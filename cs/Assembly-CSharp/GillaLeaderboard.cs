using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class GillaLeaderboard : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass21_0
	{
		public Vector3 foot;

		public GillaKeycardReader _003C_003E4__this;

		public Vector3 side;
	}

	public enum Page
	{
		// error: enumerator has no value
		Lobby,
		// error: enumerator has no value
		Friends,
		// error: enumerator has no value
		Pending,
		// error: enumerator has no value
		Blocked,
		// error: enumerator has no value
		News
	}

	public struct Row
	{
		public string name;

		public string id;

		public string uid;

		public int level;

		public Color32 colour;

		public bool you;
	}

	private struct Entry
	{
		public string id;

		public string name;

		public string info;

		public string left;

		public string right;

		public Color32 colour;

		public int level;

		public bool you;

		public bool dim;

		public bool muted;

		public GillaFriends.Friend friend;
	}

	public const int Rows = default(int);

	public const int W = default(int);

	public const int H = default(int);

	public const int RowTop = default(int);

	public const int RowStep = default(int);

	public static readonly string[] Reasons;

	public static readonly string[] Keys;

	public static readonly string[] Titles;

	public static readonly string[] LeftWords;

	public static readonly string[] RightWords;

	public const float Hold = default(float);

	public Renderer screen;

	public PressKey[] leftKeys;

	public PressKey[] rightKeys;

	public PressKey[] muteKeys;

	public PressKey[] reportKeys;

	public PressKey[] reasonKeys;

	public GameObject reasonPanel;

	public PressKey[] pageKeys;

	public PressKey offlineKey;

	public GameObject pagePanel;

	public TextAsset titleFont;

	public TextAsset textFont;

	public AudioClip sentSound;

	public AudioClip nopeSound;

	public AudioClip doneSound;

	public AudioClip pageSound;

	public ScrollDrum drum;

	public float watchFrom;

	public Page page;

	public static List<Row> Preview;

	private static string LastReport__BackingField;

	public static bool ShotKeys;

	private static readonly int BaseMap;

	private static readonly HashSet<string> reported;

	private const int LevelRight = default(int);

	private readonly List<Row> rows;

	private readonly List<Entry> entries;

	private Texture2D tex;

	private Color32[] px;

	private MaterialPropertyBlock block;

	private ScreenFont title;

	private ScreenFont text;

	private string shown;

	private float nextRefresh;

	private float pickUntil;

	private float saidAt;

	private Row picking;

	private int chosen;

	private float sendAt;

	public const float ChangeFor = default(float);

	private string said;

	private int top;

	private readonly float[] heldSince;

	private readonly bool[] spent;

	public static string LastReport
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+30]");
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = (nint)0 + (nint)48;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public int Top => top;

	public IReadOnlyList<Row> Shown => (IReadOnlyList<Row>)rows;

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
		object obj4 = (nint)0 + (nint)40;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v9+A0]");
		object obj7 = (nint)0 + (nint)48;
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7+A0]");
		object obj9 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v8+40]");
		((HashSet<System.__Canon>)0).Clear();
	}

	public static bool Reported(string id)
	{
		//IL_001b: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I
		//IL_0097: Expected I4, but got Obj
		//IL_0080: Expected Obj, but got I
		if (string.IsNullOrEmpty(id))
		{
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+40]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+40]");
			return ((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)id);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void OnEnable()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I8
		//IL_0068: Expected Obj, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_009f: Expected Obj, but got I4
		//IL_07e3: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I8
		//IL_022d: Expected Obj, but got I
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_025d: Expected Obj, but got I4
		//IL_080a: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_03cb: Expected Obj, but got I8
		//IL_03db: Expected Obj, but got I
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_040a: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I4
		//IL_011e: Expected I, but got Obj
		//IL_070d: Expected Obj, but got I4
		//IL_0831: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I4
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_0578: Expected Obj, but got I8
		//IL_0588: Expected Obj, but got I
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_05b7: Expected Obj, but got I4
		//IL_02bb: Expected Obj, but got I
		//IL_02d7: Expected Obj, but got I4
		//IL_02dc: Expected I, but got Obj
		//IL_0144: Expected I, but got Obj
		//IL_0858: Expected Obj, but got I4
		//IL_0439: Expected Obj, but got I4
		//IL_0345: Expected Obj, but got I4
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected Obj, but got Unknown
		//IL_015e: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I4
		//IL_0180: Expected I, but got Obj
		//IL_0772: Expected Obj, but got I
		//IL_0780: Expected I, but got Obj
		//IL_0468: Expected Obj, but got I
		//IL_0484: Expected Obj, but got I4
		//IL_0489: Expected I, but got Obj
		//IL_0302: Expected I, but got Obj
		//IL_05e6: Expected Obj, but got I4
		//IL_04f2: Expected Obj, but got I4
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected Obj, but got Unknown
		//IL_031c: Expected Obj, but got I
		//IL_0325: Expected Obj, but got I4
		//IL_032e: Expected Obj, but got I4
		//IL_0336: Expected I, but got Obj
		//IL_0615: Expected Obj, but got I
		//IL_0631: Expected Obj, but got I4
		//IL_0636: Expected I, but got Obj
		//IL_04af: Expected I, but got Obj
		//IL_069f: Expected Obj, but got I4
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected Obj, but got Unknown
		//IL_04c9: Expected Obj, but got I
		//IL_04d2: Expected Obj, but got I4
		//IL_04db: Expected Obj, but got I4
		//IL_04e3: Expected I, but got Obj
		//IL_065c: Expected I, but got Obj
		//IL_0676: Expected Obj, but got I
		//IL_067f: Expected Obj, but got I4
		//IL_0688: Expected Obj, but got I4
		//IL_0690: Expected I, but got Obj
		PressKey[] array = muteKeys;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
		object obj2 = 0;
		if (array.Length < 1)
		{
			goto IL_01db;
		}
		object obj3 = array.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1798]");
		object obj4 = 0;
		object obj5 = array + 32;
		Action<System.__Canon> action2 = default;
		Action<System.__Canon> action = action2;
		object obj7 = default;
		object obj6 = obj7;
		object obj9 = default;
		object obj8 = obj9;
		nint num = default;
		IntPtr intPtr = num;
		object obj10 = 0;
		Action<System.__Canon> action3 = default;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
			object obj11 = !flag;
			if (obj11 != null)
			{
				break;
			}
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v51+E4]");
			bool flag2 = (nint)0 == 0;
			object obj13 = !flag2;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X27_v11+v127 @ X25_v18*8]");
			bool flag3 = (UnityEngine.Object)0 != null;
			bool flag4 = !flag3;
			obj9 = 0;
			num = unchecked((nint)null);
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				action3._002Ector((object)this, (IntPtr)obj4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X27_v11+v127 @ X25_v18*8]");
				((PressKey)0).Pressed += (Action<PressKey>)action3;
				action = action3;
				obj6 = 0;
				obj9 = 0;
				num = (nint)action3;
			}
			obj3 = array.Length;
			obj10++;
			bool flag5 = (nint)obj10 < array.Length;
			action2 = action;
			obj7 = obj6;
			obj8 = obj9;
			intPtr = num;
			if (flag5)
			{
				continue;
			}
			goto IL_01db;
		}
		goto IL_07a6;
		IL_06e3:
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v10+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (offlineKey != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D17A0]");
			object obj16 = 0;
			Action<System.__Canon> action4 = default;
			action4._002Ector((object)this, (IntPtr)obj16);
			offlineKey.Pressed += (Action<PressKey>)action4;
		}
		Redraw(force: true);
		return;
		IL_07a6:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_01db:
		PressKey[] array2 = reportKeys;
		if (array2.Length < 1)
		{
			goto IL_0389;
		}
		object obj17 = array2.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D17B8]");
		object obj18 = 0;
		object obj19 = array2 + 32;
		object obj20 = obj7;
		object obj21 = obj9;
		IntPtr intPtr2 = num;
		object obj22 = 0;
		Action<System.__Canon> action5 = default;
		while (true)
		{
			bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17);
			object obj23 = !flag7;
			if (obj23 != null)
			{
				break;
			}
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v41+E4]");
			bool flag8 = (nint)0 == 0;
			object obj25 = !flag8;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X27_v10+v129 @ X25_v15*8]");
			bool flag9 = (UnityEngine.Object)0 != null;
			bool flag10 = !flag9;
			obj9 = 0;
			num = unchecked((nint)null);
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				action5._002Ector((object)this, (IntPtr)obj18);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X27_v10+v129 @ X25_v15*8]");
				((PressKey)0).Pressed += (Action<PressKey>)action5;
				obj20 = 0;
				obj9 = 0;
				num = (nint)action5;
			}
			obj17 = array2.Length;
			obj22++;
			bool flag11 = (nint)obj22 < array2.Length;
			obj7 = obj20;
			obj21 = obj9;
			intPtr2 = num;
			if (flag11)
			{
				continue;
			}
			goto IL_0389;
		}
		goto IL_07a6;
		IL_0536:
		PressKey[] array3 = pageKeys;
		if (array3.Length < 1)
		{
			goto IL_06e3;
		}
		object obj26 = array3.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D17A8]");
		object obj27 = 0;
		object obj28 = array3 + 32;
		object obj29 = obj7;
		object obj30 = obj9;
		IntPtr intPtr3 = num;
		object obj31 = 0;
		Action<System.__Canon> action6 = default;
		while (true)
		{
			bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj31) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26);
			object obj32 = !flag12;
			if (obj32 != null)
			{
				break;
			}
			object obj33 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X0_v21+E4]");
			bool flag13 = (nint)0 == 0;
			object obj34 = !flag13;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X27_v8+v133 @ X25_v9*8]");
			bool flag14 = (UnityEngine.Object)0 != null;
			bool flag15 = !flag14;
			obj9 = 0;
			num = unchecked((nint)null);
			if (!flag15)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				action6._002Ector((object)this, (IntPtr)obj27);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X27_v8+v133 @ X25_v9*8]");
				((PressKey)0).Pressed += (Action<PressKey>)action6;
				obj29 = 0;
				obj9 = 0;
				num = (nint)action6;
			}
			obj26 = array3.Length;
			obj31++;
			bool flag16 = (nint)obj31 < array3.Length;
			obj7 = obj29;
			obj30 = obj9;
			intPtr3 = num;
			if (flag16)
			{
				continue;
			}
			goto IL_06e3;
		}
		goto IL_07a6;
		IL_0389:
		PressKey[] array4 = reasonKeys;
		if (array4.Length < 1)
		{
			goto IL_0536;
		}
		object obj35 = array4.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D17B0]");
		object obj36 = 0;
		object obj37 = array4 + 32;
		object obj38 = obj7;
		object obj39 = obj9;
		IntPtr intPtr4 = num;
		object obj40 = 0;
		Action<System.__Canon> action7 = default;
		while (true)
		{
			bool flag17 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj35);
			object obj41 = !flag17;
			if (obj41 != null)
			{
				break;
			}
			object obj42 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X0_v31+E4]");
			bool flag18 = (nint)0 == 0;
			object obj43 = !flag18;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X27_v9+v131 @ X25_v12*8]");
			bool flag19 = (UnityEngine.Object)0 != null;
			bool flag20 = !flag19;
			obj9 = 0;
			num = unchecked((nint)null);
			if (!flag20)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				action7._002Ector((object)this, (IntPtr)obj36);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X27_v9+v131 @ X25_v12*8]");
				((PressKey)0).Pressed += (Action<PressKey>)action7;
				obj38 = 0;
				obj9 = 0;
				num = (nint)action7;
			}
			obj35 = array4.Length;
			obj40++;
			bool flag21 = (nint)obj40 < array4.Length;
			obj7 = obj38;
			obj39 = obj9;
			intPtr4 = num;
			if (flag21)
			{
				continue;
			}
			goto IL_0536;
		}
		goto IL_07a6;
	}

	private void OnDisable()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I8
		//IL_0068: Expected Obj, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_009f: Expected Obj, but got I4
		//IL_07d2: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I8
		//IL_022d: Expected Obj, but got I
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_025d: Expected Obj, but got I4
		//IL_07f9: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_03cb: Expected Obj, but got I8
		//IL_03db: Expected Obj, but got I
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_040a: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I4
		//IL_011e: Expected I, but got Obj
		//IL_070d: Expected Obj, but got I4
		//IL_0820: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I4
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_0578: Expected Obj, but got I8
		//IL_0588: Expected Obj, but got I
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_05b7: Expected Obj, but got I4
		//IL_02bb: Expected Obj, but got I
		//IL_02d7: Expected Obj, but got I4
		//IL_02dc: Expected I, but got Obj
		//IL_0144: Expected I, but got Obj
		//IL_0847: Expected Obj, but got I4
		//IL_0439: Expected Obj, but got I4
		//IL_0345: Expected Obj, but got I4
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected Obj, but got Unknown
		//IL_015e: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I4
		//IL_0180: Expected I, but got Obj
		//IL_0771: Expected Obj, but got I
		//IL_077f: Expected I, but got Obj
		//IL_0468: Expected Obj, but got I
		//IL_0484: Expected Obj, but got I4
		//IL_0489: Expected I, but got Obj
		//IL_0302: Expected I, but got Obj
		//IL_05e6: Expected Obj, but got I4
		//IL_04f2: Expected Obj, but got I4
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected Obj, but got Unknown
		//IL_031c: Expected Obj, but got I
		//IL_0325: Expected Obj, but got I4
		//IL_032e: Expected Obj, but got I4
		//IL_0336: Expected I, but got Obj
		//IL_0615: Expected Obj, but got I
		//IL_0631: Expected Obj, but got I4
		//IL_0636: Expected I, but got Obj
		//IL_04af: Expected I, but got Obj
		//IL_069f: Expected Obj, but got I4
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected Obj, but got Unknown
		//IL_04c9: Expected Obj, but got I
		//IL_04d2: Expected Obj, but got I4
		//IL_04db: Expected Obj, but got I4
		//IL_04e3: Expected I, but got Obj
		//IL_065c: Expected I, but got Obj
		//IL_0676: Expected Obj, but got I
		//IL_067f: Expected Obj, but got I4
		//IL_0688: Expected Obj, but got I4
		//IL_0690: Expected I, but got Obj
		PressKey[] array = muteKeys;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
		object obj2 = 0;
		if (array.Length < 1)
		{
			goto IL_01db;
		}
		object obj3 = array.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1798]");
		object obj4 = 0;
		object obj5 = array + 32;
		Action<System.__Canon> action2 = default;
		Action<System.__Canon> action = action2;
		object obj7 = default;
		object obj6 = obj7;
		object obj9 = default;
		object obj8 = obj9;
		nint num = default;
		IntPtr intPtr = num;
		object obj10 = 0;
		Action<System.__Canon> action3 = default;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
			object obj11 = !flag;
			if (obj11 != null)
			{
				break;
			}
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v49+E4]");
			bool flag2 = (nint)0 == 0;
			object obj13 = !flag2;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X27_v12+v127 @ X25_v19*8]");
			bool flag3 = (UnityEngine.Object)0 != null;
			bool flag4 = !flag3;
			obj9 = 0;
			num = unchecked((nint)null);
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				action3._002Ector((object)this, (IntPtr)obj4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X27_v12+v127 @ X25_v19*8]");
				((PressKey)0).Pressed -= (Action<PressKey>)action3;
				action = action3;
				obj6 = 0;
				obj9 = 0;
				num = (nint)action3;
			}
			obj3 = array.Length;
			obj10++;
			bool flag5 = (nint)obj10 < array.Length;
			action2 = action;
			obj7 = obj6;
			obj8 = obj9;
			intPtr = num;
			if (flag5)
			{
				continue;
			}
			goto IL_01db;
		}
		goto IL_0795;
		IL_0536:
		PressKey[] array2 = pageKeys;
		if (array2.Length < 1)
		{
			goto IL_06e3;
		}
		object obj14 = array2.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D17A8]");
		object obj15 = 0;
		object obj16 = array2 + 32;
		object obj17 = obj7;
		object obj18 = obj9;
		IntPtr intPtr2 = num;
		object obj19 = 0;
		Action<System.__Canon> action4 = default;
		while (true)
		{
			bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14);
			object obj20 = !flag6;
			if (obj20 != null)
			{
				break;
			}
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v19+E4]");
			bool flag7 = (nint)0 == 0;
			object obj22 = !flag7;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X27_v9+v133 @ X25_v10*8]");
			bool flag8 = (UnityEngine.Object)0 != null;
			bool flag9 = !flag8;
			obj9 = 0;
			num = unchecked((nint)null);
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				action4._002Ector((object)this, (IntPtr)obj15);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X27_v9+v133 @ X25_v10*8]");
				((PressKey)0).Pressed -= (Action<PressKey>)action4;
				obj17 = 0;
				obj9 = 0;
				num = (nint)action4;
			}
			obj14 = array2.Length;
			obj19++;
			bool flag10 = (nint)obj19 < array2.Length;
			obj7 = obj17;
			obj18 = obj9;
			intPtr2 = num;
			if (flag10)
			{
				continue;
			}
			goto IL_06e3;
		}
		goto IL_0795;
		IL_01db:
		PressKey[] array3 = reportKeys;
		if (array3.Length < 1)
		{
			goto IL_0389;
		}
		object obj23 = array3.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D17B8]");
		object obj24 = 0;
		object obj25 = array3 + 32;
		object obj26 = obj7;
		object obj27 = obj9;
		IntPtr intPtr3 = num;
		object obj28 = 0;
		Action<System.__Canon> action5 = default;
		while (true)
		{
			bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23);
			object obj29 = !flag11;
			if (obj29 != null)
			{
				break;
			}
			object obj30 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X0_v39+E4]");
			bool flag12 = (nint)0 == 0;
			object obj31 = !flag12;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X27_v11+v129 @ X25_v16*8]");
			bool flag13 = (UnityEngine.Object)0 != null;
			bool flag14 = !flag13;
			obj9 = 0;
			num = unchecked((nint)null);
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				action5._002Ector((object)this, (IntPtr)obj24);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X27_v11+v129 @ X25_v16*8]");
				((PressKey)0).Pressed -= (Action<PressKey>)action5;
				obj26 = 0;
				obj9 = 0;
				num = (nint)action5;
			}
			obj23 = array3.Length;
			obj28++;
			bool flag15 = (nint)obj28 < array3.Length;
			obj7 = obj26;
			obj27 = obj9;
			intPtr3 = num;
			if (flag15)
			{
				continue;
			}
			goto IL_0389;
		}
		goto IL_0795;
		IL_0795:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_0389:
		PressKey[] array4 = reasonKeys;
		if (array4.Length < 1)
		{
			goto IL_0536;
		}
		object obj32 = array4.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D17B0]");
		object obj33 = 0;
		object obj34 = array4 + 32;
		object obj35 = obj7;
		object obj36 = obj9;
		IntPtr intPtr4 = num;
		object obj37 = 0;
		Action<System.__Canon> action6 = default;
		while (true)
		{
			bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj37) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32);
			object obj38 = !flag16;
			if (obj38 != null)
			{
				break;
			}
			object obj39 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X0_v29+E4]");
			bool flag17 = (nint)0 == 0;
			object obj40 = !flag17;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X27_v10+v131 @ X25_v13*8]");
			bool flag18 = (UnityEngine.Object)0 != null;
			bool flag19 = !flag18;
			obj9 = 0;
			num = unchecked((nint)null);
			if (!flag19)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				action6._002Ector((object)this, (IntPtr)obj33);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X27_v10+v131 @ X25_v13*8]");
				((PressKey)0).Pressed -= (Action<PressKey>)action6;
				obj35 = 0;
				obj9 = 0;
				num = (nint)action6;
			}
			obj32 = array4.Length;
			obj37++;
			bool flag20 = (nint)obj37 < array4.Length;
			obj7 = obj35;
			obj36 = obj9;
			intPtr4 = num;
			if (flag20)
			{
				continue;
			}
			goto IL_0536;
		}
		goto IL_0795;
		IL_06e3:
		object obj41 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X0_v10+E4]");
		bool flag21 = (nint)0 == 0;
		object obj42 = !flag21;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (offlineKey != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D17A0]");
			object obj43 = 0;
			Action<System.__Canon> action7 = default;
			action7._002Ector((object)this, (IntPtr)obj43);
			offlineKey.Pressed -= (Action<PressKey>)action7;
		}
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0556: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got I4
		//IL_03ae: Expected Obj, but got I4
		//IL_02dc: Expected Obj, but got I
		//IL_02f2: Expected I4, but got Obj
		//IL_02ff: Expected Obj, but got I4
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected I4, but got Unknown
		//IL_035d: Expected Obj, but got I4
		//IL_0465: Expected I4, but got I8
		//IL_047f: Expected Obj, but got I4
		//IL_05b5: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I
		//IL_01fe: Expected Obj, but got I4
		//IL_05db: Expected Obj, but got I4
		//IL_0520: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Application.isPlaying)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		Camera main = Camera.main;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = main != null;
		bool flag4 = !flag3;
		UnityEngine.Object obj7 = null;
		if (!flag4)
		{
			Transform transform = main.transform;
			Vector3 position = transform.position;
			Transform transform2 = base.transform;
			Vector3 position2 = transform2.position;
			float num2 = default;
			float num = num2 - num2;
			float num4 = default;
			float num3 = num4 - num4;
			float num6 = default;
			float num5 = num6 - num6;
			float num7 = num * num;
			float num8 = num3 * num3;
			float num9 = num7 + num8;
			float num10 = num5 * num5;
			num2 = num10 + num9;
			num4 = watchFrom * watchFrom;
			bool flag5 = !(num2 < num4);
			obj7 = null;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
				object obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v40+E4]");
				bool flag6 = (nint)0 == 0;
				object obj10 = !flag6;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaFriends.Watched();
				obj7 = null;
			}
		}
		bool flag7 = Holds();
		object obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v8+E4]");
		bool flag8 = (nint)0 == 0;
		object obj12 = !flag8;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17;
		if (drum != null)
		{
			int step = drum.Step;
			List<Entry> list = entries;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v16 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
			object obj13 = -10;
			object obj14 = ~obj13;
			int num11 = obj13 & obj14;
			object obj15 = step - num11;
			bool flag9 = (nint)obj15 < 0;
			int num12 = step ^ num11;
			int num13 = step ^ obj15;
			int num14 = num12 & num13;
			bool flag10 = num14 < 0;
			bool flag11 = flag9 == flag10;
			object obj16 = !flag11;
			object obj17 = ~obj16;
			if (obj17 == null)
			{
				num11 = step;
			}
			bool flag12 = step < 0;
			int num15 = step ^ step;
			int num16 = step & num15;
			bool flag13 = num16 < 0;
			bool flag14 = flag12 == flag13;
			object obj18 = !flag14;
			object obj19 = ~obj18;
			if (obj19 == null)
			{
				num11 = 0;
			}
			object obj20 = num11 - top;
			bool flag15 = obj20 == null;
			bool flag16 = !flag7;
			flag17 = flag15;
			if (flag16)
			{
				goto IL_03c5;
			}
		}
		else
		{
			bool flag18 = !flag7;
			object obj21 = !flag18;
			flag17 = true;
			if (obj21 == null)
			{
				goto IL_03c5;
			}
		}
		goto IL_0405;
		IL_0405:
		float time = Time.time;
		float num17 = time + 0.25f;
		nextRefresh = num17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLeaderboard)+108]");
		if ((nint)0 != 0)
		{
			int num18 = (int)(chosen & 0x80000000L);
			bool flag19 = num18 == 0;
			object obj22 = !flag19;
			if (obj22 == null)
			{
				float time2 = Time.time;
				if (!(time2 < sendAt))
				{
					SendReport(null);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLeaderboard)+108]");
			if ((nint)0 != 0)
			{
				float time3 = Time.time;
				if (time3 > pickUntil)
				{
					_ = 0;
					picking = (Row)0;
					_ = 0;
				}
			}
		}
		Redraw(force: false);
		return;
		IL_03c5:
		if (flag17)
		{
			float time4 = Time.time;
			if (time4 < nextRefresh)
			{
				return;
			}
		}
		goto IL_0405;
	}

	public void Refresh()
	{
		Redraw(force: true);
	}

	private unsafe bool Target(PressKey[] keys, PressKey key, out Row row)
	{
		//IL_01fe: Expected I4, but got I8
		//IL_0218: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_01c6: Expected I4, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got I4
		int num = Array.IndexOf((System.__Canon[])(object)keys, (System.__Canon)(object)key);
		_ = 0;
		ref Row reference = ref *(Row*)null;
		_ = 0;
		int num2 = (int)(num & 0x80000000L);
		bool flag = num2 == 0;
		object obj = !flag;
		if (obj == null)
		{
			bool flag2 = page == 0;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				List<Row> list = rows;
				if (rows == null)
				{
					goto IL_01b8;
				}
				int num3 = top + num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X9_v3 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
				if ((nint)num3 < (nint)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D18D8]");
					object obj3 = 0;
					Row row2 = rows.get_Item(num3);
					object obj5 = default;
					object obj4 = obj5 & 1;
					bool flag3 = obj4 == null;
					object obj6 = !flag3;
					if (obj6 == null)
					{
						if (rows != null)
						{
							Row row3 = rows.get_Item(num3);
							string value = default;
							if (string.IsNullOrEmpty(value))
							{
								goto IL_0149;
							}
							if (rows != null)
							{
								Row row4 = rows.get_Item(num3);
								object obj7 = default;
								reference = ref *(Row*)obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								return true;
							}
						}
						goto IL_01b8;
					}
				}
			}
		}
		goto IL_0149;
		IL_0149:
		return false;
		IL_01b8:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void Sound(AudioClip clip, PressKey key, float volume)
	{
		//IL_0010: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_017c: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I4
		//IL_01dd: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(clip != null))
		{
			return;
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(key != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		AudioClip[] array = default;
		if (array != null)
		{
			object obj7 = array + 32;
			obj7 = clip;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if ((object)key != null)
			{
				Transform transform = key.transform;
				if ((object)transform != null)
				{
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
					object obj8 = 0;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v23+E4]");
					bool flag3 = (nint)0 == 0;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float pitchMin = default;
					float pitchMax = default;
					Sfx.Play(array, (Vector3)0, volume, pitchMin, pitchMax);
					return;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void OnMute(PressKey key)
	{
		//IL_0251: Expected Obj, but got I4
		//IL_00ad: Expected F4, but got I
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected I4, but got Unknown
		//IL_016a: Expected Obj, but got I4
		//IL_01cb: Expected Obj, but got I
		//IL_01d6: Expected Obj, but got I4
		//IL_0202: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		bool flag = Target(muteKeys, key, out var _);
		bool flag2 = !flag;
		GillaLeaderboard gillaLeaderboard = (GillaLeaderboard)flag;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj3 = !flag3;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string id = default;
			bool flag4 = GillaFriends.IsBlocked(id);
			bool flag5 = !flag4;
			gillaLeaderboard = (GillaLeaderboard)flag4;
			if (flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v10+E4]");
				bool flag6 = (nint)0 == 0;
				object obj6 = !flag6;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag7 = MutedRow(id, null);
				object obj7 = !flag7;
				bool now = (byte)(1 & obj7) != 0;
				bool flag8 = GillaMutes.Set(id, now);
				bool flag9 = string.IsNullOrEmpty(null);
				bool flag10 = !flag9;
				object obj8 = !flag10;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA828]");
					object obj9 = 0;
					string id2 = (string)obj9 + null;
					bool flag11 = GillaMutes.Set(id2, flag8);
				}
				bool flag12 = !flag8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6B8]");
				object obj10 = 0;
				object obj11 = !flag12;
				object obj12 = ~obj11;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D18E0]");
					obj10 = 0;
				}
				string text = (string)obj10 + null;
				said = text;
				object obj13 = this + 304;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				float unscaledTime = Time.unscaledTime;
				saidAt = unscaledTime;
				Redraw(force: false);
				return;
			}
		}
		GillaLeaderboard gillaLeaderboard2 = gillaLeaderboard;
		AudioClip clip = nopeSound;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		gillaLeaderboard2.Sound(clip, key, 0f);
	}

	private static bool MutedRow(string id, string uid)
	{
		//IL_005b: Expected Obj, but got I
		if (GillaMutes.IsMuted(id))
		{
			return true;
		}
		if (string.IsNullOrEmpty(uid))
		{
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA828]");
		object obj = 0;
		string id2 = (string)obj + uid;
		return GillaMutes.IsMuted(id2);
	}

	private void OnReport(PressKey key)
	{
		//IL_007c: Expected Obj, but got I4
		//IL_0132: Expected F4, but got I
		//IL_0019: Expected I4, but got I8
		//IL_0033: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I
		//IL_00c4: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0171: Expected I4, but got I8
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_019a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLeaderboard)+108]");
		if ((nint)0 != 0)
		{
			int num = (int)(chosen & 0x80000000L);
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				SendReport(null);
			}
		}
		bool flag2 = Target(reportKeys, key, out var row);
		bool flag3 = !flag2;
		GillaLeaderboard gillaLeaderboard = (GillaLeaderboard)flag2;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj4 = !flag4;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string id = default;
			bool flag5 = Reported(id);
			bool flag6 = !flag5;
			gillaLeaderboard = (GillaLeaderboard)flag5;
			if (flag6)
			{
				object obj5 = this + 256;
				picking = row;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				chosen = -1;
				float time = Time.time;
				object obj6 = this + 304;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj7 = 0;
				float num2 = time + 20f;
				said = (string)obj7;
				pickUntil = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Redraw(force: false);
				return;
			}
		}
		GillaLeaderboard gillaLeaderboard2 = gillaLeaderboard;
		AudioClip clip = nopeSound;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		gillaLeaderboard2.Sound(clip, key, 0f);
	}

	private void OnReason(PressKey key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02cb: Expected I4, but got I8
		//IL_02e5: Expected Obj, but got I4
		//IL_010f: Expected F4, but got I
		//IL_010f: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I4
		//IL_0303: Expected Obj, but got I
		//IL_0124: Expected I4, but got I8
		//IL_013e: Expected Obj, but got I4
		//IL_0325: Expected I4, but got I8
		//IL_0330: Expected VT, but got I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got I
		//IL_01f7: Invalid comparison between F4 and I4
		//IL_0206: Invalid comparison between F4 and I4
		//IL_021b: Expected Obj, but got F4
		//IL_022a: Expected Obj, but got F4
		//IL_025f: Expected Obj, but got I4
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6168]");
		object obj = 0;
		PressKey pressKey = (PressKey)obj;
		int num = Array.IndexOf((System.__Canon[])(object)reasonKeys, (System.__Canon)(object)key);
		int num2 = (int)(num & 0x80000000L);
		bool flag = num2 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLeaderboard)+108]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
				object obj3 = 0;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v5+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj4 = obj3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v5+A0]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v8+18]");
				if ((nint)num < (nint)0)
				{
					if (num == chosen)
					{
						SendReport(key);
					}
					else
					{
						chosen = num;
						float time = Time.time;
						float num3 = time + 6f;
						float num4 = num3 + 1f;
						sendAt = num3;
						float num5 = pickUntil - num4;
						bool flag3 = num5 < 0f;
						bool flag4 = num5 == 0f;
						object obj8 = pickUntil ^ num4;
						object obj9 = pickUntil ^ num5;
						object obj10 = obj8 & obj9;
						bool flag5 = (nint)obj10 < 0;
						bool flag6 = flag3 == flag5;
						object obj11 = !flag4;
						object obj12 = flag6 & obj11;
						object obj13 = ~obj12;
						if (obj13 == null)
						{
							num4 = pickUntil;
						}
						pickUntil = num4;
						((GillaLeaderboard)null).Sound(pageSound, key, 0.5f);
						pressKey = key;
					}
				}
				else
				{
					int num6 = (int)(chosen & 0x80000000L);
					bool flag7 = num6 == 0;
					object obj14 = !flag7;
					if (obj14 == null)
					{
						object obj15 = this + 304;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D18E8]");
						object obj16 = 0;
						said = (string)obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						float unscaledTime = Time.unscaledTime;
						saidAt = unscaledTime;
					}
					_ = 0;
					chosen = -1;
					picking = (Row)0;
					_ = 0;
				}
				Redraw(force: false);
				return;
			}
		}
		AudioClip clip = nopeSound;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		((GillaLeaderboard)num).Sound(clip, key, 0f);
	}

	private void SendReport(PressKey key)
	{
		//IL_0cad: Expected I4, but got I8
		//IL_0cb8: Expected VT, but got I4
		//IL_0019: Expected I4, but got I8
		//IL_0033: Expected Obj, but got I4
		//IL_0051: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I4
		//IL_0cf4: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I
		//IL_0d2b: Expected Obj, but got I4
		//IL_0ebb: Expected Obj, but got I
		//IL_0ecb: Expected Obj, but got I
		//IL_0eed: Expected Obj, but got I
		//IL_01e7: Expected Obj, but got I4
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_0241: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I8
		//IL_0292: Expected Obj, but got I
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_02d4: Expected Obj, but got I4
		//IL_02ea: Expected Obj, but got I
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_0335: Expected Obj, but got VT
		//IL_0359: Expected Obj, but got I8
		//IL_0386: Expected Obj, but got I
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_03d6: Expected Obj, but got I4
		//IL_03ec: Expected Obj, but got I
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected Obj, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected Obj, but got Unknown
		//IL_0461: Expected Obj, but got I4
		//IL_0477: Expected Obj, but got I
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_04ba: Expected Obj, but got I
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected Obj, but got Unknown
		//IL_04ea: Expected Obj, but got I
		//IL_0514: Expected Obj, but got I4
		//IL_0543: Expected Obj, but got I
		//IL_058f: Expected Obj, but got I
		//IL_0d55: Expected Obj, but got I4
		//IL_0d65: Expected Obj, but got I4
		//IL_0d85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8a: Expected Obj, but got Unknown
		//IL_057a: Expected Obj, but got I
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected Obj, but got Unknown
		//IL_05d6: Expected Obj, but got I
		//IL_05ef: Expected Obj, but got I
		//IL_061d: Expected Obj, but got I4
		//IL_0dc2: Expected Obj, but got I4
		//IL_0f10: Expected Obj, but got I
		//IL_0f32: Expected Obj, but got I
		//IL_0f47: Expected Obj, but got I
		//IL_0f5b: Expected Obj, but got I
		//IL_0729: Expected Obj, but got I
		//IL_0753: Expected Obj, but got I4
		//IL_0785: Expected Obj, but got I
		//IL_0793: Expected Obj, but got I4
		//IL_0839: Expected Obj, but got I4
		//IL_0680: Expected Obj, but got I
		//IL_06ae: Expected Obj, but got I4
		//IL_06dd: Expected Obj, but got I
		//IL_0e52: Expected Obj, but got I4
		//IL_07b0: Expected Obj, but got I
		//IL_0f88: Expected Obj, but got I
		//IL_0f98: Expected Obj, but got I
		//IL_0fad: Expected Obj, but got I
		//IL_0fc1: Expected Obj, but got I
		//IL_0feb: Expected Obj, but got I4
		//IL_0de0: Expected Obj, but got I
		//IL_0df8: Expected Obj, but got I
		//IL_0e1a: Expected Obj, but got I4
		//IL_0714: Expected Obj, but got I
		//IL_08b4: Expected Obj, but got I4
		//IL_07df: Expected Obj, but got VT
		//IL_0802: Expected Obj, but got I4
		//IL_08f9: Expected Obj, but got I4
		//IL_0e7f: Expected F4, but got I
		//IL_0e7f: Expected Obj, but got I4
		//IL_099e: Expected Obj, but got I
		//IL_09a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ac: Expected Obj, but got Unknown
		//IL_09d8: Expected Obj, but got I8
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Expected Obj, but got Unknown
		//IL_0960: Expected Obj, but got I
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Expected Obj, but got Unknown
		//IL_0a0d: Expected Obj, but got VT
		//IL_0a39: Expected Obj, but got I4
		//IL_0a4f: Expected Obj, but got I
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a74: Expected Obj, but got Unknown
		//IL_0a92: Expected Obj, but got I
		//IL_0a9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Expected Obj, but got Unknown
		//IL_0adc: Expected Obj, but got I4
		//IL_0e9e: Expected Obj, but got I
		//IL_0b24: Expected Obj, but got I4
		//IL_0b46: Expected Obj, but got I8
		//IL_0b6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b72: Expected Obj, but got Unknown
		//IL_0b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b80: Expected Obj, but got Unknown
		//IL_0b90: Expected Obj, but got I
		//IL_0bbc: Expected Obj, but got I4
		//IL_0bd2: Expected Obj, but got I
		//IL_0bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf7: Expected Obj, but got Unknown
		//IL_0c15: Expected Obj, but got I
		//IL_0c1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c23: Expected Obj, but got Unknown
		//IL_0c57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5c: Expected Obj, but got Unknown
		_ = 0;
		chosen = -1;
		picking = (Row)0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLeaderboard)+108]");
		if ((nint)0 == 0)
		{
			return;
		}
		int num = (int)(chosen & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v4+A0]");
		object obj5 = 0;
		object obj6 = obj5;
		int num2 = chosen;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X9_v2+18]");
		if ((nint)num2 >= (nint)0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v85+A0]");
			obj5 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46C0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v8+40]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLeaderboard)+108]");
		bool flag4 = ((HashSet<System.__Canon>)num3).Add((System.__Canon)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v10+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v14+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v14+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v16+A0]");
		object obj18 = 0;
		object obj19 = obj18;
		int num4 = chosen;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v18+18]");
		bool flag7 = (nint)num4 < (nint)0;
		object obj20 = !flag7;
		string[] array = default;
		if (obj20 == null && array.Length != 0)
		{
			object obj21 = obj19 + chosen;
			object obj22 = array + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v20+20]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X25_v6-8]");
			object obj23 = 0 & 0xFFFFFFFEL;
			if (obj23 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF700]");
				object obj24 = 0;
				object obj25 = array + 40;
				obj25 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X25_v8-10]");
				bool flag8 = (nint)0 < (nint)2;
				object obj26 = !flag8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X25_v8-10]");
				object obj27 = -2;
				bool flag9 = obj27 == null;
				object obj28 = ~obj26;
				object obj29 = obj28 | flag9;
				if (obj29 == null)
				{
					object obj30 = array + 48;
					obj30 = picking;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X25_v10-18]");
					object obj31 = 0 & 0xFFFFFFFCL;
					if (obj31 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D18C8]");
						object obj32 = 0;
						object obj33 = array + 56;
						obj33 = obj32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						string real = GillaName.Real;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X25_v12-20]");
						bool flag10 = (nint)0 < (nint)4;
						object obj34 = !flag10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X25_v12-20]");
						object obj35 = -4;
						bool flag11 = obj35 == null;
						object obj36 = ~obj34;
						object obj37 = obj36 | flag11;
						if (obj37 == null)
						{
							object obj38 = array + 64;
							obj38 = real;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X25_v14-28]");
							bool flag12 = (nint)0 < (nint)5;
							object obj39 = !flag12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X25_v14-28]");
							object obj40 = -5;
							bool flag13 = obj40 == null;
							object obj41 = ~obj39;
							object obj42 = obj41 | flag13;
							if (obj42 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D18B8]");
								object obj43 = 0;
								object obj44 = array + 72;
								obj44 = obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
								object obj45 = 0;
								object obj46 = obj45;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v34+E4]");
								bool flag14 = (nint)0 == 0;
								object obj47 = !flag14;
								if (obj47 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v15+8]");
								object obj48;
								if ((UnityEngine.Object)0 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v15+8]");
									obj48 = (nint)0 + (nint)120;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4F8]");
									obj48 = 0;
								}
								bool flag15 = array.Length < 6;
								object obj49 = !flag15;
								object obj50 = array.Length - 6;
								bool flag16 = obj50 == null;
								object obj51 = ~obj49;
								object obj52 = obj51 | flag16;
								if (obj52 == null)
								{
									object obj53 = array + 80;
									obj53 = obj48;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									string text = string.Concat(array);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
									object obj54 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLeaderboard)+108]");
									string text2 = (string)0 + (string)obj54 + text;
									object obj55 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v38+E4]");
									bool flag17 = (nint)0 == 0;
									object obj56 = !flag17;
									if (obj56 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									object obj57 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X0_v48+E4]");
									bool flag18 = (nint)0 == 0;
									object obj58 = !flag18;
									if (obj58 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj57 = obj2;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X0_v48+A0]");
									object obj59 = (nint)0 + (nint)48;
									obj59 = text2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA828]");
									object obj60 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLeaderboard)+108]");
									bool flag19 = ((string)0).StartsWith((string)obj60);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
									object obj61 = 0;
									if (flag19)
									{
										object obj62 = obj60;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLeaderboard)+108]");
										nint num5 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v74+10]");
										string targetPlayFabId = ((string)num5).Substring(0);
										object obj63 = obj61;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v75+E4]");
										bool flag20 = (nint)0 == 0;
										object obj64 = !flag20;
										if (obj64 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v15+8]");
										object roomName;
										if ((UnityEngine.Object)0 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v15+8]");
											roomName = (nint)0 + (nint)120;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
											roomName = 0;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
										object obj65 = 0;
										object obj66 = obj65;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D18B0]");
										object reason = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X0_v109+E4]");
										bool flag21 = (nint)0 == 0;
										object obj67 = !flag21;
										if (obj67 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										IEnumerator enumerator = ShiftAuth.ReportKick(targetPlayFabId, (string)picking, (string)reason, text, (string)roomName);
										Coroutine coroutine = StartCoroutine(enumerator);
										string text3 = text;
										object obj68 = 0;
										IEnumerator enumerator2 = enumerator;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
										object obj69 = 0;
										object obj70 = obj69;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X0_v100+E4]");
										bool flag22 = (nint)0 == 0;
										object obj71 = !flag22;
										if (obj71 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLeaderboard)+108]");
										GillaCloud.Reported((string)0, text);
										string text3 = null;
										object obj68 = 0;
										IEnumerator enumerator2 = (IEnumerator)(object)text;
									}
									object obj72 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X0_v55+E4]");
									bool flag23 = (nint)0 == 0;
									object obj73 = !flag23;
									if (obj73 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									object obj74 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X0_v59+E4]");
									bool flag24 = (nint)0 == 0;
									object obj75 = !flag24;
									if (obj75 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj74 = obj2;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X0_v59+A0]");
									object obj76 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D18D0]");
									object obj77 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v47+30]");
									string message = (string)obj77 + (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
									object obj78 = 0;
									object obj79 = obj78;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v50+E4]");
									bool flag25 = (nint)0 == 0;
									object obj80 = !flag25;
									if (obj80 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Debug.Log(message);
									object obj81 = obj61;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X0_v64+E4]");
									bool flag26 = (nint)0 == 0;
									object obj82 = !flag26;
									if (obj82 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag27 = key != null;
									bool flag28 = !flag27;
									object obj83 = !flag28;
									PressKey pressKey = key;
									if (obj83 == null)
									{
										PressKey[] array2 = reasonKeys;
										if (chosen < array2.Length)
										{
											object obj84 = array2 + chosen;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v69+20]");
											pressKey = (PressKey)0;
										}
										else
										{
											pressKey = null;
										}
									}
									bool flag29 = flag27;
									AudioClip clip = sentSound;
									PressKey key2 = pressKey;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
									((GillaLeaderboard)flag29).Sound(clip, key2, 0f);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									string[] array3 = default;
									if (array3.Length != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D18C0]");
										object obj85 = 0;
										object obj86 = array3 + 32;
										obj86 = obj85;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X22_v11-8]");
										object obj87 = 0 & 0xFFFFFFFEL;
										if (obj87 != null)
										{
											object obj88 = array3 + 40;
											obj88 = picking;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X22_v13-10]");
											bool flag30 = (nint)0 < (nint)2;
											object obj89 = !flag30;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X22_v13-10]");
											object obj90 = -2;
											bool flag31 = obj90 == null;
											object obj91 = ~obj89;
											object obj92 = obj91 | flag31;
											if (obj92 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6A8]");
												object obj93 = 0;
												object obj94 = array3 + 48;
												obj94 = obj93;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												object obj95 = obj2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v78+E4]");
												bool flag32 = (nint)0 == 0;
												object obj96 = !flag32;
												if (obj96 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													obj95 = obj2;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v78+A0]");
												object obj97 = 0;
												object obj98 = obj97;
												int num6 = chosen;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v63+18]");
												bool flag33 = (nint)num6 < (nint)0;
												object obj99 = !flag33;
												if (obj99 == null)
												{
													object obj100 = array3.Length & 0xFFFFFFFCL;
													if (obj100 != null)
													{
														object obj101 = obj98 + chosen;
														object obj102 = array3 + 56;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v64+20]");
														obj102 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X21_v8-20]");
														bool flag34 = (nint)0 < (nint)4;
														object obj103 = !flag34;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X21_v8-20]");
														object obj104 = -4;
														bool flag35 = obj104 == null;
														object obj105 = ~obj103;
														object obj106 = obj105 | flag35;
														if (obj106 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D18A8]");
															object obj107 = 0;
															object obj108 = array3 + 64;
															obj108 = obj107;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															string text4 = string.Concat(array3);
															said = text4;
															object obj109 = this + 304;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															float unscaledTime = Time.unscaledTime;
															saidAt = unscaledTime;
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

	private void OnPage(PressKey key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_032d: Expected I4, but got I8
		//IL_0347: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_0365: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_015b: Expected VT, but got I4
		//IL_0183: Expected Obj, but got I4
		//IL_01c8: Expected F4, but got I4
		//IL_00e6: Expected I4, but got I8
		//IL_0100: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I
		//IL_02bb: Expected Obj, but got I4
		//IL_01f4: Expected F4, but got I4
		//IL_0230: Expected Obj, but got I
		//IL_025a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6168]");
		object obj = 0;
		int num = Array.IndexOf((System.__Canon[])(object)pageKeys, (System.__Canon)(object)key);
		int num2 = (int)(num & 0x80000000L);
		bool flag = num2 == 0;
		object obj2 = !flag;
		if (obj2 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v5+8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v6+18]");
		if ((nint)num >= (nint)0)
		{
			return;
		}
		page = (Page)num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLeaderboard)+108]");
		bool flag3 = (nint)0 == 0;
		PressKey pressKey = key;
		if (!flag3)
		{
			int num3 = (int)(chosen & 0x80000000L);
			bool flag4 = num3 == 0;
			object obj8 = !flag4;
			pressKey = key;
			if (obj8 == null)
			{
				SendReport(null);
				pressKey = null;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj9 = 0;
		_ = 0;
		top = 0;
		object obj10 = obj9;
		picking = (Row)0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v10+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = drum != null;
		bool flag7 = !flag6;
		float num4 = 0f;
		UnityEngine.Object obj12 = null;
		if (!flag7)
		{
			drum.Set(0f);
			num4 = 0f;
			obj12 = null;
		}
		if (page == (Page)4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
			object obj13 = 0;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v21+E4]");
			bool flag8 = (nint)0 == 0;
			object obj15 = !flag8;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaFriends.MarkSeen();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj16 = 0;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v16+E4]");
		bool flag9 = (nint)0 == 0;
		object obj18 = !flag9;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaFriends.Refresh();
		((GillaLeaderboard)null).Sound(pageSound, key, 0.5f);
		Redraw(force: false);
	}

	private void OnOffline(PressKey key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I4, but got Unknown
		//IL_0070: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool offline = GillaFriends.Offline;
		object obj4 = !offline;
		bool flag2 = (byte)(1 & obj4) != 0;
		GillaFriends.Offline = flag2;
		((GillaLeaderboard)flag2).Sound(pageSound, key, 0.5f);
		Redraw(force: false);
	}

	private void Say(string words)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		said = words;
		object obj = this + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		float unscaledTime = Time.unscaledTime;
		saidAt = unscaledTime;
	}

	private bool Holds()
	{
		//IL_0640: Expected Obj, but got I
		//IL_0649: Expected Obj, but got I4
		//IL_0652: Expected Obj, but got I4
		//IL_065b: Expected Obj, but got I4
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected Obj, but got Unknown
		//IL_0732: Expected Obj, but got I4
		//IL_0630: Expected I4, but got Obj
		//IL_06fc: Expected Obj, but got I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_0439: Expected Obj, but got I4
		//IL_04a4: Expected Obj, but got I4
		//IL_04d8: Expected I, but got Obj
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected Obj, but got Unknown
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected Obj, but got Unknown
		//IL_0238: Expected Obj, but got I4
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected I4, but got Unknown
		//IL_0265: Expected F4, but got I
		//IL_02b1: Expected Obj, but got I4
		//IL_02e4: Expected Obj, but got I4
		//IL_0323: Expected Obj, but got I4
		//IL_03e2: Expected Obj, but got I4
		//IL_03f0: Expected I, but got Obj
		//IL_037e: Expected Obj, but got I4
		//IL_03c2: Invalid comparison between F4 and I
		//IL_0526: Expected Obj, but got I4
		//IL_0558: Expected Obj, but got I4
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Obj, but got Unknown
		//IL_058f: Expected Obj, but got I4
		//IL_059c: Expected I4, but got Obj
		//IL_05b2: Expected Obj, but got I4
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected Obj, but got Unknown
		//IL_05d1: Expected I4, but got Obj
		//IL_05ec: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = 32;
		object obj3 = 0;
		object obj4 = 0;
		while (true)
		{
			object obj5 = obj3 - 10;
			bool flag = (nint)obj3 < 10;
			object obj6 = !flag;
			object obj7 = ~obj6;
			object obj11;
			if (obj7 == null)
			{
				PressKey[] array = rightKeys;
				if (rightKeys == null)
				{
					goto IL_0614;
				}
				if ((nint)obj5 >= array.Length)
				{
					goto IL_0106;
				}
				object obj8 = obj3 - 10;
				bool flag2 = (nint)obj8 < array.Length;
				object obj9 = !flag2;
				if (obj9 != null)
				{
					break;
				}
				object obj10 = (object)rightKeys + obj5;
				obj11 = obj10 + 32;
			}
			else
			{
				PressKey[] array2 = leftKeys;
				if (leftKeys == null)
				{
					goto IL_0614;
				}
				if ((nint)obj3 >= array2.Length)
				{
					goto IL_0106;
				}
				obj11 = (object)leftKeys + obj2;
			}
			UnityEngine.Object obj12 = (UnityEngine.Object)obj11;
			goto IL_06d2;
			IL_03d9:
			obj4 = 1;
			bool flag3 = false;
			nint num = unchecked((nint)null);
			goto IL_0696;
			IL_06d2:
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v3+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = obj12 != null;
			bool flag6 = !flag5;
			UnityEngine.Object obj15 = null;
			if (flag6)
			{
				goto IL_03f5;
			}
			if ((object)obj12 != null)
			{
				GameObject gameObject = ((Component)obj12).gameObject;
				if ((object)gameObject != null)
				{
					bool activeInHierarchy = gameObject.activeInHierarchy;
					bool flag7 = !activeInHierarchy;
					obj15 = null;
					if (!flag7)
					{
						bool isDown = ((PressKey)obj12).IsDown;
						bool flag8 = !isDown;
						obj15 = null;
						if (!flag8)
						{
							float[] array3 = heldSince;
							if (heldSince != null)
							{
								bool flag9 = (nint)obj3 < array3.Length;
								object obj16 = !flag9;
								if (obj16 != null)
								{
									break;
								}
								object obj17 = (object)heldSince + obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X28_v2+20]");
								float num2 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X28_v2+20]");
								if ((nint)0 < (nint)0)
								{
									num2 = Time.time;
									bool flag10 = (nint)obj3 < array3.Length;
									object obj18 = !flag10;
									if (obj18 != null)
									{
										break;
									}
								}
								bool[] array4 = spent;
								if (spent != null)
								{
									bool flag11 = (nint)obj3 < array4.Length;
									object obj19 = !flag11;
									if (obj19 != null)
									{
										break;
									}
									object obj20 = (object)spent + obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v15+20]");
									bool flag12 = (nint)0 == 0;
									object obj21 = !flag12;
									if (obj21 != null)
									{
										goto IL_03d9;
									}
									float time = Time.time;
									float[] array5 = heldSince;
									if (heldSince != null)
									{
										bool flag13 = (nint)obj3 < array5.Length;
										object obj22 = !flag13;
										if (obj22 != null)
										{
											break;
										}
										object obj23 = (object)heldSince + obj3;
										float num3 = time;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v19+20]");
										num2 = num3 - 0f;
										float num4 = num2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
										if (num4 < 0f)
										{
											goto IL_03d9;
										}
										bool[] array6 = spent;
										if (spent != null)
										{
											bool flag14 = (nint)obj3 < array6.Length;
											object obj24 = !flag14;
											if (obj24 != null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMULH not yet implemented.\"");
											bool flag15 = (nint)obj3 < 9;
											object obj25 = !flag15;
											object obj26 = obj3 - 9;
											bool flag16 = obj26 == null;
											object obj27 = (object)spent + obj3;
											object obj28 = !flag16;
											bool flag17 = (byte)(obj25 & obj28) != 0;
											_ = 1;
											object obj29 = array6.Length >> 3;
											object obj30 = obj29 * 4294967286L;
											int num5 = (int)(obj3 + obj30);
											Act(num5, flag17, (PressKey)obj12);
											obj4 = 1;
											flag3 = flag17;
											num = num5;
											goto IL_0696;
										}
									}
								}
							}
							goto IL_0614;
						}
					}
					goto IL_03f5;
				}
			}
			goto IL_0614;
			IL_0614:
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_03f5:
			float[] array7 = heldSince;
			if (heldSince != null)
			{
				bool flag18 = (nint)obj3 < array7.Length;
				object obj31 = !flag18;
				if (obj31 != null)
				{
					break;
				}
				object obj32 = (object)heldSince + obj3;
				bool[] array8 = spent;
				_ = 3212836864L;
				if (spent != null)
				{
					bool flag19 = (nint)obj3 < array8.Length;
					object obj33 = !flag19;
					if (obj33 != null)
					{
						break;
					}
					object obj34 = (object)spent + obj3;
					_ = 0;
					flag3 = false;
					num = (nint)obj15;
					goto IL_0696;
				}
			}
			goto IL_0614;
			IL_0106:
			obj12 = null;
			goto IL_06d2;
			IL_0696:
			obj3++;
			obj2 += 8;
			if ((nint)obj3 == 20)
			{
				return (byte)(obj4 & 1) != 0;
			}
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private float Held(int row)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I4
		//IL_03f1: Expected F4, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00c3: Expected F4, but got I4
		//IL_00cc: Expected Obj, but got I4
		//IL_047e: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0152: Expected F4, but got I
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_038d: Invalid comparison between F4 and I4
		//IL_039c: Expected F4, but got I4
		//IL_01c3: Expected Obj, but got I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_020a: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I4
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_02a2: Expected Obj, but got I
		//IL_02e8: Invalid comparison between F4 and I4
		//IL_02f7: Invalid comparison between F4 and I4
		//IL_030a: Expected Obj, but got F4
		//IL_0317: Expected Obj, but got F4
		//IL_034c: Expected Obj, but got I4
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = default;
		float result;
		float num;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+18]");
				if ((nint)0 != 1)
				{
					object obj4 = row + 10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+18]");
					if ((nint)0 < (nint)1)
					{
						result = 0f;
						goto IL_0460;
					}
					object obj5 = obj2 + 32;
					num = 0f;
					object obj6 = 0;
					while (true)
					{
						bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
						object obj7 = !flag;
						if (obj7 != null)
						{
							break;
						}
						float[] array = heldSince;
						if (heldSince != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X22_v7+v160 @ X21_v7*4]");
							bool flag2 = (nint)0 < (nint)array.Length;
							object obj8 = !flag2;
							if (obj8 != null)
							{
								break;
							}
							float[] array2 = heldSince;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X22_v7+v160 @ X21_v7*4]");
							object obj9 = array2 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X9_v8+20]");
							float num2 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X9_v8+20]");
							if ((nint)0 >= (nint)0)
							{
								bool[] array3 = spent;
								if (spent == null)
								{
									goto IL_0404;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X22_v7+v160 @ X21_v7*4]");
								bool flag3 = (nint)0 < (nint)array3.Length;
								object obj10 = !flag3;
								if (obj10 != null)
								{
									break;
								}
								bool[] array4 = spent;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X22_v7+v160 @ X21_v7*4]");
								object obj11 = array4 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X9_v11+20]");
								bool flag4 = (nint)0 == 0;
								object obj12 = !flag4;
								if (obj12 == null)
								{
									num2 = Time.time;
									float[] array5 = heldSince;
									if (heldSince == null)
									{
										goto IL_0404;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X22_v7+v160 @ X21_v7*4]");
									bool flag5 = (nint)0 < (nint)array5.Length;
									object obj13 = !flag5;
									if (obj13 != null)
									{
										break;
									}
									float[] array6 = heldSince;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X22_v7+v160 @ X21_v7*4]");
									object obj14 = array6 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+18]");
									obj3 = 0;
									float num3 = num2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v10+20]");
									float num4 = num3 - 0f;
									float num5 = num4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
									num2 = num5 / 0f;
									float num6 = num - num2;
									bool flag6 = num6 < 0f;
									bool flag7 = num6 == 0f;
									object obj15 = num ^ num2;
									object obj16 = num ^ num6;
									object obj17 = obj15 & obj16;
									bool flag8 = (nint)obj17 < 0;
									bool flag9 = flag6 == flag8;
									object obj18 = !flag7;
									object obj19 = flag9 & obj18;
									object obj20 = ~obj19;
									if (obj20 != null)
									{
										num = num2;
									}
								}
							}
							obj6++;
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
							{
								continue;
							}
							goto IL_0384;
						}
						goto IL_0404;
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		goto IL_0404;
		IL_0404:
		throw new NullReferenceException();
		IL_0384:
		bool flag10 = num < 0f;
		result = 0f;
		if (!flag10)
		{
			bool flag11 = !((double)num > 1.0);
			result = num;
			if (!flag11)
			{
				result = 1f;
			}
		}
		goto IL_0460;
		IL_0460:
		return result;
	}

	private unsafe void Act(int row, bool right, PressKey key)
	{
		//IL_0043: Expected Obj, but got Ref
		//IL_006f: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I4
		//IL_08ac: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I4
		//IL_0592: Expected Obj, but got I
		//IL_05a7: Expected Obj, but got I
		//IL_035e: Expected Obj, but got I
		//IL_05d8: Expected Obj, but got I
		//IL_0602: Expected Obj, but got I4
		//IL_064a: Expected Obj, but got I
		//IL_065f: Expected Obj, but got I
		//IL_02a4: Expected Obj, but got I
		//IL_02b9: Expected Obj, but got I
		//IL_047b: Expected Obj, but got I
		//IL_0887: Expected F4, but got I
		//IL_0690: Expected Obj, but got I
		//IL_06ba: Expected Obj, but got I4
		//IL_0702: Expected Obj, but got I
		//IL_0717: Expected Obj, but got I
		//IL_02ea: Expected Obj, but got I
		//IL_0314: Expected Obj, but got I4
		//IL_03bd: Expected Obj, but got I
		//IL_03d2: Expected Obj, but got I
		//IL_0748: Expected Obj, but got I
		//IL_0772: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I
		//IL_0403: Expected Obj, but got I
		//IL_042d: Expected Obj, but got I4
		//IL_04da: Expected Obj, but got I
		//IL_04ef: Expected Obj, but got I
		//IL_07bd: Expected Obj, but got I
		//IL_07d2: Expected Obj, but got I
		//IL_0520: Expected Obj, but got I
		//IL_054a: Expected Obj, but got I4
		//IL_0803: Expected Obj, but got I
		//IL_082d: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I
		//IL_01ba: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I4
		List<Entry> list = entries;
		int num = top + row;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
		if ((nint)num >= (nint)0)
		{
			return;
		}
		string text = default;
		object obj = (object)(&text);
		Entry entry = list.get_Item(num);
		bool flag = !right;
		object obj2 = !flag;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			object obj4 = 32;
		}
		else
		{
			object obj4 = 24;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v4+v252 @ X8_v9]");
		string text2 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v4+v252 @ X8_v9]");
		if ((nint)0 == 0)
		{
			return;
		}
		string text3 = default;
		GillaLeaderboard gillaLeaderboard;
		if (text2._stringLength > 4)
		{
			if (text2._stringLength != 5)
			{
				bool yes;
				string text4;
				string text5;
				if (text2._stringLength != 7)
				{
					if (text2._stringLength != 6)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v4+v252 @ X8_v9]");
					char c = ((string)0).get_Chars(0);
					int num2 = c & 0xFFFF;
					if (num2 != 65)
					{
						if (num2 == 67)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D18F8]");
							object obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v4+v252 @ X8_v9]");
							if ((string)0 == (string)obj5)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
								object obj6 = 0;
								object obj7 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v58+E4]");
								bool flag2 = (nint)0 == 0;
								object obj8 = !flag2;
								if (obj8 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								GillaFriends.Cancel(text, text3);
								gillaLeaderboard = (GillaLeaderboard)(object)text;
								goto IL_0868;
							}
							return;
						}
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1928]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v4+v252 @ X8_v9]");
					if (!((string)0 == (string)obj9))
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
					object obj10 = 0;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v52+E4]");
					bool flag3 = (nint)0 == 0;
					object obj12 = !flag3;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					yes = true;
					text4 = text3;
					text5 = text;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v4+v252 @ X8_v9]");
					char c2 = ((string)0).get_Chars(0);
					int num3 = c2 & 0xFFFF;
					if (num3 != 68)
					{
						if (num3 == 85)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1910]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v4+v252 @ X8_v9]");
							if ((string)0 == (string)obj13)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
								object obj14 = 0;
								object obj15 = obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X0_v44+E4]");
								bool flag4 = (nint)0 == 0;
								object obj16 = !flag4;
								if (obj16 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								GillaFriends.Unblock(text, text3);
								gillaLeaderboard = (GillaLeaderboard)(object)text;
								goto IL_0868;
							}
							return;
						}
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1918]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v4+v252 @ X8_v9]");
					if (!((string)0 == (string)obj17))
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
					object obj18 = 0;
					object obj19 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v38+E4]");
					bool flag5 = (nint)0 == 0;
					object obj20 = !flag5;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					yes = false;
					text4 = text3;
					text5 = text;
				}
				GillaFriends.Answer(text5, text4, yes);
				gillaLeaderboard = (GillaLeaderboard)(object)text5;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v4+v252 @ X8_v9]");
				char c3 = ((string)0).get_Chars(0);
				switch (c3 & 0xFFFF)
				{
				case 85:
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1920]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v4+v252 @ X8_v9]");
					if ((string)0 == (string)obj25)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
						object obj26 = 0;
						object obj27 = obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v29+E4]");
						bool flag7 = (nint)0 == 0;
						object obj28 = !flag7;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaFriends.Remove(text, text3);
						gillaLeaderboard = (GillaLeaderboard)(object)text;
						break;
					}
					return;
				}
				case 66:
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1908]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v4+v252 @ X8_v9]");
					if ((string)0 == (string)obj21)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
						object obj22 = 0;
						object obj23 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v23+E4]");
						bool flag6 = (nint)0 == 0;
						object obj24 = !flag6;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaFriends.Block(text, text3);
						gillaLeaderboard = (GillaLeaderboard)(object)text;
						break;
					}
					return;
				}
				default:
					return;
				}
			}
		}
		else if (text2._stringLength != 3)
		{
			if (text2._stringLength != 4)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D18F0]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v4+v252 @ X8_v9]");
			if (!((string)0 == (string)obj29))
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
			object obj30 = 0;
			object obj31 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v15+E4]");
			bool flag8 = (nint)0 == 0;
			object obj32 = !flag8;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaFriends.Friend friend = default;
			GillaFriends.Join(friend);
			gillaLeaderboard = (GillaLeaderboard)(object)friend;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1900]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v4+v252 @ X8_v9]");
			if (!((string)0 == (string)obj33))
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
			object obj34 = 0;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v9+E4]");
			bool flag9 = (nint)0 == 0;
			object obj36 = !flag9;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaFriends.Ask(text, text3);
			gillaLeaderboard = (GillaLeaderboard)(object)text;
		}
		goto IL_0868;
		IL_0868:
		GillaLeaderboard gillaLeaderboard2 = gillaLeaderboard;
		AudioClip clip = doneSound;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		gillaLeaderboard2.Sound(clip, key, 0f);
	}

	private void ShowKeys()
	{
		//IL_0010: Expected Obj, but got I
		//IL_08fa: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I4
		//IL_0918: Expected Obj, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected I4, but got Unknown
		//IL_0138: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I4
		//IL_0990: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I4
		//IL_01d2: Expected Obj, but got I
		//IL_09c8: Expected Obj, but got I4
		//IL_0262: Expected Obj, but got I4
		//IL_02d5: Expected Obj, but got I4
		//IL_0280: Expected Obj, but got I
		//IL_02ff: Expected Obj, but got I4
		//IL_0310: Expected Obj, but got I4
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected Obj, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_0346: Expected Obj, but got I4
		//IL_0357: Expected Obj, but got I4
		//IL_0433: Expected Obj, but got I4
		//IL_03c6: Expected Obj, but got I4
		//IL_0a29: Expected Obj, but got I4
		//IL_047d: Expected Obj, but got I
		//IL_04a7: Expected Obj, but got I4
		//IL_0380: Expected Obj, but got I4
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected I4, but got Unknown
		//IL_04df: Expected Obj, but got I4
		//IL_03e4: Expected Obj, but got I
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Unknown
		//IL_040c: Expected Obj, but got I4
		//IL_041c: Expected Obj, but got I
		//IL_0a61: Expected Obj, but got I4
		//IL_0580: Expected Obj, but got I4
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected I4, but got Unknown
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected Obj, but got Unknown
		//IL_059e: Expected Obj, but got I
		//IL_0615: Expected Obj, but got I
		//IL_0661: Expected Obj, but got I4
		//IL_06a6: Expected Obj, but got I4
		//IL_07c5: Expected Obj, but got I4
		//IL_070f: Expected Obj, but got I4
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected Obj, but got Unknown
		//IL_0737: Expected Obj, but got I4
		//IL_0740: Expected Obj, but got I4
		//IL_078e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
		object obj4 = 0;
		bool isPlaying = Application.isPlaying;
		bool flag2 = !isPlaying;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v59+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v59+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v34+38]");
			if ((nint)0 == 0)
			{
				return;
			}
		}
		object obj9 = 4;
		bool flag4 = default;
		string text3 = default;
		string text4 = default;
		object obj13 = default;
		string text5 = default;
		while (true)
		{
			List<Entry> list = entries;
			object obj10;
			object obj20;
			PressKey key3;
			object obj31;
			if (entries != null)
			{
				obj10 = obj9 - 4;
				int num = obj10 + top;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v9 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
				string does;
				string text;
				object obj11;
				string text2;
				if ((nint)num >= (nint)0)
				{
					int num2 = (flag4 ? 1 : 0);
					does = null;
					text = null;
					obj11 = 0;
					text2 = null;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D17F0]");
					object obj12 = 0;
					Entry entry = entries.get_Item(num);
					int num2 = num;
					does = text3;
					text = text4;
					obj11 = obj13;
					text2 = text5;
				}
				PressKey[] array = leftKeys;
				if (leftKeys != null)
				{
					PressKey key;
					if ((nint)obj10 < array.Length)
					{
						bool flag5 = (nint)obj10 < array.Length;
						object obj14 = !flag5;
						if (obj14 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v11 (PressKey[])+v143 @ X29_v4*8]");
						key = (PressKey)0;
					}
					else
					{
						key = null;
					}
					object obj15 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X0_v15+E4]");
					bool flag6 = (nint)0 == 0;
					object obj16 = !flag6;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					KeyShows(key, does);
					PressKey[] array2 = rightKeys;
					if (rightKeys != null)
					{
						PressKey key2;
						if ((nint)obj10 < array2.Length)
						{
							bool flag7 = (nint)obj10 < array2.Length;
							object obj17 = !flag7;
							if (obj17 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v13 (PressKey[])+v143 @ X29_v4*8]");
							key2 = (PressKey)0;
						}
						else
						{
							key2 = null;
						}
						object obj18 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v18+E4]");
						bool flag8 = (nint)0 == 0;
						object obj19 = !flag8;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						KeyShows(key2, text);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v9 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
						bool flag9 = (nint)num >= (nint)0;
						string text6 = text;
						obj20 = 0;
						if (!flag9)
						{
							bool flag10 = page == 0;
							object obj21 = !flag10;
							text6 = text;
							obj20 = 0;
							if (obj21 == null)
							{
								object obj22 = obj11 & 1;
								bool flag11 = obj22 == null;
								object obj23 = !flag11;
								text6 = text;
								obj20 = 0;
								if (obj23 == null)
								{
									bool flag12 = string.IsNullOrEmpty(text2);
									obj20 = (flag12 ? 1 : 0) ^ 1;
									text6 = null;
								}
							}
						}
						PressKey[] array3 = muteKeys;
						if (muteKeys != null)
						{
							PressKey pressKey;
							if ((nint)obj10 < array3.Length)
							{
								bool flag13 = (nint)obj10 < array3.Length;
								object obj24 = !flag13;
								if (obj24 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v16 (PressKey[])+v143 @ X29_v4*8]");
								key3 = (PressKey)0;
								object obj25 = obj20 & 1;
								bool flag14 = obj25 == null;
								object obj26 = !flag14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v16 (PressKey[])+v143 @ X29_v4*8]");
								pressKey = (PressKey)0;
								if (obj26 == null)
								{
									goto IL_042a;
								}
							}
							else
							{
								object obj27 = obj20 & 1;
								bool flag15 = obj27 == null;
								key3 = null;
								pressKey = null;
								if (flag15)
								{
									goto IL_042a;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
							object obj28 = 0;
							object obj29 = obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v48+E4]");
							bool flag16 = (nint)0 == 0;
							object obj30 = !flag16;
							if (obj30 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag17 = GillaFriends.IsBlocked(text2);
							obj31 = (flag17 ? 1 : 0) ^ 1;
							text6 = null;
							key3 = pressKey;
							goto IL_09ff;
						}
					}
				}
			}
			goto IL_08bb;
			IL_042a:
			obj31 = 0;
			goto IL_09ff;
			IL_09ff:
			object obj32 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X0_v23+E4]");
			bool flag18 = (nint)0 == 0;
			object obj33 = !flag18;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag19 = (byte)(obj31 & 1) != 0;
			Out(key3, flag19);
			PressKey[] array4 = reportKeys;
			if (reportKeys != null)
			{
				PressKey key4;
				if ((nint)obj10 < array4.Length)
				{
					bool flag20 = (nint)obj10 < array4.Length;
					object obj34 = !flag20;
					if (obj34 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v19 (PressKey[])+v143 @ X29_v4*8]");
					key4 = (PressKey)0;
				}
				else
				{
					key4 = null;
				}
				object obj35 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X0_v26+E4]");
				bool flag21 = (nint)0 == 0;
				object obj36 = !flag21;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				flag4 = (byte)(obj20 & 1) != 0;
				Out(key4, flag4);
				obj9++;
				if ((nint)obj9 != 14)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj37 = 0;
				object obj38 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLeaderboard)+108]");
				bool flag22 = (nint)0 == 0;
				bool flag23 = !flag22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X0_v29+E4]");
				bool flag24 = (nint)0 == 0;
				object obj39 = !flag24;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag25 = reasonPanel != null;
				bool flag26 = !flag25;
				object obj40 = 0;
				bool flag27 = false;
				if (!flag26)
				{
					if ((object)reasonPanel == null)
					{
						goto IL_08bb;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLeaderboard)+108]");
					bool flag28 = (nint)0 == 0;
					bool activeSelf = reasonPanel.activeSelf;
					object obj41 = flag28 ^ activeSelf;
					object obj42 = obj41 & 1;
					bool flag29 = obj42 == null;
					object obj43 = !flag29;
					obj40 = 0;
					flag27 = false;
					if (obj43 == null)
					{
						if ((object)reasonPanel == null)
						{
							goto IL_08bb;
						}
						reasonPanel.SetActive(flag23);
						obj40 = 0;
						flag27 = flag23;
					}
				}
				object obj44 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X0_v34+E4]");
				bool flag30 = (nint)0 == 0;
				object obj45 = !flag30;
				if (obj45 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(pagePanel != null))
				{
					return;
				}
				if ((object)pagePanel != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLeaderboard)+108]");
					bool flag31 = (nint)0 == 0;
					bool activeSelf2 = pagePanel.activeSelf;
					if (flag31 == activeSelf2)
					{
						return;
					}
					if ((object)pagePanel != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLeaderboard)+108]");
						bool active = (nint)0 == 0;
						pagePanel.SetActive(active);
						return;
					}
				}
			}
			goto IL_08bb;
			IL_08bb:
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		throw new IndexOutOfRangeException();
	}

	private static void Out(PressKey key, bool on)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (key != null)
		{
			GameObject gameObject = key.gameObject;
			bool activeSelf = gameObject.activeSelf;
			if (activeSelf != on)
			{
				GameObject gameObject2 = key.gameObject;
				gameObject2.SetActive(on);
			}
		}
	}

	private unsafe static void KeyShows(PressKey key, string does)
	{
		//IL_0010: Expected Obj, but got I
		//IL_08ae: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected I4, but got Unknown
		//IL_0101: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I4
		//IL_0196: Expected Obj, but got I4
		//IL_06c7: Expected Obj, but got I4
		//IL_0725: Expected Obj, but got I
		//IL_072d: Expected I4, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_01cd: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I4
		//IL_0a19: Expected Obj, but got I4
		//IL_09a7: Expected I, but got Obj
		//IL_09b7: Expected Obj, but got I
		//IL_0774: Expected Obj, but got I
		//IL_025d: Expected Obj, but got I4
		//IL_0842: Expected Obj, but got I4
		//IL_0803: Expected Obj, but got I4
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected Obj, but got Unknown
		//IL_0921: Expected Obj, but got I4
		//IL_092e: Expected Obj, but got Ref
		//IL_0936: Expected Obj, but got Ref
		//IL_0209: Expected Obj, but got I
		//IL_07af: Expected Obj, but got I
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Expected Obj, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected Obj, but got Unknown
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected Obj, but got Unknown
		//IL_02af: Expected I, but got Obj
		//IL_02bf: Expected Obj, but got I
		//IL_034e: Expected Obj, but got I4
		//IL_0655: Expected Obj, but got I4
		//IL_0662: Expected Obj, but got Ref
		//IL_066a: Expected Obj, but got Ref
		//IL_02fa: Expected Obj, but got I
		//IL_0391: Expected I4, but got Obj
		//IL_0399: Expected I, but got Obj
		//IL_03c2: Expected Obj, but got I4
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected Obj, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_03f6: Expected Obj, but got I
		//IL_0479: Expected Obj, but got I4
		//IL_0481: Expected I4, but got Obj
		//IL_05d4: Expected Obj, but got I4
		//IL_04ed: Expected Obj, but got I4
		//IL_051e: Expected Obj, but got I4
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Obj, but got Unknown
		//IL_0544: Expected Obj, but got I4
		//IL_0580: Expected Obj, but got I4
		//IL_05ad: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = key == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
		object obj5 = 0;
		bool flag4 = string.IsNullOrEmpty(does);
		object obj6 = obj5;
		object obj7 = (flag4 ? 1 : 0) ^ 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = (byte)(obj7 & 1) != 0;
		Out(key, flag6);
		bool flag7 = !flag4;
		object obj9 = !flag7;
		if (obj9 != null)
		{
			return;
		}
		bool flag8 = (object)key == null;
		object obj10 = 0;
		object obj28 = default;
		OutOfMemoryException ex3 = default;
		object obj29;
		if (!flag8)
		{
			Transform transform = key.transform;
			bool flag9 = (object)transform == null;
			obj10 = 0;
			flag6 = false;
			if (!flag9)
			{
				IEnumerator enumerator = transform.GetEnumerator();
				bool flag10 = enumerator == null;
				object obj11 = 0;
				flag6 = false;
				if (flag10)
				{
					goto IL_05f2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4648]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1930]");
				object obj14 = 0;
				obj10 = 0;
				IEnumerator enumerator2 = enumerator;
				UnityEngine.Object obj19 = default;
				object obj27 = default;
				object obj30 = default;
				object obj32 = default;
				while (true)
				{
					nint num = (nint)enumerator2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v29 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v29 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_024a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v29 (Il2CppClass<System.Collections.IEnumerator>)+98]");
					object obj16 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X10_v31-8]");
						if (0 == (nint)obj12)
						{
							break;
						}
						obj15--;
						obj16 += 16;
						if ((nint)obj15 != 1)
						{
							continue;
						}
						goto IL_024a;
					}
					object obj17 = num + obj16;
					object obj18 = obj17 + 312;
					goto IL_08e1;
					IL_0619:
					NullReferenceException ex = new NullReferenceException();
					goto IL_0627;
					IL_033b:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					obj11 = 1;
					goto IL_0968;
					IL_0968:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ X0_v61+8]");
					flag6 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v813 @ X0_v61] (should have been resolved before IL gen)");
					if ((object)obj19 != null)
					{
						flag6 = (byte)(int)obj13 != 0;
						nint num2 = (nint)obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v35 (Il2CppClass<UnityEngine.Object>)+130]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X1_v5 (System.Boolean)+130]");
						bool flag11 = num3 < 0;
						object obj20 = !flag11;
						object obj21 = ~obj20;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v35 (Il2CppClass<UnityEngine.Object>)+B0]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X1_v5 (System.Boolean)+130]");
							object obj22 = num4 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X8_v37-8]");
							if ((nint)0 == (flag6 ? 1 : 0))
							{
								string text = obj19.name;
								bool flag12 = text == null;
								flag6 = false;
								if (!flag12)
								{
									bool flag13 = text.StartsWith((string)obj14);
									bool flag14 = !flag13;
									obj11 = 0;
									flag6 = (byte)(int)obj14 != 0;
									if (!flag14)
									{
										string text2 = obj19.name;
										string text3 = (string)obj14 + does;
										bool flag15 = text2 == text3;
										GameObject gameObject = ((Component)obj19).gameObject;
										bool flag16 = (object)gameObject == null;
										obj11 = 0;
										flag6 = false;
										if (flag16)
										{
											goto IL_0635;
										}
										bool activeSelf = gameObject.activeSelf;
										object obj23 = flag15 ^ activeSelf;
										object obj24 = obj23 & 1;
										bool flag17 = obj24 == null;
										obj11 = 0;
										flag6 = false;
										if (!flag17)
										{
											GameObject gameObject2 = ((Component)obj19).gameObject;
											bool flag18 = (object)gameObject2 == null;
											obj11 = 0;
											flag6 = false;
											if (flag18)
											{
												goto IL_0643;
											}
											gameObject2.SetActive(flag15);
											obj11 = 0;
											flag6 = flag15;
										}
									}
									bool flag19 = enumerator == null;
									object obj25 = !flag19;
									obj10 = obj11;
									enumerator2 = enumerator;
									if (obj25 != null)
									{
										continue;
									}
									goto IL_05f2;
								}
								goto IL_060b;
							}
						}
						InvalidCastException ex2 = new InvalidCastException();
						goto IL_060b;
					}
					goto IL_0627;
					IL_024a:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					obj10 = 0;
					goto IL_08e1;
					IL_08e1:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X0_v58+8]");
					flag6 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v595 @ X0_v58] (should have been resolved before IL gen)");
					object obj26 = obj27 & 1;
					bool flag20 = obj26 == null;
					obj28 = 0;
					ex3 = null;
					obj29 = (object)(&obj30);
					object obj31 = (object)(&obj32);
					if (flag20)
					{
						break;
					}
					bool flag21 = enumerator == null;
					obj11 = obj10;
					if (flag21)
					{
						goto IL_0619;
					}
					nint num5 = (nint)enumerator;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v32 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					object obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v32 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_033b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v32 (Il2CppClass<System.Collections.IEnumerator>)+98]");
					object obj34 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X10_v26-8]");
						if (0 == (nint)obj12)
						{
							break;
						}
						obj33--;
						obj34 += 16;
						if ((nint)obj33 != 1)
						{
							continue;
						}
						goto IL_033b;
					}
					object obj35 = obj34 + 1;
					object obj36 = num5 + obj35;
					object obj37 = obj36 + 312;
					obj11 = obj10;
					goto IL_0968;
					IL_0627:
					NullReferenceException ex4 = new NullReferenceException();
					goto IL_0635;
					IL_0643:
					NullReferenceException ex5 = new NullReferenceException();
					obj28 = 0;
					ex3 = null;
					obj29 = (object)(&obj30);
					obj31 = (object)(&obj32);
					obj10 = obj11;
					goto IL_0677;
					IL_060b:
					NullReferenceException ex6 = new NullReferenceException();
					goto IL_0619;
					IL_0635:
					NullReferenceException ex7 = new NullReferenceException();
					goto IL_0643;
				}
				goto IL_0715;
			}
		}
		goto IL_0677;
		IL_09ff:
		bool flag22 = ex3 == null;
		object obj38 = !flag22;
		if (obj38 == null)
		{
			bool flag23 = obj28 == null;
			object obj39 = !flag23;
			OutOfMemoryException ex8 = ex3;
			if (obj39 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex8 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex10 = default;
		NullReferenceException ex9 = ex10;
		goto IL_09dc;
		IL_0677:
		NullReferenceException ex11 = new NullReferenceException();
		if ((flag6 ? 1 : 0) == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj28 = 1;
		}
		else
		{
			bool flag24 = !flag6;
			ex9 = ex11;
			if (flag24)
			{
				goto IL_09dc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj40 = default;
			ex3 = (OutOfMemoryException)obj40;
		}
		goto IL_0715;
		IL_0a4b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v25+8]");
		flag6 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v784 @ X0_v25] (should have been resolved before IL gen)");
		goto IL_09ff;
		IL_0715:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		object obj41 = 0;
		flag6 = (byte)(int)obj41 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		object obj42 = default;
		obj29 = obj42;
		if (obj42 == null)
		{
			goto IL_09ff;
		}
		object obj43 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v13+12E]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v13+12E]");
		if ((nint)0 == 0)
		{
			goto IL_07f0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v13+98]");
		object obj45 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X10_v9-8]");
			if (0 == (nint)obj41)
			{
				break;
			}
			obj44--;
			obj45 += 16;
			if ((nint)obj44 != 1)
			{
				continue;
			}
			goto IL_07f0;
		}
		object obj46 = obj43 + obj45;
		object obj47 = obj46 + 312;
		goto IL_0a4b;
		IL_09dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE48");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_07f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj10 = 0;
		goto IL_0a4b;
		IL_05f2:
		throw new NullReferenceException();
	}

	private unsafe void Gather()
	{
		//IL_553d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5547: Unknown result type (might be due to invalid IL or missing references)
		//IL_5551: Unknown result type (might be due to invalid IL or missing references)
		//IL_555c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5570: Unknown result type (might be due to invalid IL or missing references)
		//IL_5583: Expected VT, but got I4
		//IL_5589: Unknown result type (might be due to invalid IL or missing references)
		//IL_5594: Unknown result type (might be due to invalid IL or missing references)
		//IL_559d: Unknown result type (might be due to invalid IL or missing references)
		//IL_55a9: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I4
		//IL_55c7: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I4
		//IL_0257: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I4
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got I4
		//IL_0e23: Expected Obj, but got I
		//IL_0e57: Expected Obj, but got I4
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected VT, but got I4
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_57bb: Expected Obj, but got I
		//IL_57cb: Expected Obj, but got I
		//IL_57ed: Expected Obj, but got I4
		//IL_0302: Expected Obj, but got I
		//IL_032c: Expected Obj, but got I4
		//IL_0ee8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2e: Expected VT, but got I4
		//IL_0f36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_55fc: Expected Obj, but got I
		//IL_5619: Unknown result type (might be due to invalid IL or missing references)
		//IL_5623: Unknown result type (might be due to invalid IL or missing references)
		//IL_562d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5638: Unknown result type (might be due to invalid IL or missing references)
		//IL_564c: Unknown result type (might be due to invalid IL or missing references)
		//IL_565f: Expected VT, but got I4
		//IL_5665: Unknown result type (might be due to invalid IL or missing references)
		//IL_5670: Unknown result type (might be due to invalid IL or missing references)
		//IL_5679: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got I
		//IL_0207: Expected Obj, but got I
		//IL_021c: Expected Obj, but got I
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9e: Expected Obj, but got I4
		//IL_0f64: Expected Obj, but got I
		//IL_0f6c: Expected I4, but got Obj
		//IL_0f9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe0: Expected VT, but got I4
		//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fec: Unknown result type (might be due to invalid IL or missing references)
		//IL_582d: Expected Obj, but got I
		//IL_583e: Expected I, but got Obj
		//IL_585c: Expected Obj, but got I
		//IL_5887: Expected Obj, but got I4
		//IL_5897: Expected I4, but got Obj
		//IL_0363: Expected Obj, but got I
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected Obj, but got I
		//IL_0387: Expected Obj, but got I
		//IL_0397: Expected Obj, but got I
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ece: Expected Obj, but got I
		//IL_5f8c: Expected Obj, but got I
		//IL_5fa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_5fad: Unknown result type (might be due to invalid IL or missing references)
		//IL_5fb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_5fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_5fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5fe9: Expected VT, but got I4
		//IL_5ffc: Expected Obj, but got I4
		//IL_6005: Expected Obj, but got I4
		//IL_6005: Unknown result type (might be due to invalid IL or missing references)
		//IL_6009: Unknown result type (might be due to invalid IL or missing references)
		//IL_6011: Unknown result type (might be due to invalid IL or missing references)
		//IL_53d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_53d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b1: Expected Obj, but got I
		//IL_10db: Expected Obj, but got I4
		//IL_03c7: Expected Obj, but got I
		//IL_03f1: Expected Obj, but got I4
		//IL_108e: Expected Obj, but got I
		//IL_1097: Expected Obj, but got I4
		//IL_0436: Expected Obj, but got I4
		//IL_2501: Unknown result type (might be due to invalid IL or missing references)
		//IL_250b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2515: Unknown result type (might be due to invalid IL or missing references)
		//IL_2520: Unknown result type (might be due to invalid IL or missing references)
		//IL_2534: Unknown result type (might be due to invalid IL or missing references)
		//IL_254f: Expected VT, but got I4
		//IL_2557: Unknown result type (might be due to invalid IL or missing references)
		//IL_255b: Unknown result type (might be due to invalid IL or missing references)
		//IL_113a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1144: Unknown result type (might be due to invalid IL or missing references)
		//IL_114e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1159: Unknown result type (might be due to invalid IL or missing references)
		//IL_116d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1180: Expected VT, but got I4
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected VT, but got I4
		//IL_04bb: Expected Obj, but got I4
		//IL_04c4: Expected Obj, but got I4
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c34: Expected VT, but got I4
		//IL_3f99: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_54a6: Expected Obj, but got I4
		//IL_257c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2581: Unknown result type (might be due to invalid IL or missing references)
		//IL_2596: Expected Obj, but got I
		//IL_25a6: Expected Obj, but got I
		//IL_25b6: Expected Obj, but got I
		//IL_25bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_25d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_33aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_33ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_54fd: Expected Obj, but got I4
		//IL_0510: Expected Obj, but got I
		//IL_053a: Expected Obj, but got I4
		//IL_1c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca6: Expected VT, but got I4
		//IL_3fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0e: Expected VT, but got I4
		//IL_1d16: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_603e: Expected Obj, but got I
		//IL_6046: Unknown result type (might be due to invalid IL or missing references)
		//IL_604f: Expected Ref, but got Unknown
		//IL_605f: Expected Obj, but got I
		//IL_6079: Expected Obj, but got I4
		//IL_0569: Expected Obj, but got I
		//IL_0587: Expected Obj, but got I4
		//IL_32a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_32a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_32ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_32c1: Expected VT, but got I4
		//IL_32d8: Expected Obj, but got Ref
		//IL_32dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_32e9: Expected Obj, but got I4
		//IL_33d8: Expected Obj, but got I
		//IL_33f2: Expected Obj, but got I
		//IL_33fa: Expected I4, but got Obj
		//IL_5077: Unknown result type (might be due to invalid IL or missing references)
		//IL_507b: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1202: Unknown result type (might be due to invalid IL or missing references)
		//IL_121d: Expected VT, but got I4
		//IL_260f: Expected Obj, but got I
		//IL_343b: Expected Obj, but got I4
		//IL_401b: Expected Obj, but got I
		//IL_1d5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da1: Expected VT, but got I4
		//IL_1da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_3308: Expected Obj, but got I4
		//IL_3308: Unknown result type (might be due to invalid IL or missing references)
		//IL_3310: Expected Obj, but got Unknown
		//IL_05ae: Expected Obj, but got I
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected VT, but got I4
		//IL_0624: Expected Obj, but got I4
		//IL_062d: Expected Obj, but got I4
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_2631: Unknown result type (might be due to invalid IL or missing references)
		//IL_2636: Expected Obj, but got Unknown
		//IL_2644: Expected Obj, but got Ref
		//IL_2668: Expected Obj, but got I4
		//IL_5b97: Expected Obj, but got I
		//IL_5ba7: Expected Obj, but got I
		//IL_5bc9: Expected Obj, but got I4
		//IL_50a5: Expected Obj, but got I
		//IL_50c3: Expected Obj, but got I
		//IL_50f5: Expected Obj, but got I4
		//IL_4831: Unknown result type (might be due to invalid IL or missing references)
		//IL_4835: Unknown result type (might be due to invalid IL or missing references)
		//IL_1248: Unknown result type (might be due to invalid IL or missing references)
		//IL_1252: Unknown result type (might be due to invalid IL or missing references)
		//IL_125c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1267: Unknown result type (might be due to invalid IL or missing references)
		//IL_127b: Unknown result type (might be due to invalid IL or missing references)
		//IL_128e: Expected VT, but got I4
		//IL_1296: Unknown result type (might be due to invalid IL or missing references)
		//IL_129a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2919: Expected Obj, but got I
		//IL_34d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_34da: Unknown result type (might be due to invalid IL or missing references)
		//IL_5124: Unknown result type (might be due to invalid IL or missing references)
		//IL_4058: Expected Obj, but got I
		//IL_4068: Expected Obj, but got I
		//IL_4078: Expected Obj, but got I
		//IL_4088: Expected Obj, but got I
		//IL_40c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_40cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_4111: Expected Obj, but got I4
		//IL_4111: Unknown result type (might be due to invalid IL or missing references)
		//IL_4115: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd1: Expected Obj, but got I4
		//IL_1de8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e36: Expected VT, but got I4
		//IL_5a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_269d: Expected Obj, but got I4
		//IL_26a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3482: Expected Obj, but got I4
		//IL_5ed7: Expected Obj, but got I
		//IL_5f01: Expected Obj, but got I4
		//IL_5d21: Expected Obj, but got I4
		//IL_5d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_5dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e0: Expected Obj, but got I4
		//IL_12fe: Expected VT, but got I4
		//IL_56c5: Expected Obj, but got I
		//IL_56ef: Expected Obj, but got I4
		//IL_5b70: Expected Obj, but got Ref
		//IL_293f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2943: Unknown result type (might be due to invalid IL or missing references)
		//IL_2947: Unknown result type (might be due to invalid IL or missing references)
		//IL_294c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2950: Unknown result type (might be due to invalid IL or missing references)
		//IL_298b: Expected VT, but got I4
		//IL_29ad: Expected Obj, but got Ref
		//IL_29b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_3504: Expected Obj, but got I
		//IL_350c: Expected I4, but got Obj
		//IL_351e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3523: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c0e: Expected Obj, but got I
		//IL_5c1f: Expected I, but got Obj
		//IL_5c3d: Expected Obj, but got I
		//IL_5c68: Expected Obj, but got I4
		//IL_5c78: Expected I4, but got Obj
		//IL_5178: Unknown result type (might be due to invalid IL or missing references)
		//IL_517c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5c: Expected Obj, but got I
		//IL_1e6c: Expected Obj, but got I
		//IL_1e7c: Expected Obj, but got I
		//IL_1e8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_58c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_58cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_58d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_58e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_58f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5907: Unknown result type (might be due to invalid IL or missing references)
		//IL_590b: Unknown result type (might be due to invalid IL or missing references)
		//IL_336d: Expected Obj, but got I4
		//IL_068e: Expected Obj, but got I
		//IL_06b1: Expected Obj, but got I
		//IL_26de: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_26eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2733: Expected VT, but got I4
		//IL_2755: Expected Obj, but got Ref
		//IL_2762: Unknown result type (might be due to invalid IL or missing references)
		//IL_276a: Unknown result type (might be due to invalid IL or missing references)
		//IL_353c: Expected Obj, but got I
		//IL_354c: Expected Obj, but got I
		//IL_355c: Expected Obj, but got I
		//IL_356c: Expected Obj, but got I
		//IL_356c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3570: Unknown result type (might be due to invalid IL or missing references)
		//IL_34b2: Expected Obj, but got I
		//IL_52f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_489e: Expected Obj, but got I
		//IL_48ae: Expected Obj, but got I
		//IL_48be: Expected Obj, but got I
		//IL_4906: Unknown result type (might be due to invalid IL or missing references)
		//IL_490a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4947: Expected Obj, but got I4
		//IL_4947: Unknown result type (might be due to invalid IL or missing references)
		//IL_494b: Unknown result type (might be due to invalid IL or missing references)
		//IL_415d: Expected Obj, but got I
		//IL_418b: Unknown result type (might be due to invalid IL or missing references)
		//IL_41bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_41c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_4201: Unknown result type (might be due to invalid IL or missing references)
		//IL_59d2: Expected Obj, but got I4
		//IL_59d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_59e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_59ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_59f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a0e: Expected VT, but got I4
		//IL_5a1e: Expected Obj, but got Ref
		//IL_5a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a22: Unknown result type (might be due to invalid IL or missing references)
		//IL_131c: Expected Obj, but got I
		//IL_1346: Expected Obj, but got I4
		//IL_29e4: Expected Obj, but got I
		//IL_29fa: Expected Obj, but got I
		//IL_2a02: Expected I, but got Obj
		//IL_2a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a28: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a31: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a70: Expected VT, but got I4
		//IL_2a92: Expected Obj, but got Ref
		//IL_2a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6138: Unknown result type (might be due to invalid IL or missing references)
		//IL_6141: Expected I4, but got Unknown
		//IL_520d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5211: Unknown result type (might be due to invalid IL or missing references)
		//IL_51a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_51ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_51af: Unknown result type (might be due to invalid IL or missing references)
		//IL_5df8: Expected Obj, but got I4
		//IL_5e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e91: Expected Obj, but got I4
		//IL_5e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e95: Unknown result type (might be due to invalid IL or missing references)
		//IL_139a: Expected Obj, but got I4
		//IL_13b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Expected VT, but got I4
		//IL_073b: Expected Obj, but got I
		//IL_074e: Expected Obj, but got I4
		//IL_0757: Expected Obj, but got I4
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_2799: Expected Obj, but got I
		//IL_6097: Expected Obj, but got I
		//IL_60a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_60ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_60c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_60d2: Expected Obj, but got Ref
		//IL_424d: Expected Obj, but got I
		//IL_4277: Expected Obj, but got I4
		//IL_1ed2: Expected Obj, but got I
		//IL_1eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f03: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3d: Expected VT, but got I4
		//IL_1f4d: Expected Obj, but got Ref
		//IL_1f52: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac8: Expected Obj, but got I
		//IL_2ad8: Expected Obj, but got I
		//IL_2b01: Expected Obj, but got I4
		//IL_2c58: Expected Obj, but got I
		//IL_2c82: Expected Obj, but got I4
		//IL_3589: Expected Obj, but got I
		//IL_35b3: Expected Obj, but got I4
		//IL_524e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5252: Unknown result type (might be due to invalid IL or missing references)
		//IL_5257: Expected Obj, but got Unknown
		//IL_526a: Unknown result type (might be due to invalid IL or missing references)
		//IL_526e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5273: Expected I4, but got Unknown
		//IL_527b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5280: Expected I4, but got Unknown
		//IL_52b5: Expected Obj, but got I4
		//IL_499b: Expected Obj, but got I
		//IL_49c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a05: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a43: Expected Obj, but got I4
		//IL_4a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_42ab: Expected Obj, but got I8
		//IL_42bd: Expected Obj, but got I
		//IL_141b: Expected Obj, but got I
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected Obj, but got Unknown
		//IL_07c1: Expected Obj, but got I
		//IL_2bce: Expected Obj, but got I
		//IL_2bde: Expected Obj, but got I
		//IL_2bfd: Expected VT, but got Ref
		//IL_2bfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f1: Expected Obj, but got I4
		//IL_35ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_35f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3606: Unknown result type (might be due to invalid IL or missing references)
		//IL_360a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3612: Unknown result type (might be due to invalid IL or missing references)
		//IL_361e: Expected Obj, but got Ref
		//IL_52d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_52dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_42da: Expected Obj, but got Ref
		//IL_42f2: Expected Obj, but got Ref
		//IL_1f88: Expected Obj, but got I
		//IL_1fb2: Expected Obj, but got I4
		//IL_5956: Unknown result type (might be due to invalid IL or missing references)
		//IL_5960: Unknown result type (might be due to invalid IL or missing references)
		//IL_596a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5975: Unknown result type (might be due to invalid IL or missing references)
		//IL_5989: Unknown result type (might be due to invalid IL or missing references)
		//IL_599f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b2c: Expected Obj, but got I
		//IL_2b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b51: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b64: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b69: Expected Obj, but got Unknown
		//IL_2b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b91: Expected Obj, but got Unknown
		//IL_2bb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d5d: Expected Obj, but got I
		//IL_2d6b: Expected Obj, but got Ref
		//IL_2d85: Expected Obj, but got I
		//IL_2db7: Expected Obj, but got I4
		//IL_282f: Expected Obj, but got I
		//IL_2849: Expected Obj, but got I4
		//IL_5f60: Expected Obj, but got I4
		//IL_52d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a96: Expected Obj, but got I
		//IL_4ac0: Expected Obj, but got I4
		//IL_430f: Expected Obj, but got Ref
		//IL_4348: Unknown result type (might be due to invalid IL or missing references)
		//IL_437c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4380: Unknown result type (might be due to invalid IL or missing references)
		//IL_43b9: Expected Obj, but got I8
		//IL_43d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fec: Expected Obj, but got I
		//IL_1fec: Expected Obj, but got I
		//IL_1ffe: Expected Obj, but got I
		//IL_0804: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected VT, but got I4
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected Obj, but got I
		//IL_0878: Expected Obj, but got I4
		//IL_0881: Expected Obj, but got I4
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cd9: Expected Obj, but got I
		//IL_2ce7: Expected Obj, but got Ref
		//IL_2d01: Expected Obj, but got I
		//IL_2d17: Expected Obj, but got Ref
		//IL_4afa: Expected Obj, but got I
		//IL_4afa: Expected Obj, but got I
		//IL_4b0c: Expected Obj, but got I
		//IL_201b: Expected Obj, but got Ref
		//IL_2033: Expected Obj, but got Ref
		//IL_1433: Unknown result type (might be due to invalid IL or missing references)
		//IL_1438: Expected Obj, but got Unknown
		//IL_1453: Expected Obj, but got I4
		//IL_1459: Unknown result type (might be due to invalid IL or missing references)
		//IL_1463: Unknown result type (might be due to invalid IL or missing references)
		//IL_146d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1478: Unknown result type (might be due to invalid IL or missing references)
		//IL_148c: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e2c: Expected Obj, but got I
		//IL_2e56: Expected Obj, but got I4
		//IL_2d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_288a: Expected Obj, but got I4
		//IL_5ca1: Expected Obj, but got I
		//IL_5ccb: Expected Obj, but got I4
		//IL_52eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b29: Expected Obj, but got Ref
		//IL_4b41: Expected Obj, but got Ref
		//IL_4415: Expected Obj, but got I
		//IL_442b: Expected Obj, but got I
		//IL_4433: Expected I, but got Obj
		//IL_446d: Unknown result type (might be due to invalid IL or missing references)
		//IL_44ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_44dd: Expected Obj, but got I8
		//IL_44f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2057: Unknown result type (might be due to invalid IL or missing references)
		//IL_2061: Unknown result type (might be due to invalid IL or missing references)
		//IL_206b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2076: Unknown result type (might be due to invalid IL or missing references)
		//IL_2094: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ba: Expected VT, but got I4
		//IL_20ca: Expected Obj, but got I
		//IL_20da: Expected Obj, but got Ref
		//IL_20df: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Expected I, but got Obj
		//IL_093f: Expected Obj, but got I4
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected Obj, but got Unknown
		//IL_2e0e: Expected Obj, but got I
		//IL_2e17: Expected Obj, but got I4
		//IL_28d3: Expected Obj, but got I
		//IL_28e9: Expected Obj, but got I4
		//IL_3b1c: Expected Obj, but got I
		//IL_365e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3663: Expected I4, but got Unknown
		//IL_4b68: Expected Obj, but got I4
		//IL_4b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bfd: Expected Obj, but got I
		//IL_4c0e: Expected Obj, but got I4
		//IL_4c13: Unknown result type (might be due to invalid IL or missing references)
		//IL_14de: Expected Obj, but got I
		//IL_14ee: Expected Obj, but got I
		//IL_1528: Expected Obj, but got I4
		//IL_2efa: Expected Obj, but got I
		//IL_2f24: Expected Obj, but got I4
		//IL_3b39: Expected Obj, but got Ref
		//IL_4530: Expected Obj, but got I
		//IL_4540: Expected Obj, but got I
		//IL_4569: Expected Obj, but got I4
		//IL_2111: Expected Obj, but got I
		//IL_2127: Expected Obj, but got I
		//IL_212f: Expected I, but got Obj
		//IL_2151: Unknown result type (might be due to invalid IL or missing references)
		//IL_215b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2165: Unknown result type (might be due to invalid IL or missing references)
		//IL_2170: Unknown result type (might be due to invalid IL or missing references)
		//IL_218e: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_21de: Expected VT, but got I4
		//IL_21f6: Expected Obj, but got I
		//IL_2206: Expected Obj, but got Ref
		//IL_220a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1560: Expected Obj, but got I
		//IL_2ead: Expected Obj, but got I
		//IL_2ec5: Expected Obj, but got I
		//IL_2edb: Expected Obj, but got Ref
		//IL_2fe8: Expected Obj, but got I4
		//IL_3bc8: Expected Obj, but got I4
		//IL_36b9: Expected Obj, but got I4
		//IL_4c55: Expected Obj, but got I
		//IL_4c6b: Expected Obj, but got I
		//IL_4c73: Expected I, but got Obj
		//IL_4c98: Expected Obj, but got I4
		//IL_4cb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d27: Expected Obj, but got I
		//IL_4d38: Expected Obj, but got I4
		//IL_4d3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4614: Expected Obj, but got I
		//IL_4624: Expected Obj, but got I
		//IL_4643: Expected VT, but got Ref
		//IL_4669: Unknown result type (might be due to invalid IL or missing references)
		//IL_4676: Unknown result type (might be due to invalid IL or missing references)
		//IL_4682: Expected Obj, but got Ref
		//IL_158c: Expected Obj, but got I
		//IL_15a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f99: Expected Obj, but got I
		//IL_2faf: Expected Obj, but got Ref
		//IL_3026: Expected Obj, but got I
		//IL_3040: Expected Obj, but got I4
		//IL_60e5: Expected Obj, but got Ref
		//IL_60fd: Expected Obj, but got Ref
		//IL_611a: Expected Obj, but got I4
		//IL_6128: Expected Obj, but got Ref
		//IL_3b96: Expected Obj, but got I4
		//IL_4697: Expected Obj, but got I
		//IL_46a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_46a5: Expected Obj, but got Unknown
		//IL_46d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_470b: Unknown result type (might be due to invalid IL or missing references)
		//IL_472c: Expected Obj, but got I8
		//IL_475a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4784: Unknown result type (might be due to invalid IL or missing references)
		//IL_47bd: Expected Obj, but got I8
		//IL_47d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_47d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_4594: Expected Obj, but got I
		//IL_45b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_45bd: Expected Obj, but got Unknown
		//IL_45f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_223c: Expected Obj, but got I
		//IL_224c: Expected Obj, but got I
		//IL_2275: Expected Obj, but got I4
		//IL_573f: Expected Obj, but got I
		//IL_2f7b: Expected Obj, but got I
		//IL_2f84: Expected Obj, but got I4
		//IL_5ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_5abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_5acd: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b08: Expected VT, but got I4
		//IL_5b2a: Expected Obj, but got Ref
		//IL_5b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c44: Expected Obj, but got Ref
		//IL_36df: Expected Obj, but got I
		//IL_36f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_36fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_371a: Unknown result type (might be due to invalid IL or missing references)
		//IL_371e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3726: Unknown result type (might be due to invalid IL or missing references)
		//IL_3732: Expected Obj, but got Ref
		//IL_373b: Expected Obj, but got I4
		//IL_4d76: Expected Obj, but got I
		//IL_4d86: Expected Obj, but got I
		//IL_4daf: Expected Obj, but got I4
		//IL_2323: Expected Obj, but got I
		//IL_2333: Expected Obj, but got I
		//IL_2350: Expected VT, but got Ref
		//IL_2376: Unknown result type (might be due to invalid IL or missing references)
		//IL_2386: Unknown result type (might be due to invalid IL or missing references)
		//IL_2392: Expected Obj, but got Ref
		//IL_163e: Expected Obj, but got I4
		//IL_1644: Unknown result type (might be due to invalid IL or missing references)
		//IL_164e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1658: Unknown result type (might be due to invalid IL or missing references)
		//IL_1663: Unknown result type (might be due to invalid IL or missing references)
		//IL_1677: Unknown result type (might be due to invalid IL or missing references)
		//IL_1695: Unknown result type (might be due to invalid IL or missing references)
		//IL_3078: Expected Obj, but got I4
		//IL_3bad: Expected Obj, but got I4
		//IL_4e5d: Expected Obj, but got I
		//IL_4e6d: Expected Obj, but got I
		//IL_4e8a: Expected VT, but got Ref
		//IL_4eb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ec0: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ecc: Expected Obj, but got Ref
		//IL_23a1: Expected Obj, but got I4
		//IL_23aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_23af: Expected Obj, but got Unknown
		//IL_23d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2405: Unknown result type (might be due to invalid IL or missing references)
		//IL_2429: Expected Obj, but got I
		//IL_22a0: Expected Obj, but got I
		//IL_22c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c9: Expected Obj, but got Unknown
		//IL_2305: Unknown result type (might be due to invalid IL or missing references)
		//IL_5781: Expected Obj, but got Ref
		//IL_09c1: Expected Obj, but got I
		//IL_30c1: Expected Obj, but got I
		//IL_30cc: Expected Obj, but got I4
		//IL_3c6a: Expected Obj, but got I
		//IL_3c80: Expected Obj, but got I
		//IL_3c88: Expected I, but got Obj
		//IL_3cb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d19: Expected Obj, but got Ref
		//IL_375a: Unknown result type (might be due to invalid IL or missing references)
		//IL_375e: Unknown result type (might be due to invalid IL or missing references)
		//IL_377c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3780: Unknown result type (might be due to invalid IL or missing references)
		//IL_3788: Unknown result type (might be due to invalid IL or missing references)
		//IL_3794: Expected Obj, but got Ref
		//IL_379d: Expected Obj, but got I4
		//IL_4ee7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4eec: Expected Obj, but got Unknown
		//IL_4f08: Expected Obj, but got I4
		//IL_4f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f82: Expected Obj, but got I
		//IL_4f93: Expected Obj, but got I4
		//IL_4fa4: Expected Obj, but got I4
		//IL_4fbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fea: Unknown result type (might be due to invalid IL or missing references)
		//IL_5026: Expected Obj, but got I
		//IL_5026: Unknown result type (might be due to invalid IL or missing references)
		//IL_502a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4dda: Expected Obj, but got I
		//IL_4dfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e03: Expected Obj, but got Unknown
		//IL_4e3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d9: Expected Obj, but got I
		//IL_16f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1700: Unknown result type (might be due to invalid IL or missing references)
		//IL_170a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_1729: Unknown result type (might be due to invalid IL or missing references)
		//IL_1747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a52: Expected VT, but got I4
		//IL_0a62: Expected Obj, but got I
		//IL_0a75: Expected Obj, but got I4
		//IL_0a7e: Expected Obj, but got I4
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_327b: Unknown result type (might be due to invalid IL or missing references)
		//IL_243d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2447: Unknown result type (might be due to invalid IL or missing references)
		//IL_2451: Unknown result type (might be due to invalid IL or missing references)
		//IL_245c: Unknown result type (might be due to invalid IL or missing references)
		//IL_247a: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c5: Expected VT, but got I4
		//IL_24d5: Expected Obj, but got I
		//IL_24e5: Expected Obj, but got Ref
		//IL_3141: Unknown result type (might be due to invalid IL or missing references)
		//IL_3149: Unknown result type (might be due to invalid IL or missing references)
		//IL_314d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3151: Unknown result type (might be due to invalid IL or missing references)
		//IL_3156: Unknown result type (might be due to invalid IL or missing references)
		//IL_315a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3195: Expected VT, but got I4
		//IL_31b7: Expected Obj, but got Ref
		//IL_31c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_31cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_31e0: Expected I4, but got Obj
		//IL_3d3f: Expected Obj, but got I
		//IL_3d4f: Expected Obj, but got I
		//IL_3d78: Expected Obj, but got I4
		//IL_37b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_37b9: Expected Obj, but got Unknown
		//IL_37df: Expected Obj, but got I8
		//IL_37ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_37f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3810: Unknown result type (might be due to invalid IL or missing references)
		//IL_3814: Unknown result type (might be due to invalid IL or missing references)
		//IL_381c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3828: Expected Obj, but got Ref
		//IL_1781: Expected Obj, but got I
		//IL_17b3: Expected Obj, but got I4
		//IL_0acb: Expected Obj, but got I
		//IL_0ad3: Expected I, but got Obj
		//IL_0ae9: Expected Obj, but got I
		//IL_0b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b51: Expected VT, but got I4
		//IL_0b69: Expected Obj, but got I
		//IL_0b7c: Expected Obj, but got I4
		//IL_0b85: Expected Obj, but got I4
		//IL_0b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e4f: Expected Obj, but got I
		//IL_3e5f: Expected Obj, but got I
		//IL_3e7c: Expected VT, but got Ref
		//IL_3ec4: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17dd: Expected I8, but got Unknown
		//IL_17f8: Expected Obj, but got Ref
		//IL_3da3: Expected Obj, but got I
		//IL_3dbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ddc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3de1: Expected Obj, but got Unknown
		//IL_3e36: Unknown result type (might be due to invalid IL or missing references)
		//IL_384e: Expected Obj, but got I
		//IL_3857: Unknown result type (might be due to invalid IL or missing references)
		//IL_385c: Expected Obj, but got Unknown
		//IL_3877: Unknown result type (might be due to invalid IL or missing references)
		//IL_387c: Expected I4, but got Unknown
		//IL_181c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1826: Unknown result type (might be due to invalid IL or missing references)
		//IL_1830: Unknown result type (might be due to invalid IL or missing references)
		//IL_183b: Unknown result type (might be due to invalid IL or missing references)
		//IL_184f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd1: Expected Obj, but got I
		//IL_0be1: Expected Obj, but got I
		//IL_0c0a: Expected Obj, but got I4
		//IL_38aa: Expected Obj, but got I4
		//IL_38ba: Expected Obj, but got I4
		//IL_38da: Unknown result type (might be due to invalid IL or missing references)
		//IL_38df: Expected Obj, but got Unknown
		//IL_38df: Unknown result type (might be due to invalid IL or missing references)
		//IL_38e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3901: Unknown result type (might be due to invalid IL or missing references)
		//IL_3905: Unknown result type (might be due to invalid IL or missing references)
		//IL_390d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3919: Expected Obj, but got Ref
		//IL_0ccb: Expected Obj, but got I
		//IL_0cdb: Expected Obj, but got I
		//IL_0cfa: Expected VT, but got Ref
		//IL_0d12: Expected Obj, but got I
		//IL_0d12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d16: Unknown result type (might be due to invalid IL or missing references)
		//IL_3223: Expected Obj, but got I
		//IL_323c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3251: Expected Obj, but got I4
		//IL_3261: Expected I4, but got Obj
		//IL_18a2: Expected Obj, but got I
		//IL_18b8: Expected Obj, but got I
		//IL_18c0: Expected I, but got Obj
		//IL_18e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1901: Unknown result type (might be due to invalid IL or missing references)
		//IL_1915: Unknown result type (might be due to invalid IL or missing references)
		//IL_1935: Unknown result type (might be due to invalid IL or missing references)
		//IL_195e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2e: Expected Obj, but got I
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c43: Expected Obj, but got Unknown
		//IL_0c59: Expected Obj, but got I
		//IL_0c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7b: Expected Obj, but got Unknown
		//IL_0c9d: Expected Obj, but got I
		//IL_0c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3938: Unknown result type (might be due to invalid IL or missing references)
		//IL_393d: Expected Obj, but got Unknown
		//IL_3963: Expected Obj, but got I8
		//IL_3972: Unknown result type (might be due to invalid IL or missing references)
		//IL_3976: Unknown result type (might be due to invalid IL or missing references)
		//IL_3994: Unknown result type (might be due to invalid IL or missing references)
		//IL_3998: Unknown result type (might be due to invalid IL or missing references)
		//IL_39a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_39ac: Expected Obj, but got Ref
		//IL_1990: Expected Obj, but got I
		//IL_19a0: Expected Obj, but got I
		//IL_19c9: Expected Obj, but got I4
		//IL_39d2: Expected Obj, but got I
		//IL_39db: Unknown result type (might be due to invalid IL or missing references)
		//IL_39e0: Expected Obj, but got Unknown
		//IL_1a6e: Expected Obj, but got I
		//IL_1a7e: Expected Obj, but got I
		//IL_1a9b: Expected VT, but got Ref
		//IL_1abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad4: Expected Obj, but got Ref
		//IL_3a20: Expected Obj, but got I4
		//IL_3a30: Expected Obj, but got I4
		//IL_3a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a55: Expected I4, but got Unknown
		//IL_3a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a59: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a83: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a8f: Expected Obj, but got Ref
		//IL_1af3: Expected Obj, but got I4
		//IL_1b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f4: Expected Obj, but got I
		//IL_1a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1d: Expected Obj, but got Unknown
		//IL_1a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ab3: Expected Obj, but got Unknown
		//IL_1b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8f: Unknown result type (might be due to invalid IL or missing references)
		List<Row> list = rows;
		bool flag = rows == null;
		Enumerator<, > val = (Enumerator<, >)0;
		Enumerator<, > val2 = (Enumerator<, >)0;
		Enumerator<, > val3 = (Enumerator<, >)0;
		Enumerator<, > val4 = (Enumerator<, >)0;
		List<Row> list2 = null;
		Comparison<Row> comparison = null;
		Enumerator<, > val5 = (Enumerator<, >)0;
		string text = null;
		DateTimeOffset dateTimeOffset = (DateTimeOffset)0;
		Enumerator<, > val6 = (Enumerator<, >)0;
		Enumerator<, > val7 = (Enumerator<, >)0;
		Enumerator<, > val8 = (Enumerator<, >)0;
		IntPtr intPtr = default;
		Comparison<Row> comparison2 = (Comparison<Row>)(nint)intPtr;
		List<Row> list3 = default;
		string text2;
		string text3 = default;
		Enumerator<, > val11 = default;
		UnityEngine.Object obj32;
		List<Row> list9;
		object obj52;
		object obj23;
		object obj17;
		object obj41 = default;
		object obj42 = default;
		nint num2;
		int num;
		string text8 = default;
		GillaFriends.News news;
		List<Entry> list6 = default;
		string text4;
		Enumerator<, > val9;
		IEnumerable<Row> enumerable;
		List<Row> list8;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+1C]");
			num2 = (nint)0 + (nint)1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
			bool flag2 = (nint)0 < (nint)1;
			comparison2 = (Comparison<Row>)(nint)intPtr;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+10]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
				Array.Clear((Array)num3, 0, 0);
				object obj2 = 0;
				comparison2 = null;
			}
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v195+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v195+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ X8_v129+28]");
			if ((nint)0 != 0)
			{
				list3 = rows;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v195+E4]");
				bool flag4 = (nint)0 == 0;
				object obj6 = !flag4;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = list3 == null;
				val = (Enumerator<, >)0;
				val2 = (Enumerator<, >)0;
				val3 = (Enumerator<, >)0;
				val4 = (Enumerator<, >)0;
				list2 = null;
				comparison = null;
				val5 = (Enumerator<, >)0;
				text = null;
				dateTimeOffset = (DateTimeOffset)0;
				val6 = (Enumerator<, >)0;
				val7 = (Enumerator<, >)0;
				val8 = (Enumerator<, >)0;
				if (!flag5)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1978]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1643 @ X8_v281+A0]");
					object obj8 = 0;
					num = (int)num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ X8_v282+28]");
					enumerable = (IEnumerable<Row>)0;
					List<Row> list4 = list3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ X8_v282+28]");
					list4.AddRange((IEnumerable<Row>)0);
					val6 = (Enumerator<, >)0;
					text2 = text3;
					val7 = (Enumerator<, >)0;
					val9 = (Enumerator<, >)0;
					goto IL_0e13;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
				object obj9 = 0;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1331 @ X0_v342+E4]");
				bool flag6 = (nint)0 == 0;
				object obj11 = !flag6;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool isPlaying = Application.isPlaying;
				bool flag7 = !isPlaying;
				val6 = (Enumerator<, >)0;
				text2 = text3;
				val7 = (Enumerator<, >)0;
				val9 = (Enumerator<, >)0;
				enumerable = (IEnumerable<Row>)(object)comparison2;
				if (flag7)
				{
					goto IL_0e13;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
				object obj12 = 0;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ X0_v347+E4]");
				bool flag8 = (nint)0 == 0;
				object obj14 = !flag8;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj13 = obj12;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ X0_v347+A0]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X8_v252+8]");
				bool flag9 = (nint)0 == 0;
				val = (Enumerator<, >)0;
				val2 = (Enumerator<, >)0;
				val3 = (Enumerator<, >)0;
				val4 = (Enumerator<, >)0;
				list2 = null;
				comparison = null;
				val5 = (Enumerator<, >)0;
				text = null;
				dateTimeOffset = (DateTimeOffset)0;
				val6 = (Enumerator<, >)0;
				val7 = (Enumerator<, >)0;
				val8 = (Enumerator<, >)0;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X8_v252+8]");
					Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF630]");
					news = (GillaFriends.News)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1988]");
					obj17 = 0;
					val6 = (Enumerator<, >)0;
					Enumerator<, > val10 = default;
					val9 = val10;
					num2 = (nint)(&val7);
					Enumerator<, > val12 = default;
					object obj22;
					List<Row> list5;
					while (val7.MoveNext())
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj18 = 0;
						object obj19 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2637 @ X0_v354+E4]");
						bool flag10 = (nint)0 == 0;
						object obj20 = !flag10;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag11 = (UnityEngine.Object)(object)text3 == null;
						bool flag12 = !flag11;
						object obj21 = !flag12;
						num = 0;
						if (obj21 != null)
						{
							continue;
						}
						bool flag13 = text3 == null;
						val = (Enumerator<, >)0;
						val2 = (Enumerator<, >)0;
						val3 = (Enumerator<, >)0;
						val4 = (Enumerator<, >)0;
						list2 = null;
						comparison = null;
						val5 = (Enumerator<, >)0;
						text = null;
						dateTimeOffset = (DateTimeOffset)0;
						text4 = null;
						list5 = null;
						obj22 = 1;
						obj23 = 109891584;
						val7 = val10;
						val8 = val9;
						val11 = (Enumerator<, >)(ref val7);
						list3 = (List<Row>)(object)text3;
						comparison2 = null;
						num = 0;
						if (flag13)
						{
							goto IL_5350;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj24 = 0;
						object obj25 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3131 @ X0_v358+E4]");
						bool flag14 = (nint)0 == 0;
						object obj26 = !flag14;
						if (obj26 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4099 @ stack_-A0_v34 (System.String)+40]");
						bool flag15 = (UnityEngine.Object)0 == null;
						bool flag16 = !flag15;
						object obj27 = !flag16;
						num = 0;
						if (obj27 != null)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4099 @ stack_-A0_v34 (System.String)+40]");
						object obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4099 @ stack_-A0_v34 (System.String)+40]");
						bool flag17 = (nint)0 == 0;
						val = (Enumerator<, >)0;
						val2 = (Enumerator<, >)0;
						val3 = (Enumerator<, >)0;
						val4 = (Enumerator<, >)0;
						list2 = null;
						comparison = null;
						val5 = (Enumerator<, >)0;
						text = null;
						dateTimeOffset = (DateTimeOffset)0;
						text4 = null;
						list5 = null;
						obj22 = 1;
						obj23 = 109891584;
						val7 = val10;
						val8 = val9;
						val11 = (Enumerator<, >)(ref val7);
						list3 = (List<Row>)(object)text3;
						comparison2 = null;
						num = 0;
						if (flag17)
						{
							goto IL_535e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj29 = 0;
						object obj30 = obj29;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4463 @ X0_v363+E4]");
						bool flag18 = (nint)0 == 0;
						object obj31 = !flag18;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X22_v56+30]");
						bool flag19 = (UnityEngine.Object)0;
						bool flag20 = !flag19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X22_v56+30]");
						list6 = (List<Entry>)0;
						num = 0;
						if (flag20)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X22_v56+30]");
						bool flag21 = (nint)0 == 0;
						val = (Enumerator<, >)0;
						val2 = (Enumerator<, >)0;
						val3 = (Enumerator<, >)0;
						val4 = (Enumerator<, >)0;
						list2 = null;
						comparison = null;
						val5 = (Enumerator<, >)0;
						text = null;
						dateTimeOffset = (DateTimeOffset)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X22_v56+30]");
						list6 = (List<Entry>)0;
						text4 = null;
						list5 = null;
						obj22 = 1;
						obj23 = 109891584;
						val7 = val10;
						val11 = (Enumerator<, >)(ref val7);
						obj32 = (UnityEngine.Object)(object)text3;
						enumerable = null;
						num = 0;
						if (flag21)
						{
							goto IL_53f4;
						}
						ArgumentNullException ex = new ArgumentNullException();
						object obj33 = ex & 1;
						bool flag22 = obj33 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X22_v56+30]");
						list6 = (List<Entry>)0;
						num = 0;
						if (flag22)
						{
							continue;
						}
						string playerName = ((NetworkApe)(object)text3).PlayerName;
						List<Row> list7 = rows;
						bool flag23 = playerName == null;
						val = (Enumerator<, >)0;
						val2 = (Enumerator<, >)0;
						val3 = (Enumerator<, >)0;
						val4 = (Enumerator<, >)0;
						list2 = null;
						comparison = null;
						val5 = (Enumerator<, >)0;
						text = null;
						dateTimeOffset = (DateTimeOffset)0;
						val6 = (Enumerator<, >)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X22_v56+30]");
						list6 = (List<Entry>)0;
						text4 = null;
						list5 = null;
						obj22 = 1;
						obj23 = 109891584;
						val7 = val10;
						val9 = (Enumerator<, >)0;
						val11 = (Enumerator<, >)(ref val7);
						list8 = (List<Row>)(object)text3;
						enumerable = null;
						num = 0;
						if (!flag23)
						{
							num2 = (nint)news;
							bool flag24 = playerName._stringLength < 0;
							bool flag25 = playerName._stringLength == 0;
							int num4 = playerName._stringLength ^ playerName._stringLength;
							int num5 = playerName._stringLength & num4;
							bool flag26 = num5 < 0;
							bool flag27 = flag24 == flag26;
							object obj34 = !flag25;
							object obj35 = flag27 & obj34;
							object obj36 = ~obj35;
							if (obj36 == null)
							{
								string text5 = playerName;
							}
							else
							{
								string text5 = (string)(object)news;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							if (((NetworkApe)(object)text3).IsLocal)
							{
								string accountId = ((NetworkApe)(object)text3).AccountId;
								string text6 = accountId;
							}
							else
							{
								string moderationId = ((NetworkApe)(object)text3).ModerationId;
								string text6 = moderationId;
							}
							object obj37 = (nint)(&val6) | (nint)8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							string text7;
							if (((NetworkApe)(object)text3).IsLocal)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
								object obj38 = 0;
								text7 = (string)obj38;
							}
							else
							{
								string photonUser = ((NetworkApe)(object)text3).PhotonUser;
								text7 = photonUser;
							}
							object obj39 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val6, 16));
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							int playerLevel = ((NetworkApe)(object)text3).PlayerLevel;
							Color32 furColour = ((NetworkApe)(object)text3).FurColour;
							bool isLocal = ((NetworkApe)(object)text3).IsLocal;
							bool flag28 = rows == null;
							val = (Enumerator<, >)0;
							val2 = (Enumerator<, >)0;
							val3 = (Enumerator<, >)0;
							val4 = (Enumerator<, >)0;
							list2 = null;
							comparison = null;
							val5 = (Enumerator<, >)0;
							text = null;
							dateTimeOffset = (DateTimeOffset)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X22_v56+30]");
							list6 = (List<Entry>)0;
							text4 = null;
							list5 = null;
							obj22 = 1;
							obj23 = 109891584;
							val7 = val10;
							val9 = (Enumerator<, >)0;
							val11 = (Enumerator<, >)(ref val7);
							obj32 = (UnityEngine.Object)(object)text3;
							comparison2 = null;
							num = 0;
							if (!flag28)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2351 @ X22_v57 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+10]");
								object obj40 = 0;
								num2 = (nint)obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2351 @ X22_v57 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+1C]");
								obj41 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2351 @ X22_v57 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+10]");
								bool flag29 = (nint)0 == 0;
								val = (Enumerator<, >)0;
								val2 = (Enumerator<, >)0;
								val3 = (Enumerator<, >)0;
								val4 = (Enumerator<, >)0;
								list2 = null;
								comparison = null;
								val5 = (Enumerator<, >)0;
								text = null;
								dateTimeOffset = (DateTimeOffset)0;
								text8 = text7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X22_v56+30]");
								list6 = (List<Entry>)0;
								text4 = null;
								list5 = null;
								obj22 = 1;
								obj23 = 109891584;
								val7 = val10;
								val9 = val6;
								val11 = (Enumerator<, >)(ref val7);
								obj32 = (UnityEngine.Object)(object)text3;
								comparison2 = null;
								num = 0;
								if (!flag29)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2351 @ X22_v57 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
									obj41 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3007 @ X8_v274+18]");
									obj42 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2351 @ X22_v57 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
									nint num6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3007 @ X8_v274+18]");
									bool flag30 = num6 < 0;
									object obj43 = !flag30;
									if (obj43 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2351 @ X22_v57 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
										object obj44 = (nint)0 * (nint)40;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2351 @ X22_v57 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+10]");
										object obj45 = 0 + obj44;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2351 @ X22_v57 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
										object obj46 = (nint)0 + (nint)1;
										object obj47 = obj45 + 32;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										text8 = text7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X22_v56+30]");
										list6 = (List<Entry>)0;
										val9 = val6;
										num2 = (isLocal ? 1 : 0);
										num = 0;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3789 @ X9_v77 (Il2CppClass<System.Collections.Generic.List`1<GillaLeaderboard+Row>>)+20]");
										object obj48 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5453 @ X8_v275+A8]");
										object obj49 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2388 @ X8_v276+70]");
										num = 0;
										rows.AddWithResize((Row)(&val12));
										text8 = text7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ X22_v56+30]");
										list6 = (List<Entry>)0;
										val9 = val6;
										num2 = (isLocal ? 1 : 0);
									}
									continue;
								}
							}
							goto IL_53de;
						}
						goto IL_5427;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
					object obj50 = 0;
					enumerable = (IEnumerable<Row>)obj50;
					val7.Dispose();
					val = (Enumerator<, >)0;
					val2 = (Enumerator<, >)0;
					val3 = (Enumerator<, >)0;
					val4 = (Enumerator<, >)0;
					list2 = null;
					comparison = null;
					val5 = (Enumerator<, >)0;
					text = null;
					dateTimeOffset = (DateTimeOffset)0;
					text4 = null;
					list5 = null;
					obj22 = 1;
					obj23 = 109891584;
					val7 = val10;
					val11 = (Enumerator<, >)(ref val7);
					list8 = null;
					OutOfMemoryException ex2 = new OutOfMemoryException();
					if ((nint)enumerable == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						list9 = list5;
						text4 = (string)1;
					}
					else
					{
						if ((nint)enumerable != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0E48");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						object obj51 = default;
						list9 = (List<Row>)obj51;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						list5 = (List<Row>)obj51;
					}
					obj52 = 0;
					goto IL_602e;
				}
			}
		}
		goto IL_5302;
		IL_5443:
		throw new NullReferenceException();
		IL_1b3b:
		val = (Enumerator<, >)0;
		val2 = (Enumerator<, >)0;
		val3 = (Enumerator<, >)0;
		val4 = (Enumerator<, >)0;
		list2 = null;
		comparison = null;
		val5 = (Enumerator<, >)0;
		List<Row> list10 = null;
		Comparison<Row> comparison3 = null;
		string text10;
		string text9 = text10;
		Enumerator<, > val13 = (Enumerator<, >)0;
		text = text10;
		string text12;
		string text11 = text12;
		text3 = text2;
		goto IL_5054;
		IL_532c:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_533a;
		IL_47f8:
		GillaFriends.State state;
		news = (GillaFriends.News)(object)state.asked;
		bool flag31 = state.asked == null;
		GillaFriends.State state2 = state;
		Comparison<Row> comparison4;
		List<Row> list11 = (List<Row>)(object)comparison4;
		text3 = text2;
		val8 = val9;
		list3 = list8;
		if (flag31)
		{
			goto IL_5302;
		}
		string k = news.k;
		bool flag32 = (nint)news.k < 1;
		state2 = state;
		text3 = text2;
		if (flag32)
		{
			goto IL_5054;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A10]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D18F8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1980]");
		obj23 = 0;
		object obj55 = default;
		object obj54 = obj55;
		List<Row> list12 = list2;
		Comparison<Row> comparison5 = comparison;
		List<Row> list13 = default;
		Comparison<Row> comparison6 = (Comparison<Row>)(object)list13;
		Comparison<Row> comparison8 = default;
		Comparison<Row> comparison7 = comparison8;
		List<Row> list14 = list10;
		Comparison<Row> comparison9 = comparison3;
		Comparison<Row> comparison10 = comparison4;
		string text13 = text9;
		Enumerator<, > val14 = val13;
		string text14 = text;
		string text15 = text11;
		object obj56 = obj42;
		object obj57 = obj41;
		string text16 = text8;
		List<Entry> list15 = list6;
		object obj58 = 0;
		Enumerator<, > val15 = val9;
		List<Row> list16 = list8;
		Comparison<Row> comparison11 = comparison2;
		nint num7 = num2;
		int num8 = num;
		while (true)
		{
			bool flag33 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj58) < System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref k);
			object obj59 = !flag33;
			obj55 = obj54;
			list2 = list12;
			comparison = comparison5;
			state2 = state;
			list13 = (List<Row>)(object)comparison6;
			comparison8 = comparison7;
			list10 = list14;
			comparison3 = comparison9;
			list11 = (List<Row>)(object)comparison10;
			text9 = text13;
			val13 = val14;
			text = text14;
			text11 = text15;
			obj42 = obj56;
			obj41 = obj57;
			text8 = text16;
			list6 = list15;
			text3 = text2;
			object obj22 = 1;
			val8 = val15;
			list3 = list16;
			comparison2 = comparison11;
			num2 = num7;
			num = num8;
			if (obj59 != null)
			{
				break;
			}
			object obj60 = (object)news + obj58;
			list8 = (List<Row>)(object)entries;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X8_v53+20]");
			list6 = (List<Entry>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X8_v53+20]");
			bool flag34 = (nint)0 == 0;
			obj55 = obj54;
			list2 = null;
			comparison = null;
			val5 = (Enumerator<, >)0;
			state2 = state;
			list13 = (List<Row>)(object)comparison6;
			comparison8 = comparison7;
			list10 = list14;
			comparison3 = comparison9;
			list11 = (List<Row>)(object)comparison10;
			text9 = text13;
			val13 = val14;
			text = null;
			text11 = text15;
			obj42 = obj56;
			obj41 = obj57;
			text8 = text16;
			text3 = text2;
			obj22 = 1;
			val8 = (Enumerator<, >)0;
			list3 = (List<Row>)(object)entries;
			comparison2 = comparison11;
			num2 = num7;
			num = num8;
			if (!flag34)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
				object obj61 = 0;
				object obj62 = obj61;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4671 @ X0_v82+E4]");
				bool flag35 = (nint)0 == 0;
				object obj63 = !flag35;
				if (obj63 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
				string text17 = NameOf((string)num9, (string)0);
				object obj64 = (nint)(&val5) | (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj65 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val5, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj66 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val5, 32));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag36 = list8 == null;
				obj55 = 1;
				list2 = null;
				comparison = (Comparison<Row>)obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
				val5 = (Enumerator<, >)0;
				state2 = state;
				list13 = (List<Row>)(object)comparison6;
				comparison8 = comparison7;
				list10 = list14;
				comparison3 = comparison9;
				list11 = (List<Row>)(object)comparison10;
				text9 = text13;
				val13 = val14;
				text = (string)obj53;
				text11 = text17;
				obj42 = obj56;
				obj41 = obj57;
				text8 = text16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
				list6 = (List<Entry>)0;
				text3 = text2;
				obj22 = 1;
				val8 = (Enumerator<, >)0;
				list3 = list8;
				comparison2 = (Comparison<Row>)obj17;
				num2 = num7;
				num = num8;
				if (!flag36)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+10]");
					object obj67 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+1C]");
					obj41 = (nint)0 + (nint)1;
					num2 = (nint)obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+10]");
					bool flag37 = (nint)0 == 0;
					obj55 = 1;
					list2 = null;
					comparison = (Comparison<Row>)obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
					val5 = (Enumerator<, >)0;
					state2 = state;
					list13 = (List<Row>)(object)comparison6;
					comparison8 = comparison7;
					list10 = null;
					comparison3 = (Comparison<Row>)obj17;
					list11 = null;
					text9 = (string)obj53;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
					val13 = (Enumerator<, >)0;
					text = (string)obj53;
					text11 = text17;
					obj42 = obj56;
					text8 = (string)obj53;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
					list6 = (List<Entry>)0;
					text3 = text2;
					obj22 = 1;
					val8 = (Enumerator<, >)obj17;
					list3 = list8;
					comparison2 = (Comparison<Row>)obj17;
					num = num8;
					if (!flag37)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
						obj41 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v997 @ X8_v57+18]");
						obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
						nint num10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v997 @ X8_v57+18]");
						bool flag38 = num10 < 0;
						object obj68 = !flag38;
						if (obj68 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+10]");
							nint num11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
							object obj69 = num11 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
							num2 = (nint)0 + (nint)1;
							object obj70 = obj69 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							comparison4 = (Comparison<Row>)obj17;
							text8 = (string)obj53;
							val9 = (Enumerator<, >)0;
							comparison2 = null;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3789 @ X9_v77 (Il2CppClass<System.Collections.Generic.List`1<GillaLeaderboard+Row>>)+20]");
							object obj71 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5102 @ X8_v60+A8]");
							object obj72 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5107 @ X8_v61+70]");
							num8 = 0;
							((List<Entry>)(object)list8).AddWithResize((Entry)(&val11));
							comparison6 = null;
							comparison7 = (Comparison<Row>)obj17;
							comparison4 = null;
							text8 = (string)obj53;
							text2 = (string)obj53;
							val9 = (Enumerator<, >)obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
							val11 = (Enumerator<, >)0;
							comparison2 = (Comparison<Row>)(&val11);
						}
						k = news.k;
						obj58++;
						object obj73 = obj58;
						string k2 = news.k;
						bool flag39 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj73) < System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref k2);
						obj55 = 1;
						list2 = null;
						comparison = (Comparison<Row>)obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
						val5 = (Enumerator<, >)0;
						state2 = state;
						list13 = (List<Row>)(object)comparison6;
						comparison8 = comparison7;
						list10 = null;
						comparison3 = (Comparison<Row>)obj17;
						text9 = (string)obj53;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
						val13 = (Enumerator<, >)0;
						text = (string)obj53;
						text11 = text17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
						list6 = (List<Entry>)0;
						text3 = text2;
						obj22 = 1;
						num = num8;
						obj54 = 1;
						list12 = null;
						comparison5 = (Comparison<Row>)obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
						val5 = (Enumerator<, >)0;
						list14 = null;
						comparison9 = (Comparison<Row>)obj17;
						comparison10 = comparison4;
						text13 = (string)obj53;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
						val14 = (Enumerator<, >)0;
						text14 = (string)obj53;
						text15 = text17;
						obj56 = obj42;
						obj57 = obj41;
						text16 = text8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
						list15 = (List<Entry>)0;
						val15 = val9;
						list16 = list8;
						comparison11 = comparison2;
						num7 = num2;
						if (flag39)
						{
							continue;
						}
						goto IL_5054;
					}
				}
			}
			goto IL_5302;
		}
		goto IL_5310;
		IL_5396:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		goto IL_53a4;
		IL_531e:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_532c;
		IL_2437:
		val = (Enumerator<, >)0;
		val2 = (Enumerator<, >)0;
		val3 = (Enumerator<, >)0;
		val4 = (Enumerator<, >)0;
		list2 = null;
		object obj74;
		comparison = (Comparison<Row>)obj74;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
		val5 = (Enumerator<, >)0;
		Comparison<Row> comparison12;
		list13 = (List<Row>)(object)comparison12;
		list10 = null;
		comparison3 = (Comparison<Row>)obj74;
		object obj75;
		text9 = (string)obj75;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
		val13 = (Enumerator<, >)0;
		text = (string)obj75;
		string text18;
		text11 = text18;
		dateTimeOffset = (DateTimeOffset)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
		list6 = (List<Entry>)0;
		text3 = text2;
		obj23 = (object)(&val5);
		goto IL_5054;
		IL_535e:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_536c;
		IL_5350:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_535e;
		IL_5310:
		IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
		goto IL_531e;
		IL_533a:
		NullReferenceException ex9 = new NullReferenceException();
		text4 = text3;
		goto IL_5350;
		IL_5302:
		NullReferenceException ex10 = new NullReferenceException();
		goto IL_5310;
		IL_5054:
		List<Entry> list17 = entries;
		bool flag40 = entries == null;
		list11 = (List<Row>)(object)comparison4;
		val8 = val9;
		list3 = list8;
		if (!flag40)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj76 = 0;
			object obj77 = obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v34 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
			object obj78 = -10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4082 @ X0_v64+E4]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4082 @ X0_v64+E4]");
			bool flag41 = (nint)0 == 0;
			object obj79 = !flag41;
			if (obj79 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj80 = ~obj78;
			Enumerator<, > val16 = (Enumerator<, >)(obj78 & obj80);
			bool flag42 = drum != null;
			UnityEngine.Object obj81 = drum;
			if (flag42)
			{
				bool flag43 = (object)drum == null;
				list11 = (List<Row>)(object)comparison4;
				val8 = val9;
				list3 = (List<Row>)(object)drum;
				comparison2 = null;
				num = 0;
				if (flag43)
				{
					goto IL_5302;
				}
				val9 = val16;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj82 = 0;
			object obj83 = obj82;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4539 @ X0_v68+E4]");
			bool flag44 = (nint)0 == 0;
			object obj84 = !flag44;
			if (obj84 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Enumerator<, > val17;
			if (drum != null)
			{
				bool flag45 = (object)drum == null;
				list11 = (List<Row>)(object)comparison4;
				val8 = val9;
				list3 = (List<Row>)(object)drum;
				comparison2 = null;
				num = 0;
				if (flag45)
				{
					goto IL_5302;
				}
				int step = drum.Step;
				object obj85 = step - val16;
				bool flag46 = (nint)obj85 < 0;
				int num12 = step ^ val16;
				int num13 = step ^ obj85;
				int num14 = num12 & num13;
				bool flag47 = num14 < 0;
				bool flag48 = flag46 == flag47;
				object obj86 = !flag48;
				object obj87 = ~obj86;
				val17 = ((obj87 != null) ? val16 : ((Enumerator<, >)step));
				bool flag49 = step < 0;
				int num15 = step ^ step;
				int num16 = step & num15;
				bool flag50 = num16 < 0;
				bool flag51 = flag49 == flag50;
				object obj88 = !flag51;
				object obj89 = ~obj88;
				if (obj89 == null)
				{
					val17 = (Enumerator<, >)0;
				}
			}
			else
			{
				val17 = (Enumerator<, >)0;
			}
			top = (int)val17;
			return;
		}
		goto IL_5302;
		IL_5388:
		IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
		goto IL_5396;
		IL_0e13:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D19E0]");
		object obj90 = 0;
		list8 = rows;
		object obj91 = obj90;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1950 @ X0_v198+E4]");
		bool flag52 = (nint)0 == 0;
		object obj92 = !flag52;
		if (obj92 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj91 = obj90;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1950 @ X0_v198+A0]");
		object obj93 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2215 @ X8_v242+8]");
		Comparison<Row> comparison13 = (Comparison<Row>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2215 @ X8_v242+8]");
		bool flag53 = (nint)0 == 0;
		object obj94 = !flag53;
		comparison2 = (Comparison<Row>)(object)enumerable;
		if (obj94 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1950 @ X0_v198+E4]");
			bool flag54 = (nint)0 == 0;
			object obj95 = !flag54;
			if (obj95 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj96 = obj90;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2392 @ X8_v246+A0]");
				obj93 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1940]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D19D0]");
			object obj97 = 0;
			Comparison<Row> comparison14 = default;
			comparison14._002Ector(obj93, (IntPtr)obj97);
			object obj98 = obj90;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2091 @ X8_v245+A0]");
			object obj99 = (nint)0 + (nint)8;
			obj99 = comparison14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			list6 = (List<Entry>)obj93;
			comparison13 = comparison14;
			object obj2 = 0;
			comparison2 = comparison14;
			num = (int)obj97;
		}
		bool flag55 = list8 == null;
		val = (Enumerator<, >)0;
		val2 = (Enumerator<, >)0;
		val3 = (Enumerator<, >)0;
		val4 = (Enumerator<, >)0;
		list2 = null;
		comparison = null;
		val5 = (Enumerator<, >)0;
		text = null;
		dateTimeOffset = (DateTimeOffset)0;
		text3 = text2;
		val8 = val9;
		list3 = list8;
		GillaFriends.State state3;
		if (!flag55)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D19B0]");
			object obj100 = 0;
			num = (int)obj100;
			list8.Sort(comparison13);
			List<Entry> list18 = entries;
			bool flag56 = entries == null;
			val = (Enumerator<, >)0;
			val2 = (Enumerator<, >)0;
			val3 = (Enumerator<, >)0;
			val4 = (Enumerator<, >)0;
			list2 = null;
			comparison = null;
			val5 = (Enumerator<, >)0;
			text = null;
			dateTimeOffset = (DateTimeOffset)0;
			text3 = text2;
			val8 = val9;
			list3 = list8;
			comparison2 = comparison13;
			if (!flag56)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X8_v137 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X8_v137 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+1C]");
				num2 = (nint)0 + (nint)1;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X8_v137 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
				bool flag57 = (nint)0 < (nint)1;
				comparison2 = comparison13;
				if (!flag57)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X8_v137 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
					nint num17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X8_v137 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
					Array.Clear((Array)num17, 0, 0);
					object obj2 = 0;
					comparison2 = null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
				object obj101 = 0;
				object obj102 = obj101;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2646 @ X0_v202+E4]");
				bool flag58 = (nint)0 == 0;
				object obj103 = !flag58;
				if (obj103 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaFriends.State now = GillaFriends.Now;
				if (page > (Page)1)
				{
					bool flag59 = page == (Page)2;
					val = (Enumerator<, >)0;
					val2 = (Enumerator<, >)0;
					val3 = (Enumerator<, >)0;
					val4 = (Enumerator<, >)0;
					list2 = null;
					comparison = null;
					val5 = (Enumerator<, >)0;
					text = null;
					dateTimeOffset = (DateTimeOffset)0;
					state = now;
					if (!flag59)
					{
						if (page != (Page)3)
						{
							bool flag60 = page != (Page)4;
							val = (Enumerator<, >)0;
							val2 = (Enumerator<, >)0;
							val3 = (Enumerator<, >)0;
							val4 = (Enumerator<, >)0;
							list2 = null;
							comparison = null;
							val5 = (Enumerator<, >)0;
							comparison4 = (Comparison<Row>)(object)list11;
							text = null;
							dateTimeOffset = (DateTimeOffset)0;
							text3 = text2;
							if (flag60)
							{
								goto IL_5054;
							}
							bool flag61 = now == null;
							val = (Enumerator<, >)0;
							val2 = (Enumerator<, >)0;
							val3 = (Enumerator<, >)0;
							val4 = (Enumerator<, >)0;
							list2 = null;
							comparison = null;
							val5 = (Enumerator<, >)0;
							text = null;
							dateTimeOffset = (DateTimeOffset)0;
							text3 = text2;
							val8 = val9;
							list3 = list8;
							if (!flag61)
							{
								long num18 = now.now;
								bool flag62 = now.now == 0;
								object obj34 = !flag62;
								bool flag63 = now.now > 0;
								dateTimeOffset = (DateTimeOffset)0;
								if (!flag63)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2E8]");
									object obj104 = 0;
									object obj105 = obj104;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4405 @ X0_v324+E4]");
									bool flag64 = (nint)0 == 0;
									object obj106 = !flag64;
									if (obj106 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									DateTimeOffset utcNow = DateTimeOffset.UtcNow;
									long num19 = dateTimeOffset.ToUnixTimeMilliseconds();
									num18 = num19;
									comparison2 = null;
								}
								GillaFriends.News[] inbox = now.inbox;
								bool flag65 = now.inbox == null;
								val = (Enumerator<, >)0;
								val2 = (Enumerator<, >)0;
								val3 = (Enumerator<, >)0;
								val4 = (Enumerator<, >)0;
								list2 = null;
								comparison = null;
								val5 = (Enumerator<, >)0;
								text = null;
								text3 = text2;
								val8 = val9;
								list3 = list8;
								if (!flag65)
								{
									object obj107 = inbox.Length;
									bool flag66 = inbox.Length < 1;
									val = (Enumerator<, >)0;
									val2 = (Enumerator<, >)0;
									val3 = (Enumerator<, >)0;
									val4 = (Enumerator<, >)0;
									list2 = null;
									comparison = null;
									val5 = (Enumerator<, >)0;
									comparison4 = (Comparison<Row>)(object)list11;
									text = null;
									text3 = text2;
									if (flag66)
									{
										goto IL_5054;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1980]");
									list8 = (List<Row>)0;
									while (true)
									{
										list6 = entries;
										GillaFriends.News[] inbox2 = now.inbox;
										bool flag67 = now.inbox == null;
										val = (Enumerator<, >)0;
										val2 = (Enumerator<, >)0;
										val3 = (Enumerator<, >)0;
										val4 = (Enumerator<, >)0;
										list2 = null;
										comparison = null;
										val5 = (Enumerator<, >)0;
										text = null;
										text3 = text2;
										val8 = (Enumerator<, >)0;
										list3 = list8;
										if (flag67)
										{
											break;
										}
										num2 = inbox2.Length;
										obj107--;
										bool flag68 = (nint)obj107 < inbox2.Length;
										object obj108 = !flag68;
										val = (Enumerator<, >)0;
										val2 = (Enumerator<, >)0;
										val3 = (Enumerator<, >)0;
										val4 = (Enumerator<, >)0;
										list2 = null;
										comparison = null;
										val5 = (Enumerator<, >)0;
										text = null;
										text3 = text2;
										val8 = (Enumerator<, >)0;
										list3 = list8;
										if (obj108 == null)
										{
											object obj109 = (object)now.inbox + obj107;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
											object obj110 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4655 @ X8_v230+20]");
											news = (GillaFriends.News)0;
											object obj111 = obj110;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4657 @ X0_v306+E4]");
											num2 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4657 @ X0_v306+E4]");
											bool flag69 = (nint)0 == 0;
											object obj112 = !flag69;
											if (obj112 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											text12 = GillaFriends.Line(news);
											object obj113 = (nint)(&val5) | (nint)8;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											GillaFriends.News[] inbox3 = now.inbox;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
											obj41 = 0;
											bool flag70 = now.inbox == null;
											val = (Enumerator<, >)0;
											val2 = (Enumerator<, >)0;
											val3 = (Enumerator<, >)0;
											val4 = (Enumerator<, >)0;
											list2 = null;
											comparison = null;
											val5 = (Enumerator<, >)0;
											text = null;
											text11 = text12;
											text3 = text2;
											val8 = (Enumerator<, >)0;
											list3 = list8;
											comparison2 = (Comparison<Row>)(object)text12;
											if (flag70)
											{
												break;
											}
											num2 = inbox3.Length;
											bool flag71 = (nint)obj107 < inbox3.Length;
											object obj114 = !flag71;
											val = (Enumerator<, >)0;
											val2 = (Enumerator<, >)0;
											val3 = (Enumerator<, >)0;
											val4 = (Enumerator<, >)0;
											list2 = null;
											comparison = null;
											val5 = (Enumerator<, >)0;
											text = null;
											text11 = text12;
											text3 = text2;
											val8 = (Enumerator<, >)0;
											list3 = list8;
											comparison2 = (Comparison<Row>)(object)text12;
											if (obj114 == null)
											{
												object obj115 = (object)now.inbox + obj107;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4921 @ X8_v232+20]");
												object obj116 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4921 @ X8_v232+20]");
												bool flag72 = (nint)0 == 0;
												val = (Enumerator<, >)0;
												val2 = (Enumerator<, >)0;
												val3 = (Enumerator<, >)0;
												val4 = (Enumerator<, >)0;
												list2 = null;
												comparison = null;
												val5 = (Enumerator<, >)0;
												text = null;
												text11 = text12;
												text3 = text2;
												val8 = (Enumerator<, >)0;
												list3 = list8;
												comparison2 = (Comparison<Row>)(object)text12;
												if (flag72)
												{
													break;
												}
												object obj117 = obj41;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X8_v233+10]");
												news = (GillaFriends.News)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4950 @ X0_v312+E4]");
												num2 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4950 @ X0_v312+E4]");
												bool flag73 = (nint)0 == 0;
												object obj118 = !flag73;
												if (obj118 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												long ms = num18 - news;
												text10 = Ago(ms);
												object obj119 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val5, 16));
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												bool flag74 = list6 == null;
												val = (Enumerator<, >)0;
												val2 = (Enumerator<, >)0;
												val3 = (Enumerator<, >)0;
												val4 = (Enumerator<, >)0;
												list2 = null;
												comparison = null;
												val5 = (Enumerator<, >)0;
												text = text10;
												text11 = text12;
												text3 = text2;
												val8 = (Enumerator<, >)0;
												list3 = list8;
												comparison2 = (Comparison<Row>)(object)text10;
												if (flag74)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
												object obj120 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+1C]");
												obj41 = (nint)0 + (nint)1;
												num2 = (nint)list8;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
												bool flag75 = (nint)0 == 0;
												val = (Enumerator<, >)0;
												val2 = (Enumerator<, >)0;
												val3 = (Enumerator<, >)0;
												val4 = (Enumerator<, >)0;
												list2 = null;
												comparison = null;
												val5 = (Enumerator<, >)0;
												list10 = null;
												comparison3 = null;
												list11 = null;
												text9 = text10;
												val13 = (Enumerator<, >)0;
												text = text10;
												text11 = text12;
												text8 = text10;
												text3 = text2;
												val8 = (Enumerator<, >)0;
												list3 = list8;
												comparison2 = (Comparison<Row>)(object)text10;
												if (flag75)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
												obj41 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X8_v234+18]");
												obj42 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
												nint num20 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X8_v234+18]");
												bool flag76 = num20 < 0;
												object obj121 = !flag76;
												if (obj121 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
													nint num21 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
													object obj122 = num21 + 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
													num2 = (nint)0 + (nint)1;
													object obj123 = obj122 + 32;
													_ = 0;
													_ = 0;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													comparison4 = null;
													text8 = text10;
													val9 = (Enumerator<, >)0;
													comparison2 = null;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3789 @ X9_v77 (Il2CppClass<System.Collections.Generic.List`1<GillaLeaderboard+Row>>)+20]");
													object obj124 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5226 @ X8_v236+A8]");
													object obj125 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5231 @ X8_v237+70]");
													num = 0;
													list6.AddWithResize((Entry)(&val11));
													list13 = null;
													comparison8 = null;
													comparison4 = null;
													text8 = text10;
													text2 = text10;
													val9 = (Enumerator<, >)0;
													val11 = (Enumerator<, >)0;
													comparison2 = (Comparison<Row>)(&val11);
												}
												bool flag77 = obj107 == null;
												obj34 = !flag77;
												bool flag78 = (nint)obj107 > 0;
												list10 = null;
												comparison3 = null;
												list11 = (List<Row>)(object)comparison4;
												text9 = text10;
												val13 = (Enumerator<, >)0;
												text11 = text12;
												if (flag78)
												{
													continue;
												}
												goto IL_1b3b;
											}
										}
										goto IL_5310;
									}
								}
							}
						}
						else
						{
							bool flag79 = now == null;
							val = (Enumerator<, >)0;
							val2 = (Enumerator<, >)0;
							val3 = (Enumerator<, >)0;
							val4 = (Enumerator<, >)0;
							list2 = null;
							comparison = null;
							val5 = (Enumerator<, >)0;
							text = null;
							dateTimeOffset = (DateTimeOffset)0;
							text3 = text2;
							val8 = val9;
							list3 = list8;
							if (!flag79)
							{
								GillaFriends.Person[] blocked = now.blocked;
								bool flag80 = now.blocked == null;
								val = (Enumerator<, >)0;
								val2 = (Enumerator<, >)0;
								val3 = (Enumerator<, >)0;
								val4 = (Enumerator<, >)0;
								list2 = null;
								comparison = null;
								val5 = (Enumerator<, >)0;
								text = null;
								dateTimeOffset = (DateTimeOffset)0;
								text3 = text2;
								val8 = val9;
								list3 = list8;
								if (!flag80)
								{
									object obj126 = blocked.Length;
									bool flag81 = blocked.Length < 1;
									val = (Enumerator<, >)0;
									val2 = (Enumerator<, >)0;
									val3 = (Enumerator<, >)0;
									val4 = (Enumerator<, >)0;
									list2 = null;
									comparison = null;
									val5 = (Enumerator<, >)0;
									comparison4 = (Comparison<Row>)(object)list11;
									text = null;
									dateTimeOffset = (DateTimeOffset)0;
									text3 = text2;
									if (flag81)
									{
										goto IL_5054;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
									obj75 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1910]");
									obj74 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1980]");
									obj17 = 0;
									list2 = null;
									comparison = null;
									val5 = (Enumerator<, >)0;
									comparison12 = (Comparison<Row>)(object)list13;
									text = null;
									news = null;
									while (true)
									{
										bool flag82 = System.Runtime.CompilerServices.Unsafe.As<GillaFriends.News, UIntPtr>(ref news) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj126);
										object obj127 = !flag82;
										val = (Enumerator<, >)0;
										val2 = (Enumerator<, >)0;
										val3 = (Enumerator<, >)0;
										val4 = (Enumerator<, >)0;
										list13 = (List<Row>)(object)comparison12;
										dateTimeOffset = (DateTimeOffset)0;
										text3 = text2;
										obj23 = (object)(&val5);
										val8 = val9;
										list3 = list8;
										if (obj127 != null)
										{
											break;
										}
										object obj128 = (object)now.blocked + (object)news;
										list8 = (List<Row>)(object)entries;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X8_v216+20]");
										list6 = (List<Entry>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X8_v216+20]");
										bool flag83 = (nint)0 == 0;
										val = (Enumerator<, >)0;
										val2 = (Enumerator<, >)0;
										val3 = (Enumerator<, >)0;
										val4 = (Enumerator<, >)0;
										list2 = null;
										comparison = null;
										val5 = (Enumerator<, >)0;
										list13 = (List<Row>)(object)comparison12;
										text = null;
										dateTimeOffset = (DateTimeOffset)0;
										text3 = text2;
										obj23 = (object)(&val5);
										val8 = (Enumerator<, >)0;
										list3 = (List<Row>)(object)entries;
										if (!flag83)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
											object obj129 = 0;
											object obj130 = obj129;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4625 @ X0_v289+E4]");
											bool flag84 = (nint)0 == 0;
											object obj131 = !flag84;
											if (obj131 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
											nint num22 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
											text18 = NameOf((string)num22, (string)0);
											object obj132 = (nint)(&val5) | (nint)8;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											object obj133 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val5, 16));
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											object obj134 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val5, 32));
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											bool flag85 = list8 == null;
											val = (Enumerator<, >)0;
											val2 = (Enumerator<, >)0;
											val3 = (Enumerator<, >)0;
											val4 = (Enumerator<, >)0;
											list2 = null;
											comparison = (Comparison<Row>)obj74;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
											val5 = (Enumerator<, >)0;
											list13 = (List<Row>)(object)comparison12;
											text = (string)obj75;
											text11 = text18;
											dateTimeOffset = (DateTimeOffset)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
											list6 = (List<Entry>)0;
											text3 = text2;
											obj23 = (object)(&val5);
											val8 = (Enumerator<, >)0;
											list3 = list8;
											comparison2 = (Comparison<Row>)obj74;
											if (!flag85)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+10]");
												object obj135 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+1C]");
												obj41 = (nint)0 + (nint)1;
												num2 = (nint)obj17;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+10]");
												bool flag86 = (nint)0 == 0;
												val = (Enumerator<, >)0;
												val2 = (Enumerator<, >)0;
												val3 = (Enumerator<, >)0;
												val4 = (Enumerator<, >)0;
												list2 = null;
												comparison = (Comparison<Row>)obj74;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
												val5 = (Enumerator<, >)0;
												list13 = (List<Row>)(object)comparison12;
												list10 = null;
												comparison3 = (Comparison<Row>)obj74;
												list11 = null;
												text9 = (string)obj75;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
												val13 = (Enumerator<, >)0;
												text = (string)obj75;
												text11 = text18;
												dateTimeOffset = (DateTimeOffset)0;
												text8 = (string)obj75;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
												list6 = (List<Entry>)0;
												text3 = text2;
												obj23 = (object)(&val5);
												val8 = (Enumerator<, >)obj74;
												list3 = list8;
												comparison2 = (Comparison<Row>)obj74;
												if (!flag86)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
													obj41 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X8_v220+18]");
													obj42 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
													nint num23 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X8_v220+18]");
													bool flag87 = num23 < 0;
													object obj136 = !flag87;
													if (obj136 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+10]");
														nint num24 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
														object obj137 = num24 + 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
														num2 = (nint)0 + (nint)1;
														object obj138 = obj137 + 32;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
														_ = 0;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														comparison4 = (Comparison<Row>)obj74;
														text8 = (string)obj75;
														val9 = (Enumerator<, >)0;
														comparison2 = null;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3789 @ X9_v77 (Il2CppClass<System.Collections.Generic.List`1<GillaLeaderboard+Row>>)+20]");
														object obj139 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5003 @ X8_v223+A8]");
														object obj140 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5008 @ X8_v224+70]");
														num = 0;
														((List<Entry>)(object)list8).AddWithResize((Entry)(&val11));
														comparison12 = null;
														comparison8 = (Comparison<Row>)obj74;
														comparison4 = null;
														text8 = (string)obj75;
														text2 = (string)obj75;
														val9 = (Enumerator<, >)obj74;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
														val11 = (Enumerator<, >)0;
														comparison2 = (Comparison<Row>)(&val11);
													}
													obj126 = blocked.Length;
													news = (GillaFriends.News)(news + 1);
													bool flag88 = (nint)news < blocked.Length;
													list2 = null;
													comparison = (Comparison<Row>)obj74;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
													val5 = (Enumerator<, >)0;
													list10 = null;
													comparison3 = (Comparison<Row>)obj74;
													list11 = (List<Row>)(object)comparison4;
													text9 = (string)obj75;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
													val13 = (Enumerator<, >)0;
													text = (string)obj75;
													text11 = text18;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X23_v47 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
													list6 = (List<Entry>)0;
													if (flag88)
													{
														continue;
													}
													goto IL_2437;
												}
											}
										}
										goto IL_5302;
									}
									goto IL_5310;
								}
							}
						}
					}
					else
					{
						bool flag89 = state == null;
						text3 = text2;
						val8 = val9;
						list3 = list8;
						if (!flag89)
						{
							list8 = (List<Row>)(object)state.asking;
							bool flag90 = state.asking == null;
							state2 = state;
							text3 = text2;
							val8 = val9;
							list3 = (List<Row>)(object)state.asking;
							if (!flag90)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
								object obj141 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
								bool flag91 = (nint)0 < (nint)1;
								comparison4 = (Comparison<Row>)(object)list11;
								if (flag91)
								{
									goto IL_47f8;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D19F8]");
								object obj142 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1928]");
								object obj143 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1918]");
								obj17 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1980]");
								obj23 = 0;
								object obj145 = default;
								object obj144 = obj145;
								List<Row> list19 = list2;
								Comparison<Row> comparison15 = comparison;
								Comparison<Row> comparison16 = (Comparison<Row>)(object)list13;
								Comparison<Row> comparison17 = comparison8;
								List<Row> list20 = list10;
								Comparison<Row> comparison18 = comparison3;
								string text19 = text9;
								Enumerator<, > val18 = val13;
								string text20 = text;
								string text21 = text11;
								object obj146 = obj42;
								object obj147 = obj41;
								string text22 = text8;
								List<Entry> list21 = list6;
								text3 = text2;
								object obj148 = 0;
								Enumerator<, > val19 = val9;
								Comparison<Row> comparison19 = comparison2;
								IntPtr intPtr2 = num2;
								int num25 = num;
								while (true)
								{
									bool flag92 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj148) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj141);
									object obj149 = !flag92;
									obj145 = obj144;
									list2 = list19;
									comparison = comparison15;
									state2 = state;
									list13 = (List<Row>)(object)comparison16;
									comparison8 = comparison17;
									list10 = list20;
									comparison3 = comparison18;
									text9 = text19;
									val13 = val18;
									text = text20;
									text11 = text21;
									obj42 = obj146;
									obj41 = obj147;
									text8 = text22;
									list6 = list21;
									object obj22 = obj148;
									val8 = val19;
									list3 = list8;
									comparison2 = comparison19;
									num2 = intPtr2;
									num = num25;
									if (obj149 != null)
									{
										break;
									}
									object obj150 = (object)list8 + obj148;
									List<Entry> list22 = entries;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v64+20]");
									news = (GillaFriends.News)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v64+20]");
									bool flag93 = (nint)0 == 0;
									obj145 = obj144;
									list2 = null;
									comparison = null;
									val5 = (Enumerator<, >)0;
									state2 = state;
									list13 = (List<Row>)(object)comparison16;
									comparison8 = comparison17;
									list10 = list20;
									comparison3 = comparison18;
									text9 = text19;
									val13 = val18;
									text = null;
									text11 = text21;
									obj42 = obj146;
									obj41 = obj147;
									text8 = text22;
									list6 = list21;
									obj22 = obj148;
									val8 = (Enumerator<, >)0;
									list3 = list8;
									comparison2 = comparison19;
									num2 = intPtr2;
									num = num25;
									if (!flag93)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
										object obj151 = 0;
										object obj152 = obj151;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4597 @ X0_v100+E4]");
										bool flag94 = (nint)0 == 0;
										object obj153 = !flag94;
										if (obj153 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										string text23 = NameOf((string)news.t, news.k);
										object obj154 = (nint)(&val5) | (nint)8;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj155 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val5, 16));
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj156 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val5, 24));
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj157 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val5, 32));
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										bool flag95 = entries == null;
										obj145 = obj143;
										list2 = null;
										comparison = (Comparison<Row>)obj17;
										val5 = (Enumerator<, >)news.t;
										state2 = state;
										list13 = (List<Row>)(object)comparison16;
										comparison8 = comparison17;
										list10 = list20;
										comparison3 = comparison18;
										text9 = text19;
										val13 = val18;
										text = (string)obj142;
										text11 = text23;
										obj42 = obj146;
										obj41 = obj147;
										text8 = text22;
										list6 = (List<Entry>)news.t;
										obj22 = obj148;
										news = (GillaFriends.News)(object)news.k;
										val8 = (Enumerator<, >)0;
										list3 = list8;
										comparison2 = (Comparison<Row>)obj17;
										num2 = intPtr2;
										num = num25;
										if (!flag95)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X22_v36 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
											object obj158 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X22_v36 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+1C]");
											obj41 = (nint)0 + (nint)1;
											num2 = (nint)obj23;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X22_v36 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
											bool flag96 = (nint)0 == 0;
											obj145 = obj143;
											list2 = null;
											comparison = (Comparison<Row>)obj17;
											val5 = (Enumerator<, >)news.t;
											state2 = state;
											list13 = (List<Row>)(object)comparison16;
											comparison8 = comparison17;
											list10 = null;
											comparison3 = (Comparison<Row>)obj17;
											list11 = null;
											text9 = (string)obj142;
											val13 = (Enumerator<, >)news.t;
											text = (string)obj142;
											text11 = text23;
											obj42 = obj146;
											text8 = (string)obj142;
											list6 = (List<Entry>)news.t;
											obj22 = obj148;
											news = (GillaFriends.News)(object)news.k;
											val8 = (Enumerator<, >)obj17;
											list3 = list8;
											comparison2 = (Comparison<Row>)obj17;
											num = num25;
											if (!flag96)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X22_v36 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
												obj41 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v68+18]");
												obj42 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X22_v36 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
												nint num26 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v68+18]");
												bool flag97 = num26 < 0;
												object obj159 = !flag97;
												if (obj159 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X22_v36 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
													nint num27 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X22_v36 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
													object obj160 = num27 + 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X22_v36 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
													num2 = (nint)0 + (nint)1;
													object obj161 = obj160 + 32;
													_ = news.t;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													comparison4 = (Comparison<Row>)obj17;
													text8 = (string)obj142;
													val9 = (Enumerator<, >)0;
													comparison2 = null;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3789 @ X9_v77 (Il2CppClass<System.Collections.Generic.List`1<GillaLeaderboard+Row>>)+20]");
													object obj162 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5025 @ X8_v71+A8]");
													object obj163 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5030 @ X8_v72+70]");
													num25 = 0;
													entries.AddWithResize((Entry)(&val11));
													comparison16 = null;
													comparison17 = (Comparison<Row>)obj17;
													comparison4 = null;
													text8 = (string)obj142;
													text3 = (string)obj142;
													val9 = (Enumerator<, >)obj17;
													val11 = (Enumerator<, >)news.t;
													comparison2 = (Comparison<Row>)(&val11);
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
												obj141 = 0;
												obj22 = obj148 + 1;
												object obj164 = obj22;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X21_v40 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
												bool flag98 = (nint)obj164 < 0;
												obj145 = obj143;
												list2 = null;
												comparison = (Comparison<Row>)obj17;
												val5 = (Enumerator<, >)news.t;
												list13 = (List<Row>)(object)comparison16;
												comparison8 = comparison17;
												list10 = null;
												comparison3 = (Comparison<Row>)obj17;
												text9 = (string)obj142;
												val13 = (Enumerator<, >)news.t;
												text = (string)obj142;
												text11 = text23;
												list6 = (List<Entry>)news.t;
												text2 = text3;
												num = num25;
												obj144 = obj143;
												list19 = null;
												comparison15 = (Comparison<Row>)obj17;
												val5 = (Enumerator<, >)news.t;
												list20 = null;
												comparison18 = (Comparison<Row>)obj17;
												list11 = (List<Row>)(object)comparison4;
												text19 = (string)obj142;
												val18 = (Enumerator<, >)news.t;
												text20 = (string)obj142;
												text21 = text23;
												obj146 = obj42;
												obj147 = obj41;
												text22 = text8;
												list21 = (List<Entry>)news.t;
												obj148 = obj22;
												news = (GillaFriends.News)(object)news.k;
												val19 = val9;
												comparison19 = comparison2;
												intPtr2 = num2;
												if (flag98)
												{
													continue;
												}
												goto IL_47f8;
											}
										}
									}
									goto IL_5302;
								}
								goto IL_5310;
							}
						}
					}
				}
				else
				{
					if (page != 0)
					{
						bool flag99 = page == (Page)1;
						val = (Enumerator<, >)0;
						val2 = (Enumerator<, >)0;
						val3 = (Enumerator<, >)0;
						val4 = (Enumerator<, >)0;
						list2 = null;
						comparison = null;
						val5 = (Enumerator<, >)0;
						state2 = now;
						text = null;
						dateTimeOffset = (DateTimeOffset)0;
						state3 = now;
						if (flag99)
						{
							goto IL_3393;
						}
						val = (Enumerator<, >)0;
						val2 = (Enumerator<, >)0;
						val3 = (Enumerator<, >)0;
						val4 = (Enumerator<, >)0;
						list2 = null;
						comparison = null;
						val5 = (Enumerator<, >)0;
						state2 = now;
						comparison4 = (Comparison<Row>)(object)list11;
						text = null;
						dateTimeOffset = (DateTimeOffset)0;
						text3 = text2;
						goto IL_5054;
					}
					bool flag100 = rows == null;
					val = (Enumerator<, >)0;
					val2 = (Enumerator<, >)0;
					val3 = (Enumerator<, >)0;
					val4 = (Enumerator<, >)0;
					list2 = null;
					comparison = null;
					val5 = (Enumerator<, >)0;
					state2 = now;
					text = null;
					dateTimeOffset = (DateTimeOffset)0;
					text3 = text2;
					val8 = val9;
					list3 = list8;
					if (!flag100)
					{
						Enumerator<, > enumerator2 = rows.GetEnumerator();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1980]");
						object obj165 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
						obj17 = 0;
						val2 = (Enumerator<, >)0;
						val3 = (Enumerator<, >)0;
						list2 = null;
						comparison = null;
						val5 = (Enumerator<, >)0;
						text = null;
						text8 = text2;
						val9 = (Enumerator<, >)comparison8;
						string text24 = default;
						Enumerator<, > val20 = default;
						Enumerator<, > val21 = default;
						List<Row> list5;
						while (val4.MoveNext())
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj166 = (nint)(&val5) | (nint)8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
							list8 = (List<Row>)(list13 & 1);
							object obj167 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val5, 16));
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag101 = list8 == null;
							object obj168 = !flag101;
							Comparison<Row> comparison20;
							object obj172;
							object obj179;
							string text25;
							object obj184;
							if (obj168 == null)
							{
								bool flag102 = string.IsNullOrEmpty(text24);
								bool flag103 = !flag102;
								object obj169 = !flag103;
								val2 = (Enumerator<, >)0;
								comparison20 = (Comparison<Row>)obj22;
								news = (GillaFriends.News)(object)text2;
								comparison2 = null;
								if (obj169 == null)
								{
									bool flag104 = text24 == null;
									val = (Enumerator<, >)0;
									val2 = (Enumerator<, >)0;
									val3 = val5;
									val4 = val20;
									list2 = list8;
									comparison = null;
									state2 = now;
									list11 = list8;
									text = (string)obj22;
									text11 = text2;
									dateTimeOffset = (DateTimeOffset)0;
									text8 = (string)obj22;
									list6 = (List<Entry>)(object)comparison8;
									text4 = null;
									list5 = null;
									obj23 = (object)(&val3);
									news = (GillaFriends.News)(object)text2;
									val8 = (Enumerator<, >)0;
									val11 = (Enumerator<, >)(ref val4);
									obj32 = (UnityEngine.Object)(object)list8;
									comparison2 = null;
									if (flag104)
									{
										goto IL_53c8;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA828]");
									object value = 0;
									if (text24.StartsWith((string)value))
									{
										object obj170 = obj17;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4929 @ X0_v276+E4]");
										bool flag105 = (nint)0 == 0;
										object obj171 = !flag105;
										if (obj171 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag106 = MutedRow(text24, (string)(object)comparison8);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF698]");
										obj172 = 0;
										bool flag107 = !flag106;
										object obj173 = !flag107;
										num = 0;
										if (obj173 == null)
										{
											object obj174 = obj17;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5123 @ X0_v280+E4]");
											bool flag108 = (nint)0 == 0;
											object obj175 = !flag108;
											if (obj175 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag109 = Reported(text24);
											bool flag110 = !flag109;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A08]");
											obj172 = 0;
											bool flag111 = !flag110;
											object obj36 = !flag111;
											if (obj36 != null)
											{
												obj172 = obj22;
											}
											num = 0;
										}
										goto IL_5a3c;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
									object obj176 = 0;
									object obj177 = obj176;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4935 @ X0_v229+E4]");
									bool flag112 = (nint)0 == 0;
									object obj178 = !flag112;
									if (obj178 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									if (!GillaFriends.IsBlocked(text24))
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1908]");
										obj179 = 0;
										object obj180 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val3, 32));
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
										object obj181 = 0;
										text25 = (string)obj22;
										object obj182 = obj181;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5165 @ X0_v235+E4]");
										bool flag113 = (nint)0 == 0;
										object obj183 = !flag113;
										if (obj183 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										if (GillaFriends.IsFriend(text24))
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D19E8]");
											obj184 = 0;
											object obj185 = 0;
											goto IL_5a92;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
										object obj186 = 0;
										object obj187 = obj186;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5245 @ X0_v256+E4]");
										bool flag114 = (nint)0 == 0;
										object obj188 = !flag114;
										if (obj188 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										if (GillaFriends.AsksYou(text24))
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1928]");
											object obj189 = 0;
											object obj185 = obj189;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D19F8]");
											object obj190 = 0;
											text25 = (string)obj190;
											object obj191 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val3, 24));
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
											object obj192 = 0;
											object obj193 = obj192;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5349 @ X0_v260+E4]");
											bool flag115 = (nint)0 == 0;
											object obj194 = !flag115;
											if (obj194 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											object obj185;
											if (GillaFriends.YouAsked(text24))
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A00]");
												obj184 = 0;
												obj185 = 0;
												goto IL_5a92;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1900]");
											object obj195 = 0;
											obj185 = obj195;
											object obj196 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val3, 24));
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										}
										goto IL_2fbe;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D19F0]");
									object obj197 = 0;
									object obj198 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val3, 16));
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1910]");
									object obj199 = 0;
									comparison2 = (Comparison<Row>)obj199;
									object obj200 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val3, 32));
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									val2 = (Enumerator<, >)obj199;
									comparison20 = (Comparison<Row>)obj197;
									news = (GillaFriends.News)(object)text2;
									num = 0;
								}
								goto IL_291e;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C83E8]");
							obj172 = 0;
							goto IL_5a3c;
							IL_291e:
							List<Entry> list23 = entries;
							bool flag116 = entries == null;
							val = (Enumerator<, >)0;
							val3 = val5;
							val4 = val20;
							list2 = list8;
							comparison = null;
							state2 = now;
							list11 = list8;
							text = (string)obj22;
							text11 = text2;
							dateTimeOffset = (DateTimeOffset)0;
							text8 = (string)obj22;
							list6 = (List<Entry>)(object)comparison8;
							text3 = null;
							list5 = null;
							obj23 = (object)(&val3);
							val8 = (Enumerator<, >)0;
							val11 = (Enumerator<, >)(ref val4);
							list3 = list8;
							if (!flag116)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X0_v222 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
								object obj201 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X0_v222 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+1C]");
								obj41 = (nint)0 + (nint)1;
								num2 = (nint)obj165;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X0_v222 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
								bool flag117 = (nint)0 == 0;
								val = (Enumerator<, >)0;
								val3 = val5;
								val4 = val20;
								list2 = list8;
								comparison = null;
								state2 = now;
								list11 = list8;
								text = (string)obj22;
								text11 = text2;
								dateTimeOffset = (DateTimeOffset)0;
								text8 = (string)(object)comparison20;
								list6 = (List<Entry>)(object)comparison8;
								text3 = null;
								list5 = null;
								obj23 = (object)(&val3);
								val8 = val2;
								val11 = (Enumerator<, >)(ref val4);
								list3 = list8;
								if (!flag117)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X0_v222 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
									obj41 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1502 @ X8_v151+18]");
									obj42 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X0_v222 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
									nint num28 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1502 @ X8_v151+18]");
									bool flag118 = num28 < 0;
									object obj202 = !flag118;
									if (obj202 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X0_v222 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+10]");
										nint num29 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X0_v222 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
										object obj203 = num29 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X0_v222 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
										num2 = (nint)0 + (nint)1;
										object obj204 = obj203 + 32;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										val3 = val5;
										list2 = list8;
										comparison = null;
										list11 = (List<Row>)val2;
										text = (string)obj22;
										text11 = text2;
										text8 = (string)(object)comparison20;
										list6 = (List<Entry>)(object)comparison8;
										val9 = (Enumerator<, >)list8;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3789 @ X9_v77 (Il2CppClass<System.Collections.Generic.List`1<GillaLeaderboard+Row>>)+20]");
										object obj205 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4941 @ X8_v152+A8]");
										object obj206 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4171 @ X8_v153+70]");
										num = 0;
										entries.AddWithResize((Entry)(&val21));
										val3 = val5;
										list2 = list8;
										comparison = null;
										list11 = list8;
										text = (string)obj22;
										text11 = text2;
										text8 = (string)(object)comparison20;
										list6 = (List<Entry>)(object)comparison8;
										val9 = val2;
									}
									continue;
								}
							}
							goto IL_532c;
							IL_2fbe:
							object obj207 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5314 @ X0_v241+E4]");
							bool flag119 = (nint)0 == 0;
							object obj208 = !flag119;
							if (obj208 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag120 = MutedRow(text24, (string)(object)comparison8);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF698]");
							object obj209 = 0;
							bool flag121 = !flag120;
							object obj210 = !flag121;
							if (obj210 == null)
							{
								object obj211 = obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5380 @ X0_v250+E4]");
								bool flag122 = (nint)0 == 0;
								object obj212 = !flag122;
								if (obj212 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag123 = Reported(text24);
								bool flag124 = !flag123;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A08]");
								obj209 = 0;
								object obj213 = !flag124;
								object obj36 = ~obj213;
								if (obj36 != null)
								{
									obj209 = obj22;
								}
							}
							bool flag125 = text25 == null;
							val = (Enumerator<, >)0;
							val2 = (Enumerator<, >)obj179;
							val3 = val5;
							val4 = val20;
							list2 = list8;
							comparison = null;
							state2 = now;
							list11 = list8;
							text = (string)obj22;
							text11 = text2;
							dateTimeOffset = (DateTimeOffset)0;
							text8 = (string)obj22;
							list6 = (List<Entry>)(object)comparison8;
							text4 = null;
							list5 = null;
							obj23 = (object)(&val3);
							news = (GillaFriends.News)(object)text25;
							val9 = (Enumerator<, >)0;
							val11 = (Enumerator<, >)(ref val4);
							enumerable = (IEnumerable<Row>)(object)comparison8;
							num = 0;
							if (flag125)
							{
								goto IL_5435;
							}
							num2 = text25._stringLength;
							string text26 = (string)obj209;
							if (text25._stringLength >= 1)
							{
								bool flag126 = obj209 == null;
								val = (Enumerator<, >)0;
								val2 = (Enumerator<, >)obj179;
								val3 = val5;
								val4 = val20;
								list2 = list8;
								comparison = null;
								state2 = now;
								list11 = list8;
								text = (string)obj22;
								text11 = text2;
								dateTimeOffset = (DateTimeOffset)0;
								text8 = (string)obj22;
								list6 = (List<Entry>)(object)comparison8;
								text4 = null;
								list5 = null;
								obj23 = (object)(&val3);
								news = (GillaFriends.News)(object)text25;
								val9 = (Enumerator<, >)0;
								val11 = (Enumerator<, >)(ref val4);
								enumerable = (IEnumerable<Row>)(object)comparison8;
								num = (int)obj209;
								if (flag126)
								{
									goto IL_5443;
								}
								if (text26._stringLength > 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
									object obj214 = 0;
									string text27 = text25 + (string)obj214 + (string)obj209;
									val2 = (Enumerator<, >)obj179;
									news = (GillaFriends.News)(object)text25;
									object obj2 = 0;
									comparison2 = (Comparison<Row>)(object)text27;
									num = (int)obj209;
									goto IL_5b62;
								}
							}
							string text28 = text25 + (string)obj209;
							val2 = (Enumerator<, >)obj179;
							news = (GillaFriends.News)(object)text25;
							comparison2 = (Comparison<Row>)(object)text28;
							num = 0;
							goto IL_5b62;
							IL_5a3c:
							comparison2 = (Comparison<Row>)obj172;
							val2 = (Enumerator<, >)0;
							news = (GillaFriends.News)(object)text2;
							goto IL_5b62;
							IL_5a92:
							text25 = (string)obj184;
							goto IL_2fbe;
							IL_5b62:
							object obj215 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val3, 16));
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							comparison20 = comparison2;
							goto IL_291e;
						}
						val = (Enumerator<, >)0;
						val4 = val20;
						state2 = now;
						dateTimeOffset = (DateTimeOffset)0;
						list9 = null;
						text4 = null;
						list5 = null;
						obj23 = (object)(&val3);
						val11 = (Enumerator<, >)(ref val4);
						obj52 = 19;
						goto IL_602e;
					}
				}
			}
		}
		goto IL_5302;
		IL_602e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1948]");
		object obj216 = 0;
		enumerable = (IEnumerable<Row>)obj216;
		((Enumerator<, >*)val11)->Dispose();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D19E0]");
		obj90 = 0;
		bool flag127 = list9 == null;
		object obj217 = !flag127;
		NullReferenceException ex12;
		if (obj217 == null)
		{
			bool flag128 = text4 == null;
			object obj218 = !flag128;
			ex12 = (NullReferenceException)val11;
			if (obj218 == null)
			{
				bool flag129 = (nint)obj52 == 19;
				comparison4 = (Comparison<Row>)(object)list11;
				text3 = text4;
				comparison2 = (Comparison<Row>)obj216;
				if (!flag129)
				{
					bool flag130 = obj52 == null;
					object obj219 = !flag130;
					text2 = text4;
					state3 = state2;
					comparison2 = (Comparison<Row>)obj216;
					if (obj219 == null)
					{
						goto IL_3393;
					}
					return;
				}
				goto IL_5054;
			}
			goto IL_540a;
		}
		goto IL_5419;
		IL_537a:
		IndexOutOfRangeException ex13 = new IndexOutOfRangeException();
		goto IL_5388;
		IL_536c:
		NullReferenceException ex14 = new NullReferenceException();
		goto IL_537a;
		IL_3393:
		bool flag131 = state3 == null;
		text3 = text2;
		val8 = val9;
		list3 = list8;
		if (!flag131)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D19C8]");
			object obj220 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D19C0]");
			object obj221 = 0;
			num = (int)obj221;
			List<System.__Canon> list24 = default;
			list24._002Ector((IEnumerable<System.__Canon>)(object)state3.friends);
			object obj222 = obj90;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4491 @ X0_v121+E4]");
			bool flag132 = (nint)0 == 0;
			object obj223 = !flag132;
			if (obj223 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj222 = obj90;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4491 @ X0_v121+A0]");
			object obj224 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4602 @ X8_v122+10]");
			Comparison<System.__Canon> comparison21 = (Comparison<System.__Canon>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4602 @ X8_v122+10]");
			bool flag133 = (nint)0 == 0;
			object obj225 = !flag133;
			comparison2 = (Comparison<Row>)(object)state3.friends;
			if (obj225 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4491 @ X0_v121+E4]");
				bool flag134 = (nint)0 == 0;
				object obj226 = !flag134;
				if (obj226 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj227 = obj90;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4636 @ X8_v126+A0]");
					obj224 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1938]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D19D8]");
				object obj228 = 0;
				Comparison<System.__Canon> comparison22 = default;
				comparison22._002Ector(obj224, (IntPtr)obj228);
				object obj229 = obj90;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4565 @ X8_v125+A0]");
				object obj230 = (nint)0 + (nint)16;
				obj230 = comparison22;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				comparison21 = comparison22;
				news = (GillaFriends.News)obj224;
				object obj2 = 0;
				comparison2 = (Comparison<Row>)(object)comparison22;
				num = (int)obj228;
			}
			bool flag135 = list24 == null;
			list6 = (List<Entry>)(object)comparison21;
			text3 = text2;
			val8 = val9;
			list3 = list8;
			if (!flag135)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D19B8]");
				object obj231 = 0;
				num = (int)obj231;
				list24.Sort(comparison21);
				Enumerator<, > enumerator3 = list24.GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1960]");
				object obj232 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1920]");
				obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1980]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D18F0]");
				obj17 = 0;
				Enumerator<, > val22 = default;
				val9 = val22;
				string[] array = default;
				Enumerator<, > val23 = default;
				List<Row> list5;
				while (val.MoveNext())
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
					object obj233 = 0;
					object obj234 = obj233;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4888 @ X0_v130+E4]");
					bool flag136 = (nint)0 == 0;
					object obj235 = !flag136;
					if (obj235 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text29 = GillaFriends.Where((GillaFriends.Friend)(object)text2);
					bool flag137 = text2 == null;
					val = val22;
					list6 = (List<Entry>)(object)comparison21;
					text3 = null;
					list5 = null;
					val8 = val9;
					val11 = (Enumerator<, >)(ref val);
					list3 = (List<Row>)(&val5);
					comparison2 = null;
					if (!flag137)
					{
						bool flag138 = (byte)(~(((GillaFriends.Friend)(object)text2).on ? 1u : 0u)) != 0;
						string text30 = text29;
						if (!flag138)
						{
							int num30 = (int)(text2 + 52);
							bool flag111 = ((int*)num30)->m_value < 1;
							text30 = text29;
							if (!flag111)
							{
								bool flag139 = string.IsNullOrEmpty(((GillaFriends.Friend)(object)text2).code);
								bool flag140 = !flag139;
								object obj236 = !flag140;
								text30 = text29;
								if (obj236 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
									object obj237 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									bool flag141 = array == null;
									val = val22;
									list6 = (List<Entry>)(object)array;
									text4 = null;
									list5 = null;
									news = (GillaFriends.News)(object)text29;
									val8 = val9;
									val11 = (Enumerator<, >)(ref val);
									list3 = (List<Row>)(&val5);
									comparison2 = (Comparison<Row>)5;
									if (flag141)
									{
										goto IL_536c;
									}
									bool flag142 = array.Length == 0;
									val = val22;
									list6 = (List<Entry>)(object)array;
									text4 = null;
									list5 = null;
									news = (GillaFriends.News)(object)text29;
									val8 = val9;
									val11 = (Enumerator<, >)(ref val);
									list3 = (List<Row>)(&val5);
									comparison2 = (Comparison<Row>)5;
									if (flag142)
									{
										goto IL_53b2;
									}
									object obj238 = array + 32;
									obj238 = text29;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj239 = array.Length & 0xFFFFFFFEL;
									bool flag143 = obj239 == null;
									val = val22;
									list6 = (List<Entry>)(object)array;
									text4 = null;
									list5 = null;
									news = (GillaFriends.News)(object)text29;
									val8 = val9;
									val11 = (Enumerator<, >)(ref val);
									list3 = (List<Row>)(&val5);
									comparison2 = (Comparison<Row>)(object)text29;
									if (flag143)
									{
										goto IL_5396;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
									object obj240 = 0;
									object obj241 = array + 40;
									obj241 = obj240;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									int num31 = (int)(text2 + 48);
									string text31 = ((int*)num31)->ToString();
									bool flag144 = array.Length < 2;
									object obj242 = !flag144;
									object obj243 = array.Length - 2;
									bool flag145 = obj243 == null;
									object obj244 = ~obj242;
									object obj245 = obj244 | flag145;
									val = val22;
									list6 = (List<Entry>)(object)array;
									text4 = null;
									list5 = null;
									news = (GillaFriends.News)(object)text29;
									val8 = val9;
									val11 = (Enumerator<, >)(ref val);
									list3 = (List<Row>)(&val5);
									comparison2 = (Comparison<Row>)(object)text31;
									if (obj245 != null)
									{
										goto IL_5388;
									}
									object obj246 = array + 48;
									obj246 = text31;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj247 = array.Length & 0xFFFFFFFCL;
									bool flag146 = obj247 == null;
									val = val22;
									list6 = (List<Entry>)(object)array;
									text4 = null;
									list5 = null;
									news = (GillaFriends.News)(object)text29;
									val8 = val9;
									val11 = (Enumerator<, >)(ref val);
									list3 = (List<Row>)(&val5);
									comparison2 = (Comparison<Row>)(object)text31;
									if (flag146)
									{
										goto IL_537a;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B18]");
									object obj248 = 0;
									object obj249 = array + 56;
									obj249 = obj248;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									string text32 = ((int*)num30)->ToString();
									bool flag147 = array.Length < 4;
									object obj250 = !flag147;
									object obj251 = array.Length - 4;
									bool flag148 = obj251 == null;
									object obj252 = ~obj250;
									flag111 = (byte)((obj252 | flag148) ? 1 : 0) != 0;
									val = val22;
									list6 = (List<Entry>)(object)array;
									text4 = null;
									list5 = null;
									news = (GillaFriends.News)(object)text29;
									val8 = val9;
									val11 = (Enumerator<, >)(ref val);
									list3 = (List<Row>)(&val5);
									comparison2 = (Comparison<Row>)(object)text32;
									if (flag111)
									{
										goto IL_53a4;
									}
									object obj253 = array + 64;
									obj253 = text32;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									string text33 = string.Concat(array);
									text30 = text33;
								}
							}
						}
						comparison21 = (Comparison<System.__Canon>)(object)entries;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
						object obj254 = 0;
						object obj255 = obj254;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5118 @ X0_v137+E4]");
						bool flag149 = (nint)0 == 0;
						object obj256 = !flag149;
						if (obj256 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						string text34 = NameOf(((GillaFriends.Friend)(object)text2).id, ((GillaFriends.Friend)(object)text2).name);
						object obj257 = (nint)(&val5) | (nint)8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj258 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val5, 16));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj259;
						if (~(((GillaFriends.Friend)(object)text2).on ? 1u : 0u) == 0)
						{
							bool flag150 = string.IsNullOrEmpty(((GillaFriends.Friend)(object)text2).code);
							bool flag151 = !flag150;
							bool flag111 = !flag151;
							object obj36 = !flag111;
							obj259 = ((obj36 != null) ? obj17 : ((object)0));
						}
						else
						{
							obj259 = 0;
						}
						object obj260 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val5, 24));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj261 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val5, 32));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj262 = (((GillaFriends.Friend)(object)text2).on ? 1 : 0) ^ 1;
						object obj263 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val5, 56));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag152 = comparison21 == null;
						object obj145 = obj259;
						obj55 = obj262;
						val = val22;
						list2 = null;
						comparison = (Comparison<Row>)obj23;
						text = text30;
						text11 = text34;
						list6 = (List<Entry>)(object)comparison21;
						text3 = null;
						list5 = null;
						news = (GillaFriends.News)(object)text30;
						val8 = (Enumerator<, >)0;
						val11 = (Enumerator<, >)(ref val);
						list3 = (List<Row>)(&val5);
						comparison2 = (Comparison<Row>)(object)text2;
						if (!flag152)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1590 @ X23_v38 (System.Comparison`1<System.__Canon>)+10]");
							object obj264 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1590 @ X23_v38 (System.Comparison`1<System.__Canon>)+1C]");
							obj41 = (nint)0 + (nint)1;
							num2 = (nint)obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1590 @ X23_v38 (System.Comparison`1<System.__Canon>)+10]");
							bool flag153 = (nint)0 == 0;
							obj145 = obj259;
							obj55 = obj262;
							val = val22;
							list2 = null;
							comparison = (Comparison<Row>)obj23;
							list11 = null;
							text = text30;
							text11 = text34;
							text8 = text30;
							list6 = (List<Entry>)(object)comparison21;
							text3 = null;
							list5 = null;
							news = (GillaFriends.News)(object)text30;
							val8 = (Enumerator<, >)obj23;
							val11 = (Enumerator<, >)(ref val);
							list3 = (List<Row>)(&val5);
							comparison2 = (Comparison<Row>)(object)text2;
							if (!flag153)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1590 @ X23_v38 (System.Comparison`1<System.__Canon>)+18]");
								obj41 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X8_v105+18]");
								obj42 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1590 @ X23_v38 (System.Comparison`1<System.__Canon>)+18]");
								nint num32 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X8_v105+18]");
								bool flag154 = num32 < 0;
								object obj265 = !flag154;
								if (obj265 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1590 @ X23_v38 (System.Comparison`1<System.__Canon>)+10]");
									nint num33 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1590 @ X23_v38 (System.Comparison`1<System.__Canon>)+18]");
									object obj266 = num33 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1590 @ X23_v38 (System.Comparison`1<System.__Canon>)+18]");
									num2 = (nint)0 + (nint)1;
									_ = 0;
									object obj267 = obj266 + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									obj145 = obj259;
									obj55 = obj262;
									list2 = null;
									comparison = (Comparison<Row>)obj23;
									list11 = (List<Row>)obj23;
									text = text30;
									text11 = text34;
									text8 = text30;
									news = (GillaFriends.News)(object)text30;
									val9 = (Enumerator<, >)0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3789 @ X9_v77 (Il2CppClass<System.Collections.Generic.List`1<GillaLeaderboard+Row>>)+20]");
									object obj268 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5434 @ X8_v106+A8]");
									object obj269 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4752 @ X8_v107+70]");
									num = 0;
									((List<Entry>)(object)comparison21).AddWithResize((Entry)(&val23));
									obj145 = obj259;
									obj55 = obj262;
									list2 = null;
									comparison = (Comparison<Row>)obj23;
									list11 = null;
									text = text30;
									text11 = text34;
									text8 = text30;
									news = (GillaFriends.News)(object)text30;
									val9 = (Enumerator<, >)obj23;
								}
								continue;
							}
						}
						goto IL_531e;
					}
					goto IL_533a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1950]");
				object obj270 = 0;
				enumerable = (IEnumerable<Row>)obj270;
				val.Dispose();
				val = val22;
				list6 = (List<Entry>)(object)comparison21;
				text4 = null;
				list5 = null;
				val11 = (Enumerator<, >)(ref val);
				list8 = (List<Row>)(&val5);
				goto IL_5419;
			}
		}
		goto IL_5302;
		IL_53a4:
		IndexOutOfRangeException ex15 = new IndexOutOfRangeException();
		goto IL_53b2;
		IL_53b2:
		IndexOutOfRangeException ex16 = new IndexOutOfRangeException();
		obj32 = (UnityEngine.Object)(object)list3;
		goto IL_53c8;
		IL_53c8:
		NullReferenceException ex17 = new NullReferenceException();
		val9 = val8;
		goto IL_53de;
		IL_53de:
		NullReferenceException ex18 = new NullReferenceException();
		enumerable = (IEnumerable<Row>)(object)comparison2;
		goto IL_53f4;
		IL_53f4:
		ex12 = new NullReferenceException();
		list8 = (List<Row>)(object)obj32;
		goto IL_540a;
		IL_540a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_5419;
		IL_5419:
		OutOfMemoryException ex19 = new OutOfMemoryException();
		goto IL_5427;
		IL_5427:
		NullReferenceException ex20 = new NullReferenceException();
		goto IL_5435;
		IL_5435:
		NullReferenceException ex21 = new NullReferenceException();
		goto IL_5443;
	}

	private unsafe static string NameOf(string id, string kept)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_054b: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I4
		//IL_06e2: Expected Obj, but got I
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got I
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I
		//IL_048f: Expected Obj, but got I4
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got I4
		//IL_04c1: Expected Obj, but got I4
		//IL_0790: Expected Obj, but got I
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Expected Ref, but got Unknown
		//IL_07bb: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I4
		//IL_01ba: Expected I, but got Obj
		//IL_04e0: Expected Obj, but got I4
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected Obj, but got Unknown
		//IL_0566: Expected I, but got Obj
		//IL_01fd: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I4
		//IL_052d: Expected Obj, but got I4
		//IL_0595: Expected Obj, but got I4
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected I, but got Obj
		//IL_062d: Expected Obj, but got I4
		//IL_0691: Expected Obj, but got I4
		//IL_027c: Expected Obj, but got I
		//IL_0298: Expected I, but got Obj
		//IL_0772: Expected Obj, but got I4
		//IL_02d0: Expected Obj, but got I
		//IL_02e8: Expected I, but got Obj
		//IL_0312: Expected I, but got Obj
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_0350: Expected I, but got Obj
		//IL_0395: Expected I, but got Obj
		//IL_03c4: Expected I, but got Obj
		//IL_03d2: Expected Obj, but got I4
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected I, but got Obj
		//IL_0439: Expected I, but got Obj
		//IL_0447: Expected Obj, but got I4
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected Obj, but got I4
		//IL_047c: Expected Obj, but got I4
		bool flag = string.IsNullOrEmpty(kept);
		bool flag2 = !flag;
		string result = kept;
		object obj24;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj3 = !flag3;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Application.isPlaying)
			{
				bool flag4 = string.IsNullOrEmpty(id);
				bool flag5 = !flag4;
				object obj4 = !flag5;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
					object obj5 = 0;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v14+E4]");
					bool flag6 = (nint)0 == 0;
					object obj7 = !flag6;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj6 = obj5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v14+A0]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v11+8]");
					bool flag7 = (nint)0 == 0;
					UnityEngine.Object obj10 = default;
					UnityEngine.Object obj9 = obj10;
					Enumerator<, > val = (Enumerator<, >)0;
					UnityEngine.Object obj11 = null;
					if (!flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v11+8]");
						Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj13 = 0;
						Enumerator<, > val2 = default;
						string result2 = default;
						object obj28 = default;
						while (true)
						{
							object obj23;
							object obj22;
							Enumerator<, > val3;
							Enumerator<, > val4;
							if (val.MoveNext())
							{
								object obj14 = obj13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v43+E4]");
								bool flag8 = (nint)0 == 0;
								object obj15 = !flag8;
								if (obj15 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag9 = obj10 != null;
								bool flag10 = !flag9;
								nint num = unchecked((nint)null);
								if (flag10)
								{
									continue;
								}
								if ((object)obj10 != null)
								{
									object obj16 = obj13;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ stack_-78 (UnityEngine.Object)+40]");
									UnityEngine.Object obj17 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v52+E4]");
									bool flag11 = (nint)0 == 0;
									object obj18 = !flag11;
									if (obj18 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag12 = obj17 != null;
									bool flag13 = !flag12;
									num = unchecked((nint)null);
									if (flag13)
									{
										continue;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ stack_-78 (UnityEngine.Object)+40]");
									obj17 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ stack_-78 (UnityEngine.Object)+40]");
									bool flag14 = (nint)0 == 0;
									num = unchecked((nint)null);
									obj11 = null;
									if (!flag14)
									{
										object obj19 = obj13;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v57+E4]");
										bool flag15 = (nint)0 == 0;
										object obj20 = !flag15;
										if (obj20 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X22_v10 (UnityEngine.Object)+30]");
										bool flag16 = (UnityEngine.Object)0;
										bool flag17 = !flag16;
										num = unchecked((nint)null);
										if (flag17)
										{
											continue;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X22_v10 (UnityEngine.Object)+30]");
										bool flag18 = (nint)0 == 0;
										num = unchecked((nint)null);
										obj11 = null;
										if (flag18)
										{
											goto IL_057e;
										}
										ArgumentNullException ex = new ArgumentNullException();
										object obj21 = ex & 1;
										bool flag19 = obj21 == null;
										num = unchecked((nint)null);
										if (flag19)
										{
											continue;
										}
										string accountId = ((NetworkApe)obj10).AccountId;
										bool flag20 = accountId == id;
										bool flag21 = !flag20;
										num = unchecked((nint)null);
										if (flag21)
										{
											continue;
										}
										string playerName = ((NetworkApe)obj10).PlayerName;
										bool flag22 = playerName == null;
										num = unchecked((nint)null);
										obj9 = null;
										obj22 = 0;
										val = val2;
										val3 = val2;
										val4 = (Enumerator<, >)(ref val);
										obj11 = null;
										if (flag22)
										{
											goto IL_05dd;
										}
										bool flag23 = playerName._stringLength < 1;
										num = unchecked((nint)null);
										if (flag23)
										{
											continue;
										}
										string playerName2 = ((NetworkApe)obj10).PlayerName;
										num = unchecked((nint)null);
										obj9 = null;
										obj22 = 0;
										val = val2;
										val3 = val2;
										val4 = (Enumerator<, >)(ref val);
										obj23 = 0;
										result = playerName2;
										obj24 = 6;
										goto IL_0780;
									}
								}
								else
								{
									NullReferenceException ex2 = new NullReferenceException();
									num = unchecked((nint)null);
									obj11 = null;
								}
								NullReferenceException ex3 = new NullReferenceException();
								goto IL_057e;
							}
							obj9 = null;
							obj22 = 0;
							val = val2;
							val3 = val2;
							val4 = (Enumerator<, >)(ref val);
							obj23 = 0;
							result = null;
							obj24 = 3;
							goto IL_0780;
							IL_057e:
							NullReferenceException ex4 = new NullReferenceException();
							obj9 = null;
							obj22 = 0;
							val = val2;
							val3 = val2;
							val4 = (Enumerator<, >)(ref val);
							break;
							IL_0780:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
							object obj25 = 0;
							obj11 = (UnityEngine.Object)obj25;
							((Enumerator<, >*)val4)->Dispose();
							bool flag24 = obj23 == null;
							object obj26 = !flag24;
							if (obj26 == null)
							{
								bool flag25 = (object)obj9 == null;
								object obj27 = !flag25;
								OutOfMemoryException ex5 = (OutOfMemoryException)val4;
								if (obj27 == null)
								{
									goto IL_04f6;
								}
							}
							else
							{
								OutOfMemoryException ex5 = new OutOfMemoryException();
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
							goto IL_05dd;
							IL_05dd:
							NullReferenceException ex6 = new NullReferenceException();
							if ((nint)obj11 == 2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								obj9 = (UnityEngine.Object)1;
								obj23 = obj22;
							}
							else
							{
								if ((nint)obj11 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
									return result2;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								obj23 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								obj22 = obj28;
							}
							result = null;
							obj24 = 0;
							goto IL_0780;
						}
					}
					throw new NullReferenceException();
				}
			}
			goto IL_053b;
		}
		goto IL_06cd;
		IL_04f6:
		if ((nint)obj24 != 3)
		{
			bool flag26 = obj24 == null;
			object obj29 = !flag26;
			if (obj29 != null)
			{
				goto IL_06cd;
			}
		}
		goto IL_053b;
		IL_06cd:
		return result;
		IL_053b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF630]");
		object obj30 = 0;
		result = (string)obj30;
		goto IL_06cd;
	}

	private static string Ago(long ms)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I4
		//IL_0032: Expected I8, but got I4
		//IL_00ae: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long num = Math.Max(0L, ms);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction SMULH not yet implemented.\"");
		long num2 = 307445734561825L + 5037190915060954895L;
		if (num < 60000)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A18]");
			return (string)0;
		}
		bool flag2 = num2 < 60;
		object obj4 = !flag2;
		string text;
		object obj5;
		if (obj4 == null)
		{
			long num3 = default;
			text = num3.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A28]");
			obj5 = 0;
		}
		else
		{
			bool flag3 = num2 < 1440;
			object obj6 = !flag3;
			long num4 = default;
			if (obj6 == null)
			{
				text = num4.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC138]");
				obj5 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMULH not yet implemented.\"");
				text = num4.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A20]");
				obj5 = 0;
			}
		}
		return text + (string)obj5;
	}

	private unsafe void Redraw(bool force)
	{
		//IL_0010: Expected Obj, but got I
		//IL_75c1: Expected Obj, but got I4
		//IL_75e7: Expected Obj, but got I
		//IL_7609: Expected Obj, but got I4
		//IL_904e: Expected I, but got Obj
		//IL_905e: Expected Obj, but got I
		//IL_907e: Expected Obj, but got I
		//IL_908e: Expected Obj, but got I
		//IL_90aa: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I
		//IL_0420: Expected Obj, but got I
		//IL_7664: Expected I, but got Obj
		//IL_7686: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I4
		//IL_90c8: Expected Obj, but got I
		//IL_7627: Expected Obj, but got I
		//IL_7637: Expected Obj, but got I
		//IL_0482: Expected Obj, but got I4
		//IL_0440: Expected I, but got Obj
		//IL_0162: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I
		//IL_76cd: Expected Obj, but got I
		//IL_76d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_76e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_7712: Unknown result type (might be due to invalid IL or missing references)
		//IL_771e: Expected Obj, but got I4
		//IL_43e6: Expected I, but got Obj
		//IL_43ff: Expected Obj, but got I
		//IL_04cd: Expected I, but got Obj
		//IL_04ef: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected I, but got Obj
		//IL_0260: Expected Obj, but got I
		//IL_7744: Expected I, but got Obj
		//IL_7766: Expected Obj, but got I4
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got I
		//IL_02b8: Expected Obj, but got I4
		//IL_90fd: Expected Obj, but got I
		//IL_7784: Expected I, but got Obj
		//IL_77a6: Expected Obj, but got I4
		//IL_0597: Invalid comparison between F4 and I4
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got I
		//IL_02ff: Expected I, but got Obj
		//IL_0318: Expected Obj, but got I
		//IL_0523: Expected I, but got Obj
		//IL_77bc: Expected I, but got Obj
		//IL_77de: Expected Obj, but got I4
		//IL_0336: Expected Obj, but got I
		//IL_035d: Expected Obj, but got I
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected I, but got Obj
		//IL_03ba: Expected Obj, but got I
		//IL_9141: Expected Obj, but got I
		//IL_9151: Expected Obj, but got I
		//IL_9178: Expected Obj, but got I
		//IL_9180: Unknown result type (might be due to invalid IL or missing references)
		//IL_9193: Unknown result type (might be due to invalid IL or missing references)
		//IL_91c0: Expected Obj, but got I4
		//IL_05fc: Expected I, but got Obj
		//IL_03e9: Expected Obj, but got I
		//IL_03f2: Expected I, but got Obj
		//IL_040b: Expected Obj, but got I
		//IL_0611: Expected Obj, but got I
		//IL_78cb: Expected Obj, but got I
		//IL_78d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_78e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Expected I, but got Obj
		//IL_0669: Expected Obj, but got I4
		//IL_07cc: Expected Obj, but got I
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected Obj, but got Unknown
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_77fc: Expected I, but got Obj
		//IL_781e: Expected Obj, but got I4
		//IL_91ee: Expected Obj, but got I
		//IL_91fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_91ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_9203: Unknown result type (might be due to invalid IL or missing references)
		//IL_9220: Invalid comparison between F8 and I4
		//IL_9231: Expected Obj, but got I4
		//IL_923a: Expected I4, but got Obj
		//IL_7946: Expected Obj, but got I
		//IL_069d: Expected I, but got Obj
		//IL_1415: Expected Obj, but got I
		//IL_141d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1430: Unknown result type (might be due to invalid IL or missing references)
		//IL_1470: Unknown result type (might be due to invalid IL or missing references)
		//IL_1495: Expected Obj, but got I4
		//IL_900d: Expected Obj, but got I
		//IL_9015: Unknown result type (might be due to invalid IL or missing references)
		//IL_901e: Expected Ref, but got Unknown
		//IL_9038: Expected Obj, but got I4
		//IL_0828: Expected Obj, but got I
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected Obj, but got I4
		//IL_06e9: Expected Obj, but got I4
		//IL_14c5: Expected Obj, but got I4
		//IL_14cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d5: Expected Obj, but got Unknown
		//IL_08e1: Expected Obj, but got I
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0941: Expected Obj, but got I4
		//IL_0949: Expected Obj, but got I4
		//IL_0952: Expected I4, but got Obj
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_097d: Expected I, but got Obj
		//IL_785c: Expected I, but got Obj
		//IL_787e: Expected Obj, but got I4
		//IL_09dd: Expected Obj, but got I
		//IL_09e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3d: Expected Obj, but got I4
		//IL_0a45: Expected Obj, but got I4
		//IL_0a4e: Expected I4, but got Obj
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a79: Expected I, but got Obj
		//IL_9258: Expected Obj, but got I
		//IL_9264: Unknown result type (might be due to invalid IL or missing references)
		//IL_9278: Invalid comparison between F4 and I
		//IL_1538: Expected Obj, but got I
		//IL_071d: Expected I, but got Obj
		//IL_151a: Expected Obj, but got I4
		//IL_0ad9: Expected Obj, but got I
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b39: Expected Obj, but got I4
		//IL_0b41: Expected Obj, but got I4
		//IL_0b4a: Expected I4, but got Obj
		//IL_0b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b75: Expected I, but got Obj
		//IL_7980: Expected I, but got Obj
		//IL_79a2: Expected Obj, but got I4
		//IL_7585: Expected Obj, but got I4
		//IL_157c: Invalid comparison between F4 and I4
		//IL_0bd5: Expected Obj, but got I
		//IL_0bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c35: Expected Obj, but got I4
		//IL_0c3d: Expected Obj, but got I4
		//IL_0c46: Expected I4, but got Obj
		//IL_0c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Expected I, but got Obj
		//IL_1694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd1: Expected Obj, but got I
		//IL_0cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d31: Expected Obj, but got I4
		//IL_0d39: Expected Obj, but got I4
		//IL_0d42: Expected I4, but got Obj
		//IL_0d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6d: Expected I, but got Obj
		//IL_7a07: Expected Obj, but got I4
		//IL_7a17: Expected Obj, but got I4
		//IL_1604: Unknown result type (might be due to invalid IL or missing references)
		//IL_1618: Unknown result type (might be due to invalid IL or missing references)
		//IL_161c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1620: Unknown result type (might be due to invalid IL or missing references)
		//IL_1624: Unknown result type (might be due to invalid IL or missing references)
		//IL_1669: Unknown result type (might be due to invalid IL or missing references)
		//IL_79b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_79b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_79be: Expected Obj, but got Unknown
		//IL_15b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcd: Expected Obj, but got I
		//IL_0dd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2d: Expected Obj, but got I4
		//IL_0e35: Expected Obj, but got I4
		//IL_0e3e: Expected I4, but got Obj
		//IL_0e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e69: Expected I, but got Obj
		//IL_0e71: Expected Obj, but got I4
		//IL_16a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16aa: Expected I4, but got Unknown
		//IL_16d3: Expected I, but got Obj
		//IL_163e: Unknown result type (might be due to invalid IL or missing references)
		//IL_162d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eaa: Expected I4, but got Unknown
		//IL_0eda: Expected Obj, but got I
		//IL_0ee2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3a: Expected Obj, but got I4
		//IL_0f42: Expected Obj, but got I4
		//IL_0f4b: Expected I4, but got Obj
		//IL_0f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f76: Expected I, but got Obj
		//IL_0f7e: Expected Obj, but got I4
		//IL_16f1: Expected Obj, but got I
		//IL_1703: Expected I, but got Obj
		//IL_1713: Expected Obj, but got I
		//IL_1723: Expected Obj, but got I
		//IL_1757: Expected I, but got Obj
		//IL_0fb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb7: Expected I4, but got Unknown
		//IL_0fe7: Expected Obj, but got I
		//IL_0fef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1002: Unknown result type (might be due to invalid IL or missing references)
		//IL_1047: Expected Obj, but got I4
		//IL_104f: Expected Obj, but got I4
		//IL_1058: Expected I4, but got Obj
		//IL_106a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1083: Expected I, but got Obj
		//IL_108b: Expected Obj, but got I4
		//IL_1775: Expected Obj, but got I
		//IL_17a0: Expected I, but got Obj
		//IL_10e6: Expected Obj, but got I
		//IL_10ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1101: Unknown result type (might be due to invalid IL or missing references)
		//IL_1146: Expected Obj, but got I4
		//IL_114e: Expected Obj, but got I4
		//IL_1157: Expected I4, but got Obj
		//IL_1169: Unknown result type (might be due to invalid IL or missing references)
		//IL_1182: Expected I, but got Obj
		//IL_118a: Expected Obj, but got I4
		//IL_17b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_17bc: Expected Obj, but got Unknown
		//IL_17de: Expected Obj, but got I
		//IL_17e7: Expected Obj, but got Ref
		//IL_180a: Expected Obj, but got I8
		//IL_1843: Expected Obj, but got I4
		//IL_1847: Unknown result type (might be due to invalid IL or missing references)
		//IL_1858: Expected I, but got Obj
		//IL_1866: Expected Obj, but got I4
		//IL_11e5: Expected Obj, but got I
		//IL_11ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_1200: Unknown result type (might be due to invalid IL or missing references)
		//IL_1245: Expected Obj, but got I4
		//IL_124d: Expected Obj, but got I4
		//IL_1256: Expected I4, but got Obj
		//IL_1268: Unknown result type (might be due to invalid IL or missing references)
		//IL_1281: Expected I, but got Obj
		//IL_1289: Expected Obj, but got I4
		//IL_187d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1882: Expected Obj, but got Unknown
		//IL_18b6: Expected Obj, but got I4
		//IL_18cc: Expected Obj, but got I
		//IL_18ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f1: Expected Obj, but got Unknown
		//IL_191b: Expected Obj, but got I4
		//IL_191f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1930: Expected I, but got Obj
		//IL_1941: Expected Obj, but got I4
		//IL_12e4: Expected Obj, but got I
		//IL_12ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1344: Expected Obj, but got I4
		//IL_134c: Expected Obj, but got I4
		//IL_1355: Expected I4, but got Obj
		//IL_1367: Unknown result type (might be due to invalid IL or missing references)
		//IL_1380: Expected I, but got Obj
		//IL_1388: Expected Obj, but got I4
		//IL_195f: Expected Obj, but got I
		//IL_1968: Unknown result type (might be due to invalid IL or missing references)
		//IL_196d: Expected Obj, but got Unknown
		//IL_1985: Unknown result type (might be due to invalid IL or missing references)
		//IL_198a: Expected I4, but got Unknown
		//IL_13e5: Expected Obj, but got I4
		//IL_13ed: Expected Obj, but got I4
		//IL_13f6: Expected I4, but got Obj
		//IL_13fb: Expected I, but got Obj
		//IL_19b6: Expected Obj, but got I8
		//IL_19ef: Expected Obj, but got I4
		//IL_19f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a04: Expected I, but got Obj
		//IL_1a12: Expected Obj, but got I4
		//IL_1a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2e: Expected Obj, but got Unknown
		//IL_1a62: Expected Obj, but got I4
		//IL_1a78: Expected Obj, but got I
		//IL_1a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9d: Expected Obj, but got Unknown
		//IL_1ac7: Expected Obj, but got I4
		//IL_1acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1adc: Expected I, but got Obj
		//IL_1aed: Expected Obj, but got I4
		//IL_1b04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b09: Expected Obj, but got Unknown
		//IL_1b19: Expected Obj, but got I
		//IL_1b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2e: Expected I4, but got Unknown
		//IL_1b62: Expected Obj, but got I4
		//IL_1b78: Expected Obj, but got I
		//IL_1b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9d: Expected Obj, but got Unknown
		//IL_1bcf: Expected Obj, but got I4
		//IL_1bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be4: Expected I, but got Obj
		//IL_1bf2: Expected Obj, but got I4
		//IL_1c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0e: Expected Obj, but got Unknown
		//IL_1c37: Expected I4, but got I8
		//IL_1c51: Expected Obj, but got I4
		//IL_7aaa: Expected Obj, but got I4
		//IL_7aba: Expected Obj, but got I4
		//IL_7ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_7adf: Expected Obj, but got Unknown
		//IL_7b10: Expected Obj, but got I4
		//IL_7b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b1d: Expected I, but got Obj
		//IL_7b2b: Expected Obj, but got I4
		//IL_7a40: Expected I, but got Obj
		//IL_7a73: Expected Obj, but got I4
		//IL_1cab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb0: Expected Obj, but got Unknown
		//IL_1cdc: Expected Obj, but got I8
		//IL_1d1c: Expected Obj, but got I4
		//IL_1d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d29: Expected I, but got Obj
		//IL_1d3a: Expected Obj, but got I4
		//IL_1c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d67: Expected Obj, but got I
		//IL_1d72: Expected Obj, but got I4
		//IL_1d7b: Expected I4, but got Obj
		//IL_1da6: Expected Obj, but got I
		//IL_7b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b4f: Expected Obj, but got Unknown
		//IL_7b96: Expected Obj, but got I4
		//IL_7ba6: Expected Obj, but got I4
		//IL_7bc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_7bcb: Expected Obj, but got Unknown
		//IL_7bfc: Expected Obj, but got I4
		//IL_7c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_7c09: Expected I, but got Obj
		//IL_1db3: Expected I, but got Obj
		//IL_1dd5: Expected Obj, but got I4
		//IL_1e17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e1c: Expected Obj, but got Unknown
		//IL_1e3e: Expected Obj, but got I
		//IL_1e4e: Expected Obj, but got I
		//IL_1e70: Expected Obj, but got I4
		//IL_1eb6: Expected Obj, but got I4
		//IL_1ec6: Expected Obj, but got I4
		//IL_1ee6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eeb: Expected Obj, but got Unknown
		//IL_1f1c: Expected Obj, but got I4
		//IL_1f20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f29: Expected I, but got Obj
		//IL_7c1f: Expected I, but got Obj
		//IL_7c41: Expected Obj, but got I4
		//IL_92a5: Expected Obj, but got I
		//IL_1f45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4a: Expected Obj, but got Unknown
		//IL_1e09: Expected I, but got Obj
		//IL_1f90: Expected Obj, but got I4
		//IL_1fa6: Expected Obj, but got I
		//IL_1fc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fcb: Expected Obj, but got Unknown
		//IL_1ffc: Expected Obj, but got I4
		//IL_2000: Unknown result type (might be due to invalid IL or missing references)
		//IL_2009: Expected I, but got Obj
		//IL_2025: Unknown result type (might be due to invalid IL or missing references)
		//IL_202a: Expected Obj, but got Unknown
		//IL_204c: Expected Obj, but got I
		//IL_2076: Expected Obj, but got I4
		//IL_20b1: Expected Obj, but got I
		//IL_7c61: Expected Obj, but got I4
		//IL_7c7d: Expected Obj, but got I4
		//IL_7c8d: Expected Obj, but got I4
		//IL_7cad: Unknown result type (might be due to invalid IL or missing references)
		//IL_7cb2: Expected Obj, but got Unknown
		//IL_7ce3: Expected Obj, but got I4
		//IL_7ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_7cf0: Expected I, but got Obj
		//IL_210e: Expected Obj, but got I4
		//IL_2112: Unknown result type (might be due to invalid IL or missing references)
		//IL_211b: Expected I, but got Obj
		//IL_214a: Unknown result type (might be due to invalid IL or missing references)
		//IL_214f: Expected Obj, but got Unknown
		//IL_2169: Expected I, but got Obj
		//IL_218b: Expected Obj, but got I4
		//IL_21c1: Expected Obj, but got I
		//IL_21d1: Expected Obj, but got I
		//IL_21f3: Expected Obj, but got I4
		//IL_2137: Unknown result type (might be due to invalid IL or missing references)
		//IL_213c: Expected Obj, but got Unknown
		//IL_2239: Expected Obj, but got I4
		//IL_2249: Expected Obj, but got I4
		//IL_2269: Unknown result type (might be due to invalid IL or missing references)
		//IL_226e: Expected Obj, but got Unknown
		//IL_229f: Expected Obj, but got I4
		//IL_22a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ac: Expected I, but got Obj
		//IL_22c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22cd: Expected Obj, but got Unknown
		//IL_7d0b: Expected I, but got Obj
		//IL_7d2d: Expected Obj, but got I4
		//IL_92ce: Expected Obj, but got I4
		//IL_92de: Expected Obj, but got I4
		//IL_92fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_9303: Expected Obj, but got Unknown
		//IL_933c: Expected Obj, but got I4
		//IL_9340: Unknown result type (might be due to invalid IL or missing references)
		//IL_9349: Expected I, but got Obj
		//IL_22f6: Expected I, but got Obj
		//IL_230b: Expected Obj, but got I
		//IL_2314: Unknown result type (might be due to invalid IL or missing references)
		//IL_2319: Expected Obj, but got Unknown
		//IL_2329: Expected Obj, but got I
		//IL_2370: Expected Obj, but got I4
		//IL_2386: Expected Obj, but got I
		//IL_23a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ab: Expected Obj, but got Unknown
		//IL_23e4: Expected Obj, but got I4
		//IL_23e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f1: Expected I, but got Obj
		//IL_240d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2412: Expected Obj, but got Unknown
		//IL_246c: Expected Obj, but got I4
		//IL_2470: Unknown result type (might be due to invalid IL or missing references)
		//IL_2479: Expected I, but got Obj
		//IL_24e9: Expected Obj, but got I4
		//IL_24ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_24f6: Expected I, but got Obj
		//IL_252d: Expected Obj, but got I8
		//IL_2575: Expected Obj, but got I4
		//IL_2579: Unknown result type (might be due to invalid IL or missing references)
		//IL_2582: Expected I, but got Obj
		//IL_259e: Unknown result type (might be due to invalid IL or missing references)
		//IL_25a3: Expected Obj, but got Unknown
		//IL_25e1: Expected Obj, but got I4
		//IL_25e6: Expected I, but got Obj
		//IL_26c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_26cd: Expected Obj, but got Unknown
		//IL_26ef: Expected Obj, but got I
		//IL_26f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_26fa: Expected Obj, but got Unknown
		//IL_2724: Expected Obj, but got I4
		//IL_2767: Expected Obj, but got I4
		//IL_261b: Expected I, but got Obj
		//IL_292b: Expected Obj, but got I
		//IL_2955: Expected Obj, but got I4
		//IL_278a: Expected Obj, but got I
		//IL_2639: Expected Obj, but got I
		//IL_2663: Expected Obj, but got I4
		//IL_29ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_29b1: Expected Obj, but got Unknown
		//IL_29c1: Expected Obj, but got I
		//IL_29db: Expected Obj, but got I4
		//IL_27ce: Expected VT, but got I4
		//IL_2819: Expected Obj, but got I4
		//IL_281d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2833: Expected Obj, but got I4
		//IL_26aa: Expected Obj, but got I4
		//IL_26af: Expected I, but got Obj
		//IL_2b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b71: Expected Obj, but got Unknown
		//IL_2b8b: Expected Obj, but got I4
		//IL_2b9b: Expected Obj, but got I4
		//IL_2d20: Expected I, but got Obj
		//IL_2d42: Expected Obj, but got I4
		//IL_2a0b: Expected Obj, but got I
		//IL_2a35: Expected Obj, but got I4
		//IL_7d91: Expected Obj, but got I
		//IL_7da1: Expected Obj, but got I
		//IL_7db1: Expected Obj, but got I
		//IL_7e0b: Expected Obj, but got I4
		//IL_7e0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bb9: Expected Obj, but got I
		//IL_2be3: Expected Obj, but got I4
		//IL_2888: Expected Obj, but got I
		//IL_2d6a: Expected I, but got Obj
		//IL_2c24: Expected I, but got Obj
		//IL_7d4b: Expected Obj, but got I4
		//IL_28be: Expected Obj, but got I
		//IL_2d79: Expected Obj, but got I4
		//IL_2dac: Expected Obj, but got I4
		//IL_2de5: Expected Obj, but got I4
		//IL_2de9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ae5: Expected Obj, but got I4
		//IL_2ae9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2af2: Expected I, but got Obj
		//IL_28d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d8: Expected Obj, but got Unknown
		//IL_28f3: Expected VT, but got I4
		//IL_290e: Expected Obj, but got I4
		//IL_2c8b: Expected Obj, but got I4
		//IL_2c8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca0: Expected I, but got Obj
		//IL_2e1a: Expected Obj, but got I
		//IL_2e22: Expected I, but got Obj
		//IL_2e4c: Expected Obj, but got I4
		//IL_2b24: Expected Obj, but got I
		//IL_7e41: Expected Obj, but got I
		//IL_7e4f: Expected Obj, but got Ref
		//IL_7e82: Expected VT, but got Ref
		//IL_7e82: Expected Obj, but got I
		//IL_7e9e: Expected Obj, but got I
		//IL_2cda: Expected Obj, but got I
		//IL_2b50: Expected Obj, but got I
		//IL_2b61: Expected I4, but got Obj
		//IL_2e9d: Expected Obj, but got I4
		//IL_2e6c: Expected I, but got Obj
		//IL_2d06: Expected Obj, but got I
		//IL_2d0b: Expected I, but got Obj
		//IL_2ee7: Expected Obj, but got I
		//IL_2f04: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f08: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f1d: Expected VT, but got Ref
		//IL_2f52: Expected Obj, but got I4
		//IL_2f65: Expected Obj, but got I4
		//IL_2f69: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f7d: Expected F8, but got Obj
		//IL_2f7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f81: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f9e: Expected Obj, but got I
		//IL_2fa7: Expected Obj, but got I4
		//IL_2fca: Expected Obj, but got I4
		//IL_2fd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fd9: Expected I4, but got Unknown
		//IL_441d: Expected Obj, but got I
		//IL_4461: Expected Obj, but got I
		//IL_446a: Expected Obj, but got I4
		//IL_3176: Expected Obj, but got I
		//IL_944a: Expected VT, but got Ref
		//IL_945a: Expected F8, but got Obj
		//IL_945a: Unknown result type (might be due to invalid IL or missing references)
		//IL_945e: Unknown result type (might be due to invalid IL or missing references)
		//IL_31a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_31a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_31ba: Expected VT, but got Ref
		//IL_31ef: Expected Obj, but got I4
		//IL_320a: Expected Obj, but got I4
		//IL_320e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3222: Expected F8, but got Obj
		//IL_3222: Unknown result type (might be due to invalid IL or missing references)
		//IL_3226: Unknown result type (might be due to invalid IL or missing references)
		//IL_3240: Expected Obj, but got I4
		//IL_4e5e: Expected Obj, but got I
		//IL_4e77: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e9b: Expected Obj, but got I4
		//IL_4eae: Expected Obj, but got I4
		//IL_4eb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ec7: Expected Obj, but got I4
		//IL_937d: Unknown result type (might be due to invalid IL or missing references)
		//IL_9381: Unknown result type (might be due to invalid IL or missing references)
		//IL_9396: Expected VT, but got Ref
		//IL_93cb: Expected Obj, but got I4
		//IL_93de: Expected Obj, but got I4
		//IL_93e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_93f6: Expected F8, but got Obj
		//IL_93f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_93fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_9417: Expected Obj, but got I
		//IL_941f: Expected Obj, but got I4
		//IL_447f: Expected Obj, but got I
		//IL_44a9: Expected Obj, but got I4
		//IL_325f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3263: Unknown result type (might be due to invalid IL or missing references)
		//IL_3278: Expected VT, but got Ref
		//IL_32ad: Expected Obj, but got I4
		//IL_32c8: Expected Obj, but got I4
		//IL_32cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_32e0: Expected F8, but got Obj
		//IL_32e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_32e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_32fe: Expected Obj, but got I4
		//IL_4ee6: Unknown result type (might be due to invalid IL or missing references)
		//IL_4eea: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f0a: Expected Obj, but got I4
		//IL_4f1d: Expected Obj, but got I4
		//IL_4f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f36: Expected Obj, but got I4
		//IL_3047: Expected Obj, but got I
		//IL_3066: Unknown result type (might be due to invalid IL or missing references)
		//IL_306a: Unknown result type (might be due to invalid IL or missing references)
		//IL_307f: Expected VT, but got Ref
		//IL_30b4: Expected Obj, but got I4
		//IL_30c7: Expected Obj, but got I4
		//IL_30cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_30df: Expected F8, but got Obj
		//IL_30df: Unknown result type (might be due to invalid IL or missing references)
		//IL_30e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3100: Expected Obj, but got I
		//IL_3108: Expected Obj, but got I4
		//IL_45b3: Expected Obj, but got I
		//IL_3315: Unknown result type (might be due to invalid IL or missing references)
		//IL_331a: Expected Obj, but got Unknown
		//IL_3346: Expected Obj, but got I8
		//IL_3355: Unknown result type (might be due to invalid IL or missing references)
		//IL_3359: Unknown result type (might be due to invalid IL or missing references)
		//IL_336e: Expected VT, but got Ref
		//IL_33a3: Expected Obj, but got I4
		//IL_33be: Expected Obj, but got I4
		//IL_33c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_33d6: Expected F8, but got Obj
		//IL_33d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_33da: Unknown result type (might be due to invalid IL or missing references)
		//IL_33f7: Expected Obj, but got I4
		//IL_4f4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f52: Expected Obj, but got Unknown
		//IL_80d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_80dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_80f2: Expected VT, but got Ref
		//IL_810e: Expected Obj, but got I4
		//IL_8129: Expected Obj, but got I4
		//IL_812d: Unknown result type (might be due to invalid IL or missing references)
		//IL_8141: Expected F8, but got Obj
		//IL_8141: Unknown result type (might be due to invalid IL or missing references)
		//IL_8145: Unknown result type (might be due to invalid IL or missing references)
		//IL_814e: Expected I, but got Obj
		//IL_4500: Unknown result type (might be due to invalid IL or missing references)
		//IL_4504: Unknown result type (might be due to invalid IL or missing references)
		//IL_4519: Expected VT, but got Ref
		//IL_4535: Expected Obj, but got I4
		//IL_4550: Expected Obj, but got I4
		//IL_4554: Unknown result type (might be due to invalid IL or missing references)
		//IL_4568: Expected F8, but got Obj
		//IL_4568: Unknown result type (might be due to invalid IL or missing references)
		//IL_456c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4575: Expected I, but got Obj
		//IL_3126: Expected Obj, but got I
		//IL_4f8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f91: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fb1: Expected Obj, but got I4
		//IL_4fc4: Expected Obj, but got I4
		//IL_4fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fdc: Expected I, but got Obj
		//IL_4fe4: Expected Obj, but got I4
		//IL_3415: Expected Obj, but got I
		//IL_3426: Unknown result type (might be due to invalid IL or missing references)
		//IL_342b: Expected Obj, but got Unknown
		//IL_3451: Unknown result type (might be due to invalid IL or missing references)
		//IL_3455: Unknown result type (might be due to invalid IL or missing references)
		//IL_346a: Expected VT, but got Ref
		//IL_349f: Expected Obj, but got I4
		//IL_34ba: Expected Obj, but got I4
		//IL_34be: Unknown result type (might be due to invalid IL or missing references)
		//IL_34d2: Expected F8, but got Obj
		//IL_34d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_34d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_34eb: Expected Obj, but got I4
		//IL_7eb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_7eb5: Expected Obj, but got Unknown
		//IL_45e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_45ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_4601: Expected VT, but got Ref
		//IL_461d: Expected Obj, but got I4
		//IL_4638: Expected Obj, but got I4
		//IL_463c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4650: Expected F8, but got Obj
		//IL_4650: Unknown result type (might be due to invalid IL or missing references)
		//IL_4654: Unknown result type (might be due to invalid IL or missing references)
		//IL_465d: Expected I, but got Obj
		//IL_4672: Expected Obj, but got I
		//IL_4599: Unknown result type (might be due to invalid IL or missing references)
		//IL_459e: Expected Obj, but got Unknown
		//IL_500e: Expected Obj, but got I4
		//IL_501e: Expected I4, but got Obj
		//IL_5026: Expected Obj, but got I4
		//IL_3522: Expected Obj, but got I4
		//IL_3532: Expected Obj, but got I4
		//IL_3552: Unknown result type (might be due to invalid IL or missing references)
		//IL_3557: Expected Obj, but got Unknown
		//IL_3557: Unknown result type (might be due to invalid IL or missing references)
		//IL_355b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3570: Expected VT, but got Ref
		//IL_35a5: Expected Obj, but got I4
		//IL_35c0: Expected Obj, but got I4
		//IL_35c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_35d8: Expected F8, but got Obj
		//IL_35d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_35dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_35f6: Expected Obj, but got I4
		//IL_5118: Expected Obj, but got I
		//IL_5142: Expected Obj, but got I4
		//IL_51a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_51ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_51c1: Expected VT, but got I4
		//IL_51ef: Expected Obj, but got I4
		//IL_5202: Expected Obj, but got I4
		//IL_5206: Unknown result type (might be due to invalid IL or missing references)
		//IL_5224: Expected Obj, but got I4
		//IL_5044: Expected Obj, but got I
		//IL_506e: Expected Obj, but got I4
		//IL_360d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3612: Expected Obj, but got Unknown
		//IL_363e: Expected Obj, but got I8
		//IL_364d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3651: Unknown result type (might be due to invalid IL or missing references)
		//IL_3666: Expected VT, but got Ref
		//IL_369b: Expected Obj, but got I4
		//IL_36b6: Expected Obj, but got I4
		//IL_36ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_36ce: Expected F8, but got Obj
		//IL_36ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_36d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_36ef: Expected Obj, but got I4
		//IL_50b1: Expected Obj, but got I
		//IL_50b9: Expected I, but got Obj
		//IL_50db: Expected Obj, but got I4
		//IL_817b: Expected Obj, but got I4
		//IL_818f: Expected Obj, but got I
		//IL_81a9: Expected Obj, but got I
		//IL_81b9: Expected Obj, but got I
		//IL_5258: Expected Obj, but got I
		//IL_528c: Expected Obj, but got I
		//IL_529c: Unknown result type (might be due to invalid IL or missing references)
		//IL_52a1: Expected Obj, but got Unknown
		//IL_52d6: Expected Obj, but got I4
		//IL_52de: Unknown result type (might be due to invalid IL or missing references)
		//IL_52e3: Expected Obj, but got Unknown
		//IL_52ec: Expected I4, but got Obj
		//IL_8217: Expected Obj, but got I
		//IL_8225: Expected Obj, but got Ref
		//IL_825d: Expected VT, but got Ref
		//IL_825d: Unknown result type (might be due to invalid IL or missing references)
		//IL_8261: Unknown result type (might be due to invalid IL or missing references)
		//IL_8277: Expected VT, but got Ref
		//IL_8298: Expected F8, but got I
		//IL_8298: Unknown result type (might be due to invalid IL or missing references)
		//IL_829c: Unknown result type (might be due to invalid IL or missing references)
		//IL_82b0: Expected Obj, but got I4
		//IL_46f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_46fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4712: Expected VT, but got Ref
		//IL_4723: Expected I4, but got Obj
		//IL_473f: Expected Obj, but got I4
		//IL_475a: Expected Obj, but got I4
		//IL_475e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4772: Expected F8, but got Obj
		//IL_4772: Unknown result type (might be due to invalid IL or missing references)
		//IL_4776: Unknown result type (might be due to invalid IL or missing references)
		//IL_4782: Expected I, but got Obj
		//IL_370d: Expected Obj, but got I
		//IL_3716: Unknown result type (might be due to invalid IL or missing references)
		//IL_371b: Expected Obj, but got Unknown
		//IL_373d: Expected Obj, but got I
		//IL_3767: Expected Obj, but got I4
		//IL_5311: Expected F8, but got I4
		//IL_5103: Expected I, but got Obj
		//IL_82db: Unknown result type (might be due to invalid IL or missing references)
		//IL_82e0: Expected Obj, but got Unknown
		//IL_82f2: Expected VT, but got I4
		//IL_8332: Unknown result type (might be due to invalid IL or missing references)
		//IL_8348: Expected Obj, but got I4
		//IL_8351: Expected Obj, but got I4
		//IL_5303: Expected F8, but got I4
		//IL_47b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_47b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_47cd: Expected VT, but got Ref
		//IL_47de: Expected I4, but got Obj
		//IL_47fa: Expected Obj, but got I4
		//IL_4815: Expected Obj, but got I4
		//IL_4819: Unknown result type (might be due to invalid IL or missing references)
		//IL_482d: Expected F8, but got Obj
		//IL_482d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4831: Unknown result type (might be due to invalid IL or missing references)
		//IL_483d: Expected I, but got Obj
		//IL_37bb: Expected Obj, but got I4
		//IL_37cb: Expected Obj, but got I4
		//IL_37eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_37f0: Expected Obj, but got Unknown
		//IL_37f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_37f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3809: Expected VT, but got Ref
		//IL_383e: Expected Obj, but got I4
		//IL_3859: Expected Obj, but got I4
		//IL_385d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3871: Expected F8, but got Obj
		//IL_3871: Unknown result type (might be due to invalid IL or missing references)
		//IL_3875: Unknown result type (might be due to invalid IL or missing references)
		//IL_388f: Expected Obj, but got I4
		//IL_88da: Expected Obj, but got F8
		//IL_88da: Unknown result type (might be due to invalid IL or missing references)
		//IL_88de: Unknown result type (might be due to invalid IL or missing references)
		//IL_88f6: Expected Obj, but got I4
		//IL_88fe: Expected Obj, but got I4
		//IL_8911: Expected Obj, but got I4
		//IL_4864: Unknown result type (might be due to invalid IL or missing references)
		//IL_4869: Expected Obj, but got Unknown
		//IL_488b: Expected F8, but got I
		//IL_4897: Expected native int or pointer, but got F8
		//IL_48a5: Expected Obj, but got F8
		//IL_38a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_38ab: Expected Obj, but got Unknown
		//IL_38df: Expected Obj, but got I4
		//IL_38f5: Expected Obj, but got I
		//IL_3915: Unknown result type (might be due to invalid IL or missing references)
		//IL_391a: Expected Obj, but got Unknown
		//IL_391a: Unknown result type (might be due to invalid IL or missing references)
		//IL_391e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3933: Expected VT, but got Ref
		//IL_3968: Expected Obj, but got I4
		//IL_3983: Expected Obj, but got I4
		//IL_3987: Unknown result type (might be due to invalid IL or missing references)
		//IL_399b: Expected F8, but got Obj
		//IL_399b: Unknown result type (might be due to invalid IL or missing references)
		//IL_399f: Unknown result type (might be due to invalid IL or missing references)
		//IL_39bc: Expected Obj, but got I4
		//IL_5323: Expected Obj, but got I4
		//IL_48c8: Expected Obj, but got I8
		//IL_48d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_48db: Unknown result type (might be due to invalid IL or missing references)
		//IL_48f0: Expected VT, but got Ref
		//IL_4901: Expected I4, but got Obj
		//IL_491d: Expected Obj, but got I4
		//IL_4938: Expected Obj, but got I4
		//IL_493c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4950: Expected F8, but got Obj
		//IL_4950: Unknown result type (might be due to invalid IL or missing references)
		//IL_4954: Unknown result type (might be due to invalid IL or missing references)
		//IL_495c: Expected native int or pointer, but got F8
		//IL_4965: Expected I, but got F8
		//IL_5465: Expected Obj, but got I
		//IL_5495: Expected Obj, but got I4
		//IL_39da: Expected Obj, but got I
		//IL_39e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_39e8: Expected Obj, but got Unknown
		//IL_551c: Expected Obj, but got I4
		//IL_498c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4991: Expected Obj, but got Unknown
		//IL_49ab: Expected native int or pointer, but got F8
		//IL_49b9: Expected Obj, but got F8
		//IL_3a14: Expected I, but got Obj
		//IL_3a24: Expected Obj, but got I
		//IL_3a46: Expected Obj, but got I4
		//IL_83ff: Expected Obj, but got I
		//IL_54c5: Expected Obj, but got I4
		//IL_49e4: Expected Obj, but got I4
		//IL_49fa: Expected Obj, but got I
		//IL_4a1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a1f: Expected Obj, but got Unknown
		//IL_4a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a38: Expected VT, but got Ref
		//IL_4a66: Expected Obj, but got I4
		//IL_4a81: Expected Obj, but got I4
		//IL_4a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a99: Expected F8, but got Obj
		//IL_4a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4aa9: Expected I, but got Obj
		//IL_4aad: Expected native int or pointer, but got F8
		//IL_4ab6: Expected Obj, but got F8
		//IL_3a67: Expected native int or pointer, but got Obj
		//IL_3a7a: Expected Obj, but got I4
		//IL_3ac1: Expected Obj, but got I4
		//IL_9554: Expected VT, but got Obj
		//IL_9554: Expected I4, but got F8
		//IL_9575: Expected VT, but got Obj
		//IL_9586: Expected I4, but got F8
		//IL_9597: Expected Obj, but got I4
		//IL_95a4: Expected VT, but got Obj
		//IL_95b5: Expected I4, but got F8
		//IL_95c6: Expected Obj, but got I4
		//IL_5544: Expected Obj, but got I
		//IL_83e4: Expected Obj, but got I
		//IL_53a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_53bb: Expected Obj, but got I
		//IL_53bb: Expected Obj, but got Unknown
		//IL_7eec: Expected I, but got Obj
		//IL_7f0e: Expected Obj, but got I4
		//IL_62f7: Expected Obj, but got I4
		//IL_6329: Expected I4, but got Obj
		//IL_6331: Expected Obj, but got I4
		//IL_54ed: Expected Obj, but got I
		//IL_53d8: Expected I, but got Obj
		//IL_53e8: Expected Obj, but got I
		//IL_4ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ada: Expected Obj, but got Unknown
		//IL_3cbe: Expected Obj, but got I
		//IL_3aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b04: Expected VT, but got Ref
		//IL_3b2d: Expected I4, but got Obj
		//IL_3b41: Expected Obj, but got I4
		//IL_3b5c: Expected Obj, but got I4
		//IL_3b60: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b74: Expected F8, but got Obj
		//IL_3b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_556d: Expected Obj, but got F8
		//IL_556d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5571: Unknown result type (might be due to invalid IL or missing references)
		//IL_5589: Expected Obj, but got I4
		//IL_5591: Expected Obj, but got I4
		//IL_5599: Expected Obj, but got I4
		//IL_55ac: Expected Obj, but got I4
		//IL_4b1c: Expected Obj, but got I8
		//IL_4b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b44: Expected VT, but got Ref
		//IL_4b72: Expected Obj, but got I4
		//IL_4b8d: Expected Obj, but got I4
		//IL_4b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ba5: Expected F8, but got Obj
		//IL_4ba5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ba9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bb2: Expected I, but got Obj
		//IL_7f35: Expected I4, but got Obj
		//IL_635f: Expected Obj, but got I
		//IL_5406: Expected Obj, but got I
		//IL_5430: Expected Obj, but got I4
		//IL_3d18: Expected Obj, but got I4
		//IL_3bb8: Expected Obj, but got I
		//IL_3be2: Expected Obj, but got I4
		//IL_55ea: Expected Obj, but got I
		//IL_55f2: Expected I, but got Obj
		//IL_836e: Expected Obj, but got I
		//IL_8392: Expected VT, but got I
		//IL_8392: Expected I4, but got F8
		//IL_83a2: Expected VT, but got I
		//IL_83b3: Expected I4, but got F8
		//IL_83c4: Expected Obj, but got I4
		//IL_4bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bde: Expected Obj, but got Unknown
		//IL_3dbd: Expected Obj, but got I4
		//IL_6733: Expected Obj, but got I
		//IL_6394: Expected Obj, but got I
		//IL_63be: Expected Obj, but got I4
		//IL_562e: Expected Obj, but got I
		//IL_5637: Invalid comparison between F4 and I4
		//IL_5646: Unknown result type (might be due to invalid IL or missing references)
		//IL_564e: Unknown result type (might be due to invalid IL or missing references)
		//IL_565a: Expected Obj, but got I4
		//IL_4c17: Expected Obj, but got I
		//IL_4c39: Expected Obj, but got I
		//IL_4c5b: Expected Obj, but got I4
		//IL_3df3: Expected Obj, but got I
		//IL_3d60: Expected Obj, but got I
		//IL_3d8e: Expected I, but got Obj
		//IL_3c2a: Expected Obj, but got I
		//IL_3c42: Expected Obj, but got I
		//IL_3c6c: Expected I4, but got Obj
		//IL_64f4: Expected Obj, but got I8
		//IL_650e: Expected Obj, but got I4
		//IL_8974: Expected Obj, but got I
		//IL_899d: Expected VT, but got I
		//IL_89c6: Expected Obj, but got F8
		//IL_89c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_89ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_89de: Expected VT, but got I
		//IL_8a04: Expected Obj, but got I4
		//IL_8a0c: Expected Obj, but got I4
		//IL_8a1f: Expected Obj, but got I4
		//IL_8a39: Expected Obj, but got I4
		//IL_8a49: Expected Obj, but got I
		//IL_593d: Expected Obj, but got I
		//IL_4c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cb6: Expected VT, but got Ref
		//IL_4cec: Expected Obj, but got I4
		//IL_4d07: Expected Obj, but got I4
		//IL_4d0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d1f: Expected F8, but got Obj
		//IL_4d1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_6dbf: Expected Obj, but got I
		//IL_6770: Expected Obj, but got VT
		//IL_6784: Expected Obj, but got I
		//IL_6794: Expected Obj, but got I
		//IL_4090: Unknown result type (might be due to invalid IL or missing references)
		//IL_4094: Unknown result type (might be due to invalid IL or missing references)
		//IL_40a9: Expected VT, but got Ref
		//IL_40b9: Expected I4, but got Obj
		//IL_40cd: Expected Obj, but got I4
		//IL_40e8: Expected Obj, but got I4
		//IL_40ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_4100: Expected F8, but got Obj
		//IL_4100: Unknown result type (might be due to invalid IL or missing references)
		//IL_4104: Unknown result type (might be due to invalid IL or missing references)
		//IL_4111: Expected Obj, but got I4
		//IL_4121: Expected Obj, but got I4
		//IL_680d: Expected Obj, but got I
		//IL_6837: Expected Obj, but got I4
		//IL_8d71: Expected I, but got Obj
		//IL_8d93: Expected Obj, but got I4
		//IL_67be: Expected Obj, but got I
		//IL_67cf: Expected I, but got Obj
		//IL_6524: Expected I, but got Obj
		//IL_6546: Expected Obj, but got I4
		//IL_640f: Expected Obj, but got I
		//IL_641d: Expected Obj, but got I4
		//IL_6451: Unknown result type (might be due to invalid IL or missing references)
		//IL_6456: Expected I4, but got Unknown
		//IL_648b: Expected Obj, but got I4
		//IL_6493: Unknown result type (might be due to invalid IL or missing references)
		//IL_6498: Expected Obj, but got Unknown
		//IL_852e: Expected Obj, but got F8
		//IL_852e: Unknown result type (might be due to invalid IL or missing references)
		//IL_8532: Unknown result type (might be due to invalid IL or missing references)
		//IL_8536: Unknown result type (might be due to invalid IL or missing references)
		//IL_853a: Unknown result type (might be due to invalid IL or missing references)
		//IL_853e: Unknown result type (might be due to invalid IL or missing references)
		//IL_8542: Unknown result type (might be due to invalid IL or missing references)
		//IL_855a: Expected Obj, but got I4
		//IL_8562: Expected Obj, but got I4
		//IL_856a: Expected Obj, but got I4
		//IL_857d: Expected Obj, but got I4
		//IL_8585: Unknown result type (might be due to invalid IL or missing references)
		//IL_858d: Expected F8, but got Unknown
		//IL_8596: Expected Obj, but got I4
		//IL_596f: Expected I4, but got Obj
		//IL_842e: Expected Obj, but got I4
		//IL_4d5e: Expected F8, but got I
		//IL_4d70: Expected native int or pointer, but got F8
		//IL_4df2: Expected Obj, but got I4
		//IL_4dfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_4dff: Expected Obj, but got Unknown
		//IL_4e08: Expected I4, but got Obj
		//IL_3e2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e47: Expected VT, but got Ref
		//IL_3e57: Expected I4, but got Obj
		//IL_3e6b: Expected Obj, but got I4
		//IL_3e86: Expected Obj, but got I4
		//IL_3e8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e9e: Expected F8, but got Obj
		//IL_3e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ea2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eaf: Expected Obj, but got I4
		//IL_3ebf: Expected Obj, but got I4
		//IL_8e3e: Expected Obj, but got I
		//IL_8e58: Expected Obj, but got I4
		//IL_6df1: Expected Obj, but got I
		//IL_6e1b: Expected Obj, but got I4
		//IL_9823: Expected Obj, but got I
		//IL_982c: Expected Obj, but got I4
		//IL_983d: Expected Obj, but got I4
		//IL_8bd8: Expected Obj, but got I
		//IL_8be8: Expected Obj, but got I
		//IL_8c00: Expected Obj, but got I
		//IL_8c17: Expected Obj, but got F8
		//IL_8c17: Unknown result type (might be due to invalid IL or missing references)
		//IL_8c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_8c4b: Expected Obj, but got I4
		//IL_8c53: Expected Obj, but got I4
		//IL_8c66: Expected Obj, but got I4
		//IL_569e: Invalid comparison between F4 and I4
		//IL_4e2d: Expected Obj, but got I4
		//IL_4140: Unknown result type (might be due to invalid IL or missing references)
		//IL_4144: Unknown result type (might be due to invalid IL or missing references)
		//IL_4159: Expected VT, but got Ref
		//IL_4169: Expected I4, but got Obj
		//IL_417d: Expected Obj, but got I4
		//IL_4198: Expected Obj, but got I4
		//IL_419c: Unknown result type (might be due to invalid IL or missing references)
		//IL_41b0: Expected F8, but got Obj
		//IL_41b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_41b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_41c1: Expected Obj, but got I4
		//IL_41d1: Expected Obj, but got I4
		//IL_8e23: Expected Obj, but got I4
		//IL_8dd3: Expected Obj, but got I4
		//IL_8ee0: Expected Obj, but got Ref
		//IL_8f0e: Expected VT, but got Ref
		//IL_8f2a: Expected Obj, but got F8
		//IL_8f2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f32: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f36: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f4b: Expected VT, but got Ref
		//IL_8f53: Expected I4, but got Obj
		//IL_8f70: Expected Obj, but got I4
		//IL_8f78: Expected Obj, but got I4
		//IL_8f8b: Expected Obj, but got I4
		//IL_8f9b: Expected F8, but got Obj
		//IL_8f9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_6882: Expected I, but got Obj
		//IL_656e: Expected I, but got Obj
		//IL_8a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_8a75: Expected Obj, but got Unknown
		//IL_8a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_8aa1: Expected Obj, but got Unknown
		//IL_8af1: Expected Obj, but got I4
		//IL_8af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_8afe: Expected Obj, but got Unknown
		//IL_8b07: Expected I4, but got Obj
		//IL_81f9: Expected Obj, but got I4
		//IL_4e1f: Expected Obj, but got I4
		//IL_3ede: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ee2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ef7: Expected VT, but got Ref
		//IL_3f07: Expected I4, but got Obj
		//IL_3f1b: Expected Obj, but got I4
		//IL_3f36: Expected Obj, but got I4
		//IL_3f3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f4e: Expected F8, but got Obj
		//IL_3f4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f52: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f5f: Expected Obj, but got I4
		//IL_3f6f: Expected Obj, but got I4
		//IL_8e92: Expected I, but got Obj
		//IL_8ebc: Expected Obj, but got I4
		//IL_985a: Expected Obj, but got I
		//IL_986a: Expected Obj, but got I
		//IL_6580: Expected Obj, but got I4
		//IL_65b6: Expected Obj, but got I4
		//IL_65be: Expected Obj, but got F8
		//IL_65be: Unknown result type (might be due to invalid IL or missing references)
		//IL_65c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_65f2: Expected Obj, but got I4
		//IL_65fa: Expected Obj, but got I4
		//IL_660d: Expected Obj, but got I4
		//IL_64d8: Expected Obj, but got I4
		//IL_57ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_9495: Expected Obj, but got I
		//IL_94a3: Expected Obj, but got Ref
		//IL_94ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_94b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_94be: Expected Obj, but got I4
		//IL_94c7: Expected Obj, but got I4
		//IL_94d0: Expected VT, but got Ref
		//IL_94d8: Expected I4, but got Obj
		//IL_9501: Expected F8, but got I
		//IL_9501: Unknown result type (might be due to invalid IL or missing references)
		//IL_9505: Unknown result type (might be due to invalid IL or missing references)
		//IL_9526: Expected Obj, but got I4
		//IL_41ef: Expected Obj, but got I
		//IL_4200: Unknown result type (might be due to invalid IL or missing references)
		//IL_4205: Expected Obj, but got Unknown
		//IL_4231: Expected Obj, but got I8
		//IL_4240: Unknown result type (might be due to invalid IL or missing references)
		//IL_4244: Unknown result type (might be due to invalid IL or missing references)
		//IL_4259: Expected VT, but got Ref
		//IL_4269: Expected I4, but got Obj
		//IL_427d: Expected Obj, but got I4
		//IL_4298: Expected Obj, but got I4
		//IL_429c: Unknown result type (might be due to invalid IL or missing references)
		//IL_42b0: Expected F8, but got Obj
		//IL_42b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_42b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_9885: Expected Obj, but got I
		//IL_988e: Expected Obj, but got I4
		//IL_989f: Expected Obj, but got I4
		//IL_6e88: Expected Obj, but got I4
		//IL_68ba: Expected Obj, but got F8
		//IL_68ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_68be: Unknown result type (might be due to invalid IL or missing references)
		//IL_68c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_68c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_68db: Expected VT, but got Ref
		//IL_68e3: Expected I4, but got Obj
		//IL_6900: Expected Obj, but got I4
		//IL_6908: Expected Obj, but got I4
		//IL_691b: Expected Obj, but got I4
		//IL_692b: Expected F8, but got Obj
		//IL_692b: Unknown result type (might be due to invalid IL or missing references)
		//IL_692f: Unknown result type (might be due to invalid IL or missing references)
		//IL_6938: Expected I, but got Obj
		//IL_8b27: Expected Obj, but got I4
		//IL_8b44: Expected Obj, but got I
		//IL_8b5c: Expected Obj, but got I
		//IL_8b65: Unknown result type (might be due to invalid IL or missing references)
		//IL_8b6a: Expected I4, but got Unknown
		//IL_8b91: Expected VT, but got I
		//IL_8ba1: Expected VT, but got I
		//IL_8bc3: Expected Obj, but got I4
		//IL_85c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_85c9: Expected I4, but got Unknown
		//IL_59b8: Expected Obj, but got I
		//IL_59e2: Expected Obj, but got I4
		//IL_578d: Unknown result type (might be due to invalid IL or missing references)
		//IL_8099: Expected I4, but got Obj
		//IL_4e40: Expected native int or pointer, but got F8
		//IL_3f8d: Expected Obj, but got I
		//IL_3f9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fa3: Expected Obj, but got Unknown
		//IL_3fcf: Expected Obj, but got I8
		//IL_3fde: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ff7: Expected VT, but got Ref
		//IL_4007: Expected I4, but got Obj
		//IL_401b: Expected Obj, but got I4
		//IL_4036: Expected Obj, but got I4
		//IL_403a: Unknown result type (might be due to invalid IL or missing references)
		//IL_404e: Expected F8, but got Obj
		//IL_404e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4052: Unknown result type (might be due to invalid IL or missing references)
		//IL_73c6: Expected I, but got Obj
		//IL_7079: Expected Obj, but got F8
		//IL_7079: Unknown result type (might be due to invalid IL or missing references)
		//IL_707d: Unknown result type (might be due to invalid IL or missing references)
		//IL_70b5: Expected Obj, but got I4
		//IL_70bd: Expected Obj, but got I4
		//IL_70d0: Expected Obj, but got I4
		//IL_70f8: Expected Obj, but got I
		//IL_7100: Expected Obj, but got I4
		//IL_6ef8: Expected Obj, but got F8
		//IL_6ef8: Unknown result type (might be due to invalid IL or missing references)
		//IL_6efc: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f2c: Expected Obj, but got I4
		//IL_6f34: Expected Obj, but got I4
		//IL_6f47: Expected Obj, but got I4
		//IL_6f6f: Expected Obj, but got I
		//IL_8df1: Expected Obj, but got I
		//IL_6650: Unknown result type (might be due to invalid IL or missing references)
		//IL_6655: Expected Obj, but got Unknown
		//IL_5a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a8a: Expected Obj, but got Unknown
		//IL_5a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a98: Expected I4, but got Unknown
		//IL_5ab5: Expected Obj, but got I
		//IL_5adf: Expected Obj, but got I4
		//IL_5a11: Expected Obj, but got I4
		//IL_5a2e: Expected Obj, but got I4
		//IL_9603: Expected Obj, but got I4
		//IL_8445: Unknown result type (might be due to invalid IL or missing references)
		//IL_844a: Expected Obj, but got Unknown
		//IL_8464: Expected Obj, but got I4
		//IL_42de: Expected Obj, but got I
		//IL_7244: Expected Obj, but got I4
		//IL_698e: Expected Obj, but got I
		//IL_69b8: Expected Obj, but got I4
		//IL_8ca4: Expected I, but got Obj
		//IL_8cda: Expected Obj, but got I4
		//IL_5a4f: Expected Obj, but got I4
		//IL_5a57: Expected Obj, but got I4
		//IL_57e5: Invalid comparison between F4 and I4
		//IL_7f64: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f69: Expected Obj, but got Unknown
		//IL_7f8b: Expected Obj, but got I
		//IL_7fd1: Expected Obj, but got I4
		//IL_407c: Expected Obj, but got I
		//IL_7144: Expected Obj, but got I
		//IL_7178: Expected Obj, but got I
		//IL_7188: Unknown result type (might be due to invalid IL or missing references)
		//IL_718d: Expected Obj, but got Unknown
		//IL_71c2: Expected Obj, but got I4
		//IL_71ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_71cf: Expected Obj, but got Unknown
		//IL_71d8: Expected I4, but got Obj
		//IL_7282: Expected Obj, but got F8
		//IL_7282: Unknown result type (might be due to invalid IL or missing references)
		//IL_7286: Unknown result type (might be due to invalid IL or missing references)
		//IL_72b6: Expected Obj, but got I4
		//IL_72be: Expected Obj, but got I4
		//IL_72d1: Expected Obj, but got I4
		//IL_72f9: Expected Obj, but got I
		//IL_6a02: Expected Obj, but got I4
		//IL_6695: Invalid comparison between F4 and I4
		//IL_66a4: Invalid comparison between F4 and I4
		//IL_66b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_66b8: Expected Obj, but got Unknown
		//IL_66c5: Expected Obj, but got F4
		//IL_66fa: Expected Obj, but got I4
		//IL_6702: Unknown result type (might be due to invalid IL or missing references)
		//IL_6707: Expected Obj, but got Unknown
		//IL_6710: Expected I4, but got Obj
		//IL_5b34: Expected Obj, but got I
		//IL_85fb: Expected Obj, but got I
		//IL_8604: Unknown result type (might be due to invalid IL or missing references)
		//IL_8609: Expected Obj, but got Unknown
		//IL_8623: Expected Obj, but got I4
		//IL_8476: Unknown result type (might be due to invalid IL or missing references)
		//IL_4318: Expected Obj, but got I
		//IL_4342: Expected Obj, but got I4
		//IL_8d05: Expected Obj, but got I
		//IL_8d15: Expected Obj, but got I
		//IL_8d32: Expected Obj, but got I
		//IL_8d47: Expected I4, but got Obj
		//IL_8d4f: Expected I, but got Obj
		//IL_5bd2: Expected Obj, but got I4
		//IL_5fb2: Expected Obj, but got I4
		//IL_590d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4378: Expected Obj, but got I
		//IL_4382: Expected I, but got Obj
		//IL_4392: Expected Obj, but got I
		//IL_43b4: Expected Obj, but got I4
		//IL_6a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a1b: Expected Obj, but got Unknown
		//IL_6a35: Expected Obj, but got I4
		//IL_8661: Expected Obj, but got I
		//IL_5b7b: Expected Obj, but got I4
		//IL_87a6: Expected Obj, but got I
		//IL_5ed6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5edb: Expected Obj, but got Unknown
		//IL_5ef5: Expected Obj, but got I4
		//IL_84df: Expected Obj, but got I
		//IL_8509: Expected Obj, but got I4
		//IL_586d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5881: Unknown result type (might be due to invalid IL or missing references)
		//IL_5885: Unknown result type (might be due to invalid IL or missing references)
		//IL_5889: Unknown result type (might be due to invalid IL or missing references)
		//IL_588d: Unknown result type (might be due to invalid IL or missing references)
		//IL_58da: Unknown result type (might be due to invalid IL or missing references)
		//IL_7fef: Expected Obj, but got I
		//IL_7ffd: Expected Obj, but got Ref
		//IL_8015: Unknown result type (might be due to invalid IL or missing references)
		//IL_8019: Unknown result type (might be due to invalid IL or missing references)
		//IL_8026: Expected VT, but got Ref
		//IL_8037: Expected I4, but got Obj
		//IL_8047: Expected F8, but got I
		//IL_8047: Unknown result type (might be due to invalid IL or missing references)
		//IL_804b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ab8: Expected Obj, but got F8
		//IL_6ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_6abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ad9: Expected VT, but got Ref
		//IL_6ae1: Expected I4, but got Obj
		//IL_6afe: Expected Obj, but got I4
		//IL_6b06: Expected Obj, but got I4
		//IL_6b19: Expected Obj, but got I4
		//IL_6b29: Expected F8, but got Obj
		//IL_6b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b36: Expected I, but got Obj
		//IL_96a6: Expected Obj, but got Ref
		//IL_96d2: Expected VT, but got Ref
		//IL_96e2: Expected Obj, but got I
		//IL_970c: Expected Obj, but got I4
		//IL_5bfa: Expected Obj, but got I
		//IL_8647: Expected Obj, but got I
		//IL_97b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_97b8: Expected I4, but got Unknown
		//IL_97e3: Expected Obj, but got Ref
		//IL_980e: Expected VT, but got Ref
		//IL_9621: Expected Obj, but got I
		//IL_962e: Expected I4, but got F8
		//IL_9654: Expected VT, but got I
		//IL_9654: Expected I4, but got F4
		//IL_9664: Expected VT, but got I
		//IL_9675: Expected I4, but got F4
		//IL_9685: Expected Obj, but got I4
		//IL_8484: Unknown result type (might be due to invalid IL or missing references)
		//IL_848d: Unknown result type (might be due to invalid IL or missing references)
		//IL_8492: Expected Obj, but got Unknown
		//IL_84ac: Expected Obj, but got I4
		//IL_5820: Unknown result type (might be due to invalid IL or missing references)
		//IL_5834: Unknown result type (might be due to invalid IL or missing references)
		//IL_5838: Unknown result type (might be due to invalid IL or missing references)
		//IL_583c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5840: Unknown result type (might be due to invalid IL or missing references)
		//IL_43dc: Expected I, but got Obj
		//IL_7366: Expected Obj, but got I4
		//IL_6a60: Expected Obj, but got I
		//IL_8689: Expected Obj, but got I
		//IL_8699: Expected Obj, but got I
		//IL_86c1: Expected VT, but got I
		//IL_5ba3: Expected Obj, but got I
		//IL_5feb: Unknown result type (might be due to invalid IL or missing references)
		//IL_5fef: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ffb: Unknown result type (might be due to invalid IL or missing references)
		//IL_600d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6019: Expected VT, but got Ref
		//IL_6021: Expected I4, but got Obj
		//IL_6031: Expected F8, but got Obj
		//IL_6036: Unknown result type (might be due to invalid IL or missing references)
		//IL_605d: Expected Obj, but got I4
		//IL_5f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f14: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f19: Expected Obj, but got Unknown
		//IL_5f33: Expected Obj, but got I4
		//IL_6b7b: Expected Obj, but got I
		//IL_6ba5: Expected Obj, but got I4
		//IL_5c2e: Expected Obj, but got I
		//IL_5c55: Expected Obj, but got I4
		//IL_5c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c63: Expected Obj, but got Unknown
		//IL_5c7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c80: Expected Obj, but got Unknown
		//IL_5cc2: Expected Obj, but got I4
		//IL_5ccb: Expected I4, but got Obj
		//IL_626f: Expected Obj, but got I4
		//IL_84be: Unknown result type (might be due to invalid IL or missing references)
		//IL_84c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_84c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5896: Unknown result type (might be due to invalid IL or missing references)
		//IL_589e: Expected F4, but got Unknown
		//IL_6bd9: Expected Obj, but got F8
		//IL_6bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_6bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_6be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_6be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_6bfa: Expected VT, but got Ref
		//IL_6c02: Expected I4, but got Obj
		//IL_6c1f: Expected Obj, but got I4
		//IL_6c27: Expected Obj, but got I4
		//IL_6c3a: Expected Obj, but got I4
		//IL_6c4a: Expected F8, but got Obj
		//IL_6c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c57: Expected I, but got Obj
		//IL_5cef: Expected Obj, but got I4
		//IL_6070: Unknown result type (might be due to invalid IL or missing references)
		//IL_6079: Unknown result type (might be due to invalid IL or missing references)
		//IL_607e: Expected I4, but got Unknown
		//IL_607e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6087: Unknown result type (might be due to invalid IL or missing references)
		//IL_608c: Expected Obj, but got Unknown
		//IL_60a6: Expected Obj, but got I4
		//IL_8889: Expected Obj, but got I
		//IL_5f63: Expected Obj, but got I4
		//IL_8731: Expected Obj, but got I4
		//IL_618f: Expected Obj, but got I
		//IL_61b9: Expected Obj, but got I4
		//IL_878b: Expected Obj, but got I
		//IL_6c95: Expected Obj, but got I
		//IL_6cad: Expected Obj, but got I
		//IL_6ce1: Expected Obj, but got F8
		//IL_6ce1: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ced: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d02: Expected VT, but got Ref
		//IL_6d0a: Expected I4, but got Obj
		//IL_6d27: Expected Obj, but got I4
		//IL_6d2f: Expected Obj, but got I4
		//IL_6d42: Expected Obj, but got I4
		//IL_6d52: Expected F8, but got Obj
		//IL_6d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d56: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d64: Expected I, but got Obj
		//IL_6d74: Expected Obj, but got I
		//IL_5d2e: Expected Obj, but got I
		//IL_5d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d44: Expected Obj, but got Unknown
		//IL_5d5e: Expected Obj, but got I4
		//IL_6172: Expected Obj, but got I
		//IL_617a: Expected Obj, but got I4
		//IL_60c4: Expected Obj, but got I
		//IL_60cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_60d2: Expected Obj, but got Unknown
		//IL_60ec: Expected Obj, but got I4
		//IL_5de5: Expected Obj, but got I4
		//IL_87b9: Expected Obj, but got Ref
		//IL_87e2: Expected VT, but got Ref
		//IL_87e2: Expected Obj, but got I4
		//IL_87e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_87e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_87ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_87f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_87f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_87fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_87ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_8814: Expected VT, but got Ref
		//IL_882c: Expected F8, but got Obj
		//IL_882c: Unknown result type (might be due to invalid IL or missing references)
		//IL_8830: Unknown result type (might be due to invalid IL or missing references)
		//IL_6228: Expected Obj, but got I4
		//IL_8770: Expected Obj, but got I
		//IL_5d8e: Expected Obj, but got I4
		//IL_886c: Expected Obj, but got I
		//IL_8874: Expected Obj, but got I4
		//IL_9722: Unknown result type (might be due to invalid IL or missing references)
		//IL_9727: Expected I4, but got Unknown
		//IL_9735: Expected Obj, but got Ref
		//IL_9763: Expected VT, but got Ref
		//IL_9773: Expected Obj, but got I
		//IL_979d: Expected Obj, but got I4
		//IL_5e0d: Expected Obj, but got I
		//IL_8755: Expected Obj, but got I
		//IL_62b6: Expected Obj, but got I4
		//IL_5e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e4e: Expected Obj, but got Unknown
		//IL_5e57: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e5c: Expected Obj, but got Unknown
		//IL_5e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e60: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e6c: Expected Obj, but got Unknown
		//IL_5e7d: Expected VT, but got Ref
		//IL_5eab: Unknown result type (might be due to invalid IL or missing references)
		//IL_5eaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_5eb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_5db6: Expected Obj, but got I
		//IL_88a4: Expected Obj, but got I
		//IL_88ac: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		Gather();
		ShowKeys();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		StringBuilder stringBuilder = (StringBuilder)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		nint num = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v8+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v7 (Il2CppClass<System.Text.StringBuilder>)+E4]");
		bool flag3 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
		UnityEngine.Object obj8 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v7 (Il2CppClass<System.Text.StringBuilder>)+E4]");
		bool flag4 = (byte)(~(nuint)0u) != 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaFriends.State now = GillaFriends.Now;
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v8+E4]");
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
		object obj12 = 0;
		bool isPlaying = Application.isPlaying;
		bool flag6 = !isPlaying;
		bool flag7 = force;
		if (flag6)
		{
			goto IL_0410;
		}
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v743+E4]");
		bool flag8 = (nint)0 == 0;
		object obj14 = !flag8;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v743+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v548+28]");
		bool flag9;
		Enumerator<, > val;
		Enumerator<, > val2;
		UnityEngine.Object obj20;
		bool flag14;
		GillaFriends.State state;
		bool flag13;
		bool flag15;
		UnityEngine.Object obj21;
		bool flag12;
		int num2;
		Enumerator<, > val3;
		nint num3;
		UnityEngine.Object obj22;
		if ((nint)0 != 0)
		{
			flag7 = force;
			flag9 = true;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj17 = 0;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v744+E4]");
			bool flag10 = (nint)0 == 0;
			object obj19 = !flag10;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
			if ((UnityEngine.Object)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
				bool flag11 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
				obj20 = (UnityEngine.Object)0;
				val = (Enumerator<, >)0;
				num2 = 0;
				val2 = (Enumerator<, >)0;
				flag12 = false;
				flag13 = false;
				flag14 = false;
				val3 = (Enumerator<, >)0;
				num3 = unchecked((nint)null);
				obj21 = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
				obj22 = (UnityEngine.Object)0;
				state = now;
				flag15 = force;
				if (!flag11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj23 = 0;
					object obj24 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X0_v749+E4]");
					bool flag16 = (nint)0 == 0;
					object obj25 = !flag16;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X9_v2 (UnityEngine.Object)+B0]");
					bool flag17 = (UnityEngine.Object)0 != null;
					bool flag18 = !flag17;
					num3 = unchecked((nint)null);
					flag7 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
					obj22 = (UnityEngine.Object)0;
					if (flag18)
					{
						goto IL_0410;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
					obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X9_v2 (UnityEngine.Object)+B0]");
					bool flag19 = (nint)0 == 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
					obj20 = (UnityEngine.Object)0;
					val = (Enumerator<, >)0;
					num2 = 0;
					val2 = (Enumerator<, >)0;
					flag12 = false;
					flag13 = false;
					flag14 = false;
					val3 = (Enumerator<, >)0;
					num3 = unchecked((nint)null);
					obj21 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
					obj22 = (UnityEngine.Object)0;
					state = now;
					flag15 = force;
					if (!flag19)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X9_v2 (UnityEngine.Object)+B0]");
						flag9 = ((NetworkRunner)0).IsRunning;
						num3 = unchecked((nint)null);
						flag7 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
						obj22 = (UnityEngine.Object)0;
						goto IL_765c;
					}
				}
				goto IL_73cb;
			}
			num3 = unchecked((nint)null);
			flag7 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
			obj22 = (UnityEngine.Object)0;
			flag9 = false;
		}
		goto IL_765c;
		IL_748f:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_749d;
		IL_8069:
		ScreenFont font;
		int num4;
		int num5;
		ShiftAuth.Style style;
		Line(font, num4, num5, (string)(object)stringBuilder, style, centred: false);
		bool flag20 = false;
		bool flag21 = (byte)(int)stringBuilder != 0;
		TextureFormat textureFormat = (TextureFormat)num5;
		ScreenFont screenFont;
		string text2 = (string)(object)screenFont;
		string text3;
		string[] array = (string[])(object)text3;
		num3 = num4;
		goto IL_4e4e;
		IL_7392:
		string text5 = default;
		string text4 = text5;
		goto IL_8e8a;
		IL_4e4e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array2 = default;
		bool flag22 = array2 == null;
		Enumerator<, > val4 = val2;
		bool offline;
		flag12 = offline;
		int num7;
		int num6 = num7;
		int num8;
		string[] array3 = (string[])num8;
		bool flag23 = (byte)this.page != 0;
		string text6 = (string)(-1);
		object obj27;
		Enumerator<, > val5 = (Enumerator<, >)obj27;
		string text8;
		string text7 = text8;
		obj21 = (UnityEngine.Object)1;
		GillaLeaderboard gillaLeaderboard;
		double num16;
		GillaFriends.State state2;
		int num19;
		ShiftAuth.Style style2;
		float num27;
		int num35;
		bool flag43;
		TextureFormat textureFormat2;
		nint num25;
		UnityEngine.Object obj56;
		double num14;
		if (!flag22)
		{
			bool flag24 = array2.Length == 0;
			val4 = val2;
			flag12 = offline;
			num6 = num7;
			array3 = (string[])num8;
			flag23 = (byte)this.page != 0;
			text6 = (string)(-1);
			val5 = (Enumerator<, >)obj27;
			text7 = text8;
			obj21 = (UnityEngine.Object)1;
			if (flag24)
			{
				goto IL_7481;
			}
			object obj28 = array2 + 32;
			obj28 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			string text9 = gillaLeaderboard.Fits(num8, array2);
			bool flag25 = text9 == null;
			val4 = val2;
			flag12 = offline;
			num6 = num7;
			array3 = (string[])num8;
			flag23 = (byte)this.page != 0;
			text6 = (string)(-1);
			val5 = (Enumerator<, >)obj27;
			text7 = text8;
			num3 = (nint)array2;
			obj21 = (UnityEngine.Object)num8;
			if (!flag25)
			{
				bool flag26 = text9._stringLength < 1;
				string text10 = (string)flag21;
				int num9 = (int)textureFormat;
				int num10 = (int)array2;
				ScreenFont screenFont2 = (ScreenFont)num8;
				if (!flag26)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
					object obj29 = 0;
					object obj30 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4546 @ X0_v422+E4]");
					bool flag27 = (nint)0 == 0;
					object obj31 = !flag27;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int num11 = Measure((ScreenFont)(object)text8, text9, 1);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
					text2 = (string)0;
					nint num12 = (nint)text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4605 @ X0_v426 (Il2CppClass<System.String>)+E4]");
					bool flag28 = (nint)0 == 0;
					object obj32 = !flag28;
					nint num13 = num12;
					if (obj32 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						num13 = (nint)text2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4620 @ X0_v427 (Il2CppClass<System.String>)+A0]");
					object obj33 = 0;
					object obj34 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val2, 16));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num10 = 308 - num11;
					Enumerator<, > val6 = default;
					Line((ScreenFont)(object)text8, num10, 18, text9, (ShiftAuth.Style)(&val6), centred: false);
					val6 = val2;
					flag20 = false;
					style = (ShiftAuth.Style)(&val6);
					text10 = text9;
					num9 = 18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4622 @ X8_v353+10]");
					num14 = 0.0;
					val3 = val2;
					screenFont2 = (ScreenFont)(object)text8;
					obj22 = (UnityEngine.Object)num11;
					text = text8;
					gillaLeaderboard = this;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
				object obj35 = 0;
				object obj36 = obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4581 @ X0_v185+E4]");
				bool flag29 = (nint)0 == 0;
				object obj37 = !flag29;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaBoardLook.Rule(gillaLeaderboard.px, 320, 240, 8, 311, 30);
				List<Entry> list = gillaLeaderboard.entries;
				bool flag30 = gillaLeaderboard.entries == null;
				val4 = val2;
				flag20 = false;
				style = (ShiftAuth.Style)30;
				flag21 = true;
				textureFormat = (TextureFormat)8;
				flag12 = offline;
				num6 = num7;
				array3 = (string[])num8;
				flag23 = (byte)this.page != 0;
				text6 = (string)(-1);
				val5 = (Enumerator<, >)obj27;
				text7 = text8;
				num3 = 240;
				obj21 = (UnityEngine.Object)320;
				stringBuilder = (StringBuilder)(object)text9;
				flag15 = (byte)num7 != 0;
				if (!flag30)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X8_v127 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
					object obj38 = -10;
					bool flag31 = (nint)obj38 < 0;
					bool flag32 = obj38 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X8_v127 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
					object obj39 = (nint)0 ^ (nint)0xA;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X8_v127 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
					object obj40 = 0 ^ obj38;
					object obj41 = obj39 & obj40;
					bool flag33 = (nint)obj41 < 0;
					bool flag34 = flag31 == flag33;
					object obj42 = !flag32;
					object obj43 = flag34 & obj42;
					double num15 = (((int)(~obj43) != 0) ? 304.0 : 296.0);
					num16 = num15 + 8.0;
					state2 = (GillaFriends.State)(num15 | 4);
					flag20 = false;
					style = (ShiftAuth.Style)30;
					flag21 = true;
					textureFormat = (TextureFormat)8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X8_v127 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
					flag3 = false;
					int num17 = 0;
					num6 = num7;
					int num18 = 42;
					val5 = (Enumerator<, >)obj27;
					num3 = 240;
					obj21 = (UnityEngine.Object)320;
					text = (string)296;
					string text11 = text9;
					Enumerator<, > val10 = default;
					object obj76 = default;
					Color32 colour = default;
					object obj95 = default;
					Enumerator<, > val11 = default;
					object obj111 = default;
					float num42 = default;
					string s2 = default;
					Enumerator<, > val12 = default;
					Enumerator<, > val13 = default;
					while (true)
					{
						List<Entry> list2 = gillaLeaderboard.entries;
						bool flag35 = gillaLeaderboard.entries == null;
						obj20 = (UnityEngine.Object)num16;
						val4 = val2;
						flag12 = offline;
						text2 = (string)num17;
						array3 = (string[])num18;
						flag23 = (byte)this.page != 0;
						text6 = (string)(-1);
						text7 = text8;
						state = state2;
						stringBuilder = (StringBuilder)(object)text11;
						flag15 = (byte)num7 != 0;
						if (flag35)
						{
							break;
						}
						text11 = (string)gillaLeaderboard.top;
						num19 = num18 - 4;
						int num20 = num17 + gillaLeaderboard.top;
						int num21 = num20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ X0_v189 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
						GillaLeaderboard gillaLeaderboard2;
						if ((nint)num21 < (nint)0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ X19_v27 (GillaLeaderboard)+108]");
							if ((nint)0 != 0)
							{
								Entry entry = gillaLeaderboard.entries.get_Item(num20);
								Enumerator<, > val7 = val5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ X19_v27 (GillaLeaderboard)+108]");
								bool flag36 = (string)val7 == (string)0;
								bool flag37 = !flag36;
								num3 = unchecked((nint)null);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ X19_v27 (GillaLeaderboard)+108]");
								obj21 = (UnityEngine.Object)0;
								if (!flag37)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
									object obj44 = 0;
									object obj45 = obj44;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4811 @ X0_v417+E4]");
									bool flag38 = (nint)0 == 0;
									object obj46 = !flag38;
									if (obj46 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj45 = obj44;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4811 @ X0_v417+A0]");
									object obj47 = 0;
									int y = num19;
									double num22 = num15;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4813 @ X8_v348+20]");
									Fill(8, y, (int)num22, 16, (Color32)0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4813 @ X8_v348+20]");
									style = (ShiftAuth.Style)0;
									flag21 = true;
									textureFormat = (TextureFormat)num15;
									num3 = num19;
									obj21 = (UnityEngine.Object)8;
									gillaLeaderboard2 = this;
									goto IL_5551;
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
						object obj48 = 0;
						object obj49 = obj48;
						int num23 = num20 & 1;
						bool flag39 = num23 == 0;
						object obj50 = !flag39;
						object obj53;
						if (obj50 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4756 @ X0_v407+E4]");
							bool flag40 = (nint)0 == 0;
							object obj51 = !flag40;
							if (obj51 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
								object obj52 = 0;
								obj49 = obj52;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4756 @ X0_v407+A0]");
							obj53 = (nint)0 + (nint)28;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4756 @ X0_v407+E4]");
							bool flag41 = (nint)0 == 0;
							object obj54 = !flag41;
							if (obj54 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
								object obj55 = 0;
								obj49 = obj55;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4756 @ X0_v407+A0]");
							obj53 = (nint)0 + (nint)24;
						}
						Fill(8, num19, (int)num15, 16, (Color32)obj53);
						int num24 = num20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ X0_v189 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
						bool flag42 = (nint)num24 >= (nint)0;
						style = (ShiftAuth.Style)obj53;
						flag21 = true;
						textureFormat = (TextureFormat)num15;
						num3 = num19;
						obj21 = (UnityEngine.Object)8;
						gillaLeaderboard2 = this;
						style2 = (ShiftAuth.Style)obj53;
						flag43 = true;
						textureFormat2 = (TextureFormat)num15;
						num25 = num19;
						obj56 = (UnityEngine.Object)8;
						gillaLeaderboard = this;
						if (!flag42)
						{
							goto IL_5551;
						}
						goto IL_62db;
						IL_843c:
						float num26;
						object obj57 = num26 & 1;
						bool flag44 = obj57 == null;
						object obj58 = !flag44;
						double num28;
						float num29;
						num27 = ((obj58 != null) ? ((float)num28) : num29);
						Enumerator<, > val8 = (Enumerator<, >)num28;
						goto IL_95d9;
						IL_592d:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
						object obj59 = 0;
						text = (string)obj59;
						num19 = ((this.page != 0) ? ((int)this.page) : ((int)obj59));
						bool flag45 = num19 == 0;
						obj20 = (UnityEngine.Object)num16;
						Enumerator<, > val9 = val10;
						val = val5;
						val4 = val2;
						flag12 = offline;
						text2 = (string)num17;
						array3 = (string[])num18;
						array = (string[])num19;
						flag23 = (byte)this.page != 0;
						text6 = (string)(-1);
						text7 = text8;
						num14 = (double)val8;
						obj22 = (UnityEngine.Object)109891584;
						state = state2;
						stringBuilder = (StringBuilder)(object)text11;
						flag15 = (byte)num7 != 0;
						if (flag45)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X26_v9 (System.Int32)+10]");
						int num31;
						if ((nint)0 >= (nint)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
							object obj60 = 0;
							object obj61 = obj60;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5424 @ X0_v377+E4]");
							bool flag46 = (nint)0 == 0;
							object obj62 = !flag46;
							if (obj62 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							int num30 = Measure((ScreenFont)(object)text8, (string)num19, 1);
							num31 = num30;
							num3 = 1;
							obj21 = (UnityEngine.Object)num19;
						}
						else
						{
							num31 = 0;
						}
						num6 = state2 - num31;
						object obj63;
						if (gillaLeaderboard2.page != 0)
						{
							obj63 = num6 - 12;
							string text12 = (string)flag21;
							int num32 = (int)textureFormat;
							num20 = 12;
							int num33 = (int)num3;
							string text13 = (string)(object)obj21;
						}
						else
						{
							object obj64 = num17 + text11;
							int num34 = obj64 + 1;
							string s = num35.ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
							object obj65 = 0;
							object obj66 = obj65;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5749 @ X8_v265+E4]");
							bool flag47 = (nint)0 == 0;
							object obj67 = !flag47;
							if (obj67 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							int num36 = Measure((ScreenFont)(object)text8, s, 1);
							string line = num35.ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
							object obj68 = 0;
							object obj69 = obj68;
							GillaLeaderboard gillaLeaderboard3;
							if (num20 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6001 @ X0_v369+E4]");
								bool flag48 = (nint)0 == 0;
								object obj70 = !flag48;
								if (obj70 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
									object obj71 = 0;
									obj69 = obj71;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6001 @ X0_v369+A0]");
								object obj72 = (nint)0 + (nint)16;
								gillaLeaderboard3 = this;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6001 @ X0_v369+E4]");
								bool flag49 = (nint)0 == 0;
								object obj73 = !flag49;
								if (obj73 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
									object obj74 = 0;
									obj69 = obj74;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6001 @ X0_v369+A0]");
								object obj72 = 0;
								gillaLeaderboard3 = this;
							}
							int x = 22 - num36;
							object obj75 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val2, 16));
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							gillaLeaderboard3.Line((ScreenFont)(object)text8, x, num18, line, (ShiftAuth.Style)(&obj76), centred: false);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
							object obj77 = 0;
							object obj78 = obj77;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6138 @ X0_v339+E4]");
							bool flag50 = (nint)0 == 0;
							object obj79 = !flag50;
							if (obj79 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj78 = obj77;
							}
							int y2 = num18 - 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
							object obj80 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6138 @ X0_v339+A0]");
							object obj81 = 0;
							GillaLeaderboard gillaLeaderboard4 = gillaLeaderboard3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6144 @ X8_v273+28]");
							gillaLeaderboard4.Fill(26, y2, 12, 12, (Color32)0);
							int y3 = num18 - 1;
							gillaLeaderboard3.Fill(27, y3, 10, 10, colour);
							int num37 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val, 44));
							string text14 = ((int*)num37)->ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1800]");
							object obj82 = 0;
							string text15 = (string)obj82 + text14;
							object obj83 = obj80;
							object obj84 = num6 - 8;
							object obj85 = obj84 - 214;
							bool flag51 = (nint)obj85 < 0;
							object obj86 = obj84 ^ 0xD6;
							object obj87 = obj84 ^ obj85;
							object obj88 = obj86 & obj87;
							bool flag52 = (nint)obj88 < 0;
							bool flag53 = flag51 == flag52;
							object obj89 = !flag53;
							object obj90 = (((int)(~obj89) != 0) ? ((object)214) : obj84);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6218 @ X0_v346+E4]");
							bool flag54 = (nint)0 == 0;
							object obj91 = !flag54;
							if (obj91 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							int num38 = Measure(gillaLeaderboard3.text, text15, 1);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
							object obj92 = 0;
							object obj93 = obj92;
							object obj94 = obj95 & 1;
							bool flag55 = obj94 == null;
							object obj96 = !flag55;
							object obj99;
							if (obj96 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6259 @ X0_v360+E4]");
								bool flag56 = (nint)0 == 0;
								object obj97 = !flag56;
								if (obj97 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
									object obj98 = 0;
									obj93 = obj98;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6259 @ X0_v360+A0]");
								obj99 = (nint)0 + (nint)8;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6259 @ X0_v360+E4]");
								bool flag57 = (nint)0 == 0;
								object obj100 = !flag57;
								if (obj100 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
									object obj101 = 0;
									obj93 = obj101;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6259 @ X0_v360+A0]");
								obj99 = (nint)0 + (nint)16;
							}
							int x2 = obj90 - num38;
							object obj102 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val2, 16));
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Line(gillaLeaderboard3.text, x2, num18, text15, (ShiftAuth.Style)(&val11), centred: false);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
							object obj103 = 0;
							object obj104 = obj103;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6280 @ X0_v355+E4]");
							bool flag58 = (nint)0 == 0;
							object obj105 = !flag58;
							if (obj105 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							int num39 = Measure(this.text, text15, 1);
							object obj106 = obj90 - num39;
							obj63 = obj106 - 6;
							val11 = val2;
							obj76 = val2;
							flag20 = false;
							style = (ShiftAuth.Style)(&val11);
							string text12 = text15;
							int num32 = num18;
							num35 = num34;
							flag3 = true;
							num20 = 44;
							val8 = (Enumerator<, >)obj99;
							val3 = val2;
							int num33 = 1;
							string text13 = text15;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
						object obj107 = 0;
						object obj108 = obj95 & 1;
						bool flag59 = obj108 == null;
						object obj109 = !flag59;
						object obj117;
						if (obj109 == null)
						{
							object obj110 = obj111 & 1;
							bool flag60 = obj110 == null;
							object obj112 = !flag60;
							if (obj112 == null)
							{
								object obj113 = obj107;
								object obj114 = val10 & 1;
								bool flag61 = obj114 == null;
								object obj115 = !flag61;
								if (obj115 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5904 @ X0_v320+E4]");
									bool flag62 = (nint)0 == 0;
									object obj116 = !flag62;
									if (obj116 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj113 = obj107;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5904 @ X0_v320+A0]");
									obj117 = (nint)0 + (nint)8;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5904 @ X0_v320+E4]");
									bool flag63 = (nint)0 == 0;
									object obj118 = !flag63;
									if (obj118 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj113 = obj107;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5904 @ X0_v320+A0]");
									obj117 = 0;
								}
								goto IL_97ab;
							}
						}
						object obj119 = obj107;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5851 @ X0_v316+E4]");
						bool flag64 = (nint)0 == 0;
						object obj120 = !flag64;
						if (obj120 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj119 = obj107;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5851 @ X0_v316+A0]");
						obj117 = (nint)0 + (nint)16;
						goto IL_97ab;
						IL_5551:
						bool flag65 = gillaLeaderboard2.entries == null;
						obj20 = (UnityEngine.Object)num16;
						val4 = val2;
						flag12 = offline;
						text2 = (string)num17;
						array3 = (string[])num18;
						array = (string[])num19;
						flag23 = (byte)this.page != 0;
						text6 = (string)(-1);
						text7 = text8;
						state = state2;
						stringBuilder = (StringBuilder)(object)text11;
						flag15 = (byte)num7 != 0;
						if (flag65)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D17F0]");
						object obj121 = 0;
						num3 = (nint)obj121;
						Entry entry2 = gillaLeaderboard2.entries.get_Item(num20);
						float num40 = gillaLeaderboard2.Held(num17);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
						object obj122 = 0;
						bool flag66 = !(num40 > 0f);
						val8 = (Enumerator<, >)this.page;
						val3 = (Enumerator<, >)num40;
						obj21 = (UnityEngine.Object)num17;
						if (flag66)
						{
							goto IL_592d;
						}
						object obj123 = obj122;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5090 @ X0_v383+E4]");
						bool flag67 = (nint)0 == 0;
						object obj124 = !flag67;
						if (obj124 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num41 = num40 * (float)num15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
						if (num41 < 0f)
						{
							if ((double)num41 == -0.5)
							{
								num28 = (double)num42 + -1.0;
								num29 = num42;
								num26 = num42;
								goto IL_843c;
							}
							num29 = num41 + -0.5f;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
							val8 = (Enumerator<, >)this.page;
						}
						else
						{
							if ((double)num41 == 0.5)
							{
								num28 = (double)num42 + 1.0;
								num29 = num42;
								num26 = num42;
								goto IL_843c;
							}
							num29 = num41 + 0.5f;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
							val8 = (Enumerator<, >)this.page;
						}
						goto IL_95d9;
						IL_97ab:
						int width = obj63 - num20;
						text11 = (string)(object)this.text;
						string text16 = Cut(s2, width);
						object obj125 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val2, 16));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Line(this.text, num20, num18, text16, (ShiftAuth.Style)(&val12), centred: false);
						bool flag68 = num31 < 1;
						val12 = (Enumerator<, >)1;
						val9 = val10;
						val = val5;
						flag20 = false;
						val2 = (Enumerator<, >)1;
						style2 = (ShiftAuth.Style)(&val12);
						flag43 = (byte)(int)text16 != 0;
						textureFormat2 = (TextureFormat)num18;
						num14 = (double)obj117;
						val3 = (Enumerator<, >)1;
						num25 = num20;
						obj56 = (UnityEngine.Object)(object)this.text;
						obj22 = (UnityEngine.Object)(object)text16;
						text = (string)1;
						gillaLeaderboard = this;
						if (flag68)
						{
							goto IL_62db;
						}
						Page page = (Page)(val10 & 1);
						object obj126 = val10 & 1;
						bool flag69 = obj126 == null;
						object obj127 = !flag69;
						object obj128;
						Page page2;
						Page page3;
						object obj134;
						object obj132;
						object obj131;
						if (obj127 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
							obj128 = 0;
							object obj129 = obj95 & 1;
							bool flag70 = obj129 == null;
							object obj130 = !flag70;
							if (obj130 == null)
							{
								obj131 = obj128;
								page2 = this.page;
								if (this.page != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6168 @ X0_v312+E4]");
									bool flag71 = (nint)0 == 0;
									page3 = this.page;
									obj132 = obj131;
									if (!flag71)
									{
										goto IL_6162;
									}
									goto IL_61df;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6168 @ X0_v312+E4]");
								bool flag72 = (nint)0 == 0;
								object obj133 = !flag72;
								if (obj133 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj131 = obj128;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6168 @ X0_v312+A0]");
								obj134 = (nint)0 + (nint)8;
								text = (string)page2;
							}
							else
							{
								object obj135 = obj128;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6163 @ X0_v308+E4]");
								bool flag73 = (nint)0 == 0;
								object obj136 = !flag73;
								if (obj136 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj135 = obj128;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6163 @ X0_v308+A0]");
								obj134 = (nint)0 + (nint)16;
								text = (string)page;
							}
							goto IL_87ab;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
						obj128 = 0;
						obj131 = obj128;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6168 @ X0_v312+E4]");
						bool flag74 = (nint)0 == 0;
						object obj137 = !flag74;
						page2 = page;
						page3 = page;
						obj132 = obj131;
						if (obj137 != null)
						{
							goto IL_6162;
						}
						goto IL_61df;
						IL_87ab:
						object obj138 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val2, 16));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Line((ScreenFont)(object)text8, num6, num18, (string)num19, (ShiftAuth.Style)(&val13), centred: false);
						val13 = val2;
						val12 = (Enumerator<, >)1;
						val9 = val10;
						val = val5;
						flag20 = false;
						style2 = (ShiftAuth.Style)(&val13);
						flag43 = (byte)num19 != 0;
						textureFormat2 = (TextureFormat)num18;
						num14 = (double)obj134;
						val3 = val2;
						num25 = num6;
						obj56 = (UnityEngine.Object)(object)text8;
						obj22 = (UnityEngine.Object)(object)text16;
						gillaLeaderboard = this;
						goto IL_62db;
						IL_8484:
						Enumerator<, > val14;
						object obj139 = val14 & 1;
						bool flag75 = obj139 == null;
						object obj140 = !flag75;
						double num44;
						Enumerator<, > val15;
						float num43 = ((obj140 != null) ? ((float)num44) : ((float)val15));
						val8 = (Enumerator<, >)num44;
						val3 = val15;
						goto IL_84cf;
						IL_84cf:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
						object obj141 = 0;
						object obj142 = obj141;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6025 @ X0_v393+E4]");
						bool flag76 = (nint)0 == 0;
						object obj143 = !flag76;
						if (obj143 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj142 = obj141;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6025 @ X0_v393+A0]");
						object obj144 = 0;
						int num45 = (int)(num16 - (double)num27);
						GillaLeaderboard gillaLeaderboard5 = gillaLeaderboard2;
						int y4 = num19;
						float num46 = num43;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6027 @ X9_v84+20]");
						gillaLeaderboard5.Fill(num45, y4, (int)num46, 16, (Color32)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6027 @ X9_v84+20]");
						style = (ShiftAuth.Style)0;
						flag21 = true;
						textureFormat = (TextureFormat)num43;
						num3 = num19;
						obj21 = (UnityEngine.Object)num45;
						goto IL_592d;
						IL_95d9:
						object obj145 = obj122;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5673 @ X0_v388+E4]");
						bool flag77 = (nint)0 == 0;
						object obj146 = !flag77;
						if (obj146 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
						if (num41 < 0f)
						{
							if ((double)num41 == -0.5)
							{
								num44 = (double)val5 + -1.0;
								val15 = val5;
								val14 = val5;
								goto IL_8484;
							}
							float num47 = num41 + -0.5f;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
							num43 = num41;
							val3 = (Enumerator<, >)num47;
						}
						else
						{
							if ((double)num41 == 0.5)
							{
								num44 = (double)val5 + 1.0;
								val15 = val5;
								val14 = val5;
								goto IL_8484;
							}
							float num48 = num41 + 0.5f;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
							num43 = num41;
							val3 = (Enumerator<, >)num48;
						}
						goto IL_84cf;
						IL_62db:
						num17++;
						array3 = (string[])(num18 + 18);
						bool flag78 = num17 != 10;
						style = style2;
						flag21 = flag43;
						textureFormat = textureFormat2;
						num18 = (int)array3;
						array = (string[])num19;
						num3 = num25;
						obj21 = obj56;
						if (flag78)
						{
							continue;
						}
						goto IL_634f;
						IL_61df:
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj131 = obj128;
						page2 = page3;
						goto IL_6162;
						IL_6162:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6168 @ X0_v312+A0]");
						obj134 = 0;
						text = (string)page2;
						goto IL_87ab;
					}
				}
			}
		}
		goto IL_73cb;
		IL_942d:
		bool flag79 = !flag14;
		flag20 = false;
		style = (ShiftAuth.Style)(&val4);
		array = (string[])(object)text3;
		object obj147;
		num14 = (double)obj147;
		val3 = val2;
		int num49;
		num3 = num49;
		gillaLeaderboard = this;
		ScreenFont screenFont3;
		stringBuilder = (StringBuilder)(object)screenFont3;
		if (flag79)
		{
			goto IL_4e4e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj148 = 0;
		object obj149 = obj148;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4446 @ X0_v135+E4]");
		bool flag80 = (nint)0 == 0;
		object obj150 = !flag80;
		if (obj150 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj151;
		if (obj20 != null)
		{
			bool flag81 = (object)obj20 == null;
			val4 = val2;
			flag20 = false;
			style = (ShiftAuth.Style)(&val4);
			flag12 = offline;
			num6 = num7;
			array3 = (string[])num8;
			array = (string[])(object)text3;
			flag23 = (byte)this.page != 0;
			text6 = (string)(-1);
			val5 = (Enumerator<, >)obj27;
			text7 = text8;
			num14 = (double)obj147;
			val3 = val2;
			num3 = unchecked((nint)null);
			obj21 = null;
			stringBuilder = (StringBuilder)(object)screenFont3;
			if (flag81)
			{
				goto IL_73cb;
			}
			obj151 = obj20 + 120;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			obj151 = 0;
		}
		text = (string)(object)rows;
		bool flag82 = rows == null;
		val4 = val2;
		flag20 = false;
		style = (ShiftAuth.Style)(&val4);
		flag12 = offline;
		num6 = num7;
		array3 = (string[])num8;
		array = (string[])(object)text3;
		flag23 = (byte)this.page != 0;
		text6 = (string)(-1);
		val5 = (Enumerator<, >)obj27;
		text7 = text8;
		num14 = (double)obj147;
		val3 = val2;
		num3 = unchecked((nint)null);
		obj21 = null;
		stringBuilder = (StringBuilder)(object)screenFont3;
		UnityEngine.Object obj169 = default;
		if (!flag82)
		{
			text2 = (string)obj151;
			string text17 = num35.ToString();
			List<Row> list3 = rows;
			bool flag83 = rows == null;
			val4 = val2;
			flag20 = false;
			style = (ShiftAuth.Style)(&val4);
			flag12 = offline;
			num6 = num7;
			array3 = (string[])num8;
			array = (string[])(object)text3;
			flag23 = (byte)this.page != 0;
			text6 = (string)(-1);
			val5 = (Enumerator<, >)obj27;
			text7 = text8;
			num14 = (double)obj147;
			val3 = val2;
			num3 = unchecked((nint)null);
			obj21 = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X9_v33 (System.String)+18]");
			text = (string)0;
			stringBuilder = (StringBuilder)(object)screenFont3;
			if (!flag83)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C83D8]");
				flag3 = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1146 @ X8_v93 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
				bool flag84;
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1878]");
					flag84 = false;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C83D8]");
					flag84 = false;
				}
				string text18 = text17 + (string)((bool*)(flag84 ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
				object obj152 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1808]");
				object obj153 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60D8]");
				text = (string)0;
				string text19 = (string)obj153 + text2 + text + text18;
				StringBuilder stringBuilder2 = default;
				bool flag85 = stringBuilder2 == null;
				val4 = val2;
				flag20 = false;
				style = (ShiftAuth.Style)(&val4);
				flag21 = false;
				textureFormat = (TextureFormat)text18;
				flag12 = offline;
				num6 = num7;
				array3 = (string[])num8;
				array = (string[])(object)text3;
				flag23 = (byte)this.page != 0;
				text6 = (string)(-1);
				val5 = (Enumerator<, >)obj27;
				text7 = text8;
				num14 = (double)obj147;
				val3 = val2;
				num3 = (nint)text;
				obj21 = (UnityEngine.Object)(object)text2;
				stringBuilder = stringBuilder2;
				if (!flag85)
				{
					bool flag86 = stringBuilder2.m_ChunkPrevious == null;
					val4 = val2;
					flag20 = false;
					style = (ShiftAuth.Style)(&val4);
					flag21 = false;
					textureFormat = (TextureFormat)text18;
					flag12 = offline;
					num6 = num7;
					array3 = (string[])num8;
					array = (string[])(object)text3;
					flag23 = (byte)this.page != 0;
					text6 = (string)(-1);
					val5 = (Enumerator<, >)obj27;
					text7 = text8;
					num14 = (double)obj147;
					val3 = val2;
					num3 = (nint)text;
					obj21 = (UnityEngine.Object)(object)text2;
					stringBuilder = stringBuilder2;
					if (!flag86)
					{
						obj22 = (UnityEngine.Object)(stringBuilder2 + 32);
						obj22 = (UnityEngine.Object)(object)text19;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA210]");
						double num15 = 0.0;
						string text20 = (string)obj153 + text2 + (string)((double*)(nint)num15)->m_value + text18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4677 @ X22_v18 (UnityEngine.Object)-8]");
						object obj154 = 0 & 0xFFFFFFFEL;
						bool flag87 = obj154 == null;
						val4 = val2;
						flag20 = false;
						style = (ShiftAuth.Style)(&val4);
						flag21 = false;
						textureFormat = (TextureFormat)text18;
						flag12 = offline;
						num6 = num7;
						array3 = (string[])num8;
						array = (string[])(object)text3;
						flag23 = (byte)this.page != 0;
						text6 = (string)(-1);
						val5 = (Enumerator<, >)obj27;
						text7 = text8;
						num14 = (double)obj147;
						val3 = val2;
						num3 = (nint)((double*)(nint)num15)->m_value;
						obj21 = (UnityEngine.Object)(object)text2;
						stringBuilder = stringBuilder2;
						if (!flag87)
						{
							obj22 = (UnityEngine.Object)(stringBuilder2 + 40);
							obj22 = (UnityEngine.Object)(object)text20;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							string text21 = text2 + (string)((double*)(nint)num15)->m_value + text18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4677 @ X22_v18 (UnityEngine.Object)-10]");
							bool flag88 = (nint)0 < (nint)2;
							object obj155 = !flag88;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4677 @ X22_v18 (UnityEngine.Object)-10]");
							object obj156 = -2;
							bool flag89 = obj156 == null;
							object obj157 = ~obj155;
							object obj158 = obj157 | flag89;
							val4 = val2;
							flag20 = false;
							style = (ShiftAuth.Style)(&val4);
							flag21 = false;
							textureFormat = (TextureFormat)0;
							flag12 = offline;
							num6 = num7;
							array3 = (string[])num8;
							array = (string[])(object)text3;
							flag23 = (byte)this.page != 0;
							text6 = (string)(-1);
							val5 = (Enumerator<, >)obj27;
							text7 = text8;
							num14 = (double)obj147;
							val3 = val2;
							num3 = (nint)text18;
							obj21 = (UnityEngine.Object)((double*)(nint)num15)->m_value;
							stringBuilder = stringBuilder2;
							if (obj158 == null)
							{
								object obj159 = stringBuilder2 + 48;
								obj159 = text21;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								string text22 = (string)obj153 + text2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ X20_v39-18]");
								object obj160 = 0 & 0xFFFFFFFCL;
								bool flag90 = obj160 == null;
								val4 = val2;
								flag20 = false;
								style = (ShiftAuth.Style)(&val4);
								flag21 = false;
								textureFormat = (TextureFormat)0;
								flag12 = offline;
								num6 = num7;
								array3 = (string[])num8;
								array = (string[])(object)text3;
								flag23 = (byte)this.page != 0;
								text6 = (string)(-1);
								val5 = (Enumerator<, >)obj27;
								text7 = text8;
								num14 = (double)obj147;
								val3 = val2;
								num3 = unchecked((nint)null);
								obj21 = (UnityEngine.Object)(object)text2;
								stringBuilder = stringBuilder2;
								if (!flag90)
								{
									object obj161 = stringBuilder2 + 56;
									obj161 = text22;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									string text23 = Fits(num8, (string[])(object)stringBuilder2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
									object obj162 = 0;
									screenFont = this.text;
									object obj163 = obj162;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1148 @ X8_v106+E4]");
									text = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1148 @ X8_v106+E4]");
									bool flag91 = (nint)0 == 0;
									object obj164 = !flag91;
									if (obj164 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									int num50 = Measure(screenFont, text23, 1);
									bool flag92 = text3 == null;
									val4 = val2;
									flag20 = false;
									style = (ShiftAuth.Style)(&val4);
									flag21 = false;
									textureFormat = (TextureFormat)0;
									flag12 = offline;
									text2 = (string)(object)screenFont;
									num6 = num7;
									array3 = (string[])num8;
									array = (string[])(object)text3;
									flag23 = (byte)this.page != 0;
									text6 = (string)(-1);
									val5 = (Enumerator<, >)obj27;
									text7 = text8;
									num14 = (double)obj147;
									val3 = val2;
									num3 = 1;
									obj21 = (UnityEngine.Object)(object)text23;
									stringBuilder = (StringBuilder)(object)text23;
									if (flag92)
									{
										goto IL_73cb;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
									num15 = 0.0;
									int num51 = 308 - num50;
									double value = ((double*)(nint)num15)->m_value;
									bool flag93 = text3._stringLength < 0;
									bool flag94 = text3._stringLength == 0;
									int num52 = text3._stringLength ^ text3._stringLength;
									int num53 = text3._stringLength & num52;
									bool flag95 = num53 < 0;
									bool flag96 = flag93 == flag95;
									object obj42 = !flag94;
									object obj165 = flag96 & obj42;
									obj22 = (((int)(~obj165) != 0) ? ((UnityEngine.Object)14) : ((UnityEngine.Object)8));
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5656 @ X8_v108 (System.Double)+E4]");
									bool flag97 = (nint)0 == 0;
									object obj166 = !flag97;
									if (obj166 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										value = ((double*)(nint)num15)->m_value;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5656 @ X8_v108 (System.Double)+A0]");
									object obj167 = 0;
									object obj168 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val2, 16));
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Enumerator<, > val16 = val2;
									obj169 = (UnityEngine.Object)8;
									UnityEngine.Object obj170 = (UnityEngine.Object)14;
									style = (ShiftAuth.Style)(&val16);
									num5 = (int)obj22;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X9_v33 (System.String)+18]");
									num35 = 0;
									flag3 = true;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5658 @ X8_v109+10]");
									num14 = 0.0;
									val3 = val2;
									num4 = num51;
									font = screenFont;
									text = (string)text3._stringLength;
									gillaLeaderboard = this;
									stringBuilder = (StringBuilder)(object)text23;
									goto IL_8069;
								}
							}
						}
					}
					goto IL_7481;
				}
			}
		}
		goto IL_73cb;
		IL_7f5b:
		string[] array4 = default;
		object obj171 = array4 + 40;
		object obj172;
		obj171 = obj172;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
		object obj173 = 0;
		string text24 = Fits(num8, array4);
		object obj174 = obj173;
		screenFont = this.text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6079 @ X8_v389+E4]");
		bool flag98 = (nint)0 == 0;
		object obj175 = !flag98;
		if (obj175 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num54 = Measure(screenFont, text24, 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
		object obj176 = 0;
		object obj177 = obj176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6153 @ X0_v487+E4]");
		bool flag99 = (nint)0 == 0;
		object obj178 = !flag99;
		if (obj178 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool offline2 = GillaFriends.Offline;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		obj22 = (UnityEngine.Object)0;
		nint num55 = (nint)obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6200 @ X0_v491 (Il2CppClass<UnityEngine.Object>)+E4]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6200 @ X0_v491 (Il2CppClass<UnityEngine.Object>)+E4]");
		bool flag100 = (nint)0 == 0;
		object obj179 = !flag100;
		nint num56 = num55;
		if (obj179 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num56 = (nint)obj22;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6210 @ X0_v492 (Il2CppClass<UnityEngine.Object>)+A0]");
		object obj180 = 0;
		object obj181 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val2, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		num4 = 308 - num54;
		Enumerator<, > val17 = val2;
		style = (ShiftAuth.Style)(&val17);
		num5 = 8;
		flag3 = (byte)(int)text8 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6212 @ X8_v395+8]");
		num14 = 0.0;
		val3 = val2;
		font = screenFont;
		gillaLeaderboard = this;
		stringBuilder = (StringBuilder)(object)text24;
		goto IL_8069;
		IL_7457:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_7465;
		IL_3166:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj182 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string text25 = num2.ToString();
		string[] array5 = default;
		bool flag101 = array5 == null;
		val4 = val2;
		flag20 = false;
		style = (ShiftAuth.Style)(&val4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
		flag21 = false;
		textureFormat = (TextureFormat)8;
		flag12 = offline;
		num6 = num7;
		array3 = (string[])num8;
		array = array5;
		flag23 = (byte)this.page != 0;
		text6 = (string)(-1);
		val5 = (Enumerator<, >)obj27;
		text7 = text8;
		num14 = (double)obj147;
		val3 = val2;
		num3 = 2;
		obj21 = null;
		int num57;
		text = (string)num57;
		if (flag101)
		{
			goto IL_73cb;
		}
		bool flag102 = array5.Length == 0;
		val4 = val2;
		flag20 = false;
		style = (ShiftAuth.Style)(&val4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
		flag21 = false;
		textureFormat = (TextureFormat)8;
		flag12 = offline;
		num6 = num7;
		array3 = (string[])num8;
		array = array5;
		flag23 = (byte)this.page != 0;
		text6 = (string)(-1);
		val5 = (Enumerator<, >)obj27;
		text7 = text8;
		num14 = (double)obj147;
		val3 = val2;
		num3 = 2;
		obj21 = null;
		text = (string)num57;
		string text34;
		if (!flag102)
		{
			object obj183 = array5 + 32;
			obj183 = text25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ X20_v101-8]");
			object obj184 = 0 & 0xFFFFFFFEL;
			bool flag103 = obj184 == null;
			val4 = val2;
			flag20 = false;
			style = (ShiftAuth.Style)(&val4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
			flag21 = false;
			textureFormat = (TextureFormat)8;
			flag12 = offline;
			num6 = num7;
			array3 = (string[])num8;
			array = array5;
			flag23 = (byte)this.page != 0;
			text6 = (string)(-1);
			val5 = (Enumerator<, >)obj27;
			text7 = text8;
			num14 = (double)obj147;
			val3 = val2;
			num3 = 2;
			obj21 = (UnityEngine.Object)(object)text25;
			text = (string)num57;
			if (!flag103)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1860]");
				object obj185 = 0;
				obj21 = (UnityEngine.Object)obj185;
				object obj186 = array5 + 40;
				obj186 = obj185;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag104 = state.asking == null;
				val4 = val2;
				flag20 = false;
				style = (ShiftAuth.Style)(&val4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
				flag21 = false;
				textureFormat = (TextureFormat)8;
				flag12 = offline;
				num6 = num7;
				array3 = (string[])num8;
				array = array5;
				flag23 = (byte)this.page != 0;
				text6 = (string)(-1);
				val5 = (Enumerator<, >)obj27;
				text7 = text8;
				num14 = (double)obj147;
				val3 = val2;
				num3 = 2;
				text = (string)num57;
				if (flag104)
				{
					goto IL_73cb;
				}
				string text26 = num35.ToString();
				bool flag105 = array5.Length < 2;
				object obj187 = !flag105;
				object obj188 = array5.Length - 2;
				bool flag106 = obj188 == null;
				object obj189 = ~obj187;
				object obj190 = obj189 | flag106;
				val4 = val2;
				flag20 = false;
				style = (ShiftAuth.Style)(&val4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
				flag21 = false;
				textureFormat = (TextureFormat)8;
				flag12 = offline;
				num6 = num7;
				array3 = (string[])num8;
				array = array5;
				flag23 = (byte)this.page != 0;
				text6 = (string)(-1);
				val5 = (Enumerator<, >)obj27;
				text7 = text8;
				num14 = (double)obj147;
				val3 = val2;
				num3 = 2;
				obj21 = null;
				text = (string)num57;
				if (obj190 == null)
				{
					object obj191 = array5 + 48;
					obj191 = text26;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2954 @ X20_v103-18]");
					object obj192 = 0 & 0xFFFFFFFCL;
					bool flag107 = obj192 == null;
					val4 = val2;
					flag20 = false;
					style = (ShiftAuth.Style)(&val4);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
					flag21 = false;
					textureFormat = (TextureFormat)8;
					flag12 = offline;
					num6 = num7;
					array3 = (string[])num8;
					array = array5;
					flag23 = (byte)this.page != 0;
					text6 = (string)(-1);
					val5 = (Enumerator<, >)obj27;
					text7 = text8;
					num14 = (double)obj147;
					val3 = val2;
					num3 = 2;
					obj21 = (UnityEngine.Object)(object)text26;
					text = (string)num57;
					if (!flag107)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1898]");
						object obj193 = 0;
						object obj194 = array5 + 56;
						obj194 = obj193;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
						object obj195 = 0;
						object obj196 = obj195;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4659 @ X0_v450+E4]");
						bool flag108 = (nint)0 == 0;
						object obj197 = !flag108;
						if (obj197 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int unseen = GillaFriends.Unseen;
						string text27 = num35.ToString();
						bool flag109 = array5.Length < 4;
						object obj198 = !flag109;
						object obj199 = array5.Length - 4;
						bool flag110 = obj199 == null;
						object obj200 = ~obj198;
						object obj201 = obj200 | flag110;
						val4 = val2;
						flag20 = false;
						style = (ShiftAuth.Style)(&val4);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
						flag21 = false;
						textureFormat = (TextureFormat)8;
						flag12 = offline;
						num6 = num7;
						array3 = (string[])num8;
						array = array5;
						flag23 = (byte)this.page != 0;
						text6 = (string)(-1);
						val5 = (Enumerator<, >)obj27;
						text7 = text8;
						num14 = (double)obj147;
						val3 = val2;
						num3 = 2;
						obj21 = null;
						text = (string)num57;
						if (obj201 == null)
						{
							object obj202 = array5 + 64;
							obj202 = text27;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2955 @ X20_v105-28]");
							bool flag111 = (nint)0 < (nint)5;
							object obj203 = !flag111;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2955 @ X20_v105-28]");
							object obj204 = -5;
							bool flag112 = obj204 == null;
							object obj205 = ~obj203;
							object obj206 = obj205 | flag112;
							val4 = val2;
							flag20 = false;
							style = (ShiftAuth.Style)(&val4);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
							flag21 = false;
							textureFormat = (TextureFormat)8;
							flag12 = offline;
							num6 = num7;
							array3 = (string[])num8;
							array = array5;
							flag23 = (byte)this.page != 0;
							text6 = (string)(-1);
							val5 = (Enumerator<, >)obj27;
							text7 = text8;
							num14 = (double)obj147;
							val3 = val2;
							num3 = 2;
							obj21 = (UnityEngine.Object)(object)text27;
							text = (string)num57;
							if (obj206 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1838]");
								object obj207 = 0;
								object obj208 = array5 + 72;
								obj208 = obj207;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								string text28 = string.Concat(array5);
								nint num58 = (nint)stringBuilder;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4892 @ X8_v379 (Il2CppClass<System.Text.StringBuilder>)+E4]");
								text = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4892 @ X8_v379 (Il2CppClass<System.Text.StringBuilder>)+E4]");
								bool flag113 = (nint)0 == 0;
								object obj209 = !flag113;
								if (obj209 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								int num59 = Measure((ScreenFont)((bool*)(nint)text8)->m_value, text28, 1);
								bool flag114 = num59 <= num8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
								flag21 = false;
								textureFormat = (TextureFormat)8;
								num35 = unseen;
								text3 = text28;
								string text29 = (string)1;
								string text30 = text28;
								if (!flag114)
								{
									bool flag115 = state.asking == null;
									val4 = val2;
									flag20 = false;
									style = (ShiftAuth.Style)(&val4);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
									flag21 = false;
									textureFormat = (TextureFormat)8;
									flag12 = offline;
									flag3 = (byte)(int)text8 != 0;
									num6 = num7;
									array3 = (string[])num8;
									array = (string[])(object)text28;
									flag23 = (byte)this.page != 0;
									text6 = (string)(-1);
									val5 = (Enumerator<, >)obj27;
									text7 = text8;
									num14 = (double)obj147;
									val3 = val2;
									num3 = 1;
									obj21 = (UnityEngine.Object)(object)text28;
									if (flag115)
									{
										goto IL_73cb;
									}
									string text31 = num35.ToString();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
									object obj210 = 0;
									object obj211 = obj210;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5212 @ X8_v418+E4]");
									bool flag116 = (nint)0 == 0;
									object obj212 = !flag116;
									if (obj212 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									int unseen2 = GillaFriends.Unseen;
									string text32 = num35.ToString();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1898]");
									object obj213 = 0;
									text30 = (string)obj213;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1838]");
									object obj214 = 0;
									string text33 = text31 + (string)obj213 + text32 + (string)obj214;
									flag21 = false;
									textureFormat = (TextureFormat)obj214;
									num35 = unseen2;
									text3 = text33;
									text29 = text32;
								}
								nint num60 = (nint)stringBuilder;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5003 @ X0_v467 (Il2CppClass<System.Text.StringBuilder>)+E4]");
								bool flag117 = (nint)0 == 0;
								object obj215 = !flag117;
								if (obj215 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								int num61 = Measure((ScreenFont)(object)text8, text3, 1);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
								object obj216 = 0;
								bool flag118 = num61 <= num8;
								num3 = 1;
								text34 = text3;
								if (!flag118)
								{
									object obj217 = obj216;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5277 @ X0_v506+E4]");
									bool flag119 = (nint)0 == 0;
									object obj218 = !flag119;
									if (obj218 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									int unseen3 = GillaFriends.Unseen;
									string text35 = num35.ToString();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1838]");
									object obj219 = 0;
									text34 = (string)obj219;
									string text36 = text35 + (string)obj219;
									num35 = unseen3;
									text3 = text36;
									num3 = unchecked((nint)null);
								}
								bool flag120 = this.page == 0;
								flag3 = (byte)(int)text8 != 0;
								num49 = (int)num3;
								text = text8;
								screenFont3 = (ScreenFont)(object)stringBuilder;
								if (flag120)
								{
									goto IL_942d;
								}
								object obj220 = obj216;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5375 @ X0_v472+E4]");
								bool flag121 = (nint)0 == 0;
								object obj221 = !flag121;
								if (obj221 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool offline3 = GillaFriends.Offline;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
								object obj222 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								if (offline3)
								{
									bool flag122 = array4 == null;
									val4 = val2;
									flag20 = false;
									style = (ShiftAuth.Style)(&val4);
									flag12 = offline;
									flag3 = (byte)(int)text8 != 0;
									num6 = num7;
									array3 = (string[])num8;
									array = (string[])(object)text3;
									flag23 = (byte)this.page != 0;
									text6 = (string)(-1);
									val5 = (Enumerator<, >)obj27;
									text7 = text8;
									num14 = (double)obj147;
									val3 = val2;
									obj21 = (UnityEngine.Object)2;
									text = text8;
									stringBuilder = (StringBuilder)offline3;
									if (flag122)
									{
										goto IL_73cb;
									}
									bool flag123 = array4.Length == 0;
									val4 = val2;
									flag20 = false;
									style = (ShiftAuth.Style)(&val4);
									flag12 = offline;
									flag3 = (byte)(int)text8 != 0;
									num6 = num7;
									array3 = (string[])num8;
									array = (string[])(object)text3;
									flag23 = (byte)this.page != 0;
									text6 = (string)(-1);
									val5 = (Enumerator<, >)obj27;
									text7 = text8;
									num14 = (double)obj147;
									val3 = val2;
									obj21 = (UnityEngine.Object)2;
									text = text8;
									stringBuilder = (StringBuilder)offline3;
									if (!flag123)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1830]");
										object obj223 = 0;
										obj21 = (UnityEngine.Object)obj223;
										stringBuilder = (StringBuilder)(array4 + 32);
										stringBuilder = (StringBuilder)obj223;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4298 @ X21_v56 (System.Text.StringBuilder)-8]");
										object obj224 = 0 & 0xFFFFFFFEL;
										bool flag124 = obj224 == null;
										val4 = val2;
										flag20 = false;
										style = (ShiftAuth.Style)(&val4);
										flag12 = offline;
										flag3 = (byte)(int)text8 != 0;
										num6 = num7;
										array3 = (string[])num8;
										array = (string[])(object)text3;
										flag23 = (byte)this.page != 0;
										text6 = (string)(-1);
										val5 = (Enumerator<, >)obj27;
										text7 = text8;
										num14 = (double)obj147;
										val3 = val2;
										text = text8;
										if (!flag124)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82F8]");
											obj172 = 0;
											goto IL_7f5b;
										}
									}
								}
								else
								{
									bool flag125 = array4 == null;
									val4 = val2;
									flag20 = false;
									style = (ShiftAuth.Style)(&val4);
									flag12 = offline;
									flag3 = (byte)(int)text8 != 0;
									num6 = num7;
									array3 = (string[])num8;
									array = (string[])(object)text3;
									flag23 = (byte)this.page != 0;
									text6 = (string)(-1);
									val5 = (Enumerator<, >)obj27;
									text7 = text8;
									num14 = (double)obj147;
									val3 = val2;
									obj21 = (UnityEngine.Object)2;
									text = text8;
									stringBuilder = (StringBuilder)offline3;
									if (flag125)
									{
										goto IL_73cb;
									}
									bool flag126 = array4.Length == 0;
									val4 = val2;
									flag20 = false;
									style = (ShiftAuth.Style)(&val4);
									flag12 = offline;
									flag3 = (byte)(int)text8 != 0;
									num6 = num7;
									array3 = (string[])num8;
									array = (string[])(object)text3;
									flag23 = (byte)this.page != 0;
									text6 = (string)(-1);
									val5 = (Enumerator<, >)obj27;
									text7 = text8;
									num14 = (double)obj147;
									val3 = val2;
									obj21 = (UnityEngine.Object)2;
									text = text8;
									stringBuilder = (StringBuilder)offline3;
									if (!flag126)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1820]");
										object obj225 = 0;
										obj21 = (UnityEngine.Object)obj225;
										stringBuilder = (StringBuilder)(array4 + 32);
										stringBuilder = (StringBuilder)obj225;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4298 @ X21_v56 (System.Text.StringBuilder)-8]");
										object obj226 = 0 & 0xFFFFFFFEL;
										bool flag127 = obj226 == null;
										val4 = val2;
										flag20 = false;
										style = (ShiftAuth.Style)(&val4);
										flag12 = offline;
										flag3 = (byte)(int)text8 != 0;
										num6 = num7;
										array3 = (string[])num8;
										array = (string[])(object)text3;
										flag23 = (byte)this.page != 0;
										text6 = (string)(-1);
										val5 = (Enumerator<, >)obj27;
										text7 = text8;
										num14 = (double)obj147;
										val3 = val2;
										text = text8;
										if (!flag127)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1840]");
											obj172 = 0;
											goto IL_7f5b;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_7481;
		IL_7449:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_7457;
		IL_73cb:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_73d9;
		IL_8ed2:
		object obj227 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val2, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		ScreenFont screenFont4;
		Enumerator<, > val18 = default;
		gillaLeaderboard.Line(screenFont4, 160, 224, text4, (ShiftAuth.Style)(&val18), centred: true);
		bool flag128 = (object)gillaLeaderboard.tex == null;
		obj20 = (UnityEngine.Object)num16;
		val18 = val2;
		val4 = val2;
		flag20 = true;
		style = (ShiftAuth.Style)(&val18);
		flag21 = (byte)(int)text4 != 0;
		textureFormat = (TextureFormat)224;
		flag12 = offline;
		text2 = (string)num7;
		array = (string[])num19;
		flag23 = (byte)this.page != 0;
		text6 = (string)(-1);
		text7 = text8;
		object obj228;
		num14 = (double)obj228;
		val3 = val2;
		num3 = 160;
		obj21 = (UnityEngine.Object)(object)screenFont4;
		state = state2;
		stringBuilder = (StringBuilder)(object)screenFont4;
		flag15 = (byte)num7 != 0;
		if (!flag128)
		{
			gillaLeaderboard.tex.SetPixels32(gillaLeaderboard.px);
			bool flag129 = (object)gillaLeaderboard.tex == null;
			obj20 = (UnityEngine.Object)num16;
			val18 = val2;
			val4 = val2;
			flag20 = true;
			style = (ShiftAuth.Style)(&val18);
			flag21 = (byte)(int)text4 != 0;
			textureFormat = (TextureFormat)224;
			flag12 = offline;
			text2 = (string)num7;
			array = (string[])num19;
			flag23 = (byte)this.page != 0;
			text6 = (string)(-1);
			text7 = text8;
			num14 = (double)obj228;
			val3 = val2;
			num3 = unchecked((nint)null);
			obj21 = (UnityEngine.Object)(object)gillaLeaderboard.px;
			state = state2;
			stringBuilder = (StringBuilder)(object)screenFont4;
			flag15 = (byte)num7 != 0;
			if (!flag129)
			{
				gillaLeaderboard.tex.Apply(updateMipmaps: true);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj229 = 0;
				object obj230 = obj229;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5864 @ X0_v198+E4]");
				bool flag130 = (nint)0 == 0;
				object obj231 = !flag130;
				if (obj231 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag131 = gillaLeaderboard.screen == null;
				bool flag132 = !flag131;
				object obj232 = !flag132;
				if (obj232 != null)
				{
					return;
				}
				object obj233 = this + 208;
				bool flag133 = obj233 == null;
				object obj234 = !flag133;
				obj21 = null;
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)(object)screenFont4;
				if (obj234 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
					object obj235 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					MaterialPropertyBlock materialPropertyBlock2 = default;
					materialPropertyBlock2._002Ector();
					obj233 = materialPropertyBlock2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj21 = (UnityEngine.Object)(object)materialPropertyBlock2;
					materialPropertyBlock = materialPropertyBlock2;
				}
				bool flag134 = (object)screen == null;
				obj20 = (UnityEngine.Object)num16;
				val18 = val2;
				val4 = val2;
				flag20 = true;
				style = (ShiftAuth.Style)(&val18);
				flag21 = (byte)(int)text4 != 0;
				textureFormat = (TextureFormat)224;
				flag12 = offline;
				text2 = (string)num7;
				array = (string[])num19;
				flag23 = (byte)this.page != 0;
				text6 = (string)(-1);
				text7 = text8;
				num14 = (double)obj228;
				val3 = val2;
				num3 = unchecked((nint)null);
				state = state2;
				stringBuilder = (StringBuilder)(object)materialPropertyBlock;
				flag15 = (byte)num7 != 0;
				if (!flag134)
				{
					screen.GetPropertyBlock((MaterialPropertyBlock)obj233);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
					object obj236 = 0;
					object obj237 = obj236;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6104 @ X0_v204+E4]");
					bool flag135 = (nint)0 == 0;
					object obj238 = !flag135;
					if (obj238 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag136 = obj233 == null;
					obj20 = (UnityEngine.Object)num16;
					val18 = val2;
					val4 = val2;
					flag20 = true;
					style = (ShiftAuth.Style)(&val18);
					flag21 = (byte)(int)text4 != 0;
					textureFormat = (TextureFormat)224;
					flag12 = offline;
					text2 = (string)num7;
					array = (string[])num19;
					flag23 = (byte)this.page != 0;
					text6 = (string)(-1);
					text7 = text8;
					num14 = (double)obj228;
					val3 = val2;
					num3 = unchecked((nint)null);
					obj21 = (UnityEngine.Object)obj233;
					state = state2;
					stringBuilder = (StringBuilder)obj233;
					flag15 = (byte)num7 != 0;
					if (!flag136)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
						object obj239 = 0;
						object obj240 = obj239;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6184 @ X8_v147+A0]");
						object obj241 = 0;
						object obj242 = obj233;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X8_v148+3C]");
						((MaterialPropertyBlock)obj242).SetTexture(0, (Texture)tex);
						bool flag137 = (object)screen == null;
						obj20 = (UnityEngine.Object)num16;
						val18 = val2;
						val4 = val2;
						flag20 = true;
						style = (ShiftAuth.Style)(&val18);
						flag21 = (byte)(int)text4 != 0;
						textureFormat = (TextureFormat)0;
						flag12 = offline;
						text2 = (string)num7;
						array = (string[])num19;
						flag23 = (byte)this.page != 0;
						text6 = (string)(-1);
						text7 = text8;
						num14 = (double)obj228;
						val3 = val2;
						num3 = (nint)tex;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X8_v148+3C]");
						obj21 = (UnityEngine.Object)0;
						state = state2;
						stringBuilder = (StringBuilder)obj233;
						flag15 = (byte)num7 != 0;
						if (!flag137)
						{
							screen.SetPropertyBlock((MaterialPropertyBlock)obj233);
							return;
						}
					}
				}
			}
		}
		goto IL_73cb;
		IL_440d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj243 = 0;
		text3 = (string)obj243;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
		flag21 = false;
		textureFormat = (TextureFormat)8;
		GillaFriends.Person[] asking;
		num35 = asking.Length;
		num49 = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
		text34 = (string)0;
		text = (string)286;
		goto IL_942d;
		IL_2fb5:
		GillaFriends.Friend[] friends;
		flag3 = (byte)friends.Length != 0;
		object obj244 = ~friends.Length;
		num57 = friends.Length & obj244;
		bool flag138 = friends.Length < 1;
		num2 = 0;
		if (flag138)
		{
			goto IL_3166;
		}
		UnityEngine.Object obj245 = obj169;
		UnityEngine.Object obj246 = null;
		int num62 = 0;
		num2 = 0;
		while (true)
		{
			bool flag139 = (flag3 ? 1 : 0) == (nint)obj246;
			obj169 = obj245;
			UnityEngine.Object obj170 = obj246;
			val4 = val2;
			flag20 = false;
			style = (ShiftAuth.Style)(&val4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
			flag21 = false;
			textureFormat = (TextureFormat)8;
			flag12 = offline;
			num6 = num7;
			array3 = (string[])num8;
			flag23 = (byte)this.page != 0;
			text6 = (string)(-1);
			val5 = (Enumerator<, >)obj27;
			text7 = text8;
			num14 = (double)obj147;
			val3 = val2;
			num3 = 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
			obj21 = (UnityEngine.Object)0;
			text = (string)num57;
			if (flag139)
			{
				break;
			}
			object obj247 = (object)state.friends + (object)obj246;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4511 @ X13_v9+20]");
			obj169 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4511 @ X13_v9+20]");
			bool flag140 = (nint)0 == 0;
			obj170 = obj246;
			val4 = val2;
			flag20 = false;
			style = (ShiftAuth.Style)(&val4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
			flag21 = false;
			textureFormat = (TextureFormat)8;
			flag12 = offline;
			num6 = num7;
			array3 = (string[])num8;
			flag23 = (byte)this.page != 0;
			text6 = (string)(-1);
			val5 = (Enumerator<, >)obj27;
			text7 = text8;
			num14 = (double)obj147;
			val3 = val2;
			num3 = 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
			obj21 = (UnityEngine.Object)0;
			text = (string)num57;
			if (!flag140)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X13_v6 (UnityEngine.Object)+28]");
				obj169 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X13_v6 (UnityEngine.Object)+28]");
				if ((nint)0 != 0)
				{
					num62++;
					num2 = num62;
				}
				obj170 = (UnityEngine.Object)(obj246 + 1);
				bool flag141 = num57 != (nint)obj170;
				obj245 = obj169;
				obj246 = obj170;
				if (flag141)
				{
					continue;
				}
				goto IL_3166;
			}
			goto IL_749d;
		}
		goto IL_748f;
		IL_7481:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		goto IL_748f;
		IL_7465:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_7473;
		IL_73e7:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_73f5;
		IL_742d:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_743b;
		IL_7411:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_741f;
		IL_73f5:
		NullReferenceException ex10 = new NullReferenceException();
		goto IL_7403;
		IL_0410:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		obj15 = 0;
		flag9 = false;
		goto IL_765c;
		IL_634f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
		stringBuilder = (StringBuilder)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X8_v127 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
		if ((nint)0 >= (nint)11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
			object obj248 = 0;
			object obj249 = obj248;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4972 @ X0_v280+E4]");
			bool flag142 = (nint)0 == 0;
			object obj250 = !flag142;
			if (obj250 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj249 = obj248;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4972 @ X0_v280+A0]");
			object obj251 = 0;
			GillaLeaderboard gillaLeaderboard6 = gillaLeaderboard;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4974 @ X8_v215+18]");
			gillaLeaderboard6.Fill(307, 38, 5, 178, (Color32)0);
			List<Entry> list4 = gillaLeaderboard.entries;
			bool flag143 = gillaLeaderboard.entries == null;
			obj20 = (UnityEngine.Object)num16;
			val4 = val2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4974 @ X8_v215+18]");
			style = (ShiftAuth.Style)0;
			flag21 = true;
			textureFormat = (TextureFormat)5;
			flag12 = offline;
			text2 = (string)num7;
			array = (string[])num19;
			flag23 = (byte)this.page != 0;
			text6 = (string)(-1);
			text7 = text8;
			num3 = 38;
			obj21 = (UnityEngine.Object)307;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X8_v127 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
			obj22 = (UnityEngine.Object)0;
			state = state2;
			flag15 = (byte)num7 != 0;
			if (flag143)
			{
				goto IL_73cb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X8_v216 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
			int num63 = (int)((nint)1780 / (nint)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X8_v216 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
			object obj252 = -10;
			object obj253 = num63 - 8;
			bool flag144 = (nint)obj253 < 0;
			bool flag145 = obj253 == null;
			int num64 = num63 ^ 8;
			int num65 = num63 ^ obj253;
			int num66 = num64 & num65;
			bool flag146 = num66 < 0;
			bool flag147 = flag144 == flag146;
			object obj254 = !flag145;
			object obj255 = flag147 & obj254;
			object obj256 = ~obj255;
			int num67 = ((obj256 != null) ? 8 : num63);
			object obj257 = obj252 - 1;
			bool flag148 = (nint)obj257 < 0;
			bool flag149 = obj257 == null;
			object obj258 = obj252 ^ 1;
			object obj259 = obj252 ^ obj257;
			object obj260 = obj258 & obj259;
			bool flag150 = (nint)obj260 < 0;
			flag3 = (byte)(178 - num67) != 0;
			bool flag151 = flag148 == flag150;
			object obj42 = !flag149;
			object obj261 = flag151 & obj42;
			if ((int)(~obj261) != 0)
			{
				obj252 = 1;
			}
			object obj262 = (flag3 ? 1 : 0) * gillaLeaderboard.top;
			object obj263 = obj262 / obj252;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
			object obj264 = 0;
			object obj265 = obj264;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5487 @ X9_v59+A0]");
			text = (string)0;
			int num68 = obj263 + 38;
			GillaLeaderboard gillaLeaderboard7 = gillaLeaderboard;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X9_v33 (System.String)+24]");
			gillaLeaderboard7.Fill(307, num68, 5, num67, (Color32)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X9_v33 (System.String)+24]");
			style2 = (ShiftAuth.Style)0;
			flag43 = (byte)num67 != 0;
			textureFormat2 = (TextureFormat)5;
			num25 = num68;
			obj56 = (UnityEngine.Object)307;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ X19_v27 (GillaLeaderboard)+108]");
		bool flag161;
		bool flag162;
		bool flag169;
		string text41;
		if ((nint)0 != 0)
		{
			object obj266 = (((bool*)num7)->m_value ? 1 : 0) & 0x80000000L;
			bool flag152 = obj266 == null;
			object obj267 = !flag152;
			if (obj267 == null)
			{
				nint num69 = (nint)stringBuilder;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5058 @ X0_v263 (Il2CppClass<System.Text.StringBuilder>)+E4]");
				bool flag153 = (nint)0 == 0;
				object obj268 = !flag153;
				nint num70 = num69;
				if (obj268 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num70 = (nint)stringBuilder;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				obj22 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ X0_v264 (Il2CppClass<System.Text.StringBuilder>)+A0]");
				object obj269 = 0;
				object obj270 = obj269;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
				stringBuilder = (StringBuilder)0;
				bool flag154 = obj269 == null;
				obj20 = (UnityEngine.Object)num16;
				val4 = val2;
				style = style2;
				flag21 = flag43;
				textureFormat = textureFormat2;
				flag12 = offline;
				text2 = (string)num7;
				array = (string[])num19;
				flag23 = (byte)this.page != 0;
				text6 = (string)(-1);
				text7 = text8;
				num3 = num25;
				obj21 = obj56;
				state = state2;
				flag15 = (byte)num7 != 0;
				if (flag154)
				{
					goto IL_73cb;
				}
				text = (string)((bool*)num7)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1166 @ X8_v202+18]");
				flag3 = false;
				bool value2 = ((bool*)num7)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1166 @ X8_v202+18]");
				bool flag155 = (nint)(value2 ? 1 : 0) < (nint)0;
				object obj271 = !flag155;
				obj20 = (UnityEngine.Object)num16;
				val4 = val2;
				style = style2;
				flag21 = flag43;
				textureFormat = textureFormat2;
				flag12 = offline;
				text2 = (string)num7;
				array = (string[])num19;
				flag23 = (byte)this.page != 0;
				text6 = (string)(-1);
				text7 = text8;
				num3 = num25;
				obj21 = obj56;
				state = state2;
				flag15 = (byte)num7 != 0;
				if (obj271 != null)
				{
					goto IL_7481;
				}
				object obj272 = obj269 + ((bool*)num7)->m_value;
				float time = Time.time;
				nint num71 = (nint)obj22;
				float num43 = gillaLeaderboard.sendAt - time;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5494 @ X0_v267 (Il2CppClass<UnityEngine.Object>)+E4]");
				bool flag156 = (nint)0 == 0;
				object obj273 = !flag156;
				if (obj273 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
				float num72 = time - 1f;
				bool flag157 = num72 < 0f;
				bool flag158 = num72 == 0f;
				object obj274 = time ^ 1;
				object obj275 = time ^ num72;
				object obj276 = obj274 & obj275;
				bool flag159 = (nint)obj276 < 0;
				bool flag160 = flag157 == flag159;
				object obj42 = !flag158;
				object obj277 = flag160 & obj42;
				if ((int)(~obj277) == 0)
				{
				}
				string text37 = num35.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D18A0]");
				object obj278 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1858]");
				object obj279 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5314 @ X8_v203+20]");
				string text38 = (string)0 + (string)obj278 + text37 + (string)obj279;
				flag43 = false;
				textureFormat2 = (TextureFormat)obj279;
				num25 = (nint)text37;
				obj56 = (UnityEngine.Object)obj278;
				gillaLeaderboard = this;
				text4 = text38;
			}
			else
			{
				string text39 = gillaLeaderboard.Cut((string)gillaLeaderboard.picking, 120);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1810]");
				object obj280 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1848]");
				object obj281 = 0;
				string text40 = (string)obj280 + text39 + (string)obj281;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
				stringBuilder = (StringBuilder)0;
				textureFormat2 = (TextureFormat)0;
				num25 = (nint)obj281;
				obj56 = (UnityEngine.Object)(object)text39;
				text4 = text40;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
			stringBuilder = (StringBuilder)0;
			if (flag161)
			{
				text4 = text41;
			}
			else
			{
				if (!flag162)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
					object obj282 = 0;
					if (gillaLeaderboard.page != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
						object obj283 = 0;
						object obj284 = obj283;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5244 @ X0_v226+E4]");
						bool flag163 = (nint)0 == 0;
						object obj285 = !flag163;
						if (obj285 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (Application.isPlaying)
						{
							object obj286 = obj282;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5510 @ X0_v235+E4]");
							bool flag164 = (nint)0 == 0;
							object obj287 = !flag164;
							if (obj287 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj286 = obj282;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5510 @ X0_v235+A0]");
							object obj288 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5627 @ X8_v184+18]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5510 @ X0_v235+E4]");
								bool flag165 = (nint)0 == 0;
								object obj289 = !flag165;
								if (obj289 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3026DA0");
								object obj290 = default;
								bool flag166 = obj290 == null;
								obj20 = (UnityEngine.Object)num16;
								val4 = val2;
								style = style2;
								flag21 = flag43;
								textureFormat = textureFormat2;
								flag12 = offline;
								text2 = (string)num7;
								array = (string[])num19;
								flag23 = (byte)this.page != 0;
								text6 = (string)(-1);
								text7 = text8;
								num3 = num25;
								obj21 = obj56;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X8_v127 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
								obj22 = (UnityEngine.Object)0;
								state = state2;
								flag15 = (byte)num7 != 0;
								if (flag166)
								{
									goto IL_73cb;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X0_v238+10]");
								if ((nint)0 >= (nint)1)
								{
									object obj291 = obj282;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5962 @ X0_v239+E4]");
									bool flag167 = (nint)0 == 0;
									object obj292 = !flag167;
									if (obj292 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3026DA0");
									goto IL_7392;
								}
							}
						}
						if (gillaLeaderboard.page != 0)
						{
							text = (string)(object)gillaLeaderboard.entries;
							bool flag168 = gillaLeaderboard.entries == null;
							obj20 = (UnityEngine.Object)num16;
							val4 = val2;
							style = style2;
							flag21 = flag43;
							textureFormat = textureFormat2;
							flag12 = offline;
							text2 = (string)num7;
							array = (string[])num19;
							flag23 = (byte)this.page != 0;
							text6 = (string)(-1);
							text7 = text8;
							num3 = num25;
							obj21 = obj56;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X8_v127 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
							obj22 = (UnityEngine.Object)0;
							state = state2;
							flag15 = (byte)num7 != 0;
							if (flag168)
							{
								goto IL_73cb;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X9_v33 (System.String)+18]");
							if ((nint)0 != 0)
							{
								if (gillaLeaderboard.page == (Page)4)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1850]");
									flag169 = false;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1880]");
									flag169 = false;
								}
								goto IL_8e16;
							}
							text5 = gillaLeaderboard.Empty();
							goto IL_7392;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1818]");
					flag169 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1868]");
					flag3 = false;
					if (!flag14)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1868]");
						flag169 = false;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X8_v127 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
					object obj293 = -10;
					bool flag170 = obj293 == null;
					object obj42 = !flag170;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X8_v127 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
					bool flag171 = (nint)0 > (nint)10;
					bool flag172 = flag14;
					if (!flag171)
					{
						bool flag173 = !flag14;
						flag172 = flag14;
						if (!flag173)
						{
							List<Row> list5 = gillaLeaderboard.rows;
							bool flag174 = gillaLeaderboard.rows == null;
							obj20 = (UnityEngine.Object)num16;
							val4 = val2;
							style = style2;
							flag21 = flag43;
							textureFormat = textureFormat2;
							flag12 = offline;
							flag172 = flag14;
							text2 = (string)num7;
							array = (string[])num19;
							flag23 = (byte)this.page != 0;
							text6 = (string)(-1);
							text7 = text8;
							num3 = num25;
							obj21 = obj56;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X8_v127 (System.Collections.Generic.List`1<GillaLeaderboard+Entry>)+18]");
							obj22 = (UnityEngine.Object)0;
							text = (string)flag14;
							state = state2;
							flag15 = (byte)num7 != 0;
							if (flag174)
							{
								goto IL_73cb;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1870]");
							flag3 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ X8_v166 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
							object obj294 = -1;
							bool flag175 = (nint)obj294 < 0;
							bool flag176 = obj294 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ X8_v166 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
							object obj295 = (nint)0 ^ (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ X8_v166 (System.Collections.Generic.List`1<GillaLeaderboard+Row>)+18]");
							object obj296 = 0 ^ obj294;
							object obj297 = obj295 & obj296;
							bool flag177 = (nint)obj297 < 0;
							bool flag178 = flag175 == flag177;
							obj42 = !flag176;
							object obj298 = flag178 & obj42;
							if ((int)(~obj298) == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1870]");
								flag169 = false;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1890]");
								flag169 = false;
							}
						}
					}
					goto IL_8e16;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
				object obj299 = 0;
				object obj300 = obj299;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5203 @ X0_v248+E4]");
				bool flag179 = (nint)0 == 0;
				object obj301 = !flag179;
				if (obj301 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj302 = obj299;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5173 @ X0_v252+E4]");
				bool flag180 = (nint)0 == 0;
				object obj303 = !flag180;
				if (obj303 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj302 = obj299;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5173 @ X0_v252+A0]");
				object obj304 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5181 @ X8_v193+30]");
				text4 = (string)0;
			}
		}
		nint num73 = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5190 @ X0_v215 (Il2CppClass<System.Text.StringBuilder>)+E4]");
		bool flag181 = (nint)0 == 0;
		object obj305 = !flag181;
		nint num74 = num73;
		if (obj305 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num74 = (nint)stringBuilder;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5234 @ X0_v216 (Il2CppClass<System.Text.StringBuilder>)+A0]");
		obj228 = 0;
		object obj306 = 0;
		obj22 = (UnityEngine.Object)(object)stringBuilder;
		text = (string)1;
		screenFont4 = (ScreenFont)(object)text8;
		goto IL_8ed2;
		IL_73d9:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_73e7;
		IL_743b:
		NullReferenceException ex12 = new NullReferenceException();
		goto IL_7449;
		IL_765c:
		nint num75 = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v471 (Il2CppClass<System.Text.StringBuilder>)+E4]");
		bool flag182 = (nint)0 == 0;
		object obj307 = !flag182;
		nint num76 = num75;
		if (obj307 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num76 = (nint)stringBuilder;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v472 (Il2CppClass<System.Text.StringBuilder>)+A0]");
		object obj308 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v473+18]");
		GillaLeaderboard gillaLeaderboard8;
		bool flag183;
		if ((nint)0 != 0)
		{
			gillaLeaderboard8 = this;
			flag183 = true;
		}
		else
		{
			object obj309 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v671+E4]");
			bool flag184 = (nint)0 == 0;
			object obj310 = !flag184;
			if (obj310 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Application.isPlaying)
			{
				nint num77 = (nint)stringBuilder;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1344 @ X0_v675 (Il2CppClass<System.Text.StringBuilder>)+E4]");
				bool flag185 = (nint)0 == 0;
				object obj311 = !flag185;
				if (obj311 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				nint num78 = (nint)stringBuilder;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1581 @ X0_v678 (Il2CppClass<System.Text.StringBuilder>)+E4]");
				bool flag186 = (nint)0 == 0;
				object obj312 = !flag186;
				nint num79 = num78;
				if (obj312 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num79 = (nint)stringBuilder;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v679 (Il2CppClass<System.Text.StringBuilder>)+A0]");
				object obj313 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1693 @ X8_v519+20]");
				bool flag187 = (nint)0 == 0;
				bool flag188 = !flag187;
				gillaLeaderboard8 = this;
				flag183 = flag188;
			}
			else
			{
				gillaLeaderboard8 = this;
				flag183 = false;
			}
		}
		text = gillaLeaderboard8.said;
		bool flag189 = gillaLeaderboard8.said == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
		obj20 = (UnityEngine.Object)0;
		val = (Enumerator<, >)0;
		num2 = 0;
		val2 = (Enumerator<, >)0;
		flag12 = false;
		flag13 = flag183;
		flag14 = flag9;
		flag3 = flag9;
		val3 = (Enumerator<, >)0;
		obj21 = (UnityEngine.Object)flag7;
		state = now;
		flag15 = force;
		if (!flag189)
		{
			if (text._stringLength >= 1)
			{
				float unscaledTime = Time.unscaledTime;
				float num80 = unscaledTime - gillaLeaderboard8.saidAt;
				float num81 = num80 - 5f;
				bool flag190 = num81 < 0f;
				flag161 = flag190;
				num14 = 5.0;
				val3 = (Enumerator<, >)num80;
			}
			else
			{
				flag161 = false;
				val3 = (Enumerator<, >)0;
			}
			nint num82 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1370 @ X0_v614 (Il2CppClass<System.Text.StringBuilder>)+E4]");
			bool flag191 = (nint)0 == 0;
			object obj314 = !flag191;
			if (obj314 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			nint num83 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1594 @ X0_v617 (Il2CppClass<System.Text.StringBuilder>)+E4]");
			bool flag192 = (nint)0 == 0;
			object obj315 = !flag192;
			nint num84 = num83;
			if (obj315 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num84 = (nint)stringBuilder;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1043 @ X0_v618 (Il2CppClass<System.Text.StringBuilder>)+A0]");
			object obj316 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1701 @ X8_v482+30]");
			object obj317 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1701 @ X8_v482+30]");
			bool flag193 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
			obj20 = (UnityEngine.Object)0;
			val = (Enumerator<, >)0;
			num2 = 0;
			val2 = (Enumerator<, >)0;
			flag12 = false;
			flag13 = flag183;
			flag14 = flag9;
			flag3 = flag9;
			obj21 = (UnityEngine.Object)flag7;
			state = now;
			flag15 = force;
			if (!flag193)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
				object obj318 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1132 @ X8_v483+10]");
				if ((nint)0 >= (nint)1)
				{
					float unscaledTime2 = Time.unscaledTime;
					nint num85 = (nint)stringBuilder;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2016 @ X0_v643 (Il2CppClass<System.Text.StringBuilder>)+E4]");
					bool flag194 = (nint)0 == 0;
					object obj319 = !flag194;
					if (obj319 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					nint num86 = (nint)stringBuilder;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2268 @ X0_v646 (Il2CppClass<System.Text.StringBuilder>)+E4]");
					bool flag195 = (nint)0 == 0;
					object obj320 = !flag195;
					nint num87 = num86;
					if (obj320 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						num87 = (nint)stringBuilder;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2053 @ X0_v647 (Il2CppClass<System.Text.StringBuilder>)+A0]");
					object obj321 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2369 @ X8_v497+38]");
					val3 = (Enumerator<, >)(unscaledTime2 - 0);
					double num88 = (double)val3 - 5.0;
					bool flag196 = num88 < 0.0;
					object obj322 = !flag196;
					bool flag197 = (int)(~obj322) != 0 && flag161;
					if (flag197)
					{
						float num43 = saidAt;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2053 @ X0_v647 (Il2CppClass<System.Text.StringBuilder>)+E4]");
						bool flag198 = (nint)0 == 0;
						object obj323 = !flag198;
						if (obj323 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						nint num89 = (nint)stringBuilder;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3194 @ X0_v650 (Il2CppClass<System.Text.StringBuilder>)+E4]");
						bool flag199 = (nint)0 == 0;
						object obj324 = !flag199;
						nint num90 = num89;
						if (obj324 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							num90 = (nint)stringBuilder;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2052 @ X0_v651 (Il2CppClass<System.Text.StringBuilder>)+A0]");
						object obj325 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3323 @ X8_v504+38]");
						val3 = (Enumerator<, >)0;
						float num91 = num43;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3323 @ X8_v504+38]");
						if (num91 < 0f)
						{
							flag162 = true;
							flag161 = false;
							num14 = 5.0;
							text = (string)(object)this;
							gillaLeaderboard8 = this;
						}
						else
						{
							flag162 = false;
							flag161 = true;
							num14 = 5.0;
							text = (string)(object)this;
							gillaLeaderboard8 = this;
						}
					}
					else
					{
						flag162 = flag196;
						float num43 = unscaledTime2;
						num14 = 5.0;
						text = (string)flag196;
						gillaLeaderboard8 = this;
					}
				}
				else
				{
					flag162 = false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				StringBuilder stringBuilder3 = default;
				stringBuilder3._002Ector();
				bool flag200 = gillaLeaderboard8.entries == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
				obj20 = (UnityEngine.Object)0;
				val = (Enumerator<, >)0;
				num2 = 0;
				val2 = (Enumerator<, >)0;
				flag12 = false;
				flag13 = flag183;
				flag14 = flag9;
				flag3 = flag9;
				obj21 = null;
				state = now;
				stringBuilder = stringBuilder3;
				flag15 = force;
				if (!flag200)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					text = (string)0;
					string text42 = (string)(gillaLeaderboard8 + 304);
					Enumerator<, > enumerator = gillaLeaderboard8.entries.GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
					num3 = 80;
					Enumerator<, > val19 = default;
					string text43 = default;
					double num92 = default;
					int num93 = default;
					byte b = default;
					byte b2 = default;
					string text44 = default;
					object obj327 = default;
					byte b3 = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D17C8]");
						object obj326 = 0;
						obj21 = (UnityEngine.Object)obj326;
						if (!val19.MoveNext())
						{
							break;
						}
						bool flag201 = stringBuilder3 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
						obj20 = (UnityEngine.Object)0;
						val = (Enumerator<, >)0;
						num2 = 0;
						val2 = (Enumerator<, >)0;
						flag12 = false;
						flag13 = flag183;
						flag14 = flag9;
						flag3 = flag9;
						flag23 = false;
						text6 = null;
						val5 = (Enumerator<, >)(ref val19);
						text41 = text42;
						text7 = text;
						state = now;
						stringBuilder = stringBuilder3;
						flag15 = force;
						if (flag201)
						{
							goto IL_7411;
						}
						StringBuilder stringBuilder4 = stringBuilder3.Append((string)null);
						bool flag202 = stringBuilder4 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
						obj20 = (UnityEngine.Object)0;
						val = (Enumerator<, >)0;
						num2 = 0;
						val2 = (Enumerator<, >)0;
						flag12 = false;
						flag13 = flag183;
						flag14 = flag9;
						flag3 = flag9;
						text2 = text43;
						double num15 = num92;
						num6 = num93;
						array3 = (string[])b;
						array = (string[])b2;
						int num20 = (int)text44;
						flag23 = false;
						text6 = null;
						val5 = (Enumerator<, >)(ref val19);
						text41 = text42;
						text7 = text;
						num3 = unchecked((nint)null);
						obj21 = null;
						obj22 = null;
						state = now;
						stringBuilder = stringBuilder3;
						flag15 = force;
						if (flag202)
						{
							goto IL_741f;
						}
						StringBuilder stringBuilder5 = stringBuilder4.Append(text43);
						bool flag203 = stringBuilder5 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
						obj20 = (UnityEngine.Object)0;
						val = (Enumerator<, >)0;
						num2 = 0;
						val2 = (Enumerator<, >)0;
						flag12 = false;
						flag13 = flag183;
						flag14 = flag9;
						flag3 = flag9;
						text2 = text43;
						num15 = num92;
						num6 = num93;
						array3 = (string[])b;
						array = (string[])b2;
						num20 = (int)text44;
						flag23 = false;
						text6 = null;
						val5 = (Enumerator<, >)(ref val19);
						text41 = text42;
						text7 = text;
						num3 = unchecked((nint)null);
						obj21 = (UnityEngine.Object)(object)text43;
						obj22 = null;
						state = now;
						stringBuilder = stringBuilder3;
						flag15 = force;
						if (flag203)
						{
							goto IL_73e7;
						}
						StringBuilder stringBuilder6 = stringBuilder5.Append((string)null);
						bool flag204 = stringBuilder6 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
						obj20 = (UnityEngine.Object)0;
						val = (Enumerator<, >)0;
						num2 = 0;
						val2 = (Enumerator<, >)0;
						flag12 = false;
						flag13 = flag183;
						flag14 = flag9;
						flag3 = flag9;
						text2 = text43;
						num15 = num92;
						num6 = num93;
						array3 = (string[])b;
						array = (string[])b2;
						num20 = (int)text44;
						flag23 = false;
						text6 = null;
						val5 = (Enumerator<, >)(ref val19);
						text41 = text42;
						text7 = text;
						num3 = unchecked((nint)null);
						obj21 = null;
						obj22 = null;
						state = now;
						stringBuilder = stringBuilder3;
						flag15 = force;
						if (flag204)
						{
							goto IL_73f5;
						}
						StringBuilder stringBuilder7 = stringBuilder6.Append(text44);
						bool flag205 = stringBuilder7 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
						obj20 = (UnityEngine.Object)0;
						val = (Enumerator<, >)0;
						num2 = 0;
						val2 = (Enumerator<, >)0;
						flag12 = false;
						flag13 = flag183;
						flag14 = flag9;
						flag3 = flag9;
						text2 = text43;
						num15 = num92;
						num6 = num93;
						array3 = (string[])b;
						array = (string[])b2;
						num20 = (int)text44;
						flag23 = false;
						text6 = null;
						val5 = (Enumerator<, >)(ref val19);
						text41 = text42;
						text7 = text;
						num3 = unchecked((nint)null);
						obj21 = (UnityEngine.Object)(object)text44;
						obj22 = null;
						state = now;
						stringBuilder = stringBuilder3;
						flag15 = force;
						if (flag205)
						{
							goto IL_73d9;
						}
						StringBuilder stringBuilder8 = stringBuilder7.Append((string)null);
						bool flag206 = stringBuilder8 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
						obj20 = (UnityEngine.Object)0;
						val = (Enumerator<, >)0;
						num2 = 0;
						val2 = (Enumerator<, >)0;
						flag12 = false;
						flag13 = flag183;
						flag14 = flag9;
						flag3 = flag9;
						text2 = text43;
						num15 = num92;
						num6 = num93;
						array3 = (string[])b;
						array = (string[])b2;
						num20 = (int)text44;
						flag23 = false;
						text6 = null;
						val5 = (Enumerator<, >)(ref val19);
						text41 = text42;
						text7 = text;
						num3 = unchecked((nint)null);
						obj21 = null;
						obj22 = null;
						state = now;
						stringBuilder = stringBuilder3;
						flag15 = force;
						if (flag206)
						{
							goto IL_742d;
						}
						StringBuilder stringBuilder9 = stringBuilder8.Append(num93);
						bool flag207 = stringBuilder9 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
						obj20 = (UnityEngine.Object)0;
						val = (Enumerator<, >)0;
						num2 = 0;
						val2 = (Enumerator<, >)0;
						flag12 = false;
						flag13 = flag183;
						flag14 = flag9;
						flag3 = flag9;
						text2 = text43;
						num15 = num92;
						num6 = num93;
						array3 = (string[])b;
						array = (string[])b2;
						num20 = (int)text44;
						flag23 = false;
						text6 = null;
						val5 = (Enumerator<, >)(ref val19);
						text41 = text42;
						text7 = text;
						num3 = unchecked((nint)null);
						obj21 = (UnityEngine.Object)num93;
						obj22 = null;
						state = now;
						stringBuilder = stringBuilder3;
						flag15 = force;
						if (flag207)
						{
							goto IL_743b;
						}
						bool flag208 = (byte)(num92 & 1) != 0;
						StringBuilder stringBuilder10 = stringBuilder9.Append(flag208);
						bool flag209 = stringBuilder10 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
						obj20 = (UnityEngine.Object)0;
						val = (Enumerator<, >)0;
						num2 = 0;
						val2 = (Enumerator<, >)0;
						flag12 = false;
						flag13 = flag183;
						flag14 = flag9;
						flag3 = flag9;
						text2 = text43;
						num15 = num92;
						num6 = num93;
						array3 = (string[])b;
						array = (string[])b2;
						num20 = (int)text44;
						flag23 = false;
						text6 = null;
						val5 = (Enumerator<, >)(ref val19);
						text41 = text42;
						text7 = text;
						num3 = unchecked((nint)null);
						obj21 = (UnityEngine.Object)flag208;
						obj22 = null;
						state = now;
						stringBuilder = stringBuilder3;
						flag15 = force;
						if (flag209)
						{
							goto IL_7403;
						}
						bool flag210 = (byte)(obj327 & 1) != 0;
						StringBuilder stringBuilder11 = stringBuilder10.Append(flag210);
						bool flag211 = stringBuilder11 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
						obj20 = (UnityEngine.Object)0;
						val = (Enumerator<, >)0;
						num2 = 0;
						val2 = (Enumerator<, >)0;
						flag12 = false;
						flag13 = flag183;
						flag14 = flag9;
						flag3 = flag9;
						text2 = text43;
						num15 = num92;
						num6 = num93;
						array3 = (string[])b;
						array = (string[])b2;
						num20 = (int)text44;
						flag23 = false;
						text6 = null;
						val5 = (Enumerator<, >)(ref val19);
						text41 = text42;
						text7 = text;
						num3 = unchecked((nint)null);
						obj21 = (UnityEngine.Object)flag210;
						obj22 = null;
						state = now;
						stringBuilder = stringBuilder3;
						flag15 = force;
						if (flag211)
						{
							goto IL_7449;
						}
						StringBuilder stringBuilder12 = stringBuilder11.Append(b2);
						bool flag212 = stringBuilder12 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
						obj20 = (UnityEngine.Object)0;
						val = (Enumerator<, >)0;
						num2 = 0;
						val2 = (Enumerator<, >)0;
						flag12 = false;
						flag13 = flag183;
						flag14 = flag9;
						flag3 = flag9;
						text2 = text43;
						num15 = num92;
						num6 = num93;
						array3 = (string[])b;
						array = (string[])b2;
						num20 = (int)text44;
						flag23 = false;
						text6 = null;
						val5 = (Enumerator<, >)(ref val19);
						text41 = text42;
						text7 = text;
						num3 = unchecked((nint)null);
						obj21 = (UnityEngine.Object)b2;
						obj22 = null;
						state = now;
						stringBuilder = stringBuilder3;
						flag15 = force;
						if (flag212)
						{
							goto IL_7457;
						}
						StringBuilder stringBuilder13 = stringBuilder12.Append(b);
						bool flag213 = stringBuilder13 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
						obj20 = (UnityEngine.Object)0;
						val = (Enumerator<, >)0;
						num2 = 0;
						val2 = (Enumerator<, >)0;
						flag12 = false;
						flag13 = flag183;
						flag14 = flag9;
						flag3 = flag9;
						text2 = text43;
						num15 = num92;
						num6 = num93;
						array3 = (string[])b;
						array = (string[])b2;
						num20 = (int)text44;
						flag23 = false;
						text6 = null;
						val5 = (Enumerator<, >)(ref val19);
						text41 = text42;
						text7 = text;
						num3 = unchecked((nint)null);
						obj21 = (UnityEngine.Object)b;
						obj22 = null;
						state = now;
						stringBuilder = stringBuilder3;
						flag15 = force;
						if (!flag213)
						{
							StringBuilder stringBuilder14 = stringBuilder13.Append(b3);
							bool flag214 = stringBuilder14 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
							obj20 = (UnityEngine.Object)0;
							val = (Enumerator<, >)0;
							num2 = 0;
							val2 = (Enumerator<, >)0;
							flag12 = false;
							flag13 = flag183;
							flag14 = flag9;
							flag3 = flag9;
							text2 = text43;
							num15 = num92;
							num6 = num93;
							array3 = (string[])b;
							array = (string[])b2;
							num20 = (int)text44;
							flag23 = false;
							text6 = null;
							val5 = (Enumerator<, >)(ref val19);
							text41 = text42;
							text7 = text;
							num3 = unchecked((nint)null);
							obj21 = (UnityEngine.Object)b3;
							obj22 = null;
							state = now;
							stringBuilder = stringBuilder3;
							flag15 = force;
							if (!flag214)
							{
								StringBuilder stringBuilder15 = stringBuilder14.Append('|');
								text2 = text43;
								num15 = num92;
								num6 = num93;
								array3 = (string[])b;
								array = (string[])b2;
								num20 = (int)text44;
								num3 = unchecked((nint)null);
								obj22 = null;
								continue;
							}
							goto IL_7465;
						}
						goto IL_7473;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v1+8]");
					obj20 = (UnityEngine.Object)0;
					val = (Enumerator<, >)0;
					num2 = 0;
					val2 = (Enumerator<, >)0;
					num35 = 0;
					flag12 = false;
					flag13 = flag183;
					flag14 = flag9;
					flag3 = flag9;
					flag23 = false;
					text6 = null;
					val5 = (Enumerator<, >)(ref val19);
					text41 = text42;
					text7 = text;
					state = now;
					object obj328 = 17;
					string text45 = null;
					stringBuilder = stringBuilder3;
					flag15 = force;
					object obj335 = default;
					string[] array6 = default;
					object obj338 = default;
					Texture2D texture2D = default;
					UnityEngine.Object obj436 = default;
					ScreenFont screenFont5 = default;
					ScreenFont screenFont6 = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D17C0]");
						object obj329 = 0;
						obj21 = (UnityEngine.Object)obj329;
						((Enumerator<, >*)val5)->Dispose();
						bool flag215 = text45 == null;
						object obj330 = !flag215;
						string text46;
						float num43;
						if (obj330 == null)
						{
							bool flag216 = !flag23;
							object obj331 = !flag216;
							text46 = (string)obj329;
							OutOfMemoryException ex13 = (OutOfMemoryException)val5;
							if (obj331 == null)
							{
								if ((nint)obj328 != 17)
								{
									bool flag217 = obj328 == null;
									object obj332 = !flag217;
									if (obj332 != null)
									{
										return;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
								obj22 = (UnityEngine.Object)0;
								int num94 = 0;
								while (true)
								{
									float num95 = Held(num94);
									nint num96 = (nint)obj22;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3852 @ X0_v21 (Il2CppClass<UnityEngine.Object>)+E4]");
									bool flag218 = (nint)0 == 0;
									object obj333 = !flag218;
									if (obj333 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									num27 = num95 * 20f;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
									Enumerator<, > val20;
									Enumerator<, > val21;
									if (num27 < 0f)
									{
										if ((double)num27 == -0.5)
										{
											num14 = (double)val5 + -1.0;
											val20 = val5;
											val21 = val5;
											goto IL_79b0;
										}
										float num97 = num27 + -0.5f;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
										val3 = (Enumerator<, >)num97;
									}
									else
									{
										if ((double)num27 == 0.5)
										{
											num14 = (double)val5 + 1.0;
											val20 = val5;
											val21 = val5;
											goto IL_79b0;
										}
										float num98 = num27 + 0.5f;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
										val3 = (Enumerator<, >)num98;
									}
									goto IL_79eb;
									IL_79eb:
									bool flag219 = stringBuilder == null;
									array3 = (string[])num94;
									num43 = num27;
									obj21 = (UnityEngine.Object)num94;
									if (flag219)
									{
										break;
									}
									StringBuilder stringBuilder16 = stringBuilder.Append((int)val3);
									num94++;
									bool flag220 = num94 != 10;
									num3 = unchecked((nint)null);
									if (flag220)
									{
										continue;
									}
									goto IL_16e1;
									IL_79b0:
									object obj334 = val21 & 1;
									val3 = ((obj334 != null) ? ((Enumerator<, >)num14) : val20);
									goto IL_79eb;
								}
								break;
							}
						}
						else
						{
							OutOfMemoryException ex13 = new OutOfMemoryException();
							text46 = (string)(object)obj21;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						goto IL_74cd;
						IL_74cd:
						NullReferenceException ex14 = new NullReferenceException();
						if ((nint)text46 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							flag23 = true;
							text45 = text6;
						}
						else
						{
							if ((nint)text46 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0EC0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							text45 = (string)obj335;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							text6 = (string)obj335;
						}
						num35 = 0;
						obj328 = 0;
						continue;
						IL_16e1:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
						object obj336 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						nint num99 = (nint)stringBuilder;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1134 @ X8_v20 (Il2CppClass<System.Text.StringBuilder>)+168]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1134 @ X8_v20 (Il2CppClass<System.Text.StringBuilder>)+170]");
						obj21 = (UnityEngine.Object)0;
						((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
						bool flag221 = array6 == null;
						array3 = array6;
						num43 = num27;
						num3 = unchecked((nint)null);
						if (flag221)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
						stringBuilder = (StringBuilder)0;
						bool flag222 = array6.Length == 0;
						array3 = array6;
						num43 = num27;
						num3 = unchecked((nint)null);
						if (!flag222)
						{
							object obj337 = array6 + 32;
							obj337 = obj338;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D17F8]");
							obj27 = 0;
							string text47 = ((Enum)(&val5)).ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2947 @ X20_v12-8]");
							object obj339 = 0 & 0xFFFFFFFEL;
							bool flag223 = obj339 == null;
							flag3 = (byte)this.page != 0;
							array3 = array6;
							flag23 = (byte)this.page != 0;
							text6 = (string)(-1);
							val5 = (Enumerator<, >)obj27;
							num43 = num27;
							num3 = unchecked((nint)null);
							obj21 = null;
							text = (string)(-1);
							if (!flag223)
							{
								object obj340 = array6 + 40;
								obj340 = text47;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2948 @ X20_v14-10]");
								bool flag224 = (nint)0 < (nint)2;
								object obj341 = !flag224;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2948 @ X20_v14-10]");
								object obj342 = -2;
								bool flag225 = obj342 == null;
								object obj343 = ~obj341;
								object obj344 = obj343 | flag225;
								flag3 = (byte)this.page != 0;
								array3 = array6;
								flag23 = (byte)this.page != 0;
								text6 = (string)(-1);
								val5 = (Enumerator<, >)obj27;
								num43 = num27;
								num3 = unchecked((nint)null);
								obj21 = (UnityEngine.Object)(object)text47;
								text = (string)(-1);
								if (obj344 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1888]");
									object obj345 = 0;
									object obj346 = array6 + 48;
									obj346 = obj345;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									int num100 = this + 312;
									string text48 = ((int*)num100)->ToString();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2949 @ X20_v16-18]");
									object obj347 = 0 & 0xFFFFFFFCL;
									bool flag226 = obj347 == null;
									flag3 = (byte)this.page != 0;
									array3 = array6;
									flag23 = (byte)this.page != 0;
									text6 = (string)(-1);
									val5 = (Enumerator<, >)obj27;
									num43 = num27;
									num3 = unchecked((nint)null);
									obj21 = null;
									text = (string)(-1);
									if (!flag226)
									{
										object obj348 = array6 + 56;
										obj348 = text48;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2950 @ X20_v18-20]");
										bool flag227 = (nint)0 < (nint)4;
										object obj349 = !flag227;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2950 @ X20_v18-20]");
										object obj350 = -4;
										bool flag228 = obj350 == null;
										object obj351 = ~obj349;
										object obj352 = obj351 | flag228;
										flag3 = (byte)this.page != 0;
										array3 = array6;
										flag23 = (byte)this.page != 0;
										text6 = (string)(-1);
										val5 = (Enumerator<, >)obj27;
										num43 = num27;
										num3 = unchecked((nint)null);
										obj21 = (UnityEngine.Object)(object)text48;
										text = (string)(-1);
										if (obj352 == null)
										{
											object obj353 = array6 + 64;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4488 @ X0_v175 (GillaLeaderboard)+108]");
											obj353 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											num7 = this + 296;
											string text49 = ((int*)num7)->ToString();
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2951 @ X20_v20-28]");
											bool flag229 = (nint)0 < (nint)5;
											object obj354 = !flag229;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2951 @ X20_v20-28]");
											object obj355 = -5;
											bool flag230 = obj355 == null;
											object obj356 = ~obj354;
											object obj357 = obj356 | flag230;
											flag3 = (byte)this.page != 0;
											num6 = num7;
											array3 = array6;
											flag23 = (byte)this.page != 0;
											text6 = (string)(-1);
											val5 = (Enumerator<, >)obj27;
											num43 = num27;
											num3 = unchecked((nint)null);
											obj21 = null;
											text = (string)(-1);
											if (obj357 == null)
											{
												object obj358 = array6 + 72;
												obj358 = text49;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												int num101 = (int)(((int*)num7)->m_value & 0x80000000L);
												bool flag231 = num101 == 0;
												object obj359 = !flag231;
												if (obj359 == null)
												{
													float time2 = Time.time;
													nint num102 = (nint)obj22;
													num43 = sendAt - time2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4007 @ X0_v601 (Il2CppClass<UnityEngine.Object>)+E4]");
													bool flag232 = (nint)0 == 0;
													object obj360 = !flag232;
													if (obj360 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
													val3 = (Enumerator<, >)time2;
												}
												else
												{
													num43 = num27;
												}
												string text50 = num35.ToString();
												bool flag233 = array6.Length < 6;
												object obj361 = !flag233;
												object obj362 = array6.Length - 6;
												bool flag234 = obj362 == null;
												object obj363 = ~obj361;
												object obj364 = obj363 | flag234;
												flag3 = (byte)this.page != 0;
												num6 = num7;
												array3 = array6;
												flag23 = (byte)this.page != 0;
												text6 = (string)(-1);
												val5 = (Enumerator<, >)obj27;
												num3 = unchecked((nint)null);
												obj21 = null;
												text = (string)(-1);
												if (obj364 == null)
												{
													object obj365 = array6 + 80;
													obj365 = text50;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2952 @ X20_v22-38]");
													object obj366 = 0 & 0xFFFFFFF8L;
													bool flag235 = obj366 == null;
													flag3 = (byte)this.page != 0;
													num6 = num7;
													array3 = array6;
													flag23 = (byte)this.page != 0;
													text6 = (string)(-1);
													val5 = (Enumerator<, >)obj27;
													num3 = unchecked((nint)null);
													obj21 = (UnityEngine.Object)(object)text50;
													text = (string)(-1);
													if (!flag235)
													{
														bool flag236 = !flag161;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
														text = (string)0;
														object obj367 = !flag236;
														string text51;
														if ((int)(~obj367) == 0)
														{
															text51 = text41;
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
															text51 = (string)0;
														}
														obj21 = (UnityEngine.Object)(object)text51;
														object obj368 = array6 + 88;
														obj368 = text51;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														if (flag162)
														{
															nint num103 = (nint)stringBuilder;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4036 @ X0_v588 (Il2CppClass<System.Text.StringBuilder>)+E4]");
															bool flag237 = (nint)0 == 0;
															object obj369 = !flag237;
															if (obj369 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															nint num104 = (nint)stringBuilder;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4063 @ X0_v591 (Il2CppClass<System.Text.StringBuilder>)+E4]");
															bool flag238 = (nint)0 == 0;
															object obj370 = !flag238;
															nint num105 = num104;
															if (obj370 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																num105 = (nint)stringBuilder;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4041 @ X0_v592 (Il2CppClass<System.Text.StringBuilder>)+A0]");
															string text52 = (string)((nint)0 + (nint)48);
															text7 = text52;
														}
														bool flag239 = array6.Length < 8;
														object obj371 = !flag239;
														object obj372 = array6.Length - 8;
														bool flag240 = obj372 == null;
														object obj373 = ~obj371;
														object obj374 = obj373 | flag240;
														flag3 = (byte)this.page != 0;
														num6 = num7;
														array3 = array6;
														flag23 = (byte)this.page != 0;
														text6 = (string)(-1);
														val5 = (Enumerator<, >)obj27;
														num3 = unchecked((nint)null);
														if (obj374 == null)
														{
															object obj375 = array6 + 96;
															obj375 = text7;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
															object obj376 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ X19_v12+30]");
															object obj377 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4067 @ X0_v62+E4]");
															bool flag241 = (nint)0 == 0;
															object obj378 = !flag241;
															if (obj378 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															string text53 = flag14.ToString();
															bool flag242 = array6.Length < 9;
															object obj379 = !flag242;
															object obj380 = array6.Length - 9;
															bool flag243 = obj380 == null;
															object obj381 = ~obj379;
															object obj382 = obj381 | flag243;
															flag3 = (byte)this.page != 0;
															num6 = num7;
															array3 = array6;
															flag23 = (byte)this.page != 0;
															text6 = (string)(-1);
															val5 = (Enumerator<, >)obj27;
															num3 = unchecked((nint)null);
															obj21 = null;
															if (obj382 == null)
															{
																object obj383 = array6 + 104;
																obj383 = text53;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																string text54 = flag13.ToString();
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2953 @ X20_v24-50]");
																bool flag244 = (nint)0 < (nint)10;
																object obj384 = !flag244;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2953 @ X20_v24-50]");
																object obj385 = -10;
																bool flag245 = obj385 == null;
																object obj386 = ~obj384;
																object obj387 = obj386 | flag245;
																flag3 = (byte)this.page != 0;
																num6 = num7;
																array3 = array6;
																flag23 = (byte)this.page != 0;
																text6 = (string)(-1);
																val5 = (Enumerator<, >)obj27;
																num3 = unchecked((nint)null);
																obj21 = null;
																if (obj387 == null)
																{
																	object obj388 = array6 + 112;
																	obj388 = text54;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
																	object obj389 = 0;
																	object obj390 = obj389;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4091 @ X0_v73+E4]");
																	bool flag246 = (nint)0 == 0;
																	object obj391 = !flag246;
																	if (obj391 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	}
																	bool flag247 = obj20 != null;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
																	object obj392 = 0;
																	if (flag247)
																	{
																		bool flag248 = (object)obj20 == null;
																		flag3 = (byte)this.page != 0;
																		num6 = num7;
																		array3 = array6;
																		flag23 = (byte)this.page != 0;
																		text6 = (string)(-1);
																		val5 = (Enumerator<, >)obj27;
																		num3 = unchecked((nint)null);
																		obj21 = null;
																		if (flag248)
																		{
																			break;
																		}
																		obj392 = obj20 + 120;
																	}
																	text = (string)array6.Length;
																	bool flag249 = array6.Length < 11;
																	object obj393 = !flag249;
																	object obj394 = array6.Length - 11;
																	bool flag250 = obj394 == null;
																	object obj395 = ~obj393;
																	object obj396 = obj395 | flag250;
																	flag3 = (byte)this.page != 0;
																	num6 = num7;
																	array3 = array6;
																	flag23 = (byte)this.page != 0;
																	text6 = (string)(-1);
																	val5 = (Enumerator<, >)obj27;
																	num3 = unchecked((nint)null);
																	obj21 = null;
																	if (obj396 == null)
																	{
																		object obj397 = array6 + 120;
																		obj397 = obj392;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		nint num106 = (nint)stringBuilder;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4108 @ X0_v80 (Il2CppClass<System.Text.StringBuilder>)+E4]");
																		bool flag251 = (nint)0 == 0;
																		object obj398 = !flag251;
																		if (obj398 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		}
																		offline = GillaFriends.Offline;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ X19_v12+30]");
																		object obj399 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4117 @ X0_v84+E4]");
																		text = (string)0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4117 @ X0_v84+E4]");
																		bool flag252 = (nint)0 == 0;
																		object obj400 = !flag252;
																		if (obj400 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		}
																		string text55 = flag12.ToString();
																		bool flag253 = array6.Length < 12;
																		object obj401 = !flag253;
																		object obj402 = array6.Length - 12;
																		bool flag254 = obj402 == null;
																		object obj403 = ~obj401;
																		object obj404 = obj403 | flag254;
																		flag3 = (byte)this.page != 0;
																		num6 = num7;
																		array3 = array6;
																		flag23 = (byte)this.page != 0;
																		text6 = (string)(-1);
																		val5 = (Enumerator<, >)obj27;
																		num3 = unchecked((nint)null);
																		obj21 = null;
																		if (obj404 == null)
																		{
																			object obj405 = array6 + 128;
																			obj405 = text55;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			nint num107 = (nint)stringBuilder;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4137 @ X0_v92 (Il2CppClass<System.Text.StringBuilder>)+E4]");
																			bool flag255 = (nint)0 == 0;
																			object obj406 = !flag255;
																			nint num108 = num107;
																			if (obj406 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																				num108 = (nint)stringBuilder;
																			}
																			bool flag256 = array6.Length < 13;
																			object obj407 = !flag256;
																			object obj408 = array6.Length - 13;
																			bool flag257 = obj408 == null;
																			object obj409 = ~obj407;
																			object obj410 = obj409 | flag257;
																			flag12 = offline;
																			flag3 = (byte)this.page != 0;
																			num6 = num7;
																			array3 = array6;
																			flag23 = (byte)this.page != 0;
																			text6 = (string)(-1);
																			val5 = (Enumerator<, >)obj27;
																			num3 = unchecked((nint)null);
																			obj21 = (UnityEngine.Object)(object)text55;
																			if (obj410 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2873 @ X0_v93 (Il2CppClass<System.Text.StringBuilder>)+A0]");
																				object obj411 = 0;
																				object obj412 = array6 + 136;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4144 @ X8_v60+28]");
																				obj412 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				int unseen4 = GillaFriends.Unseen;
																				string text56 = num35.ToString();
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1172 @ X20_v27-70]");
																				bool flag258 = (nint)0 < (nint)14;
																				object obj413 = !flag258;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1172 @ X20_v27-70]");
																				object obj414 = -14;
																				bool flag259 = obj414 == null;
																				object obj415 = ~obj413;
																				object obj416 = obj415 | flag259;
																				flag12 = offline;
																				flag3 = (byte)this.page != 0;
																				num6 = num7;
																				array3 = array6;
																				flag23 = (byte)this.page != 0;
																				text6 = (string)(-1);
																				val5 = (Enumerator<, >)obj27;
																				num3 = unchecked((nint)null);
																				obj21 = null;
																				if (obj416 == null)
																				{
																					object obj417 = array6 + 144;
																					obj417 = text56;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																					bool flag260 = state == null;
																					flag12 = offline;
																					flag3 = (byte)this.page != 0;
																					num6 = num7;
																					array3 = array6;
																					flag23 = (byte)this.page != 0;
																					text6 = (string)(-1);
																					val5 = (Enumerator<, >)obj27;
																					num3 = unchecked((nint)null);
																					obj21 = (UnityEngine.Object)(object)text56;
																					if (flag260)
																					{
																						break;
																					}
																					asking = state.asking;
																					bool flag261 = state.asking == null;
																					flag12 = offline;
																					flag3 = (byte)this.page != 0;
																					num6 = num7;
																					array3 = array6;
																					flag23 = (byte)this.page != 0;
																					text6 = (string)(-1);
																					val5 = (Enumerator<, >)obj27;
																					num3 = unchecked((nint)null);
																					obj21 = (UnityEngine.Object)(object)text56;
																					if (flag261)
																					{
																						break;
																					}
																					string text57 = num35.ToString();
																					object obj418 = array6.Length & 0xFFFFFFF0L;
																					bool flag262 = obj418 == null;
																					flag12 = offline;
																					flag3 = (byte)this.page != 0;
																					num6 = num7;
																					array3 = array6;
																					flag23 = (byte)this.page != 0;
																					text6 = (string)(-1);
																					val5 = (Enumerator<, >)obj27;
																					num3 = unchecked((nint)null);
																					obj21 = null;
																					if (!flag262)
																					{
																						object obj419 = array6 + 152;
																						obj419 = text57;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																						string text58 = string.Concat(array6);
																						bool flag263 = !flag15;
																						object obj420 = !flag263;
																						nint num109 = unchecked((nint)null);
																						if (obj420 == null)
																						{
																							bool flag264 = text58 == shown;
																							bool flag265 = !flag264;
																							num109 = unchecked((nint)null);
																							if (!flag265)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
																								object obj421 = 0;
																								object obj422 = obj421;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4196 @ X0_v574+E4]");
																								bool flag266 = (nint)0 == 0;
																								object obj423 = !flag266;
																								if (obj423 == null)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																								}
																								bool flag267 = tex != null;
																								bool flag268 = !flag267;
																								object obj424 = !flag268;
																								num109 = unchecked((nint)null);
																								text = (string)(object)this;
																								if (obj424 != null)
																								{
																									return;
																								}
																							}
																						}
																						object obj425 = this + 232;
																						obj425 = text58;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
																						object obj426 = 0;
																						object obj427 = this + 192;
																						object obj428 = obj426;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4190 @ X0_v114+E4]");
																						bool flag269 = (nint)0 == 0;
																						object obj429 = !flag269;
																						if (obj429 == null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																						}
																						bool flag270 = (UnityEngine.Object)obj427 == null;
																						bool flag271 = !flag270;
																						object obj430 = 0;
																						UnityEngine.Object obj431 = null;
																						if (!flag271)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
																							object obj432 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																							texture2D._002Ector(320, 240, (TextureFormat)4, mipChain: true);
																							bool flag272 = (object)texture2D == null;
																							style = (ShiftAuth.Style)0;
																							flag21 = true;
																							textureFormat = (TextureFormat)4;
																							flag12 = offline;
																							flag3 = (byte)this.page != 0;
																							num6 = num7;
																							array3 = array6;
																							flag23 = (byte)this.page != 0;
																							text6 = (string)(-1);
																							val5 = (Enumerator<, >)obj27;
																							num3 = 240;
																							obj21 = (UnityEngine.Object)320;
																							stringBuilder = (StringBuilder)(object)texture2D;
																							if (flag272)
																							{
																								break;
																							}
																							texture2D.filterMode = (FilterMode)0;
																							texture2D.wrapMode = (TextureWrapMode)1;
																							texture2D.hideFlags = (HideFlags)52;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1828]");
																							object obj433 = 0;
																							texture2D.name = (string)obj433;
																							tex = texture2D;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
																							object obj434 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																							object obj435 = this + 200;
																							obj435 = obj436;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							style = (ShiftAuth.Style)0;
																							flag21 = true;
																							textureFormat = (TextureFormat)4;
																							obj430 = 0;
																							obj431 = obj436;
																						}
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
																						object obj437 = 0;
																						object obj438 = obj437;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4229 @ X0_v119+E4]");
																						bool flag273 = (nint)0 == 0;
																						object obj439 = !flag273;
																						if (obj439 == null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																						}
																						GillaBoardLook.Clear(px, 320, 240);
																						GillaBoardLook.Frame(px, 320, 240, 3);
																						array3 = (string[])(this + 216);
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
																						stringBuilder = (StringBuilder)0;
																						bool flag274 = array3 == null;
																						object obj440 = !flag274;
																						int num110 = 240;
																						int num111 = 320;
																						if (obj440 == null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
																							object obj441 = 0;
																							object obj442 = obj441;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4256 @ X0_v545+E4]");
																							bool flag275 = (nint)0 == 0;
																							object obj443 = !flag275;
																							if (obj443 == null)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																							}
																							bool flag276 = titleFont != null;
																							bool flag277 = !flag276;
																							num110 = 0;
																							int num112 = 0;
																							if (!flag277)
																							{
																								bool flag278 = (object)titleFont == null;
																								flag21 = false;
																								textureFormat = (TextureFormat)3;
																								flag12 = offline;
																								flag3 = (byte)this.page != 0;
																								num6 = num7;
																								flag23 = (byte)this.page != 0;
																								text6 = (string)(-1);
																								val5 = (Enumerator<, >)obj27;
																								num3 = unchecked((nint)null);
																								obj21 = null;
																								if (flag278)
																								{
																									break;
																								}
																								string baked = titleFont.text;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
																								object obj444 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																								screenFont5._002Ector(baked);
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
																								stringBuilder = (StringBuilder)0;
																								num110 = 0;
																								num112 = (int)screenFont5;
																							}
																							array3 = (string[])num112;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							num111 = num112;
																						}
																						text8 = (string)(this + 224);
																						bool flag279 = text8 == null;
																						object obj445 = !flag279;
																						num3 = num110;
																						obj21 = (UnityEngine.Object)num111;
																						if (obj445 == null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
																							object obj446 = 0;
																							object obj447 = obj446;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4286 @ X0_v533+E4]");
																							bool flag280 = (nint)0 == 0;
																							object obj448 = !flag280;
																							if (obj448 == null)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																							}
																							bool flag281 = textFont != null;
																							bool flag282 = !flag281;
																							num3 = unchecked((nint)null);
																							UnityEngine.Object obj449 = null;
																							if (!flag282)
																							{
																								bool flag283 = (object)textFont == null;
																								flag21 = false;
																								textureFormat = (TextureFormat)3;
																								flag12 = offline;
																								flag3 = (byte)this.page != 0;
																								num6 = num7;
																								flag23 = (byte)this.page != 0;
																								text6 = (string)(-1);
																								val5 = (Enumerator<, >)obj27;
																								text7 = text8;
																								num3 = unchecked((nint)null);
																								obj21 = null;
																								text = text8;
																								if (flag283)
																								{
																									break;
																								}
																								string baked2 = textFont.text;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
																								object obj450 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																								screenFont6._002Ector(baked2);
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
																								stringBuilder = (StringBuilder)0;
																								num3 = unchecked((nint)null);
																								obj449 = (UnityEngine.Object)(object)screenFont6;
																							}
																							text8 = (string)(object)obj449;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							obj21 = obj449;
																						}
																						nint num113 = (nint)stringBuilder;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4299 @ X0_v125 (Il2CppClass<System.Text.StringBuilder>)+E4]");
																						bool flag284 = (nint)0 == 0;
																						object obj451 = !flag284;
																						nint num114 = num113;
																						if (obj451 == null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																							num114 = (nint)stringBuilder;
																						}
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
																						UnityEngine.Object obj170 = (UnityEngine.Object)0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1073 @ X0_v126 (Il2CppClass<System.Text.StringBuilder>)+A0]");
																						object obj452 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4316 @ X8_v80+10]");
																						object obj453 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4316 @ X8_v80+10]");
																						bool flag285 = (nint)0 == 0;
																						flag21 = false;
																						textureFormat = (TextureFormat)3;
																						flag12 = offline;
																						flag3 = (byte)this.page != 0;
																						num6 = num7;
																						flag23 = (byte)this.page != 0;
																						text6 = (string)(-1);
																						val5 = (Enumerator<, >)obj27;
																						text7 = text8;
																						text = text8;
																						if (flag285)
																						{
																							break;
																						}
																						text = (string)this.page;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1162 @ X8_v81+18]");
																						flag3 = false;
																						Page page4 = this.page;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1162 @ X8_v81+18]");
																						bool flag286 = (nint)page4 < (nint)0;
																						object obj454 = !flag286;
																						flag21 = false;
																						textureFormat = (TextureFormat)3;
																						flag12 = offline;
																						num6 = num7;
																						flag23 = (byte)this.page != 0;
																						text6 = (string)(-1);
																						val5 = (Enumerator<, >)obj27;
																						text7 = text8;
																						if (obj454 == null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4316 @ X8_v80+10]");
																							object obj455 = (nint)0 + (nint)this.page;
																							nint num115 = (nint)obj170;
																							screenFont3 = (ScreenFont)(object)array3;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4369 @ X0_v128 (Il2CppClass<UnityEngine.Object>)+E4]");
																							bool flag287 = (nint)0 == 0;
																							object obj456 = !flag287;
																							if (obj456 == null)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																								num115 = (nint)obj170;
																								obj22 = obj170;
																							}
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4369 @ X0_v128 (Il2CppClass<UnityEngine.Object>)+A0]");
																							obj147 = 0;
																							object obj457 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val2, 16));
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							ScreenFont font2 = screenFont3;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
																							Line(font2, 12, 8, (string)0, (ShiftAuth.Style)(&val4), centred: false);
																							ScreenFont font3 = title;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
																							int num116 = Measure(font3, (string)0, 2);
																							num8 = 286 - num116;
																							bool flag288 = !flag13;
																							object obj458 = !flag288;
																							if (obj458 == null && this.page == 0)
																							{
																								goto IL_440d;
																							}
																							friends = state.friends;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
																							stringBuilder = (StringBuilder)0;
																							bool flag289 = state.friends == null;
																							num2 = 0;
																							val4 = val2;
																							flag20 = false;
																							style = (ShiftAuth.Style)(&val4);
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
																							flag21 = false;
																							textureFormat = (TextureFormat)8;
																							flag12 = offline;
																							num6 = num7;
																							array3 = (string[])num8;
																							flag23 = (byte)this.page != 0;
																							text6 = (string)(-1);
																							val5 = (Enumerator<, >)obj27;
																							text7 = text8;
																							num14 = (double)obj147;
																							val3 = val2;
																							num3 = 2;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4349 @ X8_v82+20]");
																							text46 = (string)0;
																							text = (string)286;
																							if (!flag289)
																							{
																								goto IL_2fb5;
																							}
																							goto IL_74cd;
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
						goto IL_7481;
					}
				}
			}
		}
		goto IL_73cb;
		IL_7473:
		NullReferenceException ex15 = new NullReferenceException();
		goto IL_7481;
		IL_8e16:
		text4 = (string)((bool*)(flag169 ? 1 : 0))->m_value;
		goto IL_8e8a;
		IL_7403:
		NullReferenceException ex16 = new NullReferenceException();
		goto IL_7411;
		IL_749d:
		throw new NullReferenceException();
		IL_741f:
		NullReferenceException ex17 = new NullReferenceException();
		goto IL_742d;
		IL_8e8a:
		nint num117 = (nint)stringBuilder;
		screenFont4 = (ScreenFont)(object)text8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5646 @ X0_v220 (Il2CppClass<System.Text.StringBuilder>)+E4]");
		bool flag290 = (nint)0 == 0;
		object obj459 = !flag290;
		nint num118 = num117;
		if (obj459 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num118 = (nint)stringBuilder;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5343 @ X0_v221 (Il2CppClass<UnityEngine.Object>)+A0]");
		obj228 = (nint)0 + (nint)16;
		obj306 = 0;
		obj22 = (UnityEngine.Object)(object)stringBuilder;
		text = (string)1;
		goto IL_8ed2;
	}

	private string Empty()
	{
		//IL_004e: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0090: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I
		//IL_0014: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I
		object obj = page - 1;
		bool flag = (nint)obj < 2;
		object obj2 = !flag;
		object obj3 = obj - 2;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 101789696 + 1264;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X9_v3+v36 @ X8_v4*8]");
			return (string)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6530]");
		return (string)0;
	}

	private string Fits(int width, string[] tries)
	{
		//IL_0019: Expected Obj, but got I8
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0056: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I4
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_01ad: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I
		//IL_01c3: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_0133: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got I4
		object obj;
		if (tries != null)
		{
			obj = tries.Length & 0xFFFFFFFFL;
			if (tries.Length < 1)
			{
				goto IL_015b;
			}
			object obj2 = tries + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
			object obj3 = 0;
			string[] array = tries;
			int num = width;
			object obj4 = 0;
			object obj5 = obj;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
				object obj6 = !flag;
				if (obj6 != null)
				{
					break;
				}
				object obj7 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				ScreenFont font = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X26_v5+v154 @ X24_v6*8]");
				int num2 = Measure(font, (string)0, 1);
				if (num2 > width)
				{
					obj = tries.Length;
					obj4++;
					bool flag3 = (nint)obj4 < tries.Length;
					array = (string[])1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X26_v5+v154 @ X24_v6*8]");
					num = 0;
					obj5 = tries.Length;
					if (flag3)
					{
						continue;
					}
					goto IL_015b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X26_v5+v154 @ X24_v6*8]");
				return (string)0;
			}
			goto IL_01c3;
		}
		goto IL_01d1;
		IL_015b:
		if (obj != null)
		{
			object obj9 = -4294967296L + obj;
			object obj10 = (object)tries + obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v9+20]");
			return Cut((string)0, width);
		}
		goto IL_01c3;
		IL_01d1:
		return (string)(object)new NullReferenceException();
		IL_01c3:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_01d1;
	}

	private string Cut(string s, int width)
	{
		//IL_0032: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I4
		//IL_01cc: Expected Obj, but got I4
		string result;
		if (string.IsNullOrEmpty(s))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj = 0;
			result = (string)obj;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = Measure(this.text, s, 1);
			bool flag2 = num <= width;
			result = s;
			if (!flag2)
			{
				bool flag3 = s == null;
				result = s;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A30]");
					object obj5 = 0;
					string text = s;
					while (true)
					{
						if (text._stringLength >= 2)
						{
							string s2 = text + (string)obj5;
							object obj6 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v9+E4]");
							bool flag4 = (nint)0 == 0;
							object obj7 = !flag4;
							if (obj7 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							int num2 = Measure(this.text, s2, 1);
							if (num2 > width)
							{
								int length = text._stringLength - 1;
								string text2 = text.Substring(0, length);
								bool flag5 = text2 == null;
								object obj8 = !flag5;
								result = text2;
								text = text2;
								if (obj8 == null)
								{
									break;
								}
								continue;
							}
						}
						return text + (string)obj5;
					}
				}
				throw new NullReferenceException();
			}
		}
		return result;
	}

	private static int Measure(ScreenFont font, string s, int scale)
	{
		//IL_002f: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I4
		if (font != null)
		{
			return font.Measure(s, scale);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return PixelFont.Measure(s, scale);
	}

	private unsafe void Line(ScreenFont font, int x, int y, string line, ShiftAuth.Style style, bool centred = default(bool))
	{
		//IL_0067: Expected Obj, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected I4, but got Unknown
		//IL_00df: Expected Obj, but got I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_031e: Expected I4, but got Obj
		//IL_02cb: Expected Ref, but got VT
		//IL_004b: Expected Ref, but got VT
		//IL_0133: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I4
		//IL_01dc: Expected Obj, but got I4
		//IL_029d: Expected VT, but got Ref
		int num2 = default;
		if (font != null)
		{
			if (centred)
			{
				int num = font.DrawCentred(px, 320, 240, num2, y, line, ref *(ShiftAuth.Style*)style);
			}
			else
			{
				int num3 = font.Draw(px, 320, 240, num2, y, line, ref *(ShiftAuth.Style*)style);
			}
			return;
		}
		object obj = style.scale - 1;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num4 = style.scale ^ 1;
		int num5 = style.scale ^ obj;
		int num6 = num4 & num5;
		bool flag3 = num6 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		int num7 = ((obj4 != null) ? 1 : style.scale);
		bool flag5 = !centred;
		int num8 = (int)font;
		int x2 = num2;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num9 = PixelFont.Measure(line, num7);
			bool flag7 = num9 < 0;
			int num10 = num9 ^ num9;
			int num11 = num9 & num10;
			bool flag8 = num11 < 0;
			bool flag9 = flag7 == flag8;
			object obj8 = !flag9;
			object obj9 = ~obj8;
			int num12 = ((obj9 != null) ? num9 : (num9 + 1));
			x2 = num2 - num12;
			num8 = num7;
		}
		Color32[] colours = style.colours;
		if (style.colours != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v7+E4]");
			bool flag10 = (nint)0 == 0;
			object obj12 = !flag10;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PixelFont.Draw(px, 320, 240, x2, y, line, (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref colours[0]), num7);
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void Fill(int x, int y, int w, int h, Color32 colour)
	{
		//IL_0010: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Color32 colour2 = (Color32)(colour & 0xFFFFFFFFL);
		PixelFont.Fill(px, 320, 240, x, y, w, h, colour2);
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0197: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(tex != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isPlaying = Application.isPlaying;
		object obj7 = obj;
		if (isPlaying)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(tex);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.DestroyImmediate(tex);
		}
	}

	public GillaLeaderboard()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01d3: Expected I4, but got I8
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6188]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A50]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj7 = this + 40;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj9 = this + 48;
		object obj10 = default;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj11 = this + 56;
		object obj12 = default;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj13 = this + 64;
		object obj14 = default;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj15 = this + 72;
		object obj16 = default;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj17 = this + 88;
		object obj18 = default;
		obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		watchFrom = 6f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Row> list = default;
		list._002Ector();
		object obj19 = this + 176;
		obj19 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Entry> list2 = default;
		list2._002Ector();
		object obj20 = this + 184;
		obj20 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj21 = this + 304;
		saidAt = -100f;
		chosen = -1;
		said = (string)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		float[] array = default;
		heldSince = array;
		object obj22 = this + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		bool[] array2 = default;
		spent = array2;
		object obj23 = this + 328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaLeaderboard()
	{
		//IL_0010: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I8
		//IL_00b1: Expected Obj, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0194: Expected Obj, but got I
		//IL_01f7: Expected Obj, but got I
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_0231: Expected Obj, but got I8
		//IL_025e: Expected Obj, but got I
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_02a0: Expected Obj, but got I4
		//IL_02b6: Expected Obj, but got I
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_02f9: Expected Obj, but got I
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0333: Expected Obj, but got I8
		//IL_0360: Expected Obj, but got I
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected Obj, but got Unknown
		//IL_03a2: Expected Obj, but got I4
		//IL_03b8: Expected Obj, but got I
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got Unknown
		//IL_03fb: Expected Obj, but got I
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected Obj, but got Unknown
		//IL_0439: Expected Obj, but got I
		//IL_0494: Expected Obj, but got I
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		//IL_04ce: Expected Obj, but got I8
		//IL_04fb: Expected Obj, but got I
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected Obj, but got Unknown
		//IL_053d: Expected Obj, but got I4
		//IL_0553: Expected Obj, but got I
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_0596: Expected Obj, but got I
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected Obj, but got Unknown
		//IL_05d0: Expected Obj, but got I8
		//IL_05fd: Expected Obj, but got I
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected Obj, but got Unknown
		//IL_063f: Expected Obj, but got I4
		//IL_0655: Expected Obj, but got I
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected Obj, but got Unknown
		//IL_0698: Expected Obj, but got I
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected Obj, but got Unknown
		//IL_06d6: Expected Obj, but got I
		//IL_0731: Expected Obj, but got I
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Expected Obj, but got Unknown
		//IL_076b: Expected Obj, but got I8
		//IL_0798: Expected Obj, but got I
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected Obj, but got Unknown
		//IL_07da: Expected Obj, but got I4
		//IL_07f0: Expected Obj, but got I
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected Obj, but got Unknown
		//IL_0833: Expected Obj, but got I
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Expected Obj, but got Unknown
		//IL_0871: Expected Obj, but got I
		//IL_08cc: Expected Obj, but got I
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Expected Obj, but got Unknown
		//IL_0906: Expected Obj, but got I8
		//IL_0933: Expected Obj, but got I
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0941: Expected Obj, but got Unknown
		//IL_0975: Expected Obj, but got I4
		//IL_098b: Expected Obj, but got I
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected Obj, but got Unknown
		//IL_09ce: Expected Obj, but got I
		//IL_09d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dc: Expected Obj, but got Unknown
		//IL_0a08: Expected Obj, but got I8
		//IL_0a35: Expected Obj, but got I
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a43: Expected Obj, but got Unknown
		//IL_0a77: Expected Obj, but got I4
		//IL_0a8d: Expected Obj, but got I
		//IL_0aad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab2: Expected Obj, but got Unknown
		//IL_0ad0: Expected Obj, but got I
		//IL_0ae0: Expected Obj, but got I
		//IL_0af0: Expected Obj, but got I
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Expected Obj, but got Unknown
		//IL_0b2f: Expected Obj, but got I
		//IL_0b6b: Expected Obj, but got I
		//IL_0ba6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBA60]");
			object obj2 = 0;
			object obj4 = default;
			object obj3 = obj4 + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X20_v4-8]");
			object obj5 = 0 & 0xFFFFFFFEL;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB9F0]");
				object obj6 = 0;
				object obj7 = obj4 + 40;
				obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X20_v6-10]");
				bool flag = (nint)0 < (nint)2;
				object obj8 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X20_v6-10]");
				object obj9 = -2;
				bool flag2 = obj9 == null;
				object obj10 = ~obj8;
				object obj11 = obj10 | flag2;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBA40]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1790]");
					object obj13 = 0;
					object obj14 = obj4 + 48;
					obj14 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj15 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v14+A0]");
					object obj16 = 0;
					obj16 = obj4;
					object obj17 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v18+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AB0]");
						object obj18 = 0;
						object obj20 = default;
						object obj19 = obj20 + 32;
						obj19 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X20_v8-8]");
						object obj21 = 0 & 0xFFFFFFFEL;
						if (obj21 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A98]");
							object obj22 = 0;
							object obj23 = obj20 + 40;
							obj23 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X20_v10-10]");
							bool flag3 = (nint)0 < (nint)2;
							object obj24 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X20_v10-10]");
							object obj25 = -2;
							bool flag4 = obj25 == null;
							object obj26 = ~obj24;
							object obj27 = obj26 | flag4;
							if (obj27 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AA8]");
								object obj28 = 0;
								object obj29 = obj20 + 48;
								obj29 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X20_v12-18]");
								object obj30 = 0 & 0xFFFFFFFCL;
								if (obj30 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D19F0]");
									object obj31 = 0;
									object obj32 = obj20 + 56;
									obj32 = obj31;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X20_v14-20]");
									bool flag5 = (nint)0 < (nint)4;
									object obj33 = !flag5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X20_v14-20]");
									object obj34 = -4;
									bool flag6 = obj34 == null;
									object obj35 = ~obj33;
									object obj36 = obj35 | flag6;
									if (obj36 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A78]");
										object obj37 = 0;
										object obj38 = obj20 + 64;
										obj38 = obj37;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj39 = obj13;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v32+A0]");
										object obj40 = (nint)0 + (nint)8;
										obj40 = obj20;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v34+18]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AA0]");
											object obj41 = 0;
											object obj43 = default;
											object obj42 = obj43 + 32;
											obj42 = obj41;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X20_v16-8]");
											object obj44 = 0 & 0xFFFFFFFEL;
											if (obj44 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A90]");
												object obj45 = 0;
												object obj46 = obj43 + 40;
												obj46 = obj45;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X20_v18-10]");
												bool flag7 = (nint)0 < (nint)2;
												object obj47 = !flag7;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X20_v18-10]");
												object obj48 = -2;
												bool flag8 = obj48 == null;
												object obj49 = ~obj47;
												object obj50 = obj49 | flag8;
												if (obj50 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A88]");
													object obj51 = 0;
													object obj52 = obj43 + 48;
													obj52 = obj51;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X20_v20-18]");
													object obj53 = 0 & 0xFFFFFFFCL;
													if (obj53 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A80]");
														object obj54 = 0;
														object obj55 = obj43 + 56;
														obj55 = obj54;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X20_v22-20]");
														bool flag9 = (nint)0 < (nint)4;
														object obj56 = !flag9;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X20_v22-20]");
														object obj57 = -4;
														bool flag10 = obj57 == null;
														object obj58 = ~obj56;
														object obj59 = obj58 | flag10;
														if (obj59 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A70]");
															object obj60 = 0;
															object obj61 = obj43 + 64;
															obj61 = obj60;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															object obj62 = obj13;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v48+A0]");
															object obj63 = (nint)0 + (nint)16;
															obj63 = obj43;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v50+18]");
															if ((nint)0 != 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1900]");
																object obj64 = 0;
																object obj66 = default;
																object obj65 = obj66 + 32;
																obj65 = obj64;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X20_v24-8]");
																object obj67 = 0 & 0xFFFFFFFEL;
																if (obj67 != null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1928]");
																	object obj68 = 0;
																	object obj69 = obj66 + 40;
																	obj69 = obj68;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X20_v26-10]");
																	bool flag11 = (nint)0 < (nint)2;
																	object obj70 = !flag11;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X20_v26-10]");
																	object obj71 = -2;
																	bool flag12 = obj71 == null;
																	object obj72 = ~obj70;
																	object obj73 = obj72 | flag12;
																	if (obj73 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D18F0]");
																		object obj74 = 0;
																		object obj75 = obj66 + 48;
																		obj75 = obj74;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		object obj76 = obj13;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v58+A0]");
																		object obj77 = (nint)0 + (nint)24;
																		obj77 = obj66;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v62+18]");
																		if ((nint)0 != 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1908]");
																			object obj78 = 0;
																			object obj80 = default;
																			object obj79 = obj80 + 32;
																			obj79 = obj78;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X20_v28-8]");
																			object obj81 = 0 & 0xFFFFFFFEL;
																			if (obj81 != null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1910]");
																				object obj82 = 0;
																				object obj83 = obj80 + 40;
																				obj83 = obj82;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X20_v30-10]");
																				bool flag13 = (nint)0 < (nint)2;
																				object obj84 = !flag13;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X20_v30-10]");
																				object obj85 = -2;
																				bool flag14 = obj85 == null;
																				object obj86 = ~obj84;
																				object obj87 = obj86 | flag14;
																				if (obj87 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1920]");
																					object obj88 = 0;
																					object obj89 = obj80 + 48;
																					obj89 = obj88;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X20_v32-18]");
																					object obj90 = 0 & 0xFFFFFFFCL;
																					if (obj90 != null)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1918]");
																						object obj91 = 0;
																						object obj92 = obj80 + 56;
																						obj92 = obj91;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X20_v34-20]");
																						bool flag15 = (nint)0 < (nint)4;
																						object obj93 = !flag15;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X20_v34-20]");
																						object obj94 = -4;
																						bool flag16 = obj94 == null;
																						object obj95 = ~obj93;
																						object obj96 = obj95 | flag16;
																						if (obj96 == null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D18F8]");
																							object obj97 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
																							object obj98 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47D0]");
																							object obj99 = 0;
																							object obj100 = obj80 + 64;
																							obj100 = obj97;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							object obj101 = obj13;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v74+A0]");
																							object obj102 = (nint)0 + (nint)32;
																							obj102 = obj80;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							int num = Shader.PropertyToID((string)obj98);
																							object obj103 = obj13;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v75+A0]");
																							object obj104 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																							HashSet<System.__Canon> hashSet = default;
																							hashSet._002Ector();
																							object obj105 = obj13;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v77+A0]");
																							object obj106 = (nint)0 + (nint)64;
																							obj106 = hashSet;
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
