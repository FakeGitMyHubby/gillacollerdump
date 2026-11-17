using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class GillaRecycler : MonoBehaviour
{
	public sealed class Quest
	{
		public readonly GillaQuests.Stat stat;

		public readonly int goal;

		public readonly int xp;

		public readonly string text;

		public Quest(GillaQuests.Stat stat, int goal, int xp, string text)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected Obj, but got Unknown
			object obj = this + 32;
			obj = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private class Going
	{
		public GillaItem item;

		public float t;

		public Vector3 from;

		public Vector3 size;

		public Vector3 spin;

		public Quaternion turn;

		public bool moves;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<GillaRecycler> _003C_003E9__90_0;

		public static Func<Transform, Quaternion> _003C_003E9__91_0;

		public static Func<GillaItem, bool> _003C_003E9__91_1;

		public static Func<GillaItem, string> _003C_003E9__91_2;

		public static Func<IGrouping<string, GillaItem>, (string, int)> _003C_003E9__91_3;

		public static Func<(string, int), int> _003C_003E9__91_4;

		public static Func<(string, int), string> _003C_003E9__91_5;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62A0]");
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

		internal int _003COnEnable_003Eb__90_0(GillaRecycler a, GillaRecycler b)
		{
			//IL_007d: Expected I4, but got Obj
			if ((object)a != null)
			{
				string name = a.name;
				if ((object)b != null)
				{
					string name2 = b.name;
					return string.CompareOrdinal(name, name2);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal Quaternion _003CStart_003Eb__91_0(Transform s)
		{
			//IL_0010: Expected Obj, but got I
			//IL_00bb: Expected Obj, but got I4
			//IL_00ce: Expected VT, but got I4
			//IL_0091: Expected VT, but got Obj
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
			bool flag2 = s != null;
			if (flag2)
			{
				if ((object)s != null)
				{
					return s.localRotation;
				}
				NullReferenceException ex = new NullReferenceException();
				return (Quaternion)ex;
			}
			return (Quaternion)flag2;
		}

		internal bool _003CStart_003Eb__91_1(GillaItem i)
		{
			//IL_0071: Expected I4, but got Obj
			if ((object)i != null)
			{
				if (~(i.keeps ? 1u : 0u) == 0)
				{
					return false;
				}
				bool flag = !i.recycles;
				return !flag;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal string _003CStart_003Eb__91_2(GillaItem i)
		{
			if ((object)i != null)
			{
				return i.label;
			}
			return (string)(object)new NullReferenceException();
		}

		internal (string, int) _003CStart_003Eb__91_3(IGrouping<string, GillaItem> g)
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

		internal int _003CStart_003Eb__91_4((string, int) p)
		{
			IntPtr intPtr = default;
			return (int)(nint)intPtr;
		}

		internal string _003CStart_003Eb__91_5((string, int) p)
		{
			//IL_0005: Expected Obj, but got VT
			return p;
		}
	}

	public Renderer screen;

	public Transform mouth;

	public Transform lip;

	public Transform nip;

	public Vector3 front;

	public Transform[] spinners;

	public Vector3[] axes;

	public float[] rates;

	public Renderer body;

	public int lampSlot;

	public Light beacon;

	public TextAsset titleFont;

	public TextAsset textFont;

	public float wakeRange;

	public float idleSpeed;

	public float workSpeed;

	public AudioClip hum;

	public AudioClip[] grind;

	public AudioClip[] crunch;

	public AudioClip coinSound;

	public AudioClip sparkleSound;

	public AudioClip tickSound;

	public AudioClip bootSound;

	public AudioClip offSound;

	private const float HumVolume = default(float);

	private const float GrindVolume = default(float);

	private const float CrunchVolume = default(float);

	private const float TickVolume = default(float);

	private const float CoinVolume = default(float);

	private const float SparkleVolume = default(float);

	private const float WakeVolume = default(float);

	private const float CrunchEvery = default(float);

	private const float ChimeEvery = default(float);

	private const int W = default(int);

	private const int H = default(int);

	private const float Swallowing = default(float);

	private const float Recycling = default(float);

	private static readonly int BaseMap;

	private static readonly int BaseColor;

	private static readonly RectInt PriceRect;

	private static readonly RectInt WalletRect;

	private static readonly RectInt MainRect;

	private static readonly Color32 Black;

	private static readonly Color32 Scan;

	private static readonly Color32 Green;

	private static readonly Color32 Dim;

	private static readonly Color32 Dark;

	private static readonly Color32 Yellow;

	private static readonly Color32[] GreenText;

	private static readonly Color32[] DimText;

	private static readonly Color32[] BoltText;

	private static readonly List<GillaRecycler> all;

	private readonly List<Going> going;

	private readonly Queue<(string, int, bool)> waiting;

	private readonly List<(string, int, string)> log;

	private readonly Dictionary<string, int> kinds;

	private readonly List<string> unpaid;

	private bool mine;

	private int total;

	private int paidOut;

	private float shown;

	private float paidAt;

	private float countedF;

	private float tickIn;

	private int counted;

	private float work;

	private float turned;

	private float awake;

	private float flash;

	private float nextDraw;

	private bool wanted;

	private bool dirty;

	private Texture2D tex;

	private Color32[] px;

	private MaterialPropertyBlock block;

	private MaterialPropertyBlock lampBlock;

	private ScreenFont title;

	private ScreenFont text;

	private AudioSource humming;

	private AudioSource grinding;

	private int grindClip;

	private float crunchedAt;

	private float chimedAt;

	private ParticleSystem sparks;

	private Quaternion[] rest;

	private Color lampColour;

	private int lastBalance;

	private (string, int)[] prices;

	private static readonly Dictionary<string, (string[], Color32, Color32, Color32)> Icons;

	public Vector3 Front
	{
		get
		{
			//IL_0099: Expected VT, but got Obj
			//IL_0035: Expected VT, but got I4
			//IL_00b3: Expected Obj, but got I
			//IL_00bb: Expected VT, but got Obj
			//IL_00dd: Expected Obj, but got I4
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Vector3 vector = transform.TransformDirection((Vector3)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj = 0;
				Vector3 result = (Vector3)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v7 (UnityEngine.Vector3)+E4]");
				bool flag = (nint)0 == 0;
				object obj2 = !flag;
				if (obj2 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaRecycler)+48]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				if (num > 0)
				{
				}
				return result;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
	}

	public (string, int) Last
	{
		get
		{
			//IL_00b6: Expected VT, but got Obj
			//IL_00a3: Expected VT, but got I4
			//IL_0095: Expected VT, but got I4
			List<(System.__Canon, int, System.__Canon)> list = (List<(System.__Canon, int, System.__Canon)>)(object)log;
			if ((object)log != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v2 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.Int32, System.__Canon>>)+18]");
				if ((nint)0 <= (nint)0)
				{
					return ((string, int))0;
				}
				(System.__Canon, int, System.__Canon) tuple = ((List<(System.__Canon, int, System.__Canon)>)(object)log).get_Item(0);
				if ((object)log != null)
				{
					(System.__Canon, int, System.__Canon) tuple2 = ((List<(System.__Canon, int, System.__Canon)>)(object)log).get_Item(0);
					System.__Canon item = default;
					int item2 = default;
					(System.__Canon, int) tuple3 = (item, item2);
					return ((string, int))0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return ((string, int))ex;
		}
	}

	public bool Showing
	{
		get
		{
			//IL_000b: Invalid comparison between F4 and I4
			//IL_0022: Expected Obj, but got F4
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			bool flag = shown < 0f;
			object obj = shown ^ shown;
			object obj2 = shown & obj;
			bool flag2 = (nint)obj2 < 0;
			return flag == flag2;
		}
	}

	private unsafe string Shown
	{
		get
		{
			//IL_0517: Expected VT, but got I4
			//IL_0520: Expected VT, but got I4
			//IL_0529: Expected VT, but got I4
			//IL_0037: Expected Obj, but got I
			//IL_0078: Expected VT, but got I4
			//IL_0081: Expected VT, but got I4
			//IL_008a: Expected VT, but got I4
			//IL_0098: Expected Obj, but got I4
			//IL_03ff: Expected Obj, but got VT
			//IL_00d3: Expected VT, but got I4
			//IL_00dc: Expected VT, but got I4
			//IL_00e5: Expected VT, but got I4
			//IL_02e4: Expected Obj, but got I
			//IL_061b: Expected I, but got Obj
			//IL_062c: Expected VT, but got I4
			//IL_0646: Expected Obj, but got I4
			//IL_0650: Expected VT, but got I4
			//IL_0660: Expected VT, but got Ref
			//IL_01c7: Expected Obj, but got I4
			//IL_01d0: Expected Obj, but got I4
			//IL_01e1: Expected Obj, but got I4
			//IL_01fb: Expected Obj, but got I4
			//IL_0204: Expected VT, but got I4
			//IL_0214: Expected VT, but got Ref
			//IL_05e2: Expected I, but got Obj
			//IL_05eb: Expected Ref, but got VT
			//IL_0605: Expected Obj, but got I4
			//IL_015e: Expected Obj, but got I4
			//IL_054e: Expected Obj, but got I4
			//IL_0557: Expected Obj, but got I4
			//IL_055f: Expected Obj, but got I4
			//IL_0579: Expected Obj, but got I4
			//IL_0582: Expected VT, but got I4
			//IL_0592: Expected VT, but got Ref
			//IL_0245: Expected Obj, but got I4
			//IL_024d: Expected VT, but got Obj
			//IL_0255: Expected Obj, but got VT
			//IL_019f: Expected Obj, but got I4
			//IL_019f: Expected Obj, but got I4
			//IL_0274: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Expected I4, but got Unknown
			//IL_0293: Expected VT, but got Obj
			//IL_04c2: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDB8E]");
			int num = 0;
			bool flag = (object)kinds == null;
			int num2 = 0;
			int num3 = 0;
			Dictionary<System.__Canon, int>.Enumerator enumerator = (Dictionary<System.__Canon, int>.Enumerator)0;
			Dictionary<System.__Canon, int>.Enumerator enumerator2 = (Dictionary<System.__Canon, int>.Enumerator)0;
			Dictionary<System.__Canon, int>.Enumerator enumerator3 = (Dictionary<System.__Canon, int>.Enumerator)0;
			GillaRecycler gillaRecycler = this;
			string text4;
			NullReferenceException ex2;
			int num7 = default;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6460]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6468]");
				object obj = 0;
				nint num4 = ((int*)num)->m_value;
				int count = ((Dictionary<System.__Canon, int>)(object)kinds).Count;
				bool flag2 = count != 1;
				num3 = 0;
				enumerator = (Dictionary<System.__Canon, int>.Enumerator)0;
				enumerator2 = (Dictionary<System.__Canon, int>.Enumerator)0;
				enumerator3 = (Dictionary<System.__Canon, int>.Enumerator)0;
				gillaRecycler = this;
				string text = (string)109891584;
				int num5 = default;
				int num8 = default;
				if (!flag2)
				{
					bool flag3 = (object)kinds == null;
					num2 = 0;
					num3 = 0;
					enumerator = (Dictionary<System.__Canon, int>.Enumerator)0;
					enumerator2 = (Dictionary<System.__Canon, int>.Enumerator)0;
					enumerator3 = (Dictionary<System.__Canon, int>.Enumerator)0;
					gillaRecycler = this;
					if (flag3)
					{
						goto IL_03d2;
					}
					Dictionary<System.__Canon, int>.Enumerator enumerator4 = ((Dictionary<System.__Canon, int>)(object)kinds).GetEnumerator();
					int num6 = default;
					object obj2;
					object obj3;
					Dictionary<System.__Canon, int>.Enumerator enumerator5 = default;
					object obj4;
					Dictionary<System.__Canon, int>.Enumerator enumerator7;
					if (enumerator2.MoveNext())
					{
						bool flag4 = num5 < 2;
						num3 = 0;
						num = num5;
						text = (string)num6;
						if (!flag4)
						{
							string text2 = num3.ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6490]");
							num = 0;
							string text3 = (string)num6 + (string)((int*)num)->m_value + text2;
							text = text3;
						}
						num2 = 0;
						obj2 = 7;
						obj3 = 0;
						text4 = (string)num6;
						enumerator2 = enumerator5;
						num7 = 0;
						obj4 = 0;
						Dictionary<System.__Canon, int>.Enumerator enumerator6 = (Dictionary<System.__Canon, int>.Enumerator)num6;
						enumerator3 = enumerator5;
						enumerator7 = (Dictionary<System.__Canon, int>.Enumerator)(&enumerator2);
						gillaRecycler = this;
					}
					else
					{
						num2 = 0;
						obj2 = 2;
						obj3 = 0;
						num3 = 0;
						text4 = (string)num6;
						enumerator2 = enumerator5;
						num7 = 0;
						obj4 = 0;
						Dictionary<System.__Canon, int>.Enumerator enumerator6 = (Dictionary<System.__Canon, int>.Enumerator)num6;
						enumerator3 = enumerator5;
						enumerator7 = (Dictionary<System.__Canon, int>.Enumerator)(&enumerator2);
						num = num8;
						gillaRecycler = this;
						text = null;
					}
					object obj6 = default;
					string result = default;
					while (true)
					{
						num4 = (nint)obj;
						((Dictionary<System.__Canon, int>.Enumerator*)enumerator7)->Dispose();
						bool flag5 = obj3 == null;
						object obj5 = !flag5;
						if (obj5 != null)
						{
							OutOfMemoryException ex = new OutOfMemoryException();
							switch ((long)num4)
							{
							case 2L:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								obj3 = obj4;
								num7 = 1;
								num = 1;
								break;
							case 1L:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								obj3 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								obj4 = obj6;
								break;
							default:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DA10");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return result;
							}
							obj2 = 0;
							text = null;
							continue;
						}
						break;
					}
					bool flag6 = num7 == 0;
					object obj7 = !flag6;
					enumerator = (Dictionary<System.__Canon, int>.Enumerator)text4;
					ex2 = (NullReferenceException)enumerator7;
					num = num7;
					if (obj7 != null)
					{
						goto IL_03e8;
					}
					num = obj2 | 2;
					bool flag7 = num != 2;
					enumerator = (Dictionary<System.__Canon, int>.Enumerator)text4;
					string result2 = text;
					if (flag7)
					{
						return result2;
					}
				}
				bool flag8 = (object)gillaRecycler.kinds == null;
				num2 = 0;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6498]");
					object obj8 = 0;
					Dictionary<System.__Canon, int>.Enumerator enumerator8 = ((Dictionary<System.__Canon, int>)(object)gillaRecycler.kinds).GetEnumerator();
					num2 = 0;
					num = num8;
					int num9 = 0;
					while (enumerator2.MoveNext())
					{
						num9 += num5;
						num2 = num9;
						num = num5;
					}
					num4 = (nint)obj;
					enumerator2.Dispose();
					enumerator = (Dictionary<System.__Canon, int>.Enumerator)num7;
					Dictionary<System.__Canon, int>.Enumerator enumerator9 = default;
					enumerator2 = enumerator9;
					num7 = 0;
					object obj4 = 0;
					Dictionary<System.__Canon, int>.Enumerator enumerator6 = (Dictionary<System.__Canon, int>.Enumerator)0;
					enumerator3 = enumerator9;
					Dictionary<System.__Canon, int>.Enumerator enumerator7 = (Dictionary<System.__Canon, int>.Enumerator)(&enumerator2);
					gillaRecycler = null;
					goto IL_03f7;
				}
			}
			goto IL_03d2;
			IL_03f7:
			text4 = (string)enumerator;
			throw new OutOfMemoryException();
			IL_03e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_03f7;
			IL_03d2:
			ex2 = new NullReferenceException();
			num7 = num7;
			goto IL_03e8;
		}
	}

	private unsafe string Most
	{
		get
		{
			//IL_0018: Expected Obj, but got I
			//IL_0028: Expected Obj, but got I
			//IL_0050: Expected VT, but got I4
			//IL_0059: Expected Obj, but got I4
			//IL_0126: Expected Obj, but got I4
			//IL_012f: Expected Obj, but got I4
			//IL_0137: Expected VT, but got Ref
			//IL_0141: Expected Obj, but got I4
			//IL_02df: Expected I, but got Obj
			//IL_0302: Expected Obj, but got I4
			//IL_00d9: Expected Obj, but got I4
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected Obj, but got Unknown
			//IL_01ea: Expected Obj, but got I4
			//IL_0160: Expected Obj, but got I4
			//IL_0168: Expected Obj, but got Ref
			//IL_02b5: Expected Obj, but got I4
			//IL_017f: Invalid comparison between VT and I4
			//IL_0118: Expected VT, but got I4
			//IL_023b: Expected Obj, but got I4
			//IL_01ab: Expected Obj, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6468]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object result = 0;
			Dictionary<System.__Canon, int>.Enumerator enumerator = ((Dictionary<System.__Canon, int>)(object)kinds).GetEnumerator();
			object obj3 = default;
			object obj2 = obj3;
			object obj5 = default;
			object obj4 = obj5;
			Dictionary<System.__Canon, int>.Enumerator enumerator2 = (Dictionary<System.__Canon, int>.Enumerator)0;
			object obj6 = 0;
			Dictionary<System.__Canon, int>.Enumerator enumerator3 = default;
			object obj8 = default;
			while (enumerator3.MoveNext())
			{
				object obj7 = obj6 - obj8;
				bool flag = (nint)obj7 < 0;
				bool flag2 = obj7 == null;
				object obj9 = obj6 ^ obj8;
				object obj10 = obj6 ^ obj7;
				object obj11 = obj9 & obj10;
				bool flag3 = (nint)obj11 < 0;
				bool flag4 = flag == flag3;
				obj4 = !flag2;
				object obj12 = flag4 & obj4;
				object obj13 = ~obj12;
				if (obj13 != null)
				{
					obj6 = obj8;
				}
				bool flag5 = flag == flag3;
				object obj14 = !flag5;
				obj2 = ~obj14;
				if (obj2 == null)
				{
					enumerator2 = (Dictionary<System.__Canon, int>.Enumerator)0;
				}
			}
			object obj15 = 0;
			object obj16 = 0;
			Dictionary<System.__Canon, int>.Enumerator enumerator4 = (Dictionary<System.__Canon, int>.Enumerator)(&enumerator3);
			object obj17 = 0;
			object obj20 = default;
			object obj21 = default;
			Dictionary<System.__Canon, int>.Enumerator enumerator5 = default;
			IntPtr intPtr = default;
			object obj22 = default;
			object obj23 = default;
			string result2 = default;
			while (true)
			{
				nint num = (nint)obj;
				enumerator3.Dispose();
				bool flag6 = obj17 == null;
				object obj18 = !flag6;
				if (obj18 == null)
				{
					bool flag7 = obj15 == null;
					object obj19 = !flag7;
					OutOfMemoryException ex = (OutOfMemoryException)(&enumerator3);
					if (obj19 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
					obj15 = obj20;
					obj16 = obj21;
					enumerator2 = enumerator5;
					num = intPtr;
					obj = obj22;
					result = 109891584;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				switch ((long)num)
				{
				case 2L:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj15 = 1;
					obj17 = obj16;
					break;
				case 1L:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj17 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj16 = obj23;
					break;
				default:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DA10");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return result2;
				}
			}
			if (enumerator2 == (Dictionary<System.__Canon, int>.Enumerator)(object)0)
			{
				return (string)result;
			}
			return (string)enumerator2;
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
		//IL_070f: Expected Obj, but got I4
		//IL_081a: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I4
		//IL_0303: Expected Obj, but got I
		//IL_032d: Expected Obj, but got I4
		//IL_036d: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_072d: Expected Obj, but got I
		//IL_073d: Expected Obj, but got I
		//IL_038b: Expected Obj, but got I
		//IL_03b5: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I4
		//IL_0410: Expected Obj, but got I
		//IL_01b7: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I
		//IL_01fb: Expected Obj, but got I
		//IL_021b: Expected Obj, but got I
		//IL_023d: Expected Obj, but got I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_046d: Expected Obj, but got I
		//IL_0752: Expected Obj, but got I
		//IL_0762: Expected Obj, but got I
		//IL_0784: Expected Obj, but got I4
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected Obj, but got Unknown
		//IL_04bc: Expected Obj, but got I
		//IL_02c9: Expected Obj, but got I
		//IL_02e6: Expected Obj, but got I
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected Obj, but got Unknown
		//IL_0514: Expected Obj, but got I4
		//IL_0284: Expected Obj, but got I4
		//IL_0559: Expected Obj, but got I4
		//IL_07a2: Expected Obj, but got I
		//IL_07bc: Expected Obj, but got I
		//IL_07cd: Expected I, but got Obj
		//IL_07eb: Expected Obj, but got I
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected Obj, but got Unknown
		//IL_0606: Expected Obj, but got I4
		//IL_02b4: Expected Obj, but got I
		//IL_064b: Expected Obj, but got I4
		//IL_058b: Expected Obj, but got I
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected Obj, but got Unknown
		//IL_05b0: Expected Obj, but got I4
		//IL_067d: Expected Obj, but got I
		//IL_06a2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6288]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+68]");
		bool flag2 = ((List<System.__Canon>)0).Contains((System.__Canon)(object)this);
		bool flag3 = !flag2;
		object obj7 = !flag3;
		Comparison<System.__Canon> comparison = (Comparison<System.__Canon>)(object)this;
		if (obj7 == null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v58+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v58+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v31+68]");
			List<System.__Canon> list = (List<System.__Canon>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6280]");
			object obj11 = 0;
			System.__Canon[] items = list._items;
			object obj12 = obj11;
			int version = list._version + 1;
			list._version = version;
			bool flag5 = list._size < items.Length;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				object obj14 = items + list._size;
				int size = list._size + 1;
				list._size = size;
				object obj15 = obj14 + 32;
				obj15 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				System.__Canon _Canon = (System.__Canon)(object)this;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X9_v5+20]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v46+A8]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v47+70]");
				obj6 = 0;
				list.AddWithResize((System.__Canon)(object)this);
				System.__Canon _Canon = (System.__Canon)(object)this;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62A0]");
			object obj18 = 0;
			object obj19 = obj;
			object obj20 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v34+A0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v62+E4]");
			bool flag6 = (nint)0 == 0;
			object obj22 = !flag6;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj20 = obj18;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v62+A0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v40+8]");
			Comparison<System.__Canon> comparison2 = (Comparison<System.__Canon>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v40+8]");
			bool flag7 = (nint)0 == 0;
			object obj24 = !flag7;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v62+E4]");
				bool flag8 = (nint)0 == 0;
				object obj25 = !flag8;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj26 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v44+A0]");
					obj23 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6278]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6298]");
				object obj28 = 0;
				Comparison<System.__Canon> comparison3 = default;
				comparison3._002Ector(obj23, (IntPtr)obj28);
				object obj29 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v43+A0]");
				object obj30 = (nint)0 + (nint)8;
				obj30 = comparison3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				comparison2 = comparison3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6290]");
			object obj31 = 0;
			obj6 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v35+68]");
			((List<System.__Canon>)0).Sort(comparison2);
			comparison = comparison2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj32 = 0;
		object obj33 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v9+E4]");
		bool flag9 = (nint)0 == 0;
		object obj34 = !flag9;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isPlaying = Application.isPlaying;
		bool flag10 = !isPlaying;
		object obj35 = !flag10;
		if (obj35 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj36 = 0;
		object obj37 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v14+E4]");
		bool flag11 = (nint)0 == 0;
		object obj38 = !flag11;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(screen == null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Texture2D texture2D = default;
			texture2D._002Ector(512, 256, (TextureFormat)4, mipChain: true);
			texture2D.filterMode = (FilterMode)0;
			texture2D.wrapMode = (TextureWrapMode)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62A8]");
			object obj40 = 0;
			texture2D.name = (string)obj40;
			texture2D.hideFlags = (HideFlags)52;
			object obj41 = this + 320;
			tex = texture2D;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Color32[] array = default;
			px = array;
			object obj43 = this + 328;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj44 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v30+E4]");
			bool flag12 = (nint)0 == 0;
			object obj45 = !flag12;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag13 = titleFont != null;
			bool flag14 = !flag13;
			object obj46 = 0;
			ScreenFont screenFont = null;
			if (!flag14)
			{
				string baked = titleFont.text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
				object obj47 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ScreenFont screenFont2 = default;
				screenFont2._002Ector(baked);
				obj46 = 0;
				screenFont = screenFont2;
			}
			object obj48 = this + 352;
			title = screenFont;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj49 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v37+E4]");
			bool flag15 = (nint)0 == 0;
			object obj50 = !flag15;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag16 = textFont != null;
			bool flag17 = !flag16;
			object obj51 = 0;
			ScreenFont screenFont3 = null;
			if (!flag17)
			{
				string baked2 = textFont.text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
				object obj52 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ScreenFont screenFont4 = default;
				screenFont4._002Ector(baked2);
				obj51 = 0;
				screenFont3 = screenFont4;
			}
			object obj53 = this + 360;
			text = screenFont3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			awake = 0f;
			Draw();
		}
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0fd9: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_0115: Expected Obj, but got I
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_0153: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_028e: Expected Obj, but got I4
		//IL_02d3: Expected Obj, but got I4
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected Obj, but got Unknown
		//IL_0385: Expected Obj, but got I
		//IL_03af: Expected Obj, but got I4
		//IL_0ff7: Expected Obj, but got I
		//IL_1007: Expected Obj, but got I
		//IL_1029: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I
		//IL_043b: Expected Obj, but got I
		//IL_0238: Expected Obj, but got I4
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_04aa: Expected Obj, but got I4
		//IL_03f6: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got I
		//IL_04ef: Expected Obj, but got I4
		//IL_1050: Expected Obj, but got I
		//IL_106a: Expected Obj, but got I
		//IL_107b: Expected I, but got Obj
		//IL_1099: Expected Obj, but got I
		//IL_0349: Expected Obj, but got I4
		//IL_0426: Expected Obj, but got I
		//IL_1518: Expected Obj, but got I
		//IL_1538: Expected Obj, but got I
		//IL_155a: Expected Obj, but got I4
		//IL_051a: Expected I4, but got I8
		//IL_0534: Expected Obj, but got I4
		//IL_053d: Expected Obj, but got I4
		//IL_08b8: Expected Obj, but got I
		//IL_08e2: Expected Obj, but got I4
		//IL_1113: Expected Obj, but got I
		//IL_1135: Expected Obj, but got I4
		//IL_1578: Expected Obj, but got I
		//IL_1588: Expected Obj, but got I
		//IL_15aa: Expected Obj, but got I4
		//IL_10de: Expected Obj, but got I
		//IL_0985: Expected Obj, but got I
		//IL_09c0: Expected Obj, but got I4
		//IL_11d4: Expected Obj, but got I
		//IL_11e4: Expected Obj, but got I
		//IL_1206: Expected Obj, but got I4
		//IL_0940: Expected Obj, but got I4
		//IL_05bd: Expected Obj, but got I4
		//IL_0a4c: Expected Obj, but got I
		//IL_0a80: Expected Obj, but got I4
		//IL_1153: Expected Obj, but got I
		//IL_116d: Expected Obj, but got I
		//IL_117e: Expected I, but got Obj
		//IL_119c: Expected Obj, but got I
		//IL_0cb2: Expected Obj, but got I
		//IL_0ccc: Expected Obj, but got I
		//IL_12a5: Expected Obj, but got I
		//IL_12b5: Expected Obj, but got I
		//IL_12d7: Expected Obj, but got I4
		//IL_0a07: Expected Obj, but got I4
		//IL_0970: Expected Obj, but got I
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf0: Expected Obj, but got Unknown
		//IL_0d24: Expected Obj, but got I4
		//IL_0b0c: Expected Obj, but got I
		//IL_0b47: Expected Obj, but got I4
		//IL_1224: Expected Obj, but got I
		//IL_123e: Expected Obj, but got I
		//IL_124f: Expected I, but got Obj
		//IL_126d: Expected Obj, but got I
		//IL_1376: Expected Obj, but got I
		//IL_1386: Expected Obj, but got I
		//IL_13a8: Expected Obj, but got I4
		//IL_0ac7: Expected Obj, but got I4
		//IL_0a37: Expected Obj, but got I
		//IL_0bd3: Expected Obj, but got I
		//IL_0c07: Expected Obj, but got I4
		//IL_12f5: Expected Obj, but got I
		//IL_130f: Expected Obj, but got I
		//IL_1320: Expected I, but got Obj
		//IL_133e: Expected Obj, but got I
		//IL_1447: Expected Obj, but got I
		//IL_1457: Expected Obj, but got I
		//IL_1479: Expected Obj, but got I4
		//IL_0b8e: Expected Obj, but got I4
		//IL_0af7: Expected Obj, but got I
		//IL_063c: Expected Obj, but got I4
		//IL_0c93: Expected Obj, but got I
		//IL_13c6: Expected Obj, but got I
		//IL_13e0: Expected Obj, but got I
		//IL_13f1: Expected I, but got Obj
		//IL_140f: Expected Obj, but got I
		//IL_0da6: Expected Obj, but got I
		//IL_0dc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc5: Expected Obj, but got Unknown
		//IL_0c4e: Expected Obj, but got I4
		//IL_0bbe: Expected Obj, but got I
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected Obj, but got Unknown
		//IL_0683: Expected Obj, but got I4
		//IL_1497: Expected Obj, but got I
		//IL_14b1: Expected Obj, but got I
		//IL_14c2: Expected I, but got Obj
		//IL_14e0: Expected Obj, but got I
		//IL_06b2: Expected Obj, but got I
		//IL_06ce: Expected Obj, but got I4
		//IL_0c7e: Expected Obj, but got I
		//IL_0e69: Expected F4, but got I
		//IL_074d: Expected Obj, but got I4
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected Obj, but got Unknown
		//IL_077a: Expected Obj, but got I
		//IL_07a4: Expected Obj, but got I4
		//IL_0ed2: Expected F4, but got I
		//IL_07fe: Expected Obj, but got I
		//IL_082b: Expected Obj, but got I
		//IL_0851: Expected Obj, but got I4
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Texture2D texture2D = default;
		texture2D._002Ector(512, 256, (TextureFormat)4, mipChain: true);
		if ((object)texture2D == null)
		{
			goto IL_0f9a;
		}
		texture2D.filterMode = (FilterMode)0;
		texture2D.wrapMode = (TextureWrapMode)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62A8]");
		object obj5 = 0;
		texture2D.name = (string)obj5;
		object obj6 = this + 320;
		tex = texture2D;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Color32[] array = default;
		px = array;
		object obj8 = this + 328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v21+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = titleFont != null;
		bool flag4 = !flag3;
		object obj12 = 0;
		ScreenFont screenFont = null;
		if (!flag4)
		{
			if ((object)titleFont == null)
			{
				goto IL_0f9a;
			}
			string baked = titleFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont2 = default;
			screenFont2._002Ector(baked);
			obj12 = 0;
			screenFont = screenFont2;
		}
		object obj14 = this + 352;
		title = screenFont;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v28+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = textFont != null;
		bool flag7 = !flag6;
		object obj17 = 0;
		ScreenFont screenFont3 = null;
		if (!flag7)
		{
			if ((object)textFont == null)
			{
				goto IL_0f9a;
			}
			string baked2 = textFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont4 = default;
			screenFont4._002Ector(baked2);
			obj17 = 0;
			screenFont3 = screenFont4;
		}
		object obj19 = this + 360;
		text = screenFont3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62A0]");
		object obj20 = 0;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v36+E4]");
		bool flag8 = (nint)0 == 0;
		object obj22 = !flag8;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v36+A0]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v119+10]");
		Func<System.__Canon, Quaternion> selector = (Func<System.__Canon, Quaternion>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v119+10]");
		bool flag9 = (nint)0 == 0;
		object obj24 = !flag9;
		TextureFormat textureFormat = (TextureFormat)4;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v36+E4]");
			bool flag10 = (nint)0 == 0;
			object obj25 = !flag10;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj26 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v123+A0]");
				obj23 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6320]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6330]");
			object obj28 = 0;
			Func<System.__Canon, Quaternion> func = default;
			func._002Ector(obj23, (IntPtr)obj28);
			object obj29 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v122+A0]");
			object obj30 = (nint)0 + (nint)16;
			obj30 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			textureFormat = (TextureFormat)0;
			selector = func;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62D0]");
		object obj31 = 0;
		IEnumerable<Quaternion> source = Enumerable.Select((IEnumerable<System.__Canon>)(object)spinners, selector);
		Quaternion[] array2 = Enumerable.ToArray(source);
		rest = array2;
		object obj32 = this + 408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj33 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v43+E4]");
		bool flag11 = (nint)0 == 0;
		object obj34 = !flag11;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag12 = body != null;
		bool flag13 = !flag12;
		object obj35 = 0;
		int num = 0;
		if (!flag13)
		{
			int num2 = (int)(lampSlot & 0x80000000L);
			bool flag14 = num2 == 0;
			object obj36 = !flag14;
			obj35 = 0;
			num = 0;
			if (obj36 == null)
			{
				if ((object)body != null)
				{
					Material[] sharedMaterials = body.sharedMaterials;
					if (sharedMaterials != null)
					{
						bool flag15 = lampSlot >= sharedMaterials.Length;
						obj35 = 0;
						num = 0;
						if (flag15)
						{
							goto IL_1508;
						}
						if ((object)body != null)
						{
							Material[] sharedMaterials2 = body.sharedMaterials;
							if (sharedMaterials2 != null)
							{
								bool flag16 = lampSlot < sharedMaterials2.Length;
								object obj37 = !flag16;
								if (obj37 != null)
								{
									goto IL_0fa8;
								}
								object obj38 = obj9;
								object obj39 = sharedMaterials2 + lampSlot;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v114+E4]");
								bool flag17 = (nint)0 == 0;
								object obj40 = !flag17;
								if (obj40 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X9_v34+20]");
								bool flag18 = (UnityEngine.Object)0 != null;
								bool flag19 = !flag18;
								obj35 = 0;
								num = 0;
								if (flag19)
								{
									goto IL_1508;
								}
								if ((object)body != null)
								{
									Material[] sharedMaterials3 = body.sharedMaterials;
									if (sharedMaterials3 != null)
									{
										bool flag20 = lampSlot < sharedMaterials3.Length;
										object obj41 = !flag20;
										if (obj41 != null)
										{
											goto IL_0fa8;
										}
										object obj42 = sharedMaterials3 + lampSlot;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6270]");
										object obj43 = 0;
										object obj44 = obj43;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v116+E4]");
										bool flag21 = (nint)0 == 0;
										object obj45 = !flag21;
										if (obj45 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X9_v36+20]");
										if ((nint)0 != 0)
										{
											object obj46 = obj43;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X8_v117+A0]");
											object obj47 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v118+4]");
											num = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X9_v36+20]");
											nint num3 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v118+4]");
											Color color = ((Material)num3).GetColor(0);
											Color color2 = default;
											lampColour = color2;
											obj35 = 0;
											goto IL_1508;
										}
									}
								}
							}
						}
					}
				}
				goto IL_0f9a;
			}
		}
		goto IL_1508;
		IL_1508:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53B0]");
		object obj48 = 0;
		object obj49 = obj9;
		object obj50 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v27+A0]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X0_v49+E4]");
		bool flag22 = (nint)0 == 0;
		object obj52 = !flag22;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj51 != null)
		{
			object obj53 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v108+A0]");
			object obj54 = 0;
			if (obj54 == null)
			{
				goto IL_0f9a;
			}
			(string, int)[] array3 = ((GillaItemDirector)obj54).Prices();
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
			object obj55 = 0;
			object obj56 = obj55;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v41+E4]");
			bool flag23 = (nint)0 == 0;
			object obj57 = !flag23;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj56 = obj55;
			}
			object obj58 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v41+A0]");
			object source2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X0_v81+E4]");
			bool flag24 = (nint)0 == 0;
			object obj59 = !flag24;
			if (obj59 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj58 = obj20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X0_v81+A0]");
			object obj60 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v99+18]");
			Func<System.__Canon, bool> predicate = (Func<System.__Canon, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v99+18]");
			bool flag25 = (nint)0 == 0;
			object obj61 = !flag25;
			if (obj61 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X0_v81+E4]");
				bool flag26 = (nint)0 == 0;
				object obj62 = !flag26;
				if (obj62 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj63 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X8_v103+A0]");
					obj60 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6318]");
				object obj64 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6338]");
				object obj65 = 0;
				Func<System.__Canon, bool> func2 = default;
				func2._002Ector(obj60, (IntPtr)obj65);
				object obj66 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v102+A0]");
				object obj67 = (nint)0 + (nint)24;
				obj67 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				textureFormat = (TextureFormat)0;
				predicate = func2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62F8]");
			object obj68 = 0;
			IEnumerable<System.__Canon> enumerable = Enumerable.Where((IEnumerable<System.__Canon>)source2, predicate);
			object obj69 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v48+E4]");
			bool flag27 = (nint)0 == 0;
			object obj70 = !flag27;
			if (obj70 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj69 = obj20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v48+A0]");
			object obj71 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X9_v28+20]");
			Func<System.__Canon, System.__Canon> func3 = (Func<System.__Canon, System.__Canon>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X9_v28+20]");
			bool flag28 = (nint)0 == 0;
			object obj72 = !flag28;
			if (obj72 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v48+E4]");
				bool flag29 = (nint)0 == 0;
				object obj73 = !flag29;
				if (obj73 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj74 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v97+A0]");
					obj71 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6328]");
				object obj75 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6340]");
				object obj76 = 0;
				Func<System.__Canon, System.__Canon> func4 = default;
				func4._002Ector(obj71, (IntPtr)obj76);
				object obj77 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v96+A0]");
				object obj78 = (nint)0 + (nint)32;
				obj78 = func4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				textureFormat = (TextureFormat)0;
				func3 = func4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62B8]");
			object obj79 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35CC3C0");
			object obj80 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X8_v53+E4]");
			bool flag30 = (nint)0 == 0;
			object obj81 = !flag30;
			if (obj81 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj80 = obj20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X8_v53+A0]");
			object obj82 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X9_v26+28]");
			Func<System.__Canon, (System.__Canon, int)> selector2 = (Func<System.__Canon, (System.__Canon, int)>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X9_v26+28]");
			bool flag31 = (nint)0 == 0;
			object obj83 = !flag31;
			if (obj83 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X8_v53+E4]");
				bool flag32 = (nint)0 == 0;
				object obj84 = !flag32;
				if (obj84 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj85 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v89+A0]");
					obj82 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6310]");
				object obj86 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6348]");
				object obj87 = 0;
				Func<System.__Canon, (System.__Canon, int)> func5 = default;
				func5._002Ector(obj82, (IntPtr)obj87);
				object obj88 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v88+A0]");
				object obj89 = (nint)0 + (nint)40;
				obj89 = func5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				textureFormat = (TextureFormat)0;
				selector2 = func5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62C8]");
			object obj90 = 0;
			IEnumerable<System.__Canon> source3 = default;
			IEnumerable<(System.__Canon, int)> enumerable2 = Enumerable.Select(source3, selector2);
			object obj91 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X8_v58+E4]");
			bool flag33 = (nint)0 == 0;
			object obj92 = !flag33;
			if (obj92 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj91 = obj20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X8_v58+A0]");
			object obj93 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X9_v24+30]");
			Func<(System.__Canon, int), int> func6 = (Func<(System.__Canon, int), int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X9_v24+30]");
			bool flag34 = (nint)0 == 0;
			object obj94 = !flag34;
			if (obj94 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X8_v58+E4]");
				bool flag35 = (nint)0 == 0;
				object obj95 = !flag35;
				if (obj95 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj96 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v81+A0]");
					obj93 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6300]");
				object obj97 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6350]");
				object obj98 = 0;
				Func<(System.__Canon, int), int> func7 = default;
				func7._002Ector(obj93, (IntPtr)obj98);
				object obj99 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X8_v80+A0]");
				object obj100 = (nint)0 + (nint)48;
				obj100 = func7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				textureFormat = (TextureFormat)0;
				func6 = func7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62C0]");
			object obj101 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35CFB94");
			object obj102 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ X8_v63+E4]");
			bool flag36 = (nint)0 == 0;
			object obj103 = !flag36;
			if (obj103 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj102 = obj20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ X8_v63+A0]");
			object obj104 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X9_v22+38]");
			Func<(System.__Canon, int), System.__Canon> func8 = (Func<(System.__Canon, int), System.__Canon>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X9_v22+38]");
			bool flag37 = (nint)0 == 0;
			object obj105 = !flag37;
			if (obj105 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ X8_v63+E4]");
				bool flag38 = (nint)0 == 0;
				object obj106 = !flag38;
				if (obj106 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj107 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X8_v73+A0]");
					obj104 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6308]");
				object obj108 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6358]");
				object obj109 = 0;
				Func<(System.__Canon, int), System.__Canon> func9 = default;
				func9._002Ector(obj104, (IntPtr)obj109);
				object obj110 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X8_v72+A0]");
				object obj111 = (nint)0 + (nint)56;
				obj111 = func9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				textureFormat = (TextureFormat)0;
				func8 = func9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62E0]");
			object obj112 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35E1664");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62D8]");
		object obj113 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35E1150");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62F0]");
		object obj114 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35E1D90");
		(string, int)[] array4 = default;
		prices = array4;
		object obj115 = this + 440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj116 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X0_v58+E4]");
		bool flag39 = (nint)0 == 0;
		object obj117 = !flag39;
		if (obj117 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(hum != null))
		{
			goto IL_0f93;
		}
		GameObject gameObject = base.gameObject;
		if ((object)gameObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4350]");
			object obj118 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			AudioSource audioSource = default;
			humming = audioSource;
			object obj119 = this + 368;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if ((object)humming != null)
			{
				humming.clip = hum;
				if ((object)humming != null)
				{
					humming.loop = true;
					if ((object)humming != null)
					{
						AudioSource audioSource2 = humming;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
						audioSource2.volume = 0f;
						if ((object)humming != null)
						{
							humming.spatialBlend = 1f;
							if ((object)humming != null)
							{
								AudioSource audioSource3 = humming;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
								audioSource3.minDistance = 0f;
								if ((object)humming != null)
								{
									humming.maxDistance = 14f;
									if ((object)humming != null)
									{
										humming.rolloffMode = (AudioRolloffMode)1;
										if ((object)humming != null)
										{
											humming.dopplerLevel = 0f;
											if ((object)humming != null)
											{
												humming.Play();
												goto IL_0f93;
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
		goto IL_0f9a;
		IL_0f9a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0fa8;
		IL_0fa8:
		throw new IndexOutOfRangeException();
		IL_0f93:
		Draw();
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_030d: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I4
		//IL_0326: Invalid comparison between F4 and I4
		//IL_01bb: Invalid comparison between F4 and I4
		//IL_014d: Expected Obj, but got I4
		//IL_034c: Expected Obj, but got I4
		//IL_0214: Invalid comparison between F8 and I4
		//IL_022e: Expected Obj, but got F8
		//IL_023d: Expected Obj, but got F8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj4 = 0;
		float deltaTime = Time.deltaTime;
		Wake(deltaTime);
		Swallow();
		GoDown(deltaTime);
		Grind();
		Count(deltaTime);
		Spin(deltaTime);
		Lamps(deltaTime);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int bolts = Coins.Bolts;
		if (bolts != lastBalance)
		{
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v23+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int bolts2 = Coins.Bolts;
			lastBalance = bolts2;
			dirty = true;
		}
		bool flag4;
		if ((!(awake > 0f) || !((double)awake < 1.0)) && shown < 0f)
		{
			flag4 = wanted;
			if (~(wanted ? 1u : 0u) == 0)
			{
				double num = (double)awake - 1.0;
				bool flag5 = num < 0.0;
				object obj9 = (double)awake ^ 1.0;
				object obj10 = (double)awake ^ num;
				object obj11 = obj9 & obj10;
				bool flag6 = (nint)obj11 < 0;
				bool flag7 = flag5 == flag6;
				flag4 = flag7;
			}
		}
		else
		{
			flag4 = true;
		}
		object obj12 = flag4 | dirty;
		if (obj12 != null)
		{
			float time = Time.time;
			if (!(time < nextDraw))
			{
				float time2 = Time.time;
				float num2 = time2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				float num3 = num2 + 0f;
				nextDraw = num3;
				Draw();
			}
		}
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6270]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+68]");
		bool flag2 = ((List<System.__Canon>)0).Remove((System.__Canon)(object)this);
	}

	public static GillaRecycler Number(int i)
	{
		//IL_0148: Expected I4, but got I8
		//IL_0162: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0180: Expected Obj, but got I
		//IL_0190: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I
		//IL_00ea: Expected Obj, but got I
		int num = (int)(i & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6270]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v5+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v5+68]");
			List<System.__Canon> list = (List<System.__Canon>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v5+68]");
			if ((nint)0 == 0)
			{
				goto IL_0128;
			}
			if (list._size > i)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v5+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v9+A0]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v10+68]");
					list = (List<System.__Canon>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v10+68]");
					if ((nint)0 == 0)
					{
						goto IL_0128;
					}
				}
				return (GillaRecycler)(object)list.get_Item(i);
			}
		}
		return null;
		IL_0128:
		return (GillaRecycler)(object)new NullReferenceException();
	}

	public static bool Inside(Transform box, Vector3 p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0230: Expected Obj, but got I4
		//IL_0206: Expected I4, but got Obj
		//IL_0088: Expected VT, but got I4
		//IL_00a3: Invalid comparison between Obj and F8
		//IL_00b4: Expected Obj, but got I4
		//IL_00d1: Invalid comparison between F8 and I4
		//IL_00e2: Expected Obj, but got I4
		//IL_011d: Invalid comparison between Obj and F8
		//IL_012e: Expected Obj, but got I4
		//IL_014b: Invalid comparison between F8 and I4
		//IL_015c: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I4
		//IL_01cf: Invalid comparison between F8 and I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected I4, but got Unknown
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
		bool result;
		if (box == null)
		{
			result = false;
		}
		else
		{
			if ((object)box == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			Vector3 vector = box.InverseTransformPoint((Vector3)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			object obj4 = default;
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.5);
			object obj5 = !flag2;
			double num = (double)obj4 - 0.5;
			bool flag3 = num == 0.0;
			object obj6 = !flag3;
			object obj7 = obj5 & obj6;
			result = false;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				object obj8 = default;
				bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.5);
				object obj9 = !flag4;
				double num2 = (double)obj8 - 0.5;
				bool flag5 = num2 == 0.0;
				object obj10 = !flag5;
				object obj11 = obj9 & obj10;
				result = false;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					bool flag6 = 0.5 < 0.5;
					object obj12 = !flag6;
					double num3 = 0.5 - 0.5;
					bool flag7 = num3 == 0.0;
					object obj13 = ~obj12;
					bool flag8 = (byte)((obj13 | flag7) ? 1 : 0) != 0;
					result = flag8;
				}
			}
		}
		return result;
	}

	private unsafe void Swallow()
	{
		//IL_0010: Expected Obj, but got I
		//IL_064a: Expected I, but got Obj
		//IL_066c: Expected Obj, but got I4
		//IL_0782: Expected Obj, but got I
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Expected Obj, but got I4
		//IL_0027: Expected I, but got Obj
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got I4
		//IL_068a: Expected I, but got Obj
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected Obj, but got I4
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected Obj, but got I4
		//IL_071e: Expected I, but got Obj
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected Ref, but got Unknown
		//IL_0741: Expected Obj, but got I4
		//IL_0555: Expected I4, but got Obj
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got I4
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected I4, but got Obj
		//IL_04ed: Expected Obj, but got I4
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected Obj, but got Unknown
		//IL_04fd: Expected I4, but got Obj
		//IL_00b7: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I4
		//IL_0588: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I4
		//IL_05dd: Expected Obj, but got I4
		//IL_05e6: Expected Obj, but got I4
		//IL_017a: Expected I4, but got I8
		//IL_0196: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I4
		//IL_01d7: Expected Obj, but got I4
		//IL_020e: Expected Obj, but got I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got I4
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected I, but got Obj
		//IL_0299: Expected Obj, but got I
		//IL_02bb: Expected Obj, but got I4
		//IL_02e6: Expected VT, but got I4
		//IL_0304: Expected Obj, but got I4
		//IL_030a: Expected I, but got Obj
		//IL_0445: Expected Obj, but got I4
		//IL_06c4: Expected Obj, but got I
		//IL_06d2: Invalid comparison between VT and I4
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Expected Obj, but got I4
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected I4, but got Obj
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got I4
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected I, but got Obj
		//IL_0479: Expected Obj, but got VT
		//IL_039e: Expected Obj, but got I
		//IL_03c0: Expected Obj, but got I4
		//IL_03eb: Expected VT, but got I4
		//IL_0404: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
		GillaItem gillaItem = (GillaItem)0;
		nint num = (nint)gillaItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2 (Il2CppClass<GillaItem>)+E4]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		nint num2 = num;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num2 = (nint)gillaItem;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3 (Il2CppClass<GillaItem>)+A0]");
		GillaItem gillaItem2 = (GillaItem)0;
		bool flag2 = (object)gillaItem2 == null;
		GillaItem gillaItem4 = default;
		GillaItem gillaItem3 = gillaItem4;
		Enumerator<, > val = (Enumerator<, >)0;
		Transform transform = (Transform)109891584;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5268]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6270]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5260]");
			object obj4 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)gillaItem2).GetEnumerator();
			gillaItem2 = gillaItem4;
			transform = (Transform)109891584;
			Enumerator<, > val2 = default;
			object obj20 = default;
			object obj9;
			Enumerator<, > val3;
			while (true)
			{
				nint num3 = (nint)obj2;
				bool flag8;
				if (val.MoveNext())
				{
					if ((object)gillaItem4 == null)
					{
						break;
					}
					bool flag3 = (byte)(~(gillaItem4.keeps ? 1u : 0u)) != 0;
					object obj5 = !flag3;
					gillaItem2 = (GillaItem)gillaItem4.keeps;
					if (obj5 != null)
					{
						continue;
					}
					bool flag4 = (byte)(~(gillaItem4.recycles ? 1u : 0u)) != 0;
					gillaItem2 = (GillaItem)gillaItem4.recycles;
					if (flag4)
					{
						continue;
					}
					bool flag5 = (byte)(~(gillaItem4.Gone__BackingField ? 1u : 0u)) != 0;
					object obj6 = !flag5;
					gillaItem2 = (GillaItem)gillaItem4.Gone__BackingField;
					if (obj6 != null)
					{
						continue;
					}
					bool flag6 = (byte)(~(gillaItem4.Swallowed__BackingField ? 1u : 0u)) != 0;
					object obj7 = !flag6;
					gillaItem2 = (GillaItem)gillaItem4.Swallowed__BackingField;
					if (obj7 != null)
					{
						continue;
					}
					int num4 = (int)(gillaItem4.Hand__BackingField & 0x80000000L);
					bool flag7 = num4 == 0;
					gillaItem2 = (GillaItem)gillaItem4.Hand__BackingField;
					if (flag7)
					{
						continue;
					}
					flag8 = gillaItem4.Worn__BackingField;
					bool flag9 = (byte)(~(gillaItem4.Worn__BackingField ? 1u : 0u)) != 0;
					object obj8 = !flag9;
					gillaItem2 = (GillaItem)gillaItem4.Worn__BackingField;
					if (obj8 != null)
					{
						continue;
					}
					bool flag10 = gillaItem4.Mine;
					bool flag11 = !flag10;
					gillaItem2 = (GillaItem)gillaItem4.Worn__BackingField;
					if (flag11)
					{
						continue;
					}
					transform = mouth;
					Transform transform2 = gillaItem4.transform;
					bool flag12 = (object)transform2 == null;
					gillaItem3 = null;
					val = val2;
					obj9 = 0;
					val3 = (Enumerator<, >)(ref val);
					num3 = unchecked((nint)null);
					if (flag12)
					{
						goto IL_0569;
					}
					Vector3 position = transform2.position;
					object obj10 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v41+E4]");
					gillaItem2 = (GillaItem)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X0_v41+E4]");
					bool flag13 = (nint)0 == 0;
					object obj11 = !flag13;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag14 = Inside(transform, (Vector3)0);
					bool flag15 = !flag14;
					object obj12 = !flag15;
					num3 = unchecked((nint)null);
					Transform transform3 = transform;
					if (obj12 == null)
					{
						transform = lip;
						Transform transform4 = gillaItem4.transform;
						bool flag16 = (object)transform4 == null;
						gillaItem3 = null;
						val = val2;
						obj9 = 0;
						val3 = (Enumerator<, >)(ref val);
						num3 = unchecked((nint)null);
						if (flag16)
						{
							goto IL_058d;
						}
						Vector3 position2 = transform4.position;
						object obj13 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v57+E4]");
						gillaItem2 = (GillaItem)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v57+E4]");
						bool flag17 = (nint)0 == 0;
						object obj14 = !flag17;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag18 = Inside(transform, (Vector3)0);
						bool flag19 = !flag18;
						num3 = unchecked((nint)null);
						transform3 = transform;
						if (flag19)
						{
							continue;
						}
					}
					object obj15 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v47+E4]");
					bool flag20 = (nint)0 == 0;
					object obj16 = !flag20;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj15 = obj3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v47+A0]");
					gillaItem2 = (GillaItem)0;
					bool flag21 = gillaItem2.InHandTurn__BackingField == (Quaternion)(object)0;
					gillaItem3 = null;
					val = val2;
					obj9 = 0;
					val3 = (Enumerator<, >)(ref val);
					flag8 = (byte)(int)gillaItem2 != 0;
					transform = transform3;
					if (!flag21)
					{
						int recycler = ((List<System.__Canon>)gillaItem2.InHandTurn__BackingField).IndexOf((System.__Canon)(object)this);
						gillaItem4.Swallow(recycler);
						Begin(gillaItem4, moves: true);
						transform = transform3;
						continue;
					}
					goto IL_0577;
				}
				gillaItem3 = null;
				val = val2;
				obj9 = 0;
				val3 = (Enumerator<, >)(ref val);
				object obj17 = 0;
				goto IL_0716;
				IL_0716:
				num3 = (nint)obj4;
				((Enumerator<, >*)val3)->Dispose();
				bool flag22 = obj17 == null;
				object obj18 = !flag22;
				if (obj18 == null)
				{
					bool flag23 = (byte)(int)(~gillaItem3) != 0;
					object obj19 = !flag23;
					OutOfMemoryException ex = (OutOfMemoryException)val3;
					flag8 = (byte)(int)gillaItem3 != 0;
					if (obj19 == null)
					{
						return;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
					flag8 = (byte)(int)gillaItem2 != 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				goto IL_0569;
				IL_058d:
				NullReferenceException ex2 = new NullReferenceException();
				if (num3 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					gillaItem3 = (GillaItem)1;
					gillaItem2 = (GillaItem)1;
					obj17 = obj9;
				}
				else
				{
					if (num3 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D3D4");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj17 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj9 = obj20;
				}
				goto IL_0716;
				IL_0577:
				NullReferenceException ex3 = new NullReferenceException();
				gillaItem2 = (GillaItem)flag8;
				goto IL_058d;
				IL_0569:
				NullReferenceException ex4 = new NullReferenceException();
				goto IL_0577;
			}
			NullReferenceException ex5 = new NullReferenceException();
			gillaItem3 = null;
			val = val2;
			obj9 = 0;
			val3 = (Enumerator<, >)(ref val);
		}
		throw new NullReferenceException();
	}

	public void Watch(GillaItem item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0075: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C63F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GillaReviewBoard._003C_003Ec__DisplayClass103_0 obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6408]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6410]");
		object obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Predicate<System.__Canon> predicate = default;
		predicate._002Ector((object)obj2, (IntPtr)obj4);
		if (!((List<System.__Canon>)(object)going).Exists(predicate))
		{
			Begin((GillaItem)obj5, moves: false);
		}
	}

	private void Begin(GillaItem item, bool moves)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0149: Expected VT, but got F4
		//IL_01ac: Expected Obj, but got I4
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C63E8]");
		object obj = 0;
		List<System.__Canon> list = (List<System.__Canon>)(object)this.going;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Going going = default;
		going._002Ector();
		object obj2 = going + 16;
		obj2 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Transform transform = item.transform;
		Vector3 position = transform.position;
		Vector3 vector = default;
		going.from = vector;
		Transform transform2 = item.transform;
		Quaternion rotation = transform2.rotation;
		going.turn = (Quaternion)vector;
		Transform transform3 = item.transform;
		Vector3 localScale = transform3.localScale;
		going.size = vector;
		Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
		float num = UnityEngine.Random.Range(220f, 420f);
		float num2 = (float)vector * num;
		object obj3 = default;
		float num3 = (float)obj3 * num;
		going.moves = moves;
		object obj4 = default;
		float num4 = (float)obj4 * num;
		going.spin = (Vector3)num2;
		System.__Canon[] items = list._items;
		int version = list._version + 1;
		list._version = version;
		bool flag = list._size < items.Length;
		object obj5 = !flag;
		if (obj5 == null)
		{
			object obj6 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj7 = obj6 + 32;
			obj7 = going;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			list.AddWithResize((System.__Canon)(object)going);
		}
		dirty = true;
	}

	private void GoDown(float dt)
	{
		//IL_094b: Expected F8, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I
		//IL_00cb: Expected F4, but got I
		//IL_0ba5: Expected F8, but got I
		//IL_0bbe: Expected Obj, but got I4
		//IL_097c: Invalid comparison between F4 and I4
		//IL_0993: Expected Obj, but got F4
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected Obj, but got Unknown
		//IL_0b2c: Invalid comparison between F8 and I4
		//IL_0b3f: Expected Obj, but got F8
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected Obj, but got Unknown
		//IL_0b7e: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I4
		//IL_09db: Expected F8, but got I4
		//IL_014f: Expected Obj, but got I
		//IL_0be5: Expected Obj, but got I4
		//IL_0bfd: Invalid comparison between F8 and I4
		//IL_0c1f: Expected Obj, but got I4
		//IL_01a4: Invalid comparison between F4 and I4
		//IL_01b8: Expected F8, but got I4
		//IL_0a44: Expected Obj, but got I4
		//IL_0347: Expected F4, but got I4
		//IL_0350: Expected VT, but got I4
		//IL_0263: Expected Obj, but got I4
		//IL_0614: Invalid comparison between F8 and I
		//IL_066f: Expected F4, but got I
		//IL_067f: Invalid comparison between I and F8
		//IL_0377: Expected Obj, but got I
		//IL_0384: Invalid comparison between F8 and I4
		//IL_0393: Expected F8, but got I4
		//IL_0652: Expected F4, but got I4
		//IL_0426: Expected VT, but got I4
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected Obj, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected VT, but got Unknown
		//IL_06f6: Expected Obj, but got I
		//IL_0474: Expected Obj, but got I
		//IL_04a5: Expected Obj, but got I
		//IL_0529: Expected VT, but got I4
		//IL_0548: Expected F4, but got I
		//IL_0565: Invalid comparison between F8 and I4
		//IL_0574: Invalid comparison between F8 and I4
		//IL_058c: Expected Obj, but got F8
		//IL_0599: Expected Obj, but got F8
		//IL_05ce: Expected Obj, but got I4
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected Obj, but got Unknown
		//IL_070c: Expected Obj, but got I
		//IL_06d2: Expected Obj, but got I
		//IL_0ac0: Expected VT, but got I4
		//IL_0ad9: Expected VT, but got I4
		//IL_0744: Expected VT, but got I4
		//IL_0769: Expected VT, but got I4
		//IL_0793: Expected VT, but got I4
		//IL_07cc: Invalid comparison between F4 and I
		//IL_07dc: Expected VT, but got I4
		//IL_07ed: Expected F4, but got I
		//IL_0838: Expected Obj, but got I4
		//IL_0872: Expected VT, but got I4
		//IL_087c: Expected VT, but got I4
		//IL_088c: Expected Obj, but got I
		//IL_089c: Expected Obj, but got I
		//IL_08ac: Expected F4, but got I
		//IL_08b6: Expected F4, but got I4
		List<Going> list = going;
		int num = list._size;
		if (list._size >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6378]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			float num2 = dt;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC38]");
			float num3 = num2 / 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6388]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6380]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj5 = 0;
			double num4 = 1.0;
			float num5 = dt;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEC8]");
			float num6 = 0f;
			Vector3 euler = default;
			object obj12 = default;
			double num27 = default;
			do
			{
				num--;
				System.__Canon _Canon = ((List<System.__Canon>)(object)going).get_Item(num);
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj7 = !flag;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7 (System.__Canon)+10]");
				if ((UnityEngine.Object)0 == null)
				{
					((List<System.__Canon>)(object)going).RemoveAt(num);
					continue;
				}
				float num7 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7 (System.__Canon)+18]");
				float num8 = num7 + 0f;
				bool flag2 = num8 < 0f;
				double num9 = 0.0;
				if (!flag2)
				{
					bool flag3 = (double)num8 > 1.0;
					num9 = 1.0;
					if (!flag3)
					{
						num9 = num8;
					}
				}
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X0_v13+E4]");
				bool flag4 = (nint)0 == 0;
				object obj9 = !flag4;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Transform transform;
				if (nip != null)
				{
					transform = nip;
					bool flag5 = (object)nip == null;
					object obj10 = !flag5;
					if (obj10 == null)
					{
						throw new NullReferenceException();
					}
				}
				else
				{
					transform = mouth;
				}
				double num10 = num9 + num9;
				double num11 = num9 * 3.0;
				double num12 = num9 * num10;
				double num13 = num9 * num11;
				double num14 = num9 * num12;
				double num15 = num13 - num14;
				double num16 = num4 - num15;
				double num17 = num16 * 0.0;
				double num18 = num15 + num17;
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7 (System.__Canon)+50]");
				bool flag6 = (nint)0 == 0;
				(System.__Canon, int, bool) tuple = ((System.__Canon, int, bool))euler;
				float num19 = 0f;
				Vector3 at = (Vector3)0;
				double num20 = num17;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7 (System.__Canon)+10]");
					Transform transform2 = ((Component)0).transform;
					bool flag7 = num18 < 0.0;
					num9 = 0.0;
					if (!flag7)
					{
						bool flag8 = !(num18 > num4);
						num9 = num18;
						if (!flag8)
						{
							num9 = 1.0;
						}
					}
					Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
					float num21 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7 (System.__Canon)+24]");
					float num22 = num21 - 0f;
					double num23 = (double)num22 * num9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7 (System.__Canon)+24]");
					double num24 = 0.0 + num23;
					transform2.position = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7 (System.__Canon)+34]");
					object obj11 = 0 * obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
					(System.__Canon, int, bool) tuple2 = ((System.__Canon, int, bool))(obj11 * 0);
					Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7 (System.__Canon)+40]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
					nint num25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7 (System.__Canon)+40]");
					object obj14 = num25 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
					double num26 = 0.0 * num24;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
					num27 += num26;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					transform2.rotation = (Quaternion)0;
					double num28 = num18 * num18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7 (System.__Canon)+30]");
					float num29 = 0f;
					double num30 = num28 - 1.0;
					bool flag9 = num30 < 0.0;
					bool flag10 = num30 == 0.0;
					object obj15 = num28 ^ 1.0;
					object obj16 = num28 ^ num30;
					object obj17 = obj15 & obj16;
					bool flag11 = (nint)obj17 < 0;
					bool flag12 = flag9 == flag11;
					object obj18 = !flag10;
					object obj19 = flag12 & obj18;
					object obj20 = ~obj19;
					if (obj20 == null)
					{
						num28 = 1.0;
					}
					double num31 = num28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEC8]");
					double num32 = num31 * 0.0;
					double num33 = num32 + 1.0;
					double num34 = num33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7 (System.__Canon)+2C]");
					num20 = num34 * 0.0;
					double num35 = num33 * (double)num29;
					transform2.localScale = (Vector3)0;
					tuple = tuple2;
					num19 = (float)num35;
					at = (Vector3)0;
					num4 = 1.0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
				bool flag13 = !(num18 > 0.0);
				num5 = (float)num20;
				if (!flag13)
				{
					Spark(at, (float)num15);
					float num29 = dt;
					num19 = 0f;
					num5 = (float)num17;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7 (System.__Canon)+18]");
				num6 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7 (System.__Canon)+18]");
				bool flag14 = 0.0 < num4;
				euler = (Vector3)tuple;
				if (flag14)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7 (System.__Canon)+50]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7 (System.__Canon)+10]");
					((GillaItem)0).Recycle();
				}
				((List<System.__Canon>)(object)going).RemoveAt(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7 (System.__Canon)+10]");
				GillaItem gillaItem = (GillaItem)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v7 (System.__Canon)+10]");
				bool paysMe = ((GillaItem)0).PaysMe;
				tuple = ((System.__Canon)(object)gillaItem.label, gillaItem.coins, paysMe);
				((Queue<(System.__Canon, int, bool)>)(object)waiting).Enqueue(((System.__Canon, int, bool))0);
				AudioClip[] array = crunch;
				bool flag15 = crunch == null;
				euler = (Vector3)0;
				if (flag15)
				{
					continue;
				}
				bool flag16 = array.Length == 0;
				euler = (Vector3)0;
				if (flag16)
				{
					continue;
				}
				float time = Time.time;
				num6 = time - crunchedAt;
				float num36 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				bool flag17 = num36 < 0f;
				euler = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				num5 = 0f;
				if (!flag17)
				{
					float time2 = Time.time;
					object obj21 = obj5;
					crunchedAt = time2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v971 @ X0_v29+E4]");
					bool flag18 = (nint)0 == 0;
					object obj22 = !flag18;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Sfx.Play(crunch, (Vector3)0, (float)num15, (float)num17, 0f);
					euler = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
					float num29 = 0f;
					num19 = 0f;
					num5 = (float)num17;
					num6 = (float)num15;
				}
			}
			while (num > 0);
			list = going;
		}
		double num37;
		double num38;
		if (list._size > 0)
		{
			num37 = 4.0;
			num38 = 1.0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
			num38 = 0.0;
			bool flag19;
			bool flag20;
			if ((double)shown < 1.0)
			{
				flag19 = shown < 0f;
				object obj23 = shown ^ shown;
				object obj24 = shown & obj23;
				flag20 = (nint)obj24 < 0;
			}
			else
			{
				flag20 = false;
				flag19 = true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
			num37 = 0.0;
			bool flag21 = flag19 == flag20;
			object obj25 = !flag21;
			if (obj25 != null)
			{
				num38 = 0.0;
			}
		}
		double num39 = num38 - (double)work;
		double num40 = num37 * (double)dt;
		double num41 = num37 * (double)dt;
		double num42 = 0.0 - num41;
		bool flag22 = num39 < 0.0;
		object obj26 = num39 ^ num39;
		object obj27 = num39 & obj26;
		bool flag23 = (nint)obj27 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag24 = flag22 == flag23;
		object obj28 = !flag24;
		object obj29 = ~obj28;
		if (obj29 != null)
		{
			num42 = num40;
		}
		bool flag25 = num39 < num40;
		object obj30 = !flag25;
		double num43 = num39 - num40;
		bool flag26 = num43 == 0.0;
		double num44 = (double)work + num42;
		object obj31 = !flag26;
		object obj32 = obj30 & obj31;
		object obj33 = ~obj32;
		if (obj33 != null)
		{
			num44 = num38;
		}
		work = (float)num44;
	}

	private void Grind()
	{
		//IL_0034: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I
		//IL_0454: Expected Obj, but got I4
		//IL_082d: Invalid comparison between F4 and I4
		//IL_083c: Expected F8, but got I4
		//IL_049a: Expected VT, but got I4
		//IL_0821: Expected F4, but got I
		//IL_08e6: Invalid comparison between F4 and I
		//IL_04de: Expected I4, but got I8
		//IL_04f8: Expected Obj, but got I4
		//IL_0281: Expected VT, but got I4
		//IL_0291: Expected Obj, but got I
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_0671: Expected Obj, but got I4
		//IL_059e: Expected Obj, but got I4
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected Obj, but got Unknown
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected Obj, but got Unknown
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected Obj, but got Unknown
		//IL_05d7: Expected I4, but got Obj
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected Obj, but got Unknown
		//IL_06c2: Expected Obj, but got I
		//IL_06df: Expected F4, but got I
		//IL_06df: Expected F4, but got I
		//IL_074c: Expected F4, but got I
		AudioClip[] array = grind;
		if (grind == null || array.Length == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = mouth == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		List<Going> list = going;
		if (going != null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(grinding == null))
			{
				if (list._size >= 1)
				{
					goto IL_040c;
				}
				goto IL_077b;
			}
			if (list._size < 1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6390]");
			object obj8 = 0;
			GameObject gameObject = default;
			gameObject._002Ector((string)obj8);
			if ((object)gameObject != null)
			{
				Transform transform = gameObject.transform;
				Transform parent = base.transform;
				if ((object)transform != null)
				{
					transform.SetParent(parent, worldPositionStays: false);
					Transform transform2 = gameObject.transform;
					if ((object)mouth != null)
					{
						Vector3 position = mouth.position;
						if ((object)transform2 != null)
						{
							transform2.position = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4350]");
							object obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
							AudioSource audioSource = default;
							grinding = audioSource;
							object obj10 = this + 376;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							if ((object)grinding != null)
							{
								grinding.playOnAwake = false;
								if ((object)grinding != null)
								{
									grinding.spatialBlend = 1f;
									if ((object)grinding != null)
									{
										grinding.minDistance = 1f;
										if ((object)grinding != null)
										{
											grinding.maxDistance = 18f;
											if ((object)grinding != null)
											{
												grinding.rolloffMode = (AudioRolloffMode)1;
												if ((object)grinding != null)
												{
													grinding.dopplerLevel = 0f;
													goto IL_040c;
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
		goto IL_0929;
		IL_0937:
		throw new IndexOutOfRangeException();
		IL_060f:
		AudioClip[] array2;
		int num = UnityEngine.Random.Range(0, array2.Length);
		AudioClip[] array3 = grind;
		grindClip = num;
		if (grind != null)
		{
			goto IL_0656;
		}
		goto IL_0929;
		IL_0656:
		bool flag5 = num < array3.Length;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			if ((object)grinding != null)
			{
				object obj12 = array3 + num;
				AudioSource audioSource2 = grinding;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X9_v7+20]");
				audioSource2.clip = (AudioClip)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B004]");
				float pitch = UnityEngine.Random.Range(num2, 0f);
				if ((object)grinding != null)
				{
					grinding.pitch = pitch;
					if ((object)grinding != null)
					{
						AudioSource audioSource3 = grinding;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
						audioSource3.volume = 0f;
						if ((object)grinding != null)
						{
							grinding.Play();
							goto IL_077b;
						}
					}
				}
			}
			goto IL_0929;
		}
		goto IL_0937;
		IL_040c:
		if ((object)grinding != null)
		{
			bool isPlaying = grinding.isPlaying;
			bool flag6 = !isPlaying;
			object obj13 = !flag6;
			if (obj13 != null)
			{
				goto IL_077b;
			}
			if ((object)mouth != null)
			{
				Vector3 position2 = mouth.position;
				if (!GillaBackroomsSwitch.OnYourSide((Vector3)0))
				{
					goto IL_077b;
				}
				array2 = grind;
				int num3 = (int)(grindClip & 0x80000000L);
				bool flag7 = num3 == 0;
				object obj14 = !flag7;
				if (obj14 == null)
				{
					if (grind != null)
					{
						if (array2.Length < 2)
						{
							goto IL_060f;
						}
						int maxExclusive = array2.Length - 1;
						int num4 = UnityEngine.Random.Range(0, maxExclusive);
						AudioClip[] array4 = grind;
						if (grind != null)
						{
							object obj15 = grindClip + num4;
							object obj16 = obj15 + 1;
							object obj17 = obj16 / array4.Length;
							object obj18 = obj17 * array4.Length;
							num = (grindClip = obj16 - obj18);
							array3 = grind;
							goto IL_0656;
						}
					}
				}
				else if (grind != null)
				{
					goto IL_060f;
				}
			}
		}
		goto IL_0929;
		IL_077b:
		if ((object)grinding != null)
		{
			if (!grinding.isPlaying)
			{
				return;
			}
			if (list._size > 0)
			{
				if ((object)grinding != null)
				{
					AudioSource audioSource4 = grinding;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
					audioSource4.volume = 0f;
					return;
				}
			}
			else
			{
				bool flag8 = work < 0f;
				double num5 = 0.0;
				if (!flag8)
				{
					bool flag9 = !((double)work > 1.0);
					num5 = work;
					if (!flag9)
					{
						num5 = 1.0;
					}
				}
				if ((object)grinding != null)
				{
					float num6 = (float)num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
					float volume = num6 * 0f;
					grinding.volume = volume;
					if (list._size > 0)
					{
						return;
					}
					float num7 = work;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
					if (!(num7 < 0f))
					{
						return;
					}
					if ((object)grinding != null)
					{
						grinding.Stop();
						return;
					}
				}
			}
		}
		goto IL_0929;
		IL_0929:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0937;
	}

	private unsafe void Count(float dt)
	{
		//IL_0b4a: Invalid comparison between F4 and I4
		//IL_0b5b: Expected VT, but got I
		//IL_0b64: Expected VT, but got I4
		//IL_0028: Expected VT, but got I
		//IL_0031: Expected VT, but got I4
		//IL_025c: Expected VT, but got I
		//IL_026c: Expected VT, but got I
		//IL_043b: Expected VT, but got I4
		//IL_02b4: Expected Obj, but got VT
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected I4, but got Unknown
		//IL_007c: Expected Obj, but got I
		//IL_00a4: Expected VT, but got Obj
		//IL_0a4e: Expected Obj, but got I
		//IL_0a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a63: Expected Obj, but got Unknown
		//IL_0a8b: Expected Obj, but got I4
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a98: Expected Obj, but got Unknown
		//IL_0474: Invalid comparison between F4 and I4
		//IL_0c1c: Invalid comparison between F4 and I4
		//IL_0c2b: Invalid comparison between F4 and I4
		//IL_0c3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c40: Expected I4, but got Unknown
		//IL_0c4d: Expected Obj, but got F4
		//IL_0c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5a: Expected I4, but got Unknown
		//IL_0c82: Expected Obj, but got I4
		//IL_0c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8f: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I
		//IL_00da: Expected VT, but got Obj
		//IL_0108: Expected VT, but got Obj
		//IL_0abf: Expected F8, but got I
		//IL_0494: Expected F4, but got I4
		//IL_04a3: Expected F4, but got I4
		//IL_0ae1: Invalid comparison between F4 and I4
		//IL_0e29: Expected Obj, but got I
		//IL_0e53: Expected Obj, but got I4
		//IL_0383: Expected Obj, but got I4
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected I4, but got Unknown
		//IL_01e7: Expected native int or pointer, but got F4
		//IL_01fe: Expected F4, but got I
		//IL_022f: Expected VT, but got Obj
		//IL_0237: Expected VT, but got Obj
		//IL_04de: Expected Obj, but got I4
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected Obj, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected I4, but got Unknown
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected I4, but got Unknown
		//IL_0559: Expected Obj, but got I4
		//IL_019b: Expected VT, but got I4
		//IL_0cc4: Expected Obj, but got I4
		//IL_0cfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d00: Expected I4, but got Unknown
		//IL_0d35: Expected Obj, but got I4
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d42: Expected Obj, but got Unknown
		//IL_0d76: Expected VT, but got I4
		//IL_05c7: Invalid comparison between F4 and I4
		//IL_05d8: Expected Obj, but got I4
		//IL_05e1: Invalid comparison between F4 and I4
		//IL_05fc: Expected Obj, but got I4
		//IL_0615: Expected VT, but got I4
		//IL_0633: Expected Obj, but got I
		//IL_065d: Expected Obj, but got I4
		//IL_06a4: Expected VT, but got I4
		//IL_06ae: Expected VT, but got I4
		//IL_06b7: Expected VT, but got I4
		//IL_06df: Expected F4, but got I4
		//IL_06ef: Expected Obj, but got I4
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Expected I4, but got Unknown
		//IL_076c: Expected Obj, but got I4
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Expected Obj, but got Unknown
		//IL_07a8: Expected VT, but got I4
		//IL_0da8: Expected F4, but got I4
		//IL_0db1: Expected VT, but got I4
		//IL_0dba: Expected VT, but got I4
		//IL_079a: Expected VT, but got I4
		//IL_07b7: Expected VT, but got Obj
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected Obj, but got Unknown
		//IL_07f5: Expected F4, but got I4
		//IL_07fe: Expected VT, but got I4
		//IL_0835: Expected F4, but got I4
		//IL_083e: Expected VT, but got I4
		//IL_0847: Expected VT, but got I4
		//IL_087c: Expected F4, but got I
		//IL_08bf: Expected Obj, but got I
		//IL_08e9: Expected Obj, but got I4
		//IL_0938: Expected F4, but got VT
		//IL_0938: Expected VT, but got I4
		//IL_0948: Expected F4, but got VT
		//IL_0952: Expected F4, but got I4
		//IL_095b: Expected VT, but got I4
		//IL_0964: Expected VT, but got I4
		bool flag = !(shown < 0f);
		IntPtr intPtr = default;
		(string, int, bool) tuple = ((string, int, bool))(nint)intPtr;
		(System.__Canon, int, bool) tuple2 = ((System.__Canon, int, bool))109891584;
		float num;
		(string, int, bool) tuple4;
		(string, int, bool) tuple5 = default;
		(string, int, bool) tuple6 = default;
		int num3 = default;
		if (!flag)
		{
			Queue<(System.__Canon, int, bool)> queue = (Queue<(System.__Canon, int, bool)>)(object)waiting;
			bool flag2 = (object)waiting == null;
			tuple = ((string, int, bool))(nint)intPtr;
			tuple2 = ((System.__Canon, int, bool))109891584;
			num = dt;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v43 (System.Collections.Generic.Queue`1<System.ValueTuple`3<System.__Canon, System.Int32, System.Boolean>>)+20]");
				if ((nint)0 == 0)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C63A0]");
				object obj = 0;
				(System.__Canon, int, bool) tuple3 = ((Queue<(System.__Canon, int, bool)>)(object)waiting).Dequeue();
				bool flag3 = (object)kinds == null;
				tuple = ((string, int, bool))obj;
				tuple2 = tuple3;
				num = dt;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6398]");
					object obj2 = 0;
					tuple = ((string, int, bool))obj2;
					((Dictionary<System.__Canon, int>)(object)kinds).Clear();
					List<string> list = unpaid;
					bool flag4 = (object)unpaid == null;
					tuple4 = ((string, int, bool))obj;
					tuple2 = tuple3;
					num = dt;
					if (!flag4)
					{
						int version = list._version + 1;
						list._size = 0;
						list._version = version;
						if (list._size >= 1)
						{
							Array.Clear(list._items, 0, list._size);
							tuple5 = ((string, int, bool))0;
						}
						object obj3 = obj >> 32;
						bool flag5 = (byte)(obj3 & 1) != 0;
						float num2 = (float)this + 268f;
						counted = 0;
						mine = flag5;
						((float*)(nint)num2)->m_value = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BD98]");
						paidAt = 0f;
						Add(((string, int, bool))tuple3);
						shown = 0f;
						dirty = true;
						num3 = 17281024;
						tuple6 = ((string, int, bool))obj;
						tuple4 = ((string, int, bool))obj;
						tuple = ((string, int, bool))tuple3;
						tuple2 = tuple3;
						goto IL_0de8;
					}
				}
			}
			goto IL_03d2;
		}
		goto IL_0de8;
		IL_03e0:
		float num4 = (shown += num);
		if (!((double)num4 < 1.0))
		{
			bool flag6 = counted >= total;
			tuple4 = ((string, int, bool))total;
			if (!flag6)
			{
				float num5 = (float)total - countedF;
				float num6 = num5 + num5;
				if (num6 < 1.1093934E+09f)
				{
					num6 = 1.1093934E+09f;
				}
				float num7 = num6 * num;
				float num8 = countedF + num7;
				float num9 = num8 - (float)total;
				bool flag7 = num9 < 0f;
				bool flag8 = num9 == 0f;
				int num10 = num8 ^ total;
				object obj4 = num8 ^ num9;
				int num11 = num10 & obj4;
				bool flag9 = num11 < 0;
				bool flag10 = flag7 == flag9;
				object obj5 = !flag8;
				object obj6 = flag10 & obj5;
				object obj7 = ~obj6;
				float num12 = ((obj7 != null) ? num8 : ((float)total));
				countedF = num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X0_v17+E4]");
				bool flag11 = (nint)0 == 0;
				object obj10 = !flag11;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
				object obj11 = total + 1;
				object obj12 = total - obj11;
				bool flag12 = (nint)obj12 < 0;
				int num13 = total ^ obj11;
				int num14 = total ^ obj12;
				int num15 = num13 & num14;
				bool flag13 = num15 < 0;
				num3 = counted;
				bool flag14 = flag12 == flag13;
				object obj13 = !flag14;
				object obj14 = ~obj13;
				int num16 = ((obj14 != null) ? (total + 1) : total);
				object obj15 = counted - num16;
				bool flag15 = (nint)obj15 < 0;
				bool flag16 = obj15 == null;
				int num17 = counted ^ num16;
				int num18 = counted ^ obj15;
				int num19 = num17 & num18;
				bool flag17 = num19 < 0;
				bool flag18 = flag15 == flag17;
				object obj16 = !flag16;
				object obj17 = flag18 & obj16;
				object obj18 = ~obj17;
				if (obj18 == null)
				{
					num16 = counted;
				}
				bool flag19 = num16 <= num3;
				tuple4 = ((string, int, bool))total;
				if (!flag19)
				{
					counted = num16;
					float num20 = tickIn - num;
					bool flag20 = num20 < 0f;
					object obj19 = !flag20;
					bool flag21 = num20 == 0f;
					tickIn = num20;
					object obj20 = !flag21;
					object obj21 = obj19 & obj20;
					tuple4 = ((string, int, bool))total;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj22 = 0;
						object obj23 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X0_v19+E4]");
						bool flag22 = (nint)0 == 0;
						object obj24 = !flag22;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag23 = tickSound != null;
						bool flag24 = !flag23;
						tuple6 = ((string, int, bool))0;
						tuple4 = ((string, int, bool))total;
						tuple = ((string, int, bool))0;
						if (!flag24)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
							num3 = 0;
							num = counted;
							object obj25 = total - 1;
							bool flag25 = (nint)obj25 < 0;
							bool flag26 = obj25 == null;
							int num21 = total ^ 1;
							int num22 = total ^ obj25;
							int num23 = num21 & num22;
							bool flag27 = num23 < 0;
							tickIn = 0.045f;
							bool flag28 = flag25 == flag27;
							obj16 = !flag26;
							object obj26 = flag28 & obj16;
							obj18 = ~obj26;
							tuple4 = ((obj18 != null) ? (((string, int, bool))1) : (((string, int, bool))total));
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							AudioClip[] array = default;
							bool flag29 = array == null;
							float num2 = 1.0271012E+09f;
							tuple6 = ((string, int, bool))0;
							tuple = ((string, int, bool))1;
							if (!flag29)
							{
								tuple = ((string, int, bool))tickSound;
								object obj27 = array + 32;
								obj27 = tickSound;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								bool flag30 = (object)screen == null;
								num2 = 1.0271012E+09f;
								tuple6 = ((string, int, bool))0;
								if (!flag30)
								{
									Transform transform = screen.transform;
									bool flag31 = (object)transform == null;
									num2 = 1.0271012E+09f;
									tuple6 = ((string, int, bool))0;
									tuple = ((string, int, bool))0;
									if (!flag31)
									{
										float num24 = num;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
										float num25 = num24 * 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
										num8 = 0f;
										float num26 = num25 / (float)tuple4;
										float num27 = num26;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
										num = num27 + 0f;
										Vector3 position = transform.position;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
										object obj28 = 0;
										object obj29 = obj28;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X0_v32+E4]");
										bool flag32 = (nint)0 == 0;
										object obj30 = !flag32;
										if (obj30 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										float num28 = num;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
										float num29 = num28 + 0f;
										Sfx.Play(array, (Vector3)0, num26, num8, (float)tuple4);
										num12 = num26;
										num7 = (float)tuple4;
										num2 = 1.0271012E+09f;
										tuple6 = ((string, int, bool))0;
										tuple = ((string, int, bool))0;
										goto IL_0969;
									}
								}
							}
							goto IL_03d2;
						}
					}
				}
			}
			goto IL_0969;
		}
		goto IL_0bc1;
		IL_0969:
		num4 = shown;
		goto IL_0bc1;
		IL_0de8:
		Queue<(System.__Canon, int, bool)> queue2 = (Queue<(System.__Canon, int, bool)>)(object)waiting;
		bool flag33 = (object)waiting == null;
		num = dt;
		if (flag33)
		{
			goto IL_03d2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C63A8]");
		tuple2 = ((System.__Canon, int, bool))0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C63A0]");
		tuple4 = ((string, int, bool))0;
		(string, int, bool) tuple7 = tuple5;
		int num30 = num3;
		(string, int, bool) tuple8 = tuple6;
		(string, int, bool) tuple9 = tuple;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v4 (System.Collections.Generic.Queue`1<System.ValueTuple`3<System.__Canon, System.Int32, System.Boolean>>)+20]");
			bool flag34 = (nint)0 < (nint)1;
			tuple5 = tuple7;
			num3 = num30;
			tuple6 = tuple8;
			tuple = tuple9;
			num = dt;
			if (flag34)
			{
				break;
			}
			tuple = ((string, int, bool))tuple2;
			(System.__Canon, int, bool) tuple10 = queue2.Peek();
			object obj31 = tuple2 >> 32;
			num3 = obj31 & 1;
			bool flag35 = num3 != (mine ? 1 : 0);
			tuple5 = tuple7;
			tuple6 = tuple8;
			num = dt;
			if (flag35)
			{
				break;
			}
			bool flag36 = (object)waiting == null;
			tuple5 = tuple7;
			tuple6 = tuple8;
			num = dt;
			if (!flag36)
			{
				(System.__Canon, int, bool) tuple11 = ((Queue<(System.__Canon, int, bool)>)(object)waiting).Dequeue();
				Add(((string, int, bool))tuple11);
				queue2 = (Queue<(System.__Canon, int, bool)>)(object)waiting;
				dirty = true;
				bool flag37 = (object)waiting == null;
				object obj32 = !flag37;
				tuple5 = tuple4;
				tuple6 = tuple4;
				tuple = ((string, int, bool))tuple11;
				num = dt;
				tuple7 = tuple4;
				num30 = num3;
				tuple8 = tuple4;
				tuple9 = ((string, int, bool))tuple11;
				if (obj32 != null)
				{
					continue;
				}
			}
			goto IL_03d2;
		}
		goto IL_03e0;
		IL_0bc1:
		if (!((double)num4 < 1.0))
		{
			num3 = counted;
			if (counted >= total)
			{
				num3 = paidOut;
				if (paidOut < total)
				{
					Pay();
				}
			}
		}
		Queue<(string, int, bool)> queue3 = waiting;
		if ((object)waiting != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v11 (System.Collections.Generic.Queue`1<System.ValueTuple`3<System.String, System.Int32, System.Boolean>>)+20]");
			bool flag38 = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v11 (System.Collections.Generic.Queue`1<System.ValueTuple`3<System.String, System.Int32, System.Boolean>>)+20]");
			bool flag39 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v11 (System.Collections.Generic.Queue`1<System.ValueTuple`3<System.String, System.Int32, System.Boolean>>)+20]");
			nint num31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v11 (System.Collections.Generic.Queue`1<System.ValueTuple`3<System.String, System.Int32, System.Boolean>>)+20]");
			object obj33 = num31 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v11 (System.Collections.Generic.Queue`1<System.ValueTuple`3<System.String, System.Int32, System.Boolean>>)+20]");
			object obj34 = 0 & obj33;
			bool flag40 = (nint)obj34 < 0;
			bool flag41 = flag38 == flag40;
			object obj35 = !flag39;
			object obj36 = flag41 & obj35;
			object obj37 = ~obj36;
			double num32;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
				num32 = 0.0;
			}
			else
			{
				num32 = 4.0;
			}
			if (paidOut >= total && !(paidAt < 0f))
			{
				double num33 = num32 + (double)paidAt;
				if (!((double)shown < num33))
				{
					shown = -1f;
					dirty = true;
				}
			}
			return;
		}
		goto IL_03d2;
		IL_03d2:
		NullReferenceException ex = new NullReferenceException();
		goto IL_03e0;
	}

	private void Add((string, int, bool) thing)
	{
		//IL_0016: Expected Obj, but got I
		//IL_0029: Expected Obj, but got VT
		//IL_0047: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got VT
		//IL_00ca: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got VT
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0120: Expected Obj, but got VT
		nint num2 = default;
		int num = (int)(total + num2);
		total = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6420]");
		object obj = 0;
		bool flag = ((Dictionary<System.__Canon, int>)(object)kinds).TryGetValue((System.__Canon)thing, out int value);
		bool flag2 = !flag;
		object obj2 = !flag2;
		int value2 = ((obj2 == null) ? 1 : (value + 1));
		((Dictionary<System.__Canon, int>)(object)kinds).set_Item((System.__Canon)thing, value2);
		List<System.__Canon> list = (List<System.__Canon>)(object)unpaid;
		System.__Canon[] items = list._items;
		int version = list._version + 1;
		list._version = version;
		bool flag3 = list._size < items.Length;
		object obj3 = !flag3;
		if (obj3 == null)
		{
			object obj4 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj5 = obj4 + 32;
			obj5 = thing;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			list.AddWithResize((System.__Canon)thing);
		}
	}

	private unsafe void Pay()
	{
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected I4, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected VT, but got I4
		//IL_061c: Expected I4, but got Obj
		//IL_02e1: Expected Obj, but got I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got I4
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got I4
		//IL_0647: Expected Obj, but got I4
		//IL_065b: Expected VT, but got Ref
		//IL_0681: Expected VT, but got I4
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_094e: Expected I4, but got Obj
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0957: Expected Ref, but got Unknown
		//IL_0971: Expected Obj, but got I4
		//IL_0131: Expected I, but got Obj
		//IL_0163: Expected Obj, but got I4
		//IL_0768: Invalid comparison between F4 and I
		//IL_019c: Expected Obj, but got I4
		//IL_033b: Expected Obj, but got I4
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected Obj, but got Unknown
		//IL_07a7: Expected F4, but got I
		//IL_058c: Expected VT, but got Ref
		//IL_023a: Expected Obj, but got I4
		//IL_0709: Expected Obj, but got I
		//IL_0711: Expected I4, but got Obj
		//IL_07c4: Expected F4, but got I
		//IL_01ca: Expected I, but got Obj
		//IL_01fc: Expected Obj, but got I4
		//IL_03ae: Expected I, but got Obj
		//IL_03d0: Expected Obj, but got I4
		//IL_026c: Expected I, but got Obj
		//IL_029e: Expected Obj, but got I4
		//IL_0398: Expected Obj, but got I4
		//IL_08be: Expected Obj, but got I4
		bool flag = (byte)(~(mine ? 1u : 0u)) != 0;
		Enumerator<, > val = (Enumerator<, >)0;
		IntPtr intPtr = default;
		int num = (int)(nint)intPtr;
		int num2 = 109891584;
		Enumerator<, > val4 = default;
		int num4;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj = 0;
			int num3 = paidOut;
			object obj2 = obj;
			num4 = total;
			num2 = total - paidOut;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v50+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coins.AddBolts(num2);
			bool flag3 = (object)unpaid == null;
			val = (Enumerator<, >)0;
			num = 0;
			if (flag3)
			{
				goto IL_07e4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4420]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
			string text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6448]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6450]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4418]");
			object obj7 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)unpaid).GetEnumerator();
			int num5 = default;
			num4 = num5;
			while (val.MoveNext())
			{
				nint num6 = (nint)text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v58 (Il2CppClass<System.String>)+E4]");
				num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v58 (Il2CppClass<System.String>)+E4]");
				bool flag4 = (nint)0 == 0;
				object obj8 = !flag4;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaQuests.Report((GillaQuests.Stat)0, 1);
				if ((string)num5 == (string)obj5)
				{
					nint num7 = (nint)text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X0_v70 (Il2CppClass<System.String>)+E4]");
					num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X0_v70 (Il2CppClass<System.String>)+E4]");
					bool flag5 = (nint)0 == 0;
					object obj9 = !flag5;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaQuests.Report((GillaQuests.Stat)1, 1);
				}
				bool flag6 = (string)num5 == (string)obj6;
				bool flag7 = !flag6;
				int num8 = 0;
				if (!flag7)
				{
					nint num9 = (nint)text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X0_v66 (Il2CppClass<System.String>)+E4]");
					num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X0_v66 (Il2CppClass<System.String>)+E4]");
					bool flag8 = (nint)0 == 0;
					object obj10 = !flag8;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaQuests.Report((GillaQuests.Stat)2, 1);
					num8 = 0;
				}
			}
			object obj11 = 0;
			int num10 = 0;
			Enumerator<, > val2 = default;
			val = val2;
			object obj12 = 0;
			Enumerator<, > val3 = val2;
			val4 = (Enumerator<, >)(ref val);
			object obj13 = 6;
			num3 = (int)(&val);
			object obj16 = default;
			while (true)
			{
				num = (int)obj7;
				((Enumerator<, >*)val4)->Dispose();
				bool flag9 = obj11 == null;
				object obj14 = !flag9;
				num5 = num10;
				if (obj14 == null)
				{
					bool flag10 = num10 == 0;
					object obj15 = !flag10;
					num5 = num10;
					OutOfMemoryException ex = (OutOfMemoryException)val4;
					num4 = num10;
					if (obj15 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				switch (num)
				{
				case 2:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj11 = obj12;
					num5 = 1;
					num4 = 1;
					break;
				case 1:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj11 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj12 = obj16;
					break;
				default:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE0C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				num10 = num5;
				obj13 = 0;
			}
			if ((nint)obj13 != 6)
			{
				bool flag11 = obj13 == null;
				object obj17 = !flag11;
				if (obj17 != null)
				{
					return;
				}
			}
			nint num11 = (nint)text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v4 (Il2CppClass<System.String>)+E4]");
			bool flag12 = (nint)0 == 0;
			object obj18 = !flag12;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaQuests.Report((GillaQuests.Stat)3, num2);
			num5 = num10;
			num = num2;
		}
		List<string> list = unpaid;
		bool flag13 = (object)unpaid == null;
		num4 = (int)unpaid;
		if (!flag13)
		{
			int num8 = list._size;
			int num3 = list._version + 1;
			list._size = 0;
			list._version = num3;
			if (list._size >= 1)
			{
				Array.Clear(list._items, 0, list._size);
				System.__Canon _Canon = null;
				num = 0;
			}
			num4 = paidOut;
			num2 = (int)log;
			if (paidOut != 0)
			{
				if ((object)log != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X20_v2 (System.Int32)+18]");
					if ((nint)0 >= (nint)1)
					{
						string item = Shown;
						string most = Most;
						(System.__Canon, int, System.__Canon) tuple = ((System.__Canon)(object)item, total, (System.__Canon)(object)most);
						((List<(System.__Canon, int, System.__Canon)>)(object)log).set_Item(0, ((System.__Canon, int, System.__Canon))(&val4));
						num8 = (int)(&val4);
					}
					goto IL_0726;
				}
			}
			else
			{
				string text2 = Shown;
				string most2 = Most;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6440]");
				num4 = 0;
				(System.__Canon, int, System.__Canon) tuple = ((System.__Canon)(object)text2, total, (System.__Canon)(object)most2);
				bool flag14 = (object)log == null;
				tuple = ((System.__Canon, int, System.__Canon))0;
				System.__Canon _Canon = (System.__Canon)(object)most2;
				num8 = total;
				string text = text2;
				num = (int)text2;
				if (!flag14)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6428]");
					num4 = 0;
					_Canon = (System.__Canon)((int*)num4)->m_value;
					((List<(System.__Canon, int, System.__Canon)>)(object)log).Insert(0, ((System.__Canon, int, System.__Canon))(&val4));
					List<(System.__Canon, int, System.__Canon)> list2 = (List<(System.__Canon, int, System.__Canon)>)(object)log;
					bool flag15 = (object)log == null;
					tuple = ((System.__Canon, int, System.__Canon))0;
					num8 = (int)(&val4);
					int num5 = 0;
					Enumerator<, > val3 = (Enumerator<, >)0;
					val4 = (Enumerator<, >)0;
					text = text2;
					num = 0;
					num3 = 0;
					if (!flag15)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v42 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, System.Int32, System.__Canon>>)+18]");
						bool flag16 = (nint)0 < (nint)4;
						num8 = (int)(&val4);
						if (!flag16)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6430]");
							object obj19 = 0;
							num8 = (int)obj19;
							((List<(System.__Canon, int, System.__Canon)>)(object)log).RemoveAt(3);
						}
						goto IL_0726;
					}
				}
			}
		}
		goto IL_07e4;
		IL_07e4:
		throw new NullReferenceException();
		IL_0726:
		paidOut = total;
		paidAt = shown;
		float time = Time.time;
		float num12 = time - chimedAt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		if (!(num12 < 0f))
		{
			float time2 = Time.time;
			chimedAt = time2;
			AudioClip clip = coinSound;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
			Play(clip, 0f);
			AudioClip clip2 = sparkleSound;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			Play(clip2, 0f);
		}
		flash = 1f;
		dirty = true;
	}

	private unsafe void Spin(float dt)
	{
		//IL_0d94: Invalid comparison between F4 and I4
		//IL_0da3: Expected F8, but got I4
		//IL_0ef2: Expected VT, but got I
		//IL_0024: Invalid comparison between F8 and I4
		//IL_0033: Invalid comparison between F8 and I4
		//IL_004d: Expected Obj, but got F8
		//IL_005c: Expected Obj, but got F8
		//IL_0091: Expected Obj, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected I4, but got Unknown
		//IL_00a9: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I
		//IL_014b: Expected VT, but got I
		//IL_017d: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I4
		//IL_0dbb: Expected Obj, but got I4
		//IL_0dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc9: Expected Obj, but got Unknown
		//IL_0c77: Expected Obj, but got I4
		//IL_0ccb: Expected VT, but got F4
		//IL_0cd6: Invalid comparison between F4 and I4
		//IL_0ce5: Expected F4, but got I4
		//IL_0240: Expected Obj, but got I4
		//IL_0e7c: Expected Obj, but got I4
		//IL_0e81: Expected I, but got Obj
		//IL_037e: Expected Obj, but got I4
		//IL_042a: Expected Obj, but got I4
		//IL_0450: Expected Obj, but got I
		//IL_0472: Expected Obj, but got I4
		//IL_04a1: Expected Obj, but got I
		//IL_04b9: Expected I, but got Obj
		//IL_0b75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7a: Expected Obj, but got Unknown
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b88: Expected Obj, but got Unknown
		//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b96: Expected Obj, but got Unknown
		//IL_0bb2: Expected Obj, but got I4
		//IL_0bfb: Expected Obj, but got I4
		//IL_0c0c: Expected Obj, but got I4
		//IL_052b: Expected Obj, but got I4
		//IL_0530: Expected I, but got Obj
		//IL_0579: Expected Obj, but got I4
		//IL_05eb: Expected Obj, but got I4
		//IL_05f0: Expected I, but got Obj
		//IL_0639: Expected Obj, but got I4
		//IL_06ab: Expected Obj, but got I4
		//IL_06b0: Expected I, but got Obj
		//IL_0703: Expected Obj, but got I4
		//IL_076d: Expected Obj, but got I4
		//IL_0772: Expected I, but got Obj
		//IL_07c5: Expected Obj, but got I4
		//IL_080e: Expected F4, but got I
		//IL_0837: Expected VT, but got I
		//IL_0890: Expected Obj, but got I4
		//IL_0895: Expected I, but got Obj
		//IL_093c: Expected Obj, but got I
		//IL_09ad: Expected Obj, but got I
		//IL_0a17: Expected Obj, but got I
		//IL_0b2f: Expected VT, but got I4
		//IL_0b2f: Expected Obj, but got I
		//IL_0b41: Expected VT, but got Ref
		//IL_0b4c: Expected VT, but got F4
		//IL_0b5c: Expected I, but got Obj
		float num = work;
		bool flag = work < 0f;
		double num2 = 0.0;
		if (!flag)
		{
			double num3 = (double)work - 1.0;
			bool flag2 = num3 < 0.0;
			bool flag3 = num3 == 0.0;
			object obj = (double)work ^ 1.0;
			object obj2 = (double)work ^ num3;
			object obj3 = obj & obj2;
			bool flag4 = (nint)obj3 < 0;
			bool flag5 = flag2 == flag4;
			object obj4 = !flag5;
			bool flag6 = (byte)((obj4 | flag3) ? 1 : 0) != 0;
			object obj5 = !flag6;
			num2 = ((obj5 != null) ? 1.0 : ((double)work));
		}
		float num4 = workSpeed - idleSpeed;
		float num5 = num4 * (float)num2;
		float num6 = idleSpeed + num5;
		float num7 = num6 * dt;
		float num8 = turned + num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACCC]");
		Vector3 vector = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0F0");
		Transform[] array = spinners;
		turned = num8;
		if (spinners != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj6 = 0;
			object obj8 = default;
			object obj7 = obj8;
			float num10 = default;
			float num9 = num10;
			float num11 = num4;
			float num13 = default;
			float num12 = num13;
			float num15 = default;
			float num14 = num15;
			float num17 = default;
			float num16 = num17;
			float num19 = default;
			float num18 = num19;
			float num21 = default;
			float num20 = num21;
			float num23 = default;
			float num22 = num23;
			float num24 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACCC]");
			Vector3 vector2 = (Vector3)0;
			float num25 = num8;
			Vector3[] array3 = default;
			Vector3[] array2 = array3;
			object obj10 = default;
			object obj9 = obj10;
			nint num27 = default;
			nint num26 = num27;
			Vector3[] array5 = default;
			Vector3[] array4 = array5;
			object obj11 = 4;
			object obj12 = 0;
			object obj13 = 0;
			float num28 = num5;
			Vector3 axis = default;
			object obj30;
			do
			{
				Quaternion[] array6 = (Quaternion[])array.Length;
				object obj14 = obj11 - 4;
				bool flag6 = (nint)obj14 >= array.Length;
				num4 = num11;
				num19 = num18;
				num21 = num20;
				num23 = num22;
				num = num24;
				vector = vector2;
				num8 = num25;
				array3 = array2;
				obj10 = obj9;
				num27 = num26;
				array5 = array4;
				object obj15 = obj11;
				object obj16 = obj12;
				object obj17 = obj13;
				num5 = num28;
				if (!flag6)
				{
					array5 = axes;
					bool flag7 = axes == null;
					num4 = num11;
					num19 = num18;
					num21 = num20;
					num23 = num22;
					num = num24;
					vector = vector2;
					num8 = num25;
					array3 = array2;
					obj10 = obj9;
					num27 = num26;
					obj15 = obj11;
					obj16 = obj12;
					obj17 = obj13;
					num5 = num28;
					if (flag7)
					{
						break;
					}
					array5 = (Vector3[])array5.Length;
					flag6 = (nint)obj14 >= array5.Length;
					num4 = num11;
					num19 = num18;
					num21 = num20;
					num23 = num22;
					num = num24;
					vector = vector2;
					num8 = num25;
					array3 = array2;
					obj10 = obj9;
					num27 = num26;
					obj15 = obj11;
					obj16 = obj12;
					obj17 = obj13;
					num5 = num28;
					if (!flag6)
					{
						float[] array7 = rates;
						bool flag8 = rates == null;
						num4 = num11;
						num19 = num18;
						num21 = num20;
						num23 = num22;
						num = num24;
						vector = vector2;
						num8 = num25;
						array3 = array2;
						obj10 = obj9;
						num27 = num26;
						array5 = (Vector3[])(object)rates;
						obj15 = obj11;
						obj16 = obj12;
						obj17 = obj13;
						num5 = num28;
						if (flag8)
						{
							break;
						}
						array5 = (Vector3[])array7.Length;
						flag6 = (nint)obj14 >= array7.Length;
						num4 = num11;
						num19 = num18;
						num21 = num20;
						num23 = num22;
						num = num24;
						vector = vector2;
						num8 = num25;
						array3 = array2;
						obj10 = obj9;
						num27 = num26;
						obj15 = obj11;
						obj16 = obj12;
						obj17 = obj13;
						num5 = num28;
						if (!flag6)
						{
							bool flag9 = (nint)obj14 < array.Length;
							object obj18 = !flag9;
							if (obj18 == null)
							{
								object obj19 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v16+E4]");
								array6 = (Quaternion[])0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v16+E4]");
								bool flag10 = (nint)0 == 0;
								object obj20 = !flag10;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v11 (UnityEngine.Transform[])+v237 @ X24_v5*8]");
								bool flag11 = (UnityEngine.Object)0 != null;
								bool flag12 = !flag11;
								num27 = unchecked((nint)null);
								if (flag12)
								{
									goto IL_0b62;
								}
								Transform[] array8 = spinners;
								bool flag13 = spinners == null;
								num4 = num11;
								num19 = num18;
								num21 = num20;
								num23 = num22;
								num = num24;
								vector = vector2;
								num8 = num25;
								array3 = array2;
								obj10 = 0;
								num27 = unchecked((nint)null);
								obj15 = obj11;
								obj16 = obj12;
								obj17 = obj13;
								num5 = num28;
								if (flag13)
								{
									break;
								}
								bool flag14 = (nint)obj14 < array8.Length;
								object obj21 = !flag14;
								if (obj21 == null)
								{
									array6 = rest;
									bool flag15 = rest == null;
									num4 = num11;
									num19 = num18;
									num21 = num20;
									num23 = num22;
									num = num24;
									vector = vector2;
									num8 = num25;
									array3 = array2;
									obj10 = 0;
									num27 = unchecked((nint)null);
									obj15 = obj11;
									obj16 = obj12;
									obj17 = obj13;
									num5 = num28;
									if (flag15)
									{
										break;
									}
									bool flag16 = (nint)obj14 < array6.Length;
									object obj22 = !flag16;
									if (obj22 == null)
									{
										float[] array9 = rates;
										bool flag17 = rates == null;
										num4 = num11;
										num19 = num18;
										num21 = num20;
										num23 = num22;
										num = num24;
										vector = vector2;
										num8 = num25;
										array3 = array2;
										obj10 = 0;
										num27 = unchecked((nint)null);
										array5 = (Vector3[])(object)rates;
										obj15 = obj11;
										obj16 = obj12;
										obj17 = obj13;
										num5 = num28;
										if (flag17)
										{
											break;
										}
										bool flag18 = (nint)obj14 < array9.Length;
										object obj23 = !flag18;
										if (obj23 == null)
										{
											array3 = axes;
											bool flag19 = axes == null;
											num4 = num11;
											num19 = num18;
											num21 = num20;
											num23 = num22;
											num = num24;
											vector = vector2;
											num8 = num25;
											obj10 = 0;
											num27 = unchecked((nint)null);
											array5 = (Vector3[])(object)rates;
											obj15 = obj11;
											obj16 = obj12;
											obj17 = obj13;
											num5 = num28;
											if (flag19)
											{
												break;
											}
											bool flag20 = (nint)obj14 < array3.Length;
											object obj24 = !flag20;
											if (obj24 == null)
											{
												object obj25 = (object)rates + obj12;
												array6 = (Quaternion[])(object)((object)array6 + obj12);
												array5 = (Vector3[])(object)((object)axes + obj13);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v9 (UnityEngine.Vector3[])+28]");
												num5 = 0f;
												float num29 = turned;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X10_v12+20]");
												num8 = num29 * 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v9 (UnityEngine.Vector3[])+20]");
												vector = (Vector3)0;
												Quaternion quaternion = Quaternion.Internal_AngleAxis(num8, ref axis);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v15 (UnityEngine.Transform[])+v237 @ X24_v5*8]");
												bool flag21 = (nint)0 == 0;
												num4 = num11;
												num19 = num18;
												num21 = num20;
												num23 = num22;
												num = num24;
												obj10 = 0;
												num27 = unchecked((nint)null);
												obj15 = obj11;
												obj16 = obj12;
												obj17 = obj13;
												if (flag21)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v1 (UnityEngine.Quaternion[])+2C]");
												float num30 = 0f * num11;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v1 (UnityEngine.Quaternion[])+20]");
												float num31 = 0f * num8;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v1 (UnityEngine.Quaternion[])+2C]");
												float num32 = 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v9 (UnityEngine.Vector3[])+28]");
												float num33 = num32 * 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v1 (UnityEngine.Quaternion[])+28]");
												float num34 = 0f * num11;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v1 (UnityEngine.Quaternion[])+2C]");
												nint num35 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v9 (UnityEngine.Vector3[])+20]");
												object obj26 = num35 * 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v1 (UnityEngine.Quaternion[])+24]");
												float num36 = 0f * num11;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v1 (UnityEngine.Quaternion[])+2C]");
												float num37 = 0f * num8;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v1 (UnityEngine.Quaternion[])+20]");
												float num38 = 0f * num11;
												float num39 = num30 - num31;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v1 (UnityEngine.Quaternion[])+24]");
												nint num40 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v9 (UnityEngine.Vector3[])+20]");
												object obj27 = num40 * 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v1 (UnityEngine.Quaternion[])+20]");
												float num41 = 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v9 (UnityEngine.Vector3[])+28]");
												num9 = num41 * 0f;
												float num42 = num33 + num34;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v1 (UnityEngine.Quaternion[])+20]");
												float num43 = 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v9 (UnityEngine.Vector3[])+20]");
												num18 = num43 * 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v1 (UnityEngine.Quaternion[])+28]");
												nint num44 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v9 (UnityEngine.Vector3[])+20]");
												obj7 = num44 * 0;
												num16 = (float)obj26 + num36;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v1 (UnityEngine.Quaternion[])+28]");
												num14 = 0f * num8;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v1 (UnityEngine.Quaternion[])+24]");
												float num45 = 0f * num8;
												float num46 = num37 + num38;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v1 (UnityEngine.Quaternion[])+24]");
												float num47 = 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v9 (UnityEngine.Vector3[])+28]");
												num12 = num47 * 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X9_v1 (UnityEngine.Quaternion[])+28]");
												float num48 = 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v9 (UnityEngine.Vector3[])+28]");
												float num49 = num48 * 0f;
												float num50 = num39 - (float)obj27;
												num24 = num18 + num42;
												num22 = num14 + num16;
												num20 = num12 + num46;
												num11 = num50 - num49;
												num28 = num24 - num45;
												float num51 = num22 - num9;
												num25 = num20 - (float)obj7;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v15 (UnityEngine.Transform[])+v237 @ X24_v5*8]");
												((Transform)0).localRotation = (Quaternion)0;
												axis = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array5[0]);
												vector2 = (Vector3)num51;
												array2 = axes;
												num27 = unchecked((nint)null);
												goto IL_0b62;
											}
										}
									}
								}
							}
							throw new IndexOutOfRangeException();
						}
					}
				}
				object obj28 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v4+E4]");
				bool flag22 = (nint)0 == 0;
				object obj29 = !flag22;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(humming != null))
				{
					return;
				}
				vector = (Vector3)work;
				bool flag23 = work < 0f;
				num8 = 0f;
				if (!flag23)
				{
					flag6 = !((double)work > 1.0);
					num8 = work;
					if (!flag6)
					{
						num8 = 1f;
					}
				}
				bool flag24 = (object)humming == null;
				obj10 = 0;
				num27 = unchecked((nint)null);
				if (flag24)
				{
					break;
				}
				float num52 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AECC]");
				float num53 = num52 * 0f;
				float num54 = num53;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE68]");
				float pitch = num54 + 0f;
				humming.pitch = pitch;
				return;
				IL_0b62:
				array = spinners;
				obj15 = obj11 + 1;
				obj16 = obj12 + 4;
				obj17 = obj13 + 12;
				bool flag25 = spinners == null;
				obj30 = !flag25;
				num4 = num11;
				num19 = num18;
				num21 = num20;
				num23 = num22;
				num = num24;
				vector = vector2;
				num8 = num25;
				array3 = array2;
				obj10 = 0;
				num5 = num28;
				obj9 = 0;
				num26 = num27;
				array4 = array5;
				obj11 = obj15;
				obj12 = obj16;
				obj13 = obj17;
			}
			while (obj30 != null);
		}
		throw new NullReferenceException();
	}

	private void Lamps(float dt)
	{
		//IL_0564: Invalid comparison between F8 and I4
		//IL_0577: Expected Obj, but got F8
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected Obj, but got Unknown
		//IL_05b6: Expected Obj, but got I4
		//IL_05e6: Expected Obj, but got I4
		//IL_05fe: Invalid comparison between F4 and I4
		//IL_0620: Expected Obj, but got I4
		//IL_0025: Expected F4, but got I4
		//IL_0083: Invalid comparison between F4 and I4
		//IL_0092: Expected F8, but got I4
		//IL_06c1: Invalid comparison between F8 and I4
		//IL_06d0: Expected F8, but got I4
		//IL_06e9: Invalid comparison between F4 and I4
		//IL_072d: Expected Obj, but got I
		//IL_0764: Expected F8, but got I4
		//IL_07e9: Expected Obj, but got I4
		//IL_03cb: Expected Obj, but got I4
		//IL_01e0: Expected I4, but got I8
		//IL_01fa: Expected Obj, but got I4
		//IL_0435: Invalid comparison between F4 and I4
		//IL_0247: Expected Obj, but got I4
		//IL_02c8: Expected Obj, but got I
		//IL_02f2: Expected Obj, but got I4
		//IL_0489: Invalid comparison between F4 and I4
		//IL_0498: Invalid comparison between F4 and I4
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04c0: Expected Obj, but got F4
		//IL_04f5: Expected Obj, but got I4
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected I4, but got Unknown
		//IL_0455: Expected F4, but got I4
		//IL_0338: Expected Obj, but got I
		//IL_0354: Expected VT, but got I4
		//IL_0265: Expected Obj, but got I
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		float num = dt * 1.5f;
		float num2 = dt * 1.5f;
		float num3 = 0f - num2;
		double num4 = 0.0 - (double)flash;
		bool flag = num4 < 0.0;
		object obj = num4 ^ num4;
		object obj2 = num4 & obj;
		bool flag2 = (nint)obj2 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag3 = flag == flag2;
		object obj3 = !flag3;
		object obj4 = ~obj3;
		if (obj4 != null)
		{
			num3 = num;
		}
		bool flag4 = num4 < (double)num;
		object obj5 = !flag4;
		float num5 = (float)num4 - num;
		bool flag5 = num5 == 0f;
		float num6 = flash + num3;
		object obj6 = !flag5;
		object obj7 = obj5 & obj6;
		object obj8 = ~obj7;
		if (obj8 != null)
		{
			num6 = 0f;
		}
		flash = num6;
		float time = Time.time;
		float num7 = time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
		float num8 = num7 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		float time2 = Time.time;
		float num9 = time2 * 6f;
		float num10 = num9 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num11 = num10 + num10;
		float num12 = num9 - num11;
		bool flag6 = num12 < 0f;
		double num13 = 0.0;
		if (!flag6)
		{
			bool flag7 = !((double)num12 > 2.0);
			num13 = num12;
			if (!flag7)
			{
				num13 = 2.0;
			}
		}
		double num14 = num13 + -1.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		double num15 = 1.0 - num14;
		bool flag8 = num15 < 0.0;
		double num16 = 0.0;
		if (!flag8)
		{
			bool flag9 = !(num15 > 1.0);
			num16 = num15;
			if (!flag9)
			{
				num16 = 1.0;
			}
		}
		bool flag10 = work < 0f;
		double num17 = num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF14]");
		double num18 = num17 * 0.0;
		float num19 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		float num20 = num19 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj9 = 0;
		double num21 = num18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		double num22 = num21 + 0.0;
		float num23 = num20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		float num24 = num23 + 0f;
		double num25 = 0.0;
		if (!flag10)
		{
			bool flag11 = !((double)work > 1.0);
			num25 = work;
			if (!flag11)
			{
				num25 = 1.0;
			}
		}
		double num26 = num22 - (double)num24;
		object obj10 = obj9;
		double num27 = num26 * num25;
		float num28 = flash;
		double num29 = (double)flash * 3.0;
		float num30 = num24 + (float)num27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v5+E4]");
		bool flag12 = (nint)0 == 0;
		object obj11 = !flag12;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num31 = num30 + (float)num29;
		bool flag13 = body != null;
		bool flag14 = !flag13;
		double num32 = 3.0;
		int num33 = 0;
		MaterialPropertyBlock materialPropertyBlock = null;
		float num34 = num31;
		if (!flag14)
		{
			int num35 = (int)(lampSlot & 0x80000000L);
			bool flag15 = num35 == 0;
			object obj12 = !flag15;
			num32 = 3.0;
			num33 = 0;
			materialPropertyBlock = null;
			num34 = num31;
			if (obj12 == null)
			{
				bool flag16 = lampBlock == null;
				object obj13 = !flag16;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					MaterialPropertyBlock materialPropertyBlock2 = default;
					materialPropertyBlock2._002Ector();
					object obj15 = this + 344;
					lampBlock = materialPropertyBlock2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				body.GetPropertyBlock(lampBlock, lampSlot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6270]");
				object obj16 = 0;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v22+E4]");
				bool flag17 = (nint)0 == 0;
				object obj18 = !flag17;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj19 = obj16;
				object obj20 = default;
				num34 = (float)lampColour * (float)obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v16+A0]");
				object obj21 = 0;
				MaterialPropertyBlock materialPropertyBlock3 = lampBlock;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v17+4]");
				materialPropertyBlock3.SetColor(0, (Color)0);
				num33 = lampSlot;
				materialPropertyBlock = lampBlock;
				body.SetPropertyBlock(lampBlock, lampSlot);
				double num36 = default;
				num32 = num36;
				float num37 = default;
				num28 = num37;
				double num38 = default;
				num27 = num38;
			}
		}
		object obj22 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v12+E4]");
		bool flag18 = (nint)0 == 0;
		object obj23 = !flag18;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (beacon != null)
		{
			float num39 = num31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9E4]");
			float num40 = num39 + 0f;
			if (num40 < 0f)
			{
				num40 = 0f;
			}
			float num41 = num40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			float intensity = num41 * 0f;
			beacon.intensity = intensity;
			float intensity2 = beacon.intensity;
			float num42 = intensity2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
			float num43 = num42 - 0f;
			bool flag19 = num43 < 0f;
			bool flag20 = num43 == 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
			object obj24 = intensity2 ^ 0;
			object obj25 = intensity2 ^ num43;
			object obj26 = obj24 & obj25;
			bool flag21 = (nint)obj26 < 0;
			bool flag22 = flag19 == flag21;
			object obj27 = !flag20;
			bool flag23 = (byte)((flag22 & obj27) ? 1 : 0) != 0;
			beacon.enabled = flag23;
		}
	}

	private void Wake(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_040f: Expected Obj, but got I4
		//IL_0447: Expected Obj, but got I4
		//IL_0206: Expected F4, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_0318: Expected F8, but got I
		//IL_02c3: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I4
		//IL_038c: Invalid comparison between F4 and I4
		//IL_03a3: Expected Obj, but got F4
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected Obj, but got Unknown
		//IL_04fb: Expected F4, but got I
		//IL_04fb: Expected Obj, but got I
		//IL_02e3: Expected Obj, but got I4
		//IL_0465: Expected Obj, but got I
		//IL_048f: Expected Obj, but got I4
		//IL_0541: Invalid comparison between F8 and I4
		//IL_0554: Expected Obj, but got F8
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got Unknown
		//IL_0592: Expected Obj, but got I4
		//IL_0326: Expected F8, but got I4
		//IL_05dd: Expected Obj, but got I4
		//IL_05f5: Invalid comparison between F4 and I4
		//IL_0606: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = main != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			Camera main2 = Camera.main;
			Transform transform = main2.transform;
			obj4 = null;
			obj5 = transform;
		}
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num4;
		if (obj5 != null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v16+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (screen != null)
			{
				Vector3 position = ((Transform)obj5).position;
				Transform transform2 = screen.transform;
				Vector3 position2 = transform2.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj10 = 0;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v26+E4]");
				bool flag6 = (nint)0 == 0;
				object obj12 = !flag6;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num = dt - dt;
				object obj14 = default;
				object obj13 = obj14 - obj14;
				object obj16 = default;
				object obj15 = obj16 - obj16;
				float num2 = num * num;
				object obj17 = obj13 * obj13;
				float num3 = num2 + (float)obj17;
				object obj18 = obj15 * obj15;
				num4 = (float)obj18 + num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				goto IL_049d;
			}
		}
		num4 = 1.1202724E+09f;
		goto IL_049d;
		IL_0652:
		bool flag7;
		bool flag8;
		if (flag7 != flag8)
		{
			bool flag9 = !flag8;
			object obj19 = !flag9;
			object obj20 = ~obj19;
			if (obj20 == null)
			{
				object obj21 = 208;
			}
			else
			{
				object obj21 = 216;
			}
			wanted = flag8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaRecycler)+v395 @ X8_v12]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			Play((AudioClip)num5, 0f);
			flag7 = wanted;
		}
		double num6;
		if (!flag7)
		{
			num6 = 0.25;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			num6 = 0.0;
		}
		float num7 = dt / (float)num6;
		double num8 = (flag7 ? 1.0 : 0.0);
		double num9 = num8 - (double)awake;
		bool flag10 = num9 < 0.0;
		object obj22 = num9 ^ num9;
		object obj23 = num9 & obj22;
		bool flag11 = (nint)obj23 < 0;
		float num10 = 0f - num7;
		bool flag12 = flag10 == flag11;
		object obj24 = !flag12;
		object obj25 = ~obj24;
		float num11 = ((obj25 != null) ? num7 : num10);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num12 = awake + num11;
		bool flag13 = num10 < num7;
		object obj26 = !flag13;
		float num13 = num10 - num7;
		bool flag14 = num13 == 0f;
		object obj27 = !flag14;
		object obj28 = obj26 & obj27;
		object obj29 = ~obj28;
		double num14 = ((obj29 != null) ? num8 : ((double)num12));
		bool flag15 = num14 == (double)awake;
		awake = (float)num14;
		if (!flag15)
		{
			dirty = true;
		}
		return;
		IL_049d:
		flag7 = wanted;
		if (!(num4 < wakeRange))
		{
			double num15 = (double)wakeRange + 2.0;
			if ((double)num4 < num15 && ~(wanted ? 1u : 0u) == 0)
			{
				flag7 = true;
			}
			else
			{
				List<Going> list = going;
				if (list._size <= 0)
				{
					bool flag16 = shown < 0f;
					object obj30 = shown ^ shown;
					object obj31 = shown & obj30;
					bool flag17 = (nint)obj31 < 0;
					bool flag18 = flag16 == flag17;
					flag8 = flag18;
					goto IL_0652;
				}
			}
		}
		flag8 = true;
		goto IL_0652;
	}

	private unsafe void Spark(Vector3 at, float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02c3: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_02e1: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0318: Invalid comparison between F4 and Obj
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0466: Expected F4, but got I
		//IL_0466: Expected F4, but got I
		//IL_0347: Expected Obj, but got I
		//IL_0364: Expected Obj, but got I
		//IL_0381: Expected Obj, but got I
		//IL_038f: Expected VT, but got I4
		//IL_03ac: Expected Obj, but got I
		//IL_03c9: Expected F4, but got I
		//IL_03c9: Expected F4, but got I
		//IL_0401: Expected F4, but got I
		//IL_0401: Expected F4, but got I
		//IL_0440: Expected F4, but got I
		//IL_0440: Expected F4, but got I
		//IL_01d1: Expected VT, but got I4
		//IL_01ee: Expected F4, but got I
		//IL_01ee: Expected F4, but got I
		//IL_0221: Expected F4, but got I
		//IL_0221: Expected F4, but got I
		//IL_025a: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = sparks == null;
		bool flag3 = !flag2;
		ParticleSystem particleSystem = null;
		if (!flag3)
		{
			ParticleSystem particleSystem2 = (sparks = MakeSparks());
			object obj4 = this + 400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			particleSystem = particleSystem2;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = sparks == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		Vector3 vector = Front;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v8+A0]");
		object obj10 = 0;
		float value = UnityEngine.Random.value;
		object obj12 = default;
		object obj11 = obj12 * 1114636288;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)value) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
		{
			return;
		}
		int num = UnityEngine.Random.Range(1, 4);
		if (num >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v9+18]");
			object obj14 = default;
			object obj13 = obj14 * 0;
			float num2 = dt;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v9+1C]");
			float num3 = num2 * 0f;
			float num4 = (float)obj13 - num3;
			int num5 = num;
			ParticleSystem.EmitParams emitParams = default;
			object obj21 = default;
			object obj22 = default;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				float num7 = UnityEngine.Random.Range(num6, 0f);
				object obj15 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v17+A0]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v18+1C]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
				object obj17 = num8 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v18+20]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
				object obj18 = num9 * 0;
				emitParams.position = (Vector3)0;
				object obj19 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v20+A0]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A888]");
				float num11 = UnityEngine.Random.Range(num10, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v21+20]");
				float num12 = 0f * num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
				float num14 = UnityEngine.Random.Range(num13, 0f);
				float num15 = (float)obj21 * num14;
				float num16 = num12 + num15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9E4]");
				nint num17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
				float num18 = UnityEngine.Random.Range(num17, 0f);
				float num19 = num4 * num18;
				float num20 = num16 + num19;
				emitParams.velocity = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				nint num21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				float startLifetime = UnityEngine.Random.Range(num21, 0f);
				emitParams.startLifetime = startLifetime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC40]");
				nint num22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D8]");
				float startSize = UnityEngine.Random.Range(num22, 0f);
				emitParams.startSize = startSize;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				sparks.Emit((ParticleSystem.EmitParams)(&obj22), 1);
				num5--;
			}
			while (num5 != 1);
		}
	}

	private unsafe ParticleSystem MakeSparks()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0760: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I
		//IL_01c0: Expected VT, but got Ref
		//IL_01d6: Expected F4, but got I
		//IL_01e7: Expected VT, but got Ref
		//IL_026a: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I
		//IL_02b8: Expected VT, but got I4
		//IL_02fc: Expected Obj, but got Ref
		//IL_0326: Expected VT, but got I4
		//IL_033a: Expected Obj, but got I8
		//IL_037a: Expected VT, but got I4
		//IL_0396: Expected Obj, but got I4
		//IL_03a6: Expected Obj, but got I4
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_03e9: Expected Obj, but got I
		//IL_048b: Expected Obj, but got I8
		//IL_04fb: Expected VT, but got Ref
		//IL_0543: Expected F4, but got I
		//IL_056f: Expected VT, but got Ref
		//IL_05c3: Expected I4, but got I8
		//IL_05ea: Expected F4, but got I
		//IL_05fb: Expected VT, but got Ref
		//IL_0611: Expected F4, but got I
		//IL_0622: Expected VT, but got Ref
		//IL_0638: Expected F4, but got I
		//IL_0649: Expected VT, but got Ref
		//IL_065e: Expected Obj, but got I
		//IL_06a8: Expected F4, but got I
		//IL_06c2: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C30]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CB0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj6 = default;
		bool flag2 = obj6 == null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		ParticleSystem result = null;
		if (obj7 != null)
		{
			goto IL_070b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector((string)obj9);
		if ((object)gameObject != null)
		{
			Transform transform = gameObject.transform;
			Transform parent = base.transform;
			if ((object)transform != null)
			{
				transform.SetParent(parent, worldPositionStays: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CD0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				ParticleSystem particleSystem = default;
				if ((object)particleSystem != null)
				{
					particleSystem.Stop(withChildren: true, (ParticleSystemStopBehavior)0);
					ParticleSystem.MainModule main = particleSystem.main;
					ParticleSystem.MainModule mainModule = default;
					mainModule.playOnAwake = false;
					mainModule.simulationSpace = (ParticleSystemSimulationSpace)1;
					ParticleSystem.MinMaxCurve minMaxCurve = 0f;
					object obj11 = default;
					mainModule.startSpeed = (ParticleSystem.MinMaxCurve)(&obj11);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE6C]");
					ParticleSystem.MinMaxCurve minMaxCurve2 = 0f;
					object obj12 = default;
					mainModule.gravityModifier = (ParticleSystem.MinMaxCurve)(&obj12);
					mainModule.maxParticles = 160;
					ParticleSystem.EmissionModule emission = particleSystem.emission;
					ParticleSystem.EmissionModule emissionModule = default;
					emissionModule.enabled = false;
					ParticleSystem.ShapeModule shape = particleSystem.shape;
					ParticleSystem.ShapeModule shapeModule = default;
					shapeModule.enabled = false;
					ParticleSystem.ColorOverLifetimeModule colorOverLifetime = particleSystem.colorOverLifetime;
					ParticleSystem.ColorOverLifetimeModule colorOverLifetimeModule = default;
					colorOverLifetimeModule.enabled = true;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54A0]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Gradient gradient = default;
					gradient._002Ector();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5498]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					GradientColorKey gradientColorKey = new GradientColorKey((Color)0, 1f);
					GradientColorKey[] array = default;
					if (array != null)
					{
						if (array.Length != 0)
						{
							GradientColorKey gradientColorKey2 = default;
							object obj15 = (object)(&gradientColorKey2);
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X24_v5+30]");
							_ = 0;
							GradientColorKey gradientColorKey3 = new GradientColorKey((Color)0, 1f);
							object obj16 = array.Length & 0xFFFFFFFEL;
							if (obj16 != null)
							{
								_ = 0;
								_ = 0;
								gradientColorKey2 = new GradientColorKey((Color)0, 0.75f);
								bool flag4 = array.Length < 2;
								object obj17 = !flag4;
								object obj18 = array.Length - 2;
								bool flag5 = obj18 == null;
								object obj19 = ~obj17;
								object obj20 = obj19 | flag5;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5490]");
									object obj21 = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									GradientAlphaKey gradientAlphaKey = new GradientAlphaKey(1f, 0f);
									GradientAlphaKey[] array2 = default;
									if (array2 == null)
									{
										goto IL_0710;
									}
									if (array2.Length != 0)
									{
										_ = 0;
										GradientAlphaKey gradientAlphaKey2 = new GradientAlphaKey(1f, 1f);
										object obj22 = array2.Length & 0xFFFFFFFEL;
										if (obj22 != null)
										{
											_ = 0;
											if ((object)gradient != null)
											{
												gradient.SetKeys(array, array2);
												ParticleSystem.MinMaxGradient minMaxGradient = gradient;
												object obj23 = default;
												colorOverLifetimeModule.color = (ParticleSystem.MinMaxGradient)(&obj23);
												ParticleSystem.SizeOverLifetimeModule sizeOverLifetime = particleSystem.sizeOverLifetime;
												ParticleSystem.SizeOverLifetimeModule sizeOverLifetimeModule = default;
												sizeOverLifetimeModule.enabled = true;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
												AnimationCurve curve = AnimationCurve.Linear(0f, 1f, 1f, 0f);
												ParticleSystem.MinMaxCurve minMaxCurve3 = new ParticleSystem.MinMaxCurve(1f, curve);
												object obj24 = default;
												sizeOverLifetimeModule.size = (ParticleSystem.MinMaxCurve)(&obj24);
												ParticleSystem.CollisionModule collision = particleSystem.collision;
												ParticleSystem.CollisionModule collisionModule = default;
												collisionModule.enabled = true;
												collisionModule.type = (ParticleSystemCollisionType)1;
												collisionModule.quality = (ParticleSystemCollisionQuality)2;
												LayerMask collidesWith = -5893;
												collisionModule.collidesWith = collidesWith;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
												ParticleSystem.MinMaxCurve minMaxCurve4 = 0f;
												object obj25 = default;
												collisionModule.bounce = (ParticleSystem.MinMaxCurve)(&obj25);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
												ParticleSystem.MinMaxCurve minMaxCurve5 = 0f;
												object obj26 = default;
												collisionModule.dampen = (ParticleSystem.MinMaxCurve)(&obj26);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
												ParticleSystem.MinMaxCurve minMaxCurve6 = 0f;
												object obj27 = default;
												collisionModule.lifetimeLoss = (ParticleSystem.MinMaxCurve)(&obj27);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CD8]");
												object obj28 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
												ParticleSystemRenderer particleSystemRenderer = default;
												if ((object)particleSystemRenderer != null)
												{
													particleSystemRenderer.renderMode = (ParticleSystemRenderMode)1;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8D4]");
													particleSystemRenderer.velocityScale = 0f;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
													particleSystemRenderer.lengthScale = 0f;
													particleSystemRenderer.sharedMaterial = (Material)obj6;
													particleSystemRenderer.shadowCastingMode = (ShadowCastingMode)0;
													particleSystemRenderer.receiveShadows = false;
													particleSystem.Play();
													result = particleSystem;
													goto IL_070b;
												}
											}
											goto IL_0710;
										}
									}
								}
							}
						}
						goto IL_071e;
					}
				}
			}
		}
		goto IL_0710;
		IL_070b:
		return result;
		IL_071e:
		return (ParticleSystem)(object)new IndexOutOfRangeException();
		IL_0710:
		NullReferenceException ex = new NullReferenceException();
		goto IL_071e;
	}

	private void Play(AudioClip clip, float volume)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0224: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I4
		//IL_01e3: Expected VT, but got I4
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
		if (!(screen != null))
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
			if ((object)screen != null)
			{
				Transform transform = screen.transform;
				if ((object)transform != null)
				{
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
					object obj8 = 0;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v23+E4]");
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

	private void Draw()
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got I4
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Expected Obj, but got Unknown
		//IL_091b: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I4
		//IL_08bd: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I4
		//IL_0ae2: Expected Obj, but got I4
		//IL_08a2: Expected Obj, but got I
		//IL_01d9: Expected Obj, but got I4
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_02b3: Expected Obj, but got I
		//IL_02e7: Expected Obj, but got I4
		//IL_031c: Expected Obj, but got I
		//IL_06ff: Expected Obj, but got I4
		//IL_0346: Expected Obj, but got I
		//IL_0356: Expected Obj, but got I
		//IL_03a0: Invalid comparison between F4 and I4
		//IL_03b1: Invalid comparison between F4 and I4
		//IL_071d: Expected Obj, but got I
		//IL_0401: Expected F8, but got I4
		//IL_07b3: Expected Obj, but got I4
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected Obj, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected Obj, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected Obj, but got Unknown
		//IL_0623: Expected Obj, but got I4
		//IL_0650: Expected Obj, but got I4
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_0807: Expected Obj, but got I
		//IL_081c: Expected I4, but got Obj
		//IL_0ac3: Expected Obj, but got I4
		//IL_0a9c: Expected Obj, but got I4
		//IL_0b16: Expected Obj, but got I
		//IL_0b24: Expected VT, but got Obj
		//IL_0b47: Expected VT, but got I8
		//IL_0b6a: Expected F4, but got I4
		//IL_0a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6b: Expected Obj, but got Unknown
		//IL_0a85: Expected Obj, but got I4
		//IL_04d5: Expected Obj, but got I4
		//IL_0a46: Expected Obj, but got I
		//IL_048e: Expected Obj, but got I4
		//IL_0a2b: Expected Obj, but got I
		//IL_0522: Expected Obj, but got I4
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected Obj, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected Obj, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected Obj, but got Unknown
		dirty = false;
		if (px == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = tex == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (screen == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6270]");
		object obj7 = 0;
		object obj8 = 0;
		object obj9 = 0;
		Color32[] array2 = default;
		object obj26 = default;
		MaterialPropertyBlock materialPropertyBlock = default;
		while (true)
		{
			object obj10 = obj7;
			object obj11 = obj8 & 1;
			bool flag5 = obj11 == null;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v58+E4]");
				bool flag6 = (nint)0 == 0;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj10 = obj7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v58+A0]");
				object obj14 = (nint)0 + (nint)56;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v58+E4]");
				bool flag7 = (nint)0 == 0;
				object obj15 = !flag7;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj10 = obj7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v58+A0]");
				object obj14 = (nint)0 + (nint)60;
			}
			object obj16 = obj9;
			object obj17 = 512;
			while (true)
			{
				Color32[] array = px;
				int num5;
				bool flag12;
				int num4;
				Color32[] array3;
				float num;
				if (px != null)
				{
					bool flag8 = (nint)obj16 < array.Length;
					object obj18 = !flag8;
					if (obj18 != null)
					{
						goto IL_085b;
					}
					object obj19 = (object)px + obj16;
					obj17--;
					obj16++;
					if ((nint)obj17 != 1)
					{
						continue;
					}
					obj8++;
					obj9 += 512;
					if ((nint)obj8 != 256)
					{
						break;
					}
					num = awake;
					if (!((double)awake < 1.0))
					{
						DrawUi();
						double num2 = 1.0;
						goto IL_0684;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj21 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v24+E4]");
					bool flag9 = (nint)0 == 0;
					object obj22 = !flag9;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj21 = obj7;
					}
					if (array2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v24+A0]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v25+48]");
						_ = 0;
						object obj24 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v27+A0]");
						object obj25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62B0]");
						object s = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v28+48]");
						_ = 0;
						Text(title, 256, 116, (string)s, array2, 3, centred: true);
						double num3 = awake;
						bool flag10 = awake < 0f;
						bool flag11 = !(awake > 0f);
						flag12 = true;
						num4 = 3;
						array3 = array2;
						num5 = 116;
						double num2 = 1.0;
						if (flag11)
						{
							goto IL_0684;
						}
						double num6 = 0.0;
						if (!flag10)
						{
							bool flag13 = !((double)awake > 1.0);
							num6 = awake;
							if (!flag13)
							{
								num6 = 1.0;
							}
						}
						double num7 = num6 + num6;
						double num8 = num6 * 3.0;
						double num9 = num6 * num7;
						double num10 = num6 * num9;
						double num11 = num6 * num8;
						double num12 = num11 - num10;
						num3 = 1.0 - num12;
						double num13 = num3 * 0.0;
						double num14 = num12 + num13;
						num2 = num14 * 1132462080.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7F0");
						DrawUi();
						if ((nint)obj26 > 255)
						{
							goto IL_05ae;
						}
						object obj27 = 130560 - obj26;
						object obj28 = obj26;
						while (true)
						{
							object obj29 = 0;
							while (true)
							{
								object obj30 = obj7;
								Color32[] array4 = px;
								object obj31 = obj28 & 1;
								bool flag14 = obj31 == null;
								object obj32 = !flag14;
								if (obj32 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X0_v50+E4]");
									bool flag15 = (nint)0 == 0;
									object obj33 = !flag15;
									if (obj33 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj30 = obj7;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X0_v50+A0]");
									object obj34 = (nint)0 + (nint)56;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X0_v50+E4]");
									bool flag16 = (nint)0 == 0;
									object obj35 = !flag16;
									if (obj35 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj30 = obj7;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X0_v50+A0]");
									object obj34 = (nint)0 + (nint)60;
								}
								if (px == null)
								{
									break;
								}
								object obj36 = obj27 + obj29;
								bool flag17 = (nint)obj36 < array4.Length;
								object obj37 = !flag17;
								if (obj37 == null)
								{
									object obj38 = (object)px + obj36;
									obj29++;
									if ((nint)obj29 != 512)
									{
										continue;
									}
									goto IL_0572;
								}
								goto IL_085b;
							}
							break;
							IL_0572:
							obj28++;
							obj27 -= 512;
							if ((nint)obj28 != 256)
							{
								continue;
							}
							goto IL_05ae;
						}
					}
				}
				goto IL_084d;
				IL_084d:
				NullReferenceException ex = new NullReferenceException();
				goto IL_085b;
				IL_05ae:
				object obj39 = obj7;
				object obj40 = obj26 - 254;
				bool flag18 = (nint)obj40 < 0;
				object obj41 = obj26 ^ 0xFE;
				object obj42 = obj26 ^ obj40;
				object obj43 = obj41 & obj42;
				bool flag19 = (nint)obj43 < 0;
				bool flag20 = flag18 == flag19;
				object obj44 = !flag20;
				object obj45 = ~obj44;
				object obj46 = ((obj45 != null) ? ((object)254) : obj26);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v42+E4]");
				bool flag21 = (nint)0 == 0;
				object obj47 = !flag21;
				if (obj47 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj39 = obj7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v42+A0]");
				object obj48 = 0;
				RectInt r = (RectInt)(obj46 << 32);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v33+40]");
				num5 = 0;
				FillRect(r, (Color32)8589935104L);
				flag12 = true;
				num4 = 3;
				array3 = array2;
				num = 1.1324621E+09f;
				goto IL_0684;
				IL_0684:
				if ((object)tex != null)
				{
					tex.SetPixels32(px);
					if ((object)tex != null)
					{
						tex.Apply(updateMipmaps: true);
						bool flag22 = block == null;
						object obj49 = !flag22;
						if (obj49 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
							object obj50 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							materialPropertyBlock._002Ector();
							object obj51 = this + 336;
							block = materialPropertyBlock;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						}
						if ((object)screen != null)
						{
							screen.GetPropertyBlock(block);
							object obj52 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v23+E4]");
							bool flag23 = (nint)0 == 0;
							object obj53 = !flag23;
							if (obj53 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (block != null)
							{
								object obj54 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v17+A0]");
								object obj55 = 0;
								block.SetTexture((int)obj55, tex);
								if ((object)screen != null)
								{
									screen.SetPropertyBlock(block);
									return;
								}
							}
						}
					}
				}
				goto IL_084d;
				IL_085b:
				throw new IndexOutOfRangeException();
			}
		}
	}

	private unsafe void DrawUi()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0e51: Expected Obj, but got I4
		//IL_1391: Expected Obj, but got I
		//IL_13a1: Expected Obj, but got I
		//IL_13b1: Expected Obj, but got I
		//IL_13c1: Expected Obj, but got I
		//IL_13d1: Expected Obj, but got I
		//IL_13e9: Expected VT, but got I8
		//IL_13e9: Expected VT, but got I8
		//IL_13f6: Expected VT, but got I8
		//IL_1403: Expected VT, but got I8
		//IL_140c: Expected Obj, but got I4
		//IL_0f28: Expected Obj, but got I4
		//IL_0e6f: Expected Obj, but got I
		//IL_0e7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e81: Expected VT, but got Unknown
		//IL_0e91: Expected Obj, but got I
		//IL_0ea4: Expected VT, but got I8
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb2: Expected Obj, but got Unknown
		//IL_0ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec0: Expected Obj, but got Unknown
		//IL_0eda: Expected Obj, but got I4
		//IL_0ef0: Expected VT, but got I8
		//IL_006d: Expected Obj, but got I4
		//IL_0f46: Expected Obj, but got I
		//IL_0f76: Expected Obj, but got I
		//IL_0f8e: Expected Obj, but got I
		//IL_0fac: Expected VT, but got I
		//IL_0fac: Expected VT, but got I
		//IL_0fd6: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_00f2: Expected VT, but got Obj
		//IL_0108: Expected VT, but got I
		//IL_0128: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I
		//IL_01ce: Expected I4, but got Obj
		//IL_081c: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got I4
		//IL_01f7: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I
		//IL_023b: Expected I4, but got Obj
		//IL_12ae: Expected Obj, but got I
		//IL_12be: Expected Obj, but got I
		//IL_12ce: Expected Obj, but got I
		//IL_12ec: Expected VT, but got I
		//IL_12ec: Expected VT, but got I
		//IL_1316: Expected Obj, but got I4
		//IL_1245: Expected Obj, but got I
		//IL_0868: Expected Obj, but got I
		//IL_08c2: Expected Obj, but got I
		//IL_08da: Expected Obj, but got I
		//IL_093e: Expected Obj, but got I
		//IL_0960: Expected Obj, but got I4
		//IL_026c: Expected Obj, but got I4
		//IL_099e: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I4
		//IL_0a14: Expected Obj, but got I
		//IL_0a42: Expected Obj, but got I
		//IL_0a5a: Expected Obj, but got I
		//IL_0af6: Expected Obj, but got I4
		//IL_1340: Unknown result type (might be due to invalid IL or missing references)
		//IL_1345: Expected Obj, but got Unknown
		//IL_0a9f: Expected Obj, but got I4
		//IL_034c: Expected Obj, but got I4
		//IL_1437: Expected VT, but got I
		//IL_1437: Expected VT, but got I
		//IL_1469: Expected VT, but got I
		//IL_1479: Expected VT, but got I
		//IL_0b26: Expected Obj, but got I
		//IL_132d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1332: Expected Obj, but got Unknown
		//IL_0ce3: Expected Obj, but got I4
		//IL_0acf: Expected Obj, but got I
		//IL_0372: Expected Obj, but got I
		//IL_0382: Expected Obj, but got I
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected Obj, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected I4, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected I4, but got Unknown
		//IL_03cd: Expected Obj, but got I
		//IL_0d2a: Expected Obj, but got I4
		//IL_0b47: Invalid comparison between F4 and I
		//IL_0b60: Expected VT, but got I
		//IL_0b70: Expected VT, but got I
		//IL_0d5f: Expected Obj, but got I
		//IL_0d6f: Expected Obj, but got I
		//IL_0da3: Expected Obj, but got I
		//IL_0db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db8: Expected Obj, but got Unknown
		//IL_0de0: Expected Obj, but got I4
		//IL_0441: Expected Obj, but got I4
		//IL_135a: Unknown result type (might be due to invalid IL or missing references)
		//IL_135f: Expected I4, but got Unknown
		//IL_136a: Invalid comparison between F4 and I4
		//IL_0ba8: Expected Obj, but got I4
		//IL_0e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e05: Expected Obj, but got Unknown
		//IL_0bef: Expected Obj, but got I4
		//IL_0467: Expected Obj, but got I
		//IL_0483: Expected Obj, but got I
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected I4, but got Unknown
		//IL_04ca: Expected Obj, but got I
		//IL_04f8: Expected Obj, but got I
		//IL_0c24: Expected Obj, but got I
		//IL_0c34: Expected Obj, but got I
		//IL_0c4a: Expected Obj, but got I
		//IL_0c60: Expected Obj, but got I
		//IL_0c76: Expected Obj, but got I
		//IL_0c8c: Expected Obj, but got I
		//IL_0c99: Expected VT, but got Obj
		//IL_0ca6: Expected VT, but got Obj
		//IL_0528: Expected Obj, but got I
		//IL_054c: Expected I4, but got Obj
		//IL_0575: Expected Obj, but got I4
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected I4, but got Unknown
		//IL_100e: Expected Obj, but got I4
		//IL_0666: Expected Obj, but got I4
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Expected I4, but got Unknown
		//IL_06b0: Expected Obj, but got I
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected Obj, but got Unknown
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected Obj, but got Unknown
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected Obj, but got Unknown
		//IL_06ea: Expected Obj, but got I
		//IL_06fa: Expected Obj, but got I
		//IL_0717: Expected Obj, but got I
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Expected Obj, but got Unknown
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected Obj, but got Unknown
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected Obj, but got Unknown
		//IL_07a9: Expected Obj, but got I4
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Expected Obj, but got Unknown
		//IL_1024: Unknown result type (might be due to invalid IL or missing references)
		//IL_1029: Expected Obj, but got Unknown
		//IL_1032: Unknown result type (might be due to invalid IL or missing references)
		//IL_1037: Expected I4, but got Unknown
		//IL_1073: Unknown result type (might be due to invalid IL or missing references)
		//IL_1078: Expected I4, but got Unknown
		//IL_1088: Expected Obj, but got I
		//IL_10a5: Expected Obj, but got I
		//IL_10b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ba: Expected Obj, but got Unknown
		//IL_10e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ed: Expected Obj, but got Unknown
		//IL_10fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1102: Expected Obj, but got Unknown
		//IL_1137: Expected Obj, but got I4
		//IL_113f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1144: Expected Obj, but got Unknown
		//IL_1163: Unknown result type (might be due to invalid IL or missing references)
		//IL_1168: Expected Obj, but got Unknown
		//IL_1171: Unknown result type (might be due to invalid IL or missing references)
		//IL_1176: Expected I4, but got Unknown
		//IL_11af: Expected Obj, but got I4
		//IL_07ef: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C62B0]");
		object s = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4+44]");
		object obj7 = 0;
		Outline((RectInt)8589934594L, (Color32)1082331759100L);
		Color32 color = (Color32)1082331759100L;
		RectInt rectInt = (RectInt)8589934594L;
		object obj8 = 0;
		object obj14;
		do
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v7+A0]");
			object obj11 = 0;
			rectInt = (RectInt)(obj8 + 8589934892L);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v7+40]");
			obj7 = 0;
			FillRect(rectInt, (Color32)8589934599L);
			object obj12 = obj8 + 300;
			obj8 += 12;
			bool flag3 = (nint)obj12 < 492;
			object obj13 = !flag3;
			obj14 = ~obj13;
			color = (Color32)8589934599L;
		}
		while (obj14 != null);
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v10+A0]");
		object obj17 = 0;
		ScreenFont font = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v10+50]");
		Text(font, 10, 6, (string)s, (Color32[])0, 2, centred: false);
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v11+A0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v12+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v12+10]");
		Outline((RectInt)num, (Color32)0);
		object obj20 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v14+A0]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v15+8]");
		object obj24 = (nint)0 + (nint)3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v15+C]");
		object obj25 = (nint)0 + (nint)3;
		RectInt r = (RectInt)(obj24 | obj25);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v15+10]");
		Outline(r, (Color32)0);
		object obj26 = obj;
		string text = (string)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v16+A0]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v17+8]");
		int num2 = (int)((nint)0 + (nint)6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v17+C]");
		int num3 = (int)((nint)0 + (nint)5);
		ScreenFont font2 = this.text;
		int x = num2;
		int y = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v17+50]");
		Text(font2, x, y, (string)obj5, (Color32[])0, 1, centred: false);
		(string, int)[] array = prices;
		bool flag6 = prices == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v17+50]");
		Color32[] array2 = (Color32[])0;
		bool flag7 = false;
		int num4 = 1;
		int num5 = (int)this.text;
		if (flag6)
		{
			goto IL_07f4;
		}
		object obj28 = 32;
		object obj29 = 22;
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v17+50]");
		Color32[] array3 = (Color32[])0;
		bool flag8 = false;
		int num6 = 1;
		string text2 = (string)obj5;
		int num7 = num3;
		int num8 = num2;
		int num9 = (int)this.text;
		(string, int)[] array4 = prices;
		NullReferenceException ex;
		while (true)
		{
			ex = (NullReferenceException)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v18 (System.NullReferenceException)+E4]");
			array = ((string, int)[])0;
			bool flag9 = (nint)obj30 >= array4.Length;
			array2 = array3;
			flag7 = flag8;
			num4 = num6;
			text = text2;
			num3 = num7;
			num2 = num8;
			num5 = num9;
			if (flag9)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v18 (System.NullReferenceException)+E4]");
			bool flag10 = (nint)0 == 0;
			object obj31 = !flag10;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj32 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v62+E4]");
			bool flag11 = (nint)0 == 0;
			object obj33 = !flag11;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			array = prices;
			bool flag12 = prices == null;
			array2 = array3;
			flag7 = flag8;
			num4 = num6;
			text = text2;
			num3 = num7;
			num2 = num8;
			num5 = num9;
			if (!flag12)
			{
				bool flag13 = (nint)obj30 < array.Length;
				object obj34 = !flag13;
				if (obj34 != null)
				{
					goto IL_0e20;
				}
				object obj35 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X9_v21+A0]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X9_v22+8]");
				object obj37 = 0;
				object obj38 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X9_v23+C]");
				object obj39 = obj38 + 0;
				num2 = obj37 + 6;
				num3 = obj39 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v19 (System.ValueTuple`2<System.String, System.Int32>[])+v220 @ X28_v6]");
				Icon((string)0, num2, num3);
				array = prices;
				bool flag14 = prices == null;
				array2 = array3;
				flag7 = flag8;
				num4 = num6;
				text = text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v19 (System.ValueTuple`2<System.String, System.Int32>[])+v220 @ X28_v6]");
				num5 = 0;
				if (!flag14)
				{
					bool flag15 = (nint)obj30 < array.Length;
					object obj40 = !flag15;
					if (obj40 != null)
					{
						goto IL_0e20;
					}
					object obj41 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X9_v25+A0]");
					object obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v19 (System.ValueTuple`2<System.String, System.Int32>[])+v220 @ X28_v6]");
					string text3 = Fit((string)0, 84, 1);
					object obj43 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X9_v26+8]");
					num2 = (int)((nint)0 + (nint)24);
					object obj44 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X9_v23+C]");
					num3 = obj44 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v62+A0]");
					object obj45 = 0;
					ScreenFont font3 = this.text;
					int x2 = num2;
					int y2 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v63+50]");
					Text(font3, x2, y2, text3, (Color32[])0, 1, centred: false);
					array = prices;
					bool flag16 = prices == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v63+50]");
					array2 = (Color32[])0;
					flag7 = false;
					num4 = 1;
					text = text3;
					num5 = (int)this.text;
					if (!flag16)
					{
						bool flag17 = (nint)obj30 < array.Length;
						object obj46 = !flag17;
						if (obj46 != null)
						{
							goto IL_0e20;
						}
						object obj47 = (object)prices + obj28;
						int num10 = obj47 + 8;
						string text4 = ((int*)num10)->ToString();
						ScreenFont font4;
						int num12;
						if (this.text != null)
						{
							int num11 = this.text.Measure(text4, 1);
							font4 = this.text;
							num12 = num11;
							num3 = 0;
							num2 = 1;
							string text5 = text4;
						}
						else
						{
							font4 = null;
							num12 = 12;
							string text5 = null;
						}
						object obj48 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v73+E4]");
						bool flag18 = (nint)0 == 0;
						object obj49 = !flag18;
						if (obj49 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj50 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X0_v75+E4]");
						bool flag19 = (nint)0 == 0;
						object obj51 = !flag19;
						if (obj51 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj52 = obj;
						object obj53 = obj29;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X9_v23+C]");
						int y3 = obj53 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v69+A0]");
						object obj54 = 0;
						obj28 += 16;
						object obj55 = obj29 + 21;
						obj30++;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v70+8]");
						object obj56 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v70+60]");
						array2 = (Color32[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v70+10]");
						nint num13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v70+8]");
						object obj57 = num13 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v70+8]");
						object obj58 = 0 - obj57;
						bool flag20 = (nint)obj58 < 0;
						bool flag21 = obj58 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v70+8]");
						object obj59 = 0 ^ obj57;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v70+8]");
						object obj60 = 0 ^ obj58;
						object obj61 = obj59 & obj60;
						bool flag22 = (nint)obj61 < 0;
						bool flag23 = flag20 == flag22;
						object obj62 = !flag21;
						object obj63 = flag23 & obj62;
						object obj64 = ~obj63;
						if (obj64 != null)
						{
							obj56 = obj57;
						}
						object obj65 = obj56 - num12;
						int x3 = obj65 - 6;
						Text(font4, x3, y3, text4, array2, 1, centred: false);
						object obj66 = obj;
						object obj67 = obj29;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X9_v23+C]");
						num2 = obj67 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X8_v72+A0]");
						object obj68 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v73+10]");
						nint num14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v73+8]");
						object obj69 = num14 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v73+8]");
						object obj70 = 0 - obj69;
						bool flag24 = (nint)obj70 < 0;
						bool flag25 = obj70 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v73+8]");
						object obj71 = 0 ^ obj69;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v73+8]");
						object obj72 = 0 ^ obj70;
						object obj73 = obj71 & obj72;
						bool flag26 = (nint)obj73 < 0;
						bool flag27 = flag24 == flag26;
						object obj74 = !flag25;
						object obj75 = flag27 & obj74;
						object obj76 = ~obj75;
						if (obj76 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v73+8]");
							obj69 = 0;
						}
						object obj77 = obj69 - num12;
						num5 = obj77 - 16;
						BoltIcon(num5, num2, 1);
						array = prices;
						bool flag28 = prices == null;
						object obj78 = !flag28;
						flag7 = false;
						num4 = 1;
						text = text4;
						num3 = 1;
						obj29 = obj55;
						array3 = array2;
						flag8 = false;
						num6 = 1;
						text2 = text4;
						num7 = 1;
						num8 = num2;
						num9 = num5;
						array4 = prices;
						if (obj78 != null)
						{
							continue;
						}
					}
				}
			}
			goto IL_07f4;
			IL_0e20:
			throw new IndexOutOfRangeException();
		}
		goto IL_0802;
		IL_07f4:
		ex = new NullReferenceException();
		goto IL_0802;
		IL_0802:
		bool flag29 = array == null;
		object obj79 = !flag29;
		if (obj79 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ex = (NullReferenceException)obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
		object obj80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64B0]");
		object s2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v18 (System.NullReferenceException)+A0]");
		object obj81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v20+18]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v20+20]");
		Outline((RectInt)num15, (Color32)0);
		object obj82 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v20+E4]");
		bool flag30 = (nint)0 == 0;
		object obj83 = !flag30;
		if (obj83 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj84 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v22+A0]");
		object obj85 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v23+18]");
		int x4 = (int)((nint)0 + (nint)6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v23+1C]");
		int y4 = (int)((nint)0 + (nint)5);
		ScreenFont font5 = this.text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v23+50]");
		Text(font5, x4, y4, (string)s2, (Color32[])0, 1, centred: false);
		object obj86 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v24+A0]");
		object obj87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v25+18]");
		int x5 = (int)((nint)0 + (nint)8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v25+1C]");
		int y5 = (int)((nint)0 + (nint)30);
		BoltIcon(x5, y5, 2);
		object obj88 = obj;
		object obj89 = obj80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v27+A0]");
		object obj90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v24+E4]");
		bool flag31 = (nint)0 == 0;
		object obj91 = !flag31;
		if (obj91 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string boltsText = Coins.BoltsText;
		object obj92 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v29+A0]");
		object obj93 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v30+20]");
		int width = (int)(-34);
		string s3 = Fit(boltsText, width, 3);
		object obj94 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v28+18]");
		int x6 = (int)((nint)0 + (nint)28);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v28+1C]");
		int y6 = (int)((nint)0 + (nint)26);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v32+A0]");
		object obj95 = 0;
		ScreenFont font6 = this.text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v33+50]");
		Text(font6, x6, y6, s3, (Color32[])0, 3, centred: false);
		object obj96 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X0_v31+A0]");
		object obj97 = 0;
		object obj100;
		if (!((double)shown < 1.0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X0_v31+E4]");
			bool flag32 = (nint)0 == 0;
			object obj98 = !flag32;
			if (obj98 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj99 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v53+A0]");
				obj97 = 0;
			}
			obj100 = obj97 + 76;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X0_v31+E4]");
			bool flag33 = (nint)0 == 0;
			object obj101 = !flag33;
			if (obj101 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj102 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v49+A0]");
				obj97 = 0;
			}
			obj100 = obj97 + 64;
		}
		object obj103 = obj100;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v47+28]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v47+30]");
		Outline((RectInt)num16, (Color32)0);
		bool flag34 = (double)shown < 1.0;
		double num17 = 1.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v47+30]");
		Color32 color2 = (Color32)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v47+28]");
		RectInt rectInt2 = (RectInt)0;
		if (!flag34)
		{
			num17 = flash;
			float num18 = flash;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			bool flag35 = !(num18 > 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v47+30]");
			color2 = (Color32)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v47+28]");
			rectInt2 = (RectInt)0;
			if (!flag35)
			{
				object obj104 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X0_v42+E4]");
				bool flag36 = (nint)0 == 0;
				object obj105 = !flag36;
				if (obj105 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj106 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X0_v44+E4]");
				bool flag37 = (nint)0 == 0;
				object obj107 = !flag37;
				if (obj107 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj108 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v45+A0]");
				object obj109 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v46+4C]");
				obj103 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v46+28]");
				object obj110 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v46+2C]");
				object obj111 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v46+30]");
				object obj112 = -2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v46+34]");
				object obj113 = -2;
				rectInt2 = (RectInt)(obj110 | obj111);
				color2 = (Color32)(obj112 | obj113);
				Outline(rectInt2, color2);
			}
		}
		object obj114 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v35+E4]");
		bool flag38 = (nint)0 == 0;
		object obj115 = !flag38;
		if (obj115 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj116 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X0_v37+E4]");
		bool flag39 = (nint)0 == 0;
		object obj117 = !flag39;
		if (obj117 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj118 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v39+A0]");
		object obj119 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v40+30]");
		object obj120 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v40+30]");
		bool flag40 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v40+30]");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v40+30]");
		object obj121 = num19 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v40+30]");
		object obj122 = 0 & obj121;
		bool flag41 = (nint)obj122 < 0;
		bool flag42 = flag40 == flag41;
		object obj123 = !flag42;
		object obj124 = ~obj123;
		if (obj124 == null)
		{
			obj120++;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v40+28]");
		int cx = 0 + obj120;
		if (shown < 0f)
		{
			DrawIdle(cx);
		}
		else
		{
			DrawWork(cx);
		}
	}

	private unsafe void DrawIdle(int cx)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0d6d: Expected Obj, but got I
		//IL_0d8f: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_0dad: Expected Obj, but got I
		//IL_0dd7: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I
		//IL_0159: Expected Obj, but got F4
		//IL_0167: Expected Obj, but got F4
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_0e87: Expected Obj, but got I4
		//IL_0209: Expected Obj, but got I4
		//IL_023e: Expected Obj, but got I
		//IL_025b: Expected Obj, but got I
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02ed: Expected Obj, but got I4
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_0dee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df3: Expected Obj, but got Unknown
		//IL_0dfb: Invalid comparison between F4 and Obj
		//IL_0589: Expected Obj, but got I4
		//IL_0321: Expected Obj, but got I
		//IL_05d0: Expected Obj, but got I4
		//IL_0348: Expected Obj, but got I4
		//IL_0605: Expected Obj, but got I
		//IL_0649: Expected Obj, but got I
		//IL_0661: Expected Obj, but got I
		//IL_0677: Expected Obj, but got I
		//IL_068d: Expected Obj, but got I
		//IL_06a3: Expected Obj, but got I
		//IL_06b0: Expected VT, but got Obj
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected VT, but got Unknown
		//IL_038f: Expected Obj, but got I4
		//IL_06ff: Expected Obj, but got I
		//IL_0759: Expected Obj, but got I
		//IL_03c4: Expected Obj, but got I
		//IL_03d4: Expected Obj, but got I
		//IL_03f1: Expected Obj, but got I
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected Obj, but got Unknown
		//IL_0483: Expected Obj, but got I4
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected Obj, but got Unknown
		//IL_078a: Expected Obj, but got I4
		//IL_079a: Expected Obj, but got I
		//IL_0908: Expected F4, but got I4
		//IL_0911: Expected Obj, but got I4
		//IL_0e1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e20: Expected Obj, but got Unknown
		//IL_0e28: Invalid comparison between F4 and Obj
		//IL_07e4: Expected Obj, but got I4
		//IL_0532: Expected Obj, but got I4
		//IL_082b: Expected Obj, but got I4
		//IL_0e5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e60: Expected Obj, but got Unknown
		//IL_04db: Expected Obj, but got I4
		//IL_0949: Expected Obj, but got I4
		//IL_0860: Expected Obj, but got I
		//IL_0870: Expected Obj, but got I
		//IL_0880: Expected Obj, but got I
		//IL_08cc: Expected Obj, but got I
		//IL_111f: Expected VT, but got Obj
		//IL_111f: Expected I4, but got F4
		//IL_113f: Expected I4, but got Obj
		//IL_1147: Expected Obj, but got F4
		//IL_0562: Expected Obj, but got I
		//IL_0e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4d: Expected Obj, but got Unknown
		//IL_0990: Expected Obj, but got I4
		//IL_050b: Expected Obj, but got I
		//IL_09c5: Expected Obj, but got I
		//IL_09d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09da: Expected I4, but got Unknown
		//IL_0a05: Expected Obj, but got I
		//IL_0a58: Expected Obj, but got I
		//IL_0ab6: Expected Obj, but got I
		//IL_0ae4: Expected Obj, but got I
		//IL_0b2c: Expected Obj, but got I
		//IL_0ebf: Expected Obj, but got I4
		//IL_0c0a: Expected Obj, but got I4
		//IL_0c3f: Expected Obj, but got I
		//IL_0c4f: Expected Obj, but got I
		//IL_0c6c: Expected Obj, but got I
		//IL_0c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c81: Expected Obj, but got Unknown
		//IL_0caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Expected Obj, but got Unknown
		//IL_0cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc9: Expected Obj, but got Unknown
		//IL_0cfe: Expected Obj, but got I4
		//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0b: Expected Obj, but got Unknown
		//IL_0ed5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eda: Expected Obj, but got Unknown
		//IL_0ee3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee8: Expected I4, but got Unknown
		//IL_0f14: Expected Obj, but got I
		//IL_0f2c: Expected Obj, but got I
		//IL_0f49: Expected Obj, but got I
		//IL_0f59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5e: Expected Obj, but got Unknown
		//IL_0f8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f91: Expected Obj, but got Unknown
		//IL_0fa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa6: Expected Obj, but got Unknown
		//IL_0fdb: Expected Obj, but got I4
		//IL_0fe3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe8: Expected Obj, but got Unknown
		//IL_1007: Unknown result type (might be due to invalid IL or missing references)
		//IL_100c: Expected Obj, but got Unknown
		//IL_1015: Unknown result type (might be due to invalid IL or missing references)
		//IL_101a: Expected I4, but got Unknown
		//IL_104e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1053: Expected Obj, but got Unknown
		//IL_106f: Expected Obj, but got I4
		//IL_1098: Expected Obj, but got I
		//IL_10ba: Expected Obj, but got I4
		//IL_0d44: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6528]");
		object s = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v5+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+2C]");
		int num = (int)((nint)0 + (nint)14);
		ScreenFont font = this.text;
		int y = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+50]");
		Text(font, cx, y, (string)s, (Color32[])0, 2, centred: true);
		float time = Time.time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v12+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6540]");
		object s2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6538]");
		object obj14 = 0;
		float num2 = time * 1.3215284E+09f;
		object obj15 = num2 >> 63;
		object obj16 = num2 >> 35;
		object obj17 = obj16 + obj15;
		object obj18 = obj17 * 26;
		float num3 = time - (float)obj18;
		float num4 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X11_v1+28]");
		float num5 = num4 + 0f;
		float num6 = num5 + 30f;
		int num7 = cx;
		ScreenFont screenFont = this.text;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj19 = !flag4;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj20 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj21 = !flag5;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v16+A0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v17+30]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v17+28]");
			object obj24 = num8 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v17+28]");
			object obj25 = 0 - obj24;
			bool flag6 = (nint)obj25 < 0;
			bool flag7 = obj25 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v17+28]");
			object obj26 = 0 ^ obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v17+28]");
			object obj27 = 0 ^ obj25;
			object obj28 = obj26 & obj27;
			bool flag8 = (nint)obj28 < 0;
			bool flag9 = flag6 == flag8;
			object obj29 = !flag7;
			object obj30 = flag9 & obj29;
			object obj31 = ~obj30;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v17+28]");
				obj24 = 0;
			}
			object obj32 = obj24 - 30;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num6) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32))
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v16+E4]");
			bool flag10 = (nint)0 == 0;
			object obj33 = !flag10;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj34 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v69+E4]");
			bool flag11 = (nint)0 == 0;
			object obj35 = !flag11;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj36 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v71+A0]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v81+28]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v81+30]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v81+28]");
			object obj39 = num9 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v81+28]");
			object obj40 = 0 - obj39;
			bool flag12 = (nint)obj40 < 0;
			bool flag13 = obj40 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v81+28]");
			object obj41 = 0 ^ obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v81+28]");
			object obj42 = 0 ^ obj40;
			object obj43 = obj41 & obj42;
			bool flag14 = (nint)obj43 < 0;
			bool flag15 = flag12 == flag14;
			object obj44 = !flag13;
			object obj45 = flag15 & obj44;
			object obj46 = ~obj45;
			if (obj46 != null)
			{
				obj38 = obj39;
			}
			object obj47 = obj38 - 90;
			object obj50;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num6) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj47))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v71+E4]");
				bool flag16 = (nint)0 == 0;
				object obj48 = !flag16;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj49 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v87+A0]");
					obj37 = 0;
				}
				obj50 = obj37 + 64;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v71+E4]");
				bool flag17 = (nint)0 == 0;
				object obj51 = !flag17;
				if (obj51 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj52 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v83+A0]");
					obj37 = 0;
				}
				obj50 = obj37 + 68;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v81+2C]");
			num7 = (int)((nint)0 + (nint)52);
			Chevron((int)num6, num7, (Color32)obj50);
			obj12 = obj;
			float num10 = num6 + 26f;
			num = (int)obj50;
			screenFont = (ScreenFont)num6;
			num6 = num10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v16+E4]");
		bool flag18 = (nint)0 == 0;
		object obj53 = !flag18;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj54 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v18+E4]");
		bool flag19 = (nint)0 == 0;
		object obj55 = !flag19;
		if (obj55 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj56 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v24+A0]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v25+2C]");
		int y2 = (int)((nint)0 + (nint)82);
		ScreenFont font2 = this.text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v25+58]");
		Text(font2, cx, y2, (string)s2, (Color32[])0, 1, centred: true);
		object obj58 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v26+A0]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v27+28]");
		object obj60 = (nint)0 + (nint)10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v27+2C]");
		object obj61 = (nint)0 + (nint)100;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v27+30]");
		object obj62 = -20;
		RectInt r = (RectInt)(obj60 | obj61);
		Color32 c = (Color32)(obj62 | 0x100000000L);
		FillRect(r, c);
		object obj63 = obj;
		ScreenFont screenFont2 = this.text;
		string text = (string)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v29+A0]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v30+28]");
		int num11 = (int)((nint)0 + (nint)10);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v30+2C]");
		int num12 = (int)((nint)0 + (nint)108);
		ScreenFont font3 = this.text;
		int x = num11;
		int y3 = num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v30+50]");
		Text(font3, x, y3, (string)obj14, (Color32[])0, 1, centred: false);
		List<(string, int, string)> list = log;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v35 (System.Collections.Generic.List`1<System.ValueTuple`3<System.String, System.Int32, System.String>>)+18]");
		bool flag20 = (nint)0 == 0;
		object obj65 = !flag20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v30+50]");
		Color32[] array = (Color32[])0;
		bool flag21 = false;
		int num13 = 1;
		if (obj65 == null)
		{
			object obj66 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v59+E4]");
			bool flag22 = (nint)0 == 0;
			object obj67 = !flag22;
			if (obj67 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj68 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X0_v61+E4]");
			bool flag23 = (nint)0 == 0;
			object obj69 = !flag23;
			if (obj69 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj70 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v74+A0]");
			object obj71 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6530]");
			object obj72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v75+58]");
			array = (Color32[])0;
			text = (string)obj72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v75+2C]");
			num12 = (int)((nint)0 + (nint)150);
			ScreenFont font4 = this.text;
			int y4 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v75+58]");
			Text(font4, cx, y4, (string)obj72, (Color32[])0, 2, centred: true);
			list = log;
			flag21 = true;
			num13 = 2;
			num11 = cx;
			screenFont2 = this.text;
		}
		float num14 = 0f;
		object obj73 = 129;
		int num15 = 0;
		string label = default;
		string s4 = default;
		float num27 = default;
		while (true)
		{
			int num16 = num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v35 (System.Collections.Generic.List`1<System.ValueTuple`3<System.String, System.Int32, System.String>>)+18]");
			if ((nint)num16 < (nint)0)
			{
				object obj74 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v28+E4]");
				bool flag24 = (nint)0 == 0;
				object obj75 = !flag24;
				if (obj75 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj76 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X0_v30+E4]");
				bool flag25 = (nint)0 == 0;
				object obj77 = !flag25;
				if (obj77 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj78 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v39+A0]");
				object obj79 = 0;
				object obj80 = obj73;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v40+2C]");
				int num17 = obj80 + 0;
				(System.__Canon, int, System.__Canon) tuple = ((List<(System.__Canon, int, System.__Canon)>)(object)log).get_Item(num15);
				object obj81 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v43+A0]");
				object obj82 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v44+28]");
				int x2 = (int)((nint)0 + (nint)12);
				Icon(label, x2, num17);
				object obj83 = obj;
				int num18 = num17 - 3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v46+A0]");
				object obj84 = 0;
				(System.__Canon, int, System.__Canon) tuple2 = ((List<(System.__Canon, int, System.__Canon)>)(object)log).get_Item(num15);
				string s3 = Fit(s4, 190, 2);
				object obj85 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v47+28]");
				int x3 = (int)((nint)0 + (nint)30);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v49+A0]");
				object obj86 = 0;
				ScreenFont font5 = this.text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v50+50]");
				Text(font5, x3, num18, s3, (Color32[])0, 2, centred: false);
				(System.__Canon, int, System.__Canon) tuple3 = ((List<(System.__Canon, int, System.__Canon)>)(object)log).get_Item(num15);
				int num19 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num14, 2));
				string text2 = ((int*)num19)->ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60E0]");
				object obj87 = 0;
				string text3 = (string)obj87 + text2;
				ScreenFont screenFont3;
				int num21;
				if (this.text != null)
				{
					int num20 = this.text.Measure(text3, 2);
					screenFont3 = this.text;
					num21 = num20;
					int num22 = 0;
					int num23 = 2;
					string text4 = text3;
				}
				else
				{
					screenFont3 = null;
					num21 = 24;
					int num22 = num18;
					int num23 = 0;
					string text4 = text2;
				}
				object obj88 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X0_v47+E4]");
				bool flag26 = (nint)0 == 0;
				object obj89 = !flag26;
				if (obj89 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj90 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v49+E4]");
				bool flag27 = (nint)0 == 0;
				object obj91 = !flag27;
				if (obj91 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj92 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v60+A0]");
				object obj93 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v61+28]");
				object obj94 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v61+30]");
				nint num24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v61+28]");
				object obj95 = num24 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v61+28]");
				object obj96 = 0 - obj95;
				bool flag28 = (nint)obj96 < 0;
				bool flag29 = obj96 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v61+28]");
				object obj97 = 0 ^ obj95;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v61+28]");
				object obj98 = 0 ^ obj96;
				object obj99 = obj97 & obj98;
				bool flag30 = (nint)obj99 < 0;
				bool flag31 = flag28 == flag30;
				object obj100 = !flag29;
				object obj101 = flag31 & obj100;
				object obj102 = ~obj101;
				if (obj102 != null)
				{
					obj94 = obj95;
				}
				object obj103 = obj94 - num21;
				int x4 = obj103 - 10;
				ScreenFont font6 = screenFont3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v61+60]");
				Text(font6, x4, num18, text3, (Color32[])0, 2, centred: false);
				object obj104 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X8_v63+A0]");
				object obj105 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v64+30]");
				nint num25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v64+28]");
				object obj106 = num25 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v64+28]");
				object obj107 = 0 - obj106;
				bool flag32 = (nint)obj107 < 0;
				bool flag33 = obj107 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v64+28]");
				object obj108 = 0 ^ obj106;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v64+28]");
				object obj109 = 0 ^ obj107;
				object obj110 = obj108 & obj109;
				bool flag34 = (nint)obj110 < 0;
				bool flag35 = flag32 == flag34;
				object obj111 = !flag33;
				object obj112 = flag35 & obj111;
				object obj113 = ~obj112;
				if (obj113 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v64+28]");
					obj106 = 0;
				}
				object obj114 = obj106 - num21;
				int num26 = obj114 - 22;
				BoltIcon(num26, num17, 1);
				list = log;
				num15++;
				obj73 += 26;
				bool flag36 = (object)log == null;
				object obj115 = !flag36;
				num14 = num27;
				time = num27;
				num12 = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v61+60]");
				array = (Color32[])0;
				flag21 = false;
				num13 = 2;
				num11 = num17;
				screenFont2 = (ScreenFont)num26;
				text = text3;
				if (obj115 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			break;
		}
	}

	private unsafe void DrawWork(int cx)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0e20: Expected Obj, but got I
		//IL_0e42: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected I4, but got Unknown
		//IL_04e1: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I4
		//IL_0635: Expected Obj, but got I8
		//IL_0e60: Expected Obj, but got I
		//IL_0e8a: Expected Obj, but got I4
		//IL_1138: Unknown result type (might be due to invalid IL or missing references)
		//IL_113d: Expected I4, but got Unknown
		//IL_115f: Expected Obj, but got I4
		//IL_053c: Expected Obj, but got I4
		//IL_054a: Expected Obj, but got I4
		//IL_059b: Expected Obj, but got I4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected I4, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01cc: Invalid comparison between I4 and F8
		//IL_0673: Expected Obj, but got I4
		//IL_0f2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2f: Expected Obj, but got Unknown
		//IL_01f4: Unsupported input type for neg.
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected I4, but got Unknown
		//IL_06a8: Expected Obj, but got I
		//IL_06f7: Expected Obj, but got I
		//IL_073b: Expected Obj, but got I
		//IL_0eba: Expected Obj, but got I4
		//IL_0758: Expected Obj, but got I
		//IL_0768: Expected Obj, but got I
		//IL_07be: Expected Obj, but got I
		//IL_07e0: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I4
		//IL_026c: Expected Obj, but got I
		//IL_082d: Expected Obj, but got I
		//IL_02b5: Expected Obj, but got I
		//IL_02f8: Expected Obj, but got I
		//IL_0326: Expected Obj, but got I
		//IL_0343: Expected Obj, but got I
		//IL_0353: Expected VT, but got I
		//IL_0369: Expected Obj, but got I
		//IL_037f: Expected Obj, but got I
		//IL_0395: Expected Obj, but got I
		//IL_03a2: Expected VT, but got Obj
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected VT, but got Unknown
		//IL_03d8: Expected Obj, but got I
		//IL_03e3: Invalid comparison between F4 and I4
		//IL_03f2: Expected F8, but got I4
		//IL_09ba: Expected Obj, but got I4
		//IL_087f: Expected Obj, but got I4
		//IL_0a01: Expected Obj, but got I4
		//IL_08c6: Expected Obj, but got I4
		//IL_111a: Expected Obj, but got I4
		//IL_0a36: Expected Obj, but got I
		//IL_0a53: Expected Obj, but got I
		//IL_08fb: Expected Obj, but got I
		//IL_0464: Invalid comparison between F8 and I4
		//IL_0a9b: Expected Obj, but got I
		//IL_0ac9: Expected Obj, but got I
		//IL_0930: Expected Obj, but got I
		//IL_0f75: Expected Obj, but got I4
		//IL_091b: Expected Obj, but got I
		//IL_117d: Expected Obj, but got I
		//IL_11c1: Expected Obj, but got I
		//IL_0fae: Expected Obj, but got I4
		//IL_0957: Expected Obj, but got I
		//IL_0fe6: Expected Obj, but got I4
		//IL_0ef4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef9: Expected Obj, but got Unknown
		//IL_0f13: Expected Obj, but got I4
		//IL_0b41: Expected Obj, but got I
		//IL_0be2: Expected Obj, but got I4
		//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bef: Expected Obj, but got Unknown
		//IL_1020: Expected Obj, but got I
		//IL_1029: Unknown result type (might be due to invalid IL or missing references)
		//IL_102e: Expected Obj, but got Unknown
		//IL_10e2: Expected Obj, but got I4
		//IL_0c6b: Expected Obj, but got I4
		//IL_1074: Expected Obj, but got I4
		//IL_0dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc9: Expected I4, but got Unknown
		//IL_0dd1: Invalid comparison between I4 and F8
		//IL_0ccd: Expected Obj, but got F4
		//IL_0cdb: Expected Obj, but got F4
		//IL_0cf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf6: Expected Obj, but got Unknown
		//IL_0d10: Expected Obj, but got I4
		//IL_0d87: Expected Obj, but got I4
		//IL_10b3: Expected Obj, but got I
		//IL_0d40: Expected Obj, but got I4
		//IL_11fa: Expected VT, but got Obj
		//IL_120c: Expected VT, but got Obj
		//IL_1215: Unknown result type (might be due to invalid IL or missing references)
		//IL_121a: Expected Obj, but got Unknown
		//IL_1222: Expected VT, but got I4
		//IL_122a: Expected VT, but got I4
		//IL_1098: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v5+A0]");
		object obj8 = 0;
		string s = Shown;
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v7+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v8+30]");
		int width = (int)(-20);
		string s2 = Fit(s, width, 3);
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v6+2C]");
		int num = (int)((nint)0 + (nint)14);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v10+A0]");
		object obj12 = 0;
		ScreenFont font = this.text;
		int y = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v11+50]");
		Text(font, cx, y, s2, (Color32[])0, 3, centred: true);
		object obj14;
		object obj30;
		double num6;
		double num7;
		double num8;
		double num10;
		if ((double)shown < 1.0)
		{
			object obj13 = 109891584;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v53+E4]");
			bool flag3 = (nint)0 == 0;
			object obj16 = !flag3;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			object obj17 = obj;
			double num2 = 0.0 - 1.0;
			int num3 = 1.0 & 3;
			object obj18 = num2 & 3;
			int num4 = ((!(0.0 < 1.0)) ? (0 - obj18) : num3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v55+E4]");
			bool flag4 = (nint)0 == 0;
			object obj19 = !flag4;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj20 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v57+E4]");
			bool flag5 = (nint)0 == 0;
			object obj21 = !flag5;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v54+A0]");
			object obj23 = 0;
			string text = ((string)null).CreateString('.', num4);
			int count = 3 - num4;
			string text2 = ((string)null).CreateString(' ', count);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6510]");
			object obj24 = 0;
			string s3 = (string)obj24 + text + text2;
			object obj25 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v55+2C]");
			int y2 = (int)((nint)0 + (nint)62);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v60+A0]");
			object obj26 = 0;
			ScreenFont font2 = this.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v61+50]");
			Text(font2, cx, y2, s3, (Color32[])0, 2, centred: true);
			object obj27 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v62+A0]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v63+40]");
			Color32 color = (Color32)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v63+28]");
			object obj29 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v63+2C]");
			obj30 = (nint)0 + (nint)92;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v63+30]");
			object obj31 = -48;
			RectInt r = (RectInt)(obj29 | obj30);
			Color32 c = (Color32)(obj31 | 0x1600000000L);
			Outline(r, c);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v63+30]");
			object obj32 = -52;
			bool flag6 = shown < 0f;
			double num5 = 0.0;
			if (!flag6)
			{
				bool flag7 = !((double)shown > 1.0);
				num5 = shown;
				if (!flag7)
				{
					num5 = 1.0;
				}
			}
			num6 = num5 * (double)obj32;
			object obj33 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X0_v68+E4]");
			bool flag8 = (nint)0 == 0;
			object obj34 = !flag8;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
			double num9 = default;
			if (num6 < 0.0)
			{
				if (num6 == -0.5)
				{
					num7 = -1.0;
					num8 = num9;
					goto IL_0edc;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
				num10 = -0.5;
			}
			else
			{
				if (num6 == 0.5)
				{
					num7 = 1.0;
					num8 = num9;
					goto IL_0edc;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
				num10 = 0.5;
			}
			goto IL_0f83;
		}
		int num11 = this + 292;
		string text3 = ((int*)num11)->ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60E0]");
		object obj35 = 0;
		string text4 = (string)obj35 + text3;
		object obj42;
		if (this.text != null)
		{
			int num12 = this.text.Measure(text4, 6);
			object obj36 = num12 + 34;
			object obj37 = num12 + 35;
			bool flag9 = (nint)obj36 < 0;
			object obj38 = obj36 ^ obj36;
			object obj39 = obj36 & obj38;
			bool flag10 = (nint)obj39 < 0;
			bool flag11 = flag9 == flag10;
			object obj40 = !flag11;
			object obj41 = ~obj40;
			if (obj41 == null)
			{
				obj36 = obj37;
			}
			obj42 = 0 - obj36;
			int num13 = 6;
			num = 0;
			string text5 = text4;
		}
		else
		{
			int num13 = 0;
			string text5 = text3;
			obj42 = 4294967229L;
		}
		object obj43 = obj;
		int num14 = obj42 + cx;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v17+E4]");
		bool flag12 = (nint)0 == 0;
		object obj44 = !flag12;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj45 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v19+E4]");
		bool flag13 = (nint)0 == 0;
		object obj46 = !flag13;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj47 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v17+A0]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v18+2C]");
		int y3 = (int)((nint)0 + (nint)76);
		BoltIcon(num14, y3, 4);
		object obj49 = obj;
		int x = num14 + 34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v20+A0]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v21+2C]");
		int y4 = (int)((nint)0 + (nint)64);
		ScreenFont font3 = this.text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v21+60]");
		Text(font3, x, y4, text4, (Color32[])0, 6, centred: false);
		object obj51 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v22+A0]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6508]");
		object obj53 = 0;
		ScreenFont screenFont = this.text;
		string text6 = (string)obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v23+2C]");
		int num15 = (int)((nint)0 + (nint)124);
		ScreenFont font4 = this.text;
		int y5 = num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v23+60]");
		Text(font4, cx, y5, (string)obj53, (Color32[])0, 2, centred: true);
		bool flag14 = paidOut < total;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v23+60]");
		Color32[] array = (Color32[])0;
		bool flag15 = true;
		int num16 = 2;
		int num17 = cx;
		if (!flag14)
		{
			bool flag16 = ((int*)num11)->m_value < total;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v23+60]");
			array = (Color32[])0;
			flag15 = true;
			num16 = 2;
			num17 = cx;
			if (!flag16)
			{
				object obj54 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v38+E4]");
				bool flag17 = (nint)0 == 0;
				object obj55 = !flag17;
				if (obj55 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj56 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v40+E4]");
				bool flag18 = (nint)0 == 0;
				object obj57 = !flag18;
				if (obj57 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj58 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v42+A0]");
				object obj59 = 0;
				object obj60;
				if (!mine)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6500]");
					obj60 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6518]");
					obj60 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v42+E4]");
				bool flag19 = (nint)0 == 0;
				object obj61 = !flag19;
				if (obj61 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj62 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X8_v40+A0]");
					obj59 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v39+50]");
				array = (Color32[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v39+2C]");
				num15 = (int)((nint)0 + (nint)158);
				ScreenFont font5 = this.text;
				int y6 = num15;
				object s4 = obj60;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v39+50]");
				Text(font5, cx, y6, (string)s4, (Color32[])0, 1, centred: true);
				flag15 = true;
				num16 = 1;
				text6 = (string)obj60;
				num17 = cx;
				screenFont = this.text;
			}
		}
		Queue<(string, int, bool)> queue = waiting;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v26 (System.Collections.Generic.Queue`1<System.ValueTuple`3<System.String, System.Int32, System.Boolean>>)+20]");
		if ((nint)0 >= (nint)1)
		{
			object obj63 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v27+E4]");
			bool flag20 = (nint)0 == 0;
			object obj64 = !flag20;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj65 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X0_v29+E4]");
			bool flag21 = (nint)0 == 0;
			object obj66 = !flag21;
			if (obj66 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj67 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X9_v9+A0]");
			object obj68 = 0;
			int num18 = default;
			string text7 = num18.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6520]");
			object obj69 = 0;
			string s5 = (string)obj35 + text7 + (string)obj69;
			object obj70 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X9_v10+2C]");
			int y7 = (int)((nint)0 + (nint)186);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v34+A0]");
			object obj71 = 0;
			ScreenFont font6 = this.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v35+58]");
			Text(font6, cx, y7, s5, (Color32[])0, 1, centred: true);
		}
		return;
		IL_0edc:
		num10 = num8 + num7;
		object obj72 = num8 & 1;
		bool flag22 = obj72 == null;
		object obj73 = !flag22;
		num6 = ((obj73 != null) ? num10 : num8);
		goto IL_0f83;
		IL_0f83:
		float time = Time.time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X26_v5+BA4]");
		bool flag23 = (nint)0 == 0;
		object obj74 = !flag23;
		if (obj74 == null)
		{
			_ = 1;
		}
		object obj75 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X0_v74+E4]");
		bool flag24 = (nint)0 == 0;
		object obj76 = !flag24;
		if (obj76 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v63+2C]");
		object obj77 = (nint)0 + (nint)114;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v63+28]");
		double num19 = 0.0 + num6;
		object obj78 = obj30 - obj77;
		bool flag25 = (nint)obj78 < 0;
		bool flag26 = obj78 == null;
		object obj79 = obj30 ^ obj77;
		object obj80 = obj30 ^ obj78;
		object obj81 = obj79 & obj80;
		bool flag27 = (nint)obj81 < 0;
		double num20 = num19 + 26.0;
		bool flag28 = flag25 == flag27;
		object obj82 = !flag26;
		object obj83 = flag28 & obj82;
		object obj84 = ~obj83;
		if (obj84 == null)
		{
			obj77 = obj30;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v63+2C]");
		int num21 = (int)((nint)0 + (nint)94);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v63+28]");
		object obj85 = (nint)0 + (nint)120;
		object obj86 = obj77 - 2;
		float num22 = time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v63+2C]");
		float num23 = num22 + 0f;
		while (true)
		{
			object obj87 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v843 @ X0_v77+E4]");
			bool flag29 = (nint)0 == 0;
			object obj88 = !flag29;
			if (obj88 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (num21 >= (nint)obj86)
			{
				break;
			}
			object obj89 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X0_v79+E4]");
			bool flag30 = (nint)0 == 0;
			object obj90 = !flag30;
			object obj91 = obj85;
			if (obj90 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj91 = obj85;
			}
			while (true)
			{
				object obj92 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ X0_v81+E4]");
				bool flag31 = (nint)0 == 0;
				object obj93 = !flag31;
				if (obj93 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num24 = obj91 - 94;
				if (!((double)num24 < num20))
				{
					break;
				}
				float num25 = num23 + (float)obj91;
				object obj94 = obj;
				float num26 = num25 * 715827900f;
				object obj95 = num26 >> 63;
				object obj96 = num26 >> 32;
				obj77 = obj96 + obj95;
				object obj97 = obj77 & 1;
				bool flag32 = obj97 == null;
				object obj98 = !flag32;
				object obj100;
				if (obj98 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X0_v86+E4]");
					bool flag33 = (nint)0 == 0;
					object obj99 = !flag33;
					if (obj99 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj94 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X0_v86+A0]");
					obj100 = (nint)0 + (nint)64;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X0_v86+E4]");
					bool flag34 = (nint)0 == 0;
					object obj101 = !flag34;
					if (obj101 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj94 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X0_v86+A0]");
					obj100 = (nint)0 + (nint)68;
				}
				Color32 color = (Color32)obj100;
				Set(num24, num21, (Color32)obj100);
				obj91++;
				Color32 c = (Color32)num21;
				RectInt r = (RectInt)num24;
			}
			num21++;
			num23++;
		}
	}

	private void Chevron(int x, int y, Color32 c)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0017: Expected Obj, but got I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0044: Expected VT, but got Obj
		//IL_0058: Expected VT, but got I8
		//IL_0065: Expected VT, but got Obj
		//IL_0079: Expected VT, but got I8
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		object obj = y + 19;
		object obj2 = 0;
		do
		{
			object obj3 = x + obj2;
			object obj4 = y + obj2;
			RectInt r = (RectInt)(obj3 | obj4);
			FillRect(r, (Color32)4294967300L);
			RectInt r2 = (RectInt)(obj3 | obj);
			FillRect(r2, (Color32)4294967300L);
			obj2++;
			obj--;
		}
		while ((nint)obj2 != 10);
	}

	private unsafe void Icon(string label, int x, int y)
	{
		//IL_0010: Expected Obj, but got I
		//IL_034d: Expected Obj, but got I4
		//IL_03e8: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0044: Expected VT, but got Obj
		//IL_005d: Expected Obj, but got I
		//IL_02b8: Expected Obj, but got I4
		//IL_02c6: Expected Obj, but got I4
		//IL_02e8: Expected Obj, but got I4
		//IL_03c0: Expected VT, but got Obj
		//IL_03d3: Expected VT, but got I8
		//IL_0087: Invalid comparison between VT and I4
		//IL_00d9: Expected Obj, but got I4
		//IL_0396: Expected Obj, but got I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00fb: Expected Obj, but got I
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_0159: Expected Obj, but got I
		//IL_023f: Invalid comparison between VT and I4
		//IL_0250: Expected Obj, but got I4
		//IL_01e4: Expected VT, but got I4
		//IL_01f2: Expected VT, but got I4
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+70]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64C0]");
			object obj5 = 0;
			Color32 color = (Color32)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+70]");
			if (!((Dictionary<System.__Canon, (System.__Canon, Color32, Color32, Color32)>)0).TryGetValue((System.__Canon)(object)label, out var value))
			{
				object obj6 = obj;
				object obj7 = x + 2;
				object obj8 = y + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj;
				}
				RectInt r = (RectInt)(obj7 | obj8);
				FillRect(r, (Color32)25769803784L);
				return;
			}
			if (value != ((System.__Canon, Color32, Color32, Color32))(object)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ stack_-58_v4 (System.ValueTuple`4<System.__Canon, UnityEngine.Color32, UnityEngine.Color32, UnityEngine.Color32>)+18]");
				if ((nint)0 < (nint)1)
				{
					return;
				}
				int num = (int)(&value);
				(System.__Canon, Color32, Color32, Color32) tuple = value;
				object obj10 = 0;
				Color32 color2 = default;
				while (true)
				{
					int num2 = 0;
					while (true)
					{
						object obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v14 (System.ValueTuple`4<System.__Canon, UnityEngine.Color32, UnityEngine.Color32, UnityEngine.Color32>)+18]");
						bool flag3 = (nint)obj11 < 0;
						object obj12 = !flag3;
						if (obj12 != null)
						{
							break;
						}
						object obj13 = tuple + obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X10_v6+20]");
						string text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X10_v6+20]");
						if ((nint)0 != 0)
						{
							if (num2 >= text._stringLength)
							{
								goto IL_026b;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X10_v6+20]");
							char c = ((string)0).get_Chars(num2);
							int num3 = c & 0xFFFF;
							bool flag4 = num3 == 46;
							num = 0;
							if (!flag4)
							{
								color = num3 switch
								{
									77 => color2, 
									76 => (Color32)0, 
									_ => (Color32)0, 
								};
								if ((object)this == null)
								{
									goto IL_030e;
								}
								int x2 = x + num2;
								num = obj10 + y;
								Set(x2, num, color);
							}
							num2++;
							bool flag5 = value == ((System.__Canon, Color32, Color32, Color32))(object)0;
							object obj14 = !flag5;
							tuple = value;
							if (obj14 != null)
							{
								continue;
							}
						}
						goto IL_030e;
					}
					break;
					IL_026b:
					obj10++;
					object obj15 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v14 (System.ValueTuple`4<System.__Canon, UnityEngine.Color32, UnityEngine.Color32, UnityEngine.Color32>)+18]");
					if ((nint)obj15 >= 0)
					{
						return;
					}
				}
				goto IL_031c;
			}
		}
		goto IL_030e;
		IL_030e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_031c;
		IL_031c:
		throw new IndexOutOfRangeException();
	}

	private unsafe void BoltIcon(int x, int y, int scale)
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
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0186: Expected Obj, but got I8
		//IL_01b3: Expected Obj, but got I
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01f5: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_0280: Expected Obj, but got I4
		//IL_0296: Expected Obj, but got I
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected Obj, but got Unknown
		//IL_030b: Expected Obj, but got I4
		//IL_0321: Expected Obj, but got I
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_0364: Expected Obj, but got I
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		//IL_03a3: Expected Obj, but got I4
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected Obj, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected Obj, but got Unknown
		//IL_0646: Expected Obj, but got I4
		//IL_03bd: Expected Obj, but got I
		//IL_0498: Expected Obj, but got I4
		//IL_04bf: Expected VT, but got I4
		//IL_04cc: Expected VT, but got I8
		//IL_04d4: Expected VT, but got Ref
		//IL_056f: Expected native int or pointer, but got VT
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected Obj, but got Unknown
		//IL_0436: Expected Obj, but got I4
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected VT, but got Unknown
		//IL_0502: Expected VT, but got I4
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected Obj, but got Unknown
		//IL_0461: Expected VT, but got I8
		//IL_0469: Expected VT, but got Ref
		//IL_050f: Expected I4, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64F0]");
			object obj2 = 0;
			object obj4 = default;
			object obj3 = obj4 + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X24_v4-8]");
			object obj5 = 0 & 0xFFFFFFFEL;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64E0]");
				object obj6 = 0;
				object obj7 = obj4 + 40;
				obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X24_v6-10]");
				bool flag = (nint)0 < (nint)2;
				object obj8 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X24_v6-10]");
				object obj9 = -2;
				bool flag2 = obj9 == null;
				object obj10 = ~obj8;
				object obj11 = obj10 | flag2;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64E8]");
					object obj12 = 0;
					object obj13 = obj4 + 48;
					obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X24_v8-18]");
					object obj14 = 0 & 0xFFFFFFFCL;
					if (obj14 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64F8]");
						object obj15 = 0;
						object obj16 = obj4 + 56;
						obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X24_v10-20]");
						bool flag3 = (nint)0 < (nint)4;
						object obj17 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X24_v10-20]");
						object obj18 = -4;
						bool flag4 = obj18 == null;
						object obj19 = ~obj17;
						object obj20 = obj19 | flag4;
						if (obj20 == null)
						{
							object obj21 = obj4 + 64;
							obj21 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X24_v12-28]");
							bool flag5 = (nint)0 < (nint)5;
							object obj22 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X24_v12-28]");
							object obj23 = -5;
							bool flag6 = obj23 == null;
							object obj24 = ~obj22;
							object obj25 = obj24 | flag6;
							if (obj25 == null)
							{
								object obj26 = obj4 + 72;
								obj26 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X24_v14-30]");
								bool flag7 = (nint)0 < (nint)6;
								object obj27 = !flag7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X24_v14-30]");
								object obj28 = -6;
								bool flag8 = obj28 == null;
								object obj29 = ~obj27;
								object obj30 = obj29 | flag8;
								if (obj30 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6270]");
									object obj31 = 0;
									object obj32 = obj4 + 80;
									obj32 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									int num = scale | scale;
									int num2 = scale;
									object obj33 = 0;
									Color32? color2 = default;
									Color32? color3 = default;
									while (true)
									{
										object obj34 = obj33 * scale;
										object obj35 = y + obj34;
										object obj36 = obj4 + obj33;
										object obj37 = obj35 << 32;
										int num3 = x;
										int num4 = 0;
										while (true)
										{
											object obj38 = obj33;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+18]");
											bool flag9 = (nint)obj38 < 0;
											object obj39 = !flag9;
											if (obj39 != null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X20_v8+20]");
											char c = ((string)0).get_Chars(num4);
											int num5 = c & 0xFFFF;
											Color32 value;
											Color32? color;
											if (num5 != 35)
											{
												if (num5 != 76)
												{
													goto IL_059f;
												}
												object obj40 = obj31;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v36+E4]");
												bool flag10 = (nint)0 == 0;
												object obj41 = !flag10;
												if (obj41 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												value = (Color32)4293452247L;
												color = (Color32?)(object)(&color2);
											}
											else
											{
												object obj42 = obj31;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v32+E4]");
												bool flag11 = (nint)0 == 0;
												object obj43 = !flag11;
												if (obj43 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												color2 = (Color32?)(object)0;
												value = (Color32)4289372310L;
												color = (Color32?)(object)(&color2);
											}
											System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)color, new Color32?(value));
											object obj44 = (_003F?)color2 & 0xFF;
											if (obj44 != null)
											{
												Color32 value2 = color3.Value;
												RectInt r = (RectInt)(obj37 | num3);
												FillRect(r, (Color32)num);
												num2 = (int)value2;
											}
											goto IL_059f;
											IL_059f:
											num4++;
											num3 += scale;
											if (num4 != 7)
											{
												continue;
											}
											goto IL_0514;
										}
										break;
										IL_0514:
										obj33++;
										if ((nint)obj33 == 7)
										{
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
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private string Fit(string s, int width, int scale)
	{
		//IL_013d: Expected Obj, but got I4
		bool flag = this.text == null;
		string text = s;
		if (!flag)
		{
			bool flag2 = string.IsNullOrEmpty(s);
			bool flag3 = !flag2;
			text = s;
			if (flag3)
			{
				bool flag4 = s == null;
				text = s;
				if (flag4)
				{
					goto IL_0153;
				}
				while (text._stringLength >= 2)
				{
					if (this.text != null)
					{
						int num = this.text.Measure(text, scale);
						if (num <= width)
						{
							break;
						}
						int length = text._stringLength - 1;
						string text2 = text.Substring(0, length);
						bool flag5 = text2 == null;
						object obj = !flag5;
						text = text2;
						if (obj != null)
						{
							continue;
						}
					}
					goto IL_0153;
				}
			}
		}
		return text;
		IL_0153:
		return (string)(object)new NullReferenceException();
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
				int num = font.DrawCentred(px, 512, 256, x, y, s, ref s2);
			}
			else
			{
				int num2 = font.Draw(px, 512, 256, x, y, s, ref s2);
			}
		}
	}

	private void Set(int x, int y, Color32 c)
	{
		//IL_0059: Expected I4, but got I8
		//IL_0073: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00e0: Expected Obj, but got I4
		if (y > 255 || x > 511)
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
			object obj3 = obj2 + 130560;
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

	public GillaRecycler()
	{
		//IL_0269: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I
		//IL_02aa: Expected Obj, but got I
		//IL_02bb: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I
		//IL_02fb: Expected VT, but got I
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_005d: Expected I4, but got I8
		//IL_007a: Expected F4, but got I
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0133: Expected Obj, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0179: Expected Obj, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01d9: Expected Obj, but got I8
		//IL_01e8: Expected I4, but got I8
		//IL_0205: Expected VT, but got I
		//IL_0215: Expected Obj, but got I
		//IL_0224: Expected I4, but got I8
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6570]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6580]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6568]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v7+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v8+48]");
		front = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v8+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj10 = this + 80;
		object obj11 = default;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj12 = this + 88;
		object obj13 = default;
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj14 = this + 96;
		object obj15 = default;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		lampSlot = -1;
		workSpeed = 380f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B3F0]");
		wakeRange = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj16 = this + 224;
		obj16 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Queue<(System.__Canon, int, bool)> queue = default;
		queue._002Ector();
		object obj17 = this + 232;
		obj17 = queue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<(System.__Canon, int, System.__Canon)> list2 = default;
		list2._002Ector();
		object obj18 = this + 240;
		obj18 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6550]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, int> dictionary = default;
		dictionary._002Ector();
		object obj20 = this + 248;
		obj20 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list3 = default;
		list3._002Ector();
		object obj22 = this + 256;
		unpaid = (List<string>)(object)list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj23 = this + 276;
		dirty = true;
		obj23 = -4647714812233515008L;
		grindClip = -1;
		chimedAt = -9f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E8B0]");
		lampColour = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6588]");
		object obj24 = 0;
		lastBalance = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		(string, int)[] array = default;
		prices = array;
		object obj25 = this + 440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	unsafe static GillaRecycler()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_1dce: Expected Obj, but got I
		//IL_1dd6: Expected Obj, but got I4
		//IL_1dfb: Expected Obj, but got I
		//IL_1e1d: Expected Obj, but got I
		//IL_1e3a: Expected Obj, but got I
		//IL_1e4a: Expected Obj, but got I
		//IL_1e67: Expected Obj, but got I
		//IL_1e81: Expected Obj, but got I
		//IL_1e9b: Expected Obj, but got I
		//IL_1eb5: Expected Obj, but got I
		//IL_1ecf: Expected Obj, but got I
		//IL_1ee9: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I
		//IL_0203: Expected Obj, but got I4
		//IL_0285: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I
		//IL_02b9: Expected Obj, but got I
		//IL_02cf: Expected Obj, but got I
		//IL_0317: Expected Obj, but got I
		//IL_0368: Expected Obj, but got I4
		//IL_0396: Expected Obj, but got I4
		//IL_03b4: Expected Obj, but got I
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_03f6: Expected Obj, but got I8
		//IL_0423: Expected Obj, but got I
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		//IL_046d: Expected Obj, but got I4
		//IL_0483: Expected Obj, but got I
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_04c6: Expected Obj, but got I
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected Obj, but got Unknown
		//IL_0508: Expected Obj, but got I8
		//IL_0535: Expected Obj, but got I
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected Obj, but got Unknown
		//IL_057f: Expected Obj, but got I4
		//IL_0595: Expected Obj, but got I
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected Obj, but got Unknown
		//IL_05d8: Expected Obj, but got I
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected Obj, but got Unknown
		//IL_0622: Expected Obj, but got I4
		//IL_0638: Expected Obj, but got I
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected Obj, but got Unknown
		//IL_067b: Expected Obj, but got I
		//IL_068b: Expected Obj, but got I
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected Obj, but got Unknown
		//IL_06db: Expected VT, but got I8
		//IL_06db: Expected VT, but got I8
		//IL_06db: Expected VT, but got I8
		//IL_06fc: Expected VT, but got I8
		//IL_0709: Expected VT, but got I8
		//IL_0716: Expected VT, but got I8
		//IL_073c: Expected Obj, but got I
		//IL_074c: Expected Obj, but got I
		//IL_0754: Expected VT, but got Obj
		//IL_0765: Expected VT, but got Ref
		//IL_0790: Expected VT, but got I8
		//IL_0798: Expected VT, but got Ref
		//IL_07a1: Expected Obj, but got I4
		//IL_07aa: Expected Obj, but got I4
		//IL_07dc: Expected VT, but got I8
		//IL_07e4: Expected VT, but got Ref
		//IL_07ed: Expected Obj, but got I4
		//IL_07f6: Expected Obj, but got I4
		//IL_0814: Expected Obj, but got I
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected Obj, but got Unknown
		//IL_0856: Expected Obj, but got I8
		//IL_0872: Expected VT, but got I8
		//IL_087a: Expected VT, but got Ref
		//IL_0883: Expected Obj, but got I4
		//IL_08a1: Expected Obj, but got I
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected Obj, but got Unknown
		//IL_08eb: Expected Obj, but got I4
		//IL_0901: Expected Obj, but got I
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Expected Obj, but got Unknown
		//IL_0933: Expected VT, but got I8
		//IL_093b: Expected VT, but got Ref
		//IL_0944: Expected Obj, but got I4
		//IL_0962: Expected Obj, but got I
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Expected Obj, but got Unknown
		//IL_09a4: Expected Obj, but got I8
		//IL_09c0: Expected VT, but got I8
		//IL_09c8: Expected VT, but got Ref
		//IL_09d1: Expected Obj, but got I4
		//IL_09ef: Expected Obj, but got I
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Expected Obj, but got Unknown
		//IL_0a39: Expected Obj, but got I4
		//IL_0a4f: Expected Obj, but got I
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a74: Expected Obj, but got Unknown
		//IL_0a81: Expected VT, but got I8
		//IL_0a89: Expected VT, but got Ref
		//IL_0a92: Expected Obj, but got I4
		//IL_0ab0: Expected Obj, but got I
		//IL_0ac1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Expected Obj, but got Unknown
		//IL_0afa: Expected Obj, but got I4
		//IL_0b10: Expected Obj, but got I
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b35: Expected Obj, but got Unknown
		//IL_0b42: Expected VT, but got I8
		//IL_0b4a: Expected VT, but got Ref
		//IL_0b53: Expected Obj, but got I4
		//IL_0b71: Expected Obj, but got I
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b87: Expected Obj, but got Unknown
		//IL_0bbb: Expected Obj, but got I4
		//IL_0bd1: Expected Obj, but got I
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Expected Obj, but got Unknown
		//IL_0c03: Expected VT, but got I8
		//IL_0c0b: Expected VT, but got Ref
		//IL_0c14: Expected Obj, but got I4
		//IL_0c32: Expected Obj, but got I
		//IL_0c43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c48: Expected Obj, but got Unknown
		//IL_0c74: Expected Obj, but got I8
		//IL_0c90: Expected VT, but got I8
		//IL_0c98: Expected VT, but got Ref
		//IL_0ca1: Expected Obj, but got I4
		//IL_0cbf: Expected Obj, but got I
		//IL_0cd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd5: Expected Obj, but got Unknown
		//IL_0d09: Expected Obj, but got I4
		//IL_0d1f: Expected Obj, but got I
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d44: Expected Obj, but got Unknown
		//IL_0d51: Expected VT, but got I8
		//IL_0d59: Expected VT, but got Ref
		//IL_0d62: Expected Obj, but got I4
		//IL_0d80: Expected Obj, but got I
		//IL_0d90: Expected Obj, but got I
		//IL_0d99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9e: Expected Obj, but got Unknown
		//IL_0de0: Expected VT, but got I8
		//IL_0de0: Expected VT, but got I8
		//IL_0de0: Expected VT, but got I8
		//IL_0ded: Expected VT, but got Obj
		//IL_0dfe: Expected VT, but got Ref
		//IL_0e29: Expected VT, but got I8
		//IL_0e31: Expected VT, but got Ref
		//IL_0e3a: Expected Obj, but got I4
		//IL_0e43: Expected Obj, but got I4
		//IL_0e75: Expected VT, but got I8
		//IL_0e7d: Expected VT, but got Ref
		//IL_0e86: Expected Obj, but got I4
		//IL_0e8f: Expected Obj, but got I4
		//IL_0ead: Expected Obj, but got I
		//IL_0ebe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Expected Obj, but got Unknown
		//IL_0eef: Expected Obj, but got I8
		//IL_0f0b: Expected VT, but got I8
		//IL_0f13: Expected VT, but got Ref
		//IL_0f1c: Expected Obj, but got I4
		//IL_0f3a: Expected Obj, but got I
		//IL_0f4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f50: Expected Obj, but got Unknown
		//IL_0f84: Expected Obj, but got I4
		//IL_0f9a: Expected Obj, but got I
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbf: Expected Obj, but got Unknown
		//IL_0fcc: Expected VT, but got I8
		//IL_0fd4: Expected VT, but got Ref
		//IL_0fdd: Expected Obj, but got I4
		//IL_0ffb: Expected Obj, but got I
		//IL_100c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1011: Expected Obj, but got Unknown
		//IL_103d: Expected Obj, but got I8
		//IL_1059: Expected VT, but got I8
		//IL_1061: Expected VT, but got Ref
		//IL_106a: Expected Obj, but got I4
		//IL_1088: Expected Obj, but got I
		//IL_1099: Unknown result type (might be due to invalid IL or missing references)
		//IL_109e: Expected Obj, but got Unknown
		//IL_10d2: Expected Obj, but got I4
		//IL_10e8: Expected Obj, but got I
		//IL_1108: Unknown result type (might be due to invalid IL or missing references)
		//IL_110d: Expected Obj, but got Unknown
		//IL_111a: Expected VT, but got I8
		//IL_1122: Expected VT, but got Ref
		//IL_112b: Expected Obj, but got I4
		//IL_1149: Expected Obj, but got I
		//IL_115a: Unknown result type (might be due to invalid IL or missing references)
		//IL_115f: Expected Obj, but got Unknown
		//IL_1193: Expected Obj, but got I4
		//IL_11a9: Expected Obj, but got I
		//IL_11c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ce: Expected Obj, but got Unknown
		//IL_11db: Expected VT, but got I8
		//IL_11e3: Expected VT, but got Ref
		//IL_11ec: Expected Obj, but got I4
		//IL_120b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1210: Expected Obj, but got Unknown
		//IL_1244: Expected Obj, but got I4
		//IL_125a: Expected Obj, but got I
		//IL_127a: Unknown result type (might be due to invalid IL or missing references)
		//IL_127f: Expected Obj, but got Unknown
		//IL_128c: Expected VT, but got I8
		//IL_1294: Expected VT, but got Ref
		//IL_129d: Expected Obj, but got I4
		//IL_12bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c1: Expected Obj, but got Unknown
		//IL_12ed: Expected Obj, but got I8
		//IL_1309: Expected VT, but got I8
		//IL_1311: Expected VT, but got Ref
		//IL_131a: Expected Obj, but got I4
		//IL_1339: Unknown result type (might be due to invalid IL or missing references)
		//IL_133e: Expected Obj, but got Unknown
		//IL_1372: Expected Obj, but got I4
		//IL_1388: Expected Obj, but got I
		//IL_13a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ad: Expected Obj, but got Unknown
		//IL_13ba: Expected VT, but got I8
		//IL_13c2: Expected VT, but got Ref
		//IL_13cb: Expected Obj, but got I4
		//IL_13e9: Expected Obj, but got I
		//IL_13f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f7: Expected Obj, but got Unknown
		//IL_1439: Expected VT, but got I8
		//IL_1439: Expected VT, but got I8
		//IL_1439: Expected VT, but got I8
		//IL_1446: Expected VT, but got Obj
		//IL_1457: Expected VT, but got Ref
		//IL_1482: Expected VT, but got I8
		//IL_148a: Expected VT, but got Ref
		//IL_1493: Expected Obj, but got I4
		//IL_149c: Expected Obj, but got I4
		//IL_14ce: Expected VT, but got I8
		//IL_14d6: Expected VT, but got Ref
		//IL_14df: Expected Obj, but got I4
		//IL_14e8: Expected Obj, but got I4
		//IL_1506: Expected Obj, but got I
		//IL_1517: Unknown result type (might be due to invalid IL or missing references)
		//IL_151c: Expected Obj, but got Unknown
		//IL_1548: Expected Obj, but got I8
		//IL_1564: Expected VT, but got I8
		//IL_156c: Expected VT, but got Ref
		//IL_1575: Expected Obj, but got I4
		//IL_1593: Expected Obj, but got I
		//IL_15a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a9: Expected Obj, but got Unknown
		//IL_15dd: Expected Obj, but got I4
		//IL_15f3: Expected Obj, but got I
		//IL_1613: Unknown result type (might be due to invalid IL or missing references)
		//IL_1618: Expected Obj, but got Unknown
		//IL_1625: Expected VT, but got I8
		//IL_162d: Expected VT, but got Ref
		//IL_1636: Expected Obj, but got I4
		//IL_1654: Expected Obj, but got I
		//IL_1665: Unknown result type (might be due to invalid IL or missing references)
		//IL_166a: Expected Obj, but got Unknown
		//IL_1696: Expected Obj, but got I8
		//IL_16b2: Expected VT, but got I8
		//IL_16ba: Expected VT, but got Ref
		//IL_16c3: Expected Obj, but got I4
		//IL_16e1: Expected Obj, but got I
		//IL_16f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f7: Expected Obj, but got Unknown
		//IL_172b: Expected Obj, but got I4
		//IL_1741: Expected Obj, but got I
		//IL_1761: Unknown result type (might be due to invalid IL or missing references)
		//IL_1766: Expected Obj, but got Unknown
		//IL_1773: Expected VT, but got I8
		//IL_177b: Expected VT, but got Ref
		//IL_1784: Expected Obj, but got I4
		//IL_17a2: Expected Obj, but got I
		//IL_17b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b8: Expected Obj, but got Unknown
		//IL_17ec: Expected Obj, but got I4
		//IL_1802: Expected Obj, but got I
		//IL_1822: Unknown result type (might be due to invalid IL or missing references)
		//IL_1827: Expected Obj, but got Unknown
		//IL_1834: Expected VT, but got I8
		//IL_183c: Expected VT, but got Ref
		//IL_1845: Expected Obj, but got I4
		//IL_1863: Expected Obj, but got I
		//IL_1873: Expected Obj, but got I
		//IL_187c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1881: Expected Obj, but got Unknown
		//IL_18c3: Expected VT, but got I8
		//IL_18c3: Expected VT, but got I8
		//IL_18c3: Expected VT, but got I8
		//IL_18d0: Expected VT, but got Obj
		//IL_18e1: Expected VT, but got Ref
		//IL_190c: Expected VT, but got I8
		//IL_1914: Expected VT, but got Ref
		//IL_191d: Expected Obj, but got I4
		//IL_1926: Expected Obj, but got I4
		//IL_1958: Expected VT, but got I8
		//IL_1960: Expected VT, but got Ref
		//IL_1969: Expected Obj, but got I4
		//IL_1972: Expected Obj, but got I4
		//IL_1990: Expected Obj, but got I
		//IL_19a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a6: Expected Obj, but got Unknown
		//IL_19d2: Expected Obj, but got I8
		//IL_19ee: Expected VT, but got I8
		//IL_19f6: Expected VT, but got Ref
		//IL_19ff: Expected Obj, but got I4
		//IL_1a1d: Expected Obj, but got I
		//IL_1a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a33: Expected Obj, but got Unknown
		//IL_1a67: Expected Obj, but got I4
		//IL_1a7d: Expected Obj, but got I
		//IL_1a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa2: Expected Obj, but got Unknown
		//IL_1aaf: Expected VT, but got I8
		//IL_1ab7: Expected VT, but got Ref
		//IL_1ac0: Expected Obj, but got I4
		//IL_1ade: Expected Obj, but got I
		//IL_1aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af4: Expected Obj, but got Unknown
		//IL_1b20: Expected Obj, but got I8
		//IL_1b3c: Expected VT, but got I8
		//IL_1b44: Expected VT, but got Ref
		//IL_1b4d: Expected Obj, but got I4
		//IL_1b6b: Expected Obj, but got I
		//IL_1b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b81: Expected Obj, but got Unknown
		//IL_1bb5: Expected Obj, but got I4
		//IL_1bcb: Expected Obj, but got I
		//IL_1beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf0: Expected Obj, but got Unknown
		//IL_1bfd: Expected VT, but got I8
		//IL_1c05: Expected VT, but got Ref
		//IL_1c0e: Expected Obj, but got I4
		//IL_1c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c32: Expected Obj, but got Unknown
		//IL_1c66: Expected Obj, but got I4
		//IL_1c7c: Expected Obj, but got I
		//IL_1c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca1: Expected Obj, but got Unknown
		//IL_1cae: Expected VT, but got I8
		//IL_1cb6: Expected VT, but got Ref
		//IL_1cbf: Expected Obj, but got I4
		//IL_1cdd: Expected Obj, but got I
		//IL_1ced: Expected Obj, but got I
		//IL_1cf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfb: Expected Obj, but got Unknown
		//IL_1d35: Expected VT, but got I8
		//IL_1d35: Expected VT, but got I8
		//IL_1d35: Expected VT, but got I8
		//IL_1d4b: Expected VT, but got Ref
		//IL_1d69: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6270]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj4 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v3+A0]");
		object obj6 = 0;
		obj6 = num;
		int num2 = Shader.PropertyToID((string)obj3);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107CD20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E360]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107EBB0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107EBB0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+A0]");
		object obj12 = 0;
		_ = 4278453762L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+A0]");
		object obj13 = 0;
		_ = 4278717444L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+A0]");
		object obj14 = 0;
		_ = 4286119740L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+A0]");
		object obj15 = 0;
		_ = 4281822740L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+A0]");
		object obj16 = 0;
		_ = 4279511048L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+A0]");
		object obj17 = 0;
		_ = 4282181375L;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		System.__Canon _Canon = default;
		bool flag = _Canon == null;
		System.__Canon _Canon2 = (System.__Canon)2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v7 (System.__Canon)+18]");
			bool flag2 = (nint)0 == 0;
			_Canon2 = _Canon;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v7 (System.__Canon)+18]");
				bool flag3 = (nint)0 == 1;
				_ = 4290707370L;
				_Canon2 = _Canon;
				if (!flag3)
				{
					_ = 4285459260L;
					object obj18 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v17+A0]");
					object obj19 = (nint)0 + (nint)80;
					obj19 = _Canon;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					System.__Canon _Canon3 = default;
					bool flag4 = _Canon3 == null;
					_Canon2 = (System.__Canon)2;
					if (flag4)
					{
						goto IL_1d8f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v25 (System.__Canon)+18]");
					bool flag5 = (nint)0 == 0;
					_Canon2 = _Canon3;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v25 (System.__Canon)+18]");
						bool flag6 = (nint)0 == 1;
						_ = 4283471400L;
						_Canon2 = _Canon3;
						if (!flag6)
						{
							_ = 4281822740L;
							object obj20 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v19+A0]");
							object obj21 = (nint)0 + (nint)88;
							obj21 = _Canon3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							System.__Canon _Canon4 = default;
							bool flag7 = _Canon4 == null;
							_Canon2 = (System.__Canon)2;
							if (flag7)
							{
								goto IL_1d8f;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v30 (System.__Canon)+18]");
							bool flag8 = (nint)0 == 0;
							_Canon2 = _Canon4;
							if (!flag8)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v30 (System.__Canon)+18]");
								bool flag9 = (nint)0 == 1;
								_ = 4294768368L;
								_Canon2 = _Canon4;
								if (!flag9)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C65B8]");
									object obj22 = 0;
									_ = 4291671712L;
									object obj23 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C65A8]");
									object obj24 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
									object obj25 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X8_v23+A0]");
									object obj26 = (nint)0 + (nint)96;
									obj26 = _Canon4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									List<System.__Canon> list = default;
									list._002Ector();
									object obj27 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v24+A0]");
									object obj28 = (nint)0 + (nint)104;
									obj28 = list;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									Dictionary<System.__Canon, (System.__Canon, Color32, Color32, Color32)> dictionary = default;
									dictionary._002Ector();
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									System.__Canon _Canon5 = default;
									bool flag10 = _Canon5 == null;
									_Canon2 = (System.__Canon)6;
									if (flag10)
									{
										goto IL_1d8f;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v42 (System.__Canon)+18]");
									bool flag11 = (nint)0 == 0;
									_Canon2 = (System.__Canon)6;
									if (!flag11)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C65D0]");
										object obj29 = 0;
										_Canon2 = (System.__Canon)obj29;
										object obj30 = _Canon5 + 32;
										obj30 = obj29;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X21_v10-8]");
										object obj31 = 0 & 0xFFFFFFFEL;
										if (obj31 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6608]");
											object obj32 = 0;
											_Canon2 = (System.__Canon)obj32;
											object obj33 = _Canon5 + 40;
											obj33 = obj32;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X21_v12-10]");
											bool flag12 = (nint)0 < (nint)2;
											object obj34 = !flag12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X21_v12-10]");
											object obj35 = -2;
											bool flag13 = obj35 == null;
											object obj36 = ~obj34;
											object obj37 = obj36 | flag13;
											if (obj37 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C66C0]");
												object obj38 = 0;
												_Canon2 = (System.__Canon)obj38;
												object obj39 = _Canon5 + 48;
												obj39 = obj38;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X21_v14-18]");
												object obj40 = 0 & 0xFFFFFFFCL;
												if (obj40 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6670]");
													object obj41 = 0;
													_Canon2 = (System.__Canon)obj41;
													object obj42 = _Canon5 + 56;
													obj42 = obj41;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X21_v16-20]");
													bool flag14 = (nint)0 < (nint)4;
													object obj43 = !flag14;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X21_v16-20]");
													object obj44 = -4;
													bool flag15 = obj44 == null;
													object obj45 = ~obj43;
													object obj46 = obj45 | flag15;
													if (obj46 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6678]");
														object obj47 = 0;
														_Canon2 = (System.__Canon)obj47;
														object obj48 = _Canon5 + 64;
														obj48 = obj47;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X21_v18-28]");
														bool flag16 = (nint)0 < (nint)5;
														object obj49 = !flag16;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X21_v18-28]");
														object obj50 = -5;
														bool flag17 = obj50 == null;
														object obj51 = ~obj49;
														object obj52 = obj51 | flag17;
														if (obj52 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C66B0]");
															object obj53 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C65C0]");
															object obj54 = 0;
															object obj55 = _Canon5 + 72;
															obj55 = obj53;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															object obj56 = obj54;
															(System.__Canon, Color32, Color32, Color32) tuple = (_Canon5, (Color32)4288082175L, (Color32)4280860400L, (Color32)4279529120L);
															bool flag18 = dictionary == null;
															Color32 color = (Color32)4279529120L;
															Color32 color2 = (Color32)4280860400L;
															Color32 color3 = (Color32)4288082175L;
															_Canon2 = _Canon5;
															if (!flag18)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6448]");
																object key = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6598]");
																object obj57 = 0;
																color2 = (Color32)obj57;
																object obj58 = default;
																dictionary.Add((System.__Canon)key, ((System.__Canon, Color32, Color32, Color32))(&obj58));
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																System.__Canon _Canon6 = default;
																bool flag19 = _Canon6 == null;
																color = (Color32)4279529120L;
																color3 = (Color32)(&obj58);
																obj10 = 0;
																_Canon2 = (System.__Canon)9;
																if (!flag19)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v59 (System.__Canon)+18]");
																	bool flag20 = (nint)0 == 0;
																	color = (Color32)4279529120L;
																	color3 = (Color32)(&obj58);
																	obj10 = 0;
																	_Canon2 = (System.__Canon)9;
																	if (!flag20)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6660]");
																		object obj59 = 0;
																		_Canon2 = (System.__Canon)obj59;
																		object obj60 = _Canon6 + 32;
																		obj60 = obj59;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X21_v20-8]");
																		object obj61 = 0 & 0xFFFFFFFEL;
																		bool flag21 = obj61 == null;
																		color = (Color32)4279529120L;
																		color3 = (Color32)(&obj58);
																		obj10 = 0;
																		if (!flag21)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C65D8]");
																			object obj62 = 0;
																			_Canon2 = (System.__Canon)obj62;
																			object obj63 = _Canon6 + 40;
																			obj63 = obj62;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X21_v22-10]");
																			bool flag22 = (nint)0 < (nint)2;
																			object obj64 = !flag22;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X21_v22-10]");
																			object obj65 = -2;
																			bool flag23 = obj65 == null;
																			object obj66 = ~obj64;
																			object obj67 = obj66 | flag23;
																			color = (Color32)4279529120L;
																			color3 = (Color32)(&obj58);
																			obj10 = 0;
																			if (obj67 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6628]");
																				object obj68 = 0;
																				_Canon2 = (System.__Canon)obj68;
																				object obj69 = _Canon6 + 48;
																				obj69 = obj68;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X21_v24-18]");
																				object obj70 = 0 & 0xFFFFFFFCL;
																				bool flag24 = obj70 == null;
																				color = (Color32)4279529120L;
																				color3 = (Color32)(&obj58);
																				obj10 = 0;
																				if (!flag24)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6650]");
																					object obj71 = 0;
																					_Canon2 = (System.__Canon)obj71;
																					object obj72 = _Canon6 + 56;
																					obj72 = obj71;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X21_v26-20]");
																					bool flag25 = (nint)0 < (nint)4;
																					object obj73 = !flag25;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X21_v26-20]");
																					object obj74 = -4;
																					bool flag26 = obj74 == null;
																					object obj75 = ~obj73;
																					object obj76 = obj75 | flag26;
																					color = (Color32)4279529120L;
																					color3 = (Color32)(&obj58);
																					obj10 = 0;
																					if (obj76 == null)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6688]");
																						object obj77 = 0;
																						_Canon2 = (System.__Canon)obj77;
																						object obj78 = _Canon6 + 64;
																						obj78 = obj77;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X21_v28-28]");
																						bool flag27 = (nint)0 < (nint)5;
																						object obj79 = !flag27;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X21_v28-28]");
																						object obj80 = -5;
																						bool flag28 = obj80 == null;
																						object obj81 = ~obj79;
																						object obj82 = obj81 | flag28;
																						color = (Color32)4279529120L;
																						color3 = (Color32)(&obj58);
																						obj10 = 0;
																						if (obj82 == null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6690]");
																							object obj83 = 0;
																							_Canon2 = (System.__Canon)obj83;
																							object obj84 = _Canon6 + 72;
																							obj84 = obj83;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X21_v30-30]");
																							bool flag29 = (nint)0 < (nint)6;
																							object obj85 = !flag29;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X21_v30-30]");
																							object obj86 = -6;
																							bool flag30 = obj86 == null;
																							object obj87 = ~obj85;
																							object obj88 = obj87 | flag30;
																							color = (Color32)4279529120L;
																							color3 = (Color32)(&obj58);
																							obj10 = 0;
																							if (obj88 == null)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6640]");
																								object obj89 = 0;
																								_Canon2 = (System.__Canon)obj89;
																								object obj90 = _Canon6 + 80;
																								obj90 = obj89;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X21_v32-38]");
																								object obj91 = 0 & 0xFFFFFFF8L;
																								bool flag31 = obj91 == null;
																								color = (Color32)4279529120L;
																								color3 = (Color32)(&obj58);
																								obj10 = 0;
																								if (!flag31)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6630]");
																									object obj92 = 0;
																									_Canon2 = (System.__Canon)obj92;
																									object obj93 = _Canon6 + 88;
																									obj93 = obj92;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X21_v34-40]");
																									bool flag32 = (nint)0 < (nint)8;
																									object obj94 = !flag32;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X21_v34-40]");
																									object obj95 = -8;
																									bool flag33 = obj95 == null;
																									object obj96 = ~obj94;
																									object obj97 = obj96 | flag33;
																									color = (Color32)4279529120L;
																									color3 = (Color32)(&obj58);
																									obj10 = 0;
																									if (obj97 == null)
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6680]");
																										object obj98 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6450]");
																										object key2 = 0;
																										object obj99 = _Canon6 + 96;
																										obj99 = obj98;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										obj56 = obj54;
																										(System.__Canon, Color32, Color32, Color32) tuple2 = (_Canon6, (Color32)4294965990L, (Color32)4294958220L, (Color32)4291991100L);
																										color2 = (Color32)obj57;
																										dictionary.Add((System.__Canon)key2, ((System.__Canon, Color32, Color32, Color32))(&obj58));
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																										System.__Canon _Canon7 = default;
																										bool flag34 = _Canon7 == null;
																										color = (Color32)4291991100L;
																										color3 = (Color32)(&obj58);
																										obj10 = 0;
																										_Canon2 = (System.__Canon)9;
																										if (flag34)
																										{
																											goto IL_1d8f;
																										}
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v82 (System.__Canon)+18]");
																										bool flag35 = (nint)0 == 0;
																										color = (Color32)4291991100L;
																										color3 = (Color32)(&obj58);
																										obj10 = 0;
																										_Canon2 = (System.__Canon)9;
																										if (!flag35)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6618]");
																											object obj100 = 0;
																											_Canon2 = (System.__Canon)obj100;
																											object obj101 = _Canon7 + 32;
																											obj101 = obj100;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X21_v38-8]");
																											object obj102 = 0 & 0xFFFFFFFEL;
																											bool flag36 = obj102 == null;
																											color = (Color32)4291991100L;
																											color3 = (Color32)(&obj58);
																											obj10 = 0;
																											if (!flag36)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6698]");
																												object obj103 = 0;
																												_Canon2 = (System.__Canon)obj103;
																												object obj104 = _Canon7 + 40;
																												obj104 = obj103;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X21_v40-10]");
																												bool flag37 = (nint)0 < (nint)2;
																												object obj105 = !flag37;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X21_v40-10]");
																												object obj106 = -2;
																												bool flag38 = obj106 == null;
																												object obj107 = ~obj105;
																												object obj108 = obj107 | flag38;
																												color = (Color32)4291991100L;
																												color3 = (Color32)(&obj58);
																												obj10 = 0;
																												if (obj108 == null)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C66D0]");
																													object obj109 = 0;
																													_Canon2 = (System.__Canon)obj109;
																													object obj110 = _Canon7 + 48;
																													obj110 = obj109;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X21_v42-18]");
																													object obj111 = 0 & 0xFFFFFFFCL;
																													bool flag39 = obj111 == null;
																													color = (Color32)4291991100L;
																													color3 = (Color32)(&obj58);
																													obj10 = 0;
																													if (!flag39)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6620]");
																														object obj112 = 0;
																														_Canon2 = (System.__Canon)obj112;
																														object obj113 = _Canon7 + 56;
																														obj113 = obj112;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X21_v44-20]");
																														bool flag40 = (nint)0 < (nint)4;
																														object obj114 = !flag40;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X21_v44-20]");
																														object obj115 = -4;
																														bool flag41 = obj115 == null;
																														object obj116 = ~obj114;
																														object obj117 = obj116 | flag41;
																														color = (Color32)4291991100L;
																														color3 = (Color32)(&obj58);
																														obj10 = 0;
																														if (obj117 == null)
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C65C8]");
																															object obj118 = 0;
																															_Canon2 = (System.__Canon)obj118;
																															object obj119 = _Canon7 + 64;
																															obj119 = obj118;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X21_v46-28]");
																															bool flag42 = (nint)0 < (nint)5;
																															object obj120 = !flag42;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X21_v46-28]");
																															object obj121 = -5;
																															bool flag43 = obj121 == null;
																															object obj122 = ~obj120;
																															object obj123 = obj122 | flag43;
																															color = (Color32)4291991100L;
																															color3 = (Color32)(&obj58);
																															obj10 = 0;
																															if (obj123 == null)
																															{
																																_Canon2 = (System.__Canon)obj112;
																																object obj124 = _Canon7 + 72;
																																obj124 = obj112;
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X21_v48-30]");
																																bool flag44 = (nint)0 < (nint)6;
																																object obj125 = !flag44;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X21_v48-30]");
																																object obj126 = -6;
																																bool flag45 = obj126 == null;
																																object obj127 = ~obj125;
																																object obj128 = obj127 | flag45;
																																color = (Color32)4291991100L;
																																color3 = (Color32)(&obj58);
																																obj10 = 0;
																																if (obj128 == null)
																																{
																																	_Canon2 = (System.__Canon)obj109;
																																	object obj129 = _Canon7 + 80;
																																	obj129 = obj109;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X21_v50-38]");
																																	object obj130 = 0 & 0xFFFFFFF8L;
																																	bool flag46 = obj130 == null;
																																	color = (Color32)4291991100L;
																																	color3 = (Color32)(&obj58);
																																	obj10 = 0;
																																	if (!flag46)
																																	{
																																		_Canon2 = (System.__Canon)obj103;
																																		object obj131 = _Canon7 + 88;
																																		obj131 = obj103;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X21_v52-40]");
																																		bool flag47 = (nint)0 < (nint)8;
																																		object obj132 = !flag47;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X21_v52-40]");
																																		object obj133 = -8;
																																		bool flag48 = obj133 == null;
																																		object obj134 = ~obj132;
																																		object obj135 = obj134 | flag48;
																																		color = (Color32)4291991100L;
																																		color3 = (Color32)(&obj58);
																																		obj10 = 0;
																																		if (obj135 == null)
																																		{
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C66C8]");
																																			object key3 = 0;
																																			object obj136 = _Canon7 + 96;
																																			obj136 = obj100;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																			obj56 = obj54;
																																			(System.__Canon, Color32, Color32, Color32) tuple3 = (_Canon7, (Color32)4283469030L, (Color32)4281163710L, (Color32)4279842680L);
																																			color2 = (Color32)obj57;
																																			dictionary.Add((System.__Canon)key3, ((System.__Canon, Color32, Color32, Color32))(&obj58));
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																																			System.__Canon _Canon8 = default;
																																			bool flag49 = _Canon8 == null;
																																			color = (Color32)4279842680L;
																																			color3 = (Color32)(&obj58);
																																			obj10 = 0;
																																			_Canon2 = (System.__Canon)6;
																																			if (flag49)
																																			{
																																				goto IL_1d8f;
																																			}
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v105 (System.__Canon)+18]");
																																			bool flag50 = (nint)0 == 0;
																																			color = (Color32)4279842680L;
																																			color3 = (Color32)(&obj58);
																																			obj10 = 0;
																																			_Canon2 = (System.__Canon)6;
																																			if (!flag50)
																																			{
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C66A0]");
																																				object obj137 = 0;
																																				_Canon2 = (System.__Canon)obj137;
																																				object obj138 = _Canon8 + 32;
																																				obj138 = obj137;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X21_v56-8]");
																																				object obj139 = 0 & 0xFFFFFFFEL;
																																				bool flag51 = obj139 == null;
																																				color = (Color32)4279842680L;
																																				color3 = (Color32)(&obj58);
																																				obj10 = 0;
																																				if (!flag51)
																																				{
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C65E8]");
																																					object obj140 = 0;
																																					_Canon2 = (System.__Canon)obj140;
																																					object obj141 = _Canon8 + 40;
																																					obj141 = obj140;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X21_v58-10]");
																																					bool flag52 = (nint)0 < (nint)2;
																																					object obj142 = !flag52;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X21_v58-10]");
																																					object obj143 = -2;
																																					bool flag53 = obj143 == null;
																																					object obj144 = ~obj142;
																																					object obj145 = obj144 | flag53;
																																					color = (Color32)4279842680L;
																																					color3 = (Color32)(&obj58);
																																					obj10 = 0;
																																					if (obj145 == null)
																																					{
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6638]");
																																						object obj146 = 0;
																																						_Canon2 = (System.__Canon)obj146;
																																						object obj147 = _Canon8 + 48;
																																						obj147 = obj146;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X21_v60-18]");
																																						object obj148 = 0 & 0xFFFFFFFCL;
																																						bool flag54 = obj148 == null;
																																						color = (Color32)4279842680L;
																																						color3 = (Color32)(&obj58);
																																						obj10 = 0;
																																						if (!flag54)
																																						{
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6610]");
																																							object obj149 = 0;
																																							_Canon2 = (System.__Canon)obj149;
																																							object obj150 = _Canon8 + 56;
																																							obj150 = obj149;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X21_v62-20]");
																																							bool flag55 = (nint)0 < (nint)4;
																																							object obj151 = !flag55;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X21_v62-20]");
																																							object obj152 = -4;
																																							bool flag56 = obj152 == null;
																																							object obj153 = ~obj151;
																																							object obj154 = obj153 | flag56;
																																							color = (Color32)4279842680L;
																																							color3 = (Color32)(&obj58);
																																							obj10 = 0;
																																							if (obj154 == null)
																																							{
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C65F8]");
																																								object obj155 = 0;
																																								_Canon2 = (System.__Canon)obj155;
																																								object obj156 = _Canon8 + 64;
																																								obj156 = obj155;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X21_v64-28]");
																																								bool flag57 = (nint)0 < (nint)5;
																																								object obj157 = !flag57;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X21_v64-28]");
																																								object obj158 = -5;
																																								bool flag58 = obj158 == null;
																																								object obj159 = ~obj157;
																																								object obj160 = obj159 | flag58;
																																								color = (Color32)4279842680L;
																																								color3 = (Color32)(&obj58);
																																								obj10 = 0;
																																								if (obj160 == null)
																																								{
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6600]");
																																									object obj161 = 0;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6668]");
																																									object key4 = 0;
																																									object obj162 = _Canon8 + 72;
																																									obj162 = obj161;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																									obj56 = obj54;
																																									(System.__Canon, Color32, Color32, Color32) tuple4 = (_Canon8, (Color32)4293321180L, (Color32)4289701280L, (Color32)4285424735L);
																																									color2 = (Color32)obj57;
																																									dictionary.Add((System.__Canon)key4, ((System.__Canon, Color32, Color32, Color32))(&obj58));
																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																																									System.__Canon _Canon9 = default;
																																									bool flag59 = _Canon9 == null;
																																									color = (Color32)4285424735L;
																																									color3 = (Color32)(&obj58);
																																									obj10 = 0;
																																									_Canon2 = (System.__Canon)6;
																																									if (flag59)
																																									{
																																										goto IL_1d8f;
																																									}
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v122 (System.__Canon)+18]");
																																									bool flag60 = (nint)0 == 0;
																																									color = (Color32)4285424735L;
																																									color3 = (Color32)(&obj58);
																																									obj10 = 0;
																																									_Canon2 = (System.__Canon)6;
																																									if (!flag60)
																																									{
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C65E0]");
																																										object obj163 = 0;
																																										_Canon2 = (System.__Canon)obj163;
																																										object obj164 = _Canon9 + 32;
																																										obj164 = obj163;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X21_v68-8]");
																																										object obj165 = 0 & 0xFFFFFFFEL;
																																										bool flag61 = obj165 == null;
																																										color = (Color32)4285424735L;
																																										color3 = (Color32)(&obj58);
																																										obj10 = 0;
																																										if (!flag61)
																																										{
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C65F0]");
																																											object obj166 = 0;
																																											_Canon2 = (System.__Canon)obj166;
																																											object obj167 = _Canon9 + 40;
																																											obj167 = obj166;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X21_v70-10]");
																																											bool flag62 = (nint)0 < (nint)2;
																																											object obj168 = !flag62;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X21_v70-10]");
																																											object obj169 = -2;
																																											bool flag63 = obj169 == null;
																																											object obj170 = ~obj168;
																																											object obj171 = obj170 | flag63;
																																											color = (Color32)4285424735L;
																																											color3 = (Color32)(&obj58);
																																											obj10 = 0;
																																											if (obj171 == null)
																																											{
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6658]");
																																												object obj172 = 0;
																																												_Canon2 = (System.__Canon)obj172;
																																												object obj173 = _Canon9 + 48;
																																												obj173 = obj172;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X21_v72-18]");
																																												object obj174 = 0 & 0xFFFFFFFCL;
																																												bool flag64 = obj174 == null;
																																												color = (Color32)4285424735L;
																																												color3 = (Color32)(&obj58);
																																												obj10 = 0;
																																												if (!flag64)
																																												{
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6648]");
																																													object obj175 = 0;
																																													_Canon2 = (System.__Canon)obj175;
																																													object obj176 = _Canon9 + 56;
																																													obj176 = obj175;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X21_v74-20]");
																																													bool flag65 = (nint)0 < (nint)4;
																																													object obj177 = !flag65;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X21_v74-20]");
																																													object obj178 = -4;
																																													bool flag66 = obj178 == null;
																																													object obj179 = ~obj177;
																																													object obj180 = obj179 | flag66;
																																													color = (Color32)4285424735L;
																																													color3 = (Color32)(&obj58);
																																													obj10 = 0;
																																													if (obj180 == null)
																																													{
																																														_Canon2 = (System.__Canon)obj172;
																																														object obj181 = _Canon9 + 64;
																																														obj181 = obj172;
																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X21_v76-28]");
																																														bool flag67 = (nint)0 < (nint)5;
																																														object obj182 = !flag67;
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X21_v76-28]");
																																														object obj183 = -5;
																																														bool flag68 = obj183 == null;
																																														object obj184 = ~obj182;
																																														object obj185 = obj184 | flag68;
																																														color = (Color32)4285424735L;
																																														color3 = (Color32)(&obj58);
																																														obj10 = 0;
																																														if (obj185 == null)
																																														{
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C66B8]");
																																															object obj186 = 0;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C66A8]");
																																															object key5 = 0;
																																															object obj187 = _Canon9 + 72;
																																															obj187 = obj186;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																															(System.__Canon, Color32, Color32, Color32) tuple5 = (_Canon9, (Color32)4290692040L, (Color32)4286416790L, (Color32)4282142830L);
																																															dictionary.Add((System.__Canon)key5, ((System.__Canon, Color32, Color32, Color32))(&obj58));
																																															object obj188 = obj2;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v119+A0]");
																																															object obj189 = (nint)0 + (nint)112;
																																															obj189 = dictionary;
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
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																	goto IL_1d81;
																}
															}
															goto IL_1d8f;
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
			goto IL_1d81;
		}
		goto IL_1d8f;
		IL_1d81:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_1d8f;
		IL_1d8f:
		throw new NullReferenceException();
	}
}
