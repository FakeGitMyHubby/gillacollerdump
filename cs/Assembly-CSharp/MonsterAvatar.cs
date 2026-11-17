using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR;

public class MonsterAvatar : MonoBehaviour
{
	private sealed class _003CPressable_003Ed__249 : _0021_00211, _0021_00210, _0021_00211, _0021_00210, _0021_00211
	{
		private int _003C_003E1__state;

		private ModMenu.Hit _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public ModMenu _003C_003E4__this;

		private Enumerator<, > _003C_003E7__wrap1;

		private ModMenu.Hit System_002ECollections_002EGeneric_002EIEnumerator_003CModMenu_002EHit_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CPressable_003Ed__249(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			_003C_003El__initialThreadId = currentManagedThreadId;
		}

		private void System_002EIDisposable_002EDispose()
		{
			//IL_002f: Expected Obj, but got I4
			//IL_0049: Expected Obj, but got I4
			if (_003C_003E1__state != 4)
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
			//IL_01a3: Expected I4, but got I8
			//IL_0115: Expected I4, but got I8
			//IL_0131: Expected Obj, but got I4
			//IL_01cf: Expected I, but got Obj
			//IL_02a3: Expected I, but got Obj
			//IL_023c: Expected I, but got Obj
			//IL_00ce: Expected I4, but got I8
			//IL_00ea: Expected Obj, but got I4
			//IL_015c: Expected I4, but got I8
			//IL_0178: Expected Obj, but got I4
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Expected Obj, but got Unknown
			//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d0: Expected Obj, but got Unknown
			//IL_0264: Unknown result type (might be due to invalid IL or missing references)
			//IL_0269: Expected Obj, but got Unknown
			//IL_0329: Unknown result type (might be due to invalid IL or missing references)
			//IL_032e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0336: Unknown result type (might be due to invalid IL or missing references)
			//IL_033a: Unknown result type (might be due to invalid IL or missing references)
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Expected Obj, but got Unknown
			//IL_053d: Expected I4, but got I8
			//IL_054d: Expected Obj, but got I
			//IL_057a: Expected I, but got Obj
			//IL_0583: Unknown result type (might be due to invalid IL or missing references)
			//IL_0584: Unknown result type (might be due to invalid IL or missing references)
			//IL_0588: Unknown result type (might be due to invalid IL or missing references)
			//IL_0591: Expected Ref, but got Unknown
			//IL_042c: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03de: Expected Obj, but got Unknown
			//IL_03ee: Expected Obj, but got I
			ModMenu modMenu = _003C_003E4__this;
			_003CPressable_003Ed__249 obj;
			bool flag2;
			if (_003C_003E1__state > 1)
			{
				if (_003C_003E1__state == 2)
				{
					goto IL_0106;
				}
				if (_003C_003E1__state == 3)
				{
					goto IL_014d;
				}
				bool flag = _003C_003E1__state == 4;
				obj = this;
				if (flag)
				{
					goto IL_052b;
				}
				flag2 = false;
			}
			else
			{
				if (_003C_003E1__state == 0)
				{
					goto IL_0194;
				}
				bool flag3 = _003C_003E1__state != 1;
				flag2 = false;
				if (!flag3)
				{
					_003C_003E1__state = -1;
					bool flag4 = (object)_003C_003E4__this == null;
					object obj2 = !flag4;
					if (obj2 == null)
					{
						NullReferenceException ex = new NullReferenceException();
						goto IL_0106;
					}
					goto IL_022f;
				}
			}
			goto IL_04d5;
			IL_0452:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0460;
			IL_0460:
			NullReferenceException ex3 = new NullReferenceException();
			nint num = default;
			bool flag5 = num != 1;
			OutOfMemoryException ex4 = (OutOfMemoryException)(object)ex3;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj3 = default;
				bool flag6 = obj3 == null;
				flag2 = false;
				if (flag6)
				{
					return flag2;
				}
				goto IL_04d5;
			}
			goto IL_05b2;
			IL_052b:
			obj._003C_003E1__state = -3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB480]");
			object obj4 = 0;
			_003CPressable_003Ed__249 obj5 = default;
			while (true)
			{
				num = (nint)obj4;
				Enumerator<, > val = (Enumerator<, >)(obj + 48);
				if (!((Enumerator<, >*)val)->MoveNext())
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ stack_-18_v2 (MonsterAvatar+<Pressable>d__249)+40]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ stack_-18_v2 (MonsterAvatar+<Pressable>d__249)+40]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X1_v1 (Il2CppMethodInfo)+50]");
					bool flag7 = (nint)0 == 0;
					obj = obj5;
					if (flag7)
					{
						continue;
					}
					goto IL_03d0;
				}
				goto IL_0444;
			}
			obj5._003C_003Em__Finally1();
			_ = 0;
			_ = 0;
			obj5._003C_003E7__wrap1 = (Enumerator<, >)0;
			flag2 = false;
			goto IL_04d5;
			IL_04d5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FC6C");
			OutOfMemoryException ex5 = new OutOfMemoryException();
			ex4 = ex5;
			goto IL_05b2;
			IL_02fd:
			if (modMenu.rows == null)
			{
				goto IL_0452;
			}
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)modMenu.rows).GetEnumerator();
			Enumerator<, > val2 = default;
			obj5._003C_003E7__wrap1 = val2;
			object obj6 = obj5 + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj = obj5;
			goto IL_052b;
			IL_0106:
			_003C_003E1__state = -1;
			bool flag8 = (object)_003C_003E4__this == null;
			object obj7 = !flag8;
			if (obj7 == null)
			{
				NullReferenceException ex6 = new NullReferenceException();
				goto IL_014d;
			}
			goto IL_0296;
			IL_03d0:
			object obj8 = obj5 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ stack_-18_v2 (MonsterAvatar+<Pressable>d__249)+40]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int num2 = 4;
			_003CPressable_003Ed__249 obj9 = obj5;
			goto IL_0557;
			IL_0557:
			obj9._003C_003E1__state = num2;
			flag2 = true;
			goto IL_04d5;
			IL_014d:
			_003C_003E1__state = -1;
			bool flag9 = (object)_003C_003E4__this == null;
			object obj10 = !flag9;
			if (obj10 == null)
			{
				NullReferenceException ex7 = new NullReferenceException();
				goto IL_0194;
			}
			goto IL_02fd;
			IL_05b2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FC4C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			bool result = default;
			return result;
			IL_0194:
			_003C_003E1__state = -1;
			if ((object)_003C_003E4__this == null)
			{
				goto IL_0460;
			}
			num = (nint)modMenu.prev;
			if (modMenu.prev == null)
			{
				goto IL_022f;
			}
			object obj11 = this + 24;
			obj11 = modMenu.prev;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj5._003C_003E1__state = 1;
			flag2 = true;
			goto IL_04d5;
			IL_0444:
			NullReferenceException ex8 = new NullReferenceException();
			goto IL_0452;
			IL_022f:
			num = (nint)modMenu.next;
			if (modMenu.next == null)
			{
				goto IL_0296;
			}
			object obj12 = this + 24;
			obj12 = modMenu.next;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num2 = 2;
			obj9 = obj5;
			goto IL_0557;
			IL_0296:
			num = (nint)modMenu.swapKey;
			if (modMenu.swapKey == null)
			{
				goto IL_02fd;
			}
			object obj13 = this + 24;
			obj13 = modMenu.swapKey;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num2 = 3;
			obj9 = obj5;
			goto IL_0557;
		}

		private unsafe void _003C_003Em__Finally1()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected I4, but got I8
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Ref, but got Unknown
			Enumerator<, > val = (Enumerator<, >)(this + 48);
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

		private IEnumerator<ModMenu.Hit> System_002ECollections_002EGeneric_002EIEnumerable_003CModMenu_002EHit_003E_002EGetEnumerator()
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
					return (IEnumerator<ModMenu.Hit>)(object)this;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB5E0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj4 = default;
			obj4._002Ector();
			_ = 0;
			int currentManagedThreadId2 = Environment.CurrentManagedThreadId;
			object obj5 = obj4 + 40;
			obj5 = _003C_003E4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return (IEnumerator<ModMenu.Hit>)obj4;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return (IEnumerator)System_002ECollections_002EGeneric_002EIEnumerable_003CModMenu_002EHit_003E_002EGetEnumerator();
		}
	}

	internal sealed class Swing
	{
		public float round;

		public bool known;
	}

	public Transform head;

	public Transform leftHand;

	public Transform rightHand;

	public Transform leftAim;

	public Transform rightAim;

	public HandPoser fingerSourceL;

	public HandPoser fingerSourceR;

	public MonsterDirector.Entry entry;

	public bool firstPerson;

	public float sizeBy;

	private float EyeHeightNow__BackingField;

	private string HeadStands__BackingField;

	private Animator anim;

	private MonsterAnimEvents events;

	private readonly bool[] onFloor;

	private readonly Vector3[] handWas;

	private readonly float[] handSpeed;

	private readonly float[] offFloor;

	private readonly float[] stompIn;

	private bool handsKnown;

	private Transform model;

	private Transform root;

	private Transform skull;

	private Transform neck;

	private Transform upL;

	private Transform loL;

	private Transform endL;

	private Transform upR;

	private Transform loR;

	private Transform endR;

	private Transform i1L;

	private Transform p1L;

	private Transform i1R;

	private Transform p1R;

	private Transform eyeL;

	private Transform eyeR;

	private Transform gripL;

	private Transform gripR;

	private float risen;

	private float risenSpeed;

	private float floorWas;

	private float floorShift;

	private float floorShiftSpeed;

	private bool floorKnown;

	private bool floorWasHit;

	private HandPoser posL;

	private HandPoser posR;

	private Vector3 lastHead;

	private Vector3 alignLocal;

	private Vector3 restUpL;

	private Vector3 restLoL;

	private Vector3 restUpR;

	private Vector3 restLoR;

	private int axisUpL;

	private int axisLoL;

	private int axisUpR;

	private int axisLoR;

	private bool hinge;

	private bool polesKnown;

	private Vector3 alongUpL;

	private Vector3 hingeUpL;

	private Vector3 alongLoL;

	private Vector3 alongUpR;

	private Vector3 hingeUpR;

	private Vector3 alongLoR;

	private Vector3 poleL;

	private Vector3 poleR;

	private float straightL;

	private float straightR;

	private Quaternion restRelL;

	private Quaternion restRelR;

	private Quaternion handAtRestL;

	private Quaternion handAtRestR;

	private readonly Swing swingL;

	private readonly Swing swingR;

	private Transform twistL;

	private Transform twistR;

	private Quaternion twistRestL;

	private Quaternion twistRestR;

	private Quaternion handRestL;

	private Quaternion handRestR;

	private Vector3 twistAxisL;

	private Vector3 twistAxisR;

	private float twistAngleL;

	private float twistAngleR;

	private bool twistsKnown;

	private float speed;

	private float yaw;

	private float pace;

	private float running;

	private bool placed;

	private bool aligned;

	private Transform chest;

	private Quaternion[] neckBase;

	private Quaternion[] skullBase;

	private Quaternion neckShare;

	private Quaternion skullOnFace;

	private bool looking;

	private bool baseLater;

	private bool faceKnown;

	private bool mirrored;

	private bool turnedForMirror;

	private Quaternion neckUnturned;

	private Quaternion skullUnturned;

	private Quaternion neckTurned;

	private Quaternion skullTurned;

	private int lookFrames;

	private static readonly int SpeedId;

	private static readonly int PaceId;

	private const int Floor = default(int);

	private const float GripOut = default(float);

	private const float RiseTime = default(float);

	private const float RiseFastest = default(float);

	private const float FloorStep = default(float);

	private const float FloorTime = default(float);

	private const float FloorShiftMost = default(float);

	private const float TeleportFar = default(float);

	private const float FloorLooksFar = default(float);

	private const float StumpOverRoot = default(float);

	private const float NeckShare = default(float);

	private const float NeckEase = default(float);

	public static Action Stomped;

	private const float ElbowFollowsHand = default(float);

	private const float PoleEase = default(float);

	private const float MostBend = default(float);

	private const float LegsMostStretch = default(float);

	private const float StraightFrom = default(float);

	private const float StraightTo = default(float);

	private const float TwistShare = default(float);

	public float EyeHeightNow
	{
		get
		{
			return EyeHeightNow__BackingField;
		}
		private set
		{
			EyeHeightNow__BackingField = value;
		}
	}

	public string HeadStands
	{
		get
		{
			return HeadStands__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 112;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public unsafe static MonsterAvatar Create(MonsterDirector.Entry entry, Transform parent, Transform head, Transform l, Transform r, bool firstPerson)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I
		//IL_00ff: Expected F4, but got I
		//IL_010f: Expected F4, but got I
		//IL_011f: Expected Obj, but got I
		//IL_0181: Expected VT, but got I4
		//IL_01bd: Expected Obj, but got I
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_0276: Expected Obj, but got I4
		//IL_02c3: Expected Obj, but got I4
		//IL_1dcc: Expected Obj, but got I4
		//IL_039d: Expected Obj, but got I4
		//IL_0337: Expected Obj, but got I
		//IL_0359: Expected Obj, but got I4
		//IL_0411: Expected Obj, but got I4
		//IL_043e: Expected Obj, but got I
		//IL_0475: Expected Obj, but got I
		//IL_0492: Expected Obj, but got I
		//IL_05d5: Expected Obj, but got I
		//IL_0609: Expected Obj, but got I4
		//IL_04fd: Expected Obj, but got I8
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected Obj, but got Unknown
		//IL_0514: Expected Obj, but got I4
		//IL_051d: Expected Obj, but got I4
		//IL_1e0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0f: Expected Obj, but got Unknown
		//IL_1e37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3c: Expected Obj, but got Unknown
		//IL_1df3: Expected Obj, but got I4
		//IL_06ae: Expected Obj, but got I
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected Obj, but got Unknown
		//IL_06ed: Expected Obj, but got I
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected Obj, but got Unknown
		//IL_054c: Expected Obj, but got I4
		//IL_0733: Expected Obj, but got I
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected Obj, but got Unknown
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected Obj, but got Unknown
		//IL_0685: Expected Obj, but got I4
		//IL_057a: Expected Obj, but got I
		//IL_058a: Expected Obj, but got I
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected Obj, but got Unknown
		//IL_05b7: Expected Obj, but got I4
		//IL_0779: Expected Obj, but got I
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected Obj, but got Unknown
		//IL_07bf: Expected Obj, but got I
		//IL_07d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Expected Obj, but got Unknown
		//IL_0805: Expected Obj, but got I
		//IL_081f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Expected Obj, but got Unknown
		//IL_084b: Expected Obj, but got I
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected Obj, but got Unknown
		//IL_0891: Expected Obj, but got I
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Expected Obj, but got Unknown
		//IL_08d7: Expected Obj, but got I
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f6: Expected Obj, but got Unknown
		//IL_091d: Expected Obj, but got I
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected Obj, but got Unknown
		//IL_0968: Expected Obj, but got I
		//IL_098f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0994: Expected Obj, but got Unknown
		//IL_09b3: Expected Obj, but got I
		//IL_09da: Unknown result type (might be due to invalid IL or missing references)
		//IL_09df: Expected Obj, but got Unknown
		//IL_09fe: Expected Obj, but got I
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Expected Obj, but got Unknown
		//IL_0a49: Expected Obj, but got I
		//IL_0a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a75: Expected Obj, but got Unknown
		//IL_0a94: Expected Obj, but got I
		//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Expected Obj, but got Unknown
		//IL_0adf: Expected Obj, but got I
		//IL_0b06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0b: Expected Obj, but got Unknown
		//IL_0b44: Expected Obj, but got I4
		//IL_1e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e61: Expected Obj, but got Unknown
		//IL_0c8f: Expected Obj, but got I4
		//IL_0bf2: Expected Obj, but got I4
		//IL_0cbe: Expected Obj, but got I4
		//IL_0c49: Expected Obj, but got I4
		//IL_0c57: Expected Obj, but got I4
		//IL_0d06: Expected Obj, but got I4
		//IL_1ed6: Expected Obj, but got I4
		//IL_0c73: Expected Obj, but got I4
		//IL_0f9d: Expected Obj, but got I4
		//IL_0d3e: Expected Obj, but got I4
		//IL_0d86: Expected Obj, but got I4
		//IL_120d: Expected Obj, but got I
		//IL_1227: Unknown result type (might be due to invalid IL or missing references)
		//IL_122c: Expected Obj, but got Unknown
		//IL_0fd5: Expected Obj, but got I4
		//IL_1258: Expected Obj, but got I
		//IL_1272: Unknown result type (might be due to invalid IL or missing references)
		//IL_1277: Expected Obj, but got Unknown
		//IL_1019: Expected Obj, but got I4
		//IL_0dbe: Expected Obj, but got I4
		//IL_12a3: Expected Obj, but got I
		//IL_12cd: Expected Obj, but got I4
		//IL_0e06: Expected Obj, but got I4
		//IL_12f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f8: Expected Ref, but got Unknown
		//IL_1301: Unknown result type (might be due to invalid IL or missing references)
		//IL_1306: Expected Ref, but got Unknown
		//IL_130f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1314: Expected Ref, but got Unknown
		//IL_1367: Expected Obj, but got I4
		//IL_1051: Expected Obj, but got I4
		//IL_13c9: Expected Obj, but got I4
		//IL_109a: Expected Obj, but got I4
		//IL_13ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f4: Expected Ref, but got Unknown
		//IL_13fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1402: Expected Ref, but got Unknown
		//IL_140b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1410: Expected Ref, but got Unknown
		//IL_1463: Expected Obj, but got I4
		//IL_138b: Expected Obj, but got I4
		//IL_0e4b: Expected VT, but got F4
		//IL_1bc9: Expected Obj, but got I
		//IL_1bd4: Expected Obj, but got I4
		//IL_1bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be2: Expected VT, but got Unknown
		//IL_1c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1b: Expected Obj, but got Unknown
		//IL_1487: Expected Obj, but got I4
		//IL_1c35: Expected Obj, but got I4
		//IL_1c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c43: Expected VT, but got Unknown
		//IL_1c53: Expected Obj, but got I
		//IL_1c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8c: Expected Obj, but got Unknown
		//IL_14e2: Expected Obj, but got I4
		//IL_10df: Expected VT, but got F4
		//IL_0e99: Expected Obj, but got I
		//IL_0ea6: Expected VT, but got F4
		//IL_0eda: Expected Obj, but got I4
		//IL_1cc3: Expected VT, but got Ref
		//IL_1cdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce2: Expected Obj, but got Unknown
		//IL_1d19: Expected VT, but got Ref
		//IL_1d33: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d38: Expected Obj, but got Unknown
		//IL_112d: Expected Obj, but got I
		//IL_113a: Expected VT, but got F4
		//IL_116e: Expected Obj, but got I4
		//IL_0f62: Expected Obj, but got I4
		//IL_153f: Expected Obj, but got I
		//IL_155c: Expected Obj, but got I
		//IL_157e: Expected Obj, but got I
		//IL_11ea: Expected Obj, but got I4
		//IL_15e4: Expected Obj, but got I8
		//IL_15f4: Expected Obj, but got I
		//IL_15fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1602: Expected Obj, but got Unknown
		//IL_1640: Expected Obj, but got I4
		//IL_1f19: Expected Obj, but got I4
		//IL_1657: Expected I4, but got I8
		//IL_1671: Expected Obj, but got I4
		//IL_1ae9: Expected Obj, but got I
		//IL_1afb: Expected I4, but got I8
		//IL_1b15: Expected Obj, but got I4
		//IL_1b77: Expected Obj, but got I
		//IL_1b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b85: Expected Obj, but got Unknown
		//IL_16b5: Expected Obj, but got I
		//IL_16c9: Expected Obj, but got I
		//IL_1b34: Expected Obj, but got I
		//IL_16ef: Expected Obj, but got I
		//IL_1758: Expected Obj, but got I
		//IL_17d8: Expected Obj, but got I
		//IL_1817: Expected Obj, but got I
		//IL_187a: Expected VT, but got I4
		//IL_187a: Expected VT, but got I4
		//IL_189d: Expected Obj, but got I
		//IL_18f6: Expected VT, but got I4
		//IL_1916: Expected Obj, but got I
		//IL_1955: Expected Obj, but got I
		//IL_197c: Expected Obj, but got I
		//IL_19a3: Expected Obj, but got I
		//IL_19ca: Expected Obj, but got I
		//IL_19e0: Expected VT, but got Ref
		//IL_19f1: Expected Obj, but got I
		//IL_1a18: Expected Obj, but got I
		//IL_1a52: Expected Obj, but got I
		GameObject gameObject = default;
		float num3;
		float num5;
		float num7;
		MonsterAvatar monsterAvatar = default;
		object obj7;
		UnityEngine.Object obj15;
		float num2;
		float num;
		if (entry != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC950]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj2 = 0;
			string text = (string)obj + entry.name;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			gameObject._002Ector(text);
			if ((object)gameObject != null)
			{
				Transform transform = gameObject.transform;
				if ((object)transform != null)
				{
					transform.SetParent(parent, worldPositionStays: false);
					Transform transform2 = gameObject.transform;
					if ((object)transform2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
						object obj3 = 0;
						object obj4 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v12+A0]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v13+10]");
						num = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v13+C]");
						num2 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8F8]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v13+14]");
						num3 = 0f * entry.playedSize;
						float num4 = entry.playedSize;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v13+10]");
						num5 = num4 * 0f;
						float num6 = entry.playedSize;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v13+C]");
						num7 = num6 * 0f;
						transform2.localScale = (Vector3)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
						if ((object)monsterAvatar != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
							obj7 = 0;
							object obj8 = monsterAvatar + 88;
							obj8 = entry;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj9 = monsterAvatar + 32;
							obj9 = head;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj10 = monsterAvatar + 40;
							obj10 = l;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj11 = monsterAvatar + 48;
							obj11 = r;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj12 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X0_v28+E4]");
							bool flag = (nint)0 == 0;
							object obj13 = !flag;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag2 = entry.prefab != null;
							bool flag3 = !flag2;
							string text2 = null;
							object obj14 = 0;
							obj15 = null;
							if (flag3)
							{
								goto IL_1da2;
							}
							if ((object)entry.prefab != null)
							{
								Transform transform3 = entry.prefab.transform;
								if ((object)transform3 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C48]");
									object obj16 = 0;
									text2 = (string)obj16;
									Transform transform4 = transform3.Find((string)obj16);
									obj14 = 0;
									obj15 = transform4;
									goto IL_1da2;
								}
							}
						}
					}
				}
			}
		}
		goto IL_1d4c;
		IL_1ee4:
		if (~(entry.hingeArms ? 1u : 0u) == 0)
		{
			monsterAvatar.HingeRest();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC928]");
		object n = 0;
		Transform transform5 = monsterAvatar.Bone((string)n);
		object obj17 = monsterAvatar + 648;
		monsterAvatar.twistL = transform5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC938]");
		object n2 = 0;
		Transform transform6 = monsterAvatar.Bone((string)n2);
		object obj18 = monsterAvatar + 656;
		monsterAvatar.twistR = transform6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
		object obj19 = 0;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ X0_v160+E4]");
		bool flag4 = (nint)0 == 0;
		object obj21 = !flag4;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = TwistRest(monsterAvatar.model, monsterAvatar.loL, monsterAvatar.twistL, monsterAvatar.endL, out *(Quaternion*)(monsterAvatar + 664), out *(Quaternion*)(monsterAvatar + 696), out *(Vector3*)(monsterAvatar + 728));
		bool flag6 = !flag5;
		object obj22 = !flag6;
		Transform transform7 = monsterAvatar.loL;
		if (obj22 == null)
		{
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			transform7 = null;
		}
		object obj23 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1191 @ X0_v165+E4]");
		bool flag7 = (nint)0 == 0;
		object obj24 = !flag7;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ref Quaternion reference = ref *(Quaternion*)(monsterAvatar + 680);
		bool flag8 = TwistRest(monsterAvatar.model, monsterAvatar.loR, monsterAvatar.twistR, monsterAvatar.endR, out reference, out *(Quaternion*)(monsterAvatar + 712), out *(Vector3*)(monsterAvatar + 740));
		bool flag9 = !flag8;
		object obj25 = !flag9;
		Transform transform8 = monsterAvatar.loR;
		if (obj25 == null)
		{
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			transform8 = null;
		}
		if (firstPerson)
		{
			object obj26 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1226 @ X0_v185+E4]");
			bool flag10 = (nint)0 == 0;
			object obj27 = !flag10;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (entry.firstPersonMesh != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F18]");
				object layerName = 0;
				int num8 = LayerMask.NameToLayer((string)layerName);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F20]");
				object layerName2 = 0;
				int num9 = LayerMask.NameToLayer((string)layerName2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C58]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
				object obj29 = default;
				if (obj29 == null)
				{
					goto IL_1d4c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v194+18]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v194+18]");
					object obj30 = 0 & 0xFFFFFFFFL;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B90]");
					object obj31 = 0;
					object obj32 = obj29 + 32;
					float num11 = default;
					float num10 = num11;
					float num13 = default;
					float num12 = num13;
					float num15 = default;
					float num14 = num15;
					float num16 = num2;
					float num17 = num;
					Transform transform9 = monsterAvatar.endR;
					object obj33 = 0;
					GameObject gameObject2 = default;
					Transform transform17 = default;
					float num19 = default;
					float num20 = default;
					while (true)
					{
						bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30);
						object obj34 = !flag11;
						if (obj34 != null)
						{
							break;
						}
						int num18 = (int)(num9 & 0x80000000L);
						bool flag12 = num18 == 0;
						object obj35 = !flag12;
						if (obj35 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X28_v13+v373 @ X20_v16*8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X28_v13+v373 @ X20_v16*8]");
								string text3 = ((UnityEngine.Object)0).name;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC960]");
								object obj36 = 0;
								string text4 = text3 + (string)obj36;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
								object obj37 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								gameObject2._002Ector(text4);
								if ((object)gameObject2 != null)
								{
									gameObject2.layer = num9;
									Transform transform10 = gameObject2.transform;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X28_v13+v373 @ X20_v16*8]");
									Transform transform11 = ((Component)0).transform;
									if ((object)transform11 != null)
									{
										Transform parent2 = transform11.parent;
										if ((object)transform10 != null)
										{
											transform10.SetParent(parent2, worldPositionStays: false);
											Transform transform12 = gameObject2.transform;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X28_v13+v373 @ X20_v16*8]");
											Transform transform13 = ((Component)0).transform;
											if ((object)transform13 != null)
											{
												Vector3 localPosition = transform13.localPosition;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X28_v13+v373 @ X20_v16*8]");
												Transform transform14 = ((Component)0).transform;
												if ((object)transform14 != null)
												{
													Quaternion localRotation = transform14.localRotation;
													if ((object)transform12 != null)
													{
														transform12.SetLocalPositionAndRotation((Vector3)0, (Quaternion)0);
														Transform transform15 = gameObject2.transform;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X28_v13+v373 @ X20_v16*8]");
														Transform transform16 = ((Component)0).transform;
														if ((object)transform16 != null)
														{
															Vector3 localScale = transform16.localScale;
															if ((object)transform15 != null)
															{
																transform15.localScale = (Vector3)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X28_v13+v373 @ X20_v16*8]");
																Mesh sharedMesh = ((SkinnedMeshRenderer)0).sharedMesh;
																if ((object)transform17 != null)
																{
																	((SkinnedMeshRenderer)(object)transform17).sharedMesh = sharedMesh;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X28_v13+v373 @ X20_v16*8]");
																	Transform[] bones = ((SkinnedMeshRenderer)0).bones;
																	((SkinnedMeshRenderer)(object)transform17).bones = bones;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X28_v13+v373 @ X20_v16*8]");
																	Transform rootBone = ((SkinnedMeshRenderer)0).rootBone;
																	((SkinnedMeshRenderer)(object)transform17).rootBone = rootBone;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X28_v13+v373 @ X20_v16*8]");
																	Material[] sharedMaterials = ((Renderer)0).sharedMaterials;
																	((Renderer)(object)transform17).sharedMaterials = sharedMaterials;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X28_v13+v373 @ X20_v16*8]");
																	Bounds localBounds = ((Renderer)0).localBounds;
																	((Renderer)(object)transform17).localBounds = (Bounds)(&num19);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X28_v13+v373 @ X20_v16*8]");
																	SkinQuality quality = ((SkinnedMeshRenderer)0).quality;
																	((SkinnedMeshRenderer)(object)transform17).quality = quality;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X28_v13+v373 @ X20_v16*8]");
																	bool updateWhenOffscreen = ((SkinnedMeshRenderer)0).updateWhenOffscreen;
																	((SkinnedMeshRenderer)(object)transform17).updateWhenOffscreen = updateWhenOffscreen;
																	((Renderer)(object)transform17).shadowCastingMode = (ShadowCastingMode)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X28_v13+v373 @ X20_v16*8]");
																	bool receiveShadows = ((Renderer)0).receiveShadows;
																	((Renderer)(object)transform17).receiveShadows = receiveShadows;
																	num19 = num20;
																	num10 = num17;
																	num12 = num17;
																	num14 = num3;
																	num16 = num5;
																	num17 = num7;
																	num7 = num20;
																	transform9 = null;
																	goto IL_1acf;
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
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X28_v13+v373 @ X20_v16*8]");
							if ((nint)0 != 0)
							{
								goto IL_1acf;
							}
						}
						goto IL_1d4c;
						IL_1acf:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X28_v13+v373 @ X20_v16*8]");
						((SkinnedMeshRenderer)0).sharedMesh = entry.firstPersonMesh;
						int num21 = (int)(num8 & 0x80000000L);
						bool flag13 = num21 == 0;
						object obj38 = !flag13;
						if (obj38 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X28_v13+v373 @ X20_v16*8]");
							GameObject gameObject3 = ((Component)0).gameObject;
							if ((object)gameObject3 == null)
							{
								goto IL_1d4c;
							}
							gameObject3.layer = num8;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v194+18]");
						obj30 = 0;
						obj33++;
						object obj39 = obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v194+18]");
						bool flag14 = (nint)obj39 < 0;
						num2 = num16;
						num = num17;
						if (flag14)
						{
							continue;
						}
						goto IL_1bb9;
					}
					goto IL_1d5a;
				}
			}
		}
		goto IL_1bb9;
		IL_1da2:
		object obj40 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X0_v33+E4]");
		bool flag15 = (nint)0 == 0;
		object obj41 = !flag15;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag16 = obj15 == null;
		bool flag17 = !flag16;
		object obj42 = !flag17;
		if (obj42 != null)
		{
			goto IL_1d47;
		}
		UnityEngine.Object obj46 = default;
		if ((object)obj15 != null)
		{
			GameObject gameObject4 = ((Component)obj15).gameObject;
			Transform transform18 = gameObject.transform;
			object obj43 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v18+E4]");
			bool flag18 = (nint)0 == 0;
			object obj44 = !flag18;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC920]");
			object obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDBD8");
			if ((object)obj46 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C48]");
				object obj47 = 0;
				obj46.name = (string)obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC910]");
				object obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
				object obj49 = default;
				if (obj49 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v47+18]");
					if ((nint)0 < (nint)1)
					{
						goto IL_05c5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v47+18]");
					object obj50 = 0 & 0xFFFFFFFFL;
					object obj51 = obj49 + 32;
					object obj52 = 0;
					object obj53 = 1;
					while (true)
					{
						bool flag19 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj52) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj50);
						object obj54 = !flag19;
						if (obj54 != null)
						{
							break;
						}
						object obj55 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v320+E4]");
						bool flag20 = (nint)0 == 0;
						object obj56 = !flag20;
						if (obj56 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X26_v20+v421 @ X25_v18*8]");
						UnityEngine.Object.Destroy((UnityEngine.Object)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v47+18]");
						obj50 = 0;
						obj52++;
						object obj57 = obj52;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v47+18]");
						bool flag21 = (nint)obj57 < 0;
						obj53 = 0;
						if (flag21)
						{
							continue;
						}
						goto IL_05c5;
					}
					goto IL_1d5a;
				}
			}
		}
		goto IL_1d4c;
		IL_1eac:
		object obj58 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1070 @ X0_v146+E4]");
		bool flag22 = (nint)0 == 0;
		object obj59 = !flag22;
		if (obj59 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj60;
		bool flag23 = (UnityEngine.Object)obj60 != null;
		bool flag24 = !flag23;
		object obj61 = 0;
		object obj64;
		if (!flag24)
		{
			object obj62 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1089 @ X0_v263+E4]");
			bool flag25 = (nint)0 == 0;
			object obj63 = !flag25;
			if (obj63 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag26 = (UnityEngine.Object)obj64 != null;
			bool flag27 = !flag26;
			obj61 = 0;
			if (!flag27)
			{
				object obj65 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1134 @ X0_v267+E4]");
				bool flag28 = (nint)0 == 0;
				object obj66 = !flag28;
				if (obj66 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag29 = monsterAvatar.endR != null;
				bool flag30 = !flag29;
				obj61 = 0;
				if (!flag30)
				{
					if (obj60 != null)
					{
						Vector3 localScale2 = ((Transform)obj60).localScale;
						monsterAvatar.restUpR = (Vector3)num7;
						if ((object)monsterAvatar.loR != null)
						{
							Vector3 localScale3 = monsterAvatar.loR.localScale;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
							object obj67 = 0;
							monsterAvatar.restLoR = (Vector3)num7;
							object obj68 = obj67;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1207 @ X0_v275+E4]");
							bool flag31 = (nint)0 == 0;
							object obj69 = !flag31;
							if (obj69 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							int num22 = Along(monsterAvatar.upR, monsterAvatar.loR);
							monsterAvatar.axisUpR = num22;
							int num23 = Along(monsterAvatar.loR, monsterAvatar.endR);
							monsterAvatar.axisLoR = num23;
							obj61 = 0;
							goto IL_1ee4;
						}
					}
					goto IL_1d4c;
				}
			}
		}
		goto IL_1ee4;
		IL_1d47:
		return monsterAvatar;
		IL_1d5a:
		return (MonsterAvatar)(object)new IndexOutOfRangeException();
		IL_05c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC908]");
		object obj70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
		object obj71 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v29+E4]");
		bool flag32 = (nint)0 == 0;
		object obj72 = !flag32;
		if (obj72 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj73 = default;
		if (obj73 != null)
		{
			if ((object)obj73 == null)
			{
				goto IL_1d4c;
			}
			object obj74 = obj73 + 32;
			obj74 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			_ = entry.onArms;
		}
		object obj75 = monsterAvatar + 128;
		obj75 = obj73;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Transform transform19 = ((GameObject)obj46).transform;
		object obj76 = monsterAvatar + 184;
		obj76 = transform19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC900]");
		object obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
		object obj78 = monsterAvatar + 120;
		object obj79 = default;
		obj78 = obj79;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC958]");
		object n3 = 0;
		Transform transform20 = monsterAvatar.Bone((string)n3);
		object obj80 = monsterAvatar + 192;
		obj80 = transform20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F0]");
		object n4 = 0;
		Transform transform21 = monsterAvatar.Bone((string)n4);
		object obj81 = monsterAvatar + 200;
		obj81 = transform21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7720]");
		object n5 = 0;
		Transform transform22 = monsterAvatar.Bone((string)n5);
		object obj82 = monsterAvatar + 208;
		obj82 = transform22;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7728]");
		object n6 = 0;
		Transform transform23 = monsterAvatar.Bone((string)n6);
		object obj83 = monsterAvatar + 216;
		obj83 = transform23;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7730]");
		object n7 = 0;
		Transform transform24 = monsterAvatar.Bone((string)n7);
		object obj84 = monsterAvatar + 224;
		obj84 = transform24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4908]");
		object n8 = 0;
		Transform transform25 = monsterAvatar.Bone((string)n8);
		object obj85 = monsterAvatar + 232;
		obj85 = transform25;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7740]");
		object n9 = 0;
		Transform transform26 = monsterAvatar.Bone((string)n9);
		obj60 = monsterAvatar + 240;
		obj60 = transform26;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7738]");
		object n10 = 0;
		Transform transform27 = monsterAvatar.Bone((string)n10);
		obj64 = monsterAvatar + 248;
		obj64 = transform27;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E0]");
		object n11 = 0;
		Transform transform28 = monsterAvatar.Bone((string)n11);
		monsterAvatar.endR = transform28;
		object obj86 = monsterAvatar + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E8]");
		object n12 = 0;
		Transform transform29 = monsterAvatar.Bone((string)n12);
		monsterAvatar.i1L = transform29;
		object obj87 = monsterAvatar + 264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC930]");
		object n13 = 0;
		Transform transform30 = monsterAvatar.Bone((string)n13);
		monsterAvatar.p1L = transform30;
		object obj88 = monsterAvatar + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC940]");
		object n14 = 0;
		Transform transform31 = monsterAvatar.Bone((string)n14);
		monsterAvatar.i1R = transform31;
		object obj89 = monsterAvatar + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC948]");
		object n15 = 0;
		Transform transform32 = monsterAvatar.Bone((string)n15);
		monsterAvatar.p1R = transform32;
		object obj90 = monsterAvatar + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48D8]");
		object n16 = 0;
		Transform transform33 = monsterAvatar.Bone((string)n16);
		monsterAvatar.eyeL = transform33;
		object obj91 = monsterAvatar + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4910]");
		object n17 = 0;
		Transform transform34 = monsterAvatar.Bone((string)n17);
		monsterAvatar.eyeR = transform34;
		object obj92 = monsterAvatar + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj93 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X0_v130+E4]");
		bool flag33 = (nint)0 == 0;
		object obj94 = !flag33;
		if (obj94 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag34 = (UnityEngine.Object)obj82 != null;
		bool flag35 = !flag34;
		UnityEngine.Object obj95 = null;
		if (!flag35)
		{
			if (obj82 == null)
			{
				goto IL_1d4c;
			}
			Transform parent3 = ((Transform)obj82).parent;
			obj95 = parent3;
		}
		object obj96 = monsterAvatar + 784;
		monsterAvatar.chest = (Transform)obj95;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		if (firstPerson)
		{
			object obj97 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v307+E4]");
			bool flag36 = (nint)0 == 0;
			object obj98 = !flag36;
			if (obj98 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag37 = !(monsterAvatar.mirrored = entry.firstPersonMesh != null);
			object obj99 = !flag37;
			obj95 = null;
			object obj100 = 0;
			if (obj99 == null)
			{
				obj95 = null;
				obj100 = 0;
				goto IL_0c94;
			}
		}
		else
		{
			monsterAvatar.mirrored = false;
			object obj100 = 0;
		}
		monsterAvatar.Bases();
		monsterAvatar.Face();
		goto IL_0c94;
		IL_1bb9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C95B8]");
		object side = 0;
		object obj101 = !firstPerson;
		Vector3 palm = (Vector3)(1 & obj101);
		HandPoser handPoser = monsterAvatar.Poser((string)side, (XRNode)4, palm, (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != 0);
		monsterAvatar.posL = handPoser;
		object obj102 = monsterAvatar + 352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj103 = !firstPerson;
		Vector3 palm2 = (Vector3)(1 & obj103);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CF8]");
		object side2 = 0;
		HandPoser handPoser2 = monsterAvatar.Poser((string)side2, (XRNode)5, palm2, (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != 0);
		monsterAvatar.posR = handPoser2;
		object obj104 = monsterAvatar + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		MonsterAvatar monsterAvatar2 = default;
		Transform transform35 = monsterAvatar2.GripOf(monsterAvatar.endL, monsterAvatar.i1L, monsterAvatar.p1L, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
		monsterAvatar.gripL = transform35;
		object obj105 = monsterAvatar + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		MonsterAvatar monsterAvatar3 = default;
		Transform transform36 = monsterAvatar3.GripOf(monsterAvatar.endR, monsterAvatar.i1R, monsterAvatar.p1R, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
		monsterAvatar.gripR = transform36;
		object obj106 = monsterAvatar + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		goto IL_1d47;
		IL_1d4c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1d5a;
		IL_0c94:
		object obj107 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X0_v141+E4]");
		bool flag38 = (nint)0 == 0;
		object obj108 = !flag38;
		if (obj108 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag39 = (UnityEngine.Object)obj83 != null;
		bool flag40 = !flag39;
		Transform transform37 = null;
		object obj109 = 0;
		if (!flag40)
		{
			object obj110 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1048 @ X0_v285+E4]");
			bool flag41 = (nint)0 == 0;
			object obj111 = !flag41;
			if (obj111 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag42 = (UnityEngine.Object)obj84 != null;
			bool flag43 = !flag42;
			transform37 = null;
			obj109 = 0;
			if (!flag43)
			{
				object obj112 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1086 @ X0_v289+E4]");
				bool flag44 = (nint)0 == 0;
				object obj113 = !flag44;
				if (obj113 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag45 = (UnityEngine.Object)obj85 != null;
				bool flag46 = !flag45;
				transform37 = null;
				obj109 = 0;
				if (!flag46)
				{
					if (obj83 != null)
					{
						Vector3 localScale4 = ((Transform)obj83).localScale;
						monsterAvatar.restUpL = (Vector3)num7;
						if ((object)monsterAvatar.loL != null)
						{
							Vector3 localScale5 = monsterAvatar.loL.localScale;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
							object obj114 = 0;
							monsterAvatar.restLoL = (Vector3)num7;
							object obj115 = obj114;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1174 @ X0_v297+E4]");
							bool flag47 = (nint)0 == 0;
							object obj116 = !flag47;
							if (obj116 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							int num24 = Along(monsterAvatar.upL, monsterAvatar.loL);
							transform37 = monsterAvatar.endL;
							monsterAvatar.axisUpL = num24;
							int num25 = Along(monsterAvatar.loL, monsterAvatar.endL);
							monsterAvatar.axisLoL = num25;
							obj109 = 0;
							goto IL_1eac;
						}
					}
					goto IL_1d4c;
				}
			}
		}
		goto IL_1eac;
	}

	public Transform Grip(bool right)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I4
		bool flag = !right;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			object obj3 = 320;
		}
		else
		{
			object obj3 = 312;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v12 @ X8_v2]");
		return (Transform)0;
	}

	public void CloseFingers(bool right, float k)
	{
		//IL_0010: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I4
		//IL_002c: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I4
		//IL_001e: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		bool flag = !right;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			object obj5 = 360;
		}
		else
		{
			object obj5 = 352;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v56 @ X8_v4]");
		if (!((UnityEngine.Object)0 != null))
		{
		}
	}

	public Vector3 FistFromHand(bool right)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I4
		//IL_002c: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got I4
		//IL_001e: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got I4
		//IL_02cb: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I4
		//IL_0304: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I
		//IL_031f: Expected VT, but got I4
		//IL_00d5: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I4
		//IL_017e: Expected Obj, but got I
		//IL_0265: Expected VT, but got Obj
		//IL_01d5: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I
		//IL_0249: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		bool flag = !right;
		object obj2 = obj;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			object obj5 = 280;
		}
		else
		{
			object obj5 = 264;
		}
		object obj6 = !flag;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
			object obj8 = 288;
		}
		else
		{
			object obj8 = 272;
		}
		object obj9 = !flag;
		object obj10 = ~obj9;
		if (obj10 == null)
		{
			object obj11 = 256;
		}
		else
		{
			object obj11 = 232;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v62 @ X8_v4]");
		bool flag3 = (UnityEngine.Object)0 != null;
		if (flag3)
		{
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v70 @ X9_v3]");
			flag3 = (UnityEngine.Object)0 != null;
			if (flag3)
			{
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v16+E4]");
				bool flag5 = (nint)0 == 0;
				object obj16 = !flag5;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v75 @ X10_v2]");
				flag3 = (UnityEngine.Object)0 != null;
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v62 @ X8_v4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v62 @ X8_v4]");
						Vector3 position = ((Transform)0).position;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v70 @ X9_v3]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v70 @ X9_v3]");
							Vector3 position2 = ((Transform)0).position;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v75 @ X10_v2]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v75 @ X10_v2]");
								return ((Transform)0).position;
							}
						}
					}
					NullReferenceException ex = new NullReferenceException();
					return (Vector3)ex;
				}
			}
		}
		return (Vector3)flag3;
	}

	public unsafe bool Hand(bool right, out Vector3 wrist, out Vector3 palm, out Vector3 knuckles)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a67: Expected Obj, but got I4
		//IL_002c: Expected Obj, but got I4
		//IL_0a89: Expected Obj, but got I4
		//IL_001e: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got I4
		//IL_0aab: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I4
		//IL_0ad2: Expected Obj, but got I
		//IL_0b29: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I
		//IL_0118: Expected Ref, but got F8
		//IL_014c: Expected Obj, but got I4
		//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Expected I4, but got Unknown
		//IL_017b: Expected Obj, but got I
		//IL_0197: Expected Obj, but got I4
		//IL_0b5a: Expected Obj, but got I
		//IL_0b72: Expected Obj, but got I
		//IL_0b7a: Expected F8, but got Obj
		//IL_0b8a: Expected F8, but got I
		//IL_0b9a: Expected F8, but got I
		//IL_0bab: Expected Obj, but got I
		//IL_0bbf: Expected Obj, but got I
		//IL_0bcf: Expected Obj, but got I
		//IL_0bdf: Expected Obj, but got I
		//IL_0be8: Expected Obj, but got Ref
		//IL_01cf: Expected Obj, but got I4
		//IL_0212: Expected Obj, but got I4
		//IL_09f4: Expected Obj, but got I4
		//IL_0a43: Expected Obj, but got I4
		//IL_0339: Expected I, but got Obj
		//IL_0349: Expected Obj, but got I
		//IL_0246: Expected Obj, but got I4
		//IL_024f: Expected Obj, but got I4
		//IL_0d77: Expected Obj, but got I
		//IL_096d: Expected Obj, but got I4
		//IL_097a: Expected Obj, but got Ref
		//IL_0982: Expected Obj, but got Ref
		//IL_03e8: Expected Obj, but got I4
		//IL_0cf3: Expected Obj, but got I4
		//IL_0c2c: Expected Obj, but got I
		//IL_0c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Expected Obj, but got Unknown
		//IL_0384: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I
		//IL_0295: Expected Obj, but got I4
		//IL_029e: Expected Obj, but got I4
		//IL_06db: Expected Obj, but got I
		//IL_06a0: Expected Obj, but got I4
		//IL_06ad: Expected Obj, but got Ref
		//IL_06b5: Expected Obj, but got Ref
		//IL_06be: Expected Obj, but got I4
		//IL_07c9: Expected Obj, but got I4
		//IL_077a: Expected Obj, but got I4
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected Obj, but got Unknown
		//IL_0d35: Expected Obj, but got I
		//IL_0716: Expected Obj, but got I
		//IL_039f: Expected Obj, but got I
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_08a0: Expected Ref, but got F8
		//IL_08bb: Expected Obj, but got I
		//IL_0916: Expected Ref, but got F8
		//IL_0924: Expected Obj, but got I4
		//IL_0442: Expected I, but got Obj
		//IL_0452: Expected Obj, but got I
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected Obj, but got Unknown
		//IL_04f1: Expected Obj, but got I4
		//IL_088f: Expected Obj, but got I
		//IL_0816: Expected Obj, but got I4
		//IL_0731: Expected Obj, but got I
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Expected Obj, but got Unknown
		//IL_0c95: Expected Obj, but got I
		//IL_048d: Expected Obj, but got I
		//IL_053c: Expected I, but got Obj
		//IL_054c: Expected Obj, but got I
		//IL_055c: Expected Obj, but got I
		//IL_0585: Expected Obj, but got I4
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected Obj, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected Obj, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Obj, but got Unknown
		//IL_04a8: Expected Obj, but got I
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		//IL_05b9: Expected Obj, but got I
		//IL_0625: Expected Obj, but got I4
		//IL_062e: Expected Obj, but got I4
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected Obj, but got Unknown
		//IL_068d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		bool flag = !right;
		object obj2 = !flag;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			object obj4 = 256;
		}
		else
		{
			object obj4 = 232;
		}
		object obj5 = !flag;
		object obj6 = ~obj5;
		object obj7;
		if (obj6 == null)
		{
			obj7 = 280;
		}
		else
		{
			obj7 = 264;
		}
		object obj8 = !flag;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
			object obj10 = 288;
		}
		else
		{
			object obj10 = 272;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v96 @ X8_v5]");
		UnityEngine.Object obj11 = (UnityEngine.Object)0;
		ref Vector3 reference = ref *(Vector3*)null;
		_ = 0;
		_ = 0;
		ref Vector3 reference2 = ref *(Vector3*)null;
		_ = 0;
		ref Vector3 reference3 = ref *(Vector3*)null;
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v78 @ X8_v4]");
		object obj14;
		if ((UnityEngine.Object)0 == null)
		{
			obj14 = 0;
			goto IL_0b37;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v78 @ X8_v4]");
		bool flag3 = (nint)0 == 0;
		IEnumerator enumerator = null;
		object obj15 = 272;
		object obj16 = 0;
		UnityEngine.Object obj17 = null;
		if (flag3)
		{
			goto IL_0987;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v78 @ X8_v4]");
		Vector3 position = ((Transform)0).position;
		double num = default;
		reference3 = ref *(Vector3*)num;
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v44+E4]");
		bool flag4 = (nint)0 == 0;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v737 @ X10_v21]");
		bool flag5 = (UnityEngine.Object)0 != null;
		bool flag6 = !flag5;
		obj16 = 0;
		double num6 = default;
		double num4 = default;
		if (!flag6)
		{
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X0_v81+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag8 = obj11 != null;
			bool flag9 = !flag8;
			obj16 = 0;
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v737 @ X10_v21]");
				bool flag10 = (nint)0 == 0;
				enumerator = null;
				obj15 = 272;
				obj16 = 0;
				obj17 = null;
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v737 @ X10_v21]");
					Vector3 position2 = ((Transform)0).position;
					bool flag11 = (object)obj11 == null;
					enumerator = null;
					obj15 = 272;
					obj16 = 0;
					obj17 = null;
					if (!flag11)
					{
						Vector3 position3 = ((Transform)obj11).position;
						double num2 = num + num;
						double num3 = num4 + num4;
						double num5 = num6 + num6;
						num = num2 * 0.5;
						num4 = num3 * 0.5;
						num6 = num5 * 0.5;
						goto IL_0898;
					}
				}
				goto IL_0987;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj22 = 0;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v31+A0]");
		object obj24 = 0;
		double num7 = (double)obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v32+4]");
		double num8 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v32+8]");
		double num9 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v78 @ X8_v4]");
		IEnumerator enumerator2 = ((Transform)0).GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4648]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC9A8]");
		object obj27 = 0;
		object obj28 = default;
		obj15 = (object)(&obj28);
		string text = null;
		obj11 = null;
		UnityEngine.Object obj32 = default;
		object obj37 = default;
		OutOfMemoryException ex3 = default;
		object obj41 = default;
		object obj39;
		object obj38;
		while (true)
		{
			if (enumerator2 == null)
			{
				goto IL_0937;
			}
			nint num10 = (nint)enumerator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v38 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v38 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03d5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v38 (Il2CppClass<System.Collections.IEnumerator>)+98]");
			object obj29 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X10_v31-8]");
				if (0 == (nint)obj25)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v38 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				obj15 = -1;
				obj7 = obj29 + 16;
				bool flag12 = (nint)obj15 != 1;
				obj29 = obj7;
				if (flag12)
				{
					continue;
				}
				goto IL_03d5;
			}
			obj15 = obj29;
			object obj30 = num10 + obj29;
			object obj31 = obj30 + 312;
			obj7 = obj29;
			goto IL_0c1c;
			IL_0c85:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X0_v62+8]");
			obj17 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v933 @ X0_v62] (should have been resolved before IL gen)");
			if ((object)obj32 != null)
			{
				text = (string)obj26;
				nint num11 = (nint)obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v44 (Il2CppClass<UnityEngine.Object>)+130]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X1_v20 (System.String)+130]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v44 (Il2CppClass<UnityEngine.Object>)+130]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X1_v20 (System.String)+130]");
				bool flag13 = num12 < 0;
				object obj33 = !flag13;
				object obj34 = ~obj33;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v44 (Il2CppClass<UnityEngine.Object>)+B0]");
					nint num13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X1_v20 (System.String)+130]");
					object obj35 = num13 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X8_v47-8]");
					if (0 == (nint)text)
					{
						string text2 = obj32.name;
						text = (string)obj27;
						bool flag14 = text2 == (string)obj27;
						bool flag15 = !flag14;
						object obj36 = !flag15;
						obj16 = 0;
						if (obj36 == null)
						{
							Vector3 position4 = ((Transform)obj32).position;
							num7 += num;
							num8 += num4;
							obj11 = (UnityEngine.Object)(obj11 + 1);
							num9 += num6;
							obj16 = 0;
							text = null;
						}
						continue;
					}
				}
				InvalidCastException ex = new InvalidCastException();
				goto IL_0937;
			}
			goto IL_095b;
			IL_095b:
			NullReferenceException ex2 = new NullReferenceException();
			obj37 = 0;
			ex3 = null;
			obj38 = (object)(&obj28);
			obj39 = (object)(&enumerator);
			goto IL_0987;
			IL_0937:
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_0945;
			IL_0945:
			NullReferenceException ex5 = new NullReferenceException();
			obj17 = (UnityEngine.Object)(object)text;
			goto IL_095b;
			IL_03d5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			obj16 = 0;
			goto IL_0c1c;
			IL_0c1c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X0_v59+8]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v754 @ X0_v59] (should have been resolved before IL gen)");
			object obj40 = obj41 & 1;
			if (obj40 == null)
			{
				break;
			}
			if (enumerator2 == null)
			{
				goto IL_0945;
			}
			nint num14 = (nint)enumerator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v41 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v41 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_04de;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v41 (Il2CppClass<System.Collections.IEnumerator>)+98]");
			object obj42 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X10_v26-8]");
				if (0 == (nint)obj25)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v41 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				obj15 = -1;
				obj7 = obj42 + 16;
				bool flag16 = (nint)obj15 != 1;
				obj42 = obj7;
				if (flag16)
				{
					continue;
				}
				goto IL_04de;
			}
			obj15 = obj42 + 1;
			object obj43 = num14 + obj15;
			object obj44 = obj43 + 312;
			obj7 = obj42;
			goto IL_0c85;
			IL_04de:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			obj16 = 1;
			goto IL_0c85;
		}
		obj37 = 0;
		ex3 = null;
		obj38 = (object)(&obj28);
		obj39 = (object)(&enumerator);
		object obj45 = 13;
		goto IL_0d67;
		IL_0995:
		OutOfMemoryException ex6 = new OutOfMemoryException();
		goto IL_09a3;
		IL_0987:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_0995;
		IL_0b37:
		return (byte)(obj14 & 1) != 0;
		IL_0d25:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v898 @ X0_v15+8]");
		obj17 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v898 @ X0_v15] (should have been resolved before IL gen)");
		goto IL_0cd9;
		IL_0898:
		reference = ref *(Vector3*)num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v78 @ X8_v4]");
		Vector3 position5 = ((Transform)0).position;
		double num15 = num + (double)knuckles;
		double num16 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [knuckles @ X4 (UnityEngine.Vector3&)+8]");
		double num17 = num16 + 0.0;
		double num18 = num15 * 63.0;
		double num19 = num17 * 0.5;
		reference2 = ref *(Vector3*)num18;
		obj14 = 1;
		goto IL_0b37;
		IL_09a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)obj17 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj37 = 1;
		}
		else
		{
			if ((nint)obj17 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE48");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				bool result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj46 = default;
			ex3 = (OutOfMemoryException)obj46;
		}
		obj45 = 0;
		goto IL_0d67;
		IL_0767:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj16 = 0;
		goto IL_0d25;
		IL_0d67:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		object obj47 = 0;
		obj17 = (UnityEngine.Object)obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		object obj48 = default;
		obj38 = obj48;
		if (obj48 == null)
		{
			goto IL_0cd9;
		}
		object obj49 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v13+12E]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v13+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0767;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v13+98]");
		object obj50 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X10_v10-8]");
			if (0 == (nint)obj47)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v13+12E]");
			obj15 = -1;
			obj7 = obj50 + 16;
			bool flag17 = (nint)obj15 != 1;
			obj50 = obj7;
			if (flag17)
			{
				continue;
			}
			goto IL_0767;
		}
		obj15 = obj50;
		object obj51 = obj49 + obj50;
		object obj52 = obj51 + 312;
		obj7 = obj50;
		goto IL_0d25;
		IL_0cd9:
		bool flag18 = ex3 == null;
		object obj53 = !flag18;
		if (obj53 != null)
		{
			goto IL_0995;
		}
		bool flag19 = obj37 == null;
		object obj54 = !flag19;
		ex6 = ex3;
		if (obj54 == null)
		{
			if ((nint)obj45 != 13)
			{
				bool flag20 = obj45 == null;
				object obj55 = !flag20;
				obj14 = obj37;
				if (obj55 != null)
				{
					goto IL_0b37;
				}
			}
			if ((nint)obj11 > 0)
			{
				num = num7 / (double)obj11;
				num4 = num8 / (double)obj11;
				num6 = num9 / (double)obj11;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v78 @ X8_v4]");
				Vector3 position6 = ((Transform)0).position;
			}
			goto IL_0898;
		}
		goto IL_09a3;
	}

	private Transform GripOf(Transform hand, Transform index1, Transform pinkie1, Vector3 palm)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02eb: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I
		//IL_0180: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I
		//IL_035b: Expected Obj, but got I4
		//IL_0437: Expected VT, but got I4
		//IL_046a: Expected Obj, but got I4
		//IL_03ce: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = hand == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = index1 == null;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v13+E4]");
				bool flag7 = (nint)0 == 0;
				object obj9 = !flag7;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(pinkie1 == null))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC9A8]");
					object obj11 = 0;
					GameObject gameObject = default;
					gameObject._002Ector((string)obj11);
					if ((object)gameObject != null)
					{
						Transform transform = gameObject.transform;
						if ((object)transform != null)
						{
							transform.SetParent(hand, worldPositionStays: false);
							if ((object)index1 != null)
							{
								Vector3 position = index1.position;
								if ((object)pinkie1 != null)
								{
									Vector3 position2 = pinkie1.position;
									if ((object)hand != null)
									{
										object obj13 = default;
										object obj12 = obj13 + obj13;
										object obj15 = default;
										object obj14 = obj15 + obj15;
										Vector3 position3 = hand.position;
										double num = (double)obj12 * 0.5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
										object obj16 = 0;
										double num2 = (double)obj14 * 0.5;
										object obj17 = obj16;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v30+E4]");
										bool flag8 = (nint)0 == 0;
										object obj18 = !flag8;
										object obj20 = default;
										object obj19 = obj20;
										if (obj18 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj19 = obj20;
										}
										double num3 = (double)obj13 - num;
										double num4 = (double)obj15 - num2;
										double num5 = num3 * num3;
										double num6 = num4 * num4;
										Vector3 position4 = hand.position;
										Vector3 vector = hand.TransformDirection((Vector3)0);
										double num7 = num5 + num6;
										object obj21 = obj16;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v38+E4]");
										bool flag9 = (nint)0 == 0;
										object obj22 = !flag9;
										if (obj22 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
										object obj23 = default;
										if ((nint)obj23 > 0)
										{
										}
										transform.position = (Vector3)0;
										return transform;
									}
								}
							}
						}
					}
					return (Transform)(object)new NullReferenceException();
				}
			}
		}
		return hand;
	}

	private Transform Bone(string n)
	{
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0088: Expected Obj, but got I4
		//IL_01ba: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		Transform result;
		if ((object)model != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47E8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
			object obj2 = default;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v7+18]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v7+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_0157;
				}
				object obj4 = obj2 + 32;
				object obj5 = 0;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
					object obj6 = !flag;
					if (obj6 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X23_v6+v51 @ X22_v7*8]");
					if ((nint)0 == 0)
					{
						goto IL_0161;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X23_v6+v51 @ X22_v7*8]");
					string text = ((UnityEngine.Object)0).name;
					bool flag2 = text == n;
					bool flag3 = !flag2;
					object obj7 = !flag3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X23_v6+v51 @ X22_v7*8]");
					result = (Transform)0;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v7+18]");
						obj3 = 0;
						obj5++;
						object obj8 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v7+18]");
						if ((nint)obj8 < 0)
						{
							continue;
						}
						goto IL_0157;
					}
					goto IL_019c;
				}
				goto IL_016f;
			}
		}
		goto IL_0161;
		IL_019c:
		return result;
		IL_0161:
		NullReferenceException ex = new NullReferenceException();
		goto IL_016f;
		IL_016f:
		return (Transform)(object)new IndexOutOfRangeException();
		IL_0157:
		result = null;
		goto IL_019c;
	}

	private unsafe HandPoser Poser(string side, XRNode node, Vector3 palm, bool remote)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_04fe: Expected Obj, but got Ref
		//IL_005d: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I4
		//IL_012c: Expected Obj, but got I
		//IL_0156: Expected Obj, but got I4
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected I4, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_0203: Expected Obj, but got I
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_024a: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_0292: Expected Obj, but got Ref
		//IL_0343: Expected Obj, but got Ref
		//IL_02e5: Expected Obj, but got I
		//IL_0306: Expected Obj, but got Ref
		//IL_0316: Expected Obj, but got I
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected Obj, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_03ae: Expected Obj, but got I
		//IL_03c3: Expected F4, but got I
		//IL_03dd: Expected Obj, but got I
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_0436: Expected Obj, but got I
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected Obj, but got Unknown
		//IL_0488: Expected Obj, but got VT
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CF0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		MonsterBrain._003C_003Ec__DisplayClass125_0 obj4 = default;
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		string n = (string)obj + side;
		Transform transform = Bone(n);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = transform == null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		HandPoser result = null;
		IndexOutOfRangeException ex = default;
		if (obj7 == null)
		{
			bool flag4 = (object)model == null;
			object obj8 = 0;
			UnityEngine.Object obj9 = null;
			if (!flag4)
			{
				GameObject gameObject = model.gameObject;
				bool flag5 = (object)gameObject == null;
				obj8 = 0;
				obj9 = null;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC978]");
					object obj10 = 0;
					obj9 = (UnityEngine.Object)obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
					HandPoser handPoser = default;
					bool flag6 = (object)handPoser == null;
					obj8 = 0;
					if (!flag6)
					{
						bool remote2 = (byte)(palm & 1) != 0;
						handPoser.node = node;
						handPoser.remote = remote2;
						object obj11 = handPoser + 40;
						obj11 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC990]");
						object f = 0;
						HandPoser.Finger finger = _003CPoser_003Eg__Chain_007C125_0((string)f, ref obj4);
						object obj12 = handPoser + 48;
						obj12 = finger;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC998]");
						object f2 = 0;
						HandPoser.Finger finger2 = _003CPoser_003Eg__Chain_007C125_0((string)f2, ref obj4);
						object obj13 = handPoser + 56;
						obj13 = finger2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC970]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC9A0]");
						object obj15 = 0;
						HandPoser.Finger finger3 = _003CPoser_003Eg__Chain_007C125_0((string)obj15, ref obj4);
						object obj16 = default;
						bool flag7 = obj16 == null;
						obj8 = (object)(&obj4);
						obj9 = (UnityEngine.Object)obj15;
						if (!flag7)
						{
							bool flag8 = finger3 == null;
							UnityEngine.Object obj17 = (UnityEngine.Object)obj15;
							if (!flag8)
							{
								object obj18 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v32+40]");
								obj17 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag9 = ex == null;
								obj8 = (object)(&obj4);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v32+40]");
								obj9 = (UnityEngine.Object)0;
								if (flag9)
								{
									goto IL_04c9;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v38+18]");
							bool flag10 = (nint)0 == 0;
							obj8 = (object)(&obj4);
							obj9 = obj17;
							if (flag10)
							{
								goto IL_04bb;
							}
							object obj19 = obj16 + 32;
							obj19 = finger3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj20 = handPoser + 64;
							obj20 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
							object obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B950]");
							handPoser.fingerCurl = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC988]");
							object obj22 = 0;
							object obj23 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v24+8]");
							_ = 0;
							object obj24 = handPoser + 112;
							object obj25 = default;
							obj24 = obj25;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC980]");
							object obj26 = 0;
							object obj27 = obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v28+8]");
							_ = 0;
							object obj28 = handPoser + 120;
							object obj29 = default;
							obj28 = obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj30 = ~palm;
							object obj31 = 1 & obj30;
							result = handPoser;
							goto IL_051e;
						}
					}
				}
			}
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_04bb;
		}
		goto IL_051e;
		IL_051e:
		return result;
		IL_04bb:
		ex = new IndexOutOfRangeException();
		goto IL_04c9;
		IL_04c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		return (HandPoser)(object)new ArgumentNullException();
	}

	private unsafe void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_43c3: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I
		//IL_014f: Invalid comparison between F4 and I
		//IL_0161: Expected VT, but got I4
		//IL_0213: Expected Obj, but got I4
		//IL_43e9: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I4
		//IL_0196: Expected Obj, but got I
		//IL_01e9: Expected VT, but got I4
		//IL_01fa: Expected VT, but got I4
		//IL_0290: Expected Obj, but got I4
		//IL_062d: Invalid comparison between F4 and I4
		//IL_063c: Invalid comparison between F4 and I4
		//IL_0654: Expected Obj, but got F8
		//IL_0661: Expected Obj, but got F4
		//IL_0696: Expected Obj, but got I4
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected I4, but got Unknown
		//IL_0e04: Expected Obj, but got I4
		//IL_02c8: Expected Obj, but got I4
		//IL_030d: Expected Obj, but got I4
		//IL_462e: Expected Obj, but got I4
		//IL_4465: Expected Obj, but got I
		//IL_4485: Expected Obj, but got I
		//IL_44a7: Expected Obj, but got I4
		//IL_033a: Expected Obj, but got I
		//IL_0372: Expected Obj, but got I
		//IL_03a8: Expected F4, but got I
		//IL_03f5: Invalid comparison between F4 and I
		//IL_0e60: Expected Obj, but got I4
		//IL_517f: Expected VT, but got I8
		//IL_517f: Expected VT, but got Ref
		//IL_519d: Expected Obj, but got I4
		//IL_056d: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I
		//IL_0463: Expected Obj, but got I
		//IL_04a1: Expected F4, but got I
		//IL_04ee: Invalid comparison between F4 and I
		//IL_0f40: Expected F8, but got I4
		//IL_4667: Expected Obj, but got I4
		//IL_4678: Expected Obj, but got I4
		//IL_4689: Expected Obj, but got I4
		//IL_44d3: Expected Obj, but got I4
		//IL_44ec: Expected VT, but got I4
		//IL_0515: Expected VT, but got I4
		//IL_450b: Expected Obj, but got I4
		//IL_451b: Expected Obj, but got I
		//IL_0782: Expected VT, but got I4
		//IL_052a: Expected F4, but got I
		//IL_053a: Expected F8, but got I
		//IL_0544: Expected F4, but got VT
		//IL_0554: Expected VT, but got I4
		//IL_51d1: Expected Obj, but got I
		//IL_51ee: Expected Obj, but got I
		//IL_51fe: Expected Obj, but got I
		//IL_5230: Expected Obj, but got I
		//IL_5240: Expected Obj, but got I
		//IL_527b: Expected F4, but got I
		//IL_457b: Invalid comparison between F4 and I
		//IL_08dc: Expected Obj, but got I
		//IL_08a6: Expected Obj, but got I
		//IL_0a8e: Expected VT, but got I4
		//IL_0aa4: Expected Obj, but got I4
		//IL_0966: Invalid comparison between F4 and I4
		//IL_0975: Expected F4, but got I4
		//IL_0af3: Expected Obj, but got I4
		//IL_45b4: Invalid comparison between F8 and I4
		//IL_45c3: Expected F8, but got I4
		//IL_0b38: Expected Obj, but got I4
		//IL_098c: Invalid comparison between F4 and I4
		//IL_099b: Expected F4, but got I4
		//IL_0c77: Expected Obj, but got I4
		//IL_0cd4: Expected Obj, but got I4
		//IL_0b75: Expected Obj, but got I4
		//IL_09b2: Invalid comparison between F4 and I4
		//IL_0bba: Expected Obj, but got I4
		//IL_0d13: Expected Obj, but got I4
		//IL_0f76: Expected F4, but got I4
		//IL_0c47: Expected Obj, but got I4
		//IL_0ffb: Expected VT, but got I4
		//IL_0ffb: Expected VT, but got I4
		//IL_46d3: Expected Obj, but got I
		//IL_46e3: Expected Obj, but got I
		//IL_46f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_46f8: Expected Obj, but got Unknown
		//IL_4743: Expected Obj, but got I4
		//IL_4780: Expected Obj, but got I4
		//IL_102e: Expected Obj, but got I4
		//IL_1073: Expected Obj, but got I4
		//IL_4794: Unknown result type (might be due to invalid IL or missing references)
		//IL_4799: Expected Obj, but got Unknown
		//IL_49bd: Expected Obj, but got I
		//IL_49df: Expected Obj, but got I4
		//IL_47ef: Expected Obj, but got F4
		//IL_5325: Expected Obj, but got I
		//IL_5342: Expected Obj, but got I
		//IL_535a: Expected Obj, but got I
		//IL_5384: Expected Obj, but got I
		//IL_538c: Expected F4, but got Obj
		//IL_53c1: Invalid comparison between F4 and Obj
		//IL_47ca: Expected Obj, but got I
		//IL_47d2: Expected F4, but got Obj
		//IL_47e2: Expected F4, but got I
		//IL_1219: Expected F4, but got I
		//IL_1229: Expected F8, but got I
		//IL_1238: Expected VT, but got I4
		//IL_1238: Expected VT, but got I4
		//IL_117b: Invalid comparison between F8 and I4
		//IL_118a: Expected F8, but got I4
		//IL_5416: Expected Obj, but got I4
		//IL_125e: Expected VT, but got I4
		//IL_1132: Expected Obj, but got I4
		//IL_4a26: Expected Obj, but got I4
		//IL_1387: Expected F4, but got I4
		//IL_1821: Expected Obj, but got I4
		//IL_52ee: Expected VT, but got F4
		//IL_13f0: Invalid comparison between F4 and I4
		//IL_13ff: Invalid comparison between F4 and I4
		//IL_1412: Expected Obj, but got F4
		//IL_141f: Expected Obj, but got F4
		//IL_1454: Expected Obj, but got I4
		//IL_145c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1461: Expected Obj, but got Unknown
		//IL_48cf: Expected Obj, but got I4
		//IL_1316: Invalid comparison between F8 and I4
		//IL_1325: Expected F8, but got I4
		//IL_4942: Expected Obj, but got I4
		//IL_188b: Expected Obj, but got I4
		//IL_18db: Expected Obj, but got I4
		//IL_1a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6f: Expected Obj, but got Unknown
		//IL_1a91: Expected Obj, but got I4
		//IL_21b6: Expected Obj, but got I
		//IL_21e0: Expected Obj, but got I4
		//IL_1513: Expected Obj, but got I
		//IL_153d: Expected Obj, but got I4
		//IL_1ac0: Expected Obj, but got F4
		//IL_1ac9: Expected Obj, but got F4
		//IL_1b03: Expected VT, but got I4
		//IL_1b0b: Expected VT, but got I4
		//IL_1b1b: Expected VT, but got F4
		//IL_1948: Expected F8, but got I4
		//IL_4c59: Expected Obj, but got I4
		//IL_4c73: Invalid comparison between F4 and I4
		//IL_4c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c8f: Expected Obj, but got Unknown
		//IL_1572: Expected Obj, but got I
		//IL_4b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b24: Expected Obj, but got Unknown
		//IL_4b46: Expected Obj, but got I4
		//IL_4aa9: Expected F8, but got I
		//IL_4ab9: Invalid comparison between F4 and I
		//IL_4b03: Expected F8, but got I
		//IL_2efd: Expected I4, but got VT
		//IL_2f05: Expected I4, but got VT
		//IL_1b75: Expected Obj, but got I4
		//IL_5434: Expected Obj, but got I
		//IL_545e: Expected Obj, but got I4
		//IL_198e: Invalid comparison between F4 and I4
		//IL_19a5: Expected F8, but got I4
		//IL_22e3: Expected Obj, but got I
		//IL_2306: Expected F4, but got I
		//IL_2306: Expected I4, but got Obj
		//IL_233a: Expected Obj, but got I4
		//IL_221c: Expected F8, but got I4
		//IL_4963: Expected I4, but got Obj
		//IL_4997: Expected Obj, but got I4
		//IL_158b: Expected F4, but got I4
		//IL_1bba: Expected VT, but got I4
		//IL_1bc2: Expected VT, but got I4
		//IL_1bd2: Expected VT, but got F4
		//IL_236f: Expected Obj, but got I
		//IL_2397: Expected F4, but got I
		//IL_15c9: Expected Obj, but got I
		//IL_2f4f: Expected Obj, but got I4
		//IL_4cdc: Expected Obj, but got I4
		//IL_2262: Invalid comparison between F4 and I4
		//IL_2271: Expected F8, but got I4
		//IL_161e: Expected F4, but got I4
		//IL_2f93: Expected I4, but got VT
		//IL_2f9b: Expected I4, but got VT
		//IL_1c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c15: Expected Obj, but got Unknown
		//IL_1c37: Expected Obj, but got I4
		//IL_1c7c: Expected Obj, but got I4
		//IL_2fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fce: Expected Obj, but got Unknown
		//IL_2ff0: Expected Obj, but got I4
		//IL_40e5: Expected Obj, but got I4
		//IL_3035: Expected Obj, but got I4
		//IL_1cd9: Expected Obj, but got I
		//IL_1d03: Expected Obj, but got I4
		//IL_41b4: Expected Obj, but got I4
		//IL_1d49: Expected F4, but got VT
		//IL_1d49: Expected VT, but got I4
		//IL_1d49: Expected VT, but got I4
		//IL_3092: Expected Obj, but got I
		//IL_30bc: Expected Obj, but got I4
		//IL_1d8f: Expected VT, but got I4
		//IL_1d8f: Expected VT, but got Obj
		//IL_3101: Expected F4, but got VT
		//IL_422b: Expected Obj, but got I4
		//IL_314a: Expected Obj, but got VT
		//IL_314a: Expected VT, but got Obj
		//IL_1dca: Expected Obj, but got I4
		//IL_4270: Expected VT, but got I4
		//IL_432a: Expected Obj, but got I4
		//IL_3185: Expected Obj, but got I4
		//IL_4b97: Expected Obj, but got I4
		//IL_4ba7: Expected F4, but got I
		//IL_4bb4: Expected F4, but got VT
		//IL_4bc4: Expected F4, but got I
		//IL_23af: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b4: Expected Obj, but got Unknown
		//IL_23bd: Expected VT, but got I4
		//IL_23c5: Expected VT, but got I4
		//IL_23dd: Expected F4, but got I
		//IL_23ed: Expected F4, but got I
		//IL_23fd: Expected F4, but got I
		//IL_240d: Expected F4, but got I
		//IL_241a: Expected F4, but got VT
		//IL_242a: Expected F4, but got I
		//IL_2437: Expected F4, but got VT
		//IL_429d: Expected F8, but got I
		//IL_42f2: Expected VT, but got I4
		//IL_42fb: Expected VT, but got I4
		//IL_54a7: Expected VT, but got I4
		//IL_54a7: Expected VT, but got I4
		//IL_54ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_54b2: Expected Obj, but got Unknown
		//IL_4c30: Expected Obj, but got I4
		//IL_4f06: Expected Obj, but got I4
		//IL_4f16: Expected F4, but got I
		//IL_4f23: Expected F4, but got VT
		//IL_4f33: Expected F4, but got I
		//IL_3528: Unknown result type (might be due to invalid IL or missing references)
		//IL_352d: Expected Obj, but got Unknown
		//IL_354d: Expected F4, but got I
		//IL_355d: Expected F4, but got I
		//IL_356d: Expected F4, but got I
		//IL_357d: Expected F4, but got I
		//IL_358a: Expected F4, but got VT
		//IL_359a: Expected F4, but got I
		//IL_35a7: Expected F4, but got VT
		//IL_35b4: Expected F4, but got VT
		//IL_211e: Expected VT, but got I4
		//IL_2128: Expected VT, but got I4
		//IL_2140: Expected F4, but got I
		//IL_2150: Expected F4, but got I
		//IL_2160: Expected F4, but got I
		//IL_2170: Expected F4, but got I
		//IL_2180: Expected F4, but got I
		//IL_218d: Expected F4, but got VT
		//IL_1e3a: Expected F4, but got I
		//IL_1e47: Expected F4, but got VT
		//IL_1e57: Expected F4, but got I
		//IL_5507: Expected VT, but got F4
		//IL_550f: Expected VT, but got F4
		//IL_5539: Expected VT, but got Obj
		//IL_4393: Expected VT, but got I4
		//IL_5583: Expected VT, but got I4
		//IL_5583: Expected VT, but got I4
		//IL_5589: Unknown result type (might be due to invalid IL or missing references)
		//IL_558e: Expected Obj, but got Unknown
		//IL_4f84: Expected Obj, but got I4
		//IL_1e64: Expected VT, but got Obj
		//IL_1e6d: Expected VT, but got F8
		//IL_1e76: Expected Obj, but got F4
		//IL_1e7f: Expected VT, but got F4
		//IL_1ea1: Expected Obj, but got I4
		//IL_3492: Expected VT, but got I4
		//IL_349c: Expected VT, but got I4
		//IL_34b4: Expected F4, but got I
		//IL_34c4: Expected F4, but got I
		//IL_34d4: Expected F4, but got I
		//IL_34e4: Expected F4, but got I
		//IL_34f4: Expected F4, but got I
		//IL_3501: Expected F4, but got VT
		//IL_31f5: Expected F4, but got I
		//IL_3202: Expected F4, but got VT
		//IL_3212: Expected F4, but got I
		//IL_55e3: Expected VT, but got F4
		//IL_560d: Expected VT, but got Obj
		//IL_1ed3: Expected VT, but got Obj
		//IL_1ed3: Expected VT, but got Obj
		//IL_1eea: Expected VT, but got F4
		//IL_1f0a: Expected F4, but got VT
		//IL_1f14: Expected VT, but got Obj
		//IL_2484: Expected Obj, but got I4
		//IL_321f: Expected VT, but got Obj
		//IL_3241: Expected Obj, but got I4
		//IL_4bdc: Expected VT, but got F4
		//IL_24d1: Expected F8, but got VT
		//IL_24db: Expected VT, but got Obj
		//IL_3273: Expected VT, but got Obj
		//IL_3273: Expected VT, but got Obj
		//IL_32a4: Expected VT, but got Obj
		//IL_3601: Expected Obj, but got I4
		//IL_1fc9: Expected Obj, but got I4
		//IL_1f3c: Expected VT, but got I
		//IL_1f61: Expected VT, but got I
		//IL_1f71: Expected Obj, but got I
		//IL_1f81: Expected VT, but got I
		//IL_1f92: Expected VT, but got I4
		//IL_1f9a: Expected Obj, but got Ref
		//IL_255d: Expected F4, but got I
		//IL_256d: Invalid comparison between F8 and I
		//IL_258e: Expected VT, but got F4
		//IL_259e: Expected F4, but got I
		//IL_25ae: Expected Obj, but got VT
		//IL_4f4b: Expected VT, but got F4
		//IL_364e: Expected F8, but got VT
		//IL_3658: Expected VT, but got Obj
		//IL_2009: Expected VT, but got Obj
		//IL_2064: Expected Obj, but got VT
		//IL_2064: Expected VT, but got I
		//IL_2064: Expected VT, but got I4
		//IL_2064: Expected VT, but got I4
		//IL_2064: Expected VT, but got Obj
		//IL_2064: Expected VT, but got I4
		//IL_2da2: Expected Obj, but got I4
		//IL_333d: Expected Obj, but got I4
		//IL_32c6: Expected F4, but got VT
		//IL_32eb: Expected F4, but got I
		//IL_32f5: Expected F4, but got VT
		//IL_3306: Expected VT, but got I4
		//IL_330e: Expected Obj, but got Ref
		//IL_36da: Expected F8, but got I
		//IL_36ea: Invalid comparison between F8 and I
		//IL_36fb: Expected I4, but got VT
		//IL_3703: Expected I4, but got VT
		//IL_371b: Expected F4, but got I
		//IL_372b: Expected Obj, but got VT
		//IL_2072: Expected VT, but got I4
		//IL_209c: Expected F4, but got I
		//IL_20ac: Expected F4, but got I
		//IL_20bc: Expected F4, but got I
		//IL_20cc: Expected F4, but got I
		//IL_20d6: Expected F8, but got VT
		//IL_20e6: Expected F4, but got I
		//IL_20f3: Expected F4, but got VT
		//IL_2105: Expected VT, but got Obj
		//IL_25ec: Expected VT, but got F4
		//IL_25fc: Expected F4, but got I
		//IL_261c: Expected F4, but got I
		//IL_262d: Expected Obj, but got I4
		//IL_2517: Expected VT, but got I4
		//IL_252f: Expected F8, but got I
		//IL_2548: Expected VT, but got I4
		//IL_337d: Expected VT, but got Obj
		//IL_33d8: Expected Obj, but got VT
		//IL_33d8: Expected VT, but got I
		//IL_33d8: Expected VT, but got I4
		//IL_33d8: Expected VT, but got I4
		//IL_33d8: Expected VT, but got Obj
		//IL_33d8: Expected VT, but got I4
		//IL_3f11: Expected Obj, but got I4
		//IL_4df7: Expected Obj, but got VT
		//IL_33e6: Expected VT, but got I4
		//IL_3410: Expected F4, but got I
		//IL_3420: Expected F4, but got I
		//IL_3430: Expected F4, but got I
		//IL_3440: Expected F4, but got I
		//IL_344a: Expected F8, but got VT
		//IL_345a: Expected F4, but got I
		//IL_3467: Expected F4, but got VT
		//IL_3479: Expected VT, but got Obj
		//IL_3f5d: Expected VT, but got F4
		//IL_3771: Expected F4, but got I
		//IL_3791: Expected F8, but got I
		//IL_37a2: Expected Obj, but got I4
		//IL_3694: Expected VT, but got I4
		//IL_36ac: Expected F8, but got I
		//IL_36c5: Expected VT, but got I4
		//IL_2e26: Expected F4, but got I
		//IL_2e36: Expected F4, but got I
		//IL_2e46: Expected F8, but got I
		//IL_2e56: Expected F4, but got I
		//IL_2e66: Expected F8, but got I
		//IL_2e76: Expected F4, but got I
		//IL_2e98: Expected Obj, but got I4
		//IL_5058: Expected I4, but got VT
		//IL_5060: Expected I4, but got VT
		//IL_50a8: Expected Obj, but got VT
		//IL_4e24: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e29: Expected VT, but got Unknown
		//IL_4e34: Expected VT, but got I4
		//IL_4e65: Expected F4, but got VT
		//IL_4e87: Expected F4, but got VT
		//IL_3fa5: Expected F4, but got I
		//IL_3fb5: Expected F4, but got I
		//IL_3fc5: Expected F8, but got I
		//IL_3fd5: Expected F4, but got I
		//IL_3fe5: Expected F8, but got I
		//IL_3ff5: Expected F4, but got I
		//IL_4017: Expected Obj, but got I4
		//IL_266b: Expected Obj, but got I4
		//IL_50d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_50da: Expected VT, but got Unknown
		//IL_50e5: Expected VT, but got I4
		//IL_5116: Expected F4, but got VT
		//IL_511e: Expected I4, but got VT
		//IL_5126: Expected I4, but got VT
		//IL_5138: Expected F8, but got VT
		//IL_26f0: Expected F4, but got I
		//IL_2708: Expected F8, but got I
		//IL_2715: Expected F4, but got VT
		//IL_271d: Expected Obj, but got VT
		//IL_2727: Expected VT, but got Obj
		//IL_37e0: Expected Obj, but got I4
		//IL_382d: Expected I4, but got VT
		//IL_3835: Expected I4, but got VT
		//IL_3865: Expected F4, but got I
		//IL_387d: Expected F4, but got I
		//IL_388a: Expected F8, but got VT
		//IL_3892: Expected Obj, but got VT
		//IL_389c: Expected VT, but got Obj
		//IL_2754: Expected VT, but got I
		//IL_2799: Expected F8, but got I
		//IL_2813: Invalid comparison between F4 and I
		//IL_2851: Expected F8, but got I
		//IL_2859: Expected Obj, but got VT
		//IL_2862: Expected VT, but got I4
		//IL_38c9: Expected F4, but got I
		//IL_390e: Expected F8, but got I
		//IL_3988: Invalid comparison between F8 and I
		//IL_3996: Expected I4, but got VT
		//IL_399e: Expected I4, but got VT
		//IL_39c6: Expected F4, but got I
		//IL_39ce: Expected Obj, but got VT
		//IL_39d7: Expected VT, but got I4
		//IL_28a9: Expected Obj, but got I4
		//IL_28ee: Expected F4, but got VT
		//IL_3a1e: Expected Obj, but got I4
		//IL_2907: Expected VT, but got I4
		//IL_3a63: Expected F4, but got VT
		//IL_3a7c: Expected VT, but got I4
		//IL_2977: Expected Obj, but got I
		//IL_2994: Expected Obj, but got I
		//IL_2b45: Invalid comparison between F4 and I
		//IL_2b7d: Expected VT, but got F8
		//IL_2b8d: Expected F8, but got I
		//IL_2ba0: Expected VT, but got I4
		//IL_3aec: Expected Obj, but got I
		//IL_3b09: Expected Obj, but got I
		//IL_3cba: Invalid comparison between F8 and I
		//IL_3cc8: Expected I4, but got VT
		//IL_3cd0: Expected I4, but got VT
		//IL_3cfa: Expected F4, but got I
		//IL_3d0d: Expected VT, but got I4
		//IL_2bd8: Expected Obj, but got I4
		//IL_4d1c: Expected VT, but got I4
		//IL_4d1c: Expected VT, but got I4
		//IL_4d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d27: Expected Obj, but got Unknown
		//IL_4d81: Expected Obj, but got VT
		//IL_4d81: Expected VT, but got Obj
		//IL_4d81: Expected VT, but got I
		//IL_4d81: Expected VT, but got I4
		//IL_4d81: Expected VT, but got I4
		//IL_4d81: Expected VT, but got Obj
		//IL_4d81: Expected VT, but got I4
		//IL_3d45: Expected Obj, but got I4
		//IL_2c0c: Expected F4, but got VT
		//IL_2c1c: Expected F8, but got I
		//IL_2c2c: Expected F4, but got I
		//IL_2c57: Expected F4, but got VT
		//IL_2c57: Expected VT, but got Obj
		//IL_2c57: Expected VT, but got I4
		//IL_4fcd: Expected VT, but got I4
		//IL_4fcd: Expected VT, but got I4
		//IL_4fd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fd8: Expected Obj, but got Unknown
		//IL_5032: Expected Obj, but got VT
		//IL_5032: Expected VT, but got I
		//IL_5032: Expected VT, but got Obj
		//IL_5032: Expected VT, but got I4
		//IL_5032: Expected VT, but got I4
		//IL_5032: Expected VT, but got Obj
		//IL_5032: Expected VT, but got I4
		//IL_2c70: Expected VT, but got I4
		//IL_2c79: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c7e: Expected Obj, but got Unknown
		//IL_2c98: Expected Obj, but got I4
		//IL_2ca1: Expected VT, but got I4
		//IL_2cab: Expected VT, but got Obj
		//IL_2cd0: Expected VT, but got F4
		//IL_2ce1: Expected VT, but got I4
		//IL_2cea: Expected VT, but got I4
		//IL_2cf4: Expected VT, but got Obj
		//IL_2d19: Expected VT, but got F4
		//IL_2d29: Expected F4, but got I
		//IL_2d41: Expected F8, but got I
		//IL_2d4e: Expected F4, but got VT
		//IL_2d58: Expected VT, but got Obj
		//IL_2d61: Expected VT, but got I4
		//IL_2d6a: Expected Obj, but got I4
		//IL_3d7e: Expected F4, but got I
		//IL_3d8e: Expected F4, but got I
		//IL_3db9: Expected F4, but got VT
		//IL_3db9: Expected VT, but got Obj
		//IL_3db9: Expected VT, but got I4
		//IL_3dd2: Expected VT, but got I4
		//IL_3ddb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3de0: Expected Obj, but got Unknown
		//IL_3dfa: Expected Obj, but got I4
		//IL_3e0d: Expected I4, but got Obj
		//IL_3e47: Expected F8, but got VT
		//IL_3e50: Expected VT, but got I4
		//IL_3e59: Expected VT, but got I4
		//IL_3e63: Expected VT, but got Obj
		//IL_3e98: Expected F4, but got I
		//IL_3eb0: Expected F4, but got I
		//IL_3ebd: Expected F8, but got VT
		//IL_3ec7: Expected VT, but got Obj
		//IL_3ed0: Expected VT, but got I4
		//IL_3ed9: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v2+E4]");
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
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = model == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		float num = Time.deltaTime;
		MonsterDirector.Entry entry = this.entry;
		Transform transform = base.transform;
		float num2 = entry.playedSize * sizeBy;
		Vector3 localScale = transform.localScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj8 = 0;
		float num3 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		bool flag7 = !(num3 > 0f);
		Vector3 vector = (Vector3)0;
		float num5 = default;
		double num9 = default;
		if (!flag7)
		{
			Transform transform2 = base.transform;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2328 @ X8_v242+A0]");
			object obj10 = 0;
			float num4 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2281 @ X8_v243+14]");
			num5 = num4 * 0f;
			float num6 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2281 @ X8_v243+10]");
			float num7 = num6 * 0f;
			float num8 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2281 @ X8_v243+C]");
			num = num8 * 0f;
			transform2.localScale = (Vector3)0;
			num9 = num7;
			vector = (Vector3)0;
		}
		bool flag8 = (byte)(~(turnedForMirror ? 1u : 0u)) != 0;
		object obj11 = 0;
		if (!flag8)
		{
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2288 @ X0_v445+E4]");
			bool flag9 = (nint)0 == 0;
			object obj13 = !flag9;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag10 = neck != null;
			bool flag11 = !flag10;
			obj11 = 0;
			if (!flag11)
			{
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2335 @ X0_v449+E4]");
				bool flag12 = (nint)0 == 0;
				object obj15 = !flag12;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag13 = skull != null;
				bool flag14 = !flag13;
				obj11 = 0;
				if (!flag14)
				{
					Quaternion localRotation = neck.localRotation;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+374]");
					object obj16 = 0;
					float num10 = num * (float)neckTurned;
					double num11 = num9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+374]");
					double num12 = num11 * 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+378]");
					object obj17 = 0;
					float num13 = num10 + (float)num12;
					float num14 = num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+378]");
					float num15 = num14 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+37C]");
					num5 = 0f;
					float num16 = num15 + num13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2281 @ X8_v243+C]");
					double num17 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+37C]");
					num9 = num17 * 0.0;
					num = (float)num9 + num16;
					float num18 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE7C]");
					if (num18 > 0f)
					{
						Quaternion localRotation2 = skull.localRotation;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+384]");
						obj16 = 0;
						float num19 = num * (float)skullTurned;
						double num20 = num9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+384]");
						double num21 = num20 * 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+388]");
						obj17 = 0;
						float num22 = num19 + (float)num21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+37C]");
						float num23 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+388]");
						float num24 = num23 * 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+38C]");
						num5 = 0f;
						float num25 = num24 + num22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2281 @ X8_v243+C]");
						double num26 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+38C]");
						num9 = num26 * 0.0;
						num = (float)num9 + num25;
						float num27 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE7C]");
						if (num27 > 0f)
						{
							neck.localRotation = (Quaternion)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+368]");
							num5 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+364]");
							num9 = 0.0;
							num = (float)skullUnturned;
							skull.localRotation = (Quaternion)0;
						}
					}
					turnedForMirror = false;
					obj11 = 0;
				}
			}
		}
		Vector3 position = head.position;
		object obj18 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2344 @ X9_v3+A0]");
		object obj19 = 0;
		bool flag20;
		float num37;
		double num39;
		if (~(placed ? 1u : 0u) == 0)
		{
			float num28 = num - (float)lastHead;
			double num29 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+174]");
			double num30 = num29 - 0.0;
			float num31 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+178]");
			float num32 = num31 - 0f;
			float num33 = num28 * num28;
			double num34 = num30 * num30;
			float num35 = num33 + (float)num34;
			float num36 = num32 * num32;
			num37 = num35 + num36;
			float num38 = num37 - 9f;
			bool flag15 = num38 < 0f;
			bool flag16 = num38 == 0f;
			object obj20 = (double)num37 ^ 9.0;
			object obj21 = num37 ^ num38;
			object obj22 = obj20 & obj21;
			bool flag17 = (nint)obj22 < 0;
			bool flag18 = flag15 == flag17;
			object obj23 = !flag16;
			bool flag19 = (byte)((flag18 & obj23) ? 1 : 0) != 0;
			num39 = 9.0;
			flag20 = flag19;
		}
		else
		{
			num39 = num9;
			num37 = num;
			flag20 = false;
		}
		float num40 = sizeBy * entry.eyeHeight;
		bool flag21 = (byte)(~(firstPerson ? 1u : 0u)) != 0;
		float num41 = num5;
		float num42 = num;
		UnityEngine.Object obj24 = null;
		double num44;
		if (flag21)
		{
			bool flag22 = !placed;
			object obj25 = !flag22;
			object obj26 = ~obj25;
			bool flag23 = obj26 != null || flag20;
			bool flag24 = !flag23;
			object obj27 = !flag24;
			float num43 = num;
			object obj28 = obj11;
			UnityEngine.Object obj29 = null;
			if (obj27 == null)
			{
				object obj30 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2511 @ X0_v431+E4]");
				bool flag25 = (nint)0 == 0;
				object obj31 = !flag25;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag26 = root != null;
				bool flag27 = !flag26;
				num42 = num;
				obj24 = null;
				if (!flag27)
				{
					Vector3 position2 = root.position;
					Vector3 position3 = root.position;
					num42 = num37;
					obj24 = null;
				}
				bool flag28 = (byte)(~(firstPerson ? 1u : 0u)) != 0;
				object obj32 = !flag28;
				num41 = num5;
				obj11 = 0;
				num43 = num42;
				obj28 = 0;
				obj29 = obj24;
				if (obj32 != null)
				{
					goto IL_06db;
				}
			}
			MonsterDirector.Entry entry2 = this.entry;
			bool flag29 = (byte)(~(entry2.hangs ? 1u : 0u)) != 0;
			num41 = num5;
			num42 = num43;
			obj11 = obj28;
			obj24 = obj29;
			if (!flag29)
			{
				num44 = 1114636288.0;
				num41 = num5;
				num42 = num43;
				obj11 = obj28;
				obj24 = obj29;
				goto IL_469f;
			}
		}
		goto IL_06db;
		IL_4b11:
		object obj33 = obj;
		object obj34 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3815 @ X0_v121+E4]");
		bool flag30 = (nint)0 == 0;
		object obj35 = !flag30;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag31 = (UnityEngine.Object)obj34 != null;
		bool flag32 = !flag31;
		Vector3 vector2;
		int num45 = (int)vector2;
		Quaternion quaternion;
		QueryTriggerInteraction queryTriggerInteraction = (QueryTriggerInteraction)quaternion;
		float num47;
		double num46 = num47;
		Transform transform3 = null;
		UnityEngine.Object obj36 = null;
		object obj45;
		Vector3 vector4;
		object obj50;
		float num48;
		float num52;
		float num54;
		Vector3 vector5 = default;
		int num57 = default;
		int num58 = default;
		float num60;
		double num64;
		float num62;
		Vector3 b = default;
		double num65;
		double num67;
		Vector3 vector8;
		float num70;
		double num71;
		Vector3 vector9;
		float num72;
		Transform transform7;
		float num68;
		Vector3 a = default;
		float num69;
		if (!flag32)
		{
			object obj37 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3846 @ X0_v126+E4]");
			bool flag33 = (nint)0 == 0;
			object obj38 = !flag33;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag34 = endR != null;
			bool flag35 = !flag34;
			num45 = (int)vector2;
			queryTriggerInteraction = (QueryTriggerInteraction)quaternion;
			num46 = num47;
			transform3 = null;
			obj36 = null;
			if (!flag35)
			{
				object obj39 = obj;
				object obj40 = this + 64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3988 @ X0_v130+E4]");
				bool flag36 = (nint)0 == 0;
				object obj41 = !flag36;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag37 = (UnityEngine.Object)obj40 != null;
				bool flag38 = !flag37;
				object obj42 = !flag38;
				object obj43 = ~obj42;
				object obj44 = ((obj43 != null) ? obj34 : obj40);
				Quaternion rotation = ((Transform)obj44).rotation;
				MonsterDirector.Entry entry3 = this.entry;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
				obj45 = 0;
				object obj46 = obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4032 @ X0_v136+E4]");
				bool flag39 = (nint)0 == 0;
				object obj47 = !flag39;
				if (obj47 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Quaternion quaternion2 = Turned(endR, i1R, p1R, vector2, quaternion, (float)entry3.palmR);
				Vector3 position4 = ((Transform)obj34).position;
				Transform transform4 = i1R;
				Transform transform5 = p1R;
				Vector3 vector3 = WristFor((Vector3)endR, i1R, p1R, (Transform)vector2, quaternion);
				MonsterDirector.Entry entry4 = this.entry;
				bool flag40 = hinge;
				bool flag41 = (byte)(~(entry4.hangs ? 1u : 0u)) != 0;
				object obj48 = !flag41;
				float num49;
				float num50;
				float num51;
				float num53;
				float num55;
				if (obj48 == null)
				{
					if (~(hinge ? 1u : 0u) != 0)
					{
						object obj49 = this + 456;
						vector4 = (Vector3)quaternion;
						obj50 = obj49;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v80 (MonsterDirector+Entry)+58]");
						num48 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v80 (MonsterDirector+Entry)+5C]");
						num49 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v80 (MonsterDirector+Entry)+58]");
						num50 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v80 (MonsterDirector+Entry)+5C]");
						num51 = 0f;
						num52 = (float)entry3.palmR;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v80 (MonsterDirector+Entry)+58]");
						num53 = 0f;
						num54 = (float)entry3.palmR;
						num55 = (float)entry3.palmR;
						goto IL_4f5a;
					}
					flag40 = true;
				}
				if (flag40)
				{
					double num56 = straightR;
				}
				else
				{
					double num56 = 1.0;
				}
				object obj51 = obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4379 @ X0_v149+E4]");
				bool flag42 = (nint)0 == 0;
				object obj52 = !flag42;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v80 (MonsterDirector+Entry)+5C]");
				float most = 0f;
				num52 = (float)entry3.palmR;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v80 (MonsterDirector+Entry)+58]");
				float straight = 0f;
				if (obj52 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v80 (MonsterDirector+Entry)+5C]");
					most = 0f;
					num52 = (float)entry3.palmR;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v80 (MonsterDirector+Entry)+58]");
					straight = 0f;
				}
				Stretch(upR, loR, endR, (Vector3)axisUpR, (Vector3)axisLoR, vector5, num57, num58, num52, straight, most);
				object obj53 = this + 456;
				if (~(hinge ? 1u : 0u) == 0)
				{
					Vector3 side = (Vector3)obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4611 @ X0_v153 (UnityEngine.Vector3)+E4]");
					bool flag43 = (nint)0 == 0;
					object obj54 = !flag43;
					if (obj54 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Vector3 vector6 = ElbowPole(side, (Vector3)loR, (Quaternion)endR);
					bool flag44 = (byte)(~(polesKnown ? 1u : 0u)) != 0;
					float num59 = num60;
					float num61 = num62;
					float num63 = (float)num64;
					Vector3 palmLocal = (Vector3)endR;
					Transform transform6 = loR;
					if (!flag44)
					{
						num62 = (float)poleR;
						Vector3 vector7 = Vector3.Internal_Slerp(ref a, ref b, (float)num65);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+228]");
						num59 = 0f;
						num61 = (float)poleR;
						num63 = (float)num65;
						palmLocal = (Vector3)0;
						transform6 = (Transform)(&b);
					}
					poleR = (Vector3)num63;
					object obj55 = obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4742 @ X0_v156+E4]");
					bool flag45 = (nint)0 == 0;
					object obj56 = !flag45;
					if (obj56 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag46 = Turns(i1R, p1R, palmLocal);
					vector4 = (Vector3)swingR;
					Transform up = upR;
					Transform lo = loR;
					Transform end = endR;
					bool flag47 = flag46;
					Swing swing = swingR;
					Vector3 pole = hingeUpR;
					float w = num52;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+204]");
					nint num66 = 0;
					Vector3 handRest = alongLoR;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+210]");
					HingeReach(up, lo, end, (Vector3)flag47, (Vector3)swing, vector5, (Vector3)num57, (Quaternion)num58, pole, w, (Quaternion)num66, (Quaternion)handRest, handTurns: false, (Swing)restRelR);
					vector2 = (Vector3)flag46;
					obj50 = obj53;
					num67 = num68;
					vector8 = hingeUpR;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v80 (MonsterDirector+Entry)+58]");
					num48 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+1F8]");
					num69 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+1F4]");
					num70 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v80 (MonsterDirector+Entry)+5C]");
					num51 = 0f;
					num71 = (double)alongUpR;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v80 (MonsterDirector+Entry)+58]");
					num53 = 0f;
					num54 = (float)entry3.palmR;
					num72 = num52;
					vector9 = (Vector3)endR;
					transform7 = loR;
					goto IL_35c8;
				}
				vector2 = (Vector3)axisUpR;
				vector4 = (Vector3)axisLoR;
				obj50 = obj53;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v80 (MonsterDirector+Entry)+58]");
				num48 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+1A8]");
				num49 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+1A4]");
				num50 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v80 (MonsterDirector+Entry)+5C]");
				num51 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v80 (MonsterDirector+Entry)+58]");
				num53 = 0f;
				num54 = (float)entry3.palmR;
				num55 = num52;
				transform5 = endR;
				transform4 = loR;
				goto IL_4f5a;
			}
		}
		goto IL_4ea0;
		IL_06db:
		float num73 = num40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
		num37 = num73 * 0f;
		num44 = (double)num37 + 0.5;
		num39 = 0.5;
		goto IL_469f;
		IL_45f6:
		MonsterDirector.Entry entry5 = this.entry;
		float num74;
		float num75;
		float num77;
		float num79;
		float num81;
		float num82;
		float num83;
		float num78;
		if (~(entry5.hangs ? 1u : 0u) == 0)
		{
			num74 = (float)num9 - num75;
			if (~(firstPerson ? 1u : 0u) == 0)
			{
				double num76 = (double)num77 * -0.5;
				bool flag48 = (double)num74 < num76;
				num78 = (float)num76;
				num79 = (float)num76;
				if (!flag48)
				{
					float num80 = num77;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
					num78 = num80 * 0f;
					bool flag49 = !(num74 > num78);
					num79 = num74;
					if (!flag49)
					{
						num74 = num78;
						goto IL_0fb1;
					}
				}
				goto IL_4605;
			}
			num78 = (float)num9 - num81;
			num74 = Propped(num74, num78, num81, num82);
			num83 = num81;
		}
		else
		{
			num78 = num75;
			num74 = 0f;
		}
		goto IL_0fb1;
		IL_4f5a:
		object obj57 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4369 @ X0_v145+E4]");
		bool flag50 = (nint)0 == 0;
		object obj58 = !flag50;
		if (obj58 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Reach(upR, loR, endR, vector2, vector4, vector5, num52);
		num67 = -1.0;
		float num84;
		vector8 = (Vector3)num84;
		num69 = num62;
		num70 = num60;
		num71 = num64;
		num72 = num52;
		vector9 = (Vector3)endR;
		transform7 = loR;
		goto IL_35c8;
		IL_4ea0:
		polesKnown = true;
		twistsKnown = true;
		double num86;
		double num85 = num86;
		goto IL_5424;
		IL_5424:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
		object obj59 = 0;
		object obj60 = obj59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3560 @ X0_v75+E4]");
		bool flag51 = (nint)0 == 0;
		object obj61 = !flag51;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Copy(fingerSourceL, posL);
		Copy(fingerSourceR, posR);
		MonsterDirector.Entry entry6 = this.entry;
		bool flag52 = (byte)(~(entry6.onArms ? 1u : 0u)) != 0;
		float num87 = (float)num46;
		UnityEngine.Object obj62 = posR;
		float num88;
		if (!flag52)
		{
			object obj63 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3662 @ X0_v102+E4]");
			bool flag53 = (nint)0 == 0;
			object obj64 = !flag53;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag54 = events != null;
			bool flag55 = !flag54;
			num87 = (float)num46;
			transform3 = null;
			obj62 = null;
			if (!flag55)
			{
				Stomps(num88);
				num87 = num88;
				transform3 = null;
				obj62 = null;
			}
		}
		if (~(firstPerson ? 1u : 0u) != 0)
		{
			return;
		}
		MonsterDirector.Entry entry7 = this.entry;
		object obj65 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3822 @ X0_v80+E4]");
		bool flag56 = (nint)0 == 0;
		object obj66 = !flag56;
		if (obj66 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num91;
		if (entry7.firstPersonMesh == null)
		{
			object obj67 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3967 @ X0_v84+E4]");
			bool flag57 = (nint)0 == 0;
			object obj68 = !flag57;
			if (obj68 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag58 = skull != null;
			bool flag59 = !flag58;
			Vector3 vector10 = (Vector3)0;
			if (!flag59)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DDA8AC");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
				num85 = 0.0;
				float num89 = num68;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
				num68 = num89 * 0f;
				float num90 = num91;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
				num91 = num90 * 0f;
				float num92 = num87;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
				num87 = num92 * 0f;
				skull.localScale = (Vector3)0;
				vector10 = (Vector3)0;
			}
			object obj69 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4006 @ X0_v89+E4]");
			bool flag60 = (nint)0 == 0;
			object obj70 = !flag60;
			if (obj70 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (neck != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DDA8AC");
				neck.localScale = (Vector3)0;
			}
		}
		return;
		IL_5291:
		float num93;
		yaw = num93;
		Transform transform8 = base.transform;
		float num94 = yaw;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
		float num95 = num94 * 0f;
		Quaternion quaternion3 = Quaternion.Internal_FromEulerRad(ref a);
		float num96 = num40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1066 @ X9_v4+24]");
		float num97 = num96 * 0f;
		float num98 = num40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1066 @ X9_v4+2C]");
		float num99 = num98 * 0f;
		float num100 = num + num97;
		num83 = num5 + num99;
		Quaternion rotation2;
		transform8.SetPositionAndRotation((Vector3)0, rotation2);
		bool flag61 = (byte)(~(firstPerson ? 1u : 0u)) != 0;
		object obj71 = !flag61;
		if (obj71 == null)
		{
			Look(num82);
			num100 = num82;
		}
		object obj72 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2792 @ X0_v41+E4]");
		bool flag62 = (nint)0 == 0;
		object obj73 = !flag62;
		if (obj73 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag63 = eyeL != null;
		bool flag64 = !flag63;
		object obj74 = 0;
		UnityEngine.Object obj75 = null;
		double num102;
		object obj78;
		if (!flag64)
		{
			object obj76 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2805 @ X0_v406+E4]");
			bool flag65 = (nint)0 == 0;
			object obj77 = !flag65;
			if (obj77 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag66 = eyeR != null;
			bool flag67 = !flag66;
			obj74 = 0;
			obj75 = null;
			if (!flag67)
			{
				Vector3 position5 = eyeL.position;
				Vector3 position6 = eyeR.position;
				float num101 = num81 + num81;
				num83 += num83;
				num75 = num101 * 0.5f;
				num102 = (double)num83 * 0.5;
				num77 = num40;
				obj78 = 0;
				goto IL_45f6;
			}
		}
		object obj79 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2816 @ X0_v399+E4]");
		bool flag68 = (nint)0 == 0;
		object obj80 = !flag68;
		if (obj80 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag69 = skull != null;
		bool flag70 = !flag69;
		num75 = (float)num9;
		num77 = num40;
		num102 = num5;
		obj78 = 0;
		if (!flag70)
		{
			Vector3 position7 = skull.position;
			num75 = (float)num9;
			num77 = num40;
			num102 = num83;
			obj78 = 0;
		}
		goto IL_45f6;
		IL_1875:
		bool flag71 = (byte)(~(firstPerson ? 1u : 0u)) != 0;
		object obj81 = !flag71;
		double num103 = 1.0;
		num64 = 1.0;
		float num105;
		float num114;
		float num113;
		if (obj81 == null)
		{
			MonsterDirector.Entry entry8 = this.entry;
			bool flag72 = (byte)(~(entry8.onArms ? 1u : 0u)) != 0;
			object obj82 = !flag72;
			num103 = 1.0;
			num64 = 1.0;
			if (obj82 == null)
			{
				float num104 = num105;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
				float num106 = num104 * 0f;
				float num107 = num105;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB6C]");
				num62 = num107 * 0f;
				bool flag73 = num106 == num62;
				double num108 = 0.0;
				if (!flag73)
				{
					float num109 = speed - num106;
					float num110 = num62 - num106;
					float num111 = num109 / num110;
					bool flag74 = num111 < 0f;
					num86 = num109;
					num108 = 0.0;
					if (!flag74)
					{
						bool flag75 = !((double)num111 > 1.0);
						num86 = num109;
						num108 = num111;
						if (!flag75)
						{
							num86 = num109;
							num108 = 1.0;
						}
					}
				}
				num60 = 1f - (float)num108;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				num64 = 0.0;
				float num112 = num60;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				bool flag76 = !(num112 > 0f);
				num103 = num60;
				num45 = 0;
				num113 = num114;
				num68 = num62;
				num85 = num86;
				num91 = num60;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				num46 = 0.0;
				if (flag76)
				{
					goto IL_5424;
				}
			}
		}
		Transform transform9 = base.transform;
		Vector3 right = transform9.right;
		Transform transform10 = base.transform;
		Vector3 forward = transform10.forward;
		float num115 = num88 * -20f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		object obj83 = obj;
		object obj84 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3623 @ X0_v116+E4]");
		bool flag77 = (nint)0 == 0;
		object obj85 = !flag77;
		if (obj85 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		num84 = (float)(0.0 - num64);
		object obj86 = 0f - num60;
		object obj87 = 0f - num62;
		num65 = 1.0 - (double)num115;
		bool flag78 = (UnityEngine.Object)obj84 != null;
		bool flag79 = !flag78;
		vector2 = (Vector3)0;
		quaternion = (Quaternion)queryTriggerInteraction;
		num113 = num114;
		a = (Vector3)num74;
		num68 = num62;
		num91 = num84;
		num47 = (float)num65;
		Transform transform11 = null;
		Transform transform12 = null;
		object obj96;
		Vector3 vector12;
		object obj101;
		float num116;
		float num120;
		float num122;
		double num126;
		Vector3 vector19;
		float num127;
		double num128;
		Vector3 vector20;
		float num129;
		Transform transform16;
		if (!flag79)
		{
			object obj88 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3682 @ X0_v224+E4]");
			bool flag80 = (nint)0 == 0;
			object obj89 = !flag80;
			if (obj89 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag81 = endL != null;
			bool flag82 = !flag81;
			vector2 = (Vector3)0;
			quaternion = (Quaternion)queryTriggerInteraction;
			num113 = num114;
			a = (Vector3)num74;
			num68 = num62;
			num91 = num84;
			num47 = (float)num65;
			transform11 = null;
			transform12 = null;
			if (!flag82)
			{
				object obj90 = obj;
				object obj91 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3841 @ X0_v228+E4]");
				bool flag83 = (nint)0 == 0;
				object obj92 = !flag83;
				if (obj92 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag84 = (UnityEngine.Object)obj91 != null;
				bool flag85 = !flag84;
				object obj93 = !flag85;
				object obj94 = ~obj93;
				object obj95 = ((obj94 != null) ? obj84 : obj91);
				Quaternion rotation3 = ((Transform)obj95).rotation;
				MonsterDirector.Entry entry9 = this.entry;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
				obj96 = 0;
				object obj97 = obj96;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4022 @ X0_v234+E4]");
				bool flag86 = (nint)0 == 0;
				object obj98 = !flag86;
				if (obj98 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Quaternion quaternion4 = Turned(endL, i1L, p1L, (Vector3)0, (Quaternion)queryTriggerInteraction, (float)entry9.palmL);
				Vector3 position8 = ((Transform)obj84).position;
				Transform transform13 = i1L;
				Transform transform14 = p1L;
				Vector3 vector11 = WristFor((Vector3)endL, i1L, p1L, null, (Quaternion)queryTriggerInteraction);
				MonsterDirector.Entry entry10 = this.entry;
				bool flag87 = hinge;
				bool flag88 = (byte)(~(entry10.hangs ? 1u : 0u)) != 0;
				object obj99 = !flag88;
				float num117;
				float num118;
				float num119;
				float num121;
				if (obj99 == null)
				{
					if (~(hinge ? 1u : 0u) != 0)
					{
						object obj100 = this + 456;
						vector2 = (Vector3)0;
						vector12 = (Vector3)queryTriggerInteraction;
						obj101 = obj100;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v119 (MonsterDirector+Entry)+4C]");
						num116 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v119 (MonsterDirector+Entry)+50]");
						num117 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v119 (MonsterDirector+Entry)+4C]");
						num118 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v119 (MonsterDirector+Entry)+50]");
						num119 = 0f;
						num120 = (float)entry9.palmL;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v119 (MonsterDirector+Entry)+4C]");
						num121 = 0f;
						num122 = (float)entry9.palmL;
						goto IL_4beb;
					}
					flag87 = true;
				}
				if (flag87)
				{
					double num123 = straightL;
				}
				else
				{
					double num123 = 1.0;
				}
				object obj102 = obj96;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4154 @ X0_v247+E4]");
				bool flag89 = (nint)0 == 0;
				object obj103 = !flag89;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v119 (MonsterDirector+Entry)+50]");
				float most2 = 0f;
				num120 = (float)entry9.palmL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v119 (MonsterDirector+Entry)+4C]");
				float straight2 = 0f;
				if (obj103 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v119 (MonsterDirector+Entry)+50]");
					most2 = 0f;
					num120 = (float)entry9.palmL;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v119 (MonsterDirector+Entry)+4C]");
					straight2 = 0f;
				}
				Stretch(upL, loL, endL, (Vector3)axisUpL, (Vector3)axisLoL, vector5, num57, num58, num120, straight2, most2);
				object obj104 = this + 456;
				if (~(hinge ? 1u : 0u) == 0)
				{
					Vector3 side2 = (Vector3)obj96;
					Vector3 vector13 = (Vector3)(0.0 - num64);
					object obj105 = 0f - num60;
					Vector3 vector14 = (Vector3)(0f - num62);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4387 @ X0_v251 (UnityEngine.Vector3)+E4]");
					bool flag90 = (nint)0 == 0;
					object obj106 = !flag90;
					if (obj106 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Vector3 vector15 = ElbowPole(side2, (Vector3)loL, (Quaternion)endL);
					bool flag91 = (byte)(~(polesKnown ? 1u : 0u)) != 0;
					a = (Vector3)num74;
					object obj107 = obj105;
					Vector3 vector16 = vector14;
					Vector3 vector17 = vector14;
					float num124 = (float)vector13;
					Vector3 palmLocal2 = (Vector3)endL;
					Transform transform15 = loL;
					if (!flag91)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X28_v4+98]");
						vector16 = (Vector3)0;
						Vector3 vector18 = Vector3.Internal_Slerp(ref a, ref b, (float)num65);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X28_v4+98]");
						a = (Vector3)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+21C]");
						obj107 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X28_v4+98]");
						vector17 = (Vector3)0;
						num124 = (float)num65;
						palmLocal2 = (Vector3)0;
						transform15 = (Transform)(&b);
					}
					poleL = (Vector3)num124;
					object obj108 = obj96;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4591 @ X0_v254+E4]");
					bool flag92 = (nint)0 == 0;
					object obj109 = !flag92;
					if (obj109 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag93 = Turns(i1L, p1L, palmLocal2);
					vector12 = (Vector3)swingL;
					Transform up2 = upL;
					Transform lo2 = loL;
					Transform end2 = endL;
					bool flag94 = flag93;
					Swing swing2 = swingL;
					Vector3 pole2 = hingeUpL;
					float w2 = num120;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+1E0]");
					nint num125 = 0;
					Vector3 handRest2 = alongLoL;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+1EC]");
					HingeReach(up2, lo2, end2, (Vector3)flag94, (Vector3)swing2, vector5, (Vector3)num57, (Quaternion)num58, pole2, w2, (Quaternion)num125, (Quaternion)handRest2, handTurns: false, (Swing)restRelL);
					vector2 = (Vector3)flag93;
					obj101 = obj104;
					num126 = num62;
					vector19 = hingeUpL;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v119 (MonsterDirector+Entry)+4C]");
					num116 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+1D4]");
					num69 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+1D0]");
					num127 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v119 (MonsterDirector+Entry)+50]");
					num119 = 0f;
					num128 = (double)alongUpL;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v119 (MonsterDirector+Entry)+4C]");
					num121 = 0f;
					num122 = (float)entry9.palmL;
					num129 = num120;
					vector20 = (Vector3)endL;
					transform16 = loL;
					goto IL_244b;
				}
				vector2 = (Vector3)axisUpL;
				vector12 = (Vector3)axisLoL;
				obj101 = obj104;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v119 (MonsterDirector+Entry)+4C]");
				num116 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+190]");
				num117 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+18C]");
				num118 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v119 (MonsterDirector+Entry)+50]");
				num119 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v119 (MonsterDirector+Entry)+4C]");
				num121 = 0f;
				num122 = (float)entry9.palmL;
				transform14 = endL;
				transform13 = loL;
				goto IL_4beb;
			}
		}
		goto IL_4b11;
		IL_4605:
		Transform transform17 = base.transform;
		double num130 = (double)num5 - num102;
		Quaternion rotation4 = transform17.rotation;
		Quaternion rotation5 = default;
		Quaternion quaternion5 = Quaternion.Internal_Inverse(ref rotation5);
		Vector3 vector21 = (Quaternion)0 * (Vector3)0;
		object obj110 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2932 @ X8_v41+A0]");
		object obj111 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj112 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2936 @ X8_v42+18]");
		object obj114 = default;
		object obj113 = 0 * obj114;
		float num131 = num79;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2936 @ X8_v42+20]");
		float num132 = num131 * 0f;
		float num133 = num74 + (float)obj113;
		num105 = num83 + num132;
		bool flag95 = (byte)(~(firstPerson ? 1u : 0u)) != 0;
		object obj115 = !flag95;
		UnityEngine.Object obj116 = null;
		object obj125;
		float num159;
		float num160;
		float num162;
		object obj131;
		double num161;
		if (obj115 == null)
		{
			object obj117 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2942 @ X0_v362+E4]");
			bool flag96 = (nint)0 == 0;
			object obj118 = !flag96;
			if (obj118 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag97 = skull == null;
			bool flag98 = !flag97;
			obj78 = 0;
			obj116 = null;
			if (flag98)
			{
				Vector3 position9 = skull.position;
				object obj119 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3069 @ X8_v194+A0]");
				object obj120 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1440 @ X21_v6+99F]");
				bool flag99 = (nint)0 == 0;
				object obj121 = !flag99;
				if (obj121 == null)
				{
					_ = 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3070 @ X8_v195+18]");
				nint num134 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3070 @ X8_v195+18]");
				object obj122 = num134 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3070 @ X8_v195+1C]");
				nint num135 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3070 @ X8_v195+1C]");
				object obj123 = num135 * 0;
				object obj124 = obj125;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3089 @ X8_v197+A0]");
				object obj126 = 0;
				object obj127 = obj122 + obj123;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3070 @ X8_v195+20]");
				nint num136 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3070 @ X8_v195+20]");
				object obj128 = num136 * 0;
				float num137 = (float)obj126;
				float num138 = (float)obj128 + (float)obj127;
				float num139 = num - num74;
				float num140 = (float)num9 - num78;
				bool flag100 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num138) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj126);
				float num141 = num5 - num132;
				float num142 = num5;
				if (!flag100)
				{
					float num143 = num139;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3070 @ X8_v195+18]");
					float num144 = num143 * 0f;
					float num145 = num140;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3070 @ X8_v195+1C]");
					float num146 = num145 * 0f;
					float num147 = num141;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3070 @ X8_v195+20]");
					num137 = num147 * 0f;
					float num148 = num144 + num146;
					float num149 = num137 + num148;
					float num150 = num149 / num138;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3070 @ X8_v195+18]");
					num78 = 0f * num150;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3070 @ X8_v195+1C]");
					num142 = 0f * num150;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3070 @ X8_v195+20]");
					num138 = 0f * num150;
					num139 -= num78;
					num140 -= num142;
					num141 -= num138;
				}
				object obj129 = obj112;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3156 @ X0_v371+E4]");
				bool flag101 = (nint)0 == 0;
				object obj130 = !flag101;
				if (obj130 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num151 = num139 * num139;
				float num152 = num140 * num140;
				float num153 = num151 + num152;
				float num154 = num141 * num141;
				float num155 = num153 + num154;
				Vector3 position10 = skull.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				obj131 = obj112;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3015 @ X0_v350+E4]");
				bool flag102 = (nint)0 == 0;
				object obj132 = !flag102;
				if (obj132 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num156 = (float)num102 - num142;
				float num157 = num156 * num156;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				float num158 = num155 + num157;
				num159 = num79 + num158;
				num88 = num82;
				num160 = num5;
				num161 = num9;
				num162 = num79;
				obj78 = 0;
				obj116 = null;
				goto IL_4a34;
			}
		}
		obj131 = obj112;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3015 @ X0_v350+E4]");
		bool flag103 = (nint)0 == 0;
		object obj133 = !flag103;
		if (obj133 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		num159 = num105 * num105;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		num88 = num82;
		num160 = num5;
		num161 = num9;
		num162 = num79;
		goto IL_4a34;
		IL_4beb:
		object obj134 = obj96;
		double num163 = 0.0 - num64;
		float num164 = 0f - num60;
		float num165 = 0f - num62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4139 @ X0_v243+E4]");
		bool flag104 = (nint)0 == 0;
		object obj135 = !flag104;
		if (obj135 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Reach(upL, loL, endL, vector2, vector12, vector5, num120);
		num126 = 1.0;
		vector19 = (Vector3)num84;
		a = (Vector3)num74;
		num69 = num165;
		num127 = num164;
		num128 = num163;
		num129 = num120;
		vector20 = (Vector3)endL;
		transform16 = loL;
		goto IL_244b;
		IL_35c8:
		MonsterDirector.Entry entry11 = this.entry;
		object obj136 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4554 @ X0_v167+E4]");
		bool flag105 = (nint)0 == 0;
		object obj137 = !flag105;
		if (obj137 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag106 = Turns(i1R, p1R, vector9);
		bool flag107 = !flag106;
		double num166 = (double)vector8;
		Quaternion quaternion6 = (Quaternion)p1R;
		if (!flag107)
		{
			Quaternion rotation6 = endR.rotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE5E34");
			endR.rotation = (Quaternion)0;
			num67 = num47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v80 (MonsterDirector+Entry)+5C]");
			num166 = 0.0;
			num69 = num48;
			num70 = num54;
			quaternion6 = (Quaternion)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC2C]");
		num46 = 0.0;
		double num167 = num103;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC2C]");
		bool flag108 = !(num167 > 0.0);
		num45 = (int)vector2;
		queryTriggerInteraction = (QueryTriggerInteraction)vector4;
		num113 = (float)num67;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2209 @ X8_v94 (MonsterDirector+Entry)+5C]");
		float num168 = 0f;
		float num169 = (float)num103;
		Transform transform18 = (Transform)vector9;
		if (!flag108)
		{
			Quaternion quaternion7 = (Quaternion)vector4;
			float num170 = (float)num67;
			double num171 = num166;
			float num172 = num69;
			float num173 = num70;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2209 @ X8_v94 (MonsterDirector+Entry)+5C]");
			float num174 = 0f;
			double num175 = num71;
			float num176 = (float)num103;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
			double num177 = 0.0;
			Quaternion quaternion8 = quaternion6;
			object obj138 = 1;
			object obj149;
			do
			{
				bool flag109 = obj50 == null;
				num45 = (int)vector2;
				queryTriggerInteraction = (QueryTriggerInteraction)quaternion7;
				num113 = num170;
				num166 = num171;
				num69 = num172;
				num70 = num173;
				num168 = num174;
				num71 = num175;
				num169 = num176;
				num46 = num177;
				transform18 = (Transform)vector9;
				quaternion6 = quaternion8;
				if (flag109)
				{
					break;
				}
				MonsterDirector.Entry entry12 = this.entry;
				object obj139 = obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4812 @ X0_v183+E4]");
				bool flag110 = (nint)0 == 0;
				object obj140 = !flag110;
				if (obj140 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag111 = Turns(i1R, p1R, vector9);
				bool flag112 = !flag111;
				num45 = (int)vector2;
				queryTriggerInteraction = (QueryTriggerInteraction)quaternion7;
				num113 = num170;
				num166 = num171;
				num69 = num172;
				num70 = num173;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2210 @ X8_v102 (MonsterDirector+Entry)+5C]");
				num168 = 0f;
				num71 = num175;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2210 @ X8_v102 (MonsterDirector+Entry)+58]");
				num169 = 0f;
				num46 = (double)entry12.palmR;
				transform18 = (Transform)vector9;
				quaternion6 = (Quaternion)p1R;
				if (flag112)
				{
					break;
				}
				Vector3 localScale2 = upR.localScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+1A4]");
				num70 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2210 @ X8_v102 (MonsterDirector+Entry)+58]");
				float num178 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+1A4]");
				float num179 = num178 - 0f;
				double num180 = (double)entry12.palmR - (double)restUpR;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+1A8]");
				num71 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2210 @ X8_v102 (MonsterDirector+Entry)+5C]");
				float num181 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+1A8]");
				num168 = num181 - 0f;
				double num182 = num180 * num180;
				float num183 = num179 * num179;
				double num184 = num182 + (double)num183;
				float num185 = num168 * num168;
				num46 = (double)num185 + num184;
				double num186 = num46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
				bool flag113 = num186 < 0.0;
				num45 = (int)vector2;
				queryTriggerInteraction = (QueryTriggerInteraction)quaternion7;
				num113 = num170;
				num166 = num171;
				num69 = num172;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
				num169 = 0f;
				transform18 = (Transform)vector9;
				quaternion6 = (Quaternion)0;
				if (flag113)
				{
					break;
				}
				MonsterDirector.Entry entry13 = this.entry;
				object obj141 = obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4870 @ X0_v189+E4]");
				bool flag114 = (nint)0 == 0;
				object obj142 = !flag114;
				if (obj142 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Quaternion quaternion9 = Turned(endR, i1R, p1R, vector2, quaternion7, (float)entry13.palmR);
				endR.rotation = (Quaternion)0;
				Vector3 position11 = ((Transform)obj34).position;
				Vector3 position12 = i1R.position;
				Vector3 position13 = p1R.position;
				Vector3 position14 = endR.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2211 @ X8_v103 (MonsterDirector+Entry)+58]");
				nint num187 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2211 @ X8_v103 (MonsterDirector+Entry)+58]");
				object obj143 = num187 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2211 @ X8_v103 (MonsterDirector+Entry)+5C]");
				nint num188 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2211 @ X8_v103 (MonsterDirector+Entry)+5C]");
				object obj144 = num188 + 0;
				float num189 = (float)entry13.palmR + (float)entry13.palmR;
				num70 = (float)obj143 * 0.5f;
				num71 = (double)obj144 * 0.5;
				num69 = num189 * 0.5f;
				float num190 = num70;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2211 @ X8_v103 (MonsterDirector+Entry)+58]");
				float num191 = num190 - 0f;
				double num192 = num71;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2211 @ X8_v103 (MonsterDirector+Entry)+5C]");
				double num193 = num192 - 0.0;
				float num194 = num69 - (float)entry13.palmR;
				float num195 = num191 * 0.5f;
				double num196 = num193 * 0.5;
				float num197 = num194 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2211 @ X8_v103 (MonsterDirector+Entry)+58]");
				float num198 = 0f - num195;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2211 @ X8_v103 (MonsterDirector+Entry)+5C]");
				double num199 = 0.0 - num196;
				float num200 = (float)entry13.palmR - num197;
				Vector3 position15 = endR.position;
				float num201 = num200 - num197;
				float num202 = num198 - (float)entry13.palmR;
				num168 = (float)num199 - (float)num196;
				float num203 = num201 * num201;
				float num204 = num202 * num202;
				float num205 = num203 + num204;
				float num206 = num168 * num168;
				num46 = (double)num206 + (double)num205;
				double num207 = num46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
				bool flag115 = num207 < 0.0;
				num45 = (int)vector2;
				queryTriggerInteraction = (QueryTriggerInteraction)quaternion7;
				num113 = -1f;
				num166 = 0.5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
				num169 = 0f;
				transform18 = p1R;
				quaternion6 = (Quaternion)0;
				if (flag115)
				{
					break;
				}
				object obj145 = obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4966 @ X0_v204+E4]");
				bool flag116 = (nint)0 == 0;
				object obj146 = !flag116;
				if (obj146 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Stretch(upR, loR, endR, (Vector3)axisUpR, (Vector3)axisLoR, vector5, num57, num58, num200, num198, (float)num199);
				object obj147 = this + 508;
				Transform up3 = upR;
				Transform lo3 = loR;
				Transform end3 = endR;
				Swing swing3 = swingR;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+204]");
				nint num208 = 0;
				Vector3 handRest3 = alongLoR;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+210]");
				HingeReach(up3, lo3, end3, (Vector3)1, (Vector3)swing3, vector5, (Vector3)num57, (Quaternion)num58, (Vector3)obj147, num200, (Quaternion)num208, (Quaternion)handRest3, handTurns: false, (Swing)restRelR);
				MonsterDirector.Entry entry14 = this.entry;
				transform18 = p1R;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2213 @ X8_v111 (MonsterDirector+Entry)+58]");
				num169 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2213 @ X8_v111 (MonsterDirector+Entry)+5C]");
				num168 = 0f;
				Quaternion quaternion10 = Turned(endR, i1R, p1R, (Vector3)1, (Quaternion)swingR, (float)entry14.palmR);
				endR.rotation = (Quaternion)0;
				object obj148 = obj138 & 1;
				bool flag117 = obj148 == null;
				obj149 = !flag117;
				num45 = 1;
				queryTriggerInteraction = (QueryTriggerInteraction)swingR;
				num113 = -1f;
				num166 = num86;
				num69 = num68;
				num70 = num91;
				num71 = num47;
				num46 = (double)entry14.palmR;
				quaternion6 = (Quaternion)0;
				vector2 = (Vector3)1;
				quaternion7 = (Quaternion)swingR;
				num170 = -1f;
				num171 = num86;
				num172 = num68;
				num173 = num91;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2213 @ X8_v111 (MonsterDirector+Entry)+5C]");
				num174 = 0f;
				num175 = num47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2213 @ X8_v111 (MonsterDirector+Entry)+58]");
				num176 = 0f;
				num177 = (double)entry14.palmR;
				vector9 = (Vector3)p1R;
				quaternion8 = (Quaternion)0;
				obj138 = 0;
			}
			while (obj149 != null);
		}
		object obj150 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4737 @ X0_v173+E4]");
		bool flag118 = (nint)0 == 0;
		object obj151 = !flag118;
		if (obj151 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag119 = twistR != null;
		bool flag120 = !flag119;
		num88 = num82;
		Vector3 vector22 = (Vector3)num70;
		num68 = num168;
		num86 = num71;
		num91 = num169;
		transform3 = null;
		obj36 = null;
		if (!flag120)
		{
			object obj152 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+2AC]");
			num91 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+2B0]");
			num68 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+2B4]");
			num86 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+2CC]");
			num69 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+2D0]");
			num166 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+2D4]");
			num113 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4815 @ X0_v177+E4]");
			bool flag121 = (nint)0 == 0;
			object obj153 = !flag121;
			vector22 = (Vector3)handRestR;
			if (obj153 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				vector22 = (Vector3)handRestR;
			}
			bool flag122 = !twistsKnown;
			Quaternion quaternion11 = (Quaternion)(this + 756);
			Quaternion quaternion12 = (Quaternion)(!flag122);
			Twist(twistR, loR, endR, quaternion11, quaternion12, vector5, ref *(float*)num57, (byte)num58 != 0, (float)twistRestR);
			num45 = (int)quaternion11;
			queryTriggerInteraction = (QueryTriggerInteraction)quaternion12;
			num88 = num82;
			num46 = (double)twistRestR;
			transform3 = endR;
			obj36 = loR;
		}
		goto IL_4ea0;
		IL_244b:
		MonsterDirector.Entry entry15 = this.entry;
		object obj154 = obj96;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4295 @ X0_v265+E4]");
		bool flag123 = (nint)0 == 0;
		object obj155 = !flag123;
		if (obj155 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag124 = Turns(i1L, p1L, vector20);
		bool flag125 = !flag124;
		num166 = (double)vector19;
		Quaternion quaternion13 = (Quaternion)p1L;
		if (!flag125)
		{
			Quaternion rotation7 = endL.rotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE5E34");
			endL.rotation = (Quaternion)0;
			num126 = num65;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X8_v119 (MonsterDirector+Entry)+50]");
			num166 = 0.0;
			num69 = num116;
			num127 = num122;
			quaternion13 = (Quaternion)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC2C]");
		num47 = 0f;
		double num209 = num103;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC2C]");
		bool flag126 = !(num209 > 0.0);
		quaternion = (Quaternion)vector12;
		num113 = (float)num126;
		vector22 = (Vector3)num127;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2202 @ X8_v133 (MonsterDirector+Entry)+50]");
		num68 = 0f;
		double num210 = num103;
		Transform transform19 = (Transform)vector20;
		if (!flag126)
		{
			Vector3 vector23 = vector2;
			Quaternion quaternion14 = (Quaternion)vector12;
			float num211 = (float)num126;
			double num212 = num166;
			float num213 = num69;
			Vector3 vector24 = (Vector3)num127;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2202 @ X8_v133 (MonsterDirector+Entry)+50]");
			float num214 = 0f;
			double num215 = num128;
			double num216 = num103;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
			float num217 = 0f;
			Quaternion quaternion15 = quaternion13;
			object obj156 = 1;
			object obj167;
			do
			{
				bool flag127 = obj101 == null;
				vector2 = vector23;
				quaternion = quaternion14;
				num113 = num211;
				num166 = num212;
				num69 = num213;
				vector22 = vector24;
				num68 = num214;
				num128 = num215;
				num210 = num216;
				num47 = num217;
				transform19 = (Transform)vector20;
				quaternion13 = quaternion15;
				if (flag127)
				{
					break;
				}
				MonsterDirector.Entry entry16 = this.entry;
				object obj157 = obj96;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4701 @ X0_v281+E4]");
				bool flag128 = (nint)0 == 0;
				object obj158 = !flag128;
				if (obj158 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag129 = Turns(i1L, p1L, vector20);
				bool flag130 = !flag129;
				vector2 = vector23;
				quaternion = quaternion14;
				num113 = num211;
				num166 = num212;
				num69 = num213;
				vector22 = vector24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2203 @ X8_v141 (MonsterDirector+Entry)+50]");
				num68 = 0f;
				num128 = num215;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2203 @ X8_v141 (MonsterDirector+Entry)+4C]");
				num210 = 0.0;
				num47 = (float)entry16.palmL;
				transform19 = (Transform)vector20;
				quaternion13 = (Quaternion)p1L;
				if (flag130)
				{
					break;
				}
				Vector3 localScale3 = upL.localScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+18C]");
				vector22 = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2203 @ X8_v141 (MonsterDirector+Entry)+4C]");
				double num218 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+18C]");
				double num219 = num218 - 0.0;
				float num220 = (float)entry16.palmL - (float)restUpL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+190]");
				num128 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2203 @ X8_v141 (MonsterDirector+Entry)+50]");
				float num221 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+190]");
				num68 = num221 - 0f;
				float num222 = num220 * num220;
				double num223 = num219 * num219;
				float num224 = num222 + (float)num223;
				float num225 = num68 * num68;
				num47 = num225 + num224;
				float num226 = num47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
				bool flag131 = num226 < 0f;
				vector2 = vector23;
				quaternion = quaternion14;
				num113 = num211;
				num166 = num212;
				num69 = num213;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
				num210 = 0.0;
				transform19 = (Transform)vector20;
				quaternion13 = (Quaternion)0;
				if (flag131)
				{
					break;
				}
				MonsterDirector.Entry entry17 = this.entry;
				object obj159 = obj96;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4855 @ X0_v287+E4]");
				bool flag132 = (nint)0 == 0;
				object obj160 = !flag132;
				if (obj160 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Quaternion quaternion16 = Turned(endL, i1L, p1L, vector23, quaternion14, (float)entry17.palmL);
				endL.rotation = (Quaternion)0;
				Vector3 position16 = ((Transform)obj84).position;
				Vector3 position17 = i1L.position;
				Vector3 position18 = p1L.position;
				Vector3 position19 = endL.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2204 @ X8_v142 (MonsterDirector+Entry)+4C]");
				nint num227 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2204 @ X8_v142 (MonsterDirector+Entry)+4C]");
				object obj161 = num227 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2204 @ X8_v142 (MonsterDirector+Entry)+50]");
				nint num228 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2204 @ X8_v142 (MonsterDirector+Entry)+50]");
				object obj162 = num228 + 0;
				float num229 = (float)entry17.palmL + (float)entry17.palmL;
				double num230 = (double)obj161 * 0.5;
				num128 = (double)obj162 * 0.5;
				num69 = num229 * 0.5f;
				double num231 = num230;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2204 @ X8_v142 (MonsterDirector+Entry)+4C]");
				double num232 = num231 - 0.0;
				double num233 = num128;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2204 @ X8_v142 (MonsterDirector+Entry)+50]");
				double num234 = num233 - 0.0;
				float num235 = num69 - (float)entry17.palmL;
				double num236 = num232 * 0.5;
				double num237 = num234 * 0.5;
				float num238 = num235 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2204 @ X8_v142 (MonsterDirector+Entry)+4C]");
				double num239 = 0.0 - num236;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2204 @ X8_v142 (MonsterDirector+Entry)+50]");
				double num240 = 0.0 - num237;
				float num241 = (float)entry17.palmL - num238;
				Vector3 position20 = endL.position;
				float num242 = num241 - num238;
				double num243 = num239 - (double)entry17.palmL;
				num68 = (float)num240 - (float)num237;
				float num244 = num242 * num242;
				double num245 = num243 * num243;
				float num246 = num244 + (float)num245;
				float num247 = num68 * num68;
				num47 = num247 + num246;
				float num248 = num47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
				bool flag133 = num248 < 0f;
				vector2 = vector23;
				quaternion = quaternion14;
				num113 = 1f;
				num166 = 0.5;
				vector22 = (Vector3)num230;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
				num210 = 0.0;
				transform19 = p1L;
				quaternion13 = (Quaternion)0;
				if (flag133)
				{
					break;
				}
				object obj163 = obj96;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4903 @ X0_v302+E4]");
				bool flag134 = (nint)0 == 0;
				object obj164 = !flag134;
				if (obj164 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Stretch(upL, loL, endL, (Vector3)axisUpL, (Vector3)axisLoL, vector5, num57, num58, num241, (float)num239, (float)num240);
				object obj165 = this + 484;
				Transform up4 = upL;
				Transform lo4 = loL;
				Transform end4 = endL;
				Swing swing4 = swingL;
				Vector3 pole3 = hingeUpL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+1E0]");
				nint num249 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+1EC]");
				HingeReach(up4, lo4, end4, (Vector3)1, (Vector3)swing4, vector5, (Vector3)num57, (Quaternion)num58, pole3, num241, (Quaternion)num249, (Quaternion)obj165, handTurns: false, (Swing)restRelL);
				MonsterDirector.Entry entry18 = this.entry;
				transform19 = p1L;
				num47 = (float)entry18.palmL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2206 @ X8_v149 (MonsterDirector+Entry)+4C]");
				num210 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2206 @ X8_v149 (MonsterDirector+Entry)+50]");
				num68 = 0f;
				Quaternion quaternion17 = Turned(endL, i1L, p1L, (Vector3)1, (Quaternion)swingL, (float)entry18.palmL);
				endL.rotation = (Quaternion)0;
				object obj166 = obj156 & 1;
				bool flag135 = obj166 == null;
				obj167 = !flag135;
				vector2 = (Vector3)1;
				quaternion = (Quaternion)swingL;
				num113 = 1f;
				num166 = num86;
				num69 = num62;
				vector22 = (Vector3)num84;
				num128 = num65;
				quaternion13 = (Quaternion)0;
				vector23 = (Vector3)1;
				quaternion14 = (Quaternion)swingL;
				num211 = 1f;
				num212 = num86;
				num213 = num62;
				vector24 = (Vector3)num84;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2206 @ X8_v149 (MonsterDirector+Entry)+50]");
				num214 = 0f;
				num215 = num65;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2206 @ X8_v149 (MonsterDirector+Entry)+4C]");
				num216 = 0.0;
				num217 = (float)entry18.palmL;
				vector20 = (Vector3)p1L;
				quaternion15 = (Quaternion)0;
				obj156 = 0;
			}
			while (obj167 != null);
		}
		object obj168 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4586 @ X0_v271+E4]");
		bool flag136 = (nint)0 == 0;
		object obj169 = !flag136;
		if (obj169 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag137 = twistL != null;
		bool flag138 = !flag137;
		num88 = num82;
		num86 = num128;
		num91 = (float)num210;
		transform11 = null;
		transform12 = null;
		if (!flag138)
		{
			object obj170 = obj96;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+29C]");
			num91 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+2A0]");
			num68 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+2A4]");
			num86 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+2BC]");
			num69 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+2C0]");
			num166 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+2C4]");
			num113 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4704 @ X0_v275+E4]");
			bool flag139 = (nint)0 == 0;
			object obj171 = !flag139;
			vector22 = (Vector3)handRestL;
			if (obj171 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				vector22 = (Vector3)handRestL;
			}
			bool flag140 = !twistsKnown;
			Quaternion quaternion18 = (Quaternion)(this + 752);
			Quaternion quaternion19 = (Quaternion)(!flag140);
			Twist(twistL, loL, endL, quaternion18, quaternion19, vector5, ref *(float*)num57, (byte)num58 != 0, (float)twistRestL);
			vector2 = (Vector3)quaternion18;
			quaternion = quaternion19;
			num88 = num82;
			num47 = (float)twistRestL;
			transform11 = endL;
			transform12 = loL;
		}
		goto IL_4b11;
		IL_4a34:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		double num250 = 1.0 * 1.5;
		float num251 = num162 + (float)num250;
		if (num159 > num251)
		{
			object obj172 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3031 @ X8_v183+A0]");
			object obj173 = 0;
			num133 = (float)obj173;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3018 @ X8_v184+8]");
			num105 = 0f;
		}
		object obj174 = this + 380;
		if (~(aligned ? 1u : 0u) == 0)
		{
			if (~(firstPerson ? 1u : 0u) == 0)
			{
				MonsterDirector.Entry entry19 = this.entry;
				bool flag141 = (byte)(~(entry19.hangs ? 1u : 0u)) != 0;
				object obj175 = !flag141;
				if (obj175 != null)
				{
					goto IL_47e7;
				}
			}
			float num252 = num88 * -12f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
			double num253 = 1.0 - (double)num252;
			bool flag142 = num253 < 0.0;
			double num254 = 0.0;
			if (!flag142)
			{
				bool flag143 = !(num253 > 1.0);
				num254 = num253;
				if (!flag143)
				{
					num254 = 1.0;
				}
			}
			float num255 = num133 - (float)obj174;
			double num256 = num105;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+184]");
			num250 = num256 - 0.0;
			object obj176 = default;
			float num257 = num255 * (float)obj176;
			double num258 = num250 * num254;
			num133 = (float)obj174 + num257;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+184]");
			num105 = 0f + (float)num258;
		}
		goto IL_47e7;
		IL_0fb1:
		num79 = num74;
		goto IL_4605;
		IL_47e7:
		obj174 = num133;
		aligned = true;
		Transform transform20 = base.transform;
		Vector3 position21 = transform20.position;
		Transform transform21 = base.transform;
		Quaternion rotation8 = transform21.rotation;
		vector22 = alignLocal;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+180]");
		num69 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+184]");
		num166 = 0.0;
		Vector3 vector25 = (Quaternion)0 * (Vector3)0;
		double num259 = num250 + num250;
		transform20.position = (Vector3)0;
		float num260 = num75 - num81;
		EyeHeightNow__BackingField = num260;
		Mirrored(num88);
		float num261;
		if (~(placed ? 1u : 0u) != 0)
		{
			num86 = 1.5;
			num261 = 0f;
		}
		else
		{
			object obj177 = obj112;
			num105 = num - (float)lastHead;
			float num262 = num160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+178]");
			float num263 = num262 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3241 @ X0_v343+E4]");
			bool flag144 = (nint)0 == 0;
			object obj178 = !flag144;
			if (obj178 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num264 = num263 * num263;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float num265 = num88 * -6f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
			float num266 = num105 / num88;
			double num267 = 1.0 - (double)num265;
			bool flag145 = num267 < 0.0;
			double num268 = 0.0;
			if (!flag145)
			{
				bool flag146 = !(num267 > 1.0);
				num268 = num267;
				if (!flag146)
				{
					num268 = 1.0;
				}
			}
			float num269 = num266 - speed;
			float num270 = num269 * (float)num268;
			num261 = speed + num270;
			num86 = 1.0;
		}
		MonsterDirector.Entry entry20 = this.entry;
		speed = num261;
		lastHead = (Vector3)num;
		placed = true;
		num62 = entry20.runSpeed;
		object obj179 = obj;
		float num271 = sizeBy * entry20.runSpeed;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		float num272 = num105;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		num60 = num272 + 0f;
		float num273 = num271 - num60;
		bool flag147 = num273 < 0f;
		bool flag148 = num273 == 0f;
		object obj180 = num271 ^ num60;
		object obj181 = num271 ^ num273;
		object obj182 = obj180 & obj181;
		bool flag149 = (nint)obj182 < 0;
		bool flag150 = flag147 == flag149;
		object obj183 = !flag148;
		object obj184 = flag150 & obj183;
		object obj185 = ~obj184;
		float num274 = ((obj185 != null) ? num60 : num271);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3250 @ X0_v69+E4]");
		bool flag151 = (nint)0 == 0;
		object obj186 = !flag151;
		if (obj186 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag152 = anim != null;
		bool flag153 = !flag152;
		transform3 = null;
		obj36 = null;
		if (!flag153)
		{
			MonsterDirector.Entry entry21 = this.entry;
			Animator animator;
			int num275;
			float value2;
			if (~(entry21.onArms ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
				object obj187 = 0;
				object obj188 = obj187;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3347 @ X0_v333+E4]");
				bool flag154 = (nint)0 == 0;
				object obj189 = !flag154;
				if (obj189 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj190 = obj187;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X9_v59+A0]");
				object obj191 = 0;
				float value = (firstPerson ? 1f : 0f);
				anim.SetFloat((int)obj191, value);
				object obj192 = obj187;
				animator = anim;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3607 @ X0_v336+E4]");
				bool flag155 = (nint)0 == 0;
				object obj193 = !flag155;
				if (obj193 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj194 = obj187;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3630 @ X9_v60+A0]");
				object obj195 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3642 @ X8_v172+4]");
				num275 = 0;
				if (!firstPerson)
				{
					num60 = 1f;
					value2 = 1f;
				}
				else
				{
					num60 = 1f;
					value2 = 0f;
				}
			}
			else
			{
				if (~(firstPerson ? 1u : 0u) == 0)
				{
					Steps(num105, num274, num88);
					num62 = num88;
					num60 = num274;
					transform3 = null;
					obj36 = null;
					goto IL_1875;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
				object obj196 = 0;
				object obj197 = obj196;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2064 @ X0_v325+E4]");
				bool flag156 = (nint)0 == 0;
				object obj198 = !flag156;
				if (obj198 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj197 = obj196;
				}
				bool flag157 = speed < num105;
				object obj199 = !flag157;
				float num276 = speed - num105;
				bool flag158 = num276 == 0f;
				object obj200 = ~obj199;
				object obj201 = obj200 | flag158;
				float num282;
				if (obj201 == null)
				{
					bool flag159 = num105 == num274;
					double num277 = 0.0;
					if (!flag159)
					{
						float num278 = speed - num105;
						float num279 = num274 - num105;
						float num280 = num278 / num279;
						bool flag160 = num280 < 0f;
						num277 = 0.0;
						if (!flag160)
						{
							bool flag161 = !((double)num280 > 1.0);
							num277 = num280;
							if (!flag161)
							{
								num277 = 1.0;
							}
						}
					}
					double num281 = num277 + 1.0;
					num282 = (float)num281;
				}
				else
				{
					num282 = speed / num105;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2064 @ X0_v325+A0]");
				object obj202 = 0;
				Animator animator2 = anim;
				float value3 = num282;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				animator2.SetFloat((int)obj202, value3, 0f, num88);
				object obj203 = obj196;
				animator = anim;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3620 @ X0_v327+E4]");
				bool flag162 = (nint)0 == 0;
				object obj204 = !flag162;
				if (obj204 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj205 = obj196;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3658 @ X8_v165+A0]");
				object obj206 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3660 @ X8_v166+4]");
				num275 = 0;
				num62 = num88;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				num60 = 0f;
				value2 = 1f;
			}
			animator.SetFloat(num275, value2);
			transform3 = null;
			obj36 = (UnityEngine.Object)num275;
		}
		goto IL_1875;
		IL_469f:
		float num283 = num40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1066 @ X9_v4+28]");
		float num284 = num283 * 0f;
		double num285 = num9 + (double)num284;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj207 = 0;
		object obj208 = obj8;
		object obj209 = obj207;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2479 @ X9_v5+A0]");
		object obj210 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2480 @ X0_v24+E4]");
		bool flag163 = (nint)0 == 0;
		object obj211 = !flag163;
		num82 = num40;
		if (obj211 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num82 = num42;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		object obj212 = default;
		bool flag164 = Physics.Raycast((Vector3)(&obj212), (Vector3)4294961403L, out *(RaycastHit*)1, num42, 0, queryTriggerInteraction);
		bool flag165 = !flag164;
		object obj213 = !flag165;
		object obj214 = ~obj213;
		float num286 = default;
		num81 = ((obj214 != null) ? ((float)num285) : num286);
		bool flag166 = (byte)(~(firstPerson ? 1u : 0u)) != 0;
		object obj215 = !flag166;
		float num287 = (float)num9;
		float num288 = num286;
		rotation2 = (Quaternion)1;
		if (obj215 == null)
		{
			num288 = FloorEased(num81, flag164, flag20, num82);
			num81 += num288;
			num287 = num82;
			rotation2 = (Quaternion)flag20;
		}
		Vector3 forward2 = head.forward;
		object obj216 = obj8;
		object obj217 = 109891584;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2569 @ X8_v24+A0]");
		object obj218 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2570 @ X8_v25+18]");
		nint num289 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2570 @ X8_v25+18]");
		object obj219 = num289 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2570 @ X8_v25+1C]");
		nint num290 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2570 @ X8_v25+1C]");
		object obj220 = num290 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		obj125 = 0;
		object obj221 = obj125;
		object obj222 = obj219 + obj220;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2570 @ X8_v25+20]");
		nint num291 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2570 @ X8_v25+20]");
		object obj223 = num291 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2585 @ X8_v27+A0]");
		object obj224 = 0;
		object obj225 = obj223 + obj222;
		bool flag167 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj225) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj224);
		float num292 = num41;
		float num293 = num287;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2481 @ X8_v20+24]");
		num114 = 0f;
		float num294 = num288;
		if (!flag167)
		{
			float num295 = num288;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2570 @ X8_v25+18]");
			float num296 = num295 * 0f;
			float num297 = num287;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2570 @ X8_v25+1C]");
			float num298 = num297 * 0f;
			float num299 = num41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2570 @ X8_v25+20]");
			num114 = num299 * 0f;
			float num300 = num296 + num298;
			float num301 = num114 + num300;
			float num302 = num301 / (float)obj225;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2570 @ X8_v25+18]");
			float num303 = 0f * num302;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2570 @ X8_v25+1C]");
			float num304 = 0f * num302;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2570 @ X8_v25+20]");
			float num305 = 0f * num302;
			num294 = num288 - num303;
			num293 = num287 - num304;
			num292 = num41 - num305;
			num41 = num304;
		}
		float num306 = num294 * num294;
		float num307 = num293 * num293;
		float num308 = num306 + num307;
		float num309 = num292 * num292;
		float num310 = num308 + num309;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		if (num310 > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFF0");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
			object obj226 = 0;
			float num311 = num294;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
			num93 = num311 * 0f;
		}
		else
		{
			num93 = yaw;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			object obj226 = 0;
		}
		double num316;
		if (~(placed ? 1u : 0u) == 0)
		{
			float num312 = num82 * -6f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
			float num313 = num93 - yaw;
			float num314 = num313 / 1.13587E+09f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			float num315 = num314 * 1.13587E+09f;
			num114 = num313 - num315;
			num316 = 1.0 - (double)num312;
			bool flag168 = num114 < 0f;
			num41 = 0f;
			if (!flag168)
			{
				bool flag169 = num114 > 1.13587E+09f;
				float num317 = 1.13587E+09f;
				if (!flag169)
				{
					bool flag170 = !(num114 > 1.1274813E+09f);
					num317 = num114;
					num41 = num114;
					if (flag170)
					{
						goto IL_45ab;
					}
				}
				num41 = num317 + 3.2833536E+09f;
			}
			goto IL_45ab;
		}
		goto IL_5291;
		IL_45ab:
		bool flag171 = num316 < 0.0;
		double num318 = 0.0;
		if (!flag171)
		{
			bool flag172 = !(num316 > 1.0);
			num318 = num316;
			if (!flag172)
			{
				num318 = 1.0;
			}
		}
		float num319 = num41 * (float)num318;
		num93 = yaw + num319;
		goto IL_5291;
	}

	private unsafe float Propped(float wanted, float above, float floorY, float dt)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_016e: Invalid comparison between F4 and I
		//IL_01dc: Invalid comparison between F4 and I4
		//IL_085c: Invalid comparison between F4 and I4
		//IL_086b: Invalid comparison between F4 and I4
		//IL_087e: Expected Obj, but got F4
		//IL_088b: Expected Obj, but got F4
		//IL_08c0: Expected Obj, but got I4
		//IL_08c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Expected Obj, but got Unknown
		//IL_0925: Expected Obj, but got I4
		//IL_029f: Invalid comparison between F4 and I4
		//IL_02b0: Expected Obj, but got I4
		//IL_0361: Expected Obj, but got I4
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected Ref, but got Unknown
		//IL_0762: Expected F4, but got I
		//IL_03d5: Expected Obj, but got I4
		//IL_095c: Expected Obj, but got I
		//IL_0986: Expected Obj, but got I4
		//IL_09be: Expected Obj, but got I4
		//IL_0529: Expected Obj, but got I4
		//IL_09f6: Expected Obj, but got I4
		//IL_0657: Invalid comparison between F4 and I4
		//IL_0666: Invalid comparison between F4 and I4
		//IL_0679: Expected Obj, but got F4
		//IL_0686: Expected Obj, but got F4
		//IL_06e8: Expected Obj, but got I4
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected Obj, but got Unknown
		//IL_0b67: Invalid comparison between F4 and I4
		//IL_0b76: Invalid comparison between F4 and I4
		//IL_0b89: Expected Obj, but got F4
		//IL_0b96: Expected Obj, but got F4
		//IL_0bcb: Expected Obj, but got I4
		//IL_0bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd8: Expected Obj, but got Unknown
		MonsterDirector.Entry entry = this.entry;
		bool flag = this.entry == null;
		float num = wanted;
		float num19;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num2 = entry.eyeHeight * sizeBy;
			if (root != null)
			{
				bool flag3 = (object)root == null;
				num = wanted;
				if (flag3)
				{
					goto IL_0773;
				}
				Vector3 position = root.position;
				float num3 = above;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
				float num4 = num3 + 0f;
				num = num4 - floorY;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				UnityEngine.Object obj4 = null;
			}
			else
			{
				double num5 = (double)num2 * 0.5;
				num = (float)num5;
				UnityEngine.Object obj4 = null;
			}
			float[] array = offFloor;
			if (offFloor != null)
			{
				if (array.Length == 0)
				{
					goto IL_0781;
				}
				float num6 = array[0];
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				bool flag4;
				if (num6 < 0f)
				{
					flag4 = true;
				}
				else
				{
					if (array.Length == 1)
					{
						goto IL_0781;
					}
					float num7 = array[1];
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					float num8 = num7 - 0f;
					bool flag5 = num8 < 0f;
					flag4 = flag5;
				}
				MonsterDirector.Entry entry2 = this.entry;
				if (this.entry != null)
				{
					num = 0f - num;
					float num9 = entry2.playedSize;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
					float num10 = num9 * 0f;
					float num11 = num10 * sizeBy;
					if (flag4 && !(num > wanted))
					{
						float num12 = entry2.playedSize;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
						float num13 = num12 * 0f;
						num = num13 * sizeBy;
						float num14 = num - wanted;
						bool flag6 = num14 < 0f;
						object obj5 = !flag6;
						object obj6 = ~obj5;
						if (obj6 == null)
						{
							num = wanted;
						}
					}
					float num15 = above - num2;
					object obj7 = obj;
					float num16 = num15 - num11;
					float num17 = num2 + num11;
					float num18 = num - num16;
					bool flag7 = num18 < 0f;
					bool flag8 = num18 == 0f;
					object obj8 = num ^ num16;
					object obj9 = num ^ num18;
					object obj10 = obj8 & obj9;
					bool flag9 = (nint)obj10 < 0;
					bool flag10 = flag7 == flag9;
					object obj11 = !flag8;
					object obj12 = flag10 & obj11;
					object obj13 = ~obj12;
					if (obj13 == null)
					{
						num16 = num;
					}
					num19 = ((!(num17 < above)) ? num : num16);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v11+E4]");
					bool flag11 = (nint)0 == 0;
					object obj14 = !flag11;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (upL != null)
					{
						object obj15 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X0_v18+E4]");
						bool flag12 = (nint)0 == 0;
						object obj16 = !flag12;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (loL != null)
						{
							object obj17 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v22+E4]");
							bool flag13 = (nint)0 == 0;
							object obj18 = !flag13;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (endL != null)
							{
								if ((object)loL != null)
								{
									Vector3 position2 = loL.position;
									if ((object)upL != null)
									{
										Vector3 position3 = upL.position;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
										object obj19 = 0;
										object obj20 = obj19;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X0_v31+E4]");
										bool flag14 = (nint)0 == 0;
										object obj21 = !flag14;
										if (obj21 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										if ((object)endL != null)
										{
											Vector3 position4 = endL.position;
											if ((object)loL != null)
											{
												Vector3 position5 = loL.position;
												object obj22 = obj19;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X0_v38+E4]");
												bool flag15 = (nint)0 == 0;
												object obj23 = !flag15;
												if (obj23 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												object obj24 = obj;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X0_v40+E4]");
												bool flag16 = (nint)0 == 0;
												object obj25 = !flag16;
												if (obj25 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												bool flag17 = leftHand != null;
												bool flag18 = !flag17;
												UnityEngine.Object obj26 = null;
												float num20 = floorY;
												if (!flag18)
												{
													if ((object)leftHand == null)
													{
														goto IL_0773;
													}
													Vector3 position6 = leftHand.position;
													obj26 = null;
													num20 = num17;
												}
												object obj27 = obj;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v45+E4]");
												bool flag19 = (nint)0 == 0;
												object obj28 = !flag19;
												if (obj28 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												bool flag20 = rightHand != null;
												bool flag21 = !flag20;
												float num21 = floorY;
												if (!flag21)
												{
													if ((object)rightHand == null)
													{
														goto IL_0773;
													}
													Vector3 position7 = rightHand.position;
													num21 = num17;
												}
												if ((object)upL != null)
												{
													float num22 = num20 - num21;
													bool flag22 = num22 < 0f;
													bool flag23 = num22 == 0f;
													object obj29 = num20 ^ num21;
													object obj30 = num20 ^ num22;
													object obj31 = obj29 & obj30;
													bool flag24 = (nint)obj31 < 0;
													float num23 = num - num;
													float num24 = num17 - num17;
													float num25 = num16 - num16;
													bool flag25 = flag22 == flag24;
													object obj32 = !flag23;
													object obj33 = flag25 & obj32;
													object obj34 = ~obj33;
													if (obj34 == null)
													{
														num21 = num20;
													}
													float num26 = num23 * num23;
													float num27 = num24 * num24;
													float num28 = num25 * num25;
													float num29 = num26 + num27;
													float num30 = num28 + num29;
													float num31 = num - num;
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
													float num32 = num17 - num17;
													float num33 = num16 - num16;
													float num34 = num31 * num31;
													float num35 = num32 * num32;
													float num36 = num34 + num35;
													float num37 = num33 * num33;
													float num38 = num37 + num36;
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
													float num39 = num30 + num38;
													float num40 = num39 * 1.25f;
													Vector3 position8 = upL.position;
													float num41 = num40 + 1.25f;
													float num42 = num21 - num41;
													float num43 = num19 - num42;
													bool flag26 = num43 < 0f;
													bool flag27 = num43 == 0f;
													object obj35 = num19 ^ num42;
													object obj36 = num19 ^ num43;
													object obj37 = obj35 & obj36;
													bool flag28 = (nint)obj37 < 0;
													bool flag29 = flag26 == flag28;
													object obj38 = !flag27;
													object obj39 = flag29 & obj38;
													object obj40 = ~obj39;
													if (obj40 != null)
													{
														num19 = num42;
													}
													goto IL_0933;
												}
											}
										}
									}
								}
								goto IL_0773;
							}
						}
					}
					goto IL_0933;
				}
			}
		}
		goto IL_0773;
		IL_0933:
		if (~(placed ? 1u : 0u) == 0)
		{
			ref float currentVelocity = ref *(float*)(this + 332);
			float current = risen;
			float target = num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
			float num44 = Mathf.SmoothDamp(current, target, ref currentVelocity, 0f, 15f, dt);
			num19 = num44;
		}
		risen = num19;
		return num19;
		IL_0781:
		throw new IndexOutOfRangeException();
		IL_0773:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0781;
	}

	private unsafe float FloorEased(float floorY, bool hit, bool teleported, float dt)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Ref, but got Unknown
		//IL_0187: Expected F4, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I4
		object obj = (floorKnown ? 1 : 0) ^ 1;
		object obj2 = obj | teleported;
		if (obj2 != null)
		{
			object obj3 = this + 340;
			obj3 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			object obj4 = default;
			if ((nint)obj4 > 0)
			{
				bool flag = !hit;
				object obj5 = !flag;
				if (obj5 != null || ~(floorWasHit ? 1u : 0u) == 0)
				{
					float num = floorY - floorWas;
					float num2 = floorShift - num;
					floorShift = num2;
				}
			}
		}
		floorWasHit = hit;
		floorKnown = true;
		ref float currentVelocity = ref *(float*)(this + 344);
		floorWas = floorY;
		float current = floorShift;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		float num3 = Mathf.SmoothDamp(current, 0f, ref currentVelocity, 0f, 1f / 0f, dt);
		bool flag2 = (double)num3 < -8.0;
		double num4 = -8.0;
		if (!flag2)
		{
			bool flag3 = !((double)num3 > 8.0);
			num4 = num3;
			if (!flag3)
			{
				num4 = 8.0;
			}
		}
		floorShift = (float)num4;
		return (float)num4;
	}

	private void Look(float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0b12: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got I4
		//IL_01cb: Expected Obj, but got I4
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_024b: Expected Obj, but got I4
		//IL_0298: Expected F8, but got I4
		//IL_02a1: Expected Obj, but got I4
		//IL_0b39: Invalid comparison between F8 and I4
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Expected Obj, but got Unknown
		//IL_0b5a: Expected Obj, but got F8
		//IL_0b8f: Expected Obj, but got I4
		//IL_03ff: Expected F8, but got I4
		//IL_02bf: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I4
		//IL_033d: Expected Obj, but got I
		//IL_034c: Expected I4, but got Obj
		//IL_0359: Invalid comparison between F4 and I4
		//IL_0368: Expected F8, but got I4
		//IL_0371: Expected Obj, but got I4
		//IL_088f: Expected Obj, but got I
		//IL_03b3: Expected Obj, but got I4
		//IL_03e4: Expected Obj, but got I4
		//IL_08f6: Expected Obj, but got I4
		//IL_090c: Expected Obj, but got I
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Expected Obj, but got Unknown
		//IL_09da: Expected Obj, but got I4
		//IL_09ea: Expected Obj, but got I4
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Expected Obj, but got Unknown
		//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3c: Expected Obj, but got Unknown
		//IL_0a74: Expected Obj, but got I
		//IL_0a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a87: Expected Obj, but got Unknown
		//IL_0ac0: Expected Obj, but got I4
		//IL_0bcf: Expected VT, but got F4
		//IL_0684: Expected Obj, but got I
		//IL_0694: Expected Obj, but got I
		//IL_06a4: Expected Obj, but got I
		//IL_06ae: Expected F4, but got VT
		//IL_06be: Expected F8, but got I
		//IL_06ce: Expected F8, but got I
		//IL_06d8: Expected F4, but got VT
		//IL_06e8: Expected Obj, but got I
		//IL_0793: Expected VT, but got I4
		//IL_07c2: Expected VT, but got I4
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
		bool flag2 = skull == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = neck == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v11+E4]");
		bool flag7 = (nint)0 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = chest == null;
		bool flag9 = !flag8;
		object obj10 = !flag9;
		if (obj10 != null)
		{
			return;
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v15+E4]");
		bool flag10 = (nint)0 == 0;
		object obj12 = !flag10;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = head == null;
		bool flag12 = !flag11;
		object obj13 = !flag12;
		if (obj13 != null || ~(faceKnown ? 1u : 0u) != 0)
		{
			return;
		}
		object obj14 = this + 792;
		bool flag13 = neckBase == null;
		UnityEngine.Object obj15 = null;
		if (!flag13)
		{
			goto IL_0221;
		}
		if (~(baseLater ? 1u : 0u) != 0 || ++lookFrames < 2)
		{
			return;
		}
		baseLater = false;
		if ((object)neck != null)
		{
			Quaternion localRotation = neck.localRotation;
			if ((object)skull != null)
			{
				Quaternion localRotation2 = skull.localRotation;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F28]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj17 = default;
				if (obj17 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X0_v28+18]");
					bool flag14 = (nint)0 < (nint)2;
					object obj18 = !flag14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X0_v28+18]");
					object obj19 = -2;
					bool flag15 = obj19 == null;
					object obj20 = ~obj18;
					object obj21 = obj20 | flag15;
					if (obj21 == null)
					{
						obj14 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Quaternion[] array = default;
						if (array == null)
						{
							goto IL_0ad3;
						}
						bool flag16 = array.Length < 2;
						object obj22 = !flag16;
						object obj23 = array.Length - 2;
						bool flag17 = obj23 == null;
						object obj24 = ~obj22;
						object obj25 = obj24 | flag17;
						if (obj25 == null)
						{
							object obj26 = this + 800;
							skullBase = array;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC9C8]");
							object obj27 = 0;
							obj15 = (UnityEngine.Object)obj27;
							object obj28 = this + 112;
							obj28 = obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X21_v8+2A8]");
							bool flag18 = (nint)0 == 0;
							object obj29 = !flag18;
							if (obj29 == null)
							{
								return;
							}
							goto IL_0221;
						}
					}
					goto IL_0ae1;
				}
			}
		}
		goto IL_0ad3;
		IL_0ae1:
		throw new IndexOutOfRangeException();
		IL_0221:
		object obj30 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v38+E4]");
		bool flag19 = (nint)0 == 0;
		object obj31 = !flag19;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag20 = anim != null;
		bool flag21 = !flag20;
		float num2 = default;
		float num = num2;
		double num3 = 0.0;
		object obj32 = 0;
		double num4 = default;
		if (!flag21)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
			object obj33 = 0;
			object obj34 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v101+E4]");
			bool flag22 = (nint)0 == 0;
			object obj35 = !flag22;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((object)anim == null)
			{
				goto IL_0ad3;
			}
			object obj36 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X8_v30+A0]");
			object obj37 = 0;
			num = anim.GetFloat((int)obj37);
			bool flag23 = num < 0f;
			num3 = 0.0;
			obj32 = 0;
			if (!flag23)
			{
				bool flag24 = !((double)num > 2.0);
				num4 = 2.0;
				num3 = num;
				obj32 = 0;
				if (!flag24)
				{
					num4 = 2.0;
					num3 = 2.0;
					obj32 = 0;
				}
			}
		}
		double num5 = num3 - 1.0;
		bool flag25 = num5 < 0.0;
		object obj38 = num3 ^ 1;
		object obj39 = num3 ^ num5;
		object obj40 = obj38 & obj39;
		bool flag26 = (nint)obj40 < 0;
		bool flag27 = flag25 == flag26;
		object obj41 = !flag27;
		object obj42 = ~obj41;
		double num6 = ((obj42 != null) ? 1.0 : num3);
		if ((object)chest != null)
		{
			Quaternion rotation = chest.rotation;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FC8C");
				if (obj14 != null)
				{
					double num7 = num6 + 1.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FC8C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE5E34");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
					if (skullBase != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FC8C");
						if (skullBase != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FC8C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE5E34");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
							if ((object)head != null)
							{
								Quaternion rotation2 = head.rotation;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
								if ((object)chest != null)
								{
									Quaternion rotation3 = chest.rotation;
									Quaternion rotation4 = default;
									Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation4);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
									Quaternion quaternion2 = Quaternion.Internal_Inverse(ref rotation4);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
									if ((object)chest != null)
									{
										Quaternion rotation5 = chest.rotation;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DA97E8");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE5E34");
										bool flag28 = (byte)(~(looking ? 1u : 0u)) != 0;
										object obj44 = default;
										object obj43 = obj44;
										object obj46 = default;
										object obj45 = obj46;
										object obj47 = obj44;
										float num8 = num;
										double num9 = num4;
										double num10 = num4;
										float num11 = num;
										object obj48 = obj46;
										if (!flag28)
										{
											float num12 = num2 * -10f;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE5E34");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+334]");
											obj43 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+330]");
											obj45 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+334]");
											obj47 = 0;
											num8 = (float)neckShare;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+32C]");
											num9 = 0.0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+32C]");
											num10 = 0.0;
											num11 = (float)neckShare;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+330]");
											obj48 = 0;
										}
										neckShare = (Quaternion)num8;
										looking = true;
										if ((object)chest != null)
										{
											Quaternion rotation6 = chest.rotation;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
											if ((object)chest != null)
											{
												Quaternion rotation7 = chest.rotation;
												Quaternion quaternion3 = Quaternion.Internal_Inverse(ref rotation4);
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
												if ((object)neck != null)
												{
													neck.rotation = (Quaternion)0;
													if ((object)skull != null)
													{
														skull.rotation = (Quaternion)0;
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
		goto IL_0ad3;
		IL_0ad3:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0ae1;
	}

	private void Mirrored(float dt)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_012c: Expected VT, but got F4
		//IL_0159: Expected VT, but got F4
		//IL_0190: Expected VT, but got F4
		//IL_01bd: Expected VT, but got F4
		if (~(mirrored ? 1u : 0u) != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = neck == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = skull == null;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				Quaternion localRotation = neck.localRotation;
				neckUnturned = (Quaternion)dt;
				Quaternion localRotation2 = skull.localRotation;
				skullUnturned = (Quaternion)dt;
				Look(dt);
				Quaternion localRotation3 = neck.localRotation;
				neckTurned = (Quaternion)dt;
				Quaternion localRotation4 = skull.localRotation;
				skullTurned = (Quaternion)dt;
				turnedForMirror = true;
			}
		}
	}

	private unsafe void Face()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I4
		//IL_09bc: Expected Obj, but got I4
		//IL_00ea: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I4
		//IL_03f3: Expected Obj, but got I
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_0185: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I4
		//IL_0298: Expected I4, but got I8
		//IL_02a1: Expected Obj, but got I4
		//IL_0995: Expected Obj, but got I4
		//IL_0358: Expected I4, but got I8
		//IL_0372: Expected Obj, but got I4
		//IL_037f: Expected I4, but got I8
		//IL_0388: Expected Obj, but got I4
		//IL_0392: Expected Obj, but got I4
		//IL_0314: Expected I4, but got I8
		//IL_0481: Expected Obj, but got I
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected Obj, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected Obj, but got Unknown
		//IL_0571: Expected Obj, but got I4
		//IL_05af: Expected VT, but got Obj
		//IL_05cc: Expected Obj, but got I
		//IL_05de: Expected I4, but got I8
		//IL_05f8: Expected Obj, but got I4
		//IL_0a74: Expected VT, but got I4
		//IL_0a85: Expected VT, but got I4
		//IL_0aa2: Expected Obj, but got I
		//IL_0adb: Expected Obj, but got I4
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected Obj, but got Unknown
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected Ref, but got Unknown
		//IL_0663: Expected Obj, but got I4
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected Obj, but got Unknown
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected Obj, but got Unknown
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fc: Expected Obj, but got Unknown
		//IL_0891: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Expected Obj, but got Unknown
		//IL_0915: Expected VT, but got Obj
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected Obj, but got Unknown
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected Ref, but got Unknown
		//IL_09d9: Expected VT, but got I4
		//IL_09d9: Expected VT, but got I4
		//IL_09f8: Expected Obj, but got I4
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected Ref, but got Unknown
		//IL_0a15: Expected VT, but got I4
		//IL_0a15: Expected VT, but got I4
		//IL_0a42: Expected VT, but got I4
		//IL_0a42: Expected VT, but got I4
		if ((object)model != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4250]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
			object obj3 = default;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+18]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+18]");
				if ((nint)0 < (nint)1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4288]");
				object obj6 = 0;
				object obj7 = 0;
				Quaternion rotation2 = default;
				object obj23 = default;
				object obj24 = default;
				object obj26 = default;
				object obj28 = default;
				object obj29 = default;
				object obj31 = default;
				object obj32 = default;
				object obj37 = default;
				object obj48 = default;
				object obj49 = default;
				object obj51 = default;
				object obj52 = default;
				Matrix4x4 matrix4x2 = default;
				Vector3 upwards = default;
				object obj53 = default;
				Vector3 forward = default;
				object obj59 = default;
				object obj61 = default;
				object obj63 = default;
				object obj67 = default;
				object obj77 = default;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
					object obj8 = !flag;
					if (obj8 != null)
					{
						break;
					}
					object obj9 = obj3 + obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v10+20]");
					Matrix4x4[] bindposes;
					int num;
					int num3;
					object obj19;
					int num6;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v10+20]");
						Mesh sharedMesh = ((SkinnedMeshRenderer)0).sharedMesh;
						object obj10 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v11+E4]");
						bool flag2 = (nint)0 == 0;
						object obj11 = !flag2;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag3 = sharedMesh == null;
						bool flag4 = !flag3;
						object obj12 = !flag4;
						obj2 = 0;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v10+20]");
							Transform[] bones = ((SkinnedMeshRenderer)0).bones;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v10+20]");
							Mesh sharedMesh2 = ((SkinnedMeshRenderer)0).sharedMesh;
							if ((object)sharedMesh2 == null)
							{
								goto IL_0936;
							}
							bindposes = sharedMesh2.bindposes;
							num = Array.IndexOf((System.__Canon[])(object)bones, (System.__Canon)(object)skull);
							object obj13 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v14+E4]");
							bool flag5 = (nint)0 == 0;
							object obj14 = !flag5;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (eyeL != null)
							{
								object obj15 = obj6;
								int num2 = Array.IndexOf((System.__Canon[])(object)bones, (System.__Canon)(object)eyeL);
								num3 = num2;
								UnityEngine.Object obj16 = eyeL;
							}
							else
							{
								num3 = -1;
								object obj15 = 0;
								UnityEngine.Object obj16 = null;
							}
							object obj17 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X0_v27+E4]");
							bool flag6 = (nint)0 == 0;
							object obj18 = !flag6;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (eyeR != null)
							{
								obj19 = obj6;
								int num4 = Array.IndexOf((System.__Canon[])(object)bones, (System.__Canon)(object)eyeR);
								int num5 = (int)(num & 0x80000000L);
								bool flag7 = num5 == 0;
								num6 = num4;
								if (flag7)
								{
									goto IL_03a0;
								}
								obj2 = obj6;
							}
							else
							{
								int num7 = (int)(num & 0x80000000L);
								bool flag8 = num7 == 0;
								object obj20 = !flag8;
								num6 = -1;
								obj19 = 0;
								obj2 = 0;
								if (obj20 == null)
								{
									goto IL_03a0;
								}
							}
						}
						goto IL_03e3;
					}
					goto IL_0936;
					IL_03e3:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+18]");
					obj4 = 0;
					obj7++;
					object obj21 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+18]");
					if ((nint)obj21 >= 0)
					{
						return;
					}
					continue;
					IL_03a0:
					if (bindposes != null)
					{
						bool flag9 = num < bindposes.Length;
						obj2 = obj19;
						if (!flag9)
						{
							goto IL_03e3;
						}
						Transform transform = base.transform;
						if ((object)transform != null)
						{
							Quaternion rotation = transform.rotation;
							Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v10+20]");
							Transform transform2 = ((Component)0).transform;
							if ((object)transform2 != null)
							{
								Quaternion rotation3 = transform2.rotation;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								int num8 = num6 | num3;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								object obj22 = obj23 * obj24;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
								object obj25 = 0 * obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								object obj27 = obj28 * obj29;
								object obj30 = obj31 * obj32;
								object obj33 = 0 * obj32;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
								object obj34 = obj30 - obj27;
								object obj35 = obj33 + obj25;
								object obj36 = obj23 * obj37;
								object obj38 = 0 * 0;
								object obj39 = obj34 - obj22;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								object obj40 = obj36 + obj35;
								object obj41 = obj34 * obj37;
								Quaternion quaternion2 = (Quaternion)(obj40 - obj38);
								object obj42 = obj39 - obj41;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
								object obj43 = 0;
								int num9 = (int)(num8 & 0x80000000L);
								bool flag10 = num9 == 0;
								object obj44 = !flag10;
								object obj50;
								if (obj44 == null && num3 < bindposes.Length && num6 < bindposes.Length)
								{
									bool flag11 = num3 < bindposes.Length;
									object obj45 = !flag11;
									if (obj45 != null)
									{
										break;
									}
									object obj46 = bindposes + 32;
									Matrix4x4 matrix4x = Matrix4x4.Internal_Inverse(ref *(Matrix4x4*)(obj46 + num3));
									Quaternion rotation4 = matrix4x2.GetRotation();
									Vector3 vector = (Quaternion)0 * (Vector3)0;
									bool flag12 = num6 < bindposes.Length;
									object obj47 = !flag12;
									if (obj47 != null)
									{
										break;
									}
									Matrix4x4 matrix4x3 = Matrix4x4.Internal_Inverse(ref *(Matrix4x4*)(obj46 + num6));
									Quaternion rotation5 = matrix4x2.GetRotation();
									Vector3 vector2 = (Quaternion)0 * (Vector3)0;
									obj34 = obj48 + obj49;
									obj50 = obj51 + obj52;
									Vector3 vector3 = (Quaternion)0 * (Vector3)0;
									matrix4x2 = (Matrix4x4)upwards;
									obj39 = obj53;
									obj40 = obj42;
								}
								else
								{
									matrix4x2 = (Matrix4x4)0;
									obj50 = obj23;
									forward = (Vector3)0;
								}
								object obj54 = obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v876 @ X8_v21+A0]");
								object obj55 = 0;
								Quaternion quaternion3 = Quaternion.Internal_LookRotation(ref forward, ref upwards);
								Quaternion quaternion4 = Quaternion.Internal_Inverse(ref rotation2);
								bool flag13 = num < bindposes.Length;
								object obj56 = !flag13;
								if (obj56 != null)
								{
									break;
								}
								object obj57 = bindposes + num;
								Matrix4x4 matrix4x4 = Matrix4x4.Internal_Inverse(ref *(Matrix4x4*)(obj57 + 32));
								Quaternion rotation6 = matrix4x2.GetRotation();
								faceKnown = true;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								object obj58 = obj36 * obj59;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								object obj60 = obj34 * obj61;
								object obj62 = obj50 * obj63;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ X8_v22+20]");
								object obj64 = obj42 * 0;
								object obj65 = 0 * obj37;
								object obj66 = obj36 * obj67;
								object obj68 = obj60 + obj62;
								object obj69 = obj64 + obj65;
								object obj70 = obj68 + obj58;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
								object obj71 = quaternion2 * obj39;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
								object obj72 = obj58 * obj39;
								object obj73 = obj71 + obj69;
								object obj74 = obj70 - obj66;
								object obj75 = obj73 - obj72;
								object obj76 = obj51 * obj77;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								object obj78 = obj40 * obj48;
								object obj79 = obj74 * obj40;
								object obj80 = quaternion2 * obj24;
								object obj81 = obj66 * obj70;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
								object obj82 = obj75 * obj51;
								object obj83 = obj79 + obj78;
								object obj84 = obj76 + obj81;
								object obj85 = obj75 * obj51;
								object obj86 = obj66 * obj48;
								object obj87 = obj84 + obj80;
								object obj88 = obj85 + obj83;
								Quaternion quaternion5 = (Quaternion)(obj88 - obj86);
								object obj89 = obj87 - obj82;
								skullOnFace = quaternion5;
								return;
							}
						}
					}
					goto IL_0936;
				}
				goto IL_0944;
			}
		}
		goto IL_0936;
		IL_0944:
		throw new IndexOutOfRangeException();
		IL_0936:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0944;
	}

	private void Bases()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0ac8: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got I4
		//IL_01c3: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I4
		//IL_0242: Expected Obj, but got I4
		//IL_027a: Expected Obj, but got I4
		//IL_02c1: Expected Obj, but got I4
		//IL_0395: Expected Obj, but got I
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got Unknown
		//IL_03e7: Expected Obj, but got VT
		//IL_0401: Expected Obj, but got I
		//IL_0411: Expected Obj, but got I
		//IL_041a: Expected F4, but got I4
		//IL_0423: Expected F4, but got I4
		//IL_042c: Expected Obj, but got I4
		//IL_0b22: Expected Obj, but got I4
		//IL_047f: Expected Obj, but got I
		//IL_0492: Expected I4, but got Obj
		//IL_04c9: Expected Obj, but got I
		//IL_058d: Invalid comparison between F4 and I4
		//IL_059e: Expected Obj, but got I4
		//IL_05cc: Expected Obj, but got I4
		//IL_05be: Expected Obj, but got I4
		//IL_0b52: Expected Obj, but got I
		//IL_0b6a: Expected F4, but got Obj
		//IL_0b73: Expected Obj, but got I4
		//IL_0664: Expected Obj, but got I4
		//IL_068f: Expected VT, but got I4
		//IL_06cb: Expected VT, but got I4
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected Obj, but got Unknown
		//IL_0705: Expected VT, but got Obj
		//IL_072f: Expected Obj, but got I4
		//IL_0786: Invalid comparison between F4 and I
		//IL_0797: Expected Obj, but got I4
		//IL_0822: Invalid comparison between F4 and I
		//IL_0833: Expected Obj, but got I4
		//IL_0895: Invalid comparison between F4 and I4
		//IL_08a6: Expected F4, but got VT
		//IL_08af: Expected Obj, but got I4
		//IL_08b8: Expected VT, but got I4
		//IL_08f0: Expected Obj, but got I4
		//IL_0944: Expected Obj, but got I
		//IL_0958: Expected I4, but got Obj
		//IL_098f: Expected Obj, but got I
		//IL_0a55: Expected Obj, but got I
		//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		baseLater = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = anim == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		if ((object)anim != null)
		{
			RuntimeAnimatorController runtimeAnimatorController = anim.runtimeAnimatorController;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = runtimeAnimatorController == null;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			if (obj7 != null)
			{
				return;
			}
			if ((object)anim != null)
			{
				if (!anim.isActiveAndEnabled)
				{
					return;
				}
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X0_v18+E4]");
				bool flag7 = (nint)0 == 0;
				object obj9 = !flag7;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag8 = skull == null;
				bool flag9 = !flag8;
				object obj10 = !flag9;
				if (obj10 != null)
				{
					return;
				}
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X0_v22+E4]");
				bool flag10 = (nint)0 == 0;
				object obj12 = !flag10;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag11 = neck == null;
				bool flag12 = !flag11;
				object obj13 = !flag12;
				if (obj13 != null)
				{
					return;
				}
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X0_v26+E4]");
				bool flag13 = (nint)0 == 0;
				object obj15 = !flag13;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag14 = chest == null;
				bool flag15 = !flag14;
				object obj16 = !flag15;
				if (obj16 != null)
				{
					return;
				}
				if ((object)anim != null)
				{
					bool fireEvents = anim.fireEvents;
					if ((object)anim != null)
					{
						anim.fireEvents = false;
						if ((object)anim != null)
						{
							anim.Rebind();
							if ((object)anim != null)
							{
								anim.Update(0f);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F28]");
								object obj17 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								object obj18 = this + 792;
								Quaternion[] array = default;
								neckBase = array;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								object obj19 = this + 800;
								Quaternion quaternion = default;
								skullBase = (Quaternion[])quaternion;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
								object obj20 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D60]");
								object obj21 = 0;
								float num = 0f;
								float num2 = 0f;
								object obj22 = 0;
								Quaternion quaternion2 = quaternion;
								Vector4 sum = default;
								Vector4 sum2 = default;
								while (true)
								{
									object obj23 = obj20;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X0_v44+E4]");
									bool flag16 = (nint)0 == 0;
									object obj24 = !flag16;
									if (obj24 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									if ((object)anim == null)
									{
										break;
									}
									object obj25 = obj20;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X8_v15+A0]");
									object obj26 = 0;
									anim.SetFloat((int)obj26, num);
									if ((object)anim == null)
									{
										break;
									}
									object obj27 = obj20;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v17+A0]");
									object obj28 = 0;
									Animator animator = anim;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v18+4]");
									animator.SetFloat(0, 1f);
									if ((object)anim == null)
									{
										break;
									}
									anim.Play(0, 0, 0f);
									if ((object)anim == null)
									{
										break;
									}
									anim.Update(0f);
									if ((object)anim == null)
									{
										break;
									}
									AnimatorStateInfo currentAnimatorStateInfo = anim.GetCurrentAnimatorStateInfo(0);
									bool flag17 = num == 0f;
									object obj29 = !flag17;
									object obj30 = ~obj29;
									object obj31 = ((obj30 != null) ? ((object)1) : ((object)8));
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
									object obj32 = obj21;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v21+A0]");
									object obj33 = 0;
									float num3 = 0f / (float)obj31;
									float num4 = (float)obj33;
									object obj34 = 0;
									while (true)
									{
										if (obj34 != null)
										{
											if ((object)anim == null)
											{
												break;
											}
											anim.Update(num3);
											num4 = num3;
										}
										if ((object)neck == null)
										{
											break;
										}
										Quaternion localRotation = neck.localRotation;
										object obj35 = obj20;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X0_v57+E4]");
										bool flag18 = (nint)0 == 0;
										object obj36 = !flag18;
										if (obj36 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										_003CBases_003Eg__Add_007C142_0(ref sum, (Quaternion)0);
										if ((object)skull == null)
										{
											break;
										}
										Quaternion localRotation2 = skull.localRotation;
										_003CBases_003Eg__Add_007C142_0(ref sum2, (Quaternion)0);
										obj34++;
										if (obj31 != obj34)
										{
											continue;
										}
										goto IL_06fd;
									}
									break;
									IL_06fd:
									Vector4 sum3 = (Vector4)obj20;
									object obj37 = obj18;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v64 (UnityEngine.Vector4)+E4]");
									bool flag19 = (nint)0 == 0;
									object obj38 = !flag19;
									if (obj38 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Quaternion sum4 = _003CBases_003Eg__Mean_007C142_1(sum3);
									if (obj18 == null)
									{
										break;
									}
									float num5 = num;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X20_v18+18]");
									bool flag20 = num5 < 0f;
									object obj39 = !flag20;
									if (obj39 == null)
									{
										float num6 = (float)obj18 + num;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v22+4]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v22+8]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v22+C]");
										_ = 0;
										object obj40 = obj19;
										Quaternion quaternion3 = _003CBases_003Eg__Mean_007C142_1((Vector4)sum4);
										if (obj19 == null)
										{
											break;
										}
										float num7 = num;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X20_v19+18]");
										bool flag21 = num7 < 0f;
										object obj41 = !flag21;
										if (obj41 == null)
										{
											float num8 = (float)obj19 + num;
											num++;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v22+4]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v22+8]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v22+C]");
											_ = 0;
											bool flag22 = num != 3f;
											num2 = (float)sum2;
											obj22 = 0;
											quaternion2 = (Quaternion)0;
											if (!flag22)
											{
												object obj42 = obj20;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v67+E4]");
												bool flag23 = (nint)0 == 0;
												object obj43 = !flag23;
												if (obj43 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												if ((object)anim == null)
												{
													break;
												}
												object obj44 = obj20;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v31+A0]");
												object obj45 = 0;
												anim.SetFloat((int)obj45, 0f);
												if ((object)anim == null)
												{
													break;
												}
												object obj46 = obj20;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v33+A0]");
												object obj47 = 0;
												Animator animator2 = anim;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v34+4]");
												animator2.SetFloat(0, 1f);
												if ((object)anim == null)
												{
													break;
												}
												anim.Play(0, 0, 0f);
												if ((object)anim == null)
												{
													break;
												}
												anim.Update(0f);
												if ((object)anim == null)
												{
													break;
												}
												anim.fireEvents = fireEvents;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC968]");
												object obj48 = 0;
												object obj49 = this + 112;
												obj49 = obj48;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												return;
											}
											continue;
										}
									}
									goto IL_0a8c;
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0a8c;
		IL_0a8c:
		throw new IndexOutOfRangeException();
	}

	private void Stomps(float dt)
	{
		//IL_0b56: Expected Obj, but got I
		//IL_0b66: Expected Obj, but got I
		//IL_0b76: Expected Obj, but got I
		//IL_0b7f: Expected Obj, but got I4
		//IL_0b88: Expected Obj, but got I4
		//IL_0ba5: Expected F4, but got I
		//IL_001c: Expected Obj, but got I4
		//IL_0bcc: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I4
		//IL_0086: Expected I, but got Obj
		//IL_0be3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be8: Expected Obj, but got Unknown
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Expected Obj, but got Unknown
		//IL_00ca: Expected Obj, but got I
		//IL_0227: Expected F4, but got I4
		//IL_0247: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got I4
		//IL_028e: Invalid comparison between F4 and I4
		//IL_029d: Invalid comparison between F4 and I4
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02c5: Expected Obj, but got F4
		//IL_02fa: Expected Obj, but got I4
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0158: Expected F8, but got I
		//IL_0168: Expected Obj, but got I
		//IL_033b: Expected F4, but got I
		//IL_0c48: Expected Obj, but got I4
		//IL_035b: Expected Obj, but got I4
		//IL_03cb: Expected Obj, but got I4
		//IL_0431: Expected Obj, but got I4
		//IL_0ccd: Expected Obj, but got I
		//IL_0cdd: Expected Obj, but got I
		//IL_0cf5: Expected F8, but got I
		//IL_0d05: Expected Obj, but got I
		//IL_0d27: Expected Obj, but got I4
		//IL_052b: Expected VT, but got I4
		//IL_052b: Expected VT, but got I8
		//IL_04cd: Expected Obj, but got I4
		//IL_0a7a: Expected Obj, but got I4
		//IL_04e4: Expected Obj, but got I4
		//IL_04f2: Expected I, but got Obj
		//IL_0590: Expected Obj, but got I4
		//IL_05cf: Expected Obj, but got I4
		//IL_05f0: Expected VT, but got I4
		//IL_0b01: Expected Obj, but got I4
		//IL_09f1: Expected Obj, but got I4
		//IL_0b17: Expected Obj, but got I4
		//IL_0642: Expected Obj, but got I4
		//IL_0a31: Expected I, but got VT
		//IL_066f: Expected F4, but got I
		//IL_0691: Expected Obj, but got I4
		//IL_06b3: Expected Obj, but got I4
		//IL_06d9: Expected VT, but got I4
		//IL_072b: Expected Obj, but got I4
		//IL_0749: Invalid comparison between F4 and I
		//IL_076f: Expected F4, but got I
		//IL_0778: Expected VT, but got I4
		//IL_07a5: Expected F4, but got I
		//IL_07db: Expected F4, but got I
		//IL_07e4: Expected VT, but got I4
		//IL_0839: Expected VT, but got I4
		//IL_087d: Expected Obj, but got I4
		//IL_088d: Expected Obj, but got I
		//IL_08da: Expected Obj, but got I4
		//IL_0d6e: Expected Obj, but got I
		//IL_0d7e: Expected Obj, but got I
		//IL_0daf: Expected VT, but got I4
		//IL_0902: Expected Obj, but got I
		//IL_0931: Expected Obj, but got I4
		//IL_09b6: Expected VT, but got I
		//IL_0959: Expected Obj, but got I
		//IL_0971: Expected Obj, but got I
		//IL_0981: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj3 = 0;
		object obj4 = 0;
		object obj5 = 0;
		double num = 30.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		float num2 = 0f;
		object obj10 = default;
		float num3 = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		while (true)
		{
			object obj6 = obj;
			if (obj5 == null)
			{
				object obj7 = 40;
			}
			else
			{
				object obj7 = 48;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v193 @ X8_v7]");
			bool flag2 = (UnityEngine.Object)0 == null;
			bool flag3 = !flag2;
			object obj9 = !flag3;
			obj10 = obj10;
			num3 = num3;
			float num4 = num2;
			int num5 = 0;
			nint num6 = unchecked((nint)null);
			bool[] array6;
			bool flag16;
			Vector3 vector;
			object obj32;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v193 @ X8_v7]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterAvatar)+v193 @ X8_v7]");
					Vector3 position = ((Transform)0).position;
					if (~(handsKnown ? 1u : 0u) == 0)
					{
						Vector3[] array = handWas;
						if (handWas == null)
						{
							goto IL_0b31;
						}
						bool flag4 = (nint)obj5 < array.Length;
						object obj11 = !flag4;
						if (obj11 != null)
						{
							break;
						}
						object obj12 = (object)handWas + obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v57+24]");
						double num7 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v57+28]");
						object obj13 = 0;
						object obj14 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v36+E4]");
						bool flag5 = (nint)0 == 0;
						object obj15 = !flag5;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num8 = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v57+20]");
						float num9 = num8 - 0f;
						float num10 = num3 - (float)num7;
						object obj16 = obj10 - obj13;
						float num11 = num9 * num9;
						float num12 = num10 * num10;
						obj10 = obj16 * obj16;
						float num13 = num11 + num12;
						float num14 = num13 + (float)obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						num4 = num14 / dt;
					}
					else
					{
						obj10 = obj10;
						num4 = 0f;
					}
					float[] array2 = handSpeed;
					if (handSpeed != null)
					{
						bool flag6 = (nint)obj5 < array2.Length;
						object obj17 = !flag6;
						if (obj17 != null)
						{
							break;
						}
						object obj18 = (object)handSpeed + obj5;
						Vector3[] array3 = handWas;
						float num15 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v15+20]");
						float num16 = num15 - 0f;
						bool flag7 = num16 < 0f;
						bool flag8 = num16 == 0f;
						float num17 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v15+20]");
						object obj19 = num17 ^ 0;
						object obj20 = num4 ^ num16;
						object obj21 = obj19 & obj20;
						bool flag9 = (nint)obj21 < 0;
						bool flag10 = flag7 == flag9;
						object obj22 = !flag8;
						object obj23 = flag10 & obj22;
						object obj24 = ~obj23;
						float num18;
						if (obj24 == null)
						{
							num18 = num4;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v15+20]");
							num18 = 0f;
						}
						if (handWas != null)
						{
							bool flag11 = (nint)obj5 < array3.Length;
							object obj25 = !flag11;
							if (obj25 != null)
							{
								break;
							}
							object obj26 = (object)handWas + obj4;
							float[] array4 = handSpeed;
							if (handSpeed != null)
							{
								bool flag12 = (nint)obj5 < array4.Length;
								object obj27 = !flag12;
								if (obj27 != null)
								{
									break;
								}
								object obj28 = (object)handSpeed + obj5;
								float[] array5 = stompIn;
								if (stompIn != null)
								{
									bool flag13 = (nint)obj5 < array5.Length;
									object obj29 = !flag13;
									if (obj29 != null)
									{
										break;
									}
									object obj30 = (object)stompIn + obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v20+20]");
									num3 = 0f - dt;
									if ((double)num4 > num)
									{
										array6 = onFloor;
										if (onFloor != null)
										{
											bool flag14 = (nint)obj5 < array6.Length;
											object obj31 = !flag14;
											if (obj31 != null)
											{
												break;
											}
											obj32 = 0;
											num5 = 0;
											num6 = unchecked((nint)null);
											goto IL_0c9e;
										}
									}
									else
									{
										object obj33 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
										object obj34 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v25+A0]");
										object obj35 = 0;
										object obj36 = obj34;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v26+24]");
										double num7 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v26+28]");
										object obj13 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X0_v17+E4]");
										bool flag15 = (nint)0 == 0;
										object obj37 = !flag15;
										if (obj37 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										flag16 = Physics.Raycast((Vector3)4294961403L, (Vector3)1, num2, 0, queryTriggerInteraction);
										if (flag16)
										{
											bool[] array7 = onFloor;
											if (onFloor != null)
											{
												bool flag17 = (nint)obj5 < array7.Length;
												object obj38 = !flag17;
												if (obj38 != null)
												{
													break;
												}
												object obj39 = (object)onFloor + obj5;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v32+20]");
												bool flag18 = (nint)0 == 0;
												object obj40 = !flag18;
												double num19 = num7;
												num3 = num3;
												num4 = num2;
												vector = (Vector3)1;
												if (obj40 == null)
												{
													float[] array8 = stompIn;
													if (stompIn == null)
													{
														goto IL_0b31;
													}
													bool flag19 = (nint)obj5 < array8.Length;
													object obj41 = !flag19;
													if (obj41 != null)
													{
														break;
													}
													object obj42 = (object)stompIn + obj5;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v38+20]");
													num4 = 0f;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v38+20]");
													bool flag20 = (nint)0 < (nint)0;
													object obj43 = !flag20;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v38+20]");
													bool flag21 = (nint)0 == 0;
													object obj44 = !flag21;
													object obj45 = obj43 & obj44;
													num19 = num7;
													num3 = num3;
													vector = (Vector3)1;
													if (obj45 == null)
													{
														float[] array9 = offFloor;
														if (offFloor == null)
														{
															goto IL_0b31;
														}
														bool flag22 = (nint)obj5 < array9.Length;
														object obj46 = !flag22;
														if (obj46 != null)
														{
															break;
														}
														float num20 = num18;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
														bool flag23 = num20 < 0f;
														num19 = num7;
														num3 = num3;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
														num4 = 0f;
														vector = (Vector3)1;
														if (!flag23)
														{
															object obj47 = (object)offFloor + obj5;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v40+20]");
															num4 = 0f;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v40+20]");
															nint num21 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
															bool flag24 = num21 < 0;
															num19 = num7;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
															num3 = 0f;
															vector = (Vector3)1;
															if (!flag24)
															{
																if ((object)events != null)
																{
																	num19 = (double)num18 / 5.0;
																	events.Stomp((Vector3)0, num2);
																	float[] array10 = stompIn;
																	if (stompIn != null)
																	{
																		bool flag25 = (nint)obj5 < array10.Length;
																		object obj48 = !flag25;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
																		object obj49 = 0;
																		if (obj48 != null)
																		{
																			break;
																		}
																		object obj50 = obj49;
																		object obj51 = (object)stompIn + obj5;
																		_ = 1039516303;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X0_v25+E4]");
																		bool flag26 = (nint)0 == 0;
																		object obj52 = !flag26;
																		if (obj52 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
																			object obj53 = 0;
																			obj50 = obj53;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X0_v25+A0]");
																		object obj54 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v44+8]");
																		object obj55 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v44+8]");
																		bool flag27 = (nint)0 == 0;
																		num3 = num3;
																		num4 = num2;
																		vector = (Vector3)0;
																		if (!flag27)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X0_v25+E4]");
																			bool flag28 = (nint)0 == 0;
																			object obj56 = !flag28;
																			if (obj56 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
																				object obj57 = 0;
																				object obj58 = obj57;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v49+A0]");
																				object obj59 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X8_v50+8]");
																				obj55 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X8_v50+8]");
																				if ((nint)0 == 0)
																				{
																					goto IL_0b31;
																				}
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v46+28]");
																			vector = (Vector3)0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v754 @ X8_v46+18] (should have been resolved before IL gen)");
																			num3 = num3;
																			num4 = num2;
																		}
																		goto IL_0d35;
																	}
																}
																goto IL_0b31;
															}
														}
													}
												}
												goto IL_0d35;
											}
										}
										else
										{
											float[] array11 = offFloor;
											if (offFloor != null)
											{
												bool flag29 = (nint)obj5 < array11.Length;
												object obj60 = !flag29;
												if (obj60 != null)
												{
													break;
												}
												object obj61 = (object)offFloor + obj5;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v30+20]");
												num4 = 0f + dt;
												num = 30.0;
												double num19 = num7;
												obj10 = obj10;
												num3 = num3;
												num6 = 1;
												goto IL_0dbd;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_0b31;
			}
			goto IL_0bda;
			IL_0c9e:
			object obj62 = (object)array6 + obj5;
			goto IL_0bda;
			IL_0bda:
			obj5++;
			obj4 += 12;
			bool flag30 = (nint)obj5 != 2;
			num2 = num4;
			if (!flag30)
			{
				handsKnown = true;
				return;
			}
			continue;
			IL_0d35:
			float[] array12 = offFloor;
			if (offFloor == null)
			{
				goto IL_0b31;
			}
			bool flag31 = (nint)obj5 < array12.Length;
			object obj63 = !flag31;
			if (obj63 != null)
			{
				break;
			}
			object obj64 = (object)offFloor + obj5;
			_ = 0;
			num = 30.0;
			obj10 = obj10;
			num6 = (nint)vector;
			goto IL_0dbd;
			IL_0b31:
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_0dbd:
			array6 = onFloor;
			if (onFloor == null)
			{
				goto IL_0b31;
			}
			bool flag32 = (nint)obj5 < array6.Length;
			object obj65 = !flag32;
			if (obj65 != null)
			{
				break;
			}
			obj32 = flag16;
			num5 = 0;
			goto IL_0c9e;
		}
		throw new IndexOutOfRangeException();
	}

	private void Steps(float walk, float run, float dt)
	{
		//IL_046c: Expected Obj, but got I
		//IL_04c3: Invalid comparison between F4 and I4
		//IL_04d2: Invalid comparison between F4 and I4
		//IL_04e5: Expected Obj, but got F4
		//IL_04f2: Expected Obj, but got F4
		//IL_0527: Expected Obj, but got I4
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected Obj, but got Unknown
		//IL_0563: Invalid comparison between F4 and I4
		//IL_0572: Invalid comparison between F4 and I4
		//IL_0585: Expected Obj, but got F4
		//IL_0592: Expected Obj, but got F4
		//IL_05c7: Expected Obj, but got I4
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected Obj, but got Unknown
		//IL_0602: Expected F8, but got I4
		//IL_0663: Invalid comparison between F8 and I4
		//IL_0676: Expected Obj, but got F8
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Expected Obj, but got Unknown
		//IL_06b5: Expected Obj, but got I4
		//IL_005c: Invalid comparison between F4 and I4
		//IL_006b: Expected F8, but got I4
		//IL_06e5: Expected Obj, but got I4
		//IL_06fd: Invalid comparison between F8 and I4
		//IL_071f: Expected Obj, but got I4
		//IL_076f: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I
		//IL_011b: Expected I4, but got Obj
		//IL_012e: Expected I4, but got Obj
		//IL_0152: Invalid comparison between F4 and I4
		//IL_0325: Invalid comparison between F4 and I
		//IL_0334: Expected Obj, but got I4
		//IL_01c0: Invalid comparison between F8 and I4
		//IL_01cf: Expected F8, but got I4
		//IL_0303: Expected Obj, but got I4
		//IL_078d: Invalid comparison between F8 and I
		//IL_0361: Expected F4, but got I
		//IL_0371: Invalid comparison between F4 and I
		//IL_0838: Invalid comparison between F8 and I4
		//IL_0847: Invalid comparison between F8 and I4
		//IL_0861: Expected Obj, but got F8
		//IL_0870: Expected Obj, but got F8
		//IL_08a5: Expected Obj, but got I4
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected Obj, but got Unknown
		//IL_07bd: Expected Obj, but got I4
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected Obj, but got Unknown
		//IL_023b: Invalid comparison between F8 and I4
		//IL_024a: Invalid comparison between F8 and I4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_0272: Expected Obj, but got F8
		//IL_0395: Invalid comparison between F4 and I
		//IL_02d1: Expected F4, but got I4
		//IL_08d4: Invalid comparison between F4 and I4
		//IL_07fd: Expected Obj, but got I4
		//IL_02c3: Expected F4, but got I
		//IL_0954: Invalid comparison between F4 and I4
		//IL_0967: Expected Obj, but got F4
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected Obj, but got Unknown
		//IL_09a6: Expected Obj, but got I4
		//IL_03c4: Expected F4, but got I
		//IL_03f3: Expected F8, but got I4
		//IL_09d6: Expected Obj, but got I4
		//IL_09ee: Invalid comparison between F4 and I4
		//IL_0a10: Expected Obj, but got I4
		//IL_0a60: Expected Obj, but got I4
		//IL_043e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
		object obj = 0;
		float num = walk * 4f;
		float num2 = walk * 2.5f;
		float num3 = walk;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
		float num4 = num3 * 0f;
		float num5 = num - run;
		bool flag = num5 < 0f;
		bool flag2 = num5 == 0f;
		object obj2 = num ^ run;
		object obj3 = num ^ num5;
		object obj4 = obj2 & obj3;
		bool flag3 = (nint)obj4 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		object obj6 = flag4 & obj5;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
			num = run;
		}
		float num6 = num2 - num;
		bool flag5 = num6 < 0f;
		bool flag6 = num6 == 0f;
		object obj8 = num2 ^ num;
		object obj9 = num2 ^ num6;
		object obj10 = obj8 & obj9;
		bool flag7 = (nint)obj10 < 0;
		bool flag8 = flag5 == flag7;
		object obj11 = !flag6;
		object obj12 = flag8 & obj11;
		object obj13 = ~obj12;
		if (obj13 != null)
		{
			num2 = num;
		}
		bool flag9 = num4 == num2;
		double num7 = 0.0;
		if (!flag9)
		{
			float num8 = num2 - num4;
			float num9 = speed - num4;
			float num10 = num9 / num8;
			bool flag10 = num10 < 0f;
			num7 = 0.0;
			if (!flag10)
			{
				bool flag11 = !((double)num10 > 1.0);
				num7 = num10;
				if (!flag11)
				{
					num7 = 1.0;
				}
			}
		}
		object obj14 = obj;
		double num11 = num7 - (double)running;
		float num12 = dt * 3f;
		float num13 = dt * 3f;
		float num14 = 0f - num13;
		bool flag12 = num11 < 0.0;
		object obj15 = num11 ^ num11;
		object obj16 = num11 & obj15;
		bool flag13 = (nint)obj16 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag14 = flag12 == flag13;
		object obj17 = !flag14;
		object obj18 = ~obj17;
		if (obj18 != null)
		{
			num14 = num12;
		}
		bool flag15 = num11 < (double)num12;
		object obj19 = !flag15;
		double num15 = num11 - (double)num12;
		bool flag16 = num15 == 0.0;
		float num16 = running + num14;
		object obj20 = !flag16;
		object obj21 = obj19 & obj20;
		object obj22 = ~obj21;
		if (obj22 == null)
		{
			num7 = num16;
		}
		running = (float)num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v2+E4]");
		bool flag17 = (nint)0 == 0;
		object obj23 = !flag17;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v6+A0]");
		object obj25 = 0;
		float value = running + 1f;
		int num17 = (int)obj25;
		anim.SetFloat((int)obj25, value);
		float num18 = speed;
		float num19 = speed / walk;
		if (num19 < 0f)
		{
			goto IL_0169;
		}
		object obj26;
		if ((double)num19 > 2.5)
		{
			obj26 = 0;
			num19 = 2.5f;
		}
		else
		{
			float num20 = num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			bool flag18 = num20 < 0f;
			obj26 = 0;
			if (flag18)
			{
				goto IL_0169;
			}
		}
		goto IL_0342;
		IL_0169:
		AnimatorStateInfo currentAnimatorStateInfo = anim.GetCurrentAnimatorStateInfo(0);
		object obj28 = default;
		object obj27 = obj28 + obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		double num21 = (double)obj27 * -0.5;
		double num22 = (double)obj28 + num21;
		bool flag19 = num22 < 0.0;
		double num23 = 0.0;
		if (!flag19)
		{
			bool flag20 = !(num22 > 0.5);
			num23 = num22;
			if (!flag20)
			{
				num23 = 0.5;
			}
		}
		double num24 = num23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A810]");
		bool flag21;
		bool flag22;
		bool flag23;
		if (num24 < 0.0)
		{
			double num25 = num23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
			double num26 = num25 - 0.0;
			flag21 = num26 < 0.0;
			flag22 = num26 == 0.0;
			double num27 = num23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
			object obj29 = num27 ^ 0;
			object obj30 = num23 ^ num26;
			object obj31 = obj29 & obj30;
			flag23 = (nint)obj31 < 0;
		}
		else
		{
			flag23 = false;
			flag22 = true;
			flag21 = false;
		}
		bool flag24 = flag21 == flag23;
		object obj32 = !flag22;
		object obj33 = flag24 & obj32;
		object obj34 = ~obj33;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			num19 = 0f;
		}
		else
		{
			num19 = 0f;
		}
		num18 = speed;
		num17 = 0;
		obj26 = 0;
		goto IL_0342;
		IL_0342:
		float num28 = num18 / run;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		float num29 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		if (!(num28 < 0f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE6C]");
			bool flag25 = !(num28 > 0f);
			num29 = num28;
			if (!flag25)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE6C]");
				num29 = 0f;
			}
		}
		float num30 = num29 - num19;
		object obj35 = obj;
		double num31 = (double)running - 1.0;
		bool flag26 = num31 < 0.0;
		bool flag27 = num31 == 0.0;
		object obj36 = (double)running ^ 1.0;
		object obj37 = (double)running ^ num31;
		object obj38 = obj36 & obj37;
		bool flag28 = (nint)obj38 < 0;
		bool flag29 = flag26 == flag28;
		object obj39 = !flag29;
		object obj40 = obj39 | flag27;
		object obj41 = ~obj40;
		double num32 = ((obj41 != null) ? 1.0 : ((double)running));
		if (running < 0f)
		{
			num32 = 0.0;
		}
		float num33 = num30 * (float)num32;
		float num34 = dt * 4f;
		float num35 = dt * 4f;
		float num36 = 0f - num35;
		float num37 = num19 + num33;
		float num38 = num37 - pace;
		bool flag30 = num38 < 0f;
		object obj42 = num38 ^ num38;
		object obj43 = num38 & obj42;
		bool flag31 = (nint)obj43 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag32 = flag30 == flag31;
		object obj44 = !flag32;
		object obj45 = ~obj44;
		if (obj45 != null)
		{
			num36 = num34;
		}
		bool flag33 = num38 < num34;
		object obj46 = !flag33;
		float num39 = num38 - num34;
		bool flag34 = num39 == 0f;
		float num40 = pace + num36;
		object obj47 = !flag34;
		object obj48 = obj46 & obj47;
		object obj49 = ~obj48;
		if (obj49 == null)
		{
			num37 = num40;
		}
		pace = num37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v8+E4]");
		bool flag35 = (nint)0 == 0;
		object obj50 = !flag35;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj51 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v11+A0]");
		object obj52 = 0;
		Animator animator = anim;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v12+4]");
		animator.SetFloat(0, pace);
	}

	private static void Copy(HandPoser from, HandPoser to)
	{
		//IL_0010: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
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
		bool flag2 = from == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = to == null;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				to.trigger = from.trigger;
				to.thumbPress = from.thumbPress;
			}
		}
	}

	private static bool Turns(Transform index1, Transform pinkie1, Vector3 palmLocal)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01b7: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
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
		if (index1 != null)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (pinkie1 != null)
			{
				object obj7 = default;
				object obj6 = obj7 * obj7;
				object obj9 = default;
				object obj8 = obj9 * obj9;
				object obj10 = obj6 + obj8;
				object obj12 = default;
				object obj11 = obj12 * obj12;
				object obj13 = obj11 + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
				object obj14 = obj13 - 0;
				bool flag3 = (nint)obj14 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
				object obj15 = obj13 ^ 0;
				object obj16 = obj13 ^ obj14;
				object obj17 = obj15 & obj16;
				bool flag4 = (nint)obj17 < 0;
				return flag3 == flag4;
			}
		}
		return false;
	}

	private static Quaternion Turned(Transform hand, Transform index1, Transform pinkie1, Vector3 palmLocal, Quaternion aim, float palmSide)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05b9: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_058f: Expected VT, but got Obj
		//IL_0084: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_0132: Invalid comparison between F4 and I
		//IL_0215: Expected Obj, but got I
		//IL_02a8: Expected VT, but got I4
		//IL_030c: Invalid comparison between F8 and I
		//IL_05d6: Expected VT, but got I4
		//IL_05d6: Expected VT, but got I4
		//IL_0600: Expected VT, but got I4
		//IL_0600: Expected VT, but got I4
		//IL_0613: Expected VT, but got I4
		//IL_0613: Expected VT, but got I4
		//IL_062b: Expected VT, but got I4
		//IL_062b: Expected VT, but got I4
		//IL_0662: Expected Obj, but got I
		//IL_0696: Expected Obj, but got I
		//IL_06da: Invalid comparison between F4 and Obj
		//IL_0765: Invalid comparison between F8 and Obj
		//IL_0749: Invalid comparison between F4 and I
		//IL_04f4: Invalid comparison between F4 and I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = index1 == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = pinkie1 == null;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				float num = palmSide * palmSide;
				double num3 = default;
				double num2 = num3 * num3;
				float num4 = num + (float)num2;
				double num6 = default;
				double num5 = num6 * num6;
				float num7 = (float)num5 + num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
				if (!(num7 < 0f))
				{
					if ((object)index1 != null)
					{
						Vector3 position = index1.position;
						if ((object)pinkie1 != null)
						{
							Vector3 position2 = pinkie1.position;
							if ((object)hand != null)
							{
								double num8 = num6 + num6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
								nint num9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
								object obj8 = num9 + 0;
								float num10 = num7 + num7;
								double num11 = num8 * 0.5;
								double num12 = (double)obj8 * 0.5;
								float num13 = num10 * 0.5f;
								Vector3 position3 = hand.position;
								float num14 = num13 - num10;
								double num15 = num12 - (double)obj8;
								double num16 = num11 - num8;
								Vector3 vector = hand.TransformDirection((Vector3)0);
								float num17 = num14 * num14;
								double num18 = num15 * num15;
								float num19 = num17 + (float)num18;
								double num20 = num16 * num16;
								double num21 = num20 + (double)num19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
								if (!(num21 < 0.0))
								{
									Vector3 vector2 = (Quaternion)0 * (Vector3)0;
									Vector3 axis = default;
									Quaternion quaternion = Quaternion.Internal_AngleAxis(60f, ref axis);
									Vector3 vector3 = (Quaternion)0 * (Vector3)0;
									Vector3 vector4 = (Quaternion)0 * (Vector3)0;
									Vector3 vector5 = (Quaternion)0 * (Vector3)0;
									float num22 = 1.1146363E+09f * 1.1146363E+09f;
									object obj10 = default;
									object obj9 = obj10 * obj10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
									object obj11 = 0;
									object obj12 = obj11;
									float num23 = num22 + (float)obj9;
									object obj14 = default;
									object obj13 = obj14 * obj14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v27+A0]");
									object obj15 = 0;
									float num24 = (float)obj13 + num23;
									Vector3 vector6 = default;
									object obj16 = default;
									float num25 = (float)vector6 * (float)obj16;
									float num26 = (float)obj10 * (float)obj16;
									float num27 = (float)obj14 * (float)obj16;
									if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num24) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15))
									{
										float num28 = 1.1146363E+09f * num25;
										float num29 = (float)obj10 * num26;
										float num30 = (float)obj14 * num27;
										float num31 = num28 + num29;
										float num32 = num30 + num31;
										float num33 = num32 / num24;
										float num34 = 1.1146363E+09f * num33;
										float num35 = (float)obj10 * num33;
										float num36 = (float)obj14 * num33;
										num25 -= num34;
										num26 -= num35;
										num27 -= num36;
									}
									bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15);
									double num37 = num6;
									double num38 = num3;
									float num39 = palmSide;
									if (!flag7)
									{
										float num40 = palmSide * num14;
										double num41 = num3 * num15;
										double num42 = num6 * num16;
										float num43 = num40 + (float)num41;
										double num44 = num42 + (double)num43;
										double num45 = num44 / num21;
										float num46 = num14 * (float)num45;
										double num47 = num15 * num45;
										double num48 = num16 * num45;
										num39 = palmSide - num46;
										num38 = num3 - num47;
										num37 = num6 - num48;
									}
									float num49 = num25 * num25;
									float num50 = num26 * num26;
									float num51 = num49 + num50;
									float num52 = num27 * num27;
									float num53 = num51 + num52;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
									if (!(num53 < 0f))
									{
										float num54 = num39 * num39;
										double num55 = num38 * num38;
										float num56 = num54 + (float)num55;
										double num57 = num37 * num37;
										float num58 = num56 + (float)num57;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
										if (!(num58 < 0f))
										{
											Vector3 upwards = default;
											Quaternion quaternion2 = Quaternion.Internal_LookRotation(ref axis, ref upwards);
											Quaternion quaternion3 = Quaternion.Internal_LookRotation(ref axis, ref upwards);
											Quaternion rotation = default;
											Quaternion quaternion4 = Quaternion.Internal_Inverse(ref rotation);
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
											Quaternion rotation2 = hand.rotation;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
											Quaternion result = default;
											return result;
										}
									}
									return hand.rotation;
								}
								goto IL_0166;
							}
						}
					}
					goto IL_0581;
				}
			}
		}
		if ((object)hand != null)
		{
			goto IL_0166;
		}
		goto IL_0581;
		IL_0166:
		return hand.rotation;
		IL_0581:
		NullReferenceException ex = new NullReferenceException();
		return (Quaternion)ex;
	}

	private static Vector3 WristFor(Vector3 at, Transform hand, Transform index1, Transform pinkie1, Quaternion turned)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0054: Expected VT, but got I4
		//IL_008c: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I4
		//IL_00d9: Expected VT, but got I4
		//IL_01c2: Expected VT, but got Obj
		//IL_0144: Invalid comparison between VT and I4
		//IL_0161: Expected Obj, but got VT
		//IL_016e: Expected Obj, but got VT
		//IL_0193: Expected VT, but got I4
		//IL_0193: Expected VT, but got I4
		//IL_01ab: Expected VT, but got I4
		//IL_01ab: Expected VT, but got I4
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
		bool flag2 = hand == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		Vector3 result = (Vector3)flag2;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = index1 == null;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			result = (Vector3)flag5;
			if (obj7 == null)
			{
				if ((object)hand != null)
				{
					Vector3 position = hand.position;
					if ((object)index1 != null)
					{
						Vector3 position2 = index1.position;
						if (at != (Vector3)(object)0)
						{
							Vector3 position3 = ((Transform)at).position;
							Quaternion rotation = ((Transform)at).rotation;
							Quaternion rotation2 = default;
							Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation2);
							Vector3 vector = (Quaternion)0 * (Vector3)0;
							result = (Quaternion)0 * (Vector3)0;
							goto IL_01fa;
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (Vector3)ex;
			}
		}
		goto IL_01fa;
		IL_01fa:
		return result;
	}

	private static int Along(Transform bone, Transform child)
	{
		//IL_0219: Expected I4, but got Obj
		//IL_0089: Expected VT, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0293: Expected Obj, but got I4
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_02d0: Expected Obj, but got I4
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		if ((object)child != null)
		{
			Vector3 position = child.position;
			if ((object)bone != null)
			{
				Vector3 position2 = bone.position;
				object obj2 = default;
				object obj = obj2 - obj2;
				object obj4 = default;
				object obj3 = obj4 - obj4;
				object obj6 = default;
				object obj5 = obj6 - obj6;
				Vector3 vector = bone.InverseTransformDirection((Vector3)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				object obj7 = obj3 - obj5;
				bool flag = (nint)obj7 < 0;
				bool flag2 = obj7 == null;
				object obj8 = obj3 ^ obj5;
				object obj9 = obj3 ^ obj7;
				object obj10 = obj8 & obj9;
				bool flag3 = (nint)obj10 < 0;
				bool flag4 = flag == flag3;
				object obj11 = !flag4;
				object obj12 = obj11 | flag2;
				object obj13 = ~obj12;
				int result = ((obj13 != null) ? 1 : 2);
				object obj14 = obj - obj5;
				bool flag5 = (nint)obj14 < 0;
				bool flag6 = obj14 == null;
				object obj15 = obj ^ obj5;
				object obj16 = obj ^ obj14;
				object obj17 = obj15 & obj16;
				bool flag7 = (nint)obj17 < 0;
				bool flag8 = flag5 == flag7;
				object obj18 = !flag6;
				object obj19 = flag8 & obj18;
				object obj20 = ~obj19;
				bool flag9;
				bool flag10;
				bool flag11;
				if (obj20 == null)
				{
					object obj21 = obj - obj3;
					flag9 = (nint)obj21 < 0;
					flag10 = obj21 == null;
					object obj22 = obj ^ obj3;
					object obj23 = obj ^ obj21;
					object obj24 = obj22 & obj23;
					flag11 = (nint)obj24 < 0;
				}
				else
				{
					flag11 = false;
					flag10 = true;
					flag9 = false;
				}
				bool flag12 = flag9 == flag11;
				object obj25 = !flag12;
				object obj26 = obj25 | flag10;
				object obj27 = ~obj26;
				if (obj27 == null)
				{
					return result;
				}
				return 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private unsafe static Vector3 ScaleAlong(Vector3 scale, int axis, float s)
	{
		//IL_0009: Invalid comparison between VT and I4
		//IL_007c: Expected Obj, but got Ref
		//IL_0026: Invalid comparison between VT and I4
		//IL_006f: Expected Obj, but got Ref
		//IL_0043: Invalid comparison between VT and I4
		//IL_0062: Expected Obj, but got Ref
		//IL_00d3: Expected VT, but got Obj
		object obj;
		if (scale != (Vector3)(object)0)
		{
			if (scale != (Vector3)(object)1)
			{
				if (scale != (Vector3)(object)2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					IndexOutOfRangeException ex = default;
					string message = default;
					ex._002Ector(message);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					ArgumentNullException ex2 = new ArgumentNullException();
					return (Vector3)ex2;
				}
				object obj2 = default;
				obj = (object)(&obj2);
			}
			else
			{
				object obj3 = default;
				obj = (object)(&obj3);
			}
		}
		else
		{
			object obj4 = default;
			obj = (object)(&obj4);
		}
		object obj6 = default;
		object obj5 = obj * obj6;
		obj = obj5;
		return scale;
	}

	private static void Stretch(Transform up, Transform lo, Transform end, Vector3 target, Vector3 restUp, Vector3 restLo, int axisUp, int axisLo, float w, float straight = default(float), float most = default(float))
	{
		//IL_0010: Expected Obj, but got I
		//IL_0685: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		//IL_0162: Expected VT, but got I4
		//IL_0175: Expected VT, but got I4
		//IL_06a3: Expected Obj, but got I
		//IL_06cd: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got I
		//IL_071f: Expected Obj, but got I4
		//IL_0761: Expected Obj, but got I4
		//IL_0354: Invalid comparison between Obj and F8
		//IL_0536: Expected Obj, but got I4
		//IL_054e: Invalid comparison between F4 and I4
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected Obj, but got Unknown
		//IL_03d8: Invalid comparison between F4 and Obj
		//IL_03e9: Expected Obj, but got I4
		//IL_0401: Invalid comparison between F4 and I4
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected Obj, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected Obj, but got Unknown
		//IL_043b: Expected Obj, but got I
		//IL_07a3: Expected Obj, but got I
		//IL_07f0: Expected Obj, but got I4
		//IL_062c: Expected VT, but got I4
		//IL_0643: Expected F4, but got I
		//IL_0655: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = up == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = lo == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v11+E4]");
		bool flag7 = (nint)0 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = end == null;
		bool flag9 = !flag8;
		object obj10 = !flag9;
		if (obj10 != null)
		{
			return;
		}
		up.localScale = (Vector3)0;
		lo.localScale = (Vector3)0;
		Vector3 position = lo.position;
		Vector3 position2 = up.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v24+E4]");
		bool flag10 = (nint)0 == 0;
		object obj13 = !flag10;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		nint num = default;
		object obj14 = num - num;
		object obj16 = default;
		object obj15 = obj16 - obj16;
		object obj18 = default;
		object obj17 = obj18 - obj18;
		object obj19 = obj14 * obj14;
		object obj20 = obj15 * obj15;
		Vector3 position3 = end.position;
		Vector3 position4 = lo.position;
		object obj21 = obj11;
		object obj22 = obj19 + obj20;
		object obj23 = obj17 * obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v31+E4]");
		bool flag11 = (nint)0 == 0;
		object obj24 = !flag11;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj25 = obj23 + obj22;
		Vector3 position5 = up.position;
		object obj26 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj27 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v36+E4]");
		bool flag12 = (nint)0 == 0;
		object obj28 = !flag12;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		if ((nint)obj25 < 0)
		{
			return;
		}
		object obj29 = obj14 - obj14;
		object obj30 = obj15 - obj15;
		object obj31 = obj18 - obj18;
		object obj32 = obj29 * obj29;
		object obj33 = obj30 * obj30;
		object obj34 = obj31 * obj31;
		object obj35 = obj32 + obj33;
		float num2 = w - (float)obj14;
		object obj36 = obj34 + obj35;
		float num3 = straight - (float)obj15;
		float num4 = num2 * num2;
		float num5 = most - (float)obj26;
		float num6 = num3 * num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num7 = num4 + num6;
		float num8 = num5 * num5;
		float num9 = num8 + num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj37 = default;
		float num18;
		double num19;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj37) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1.0))
		{
			object obj38 = obj25 + obj25;
			object obj39 = obj25 * obj25;
			object obj40 = obj36 * obj36;
			object obj41 = obj38 * obj36;
			object obj42 = obj39 + obj40;
			object obj43 = obj41 * obj37;
			object obj44 = obj42 + obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			bool flag13 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44);
			object obj45 = !flag13;
			float num10 = num9 - (float)obj44;
			bool flag14 = num10 == 0f;
			object obj46 = ~obj45;
			object obj47 = obj46 | flag14;
			if (obj47 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B024]");
			object obj48 = 0;
			object obj49 = obj37 * obj37;
			object obj50 = obj36 * obj37;
			float num11 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B024]");
			float num12 = num11 * 0f;
			double num13 = 1.0 - (double)obj49;
			float num14 = num12 * num12;
			double num15 = num13 * (double)obj40;
			float num16 = num14 - (float)num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float num17 = num16 - (float)obj50;
			num18 = num17 / (float)obj25;
			obj26 = obj37;
			num19 = 1.0;
		}
		else
		{
			object obj51 = obj25 + obj36;
			double num20 = (double)obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA98]");
			double num15 = num20 * 0.0;
			bool flag15 = (double)num9 < num15;
			object obj52 = !flag15;
			float num21 = num9 - (float)num15;
			bool flag16 = num21 == 0f;
			object obj53 = ~obj52;
			object obj54 = obj53 | flag16;
			if (obj54 != null)
			{
				return;
			}
			float num22 = num9 - (float)obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA98]");
			object obj55 = obj25 * 0;
			num18 = num22 / (float)obj55;
			object obj48 = obj37;
			num19 = 1.0;
		}
		bool flag17 = (double)num18 < num19;
		float num23 = (float)num19;
		if (!flag17)
		{
			float num24 = default;
			bool flag18 = !(num18 > num24);
			num23 = num18;
			if (!flag18)
			{
				num23 = num24;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
		object obj56 = 0;
		float num25 = num23 + -1f;
		object obj57 = obj56;
		object obj58 = default;
		float num26 = num25 * (float)obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v38+E4]");
		bool flag19 = (nint)0 == 0;
		object obj59 = !flag19;
		if (obj59 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float s = default;
		Vector3 vector = ScaleAlong(target, 0, s);
		up.localScale = (Vector3)0;
		Vector3 vector2 = ScaleAlong(restUp, 0, num);
		lo.localScale = (Vector3)0;
	}

	private unsafe static bool TwistRest(Transform model, Transform lo, Transform twist, Transform end, out Quaternion twistRest, out Quaternion handRest, out Vector3 axis)
	{
		//IL_0857: Expected Obj, but got I
		//IL_086f: Expected Obj, but got I
		//IL_08c3: Expected Obj, but got I
		//IL_07b6: Expected Obj, but got I
		//IL_07ce: Expected Obj, but got I
		//IL_080d: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I4
		//IL_07a1: Expected I4, but got Obj
		//IL_01ee: Expected Obj, but got I
		//IL_022d: Expected Obj, but got I
		//IL_025b: Expected Obj, but got I4
		//IL_0834: Expected Obj, but got I4
		//IL_02a3: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got I4
		//IL_0316: Expected Obj, but got I4
		//IL_031f: Expected Obj, but got I4
		//IL_04bc: Expected Obj, but got I
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got Unknown
		//IL_033e: Expected Obj, but got I
		//IL_0353: Expected Obj, but got I
		//IL_0396: Expected Obj, but got I
		//IL_0407: Expected I4, but got I8
		//IL_0421: Expected Obj, but got I4
		//IL_0517: Expected Obj, but got I4
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected Obj, but got Unknown
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected Ref, but got Unknown
		//IL_0568: Expected Obj, but got I4
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected Ref, but got Unknown
		//IL_05ab: Expected Obj, but got I4
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected Ref, but got Unknown
		//IL_0612: Expected VT, but got Obj
		//IL_0639: Expected Obj, but got VT
		//IL_06d4: Expected Ref, but got VT
		//IL_0714: Expected Ref, but got VT
		//IL_074e: Expected VT, but got I4
		//IL_074e: Expected VT, but got I4
		//IL_075f: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v7+A0]");
		object obj3 = 0;
		ref Quaternion reference = ref *(Quaternion*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v8+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v8+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v8+C]");
		_ = 0;
		ref Quaternion reference2 = ref *(Quaternion*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v8+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v8+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v8+C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v13+A0]");
		object obj7 = 0;
		ref Vector3 reference3 = ref *(Vector3*)obj7;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v14+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = model == null;
		bool flag3 = !flag2;
		object obj10 = !flag3;
		Matrix4x4[] bindposes;
		int num;
		int num2;
		int num3;
		if (obj10 == null)
		{
			object obj11 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = lo == null;
			bool flag6 = !flag5;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				object obj14 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v15+E4]");
				bool flag7 = (nint)0 == 0;
				object obj15 = !flag7;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag8 = twist == null;
				bool flag9 = !flag8;
				object obj16 = !flag9;
				if (obj16 == null)
				{
					object obj17 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X0_v19+E4]");
					bool flag10 = (nint)0 == 0;
					object obj18 = !flag10;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag11 = end == null;
					bool flag12 = !flag11;
					object obj19 = !flag12;
					if (obj19 == null)
					{
						if ((object)model != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4250]");
							object obj20 = 0;
							object obj21 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
							object obj22 = default;
							if (obj22 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v28+18]");
								object obj23 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v28+18]");
								if ((nint)0 < (nint)1)
								{
									goto IL_0777;
								}
								object obj24 = 0;
								while (true)
								{
									bool flag13 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23);
									object obj25 = !flag13;
									if (obj25 != null)
									{
										break;
									}
									object obj26 = obj22 + obj24;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v27+20]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v27+20]");
										Mesh sharedMesh = ((SkinnedMeshRenderer)0).sharedMesh;
										object obj27 = obj4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v28+E4]");
										bool flag14 = (nint)0 == 0;
										object obj28 = !flag14;
										if (obj28 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag15 = sharedMesh == null;
										bool flag16 = !flag15;
										object obj29 = !flag16;
										obj21 = 0;
										if (obj29 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v27+20]");
											Transform[] bones = ((SkinnedMeshRenderer)0).bones;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v27+20]");
											Mesh sharedMesh2 = ((SkinnedMeshRenderer)0).sharedMesh;
											if ((object)sharedMesh2 == null)
											{
												goto IL_0785;
											}
											bindposes = sharedMesh2.bindposes;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4288]");
											object obj30 = 0;
											num = Array.IndexOf((System.__Canon[])(object)bones, (System.__Canon)(object)lo);
											num2 = Array.IndexOf((System.__Canon[])(object)bones, (System.__Canon)(object)twist);
											obj21 = obj30;
											num3 = Array.IndexOf((System.__Canon[])(object)bones, (System.__Canon)(object)end);
											int num4 = num2 | num;
											int num5 = num4 | num3;
											int num6 = (int)(num5 & 0x80000000L);
											bool flag17 = num6 == 0;
											object obj31 = !flag17;
											if (obj31 == null)
											{
												if (bindposes == null)
												{
													goto IL_0785;
												}
												if (num3 < bindposes.Length && num < bindposes.Length && num2 < bindposes.Length)
												{
													goto IL_04fc;
												}
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v28+18]");
										obj23 = 0;
										obj24++;
										object obj32 = obj24;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v28+18]");
										if ((nint)obj32 >= 0)
										{
											return false;
										}
										continue;
									}
									goto IL_0785;
								}
								goto IL_0793;
							}
						}
						goto IL_0785;
					}
				}
			}
		}
		goto IL_0777;
		IL_0785:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0793;
		IL_04fc:
		bool flag18 = num < bindposes.Length;
		object obj33 = !flag18;
		if (obj33 == null)
		{
			object obj34 = bindposes + 32;
			Matrix4x4 matrix4x = Matrix4x4.Internal_Inverse(ref *(Matrix4x4*)(obj34 + num));
			bool flag19 = num2 < bindposes.Length;
			object obj35 = !flag19;
			if (obj35 == null)
			{
				Matrix4x4 matrix4x2 = Matrix4x4.Internal_Inverse(ref *(Matrix4x4*)(obj34 + num2));
				bool flag20 = num3 < bindposes.Length;
				object obj36 = !flag20;
				if (obj36 == null)
				{
					Matrix4x4 matrix4x3 = Matrix4x4.Internal_Inverse(ref *(Matrix4x4*)(obj34 + num3));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72F4C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72F4C");
					object obj37 = default;
					Quaternion quaternion = (Quaternion)(obj37 - obj37);
					object obj39 = default;
					object obj38 = obj39 - obj39;
					object obj41 = default;
					object obj40 = obj41 - obj41;
					object obj42 = quaternion * quaternion;
					object obj43 = obj38 * obj38;
					object obj44 = obj42 + obj43;
					object obj45 = obj40 * obj40;
					object obj46 = obj45 + obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
					if ((nint)obj46 >= 0)
					{
						Matrix4x4 matrix4x4 = default;
						Quaternion rotation = matrix4x4.GetRotation();
						Quaternion rotation2 = default;
						Quaternion quaternion2 = Quaternion.Internal_Inverse(ref rotation2);
						Matrix4x4 matrix4x5 = default;
						Quaternion rotation3 = matrix4x5.GetRotation();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
						reference2 = ref *(Quaternion*)quaternion;
						Quaternion quaternion3 = Quaternion.Internal_Inverse(ref rotation2);
						Matrix4x4 matrix4x6 = default;
						Quaternion rotation4 = matrix4x6.GetRotation();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
						reference = ref *(Quaternion*)quaternion;
						Quaternion quaternion4 = Quaternion.Internal_Inverse(ref rotation2);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
						Vector3 vector = (Quaternion)0 * (Vector3)0;
						reference3 = ref *(Vector3*)quaternion;
						return true;
					}
					goto IL_0777;
				}
			}
		}
		goto IL_0793;
		IL_0777:
		return false;
		IL_0793:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private unsafe static void Twist(Transform twist, Transform lo, Transform end, Quaternion twistRest, Quaternion handRest, Vector3 axis, ref float angle, bool known, float w)
	{
		//IL_004d: Expected VT, but got I4
		//IL_004d: Expected VT, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_01b9: Expected native int or pointer, but got VT
		//IL_01b0: Expected VT, but got I4
		//IL_00d2: Invalid comparison between F4 and I4
		//IL_00e1: Expected F4, but got I4
		//IL_0217: Invalid comparison between F4 and I4
		//IL_017d: Invalid comparison between F4 and I8
		//IL_00f8: Invalid comparison between F4 and I4
		//IL_0107: Expected F4, but got I4
		//IL_016b: Expected Obj, but got I8
		//IL_019d: Expected Obj, but got I4
		//IL_011e: Invalid comparison between F4 and I4
		Quaternion rotation = lo.rotation;
		Quaternion rotation2 = default;
		Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation2);
		Quaternion rotation3 = end.rotation;
		Quaternion quaternion2 = Quaternion.Internal_Inverse(ref rotation2);
		float num = ApeAvatarDriver.TwistAngle((Quaternion)0, (Vector3)0);
		object obj = handRest & 1;
		if (obj == null)
		{
			goto IL_01b1;
		}
		float num2 = num - twistRest.x;
		float num3 = num2 / 1.13587E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num4 = num3 * 1.13587E+09f;
		float num5 = num2 - num4;
		bool flag = num5 < 0f;
		float num6 = 0f;
		if (!flag)
		{
			bool flag2 = num5 > 1.13587E+09f;
			float num7 = 1.13587E+09f;
			if (!flag2)
			{
				bool flag3 = !(num5 > 1.1274813E+09f);
				num7 = num5;
				num6 = num5;
				if (flag3)
				{
					goto IL_01fa;
				}
			}
			num6 = num7 + 3.2833536E+09f;
		}
		goto IL_01fa;
		IL_01b1:
		((Quaternion*)(nint)twistRest)->x = num;
		float num8 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		float num9 = num8 * 0f;
		object obj2 = default;
		float angle2 = num9 * (float)obj2;
		Vector3 axis2 = default;
		Quaternion quaternion3 = Quaternion.Internal_AngleAxis(angle2, ref axis2);
		twist.localRotation = (Quaternion)0;
		return;
		IL_01fa:
		num = twistRest.x + num6;
		object obj3;
		if (num > 1.1320689E+09f)
		{
			obj3 = 3283353600L;
		}
		else
		{
			if (!(num < 3.2795525E+09f))
			{
				goto IL_01b1;
			}
			obj3 = 1135869952;
		}
		num += (float)obj3;
		goto IL_01b1;
	}

	private unsafe void HingeRest()
	{
		//IL_0010: Expected Obj, but got I
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Ref, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Ref, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Ref, but got Unknown
		//IL_01d7: Expected Obj, but got I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Ref, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Ref, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Ref, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Ref, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Ref, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Ref, but got Unknown
		//IL_00f4: Expected Obj, but got I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Ref, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Ref, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Ref, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
		object obj = 0;
		Transform body = transform;
		object obj2 = obj;
		ref Quaternion restRel = ref *(Quaternion*)(this + 564);
		ref float straight = ref *(float*)(this + 556);
		ref Quaternion handRest = ref *(Quaternion*)(this + 596);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3;
		if (HingeRestOf(model, body, upL, loL, endL, out *(Vector3*)(this + 460), out *(Vector3*)(this + 472), out *(Vector3*)(this + 484), out restRel, out straight, out handRest))
		{
			Transform body2 = transform;
			object obj4 = obj;
			ref Quaternion restRel2 = ref *(Quaternion*)(this + 580);
			ref float straight2 = ref *(float*)(this + 560);
			ref Quaternion handRest2 = ref *(Quaternion*)(this + 612);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			flag3 = HingeRestOf(model, body2, upR, loR, endR, out *(Vector3*)(this + 496), out *(Vector3*)(this + 508), out *(Vector3*)(this + 520), out restRel2, out straight2, out handRest2);
		}
		else
		{
			flag3 = false;
		}
		hinge = flag3;
	}

	internal unsafe static bool HingeRestOf(Transform model, Transform body, Transform up, Transform lo, Transform end, out Vector3 alongUp, out Vector3 hingeUp, out Vector3 alongLo, out Quaternion restRel, out float straight, out Quaternion handRest)
	{
		//IL_0dca: Expected Obj, but got I
		//IL_0de2: Expected Obj, but got I
		//IL_0e31: Expected Obj, but got I
		//IL_0cc1: Expected Obj, but got I
		//IL_0cd9: Expected Obj, but got I
		//IL_0d6a: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I4
		//IL_01eb: Expected Obj, but got I4
		//IL_0230: Expected Obj, but got I4
		//IL_0cac: Expected I4, but got Obj
		//IL_026b: Expected Obj, but got I
		//IL_02aa: Expected Obj, but got I
		//IL_02d8: Expected Obj, but got I4
		//IL_0d91: Expected Obj, but got I4
		//IL_0320: Expected Obj, but got I
		//IL_034e: Expected Obj, but got I4
		//IL_0393: Expected Obj, but got I4
		//IL_039c: Expected Obj, but got I4
		//IL_0539: Expected Obj, but got I
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got Unknown
		//IL_03bb: Expected Obj, but got I
		//IL_03d0: Expected Obj, but got I
		//IL_0413: Expected Obj, but got I
		//IL_0465: Expected Obj, but got I4
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected I4, but got Unknown
		//IL_0484: Expected I4, but got I8
		//IL_049e: Expected Obj, but got I4
		//IL_05c6: Expected Obj, but got I
		//IL_062e: Expected VT, but got I4
		//IL_062e: Expected VT, but got I4
		//IL_064d: Expected Obj, but got I4
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected Obj, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Ref, but got Unknown
		//IL_069e: Expected Obj, but got I4
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected Ref, but got Unknown
		//IL_06e1: Expected Obj, but got I4
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected Ref, but got Unknown
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected Obj, but got Unknown
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected Obj, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected Obj, but got Unknown
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Expected Obj, but got Unknown
		//IL_0951: Expected VT, but got Obj
		//IL_0961: Invalid comparison between VT and I
		//IL_09d0: Expected VT, but got I4
		//IL_09d0: Expected VT, but got I4
		//IL_09dc: Expected Ref, but got VT
		//IL_0a19: Expected VT, but got I4
		//IL_0a19: Expected VT, but got I4
		//IL_0a67: Expected VT, but got I4
		//IL_0a67: Expected VT, but got I4
		//IL_0b2c: Expected VT, but got I4
		//IL_0b2c: Expected VT, but got I4
		//IL_0b47: Expected Obj, but got VT
		//IL_0b64: Expected Obj, but got I
		//IL_0b8e: Expected Obj, but got I
		//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bad: Expected Obj, but got Unknown
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc2: Expected Obj, but got Unknown
		//IL_0bd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd7: Expected Obj, but got Unknown
		//IL_0bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c00: Expected Obj, but got Unknown
		//IL_0c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c15: Expected Obj, but got Unknown
		//IL_0dac: Expected Ref, but got F8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v7+A0]");
		object obj3 = 0;
		ref Vector3 reference = ref *(Vector3*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v8+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v8+8]");
		_ = 0;
		ref Vector3 reference2 = ref *(Vector3*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v8+8]");
		_ = 0;
		ref Vector3 reference3 = ref *(Vector3*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v8+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v13+A0]");
		object obj7 = 0;
		ref Quaternion reference4 = ref *(Quaternion*)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v14+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v14+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v14+C]");
		_ = 0;
		ref Quaternion reference5 = ref *(Quaternion*)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v14+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v14+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v14+C]");
		_ = 0;
		ref float reference6 = ref *(float*)1065353216;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = model == null;
		bool flag3 = !flag2;
		object obj10 = !flag3;
		Matrix4x4[] bindposes;
		int num;
		int num2;
		int num3;
		if (obj10 == null)
		{
			object obj11 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = body == null;
			bool flag6 = !flag5;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				object obj14 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X0_v15+E4]");
				bool flag7 = (nint)0 == 0;
				object obj15 = !flag7;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag8 = up == null;
				bool flag9 = !flag8;
				object obj16 = !flag9;
				if (obj16 == null)
				{
					object obj17 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X0_v19+E4]");
					bool flag10 = (nint)0 == 0;
					object obj18 = !flag10;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag11 = lo == null;
					bool flag12 = !flag11;
					object obj19 = !flag12;
					if (obj19 == null)
					{
						object obj20 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X0_v23+E4]");
						bool flag13 = (nint)0 == 0;
						object obj21 = !flag13;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag14 = end == null;
						bool flag15 = !flag14;
						object obj22 = !flag15;
						if (obj22 == null)
						{
							if ((object)model != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4250]");
								object obj23 = 0;
								object obj24 = obj23;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
								object obj25 = default;
								if (obj25 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v32+18]");
									object obj26 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v32+18]");
									if ((nint)0 < (nint)1)
									{
										goto IL_0978;
									}
									object obj27 = 0;
									while (true)
									{
										bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26);
										object obj28 = !flag16;
										if (obj28 != null)
										{
											break;
										}
										object obj29 = obj25 + obj27;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v29+20]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v29+20]");
											Mesh sharedMesh = ((SkinnedMeshRenderer)0).sharedMesh;
											object obj30 = obj4;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ X8_v30+E4]");
											bool flag17 = (nint)0 == 0;
											object obj31 = !flag17;
											if (obj31 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag18 = sharedMesh == null;
											bool flag19 = !flag18;
											object obj32 = !flag19;
											obj24 = 0;
											if (obj32 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v29+20]");
												Transform[] bones = ((SkinnedMeshRenderer)0).bones;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v29+20]");
												Mesh sharedMesh2 = ((SkinnedMeshRenderer)0).sharedMesh;
												if ((object)sharedMesh2 == null)
												{
													goto IL_0c90;
												}
												bindposes = sharedMesh2.bindposes;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4288]");
												object obj33 = 0;
												num = Array.IndexOf((System.__Canon[])(object)bones, (System.__Canon)(object)up);
												num2 = Array.IndexOf((System.__Canon[])(object)bones, (System.__Canon)(object)lo);
												obj24 = obj33;
												num3 = Array.IndexOf((System.__Canon[])(object)bones, (System.__Canon)(object)end);
												object obj34 = num2 | num;
												int num4 = obj34 | num3;
												int num5 = (int)(num4 & 0x80000000L);
												bool flag20 = num5 == 0;
												object obj35 = !flag20;
												if (obj35 == null)
												{
													if (bindposes == null)
													{
														goto IL_0c90;
													}
													if (num3 < bindposes.Length && num < bindposes.Length && num2 < bindposes.Length)
													{
														goto IL_0579;
													}
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v32+18]");
											obj26 = 0;
											obj27++;
											object obj36 = obj27;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v32+18]");
											if ((nint)obj36 >= 0)
											{
												return false;
											}
											continue;
										}
										goto IL_0c90;
									}
									goto IL_0c9e;
								}
							}
							goto IL_0c90;
						}
					}
				}
			}
		}
		goto IL_0978;
		IL_0c90:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0c9e;
		IL_0c9e:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
		IL_0579:
		if ((object)body != null)
		{
			Quaternion rotation = body.rotation;
			Quaternion rotation2 = default;
			Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v29+20]");
			Transform transform = ((Component)0).transform;
			if ((object)transform != null)
			{
				Quaternion rotation3 = transform.rotation;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
				Quaternion quaternion2 = Quaternion.Internal_Inverse(ref rotation2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE5E70");
				Vector3 vector = (Quaternion)0 * (Vector3)0;
				bool flag21 = num < bindposes.Length;
				object obj37 = !flag21;
				if (obj37 == null)
				{
					object obj38 = bindposes + 32;
					Matrix4x4 matrix4x = Matrix4x4.Internal_Inverse(ref *(Matrix4x4*)(obj38 + num));
					bool flag22 = num2 < bindposes.Length;
					object obj39 = !flag22;
					if (obj39 == null)
					{
						Matrix4x4 matrix4x2 = Matrix4x4.Internal_Inverse(ref *(Matrix4x4*)(obj38 + num2));
						bool flag23 = num3 < bindposes.Length;
						object obj40 = !flag23;
						if (obj40 == null)
						{
							Matrix4x4 matrix4x3 = Matrix4x4.Internal_Inverse(ref *(Matrix4x4*)(obj38 + num3));
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72F4C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72F4C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72F4C");
							object obj42 = default;
							object obj41 = obj42 - obj42;
							object obj44 = default;
							object obj43 = obj44 - obj44;
							object obj46 = default;
							object obj45 = obj46 - obj46;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
							object obj47 = obj41 * obj41;
							object obj48 = obj43 * obj43;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v14+8]");
							object obj49 = 0 * obj44;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v14+8]");
							object obj50 = 0 * obj42;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v14+4]");
							object obj51 = 0 * obj46;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v14+4]");
							object obj52 = 0 * obj42;
							object obj53 = obj47 + obj48;
							object obj54 = obj45 * obj45;
							object obj55 = obj7 * obj46;
							object obj56 = obj7 * obj44;
							object obj57 = obj49 - obj51;
							object obj58 = obj54 + obj53;
							object obj59 = obj55 - obj50;
							object obj60 = obj52 - obj56;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
							if ((nint)obj58 >= 0)
							{
								object obj61 = obj42 - obj42;
								object obj62 = obj44 - obj44;
								object obj63 = obj46 - obj46;
								object obj64 = obj61 * obj61;
								object obj65 = obj62 * obj62;
								object obj66 = obj64 + obj65;
								object obj67 = obj63 * obj63;
								object obj68 = obj67 + obj66;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
								if ((nint)obj68 >= 0)
								{
									object obj69 = obj57 * obj57;
									object obj70 = obj59 * obj59;
									object obj71 = obj60 * obj60;
									object obj72 = obj69 + obj70;
									Quaternion quaternion3 = (Quaternion)(obj71 + obj72);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
									if (quaternion3 >= (object)0)
									{
										Matrix4x4 matrix4x4 = default;
										Quaternion rotation4 = matrix4x4.GetRotation();
										Matrix4x4 matrix4x5 = default;
										Quaternion rotation5 = matrix4x5.GetRotation();
										Quaternion quaternion4 = Quaternion.Internal_Inverse(ref rotation2);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
										Vector3 vector2 = (Quaternion)0 * (Vector3)0;
										reference3 = ref *(Vector3*)quaternion3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
										_ = 0;
										Quaternion quaternion5 = Quaternion.Internal_Inverse(ref rotation2);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
										Vector3 vector3 = (Quaternion)0 * (Vector3)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
										reference2 = ref *(Vector3*)null;
										Quaternion quaternion6 = Quaternion.Internal_Inverse(ref rotation2);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
										Vector3 vector4 = (Quaternion)0 * (Vector3)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
										reference = ref *(Vector3*)null;
										Quaternion quaternion7 = Quaternion.Internal_Inverse(ref rotation2);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
										reference5 = ref *(Quaternion*)null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
										_ = 0;
										Quaternion quaternion8 = Quaternion.Internal_Inverse(ref rotation2);
										Matrix4x4 matrix4x6 = default;
										Quaternion rotation6 = matrix4x6.GetRotation();
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
										reference4 = ref *(Quaternion*)null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
										_ = 0;
										Vector3 vector5 = (Quaternion)0 * (Vector3)0;
										object obj73 = restRel * hingeUp;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [restRel @ stack_0 (UnityEngine.Quaternion&)+4]");
										nint num6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hingeUp @ X6 (UnityEngine.Vector3&)+4]");
										object obj74 = num6 * 0;
										object obj75 = obj73 + obj74;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [restRel @ stack_0 (UnityEngine.Quaternion&)+8]");
										nint num7 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hingeUp @ X6 (UnityEngine.Vector3&)+8]");
										object obj76 = num7 * 0;
										object obj77 = obj76 + obj75;
										object obj78 = hingeUp * obj77;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hingeUp @ X6 (UnityEngine.Vector3&)+4]");
										object obj79 = 0 * obj77;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hingeUp @ X6 (UnityEngine.Vector3&)+8]");
										object obj80 = 0 * obj77;
										double num8 = (double)restRel - (double)obj78;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [restRel @ stack_0 (UnityEngine.Quaternion&)+4]");
										object obj81 = 0 - obj79;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [restRel @ stack_0 (UnityEngine.Quaternion&)+8]");
										object obj82 = 0 - obj80;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
										bool flag24 = num8 < 0.5;
										double num9 = 0.5;
										if (!flag24)
										{
											bool flag25 = !(num8 > 1.0);
											num9 = num8;
											if (!flag25)
											{
												num9 = 1.0;
											}
										}
										reference6 = ref *(float*)num9;
										return true;
									}
								}
							}
							goto IL_0978;
						}
					}
				}
				goto IL_0c9e;
			}
		}
		goto IL_0c90;
		IL_0978:
		return false;
	}

	private static Vector3 ElbowPole(Vector3 side, Vector3 back, Quaternion aim)
	{
		//IL_0154: Expected Obj, but got I
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_01b5: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I4
		//IL_0063: Invalid comparison between F8 and I
		//IL_00bf: Expected Obj, but got I
		//IL_00c7: Expected F8, but got Obj
		//IL_00d7: Expected F8, but got I
		//IL_02d0: Expected Obj, but got I
		//IL_02de: Expected VT, but got I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_0373: Invalid comparison between F8 and I
		//IL_0392: Expected VT, but got Obj
		//IL_03b4: Expected Obj, but got I4
		object obj = default;
		double num = (double)obj * 0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B8B8]");
		object obj4 = default;
		object obj3 = obj4 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B368]");
		object obj6 = default;
		object obj5 = obj6 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		object obj8 = default;
		object obj7 = obj8 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v3+A0]");
		object obj10 = 0;
		object obj11 = obj3 + obj5;
		double num2 = num + (double)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4+2C]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		object obj12 = num3 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4+24]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B8B8]");
		object obj13 = num4 * 0;
		object obj14 = obj11 + obj13;
		double num5 = num2 + (double)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj15 = 0;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj17 = !flag;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj18 = obj14 * obj14;
		double num6 = num5 * num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		double num7 = (double)obj18 + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		double num8;
		double num9;
		if (num7 > 0.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			num8 = (double)obj14 / num6;
			num9 = num5 / num7;
		}
		else
		{
			object obj19 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v33+A0]");
			object obj20 = 0;
			num8 = (double)obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v34+8]");
			num9 = 0.0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		double num10 = num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC38]");
		double num11 = num10 * 0.0;
		double num12 = num8 * num7;
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v16+A0]");
		object obj22 = 0;
		Vector3 result = (Quaternion)0 * back;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj24 = default;
		object obj25 = default;
		object obj23 = obj24 * obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
		object obj27 = default;
		object obj26 = obj27 * 0;
		double num13 = num12 + (double)obj23;
		double num14 = num11 - (double)obj26;
		double num15 = num13 * num13;
		double num16 = num14 * num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		double num17 = num16 + num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		if (num17 > 0.0)
		{
			result = (Vector3)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v9 (UnityEngine.Vector3)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj28 = !flag2;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if ((nint)obj27 > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			}
		}
		return result;
	}

	internal static void HingeReach(Transform up, Transform lo, Transform end, Vector3 target, Vector3 alongUp, Vector3 hingeUp, Vector3 alongLo, Quaternion restRel, Vector3 pole, float w, Quaternion handTo = default(Quaternion), Quaternion handRest = default(Quaternion), bool handTurns = default(bool), Swing swing = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0f64: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_0f82: Expected Obj, but got I
		//IL_0fac: Expected Obj, but got I4
		//IL_073c: Expected Obj, but got I4
		//IL_103a: Expected Obj, but got I4
		//IL_0221: Invalid comparison between F4 and I
		//IL_02ed: Invalid comparison between F4 and I
		//IL_0310: Expected VT, but got I4
		//IL_0310: Expected VT, but got I4
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected Obj, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_03fd: Expected Obj, but got VT
		//IL_040a: Expected Obj, but got VT
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected Obj, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_105b: Invalid comparison between F8 and I4
		//IL_106a: Expected F8, but got I4
		//IL_10c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c6: Expected Obj, but got Unknown
		//IL_10db: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e0: Expected Obj, but got Unknown
		//IL_10ef: Expected VT, but got I4
		//IL_10ef: Expected VT, but got I4
		//IL_0668: Unsupported input type for neg.
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected VT, but got Unknown
		//IL_0671: Unsupported input type for neg.
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_067a: Unsupported input type for neg.
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected VT, but got Unknown
		//IL_0696: Expected Obj, but got VT
		//IL_06bd: Expected Obj, but got VT
		//IL_05d6: Invalid comparison between F8 and I
		//IL_118a: Invalid comparison between F4 and I
		//IL_0605: Expected F8, but got I
		//IL_11c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c7: Expected Obj, but got Unknown
		//IL_11e6: Expected VT, but got F4
		//IL_1219: Expected Obj, but got VT
		//IL_1265: Invalid comparison between F4 and I
		//IL_0825: Invalid comparison between F4 and I
		//IL_083b: Expected VT, but got F4
		//IL_0d01: Invalid comparison between F4 and I
		//IL_08a5: Invalid comparison between F8 and I4
		//IL_08b4: Expected F8, but got I4
		//IL_090c: Expected VT, but got I4
		//IL_090c: Expected VT, but got I4
		//IL_091f: Expected VT, but got I4
		//IL_091f: Expected VT, but got I4
		//IL_0987: Invalid comparison between F4 and I
		//IL_0d82: Expected VT, but got I4
		//IL_0c4f: Expected VT, but got Obj
		//IL_0c57: Expected VT, but got F4
		//IL_0dc8: Expected VT, but got I4
		//IL_0af7: Invalid comparison between VT and I4
		//IL_12d1: Expected VT, but got I4
		//IL_12d1: Expected VT, but got I4
		//IL_12dd: Expected VT, but got F4
		//IL_12e5: Expected VT, but got F4
		//IL_0e89: Invalid comparison between F4 and I
		//IL_1313: Invalid comparison between F4 and I4
		//IL_0c81: Invalid comparison between F4 and I8
		//IL_0b99: Invalid comparison between F4 and I4
		//IL_0ba8: Expected F4, but got I4
		//IL_0eb0: Invalid comparison between F4 and I
		//IL_0c42: Expected Obj, but got I8
		//IL_0ca1: Expected Obj, but got I4
		//IL_0bbf: Invalid comparison between F4 and I4
		//IL_0bce: Expected F4, but got I4
		//IL_0be5: Invalid comparison between F4 and I4
		//IL_0f30: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = up == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = lo == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X0_v11+E4]");
		bool flag7 = (nint)0 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (end == null)
		{
			return;
		}
		Vector3 position = up.position;
		Vector3 position2 = lo.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X0_v22+E4]");
		bool flag8 = (nint)0 == 0;
		object obj12 = !flag8;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 position3 = end.position;
		Vector3 position4 = lo.position;
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X0_v29+E4]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD9A1]");
			bool flag9 = (nint)0 == 0;
			object obj14 = !flag9;
			if (obj14 == null)
			{
				_ = 1;
			}
		}
		object obj15 = obj10;
		float num = w - w;
		object obj17 = default;
		object obj16 = obj17 - obj17;
		object obj19 = default;
		object obj18 = obj19 - obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X0_v31+E4]");
		bool flag10 = (nint)0 == 0;
		object obj20 = !flag10;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num2 = num * num;
		object obj21 = obj16 * obj16;
		float num3 = num2 + (float)obj21;
		object obj22 = obj18 * obj18;
		float num4 = (float)obj22 + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		if (num4 < 0f)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		if ((nint)obj18 < 0)
		{
			return;
		}
		float num5 = w - w;
		object obj23 = obj19 - obj19;
		object obj24 = obj17 - obj17;
		float num6 = num5 * num5;
		object obj25 = obj24 * obj24;
		float num7 = num6 + (float)obj25;
		object obj26 = obj23 * obj23;
		float num8 = (float)obj26 + num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		if (num8 < 0f)
		{
			return;
		}
		Vector3 vector = (Quaternion)0 * (Vector3)0;
		object obj27 = pole * swing;
		object obj29 = default;
		object obj30 = default;
		object obj28 = obj29 * obj30;
		IntPtr intPtr = default;
		object obj31 = handTo * (nint)intPtr;
		object obj32 = obj27 + obj28;
		object obj33 = obj31 + obj32;
		object obj34 = pole * obj33;
		object obj35 = obj29 * obj33;
		object obj36 = handTo * obj33;
		object obj37 = (object)swing - obj34;
		object obj38 = obj30 - obj35;
		object obj39 = (nint)intPtr - obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		if ((nint)obj37 < 0)
		{
			return;
		}
		Vector3 vector2 = default;
		object obj40 = vector2 * obj29;
		object obj42 = default;
		object obj41 = obj42 * handTo;
		Vector3 vector3 = default;
		object obj43 = vector3 * handTo;
		object obj44 = vector2 * pole;
		object obj45 = obj40 - obj41;
		object obj46 = obj42 * pole;
		object obj47 = vector3 * obj29;
		object obj48 = obj43 - obj44;
		object obj49 = obj46 - obj47;
		object obj50 = obj45 * obj37;
		object obj51 = obj48 * obj38;
		object obj52 = vector3 * obj37;
		object obj53 = obj42 * obj38;
		object obj54 = obj50 + obj51;
		object obj55 = obj49 * obj39;
		object obj56 = obj52 + obj53;
		object obj57 = vector2 * obj39;
		object obj58 = obj55 + obj54;
		object obj59 = obj57 + obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFF0");
		object obj60 = obj18 * obj18;
		object obj61 = obj18 + obj18;
		float num9 = num4 * num4;
		float num10 = (float)obj61 * num8;
		float num11 = num9 - (float)obj60;
		float num12 = num8 * num8;
		float num13 = num11 - num12;
		float num14 = num10 * (float)obj37;
		float num15 = num13 / num14;
		bool flag11 = (double)num15 < -1.0;
		double num16 = -1.0;
		if (!flag11)
		{
			bool flag12 = !((double)num15 > 1.0);
			num16 = num15;
			if (!flag12)
			{
				num16 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFE0");
		bool flag13 = num16 < 0.0;
		double num17 = 0.0;
		if (!flag13)
		{
			double num18 = num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A85C]");
			bool flag14 = !(num18 > 0.0);
			num17 = num16;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A85C]");
				num17 = 0.0;
			}
		}
		double num19 = num17 - (double)obj58;
		float num20 = (float)num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
		float num21 = num20 * 0f;
		Vector3 axis = default;
		Quaternion quaternion = Quaternion.Internal_AngleAxis(num21, ref axis);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
		object obj62 = vector3 * obj18;
		object obj63 = obj42 * obj18;
		object obj64 = vector2 * obj18;
		Vector3 vector4 = (Quaternion)0 * (Vector3)0;
		float num22 = num8 * num21;
		float num23 = num8 * (float)obj29;
		float num25 = default;
		float num24 = num8 * num25;
		float num26 = (float)obj62 + num22;
		float num27 = (float)obj63 + num23;
		float num28 = (float)obj64 + num24;
		Vector3 vector5 = (Vector3)(0 - obj45);
		object obj65 = 0 - obj48;
		Vector3 vector6 = (Vector3)(0 - obj49);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2ECCDCC");
		object obj66 = vector5 * vector5;
		object obj67 = obj65 * obj65;
		object obj68 = obj66 + obj67;
		object obj69 = vector6 * vector6;
		object obj70 = obj69 + obj68;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
		float num29;
		if ((nint)obj70 < 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2ECCDCC");
			Vector3 vector7 = vector2;
			num29 = num26;
		}
		else
		{
			Vector3 vector7 = vector6;
			num29 = num26;
		}
		float num30 = num / num4;
		float num31 = (float)obj16 / num4;
		float num32 = (float)obj18 / num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2ECCDCC");
		float num34 = default;
		float num33 = num34 * num34;
		float num36 = default;
		float num35 = num36 * num36;
		float num37 = num33 + num35;
		float num38 = num25 * num25;
		float num39 = num38 + num37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		bool flag15 = !(num39 < 0f);
		float num40 = num34;
		float num41 = num25;
		float num42 = num36;
		if (!flag15)
		{
			Vector3 position5 = lo.position;
			float num43 = num39 - w;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			float num44 = 0f - (float)obj17;
			num41 = num25 - (float)obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2ECCDCC");
			num40 = num43;
			num42 = num44;
		}
		object obj71 = target & 1;
		bool flag16 = obj71 == null;
		axis = pole;
		Vector3 vector8 = (Vector3)num40;
		float num45 = num41;
		float num46 = num29;
		float num47 = num41;
		double num70;
		float num80;
		float num85;
		if (!flag16)
		{
			float num48 = num40 * num40;
			float num49 = num42 * num42;
			float num50 = num48 + num49;
			float num51 = num41 * num41;
			float num52 = num50 + num51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFFC]");
			bool flag17 = num52 < 0f;
			axis = pole;
			vector8 = (Vector3)num40;
			num45 = num41;
			num46 = num29;
			num47 = num41;
			if (!flag17)
			{
				double num53 = num17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
				double num54 = num53 * 0.0;
				double num55 = num54 + -10.0;
				double num56 = num55 / 1109393408.0;
				bool flag18 = num56 < 0.0;
				double num57 = 0.0;
				if (!flag18)
				{
					bool flag19 = num56 > 1.0;
					num57 = 1.0;
					if (!flag19)
					{
						num57 = num56;
					}
				}
				Quaternion rotation = default;
				Quaternion quaternion2 = Quaternion.Internal_Inverse(ref rotation);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
				Quaternion rotation2 = default;
				Quaternion quaternion3 = Quaternion.Internal_Inverse(ref rotation2);
				Vector3 vector9 = (Quaternion)0 * (Vector3)0;
				Vector3 vector10 = (Quaternion)0 * (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2ECCDCC");
				object obj73 = default;
				object obj72 = obj73 * obj73;
				object obj75 = default;
				object obj74 = obj75 * obj75;
				object obj76 = obj72 + obj74;
				float num59 = default;
				float num58 = num59 * num59;
				float num60 = num58 + (float)obj76;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
				if (num60 > 0f)
				{
					double num61 = num57 + num57;
					double num62 = num57 * 3.0;
					double num63 = num57 * num61;
					double num64 = num57 * num62;
					double num65 = num57 * num63;
					double num66 = num64 - num65;
					double num67 = 1.0 - num66;
					double num68 = num67 * 0.0;
					double num69 = num66 + num68;
					num70 = 1.0 - num69;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
					float num71 = num31 * (float)num68;
					float num72 = num32 * 1f;
					float num73 = num32 * (float)num69;
					float num74 = num30 * (float)num68;
					float num75 = num30 * 1f;
					float num76 = num31 * (float)num69;
					float num77 = num71 - num72;
					float num78 = num73 - num74;
					float num79 = num75 - num76;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72DCC");
					bool flag20 = alongUp == (Vector3)(object)0;
					num80 = num40;
					if (flag20)
					{
						goto IL_12a2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [alongUp @ X4 (UnityEngine.Vector3)+14]");
					bool flag21 = (nint)0 == 0;
					num80 = num40;
					if (flag21)
					{
						goto IL_130a;
					}
					float num81 = num40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [alongUp @ X4 (UnityEngine.Vector3)+10]");
					float num82 = num81 - 0f;
					float num83 = num82 / 1.13587E+09f;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					num41 = num83 * 1.13587E+09f;
					float num84 = num82 - num41;
					bool flag22 = num84 < 0f;
					num85 = 0f;
					if (!flag22)
					{
						bool flag23 = num84 > 1.13587E+09f;
						float num86 = 1.13587E+09f;
						if (!flag23)
						{
							bool flag24 = !(num84 > 1.1274813E+09f);
							num86 = num84;
							num85 = num84;
							num41 = num84;
							if (flag24)
							{
								goto IL_132a;
							}
						}
						num85 = num86 + 3.2833536E+09f;
						num41 = num86;
					}
					goto IL_132a;
				}
				axis = (Vector3)swing;
				vector8 = (Vector3)num40;
				num45 = num59;
				num46 = num29;
				num47 = num41;
			}
		}
		goto IL_120c;
		IL_132a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [alongUp @ X4 (UnityEngine.Vector3)+10]");
		num80 = 0f + num85;
		goto IL_130a;
		IL_130a:
		object obj77;
		if (num80 > 1.1320689E+09f)
		{
			obj77 = 3283353600L;
		}
		else
		{
			if (!(num80 < 3.2795525E+09f))
			{
				goto IL_135a;
			}
			obj77 = 1135869952;
		}
		num80 += (float)obj77;
		goto IL_135a;
		IL_120c:
		object obj78 = vector8 * vector8;
		float num87 = num42 * num42;
		float num88 = (float)obj78 + num87;
		float num89 = num47 * num47;
		float num90 = num88 + num89;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFFC]");
		if (num90 < 0f)
		{
			return;
		}
		float num91 = num46 * num46;
		float num92 = num27 * num27;
		float num93 = num91 + num92;
		float num94 = num28 * num28;
		float num95 = num94 + num93;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
		if (num95 < 0f)
		{
			return;
		}
		Vector3 upwards = default;
		Quaternion quaternion4 = Quaternion.Internal_LookRotation(ref axis, ref upwards);
		Quaternion quaternion5 = Quaternion.Internal_LookRotation(ref axis, ref upwards);
		Quaternion rotation3 = default;
		Quaternion quaternion6 = Quaternion.Internal_Inverse(ref rotation3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
		Quaternion rotation4 = up.rotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE5E34");
		up.rotation = (Quaternion)0;
		Quaternion rotation5 = lo.rotation;
		Quaternion rotation6 = up.rotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE5E34");
		lo.rotation = (Quaternion)0;
		Vector3 position6 = end.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC2C]");
		object obj79 = default;
		if ((nint)obj79 <= 0)
		{
			return;
		}
		float num96 = (float)obj79 - w;
		float num97 = num94 - (float)obj17;
		float num98 = num45 - (float)obj19;
		float num99 = num96 * num96;
		float num100 = num97 * num97;
		float num101 = num99 + num100;
		float num102 = num98 * num98;
		float num103 = num102 + num101;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
		if (!(num103 > 0f))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
		if (num4 > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE5EB4");
			if ((double)num96 < 3.0)
			{
				Quaternion quaternion7 = Quaternion.Internal_FromToRotation(ref axis, ref upwards);
				Quaternion rotation7 = up.rotation;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
				up.rotation = (Quaternion)0;
			}
		}
		return;
		IL_12a2:
		float num104 = (float)num70 * num80;
		Quaternion quaternion8 = Quaternion.Internal_AngleAxis(num104, ref axis);
		Vector3 vector11 = (Quaternion)0 * (Vector3)0;
		axis = (Vector3)num30;
		vector8 = (Vector3)num104;
		num45 = num41;
		num46 = num29;
		num47 = num41;
		num42 = num32;
		goto IL_120c;
		IL_135a:
		_ = 1;
		goto IL_12a2;
	}

	internal static void Reach(Transform up, Transform lo, Transform end, Vector3 target, Vector3 side, Vector3 back, float w)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0509: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		//IL_0527: Expected Obj, but got I
		//IL_0551: Expected Obj, but got I4
		//IL_0804: Expected Obj, but got I4
		//IL_0239: Expected F4, but got I
		//IL_0253: Invalid comparison between F4 and I
		//IL_064c: Expected Obj, but got I4
		//IL_082f: Expected Obj, but got I
		//IL_083f: Invalid comparison between F4 and I
		//IL_0327: Expected Obj, but got I
		//IL_032f: Expected F4, but got Obj
		//IL_033f: Expected F4, but got I
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Expected Obj, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected Obj, but got Unknown
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected Obj, but got Unknown
		//IL_088a: Expected Obj, but got I
		//IL_08a4: Expected F8, but got I
		//IL_08d8: Expected Obj, but got I
		//IL_06d1: Expected Obj, but got I
		//IL_0716: Expected Obj, but got I
		//IL_0737: Invalid comparison between F4 and Obj
		//IL_0924: Invalid comparison between F4 and I
		//IL_0459: Expected VT, but got I4
		//IL_0965: Expected Obj, but got I4
		//IL_03f9: Invalid comparison between F4 and I
		//IL_04d9: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = up == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = lo == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v11+E4]");
		bool flag7 = (nint)0 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = end == null;
		bool flag9 = !flag8;
		object obj10 = !flag9;
		if (obj10 != null)
		{
			return;
		}
		Vector3 position = up.position;
		Vector3 position2 = lo.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v22+E4]");
		bool flag10 = (nint)0 == 0;
		object obj13 = !flag10;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num = w - w;
		object obj15 = default;
		object obj14 = obj15 - obj15;
		Vector3 position3 = end.position;
		Vector3 position4 = lo.position;
		float num2 = num * num;
		object obj16 = obj14 * obj14;
		object obj17 = obj11;
		object obj18 = obj15 - obj15;
		object obj20 = default;
		object obj19 = obj20 - obj20;
		float num3 = w - w;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v29+E4]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj21 = obj18 * obj18;
		float num4 = num3 * num3;
		float num5 = num2 + (float)obj16;
		object obj22 = obj19 * obj19;
		float num6 = (float)obj21 + num4;
		float num7 = (float)obj22 + num5;
		float num8 = w - w;
		object obj23 = obj11;
		object obj24 = obj20 - obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X0_v32+E4]");
		bool flag11 = (nint)0 == 0;
		object obj25 = !flag11;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num9 = num8 * num8;
		object obj26 = obj24 * obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		float num10 = (float)obj26 + num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		float num11 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		float num12 = default;
		bool flag12 = num12 < 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		if (!flag12)
		{
			float num13 = num6 + num7;
			float num14 = num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC2C]");
			num10 = num14 * 0f;
			bool flag13 = !(num12 > num10);
			num11 = num12;
			if (!flag13)
			{
				num11 = num10;
			}
		}
		float num15 = num12;
		object obj27 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X0_v36+E4]");
		bool flag14 = (nint)0 == 0;
		object obj28 = !flag14;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num15 = num12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj29 = 0;
		float num16 = num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		float num17;
		object obj30 = default;
		float num18;
		if (num16 > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			num17 = num8 / (float)obj30;
			num18 = (float)obj24 / num15;
		}
		else
		{
			object obj31 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v55+A0]");
			object obj32 = 0;
			num17 = (float)obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v56+8]");
			num18 = 0f;
		}
		object obj33 = default;
		double num19 = (double)obj33 * 0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		object obj35 = default;
		object obj34 = obj35 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B8B8]");
		object obj37 = default;
		object obj36 = obj37 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B368]");
		object obj38 = obj30 * 0;
		object obj39 = obj29;
		object obj40 = obj36 + obj38;
		double num20 = num19 + (double)obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v29+A0]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v30+24]");
		double num21 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v30+24]");
		double num22 = 0.0 * (double)obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v30+2C]");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		object obj42 = num23 * 0;
		float num24 = num18 * num18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj43 = 0;
		float num25 = (float)obj40 + (float)num22;
		double num26 = num20 + (double)obj42;
		float num27 = num17 * num17;
		object obj44 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v35+A0]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		float num28 = num24 + num27;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num28) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj45))
		{
			float num29 = num17 * num25;
			num21 = (double)num18 * num26;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			double num30 = num21 + (double)num29;
			double num31 = num30 / (double)num28;
			object obj46 = default;
			float num32 = num17 * (float)obj46;
			double num33 = (double)num18 * num31;
			num25 -= num32;
			num26 -= num33;
		}
		float num34 = num25 * num25;
		double num35 = num26 * num26;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		float num36 = num34 + (float)num35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		float num37 = default;
		if (num36 > 0f)
		{
			object obj47 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X0_v69+E4]");
			bool flag15 = (nint)0 == 0;
			object obj48 = !flag15;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if (num37 > 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Quaternion rotation = up.rotation;
		Vector3 position5 = lo.position;
		Vector3 fromDirection = default;
		Vector3 toDirection = default;
		Quaternion quaternion = Quaternion.Internal_FromToRotation(ref fromDirection, ref toDirection);
		Quaternion a = default;
		Quaternion b = default;
		Quaternion quaternion2 = Quaternion.Internal_Slerp(ref a, ref b, num37);
		up.rotation = (Quaternion)0;
		Quaternion rotation2 = lo.rotation;
		Vector3 position6 = end.position;
		Vector3 position7 = lo.position;
		Vector3 position8 = lo.position;
		Quaternion quaternion3 = Quaternion.Internal_FromToRotation(ref fromDirection, ref toDirection);
		Quaternion a2 = default;
		Quaternion b2 = default;
		Quaternion quaternion4 = Quaternion.Internal_Slerp(ref a2, ref b2, num37);
		lo.rotation = (Quaternion)0;
	}

	public MonsterAvatar()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_0110: Expected Obj, but got I8
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01db: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I
		//IL_020b: Expected Obj, but got I
		//IL_0220: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0289: Expected Obj, but got I
		//IL_029e: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I
		//IL_02c8: Expected Obj, but got I
		//IL_02dd: Expected Obj, but got I
		//IL_02f2: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC9D0]");
		object obj5 = 0;
		sizeBy = 1f;
		object obj6 = this + 564;
		object obj7 = this + 112;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = this + 136;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj10 = this + 144;
		object obj11 = default;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj12 = this + 152;
		object obj13 = default;
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj14 = this + 160;
		object obj15 = default;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj16 = this + 168;
		object obj17 = default;
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj18 = obj16 + 388;
		obj18 = 4575657222473777152L;
		object obj19 = this + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj20 = 0;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6+A0]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6+A0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6+A0]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6+A0]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj25 = default;
		obj25._002Ector();
		object obj26 = this + 632;
		swingL = (Swing)obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj27 = default;
		obj27._002Ector();
		object obj28 = this + 640;
		swingR = (Swing)obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj29 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v10+A0]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v10+A0]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v10+A0]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v10+A0]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v10+A0]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v10+A0]");
		object obj35 = 0;
		obj19 = obj35;
		base._002Ector();
	}

	static MonsterAvatar()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC9D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC9E0]");
		object obj3 = 0;
		int num = Animator.StringToHash((string)obj);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+A0]");
		object obj5 = 0;
		obj5 = num;
		int num2 = Animator.StringToHash((string)obj3);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v5+A0]");
		object obj7 = 0;
	}

	private HandPoser.Finger _003CPoser_003Eg__Chain_007C125_0(string f, ref MonsterBrain._003C_003Ec__DisplayClass125_0 P_1)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_018e: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I
		//IL_0255: Expected Obj, but got I8
		//IL_026d: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I
		//IL_021d: Expected Obj, but got I4
		//IL_022d: Expected Obj, but got I
		//IL_028b: Expected Obj, but got I
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_02bb: Expected Obj, but got I
		//IL_02d4: Expected Obj, but got I
		//IL_038a: Expected Obj, but got I4
		//IL_03a0: Expected Obj, but got I
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got Unknown
		//IL_03ce: Expected Obj, but got I4
		//IL_0328: Expected Obj, but got I
		//IL_034a: Expected Obj, but got I4
		//IL_035a: Expected Obj, but got I
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_0414: Expected Obj, but got I4
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC9B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HandPoser.Finger finger = default;
		finger._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass125_0&)+8]");
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass125_0&)+8]");
		string text2 = f + (string)obj3 + (string)0;
		Transform transform = Bone(text2);
		object obj4 = default;
		bool flag = obj4 == null;
		object obj5 = 0;
		string text3 = text2;
		NullReferenceException ex = default;
		if (!flag)
		{
			bool flag2 = (object)transform == null;
			string text4 = text2;
			if (!flag2)
			{
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v14+40]");
				text4 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag3 = ex == null;
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v14+40]");
				text3 = (string)0;
				if (flag3)
				{
					goto IL_0473;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+18]");
			bool flag4 = (nint)0 == 0;
			obj5 = 0;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC9C0]");
				object obj7 = 0;
				object obj8 = obj4 + 32;
				obj8 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass125_0&)+8]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass125_0&)+8]");
				string text5 = f + (string)obj7 + (string)0;
				Transform transform2 = Bone(text5);
				bool flag5 = (object)transform2 == null;
				text4 = text5;
				if (!flag5)
				{
					object obj9 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v13+40]");
					text4 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag6 = ex == null;
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v13+40]");
					text3 = (string)0;
					if (flag6)
					{
						goto IL_0473;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+18]");
				object obj10 = 0 & 0xFFFFFFFEL;
				bool flag7 = obj10 == null;
				obj5 = 0;
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC9B8]");
					object obj11 = 0;
					object obj12 = obj4 + 40;
					obj12 = transform2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass125_0&)+8]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X2 (<>c__DisplayClass125_0&)+8]");
					string text6 = f + (string)obj11 + (string)0;
					Transform transform3 = Bone(text6);
					bool flag8 = (object)transform3 == null;
					text4 = text6;
					if (!flag8)
					{
						object obj13 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v12+40]");
						text4 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag9 = ex == null;
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v12+40]");
						text3 = (string)0;
						if (flag9)
						{
							goto IL_0473;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+18]");
					bool flag10 = (nint)0 < (nint)2;
					object obj14 = !flag10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+18]");
					object obj15 = -2;
					bool flag11 = obj15 == null;
					object obj16 = ~obj14;
					object obj17 = obj16 | flag11;
					obj5 = 0;
					if (obj17 == null)
					{
						object obj18 = obj4 + 48;
						obj18 = transform3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag12 = finger == null;
						obj5 = 0;
						text3 = (string)(object)transform3;
						if (!flag12)
						{
							object obj19 = finger + 16;
							obj19 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							return finger;
						}
						goto IL_0465;
					}
				}
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			text3 = text4;
		}
		goto IL_0465;
		IL_0465:
		ex = new NullReferenceException();
		goto IL_0473;
		IL_0473:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		return (HandPoser.Finger)(object)new ArgumentNullException();
	}

	internal unsafe static void _003CBases_003Eg__Add_007C142_0(ref Vector4 sum, Quaternion q)
	{
		//IL_0064: Expected Obj, but got VT
		//IL_0074: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01ba: Expected Obj, but got I
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got VT
		//IL_0042: Expected Obj, but got I
		//IL_013e: Unsupported input type for neg.
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0147: Unsupported input type for neg.
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_0150: Unsupported input type for neg.
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0159: Unsupported input type for neg.
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDA39]");
		object obj;
		object obj2;
		object obj3;
		object obj5;
		if ((nint)0 != 0)
		{
			obj = sum;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sum @ X0 (UnityEngine.Vector4&)+8]");
			obj2 = 0;
			object obj4 = default;
			obj3 = obj4;
			object obj6 = default;
			obj5 = obj6;
		}
		else
		{
			obj = sum;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sum @ X0 (UnityEngine.Vector4&)+4]");
			obj3 = 0;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sum @ X0 (UnityEngine.Vector4&)+8]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sum @ X0 (UnityEngine.Vector4&)+C]");
			obj5 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D60]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5+A0]");
		object obj9 = 0;
		object obj10 = sum - obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sum @ X0 (UnityEngine.Vector4&)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6+8]");
		object obj11 = num - 0;
		object obj12 = obj10 * obj10;
		object obj13 = obj11 * obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sum @ X0 (UnityEngine.Vector4&)+8]");
		object obj14 = obj12 + 0;
		object obj15 = obj13 + obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj16 = obj13 + obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		bool flag = (nint)obj16 < 0;
		object obj18 = default;
		object obj17 = obj18;
		object obj20 = default;
		object obj19 = obj20;
		object obj22 = default;
		object obj21 = obj22;
		object obj24 = default;
		object obj23 = obj24;
		if (!flag)
		{
			object obj25 = obj18 * obj;
			object obj26 = obj20 * obj3;
			object obj27 = obj25 + obj26;
			object obj28 = obj22 * obj2;
			object obj29 = obj28 + obj27;
			object obj30 = obj24 * obj5;
			object obj31 = obj30 + obj29;
			bool flag2 = (nint)obj31 >= 0;
			obj17 = obj18;
			obj19 = obj20;
			obj21 = obj22;
			obj23 = obj24;
			if (!flag2)
			{
				obj17 = 0 - obj18;
				obj19 = 0 - obj20;
				obj21 = 0 - obj22;
				obj23 = 0 - obj24;
			}
		}
		object obj32 = obj17 + obj;
		object obj33 = obj19 + obj3;
		object obj34 = obj21 + obj2;
		object obj35 = obj23 + obj5;
		ref Vector4 reference = ref *(Vector4*)obj32;
	}

	internal static Quaternion _003CBases_003Eg__Mean_007C142_1(Vector4 sum)
	{
		//IL_00e4: Expected Obj, but got I
		//IL_00ec: Expected VT, but got Obj
		//IL_010e: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 * obj2;
		object obj4 = default;
		object obj3 = obj4 * obj4;
		object obj5 = obj3 + obj;
		object obj7 = default;
		object obj6 = obj7 * obj7;
		object obj8 = obj6 + obj5;
		object obj10 = default;
		object obj9 = obj10 * obj10;
		object obj11 = obj9 + obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A844]");
		Quaternion result;
		if ((nint)obj11 >= 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj12 = 0;
			result = (Quaternion)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v1 (UnityEngine.Quaternion)+E4]");
			bool flag = (nint)0 == 0;
			object obj13 = !flag;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			object obj14 = default;
			if ((nint)obj14 <= 0)
			{
				goto IL_011c;
			}
		}
		Vector4 vector = default;
		result = (Quaternion)vector;
		goto IL_011c;
		IL_011c:
		return result;
	}
}
