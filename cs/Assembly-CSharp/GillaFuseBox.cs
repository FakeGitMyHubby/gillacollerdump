using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using GorillaLocomotion;
using UnityEngine;
using UnityEngine.XR;

public class GillaFuseBox : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public GillaFriends _003C_003E4__this;

		public string function;

		public string name;

		public string id;

		internal void _003CSend_003Eb__0(string json)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0898: Expected Obj, but got I
			//IL_08c2: Expected Obj, but got I4
			//IL_074e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0753: Expected Obj, but got Unknown
			//IL_07a5: Expected Obj, but got I4
			//IL_0094: Expected I, but got Obj
			//IL_07c3: Expected I, but got Obj
			//IL_0312: Expected Obj, but got I
			//IL_0334: Expected Obj, but got I4
			//IL_00b2: Expected Obj, but got I
			//IL_00cf: Expected Obj, but got I
			//IL_00e7: Expected I, but got Obj
			//IL_035c: Expected Obj, but got I4
			//IL_0235: Expected Obj, but got I
			//IL_0253: Expected Obj, but got I4
			//IL_02c9: Expected Obj, but got I
			//IL_02e7: Expected Obj, but got I4
			//IL_011f: Expected Obj, but got I4
			//IL_037a: Expected Obj, but got I
			//IL_038b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0390: Expected Obj, but got Unknown
			//IL_03bc: Expected Obj, but got I8
			//IL_028b: Expected Obj, but got I4
			//IL_0159: Expected Obj, but got I
			//IL_0175: Expected I, but got Obj
			//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f1: Expected Obj, but got Unknown
			//IL_0427: Expected Obj, but got I4
			//IL_043d: Expected Obj, but got I
			//IL_045d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0462: Expected Obj, but got Unknown
			//IL_0193: Expected Obj, but got I
			//IL_019b: Expected I, but got Obj
			//IL_01b2: Expected Obj, but got I
			//IL_0480: Expected Obj, but got I
			//IL_0491: Unknown result type (might be due to invalid IL or missing references)
			//IL_0496: Expected Obj, but got Unknown
			//IL_04c2: Expected Obj, but got I8
			//IL_01fd: Expected Obj, but got I4
			//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f7: Expected Obj, but got Unknown
			//IL_052d: Expected Obj, but got I4
			//IL_0543: Expected Obj, but got I
			//IL_0563: Unknown result type (might be due to invalid IL or missing references)
			//IL_0568: Expected Obj, but got Unknown
			//IL_0586: Expected Obj, but got I
			//IL_0597: Unknown result type (might be due to invalid IL or missing references)
			//IL_059c: Expected Obj, but got Unknown
			//IL_05d0: Expected Obj, but got I4
			//IL_05e6: Expected Obj, but got I
			//IL_0606: Unknown result type (might be due to invalid IL or missing references)
			//IL_060b: Expected Obj, but got Unknown
			//IL_0622: Unknown result type (might be due to invalid IL or missing references)
			//IL_0627: Expected Obj, but got Unknown
			//IL_0637: Expected Obj, but got I
			//IL_0823: Expected Obj, but got I
			//IL_082c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0831: Expected Obj, but got Unknown
			//IL_087a: Expected Obj, but got I4
			GillaFriends gillaFriends = _003C_003E4__this;
			if ((object)_003C_003E4__this == null)
			{
				goto IL_06e1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F30]");
			object obj = 0;
			gillaFriends.busy = false;
			object obj2 = obj;
			string text = default;
			System.__Canon _Canon = JsonUtility.FromJson<System.__Canon>(text);
			System.__Canon _Canon2 = _Canon;
			goto IL_0888;
			IL_06e1:
			NullReferenceException ex = new NullReferenceException();
			bool flag = (nint)text != 1;
			NullReferenceException ex2 = ex;
			nint num;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj4 = default;
				object obj3 = obj4;
				obj2 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj6 = default;
				object obj5 = obj6 & 1;
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					_Canon2 = null;
					goto IL_0888;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj7 = obj4;
				text = (string)(101789696 + 1224);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				num = unchecked((nint)null);
				NullReferenceException ex3 = default;
				ex2 = ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_0888:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string what = GillaFriends.Outcome(function, (GillaFriends.Reply)(object)_Canon2, name);
			GillaFriends.Say(what);
			bool flag3 = _Canon2 == null;
			num = (nint)name;
			IntPtr intPtr;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0E20]");
				object obj11 = 0;
				text = (string)obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X20_v2 (System.__Canon)+10]");
				bool flag4 = (string)0 == (string)obj11;
				bool flag5 = !flag4;
				num = unchecked((nint)null);
				if (!flag5)
				{
					object obj12 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v45+E4]");
					bool flag6 = (nint)0 == 0;
					object obj13 = !flag6;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaFriends.LoadBlocked();
					object obj14 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v36+A0]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v37+8]");
					bool flag7 = (nint)0 == 0;
					num = unchecked((nint)null);
					if (flag7)
					{
						goto IL_06e1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF10]");
					object obj16 = 0;
					num = (nint)obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v37+8]");
					if (((HashSet<System.__Canon>)0).Remove((System.__Canon)(object)id))
					{
						object obj17 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v49+E4]");
						bool flag8 = (nint)0 == 0;
						object obj18 = !flag8;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaFriends.SaveBlocked();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X20_v2 (System.__Canon)+10]");
				bool flag9 = string.IsNullOrEmpty((string)0);
				bool flag10 = !flag9;
				object obj19 = !flag10;
				if (obj19 == null)
				{
					object obj20 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v40+E4]");
					bool flag11 = (nint)0 == 0;
					object obj21 = !flag11;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaFriends.Nudge(id);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X20_v2 (System.__Canon)+20]");
				bool flag12 = string.IsNullOrEmpty((string)0);
				bool flag13 = !flag12;
				object obj22 = !flag13;
				intPtr = num;
				text = null;
				if (obj22 != null)
				{
					goto IL_0693;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			string[] array = default;
			bool flag14 = array == null;
			text = (string)6;
			if (!flag14)
			{
				bool flag15 = array.Length == 0;
				text = (string)6;
				if (!flag15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F40]");
					object obj24 = 0;
					text = (string)obj24;
					object obj25 = array + 32;
					obj25 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X22_v7-8]");
					object obj26 = 0 & 0xFFFFFFFEL;
					if (obj26 != null)
					{
						text = function;
						object obj27 = array + 40;
						obj27 = function;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X22_v9-10]");
						bool flag16 = (nint)0 < (nint)2;
						object obj28 = !flag16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X22_v9-10]");
						object obj29 = -2;
						bool flag17 = obj29 == null;
						object obj30 = ~obj28;
						object obj31 = obj30 | flag17;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F48]");
							object obj32 = 0;
							text = (string)obj32;
							object obj33 = array + 48;
							obj33 = obj32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X22_v11-18]");
							object obj34 = 0 & 0xFFFFFFFCL;
							if (obj34 != null)
							{
								text = id;
								object obj35 = array + 56;
								obj35 = id;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X22_v13-20]");
								bool flag18 = (nint)0 < (nint)4;
								object obj36 = !flag18;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X22_v13-20]");
								object obj37 = -4;
								bool flag19 = obj37 == null;
								object obj38 = ~obj36;
								object obj39 = obj38 | flag19;
								if (obj39 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F38]");
									object obj40 = 0;
									text = (string)obj40;
									object obj41 = array + 64;
									obj41 = obj40;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X22_v15-28]");
									bool flag20 = (nint)0 < (nint)5;
									object obj42 = !flag20;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X22_v15-28]");
									object obj43 = -5;
									bool flag21 = obj43 == null;
									object obj44 = ~obj42;
									object obj45 = obj44 | flag21;
									if (obj45 == null)
									{
										object obj46 = _Canon2 + 32;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFA0]");
										object obj47 = 0;
										if (_Canon2 != null)
										{
											obj47 = obj46;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
										object obj48 = 0;
										object obj49 = array + 72;
										obj49 = obj47;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										string message = string.Concat(array);
										object obj50 = obj48;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v27+E4]");
										bool flag22 = (nint)0 == 0;
										object obj51 = !flag22;
										if (obj51 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Debug.LogWarning(message);
										intPtr = num;
										text = null;
										goto IL_0693;
									}
								}
							}
						}
					}
				}
				IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
			}
			goto IL_06e1;
			IL_0693:
			GillaFriends gillaFriends2 = _003C_003E4__this;
			bool flag23 = (object)_003C_003E4__this == null;
			num = intPtr;
			if (!flag23)
			{
				gillaFriends2.nextLook = 0f;
				return;
			}
			goto IL_06e1;
		}

		internal void _003CSend_003Eb__1(string why)
		{
			//IL_0028: Expected Obj, but got I
			//IL_0038: Expected Obj, but got I
			//IL_0048: Expected Obj, but got I
			//IL_0058: Expected Obj, but got I
			//IL_0068: Expected Obj, but got I
			//IL_009b: Expected Obj, but got I4
			//IL_00d7: Expected Obj, but got I
			//IL_01b3: Expected Obj, but got I4
			//IL_00c2: Expected Obj, but got I
			//IL_013e: Expected Obj, but got I4
			GillaFriends gillaFriends = _003C_003E4__this;
			gillaFriends.busy = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC750]");
			object value = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD6E8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F50]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj4 = 0;
			bool flag = why.StartsWith((string)value);
			object obj5 = obj;
			bool flag2 = !flag;
			object obj6 = !flag2;
			object obj7 = ~obj6;
			object what;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F28]");
				what = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F18]");
				what = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaFriends.Say((string)what);
			string message = (string)obj2 + function + (string)obj3 + why;
			object obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
			GillaFriends gillaFriends2 = _003C_003E4__this;
			gillaFriends2.nextLook = 0f;
		}
	}

	private enum Hunt_
	{
		// error: enumerator has no value
		Make,
		// error: enumerator has no value
		Hold,
		// error: enumerator has no value
		None
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<GillaFuse> _003C_003E9__44_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F98]");
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

		internal bool _003CHunt_003Eb__44_0(GillaFuse f)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0192: Expected Obj, but got I4
			//IL_004c: Expected Obj, but got I4
			//IL_0168: Expected I4, but got Obj
			//IL_00ae: Expected Obj, but got I4
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
			bool flag2 = f == null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				if ((object)f != null)
				{
					GillaItem item = f.Item;
					object obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v7+E4]");
					bool flag4 = (nint)0 == 0;
					object obj6 = !flag4;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (item == null)
					{
						goto IL_00f6;
					}
					GillaItem item2 = f.Item;
					if ((object)item2 != null)
					{
						bool flag5 = !item2.Gone__BackingField;
						return !flag5;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			goto IL_00f6;
			IL_00f6:
			return true;
		}
	}

	public GillaDoor door;

	public Transform[] seats;

	public GameObject[] seated;

	public Renderer[] lamps;

	public Renderer powerLamp;

	public Renderer buttonCap;

	public Transform press;

	public GameObject fusePrefab;

	public Transform spotsSpace;

	public Vector3[] spots;

	public float reach;

	public float handReach;

	public float stayOpen;

	public AudioClip seatSound;

	public AudioClip powerSound;

	public AudioClip acceptSound;

	public AudioClip denySound;

	public Color offColour;

	public Color onColour;

	private static readonly int BaseColorId;

	private const float Again = default(float);

	private const float LieHigh = default(float);

	private static GillaFuseBox Instance__BackingField;

	private readonly List<GillaFuse> yours;

	private readonly Dictionary<GillaFuse, int> spotOf;

	public const int Places = default(int);

	private MaterialPropertyBlock block;

	private readonly Dictionary<Renderer, int> shownColour;

	private bool touching;

	private float nextTry;

	private float openSince;

	private float nextMake;

	public static GillaFuseBox Instance
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F58]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+8]");
			return (GillaFuseBox)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F58]");
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
			object obj4 = (nint)0 + (nint)8;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public IReadOnlyList<GillaFuse> Yours => (IReadOnlyList<GillaFuse>)yours;

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F58]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+A0]");
		object obj6 = (nint)0 + (nint)8;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0066: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action = default;
		action._002Ector(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaCaveFuses.Changed += action;
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0071: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action = default;
		action._002Ector(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaCaveFuses.Changed -= action;
		ThrowAway();
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I
		//IL_0158: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I
		//IL_01d8: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I4
		//IL_01fc: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F58]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X9_v1+8]");
		if ((UnityEngine.Object)0 == this)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v14+A0]");
			object obj14 = (nint)0 + (nint)8;
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private void Start()
	{
		Refresh();
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_07b9: Expected Obj, but got I
		//IL_07db: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I4
		//IL_0801: Expected Obj, but got I
		//IL_0823: Expected Obj, but got I4
		//IL_0890: Expected Obj, but got I
		//IL_08c0: Expected Obj, but got I4
		//IL_017e: Expected Obj, but got I4
		//IL_0687: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I4
		//IL_0773: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I4
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Expected I4, but got Unknown
		//IL_06f4: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got I4
		//IL_0795: Expected Obj, but got I4
		//IL_0304: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I4
		//IL_0333: Expected VT, but got I4
		//IL_0359: Expected Obj, but got I4
		//IL_0382: Expected Obj, but got I4
		//IL_038b: Expected Obj, but got I4
		//IL_03ca: Expected Obj, but got I4
		//IL_03fe: Expected F4, but got I
		//IL_0441: Expected Obj, but got I4
		//IL_0520: Expected Obj, but got I4
		//IL_0560: Expected Obj, but got I4
		//IL_0569: Expected Obj, but got I4
		//IL_04b2: Expected Obj, but got I4
		//IL_0587: Expected F4, but got I
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected Obj, but got Unknown
		//IL_059b: Expected Obj, but got I4
		//IL_05c9: Expected Obj, but got I
		//IL_05f3: Expected Obj, but got I4
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected Obj, but got Unknown
		//IL_0640: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F58]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaCaveFuses.Tick();
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj7 = 0;
		Hunt_ hunt_ = Hunting();
		if (hunt_ != (Hunt_)2)
		{
			bool flag3 = hunt_ == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Hunt();
			}
		}
		else
		{
			ThrowAway();
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v13+A0]");
		object obj14 = 0;
		TakeFuses();
		object obj15 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v15+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = door != null;
		bool flag8 = !flag7;
		object obj17 = 0;
		UnityEngine.Object obj18 = null;
		if (flag8)
		{
			goto IL_065d;
		}
		object obj19 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v39+E4]");
		bool flag9 = (nint)0 == 0;
		object obj20 = !flag9;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag10 = (UnityEngine.Object)obj14 != null;
		bool flag11 = !flag10;
		obj17 = 0;
		obj18 = null;
		object obj33;
		float within = default;
		float num;
		if (!flag11)
		{
			object obj21 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v46+E4]");
			bool flag12 = (nint)0 == 0;
			object obj22 = !flag12;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Transform transform;
			if (press != null)
			{
				transform = press;
				bool flag13 = (object)press == null;
				object obj23 = !flag13;
				if (obj23 == null)
				{
					throw new NullReferenceException();
				}
			}
			else
			{
				transform = base.transform;
			}
			Vector3 position = transform.position;
			object obj24 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v52+E4]");
			bool flag14 = (nint)0 == 0;
			object obj25 = !flag14;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag15 = HandAt((Player)obj14, (Vector3)0, within);
			bool flag16 = !flag15;
			num = handReach;
			obj17 = 0;
			obj18 = null;
			if (!flag16)
			{
				bool flag17 = (byte)(~(touching ? 1u : 0u)) != 0;
				object obj26 = !flag17;
				obj17 = 0;
				obj18 = null;
				if (obj26 == null)
				{
					within = Time.time;
					float num2 = nextTry;
					bool flag18 = within < nextTry;
					obj17 = 0;
					obj18 = null;
					if (!flag18)
					{
						float time = Time.time;
						object obj27 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
						num2 = 0f;
						float num3 = time;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
						within = num3 + 0f;
						nextTry = within;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v59+E4]");
						bool flag19 = (nint)0 == 0;
						object obj28 = !flag19;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool allIn = GillaCaveFuses.AllIn;
						bool flag20 = !allIn;
						obj18 = null;
						if (!flag20)
						{
							bool isOpen = door.IsOpen;
							bool flag21 = !isOpen;
							object obj29 = !flag21;
							obj18 = null;
							if (obj29 == null)
							{
								bool busy = door.Busy;
								bool flag22 = !busy;
								obj18 = null;
								if (flag22)
								{
									door.Press();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
									object obj30 = 0;
									object obj31 = obj30;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v76+E4]");
									bool flag23 = (nint)0 == 0;
									object obj32 = !flag23;
									if (obj32 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									GillaQuests.Report((GillaQuests.Stat)4, 1);
									obj33 = this + 144;
									within = 0.5f;
									obj17 = 0;
									goto IL_0831;
								}
							}
						}
						object obj34 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v66+E4]");
						bool flag24 = (nint)0 == 0;
						object obj35 = !flag24;
						if (obj35 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool allIn2 = GillaCaveFuses.AllIn;
						bool flag25 = !allIn2;
						object obj36 = !flag25;
						obj17 = 0;
						if (obj36 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
							within = 0f;
							obj33 = this + 152;
							obj17 = 0;
							goto IL_0831;
						}
					}
				}
				goto IL_0645;
			}
		}
		bool flag26 = false;
		goto IL_084c;
		IL_0861:
		object obj37;
		bool flag27 = (byte)(obj37 & 1) != 0;
		Show(buttonCap, flag27);
		return;
		IL_084c:
		touching = flag26;
		ShutInTime();
		goto IL_065d;
		IL_0645:
		num = handReach;
		flag26 = true;
		goto IL_084c;
		IL_065d:
		object obj38 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v22+E4]");
		bool flag28 = (nint)0 == 0;
		object obj39 = !flag28;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (GillaCaveFuses.AllIn)
		{
			object obj40 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v29+E4]");
			bool flag29 = (nint)0 == 0;
			object obj41 = !flag29;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (door != null && !door.IsOpen)
			{
				bool busy2 = door.Busy;
				obj37 = (busy2 ? 1 : 0) ^ 1;
				goto IL_0861;
			}
		}
		obj37 = 0;
		goto IL_0861;
		IL_0831:
		Beep((AudioClip)obj33, within);
		obj18 = (UnityEngine.Object)obj33;
		goto IL_0645;
	}

	private static Hunt_ Hunting()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I4
		//IL_025d: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I4
		//IL_02aa: Expected Obj, but got I
		//IL_02ba: Expected Obj, but got I
		//IL_02dc: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_020d: Expected I4, but got Obj
		//IL_00d4: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v1+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v1+8]");
		bool flag4 = (UnityEngine.Object)0 == null;
		bool flag5 = !flag4;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v1+8]");
			if ((nint)0 == 0)
			{
				goto IL_01ff;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v3 (UnityEngine.Object)+A4]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				object obj13 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v15+E4]");
				bool flag7 = (nint)0 == 0;
				object obj14 = !flag7;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v3 (UnityEngine.Object)+B0]");
				bool flag8 = (UnityEngine.Object)0 == null;
				bool flag9 = !flag8;
				object obj15 = !flag9;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v3 (UnityEngine.Object)+B0]");
					if ((nint)0 == 0)
					{
						goto IL_01ff;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v3 (UnityEngine.Object)+B0]");
					if (((NetworkRunner)0).IsRunning)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v3 (UnityEngine.Object)+90]");
						if ((nint)0 != 0)
						{
							return (Hunt_)2;
						}
					}
				}
			}
		}
		return (Hunt_)0;
		IL_01ff:
		NullReferenceException ex = new NullReferenceException();
		return (Hunt_)ex;
	}

	private unsafe void Hunt()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0f90: Expected Obj, but got I4
		//IL_1161: Expected Obj, but got I
		//IL_1171: Expected Obj, but got I
		//IL_1193: Expected Obj, but got I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected I4, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I
		//IL_00cc: Expected I, but got Obj
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected I4, but got Obj
		//IL_0fae: Expected Obj, but got I
		//IL_0fd0: Expected Obj, but got I
		//IL_0fd8: Expected I, but got Obj
		//IL_0fe9: Expected I, but got Obj
		//IL_1007: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected I4, but got Unknown
		//IL_01c7: Expected I4, but got Obj
		//IL_01df: Expected I, but got Obj
		//IL_01ef: Expected I4, but got Obj
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected Obj, but got I
		//IL_0514: Expected I4, but got Obj
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected I, but got Obj
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected Obj, but got I4
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected I4, but got Unknown
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Expected Obj, but got I
		//IL_09d4: Expected Obj, but got I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Expected Obj, but got I4
		//IL_0651: Expected Obj, but got I
		//IL_0670: Expected Obj, but got I
		//IL_105d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1062: Expected Obj, but got Unknown
		//IL_107e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1083: Expected I4, but got Unknown
		//IL_1090: Unknown result type (might be due to invalid IL or missing references)
		//IL_1095: Expected I4, but got Unknown
		//IL_068f: Expected Obj, but got I
		//IL_0697: Expected I, but got Obj
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected I4, but got Obj
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a56: Expected I, but got Obj
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected Obj, but got I
		//IL_0709: Expected Obj, but got I
		//IL_0719: Expected Obj, but got I
		//IL_0327: Expected I, but got Obj
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c47: Expected I, but got Obj
		//IL_0c69: Expected Obj, but got I4
		//IL_0cb0: Expected Obj, but got I4
		//IL_087a: Expected Obj, but got I4
		//IL_0883: Expected Obj, but got I4
		//IL_088c: Expected Obj, but got I4
		//IL_03a0: Expected Obj, but got I4
		//IL_1118: Expected Obj, but got I
		//IL_1120: Expected I4, but got Obj
		//IL_1143: Expected Obj, but got I4
		//IL_0726: Expected I, but got Obj
		//IL_0748: Expected Obj, but got I4
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Expected I4, but got I8
		//IL_0af2: Expected Obj, but got I4
		//IL_078d: Expected Obj, but got I4
		//IL_0b30: Expected I, but got Obj
		//IL_0b52: Expected Obj, but got I4
		//IL_08ab: Expected Obj, but got I4
		//IL_08b3: Expected Obj, but got Ref
		//IL_0408: Expected I, but got Obj
		//IL_0e88: Expected I4, but got Obj
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Expected Obj, but got Unknown
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected Obj, but got Unknown
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0934: Expected F4, but got Unknown
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9b: Expected Obj, but got I4
		//IL_0854: Expected I, but got Obj
		//IL_0d3f: Expected Obj, but got F4
		//IL_0d4c: Expected Obj, but got F4
		//IL_0bb2: Expected I, but got Obj
		//IL_0bfa: Expected Obj, but got I4
		//IL_0c02: Expected I, but got Obj
		//IL_07e2: Expected I, but got Obj
		//IL_080f: Expected Obj, but got I4
		//IL_081f: Expected I, but got Obj
		//IL_0f05: Expected Obj, but got I4
		//IL_096c: Expected Obj, but got I4
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Expected F4, but got Unknown
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db4: Expected I, but got Obj
		//IL_0dd6: Expected Obj, but got I4
		//IL_0e5f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F98]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v58+8]");
		Predicate<System.__Canon> predicate = (Predicate<System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v58+8]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		Predicate<System.__Canon> predicate2 = default;
		object obj9;
		nint num;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v62+A0]");
				obj4 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0FF8]");
			object obj8 = 0;
			obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1000]");
			object obj10 = 0;
			num = (nint)obj10;
			predicate2._002Ector(obj4, (IntPtr)obj10);
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v61+A0]");
			object obj12 = (nint)0 + (nint)8;
			obj12 = predicate2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			predicate = predicate2;
		}
		bool flag4 = (object)yours == null;
		Enumerator<, > val = (Enumerator<, >)0;
		int num2 = (int)predicate2;
		object obj14;
		bool flag8;
		bool flag9;
		nint num8;
		Predicate<System.__Canon> predicate3;
		int num9;
		bool flag6;
		bool flag7;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0FC8]");
			object obj13 = 0;
			num = (nint)obj13;
			int num3 = ((List<System.__Canon>)(object)yours).RemoveAll(predicate);
			List<GillaFuse> list = yours;
			bool flag5 = (object)yours == null;
			val = (Enumerator<, >)0;
			num2 = (int)predicate;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0FE8]");
				obj = 0;
				int num4 = list._size;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0FD0]");
				obj14 = 0;
				object obj15 = list._size - 1;
				flag6 = list._size < 1;
				int num5 = list._size ^ 1;
				int num6 = list._size ^ obj15;
				int num7 = num5 & num6;
				flag7 = num7 < 0;
				num2 = (int)predicate;
				flag8 = flag7;
				flag9 = flag6;
				num8 = (nint)obj13;
				predicate3 = predicate;
				num9 = (int)predicate;
				if (flag6)
				{
					goto IL_04ab;
				}
				while (true)
				{
					bool flag10 = (object)yours == null;
					val = (Enumerator<, >)0;
					if (flag10)
					{
						break;
					}
					num = (nint)obj;
					num4--;
					System.__Canon _Canon = ((List<System.__Canon>)(object)yours).get_Item(num4);
					bool flag11 = _Canon == null;
					val = (Enumerator<, >)0;
					num2 = num4;
					if (flag11)
					{
						break;
					}
					GillaItem item = ((GillaFuse)(object)_Canon).Item;
					bool flag12 = (object)item == null;
					val = (Enumerator<, >)0;
					num2 = num4;
					if (flag12)
					{
						break;
					}
					bool lost = item.Lost;
					bool flag13 = !lost;
					num2 = 0;
					if (!flag13)
					{
						bool flag14 = (object)yours == null;
						val = (Enumerator<, >)0;
						num2 = 0;
						if (flag14)
						{
							break;
						}
						num = (nint)obj;
						System.__Canon _Canon2 = ((List<System.__Canon>)(object)yours).get_Item(num4);
						bool flag15 = _Canon2 == null;
						val = (Enumerator<, >)0;
						num2 = num4;
						if (flag15)
						{
							break;
						}
						GameObject gameObject = ((Component)(object)_Canon2).gameObject;
						list = (List<GillaFuse>)obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v55 (System.Collections.Generic.List`1<GillaFuse>)+E4]");
						bool flag16 = (nint)0 == 0;
						object obj16 = !flag16;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						UnityEngine.Object.Destroy(gameObject);
						bool flag17 = (object)yours == null;
						val = (Enumerator<, >)0;
						predicate = (Predicate<System.__Canon>)(object)gameObject;
						num2 = 0;
						if (flag17)
						{
							break;
						}
						num = (nint)obj14;
						((List<System.__Canon>)(object)yours).RemoveAt(num4);
						predicate = (Predicate<System.__Canon>)(object)gameObject;
						num2 = num4;
					}
					flag6 = num4 < 0;
					int num10 = num4 ^ num4;
					int num11 = num4 & num10;
					flag7 = num11 < 0;
					bool flag18 = num4 > 0;
					flag8 = flag7;
					flag9 = flag6;
					num8 = num;
					predicate3 = predicate;
					num9 = num2;
					if (flag18)
					{
						continue;
					}
					goto IL_04ab;
				}
			}
		}
		goto IL_0c18;
		IL_0c18:
		throw new NullReferenceException();
		IL_099a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
		object obj17 = 0;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X0_v31+E4]");
		bool flag19 = (nint)0 == 0;
		object obj19 = !flag19;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int done = GillaCaveFuses.Done;
		bool flag20 = (object)yours == null;
		num = num8;
		predicate = predicate3;
		if (!flag20)
		{
			predicate = (Predicate<System.__Canon>)(2 - done);
			int num12 = num2;
			List<System.__Canon> list2 = (List<System.__Canon>)(object)yours;
			object obj24;
			do
			{
				object obj20 = list2._size - predicate;
				flag6 = (nint)obj20 < 0;
				int num13 = list2._size ^ predicate;
				int num14 = list2._size ^ obj20;
				int num15 = num13 & num14;
				flag7 = num15 < 0;
				bool flag21 = list2._size <= (nint)predicate;
				num = num8;
				num2 = num12;
				if (!flag21)
				{
					num = (nint)obj;
					num2 = list2._size - 1;
					System.__Canon _Canon3 = list2.get_Item(num2);
					if (_Canon3 == null)
					{
						break;
					}
					GillaItem item2 = ((GillaFuse)(object)_Canon3).Item;
					if ((object)item2 == null)
					{
						break;
					}
					int num16 = (int)(item2.Hand__BackingField & 0x80000000L);
					bool flag22 = num16 == 0;
					object obj21 = !flag22;
					if (obj21 == null)
					{
						GillaItem item3 = ((GillaFuse)(object)_Canon3).Item;
						GillaHands.Drop(item3);
					}
					GameObject obj22 = ((Component)(object)_Canon3).gameObject;
					nint num17 = (nint)obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v30 (Il2CppClass<System.Object>)+E4]");
					bool flag23 = (nint)0 == 0;
					object obj23 = !flag23;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(obj22);
					List<System.__Canon> list3 = (List<System.__Canon>)(object)yours;
					bool flag24 = (object)yours == null;
					num2 = 0;
					if (flag24)
					{
						break;
					}
					num = (nint)obj14;
					num2 = list3._size - 1;
					((List<System.__Canon>)(object)yours).RemoveAt(num2);
					list2 = (List<System.__Canon>)(object)yours;
					bool flag25 = (object)yours == null;
					obj24 = !flag25;
					num8 = (nint)obj14;
					num12 = num2;
					continue;
				}
				if (flag6 == flag7)
				{
					return;
				}
				nint num18 = (nint)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v7 (Il2CppClass<System.Object>)+E4]");
				bool flag26 = (nint)0 == 0;
				object obj25 = !flag26;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag27 = fusePrefab == null;
				bool flag28 = !flag27;
				object obj26 = !flag28;
				if (obj26 != null)
				{
					return;
				}
				Vector3[] array = spots;
				if (spots == null || array.Length == 0)
				{
					return;
				}
				float time = Time.time;
				float num19 = time - nextMake;
				flag6 = time < nextMake;
				object obj27 = time ^ nextMake;
				object obj28 = time ^ num19;
				object obj29 = obj27 & obj28;
				flag7 = (nint)obj29 < 0;
				if (flag6)
				{
					return;
				}
				float time2 = Time.time;
				float num20 = time2 + 1f;
				nextMake = num20;
				GillaFuse gillaFuse = MakeFuse();
				nint num21 = (nint)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v11 (Il2CppClass<System.Object>)+E4]");
				bool flag29 = (nint)0 == 0;
				object obj30 = !flag29;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (gillaFuse != null)
				{
					bool flag30 = (object)yours == null;
					num = 0;
					num2 = 0;
					if (flag30)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0FB8]");
					object obj31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D100");
				}
				return;
			}
			while (obj24 != null);
		}
		goto IL_0c18;
		IL_04ab:
		bool flag31 = (object)spotOf == null;
		val = (Enumerator<, >)0;
		flag7 = flag8;
		flag6 = flag9;
		num = num8;
		predicate = predicate3;
		num2 = num9;
		if (!flag31)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0FA8]");
			object obj32 = 0;
			num2 = (int)obj32;
			int count = ((Dictionary<System.__Canon, int>)(object)spotOf).Count;
			List<GillaFuse> list4 = yours;
			bool flag32 = (object)yours == null;
			val = (Enumerator<, >)0;
			flag7 = flag8;
			flag6 = flag9;
			num = num8;
			predicate = predicate3;
			if (!flag32)
			{
				object obj33 = count - list4._size;
				flag6 = (nint)obj33 < 0;
				int num22 = count ^ list4._size;
				int num23 = count ^ obj33;
				int num24 = num22 & num23;
				flag7 = num24 < 0;
				bool flag33 = count <= list4._size;
				UnityEngine.Object obj35 = default;
				UnityEngine.Object obj34 = obj35;
				val = (Enumerator<, >)0;
				if (flag33)
				{
					goto IL_099a;
				}
				bool flag34 = (object)spotOf == null;
				val = (Enumerator<, >)0;
				num = num8;
				predicate = predicate3;
				if (!flag34)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0FB0]");
					object obj36 = 0;
					Dictionary<System.__Canon, int>.KeyCollection keys = ((Dictionary<System.__Canon, int>)(object)spotOf).Keys;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0FF0]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0FD8]");
					object obj38 = 0;
					num = (nint)obj38;
					List<System.__Canon> list5 = default;
					list5._002Ector((IEnumerable<System.__Canon>)(object)keys);
					bool flag35 = list5 == null;
					val = (Enumerator<, >)0;
					predicate = (Predicate<System.__Canon>)(object)keys;
					num2 = (int)keys;
					if (!flag35)
					{
						Enumerator<, > enumerator = list5.GetEnumerator();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F78]");
						object obj39 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0FA0]");
						object obj40 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0FC0]");
						object obj41 = 0;
						object obj45;
						while (val.MoveNext())
						{
							nint num25 = (nint)obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X0_v78 (Il2CppClass<System.Object>)+E4]");
							bool flag36 = (nint)0 == 0;
							object obj42 = !flag36;
							if (obj42 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag37 = obj35 == null;
							bool flag38 = !flag37;
							object obj43 = !flag38;
							nint num26 = 0;
							System.__Canon _Canon4 = null;
							if (obj43 == null)
							{
								bool flag39 = (object)yours == null;
								num = 0;
								num2 = 0;
								if (flag39)
								{
									goto IL_0e8d;
								}
								num26 = (nint)obj41;
								bool flag40 = ((List<System.__Canon>)(object)yours).Contains((System.__Canon)(object)obj35);
								bool flag41 = !flag40;
								object obj44 = !flag41;
								_Canon4 = (System.__Canon)(object)obj35;
								num = (nint)obj41;
								if (obj44 != null)
								{
									continue;
								}
							}
							if ((object)spotOf != null)
							{
								num = (nint)obj40;
								bool flag42 = ((Dictionary<System.__Canon, int>)(object)spotOf).Remove((System.__Canon)(object)obj35);
								continue;
							}
							NullReferenceException ex = new NullReferenceException();
							num = num26;
							num2 = (int)_Canon4;
							goto IL_0e8d;
							IL_0e8d:
							obj34 = null;
							obj45 = 0;
							throw new NullReferenceException();
						}
						obj34 = null;
						obj45 = 0;
						predicate3 = (Predicate<System.__Canon>)6;
						object obj46 = 0;
						object obj50 = default;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F70]");
							object obj47 = 0;
							num2 = (int)obj47;
							val.Dispose();
							bool flag43 = obj46 == null;
							object obj48 = !flag43;
							if (obj48 == null)
							{
								bool flag44 = (object)obj34 == null;
								object obj49 = !flag44;
								OutOfMemoryException ex2 = (OutOfMemoryException)(&val);
								if (obj49 == null)
								{
									break;
								}
							}
							else
							{
								OutOfMemoryException ex2 = new OutOfMemoryException();
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
							switch (num2)
							{
							case 2:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								obj34 = (UnityEngine.Object)1;
								obj46 = obj45;
								break;
							case 1:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								obj46 = obj50;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								obj45 = obj50;
								break;
							default:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0D5C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return;
							}
							predicate3 = null;
						}
						object obj51 = predicate3 - 6;
						flag6 = (nint)obj51 < 0;
						bool flag45 = (nint)predicate3 == 6;
						object obj52 = predicate3 ^ 6;
						object obj53 = (object)predicate3 ^ obj51;
						object obj54 = obj52 & obj53;
						flag7 = (nint)obj54 < 0;
						Enumerator<, > val2 = default;
						val = val2;
						float num20 = (float)val2;
						Enumerator<, > val3 = (Enumerator<, >)(ref val);
						num8 = num;
						if (!flag45)
						{
							bool flag46 = predicate3 == null;
							object obj55 = !flag46;
							val = val2;
							num20 = (float)val2;
							val3 = (Enumerator<, >)(ref val);
							num8 = num;
							if (obj55 != null)
							{
								return;
							}
						}
						goto IL_099a;
					}
				}
			}
		}
		goto IL_0c18;
	}

	private unsafe GillaFuse MakeFuse()
	{
		//IL_0015: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I4
		//IL_030d: Expected I4, but got I8
		//IL_0b03: Expected Obj, but got I
		//IL_0b2d: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_00d9: Expected I4, but got I8
		//IL_0ae5: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I4
		//IL_0122: Expected I, but got Obj
		//IL_048f: Expected Obj, but got I4
		//IL_03a8: Expected Obj, but got I4
		//IL_01cf: Expected I4, but got I8
		//IL_01e9: Expected Obj, but got I4
		//IL_04ab: Expected Obj, but got I4
		//IL_04ca: Expected Obj, but got I
		//IL_04da: Expected Obj, but got I
		//IL_04ea: Expected Obj, but got I
		//IL_04f3: Expected Obj, but got I4
		//IL_0228: Expected I4, but got I8
		//IL_0184: Expected Obj, but got I4
		//IL_0b9f: Expected Obj, but got I
		//IL_03e3: Expected Obj, but got I4
		//IL_0402: Expected Obj, but got I
		//IL_0412: Expected VT, but got I4
		//IL_0426: Expected Obj, but got I
		//IL_0436: Expected Obj, but got I
		//IL_0446: Expected Obj, but got I
		//IL_0527: Expected Obj, but got I
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected Obj, but got Unknown
		//IL_0561: Expected Obj, but got I8
		//IL_0288: Expected Obj, but got I4
		//IL_058e: Expected Obj, but got I
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected Obj, but got Unknown
		//IL_05d0: Expected Obj, but got I4
		//IL_05e6: Expected Obj, but got I
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected Obj, but got Unknown
		//IL_0629: Expected Obj, but got I
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Expected Obj, but got Unknown
		//IL_0663: Expected Obj, but got I8
		//IL_02c3: Expected I4, but got I8
		//IL_02dd: Expected Obj, but got I4
		//IL_0690: Expected Obj, but got I
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected Obj, but got Unknown
		//IL_06d2: Expected Obj, but got I4
		//IL_06e8: Expected Obj, but got I
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected Obj, but got Unknown
		//IL_072b: Expected Obj, but got I
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected Obj, but got Unknown
		//IL_0bd6: Expected Obj, but got I
		//IL_0bee: Expected Obj, but got I
		//IL_0bfe: Expected Obj, but got I
		//IL_0ca1: Expected Obj, but got I4
		//IL_078c: Expected VT, but got I8
		//IL_07ab: Expected VT, but got Ref
		//IL_07c9: Expected Obj, but got I4
		//IL_0c2a: Expected Obj, but got I4
		//IL_0c4c: Expected Obj, but got I4
		//IL_0cc7: Expected Obj, but got I
		//IL_0cd7: Expected Obj, but got I
		//IL_0cf4: Expected Obj, but got I
		//IL_0d11: Expected Obj, but got I
		//IL_0d2e: Expected Obj, but got I
		//IL_0db6: Expected Obj, but got I4
		//IL_0867: Expected Obj, but got I
		//IL_0877: Expected Obj, but got I
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Expected Obj, but got Unknown
		//IL_090f: Expected Obj, but got I
		//IL_0943: Expected Obj, but got I4
		//IL_09b5: Expected Obj, but got I4
		//IL_08fa: Expected Obj, but got I4
		Vector3[] array = spots;
		object obj7;
		int num;
		object obj9;
		if (spots != null)
		{
			object obj = array.Length - 2;
			bool flag = (nint)obj < 0;
			object obj2 = array.Length ^ 2;
			object obj3 = array.Length ^ obj;
			object obj4 = obj2 & obj3;
			bool flag2 = (nint)obj4 < 0;
			bool flag3 = flag == flag2;
			object obj5 = !flag3;
			object obj6 = ~obj5;
			obj7 = ((obj6 != null) ? ((object)2) : ((object)array.Length));
			if (array.Length < 1)
			{
				num = -1;
				goto IL_0af3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1020]");
			obj9 = 0;
			num = -1;
			int num2 = 0;
			while (true)
			{
				object obj10 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v73+E4]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = GillaCaveFuses.In(num2);
				bool flag6 = !flag5;
				object obj12 = !flag6;
				nint num3 = unchecked((nint)null);
				if (obj12 == null)
				{
					if ((object)spotOf == null)
					{
						break;
					}
					object obj13 = obj9;
					bool flag7 = ((Dictionary<System.__Canon, int>)(object)spotOf).ContainsValue(num2);
					bool flag8 = !flag7;
					object obj14 = !flag8;
					obj6 = ~obj14;
					if (obj6 == null)
					{
						num3 = num2;
					}
					else
					{
						num3 = num2;
						num = num2;
					}
				}
				num2++;
				if (num2 < (nint)obj7)
				{
					int num4 = (int)(num & 0x80000000L);
					bool flag9 = num4 == 0;
					object obj15 = !flag9;
					if (obj15 != null)
					{
						continue;
					}
				}
				goto IL_01f7;
			}
		}
		goto IL_0a2a;
		IL_0af3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj16 = 0;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v7+E4]");
		bool flag10 = (nint)0 == 0;
		object obj18 = !flag10;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num5 = ~num;
		int num6 = num & num5;
		object obj23;
		object obj24;
		object obj25;
		if (spotsSpace != null)
		{
			Vector3[] array2 = spots;
			if (spots != null)
			{
				bool flag11 = num6 < array2.Length;
				object obj19 = !flag11;
				if (obj19 != null)
				{
					goto IL_0a38;
				}
				if ((object)spotsSpace != null)
				{
					object obj20 = num6 * 12;
					object obj21 = (object)spots + obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v53+20]");
					object obj22 = 0;
					Vector3 vector = spotsSpace.TransformPoint((Vector3)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v53+28]");
					obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v53+24]");
					obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v53+20]");
					obj25 = 0;
					goto IL_0b8f;
				}
			}
		}
		else
		{
			Vector3[] array3 = spots;
			if (spots != null)
			{
				bool flag12 = num6 < array3.Length;
				object obj26 = !flag12;
				if (obj26 != null)
				{
					goto IL_0a38;
				}
				object obj27 = num6 * 12;
				object obj28 = (object)spots + obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v51+20]");
				obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v51+24]");
				obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v51+28]");
				obj23 = 0;
				object obj22 = 0;
				goto IL_0b8f;
			}
		}
		goto IL_0a2a;
		IL_01f7:
		if (array.Length >= 1 && (int)(num & 0x80000000L) != 0)
		{
			int num7 = 0;
			while ((object)spotOf != null)
			{
				object obj13 = obj9;
				bool flag13 = ((Dictionary<System.__Canon, int>)(object)spotOf).ContainsValue(num7);
				bool flag14 = !flag13;
				object obj29 = !flag14;
				object obj30 = ~obj29;
				if (obj30 != null)
				{
					num = num7;
				}
				int num8 = num7 + 1;
				bool flag15 = num8 >= (nint)obj7;
				nint num3 = num7;
				if (!flag15)
				{
					int num9 = (int)(num & 0x80000000L);
					bool flag16 = num9 == 0;
					object obj31 = !flag16;
					num7 = num8;
					if (obj31 != null)
					{
						continue;
					}
					num3 = num8;
				}
				goto IL_0af3;
			}
			goto IL_0a2a;
		}
		goto IL_0af3;
		IL_0a2a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0a38;
		IL_0a38:
		return (GillaFuse)(object)new IndexOutOfRangeException();
		IL_0b8f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array4 = default;
		if (array4 == null)
		{
			goto IL_0a2a;
		}
		if (array4.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5A8]");
			object obj33 = 0;
			object obj34 = array4 + 32;
			obj34 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X22_v5-8]");
			object obj35 = 0 & 0xFFFFFFFEL;
			if (obj35 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F18]");
				object obj36 = 0;
				object obj37 = array4 + 40;
				obj37 = obj36;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X22_v7-10]");
				bool flag17 = (nint)0 < (nint)2;
				object obj38 = !flag17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X22_v7-10]");
				object obj39 = -2;
				bool flag18 = obj39 == null;
				object obj40 = ~obj38;
				object obj41 = obj40 | flag18;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F20]");
					object obj42 = 0;
					object obj43 = array4 + 48;
					obj43 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X22_v9-18]");
					object obj44 = 0 & 0xFFFFFFFCL;
					if (obj44 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5C0]");
						object obj45 = 0;
						object obj46 = array4 + 56;
						obj46 = obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X22_v11-20]");
						bool flag19 = (nint)0 < (nint)4;
						object obj47 = !flag19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X22_v11-20]");
						object obj48 = -4;
						bool flag20 = obj48 == null;
						object obj49 = ~obj47;
						object obj50 = obj49 | flag20;
						if (obj50 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5B0]");
							object obj51 = 0;
							object obj52 = array4 + 64;
							obj52 = obj51;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							int mask = LayerMask.GetMask(array4);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
							object obj53 = 0;
							object obj54 = obj53;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v29+A0]");
							object obj55 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
							object obj56 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v31+18]");
							double num10 = 0.0 * 0.5;
							object obj57 = obj56;
							double num11 = (double)obj25 + num10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v29+E4]");
							bool flag21 = (nint)0 == 0;
							object obj58 = !flag21;
							if (obj58 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							int num12 = ~mask;
							Vector3 direction = (Vector3)(0xFFFFFFFBL & num12);
							object obj59 = default;
							QueryTriggerInteraction queryTriggerInteraction = default;
							bool flag22 = Physics.Raycast((Vector3)(&obj59), direction, out *(RaycastHit*)1, (float)num11, 0, queryTriggerInteraction);
							bool flag23 = !flag22;
							object obj60 = !flag23;
							object obj61 = ~obj60;
							if (obj61 == null)
							{
								object obj62 = default;
								obj23 = obj62;
							}
							object obj63 = !flag23;
							object obj64 = ~obj63;
							object obj65 = ((obj64 != null) ? obj25 : obj59);
							object obj66 = !flag23;
							object obj67 = ~obj66;
							object obj69 = default;
							object obj68 = ((obj67 != null) ? obj24 : obj69);
							object obj70 = obj53;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X8_v33+A0]");
							object obj71 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5370]");
							object obj72 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v34+18]");
							nint num13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
							object obj73 = num13 * 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v34+1C]");
							nint num14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
							object obj74 = num14 * 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v34+20]");
							nint num15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
							object obj75 = num15 * 0;
							object obj76 = obj65 + obj73;
							object obj77 = obj68 + obj74;
							object obj78 = obj23 + obj75;
							float num16 = UnityEngine.Random.Range(0f, 360f);
							float num17 = num16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
							float num18 = num17 * 0f;
							Vector3 euler = default;
							Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
							object obj79 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X0_v37+E4]");
							bool flag24 = (nint)0 == 0;
							object obj80 = !flag24;
							if (obj80 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDC9C");
							UnityEngine.Object obj81 = default;
							if ((object)obj81 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1038]");
								object obj82 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5360]");
								object obj83 = 0;
								obj81.name = (string)obj82;
								object obj84 = obj83;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
								object obj86 = default;
								object obj85 = obj86 & 1;
								if (obj85 != null)
								{
									Rigidbody rigidbody = default;
									if ((object)rigidbody == null)
									{
										goto IL_0a2a;
									}
									rigidbody.isKinematic = true;
									obj84 = 0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1030]");
								object obj87 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
								object obj88 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v42+E4]");
								bool flag25 = (nint)0 == 0;
								object obj89 = !flag25;
								if (obj89 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								UnityEngine.Object obj90 = default;
								if (obj90 == null)
								{
									object obj91 = obj16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v52+E4]");
									bool flag26 = (nint)0 == 0;
									object obj92 = !flag26;
									if (obj92 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									UnityEngine.Object.Destroy(obj81);
									return null;
								}
								if ((object)spotOf != null)
								{
									((Dictionary<System.__Canon, int>)(object)spotOf).set_Item((System.__Canon)(object)obj90, num6);
									return (GillaFuse)obj90;
								}
							}
							goto IL_0a2a;
						}
					}
				}
			}
		}
		goto IL_0a38;
	}

	private unsafe void ThrowAway()
	{
		//IL_0010: Expected Obj, but got I
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got I4
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Obj, but got I4
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got I4
		//IL_0616: Expected I, but got Obj
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected Ref, but got Unknown
		//IL_0639: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I4
		//IL_0319: Expected Obj, but got I4
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_046f: Expected I, but got Obj
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected Obj, but got I4
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I4
		//IL_0522: Expected Obj, but got I4
		//IL_052b: Expected Obj, but got I4
		//IL_036e: Expected Obj, but got I4
		//IL_058a: Expected Obj, but got I4
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected I4, but got Unknown
		//IL_025c: Expected Obj, but got I
		//IL_027e: Expected Obj, but got I4
		//IL_01cf: Expected I, but got Obj
		//IL_0423: Expected I, but got Obj
		//IL_01f4: Expected I4, but got I8
		//IL_020e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE84E]");
		List<GillaFuse> list = (List<GillaFuse>)0;
		bool flag = (object)yours == null;
		UnityEngine.Object obj = default;
		List<GillaFuse> list2 = (List<GillaFuse>)obj;
		Enumerator<, > val = (Enumerator<, >)0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F78]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F70]");
			object obj4 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)yours).GetEnumerator();
			UnityEngine.Object obj5 = obj;
			Enumerator<, > val2 = default;
			object obj20 = default;
			while (true)
			{
				int num;
				if (val.MoveNext())
				{
					object obj6 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v32+E4]");
					obj5 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v32+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag3 = obj == null;
					bool flag4 = !flag3;
					object obj8 = !flag4;
					num = 0;
					if (obj8 != null)
					{
						continue;
					}
					nint num2;
					if ((object)obj != null)
					{
						GillaItem item = ((GillaFuse)obj).Item;
						object obj9 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v41+E4]");
						list = (List<GillaFuse>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v41+E4]");
						bool flag5 = (nint)0 == 0;
						object obj10 = !flag5;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (item != null)
						{
							GillaItem item2 = ((GillaFuse)obj).Item;
							bool flag6 = (object)item2 == null;
							num = 0;
							num2 = unchecked((nint)null);
							if (flag6)
							{
								goto IL_047c;
							}
							int num3 = (int)(item2.Hand__BackingField & 0x80000000L);
							bool flag7 = num3 == 0;
							object obj11 = !flag7;
							if (obj11 == null)
							{
								GillaItem item3 = ((GillaFuse)obj).Item;
								GillaHands.Drop(item3);
							}
						}
						GameObject obj12 = ((Component)obj).gameObject;
						object obj13 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v48+E4]");
						obj5 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v48+E4]");
						bool flag8 = (nint)0 == 0;
						object obj14 = !flag8;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						UnityEngine.Object.Destroy(obj12);
						num = 0;
						continue;
					}
					NullReferenceException ex = new NullReferenceException();
					num = 0;
					num2 = unchecked((nint)null);
					list = (List<GillaFuse>)obj5;
					goto IL_047c;
				}
				object obj15 = 5;
				list2 = null;
				val = val2;
				object obj16 = 0;
				Enumerator<, > val3 = (Enumerator<, >)(ref val);
				Enumerator<, > val4 = val2;
				Enumerator<, > val5 = (Enumerator<, >)(ref val);
				list = (List<GillaFuse>)obj5;
				object obj17 = 0;
				while (true)
				{
					nint num2 = (nint)obj4;
					((Enumerator<, >*)val5)->Dispose();
					bool flag9 = obj17 == null;
					object obj18 = !flag9;
					if (obj18 == null)
					{
						bool flag10 = (object)list2 == null;
						object obj19 = !flag10;
						OutOfMemoryException ex2 = (OutOfMemoryException)val5;
						list = list2;
						if (obj19 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex2 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch ((long)num2)
					{
					case 2L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						list2 = (List<GillaFuse>)1;
						list = (List<GillaFuse>)1;
						obj17 = obj16;
						break;
					case 1L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj17 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj16 = obj20;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0D5C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					obj15 = 0;
				}
				if ((nint)obj15 != 5)
				{
					bool flag11 = obj15 == null;
					object obj21 = !flag11;
					if (obj21 != null)
					{
						return;
					}
				}
				list = yours;
				if ((object)yours == null)
				{
					break;
				}
				num = list._size;
				val3 = (Enumerator<, >)(list._version + 1);
				list._size = 0;
				list._version = (int)val3;
				if (list._size >= 1)
				{
					Array.Clear(list._items, 0, list._size);
					nint num2 = unchecked((nint)null);
				}
				if ((object)spotOf == null)
				{
					break;
				}
				((Dictionary<System.__Canon, int>)(object)spotOf).Clear();
				return;
				IL_047c:
				NullReferenceException ex3 = new NullReferenceException();
				list2 = null;
				val = val2;
				obj16 = 0;
				val3 = (Enumerator<, >)(ref val);
				val4 = val2;
				val5 = (Enumerator<, >)(ref val);
				break;
			}
		}
		throw new NullReferenceException();
	}

	private unsafe void TakeFuses()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d82: Expected Obj, but got I4
		//IL_0d90: Expected Obj, but got I4
		//IL_0daa: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I
		//IL_013c: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I4
		//IL_017a: Expected I, but got Obj
		//IL_09fc: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I4
		//IL_01f6: Expected Obj, but got I4
		//IL_022f: Expected Obj, but got I4
		//IL_0234: Expected I, but got Obj
		//IL_025c: Expected Obj, but got I4
		//IL_0261: Expected I, but got Obj
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected F4, but got Unknown
		//IL_028f: Expected Obj, but got I4
		//IL_095d: Expected Obj, but got I4
		//IL_0d1f: Expected I, but got Obj
		//IL_0d42: Expected Obj, but got I4
		//IL_0d56: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got I4
		//IL_0300: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Expected I, but got Obj
		//IL_09b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected Obj, but got Ref
		//IL_0aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Expected Obj, but got I4
		//IL_0ab6: Expected I, but got Obj
		//IL_0369: Expected Obj, but got I4
		//IL_03ae: Expected Obj, but got I4
		//IL_03b7: Expected Obj, but got I4
		//IL_0ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Expected Obj, but got I4
		//IL_0ae2: Expected I, but got Obj
		//IL_0403: Expected I4, but got I8
		//IL_041d: Expected Obj, but got I4
		//IL_0426: Expected Obj, but got I4
		//IL_0b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b69: Expected Obj, but got I4
		//IL_0b6e: Expected I, but got Obj
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3d: Expected Obj, but got I4
		//IL_0b42: Expected I, but got Obj
		//IL_04ac: Expected Obj, but got I4
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Expected Obj, but got I4
		//IL_0b0e: Expected I, but got Obj
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected Obj, but got Unknown
		//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b95: Expected Obj, but got I4
		//IL_0b9a: Expected I, but got Obj
		//IL_04ff: Expected Obj, but got I
		//IL_05ba: Expected Obj, but got I4
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb9: Expected Obj, but got I4
		//IL_0bbe: Expected I, but got Obj
		//IL_0650: Expected Obj, but got I4
		//IL_06a0: Expected Obj, but got I4
		//IL_06ec: Expected F4, but got I
		//IL_071e: Expected F4, but got I
		//IL_0756: Expected Obj, but got I4
		//IL_07b2: Expected F4, but got I
		//IL_07bb: Expected Obj, but got I4
		//IL_07d9: Expected Obj, but got I
		//IL_0bdc: Expected F4, but got I
		//IL_0be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Expected Obj, but got I4
		//IL_0c14: Expected F4, but got I
		//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c25: Expected Obj, but got I4
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Expected Obj, but got Unknown
		//IL_0c54: Expected F4, but got I
		//IL_0c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c65: Expected Obj, but got I4
		//IL_0c6a: Expected I, but got Obj
		//IL_088a: Expected Obj, but got I
		//IL_08b4: Expected Obj, but got I4
		//IL_08f3: Expected F4, but got I
		//IL_08f3: Expected VT, but got I4
		//IL_091d: Expected Obj, but got I
		//IL_093d: Expected F4, but got I
		//IL_0946: Expected Obj, but got I4
		//IL_094f: Expected Obj, but got I4
		Transform[] array = seats;
		if (seats == null)
		{
			goto IL_0c70;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F78]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1008]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F70]");
		object obj5 = 0;
		Enumerator<, > val = (Enumerator<, >)0;
		int num = 0;
		double num3 = default;
		double num5 = default;
		object obj16 = default;
		float num6;
		float num8;
		float num11 = default;
		object obj22;
		nint num13;
		double num2;
		double num4;
		object obj15;
		float num10;
		object obj17;
		nint num12;
		float num7 = default;
		float num9 = default;
		while (true)
		{
			bool flag = num < 1;
			object obj6 = !flag;
			object obj7 = num - 1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			object obj9 = obj6 & obj8;
			if (obj9 != null || num >= array.Length)
			{
				return;
			}
			bool flag3 = num < array.Length;
			object obj10 = !flag3;
			if (obj10 != null)
			{
				break;
			}
			object obj11 = obj;
			object obj12 = array + num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v18+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v10+20]");
			bool flag5 = (UnityEngine.Object)0 == null;
			bool flag6 = !flag5;
			object obj14 = !flag6;
			num2 = num3;
			num4 = num5;
			obj15 = obj16;
			num6 = num7;
			num8 = num9;
			num10 = num11;
			obj17 = 0;
			num12 = unchecked((nint)null);
			if (obj14 == null)
			{
				object obj18 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X0_v23+E4]");
				bool flag7 = (nint)0 == 0;
				object obj19 = !flag7;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag8 = GillaCaveFuses.In(num);
				bool flag9 = !flag8;
				object obj20 = !flag9;
				num2 = num3;
				num4 = num5;
				obj15 = obj16;
				num6 = num7;
				num8 = num9;
				num10 = num11;
				obj17 = 0;
				num12 = unchecked((nint)null);
				if (obj20 == null)
				{
					goto IL_0242;
				}
			}
			array = seats;
			num++;
			bool flag10 = seats == null;
			object obj21 = !flag10;
			num3 = num2;
			num5 = num4;
			obj16 = obj15;
			num7 = num6;
			num9 = num8;
			num11 = num10;
			obj22 = obj17;
			num13 = num12;
			if (obj21 != null)
			{
				continue;
			}
			goto IL_0a4a;
		}
		goto IL_0c7e;
		IL_0c70:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0c7e;
		IL_0c7e:
		throw new IndexOutOfRangeException();
		IL_0a4a:
		num3 = num2;
		num5 = num4;
		obj16 = obj15;
		num7 = num6;
		num9 = num8;
		num11 = num10;
		obj22 = obj17;
		num13 = num12;
		goto IL_0c70;
		IL_0242:
		bool flag11 = (object)yours == null;
		obj22 = 0;
		num13 = unchecked((nint)null);
		if (!flag11)
		{
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)yours).GetEnumerator();
			Enumerator<, > val2 = default;
			float num14 = (float)val2;
			obj22 = 0;
			AudioClip[] array3 = default;
			while (true)
			{
				bool flag12 = val.MoveNext();
				bool flag13 = !flag12;
				num6 = num7;
				num8 = num9;
				num11 = num14;
				object obj44;
				Enumerator<, > val3;
				if (!flag13)
				{
					object obj23 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v35+E4]");
					bool flag14 = (nint)0 == 0;
					object obj24 = !flag14;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag15 = (UnityEngine.Object)null == (UnityEngine.Object)null;
					bool flag16 = !flag15;
					object obj25 = !flag16;
					obj22 = 0;
					if (obj25 != null)
					{
						continue;
					}
					if (0 == 0)
					{
						NullReferenceException ex2 = new NullReferenceException();
						num11 = num14;
						val3 = (Enumerator<, >)(ref val);
						obj22 = 0;
						num13 = unchecked((nint)null);
						break;
					}
					GillaItem item = ((GillaFuse)null).Item;
					object obj26 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X0_v42+E4]");
					bool flag17 = (nint)0 == 0;
					object obj27 = !flag17;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag18 = item == null;
					bool flag19 = !flag18;
					object obj28 = !flag19;
					obj22 = 0;
					if (obj28 != null)
					{
						continue;
					}
					GillaItem item2 = ((GillaFuse)null).Item;
					if ((object)item2 == null)
					{
						NullReferenceException ex2 = new NullReferenceException();
						num11 = num14;
						val3 = (Enumerator<, >)(ref val);
						obj22 = 0;
						num13 = unchecked((nint)null);
						break;
					}
					int num15 = (int)(item2.Hand__BackingField & 0x80000000L);
					bool flag20 = num15 == 0;
					object obj29 = !flag20;
					obj22 = 0;
					if (obj29 != null)
					{
						continue;
					}
					Transform transform = ((Component)null).transform;
					if ((object)transform == null)
					{
						NullReferenceException ex2 = new NullReferenceException();
						num11 = num14;
						val3 = (Enumerator<, >)(ref val);
						obj22 = 0;
						num13 = unchecked((nint)null);
						break;
					}
					Vector3 position = transform.position;
					Transform[] array2 = seats;
					if (seats == null)
					{
						NullReferenceException ex2 = new NullReferenceException();
						num11 = num14;
						val3 = (Enumerator<, >)(ref val);
						obj22 = 0;
						num13 = unchecked((nint)null);
						break;
					}
					bool flag21 = num < array2.Length;
					object obj30 = !flag21;
					if (obj30 != null)
					{
						IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
						num11 = num14;
						val3 = (Enumerator<, >)(ref val);
						obj22 = 0;
						num13 = unchecked((nint)null);
						NullReferenceException ex2 = (NullReferenceException)(object)ex3;
						break;
					}
					object obj31 = seats + num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v24+20]");
					if ((nint)0 == 0)
					{
						NullReferenceException ex2 = new NullReferenceException();
						num11 = num14;
						val3 = (Enumerator<, >)(ref val);
						obj22 = 0;
						num13 = unchecked((nint)null);
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v24+20]");
					Vector3 position2 = ((Transform)0).position;
					float num16 = num14 - num14;
					float num17 = num9 - num9;
					float num18 = num7 - num7;
					float num19 = num16 * num16;
					float num20 = num17 * num17;
					float num21 = num19 + num20;
					float num22 = num18 * num18;
					num7 = reach;
					num11 = num22 + num21;
					num9 = reach * reach;
					bool flag22 = num11 > num9;
					num14 = num11;
					obj22 = 0;
					if (flag22)
					{
						continue;
					}
					GillaItem item3 = ((GillaFuse)null).Item;
					GillaHands.Drop(item3);
					if ((object)yours == null)
					{
						NullReferenceException ex2 = new NullReferenceException();
						val3 = (Enumerator<, >)(ref val);
						obj22 = 0;
						num13 = unchecked((nint)null);
						break;
					}
					obj22 = obj4;
					bool flag23 = ((List<System.__Canon>)(object)yours).Remove((System.__Canon)null);
					GameObject obj32 = ((Component)null).gameObject;
					object obj33 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X0_v65+E4]");
					bool flag24 = (nint)0 == 0;
					object obj34 = !flag24;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(obj32);
					object obj35 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ X0_v68+E4]");
					bool flag25 = (nint)0 == 0;
					object obj36 = !flag25;
					if (obj36 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int done = GillaCaveFuses.Done;
					GillaCaveFuses.Put(num);
					AudioClip clip = seatSound;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					Beep(clip, 0f);
					bool flag26 = done != 1;
					num6 = num7;
					num8 = num9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					num11 = 0f;
					if (!flag26)
					{
						object obj37 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v74+E4]");
						bool flag27 = (nint)0 == 0;
						object obj38 = !flag27;
						if (obj38 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag28 = powerSound != null;
						bool flag29 = !flag28;
						num6 = num7;
						num8 = num9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
						num11 = 0f;
						obj22 = 0;
						if (!flag29)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
							object obj39 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							NullReferenceException ex2;
							if (array3 != null)
							{
								if (array3.Length != 0)
								{
									object obj40 = array3 + 32;
									obj40 = powerSound;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Transform transform2 = base.transform;
									if ((object)transform2 != null)
									{
										Vector3 position3 = transform2.position;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
										object obj41 = 0;
										object obj42 = obj41;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X0_v89+E4]");
										bool flag30 = (nint)0 == 0;
										object obj43 = !flag30;
										if (obj43 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
										Sfx.Play(array3, (Vector3)0, 0f, num9, num7);
										num3 = 1.0;
										num5 = 1.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
										obj16 = 0;
										num6 = num7;
										num8 = num9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
										num11 = 0f;
										obj22 = 0;
										obj44 = 0;
										goto IL_0d17;
									}
									ex2 = new NullReferenceException();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
									num11 = 0f;
									val3 = (Enumerator<, >)(ref val);
									obj22 = 0;
									num13 = unchecked((nint)null);
									break;
								}
								IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
								num11 = 0f;
								val3 = (Enumerator<, >)(ref val);
								obj22 = 0;
								num13 = 1;
								ex2 = (NullReferenceException)(object)ex4;
								break;
							}
							ex2 = new NullReferenceException();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
							num11 = 0f;
							val3 = (Enumerator<, >)(ref val);
							obj22 = 0;
							num13 = 1;
							break;
						}
					}
				}
				obj44 = 0;
				goto IL_0d17;
				IL_0d17:
				num13 = (nint)obj5;
				val.Dispose();
				bool flag31 = obj44 == null;
				object obj45 = !flag31;
				num7 = num6;
				num9 = num8;
				val3 = (Enumerator<, >)(ref val);
				if (obj45 == null)
				{
					num2 = num3;
					num4 = num5;
					obj15 = obj16;
					val = val2;
					num10 = num11;
					val3 = (Enumerator<, >)(ref val);
					obj17 = obj22;
					num12 = (nint)obj5;
					num7 = num6;
					num9 = num8;
					val3 = (Enumerator<, >)(ref val);
					OutOfMemoryException ex5 = (OutOfMemoryException)(&val);
				}
				else
				{
					OutOfMemoryException ex5 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0D5C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
		}
		goto IL_0c70;
	}

	private void ShutInTime()
	{
		//IL_0082: Invalid comparison between F4 and I4
		//IL_027c: Expected Obj, but got I
		//IL_02a6: Expected Obj, but got I4
		//IL_02de: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I
		//IL_03a9: Expected Obj, but got I
		//IL_03d3: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I4
		//IL_0220: Expected Obj, but got I4
		//IL_0360: Expected Obj, but got I4
		//IL_0252: Expected Obj, but got I4
		//IL_03f1: Expected Obj, but got I
		//IL_0198: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got I
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_01ed: Unsupported input type for neg.
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		if (!door.IsOpen || door.IsMoving)
		{
			openSince = -1f;
			return;
		}
		float num = openSince;
		if (openSince < 0f)
		{
			num = Time.time;
			openSince = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v15+A0]");
		object obj7 = 0;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj7 != null;
		bool flag5 = !flag4;
		object obj10 = 0;
		if (!flag5)
		{
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v26+E4]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v30+E4]");
			bool flag7 = (nint)0 == 0;
			object obj14 = !flag7;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v30+A0]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v19+6CC]");
			object obj17 = -0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v19+6CC]");
			object obj18 = (nint)0 & (nint)3;
			object obj19 = obj17 & 3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v19+6CC]");
			if ((nint)0 >= (nint)0)
			{
				obj18 = 0 - obj19;
			}
			object obj20 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			obj10 = obj20 * 0;
		}
		float time = Time.time;
		float num2 = time - openSince;
		float num3 = (float)obj10 + stayOpen;
		if (!(num2 > num3))
		{
			return;
		}
		bool busy = door.Busy;
		bool flag8 = !busy;
		object obj21 = !flag8;
		if (obj21 == null)
		{
			bool flag9 = SomeoneInDoorway();
			bool flag10 = !flag9;
			object obj22 = !flag10;
			if (obj22 == null)
			{
				door.Press();
			}
		}
	}

	private unsafe bool SomeoneInDoorway()
	{
		//IL_0761: Expected Obj, but got Ref
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected Obj, but got Ref
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got I
		//IL_004b: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		//IL_007d: Expected I, but got Obj
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got I4
		//IL_037f: Expected Obj, but got I
		//IL_03a9: Expected Obj, but got I4
		//IL_083f: Expected Obj, but got I
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected I, but got Obj
		//IL_019d: Expected Obj, but got I
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got I
		//IL_03ef: Expected Obj, but got I
		//IL_0400: Expected Obj, but got I
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got I4
		//IL_023d: Expected Obj, but got VT
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected Obj, but got I4
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got I4
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Expected Ref, but got Unknown
		//IL_0900: Expected Obj, but got I4
		//IL_0435: Expected Obj, but got I4
		//IL_0270: Expected I, but got Obj
		//IL_0280: Expected Obj, but got I
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected Obj, but got I4
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected Obj, but got Unknown
		//IL_02d8: Invalid comparison between VT and I4
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got VT
		//IL_032e: Expected VT, but got Ref
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected Obj, but got I4
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got I4
		//IL_0353: Expected Obj, but got Ref
		//IL_06e1: Expected Obj, but got I4
		//IL_06ea: Expected Obj, but got I4
		//IL_04f9: Expected Obj, but got I
		//IL_055f: Expected Obj, but got I
		//IL_056e: Expected VT, but got Ref
		Enumerator<, > val = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag = (object)door == null;
		UnityEngine.Object obj2 = default;
		GillaDoor gillaDoor = (GillaDoor)obj2;
		Enumerator<, > val2 = (Enumerator<, >)0;
		object obj4 = default;
		object obj3 = obj4;
		object obj6 = default;
		object obj5 = obj6;
		Enumerator<, > val3 = (Enumerator<, >)0;
		val = (Enumerator<, >)0;
		GillaFuseBox gillaFuseBox = this;
		GillaDoor gillaDoor2 = (GillaDoor)(&val);
		object obj11;
		bool result;
		ref GillaGlass._003C_003Ec__DisplayClass50_0 reference;
		if (!flag)
		{
			Vector3 foot = door.Foot;
			gillaDoor2 = door;
			bool flag2 = (object)door == null;
			gillaDoor = (GillaDoor)obj2;
			val2 = (Enumerator<, >)0;
			obj3 = obj4;
			obj5 = obj6;
			val3 = (Enumerator<, >)0;
			val = (Enumerator<, >)0;
			gillaFuseBox = null;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj7 = 0;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X9_v8+A0]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
				UnityEngine.Object obj10 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				nint num = (nint)obj10;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X9_v9+1C]");
				object obj13 = 0 * obj4;
				Vector3 vector = gillaDoor2.Through__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X9_v9+1C]");
				obj5 = vector * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v15 (Il2CppClass<UnityEngine.Object>)+A0]");
				object obj14 = 0;
				object obj16 = default;
				object obj15 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v4 (GillaDoor)+148]");
				obj16 = obj15 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X9_v9+18]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v4 (GillaDoor)+148]");
				object obj17 = num2 * 0;
				obj3 = obj13 - obj16;
				val3 = (Enumerator<, >)(obj17 - obj5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v30+E4]");
				bool flag3 = (nint)0 == 0;
				object obj18 = !flag3;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag4 = (UnityEngine.Object)obj14 != null;
				bool flag5 = !flag4;
				reference = ref *(GillaGlass._003C_003Ec__DisplayClass50_0*)null;
				gillaFuseBox = null;
				if (flag5)
				{
					goto IL_036f;
				}
				nint num3 = (nint)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v29 (Il2CppClass<UnityEngine.Object>)+A0]");
				object obj19 = 0;
				gillaDoor2 = (GillaDoor)obj19;
				bool flag6 = obj19 == null;
				gillaDoor = (GillaDoor)obj2;
				val2 = (Enumerator<, >)0;
				reference = ref *(GillaGlass._003C_003Ec__DisplayClass50_0*)null;
				val = (Enumerator<, >)0;
				gillaFuseBox = null;
				if (!flag6)
				{
					object obj20 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v62+E4]");
					bool flag7 = (nint)0 == 0;
					object obj21 = !flag7;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag8 = (UnityEngine.Object)gillaDoor2.shutTurn != null;
					bool flag9 = !flag8;
					reference = ref *(GillaGlass._003C_003Ec__DisplayClass50_0*)null;
					gillaFuseBox = null;
					if (flag9)
					{
						goto IL_036f;
					}
					nint num4 = (nint)obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v32 (Il2CppClass<UnityEngine.Object>)+A0]");
					object obj22 = 0;
					gillaDoor2 = (GillaDoor)obj22;
					bool flag10 = obj22 == null;
					gillaDoor = (GillaDoor)obj2;
					val2 = (Enumerator<, >)0;
					reference = ref *(GillaGlass._003C_003Ec__DisplayClass50_0*)null;
					val = (Enumerator<, >)0;
					gillaFuseBox = null;
					if (!flag10)
					{
						bool flag11 = gillaDoor2.shutTurn == (Quaternion)(object)0;
						gillaDoor = (GillaDoor)obj2;
						val2 = (Enumerator<, >)0;
						reference = ref *(GillaGlass._003C_003Ec__DisplayClass50_0*)null;
						val = (Enumerator<, >)0;
						gillaFuseBox = null;
						if (!flag11)
						{
							Vector3 position = ((Transform)gillaDoor2.shutTurn).position;
							bool flag12 = _003CSomeoneInDoorway_003Eg__In_007C50_0((Vector3)(&val), ref *(GillaGlass._003C_003Ec__DisplayClass50_0*)null);
							bool flag13 = !flag12;
							reference = ref *(GillaGlass._003C_003Ec__DisplayClass50_0*)null;
							gillaFuseBox = (GillaFuseBox)(&val);
							if (flag13)
							{
								goto IL_036f;
							}
							result = true;
							goto IL_061c;
						}
					}
				}
			}
		}
		goto IL_0677;
		IL_036f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj23 = 0;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v36+E4]");
		bool flag14 = (nint)0 == 0;
		object obj25 = !flag14;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj24 = obj23;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v36+A0]");
		gillaDoor2 = (GillaDoor)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v4 (GillaDoor)+8]");
		bool flag15 = (nint)0 == 0;
		gillaDoor = (GillaDoor)obj2;
		val2 = (Enumerator<, >)0;
		val = (Enumerator<, >)0;
		if (!flag15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v4 (GillaDoor)+8]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			bool flag16;
			ref GillaGlass._003C_003Ec__DisplayClass50_0 reference2;
			Enumerator<, > val4 = default;
			object obj32;
			Enumerator<, > val5;
			while (true)
			{
				flag16 = val2.MoveNext();
				bool flag17 = !flag16;
				reference2 = ref reference;
				if (flag17)
				{
					break;
				}
				object obj28 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v43+E4]");
				bool flag18 = (nint)0 == 0;
				object obj29 = !flag18;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag19 = obj2 != null;
				bool flag20 = !flag19;
				reference = ref *(GillaGlass._003C_003Ec__DisplayClass50_0*)null;
				if (flag20)
				{
					continue;
				}
				if ((object)obj2 != null)
				{
					object obj30 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v50+E4]");
					bool flag21 = (nint)0 == 0;
					object obj31 = !flag21;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ stack_-98 (UnityEngine.Object)+68]");
					bool flag22 = (UnityEngine.Object)0 != null;
					bool flag23 = !flag22;
					reference = ref *(GillaGlass._003C_003Ec__DisplayClass50_0*)null;
					if (flag23)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ stack_-98 (UnityEngine.Object)+68]");
					bool flag24 = (nint)0 == 0;
					reference = ref *(GillaGlass._003C_003Ec__DisplayClass50_0*)null;
					gillaFuseBox = null;
					if (!flag24)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ stack_-98 (UnityEngine.Object)+68]");
						Vector3 position2 = ((Transform)0).position;
						bool flag25 = _003CSomeoneInDoorway_003Eg__In_007C50_0((Vector3)(&val), ref *(GillaGlass._003C_003Ec__DisplayClass50_0*)null);
						bool flag26 = !flag25;
						reference2 = ref *(GillaGlass._003C_003Ec__DisplayClass50_0*)null;
						reference = ref *(GillaGlass._003C_003Ec__DisplayClass50_0*)null;
						if (!flag26)
						{
							break;
						}
						continue;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
					reference = ref *(GillaGlass._003C_003Ec__DisplayClass50_0*)null;
					gillaFuseBox = null;
				}
				NullReferenceException ex2 = new NullReferenceException();
				gillaDoor = null;
				val2 = val4;
				obj32 = 0;
				val5 = (Enumerator<, >)(ref val2);
				val3 = val4;
				val = (Enumerator<, >)0;
				goto IL_0677;
			}
			gillaDoor = null;
			val2 = val4;
			obj32 = 0;
			val5 = (Enumerator<, >)(ref val2);
			reference = ref reference2;
			val3 = val4;
			val = (Enumerator<, >)0;
			object obj33 = 0;
			result = flag16;
			bool result2 = default;
			object obj36 = default;
			while (true)
			{
				gillaFuseBox = (GillaFuseBox)obj27;
				((Enumerator<, >*)val5)->Dispose();
				bool flag27 = obj33 == null;
				object obj34 = !flag27;
				if (obj34 == null)
				{
					bool flag28 = (object)gillaDoor == null;
					object obj35 = !flag28;
					OutOfMemoryException ex3 = (OutOfMemoryException)val5;
					if (obj35 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex3 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)gillaFuseBox == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					gillaDoor = (GillaDoor)1;
					gillaDoor2 = (GillaDoor)1;
					obj33 = obj32;
				}
				else
				{
					if ((nint)gillaFuseBox != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj33 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj32 = obj36;
				}
				result = false;
			}
			goto IL_061c;
		}
		goto IL_0677;
		IL_061c:
		return result;
		IL_0677:
		throw new NullReferenceException();
	}

	private static bool HandAt(Player gt, Vector3 p, float within)
	{
		//IL_02f8: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I4
		//IL_0162: Invalid comparison between F4 and Obj
		//IL_02bb: Invalid comparison between F4 and I4
		if ((object)gt != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = gt.leftHandFollower != null;
			bool flag3 = !flag2;
			object obj5 = default;
			object obj4 = obj5;
			object obj7 = default;
			object obj6 = obj7;
			float num = within;
			UnityEngine.Object obj8 = null;
			object obj12 = default;
			if (!flag3)
			{
				if ((object)gt.leftHandFollower == null)
				{
					goto IL_02ea;
				}
				Vector3 position = gt.leftHandFollower.position;
				float num2 = within - within;
				object obj9 = obj7 - obj7;
				obj4 = obj5 - obj5;
				float num3 = num2 * num2;
				object obj10 = obj9 * obj9;
				float num4 = num3 + (float)obj10;
				object obj11 = obj4 * obj4;
				num = (float)obj11 + num4;
				obj6 = obj12 * obj12;
				bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
				obj8 = null;
				if (flag4)
				{
					return true;
				}
			}
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v10+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(gt.rightHandFollower != null))
			{
				return false;
			}
			if ((object)gt.rightHandFollower != null)
			{
				Vector3 position2 = gt.rightHandFollower.position;
				float num5 = num - within;
				object obj15 = obj6 - obj7;
				object obj16 = obj4 - obj5;
				float num6 = num5 * num5;
				object obj17 = obj15 * obj15;
				float num7 = num6 + (float)obj17;
				object obj18 = obj16 * obj16;
				float num8 = (float)obj18 + num7;
				object obj19 = obj12 * obj12;
				float num9 = num8 - (float)obj19;
				return num9 < 0f;
			}
		}
		goto IL_02ea;
		IL_02ea:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void Beep(AudioClip clip, float buzz)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01ff: Expected Obj, but got I4
		//IL_0181: Expected F4, but got I
		//IL_01b6: Expected F4, but got I
		//IL_005f: Expected Obj, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I4
		//IL_0150: Expected VT, but got I4
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
		if (clip != null)
		{
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
					object obj6 = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v27+E4]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float pitchMin = default;
					float pitchMax = default;
					Sfx.Play(array, (Vector3)0, buzz, pitchMin, pitchMax);
					goto IL_0155;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			throw new IndexOutOfRangeException();
		}
		goto IL_0155;
		IL_0155:
		InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode((XRNode)5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
		InputDevice inputDevice = default;
		bool flag3 = inputDevice.SendHapticImpulse(0u, buzz, 0f);
		InputDevice deviceAtXRNode2 = InputDevices.GetDeviceAtXRNode((XRNode)4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
		bool flag4 = inputDevice.SendHapticImpulse(0u, buzz, 0f);
	}

	private void Refresh()
	{
		//IL_0408: Expected Obj, but got I
		//IL_0418: Expected Obj, but got I
		//IL_0421: Expected Obj, but got I4
		//IL_0450: Expected Obj, but got I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I4
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got Unknown
		//IL_00e3: Expected Obj, but got I4
		//IL_030e: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I
		//IL_03a7: Expected Obj, but got I4
		//IL_0332: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I
		//IL_0243: Expected Obj, but got I4
		//IL_028b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC008]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = 4;
		while (true)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int socket = obj3 - 4;
			bool flag2 = GillaCaveFuses.In(socket);
			GameObject[] array = seated;
			object obj6;
			bool flag4;
			if (seated != null)
			{
				obj6 = obj3 - 4;
				bool flag3 = (nint)obj6 >= array.Length;
				flag4 = false;
				if (!flag3)
				{
					bool flag5 = (nint)obj6 < array.Length;
					object obj7 = !flag5;
					if (obj7 != null)
					{
						break;
					}
					object obj8 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v20+E4]");
					bool flag6 = (nint)0 == 0;
					object obj9 = !flag6;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v5 (UnityEngine.GameObject[])+v52 @ X24_v2*8]");
					bool flag7 = (UnityEngine.Object)0 != null;
					bool flag8 = !flag7;
					bool flag9 = false;
					flag4 = false;
					if (!flag8)
					{
						GameObject[] array2 = seated;
						if (seated != null)
						{
							bool flag10 = (nint)obj6 < array2.Length;
							object obj10 = !flag10;
							if (obj10 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v12 (UnityEngine.GameObject[])+v52 @ X24_v2*8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v12 (UnityEngine.GameObject[])+v52 @ X24_v2*8]");
								bool activeSelf = ((GameObject)0).activeSelf;
								bool flag11 = flag2 == activeSelf;
								flag9 = false;
								flag4 = false;
								if (flag11)
								{
									goto IL_02a1;
								}
								GameObject[] array3 = seated;
								if (seated != null)
								{
									bool flag12 = (nint)obj6 < array3.Length;
									object obj11 = !flag12;
									if (obj11 != null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v14 (UnityEngine.GameObject[])+v52 @ X24_v2*8]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v14 (UnityEngine.GameObject[])+v52 @ X24_v2*8]");
										((GameObject)0).SetActive(flag2);
										flag9 = false;
										flag4 = flag2;
										goto IL_02a1;
									}
								}
							}
						}
						goto IL_03e3;
					}
				}
				goto IL_02a1;
			}
			goto IL_03e3;
			IL_03e3:
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_02a1:
			Renderer[] array4 = lamps;
			if (lamps != null)
			{
				bool flag13 = (nint)obj6 >= array4.Length;
				nint num = (flag4 ? 1 : 0);
				if (!flag13)
				{
					bool flag14 = (nint)obj6 < array4.Length;
					object obj12 = !flag14;
					if (obj12 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v9 (UnityEngine.Renderer[])+v52 @ X24_v2*8]");
					Show((Renderer)0, flag2);
					bool flag9 = flag2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v9 (UnityEngine.Renderer[])+v52 @ X24_v2*8]");
					num = 0;
				}
				obj3++;
				if ((nint)obj3 == 6)
				{
					object obj13 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v13+E4]");
					bool flag15 = (nint)0 == 0;
					object obj14 = !flag15;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool allIn = GillaCaveFuses.AllIn;
					Show(powerLamp, allIn);
					return;
				}
				continue;
			}
			goto IL_03e3;
		}
		throw new IndexOutOfRangeException();
	}

	private void Show(Renderer r, bool on)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0262: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I
		//IL_0213: Expected Obj, but got I
		//IL_0225: Expected VT, but got I4
		//IL_0225: Expected I4, but got Obj
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
		bool flag2 = r == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null || (((Dictionary<System.__Canon, int>)(object)shownColour).TryGetValue((System.__Canon)(object)r, out int value) && value == (on ? 1 : 0)))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1018]");
		object obj5 = 0;
		((Dictionary<System.__Canon, int>)(object)shownColour).set_Item((System.__Canon)(object)r, on ? 1 : 0);
		object obj6 = this + 208;
		bool flag4 = obj6 == null;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			obj6 = materialPropertyBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		r.GetPropertyBlock((MaterialPropertyBlock)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F58]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v15+E4]");
		object obj11;
		if ((nint)0 != 0)
		{
			bool flag5 = !on;
			obj11 = obj10;
			if (flag5)
			{
				goto IL_01f6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj9;
			bool flag6 = !on;
			object obj12 = !flag6;
			obj11 = obj9;
			if (obj12 == null)
			{
				goto IL_01f6;
			}
		}
		goto IL_0203;
		IL_0203:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v15+A0]");
		object obj13 = 0;
		((MaterialPropertyBlock)obj6).SetColor((int)obj13, (Color)0);
		r.SetPropertyBlock((MaterialPropertyBlock)obj6);
		return;
		IL_01f6:
		obj10 = obj11;
		goto IL_0203;
	}

	public GillaFuseBox()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_0109: Expected F4, but got I
		//IL_011b: Expected VT, but got I
		//IL_012d: Expected VT, but got I
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8408]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0FF0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1048]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1058]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = this + 40;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj10 = this + 48;
		object obj11 = default;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj12 = this + 56;
		object obj13 = default;
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj14 = this + 104;
		object obj15 = default;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		stayOpen = 15f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C610]");
		reach = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D150]");
		offColour = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E510]");
		onColour = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj16 = this + 192;
		obj16 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, int> dictionary = default;
		dictionary._002Ector();
		object obj17 = this + 200;
		obj17 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, int> dictionary2 = default;
		dictionary2._002Ector();
		object obj18 = this + 216;
		obj18 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		openSince = -1f;
		base._002Ector();
	}

	static GillaFuseBox()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0F58]");
		object obj2 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = num;
	}

	private bool _003CSomeoneInDoorway_003Eg__In_007C50_0(Vector3 p, ref GillaGlass._003C_003Ec__DisplayClass50_0 P_1)
	{
		//IL_0220: Expected I4, but got Obj
		//IL_0201: Invalid comparison between F4 and I4
		GillaDoor gillaDoor = door;
		if ((object)door != null)
		{
			object obj = default;
			float num = (float)obj - p.x;
			object obj2 = default;
			float num2 = (float)obj2 - p.y;
			object obj3 = default;
			float num3 = (float)obj3 - p.z;
			float num4 = num * (float)gillaDoor.Through__BackingField;
			float num5 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (GillaDoor)+148]");
			float num6 = num5 * 0f;
			float num7 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (GillaDoor)+14C]");
			float num8 = num7 * 0f;
			float num9 = num4 + num6;
			float num10 = num8 + num9;
			double num11 = (double)gillaDoor.Thickness__BackingField * 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			double num12 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			double num13 = num12 + 0.0;
			if ((double)num10 < num13)
			{
				float num14 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (UnityEngine.Vector3)+18]");
				float num15 = num14 * 0f;
				float num16 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (UnityEngine.Vector3)+1C]");
				float num17 = num16 * 0f;
				float num18 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (UnityEngine.Vector3)+20]");
				float num19 = num18 * 0f;
				float num20 = num15 + num17;
				double num21 = (double)gillaDoor.Width__BackingField * 0.5;
				float num22 = num19 + num20;
				double num23 = num21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				double num24 = num23 + 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				if ((double)num22 < num24)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					float num25 = num2 - 3f;
					return num25 < 0f;
				}
			}
			return false;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
