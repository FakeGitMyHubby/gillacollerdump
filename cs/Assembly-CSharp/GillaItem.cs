using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class GillaItem : MonoBehaviour
{
	public string label;

	public int coins;

	public AudioClip[] knocks;

	public bool keeps;

	public bool recycles;

	public static readonly List<GillaItem> All;

	private int Hand__BackingField;

	private bool Swallowed__BackingField;

	private bool Gone__BackingField;

	private bool Pinned__BackingField;

	private bool Floats__BackingField;

	private bool Laid__BackingField;

	private bool passes;

	private bool ForMonsters__BackingField;

	private bool StaffOnly__BackingField;

	private bool Stuck__BackingField;

	private bool Worn__BackingField;

	public Action<Vector3, Vector3, float, Collider> Knocked;

	private float KnockLoudness__BackingField;

	private Vector3 InHandAt__BackingField;

	private Quaternion InHandTurn__BackingField;

	private Rigidbody Body__BackingField;

	private Collider[] Colliders__BackingField;

	private GillaItemNet Net__BackingField;

	private Renderer[] renderers;

	private float bornY;

	private float stirred;

	private float knockCool;

	private bool throwWaits;

	private Vector3 throwVelocity;

	private Vector3 throwSpin;

	public int Hand
	{
		get
		{
			return Hand__BackingField;
		}
		private set
		{
			Hand__BackingField = value;
		}
	}

	public bool Swallowed
	{
		get
		{
			return Swallowed__BackingField;
		}
		private set
		{
			Swallowed__BackingField = value;
		}
	}

	public bool Gone
	{
		get
		{
			return Gone__BackingField;
		}
		private set
		{
			Gone__BackingField = value;
		}
	}

	public bool Pinned
	{
		get
		{
			return Pinned__BackingField;
		}
		set
		{
			Pinned__BackingField = value;
		}
	}

	public bool Floats
	{
		get
		{
			return Floats__BackingField;
		}
		set
		{
			Floats__BackingField = value;
		}
	}

	public bool Laid
	{
		get
		{
			return Laid__BackingField;
		}
		set
		{
			Laid__BackingField = value;
		}
	}

	public bool Passes
	{
		get
		{
			return passes;
		}
		set
		{
			//IL_0038: Expected Obj, but got I8
			//IL_0048: Expected Obj, but got I
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected Obj, but got Unknown
			//IL_0069: Expected Obj, but got I4
			//IL_01b5: Expected Obj, but got I4
			//IL_0098: Expected Obj, but got I4
			//IL_00c7: Expected Obj, but got I
			//IL_00df: Expected I, but got Obj
			//IL_0127: Expected Obj, but got I4
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected Obj, but got Unknown
			//IL_010b: Expected Obj, but got I
			//IL_0110: Expected I, but got Obj
			Collider[] array = Colliders__BackingField;
			passes = value;
			if (Colliders__BackingField == null || array.Length < 1)
			{
				return;
			}
			object obj = array.Length & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = Colliders__BackingField + 32;
			bool flag = value;
			object obj4 = 0;
			while (true)
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
				object obj5 = !flag2;
				if (obj5 != null)
				{
					break;
				}
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v7+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X24_v3+v143 @ X22_v5*8]");
				bool flag4 = (UnityEngine.Object)0 != null;
				bool flag5 = !flag4;
				nint num = unchecked((nint)null);
				flag = false;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X24_v3+v143 @ X22_v5*8]");
					((Collider)0).isTrigger = value;
					num = unchecked((nint)null);
					flag = value;
				}
				obj = array.Length;
				obj4++;
				if ((nint)obj4 >= array.Length)
				{
					return;
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			throw new NullReferenceException();
		}
	}

	public bool ForMonsters
	{
		get
		{
			return ForMonsters__BackingField;
		}
		set
		{
			ForMonsters__BackingField = value;
		}
	}

	public bool StaffOnly
	{
		get
		{
			return StaffOnly__BackingField;
		}
		set
		{
			StaffOnly__BackingField = value;
		}
	}

	public bool Stuck
	{
		get
		{
			return Stuck__BackingField;
		}
		set
		{
			Stuck__BackingField = value;
		}
	}

	public bool Worn
	{
		get
		{
			return Worn__BackingField;
		}
		set
		{
			Worn__BackingField = value;
		}
	}

	public float KnockLoudness
	{
		get
		{
			return KnockLoudness__BackingField;
		}
		set
		{
			KnockLoudness__BackingField = value;
		}
	}

	public Vector3 InHandAt
	{
		get
		{
			//IL_0002: Expected VT, but got Obj
			return (Vector3)this;
		}
		set
		{
			Vector3 vector = default;
			InHandAt__BackingField = vector;
		}
	}

	public Quaternion InHandTurn
	{
		get
		{
			//IL_0002: Expected VT, but got Obj
			return (Quaternion)this;
		}
		set
		{
			Quaternion quaternion = default;
			InHandTurn__BackingField = quaternion;
		}
	}

	public bool JustKnocked
	{
		get
		{
			//IL_000b: Invalid comparison between F4 and I4
			//IL_001c: Invalid comparison between F4 and I4
			//IL_0033: Expected Obj, but got F4
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected Obj, but got Unknown
			//IL_006a: Expected Obj, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected I4, but got Unknown
			bool flag = knockCool < 0f;
			bool flag2 = knockCool == 0f;
			object obj = knockCool ^ knockCool;
			object obj2 = knockCool & obj;
			bool flag3 = (nint)obj2 < 0;
			bool flag4 = flag == flag3;
			object obj3 = !flag2;
			return (byte)((flag4 & obj3) ? 1 : 0) != 0;
		}
	}

	public Rigidbody Body
	{
		get
		{
			return Body__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 120;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public Collider[] Colliders
	{
		get
		{
			return Colliders__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 128;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public GillaItemNet Net
	{
		get
		{
			return Net__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 136;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public bool Mine
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_019a: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got I4
			//IL_0170: Expected I4, but got Obj
			//IL_00dd: Expected I4, but got Obj
			//IL_00eb: Expected I4, but got Obj
			//IL_010f: Expected Obj, but got I
			//IL_0129: Expected Obj, but got I4
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
			bool flag2 = (UnityEngine.Object)Net__BackingField == (UnityEngine.Object)null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			bool result;
			if (obj4 == null)
			{
				if ((object)Net__BackingField != null)
				{
					if (!Net__BackingField.Live)
					{
						goto IL_0146;
					}
					GillaItemNet gillaItemNet = Net__BackingField;
					if ((object)Net__BackingField != null)
					{
						result = (byte)(int)((SimulationBehaviour)gillaItemNet)._object != 0;
						if ((int)(~((SimulationBehaviour)gillaItemNet)._object) == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v6 (System.Boolean)+58]");
							object obj5 = (nint)0 & (nint)2;
							bool flag4 = obj5 == null;
							object obj6 = !flag4;
							if (obj6 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
								bool result2 = default;
								return result2;
							}
							result = false;
						}
						goto IL_01a8;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			goto IL_0146;
			IL_01a8:
			return result;
			IL_0146:
			result = true;
			goto IL_01a8;
		}
	}

	public bool HeldByOther
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
			if ((UnityEngine.Object)Net__BackingField != (UnityEngine.Object)null)
			{
				if ((object)Net__BackingField != null)
				{
					return Net__BackingField.HeldByOther;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	public bool PaysMe
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
			if ((UnityEngine.Object)Net__BackingField == (UnityEngine.Object)null)
			{
				return true;
			}
			if ((object)Net__BackingField != null)
			{
				return Net__BackingField.PaysMe;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public bool HeldLastByMe
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
			if ((UnityEngine.Object)Net__BackingField == (UnityEngine.Object)null)
			{
				return true;
			}
			if ((object)Net__BackingField != null)
			{
				return Net__BackingField.HeldLastByMe;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public bool Lost
	{
		get
		{
			//IL_0016: Expected Obj, but got I4
			//IL_003a: Expected Obj, but got I4
			//IL_005c: Expected I4, but got I8
			//IL_008f: Expected Obj, but got I4
			//IL_0147: Expected I4, but got Obj
			//IL_0126: Invalid comparison between F8 and I4
			bool flag = (byte)(~(Floats__BackingField ? 1u : 0u)) != 0;
			object obj = !flag;
			if (obj == null)
			{
				bool flag2 = (byte)(~(Worn__BackingField ? 1u : 0u)) != 0;
				object obj2 = !flag2;
				if (obj2 == null && (int)(Hand__BackingField & 0x80000000L) != 0)
				{
					bool flag3 = (byte)(~(Swallowed__BackingField ? 1u : 0u)) != 0;
					object obj3 = !flag3;
					if (obj3 == null && ~(Gone__BackingField ? 1u : 0u) != 0)
					{
						Transform transform = base.transform;
						if ((object)transform != null)
						{
							Vector3 position = transform.position;
							double num = (double)bornY + -30.0;
							object obj4 = default;
							double num2 = (double)obj4 - num;
							return num2 < 0.0;
						}
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
				}
			}
			return false;
		}
	}

	public bool Still
	{
		get
		{
			//IL_0014: Expected I4, but got I8
			//IL_0047: Expected Obj, but got I4
			//IL_006b: Expected Obj, but got I4
			//IL_01a7: Expected I4, but got Obj
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Expected Obj, but got Unknown
			if ((int)(Hand__BackingField & 0x80000000L) != 0)
			{
				bool flag = (byte)(~(Swallowed__BackingField ? 1u : 0u)) != 0;
				object obj = !flag;
				if (obj == null)
				{
					bool flag2 = (byte)(~(Gone__BackingField ? 1u : 0u)) != 0;
					object obj2 = !flag2;
					if (obj2 == null && ~(throwWaits ? 1u : 0u) != 0)
					{
						if ((object)Body__BackingField != null)
						{
							if (Body__BackingField.isKinematic)
							{
								return true;
							}
							if ((object)Body__BackingField != null)
							{
								Vector3 linearVelocity = Body__BackingField.linearVelocity;
								object obj4 = default;
								object obj3 = obj4 * obj4;
								object obj6 = default;
								object obj5 = obj6 * obj6;
								object obj7 = obj3 + obj5;
								object obj9 = default;
								object obj8 = obj9 * obj9;
								object obj10 = obj8 + obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
								object obj11 = obj10 - 0;
								return (nint)obj11 < 0;
							}
						}
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
				}
			}
			return false;
		}
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I4
		//IL_036e: Expected Obj, but got I
		//IL_037e: Expected Obj, but got I
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_0802: Expected Obj, but got I4
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected Obj, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I4
		//IL_043c: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I4
		//IL_0306: Expected Obj, but got I
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got Unknown
		//IL_04a2: Expected Obj, but got I
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected Obj, but got Unknown
		//IL_04d7: Expected Obj, but got I
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected Obj, but got Unknown
		//IL_0519: Expected Obj, but got I4
		//IL_052f: Expected Obj, but got I
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected Obj, but got Unknown
		//IL_0572: Expected Obj, but got I
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected Obj, but got Unknown
		//IL_0231: Expected Obj, but got I4
		//IL_05a7: Expected Obj, but got I
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected Obj, but got Unknown
		//IL_05e9: Expected Obj, but got I4
		//IL_05ff: Expected Obj, but got I
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected Obj, but got Unknown
		//IL_02bc: Expected Obj, but got I
		//IL_02cc: Expected Obj, but got I
		//IL_02dc: Expected Obj, but got I
		//IL_02f1: Expected Obj, but got I
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_0294: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I4
		//IL_0642: Expected Obj, but got I
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected Obj, but got Unknown
		//IL_06a1: Expected Obj, but got I8
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected Obj, but got Unknown
		//IL_06b8: Expected Obj, but got I4
		//IL_087c: Expected Obj, but got I4
		//IL_06d7: Expected Obj, but got I
		//IL_06f9: Expected Obj, but got I
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Expected Obj, but got Unknown
		//IL_0758: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B78]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E40]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7458]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj4 = this + 120;
		object obj5 = default;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
		object obj6 = default;
		if (obj6 == null)
		{
			goto IL_079e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v9+18]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v9+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_0340;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1530]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB610]");
		object obj10 = 0;
		object obj12 = default;
		object obj11 = obj12;
		object obj13 = 0;
		UnityEngine.Object obj18 = default;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
			object obj14 = !flag;
			if (obj14 != null)
			{
				break;
			}
			object obj15 = obj6 + obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v30+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
				object obj16 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v31+E4]");
				bool flag2 = (nint)0 == 0;
				object obj17 = !flag2;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag3 = obj18 == null;
				bool flag4 = !flag3;
				obj12 = 0;
				if (flag4)
				{
					goto IL_02f6;
				}
				if (list != null)
				{
					System.__Canon[] items = list._items;
					object obj19 = obj10;
					int version = list._version + 1;
					list._version = version;
					if (list._items != null)
					{
						bool flag5 = list._size < items.Length;
						object obj20 = !flag5;
						if (obj20 == null)
						{
							object obj21 = list._items + list._size;
							int size = list._size + 1;
							list._size = size;
							object obj22 = obj21 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v30+20]");
							obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							obj12 = 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X9_v13+20]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v35+A8]");
							object obj24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v36+70]");
							obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v30+20]");
							list.AddWithResize((System.__Canon)0);
						}
						goto IL_02f6;
					}
				}
			}
			goto IL_079e;
			IL_02f6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v9+18]");
			obj7 = 0;
			obj13++;
			object obj25 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v9+18]");
			bool flag6 = (nint)obj25 < 0;
			obj11 = obj12;
			if (flag6)
			{
				continue;
			}
			goto IL_0340;
		}
		goto IL_07ac;
		IL_079e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_07ac;
		IL_07ac:
		throw new IndexOutOfRangeException();
		IL_0340:
		int num2;
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75C0]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1528]");
			object obj27 = 0;
			System.__Canon[] array = list.ToArray();
			object obj28 = this + 128;
			obj28 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
			object obj29 = this + 144;
			object obj30 = default;
			obj29 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			object obj31 = this + 136;
			object obj32 = default;
			obj31 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
				object obj33 = 0;
				Vector3 position = transform.position;
				float num = default;
				bornY = num;
				float time = Time.time;
				stirred = time;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj34 = default;
				if (obj34 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5A8]");
					object obj35 = 0;
					object obj36 = obj34 + 32;
					obj36 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F18]");
					object obj37 = 0;
					object obj38 = obj34 + 40;
					obj38 = obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X21_v11-10]");
					bool flag7 = (nint)0 < (nint)2;
					object obj39 = !flag7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X21_v11-10]");
					object obj40 = -2;
					bool flag8 = obj40 == null;
					object obj41 = ~obj39;
					object obj42 = obj41 | flag8;
					if (obj42 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F20]");
						object obj43 = 0;
						object obj44 = obj34 + 48;
						obj44 = obj43;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5C0]");
						object obj45 = 0;
						object obj46 = obj34 + 56;
						obj46 = obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X21_v15-20]");
						bool flag9 = (nint)0 < (nint)4;
						object obj47 = !flag9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X21_v15-20]");
						object obj48 = -4;
						bool flag10 = obj48 == null;
						object obj49 = ~obj47;
						object obj50 = obj49 | flag10;
						if (obj50 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5B0]");
							object obj51 = 0;
							object obj52 = obj34 + 64;
							obj52 = obj51;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X21_v17-28]");
							if ((nint)0 < (nint)1)
							{
								num2 = 0;
								goto IL_0839;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X21_v17-28]");
							object obj53 = 0 & 0xFFFFFFFFL;
							object obj54 = obj34 + 32;
							object obj55 = 0;
							num2 = 0;
							while (true)
							{
								bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj55) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj53);
								object obj56 = !flag11;
								if (obj56 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X23_v10+v347 @ X22_v11*8]");
								int num3 = LayerMask.NameToLayer((string)0);
								int num4 = 1 << num3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v35+18]");
								obj53 = 0;
								bool flag12 = num3 < 0;
								int num5 = num3 ^ num3;
								int num6 = num3 & num5;
								bool flag13 = num6 < 0;
								obj55++;
								bool flag14 = flag12 == flag13;
								object obj57 = !flag14;
								object obj58 = ~obj57;
								if (obj58 == null)
								{
									num4 = 0;
								}
								num2 = num4 | num2;
								if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj55) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj53))
								{
									continue;
								}
								goto IL_0839;
							}
						}
					}
					goto IL_07ac;
				}
			}
		}
		goto IL_079e;
		IL_0839:
		LayerMask excludeLayers = num2;
		if (obj4 != null)
		{
			((Rigidbody)obj4).excludeLayers = excludeLayers;
			return;
		}
		goto IL_079e;
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
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
		List<System.__Canon> list = (List<System.__Canon>)obj4;
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
		//IL_0066: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
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
		bool flag2 = ((List<System.__Canon>)obj4).Remove((System.__Canon)(object)this);
	}

	private void Start()
	{
		GillaHands.IgnoreYou(Colliders__BackingField);
	}

	private void Update()
	{
		//IL_0058: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I4
		//IL_0019: Expected I4, but got I8
		//IL_0033: Expected Obj, but got I4
		//IL_02eb: Expected Obj, but got I4
		//IL_03d9: Expected Obj, but got I4
		//IL_0316: Expected I4, but got I8
		//IL_032e: Expected Obj, but got I4
		//IL_07bd: Expected Obj, but got I4
		//IL_048a: Expected Obj, but got I4
		//IL_036e: Expected Obj, but got I4
		//IL_0377: Expected Obj, but got I4
		//IL_040f: Expected Obj, but got I
		//IL_0427: Expected Obj, but got I
		//IL_05be: Expected Obj, but got I4
		//IL_03a7: Expected Obj, but got I4
		//IL_0167: Expected Obj, but got I4
		//IL_0271: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I4
		//IL_062e: Expected Obj, but got I4
		//IL_0572: Expected I4, but got I8
		//IL_051a: Expected Obj, but got I4
		//IL_051f: Expected I, but got Obj
		//IL_01af: Expected Obj, but got I4
		//IL_0666: Invalid comparison between F4 and I
		//IL_0550: Expected I, but got Obj
		//IL_01d1: Expected I4, but got I8
		//IL_0204: Expected Obj, but got I4
		//IL_06ca: Expected Obj, but got I4
		//IL_072e: Expected Obj, but got I4
		float deltaTime = Time.deltaTime;
		float num = knockCool - deltaTime;
		knockCool = num;
		if (~(Floats__BackingField ? 1u : 0u) == 0)
		{
			int num2 = (int)(Hand__BackingField & 0x80000000L);
			bool flag = num2 == 0;
			object obj = !flag;
			if (obj == null)
			{
				goto IL_0041;
			}
			Body__BackingField.isKinematic = true;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag10;
		if ((UnityEngine.Object)Net__BackingField != (UnityEngine.Object)null && Net__BackingField.Live)
		{
			if (Mine)
			{
				Lay();
			}
			if (Mine)
			{
				bool flag3 = (byte)(~(Swallowed__BackingField ? 1u : 0u)) != 0;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					bool flag4 = (byte)(~(Gone__BackingField ? 1u : 0u)) != 0;
					object obj6 = !flag4;
					if (obj6 == null)
					{
						bool flag5 = (byte)(~(throwWaits ? 1u : 0u)) != 0;
						object obj7 = !flag5;
						if (obj7 == null && (int)(Hand__BackingField & 0x80000000L) != 0)
						{
							bool flag6 = (byte)(~(Pinned__BackingField ? 1u : 0u)) != 0;
							object obj8 = !flag6;
							if (obj8 == null && ~(Worn__BackingField ? 1u : 0u) != 0)
							{
								bool flag7 = !Laid__BackingField;
								bool flag8 = !flag7;
								bool flag9 = (object)Body__BackingField == null;
								object obj9 = !flag9;
								flag10 = flag8;
								if (obj9 == null)
								{
									throw new NullReferenceException();
								}
								goto IL_0239;
							}
						}
					}
				}
			}
			flag10 = true;
			goto IL_0239;
		}
		Lay();
		bool flag11 = (byte)(~(Laid__BackingField ? 1u : 0u)) != 0;
		object obj10 = 0;
		bool flag12 = false;
		if (!flag11)
		{
			int num3 = (int)(Hand__BackingField & 0x80000000L);
			bool flag13 = num3 == 0;
			obj10 = 0;
			flag12 = false;
			if (!flag13)
			{
				bool isKinematic = Body__BackingField.isKinematic;
				bool flag14 = !isKinematic;
				object obj11 = !flag14;
				obj10 = 0;
				flag12 = false;
				if (obj11 == null)
				{
					Body__BackingField.isKinematic = true;
					obj10 = 0;
					flag12 = true;
				}
			}
		}
		bool still = Still;
		bool flag15 = !still;
		object obj12 = !flag15;
		if (obj12 == null)
		{
			num = Time.time;
			stirred = num;
		}
		bool flag16 = (byte)(~(Gone__BackingField ? 1u : 0u)) != 0;
		object obj13 = !flag16;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53B0]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v16+A0]");
			object obj16 = 0;
			UnityEngine.Object obj17 = (UnityEngine.Object)obj16;
			if (!Lost)
			{
				object obj18 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v26+E4]");
				bool flag17 = (nint)0 == 0;
				object obj19 = !flag17;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!((UnityEngine.Object)obj16 != null))
				{
					return;
				}
				bool flag18 = ((GillaItemDirector)obj16).Stays(this);
				bool flag19 = !flag18;
				object obj20 = !flag19;
				if (obj20 != null)
				{
					return;
				}
				float time = Time.time;
				float num4 = time - stirred;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X20_v9 (UnityEngine.Object)+40]");
				if (!(num4 > 0f))
				{
					return;
				}
				Transform transform = base.transform;
				Vector3 position = transform.position;
				num = GillaItemDirector.Nearest(position);
				bool flag20 = !((double)num < 8.0);
				obj10 = 0;
				if (!flag20)
				{
					return;
				}
			}
		}
		GameObject obj21 = gameObject;
		object obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v13+E4]");
		bool flag21 = (nint)0 == 0;
		object obj23 = !flag21;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.Destroy(obj21);
		return;
		IL_078d:
		Rigidbody rigidbody;
		RigidbodyInterpolation rigidbodyInterpolation;
		rigidbody.interpolation = rigidbodyInterpolation;
		nint num5 = (nint)rigidbodyInterpolation;
		goto IL_055e;
		IL_055e:
		if ((int)(Hand__BackingField & 0x80000000L) != 0)
		{
			return;
		}
		goto IL_0041;
		IL_0041:
		Hold();
		return;
		IL_0239:
		Body__BackingField.isKinematic = flag10;
		bool mine = Mine;
		bool flag22 = !mine;
		object obj24 = !flag22;
		if (obj24 == null)
		{
			RigidbodyInterpolation interpolation = Body__BackingField.interpolation;
			bool flag23 = interpolation == 0;
			flag10 = false;
			if (!flag23)
			{
				rigidbody = Body__BackingField;
				rigidbodyInterpolation = (RigidbodyInterpolation)0;
				goto IL_078d;
			}
		}
		bool mine2 = Mine;
		bool flag24 = !mine2;
		num5 = (flag10 ? 1 : 0);
		if (!flag24)
		{
			bool isKinematic2 = Body__BackingField.isKinematic;
			bool flag25 = !isKinematic2;
			object obj25 = !flag25;
			num5 = unchecked((nint)null);
			if (obj25 == null)
			{
				RigidbodyInterpolation interpolation2 = Body__BackingField.interpolation;
				bool flag26 = interpolation2 == 0;
				num5 = unchecked((nint)null);
				if (flag26)
				{
					rigidbody = Body__BackingField;
					rigidbodyInterpolation = (RigidbodyInterpolation)1;
					goto IL_078d;
				}
			}
		}
		goto IL_055e;
	}

	private void Lay()
	{
		//IL_0255: Expected Obj, but got I4
		//IL_0019: Expected I4, but got I8
		//IL_004c: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I4
		//IL_0273: Expected Obj, but got I
		//IL_0283: Expected Obj, but got I
		//IL_02a3: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got I4
		//IL_020e: Expected VT, but got I4
		bool flag = (byte)(~(Laid__BackingField ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null || (int)(Hand__BackingField & 0x80000000L) == 0)
		{
			return;
		}
		bool flag2 = (byte)(~(Swallowed__BackingField ? 1u : 0u)) != 0;
		object obj2 = !flag2;
		if (obj2 != null)
		{
			return;
		}
		bool flag3 = (byte)(~(Gone__BackingField ? 1u : 0u)) != 0;
		object obj3 = !flag3;
		if (obj3 != null)
		{
			return;
		}
		bool flag4 = (byte)(~(throwWaits ? 1u : 0u)) != 0;
		object obj4 = !flag4;
		if (obj4 != null)
		{
			return;
		}
		bool flag5 = (byte)(~(Pinned__BackingField ? 1u : 0u)) != 0;
		object obj5 = !flag5;
		if (obj5 != null || ~(Worn__BackingField ? 1u : 0u) == 0)
		{
			return;
		}
		bool isKinematic = Body__BackingField.isKinematic;
		bool flag6 = !isKinematic;
		object obj6 = !flag6;
		object obj7 = 0;
		if (obj6 == null)
		{
			Vector3 linearVelocity = Body__BackingField.linearVelocity;
			object obj9 = default;
			object obj8 = obj9 * obj9;
			object obj11 = default;
			object obj10 = obj11 * obj11;
			object obj12 = obj8 + obj10;
			object obj14 = default;
			object obj13 = obj14 * obj14;
			obj9 = obj13 + obj12;
			object obj15 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			bool flag7 = (nint)obj15 >= 0;
			obj7 = 0;
			if (flag7)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53B0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj17 = 0;
		object obj18 = obj16;
		object obj19 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v17+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v9+E4]");
		bool flag8 = (nint)0 == 0;
		object obj21 = !flag8;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj20 != null)
		{
			Transform transform = base.transform;
			Vector3 position = transform.position;
			if (((GillaItemDirector)obj20).OnSpot((Vector3)0))
			{
				Laid__BackingField = true;
			}
		}
	}

	public void Take(int hand)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Hand__BackingField = hand;
		Laid__BackingField = false;
		throwWaits = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)Net__BackingField != (UnityEngine.Object)null)
		{
			Net__BackingField.TakeOver();
		}
		Hold();
	}

	private void Hold()
	{
		//IL_0034: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_0215: Expected Obj, but got I4
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_024d: Expected Obj, but got I4
		//IL_033a: Expected Obj, but got I4
		//IL_028d: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		Collider[] array = Colliders__BackingField;
		if (Colliders__BackingField == null)
		{
			goto IL_02c4;
		}
		bool flag3;
		if (array.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (array[0] != null)
			{
				Collider[] array2 = Colliders__BackingField;
				if (Colliders__BackingField == null || (object)array2[0] == null)
				{
					goto IL_02c4;
				}
				bool flag2 = array2[0].enabled;
				flag3 = flag2;
				goto IL_0302;
			}
		}
		flag3 = false;
		goto IL_0302;
		IL_02c4:
		NullReferenceException ex = new NullReferenceException();
		goto IL_02d2;
		IL_0302:
		if ((object)Body__BackingField != null)
		{
			bool isKinematic = Body__BackingField.isKinematic;
			object obj4 = !isKinematic;
			object obj5 = flag3 | obj4;
			object obj6 = obj5 & 1;
			if (obj6 == null)
			{
				return;
			}
			if ((object)Body__BackingField != null)
			{
				Body__BackingField.isKinematic = true;
				if ((object)Body__BackingField != null)
				{
					Body__BackingField.interpolation = (RigidbodyInterpolation)0;
					Collider[] array3 = Colliders__BackingField;
					if (Colliders__BackingField != null)
					{
						object obj7 = array3.Length;
						if (array3.Length < 1)
						{
							return;
						}
						object obj8 = Colliders__BackingField + 32;
						object obj9 = 0;
						while (true)
						{
							bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
							object obj10 = !flag4;
							if (obj10 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X21_v5+v112 @ X20_v8*8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X21_v5+v112 @ X20_v8*8]");
								((Collider)0).enabled = false;
								obj7 = array3.Length;
								obj9++;
								if ((nint)obj9 >= array3.Length)
								{
									return;
								}
								continue;
							}
							goto IL_02c4;
						}
						goto IL_02d2;
					}
				}
			}
		}
		goto IL_02c4;
		IL_02d2:
		throw new IndexOutOfRangeException();
	}

	public void Release(Vector3 velocity, Vector3 spin)
	{
		//IL_0019: Expected I4, but got I8
		//IL_0042: Expected Obj, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_01d3: Expected Obj, but got I4
		//IL_0170: Expected VT, but got I4
		//IL_0170: Expected VT, but got I4
		//IL_00ba: Expected Obj, but got I
		//IL_00c4: Expected Obj, but got I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		Collider[] array = Colliders__BackingField;
		Hand__BackingField = -1;
		if (Colliders__BackingField == null)
		{
			goto IL_01a5;
		}
		object obj = array.Length;
		if (array.Length < 1)
		{
			goto IL_00f0;
		}
		object obj2 = Colliders__BackingField + 32;
		object obj3 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj4 = !flag;
			if (obj4 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X22_v7+v66 @ X21_v8*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X22_v7+v66 @ X21_v8*8]");
				((Collider)0).enabled = true;
				obj = array.Length;
				obj3++;
				if ((nint)obj3 < array.Length)
				{
					continue;
				}
				goto IL_00f0;
			}
			goto IL_01a5;
		}
		goto IL_01b3;
		IL_01a5:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01b3;
		IL_01b3:
		throw new IndexOutOfRangeException();
		IL_00f0:
		if (~(Floats__BackingField ? 1u : 0u) == 0)
		{
			if ((object)Body__BackingField != null)
			{
				Body__BackingField.isKinematic = true;
				return;
			}
			goto IL_01a5;
		}
		if (Mine)
		{
			Fly((Vector3)1, (Vector3)0);
			return;
		}
		Vector3 vector = default;
		throwVelocity = vector;
		throwWaits = true;
		Vector3 vector2 = default;
		throwSpin = vector2;
	}

	private void Fly(Vector3 velocity, Vector3 spin)
	{
		//IL_004a: Expected VT, but got I4
		//IL_005f: Expected VT, but got I4
		throwWaits = false;
		Body__BackingField.isKinematic = false;
		Body__BackingField.interpolation = (RigidbodyInterpolation)1;
		Body__BackingField.linearVelocity = (Vector3)0;
		Body__BackingField.angularVelocity = (Vector3)0;
		Body__BackingField.WakeUp();
	}

	public void AuthorityChanged(bool mine)
	{
		//IL_0095: Expected I4, but got I8
		//IL_00af: Expected Obj, but got I4
		//IL_004a: Expected I4, but got I8
		//IL_0075: Expected VT, but got I
		//IL_0075: Expected VT, but got I4
		if (mine)
		{
			if (~(throwWaits ? 1u : 0u) == 0 && (int)(Hand__BackingField & 0x80000000L) != 0)
			{
				IntPtr intPtr = default;
				Fly((Vector3)mine, (Vector3)(nint)intPtr);
			}
			return;
		}
		throwWaits = false;
		int num = (int)(Hand__BackingField & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null && HeldByOther)
		{
			GillaHands.Drop(this);
		}
	}

	public void Swallow(int recycler)
	{
		//IL_025b: Expected I4, but got I8
		//IL_0275: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I4
		//IL_018e: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00f6: Expected Obj, but got I4
		//IL_029c: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got I4
		int num = (int)(Hand__BackingField & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			GillaHands.Drop(this);
		}
		Swallowed__BackingField = true;
		if ((object)Body__BackingField != null)
		{
			Body__BackingField.isKinematic = true;
			if ((object)Body__BackingField != null)
			{
				Body__BackingField.interpolation = (RigidbodyInterpolation)0;
				Collider[] array = Colliders__BackingField;
				if (Colliders__BackingField != null)
				{
					object obj2 = array.Length;
					bool flag2 = array.Length < 1;
					object obj3 = 0;
					bool flag3 = false;
					if (flag2)
					{
						goto IL_017e;
					}
					object obj4 = Colliders__BackingField + 32;
					object obj5 = 0;
					while (true)
					{
						bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
						object obj6 = !flag4;
						if (obj6 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X23_v6+v56 @ X22_v7*8]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X23_v6+v56 @ X22_v7*8]");
							((Collider)0).enabled = false;
							obj2 = array.Length;
							obj5++;
							bool flag5 = (nint)obj5 < array.Length;
							obj3 = 0;
							flag3 = false;
							if (flag5)
							{
								continue;
							}
							goto IL_017e;
						}
						goto IL_0232;
					}
					goto IL_0240;
				}
			}
		}
		goto IL_0232;
		IL_0232:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0240;
		IL_017e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v10+E4]");
		bool flag6 = (nint)0 == 0;
		object obj9 = !flag6;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)Net__BackingField != (UnityEngine.Object)null)
		{
			if ((object)Net__BackingField != null)
			{
				Net__BackingField.Swallowed(recycler);
				return;
			}
			goto IL_0232;
		}
		return;
		IL_0240:
		throw new IndexOutOfRangeException();
	}

	public void Recycle()
	{
		//IL_003e: Expected Obj, but got I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		Renderer[] array = renderers;
		Swallowed__BackingField = false;
		if (renderers == null)
		{
			goto IL_00ed;
		}
		object obj = array.Length;
		if (array.Length < 1)
		{
			return;
		}
		object obj2 = renderers + 32;
		object obj3 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj4 = !flag;
			if (obj4 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X21_v5+v35 @ X20_v6*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X21_v5+v35 @ X20_v6*8]");
				((Renderer)0).enabled = false;
				obj = array.Length;
				obj3++;
				if ((nint)obj3 >= array.Length)
				{
					return;
				}
				continue;
			}
			goto IL_00ed;
		}
		goto IL_00fb;
		IL_00ed:
		NullReferenceException ex = new NullReferenceException();
		goto IL_00fb;
		IL_00fb:
		throw new IndexOutOfRangeException();
	}

	public void ShowSwallowed()
	{
		//IL_0014: Expected I4, but got I8
		//IL_002e: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I4
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		int num = (int)(Hand__BackingField & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			GillaHands.Drop(this);
		}
		Collider[] array = Colliders__BackingField;
		Swallowed__BackingField = true;
		if (Colliders__BackingField == null)
		{
			goto IL_0134;
		}
		object obj2 = array.Length;
		if (array.Length < 1)
		{
			return;
		}
		object obj3 = Colliders__BackingField + 32;
		object obj4 = 0;
		while (true)
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
			object obj5 = !flag2;
			if (obj5 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v5+v71 @ X19_v7*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v5+v71 @ X19_v7*8]");
				((Collider)0).enabled = false;
				obj2 = array.Length;
				obj4++;
				if ((nint)obj4 >= array.Length)
				{
					return;
				}
				continue;
			}
			goto IL_0134;
		}
		goto IL_0142;
		IL_0142:
		throw new IndexOutOfRangeException();
		IL_0134:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0142;
	}

	public void ShowGone()
	{
		//IL_003e: Expected Obj, but got I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I4
		//IL_01fc: Expected Obj, but got I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_0197: Expected Obj, but got I
		//IL_01a1: Expected Obj, but got I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		Renderer[] array = renderers;
		Swallowed__BackingField = false;
		if (renderers == null)
		{
			goto IL_01ce;
		}
		object obj = array.Length;
		if (array.Length < 1)
		{
			goto IL_00ec;
		}
		object obj2 = renderers + 32;
		object obj3 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj4 = !flag;
			if (obj4 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X22_v5+v45 @ X21_v8*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X22_v5+v45 @ X21_v8*8]");
				((Renderer)0).enabled = false;
				obj = array.Length;
				obj3++;
				if ((nint)obj3 < array.Length)
				{
					continue;
				}
				goto IL_00ec;
			}
			goto IL_01ce;
		}
		goto IL_01dc;
		IL_01ce:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01dc;
		IL_01dc:
		throw new IndexOutOfRangeException();
		IL_00ec:
		Collider[] array2 = Colliders__BackingField;
		if (Colliders__BackingField == null)
		{
			goto IL_01ce;
		}
		object obj5 = array2.Length;
		if (array2.Length < 1)
		{
			return;
		}
		object obj6 = Colliders__BackingField + 32;
		object obj7 = 0;
		while (true)
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
			object obj8 = !flag2;
			if (obj8 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v6+v104 @ X20_v7*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v6+v104 @ X20_v7*8]");
				((Collider)0).enabled = false;
				obj5 = array2.Length;
				obj7++;
				if ((nint)obj7 >= array2.Length)
				{
					return;
				}
				continue;
			}
			goto IL_01ce;
		}
		goto IL_01dc;
	}

	private void OnCollisionEnter(Collision hit)
	{
		//IL_0062: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I4
		//IL_0051: Expected VT, but got I4
		ContactPoint contact = hit.GetContact(0);
		Vector3 relativeVelocity = hit.relativeVelocity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float speed = default;
		Knock((Vector3)0, speed);
	}

	public void HeldKnock(Vector3 at, Vector3 faces, float speed, Collider on)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		Action<Vector3, Vector3, float, Collider> knocked = Knocked;
		if (Knocked != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`4<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Collider>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`4<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Collider>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`4<UnityEngine.Vector3, UnityEngine.Vector3, System.Single, UnityEngine.Collider>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X3_v1 (should have been resolved before IL gen)");
		}
		Knock(at, speed);
	}

	public void Knock(Vector3 at, float speed)
	{
		//IL_0010: Invalid comparison between F4 and I4
		//IL_009b: Invalid comparison between F8 and I
		//IL_014a: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I4
		//IL_0114: Expected VT, but got I4
		//IL_00c7: Expected F4, but got I
		//IL_00d7: Invalid comparison between F8 and I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		object obj = default;
		if ((nint)obj < 0 || knockCool > 0f)
		{
			return;
		}
		AudioClip[] array = knocks;
		if (knocks == null || array.Length == 0)
		{
			return;
		}
		double num = (double)obj / 5.0;
		knockCool = 0.12f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		bool flag = num < 0.0;
		float num3 = default;
		float num2 = num3;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			num2 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			if (num > 0.0)
			{
				goto IL_00e9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			goto IL_00e9;
		}
		goto IL_00f8;
		IL_00f8:
		float pitchMax = default;
		Sfx.Play(knocks, (Vector3)0, speed, num3, pitchMax);
		return;
		IL_00e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_00f8;
	}

	public void Hush(float seconds)
	{
		//IL_001a: Invalid comparison between F4 and I4
		//IL_0029: Invalid comparison between F4 and I4
		//IL_003e: Expected Obj, but got F4
		//IL_004d: Expected Obj, but got F4
		//IL_0082: Expected Obj, but got I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		float num2 = default;
		float num = knockCool - num2;
		bool flag = num < 0f;
		bool flag2 = num == 0f;
		object obj = knockCool ^ num2;
		object obj2 = knockCool ^ num;
		object obj3 = obj & obj2;
		bool flag3 = (nint)obj3 < 0;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag4 & obj4;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
		}
		knockCool = knockCool;
	}

	public GillaItem()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0063: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_0085: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1548]");
		object obj = 0;
		object obj2 = this + 32;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 5;
		_ = 4294967295L;
		_ = 1;
		_ = 1065353216;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v8+A0]");
		InHandTurn__BackingField = (Quaternion)(object)0;
		base._002Ector();
	}

	static GillaItem()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = list;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
