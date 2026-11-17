using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class GillaBackroomsSwitch : MonoBehaviour
{
	public GameObject[] parts;

	public Bounds below;

	public Bounds[] notBelow;

	public Bounds room;

	public Bounds store;

	public GillaDoor door;

	public int perFrame;

	public float offAfter;

	private static GillaBackroomsSwitch Instance__BackingField;

	public static bool Held;

	public static bool ForMonster;

	private int on;

	private float wantedAt;

	public static GillaBackroomsSwitch Instance
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB08]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
			return (GillaBackroomsSwitch)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB08]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+A0]");
			object obj3 = 0;
			obj3 = value;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public bool AllOn
	{
		get
		{
			//IL_00a6: Expected I4, but got Obj
			//IL_003a: Expected Obj, but got I4
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected I4, but got Unknown
			GameObject[] array = parts;
			if (parts != null)
			{
				object obj = on - array.Length;
				bool flag = (nint)obj < 0;
				int num = on ^ array.Length;
				int num2 = on ^ obj;
				int num3 = num & num2;
				bool flag2 = num3 < 0;
				return flag == flag2;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public bool AllOff
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected I4, but got Unknown
			object obj = on - 1;
			bool flag = (nint)obj < 0;
			int num = on ^ 1;
			int num2 = on ^ obj;
			int num3 = num & num2;
			bool flag2 = num3 < 0;
			bool flag3 = flag == flag2;
			return !flag3;
		}
	}

	private void Awake()
	{
		//IL_0022: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB08]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X9_v1+A0]");
		object obj3 = 0;
		obj3 = this;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		GameObject[] array = parts;
		on = array.Length;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB08]");
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

	private void Start()
	{
		//IL_0013: Expected VT, but got I
		Vector3 vector = Eyes();
		IntPtr intPtr = default;
		if (Wanted((Vector3)(nint)intPtr))
		{
			float time = Time.time;
			wantedAt = time;
		}
		else
		{
			All(state: false);
		}
	}

	public unsafe static bool SameSide(Vector3 a, Vector3 b)
	{
		//IL_00d3: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I
		//IL_0048: Expected Obj, but got I4
		//IL_00c3: Expected I4, but got Obj
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected I4, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected VT, but got Unknown
		//IL_006d: Expected Ref, but got VT
		//IL_0138: Expected Obj, but got I
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected VT, but got Unknown
		//IL_0091: Expected Ref, but got VT
		//IL_00a2: Expected Obj, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB08]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v5+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7;
		if ((UnityEngine.Object)obj5 == null)
		{
			obj7 = 1;
			goto IL_00d8;
		}
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v10+A0]");
		object obj9 = 0;
		if (obj9 != null)
		{
			Bounds bounds = (Bounds)(obj9 + 40);
			Vector3 point = default;
			bool flag2 = ((Bounds*)bounds)->Internal_Contains(ref point);
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v16+A0]");
			object obj11 = 0;
			if (obj11 != null)
			{
				Bounds bounds2 = (Bounds)(obj11 + 40);
				bool flag3 = ((Bounds*)bounds2)->Internal_Contains(ref point);
				object obj12 = flag2 ^ flag3;
				obj7 = obj12 ^ 1;
				goto IL_00d8;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_00d8:
		return (byte)(obj7 & 1) != 0;
	}

	public unsafe static bool OnYourSide(Vector3 at)
	{
		//IL_0170: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got I4
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected I4, but got Unknown
		//IL_0060: Expected Obj, but got VT
		//IL_00c8: Invalid comparison between Obj and F8
		//IL_018d: Expected Obj, but got I
		//IL_0160: Expected I4, but got Obj
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected VT, but got Unknown
		//IL_00fc: Expected Ref, but got VT
		//IL_01c2: Expected Obj, but got I
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected VT, but got Unknown
		//IL_0120: Expected Ref, but got VT
		//IL_0131: Expected Obj, but got I4
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB08]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 == null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		object obj23;
		if (obj7 == null)
		{
			Vector3 vector = Eyes();
			Vector3 vector2 = default;
			object obj8 = vector2 - vector2;
			object obj10 = default;
			object obj9 = obj10 - obj10;
			object obj12 = default;
			object obj11 = obj12 - obj12;
			object obj13 = obj8 * obj8;
			object obj14 = obj9 * obj9;
			object obj15 = obj13 + obj14;
			object obj16 = obj11 * obj11;
			object obj17 = obj16 + obj15;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)9.0))
			{
				object obj18 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v11+A0]");
				object obj19 = 0;
				if (obj19 != null)
				{
					Bounds bounds = (Bounds)(obj19 + 40);
					Vector3 point = default;
					bool flag4 = ((Bounds*)bounds)->Internal_Contains(ref point);
					object obj20 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v17+A0]");
					object obj21 = 0;
					if (obj21 != null)
					{
						Bounds bounds2 = (Bounds)(obj21 + 40);
						bool flag5 = ((Bounds*)bounds2)->Internal_Contains(ref point);
						object obj22 = flag4 ^ flag5;
						obj23 = obj22 ^ 1;
						goto IL_01df;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}
		obj23 = 1;
		goto IL_01df;
		IL_01df:
		return (byte)(obj23 & 1) != 0;
	}

	public unsafe bool Wanted(Vector3 at)
	{
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected VT, but got Unknown
		//IL_019b: Expected Ref, but got VT
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected VT, but got Unknown
		//IL_0048: Expected Ref, but got VT
		//IL_0087: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I4
		//IL_000f: Expected VT, but got Ref
		//IL_0183: Expected I4, but got Obj
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected VT, but got Unknown
		//IL_015e: Expected Ref, but got VT
		Bounds bounds = (Bounds)(this + 40);
		Vector3 point = default;
		if (!((Bounds*)bounds)->Internal_Contains(ref point) || Elsewhere((Vector3)(&point)))
		{
			Bounds bounds2 = (Bounds)(this + 72);
			if (!((Bounds*)bounds2)->Internal_Contains(ref point))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (door != null)
				{
					if ((object)door == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					if (door.IsOpen)
					{
						Bounds bounds3 = (Bounds)(this + 96);
						return ((Bounds*)bounds3)->Internal_Contains(ref point);
					}
				}
				return false;
			}
		}
		return true;
	}

	private bool Elsewhere(Vector3 at)
	{
		//IL_024d: Expected I4, but got Obj
		//IL_005c: Expected Obj, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0093: Expected Obj, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected I4, but got Unknown
		//IL_00db: Expected Obj, but got I8
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I4
		//IL_0105: Expected VT, but got I4
		//IL_0266: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01e0: Expected Obj, but got I4
		//IL_0210: Expected VT, but got Obj
		Bounds[] array = notBelow;
		object obj5;
		if (notBelow != null)
		{
			bool flag = array.Length < 0;
			bool flag2 = array.Length == 0;
			object obj = array.Length ^ array.Length;
			object obj2 = array.Length & obj;
			bool flag3 = (nint)obj2 < 0;
			bool flag4 = flag == flag3;
			object obj3 = !flag2;
			object obj4 = flag4 & obj3;
			bool flag5 = array.Length < 1;
			obj5 = obj4;
			if (flag5)
			{
				goto IL_021e;
			}
			object obj6 = array.Length & 0xFFFFFFFFL;
			object obj7 = notBelow + 32;
			object obj8 = 0;
			object obj9 = obj4;
			Bounds bounds = (Bounds)0;
			Vector3 point = default;
			Vector3 vector = default;
			while (true)
			{
				bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
				object obj10 = !flag6;
				if (obj10 != null)
				{
					break;
				}
				bool flag7 = bounds.Internal_Contains(ref point);
				bool flag8 = !flag7;
				object obj11 = !flag8;
				obj5 = obj9;
				if (obj11 == null)
				{
					obj6 = array.Length;
					obj8++;
					obj7 += 24;
					object obj12 = obj8 - array.Length;
					bool flag9 = (nint)obj12 < 0;
					object obj13 = obj8 ^ array.Length;
					object obj14 = obj8 ^ obj12;
					object obj15 = obj13 & obj14;
					bool flag10 = (nint)obj15 < 0;
					bool flag11 = flag9 == flag10;
					object obj16 = !flag11;
					bool flag12 = (nint)obj8 < array.Length;
					obj5 = obj16;
					point = vector;
					obj9 = obj16;
					bounds = (Bounds)obj7;
					if (flag12)
					{
						continue;
					}
				}
				goto IL_021e;
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
		IL_021e:
		return (byte)(obj5 & 1) != 0;
	}

	public static void Prepare(Vector3 at)
	{
		//IL_00a2: Expected Obj, but got I
		//IL_011f: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I
		//IL_0052: Expected VT, but got I4
		//IL_00dc: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB08]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj5 != null)
		{
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v10+A0]");
			object obj8 = 0;
			if (((GillaBackroomsSwitch)obj8).Wanted((Vector3)0))
			{
				object obj9 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v15+A0]");
				object obj10 = 0;
				object obj11 = obj10;
				float time = Time.time;
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v19+A0]");
				object obj13 = 0;
				((GillaBackroomsSwitch)obj13).All(true);
			}
		}
	}

	private void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0578: Expected Obj, but got I
		//IL_059a: Expected Obj, but got I4
		//IL_0037: Expected Obj, but got I4
		//IL_0058: Expected VT, but got I
		//IL_035a: Expected Obj, but got I
		//IL_0363: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I4
		//IL_03c6: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I4
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Obj, but got Unknown
		//IL_040d: Expected Obj, but got I4
		//IL_043c: Expected Obj, but got I
		//IL_0458: Expected Obj, but got I4
		//IL_045d: Expected I, but got Obj
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Obj, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_01ac: Expected Obj, but got I4
		//IL_01db: Expected Obj, but got I
		//IL_01f7: Expected Obj, but got I4
		//IL_01fc: Expected I, but got Obj
		//IL_04b1: Expected Obj, but got I4
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected Obj, but got Unknown
		//IL_0250: Expected Obj, but got I4
		//IL_050b: Expected Obj, but got I
		//IL_0514: Expected Obj, but got I4
		//IL_0519: Expected I, but got Obj
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_02aa: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB08]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+8]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+9]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Vector3 vector = Eyes();
				nint num = default;
				if (!Wanted((Vector3)num))
				{
					goto IL_05a8;
				}
			}
		}
		float time = Time.time;
		wantedAt = time;
		goto IL_05a8;
		IL_05a8:
		float time2 = Time.time;
		float num2 = time2 - wantedAt;
		if (num2 < offAfter)
		{
			GameObject[] array = parts;
			if (parts != null)
			{
				int num3 = on;
				if (on >= array.Length || perFrame < 1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj6 = 0;
				object obj7 = 0;
				while (true)
				{
					GameObject[] array2 = parts;
					if (parts == null)
					{
						break;
					}
					bool flag3 = num3 < array2.Length;
					object obj8 = !flag3;
					if (num3 >= array2.Length)
					{
						return;
					}
					if (obj8 == null)
					{
						object obj9 = obj6;
						object obj10 = parts + num3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v18+E4]");
						bool flag4 = (nint)0 == 0;
						object obj11 = !flag4;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v20+20]");
						bool flag5 = (UnityEngine.Object)0 != null;
						bool flag6 = !flag5;
						object obj12 = 0;
						nint num = unchecked((nint)null);
						if (!flag6)
						{
							GameObject[] array3 = parts;
							if (parts == null)
							{
								break;
							}
							bool flag7 = on < array3.Length;
							object obj13 = !flag7;
							if (obj13 != null)
							{
								goto IL_0559;
							}
							object obj14 = parts + on;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v25+20]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v25+20]");
							((GameObject)0).SetActive(value: true);
							obj12 = 0;
							num = 1;
						}
						obj7++;
						num3 = ++on;
						if ((nint)obj7 >= perFrame)
						{
							return;
						}
						continue;
					}
					goto IL_0559;
				}
			}
		}
		else
		{
			if (on < 1 || perFrame < 1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj15 = 0;
			object obj16 = 0;
			while (true)
			{
				if (on <= 0)
				{
					return;
				}
				GameObject[] array4 = parts;
				int num4 = --on;
				if (parts == null)
				{
					break;
				}
				bool flag8 = num4 < array4.Length;
				object obj17 = !flag8;
				if (obj17 == null)
				{
					object obj18 = obj15;
					object obj19 = parts + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v10+E4]");
					bool flag9 = (nint)0 == 0;
					object obj20 = !flag9;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v13+20]");
					bool flag10 = (UnityEngine.Object)0 != null;
					bool flag11 = !flag10;
					object obj12 = 0;
					nint num = unchecked((nint)null);
					if (!flag11)
					{
						GameObject[] array5 = parts;
						if (parts == null)
						{
							break;
						}
						bool flag12 = on < array5.Length;
						object obj21 = !flag12;
						if (obj21 != null)
						{
							goto IL_0559;
						}
						object obj22 = parts + on;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v17+20]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v17+20]");
						((GameObject)0).SetActive(value: false);
						obj12 = 0;
						num = unchecked((nint)null);
					}
					obj16++;
					if ((nint)obj16 >= perFrame)
					{
						return;
					}
					continue;
				}
				goto IL_0559;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0559;
		IL_0559:
		throw new IndexOutOfRangeException();
	}

	private void All(bool state)
	{
		//IL_0038: Expected Obj, but got I8
		//IL_0048: Expected Obj, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0067: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I
		//IL_00dd: Expected I, but got Obj
		//IL_0163: Expected Obj, but got I4
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_0105: Expected Obj, but got I
		//IL_011c: Expected I, but got Obj
		//IL_0147: Expected Obj, but got I
		//IL_014c: Expected I, but got Obj
		GameObject[] array = parts;
		if (array.Length >= 1)
		{
			object obj = array.Length & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = array + 32;
			bool flag = state;
			object obj4 = 0;
			do
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
				object obj5 = !flag2;
				if (obj5 == null)
				{
					object obj6 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v7+E4]");
					bool flag3 = (nint)0 == 0;
					object obj7 = !flag3;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X25_v4+v71 @ X23_v5*8]");
					bool flag4 = (UnityEngine.Object)0 != null;
					bool flag5 = !flag4;
					nint num = unchecked((nint)null);
					flag = false;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X25_v4+v71 @ X23_v5*8]");
						bool activeSelf = ((GameObject)0).activeSelf;
						bool flag6 = activeSelf == state;
						num = unchecked((nint)null);
						flag = state;
						if (!flag6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X25_v4+v71 @ X23_v5*8]");
							((GameObject)0).SetActive(state);
							num = unchecked((nint)null);
							flag = state;
						}
					}
					obj = array.Length;
					obj4++;
					continue;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
			while ((nint)obj4 < array.Length);
		}
		int num2;
		if (state)
		{
			GameObject[] array2 = parts;
			num2 = array2.Length;
		}
		else
		{
			num2 = 0;
		}
		on = num2;
	}

	private static Vector3 Eyes()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I4
		//IL_0109: Expected VT, but got I4
		//IL_00bb: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = main != null;
		if (flag2)
		{
			if ((object)main != null)
			{
				Transform transform = main.transform;
				if ((object)transform != null)
				{
					return transform.position;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
		return (Vector3)flag2;
	}

	public GillaBackroomsSwitch()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_005c: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5048]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = this + 32;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj5 = this + 64;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		wantedAt = -1f / 0f;
		perFrame = 40;
		base._002Ector();
	}
}
