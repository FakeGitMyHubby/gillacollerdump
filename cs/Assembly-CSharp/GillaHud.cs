using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;
using UnityEngine.Rendering;

public class GillaHud : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass45_0
	{
		public List<Vector3> balls;

		public Vector3 at;

		public Quaternion toHand;

		public Vector3 from;

		public List<float> sizes;

		internal void _003CShapeOf_003Eg__Ball_007C0(Vector3 world, float r)
		{
			//IL_0231: Expected VT, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0043: Expected Obj, but got I
			//IL_005e: Expected Obj, but got VT
			//IL_007b: Expected Obj, but got I
			//IL_0098: Expected Obj, but got I
			//IL_00c1: Expected Obj, but got I4
			//IL_0131: Expected Obj, but got I
			//IL_0141: Expected Obj, but got I
			//IL_0156: Expected VT, but got I
			//IL_00e5: Expected Obj, but got I
			//IL_0108: Expected Obj, but got I
			//IL_017b: Expected Obj, but got I
			//IL_0192: Expected Obj, but got I
			//IL_01c5: Expected Obj, but got I4
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected Obj, but got Unknown
			//IL_01fe: Expected Obj, but got I
			List<Vector3> list = balls;
			Vector3 vector = (Quaternion)0 * world;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
			object obj2 = 0;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
			object obj4 = (nint)0 + (nint)1;
			object obj5 = at + toHand;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHud+<>c__DisplayClass45_0)+1C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHud+<>c__DisplayClass45_0)+28]");
			object obj6 = num + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHud+<>c__DisplayClass45_0)+20]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHud+<>c__DisplayClass45_0)+2C]");
			object obj7 = num2 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4+18]");
			bool flag = num3 < 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				object obj9 = (nint)0 * (nint)12;
				object obj10 = obj2 + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X20_v2 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				object obj11 = (nint)0 + (nint)1;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X9_v4+20]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v10+A8]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v11+70]");
				list.AddWithResize((Vector3)0);
			}
			List<float> list2 = sizes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v7 (System.Collections.Generic.List`1<System.Single>)+10]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v7 (System.Collections.Generic.List`1<System.Single>)+1C]");
			object obj15 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v7 (System.Collections.Generic.List`1<System.Single>)+18]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6+18]");
			bool flag2 = num4 < 0;
			object obj16 = !flag2;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v7 (System.Collections.Generic.List`1<System.Single>)+18]");
				object obj17 = obj14 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v7 (System.Collections.Generic.List`1<System.Single>)+18]");
				object obj18 = (nint)0 + (nint)1;
			}
			else
			{
				float item = default;
				list2.AddWithResize(item);
			}
		}
	}

	private class Message
	{
		public string top;

		public string bottom;

		public Color32[] topColours;

		public Color32[] bottomColours;

		public bool hunt;

		public float lasts = 3f;
	}

	private struct Clock
	{
		public int key;

		public int bucket;

		public bool on;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Message, bool> _003C_003E9__70_0;

		public static Func<Message, bool> _003C_003E9__70_1;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1288]");
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

		internal bool _003CLetGoOfHunt_003Eb__70_0(Message m)
		{
			//IL_0035: Expected I4, but got Obj
			if (m != null)
			{
				return m.hunt;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool _003CLetGoOfHunt_003Eb__70_1(Message m)
		{
			//IL_0044: Expected I4, but got Obj
			if (m != null)
			{
				return !m.hunt;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public const int W = default(int);

	public const int H = default(int);

	public const float Ahead = default(float);

	public const float Below = default(float);

	public const float Wide = default(float);

	public const float ShowFor = default(float);

	public const float FadeIn = default(float);

	public const float FadeOut = default(float);

	public const float Every = default(float);

	public Material material;

	public TextAsset titleFont;

	public TextAsset textFont;

	private static GillaHud Instance__BackingField;

	private static readonly Color32[] Gold;

	private static readonly Color32[] Lime;

	private static readonly Color32[] Milk;

	private static readonly Color32[] Red;

	private static readonly Color32[] Blue;

	private static readonly Color32[] Grey;

	private static readonly int BaseMap;

	private static readonly int Alpha;

	private readonly Queue<Message> waiting;

	private Message current;

	private float shownAt;

	private Renderer picture;

	private Texture2D tex;

	private Color32[] px;

	private MaterialPropertyBlock block;

	private ScreenFont title;

	private ScreenFont text;

	private bool[] questDone;

	private float nextQuestLook;

	private Clock hunt;

	private Clock race;

	private bool following;

	private string Last__BackingField;

	private Action<string> m_Said;

	private float Shown__BackingField;

	public static GillaHud Instance
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
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
			return (GillaHud)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
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
			obj4 = value;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public Renderer Picture => picture;

	public string Showing
	{
		get
		{
			//IL_0015: Expected Obj, but got I
			Message message = current;
			if (current != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6128]");
				object obj = 0;
				return message.top + (string)obj + message.bottom;
			}
			return null;
		}
	}

	public string Last
	{
		get
		{
			return Last__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 168;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public float Shown
	{
		get
		{
			return Shown__BackingField;
		}
		private set
		{
			Shown__BackingField = value;
		}
	}

	public event Action<string> Said
	{
		add
		{
			//IL_006a: Expected Obj, but got I
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected Obj, but got Unknown
			//IL_004d: Expected Obj, but got I4
			//IL_0029: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
			object obj = 0;
			object obj2 = this + 176;
			Delegate obj3 = (Delegate)obj2;
			object obj5 = default;
			Delegate obj8 = default;
			while (true)
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag = obj5 == null;
					object obj6 = !flag;
					object obj7 = obj5;
					if (obj6 == null)
					{
						break;
					}
				}
				else
				{
					object obj7 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag2 = (object)obj8 != obj3;
				obj3 = obj8;
				if (!flag2)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_006a: Expected Obj, but got I
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected Obj, but got Unknown
			//IL_004d: Expected Obj, but got I4
			//IL_0029: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
			object obj = 0;
			object obj2 = this + 176;
			Delegate obj3 = (Delegate)obj2;
			object obj5 = default;
			Delegate obj8 = default;
			while (true)
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag = obj5 == null;
					object obj6 = !flag;
					object obj7 = obj5;
					if (obj6 == null)
					{
						break;
					}
				}
				else
				{
					object obj7 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag2 = (object)obj8 != obj3;
				obj3 = obj8;
				if (!flag2)
				{
					return;
				}
			}
			throw new InvalidCastException();
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

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I4
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
			Transform transform = base.transform;
			Transform parent = transform.parent;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (parent != null)
			{
				Transform transform2 = base.transform;
				transform2.SetParent(null, worldPositionStays: true);
			}
		}
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I4
		//IL_00ff: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I4
		//IL_0187: Expected Obj, but got I
		//IL_01b6: Expected I, but got Obj
		//IL_0066: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11C0]");
		object obj5 = 0;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61D0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11C8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v6+A0]");
		object obj11 = 0;
		obj11 = this;
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<int, int> action = default;
		action._002Ector((object)this, (IntPtr)obj5);
		GillaLevel.Gained += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<int, int, int> action2 = default;
		action2._002Ector((object)this, (IntPtr)obj8);
		object obj13 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v14+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaQuests.Claimed += action2;
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_01d3: Expected Obj, but got I
		//IL_01eb: Expected I, but got Obj
		//IL_006d: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I4
		//IL_00ec: Expected Obj, but got I4
		//IL_0211: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got I4
		//IL_026b: Expected Obj, but got I4
		//IL_02d1: Expected Obj, but got I
		//IL_02da: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11C0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61D0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11C8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<int, int> action = default;
		action._002Ector((object)this, (IntPtr)obj2);
		GillaLevel.Gained -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<int, int, int> action2 = default;
		action2._002Ector((object)this, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaQuests.Claimed -= action2;
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v14+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj6;
		}
		object obj14 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v14+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj15 == this)
		{
			object obj17 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			object obj18 = !flag5;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj19 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v22+E4]");
			bool flag6 = (nint)0 == 0;
			object obj20 = !flag6;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj19 = obj6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v22+A0]");
			object obj21 = 0;
			obj21 = 0;
			object obj22 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I4
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
		bool flag2 = picture != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		if (!flag3)
		{
			GameObject obj5 = picture.gameObject;
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(obj5);
			obj4 = null;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (tex != null)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(tex);
		}
	}

	private void OnGained(int amount, int levelsUp)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I
		//IL_01a3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6148]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC620]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
		object obj4 = 0;
		int num = default;
		string text = num.ToString();
		string top = (string)obj + text + (string)obj2;
		int level = GillaLevel.Level;
		int num2 = default;
		string text2 = num2.ToString();
		Color32[] topColours;
		Color32[] bottomColours;
		string bottom;
		if (levelsUp >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11D0]");
			object obj5 = 0;
			string text3 = (string)obj3 + text2 + (string)obj5;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v11+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12+8]");
			topColours = (Color32[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12+10]");
			bottomColours = (Color32[])0;
			bottom = text3;
		}
		else
		{
			string text4 = (string)obj3 + text2;
			object obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v7+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v8+8]");
			topColours = (Color32[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v8+30]");
			bottomColours = (Color32[])0;
			bottom = text4;
		}
		Show(top, bottom, topColours, bottomColours, hunt: false, 3f);
	}

	public void QuestClaimed(int coins, int xp, int levelsUp)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I
		//IL_0312: Expected Obj, but got I
		//IL_0356: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I
		//IL_042c: Expected Obj, but got I
		//IL_043c: Expected Obj, but got I
		//IL_044c: Expected Obj, but got I
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I8
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got I4
		//IL_0124: Expected Obj, but got I
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got I
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I8
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_021b: Expected Obj, but got I4
		//IL_0231: Expected Obj, but got I
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_0274: Expected Obj, but got I
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_02d0: Expected Obj, but got I4
		//IL_03ef: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got I
		//IL_040f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6150]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
		object obj3 = 0;
		int num = default;
		string text = num.ToString();
		string top = (string)obj + text + (string)obj2;
		int num2 = default;
		Color32[] topColours;
		Color32[] bottomColours;
		string bottom;
		if (levelsUp >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			string[] array = default;
			if (array.Length != 0)
			{
				object obj5 = array + 32;
				obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				string text2 = num2.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X22_v8-8]");
				object obj6 = 0 & 0xFFFFFFFEL;
				if (obj6 != null)
				{
					object obj7 = array + 40;
					obj7 = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X22_v10-10]");
					bool flag = (nint)0 < (nint)2;
					object obj8 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X22_v10-10]");
					object obj9 = -2;
					bool flag2 = obj9 == null;
					object obj10 = ~obj8;
					object obj11 = obj10 | flag2;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1200]");
						object obj12 = 0;
						object obj13 = array + 48;
						obj13 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						int level = GillaLevel.Level;
						int num3 = default;
						string text3 = num3.ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X22_v12-18]");
						object obj14 = 0 & 0xFFFFFFFCL;
						if (obj14 != null)
						{
							object obj15 = array + 56;
							obj15 = text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X22_v14-20]");
							bool flag3 = (nint)0 < (nint)4;
							object obj16 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X22_v14-20]");
							object obj17 = -4;
							bool flag4 = obj17 == null;
							object obj18 = ~obj16;
							object obj19 = obj18 | flag4;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11D0]");
								object obj20 = 0;
								object obj21 = array + 64;
								obj21 = obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								string text4 = string.Concat(array);
								object obj22 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v24+E4]");
								bool flag5 = (nint)0 == 0;
								object obj23 = !flag5;
								if (obj23 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj22 = obj3;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v24+A0]");
								object obj24 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v25+8]");
								topColours = (Color32[])0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v25+10]");
								bottomColours = (Color32[])0;
								bottom = text4;
								goto IL_0459;
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			throw new NullReferenceException();
		}
		string text5 = num2.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11F8]");
		object obj25 = 0;
		string text6 = (string)obj + text5 + (string)obj25;
		object obj26 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v7+E4]");
		bool flag6 = (nint)0 == 0;
		object obj27 = !flag6;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj26 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v7+A0]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v8+8]");
		topColours = (Color32[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v8+30]");
		bottomColours = (Color32[])0;
		bottom = text6;
		goto IL_0459;
		IL_0459:
		Show(top, bottom, topColours, bottomColours, hunt: false, 3f);
	}

	public void Show(string top, string bottom)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+30]");
		Show(top, bottom, (Color32[])num, (Color32[])0, hunt: false, 3f);
	}

	public void Alert(string top, string bottom, float lasts = default(float))
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
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
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+18]");
		Show(top, bottom, (Color32[])num, (Color32[])0, hunt: false, lasts);
	}

	private void Show(string top, string bottom, Color32[] topColours, Color32[] bottomColours, bool hunt = default(bool), float lasts = default(float))
	{
		//IL_0015: Expected Obj, but got I
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_004f: Expected Obj, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00ed: Expected F4, but got I
		//IL_00fd: Invalid comparison between F4 and I
		//IL_0137: Expected Obj, but got I
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_018b: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I
		//IL_01d8: Expected Obj, but got I
		//IL_01e8: Expected Obj, but got I
		Queue<System.__Canon> queue = (Queue<System.__Canon>)(object)waiting;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11D8]");
		object obj = 0;
		bool flag = queue._size < 3;
		string text = top;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11E0]");
			object obj2 = 0;
			text = (string)obj2;
			System.__Canon _Canon = queue.Dequeue();
			queue = (Queue<System.__Canon>)(object)waiting;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_ = 1077936128;
		object obj3 = default;
		obj3._002Ector();
		object obj4 = obj3 + 16;
		obj4 = top;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj3 + 24;
		obj5 = bottom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj3 + 32;
		obj6 = topColours;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj3 + 40;
		obj7 = bottomColours;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		if (!(lasts < 0f))
		{
			num = lasts;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6128]");
		object obj8 = 0;
		queue.Enqueue((System.__Canon)obj3);
		string text2 = top + (string)obj8 + bottom;
		object obj9 = this + 168;
		obj9 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X19_v2+8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X19_v2+8]");
		if ((nint)0 != 0)
		{
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v10+40]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v10+28]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v10+18]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v146 @ X3_v2 (should have been resolved before IL gen)");
		}
	}

	public void Clear()
	{
		//IL_0016: Expected Obj, but got I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0035: Expected Obj, but got I4
		//IL_0092: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		((Queue<System.__Canon>)(object)waiting).Clear();
		object obj2 = this + 64;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = obj;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X21_v3+10]");
		if ((UnityEngine.Object)0 != null)
		{
			picture.enabled = false;
		}
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0482: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_03f9: Expected Obj, but got I4
		//IL_049a: Invalid comparison between F4 and I4
		//IL_04a9: Expected F8, but got I4
		//IL_0262: Expected Obj, but got I
		//IL_028c: Expected Obj, but got I4
		//IL_02c1: Expected Obj, but got I
		//IL_02fb: Expected Obj, but got I
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
		if (!Application.isPlaying)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (picture == null && !Attach())
		{
			return;
		}
		LookAtQuests();
		LookAtClocks();
		object obj7 = this + 64;
		if (obj7 != null)
		{
			goto IL_012e;
		}
		Queue<System.__Canon> queue = (Queue<System.__Canon>)(object)waiting;
		if (queue._size >= 1)
		{
			System.__Canon _Canon = queue.Dequeue();
			current = (Message)(object)_Canon;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			float unscaledTime = Time.unscaledTime;
			shownAt = unscaledTime;
			Draw(current);
			bool flag3 = current == null;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_012e;
			}
		}
		if (picture.enabled)
		{
			picture.enabled = false;
		}
		Shown__BackingField = 0f;
		return;
		IL_012e:
		float unscaledTime2 = Time.unscaledTime;
		Message message = current;
		float num = unscaledTime2 - shownAt;
		if (num < message.lasts)
		{
			float num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			float num3 = num2 / 0f;
			float num4 = message.lasts - num;
			float num5 = num4 + num4;
			float num6 = ((!(num3 < num5)) ? num5 : num3);
			bool flag4 = num6 < 0f;
			double num7 = 0.0;
			if (!flag4)
			{
				bool flag5 = !((double)num6 > 1.0);
				num7 = num6;
				if (!flag5)
				{
					num7 = 1.0;
				}
			}
			Shown__BackingField = (float)num7;
			picture.enabled = true;
			picture.GetPropertyBlock(block);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v34+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v19+A0]");
			object obj13 = 0;
			MaterialPropertyBlock materialPropertyBlock = block;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v20+38]");
			materialPropertyBlock.SetTexture(0, tex);
			object obj14 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v21+A0]");
			object obj15 = 0;
			MaterialPropertyBlock materialPropertyBlock2 = block;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v22+3C]");
			materialPropertyBlock2.SetFloat(0, Shown__BackingField);
			picture.SetPropertyBlock(block);
		}
		else
		{
			current = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Shown__BackingField = 0f;
			picture.enabled = false;
		}
	}

	private bool Attach()
	{
		//IL_0010: Expected Obj, but got I
		//IL_07a9: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_0776: Expected I4, but got Obj
		//IL_0117: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I4
		//IL_023b: Expected VT, but got I4
		//IL_0260: Expected VT, but got I4
		//IL_029d: Expected VT, but got I4
		//IL_02ad: Expected Obj, but got I
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_039a: Expected Obj, but got I
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected Obj, but got Unknown
		//IL_03e4: Expected Obj, but got I
		//IL_045e: Expected Obj, but got I
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_049d: Expected Obj, but got I
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected Obj, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected Obj, but got Unknown
		//IL_04ee: Expected Obj, but got I4
		//IL_04f7: Expected Obj, but got I4
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Expected Obj, but got Unknown
		//IL_0643: Expected Obj, but got I4
		//IL_0537: Expected Obj, but got I4
		//IL_067b: Expected Obj, but got I4
		//IL_057c: Expected Obj, but got I4
		//IL_06c0: Expected Obj, but got I4
		//IL_05cd: Expected Obj, but got I
		//IL_0711: Expected Obj, but got I
		//IL_05f2: Expected Obj, but got I4
		//IL_0736: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = main == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(material == null))
			{
				GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)5);
				if ((object)gameObject != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1210]");
					object obj7 = 0;
					gameObject.name = (string)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7560]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
					object obj9 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v12+E4]");
					bool flag5 = (nint)0 == 0;
					object obj10 = !flag5;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object obj11 = default;
					UnityEngine.Object.Destroy(obj11);
					Transform transform = gameObject.transform;
					if ((object)main != null)
					{
						Transform parent = main.transform;
						if ((object)transform != null)
						{
							transform.SetParent(parent, worldPositionStays: false);
							Transform transform2 = gameObject.transform;
							if ((object)transform2 != null)
							{
								transform2.localPosition = (Vector3)0;
								Transform transform3 = gameObject.transform;
								Vector3 forward = default;
								Vector3 upwards = default;
								Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
								if ((object)transform3 != null)
								{
									transform3.localRotation = (Quaternion)0;
									Transform transform4 = gameObject.transform;
									if ((object)transform4 != null)
									{
										transform4.localScale = (Vector3)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B18]");
										object obj12 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
										object obj13 = this + 80;
										object obj14 = default;
										obj13 = obj14;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										if (obj13 != null)
										{
											((Renderer)obj13).sharedMaterial = material;
											if ((object)picture != null)
											{
												picture.shadowCastingMode = (ShadowCastingMode)0;
												if (obj13 != null)
												{
													((Renderer)obj13).receiveShadows = false;
													if (obj13 != null)
													{
														((Renderer)obj13).enabled = false;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
														object obj15 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
														MaterialPropertyBlock materialPropertyBlock = default;
														materialPropertyBlock._002Ector();
														object obj16 = this + 104;
														obj16 = materialPropertyBlock;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
														object obj17 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
														Texture2D texture2D = default;
														texture2D._002Ector(320, 80, (TextureFormat)4, mipChain: false);
														if ((object)texture2D != null)
														{
															texture2D.filterMode = (FilterMode)0;
															texture2D.wrapMode = (TextureWrapMode)1;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1218]");
															object obj18 = 0;
															texture2D.name = (string)obj18;
															object obj19 = this + 88;
															obj19 = texture2D;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
															object obj20 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
															object obj21 = this + 96;
															ScreenFont screenFont = default;
															obj21 = screenFont;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															object obj22 = this + 112;
															bool flag6 = obj22 == null;
															object obj23 = !flag6;
															object obj24 = 0;
															ScreenFont screenFont2 = screenFont;
															if (obj23 == null)
															{
																object obj25 = obj;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v78+E4]");
																bool flag7 = (nint)0 == 0;
																object obj26 = !flag7;
																if (obj26 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																}
																bool flag8 = titleFont != null;
																bool flag9 = !flag8;
																obj24 = 0;
																ScreenFont screenFont3 = null;
																if (!flag9)
																{
																	if ((object)titleFont == null)
																	{
																		goto IL_0768;
																	}
																	string baked = titleFont.text;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
																	object obj27 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																	ScreenFont screenFont4 = default;
																	screenFont4._002Ector(baked);
																	obj24 = 0;
																	screenFont3 = screenFont4;
																}
																obj22 = screenFont3;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																screenFont2 = screenFont3;
															}
															object obj28 = this + 120;
															bool flag10 = obj28 == null;
															object obj29 = !flag10;
															if (obj29 == null)
															{
																object obj30 = obj;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X0_v66+E4]");
																bool flag11 = (nint)0 == 0;
																object obj31 = !flag11;
																if (obj31 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																}
																bool flag12 = textFont != null;
																bool flag13 = !flag12;
																object obj32 = 0;
																ScreenFont screenFont5 = null;
																if (!flag13)
																{
																	if ((object)textFont == null)
																	{
																		goto IL_0768;
																	}
																	string baked2 = textFont.text;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
																	object obj33 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																	ScreenFont screenFont6 = default;
																	screenFont6._002Ector(baked2);
																	obj32 = 0;
																	screenFont5 = screenFont6;
																}
																obj28 = screenFont5;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															}
															return true;
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
				goto IL_0768;
			}
		}
		return false;
		IL_0768:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void LookAtQuests()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I
		//IL_00c4: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I
		//IL_0668: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_011b: Expected I, but got Obj
		//IL_01a8: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I4
		//IL_0191: Expected I, but got Obj
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_024f: Expected Obj, but got I4
		//IL_0271: Expected I, but got Obj
		//IL_027a: Expected Obj, but got I4
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02b7: Expected Obj, but got I4
		//IL_02bc: Expected I, but got Obj
		//IL_02c5: Expected Obj, but got I4
		//IL_02e3: Expected Obj, but got I
		//IL_0321: Expected Obj, but got I
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_036d: Expected Obj, but got I8
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected Obj, but got Unknown
		//IL_03cc: Expected Obj, but got I4
		//IL_03e2: Expected Obj, but got I
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected Obj, but got Unknown
		//IL_0425: Expected Obj, but got I
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_046f: Expected Obj, but got I4
		//IL_04d6: Expected Obj, but got I8
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected Obj, but got Unknown
		//IL_0535: Expected Obj, but got I4
		//IL_054b: Expected Obj, but got I
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Obj, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected Obj, but got Unknown
		//IL_05da: Expected Obj, but got I4
		//IL_0693: Expected Obj, but got I
		//IL_06c7: Expected Obj, but got I
		//IL_06c7: Expected Obj, but got I
		//IL_06d7: Expected I, but got Obj
		//IL_06ed: Expected Obj, but got I4
		float unscaledTime = Time.unscaledTime;
		if (unscaledTime < nextQuestLook)
		{
			return;
		}
		float unscaledTime2 = Time.unscaledTime;
		object obj = this + 128;
		float num = unscaledTime2 + 0.5f;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			IntPtr intPtr = default;
			obj = (nint)intPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			nint num2 = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1220]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1230]");
		object obj7 = 0;
		int num3 = 0;
		int num4 = 0;
		string[] array = default;
		while (true)
		{
			object obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = GillaQuests.DoneAt(num4);
			bool flag4 = !flag3;
			nint num2 = unchecked((nint)null);
			object obj14;
			if (!flag4)
			{
				object obj10 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v16+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag6 = GillaQuests.ClaimedAt(num4);
				bool flag7 = !flag6;
				num2 = unchecked((nint)null);
				if (flag7)
				{
					object obj12 = obj;
					int num5 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X9_v7+18]");
					bool flag8 = (nint)num5 < (nint)0;
					object obj13 = !flag8;
					if (obj13 != null)
					{
						break;
					}
					bool flag9 = obj == null;
					num2 = unchecked((nint)null);
					obj14 = 1;
					if (!flag9)
					{
						object obj15 = obj12 + num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X9_v8+20]");
						bool flag10 = (nint)0 == 0;
						object obj16 = !flag10;
						num2 = unchecked((nint)null);
						obj14 = 1;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							if (array.Length == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60E0]");
							object obj18 = 0;
							object obj19 = array + 32;
							obj19 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							string text = num3.ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X23_v6-8]");
							object obj20 = 0 & 0xFFFFFFFEL;
							if (obj20 == null)
							{
								break;
							}
							object obj21 = array + 40;
							obj21 = text;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X23_v8-10]");
							bool flag11 = (nint)0 < (nint)2;
							object obj22 = !flag11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X23_v8-10]");
							object obj23 = -2;
							bool flag12 = obj23 == null;
							object obj24 = ~obj22;
							object obj25 = obj24 | flag12;
							if (obj25 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1228]");
							object obj26 = 0;
							object obj27 = array + 48;
							obj27 = obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj28 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v31+E4]");
							bool flag13 = (nint)0 == 0;
							object obj29 = !flag13;
							if (obj29 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							GillaRecycler.Quest quest = GillaQuests.QuestAt(num4);
							int num6 = GillaLevel.ForYou(quest.xp);
							string text2 = num3.ToString();
							object obj30 = array.Length & 0xFFFFFFFCL;
							if (obj30 == null)
							{
								break;
							}
							object obj31 = array + 56;
							obj31 = text2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X23_v2-20]");
							bool flag14 = (nint)0 < (nint)4;
							object obj32 = !flag14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X23_v2-20]");
							object obj33 = -4;
							bool flag15 = obj33 == null;
							object obj34 = ~obj32;
							object obj35 = obj34 | flag15;
							if (obj35 != null)
							{
								break;
							}
							object obj36 = array + 64;
							obj36 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							string bottom = string.Concat(array);
							object obj37 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v27+E4]");
							bool flag16 = (nint)0 == 0;
							object obj38 = !flag16;
							if (obj38 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj37 = obj6;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v27+A0]");
							object obj39 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v28+10]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v28+8]");
							Show((string)obj7, bottom, (Color32[])num7, (Color32[])0, hunt: false, 3f);
							num3 = num6;
							num2 = (nint)obj7;
							num = 3f;
							obj14 = 1;
						}
					}
					goto IL_0676;
				}
			}
			obj14 = 0;
			goto IL_0676;
			IL_0676:
			object obj40 = obj;
			int num8 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X9_v3+18]");
			bool flag17 = (nint)num8 < (nint)0;
			object obj41 = !flag17;
			if (obj41 != null)
			{
				break;
			}
			object obj42 = obj40 + num4;
			num4++;
			if (num4 == 3)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private unsafe void LookAtClocks()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0640: Expected Obj, but got I
		//IL_0662: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_0095: Expected F4, but got I4
		//IL_02ae: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I
		//IL_02e8: Expected Obj, but got I4
		//IL_0338: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I
		//IL_00df: Expected I4, but got Obj
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0133: Expected I, but got VT
		//IL_03aa: Expected Obj, but got I4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0189: Expected I, but got VT
		//IL_069f: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I4
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected Obj, but got Unknown
		//IL_04e5: Expected Obj, but got I4
		//IL_0566: Expected Obj, but got I
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaModeRound gillaModeRound = GillaModeRound.Current;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool inHunt = GillaMapVote.InHunt;
		bool flag3 = !inHunt;
		float num = 0f;
		object obj10 = default;
		nint num5 = default;
		bool flag7;
		if (!flag3)
		{
			NetworkDictionary<PlayerRef, byte> players = gillaModeRound.Players;
			PlayerRef localPlayer = ((SimulationBehaviour)gillaModeRound)._runner.LocalPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
			object obj7 = 0;
			int num2 = (int)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
			object obj9 = default;
			object obj8 = obj9 & 1;
			bool flag4 = obj8 == null;
			int num3 = (int)(&obj10);
			object obj12 = default;
			object obj11 = obj12;
			float num4 = default;
			num = num4;
			object obj14 = default;
			object obj13 = obj14;
			num5 = (nint)localPlayer;
			if (!flag4)
			{
				object obj15 = obj10 | 2;
				bool flag5 = (nint)obj15 != 3;
				num3 = (int)(&obj10);
				obj11 = obj12;
				num = num4;
				obj13 = obj14;
				num5 = (nint)localPlayer;
				if (!flag5)
				{
					following = true;
					int round = gillaModeRound.Round;
					float huntEnds = gillaModeRound.HuntEnds;
					float now = gillaModeRound.Now;
					if ((nint)obj10 == 3)
					{
						byte startMonsters = gillaModeRound.StartMonsters;
						int num6 = startMonsters & 0xFE;
						bool flag6 = num6 == 0;
						object obj16 = !flag6;
						object obj17 = ~obj16;
						num2 = ((obj17 != null) ? 1 : 3);
					}
					else
					{
						num2 = 2;
					}
					num = huntEnds - now;
					TimeLeft(isRace: false, round, num, num2);
					num3 = round;
					obj11 = obj12;
					obj13 = obj14;
					flag7 = false;
					goto IL_029e;
				}
			}
		}
		_ = 0;
		bool flag8 = (byte)(~(following ? 1u : 0u)) != 0;
		flag7 = (byte)num5 != 0;
		if (!flag8)
		{
			LetGoOfHunt();
			flag7 = (byte)num5 != 0;
		}
		goto IL_029e;
		IL_029e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B8]");
		object obj18 = 0;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v13+E4]");
		bool flag9 = (nint)0 == 0;
		object obj21 = !flag9;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaSplashGame gillaSplashGame = GillaSplashGame.Current;
		object obj22 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v10+E4]");
		bool flag10 = (nint)0 == 0;
		object obj23 = !flag10;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)gillaSplashGame != (UnityEngine.Object)null)
		{
			object obj24 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v22+E4]");
			bool flag11 = (nint)0 == 0;
			object obj25 = !flag11;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)((SimulationBehaviour)gillaSplashGame)._object != (UnityEngine.Object)null)
			{
				NetworkObject networkObject = ((SimulationBehaviour)gillaSplashGame)._object;
				object obj26 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v27+E4]");
				bool flag12 = (nint)0 == 0;
				object obj27 = !flag12;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((bool)networkObject._runner)
				{
					ArgumentNullException ex = new ArgumentNullException();
					object obj28 = ex & 1;
					if (obj28 != null)
					{
						byte phase = gillaSplashGame.Phase;
						int num7 = phase & 0xFF;
						if (num7 == 2)
						{
							object obj29 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v35+E4]");
							bool flag13 = (nint)0 == 0;
							object obj30 = !flag13;
							if (obj30 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if ((UnityEngine.Object)((SimulationBehaviour)gillaSplashGame)._runner != (UnityEngine.Object)null)
							{
								NetworkDictionary<PlayerRef, byte> players2 = gillaSplashGame.Players;
								PlayerRef localPlayer2 = ((SimulationBehaviour)gillaSplashGame)._runner.LocalPlayer;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
								object obj31 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
								object obj33 = default;
								object obj32 = obj33 & 1;
								if (obj32 != null && (nint)obj10 == 1)
								{
									int starts = gillaSplashGame.Starts;
									float phaseEnds = gillaSplashGame.PhaseEnds;
									float now2 = gillaSplashGame.Now;
									float left = phaseEnds - now2;
									TimeLeft(isRace: true, starts, left, 0);
									return;
								}
							}
						}
					}
				}
			}
		}
		_ = 0;
	}

	private void LetGoOfHunt()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1288]");
		object obj = 0;
		object obj2 = obj;
		following = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CCDC");
	}

	public void TimeLeft(bool isRace, int key, float left, int role = default(int))
	{
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected Obj, but got Unknown
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Expected Obj, but got Unknown
		//IL_0837: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0859: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0879: Expected Obj, but got I4
		//IL_0882: Invalid comparison between F4 and I4
		//IL_0aae: Expected Obj, but got I
		//IL_0ad8: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I
		//IL_026b: Expected Obj, but got I4
		//IL_0413: Expected Obj, but got I4
		//IL_09ea: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got I
		//IL_0455: Expected Obj, but got I
		//IL_047f: Expected Obj, but got I4
		//IL_02be: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_04aa: Expected I4, but got F8
		//IL_04d4: Expected Obj, but got I4
		//IL_04f1: Invalid comparison between F4 and I4
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected Obj, but got Unknown
		//IL_06a6: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I
		//IL_0198: Expected Obj, but got I4
		//IL_0a7e: Expected Obj, but got I
		//IL_053d: Expected Obj, but got I4
		//IL_0572: Expected Obj, but got I
		//IL_02d3: Expected Obj, but got I
		//IL_0b38: Expected Obj, but got I4
		//IL_0a0e: Expected Obj, but got I
		//IL_0997: Expected Obj, but got I
		//IL_02fa: Expected Obj, but got I4
		//IL_0767: Expected Obj, but got I4
		//IL_06f2: Expected Obj, but got I
		//IL_0702: Expected Obj, but got I
		//IL_070d: Expected Obj, but got I4
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected I4, but got Unknown
		//IL_05f5: Expected Obj, but got I4
		//IL_0968: Expected Obj, but got I4
		//IL_0a99: Expected Obj, but got I
		//IL_0a44: Expected Obj, but got I
		//IL_05ae: Expected Obj, but got I4
		//IL_033c: Expected Obj, but got I
		//IL_0366: Expected Obj, but got I4
		//IL_0b08: Expected Obj, but got I4
		//IL_0b68: Expected Obj, but got I4
		//IL_0a29: Expected Obj, but got I
		//IL_0391: Expected I4, but got F8
		//IL_03a5: Expected Obj, but got I
		//IL_07b3: Expected Obj, but got I
		//IL_07be: Expected Obj, but got I4
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected I4, but got Unknown
		//IL_07f7: Expected Obj, but got I
		//IL_0641: Expected Obj, but got I
		//IL_0651: Expected Obj, but got I
		object obj = this + 152;
		object obj2 = this + 140;
		bool flag = !isRace;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			object obj5 = 152;
		}
		else
		{
			object obj5 = 140;
		}
		object obj6 = !flag;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
			object obj8 = obj;
		}
		else
		{
			object obj8 = obj2;
		}
		object obj9 = 109891584;
		if (left < 0f)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		bool flag3 = !isRace;
		object obj13 = !flag3;
		object obj14 = ~obj13;
		object obj15;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1270]");
			obj15 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1260]");
			obj15 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X24_v1+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v8 (GillaHud)+v83 @ X28_v1]");
			if ((nint)0 == key)
			{
				bool flag4;
				bool flag5;
				if (0 >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X24_v1+4]");
					object obj16 = -0;
					flag4 = (nint)obj16 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X24_v1+4]");
					object obj17 = 0 & obj16;
					flag5 = (nint)obj17 < 0;
				}
				else
				{
					flag5 = false;
					flag4 = false;
				}
				if (flag4 != flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
					object obj18 = 0;
					object obj19 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v60+E4]");
					bool flag6 = (nint)0 == 0;
					object obj20 = !flag6;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string top = Minutes(0);
					object obj21 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v61+E4]");
					bool flag7 = (nint)0 == 0;
					object obj22 = !flag7;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj21 = obj18;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v61+A0]");
					object topColours = (nint)0 + (nint)24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v61+E4]");
					bool flag8 = (nint)0 == 0;
					object obj23 = !flag8;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj24 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X8_v62+A0]");
					object obj25 = 0;
					object obj26 = !isRace;
					bool flag9 = (byte)(1 & obj26) != 0;
					object bottom = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v63+30]");
					Show(top, (string)bottom, (Color32[])topColours, (Color32[])0, flag9, 3f);
				}
				_ = 0;
				return;
			}
		}
		_ = 0;
		_ = 1;
		_ = 0;
		_ = 0;
		Color32[] bottomColours;
		bool flag17;
		Color32[] topColours2;
		string top2;
		string bottom2;
		float lasts;
		if (role != 0)
		{
			bool flag10 = !isRace;
			object obj27 = !flag10;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1278]");
				object obj28 = 0;
				if (role != 3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1280]");
					obj28 = 0;
				}
				if (role == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1268]");
					obj28 = 0;
				}
				string text2;
				if ((double)left > 1.0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X26_v1+B07]");
					bool flag11 = (nint)0 == 0;
					object obj29 = !flag11;
					if (obj29 == null)
					{
						_ = 1;
					}
					object obj30 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v47+E4]");
					bool flag12 = (nint)0 == 0;
					object obj31 = !flag12;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
					object obj32 = 0;
					object obj33 = obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X0_v49+E4]");
					bool flag13 = (nint)0 == 0;
					object obj34 = !flag13;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text = Minutes(1);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
					object obj35 = 0;
					text2 = text + (string)obj35;
					double num = 1.0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj36 = 0;
					text2 = (string)obj36;
					double num = 1.0;
				}
				string text3 = text2 + (string)obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
				object obj37 = 0;
				object obj38 = obj37;
				object obj40;
				if (role == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v33+E4]");
					bool flag14 = (nint)0 == 0;
					object obj39 = !flag14;
					if (obj39 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj38 = obj37;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v33+A0]");
					obj40 = (nint)0 + (nint)40;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v33+E4]");
					bool flag15 = (nint)0 == 0;
					object obj41 = !flag15;
					if (obj41 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj38 = obj37;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v33+A0]");
					obj40 = (nint)0 + (nint)32;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v33+E4]");
				bool flag16 = (nint)0 == 0;
				object obj42 = !flag16;
				if (obj42 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj43 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v34+A0]");
				object obj44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v35+30]");
				bottomColours = (Color32[])0;
				flag17 = true;
				topColours2 = (Color32[])obj40;
				top2 = (string)obj28;
				bottom2 = text3;
				lasts = 3f;
				goto IL_0a49;
			}
		}
		if (!((double)left > 1.0))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X26_v1+B07]");
		bool flag18 = (nint)0 == 0;
		object obj45 = !flag18;
		if (obj45 == null)
		{
			_ = 1;
		}
		object obj46 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v10+E4]");
		bool flag19 = (nint)0 == 0;
		object obj47 = !flag19;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
		object obj48 = 0;
		object obj49 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v12+E4]");
		bool flag20 = (nint)0 == 0;
		object obj50 = !flag20;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text4 = Minutes(1);
		object obj51 = obj48;
		bool flag21 = (double)left < 30.0;
		object obj52 = !flag21;
		float num2 = left - 30f;
		bool flag22 = num2 == 0f;
		object obj53 = ~obj52;
		object obj54 = obj53 | flag22;
		object obj56;
		if (obj54 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v18+E4]");
			bool flag23 = (nint)0 == 0;
			object obj55 = !flag23;
			if (obj55 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj51 = obj48;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v18+A0]");
			obj56 = (nint)0 + (nint)24;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v18+E4]");
			bool flag24 = (nint)0 == 0;
			object obj57 = !flag24;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj51 = obj48;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v18+A0]");
			obj56 = (nint)0 + (nint)32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v18+E4]");
		bool flag25 = (nint)0 == 0;
		object obj58 = !flag25;
		if (obj58 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj59 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v19+A0]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v20+30]");
		bottomColours = (Color32[])0;
		object obj61 = !isRace;
		flag17 = (byte)(1 & obj61) != 0;
		topColours2 = (Color32[])obj56;
		top2 = text4;
		bottom2 = (string)obj15;
		lasts = 3f;
		goto IL_0a49;
		IL_0a49:
		Show(top2, bottom2, topColours2, bottomColours, flag17, lasts);
	}

	private static string Minutes(int seconds)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6160]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
		object obj2 = 0;
		int num = default;
		string text = num.ToString();
		string text2 = num.ToString((string)obj);
		return text + (string)obj2 + text2;
	}

	private unsafe void Draw(Message m)
	{
		//IL_0011: Expected Obj, but got I
		//IL_0e07: Expected Obj, but got I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0077: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I
		//IL_0225: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I4
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected I4, but got Unknown
		//IL_02cc: Expected Obj, but got I4
		//IL_0e30: Expected Obj, but got I4
		//IL_0e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3f: Expected Obj, but got Unknown
		//IL_0ef7: Expected VT, but got Ref
		//IL_00e8: Expected Obj, but got I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0389: Expected Obj, but got I4
		//IL_039f: Expected Obj, but got I
		//IL_034b: Expected VT, but got Ref
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got I4
		//IL_0529: Expected Obj, but got I
		//IL_0548: Expected Obj, but got I4
		//IL_055b: Expected Obj, but got I4
		//IL_06f8: Expected Obj, but got I4
		//IL_0419: Expected Obj, but got I
		//IL_0438: Expected Obj, but got I4
		//IL_044b: Expected Obj, but got I4
		//IL_05a1: Expected Obj, but got I4
		//IL_05b4: Expected Obj, but got I4
		//IL_0681: Expected Obj, but got I4
		//IL_072f: Expected Obj, but got I4
		//IL_0738: Expected Obj, but got I4
		//IL_0757: Expected Obj, but got I
		//IL_0792: Expected Obj, but got I4
		//IL_04a6: Expected Obj, but got I4
		//IL_116c: Expected Obj, but got I
		//IL_1196: Expected Obj, but got I4
		//IL_060f: Expected Obj, but got I4
		//IL_06c3: Expected Obj, but got I4
		//IL_06d1: Expected I, but got Obj
		//IL_04dd: Expected Obj, but got I4
		//IL_04e6: Expected Obj, but got I4
		//IL_07e2: Expected I, but got Obj
		//IL_0801: Expected Obj, but got I
		//IL_080e: Expected Obj, but got I4
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_0846: Expected I4, but got Unknown
		//IL_0885: Expected Obj, but got I4
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Expected Obj, but got Unknown
		//IL_0651: Expected Obj, but got I4
		//IL_0f63: Expected Obj, but got I4
		//IL_0f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8d: Expected I4, but got Unknown
		//IL_0fc2: Expected Obj, but got I4
		//IL_0ffb: Expected Obj, but got I4
		//IL_08fb: Expected Obj, but got I4
		//IL_0909: Expected Obj, but got I4
		//IL_095a: Expected Obj, but got I4
		//IL_1017: Expected I4, but got Obj
		//IL_1045: Expected VT, but got I8
		//IL_105d: Expected Obj, but got I4
		//IL_1082: Unknown result type (might be due to invalid IL or missing references)
		//IL_1087: Expected I4, but got Unknown
		//IL_10bc: Expected Obj, but got I4
		//IL_10e1: Expected Obj, but got Ref
		//IL_10fb: Expected Obj, but got I
		//IL_1125: Expected Obj, but got I4
		//IL_09c9: Expected VT, but got Ref
		//IL_09e8: Expected Obj, but got I4
		//IL_09fb: Expected Obj, but got I4
		//IL_0a56: Expected VT, but got Ref
		//IL_0cd0: Expected VT, but got I8
		//IL_0cd9: Expected I4, but got Obj
		//IL_0ce1: Expected I4, but got Obj
		//IL_0cea: Expected Obj, but got I4
		//IL_0cff: Expected Obj, but got I8
		//IL_0a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a99: Expected Obj, but got Unknown
		//IL_0ac3: Expected VT, but got Ref
		//IL_0d4f: Expected VT, but got I8
		//IL_0d58: Expected I4, but got Obj
		//IL_0d60: Expected I4, but got Obj
		//IL_0d65: Expected I, but got Obj
		//IL_0d6e: Expected Obj, but got I4
		//IL_0d8d: Expected Obj, but got I8
		//IL_114e: Expected Obj, but got I4
		//IL_0aff: Expected Obj, but got I
		//IL_0b0c: Expected I4, but got Obj
		//IL_0b1e: Expected Obj, but got Ref
		//IL_0b3d: Expected Obj, but got I
		//IL_0b67: Expected Obj, but got I4
		//IL_0b9f: Expected VT, but got Ref
		//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bad: Expected Obj, but got Unknown
		//IL_0bcb: Expected Obj, but got I4
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdd: Expected Obj, but got Unknown
		//IL_0c42: Expected VT, but got Ref
		//IL_0c81: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1238]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		bool flag = obj2 == null;
		Color32[] array = null;
		Color32[] array2 = null;
		bool cut = false;
		GillaHud gillaHud = null;
		Message message = m;
		object obj3 = obj2;
		object obj4 = 109895680;
		Message message2 = default;
		ScreenFont screenFont = default;
		Message message3;
		object obj10;
		bool flag5;
		object obj9;
		object obj7;
		object obj8;
		bool flag4;
		if (!flag)
		{
			object obj5 = obj2 + 16;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag2 = px == null;
			array = null;
			array2 = null;
			cut = false;
			gillaHud = this;
			message = m;
			obj3 = obj2;
			obj4 = 109895680;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1248]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1258]");
				message2 = (Message)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1240]");
				screenFont = (ScreenFont)0;
				object obj6 = 0;
				Color32[] array3 = px;
				while (true)
				{
					bool flag3 = (nint)obj6 < array3.Length;
					obj7 = !flag3;
					obj8 = obj6 - array3.Length;
					flag4 = obj8 == null;
					flag5 = (nint)obj6 >= array3.Length;
					array = null;
					array2 = null;
					cut = false;
					obj9 = obj6;
					gillaHud = this;
					message3 = m;
					obj10 = obj2;
					if (flag5)
					{
						break;
					}
					bool flag6 = (nint)obj6 < array3.Length;
					obj7 = !flag6;
					obj8 = obj6 - array3.Length;
					flag4 = obj8 == null;
					if (obj7 == null)
					{
						object obj11 = (object)array3 + obj6;
						obj9 = obj6 + 1;
						_ = 0;
						bool flag7 = px == null;
						object obj12 = !flag7;
						array = null;
						array2 = null;
						cut = false;
						gillaHud = this;
						message = m;
						obj3 = obj2;
						obj6 = obj9;
						array3 = px;
						if (obj12 != null)
						{
							continue;
						}
						goto IL_01a0;
					}
					goto IL_0dac;
				}
				goto IL_01be;
			}
		}
		goto IL_01a0;
		IL_115c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X0_v15+E4]");
		bool flag8 = (nint)0 == 0;
		object obj15 = !flag8;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int scale;
		int num = Measure(title, message3.top, scale);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Func<System.__Canon, int> func = default;
		func._002Ector(obj10, (IntPtr)message2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35CF46C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj16 = 0;
		int num2 = default;
		object obj17 = num - num2;
		bool flag9 = (nint)obj17 < 0;
		bool flag10 = obj17 == null;
		int num3 = num ^ num2;
		int num4 = num ^ obj17;
		int num5 = num3 & num4;
		bool flag11 = num5 < 0;
		Color32[] array4 = px;
		bool flag12 = flag9 == flag11;
		object obj18 = !flag10;
		object obj19 = flag12 & obj18;
		object obj20 = ~obj19;
		int num6 = ((obj20 != null) ? num2 : num);
		object obj21 = obj16;
		int num7 = num6 + 28;
		object obj22 = num7 - 316;
		bool flag13 = (nint)obj22 < 0;
		int num8 = num7 ^ 0x13C;
		int num9 = num7 ^ obj22;
		int num10 = num8 & num9;
		bool flag14 = num10 < 0;
		bool flag15 = flag13 == flag14;
		object obj23 = !flag15;
		object obj24 = ~obj23;
		int num11 = ((obj24 != null) ? 316 : num7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v23+E4]");
		bool flag16 = (nint)0 == 0;
		object obj25 = !flag16;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj26 = 320 - num11;
		object obj27 = 321 - num11;
		bool flag17 = (nint)obj26 < 0;
		object obj28 = obj26 ^ obj26;
		object obj29 = obj26 & obj28;
		bool flag18 = (nint)obj29 < 0;
		bool flag19 = flag17 == flag18;
		object obj30 = !flag19;
		object obj31 = ~obj30;
		if (obj31 == null)
		{
			obj26 = obj27;
		}
		int x = obj26 >> 1;
		PixelFont.Fill(array4, 320, 80, x, 3, num11, 74, (Color32)3825730564L);
		screenFont = title;
		int num12;
		object obj32 = num12 - 289;
		bool flag20 = (nint)obj32 < 0;
		int num13 = num12 ^ 0x121;
		int num14 = num12 ^ obj32;
		int num15 = num13 & num14;
		bool flag21 = num15 < 0;
		bool flag22 = flag20 == flag21;
		object obj33 = !flag22;
		object obj34 = ~obj33;
		int num16 = ((obj34 != null) ? 13 : 7);
		object obj35 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref array, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
		object obj36 = 0;
		object obj37 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X0_v28+E4]");
		bool flag23 = (nint)0 == 0;
		object obj38 = !flag23;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Color32[] array5 = default;
		Line(screenFont, 160, num16, message3.top, (ShiftAuth.Style)(&array5));
		List<string> list;
		bool flag24 = list._size < 1;
		obj7 = !flag24;
		obj8 = list._size - 1;
		flag4 = obj8 == null;
		flag5 = list._size < 1;
		Color32[] topColours = message3.topColours;
		array2 = array;
		string text = message3.top;
		int num17 = num16;
		ShiftAuth.Style style = (ShiftAuth.Style)(&array5);
		nint num18 = 160;
		gillaHud = (GillaHud)(object)screenFont;
		message = (Message)(object)message3.top;
		obj3 = obj10;
		if (flag5)
		{
			goto IL_0c9f;
		}
		Color32[] array6;
		obj3 = array6 + 32;
		Color32[] topColours2 = message3.topColours;
		string top = message3.top;
		int num19 = num16;
		ShiftAuth.Style style2 = (ShiftAuth.Style)(&array5);
		Color32[] array7 = array6;
		Message message4 = null;
		Color32[] array8 = default;
		while (true)
		{
			bool flag25 = (nint)message4 < array7.Length;
			object obj39 = !flag25;
			if (obj39 != null)
			{
				break;
			}
			screenFont = this.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X20_v9 (System.Object)+v498 @ X24_v8 (GillaHud+Message)*4]");
			num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C83C0]");
			object obj40 = 0;
			System.__Canon _Canon = ((List<System.__Canon>)(object)list).get_Item((int)message4);
			object obj41 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref array, 16));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
			object obj42 = 0;
			object obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X0_v39+E4]");
			bool flag26 = (nint)0 == 0;
			object obj44 = !flag26;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Line(screenFont, 160, num16, (string)(object)_Canon, (ShiftAuth.Style)(&array8));
			message = (Message)(message4 + 1);
			bool flag27 = (nint)message < list._size;
			obj7 = !flag27;
			obj8 = message - list._size;
			flag4 = obj8 == null;
			flag5 = (nint)message < list._size;
			array8 = array;
			topColours = message3.bottomColours;
			array2 = array;
			array4 = (Color32[])(object)_Canon;
			text = (string)(object)_Canon;
			num17 = num16;
			style = (ShiftAuth.Style)(&array8);
			num18 = 160;
			gillaHud = (GillaHud)(object)screenFont;
			array8 = array;
			topColours2 = message3.bottomColours;
			top = (string)(object)_Canon;
			num19 = num16;
			style2 = (ShiftAuth.Style)(&array8);
			array7 = array6;
			message4 = message;
			if (flag5)
			{
				continue;
			}
			goto IL_0c9f;
		}
		goto IL_0dac;
		IL_0f2d:
		Color32[] array9 = default;
		array6 = array9;
		goto IL_115c;
		IL_0f1b:
		Color32[] array10 = default;
		array6 = array10;
		goto IL_115c;
		IL_0c9f:
		bool flag28 = (object)tex == null;
		int num20 = 74;
		array5 = array;
		Color32 color = (Color32)3825730564L;
		int num21 = (int)array6;
		int num22 = (int)text;
		obj9 = 1048576000;
		message2 = message3;
		obj4 = 4279110154L;
		if (!flag28)
		{
			tex.SetPixels32(px);
			bool flag29 = (object)tex == null;
			num20 = 74;
			array5 = array;
			color = (Color32)3825730564L;
			num21 = (int)array6;
			num22 = (int)text;
			num18 = unchecked((nint)null);
			obj9 = 1048576000;
			message2 = message3;
			gillaHud = (GillaHud)(object)px;
			obj4 = 4279110154L;
			if (!flag29)
			{
				tex.Apply(updateMipmaps: false);
				return;
			}
		}
		goto IL_01a0;
		IL_0dac:
		throw new IndexOutOfRangeException();
		IL_01a0:
		NullReferenceException ex = new NullReferenceException();
		message3 = message;
		obj10 = obj3;
		goto IL_01be;
		IL_01be:
		bool flag30 = message3 == null;
		message = message3;
		obj3 = obj10;
		if (!flag30)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
			object obj45 = 0;
			object obj46 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v7+E4]");
			bool flag31 = (nint)0 == 0;
			object obj47 = !flag31;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num12 = Measure(title, message3.top, 3);
			object obj48 = num12 - 289;
			bool flag32 = (nint)obj48 < 0;
			int num23 = num12 ^ 0x121;
			int num24 = num12 ^ obj48;
			int num25 = num23 & num24;
			bool flag33 = num25 < 0;
			bool flag34 = flag32 == flag33;
			object obj49 = !flag34;
			obj34 = ~obj49;
			num21 = ((obj34 != null) ? 2 : (2 + 1));
			_ = 2;
			list = Wrap(message3.bottom, 288, 2, 2, out cut);
			bool flag35 = !cut;
			num22 = 2;
			num17 = 2;
			style = (ShiftAuth.Style)(&cut);
			num18 = 288;
			gillaHud = (GillaHud)(object)message3.bottom;
			if (!flag35)
			{
				_ = 1;
				list = Wrap(message3.bottom, 296, 3, 1, out var cut2);
				num22 = 1;
				num17 = 3;
				style = (ShiftAuth.Style)(&cut2);
				num18 = 296;
				gillaHud = (GillaHud)(object)message3.bottom;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X20_v5 (System.Object)+18]");
			bool flag36 = (nint)0 < (nint)2;
			obj7 = !flag36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X20_v5 (System.Object)+18]");
			obj8 = -2;
			flag4 = obj8 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X20_v5 (System.Object)+18]");
			if ((nint)0 == 2)
			{
				bool flag37 = (object)list == null;
				message = message3;
				obj3 = obj10;
				if (!flag37)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
					obj9 = 0;
					bool flag38 = list._size < 1;
					obj7 = !flag38;
					obj8 = list._size - 1;
					flag4 = obj8 == null;
					if (list._size == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						bool flag39 = array10 == null;
						gillaHud = (GillaHud)1;
						message = message3;
						obj3 = obj10;
						if (!flag39)
						{
							scale = num21;
							ScreenFont screenFont2 = screenFont;
							GillaHud gillaHud2 = (GillaHud)1;
							object obj50 = 50;
							goto IL_0f1b;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						bool flag40 = array9 == null;
						gillaHud = (GillaHud)2;
						message = message3;
						obj3 = obj10;
						if (!flag40)
						{
							_ = 37;
							scale = num21;
							ScreenFont screenFont2 = screenFont;
							GillaHud gillaHud2 = (GillaHud)2;
							nint num26 = (nint)typeof(_0021_00210);
							goto IL_0f2d;
						}
					}
				}
			}
			else
			{
				bool flag41 = (object)list == null;
				message = message3;
				obj3 = obj10;
				if (!flag41)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
					obj9 = 0;
					bool flag42 = list._size < 1;
					obj7 = !flag42;
					obj8 = list._size - 1;
					if (list._size != 1)
					{
						bool flag43 = list._size < 2;
						obj7 = !flag43;
						obj8 = list._size - 2;
						flag4 = obj8 == null;
						if (list._size != 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1250]");
							object obj51 = 0;
							object obj52 = obj51;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v54+8]");
							_ = 0;
							scale = num21;
							Color32[] array11 = default;
							array6 = array11;
							ScreenFont screenFont2 = screenFont;
							GillaHud gillaHud2 = (GillaHud)3;
							goto IL_115c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						bool flag44 = array9 == null;
						gillaHud = (GillaHud)2;
						message = message3;
						obj3 = obj10;
						if (!flag44)
						{
							_ = 45;
							scale = num21;
							ScreenFont screenFont2 = screenFont;
							GillaHud gillaHud2 = (GillaHud)2;
							nint num26 = 56;
							goto IL_0f2d;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						bool flag45 = array10 == null;
						gillaHud = (GillaHud)1;
						message = message3;
						obj3 = obj10;
						if (!flag45)
						{
							scale = num21;
							ScreenFont screenFont2 = screenFont;
							GillaHud gillaHud2 = (GillaHud)1;
							object obj50 = 53;
							goto IL_0f1b;
						}
					}
				}
			}
		}
		goto IL_01a0;
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

	private unsafe List<string> Wrap(string s, int wide, int most, int scale, out bool cut)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0f90: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I
		//IL_0980: Expected Obj, but got I4
		//IL_09b9: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I4
		//IL_013d: Expected Obj, but got I4
		//IL_107e: Expected Obj, but got I4
		//IL_0b44: Expected Obj, but got I4
		//IL_0bd8: Expected Obj, but got I4
		//IL_0170: Expected Obj, but got I
		//IL_0c49: Expected Obj, but got Ref
		//IL_0a3e: Expected I, but got Obj
		//IL_0cfe: Expected Obj, but got I
		//IL_0d54: Expected Obj, but got Ref
		//IL_08af: Expected Obj, but got I4
		//IL_08b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bd: Expected Obj, but got Unknown
		//IL_0ac0: Expected Obj, but got I4
		//IL_0da9: Expected Obj, but got Ref
		//IL_0b87: Expected Obj, but got I
		//IL_0b97: Expected Obj, but got I
		//IL_0935: Expected Obj, but got I4
		//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c89: Expected Obj, but got Unknown
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae5: Expected Obj, but got Unknown
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Expected Obj, but got Unknown
		//IL_0270: Expected Obj, but got I4
		//IL_0dc7: Expected Obj, but got I
		//IL_0ff7: Expected I, but got Obj
		//IL_1023: Expected Obj, but got I4
		//IL_034e: Expected I4, but got Obj
		//IL_029e: Expected Obj, but got I
		//IL_02c4: Expected Obj, but got I4
		//IL_0ded: Expected I, but got Obj
		//IL_0e0f: Expected Obj, but got I4
		//IL_03a0: Expected I4, but got Obj
		//IL_06ca: Expected I4, but got Obj
		//IL_060a: Expected I, but got Obj
		//IL_062c: Expected Obj, but got I4
		//IL_03d3: Expected I, but got Obj
		//IL_0417: Expected I4, but got Obj
		//IL_0eef: Expected Obj, but got I4
		//IL_0f08: Expected Obj, but got I4
		//IL_06fd: Expected Obj, but got I
		//IL_0742: Expected I4, but got Obj
		//IL_044c: Expected Obj, but got I4
		//IL_046c: Expected Obj, but got I4
		//IL_076f: Expected Obj, but got I4
		//IL_077f: Expected Obj, but got I
		//IL_079f: Expected Obj, but got I4
		//IL_04f6: Expected Obj, but got I
		//IL_0506: Expected Obj, but got I
		//IL_054f: Expected Obj, but got I4
		//IL_056b: Expected I4, but got Obj
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected Obj, but got Unknown
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected Obj, but got Unknown
		//IL_0848: Expected Obj, but got I4
		//IL_0851: Expected Obj, but got I4
		//IL_0862: Expected Obj, but got I4
		//IL_0872: Expected I4, but got Obj
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected Obj, but got Unknown
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f2: Expected Obj, but got Unknown
		//IL_05c1: Expected I4, but got Obj
		//IL_0898: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7220]");
		int num = 0;
		ref bool reference = ref *(bool*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj2 = 0;
		string text = (string)obj2;
		string text2 = (string)((s != null) ? s : obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		char[] array = default;
		bool flag = array == null;
		string text3 = s;
		List<System.__Canon> list2 = list;
		string text4;
		string text5;
		string text7;
		System.__Canon _Canon;
		int num11;
		if (!flag)
		{
			if (array.Length == 0)
			{
				goto IL_0f56;
			}
			array[0] = ' ';
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			text3 = (string)0;
			bool flag2 = text2 == null;
			list2 = list;
			if (!flag2)
			{
				string[] array2 = text2.Split(array, (StringSplitOptions)1);
				bool flag3 = array2 == null;
				list2 = list;
				if (!flag3)
				{
					object obj3 = array2.Length;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
					text4 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
					text5 = (string)0;
					object obj12;
					StringSplitOptions stringSplitOptions2;
					if (array2.Length >= 1)
					{
						object obj4 = 0;
						object obj5 = 0;
						StringSplitOptions stringSplitOptions = (StringSplitOptions)1;
						char[] array3 = array;
						object obj9 = default;
						object obj11 = default;
						int num4 = default;
						while (true)
						{
							bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
							object obj6 = !flag4;
							if (obj6 != null)
							{
								break;
							}
							object obj7 = (object)array2 + obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v37+20]");
							string text6 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v37+20]");
							bool flag5 = (nint)0 == 0;
							text7 = text3;
							int num2 = num;
							list2 = list;
							text2 = text4;
							if (!flag5)
							{
								object obj8;
								object obj10;
								int num3;
								char[] array4;
								while (true)
								{
									bool flag6 = text6._stringLength < 1;
									obj8 = obj9;
									obj10 = obj11;
									num3 = num4;
									obj12 = obj5;
									stringSplitOptions2 = stringSplitOptions;
									array4 = array3;
									_Canon = (System.__Canon)(object)text;
									num = num2;
									if (flag6)
									{
										break;
									}
									ScreenFont screenFont;
									while (true)
									{
										bool flag7 = text == null;
										text3 = text7;
										num = num2;
										list2 = list;
										text2 = text4;
										if (flag7)
										{
											break;
										}
										bool flag8 = text._stringLength == 0;
										string text8 = (string)stringSplitOptions;
										string text9 = (string)(object)array3;
										string text10 = text6;
										if (!flag8)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
											object obj13 = 0;
											text9 = (string)obj13;
											string text11 = text + (string)obj13 + text6;
											obj5 = 0;
											text8 = text6;
											text10 = text11;
										}
										nint num5 = (nint)text5;
										screenFont = this.text;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X0_v49 (Il2CppClass<System.String>)+E4]");
										bool flag9 = (nint)0 == 0;
										object obj14 = !flag9;
										if (obj14 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										int num6 = Measure(screenFont, text10, scale);
										bool flag10 = num6 <= wide;
										obj8 = obj9;
										obj10 = obj11;
										num3 = num4;
										obj12 = obj5;
										stringSplitOptions2 = (StringSplitOptions)scale;
										array4 = (char[])text10;
										_Canon = (System.__Canon)(object)text10;
										num = (int)screenFont;
										if (flag10)
										{
											goto end_IL_01b5;
										}
										if (text._stringLength > 0)
										{
											bool flag11 = list == null;
											text3 = text7;
											num = (int)screenFont;
											list2 = list;
											text2 = text4;
											if (flag11)
											{
												break;
											}
											System.__Canon[] items = list._items;
											nint num7 = (nint)text4;
											int version = list._version + 1;
											list._version = version;
											bool flag12 = list._items == null;
											text3 = text7;
											num = (int)screenFont;
											list2 = list;
											text2 = text4;
											if (flag12)
											{
												break;
											}
											num4 = list._size;
											obj11 = items.Length;
											bool flag13 = list._size < items.Length;
											object obj15 = !flag13;
											if (obj15 == null)
											{
												object obj16 = list._items + list._size;
												int size = list._size + 1;
												list._size = size;
												object obj17 = obj16 + 32;
												obj17 = text;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												stringSplitOptions = (StringSplitOptions)scale;
												array3 = (char[])text;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X9_v30 (Il2CppClass<System.String>)+20]");
												object obj18 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v895 @ X8_v58+A8]");
												object obj19 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ X8_v59+70]");
												stringSplitOptions = (StringSplitOptions)0;
												list.AddWithResize((System.__Canon)(object)text);
												array3 = (char[])text;
											}
											bool flag14 = text6._stringLength == 0;
											obj9 = !flag14;
											bool flag15 = text6._stringLength > 0;
											num2 = (int)screenFont;
											text = text7;
											if (!flag15)
											{
												obj8 = obj9;
												obj10 = obj11;
												num3 = num4;
												obj12 = obj5;
												stringSplitOptions2 = stringSplitOptions;
												array4 = array3;
												_Canon = (System.__Canon)(object)text7;
												num = (int)screenFont;
												goto end_IL_01b5;
											}
											continue;
										}
										goto IL_05c6;
									}
									goto IL_0f1e;
									IL_05c6:
									int num8 = 1;
									ScreenFont screenFont2;
									bool flag18;
									do
									{
										bool flag16 = num8 >= text6._stringLength;
										screenFont2 = screenFont;
										text2 = text4;
										if (flag16)
										{
											break;
										}
										num8++;
										text2 = (string)(object)this.text;
										string text12 = text6.Substring(0, num8);
										nint num9 = (nint)text5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X8_v54 (Il2CppClass<System.String>)+E4]");
										bool flag17 = (nint)0 == 0;
										object obj20 = !flag17;
										if (obj20 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										int num10 = Measure((ScreenFont)(object)text2, text12, scale);
										flag18 = num10 <= wide;
										screenFont2 = (ScreenFont)(object)text12;
										screenFont = (ScreenFont)(object)text12;
										text4 = text2;
									}
									while (flag18);
									string text13 = text6.Substring(0, num8);
									bool flag19 = list == null;
									text3 = text5;
									num = (int)screenFont2;
									list2 = list;
									if (!flag19)
									{
										System.__Canon[] items2 = list._items;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
										text2 = (string)0;
										int version2 = list._version + 1;
										list._version = version2;
										bool flag20 = list._items == null;
										text3 = text5;
										num = (int)screenFont2;
										list2 = list;
										if (!flag20)
										{
											num4 = list._size;
											obj11 = items2.Length;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
											text7 = (string)0;
											bool flag21 = list._size < items2.Length;
											object obj21 = !flag21;
											if (obj21 == null)
											{
												object obj22 = list._items + list._size;
												int size2 = list._size + 1;
												list._size = size2;
												object obj23 = obj22 + 32;
												obj23 = text13;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											}
											else
											{
												list.AddWithResize((System.__Canon)(object)text13);
											}
											string text14 = text6.Substring(num8);
											bool flag22 = text14 == null;
											object obj24 = !flag22;
											obj5 = 0;
											stringSplitOptions = (StringSplitOptions)0;
											array3 = (char[])num8;
											text6 = text14;
											num2 = (int)screenFont2;
											text4 = text2;
											if (obj24 != null)
											{
												continue;
											}
											text3 = text7;
											num = (int)screenFont2;
											list2 = list;
										}
									}
									goto IL_0f1e;
									continue;
									end_IL_01b5:
									break;
								}
								obj3 = array2.Length;
								obj4++;
								bool flag23 = (nint)obj4 < array2.Length;
								obj9 = obj8;
								obj11 = obj10;
								num4 = num3;
								obj5 = obj12;
								stringSplitOptions = stringSplitOptions2;
								array3 = array4;
								text3 = text7;
								text = (string)(object)_Canon;
								if (flag23)
								{
									continue;
								}
								goto IL_091b;
							}
							goto IL_0f1e;
						}
						goto IL_0f56;
					}
					bool flag24 = text == null;
					obj12 = 0;
					stringSplitOptions2 = (StringSplitOptions)1;
					text7 = text3;
					_Canon = (System.__Canon)(object)text;
					num11 = num;
					list2 = list;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
					text2 = (string)0;
					if (!flag24)
					{
						goto IL_09c7;
					}
				}
			}
		}
		goto IL_0f1e;
		IL_091b:
		bool flag25 = _Canon == null;
		object obj25 = !flag25;
		num11 = num;
		if (obj25 != null)
		{
			goto IL_09c7;
		}
		text3 = text7;
		list2 = list;
		text2 = text4;
		goto IL_0f1e;
		IL_0f1e:
		throw new NullReferenceException();
		IL_0bb9:
		bool flag26 = list._size == 0;
		object obj26 = !flag26;
		if (obj26 == null)
		{
			System.__Canon[] items3 = list._items;
			int version3 = list._version + 1;
			list._version = version3;
			bool flag27 = list._items == null;
			text3 = text7;
			num = most;
			list2 = list;
			text2 = (string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref cut);
			if (flag27)
			{
				goto IL_0f1e;
			}
			if (items3.Length != 0)
			{
				object obj27 = list._items + 32;
				obj27 = text7;
				list._size = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			else
			{
				list.AddWithResize((System.__Canon)(object)text7);
			}
		}
		bool flag28 = list._size <= most;
		list2 = list;
		if (!flag28)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D12C0]");
			object obj28 = 0;
			reference = ref *(bool*)1;
			object obj29 = obj28;
			List<System.__Canon> range = list.GetRange(0, most);
			bool flag29 = range == null;
			text3 = text7;
			num = most;
			list2 = list;
			text2 = (string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref cut);
			if (!flag29)
			{
				num = most - 1;
				System.__Canon _Canon2 = range.get_Item(num);
				bool flag30 = _Canon2 == null;
				text3 = text7;
				list2 = range;
				text2 = (string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref cut);
				if (!flag30)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF630]");
					text3 = (string)0;
					string text15 = (string)(object)_Canon2;
					while (true)
					{
						bool flag31 = text15._stringLength < 1;
						list2 = range;
						text2 = text15;
						if (flag31)
						{
							break;
						}
						string s2 = text15 + text3;
						nint num12 = (nint)text5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v25 (Il2CppClass<System.String>)+E4]");
						bool flag32 = (nint)0 == 0;
						object obj30 = !flag32;
						if (obj30 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int num13 = Measure(this.text, s2, scale);
						bool flag33 = num13 <= wide;
						list2 = range;
						text2 = text15;
						if (flag33)
						{
							break;
						}
						int length = text15._stringLength - 1;
						string text16 = text15.Substring(0, length);
						bool flag34 = text16 == null;
						list2 = range;
						text2 = text15;
						if (!flag34)
						{
							string text17 = text16.TrimEnd();
							bool flag35 = text17 == null;
							object obj31 = !flag35;
							list2 = range;
							text2 = text17;
							obj29 = 0;
							text15 = text17;
							if (obj31 != null)
							{
								continue;
							}
						}
						goto IL_0f1e;
					}
					string value = text2 + text3;
					list2.set_Item(num, (System.__Canon)(object)value);
					goto IL_0f51;
				}
			}
			goto IL_0f1e;
		}
		goto IL_0f51;
		IL_09c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X28_v7 (System.__Canon)+10]");
		if ((nint)0 >= (nint)1)
		{
			bool flag36 = list == null;
			text3 = text7;
			num = num11;
			list2 = list;
			text2 = text4;
			if (!flag36)
			{
				System.__Canon[] items4 = list._items;
				nint num14 = (nint)text4;
				int version4 = list._version + 1;
				list._version = version4;
				bool flag37 = list._items == null;
				text3 = text7;
				num = num11;
				list2 = list;
				text2 = text4;
				if (!flag37)
				{
					bool flag38 = list._size < items4.Length;
					object obj32 = !flag38;
					if (obj32 == null)
					{
						object obj33 = list._items + list._size;
						int size3 = list._size + 1;
						list._size = size3;
						object obj34 = obj33 + 32;
						obj34 = _Canon;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X9_v15 (Il2CppClass<System.String>)+20]");
						object obj35 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v34+A8]");
						object obj36 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v35+70]");
						StringSplitOptions stringSplitOptions2 = (StringSplitOptions)0;
						list.AddWithResize(_Canon);
					}
					goto IL_0bb9;
				}
			}
		}
		else
		{
			bool flag39 = list == null;
			object obj37 = !flag39;
			if (obj37 != null)
			{
				goto IL_0bb9;
			}
			text3 = text7;
			num = num11;
			list2 = list;
			text2 = text4;
		}
		goto IL_0f1e;
		IL_0f56:
		return (List<string>)(object)new IndexOutOfRangeException();
		IL_0f51:
		return (List<string>)(object)list2;
	}

	private unsafe void Line(ScreenFont font, int x, int y, string line, ShiftAuth.Style style)
	{
		//IL_0047: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected I4, but got Unknown
		//IL_00da: Expected Obj, but got I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_002e: Expected Ref, but got VT
		//IL_024a: Expected Obj, but got I4
		//IL_01be: Expected Obj, but got I4
		//IL_0298: Expected VT, but got Ref
		if (font != null)
		{
			int num = font.DrawCentred(px, 320, 80, x, y, line, ref *(ShiftAuth.Style*)style);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = style.scale - 1;
		bool flag = (nint)obj3 < 0;
		bool flag2 = obj3 == null;
		int num2 = style.scale ^ 1;
		int num3 = style.scale ^ obj3;
		int num4 = num2 & num3;
		bool flag3 = num4 < 0;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag4 & obj4;
		object obj6 = ~obj5;
		int scale = ((obj6 != null) ? 1 : style.scale);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num5 = PixelFont.Measure(line, scale);
		Color32[] colours = style.colours;
		if (style.colours != null)
		{
			bool flag6 = num5 < 0;
			int num6 = num5 ^ num5;
			int num7 = num5 & num6;
			bool flag7 = num7 < 0;
			bool flag8 = flag6 == flag7;
			object obj8 = !flag8;
			object obj9 = ~obj8;
			int num8 = ((obj9 != null) ? num5 : (num5 + 1));
			int x2 = x - num8;
			PixelFont.Draw(px, 320, 80, x2, y, line, (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref colours[0]), scale);
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	public GillaHud()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D12C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Queue<System.__Canon> queue = default;
		queue._002Ector();
		object obj2 = this + 56;
		obj2 = queue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaHud()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I
		//IL_0315: Expected Obj, but got I
		//IL_03ac: Expected Obj, but got I
		//IL_03bc: Expected Obj, but got I
		//IL_03d2: Expected Obj, but got I
		//IL_040e: Expected Obj, but got I
		//IL_0438: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+18]");
			bool flag = (nint)0 == 1;
			_ = 4289392895L;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
				object obj2 = 0;
				_ = 4281510630L;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v8+A0]");
				object obj4 = (nint)0 + (nint)8;
				object obj5 = default;
				obj4 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v12+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v12+18]");
					bool flag2 = (nint)0 == 1;
					_ = 4285464460L;
					if (!flag2)
					{
						_ = 4280866600L;
						object obj6 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v12+A0]");
						object obj7 = (nint)0 + (nint)16;
						object obj8 = default;
						obj7 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v17+18]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v17+18]");
							bool flag3 = (nint)0 == 1;
							_ = 4294967295L;
							if (!flag3)
							{
								_ = 4293321195L;
								object obj9 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v16+A0]");
								object obj10 = (nint)0 + (nint)24;
								object obj11 = default;
								obj10 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v22+18]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v22+18]");
									bool flag4 = (nint)0 == 1;
									_ = 4285432575L;
									if (!flag4)
									{
										_ = 4280824555L;
										object obj12 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v20+A0]");
										object obj13 = (nint)0 + (nint)32;
										object obj14 = default;
										obj13 = obj14;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v27+18]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v27+18]");
											bool flag5 = (nint)0 == 1;
											_ = 4294955670L;
											if (!flag5)
											{
												_ = 4294935090L;
												object obj15 = obj2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v23+A0]");
												object obj16 = (nint)0 + (nint)40;
												object obj17 = default;
												obj16 = obj17;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v32+18]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v32+18]");
													bool flag6 = (nint)0 == 1;
													_ = 4291675848L;
													if (!flag6)
													{
														_ = 4289044128L;
														object obj18 = obj2;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
														object obj19 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB58]");
														object obj20 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v27+A0]");
														object obj21 = (nint)0 + (nint)48;
														object obj22 = default;
														obj21 = obj22;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														int num = Shader.PropertyToID((string)obj19);
														object obj23 = obj2;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v28+A0]");
														object obj24 = 0;
														int num2 = Shader.PropertyToID((string)obj20);
														object obj25 = obj2;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v30+A0]");
														object obj26 = 0;
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
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
