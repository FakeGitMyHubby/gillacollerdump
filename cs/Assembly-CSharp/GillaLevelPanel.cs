using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class GillaLevelPanel : MonoBehaviour
{
	public Renderer screen;

	public PressKey[] tabKeys;

	public PressKey[] buyKeys;

	public GameObject buyGroup;

	public TextAsset titleFont;

	public TextAsset textFont;

	public AudioClip buySound;

	public AudioClip nopeSound;

	public AudioClip levelUpSound;

	public AudioClip tabSound;

	public const int W = default(int);

	public const int H = default(int);

	public const int Rewards = default(int);

	public const int Buy = default(int);

	public static readonly int[] RowTops;

	public const int RowHeight = default(int);

	public static readonly int[] RowXp;

	public const int TabTop = default(int);

	public const int TabHeight = default(int);

	public const int TabLeft = default(int);

	public const int TabWidth = default(int);

	public const int TabGap = default(int);

	public const int MostAtOnce = default(int);

	public static bool NoServerForTest;

	private static readonly int BaseMap;

	private Texture2D tex;

	private Color32[] px;

	private MaterialPropertyBlock block;

	private ScreenFont title;

	private ScreenFont text;

	private string shown;

	private string said;

	private float sayUntil;

	private bool sayBad;

	private int tab;

	public int Tab => tab;

	public static int ToNextLevel
	{
		get
		{
			//IL_0012: Expected Obj, but got I4
			//IL_001b: Expected Obj, but got I4
			//IL_0024: Expected Obj, but got I4
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Expected Obj, but got Unknown
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Expected Obj, but got Unknown
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Expected Obj, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected I4, but got Unknown
			//IL_0065: Expected Obj, but got I4
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected I4, but got Unknown
			//IL_00d3: Expected Obj, but got I4
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected Obj, but got Unknown
			int xp = GillaLevel.Xp;
			object obj = 2;
			object obj2 = 50;
			object obj3 = 0;
			object obj4 = default;
			obj = obj4;
			object obj5 = default;
			obj2 = obj5;
			object obj6 = default;
			obj3 = obj6;
			object obj7;
			do
			{
				obj7 = obj2 * obj;
				obj3 += 100;
				obj2 += 50;
				obj++;
			}
			while ((nint)obj7 <= xp);
			int intoLevel = GillaLevel.IntoLevel;
			int num = obj3 - intoLevel;
			object obj8 = num - 1;
			bool flag = (nint)obj8 < 0;
			bool flag2 = obj8 == null;
			int num2 = num ^ 1;
			int num3 = num ^ obj8;
			int num4 = num2 & num3;
			bool flag3 = num4 < 0;
			bool flag4 = flag == flag3;
			object obj9 = !flag2;
			object obj10 = flag4 & obj9;
			object obj11 = ~obj10;
			if (obj11 == null)
			{
				return num;
			}
			return 1;
		}
	}

	private static void Fresh()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AD8]");
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
		_ = 0;
	}

	private void OnEnable()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I8
		//IL_0068: Expected Obj, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got I4
		//IL_0380: Expected Obj, but got I
		//IL_0390: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I
		//IL_03b8: Expected I, but got Obj
		//IL_048c: Expected Obj, but got I4
		//IL_03e7: Expected Obj, but got I4
		//IL_0205: Expected Obj, but got I8
		//IL_0215: Expected Obj, but got I
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_0244: Expected Obj, but got I4
		//IL_04b3: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I4
		//IL_042a: Expected I, but got Obj
		//IL_00f5: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I4
		//IL_0116: Expected I, but got Obj
		//IL_0273: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_02a2: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I4
		//IL_02c3: Expected I, but got Obj
		//IL_013c: Expected I, but got Obj
		//IL_032c: Expected Obj, but got I4
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I4
		//IL_0170: Expected I, but got Obj
		//IL_02e9: Expected I, but got Obj
		//IL_0303: Expected Obj, but got I
		//IL_030c: Expected Obj, but got I4
		//IL_0315: Expected Obj, but got I4
		//IL_031d: Expected I, but got Obj
		PressKey[] array = tabKeys;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
		object obj2 = 0;
		if (array.Length < 1)
		{
			goto IL_01c3;
		}
		object obj3 = array.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AF0]");
		object obj4 = 0;
		object obj5 = array + 32;
		object obj7 = default;
		object obj6 = obj7;
		object obj9 = default;
		object obj8 = obj9;
		nint num = default;
		IntPtr intPtr = num;
		object obj10 = 0;
		Action<System.__Canon> action = default;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
			object obj11 = !flag;
			if (obj11 != null)
			{
				break;
			}
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v30+E4]");
			bool flag2 = (nint)0 == 0;
			object obj13 = !flag2;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X27_v7+v100 @ X25_v10*8]");
			bool flag3 = (UnityEngine.Object)0 != null;
			bool flag4 = !flag3;
			obj9 = 0;
			num = unchecked((nint)null);
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				action._002Ector((object)this, (IntPtr)obj4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X27_v7+v100 @ X25_v10*8]");
				((PressKey)0).Pressed += (Action<PressKey>)action;
				obj6 = 0;
				obj9 = 0;
				num = (nint)action;
			}
			obj3 = array.Length;
			obj10++;
			bool flag5 = (nint)obj10 < array.Length;
			obj7 = obj6;
			obj8 = obj9;
			intPtr = num;
			if (flag5)
			{
				continue;
			}
			goto IL_01c3;
		}
		goto IL_044f;
		IL_044f:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_01c3:
		PressKey[] array2 = buyKeys;
		if (array2.Length < 1)
		{
			goto IL_0370;
		}
		object obj14 = array2.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AE0]");
		object obj15 = 0;
		object obj16 = array2 + 32;
		object obj17 = obj7;
		object obj18 = obj9;
		IntPtr intPtr2 = num;
		object obj19 = 0;
		Action<System.__Canon> action2 = default;
		while (true)
		{
			bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14);
			object obj20 = !flag6;
			if (obj20 != null)
			{
				break;
			}
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v20+E4]");
			bool flag7 = (nint)0 == 0;
			object obj22 = !flag7;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X27_v6+v102 @ X25_v7*8]");
			bool flag8 = (UnityEngine.Object)0 != null;
			bool flag9 = !flag8;
			obj9 = 0;
			num = unchecked((nint)null);
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				action2._002Ector((object)this, (IntPtr)obj15);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X27_v6+v102 @ X25_v7*8]");
				((PressKey)0).Pressed += (Action<PressKey>)action2;
				obj17 = 0;
				obj9 = 0;
				num = (nint)action2;
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
			goto IL_0370;
		}
		goto IL_044f;
		IL_0370:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AE8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action3 = default;
		action3._002Ector(this, (IntPtr)obj24);
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v10+E4]");
		bool flag11 = (nint)0 == 0;
		object obj27 = !flag11;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coins.Changed += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action4 = default;
		action4._002Ector(this, (IntPtr)obj24);
		GillaLevel.Changed += action4;
		ShowKeys();
		Redraw(force: true);
	}

	private void OnDisable()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I8
		//IL_0068: Expected Obj, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got I4
		//IL_0380: Expected Obj, but got I
		//IL_0390: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I
		//IL_03b8: Expected I, but got Obj
		//IL_0476: Expected Obj, but got I4
		//IL_03e7: Expected Obj, but got I4
		//IL_0205: Expected Obj, but got I8
		//IL_0215: Expected Obj, but got I
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_0244: Expected Obj, but got I4
		//IL_049d: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I4
		//IL_042a: Expected I, but got Obj
		//IL_00f5: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I4
		//IL_0116: Expected I, but got Obj
		//IL_0273: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_02a2: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I4
		//IL_02c3: Expected I, but got Obj
		//IL_013c: Expected I, but got Obj
		//IL_032c: Expected Obj, but got I4
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I4
		//IL_0170: Expected I, but got Obj
		//IL_02e9: Expected I, but got Obj
		//IL_0303: Expected Obj, but got I
		//IL_030c: Expected Obj, but got I4
		//IL_0315: Expected Obj, but got I4
		//IL_031d: Expected I, but got Obj
		PressKey[] array = tabKeys;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
		object obj2 = 0;
		if (array.Length < 1)
		{
			goto IL_01c3;
		}
		object obj3 = array.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AF0]");
		object obj4 = 0;
		object obj5 = array + 32;
		object obj7 = default;
		object obj6 = obj7;
		object obj9 = default;
		object obj8 = obj9;
		nint num = default;
		IntPtr intPtr = num;
		object obj10 = 0;
		Action<System.__Canon> action = default;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
			object obj11 = !flag;
			if (obj11 != null)
			{
				break;
			}
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v28+E4]");
			bool flag2 = (nint)0 == 0;
			object obj13 = !flag2;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X27_v7+v100 @ X25_v10*8]");
			bool flag3 = (UnityEngine.Object)0 != null;
			bool flag4 = !flag3;
			obj9 = 0;
			num = unchecked((nint)null);
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				action._002Ector((object)this, (IntPtr)obj4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X27_v7+v100 @ X25_v10*8]");
				((PressKey)0).Pressed -= (Action<PressKey>)action;
				obj6 = 0;
				obj9 = 0;
				num = (nint)action;
			}
			obj3 = array.Length;
			obj10++;
			bool flag5 = (nint)obj10 < array.Length;
			obj7 = obj6;
			obj8 = obj9;
			intPtr = num;
			if (flag5)
			{
				continue;
			}
			goto IL_01c3;
		}
		goto IL_0439;
		IL_0439:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_01c3:
		PressKey[] array2 = buyKeys;
		if (array2.Length < 1)
		{
			goto IL_0370;
		}
		object obj14 = array2.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AE0]");
		object obj15 = 0;
		object obj16 = array2 + 32;
		object obj17 = obj7;
		object obj18 = obj9;
		IntPtr intPtr2 = num;
		object obj19 = 0;
		Action<System.__Canon> action2 = default;
		while (true)
		{
			bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14);
			object obj20 = !flag6;
			if (obj20 != null)
			{
				break;
			}
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v18+E4]");
			bool flag7 = (nint)0 == 0;
			object obj22 = !flag7;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X27_v6+v102 @ X25_v7*8]");
			bool flag8 = (UnityEngine.Object)0 != null;
			bool flag9 = !flag8;
			obj9 = 0;
			num = unchecked((nint)null);
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				action2._002Ector((object)this, (IntPtr)obj15);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X27_v6+v102 @ X25_v7*8]");
				((PressKey)0).Pressed -= (Action<PressKey>)action2;
				obj17 = 0;
				obj9 = 0;
				num = (nint)action2;
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
			goto IL_0370;
		}
		goto IL_0439;
		IL_0370:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AE8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action3 = default;
		action3._002Ector(this, (IntPtr)obj24);
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v10+E4]");
		bool flag11 = (nint)0 == 0;
		object obj27 = !flag11;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coins.Changed -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action4 = default;
		action4._002Ector(this, (IntPtr)obj24);
		GillaLevel.Changed -= action4;
	}

	private void OnChanged()
	{
		Redraw(force: false);
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
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
		object obj4 = this + 160;
		if (obj4 != null)
		{
			float time = Time.time;
			if (!(time < sayUntil))
			{
				said = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Redraw(force: false);
			}
		}
	}

	public void ShowTab(int which)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_003b: Expected Obj, but got I4
		object obj = which - 1;
		bool flag = obj == null;
		tab = (flag ? 1 : 0);
		object obj2 = this + 160;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		ShowKeys();
		Redraw(force: false);
	}

	private void ShowKeys()
	{
		//IL_0010: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00d3: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (buyGroup != null)
		{
			bool activeSelf = buyGroup.activeSelf;
			object obj4 = tab - 1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			object obj6 = activeSelf ^ obj5;
			object obj7 = obj6 & 1;
			if (obj7 == null)
			{
				object obj8 = tab - 1;
				bool active = obj8 == null;
				buyGroup.SetActive(active);
			}
		}
	}

	private void OnTab(PressKey key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01fd: Expected I4, but got I8
		//IL_0217: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0160: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I4
		//IL_01c1: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6168]");
		object obj = 0;
		int num = Array.IndexOf((System.__Canon[])(object)tabKeys, (System.__Canon)(object)key);
		int num2 = (int)(num & 0x80000000L);
		bool flag = num2 == 0;
		object obj2 = !flag;
		if (obj2 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		ShowTab(num);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(tabSound != null))
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
			obj7 = tabSound;
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v22+E4]");
					bool flag3 = (nint)0 == 0;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float volume = default;
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

	private void OnBuy(PressKey key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_06b3: Expected I4, but got I8
		//IL_06cd: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_06eb: Expected Obj, but got I
		//IL_06fb: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_02a0: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I4
		//IL_0742: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I4
		//IL_0321: Expected I4, but got I8
		//IL_033b: Expected Obj, but got I4
		//IL_01f8: Expected Obj, but got I
		//IL_0208: Expected Obj, but got I
		//IL_038b: Expected Obj, but got I
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Expected Obj, but got Unknown
		//IL_03a0: Expected Obj, but got I
		//IL_03c1: Expected Obj, but got I
		//IL_03d1: Expected Obj, but got I
		//IL_04b8: Expected I4, but got I8
		//IL_04d2: Expected Obj, but got I4
		//IL_0376: Expected Obj, but got I
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected Obj, but got Unknown
		//IL_0410: Expected Obj, but got I
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected Obj, but got Unknown
		//IL_0445: Expected Obj, but got I4
		//IL_076d: Expected Obj, but got I
		//IL_0797: Expected Obj, but got I4
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected Obj, but got Unknown
		//IL_054a: Expected Obj, but got I
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got Unknown
		//IL_05f5: Expected Obj, but got I
		//IL_061f: Expected Obj, but got I4
		//IL_065b: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6168]");
		object obj = 0;
		string text = (string)obj;
		int num = Array.IndexOf((System.__Canon[])(object)buyKeys, (System.__Canon)(object)key);
		int num2 = (int)(num & 0x80000000L);
		bool flag = num2 == 0;
		object obj2 = !flag;
		if (obj2 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AD8]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v9+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X9_v3+8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X9_v3+8]");
		if ((nint)0 == 0)
		{
			goto IL_0671;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X9_v18+18]");
		if ((nint)num >= (nint)0 || tab != 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v9+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X9_v22+8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X9_v22+8]");
			if ((nint)0 == 0)
			{
				goto IL_0671;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X9_v18+18]");
		bool flag4 = (nint)num < (nint)0;
		object obj10 = !flag4;
		if (obj10 != null)
		{
			goto IL_067f;
		}
		object obj11 = obj7 + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X10_v8+20]");
		int xp;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v9+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v9+A0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X9_v20+8]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X9_v20+8]");
				if ((nint)0 == 0)
				{
					goto IL_0671;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X9_v18+18]");
			bool flag6 = (nint)num < (nint)0;
			object obj14 = !flag6;
			if (obj14 != null)
			{
				goto IL_067f;
			}
			object obj15 = obj7 + num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X9_v19+20]");
			xp = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v9+E4]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int toNextLevel = ToNextLevel;
			obj4 = obj3;
			xp = toNextLevel;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v9+E4]");
		bool flag8 = (nint)0 == 0;
		object obj17 = !flag8;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num3 = BuyXp(xp);
		int num4 = num3 >> 31;
		sayBad = (byte)num4 != 0;
		int num5 = (int)(num3 & 0x80000000L);
		bool flag9 = num5 == 0;
		object obj18 = !flag9;
		object obj22;
		string text4;
		if (obj18 == null)
		{
			if (num3 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
				object obj19 = 0;
				int num6 = default;
				string text2 = num6.ToString((string)obj19);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60E0]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6148]");
				object obj21 = 0;
				text = (string)obj21;
				string text3 = (string)obj20 + text2 + (string)obj21;
				text4 = text3;
				goto IL_07a5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1B60]");
			obj22 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1B58]");
			obj22 = 0;
		}
		text4 = (string)obj22;
		goto IL_07a5;
		IL_04e0:
		object obj23 = this + 80;
		goto IL_075d;
		IL_067f:
		throw new IndexOutOfRangeException();
		IL_0671:
		NullReferenceException ex = new NullReferenceException();
		goto IL_067f;
		IL_07a5:
		object obj24 = this + 160;
		obj24 = text4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		float time = Time.time;
		float volume = time + 2.5f;
		if (num3 >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj25 = 0;
			obj23 = this + 96;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v40+E4]");
			bool flag10 = (nint)0 == 0;
			object obj27 = !flag10;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag11 = (UnityEngine.Object)obj23 != null;
			bool flag12 = !flag11;
			text4 = null;
			text = null;
			if (flag12)
			{
				goto IL_04e0;
			}
			text4 = null;
			text = null;
		}
		else
		{
			int num7 = (int)(num3 & 0x80000000L);
			bool flag13 = num7 == 0;
			object obj28 = !flag13;
			if (obj28 == null)
			{
				goto IL_04e0;
			}
			obj23 = this + 88;
		}
		goto IL_075d;
		IL_0660:
		Redraw(force: false);
		return;
		IL_075d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj29 = 0;
		object obj30 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v20+E4]");
		bool flag14 = (nint)0 == 0;
		object obj31 = !flag14;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!((UnityEngine.Object)obj23 != null))
		{
			goto IL_0660;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		AudioClip[] array = default;
		if (array != null)
		{
			object obj33 = array + 32;
			obj33 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if ((object)key != null)
			{
				Transform transform = key.transform;
				if ((object)transform != null)
				{
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
					object obj34 = 0;
					object obj35 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v34+E4]");
					bool flag15 = (nint)0 == 0;
					object obj36 = !flag15;
					if (obj36 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float pitchMax = default;
					Sfx.Play(array, (Vector3)0, volume, 2.5f, pitchMax);
					goto IL_0660;
				}
			}
		}
		goto IL_0671;
	}

	public static int BuyXp(int xp)
	{
		//IL_0091: Expected I4, but got I8
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I4
		//IL_0242: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I
		//IL_02c0: Expected Obj, but got I4
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected I4, but got Unknown
		//IL_031f: Expected Obj, but got I4
		//IL_029c: Expected Obj, but got I4
		//IL_01da: Expected I4, but got I8
		int result;
		if (xp >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int bolts = Coins.Bolts;
			if (bolts >= xp)
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int amount = -xp;
				Coins.AddBoltsHere(amount);
				int num = GillaLevel.Add(xp, quiet: false, boost: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AD8]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj7 = obj6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v8+A0]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v9+10]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				result = num;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
					object obj11 = 0;
					bool flag5 = false;
					int num2 = xp;
					bool flag10;
					do
					{
						object obj12 = obj11;
						object obj13 = num2 - 10000;
						bool flag6 = (nint)obj13 < 0;
						int num3 = num2 ^ 0x2710;
						int num4 = num2 ^ obj13;
						int num5 = num3 & num4;
						bool flag7 = num5 < 0;
						bool flag8 = flag6 == flag7;
						object obj14 = !flag8;
						object obj15 = ~obj14;
						int xp2 = ((obj15 != null) ? 10000 : num2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v16+E4]");
						bool flag9 = (nint)0 == 0;
						object obj16 = !flag9;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaCloud.BoughtXp(xp2);
						int num6 = (int)(num2 + 4294957296L);
						flag10 = num2 > 10000;
						result = num;
						flag5 = false;
						num2 = num6;
					}
					while (flag10);
				}
				goto IL_0210;
			}
		}
		result = -1;
		goto IL_0210;
		IL_0210:
		return result;
	}

	public void Refresh()
	{
		ShowKeys();
		Redraw(force: true);
	}

	private unsafe void Redraw(bool force)
	{
		//IL_0010: Expected Obj, but got I
		//IL_2835: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I4
		//IL_2851: Expected Obj, but got I4
		//IL_2875: Unknown result type (might be due to invalid IL or missing references)
		//IL_287a: Expected Obj, but got Unknown
		//IL_00ec: Expected Obj, but got I4
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected I4, but got Unknown
		//IL_0151: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I4
		//IL_0194: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01ff: Expected Obj, but got I8
		//IL_0217: Expected Obj, but got I4
		//IL_0220: Expected Obj, but got I4
		//IL_0229: Expected Obj, but got I4
		//IL_0232: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got I4
		//IL_0243: Expected I4, but got Obj
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_02ad: Expected Obj, but got I4
		//IL_02c3: Expected Obj, but got I
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		//IL_02f1: Expected Obj, but got I4
		//IL_02fa: Expected Obj, but got I4
		//IL_0303: Expected Obj, but got I4
		//IL_030c: Expected Obj, but got I4
		//IL_0315: Expected Obj, but got I4
		//IL_1fee: Expected Obj, but got I4
		//IL_2064: Expected Obj, but got I
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_036e: Expected Obj, but got I8
		//IL_0386: Expected Obj, but got I4
		//IL_038f: Expected Obj, but got I4
		//IL_0398: Expected Obj, but got I4
		//IL_03a1: Expected Obj, but got I4
		//IL_03aa: Expected Obj, but got I4
		//IL_03b2: Expected I4, but got Obj
		//IL_31c9: Expected Obj, but got I4
		//IL_2099: Expected Obj, but got I
		//IL_20a9: Expected Obj, but got I
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_2173: Expected Obj, but got I4
		//IL_2134: Expected I, but got Obj
		//IL_041c: Expected Obj, but got I4
		//IL_0432: Expected Obj, but got I
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected Obj, but got Unknown
		//IL_0460: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got I4
		//IL_0472: Expected Obj, but got I4
		//IL_047b: Expected Obj, but got I4
		//IL_0484: Expected Obj, but got I4
		//IL_20e4: Expected Obj, but got I
		//IL_21a1: Expected Obj, but got I
		//IL_21b1: Expected Obj, but got I
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_04dd: Expected Obj, but got I4
		//IL_04f3: Expected Obj, but got I
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected Obj, but got Unknown
		//IL_0521: Expected Obj, but got I4
		//IL_052a: Expected Obj, but got I4
		//IL_0533: Expected Obj, but got I4
		//IL_053c: Expected Obj, but got I4
		//IL_0545: Expected Obj, but got I4
		//IL_054d: Expected I4, but got Obj
		//IL_223c: Expected I, but got Obj
		//IL_214f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2154: Expected Obj, but got Unknown
		//IL_3262: Expected Obj, but got I4
		//IL_21ec: Expected Obj, but got I
		//IL_20f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f7: Expected Obj, but got Unknown
		//IL_2100: Unknown result type (might be due to invalid IL or missing references)
		//IL_2105: Expected Obj, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected Obj, but got Unknown
		//IL_22b6: Expected Obj, but got I
		//IL_05af: Expected Obj, but got I4
		//IL_05c5: Expected Obj, but got I
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected Obj, but got Unknown
		//IL_05f3: Expected Obj, but got I4
		//IL_05fc: Expected Obj, but got I4
		//IL_0605: Expected Obj, but got I4
		//IL_060e: Expected Obj, but got I4
		//IL_0617: Expected Obj, but got I4
		//IL_22e4: Expected VT, but got Ref
		//IL_2271: Expected Obj, but got I
		//IL_2294: Expected VT, but got Ref
		//IL_2257: Unknown result type (might be due to invalid IL or missing references)
		//IL_225c: Expected Obj, but got Unknown
		//IL_3577: Expected Obj, but got I4
		//IL_21fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ff: Expected Obj, but got Unknown
		//IL_2208: Unknown result type (might be due to invalid IL or missing references)
		//IL_220d: Expected Obj, but got Unknown
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected Obj, but got Unknown
		//IL_0668: Expected Obj, but got I8
		//IL_0680: Expected Obj, but got I4
		//IL_0689: Expected Obj, but got I4
		//IL_0692: Expected Obj, but got I4
		//IL_069b: Expected Obj, but got I4
		//IL_06a4: Expected Obj, but got I4
		//IL_06ac: Expected I4, but got Obj
		//IL_2376: Expected Obj, but got I4
		//IL_06c2: Expected I4, but got Obj
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected Obj, but got Unknown
		//IL_0704: Expected Obj, but got I4
		//IL_071a: Expected Obj, but got I
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Expected Obj, but got Unknown
		//IL_0748: Expected Obj, but got I4
		//IL_0751: Expected Obj, but got I4
		//IL_075a: Expected Obj, but got I4
		//IL_0763: Expected Obj, but got I4
		//IL_076c: Expected Obj, but got I4
		//IL_32a1: Expected Obj, but got I
		//IL_232f: Expected Obj, but got I4
		//IL_35a7: Expected Obj, but got I4
		//IL_3286: Expected Obj, but got I
		//IL_0784: Expected I4, but got Obj
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0792: Expected Obj, but got Unknown
		//IL_07c8: Expected Obj, but got I4
		//IL_07de: Expected Obj, but got I
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected Obj, but got Unknown
		//IL_080c: Expected Obj, but got I4
		//IL_0815: Expected Obj, but got I4
		//IL_081e: Expected Obj, but got I4
		//IL_0827: Expected Obj, but got I4
		//IL_0830: Expected Obj, but got I4
		//IL_23e4: Expected VT, but got Obj
		//IL_23f4: Expected Obj, but got I
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Expected Obj, but got Unknown
		//IL_086e: Expected Obj, but got I
		//IL_087e: Expected Obj, but got I
		//IL_08a0: Expected Obj, but got I4
		//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c8: Expected I4, but got Unknown
		//IL_08f1: Expected Obj, but got I4
		//IL_0901: Expected Obj, but got I4
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Expected Obj, but got Unknown
		//IL_092f: Expected Obj, but got I4
		//IL_0938: Expected Obj, but got I4
		//IL_0941: Expected Obj, but got I4
		//IL_094a: Expected Obj, but got I4
		//IL_0953: Expected Obj, but got I4
		//IL_2445: Expected Obj, but got Ref
		//IL_32e7: Expected Obj, but got I
		//IL_3307: Expected VT, but got Ref
		//IL_3310: Unknown result type (might be due to invalid IL or missing references)
		//IL_3315: Expected Obj, but got Unknown
		//IL_3345: Expected VT, but got Obj
		//IL_3356: Expected VT, but got Ref
		//IL_2438: Expected Obj, but got Ref
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Expected Obj, but got Unknown
		//IL_09b6: Expected Obj, but got I4
		//IL_2461: Expected VT, but got Obj
		//IL_247a: Expected I4, but got Obj
		//IL_2493: Expected I4, but got Obj
		//IL_0a83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a88: Expected Obj, but got Unknown
		//IL_0aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aad: Expected Obj, but got Unknown
		//IL_0acf: Expected Obj, but got I4
		//IL_0b12: Expected Obj, but got I4
		//IL_09eb: Expected I, but got Obj
		//IL_24c0: Expected Obj, but got I
		//IL_24d9: Expected VT, but got Obj
		//IL_24f2: Expected I4, but got Obj
		//IL_2500: Expected I, but got Obj
		//IL_250a: Expected I4, but got Obj
		//IL_0cb0: Expected Obj, but got I4
		//IL_0b35: Expected Obj, but got I
		//IL_0a23: Expected Obj, but got I4
		//IL_2557: Expected Obj, but got I4
		//IL_0d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0c: Expected Obj, but got Unknown
		//IL_0d26: Expected Obj, but got I4
		//IL_0b79: Expected Obj, but got I4
		//IL_0a6a: Expected Obj, but got I4
		//IL_0a6f: Expected I, but got Obj
		//IL_259e: Expected Obj, but got I4
		//IL_0e8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8f: Expected Obj, but got Unknown
		//IL_0ea9: Expected Obj, but got I4
		//IL_101f: Expected Obj, but got I4
		//IL_0d70: Expected Obj, but got I4
		//IL_25b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b7: Expected Obj, but got Unknown
		//IL_25d1: Expected Obj, but got I4
		//IL_28a9: Expected Obj, but got I
		//IL_28b7: Expected Obj, but got Ref
		//IL_28cf: Expected Obj, but got Ref
		//IL_28e7: Expected Obj, but got I
		//IL_2907: Expected Obj, but got Ref
		//IL_2917: Expected Obj, but got I
		//IL_0ee1: Expected Obj, but got I4
		//IL_0bf3: Expected Obj, but got I
		//IL_2648: Expected VT, but got Obj
		//IL_2661: Expected I4, but got Obj
		//IL_266f: Expected I, but got Obj
		//IL_0e6d: Expected Obj, but got I4
		//IL_0c29: Expected Obj, but got I
		//IL_25f8: Expected Obj, but got I
		//IL_0fde: Expected Obj, but got I4
		//IL_0de6: Expected Obj, but got I4
		//IL_0dfd: Expected I, but got Obj
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c43: Expected Obj, but got Unknown
		//IL_0c79: Expected Obj, but got I4
		//IL_26b6: Expected Obj, but got I4
		//IL_262a: Expected I4, but got Obj
		//IL_2948: Expected Obj, but got I4
		//IL_0f57: Expected Obj, but got I4
		//IL_0f6e: Expected I, but got Obj
		//IL_26ea: Expected VT, but got Obj
		//IL_2703: Expected I4, but got Obj
		//IL_2711: Expected I, but got Obj
		//IL_2719: Expected I4, but got Obj
		//IL_33b6: Expected Obj, but got I
		//IL_33c4: Expected Obj, but got Ref
		//IL_33f4: Expected VT, but got Ref
		//IL_33f4: Expected Obj, but got I4
		//IL_0e33: Expected Obj, but got I
		//IL_0fa4: Expected Obj, but got I
		//IL_0e60: Expected I4, but got Obj
		//IL_273f: Expected Obj, but got I
		//IL_2783: Expected VT, but got Obj
		//IL_279c: Expected I4, but got Obj
		//IL_27af: Expected I, but got Obj
		//IL_199b: Expected Obj, but got I
		//IL_19c5: Expected Obj, but got I4
		//IL_0fd1: Expected I4, but got Obj
		//IL_10f1: Expected Obj, but got I4
		//IL_1127: Expected Obj, but got I4
		//IL_2cf9: Expected Obj, but got I4
		//IL_2c97: Expected Obj, but got I
		//IL_2cc1: Expected Obj, but got I4
		//IL_34c1: Expected Obj, but got I
		//IL_34d1: Expected Obj, but got I
		//IL_34fa: Expected Obj, but got I4
		//IL_350b: Expected Obj, but got I4
		//IL_2966: Expected Obj, but got I
		//IL_2976: Expected Obj, but got I
		//IL_2996: Expected Obj, but got I4
		//IL_1a16: Expected Obj, but got I
		//IL_1a26: Expected Obj, but got I
		//IL_186e: Expected Obj, but got I
		//IL_188a: Expected Obj, but got I4
		//IL_2d4e: Expected Obj, but got I4
		//IL_2d5f: Expected Obj, but got I4
		//IL_2d68: Expected Obj, but got I4
		//IL_1a61: Expected Obj, but got I
		//IL_118c: Expected Obj, but got I4
		//IL_1f70: Expected Obj, but got Ref
		//IL_1986: Expected Obj, but got Ref
		//IL_18a8: Expected Obj, but got I
		//IL_18d2: Expected Obj, but got I4
		//IL_29c4: Expected Obj, but got I4
		//IL_1af3: Expected Obj, but got I
		//IL_1b16: Expected Obj, but got I4
		//IL_1ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad5: Expected Obj, but got Unknown
		//IL_314b: Expected Obj, but got I
		//IL_315c: Expected Obj, but got I4
		//IL_3165: Expected Obj, but got I4
		//IL_316d: Expected VT, but got Ref
		//IL_1979: Expected Obj, but got Ref
		//IL_1908: Expected Obj, but got I
		//IL_1918: Expected Obj, but got I
		//IL_11bc: Expected Obj, but got I
		//IL_310e: Expected Obj, but got I
		//IL_1a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a74: Expected Obj, but got Unknown
		//IL_1a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a82: Expected Obj, but got Unknown
		//IL_11e2: Expected Obj, but got I4
		//IL_11f3: Expected Obj, but got I4
		//IL_11fc: Expected Obj, but got I4
		//IL_1bad: Expected I, but got Obj
		//IL_1f8b: Expected Obj, but got Ref
		//IL_2dbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc3: Expected Obj, but got Unknown
		//IL_2dda: Expected Obj, but got Ref
		//IL_2dea: Expected Obj, but got I
		//IL_2df8: Expected Obj, but got I4
		//IL_2e09: Expected Obj, but got I4
		//IL_2e12: Expected Obj, but got I4
		//IL_1b5d: Expected Obj, but got I
		//IL_1222: Expected Obj, but got I
		//IL_1242: Expected Obj, but got I4
		//IL_1bf1: Expected Obj, but got Ref
		//IL_1c01: Expected Obj, but got I
		//IL_1c0f: Expected Obj, but got I4
		//IL_1c20: Expected Obj, but got I4
		//IL_1c29: Expected Obj, but got I4
		//IL_1bc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bcd: Expected Obj, but got Unknown
		//IL_1271: Expected Obj, but got I4
		//IL_1282: Expected Obj, but got I4
		//IL_128b: Expected Obj, but got I4
		//IL_1b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b70: Expected Obj, but got Unknown
		//IL_1b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7e: Expected Obj, but got Unknown
		//IL_1c57: Expected Obj, but got I
		//IL_1c67: Expected Obj, but got I
		//IL_12b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b6: Expected Obj, but got Unknown
		//IL_1cf2: Expected I, but got Obj
		//IL_13f1: Expected Obj, but got Ref
		//IL_2e80: Expected Obj, but got I4
		//IL_2e88: Expected Obj, but got Ref
		//IL_2e98: Expected Obj, but got I
		//IL_2ea6: Expected Obj, but got I4
		//IL_2eb7: Expected Obj, but got I4
		//IL_2ec0: Expected Obj, but got I4
		//IL_1ca2: Expected Obj, but got I
		//IL_29fc: Expected Obj, but got I4
		//IL_130a: Expected Obj, but got I4
		//IL_342d: Expected Obj, but got I
		//IL_345a: Expected VT, but got I
		//IL_1399: Expected Obj, but got I4
		//IL_13aa: Expected Obj, but got I4
		//IL_13b3: Expected Obj, but got I4
		//IL_1d41: Expected Obj, but got I4
		//IL_1d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d12: Expected Obj, but got Unknown
		//IL_1476: Expected Obj, but got I4
		//IL_133a: Expected Obj, but got I
		//IL_134a: Expected Obj, but got I
		//IL_136a: Expected Obj, but got I4
		//IL_2ee6: Expected Obj, but got I
		//IL_2f0b: Expected VT, but got I
		//IL_2f28: Expected Obj, but got I
		//IL_1cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb5: Expected Obj, but got Unknown
		//IL_1cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc3: Expected Obj, but got Unknown
		//IL_2a3b: Expected Obj, but got I
		//IL_142f: Expected Obj, but got I4
		//IL_13df: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e4: Expected Obj, but got Unknown
		//IL_1d73: Expected Obj, but got I4
		//IL_1d97: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d9c: Expected I4, but got Unknown
		//IL_1dd1: Expected Obj, but got I4
		//IL_34a3: Expected Obj, but got I4
		//IL_2a20: Expected Obj, but got I
		//IL_1dfd: Expected Obj, but got Ref
		//IL_14ec: Expected VT, but got Obj
		//IL_14f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f9: Expected Obj, but got Unknown
		//IL_1510: Unknown result type (might be due to invalid IL or missing references)
		//IL_1515: Expected I4, but got Unknown
		//IL_151d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1522: Expected I4, but got Unknown
		//IL_156d: Expected Obj, but got I4
		//IL_2f6c: Expected VT, but got Ref
		//IL_2f7c: Expected Obj, but got I
		//IL_2fa6: Expected Obj, but got I4
		//IL_1df0: Expected Obj, but got Ref
		//IL_1599: Expected Obj, but got Ref
		//IL_1e2e: Expected Obj, but got I
		//IL_2a58: Expected Obj, but got I
		//IL_2a68: Expected Obj, but got I
		//IL_2a8f: Expected VT, but got Ref
		//IL_2a8f: Expected I4, but got Obj
		//IL_2a9f: Expected Obj, but got I
		//IL_2ac9: Expected Obj, but got I4
		//IL_158c: Expected Obj, but got Ref
		//IL_1e51: Expected Obj, but got I4
		//IL_1e75: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e7a: Expected I4, but got Unknown
		//IL_1eaf: Expected Obj, but got I4
		//IL_2ae7: Expected Obj, but got I
		//IL_2af7: Expected Obj, but got I
		//IL_2b16: Expected VT, but got Obj
		//IL_2b28: Expected Obj, but got I4
		//IL_2b38: Expected I4, but got Obj
		//IL_2b4e: Expected I, but got Obj
		//IL_2b58: Expected I4, but got Obj
		//IL_2fe3: Expected VT, but got Ref
		//IL_15d6: Expected Obj, but got I4
		//IL_15de: Expected VT, but got Obj
		//IL_15f8: Expected Obj, but got I4
		//IL_1601: Expected Obj, but got I4
		//IL_1619: Expected I4, but got Obj
		//IL_162f: Expected I, but got Obj
		//IL_1639: Expected I4, but got Obj
		//IL_1f53: Expected Obj, but got I
		//IL_1f63: Expected Obj, but got Ref
		//IL_3048: Expected Obj, but got I
		//IL_3076: Expected VT, but got Ref
		//IL_309e: Expected Obj, but got I4
		//IL_30a6: Expected Obj, but got Ref
		//IL_30b6: Expected Obj, but got Ref
		//IL_30cf: Expected I4, but got Obj
		//IL_1ef9: Expected Obj, but got I4
		//IL_1f09: Expected Obj, but got I
		//IL_1657: Unknown result type (might be due to invalid IL or missing references)
		//IL_165c: Expected Obj, but got Unknown
		//IL_1f3e: Expected Obj, but got I
		//IL_1714: Expected Obj, but got I
		//IL_302b: Expected Obj, but got Ref
		//IL_173a: Expected Obj, but got I
		//IL_1691: Expected Obj, but got I
		//IL_16b2: Expected Obj, but got I
		//IL_16c2: Expected Obj, but got I
		//IL_2b6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b73: Expected Obj, but got Unknown
		//IL_2b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b8f: Expected I4, but got Unknown
		//IL_2b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b9c: Expected I4, but got Unknown
		//IL_2be7: Expected Obj, but got I4
		//IL_1764: Expected Obj, but got Ref
		//IL_2c17: Expected Obj, but got I4
		//IL_1757: Expected Obj, but got Ref
		//IL_177e: Expected Obj, but got Ref
		//IL_2c50: Expected VT, but got Ref
		//IL_2c71: Expected Obj, but got I
		//IL_1771: Expected Obj, but got Ref
		//IL_1793: Expected Obj, but got I
		//IL_17cb: Expected VT, but got Ref
		//IL_17d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d9: Expected Obj, but got Unknown
		//IL_17f9: Expected VT, but got Obj
		//IL_181a: Expected I4, but got Obj
		//IL_1835: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AD8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1B28]");
		int num = 0;
		int bolts = Coins.Bolts;
		int xp = GillaLevel.Xp;
		object obj9 = 50;
		int num2 = 0;
		object obj10 = default;
		obj9 = obj10;
		int num3 = default;
		num2 = num3;
		object obj12;
		do
		{
			object obj11 = num2 + 2;
			num2++;
			obj12 = obj9 * obj11;
			obj9 += 50;
		}
		while ((nint)obj12 <= xp);
		object obj13 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int toNextLevel = ToNextLevel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		int num4 = this + 176;
		string text = ((int*)num4)->ToString();
		string[] array = default;
		bool flag3 = array == null;
		object obj15 = 0;
		int num5 = 0;
		object obj16;
		object obj17;
		object obj18;
		object obj19;
		int num6;
		object obj71;
		object obj87;
		object obj94;
		object obj96 = default;
		object obj105;
		object obj121 = default;
		int num28;
		Color32 color;
		int num16;
		bool flag48;
		int num10;
		bool flag34;
		TextureFormat textureFormat;
		object obj108;
		object obj115;
		nint num9;
		if (!flag3)
		{
			bool flag4 = array.Length == 0;
			obj16 = 0;
			obj17 = 0;
			obj18 = 0;
			obj19 = 0;
			obj15 = 0;
			num5 = 0;
			num6 = num2;
			if (!flag4)
			{
				object obj20 = array + 32;
				obj20 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X22_v23-8]");
				object obj21 = 0 & 0xFFFFFFFEL;
				bool flag5 = obj21 == null;
				obj16 = 0;
				obj17 = 0;
				obj18 = 0;
				obj19 = 0;
				obj15 = 0;
				num5 = (int)text;
				num6 = num2;
				if (!flag5)
				{
					object obj22 = array + 40;
					obj22 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					int num7 = default;
					string text2 = num7.ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X22_v25-10]");
					bool flag6 = (nint)0 < (nint)2;
					object obj23 = !flag6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X22_v25-10]");
					object obj24 = -2;
					bool flag7 = obj24 == null;
					object obj25 = ~obj23;
					object obj26 = obj25 | flag7;
					obj16 = 0;
					obj17 = 0;
					obj18 = 0;
					obj19 = 0;
					obj15 = 0;
					num5 = 0;
					num6 = num2;
					if (obj26 == null)
					{
						object obj27 = array + 48;
						obj27 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X22_v27-18]");
						object obj28 = 0 & 0xFFFFFFFCL;
						bool flag8 = obj28 == null;
						obj16 = 0;
						obj17 = 0;
						obj18 = 0;
						obj19 = 0;
						obj15 = 0;
						num5 = (int)text2;
						num6 = num2;
						if (!flag8)
						{
							object obj29 = array + 56;
							obj29 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							string text3 = num6.ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X22_v29-20]");
							bool flag9 = (nint)0 < (nint)4;
							object obj30 = !flag9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X22_v29-20]");
							object obj31 = -4;
							bool flag10 = obj31 == null;
							object obj32 = ~obj30;
							object obj33 = obj32 | flag10;
							obj16 = 0;
							obj17 = 0;
							obj18 = 0;
							obj19 = 0;
							obj15 = 0;
							num5 = 0;
							if (obj33 == null)
							{
								object obj34 = array + 64;
								obj34 = text3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X22_v31-28]");
								bool flag11 = (nint)0 < (nint)5;
								object obj35 = !flag11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X22_v31-28]");
								object obj36 = -5;
								bool flag12 = obj36 == null;
								object obj37 = ~obj35;
								object obj38 = obj37 | flag12;
								obj16 = 0;
								obj17 = 0;
								obj18 = 0;
								obj19 = 0;
								obj15 = 0;
								num5 = (int)text3;
								if (obj38 == null)
								{
									object obj39 = array + 72;
									obj39 = obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									int num8 = default;
									string text4 = num8.ToString();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X22_v33-30]");
									bool flag13 = (nint)0 < (nint)6;
									object obj40 = !flag13;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X22_v33-30]");
									object obj41 = -6;
									bool flag14 = obj41 == null;
									object obj42 = ~obj40;
									object obj43 = obj42 | flag14;
									obj16 = 0;
									obj17 = 0;
									obj18 = 0;
									obj19 = 0;
									obj15 = 0;
									num5 = 0;
									if (obj43 == null)
									{
										object obj44 = array + 80;
										obj44 = text4;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X22_v35-38]");
										object obj45 = 0 & 0xFFFFFFF8L;
										bool flag15 = obj45 == null;
										obj16 = 0;
										obj17 = 0;
										obj18 = 0;
										obj19 = 0;
										obj15 = 0;
										num5 = (int)text4;
										if (!flag15)
										{
											num5 = (int)obj6;
											object obj46 = array + 88;
											obj46 = obj6;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X22_v37-40]");
											bool flag16 = (nint)0 < (nint)8;
											object obj47 = !flag16;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X22_v37-40]");
											object obj48 = -8;
											bool flag17 = obj48 == null;
											object obj49 = ~obj47;
											object obj50 = obj49 | flag17;
											obj16 = 0;
											obj17 = 0;
											obj18 = 0;
											obj19 = 0;
											obj15 = 0;
											if (obj50 == null)
											{
												num5 = (int)said;
												object obj51 = array + 96;
												obj51 = said;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X22_v39-48]");
												bool flag18 = (nint)0 < (nint)9;
												object obj52 = !flag18;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X22_v39-48]");
												object obj53 = -9;
												bool flag19 = obj53 == null;
												object obj54 = ~obj52;
												object obj55 = obj54 | flag19;
												obj16 = 0;
												obj17 = 0;
												obj18 = 0;
												obj19 = 0;
												obj15 = 0;
												if (obj55 == null)
												{
													object obj56 = array + 104;
													obj56 = obj6;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
													object obj57 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2109 @ X8_v68+30]");
													object obj58 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2110 @ X0_v118+E4]");
													bool flag20 = (nint)0 == 0;
													object obj59 = !flag20;
													if (obj59 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													bool flag21 = (byte)(this + 172) != 0;
													string text5 = (flag21 ? ((bool*)1) : ((bool*)null))->ToString();
													bool flag22 = array.Length < 10;
													object obj60 = !flag22;
													object obj61 = array.Length - 10;
													bool flag23 = obj61 == null;
													object obj62 = ~obj60;
													object obj63 = obj62 | flag23;
													obj16 = 0;
													obj17 = 0;
													obj18 = 0;
													obj19 = 0;
													obj15 = 0;
													num5 = 0;
													if (obj63 == null)
													{
														object obj64 = array + 112;
														obj64 = text5;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														string text6 = string.Concat(array);
														bool flag24 = !force;
														object obj65 = !flag24;
														if (obj65 == null)
														{
															bool flag25 = text6 == shown;
															bool flag26 = !flag25;
															num9 = unchecked((nint)null);
															if (!flag26)
															{
																object obj66 = obj7;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2196 @ X0_v312+E4]");
																bool flag27 = (nint)0 == 0;
																object obj67 = !flag27;
																if (obj67 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																}
																bool flag28 = tex != null;
																bool flag29 = !flag28;
																object obj68 = !flag29;
																num9 = unchecked((nint)null);
																if (obj68 != null)
																{
																	return;
																}
															}
														}
														object obj69 = this + 152;
														obj69 = text6;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														object obj70 = obj7;
														obj71 = this + 112;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2189 @ X0_v131+E4]");
														bool flag30 = (nint)0 == 0;
														object obj72 = !flag30;
														if (obj72 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														bool flag31 = (UnityEngine.Object)obj71 == null;
														bool flag32 = !flag31;
														object obj73 = 0;
														UnityEngine.Object obj74 = null;
														if (!flag32)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
															object obj75 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
															Texture2D texture2D = default;
															texture2D._002Ector(160, 240, (TextureFormat)4, mipChain: true);
															bool flag33 = (object)texture2D == null;
															obj15 = 0;
															num10 = 0;
															flag34 = true;
															textureFormat = (TextureFormat)4;
															num9 = 240;
															num5 = 160;
															if (flag33)
															{
																goto IL_27d2;
															}
															texture2D.filterMode = (FilterMode)0;
															texture2D.wrapMode = (TextureWrapMode)1;
															texture2D.hideFlags = (HideFlags)52;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1B48]");
															object obj76 = 0;
															texture2D.name = (string)obj76;
															tex = texture2D;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
															object obj77 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
															object obj78 = this + 120;
															UnityEngine.Object obj79 = default;
															obj78 = obj79;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															num10 = 0;
															flag34 = true;
															textureFormat = (TextureFormat)4;
															obj73 = 0;
															obj74 = obj79;
														}
														object obj80 = obj8;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2226 @ X0_v136+E4]");
														bool flag35 = (nint)0 == 0;
														object obj81 = !flag35;
														if (obj81 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														GillaBoardLook.Clear(px, 160, 240);
														GillaBoardLook.Frame(px, 160, 240, 3);
														object obj82 = this + 136;
														bool flag36 = obj82 == null;
														object obj83 = !flag36;
														int num11 = 240;
														int num12 = 160;
														if (obj83 == null)
														{
															object obj84 = obj7;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2275 @ X0_v283+E4]");
															bool flag37 = (nint)0 == 0;
															object obj85 = !flag37;
															if (obj85 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															bool flag38 = titleFont != null;
															bool flag39 = !flag38;
															num11 = 0;
															int num13 = 0;
															if (!flag39)
															{
																bool flag40 = (object)titleFont == null;
																obj15 = 0;
																flag34 = false;
																textureFormat = (TextureFormat)3;
																num9 = unchecked((nint)null);
																num5 = 0;
																if (flag40)
																{
																	goto IL_27d2;
																}
																string baked = titleFont.text;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
																object obj86 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																ScreenFont screenFont = default;
																screenFont._002Ector(baked);
																num11 = 0;
																num13 = (int)screenFont;
															}
															obj82 = num13;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															num12 = num13;
														}
														obj87 = this + 144;
														bool flag41 = obj87 == null;
														object obj88 = !flag41;
														if (obj88 == null)
														{
															object obj89 = obj7;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2306 @ X0_v271+E4]");
															bool flag42 = (nint)0 == 0;
															object obj90 = !flag42;
															if (obj90 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															bool flag43 = textFont != null;
															bool flag44 = !flag43;
															num11 = 0;
															int num14 = 0;
															if (!flag44)
															{
																bool flag45 = (object)textFont == null;
																obj15 = 0;
																flag34 = false;
																textureFormat = (TextureFormat)3;
																num9 = unchecked((nint)null);
																num5 = 0;
																if (flag45)
																{
																	goto IL_27d2;
																}
																string baked2 = textFont.text;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
																object obj91 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																ScreenFont screenFont2 = default;
																screenFont2._002Ector(baked2);
																num11 = 0;
																num14 = (int)screenFont2;
															}
															obj87 = num14;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															num12 = num14;
														}
														object obj92 = obj8;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ X0_v143+E4]");
														bool flag46 = (nint)0 == 0;
														object obj93 = !flag46;
														if (obj93 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															obj92 = obj8;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ X0_v143+A0]");
														obj94 = 0;
														object obj95 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj96, 16));
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														object obj97 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj96, 16));
														object obj98 = obj8;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2381 @ X8_v81+A0]");
														object obj99 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														object obj100 = obj8;
														object obj101 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj96, 16));
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2406 @ X8_v83+A0]");
														object obj102 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														object obj103 = obj8;
														int num15;
														if (tab == 1)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1B50]");
															num15 = 0;
														}
														else
														{
															num15 = num;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2450 @ X0_v151+E4]");
														bool flag47 = (nint)0 == 0;
														object obj104 = !flag47;
														if (obj104 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															obj103 = obj8;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2450 @ X0_v151+A0]");
														obj105 = 0;
														object obj106 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj96, 16));
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														object obj107 = default;
														Line((ScreenFont)obj82, 10, 8, (string)((int*)num15)->m_value, (ShiftAuth.Style)(&obj107), centred: false);
														GillaBoardLook.Rule(px, 160, 240, 8, 151, 30);
														if (tab != 0)
														{
															num16 = 0;
															flag48 = false;
															obj19 = obj96;
															obj108 = obj105;
															obj15 = 2;
															num10 = 30;
															flag34 = true;
															textureFormat = (TextureFormat)8;
															num9 = 240;
															num5 = 160;
															object obj109 = 0;
															object obj147 = default;
															int num22 = default;
															object obj167 = default;
															object obj169 = default;
															while (true)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AD8]");
																object obj110 = 0;
																object obj111 = obj110;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v224+E4]");
																bool flag49 = (nint)0 == 0;
																object obj112 = !flag49;
																if (obj112 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	obj111 = obj110;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v224+A0]");
																object obj113 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v159+8]");
																object obj114 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v159+8]");
																bool flag50 = (nint)0 == 0;
																obj115 = 0;
																if (flag50)
																{
																	break;
																}
																object obj116 = obj109;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X9_v61+18]");
																if ((nint)obj116 >= 0)
																{
																	goto IL_183a;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v224+E4]");
																bool flag51 = (nint)0 == 0;
																object obj117 = !flag51;
																if (obj117 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	obj111 = obj110;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v224+A0]");
																	obj113 = 0;
																}
																object obj118 = obj113;
																bool flag52 = obj113 == null;
																obj115 = 0;
																if (flag52)
																{
																	break;
																}
																object obj119 = obj109;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X9_v68+18]");
																bool flag53 = (nint)obj119 < 0;
																object obj120 = !flag53;
																obj121 = obj71;
																obj17 = 1;
																obj115 = 0;
																obj18 = obj94;
																if (obj120 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v159+8]");
																	object obj122 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v159+8]");
																	bool flag54 = (nint)0 == 0;
																	obj115 = 0;
																	if (flag54)
																	{
																		break;
																	}
																	object obj123 = obj109;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v196+18]");
																	bool flag55 = (nint)obj123 < 0;
																	object obj124 = !flag55;
																	obj121 = obj71;
																	obj17 = 1;
																	obj115 = 0;
																	obj18 = obj94;
																	if (obj124 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v159+8]");
																		object obj125 = 0 + obj109;
																		object obj126 = obj113 + obj109;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2854 @ X10_v59+20]");
																		object obj133;
																		if ((nint)0 != 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v224+E4]");
																			bool flag56 = (nint)0 == 0;
																			object obj127 = !flag56;
																			if (obj127 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																				object obj128 = obj110;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2950 @ X8_v199+A0]");
																				object obj129 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2951 @ X8_v200+8]");
																				obj122 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2951 @ X8_v200+8]");
																				bool flag57 = (nint)0 == 0;
																				obj115 = 0;
																				if (flag57)
																				{
																					break;
																				}
																			}
																			object obj130 = obj109;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v196+18]");
																			bool flag58 = (nint)obj130 < 0;
																			object obj131 = !flag58;
																			obj121 = obj71;
																			obj17 = 1;
																			obj115 = 0;
																			obj18 = obj94;
																			if (obj131 != null)
																			{
																				goto IL_1f90;
																			}
																			object obj132 = obj122 + obj109;
																			obj133 = obj132 + 32;
																		}
																		else
																		{
																			obj133 = (object)(&num8);
																		}
																		object obj134 = obj8;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2954 @ X0_v227+E4]");
																		bool flag59 = (nint)0 == 0;
																		object obj135 = !flag59;
																		if (obj135 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																			obj134 = obj8;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2954 @ X0_v227+A0]");
																		object obj136 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2855 @ X9_v69+20]");
																		nint num17 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2956 @ X8_v163+18]");
																		Fill(8, (int)num17, 144, 38, (Color32)0);
																		object obj137 = obj8;
																		object obj139;
																		if (num7 < (nint)obj133)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3032 @ X0_v230+E4]");
																			bool flag60 = (nint)0 == 0;
																			object obj138 = !flag60;
																			if (obj138 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																				obj137 = obj8;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3032 @ X0_v230+A0]");
																			obj139 = (nint)0 + (nint)40;
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3032 @ X0_v230+E4]");
																			bool flag61 = (nint)0 == 0;
																			object obj140 = !flag61;
																			if (obj140 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																				obj137 = obj8;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3032 @ X0_v230+A0]");
																			obj139 = (nint)0 + (nint)44;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3032 @ X0_v230+E4]");
																		bool flag62 = (nint)0 == 0;
																		object obj141 = !flag62;
																		if (obj141 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2855 @ X9_v69+20]");
																		int y = (int)((nint)0 + (nint)7);
																		GillaBoardLook.Box(px, 160, 240, 12, y, 34, 24, (Color32)obj139);
																		object obj142 = num7 - obj133;
																		bool flag63 = (nint)obj142 < 0;
																		int num18 = num7 ^ obj133;
																		int num19 = num7 ^ obj142;
																		int num20 = num18 & num19;
																		bool flag64 = num20 < 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2855 @ X9_v69+20]");
																		int num21 = (int)((nint)0 + (nint)15);
																		bool flag65 = flag63 == flag64;
																		object obj143 = !flag65;
																		object obj144 = ~obj143;
																		object obj145 = ((obj144 != null) ? ((object)(&obj17)) : ((object)(&obj16)));
																		obj15 = obj145;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3103 @ X8_v166+10]");
																		obj108 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD10]");
																		object obj146 = 0;
																		Line(this.text, (int)typeof(_0021_00210), num21, (string)obj146, (ShiftAuth.Style)(&obj147), centred: true);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AD8]");
																		object obj148 = 0;
																		object obj149 = obj148;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v235+E4]");
																		bool flag66 = (nint)0 == 0;
																		object obj150 = !flag66;
																		if (obj150 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																			obj149 = obj148;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v235+A0]");
																		object obj151 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3124 @ X8_v170+8]");
																		object obj152 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3124 @ X8_v170+8]");
																		bool flag67 = (nint)0 == 0;
																		color = (Color32)obj139;
																		flag48 = true;
																		obj115 = 0;
																		num10 = (int)(&obj147);
																		flag34 = (byte)(int)obj146 != 0;
																		textureFormat = (TextureFormat)num21;
																		num9 = (nint)typeof(_0021_00210);
																		num5 = (int)this.text;
																		if (flag67)
																		{
																			break;
																		}
																		object obj153 = obj109;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v171+18]");
																		bool flag68 = (nint)obj153 < 0;
																		object obj154 = !flag68;
																		color = (Color32)obj139;
																		obj121 = obj71;
																		flag48 = true;
																		obj17 = 1;
																		obj115 = 0;
																		obj18 = obj94;
																		num10 = (int)(&obj147);
																		flag34 = (byte)(int)obj146 != 0;
																		textureFormat = (TextureFormat)num21;
																		num9 = (nint)typeof(_0021_00210);
																		num5 = (int)this.text;
																		if (obj154 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3124 @ X8_v170+8]");
																			object obj155 = 0 + obj109;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3142 @ X8_v172+20]");
																			object obj156;
																			string line;
																			if ((nint)0 != 0)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
																				obj156 = 0;
																				string text7 = num22.ToString((string)obj156);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60E0]");
																				object obj157 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6148]");
																				object obj158 = 0;
																				string text8 = (string)obj157 + text7 + (string)obj158;
																				line = text8;
																			}
																			else
																			{
																				int num23 = num6 + 1;
																				string text9 = num16.ToString();
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC620]");
																				object obj159 = 0;
																				string text10 = (string)obj159 + text9;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
																				obj156 = 0;
																				num16 = num23;
																				line = text10;
																			}
																			object obj160 = num7 - obj133;
																			bool flag69 = (nint)obj160 < 0;
																			int num24 = num7 ^ obj133;
																			int num25 = num7 ^ obj160;
																			int num26 = num24 & num25;
																			bool flag70 = num26 < 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2855 @ X9_v69+20]");
																			int y2 = (int)((nint)0 + (nint)8);
																			bool flag71 = flag69 == flag70;
																			object obj161 = !flag71;
																			object obj162 = ~obj161;
																			object obj163 = ((obj162 != null) ? ((object)(&obj17)) : ((object)(&obj16)));
																			bool flag72 = flag69 == flag70;
																			object obj164 = !flag72;
																			object obj165 = ~obj164;
																			object obj166 = ((obj165 != null) ? ((object)(&obj19)) : ((object)(&obj16)));
																			Line(this.text, 52, y2, line, (ShiftAuth.Style)(&obj167), centred: false);
																			string text11 = num22.ToString((string)obj156);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB800]");
																			object obj168 = 0;
																			string text12 = text11 + (string)obj168;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2504 @ X23_v29+10]");
																			obj108 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2855 @ X9_v69+20]");
																			int num27 = (int)((nint)0 + (nint)20);
																			Line(this.text, 52, num27, text12, (ShiftAuth.Style)(&obj169), centred: false);
																			obj109++;
																			obj167 = obj163;
																			obj147 = obj15;
																			obj169 = obj166;
																			color = (Color32)obj139;
																			flag48 = false;
																			obj15 = obj166;
																			num10 = (int)(&obj169);
																			flag34 = (byte)(int)text12 != 0;
																			textureFormat = (TextureFormat)num27;
																			num9 = 52;
																			num5 = (int)this.text;
																			continue;
																		}
																	}
																}
																goto IL_1f90;
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
															object obj170 = 0;
															object obj171 = obj170;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2469 @ X0_v159+E4]");
															bool flag73 = (nint)0 == 0;
															object obj172 = !flag73;
															if (obj172 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															object obj173 = obj170;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v163+E4]");
															bool flag74 = (nint)0 == 0;
															object obj174 = !flag74;
															if (obj174 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																obj173 = obj170;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v163+A0]");
															object obj175 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v97+10]");
															object obj176 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v97+10]");
															bool flag75 = (nint)0 == 0;
															flag48 = false;
															obj115 = 0;
															obj108 = obj105;
															obj15 = 2;
															num10 = 30;
															flag34 = true;
															textureFormat = (TextureFormat)8;
															num9 = 240;
															num5 = 160;
															if (!flag75)
															{
																object obj177 = obj176;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AF8]");
																object obj178 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2552 @ X8_v98+12E]");
																object obj179 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2552 @ X8_v98+12E]");
																if ((nint)0 == 0)
																{
																	goto IL_1aa2;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2552 @ X8_v98+98]");
																object obj180 = (nint)0 + (nint)8;
																while (true)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2632 @ X10_v54-8]");
																	if (0 == (nint)obj178)
																	{
																		break;
																	}
																	obj179--;
																	obj180 += 16;
																	if ((nint)obj179 != 1)
																	{
																		continue;
																	}
																	goto IL_1aa2;
																}
																object obj181 = obj177 + obj180;
																object obj182 = obj181 + 312;
																num28 = 240;
																goto IL_2d2c;
															}
														}
														goto IL_27d2;
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
			goto IL_1f90;
		}
		goto IL_27d2;
		IL_31af:
		OutOfMemoryException ex = default;
		bool flag76 = ex == null;
		object obj183 = !flag76;
		if (obj183 != null)
		{
			goto IL_27e0;
		}
		object obj184 = default;
		bool flag77 = obj184 == null;
		object obj185 = !flag77;
		OutOfMemoryException ex2 = ex;
		if (obj185 != null)
		{
			goto IL_27ee;
		}
		object obj187 = default;
		object obj186 = obj187;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1B08]");
		object obj188 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1751 @ X8_v40+12E]");
		object obj189 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1751 @ X8_v40+12E]");
		if ((nint)0 == 0)
		{
			goto IL_222d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1751 @ X8_v40+98]");
		object obj190 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1805 @ X10_v18-8]");
			if (0 == (nint)obj188)
			{
				break;
			}
			obj189--;
			obj190 += 16;
			if ((nint)obj189 != 1)
			{
				continue;
			}
			goto IL_222d;
		}
		object obj191 = obj186 + obj190;
		object obj192 = obj191 + 312;
		goto IL_323e;
		IL_2125:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num9 = unchecked((nint)null);
		goto IL_31fb;
		IL_1f9e:
		NullReferenceException ex3 = new NullReferenceException();
		NullReferenceException ex4;
		if (num5 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj184 = 1;
		}
		else
		{
			bool flag78 = num5 != 1;
			ex4 = ex3;
			if (flag78)
			{
				goto IL_318c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj193 = default;
			ex = (OutOfMemoryException)obj193;
		}
		goto IL_203c;
		IL_183a:
		string line2 = said;
		ScreenFont screenFont3 = this.text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD10]");
		ScreenFont screenFont4 = (ScreenFont)0;
		bool flag79 = said == null;
		object obj194 = !flag79;
		object obj200;
		string text14;
		if (obj194 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj195 = 0;
			object obj196 = obj195;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2562 @ X0_v217+E4]");
			bool flag80 = (nint)0 == 0;
			object obj197 = !flag80;
			if (obj197 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string boltsText = Coins.BoltsText;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D18]");
			object obj198 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB800]");
			object obj199 = 0;
			string text13 = (string)obj198 + boltsText + (string)obj199;
			bool flag81 = said == null;
			line2 = text13;
			text14 = text13;
			if (flag81)
			{
				line2 = text14;
				obj200 = (object)(&obj19);
				goto IL_3133;
			}
		}
		obj200 = (sayBad ? ((object)(&obj16)) : ((object)(&obj17)));
		goto IL_3133;
		IL_27ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex5 = default;
		ex4 = ex5;
		goto IL_318c;
		IL_318c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_3546:
		ScreenFont font;
		ShiftAuth.Style style;
		int y3;
		int x;
		Line(font, x, y3, line2, style, centred: true);
		bool flag82 = true;
		object obj201 = 0;
		int num29 = 43;
		object obj204;
		ScreenFont screenFont5;
		object obj208 = default;
		int num30;
		bool flag86;
		do
		{
			object obj202 = obj8;
			if ((nint)obj201 == tab)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2113 @ X0_v29+E4]");
				bool flag83 = (nint)0 == 0;
				object obj203 = !flag83;
				if (obj203 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj202 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2113 @ X0_v29+A0]");
				obj204 = (nint)0 + (nint)44;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2113 @ X0_v29+E4]");
				bool flag84 = (nint)0 == 0;
				object obj205 = !flag84;
				if (obj205 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj202 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2113 @ X0_v29+A0]");
				obj204 = (nint)0 + (nint)40;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2113 @ X0_v29+E4]");
			bool flag85 = (nint)0 == 0;
			object obj206 = !flag85;
			if (obj206 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int x2 = num29 - 35;
			GillaBoardLook.Box(px, 160, 240, x2, 214, 70, 20, (Color32)obj204);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1B38]");
			screenFont5 = (ScreenFont)0;
			font = this.text;
			if (obj201 != null)
			{
				screenFont5 = screenFont4;
			}
			object obj207 = (((nint)obj201 != tab) ? ((object)(&obj16)) : ((object)(&obj17)));
			line2 = (string)(object)screenFont5;
			obj15 = obj207;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X9_v12+10]");
			obj108 = 0;
			Line(font, num29, 220, (string)(object)screenFont5, (ShiftAuth.Style)(&obj208), centred: true);
			obj201++;
			num30 = num29 + 74;
			flag86 = (nint)obj201 != 2;
			obj208 = obj207;
			color = (Color32)obj204;
			flag82 = true;
			style = (ShiftAuth.Style)(&obj208);
			y3 = 220;
			x = num29;
			num29 = num30;
		}
		while (flag86);
		bool flag87 = obj121 == null;
		color = (Color32)obj204;
		flag48 = true;
		num10 = (int)(&obj208);
		flag34 = (byte)(int)screenFont5 != 0;
		textureFormat = (TextureFormat)220;
		num9 = num30;
		num5 = (int)font;
		if (!flag87)
		{
			((Texture2D)obj121).SetPixels32(px);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AD8]");
			object obj209 = 0;
			bool flag88 = (object)tex == null;
			color = (Color32)obj204;
			flag48 = true;
			num10 = (int)(&obj208);
			flag34 = (byte)(int)screenFont5 != 0;
			textureFormat = (TextureFormat)220;
			num9 = unchecked((nint)null);
			num5 = (int)px;
			if (!flag88)
			{
				tex.Apply(updateMipmaps: true);
				int value = ((int*)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2259 @ X0_v35 (System.Int32)+E4]");
				bool flag89 = (nint)0 == 0;
				object obj210 = !flag89;
				if (obj210 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag90 = screen == null;
				bool flag91 = !flag90;
				object obj211 = !flag91;
				if (obj211 != null)
				{
					return;
				}
				object obj212 = this + 128;
				bool flag92 = obj212 == null;
				object obj213 = !flag92;
				num5 = 0;
				if (obj213 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
					object obj214 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					MaterialPropertyBlock materialPropertyBlock = default;
					materialPropertyBlock._002Ector();
					obj212 = materialPropertyBlock;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num5 = (int)materialPropertyBlock;
				}
				bool flag93 = (object)screen == null;
				color = (Color32)obj204;
				flag48 = true;
				num10 = (int)(&obj208);
				flag34 = (byte)(int)line2 != 0;
				textureFormat = (TextureFormat)220;
				num9 = unchecked((nint)null);
				if (!flag93)
				{
					screen.GetPropertyBlock((MaterialPropertyBlock)obj212);
					object obj215 = obj209;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2418 @ X0_v41+E4]");
					bool flag94 = (nint)0 == 0;
					object obj216 = !flag94;
					if (obj216 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag95 = obj212 == null;
					color = (Color32)obj204;
					flag48 = true;
					num10 = (int)(&obj208);
					flag34 = (byte)(int)line2 != 0;
					textureFormat = (TextureFormat)220;
					num9 = unchecked((nint)null);
					num5 = (int)obj212;
					if (!flag95)
					{
						object obj217 = obj209;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2441 @ X8_v25+A0]");
						object obj218 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v26+14]");
						num5 = 0;
						object obj219 = obj212;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v26+14]");
						((MaterialPropertyBlock)obj219).SetTexture(0, (Texture)tex);
						bool flag96 = (object)screen == null;
						color = (Color32)obj204;
						flag48 = true;
						num10 = (int)(&obj208);
						flag34 = (byte)(int)line2 != 0;
						textureFormat = (TextureFormat)0;
						num9 = (nint)tex;
						if (!flag96)
						{
							screen.SetPropertyBlock((MaterialPropertyBlock)obj212);
							return;
						}
					}
				}
			}
		}
		goto IL_27d2;
		IL_1f68:
		object obj221 = default;
		object obj220 = (object)(&obj221);
		throw new NullReferenceException();
		IL_1aa2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num28 = 0;
		goto IL_2d2c;
		IL_203c:
		object obj222 = obj220;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD10]");
		screenFont4 = (ScreenFont)0;
		if (obj220 == null)
		{
			goto IL_31af;
		}
		object obj223 = obj222;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		object obj224 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1471 @ X8_v50+12E]");
		object obj225 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1471 @ X8_v50+12E]");
		if ((nint)0 == 0)
		{
			goto IL_2125;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1471 @ X8_v50+98]");
		object obj226 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1730 @ X10_v26-8]");
			if (0 == (nint)obj224)
			{
				break;
			}
			obj225--;
			obj226 += 16;
			if ((nint)obj225 != 1)
			{
				continue;
			}
			goto IL_2125;
		}
		object obj227 = obj223 + obj226;
		object obj228 = obj227 + 312;
		goto IL_31fb;
		IL_2d2c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2750 @ X0_v164] (should have been resolved before IL gen)");
		object obj229 = default;
		bool flag97 = obj229 == null;
		obj16 = 1;
		obj19 = obj96;
		text14 = (string)151;
		screenFont3 = (ScreenFont)109895680;
		if (flag97)
		{
			goto IL_1f68;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		object obj230 = 0;
		num16 = 0;
		flag48 = false;
		obj108 = obj105;
		obj15 = 2;
		num10 = 30;
		flag34 = true;
		textureFormat = (TextureFormat)8;
		object obj231 = obj229;
		int num31 = 38;
		object obj238 = default;
		int num32 = default;
		IntPtr intPtr = default;
		string monster = default;
		IntPtr intPtr2 = default;
		object obj264 = default;
		while (true)
		{
			object obj232 = obj231;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2875 @ X8_v104+12E]");
			object obj233 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2875 @ X8_v104+12E]");
			if ((nint)0 == 0)
			{
				goto IL_1b9e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2875 @ X8_v104+98]");
			object obj234 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2930 @ X10_v49-8]");
				if (0 == (nint)obj230)
				{
					break;
				}
				obj233--;
				obj234 += 16;
				if ((nint)obj233 != 1)
				{
					continue;
				}
				goto IL_1b9e;
			}
			object obj235 = obj232 + obj234;
			object obj236 = obj235 + 312;
			num9 = num28;
			goto IL_2d9b;
			IL_2d9b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2967 @ X0_v170+8]");
			num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2967 @ X0_v170] (should have been resolved before IL gen)");
			object obj237 = obj238 & 1;
			bool flag98 = obj237 == null;
			obj220 = (object)(&obj221);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v97+10]");
			obj187 = 0;
			ex = null;
			obj184 = 0;
			obj121 = obj71;
			obj17 = 1;
			obj115 = 0;
			obj18 = obj94;
			if (flag98)
			{
				break;
			}
			bool flag99 = obj229 == null;
			obj220 = (object)(&obj221);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v97+10]");
			obj187 = 0;
			ex = null;
			obj184 = 0;
			obj121 = obj71;
			obj17 = 1;
			obj115 = 0;
			obj18 = obj94;
			if (flag99)
			{
				goto IL_1f9e;
			}
			object obj239 = obj229;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2988 @ X8_v107+12E]");
			object obj240 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1B00]");
			object obj241 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2988 @ X8_v107+12E]");
			if ((nint)0 == 0)
			{
				goto IL_1ce3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2988 @ X8_v107+98]");
			object obj242 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3039 @ X10_v44-8]");
				if (0 == (nint)obj241)
				{
					break;
				}
				obj240--;
				obj242 += 16;
				if ((nint)obj240 != 1)
				{
					continue;
				}
				goto IL_1ce3;
			}
			object obj243 = obj239 + obj242;
			object obj244 = obj243 + 312;
			goto IL_2e4c;
			IL_2e4c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3080 @ X0_v173+8]");
			num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3080 @ X0_v173] (should have been resolved before IL gen)");
			bool flag100 = num31 < 165;
			object obj245 = !flag100;
			obj220 = (object)(&obj221);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v97+10]");
			obj187 = 0;
			ex = null;
			obj184 = 0;
			obj121 = obj71;
			obj17 = 1;
			obj115 = 0;
			obj18 = obj94;
			if (obj245 != null)
			{
				break;
			}
			object obj246 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3094 @ X0_v177+E4]");
			bool flag101 = (nint)0 == 0;
			object obj247 = !flag101;
			if (obj247 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj246 = obj8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3094 @ X0_v177+A0]");
			object obj248 = 0;
			int y4 = num31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3096 @ X8_v111+18]");
			Fill(8, y4, 144, 42, (Color32)0);
			string text15 = num32.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC620]");
			object obj249 = 0;
			string line3 = (string)obj249 + text15;
			object obj250 = num6 - num5;
			bool flag102 = (nint)obj250 < 0;
			int num33 = num6 ^ num5;
			int num34 = num6 ^ obj250;
			int num35 = num33 & num34;
			bool flag103 = num35 < 0;
			bool flag104 = flag102 == flag103;
			object obj251 = !flag104;
			object obj252 = ~obj251;
			if (obj252 == null)
			{
				ScreenFont screenFont6 = (ScreenFont)(&obj19);
			}
			else
			{
				ScreenFont screenFont6 = (ScreenFont)(&obj17);
			}
			int y5 = num31 + 5;
			Line((ScreenFont)obj87, 14, y5, line3, (ShiftAuth.Style)(&intPtr), centred: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AD8]");
			object obj253 = 0;
			object obj254 = obj253;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3167 @ X0_v184+E4]");
			bool flag105 = (nint)0 == 0;
			object obj255 = !flag105;
			if (obj255 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text16 = Label(monster);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1B18]");
			object obj256 = 0;
			string line4 = text16 + (string)obj256;
			object obj257 = num6 - num5;
			bool flag106 = (nint)obj257 < 0;
			int num36 = num6 ^ num5;
			int num37 = num6 ^ obj257;
			int num38 = num36 & num37;
			bool flag107 = num38 < 0;
			bool flag108 = flag106 == flag107;
			object obj258 = !flag108;
			object obj259 = ~obj258;
			if (obj259 == null)
			{
			}
			int y6 = num31 + 17;
			Line((ScreenFont)obj87, 14, y6, line4, (ShiftAuth.Style)(&intPtr2), centred: false);
			object obj262;
			if (num6 < num5)
			{
				int num39 = num32 - num6;
				string text17 = num16.ToString();
				object obj260 = num32 - num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1B30]");
				object obj261 = 0;
				if ((nint)obj260 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1B10]");
					obj261 = 0;
				}
				string text18 = text17 + (string)obj261;
				num16 = num39;
				text14 = text18;
				obj262 = (object)(&obj16);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1B20]");
				object obj263 = 0;
				text14 = (string)obj263;
				obj262 = (object)(&obj17);
			}
			obj15 = obj262;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2850 @ X8_v122+10]");
			obj108 = 0;
			int num40 = num31 + 29;
			Line((ScreenFont)obj87, 14, num40, text14, (ShiftAuth.Style)(&obj264), centred: false);
			num31 += 48;
			bool flag109 = obj229 == null;
			object obj265 = !flag109;
			screenFont4 = (ScreenFont)(&obj16);
			num = num6;
			screenFont3 = (ScreenFont)(&obj19);
			flag48 = false;
			num10 = (int)(&obj264);
			flag34 = (byte)(int)text14 != 0;
			textureFormat = (TextureFormat)num40;
			num28 = 14;
			obj231 = obj229;
			if (obj265 != null)
			{
				continue;
			}
			goto IL_1f68;
			IL_1ce3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num9 = unchecked((nint)null);
			goto IL_2e4c;
			IL_1b9e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num9 = unchecked((nint)null);
			goto IL_2d9b;
		}
		goto IL_203c;
		IL_27e0:
		ex2 = new OutOfMemoryException();
		goto IL_27ee;
		IL_323e:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1846 @ X0_v62] (should have been resolved before IL gen)");
		object obj266 = default;
		bool flag110 = obj266 == null;
		object obj267 = !flag110;
		if (obj267 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1B40]");
			object line5 = 0;
			object obj268 = default;
			Line(this.text, 80, 60, (string)line5, (ShiftAuth.Style)(&obj268), centred: true);
		}
		string text19 = num6.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF720]");
		object obj269 = 0;
		string text20 = (string)obj269 + text19;
		obj108 = obj18;
		obj15 = obj19;
		object obj270 = default;
		style = (ShiftAuth.Style)(&obj270);
		line2 = text20;
		y3 = 196;
		x = 80;
		font = this.text;
		goto IL_3546;
		IL_27d2:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_27e0;
		IL_31fb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1765 @ X0_v75+8]");
		num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1765 @ X0_v75] (should have been resolved before IL gen)");
		goto IL_31af;
		IL_3133:
		obj15 = obj200;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2015 @ X8_v90+10]");
		obj108 = 0;
		obj121 = obj71;
		obj17 = 1;
		obj115 = 0;
		object obj271 = default;
		style = (ShiftAuth.Style)(&obj271);
		y3 = 200;
		x = 80;
		font = screenFont3;
		goto IL_3546;
		IL_222d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num9 = unchecked((nint)null);
		goto IL_323e;
		IL_1f90:
		IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
		goto IL_1f9e;
	}

	private static string Label(string monster)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int monster2 = MonsterChoice.NumberOf(monster);
		MonsterDirector.Entry entry = MonsterCatalog.Of(monster2);
		bool flag2 = entry == null;
		string text = monster;
		if (!flag2)
		{
			bool flag3 = string.IsNullOrEmpty(entry.label);
			bool flag4 = !flag3;
			object obj4 = !flag4;
			text = monster;
			if (obj4 == null)
			{
				text = entry.label;
			}
		}
		if (text != null)
		{
			return text.ToUpperInvariant();
		}
		return (string)(object)new NullReferenceException();
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
				int num = font.DrawCentred(px, 160, 240, num2, y, line, ref *(ShiftAuth.Style*)style);
			}
			else
			{
				int num3 = font.Draw(px, 160, 240, num2, y, line, ref *(ShiftAuth.Style*)style);
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
			PixelFont.Draw(px, 160, 240, x2, y, line, (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref colours[0]), num7);
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
		PixelFont.Fill(px, 160, 240, x, y, w, h, colour2);
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

	public GillaLevelPanel()
	{
		//IL_0010: Expected Obj, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6188]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 40;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj4 = this + 48;
		object obj5 = default;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaLevelPanel()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0192: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00e3: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1B68]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1AD8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+8]");
		_ = 0;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+A0]");
		object obj6 = 0;
		object obj7 = default;
		obj6 = obj7;
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v7+18]");
		bool flag = (nint)0 < (nint)1;
		object obj9 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v7+18]");
		object obj10 = -1;
		bool flag2 = obj10 == null;
		object obj11 = ~obj9;
		object obj12 = obj11 | flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v7+18]");
			bool flag3 = (nint)0 == 2;
			_ = 10;
			if (!flag3)
			{
				object obj13 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
				object obj14 = 0;
				_ = 100;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v10+A0]");
				object obj15 = (nint)0 + (nint)8;
				object obj16 = default;
				obj15 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				int num = Shader.PropertyToID((string)obj14);
				object obj17 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v11+A0]");
				object obj18 = 0;
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
