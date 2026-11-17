using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;
using UnityEngine;

public class GillaBundleStand : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass48_0
	{
		public GillaAtm _003C_003E4__this;

		public int i;

		internal void _003CDrop_003Eb__0(GillaPurchases.Result result)
		{
			//IL_0010: Expected Obj, but got I
			//IL_02d3: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got I4
			//IL_0095: Expected I4, but got I8
			//IL_0141: Expected Obj, but got I
			//IL_016b: Expected Obj, but got I4
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0210: Expected Obj, but got Unknown
			//IL_0220: Expected Obj, but got I
			//IL_0282: Expected F4, but got I
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected Obj, but got Unknown
			//IL_00d3: Expected Obj, but got I
			//IL_01d1: Expected Obj, but got I
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = _003C_003E4__this == null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 != null)
			{
				return;
			}
			GillaAtm gillaAtm = _003C_003E4__this;
			if (result != 0)
			{
				gillaAtm.paying = -1;
				if (result == (GillaPurchases.Result)1)
				{
					object obj5 = gillaAtm + 208;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object messageText = 0;
					gillaAtm.messageText = (string)messageText;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					gillaAtm.message = 0f;
					gillaAtm.messageBad = false;
				}
				else
				{
					object obj6 = gillaAtm + 208;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF678]");
					object messageText2 = 0;
					gillaAtm.messageText = (string)messageText2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					gillaAtm.messageBad = true;
					GillaAtm gillaAtm2 = _003C_003E4__this;
					gillaAtm.message = 2.5f;
					GillaAtm gillaAtm3 = _003C_003E4__this;
					AudioClip errorSound = gillaAtm2.errorSound;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
					gillaAtm3.Play(errorSound, 0f);
				}
			}
			else if (gillaAtm.paying == i)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
				object obj7 = 0;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v10+E4]");
				bool flag4 = (nint)0 == 0;
				object obj9 = !flag4;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int balance = Coins.Balance;
				GillaAtm gillaAtm4 = _003C_003E4__this;
				if (balance <= gillaAtm4.balanceWhenPaid)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6708]");
					object obj10 = 0;
					object obj11 = gillaAtm4 + 208;
					obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					_ = 256;
					_ = 1090519040;
				}
			}
			GillaAtm gillaAtm5 = _003C_003E4__this;
			gillaAtm5.dirty = true;
		}
	}

	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public GillaBundleStand _003C_003E4__this;

		public int with;

		public string name;

		internal void _003CPressMonster_003Eb__0(GillaPurchases.Result result)
		{
			//IL_018c: Expected Obj, but got I
			//IL_01b6: Expected Obj, but got I4
			//IL_01e3: Expected Obj, but got I
			//IL_01f3: Expected Obj, but got I
			//IL_001f: Expected Obj, but got I4
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Expected Obj, but got Unknown
			//IL_0232: Expected I, but got Obj
			//IL_005f: Expected Obj, but got I
			//IL_00a1: Expected Obj, but got I
			//IL_00b1: Expected Obj, but got I
			//IL_00e1: Expected Obj, but got I
			//IL_010b: Expected Obj, but got I4
			//IL_0138: Expected Obj, but got I
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Expected Obj, but got Unknown
			//IL_0177: Expected I, but got Obj
			GillaBundleStand gillaBundleStand;
			AudioClip clip;
			object obj8;
			if (result != (GillaPurchases.Result)2)
			{
				bool flag = result == 0;
				object obj = !flag;
				if (obj != null)
				{
					gillaBundleStand = _003C_003E4__this;
					clip = null;
					goto IL_027a;
				}
				GillaBundleStand gillaBundleStand2 = _003C_003E4__this;
				float unscaledTime = Time.unscaledTime;
				GillaBundleStand gillaBundleStand3 = _003C_003E4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
				object obj2 = 0;
				float checkingUntil = unscaledTime + gillaBundleStand3.checkingFor;
				gillaBundleStand2.checkingUntil = checkingUntil;
				int num = default;
				string text = num.ToString((string)obj2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7B8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7B0]");
				object obj4 = 0;
				string text2 = name + (string)obj3 + text + (string)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v19+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7A0]");
				object title = 0;
				GillaToast.Show(with, (string)title, text2, error: false);
				gillaBundleStand = _003C_003E4__this;
				obj8 = _003C_003E4__this + 80;
				nint num2 = (nint)text2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
				object obj9 = 0;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v6+E4]");
				bool flag3 = (nint)0 == 0;
				object obj11 = !flag3;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7C0]");
				object title2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7A8]");
				object obj12 = 0;
				GillaToast.Show(with, (string)title2, (string)obj12, error: true);
				gillaBundleStand = _003C_003E4__this;
				obj8 = _003C_003E4__this + 88;
				nint num2 = (nint)obj12;
			}
			clip = (AudioClip)obj8;
			goto IL_027a;
			IL_027a:
			gillaBundleStand.Play(clip);
		}
	}

	public string bundleName;

	public string monsterName;

	public Renderer screen;

	public PressKey buyKey;

	public TextAsset titleFont;

	public TextAsset textFont;

	public AudioClip buySound;

	public AudioClip denySound;

	public AudioClip wearSound;

	public float reach;

	public float checkingFor;

	public const int W = default(int);

	public const int H = default(int);

	public static readonly RectInt Button;

	private const float AskEvery = default(float);

	private const float OpenFor = default(float);

	private const float ShutFor = default(float);

	private static readonly int BaseMap;

	private static readonly Color32[] Ink;

	private Texture2D tex;

	private Color32[] px;

	private MaterialPropertyBlock block;

	private ScreenFont title;

	private ScreenFont text;

	private string shown;

	private float nextAsk;

	private float checkingUntil;

	private float popT = 1f;

	private bool near;

	private Vector3 fullSize;

	private string LabelShown__BackingField;

	private string LinesShown__BackingField;

	private Coins.Bundle Bundle
	{
		get
		{
			if (string.IsNullOrEmpty(bundleName))
			{
				return null;
			}
			return CosmeticCatalog.BundleNamed(bundleName);
		}
	}

	public string LabelShown
	{
		get
		{
			return LabelShown__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 192;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public string LinesShown
	{
		get
		{
			return LinesShown__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 200;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_039e: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0172: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I4
		//IL_01d5: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_013c: Expected I, but got Obj
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_029c: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I4
		//IL_02cb: Expected Obj, but got I
		//IL_02e7: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_0248: Expected Obj, but got I4
		//IL_0319: Expected Obj, but got I
		//IL_033e: Expected Obj, but got I4
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
		if (!(screen == null))
		{
			Transform transform = screen.transform;
			Vector3 localScale = transform.localScale;
			object obj4 = obj;
			Vector3 vector = default;
			fullSize = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = buyKey != null;
			bool flag4 = !flag3;
			object obj6 = 0;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6A0]");
				object obj8 = 0;
				Action<System.__Canon> action = default;
				action._002Ector((object)this, (IntPtr)obj8);
				buyKey.Pressed += (Action<PressKey>)action;
				obj6 = 0;
			}
			object obj9 = this + 152;
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X20_v7-58]");
			bool flag6 = (UnityEngine.Object)0 != null;
			bool flag7 = !flag6;
			object obj12 = 0;
			ScreenFont screenFont = null;
			if (!flag7)
			{
				string baked = titleFont.text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ScreenFont screenFont2 = default;
				screenFont2._002Ector(baked);
				obj12 = 0;
				screenFont = screenFont2;
			}
			object obj14 = this + 136;
			obj14 = screenFont;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v25+E4]");
			bool flag8 = (nint)0 == 0;
			object obj16 = !flag8;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X21_v5-40]");
			bool flag9 = (UnityEngine.Object)0 != null;
			bool flag10 = !flag9;
			object obj17 = 0;
			ScreenFont screenFont3 = null;
			if (!flag10)
			{
				string baked2 = textFont.text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ScreenFont screenFont4 = default;
				screenFont4._002Ector(baked2);
				obj17 = 0;
				screenFont3 = screenFont4;
			}
			object obj19 = this + 144;
			obj19 = screenFont3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Show();
		}
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_0097: Expected I, but got Obj
		//IL_00b4: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I
		//IL_01d3: Expected Obj, but got I
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01ff: Expected Obj, but got I
		//IL_015c: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = buyKey != null;
		bool flag3 = !flag2;
		object obj4 = 0;
		Action<PressKey> action = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Action<System.__Canon> action2 = default;
			action2._002Ector((object)this, (IntPtr)obj6);
			buyKey.Pressed -= (Action<PressKey>)action2;
			obj4 = 0;
			action = (Action<PressKey>)action2;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (screen != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v12+A0]");
			object obj11 = 0;
			object obj12 = fullSize - obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBundleStand)+B8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v13+8]");
			object obj13 = num - 0;
			object obj14 = obj12 * obj12;
			object obj15 = obj13 * obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			object obj16 = obj15 + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
			if ((nint)obj16 >= 0)
			{
				Transform transform = screen.transform;
				transform.localScale = (Vector3)0;
				screen.enabled = true;
			}
		}
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

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_06db: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I4
		//IL_029a: Expected F4, but got I4
		//IL_021e: Invalid comparison between F4 and I4
		//IL_0536: Invalid comparison between F4 and I4
		//IL_0545: Invalid comparison between F4 and I4
		//IL_055d: Expected Obj, but got F8
		//IL_056a: Expected Obj, but got F4
		//IL_059f: Expected Obj, but got I4
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected Obj, but got Unknown
		//IL_02af: Expected Obj, but got I
		//IL_02fa: Invalid comparison between F4 and I4
		//IL_0309: Invalid comparison between F4 and I4
		//IL_0321: Expected Obj, but got F8
		//IL_032e: Expected Obj, but got F4
		//IL_0363: Expected Obj, but got I4
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_05f7: Expected VT, but got I4
		//IL_0758: Expected Obj, but got I4
		//IL_061c: Invalid comparison between F8 and I4
		//IL_062b: Invalid comparison between F8 and I4
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected Obj, but got Unknown
		//IL_0653: Expected Obj, but got F8
		//IL_0688: Expected Obj, but got I4
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected I4, but got Unknown
		//IL_03be: Invalid comparison between F4 and I4
		//IL_03cf: Expected Obj, but got I4
		//IL_03d8: Invalid comparison between F4 and I4
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected Obj, but got Unknown
		//IL_03fd: Expected F8, but got I4
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
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (screen == null)
		{
			return;
		}
		Camera main = Camera.main;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5;
		if (main != null)
		{
			Transform transform = main.transform;
			Vector3 position = transform.position;
			Transform transform2 = base.transform;
			Vector3 position2 = transform2.position;
			object obj10 = default;
			object obj9 = obj10 - obj10;
			object obj12 = default;
			object obj11 = obj12 - obj12;
			float num2 = default;
			float num = num2 - num2;
			object obj13 = obj9 * obj9;
			object obj14 = obj11 * obj11;
			object obj15 = obj13 + obj14;
			float num3 = num * num;
			float num4 = num3 + (float)obj15;
			float num5 = reach * reach;
			float num6 = num4 - num5;
			bool flag4 = num6 < 0f;
			UnityEngine.Object obj16 = null;
			flag5 = flag4;
		}
		else
		{
			UnityEngine.Object obj16 = null;
			flag5 = false;
		}
		float num7;
		if (near == flag5)
		{
			num7 = popT;
			if (!((double)popT < 1.0))
			{
				goto IL_06aa;
			}
		}
		else
		{
			near = flag5;
			popT = 0f;
			num7 = 0f;
		}
		float deltaTime = Time.deltaTime;
		double num13;
		if (~(near ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6C0]");
			object obj17 = 0;
			float num8 = deltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
			float num9 = num8 / 0f;
			object obj18 = obj17;
			float num10 = num7 + num9;
			float num11 = num10 - 1f;
			bool flag6 = num11 < 0f;
			bool flag7 = num11 == 0f;
			object obj19 = (double)num10 ^ 1.0;
			object obj20 = num10 ^ num11;
			object obj21 = obj19 & obj20;
			bool flag8 = (nint)obj21 < 0;
			bool flag9 = flag6 == flag8;
			object obj22 = !flag7;
			object obj23 = flag9 & obj22;
			object obj24 = ~obj23;
			float num12 = (popT = ((obj24 != null) ? num10 : 1f));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v23+E4]");
			bool flag10 = (nint)0 == 0;
			object obj25 = !flag10;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag11 = num12 < 0f;
			object obj26 = !flag11;
			bool flag12 = num12 == 0f;
			object obj27 = ~obj26;
			object obj28 = obj27 | flag12;
			num13 = 0.0;
			if (obj28 == null)
			{
				bool flag13 = !((double)num12 < 1.0);
				num13 = 1.0;
				if (!flag13)
				{
					float num14 = num12 * -10f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D070");
					float num15 = num12 * 10f;
					float num16 = num15 + -0.75f;
					float num17 = num16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
					float num18 = num17 * 0f;
					float num19 = num18 + num18;
					float num20 = num19 / 3f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
					float num21 = num14 * num20;
					num13 = (double)num21 + 1.0;
				}
			}
		}
		else
		{
			float num22 = deltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA90]");
			float num23 = num22 / 0f;
			float num24 = num7 + num23;
			float num25 = num24 - 1f;
			bool flag14 = num25 < 0f;
			bool flag15 = num25 == 0f;
			object obj29 = (double)num24 ^ 1.0;
			object obj30 = num24 ^ num25;
			object obj31 = obj29 & obj30;
			bool flag16 = (nint)obj31 < 0;
			bool flag17 = flag14 == flag16;
			object obj32 = !flag15;
			object obj33 = flag17 & obj32;
			object obj34 = ~obj33;
			if (obj34 == null)
			{
				num24 = 1f;
			}
			num13 = 1.0 - (double)num24;
			popT = num24;
		}
		Transform transform3 = screen.transform;
		transform3.localScale = (Vector3)0;
		double num26 = num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		double num27 = num26 - 0.0;
		bool flag18 = num27 < 0.0;
		bool flag19 = num27 == 0.0;
		double num28 = num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		object obj35 = num28 ^ 0;
		object obj36 = num13 ^ num27;
		object obj37 = obj35 & obj36;
		bool flag20 = (nint)obj37 < 0;
		bool flag21 = flag18 == flag20;
		object obj38 = !flag19;
		bool flag22 = (byte)((flag21 & obj38) ? 1 : 0) != 0;
		screen.enabled = flag22;
		goto IL_06aa;
		IL_06aa:
		Show();
	}

	private static float ElasticOut(float t)
	{
		//IL_0009: Invalid comparison between F4 and I4
		//IL_001a: Expected Obj, but got I4
		//IL_0023: Invalid comparison between F4 and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0048: Expected F4, but got I4
		bool flag = t < 0f;
		object obj = !flag;
		bool flag2 = t == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		float result = 0f;
		if (obj3 == null)
		{
			bool flag3 = !((double)t < 1.0);
			result = 1f;
			if (!flag3)
			{
				float num = t * -10f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D070");
				float num2 = t * 10f;
				float num3 = num2 + -0.75f;
				float num4 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
				float num5 = num4 * 0f;
				float num6 = num5 + num5;
				float num7 = num6 / 3f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				float num8 = num * num7;
				result = num8 + 1f;
			}
		}
		return result;
	}

	private void Show()
	{
		//IL_0015: Expected Obj, but got I
		//IL_02ae: Expected Obj, but got I
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_004c: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I4
		//IL_092f: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I4
		//IL_0519: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got I
		//IL_0232: Expected Obj, but got I4
		//IL_066f: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I4
		//IL_0540: Expected Obj, but got I
		//IL_056a: Expected Obj, but got I4
		//IL_0963: Expected Obj, but got I
		//IL_0973: Expected Obj, but got I
		//IL_0995: Expected Obj, but got I4
		//IL_05a8: Expected Obj, but got I4
		//IL_03b1: Expected Obj, but got I
		//IL_03c2: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got I
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected Obj, but got Unknown
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Expected Obj, but got Unknown
		//IL_08ba: Expected Obj, but got I4
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c7: Expected I4, but got Unknown
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Expected Obj, but got Unknown
		//IL_08ef: Expected Obj, but got I4
		//IL_0349: Expected Obj, but got I4
		//IL_094e: Expected Obj, but got I4
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected Obj, but got Unknown
		//IL_0780: Expected Obj, but got I4
		//IL_05f7: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I4
		//IL_07b8: Expected Obj, but got I4
		//IL_0416: Expected Obj, but got I4
		//IL_039c: Expected Obj, but got I
		//IL_01f3: Expected F4, but got I4
		//IL_07ff: Expected Obj, but got I4
		//IL_0808: Expected Obj, but got I4
		//IL_047a: Expected Obj, but got I4
		//IL_0400: Expected Obj, but got I4
		//IL_0638: Expected Obj, but got I4
		//IL_04bd: Expected Obj, but got I4
		//IL_04c8: Expected Obj, but got I4
		//IL_04d5: Expected I4, but got Obj
		object obj;
		Coins.Bundle bundle;
		object obj2;
		string text;
		bool flag6;
		object obj14;
		object obj18;
		string text2;
		bool flag8;
		string text3;
		if (string.IsNullOrEmpty(monsterName))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj = 0;
			bundle = Bundle;
			float unscaledTime;
			if (bundle != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
				obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v60+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				text = GillaPurchases.PriceOf(bundle.sku);
				bool flag2 = text == null;
				object obj5 = !flag2;
				float num;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
					object obj6 = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v83+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (Application.isPlaying)
					{
						unscaledTime = Time.unscaledTime;
						num = nextAsk;
						if (!(unscaledTime < nextAsk))
						{
							float unscaledTime2 = Time.unscaledTime;
							object obj9 = obj2;
							unscaledTime = unscaledTime2 + 1.1146363E+09f;
							nextAsk = unscaledTime;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v90+E4]");
							bool flag4 = (nint)0 == 0;
							object obj10 = !flag4;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							GillaPurchases.FetchPrices();
							num = 1.1146363E+09f;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
				object obj11 = 0;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v65+E4]");
				bool flag5 = (nint)0 == 0;
				object obj13 = !flag5;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				flag6 = Coins.OwnsAll(bundle);
				if (flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4E0]");
					obj14 = 0;
					goto IL_093d;
				}
				unscaledTime = Time.unscaledTime;
				num = checkingUntil;
				if (!(unscaledTime < checkingUntil))
				{
					object obj15 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v79+E4]");
					bool flag7 = (nint)0 == 0;
					object obj16 = !flag7;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (GillaPurchases.Busy)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6B0]");
						obj14 = 0;
						goto IL_093d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6B8]");
					object obj17 = 0;
					if (text == null)
					{
						obj18 = 0;
						text2 = (string)obj17;
					}
					else
					{
						obj18 = 0;
						text2 = text;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6A8]");
					object obj19 = 0;
					text2 = (string)obj19;
					obj18 = 1;
				}
				goto IL_086e;
			}
			unscaledTime = Time.unscaledTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj20 = 0;
			text2 = (string)obj20;
			object obj21 = this + 192;
			obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			flag8 = false;
			text3 = (string)obj20;
			goto IL_0905;
		}
		ShowMonster();
		return;
		IL_086e:
		object obj22 = this + 192;
		obj22 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj23 = obj18 | flag6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X24_v8-14]");
		bool flag9 = (nint)0 == 0;
		object obj24 = !flag9;
		flag8 = (byte)((flag6 & obj24) ? 1 : 0) != 0;
		object obj25 = obj23 & 1;
		bool flag10 = obj25 == null;
		object obj26 = !flag10;
		text3 = text2;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X24_v8-14]");
			bool flag11 = (nint)0 == 0;
			text3 = text2;
			if (!flag11)
			{
				object obj27 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X0_v74+E4]");
				bool flag12 = (nint)0 == 0;
				object obj28 = !flag12;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool busy = GillaPurchases.Busy;
				bool flag13 = text == null;
				object obj29 = (busy ? 1 : 0) ^ 1;
				object obj30 = !flag13;
				flag8 = (byte)(obj30 & obj29) != 0;
				text3 = text2;
			}
		}
		goto IL_0905;
		IL_0905:
		object obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v8+E4]");
		bool flag14 = (nint)0 == 0;
		object obj32 = !flag14;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag15 = buyKey != null;
		bool flag16 = !flag15;
		object obj33 = 0;
		bool flag17 = false;
		if (!flag16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj34 = 0;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v46+E4]");
			bool flag18 = (nint)0 == 0;
			object obj36 = !flag18;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isPlaying = Application.isPlaying;
			bool flag19 = !isPlaying;
			obj33 = 0;
			flag17 = false;
			if (!flag19)
			{
				GameObject gameObject = buyKey.gameObject;
				bool activeSelf = gameObject.activeSelf;
				bool flag20 = flag8 == activeSelf;
				obj33 = 0;
				flag17 = false;
				if (!flag20)
				{
					GameObject gameObject2 = buyKey.gameObject;
					gameObject2.SetActive(flag8);
					obj33 = 0;
					flag17 = flag8;
				}
			}
		}
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v15+E4]");
		bool flag21 = (nint)0 == 0;
		object obj38 = !flag21;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag22 = buyKey != null;
		bool flag23 = !flag22;
		UnityEngine.Object obj39 = null;
		if (!flag23)
		{
			GameObject gameObject3 = buyKey.gameObject;
			bool activeInHierarchy = gameObject3.activeInHierarchy;
			bool flag24 = !activeInHierarchy;
			obj39 = null;
			if (!flag24)
			{
				bool isDown = buyKey.IsDown;
				obj39 = null;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v9+30]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v10+E4]");
		bool flag25 = (nint)0 == 0;
		object obj42 = !flag25;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool down = default;
		string text4 = down.ToString();
		string text5 = text2 + text4;
		object obj43 = this + 152;
		bool flag26 = text5 == (string)obj43;
		bool flag27 = !flag26;
		object obj44 = 0;
		if (!flag27)
		{
			object obj45 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v31+E4]");
			bool flag28 = (nint)0 == 0;
			object obj46 = !flag28;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag29 = tex != null;
			bool flag30 = !flag29;
			object obj47 = !flag30;
			obj44 = 0;
			if (obj47 != null)
			{
				return;
			}
		}
		shown = text5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Draw(bundle, text2, down);
		return;
		IL_093d:
		text2 = (string)obj14;
		obj18 = 0;
		goto IL_086e;
	}

	private void ShowMonster()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0bf2: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0301: Expected Obj, but got I
		//IL_0323: Expected Obj, but got I4
		//IL_0379: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_00b7: Expected Obj, but got I4
		//IL_03bd: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I
		//IL_0520: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_022d: Expected Obj, but got I4
		//IL_03db: Expected Obj, but got I
		//IL_0405: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I4
		//IL_0265: Expected Obj, but got I4
		//IL_0711: Expected Obj, but got I
		//IL_071a: Expected Obj, but got I4
		//IL_0723: Expected Obj, but got I4
		//IL_0593: Expected Obj, but got I4
		//IL_02ac: Expected Obj, but got I4
		//IL_02b5: Expected Obj, but got I4
		//IL_0679: Expected Obj, but got I4
		//IL_0d19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1e: Expected Obj, but got Unknown
		//IL_0d38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3d: Expected Obj, but got Unknown
		//IL_0d5f: Expected Obj, but got I4
		//IL_073e: Expected Obj, but got I4
		//IL_0b8e: Expected Obj, but got I
		//IL_06ea: Expected Obj, but got I
		//IL_06f3: Expected Obj, but got I4
		//IL_06fc: Expected Obj, but got I4
		//IL_04c6: Expected Obj, but got I4
		//IL_0c2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c31: Expected Obj, but got Unknown
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3e: Expected I4, but got Unknown
		//IL_0c47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4c: Expected Obj, but got Unknown
		//IL_0c66: Expected Obj, but got I4
		//IL_06cc: Expected Obj, but got I
		//IL_06d5: Expected Obj, but got I4
		//IL_0c1e: Expected Obj, but got I4
		//IL_05fe: Expected Obj, but got I
		//IL_0607: Expected Obj, but got I4
		//IL_0610: Expected Obj, but got I4
		//IL_0619: Expected Obj, but got I4
		//IL_04f1: Expected F4, but got I4
		//IL_0c9e: Expected Obj, but got I4
		//IL_0d05: Expected Obj, but got I4
		//IL_0d0e: Expected Obj, but got I4
		//IL_083a: Expected Obj, but got I4
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected Obj, but got Unknown
		//IL_076b: Expected Obj, but got I4
		//IL_0990: Expected Obj, but got I4
		//IL_0861: Expected Obj, but got I
		//IL_088b: Expected Obj, but got I4
		//IL_07a3: Expected Obj, but got I4
		//IL_0cbc: Expected Obj, but got I
		//IL_0ccc: Expected Obj, but got I
		//IL_0cee: Expected Obj, but got I4
		//IL_08c9: Expected Obj, but got I4
		//IL_07e6: Expected Obj, but got I4
		//IL_07f1: Expected Obj, but got I4
		//IL_07fe: Expected I4, but got Obj
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a97: Expected Obj, but got Unknown
		//IL_0ac0: Expected Obj, but got I4
		//IL_0918: Expected Obj, but got I4
		//IL_0af8: Expected Obj, but got I4
		//IL_0b3f: Expected Obj, but got I4
		//IL_0b48: Expected Obj, but got I4
		//IL_0959: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		if (MonsterChoice.ComingSoon(monsterName))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6D8]");
			object obj5 = 0;
			object obj6 = this + 192;
			obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v108+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X20_v16-88]");
			if ((UnityEngine.Object)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
				object obj9 = 0;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v124+E4]");
				bool flag3 = (nint)0 == 0;
				object obj11 = !flag3;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (Application.isPlaying)
				{
					GameObject gameObject = buyKey.gameObject;
					if (gameObject.activeSelf)
					{
						GameObject gameObject2 = buyKey.gameObject;
						gameObject2.SetActive(value: false);
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6C8]");
			object obj12 = 0;
			object obj13 = this + 152;
			bool flag4 = (string)obj13 == (string)obj12;
			bool flag5 = !flag4;
			object obj14 = 0;
			if (!flag5)
			{
				object obj15 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v119+E4]");
				bool flag6 = (nint)0 == 0;
				object obj16 = !flag6;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag7 = tex != null;
				bool flag8 = !flag7;
				object obj17 = !flag8;
				obj14 = 0;
				if (obj17 != null)
				{
					return;
				}
			}
			shown = (string)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			DrawMonster(null, down: false);
			return;
		}
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v9+E4]");
		bool flag9 = (nint)0 == 0;
		object obj20 = !flag9;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string sku = MonsterChoice.SkuFor(monsterName);
		object obj21 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v7+E4]");
		bool flag10 = (nint)0 == 0;
		object obj22 = !flag10;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = GillaPurchases.PriceOf(sku);
		bool flag11 = text == null;
		object obj23 = !flag11;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj24 = 0;
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v93+E4]");
			bool flag12 = (nint)0 == 0;
			object obj26 = !flag12;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Application.isPlaying)
			{
				float unscaledTime = Time.unscaledTime;
				float num = nextAsk;
				if (!(unscaledTime < nextAsk))
				{
					float unscaledTime2 = Time.unscaledTime;
					object obj27 = obj19;
					unscaledTime = unscaledTime2 + 1.1146363E+09f;
					nextAsk = unscaledTime;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v100+E4]");
					bool flag13 = (nint)0 == 0;
					object obj28 = !flag13;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaPurchases.FetchPrices();
					num = 1.1146363E+09f;
				}
			}
		}
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v17+E4]");
		bool flag14 = (nint)0 == 0;
		object obj30 = !flag14;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag15 = MonsterChoice.MayPlay(monsterName);
		object obj33;
		object obj34;
		object obj35;
		object obj37;
		string text2;
		if (flag15)
		{
			object obj31 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v86+E4]");
			bool flag16 = (nint)0 == 0;
			object obj32 = !flag16;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string picked = MonsterChoice.Picked;
			object obj36;
			if (picked == monsterName)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6D0]");
				obj33 = 0;
				obj34 = 1;
				obj35 = 0;
				obj36 = 0;
				goto IL_0c00;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB080]");
			obj37 = 0;
			obj35 = 0;
			obj36 = 0;
		}
		else
		{
			float unscaledTime = Time.unscaledTime;
			float num = checkingUntil;
			if (unscaledTime < checkingUntil)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6A8]");
				obj33 = 0;
				obj34 = 0;
				obj35 = 1;
				goto IL_0c00;
			}
			object obj38 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X0_v83+E4]");
			bool flag17 = (nint)0 == 0;
			object obj39 = !flag17;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!GillaPurchases.Busy)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6B8]");
				object obj40 = 0;
				text2 = (string)((text != null) ? text : obj40);
				obj34 = 0;
				obj35 = 0;
				goto IL_0d13;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6B0]");
			obj37 = 0;
			obj35 = 0;
		}
		text2 = (string)obj37;
		obj34 = 0;
		goto IL_0d13;
		IL_0c00:
		text2 = (string)obj33;
		goto IL_0d13;
		IL_0d13:
		object obj41 = this + 192;
		obj41 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj42 = flag15 | obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X23_v7-14]");
		bool flag18 = (nint)0 == 0;
		object obj43 = !flag18;
		object obj44 = ~obj43;
		object obj45 = ((obj44 != null) ? ((object)1) : obj34);
		object obj46 = obj45 ^ 1;
		bool flag19 = (byte)((flag15 & obj46) ? 1 : 0) != 0;
		object obj47 = obj42 & 1;
		bool flag20 = obj47 == null;
		object obj48 = !flag20;
		if (obj48 == null)
		{
			object obj49 = obj45 & 1;
			bool flag21 = obj49 == null;
			object obj50 = !flag21;
			if (obj50 == null)
			{
				object obj51 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X0_v76+E4]");
				bool flag22 = (nint)0 == 0;
				object obj52 = !flag22;
				if (obj52 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool busy = GillaPurchases.Busy;
				bool flag23 = text == null;
				object obj53 = (busy ? 1 : 0) ^ 1;
				object obj54 = !flag23;
				flag19 = (byte)(obj54 & obj53) != 0;
			}
		}
		object obj55 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X0_v25+E4]");
		bool flag24 = (nint)0 == 0;
		object obj56 = !flag24;
		if (obj56 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag25 = buyKey != null;
		bool flag26 = !flag25;
		object obj57 = 0;
		bool flag27 = false;
		if (!flag26)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj58 = 0;
			object obj59 = obj58;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X0_v64+E4]");
			bool flag28 = (nint)0 == 0;
			object obj60 = !flag28;
			if (obj60 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isPlaying = Application.isPlaying;
			bool flag29 = !isPlaying;
			obj57 = 0;
			flag27 = false;
			if (!flag29)
			{
				GameObject gameObject3 = buyKey.gameObject;
				bool activeSelf = gameObject3.activeSelf;
				bool flag30 = flag19 == activeSelf;
				obj57 = 0;
				flag27 = false;
				if (!flag30)
				{
					GameObject gameObject4 = buyKey.gameObject;
					gameObject4.SetActive(flag19);
					obj57 = 0;
					flag27 = flag19;
				}
			}
		}
		object obj61 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X0_v30+E4]");
		bool flag31 = (nint)0 == 0;
		object obj62 = !flag31;
		if (obj62 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag32 = buyKey != null;
		bool flag33 = !flag32;
		UnityEngine.Object obj63 = null;
		if (!flag33)
		{
			GameObject gameObject5 = buyKey.gameObject;
			bool activeInHierarchy = gameObject5.activeInHierarchy;
			bool flag34 = !activeInHierarchy;
			obj63 = null;
			if (!flag34)
			{
				bool isDown = buyKey.IsDown;
				obj63 = null;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v18+30]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v19+E4]");
		bool flag35 = (nint)0 == 0;
		object obj66 = !flag35;
		if (obj66 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool down = default;
		string text3 = down.ToString();
		int level = GillaLevel.Level;
		int num2 = default;
		string text4 = num2.ToString();
		string text5 = text2 + text3 + text4;
		object obj67 = this + 152;
		bool flag36 = text5 == (string)obj67;
		bool flag37 = !flag36;
		object obj68 = 0;
		if (!flag37)
		{
			object obj69 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X0_v49+E4]");
			bool flag38 = (nint)0 == 0;
			object obj70 = !flag38;
			if (obj70 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag39 = tex != null;
			bool flag40 = !flag39;
			object obj71 = !flag40;
			obj68 = 0;
			if (obj71 != null)
			{
				return;
			}
		}
		shown = text5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		DrawMonster(text2, down);
	}

	private void PressMonster(PressKey key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_006c: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I
		//IL_00ed: Expected VT, but got Obj
		//IL_010f: Expected Obj, but got I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_0197: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_0345: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I4
		//IL_03b0: Expected Obj, but got I4
		//IL_0242: Expected Obj, but got I
		//IL_0257: Expected Obj, but got I
		//IL_028a: Expected Obj, but got I4
		//IL_03e8: Expected Obj, but got I4
		//IL_02b7: Expected Obj, but got I
		//IL_043f: Expected Obj, but got I
		//IL_0459: Expected Obj, but got I
		//IL_046a: Expected I, but got Obj
		//IL_0499: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF768]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (MonsterChoice.ComingSoon(monsterName))
		{
			return;
		}
		Transform transform = key.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
		object obj7 = 0;
		Vector3 to = (Vector3)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v17 (UnityEngine.Vector3)+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = GillaToast.NearerHand(to);
		string text = MonsterLabel();
		object obj9 = obj2 + 32;
		obj9 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = MonsterChoice.MayPlay(monsterName);
		object obj12 = obj3;
		if (flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v28+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			MonsterChoice.Pick(monsterName);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF778]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+20]");
			string text2 = (string)0 + (string)obj14;
			object obj15 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v17+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF780]");
			object line = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+18]");
			GillaToast.Show(0, text2, (string)line, error: false);
			Play(wearSound);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v28+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string sku = MonsterChoice.SkuFor(monsterName);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
		object obj18 = 0;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v8+E4]");
		bool flag8 = (nint)0 == 0;
		object obj20 = !flag8;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool busy = GillaPurchases.Busy;
		bool flag9 = !busy;
		object obj21 = !flag9;
		if (obj21 != null)
		{
			return;
		}
		object obj22 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v34+E4]");
		bool flag10 = (nint)0 == 0;
		object obj23 = !flag10;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text3 = GillaPurchases.PriceOf(sku);
		if (text3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF5D8]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF770]");
			object obj25 = 0;
			Action<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> action = default;
			action._002Ector(obj2, (IntPtr)obj25);
			object obj26 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v40+E4]");
			bool flag11 = (nint)0 == 0;
			object obj27 = !flag11;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaPurchases.Buy(sku, (Action<GillaPurchases.Result>)(object)action);
		}
	}

	private string MonsterLabel()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I4
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
		int monster = MonsterChoice.NumberOf(monsterName);
		MonsterDirector.Entry entry = MonsterCatalog.Of(monster);
		if (entry == null || string.IsNullOrEmpty(entry.label))
		{
			if (monsterName != null)
			{
				return monsterName.ToUpperInvariant();
			}
			return (string)(object)new NullReferenceException();
		}
		return entry.label;
	}

	private unsafe void DrawMonster(string label, bool down)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1003: Expected Obj, but got I
		//IL_1013: Expected Obj, but got I
		//IL_1023: Expected Obj, but got I
		//IL_105d: Expected Obj, but got I4
		//IL_107b: Expected Obj, but got I
		//IL_1089: Expected Obj, but got Ref
		//IL_10b1: Expected VT, but got Ref
		//IL_0042: Expected Obj, but got Ref
		//IL_0052: Expected Obj, but got I
		//IL_0082: Expected VT, but got Ref
		//IL_00c7: Expected Obj, but got Ref
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efb: Expected VT, but got Ref
		//IL_0f0b: Expected Obj, but got I
		//IL_0f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I
		//IL_012d: Expected I, but got Obj
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I
		//IL_0263: Expected Obj, but got I
		//IL_029d: Expected Obj, but got I
		//IL_02bf: Expected Obj, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_02f3: Expected I4, but got Obj
		//IL_032e: Expected Obj, but got I4
		//IL_089c: Expected Obj, but got I
		//IL_08ac: Expected Obj, but got I
		//IL_08bc: Expected Obj, but got I
		//IL_08cf: Expected Obj, but got I4
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected I4, but got Unknown
		//IL_0947: Expected Obj, but got I4
		//IL_094f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Expected Obj, but got Unknown
		//IL_0988: Expected Obj, but got I4
		//IL_035e: Expected Obj, but got I
		//IL_037f: Expected Obj, but got I
		//IL_038f: Expected Obj, but got I
		//IL_1170: Unknown result type (might be due to invalid IL or missing references)
		//IL_1175: Unknown result type (might be due to invalid IL or missing references)
		//IL_118a: Expected VT, but got Ref
		//IL_119a: Expected Obj, but got I
		//IL_119f: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_11af: Unknown result type (might be due to invalid IL or missing references)
		//IL_097a: Expected Obj, but got I4
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected I4, but got Obj
		//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c61: Expected Obj, but got I4
		//IL_0c65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c72: Expected Obj, but got I4
		//IL_0c83: Expected Obj, but got I4
		//IL_0458: Expected Obj, but got I4
		//IL_1367: Unknown result type (might be due to invalid IL or missing references)
		//IL_1370: Expected Ref, but got Unknown
		//IL_138a: Expected Obj, but got I4
		//IL_1392: Unknown result type (might be due to invalid IL or missing references)
		//IL_1396: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got VT
		//IL_04e7: Expected Obj, but got I
		//IL_0533: Expected Obj, but got I4
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected Obj, but got Unknown
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected Obj, but got Unknown
		//IL_04c5: Expected I4, but got Obj
		//IL_0f48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca2: Expected Obj, but got I4
		//IL_0caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cba: Expected Obj, but got Unknown
		//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Expected Obj, but got I4
		//IL_09d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7e: Expected Obj, but got I
		//IL_0ab1: Expected Obj, but got I4
		//IL_0aba: Expected Obj, but got I4
		//IL_0752: Expected Obj, but got I
		//IL_0e97: Expected Obj, but got I
		//IL_0eae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb3: Expected Obj, but got Unknown
		//IL_0cff: Expected Obj, but got I4
		//IL_0b41: Expected Obj, but got I4
		//IL_0a49: Expected Obj, but got I4
		//IL_1100: Expected I, but got Obj
		//IL_115a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f85: Expected Obj, but got I4
		//IL_0f96: Expected Obj, but got I4
		//IL_0d3a: Expected Obj, but got I
		//IL_0d64: Expected Obj, but got I4
		//IL_122c: Expected Obj, but got I
		//IL_0ad8: Expected Obj, but got I
		//IL_0b09: Expected Obj, but got I4
		//IL_1200: Expected Obj, but got I
		//IL_1209: Expected Obj, but got I4
		//IL_0fed: Expected Obj, but got I4
		//IL_0d91: Expected Obj, but got I
		//IL_0dbb: Expected Obj, but got I4
		//IL_13b6: Expected Obj, but got Ref
		//IL_13dd: Expected VT, but got Ref
		//IL_13e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ea: Expected I4, but got Unknown
		//IL_13ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1413: Expected VT, but got Ref
		//IL_141b: Unknown result type (might be due to invalid IL or missing references)
		//IL_141f: Unknown result type (might be due to invalid IL or missing references)
		//IL_142b: Expected Obj, but got Ref
		//IL_0b76: Expected Obj, but got I
		//IL_0b9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected Obj, but got I4
		//IL_0612: Expected Obj, but got I
		//IL_0df8: Expected Obj, but got I
		//IL_0e1a: Expected Obj, but got I4
		//IL_0c25: Expected Obj, but got I4
		//IL_0850: Expected Obj, but got I
		//IL_0860: Expected Obj, but got I
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_129b: Expected Obj, but got I
		//IL_12a9: Expected Obj, but got Ref
		//IL_12d9: Expected Obj, but got I
		//IL_12f6: Expected VT, but got Ref
		//IL_1306: Expected Obj, but got I
		//IL_1275: Expected Obj, but got I
		//IL_127e: Expected Obj, but got I4
		//IL_0bde: Expected Obj, but got I4
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected Obj, but got Unknown
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Expected Obj, but got Unknown
		//IL_0e4f: Expected Obj, but got I
		//IL_0e66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6b: Expected Obj, but got Unknown
		//IL_124f: Expected Obj, but got I
		//IL_1258: Expected Obj, but got I4
		//IL_06cb: Expected Obj, but got I4
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Expected Obj, but got Unknown
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Expected Obj, but got Unknown
		//IL_079f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF748]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4460]");
		object obj4 = 0;
		Begin();
		string line = MonsterLabel();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v6+A0]");
		object obj7 = 0;
		Enumerator<, > val = default;
		object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj9 = default;
		Line(title, 128, 11, line, (ShiftAuth.Style)(&obj9));
		GillaBoardLook.Rule(px, 256, 192, 10, 245, 33);
		object obj10 = obj;
		object obj11 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v5+A0]");
		System.__Canon[] array = (System.__Canon[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		string text = (string)obj2;
		object obj12 = default;
		Line(this.text, 128, 40, (string)obj2, (ShiftAuth.Style)(&obj12));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		System.__Canon _Canon = (System.__Canon)obj4;
		List<System.__Canon> list = default;
		list._002Ector();
		bool flag2 = list == null;
		int num = 0;
		string text2 = (string)(&val);
		int num2 = 40;
		int num3 = 128;
		Enumerator<, > val2 = (Enumerator<, >)1;
		bool flag6;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF738]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
			text2 = (string)0;
			array = list._items;
			_Canon = (System.__Canon)obj13;
			nint num4 = (nint)text2;
			int version = list._version + 1;
			list._version = version;
			bool flag3 = list._items == null;
			num = 0;
			num2 = 40;
			num3 = 128;
			val2 = (Enumerator<, >)text2;
			if (!flag3)
			{
				version = list._size;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
				object obj14 = 0;
				bool flag4 = list._size < array.Length;
				object obj15 = !flag4;
				if (obj15 == null)
				{
					object obj16 = list._items + list._size;
					int size = list._size + 1;
					list._size = size;
					object obj17 = obj16 + 32;
					obj17 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					int num5 = 128;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X9_v13 (Il2CppClass<System.String>)+20]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v91+A8]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v92+70]");
					int num5 = 0;
					list.AddWithResize((System.__Canon)obj13);
				}
				object obj20 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF718]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v68+E4]");
				bool flag5 = (nint)0 == 0;
				object obj21 = !flag5;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string[] collection = MonsterChoice.AbilitiesOf(monsterName);
				num3 = (int)obj3;
				list.AddRange((IEnumerable<System.__Canon>)(object)collection);
				flag6 = MonsterChoice.ComingSoon(monsterName);
				bool flag7 = !flag6;
				object obj22 = !flag7;
				num = 0;
				num2 = 40;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
					object obj23 = 0;
					string text3 = num.ToString((string)obj23);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60E0]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6150]");
					object obj25 = 0;
					string text4 = (string)obj24 + text3 + (string)obj25;
					array = list._items;
					val2 = (Enumerator<, >)text2;
					version = list._version + 1;
					list._version = version;
					bool flag8 = list._items == null;
					num = 2500;
					bool flag9 = flag6;
					num2 = 0;
					num3 = (int)obj25;
					_Canon = (System.__Canon)(object)text3;
					if (flag8)
					{
						goto IL_0ee9;
					}
					version = list._size;
					bool flag10 = list._size < array.Length;
					object obj26 = !flag10;
					if (obj26 == null)
					{
						object obj27 = list._items + list._size;
						int size2 = list._size + 1;
						list._size = size2;
						object obj28 = obj27 + 32;
						obj28 = text4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						num3 = (int)obj25;
					}
					else
					{
						System.__Canon _Canon2 = (System.__Canon)val2._current;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v89 (System.__Canon)+A8]");
						object obj29 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v90+70]");
						num3 = 0;
						list.AddWithResize((System.__Canon)(object)text4);
					}
					object obj30 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X0_v114+E4]");
					bool flag11 = (nint)0 == 0;
					object obj31 = !flag11;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int num6 = MonsterChoice.LevelFor(monsterName);
					bool flag12 = num6 < 1;
					int num7 = num6;
					num = 2500;
					num2 = 0;
					if (!flag12)
					{
						int level = GillaLevel.Level;
						string text7;
						object obj36;
						if (level < num6)
						{
							bool flag13 = num6 < 1;
							num7 = num6;
							num = 2500;
							num2 = 0;
							if (flag13)
							{
								goto IL_088b;
							}
							string text5 = num7.ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF760]");
							object obj32 = 0;
							string text6 = (string)obj32 + text5;
							array = list._items;
							version = list._version + 1;
							list._version = version;
							bool flag14 = list._items == null;
							num = 2500;
							flag9 = flag6;
							num2 = 0;
							num3 = 0;
							_Canon = (System.__Canon)(object)text5;
							val2 = (Enumerator<, >)text2;
							if (flag14)
							{
								goto IL_0ee9;
							}
							bool flag15 = list._size < array.Length;
							object obj33 = !flag15;
							if (obj33 == null)
							{
								object obj34 = list._items + list._size;
								int size3 = list._size + 1;
								list._size = size3;
								object obj35 = obj34 + 32;
								obj35 = text6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							}
							else
							{
								list.AddWithResize((System.__Canon)(object)text6);
							}
							int level2 = GillaLevel.Level;
							text7 = num.ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF720]");
							obj36 = 0;
						}
						else
						{
							text7 = num7.ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF750]");
							obj36 = 0;
							num = 2500;
						}
						string text8 = (string)obj36 + text7;
						array = list._items;
						nint num8 = (nint)text2;
						version = list._version + 1;
						list._version = version;
						bool flag16 = list._items == null;
						flag9 = flag6;
						num2 = 0;
						num3 = 0;
						_Canon = (System.__Canon)(object)text7;
						val2 = (Enumerator<, >)text2;
						if (flag16)
						{
							goto IL_0ee9;
						}
						bool flag17 = list._size < array.Length;
						object obj37 = !flag17;
						if (obj37 == null)
						{
							object obj38 = list._items + list._size;
							int size4 = list._size + 1;
							list._size = size4;
							object obj39 = obj38 + 32;
							obj39 = text8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							num2 = 0;
							num3 = 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X9_v28 (Il2CppClass<System.String>)+20]");
							object obj40 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X8_v76+A8]");
							object obj41 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v77+70]");
							num3 = 0;
							list.AddWithResize((System.__Canon)(object)text8);
							num2 = 0;
						}
					}
				}
				goto IL_088b;
			}
		}
		goto IL_0ee9;
		IL_088b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4420]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF740]");
		object value = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4418]");
		obj3 = 0;
		object obj43 = list._size - 5;
		bool flag18 = (nint)obj43 < 0;
		bool flag19 = obj43 == null;
		int num9 = list._size ^ 5;
		int num10 = list._size ^ obj43;
		int num11 = num9 & num10;
		bool flag20 = num11 < 0;
		bool flag21 = flag18 == flag20;
		object obj44 = !flag21;
		object obj45 = obj44 | flag19;
		object obj46 = ~obj45;
		object obj47 = ((obj46 != null) ? ((object)12) : ((object)(12 + 1)));
		Enumerator<, > enumerator = list.GetEnumerator();
		int num12 = 52;
		ShiftAuth.Style style = (ShiftAuth.Style)(&obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v7 (System.__Canon[])+10]");
		object obj48 = 0;
		val = (Enumerator<, >)1;
		Enumerator<, > val4 = default;
		Enumerator<, > val3 = (Enumerator<, >)(ref val4);
		Enumerator<, > val6 = default;
		Enumerator<, > val5 = val6;
		object obj65 = default;
		Enumerator<, > val8 = default;
		System.__Canon[] array2 = default;
		object obj82 = default;
		string label2 = default;
		while (true)
		{
			_Canon = (System.__Canon)obj42;
			System.__Canon[] array3;
			object obj49;
			Enumerator<, > val7;
			bool flag9;
			object obj52;
			object obj54;
			if (val4.MoveNext())
			{
				if (num12 > 127)
				{
					continue;
				}
				bool flag22 = array2 == null;
				array3 = null;
				val4 = val6;
				obj49 = 0;
				val7 = (Enumerator<, >)(ref val4);
				flag9 = flag6;
				if (flag22)
				{
					goto IL_0f55;
				}
				if (((string)(object)array2).StartsWith((string)value))
				{
					object obj50 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ X0_v106+E4]");
					bool flag23 = (nint)0 == 0;
					object obj51 = !flag23;
					if (obj51 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj50 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ X0_v106+A0]");
					obj52 = (nint)0 + (nint)56;
					object obj53 = 0;
					obj54 = obj;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6E8]");
					object obj55 = 0;
					string text9 = (string)obj55;
					bool flag24 = ((string)(object)array2).Contains((string)obj55);
					bool flag25 = !flag24;
					object obj56 = !flag25;
					object obj53 = 0;
					if (obj56 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF730]");
						object obj57 = 0;
						text9 = (string)obj57;
						bool flag26 = ((string)(object)array2).StartsWith((string)obj57);
						bool flag27 = !flag26;
						obj53 = 0;
						if (flag27)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF728]");
							object value2 = 0;
							bool flag28 = ((string)(object)array2).StartsWith((string)value2);
							object obj58 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1087 @ X0_v99+E4]");
							val3 = (Enumerator<, >)0;
							if (flag28)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1087 @ X0_v99+E4]");
								bool flag29 = (nint)0 == 0;
								object obj59 = !flag29;
								if (obj59 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj58 = obj;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1087 @ X0_v99+A0]");
								obj52 = (nint)0 + (nint)16;
								obj53 = 0;
								obj54 = obj;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1087 @ X0_v99+E4]");
								bool flag30 = (nint)0 == 0;
								object obj60 = !flag30;
								if (obj60 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj58 = obj;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1087 @ X0_v99+A0]");
								obj52 = 0;
								obj53 = 0;
								obj54 = obj;
							}
							goto IL_13a8;
						}
					}
					object obj61 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1085 @ X0_v91+E4]");
					bool flag31 = (nint)0 == 0;
					object obj62 = !flag31;
					if (obj62 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj61 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1085 @ X0_v91+A0]");
					obj52 = (nint)0 + (nint)48;
					obj54 = obj;
				}
				goto IL_13a8;
			}
			array3 = null;
			val4 = val6;
			obj49 = 0;
			val7 = (Enumerator<, >)(ref val4);
			object obj63 = 0;
			flag9 = flag6;
			object obj64 = 12;
			goto IL_135f;
			IL_0f55:
			NullReferenceException ex = new NullReferenceException();
			if ((nint)_Canon == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				array3 = (System.__Canon[])1;
				obj63 = obj49;
				array = (System.__Canon[])1;
			}
			else
			{
				if ((nint)_Canon != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj63 = obj65;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj49 = obj65;
			}
			obj64 = 0;
			goto IL_135f;
			IL_13a8:
			object obj66 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val, 16));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Line(this.text, 128, num12, (string)(object)array2, (ShiftAuth.Style)(&val8));
			num12 += obj47;
			val8 = val;
			text = (string)(object)array2;
			num2 = num12;
			num3 = 128;
			style = (ShiftAuth.Style)(&val8);
			obj48 = obj52;
			val5 = val;
			array = (System.__Canon[])(&val);
			obj = obj54;
			continue;
			IL_135f:
			_Canon = (System.__Canon)obj3;
			((Enumerator<, >*)val7)->Dispose();
			bool flag32 = obj63 == null;
			object obj67 = !flag32;
			array2 = array3;
			val2 = val3;
			if (obj67 == null)
			{
				bool flag33 = array3 == null;
				object obj68 = !flag33;
				array2 = array3;
				val2 = val3;
				OutOfMemoryException ex2 = (OutOfMemoryException)val7;
				if (obj68 == null)
				{
					if ((nint)obj64 != 12)
					{
						bool flag34 = obj64 == null;
						object obj69 = !flag34;
						if (obj69 != null)
						{
							return;
						}
					}
					if (flag9)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6C0]");
						object obj70 = 0;
						object obj71 = obj70;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v942 @ X0_v27+E4]");
						bool flag35 = (nint)0 == 0;
						object obj72 = !flag35;
						if (obj72 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
						object obj73 = 0;
						object obj74 = obj73;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X0_v29+E4]");
						bool flag36 = (nint)0 == 0;
						object obj75 = !flag36;
						if (obj75 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj76 = obj70;
						object obj77 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v19+A0]");
						object obj78 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ X0_v32+E4]");
						bool flag37 = (nint)0 == 0;
						object obj79 = !flag37;
						if (obj79 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj77 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ X0_v32+A0]");
						object obj80 = 0;
						object obj81 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val, 16));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X8_v20+4]");
						int y = (int)((nint)0 + (nint)13);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6D8]");
						object line2 = 0;
						Line(this.text, 128, y, (string)line2, (ShiftAuth.Style)(&obj82));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF700]");
						object separator = 0;
						string text10 = string.Join((string)separator, (IEnumerable<string>)list);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF758]");
						object obj83 = 0;
						string text11 = text10 + (string)obj83;
						object obj84 = this + 200;
						obj84 = text11;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF700]");
						object separator2 = 0;
						string text12 = string.Join((string)separator2, (IEnumerable<string>)list);
						object obj85 = this + 200;
						obj85 = text12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Key(label2, down);
					}
					End();
					return;
				}
			}
			else
			{
				OutOfMemoryException ex2 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			array3 = array2;
			val3 = val2;
			goto IL_0f55;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE0C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0ee9:
		val4 = (Enumerator<, >)0;
		style = (ShiftAuth.Style)(&obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v7 (System.__Canon[])+10]");
		obj48 = 0;
		val = (Enumerator<, >)1;
		val5 = (Enumerator<, >)1;
		throw new NullReferenceException();
	}

	private unsafe void OnPress(PressKey key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_06a7: Expected Obj, but got I4
		//IL_06b5: Expected Obj, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_00c7: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I4
		//IL_0214: Expected Obj, but got I
		//IL_021c: Expected I, but got Obj
		//IL_023e: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I4
		//IL_02ac: Expected Obj, but got I4
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_02c7: Expected I, but got Obj
		//IL_02d7: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I4
		//IL_04f3: Expected Obj, but got I4
		//IL_04fc: Expected Obj, but got I4
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got I4
		//IL_051b: Expected Obj, but got I4
		//IL_0720: Expected Obj, but got I
		//IL_074b: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I4
		//IL_0358: Expected Obj, but got I4
		//IL_053a: Expected Obj, but got I4
		//IL_0542: Expected Obj, but got Ref
		//IL_038b: Expected Obj, but got I4
		//IL_03b6: Expected Obj, but got I
		//IL_03be: Expected VT, but got Obj
		//IL_03e0: Expected Obj, but got I4
		//IL_0617: Expected Obj, but got I4
		//IL_0587: Expected Obj, but got I4
		//IL_041a: Expected Obj, but got I
		//IL_043f: Expected Obj, but got I4
		//IL_0676: Expected Obj, but got I4
		//IL_045d: Expected Obj, but got I
		//IL_0477: Expected Obj, but got I
		//IL_0488: Expected I, but got Obj
		//IL_0495: Expected I, but got Obj
		//IL_04b7: Expected Obj, but got I4
		//IL_04e9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF790]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		bool flag = obj2 == null;
		object obj3 = 0;
		GillaBundleStand gillaBundleStand = this;
		object obj4 = 109895680;
		if (!flag)
		{
			object obj5 = obj2 + 16;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (!string.IsNullOrEmpty(monsterName))
			{
				PressMonster(key);
				return;
			}
			Coins.Bundle bundle = Bundle;
			obj4 = obj2 + 32;
			obj4 = bundle;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Coins.Bundle b = (Coins.Bundle)obj4;
			if (obj4 == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v37+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Coins.OwnsAll(b))
			{
				List<byte> list = CosmeticCatalog.IdsOf((Coins.Bundle)obj4);
				bool flag3 = list == null;
				obj3 = 0;
				gillaBundleStand = this;
				if (!flag3)
				{
					Enumerator<, > enumerator = list.GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4728]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
					obj4 = 0;
					Enumerator<, > val = default;
					while (val.MoveNext())
					{
						object obj10 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v69+E4]");
						bool flag4 = (nint)0 == 0;
						object obj11 = !flag4;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cosmetics.Wear(0);
					}
					object obj12 = 0;
					object obj13 = 0;
					Enumerator<, > val2 = (Enumerator<, >)(ref val);
					gillaBundleStand = this;
					object obj14 = 0;
					object obj15 = 7;
					object obj20 = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4720]");
						object obj16 = 0;
						obj3 = obj16;
						val.Dispose();
						bool flag5 = obj14 == null;
						object obj17 = !flag5;
						if (obj17 == null)
						{
							bool flag6 = obj12 == null;
							object obj18 = !flag6;
							OutOfMemoryException ex = (OutOfMemoryException)(&val);
							if (obj18 == null)
							{
								if ((nint)obj15 != 7)
								{
									bool flag7 = obj15 == null;
									object obj19 = !flag7;
									if (obj19 != null)
									{
										return;
									}
								}
								gillaBundleStand.Play(gillaBundleStand.wearSound);
								return;
							}
						}
						else
						{
							OutOfMemoryException ex = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if ((nint)obj3 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj12 = 1;
							obj14 = obj13;
						}
						else
						{
							if ((nint)obj3 != 1)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj14 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj13 = obj20;
						}
						obj15 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CEFC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
				b = (Coins.Bundle)0;
				nint num = (nint)b;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v42 (Il2CppClass<Coins+Bundle>)+E4]");
				bool flag8 = (nint)0 == 0;
				object obj21 = !flag8;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool busy = GillaPurchases.Busy;
				bool flag9 = !busy;
				object obj22 = !flag9;
				if (obj22 != null)
				{
					return;
				}
				object obj23 = obj4;
				bool flag10 = obj4 == null;
				obj3 = 0;
				gillaBundleStand = this;
				if (!flag10)
				{
					nint num2 = (nint)b;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v17+38]");
					gillaBundleStand = (GillaBundleStand)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v44 (Il2CppClass<Coins+Bundle>)+E4]");
					bool flag11 = (nint)0 == 0;
					object obj24 = !flag11;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text = GillaPurchases.PriceOf((string)(object)gillaBundleStand);
					if (text == null)
					{
						return;
					}
					bool flag12 = (object)key == null;
					obj3 = 0;
					if (!flag12)
					{
						Transform transform = key.transform;
						bool flag13 = (object)transform == null;
						obj3 = 0;
						if (!flag13)
						{
							Vector3 position = transform.position;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
							object obj25 = 0;
							Vector3 to = (Vector3)obj25;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v52 (UnityEngine.Vector3)+E4]");
							bool flag14 = (nint)0 == 0;
							object obj26 = !flag14;
							if (obj26 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							int num3 = GillaToast.NearerHand(to);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Object)+20]");
							object obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Object)+20]");
							bool flag15 = (nint)0 == 0;
							obj3 = 0;
							if (!flag15)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF5D8]");
								object obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF798]");
								object obj29 = 0;
								Action<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> action = default;
								action._002Ector(obj2, (IntPtr)obj29);
								nint num4 = (nint)b;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X0_v56 (Il2CppClass<Coins+Bundle>)+E4]");
								bool flag16 = (nint)0 == 0;
								object obj30 = !flag16;
								if (obj30 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v21+38]");
								GillaPurchases.Buy((string)0, (Action<GillaPurchases.Result>)(object)action);
								return;
							}
						}
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	private void Play(AudioClip clip)
	{
		//IL_0010: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_016c: Expected Obj, but got I
		//IL_0184: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_0242: Expected Obj, but got I4
		//IL_010d: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		AudioClip[] array = default;
		if (array != null)
		{
			object obj5 = array + 32;
			obj5 = clip;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v13+A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v14+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				object obj10 = num * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v14+1C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				object obj11 = num2 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v14+20]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				object obj12 = num3 * 0;
				object obj13 = obj9;
				object obj14 = default;
				float volume = (float)obj14 + (float)obj10;
				object obj15 = default;
				float pitchMin = (float)obj15 + (float)obj11;
				object obj16 = default;
				float pitchMax = (float)obj16 + (float)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v19+E4]");
				bool flag2 = (nint)0 == 0;
				object obj17 = !flag2;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Sfx.Play(array, (Vector3)0, volume, pitchMin, pitchMax);
				return;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void Begin()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_0211: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0143: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 112;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 == null;
		bool flag3 = !flag2;
		object obj5 = 0;
		UnityEngine.Object obj6 = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Texture2D texture2D = default;
			texture2D._002Ector(256, 192, (TextureFormat)4, mipChain: true);
			texture2D.filterMode = (FilterMode)0;
			texture2D.wrapMode = (TextureWrapMode)1;
			texture2D.hideFlags = (HideFlags)52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF788]");
			object obj8 = 0;
			texture2D.name = (string)obj8;
			tex = texture2D;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj10 = this + 120;
			UnityEngine.Object obj11 = default;
			obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj5 = 0;
			obj6 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj12 = 0;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaBoardLook.Clear(px, 256, 192);
		GillaBoardLook.Frame(px, 256, 192, 3);
	}

	private unsafe void Key(string label, bool down)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I
		//IL_0301: Expected Obj, but got I4
		//IL_0445: Expected Obj, but got I
		//IL_0455: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I4
		//IL_0340: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_0492: Expected Obj, but got I
		//IL_04b4: Expected Obj, but got I4
		//IL_0325: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected I4, but got Unknown
		//IL_016d: Expected VT, but got Obj
		//IL_01ca: Expected VT, but got Obj
		//IL_01ca: Expected I4, but got Obj
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected I4, but got Unknown
		//IL_0248: Expected VT, but got Obj
		//IL_0272: Expected Obj, but got I4
		//IL_0355: Expected Obj, but got I
		//IL_0363: Expected Obj, but got Ref
		//IL_03de: Expected Obj, but got I4
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected I4, but got Unknown
		//IL_0434: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6C0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj6 = 0;
		object obj7 = obj3;
		object obj9;
		if (down)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v22+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v22+A0]");
			obj9 = (nint)0 + (nint)36;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v22+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v22+A0]");
			obj9 = (nint)0 + (nint)44;
		}
		object obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+8]");
		int rw = (int)(-6);
		int x = obj5 + 3;
		Color32[] array = px;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+C]");
		PixelFont.Fill(array, 256, 192, x, (int)num, rw, 0, (Color32)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+C]");
		int rh = (int)(-6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+4]");
		int y = (int)((nint)0 + (nint)3);
		Color32[] array2 = px;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+8]");
		PixelFont.Fill(array2, 256, 192, (int)obj5, y, 0, rh, (Color32)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+8]");
		int rw2 = (int)(-2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+C]");
		int rh2 = (int)(-2);
		int x2 = obj5 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+4]");
		int y2 = (int)((nint)0 + (nint)1);
		PixelFont.Fill(px, 256, 192, x2, y2, rw2, rh2, (Color32)obj9);
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v14+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v14+A0]");
		object obj18 = 0;
		object obj20 = default;
		object obj19 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj20, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+8]");
		bool flag7 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+8]");
		int num3 = (int)(num2 ^ 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+8]");
		int num4 = (int)((nint)0 & (nint)num3);
		bool flag8 = num4 < 0;
		bool flag9 = flag7 == flag8;
		object obj21 = !flag9;
		object obj22 = ~obj21;
		int num5;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+8]");
			num5 = (int)((nint)0 + (nint)1);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+8]");
			num5 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+4]");
		int y3 = (int)((nint)0 + (nint)13);
		int x3 = obj5 + num5;
		object obj23 = default;
		Line(text, x3, y3, label, (ShiftAuth.Style)(&obj23));
	}

	private void End()
	{
		//IL_002b: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00d5: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I4
		//IL_01a0: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I
		tex.SetPixels32(px);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		tex.Apply(updateMipmaps: true);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(screen == null))
		{
			object obj4 = this + 128;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				MaterialPropertyBlock materialPropertyBlock = default;
				materialPropertyBlock._002Ector();
				obj4 = materialPropertyBlock;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			screen.GetPropertyBlock((MaterialPropertyBlock)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6C0]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v8+A0]");
			object obj11 = 0;
			object obj12 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v9+10]");
			((MaterialPropertyBlock)obj12).SetTexture(0, (Texture)tex);
			screen.SetPropertyBlock((MaterialPropertyBlock)obj4);
		}
	}

	private unsafe void Draw(Coins.Bundle b, string label, bool down)
	{
		//IL_0081: Expected Obj, but got I
		//IL_171a: Expected Obj, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0048: Expected Obj, but got I4
		//IL_1763: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected I4, but got Unknown
		//IL_011d: Expected Obj, but got I4
		//IL_13ec: Expected Obj, but got I
		//IL_13fa: Expected Obj, but got Ref
		//IL_141f: Expected VT, but got Ref
		//IL_13a6: Expected Obj, but got I4
		//IL_070c: Expected Obj, but got I4
		//IL_13cf: Expected Obj, but got I4
		//IL_14df: Expected Obj, but got I
		//IL_14ed: Expected Obj, but got Ref
		//IL_1507: Expected Obj, but got I
		//IL_1525: Expected VT, but got Ref
		//IL_01c4: Expected Obj, but got I
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got I4
		//IL_1458: Expected Obj, but got I
		//IL_1466: Expected Obj, but got Ref
		//IL_1496: Expected VT, but got Ref
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_169d: Unknown result type (might be due to invalid IL or missing references)
		//IL_16aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_16bb: Expected Obj, but got I4
		//IL_16bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d4: Expected VT, but got Ref
		//IL_16e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_11da: Expected Obj, but got I4
		//IL_11de: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f3: Expected VT, but got Ref
		//IL_11ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1203: Unknown result type (might be due to invalid IL or missing references)
		//IL_1207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected I, but got Obj
		//IL_0391: Expected Obj, but got I4
		//IL_03b1: Expected Obj, but got I4
		//IL_0430: Expected Obj, but got I
		//IL_0440: Expected Obj, but got I
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		Begin();
		object obj2;
		if (b != null)
		{
			object obj = b + 24;
			bool flag = string.IsNullOrEmpty((string)obj);
			obj2 = obj - 8;
			bool flag2 = !flag;
			object obj3 = !flag2;
			object obj4 = ~obj3;
			if (obj4 != null)
			{
				obj2 = obj;
			}
			Coins.Bundle bundle = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6D8]");
			obj2 = 0;
			Coins.Bundle bundle = b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj5 = 0;
		int y;
		ScreenFont font;
		if (title != null)
		{
			int num = title.Measure((string)obj2, 2);
			object obj6 = num - 229;
			bool flag3 = (nint)obj6 < 0;
			int num2 = num ^ 0xE5;
			int num3 = num ^ obj6;
			int num4 = num2 & num3;
			bool flag4 = num4 < 0;
			font = title;
			bool flag5 = flag3 == flag4;
			object obj7 = !flag5;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
			}
			bool flag6 = flag3 == flag4;
			object obj9 = !flag6;
			object obj4 = ~obj9;
			y = ((obj4 != null) ? 15 : 11);
			bool flag7 = false;
			string text = (string)2;
			Coins.Bundle bundle = (Coins.Bundle)obj2;
		}
		else
		{
			y = 11;
			font = null;
			bool flag7 = down;
			string text = label;
		}
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v7+E4]");
		bool flag8 = (nint)0 == 0;
		object obj11 = !flag8;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v7+A0]");
		object obj12 = 0;
		Enumerator<, > val = default;
		object obj13 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj14 = default;
		Line(font, 128, y, (string)obj2, (ShiftAuth.Style)(&obj14));
		GillaBoardLook.Rule(px, 256, 192, 10, 245, 33);
		object obj15 = obj5;
		if (b != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6F8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
			Enumerator<, > val2 = (Enumerator<, >)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v16+E4]");
			bool flag9 = (nint)0 == 0;
			object obj17 = !flag9;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v16+A0]");
			object obj18 = 0;
			object obj19 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val, 16));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			string text2 = (string)obj16;
			object obj20 = default;
			Line(this.text, 128, 40, (string)obj16, (ShiftAuth.Style)(&obj20));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<System.__Canon> list = default;
			list._002Ector();
			List<byte> list2 = CosmeticCatalog.IdsOf(b);
			bool flag10 = list2 == null;
			int num6 = default;
			int num5 = num6;
			Enumerator<, > val3 = (Enumerator<, >)0;
			nint num7 = 1;
			int num8 = 40;
			string text3 = null;
			bool flag11 = down;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
				font = (ScreenFont)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4720]");
				object obj21 = 0;
				Enumerator<, > enumerator = list2.GetEnumerator();
				num7 = (nint)(&val3);
				int num9 = 128;
				Enumerator<, > val5 = default;
				while (true)
				{
					System.__Canon _Canon;
					Enumerator<, > val4;
					int num10;
					object obj28;
					Enumerator<, > val6;
					ShiftAuth.Style style;
					Enumerator<, > val7;
					Enumerator<, > val8;
					int num11;
					bool flag14;
					if (val3.MoveNext())
					{
						CosmeticCatalog.Entry entry = CosmeticCatalog.Of(num6);
						if (entry == null)
						{
							continue;
						}
						bool flag12 = list == null;
						_Canon = null;
						if (!flag12)
						{
							System.__Canon[] items = list._items;
							_Canon = (System.__Canon)(object)entry.label;
							num7 = (nint)font;
							int version = list._version + 1;
							list._version = version;
							if (list._items != null)
							{
								version = list._size;
								object obj22 = items.Length;
								bool flag13 = list._size < items.Length;
								object obj23 = !flag13;
								if (obj23 == null)
								{
									object obj24 = list._items + list._size;
									num7 = list._size + 1;
									list._size = (int)num7;
									object obj25 = obj24 + 32;
									obj25 = entry.label;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X9_v6 (Il2CppClass<ScreenFont>)+20]");
									object obj26 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1149 @ X8_v72+A8]");
									object obj27 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X8_v73+70]");
									num9 = 0;
									list.AddWithResize((System.__Canon)(object)entry.label);
								}
								continue;
							}
						}
						NullReferenceException ex = new NullReferenceException();
						val4 = (Enumerator<, >)0;
						num10 = 0;
						val3 = val5;
						obj28 = 0;
						val6 = (Enumerator<, >)(ref val3);
						val = (Enumerator<, >)1;
						style = (ShiftAuth.Style)(&obj20);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v12+10]");
						val7 = (Enumerator<, >)0;
						val8 = val5;
						num11 = 40;
						flag14 = down;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						break;
					}
					_Canon = (System.__Canon)obj21;
					val3.Dispose();
					val4 = (Enumerator<, >)0;
					num10 = 0;
					val3 = val5;
					obj28 = 0;
					val6 = (Enumerator<, >)(ref val3);
					val = (Enumerator<, >)1;
					style = (ShiftAuth.Style)(&obj20);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v12+10]");
					val7 = (Enumerator<, >)0;
					val8 = val5;
					num11 = 40;
					flag14 = down;
					break;
				}
				throw new OutOfMemoryException();
			}
			System.__Canon _Canon2 = (System.__Canon)(object)text3;
			throw new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v16+E4]");
		bool flag15 = (nint)0 == 0;
		object obj29 = !flag15;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v16+A0]");
		object obj30 = 0;
		object obj31 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6E0]");
		object line = 0;
		object obj32 = default;
		Line(this.text, 128, 86, (string)line, (ShiftAuth.Style)(&obj32));
		End();
	}

	private unsafe void Line(ScreenFont font, int x, int y, string line, ShiftAuth.Style style)
	{
		//IL_024f: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected I4, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_004b: Expected Ref, but got VT
		//IL_027f: Expected Obj, but got I4
		//IL_01db: Expected Obj, but got I4
		//IL_02cd: Expected VT, but got Ref
		bool flag = string.IsNullOrEmpty(line);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			return;
		}
		if (font != null)
		{
			int num = font.DrawCentred(px, 256, 192, x, y, line, ref *(ShiftAuth.Style*)style);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = style.scale - 1;
		bool flag3 = (nint)obj4 < 0;
		bool flag4 = obj4 == null;
		int num2 = style.scale ^ 1;
		int num3 = style.scale ^ obj4;
		int num4 = num2 & num3;
		bool flag5 = num4 < 0;
		bool flag6 = flag3 == flag5;
		object obj5 = !flag4;
		object obj6 = flag6 & obj5;
		object obj7 = ~obj6;
		int scale = ((obj7 != null) ? 1 : style.scale);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v5+E4]");
		bool flag7 = (nint)0 == 0;
		object obj8 = !flag7;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num5 = PixelFont.Measure(line, scale);
		Color32[] colours = style.colours;
		if (style.colours != null)
		{
			bool flag8 = num5 < 0;
			int num6 = num5 ^ num5;
			int num7 = num5 & num6;
			bool flag9 = num7 < 0;
			bool flag10 = flag8 == flag9;
			object obj9 = !flag10;
			object obj10 = ~obj9;
			int num8 = ((obj10 != null) ? num5 : (num5 + 1));
			int x2 = x - num8;
			PixelFont.Draw(px, 256, 192, x2, y, line, (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref colours[0]), scale);
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	public GillaBundleStand()
	{
		//IL_001d: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BFB0]");
		reach = 0f;
		base._002Ector();
	}

	static GillaBundleStand()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj3 = 0;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107DD70]");
		obj5 = 0;
		int num = Shader.PropertyToID((string)obj2);
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+18]");
			bool flag = (nint)0 == 1;
			_ = 4278584838L;
			if (!flag)
			{
				_ = 4278584838L;
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v11+A0]");
				object obj9 = (nint)0 + (nint)24;
				object obj10 = default;
				obj9 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
