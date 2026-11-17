using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class GillaItemDirector : MonoBehaviour
{
	private sealed class _003CWaitForVerdict_003Ed__41 : _0021_00210, _00210, _0021_00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CWaitForVerdict_003Ed__41(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0128: Expected Obj, but got I
			//IL_009e: Expected I4, but got I8
			//IL_0171: Expected Obj, but got I4
			//IL_0021: Expected Obj, but got I4
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected Obj, but got Unknown
			//IL_00fa: Expected Obj, but got I4
			//IL_0046: Expected I4, but got I8
			//IL_0068: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
			object obj = 0;
			if (_003C_003E1__state != 1)
			{
				bool flag = _003C_003E1__state == 0;
				object obj2 = !flag;
				if (obj2 != null)
				{
					goto IL_00d8;
				}
				object obj3 = obj;
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v14+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaIntegrity.Begin();
			}
			else
			{
				_003C_003E1__state = -1;
			}
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (GillaIntegrity.Done)
			{
				goto IL_00d8;
			}
			object obj7 = this + 24;
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			_ = 1;
			return true;
			IL_00d8:
			return false;
		}

		private void System_002ECollections_002EIEnumerator_002EReset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	[Serializable]
	public class Kind
	{
		public GameObject prefab;

		public float chance = 1f;

		public Vector3 lie;

		public float lift;
	}

	[Serializable]
	public class Spot
	{
		public Kind kind;

		public Vector3 at;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Kind, bool> _003C_003E9__34_0;

		public static Func<Kind, GillaItem> _003C_003E9__34_1;

		public static Func<GillaItem, string> _003C_003E9__34_2;

		public static Func<IGrouping<string, GillaItem>, (string, int)> _003C_003E9__34_3;

		public static Func<(string, int), int> _003C_003E9__34_4;

		public static Func<(string, int), string> _003C_003E9__34_5;

		public static Predicate<GameObject> _003C_003E9__37_0;

		public static Func<Kind, bool> _003C_003E9__46_0;

		public static Func<Kind, float> _003C_003E9__46_1;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1550]");
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

		internal bool _003CPrices_003Eb__34_0(Kind k)
		{
			//IL_0136: Expected I4, but got Obj
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			//IL_00be: Expected Obj, but got I
			//IL_00f2: Expected Obj, but got I4
			if (k != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(k.prefab != null))
				{
					return false;
				}
				if ((object)k.prefab != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD00]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
					object obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v7+E4]");
					bool flag2 = (nint)0 == 0;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object obj7 = default;
					return obj7 != null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal GillaItem _003CPrices_003Eb__34_1(Kind k)
		{
			//IL_0037: Expected Obj, but got I
			if (k != null && (object)k.prefab != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD00]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
				GillaItem result = default;
				return result;
			}
			return (GillaItem)(object)new NullReferenceException();
		}

		internal string _003CPrices_003Eb__34_2(GillaItem i)
		{
			if ((object)i != null)
			{
				return i.label;
			}
			return (string)(object)new NullReferenceException();
		}

		internal (string, int) _003CPrices_003Eb__34_3(IGrouping<string, GillaItem> g)
		{
			//IL_0107: Expected VT, but got Obj
			//IL_000d: Expected I, but got Obj
			//IL_001d: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0069: Expected Obj, but got I
			//IL_00f9: Expected VT, but got I4
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected Obj, but got Unknown
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected Obj, but got Unknown
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Expected Obj, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected Obj, but got Unknown
			if (g == null)
			{
				goto IL_00f9;
			}
			nint num = (nint)g;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C66E0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4 (Il2CppClass<System.Linq.IGrouping`2<System.String, GillaItem>>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4 (Il2CppClass<System.Linq.IGrouping`2<System.String, GillaItem>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00aa;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4 (Il2CppClass<System.Linq.IGrouping`2<System.String, GillaItem>>)+98]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X10_v8-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj2--;
				obj3 += 16;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00aa;
			}
			object obj4 = num + obj3;
			object obj5 = obj4 + 312;
			goto IL_0148;
			IL_0148:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v187 @ X0_v4] (should have been resolved before IL gen)");
			System.__Canon _Canon = Enumerable.First((IEnumerable<System.__Canon>)g);
			if (_Canon != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v8 (System.__Canon)+28]");
				System.__Canon item = default;
				(System.__Canon, int) tuple = (item, 0);
				return ((string, int))0;
			}
			goto IL_00f9;
			IL_00f9:
			NullReferenceException ex = new NullReferenceException();
			return ((string, int))ex;
			IL_00aa:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0148;
		}

		internal int _003CPrices_003Eb__34_4((string, int) p)
		{
			IntPtr intPtr = default;
			return (int)(nint)intPtr;
		}

		internal string _003CPrices_003Eb__34_5((string, int) p)
		{
			//IL_0005: Expected Obj, but got VT
			return p;
		}

		internal bool _003CUpdate_003Eb__37_0(GameObject go)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0061: Expected Obj, but got I4
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
			return go == null;
		}

		internal bool _003CPick_003Eb__46_0(Kind k)
		{
			//IL_013b: Expected I4, but got Obj
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			//IL_009a: Invalid comparison between F4 and I4
			//IL_00ae: Invalid comparison between F4 and I4
			//IL_00cb: Expected Obj, but got F4
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected Obj, but got Unknown
			//IL_0105: Expected Obj, but got I4
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Expected I4, but got Unknown
			if (k != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (k.prefab != null)
				{
					bool flag2 = k.chance < 0f;
					bool flag3 = k.chance == 0f;
					object obj4 = k.chance ^ k.chance;
					object obj5 = k.chance & obj4;
					bool flag4 = (nint)obj5 < 0;
					bool flag5 = flag2 == flag4;
					object obj6 = !flag3;
					return (byte)((flag5 & obj6) ? 1 : 0) != 0;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal float _003CPick_003Eb__46_1(Kind k)
		{
			return k.chance;
		}
	}

	public Kind[] kinds;

	public Vector3[] places;

	public int most;

	public int first;

	public Vector2 every;

	public float lasts;

	public Kind keycard;

	public Vector3 keycardAt;

	public Spot[] spots;

	public float spotRefill;

	private static GillaItemDirector Instance__BackingField;

	private const float Apart = default(float);

	private const float Unseen = default(float);

	private const float KeycardEvery = default(float);

	private const float SpotHolds = default(float);

	public const float Settle = default(float);

	private readonly List<GameObject> local;

	private float offlineFor;

	private float nextAt;

	private float nextKeycard;

	private float nextCard;

	private float joinedAt;

	private float[] spotGone;

	private NetworkRunner joined;

	private GillaItem card;

	public static GillaItemDirector Instance
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
			return (GillaItemDirector)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+A0]");
			object obj3 = 0;
			obj3 = value;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public GillaItem YourCard => card;

	private void Awake()
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X9_v1+A0]");
		object obj3 = 0;
		obj3 = this;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void OnDestroy()
	{
		//IL_0055: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53B0]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj5 == this)
		{
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v9+A0]");
			object obj8 = 0;
			obj8 = 0;
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public (string, int)[] Prices()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0452: Expected Obj, but got I4
		//IL_095d: Expected Obj, but got I
		//IL_096d: Expected Obj, but got I
		//IL_097d: Expected Obj, but got I
		//IL_099f: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I4
		//IL_04f1: Expected Obj, but got I
		//IL_0501: Expected Obj, but got I
		//IL_0511: Expected Obj, but got I
		//IL_0533: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0177: Expected Obj, but got I4
		//IL_0470: Expected Obj, but got I
		//IL_048a: Expected Obj, but got I
		//IL_049b: Expected I, but got Obj
		//IL_04b9: Expected Obj, but got I
		//IL_04d4: Expected Obj, but got I4
		//IL_05d2: Expected Obj, but got I
		//IL_05e2: Expected Obj, but got I
		//IL_05f2: Expected Obj, but got I
		//IL_0614: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I4
		//IL_0551: Expected Obj, but got I
		//IL_056b: Expected Obj, but got I
		//IL_057c: Expected I, but got Obj
		//IL_059a: Expected Obj, but got I
		//IL_05b5: Expected Obj, but got I4
		//IL_06b3: Expected Obj, but got I
		//IL_06c3: Expected Obj, but got I
		//IL_06d3: Expected Obj, but got I
		//IL_06f5: Expected Obj, but got I4
		//IL_01be: Expected Obj, but got I4
		//IL_0137: Expected Obj, but got I
		//IL_02de: Expected Obj, but got I4
		//IL_0632: Expected Obj, but got I
		//IL_064c: Expected Obj, but got I
		//IL_065d: Expected I, but got Obj
		//IL_067b: Expected Obj, but got I
		//IL_0696: Expected Obj, but got I4
		//IL_0794: Expected Obj, but got I
		//IL_07a4: Expected Obj, but got I
		//IL_07b4: Expected Obj, but got I
		//IL_07d6: Expected Obj, but got I4
		//IL_026e: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got I
		//IL_038e: Expected Obj, but got I4
		//IL_0713: Expected Obj, but got I
		//IL_072d: Expected Obj, but got I
		//IL_073e: Expected I, but got Obj
		//IL_075c: Expected Obj, but got I
		//IL_0777: Expected Obj, but got I4
		//IL_0875: Expected Obj, but got I
		//IL_0885: Expected Obj, but got I
		//IL_0895: Expected Obj, but got I
		//IL_08a5: Expected Obj, but got I
		//IL_08c7: Expected Obj, but got I4
		//IL_0325: Expected Obj, but got I4
		//IL_029e: Expected Obj, but got I
		//IL_07f4: Expected Obj, but got I
		//IL_080e: Expected Obj, but got I
		//IL_081f: Expected I, but got Obj
		//IL_083d: Expected Obj, but got I
		//IL_0858: Expected Obj, but got I4
		//IL_03d5: Expected Obj, but got I4
		//IL_0355: Expected Obj, but got I
		//IL_08e5: Expected Obj, but got I
		//IL_08ff: Expected Obj, but got I
		//IL_0910: Expected I, but got Obj
		//IL_092e: Expected Obj, but got I
		//IL_0405: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1550]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v61+8]");
		Func<System.__Canon, bool> predicate = (Func<System.__Canon, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1560]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v61+8]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v65+A0]");
				obj4 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1570]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1578]");
			object obj10 = 0;
			Func<System.__Canon, bool> func = default;
			func._002Ector(obj4, (IntPtr)obj10);
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v64+A0]");
			object obj12 = (nint)0 + (nint)8;
			obj12 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj13 = 0;
			predicate = func;
		}
		IEnumerable<System.__Canon> source = Enumerable.Where((IEnumerable<System.__Canon>)(object)kinds, predicate);
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v7+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X9_v25+10]");
		Func<System.__Canon, System.__Canon> selector = (Func<System.__Canon, System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1558]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X9_v25+10]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v7+E4]");
			bool flag6 = (nint)0 == 0;
			object obj19 = !flag6;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj20 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v59+A0]");
				obj16 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1568]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1580]");
			object obj22 = 0;
			Func<System.__Canon, System.__Canon> func2 = default;
			func2._002Ector(obj16, (IntPtr)obj22);
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v58+A0]");
			object obj24 = (nint)0 + (nint)16;
			obj24 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj13 = 0;
			selector = func2;
		}
		IEnumerable<System.__Canon> enumerable = Enumerable.Select(source, selector);
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v10+E4]");
		bool flag7 = (nint)0 == 0;
		object obj26 = !flag7;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v10+A0]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X9_v23+18]");
		Func<System.__Canon, System.__Canon> func3 = (Func<System.__Canon, System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62B8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X9_v23+18]");
		bool flag8 = (nint)0 == 0;
		object obj29 = !flag8;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v10+E4]");
			bool flag9 = (nint)0 == 0;
			object obj30 = !flag9;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj31 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v51+A0]");
				obj27 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6328]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1588]");
			object obj33 = 0;
			Func<System.__Canon, System.__Canon> func4 = default;
			func4._002Ector(obj27, (IntPtr)obj33);
			object obj34 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v50+A0]");
			object obj35 = (nint)0 + (nint)24;
			obj35 = func4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj13 = 0;
			func3 = func4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35CC3C0");
		object obj36 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v13+E4]");
		bool flag10 = (nint)0 == 0;
		object obj37 = !flag10;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj36 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v13+A0]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X9_v21+20]");
		Func<System.__Canon, (System.__Canon, int)> selector2 = (Func<System.__Canon, (System.__Canon, int)>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62C8]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X9_v21+20]");
		bool flag11 = (nint)0 == 0;
		object obj40 = !flag11;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v13+E4]");
			bool flag12 = (nint)0 == 0;
			object obj41 = !flag12;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj42 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v43+A0]");
				obj38 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6310]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1590]");
			object obj44 = 0;
			Func<System.__Canon, (System.__Canon, int)> func5 = default;
			func5._002Ector(obj38, (IntPtr)obj44);
			object obj45 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v42+A0]");
			object obj46 = (nint)0 + (nint)32;
			obj46 = func5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj13 = 0;
			selector2 = func5;
		}
		IEnumerable<System.__Canon> source2 = default;
		IEnumerable<(System.__Canon, int)> enumerable2 = Enumerable.Select(source2, selector2);
		object obj47 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v16+E4]");
		bool flag13 = (nint)0 == 0;
		object obj48 = !flag13;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj47 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v16+A0]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X9_v19+28]");
		Func<(System.__Canon, int), int> func6 = (Func<(System.__Canon, int), int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62C0]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X9_v19+28]");
		bool flag14 = (nint)0 == 0;
		object obj51 = !flag14;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v16+E4]");
			bool flag15 = (nint)0 == 0;
			object obj52 = !flag15;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj53 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v35+A0]");
				obj49 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6300]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1598]");
			object obj55 = 0;
			Func<(System.__Canon, int), int> func7 = default;
			func7._002Ector(obj49, (IntPtr)obj55);
			object obj56 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v34+A0]");
			object obj57 = (nint)0 + (nint)40;
			obj57 = func7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj13 = 0;
			func6 = func7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35CFB94");
		object obj58 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v19+E4]");
		bool flag16 = (nint)0 == 0;
		object obj59 = !flag16;
		if (obj59 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj58 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v19+A0]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62E0]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X9_v17+30]");
		Func<(System.__Canon, int), System.__Canon> func8 = (Func<(System.__Canon, int), System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62F0]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X9_v17+30]");
		bool flag17 = (nint)0 == 0;
		object obj63 = !flag17;
		if (obj63 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v19+E4]");
			bool flag18 = (nint)0 == 0;
			object obj64 = !flag18;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj65 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v27+A0]");
				obj60 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6308]");
			object obj66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D15A0]");
			object obj67 = 0;
			Func<(System.__Canon, int), System.__Canon> func9 = default;
			func9._002Ector(obj60, (IntPtr)obj67);
			object obj68 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v26+A0]");
			object obj69 = (nint)0 + (nint)48;
			obj69 = func9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			func8 = func9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35E1664");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35E1D90");
		(string, int)[] result = default;
		return result;
	}

	public static bool AnyoneNear(Vector3 p, float within = default(float))
	{
		//IL_0025: Invalid comparison between F4 and I4
		float num = Nearest(p);
		object obj = default;
		float num2 = num - (float)obj;
		return num2 < 0f;
	}

	private unsafe static float Nearest(Vector3 p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_079f: Expected Obj, but got I4
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_0917: Unknown result type (might be due to invalid IL or missing references)
		//IL_091b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0927: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got I
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got I4
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Obj, but got I4
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected Ref, but got Unknown
		//IL_089d: Expected Obj, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got I4
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected F4, but got Unknown
		//IL_013e: Expected Obj, but got I4
		//IL_036d: Expected Obj, but got I4
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected F4, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected Obj, but got I
		//IL_03d6: Expected Obj, but got I4
		//IL_0651: Expected Obj, but got I4
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected Obj, but got I4
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected F4, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got I4
		//IL_01d2: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I4
		//IL_06fc: Expected Obj, but got I4
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected Obj, but got I
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected Obj, but got I4
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got I4
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got I4
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected F4, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got I4
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected Obj, but got VT
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected F4, but got Unknown
		//IL_0269: Expected Obj, but got I
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected Obj, but got I4
		//IL_0509: Expected Obj, but got I
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected Obj, but got I4
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Invalid comparison between VT and I4
		//IL_0559: Expected Obj, but got I4
		//IL_0828: Expected Obj, but got I4
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected Obj, but got VT
		//IL_0864: Expected Obj, but got I4
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected Obj, but got Unknown
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Invalid comparison between Unknown and F4
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected F4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+A0]");
		Enumerator<, > val = (Enumerator<, >)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v20 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+8]");
		bool flag2 = (nint)0 == 0;
		object obj5 = default;
		object obj4 = obj5;
		object obj7 = default;
		object obj6 = obj7;
		UnityEngine.Object obj9 = default;
		UnityEngine.Object obj8 = obj9;
		Enumerator<, > val2 = (Enumerator<, >)0;
		Enumerator<, > val4 = default;
		Enumerator<, > val3 = val4;
		IntPtr intPtr = default;
		UnityEngine.Object obj10 = (UnityEngine.Object)(nint)intPtr;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v20 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+8]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			obj = 0;
			obj4 = obj5;
			obj6 = obj7;
			Enumerator<, > val5 = (Enumerator<, >)2139095039;
			Enumerator<, > val6 = default;
			val3 = val6;
			val = (Enumerator<, >)2139095039;
			object obj29 = default;
			while (true)
			{
				float num;
				object obj20;
				Enumerator<, > val7;
				if (val2.MoveNext())
				{
					object obj15 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v51+E4]");
					val = (Enumerator<, >)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v51+E4]");
					bool flag3 = (nint)0 == 0;
					object obj16 = !flag3;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = obj9 != null;
					bool flag5 = !flag4;
					object obj17 = 0;
					if (flag5)
					{
						continue;
					}
					if ((object)obj9 != null)
					{
						object obj18 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v56+E4]");
						val = (Enumerator<, >)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v56+E4]");
						bool flag6 = (nint)0 == 0;
						object obj19 = !flag6;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ stack_-B8 (UnityEngine.Object)+68]");
						bool flag7 = (UnityEngine.Object)0 != null;
						bool flag8 = !flag7;
						obj17 = 0;
						if (flag8)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ stack_-B8 (UnityEngine.Object)+68]");
						bool flag9 = (nint)0 == 0;
						obj17 = 0;
						obj8 = null;
						val2 = val6;
						obj20 = 0;
						num = (float)val3;
						val7 = (Enumerator<, >)(ref val2);
						obj10 = null;
						if (!flag9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ stack_-B8 (UnityEngine.Object)+68]");
							Vector3 position = ((Transform)0).position;
							object obj21 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v63+E4]");
							val = (Enumerator<, >)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v63+E4]");
							bool flag10 = (nint)0 == 0;
							object obj22 = !flag10;
							if (obj22 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj23 = val4 - val3;
							object obj24 = obj7 - obj6;
							obj4 = obj5 - obj4;
							object obj25 = obj23 * obj23;
							object obj26 = obj24 * obj24;
							object obj27 = obj25 + obj26;
							obj6 = obj4 * obj4;
							Enumerator<, > val8 = (Enumerator<, >)(obj6 + obj27);
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							if (val5 >= val8)
							{
								val5 = val8;
							}
							obj17 = 0;
							val3 = val8;
							continue;
						}
						goto IL_06ac;
					}
					NullReferenceException ex = new NullReferenceException();
					obj17 = 0;
					obj8 = null;
					val2 = val6;
					obj20 = 0;
					val7 = (Enumerator<, >)(ref val2);
					obj10 = null;
					break;
				}
				obj8 = null;
				val2 = val6;
				obj20 = 0;
				val7 = (Enumerator<, >)(ref val2);
				object obj28 = 0;
				goto IL_0872;
				IL_06ac:
				NullReferenceException ex2 = new NullReferenceException();
				if ((nint)obj10 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj8 = (UnityEngine.Object)1;
					val3 = (Enumerator<, >)num;
					val = (Enumerator<, >)1;
					obj28 = obj20;
				}
				else
				{
					if ((nint)obj10 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return num;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj28 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj20 = obj29;
					val3 = (Enumerator<, >)num;
				}
				goto IL_0872;
				IL_0872:
				obj10 = (UnityEngine.Object)obj13;
				((Enumerator<, >*)val7)->Dispose();
				bool flag11 = obj28 == null;
				object obj30 = !flag11;
				if (obj30 == null)
				{
					bool flag12 = (object)obj8 == null;
					object obj31 = !flag12;
					num = (float)val3;
					OutOfMemoryException ex3 = (OutOfMemoryException)val7;
					val = (Enumerator<, >)obj8;
					if (obj31 == null)
					{
						object obj32 = obj14;
						object obj33 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v7+A0]");
						object obj34 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v7+E4]");
						bool flag13 = (nint)0 == 0;
						object obj35 = !flag13;
						if (obj35 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag14 = (UnityEngine.Object)obj34 != null;
						bool flag15 = !flag14;
						float result = (float)val5;
						if (!flag15)
						{
							object obj36 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v10+A0]");
							object obj37 = 0;
							val = (Enumerator<, >)obj37;
							bool flag16 = obj37 == null;
							object obj17 = 0;
							obj10 = null;
							if (flag16)
							{
								break;
							}
							object obj38 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v12+E4]");
							bool flag17 = (nint)0 == 0;
							object obj39 = !flag17;
							if (obj39 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag18 = (UnityEngine.Object)val._current != null;
							bool flag19 = !flag18;
							result = (float)val5;
							if (!flag19)
							{
								object obj40 = obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v13+A0]");
								object obj41 = 0;
								val = (Enumerator<, >)obj41;
								bool flag20 = obj41 == null;
								obj17 = 0;
								obj10 = null;
								if (flag20)
								{
									break;
								}
								bool flag21 = val._current == (_00210)(object)0;
								obj17 = 0;
								obj10 = null;
								if (flag21)
								{
									break;
								}
								Vector3 position2 = ((Transform)val._current).position;
								object obj42 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X0_v19+E4]");
								bool flag22 = (nint)0 == 0;
								object obj43 = !flag22;
								if (obj43 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj44 = val4 - val3;
								object obj45 = obj7 - obj6;
								object obj46 = obj5 - obj4;
								object obj47 = obj44 * obj44;
								object obj48 = obj45 * obj45;
								object obj49 = obj47 + obj48;
								object obj50 = obj46 * obj46;
								float num2 = (float)obj50 + (float)obj49;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								result = ((!((float)val5 < num2)) ? num2 : ((float)val5));
							}
						}
						return result;
					}
				}
				else
				{
					OutOfMemoryException ex3 = new OutOfMemoryException();
					num = (float)val3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				goto IL_06ac;
			}
		}
		throw new NullReferenceException();
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_060e: Expected Obj, but got I4
		//IL_077c: Expected Obj, but got I
		//IL_078c: Expected Obj, but got I
		//IL_07ae: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_06ac: Expected Obj, but got I
		//IL_06ce: Expected Obj, but got I4
		//IL_062c: Expected Obj, but got I
		//IL_0646: Expected Obj, but got I
		//IL_0657: Expected I, but got Obj
		//IL_0675: Expected Obj, but got I
		//IL_07d4: Expected Obj, but got I
		//IL_07e4: Expected Obj, but got I
		//IL_0806: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I
		//IL_0706: Expected Obj, but got I4
		//IL_0170: Expected Obj, but got I
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_023a: Expected Obj, but got I4
		//IL_026e: Expected Obj, but got I4
		//IL_029d: Expected Obj, but got I
		//IL_0348: Expected Obj, but got I4
		//IL_0377: Expected Obj, but got I
		//IL_0395: Expected Obj, but got I4
		//IL_03c7: Expected F8, but got I4
		//IL_02f5: Expected F4, but got I
		//IL_0451: Expected Obj, but got I4
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_0494: Expected Obj, but got I4
		//IL_0414: Expected VT, but got I4
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected Obj, but got Unknown
		//IL_0516: Expected Obj, but got I4
		//IL_05cd: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1550]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v32+38]");
		Predicate<System.__Canon> match = (Predicate<System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v32+38]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v36+A0]");
				obj4 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D15B0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D15B8]");
			object obj9 = 0;
			Predicate<System.__Canon> predicate = default;
			predicate._002Ector(obj4, (IntPtr)obj9);
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v35+A0]");
			object obj11 = (nint)0 + (nint)56;
			obj11 = predicate;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			match = predicate;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D15A8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj13 = 0;
		int num = ((List<System.__Canon>)(object)local).RemoveAll(match);
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj16 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj13;
		}
		object obj19 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v13+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X9_v3+8]");
		UnityEngine.Object obj21 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj22 = !flag6;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X9_v3+8]");
		bool flag7 = (UnityEngine.Object)0 != null;
		bool flag8 = !flag7;
		UnityEngine.Object obj23 = null;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X21_v4 (UnityEngine.Object)+B0]");
			obj23 = (UnityEngine.Object)0;
		}
		object obj24 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v17+E4]");
		bool flag9 = (nint)0 == 0;
		object obj25 = !flag9;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetworkRunner runner;
		if (obj23 != null && ((NetworkRunner)obj23).IsRunning)
		{
			offlineFor = 0f;
			ClearLocal();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X21_v4 (UnityEngine.Object)+90]");
			if ((nint)0 != 0)
			{
				nextAt = -1f;
				ThrowAwayCard();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X21_v4 (UnityEngine.Object)+A4]");
			bool flag10 = (nint)0 == 0;
			object obj26 = !flag10;
			if (obj26 == null)
			{
				object obj27 = obj17;
				object obj28 = this + 152;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v51+E4]");
				bool flag11 = (nint)0 == 0;
				object obj29 = !flag11;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (obj23 != (UnityEngine.Object)obj28)
				{
					joined = (NetworkRunner)obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					float time = Time.time;
					object obj30 = this + 144;
					obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					_ = 3212836864L;
				}
				MakeCard();
				if (((NetworkRunner)obj23).IsSharedModeMasterClient)
				{
					float time2 = Time.time;
					float num2 = time2 - joinedAt;
					if (!((double)num2 < 5.0))
					{
						if (Due(online: true))
						{
							Kind kind = Pick();
							GillaItem gillaItem = Make((NetworkRunner)obj23, kind, (Vector3?)(object)0);
						}
						runner = (NetworkRunner)obj23;
						goto IL_0761;
					}
				}
			}
			nextAt = -1f;
			return;
		}
		object obj31 = this + 152;
		obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj32 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v27+E4]");
		bool flag12 = (nint)0 == 0;
		object obj33 = !flag12;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X9_v3+8]");
		if ((UnityEngine.Object)0 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X21_v4 (UnityEngine.Object)+A4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B338]");
				offlineFor = 0f;
				return;
			}
		}
		float deltaTime = Time.deltaTime;
		object obj34 = obj17;
		float num3 = (offlineFor += deltaTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v32+E4]");
		bool flag13 = (nint)0 == 0;
		object obj35 = !flag13;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X9_v3+8]");
		bool flag14 = (UnityEngine.Object)0 != null;
		bool flag15 = !flag14;
		object obj36 = !flag15;
		object obj37 = ~obj36;
		double num4 = ((obj37 != null) ? 0.0 : 2.0);
		if (!((double)num3 < num4))
		{
			if (Due(online: false))
			{
				Kind kind2 = Pick();
				GillaItem gillaItem2 = Make(null, kind2, (Vector3?)(object)0);
			}
			MakeCard();
			runner = null;
			goto IL_0761;
		}
		return;
		IL_0761:
		Spots(runner);
	}

	private void MakeCard()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_027b: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I
		//IL_0170: Expected VT, but got Obj
		//IL_0187: Expected VT, but got I4
		//IL_01ce: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 != null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			return;
		}
		float time = Time.time;
		if (time < nextCard)
		{
			return;
		}
		Kind kind = keycard;
		if (keycard == null)
		{
			return;
		}
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = kind.prefab == null;
		bool flag6 = !flag5;
		object obj8 = !flag6;
		if (obj8 == null)
		{
			float time2 = Time.time;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
			object obj9 = 0;
			float num = time2 + 2f;
			nextCard = num;
			Vector3? vector = (Vector3)obj9;
			GillaItem gillaItem = Make(null, keycard, (Vector3?)(object)0);
			card = gillaItem;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v18+E4]");
			bool flag7 = (nint)0 == 0;
			object obj11 = !flag7;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (card != null)
			{
				GameObject item = card.gameObject;
				bool flag8 = ((List<System.__Canon>)(object)local).Remove((System.__Canon)(object)item);
			}
		}
	}

	private void ThrowAwayCard()
	{
		//IL_0010: Expected Obj, but got I
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0165: Expected Obj, but got I4
		//IL_0074: Expected I4, but got I8
		//IL_008e: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!((UnityEngine.Object)obj3 == null))
		{
			GillaItem gillaItem = (GillaItem)obj3;
			int num = (int)(gillaItem.Hand__BackingField & 0x80000000L);
			bool flag2 = num == 0;
			object obj5 = !flag2;
			Component component = gillaItem;
			if (obj5 == null)
			{
				GillaHands.Drop(gillaItem);
				component = (Component)obj3;
			}
			GameObject obj6 = component.gameObject;
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(obj6);
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private unsafe void Spots(NetworkRunner runner)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0bc3: Expected Obj, but got I
		//IL_0bed: Expected Obj, but got I4
		//IL_0c5d: Expected Obj, but got I
		//IL_0c87: Expected Obj, but got I4
		//IL_1033: Expected Obj, but got I
		//IL_1043: Expected Obj, but got I
		//IL_105d: Expected Obj, but got I
		//IL_106b: Expected I, but got Obj
		//IL_1083: Expected VT, but got I4
		//IL_108b: Expected I, but got Obj
		//IL_0c3a: Expected I, but got Obj
		//IL_0cbc: Expected Obj, but got I
		//IL_0cc4: Expected I, but got Obj
		//IL_0cde: Expected VT, but got I4
		//IL_00d7: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got I4
		//IL_0d03: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I4
		//IL_0d6b: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I4
		//IL_0eec: Expected Obj, but got I
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected I, but got Obj
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected F4, but got Unknown
		//IL_0ddf: Expected Obj, but got I4
		//IL_0fcf: Expected Obj, but got I
		//IL_0fe8: Expected VT, but got Ref
		//IL_0e18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1d: Expected Obj, but got Unknown
		//IL_0e48: Expected Obj, but got I4
		//IL_0695: Expected VT, but got Ref
		//IL_0235: Expected Obj, but got I4
		//IL_0265: Expected Obj, but got I4
		//IL_06b3: Expected VT, but got Ref
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_0345: Invalid comparison between F4 and I
		//IL_0386: Expected Obj, but got I4
		//IL_03ad: Expected Obj, but got I
		//IL_03cb: Expected Obj, but got I4
		//IL_03d0: Expected I, but got Obj
		//IL_0408: Expected Obj, but got I4
		//IL_046a: Expected Obj, but got I8
		//IL_049f: Expected Obj, but got I
		//IL_04c1: Expected Obj, but got I4
		//IL_06d6: Expected VT, but got Ref
		//IL_053f: Expected Obj, but got I
		//IL_06f9: Expected VT, but got Ref
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_0632: Invalid comparison between F4 and I
		//IL_071c: Expected VT, but got Ref
		//IL_067f: Expected Obj, but got I
		float time = Time.time;
		if (time < nextKeycard)
		{
			return;
		}
		float time2 = Time.time;
		object obj = this + 144;
		object obj2 = obj;
		float num = time2 + 2f;
		Spot[] array;
		double num2;
		NetworkRunner networkRunner;
		if (obj != null)
		{
			array = spots;
			bool flag = spots == null;
			networkRunner = runner;
			num2 = 2.0;
			if (flag)
			{
				goto IL_0e73;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X9_v1+18]");
			bool flag2 = (nint)0 != array.Length;
			networkRunner = runner;
			if (!flag2)
			{
				goto IL_00c7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v19+E4]");
		bool flag3 = (nint)0 == 0;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4;
		if ((UnityEngine.Object)runner == (UnityEngine.Object)null)
		{
			nint num3 = unchecked((nint)null);
			networkRunner = null;
			flag4 = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v32+E4]");
			bool flag5 = (nint)0 == 0;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v32+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5338]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1630]");
			object obj11 = 0;
			Predicate<System.__Canon> predicate = default;
			predicate._002Ector((object)this, (IntPtr)obj11);
			bool flag6 = obj9 == null;
			Vector3? vector = (Vector3?)(object)0;
			nint num3 = (nint)obj11;
			networkRunner = (NetworkRunner)(object)this;
			num2 = 2.0;
			if (flag6)
			{
				goto IL_0e73;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1638]");
			object obj12 = 0;
			num3 = (nint)obj12;
			bool flag7 = ((List<System.__Canon>)obj9).Exists(predicate);
			vector = (Vector3?)(object)0;
			networkRunner = (NetworkRunner)(object)predicate;
			flag4 = flag7;
		}
		Spot[] array2 = spots;
		bool flag8 = spots == null;
		num2 = 2.0;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			NetworkRunner networkRunner2 = default;
			spotGone = (float[])(object)networkRunner2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag9 = spots == null;
			networkRunner = networkRunner2;
			num2 = 2.0;
			if (!flag9)
			{
				float num4 = num;
				object obj14 = 0;
				array = spots;
				while (true)
				{
					bool flag10 = (nint)obj14 >= array.Length;
					networkRunner = networkRunner2;
					num = num4;
					if (flag10)
					{
						break;
					}
					UnityEngine.Object obj15 = (UnityEngine.Object)obj;
					num = ((!flag4) ? (0f - spotRefill) : Time.time);
					bool flag11 = (object)obj15 == null;
					networkRunner = networkRunner2;
					num2 = 2.0;
					if (!flag11)
					{
						object obj16 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X24_v10 (UnityEngine.Object)+18]");
						bool flag12 = (nint)obj16 < 0;
						object obj17 = !flag12;
						networkRunner = networkRunner2;
						num2 = 2.0;
						if (obj17 != null)
						{
							goto IL_0e81;
						}
						object obj18 = (object)obj15 + obj14;
						obj14++;
						array = spots;
						bool flag13 = spots == null;
						object obj19 = !flag13;
						networkRunner = networkRunner2;
						num2 = 2.0;
						num4 = num;
						if (obj19 != null)
						{
							continue;
						}
					}
					goto IL_0e73;
				}
				goto IL_00c7;
			}
		}
		goto IL_0e73;
		IL_06e8:
		NullReferenceException ex = new NullReferenceException();
		Enumerator<, > val;
		Vector3? vector2 = (Vector3?)(object)(&val);
		networkRunner = null;
		OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
		goto IL_0f9c;
		IL_0e9e:
		ex2 = new OutOfMemoryException();
		goto IL_0f9c;
		IL_0e81:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0e9e;
		IL_070b:
		NullReferenceException ex4 = new NullReferenceException();
		vector2 = (Vector3?)(object)(&val);
		networkRunner = null;
		ex2 = (OutOfMemoryException)(object)ex4;
		goto IL_0f9c;
		IL_06a2:
		NullReferenceException ex5 = new NullReferenceException();
		vector2 = (Vector3?)(object)(&val);
		networkRunner = null;
		ex2 = (OutOfMemoryException)(object)ex5;
		goto IL_0f9c;
		IL_0e73:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_0e81;
		IL_0f9c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D3D4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_06c5:
		NullReferenceException ex7 = new NullReferenceException();
		vector2 = (Vector3?)(object)(&val);
		networkRunner = null;
		ex2 = (OutOfMemoryException)(object)ex7;
		goto IL_0f9c;
		IL_0684:
		NullReferenceException ex8 = new NullReferenceException();
		vector2 = (Vector3?)(object)(&val);
		ex2 = (OutOfMemoryException)(object)ex8;
		goto IL_0f9c;
		IL_00c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5268]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj22 = 0;
		val = (Enumerator<, >)0;
		object obj23 = 0;
		num2 = 2.0;
		if ((nint)obj23 >= array.Length)
		{
			return;
		}
		bool flag14 = (nint)obj23 < array.Length;
		object obj24 = !flag14;
		if (obj24 == null)
		{
			object obj25 = (object)array + obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X8_v27+20]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X8_v27+20]");
			if ((nint)0 != 0)
			{
				object obj27 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X0_v43+E4]");
				bool flag15 = (nint)0 == 0;
				object obj28 = !flag15;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj27 = obj20;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X0_v43+A0]");
				object obj29 = 0;
				if (obj29 != null)
				{
					Enumerator<, > enumerator = ((List<System.__Canon>)obj29).GetEnumerator();
					nint num3 = unchecked((nint)null);
					Enumerator<, > val2 = default;
					num = (float)val2;
					object obj33 = default;
					while (true)
					{
						networkRunner = (NetworkRunner)obj21;
						if (!val.MoveNext())
						{
							break;
						}
						if (0 == 0)
						{
							goto IL_0684;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ stack_-B8_v6 (UnityEngine.Component)+38]");
						bool flag16 = (nint)0 == 0;
						object obj30 = !flag16;
						if (obj30 != null)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ stack_-B8_v6 (UnityEngine.Component)+41]");
						bool flag17 = (nint)0 == 0;
						object obj31 = !flag17;
						if (obj31 != null)
						{
							continue;
						}
						Transform transform = ((Component)null).transform;
						if ((object)transform == null)
						{
							goto IL_06a2;
						}
						Vector3 position = transform.position;
						float num5 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v28+18]");
						float num6 = num5 - 0f;
						double num7 = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v28+1C]");
						double num8 = num7 - 0.0;
						object obj32 = obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v28+20]");
						obj33 = obj32 - 0;
						float num9 = num6 * num6;
						double num10 = num8 * num8;
						float num11 = num9 + (float)num10;
						num2 = (double)obj33 * (double)obj33;
						num = (float)num2 + num11;
						float num12 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC08]");
						if (!(num12 < 0f))
						{
							continue;
						}
						object obj34 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v67+E4]");
						bool flag18 = (nint)0 == 0;
						object obj35 = !flag18;
						if (obj35 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag19 = (UnityEngine.Object)num3 == null;
						bool flag20 = !flag19;
						object obj36 = !flag20;
						num3 = unchecked((nint)null);
						if (obj36 != null)
						{
							continue;
						}
						object obj37 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X0_v71+E4]");
						bool flag21 = (nint)0 == 0;
						object obj38 = !flag21;
						if (obj38 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (!((UnityEngine.Object)runner != (UnityEngine.Object)null))
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ stack_-B8_v6 (UnityEngine.Component)+3C]");
						object obj39 = 0 & 0x80000000L;
						if (obj39 == null)
						{
							continue;
						}
						object obj40 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ stack_-B8_v6 (UnityEngine.Component)+88]");
						UnityEngine.Object obj15 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X0_v75+E4]");
						bool flag22 = (nint)0 == 0;
						object obj41 = !flag22;
						if (obj41 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (!(obj15 != null))
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ stack_-B8_v6 (UnityEngine.Component)+88]");
						if ((nint)0 == 0)
						{
							goto IL_06c5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ stack_-B8_v6 (UnityEngine.Component)+88]");
						if (!((GillaItemNet)0).Live)
						{
							continue;
						}
						Transform transform2 = ((Component)null).transform;
						if ((object)transform2 == null)
						{
							goto IL_06e8;
						}
						Vector3 position2 = transform2.position;
						float num13 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v28+18]");
						float num14 = num13 - 0f;
						double num15 = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v28+1C]");
						double num16 = num15 - 0.0;
						object obj42 = obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v28+20]");
						obj33 = obj42 - 0;
						float num17 = num14 * num14;
						double num18 = num16 * num16;
						float num19 = num17 + (float)num18;
						num2 = (double)obj33 * (double)obj33;
						num = (float)num2 + num19;
						float num20 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
						if (!(num20 < 0f))
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ stack_-B8_v6 (UnityEngine.Component)+88]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ stack_-B8_v6 (UnityEngine.Component)+88]");
							((GillaItemNet)0).RemoveFromRoom();
							continue;
						}
						goto IL_070b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5260]");
					object obj43 = 0;
					networkRunner = (NetworkRunner)obj43;
					val.Dispose();
					vector2 = (Vector3?)(object)(&val);
					goto IL_0e9e;
				}
			}
			goto IL_0e73;
		}
		goto IL_0e81;
	}

	public bool OnSpot(Vector3 p)
	{
		//IL_01b4: Expected I4, but got Obj
		//IL_0193: Expected Obj, but got I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_0053: Expected Obj, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		Spot[] array = spots;
		if (spots == null)
		{
			goto IL_0198;
		}
		object obj3;
		if (array.Length >= 1)
		{
			object obj = ~array.Length;
			object obj2 = array.Length & obj;
			obj3 = 0;
			object obj7 = default;
			object obj9 = default;
			object obj11 = default;
			while (array.Length != (nint)obj3)
			{
				object obj4 = (object)spots + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X12_v5+20]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X12_v5+20]");
				if ((nint)0 == 0)
				{
					goto IL_0198;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X12_v6+20]");
				object obj6 = obj7 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X12_v6+18]");
				object obj8 = obj9 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X12_v6+1C]");
				object obj10 = obj11 - 0;
				object obj12 = obj8 * obj8;
				object obj13 = obj10 * obj10;
				object obj14 = obj12 + obj13;
				object obj15 = obj6 * obj6;
				object obj16 = obj14 + obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC08]");
				if ((nint)obj16 >= 0)
				{
					obj3++;
					if (obj2 != obj3)
					{
						continue;
					}
				}
				goto IL_01b4;
			}
			goto IL_01a6;
		}
		obj3 = 0;
		goto IL_01b4;
		IL_01a6:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
		IL_0198:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_01a6;
		IL_01b4:
		object obj17 = obj3 - array.Length;
		bool flag = (nint)obj17 < 0;
		object obj18 = obj3 ^ array.Length;
		object obj19 = obj3 ^ obj17;
		object obj20 = obj18 & obj19;
		bool flag2 = (nint)obj20 < 0;
		bool flag3 = flag == flag2;
		return !flag3;
	}

	public bool Stays(GillaItem item)
	{
		//IL_009d: Expected I4, but got Obj
		//IL_0081: Expected VT, but got I4
		if ((object)item != null)
		{
			if (~(item.keeps ? 1u : 0u) == 0)
			{
				return true;
			}
			Transform transform = item.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				return OnSpot((Vector3)0);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private unsafe void ClearLocal()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got I4
		//IL_03b0: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got Ref
		//IL_0105: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I4
		//IL_02cd: Expected Obj, but got I4
		//IL_02d6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE8FB]");
		List<GameObject> list = (List<GameObject>)0;
		bool flag = (object)local == null;
		UnityEngine.Object obj = default;
		List<GameObject> list2 = (List<GameObject>)obj;
		Enumerator<, > val = (Enumerator<, >)0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4928]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4920]");
			object obj4 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)local).GetEnumerator();
			UnityEngine.Object obj5 = obj;
			while (val.MoveNext())
			{
				object obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v29+E4]");
				obj5 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v29+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag3 = obj != null;
				bool flag4 = !flag3;
				object obj8 = 0;
				if (!flag4)
				{
					object obj9 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v33+E4]");
					obj5 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v33+E4]");
					bool flag5 = (nint)0 == 0;
					object obj10 = !flag5;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(obj);
					obj8 = 0;
				}
			}
			list2 = null;
			Enumerator<, > val2 = default;
			val = val2;
			object obj11 = 0;
			Enumerator<, > val3 = (Enumerator<, >)(ref val);
			list = (List<GameObject>)obj5;
			object obj12 = 0;
			object obj15 = default;
			while (true)
			{
				val.Dispose();
				bool flag6 = obj12 == null;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					bool flag7 = (object)list2 == null;
					object obj14 = !flag7;
					OutOfMemoryException ex = (OutOfMemoryException)(&val);
					list = list2;
					if (obj14 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)obj4 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					list2 = (List<GameObject>)1;
					list = (List<GameObject>)1;
					obj12 = obj11;
					continue;
				}
				if ((nint)obj4 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj12 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj11 = obj15;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D0C4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			list = local;
			if ((object)local != null)
			{
				int version = list._version + 1;
				list._size = 0;
				list._version = version;
				if (list._size >= 1)
				{
					Array.Clear(list._items, 0, list._size);
				}
				return;
			}
		}
		throw new NullReferenceException();
	}

	private bool Due(bool online)
	{
		//IL_0014: Invalid comparison between F4 and I4
		//IL_00f5: Expected F4, but got VT
		//IL_0105: Expected F4, but got I
		//IL_0148: Expected Obj, but got I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected I4, but got Unknown
		float time = Time.time;
		float num2;
		bool result;
		if (nextAt < 0f)
		{
			float num = UnityEngine.Random.Range(3f, 12f);
			num2 = time + num;
			result = false;
		}
		else
		{
			if (time < nextAt)
			{
				result = false;
				goto IL_01b5;
			}
			int num3 = Lying(online);
			float time2 = Time.time;
			float maxInclusive;
			float minInclusive;
			if (num3 < first)
			{
				maxInclusive = 12f;
				minInclusive = 3f;
			}
			else
			{
				minInclusive = (float)every;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaItemDirector)+3C]");
				maxInclusive = 0f;
			}
			float num4 = UnityEngine.Random.Range(minInclusive, maxInclusive);
			num2 = time2 + num4;
			object obj = num3 - most;
			bool flag = (nint)obj < 0;
			int num5 = num3 ^ most;
			int num6 = num3 ^ obj;
			int num7 = num5 & num6;
			bool flag2 = num7 < 0;
			bool flag3 = flag == flag2;
			bool flag4 = !flag3;
			result = flag4;
		}
		nextAt = num2;
		goto IL_01b5;
		IL_01b5:
		return result;
	}

	private int Lying(bool online)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ca: Expected I4, but got Obj
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I
		//IL_0125: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1640]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6318]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1650]");
			object obj5 = 0;
			object obj6 = obj2 + 16;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v8+A0]");
			object source = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Func<System.__Canon, bool> func = default;
			func._002Ector(obj2, (IntPtr)obj5);
			return Enumerable.Count((IEnumerable<System.__Canon>)source, func);
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private unsafe Kind Pick()
	{
		//IL_0010: Expected Obj, but got I
		//IL_045c: Expected Obj, but got I4
		//IL_066f: Expected Obj, but got I
		//IL_067f: Expected Obj, but got I
		//IL_068f: Expected Obj, but got I
		//IL_069f: Expected Obj, but got I
		//IL_06c1: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_04fb: Expected Obj, but got I
		//IL_050b: Expected Obj, but got I
		//IL_051b: Expected Obj, but got I
		//IL_053d: Expected Obj, but got I4
		//IL_047a: Expected Obj, but got I
		//IL_0494: Expected Obj, but got I
		//IL_04a5: Expected I, but got Obj
		//IL_04c3: Expected Obj, but got I
		//IL_04de: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I4
		//IL_055b: Expected Obj, but got I
		//IL_0575: Expected Obj, but got I
		//IL_0586: Expected I, but got Obj
		//IL_05a4: Expected Obj, but got I
		//IL_05bf: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I
		//IL_01b5: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got I
		//IL_0239: Expected Obj, but got I4
		//IL_0242: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got I4
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got I4
		//IL_0264: Expected Obj, but got Ref
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected Ref, but got Unknown
		//IL_0629: Expected Obj, but got I4
		//IL_0333: Expected Obj, but got I4
		//IL_033c: Expected Obj, but got I4
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Ref
		//IL_02c6: Expected Obj, but got I4
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_03bb: Expected Obj, but got I4
		//IL_03cc: Expected Obj, but got I4
		//IL_0423: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1550]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1560]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v29+40]");
		Func<System.__Canon, bool> predicate = (Func<System.__Canon, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D15D0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v29+40]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v33+A0]");
				obj4 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1570]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1600]");
			object obj11 = 0;
			Func<System.__Canon, bool> func = default;
			func._002Ector(obj4, (IntPtr)obj11);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v32+A0]");
			object obj13 = (nint)0 + (nint)64;
			obj13 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj14 = 0;
			predicate = func;
		}
		IEnumerable<System.__Canon> source = Enumerable.Where((IEnumerable<System.__Canon>)(object)kinds, predicate);
		List<System.__Canon> list = Enumerable.ToList(source);
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v13+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X9_v5+48]");
		Func<System.__Canon, float> func2 = (Func<System.__Canon, float>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D15C8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X9_v5+48]");
		bool flag5 = (nint)0 == 0;
		object obj19 = !flag5;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v13+E4]");
			bool flag6 = (nint)0 == 0;
			object obj20 = !flag6;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj21 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v27+A0]");
				obj17 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D15F0]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1608]");
			object obj23 = 0;
			Func<System.__Canon, float> func3 = default;
			func3._002Ector(obj17, (IntPtr)obj23);
			obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v13+A0]");
			object obj24 = (nint)0 + (nint)72;
			obj24 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj14 = 0;
			func2 = func3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35E1070");
		float maxInclusive = default;
		float num = UnityEngine.Random.Range(0f, maxInclusive);
		bool flag7 = list == null;
		Func<System.__Canon, float> func4 = func2;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D15E0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D15D8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D15C0]");
			obj = 0;
			Enumerator<, > enumerator = list.GetEnumerator();
			float num2 = num;
			func4 = (Func<System.__Canon, float>)obj25;
			Enumerator<, > val = default;
			object obj27;
			object obj28;
			Enumerator<, > val2;
			if (!val.MoveNext())
			{
				object obj26 = 8;
				obj27 = 0;
				obj28 = 0;
				val2 = (Enumerator<, >)(ref val);
				object obj29 = 0;
				obj15 = (object)(&val);
				Kind result = null;
				Kind kind = default;
				object obj33 = default;
				while (true)
				{
					func4 = (Func<System.__Canon, float>)obj18;
					((Enumerator<, >*)val2)->Dispose();
					bool flag8 = obj29 == null;
					object obj30 = !flag8;
					if (obj30 == null)
					{
						bool flag9 = obj27 == null;
						object obj31 = !flag9;
						OutOfMemoryException ex = (OutOfMemoryException)val2;
						if (obj31 == null)
						{
							object obj32 = obj26 | 8;
							if ((nint)obj32 == 8)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35CD470");
								result = kind;
							}
							return result;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)func4 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj27 = 1;
						obj29 = obj28;
						obj15 = 1;
					}
					else
					{
						if ((nint)func4 != 1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj29 = obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj28 = obj33;
					}
					obj26 = 0;
					result = null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0DEC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				Kind result2 = default;
				return result2;
			}
			Kind kind2 = null;
			NullReferenceException ex2 = new NullReferenceException();
			obj27 = 0;
			obj28 = 0;
			val2 = (Enumerator<, >)(ref val);
			obj15 = (object)(&val);
		}
		throw new NullReferenceException();
	}

	private unsafe bool PlaceFor(out Vector3 at)
	{
		//IL_0475: Expected Obj, but got I
		//IL_0485: Expected Obj, but got I
		//IL_04a4: Expected Obj, but got I
		//IL_04ad: Expected Obj, but got I4
		//IL_04b6: Expected Obj, but got I4
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected I4, but got Unknown
		//IL_005d: Expected Obj, but got I4
		//IL_0062: Expected I, but got Obj
		//IL_007e: Expected Obj, but got I4
		//IL_0096: Expected VT, but got I4
		//IL_00c4: Expected Obj, but got I4
		//IL_04e0: Expected Obj, but got I
		//IL_04ff: Expected F8, but got I
		//IL_050f: Expected Obj, but got I
		//IL_0514: Expected I, but got Obj
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected F8, but got I
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected F4, but got Unknown
		//IL_0133: Expected Obj, but got I
		//IL_052a: Expected I4, but got Obj
		//IL_060a: Expected Obj, but got I
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected I, but got Obj
		//IL_0630: Expected I4, but got Obj
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected I, but got Obj
		//IL_0178: Expected Obj, but got I4
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected I, but got Obj
		//IL_057e: Expected Obj, but got I4
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5268]");
		object obj2 = 0;
		ref Vector3 reference = ref *(Vector3*)null;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj3 = 0;
		object obj4 = 0;
		object obj5 = 0;
		double num = 0.5;
		ref Vector3 reference2 = ref at;
		Vector3[] array = places;
		bool flag = places == null;
		int num2 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
		if (!flag)
		{
			num2 = array.Length;
			if (array.Length == 0)
			{
				return (byte)(obj5 & 1) != 0;
			}
			int num3 = UnityEngine.Random.Range(0, array.Length);
			bool flag2 = num3 < array.Length;
			object obj6 = !flag2;
			nint num4 = unchecked((nint)null);
			if (obj6 != null)
			{
				goto IL_0433;
			}
			object obj7 = num3 * 12;
			object obj8 = (object)places + obj7;
			float num5 = Nearest((Vector3)num3);
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X0_v23+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X0_v23+A0]");
			object obj11 = 0;
			bool flag4 = obj11 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v12+24]");
			double num6 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v12+28]");
			object obj12 = 0;
			num4 = unchecked((nint)null);
			if (!flag4)
			{
				float num7 = num5 * 0.125f;
				Enumerator<, > enumerator = ((List<System.__Canon>)obj11).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v12+24]");
				num6 = 0.0;
				Enumerator<, > val = default;
				num5 = (float)val;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v12+28]");
				obj12 = 0;
				Enumerator<, > val2 = default;
				while (true)
				{
					num2 = (int)obj2;
					Enumerator<, > val3;
					if (val2.MoveNext())
					{
						NullReferenceException ex;
						if (false)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ stack_-C8_v1 (UnityEngine.Component)+41]");
							bool flag5 = (nint)0 == 0;
							object obj13 = !flag5;
							if (obj13 == null)
							{
								Transform transform = ((Component)null).transform;
								if ((object)transform == null)
								{
									ex = new NullReferenceException();
									val3 = (Enumerator<, >)(ref val2);
									num4 = unchecked((nint)null);
									num2 = 0;
									break;
								}
								Vector3 position = transform.position;
								object obj14 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v36+E4]");
								bool flag6 = (nint)0 == 0;
								object obj15 = !flag6;
								if (obj15 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v12+20]");
								float num8 = 0f - num5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v12+24]");
								double num9 = 0.0 - num6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v12+28]");
								object obj16 = 0 - obj12;
								float num10 = num8 * num8;
								double num11 = num9 * num9;
								obj12 = obj16 * obj16;
								float num12 = num10 + (float)num11;
								float num13 = (float)obj12 + num12;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								float num14 = num13 / 10f;
								if (!(num7 < num14))
								{
									num7 = num14;
								}
								num6 = 10.0;
								num5 = num14;
							}
							continue;
						}
						ex = new NullReferenceException();
						val3 = (Enumerator<, >)(ref val2);
						num4 = unchecked((nint)null);
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5260]");
					object obj17 = 0;
					reference2 = ref *(Vector3*)obj17;
					val2.Dispose();
					val3 = (Enumerator<, >)(ref val2);
					num4 = unchecked((nint)null);
					num2 = (int)obj17;
					OutOfMemoryException ex2 = new OutOfMemoryException();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D3D4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				bool result = default;
				return result;
			}
		}
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0433;
		IL_0433:
		throw new IndexOutOfRangeException();
	}

	private unsafe GillaItem Make(NetworkRunner runner, Kind kind, Vector3? place)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_0126: Expected F4, but got I4
		//IL_0c44: Expected Obj, but got I
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_0c84: Expected Obj, but got I
		//IL_0d0f: Expected Obj, but got I
		//IL_0d1f: Expected F4, but got I
		//IL_0d2f: Expected F4, but got I
		//IL_0da5: Expected Obj, but got I4
		//IL_0495: Expected F4, but got VT
		//IL_049e: Expected Obj, but got I4
		//IL_0280: Expected Obj, but got I4
		//IL_04c9: Expected Obj, but got I
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_02ad: Expected Obj, but got I
		//IL_067a: Expected F4, but got VT
		//IL_0682: Expected Obj, but got Ref
		//IL_0516: Expected Obj, but got I
		//IL_0523: Expected VT, but got Obj
		//IL_0533: Expected Obj, but got I
		//IL_053b: Expected VT, but got Obj
		//IL_0548: Expected VT, but got Obj
		//IL_0340: Expected Obj, but got I
		//IL_06ba: Expected Obj, but got I
		//IL_06ca: Expected Obj, but got I
		//IL_06f4: Expected Obj, but got I
		//IL_071e: Expected Obj, but got I4
		//IL_03ff: Expected Obj, but got I4
		//IL_058a: Expected VT, but got Ref
		//IL_058a: Expected VT, but got I4
		//IL_05b8: Expected Obj, but got I4
		//IL_0763: Expected Obj, but got I
		//IL_0773: Expected Obj, but got I
		//IL_0783: Expected Obj, but got I
		//IL_0840: Invalid comparison between VT and I4
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_0617: Expected F4, but got VT
		//IL_0620: Expected Obj, but got I4
		//IL_0629: Expected VT, but got I4
		//IL_080c: Expected Obj, but got I
		//IL_08a0: Expected I, but got Obj
		//IL_08a8: Expected Obj, but got I
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Expected Obj, but got Unknown
		//IL_0b63: Expected VT, but got I4
		//IL_0647: Expected Obj, but got I
		//IL_0b85: Expected Obj, but got I4
		//IL_090e: Expected Obj, but got I4
		//IL_0916: Expected I, but got Obj
		//IL_091e: Expected Obj, but got Ref
		//IL_097e: Expected Obj, but got I4
		//IL_0a7e: Expected Obj, but got I4
		//IL_0a9c: Expected Obj, but got I
		//IL_0b07: Expected Obj, but got I4
		if (kind == null)
		{
			goto IL_0749;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = kind.prefab == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		GillaItem result = null;
		if (obj4 == null)
		{
			Vector3? vector = default;
			object obj5 = (_003F?)vector & 0xFF;
			float num;
			float num2 = default;
			Vector3 vector3;
			object obj6;
			if (obj5 != null)
			{
				Vector3? vector2 = default;
				Vector3 value = vector2.Value;
				num = num2;
				Vector3 vector4 = default;
				vector3 = vector4;
				object obj7 = default;
				obj6 = obj7;
			}
			else
			{
				if (!PlaceFor(out var at))
				{
					goto IL_0749;
				}
				num = 0f;
				vector3 = at;
				object obj8 = default;
				obj6 = obj8;
			}
			float num3 = UnityEngine.Random.Range(0f, 360f);
			float num4 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			float num5 = num4 * 0f;
			Vector3 euler = default;
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			float num6 = (float)kind.lie * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [kind @ X2 (GillaItemDirector+Kind)+24]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj9 = num7 * 0;
			Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(ref euler);
			object obj10 = default;
			float num8 = (float)obj10 * num6;
			float num9 = num5 * (float)obj10;
			float num10 = 1.13587E+09f * (float)obj10;
			float num11 = num2 * (float)obj10;
			object obj11 = obj10 * obj10;
			object obj12 = obj10 * obj9;
			float num12 = num5 * num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [kind @ X2 (GillaItemDirector+Kind)+24]");
			object obj13 = obj10 * 0;
			float num13 = num8 + num9;
			float num14 = 1.13587E+09f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [kind @ X2 (GillaItemDirector+Kind)+24]");
			float num15 = num14 * 0f;
			float num16 = num2 * num6;
			float num17 = (float)obj12 + num10;
			float num18 = num5 * (float)obj9;
			float num19 = (float)obj11 - num12;
			float num20 = (float)obj13 + num11;
			float num21 = 1.13587E+09f * (float)obj9;
			float num22 = num15 + num13;
			float num23 = num16 + num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj14 = 0;
			float num24 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [kind @ X2 (GillaItemDirector+Kind)+24]");
			float num25 = num24 * 0f;
			float num26 = num18 + num20;
			float num27 = num2 * (float)obj9;
			float num28 = 1.13587E+09f * num6;
			object obj15 = obj14;
			float num29 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [kind @ X2 (GillaItemDirector+Kind)+24]");
			float num30 = num29 * 0f;
			object obj16 = obj;
			float num31 = num19 - num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v16+A0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v17+1C]");
			float num32 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v17+20]");
			float num33 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v17+20]");
			float num34 = 0f * kind.lift;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v17+18]");
			float num35 = 0f * kind.lift;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v17+1C]");
			float num36 = 0f * kind.lift;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X0_v17+E4]");
			bool flag4 = (nint)0 == 0;
			object obj18 = !flag4;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num37 = num22 - num27;
			float num38 = num31 - num30;
			float num39 = num23 - num25;
			float num40 = num26 - num28;
			float num41 = (float)obj6 + num36;
			float num42 = (float)vector3 + num35;
			float num43 = num + num34;
			if ((UnityEngine.Object)runner == (UnityEngine.Object)null)
			{
				Transform transform = base.transform;
				object obj19 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X8_v45+E4]");
				bool flag5 = (nint)0 == 0;
				object obj20 = !flag5;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E20]");
				object obj21 = 0;
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDDA0");
				List<System.__Canon> list = (List<System.__Canon>)(object)local;
				bool flag6 = (object)local == null;
				num21 = num40;
				num33 = num37;
				num22 = num38;
				num19 = num39;
				num32 = num43;
				float num44 = num42;
				float num45 = num41;
				Transform transform2 = transform;
				NetworkRunner networkRunner = runner;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4940]");
					object obj23 = 0;
					System.__Canon[] items = list._items;
					object obj24 = obj23;
					int version = list._version + 1;
					list._version = version;
					bool flag7 = list._items == null;
					num21 = num40;
					num33 = num37;
					num22 = num38;
					num19 = num39;
					num32 = num43;
					num44 = num42;
					num45 = num41;
					transform2 = transform;
					networkRunner = runner;
					if (!flag7)
					{
						bool flag8 = list._size < items.Length;
						object obj25 = !flag8;
						System.__Canon _Canon = default;
						if (obj25 == null)
						{
							object obj26 = list._items + list._size;
							int size = list._size + 1;
							list._size = size;
							object obj27 = obj26 + 32;
							obj27 = _Canon;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							transform2 = (Transform)(object)_Canon;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X10_v7+20]");
							object obj28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ X9_v13+A8]");
							object obj29 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X9_v14+70]");
							obj22 = 0;
							((List<System.__Canon>)(object)local).AddWithResize(_Canon);
							transform2 = (Transform)(object)_Canon;
						}
						bool flag9 = _Canon == null;
						num21 = num40;
						num33 = num37;
						num22 = num38;
						num19 = num39;
						num32 = num43;
						num44 = num42;
						num45 = num41;
						networkRunner = runner;
						if (!flag9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBD00]");
							object obj30 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
							goto IL_0bcd;
						}
					}
				}
			}
			else
			{
				bool flag10 = (object)kind.prefab == null;
				float num44 = num;
				float num45 = (float)vector3;
				object obj22 = 0;
				Transform transform2 = null;
				NetworkRunner networkRunner = runner;
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5358]");
					object obj31 = 0;
					obj22 = obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
					object obj33 = default;
					object obj32 = obj33 & 1;
					NetworkObject prefab = default;
					if (obj32 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
						object obj34 = 0;
						Vector3? position = (Vector3)obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5368]");
						object obj35 = 0;
						Quaternion quaternion3 = (Quaternion)obj35;
						Quaternion? quaternion4 = (Quaternion)obj35;
						if ((object)runner != null)
						{
							Quaternion? quaternion5 = default;
							NetworkObject networkObject = runner.Spawn(prefab, position, (Quaternion?)(object)0, (PlayerRef?)(object)(&quaternion5), null, (NetworkSpawnFlags)0);
							object obj36 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v895 @ X0_v92+E4]");
							bool flag11 = (nint)0 == 0;
							object obj37 = !flag11;
							if (obj37 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (!((UnityEngine.Object)networkObject != (UnityEngine.Object)null))
							{
								goto IL_0749;
							}
							bool flag12 = (object)networkObject == null;
							num37 = (float)quaternion4;
							obj22 = 0;
							quaternion3 = (Quaternion)0;
							if (!flag12)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51E0]");
								object obj38 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
								goto IL_0bcd;
							}
						}
						else
						{
							NullReferenceException ex = new NullReferenceException();
						}
						NullReferenceException ex2 = new NullReferenceException();
						bool flag13 = quaternion3 != (Quaternion)(object)1;
						num33 = num38;
						num32 = num40;
						num44 = num37;
						num45 = num39;
						NullReferenceException ex3 = ex2;
						if (!flag13)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							NetworkRunner networkRunner2 = default;
							nint num46 = (nint)networkRunner2;
							transform2 = (Transform)num46;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
							object obj40 = default;
							object obj39 = obj40 & 1;
							bool flag14 = obj39 == null;
							num33 = num38;
							num32 = num40;
							num44 = num37;
							num45 = num39;
							networkRunner = networkRunner2;
							if (!flag14)
							{
								object obj41 = 0;
								nint num47 = (nint)networkRunner2;
								object obj43 = default;
								object obj42 = (object)(&obj43);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								NetworkRunner networkRunner3 = default;
								bool flag15 = (object)networkRunner3 == null;
								num33 = num38;
								num32 = num40;
								num44 = num37;
								num45 = num39;
								transform2 = (Transform)5;
								networkRunner = networkRunner2;
								if (!flag15)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
									bool flag16 = (object)kind.prefab == null;
									num33 = num38;
									num32 = num40;
									num44 = num37;
									num45 = num39;
									object obj44 = default;
									obj22 = obj44;
									transform2 = null;
									networkRunner = networkRunner3;
									if (!flag16)
									{
										string text = kind.prefab.name;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
										bool flag17 = (object)networkRunner2 == null;
										num33 = num38;
										num32 = num40;
										num44 = num37;
										num45 = num39;
										object obj45 = default;
										obj22 = obj45;
										transform2 = (Transform)2;
										networkRunner = networkRunner3;
										if (!flag17)
										{
											object obj46 = num47;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v939 @ X8_v39+188] (should have been resolved before IL gen)");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
											string message = string.Concat((string[])(object)networkRunner3);
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X0_v84+E4]");
											bool flag18 = (nint)0 == 0;
											object obj47 = !flag18;
											if (obj47 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Debug.LogError(message);
											result = null;
											goto IL_0bcd;
										}
									}
								}
								goto IL_0b37;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
							object obj48 = networkRunner;
							quaternion3 = (Quaternion)(101789696 + 1224);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj22 = 0;
							NullReferenceException ex4 = default;
							ex3 = ex4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						GillaItem result2 = default;
						return result2;
					}
					bool flag19 = (object)kind.prefab == null;
					num44 = num;
					num45 = (float)vector3;
					transform2 = (Transform)(&prefab);
					networkRunner = runner;
					if (!flag19)
					{
						string text2 = kind.prefab.name;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1610]");
						object obj49 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD40]");
						object obj50 = 0;
						string message2 = (string)obj49 + text2 + (string)obj50;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
						object obj51 = 0;
						object obj52 = obj51;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v30+E4]");
						bool flag20 = (nint)0 == 0;
						object obj53 = !flag20;
						if (obj53 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Debug.LogError(message2);
						goto IL_0749;
					}
				}
			}
			goto IL_0b37;
		}
		goto IL_0bcd;
		IL_0749:
		result = null;
		goto IL_0bcd;
		IL_0bcd:
		return result;
		IL_0b37:
		throw new NullReferenceException();
	}

	public GillaItem MakeNow(int k, Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_028e: Expected Obj, but got I4
		//IL_02b4: Expected Obj, but got I
		//IL_02d6: Expected Obj, but got I4
		//IL_036b: Expected Obj, but got I
		//IL_037b: Expected Obj, but got I
		//IL_039d: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_030e: Expected Obj, but got I4
		//IL_0195: Expected I4, but got I8
		//IL_01af: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I
		//IL_032c: Expected Obj, but got I
		//IL_0339: Expected VT, but got Obj
		//IL_0248: Expected VT, but got I4
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_0226: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v1+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v1+8]");
		bool flag4 = (UnityEngine.Object)0 != null;
		bool flag5 = !flag4;
		UnityEngine.Object obj11 = null;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v1+8]");
			if ((nint)0 == 0)
			{
				goto IL_0256;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X21_v3 (UnityEngine.Object)+B0]");
			obj11 = (UnityEngine.Object)0;
		}
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v10+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = obj11 != null;
		bool flag8 = !flag7;
		NetworkRunner runner = null;
		GillaItem result;
		if (!flag8)
		{
			if ((object)obj11 == null)
			{
				goto IL_0256;
			}
			bool isRunning = ((NetworkRunner)obj11).IsRunning;
			bool flag9 = !isRunning;
			runner = null;
			if (!flag9)
			{
				bool isSharedModeMasterClient = ((NetworkRunner)obj11).IsSharedModeMasterClient;
				bool flag10 = !isSharedModeMasterClient;
				runner = (NetworkRunner)obj11;
				result = null;
				if (flag10)
				{
					goto IL_0251;
				}
			}
		}
		int num = (int)(k & 0x80000000L);
		bool flag11 = num == 0;
		object obj14 = !flag11;
		Kind kind;
		if (obj14 == null)
		{
			Kind[] array = kinds;
			if (kinds == null)
			{
				goto IL_0256;
			}
			if (array.Length > k)
			{
				object obj15 = kinds + k;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v16+20]");
				kind = (Kind)0;
				goto IL_031c;
			}
		}
		kind = null;
		goto IL_031c;
		IL_0251:
		return result;
		IL_031c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
		object obj16 = 0;
		Vector3? vector = (Vector3)obj16;
		if ((object)this != null)
		{
			result = Make(runner, kind, (Vector3?)(object)0);
			goto IL_0251;
		}
		goto IL_0256;
		IL_0256:
		return (GillaItem)(object)new NullReferenceException();
	}

	public GillaItemDirector()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1658]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1660]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48C0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj5 = this + 32;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj7 = this + 40;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		lasts = 300f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107DEE0]");
		most = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj9 = this + 96;
		object obj10 = default;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		spotRefill = 180f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj11 = this + 112;
		obj11 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		nextAt = -1f;
		base._002Ector();
	}

	private bool _003CSpots_003Eb__40_0(GillaItem i)
	{
		//IL_018f: Expected I4, but got Obj
		//IL_001e: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I4
		//IL_016d: Expected VT, but got I4
		if ((object)i != null)
		{
			bool flag = (byte)(~(i.keeps ? 1u : 0u)) != 0;
			object obj = !flag;
			if (obj == null)
			{
				bool flag2 = (byte)(~(i.Gone__BackingField ? 1u : 0u)) != 0;
				object obj2 = !flag2;
				if (obj2 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj3 = 0;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+E4]");
					bool flag3 = (nint)0 == 0;
					object obj5 = !flag3;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((UnityEngine.Object)i.Net__BackingField != (UnityEngine.Object)null)
					{
						if ((object)i.Net__BackingField != null)
						{
							if (!i.Net__BackingField.Live)
							{
								goto IL_017b;
							}
							Transform transform = i.transform;
							if ((object)transform != null)
							{
								Vector3 position = transform.position;
								return OnSpot((Vector3)0);
							}
						}
						goto IL_0181;
					}
				}
			}
			goto IL_017b;
		}
		goto IL_0181;
		IL_017b:
		return false;
		IL_0181:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
