using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class GillaCaveSwitch : MonoBehaviour
{
	public GameObject[] parts;

	public Bounds below;

	public Bounds[] belowToo;

	public Bounds room;

	public Bounds front;

	public GillaDoor door;

	public int perFrame;

	public float offAfter;

	public NetworkObject oreField;

	private static GillaCaveSwitch Instance__BackingField;

	public static bool Held;

	private int on;

	private float wantedAt;

	public static GillaCaveSwitch Instance
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC068]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
			return (GillaCaveSwitch)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC068]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC068]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC068]");
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

	public unsafe bool Wanted(Vector3 at)
	{
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected VT, but got Unknown
		//IL_02ce: Expected Ref, but got VT
		//IL_02ec: Expected Obj, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected VT, but got Unknown
		//IL_001d: Expected Ref, but got VT
		//IL_005c: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I4
		//IL_02b6: Expected I4, but got Obj
		//IL_01d3: Expected Obj, but got I8
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_01ec: Expected VT, but got I4
		//IL_01f5: Expected Obj, but got I4
		//IL_0318: Expected Obj, but got I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected VT, but got Unknown
		//IL_0143: Expected Ref, but got VT
		//IL_0161: Expected Obj, but got I4
		//IL_0225: Expected Obj, but got I4
		//IL_023d: Expected Obj, but got I4
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0271: Expected VT, but got Obj
		Bounds bounds = (Bounds)(this + 40);
		Vector3 point = default;
		bool flag = ((Bounds*)bounds)->Internal_Contains(ref point);
		bool flag2 = !flag;
		object obj = !flag2;
		bool flag9;
		if (obj == null)
		{
			Bounds bounds2 = (Bounds)(this + 72);
			if (!((Bounds*)bounds2)->Internal_Contains(ref point))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj4 = !flag3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag4 = door != null;
				bool flag5 = !flag4;
				Vector3 vector = default;
				point = vector;
				if (!flag5)
				{
					if ((object)door == null)
					{
						goto IL_02a8;
					}
					bool isOpen = door.IsOpen;
					bool flag6 = !isOpen;
					point = vector;
					if (!flag6)
					{
						Bounds bounds3 = (Bounds)(this + 96);
						bool flag7 = ((Bounds*)bounds3)->Internal_Contains(ref point);
						bool flag8 = !flag7;
						object obj5 = !flag8;
						point = vector;
						if (obj5 != null)
						{
							goto IL_003e;
						}
					}
				}
				Bounds[] array = belowToo;
				if (belowToo != null)
				{
					if (array.Length < 1)
					{
						flag9 = false;
						goto IL_02fa;
					}
					object obj6 = array.Length & 0xFFFFFFFFL;
					object obj7 = belowToo + 32;
					Bounds bounds4 = (Bounds)0;
					object obj8 = 0;
					while (true)
					{
						bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
						object obj9 = !flag10;
						if (obj9 != null)
						{
							break;
						}
						flag9 = bounds4.Internal_Contains(ref point);
						bool flag11 = !flag9;
						object obj10 = !flag11;
						if (obj10 == null)
						{
							obj6 = array.Length;
							obj8++;
							obj7 += 24;
							bool flag12 = (nint)obj8 < array.Length;
							bounds4 = (Bounds)obj7;
							point = vector;
							if (flag12)
							{
								continue;
							}
						}
						goto IL_02fa;
					}
					IndexOutOfRangeException ex = new IndexOutOfRangeException();
				}
				goto IL_02a8;
			}
		}
		goto IL_003e;
		IL_02a8:
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
		IL_02fa:
		return flag9;
		IL_003e:
		flag9 = true;
		goto IL_02fa;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC068]");
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
			if (((GillaCaveSwitch)obj8).Wanted((Vector3)0))
			{
				object obj9 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v15+A0]");
				object obj10 = 0;
				object obj11 = obj10;
				float time = Time.time;
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v19+A0]");
				object obj13 = 0;
				((GillaCaveSwitch)obj13).All(true);
			}
		}
	}

	private void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_05c9: Expected Obj, but got I
		//IL_05eb: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I4
		//IL_008b: Expected VT, but got I4
		//IL_039a: Expected Obj, but got I
		//IL_03a3: Expected Obj, but got I4
		//IL_03ac: Expected VT, but got I4
		//IL_014e: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I4
		//IL_0160: Expected VT, but got I4
		//IL_040f: Expected Obj, but got I4
		//IL_0180: Expected Obj, but got I4
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_0456: Expected Obj, but got I4
		//IL_0485: Expected Obj, but got I
		//IL_04a1: Expected Obj, but got I4
		//IL_04aa: Expected VT, but got I4
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected Obj, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01e8: Expected Obj, but got I4
		//IL_0217: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I4
		//IL_023c: Expected VT, but got I4
		//IL_04fe: Expected Obj, but got I4
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected Obj, but got Unknown
		//IL_0290: Expected Obj, but got I4
		//IL_0558: Expected Obj, but got I
		//IL_0561: Expected Obj, but got I4
		//IL_056a: Expected VT, but got I4
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02ea: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I4
		//IL_02fc: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC068]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaOreField.Keep(oreField);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v5+8]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Vector3 vector = Eyes();
			if (!Wanted((Vector3)0))
			{
				goto IL_05f9;
			}
		}
		float time = Time.time;
		wantedAt = time;
		goto IL_05f9;
		IL_05f9:
		float time2 = Time.time;
		float num = time2 - wantedAt;
		if (num < offAfter)
		{
			GameObject[] array = parts;
			if (parts != null)
			{
				int num2 = on;
				if (on >= array.Length || perFrame < 1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj8 = 0;
				object obj9 = 0;
				Vector3 vector2 = (Vector3)0;
				while (true)
				{
					GameObject[] array2 = parts;
					if (parts == null)
					{
						break;
					}
					bool flag3 = num2 < array2.Length;
					object obj10 = !flag3;
					if (num2 >= array2.Length)
					{
						return;
					}
					if (obj10 == null)
					{
						object obj11 = obj8;
						object obj12 = parts + num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v21+E4]");
						bool flag4 = (nint)0 == 0;
						object obj13 = !flag4;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v21+20]");
						bool flag5 = (UnityEngine.Object)0 != null;
						bool flag6 = !flag5;
						object obj14 = 0;
						vector2 = (Vector3)0;
						if (!flag6)
						{
							GameObject[] array3 = parts;
							if (parts == null)
							{
								break;
							}
							bool flag7 = on < array3.Length;
							object obj15 = !flag7;
							if (obj15 != null)
							{
								goto IL_05aa;
							}
							object obj16 = parts + on;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v26+20]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v26+20]");
							((GameObject)0).SetActive(value: true);
							obj14 = 0;
							vector2 = (Vector3)1;
						}
						obj9++;
						num2 = ++on;
						if ((nint)obj9 >= perFrame)
						{
							return;
						}
						continue;
					}
					goto IL_05aa;
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
			object obj17 = 0;
			object obj18 = 0;
			Vector3 vector3 = (Vector3)0;
			while (true)
			{
				if (on <= 0)
				{
					return;
				}
				GameObject[] array4 = parts;
				int num3 = --on;
				if (parts == null)
				{
					break;
				}
				bool flag8 = num3 < array4.Length;
				object obj19 = !flag8;
				if (obj19 == null)
				{
					object obj20 = obj17;
					object obj21 = parts + num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v13+E4]");
					bool flag9 = (nint)0 == 0;
					object obj22 = !flag9;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v14+20]");
					bool flag10 = (UnityEngine.Object)0 != null;
					bool flag11 = !flag10;
					object obj14 = 0;
					vector3 = (Vector3)0;
					if (!flag11)
					{
						GameObject[] array5 = parts;
						if (parts == null)
						{
							break;
						}
						bool flag12 = on < array5.Length;
						object obj23 = !flag12;
						if (obj23 != null)
						{
							goto IL_05aa;
						}
						object obj24 = parts + on;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v18+20]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v18+20]");
						((GameObject)0).SetActive(value: false);
						obj14 = 0;
						vector3 = (Vector3)0;
					}
					obj18++;
					if ((nint)obj18 >= perFrame)
					{
						return;
					}
					continue;
				}
				goto IL_05aa;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_05aa;
		IL_05aa:
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

	public GillaCaveSwitch()
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
		perFrame = 20;
		base._002Ector();
	}
}
