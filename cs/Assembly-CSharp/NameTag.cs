using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class NameTag : MonoBehaviour
{
	private const int W = default(int);

	private const int H = default(int);

	private const int Line = default(int);

	private const float TitleEvery = default(float);

	private static readonly int BaseMap;

	private static readonly int TagColour;

	private static readonly int TagLight;

	private static readonly List<NameTag> live;

	public Transform head;

	public float above;

	public float width;

	public CosmeticWearer wearer;

	private const float OverWorn = default(float);

	private Texture2D tex;

	private Color32[] px;

	private Renderer quad;

	private MaterialPropertyBlock block;

	private string shown;

	private int title;

	private bool visible = true;

	private bool backwards;

	private bool mine;

	private GameObject body;

	private Dismemberment parts;

	private string nameFor;

	private float titleAt;

	private static bool nameChanged;

	private static NameTag Yours__BackingField;

	private static NetworkBootstrap yoursFor;

	public Color32[] Pixels => px;

	public string Text => shown;

	public int TitleId => title;

	public bool Showing
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00c2: Expected Obj, but got I4
			//IL_0098: Expected I4, but got Obj
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
			if (quad != null)
			{
				if ((object)quad != null)
				{
					return quad.enabled;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	public static NameTag Yours
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+20]");
			return (NameTag)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
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
			object obj4 = (nint)0 + (nint)32;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static NameTag Create(Transform parent, Transform head, Material material, int layer = default(int))
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_0247: Expected VT, but got I4
		GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)5);
		if ((object)gameObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDDF0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7560]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			gameObject.name = (string)obj;
			gameObject.layer = layer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj6 = default;
			UnityEngine.Object.Destroy(obj6);
			Transform transform = gameObject.transform;
			if ((object)transform != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDDE8]");
				object obj7 = 0;
				transform.SetParent(parent, worldPositionStays: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				NameTag nameTag = default;
				if ((object)nameTag != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B18]");
					object obj8 = 0;
					object obj9 = nameTag + 32;
					obj9 = head;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
					object obj10 = nameTag + 72;
					object obj11 = default;
					obj10 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					if (obj10 != null)
					{
						((Renderer)obj10).sharedMaterial = material;
						if (obj10 != null)
						{
							((Renderer)obj10).shadowCastingMode = (ShadowCastingMode)0;
							if (obj10 != null)
							{
								((Renderer)obj10).receiveShadows = false;
								Transform transform2 = gameObject.transform;
								if ((object)transform2 != null)
								{
									transform2.localScale = (Vector3)0;
									if ((object)nameTag.quad != null)
									{
										nameTag.quad.enabled = false;
										return nameTag;
									}
								}
							}
						}
					}
				}
			}
		}
		return (NameTag)(object)new NullReferenceException();
	}

	public void SetName(string name)
	{
		if (name != shown)
		{
			Draw(name, title);
		}
		SetVisible(visible);
	}

	public void SetTitle(int id)
	{
		if (title != id)
		{
			Draw(shown, id);
		}
	}

	public void SetVisible(bool show)
	{
		//IL_00d9: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		bool flag = default;
		visible = flag;
		object obj2;
		if (flag)
		{
			bool flag2 = string.IsNullOrEmpty(shown);
			obj2 = (flag2 ? 1 : 0) ^ 1;
		}
		else
		{
			obj2 = 0;
		}
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (quad != null)
		{
			bool flag4 = quad.enabled;
			object obj5 = obj2 & 1;
			if ((nint)obj5 != (flag4 ? 1 : 0))
			{
				bool flag5 = (byte)(obj2 & 1) != 0;
				quad.enabled = flag5;
			}
		}
	}

	private void Draw(string name, int titleId)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a43: Expected Obj, but got Unknown
		//IL_0a63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a68: Expected Obj, but got Unknown
		//IL_0a97: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I
		//IL_01ed: Expected Obj, but got I
		//IL_01fd: Expected Obj, but got I
		//IL_02db: Expected Obj, but got I4
		//IL_02e3: Expected VT, but got I4
		//IL_0349: Expected Obj, but got I4
		//IL_0362: Expected I4, but got VT
		//IL_022c: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I
		//IL_0313: Expected VT, but got I8
		//IL_0329: Expected VT, but got I8
		//IL_0158: Expected Obj, but got I
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_039a: Expected Obj, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_0281: Expected Obj, but got I4
		//IL_03c0: Expected I4, but got Obj
		//IL_03cc: Expected I, but got Obj
		//IL_03f8: Expected Obj, but got I4
		//IL_0569: Expected Obj, but got I4
		//IL_0458: Expected Obj, but got I4
		//IL_0466: Expected Obj, but got I4
		//IL_04b7: Expected Obj, but got I4
		//IL_0aec: Expected I4, but got Obj
		//IL_0b47: Expected Obj, but got I4
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected Obj, but got Unknown
		//IL_05e1: Expected Obj, but got I4
		//IL_05ff: Expected Obj, but got I
		//IL_067d: Expected VT, but got I
		//IL_06a2: Expected Obj, but got I
		//IL_06c4: Expected Obj, but got I4
		//IL_0724: Expected Obj, but got I
		//IL_0737: Expected I4, but got Obj
		//IL_0760: Expected Obj, but got I4
		//IL_0770: Expected Obj, but got I
		//IL_0780: Expected Obj, but got I
		//IL_0790: Expected Obj, but got I
		//IL_07b2: Expected Obj, but got I4
		//IL_07d8: Expected I4, but got Obj
		//IL_07fe: Expected I4, but got Obj
		//IL_081a: Expected Obj, but got VT
		//IL_0828: Expected Obj, but got VT
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0836: Expected Obj, but got Unknown
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0844: Expected Obj, but got Unknown
		//IL_0852: Expected Obj, but got VT
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Expected Obj, but got Unknown
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Expected Obj, but got Unknown
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Expected Obj, but got Unknown
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Expected Obj, but got Unknown
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Expected Obj, but got Unknown
		//IL_08aa: Expected VT, but got I4
		//IL_08aa: Expected I4, but got Obj
		//IL_08d1: Expected Obj, but got I
		//IL_08ff: Expected Obj, but got I4
		//IL_0921: Expected Obj, but got I
		//IL_093d: Expected Obj, but got VT
		//IL_094b: Expected Obj, but got VT
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Expected Obj, but got Unknown
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected Obj, but got Unknown
		//IL_0975: Expected Obj, but got VT
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Expected Obj, but got Unknown
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0991: Expected Obj, but got Unknown
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Expected Obj, but got Unknown
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Expected Obj, but got Unknown
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Expected Obj, but got Unknown
		//IL_09d7: Expected VT, but got I4
		//IL_09f1: Expected Obj, but got I4
		//IL_0a13: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = this + 88;
		obj2 = name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = obj;
		object obj4 = this + 56;
		UnityEngine.Object obj5 = (UnityEngine.Object)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = obj5 == null;
		bool flag3 = !flag2;
		IntPtr intPtr = default;
		TextureFormat textureFormat = (TextureFormat)(nint)intPtr;
		int num = 0;
		Texture2D texture2D = (Texture2D)titleId;
		string text2;
		Color32[] array;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
			array = (Color32[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Texture2D texture2D2 = default;
			texture2D2._002Ector(128, 24, (TextureFormat)4, mipChain: false);
			bool flag4 = (object)texture2D2 == null;
			string text = null;
			bool flag5 = false;
			textureFormat = (TextureFormat)4;
			num = 24;
			text2 = name;
			texture2D = texture2D2;
			if (flag4)
			{
				goto IL_02a9;
			}
			texture2D2.filterMode = (FilterMode)0;
			texture2D2.wrapMode = (TextureWrapMode)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDDF0]");
			object obj7 = 0;
			texture2D2.name = (string)obj7;
			tex = texture2D2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj9 = this + 64;
			object obj10 = default;
			obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			text = null;
			flag5 = false;
			textureFormat = (TextureFormat)4;
			num = 0;
			texture2D = texture2D2;
		}
		array = px;
		bool flag6 = px == null;
		text2 = name;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
			texture2D = (Texture2D)0;
			Color32[] array2 = null;
			Color32[] array3 = px;
			object obj14;
			MaterialPropertyBlock materialPropertyBlock = default;
			do
			{
				bool flag7 = (nint)array2 >= array3.Length;
				Color32[] array4 = array2;
				text2 = name;
				array = array3;
				if (!flag7)
				{
					bool flag8 = (nint)array2 < array3.Length;
					object obj12 = !flag8;
					if (obj12 == null)
					{
						object obj13 = (object)array3 + (object)array2;
						array4 = (Color32[])(array2 + 1);
						_ = 0;
						array = px;
						bool flag9 = px == null;
						obj14 = !flag9;
						text2 = name;
						array2 = array4;
						array3 = px;
						continue;
					}
					throw new IndexOutOfRangeException();
				}
				bool flag10 = string.IsNullOrEmpty(text2);
				bool flag11 = !flag10;
				object obj15 = !flag11;
				Color32 color = (Color32)textureFormat;
				string text3 = null;
				if (obj15 == null)
				{
					Edged(text2, 14, (Color32)4294967295L, edged: false);
					bool flag5 = false;
					color = (Color32)4294967295L;
					num = 14;
					text3 = text2;
				}
				text2 = (string)title;
				bool flag12 = title < 1;
				textureFormat = (TextureFormat)color;
				if (!flag12)
				{
					object obj16 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v41+E4]");
					bool flag13 = (nint)0 == 0;
					object obj17 = !flag13;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text4 = NameTitles.Label((int)text2);
					nint num2 = (nint)texture2D;
					texture2D = (Texture2D)(object)px;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v33 (Il2CppClass<UnityEngine.Texture2D>)+E4]");
					bool flag14 = (nint)0 == 0;
					object obj18 = !flag14;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int num3 = PixelFont.Measure(text4, 1);
					Color32 color2 = NameTitles.Light(title);
					Color32 bottom = NameTitles.Colour(title);
					array = (Color32[])(128 - num3);
					array4 = (Color32[])(129 - num3);
					bool flag15 = (nint)array < 0;
					object obj19 = (object)array ^ (object)array;
					object obj20 = (object)array & obj19;
					bool flag16 = (nint)obj20 < 0;
					bool flag17 = flag15 == flag16;
					object obj21 = !flag17;
					object obj22 = ~obj21;
					if (obj22 == null)
					{
						array = array4;
					}
					int num4 = (object)array >> 1;
					PixelFont.Draw((Color32[])(object)texture2D, 128, 24, num4, 2, text4, color2, bottom);
					Color32 color3 = color2;
					string text = text4;
					bool flag5 = true;
					textureFormat = (TextureFormat)num4;
					num = 24;
					obj5 = (UnityEngine.Object)num3;
					text2 = text4;
				}
				if (obj4 == null)
				{
					break;
				}
				((Texture2D)obj4).SetPixels32(px);
				bool flag18 = (object)tex == null;
				num = 0;
				if (flag18)
				{
					break;
				}
				tex.Apply(updateMipmaps: false);
				object obj23 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X0_v16+E4]");
				bool flag19 = (nint)0 == 0;
				object obj24 = !flag19;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(quad == null))
				{
					obj4 = this + 80;
					array = (Color32[])obj4;
					bool flag20 = obj4 == null;
					object obj25 = !flag20;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
						array = (Color32[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						materialPropertyBlock._002Ector();
						obj4 = materialPropertyBlock;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						text2 = (string)(object)materialPropertyBlock;
					}
					bool flag21 = (object)quad == null;
					num = 0;
					if (flag21)
					{
						break;
					}
					quad.GetPropertyBlock((MaterialPropertyBlock)obj4);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
					Color32 color3 = (Color32)0;
					text2 = (string)obj4;
					int rgba = color3.rgba;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X0_v22 (System.Int32)+E4]");
					array = (Color32[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X0_v22 (System.Int32)+E4]");
					bool flag22 = (nint)0 == 0;
					object obj26 = !flag22;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag23 = text2 == null;
					num = 0;
					if (flag23)
					{
						break;
					}
					int rgba2 = color3.rgba;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v10 (System.Int32)+A0]");
					object obj27 = 0;
					((MaterialPropertyBlock)(object)text2).SetTexture((int)obj27, (Texture)tex);
					int rgba3 = color3.rgba;
					object obj28 = obj11;
					text2 = (string)(object)block;
					obj5 = (UnityEngine.Object)title;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v12 (System.Int32)+A0]");
					array = (Color32[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v25+E4]");
					array4 = (Color32[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v5 (UnityEngine.Color32[])+4]");
					texture2D = (Texture2D)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v25+E4]");
					bool flag24 = (nint)0 == 0;
					object obj29 = !flag24;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Color32 color4 = NameTitles.Colour((int)obj5);
					bool flag25 = text2 == null;
					textureFormat = (TextureFormat)0;
					num = (int)tex;
					if (flag25)
					{
						break;
					}
					object obj30 = color4 >> 24;
					object obj31 = color4 >> 16;
					object obj32 = obj31 & 0xFF;
					object obj33 = obj30 / 1132396544;
					object obj34 = color4 >> 8;
					object obj35 = obj34 & 0xFF;
					object obj36 = obj32 / 1132396544;
					object obj37 = color4 & 0xFF;
					object obj38 = obj35 / 1132396544;
					object obj39 = obj37 / 1132396544;
					((MaterialPropertyBlock)(object)text2).SetColor((int)texture2D, (Color)0);
					int rgba4 = color3.rgba;
					text2 = (string)(object)block;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v21 (System.Int32)+A0]");
					array = (Color32[])0;
					Color32 color5 = NameTitles.Light(title);
					bool flag26 = block == null;
					object obj40 = 1132396544;
					textureFormat = (TextureFormat)0;
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v5 (UnityEngine.Color32[])+8]");
					texture2D = (Texture2D)0;
					if (flag26)
					{
						break;
					}
					object obj41 = color5 >> 24;
					object obj42 = color5 >> 16;
					object obj43 = obj42 & 0xFF;
					obj33 = obj41 / 1132396544;
					object obj44 = color5 >> 8;
					object obj45 = obj44 & 0xFF;
					obj36 = obj43 / 1132396544;
					array = (Color32[])(color5 & 0xFF);
					obj38 = obj45 / 1132396544;
					obj39 = array / 1132396544;
					MaterialPropertyBlock materialPropertyBlock2 = block;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v5 (UnityEngine.Color32[])+8]");
					materialPropertyBlock2.SetColor(0, (Color)0);
					bool flag27 = (object)quad == null;
					obj40 = 1132396544;
					textureFormat = (TextureFormat)0;
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v5 (UnityEngine.Color32[])+8]");
					texture2D = (Texture2D)0;
					if (flag27)
					{
						break;
					}
					quad.SetPropertyBlock((MaterialPropertyBlock)obj4);
				}
				return;
			}
			while (obj14 != null);
		}
		goto IL_02a9;
		IL_02a9:
		throw new NullReferenceException();
	}

	private void Edged(string s, int y, Color32 colour, bool edged = default(bool))
	{
		//IL_0010: Expected Obj, but got I
		//IL_031b: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		//IL_0337: Expected I4, but got Obj
		//IL_0297: Expected Obj, but got I4
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected VT, but got Unknown
		//IL_00fc: Expected Obj, but got I8
		//IL_03a5: Expected Obj, but got I8
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_012d: Expected I4, but got Obj
		//IL_014f: Expected Obj, but got I4
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected I4, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected I4, but got Unknown
		//IL_01b3: Expected VT, but got I8
		//IL_01b3: Expected Obj, but got I4
		//IL_01c5: Expected I, but got Obj
		//IL_01d5: Expected VT, but got I4
		//IL_01e2: Expected VT, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = PixelFont.Measure(s, 1);
		object obj4 = 128 - num;
		object obj5 = 129 - num;
		bool flag2 = (nint)obj4 < 0;
		object obj6 = obj4 ^ obj4;
		object obj7 = obj4 & obj6;
		bool flag3 = (nint)obj7 < 0;
		bool flag4 = flag2 == flag3;
		object obj8 = !flag4;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
			obj4 = obj5;
		}
		int num2 = obj4 >> 1;
		bool flag6 = default;
		bool flag5 = !flag6;
		Color32 color = colour;
		int num3 = 0;
		int num4 = 1;
		if (!flag5)
		{
			int num6 = default;
			int num5 = num6;
			IntPtr intPtr = default;
			nint num7 = intPtr;
			bool flag7 = flag6;
			Color32 color2 = colour;
			Color32 color4 = default;
			Color32 color3 = color4;
			object obj10 = 4294967295L;
			int num8 = 0;
			int num9 = 1;
			bool flag8 = flag6;
			bool flag10;
			do
			{
				object obj11 = 4294967295L;
				do
				{
					object obj12 = obj11 | obj10;
					if (obj12 != null)
					{
						object obj13 = obj;
						flag8 = (byte)(int)px != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v14+E4]");
						bool flag9 = (nint)0 == 0;
						object obj14 = !flag9;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int num10 = obj10 + num2;
						int num11 = y + obj11;
						PixelFont.Draw((Color32[])flag8, 128, 24, num10, num11, s, (Color32)4279110154L, 1);
						num5 = 1;
						num7 = (nint)s;
						flag7 = (byte)num11 != 0;
						color2 = (Color32)num10;
						color3 = (Color32)4279110154L;
						num8 = 24;
						num9 = 128;
					}
					obj11++;
				}
				while ((nint)obj11 != 2);
				obj10++;
				flag10 = (nint)obj10 != 2;
				color = color2;
				num3 = num8;
				num4 = num9;
			}
			while (flag10);
		}
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v7+E4]");
		bool flag11 = (nint)0 == 0;
		object obj16 = !flag11;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Color32 colour2 = (Color32)(colour & 0xFFFFFFFFL);
		PixelFont.Draw(px, 128, 24, num2, y, s, colour2, 1);
	}

	public static void FaceMirror(Vector3 reflectedEye)
	{
		//IL_0209: Expected Obj, but got I
		//IL_0219: Expected Obj, but got I
		//IL_0229: Expected Obj, but got I
		//IL_028e: Expected Obj, but got I4
		//IL_02ac: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I4
		//IL_0121: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I4
		//IL_025f: Expected Obj, but got I
		//IL_018f: Expected I4, but got Obj
		//IL_01a4: Expected Obj, but got I
		//IL_01bf: Expected I4, but got Obj
		//IL_01bf: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE00]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		object obj5 = default;
		object obj4 = obj5;
		object obj7 = default;
		object obj6 = obj7;
		object obj9 = default;
		object obj8 = obj9;
		int num = 0;
		while (true)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj11 = !flag;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v4+A0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v5+10]");
			List<System.__Canon> list = (List<System.__Canon>)0;
			if (num >= list._size)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj13 = !flag2;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v13+A0]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v14+10]");
				list = (List<System.__Canon>)0;
			}
			System.__Canon _Canon = list.get_Item(num);
			object obj16 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = (UnityEngine.Object)(object)_Canon != null;
			bool flag5 = !flag4;
			nint num2 = unchecked((nint)null);
			bool flag6 = false;
			if (!flag5)
			{
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v15+E4]");
				bool flag7 = (nint)0 == 0;
				object obj19 = !flag7;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj18 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v15+A0]");
				object obj20 = 0;
				flag6 = (byte)(int)obj2 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v12+10]");
				System.__Canon _Canon2 = ((List<System.__Canon>)0).get_Item(num);
				((NameTag)(object)_Canon2).Face((Vector3)1, (byte)(int)obj2 != 0);
				obj4 = obj5;
				obj6 = obj7;
				obj8 = obj9;
				num2 = 1;
			}
			num++;
		}
	}

	public static void FaceViewer(Vector3 eye)
	{
		//IL_0205: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I
		//IL_0225: Expected Obj, but got I
		//IL_028a: Expected Obj, but got I4
		//IL_02a8: Expected Obj, but got I
		//IL_02b8: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I4
		//IL_0121: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I4
		//IL_025b: Expected Obj, but got I
		//IL_018f: Expected I4, but got Obj
		//IL_01a4: Expected Obj, but got I
		//IL_01bf: Expected I4, but got Obj
		//IL_01bf: Expected VT, but got I4
		//IL_01dc: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE00]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		object obj5 = default;
		object obj4 = obj5;
		object obj7 = default;
		object obj6 = obj7;
		object obj9 = default;
		object obj8 = obj9;
		int num = 0;
		while (true)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj11 = !flag;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v4+A0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v5+10]");
			List<System.__Canon> list = (List<System.__Canon>)0;
			if (num >= list._size)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj13 = !flag2;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v13+A0]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v14+10]");
				list = (List<System.__Canon>)0;
			}
			System.__Canon _Canon = list.get_Item(num);
			object obj16 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = (UnityEngine.Object)(object)_Canon != null;
			bool flag5 = !flag4;
			nint num2 = unchecked((nint)null);
			bool flag6 = false;
			if (!flag5)
			{
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v15+E4]");
				bool flag7 = (nint)0 == 0;
				object obj19 = !flag7;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj18 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v15+A0]");
				object obj20 = 0;
				flag6 = (byte)(int)obj2 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v12+10]");
				System.__Canon _Canon2 = ((List<System.__Canon>)0).get_Item(num);
				((NameTag)(object)_Canon2).Face((Vector3)0, (byte)(int)obj2 != 0);
				obj4 = obj5;
				obj6 = obj7;
				obj8 = obj9;
				num2 = unchecked((nint)null);
			}
			num++;
		}
	}

	private void Face(Vector3 eye, bool mirror)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0294: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_0125: Expected Obj, but got I4
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_0228: Expected VT, but got I4
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
		bool flag2 = head == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = eye & 1;
		bool flag4 = obj5 == null;
		object obj6 = !flag4;
		bool flag5 = false;
		if (obj6 == null)
		{
			Flip(reversed: false);
			flag5 = false;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v8+E4]");
		bool flag6 = (nint)0 == 0;
		object obj8 = !flag6;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = quad == null;
		bool flag8 = !flag7;
		object obj9 = !flag8;
		if (obj9 == null && quad.enabled)
		{
			Transform transform = base.transform;
			Vector3 position = transform.position;
			object obj11 = default;
			object obj10 = obj11 - obj11;
			object obj13 = default;
			object obj12 = obj13 - obj13;
			object obj15 = default;
			object obj14 = obj15 - obj15;
			object obj16 = obj10 * obj10;
			object obj17 = obj12 * obj12;
			object obj18 = obj16 + obj17;
			object obj19 = obj14 * obj14;
			object obj20 = obj19 + obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			if ((nint)obj20 > 0)
			{
				Transform transform2 = base.transform;
				Vector3 forward = default;
				Vector3 upwards = default;
				Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
				transform2.rotation = (Quaternion)0;
			}
			object obj21 = eye & 1;
			if (obj21 != null)
			{
				Flip(reversed: true);
			}
		}
	}

	private void Flip(bool reversed)
	{
		//IL_0065: Expected VT, but got I4
		if (backwards != reversed)
		{
			backwards = reversed;
			Transform transform = base.transform;
			Vector3 localScale = transform.localScale;
			Transform transform2 = base.transform;
			transform2.localScale = (Vector3)0;
		}
	}

	public static void MakeYours()
	{
		//IL_0010: Expected Obj, but got I
		//IL_08f6: Expected Obj, but got I4
		//IL_091c: Expected Obj, but got I
		//IL_093e: Expected Obj, but got I4
		//IL_0aff: Expected Obj, but got I
		//IL_0b0f: Expected Obj, but got I
		//IL_0b31: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I4
		//IL_0964: Expected Obj, but got I
		//IL_0986: Expected Obj, but got I4
		//IL_0b57: Expected Obj, but got I
		//IL_0b79: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_018e: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I4
		//IL_01e4: Expected Obj, but got I4
		//IL_09ac: Expected Obj, but got I
		//IL_09ce: Expected Obj, but got I4
		//IL_0235: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I
		//IL_0253: Expected Obj, but got I4
		//IL_028b: Expected Obj, but got I4
		//IL_09f2: Expected Obj, but got I
		//IL_0a02: Expected Obj, but got I
		//IL_02da: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I
		//IL_0a5b: Expected Obj, but got I4
		//IL_03bf: Expected Obj, but got I4
		//IL_0369: Expected Obj, but got I
		//IL_0414: Expected Obj, but got I4
		//IL_0443: Expected Obj, but got I
		//IL_0461: Expected Obj, but got I4
		//IL_0499: Expected Obj, but got I4
		//IL_04c8: Expected Obj, but got I
		//IL_04e6: Expected Obj, but got I4
		//IL_051e: Expected Obj, but got I4
		//IL_054d: Expected Obj, but got I
		//IL_0580: Expected Obj, but got I
		//IL_05ba: Expected Obj, but got I
		//IL_0612: Expected Obj, but got I4
		//IL_0654: Expected Obj, but got I
		//IL_0654: Expected Obj, but got I
		//IL_0685: Expected Obj, but got I
		//IL_06d6: Expected Obj, but got I
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected Obj, but got Unknown
		//IL_0729: Expected Obj, but got I4
		//IL_0758: Expected Obj, but got I
		//IL_0774: Expected Obj, but got I4
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Expected Obj, but got Unknown
		//IL_0a99: Expected Obj, but got I
		//IL_0ab3: Expected Obj, but got I
		//IL_0ac1: Expected I, but got Obj
		//IL_0792: Expected Obj, but got I
		//IL_085a: Expected I, but got Obj
		//IL_0892: Expected Obj, but got I4
		//IL_07c7: Expected Obj, but got I
		//IL_0ad6: Expected Obj, but got I
		//IL_082f: Expected Obj, but got I4
		//IL_0821: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X9_v1+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Application.isPlaying)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v15+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj11;
		}
		object obj17 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v15+A0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X9_v3+20]");
		bool flag7 = (UnityEngine.Object)0 != null;
		bool flag8 = !flag7;
		object obj20 = !flag8;
		if (obj20 != null)
		{
			return;
		}
		object obj21 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v19+E4]");
		bool flag9 = (nint)0 == 0;
		object obj22 = !flag9;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X9_v1+8]");
		bool flag10 = (UnityEngine.Object)0 == null;
		bool flag11 = !flag10;
		object obj23 = !flag11;
		if (obj23 != null)
		{
			return;
		}
		object obj24 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v24+E4]");
		bool flag12 = (nint)0 == 0;
		object obj25 = !flag12;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj24 = obj11;
		}
		object obj26 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v24+A0]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v16+E4]");
		bool flag13 = (nint)0 == 0;
		object obj28 = !flag13;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X9_v1+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X9_v4+28]");
		bool flag14 = (UnityEngine.Object)num == (UnityEngine.Object)0;
		bool flag15 = !flag14;
		object obj29 = !flag15;
		if (obj29 != null)
		{
			return;
		}
		object obj30 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v29+E4]");
		bool flag16 = (nint)0 == 0;
		object obj31 = !flag16;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v29+A0]");
		object obj32 = (nint)0 + (nint)40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X9_v1+8]");
		obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X9_v1+8]");
		NameTag nameTag;
		object obj56;
		if ((nint)0 != 0)
		{
			object obj33 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v37+E4]");
			bool flag17 = (nint)0 == 0;
			object obj34 = !flag17;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X19_v3 (UnityEngine.Object)+20]");
			bool flag18 = (UnityEngine.Object)0 != null;
			bool flag19 = !flag18;
			UnityEngine.Object obj35 = null;
			UnityEngine.Object obj36 = null;
			if (!flag19)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X19_v3 (UnityEngine.Object)+20]");
				if ((nint)0 == 0)
				{
					goto IL_08b7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA460]");
				object obj37 = 0;
				obj35 = (UnityEngine.Object)obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
				UnityEngine.Object obj38 = default;
				obj36 = obj38;
			}
			object obj39 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v42+E4]");
			bool flag20 = (nint)0 == 0;
			object obj40 = !flag20;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag21 = obj36 == null;
			bool flag22 = !flag21;
			object obj41 = !flag22;
			if (obj41 != null)
			{
				return;
			}
			if ((object)obj36 != null)
			{
				object obj42 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v46+E4]");
				bool flag23 = (nint)0 == 0;
				object obj43 = !flag23;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X20_v14 (UnityEngine.Object)+B0]");
				bool flag24 = (UnityEngine.Object)0 == null;
				bool flag25 = !flag24;
				object obj44 = !flag25;
				if (obj44 != null)
				{
					return;
				}
				object obj45 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v50+E4]");
				bool flag26 = (nint)0 == 0;
				object obj46 = !flag26;
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X19_v3 (UnityEngine.Object)+30]");
				bool flag27 = (UnityEngine.Object)0 == null;
				bool flag28 = !flag27;
				object obj47 = !flag28;
				if (obj47 != null)
				{
					return;
				}
				object obj48 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v54+E4]");
				bool flag29 = (nint)0 == 0;
				object obj49 = !flag29;
				if (obj49 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X19_v3 (UnityEngine.Object)+48]");
				if ((UnityEngine.Object)0 == null)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X9_v1+8]");
				Transform parent = ((Component)0).transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X19_v3 (UnityEngine.Object)+48]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X19_v3 (UnityEngine.Object)+48]");
					GameObject gameObject = ((Component)0).gameObject;
					if ((object)gameObject != null)
					{
						int layer = gameObject.layer;
						object obj50 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v27+E4]");
						bool flag30 = (nint)0 == 0;
						object obj51 = !flag30;
						if (obj51 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X19_v3 (UnityEngine.Object)+30]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X20_v14 (UnityEngine.Object)+B0]");
						nameTag = Create(parent, (Transform)num2, (Material)0, layer);
						if ((object)nameTag != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE10]");
							object obj52 = 0;
							nameTag.name = (string)obj52;
							nameTag.mine = true;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X19_v3 (UnityEngine.Object)+48]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X19_v3 (UnityEngine.Object)+48]");
								GameObject gameObject2 = ((Component)0).gameObject;
								object obj53 = nameTag + 104;
								obj53 = gameObject2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj54 = obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v71+E4]");
								bool flag31 = (nint)0 == 0;
								object obj55 = !flag31;
								if (obj55 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X19_v3 (UnityEngine.Object)+68]");
								bool flag32 = (UnityEngine.Object)0 != null;
								bool flag33 = !flag32;
								obj56 = 0;
								if (!flag33)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X19_v3 (UnityEngine.Object)+68]");
									object obj57 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X19_v3 (UnityEngine.Object)+68]");
									if ((nint)0 == 0)
									{
										goto IL_08b7;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v35+20]");
									object obj58 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v35+20]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v36+18]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v36+20]");
											obj56 = 0;
											goto IL_0a69;
										}
									}
									obj56 = 0;
								}
								goto IL_0a69;
							}
						}
					}
				}
			}
		}
		goto IL_08b7;
		IL_08b7:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_0a69:
		object obj59 = nameTag + 112;
		obj59 = obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE08]");
		object obj61 = 0;
		Action action = default;
		action._002Ector(null, (IntPtr)obj61);
		GillaName.Changed -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action2 = default;
		action2._002Ector(null, (IntPtr)obj61);
		GillaName.Changed += action2;
		object obj62 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v85+E4]");
		bool flag34 = (nint)0 == 0;
		object obj63 = !flag34;
		if (obj63 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj62 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v85+A0]");
		object obj64 = 0;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F3FF78");
	}

	private static void NameChanged()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
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
		_ = 1;
	}

	private static CosmeticWearer HatsOn(NetworkBootstrap rig)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03b3: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got I4
		//IL_0194: Expected Obj, but got I8
		//IL_01a4: Expected Obj, but got I
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01c0: Expected Obj, but got I4
		//IL_01c9: Expected Obj, but got I4
		//IL_0417: Expected Obj, but got I4
		//IL_01fd: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I
		//IL_03f0: Expected Obj, but got I4
		//IL_0329: Expected Obj, but got I4
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_0350: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = rig == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		CosmeticWearer result = null;
		if (obj4 == null)
		{
			if ((object)rig != null)
			{
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v12+E4]");
				bool flag4 = (nint)0 == 0;
				object obj6 = !flag4;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = rig.tearing == null;
				bool flag6 = !flag5;
				object obj7 = !flag6;
				result = null;
				if (obj7 != null)
				{
					goto IL_03c1;
				}
				DismemberGroup tearing = rig.tearing;
				if ((object)rig.tearing != null)
				{
					Dismemberment[] copies = tearing.copies;
					if (tearing.copies == null || copies.Length < 1)
					{
						goto IL_0363;
					}
					object obj8 = copies.Length & 0xFFFFFFFFL;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8828]");
					object obj9 = 0;
					object obj10 = tearing.copies + 32;
					object obj11 = 0;
					object obj12 = 0;
					UnityEngine.Object obj13 = null;
					UnityEngine.Object obj19 = default;
					while (true)
					{
						bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
						object obj14 = !flag7;
						if (obj14 != null)
						{
							break;
						}
						object obj15 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v18+E4]");
						bool flag8 = (nint)0 == 0;
						object obj16 = !flag8;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X25_v6+v69 @ X23_v7*8]");
						bool flag9 = (UnityEngine.Object)0 != null;
						bool flag10 = !flag9;
						UnityEngine.Object obj17 = null;
						UnityEngine.Object obj18 = null;
						if (!flag10)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X25_v6+v69 @ X23_v7*8]");
							if ((nint)0 == 0)
							{
								goto IL_036d;
							}
							obj17 = (UnityEngine.Object)obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
							obj18 = obj19;
						}
						object obj20 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v23+E4]");
						bool flag11 = (nint)0 == 0;
						object obj21 = !flag11;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (obj18 != null)
						{
							if ((object)obj18 == null)
							{
								goto IL_036d;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X20_v13 (UnityEngine.Object)+21]");
							bool flag12 = (nint)0 == 0;
							result = (CosmeticWearer)obj18;
							if (flag12)
							{
								goto IL_03c1;
							}
						}
						obj8 = copies.Length;
						obj11++;
						bool flag13 = (nint)obj11 < copies.Length;
						obj12 = 0;
						obj13 = null;
						if (flag13)
						{
							continue;
						}
						goto IL_0363;
					}
					goto IL_037b;
				}
			}
			goto IL_036d;
		}
		goto IL_03c1;
		IL_0363:
		result = null;
		goto IL_03c1;
		IL_037b:
		return (CosmeticWearer)(object)new IndexOutOfRangeException();
		IL_036d:
		NullReferenceException ex = new NullReferenceException();
		goto IL_037b;
		IL_03c1:
		return result;
	}

	private void KeepYours()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected Obj, but got Unknown
		//IL_0497: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_013d: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I4
		//IL_04f9: Expected Obj, but got I
		//IL_051b: Expected Obj, but got I4
		//IL_04b5: Expected Obj, but got I
		//IL_04c6: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I4
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got I
		//IL_0332: Expected Obj, but got I4
		//IL_0229: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I4
		//IL_0435: Expected Obj, but got I4
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected I4, but got Unknown
		//IL_03d2: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I4
		//IL_0426: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
		object obj6 = 0;
		bool flag2 = (UnityEngine.Object)obj3 == null;
		bool flag3 = !flag2;
		UnityEngine.Object obj7 = null;
		if (!flag3)
		{
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v54+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v54+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v24+28]");
			CosmeticWearer cosmeticWearer = HatsOn((NetworkBootstrap)0);
			obj3 = cosmeticWearer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj7 = cosmeticWearer;
		}
		object obj11 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string playerId = NetworkBootstrap.PlayerId;
		object obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X9_v4+18]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		string text;
		if (obj16 == null)
		{
			bool flag8 = (object)playerId == nameFor;
			text = (string)(object)obj7;
			if (flag8)
			{
				goto IL_01df;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7+E4]");
		bool flag9 = (nint)0 == 0;
		object obj17 = !flag9;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v21+A0]");
			obj15 = 0;
		}
		_ = 0;
		object obj19 = this + 120;
		obj19 = playerId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		string current = GillaName.Current;
		SetName(current);
		text = current;
		goto IL_01df;
		IL_01df:
		float unscaledTime = Time.unscaledTime;
		double num = titleAt;
		bool flag10 = unscaledTime < titleAt;
		int num2 = 0;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5828]");
			object obj20 = 0;
			float unscaledTime2 = Time.unscaledTime;
			object obj21 = obj20;
			unscaledTime = unscaledTime2 + 0.5f;
			titleAt = unscaledTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v37+E4]");
			bool flag11 = (nint)0 == 0;
			object obj22 = !flag11;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num3 = NameTitles.Shown;
			bool flag12 = title == num3;
			num = 0.5;
			num2 = 0;
			if (!flag12)
			{
				text = shown;
				Draw(shown, num3);
				num = 0.5;
				num2 = num3;
			}
		}
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v15+E4]");
		bool flag13 = (nint)0 == 0;
		object obj24 = !flag13;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj27;
		if (body != null && body.activeInHierarchy)
		{
			object obj25 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v26+E4]");
			bool flag14 = (nint)0 == 0;
			object obj26 = !flag14;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (parts == null)
			{
				obj27 = 1;
			}
			else
			{
				bool flag15 = parts.IsTorn((ApePart)0);
				obj27 = (flag15 ? 1 : 0) ^ 1;
			}
		}
		else
		{
			obj27 = 0;
		}
		bool flag16 = (byte)(obj27 & 1) != 0;
		SetVisible(flag16);
	}

	private void LateUpdate()
	{
		//IL_0516: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I4
		//IL_0143: Expected Obj, but got I4
		//IL_014c: Expected VT, but got I4
		//IL_03b1: Expected Obj, but got I4
		//IL_03f6: Expected Obj, but got I4
		//IL_053f: Expected Obj, but got I
		//IL_0575: Expected Obj, but got I
		//IL_05e3: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I4
		//IL_0379: Expected VT, but got I4
		//IL_0382: Expected VT, but got I4
		//IL_01ed: Expected Obj, but got I4
		//IL_04cc: Invalid comparison between F8 and I
		//IL_0273: Invalid comparison between F8 and I4
		//IL_0282: Invalid comparison between F8 and I4
		//IL_0295: Expected Obj, but got F8
		//IL_02a2: Expected Obj, but got F8
		//IL_02d7: Expected Obj, but got I4
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_031a: Expected Obj, but got I4
		//IL_0304: Expected Obj, but got I4
		//IL_0500: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		if (~(mine ? 1u : 0u) == 0)
		{
			KeepYours();
		}
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = quad == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null || !quad.enabled)
		{
			return;
		}
		Flip(reversed: false);
		Camera main = Camera.main;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = head != null;
		bool flag6 = !flag5;
		object obj7 = 0;
		Vector3 vector = (Vector3)0;
		double num6 = default;
		double num17 = default;
		double num18 = default;
		if (!flag6)
		{
			Vector3 position = head.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj8 = 0;
			object obj9 = obj;
			double num = (double)width * 12.0;
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v22+A0]");
			object obj11 = 0;
			double num2 = num * 60.0;
			double num3 = num2 * 0.5;
			double num4 = (double)above + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v23+1C]");
			double num5 = 0.0 * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v42+E4]");
			bool flag7 = (nint)0 == 0;
			object obj12 = !flag7;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num7 = default;
			num6 = num7 + num5;
			bool flag8 = wearer != null;
			bool flag9 = !flag8;
			obj7 = 0;
			if (!flag9)
			{
				bool flag10 = wearer.TopOfHead(out var top);
				bool flag11 = !flag10;
				obj7 = 0;
				if (!flag11)
				{
					double num8 = (double)width * 24.0;
					float num9 = top;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
					float num10 = num9 + 0f;
					double num11 = num8 * 60.0;
					double num12 = num11 * 0.5;
					float num13 = num10 + (float)num12;
					double num14 = num6 - (double)num13;
					bool flag12 = num14 < 0.0;
					bool flag13 = num14 == 0.0;
					object obj13 = num6 ^ (double)num13;
					object obj14 = num6 ^ num14;
					object obj15 = obj13 & obj14;
					bool flag14 = (nint)obj15 < 0;
					bool flag15 = flag12 == flag14;
					object obj16 = !flag13;
					object obj17 = flag15 & obj16;
					object obj18 = ~obj17;
					if (obj18 == null)
					{
						obj7 = 0;
					}
					else
					{
						num6 = num13;
						obj7 = 0;
					}
				}
			}
			Transform transform = base.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v23+18]");
			double num15 = 0.0 * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v23+20]");
			double num16 = 0.0 * num4;
			num17 += num15;
			num18 += num16;
			transform.position = (Vector3)0;
			vector = (Vector3)0;
		}
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v19+E4]");
		bool flag16 = (nint)0 == 0;
		object obj20 = !flag16;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17 = main == null;
		bool flag18 = !flag17;
		object obj21 = !flag18;
		if (obj21 == null)
		{
			Transform transform2 = base.transform;
			Vector3 position2 = transform2.position;
			Transform transform3 = main.transform;
			Vector3 position3 = transform3.position;
			double num19 = num17 - num17;
			double num20 = num6 - num6;
			double num21 = num18 - num18;
			double num22 = num19 * num19;
			double num23 = num20 * num20;
			double num24 = num22 + num23;
			double num25 = num21 * num21;
			double num26 = num25 + num24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			if (num26 > 0.0)
			{
				Transform transform4 = base.transform;
				Vector3 forward = default;
				Vector3 upwards = default;
				Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
				transform4.rotation = (Quaternion)0;
			}
		}
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+10]");
		List<System.__Canon> list = (List<System.__Canon>)0;
		System.__Canon[] items = list._items;
		int version = list._version + 1;
		list._version = version;
		bool flag2 = list._size < items.Length;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			object obj6 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj7 = obj6 + 32;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			list.AddWithResize((System.__Canon)(object)this);
		}
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+10]");
		bool flag2 = ((List<System.__Canon>)0).Remove((System.__Canon)(object)this);
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I4
		//IL_022d: Expected Obj, but got I4
		//IL_028b: Expected Obj, but got I
		//IL_02ad: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I
		//IL_0191: Expected Obj, but got I4
		//IL_0265: Expected Obj, but got I4
		//IL_02d1: Expected Obj, but got I
		//IL_02da: Expected Obj, but got I4
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
		object obj4 = 0;
		bool flag2 = tex != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v38+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(tex);
			obj5 = null;
		}
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj11 = !flag6;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj4;
		}
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v11+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X9_v1+20]");
		if ((UnityEngine.Object)0 == this)
		{
			object obj15 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v15+E4]");
			bool flag8 = (nint)0 == 0;
			object obj16 = !flag8;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v19+E4]");
			bool flag9 = (nint)0 == 0;
			object obj18 = !flag9;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v19+A0]");
			object obj19 = (nint)0 + (nint)32;
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I4
		//IL_0191: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
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
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+1C]");
		object obj6 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			Array.Clear((Array)num, 0, 0);
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v8+A0]");
		object obj9 = (nint)0 + (nint)32;
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v9+A0]");
		object obj11 = (nint)0 + (nint)40;
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v10+A0]");
		object obj13 = 0;
		_ = 1;
	}

	public NameTag()
	{
		//IL_001d: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B4D0]");
		above = 0f;
		base._002Ector();
	}

	static NameTag()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I4
		//IL_012c: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE30]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE38]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDE40]");
		object obj5 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+A0]");
		object obj7 = 0;
		obj7 = num;
		int num2 = Shader.PropertyToID((string)obj3);
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v5+A0]");
		object obj9 = 0;
		int num3 = Shader.PropertyToID((string)obj4);
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v9+A0]");
		object obj13 = (nint)0 + (nint)16;
		obj13 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v10+A0]");
		object obj15 = 0;
		_ = 1;
	}
}
