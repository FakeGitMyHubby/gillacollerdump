using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

public class GillaQuestBoard : MonoBehaviour
{
	public Renderer screen;

	public PressKey[] claimKeys;

	public TextAsset titleFont;

	public TextAsset textFont;

	public AudioClip claimSound;

	public AudioClip nopeSound;

	public AudioClip levelUpSound;

	private const int W = default(int);

	private const int H = default(int);

	private static readonly int BaseMap;

	private Texture2D tex;

	private Color32[] px;

	private MaterialPropertyBlock block;

	private ScreenFont title;

	private ScreenFont text;

	private string shown;

	private float nextRefresh;

	private float levelUpUntil;

	private void OnEnable()
	{
		//IL_01cb: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_0203: Expected I, but got Obj
		//IL_0232: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I8
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got I4
		//IL_02cc: Expected Obj, but got I4
		//IL_0275: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I4
		//IL_0116: Expected I, but got Obj
		//IL_017f: Expected Obj, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_013c: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I4
		//IL_0170: Expected I, but got Obj
		PressKey[] array = claimKeys;
		if (array.Length >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A0]");
			object obj3 = 0;
			object obj4 = array.Length & 0xFFFFFFFFL;
			object obj5 = array + 32;
			object obj7 = default;
			object obj6 = obj7;
			object obj9 = default;
			object obj8 = obj9;
			nint num = default;
			IntPtr intPtr = num;
			object obj10 = 0;
			Action<System.__Canon> action = default;
			bool flag5;
			do
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
				object obj11 = !flag;
				if (obj11 == null)
				{
					object obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v17+E4]");
					bool flag2 = (nint)0 == 0;
					object obj13 = !flag2;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X27_v4+v81 @ X23_v7*8]");
					bool flag3 = (UnityEngine.Object)0 != null;
					bool flag4 = !flag3;
					obj9 = 0;
					num = unchecked((nint)null);
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						action._002Ector((object)this, (IntPtr)obj3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X27_v4+v81 @ X23_v7*8]");
						((PressKey)0).Pressed += (Action<PressKey>)action;
						obj6 = 0;
						obj9 = 0;
						num = (nint)action;
					}
					obj4 = array.Length;
					obj10++;
					flag5 = (nint)obj10 < array.Length;
					obj8 = obj9;
					intPtr = num;
					continue;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
			while (flag5);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6098]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action2 = default;
		action2._002Ector(this, (IntPtr)obj15);
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v7+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaQuests.Changed += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action3 = default;
		action3._002Ector(this, (IntPtr)obj15);
		GillaLevel.Changed += action3;
		Redraw(force: true);
	}

	private void OnDisable()
	{
		//IL_01cb: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_0203: Expected I, but got Obj
		//IL_0232: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I8
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got I4
		//IL_02c1: Expected Obj, but got I4
		//IL_0275: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I4
		//IL_0116: Expected I, but got Obj
		//IL_017f: Expected Obj, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_013c: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I4
		//IL_0170: Expected I, but got Obj
		PressKey[] array = claimKeys;
		if (array.Length >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A0]");
			object obj3 = 0;
			object obj4 = array.Length & 0xFFFFFFFFL;
			object obj5 = array + 32;
			object obj7 = default;
			object obj6 = obj7;
			object obj9 = default;
			object obj8 = obj9;
			nint num = default;
			IntPtr intPtr = num;
			object obj10 = 0;
			Action<System.__Canon> action = default;
			bool flag5;
			do
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
				object obj11 = !flag;
				if (obj11 == null)
				{
					object obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v16+E4]");
					bool flag2 = (nint)0 == 0;
					object obj13 = !flag2;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X27_v4+v81 @ X23_v7*8]");
					bool flag3 = (UnityEngine.Object)0 != null;
					bool flag4 = !flag3;
					obj9 = 0;
					num = unchecked((nint)null);
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						action._002Ector((object)this, (IntPtr)obj3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X27_v4+v81 @ X23_v7*8]");
						((PressKey)0).Pressed -= (Action<PressKey>)action;
						obj6 = 0;
						obj9 = 0;
						num = (nint)action;
					}
					obj4 = array.Length;
					obj10++;
					flag5 = (nint)obj10 < array.Length;
					obj8 = obj9;
					intPtr = num;
					continue;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
			while (flag5);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6098]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action2 = default;
		action2._002Ector(this, (IntPtr)obj15);
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v7+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaQuests.Changed -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action3 = default;
		action3._002Ector(this, (IntPtr)obj15);
		GillaLevel.Changed -= action3;
	}

	private void OnChanged()
	{
		Redraw(force: false);
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I4
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
		if (Application.isPlaying)
		{
			float time = Time.time;
			if (!(time < nextRefresh))
			{
				float time2 = Time.time;
				float num = time2 + 0.5f;
				nextRefresh = num;
				Redraw(force: false);
			}
		}
	}

	private void OnKey(PressKey key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0373: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I
		//IL_015a: Expected I4, but got I8
		//IL_0174: Expected Obj, but got I4
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got I4
		//IL_03ab: Expected Obj, but got I4
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_0108: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I4
		//IL_01fc: Expected Obj, but got I
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_02a7: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got I4
		//IL_0308: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6168]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj2 = 0;
		object obj3 = obj;
		int i = Array.IndexOf((System.__Canon[])(object)claimKeys, (System.__Canon)(object)key);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		int num = GillaQuests.Claim(i);
		object obj8;
		float volume = default;
		double num2 = default;
		if (num >= 1)
		{
			float time = Time.time;
			object obj7 = obj6;
			obj8 = this + 80;
			volume = time + 3f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v34+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = (UnityEngine.Object)obj8 != null;
			bool flag4 = !flag3;
			obj3 = 0;
			System.__Canon _Canon = null;
			num2 = 3.0;
			if (flag4)
			{
				goto IL_018a;
			}
			obj3 = 0;
			_Canon = null;
			num2 = 3.0;
		}
		else
		{
			int num3 = (int)(num & 0x80000000L);
			bool flag5 = num3 == 0;
			object obj10 = !flag5;
			System.__Canon _Canon = (System.__Canon)(object)key;
			if (obj10 == null)
			{
				goto IL_018a;
			}
			obj8 = this + 72;
			_Canon = (System.__Canon)(object)key;
		}
		goto IL_0381;
		IL_0381:
		object obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v8+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			AudioClip[] array = default;
			if (array != null)
			{
				object obj14 = array + 32;
				obj14 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if ((object)key != null)
				{
					Transform transform = key.transform;
					if ((object)transform != null)
					{
						Vector3 position = transform.position;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
						object obj15 = 0;
						object obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v26+E4]");
						bool flag7 = (nint)0 == 0;
						object obj17 = !flag7;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float pitchMax = default;
						Sfx.Play(array, (Vector3)0, volume, (float)num2, pitchMax);
						goto IL_030d;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			throw new IndexOutOfRangeException();
		}
		goto IL_030d;
		IL_030d:
		Redraw(force: false);
		return;
		IL_018a:
		obj8 = this + 64;
		goto IL_0381;
	}

	public void Refresh()
	{
		Redraw(force: true);
	}

	private unsafe void Redraw(bool force)
	{
		//IL_0010: Expected Obj, but got I
		//IL_27d6: Expected Obj, but got I
		//IL_27f8: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		//IL_00d0: Expected F4, but got I4
		//IL_2816: Expected Obj, but got I
		//IL_2826: Expected Obj, but got I
		//IL_2836: Expected Obj, but got I
		//IL_288a: Expected Obj, but got I4
		//IL_0237: Expected Obj, but got I
		//IL_0261: Expected Obj, but got I4
		//IL_28a8: Expected Obj, but got I
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_02fc: Expected Obj, but got I4
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_037a: Expected Obj, but got I4
		//IL_0390: Expected Obj, but got I
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_03d3: Expected Obj, but got I
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected Obj, but got Unknown
		//IL_0459: Expected Obj, but got I4
		//IL_046f: Expected Obj, but got I
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected Obj, but got Unknown
		//IL_04b2: Expected Obj, but got I
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Obj, but got Unknown
		//IL_0513: Expected Obj, but got I4
		//IL_0529: Expected Obj, but got I
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected Obj, but got Unknown
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected Obj, but got Unknown
		//IL_058c: Expected Obj, but got I
		//IL_059c: Expected Obj, but got I
		//IL_05be: Expected Obj, but got I4
		//IL_0604: Expected Obj, but got I4
		//IL_0614: Expected Obj, but got I4
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected Obj, but got Unknown
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected Obj, but got Unknown
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected Obj, but got Unknown
		//IL_06db: Expected Obj, but got I4
		//IL_06f1: Expected Obj, but got I
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected Obj, but got Unknown
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected Obj, but got Unknown
		//IL_0766: Expected Obj, but got I
		//IL_0780: Expected Obj, but got I4
		//IL_0785: Expected I, but got Obj
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_0867: Expected Obj, but got Unknown
		//IL_0889: Expected Obj, but got I
		//IL_088f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0894: Expected Obj, but got Unknown
		//IL_08be: Expected Obj, but got I4
		//IL_0901: Expected Obj, but got I4
		//IL_07ba: Expected I, but got Obj
		//IL_0a4e: Expected Obj, but got I4
		//IL_0924: Expected Obj, but got I
		//IL_07d8: Expected Obj, but got I
		//IL_0802: Expected Obj, but got I4
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Expected Obj, but got Unknown
		//IL_0ac4: Expected Obj, but got I4
		//IL_0849: Expected Obj, but got I4
		//IL_084e: Expected I, but got Obj
		//IL_0c0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c14: Expected Obj, but got Unknown
		//IL_0c2e: Expected Obj, but got I4
		//IL_0d8b: Expected Obj, but got I4
		//IL_0af4: Expected Obj, but got I
		//IL_0b1e: Expected Obj, but got I4
		//IL_28ea: Expected Obj, but got I
		//IL_28f8: Expected Obj, but got Ref
		//IL_2923: Expected VT, but got Ref
		//IL_2933: Expected Obj, but got I
		//IL_0c4c: Expected Obj, but got I
		//IL_0c76: Expected Obj, but got I4
		//IL_09ac: Expected Obj, but got I
		//IL_0bf2: Expected Obj, but got I4
		//IL_09e2: Expected Obj, but got I
		//IL_0d4a: Expected Obj, but got I4
		//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fc: Expected Obj, but got Unknown
		//IL_0a17: Expected Obj, but got I4
		//IL_0dd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddb: Expected Obj, but got Unknown
		//IL_0e17: Expected Obj, but got I4
		//IL_0e51: Expected Obj, but got I
		//IL_0bb8: Expected Obj, but got I
		//IL_0e70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e75: Expected Obj, but got Unknown
		//IL_0ea9: Expected Obj, but got I4
		//IL_0ebf: Expected Obj, but got I
		//IL_0edf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee4: Expected Obj, but got Unknown
		//IL_0d10: Expected Obj, but got I
		//IL_0be5: Expected I4, but got Obj
		//IL_0d3d: Expected I4, but got Obj
		//IL_0f02: Expected Obj, but got I
		//IL_0f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f10: Expected Obj, but got Unknown
		//IL_0f44: Expected Obj, but got I
		//IL_0f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f68: Expected Obj, but got Unknown
		//IL_0f9c: Expected Obj, but got I4
		//IL_0fb2: Expected Obj, but got I
		//IL_0fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd7: Expected Obj, but got Unknown
		//IL_0ff5: Expected Obj, but got I
		//IL_0ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1003: Expected Obj, but got Unknown
		//IL_1037: Expected Obj, but got I
		//IL_106a: Expected Obj, but got I4
		//IL_1080: Expected Obj, but got I
		//IL_10a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a5: Expected Obj, but got Unknown
		//IL_10bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c1: Expected Obj, but got Unknown
		//IL_10f5: Expected Obj, but got I
		//IL_111f: Expected Obj, but got I4
		//IL_1162: Expected Obj, but got I
		//IL_117a: Expected Obj, but got I
		//IL_1188: Expected Obj, but got Ref
		//IL_11c5: Expected VT, but got Ref
		//IL_11fc: Expected I, but got Obj
		//IL_1230: Expected Obj, but got I
		//IL_1261: Expected Obj, but got I4
		//IL_2cdd: Expected Obj, but got I
		//IL_2cff: Expected Obj, but got I4
		//IL_12ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bf: Expected I4, but got Unknown
		//IL_12f6: Expected Obj, but got I4
		//IL_2952: Expected Obj, but got I
		//IL_2988: Expected VT, but got I
		//IL_2998: Expected Obj, but got I
		//IL_29c2: Expected Obj, but got I4
		//IL_1360: Expected Obj, but got I4
		//IL_1385: Unknown result type (might be due to invalid IL or missing references)
		//IL_138a: Expected I4, but got Unknown
		//IL_13bf: Expected Obj, but got I4
		//IL_1459: Expected Obj, but got I4
		//IL_2a18: Expected Obj, but got I
		//IL_1412: Expected Obj, but got I4
		//IL_2e51: Expected VT, but got Ref
		//IL_2a03: Expected Obj, but got I
		//IL_149b: Expected Obj, but got I
		//IL_14ab: Expected Obj, but got I
		//IL_14d5: Expected Obj, but got I
		//IL_1563: Expected Obj, but got I4
		//IL_2a4e: Expected Obj, but got I
		//IL_151c: Expected Obj, but got I4
		//IL_2ea5: Expected VT, but got Ref
		//IL_2eb5: Expected Obj, but got I
		//IL_2edf: Expected Obj, but got I4
		//IL_2a33: Expected Obj, but got I
		//IL_15d1: Expected Obj, but got I
		//IL_15e1: Expected Obj, but got I
		//IL_1606: Expected Obj, but got I
		//IL_16a4: Expected Obj, but got I4
		//IL_2a84: Expected Obj, but got I
		//IL_164d: Expected Obj, but got I4
		//IL_2f26: Expected VT, but got Ref
		//IL_16cc: Expected Obj, but got I
		//IL_2a69: Expected Obj, but got I
		//IL_1750: Expected Obj, but got I
		//IL_1774: Expected VT, but got Ref
		//IL_1795: Expected Obj, but got I4
		//IL_1675: Expected Obj, but got I
		//IL_16e9: Expected Obj, but got I
		//IL_171b: Expected Obj, but got I4
		//IL_17be: Expected Obj, but got I4
		//IL_2a99: Expected Obj, but got I
		//IL_2ab3: Expected Obj, but got I
		//IL_2ac4: Expected Obj, but got I4
		//IL_2acc: Expected VT, but got Ref
		//IL_2adc: Expected Obj, but got I
		//IL_2ae5: Expected Obj, but got I4
		//IL_1c1f: Expected Obj, but got I
		//IL_1917: Expected Obj, but got I
		//IL_18bd: Expected Obj, but got I4
		//IL_2b41: Expected Obj, but got I
		//IL_2b5b: Expected Obj, but got I
		//IL_2b6c: Expected Obj, but got I4
		//IL_2b74: Expected VT, but got Ref
		//IL_2b85: Expected Obj, but got I4
		//IL_17dc: Expected Obj, but got I
		//IL_1806: Expected Obj, but got I4
		//IL_1ce0: Expected Obj, but got I4
		//IL_1846: Expected Obj, but got I4
		//IL_1857: Expected VT, but got Ref
		//IL_1878: Expected Obj, but got I4
		//IL_2bc0: Expected Obj, but got I
		//IL_1c99: Expected Obj, but got I4
		//IL_195e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1963: Expected Obj, but got Unknown
		//IL_2f65: Expected Obj, but got I4
		//IL_2ba5: Expected Obj, but got I
		//IL_198a: Expected Obj, but got I
		//IL_1993: Unknown result type (might be due to invalid IL or missing references)
		//IL_1998: Expected Obj, but got Unknown
		//IL_19c1: Expected Obj, but got I
		//IL_1d51: Expected VT, but got Obj
		//IL_1d61: Expected Obj, but got I
		//IL_1d79: Expected Obj, but got I
		//IL_19f9: Expected Obj, but got I4
		//IL_1a0f: Expected Obj, but got I
		//IL_1a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a34: Expected Obj, but got Unknown
		//IL_2be4: Expected Obj, but got I
		//IL_2bef: Expected Obj, but got I4
		//IL_1a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a50: Expected Obj, but got Unknown
		//IL_1a77: Expected Obj, but got I
		//IL_1a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a85: Expected Obj, but got Unknown
		//IL_2c17: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c1c: Expected Obj, but got Unknown
		//IL_2c2c: Expected Obj, but got I
		//IL_2c37: Expected Obj, but got I4
		//IL_1acb: Expected Obj, but got I4
		//IL_1ae1: Expected Obj, but got I
		//IL_1b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b06: Expected Obj, but got Unknown
		//IL_1dd3: Expected Obj, but got Ref
		//IL_2c59: Expected Obj, but got I4
		//IL_1b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b22: Expected Obj, but got Unknown
		//IL_1b56: Expected Obj, but got I4
		//IL_1b6c: Expected Obj, but got I
		//IL_1b8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b91: Expected Obj, but got Unknown
		//IL_1baf: Expected Obj, but got I
		//IL_1bb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bbd: Expected Obj, but got Unknown
		//IL_1e6b: Expected Obj, but got I4
		//IL_2cc0: Expected Obj, but got I
		//IL_1e14: Expected Obj, but got I4
		//IL_2fb6: Expected VT, but got Ref
		//IL_2ff5: Expected Obj, but got I4
		//IL_2ffe: Expected Obj, but got I4
		//IL_3007: Expected Obj, but got I4
		//IL_3020: Expected I4, but got Obj
		//IL_3031: Expected Obj, but got I4
		//IL_3042: Expected I4, but got Obj
		//IL_1e93: Expected Obj, but got I
		//IL_2ca3: Expected Obj, but got I
		//IL_1e3c: Expected Obj, but got I
		//IL_1eb0: Expected Obj, but got I
		//IL_1eda: Expected Obj, but got I4
		//IL_1f42: Expected Obj, but got I4
		//IL_1fc9: Expected Obj, but got I
		//IL_2000: Expected Obj, but got I
		//IL_2009: Unknown result type (might be due to invalid IL or missing references)
		//IL_200e: Expected Obj, but got Unknown
		//IL_1f8a: Expected Obj, but got I
		//IL_2d37: Expected Obj, but got I4
		//IL_2049: Unknown result type (might be due to invalid IL or missing references)
		//IL_204e: Expected Obj, but got Unknown
		//IL_2082: Expected Obj, but got I4
		//IL_2098: Expected Obj, but got I
		//IL_20b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_20bd: Expected Obj, but got Unknown
		//IL_3068: Expected Obj, but got I
		//IL_3096: Expected VT, but got Ref
		//IL_30ae: Expected Obj, but got I
		//IL_30e6: Expected VT, but got I
		//IL_2362: Expected Obj, but got I4
		//IL_2396: Unknown result type (might be due to invalid IL or missing references)
		//IL_239b: Expected I4, but got Unknown
		//IL_23d0: Expected Obj, but got I4
		//IL_23d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_23dd: Expected Obj, but got Unknown
		//IL_20db: Expected Obj, but got I
		//IL_20e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e9: Expected Obj, but got Unknown
		//IL_2116: Unknown result type (might be due to invalid IL or missing references)
		//IL_211b: Expected Obj, but got Unknown
		//IL_214f: Expected Obj, but got I4
		//IL_2165: Expected Obj, but got I
		//IL_2185: Unknown result type (might be due to invalid IL or missing references)
		//IL_218a: Expected Obj, but got Unknown
		//IL_2d53: Expected Obj, but got I4
		//IL_2d5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d60: Expected I4, but got Unknown
		//IL_30fb: Expected Obj, but got I
		//IL_3125: Expected Obj, but got I4
		//IL_21a8: Expected Obj, but got I
		//IL_21b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b6: Expected Obj, but got Unknown
		//IL_21fc: Expected Obj, but got I4
		//IL_2212: Expected Obj, but got I
		//IL_2232: Unknown result type (might be due to invalid IL or missing references)
		//IL_2237: Expected Obj, but got Unknown
		//IL_2493: Invalid comparison between I4 and F8
		//IL_2455: Invalid comparison between I4 and F8
		//IL_224e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2253: Expected Obj, but got Unknown
		//IL_2287: Expected Obj, but got I4
		//IL_229d: Expected Obj, but got I
		//IL_22bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c2: Expected Obj, but got Unknown
		//IL_2dc7: Expected Obj, but got I
		//IL_2def: Expected VT, but got I
		//IL_2def: Expected I4, but got F8
		//IL_2d7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d82: Expected Obj, but got Unknown
		//IL_2d9c: Expected Obj, but got I4
		//IL_22e0: Expected Obj, but got I
		//IL_22e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ee: Expected Obj, but got Unknown
		//IL_2322: Expected Obj, but got I
		//IL_2592: Expected Obj, but got I
		//IL_25bc: Expected Obj, but got I4
		//IL_2606: Expected Obj, but got I4
		//IL_261d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2622: Expected Obj, but got Unknown
		//IL_263c: Expected Obj, but got I4
		//IL_265a: Expected Obj, but got I
		//IL_26cd: Expected Obj, but got I
		//IL_26f7: Expected Obj, but got I4
		//IL_2741: Expected Obj, but got I
		//IL_2759: Expected Obj, but got I
		//IL_276f: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan untilNew = GillaQuests.UntilNew;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj7 = 0;
		if (Application.isPlaying)
		{
			float time = Time.time;
			float num = time + time;
		}
		else
		{
			float num = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60D0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6108]");
		object line = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6100]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		char c = '\0';
		int num2 = 0;
		string[] array = default;
		object obj17 = default;
		TimeSpan timeSpan = default;
		int num3 = default;
		bool flag14 = default;
		bool flag17 = default;
		Texture2D texture2D = default;
		UnityEngine.Object obj70 = default;
		ScreenFont screenFont = default;
		ScreenFont screenFont2 = default;
		object obj89 = default;
		object obj90 = default;
		string[] array2 = default;
		object obj124 = default;
		object obj144 = default;
		object obj152 = default;
		object obj165 = default;
		string[] array3 = default;
		int num30 = default;
		object obj232 = default;
		string[] array4 = default;
		int num33 = default;
		int num34 = default;
		object obj269 = default;
		double num40 = default;
		MaterialPropertyBlock materialPropertyBlock = default;
		while (true)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaRecycler.Quest quest = GillaQuests.QuestAt(num2);
			if (quest != null && stringBuilder != null)
			{
				StringBuilder stringBuilder2 = stringBuilder.Append(quest.text);
				int value = GillaQuests.ProgressAt(num2);
				if (stringBuilder2 != null)
				{
					StringBuilder stringBuilder3 = stringBuilder2.Append(value);
					bool value2 = GillaQuests.ClaimedAt(num2);
					if (stringBuilder3 != null)
					{
						StringBuilder stringBuilder4 = stringBuilder3.Append(value2);
						if (stringBuilder4 != null)
						{
							StringBuilder stringBuilder5 = stringBuilder4.Append('|');
							num2++;
							bool flag4 = num2 != 3;
							c = '|';
							if (flag4)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
							object obj12 = 0;
							object obj13 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1186 @ X0_v31+E4]");
							bool flag5 = (nint)0 == 0;
							object obj14 = !flag5;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (Application.isPlaying)
							{
								float num = Time.time;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
							object obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
							if (array != null)
							{
								object obj16 = array + 32;
								obj16 = obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj18 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1242 @ X0_v43+E4]");
								bool flag6 = (nint)0 == 0;
								object obj19 = !flag6;
								if (obj19 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								int hours = timeSpan.Hours;
								string text = num3.ToString();
								object obj20 = array + 40;
								obj20 = text;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X22_v5-10]");
								bool flag7 = (nint)0 < (nint)2;
								object obj21 = !flag7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X22_v5-10]");
								object obj22 = -2;
								bool flag8 = obj22 == null;
								object obj23 = ~obj21;
								object obj24 = obj23 | flag8;
								if (obj24 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
								object obj25 = 0;
								object obj26 = array + 48;
								obj26 = obj25;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								int minutes = timeSpan.Minutes;
								string text2 = num3.ToString();
								object obj27 = array + 56;
								obj27 = text2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v871 @ X22_v9-20]");
								bool flag9 = (nint)0 < (nint)4;
								object obj28 = !flag9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v871 @ X22_v9-20]");
								object obj29 = -4;
								bool flag10 = obj29 == null;
								object obj30 = ~obj28;
								object obj31 = obj30 | flag10;
								if (obj31 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
								object obj32 = 0;
								object obj33 = array + 64;
								obj33 = obj32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								int seconds = timeSpan.Seconds;
								string text3 = num3.ToString();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X22_v11-28]");
								bool flag11 = (nint)0 < (nint)5;
								object obj34 = !flag11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X22_v11-28]");
								object obj35 = -5;
								bool flag12 = obj35 == null;
								object obj36 = ~obj34;
								object obj37 = obj36 | flag12;
								if (obj37 != null)
								{
									break;
								}
								object obj38 = array + 72;
								obj38 = text3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
								object obj39 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1287 @ X8_v27+30]");
								object obj40 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1288 @ X0_v68+E4]");
								bool flag13 = (nint)0 == 0;
								object obj41 = !flag13;
								if (obj41 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								string text4 = flag14.ToString();
								bool flag15 = array.Length < 6;
								object obj42 = !flag15;
								object obj43 = array.Length - 6;
								bool flag16 = obj43 == null;
								object obj44 = ~obj42;
								object obj45 = obj44 | flag16;
								if (obj45 != null)
								{
									break;
								}
								object obj46 = array + 80;
								obj46 = text4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								int xp = GillaLevel.Xp;
								string text5 = num3.ToString();
								object obj47 = array + 88;
								obj47 = text5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								string text6 = flag17.ToString();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X22_v15-40]");
								bool flag18 = (nint)0 < (nint)8;
								object obj48 = !flag18;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X22_v15-40]");
								object obj49 = -8;
								bool flag19 = obj49 == null;
								object obj50 = ~obj48;
								object obj51 = obj50 | flag19;
								if (obj51 != null)
								{
									break;
								}
								object obj52 = array + 96;
								obj52 = text6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								string text7 = string.Concat(array);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
								object obj53 = 0;
								bool flag20 = !force;
								object obj54 = !flag20;
								nint num4 = unchecked((nint)null);
								if (obj54 == null)
								{
									bool flag21 = text7 == shown;
									bool flag22 = !flag21;
									num4 = unchecked((nint)null);
									if (!flag22)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
										object obj55 = 0;
										object obj56 = obj55;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1354 @ X0_v411+E4]");
										bool flag23 = (nint)0 == 0;
										object obj57 = !flag23;
										if (obj57 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag24 = tex != null;
										bool flag25 = !flag24;
										object obj58 = !flag25;
										num4 = unchecked((nint)null);
										if (obj58 != null)
										{
											return;
										}
									}
								}
								object obj59 = this + 128;
								obj59 = text7;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
								object obj60 = 0;
								object obj61 = this + 88;
								object obj62 = obj60;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1348 @ X0_v92+E4]");
								bool flag26 = (nint)0 == 0;
								object obj63 = !flag26;
								if (obj63 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag27 = (UnityEngine.Object)obj61 == null;
								bool flag28 = !flag27;
								object obj64 = 0;
								UnityEngine.Object obj65 = null;
								if (!flag28)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
									object obj66 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									texture2D._002Ector(320, 240, (TextureFormat)4, mipChain: true);
									if ((object)texture2D == null)
									{
										goto IL_27a9;
									}
									texture2D.filterMode = (FilterMode)0;
									texture2D.wrapMode = (TextureWrapMode)1;
									texture2D.hideFlags = (HideFlags)52;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60F8]");
									object obj67 = 0;
									texture2D.name = (string)obj67;
									tex = texture2D;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
									object obj68 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									object obj69 = this + 96;
									obj69 = obj70;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									obj64 = 0;
									obj65 = obj70;
								}
								object obj71 = obj53;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1383 @ X0_v97+E4]");
								bool flag29 = (nint)0 == 0;
								object obj72 = !flag29;
								if (obj72 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								GillaBoardLook.Clear(px, 320, 240);
								GillaBoardLook.Frame(px, 320, 240, 3);
								object obj73 = this + 112;
								bool flag30 = obj73 == null;
								object obj74 = !flag30;
								int num5 = 240;
								int num6 = 320;
								if (obj74 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
									object obj75 = 0;
									object obj76 = obj75;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ X0_v382+E4]");
									bool flag31 = (nint)0 == 0;
									object obj77 = !flag31;
									if (obj77 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag32 = titleFont != null;
									bool flag33 = !flag32;
									num5 = 0;
									int num7 = 0;
									if (!flag33)
									{
										if ((object)titleFont == null)
										{
											goto IL_27a9;
										}
										string baked = titleFont.text;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
										object obj78 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										screenFont._002Ector(baked);
										num5 = 0;
										num7 = (int)screenFont;
									}
									obj73 = num7;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									num6 = num7;
								}
								object obj79 = this + 120;
								bool flag34 = obj79 == null;
								object obj80 = !flag34;
								if (obj80 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
									object obj81 = 0;
									object obj82 = obj81;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1460 @ X0_v370+E4]");
									bool flag35 = (nint)0 == 0;
									object obj83 = !flag35;
									if (obj83 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag36 = textFont != null;
									bool flag37 = !flag36;
									num5 = 0;
									int num8 = 0;
									if (!flag37)
									{
										if ((object)textFont == null)
										{
											goto IL_27a9;
										}
										string baked2 = textFont.text;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
										object obj84 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										screenFont2._002Ector(baked2);
										num5 = 0;
										num8 = (int)screenFont2;
									}
									obj79 = num8;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									num6 = num8;
								}
								object obj85 = obj53;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X0_v104+E4]");
								bool flag38 = (nint)0 == 0;
								object obj86 = !flag38;
								if (obj86 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj85 = obj53;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X0_v104+A0]");
								object obj87 = 0;
								object obj88 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj89, 16));
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Line((ScreenFont)obj73, 12, 9, (string)line, (ShiftAuth.Style)(&obj90), centred: false);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
								object obj91 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								if (array2 != null)
								{
									object obj92 = array2 + 32;
									obj92 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj93 = obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1551 @ X0_v113+E4]");
									bool flag39 = (nint)0 == 0;
									object obj94 = !flag39;
									if (obj94 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									int hours2 = timeSpan.Hours;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6160]");
									object obj95 = 0;
									string text8 = num3.ToString((string)obj95);
									object obj96 = array2 + 40;
									obj96 = text8;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ X20_v14-10]");
									bool flag40 = (nint)0 < (nint)2;
									object obj97 = !flag40;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ X20_v14-10]");
									object obj98 = -2;
									bool flag41 = obj98 == null;
									object obj99 = ~obj97;
									object obj100 = obj99 | flag41;
									if (obj100 != null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
									object obj101 = 0;
									object obj102 = array2 + 48;
									obj102 = obj101;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									int minutes2 = timeSpan.Minutes;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6160]");
									object obj103 = 0;
									string text9 = num3.ToString((string)obj103);
									object obj104 = array2 + 56;
									obj104 = text9;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X20_v18-20]");
									bool flag42 = (nint)0 < (nint)4;
									object obj105 = !flag42;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X20_v18-20]");
									object obj106 = -4;
									bool flag43 = obj106 == null;
									object obj107 = ~obj105;
									object obj108 = obj107 | flag43;
									if (obj108 != null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
									object obj109 = 0;
									object obj110 = array2 + 64;
									obj110 = obj109;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									int seconds2 = timeSpan.Seconds;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6160]");
									object obj111 = 0;
									string text10 = num3.ToString((string)obj111);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X20_v20-28]");
									bool flag44 = (nint)0 < (nint)5;
									object obj112 = !flag44;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X20_v20-28]");
									object obj113 = -5;
									bool flag45 = obj113 == null;
									object obj114 = ~obj112;
									object obj115 = obj114 | flag45;
									if (obj115 != null)
									{
										break;
									}
									object obj116 = array2 + 72;
									obj116 = text10;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									string text11 = string.Concat(array2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B8]");
									object obj117 = 0;
									object obj118 = obj117;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1608 @ X8_v67+E4]");
									bool flag46 = (nint)0 == 0;
									object obj119 = !flag46;
									if (obj119 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									int num9 = Measure((ScreenFont)obj79, text11, 1);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
									object obj120 = 0;
									object obj121 = obj120;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1626 @ X8_v70+A0]");
									object obj122 = 0;
									object obj123 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj89, 16));
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									int x = 308 - num9;
									Line((ScreenFont)obj79, x, 15, text11, (ShiftAuth.Style)(&obj124), centred: false);
									GillaBoardLook.Rule(px, 320, 240, 10, 309, 30);
									nint num10 = (nint)typeof(_0021_00210);
									bool flag47 = false;
									int num11 = 30;
									int num12 = 309;
									int num13 = 10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1629 @ X8_v71+10]");
									object obj125 = 0;
									int num14 = 0;
									int num15 = 240;
									int num16 = 320;
									object obj126 = obj89;
									GillaQuestBoard gillaQuestBoard = this;
									object obj127 = 0;
									while (true)
									{
										object obj128 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
										object obj129 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1679 @ X0_v148+E4]");
										bool flag48 = (nint)0 == 0;
										object obj130 = !flag48;
										if (obj130 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										GillaRecycler.Quest quest2 = GillaQuests.QuestAt(num14);
										int num17 = GillaQuests.ProgressAt(num14);
										if (quest2 == null)
										{
											break;
										}
										int num18 = quest2 + 20;
										bool flag49 = GillaQuests.ClaimedAt(num14);
										object obj131 = obj129;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1699 @ X8_v79+E4]");
										bool flag50 = (nint)0 == 0;
										object obj132 = !flag50;
										if (obj132 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj131 = obj129;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1699 @ X8_v79+A0]");
										object obj133 = 0;
										int y = (int)(num10 - 31);
										GillaQuestBoard gillaQuestBoard2 = gillaQuestBoard;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1701 @ X8_v80+18]");
										gillaQuestBoard2.Fill(10, y, 300, 48, (Color32)0);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B8]");
										object obj134 = 0;
										object obj135 = obj134;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1712 @ X0_v158+E4]");
										bool flag51 = (nint)0 == 0;
										object obj136 = !flag51;
										if (obj136 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										int num19 = Measure(gillaQuestBoard.title, quest2.text, 1);
										object obj137 = obj129;
										object obj138 = num19 - 223;
										bool flag52 = (nint)obj138 < 0;
										int num20 = num19 ^ 0xDF;
										int num21 = num19 ^ obj138;
										int num22 = num20 & num21;
										bool flag53 = num22 < 0;
										bool flag54 = flag52 == flag53;
										object obj139 = !flag54;
										object obj140 = ~obj139;
										object font = ((obj140 != null) ? obj79 : obj73);
										if (flag49)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1760 @ X0_v355+E4]");
											bool flag55 = (nint)0 == 0;
											object obj141 = !flag55;
											if (obj141 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj137 = obj129;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1760 @ X0_v355+A0]");
											object obj142 = (nint)0 + (nint)16;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1760 @ X0_v355+E4]");
											bool flag56 = (nint)0 == 0;
											object obj143 = !flag56;
											if (obj143 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj137 = obj129;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1760 @ X0_v355+A0]");
											object obj142 = 0;
										}
										int y2 = (int)(num10 - 25);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										gillaQuestBoard.Line((ScreenFont)font, 16, y2, quest2.text, (ShiftAuth.Style)(&obj144), centred: false);
										int num23 = GillaLevel.ForYou(quest2.xp);
										string text12 = num3.ToString();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60E0]");
										object obj145 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6158]");
										object obj146 = 0;
										string text13 = (string)obj145 + text12 + (string)obj146;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
										object obj147 = 0;
										object obj148 = obj147;
										if (flag49)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1820 @ X0_v349+E4]");
											bool flag57 = (nint)0 == 0;
											object obj149 = !flag57;
											if (obj149 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj148 = obj147;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1820 @ X0_v349+A0]");
											object obj150 = (nint)0 + (nint)16;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1820 @ X0_v349+E4]");
											bool flag58 = (nint)0 == 0;
											object obj151 = !flag58;
											if (obj151 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj148 = obj147;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1820 @ X0_v349+A0]");
											object obj150 = (nint)0 + (nint)8;
										}
										int num24 = (int)(num10 - 12);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Line(gillaQuestBoard.text, 16, num24, text13, (ShiftAuth.Style)(&obj152), centred: false);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B8]");
										object obj153 = 0;
										object obj154 = obj153;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1845 @ X0_v178+E4]");
										bool flag59 = (nint)0 == 0;
										object obj155 = !flag59;
										if (obj155 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										int num25 = Measure(this.text, text13, 1);
										string text14 = num3.ToString();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60E0]");
										object obj156 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6150]");
										object obj157 = 0;
										string text15 = (string)obj156 + text14 + (string)obj157;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
										object obj158 = 0;
										object obj159 = obj158;
										object obj162;
										if (flag49)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1894 @ X0_v342+E4]");
											bool flag60 = (nint)0 == 0;
											object obj160 = !flag60;
											if (obj160 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
												object obj161 = 0;
												obj159 = obj161;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1894 @ X0_v342+A0]");
											obj162 = (nint)0 + (nint)16;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1894 @ X0_v342+E4]");
											bool flag61 = (nint)0 == 0;
											object obj163 = !flag61;
											if (obj163 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
												object obj164 = 0;
												obj159 = obj164;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1894 @ X0_v342+A0]");
											obj162 = (nint)0 + (nint)48;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										int x2 = num25 + 16;
										Line(this.text, x2, num24, text15, (ShiftAuth.Style)(&obj165), centred: false);
										object obj166;
										ScreenFont font2;
										ShiftAuth.Style style;
										string line2;
										bool flag64;
										int num26;
										if (flag49)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
											obj166 = 0;
											object obj167 = obj166;
											font2 = (ScreenFont)obj79;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1949 @ X0_v337+E4]");
											bool flag62 = (nint)0 == 0;
											object obj168 = !flag62;
											if (obj168 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj167 = obj166;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1949 @ X0_v337+A0]");
											object obj169 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60F0]");
											object obj170 = 0;
											line2 = (string)obj170;
											object obj171 = 1;
											style = (ShiftAuth.Style)(&obj171);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1951 @ X8_v225+10]");
											object obj172 = 0;
											object obj173 = 1;
											gillaQuestBoard = this;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
											obj166 = 0;
											bool flag63 = num17 < ((int*)num18)->m_value;
											flag64 = false;
											style = (ShiftAuth.Style)(&obj165);
											line2 = text15;
											num26 = num24;
											object obj172 = obj162;
											object obj173 = 1;
											gillaQuestBoard = this;
											if (flag63)
											{
												goto IL_18e2;
											}
											bool flag65 = !flag14;
											object obj174 = !flag65;
											if (obj174 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
												object obj175 = 0;
												object obj176 = obj175;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2020 @ X0_v331+E4]");
												bool flag66 = (nint)0 == 0;
												object obj177 = !flag66;
												if (obj177 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												bool isPlaying = Application.isPlaying;
												bool flag67 = !isPlaying;
												object obj178 = !flag67;
												flag64 = false;
												style = (ShiftAuth.Style)(&obj165);
												line2 = text15;
												num26 = num24;
												obj172 = obj162;
												obj173 = 1;
												gillaQuestBoard = this;
												if (obj178 != null)
												{
													goto IL_18e2;
												}
											}
											object obj179 = obj166;
											font2 = (ScreenFont)obj79;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2062 @ X0_v326+E4]");
											bool flag68 = (nint)0 == 0;
											object obj180 = !flag68;
											if (obj180 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj179 = obj166;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2062 @ X0_v326+A0]");
											object obj181 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6118]");
											object obj182 = 0;
											line2 = (string)obj182;
											object obj183 = 1;
											style = (ShiftAuth.Style)(&obj183);
											obj172 = obj181;
											obj173 = 1;
											gillaQuestBoard = this;
										}
										gillaQuestBoard.Line(font2, 16, (int)num10, line2, style, centred: false);
										flag64 = false;
										num26 = (int)num10;
										x2 = 16;
										goto IL_18e2;
										IL_2d65:
										double num28;
										double num29;
										double num27 = num28 + num29;
										object obj184 = num28 & 1;
										bool flag69 = obj184 == null;
										object obj185 = !flag69;
										if (obj185 != null)
										{
											num28 = num27;
										}
										goto IL_2daf;
										IL_18e2:
										string text19;
										if (quest2.stat == (GillaQuests.Stat)6)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
											object obj186 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
											string text16 = num3.ToString();
											if (array3 == null)
											{
												break;
											}
											object obj187 = array3 + 32;
											obj187 = text16;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
											object obj188 = 0;
											object obj189 = array3 + 40;
											obj189 = obj188;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6160]");
											object obj190 = 0;
											string text17 = num3.ToString((string)obj190);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X20_v57-10]");
											bool flag70 = (nint)0 < (nint)2;
											object obj191 = !flag70;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X20_v57-10]");
											object obj192 = -2;
											bool flag71 = obj192 == null;
											object obj193 = ~obj191;
											object obj194 = obj193 | flag71;
											if (obj194 != null)
											{
												goto end_IL_2860;
											}
											object obj195 = array3 + 48;
											obj195 = text17;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B18]");
											object obj196 = 0;
											object obj197 = array3 + 56;
											obj197 = obj196;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											string text18 = num3.ToString();
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X20_v61-20]");
											bool flag72 = (nint)0 < (nint)4;
											object obj198 = !flag72;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X20_v61-20]");
											object obj199 = -4;
											bool flag73 = obj199 == null;
											object obj200 = ~obj198;
											object obj201 = obj200 | flag73;
											if (obj201 != null)
											{
												goto end_IL_2860;
											}
											object obj202 = array3 + 64;
											obj202 = text18;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X20_v63-28]");
											bool flag74 = (nint)0 < (nint)5;
											object obj203 = !flag74;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X20_v63-28]");
											object obj204 = -5;
											bool flag75 = obj204 == null;
											object obj205 = ~obj203;
											object obj206 = obj205 | flag75;
											if (obj206 != null)
											{
												goto end_IL_2860;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6130]");
											object obj207 = 0;
											object obj208 = array3 + 72;
											obj208 = obj207;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											text19 = string.Concat(array3);
											string text20 = null;
											string text21 = null;
										}
										else
										{
											string text22 = num30.ToString();
											string text23 = ((int*)num18)->ToString();
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6128]");
											object obj209 = 0;
											string text21 = (string)obj209;
											text19 = text22 + (string)obj209 + text23;
											num26 = 0;
											string text20 = text23;
										}
										object obj210 = obj166;
										object obj212;
										if (flag49)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X0_v196+E4]");
											bool flag76 = (nint)0 == 0;
											object obj211 = !flag76;
											if (obj211 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj210 = obj166;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X0_v196+A0]");
											obj212 = (nint)0 + (nint)40;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X0_v196+E4]");
											bool flag77 = (nint)0 == 0;
											object obj213 = !flag77;
											if (obj213 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj210 = obj166;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X0_v196+A0]");
											obj212 = (nint)0 + (nint)44;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ X0_v196+E4]");
										bool flag78 = (nint)0 == 0;
										object obj214 = !flag78;
										if (obj214 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										int y3 = (int)(num10 - 23);
										GillaBoardLook.Box(gillaQuestBoard.px, 320, 240, 240, y3, 64, 24, (Color32)obj212);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60E8]");
										object obj215 = 0;
										string text24 = (string)obj215;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6110]");
										object obj216 = 0;
										if (num17 < ((int*)num18)->m_value)
										{
											text24 = text19;
										}
										bool flag79 = !flag49;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
										object obj217 = 0;
										object obj218 = !flag79;
										object obj219 = ~obj218;
										string text25 = (string)((obj219 != null) ? text24 : obj216);
										object obj220 = obj217;
										object obj221 = obj127 + 16;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
										obj = 0;
										object obj222 = !flag79;
										object obj223 = ~obj222;
										if (obj223 != null)
										{
											obj127 = (object)(&obj89);
										}
										object obj224 = !flag79;
										object obj225 = ~obj224;
										object obj226;
										if (obj225 == null)
										{
											obj226 = obj221;
										}
										else
										{
											obj226 = obj123;
										}
										object obj229;
										if (flag49)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2258 @ X0_v282+E4]");
											bool flag80 = (nint)0 == 0;
											object obj227 = !flag80;
											if (obj227 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
												object obj228 = 0;
												obj220 = obj228;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2258 @ X0_v282+A0]");
											obj229 = (nint)0 + (nint)16;
											obj226 = obj88;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2258 @ X0_v282+E4]");
											bool flag81 = (nint)0 == 0;
											object obj230 = !flag81;
											if (obj230 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
												object obj231 = 0;
												obj220 = obj231;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2258 @ X0_v282+A0]");
											obj229 = 0;
										}
										int num31 = (int)(num10 - 15);
										obj226 = obj229;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										gillaQuestBoard.Line((ScreenFont)obj79, 272, num31, text25, (ShiftAuth.Style)(&obj232), centred: true);
										num14++;
										num10 += 58;
										bool flag82 = num14 != 3;
										obj232 = obj89;
										obj165 = 1;
										obj152 = 1;
										obj144 = 1;
										flag47 = true;
										num11 = (int)(&obj232);
										num12 = (int)text25;
										num13 = num31;
										obj125 = 0;
										num15 = 272;
										num16 = (int)obj79;
										obj126 = obj89;
										if (flag82)
										{
											continue;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
										object obj233 = 0;
										object obj234 = obj233;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2271 @ X0_v204+E4]");
										bool flag83 = (nint)0 == 0;
										object obj235 = !flag83;
										if (obj235 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										GillaBoardLook.Rule(gillaQuestBoard.px, 320, 240, 10, 309, 211);
										int intoLevel = GillaLevel.IntoLevel;
										int forNext = GillaLevel.ForNext;
										object obj236 = flag14 & flag17;
										string line3;
										if (obj236 != null)
										{
											int level = GillaLevel.Level;
											string text26 = num3.ToString();
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6138]");
											object obj237 = 0;
											string text27 = (string)obj237 + text26;
											int num32 = 0;
											string text28 = text26;
											line3 = text27;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
											object obj238 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
											if (array4 == null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6140]");
											object obj239 = 0;
											object obj240 = array4 + 32;
											obj240 = obj239;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											int level2 = GillaLevel.Level;
											string text29 = num3.ToString();
											object obj241 = array4 + 40;
											obj241 = text29;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X20_v40-10]");
											bool flag84 = (nint)0 < (nint)2;
											object obj242 = !flag84;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X20_v40-10]");
											object obj243 = -2;
											bool flag85 = obj243 == null;
											object obj244 = ~obj242;
											object obj245 = obj244 | flag85;
											if (obj245 != null)
											{
												goto end_IL_2860;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60D8]");
											object obj246 = 0;
											object obj247 = array4 + 48;
											obj247 = obj246;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											string text30 = num33.ToString();
											object obj248 = array4 + 56;
											obj248 = text30;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ X20_v44-20]");
											bool flag86 = (nint)0 < (nint)4;
											object obj249 = !flag86;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ X20_v44-20]");
											object obj250 = -4;
											bool flag87 = obj250 == null;
											object obj251 = ~obj249;
											object obj252 = obj251 | flag87;
											if (obj252 != null)
											{
												goto end_IL_2860;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B18]");
											object obj253 = 0;
											object obj254 = array4 + 64;
											obj254 = obj253;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											string text31 = num34.ToString();
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X20_v46-28]");
											bool flag88 = (nint)0 < (nint)5;
											object obj255 = !flag88;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X20_v46-28]");
											object obj256 = -5;
											bool flag89 = obj256 == null;
											object obj257 = ~obj255;
											object obj258 = obj257 | flag89;
											if (obj258 != null)
											{
												goto end_IL_2860;
											}
											object obj259 = array4 + 72;
											obj259 = text31;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X20_v48-30]");
											bool flag90 = (nint)0 < (nint)6;
											object obj260 = !flag90;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X20_v48-30]");
											object obj261 = -6;
											bool flag91 = obj261 == null;
											object obj262 = ~obj260;
											object obj263 = obj262 | flag91;
											if (obj263 != null)
											{
												goto end_IL_2860;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6148]");
											object obj264 = 0;
											object obj265 = array4 + 80;
											obj265 = obj264;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											string text32 = string.Concat(array4);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
											obj233 = 0;
											int num32 = 240;
											string text28 = null;
											line3 = text32;
										}
										object obj266 = obj233;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2337 @ X0_v213+E4]");
										bool flag92 = (nint)0 == 0;
										object obj267 = !flag92;
										if (obj267 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj266 = obj233;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2337 @ X0_v213+A0]");
										object obj268 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										gillaQuestBoard.Line((ScreenFont)obj79, 14, 219, line3, (ShiftAuth.Style)(&obj269), centred: false);
										object obj270 = obj233;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2353 @ X8_v125+A0]");
										object obj271 = 0;
										Color32[] array5 = gillaQuestBoard.px;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2359 @ X8_v126+28]");
										GillaBoardLook.Box(array5, 320, 240, 186, 219, 118, 8, (Color32)0);
										object obj272 = forNext - 1;
										bool flag93 = (nint)obj272 < 0;
										bool flag94 = obj272 == null;
										int num35 = forNext ^ 1;
										int num36 = forNext ^ obj272;
										int num37 = num35 & num36;
										bool flag95 = num37 < 0;
										bool flag96 = flag93 == flag95;
										object obj273 = !flag94;
										object obj274 = flag96 & obj273;
										object obj275 = ~obj274;
										int num38 = ((obj275 != null) ? 1 : forNext);
										object obj276 = intoLevel * 1122238464;
										int num39 = obj276 / num38;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
										object obj277 = 0;
										object obj278 = obj277;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2403 @ X0_v219+E4]");
										bool flag97 = (nint)0 == 0;
										object obj279 = !flag97;
										if (obj279 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
										if (num39 < 0)
										{
											if ((double)num39 == -0.5)
											{
												num29 = -1.0;
												num28 = num40;
												goto IL_2d65;
											}
											num28 = (double)num39 + -0.5;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
											num27 = -0.5;
										}
										else
										{
											if ((double)num39 == 0.5)
											{
												num29 = 1.0;
												num28 = num40;
												goto IL_2d65;
											}
											num28 = (double)num39 + 0.5;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
											num27 = 0.5;
										}
										goto IL_2daf;
										IL_2daf:
										object obj280 = obj233;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2483 @ X8_v135+A0]");
										object obj281 = 0;
										GillaQuestBoard gillaQuestBoard3 = gillaQuestBoard;
										double num41 = num28;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v136+2C]");
										gillaQuestBoard3.Fill(188, 221, (int)num41, 4, (Color32)0);
										if ((object)gillaQuestBoard.tex == null)
										{
											break;
										}
										gillaQuestBoard.tex.SetPixels32(gillaQuestBoard.px);
										if ((object)gillaQuestBoard.tex == null)
										{
											break;
										}
										gillaQuestBoard.tex.Apply(updateMipmaps: true);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
										object obj282 = 0;
										object obj283 = obj282;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2503 @ X0_v226+E4]");
										bool flag98 = (nint)0 == 0;
										object obj284 = !flag98;
										if (obj284 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag99 = gillaQuestBoard.screen == null;
										bool flag100 = !flag99;
										object obj285 = !flag100;
										if (obj285 == null)
										{
											object obj286 = gillaQuestBoard + 104;
											bool flag101 = obj286 == null;
											object obj287 = !flag101;
											if (obj287 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
												object obj288 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
												materialPropertyBlock._002Ector();
												obj286 = materialPropertyBlock;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											}
											if ((object)gillaQuestBoard.screen == null)
											{
												break;
											}
											gillaQuestBoard.screen.GetPropertyBlock((MaterialPropertyBlock)obj286);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B8]");
											object obj289 = 0;
											object obj290 = obj289;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2528 @ X0_v232+E4]");
											bool flag102 = (nint)0 == 0;
											object obj291 = !flag102;
											if (obj291 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											if (obj286 == null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B8]");
											object obj292 = 0;
											object obj293 = obj292;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2535 @ X8_v147+A0]");
											object obj294 = 0;
											((MaterialPropertyBlock)obj286).SetTexture((int)obj294, (Texture)gillaQuestBoard.tex);
											if ((object)gillaQuestBoard.screen == null)
											{
												break;
											}
											gillaQuestBoard.screen.SetPropertyBlock((MaterialPropertyBlock)obj286);
										}
										return;
									}
								}
							}
						}
					}
				}
			}
			goto IL_27a9;
			IL_27a9:
			NullReferenceException ex = new NullReferenceException();
			break;
			continue;
			end_IL_2860:
			break;
		}
		throw new IndexOutOfRangeException();
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

	public GillaQuestBoard()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6188]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 40;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaQuestBoard()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B8]");
		object obj2 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = num;
	}
}
