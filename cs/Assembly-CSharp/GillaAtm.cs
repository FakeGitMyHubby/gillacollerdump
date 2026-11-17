using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;
using UnityEngine;

public class GillaAtm : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<byte> _003C_003E9__155_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF2A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj2 = default;
			obj2._002Ector();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
			object obj4 = 0;
			obj4 = obj2;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		internal bool _003CRefill_003Eb__155_0(byte id)
		{
			//IL_006d: Expected I4, but got Obj
			//IL_004b: Expected Obj, but got I4
			int id2 = id & 0xFF;
			CosmeticCatalog.Entry entry = CosmeticCatalog.Of(id2);
			if (entry != null)
			{
				object obj = entry.slot - 6;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public struct Pack
	{
		public string sku;

		public int coins;

		public string usd;
	}

	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public int pack;

		public GillaAtm _003C_003E4__this;

		internal void _003COnEnable_003Eb__0(int with)
		{
			_003C_003E4__this.Drop(pack);
		}
	}

	public static readonly Pack[] Packs;

	public Renderer screen;

	public Transform[] orbs;

	public Transform trackFrame;

	public Vector3[] trackFrom;

	public Vector3[] trackTo;

	public TextAsset titleFont;

	public TextAsset textFont;

	public AudioClip tickSound;

	public AudioClip buySound;

	public AudioClip errorSound;

	public AudioClip coinSound;

	public AudioClip sparkleSound;

	public AudioClip grabSound;

	public const int W = default(int);

	public const int H = default(int);

	public const int RowsTop = default(int);

	public const int RowTall = default(int);

	public const int TrackDown = default(int);

	private static readonly int BaseMap;

	private static readonly Color32 Line;

	private static readonly Color32 Coin;

	private static readonly Color32 Black;

	private static readonly Color32 Bright;

	private Texture2D tex;

	private Color32[] px;

	private ScreenFont title;

	private ScreenFont text;

	private SlideOrb[] slides;

	private float[] along;

	private bool[] held;

	private bool[] atEnd;

	private float message;

	private string messageText;

	private bool messageBad;

	private bool dirty;

	private int lastBalance;

	private int paying;

	private int balanceWhenPaid;

	private float paidAt;

	private string pricesShown;

	public static int PackOf(string sku)
	{
		//IL_0189: Expected Obj, but got I
		//IL_0192: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I4
		//IL_01ed: Expected Obj, but got I
		//IL_0179: Expected I4, but got Obj
		//IL_0158: Expected I4, but got I8
		//IL_0065: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF568]");
		object obj = 0;
		object obj2 = 32;
		int num = 0;
		while (true)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v4+A0]");
			object obj5 = 0;
			object obj6 = obj5;
			if (obj5 == null)
			{
				goto IL_015d;
			}
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v10+18]");
			if ((nint)num2 < (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v11+A0]");
					object obj9 = 0;
					obj6 = obj9;
					if (obj9 == null)
					{
						goto IL_015d;
					}
				}
				int num3 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v10+18]");
				bool flag3 = (nint)num3 < (nint)0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v10+v42 @ X22_v2]");
					bool flag4 = (string)0 == sku;
					bool flag5 = !flag4;
					object obj11 = !flag5;
					if (obj11 != null)
					{
						break;
					}
					num++;
					obj2 += 24;
					continue;
				}
				goto IL_016b;
			}
			num = -1;
			break;
			IL_016b:
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			return (int)ex;
			IL_015d:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_016b;
		}
		return num;
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
		//IL_144e: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0144: Expected Obj, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_019a: Expected Obj, but got I4
		//IL_01c9: Expected Obj, but got I
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_02ca: Expected Obj, but got I4
		//IL_02f9: Expected Obj, but got I
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected Obj, but got Unknown
		//IL_03ca: Expected Obj, but got I4
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_03e7: Expected I, but got Obj
		//IL_0251: Expected Obj, but got I
		//IL_0385: Expected Obj, but got I
		//IL_03b2: Expected I4, but got Obj
		//IL_05b2: Expected Obj, but got I
		//IL_05dc: Expected Obj, but got I4
		//IL_048f: Expected Obj, but got I
		//IL_04a3: Expected Obj, but got I4
		//IL_06e9: Expected Obj, but got I
		//IL_0713: Expected Obj, but got I4
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected Obj, but got Unknown
		//IL_04fc: Expected Obj, but got I
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected Obj, but got Unknown
		//IL_0519: Expected Obj, but got I4
		//IL_0766: Expected Obj, but got I
		//IL_0780: Expected Obj, but got I
		//IL_0791: Expected I, but got Obj
		//IL_0538: Expected Obj, but got I
		//IL_07a6: Expected Obj, but got I
		//IL_07d0: Expected Obj, but got I4
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected Obj, but got Unknown
		//IL_058b: Expected Obj, but got I4
		//IL_081e: Expected Obj, but got I
		//IL_0832: Expected Obj, but got I4
		//IL_088b: Expected Obj, but got I
		//IL_08cd: Expected Obj, but got I4
		//IL_08d6: Expected Obj, but got I4
		//IL_08df: Expected Obj, but got I4
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Expected Obj, but got Unknown
		//IL_0a00: Expected I4, but got Obj
		//IL_0a29: Expected Obj, but got I4
		//IL_0a71: Expected I4, but got Obj
		//IL_0abb: Expected Obj, but got I4
		//IL_0aea: Expected Obj, but got I
		//IL_0b08: Expected Obj, but got I4
		//IL_1472: Unknown result type (might be due to invalid IL or missing references)
		//IL_1477: Expected Obj, but got Unknown
		//IL_1480: Unknown result type (might be due to invalid IL or missing references)
		//IL_1485: Expected Obj, but got Unknown
		//IL_148e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1493: Expected Obj, but got Unknown
		//IL_14b2: Expected Obj, but got I4
		//IL_0bc1: Expected Obj, but got I4
		//IL_0cad: Expected Obj, but got I4
		//IL_0d99: Expected Obj, but got I4
		//IL_0e32: Expected Obj, but got I
		//IL_0e6e: Expected Obj, but got I4
		//IL_0ebd: Expected Obj, but got I4
		//IL_0ebd: Expected VT, but got Obj
		//IL_0ebd: Expected VT, but got Obj
		//IL_0ebd: Expected Obj, but got I
		//IL_0ee5: Expected Obj, but got I
		//IL_0ef5: Expected Obj, but got I
		//IL_0f05: Expected Obj, but got I
		//IL_0f15: Expected Obj, but got I
		//IL_0f25: Expected Obj, but got I
		//IL_0f35: Expected Obj, but got I
		//IL_0f42: Expected I4, but got Obj
		//IL_0f4f: Expected I4, but got Obj
		//IL_0f5c: Expected I4, but got Obj
		//IL_0f72: Expected I, but got Obj
		//IL_0fab: Expected Obj, but got I
		//IL_0fbb: Expected Obj, but got I
		//IL_0fcb: Expected Obj, but got I
		//IL_0fdb: Expected Obj, but got I
		//IL_0feb: Expected Obj, but got I
		//IL_0ffb: Expected Obj, but got I
		//IL_1008: Expected I4, but got Obj
		//IL_1015: Expected I4, but got Obj
		//IL_103e: Expected Obj, but got I4
		//IL_104e: Expected Obj, but got I
		//IL_105e: Expected Obj, but got I
		//IL_106e: Expected Obj, but got I
		//IL_107e: Expected Obj, but got I
		//IL_108e: Expected Obj, but got I
		//IL_109e: Expected Obj, but got I
		//IL_10ab: Expected I4, but got Obj
		//IL_10b8: Expected I4, but got Obj
		//IL_1120: Expected Obj, but got I
		//IL_1130: Expected Obj, but got I
		//IL_1140: Expected Obj, but got I
		//IL_1150: Expected Obj, but got I
		//IL_1160: Expected Obj, but got I
		//IL_1170: Expected Obj, but got I
		//IL_117d: Expected I4, but got Obj
		//IL_118a: Expected I4, but got Obj
		//IL_1192: Expected I4, but got Obj
		//IL_11c1: Expected Obj, but got I4
		//IL_11d1: Expected Obj, but got I
		//IL_11e1: Expected Obj, but got I
		//IL_11f1: Expected Obj, but got I
		//IL_1201: Expected Obj, but got I
		//IL_1211: Expected Obj, but got I
		//IL_1221: Expected Obj, but got I
		//IL_122e: Expected I4, but got Obj
		//IL_123b: Expected I4, but got Obj
		//IL_1243: Expected I4, but got Obj
		//IL_126e: Expected Obj, but got I
		//IL_1288: Expected Obj, but got I
		//IL_1299: Expected I, but got Obj
		//IL_12c5: Expected Obj, but got I
		//IL_12d5: Expected Obj, but got I
		//IL_12e5: Expected Obj, but got I
		//IL_12f5: Expected Obj, but got I
		//IL_1305: Expected Obj, but got I
		//IL_1315: Expected Obj, but got I
		//IL_1326: Expected I4, but got Obj
		//IL_132e: Expected I4, but got Obj
		//IL_1352: Expected Obj, but got I
		//IL_1374: Expected Obj, but got I
		//IL_1384: Expected Obj, but got I
		//IL_1394: Expected Obj, but got I
		//IL_13a4: Expected Obj, but got I
		//IL_13b4: Expected Obj, but got I
		//IL_13c4: Expected Obj, but got I
		//IL_13d4: Expected Obj, but got I
		//IL_13e5: Expected I4, but got Obj
		//IL_13ed: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2+E4]");
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
		texture2D._002Ector(200, 240, (TextureFormat)4, mipChain: true);
		bool flag2 = (object)texture2D == null;
		TextureFormat textureFormat = (TextureFormat)4;
		int num = 240;
		int num2 = 200;
		if (!flag2)
		{
			texture2D.filterMode = (FilterMode)0;
			texture2D.wrapMode = (TextureWrapMode)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF598]");
			object obj5 = 0;
			texture2D.name = (string)obj5;
			texture2D.hideFlags = (HideFlags)52;
			object obj6 = this + 136;
			obj6 = texture2D;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj8 = this + 144;
			object obj9 = default;
			obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v26+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X20_v8-48]");
			bool flag4 = (UnityEngine.Object)0 != null;
			bool flag5 = !flag4;
			int num3 = 0;
			ScreenFont screenFont = null;
			if (!flag5)
			{
				bool flag6 = (object)titleFont == null;
				textureFormat = (TextureFormat)4;
				num = 0;
				num2 = 0;
				if (flag6)
				{
					goto IL_13f2;
				}
				string baked = titleFont.text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ScreenFont screenFont2 = default;
				screenFont2._002Ector(baked);
				num3 = 0;
				screenFont = screenFont2;
			}
			object obj13 = this + 152;
			obj13 = screenFont;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X0_v33+E4]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X21_v6-48]");
			bool flag8 = (UnityEngine.Object)0 != null;
			bool flag9 = !flag8;
			num = 0;
			int num4 = 0;
			if (!flag9)
			{
				bool flag10 = (object)textFont == null;
				textureFormat = (TextureFormat)4;
				num = 0;
				num2 = 0;
				if (flag10)
				{
					goto IL_13f2;
				}
				string baked2 = textFont.text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ScreenFont screenFont3 = default;
				screenFont3._002Ector(baked2);
				num = 0;
				num4 = (int)screenFont3;
			}
			object obj17 = this + 160;
			obj17 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			GillaAtm gillaAtm = (GillaAtm)(this + 176);
			nint num5 = (nint)gillaAtm;
			bool flag11 = (object)gillaAtm == null;
			textureFormat = (TextureFormat)4;
			num2 = num4;
			if (!flag11)
			{
				Transform[] array = orbs;
				bool flag12 = orbs == null;
				textureFormat = (TextureFormat)4;
				num2 = num4;
				if (!flag12)
				{
					num2 = array.Length;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v17 (Il2CppClass<GillaAtm>)+18]");
					if ((nint)0 == array.Length)
					{
						goto IL_05a2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					int num6 = default;
					along = (float[])num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Transform[] array2 = orbs;
					bool flag13 = orbs == null;
					textureFormat = (TextureFormat)4;
					num2 = num6;
					if (!flag13)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						gillaAtm = (GillaAtm)(this + 184);
						int num7 = default;
						gillaAtm = (GillaAtm)num7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X20_v23 (GillaAtm)-90]");
						object obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X20_v23 (GillaAtm)-90]");
						bool flag14 = (nint)0 == 0;
						textureFormat = (TextureFormat)4;
						num2 = num7;
						if (!flag14)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							object obj21 = this + 192;
							int num8 = default;
							obj21 = num8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							num2 = num8;
							goto IL_05a2;
						}
					}
				}
			}
		}
		goto IL_13f2;
		IL_140e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_1400:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_140e;
		IL_06d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj22 = 0;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X0_v47+E4]");
		bool flag15 = (nint)0 == 0;
		object obj24 = !flag15;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaAtm gillaAtm2;
		if (Application.isPlaying)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF570]");
			object obj26 = 0;
			Action action = default;
			action._002Ector(gillaAtm2, (IntPtr)obj26);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj27 = 0;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X0_v55+E4]");
			bool flag16 = (nint)0 == 0;
			object obj29 = !flag16;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coins.Changed += action;
			num2 = 0;
		}
		gillaAtm2.Draw();
		return;
		IL_13f2:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_1400;
		IL_05a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj30 = 0;
		object obj31 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X0_v42+E4]");
		bool flag17 = (nint)0 == 0;
		object obj32 = !flag17;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isPlaying = Application.isPlaying;
		bool flag18 = !isPlaying;
		TextureFormat textureFormat2 = (TextureFormat)4;
		gillaAtm2 = this;
		if (flag18)
		{
			goto IL_06d9;
		}
		object obj33 = this + 168;
		object obj34 = obj33;
		bool flag19 = obj33 == null;
		textureFormat = (TextureFormat)4;
		if (!flag19)
		{
			Transform[] array3 = orbs;
			bool flag20 = orbs == null;
			textureFormat = (TextureFormat)4;
			if (!flag20)
			{
				num2 = array3.Length;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v35+18]");
				bool flag21 = (nint)0 != array3.Length;
				textureFormat2 = (TextureFormat)4;
				gillaAtm2 = this;
				if (flag21)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF578]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					int num9 = default;
					slides = (SlideOrb[])num9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Transform[] array4 = orbs;
					bool flag22 = orbs == null;
					textureFormat = (TextureFormat)4;
					num2 = num9;
					if (flag22)
					{
						goto IL_13f2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF590]");
					object obj36 = 0;
					object obj38 = default;
					object obj37 = obj38;
					object obj40 = default;
					object obj39 = obj40;
					object obj42 = default;
					object obj41 = obj42;
					object obj44 = default;
					object obj43 = obj44;
					object obj46 = default;
					object obj45 = obj46;
					object obj48 = default;
					object obj47 = obj48;
					textureFormat2 = (TextureFormat)4;
					object obj49 = 0;
					object obj50 = 0;
					object obj51 = 32;
					int num10 = num;
					int num11 = num9;
					gillaAtm2 = this;
					object obj52 = default;
					Action<int> action2 = default;
					while (true)
					{
						bool flag23 = (nint)obj49 >= array4.Length;
						obj38 = obj37;
						obj40 = obj39;
						obj42 = obj41;
						obj44 = obj43;
						obj46 = obj45;
						obj48 = obj47;
						num = num10;
						num2 = num11;
						if (flag23)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						obj52._002Ector();
						bool flag24 = obj52 == null;
						obj38 = obj37;
						obj40 = obj39;
						obj42 = obj41;
						obj44 = obj43;
						obj46 = obj45;
						obj48 = obj47;
						textureFormat = textureFormat2;
						num = num10;
						num2 = 0;
						if (!flag24)
						{
							object obj53 = obj52 + 24;
							obj53 = gillaAtm2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Transform[] array5 = gillaAtm2.orbs;
							bool flag25 = gillaAtm2.orbs == null;
							obj38 = obj37;
							obj40 = obj39;
							obj42 = obj41;
							obj44 = obj43;
							obj46 = obj45;
							obj48 = obj47;
							textureFormat = textureFormat2;
							num = num10;
							num2 = (int)gillaAtm2;
							if (!flag25)
							{
								bool flag26 = (nint)obj49 < array5.Length;
								object obj54 = !flag26;
								obj38 = obj37;
								obj40 = obj39;
								obj42 = obj41;
								obj44 = obj43;
								obj46 = obj45;
								obj48 = obj47;
								textureFormat = textureFormat2;
								num = num10;
								num2 = (int)gillaAtm2;
								if (obj54 != null)
								{
									goto IL_1400;
								}
								object obj55 = obj;
								object obj56 = (object)gillaAtm2.orbs + obj49;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X0_v70+E4]");
								bool flag27 = (nint)0 == 0;
								object obj57 = !flag27;
								if (obj57 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X8_v43+20]");
								bool flag28 = (UnityEngine.Object)0 == null;
								bool flag29 = !flag28;
								object obj58 = !flag29;
								num = 0;
								num2 = 0;
								if (obj58 != null)
								{
									goto IL_145c;
								}
								Transform[] array6 = gillaAtm2.orbs;
								bool flag30 = gillaAtm2.orbs == null;
								obj38 = obj37;
								obj40 = obj39;
								obj42 = obj41;
								obj44 = obj43;
								obj46 = obj45;
								obj48 = obj47;
								textureFormat = textureFormat2;
								num = 0;
								num2 = 0;
								if (!flag30)
								{
									bool flag31 = (nint)obj49 < array6.Length;
									object obj59 = !flag31;
									obj38 = obj37;
									obj40 = obj39;
									obj42 = obj41;
									obj44 = obj43;
									obj46 = obj45;
									obj48 = obj47;
									textureFormat = textureFormat2;
									num = 0;
									num2 = 0;
									if (obj59 != null)
									{
										goto IL_1400;
									}
									Vector3[] array7 = gillaAtm2.trackFrom;
									bool flag32 = gillaAtm2.trackFrom == null;
									obj38 = obj37;
									obj40 = obj39;
									obj42 = obj41;
									obj44 = obj43;
									obj46 = obj45;
									obj48 = obj47;
									textureFormat = textureFormat2;
									num = 0;
									num2 = 0;
									if (!flag32)
									{
										bool flag33 = (nint)obj49 < array7.Length;
										object obj60 = !flag33;
										obj38 = obj37;
										obj40 = obj39;
										obj42 = obj41;
										obj44 = obj43;
										obj46 = obj45;
										obj48 = obj47;
										textureFormat = textureFormat2;
										num = 0;
										num2 = 0;
										if (obj60 != null)
										{
											goto IL_1400;
										}
										Vector3[] array8 = gillaAtm2.trackTo;
										bool flag34 = gillaAtm2.trackTo == null;
										obj38 = obj37;
										obj40 = obj39;
										obj42 = obj41;
										obj44 = obj43;
										obj46 = obj45;
										obj48 = obj47;
										textureFormat = textureFormat2;
										num = 0;
										num2 = 0;
										if (!flag34)
										{
											bool flag35 = (nint)obj49 < array8.Length;
											object obj61 = !flag35;
											obj38 = obj37;
											obj40 = obj39;
											obj42 = obj41;
											obj44 = obj43;
											obj46 = obj45;
											obj48 = obj47;
											textureFormat = textureFormat2;
											num = 0;
											num2 = 0;
											if (obj61 != null)
											{
												goto IL_1400;
											}
											object obj62 = (object)gillaAtm2.trackFrom + obj50;
											SlideOrb[] array9 = gillaAtm2.slides;
											object obj63 = (object)gillaAtm2.orbs + obj49;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF580]");
											object obj64 = 0;
											object obj65 = (object)gillaAtm2.trackTo + obj50;
											object obj66 = obj64;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X0_v75+E4]");
											bool flag36 = (nint)0 == 0;
											object obj67 = !flag36;
											if (obj67 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ X8_v47+20]");
											SlideOrb slideOrb = SlideOrb.On((Transform)0, gillaAtm2.trackFrame, (Vector3)gillaAtm2.grabSound, (Vector3)gillaAtm2.tickSound, (AudioClip)1, null);
											bool flag37 = gillaAtm2.slides == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+28]");
											obj38 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+24]");
											obj40 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+20]");
											obj42 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+28]");
											obj44 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+24]");
											obj46 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+20]");
											obj48 = 0;
											textureFormat = (TextureFormat)gillaAtm2.tickSound;
											num = (int)gillaAtm2.grabSound;
											num2 = (int)gillaAtm2.trackFrame;
											if (!flag37)
											{
												nint num12 = (nint)array9;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v49 (Il2CppClass<SlideOrb[]>)+40]");
												num2 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
												bool flag38 = ex == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+28]");
												obj38 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+24]");
												obj40 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+20]");
												obj42 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+28]");
												obj44 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+24]");
												obj46 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+20]");
												obj48 = 0;
												textureFormat = (TextureFormat)gillaAtm2.tickSound;
												num = (int)gillaAtm2.grabSound;
												if (flag38)
												{
													goto IL_140e;
												}
												bool flag39 = (nint)obj49 < array9.Length;
												object obj68 = !flag39;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+28]");
												obj38 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+24]");
												obj40 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+20]");
												obj42 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+28]");
												obj44 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+24]");
												obj46 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+20]");
												obj48 = 0;
												textureFormat = (TextureFormat)gillaAtm2.tickSound;
												num = (int)gillaAtm2.grabSound;
												if (obj68 != null)
												{
													goto IL_1400;
												}
												object obj69 = (object)gillaAtm2.slides + obj49;
												object obj70 = (object)gillaAtm2.slides + obj51;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												object obj71 = obj33;
												bool flag40 = obj33 == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+28]");
												obj38 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+24]");
												obj40 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+20]");
												obj42 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+28]");
												obj44 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+24]");
												obj46 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+20]");
												obj48 = 0;
												textureFormat = (TextureFormat)gillaAtm2.tickSound;
												num = (int)gillaAtm2.grabSound;
												num2 = (int)slideOrb;
												if (!flag40)
												{
													object obj72 = obj49;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v53+18]");
													bool flag41 = (nint)obj72 < 0;
													object obj73 = !flag41;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+28]");
													obj38 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+24]");
													obj40 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+20]");
													obj42 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+28]");
													obj44 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+24]");
													obj46 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+20]");
													obj48 = 0;
													textureFormat = (TextureFormat)gillaAtm2.tickSound;
													num = (int)gillaAtm2.grabSound;
													num2 = (int)slideOrb;
													if (obj73 != null)
													{
														goto IL_1400;
													}
													object obj74 = obj33 + obj49;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C48]");
													object obj75 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF588]");
													object obj76 = 0;
													action2._002Ector(obj52, (IntPtr)obj76);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ X8_v54+20]");
													bool flag42 = (nint)0 == 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+28]");
													obj38 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+24]");
													obj40 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+20]");
													obj42 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+28]");
													obj44 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+24]");
													obj46 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+20]");
													obj48 = 0;
													textureFormat = (TextureFormat)0;
													num = (int)obj76;
													num2 = (int)obj52;
													if (!flag42)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ X8_v54+20]");
														object obj77 = (nint)0 + (nint)88;
														obj77 = action2;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF590]");
														obj36 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+28]");
														obj37 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+24]");
														obj39 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v48+20]");
														obj41 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+28]");
														obj43 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+24]");
														obj45 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v6+20]");
														obj47 = 0;
														textureFormat2 = (TextureFormat)0;
														num = (int)obj76;
														num2 = (int)action2;
														goto IL_145c;
													}
												}
											}
										}
									}
								}
							}
						}
						goto IL_13f2;
						IL_145c:
						array4 = gillaAtm2.orbs;
						obj49++;
						obj50 += 12;
						obj51 += 8;
						bool flag43 = gillaAtm2.orbs == null;
						object obj78 = !flag43;
						obj38 = obj37;
						obj40 = obj39;
						obj42 = obj41;
						obj44 = obj43;
						obj46 = obj45;
						obj48 = obj47;
						textureFormat = textureFormat2;
						num10 = num;
						num11 = num2;
						if (obj78 != null)
						{
							continue;
						}
						goto IL_13f2;
					}
				}
				goto IL_06d9;
			}
		}
		goto IL_13f2;
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_0092: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I4
		//IL_0196: Expected Obj, but got I4
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF570]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Action action = default;
			action._002Ector(this, (IntPtr)obj5);
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v17+E4]");
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
		if (tex != null)
		{
			object obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
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

	private unsafe void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0ec5: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I4
		//IL_11d4: Expected Obj, but got I4
		//IL_0856: Invalid comparison between F4 and I4
		//IL_1066: Expected I4, but got I8
		//IL_1080: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I4
		//IL_109e: Expected Obj, but got I
		//IL_10c8: Expected Obj, but got I4
		//IL_0885: Invalid comparison between F4 and I4
		//IL_0896: Expected Obj, but got I4
		//IL_089f: Invalid comparison between F4 and I4
		//IL_08ba: Expected Obj, but got I4
		//IL_090f: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I4
		//IL_10e6: Expected Obj, but got I
		//IL_10fe: Expected Obj, but got I
		//IL_1128: Expected Obj, but got I4
		//IL_094f: Expected Obj, but got I4
		//IL_01da: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I4
		//IL_1244: Expected Obj, but got I
		//IL_0a07: Expected I4, but got I8
		//IL_0a21: Expected Obj, but got I4
		//IL_0edc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee1: Expected Obj, but got Unknown
		//IL_0efb: Expected Obj, but got I4
		//IL_1160: Expected Obj, but got I4
		//IL_0980: Invalid comparison between F4 and I4
		//IL_0992: Expected F4, but got I4
		//IL_0a59: Expected Obj, but got I4
		//IL_0e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1f: Expected Obj, but got Unknown
		//IL_09af: Expected I4, but got I8
		//IL_09b8: Expected F4, but got I4
		//IL_0290: Expected Obj, but got I4
		//IL_0ce8: Expected Obj, but got I8
		//IL_0cf8: Expected Obj, but got I
		//IL_0d01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d06: Expected Obj, but got Unknown
		//IL_0d17: Expected Obj, but got I4
		//IL_11bc: Expected Obj, but got I4
		//IL_0ab0: Expected Obj, but got I
		//IL_0ada: Expected Obj, but got I4
		//IL_02bd: Expected Obj, but got I
		//IL_117e: Expected Obj, but got I
		//IL_0d4e: Expected Obj, but got I4
		//IL_032e: Expected F4, but got I
		//IL_034e: Expected F4, but got I4
		//IL_0b22: Expected Obj, but got I4
		//IL_0f5a: Expected Obj, but got I
		//IL_0f74: Expected Obj, but got I8
		//IL_0f8e: Expected Obj, but got I4
		//IL_0daa: Expected Obj, but got I
		//IL_0db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db8: Expected Obj, but got Unknown
		//IL_0dc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc6: Expected Obj, but got Unknown
		//IL_0de5: Expected Obj, but got I4
		//IL_0df6: Expected Obj, but got I4
		//IL_03e2: Expected Obj, but got I4
		//IL_0371: Invalid comparison between I and F8
		//IL_038a: Expected F4, but got I
		//IL_0b40: Expected Obj, but got I
		//IL_0b50: Expected Obj, but got I4
		//IL_0b66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6b: Expected I4, but got Unknown
		//IL_0b8c: Expected Obj, but got I
		//IL_0b9c: Expected Obj, but got I
		//IL_03cc: Expected Obj, but got I4
		//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc9: Expected Obj, but got Unknown
		//IL_0c09: Expected F4, but got I
		//IL_0c32: Expected I4, but got I8
		//IL_0c3b: Expected Obj, but got I4
		//IL_0c44: Expected Obj, but got I4
		//IL_0402: Expected Obj, but got I4
		//IL_0439: Expected F4, but got I
		//IL_049e: Expected Obj, but got I4
		//IL_051b: Expected Obj, but got I4
		//IL_100e: Expected Obj, but got I4
		//IL_05a0: Expected Obj, but got I4
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected Obj, but got Unknown
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected Obj, but got Unknown
		//IL_05d5: Expected Obj, but got I4
		//IL_06fe: Expected I4, but got Obj
		//IL_0754: Expected Obj, but got I4
		//IL_063b: Expected Obj, but got I4
		//IL_0783: Expected I4, but got Obj
		//IL_0797: Expected I4, but got I8
		//IL_07b1: Expected Obj, but got I4
		//IL_0801: Expected Obj, but got I4
		//IL_067a: Expected Obj, but got I4
		//IL_1035: Expected Obj, but got I4
		//IL_104d: Expected Obj, but got I4
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
		if (!Application.isPlaying)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaPurchases.FetchPrices();
		float deltaTime = Time.deltaTime;
		SlideOrb[] array = slides;
		bool flag3 = slides == null;
		IntPtr intPtr = default;
		UnityEngine.Object obj7 = (UnityEngine.Object)(nint)intPtr;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj8 = 0;
			bool[] array3 = default;
			bool[] array2 = array3;
			bool[] array5 = default;
			bool[] array4 = array5;
			bool[] array7 = default;
			bool[] array6 = array7;
			object obj10 = default;
			object obj9 = obj10;
			float num2 = default;
			float num = num2;
			string text2 = default;
			string text = text2;
			float num3 = deltaTime;
			object obj11 = 0;
			object obj58 = default;
			object obj81;
			do
			{
				object obj12 = array.Length;
				bool flag4 = (nint)obj11 >= array.Length;
				array3 = array2;
				array5 = array4;
				array7 = array6;
				obj10 = obj9;
				num2 = num;
				text2 = text;
				obj7 = null;
				float num4 = deltaTime;
				string text5;
				if (!flag4)
				{
					bool flag5 = (nint)obj11 < array.Length;
					object obj13 = !flag5;
					if (obj13 == null)
					{
						object obj14 = obj8;
						object obj15 = (object)array + obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v71+E4]");
						obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v71+E4]");
						bool flag6 = (nint)0 == 0;
						object obj16 = !flag6;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v49+20]");
						bool flag7 = (UnityEngine.Object)0 == null;
						SlideOrb[] array8 = slides;
						bool flag8 = !flag7;
						object obj17 = !flag8;
						array = slides;
						if (obj17 != null)
						{
							goto IL_0ed3;
						}
						bool flag9 = slides == null;
						array3 = array2;
						array5 = array4;
						array7 = array6;
						obj10 = obj9;
						num2 = num;
						text2 = null;
						obj7 = null;
						num4 = deltaTime;
						if (flag9)
						{
							break;
						}
						bool flag10 = (nint)obj11 < array8.Length;
						object obj18 = !flag10;
						if (obj18 == null)
						{
							obj12 = (object)slides + obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X9_v3+20]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X9_v3+20]");
							bool flag11 = (nint)0 == 0;
							array3 = array2;
							array5 = array4;
							array7 = array6;
							obj10 = obj9;
							num2 = num;
							text2 = null;
							obj7 = null;
							num4 = deltaTime;
							if (flag11)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X20_v17+74]");
							num2 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X20_v17+74]");
							bool flag12 = (nint)0 < (nint)0;
							num3 = 0f;
							if (!flag12)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X20_v17+74]");
								bool flag13 = !(0.0 > 1.0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X20_v17+74]");
								num3 = 0f;
								if (!flag13)
								{
									num3 = 1f;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X20_v17+70]");
							array3 = (bool[])0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X20_v17+70]");
							object obj20 = 0 & 0x80000000L;
							bool flag14 = obj20 == null;
							object obj21 = !flag14;
							if (obj21 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X20_v17+B0]");
								bool flag15 = (nint)0 == 0;
								object obj22 = !flag15;
								obj12 = obj22;
							}
							else
							{
								obj12 = 0;
							}
							float[] array9 = along;
							bool flag16 = along == null;
							array5 = array4;
							array7 = (bool[])(object)along;
							obj10 = obj9;
							text2 = null;
							obj7 = null;
							num4 = deltaTime;
							if (flag16)
							{
								break;
							}
							bool flag17 = (nint)obj11 < array9.Length;
							object obj23 = !flag17;
							if (obj23 == null)
							{
								obj10 = (object)along + obj11;
								array7 = held;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X12_v3+20]");
								num2 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X12_v3+20]");
								nint num5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A884]");
								if (num5 > 0)
								{
									dirty = true;
									bool flag18 = held == null;
									object obj24 = !flag18;
									if (obj24 == null)
									{
										text2 = null;
										obj7 = null;
										num4 = deltaTime;
										break;
									}
								}
								else
								{
									bool flag19 = held == null;
									array5 = array4;
									text2 = null;
									obj7 = null;
									num4 = deltaTime;
									if (flag19)
									{
										break;
									}
									bool flag20 = (nint)obj11 < array7.Length;
									object obj25 = !flag20;
									if (obj25 != null)
									{
										goto IL_0e94;
									}
									object obj26 = (object)held + obj11;
									bool flag21 = (nint)array3 < 0;
									object obj27 = (object)array3 ^ (object)array3;
									object obj28 = (object)array3 & obj27;
									bool flag22 = (nint)obj28 < 0;
									bool flag23 = flag21 == flag22;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X13_v9+20]");
									bool flag24 = (nint)0 == 0;
									object obj29 = !flag24;
									bool[] array10 = (bool[])(flag23 ^ obj29);
									object obj30 = array10 & 1;
									bool flag25 = obj30 == null;
									object obj31 = !flag25;
									if (obj31 == null)
									{
										array5 = atEnd;
										bool flag26 = atEnd == null;
										text2 = null;
										obj7 = null;
										num4 = deltaTime;
										if (flag26)
										{
											break;
										}
										bool flag27 = (nint)obj11 < array5.Length;
										object obj32 = !flag27;
										if (obj32 != null)
										{
											goto IL_0e94;
										}
										object obj33 = (object)atEnd + obj11;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ X13_v16+20]");
										bool flag28 = (nint)0 == 0;
										bool[] array11 = (bool[])(!flag28);
										bool flag29 = obj12 == array11;
										array10 = array11;
										array4 = array11;
										if (flag29)
										{
											goto IL_0ff3;
										}
									}
									dirty = true;
									array4 = array10;
								}
								goto IL_0ff3;
							}
						}
					}
				}
				else
				{
					float num6 = message;
					if (message > 0f)
					{
						num6 -= num4;
						bool flag30 = num6 < 0f;
						object obj34 = !flag30;
						bool flag31 = num6 == 0f;
						message = num6;
						object obj35 = !flag31;
						object obj36 = obj34 & obj35;
						if (obj36 == null)
						{
							dirty = true;
						}
					}
					int num7 = (int)(paying & 0x80000000L);
					bool flag32 = num7 == 0;
					object obj37 = !flag32;
					if (obj37 == null)
					{
						object obj38 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X0_v64+E4]");
						bool flag33 = (nint)0 == 0;
						object obj39 = !flag33;
						if (obj39 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool busy = GillaPurchases.Busy;
						bool flag34 = !busy;
						object obj40 = !flag34;
						if (obj40 == null)
						{
							float time = Time.time;
							num6 = time - paidAt;
							bool flag35 = !(num6 > 1.1230249E+09f);
							num2 = 1.1230249E+09f;
							if (!flag35)
							{
								paying = -1;
								num2 = 1.1230249E+09f;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
					object obj41 = 0;
					object obj42 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X0_v14+E4]");
					bool flag36 = (nint)0 == 0;
					object obj43 = !flag36;
					if (obj43 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int balance = Coins.Balance;
					if (balance != lastBalance)
					{
						int num8 = (int)(paying & 0x80000000L);
						bool flag37 = num8 == 0;
						object obj44 = !flag37;
						if (obj44 == null)
						{
							object obj45 = obj41;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X0_v44+E4]");
							bool flag38 = (nint)0 == 0;
							object obj46 = !flag38;
							if (obj46 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							int balance2 = Coins.Balance;
							if (balance2 > balanceWhenPaid)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF568]");
								object obj47 = 0;
								object obj48 = obj47;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v49+E4]");
								bool flag39 = (nint)0 == 0;
								object obj49 = !flag39;
								if (obj49 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj48 = obj47;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v49+A0]");
								object obj50 = 0;
								object obj51 = obj50;
								if (obj50 == null)
								{
									break;
								}
								int num9 = paying;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v35+18]");
								bool flag40 = (nint)num9 < (nint)0;
								object obj52 = !flag40;
								if (obj52 != null)
								{
									goto IL_0e94;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
								array7 = (bool[])0;
								object obj53 = paying * 24;
								object obj54 = obj50 + obj53;
								int num10 = obj54 + 40;
								string text3 = ((int*)num10)->ToString((string)(object)array7);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60E0]");
								object obj55 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6150]");
								object obj56 = 0;
								text2 = (string)obj56;
								string text4 = (string)obj55 + text3 + (string)obj56;
								object obj57 = this + 208;
								obj57 = text4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								messageBad = false;
								message = 2.5f;
								AudioClip clip = coinSound;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
								Play(clip, 0f);
								Play(sparkleSound, 0.5f);
								paying = -1;
								obj58 = 0;
								array3 = (bool[])24;
								obj7 = sparkleSound;
								num6 = 0.5f;
							}
						}
						object obj59 = obj41;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X0_v39+E4]");
						bool flag41 = (nint)0 == 0;
						object obj60 = !flag41;
						if (obj60 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int balance3 = Coins.Balance;
						lastBalance = balance3;
						dirty = true;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF568]");
					object obj61 = 0;
					object obj62 = obj61;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj63 = 0;
					text5 = (string)obj63;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v20+E4]");
					bool flag42 = (nint)0 == 0;
					object obj64 = !flag42;
					if (obj64 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj62 = obj61;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v20+A0]");
					object obj65 = 0;
					obj8 = obj65;
					if (obj65 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X23_v4+18]");
					if ((nint)0 < (nint)1)
					{
						goto IL_0e14;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X23_v4+18]");
					object obj66 = 0 & 0xFFFFFFFFL;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
					object obj67 = 0;
					object obj68 = obj65 + 32;
					object obj69 = obj58;
					object obj70 = 0;
					string text6 = text5;
					while (true)
					{
						bool flag43 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj70) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj66);
						object obj71 = !flag43;
						if (obj71 != null)
						{
							break;
						}
						object obj72 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ X0_v29+E4]");
						bool flag44 = (nint)0 == 0;
						object obj73 = !flag44;
						if (obj73 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						string text7 = GillaPurchases.PriceOf((string)obj68);
						text2 = (string)obj67;
						string text8 = text6 + text7 + (string)obj67;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X23_v4+18]");
						obj66 = 0;
						obj70++;
						obj68 += 24;
						object obj74 = obj70;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X23_v4+18]");
						bool flag45 = (nint)obj74 < 0;
						obj58 = 0;
						text5 = text8;
						obj69 = 0;
						obj7 = (UnityEngine.Object)(object)text7;
						text6 = text8;
						if (flag45)
						{
							continue;
						}
						goto IL_0e14;
					}
				}
				goto IL_0e94;
				IL_0ff3:
				bool flag46 = (nint)obj11 < array7.Length;
				object obj75 = !flag46;
				if (obj75 == null)
				{
					object obj76 = ~array3;
					array7 = (bool[])(object)((object)array7 + obj11);
					obj10 = obj76 >> 31;
					array3 = atEnd;
					array7[0] = (byte)(int)obj10 != 0;
					bool flag47 = atEnd == null;
					array5 = array4;
					text2 = null;
					obj7 = null;
					num4 = deltaTime;
					if (flag47)
					{
						break;
					}
					bool flag48 = (nint)obj11 < array3.Length;
					object obj77 = !flag48;
					if (obj77 == null)
					{
						array2 = (bool[])(object)((object)atEnd + obj11);
						array2[0] = (byte)(int)obj12 != 0;
						int num11 = (int)(paying & 0x80000000L);
						bool flag49 = num11 == 0;
						object obj78 = !flag49;
						bool flag50;
						if (obj78 == null)
						{
							flag50 = true;
							array = slides;
						}
						else
						{
							object obj79 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ X0_v78+E4]");
							bool flag51 = (nint)0 == 0;
							object obj80 = !flag51;
							if (obj80 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							flag50 = GillaPurchases.Busy;
							array = slides;
						}
						array6 = (bool[])paying;
						obj9 = obj10;
						num = num2;
						obj12 = flag50;
						goto IL_0ed3;
					}
				}
				goto IL_0e94;
				IL_0ed3:
				obj11++;
				bool flag52 = array == null;
				obj81 = !flag52;
				array3 = array2;
				array5 = array4;
				array7 = array6;
				obj10 = obj9;
				num2 = num;
				text2 = null;
				obj7 = null;
				num4 = deltaTime;
				text = null;
				continue;
				IL_0e94:
				throw new IndexOutOfRangeException();
				IL_0e14:
				object obj82 = this + 240;
				if (text5 != (string)obj82)
				{
					pricesShown = text5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					dirty = true;
				}
				else if (~(dirty ? 1u : 0u) != 0)
				{
					return;
				}
				Draw();
				return;
			}
			while (obj81 != null);
		}
		throw new NullReferenceException();
	}

	private void Drop(int i)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0071: Expected Obj, but got I4
		//IL_05af: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I4
		//IL_01ac: Expected Obj, but got I4
		//IL_01da: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I
		//IL_0495: Expected Obj, but got I
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got Unknown
		//IL_061f: Expected F4, but got I
		//IL_04bd: Expected Obj, but got I4
		//IL_0247: Expected Obj, but got I4
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Obj, but got Unknown
		//IL_04f2: Expected Obj, but got I
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_027c: Expected Obj, but got I
		//IL_0559: Expected F4, but got I
		//IL_0559: Expected Obj, but got I
		//IL_02f4: Expected F4, but got I
		//IL_02f4: Expected F4, but got I
		//IL_02f4: Expected Obj, but got I
		//IL_0304: Expected Obj, but got I
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_0354: Expected F4, but got I
		//IL_0384: Expected Obj, but got I
		//IL_03b8: Expected Obj, but got I4
		//IL_03ee: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I
		//IL_0428: Expected I, but got Obj
		//IL_0452: Expected Obj, but got I4
		//IL_0484: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF5D0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF568]");
			object obj3 = 0;
			object obj4 = obj2 + 16;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v11+A0]");
			object obj7 = 0;
			object obj8 = obj7;
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3 (System.Object)+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v7+18]");
				bool flag2 = num < 0;
				object obj9 = !flag2;
				if (obj9 != null)
				{
					goto IL_0568;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3 (System.Object)+18]");
				object obj11 = (nint)0 * (nint)24;
				object obj12 = obj7 + obj11;
				object obj13 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v13+E4]");
				bool flag3 = (nint)0 == 0;
				object obj14 = !flag3;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj15;
				if (GillaPurchases.Busy)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF5E8]");
					obj15 = 0;
				}
				else
				{
					object obj16 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v21+E4]");
					bool flag4 = (nint)0 == 0;
					object obj17 = !flag4;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v8+20]");
					string text = GillaPurchases.PriceOf((string)0);
					if (text != null)
					{
						SlideOrb[] array = slides;
						if (slides != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3 (System.Object)+18]");
							bool flag5 = (nint)0 < (nint)array.Length;
							object obj18 = !flag5;
							if (obj18 != null)
							{
								goto IL_0568;
							}
							SlideOrb[] array2 = slides;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3 (System.Object)+18]");
							object obj19 = array2 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v20+20]");
							SlideOrb slideOrb = (SlideOrb)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v20+20]");
							if ((nint)0 != 0)
							{
								slideOrb.popT = 0f;
								slideOrb.x = 0f;
								slideOrb.v = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v20+20]");
								nint num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
								((SlideOrb)num2).Buzz((float)num3, 0f);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF5F0]");
								object obj20 = 0;
								object obj21 = this + 208;
								obj21 = obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								messageBad = false;
								message = 180f;
								AudioClip clip = buySound;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
								Play(clip, 0f);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3 (System.Object)+18]");
								paying = 0;
								float time = Time.time;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
								object obj22 = 0;
								paidAt = time;
								object obj23 = obj22;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v31+E4]");
								bool flag6 = (nint)0 == 0;
								object obj24 = !flag6;
								if (obj24 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								int balance = Coins.Balance;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF5D8]");
								object obj25 = 0;
								balanceWhenPaid = balance;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF5E0]");
								object obj26 = 0;
								Action<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> action = default;
								action._002Ector(obj2, (IntPtr)obj26);
								object obj27 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v37+E4]");
								bool flag7 = (nint)0 == 0;
								object obj28 = !flag7;
								if (obj28 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v8+20]");
								GillaPurchases.Buy((string)0, (Action<GillaPurchases.Result>)(object)action);
								return;
							}
						}
						goto IL_055a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF5F8]");
					obj15 = 0;
				}
				object obj29 = this + 208;
				obj29 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				messageBad = true;
				message = 2.5f;
				AudioClip clip2 = errorSound;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				Play(clip2, 0f);
				SlideOrb[] array3 = slides;
				if (slides != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3 (System.Object)+18]");
					bool flag8 = (nint)0 < (nint)array3.Length;
					object obj30 = !flag8;
					if (obj30 != null)
					{
						goto IL_0568;
					}
					SlideOrb[] array4 = slides;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3 (System.Object)+18]");
					object obj31 = array4 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v13+20]");
					SlideOrb slideOrb2 = (SlideOrb)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v13+20]");
					if ((nint)0 != 0)
					{
						slideOrb2.shake = 0.45f;
						slideOrb2.v = -2f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v13+20]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
						((SlideOrb)num4).Buzz(0.5f, 0f);
						return;
					}
				}
			}
		}
		goto IL_055a;
		IL_0568:
		throw new IndexOutOfRangeException();
		IL_055a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0568;
	}

	private void Say(string s, bool bad, float lasts = default(float))
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 208;
		obj = s;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 1;
	}

	private void Play(AudioClip clip, float volume)
	{
		//IL_0010: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_016c: Expected Obj, but got I
		//IL_0184: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I
		//IL_0203: Expected Obj, but got I4
		//IL_010d: Expected VT, but got I4
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
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v13+A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
				object obj9 = 0;
				object obj10 = obj9;
				object obj11 = default;
				float num = (float)obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v14+20]");
				float pitchMax = num + 0f;
				float num2 = volume;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v14+18]");
				float volume2 = num2 + 0f;
				object obj12 = default;
				float num3 = (float)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v14+1C]");
				float pitchMin = num3 + 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v19+E4]");
				bool flag2 = (nint)0 == 0;
				object obj13 = !flag2;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Sfx.Play(array, (Vector3)0, volume2, pitchMin, pitchMax);
				return;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	public void Refresh()
	{
		//IL_0010: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I4
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
		if (tex == null)
		{
			OnEnable();
		}
		Draw();
	}

	private void Draw()
	{
		//IL_0010: Expected Obj, but got I
		//IL_06cf: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I
		//IL_0190: Expected Obj, but got I4
		//IL_0212: Expected Obj, but got I4
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected I4, but got Unknown
		//IL_0724: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I4
		//IL_0742: Expected Obj, but got I
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected I4, but got Unknown
		//IL_077f: Expected Obj, but got I
		//IL_07b3: Expected Obj, but got I
		//IL_0823: Expected Obj, but got I4
		//IL_07ec: Expected Obj, but got I
		//IL_02e6: Expected Obj, but got I4
		//IL_0841: Expected Obj, but got I
		//IL_0851: Expected Obj, but got I
		//IL_0889: Expected Obj, but got I
		//IL_0894: Invalid comparison between F4 and I4
		//IL_08ad: Expected Obj, but got I
		//IL_0589: Expected Obj, but got I4
		//IL_033e: Expected Obj, but got I
		//IL_05e4: Expected Obj, but got I
		//IL_0635: Expected Obj, but got I4
		//IL_0377: Expected Obj, but got I
		//IL_03a1: Expected Obj, but got I4
		//IL_066a: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I4
		//IL_08e6: Expected Obj, but got I
		//IL_08fe: Expected VT, but got I8
		//IL_08fe: Expected VT, but got I8
		//IL_0486: Expected Obj, but got I4
		//IL_0948: Expected Obj, but got I
		//IL_0437: Expected Obj, but got I4
		//IL_0995: Expected VT, but got I8
		//IL_0995: Expected VT, but got I8
		//IL_092d: Expected Obj, but got I
		//IL_0514: Expected Obj, but got I4
		//IL_0978: Expected Obj, but got I
		//IL_04cd: Expected Obj, but got I4
		//IL_0963: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		dirty = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = tex == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null || px == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaBoardLook.Clear(px, 200, 240);
		GillaBoardLook.Frame(px, 200, 240, 3);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v6+A0]");
		object colours = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CAEC8]");
		object s = 0;
		Text(title, 12, 9, (string)s, (Color32[])colours, 1, centred: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string s2 = Coins.Text;
		object obj12;
		if (this.text != null)
		{
			int num = this.text.Measure(s2, 2);
			obj12 = num + 20;
			int num2 = 0;
		}
		else
		{
			obj12 = 80;
			int num2 = 9;
		}
		int x = 188 - obj12;
		CoinIcon(x, 10);
		object obj13 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v19+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v19+A0]");
		object obj15 = 0;
		int x2 = 208 - obj12;
		ScreenFont font = this.text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v14+30]");
		Text(font, x2, 8, s2, (Color32[])0, 2, centred: false);
		GillaBoardLook.Rule(px, 200, 240, 8, 191, 42);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF568]");
		object obj16 = 0;
		int num3 = 50;
		int num4 = 240;
		int num5 = 200;
		int num6 = 0;
		while (true)
		{
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v24+E4]");
			bool flag7 = (nint)0 == 0;
			object obj18 = !flag7;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj16;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v24+A0]");
			object obj19 = 0;
			object obj20 = obj19;
			int num7 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v19+18]");
			if ((nint)num7 >= (nint)0)
			{
				break;
			}
			Row(num6, num3);
			int num8 = num6 + 1;
			num3 += 44;
			num4 = num3;
			num5 = num6;
			num6 = num8;
		}
		object obj21 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v28+E4]");
		bool flag8 = (nint)0 == 0;
		object obj22 = !flag8;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v28+A0]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF5B0]");
		object obj24 = 0;
		string text = (string)obj24;
		ScreenFont font2 = this.text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v23+10]");
		Text(font2, 100, 224, (string)obj24, (Color32[])0, 1, centred: true);
		bool flag9 = !(message > 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v23+10]");
		Color32[] array = (Color32[])0;
		bool flag10 = true;
		int num9 = 1;
		int num10 = 224;
		if (!flag9)
		{
			string text2 = messageText;
			bool flag11 = text2._stringLength < 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v23+10]");
			array = (Color32[])0;
			flag10 = true;
			num9 = 1;
			num10 = 224;
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
				object obj25 = 0;
				object obj26 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v46+E4]");
				bool flag12 = (nint)0 == 0;
				object obj27 = !flag12;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj28 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X0_v49+E4]");
				bool flag13 = (nint)0 == 0;
				object obj29 = !flag13;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj28 = obj16;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X0_v49+A0]");
				object obj30 = 0;
				Fill((RectInt)463856467982L, (Color32)94489280684L);
				if (~(messageBad ? 1u : 0u) == 0)
				{
					object obj31 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v67+E4]");
					bool flag14 = (nint)0 == 0;
					object obj32 = !flag14;
					if (obj32 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj31 = obj5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v67+A0]");
					object obj33 = (nint)0 + (nint)40;
				}
				else
				{
					object obj34 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v63+E4]");
					bool flag15 = (nint)0 == 0;
					object obj35 = !flag15;
					if (obj35 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj34 = obj16;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v63+A0]");
					object obj33 = (nint)0 + (nint)12;
				}
				Outline((RectInt)463856467982L, (Color32)94489280684L);
				object obj36 = obj5;
				object obj38;
				if (~(messageBad ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v56+E4]");
					bool flag16 = (nint)0 == 0;
					object obj37 = !flag16;
					if (obj37 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj36 = obj5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v56+A0]");
					obj38 = (nint)0 + (nint)16;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v56+E4]");
					bool flag17 = (nint)0 == 0;
					object obj39 = !flag17;
					if (obj39 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj36 = obj5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v56+A0]");
					obj38 = 0;
				}
				array = (Color32[])obj38;
				Text(this.text, 100, 113, messageText, (Color32[])obj38, 1, centred: true);
				flag10 = true;
				num9 = 1;
				text = messageText;
				num10 = 113;
			}
		}
		tex.SetPixels32(px);
		tex.Apply(updateMipmaps: true);
		object obj40 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X0_v33+E4]");
		bool flag18 = (nint)0 == 0;
		object obj41 = !flag18;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(screen == null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			screen.GetPropertyBlock(materialPropertyBlock);
			object obj43 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v40+E4]");
			bool flag19 = (nint)0 == 0;
			object obj44 = !flag19;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj45 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v29+A0]");
			object obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v30+8]");
			materialPropertyBlock.SetTexture(0, tex);
			screen.SetPropertyBlock(materialPropertyBlock);
		}
	}

	private unsafe void Row(int i, int top)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0b3f: Expected Obj, but got I4
		//IL_0ff7: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_01a4: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_0176: Expected Obj, but got I
		//IL_0234: Expected Obj, but got I4
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0254: Expected Obj, but got I4
		//IL_0263: Expected Obj, but got I4
		//IL_028e: Expected F8, but got I4
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_0226: Expected Obj, but got I
		//IL_0baf: Expected Obj, but got I
		//IL_0bbf: Expected Obj, but got I
		//IL_035f: Expected Obj, but got I
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_03bc: Expected Obj, but got I4
		//IL_02fa: Expected Obj, but got I4
		//IL_031c: Expected Obj, but got I4
		//IL_0c22: Expected Obj, but got I
		//IL_0c40: Expected Obj, but got I
		//IL_0c6f: Expected Obj, but got I
		//IL_0c99: Expected Obj, but got I4
		//IL_0bec: Expected Obj, but got I
		//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Expected VT, but got Unknown
		//IL_0c0d: Expected VT, but got I8
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_02df: Expected F8, but got I
		//IL_0cf0: Expected Obj, but got I4
		//IL_102c: Expected Obj, but got I
		//IL_1074: Expected Obj, but got I
		//IL_04d8: Expected Obj, but got I4
		//IL_04e7: Expected Obj, but got I4
		//IL_0d0d: Expected VT, but got I4
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected Obj, but got Unknown
		//IL_0560: Expected Obj, but got I4
		//IL_056f: Expected Obj, but got I4
		//IL_0d98: Expected Obj, but got I
		//IL_0db0: Expected Obj, but got I
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected Obj, but got Unknown
		//IL_0d49: Expected VT, but got I4
		//IL_0d5b: Expected Obj, but got I4
		//IL_0d72: Expected VT, but got I4
		//IL_0d7a: Expected VT, but got I4
		//IL_0658: Invalid comparison between F8 and I4
		//IL_0667: Invalid comparison between F8 and I4
		//IL_067f: Expected Obj, but got F8
		//IL_068c: Expected Obj, but got F8
		//IL_06b5: Expected Obj, but got I4
		//IL_06ce: Expected Obj, but got I4
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected Obj, but got Unknown
		//IL_05d1: Expected Obj, but got I4
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected Obj, but got Unknown
		//IL_0617: Expected VT, but got I4
		//IL_0e95: Invalid comparison between F8 and I4
		//IL_0e7e: Expected Obj, but got I4
		//IL_0dc5: Expected Obj, but got I
		//IL_0ddd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Expected VT, but got Unknown
		//IL_0df5: Expected VT, but got I8
		//IL_0e21: Expected VT, but got I8
		//IL_0e46: Expected I4, but got I8
		//IL_10ad: Expected Obj, but got I
		//IL_10d7: Expected Obj, but got I4
		//IL_071a: Expected F8, but got I4
		//IL_0741: Invalid comparison between F8 and I4
		//IL_0f39: Expected Obj, but got F8
		//IL_0f41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f46: Expected Obj, but got Unknown
		//IL_0f68: Expected Obj, but got I4
		//IL_10f5: Expected Obj, but got I
		//IL_1102: Unknown result type (might be due to invalid IL or missing references)
		//IL_1107: Expected VT, but got Unknown
		//IL_110f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1114: Expected VT, but got Unknown
		//IL_0ee7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eec: Expected Obj, but got Unknown
		//IL_0f06: Expected Obj, but got I4
		//IL_097c: Expected Obj, but got I4
		//IL_0887: Expected Obj, but got I4
		//IL_09d1: Expected Obj, but got I
		//IL_1163: Expected VT, but got Obj
		//IL_117d: Expected Obj, but got I4
		//IL_08e4: Expected Obj, but got I
		//IL_0903: Expected VT, but got I
		//IL_092d: Expected Obj, but got I4
		//IL_0a26: Expected Obj, but got I
		//IL_0f8c: Expected Obj, but got I
		//IL_09ef: Expected F8, but got I
		//IL_09ff: Invalid comparison between F8 and I
		//IL_0ada: Expected Obj, but got I4
		//IL_0a6c: Expected Obj, but got I
		//IL_0fe2: Expected Obj, but got I
		//IL_0a93: Expected Obj, but got I4
		//IL_0fc7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF568]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3+A0]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj17;
		object obj23;
		double num;
		object obj30;
		int num9;
		int num10;
		object obj58;
		double num17;
		double num18;
		double num20;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v5+18]");
			bool flag2 = (nint)0 < (nint)i;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v5+18]");
			object obj7 = -i;
			bool flag3 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag3;
			if (obj9 != null)
			{
				goto IL_0b0e;
			}
			object obj10 = i * 24;
			object obj11 = obj4 + obj10;
			bool[] array = held;
			if (held != null)
			{
				bool flag4 = array.Length < i;
				object obj12 = !flag4;
				object obj13 = array.Length - i;
				bool flag5 = obj13 == null;
				if (array.Length > i)
				{
					object obj14 = ~obj12;
					object obj15 = obj14 | flag5;
					if (obj15 != null)
					{
						goto IL_0b0e;
					}
					object obj16 = held + i;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v91+20]");
					obj17 = 0;
				}
				else
				{
					obj17 = 0;
				}
				bool[] array2 = atEnd;
				if (atEnd != null)
				{
					bool flag6 = array2.Length < i;
					object obj18 = !flag6;
					object obj19 = array2.Length - i;
					bool flag7 = obj19 == null;
					if (array2.Length > i)
					{
						object obj20 = ~obj18;
						object obj21 = obj20 | flag7;
						if (obj21 != null)
						{
							goto IL_0b0e;
						}
						object obj22 = atEnd + i;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v90+20]");
						obj23 = 0;
					}
					else
					{
						obj23 = 0;
					}
					float[] array3 = along;
					if (along != null)
					{
						bool flag8 = array3.Length < i;
						object obj24 = !flag8;
						object obj25 = array3.Length - i;
						bool flag9 = obj25 == null;
						bool flag10 = array3.Length <= i;
						num = 0.0;
						if (!flag10)
						{
							object obj26 = ~obj24;
							object obj27 = obj26 | flag9;
							if (obj27 != null)
							{
								goto IL_0b0e;
							}
							object obj28 = along + i;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v89+20]");
							num = 0.0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E8]");
						object obj29 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
						obj30 = 0;
						if (obj17 != null)
						{
							object obj31 = obj30;
							object obj32 = top - 3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v88+E4]");
							bool flag11 = (nint)0 == 0;
							object obj33 = !flag11;
							if (obj33 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj31 = obj30;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v88+A0]");
							object obj34 = 0;
							RectInt r = (RectInt)(8 | obj32);
							Fill(r, (Color32)171798692024L);
						}
						int y = top + 3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
						object obj35 = 0;
						CoinIcon(14, y);
						string sku = default;
						int num2 = (int)((nint)(&sku) | (nint)8);
						string s = ((int*)num2)->ToString((string)obj29);
						object obj36 = obj30;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v17+E4]");
						bool flag12 = (nint)0 == 0;
						object obj37 = !flag12;
						if (obj37 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj36 = obj30;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v17+A0]");
						object obj38 = 0;
						int num3 = top + 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF630]");
						object obj39 = 0;
						ScreenFont font = this.text;
						int y2 = num3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v18+30]");
						Text(font, 34, y2, s, (Color32[])0, 2, centred: false);
						object obj40 = obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v14+E4]");
						bool flag13 = (nint)0 == 0;
						object obj41 = !flag13;
						if (obj41 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						string text = GillaPurchases.PriceOf(sku);
						string text2 = (string)((text != null) ? text : obj39);
						ScreenFont screenFont;
						int num6;
						if (this.text != null)
						{
							int num4 = this.text.Measure(text2, 1);
							screenFont = this.text;
							num3 = 0;
							ScreenFont screenFont2 = (ScreenFont)(object)text2;
							int num5 = 1;
							num6 = num4;
						}
						else
						{
							screenFont = null;
							ScreenFont screenFont2 = this.text;
							int num5 = 34;
							num6 = 30;
						}
						object obj42 = obj30;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X0_v21+E4]");
						bool flag14 = (nint)0 == 0;
						object obj43 = !flag14;
						if (obj43 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj42 = obj30;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X0_v21+A0]");
						object obj44 = 0;
						int num7 = top + 6;
						int num8 = 186 - num6;
						ScreenFont font2 = screenFont;
						int x = num8;
						int y3 = num7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v22+8]");
						Text(font2, x, y3, text2, (Color32[])0, 1, centred: false);
						Vector3[] array4 = trackFrom;
						if (trackFrom != null)
						{
							bool flag15 = array4.Length < i;
							object obj45 = !flag15;
							object obj46 = array4.Length - i;
							bool flag16 = obj46 == null;
							if (array4.Length > i)
							{
								object obj47 = ~obj45;
								object obj48 = obj47 | flag16;
								if (obj48 != null)
								{
									goto IL_0b0e;
								}
							}
							num9 = Column((Vector3)22, num8);
							Vector3[] array5 = trackTo;
							if (trackTo != null)
							{
								bool flag17 = array5.Length < i;
								object obj49 = !flag17;
								object obj50 = array5.Length - i;
								bool flag18 = obj50 == null;
								if (array5.Length > i)
								{
									object obj51 = ~obj49;
									object obj52 = obj51 | flag18;
									if (obj52 != null)
									{
										goto IL_0b0e;
									}
									object obj53 = i * 12;
									object obj54 = (object)trackTo + obj53;
									object obj55 = obj54 + 32;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
									object obj56 = 0;
									object obj57 = obj56;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v72+A0]");
									object obj55 = 0;
								}
								num10 = Column((Vector3)172, num8);
								obj58 = top + 32;
								bool flag19 = num9 > num10;
								RectInt rectInt = (RectInt)172;
								Color32 color = (Color32)num8;
								if (!flag19)
								{
									object obj59 = obj58 << 32;
									int num11 = num7;
									Vector3 vector = (Vector3)172;
									int num12 = num9;
									bool flag21;
									do
									{
										object obj60 = obj30;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v69+E4]");
										bool flag20 = (nint)0 == 0;
										object obj61 = !flag20;
										if (obj61 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj60 = obj30;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v69+A0]");
										object obj62 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X8_v66+24]");
										num7 = 0;
										rectInt = (RectInt)(obj59 | num12);
										Fill(rectInt, (Color32)8589934594L);
										num12 += 4;
										flag21 = num12 <= num10;
										color = (Color32)8589934594L;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X8_v66+24]");
										num11 = 0;
										vector = (Vector3)rectInt;
										num8 = 2;
									}
									while (flag21);
								}
								double num13 = num - 1.0;
								bool flag22 = num13 < 0.0;
								bool flag23 = num13 == 0.0;
								object obj63 = num ^ 1.0;
								object obj64 = num ^ num13;
								object obj65 = obj63 & obj64;
								bool flag24 = (nint)obj65 < 0;
								object obj66 = num10 - num9;
								bool flag25 = flag22 == flag24;
								object obj67 = !flag25;
								object obj68 = obj67 | flag23;
								object obj69 = ~obj68;
								double num14 = ((obj69 != null) ? 1.0 : num);
								if (num < 0.0)
								{
									num14 = 0.0;
								}
								double num15 = (double)obj66 * num14;
								double num16 = num15 + (double)num9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
								object obj70 = 0;
								object obj71 = obj70;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X0_v31+E4]");
								bool flag26 = (nint)0 == 0;
								object obj72 = !flag26;
								if (obj72 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
								double num19 = default;
								if (num16 < 0.0)
								{
									if (num16 == -0.5)
									{
										num17 = -1.0;
										num18 = num19;
										goto IL_0ecf;
									}
									num18 = num16 + -0.5;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
									num20 = -0.5;
								}
								else
								{
									if (num16 == 0.5)
									{
										num17 = 1.0;
										num18 = num19;
										goto IL_0ecf;
									}
									num18 = num16 + 0.5;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
									num20 = 0.5;
								}
								goto IL_0f19;
							}
						}
					}
				}
			}
		}
		goto IL_0b00;
		IL_0b0e:
		throw new IndexOutOfRangeException();
		IL_0f19:
		object obj73 = obj;
		double num21 = num18 - (double)num9;
		object obj74 = ~num21;
		object obj75 = num21 & obj74;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v36+E4]");
		bool flag27 = (nint)0 == 0;
		object obj76 = !flag27;
		if (obj76 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj73 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v36+A0]");
		object obj77 = 0;
		Color32 c = (Color32)(obj75 | 0x200000000L);
		RectInt r2 = (RectInt)(num9 | obj58);
		Fill(r2, c);
		object obj84;
		int r3;
		if (obj23 != null)
		{
			object obj78 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v53+E4]");
			bool flag28 = (nint)0 == 0;
			object obj79 = !flag28;
			if (obj79 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((object)this == null)
			{
				goto IL_0b00;
			}
			object obj80 = obj;
			int cy = top + 33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X8_v57+A0]");
			object obj81 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v58+18]");
			Circle(num10, cy, 10, (Color32)0);
			object obj82 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v843 @ X0_v57+E4]");
			bool flag29 = (nint)0 == 0;
			object obj83 = !flag29;
			if (obj83 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj82 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v843 @ X0_v57+A0]");
			obj84 = (nint)0 + (nint)24;
			r3 = 7;
		}
		else
		{
			object obj85 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ X0_v50+E4]");
			bool flag30 = (nint)0 == 0;
			object obj86 = !flag30;
			if (obj86 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((object)this == null)
			{
				goto IL_0b00;
			}
			object obj87 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X8_v53+A0]");
			obj84 = (nint)0 + (nint)40;
			r3 = 8;
		}
		int cy2 = top + 33;
		Circle(num10, cy2, r3, (Color32)obj84);
		bool flag31 = obj17 == null;
		object obj88 = !flag31;
		if (obj88 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			num18 = 0.0;
			double num22 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			if (!(num22 > 0.0))
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF620]");
		object s2 = 0;
		object obj89 = obj30;
		int x2 = num10 - 2;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF628]");
			s2 = 0;
		}
		object colours;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X0_v44+E4]");
			bool flag32 = (nint)0 == 0;
			object obj90 = !flag32;
			if (obj90 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj89 = obj30;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X0_v44+A0]");
			colours = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X0_v44+E4]");
			bool flag33 = (nint)0 == 0;
			object obj91 = !flag33;
			if (obj91 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj89 = obj30;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X0_v44+A0]");
			colours = (nint)0 + (nint)16;
		}
		int y4 = top + 18;
		Text(this.text, x2, y4, (string)s2, (Color32[])colours, 1, centred: true);
		return;
		IL_0ecf:
		num20 = num18 + num17;
		object obj92 = num18 & 1;
		bool flag34 = obj92 == null;
		object obj93 = !flag34;
		if (obj93 != null)
		{
			num18 = num20;
		}
		goto IL_0f19;
		IL_0b00:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0b0e;
	}

	private int Column(Vector3 local, int otherwise)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02f6: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_00d8: Expected I4, but got VT
		//IL_0086: Expected Obj, but got I4
		//IL_02cc: Expected I4, but got Obj
		//IL_013a: Expected VT, but got I4
		//IL_0169: Expected VT, but got I4
		//IL_0319: Expected Obj, but got I
		//IL_0343: Expected Obj, but got I4
		//IL_01b8: Invalid comparison between F8 and I4
		//IL_03b4: Invalid comparison between F8 and I4
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_03d5: Expected Obj, but got F8
		//IL_040a: Expected Obj, but got I4
		//IL_02b9: Expected F8, but got I4
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected Obj, but got Unknown
		//IL_0388: Expected Obj, but got I4
		//IL_042a: Expected Obj, but got F8
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = screen == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		double num3;
		double num4;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(trackFrame == null))
			{
				if ((object)screen != null)
				{
					Transform transform = screen.transform;
					if ((object)trackFrame != null)
					{
						Vector3 vector = trackFrame.TransformPoint((Vector3)0);
						if ((object)transform != null)
						{
							Vector3 vector2 = transform.InverseTransformPoint((Vector3)0);
							object obj7 = default;
							double num = (double)obj7 + 0.5;
							double num2 = num * 1128792064.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj8 = 0;
							object obj9 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v22+E4]");
							bool flag5 = (nint)0 == 0;
							object obj10 = !flag5;
							if (obj10 == null)
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
									goto IL_0351;
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
									goto IL_0351;
								}
								num4 = num2 + 0.5;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
							}
							goto IL_039b;
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
		}
		return (int)local;
		IL_039b:
		double num6 = num4 - 199.0;
		bool flag6 = num6 < 0.0;
		object obj11 = num4 ^ 0xC7;
		object obj12 = num4 ^ num6;
		object obj13 = obj11 & obj12;
		bool flag7 = (nint)obj13 < 0;
		bool flag8 = flag6 == flag7;
		object obj14 = !flag8;
		object obj15 = ~obj14;
		double num7 = ((obj15 != null) ? 199.0 : num4);
		object obj16 = ~num7;
		return num7 & obj16;
		IL_0351:
		double num8 = num4 + num3;
		object obj17 = num4 & 1;
		bool flag9 = obj17 == null;
		object obj18 = !flag9;
		if (obj18 != null)
		{
			num4 = num8;
		}
		goto IL_039b;
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
				int num = font.DrawCentred(px, 200, 240, x, y, s, ref s2);
			}
			else
			{
				int num2 = font.Draw(px, 200, 240, x, y, s, ref s2);
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
		GillaBoardLook.Coin(px, 200, 240, x, y, 2);
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
			object obj6 = obj5 / 1116733440;
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
			flag5 = (nint)obj2 != 72;
			num3 = (int)color;
		}
		while (flag5);
	}

	private void Set(int x, int y, Color32 c)
	{
		//IL_0059: Expected I4, but got I8
		//IL_0073: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I4
		if (y > 239 || x > 199)
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
			object obj2 = 239 - y;
			object obj3 = obj2 * 200;
			object obj4 = x + obj3;
			bool flag2 = (nint)obj4 < array.Length;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				object obj6 = (object)px + obj4;
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	private void Fill(RectInt r, Color32 c)
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

	public GillaAtm()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF578]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj7 = this + 40;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj9 = this + 56;
		object obj10 = default;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj11 = this + 64;
		object obj12 = default;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj13 = this + 168;
		object obj14 = default;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj15 = this + 176;
		object obj16 = default;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj17 = this + 184;
		object obj18 = default;
		obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj19 = this + 192;
		object obj20 = default;
		obj19 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj21 = this + 208;
		obj21 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		dirty = true;
		object obj22 = this + 240;
		obj22 = obj6;
		lastBalance = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	unsafe static GillaAtm()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_03bf: Expected Obj, but got Ref
		//IL_006a: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got Ref
		//IL_00dd: Expected Obj, but got I8
		//IL_010a: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0159: Expected Obj, but got Ref
		//IL_0185: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01de: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_022d: Expected Obj, but got Ref
		//IL_0251: Expected Obj, but got I8
		//IL_027e: Expected Obj, but got I
		//IL_028e: Expected Obj, but got I
		//IL_029e: Expected Obj, but got I
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02d8: Expected Obj, but got I
		//IL_0324: Expected Obj, but got I
		//IL_034b: Expected Obj, but got I4
		//IL_03de: Expected Obj, but got I
		//IL_03fb: Expected Obj, but got I
		//IL_0415: Expected Obj, but got I
		//IL_042f: Expected Obj, but got I
		//IL_0383: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF638]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF640]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF648]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = default;
		object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF670]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF5C8]");
			object obj7 = 0;
			object obj9 = default;
			object obj8 = obj9 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 16));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+18]");
			object obj11 = 0 & 0xFFFFFFFEL;
			if (obj11 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF658]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF668]");
				object obj13 = 0;
				object obj14 = obj9 + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj15 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+18]");
				bool flag = (nint)0 < (nint)2;
				object obj16 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+18]");
				object obj17 = -2;
				bool flag2 = obj17 == null;
				object obj18 = ~obj16;
				object obj19 = obj18 | flag2;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF660]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF650]");
					object obj21 = 0;
					object obj22 = obj9 + 80;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj23 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 16));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+18]");
					object obj24 = 0 & 0xFFFFFFFCL;
					if (obj24 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF568]");
						object obj25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
						object obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
						object obj27 = 0;
						object obj28 = obj9 + 104;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj29 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v17+A0]");
						object obj30 = 0;
						obj30 = obj9;
						object obj31 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						int num = Shader.PropertyToID((string)obj26);
						object obj32 = obj25;
						object obj33 = obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X9_v2+A0]");
						object obj34 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v21+E4]");
						bool flag3 = (nint)0 == 0;
						object obj35 = !flag3;
						if (obj35 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj32 = obj25;
							obj33 = obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X9_v2+A0]");
							obj34 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v21+A0]");
						object obj36 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v22+2C]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X9_v2+A0]");
						object obj37 = 0;
						_ = 4293454056L;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X9_v2+A0]");
						object obj38 = 0;
						_ = 4278584838L;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X9_v2+A0]");
						object obj39 = 0;
						_ = 4294967295L;
						return;
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
