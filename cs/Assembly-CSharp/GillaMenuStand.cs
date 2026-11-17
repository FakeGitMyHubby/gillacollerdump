using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class GillaMenuStand : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public GillaBundleStand _003C_003E4__this;

		public int with;

		public Coins.Bundle b;

		internal unsafe void _003COnPress_003Eb__0(GillaPurchases.Result result)
		{
			//IL_01ae: Expected Obj, but got I
			//IL_01d8: Expected Obj, but got I4
			//IL_0205: Expected Obj, but got I
			//IL_0215: Expected Obj, but got I
			//IL_001f: Expected Obj, but got I4
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Expected Obj, but got Unknown
			//IL_0254: Expected I, but got Obj
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected I4, but got Unknown
			//IL_009f: Expected Obj, but got I
			//IL_00c0: Expected Obj, but got I
			//IL_00d0: Expected Obj, but got I
			//IL_0103: Expected Obj, but got I
			//IL_012d: Expected Obj, but got I4
			//IL_015a: Expected Obj, but got I
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected Obj, but got Unknown
			//IL_0199: Expected I, but got Obj
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
					goto IL_029c;
				}
				GillaBundleStand gillaBundleStand2 = _003C_003E4__this;
				float unscaledTime = Time.unscaledTime;
				GillaBundleStand gillaBundleStand3 = _003C_003E4__this;
				Coins.Bundle bundle = b;
				float checkingUntil = unscaledTime + gillaBundleStand3.checkingFor;
				gillaBundleStand2.checkingUntil = checkingUntil;
				int num = b + 44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
				object obj2 = 0;
				string text = ((int*)num)->ToString((string)obj2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7B8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7B0]");
				object obj4 = 0;
				string text2 = bundle.label + (string)obj3 + text + (string)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v18+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v6+E4]");
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
			goto IL_029c;
			IL_029c:
			gillaBundleStand.Play(clip);
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public GillaMenuStand _003C_003E4__this;

		public int with;

		internal void _003COnPress_003Eb__0(GillaPurchases.Result result)
		{
			//IL_023e: Expected Obj, but got I
			//IL_0268: Expected Obj, but got I4
			//IL_0295: Expected Obj, but got I
			//IL_02a5: Expected Obj, but got I
			//IL_001f: Expected Obj, but got I4
			//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ec: Expected Obj, but got Unknown
			//IL_02fd: Expected I, but got Obj
			//IL_0305: Expected I4, but got Obj
			//IL_0536: Expected Obj, but got I
			//IL_0560: Expected Obj, but got I4
			//IL_035e: Expected Obj, but got I
			//IL_0098: Expected Obj, but got I
			//IL_00e3: Expected Obj, but got I4
			//IL_038e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0393: Expected Obj, but got Unknown
			//IL_014c: Expected Obj, but got I
			//IL_0172: Expected Obj, but got I
			//IL_019c: Expected Obj, but got I4
			//IL_01c9: Expected Obj, but got I
			//IL_047c: Expected Obj, but got I
			//IL_0494: Expected Obj, but got I
			//IL_04a4: Expected Obj, but got I
			//IL_0518: Expected Obj, but got I4
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0210: Expected Obj, but got Unknown
			//IL_0221: Expected I, but got Obj
			//IL_0229: Expected I4, but got Obj
			//IL_042b: Expected VT, but got I4
			UnityEngine.Object obj2;
			GillaMenuStand gillaMenuStand2 = default;
			float num = default;
			object obj11;
			GillaPurchases.Result result2 = default;
			if (result2 != (GillaPurchases.Result)2)
			{
				bool flag = result2 == 0;
				object obj = !flag;
				if (obj != null)
				{
					obj2 = null;
					goto IL_0526;
				}
				GillaMenuStand gillaMenuStand = _003C_003E4__this;
				float unscaledTime = Time.unscaledTime;
				gillaMenuStand2 = _003C_003E4__this;
				if ((object)_003C_003E4__this != null && (object)_003C_003E4__this != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
					object obj3 = 0;
					num = unscaledTime + gillaMenuStand2.checkingFor;
					object obj4 = obj3;
					gillaMenuStand.checkingUntil = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v34+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					ModMenuAccess.SetEquipped(gillaMenuStand2.item, on: true);
					GillaMenuStand gillaMenuStand3 = _003C_003E4__this;
					if ((object)_003C_003E4__this != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF820]");
						object obj6 = 0;
						string text = gillaMenuStand3.menuName + (string)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
						object obj7 = 0;
						object obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v33+E4]");
						bool flag3 = (nint)0 == 0;
						object obj9 = !flag3;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7A0]");
						object obj10 = 0;
						GillaToast.Show(with, (string)obj10, text, error: false);
						if ((object)_003C_003E4__this != null)
						{
							obj11 = _003C_003E4__this + 88;
							bool flag4 = false;
							nint num2 = (nint)text;
							result2 = (GillaPurchases.Result)obj10;
							goto IL_045f;
						}
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
				object obj12 = 0;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v29+E4]");
				bool flag5 = (nint)0 == 0;
				object obj14 = !flag5;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7C0]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7A8]");
				object obj16 = 0;
				GillaToast.Show(with, (string)obj15, (string)obj16, error: true);
				if ((object)_003C_003E4__this != null)
				{
					obj11 = _003C_003E4__this + 96;
					bool flag4 = true;
					nint num2 = (nint)obj16;
					result2 = (GillaPurchases.Result)obj15;
					goto IL_045f;
				}
			}
			goto IL_042d;
			IL_042d:
			NullReferenceException ex = new NullReferenceException();
			throw new IndexOutOfRangeException();
			IL_0526:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj17 = 0;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v3+E4]");
			bool flag6 = (nint)0 == 0;
			object obj19 = !flag6;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(obj2 != null))
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			AudioClip[] array = default;
			if (array != null)
			{
				object obj21 = array + 32;
				obj21 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if ((object)_003C_003E4__this != null)
				{
					Transform transform = _003C_003E4__this.transform;
					if ((object)transform != null)
					{
						Vector3 position = transform.position;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
						object obj22 = 0;
						object obj23 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v14+A0]");
						object obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
						object obj25 = 0;
						object obj26 = obj25;
						object obj27 = default;
						float num3 = (float)obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v15+20]");
						float pitchMax = num3 + 0f;
						float num4 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v15+18]");
						float volume = num4 + 0f;
						float num5 = gillaMenuStand2.checkingFor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v15+1C]");
						float pitchMin = num5 + 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v16+E4]");
						bool flag7 = (nint)0 == 0;
						object obj28 = !flag7;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Sfx.Play(array, (Vector3)0, volume, pitchMin, pitchMax);
						return;
					}
				}
			}
			goto IL_042d;
			IL_045f:
			obj2 = (UnityEngine.Object)obj11;
			goto IL_0526;
		}
	}

	public string sku;

	public string item;

	public string menuName;

	public PressKey buyKey;

	public Renderer screen;

	public TextAsset titleFont;

	public TextAsset textFont;

	public AudioClip buySound;

	public AudioClip denySound;

	public AudioClip equipSound;

	public float checkingFor = 20f;

	public const int W = default(int);

	public const int H = default(int);

	public static readonly RectInt Button;

	private bool Live__BackingField;

	private const float AskEvery = default(float);

	private static readonly int BaseMap;

	private static readonly Color32[] Ink;

	private float nextAsk;

	private float checkingUntil;

	private float downUntil;

	private string shown;

	private string drawn;

	private Texture2D tex;

	private Color32[] px;

	private ScreenFont title;

	private ScreenFont text;

	private MaterialPropertyBlock block;

	public const string ModeratorsName = null;

	public string Shown => shown;

	public bool Live
	{
		get
		{
			return Live__BackingField;
		}
		private set
		{
			Live__BackingField = value;
		}
	}

	private bool ForModerators
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6F8]");
			object obj = 0;
			return item == (string)obj;
		}
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I
		//IL_0108: Expected I, but got Obj
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
		if (buyKey != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Application.isPlaying)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7C8]");
				object obj8 = 0;
				Action<System.__Canon> action = default;
				action._002Ector((object)this, (IntPtr)obj8);
				buyKey.Pressed += (Action<PressKey>)action;
			}
		}
		Redraw();
	}

	public void Redraw()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0217: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I4
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
		bool flag2 = titleFont != null;
		bool flag3 = !flag2;
		object obj4 = 0;
		ScreenFont screenFont = null;
		if (!flag3)
		{
			string baked = titleFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont2 = default;
			screenFont2._002Ector(baked);
			obj4 = 0;
			screenFont = screenFont2;
		}
		object obj6 = this + 168;
		obj6 = screenFont;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X21_v4-58]");
		bool flag5 = (UnityEngine.Object)0 != null;
		bool flag6 = !flag5;
		object obj9 = 0;
		ScreenFont screenFont3 = null;
		if (!flag6)
		{
			string baked2 = textFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont4 = default;
			screenFont4._002Ector(baked2);
			obj9 = 0;
			screenFont3 = screenFont4;
		}
		object obj11 = this + 176;
		obj11 = screenFont3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj12 = this + 144;
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Update();
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_0106: Expected I, but got Obj
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
		if (buyKey != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Application.isPlaying)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7C8]");
				object obj8 = 0;
				Action<System.__Canon> action = default;
				action._002Ector((object)this, (IntPtr)obj8);
				buyKey.Pressed -= (Action<PressKey>)action;
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
		//IL_0937: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I4
		//IL_001f: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I4
		//IL_097d: Expected Obj, but got I
		//IL_09a7: Expected Obj, but got I4
		//IL_0249: Expected Obj, but got I4
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_02af: Invalid comparison between F4 and I4
		//IL_030d: Expected Obj, but got I
		//IL_031b: Expected Obj, but got I4
		//IL_034a: Expected Obj, but got I4
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ec: Expected Obj, but got Unknown
		//IL_0a1a: Expected Obj, but got I4
		//IL_0a25: Expected Obj, but got I4
		//IL_01db: Expected Obj, but got I4
		//IL_037e: Expected Obj, but got I4
		//IL_0206: Expected F4, but got I4
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9f: Expected Obj, but got Unknown
		//IL_02f8: Expected Obj, but got I4
		//IL_0564: Expected Obj, but got I4
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected Obj, but got Unknown
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got Unknown
		//IL_0599: Expected Obj, but got I4
		//IL_0487: Expected Obj, but got I4
		//IL_04f5: Expected Obj, but got I
		//IL_05e3: Expected Obj, but got I
		//IL_061a: Expected Obj, but got I4
		//IL_08eb: Expected Obj, but got I
		//IL_08f6: Expected Obj, but got I4
		//IL_0849: Expected Obj, but got I
		//IL_03e2: Expected Obj, but got I4
		//IL_05c1: Expected Obj, but got I4
		//IL_05ce: Expected I4, but got Obj
		//IL_08a7: Expected Obj, but got I
		//IL_08b5: Expected Obj, but got I4
		//IL_0875: Expected Obj, but got I
		//IL_0b4d: Expected Obj, but got I4
		//IL_04e0: Expected Obj, but got I
		//IL_0520: Expected Obj, but got I
		//IL_07a0: Expected Obj, but got I
		//IL_0674: Expected Obj, but got I
		//IL_069e: Expected Obj, but got I4
		//IL_043b: Expected Obj, but got I
		//IL_078b: Expected Obj, but got I
		//IL_07ca: Expected Obj, but got I
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Expected Obj, but got Unknown
		//IL_07b5: Expected Obj, but got I
		//IL_071e: Expected Obj, but got I4
		//IL_07e9: Invalid comparison between F4 and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
		object obj = 0;
		bool flag = string.IsNullOrEmpty(sku);
		bool forModerators = ForModerators;
		bool flag3;
		string text;
		bool flag4;
		bool flag5;
		if (flag)
		{
			bool flag2 = !forModerators;
			object obj2 = !flag2;
			flag3 = true;
			text = null;
			if (obj2 == null)
			{
				flag4 = true;
				flag5 = false;
				text = null;
				goto IL_02fd;
			}
		}
		else
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v62+E4]");
			bool flag6 = (nint)0 == 0;
			object obj4 = !flag6;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text2 = GillaPurchases.PriceOf(sku);
			if (text2 != null)
			{
				flag3 = false;
				text = text2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v66+E4]");
				bool flag7 = (nint)0 == 0;
				object obj7 = !flag7;
				if (obj7 == null)
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
						object obj8 = obj;
						unscaledTime = unscaledTime2 + 1.1146363E+09f;
						nextAsk = unscaledTime;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v74+E4]");
						bool flag8 = (nint)0 == 0;
						object obj9 = !flag8;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaPurchases.FetchPrices();
						num = 1.1146363E+09f;
					}
				}
				flag3 = true;
				text = null;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v38+E4]");
		bool flag9 = (nint)0 == 0;
		object obj12 = !flag9;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag10 = ModMenuAccess.Owns(item);
		object obj13 = flag | flag10;
		object obj14 = obj13 & 1;
		bool flag11;
		if (obj14 != null)
		{
			flag11 = false;
		}
		else
		{
			float unscaledTime = Time.unscaledTime;
			float num = checkingUntil;
			float num2 = unscaledTime - checkingUntil;
			bool flag12 = num2 < 0f;
			flag11 = flag12;
		}
		bool flag13 = !flag11;
		object obj15;
		string text3;
		GillaMenuStand gillaMenuStand;
		GillaMenuStand gillaMenuStand2;
		object obj21;
		if (flag)
		{
			bool flag14 = !forModerators;
			flag4 = flag13;
			flag5 = flag10;
			if (flag14)
			{
				goto IL_02fd;
			}
			obj15 = 1;
		}
		else
		{
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v51+E4]");
			bool flag15 = (nint)0 == 0;
			object obj17 = !flag15;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool busy = GillaPurchases.Busy;
			obj15 = (busy ? 1 : 0) ^ 1;
			if (!forModerators)
			{
				if (flag10)
				{
					object obj18 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v53+E4]");
					bool flag16 = (nint)0 == 0;
					object obj19 = !flag16;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj20;
					if (ModMenuAccess.Worn(item))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7D8]");
						obj20 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF388]");
						obj20 = 0;
					}
					text3 = (string)obj20;
					gillaMenuStand = null;
					flag4 = flag13;
					flag5 = true;
					gillaMenuStand2 = this;
					goto IL_09e1;
				}
				if (flag11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6A8]");
					obj21 = 0;
					gillaMenuStand = null;
					flag4 = false;
					flag5 = false;
				}
				else
				{
					if (!busy)
					{
						bool flag17 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6B8]");
						object obj22 = 0;
						object obj23 = !flag17;
						object obj24 = ~obj23;
						text3 = (string)((obj24 != null) ? text : obj22);
						gillaMenuStand = null;
						obj15 = 1;
						flag4 = true;
						flag5 = false;
						gillaMenuStand2 = this;
						goto IL_09e1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6B0]");
					obj21 = 0;
					gillaMenuStand = null;
					obj15 = 0;
					flag4 = true;
					flag5 = false;
				}
				goto IL_0b2d;
			}
		}
		if (flag10)
		{
			object obj25 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v45+E4]");
			bool flag18 = (nint)0 == 0;
			object obj26 = !flag18;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj27;
			if (ModMenuAccess.Worn(item))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7D8]");
				obj27 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF388]");
				obj27 = 0;
			}
			text3 = (string)obj27;
			flag5 = true;
			gillaMenuStand2 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7D0]");
			object obj28 = 0;
			text3 = (string)obj28;
			flag5 = false;
			gillaMenuStand2 = null;
		}
		gillaMenuStand = this;
		flag4 = flag13;
		goto IL_09e1;
		IL_09e1:
		object obj29 = this + 136;
		obj29 = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag19 = !forModerators;
		object obj30 = forModerators | flag;
		object obj31 = !flag19;
		object obj32 = ~obj31;
		GillaMenuStand gillaMenuStand3 = ((obj32 != null) ? gillaMenuStand2 : gillaMenuStand);
		object obj33 = obj30 & 1;
		if (obj33 != null)
		{
			flag5 = forModerators & flag5;
			gillaMenuStand2 = gillaMenuStand3;
		}
		else
		{
			object obj34 = !flag4;
			object obj35 = flag5 | obj34;
			object obj36 = obj35 & 1;
			bool flag20 = obj36 == null;
			object obj37 = !flag20;
			if (obj37 == null)
			{
				bool flag21 = text == null;
				object obj38 = !flag21;
				flag5 = (byte)(obj15 & obj38) != 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj39 = 0;
		gillaMenuStand2.Live__BackingField = flag5;
		object obj40 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X0_v13+E4]");
		bool flag22 = (nint)0 == 0;
		object obj41 = !flag22;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (buyKey != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj42 = 0;
			object obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X0_v25+E4]");
			bool flag23 = (nint)0 == 0;
			object obj44 = !flag23;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Application.isPlaying)
			{
				GameObject gameObject = buyKey.gameObject;
				bool activeSelf = gameObject.activeSelf;
				bool flag24 = !Live__BackingField;
				object obj45 = !flag24;
				if ((activeSelf ? 1 : 0) != (nint)obj45)
				{
					GameObject gameObject2 = buyKey.gameObject;
					gameObject2.SetActive(Live__BackingField);
				}
			}
		}
		float unscaledTime3 = Time.unscaledTime;
		object obj46;
		if (!Live__BackingField)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6960]");
			obj46 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60E0]");
			obj46 = 0;
		}
		object obj47;
		if (unscaledTime3 < downUntil)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7E0]");
			obj47 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			obj47 = 0;
		}
		string text4 = shown + (string)obj46 + (string)obj47;
		object obj48 = this + 144;
		if (text4 != (string)obj48)
		{
			float num3 = unscaledTime3 - downUntil;
			bool down = num3 < 0f;
			drawn = text4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Draw(shown, Live__BackingField, down);
		}
		return;
		IL_02fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6B8]");
		obj21 = 0;
		gillaMenuStand = null;
		obj15 = 1;
		goto IL_0b2d;
		IL_0b2d:
		text3 = (string)obj21;
		gillaMenuStand2 = this;
		goto IL_09e1;
	}

	public void Press()
	{
		OnPress(buyKey);
	}

	private void OnPress(PressKey key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I4
		//IL_01c6: Expected Obj, but got I
		//IL_01ce: Expected VT, but got Obj
		//IL_01f0: Expected Obj, but got I4
		//IL_022a: Expected Obj, but got I
		//IL_0259: Expected Obj, but got I4
		//IL_053b: Expected Obj, but got I
		//IL_0555: Expected Obj, but got I
		//IL_0566: Expected I, but got Obj
		//IL_0595: Expected Obj, but got I4
		//IL_02cc: Expected Obj, but got I4
		//IL_05c7: Expected Obj, but got I
		//IL_0303: Expected Obj, but got I4
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected I4, but got Unknown
		//IL_0344: Expected Obj, but got I
		//IL_0359: Expected Obj, but got I4
		//IL_0385: Expected Obj, but got I
		//IL_0651: Expected Obj, but got I4
		//IL_065a: Expected Obj, but got I4
		//IL_0662: Expected Obj, but got I4
		//IL_0757: Expected Obj, but got I4
		//IL_0420: Expected Obj, but got I4
		//IL_039a: Expected Obj, but got I
		//IL_03bc: Expected Obj, but got I4
		//IL_047a: Expected Obj, but got I
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected Obj, but got Unknown
		//IL_0680: Expected Obj, but got I
		//IL_0698: Expected Obj, but got I
		//IL_06a8: Expected Obj, but got I
		//IL_071f: Expected Obj, but got I4
		//IL_052a: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF810]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (~(Live__BackingField ? 1u : 0u) != 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (GillaPurchases.Busy)
			{
				return;
			}
			float unscaledTime = Time.unscaledTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj7 = 0;
			float num = unscaledTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			float num2 = num + 0f;
			object obj8 = obj7;
			downUntil = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Component component;
			if (key != null)
			{
				if ((object)key == null)
				{
					goto IL_05c8;
				}
				component = key;
			}
			else
			{
				component = this;
			}
			Transform transform = component.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
				object obj10 = 0;
				Vector3 to = (Vector3)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v24 (UnityEngine.Vector3)+E4]");
				bool flag3 = (nint)0 == 0;
				object obj11 = !flag3;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num3 = GillaToast.NearerHand(to);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
				object obj12 = 0;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v26+E4]");
				bool flag4 = (nint)0 == 0;
				object obj14 = !flag4;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!ModMenuAccess.Owns(item))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF5D8]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF818]");
					object obj16 = 0;
					Action<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> action = default;
					action._002Ector(obj2, (IntPtr)obj16);
					object obj17 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v32+E4]");
					bool flag5 = (nint)0 == 0;
					object obj18 = !flag5;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD020]");
					GillaPurchases.Buy((string)0, (Action<GillaPurchases.Result>)(object)action);
					return;
				}
				object obj19 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v36+E4]");
				bool flag6 = (nint)0 == 0;
				object obj20 = !flag6;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag7 = ModMenuAccess.Worn(item);
				object obj21 = !flag7;
				bool flag8 = (byte)(1 & obj21) != 0;
				ModMenuAccess.SetWorn(item, flag8);
				bool flag9 = !flag7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF340]");
				object obj22 = 0;
				string text = menuName;
				object obj23 = !flag9;
				object obj24 = ~obj23;
				if (obj24 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF398]");
					obj22 = 0;
				}
				bool flag10 = !flag7;
				object obj25 = !flag10;
				object obj26 = 0;
				string text2 = (string)flag8;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF820]");
					object obj27 = 0;
					text2 = (string)obj27;
					string text3 = text + (string)obj27;
					obj26 = 0;
					text = text3;
				}
				object obj28 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v42+E4]");
				bool flag11 = (nint)0 == 0;
				object obj29 = !flag11;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+18]");
				GillaToast.Show(0, (string)obj22, text, error: false);
				object obj30 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v45+E4]");
				bool flag12 = (nint)0 == 0;
				object obj31 = !flag12;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(equipSound != null))
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				AudioClip[] array = default;
				if (array != null)
				{
					object obj33 = array + 32;
					obj33 = equipSound;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Transform transform2 = base.transform;
					if ((object)transform2 != null)
					{
						Vector3 position2 = transform2.position;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
						object obj34 = 0;
						object obj35 = obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v32+A0]");
						object obj36 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
						object obj37 = 0;
						object obj38 = obj37;
						object obj39 = default;
						float num4 = (float)obj39;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v33+20]");
						float pitchMax = num4 + 0f;
						float num5 = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v33+18]");
						float volume = num5 + 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
						float num6 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v33+1C]");
						float pitchMin = num6 + 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v58+E4]");
						bool flag13 = (nint)0 == 0;
						object obj40 = !flag13;
						if (obj40 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Sfx.Play(array, (Vector3)0, volume, pitchMin, pitchMax);
						return;
					}
				}
			}
		}
		goto IL_05c8;
		IL_05c8:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void Draw(string label, bool live, bool down)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0b6e: Expected Obj, but got I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0087: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I4
		//IL_0202: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_02b4: Expected Obj, but got I
		//IL_02bf: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_01e5: Expected Obj, but got I4
		//IL_0e89: Expected Obj, but got I4
		//IL_0302: Expected Obj, but got I
		//IL_0314: Expected Obj, but got I4
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected I4, but got Unknown
		//IL_037d: Expected Obj, but got I4
		//IL_0c00: Expected Obj, but got I
		//IL_0bba: Expected Obj, but got I4
		//IL_0485: Expected Obj, but got I
		//IL_0490: Expected Obj, but got I4
		//IL_0449: Expected Obj, but got I
		//IL_0c7c: Expected Obj, but got I4
		//IL_04c0: Expected Obj, but got I
		//IL_0ea7: Expected Obj, but got I
		//IL_0ed2: Expected Obj, but got I
		//IL_0ee2: Expected Obj, but got I
		//IL_0f0c: Expected Obj, but got I4
		//IL_0c9a: Expected Obj, but got I
		//IL_0587: Expected Obj, but got I4
		//IL_0cf0: Expected Obj, but got I
		//IL_0f2a: Expected Obj, but got I
		//IL_0f54: Expected Obj, but got I4
		//IL_05ce: Expected Obj, but got I4
		//IL_0612: Expected Obj, but got I
		//IL_063c: Expected Obj, but got I4
		//IL_0d0b: Expected Obj, but got I
		//IL_0540: Expected Obj, but got I4
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected I4, but got Unknown
		//IL_06b6: Expected VT, but got Obj
		//IL_0713: Expected VT, but got Obj
		//IL_0713: Expected I4, but got Obj
		//IL_0cd5: Expected Obj, but got I
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected I4, but got Unknown
		//IL_0791: Expected VT, but got Obj
		//IL_0804: Expected Obj, but got I4
		//IL_0911: Expected Obj, but got I4
		//IL_0837: Expected Obj, but got I
		//IL_0862: Expected I4, but got Obj
		//IL_0dae: Expected Obj, but got I4
		//IL_088a: Expected I4, but got Obj
		//IL_0dcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd2: Expected I4, but got Unknown
		//IL_09d6: Expected Obj, but got I4
		//IL_0e20: Expected Obj, but got I
		//IL_0987: Expected Obj, but got I4
		//IL_0f6f: Expected Obj, but got I4
		//IL_0f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f84: Expected Obj, but got Unknown
		//IL_0fd5: Expected Obj, but got I4
		//IL_0e05: Expected Obj, but got I
		//IL_0e35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3a: Expected I4, but got Unknown
		//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a09: Expected Obj, but got Unknown
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Expected Obj, but got Unknown
		//IL_0a59: Expected Obj, but got I4
		//IL_0adf: Expected Obj, but got I4
		//IL_0b14: Expected Obj, but got I
		//IL_0a77: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (screen == null)
		{
			return;
		}
		object obj4 = obj;
		object obj5 = this + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = (UnityEngine.Object)obj5 == null;
		bool flag4 = !flag3;
		IntPtr intPtr = default;
		bool flag5 = (byte)(nint)intPtr != 0;
		TextureFormat textureFormat = (down ? ((TextureFormat)1) : ((TextureFormat)0));
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Texture2D texture2D = default;
			texture2D._002Ector(256, 128, (TextureFormat)4, mipChain: false);
			texture2D.filterMode = (FilterMode)0;
			texture2D.wrapMode = (TextureWrapMode)1;
			texture2D.hideFlags = (HideFlags)52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7F0]");
			object obj10 = 0;
			texture2D.name = (string)obj10;
			tex = texture2D;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj12 = this + 160;
			UnityEngine.Object obj13 = default;
			obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			flag5 = false;
			textureFormat = (TextureFormat)4;
			obj7 = 0;
			obj8 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaBoardLook.Clear(px, 256, 128);
		GillaBoardLook.Frame(px, 256, 128, 3);
		object obj17 = this + 48;
		bool flag7 = string.IsNullOrEmpty((string)obj17);
		bool flag8 = !flag7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6D8]");
		object obj18 = 0;
		object obj19 = !flag8;
		object obj20 = ~obj19;
		if (obj20 != null)
		{
			obj18 = obj17;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X20_v5+78]");
		ScreenFont font;
		int scale;
		int y;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X20_v5+78]");
			int num = ((ScreenFont)0).Measure((string)obj18, 2);
			object obj21 = num - 229;
			bool flag9 = (nint)obj21 < 0;
			int num2 = num ^ 0xE5;
			int num3 = num ^ obj21;
			int num4 = num2 & num3;
			bool flag10 = num4 < 0;
			font = title;
			bool flag11 = flag9 == flag10;
			object obj22 = !flag11;
			object obj23 = ~obj22;
			scale = ((obj23 != null) ? 1 : (1 + 1));
			bool flag12 = flag9 == flag10;
			object obj24 = !flag12;
			object obj25 = ~obj24;
			y = ((obj25 != null) ? 14 : 10);
			int num5 = 0;
			int num6 = 2;
			string text = (string)obj18;
		}
		else
		{
			int num5 = 3;
			font = null;
			y = 10;
			int num6 = 128;
			string text = null;
			scale = 2;
		}
		object obj26 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v22+E4]");
		bool flag13 = (nint)0 == 0;
		object obj27 = !flag13;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj26 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v22+A0]");
		object colours = 0;
		Line(font, 128, y, (string)obj18, scale, (Color32[])colours);
		GillaBoardLook.Rule(px, 256, 128, 10, 245, 34);
		object obj28;
		if (ForModerators)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7F8]");
			obj28 = 0;
			int num7 = 256;
		}
		else
		{
			bool flag14 = string.IsNullOrEmpty(sku);
			bool flag15 = !flag14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF808]");
			obj28 = 0;
			object obj29 = !flag15;
			object obj30 = ~obj29;
			if (obj30 == null)
			{
				int num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF800]");
				obj28 = 0;
			}
			else
			{
				int num7 = 0;
			}
		}
		object obj31 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v29+E4]");
		bool flag16 = (nint)0 == 0;
		object obj32 = !flag16;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v29+A0]");
		object obj33 = 0;
		ScreenFont font2 = this.text;
		object line = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v15+10]");
		Line(font2, 128, 43, (string)line, 1, (Color32[])0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7E8]");
		object obj34 = 0;
		object obj35 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v32+E4]");
		bool flag17 = (nint)0 == 0;
		object obj36 = !flag17;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj35 = obj34;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v32+A0]");
		object obj37 = 0;
		object obj38 = obj14;
		object obj40;
		if (live)
		{
			if (down)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v82+E4]");
				bool flag18 = (nint)0 == 0;
				object obj39 = !flag18;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj38 = obj14;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v82+A0]");
				obj40 = (nint)0 + (nint)36;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v82+E4]");
				bool flag19 = (nint)0 == 0;
				object obj41 = !flag19;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj38 = obj14;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v82+A0]");
				obj40 = (nint)0 + (nint)44;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v82+E4]");
			bool flag20 = (nint)0 == 0;
			object obj42 = !flag20;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj38 = obj14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v82+A0]");
			obj40 = (nint)0 + (nint)40;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj43 = 0;
		object obj44 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v35+E4]");
		bool flag21 = (nint)0 == 0;
		object obj45 = !flag21;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj46 = 0;
		object obj47 = obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v37+E4]");
		bool flag22 = (nint)0 == 0;
		object obj48 = !flag22;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+8]");
		int rw = (int)(-6);
		int x = obj37 + 3;
		Color32[] array = px;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+4]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+C]");
		PixelFont.Fill(array, 256, 128, x, (int)num8, rw, 0, (Color32)obj40);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+C]");
		int rh = (int)(-6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+4]");
		int y2 = (int)((nint)0 + (nint)3);
		Color32[] array2 = px;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+8]");
		PixelFont.Fill(array2, 256, 128, (int)obj37, y2, 0, rh, (Color32)obj40);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+8]");
		int rw2 = (int)(-2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+C]");
		int rh2 = (int)(-2);
		int x2 = obj37 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+4]");
		int y3 = (int)((nint)0 + (nint)1);
		PixelFont.Fill(px, 256, 128, x2, y3, rw2, rh2, (Color32)obj40);
		bool flag23 = this.text == null;
		int num9 = 128;
		int num10 = 256;
		int num12;
		if (!flag23)
		{
			int num11 = this.text.Measure(label, 2);
			object obj49 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v47+E4]");
			bool flag24 = (nint)0 == 0;
			object obj50 = !flag24;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+8]");
			object obj51 = -10;
			bool flag25 = num11 <= (nint)obj51;
			x2 = 0;
			num9 = 2;
			num10 = (int)label;
			if (!flag25)
			{
				x2 = 0;
				num9 = 2;
				num10 = (int)label;
				num12 = 1;
				goto IL_0d10;
			}
		}
		num12 = 2;
		goto IL_0d10;
		IL_0d3d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+8]");
		bool flag26 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+8]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+8]");
		int num14 = (int)(num13 ^ 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+8]");
		int num15 = (int)((nint)0 & (nint)num14);
		bool flag27 = num15 < 0;
		bool flag28 = flag26 == flag27;
		object obj52 = !flag28;
		object obj53 = ~obj52;
		int num16;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+8]");
			num16 = (int)((nint)0 + (nint)1);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+8]");
			num16 = 0;
		}
		int x3 = obj37 + num16;
		object colours2;
		if (live)
		{
			object obj54 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X0_v66+E4]");
			bool flag29 = (nint)0 == 0;
			object obj55 = !flag29;
			if (obj55 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj54 = obj34;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X0_v66+A0]");
			colours2 = (nint)0 + (nint)24;
		}
		else
		{
			object obj56 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X0_v62+E4]");
			bool flag30 = (nint)0 == 0;
			object obj57 = !flag30;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj56 = obj14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X0_v62+A0]");
			colours2 = (nint)0 + (nint)8;
		}
		int num17;
		object obj58 = num17 * num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+C]");
		object obj59 = 0 - obj58;
		bool flag31 = (nint)obj59 < 0;
		object obj60 = obj59 ^ obj59;
		object obj61 = obj59 & obj60;
		bool flag32 = (nint)obj61 < 0;
		bool flag33 = flag31 == flag32;
		object obj62 = !flag33;
		object obj63 = ~obj62;
		if (obj63 == null)
		{
			obj59++;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v17+4]");
		int y4 = 0 + obj59;
		Line(this.text, x3, y4, label, num12, (Color32[])colours2);
		tex.SetPixels32(px);
		tex.Apply(updateMipmaps: false);
		object obj64 = this + 184;
		bool flag34 = obj64 == null;
		object obj65 = !flag34;
		if (obj65 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			obj64 = materialPropertyBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		screen.GetPropertyBlock((MaterialPropertyBlock)obj64);
		object obj67 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X0_v52+E4]");
		bool flag35 = (nint)0 == 0;
		object obj68 = !flag35;
		if (obj68 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj69 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v31+A0]");
		object obj70 = 0;
		object obj71 = obj64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v32+10]");
		((MaterialPropertyBlock)obj71).SetTexture(0, (Texture)tex);
		screen.SetPropertyBlock((MaterialPropertyBlock)obj64);
		return;
		IL_08cf:
		ScreenFont screenFont;
		num17 = screenFont.cap;
		goto IL_0d3d;
		IL_0d10:
		object obj72 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X0_v44+E4]");
		if ((nint)0 != 0)
		{
			bool flag36 = this.text == null;
			screenFont = this.text;
			if (!flag36)
			{
				goto IL_08cf;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			screenFont = this.text;
			bool flag37 = this.text == null;
			object obj73 = !flag37;
			if (obj73 != null)
			{
				goto IL_08cf;
			}
		}
		num17 = 7;
		goto IL_0d3d;
	}

	private unsafe void Line(ScreenFont font, int x, int y, string line, int scale, Color32[] colours)
	{
		//IL_01bb: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got Ref
		//IL_0147: Expected Obj, but got I4
		//IL_0209: Expected VT, but got Ref
		bool flag = string.IsNullOrEmpty(line);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			return;
		}
		if (font != null)
		{
			ShiftAuth.Style s = default;
			object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref s, 16));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int num = font.DrawCentred(px, 256, 128, x, y, line, ref s);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num2 = PixelFont.Measure(line, scale);
		if (colours != null)
		{
			bool flag4 = num2 < 0;
			int num3 = num2 ^ num2;
			int num4 = num2 & num3;
			bool flag5 = num4 < 0;
			bool flag6 = flag4 == flag5;
			object obj6 = !flag6;
			object obj7 = ~obj6;
			int num5 = ((obj7 != null) ? num2 : (num2 + 1));
			int x2 = x - num5;
			PixelFont.Draw(px, 256, 128, x2, y, line, (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref colours[0]), scale);
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private static void HookModerators()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I
		//IL_00f1: Expected I, but got Obj
		//IL_011b: Expected Obj, but got I4
		//IL_006a: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4380]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF828]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4390]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7E8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction = default;
		unityAction._002Ector((object)null, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction2 = default;
		unityAction2._002Ector((object)null, (IntPtr)obj2);
		SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction2;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaMenuStand gillaMenuStand = MakeModerators();
	}

	private static void ModeratorsLoaded(Scene scene, LoadSceneMode mode)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaMenuStand gillaMenuStand = MakeModerators();
	}

	public static GillaMenuStand MakeModerators()
	{
		//IL_0010: Expected Obj, but got I
		//IL_130e: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_1346: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I4
		//IL_03a3: Expected Obj, but got I4
		//IL_136d: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I
		//IL_03e3: Expected Obj, but got I
		//IL_0418: Expected Obj, but got I4
		//IL_019c: Expected Obj, but got I
		//IL_045d: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I4
		//IL_0320: Expected Obj, but got I
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_049d: Expected Obj, but got I4
		//IL_01f5: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I4
		//IL_04ca: Expected Obj, but got I
		//IL_0266: Expected Obj, but got I4
		//IL_0509: Expected Obj, but got I
		//IL_0529: Expected Obj, but got I4
		//IL_13a5: Expected Obj, but got I4
		//IL_0540: Expected Obj, but got I4
		//IL_0549: Expected Obj, but got I4
		//IL_13cc: Expected Obj, but got I4
		//IL_02e8: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I4
		//IL_02fa: Expected Obj, but got I4
		//IL_084b: Expected Obj, but got I
		//IL_0875: Expected Obj, but got I4
		//IL_0573: Expected Obj, but got I
		//IL_08a2: Expected Obj, but got I
		//IL_05c2: Expected Obj, but got I4
		//IL_0908: Expected Obj, but got I
		//IL_05f1: Expected Obj, but got I
		//IL_060d: Expected Obj, but got I4
		//IL_07b5: Expected Obj, but got I
		//IL_07be: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected Obj, but got Unknown
		//IL_064a: Expected Obj, but got I4
		//IL_0955: Expected Obj, but got I
		//IL_096f: Expected Obj, but got I
		//IL_0679: Expected Obj, but got I
		//IL_0695: Expected Obj, but got I4
		//IL_06de: Expected Obj, but got I
		//IL_09e8: Expected VT, but got I4
		//IL_0736: Expected Obj, but got I4
		//IL_13ea: Expected Obj, but got I
		//IL_077b: Expected Obj, but got I4
		//IL_0784: Expected Obj, but got I4
		//IL_0792: Expected Obj, but got I4
		//IL_14ea: Expected VT, but got I4
		//IL_140a: Expected Obj, but got I
		//IL_1430: Expected VT, but got I4
		//IL_1430: Expected VT, but got I4
		//IL_1444: Expected Obj, but got I
		//IL_146e: Expected Obj, but got I4
		//IL_0a11: Expected Obj, but got I
		//IL_0a40: Expected VT, but got I4
		//IL_0a40: Expected VT, but got Obj
		//IL_0a55: Expected Obj, but got I
		//IL_149a: Expected VT, but got I4
		//IL_149a: Expected VT, but got Obj
		//IL_0a7b: Expected Obj, but got I
		//IL_0a98: Expected Obj, but got I
		//IL_0ad1: Expected Obj, but got I4
		//IL_0b75: Expected VT, but got I4
		//IL_0bb2: Expected VT, but got I4
		//IL_0bc2: Expected Obj, but got I
		//IL_0c07: Expected Obj, but got I
		//IL_0c62: Expected Obj, but got I
		//IL_0cdb: Expected VT, but got I4
		//IL_0cfa: Expected Obj, but got I
		//IL_0d42: Expected Obj, but got I
		//IL_0e0b: Expected Obj, but got I
		//IL_0e35: Expected Obj, but got I4
		//IL_0e91: Expected VT, but got I4
		//IL_0eb6: Expected VT, but got I4
		//IL_0ec6: Expected Obj, but got I
		//IL_0f0e: Expected VT, but got I4
		//IL_0f21: Expected VT, but got I4
		//IL_0f31: Expected Obj, but got I
		//IL_0f6d: Expected Obj, but got I
		//IL_0f76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7b: Expected Obj, but got Unknown
		//IL_0f9d: Expected Obj, but got I
		//IL_0fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd0: Expected Obj, but got Unknown
		//IL_0fe0: Expected Obj, but got I
		//IL_0ffa: Expected Obj, but got I
		//IL_101e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1023: Expected Obj, but got Unknown
		//IL_1074: Expected Obj, but got I
		//IL_10ab: Expected Obj, but got I
		//IL_10b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b9: Expected Obj, but got Unknown
		//IL_10db: Expected Obj, but got I
		//IL_10e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e9: Expected Obj, but got Unknown
		//IL_1109: Unknown result type (might be due to invalid IL or missing references)
		//IL_110e: Expected Obj, but got Unknown
		//IL_1129: Unknown result type (might be due to invalid IL or missing references)
		//IL_112e: Expected Obj, but got Unknown
		//IL_114e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1153: Expected Obj, but got Unknown
		//IL_1163: Expected Obj, but got I
		//IL_1176: Unknown result type (might be due to invalid IL or missing references)
		//IL_117b: Expected Obj, but got Unknown
		//IL_118b: Expected Obj, but got I
		//IL_11a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a8: Expected Obj, but got Unknown
		//IL_11b8: Expected Obj, but got I
		//IL_11cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d0: Expected Obj, but got Unknown
		//IL_11e0: Expected Obj, but got I
		//IL_11f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fd: Expected Obj, but got Unknown
		//IL_120d: Expected Obj, but got I
		//IL_1256: Expected Obj, but got I
		//IL_1280: Expected Obj, but got I4
		//IL_12ad: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isPlaying = Application.isPlaying;
		bool flag2 = !isPlaying;
		GillaMenuStand result = null;
		if (flag2)
		{
			goto IL_12c3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF850]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = (string)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj8 = default;
		if (obj8 == null)
		{
			goto IL_12c8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v11+18]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v11+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_0362;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF890]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF878]");
		object obj11 = 0;
		object obj12 = 0;
		UnityEngine.Object obj15;
		while (true)
		{
			bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
			object obj13 = !flag4;
			if (obj13 != null)
			{
				break;
			}
			object obj14 = obj8 + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v115+20]");
			obj15 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v115+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v115+20]");
				string text2 = ((UnityEngine.Object)0).name;
				string text3 = (string)obj10;
				bool flag5 = text2 == (string)obj10;
				bool flag6 = !flag5;
				object obj16 = 0;
				object obj20;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v115+20]");
					Transform parent = ((Transform)0).parent;
					object obj17 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X8_v118+E4]");
					bool flag7 = (nint)0 == 0;
					object obj18 = !flag7;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag8 = parent != null;
					bool flag9 = !flag8;
					obj16 = 0;
					text3 = null;
					if (!flag9)
					{
						Transform parent2 = ((Transform)obj15).parent;
						if ((object)parent2 == null)
						{
							goto IL_12c8;
						}
						string text4 = parent2.name;
						text3 = (string)obj11;
						bool flag10 = text4 == (string)obj11;
						bool flag11 = !flag10;
						object obj19 = !flag11;
						obj16 = 0;
						obj20 = 0;
						text = (string)obj11;
						if (obj19 != null)
						{
							goto IL_131c;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v11+18]");
				obj9 = 0;
				obj12++;
				object obj21 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v11+18]");
				bool flag12 = (nint)obj21 < 0;
				obj20 = obj16;
				text = text3;
				if (flag12)
				{
					continue;
				}
				goto IL_0362;
			}
			goto IL_12c8;
		}
		goto IL_12d6;
		IL_137b:
		object obj22 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X0_v31+E4]");
		bool flag13 = (nint)0 == 0;
		object obj23 = !flag13;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj24;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj25 = 0;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ X0_v180+E4]");
			bool flag14 = (nint)0 == 0;
			object obj27 = !flag14;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF870]");
			object message = 0;
			Debug.LogWarning(message);
			result = null;
			goto IL_12c3;
		}
		if ((object)obj24 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7 (UnityEngine.Object)+40]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7 (UnityEngine.Object)+40]");
				Transform transform = ((Component)0).transform;
				if ((object)transform != null)
				{
					Transform parent3 = transform.parent;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF888]");
					object obj29 = 0;
					GameObject gameObject = default;
					gameObject._002Ector((string)obj29);
					if ((object)gameObject != null)
					{
						Transform transform2 = gameObject.transform;
						if ((object)transform2 != null)
						{
							transform2.SetParent((Transform)obj15, worldPositionStays: false);
							transform2.localPosition = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
							object obj30 = 0;
							Vector3 forward = default;
							Vector3 upwards = default;
							Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
							transform2.localRotation = (Quaternion)0;
							object obj31 = obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1060 @ X8_v30+A0]");
							object obj32 = 0;
							Quaternion quaternion2 = Quaternion.Internal_AngleAxis(12f, ref forward);
							Vector3 vector = (Quaternion)0 * (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7E8]");
							object obj33 = 0;
							object obj34 = obj33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1074 @ X0_v55+E4]");
							bool flag15 = (nint)0 == 0;
							object obj35 = !flag15;
							if (obj35 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF8A0]");
							object part = 0;
							GillaPurchases._003C_003Ec__DisplayClass47_0 obj36 = default;
							Material material = _003CMakeModerators_003Eg__MatOf_007C47_0((string)part, ref obj36);
							Material mat = default;
							Quaternion rot = default;
							Part(transform2, (string)part, (Vector3)material, (Vector3)0, mat, rot);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF898]");
							object part2 = 0;
							Material material2 = _003CMakeModerators_003Eg__MatOf_007C47_0((string)part2, ref obj36);
							Part(transform2, (string)part2, (Vector3)material2, (Vector3)0, mat, rot);
							GameObject gameObject2 = GameObject.CreatePrimitive((PrimitiveType)5);
							if ((object)gameObject2 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF860]");
								object obj37 = 0;
								gameObject2.name = (string)obj37;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7560]");
								object obj38 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
								object obj39 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v48+E4]");
								bool flag16 = (nint)0 == 0;
								object obj40 = !flag16;
								if (obj40 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								UnityEngine.Object obj41 = default;
								UnityEngine.Object.Destroy(obj41);
								Transform transform3 = gameObject2.transform;
								if ((object)transform3 != null)
								{
									transform3.SetParent(transform2, worldPositionStays: false);
									Transform transform4 = gameObject2.transform;
									if ((object)transform4 != null)
									{
										transform4.localRotation = (Quaternion)0;
										Transform transform5 = gameObject2.transform;
										if ((object)transform5 != null)
										{
											transform5.localScale = (Vector3)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B18]");
											object obj42 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7 (UnityEngine.Object)+40]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7 (UnityEngine.Object)+40]");
												Material sharedMaterial = ((Renderer)0).sharedMaterial;
												Renderer renderer = default;
												if ((object)renderer != null)
												{
													renderer.sharedMaterial = sharedMaterial;
													renderer.shadowCastingMode = (ShadowCastingMode)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF880]");
													object obj43 = 0;
													GameObject gameObject3 = default;
													gameObject3._002Ector((string)obj43);
													if ((object)gameObject3 != null)
													{
														Transform transform6 = gameObject3.transform;
														if ((object)transform6 != null)
														{
															transform6.SetParent(transform2, worldPositionStays: false);
															transform6.localRotation = (Quaternion)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC180]");
															object obj44 = 0;
															GameObject gameObject4 = default;
															gameObject4._002Ector((string)obj44);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7 (UnityEngine.Object)+38]");
															if ((nint)0 != 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7 (UnityEngine.Object)+38]");
																GameObject gameObject5 = ((Component)0).gameObject;
																if ((object)gameObject5 != null)
																{
																	int layer = gameObject5.layer;
																	if ((object)gameObject4 != null)
																	{
																		gameObject4.layer = layer;
																		gameObject4.SetActive(value: false);
																		Transform transform7 = gameObject4.transform;
																		if ((object)transform7 != null)
																		{
																			transform7.SetParent(transform6, worldPositionStays: false);
																			Transform transform8 = gameObject4.transform;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
																			object obj45 = 0;
																			object obj46 = obj45;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v61+E4]");
																			bool flag17 = (nint)0 == 0;
																			object obj47 = !flag17;
																			if (obj47 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																			}
																			if ((object)transform8 != null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
																				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
																				transform8.localPosition = (Vector3)0;
																				Transform transform9 = gameObject4.transform;
																				Quaternion quaternion3 = Quaternion.Internal_LookRotation(ref forward, ref upwards);
																				if ((object)transform9 != null)
																				{
																					transform9.localRotation = (Quaternion)0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DE8]");
																					object obj48 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
																					Collider collider = default;
																					if ((object)collider != null)
																					{
																						collider.isTrigger = true;
																						((BoxCollider)collider).size = (Vector3)0;
																						((BoxCollider)collider).center = (Vector3)0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF840]");
																						object obj49 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
																						object obj50 = default;
																						if (obj50 != null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF868]");
																							object obj51 = 0;
																							object obj52 = obj50 + 32;
																							obj52 = obj51;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7 (UnityEngine.Object)+38]");
																							object obj53 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7 (UnityEngine.Object)+38]");
																							if ((nint)0 != 0)
																							{
																								object obj54 = obj50 + 40;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v78+28]");
																								obj54 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8408]");
																								object obj55 = 0;
																								_ = 0;
																								_ = 1011129254;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																								object obj56 = obj50 + 64;
																								object obj57 = default;
																								obj56 = obj57;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																								GameObject gameObject6 = ((Component)obj15).gameObject;
																								if ((object)gameObject6 != null)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF838]");
																									object obj58 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
																									Behaviour behaviour = default;
																									if ((object)behaviour != null)
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6F8]");
																										object obj59 = 0;
																										object obj60 = behaviour + 40;
																										obj60 = obj59;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB120]");
																										object obj61 = 0;
																										object obj62 = behaviour + 48;
																										obj62 = obj61;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										object obj63 = behaviour + 64;
																										obj63 = renderer;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										object obj64 = behaviour + 56;
																										obj64 = obj50;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										object obj65 = behaviour + 72;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7 (UnityEngine.Object)+48]");
																										obj65 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										object obj66 = behaviour + 80;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7 (UnityEngine.Object)+50]");
																										obj66 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										object obj67 = behaviour + 88;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7 (UnityEngine.Object)+58]");
																										obj67 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										object obj68 = behaviour + 96;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7 (UnityEngine.Object)+60]");
																										obj68 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										object obj69 = behaviour + 104;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7 (UnityEngine.Object)+68]");
																										obj69 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										behaviour.enabled = false;
																										behaviour.enabled = true;
																										((GillaMenuStand)behaviour).Redraw();
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
																										object obj70 = 0;
																										object obj71 = obj70;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1309 @ X0_v155+E4]");
																										bool flag18 = (nint)0 == 0;
																										object obj72 = !flag18;
																										if (obj72 == null)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																										}
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF858]");
																										object message2 = 0;
																										Debug.Log(message2);
																										result = (GillaMenuStand)behaviour;
																										goto IL_12c3;
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
				}
			}
		}
		goto IL_12c8;
		IL_12c3:
		return result;
		IL_07f7:
		obj24 = null;
		goto IL_137b;
		IL_131c:
		object obj73 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X0_v17+E4]");
		bool flag19 = (nint)0 == 0;
		object obj74 = !flag19;
		if (obj74 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag20 = obj15 == null;
		bool flag21 = !flag20;
		object obj75 = !flag21;
		result = null;
		if (obj75 != null)
		{
			goto IL_12c3;
		}
		if ((object)obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF830]");
			object obj76 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			object obj77 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v13+E4]");
			bool flag22 = (nint)0 == 0;
			object obj78 = !flag22;
			if (obj78 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj79 = default;
			bool flag23 = obj79 != null;
			bool flag24 = !flag23;
			object obj80 = !flag24;
			result = (GillaMenuStand)obj79;
			if (obj80 != null)
			{
				goto IL_12c3;
			}
			object obj81 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ X0_v26+E4]");
			bool flag25 = (nint)0 == 0;
			object obj82 = !flag25;
			if (obj82 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF848]");
			object obj83 = 0;
			UnityEngine.Object obj84 = (UnityEngine.Object)obj83;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
			object obj85 = default;
			if (obj85 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X0_v29+18]");
				object obj86 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X0_v29+18]");
				bool flag26 = (nint)0 < (nint)1;
				object obj87 = 0;
				if (flag26)
				{
					goto IL_07f7;
				}
				object obj88 = 0;
				object obj89 = 0;
				UnityEngine.Object obj90 = (UnityEngine.Object)obj83;
				while (true)
				{
					bool flag27 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj89) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj86);
					object obj91 = !flag27;
					if (obj91 != null)
					{
						break;
					}
					object obj92 = obj85 + obj89;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v107+20]");
					obj24 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v107+20]");
					if ((nint)0 != 0)
					{
						object obj93 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v938 @ X0_v187+E4]");
						bool flag28 = (nint)0 == 0;
						object obj94 = !flag28;
						if (obj94 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7 (UnityEngine.Object)+40]");
						bool flag29 = (UnityEngine.Object)0 != null;
						bool flag30 = !flag29;
						obj88 = 0;
						obj90 = null;
						if (!flag30)
						{
							object obj95 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v970 @ X0_v192+E4]");
							bool flag31 = (nint)0 == 0;
							object obj96 = !flag31;
							if (obj96 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7 (UnityEngine.Object)+38]");
							bool flag32 = (UnityEngine.Object)0 != null;
							bool flag33 = !flag32;
							obj88 = 0;
							obj90 = null;
							if (!flag33)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7 (UnityEngine.Object)+40]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X20_v7 (UnityEngine.Object)+40]");
									Transform transform10 = ((Component)0).transform;
									if ((object)transform10 != null)
									{
										Transform parent4 = transform10.parent;
										object obj97 = obj4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v112+E4]");
										bool flag34 = (nint)0 == 0;
										object obj98 = !flag34;
										if (obj98 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag35 = parent4 != null;
										bool flag36 = !flag35;
										object obj99 = !flag36;
										obj88 = 0;
										obj90 = null;
										obj87 = 0;
										obj84 = null;
										if (obj99 == null)
										{
											goto IL_07a5;
										}
										goto IL_137b;
									}
								}
								goto IL_12c8;
							}
						}
						goto IL_07a5;
					}
					goto IL_12c8;
					IL_07a5:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X0_v29+18]");
					obj86 = 0;
					obj89++;
					object obj100 = obj89;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X0_v29+18]");
					bool flag37 = (nint)obj100 < 0;
					obj87 = obj88;
					obj84 = obj90;
					if (flag37)
					{
						continue;
					}
					goto IL_07f7;
				}
				goto IL_12d6;
			}
		}
		goto IL_12c8;
		IL_12c8:
		NullReferenceException ex = new NullReferenceException();
		goto IL_12d6;
		IL_0362:
		obj15 = null;
		goto IL_131c;
		IL_12d6:
		return (GillaMenuStand)(object)new IndexOutOfRangeException();
	}

	private static void Part(Transform parent, string name, Vector3 at, Vector3 size, Material mat, Quaternion rot)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_00d5: Expected VT, but got I4
		//IL_00f5: Expected VT, but got I4
		//IL_0115: Expected VT, but got I4
		//IL_011f: Expected Obj, but got VT
		//IL_0155: Expected Obj, but got I
		//IL_0171: Expected Obj, but got VT
		GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7560]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		gameObject.name = name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj5 = default;
		UnityEngine.Object.Destroy(obj5);
		Transform transform = gameObject.transform;
		transform.SetParent(parent, worldPositionStays: false);
		Transform transform2 = gameObject.transform;
		transform2.localPosition = (Vector3)0;
		Transform transform3 = gameObject.transform;
		transform3.localRotation = (Quaternion)0;
		Transform transform4 = gameObject.transform;
		transform4.localScale = (Vector3)0;
		if ((UnityEngine.Object)at != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
			Renderer renderer = default;
			renderer.sharedMaterial = (Material)at;
		}
	}

	static GillaMenuStand()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj3 = 0;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F740]");
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

	internal static Material _003CMakeModerators_003Eg__MatOf_007C47_0(string part, ref GillaPurchases._003C_003Ec__DisplayClass47_0 P_1)
	{
		//IL_017a: Invalid comparison between VT and I4
		//IL_0015: Expected Obj, but got I
		//IL_0027: Expected Obj, but got VT
		//IL_0055: Expected Obj, but got I4
		//IL_01b8: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I
		if (P_1 != (GillaPurchases._003C_003Ec__DisplayClass47_0)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Transform transform = ((Transform)P_1).Find(part);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = transform != null;
			bool flag3 = !flag2;
			UnityEngine.Object obj4 = null;
			UnityEngine.Object obj5 = null;
			if (!flag3)
			{
				if ((object)transform == null)
				{
					goto IL_015e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4410]");
				object obj6 = 0;
				obj4 = (UnityEngine.Object)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
				UnityEngine.Object obj7 = default;
				obj5 = obj7;
			}
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(obj5 != null))
			{
				return null;
			}
			if ((object)obj5 != null)
			{
				return ((Renderer)obj5).sharedMaterial;
			}
		}
		goto IL_015e;
		IL_015e:
		return (Material)(object)new NullReferenceException();
	}
}
