using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

public class Dismemberment : MonoBehaviour
{
	private sealed class _003CWorn_003Ed__58 : _0021_00210, _00210, _0021_00210, _00210, _0021_00210
	{
		private int _003C_003E1__state;

		private GameObject _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public CosmeticWearer _003C_003E4__this;

		private List<GameObject>[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private Enumerator<, > _003C_003E7__wrap3;

		private GameObject System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EGameObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CWorn_003Ed__58(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			_003C_003El__initialThreadId = currentManagedThreadId;
		}

		private void System_002EIDisposable_002EDispose()
		{
			//IL_002f: Expected Obj, but got I4
			//IL_0049: Expected Obj, but got I4
			if (_003C_003E1__state != 1)
			{
				object obj = _003C_003E1__state + 3;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 != null)
				{
					return;
				}
			}
			_003C_003Em__Finally1();
		}

		private unsafe bool MoveNext()
		{
			//IL_03d1: Expected Obj, but got I
			//IL_03e1: Expected Obj, but got I
			//IL_00d2: Expected I4, but got I8
			//IL_0440: Expected I, but got Obj
			//IL_0449: Unknown result type (might be due to invalid IL or missing references)
			//IL_044a: Unknown result type (might be due to invalid IL or missing references)
			//IL_044e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0457: Expected Ref, but got Unknown
			//IL_0021: Expected Obj, but got I4
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_040e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0413: Expected Obj, but got Unknown
			//IL_041b: Expected I4, but got Obj
			//IL_01aa: Expected Obj, but got I
			//IL_01cc: Expected Obj, but got I4
			//IL_0051: Expected I4, but got I8
			//IL_00f2: Expected I4, but got I8
			//IL_02c1: Expected Obj, but got I4
			//IL_007d: Expected I, but got Obj
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected Obj, but got Unknown
			//IL_033d: Expected Obj, but got I4
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Expected Obj, but got Unknown
			//IL_02ee: Expected Obj, but got I4
			//IL_02fd: Expected I, but got Obj
			//IL_0306: Expected Obj, but got I4
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Expected I4, but got Unknown
			//IL_04b5: Expected Obj, but got I4
			//IL_04bd: Expected Obj, but got I4
			//IL_03b6: Expected I4, but got Obj
			//IL_0148: Expected Obj, but got I
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Expected Obj, but got Unknown
			//IL_018d: Expected I4, but got I8
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4928]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			bool result;
			_003CWorn_003Ed__58 obj5 = default;
			_003CWorn_003Ed__58 obj6;
			int num2;
			NullReferenceException ex;
			nint num = default;
			_003CWorn_003Ed__58 obj4;
			CosmeticWearer cosmeticWearer;
			int num3;
			if (_003C_003E1__state != 1)
			{
				bool flag = _003C_003E1__state == 0;
				object obj3 = !flag;
				result = false;
				if (obj3 != null)
				{
					goto IL_0400;
				}
				cosmeticWearer = _003C_003E4__this;
				_003C_003E1__state = -1;
				if ((object)_003C_003E4__this != null)
				{
					num = (nint)cosmeticWearer.worn;
					obj4 = (_003CWorn_003Ed__58)(this + 48);
					obj4 = (_003CWorn_003Ed__58)(object)cosmeticWearer.worn;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj5._003C_003E7__wrap2 = 0;
					obj6 = obj5;
					num2 = 0;
					goto IL_0405;
				}
				ex = new NullReferenceException();
				num3 = -1;
				goto IL_036d;
			}
			_003C_003E1__state = -3;
			obj4 = this;
			goto IL_0438;
			IL_036d:
			object obj7;
			if (num == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				object obj8 = default;
				obj7 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				num2 = (int)cosmeticWearer;
				goto IL_049b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D20C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			bool result2 = default;
			return result2;
			IL_049b:
			bool flag2 = obj7 == null;
			object obj9 = !flag2;
			cosmeticWearer = (CosmeticWearer)num2;
			if (obj9 == null)
			{
				result = false;
				goto IL_0400;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D480");
			OutOfMemoryException ex2 = new OutOfMemoryException();
			ex = (NullReferenceException)(object)ex2;
			goto IL_036d;
			IL_0438:
			while (true)
			{
				num = (nint)obj;
				Enumerator<, > val = (Enumerator<, >)(obj5 + 64);
				if (!((Enumerator<, >*)val)->MoveNext())
				{
					break;
				}
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ stack_-28_v2 (Dismemberment+<Worn>d__58)+50]");
				obj4 = (_003CWorn_003Ed__58)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj11 = !flag3;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!((UnityEngine.Object)(object)obj4 != null))
				{
					continue;
				}
				goto IL_0214;
			}
			obj5._003C_003Em__Finally1();
			_ = 0;
			_ = 0;
			obj5._003C_003E7__wrap3 = (Enumerator<, >)0;
			num2 = ++obj5._003C_003E7__wrap2;
			obj6 = obj5;
			goto IL_0405;
			IL_0335:
			cosmeticWearer = (CosmeticWearer)num2;
			throw new NullReferenceException();
			IL_0214:
			object obj12 = obj5 + 24;
			obj12 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj5._003C_003E1__state = 1;
			result = true;
			goto IL_0400;
			IL_0405:
			object obj13 = obj6 + 48;
			num3 = (int)obj13;
			if (obj13 != null)
			{
				int num4 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X9_v11 (System.Int32)+18]");
				bool flag4 = (nint)num4 < (nint)0;
				object obj14 = !flag4;
				int num5 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X9_v11 (System.Int32)+18]");
				if ((nint)num5 >= (nint)0)
				{
					obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num = unchecked((nint)null);
					obj7 = 0;
					goto IL_049b;
				}
				if (obj14 == null)
				{
					num2 = obj13 + num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v13 (System.Int32)+20]");
					if ((nint)0 == 0)
					{
						goto IL_0335;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v13 (System.Int32)+20]");
					Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
					Enumerator<, > val2 = default;
					obj5._003C_003E7__wrap3 = val2;
					object obj15 = obj5 + 64;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj5._003C_003E1__state = -3;
					goto IL_0438;
				}
			}
			else
			{
				NullReferenceException ex3 = new NullReferenceException();
			}
			IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
			goto IL_0335;
			IL_0400:
			return result;
		}

		private unsafe void _003C_003Em__Finally1()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected I4, but got I8
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Ref, but got Unknown
			Enumerator<, > val = (Enumerator<, >)(this + 64);
			_003C_003E1__state = -1;
			((Enumerator<, >*)val)->Dispose();
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

		private IEnumerator<GameObject> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator()
		{
			//IL_00c4: Expected Obj, but got I4
			//IL_00de: Expected Obj, but got I4
			//IL_0054: Expected Obj, but got I
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected Obj, but got Unknown
			object obj = _003C_003E1__state + 2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				if (_003C_003El__initialThreadId == currentManagedThreadId)
				{
					_003C_003E1__state = 0;
					return (IEnumerator<GameObject>)(object)this;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49F0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj4 = default;
			obj4._002Ector();
			_ = 0;
			int currentManagedThreadId2 = Environment.CurrentManagedThreadId;
			object obj5 = obj4 + 40;
			obj5 = _003C_003E4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return (IEnumerator<GameObject>)obj4;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return (IEnumerator)System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator();
		}
	}

	[Serializable]
	public class Part
	{
		public ApePart id;

		public SkinnedMeshRenderer renderer;

		public Transform joint;

		public Transform jointOut;

		public GameObject stump;

		public bool torn;

		public bool sawn;

		public Vector4 sawPlane;
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public SkinnedMeshRenderer skin;

		internal bool _003CSetCaps_003Eb__0(Part p)
		{
			//IL_0087: Expected I4, but got Obj
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			if (p != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return p.renderer == skin;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public Part[] parts;

	public bool spawnPieces;

	public Material bloodMaterial;

	public Material fleshMaterial;

	public float pieceLifetime;

	public AudioClip[] tearSounds;

	public float tearVolume;

	public AudioClip[] dropSounds;

	public float bleedSeconds;

	public int bleedPulses;

	public int gushDroplets;

	public int pieceOwner;

	[NonSerialized]
	private readonly int[] sawnAgain;

	private readonly List<GameObject> pieces;

	private static readonly ProfilerMarker TearMark;

	private static readonly ProfilerMarker TearPieceMark;

	private static readonly ProfilerMarker TearCapsMark;

	private static readonly ProfilerMarker TearSoundMark;

	private static readonly ProfilerMarker TearBloodMark;

	private static readonly ProfilerMarker TearStainsMark;

	private static readonly ProfilerMarker TearStrandsMark;

	private List<SkinnedMeshRenderer> capped;

	private Material capFlesh;

	private static Material anyFlesh;

	private Action<ApePart, GameObject> m_PartTorn;

	private Action m_PartsReset;

	public event Action<ApePart, GameObject> PartTorn
	{
		add
		{
			//IL_006a: Expected Obj, but got I
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected Obj, but got Unknown
			//IL_004d: Expected Obj, but got I4
			//IL_0029: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4878]");
			object obj = 0;
			object obj2 = this + 144;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4878]");
			object obj = 0;
			object obj2 = this + 144;
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

	public event Action PartsReset
	{
		add
		{
			//IL_006d: Expected Obj, but got I
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj = 0;
			object obj2 = this + 152;
			Delegate obj3 = (Delegate)obj2;
			Delegate obj5 = default;
			while (true)
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 != null && obj4 != obj)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag = (object)obj5 != obj3;
				obj3 = obj5;
				if (!flag)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_006d: Expected Obj, but got I
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj = 0;
			object obj2 = this + 152;
			Delegate obj3 = (Delegate)obj2;
			Delegate obj5 = default;
			while (true)
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 != null && obj4 != obj)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag = (object)obj5 != obj3;
				obj3 = obj5;
				if (!flag)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
	}

	private void Awake()
	{
		SetCaps();
	}

	public unsafe void SetCaps()
	{
		//IL_139c: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a1: Expected Obj, but got Unknown
		//IL_13b1: Expected Obj, but got I
		//IL_13cb: Expected Obj, but got I4
		//IL_1228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_005a: Expected I4, but got Obj
		//IL_09d1: Expected Obj, but got I4
		//IL_0924: Expected Obj, but got I4
		//IL_16da: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e7: Expected Obj, but got I
		//IL_09f7: Expected Obj, but got I
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected Obj, but got Unknown
		//IL_0948: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I4
		//IL_0128: Expected I4, but got Obj
		//IL_11b1: Expected Obj, but got I4
		//IL_11b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c2: Expected Obj, but got I4
		//IL_11c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected Obj, but got I4
		//IL_1486: Expected Obj, but got I4
		//IL_1494: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d5: Expected Obj, but got I8
		//IL_1662: Expected Obj, but got I
		//IL_166a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1673: Expected Ref, but got Unknown
		//IL_168d: Expected Obj, but got I4
		//IL_0a41: Expected Obj, but got I4
		//IL_0a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a52: Expected Obj, but got I4
		//IL_0a52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a67: Expected I, but got Obj
		//IL_09b6: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got I
		//IL_019f: Expected Obj, but got I8
		//IL_11fa: Expected Obj, but got I4
		//IL_11fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1202: Expected Obj, but got Unknown
		//IL_1504: Unknown result type (might be due to invalid IL or missing references)
		//IL_1509: Expected Obj, but got Unknown
		//IL_153e: Expected Obj, but got I4
		//IL_09a8: Expected Obj, but got I
		//IL_12d0: Expected Obj, but got I4
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Expected Obj, but got Unknown
		//IL_0abf: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I
		//IL_0214: Expected Obj, but got I4
		//IL_0b04: Expected Obj, but got I4
		//IL_0259: Expected Obj, but got I4
		//IL_026f: Expected I, but got Obj
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected Obj, but got Unknown
		//IL_0868: Expected Obj, but got I8
		//IL_133a: Expected Obj, but got I4
		//IL_0b33: Expected Obj, but got I4
		//IL_0b33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b44: Expected Obj, but got I4
		//IL_0b44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b62: Expected I, but got Obj
		//IL_02c6: Expected Obj, but got I8
		//IL_02dc: Expected I, but got Obj
		//IL_0ba7: Expected Obj, but got I4
		//IL_02f4: Expected Obj, but got I4
		//IL_030a: Expected I, but got Obj
		//IL_0bec: Expected Obj, but got I4
		//IL_1403: Expected Obj, but got I4
		//IL_0498: Expected Obj, but got I4
		//IL_04ae: Expected I, but got Obj
		//IL_0359: Expected Obj, but got I8
		//IL_036f: Expected I, but got Obj
		//IL_0c13: Expected Obj, but got I
		//IL_0c2d: Expected Obj, but got I
		//IL_0c3e: Expected I, but got Obj
		//IL_0c53: Expected Obj, but got I
		//IL_0c5b: Expected I4, but got Obj
		//IL_0c86: Expected Obj, but got I4
		//IL_0c8f: Expected Obj, but got I4
		//IL_0c8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Expected Obj, but got I4
		//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb8: Expected I, but got Obj
		//IL_04f0: Expected Obj, but got I8
		//IL_0506: Expected I, but got Obj
		//IL_03a7: Expected I, but got Obj
		//IL_0ceb: Expected Obj, but got I4
		//IL_0cf4: Expected Obj, but got I4
		//IL_0cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d05: Expected Obj, but got I4
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1a: Expected I, but got Obj
		//IL_0555: Expected Obj, but got I8
		//IL_056b: Expected I, but got Obj
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got I8
		//IL_0418: Expected I, but got Obj
		//IL_0d4d: Expected Obj, but got I4
		//IL_0d56: Expected Obj, but got I4
		//IL_0d56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d67: Expected Obj, but got I4
		//IL_0d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Expected I, but got Obj
		//IL_05b2: Expected I, but got Obj
		//IL_043a: Expected Obj, but got I8
		//IL_0457: Expected Obj, but got I
		//IL_045c: Expected I, but got Obj
		//IL_0daf: Expected Obj, but got I4
		//IL_0db8: Expected Obj, but got I4
		//IL_0db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc9: Expected Obj, but got I4
		//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dde: Expected I, but got Obj
		//IL_05fc: Expected Obj, but got I8
		//IL_0615: Expected I, but got Obj
		//IL_0dfa: Expected Obj, but got I4
		//IL_0e10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e15: Expected I4, but got Unknown
		//IL_0e1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e24: Expected Obj, but got Unknown
		//IL_0e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e42: Expected Obj, but got Unknown
		//IL_0eae: Expected Obj, but got I4
		//IL_0eb7: Expected Obj, but got I4
		//IL_0640: Expected Obj, but got I
		//IL_065b: Expected I4, but got Obj
		//IL_0699: Expected Obj, but got I8
		//IL_06b2: Expected I, but got Obj
		//IL_0ee4: Expected Obj, but got I
		//IL_0eef: Expected Obj, but got I4
		//IL_06f7: Expected Obj, but got I4
		//IL_0f1b: Expected I, but got Obj
		//IL_0782: Expected Obj, but got I
		//IL_0792: Expected Obj, but got I
		//IL_15ce: Expected Obj, but got I4
		//IL_15d7: Expected Obj, but got I4
		//IL_15d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15db: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e8: Expected Obj, but got I4
		//IL_15e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected Obj, but got I4
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Expected Obj, but got Unknown
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Expected Obj, but got Unknown
		//IL_1427: Expected Obj, but got I
		//IL_143f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1444: Expected Obj, but got Unknown
		//IL_1468: Expected I, but got Obj
		//IL_0f41: Expected Obj, but got I4
		//IL_0f6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f73: Expected I4, but got Unknown
		//IL_0fa8: Expected Obj, but got I4
		//IL_1644: Expected I, but got Obj
		//IL_114c: Expected Obj, but got I4
		//IL_1155: Expected Obj, but got I4
		//IL_1155: Unknown result type (might be due to invalid IL or missing references)
		//IL_1159: Unknown result type (might be due to invalid IL or missing references)
		//IL_1166: Expected Obj, but got I4
		//IL_1166: Unknown result type (might be due to invalid IL or missing references)
		//IL_116a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1172: Unknown result type (might be due to invalid IL or missing references)
		//IL_1003: Expected I, but got Obj
		//IL_119a: Expected Obj, but got I4
		//IL_10b1: Expected Obj, but got I4
		//IL_10ba: Expected Obj, but got I4
		//IL_10c3: Expected Obj, but got I4
		//IL_10c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d4: Expected Obj, but got I4
		//IL_10d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1019: Expected I, but got Obj
		//IL_104b: Expected Obj, but got I4
		//IL_1054: Expected Obj, but got I4
		//IL_1054: Unknown result type (might be due to invalid IL or missing references)
		//IL_1058: Unknown result type (might be due to invalid IL or missing references)
		//IL_1065: Expected Obj, but got I4
		//IL_1065: Unknown result type (might be due to invalid IL or missing references)
		//IL_1069: Unknown result type (might be due to invalid IL or missing references)
		//IL_1071: Unknown result type (might be due to invalid IL or missing references)
		//IL_1110: Unknown result type (might be due to invalid IL or missing references)
		//IL_1115: Expected Obj, but got Unknown
		//IL_112f: Expected I, but got Obj
		object obj = this + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		bool flag = obj == null;
		object obj3 = !flag;
		object obj10 = default;
		Enumerator<, > val = default;
		object obj12;
		object obj6;
		object obj11;
		int num9 = default;
		object obj9;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DA0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<System.__Canon> list = default;
			list._002Ector();
			capped = (List<SkinnedMeshRenderer>)(object)list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4250]");
			object obj5 = 0;
			int num = (int)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
			List<System.__Canon> list2 = default;
			bool flag2 = list2 == null;
			nint num2 = 1;
			if (flag2)
			{
				goto IL_1211;
			}
			int size = list2._size;
			bool flag3 = list2._size < 1;
			num2 = 1;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DC0]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D18]");
				int num3 = 0;
				int num5 = default;
				int num4 = num5;
				int num7 = default;
				int num6 = num7;
				Material[] array2 = default;
				Material[] array = array2;
				int num8 = num9;
				Mesh mesh2 = default;
				Mesh mesh = mesh2;
				SkinnedMeshRenderer skinnedMeshRenderer2 = default;
				SkinnedMeshRenderer skinnedMeshRenderer = skinnedMeshRenderer2;
				object obj7 = 0;
				int num10 = (int)obj5;
				nint num11 = 1;
				while (true)
				{
					bool flag4 = (nint)obj7 < size;
					object obj8 = !flag4;
					obj9 = obj10;
					val = (Enumerator<, >)0;
					num5 = num4;
					num7 = num6;
					array2 = array;
					num9 = num8;
					mesh2 = mesh;
					skinnedMeshRenderer2 = skinnedMeshRenderer;
					obj11 = -4294967296L;
					obj12 = obj7;
					num = num10;
					num2 = num11;
					if (obj8 != null)
					{
						break;
					}
					object obj13 = (object)list2 + obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v56+20]");
					skinnedMeshRenderer2 = (SkinnedMeshRenderer)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v56+20]");
					bool flag5 = (nint)0 == 0;
					num5 = num4;
					num7 = num6;
					array2 = array;
					num9 = num8;
					mesh2 = mesh;
					obj11 = -4294967296L;
					obj12 = obj7;
					num = num10;
					num2 = num11;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v56+20]");
						Mesh sharedMesh = ((SkinnedMeshRenderer)0).sharedMesh;
						object obj14 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v57+E4]");
						num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v57+E4]");
						bool flag6 = (nint)0 == 0;
						object obj15 = !flag6;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag7 = sharedMesh == null;
						bool flag8 = !flag7;
						object obj16 = !flag8;
						mesh2 = sharedMesh;
						num = 0;
						num2 = unchecked((nint)null);
						if (obj16 != null)
						{
							goto IL_0815;
						}
						Material[] sharedMaterials = skinnedMeshRenderer2.sharedMaterials;
						bool flag9 = sharedMaterials == null;
						num5 = num4;
						num7 = num6;
						array2 = array;
						mesh2 = sharedMesh;
						obj11 = -4294967296L;
						obj12 = obj7;
						num = 0;
						num2 = unchecked((nint)null);
						if (!flag9)
						{
							mesh2 = (Mesh)sharedMaterials.Length;
							bool flag10 = sharedMaterials.Length == 0;
							nint num12 = unchecked((nint)null);
							if (!flag10)
							{
								Mesh sharedMesh2 = skinnedMeshRenderer2.sharedMesh;
								bool flag11 = (object)sharedMesh2 == null;
								num5 = num4;
								num7 = num6;
								array2 = sharedMaterials;
								obj11 = -4294967296L;
								obj12 = obj7;
								num = 0;
								num2 = unchecked((nint)null);
								if (flag11)
								{
									goto IL_1211;
								}
								int subMeshCount = sharedMesh2.subMeshCount;
								bool flag12 = subMeshCount != sharedMaterials.Length;
								mesh2 = null;
								num12 = unchecked((nint)null);
								if (!flag12)
								{
									bool flag13 = sharedMaterials.Length == 0;
									obj9 = obj10;
									val = (Enumerator<, >)0;
									num5 = num4;
									num7 = num6;
									array2 = sharedMaterials;
									mesh2 = null;
									obj11 = -4294967296L;
									obj12 = obj7;
									num = 0;
									num2 = unchecked((nint)null);
									if (flag13)
									{
										break;
									}
									object obj17 = -4294967296L + sharedMaterials.Length;
									object obj18 = (object)sharedMaterials + obj17;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v71+20]");
									mesh2 = (Mesh)0;
									num12 = unchecked((nint)null);
								}
							}
							object obj19 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1253 @ X0_v103+E4]");
							bool flag14 = (nint)0 == 0;
							object obj20 = !flag14;
							if (obj20 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag15 = mesh2 == null;
							bool flag16 = !flag15;
							object obj21 = !flag16;
							array = sharedMaterials;
							num = 0;
							num2 = unchecked((nint)null);
							if (obj21 != null)
							{
								goto IL_0815;
							}
							bool flag17 = (object)mesh2 == null;
							num5 = num4;
							num7 = num6;
							array2 = sharedMaterials;
							obj11 = -4294967296L;
							obj12 = obj7;
							num = 0;
							num2 = unchecked((nint)null);
							if (!flag17)
							{
								string text = mesh2.name;
								bool flag18 = text == null;
								num5 = num4;
								num7 = num6;
								array2 = sharedMaterials;
								obj11 = -4294967296L;
								obj12 = obj7;
								num = 0;
								num2 = unchecked((nint)null);
								if (!flag18)
								{
									bool flag19 = text.Contains((string)obj6);
									bool flag20 = !flag19;
									array = sharedMaterials;
									num = 0;
									num2 = (nint)obj6;
									if (flag20)
									{
										goto IL_0815;
									}
									List<System.__Canon> list3 = (List<System.__Canon>)obj;
									bool flag21 = obj == null;
									num5 = num4;
									num7 = num6;
									array2 = sharedMaterials;
									obj11 = -4294967296L;
									obj12 = obj7;
									num = 0;
									num2 = (nint)obj6;
									if (!flag21)
									{
										System.__Canon[] items = list3._items;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D88]");
										object obj22 = 0;
										num7 = list3._version + 1;
										num9 = (int)obj22;
										list3._version = num7;
										bool flag22 = list3._items == null;
										num5 = num4;
										array2 = sharedMaterials;
										obj11 = -4294967296L;
										obj12 = obj7;
										num = 0;
										num2 = (nint)obj6;
										if (!flag22)
										{
											num6 = list3._size;
											num4 = items.Length;
											bool flag23 = list3._size < items.Length;
											object obj23 = !flag23;
											if (obj23 == null)
											{
												object obj24 = list3._items + list3._size;
												num9 = ++list3._size;
												object obj25 = obj24 + 32;
												obj25 = skinnedMeshRenderer2;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												num = 0;
												System.__Canon _Canon = (System.__Canon)(object)skinnedMeshRenderer2;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ X9_v28 (System.Int32)+20]");
												object obj26 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ X8_v65+A8]");
												object obj27 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1305 @ X8_v66+70]");
												num = 0;
												((List<System.__Canon>)obj).AddWithResize((System.__Canon)(object)skinnedMeshRenderer2);
												System.__Canon _Canon = (System.__Canon)(object)skinnedMeshRenderer2;
											}
											int value = ((int*)num3)->m_value;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1313 @ X0_v113 (System.Int32)+E4]");
											bool flag24 = (nint)0 == 0;
											object obj28 = !flag24;
											if (obj28 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												value = ((int*)num3)->m_value;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1313 @ X0_v113 (System.Int32)+A0]");
											object obj29 = (nint)0 + (nint)56;
											obj29 = mesh2;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											object obj30 = this + 136;
											capFlesh = (Material)(object)mesh2;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											array = sharedMaterials;
											num2 = (nint)mesh2;
											goto IL_0815;
										}
									}
								}
							}
						}
					}
					goto IL_1211;
					IL_0815:
					size = list2._size;
					obj12 = obj7 + 1;
					bool flag25 = (nint)obj12 < list2._size;
					num5 = num4;
					num7 = num6;
					array2 = array;
					obj11 = -4294967296L;
					num8 = num9;
					mesh = mesh2;
					skinnedMeshRenderer = skinnedMeshRenderer2;
					obj7 = obj12;
					num10 = num;
					num11 = num2;
					if (flag25)
					{
						continue;
					}
					goto IL_08a6;
				}
				goto IL_123f;
			}
		}
		goto IL_08a6;
		IL_123f:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_124d;
		IL_12a1:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_12af;
		IL_124d:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_125b;
		IL_1277:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_1285;
		IL_1269:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_1277;
		IL_12af:
		IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
		goto IL_12bd;
		IL_125b:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_1269;
		IL_12bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		object obj31 = 0;
		throw new ArgumentNullException();
		IL_1285:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_1293;
		IL_1293:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_12a1;
		IL_1231:
		NullReferenceException ex10 = new NullReferenceException();
		goto IL_123f;
		IL_08a6:
		Part[] array3 = parts;
		if (parts == null)
		{
			goto IL_1211;
		}
		num9 = array3.Length;
		object obj36;
		if (array3.Length >= 1)
		{
			int num13 = ~array3.Length;
			int num5 = array3.Length & num13;
			int num7 = 0;
			obj12 = 0;
			while (true)
			{
				bool flag26 = num9 == num7;
				obj9 = obj10;
				val = (Enumerator<, >)0;
				if (flag26)
				{
					break;
				}
				object obj32 = parts + num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X12_v18+20]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X12_v18+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X12_v4+38]");
					object obj34;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X12_v4+39]");
						obj34 = (nint)0 ^ (nint)1;
					}
					else
					{
						obj34 = 0;
					}
					object obj35 = obj12 & 1;
					num7++;
					obj33 = obj34 | obj35;
					bool flag27 = obj33 == null;
					obj36 = !flag27;
					bool flag28 = num5 != num7;
					obj12 = obj36;
					if (flag28)
					{
						continue;
					}
					goto IL_09bb;
				}
				goto IL_1211;
			}
			goto IL_123f;
		}
		obj12 = 0;
		goto IL_1565;
		IL_1211:
		NullReferenceException ex11 = new NullReferenceException();
		obj9 = obj10;
		val = (Enumerator<, >)0;
		goto IL_1231;
		IL_1565:
		if (obj == null)
		{
			goto IL_1211;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D78]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DB8]");
		obj11 = 0;
		Enumerator<, > enumerator = ((List<System.__Canon>)obj).GetEnumerator();
		num9 = (int)(&val);
		object obj37 = default;
		Enumerator<, > val2 = default;
		Predicate<System.__Canon> predicate = default;
		List<System.__Canon> list4 = default;
		object obj66 = default;
		while (true)
		{
			object obj38;
			Enumerator<, > val3;
			Enumerator<, > val4;
			if (val.MoveNext())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				obj37._002Ector();
				bool flag29 = obj37 == null;
				obj9 = 0;
				val = val2;
				obj38 = 0;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				nint num2 = unchecked((nint)null);
				if (flag29)
				{
					break;
				}
				obj = obj37 + 16;
				obj = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj39 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X0_v55+E4]");
				bool flag30 = (nint)0 == 0;
				object obj40 = !flag30;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag31 = (UnityEngine.Object)obj == null;
				bool flag32 = !flag31;
				object obj41 = !flag32;
				int num = 0;
				if (obj41 != null)
				{
					continue;
				}
				bool flag33 = obj == null;
				obj9 = 0;
				val = val2;
				obj38 = 0;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				num = 0;
				num2 = unchecked((nint)null);
				if (flag33)
				{
					goto IL_124d;
				}
				Mesh sharedMesh3 = ((SkinnedMeshRenderer)obj).sharedMesh;
				object obj42 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1265 @ X0_v61+E4]");
				bool flag34 = (nint)0 == 0;
				object obj43 = !flag34;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag35 = sharedMesh3 == null;
				bool flag36 = !flag35;
				object obj44 = !flag36;
				num = 0;
				if (obj44 != null)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DA8]");
				object obj45 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DB0]");
				object obj46 = 0;
				predicate._002Ector(obj37, (IntPtr)obj46);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D68]");
				object obj47 = 0;
				num = (int)obj47;
				bool flag37 = Array.Exists((System.__Canon[])(object)parts, predicate);
				bool flag38 = obj == null;
				object obj48 = 0;
				obj9 = 0;
				val = val2;
				obj38 = 0;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				num2 = (nint)predicate;
				if (flag38)
				{
					goto IL_1277;
				}
				Mesh sharedMesh4 = ((SkinnedMeshRenderer)obj).sharedMesh;
				bool flag39 = (object)sharedMesh4 == null;
				obj48 = 0;
				obj9 = 0;
				val = val2;
				obj38 = 0;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				num2 = unchecked((nint)null);
				if (flag39)
				{
					goto IL_1269;
				}
				int subMeshCount2 = sharedMesh4.subMeshCount;
				bool flag40 = obj == null;
				obj48 = 0;
				obj9 = 0;
				val = val2;
				obj38 = 0;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				num2 = unchecked((nint)null);
				if (flag40)
				{
					goto IL_1285;
				}
				Material[] sharedMaterials2 = ((Renderer)obj).sharedMaterials;
				bool flag41 = sharedMaterials2 == null;
				obj48 = 0;
				obj9 = 0;
				val = val2;
				obj38 = 0;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				num2 = unchecked((nint)null);
				if (flag41)
				{
					goto IL_125b;
				}
				Material[] array2 = (Material[])(subMeshCount2 - 1);
				num9 = (flag37 ? 1 : 0) ^ 1;
				int num3 = obj12 & num9;
				object obj49 = array2 - sharedMaterials2.Length;
				bool flag42 = (nint)obj49 < 0;
				object obj50 = array2 ^ sharedMaterials2.Length;
				object obj51 = (object)array2 ^ obj49;
				object obj52 = obj50 & obj51;
				bool flag43 = (nint)obj52 < 0;
				bool flag44 = flag42 == flag43;
				int num14 = num3 ^ (flag44 ? 1 : 0);
				int num15 = num14 & 1;
				bool flag45 = num15 == 0;
				object obj53 = !flag45;
				obj48 = 0;
				if (obj53 != null)
				{
					continue;
				}
				bool flag46 = num3 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B58]");
				object obj54 = 0;
				object obj55 = !flag46;
				object obj56 = ~obj55;
				if (obj56 == null)
				{
					num2 = subMeshCount2;
				}
				else
				{
					num2 = (nint)array2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				bool flag47 = list4 == null;
				obj48 = 0;
				obj9 = 0;
				val = val2;
				obj38 = 0;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				if (flag47)
				{
					goto IL_1293;
				}
				num9 = list4._size;
				object obj57 = sharedMaterials2.Length - list4._size;
				bool flag48 = (nint)obj57 < 0;
				int num16 = sharedMaterials2.Length ^ list4._size;
				int num17 = sharedMaterials2.Length ^ obj57;
				int num18 = num16 & num17;
				bool flag49 = num18 < 0;
				bool flag50 = flag48 == flag49;
				object obj58 = !flag50;
				obj56 = ~obj58;
				num = ((obj56 != null) ? list4._size : sharedMaterials2.Length);
				Array.Copy(sharedMaterials2, (Array)(object)list4, num);
				int num19 = num3 & 1;
				bool flag51 = num19 == 0;
				Material[] array4 = sharedMaterials2;
				num2 = (nint)list4;
				if (!flag51)
				{
					array4 = (Material[])(object)capFlesh;
					bool flag52 = (object)capFlesh == null;
					nint num20 = (nint)list4;
					if (!flag52)
					{
						nint num21 = (nint)list4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ X8_v47 (Il2CppClass<System.Collections.Generic.List`1<System.__Canon>>)+40]");
						num20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag53 = ex6 == null;
						obj48 = 0;
						obj9 = 0;
						val = val2;
						obj38 = 0;
						val3 = val2;
						val4 = (Enumerator<, >)(ref val);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ X8_v47 (Il2CppClass<System.Collections.Generic.List`1<System.__Canon>>)+40]");
						num2 = 0;
						if (flag53)
						{
							goto IL_12bd;
						}
					}
					bool flag54 = (nint)array2 < list4._size;
					object obj59 = !flag54;
					obj48 = 0;
					obj9 = 0;
					val = val2;
					obj38 = 0;
					val3 = val2;
					val4 = (Enumerator<, >)(ref val);
					num2 = num20;
					if (obj59 != null)
					{
						goto IL_12af;
					}
					object obj60 = (object)list4 + (object)array2;
					object obj61 = obj60 + 32;
					obj61 = array4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num2 = (nint)array4;
				}
				bool flag55 = obj == null;
				obj48 = 0;
				obj9 = 0;
				val = val2;
				obj38 = 0;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				if (!flag55)
				{
					((Renderer)obj).sharedMaterials = (Material[])(object)list4;
					obj48 = 0;
					num = 0;
					continue;
				}
				goto IL_12a1;
			}
			obj9 = 0;
			val = val2;
			obj38 = 0;
			val3 = val2;
			val4 = (Enumerator<, >)(ref val);
			object obj62 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D70]");
				object obj63 = 0;
				obj31 = obj63;
				((Enumerator<, >*)val4)->Dispose();
				bool flag56 = obj62 == null;
				object obj64 = !flag56;
				if (obj64 == null)
				{
					bool flag57 = obj9 == null;
					object obj65 = !flag57;
					OutOfMemoryException ex12 = (OutOfMemoryException)val4;
					if (obj65 == null)
					{
						return;
					}
				}
				else
				{
					OutOfMemoryException ex12 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)obj31 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj9 = 1;
					obj62 = obj38;
					continue;
				}
				if ((nint)obj31 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj62 = obj66;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj38 = obj66;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D22C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
		}
		goto IL_1231;
		IL_09bb:
		obj12 = obj36;
		goto IL_1565;
	}

	public static Material[] WithCaps(SkinnedMeshRenderer skin)
	{
		//IL_03d2: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_03f0: Expected Obj, but got I
		//IL_041a: Expected Obj, but got I4
		//IL_047c: Expected Obj, but got I
		//IL_049e: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I4
		//IL_01de: Expected Obj, but got I
		//IL_0229: Expected Obj, but got I4
		//IL_0440: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got I
		//IL_0309: Expected Obj, but got I4
		//IL_0312: Expected Obj, but got I4
		//IL_0293: Expected I, but got Obj
		//IL_02a3: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I4
		//IL_02de: Expected Obj, but got I
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Obj, but got Unknown
		//IL_035e: Expected Obj, but got I
		bool flag = (object)skin == null;
		IntPtr intPtr = default;
		UnityEngine.Object obj = (UnityEngine.Object)(nint)intPtr;
		Material[] sharedMaterials;
		IndexOutOfRangeException ex = default;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			sharedMaterials = skin.sharedMaterials;
			Mesh sharedMesh = skin.sharedMesh;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num2;
			int num;
			if (sharedMesh != null)
			{
				Mesh sharedMesh2 = skin.sharedMesh;
				bool flag3 = (object)sharedMesh2 == null;
				num = 0;
				obj = null;
				if (flag3)
				{
					goto IL_0382;
				}
				int subMeshCount = sharedMesh2.subMeshCount;
				UnityEngine.Object obj5 = null;
				num2 = subMeshCount;
			}
			else
			{
				UnityEngine.Object obj5 = null;
				num2 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D18]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v18+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj6;
			}
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v18+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v8+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X9_v5+38]");
			bool flag6 = (UnityEngine.Object)0 == null;
			bool flag7 = !flag6;
			object obj12 = !flag7;
			if (obj12 != null)
			{
				goto IL_0375;
			}
			bool flag8 = sharedMaterials == null;
			num = 0;
			obj = null;
			if (!flag8)
			{
				object obj13 = num2 - 1;
				if ((nint)obj13 != sharedMaterials.Length)
				{
					goto IL_0375;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B58]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Material[] array = default;
				sharedMaterials.CopyTo(array, 0);
				object obj15 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v28+E4]");
				bool flag9 = (nint)0 == 0;
				object obj16 = !flag9;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj15 = obj6;
				}
				bool flag10 = array == null;
				object obj17 = 0;
				num = 0;
				obj = (UnityEngine.Object)(object)array;
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v28+A0]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v15+38]");
					bool flag11 = (nint)0 == 0;
					UnityEngine.Object obj19 = (UnityEngine.Object)(object)array;
					if (!flag11)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v18 (Il2CppClass<UnityEngine.Material[]>)+40]");
						obj19 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag12 = ex == null;
						obj17 = 0;
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v18 (Il2CppClass<UnityEngine.Material[]>)+40]");
						obj = (UnityEngine.Object)0;
						if (flag12)
						{
							goto IL_039e;
						}
					}
					bool flag13 = sharedMaterials.Length < array.Length;
					object obj20 = !flag13;
					obj17 = 0;
					num = 0;
					obj = obj19;
					if (obj20 == null)
					{
						object obj21 = array + sharedMaterials.Length;
						object obj22 = obj21 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v15+38]");
						obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						return array;
					}
					goto IL_0390;
				}
			}
		}
		goto IL_0382;
		IL_039e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		return (Material[])(object)new ArgumentNullException();
		IL_0390:
		ex = new IndexOutOfRangeException();
		goto IL_039e;
		IL_0375:
		return sharedMaterials;
		IL_0382:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0390;
	}

	public bool IsTorn(ApePart id)
	{
		//IL_0025: Expected I4, but got Obj
		Part part = Find(id);
		bool flag = part == null;
		bool result = (byte)(int)part != 0;
		if (!flag)
		{
			bool flag2 = !part.torn;
			bool flag3 = !flag2;
			result = flag3;
		}
		return result;
	}

	public unsafe void Tear(ApePart id, Vector3 impulse)
	{
		//IL_0010: Expected Obj, but got I
		//IL_2c3f: Expected Obj, but got I4
		//IL_31c1: Expected Obj, but got I
		//IL_31c9: Expected I, but got Obj
		//IL_0069: Expected Obj, but got I4
		//IL_2c55: Expected Obj, but got Ref
		//IL_0035: Expected I, but got Obj
		//IL_28f2: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I4
		//IL_28ca: Expected I, but got Obj
		//IL_291a: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I
		//IL_01b4: Expected Obj, but got I4
		//IL_2994: Expected Obj, but got I4
		//IL_299c: Expected Obj, but got I
		//IL_051c: Expected VT, but got I4
		//IL_05b6: Expected Obj, but got I4
		//IL_05fe: Expected VT, but got I4
		//IL_06cb: Expected Obj, but got I4
		//IL_2ce4: Expected VT, but got I4
		//IL_2ced: Expected Obj, but got I4
		//IL_2d02: Expected Obj, but got I
		//IL_0248: Expected VT, but got I4
		//IL_0251: Expected Obj, but got I4
		//IL_2d30: Expected Obj, but got I
		//IL_063a: Expected VT, but got I4
		//IL_0643: Expected Obj, but got I4
		//IL_071d: Expected Obj, but got Ref
		//IL_057e: Expected VT, but got I4
		//IL_0762: Expected Obj, but got I4
		//IL_076f: Expected Obj, but got Ref
		//IL_0790: Expected Obj, but got I4
		//IL_0693: Expected VT, but got I4
		//IL_074b: Expected I, but got Obj
		//IL_02df: Expected Obj, but got I4
		//IL_2a46: Expected I4, but got Obj
		//IL_2a4e: Expected I, but got Obj
		//IL_2c82: Expected Obj, but got I
		//IL_0329: Expected VT, but got I4
		//IL_310e: Expected Obj, but got Ref
		//IL_3125: Expected I4, but got Obj
		//IL_0352: Expected Obj, but got I4
		//IL_035f: Expected Obj, but got Ref
		//IL_0380: Expected VT, but got I4
		//IL_0389: Expected Obj, but got I4
		//IL_039e: Expected I, but got Obj
		//IL_033b: Expected I, but got Obj
		//IL_2b57: Expected Obj, but got I4
		//IL_2bc9: Expected Obj, but got I4
		//IL_24f3: Expected Obj, but got I4
		//IL_278a: Expected Obj, but got I
		//IL_287c: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D18]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v3+A0]");
		object obj4 = 0;
		nint num = (nint)obj4;
		if (obj4 != null)
		{
			ProfilerUnsafeUtility.BeginSample((IntPtr)obj4);
		}
		Part part = Find(id);
		bool flag2 = part == null;
		nint num2 = 0;
		object obj5 = 0;
		OutOfMemoryException ex = null;
		ApePart apePart = id;
		float num4 = default;
		float num3 = num4;
		float num6 = default;
		float num5 = num6;
		float num8 = default;
		float num7 = num8;
		object obj7 = default;
		object obj10 = default;
		UnityEngine.Object obj11;
		UnityEngine.Object obj14;
		bool flag9 = default;
		Vector3 vector = default;
		object obj19 = default;
		OutOfMemoryException ex2 = default;
		float num9;
		float num10;
		float num11;
		if (!flag2)
		{
			bool flag3 = (byte)(~(part.torn ? 1u : 0u)) != 0;
			object obj6 = !flag3;
			num2 = 0;
			obj5 = 0;
			ex = null;
			apePart = id;
			num3 = num4;
			num5 = num6;
			num7 = num8;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D28]");
				obj7 = 0;
				part.torn = true;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v85+E4]");
				bool flag4 = (nint)0 == 0;
				object obj9 = !flag4;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = GillaPull.Tearing(this, id);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				obj10 = 0;
				obj11 = part.renderer;
				object obj12 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X0_v89+E4]");
				bool flag6 = (nint)0 == 0;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj20;
				if (obj11 != null)
				{
					bool flag7 = (byte)(~(spawnPieces ? 1u : 0u)) != 0;
					obj14 = null;
					if (!flag7)
					{
						bool flag8 = (object)part.renderer == null;
						num2 = 0;
						flag9 = flag5;
						vector = (Vector3)0;
						obj5 = 0;
						ex = null;
						obj14 = null;
						num3 = num4;
						num5 = num6;
						num7 = num8;
						if (flag8)
						{
							goto IL_29c7;
						}
						bool flag10 = part.renderer.enabled;
						bool flag11 = !flag10;
						obj14 = null;
						if (!flag11)
						{
							object obj15 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ X0_v224+E4]");
							bool flag12 = (nint)0 == 0;
							object obj16 = !flag12;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj15 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ X0_v224+A0]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ X8_v99+8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ X8_v99+8]");
								ProfilerUnsafeUtility.BeginSample((IntPtr)0);
							}
							GameObject gameObject = SpawnPiece(part, (Vector3)0);
							object obj18 = (object)(&num2);
							bool flag13 = obj18 == null;
							apePart = (ApePart)part;
							if (!flag13)
							{
								ProfilerUnsafeUtility.EndSample((IntPtr)obj18);
								apePart = (ApePart)0;
							}
							obj19 = 0;
							ex2 = null;
							obj20 = (object)(&num2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ X8_v99+8]");
							num2 = 0;
							flag9 = flag5;
							vector = (Vector3)0;
							obj5 = 0;
							ex = null;
							num3 = num4;
							num = (nint)gameObject;
							num5 = num6;
							num7 = num8;
							goto IL_2a79;
						}
					}
					num2 = 0;
					num = 0;
					bool flag14 = (object)part.renderer == null;
					num9 = num8;
					num10 = num6;
					num11 = num4;
					flag9 = flag5;
					vector = (Vector3)0;
					obj5 = 0;
					ex = null;
					num3 = num4;
					obj11 = (UnityEngine.Object)num;
					num5 = num6;
					num7 = num8;
					if (flag14)
					{
						goto IL_29a1;
					}
					part.renderer.enabled = false;
					num9 = num8;
					num10 = num6;
					num11 = num4;
					Vector3 vector2 = (Vector3)0;
					bool flag15 = false;
				}
				else
				{
					num9 = num8;
					num10 = num6;
					num11 = num4;
					num2 = 0;
					Vector3 vector2 = (Vector3)0;
					bool flag15 = false;
					num = 0;
				}
				object obj21 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ X0_v94+E4]");
				bool flag16 = (nint)0 == 0;
				object obj22 = !flag16;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag17 = part.stump != null;
				bool flag18 = !flag17;
				vector = (Vector3)0;
				bool flag19 = false;
				if (!flag18)
				{
					bool flag20 = (object)part.stump == null;
					flag9 = flag5;
					vector = (Vector3)0;
					obj5 = 0;
					ex = null;
					apePart = (ApePart)0;
					num3 = num4;
					num5 = num6;
					num7 = num8;
					if (flag20)
					{
						goto IL_2983;
					}
					part.stump.SetActive(value: true);
					vector = (Vector3)0;
					flag19 = true;
				}
				object obj23 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1183 @ X0_v100+E4]");
				bool flag21 = (nint)0 == 0;
				object obj24 = !flag21;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj23 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1183 @ X0_v100+A0]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X8_v48+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X8_v48+10]");
					ProfilerUnsafeUtility.BeginSample((IntPtr)0);
					flag19 = false;
				}
				SetCaps();
				object obj26 = (object)(&num2);
				bool flag22 = obj26 == null;
				apePart = (flag19 ? ((ApePart)1) : ((ApePart)0));
				if (!flag22)
				{
					ProfilerUnsafeUtility.EndSample((IntPtr)obj26);
					apePart = (ApePart)0;
				}
				obj19 = 0;
				ex2 = null;
				obj20 = (object)(&num2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X8_v48+10]");
				num2 = 0;
				flag9 = flag5;
				obj5 = 0;
				ex = null;
				num3 = num4;
				num5 = num6;
				num7 = num8;
				goto IL_2966;
			}
		}
		goto IL_2c4d;
		IL_2966:
		OutOfMemoryException ex3 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_2983;
		IL_29a1:
		NullReferenceException ex4 = new NullReferenceException();
		num8 = num9;
		num6 = num10;
		num4 = num11;
		goto IL_29c7;
		IL_2c4d:
		object obj28 = default;
		object obj27 = (object)(&obj28);
		if (obj27 != null)
		{
			ProfilerUnsafeUtility.EndSample((IntPtr)obj27);
			apePart = (ApePart)0;
		}
		bool flag23 = ex == null;
		object obj29 = !flag23;
		if (obj29 == null)
		{
			bool flag24 = obj5 == null;
			object obj30 = !flag24;
			OutOfMemoryException ex5 = ex;
			if (obj30 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex5 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		num9 = num8;
		num10 = num6;
		num11 = num4;
		goto IL_2966;
		IL_2983:
		NullReferenceException ex6 = new NullReferenceException();
		obj14 = (UnityEngine.Object)apePart;
		obj11 = (UnityEngine.Object)num;
		goto IL_29a1;
		IL_2a79:
		OutOfMemoryException ex7 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex8 = new NullReferenceException();
		NullReferenceException ex9 = new NullReferenceException();
		OutOfMemoryException ex10 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex11 = new NullReferenceException();
		NullReferenceException ex12 = new NullReferenceException();
		NullReferenceException ex13 = new NullReferenceException();
		NullReferenceException ex14 = new NullReferenceException();
		NullReferenceException ex15 = new NullReferenceException();
		if (apePart == (ApePart)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj19 = 1;
		}
		else
		{
			if (apePart != (ApePart)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
				if (apePart == (ApePart)2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj5 = 1;
				}
				else
				{
					if (apePart != (ApePart)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					object obj31 = default;
					ex = (OutOfMemoryException)obj31;
				}
				goto IL_2c4d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj32 = default;
			ex2 = (OutOfMemoryException)obj32;
		}
		Part part2 = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
		bool flag25 = (nint)part2 == 9;
		float num13 = default;
		float num12 = num13;
		float num15 = default;
		float num14 = num15;
		float num17 = default;
		float num16 = num17;
		object obj34 = default;
		object obj33 = obj34;
		float num19 = default;
		float num18 = num19;
		float num21 = default;
		float num20 = num21;
		float num23 = default;
		float num22 = num23;
		float num25 = default;
		float num24 = num25;
		float num27 = default;
		float num26 = num27;
		nint num28 = default;
		IntPtr intPtr = num28;
		double num30 = default;
		double num29 = num30;
		double num32 = default;
		double num31 = num32;
		bool flag27 = default;
		bool flag26 = flag27;
		float num34 = default;
		float num33 = num34;
		float num36 = default;
		float num35 = num36;
		Vector3 vector4 = default;
		Vector3 vector3 = vector4;
		float num38 = default;
		float num37 = num38;
		double num40 = default;
		double num39 = num40;
		object obj36 = default;
		object obj35 = obj36;
		float num42 = default;
		float num41 = num42;
		float num44 = default;
		float num43 = num44;
		num9 = num8;
		num10 = num6;
		num11 = num4;
		object obj37 = obj19;
		OutOfMemoryException ex16 = ex2;
		bool flag28 = flag9;
		object obj38 = obj10;
		Vector3 vector5 = vector;
		object obj39 = obj7;
		object obj40 = obj5;
		OutOfMemoryException ex17 = ex;
		ApePart apePart2 = apePart;
		float num45 = num3;
		IntPtr intPtr2 = num;
		float num46 = num5;
		float num47 = num7;
		if (!flag25)
		{
			bool flag29 = part2 == null;
			object obj41 = !flag29;
			num12 = num13;
			num14 = num15;
			num16 = num17;
			obj33 = obj34;
			num18 = num19;
			num20 = num21;
			num22 = num23;
			num24 = num25;
			num26 = num27;
			intPtr = num28;
			num29 = num30;
			num31 = num32;
			flag26 = flag27;
			num33 = num34;
			num35 = num36;
			vector3 = vector4;
			num37 = num38;
			num39 = num40;
			obj35 = obj36;
			num41 = num42;
			num43 = num44;
			num9 = num8;
			num10 = num6;
			num11 = num4;
			obj37 = obj19;
			ex16 = ex2;
			flag28 = flag9;
			obj38 = obj10;
			vector5 = vector;
			obj39 = obj7;
			obj40 = obj5;
			ex17 = ex;
			apePart2 = apePart;
			num45 = num3;
			intPtr2 = num;
			num46 = num5;
			num47 = num7;
			if (obj41 != null)
			{
				goto IL_2c4d;
			}
		}
		Action<ApePart, GameObject> partTorn = this.m_PartTorn;
		bool flag30 = this.m_PartTorn == null;
		num13 = num12;
		num15 = num14;
		num17 = num16;
		obj34 = obj33;
		num19 = num18;
		num21 = num20;
		num23 = num22;
		num25 = num24;
		num27 = num26;
		num28 = intPtr;
		num30 = num29;
		num32 = num31;
		flag27 = flag26;
		num34 = num33;
		num36 = num35;
		vector4 = vector3;
		num38 = num37;
		num40 = num39;
		obj36 = obj35;
		num42 = num41;
		num44 = num43;
		num8 = num9;
		num6 = num10;
		num4 = num11;
		obj19 = obj37;
		ex2 = ex16;
		flag9 = flag28;
		obj10 = obj38;
		vector = vector5;
		obj7 = obj39;
		obj5 = obj40;
		ex = ex17;
		apePart = apePart2;
		num3 = num45;
		num = intPtr2;
		num5 = num46;
		num7 = num47;
		if (!flag30)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v40 (System.Action`2<ApePart, UnityEngine.GameObject>)+18]");
			obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v40 (System.Action`2<ApePart, UnityEngine.GameObject>)+28]");
			num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v466 @ X8_v40 (System.Action`2<ApePart, UnityEngine.GameObject>)+18] (should have been resolved before IL gen)");
			num13 = num12;
			num15 = num14;
			num17 = num16;
			obj34 = obj33;
			num19 = num18;
			num21 = num20;
			num23 = num22;
			num25 = num24;
			num27 = num26;
			num30 = num29;
			num32 = num31;
			flag27 = flag26;
			num34 = num33;
			num36 = num35;
			vector4 = vector3;
			num38 = num37;
			num40 = num39;
			num42 = num41;
			num44 = num43;
			num8 = num9;
			num6 = num10;
			num4 = num11;
			obj19 = obj37;
			ex2 = ex16;
			flag9 = flag28;
			obj10 = obj38;
			vector = (Vector3)(nint)intPtr2;
			obj7 = obj39;
			obj5 = obj40;
			ex = ex17;
			apePart = id;
			num3 = num45;
			num = intPtr2;
			num5 = num46;
			num7 = num47;
		}
		goto IL_2c4d;
		IL_29c7:
		NullReferenceException ex18 = new NullReferenceException();
		num9 = num8;
		num10 = num6;
		num11 = num4;
		NullReferenceException ex19 = new NullReferenceException();
		OutOfMemoryException ex20 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex21 = new NullReferenceException();
		OutOfMemoryException ex22 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		apePart = (ApePart)obj14;
		num = (nint)obj11;
		NullReferenceException ex23 = new NullReferenceException();
		num8 = num9;
		num6 = num10;
		num4 = num11;
		goto IL_2a79;
	}

	public void Sawn(ApePart id, GameObject piece, Vector3 at, Vector3 outWay, GillaRip.Along along)
	{
		//IL_0144: Expected Obj, but got I4
		//IL_0ccf: Expected VT, but got F4
		//IL_0ce5: Expected Obj, but got I
		//IL_0d0f: Expected Obj, but got I4
		//IL_017e: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_0332: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got I4
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0374: Expected I4, but got VT
		//IL_0382: Expected VT, but got I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0131: Expected Obj, but got I
		//IL_03a4: Expected I4, but got I8
		//IL_03be: Expected Obj, but got I4
		//IL_03c6: Expected I4, but got VT
		//IL_03d0: Expected Obj, but got I4
		//IL_03d9: Expected VT, but got I4
		//IL_01ca: Expected Obj, but got I
		//IL_04bc: Expected Obj, but got I
		//IL_04e6: Expected Obj, but got I4
		//IL_0513: Expected F8, but got I
		//IL_052f: Expected VT, but got I4
		//IL_0559: Expected Obj, but got I4
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected I4, but got Unknown
		//IL_0421: Expected Obj, but got I
		//IL_044b: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I4
		//IL_05a5: Expected F8, but got I
		//IL_05de: Expected VT, but got I4
		//IL_0477: Expected VT, but got I4
		//IL_048e: Expected VT, but got I4
		//IL_02cc: Expected Obj, but got I
		//IL_02dc: Expected Obj, but got I
		//IL_02ec: Expected Obj, but got I
		//IL_0bb6: Expected Obj, but got I
		//IL_0be0: Expected Obj, but got I4
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_02af: Expected Obj, but got I4
		//IL_0c08: Expected VT, but got Obj
		//IL_0616: Expected Obj, but got I4
		//IL_0665: Expected F8, but got I
		//IL_069e: Expected VT, but got I4
		//IL_0d2d: Expected Obj, but got I
		//IL_0d45: Expected Obj, but got I
		//IL_0d5a: Expected Obj, but got I
		//IL_0db1: Expected Obj, but got I4
		//IL_0725: Invalid comparison between F8 and I
		//IL_0786: Expected Obj, but got I
		//IL_078e: Expected F8, but got Obj
		//IL_079e: Expected F8, but got I
		//IL_07ae: Expected F8, but got I
		//IL_0dcf: Expected Obj, but got I
		//IL_0df9: Expected Obj, but got I4
		//IL_07d7: Expected VT, but got I4
		//IL_07d7: Expected VT, but got Obj
		//IL_07e7: Expected Obj, but got I
		//IL_0806: Expected Obj, but got I
		//IL_084d: Expected Obj, but got I
		//IL_0877: Expected Obj, but got I4
		//IL_08a2: Expected VT, but got I4
		//IL_08e3: Expected VT, but got I4
		//IL_0923: Expected Obj, but got I4
		//IL_0923: Expected VT, but got Obj
		//IL_095f: Expected Obj, but got I4
		//IL_09f4: Expected VT, but got I4
		//IL_0a1c: Expected Obj, but got I
		//IL_0abf: Expected VT, but got I4
		//IL_0b09: Expected Obj, but got I4
		//IL_0b4b: Expected Obj, but got I4
		//IL_0b4b: Expected VT, but got Obj
		//IL_0b97: Expected Obj, but got I4
		//IL_0ba1: Expected VT, but got Obj
		Part part = Find(id);
		if (part == null)
		{
			return;
		}
		object obj2;
		if (~(part.torn ? 1u : 0u) == 0)
		{
			if (id == 0)
			{
				return;
			}
			bool flag = (byte)(~(part.sawn ? 1u : 0u)) != 0;
			object obj = !flag;
			if (obj == null)
			{
				return;
			}
		}
		else if (~(part.sawn ? 1u : 0u) != 0)
		{
			obj2 = 0;
			goto IL_0c8e;
		}
		int[] array = sawnAgain;
		if (sawnAgain == null)
		{
			goto IL_0c4d;
		}
		bool flag2 = array.Length < (int)id;
		object obj3 = !flag2;
		object obj4 = array.Length - id;
		bool flag3 = obj4 == null;
		object obj5 = ~obj3;
		object obj6 = obj5 | flag3;
		if (obj6 != null)
		{
			goto IL_0c5b;
		}
		object obj7 = sawnAgain + id;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v65+20]");
		obj2 = (nint)0 + (nint)1;
		goto IL_0c8e;
		IL_0ba6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X0_v27+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num = default;
		GillaSplatter.Around((Vector3)this, num);
		float num2 = num;
		goto IL_0c15;
		IL_0c15:
		Action<ApePart, GameObject> partTorn = this.m_PartTorn;
		if (this.m_PartTorn != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v185 @ X8_v15 (System.Action`2<ApePart, UnityEngine.GameObject>)+18] (should have been resolved before IL gen)");
		}
		return;
		IL_0308:
		object obj12;
		object obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = piece != null;
		bool flag7 = !flag6;
		int pulses = (int)outWay;
		GillaCorpse gillaCorpse = null;
		PieceKey pieceKey = (PieceKey)0;
		if (!flag7)
		{
			int num3 = (int)(pieceOwner & 0x80000000L);
			bool flag8 = num3 == 0;
			object obj14 = !flag8;
			pulses = (int)outWay;
			gillaCorpse = (GillaCorpse)pieceOwner;
			pieceKey = (PieceKey)0;
			if (obj14 == null)
			{
				byte part2 = (byte)(int)(id + obj2);
				PieceKey pieceKey2 = new PieceKey(3, pieceOwner, part2, 1);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E60]");
				object obj15 = 0;
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X0_v90+E4]");
				bool flag9 = (nint)0 == 0;
				object obj17 = !flag9;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaSlice.Name(piece, (PieceKey)0);
				pulses = 0;
				gillaCorpse = null;
				pieceKey = (PieceKey)0;
			}
		}
		if (~(spawnPieces ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj18 = 0;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X0_v19+E4]");
			bool flag10 = (nint)0 == 0;
			object obj20 = !flag10;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA0C]");
			double num4 = 0.0;
			float num5 = default;
			float num6 = default;
			Sfx.Play(tearSounds, (Vector3)0, num, num5, num6);
			object obj21 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X0_v22+E4]");
			bool flag11 = (nint)0 == 0;
			object obj22 = !flag11;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag12 = bloodMaterial != null;
			bool flag13 = !flag12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			double num7 = 0.0;
			double num8 = tearVolume;
			float num9 = num6;
			float num10 = num5;
			float num11 = num;
			int num12 = 0;
			Material material = null;
			Vector3 vector = (Vector3)0;
			if (!flag13)
			{
				object obj23 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X0_v31+E4]");
				bool flag14 = (nint)0 == 0;
				object obj24 = !flag14;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag15 = part.joint != null;
				bool flag16 = !flag15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
				num7 = 0.0;
				num8 = tearVolume;
				num9 = num6;
				num10 = num5;
				num11 = num;
				num12 = 0;
				material = null;
				vector = (Vector3)0;
				if (!flag16)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj25 = 0;
					object obj26 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v28+A0]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v29+18]");
					double num13 = 0.0 * 0.5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v29+1C]");
					double num14 = 0.0 * 0.5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v29+20]");
					double num15 = 0.0 * 0.5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj28 = 0;
					double num17 = default;
					double num16 = num17 + num13;
					object obj29 = obj28;
					double num19 = default;
					double num18 = num19 + num14;
					double num21 = default;
					double num20 = num21 + num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X0_v38+E4]");
					bool flag17 = (nint)0 == 0;
					object obj30 = !flag17;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					double num22 = num16 * num16;
					double num23 = num18 * num18;
					double num24 = num22 + num23;
					double num25 = num20 * num20;
					double num26 = num24 + num25;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					double num29;
					if (num26 > 0.0)
					{
						double num27 = num16 / num26;
						double num28 = num18 / num26;
						num29 = num20 / num26;
					}
					else
					{
						object obj31 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X8_v49+A0]");
						object obj32 = 0;
						double num27 = (double)obj32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v50+4]");
						double num28 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v50+8]");
						num29 = 0.0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
					object obj33 = 0;
					object obj34 = obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X0_v40+E4]");
					bool flag18 = (nint)0 == 0;
					object obj35 = !flag18;
					if (obj35 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Blood.Burst((Vector3)bloodMaterial, (Vector3)0, null, num);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D58]");
					object obj37 = 0;
					GameObject gameObject = default;
					gameObject._002Ector((string)obj37);
					if ((object)gameObject != null)
					{
						Transform transform = gameObject.transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D18]");
						object obj38 = 0;
						object obj39 = obj38;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v44+E4]");
						bool flag19 = (nint)0 == 0;
						object obj40 = !flag19;
						if (obj40 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Transform parent = NearestBone(part, (Vector3)0);
						if ((object)transform != null)
						{
							transform.SetParent(parent, worldPositionStays: true);
							transform.position = (Vector3)0;
							num8 = bleedSeconds;
							num12 = bleedPulses;
							Blood.Spray(transform, (Vector3)bloodMaterial, (Material)gushDroplets, (float)num17, bleedPulses, pulses, (float)num19);
							GameObject obj41 = transform.gameObject;
							object obj42 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X8_v45+E4]");
							bool flag20 = (nint)0 == 0;
							object obj43 = !flag20;
							if (obj43 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							num11 = bleedSeconds + 1.5f;
							UnityEngine.Object.Destroy(obj41, num11);
							bool flag21 = piece != null;
							bool flag22 = !flag21;
							num4 = num29;
							num7 = 1.0;
							num9 = (float)num21;
							num10 = (float)num19;
							material = null;
							vector = (Vector3)0;
							if (flag22)
							{
								goto IL_0ba6;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E40]");
							object obj44 = 0;
							GameObject gameObject2 = default;
							gameObject2._002Ector((string)obj44);
							if ((object)gameObject2 != null)
							{
								Transform transform2 = gameObject2.transform;
								if ((object)piece != null)
								{
									Transform parent2 = piece.transform;
									if ((object)transform2 != null)
									{
										transform2.SetParent(parent2, worldPositionStays: true);
										transform2.position = (Vector3)0;
										object obj45 = obj33;
										float num30 = (float)(0.0 - num17);
										float num31 = (float)(0.0 - num19);
										float num32 = (float)(0.0 - num21);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X0_v67+E4]");
										bool flag23 = (nint)0 == 0;
										object obj46 = !flag23;
										if (obj46 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Blood.Spray(transform2, (Vector3)bloodMaterial, (Material)45, num30, 3, pulses, num31);
										num4 = num29;
										num7 = 1.0;
										num8 = 2.0;
										num9 = num32;
										num10 = num31;
										num11 = num30;
										num12 = 3;
										material = (Material)45;
										vector = (Vector3)bloodMaterial;
										goto IL_0ba6;
									}
								}
							}
						}
					}
					goto IL_0c4d;
				}
			}
			goto IL_0ba6;
		}
		goto IL_0c15;
		IL_0c8e:
		part.torn = true;
		Vector3 vector2 = default;
		num2 = vector2.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		part.sawPlane = (Vector4)vector2.x;
		SetCaps();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		obj12 = 0;
		object obj47 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X0_v6+E4]");
		bool flag24 = (nint)0 == 0;
		object obj48 = !flag24;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag25 = piece != null;
		bool flag26 = !flag25;
		object obj49 = 0;
		System.__Canon _Canon = null;
		if (flag26)
		{
			goto IL_0308;
		}
		List<System.__Canon> list = (List<System.__Canon>)(object)pieces;
		if ((object)pieces != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4940]");
			object obj50 = 0;
			System.__Canon[] items = list._items;
			object obj51 = obj50;
			int version = list._version + 1;
			list._version = version;
			if (list._items != null)
			{
				bool flag27 = list._size < items.Length;
				object obj52 = !flag27;
				if (obj52 == null)
				{
					object obj53 = list._items + list._size;
					int size = list._size + 1;
					list._size = size;
					object obj54 = obj53 + 32;
					obj54 = piece;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj49 = 0;
					_Canon = (System.__Canon)(object)piece;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X9_v14+20]");
					object obj55 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v58+A8]");
					object obj56 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v59+70]");
					obj49 = 0;
					((List<System.__Canon>)(object)pieces).AddWithResize((System.__Canon)(object)piece);
					_Canon = (System.__Canon)(object)piece;
				}
				goto IL_0308;
			}
		}
		goto IL_0c4d;
		IL_0c5b:
		throw new IndexOutOfRangeException();
		IL_0c4d:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0c5b;
	}

	private static Transform NearestBone(Part p, Vector3 at)
	{
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I4
		//IL_0509: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got I4
		//IL_0420: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got I8
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I4
		//IL_0272: Expected Obj, but got I4
		//IL_05a0: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got I4
		//IL_02dd: Expected Obj, but got I
		//IL_02fb: Expected Obj, but got I4
		//IL_0521: Expected Obj, but got I4
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected Obj, but got Unknown
		//IL_0560: Expected Obj, but got I4
		//IL_0571: Expected Obj, but got I4
		//IL_0344: Expected Obj, but got I
		//IL_03f1: Expected Obj, but got I
		object obj;
		UnityEngine.Object obj2;
		if (p != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj = 0;
			obj2 = p.joint;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = default;
			object obj8 = default;
			object obj10 = default;
			object obj15;
			object obj9;
			object obj14;
			object obj13;
			if (obj2 != null)
			{
				if ((object)obj2 == null)
				{
					goto IL_04b4;
				}
				Vector3 position = ((Transform)obj2).position;
				object obj5 = obj6 - obj6;
				object obj7 = obj8 - obj8;
				obj9 = obj10 - obj10;
				object obj11 = obj5 * obj5;
				object obj12 = obj7 * obj7;
				obj13 = obj11 + obj12;
				obj14 = obj9 * obj9;
				obj15 = obj14 + obj13;
				UnityEngine.Object obj16 = null;
			}
			else
			{
				obj15 = 2139095039;
				obj9 = obj10;
				obj14 = obj8;
				obj13 = obj6;
				UnityEngine.Object obj16 = null;
			}
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj18 = !flag2;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = p.renderer != null;
			bool flag4 = !flag3;
			object obj19 = 0;
			UnityEngine.Object obj20 = null;
			if (flag4)
			{
				goto IL_03f6;
			}
			if ((object)p.renderer != null)
			{
				Transform[] bones = p.renderer.bones;
				if (bones != null)
				{
					bool flag5 = bones.Length < 1;
					obj19 = 0;
					obj20 = null;
					if (flag5)
					{
						goto IL_03f6;
					}
					object obj21 = bones.Length & 0xFFFFFFFFL;
					object obj22 = bones + 32;
					object obj23 = 0;
					object obj24 = obj9;
					object obj25 = obj14;
					object obj26 = obj13;
					object obj27 = 0;
					UnityEngine.Object obj28 = null;
					UnityEngine.Object obj29 = obj2;
					while (true)
					{
						bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21);
						object obj30 = !flag6;
						if (obj30 == null)
						{
							object obj31 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v26+E4]");
							bool flag7 = (nint)0 == 0;
							object obj32 = !flag7;
							if (obj32 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X25_v5+v71 @ X24_v6*8]");
							bool flag8 = (UnityEngine.Object)0 == null;
							bool flag9 = !flag8;
							object obj33 = !flag9;
							obj20 = null;
							if (obj33 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X25_v5+v71 @ X24_v6*8]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X25_v5+v71 @ X24_v6*8]");
								Vector3 position2 = ((Transform)0).position;
								object obj34 = obj26 - obj6;
								object obj35 = obj25 - obj8;
								obj24 -= obj10;
								object obj36 = obj34 * obj34;
								object obj37 = obj35 * obj35;
								object obj38 = obj36 + obj37;
								obj25 = obj24 * obj24;
								obj26 = obj25 + obj38;
								bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15);
								obj20 = null;
								if (!flag10)
								{
									obj15 = obj26;
									obj20 = null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X25_v5+v71 @ X24_v6*8]");
									obj29 = (UnityEngine.Object)0;
								}
							}
							obj21 = bones.Length;
							obj23++;
							bool flag11 = (nint)obj23 < bones.Length;
							obj9 = obj24;
							obj14 = obj25;
							obj13 = obj26;
							obj19 = 0;
							obj2 = obj29;
							obj27 = 0;
							obj28 = obj20;
							if (flag11)
							{
								continue;
							}
							goto IL_03f6;
						}
						IndexOutOfRangeException ex = new IndexOutOfRangeException();
						break;
					}
				}
			}
		}
		goto IL_04b4;
		IL_03f6:
		object obj39 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v14+E4]");
		bool flag12 = (nint)0 == 0;
		object obj40 = !flag12;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj2 != null)
		{
			return (Transform)obj2;
		}
		if ((object)p.renderer != null)
		{
			return p.renderer.transform;
		}
		goto IL_04b4;
		IL_04b4:
		return (Transform)(object)new NullReferenceException();
	}

	private Vector3 SprayDir(Part p)
	{
		//IL_035a: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I4
		//IL_039e: Expected Obj, but got I
		//IL_03b6: Expected Obj, but got I
		//IL_03bb: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I4
		//IL_03dd: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I4
		//IL_01c6: Expected I, but got Obj
		//IL_03fa: Expected Obj, but got I
		//IL_0424: Expected Obj, but got I4
		//IL_0214: Expected Obj, but got I
		//IL_023e: Expected I, but got Obj
		//IL_02d1: Expected Obj, but got I
		//IL_02e1: Expected Obj, but got I
		//IL_02b4: Expected Obj, but got I4
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected Obj, but got Unknown
		//IL_0449: Expected VT, but got Obj
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected Obj, but got Unknown
		//IL_0480: Expected Obj, but got I4
		Part part = Find((ApePart)0);
		object obj2;
		Transform joint;
		object obj10;
		object obj11;
		UnityEngine.Object obj12;
		if (p != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			obj2 = 0;
			bool flag = p.id == 0;
			UnityEngine.Object obj3 = null;
			if (!flag)
			{
				bool flag2 = part == null;
				obj3 = null;
				if (!flag2)
				{
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v48+E4]");
					bool flag3 = (nint)0 == 0;
					object obj5 = !flag3;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = part.joint == null;
					bool flag5 = !flag4;
					obj3 = null;
					if (flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD020]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD020]");
							Vector3 position = ((Transform)0).position;
							joint = part.joint;
							bool flag6 = (object)part.joint == null;
							nint num = unchecked((nint)null);
							if (!flag6)
							{
								goto IL_024c;
							}
						}
						goto IL_034c;
					}
				}
			}
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v36+E4]");
			bool flag7 = (nint)0 == 0;
			object obj7 = !flag7;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(p.jointOut != null))
			{
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v38+A0]");
				object obj9 = 0;
				obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v39+8]");
				obj11 = 0;
				nint num = unchecked((nint)null);
				obj12 = null;
				goto IL_03c5;
			}
			if ((object)p.jointOut != null)
			{
				Vector3 position2 = p.jointOut.position;
				joint = p.joint;
				bool flag8 = (object)p.joint == null;
				object obj13 = !flag8;
				nint num = unchecked((nint)null);
				if (obj13 != null)
				{
					goto IL_024c;
				}
			}
		}
		goto IL_034c;
		IL_034c:
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
		IL_024c:
		Vector3 position3 = joint.position;
		object obj14 = default;
		obj10 = obj14 - obj14;
		object obj15 = default;
		obj11 = obj15 - obj15;
		obj12 = null;
		goto IL_03c5;
		IL_03c5:
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v8+A0]");
		object obj17 = 0;
		object obj18 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj19 = 0;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v10+E4]");
		bool flag9 = (nint)0 == 0;
		object obj21 = !flag9;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj10;
		}
		object obj22 = obj18 * obj18;
		object obj23 = obj11 * obj11;
		object obj24 = obj22 + obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		object obj25;
		if ((nint)obj24 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			obj25 = obj11 / obj24;
			obj23 = 0;
		}
		else
		{
			object obj26 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v28+A0]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v29+8]");
			obj25 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj28 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		object obj29 = obj28 * 0;
		Vector3 result = (Vector3)obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v9+20]");
		object obj30 = 0 + obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v15 (UnityEngine.Vector3)+E4]");
		bool flag10 = (nint)0 == 0;
		object obj31 = !flag10;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj32 = obj30 * obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		if ((nint)obj32 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		}
		return result;
	}

	public unsafe void ResetAll()
	{
		//IL_0010: Expected Obj, but got I
		//IL_1011: Unknown result type (might be due to invalid IL or missing references)
		//IL_102b: Expected Obj, but got I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I4
		//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbc: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I4
		//IL_0be0: Expected Obj, but got I
		//IL_0bf0: Expected Obj, but got I
		//IL_0bf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1226: Expected Obj, but got I4
		//IL_122c: Unknown result type (might be due to invalid IL or missing references)
		//IL_123f: Expected Obj, but got I4
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d38: Expected Obj, but got I4
		//IL_0d46: Expected Obj, but got I4
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got I4
		//IL_12fb: Expected I4, but got Obj
		//IL_12fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1304: Expected Ref, but got Unknown
		//IL_131e: Expected Obj, but got I4
		//IL_0c24: Expected Obj, but got I
		//IL_0c46: Expected Obj, but got I4
		//IL_0d6a: Expected Obj, but got I4
		//IL_0d6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d72: Expected Obj, but got Unknown
		//IL_1059: Expected Obj, but got I
		//IL_105d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1076: Expected Obj, but got I
		//IL_1098: Expected Obj, but got I4
		//IL_0f1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caf: Expected Obj, but got I
		//IL_0cd1: Expected Obj, but got I4
		//IL_02a4: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got I4
		//IL_0dbf: Expected Obj, but got I4
		//IL_03b4: Expected Obj, but got I
		//IL_03d6: Expected Obj, but got I4
		//IL_12de: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1a: Expected Obj, but got I
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got I4
		//IL_0f83: Expected Obj, but got I4
		//IL_0f8c: Expected Obj, but got I4
		//IL_0a92: Expected Obj, but got I4
		//IL_0a9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Expected Obj, but got Unknown
		//IL_0feb: Expected Obj, but got I4
		//IL_0e67: Expected I4, but got Obj
		//IL_0e67: Expected Obj, but got I
		//IL_0e70: Expected Obj, but got I4
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got I4
		//IL_04ce: Expected Obj, but got Ref
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected Obj, but got Ref
		//IL_08d8: Expected Obj, but got I4
		//IL_04e4: Expected I, but got Obj
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fb: Expected Obj, but got Unknown
		//IL_052f: Expected Obj, but got I
		//IL_1255: Expected Obj, but got Ref
		//IL_125d: Expected I4, but got Obj
		//IL_126f: Expected Obj, but got Ref
		//IL_128e: Expected Obj, but got Ref
		//IL_1182: Unknown result type (might be due to invalid IL or missing references)
		//IL_1194: Expected Obj, but got Ref
		//IL_11ab: Expected Obj, but got I4
		//IL_11bc: Expected Obj, but got I4
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected Obj, but got Unknown
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected Obj, but got Unknown
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6f: Expected Obj, but got Ref
		//IL_0b7e: Expected Obj, but got I4
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Invalid comparison between Unknown and I4
		//IL_05ed: Expected I, but got Obj
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected Obj, but got I
		//IL_0638: Expected Obj, but got I
		//IL_09a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c4: Expected Obj, but got Unknown
		//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2a: Expected Obj, but got Ref
		//IL_0b39: Expected Obj, but got I4
		//IL_094f: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected Obj, but got Unknown
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_096a: Invalid comparison between Unknown and I4
		//IL_06df: Expected I4, but got Obj
		//IL_06e7: Expected I, but got Obj
		//IL_06f7: Expected Obj, but got I
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected Obj, but got I4
		//IL_0741: Expected Obj, but got I
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected Obj, but got Unknown
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected Obj, but got Unknown
		//IL_0ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae5: Expected Obj, but got Ref
		//IL_0af4: Expected Obj, but got I4
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected Obj, but got Unknown
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Invalid comparison between Unknown and I4
		//IL_076c: Expected Obj, but got I
		//IL_077c: Expected Obj, but got I
		//IL_07dd: Expected I4, but got Obj
		//IL_0880: Expected Obj, but got I4
		//IL_0810: Expected Obj, but got I
		//IL_0832: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD9C6]");
		Dismemberment dismemberment = (Dismemberment)0;
		Array array = sawnAgain;
		bool flag = sawnAgain == null;
		Enumerator<, > val = (Enumerator<, >)0;
		IEnumerator enumerator = null;
		IntPtr intPtr = default;
		int num = (int)(nint)intPtr;
		Dismemberment dismemberment2 = (Dismemberment)109891584;
		object obj2;
		object obj3;
		object obj4;
		object obj5;
		object obj6;
		Enumerator<, > val2;
		Dismemberment dismemberment3;
		object obj;
		int num2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2 (System.Array)+18]");
			num2 = 0;
			int[] array2 = sawnAgain;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2 (System.Array)+18]");
			Array.Clear(array2, 0, 0);
			Part[] array3 = parts;
			bool flag2 = parts == null;
			val = (Enumerator<, >)0;
			enumerator = null;
			dismemberment3 = this;
			obj = 0;
			num = 0;
			dismemberment2 = (Dismemberment)109891584;
			if (!flag2)
			{
				dismemberment = (Dismemberment)array3.Length;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				obj2 = 0;
				bool flag3 = array3.Length < 1;
				enumerator = null;
				num = 0;
				dismemberment2 = (Dismemberment)109891584;
				if (flag3)
				{
					goto IL_0b93;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4648]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D58]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D60]");
				object obj7 = 0;
				enumerator = null;
				object obj8 = 0;
				num = 0;
				dismemberment2 = (Dismemberment)109891584;
				while (true)
				{
					bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<Dismemberment, UIntPtr>(ref dismemberment);
					object obj9 = !flag4;
					val = (Enumerator<, >)0;
					dismemberment3 = this;
					obj = 0;
					if (obj9 != null)
					{
						break;
					}
					dismemberment = (Dismemberment)(object)((object)parts + obj8);
					dismemberment2 = (Dismemberment)(object)dismemberment.parts;
					bool flag5 = dismemberment.parts == null;
					val = (Enumerator<, >)0;
					dismemberment3 = this;
					obj = 0;
					if (!flag5)
					{
						dismemberment2.fleshMaterial = null;
						object obj10 = obj7;
						object obj11 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v30+A0]");
						object obj12 = 0;
						val2 = (Enumerator<, >)obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X0_v55+E4]");
						dismemberment = (Dismemberment)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X0_v55+E4]");
						bool flag6 = (nint)0 == 0;
						object obj13 = !flag6;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag7 = (UnityEngine.Object)(object)((MonoBehaviour)dismemberment2).m_CancellationTokenSource != null;
						bool flag8 = !flag7;
						bool flag9 = false;
						int num3 = 0;
						if (!flag8)
						{
							bool flag10 = ((MonoBehaviour)dismemberment2).m_CancellationTokenSource == null;
							val = (Enumerator<, >)0;
							dismemberment3 = this;
							obj = 0;
							num = 0;
							num2 = 0;
							if (flag10)
							{
								goto IL_0eca;
							}
							((Renderer)(object)((MonoBehaviour)dismemberment2).m_CancellationTokenSource).enabled = true;
							flag9 = true;
							num3 = 0;
						}
						object obj14 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X0_v60+E4]");
						dismemberment = (Dismemberment)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X0_v60+E4]");
						bool flag11 = (nint)0 == 0;
						object obj15 = !flag11;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag12 = dismemberment2.bloodMaterial != null;
						bool flag13 = !flag12;
						bool flag14 = false;
						int num4 = 0;
						if (!flag13)
						{
							bool flag15 = (object)dismemberment2.bloodMaterial == null;
							val = (Enumerator<, >)0;
							dismemberment3 = this;
							obj = 0;
							num = 0;
							num2 = 0;
							if (flag15)
							{
								goto IL_0eca;
							}
							((GameObject)(object)dismemberment2.bloodMaterial).SetActive(false);
							flag14 = false;
							num4 = 0;
						}
						object obj16 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v65+E4]");
						dismemberment = (Dismemberment)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v65+E4]");
						bool flag16 = (nint)0 == 0;
						object obj17 = !flag16;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag17 = (UnityEngine.Object)(object)dismemberment2.parts != null;
						bool flag18 = !flag17;
						num = 0;
						num2 = 0;
						if (!flag18)
						{
							goto IL_0435;
						}
						dismemberment = (Dismemberment)array3.Length;
						obj8++;
						if ((nint)obj8 < array3.Length)
						{
							continue;
						}
						goto IL_0b93;
					}
					goto IL_0eca;
				}
				goto IL_0ed8;
			}
		}
		goto IL_0eca;
		IL_0989:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		int num5 = 0;
		goto IL_11e6;
		IL_12f3:
		num = (int)dismemberment2;
		Enumerator<, > val3;
		((Enumerator<, >*)val3)->Dispose();
		Dismemberment dismemberment4;
		bool flag19 = (object)dismemberment4 == null;
		object obj18 = !flag19;
		object obj20;
		IndexOutOfRangeException ex2;
		IndexOutOfRangeException ex = default;
		if (obj18 == null)
		{
			bool flag20 = ex == null;
			object obj19 = !flag20;
			ex2 = (IndexOutOfRangeException)val3;
			dismemberment = (Dismemberment)(object)ex;
			if (obj19 == null)
			{
				if ((nint)obj20 != 11)
				{
					bool flag21 = obj20 == null;
					object obj21 = !flag21;
					if (obj21 != null)
					{
						return;
					}
				}
				dismemberment = (Dismemberment)(object)dismemberment3.pieces;
				bool flag22 = (object)dismemberment3.pieces == null;
				dismemberment2 = dismemberment3;
				if (!flag22)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X8_v60 (Dismemberment)+1C]");
					object obj22 = (nint)0 + (nint)1;
					((MonoBehaviour)dismemberment).m_CancellationTokenSource = null;
					if ((nint)((MonoBehaviour)dismemberment).m_CancellationTokenSource >= 1)
					{
						Array.Clear((Array)(nint)((UnityEngine.Object)dismemberment).m_CachedPtr, 0, (int)((MonoBehaviour)dismemberment).m_CancellationTokenSource);
						obj = 0;
						num = 0;
					}
					Action partsReset = dismemberment3.m_PartsReset;
					if (dismemberment3.m_PartsReset != null)
					{
						num = (int)(nint)((Delegate)partsReset).method;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v867.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
					dismemberment3.SetCaps();
					return;
				}
				goto IL_0eca;
			}
			goto IL_0ee6;
		}
		OutOfMemoryException ex3 = new OutOfMemoryException();
		goto IL_0f13;
		IL_0ee6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0ef5;
		IL_0ef5:
		throw new OutOfMemoryException();
		IL_0ac4:
		InvalidCastException ex4 = new InvalidCastException();
		val = (Enumerator<, >)0;
		ex = null;
		object obj23 = default;
		Dismemberment dismemberment5 = (Dismemberment)(&obj23);
		dismemberment3 = this;
		obj = 0;
		num2 = num5;
		ex3 = (OutOfMemoryException)(object)ex4;
		goto IL_0f13;
		IL_0b09:
		NullReferenceException ex5 = new NullReferenceException();
		val = (Enumerator<, >)0;
		ex = null;
		dismemberment5 = (Dismemberment)(&obj23);
		dismemberment3 = this;
		obj = 0;
		num2 = num5;
		ex3 = (OutOfMemoryException)(object)ex5;
		goto IL_0f13;
		IL_0ed8:
		ex2 = new IndexOutOfRangeException();
		goto IL_0ee6;
		IL_08a8:
		NullReferenceException ex6 = new NullReferenceException();
		val = (Enumerator<, >)0;
		ex = null;
		dismemberment5 = (Dismemberment)(&obj23);
		dismemberment3 = this;
		obj = 0;
		ex3 = (OutOfMemoryException)(object)ex6;
		goto IL_0f13;
		IL_0f13:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE48");
		Enumerator<, > val4 = default;
		val3 = val4;
		OutOfMemoryException ex7 = ex3;
		object obj24 = default;
		Enumerator<, > val5 = default;
		OutOfMemoryException ex8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			if (num == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex = (IndexOutOfRangeException)1;
				dismemberment = (Dismemberment)1;
				dismemberment4 = dismemberment5;
				break;
			}
			if (num == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				dismemberment4 = (Dismemberment)obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				dismemberment5 = (Dismemberment)obj24;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D0C4");
			val3 = val5;
			ex7 = ex8;
		}
		obj20 = 0;
		goto IL_12f3;
		IL_0b93:
		bool flag23 = (object)pieces == null;
		val = (Enumerator<, >)0;
		dismemberment3 = this;
		obj = 0;
		dismemberment = this;
		if (flag23)
		{
			goto IL_0eca;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4928]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4920]");
		dismemberment2 = (Dismemberment)0;
		Enumerator<, > enumerator2 = ((List<System.__Canon>)(object)pieces).GetEnumerator();
		dismemberment = (Dismemberment)(object)ex;
		while (val.MoveNext())
		{
			object obj26 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v44+E4]");
			dismemberment = (Dismemberment)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v44+E4]");
			bool flag24 = (nint)0 == 0;
			object obj27 = !flag24;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag25 = (UnityEngine.Object)(object)ex != null;
			bool flag26 = !flag25;
			num2 = 0;
			if (!flag26)
			{
				object obj28 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X0_v48+E4]");
				dismemberment = (Dismemberment)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X0_v48+E4]");
				bool flag27 = (nint)0 == 0;
				object obj29 = !flag27;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy((UnityEngine.Object)(object)ex);
				num2 = 0;
			}
		}
		Enumerator<, > val6 = default;
		val = val6;
		val2 = val6;
		Enumerator<, > val7 = (Enumerator<, >)(ref val);
		ex = null;
		dismemberment5 = null;
		val3 = (Enumerator<, >)(ref val);
		obj20 = 11;
		dismemberment3 = this;
		obj = 0;
		dismemberment4 = null;
		goto IL_12f3;
		IL_0eca:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_0ed8;
		IL_0b4e:
		NullReferenceException ex10 = new NullReferenceException();
		val = (Enumerator<, >)0;
		ex = null;
		dismemberment5 = (Dismemberment)(&obj23);
		dismemberment3 = this;
		obj = 0;
		num2 = num5;
		ex3 = (OutOfMemoryException)(object)ex10;
		goto IL_0f13;
		IL_0435:
		bool flag28 = dismemberment2.parts == null;
		val = (Enumerator<, >)0;
		dismemberment3 = this;
		obj = 0;
		num = 0;
		num2 = 0;
		if (flag28)
		{
			goto IL_0eca;
		}
		IEnumerator enumerator3 = ((Transform)(object)dismemberment2.parts).GetEnumerator();
		bool flag29 = enumerator3 == null;
		IEnumerator enumerator4 = enumerator3;
		num5 = 0;
		num = 0;
		num2 = 0;
		dismemberment = (Dismemberment)(&obj23);
		if (flag29)
		{
			goto IL_08a8;
		}
		object obj33 = default;
		object obj35 = default;
		object obj38 = default;
		UnityEngine.Object obj39 = default;
		object obj31;
		while (true)
		{
			nint num6 = (nint)enumerator4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v41 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			val7 = (Enumerator<, >)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v41 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0580;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v41 (Il2CppClass<System.Collections.IEnumerator>)+98]");
			object obj30 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ X10_v32-8]");
				if (0 == (nint)obj4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v41 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				val7 = (Enumerator<, >)(-1);
				obj31 = obj30 + 16;
				bool flag30 = (int)val7 != 1;
				obj30 = obj31;
				if (flag30)
				{
					continue;
				}
				goto IL_0580;
			}
			val7 = (Enumerator<, >)obj30;
			object obj32 = num6 + obj30;
			obj33 = obj32 + 312;
			obj31 = obj30;
			goto IL_10cb;
			IL_10cb:
			dismemberment = (Dismemberment)obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X0_v75+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1008 @ X0_v75] (should have been resolved before IL gen)");
			object obj34 = obj35 & 1;
			if (obj34 == null)
			{
				break;
			}
			if (enumerator3 == null)
			{
				goto IL_0b4e;
			}
			nint num7 = (nint)enumerator3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ X8_v52 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			val7 = (Enumerator<, >)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ X8_v52 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0689;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ X8_v52 (Il2CppClass<System.Collections.IEnumerator>)+98]");
			object obj36 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X10_v27-8]");
				if (0 == (nint)obj4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ X8_v52 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				val7 = (Enumerator<, >)(-1);
				obj31 = obj36 + 16;
				bool flag31 = (int)val7 != 1;
				obj36 = obj31;
				if (flag31)
				{
					continue;
				}
				goto IL_0689;
			}
			val7 = (Enumerator<, >)(obj36 + 1);
			object obj37 = num7 + val7;
			obj38 = obj37 + 312;
			obj31 = obj36;
			goto IL_113d;
			IL_113d:
			dismemberment = (Dismemberment)obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X0_v89+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1103 @ X0_v89] (should have been resolved before IL gen)");
			if ((object)obj39 != null)
			{
				num = (int)obj5;
				nint num8 = (nint)obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1137 @ X8_v55 (Il2CppClass<UnityEngine.Object>)+130]");
				obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X1_v4 (System.Int32)+130]");
				val7 = (Enumerator<, >)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1137 @ X8_v55 (Il2CppClass<UnityEngine.Object>)+130]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X1_v4 (System.Int32)+130]");
				bool flag32 = num9 < 0;
				object obj40 = !flag32;
				object obj41 = ~obj40;
				dismemberment = (Dismemberment)num8;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1137 @ X8_v55 (Il2CppClass<UnityEngine.Object>)+B0]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X1_v4 (System.Int32)+130]");
					object obj42 = num10 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ X8_v58-8]");
					dismemberment = (Dismemberment)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ X8_v58-8]");
					if ((nint)0 == num)
					{
						string text = obj39.name;
						bool flag33 = text == (string)obj6;
						bool flag34 = !flag33;
						num = (int)obj6;
						if (!flag34)
						{
							GameObject obj43 = ((Component)obj39).gameObject;
							object obj44 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1201 @ X0_v101+E4]");
							dismemberment = (Dismemberment)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1201 @ X0_v101+E4]");
							bool flag35 = (nint)0 == 0;
							object obj45 = !flag35;
							if (obj45 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							UnityEngine.Object.Destroy(obj43);
							num = 0;
						}
						bool flag36 = enumerator3 == null;
						object obj46 = !flag36;
						enumerator4 = enumerator3;
						num5 = 0;
						num2 = 0;
						if (obj46 != null)
						{
							continue;
						}
						goto IL_08a8;
					}
				}
				goto IL_0ac4;
			}
			goto IL_0b09;
			IL_0689:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num5 = 1;
			goto IL_113d;
			IL_0580:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num5 = 0;
			goto IL_10cb;
		}
		object obj47 = (object)(&enumerator);
		num = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		Dismemberment dismemberment6 = (Dismemberment)(&obj23);
		object obj48 = default;
		dismemberment6 = (Dismemberment)obj48;
		bool flag37 = obj48 == null;
		dismemberment = (Dismemberment)(&obj23);
		if (flag37)
		{
			goto IL_117c;
		}
		object obj49 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1074 @ X8_v48+12E]");
		val7 = (Enumerator<, >)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1074 @ X8_v48+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0989;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1074 @ X8_v48+98]");
		object obj50 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1149 @ X10_v20-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1074 @ X8_v48+12E]");
			val7 = (Enumerator<, >)(-1);
			obj31 = obj50 + 16;
			bool flag38 = (int)val7 != 1;
			obj50 = obj31;
			if (flag38)
			{
				continue;
			}
			goto IL_0989;
		}
		val7 = (Enumerator<, >)obj50;
		object obj51 = obj49 + obj50;
		object obj52 = obj51 + 312;
		obj31 = obj50;
		goto IL_11e6;
		IL_117c:
		val = (Enumerator<, >)0;
		ex = null;
		dismemberment5 = (Dismemberment)(&obj23);
		enumerator = enumerator3;
		dismemberment3 = this;
		obj = 0;
		num2 = num5;
		dismemberment2 = (Dismemberment)6;
		goto IL_0ef5;
		IL_11e6:
		dismemberment = (Dismemberment)obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1179 @ X0_v82+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1179 @ X0_v82] (should have been resolved before IL gen)");
		goto IL_117c;
	}

	public void Take(GameObject piece)
	{
		bool flag = ((List<System.__Canon>)(object)pieces).Remove((System.__Canon)(object)piece);
	}

	public List<GameObject> TakePieces()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector((IEnumerable<System.__Canon>)pieces);
		List<GameObject> list2 = pieces;
		if ((object)pieces != null)
		{
			int version = list2._version + 1;
			list2._size = 0;
			list2._version = version;
			if (list2._size >= 1)
			{
				Array.Clear(list2._items, 0, list2._size);
			}
			return (List<GameObject>)(object)list;
		}
		return (List<GameObject>)(object)new NullReferenceException();
	}

	public Part Find(ApePart id)
	{
		//IL_0033: Expected Obj, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		Part[] array = parts;
		Part part;
		if (parts != null)
		{
			object obj = array.Length;
			if (array.Length >= 1)
			{
				object obj2 = parts + 32;
				while (true)
				{
					part = (Part)obj2;
					if (obj2 != null)
					{
						if (part.id == id)
						{
							break;
						}
						obj--;
						obj2 += 8;
						if ((nint)obj != 1)
						{
							continue;
						}
						goto IL_00c4;
					}
					return (Part)(object)new NullReferenceException();
				}
				goto IL_00dc;
			}
		}
		goto IL_00c4;
		IL_00dc:
		return part;
		IL_00c4:
		part = null;
		goto IL_00dc;
	}

	private unsafe GameObject SpawnPiece(Part p, Vector3 impulse)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_1aa7: Expected Obj, but got I
		//IL_1abf: Expected Obj, but got Ref
		//IL_1af3: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got Ref
		//IL_00a4: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I
		//IL_02b2: Expected Obj, but got Ref
		//IL_026f: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I
		//IL_0777: Expected Obj, but got I
		//IL_07ab: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I4
		//IL_07ed: Expected VT, but got Obj
		//IL_07f6: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got I4
		//IL_01ba: Expected VT, but got I4
		//IL_01c6: Expected I, but got Obj
		//IL_01e6: Expected F4, but got Obj
		//IL_0998: Expected Obj, but got I
		//IL_09c2: Expected Obj, but got I4
		//IL_0346: Expected Obj, but got Ref
		//IL_0370: Expected Obj, but got I
		//IL_1b80: Expected Obj, but got I4
		//IL_1cc0: Expected Obj, but got I
		//IL_1ce2: Expected Obj, but got I4
		//IL_0836: Expected Obj, but got I
		//IL_0a30: Expected Obj, but got I4
		//IL_0be4: Expected Obj, but got I4
		//IL_0884: Expected VT, but got Obj
		//IL_088d: Expected Obj, but got I4
		//IL_0c0b: Expected Obj, but got VT
		//IL_08b5: Expected Obj, but got I8
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Expected Obj, but got Unknown
		//IL_08cc: Expected Obj, but got I4
		//IL_08d5: Expected Obj, but got I4
		//IL_0c35: Invalid comparison between VT and I4
		//IL_0a70: Expected Obj, but got I
		//IL_1b48: Expected Obj, but got I4
		//IL_0c8b: Expected Obj, but got I
		//IL_0c59: Expected Obj, but got I
		//IL_0abf: Expected Obj, but got I4
		//IL_0904: Expected Obj, but got I4
		//IL_0936: Expected Obj, but got I
		//IL_0946: Expected Obj, but got I
		//IL_094f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Expected Obj, but got Unknown
		//IL_0972: Expected Obj, but got Ref
		//IL_097a: Expected Obj, but got Ref
		//IL_0cab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb0: Expected Obj, but got Unknown
		//IL_0cff: Expected Obj, but got I4
		//IL_0ae7: Expected Obj, but got I8
		//IL_0af0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Expected Obj, but got Unknown
		//IL_0afe: Expected Obj, but got I4
		//IL_0b07: Expected Obj, but got I4
		//IL_0468: Expected VT, but got I4
		//IL_0468: Expected VT, but got I4
		//IL_0478: Expected Obj, but got I
		//IL_0d26: Expected Obj, but got VT
		//IL_1ba7: Expected Obj, but got I4
		//IL_0d57: Expected Obj, but got I
		//IL_0d71: Expected Obj, but got I
		//IL_0d82: Expected I, but got Obj
		//IL_0b36: Expected Obj, but got I4
		//IL_04c1: Expected Obj, but got I
		//IL_0d90: Invalid comparison between VT and I4
		//IL_0b68: Expected Obj, but got I
		//IL_0b78: Expected Obj, but got I
		//IL_0b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected Obj, but got Unknown
		//IL_0ba4: Expected Obj, but got Ref
		//IL_0bac: Expected Obj, but got Ref
		//IL_04fa: Expected Obj, but got I4
		//IL_0e22: Expected Obj, but got I4
		//IL_0e59: Expected Obj, but got I4
		//IL_0db1: Expected Obj, but got VT
		//IL_0db6: Expected I, but got Obj
		//IL_0dbf: Expected Obj, but got I4
		//IL_0eae: Expected VT, but got I4
		//IL_0563: Expected Obj, but got I
		//IL_17e9: Expected Obj, but got I4
		//IL_0580: Expected Obj, but got Ref
		//IL_1810: Expected Obj, but got VT
		//IL_0ee6: Expected Obj, but got I4
		//IL_0f4e: Expected Obj, but got I4
		//IL_183a: Invalid comparison between VT and I4
		//IL_139c: Expected Obj, but got I4
		//IL_05c7: Expected VT, but got I4
		//IL_140e: Expected VT, but got I4
		//IL_1857: Expected Obj, but got VT
		//IL_18c5: Expected Obj, but got I
		//IL_18ef: Expected Obj, but got I4
		//IL_142c: Expected Obj, but got I
		//IL_1446: Expected Obj, but got I
		//IL_060e: Expected VT, but got I4
		//IL_191d: Expected VT, but got Ref
		//IL_1932: Expected F4, but got Obj
		//IL_0631: Expected Obj, but got I
		//IL_19d9: Expected Obj, but got I4
		//IL_19f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fe: Expected Obj, but got Unknown
		//IL_1a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2c: Expected Obj, but got Unknown
		//IL_06af: Expected VT, but got I4
		//IL_0707: Expected VT, but got I4
		//IL_0714: Expected I, but got Obj
		//IL_0752: Expected Obj, but got I4
		//IL_1075: Expected Obj, but got I4
		//IL_151d: Expected VT, but got I4
		//IL_10a2: Expected Obj, but got I
		//IL_154c: Expected Obj, but got I4
		//IL_1c56: Expected Obj, but got I
		//IL_1c6e: Expected Obj, but got I
		//IL_1c7e: Expected F4, but got I
		//IL_1c8e: Expected F4, but got I
		//IL_1c9e: Expected F4, but got I
		//IL_1c0e: Expected Obj, but got I
		//IL_1c38: Expected Obj, but got I4
		//IL_176c: Expected Obj, but got I4
		//IL_176c: Expected VT, but got Obj
		//IL_17b0: Expected Obj, but got I4
		//IL_17ba: Expected VT, but got Obj
		//IL_1d1e: Expected Obj, but got I
		//IL_1d57: Expected Obj, but got I4
		//IL_1670: Expected F4, but got I
		//IL_168a: Invalid comparison between F4 and I
		//IL_16ed: Expected Obj, but got I
		//IL_1705: Expected Obj, but got I
		//IL_170d: Expected F4, but got Obj
		//IL_171d: Expected F4, but got I
		//IL_172d: Expected F4, but got I
		//IL_11db: Expected VT, but got I4
		//IL_11eb: Expected Obj, but got I
		//IL_122f: Expected Obj, but got I
		//IL_1286: Unknown result type (might be due to invalid IL or missing references)
		//IL_128b: Expected Obj, but got Unknown
		//IL_1294: Expected Obj, but got I4
		//IL_1beb: Expected Obj, but got I4
		//IL_12cf: Expected Obj, but got I
		//IL_130e: Expected Obj, but got I
		//IL_1317: Unknown result type (might be due to invalid IL or missing references)
		//IL_131c: Expected Obj, but got Unknown
		//IL_135b: Expected Obj, but got I4
		object obj;
		object obj3;
		nint num2 = default;
		TornArm tornArm2;
		object obj10;
		GillaAtmosphere._003C_003Ec__DisplayClass43_0 obj12 = default;
		Renderer renderer;
		Rigidbody rigidbody;
		GameObject gameObject2;
		double num5;
		double num4 = default;
		float num6 = default;
		double num7 = default;
		if (p != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DC8]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E48]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D18]");
			obj3 = 0;
			float num = default;
			double num8 = default;
			if (p.id != 0)
			{
				string text = ((Enum)(&num)).ToString();
				string text2 = (string)obj2 + text;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v126+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Material[] array = WithCaps(p.renderer);
				Transform transform = base.transform;
				if ((object)transform == null)
				{
					goto IL_1a5e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E30]");
				object obj6 = 0;
				Vector3 forward = transform.forward;
				Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X0_v250+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj9 = p.id - 1;
				bool left = obj9 == null;
				Vector3 going = default;
				Vector3 spin = default;
				TornArm tornArm = TornArm.Make(p.renderer, text2, left, array, (Vector3)0, going, spin);
				num2 = (nint)array;
				double num3 = num4;
				num5 = num6;
				num7 = num8;
				num = (float)obj;
				tornArm2 = tornArm;
			}
			else
			{
				tornArm2 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj11 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj12, 8));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj13 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v888 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (tornArm2 != null)
			{
				if ((object)tornArm2 != null)
				{
					GameObject gameObject = tornArm2.gameObject;
					renderer = null;
					object obj15 = 0;
					rigidbody = null;
					gameObject2 = gameObject;
					goto IL_0767;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Mesh mesh = default;
				mesh._002Ector();
				string text3 = ((Enum)(&num)).ToString();
				string text4 = (string)obj2 + text3;
				if ((object)mesh != null)
				{
					mesh.name = text4;
					if ((object)p.renderer != null)
					{
						p.renderer.BakeMesh(mesh, useScale: false);
						mesh.RecalculateBounds();
						object obj17 = default;
						string text5 = ((Enum)(&obj17)).ToString();
						string text6 = (string)obj2 + text5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						GameObject gameObject3 = default;
						gameObject3._002Ector(text6);
						if ((object)gameObject3 != null)
						{
							Transform transform2 = gameObject3.transform;
							Transform transform3 = p.renderer.transform;
							if ((object)transform3 != null)
							{
								Vector3 position = transform3.position;
								Transform transform4 = p.renderer.transform;
								if ((object)transform4 != null)
								{
									Quaternion rotation = transform4.rotation;
									if ((object)transform2 != null)
									{
										transform2.SetPositionAndRotation((Vector3)0, (Quaternion)0);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF0]");
										object obj19 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
										MeshFilter meshFilter = default;
										if ((object)meshFilter != null)
										{
											meshFilter.sharedMesh = mesh;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF8]");
											object obj20 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
											object obj21 = obj3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v114+E4]");
											bool flag4 = (nint)0 == 0;
											object obj22 = !flag4;
											if (obj22 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Material[] sharedMaterials = WithCaps(p.renderer);
											Renderer renderer2 = default;
											if ((object)renderer2 != null)
											{
												renderer2.sharedMaterials = sharedMaterials;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DE8]");
												object obj23 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
												object obj24 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj12, 8));
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Bounds bounds = mesh.bounds;
												BoxCollider boxCollider = default;
												if ((object)boxCollider != null)
												{
													boxCollider.center = (Vector3)0;
													Bounds bounds2 = mesh.bounds;
													if ((object)boxCollider != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
														boxCollider.size = (Vector3)0;
														gameObject3.layer = 2;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E00]");
														object obj25 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
														Rigidbody rigidbody2 = default;
														if ((object)rigidbody2 != null)
														{
															float mass = ((p.id != 0) ? 2f : 3f);
															rigidbody2.mass = mass;
															rigidbody2.interpolation = (RigidbodyInterpolation)1;
															rigidbody2.collisionDetectionMode = (CollisionDetectionMode)2;
															rigidbody2.linearVelocity = (Vector3)0;
															Vector3 insideUnitSphere2 = UnityEngine.Random.insideUnitSphere;
															num8 *= 7.0;
															double num9 = (double)num6 * 7.0;
															double num10 = num4 * 7.0;
															rigidbody2.angularVelocity = (Vector3)0;
															double num11 = num7;
															num2 = unchecked((nint)null);
															double num3 = num4;
															num5 = num6;
															num4 = num10;
															num6 = (float)num9;
															num7 = 7.0;
															renderer = renderer2;
															object obj15 = 0;
															rigidbody = rigidbody2;
															gameObject2 = gameObject3;
															goto IL_0767;
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
		goto IL_1a5e;
		IL_1bfe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
		object obj26 = 0;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1536 @ X0_v93+E4]");
		bool flag5 = (nint)0 == 0;
		object obj28 = !flag5;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform transform5;
		float num12;
		float num13;
		Blood.Spray(transform5, (Vector3)bloodMaterial, (Material)45, num12, 3, 0, num13);
		int num14 = 3;
		num5 = 1.0;
		float num15;
		num4 = num15;
		num6 = num13;
		float num16 = num12;
		num7 = 2.0;
		Material material = (Material)45;
		Vector3 vector = (Vector3)bloodMaterial;
		goto IL_17bf;
		IL_193f:
		List<System.__Canon> list = (List<System.__Canon>)(object)pieces;
		if ((object)pieces != null)
		{
			System.__Canon[] items = list._items;
			int version = list._version + 1;
			list._version = version;
			if (list._items != null)
			{
				bool flag6 = list._size < items.Length;
				object obj29 = !flag6;
				if (obj29 == null)
				{
					object obj30 = list._items + list._size;
					int size = list._size + 1;
					list._size = size;
					object obj31 = obj30 + 32;
					obj31 = gameObject2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				else
				{
					((List<System.__Canon>)(object)pieces).AddWithResize((System.__Canon)(object)gameObject2);
				}
				return gameObject2;
			}
		}
		goto IL_1a5e;
		IL_1a6c:
		return (GameObject)(object)new IndexOutOfRangeException();
		IL_0e2f:
		object obj32 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1242 @ X0_v43+E4]");
		bool flag7 = (nint)0 == 0;
		object obj33 = !flag7;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = p.joint != null;
		bool flag9 = !flag8;
		num14 = (int)num2;
		material = null;
		vector = (Vector3)0;
		if (flag9)
		{
			goto IL_17bf;
		}
		object obj34 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1261 @ X0_v69+E4]");
		bool flag10 = (nint)0 == 0;
		object obj35 = !flag10;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = p.stump != null;
		bool flag12 = !flag11;
		double num17 = num4;
		float num18 = num6;
		float num19 = num16;
		double num20 = num7;
		object obj36 = 0;
		int num21 = 0;
		if (flag12)
		{
			goto IL_1372;
		}
		if ((object)p.stump != null)
		{
			Transform transform6 = p.stump.transform;
			if ((object)transform6 != null)
			{
				Vector3 position2 = transform6.position;
				if ((object)p.stump != null)
				{
					Transform transform7 = p.stump.transform;
					if ((object)transform7 != null)
					{
						Quaternion rotation2 = transform7.rotation;
						if ((object)gameObject2 != null)
						{
							Transform transform8 = gameObject2.transform;
							object obj37 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1443 @ X8_v71+E4]");
							bool flag13 = (nint)0 == 0;
							object obj38 = !flag13;
							if (obj38 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E20]");
							object obj39 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDDA0");
							GameObject gameObject4 = default;
							if ((object)gameObject4 != null)
							{
								gameObject4.SetActive(value: true);
								if ((object)p.stump != null)
								{
									Transform transform9 = p.stump.transform;
									if ((object)transform9 != null)
									{
										Vector3 lossyScale = transform9.lossyScale;
										Transform transform10 = gameObject2.transform;
										if ((object)transform10 != null)
										{
											Vector3 lossyScale2 = transform10.lossyScale;
											Transform transform11 = gameObject4.transform;
											if ((object)transform11 != null)
											{
												num17 = num4 / num4;
												num18 = num6 / num6;
												num19 = num16 / num16;
												transform11.localScale = (Vector3)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B28]");
												object obj40 = 0;
												obj36 = obj40;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
												object obj41 = default;
												if (obj41 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v138+18]");
													object obj42 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v138+18]");
													bool flag14 = (nint)0 < (nint)1;
													double num11 = num7;
													double num3 = num4;
													num5 = num6;
													num20 = num16;
													num21 = 1;
													if (flag14)
													{
														goto IL_1372;
													}
													object obj43 = obj41 + 32;
													object obj44 = 0;
													while (true)
													{
														bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj42);
														object obj45 = !flag15;
														if (obj45 != null)
														{
															break;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X26_v9+v329 @ X25_v18*8]");
														if ((nint)0 != 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X26_v9+v329 @ X25_v18*8]");
															GameObject gameObject5 = ((Component)0).gameObject;
															if ((object)gameObject5 != null)
															{
																gameObject5.layer = 2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v138+18]");
																obj42 = 0;
																obj44++;
																object obj46 = obj44;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v138+18]");
																bool flag16 = (nint)obj46 < 0;
																num11 = num7;
																num3 = num4;
																num5 = num6;
																num20 = num16;
																obj36 = 0;
																num21 = 2;
																if (flag16)
																{
																	continue;
																}
																goto IL_1372;
															}
														}
														goto IL_1a5e;
													}
													goto IL_1a6c;
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
		goto IL_1a5e;
		IL_17bf:
		object obj47 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1304 @ X0_v48+E4]");
		bool flag17 = (nint)0 == 0;
		object obj48 = !flag17;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj12 != null)
		{
			if (obj12 != (GillaAtmosphere._003C_003Ec__DisplayClass43_0)(object)0)
			{
				((TornArm)obj12).OutOfDoors();
				Rigidbody rigidbody3 = null;
				goto IL_193f;
			}
		}
		else if ((object)gameObject2 != null)
		{
			Transform thing = gameObject2.transform;
			if ((object)renderer != null)
			{
				Bounds bounds3 = renderer.bounds;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
				object obj49 = 0;
				object obj50 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1399 @ X0_v62+E4]");
				bool flag18 = (nint)0 == 0;
				object obj51 = !flag18;
				if (obj51 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj52 = default;
				bool flag19 = GillaDoor.OutOfSlabs(thing, (Bounds)(&obj52), rigidbody);
				num14 = 0;
				num16 = (float)obj;
				Rigidbody rigidbody3 = rigidbody;
				goto IL_193f;
			}
		}
		goto IL_1a5e;
		IL_1372:
		object obj53 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1356 @ X0_v74+E4]");
		bool flag20 = (nint)0 == 0;
		object obj54 = !flag20;
		if (obj54 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag21 = bloodMaterial != null;
		bool flag22 = !flag21;
		num14 = (int)num2;
		num4 = num17;
		num6 = num18;
		num16 = num19;
		num7 = num20;
		material = null;
		vector = (Vector3)0;
		if (flag22)
		{
			goto IL_17bf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E40]");
		object obj56 = 0;
		GameObject gameObject6 = default;
		gameObject6._002Ector((string)obj56);
		if ((object)gameObject6 != null)
		{
			transform5 = gameObject6.transform;
			if ((object)gameObject2 != null)
			{
				Transform parent = gameObject2.transform;
				if ((object)transform5 != null)
				{
					transform5.SetParent(parent, worldPositionStays: false);
					if ((object)p.joint != null)
					{
						Vector3 position3 = p.joint.position;
						transform5.position = (Vector3)0;
						object obj57 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1464 @ X0_v88+E4]");
						bool flag23 = (nint)0 == 0;
						object obj58 = !flag23;
						if (obj58 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (!(p.jointOut != null))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
							object obj59 = 0;
							object obj60 = obj59;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X8_v54+A0]");
							object obj61 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ X8_v55+24]");
							num12 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ X8_v55+28]");
							num13 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ X8_v55+2C]");
							num15 = 0f;
							UnityEngine.Object obj62 = null;
							goto IL_1bfe;
						}
						if ((object)p.joint != null)
						{
							Vector3 position4 = p.joint.position;
							if ((object)p.jointOut != null)
							{
								Vector3 position5 = p.jointOut.position;
								float num22 = num19 - num19;
								float num23 = num18 - num18;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
								object obj63 = 0;
								double num24 = num17 - num17;
								object obj64 = obj63;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1572 @ X0_v107+E4]");
								bool flag24 = (nint)0 == 0;
								object obj65 = !flag24;
								if (obj65 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								float num25 = num22 * num22;
								float num26 = num23 * num23;
								float num27 = num25 + num26;
								double num28 = num24 * num24;
								num19 = (float)num28 + num27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
								num18 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								float num29 = num19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
								if (num29 > 0f)
								{
									num12 = num22 / num19;
									num13 = num23 / num19;
									num15 = (float)num24 / num19;
									UnityEngine.Object obj62 = null;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
									object obj66 = 0;
									object obj67 = obj66;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1587 @ X8_v67+A0]");
									object obj68 = 0;
									num12 = (float)obj68;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1528 @ X8_v68+4]");
									num13 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1528 @ X8_v68+8]");
									num15 = 0f;
									UnityEngine.Object obj62 = null;
								}
								goto IL_1bfe;
							}
						}
					}
				}
			}
		}
		goto IL_1a5e;
		IL_0767:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DD0]");
		object obj69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
		object obj70 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v11+E4]");
		bool flag25 = (nint)0 == 0;
		object obj71 = !flag25;
		if (obj71 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj72 = default;
		bool flag26 = obj72 != null;
		bool flag27 = !flag26;
		obj12 = (GillaAtmosphere._003C_003Ec__DisplayClass43_0)tornArm2;
		object obj73 = 0;
		UnityEngine.Object obj74 = null;
		if (flag27)
		{
			goto IL_0988;
		}
		if ((object)obj72 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DD8]");
			object obj75 = 0;
			obj73 = obj75;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
			object obj76 = default;
			if (obj76 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v174+18]");
				bool flag28 = (nint)0 < (nint)1;
				obj12 = (GillaAtmosphere._003C_003Ec__DisplayClass43_0)tornArm2;
				obj74 = (UnityEngine.Object)1;
				if (flag28)
				{
					goto IL_0988;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v174+18]");
				object obj77 = 0 & 0xFFFFFFFFL;
				object obj78 = obj76 + 32;
				UnityEngine.Object obj79 = (UnityEngine.Object)1;
				object obj80 = 0;
				while (true)
				{
					bool flag29 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj80) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj77);
					object obj81 = !flag29;
					if (obj81 != null)
					{
						break;
					}
					object obj82 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1109 @ X0_v176+E4]");
					bool flag30 = (nint)0 == 0;
					object obj83 = !flag30;
					if (obj83 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X29_v9+v705 @ X28_v12*8]");
					_003CSpawnPiece_003Eg__Clear_007C43_0((Collider)0, ref obj12);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v174+18]");
					obj77 = 0;
					obj80++;
					object obj84 = obj80;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v174+18]");
					bool flag31 = (nint)obj84 < 0;
					obj74 = (UnityEngine.Object)(&obj12);
					obj79 = (UnityEngine.Object)(&obj12);
					if (flag31)
					{
						continue;
					}
					goto IL_0988;
				}
				goto IL_1a6c;
			}
		}
		goto IL_1a5e;
		IL_1a5e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1a6c;
		IL_0bba:
		object obj85 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1144 @ X0_v31+E4]");
		bool flag32 = (nint)0 == 0;
		object obj86 = !flag32;
		if (obj86 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj87;
		if ((UnityEngine.Object)obj12 != null)
		{
			if (obj12 == (GillaAtmosphere._003C_003Ec__DisplayClass43_0)(object)0)
			{
				goto IL_1a5e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ stack_-B0_v5 (GillaAtmosphere+<>c__DisplayClass43_0)+98]");
			obj87 = 0;
		}
		else
		{
			if ((object)gameObject2 == null)
			{
				goto IL_1a5e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E08]");
			object obj88 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			object obj89 = default;
			obj87 = obj89;
		}
		if (obj87 != null)
		{
			object obj90 = obj87 + 32;
			obj90 = dropSounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num16 = pieceLifetime;
			object obj91 = obj10;
			_ = pieceLifetime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ X0_v38+E4]");
			bool flag33 = (nint)0 == 0;
			object obj92 = !flag33;
			if (obj92 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DE0]");
				object obj93 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E38]");
				object obj94 = 0;
				Func<System.__Canon, System.__Canon> func = default;
				func._002Ector(obj87, (IntPtr)obj94);
				if (obj12 != (GillaAtmosphere._003C_003Ec__DisplayClass43_0)(object)0)
				{
					((TornArm)obj12).CopyMaterials((Func<Material[], Material[]>)(object)func);
					num2 = unchecked((nint)null);
					object obj95 = 0;
					Material[] array2 = (Material[])(object)func;
					goto IL_0e2f;
				}
			}
			else if ((object)renderer != null)
			{
				Material[] sharedMaterials2 = renderer.sharedMaterials;
				Material[] array3 = (renderer.sharedMaterials = ((TornPiece)obj87).Own(sharedMaterials2));
				object obj95 = 0;
				Material[] array2 = array3;
				goto IL_0e2f;
			}
		}
		goto IL_1a5e;
		IL_0988:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj96 = 0;
		object obj97 = obj96;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X0_v22+E4]");
		bool flag34 = (nint)0 == 0;
		object obj98 = !flag34;
		if (obj98 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj99 = obj96;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X0_v26+E4]");
		bool flag35 = (nint)0 == 0;
		object obj100 = !flag35;
		if (obj100 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj99 = obj96;
		}
		object obj101 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X0_v26+A0]");
		object obj102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v17+E4]");
		bool flag36 = (nint)0 == 0;
		object obj103 = !flag36;
		if (obj103 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag37 = (UnityEngine.Object)obj102 != null;
		bool flag38 = !flag37;
		object obj104 = 0;
		UnityEngine.Object obj105 = null;
		if (flag38)
		{
			goto IL_0bba;
		}
		if (obj102 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DD8]");
			object obj106 = 0;
			obj104 = obj106;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
			object obj107 = default;
			if (obj107 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v159+18]");
				bool flag39 = (nint)0 < (nint)1;
				obj105 = (UnityEngine.Object)1;
				if (flag39)
				{
					goto IL_0bba;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v159+18]");
				object obj108 = 0 & 0xFFFFFFFFL;
				object obj109 = obj107 + 32;
				UnityEngine.Object obj110 = (UnityEngine.Object)1;
				object obj111 = 0;
				while (true)
				{
					bool flag40 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj111) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj108);
					object obj112 = !flag40;
					if (obj112 != null)
					{
						break;
					}
					object obj113 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1188 @ X0_v161+E4]");
					bool flag41 = (nint)0 == 0;
					object obj114 = !flag41;
					if (obj114 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X29_v8+v706 @ X28_v9*8]");
					_003CSpawnPiece_003Eg__Clear_007C43_0((Collider)0, ref obj12);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v159+18]");
					obj108 = 0;
					obj111++;
					object obj115 = obj111;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v159+18]");
					bool flag42 = (nint)obj115 < 0;
					obj105 = (UnityEngine.Object)(&obj12);
					obj110 = (UnityEngine.Object)(&obj12);
					if (flag42)
					{
						continue;
					}
					goto IL_0bba;
				}
				goto IL_1a6c;
			}
		}
		goto IL_1a5e;
	}

	public Dismemberment()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00a5: Expected I4, but got I8
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48C0]");
		object obj2 = 0;
		spawnPieces = true;
		tearVolume = 1f;
		bleedSeconds = 4f;
		pieceLifetime = 45f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C5D8]");
		bleedPulses = 0;
		pieceOwner = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = this + 112;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj5 = this + 120;
		obj5 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static Dismemberment()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I
		//IL_01cd: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E80]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D18]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E88]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E90]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E98]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EA0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EA8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EB0]");
		object obj8 = 0;
		IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker((string)obj, 1, (MarkerFlags)0, 0);
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3+A0]");
		object obj10 = 0;
		obj10 = (nint)intPtr;
		IntPtr intPtr2 = ProfilerUnsafeUtility.CreateMarker((string)obj3, 1, (MarkerFlags)0, 0);
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v5+A0]");
		object obj12 = 0;
		IntPtr intPtr3 = ProfilerUnsafeUtility.CreateMarker((string)obj4, 1, (MarkerFlags)0, 0);
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v7+A0]");
		object obj14 = 0;
		IntPtr intPtr4 = ProfilerUnsafeUtility.CreateMarker((string)obj5, 1, (MarkerFlags)0, 0);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v9+A0]");
		object obj16 = 0;
		IntPtr intPtr5 = ProfilerUnsafeUtility.CreateMarker((string)obj6, 1, (MarkerFlags)0, 0);
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v11+A0]");
		object obj18 = 0;
		IntPtr intPtr6 = ProfilerUnsafeUtility.CreateMarker((string)obj7, 1, (MarkerFlags)0, 0);
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v13+A0]");
		object obj20 = 0;
		IntPtr intPtr7 = ProfilerUnsafeUtility.CreateMarker((string)obj8, 1, (MarkerFlags)0, 0);
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v15+A0]");
		object obj22 = 0;
	}

	internal static void _003CSpawnPiece_003Eg__Clear_007C43_0(Collider c, ref GillaAtmosphere._003C_003Ec__DisplayClass43_0 P_1)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I4
		//IL_0033: Expected Obj, but got VT
		//IL_0077: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I
		//IL_0066: Expected Obj, but got VT
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
		if ((UnityEngine.Object)P_1 != null)
		{
			((TornArm)P_1).Ignore(c);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass43_0&)+8]");
		Physics.IgnoreCollision((Collider)0, c);
	}
}
