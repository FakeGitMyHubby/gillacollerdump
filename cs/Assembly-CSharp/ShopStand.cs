using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class ShopStand : MonoBehaviour
{
	public int index;

	public bool featured;

	public string sells;

	public string bundle;

	public Renderer screen;

	public Transform orb;

	public Transform trackFrame;

	public Vector3 trackFrom;

	public Vector3 trackTo;

	public Transform display;

	public float displaySize;

	public float bob;

	public Material hologram;

	public TextAsset titleFont;

	public TextAsset textFont;

	public AudioClip tickSound;

	public AudioClip buySound;

	public AudioClip errorSound;

	public AudioClip coinSound;

	public AudioClip sparkleSound;

	public AudioClip grabSound;

	public Renderer burst;

	private const int W = default(int);

	private const int H = default(int);

	private static readonly int BaseMap;

	private static readonly Color32 Black;

	private static readonly Color32 Line;

	private static readonly Color32 Dim;

	private static readonly Color32 Bright;

	private static readonly Color32 Coin;

	private static readonly Color32 White;

	private static readonly Color32[] Plain;

	private static readonly Color32[] Picked;

	private static readonly Color32[] Warning;

	private byte id;

	private GameObject item;

	private Texture2D tex;

	private Color32[] px;

	private ScreenFont title;

	private ScreenFont text;

	private MaterialPropertyBlock block;

	private int hand;

	private float along;

	private float message;

	private float burstT;

	private bool atEnd;

	private string messageText;

	private bool messageBad;

	private bool dirty;

	private SlideOrb slide;

	private int lastBalance;

	private Vector3 displayRest;

	private static readonly DateTime StockFrom;

	private Coins.Bundle Bundle
	{
		get
		{
			if (string.IsNullOrEmpty(bundle))
			{
				return null;
			}
			return CosmeticCatalog.BundleNamed(bundle);
		}
	}

	private static int Fortnight
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d9: Expected Obj, but got I
			//IL_00fb: Expected Obj, but got I4
			//IL_0034: Expected Obj, but got I
			//IL_0067: Expected Obj, but got I4
			//IL_0119: Expected Obj, but got I
			//IL_012e: Expected VT, but got I
			//IL_015c: Expected Obj, but got I4
			//IL_00c1: Expected I4, but got F8
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6178]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9C8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60D0]");
			object obj5 = 0;
			DateTime utcNow = DateTime.UtcNow;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v6+38]");
			TimeSpan timeSpan = utcNow - (DateTime)0;
			object obj9 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan2 = default;
			double totalDays = timeSpan2.TotalDays;
			double num = totalDays / 8.000000001396984;
			return (int)num;
		}
	}

	public unsafe static DateTime NextStock
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00e2: Expected Obj, but got I
			//IL_0104: Expected Obj, but got I4
			//IL_0057: Expected Obj, but got I4
			//IL_0082: Expected Obj, but got I4
			//IL_00b4: Expected VT, but got I
			//IL_00c1: Expected Ref, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9C8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6178]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int fortnight = Fortnight;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = fortnight + 1;
			object obj8 = obj;
			double value = (double)obj7 * 8.000000001396984;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6+A0]");
			DateTime dateTime = (DateTime)((nint)0 + (nint)56);
			return ((DateTime*)dateTime)->AddDays(value);
		}
	}

	private static Color32 C(byte r, byte g, byte b)
	{
		//IL_0045: Expected VT, but got I8
		int num = g & 0xFF;
		int num2 = num << 8;
		int num3 = num2 | b;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
		return (Color32)(num3 | 0xFF000000L);
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a36: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_010c: Expected Obj, but got I
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_0162: Expected Obj, but got I4
		//IL_0191: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I4
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0258: Expected Obj, but got I4
		//IL_0287: Expected Obj, but got I
		//IL_02a3: Expected Obj, but got I4
		//IL_01df: Expected Obj, but got I
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_0204: Expected Obj, but got I4
		//IL_02d5: Expected Obj, but got I
		//IL_02fa: Expected Obj, but got I4
		//IL_0358: Expected I4, but got Obj
		//IL_0476: Expected Obj, but got I4
		//IL_03a2: Expected Obj, but got I
		//IL_03cc: Expected Obj, but got I4
		//IL_059e: Expected Obj, but got I
		//IL_05c8: Expected Obj, but got I4
		//IL_0910: Expected Obj, but got I4
		//IL_063e: Expected Obj, but got I4
		//IL_0963: Expected Obj, but got I
		//IL_097d: Expected Obj, but got I
		//IL_098b: Expected I, but got Obj
		//IL_054a: Expected Obj, but got I4
		//IL_09a0: Expected Obj, but got I
		//IL_09ca: Expected Obj, but got I4
		//IL_06cd: Expected Obj, but got I4
		//IL_075c: Expected Obj, but got I4
		//IL_07d1: Expected Obj, but got I
		//IL_07fb: Expected Obj, but got I4
		//IL_083b: Expected Obj, but got I4
		//IL_083b: Expected VT, but got Obj
		//IL_083b: Expected VT, but got Obj
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected Obj, but got Unknown
		//IL_0873: Expected Obj, but got I
		//IL_088d: Expected Obj, but got I
		//IL_0895: Expected I, but got Obj
		//IL_08a3: Expected I, but got Obj
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected Obj, but got Unknown
		//IL_08db: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Texture2D texture2D = default;
		texture2D._002Ector(256, 128, (TextureFormat)4, mipChain: true);
		texture2D.filterMode = (FilterMode)0;
		texture2D.wrapMode = (TextureWrapMode)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA00]");
		object obj5 = 0;
		texture2D.name = (string)obj5;
		texture2D.hideFlags = (HideFlags)52;
		object obj6 = this + 216;
		obj6 = texture2D;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = this + 224;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v21+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X20_v6-60]");
		bool flag3 = (UnityEngine.Object)0 != null;
		bool flag4 = !flag3;
		object obj12 = 0;
		ScreenFont screenFont = null;
		if (!flag4)
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
		object obj14 = this + 232;
		obj14 = screenFont;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v28+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X21_v4-60]");
		bool flag6 = (UnityEngine.Object)0 != null;
		bool flag7 = !flag6;
		object obj17 = 0;
		ScreenFont screenFont3 = null;
		if (!flag7)
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
		object obj19 = this + 240;
		obj19 = screenFont3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Coins.Bundle bundle = Bundle;
		byte b;
		if (bundle != null)
		{
			bool flag8 = (byte)(int)screenFont3 != 0;
			b = 0;
		}
		else if (string.IsNullOrEmpty(sells))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9C8]");
			object obj20 = 0;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v103+E4]");
			bool flag9 = (nint)0 == 0;
			object obj22 = !flag9;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag10 = !featured;
			bool flag11 = !flag10;
			b = Stock(index, flag11);
			bool flag8 = flag11;
		}
		else
		{
			b = CosmeticCatalog.IdOf(sells);
			bool flag8 = false;
		}
		object obj23 = obj;
		id = b;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v16+E4]");
		bool flag12 = (nint)0 == 0;
		object obj24 = !flag12;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag13 = orb != null;
		bool flag14 = !flag13;
		nint num = 0;
		bool flag15 = false;
		if (!flag14)
		{
			GameObject gameObject = orb.gameObject;
			Coins.Bundle bundle2 = Bundle;
			if (bundle2 != null)
			{
				Coins.Bundle bundle3 = Bundle;
				bool flag16 = !bundle3.realMoney;
				bool flag17 = (object)gameObject == null;
				object obj25 = !flag17;
				flag15 = flag16;
				if (obj25 == null)
				{
					throw new NullReferenceException();
				}
			}
			else
			{
				flag15 = true;
			}
			gameObject.SetActive(flag15);
			num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj26 = 0;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v43+E4]");
		bool flag18 = (nint)0 == 0;
		object obj28 = !flag18;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isPlaying = Application.isPlaying;
		bool flag19 = !isPlaying;
		TextureFormat textureFormat = (TextureFormat)4;
		if (!flag19)
		{
			object obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v62+E4]");
			bool flag20 = (nint)0 == 0;
			object obj30 = !flag20;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag21 = orb != null;
			bool flag22 = !flag21;
			textureFormat = (TextureFormat)4;
			num = 0;
			flag15 = false;
			if (!flag22)
			{
				object obj31 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v66+E4]");
				bool flag23 = (nint)0 == 0;
				object obj32 = !flag23;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag24 = trackFrame != null;
				bool flag25 = !flag24;
				textureFormat = (TextureFormat)4;
				num = 0;
				flag15 = false;
				if (!flag25)
				{
					object obj33 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X0_v70+E4]");
					bool flag26 = (nint)0 == 0;
					object obj34 = !flag26;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag27 = slide == null;
					bool flag28 = !flag27;
					textureFormat = (TextureFormat)4;
					num = 0;
					flag15 = false;
					if (!flag28)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF580]");
						object obj35 = 0;
						object obj36 = obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v74+E4]");
						bool flag29 = (nint)0 == 0;
						object obj37 = !flag29;
						if (obj37 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						SlideOrb slideOrb = SlideOrb.On(orb, trackFrame, (Vector3)grabSound, (Vector3)tickSound, (AudioClip)1, null);
						slide = slideOrb;
						object obj38 = this + 296;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C48]");
						object obj39 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9F0]");
						object obj40 = 0;
						num = (nint)obj40;
						Action<int> action = default;
						action._002Ector((object)this, (IntPtr)obj40);
						object obj41 = slide + 88;
						obj41 = action;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						textureFormat = (TextureFormat)0;
						flag15 = (byte)(int)action != 0;
					}
				}
			}
		}
		ShowItem();
		object obj42 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v49+E4]");
		bool flag30 = (nint)0 == 0;
		object obj43 = !flag30;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Application.isPlaying)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9F8]");
			object obj45 = 0;
			Action action2 = default;
			action2._002Ector(this, (IntPtr)obj45);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj46 = 0;
			object obj47 = obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v57+E4]");
			bool flag31 = (nint)0 == 0;
			object obj48 = !flag31;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coins.Changed += action2;
			flag15 = false;
		}
		Draw();
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02bf: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_0092: Expected I, but got Obj
		//IL_01f7: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I4
		//IL_026b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Application.isPlaying)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9F8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Action action = default;
			action._002Ector(this, (IntPtr)obj5);
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v27+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coins.Changed -= action;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = item != null;
		bool flag5 = !flag4;
		UnityEngine.Object obj12 = null;
		if (!flag5)
		{
			object obj13 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v20+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.DestroyImmediate(item);
			obj12 = null;
		}
		object obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v11+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (tex != null)
		{
			object obj17 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v15+E4]");
			bool flag8 = (nint)0 == 0;
			object obj18 = !flag8;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.DestroyImmediate(tex);
		}
	}

	private void OnCoins()
	{
		dirty = true;
	}

	public static byte Stock(int index, bool featured)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_06ec: Expected I4, but got Obj
		//IL_06da: Expected I4, but got Obj
		//IL_0052: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		//IL_0332: Expected Obj, but got I
		//IL_034a: Expected Obj, but got I
		//IL_036c: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00e6: Expected I, but got Obj
		//IL_03b0: Expected Obj, but got I4
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected I4, but got Unknown
		//IL_03f1: Expected Obj, but got I
		//IL_0680: Expected Obj, but got I
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Expected I4, but got Unknown
		//IL_0140: Expected Obj, but got I4
		//IL_0145: Expected I, but got Obj
		//IL_0755: Expected I4, but got Obj
		//IL_0442: Expected I4, but got Obj
		//IL_045c: Expected Obj, but got I4
		//IL_046a: Expected Obj, but got I4
		//IL_0484: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I4
		//IL_0268: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I
		//IL_024a: Expected I, but got Obj
		//IL_0548: Expected Obj, but got I4
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected I4, but got Unknown
		//IL_05c4: Expected Obj, but got I4
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected Obj, but got Unknown
		//IL_0796: Expected Obj, but got I
		//IL_07bb: Expected Obj, but got I
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected Obj, but got Unknown
		//IL_0813: Expected Obj, but got I4
		//IL_0613: Expected Obj, but got I4
		//IL_0605: Expected Obj, but got I
		//IL_0632: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45D0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		byte b = (byte)(int)obj2;
		List<byte> list = default;
		list._002Ector();
		int count = CosmeticCatalog.Count;
		if (count < 1)
		{
			goto IL_02e0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45D8]");
		object obj4 = 0;
		nint num = default;
		IntPtr intPtr = num;
		int num2 = 1;
		while (true)
		{
			CosmeticCatalog.Entry entry = CosmeticCatalog.Of(num2);
			if (entry == null)
			{
				break;
			}
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v43+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = entry.prefab != null;
			bool flag3 = !flag2;
			num = unchecked((nint)null);
			b = 0;
			if (!flag3)
			{
				CosmeticCatalog.Entry entry2 = CosmeticCatalog.Of(num2);
				if (entry2 == null)
				{
					break;
				}
				bool flag4 = (byte)(~(entry2.retired ? 1u : 0u)) != 0;
				object obj7 = !flag4;
				num = unchecked((nint)null);
				b = 0;
				if (obj7 == null)
				{
					if (list == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+10]");
					object obj8 = 0;
					object obj9 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+1C]");
					object obj10 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+10]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v30+18]");
					bool flag5 = num3 < 0;
					object obj11 = !flag5;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
						object obj12 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+10]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
						object obj13 = num4 + 0;
						num = unchecked((nint)null);
						b = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X9_v15+20]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v31+A8]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v32+70]");
						num = 0;
						list.AddWithResize((byte)num2);
						b = (byte)num2;
					}
				}
			}
			num2++;
			int count2 = CosmeticCatalog.Count;
			bool flag6 = num2 <= count2;
			intPtr = num;
			if (flag6)
			{
				continue;
			}
			goto IL_02e0;
		}
		goto IL_06cc;
		IL_02e0:
		int num8;
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
			if ((nint)0 == 0)
			{
				return 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9C8]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F90]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v11+E4]");
			bool flag7 = (nint)0 == 0;
			object obj19 = !flag7;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int fortnight = Fortnight;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj20 = fortnight * 7919;
			int seed = 17 + obj20;
			System.Random random = default;
			random._002Ector(seed);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
			int num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
			object obj21 = -1;
			if ((nint)obj21 < 1)
			{
				goto IL_0692;
			}
			if (random != null)
			{
				object obj25;
				do
				{
					int num6 = num5 - 1;
					string text = ((System.Empty)(object)random).ToString();
					byte value = list.get_Item((int)text);
					byte value2 = list.get_Item(num6);
					list.set_Item(num6, value);
					list.set_Item((int)text, value2);
					bool flag8 = num6 < 1;
					object obj22 = !flag8;
					object obj23 = num6 - 1;
					bool flag9 = obj23 == null;
					object obj24 = !flag9;
					obj25 = obj22 & obj24;
					num5 = num6;
				}
				while (obj25 != null);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
				if ((nint)0 < (nint)2)
				{
					goto IL_0692;
				}
				int num7 = 1;
				num8 = 0;
				while (true)
				{
					byte b2 = list.get_Item(num7);
					int num9 = b2 & 0xFF;
					CosmeticCatalog.Entry entry3 = CosmeticCatalog.Of(num9);
					if (entry3 == null)
					{
						break;
					}
					byte b3 = list.get_Item(num8);
					int num10 = b3 & 0xFF;
					CosmeticCatalog.Entry entry4 = CosmeticCatalog.Of(num10);
					if (entry4 == null)
					{
						break;
					}
					object obj26 = entry3.price - entry4.price;
					bool flag10 = (nint)obj26 < 0;
					bool flag11 = obj26 == null;
					int num11 = entry3.price ^ entry4.price;
					int num12 = entry3.price ^ obj26;
					int num13 = num11 & num12;
					bool flag12 = num13 < 0;
					bool flag13 = flag10 == flag12;
					object obj27 = !flag11;
					object obj28 = flag13 & obj27;
					object obj29 = ~obj28;
					if (obj29 == null)
					{
						num8 = num7;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
					object obj30 = -4;
					bool flag14 = (nint)obj30 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
					object obj31 = (nint)0 ^ (nint)4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
					object obj32 = 0 ^ obj30;
					object obj33 = obj31 & obj32;
					bool flag15 = (nint)obj33 < 0;
					num7++;
					bool flag16 = flag14 == flag15;
					object obj34 = !flag16;
					object obj35 = ~obj34;
					object obj36;
					if (obj35 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
						obj36 = 0;
					}
					else
					{
						obj36 = 4;
					}
					if (num7 < (nint)obj36)
					{
						continue;
					}
					goto IL_0618;
				}
			}
		}
		goto IL_06cc;
		IL_0692:
		bool flag17 = !featured;
		num8 = 0;
		if (flag17)
		{
			goto IL_0648;
		}
		int num14 = 0;
		goto IL_0846;
		IL_0618:
		bool flag18 = !featured;
		object obj37 = !flag18;
		num14 = num8;
		if (obj37 == null)
		{
			goto IL_0648;
		}
		goto IL_0846;
		IL_0648:
		list.RemoveAt(num8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
		int num15 = (int)((nint)index / (nint)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Collections.Generic.List`1<System.Byte>)+18]");
		object obj38 = (nint)num15 * (nint)0;
		num14 = index - obj38;
		goto IL_0846;
		IL_06cc:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex;
		IL_0846:
		return list.get_Item(num14);
	}

	private void ShowItem()
	{
		//IL_0010: Expected Obj, but got I
		//IL_1742: Unknown result type (might be due to invalid IL or missing references)
		//IL_1747: Expected Obj, but got Unknown
		//IL_1769: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_01c4: Expected Obj, but got I4
		//IL_020e: Expected Obj, but got I4
		//IL_0143: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got I4
		//IL_0246: Expected Obj, but got I4
		//IL_028d: Expected Obj, but got I4
		//IL_0349: Expected Obj, but got I
		//IL_0373: Expected Obj, but got I4
		//IL_03b3: Expected Obj, but got I4
		//IL_05db: Expected Obj, but got I4
		//IL_03ec: Expected Obj, but got I4
		//IL_17b7: Expected Obj, but got I4
		//IL_041d: Expected Obj, but got I
		//IL_0425: Expected I4, but got Obj
		//IL_0447: Expected Obj, but got I4
		//IL_0450: Expected Obj, but got I4
		//IL_060b: Expected Obj, but got I
		//IL_0623: Expected Obj, but got I
		//IL_0633: Expected F4, but got I
		//IL_0643: Expected F4, but got I
		//IL_064b: Expected F4, but got Obj
		//IL_0659: Expected VT, but got I4
		//IL_0671: Expected Obj, but got I4
		//IL_046e: Expected Obj, but got I
		//IL_048e: Expected Obj, but got I4
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected Obj, but got Unknown
		//IL_04b3: Expected Obj, but got I4
		//IL_04bb: Expected I4, but got Obj
		//IL_04c4: Expected Obj, but got I4
		//IL_17e2: Expected Obj, but got I4
		//IL_1791: Expected Obj, but got I4
		//IL_16fb: Expected Obj, but got I4
		//IL_06a6: Expected Obj, but got I
		//IL_06be: Expected Obj, but got I
		//IL_06ce: Expected F4, but got I
		//IL_06de: Expected F4, but got I
		//IL_06e6: Expected F4, but got Obj
		//IL_06f6: Expected F4, but got I
		//IL_0704: Expected VT, but got I4
		//IL_071c: Expected Obj, but got I4
		//IL_04e9: Expected Obj, but got I4
		//IL_0518: Expected Obj, but got I
		//IL_0534: Expected Obj, but got I4
		//IL_180d: Expected Obj, but got I4
		//IL_056d: Expected Obj, but got I
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_05a3: Expected Obj, but got I4
		//IL_05b5: Expected Obj, but got I4
		//IL_0759: Expected Obj, but got I
		//IL_0769: Expected F4, but got I
		//IL_0779: Expected F4, but got I
		//IL_0789: Expected F4, but got I
		//IL_0797: Expected VT, but got I4
		//IL_07af: Expected Obj, but got I4
		//IL_07d2: Expected Obj, but got I
		//IL_07fc: Expected Obj, but got I4
		//IL_084e: Expected Obj, but got I
		//IL_0881: Expected Obj, but got I4
		//IL_089e: Expected Obj, but got I
		//IL_0bc2: Expected Obj, but got I
		//IL_0bd2: Expected Obj, but got I
		//IL_0bf2: Expected Obj, but got I4
		//IL_1887: Expected Obj, but got I4
		//IL_0c19: Expected Obj, but got I
		//IL_0c2d: Expected Obj, but got I
		//IL_0e76: Expected Obj, but got I4
		//IL_0af3: Expected Obj, but got I4
		//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c85: Expected Obj, but got Unknown
		//IL_0ce3: Expected Obj, but got I4
		//IL_08ed: Expected Obj, but got I4
		//IL_0e94: Expected VT, but got I4
		//IL_0eca: Expected Obj, but got I4
		//IL_1c8e: Expected Obj, but got I4
		//IL_0b1f: Expected Obj, but got I
		//IL_0b2f: Expected Obj, but got I
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3d: Expected Obj, but got Unknown
		//IL_0b7f: Expected Obj, but got I
		//IL_0914: Expected Obj, but got I
		//IL_0930: Expected Obj, but got I4
		//IL_0f0b: Expected VT, but got I4
		//IL_0f1f: Expected Obj, but got I
		//IL_0d38: Expected Obj, but got I4
		//IL_0f4e: Expected Obj, but got I4
		//IL_0f57: Expected Obj, but got I4
		//IL_0955: Expected Obj, but got I4
		//IL_0965: Expected Obj, but got I
		//IL_0987: Expected Obj, but got I4
		//IL_0d5f: Expected Obj, but got I
		//IL_0dbe: Expected Obj, but got I
		//IL_0dd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddb: Expected Obj, but got Unknown
		//IL_0f95: Expected Obj, but got I4
		//IL_18b5: Invalid comparison between F8 and I4
		//IL_18c4: Invalid comparison between F8 and I4
		//IL_18d7: Expected Obj, but got F8
		//IL_18e4: Expected Obj, but got F8
		//IL_1919: Expected Obj, but got I4
		//IL_1921: Unknown result type (might be due to invalid IL or missing references)
		//IL_1926: Expected Obj, but got Unknown
		//IL_0abd: Expected Obj, but got I
		//IL_0fe2: Expected Obj, but got I4
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ca: Expected Obj, but got Unknown
		//IL_09de: Expected Obj, but got I8
		//IL_09e7: Expected Obj, but got I4
		//IL_101c: Expected Obj, but got I4
		//IL_1032: Expected Obj, but got I
		//IL_1057: Unknown result type (might be due to invalid IL or missing references)
		//IL_105c: Expected Obj, but got Unknown
		//IL_1075: Expected Obj, but got I4
		//IL_1a38: Invalid comparison between F8 and I4
		//IL_1a47: Invalid comparison between F8 and I4
		//IL_1a5a: Expected Obj, but got F8
		//IL_1a67: Expected Obj, but got F8
		//IL_1a9c: Expected Obj, but got I4
		//IL_1aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa9: Expected Obj, but got Unknown
		//IL_1839: Expected Obj, but got I4
		//IL_09f4: Expected I, but got Obj
		//IL_0a04: Expected Obj, but got I
		//IL_0a26: Expected Obj, but got I4
		//IL_10c2: Expected Obj, but got I4
		//IL_0a6a: Expected Obj, but got I4
		//IL_0a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a78: Expected Obj, but got Unknown
		//IL_0a46: Expected Obj, but got I4
		//IL_1173: Expected Obj, but got I4
		//IL_117c: Expected Obj, but got I4
		//IL_111d: Expected Obj, but got I8
		//IL_1126: Unknown result type (might be due to invalid IL or missing references)
		//IL_112b: Expected Obj, but got Unknown
		//IL_1134: Unknown result type (might be due to invalid IL or missing references)
		//IL_1139: Expected Obj, but got Unknown
		//IL_1cdc: Expected F4, but got Obj
		//IL_1ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cea: Expected Obj, but got Unknown
		//IL_1d02: Invalid comparison between F4 and I4
		//IL_1d11: Invalid comparison between F4 and I4
		//IL_1d1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d24: Expected Obj, but got Unknown
		//IL_1d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d31: Expected Obj, but got Unknown
		//IL_1d66: Expected Obj, but got I4
		//IL_1d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d73: Expected Obj, but got Unknown
		//IL_1c10: Expected Obj, but got I4
		//IL_1bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc8: Expected Obj, but got Unknown
		//IL_114e: Expected F4, but got Obj
		//IL_11c5: Expected Obj, but got I
		//IL_11d5: Expected F4, but got I
		//IL_1228: Expected VT, but got I4
		//IL_1240: Expected Obj, but got I4
		//IL_12d6: Expected Obj, but got I4
		//IL_1c3b: Expected Obj, but got I4
		//IL_1329: Expected Obj, but got I
		//IL_13cc: Expected VT, but got I4
		//IL_13f9: Expected Obj, but got I
		//IL_142b: Expected Obj, but got I4
		//IL_1465: Expected Obj, but got I4
		//IL_1488: Expected Obj, but got I
		//IL_14b8: Expected Obj, but got I
		//IL_14de: Expected Obj, but got I
		//IL_1610: Expected Obj, but got I4
		//IL_151d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1522: Expected Obj, but got Unknown
		//IL_153c: Expected Obj, but got I4
		//IL_162e: Expected Obj, but got I
		//IL_1662: Expected Obj, but got I4
		//IL_1c67: Expected Obj, but got I4
		//IL_1561: Expected Obj, but got I4
		//IL_16c2: Expected Obj, but got I4
		//IL_1594: Expected Obj, but got I
		//IL_15a4: Expected Obj, but got I
		//IL_15ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b2: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v130+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isPlaying = Application.isPlaying;
			object obj8 = obj;
			if (isPlaying)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v134+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy((UnityEngine.Object)obj3);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v134+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.DestroyImmediate((UnityEngine.Object)obj3);
			}
		}
		CosmeticCatalog.Entry entry = CosmeticCatalog.Of(id);
		if (entry == null)
		{
			return;
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v10+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = entry.prefab == null;
		bool flag7 = !flag6;
		object obj13 = !flag7;
		if (obj13 != null)
		{
			return;
		}
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v14+E4]");
		bool flag8 = (nint)0 == 0;
		object obj15 = !flag8;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = display == null;
		bool flag10 = !flag9;
		object obj16 = !flag10;
		if (obj16 != null)
		{
			return;
		}
		GameObject gameObject = CosmeticCatalog.Display(entry);
		obj3 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag11 = obj3 == null;
		bool flag12 = false;
		GameObject gameObject2 = gameObject;
		bool flag19;
		GameObject gameObject3;
		object obj21;
		if (!flag11)
		{
			Transform transform = ((GameObject)obj3).transform;
			bool flag13 = (object)transform == null;
			flag12 = false;
			gameObject2 = null;
			if (!flag13)
			{
				transform.SetParent(display, worldPositionStays: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
				object obj17 = 0;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X0_v29+E4]");
				bool flag14 = (nint)0 == 0;
				object obj19 = !flag14;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool isPlaying2 = Application.isPlaying;
				bool flag15 = !isPlaying2;
				object obj20 = !flag15;
				flag12 = false;
				gameObject2 = (GameObject)(object)display;
				if (obj20 != null)
				{
					goto IL_05c3;
				}
				bool flag16 = obj3 == null;
				obj21 = 0;
				flag12 = false;
				gameObject2 = (GameObject)(object)display;
				if (!flag16)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B28]");
					object obj22 = 0;
					flag12 = (byte)(int)obj22 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
					object obj23 = default;
					bool flag17 = obj23 == null;
					obj21 = 0;
					gameObject2 = (GameObject)1;
					if (!flag17)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X0_v122+18]");
						object obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X0_v122+18]");
						bool flag18 = (nint)0 < (nint)1;
						gameObject2 = (GameObject)1;
						if (flag18)
						{
							goto IL_05c3;
						}
						object obj25 = obj23 + 32;
						object obj26 = 0;
						flag19 = (byte)(int)obj22 != 0;
						gameObject3 = (GameObject)1;
						while (true)
						{
							bool flag20 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
							object obj27 = !flag20;
							if (obj27 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X23_v22+v657 @ X22_v15*8]");
							bool flag21 = (nint)0 == 0;
							obj21 = 0;
							flag12 = flag19;
							gameObject2 = gameObject3;
							if (!flag21)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X23_v22+v657 @ X22_v15*8]");
								GameObject gameObject4 = ((Component)0).gameObject;
								bool flag22 = (object)gameObject4 == null;
								obj21 = 0;
								flag12 = flag19;
								gameObject2 = null;
								if (!flag22)
								{
									gameObject4.hideFlags = (HideFlags)52;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X0_v122+18]");
									obj24 = 0;
									obj26++;
									object obj28 = obj26;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X0_v122+18]");
									bool flag23 = (nint)obj28 < 0;
									flag12 = false;
									gameObject2 = (GameObject)52;
									flag19 = false;
									gameObject3 = (GameObject)52;
									if (flag23)
									{
										continue;
									}
									goto IL_05c3;
								}
							}
							goto IL_1710;
						}
						goto IL_16e9;
					}
				}
			}
		}
		goto IL_1710;
		IL_15f8:
		bool flag24 = obj3 == null;
		obj21 = 0;
		object obj31;
		if (!flag24)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF410]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
			object obj30 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v59+E4]");
			bool flag25 = (nint)0 == 0;
			object obj32 = !flag25;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj33 = default;
			if (!(obj33 != null))
			{
				return;
			}
			bool flag26 = (object)obj33 == null;
			obj21 = 0;
			flag12 = false;
			gameObject2 = null;
			if (!flag26)
			{
				_ = 1128792064;
				return;
			}
		}
		goto IL_1710;
		IL_0b8d:
		object obj34;
		bool flag27 = obj34 == null;
		flag19 = flag12;
		object obj35;
		double num;
		float num3;
		double num5;
		float num7;
		object obj38 = default;
		float num21;
		float num24;
		float num40;
		float num22;
		if (!flag27)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v49+20]");
			bool flag28 = (nint)0 == 0;
			obj21 = 0;
			gameObject2 = gameObject3;
			if (flag28)
			{
				goto IL_1710;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v49+20]");
			Bounds bounds = ((Renderer)0).bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v49+18]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v49+18]");
			bool flag29 = (nint)0 < (nint)1;
			double num2 = default;
			num = num2;
			float num4 = default;
			num3 = num4;
			double num6 = default;
			num5 = num6;
			float num8 = default;
			num7 = num8;
			gameObject2 = null;
			if (flag29)
			{
				goto IL_0e4c;
			}
			object obj37 = obj38 + 32;
			float num10 = default;
			float num9 = num10;
			float num12 = default;
			float num11 = num12;
			float num14 = default;
			float num13 = num14;
			float num16 = default;
			float num15 = num16;
			double num17 = num2;
			float num18 = num4;
			double num19 = num6;
			float num20 = num21;
			num22 = num8;
			float num23 = num24;
			gameObject3 = null;
			object obj39 = 0;
			object obj41 = default;
			object obj48 = default;
			while (true)
			{
				bool flag30 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj39) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj36);
				object obj40 = !flag30;
				num10 = num9;
				num12 = num11;
				num14 = num13;
				num16 = num15;
				num21 = num20;
				num24 = num23;
				flag19 = flag12;
				if (obj40 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X24_v9+v806 @ X23_v18*8]");
				bool flag31 = (nint)0 == 0;
				num10 = num9;
				num12 = num11;
				num14 = num13;
				num16 = num15;
				num21 = num20;
				num24 = num23;
				obj21 = 0;
				gameObject2 = gameObject3;
				if (!flag31)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X24_v9+v806 @ X23_v18*8]");
					Bounds bounds2 = ((Renderer)0).bounds;
					double num25 = num19 - num17;
					double num26 = num17 + num19;
					double num27 = num6 - num2;
					double num28 = num6 + num2;
					num16 = (float)obj41 + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v49+18]");
					obj36 = 0;
					float num29 = num22 - num18;
					obj39++;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
					if (!(num25 < num27))
					{
						num25 = num27;
					}
					double num30 = num26 - num27;
					bool flag32 = num30 < 0.0;
					bool flag33 = num30 == 0.0;
					object obj42 = num26 ^ num27;
					object obj43 = num26 ^ num30;
					object obj44 = obj42 & obj43;
					bool flag34 = (nint)obj44 < 0;
					bool flag35 = flag32 == flag34;
					object obj45 = !flag33;
					object obj46 = flag35 & obj45;
					object obj47 = ~obj46;
					if (obj47 == null)
					{
						num27 = num26;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
					double num31 = num27 - num25;
					float num32 = (float)obj48 - num29;
					double num33 = num31 * 0.5;
					num12 = num32 * 63f;
					double num34 = num25 + num33;
					float num35 = num29 + num12;
					double num36 = num34 - num33;
					double num37 = num33 + num34;
					num14 = num35 - num12;
					num10 = num12 + num35;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
					if (!(num36 < num28))
					{
						num36 = num28;
					}
					double num38 = num37 - num28;
					bool flag36 = num38 < 0.0;
					bool flag37 = num38 == 0.0;
					object obj49 = num37 ^ num28;
					object obj50 = num37 ^ num38;
					object obj51 = obj49 & obj50;
					bool flag38 = (nint)obj51 < 0;
					bool flag39 = flag36 == flag38;
					object obj52 = !flag37;
					object obj53 = flag39 & obj52;
					object obj54 = ~obj53;
					if (obj54 == null)
					{
						num28 = num37;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
					double num39 = num28 - num36;
					num21 = num12 - (float)num34;
					num = num39 * 0.5;
					num3 = num21 * 63f;
					num5 = num36 + num;
					num7 = (float)num34 + num3;
					bool flag40 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj39) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj36);
					num24 = (float)num34;
					gameObject2 = null;
					num9 = num10;
					num11 = num12;
					num13 = num14;
					num15 = num16;
					num17 = num;
					num18 = num3;
					num19 = num5;
					num20 = num21;
					num22 = num7;
					num23 = (float)num34;
					num40 = (float)num36;
					gameObject3 = null;
					if (flag40)
					{
						continue;
					}
					goto IL_0e4c;
				}
				goto IL_1710;
			}
		}
		goto IL_16e9;
		IL_05c3:
		bool flag41 = obj3 == null;
		obj21 = 0;
		bool flag49;
		NullReferenceException ex = default;
		if (!flag41)
		{
			Transform transform2 = ((GameObject)obj3).transform;
			bool flag42 = (object)transform2 == null;
			obj21 = 0;
			gameObject2 = null;
			if (!flag42)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj55 = 0;
				object obj56 = obj55;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X8_v17+A0]");
				object obj57 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v18+4]");
				num40 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v18+8]");
				num24 = 0f;
				num22 = (float)obj57;
				transform2.localPosition = (Vector3)0;
				bool flag43 = obj3 == null;
				obj21 = 0;
				gameObject2 = null;
				if (!flag43)
				{
					Transform transform3 = ((GameObject)obj3).transform;
					bool flag44 = (object)transform3 == null;
					obj21 = 0;
					gameObject2 = null;
					if (!flag44)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
						object obj58 = 0;
						object obj59 = obj58;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v23+A0]");
						object obj60 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X8_v24+8]");
						num24 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X8_v24+C]");
						num21 = 0f;
						num22 = (float)obj60;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X8_v24+4]");
						num40 = 0f;
						transform3.localRotation = (Quaternion)0;
						bool flag45 = obj3 == null;
						obj21 = 0;
						gameObject2 = null;
						if (!flag45)
						{
							Transform transform4 = ((GameObject)obj3).transform;
							bool flag46 = (object)transform4 == null;
							obj21 = 0;
							gameObject2 = null;
							if (!flag46)
							{
								object obj61 = obj55;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v971 @ X8_v27+A0]");
								object obj62 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v28+10]");
								num40 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v28+14]");
								num24 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v28+C]");
								num22 = 0f;
								transform4.localScale = (Vector3)0;
								bool flag47 = obj3 == null;
								obj21 = 0;
								gameObject2 = null;
								if (!flag47)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C30]");
									object obj63 = 0;
									gameObject2 = (GameObject)obj63;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36268A8");
									bool flag48 = obj38 == null;
									obj21 = 0;
									if (!flag48)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v49+18]");
										if ((nint)0 == 0)
										{
											return;
										}
										flag49 = string.IsNullOrEmpty(sells);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v49+18]");
										obj34 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v49+18]");
										bool flag50 = (nint)0 < (nint)1;
										gameObject3 = null;
										if (flag50)
										{
											goto IL_0b8d;
										}
										object obj64 = 0;
										flag19 = flag12;
										gameObject2 = null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v49+18]");
										object obj65 = 0;
										Material[] array = default;
										while (true)
										{
											bool flag51 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj64) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj65);
											object obj66 = !flag51;
											gameObject3 = gameObject2;
											if (obj66 != null)
											{
												break;
											}
											object obj67 = obj38 + obj64;
											if (!flag49)
											{
												goto IL_0ad3;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X8_v75+20]");
											bool flag52 = (nint)0 == 0;
											obj21 = 0;
											flag12 = flag19;
											if (!flag52)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X8_v75+20]");
												Material[] sharedMaterials = ((Renderer)0).sharedMaterials;
												bool flag53 = sharedMaterials == null;
												obj21 = 0;
												flag12 = flag19;
												gameObject2 = null;
												if (!flag53)
												{
													gameObject2 = (GameObject)sharedMaterials.Length;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B58]");
													object obj68 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
													bool flag54 = array == null;
													obj21 = 0;
													flag12 = flag19;
													if (!flag54)
													{
														if (array.Length < 1)
														{
															goto IL_0aa8;
														}
														object obj69 = array + 32;
														object obj70 = array.Length & 0xFFFFFFFFL;
														object obj71 = 0;
														while (true)
														{
															if ((object)hologram != null)
															{
																nint num41 = (nint)array;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X8_v86 (Il2CppClass<UnityEngine.Material[]>)+40]");
																gameObject2 = (GameObject)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																bool flag55 = ex == null;
																obj21 = 0;
																flag12 = flag19;
																if (flag55)
																{
																	break;
																}
																obj70 = array.Length;
															}
															bool flag56 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj71) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj70);
															object obj72 = !flag56;
															gameObject3 = gameObject2;
															if (obj72 != null)
															{
																goto end_IL_186e;
															}
															obj69 = hologram;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															obj70 = array.Length;
															object obj73 = obj71 + 1;
															bool flag57 = (nint)obj73 < array.Length;
															obj71 = obj73;
															gameObject2 = (GameObject)(object)hologram;
															if (flag57)
															{
																continue;
															}
															goto IL_0aa8;
														}
														goto IL_171e;
													}
												}
											}
											goto IL_1710;
											IL_0ad3:
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X8_v75+20]");
											bool flag58 = (nint)0 == 0;
											obj21 = 0;
											flag12 = flag19;
											if (!flag58)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X8_v75+20]");
												((Renderer)0).shadowCastingMode = (ShadowCastingMode)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v49+18]");
												obj34 = 0;
												obj64++;
												object obj74 = obj64;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v49+18]");
												bool flag59 = (nint)obj74 < 0;
												flag12 = false;
												gameObject3 = null;
												flag19 = false;
												gameObject2 = null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v49+18]");
												obj65 = 0;
												if (flag59)
												{
													continue;
												}
												goto IL_0b8d;
											}
											goto IL_1710;
											IL_0aa8:
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X8_v75+20]");
											((Renderer)0).sharedMaterials = array;
											flag19 = false;
											gameObject2 = (GameObject)(object)array;
											goto IL_0ad3;
											continue;
											end_IL_186e:
											break;
										}
										goto IL_16e9;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_1710;
		IL_1710:
		ex = new NullReferenceException();
		goto IL_171e;
		IL_1c23:
		Transform transform5;
		bool flag60 = (object)transform5 == null;
		obj21 = 0;
		gameObject2 = null;
		float num42;
		float num43 = default;
		if (!flag60)
		{
			object obj75 = obj35;
			float num16 = (float)num5 * num42;
			float num14 = num43 * num42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1335 @ X8_v47+A0]");
			object obj76 = 0;
			float num44 = num22 * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v48+20]");
			float num45 = 0f * num44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v48+1C]");
			float num46 = 0f * num44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v48+18]");
			float num47 = 0f * num44;
			num21 = num7 * num42;
			num24 = num45 - num16;
			num40 = num46 - num14;
			num22 = num47 - num21;
			transform5.localPosition = (Vector3)0;
			if (!flag49)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj77 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			bool flag61 = (object)display == null;
			obj21 = 0;
			gameObject2 = null;
			if (!flag61)
			{
				Vector3 position = display.position;
				bool flag62 = materialPropertyBlock == null;
				obj21 = 0;
				gameObject2 = null;
				if (!flag62)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA18]");
					object obj78 = 0;
					materialPropertyBlock.SetFloat((string)obj78, num40);
					num22 = num43 * num42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA10]");
					object obj79 = 0;
					materialPropertyBlock.SetFloat((string)obj79, num22);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v49+18]");
					object obj80 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v49+18]");
					bool flag63 = (nint)0 < (nint)1;
					flag12 = false;
					gameObject2 = (GameObject)obj79;
					if (flag63)
					{
						goto IL_15f8;
					}
					object obj81 = obj38 + 32;
					flag19 = false;
					gameObject3 = (GameObject)obj79;
					object obj82 = 0;
					while (true)
					{
						bool flag64 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj82) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj80);
						object obj83 = !flag64;
						if (obj83 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X23_v16+v799 @ X20_v9*8]");
						bool flag65 = (nint)0 == 0;
						obj21 = 0;
						flag12 = flag19;
						gameObject2 = gameObject3;
						if (!flag65)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X23_v16+v799 @ X20_v9*8]");
							((Renderer)0).SetPropertyBlock(materialPropertyBlock);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v49+18]");
							obj80 = 0;
							obj82++;
							object obj84 = obj82;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v49+18]");
							bool flag66 = (nint)obj84 < 0;
							flag12 = false;
							gameObject2 = (GameObject)(object)materialPropertyBlock;
							flag19 = false;
							gameObject3 = (GameObject)(object)materialPropertyBlock;
							if (flag66)
							{
								continue;
							}
							goto IL_15f8;
						}
						goto IL_1710;
					}
					goto IL_16e9;
				}
			}
		}
		goto IL_1710;
		IL_171e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_0e4c:
		bool flag67 = (object)display == null;
		num22 = num7;
		num40 = num43;
		obj21 = 0;
		if (!flag67)
		{
			Vector3 vector = display.InverseTransformPoint((Vector3)0);
			bool flag68 = (object)display == null;
			num22 = num7;
			num24 = (float)num5;
			num40 = num43;
			obj21 = 0;
			gameObject2 = null;
			if (!flag68)
			{
				num22 = num3 + num3;
				num24 = (float)num + (float)num;
				Vector3 vector2 = display.InverseTransformVector((Vector3)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
				object obj85 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj86 = default;
				bool flag69 = obj86 == null;
				num40 = num43;
				obj21 = 0;
				gameObject2 = (GameObject)4;
				if (!flag69)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v61+18]");
					bool flag70 = (nint)0 == 0;
					num40 = num43;
					flag19 = flag12;
					gameObject3 = (GameObject)4;
					if (!flag70)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v61+18]");
						bool flag71 = (nint)0 == 1;
						num40 = num43;
						flag19 = flag12;
						gameObject3 = (GameObject)4;
						if (!flag71)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v61+18]");
							bool flag72 = (nint)0 < (nint)2;
							object obj87 = !flag72;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v61+18]");
							object obj88 = -2;
							bool flag73 = obj88 == null;
							object obj89 = ~obj87;
							object obj90 = obj89 | flag73;
							num40 = num43;
							flag19 = flag12;
							gameObject3 = (GameObject)4;
							if (obj90 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v61+18]");
								bool flag74 = (nint)0 == 3;
								num40 = num43;
								flag19 = flag12;
								gameObject3 = (GameObject)4;
								if (!flag74)
								{
									_ = 1008981770;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v61+18]");
									bool flag75 = (nint)0 < (nint)2;
									float num48 = num22;
									if (!flag75)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v61+18]");
										object obj91 = 0 & 0xFFFFFFFFL;
										object obj92 = obj86 + 36;
										object obj93 = obj91 - 1;
										float num49 = num22;
										bool flag80;
										do
										{
											num22 = (float)obj92;
											obj92 += 4;
											float num50 = (float)obj92 - num49;
											bool flag76 = num50 < 0f;
											bool flag77 = num50 == 0f;
											object obj94 = obj92 ^ num49;
											object obj95 = obj92 ^ num50;
											object obj96 = obj94 & obj95;
											bool flag78 = (nint)obj96 < 0;
											bool flag79 = flag76 == flag78;
											object obj97 = !flag77;
											object obj98 = flag79 & obj97;
											object obj99 = ~obj98;
											if (obj99 == null)
											{
												num49 = (float)obj92;
											}
											obj93--;
											flag80 = (nint)obj93 != 1;
											num48 = num49;
										}
										while (flag80);
									}
									bool flag81 = obj3 == null;
									num40 = num43;
									obj21 = 0;
									gameObject2 = (GameObject)4;
									if (!flag81)
									{
										Transform transform6 = ((GameObject)obj3).transform;
										bool flag82 = (object)transform6 == null;
										num40 = num43;
										obj21 = 0;
										gameObject2 = null;
										if (!flag82)
										{
											num42 = displaySize / num48;
											object obj100 = obj35;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1309 @ X8_v43+A0]");
											object obj101 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v44+C]");
											num21 = 0f;
											float num51 = num42;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v44+14]");
											num24 = num51 * 0f;
											float num52 = num42;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v44+10]");
											num40 = num52 * 0f;
											float num53 = num42;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v44+C]");
											num22 = num53 * 0f;
											transform6.localScale = (Vector3)0;
											bool flag83 = obj3 == null;
											obj21 = 0;
											gameObject2 = null;
											if (!flag83)
											{
												transform5 = ((GameObject)obj3).transform;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD9A0]");
												if ((nint)0 != 0)
												{
													if (flag49)
													{
														goto IL_12a2;
													}
												}
												else
												{
													_ = 1;
													bool flag84 = !flag49;
													object obj102 = !flag84;
													if (obj102 != null)
													{
														goto IL_12a2;
													}
												}
												num22 = displaySize;
												goto IL_1c23;
											}
										}
									}
									goto IL_1710;
								}
							}
						}
					}
					goto IL_16e9;
				}
			}
		}
		goto IL_1710;
		IL_16e9:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		obj21 = 0;
		flag12 = flag19;
		gameObject2 = gameObject3;
		goto IL_1710;
		IL_12a2:
		num22 = num43 * num42;
		goto IL_1c23;
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_05c9: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I4
		//IL_00db: Expected VT, but got I4
		//IL_02a2: Expected Obj, but got I4
		//IL_0693: Invalid comparison between F4 and I4
		//IL_0731: Expected Obj, but got I
		//IL_075b: Expected Obj, but got I4
		//IL_060e: Expected F4, but got VT
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Expected Obj, but got Unknown
		//IL_0638: Expected Obj, but got I4
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected Obj, but got Unknown
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected Obj, but got Unknown
		//IL_010a: Expected F8, but got I4
		//IL_046f: Invalid comparison between F4 and I4
		//IL_0480: Expected Obj, but got I4
		//IL_0489: Invalid comparison between F4 and I4
		//IL_04a4: Expected Obj, but got I4
		//IL_0309: Invalid comparison between F4 and I4
		//IL_0318: Expected F8, but got I4
		//IL_017e: Expected F4, but got I
		//IL_018e: Expected F4, but got I
		//IL_0774: Invalid comparison between F4 and I4
		//IL_06c4: Expected F4, but got I
		//IL_06e0: Invalid comparison between F4 and I
		//IL_013b: Expected VT, but got I4
		//IL_014f: Expected F4, but got I4
		//IL_0160: Expected F4, but got I4
		//IL_052f: Expected Obj, but got I4
		//IL_0798: Expected Obj, but got I
		//IL_07b0: Expected Obj, but got I
		//IL_07ee: Expected I4, but got I8
		//IL_0808: Expected Obj, but got I4
		//IL_0261: Expected VT, but got I4
		//IL_026a: Expected Obj, but got I4
		//IL_0273: Expected VT, but got I4
		//IL_03ab: Expected I4, but got I8
		//IL_03c5: Expected Obj, but got I4
		//IL_0408: Expected Obj, but got I4
		//IL_03f2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
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
		float deltaTime = Time.deltaTime;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = display != null;
		bool flag4 = !flag3;
		object obj7 = 0;
		Vector3 vector = (Vector3)0;
		float num = deltaTime;
		float num15;
		float num14;
		if (!flag4)
		{
			double num2 = (featured ? 25.0 : 1108082688.0);
			float num3 = deltaTime * (float)num2;
			display.Rotate(0f, num3, 0f, (Space)0);
			float num4 = (float)displayRest;
			object obj8 = displayRest & 0x7FFFFFFF;
			bool flag5 = (nint)obj8 < 2139095040;
			object obj9 = !flag5;
			object obj10 = obj8 - 2139095040;
			bool flag6 = obj10 == null;
			object obj11 = ~obj9;
			object obj12 = obj11 | flag6;
			float num5;
			float num6;
			if (obj12 == null)
			{
				Vector3 localPosition = display.localPosition;
				displayRest = (Vector3)0;
				_ = 0;
				num5 = 0f;
				num6 = num3;
				num4 = 0f;
				Space space = (Space)0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ShopStand)+138]");
				num6 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ShopStand)+13C]");
				num5 = 0f;
				Space space = (Space)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj13 = 0;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v30+A0]");
			object obj15 = 0;
			float time = Time.time;
			float num7 = time;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A80C]");
			float num8 = num7 * 0f;
			float num9 = num8 + (float)index;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			float num10 = bob * num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v31+20]");
			float num11 = 0f * num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v31+1C]");
			float num12 = 0f * num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v31+18]");
			float num13 = 0f * num10;
			num14 = num5 + num11;
			num15 = num6 + num12;
			num = num4 + num13;
			display.localPosition = (Vector3)0;
			obj7 = 0;
			vector = (Vector3)0;
		}
		object obj16 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(slide != null))
		{
			goto IL_067e;
		}
		SlideOrb slideOrb = slide;
		bool flag8 = slideOrb.x < 0f;
		double num16 = 0.0;
		if (!flag8)
		{
			bool flag9 = !((double)slideOrb.x > 1.0);
			num16 = slideOrb.x;
			if (!flag9)
			{
				num16 = 1.0;
			}
		}
		num15 = along;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A884]");
		num14 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num17 = along;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A884]");
		if (!(num17 > 0f) && slideOrb.hand == hand)
		{
			int num18 = (int)(slideOrb.hand & 0x80000000L);
			bool flag10 = num18 == 0;
			object obj18 = !flag10;
			object obj20;
			if (obj18 == null)
			{
				bool flag11 = !slideOrb.snapped;
				object obj19 = !flag11;
				obj20 = obj19;
			}
			else
			{
				obj20 = 0;
			}
			if ((atEnd ? 1 : 0) == (nint)obj20)
			{
				goto IL_07be;
			}
		}
		dirty = true;
		goto IL_07be;
		IL_07be:
		along = (float)num16;
		hand = slideOrb.hand;
		int num19 = (int)(slideOrb.hand & 0x80000000L);
		bool flag12 = num19 == 0;
		object obj21 = !flag12;
		bool flag15;
		if (obj21 == null)
		{
			bool flag13 = !slideOrb.snapped;
			bool flag14 = !flag13;
			flag15 = flag14;
		}
		else
		{
			flag15 = false;
		}
		atEnd = flag15;
		goto IL_067e;
		IL_067e:
		float num20 = message;
		if (message > 0f)
		{
			num20 -= deltaTime;
			bool flag16 = num20 < 0f;
			object obj22 = !flag16;
			bool flag17 = num20 == 0f;
			message = num20;
			object obj23 = !flag17;
			object obj24 = obj22 & obj23;
			if (obj24 == null)
			{
				dirty = true;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj25 = 0;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v19+E4]");
		bool flag18 = (nint)0 == 0;
		object obj27 = !flag18;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int balance = Coins.Balance;
		if (balance != lastBalance)
		{
			object obj28 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X0_v27+E4]");
			bool flag19 = (nint)0 == 0;
			object obj29 = !flag19;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int balance2 = Coins.Balance;
			lastBalance = balance2;
			dirty = true;
		}
		if (!(burstT < 0f))
		{
			Burst(deltaTime);
		}
		if (~(dirty ? 1u : 0u) == 0)
		{
			Draw();
		}
	}

	private void Drop(int with)
	{
		//IL_098e: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I4
		//IL_093b: Expected F4, but got I
		//IL_0310: Expected Obj, but got I4
		//IL_05d3: Expected Obj, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_0091: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I4
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01dc: Expected Obj, but got I
		//IL_0200: Expected Obj, but got I
		//IL_0240: Expected Obj, but got I4
		//IL_062b: Expected Obj, but got I4
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected Obj, but got Unknown
		//IL_052d: Expected Obj, but got I
		//IL_0551: Expected Obj, but got I
		//IL_0591: Expected Obj, but got I4
		//IL_065a: Expected I4, but got I8
		//IL_0379: Expected Obj, but got I
		//IL_03a3: Expected Obj, but got I4
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected Obj, but got Unknown
		//IL_0867: Expected Obj, but got I
		//IL_088b: Expected Obj, but got I
		//IL_08cb: Expected Obj, but got I4
		//IL_0a2b: Expected F4, but got I
		//IL_02b5: Expected F4, but got I
		//IL_02c5: Expected F4, but got I
		//IL_068b: Expected Obj, but got I
		//IL_06b5: Expected Obj, but got I4
		//IL_0410: Expected F4, but got I
		//IL_044f: Expected F4, but got I
		//IL_044f: Expected F4, but got I
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected Obj, but got Unknown
		//IL_046a: Expected Obj, but got I
		//IL_0493: Expected Obj, but got I
		//IL_04d3: Expected Obj, but got I4
		//IL_0724: Expected F4, but got I
		//IL_0763: Expected F4, but got I
		//IL_0763: Expected F4, but got I
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected Obj, but got Unknown
		//IL_077e: Expected Obj, but got I
		//IL_07a7: Expected Obj, but got I
		//IL_07e7: Expected Obj, but got I4
		//IL_09f0: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj = 0;
		Coins.Bundle bundle = Bundle;
		int coins;
		int num2;
		float volume;
		int coins2;
		string label;
		int num4;
		if (bundle != null)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v56+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Coins.OwnsAll(bundle))
			{
				object obj4 = this + 280;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA58]");
				object obj5 = 0;
				messageText = (string)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9C8]");
				object obj6 = 0;
				messageBad = false;
				message = 2f;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v86+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				WearAll(bundle);
				goto IL_026e;
			}
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v60+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = Coins.PriceOf(bundle);
			if (!Coins.Buy(bundle))
			{
				object obj11 = this + 280;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF310]");
				object obj12 = 0;
				messageText = (string)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
				object obj13 = 0;
				messageBad = true;
				message = 2f;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v68+E4]");
				bool flag4 = (nint)0 == 0;
				object obj15 = !flag4;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				coins = num;
				num2 = with;
				goto IL_0a05;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9C8]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v72+E4]");
			bool flag5 = (nint)0 == 0;
			object obj18 = !flag5;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			WearAll(bundle);
			SlideOrb slideOrb = slide;
			if ((object)slide != null)
			{
				slideOrb.popT = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				volume = 0f;
				slideOrb.x = 0f;
				slideOrb.v = 0f;
				SlideOrb slideOrb2 = slide;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
				slideOrb2.Buzz((float)num3, 0f);
				object obj19 = this + 280;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA50]");
				object obj20 = 0;
				messageText = (string)obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
				object obj21 = 0;
				messageBad = false;
				message = 2f;
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v78+E4]");
				bool flag6 = (nint)0 == 0;
				object obj23 = !flag6;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				coins2 = num;
				label = bundle.label;
				num4 = with;
				goto IL_09c7;
			}
		}
		else
		{
			CosmeticCatalog.Entry entry = CosmeticCatalog.Of(id);
			if (entry == null)
			{
				goto IL_0902;
			}
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v21+E4]");
			bool flag7 = (nint)0 == 0;
			object obj25 = !flag7;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Coins.Owns(id))
			{
				object obj26 = this + 280;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA58]");
				object obj27 = 0;
				messageText = (string)obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
				object obj28 = 0;
				messageBad = false;
				object obj29 = obj28;
				message = 2f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v51+E4]");
				bool flag8 = (nint)0 == 0;
				object obj30 = !flag8;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cosmetics.Wear(id);
				goto IL_026e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			IEnumerable<byte> enumerable = default;
			if (enumerable != null)
			{
				_ = id;
				object obj32 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v27+E4]");
				bool flag9 = (nint)0 == 0;
				object obj33 = !flag9;
				if (obj33 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!Coins.Buy(enumerable, -1))
				{
					object obj34 = this + 280;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF310]");
					object obj35 = 0;
					messageText = (string)obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
					object obj36 = 0;
					messageBad = true;
					message = 2f;
					object obj37 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X0_v33+E4]");
					bool flag10 = (nint)0 == 0;
					object obj38 = !flag10;
					if (obj38 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					coins = entry.price;
					num2 = with;
					goto IL_0a05;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
				object obj39 = 0;
				object obj40 = obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v37+E4]");
				bool flag11 = (nint)0 == 0;
				object obj41 = !flag11;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cosmetics.Wear(id);
				SlideOrb slideOrb3 = slide;
				if ((object)slide != null)
				{
					slideOrb3.popT = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
					volume = 0f;
					slideOrb3.x = 0f;
					slideOrb3.v = 0f;
					SlideOrb slideOrb4 = slide;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
					slideOrb4.Buzz((float)num5, 0f);
					object obj42 = this + 280;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA50]");
					object obj43 = 0;
					messageText = (string)obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
					object obj44 = 0;
					messageBad = false;
					message = 2f;
					object obj45 = obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v43+E4]");
					bool flag12 = (nint)0 == 0;
					object obj46 = !flag12;
					if (obj46 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					coins2 = entry.price;
					label = entry.label;
					num4 = with;
					goto IL_09c7;
				}
			}
		}
		goto IL_0969;
		IL_0902:
		SlideOrb slideOrb5 = slide;
		if ((object)slide == null)
		{
			goto IL_0969;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
		float seconds = 0f;
		slideOrb5.shake = 0.45f;
		slideOrb5.v = -2f;
		float amplitude = 0.5f;
		goto IL_09b5;
		IL_026e:
		slideOrb5 = slide;
		if ((object)slide == null)
		{
			goto IL_0969;
		}
		slideOrb5.popT = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		amplitude = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		seconds = 0f;
		slideOrb5.x = 0f;
		slideOrb5.v = 0f;
		goto IL_09b5;
		IL_09c7:
		GillaToast.Bought(num4, label, coins2);
		AudioClip clip = buySound;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		Play(clip, 0f);
		Play(coinSound, volume);
		Play(sparkleSound, 0.5f);
		burstT = 0f;
		return;
		IL_09b5:
		slideOrb5.Buzz(amplitude, seconds);
		return;
		IL_0a05:
		GillaToast.NotEnough(num2, coins);
		AudioClip clip2 = errorSound;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		Play(clip2, 0f);
		goto IL_0902;
		IL_0969:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private unsafe static void WearAll(Coins.Bundle b)
	{
		//IL_0017: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got I4
		//IL_023e: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I4
		//IL_0124: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I4
		//IL_00ea: Expected Obj, but got Ref
		//IL_017a: Expected Obj, but got I4
		List<byte> list = CosmeticCatalog.IdsOf(b);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4728]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4720]");
		object obj3 = 0;
		Enumerator<, > enumerator = list.GetEnumerator();
		Enumerator<, > val = default;
		while (val.MoveNext())
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cosmetics.Wear(0);
		}
		object obj6 = 0;
		object obj7 = 0;
		Enumerator<, > val2 = (Enumerator<, >)(ref val);
		object obj8 = 0;
		object obj12 = default;
		object obj13 = default;
		object obj14 = default;
		while (true)
		{
			object obj9 = obj3;
			val.Dispose();
			bool flag2 = obj8 == null;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				bool flag3 = obj6 == null;
				object obj11 = !flag3;
				OutOfMemoryException ex = (OutOfMemoryException)(&val);
				if (obj11 == null)
				{
					return;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				obj6 = obj12;
				obj7 = obj13;
				obj9 = 0;
				obj3 = 109895680;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)obj9 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj6 = 1;
				obj8 = obj7;
				continue;
			}
			if ((nint)obj9 != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			obj8 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj7 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CEFC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	private void Say(string s, bool bad)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		messageText = s;
		object obj = this + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		messageBad = bad;
		message = 2f;
		dirty = true;
	}

	private void Burst(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0361: Expected Obj, but got I4
		//IL_008f: Invalid comparison between F4 and I4
		//IL_009e: Expected F8, but got I4
		//IL_010b: Invalid comparison between F8 and I4
		//IL_03b0: Invalid comparison between F8 and I4
		//IL_03bf: Expected F8, but got I4
		//IL_0187: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I
		//IL_0220: Expected VT, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_024d: Expected Obj, but got I4
		//IL_02b2: Expected Obj, but got I
		//IL_02c4: Expected VT, but got I4
		//IL_026b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		float num = dt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		float num2 = num / 0f;
		float num3 = num2 + burstT;
		burstT = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (burst == null)
		{
			if ((double)burstT < 1.0)
			{
				return;
			}
		}
		else
		{
			bool flag2 = burstT < 0f;
			double num4 = 0.0;
			if (!flag2)
			{
				bool flag3 = !((double)burstT > 1.0);
				num4 = burstT;
				if (!flag3)
				{
					num4 = 1.0;
				}
			}
			double num5 = num4 - 1.0;
			bool flag4 = num5 < 0.0;
			burst.enabled = flag4;
			Transform transform = burst.transform;
			double num6 = 1.0 - num4;
			double num7 = num6 * num6;
			double num8 = 1.0 - num7;
			bool flag5 = num8 < 0.0;
			double num9 = 0.0;
			if (!flag5)
			{
				bool flag6 = !(num8 > 1.0);
				num9 = num8;
				if (!flag6)
				{
					num9 = 1.0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj4 = 0;
			double num10 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADAC]");
			double num11 = num10 * 0.0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v12+A0]");
			object obj6 = 0;
			double num12 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			double num13 = num12 + 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v13+14]");
			double num14 = 0.0 * num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v13+10]");
			double num15 = 0.0 * num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v13+C]");
			double num16 = 0.0 * num13;
			transform.localScale = (Vector3)0;
			object obj7 = this + 248;
			MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)obj7;
			bool flag7 = obj7 == null;
			object obj8 = !flag7;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				MaterialPropertyBlock materialPropertyBlock2 = default;
				materialPropertyBlock2._002Ector();
				obj7 = materialPropertyBlock2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				materialPropertyBlock = (MaterialPropertyBlock)obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
			object obj10 = 0;
			materialPropertyBlock.SetColor((string)obj10, (Color)0);
			burst.SetPropertyBlock(block);
			if ((double)burstT < 1.0)
			{
				return;
			}
		}
		burstT = -1f;
	}

	private void Play(AudioClip clip, float volume)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0186: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00e4: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I4
		//IL_0145: Expected VT, but got I4
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		AudioClip[] array = default;
		if (array != null)
		{
			object obj5 = array + 32;
			obj5 = clip;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if ((object)orb != null)
			{
				Vector3 position = orb.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v17+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float pitchMin = default;
				float pitchMax = default;
				Sfx.Play(array, (Vector3)0, volume, pitchMin, pitchMax);
				return;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private unsafe void Draw()
	{
		//IL_0010: Expected Obj, but got I
		//IL_122d: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_00f2: Expected VT, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_0914: Expected VT, but got I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0975: Invalid comparison between F8 and I4
		//IL_0984: Invalid comparison between F8 and I4
		//IL_099e: Expected Obj, but got F8
		//IL_09ad: Expected Obj, but got F8
		//IL_09e2: Expected Obj, but got I4
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ef: Expected Obj, but got Unknown
		//IL_02c1: Expected Obj, but got I4
		//IL_160d: Expected Obj, but got I4
		//IL_1618: Invalid comparison between F4 and I4
		//IL_15f2: Expected Obj, but got I4
		//IL_02f0: Expected VT, but got I4
		//IL_1534: Expected Obj, but got I
		//IL_1556: Expected VT, but got I8
		//IL_1569: Expected VT, but got I8
		//IL_1595: Expected VT, but got I8
		//IL_15b2: Expected I4, but got I8
		//IL_0183: Expected Obj, but got I4
		//IL_1bbd: Expected Obj, but got I
		//IL_1be7: Expected Obj, but got I4
		//IL_0a30: Expected F8, but got I4
		//IL_01ed: Expected Obj, but got I4
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected I4, but got Unknown
		//IL_0256: Expected Obj, but got I4
		//IL_1268: Expected Obj, but got I
		//IL_1278: Expected Obj, but got I
		//IL_1288: Expected Obj, but got I
		//IL_12c0: Expected Obj, but got I
		//IL_0a57: Invalid comparison between F8 and I4
		//IL_1364: Expected Obj, but got I4
		//IL_130c: Expected Obj, but got I4
		//IL_1aee: Expected Obj, but got I
		//IL_1b1a: Expected Obj, but got I
		//IL_16bc: Expected Obj, but got F8
		//IL_16c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c9: Expected Obj, but got Unknown
		//IL_16eb: Expected Obj, but got I4
		//IL_0658: Expected Obj, but got I
		//IL_0682: Expected Obj, but got I4
		//IL_1c05: Expected Obj, but got I
		//IL_1c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c17: Expected VT, but got Unknown
		//IL_1c29: Expected VT, but got I8
		//IL_166a: Unknown result type (might be due to invalid IL or missing references)
		//IL_166f: Expected Obj, but got Unknown
		//IL_1689: Expected Obj, but got I4
		//IL_034b: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I4
		//IL_06c9: Expected Obj, but got I4
		//IL_03c9: Expected Obj, but got I4
		//IL_0bf8: Expected Obj, but got I4
		//IL_1743: Expected Obj, but got I
		//IL_0bb1: Expected Obj, but got I4
		//IL_0760: Expected Obj, but got I
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected I4, but got Unknown
		//IL_043a: Expected Obj, but got I4
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected I4, but got Unknown
		//IL_04a3: Expected Obj, but got I4
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected Obj, but got Unknown
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got Unknown
		//IL_04d8: Expected Obj, but got I4
		//IL_04f9: Expected Obj, but got I
		//IL_1c57: Expected VT, but got Obj
		//IL_1c6e: Expected VT, but got Obj
		//IL_1728: Expected Obj, but got I
		//IL_07d5: Expected Obj, but got I4
		//IL_072b: Expected Obj, but got I4
		//IL_1118: Expected Obj, but got I
		//IL_112b: Expected Obj, but got I4
		//IL_0cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cde: Expected Obj, but got Unknown
		//IL_144a: Expected Obj, but got I4
		//IL_07b6: Expected Obj, but got I4
		//IL_139e: Expected Obj, but got I
		//IL_13ae: Expected Obj, but got I
		//IL_13be: Expected Obj, but got I
		//IL_1157: Expected Obj, but got I
		//IL_0535: Expected Obj, but got I
		//IL_0556: Expected Obj, but got I
		//IL_0566: Expected Obj, but got I
		//IL_17f2: Expected Obj, but got I
		//IL_181c: Expected Obj, but got I4
		//IL_0c47: Expected Obj, but got I4
		//IL_1ba8: Expected VT, but got Obj
		//IL_1c9d: Expected Obj, but got I
		//IL_1758: Expected Obj, but got I
		//IL_1768: Expected VT, but got I
		//IL_1788: Expected VT, but got I
		//IL_178e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1793: Expected Obj, but got Unknown
		//IL_146a: Unknown result type (might be due to invalid IL or missing references)
		//IL_146f: Expected I4, but got Unknown
		//IL_148e: Expected Obj, but got I
		//IL_14b8: Expected Obj, but got I4
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected Obj, but got Unknown
		//IL_11c5: Expected Obj, but got I4
		//IL_10dd: Expected Obj, but got I4
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Expected Obj, but got Unknown
		//IL_1ac1: Expected Obj, but got I
		//IL_117e: Expected Obj, but got I4
		//IL_1b70: Expected Obj, but got I4
		//IL_05c5: Expected Obj, but got I4
		//IL_05d3: Expected Obj, but got I4
		//IL_0624: Expected Obj, but got I4
		//IL_0d40: Expected Obj, but got I
		//IL_0c84: Expected Obj, but got I
		//IL_0cae: Expected Obj, but got I4
		//IL_08b8: Expected Obj, but got I4
		//IL_1aa6: Expected Obj, but got I
		//IL_19f4: Expected Obj, but got I
		//IL_1a12: Expected Obj, but got I
		//IL_1a41: Expected Obj, but got I
		//IL_137b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1380: Expected I4, but got Unknown
		//IL_1389: Expected Obj, but got I4
		//IL_0d2b: Expected Obj, but got I
		//IL_1840: Expected Obj, but got I
		//IL_14cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d4: Expected I4, but got Unknown
		//IL_14ea: Expected Obj, but got I
		//IL_0869: Expected Obj, but got I4
		//IL_0dae: Expected Obj, but got I4
		//IL_188f: Expected Obj, but got I
		//IL_0d67: Expected Obj, but got I4
		//IL_1d1a: Expected I4, but got I8
		//IL_1874: Expected Obj, but got I
		//IL_0eeb: Invalid comparison between F4 and I4
		//IL_0de3: Expected F8, but got I
		//IL_0df5: Invalid comparison between F4 and I
		//IL_0e06: Expected Obj, but got I4
		//IL_0e28: Invalid comparison between F4 and I4
		//IL_0e39: Expected Obj, but got I4
		//IL_0f12: Expected Obj, but got I
		//IL_0f3c: Expected Obj, but got I4
		//IL_0f83: Expected Obj, but got I4
		//IL_0ebb: Expected Obj, but got I4
		//IL_193f: Expected Obj, but got I
		//IL_1957: Expected VT, but got I8
		//IL_1957: Expected VT, but got I8
		//IL_18a4: Expected Obj, but got I
		//IL_18c2: Expected Obj, but got I
		//IL_18d2: Expected Obj, but got I
		//IL_1907: Expected Obj, but got I
		//IL_1011: Expected Obj, but got I4
		//IL_19a9: Expected Obj, but got I
		//IL_0fca: Expected Obj, but got I4
		//IL_1d8c: Expected VT, but got I8
		//IL_1d8c: Expected VT, but got I8
		//IL_198e: Expected Obj, but got I
		//IL_109f: Expected Obj, but got I4
		//IL_19df: Expected Obj, but got I
		//IL_1058: Expected Obj, but got I4
		//IL_19c4: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj = 0;
		object obj2 = obj;
		dirty = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9C8]");
		object obj4 = 0;
		GillaBoardLook.Clear(px, 256, 128);
		GillaBoardLook.Frame(px, 256, 128, 3);
		CosmeticCatalog.Entry entry = CosmeticCatalog.Of(id);
		Coins.Bundle bundle = Bundle;
		bool flag2;
		object obj5;
		int num;
		int num2;
		Vector3 vector;
		if (bundle != null)
		{
			flag2 = bundle.realMoney;
			obj5 = bundle + 24;
		}
		else
		{
			bool flag3 = entry == null;
			string text = null;
			num = 3;
			num2 = 128;
			vector = (Vector3)0;
			if (flag3)
			{
				goto IL_08dd;
			}
			obj5 = entry + 24;
			flag2 = false;
		}
		if (obj5 != null)
		{
			bool flag4 = (byte)(~(featured ? 1u : 0u)) != 0;
			Color32[] array2 = default;
			Color32[] array = array2;
			string text2 = null;
			int num3 = 3;
			int num4 = 128;
			ScreenFont screenFont = null;
			bool flag6;
			int num5;
			if (!flag4)
			{
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v87+E4]");
				bool flag5 = (nint)0 == 0;
				object obj7 = !flag5;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v87+A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA48]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v66+28]");
				array = (Color32[])0;
				text2 = (string)obj9;
				ScreenFont font = this.text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v66+28]");
				Text(font, 128, 6, (string)obj9, (Color32[])0, 1, centred: true);
				flag6 = true;
				num5 = 1;
				num3 = 6;
				num4 = 128;
				screenFont = this.text;
			}
			ScreenFont screenFont2;
			int num10;
			int num11;
			if (title != null)
			{
				int num6 = title.Measure((string)obj5, 2);
				object obj10 = num6 - 245;
				bool flag7 = (nint)obj10 < 0;
				int num7 = num6 ^ 0xF5;
				int num8 = num6 ^ obj10;
				int num9 = num7 & num8;
				bool flag8 = num9 < 0;
				screenFont2 = title;
				bool flag9 = flag7 == flag8;
				object obj11 = !flag9;
				object obj12 = ~obj11;
				num10 = ((obj12 != null) ? 1 : (1 + 1));
				bool flag10 = flag7 == flag8;
				object obj13 = !flag10;
				object obj14 = ~obj13;
				num11 = ((obj14 != null) ? 15 : 10);
				num3 = 0;
				num4 = 2;
				screenFont = (ScreenFont)obj5;
			}
			else
			{
				num10 = 2;
				num11 = 10;
				screenFont2 = null;
			}
			object obj15 = obj4;
			if (featured)
			{
				num11 = 16;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X0_v16+E4]");
			bool flag11 = (nint)0 == 0;
			object obj16 = !flag11;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X0_v16+A0]");
			object obj17 = 0;
			ScreenFont font2 = screenFont2;
			int y = num11;
			object s = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v11+20]");
			Text(font2, 128, y, (string)s, (Color32[])0, num10, centred: true);
			bool flag16;
			if (bundle != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
				object obj18 = 0;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X0_v50+E4]");
				bool flag12 = (nint)0 == 0;
				object obj20 = !flag12;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag13 = Coins.OwnsAll(bundle);
				object obj21 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v38+E4]");
				bool flag14 = (nint)0 == 0;
				object obj22 = !flag14;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num12 = Coins.PriceOf(bundle);
				bool flag15 = !flag2;
				flag16 = flag13;
				ScreenFont screenFont3 = null;
				if (!flag15)
				{
					int num13 = bundle + 44;
					object obj23 = ((int*)num13)->m_value - 1;
					bool flag17 = (nint)obj23 < 0;
					int num14 = ((int*)num13)->m_value ^ 1;
					int num15 = ((int*)num13)->m_value ^ obj23;
					int num16 = num14 & num15;
					bool flag18 = num16 < 0;
					bool flag19 = flag17 == flag18;
					object obj24 = !flag19;
					object obj25 = obj24 | flag13;
					object obj26 = obj25 & 1;
					bool flag20 = obj26 == null;
					object obj27 = !flag20;
					bool flag21 = true;
					int num17 = num10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v11+20]");
					Color32[] array3 = (Color32[])0;
					string text3 = (string)obj5;
					int num18 = num11;
					int num19 = 128;
					ScreenFont screenFont4 = null;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
						object obj28 = 0;
						string text4 = ((int*)num13)->ToString((string)obj28);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60E0]");
						object obj29 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6150]");
						object obj30 = 0;
						string text5 = (string)obj29 + text4 + (string)obj30;
						int num21;
						if (this.text != null)
						{
							int num20 = this.text.Measure(text5, 2);
							object obj31 = num20 + 20;
							object obj32 = num20 + 21;
							bool flag22 = (nint)obj31 < 0;
							object obj33 = obj31 ^ obj31;
							object obj34 = obj31 & obj33;
							bool flag23 = (nint)obj34 < 0;
							bool flag24 = flag22 == flag23;
							object obj35 = !flag24;
							object obj36 = ~obj35;
							if (obj36 == null)
							{
								obj31 = obj32;
							}
							num21 = 128 - obj31;
							object obj37 = 0;
						}
						else
						{
							num21 = 68;
							object obj37 = 0;
						}
						CoinIcon(num21, 44);
						object obj38 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1041 @ X0_v74+E4]");
						bool flag25 = (nint)0 == 0;
						object obj39 = !flag25;
						if (obj39 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj38 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1041 @ X0_v74+A0]");
						object obj40 = 0;
						num19 = num21 + 20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v62+30]");
						array3 = (Color32[])0;
						ScreenFont font3 = this.text;
						int x = num19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v62+30]");
						Text(font3, x, 42, text5, (Color32[])0, 2, centred: false);
						flag21 = false;
						num17 = 2;
						text3 = text5;
						num18 = 42;
						screenFont4 = this.text;
					}
					bool flag26 = !flag13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4E0]");
					object s2 = 0;
					object obj41 = obj4;
					object obj42 = !flag26;
					object obj43 = ~obj42;
					if (obj43 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF6D8]");
						s2 = 0;
					}
					object colours;
					if (flag13)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X0_v61+E4]");
						bool flag27 = (nint)0 == 0;
						object obj44 = !flag27;
						if (obj44 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj41 = obj4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X0_v61+A0]");
						colours = (nint)0 + (nint)40;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X0_v61+E4]");
						bool flag28 = (nint)0 == 0;
						object obj45 = !flag28;
						if (obj45 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj41 = obj4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X0_v61+A0]");
						colours = (nint)0 + (nint)32;
					}
					Text(this.text, 128, 82, (string)s2, (Color32[])colours, 2, centred: true);
					goto IL_11ea;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
				object obj46 = 0;
				object obj47 = obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X0_v44+E4]");
				bool flag29 = (nint)0 == 0;
				object obj48 = !flag29;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag30 = Coins.Owns(id);
				bool flag31 = !flag2;
				object obj49 = !flag31;
				flag16 = flag30;
				ScreenFont screenFont3 = null;
				if (obj49 != null)
				{
					throw new NullReferenceException();
				}
			}
			string text;
			ScreenFont screenFont5;
			if (flag16)
			{
				object obj50 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v40+E4]");
				bool flag32 = (nint)0 == 0;
				object obj51 = !flag32;
				if (obj51 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj50 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v40+A0]");
				object obj52 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4E0]");
				object obj53 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X8_v31+28]");
				array2 = (Color32[])0;
				text = (string)obj53;
				flag6 = true;
				num5 = 2;
				num = 42;
				num2 = 128;
				screenFont5 = this.text;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
				object obj54 = 0;
				int num22 = default;
				string text6 = num22.ToString((string)obj54);
				object obj55;
				if (this.text != null)
				{
					int num23 = this.text.Measure(text6, 2);
					obj55 = num23 + 20;
					int num24 = 0;
				}
				else
				{
					int num24 = num11;
					obj55 = 56;
				}
				bool flag33 = (nint)obj55 < 0;
				object obj56 = obj55 ^ obj55;
				object obj57 = obj55 & obj56;
				bool flag34 = (nint)obj57 < 0;
				bool flag35 = flag33 == flag34;
				object obj58 = !flag35;
				object obj59 = ~obj58;
				object obj60 = ((obj59 != null) ? obj55 : ((object)(obj55 + 1)));
				int x2 = 128 - obj60;
				CoinIcon(x2, 44);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
				object obj61 = 0;
				object obj62 = obj61;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ X0_v24+E4]");
				bool flag36 = (nint)0 == 0;
				object obj63 = !flag36;
				if (obj63 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj64 = 0 - obj60;
				int balance = Coins.Balance;
				if (balance < num22)
				{
					object obj65 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X0_v28+E4]");
					bool flag37 = (nint)0 == 0;
					object obj66 = !flag37;
					if (obj66 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj65 = obj4;
					}
				}
				else
				{
					object obj65 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X0_v28+E4]");
					bool flag38 = (nint)0 == 0;
					object obj67 = !flag38;
					if (obj67 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj65 = obj;
					}
				}
				num2 = obj64 + 148;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X0_v28+A0]");
				object obj68 = (nint)0 + (nint)48;
				array2 = (Color32[])obj68;
				flag6 = false;
				num5 = 2;
				text = text6;
				num = 42;
				screenFont5 = this.text;
			}
			Text(screenFont5, num2, num, text, array2, num5, flag6);
			vector = (Vector3)screenFont5;
		}
		else
		{
			bool flag39 = !flag2;
			object obj69 = !flag39;
			if (obj69 != null)
			{
				goto IL_11ea;
			}
			string text = null;
			num = 3;
			num2 = 128;
			vector = (Vector3)0;
		}
		goto IL_08dd;
		IL_08dd:
		int num25 = Track(vector);
		int num26 = Track(vector);
		bool flag40 = num25 > num26;
		Color32 color = (Color32)num2;
		RectInt rectInt = (RectInt)vector;
		if (!flag40)
		{
			int num27 = num25;
			int num28 = num;
			bool flag42;
			do
			{
				object obj70 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v181+E4]");
				bool flag41 = (nint)0 == 0;
				object obj71 = !flag41;
				if (obj71 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj70 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v181+A0]");
				object obj72 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v135+C]");
				num = 0;
				rectInt = (RectInt)(num27 | 0x5C00000000L);
				FillRect(rectInt, (Color32)8589934594L);
				num27 += 4;
				flag42 = num27 <= num26;
				color = (Color32)8589934594L;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v135+C]");
				num28 = 0;
				num2 = 2;
				vector = (Vector3)rectInt;
			}
			while (flag42);
		}
		double num29 = (double)along - 1.0;
		bool flag43 = num29 < 0.0;
		bool flag44 = num29 == 0.0;
		object obj73 = (double)along ^ 1.0;
		object obj74 = (double)along ^ num29;
		object obj75 = obj73 & obj74;
		bool flag45 = (nint)obj75 < 0;
		bool flag46 = flag43 == flag45;
		object obj76 = !flag46;
		object obj77 = obj76 | flag44;
		object obj78 = ~obj77;
		double num30 = ((obj78 != null) ? 1.0 : ((double)along));
		object obj79 = num26 - num25;
		if (along < 0f)
		{
			num30 = 0.0;
		}
		double num31 = (double)obj79 * num30;
		double num32 = num31 + (double)num25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj80 = 0;
		object obj81 = obj80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X0_v98+E4]");
		bool flag47 = (nint)0 == 0;
		object obj82 = !flag47;
		if (obj82 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num33;
		double num34;
		double num35 = default;
		double num36;
		if (num32 < 0.0)
		{
			if (num32 == -0.5)
			{
				num33 = -1.0;
				num34 = num35;
				goto IL_1652;
			}
			num34 = num32 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num36 = -0.5;
		}
		else
		{
			if (num32 == 0.5)
			{
				num33 = 1.0;
				num34 = num35;
				goto IL_1652;
			}
			num34 = num32 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num36 = 0.5;
		}
		goto IL_169c;
		IL_169c:
		object obj83 = obj4;
		double num37 = num34 - (double)num25;
		object obj84 = ~num37;
		object obj85 = num37 & obj84;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v103+E4]");
		bool flag48 = (nint)0 == 0;
		object obj86 = !flag48;
		if (obj86 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj83 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v103+A0]");
		object obj87 = 0;
		Color32 c = (Color32)(obj85 | 0x200000000L);
		RectInt r = (RectInt)(num25 | 0x5C00000000L);
		FillRect(r, c);
		object obj88 = obj4;
		int num38 = (atEnd ? 15 : 13);
		object obj90;
		if (~(atEnd ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v167+E4]");
			bool flag49 = (nint)0 == 0;
			object obj89 = !flag49;
			if (obj89 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj88 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v167+A0]");
			obj90 = (nint)0 + (nint)16;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v167+E4]");
			bool flag50 = (nint)0 == 0;
			object obj91 = !flag50;
			if (obj91 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj88 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v167+A0]");
			obj90 = (nint)0 + (nint)8;
		}
		Color32 color2 = (Color32)obj90;
		Circle(num26, 93, num38, (Color32)obj90);
		object obj95;
		ScreenFont font4;
		string s3;
		object colours2;
		if (~(atEnd ? 1u : 0u) == 0)
		{
			object obj92 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1067 @ X0_v159+E4]");
			bool flag51 = (nint)0 == 0;
			object obj93 = !flag51;
			if (obj93 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj92 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1067 @ X0_v159+A0]");
			object obj94 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X8_v121+10]");
			color2 = (Color32)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X8_v121+10]");
			Circle(num26, 93, 12, (Color32)0);
			obj95 = this + 240;
			font4 = (ScreenFont)obj95;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X24_v9+20]");
			bool flag52 = (nint)0 == 0;
			int num39 = 12;
			int num40 = 93;
			int num41 = num26;
			if (!flag52)
			{
				object obj96 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA40]");
				object obj97 = 0;
				s3 = (string)obj97;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1124 @ X0_v162+E4]");
				bool flag53 = (nint)0 == 0;
				object obj98 = !flag53;
				if (obj98 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj96 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1124 @ X0_v162+A0]");
				colours2 = (nint)0 + (nint)40;
				goto IL_1ca2;
			}
		}
		else
		{
			obj95 = this + 240;
			font4 = (ScreenFont)obj95;
			int num39 = num38;
			int num40 = 93;
			int num41 = num26;
		}
		object obj99 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA38]");
		object obj100 = 0;
		s3 = (string)obj100;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ X0_v155+E4]");
		bool flag54 = (nint)0 == 0;
		object obj101 = !flag54;
		if (obj101 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj99 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ X0_v155+A0]");
		colours2 = (nint)0 + (nint)32;
		goto IL_1ca2;
		IL_1ca2:
		Text(font4, num26, 66, s3, (Color32[])colours2, 1, centred: true);
		object obj102 = obj4;
		object obj103;
		if (!atEnd)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA28]");
			obj103 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA20]");
			obj103 = 0;
		}
		object obj105;
		if (~(atEnd ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X0_v147+E4]");
			bool flag55 = (nint)0 == 0;
			object obj104 = !flag55;
			if (obj104 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj102 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X0_v147+A0]");
			obj105 = (nint)0 + (nint)40;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X0_v147+E4]");
			bool flag56 = (nint)0 == 0;
			object obj106 = !flag56;
			if (obj106 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj102 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X0_v147+A0]");
			obj105 = (nint)0 + (nint)32;
		}
		Text(this.text, num26, 109, (string)obj103, (Color32[])obj105, 1, centred: true);
		int num42 = (int)(hand & 0x80000000L);
		bool flag57 = num42 == 0;
		bool flag58 = true;
		int num43 = 1;
		Color32[] array4 = (Color32[])obj105;
		string text7 = (string)obj103;
		int num44 = 109;
		int num45 = num26;
		ScreenFont screenFont6 = this.text;
		if (!flag57)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			num36 = 0.0;
			float num46 = along;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			bool flag59 = num46 < 0f;
			object obj107 = !flag59;
			float num47 = along;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			float num48 = num47 - 0f;
			bool flag60 = num48 == 0f;
			object obj108 = !flag60;
			object obj109 = obj107 & obj108;
			flag58 = true;
			num43 = 1;
			array4 = (Color32[])obj105;
			text7 = (string)obj103;
			num44 = 109;
			num45 = num26;
			screenFont6 = this.text;
			if (obj109 == null)
			{
				object obj110 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ X0_v143+E4]");
				bool flag61 = (nint)0 == 0;
				object obj111 = !flag61;
				if (obj111 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj110 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ X0_v143+A0]");
				object obj112 = 0;
				num45 = num25 + 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA30]");
				object obj113 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X8_v108+20]");
				array4 = (Color32[])0;
				text7 = (string)obj113;
				object font5 = obj95;
				int x3 = num45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X8_v108+20]");
				Text((ScreenFont)font5, x3, 112, (string)obj113, (Color32[])0, 1, centred: true);
				flag58 = true;
				num43 = 1;
				num44 = 112;
				screenFont6 = (ScreenFont)obj95;
			}
		}
		if (message > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			object obj114 = 0;
			object obj115 = obj114;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1241 @ X0_v116+E4]");
			bool flag62 = (nint)0 == 0;
			object obj116 = !flag62;
			if (obj116 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj117 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1272 @ X0_v119+E4]");
			bool flag63 = (nint)0 == 0;
			object obj118 = !flag63;
			if (obj118 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj117 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1272 @ X0_v119+A0]");
			object obj119 = 0;
			FillRect((RectInt)257698037780L, (Color32)77309411544L);
			object obj120 = obj4;
			if (~(messageBad ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v133+E4]");
				bool flag64 = (nint)0 == 0;
				object obj121 = !flag64;
				if (obj121 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj120 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v133+A0]");
				object obj122 = (nint)0 + (nint)12;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v133+E4]");
				bool flag65 = (nint)0 == 0;
				object obj123 = !flag65;
				if (obj123 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj120 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X0_v133+A0]");
				object obj122 = (nint)0 + (nint)8;
			}
			Outline((RectInt)257698037780L, (Color32)77309411544L);
			object obj124 = obj4;
			object colours3;
			if (~(messageBad ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1321 @ X0_v127+E4]");
				bool flag66 = (nint)0 == 0;
				object obj125 = !flag66;
				if (obj125 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj124 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1321 @ X0_v127+A0]");
				colours3 = (nint)0 + (nint)48;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1321 @ X0_v127+E4]");
				bool flag67 = (nint)0 == 0;
				object obj126 = !flag67;
				if (obj126 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj124 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1321 @ X0_v127+A0]");
				colours3 = (nint)0 + (nint)32;
			}
			Text(this.text, 128, 65, messageText, (Color32[])colours3, 1, centred: true);
			screenFont6 = this.text;
		}
		Finish();
		return;
		IL_1652:
		num36 = num34 + num33;
		object obj127 = num34 & 1;
		bool flag68 = obj127 == null;
		object obj128 = !flag68;
		if (obj128 != null)
		{
			num34 = num36;
		}
		goto IL_169c;
		IL_11ea:
		Finish();
	}

	private void Finish()
	{
		//IL_002b: Expected Obj, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I
		//IL_0157: Expected I4, but got Obj
		//IL_00a9: Expected I4, but got Obj
		tex.SetPixels32(px);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
		object obj = 0;
		tex.Apply(updateMipmaps: true);
		object obj2 = this + 248;
		bool flag = obj2 == null;
		object obj3 = !flag;
		bool flag2 = true;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			obj2 = materialPropertyBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			flag2 = (byte)(int)materialPropertyBlock != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		MaterialPropertyBlock materialPropertyBlock2 = default;
		materialPropertyBlock2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9C8]");
		object obj4 = 0;
		screen.GetPropertyBlock(materialPropertyBlock2);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v6+A0]");
		object obj8 = 0;
		materialPropertyBlock2.SetTexture((int)obj8, tex);
		screen.SetPropertyBlock(materialPropertyBlock2);
	}

	private int Track(Vector3 local)
	{
		//IL_01ef: Expected I4, but got Obj
		//IL_005d: Expected VT, but got I4
		//IL_008c: Expected VT, but got I4
		//IL_01ff: Expected Obj, but got I
		//IL_0229: Expected Obj, but got I4
		//IL_00db: Invalid comparison between F8 and I4
		//IL_029a: Invalid comparison between F8 and I4
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02bb: Expected Obj, but got F8
		//IL_02f0: Expected Obj, but got I4
		//IL_01dc: Expected F8, but got I4
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_026e: Expected Obj, but got I4
		//IL_0310: Expected Obj, but got F8
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected I4, but got Unknown
		double num3;
		double num4;
		if ((object)screen != null)
		{
			Transform transform = screen.transform;
			if ((object)trackFrame != null)
			{
				Vector3 vector = trackFrame.TransformPoint((Vector3)0);
				if ((object)transform != null)
				{
					Vector3 vector2 = transform.InverseTransformPoint((Vector3)0);
					object obj = default;
					double num = (double)obj + 0.5;
					double num2 = num * 1132462080.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj2 = 0;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
					bool flag = (nint)0 == 0;
					object obj4 = !flag;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
					double num5 = default;
					if (num2 < 0.0)
					{
						if (num2 == -0.5)
						{
							num3 = -1.0;
							num4 = num5;
							goto IL_0237;
						}
						num4 = num2 + -0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
					}
					else
					{
						if (num2 == 0.5)
						{
							num3 = 1.0;
							num4 = num5;
							goto IL_0237;
						}
						num4 = num2 + 0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					}
					goto IL_0281;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0237:
		double num6 = num4 + num3;
		object obj5 = num4 & 1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			num4 = num6;
		}
		goto IL_0281;
		IL_0281:
		double num7 = num4 - 255.0;
		bool flag3 = num7 < 0.0;
		object obj7 = num4 ^ 0xFF;
		object obj8 = num4 ^ num7;
		object obj9 = obj7 & obj8;
		bool flag4 = (nint)obj9 < 0;
		bool flag5 = flag3 == flag4;
		object obj10 = !flag5;
		object obj11 = ~obj10;
		double num8 = ((obj11 != null) ? 255.0 : num4);
		object obj12 = ~num8;
		return num8 & obj12;
	}

	private unsafe void Text(ScreenFont font, int x, int y, string s, Color32[] colours, int scale, bool centred = default(bool))
	{
		//IL_0044: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got Ref
		if (font == null)
		{
			return;
		}
		bool flag = string.IsNullOrEmpty(s);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			ShiftAuth.Style style = default;
			object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref style, 16));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			ShiftAuth.Style s2 = default;
			if (centred)
			{
				int num = font.DrawCentred(px, 256, 128, x, y, s, ref s2);
			}
			else
			{
				int num2 = font.Draw(px, 256, 128, x, y, s, ref s2);
			}
		}
	}

	private void CoinIcon(int x, int y)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaBoardLook.Coin(px, 256, 128, x, y, 2);
	}

	private void Circle(int cx, int cy, int r, Color32 c)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I4
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected Obj, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_0287: Expected Obj, but got I4
		//IL_0067: Invalid comparison between F8 and I4
		//IL_0318: Expected Obj, but got I4
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_02cc: Expected Obj, but got I4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_01d3: Invalid comparison between Obj and F8
		//IL_0195: Invalid comparison between Obj and F8
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected VT, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected I4, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected I4, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected Obj, but got Unknown
		//IL_03d6: Expected I4, but got VT
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_035d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		int num = cy;
		int num2 = cx;
		int num3 = r;
		object obj2 = 0;
		double num7 = default;
		bool flag5;
		do
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
			object obj4 = obj3 * 0;
			object obj5 = obj4 + obj4;
			object obj6 = obj5 / 1119879168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D100");
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num4 = (double)obj6 * (double)r;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
			double num5;
			double num6;
			double num8;
			if (num4 < 0.0)
			{
				if (num4 == -0.5)
				{
					num5 = -1.0;
					num6 = num7;
					goto IL_0295;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
				num8 = num4;
			}
			else
			{
				if (num4 == 0.5)
				{
					num5 = 1.0;
					num6 = num7;
					goto IL_0295;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
				num8 = num4;
			}
			goto IL_02df;
			IL_0295:
			double num9 = num6 + num5;
			object obj9 = num6 & 1;
			bool flag2 = obj9 == null;
			object obj10 = !flag2;
			num8 = ((obj10 != null) ? num9 : num6);
			goto IL_02df;
			IL_0326:
			double num10;
			double num11;
			num9 = num10 + num11;
			object obj11 = num10 & 1;
			bool flag3 = obj11 == null;
			obj10 = !flag3;
			if (obj10 != null)
			{
				num10 = num9;
			}
			goto IL_0370;
			IL_02df:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj14 = obj6 * r;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
			if ((nint)obj14 < 0)
			{
				if (obj14 == (object)(-0.5))
				{
					num11 = -1.0;
					num10 = num7;
					goto IL_0326;
				}
				num10 = (double)obj14 + -0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			}
			else
			{
				if (obj14 == (object)0.5)
				{
					num11 = 1.0;
					num10 = num7;
					goto IL_0326;
				}
				num10 = (double)obj14 + 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			}
			goto IL_0370;
			IL_0370:
			Color32 color = (Color32)(c & 0xFFFFFFFFL);
			num2 = (int)(num8 + cx);
			num = (int)(num10 + cy);
			Set(num2, num, color);
			obj2++;
			flag5 = (nint)obj2 != 96;
			num3 = (int)color;
		}
		while (flag5);
	}

	private void Set(int x, int y, Color32 c)
	{
		//IL_0059: Expected I4, but got I8
		//IL_0073: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00e0: Expected Obj, but got I4
		if (y > 127 || x > 255)
		{
			return;
		}
		int num = y | x;
		int num2 = (int)(num & 0x80000000L);
		bool flag = num2 == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Color32[] array = px;
		if (px != null)
		{
			object obj2 = x - y;
			object obj3 = obj2 + 32512;
			bool flag2 = (nint)obj3 < array.Length;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				object obj5 = (object)px + obj3;
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	private void FillRect(RectInt r, Color32 c)
	{
		//IL_000e: Expected I4, but got VT
		//IL_001c: Expected Obj, but got VT
		//IL_002c: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected I4, but got Unknown
		//IL_0067: Expected Obj, but got I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected I4, but got Unknown
		//IL_00d4: Expected Obj, but got I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_02a4: Expected Obj, but got VT
		//IL_02cf: Expected Obj, but got VT
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got Unknown
		//IL_0311: Expected Obj, but got I4
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0397: Expected Obj, but got I4
		//IL_01a1: Expected Obj, but got I4
		//IL_035f: Expected Obj, but got I4
		//IL_01e0: Expected VT, but got I8
		//IL_01f2: Expected I4, but got VT
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected VT, but got Unknown
		//IL_0210: Expected I, but got VT
		int num = r >> 32;
		Color32 color = default;
		object obj = color >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num2 = obj + num;
		RectInt rectInt = (RectInt)(color + r);
		object obj5 = num - num2;
		bool flag2 = (nint)obj5 < 0;
		bool flag3 = obj5 == null;
		int num3 = num ^ num2;
		int num4 = num ^ obj5;
		int num5 = num3 & num4;
		bool flag4 = num5 < 0;
		bool flag5 = flag2 == flag4;
		object obj6 = !flag3;
		object obj7 = flag5 & obj6;
		object obj8 = ~obj7;
		int num6 = ((obj8 != null) ? num2 : num);
		object obj9 = r - rectInt;
		bool flag6 = (nint)obj9 < 0;
		bool flag7 = obj9 == null;
		object obj10 = r ^ rectInt;
		object obj11 = r ^ obj9;
		object obj12 = obj10 & obj11;
		bool flag8 = (nint)obj12 < 0;
		bool flag9 = flag6 == flag8;
		object obj13 = !flag7;
		object obj14 = flag9 & obj13;
		object obj15 = ~obj14;
		IntPtr intPtr = default;
		RectInt rectInt3;
		if (obj15 == null)
		{
			RectInt rectInt2 = r;
			nint num7 = intPtr;
			rectInt3 = r;
		}
		else
		{
			RectInt rectInt2 = r;
			nint num7 = intPtr;
			rectInt3 = rectInt;
		}
		while (true)
		{
			object obj16 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v5+E4]");
			bool flag10 = (nint)0 == 0;
			object obj17 = !flag10;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (num == num6)
			{
				break;
			}
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v7+E4]");
			bool flag11 = (nint)0 == 0;
			object obj19 = !flag11;
			RectInt rectInt4 = r;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				rectInt4 = r;
			}
			while (true)
			{
				object obj20 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v9+E4]");
				bool flag12 = (nint)0 == 0;
				object obj21 = !flag12;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (rectInt3 != rectInt4)
				{
					Color32 color2 = (Color32)((nint)intPtr & 0xFFFFFFFFL);
					Set((int)rectInt4, num, color2);
					RectInt rectInt5 = (RectInt)(rectInt4 + 1);
					RectInt rectInt2 = rectInt4;
					nint num7 = (nint)color2;
					rectInt4 = rectInt5;
					continue;
				}
				break;
			}
			num++;
		}
	}

	private void Outline(RectInt r, Color32 c)
	{
		//IL_000e: Expected I4, but got VT
		//IL_001c: Expected Obj, but got VT
		//IL_002c: Expected Obj, but got I
		//IL_038d: Expected Obj, but got I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected I4, but got Unknown
		//IL_0067: Expected Obj, but got VT
		//IL_0092: Expected Obj, but got VT
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00d4: Expected Obj, but got I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_03a8: Expected Obj, but got I4
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected I4, but got Unknown
		//IL_0415: Expected Obj, but got I4
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected Obj, but got Unknown
		//IL_048e: Expected Obj, but got I4
		//IL_0240: Expected Obj, but got I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected I4, but got Unknown
		//IL_0181: Expected Obj, but got I4
		//IL_04c6: Expected Obj, but got I4
		//IL_01b0: Expected VT, but got I8
		//IL_01c2: Expected I4, but got VT
		//IL_01d4: Expected VT, but got I8
		//IL_01e6: Expected I4, but got VT
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected VT, but got Unknown
		//IL_0201: Expected VT, but got I4
		//IL_0211: Expected I, but got VT
		//IL_02c5: Expected Obj, but got I4
		//IL_02f4: Expected VT, but got I8
		//IL_0306: Expected I4, but got VT
		//IL_0318: Expected VT, but got I8
		//IL_0345: Expected VT, but got I4
		//IL_034d: Expected VT, but got I4
		//IL_0355: Expected I, but got VT
		int num = r >> 32;
		Color32 color = default;
		object obj = color >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RectInt rectInt = (RectInt)(color + r);
		int num2 = obj + num;
		object obj5 = r - rectInt;
		bool flag2 = (nint)obj5 < 0;
		bool flag3 = obj5 == null;
		object obj6 = r ^ rectInt;
		object obj7 = r ^ obj5;
		object obj8 = obj6 & obj7;
		bool flag4 = (nint)obj8 < 0;
		bool flag5 = flag2 == flag4;
		object obj9 = !flag3;
		object obj10 = flag5 & obj9;
		object obj11 = ~obj10;
		RectInt rectInt2 = ((obj11 != null) ? rectInt : r);
		object obj12 = num - num2;
		bool flag6 = (nint)obj12 < 0;
		bool flag7 = obj12 == null;
		int num3 = num ^ num2;
		int num4 = num ^ obj12;
		int num5 = num3 & num4;
		bool flag8 = num5 < 0;
		bool flag9 = flag6 == flag8;
		object obj13 = !flag7;
		object obj14 = flag9 & obj13;
		object obj15 = ~obj14;
		int num6 = ((obj15 != null) ? num2 : num);
		int num7 = num6 - 1;
		RectInt rectInt3 = r;
		IntPtr intPtr = default;
		nint num8 = intPtr;
		RectInt rectInt4 = r;
		while (true)
		{
			object obj16 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v5+E4]");
			bool flag10 = (nint)0 == 0;
			object obj17 = !flag10;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj18 = obj2;
			if (rectInt2 == rectInt4)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+E4]");
			bool flag11 = (nint)0 == 0;
			object obj19 = !flag11;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Color32 c2 = (Color32)((nint)intPtr & 0xFFFFFFFFL);
			Set((int)rectInt4, num, c2);
			Color32 color2 = (Color32)((nint)intPtr & 0xFFFFFFFFL);
			Set((int)rectInt4, num7, color2);
			RectInt rectInt5 = (RectInt)(rectInt4 + 1);
			color = (Color32)num7;
			rectInt3 = rectInt4;
			num8 = (nint)color2;
			rectInt4 = rectInt5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+E4]");
		bool flag12 = (nint)0 == 0;
		object obj20 = !flag12;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num9 = rectInt2 - 1;
		while (true)
		{
			object obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v10+E4]");
			bool flag13 = (nint)0 == 0;
			object obj22 = !flag13;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (num6 != num)
			{
				object obj23 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v12+E4]");
				bool flag14 = (nint)0 == 0;
				object obj24 = !flag14;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Color32 c3 = (Color32)((nint)intPtr & 0xFFFFFFFFL);
				Set((int)r, num, c3);
				Color32 color3 = (Color32)((nint)intPtr & 0xFFFFFFFFL);
				Set(num9, num, color3);
				int num10 = num + 1;
				color = (Color32)num;
				rectInt3 = (RectInt)num9;
				num8 = (nint)color3;
				num = num10;
				continue;
			}
			break;
		}
	}

	public ShopStand()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_002f: Expected I4, but got I8
		//IL_004c: Expected F4, but got I
		//IL_007a: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		object obj2 = this + 280;
		hand = -1;
		burstT = -1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BE78]");
		displaySize = 0f;
		messageText = (string)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		dirty = true;
		lastBalance = -1;
		_ = 0;
		base._002Ector();
	}

	static ShopStand()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I
		//IL_019f: Expected Obj, but got I
		//IL_01b5: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I
		//IL_025d: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9C8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj3 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+A0]");
		object obj5 = 0;
		_ = 4278584838L;
		object obj6 = obj3;
		obj5 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+A0]");
		object obj8 = 0;
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X10_v2+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X9_v2+2C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X10_v2+A0]");
		object obj11 = 0;
		_ = 4284506208L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X10_v2+A0]");
		object obj12 = 0;
		_ = 4294967295L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X10_v2+A0]");
		object obj13 = 0;
		_ = 4293454056L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X10_v2+A0]");
		object obj14 = 0;
		_ = 4294967295L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X10_v2+A0]");
		object obj16 = (nint)0 + (nint)32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v8+8]");
		obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj17 = obj3;
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v9+A0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v8+A0]");
		object obj20 = (nint)0 + (nint)40;
		obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj21 = obj3;
		object obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v11+A0]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v9+A0]");
		object obj24 = (nint)0 + (nint)48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v12+10]");
		obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		DateTime dateTime = new DateTime(2026, 11, 2);
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v13+A0]");
		object obj26 = 0;
		_ = 0;
	}
}
