using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using GorillaLocomotion;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.XR;

public class GillaHands : MonoBehaviour
{
	[Serializable]
	public class Piece
	{
		public string bone;

		public GoreSection section;

		public Mesh mesh;

		public Material material;

		public float gone;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<HandPoser, bool> _003C_003E9__29_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1130]");
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

		internal bool _003CStart_003Eb__29_0(HandPoser p)
		{
			//IL_0044: Expected I4, but got Obj
			if ((object)p != null)
			{
				return !p.remote;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public float reach;

	public float throwBoost;

	public AudioClip[] pickUps;

	public AudioClip[] putDowns;

	public static Func<GillaItem, Vector3, Vector3, bool> LettingGo;

	public static Func<int, Vector3, GillaItem> Reaching;

	private static GillaHands you;

	private const int Mouse = default(int);

	private const int Trail = default(int);

	private const float SettleRate = default(float);

	private const float GripTake = default(float);

	private const float GripLetGo = default(float);

	private readonly GillaItem[] holding;

	private readonly Vector3[] heldAt;

	private readonly Vector3[] settling;

	private readonly Quaternion[] heldTurn;

	private readonly HeldShape[] shapes;

	private readonly bool[] knocking;

	private readonly bool[] was;

	private readonly bool[] testHeld;

	private readonly Vector3[,] trailAt;

	private readonly Quaternion[,] trailTurn;

	private readonly float[] trailTime;

	private int head;

	private int frames;

	private Player gt;

	private Collider[] rig;

	private HandPoser[] posers;

	private const int MostBalls = default(int);

	private const float LeastBall = default(float);

	private const float MostBall = default(float);

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CE0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DD8]");
		object obj3 = 0;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+A0]");
		object obj5 = (nint)0 + (nint)16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj6 = this + 152;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
		object obj8 = this + 160;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I4
		//IL_0058: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_009f: Expected Obj, but got I4
		//IL_01de: Expected Obj, but got I
		//IL_01f8: Expected Obj, but got I
		//IL_0209: Expected I, but got Obj
		//IL_0227: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1120]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1130]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD798");
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v5+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1110]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X9_v4+8]");
		Func<System.__Canon, bool> predicate = (Func<System.__Canon, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X9_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v5+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v13+A0]");
				obj8 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1118]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1128]");
			object obj14 = 0;
			Func<System.__Canon, bool> func = default;
			func._002Ector(obj8, (IntPtr)obj14);
			object obj15 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v12+A0]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			predicate = func;
		}
		IEnumerable<System.__Canon> source2 = default;
		IEnumerable<System.__Canon> source = Enumerable.Where(source2, predicate);
		System.__Canon[] array = Enumerable.ToArray(source);
		object obj17 = this + 168;
		obj17 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+10]");
		if ((UnityEngine.Object)0 == this)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v5+A0]");
			object obj8 = (nint)0 + (nint)16;
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static void IgnoreYou(Collider[] colliders)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_03e3: Expected Obj, but got I
		//IL_03f3: Expected Obj, but got I
		//IL_0403: Expected Obj, but got I
		//IL_0425: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I8
		//IL_00ad: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I4
		//IL_0473: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I
		//IL_0381: Expected Obj, but got I4
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got I8
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0175: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I4
		//IL_044c: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I4
		//IL_0200: Expected Obj, but got I4
		//IL_032d: Expected Obj, but got I
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		//IL_023d: Expected Obj, but got I4
		//IL_026c: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I4
		//IL_02c5: Expected Obj, but got I4
		//IL_02f7: Expected Obj, but got I
		//IL_0300: Expected Obj, but got I4
		//IL_0310: Expected Obj, but got I
		//IL_0318: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+10]");
		UnityEngine.Object obj7 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = obj7 == null;
		bool flag3 = !flag2;
		object obj9 = !flag3;
		if (obj9 != null || colliders.Length < 1)
		{
			return;
		}
		object obj10 = colliders.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj11 = 0;
		object obj12 = 0;
		object obj13 = 0;
		UnityEngine.Object obj14 = null;
		while (true)
		{
			bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
			object obj15 = !flag4;
			if (obj15 != null)
			{
				break;
			}
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v11+A0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v12+10]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v13+A0]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X26_v6+18]");
			if ((nint)0 >= (nint)1)
			{
				obj6 = (object)colliders + obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X26_v6+18]");
				object obj20 = 0 & 0xFFFFFFFFL;
				object obj21 = obj19 + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v6+20]");
				obj7 = (UnityEngine.Object)0;
				object obj22 = 0;
				object obj23 = obj13;
				UnityEngine.Object obj24 = obj14;
				while (true)
				{
					bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20);
					object obj25 = !flag5;
					if (obj25 != null)
					{
						break;
					}
					object obj26 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v14+E4]");
					bool flag6 = (nint)0 == 0;
					object obj27 = !flag6;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					flag2 = obj7 != null;
					bool flag7 = !flag2;
					obj13 = 0;
					obj14 = null;
					if (!flag7)
					{
						object obj28 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v19+E4]");
						bool flag8 = (nint)0 == 0;
						object obj29 = !flag8;
						if (obj29 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X28_v6+v262 @ X27_v8*8]");
						flag2 = (UnityEngine.Object)0 != null;
						bool flag9 = !flag2;
						obj13 = 0;
						obj14 = null;
						if (!flag9)
						{
							object obj30 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v23+E4]");
							bool flag10 = (nint)0 == 0;
							object obj31 = !flag10;
							if (obj31 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							UnityEngine.Object collider = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X28_v6+v262 @ X27_v8*8]");
							Physics.IgnoreCollision((Collider)collider, (Collider)0);
							obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X28_v6+v262 @ X27_v8*8]");
							obj14 = (UnityEngine.Object)0;
							flag2 = (byte)(int)obj7 != 0;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X26_v6+18]");
					obj20 = 0;
					object obj32 = obj22 + 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X26_v6+18]");
					bool flag11 = (nint)obj32 < 0;
					obj22 = obj32;
					obj23 = obj13;
					obj24 = obj14;
					if (flag11)
					{
						continue;
					}
					goto IL_0377;
				}
				break;
			}
			goto IL_0377;
			IL_0377:
			obj10 = colliders.Length;
			obj12++;
			if ((nint)obj12 >= colliders.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public static void Drop(GillaItem item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0266: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I
		//IL_01fd: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+10]");
		bool flag2 = (UnityEngine.Object)0 == null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			return;
		}
		bool flag4 = false;
		UnityEngine.Object obj8 = null;
		int num = 0;
		while (true)
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v7+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v8+10]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v8+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v9+38]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v9+38]");
				if ((nint)0 != 0)
				{
					int num2 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v12+18]");
					bool flag5 = (nint)num2 < (nint)0;
					object obj13 = !flag5;
					if (obj13 != null)
					{
						break;
					}
					object obj14 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v9+38]");
					object obj15 = (nint)0 + (nint)num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v12+E4]");
					bool flag6 = (nint)0 == 0;
					object obj16 = !flag6;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v13+20]");
					bool flag7 = (UnityEngine.Object)0 == item;
					bool flag8 = !flag7;
					flag4 = false;
					obj8 = item;
					if (!flag8)
					{
						object obj17 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v15+A0]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v16+10]");
						if ((nint)0 == 0)
						{
							goto IL_0231;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v16+10]");
						((GillaHands)0).LetGo(num, thrown: false);
						flag4 = false;
						obj8 = (UnityEngine.Object)num;
					}
					num++;
					if (num == 3)
					{
						return;
					}
					continue;
				}
			}
			goto IL_0231;
			IL_0231:
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		throw new IndexOutOfRangeException();
	}

	public static GillaItem Holding(int hand)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_01bd: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I4
		//IL_0124: Expected Obj, but got I
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_016c: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+10]");
		bool flag2 = (UnityEngine.Object)0 != null;
		bool flag3 = !flag2;
		GillaItem result = null;
		if (!flag3)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v7+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v8+10]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v8+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v9+38]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v9+38]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v12+18]");
					bool flag4 = (nint)0 < (nint)hand;
					object obj11 = !flag4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v12+18]");
					object obj12 = -hand;
					bool flag5 = obj12 == null;
					object obj13 = ~obj11;
					object obj14 = obj13 | flag5;
					if (obj14 != null)
					{
						goto IL_018f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v9+38]");
					object obj15 = (nint)0 + (nint)hand;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v13+20]");
					result = (GillaItem)0;
					goto IL_01ed;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_018f;
		}
		goto IL_01ed;
		IL_018f:
		return (GillaItem)(object)new IndexOutOfRangeException();
		IL_01ed:
		return result;
	}

	public static Vector3 HandPoint(int hand)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I
		//IL_0134: Expected VT, but got I4
		//IL_007f: Expected Obj, but got I
		//IL_00d5: Expected VT, but got Obj
		//IL_00b9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+10]");
		bool flag2 = (UnityEngine.Object)0 != null;
		if (flag2)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v12+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v13+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v13+10]");
				return ((GillaHands)0).Point(hand);
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		return (Vector3)flag2;
	}

	public static bool Reaches(int hand)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_02f1: Expected Obj, but got I
		//IL_0313: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_02d1: Expected I4, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_016f: Expected Obj, but got I
		//IL_0191: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I
		//IL_024c: Expected VT, but got I4
		//IL_024c: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+10]");
		if (!((UnityEngine.Object)0 != null))
		{
			goto IL_02af;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v7+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v7+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v8+38]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v8+38]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v11+18]");
				bool flag2 = (nint)0 < (nint)hand;
				object obj11 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v11+18]");
				object obj12 = -hand;
				bool flag3 = obj12 == null;
				object obj13 = ~obj11;
				object obj14 = obj13 | flag3;
				if (obj14 != null)
				{
					goto IL_02c3;
				}
				object obj15 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v8+38]");
				object obj16 = (nint)0 + (nint)hand;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v12+E4]");
				bool flag4 = (nint)0 == 0;
				object obj17 = !flag4;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v12+20]");
				if (!((UnityEngine.Object)0 == null))
				{
					goto IL_02af;
				}
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v13+A0]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v14+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v14+10]");
					Vector3 vector = ((GillaHands)0).Point(hand);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v14+10]");
					GillaItem gillaItem = ((GillaHands)0).Nearest((Vector3)hand);
					object obj20 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v15+E4]");
					bool flag5 = (nint)0 == 0;
					object obj21 = !flag5;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return gillaItem != null;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_02c3;
		IL_02af:
		return false;
		IL_02c3:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	public static void TakeForTest(int hand, GillaItem item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_01a3: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I4
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_0216: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+10]");
		if ((UnityEngine.Object)0 == null)
		{
			return;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v5+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6+10]");
		GillaHands gillaHands = (GillaHands)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6+10]");
		if ((nint)0 != 0)
		{
			bool[] array = gillaHands.testHeld;
			if (gillaHands.testHeld != null)
			{
				bool flag2 = array.Length < hand;
				object obj9 = !flag2;
				object obj10 = array.Length - hand;
				bool flag3 = obj10 == null;
				object obj11 = ~obj9;
				object obj12 = obj11 | flag3;
				if (obj12 == null)
				{
					bool[] array2 = gillaHands.was;
					object obj13 = gillaHands.testHeld + hand;
					_ = 1;
					if (gillaHands.was == null)
					{
						goto IL_0217;
					}
					bool flag4 = array2.Length < hand;
					object obj14 = !flag4;
					object obj15 = array2.Length - hand;
					bool flag5 = obj15 == null;
					object obj16 = ~obj14;
					object obj17 = obj16 | flag5;
					if (obj17 == null)
					{
						object obj18 = gillaHands.was + hand;
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6+10]");
						((GillaHands)0).Take(hand, item);
						return;
					}
				}
				goto IL_0225;
			}
		}
		goto IL_0217;
		IL_0225:
		throw new IndexOutOfRangeException();
		IL_0217:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0225;
	}

	public static void ThrowForTest(int hand, Vector3 velocity)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0400: Expected Obj, but got I
		//IL_0422: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_016d: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0233: Expected Obj, but got I
		//IL_0255: Expected Obj, but got I4
		//IL_0284: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I
		//IL_02ce: Expected Obj, but got I
		//IL_033d: Expected Obj, but got I4
		//IL_034c: Expected Obj, but got I4
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_03ab: Expected Obj, but got I
		//IL_03ca: Expected VT, but got I4
		//IL_03ca: Expected VT, but got I4
		//IL_03ca: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+10]");
		bool flag2 = (UnityEngine.Object)0 == null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v6+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v7+10]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v7+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v8+70]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v8+70]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X9_v5+18]");
				bool flag4 = (nint)0 < (nint)hand;
				object obj12 = !flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X9_v5+18]");
				object obj13 = -hand;
				bool flag5 = obj13 == null;
				object obj14 = ~obj12;
				object obj15 = obj14 | flag5;
				if (obj15 != null)
				{
					goto IL_03d9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v8+38]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v8+70]");
				object obj17 = (nint)0 + (nint)hand;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v8+38]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v11+18]");
					bool flag6 = (nint)0 < (nint)hand;
					object obj18 = !flag6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v11+18]");
					object obj19 = -hand;
					bool flag7 = obj19 == null;
					object obj20 = ~obj18;
					object obj21 = obj20 | flag7;
					if (obj21 != null)
					{
						goto IL_03d9;
					}
					object obj22 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v8+38]");
					object obj23 = (nint)0 + (nint)hand;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v11+E4]");
					bool flag8 = (nint)0 == 0;
					object obj24 = !flag8;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v12+20]");
					if ((UnityEngine.Object)0 == null)
					{
						return;
					}
					object obj25 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v13+A0]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v14+10]");
					GillaHands gillaHands = (GillaHands)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v14+10]");
					if ((nint)0 != 0)
					{
						GillaItem[] array = gillaHands.holding;
						if (gillaHands.holding != null)
						{
							bool flag9 = array.Length < hand;
							object obj27 = !flag9;
							object obj28 = array.Length - hand;
							bool flag10 = obj28 == null;
							object obj29 = ~obj27;
							object obj30 = obj29 | flag10;
							if (obj30 != null)
							{
								goto IL_03d9;
							}
							object obj31 = gillaHands.holding + hand;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v14+10]");
							((GillaHands)0).LetGo(hand, thrown: false);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v16+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v16+20]");
								((GillaItem)0).Release((Vector3)hand, (Vector3)0);
								return;
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_03d9;
		IL_03d9:
		throw new IndexOutOfRangeException();
	}

	public static void GripForTest(int hand, bool closed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_00c4: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+10]");
		if (!((UnityEngine.Object)0 != null))
		{
			return;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v7+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v7+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v8+70]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v8+70]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v11+18]");
				bool flag2 = (nint)0 < (nint)hand;
				object obj11 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v11+18]");
				object obj12 = -hand;
				bool flag3 = obj12 == null;
				object obj13 = ~obj11;
				object obj14 = obj13 | flag3;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v8+70]");
					object obj15 = (nint)0 + (nint)hand;
					return;
				}
				goto IL_017f;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_017f;
		IL_017f:
		throw new IndexOutOfRangeException();
	}

	private unsafe void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_14ce: Expected Obj, but got I
		//IL_14f0: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I
		//IL_150e: Expected Obj, but got I
		//IL_15ec: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I4
		//IL_0191: Expected Obj, but got I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01d8: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I
		//IL_0218: Expected Obj, but got I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected I4, but got Unknown
		//IL_0256: Expected Obj, but got I4
		//IL_0314: Expected Obj, but got I4
		//IL_034c: Expected Obj, but got I4
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_02a8: Expected Obj, but got I4
		//IL_0729: Expected Obj, but got I4
		//IL_03c3: Expected Obj, but got I4
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_0529: Expected Obj, but got I4
		//IL_046f: Expected Obj, but got I4
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected Obj, but got Unknown
		//IL_0770: Expected Obj, but got I4
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_03f1: Expected Obj, but got I
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_041d: Expected Obj, but got I4
		//IL_079f: Expected Obj, but got I
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected Obj, but got Unknown
		//IL_0568: Expected Obj, but got I4
		//IL_06b7: Expected Obj, but got I4
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Expected Obj, but got Unknown
		//IL_0846: Expected Obj, but got I4
		//IL_08ef: Expected Obj, but got I4
		//IL_05c3: Expected Obj, but got I4
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected Obj, but got Unknown
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Expected Obj, but got Unknown
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_0928: Expected Obj, but got Unknown
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected Obj, but got Unknown
		//IL_060a: Expected Obj, but got I4
		//IL_158e: Expected Obj, but got I
		//IL_15a6: Expected Obj, but got I
		//IL_15b6: Expected Obj, but got I
		//IL_08a1: Expected Obj, but got Ref
		//IL_0639: Expected Obj, but got I
		//IL_064a: Expected Obj, but got I4
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected Obj, but got Unknown
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected Obj, but got Unknown
		//IL_155a: Expected Obj, but got I
		//IL_1568: Expected VT, but got I4
		//IL_1571: Expected F4, but got I4
		//IL_0962: Expected Obj, but got I
		//IL_097a: Expected Obj, but got I
		//IL_098a: Expected Obj, but got I
		//IL_0c63: Expected Obj, but got I4
		//IL_0c6c: Expected Obj, but got I4
		//IL_0c75: Expected Obj, but got I4
		//IL_162d: Expected Obj, but got I4
		//IL_1665: Expected Obj, but got I4
		//IL_0ca6: Expected Obj, but got I4
		//IL_0a5f: Expected Obj, but got I4
		//IL_169d: Expected Obj, but got I4
		//IL_0ccc: Expected Obj, but got I
		//IL_0cee: Expected Obj, but got I4
		//IL_0b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b28: Expected Obj, but got Unknown
		//IL_0b31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b36: Expected Obj, but got Unknown
		//IL_0ae0: Expected VT, but got I4
		//IL_0d1d: Expected Obj, but got I
		//IL_0be4: Expected Obj, but got I4
		//IL_0b74: Expected VT, but got I4
		//IL_0d60: Expected Obj, but got I4
		//IL_0ddc: Expected Obj, but got I4
		//IL_0c4b: Expected I4, but got Obj
		//IL_0e53: Expected Obj, but got I4
		//IL_0ec7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecc: Expected Obj, but got Unknown
		//IL_0ee3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee8: Expected Obj, but got Unknown
		//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef6: Expected Obj, but got Unknown
		//IL_0f34: Expected Obj, but got I
		//IL_0ea8: Expected F4, but got I4
		//IL_0fdc: Expected Obj, but got I4
		//IL_1067: Expected Obj, but got I
		//IL_10c2: Expected Obj, but got I4
		//IL_10de: Expected VT, but got I4
		//IL_10de: Expected VT, but got I4
		//IL_1126: Expected Obj, but got I4
		//IL_1178: Expected Obj, but got I4
		//IL_1256: Unknown result type (might be due to invalid IL or missing references)
		//IL_125b: Expected Obj, but got Unknown
		//IL_126b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1270: Expected Obj, but got Unknown
		//IL_12c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ca: Expected Obj, but got Unknown
		//IL_12e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ee: Expected Obj, but got Unknown
		//IL_1333: Unknown result type (might be due to invalid IL or missing references)
		//IL_1338: Expected Obj, but got Unknown
		//IL_1357: Unknown result type (might be due to invalid IL or missing references)
		//IL_135c: Expected Obj, but got Unknown
		//IL_136c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1371: Expected Obj, but got Unknown
		//IL_1381: Unknown result type (might be due to invalid IL or missing references)
		//IL_1386: Expected Obj, but got Unknown
		//IL_13d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d7: Expected Obj, but got Unknown
		//IL_1414: Unknown result type (might be due to invalid IL or missing references)
		//IL_1419: Expected Obj, but got Unknown
		//IL_144a: Expected VT, but got I4
		//IL_144a: Expected VT, but got I4
		//IL_145f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10;
		bool flag2;
		if ((UnityEngine.Object)obj5 != null)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v76+A0]");
			object obj8 = 0;
			object obj9 = obj8;
			if (obj8 == null)
			{
				goto IL_1499;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v78+A9]");
			if ((nint)0 != 0)
			{
				obj10 = 0;
				flag2 = false;
				goto IL_14fe;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v122+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isMonster = MonsterPlayer.IsMonster;
		obj10 = (isMonster ? 1 : 0) ^ 1;
		flag2 = true;
		goto IL_14fe;
		IL_14a7:
		throw new IndexOutOfRangeException();
		IL_14fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE890]");
		object obj14 = 0;
		Record();
		bool flag4 = false;
		int num = 0;
		float num2 = default;
		float num4 = default;
		object obj44 = default;
		object obj49 = default;
		object obj55 = default;
		UnityEngine.Object obj97 = default;
		object obj116 = default;
		while (true)
		{
			bool flag5 = GillaToys.HeldIn(num);
			GillaItem[] array = holding;
			bool flag6 = num == 0;
			object obj15 = !flag6;
			object obj16 = ~obj15;
			XRNode node = ((obj16 != null) ? ((XRNode)4) : ((XRNode)5));
			if (holding == null)
			{
				break;
			}
			bool flag7 = num < array.Length;
			object obj17 = !flag7;
			Transform transform;
			Transform transform2;
			bool flag15;
			bool flag10;
			if (obj17 == null)
			{
				object obj18 = obj2;
				object obj19 = holding + num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v11+E4]");
				bool flag8 = (nint)0 == 0;
				object obj20 = !flag8;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X8_v8+20]");
				bool flag9 = (UnityEngine.Object)0 != null;
				object obj21 = flag5 | flag9;
				flag10 = (byte)(obj21 & 1) != 0;
				bool flag11 = Grip(node, flag10);
				bool flag12 = !flag11;
				object obj22 = !flag12;
				if (obj22 == null)
				{
					bool[] array2 = testHeld;
					if (testHeld == null)
					{
						break;
					}
					bool flag13 = num < array2.Length;
					object obj23 = !flag13;
					if (obj23 != null)
					{
						goto IL_14a7;
					}
					object obj24 = testHeld + num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v68+20]");
					if ((nint)0 == 0)
					{
						bool flag14 = !flag2;
						object obj25 = !flag14;
						transform = null;
						transform2 = null;
						flag15 = flag10;
						if (obj25 != null)
						{
							goto IL_037f;
						}
						goto IL_048f;
					}
				}
				object obj26 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X0_v112+E4]");
				bool flag16 = (nint)0 == 0;
				object obj27 = !flag16;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag17 = GillaOneArm.Resting(num);
				transform = (Transform)((flag17 ? 1 : 0) ^ 1);
				bool flag18 = !flag2;
				flag10 = false;
				transform2 = transform;
				flag15 = false;
				if (!flag18)
				{
					goto IL_037f;
				}
				goto IL_048f;
			}
			goto IL_14a7;
			IL_06e5:
			GillaItem[] array3 = holding;
			if (holding == null)
			{
				break;
			}
			bool flag19 = num < array3.Length;
			object obj28 = !flag19;
			bool flag23;
			if (obj28 == null)
			{
				object obj29 = obj2;
				object obj30 = holding + num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X0_v56+E4]");
				bool flag20 = (nint)0 == 0;
				object obj31 = !flag20;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X8_v40+20]");
				bool flag21 = (UnityEngine.Object)0 != null;
				bool flag22 = !flag21;
				transform2 = transform;
				flag4 = false;
				if (flag22)
				{
					goto IL_07f4;
				}
				LetGo(num, flag23);
				transform2 = transform;
				flag4 = flag23;
				goto IL_08ab;
			}
			goto IL_14a7;
			IL_16ab:
			Fingers(num, num2);
			goto IL_08ab;
			IL_08ab:
			bool[] array4 = was;
			if (was == null)
			{
				break;
			}
			bool flag24 = num < array4.Length;
			object obj32 = !flag24;
			if (obj32 == null)
			{
				object obj33 = was + num;
				num++;
				object obj34 = transform2 & 1;
				if (num != 2)
				{
					continue;
				}
				MouseHands(flag2);
				object obj35 = 32;
				object obj36 = 0;
				object obj37 = 32;
				bool flag25 = flag2;
				int num3 = 0;
				while (true)
				{
					GillaItem[] array5 = holding;
					if (holding == null)
					{
						break;
					}
					bool flag26 = num3 < array5.Length;
					object obj38 = !flag26;
					object obj43;
					if (obj38 == null)
					{
						object obj39 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v15 (GillaItem[])+v218 @ X25_v6]");
						UnityEngine.Object obj40 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X0_v22+E4]");
						bool flag27 = (nint)0 == 0;
						object obj41 = !flag27;
						if (obj41 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v15 (GillaItem[])+v218 @ X25_v6]");
						if ((UnityEngine.Object)0 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v15 (GillaItem[])+v218 @ X25_v6]");
							bool flag28 = (nint)0 == 0;
							object obj42 = !flag28;
							if (obj42 == null)
							{
								num4 = num4;
								obj43 = obj44;
								flag4 = false;
								flag25 = false;
								goto IL_0ebe;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v15 (GillaItem[])+v218 @ X25_v6]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X21_v7 (UnityEngine.Object)+41]");
							bool flag29 = (nint)0 == 0;
							object obj45 = !flag29;
							if (obj45 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X21_v7 (UnityEngine.Object)+40]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v15 (GillaItem[])+v218 @ X25_v6]");
									if (((GillaItem)0).HeldByOther)
									{
										LetGo(num3, thrown: false);
										num4 = num4;
										obj43 = obj44;
										flag4 = false;
										flag25 = (byte)num3 != 0;
										goto IL_0ebe;
									}
									Quaternion quaternion = Turn(num3);
									Vector3[] array6 = settling;
									if (settling == null)
									{
										break;
									}
									bool flag30 = num3 < array6.Length;
									object obj46 = !flag30;
									if (obj46 == null)
									{
										object obj47 = (object)settling + obj37;
										float deltaTime = Time.deltaTime;
										float num5 = deltaTime * -28f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
										object obj48 = obj47 * obj49;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1124 @ X22_v7+8]");
										float num6 = 0f * num5;
										obj47 = obj48;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v15 (GillaItem[])+v218 @ X25_v6]");
										Transform transform3 = ((Component)0).transform;
										Vector3 vector = Point(num3);
										Vector3[] array7 = heldAt;
										if (heldAt == null)
										{
											break;
										}
										bool flag31 = num3 < array7.Length;
										object obj50 = !flag31;
										if (obj50 == null)
										{
											Vector3 vector2 = (Quaternion)0 * (Vector3)num3;
											Vector3[] array8 = settling;
											if (settling == null)
											{
												break;
											}
											bool flag32 = num3 < array8.Length;
											object obj51 = !flag32;
											if (obj51 == null)
											{
												Quaternion[] array9 = heldTurn;
												if (heldTurn == null)
												{
													break;
												}
												bool flag33 = num3 < array9.Length;
												object obj52 = !flag33;
												if (obj52 == null)
												{
													if ((object)transform3 == null)
													{
														break;
													}
													object obj53 = (object)heldTurn + obj36;
													float num7 = num6 + num2;
													object obj54 = obj48 + obj55;
													object obj56 = obj44 + obj44;
													object obj57 = (object)settling + obj37;
													float num8 = num2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X9_v18+20]");
													float num9 = num8 * 0f;
													float num10 = num4;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X9_v18+24]");
													float num11 = num10 * 0f;
													float num12 = num4;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X9_v18+2C]");
													float num13 = num12 * 0f;
													float num14 = num4;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X9_v18+28]");
													float num15 = num14 * 0f;
													object obj58 = obj44;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X9_v18+2C]");
													object obj59 = obj58 * 0;
													object obj60 = obj55;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X9_v18+2C]");
													object obj61 = obj60 * 0;
													float num16 = num4;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X9_v18+20]");
													float num17 = num16 * 0f;
													float num18 = num2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X9_v18+2C]");
													float num19 = num18 * 0f;
													float num20 = num2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X9_v18+28]");
													float num21 = num20 * 0f;
													object obj62 = obj44;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X9_v18+24]");
													object obj63 = obj62 * 0;
													float num22 = num13 - num9;
													object obj64 = obj55;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X9_v18+24]");
													object obj65 = obj64 * 0;
													float num23 = (float)obj59 + num15;
													float num24 = num2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X9_v18+24]");
													float num25 = num24 * 0f;
													float num26 = (float)obj61 + num11;
													object obj66 = obj44;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X9_v18+20]");
													object obj67 = obj66 * 0;
													float num27 = num19 + num17;
													object obj68 = obj55;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X9_v18+28]");
													object obj69 = obj68 * 0;
													object obj70 = obj55;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X9_v18+20]");
													object obj71 = obj70 * 0;
													object obj72 = obj44;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X9_v18+28]");
													object obj73 = obj72 * 0;
													float num28 = num22 - (float)obj65;
													float num29 = num25 + num23;
													float num30 = (float)obj67 + num26;
													float num31 = num27 + (float)obj69;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ X8_v25+8]");
													obj43 = obj56 + 0;
													float num32 = num28 - (float)obj73;
													float num33 = num29 - (float)obj71;
													float num34 = num7 + (float)obj57;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ X8_v25+4]");
													object obj74 = obj54 + 0;
													float num35 = num30 - num21;
													num4 = num31 - (float)obj63;
													transform3.SetPositionAndRotation((Vector3)0, (Quaternion)0);
													int h = num3;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v15 (GillaItem[])+v218 @ X25_v6]");
													InHand(h, (GillaItem)0);
													num2 = num34;
													obj55 = obj74;
													flag4 = false;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v15 (GillaItem[])+v218 @ X25_v6]");
													flag25 = false;
													goto IL_0ebe;
												}
											}
										}
									}
									goto IL_14a7;
								}
							}
						}
						GillaItem[] array10 = holding;
						if (holding == null)
						{
							break;
						}
						bool flag34 = num3 < array10.Length;
						object obj75 = !flag34;
						if (obj75 == null)
						{
							object obj76 = (object)holding + obj35;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Fingers(num3, 0f);
							num4 = num4;
							obj43 = obj44;
							num2 = 0f;
							flag4 = false;
							flag25 = (byte)num3 != 0;
							goto IL_0ebe;
						}
					}
					goto IL_14a7;
					IL_0ebe:
					obj37 += 12;
					num3++;
					obj35 += 8;
					obj36 += 16;
					bool flag35 = (nint)obj37 != 68;
					obj44 = obj43;
					if (!flag35)
					{
						Touches();
						return;
					}
				}
				break;
			}
			goto IL_14a7;
			IL_048f:
			object obj77 = transform2 & 1;
			bool flag36 = obj77 == null;
			bool flag37 = false;
			transform = transform2;
			flag23 = false;
			bool flag38 = false;
			flag10 = flag15;
			if (!flag36)
			{
				goto IL_04e5;
			}
			goto IL_06e5;
			IL_037f:
			GillaItem[] array11 = holding;
			if (holding == null)
			{
				break;
			}
			bool flag39 = num < array11.Length;
			object obj78 = !flag39;
			if (obj78 == null)
			{
				object obj79 = holding + num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v64+20]");
				bool flag40 = Allowed((GillaItem)0);
				object obj80 = transform & 1;
				bool flag41 = obj80 == null;
				object obj81 = !flag41;
				transform2 = transform;
				flag37 = flag40;
				flag15 = flag10;
				if (obj81 != null)
				{
					goto IL_04e5;
				}
				flag23 = flag40;
				flag38 = false;
				goto IL_06e5;
			}
			goto IL_14a7;
			IL_04e5:
			bool[] array12 = was;
			if (was == null)
			{
				break;
			}
			bool flag42 = num < array12.Length;
			object obj82 = !flag42;
			if (obj82 == null)
			{
				object obj83 = was + num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v43+20]");
				bool flag43 = (nint)0 == 0;
				object obj84 = !flag43;
				flag38 = false;
				if (obj84 == null)
				{
					GillaItem[] array13 = holding;
					if (holding == null)
					{
						break;
					}
					bool flag44 = num < array13.Length;
					object obj85 = !flag44;
					if (obj85 != null)
					{
						goto IL_14a7;
					}
					object obj86 = obj2;
					object obj87 = holding + num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X0_v64+E4]");
					bool flag45 = (nint)0 == 0;
					object obj88 = !flag45;
					if (obj88 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v47+20]");
					bool flag46 = (UnityEngine.Object)0 == null;
					object obj89 = flag2 & flag46;
					object obj90 = ~obj89;
					object obj91 = flag5 | obj90;
					object obj92 = obj91 & 1;
					bool flag47 = obj92 == null;
					flag38 = false;
					flag15 = false;
					if (flag47)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51C0]");
						object obj93 = 0;
						object obj94 = obj93;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X8_v52+A0]");
						object obj95 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X8_v53+8]");
						UnityEngine.Object obj96 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X8_v53+8]");
						bool flag48 = (nint)0 == 0;
						bool flag49 = false;
						int num36 = 0;
						if (!flag48)
						{
							Vector3 vector3 = Point(num);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X23_v12 (UnityEngine.Object)+28]");
							flag49 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v859 @ X23_v12 (UnityEngine.Object)+18] (should have been resolved before IL gen)");
							obj96 = obj97;
							num36 = num;
						}
						object obj98 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X0_v69+E4]");
						bool flag50 = (nint)0 == 0;
						object obj99 = !flag50;
						if (obj99 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (obj96 != null)
						{
							bool flag51 = Allowed((GillaItem)obj96);
							bool flag52 = !flag51;
							object obj100 = !flag52;
							object obj101 = ~obj100;
							if (obj101 != null)
							{
								obj96 = null;
							}
						}
						object obj102 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ X0_v74+E4]");
						bool flag53 = (nint)0 == 0;
						object obj103 = !flag53;
						if (obj103 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag54 = obj96 == null;
						bool flag55 = !flag54;
						int num37 = 0;
						if (!flag55)
						{
							Vector3 vector4 = Point(num);
							GillaItem gillaItem = Nearest((Vector3)num);
							obj96 = gillaItem;
							num37 = num;
						}
						object obj104 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1041 @ X0_v79+E4]");
						bool flag56 = (nint)0 == 0;
						object obj105 = !flag56;
						if (obj105 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag57 = obj96 == null;
						object obj106 = obj10 & flag57;
						object obj107 = obj106 & 1;
						bool flag58 = obj107 == null;
						UnityEngine.Object obj108 = null;
						if (!flag58)
						{
							Vector3 vector5 = Point(num);
							bool flag59 = GillaToys.TryTake(num, (Vector3)0);
							bool flag60 = !flag59;
							obj108 = null;
							if (!flag60)
							{
								num2 = 1f;
								flag4 = false;
								goto IL_16ab;
							}
						}
						object obj109 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1070 @ X0_v84+E4]");
						bool flag61 = (nint)0 == 0;
						object obj110 = !flag61;
						if (obj110 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag62 = obj96 != null;
						bool flag63 = !flag62;
						flag4 = false;
						if (!flag63)
						{
							Take(num, (GillaItem)obj96);
							flag4 = (byte)(int)obj96 != 0;
						}
						goto IL_08ab;
					}
				}
				bool flag64 = !flag37;
				object obj111 = !flag64;
				transform = transform2;
				flag23 = flag37;
				flag10 = flag15;
				flag4 = flag38;
				if (obj111 == null)
				{
					goto IL_06e5;
				}
				goto IL_07f4;
			}
			goto IL_14a7;
			IL_07f4:
			if (flag5)
			{
				object obj112 = (object)transform2 & obj10;
				object obj113 = obj112 & 1;
				bool flag65 = obj113 == null;
				object obj114 = !flag65;
				if (obj114 == null)
				{
					Throw(num, out var velocity, out var _);
					object obj115 = obj10 & 1;
					if (obj115 != null)
					{
						obj55 = obj116;
						object obj117 = (object)(&velocity);
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
						object obj118 = 0;
						object obj119 = obj118;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v961 @ X8_v34+A0]");
						object obj117 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X8_v28+4]");
						obj55 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X8_v28+8]");
					obj44 = 0;
					GillaToys.Release(num, (Vector3)0);
					num2 = 0f;
					flag4 = (byte)(&velocity) != 0;
					goto IL_16ab;
				}
			}
			goto IL_08ab;
		}
		goto IL_1499;
		IL_1499:
		NullReferenceException ex = new NullReferenceException();
		goto IL_14a7;
	}

	private static void InHand(int h, GillaItem item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0343: Expected Obj, but got I4
		//IL_037b: Expected Obj, but got I4
		//IL_03e9: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I4
		//IL_00de: Expected I, but got Obj
		//IL_03b3: Expected Obj, but got I4
		//IL_0180: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I
		//IL_03ce: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got VT
		//IL_01fa: Expected VT, but got I4
		//IL_01fa: Expected VT, but got I4
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_0307: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		UnityEngine.Object obj8;
		if (h == 2)
		{
			UnityEngine.Object obj7 = item;
			obj8 = null;
		}
		else
		{
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v3+8]");
			bool flag4 = (UnityEngine.Object)0 == null;
			bool flag5 = !flag4;
			object obj12 = !flag5;
			nint num = unchecked((nint)null);
			UnityEngine.Object obj7 = null;
			obj8 = null;
			if (obj12 == null)
			{
				object obj13;
				if (h != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v3+8]");
					obj13 = (nint)0 + (nint)64;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v3+8]");
					obj13 = (nint)0 + (nint)56;
				}
				obj8 = (UnityEngine.Object)obj13;
				num = unchecked((nint)null);
				obj7 = null;
			}
		}
		object obj14 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v8+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = obj8 == null;
		bool flag8 = !flag7;
		object obj16 = !flag8;
		if (obj16 == null)
		{
			Quaternion rotation = ((Transform)obj8).rotation;
			Quaternion rotation2 = default;
			Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation2);
			Transform transform = item.transform;
			Vector3 position = transform.position;
			Vector3 position2 = ((Transform)obj8).position;
			Vector3 vector = default;
			object obj17 = vector - vector;
			Vector3 vector2 = (Quaternion)0 * (Vector3)0;
			item.InHandAt__BackingField = vector;
			Transform transform2 = item.transform;
			Quaternion rotation3 = transform2.rotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
			object obj19 = default;
			object obj18 = obj19 * vector;
			object obj20 = vector * obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
			object obj21 = obj18 + obj20;
			object obj23 = default;
			object obj22 = vector * obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
			object obj24 = obj21 + obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			object obj25 = obj20 * obj23;
			Quaternion quaternion2 = (Quaternion)(obj24 - obj25);
			item.InHandTurn__BackingField = quaternion2;
		}
	}

	private unsafe void Touches()
	{
		//IL_0010: Expected Obj, but got I
		//IL_06c0: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_006b: Expected VT, but got I4
		//IL_0074: Expected VT, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I
		//IL_0190: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got I4
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_0325: Expected Obj, but got I4
		//IL_0379: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got Ref
		//IL_0389: Expected Obj, but got Ref
		//IL_0391: Expected VT, but got Ref
		//IL_03d4: Expected Obj, but got I4
		//IL_040b: Expected Obj, but got I4
		//IL_0413: Expected Obj, but got Ref
		//IL_041b: Expected Obj, but got Ref
		//IL_0423: Expected VT, but got Ref
		//IL_043d: Expected Obj, but got I4
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected Obj, but got Unknown
		//IL_046e: Expected VT, but got I4
		//IL_074c: Expected Obj, but got VT
		//IL_060a: Expected Obj, but got I4
		//IL_04b6: Expected Obj, but got I4
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected Obj, but got Unknown
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected Obj, but got Unknown
		//IL_04f5: Expected Obj, but got I4
		//IL_04fd: Expected Obj, but got I4
		//IL_0784: Expected Obj, but got I4
		//IL_0563: Expected Obj, but got VT
		//IL_05c6: Expected Obj, but got Ref
		//IL_05c6: Expected F4, but got VT
		//IL_05c6: Expected VT, but got Ref
		//IL_05c6: Expected VT, but got Obj
		//IL_05c6: Expected Obj, but got I
		//IL_05d8: Expected Obj, but got Ref
		//IL_05e2: Expected VT, but got Ref
		//IL_05ea: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (gt == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj4 = 0;
		Vector3 velocity = (Vector3)0;
		Vector3 vector = (Vector3)0;
		UnityEngine.Object obj5 = null;
		int num = 0;
		object obj27 = default;
		object obj30 = default;
		while (true)
		{
			GillaItem[] array = holding;
			if (holding == null)
			{
				goto IL_0681;
			}
			bool flag2 = num < array.Length;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				break;
			}
			object obj7 = obj;
			object obj8 = holding + num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v8+20]");
			UnityEngine.Object obj9 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v8+20]");
			bool flag7;
			if ((UnityEngine.Object)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v8+20]");
				if ((nint)0 == 0)
				{
					goto IL_0681;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X22_v4 (UnityEngine.Object)+45]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X22_v4 (UnityEngine.Object)+48]");
					bool flag5 = (nint)0 == 0;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X22_v4 (UnityEngine.Object)+41]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X22_v4 (UnityEngine.Object)+40]");
							bool flag6 = (nint)0 == 0;
							flag7 = flag6;
							goto IL_07bb;
						}
					}
				}
			}
			flag7 = false;
			goto IL_07bb;
			IL_0735:
			bool[] array2;
			bool flag8 = array2 == null;
			Vector3 vector2;
			obj5 = (UnityEngine.Object)vector2;
			if (!flag8)
			{
				goto IL_05ef;
			}
			goto IL_0681;
			IL_07bb:
			Player player = gt;
			if (num != 0)
			{
				HeldShape rightHeld;
				if (flag7)
				{
					HeldShape[] array3 = shapes;
					if (shapes == null)
					{
						goto IL_0681;
					}
					rightHeld = array3[1];
				}
				else
				{
					rightHeld = null;
				}
				if ((object)gt == null)
				{
					goto IL_0681;
				}
				object obj13 = gt + 320;
				player.rightHeld = rightHeld;
			}
			else
			{
				HeldShape rightHeld;
				if (flag7)
				{
					HeldShape[] array4 = shapes;
					if (shapes == null)
					{
						goto IL_0681;
					}
					rightHeld = array4[0];
				}
				else
				{
					rightHeld = null;
				}
				if ((object)gt == null)
				{
					goto IL_0681;
				}
				player.leftHeld = rightHeld;
				object obj13 = gt + 312;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if ((object)gt != null)
			{
				object obj14 = num - 1;
				bool flag9 = obj14 == null;
				bool flag10 = gt.HeldTouching(flag9, out var at, out var faces, out var on);
				bool flag11;
				bool flag12;
				if (flag10)
				{
					object obj15 = 0;
					object obj16 = (object)(&on);
					Collider collider = (Collider)(&faces);
					vector = (Vector3)(&at);
					flag11 = flag9;
					flag12 = false;
				}
				else
				{
					if ((object)gt == null)
					{
						goto IL_0681;
					}
					object obj17 = num - 1;
					bool flag13 = obj17 == null;
					flag12 = gt.HeldInto(flag13, out at, out faces, out on);
					object obj15 = 0;
					object obj16 = (object)(&on);
					Collider collider = (Collider)(&faces);
					vector = (Vector3)(&at);
					flag11 = flag13;
				}
				object obj18 = flag10 | flag12;
				object obj19 = flag7 & obj18;
				array2 = knocking;
				bool flag14 = (nint)obj19 != 1;
				vector2 = (Vector3)flag11;
				if (flag14)
				{
					goto IL_0735;
				}
				if (knocking != null)
				{
					bool flag15 = num < array2.Length;
					object obj20 = !flag15;
					if (obj20 != null)
					{
						break;
					}
					object obj21 = knocking + num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X9_v11+20]");
					bool flag16 = (nint)0 == 0;
					object obj22 = !flag16;
					obj5 = (UnityEngine.Object)flag11;
					if (obj22 != null)
					{
						goto IL_05ef;
					}
					Throw(num, out velocity, out var spin);
					object obj23 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v24+E4]");
					bool flag17 = (nint)0 == 0;
					object obj24 = !flag17;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v8+20]");
					if ((nint)0 != 0)
					{
						object obj25 = velocity * velocity;
						object obj26 = obj27 * obj27;
						object obj28 = obj25 + obj26;
						object obj29 = obj28 + obj30;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						float num2 = (float)obj29 / throwBoost;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v8+20]");
						((GillaItem)0).HeldKnock((Vector3)on, (Vector3)(&velocity), (float)at, (Collider)(&spin));
						array2 = knocking;
						Collider collider = (Collider)(&spin);
						vector = (Vector3)(&velocity);
						vector2 = (Vector3)on;
						goto IL_0735;
					}
				}
			}
			goto IL_0681;
			IL_0681:
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_05ef:
			bool flag18 = num < array2.Length;
			object obj31 = !flag18;
			if (obj31 != null)
			{
				break;
			}
			object obj32 = array2 + num;
			num++;
			if (num == 2)
			{
				return;
			}
		}
		throw new IndexOutOfRangeException();
	}

	private unsafe static HeldShape ShapeOf(GillaItem item, Quaternion toHand, Vector3 at, Vector3 from)
	{
		//IL_0010: Expected Obj, but got I
		//IL_18bf: Expected F4, but got I4
		//IL_0039: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_0069: Expected F4, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_01c8: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I8
		//IL_01ec: Expected Obj, but got I
		//IL_01f5: Expected F8, but got I4
		//IL_01fe: Expected F8, but got I4
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got I4
		//IL_0231: Expected F4, but got I
		//IL_1e67: Expected Obj, but got I4
		//IL_16ff: Expected Obj, but got I
		//IL_124d: Expected Obj, but got I
		//IL_1267: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I
		//IL_02ca: Expected Obj, but got I4
		//IL_1751: Expected Obj, but got I
		//IL_1761: Expected Obj, but got I
		//IL_1285: Expected Obj, but got I
		//IL_129f: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I
		//IL_0317: Expected Obj, but got I4
		//IL_0328: Expected VT, but got I4
		//IL_12c5: Expected Obj, but got I
		//IL_12d5: Expected Obj, but got I
		//IL_12e5: Expected Obj, but got I
		//IL_12f5: Expected Obj, but got I
		//IL_12fe: Expected Obj, but got I4
		//IL_10dc: Expected Obj, but got I4
		//IL_10e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ea: Expected Obj, but got Unknown
		//IL_035b: Expected VT, but got I4
		//IL_130b: Expected VT, but got Obj
		//IL_131b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1320: Expected Obj, but got Unknown
		//IL_1329: Unknown result type (might be due to invalid IL or missing references)
		//IL_132e: Expected Obj, but got Unknown
		//IL_1357: Expected I4, but got Obj
		//IL_137f: Expected Obj, but got I4
		//IL_037f: Expected Obj, but got I
		//IL_039b: Expected VT, but got I4
		//IL_139d: Expected Obj, but got I
		//IL_13bb: Expected Obj, but got I
		//IL_13df: Expected Obj, but got I4
		//IL_03df: Expected Obj, but got I
		//IL_03f9: Expected I, but got Obj
		//IL_0422: Expected Obj, but got I4
		//IL_048c: Expected Obj, but got I
		//IL_04bd: Expected Obj, but got I4
		//IL_1416: Expected Obj, but got I4
		//IL_0527: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I4
		//IL_0457: Expected Obj, but got I
		//IL_1496: Expected Obj, but got I
		//IL_14a6: Expected Obj, but got I
		//IL_14bb: Expected VT, but got I
		//IL_14cb: Expected Obj, but got I
		//IL_05c2: Expected Obj, but got I
		//IL_05f4: Expected Obj, but got I4
		//IL_060e: Expected VT, but got I4
		//IL_04f2: Expected Obj, but got I
		//IL_0a5b: Expected Obj, but got I
		//IL_143a: Expected Obj, but got I
		//IL_144a: Unknown result type (might be due to invalid IL or missing references)
		//IL_144f: Expected Obj, but got Unknown
		//IL_1465: Expected Obj, but got I
		//IL_1481: Expected Obj, but got I4
		//IL_058d: Expected Obj, but got I
		//IL_0da8: Expected Obj, but got I
		//IL_0dba: Expected VT, but got I4
		//IL_0ad8: Expected Obj, but got I
		//IL_0aea: Expected Obj, but got I4
		//IL_0b04: Expected Obj, but got I4
		//IL_0b12: Expected Obj, but got I4
		//IL_0b2c: Expected Obj, but got I4
		//IL_063e: Expected Obj, but got I
		//IL_0668: Expected VT, but got I4
		//IL_0eb0: Expected Obj, but got I
		//IL_0ec5: Expected Obj, but got I
		//IL_0dd4: Expected Obj, but got I
		//IL_0df0: Invalid comparison between F4 and I4
		//IL_0dff: Invalid comparison between F4 and I4
		//IL_0e12: Expected Obj, but got F8
		//IL_0e1f: Expected Obj, but got F8
		//IL_0e54: Expected Obj, but got I4
		//IL_0e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e61: Expected Obj, but got Unknown
		//IL_0b6f: Expected Obj, but got I8
		//IL_14f5: Expected VT, but got Obj
		//IL_1502: Expected I4, but got Obj
		//IL_152a: Expected Obj, but got I4
		//IL_0f28: Expected VT, but got I4
		//IL_0f31: Expected Obj, but got I4
		//IL_1a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a72: Expected Obj, but got Unknown
		//IL_0b5d: Expected Obj, but got I8
		//IL_068c: Expected Obj, but got I
		//IL_06ba: Expected Obj, but got I4
		//IL_1ea3: Expected Obj, but got I
		//IL_1ecc: Expected Obj, but got I
		//IL_1edd: Expected I, but got Obj
		//IL_1ef7: Expected Obj, but got I
		//IL_1ef7: Expected VT, but got I4
		//IL_1ef7: Expected VT, but got Obj
		//IL_1ef7: Expected VT, but got Obj
		//IL_1b72: Invalid comparison between F4 and I4
		//IL_1b81: Invalid comparison between F4 and I4
		//IL_1b94: Expected Obj, but got F4
		//IL_1ba1: Expected Obj, but got F4
		//IL_1bd6: Expected Obj, but got I4
		//IL_1bde: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be3: Expected Obj, but got Unknown
		//IL_1bec: Expected I4, but got Obj
		//IL_0ab4: Expected VT, but got I4
		//IL_1548: Expected Obj, but got I
		//IL_1566: Expected Obj, but got I
		//IL_158a: Expected Obj, but got I4
		//IL_070d: Expected VT, but got I4
		//IL_0f6e: Expected VT, but got Obj
		//IL_1c1b: Expected VT, but got I4
		//IL_1c34: Expected VT, but got I4
		//IL_0c80: Invalid comparison between F4 and I4
		//IL_0c8f: Invalid comparison between F4 and I4
		//IL_0ca2: Expected Obj, but got F4
		//IL_0caf: Expected Obj, but got F4
		//IL_0ce4: Expected Obj, but got I4
		//IL_0cec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf1: Expected Obj, but got Unknown
		//IL_0c00: Expected Obj, but got I4
		//IL_15c1: Expected Obj, but got I4
		//IL_0731: Expected Obj, but got I
		//IL_074d: Expected VT, but got I4
		//IL_0bbc: Expected VT, but got I4
		//IL_17f1: Expected Obj, but got I
		//IL_1629: Expected Obj, but got I
		//IL_1639: Expected Obj, but got I
		//IL_1649: Expected Obj, but got I
		//IL_1ade: Expected Obj, but got I
		//IL_1b1d: Invalid comparison between F4 and I4
		//IL_1664: Unknown result type (might be due to invalid IL or missing references)
		//IL_1669: Expected Obj, but got Unknown
		//IL_15ec: Expected Obj, but got I
		//IL_1602: Expected Obj, but got I
		//IL_1614: Expected Obj, but got I4
		//IL_0c4d: Expected VT, but got I4
		//IL_0d23: Expected F4, but got I4
		//IL_1145: Expected VT, but got I4
		//IL_1156: Expected F8, but got I4
		//IL_1167: Expected Obj, but got I4
		//IL_1fe0: Expected Obj, but got I
		//IL_1ff8: Expected Obj, but got I
		//IL_2000: Expected F4, but got Obj
		//IL_2010: Expected F8, but got I
		//IL_2020: Expected F4, but got I
		//IL_0fc8: Expected F8, but got I
		//IL_0fd8: Expected F8, but got I
		//IL_0fe0: Expected Obj, but got Ref
		//IL_1b55: Expected Obj, but got F8
		//IL_1901: Invalid comparison between F4 and I
		//IL_1917: Expected F8, but got I
		//IL_2067: Expected Obj, but got I4
		//IL_0f9b: Expected F4, but got Obj
		//IL_0fab: Expected F8, but got I
		//IL_0fb3: Expected Obj, but got Ref
		//IL_1940: Expected VT, but got I4
		//IL_1049: Invalid comparison between F4 and I4
		//IL_0867: Expected VT, but got I4
		//IL_0813: Invalid comparison between F4 and I
		//IL_0888: Expected VT, but got I4
		//IL_08a9: Expected Obj, but got I4
		//IL_1c6f: Invalid comparison between F4 and I4
		//IL_1c7e: Invalid comparison between F4 and I4
		//IL_1c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c92: Expected Obj, but got Unknown
		//IL_1c9f: Expected Obj, but got F4
		//IL_1cd4: Expected Obj, but got I4
		//IL_1cdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce1: Expected Obj, but got Unknown
		//IL_1cea: Expected I4, but got Obj
		//IL_1066: Expected F4, but got I4
		//IL_0d7a: Expected F4, but got Obj
		//IL_0d8a: Expected F8, but got I
		//IL_0d92: Expected Obj, but got Ref
		//IL_0842: Expected F8, but got I
		//IL_1096: Expected Obj, but got I4
		//IL_184c: Expected Obj, but got I
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Expected F4, but got I
		//IL_08e5: Expected Obj, but got I
		//IL_08f6: Expected F8, but got I4
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Expected F4, but got Unknown
		//IL_1088: Expected Obj, but got F4
		//IL_1e24: Expected Obj, but got I
		//IL_1e31: Invalid comparison between F4 and I4
		//IL_1e40: Expected F8, but got I4
		//IL_1f0c: Expected Obj, but got I
		//IL_1f25: Expected F4, but got Ref
		//IL_1d92: Expected VT, but got I4
		//IL_1da8: Expected VT, but got I4
		//IL_1db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db6: Expected Obj, but got Unknown
		//IL_1de0: Expected VT, but got I4
		//IL_0911: Expected VT, but got I4
		//IL_1980: Expected Obj, but got I4
		//IL_19a0: Expected VT, but got I4
		//IL_19b9: Expected F8, but got I4
		//IL_1fc2: Expected Obj, but got I4
		//IL_09bc: Invalid comparison between F4 and I
		//IL_0a1d: Expected Obj, but got I
		//IL_0a25: Expected F8, but got Obj
		//IL_0a35: Expected F4, but got I
		//IL_0a45: Expected F8, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1148]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		bool flag = obj2 == null;
		float num2 = default;
		float num = num2;
		double num4 = default;
		double num3 = num4;
		float num5 = 0f;
		UnityEngine.Object obj3 = null;
		object obj7;
		object obj6;
		Vector3 vector = default;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73E0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73D8]");
			float num6 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<Vector3> list = default;
			list._002Ector();
			obj6 = obj2 + 16;
			obj6 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<float> list2 = default;
			list2._002Ector();
			obj7 = obj2 + 64;
			obj7 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag2 = (object)item == null;
			float num7 = default;
			num = num7;
			double num8 = default;
			num3 = num8;
			float num9 = default;
			num5 = num9;
			obj3 = (UnityEngine.Object)(object)list2;
			if (!flag2)
			{
				Collider[] array = item.Colliders__BackingField;
				bool flag3 = item.Colliders__BackingField == null;
				num = num7;
				num3 = num8;
				num5 = num9;
				obj3 = (UnityEngine.Object)(object)list2;
				if (!flag3)
				{
					bool flag4 = array.Length < 1;
					num = num7;
					num3 = num8;
					num5 = num9;
					obj3 = (UnityEngine.Object)(object)list2;
					if (flag4)
					{
						goto IL_11e3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj8 = 0;
					object obj9 = array.Length & 0xFFFFFFFFL;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj10 = 0;
					double num10 = 0.0;
					double num11 = 0.0;
					Enumerator<, > val = (Enumerator<, >)0;
					object obj11 = 0;
					num = num7;
					num3 = num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACC4]");
					num5 = 0f;
					obj3 = (UnityEngine.Object)(object)list2;
					double num13 = default;
					double num12 = num13;
					double num14 = num4;
					float num15 = num2;
					double num17 = default;
					float num16 = (float)num17;
					float num19 = default;
					float num18 = num19;
					List<Vector3> list3 = list;
					float num21 = default;
					double num20 = num21;
					float num23 = default;
					float num22 = num23;
					double num24 = default;
					IndexOutOfRangeException ex = default;
					string text = default;
					float num35 = default;
					double num62 = default;
					float num63 = default;
					float num64 = default;
					Enumerator<, > val2 = default;
					float num71 = default;
					double num29 = default;
					double num72 = default;
					float num61 = default;
					HeldShape result = default;
					Action<Vector3, float> action = default;
					IntPtr intPtr = default;
					IndexOutOfRangeException ex3 = default;
					string text3 = default;
					UnityEngine.Object obj84 = default;
					while (true)
					{
						bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
						object obj12 = !flag5;
						if (obj12 != null)
						{
							break;
						}
						object obj13 = obj8;
						object obj14 = (object)item.Colliders__BackingField + obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v47+20]");
						UnityEngine.Object obj15 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ X0_v70+E4]");
						bool flag6 = (nint)0 == 0;
						object obj16 = !flag6;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v47+20]");
						bool flag7 = (UnityEngine.Object)0 == null;
						bool flag8 = !flag7;
						object obj17 = !flag8;
						num24 = num24;
						vector = (Vector3)0;
						obj3 = null;
						if (obj17 != null)
						{
							goto IL_10d2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v47+20]");
						bool flag9 = (nint)0 == 0;
						vector = (Vector3)0;
						obj3 = null;
						Transform transform;
						float num55;
						double num56;
						double num57;
						float num58;
						object obj40;
						int num34;
						string text2;
						if (!flag9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v47+20]");
							transform = ((Component)0).transform;
							bool flag10 = (object)transform == null;
							vector = (Vector3)0;
							obj3 = null;
							if (!flag10)
							{
								Vector3 lossyScale = transform.lossyScale;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1160]");
								object obj18 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
								object obj19 = obj18;
								nint num25 = (nint)obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v52 (Il2CppClass<UnityEngine.Object>)+130]");
								nint num26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X10_v17+130]");
								bool flag11 = num26 < 0;
								object obj20 = !flag11;
								object obj21 = ~obj20;
								if (obj21 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v52 (Il2CppClass<UnityEngine.Object>)+B0]");
									nint num27 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X10_v17+130]");
									object obj22 = num27 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1416 @ X11_v26-8]");
									if (0 == (nint)obj19)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v47+20]");
										int direction = ((CapsuleCollider)0).direction;
										if (direction != 0 && direction != 2)
										{
											bool flag12 = direction != 1;
											vector = (Vector3)0;
											obj3 = null;
											if (flag12)
											{
												goto IL_17ac;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v47+20]");
										num5 = ((CapsuleCollider)0).radius;
										object obj23 = direction - 1;
										bool flag13 = direction < 1;
										object obj24 = !flag13;
										object obj25 = direction - 1;
										bool flag14 = obj25 == null;
										object obj26 = !flag14;
										object obj27 = obj24 & obj26;
										object obj28 = ~obj27;
										object obj29 = ((obj28 != null) ? ((object)(-4294967295L)) : ((object)4294967294L));
										object obj30 = obj29 + direction;
										bool flag15 = obj30 == null;
										float num28 = num18;
										if (!flag15)
										{
											bool flag16 = (nint)obj30 == 2;
											num28 = num22;
											if (!flag16)
											{
												bool flag17 = (nint)obj30 != 1;
												num28 = (float)num29;
												vector = (Vector3)0;
												num3 = num29;
												obj3 = null;
												if (flag17)
												{
													goto IL_17ac;
												}
											}
										}
										if (direction == 0)
										{
											obj23 = 2;
										}
										if (obj23 != null)
										{
											bool flag18 = (nint)obj23 == 2;
											num18 = num22;
											if (!flag18)
											{
												bool flag19 = (nint)obj23 != 1;
												num18 = (float)num29;
												vector = (Vector3)0;
												num3 = num28;
												obj3 = null;
												if (flag19)
												{
													goto IL_17ac;
												}
											}
										}
										float num30 = num28 - num18;
										bool flag20 = num30 < 0f;
										bool flag21 = num30 == 0f;
										object obj31 = num28 ^ num18;
										object obj32 = num28 ^ num30;
										object obj33 = obj31 & obj32;
										bool flag22 = (nint)obj33 < 0;
										bool flag23 = flag20 == flag22;
										object obj34 = !flag21;
										object obj35 = flag23 & obj34;
										object obj36 = ~obj35;
										if (obj36 != null)
										{
											num28 = num18;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
										num16 = num5 * num28;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v47+20]");
										float height = ((CapsuleCollider)0).height;
										float num31 = height * 0.5f;
										float num32 = (float)num14 * num31;
										float num33 = num32 - num16;
										num15 = ((!(num33 < 0f)) ? num33 : 0f);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
										object obj37 = 0;
										object obj38 = obj37;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1812 @ X8_v94+A0]");
										object obj39 = 0;
										num5 = (float)obj39;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X8_v95+4]");
										num3 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X8_v95+8]");
										num = 0f;
										object obj41;
										if (direction != 0)
										{
											if (direction != 2)
											{
												if (direction != 1)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
													ex._002Ector(text);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6068]");
													obj40 = 0;
													num34 = 0;
													text2 = text;
													goto IL_1f7b;
												}
												num35 = (float)obj39;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X8_v95+8]");
												num10 = 0.0;
												obj41 = (object)(&num11);
											}
											else
											{
												num35 = (float)obj39;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X8_v95+4]");
												num11 = 0.0;
												obj41 = (object)(&num10);
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X8_v95+8]");
											num10 = 0.0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X8_v95+4]");
											num11 = 0.0;
											obj41 = (object)(&num35);
										}
										double num36 = 1.0 / num14;
										obj41 = num36;
										object obj42 = obj10;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1888 @ X0_v148+E4]");
										bool flag24 = (nint)0 == 0;
										object obj43 = !flag24;
										if (obj43 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										float num37 = num15 + num15;
										float num38 = num16 * 1.5f;
										float num39 = num37 / num38;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
										num6 = num39 + 1f;
										float num40 = ((num6 < 12f) ? (num39 + 1f) : 12f);
										float num41 = num40 - 1f;
										bool flag25 = num41 < 0f;
										bool flag26 = num41 == 0f;
										object obj44 = num40 ^ 1;
										object obj45 = num40 ^ num41;
										object obj46 = obj44 & obj45;
										bool flag27 = (nint)obj46 < 0;
										bool flag28 = flag25 == flag27;
										object obj47 = !flag26;
										object obj48 = flag28 & obj47;
										list3 = (((int)(~obj48) != 0) ? ((List<Vector3>)1) : ((List<Vector3>)num40));
										num14 = (double)list3 + -1.0;
										Mesh mesh = null;
										bool flag30;
										do
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v47+20]");
											Vector3 center = ((CapsuleCollider)0).center;
											bool flag29 = num6 < 2f;
											double num42 = 0.0;
											if (!flag29)
											{
												double num43 = (double)mesh / num14;
												double num44 = num43 + num43;
												num42 = num44 + -1.0;
											}
											float num45 = num15 * (float)num42;
											num19 = num35 * num45;
											num21 = (float)num11 * num45;
											float num46 = (float)num10 * num45;
											num5 = (float)list3 + num19;
											num3 = -1.0 + (double)num21;
											num += num46;
											Vector3 vector2 = transform.TransformPoint((Vector3)0);
											((GillaHud._003C_003Ec__DisplayClass45_0)obj2)._003CShapeOf_003Eg__Ball_007C0((Vector3)0, num5);
											Mesh mesh2 = (Mesh)(mesh + 1);
											flag30 = (object)list3 != mesh2;
											num17 = num16;
											num24 = num24;
											vector = (Vector3)0;
											obj3 = null;
											num12 = num11;
											num20 = num10;
											num22 = num35;
											mesh = mesh2;
										}
										while (flag30);
										goto IL_10d2;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1170]");
								object obj49 = 0;
								obj19 = obj49;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v52 (Il2CppClass<UnityEngine.Object>)+130]");
								nint num47 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X10_v17+130]");
								bool flag31 = num47 < 0;
								object obj50 = !flag31;
								object obj51 = ~obj50;
								if (obj51 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v52 (Il2CppClass<UnityEngine.Object>)+B0]");
									nint num48 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X10_v17+130]");
									object obj52 = num48 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1453 @ X11_v24-8]");
									if (0 == (nint)obj19)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v47+20]");
										Vector3 center2 = ((SphereCollider)0).center;
										Vector3 vector3 = transform.TransformPoint((Vector3)0);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v47+20]");
										float radius = ((SphereCollider)0).radius;
										float num49 = (float)num29 - num22;
										bool flag32 = num49 < 0f;
										bool flag33 = num49 == 0f;
										object obj53 = num29 ^ (double)num22;
										object obj54 = num29 ^ (double)num49;
										object obj55 = obj53 & obj54;
										bool flag34 = (nint)obj55 < 0;
										bool flag35 = flag32 == flag34;
										object obj56 = !flag33;
										object obj57 = flag35 & obj56;
										object obj58 = ~obj57;
										float num50 = ((obj58 != null) ? num22 : ((float)num29));
										float num51 = num18 - num50;
										bool flag36 = num51 < 0f;
										bool flag37 = num51 == 0f;
										object obj59 = num18 ^ num50;
										object obj60 = num18 ^ num51;
										object obj61 = obj59 & obj60;
										bool flag38 = (nint)obj61 < 0;
										bool flag39 = flag36 == flag38;
										object obj47 = !flag37;
										object obj62 = flag39 & obj47;
										if ((int)(~obj62) == 0)
										{
											num50 = num18;
										}
										float num52 = num50 * radius;
										((GillaHud._003C_003Ec__DisplayClass45_0)obj2)._003CShapeOf_003Eg__Ball_007C0((Vector3)0, num5);
										num17 = num52;
										num24 = num24;
										vector = (Vector3)0;
										obj3 = null;
										num14 = num;
										num15 = (float)num3;
										num16 = num5;
										goto IL_10d2;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1158]");
								object obj63 = 0;
								obj19 = obj63;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v52 (Il2CppClass<UnityEngine.Object>)+130]");
								nint num53 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X10_v17+130]");
								bool flag40 = num53 < 0;
								object obj64 = !flag40;
								object obj65 = ~obj64;
								if (obj65 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v52 (Il2CppClass<UnityEngine.Object>)+B0]");
									nint num54 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X10_v17+130]");
									object obj66 = num54 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1493 @ X11_v22-8]");
									if (0 == (nint)obj19)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v47+20]");
										Vector3 center3 = ((BoxCollider)0).center;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v47+20]");
										Vector3 size = ((BoxCollider)0).size;
										num55 = num5 * 0.5f;
										num56 = num3 * 0.5;
										num57 = (double)num * 0.5;
										num17 = 0.5;
										num58 = num5;
										Vector3 vector4 = (Vector3)0;
										object obj67 = 0;
										num14 = num;
										num15 = (float)num3;
										goto IL_1e75;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4370]");
								object obj68 = 0;
								obj19 = obj68;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v52 (Il2CppClass<UnityEngine.Object>)+130]");
								nint num59 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X10_v17+130]");
								bool flag41 = num59 < 0;
								object obj69 = !flag41;
								object obj70 = ~obj69;
								num24 = num24;
								vector = (Vector3)0;
								obj3 = null;
								if (obj70 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v52 (Il2CppClass<UnityEngine.Object>)+B0]");
									nint num60 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X10_v17+130]");
									object obj71 = num60 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1549 @ X8_v59-8]");
									bool flag42 = 0 != (nint)obj19;
									num24 = num24;
									vector = (Vector3)0;
									obj3 = null;
									if (!flag42)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v47+20]");
										Mesh sharedMesh = ((MeshCollider)0).sharedMesh;
										object obj72 = obj8;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v61+E4]");
										bool flag43 = (nint)0 == 0;
										object obj73 = !flag43;
										if (obj73 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag44 = sharedMesh != null;
										bool flag45 = !flag44;
										num24 = num24;
										Mesh mesh2 = sharedMesh;
										vector = (Vector3)0;
										obj3 = null;
										if (!flag45)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v47+20]");
											Mesh sharedMesh2 = ((MeshCollider)0).sharedMesh;
											bool flag46 = (object)sharedMesh2 == null;
											vector = (Vector3)0;
											obj3 = null;
											if (!flag46)
											{
												if (!sharedMesh2.isReadable)
												{
													Bounds bounds = sharedMesh2.bounds;
													Bounds bounds2 = sharedMesh2.bounds;
													num58 = num61;
													mesh2 = sharedMesh;
													Vector3 vector4 = (Vector3)0;
													num57 = num62;
													num56 = 0.0;
													num55 = num63;
													object obj67 = 0;
													num14 = num24;
													num15 = num64;
													goto IL_1e75;
												}
												Bounds bounds3 = sharedMesh2.bounds;
												float num65 = num18 * num63;
												float num66 = (float)num29 * 0f;
												float num67 = num22 * (float)num62;
												if (!(num66 < num67))
												{
													num66 = num67;
												}
												if (num65 < num66)
												{
													num66 = num65;
												}
												float num68 = num66;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD0]");
												bool flag47 = num68 < 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD0]");
												double num69 = 0.0;
												if (!flag47)
												{
													float num70 = num66;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACC4]");
													bool flag48 = !(num70 > 0f);
													num69 = num66;
													if (!flag48)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACC4]");
														num69 = 0.0;
													}
												}
												Bounds bounds4 = sharedMesh2.bounds;
												Vector3 vector5 = transform.TransformPoint((Vector3)0);
												Vector3[] vertices = sharedMesh2.vertices;
												Bounds bounds5 = sharedMesh2.bounds;
												List<Vector3> list4 = Furthest(vertices, (Vector3)10, 0);
												bool flag49 = list4 == null;
												vector = (Vector3)0;
												num = (float)num24;
												num3 = num64;
												num5 = num61;
												obj3 = (UnityEngine.Object)10;
												if (!flag49)
												{
													Enumerator<, > enumerator = list4.GetEnumerator();
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A38]");
													num6 = 0f;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
													object obj74 = 0;
													num = (float)num24;
													num3 = 0.0;
													num5 = (float)val2;
													while (val.MoveNext())
													{
														Vector3 vector6 = transform.TransformPoint((Vector3)0);
														object obj75 = obj10;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2050 @ X0_v114+E4]");
														bool flag50 = (nint)0 == 0;
														object obj76 = !flag50;
														if (obj76 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														num14 = num24 - (double)num71;
														num29 = (double)num61 - 0.0;
														num15 = num64 - (float)num72;
														Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
														bool flag51 = !((double)num22 > num69);
														num = (float)num24;
														num3 = num64;
														num5 = num61;
														if (!flag51)
														{
															object obj77 = obj10;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2109 @ X0_v120+E4]");
															bool flag52 = (nint)0 == 0;
															object obj78 = !flag52;
															if (obj78 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															float num73 = num22;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
															double num74;
															float num75;
															double num76;
															if (num73 > 0f)
															{
																num74 = num29 / (double)num22;
																num75 = num15 / num22;
																num76 = num14 / (double)num22;
															}
															else
															{
																object obj79 = obj74;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2120 @ X8_v83+A0]");
																object obj80 = 0;
																num74 = (double)obj80;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2121 @ X8_v84+4]");
																num75 = 0f;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2121 @ X8_v84+8]");
																num76 = 0.0;
															}
															double num77 = num69 * num74;
															double num78 = num69 * (double)num75;
															double num79 = num69 * num76;
															num5 = 0f + (float)num77;
															num3 = num72 + num78;
															double num80 = (double)num71 + num79;
															num = (float)num80;
														}
														((GillaHud._003C_003Ec__DisplayClass45_0)obj2)._003CShapeOf_003Eg__Ball_007C0((Vector3)0, num5);
														num17 = num69;
														num19 = num64;
														num12 = 0.0;
														num18 = num71;
														num20 = num72;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A20]");
													object obj81 = 0;
													obj3 = (UnityEngine.Object)obj81;
													val.Dispose();
													num61 = (nint)(&val);
													num34 = 0;
													OutOfMemoryException ex2 = new OutOfMemoryException();
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DAC4");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
													return result;
												}
											}
											goto IL_1793;
										}
									}
								}
								goto IL_10d2;
							}
						}
						goto IL_1793;
						IL_1e75:
						num16 = num18 * num55;
						num12 = num29 * num56;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1150]");
						object obj82 = 0;
						num20 = (double)num22 * num57;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1178]");
						object obj83 = 0;
						action._002Ector(obj2, (IntPtr)obj83);
						Box(transform, (Vector3)action, (Vector3)obj83, (Vector3)0, (Action<Vector3, float>)(nint)intPtr);
						num21 = (float)num20;
						num17 = num16;
						num19 = (float)num12;
						num24 = num24;
						vector = (Vector3)obj83;
						num = (float)num14;
						num3 = num15;
						num5 = num58;
						obj3 = (UnityEngine.Object)(object)action;
						goto IL_10d2;
						IL_10d2:
						obj9 = array.Length;
						obj11++;
						if ((nint)obj11 < array.Length)
						{
							continue;
						}
						goto IL_11e3;
						IL_17ac:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						ex3._002Ector(text3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6060]");
						obj40 = 0;
						num34 = 0;
						text2 = text3;
						goto IL_1f7b;
						IL_1f7b:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						obj3 = obj84;
						throw new ArgumentNullException();
					}
					goto IL_17a1;
				}
			}
		}
		goto IL_1793;
		IL_16ef:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43D0]");
		object obj85 = 0;
		obj3 = (UnityEngine.Object)obj85;
		List<Vector3> list5;
		Vector3[] at2 = list5.ToArray();
		bool flag53 = obj7 == null;
		Vector3 vector7;
		vector = vector7;
		float num81;
		num5 = num81;
		if (!flag53)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73D0]");
			object obj86 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1168]");
			object obj87 = 0;
			float[] radius2 = ((List<float>)obj7).ToArray();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			HeldShape heldShape = default;
			heldShape._002Ector(at2, radius2);
			return heldShape;
		}
		goto IL_1793;
		IL_1689:
		List<Vector3> list6 = default;
		obj6 = list6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		List<float> list7 = default;
		obj7 = list7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		list5 = (List<Vector3>)obj6;
		bool flag54 = obj6 == null;
		vector7 = vector;
		num81 = num5;
		obj3 = (UnityEngine.Object)(object)list7;
		if (!flag54)
		{
			goto IL_16ef;
		}
		goto IL_1793;
		IL_17a1:
		throw new IndexOutOfRangeException();
		IL_1793:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_17a1;
		IL_11e3:
		list5 = (List<Vector3>)obj6;
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1115 @ X0_v45 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			bool flag55 = (nint)0 < (nint)25;
			vector7 = vector;
			num81 = num5;
			if (flag55)
			{
				goto IL_16ef;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
			object obj88 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C0]");
			object obj89 = 0;
			list6._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73E0]");
			object obj90 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73D8]");
			object obj91 = 0;
			obj3 = (UnityEngine.Object)obj91;
			list7._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
			object obj92 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
			object obj93 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C76A8]");
			object obj94 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73B0]");
			object obj95 = 0;
			object obj96 = 0;
			while (true)
			{
				List<Vector3> list8 = (List<Vector3>)obj6;
				if (obj6 == null)
				{
					break;
				}
				vector = (Vector3)obj92;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v57 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				object obj97 = 0 * obj96;
				object obj98 = obj97 * 715827883;
				object obj99 = obj98 >> 63;
				object obj100 = obj98 >> 34;
				int num82 = (int)(obj100 + obj99);
				Vector3 vector8 = ((List<Vector3>)obj6).get_Item(num82);
				bool flag56 = list6 == null;
				obj3 = (UnityEngine.Object)num82;
				if (flag56)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X0_v53 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				object obj101 = 0;
				object obj102 = obj93;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X0_v53 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
				object obj103 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X0_v53 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				bool flag57 = (nint)0 == 0;
				obj3 = (UnityEngine.Object)num82;
				if (flag57)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X0_v53 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				nint num83 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X9_v12+18]");
				bool flag58 = num83 < 0;
				object obj104 = !flag58;
				if (obj104 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X0_v53 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj105 = (nint)0 * (nint)12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X0_v53 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj106 = 0 + obj105;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X0_v53 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj107 = (nint)0 + (nint)1;
					obj3 = (UnityEngine.Object)num82;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v34+20]");
					object obj108 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1519 @ X8_v42+A8]");
					object obj109 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1521 @ X8_v43+70]");
					list6.AddWithResize((Vector3)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1521 @ X8_v43+70]");
					obj3 = (UnityEngine.Object)0;
				}
				if (obj7 == null)
				{
					break;
				}
				vector = (Vector3)obj94;
				int num84 = (int)(obj100 + obj99);
				num5 = ((List<float>)obj7).get_Item(num84);
				bool flag59 = list7 == null;
				obj3 = (UnityEngine.Object)num84;
				if (flag59)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X0_v55 (System.Collections.Generic.List`1<System.Single>)+10]");
				object obj110 = 0;
				object obj111 = obj95;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X0_v55 (System.Collections.Generic.List`1<System.Single>)+1C]");
				object obj112 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X0_v55 (System.Collections.Generic.List`1<System.Single>)+10]");
				bool flag60 = (nint)0 == 0;
				obj3 = (UnityEngine.Object)num84;
				if (flag60)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X0_v55 (System.Collections.Generic.List`1<System.Single>)+18]");
				nint num85 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v37+18]");
				bool flag61 = num85 < 0;
				object obj113 = !flag61;
				if (obj113 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X0_v55 (System.Collections.Generic.List`1<System.Single>)+10]");
					nint num86 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X0_v55 (System.Collections.Generic.List`1<System.Single>)+18]");
					object obj114 = num86 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X0_v55 (System.Collections.Generic.List`1<System.Single>)+18]");
					object obj115 = (nint)0 + (nint)1;
					obj3 = (UnityEngine.Object)num84;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X9_v14+20]");
					object obj116 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1687 @ X8_v39+A8]");
					object obj117 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1689 @ X8_v40+70]");
					obj3 = (UnityEngine.Object)0;
					list7.AddWithResize(num5);
				}
				obj96++;
				if ((nint)obj96 != 24)
				{
					continue;
				}
				goto IL_1689;
			}
		}
		goto IL_1793;
	}

	private static void Box(Transform t, Vector3 middle, Vector3 e, Vector3 s, Action<Vector3, float> ball)
	{
		//IL_0010: Expected F4, but got I
		//IL_098b: Expected Obj, but got I
		//IL_09a3: Expected Obj, but got I
		//IL_0066: Invalid comparison between F4 and I
		//IL_058c: Expected F4, but got Obj
		//IL_05a4: Invalid comparison between F4 and I4
		//IL_05b3: Invalid comparison between F4 and I4
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected Obj, but got Unknown
		//IL_05d3: Expected Obj, but got F4
		//IL_0608: Expected Obj, but got I4
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected Obj, but got Unknown
		//IL_064c: Invalid comparison between F4 and I4
		//IL_065b: Invalid comparison between F4 and I4
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_0683: Expected Obj, but got F4
		//IL_06b8: Expected Obj, but got I4
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected Obj, but got Unknown
		//IL_0095: Expected F4, but got I
		//IL_00c4: Expected F4, but got I
		//IL_06fc: Invalid comparison between F4 and I4
		//IL_070b: Invalid comparison between F4 and I4
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected Obj, but got Unknown
		//IL_0733: Expected Obj, but got F4
		//IL_0768: Expected Obj, but got I4
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Expected Obj, but got Unknown
		//IL_077e: Expected I4, but got Obj
		//IL_00e6: Expected F4, but got I
		//IL_00f9: Expected Obj, but got I4
		//IL_0125: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I4
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected Obj, but got Unknown
		//IL_080a: Expected Obj, but got I4
		//IL_0226: Expected F8, but got I4
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected Obj, but got Unknown
		//IL_0245: Expected Obj, but got I4
		//IL_0842: Expected Obj, but got I4
		//IL_02f5: Expected F8, but got I4
		//IL_0312: Expected F8, but got I4
		//IL_0392: Expected VT, but got I4
		//IL_039f: Invalid comparison between VT and I4
		//IL_03ca: Expected VT, but got I
		//IL_03dc: Expected I4, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD0]");
		float num = 0f;
		float num3 = default;
		float num4 = default;
		float num2 = ((!(num3 < num4)) ? num4 : num3);
		float num5 = default;
		if (num5 < num2)
		{
			num2 = num5;
		}
		if (!(num2 < num))
		{
			float num6 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
			bool flag = !(num6 > 0f);
			num = num2;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
				num = 0f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v5+A0]");
		object obj3 = 0;
		float num7 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v7+14]");
		float num8 = num7 * 0f;
		float num9 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v7+C]");
		float num10 = num9 * 0f;
		float num11 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v7+10]");
		float num12 = num11 * 0f;
		float num13 = num4 - num8;
		float num14 = num5 - num10;
		float num15 = num3 - num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD99B]");
		bool flag2 = (nint)0 == 0;
		bool flag3 = !flag2;
		float num16 = (float)obj3;
		float num17 = num14 - (float)obj3;
		bool flag4 = num17 < 0f;
		bool flag5 = num17 == 0f;
		object obj4 = num14 ^ obj3;
		object obj5 = num14 ^ num17;
		object obj6 = obj4 & obj5;
		bool flag6 = (nint)obj6 < 0;
		bool flag7 = flag4 == flag6;
		object obj7 = !flag5;
		object obj8 = flag7 & obj7;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
			num16 = num14;
		}
		float num18 = num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v7+4]");
		float num19 = num18 - 0f;
		bool flag8 = num19 < 0f;
		bool flag9 = num19 == 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v7+4]");
		object obj10 = num15 ^ 0;
		object obj11 = num15 ^ num19;
		object obj12 = obj10 & obj11;
		bool flag10 = (nint)obj12 < 0;
		bool flag11 = flag8 == flag10;
		object obj13 = !flag9;
		object obj14 = flag11 & obj13;
		object obj15 = ~obj14;
		float num20;
		if (obj15 == null)
		{
			num20 = num15;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v7+4]");
			num20 = 0f;
		}
		float num21 = num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v7+8]");
		float num22 = num21 - 0f;
		bool flag12 = num22 < 0f;
		bool flag13 = num22 == 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v7+8]");
		object obj16 = num13 ^ 0;
		object obj17 = num13 ^ num22;
		object obj18 = obj16 & obj17;
		bool flag14 = (nint)obj18 < 0;
		bool flag15 = flag12 == flag14;
		object obj19 = !flag13;
		object obj20 = flag15 & obj19;
		float num23;
		if ((int)(~obj20) == 0)
		{
			num23 = num13;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v7+8]");
			num23 = 0f;
		}
		int num24 = Count(num16, num);
		int num25 = Count(num20, num);
		int num26 = Count(num23, num);
		object obj21 = num24 - 1;
		if (num24 < 1)
		{
			return;
		}
		object obj22 = num25 - 1;
		object obj23 = num26 - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		double num27 = (double)num26 + -1.0;
		double num28 = (double)num24 + -1.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		double num29 = (double)num25 + -1.0;
		Vector3 vector = middle;
		object obj24 = 0;
		int num30 = num26;
		int num31 = num24;
		int num32 = num26;
		double num33 = num29;
		float num34 = num20;
		object obj25 = default;
		int num41 = default;
		object obj35 = default;
		int num52 = default;
		object obj36 = default;
		Transform transform = default;
		do
		{
			if (num25 >= 1)
			{
				double num35 = (double)obj24 / num28;
				double num36 = num35 + num35;
				double num37 = num36 + -1.0;
				if (num24 == 1)
				{
					num37 = 0.0;
				}
				float num38 = num16 * (float)num37;
				float num39 = num38 / (float)obj25;
				float num40 = (float)num41 + num39;
				bool flag16 = flag3;
				Vector3 vector2 = vector;
				object obj26 = 0;
				int num42 = num30;
				int num43 = num31;
				int num44 = num32;
				float num45 = num34;
				int num46 = num24;
				bool flag26;
				do
				{
					bool flag17 = num26 < 1;
					num33 = num39;
					if (!flag17)
					{
						bool flag18 = obj26 == null;
						object obj27 = !flag18;
						object obj28 = ~obj27;
						bool flag19 = obj28 != null || obj24 == null;
						object obj29 = !flag19;
						object obj30 = ~obj29;
						bool flag20;
						bool flag21;
						if (obj30 == null)
						{
							object obj31 = obj24 - obj21;
							flag20 = (nint)obj31 < 0;
							object obj32 = obj24 ^ obj21;
							object obj33 = obj24 ^ obj31;
							object obj34 = obj32 & obj33;
							flag21 = (nint)obj34 < 0;
						}
						else
						{
							flag21 = false;
							flag20 = false;
						}
						bool flag22 = flag20 == flag21;
						double num47 = (double)obj26 / num29;
						double num48 = num47 + num47;
						double num49 = num48 + -1.0;
						if (num25 == 1)
						{
							num49 = 0.0;
						}
						float num50 = num20 * (float)num49;
						float num51 = num50 / (float)obj35;
						num45 = (float)num52 + num51;
						Vector3 vector3 = vector2;
						float num53 = num20;
						int num54 = num42;
						int num55 = 0;
						int num56 = num44;
						int num57 = num46;
						bool flag25;
						do
						{
							if (!flag22 && System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22))
							{
								flag16 = num55 == 0;
								if (!flag16)
								{
									bool flag23 = num55 >= (nint)obj23;
									num33 = num51;
									if (!flag23)
									{
										goto IL_044c;
									}
								}
							}
							bool flag24 = num26 == 1;
							double num58 = 0.0;
							if (!flag24)
							{
								double num59 = (double)num55 / num27;
								double num60 = num59 + num59;
								num58 = num60 + -1.0;
							}
							float num61 = num23 * (float)num58;
							float num62 = num61 / num14;
							num53 = (float)obj36 + num62;
							Vector3 vector4 = transform.TransformPoint((Vector3)0);
							flag16 = middle == (Vector3)(object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [middle @ X1 (UnityEngine.Vector3)+18]");
							num57 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [middle @ X1 (UnityEngine.Vector3)+28]");
							vector3 = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [middle @ X1 (UnityEngine.Vector3)+18] (should have been resolved before IL gen)");
							num54 = (int)num;
							num33 = num40;
							goto IL_044c;
							IL_044c:
							num43 = num55 + 1;
							flag25 = num26 != num43;
							vector2 = vector3;
							num42 = num54;
							num44 = num56;
							num46 = num57;
							num55 = num43;
							num51 = (float)num33;
						}
						while (flag25);
					}
					object obj37 = obj26 + 1;
					flag26 = (nint)obj37 != num25;
					flag3 = flag16;
					vector = vector2;
					num30 = num42;
					num31 = num43;
					num32 = num44;
					num34 = num45;
					obj26 = obj37;
					num39 = (float)num33;
				}
				while (flag26);
			}
			obj24++;
		}
		while ((nint)obj24 != num24);
	}

	private static int Count(float half, float r)
	{
		//IL_00d2: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I4
		//IL_006a: Invalid comparison between F4 and I4
		//IL_0123: Invalid comparison between F4 and I4
		//IL_0132: Invalid comparison between F4 and I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0153: Expected Obj, but got F4
		//IL_0188: Expected Obj, but got I4
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_0087: Expected F4, but got I4
		//IL_00a9: Expected I4, but got F4
		float num = r * 0.75f;
		if (num < half)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			float num2 = half + 1f;
			float num3 = ((num2 < 4f) ? (half + 1f) : 4f);
			float num4 = num3 - 2f;
			bool flag2 = num4 < 0f;
			bool flag3 = num4 == 0f;
			object obj4 = num3 ^ 2;
			object obj5 = num3 ^ num4;
			object obj6 = obj4 & obj5;
			bool flag4 = (nint)obj6 < 0;
			bool flag5 = flag2 == flag4;
			object obj7 = !flag3;
			object obj8 = flag5 & obj7;
			object obj9 = ~obj8;
			if (obj9 == null)
			{
				return (int)num3;
			}
			return 2;
		}
		return 1;
	}

	private static float Spread(int i, int n)
	{
		//IL_0018: Expected F4, but got I4
		bool flag = n == 1;
		float result = 0f;
		if (!flag)
		{
			double num = (double)n + -1.0;
			double num2 = (double)i / num;
			double num3 = num2 + num2;
			double num4 = num3 + -1.0;
			result = (float)num4;
		}
		return result;
	}

	private static Vector3 Abs(Vector3 v)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		return v;
	}

	private static List<Vector3> Furthest(Vector3[] points, Vector3 middle, int many)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I8
		//IL_0275: Expected Obj, but got I4
		//IL_07c4: Invalid comparison between VT and I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00a8: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_028a: Expected Obj, but got I
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02af: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I4
		//IL_02cd: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_0236: Expected Obj, but got I4
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_024c: Expected I4, but got Obj
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected Obj, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_0323: Expected Obj, but got I
		//IL_0339: Expected Obj, but got I
		//IL_0394: Expected Obj, but got I4
		//IL_0417: Expected Obj, but got I
		//IL_0427: Expected Obj, but got I
		//IL_043c: Expected VT, but got I
		//IL_07ec: Expected Obj, but got I8
		//IL_03b8: Expected Obj, but got I
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected Obj, but got Unknown
		//IL_03e3: Expected Obj, but got I
		//IL_0456: Expected Obj, but got I8
		//IL_045f: Expected Obj, but got I4
		//IL_06d2: Expected Obj, but got I8
		//IL_086c: Expected Obj, but got I4
		//IL_0599: Expected Obj, but got I
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected Obj, but got Unknown
		//IL_08c6: Expected Obj, but got I
		//IL_08e7: Expected Obj, but got I4
		//IL_04a2: Expected Obj, but got I4
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Expected Obj, but got Unknown
		//IL_0726: Invalid comparison between Obj and VT
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected Obj, but got Unknown
		//IL_0615: Expected Obj, but got I4
		//IL_04cd: Expected Obj, but got I
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Obj, but got Unknown
		//IL_0523: Expected Obj, but got I
		//IL_0819: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Expected Obj, but got Unknown
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Expected Obj, but got Unknown
		//IL_0644: Expected Obj, but got I4
		//IL_055a: Expected Obj, but got I
		//IL_066f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector3> list = default;
		list._002Ector();
		object obj3;
		object obj4;
		List<Vector3> list2 = default;
		if (points != null)
		{
			if (points.Length == 0)
			{
				goto IL_073d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			obj3 = points.Length & 0xFFFFFFFFL;
			if (points.Length < 1)
			{
				obj4 = 0;
				goto IL_07bb;
			}
			object obj5 = points + 40;
			object obj6 = list2 + 32;
			obj4 = 0;
			object obj7 = 0;
			object obj13 = default;
			object obj15 = default;
			object obj17 = default;
			while (list2 != null)
			{
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v9 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				bool flag = (nint)obj8 < 0;
				object obj9 = !flag;
				if (obj9 == null)
				{
					object obj10 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v9 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					bool flag2 = (nint)obj10 < 0;
					object obj11 = !flag2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X11_v12-8]");
					object obj12 = 0 - obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X11_v12-4]");
					object obj14 = 0 - obj15;
					object obj16 = obj5 - obj17;
					object obj18 = obj12 * obj12;
					object obj19 = obj14 * obj14;
					object obj20 = obj18 + obj19;
					object obj21 = obj16 * obj16;
					object obj22 = obj20 + obj21;
					if (obj11 == null)
					{
						object obj23 = (object)list2 + obj4;
						obj5 += 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X13_v7+20]");
						object obj24 = obj22 - 0;
						bool flag3 = (nint)obj24 < 0;
						bool flag4 = obj24 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X13_v7+20]");
						object obj25 = obj22 ^ 0;
						object obj26 = obj22 ^ obj24;
						object obj27 = obj25 & obj26;
						bool flag5 = (nint)obj27 < 0;
						bool flag6 = flag3 == flag5;
						object obj28 = !flag4;
						object obj29 = flag6 & obj28;
						if ((int)(~obj29) == 0)
						{
							obj4 = obj7;
						}
						obj7++;
						if (obj3 != obj7)
						{
							continue;
						}
						goto IL_07bb;
					}
				}
				goto IL_0742;
			}
		}
		goto IL_0750;
		IL_07bb:
		if (middle >= (object)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
			object obj30 = 0;
			object obj31 = points + 40;
			object obj32 = list2 + 32;
			object obj33 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
				object obj34 = !flag7;
				if (obj34 != null)
				{
					goto IL_0742;
				}
				if (list != null)
				{
					object obj35 = obj4 * 12;
					object obj36 = (object)points + obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
					object obj38 = (nint)0 + (nint)1;
					object obj39 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v10+18]");
						bool flag8 = num < 0;
						object obj40 = !flag8;
						if (obj40 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj41 = (nint)0 * (nint)12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj42 = 0 + obj41;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj43 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X9_v5+20]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X9_v5+28]");
							_ = 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X9_v6+20]");
							object obj44 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v14+A8]");
							object obj45 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v15+70]");
							list.AddWithResize((Vector3)0);
						}
						obj3 = points.Length & 0xFFFFFFFFL;
						if (points.Length >= 1)
						{
							object obj46 = obj31;
							obj4 = 4294967295L;
							object obj47 = 0;
							while (true)
							{
								object obj55;
								if (obj33 != null)
								{
									if (list2 == null)
									{
										break;
									}
									object obj48 = obj47;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v9 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									bool flag9 = (nint)obj48 < 0;
									object obj49 = !flag9;
									if (obj49 != null)
									{
										goto IL_0742;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X11_v8-8]");
									nint num2 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X9_v5+20]");
									object obj50 = num2 - 0;
									object obj51 = obj46;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X9_v5+28]");
									object obj52 = obj51 - 0;
									object obj53 = obj50 * obj50;
									object obj54 = obj52 * obj52;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
									obj55 = obj53 + obj54;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X26_v4+v156 @ X10_v13*4]");
									object obj56 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X26_v4+v156 @ X10_v13*4]");
									if (0 < (nint)obj55)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X26_v4+v156 @ X10_v13*4]");
										obj55 = 0;
									}
								}
								else
								{
									if (list2 == null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X11_v8-8]");
									nint num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X9_v5+20]");
									object obj57 = num3 - 0;
									object obj58 = obj46;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X9_v5+28]");
									object obj59 = obj58 - 0;
									object obj60 = obj57 * obj57;
									object obj56 = obj59 * obj59;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
									obj55 = obj60 + obj56;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v9 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								object obj61 = 0;
								object obj62 = obj47;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v9 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								bool flag10 = (nint)obj62 < 0;
								object obj63 = !flag10;
								if (obj63 != null)
								{
									goto IL_0742;
								}
								object obj64 = obj4 & 0x80000000L;
								bool flag11 = obj64 == null;
								object obj65 = !flag11;
								if (obj65 == null)
								{
									object obj66 = obj4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v9 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									bool flag12 = (nint)obj66 < 0;
									object obj67 = !flag12;
									if (obj67 != null)
									{
										goto IL_0742;
									}
									obj61 = (object)list2 + obj4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X12_v10+20]");
									object obj56 = 0;
									object obj68 = obj55;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X12_v10+20]");
									if ((nint)obj68 <= 0)
									{
										goto IL_0810;
									}
								}
								obj4 = obj47;
								goto IL_0810;
								IL_0810:
								obj47++;
								obj46 += 12;
								if (obj3 != obj47)
								{
									continue;
								}
								goto IL_084b;
							}
						}
						else if (list2 != null)
						{
							obj4 = 4294967295L;
							goto IL_084b;
						}
					}
				}
				goto IL_0750;
				IL_084b:
				object obj69 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v9 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				bool flag13 = (nint)obj69 < 0;
				object obj70 = !flag13;
				if (obj70 == null)
				{
					object obj71 = (object)list2 + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X10_v11+20]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
					if (num4 < 0)
					{
						break;
					}
					obj33++;
					if (obj33 == (object)middle)
					{
						break;
					}
					continue;
				}
				goto IL_0742;
			}
		}
		goto IL_073d;
		IL_073d:
		return list;
		IL_0750:
		return (List<Vector3>)(object)new NullReferenceException();
		IL_0742:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0750;
	}

	private Vector3 Point(int h)
	{
		//IL_024d: Expected Obj, but got I
		//IL_0255: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I4
		//IL_022e: Expected VT, but got Obj
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		bool flag = h == 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		UnityEngine.Object obj2 = (UnityEngine.Object)h;
		if (!flag)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v26+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = gt == null;
			bool flag4 = !flag3;
			obj2 = null;
			if (flag4)
			{
				object obj5;
				if (h != 0)
				{
					if ((object)gt == null)
					{
						goto IL_0220;
					}
					obj5 = gt + 56;
				}
				else
				{
					if ((object)gt == null)
					{
						goto IL_0220;
					}
					obj5 = gt + 48;
				}
				if (obj5 != null)
				{
					return ((Transform)obj5).position;
				}
				goto IL_0220;
			}
		}
		Camera main = Camera.main;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Component component;
		if (main != null)
		{
			Camera main2 = Camera.main;
			bool flag6 = (object)main2 == null;
			object obj8 = !flag6;
			component = main2;
			if (obj8 == null)
			{
				goto IL_0220;
			}
		}
		else
		{
			component = this;
		}
		Transform transform = component.transform;
		if ((object)transform != null)
		{
			Vector3 position = transform.position;
			Vector3 forward = transform.forward;
			Vector3 right = transform.right;
			return transform.up;
		}
		goto IL_0220;
		IL_0220:
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	private Quaternion Turn(int h)
	{
		//IL_020a: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_0247: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I4
		//IL_01eb: Expected VT, but got Obj
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		bool flag = h == 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		UnityEngine.Object obj2 = (UnityEngine.Object)h;
		Transform transform;
		if (!flag)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = gt == null;
			bool flag4 = !flag3;
			obj2 = null;
			if (flag4)
			{
				object obj5;
				if (h != 0)
				{
					if ((object)gt == null)
					{
						goto IL_01dd;
					}
					obj5 = gt + 64;
				}
				else
				{
					if ((object)gt == null)
					{
						goto IL_01dd;
					}
					obj5 = gt + 72;
				}
				transform = (Transform)obj5;
				if (obj5 != null)
				{
					goto IL_01cb;
				}
				goto IL_01dd;
			}
		}
		Camera main = Camera.main;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Component component;
		if (main != null)
		{
			Camera main2 = Camera.main;
			bool flag6 = (object)main2 == null;
			object obj8 = !flag6;
			component = main2;
			if (obj8 == null)
			{
				goto IL_01dd;
			}
		}
		else
		{
			component = this;
		}
		transform = component.transform;
		bool flag7 = (object)transform == null;
		object obj9 = !flag7;
		if (obj9 != null)
		{
			goto IL_01cb;
		}
		goto IL_01dd;
		IL_01cb:
		return transform.rotation;
		IL_01dd:
		NullReferenceException ex = new NullReferenceException();
		return (Quaternion)ex;
	}

	private void Record()
	{
		//IL_001a: Expected Obj, but got I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_006b: Expected I4, but got Obj
		//IL_00b8: Expected Obj, but got I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00f6: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_01c9: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I4
		//IL_0236: Expected Obj, but got I
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		float[] array = trailTime;
		object obj = head + 1;
		object obj2 = obj * 1717986919;
		object obj3 = obj2 >> 63;
		object obj4 = obj2 >> 33;
		object obj5 = obj4 + obj3;
		object obj6 = obj5 + obj5;
		int num = obj - obj6;
		int num2 = frames + 1;
		head = num;
		frames = num2;
		float time = Time.time;
		bool flag = num < array.Length;
		object obj7 = !flag;
		if (obj7 == null)
		{
			object obj8 = array + num;
			int num3 = 0;
			while (true)
			{
				Vector3[,] array2 = trailAt;
				Vector3 vector = Point(num3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X22_v5 (UnityEngine.Vector3[2])+10]");
				object obj9 = 0;
				bool flag2 = num3 < (nint)obj9;
				object obj10 = !flag2;
				if (obj10 != null)
				{
					break;
				}
				int num4 = head;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v13+10]");
				bool flag3 = (nint)num4 < (nint)0;
				object obj11 = !flag3;
				if (obj11 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v13+10]");
				object obj12 = (nint)0 * (nint)num3;
				object obj13 = head + obj12;
				object obj14 = obj13 * 12;
				object obj15 = (object)array2 + obj14;
				Quaternion[,] array3 = trailTurn;
				Quaternion quaternion = Turn(num3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X22_v6 (UnityEngine.Quaternion[2])+10]");
				object obj16 = 0;
				bool flag4 = num3 < (nint)obj16;
				object obj17 = !flag4;
				if (obj17 != null)
				{
					break;
				}
				int num5 = head;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v17+10]");
				bool flag5 = (nint)num5 < (nint)0;
				object obj18 = !flag5;
				if (obj18 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v17+10]");
				object obj19 = (nint)0 * (nint)num3;
				object obj20 = head + obj19;
				num3++;
				object obj21 = (object)array3 + obj20;
				if (num3 == 3)
				{
					return;
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private static bool Allowed(GillaItem item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_020d: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_01e3: Expected I4, but got Obj
		//IL_010d: Expected Obj, but got I4
		//IL_0172: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = item == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (MonsterPlayer.IsMonster)
			{
				if ((object)item != null)
				{
					bool flag5 = (byte)(~(item.ForMonsters__BackingField ? 1u : 0u)) != 0;
					object obj8 = !flag5;
					if (obj8 == null)
					{
						return false;
					}
					goto IL_0146;
				}
			}
			else if ((object)item != null)
			{
				goto IL_0146;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_01c7;
		IL_01c7:
		return true;
		IL_0146:
		if (~(item.StaffOnly__BackingField ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v14+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return ModMenuAccess.IsModerator;
		}
		goto IL_01c7;
	}

	private unsafe GillaItem Nearest(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_06fb: Expected Obj, but got I4
		//IL_0719: Expected Obj, but got I
		//IL_0721: Expected I, but got Obj
		//IL_0743: Expected Obj, but got I4
		//IL_0900: Expected Obj, but got I
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected VT, but got I4
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected I, but got Obj
		//IL_00fd: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got I
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected VT, but got I4
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected F8, but got Unknown
		//IL_0759: Expected VT, but got Obj
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected Obj, but got I4
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected Obj, but got I4
		//IL_0894: Expected Obj, but got I
		//IL_089c: Expected VT, but got Obj
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Expected Ref, but got Unknown
		//IL_08bf: Expected Obj, but got I4
		//IL_057c: Expected Obj, but got I4
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected Obj, but got Unknown
		//IL_0199: Expected Obj, but got I4
		//IL_0638: Invalid comparison between VT and I4
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected Obj, but got I4
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Invalid comparison between VT and I4
		//IL_01c0: Expected Obj, but got I4
		//IL_0671: Expected Obj, but got I4
		//IL_01f5: Expected Obj, but got I4
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got I4
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected F8, but got I4
		//IL_082b: Expected Obj, but got I4
		//IL_0843: Invalid comparison between F8 and I4
		//IL_0854: Expected Obj, but got I4
		//IL_02b7: Expected Obj, but got I8
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02d3: Expected Obj, but got I4
		//IL_02dc: Expected F8, but got I4
		//IL_07fb: Expected Obj, but got I4
		//IL_0804: Expected F8, but got I4
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got I4
		//IL_033a: Expected Obj, but got I
		//IL_0358: Expected Obj, but got I4
		//IL_035d: Expected I, but got Obj
		//IL_0366: Expected VT, but got I4
		//IL_04c7: Expected Obj, but got I4
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected Obj, but got Unknown
		//IL_0390: Expected I, but got Obj
		//IL_0399: Expected F8, but got I4
		//IL_03a2: Expected VT, but got I4
		//IL_04fc: Expected F8, but got I4
		//IL_03c1: Expected Obj, but got I
		//IL_03db: Expected Obj, but got I
		//IL_03f6: Expected VT, but got I4
		//IL_03f6: Expected Obj, but got I
		//IL_07ad: Expected Obj, but got I4
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Invalid comparison between F8 and Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected F8, but got Unknown
		//IL_07d0: Expected Obj, but got I
		//IL_07d5: Expected I, but got Obj
		//IL_07dd: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isMonster = MonsterPlayer.IsMonster;
		bool flag2 = !isMonster;
		double num2 = default;
		double num = num2;
		GillaItem gillaItem2 = default;
		Enumerator<, > val;
		GillaHands gillaHands;
		GillaItem gillaItem;
		if (!flag2)
		{
			Transform transform = base.transform;
			bool flag3 = (object)transform == null;
			gillaItem = gillaItem2;
			val = (Enumerator<, >)0;
			num = num2;
			Vector3 vector = (Vector3)0;
			gillaHands = this;
			if (flag3)
			{
				goto IL_05e9;
			}
			Vector3 lossyScale = transform.lossyScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			num = 1.0;
			vector = (Vector3)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
		gillaHands = (GillaHands)0;
		nint num3 = (nint)gillaHands;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v11 (Il2CppClass<GillaHands>)+E4]");
		bool flag4 = (nint)0 == 0;
		object obj4 = !flag4;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num3 = (nint)gillaHands;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v11 (Il2CppClass<GillaHands>)+A0]");
		object obj5 = 0;
		bool flag5 = obj5 == null;
		gillaItem = gillaItem2;
		val = (Enumerator<, >)0;
		object obj9 = default;
		Enumerator<, > val3 = default;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5268]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj7 = 0;
			double num4 = (double)reach * 1.0;
			Enumerator<, > enumerator = ((List<System.__Canon>)obj5).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj8 = 0;
			object obj10 = default;
			obj9 = obj10;
			Enumerator<, > val2 = (Enumerator<, >)(ref val);
			Enumerator<, > val4 = default;
			val3 = val4;
			GillaItem gillaItem3 = null;
			Enumerator<, > val6 = default;
			GillaItem gillaItem4;
			object obj14;
			Enumerator<, > val5;
			while (true)
			{
				double num5 = (double)val2;
				double num6 = num4;
				while (true)
				{
					Vector3 vector = (Vector3)obj6;
					if (!val.MoveNext())
					{
						break;
					}
					if ((object)gillaItem2 != null)
					{
						bool flag6 = (byte)(~(gillaItem2.Gone__BackingField ? 1u : 0u)) != 0;
						object obj11 = !flag6;
						if (obj11 != null)
						{
							continue;
						}
						bool flag7 = (byte)(~(gillaItem2.Swallowed__BackingField ? 1u : 0u)) != 0;
						object obj12 = !flag7;
						if (obj12 != null)
						{
							continue;
						}
						bool heldByOther = gillaItem2.HeldByOther;
						bool flag8 = !heldByOther;
						object obj13 = !flag8;
						if (obj13 != null || !Allowed(gillaItem2))
						{
							continue;
						}
						Collider[] array = gillaItem2.Colliders__BackingField;
						bool flag9 = gillaItem2.Colliders__BackingField == null;
						gillaItem4 = gillaItem3;
						gillaItem = null;
						val = val4;
						obj14 = 0;
						val5 = (Enumerator<, >)(ref val);
						if (flag9)
						{
							goto IL_0607;
						}
						if (array.Length < 1)
						{
							num6 = 2139095039.0;
							goto IL_0812;
						}
						object obj15 = array.Length & 0xFFFFFFFFL;
						gillaHands = (GillaHands)(gillaItem2.Colliders__BackingField + 32);
						object obj16 = 0;
						num6 = 2139095039.0;
						while (true)
						{
							bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15);
							object obj17 = !flag10;
							num5 = 2139095039.0;
							if (obj17 != null)
							{
								break;
							}
							object obj18 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X0_v29+E4]");
							bool flag11 = (nint)0 == 0;
							object obj19 = !flag11;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X19_v10 (GillaHands)+v412 @ X24_v7*8]");
							bool flag12 = (UnityEngine.Object)0 == null;
							bool flag13 = !flag12;
							object obj20 = !flag13;
							nint num7 = unchecked((nint)null);
							vector = (Vector3)0;
							if (obj20 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X19_v10 (GillaHands)+v412 @ X24_v7*8]");
								bool flag14 = (nint)0 == 0;
								num7 = unchecked((nint)null);
								num5 = 2139095039.0;
								vector = (Vector3)0;
								if (flag14)
								{
									goto IL_05b3;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X19_v10 (GillaHands)+v412 @ X24_v7*8]");
								bool flag15 = ((Collider)0).enabled;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X19_v10 (GillaHands)+v412 @ X24_v7*8]");
								((Collider)0).enabled = true;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X19_v10 (GillaHands)+v412 @ X24_v7*8]");
								Vector3 vector2 = ((Collider)0).ClosestPoint((Vector3)0);
								object obj21 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ X0_v40+E4]");
								bool flag16 = (nint)0 == 0;
								object obj22 = !flag16;
								if (obj22 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								float num8 = (float)val6 - (float)val6;
								double num9 = num2 - num2;
								obj9 = obj10 - obj10;
								float num10 = num8 * num8;
								double num11 = num9 * num9;
								double num12 = (double)num10 + num11;
								num = (double)obj9 * (double)obj9;
								val3 = (Enumerator<, >)(num + num12);
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								if (!(num6 < (double)val3))
								{
									num6 = (double)val3;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X19_v10 (GillaHands)+v412 @ X24_v7*8]");
								((Collider)0).enabled = flag15;
								num7 = unchecked((nint)null);
								vector = (Vector3)flag15;
							}
							obj15 = array.Length;
							obj16++;
							if ((nint)obj16 < array.Length)
							{
								continue;
							}
							goto IL_04f3;
						}
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
					}
					IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
					goto IL_05b3;
					IL_05b3:
					NullReferenceException ex3 = new NullReferenceException();
					gillaItem4 = gillaItem3;
					gillaItem = null;
					val = val4;
					obj14 = 0;
					val5 = (Enumerator<, >)(ref val);
					goto IL_05e9;
					IL_04f3:
					num5 = 2139095039.0;
					goto IL_0812;
					IL_0812:
					bool flag17 = num6 < num4;
					object obj23 = !flag17;
					double num13 = num6 - num4;
					bool flag18 = num13 == 0.0;
					object obj24 = !flag18;
					object obj25 = obj23 & obj24;
					if (obj25 == null)
					{
						goto IL_050f;
					}
				}
				break;
				IL_050f:
				val2 = (Enumerator<, >)num5;
				num4 = num6;
				gillaItem3 = gillaItem2;
			}
			gillaItem4 = gillaItem3;
			gillaItem = null;
			val = val4;
			obj14 = 0;
			val5 = (Enumerator<, >)(ref val);
			object obj26 = 0;
			object obj30 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5260]");
				object obj27 = 0;
				Vector3 vector = (Vector3)obj27;
				((Enumerator<, >*)val5)->Dispose();
				bool flag19 = obj26 == null;
				object obj28 = !flag19;
				if (obj28 == null)
				{
					bool flag20 = (object)gillaItem == null;
					object obj29 = !flag20;
					OutOfMemoryException ex4 = (OutOfMemoryException)val5;
					if (obj29 == null)
					{
						return gillaItem4;
					}
				}
				else
				{
					OutOfMemoryException ex4 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if (vector == (Vector3)(object)2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					gillaItem = (GillaItem)1;
					obj26 = obj14;
					continue;
				}
				if (vector != (Vector3)(object)1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj26 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj14 = obj30;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D3D4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			GillaItem result = default;
			return result;
		}
		goto IL_05e9;
		IL_0607:
		throw new NullReferenceException();
		IL_05e9:
		NullReferenceException ex5 = new NullReferenceException();
		obj9 = obj9;
		val3 = val3;
		goto IL_0607;
	}

	private static Vector3 NearestOn(GillaItem item, Vector3 at)
	{
		//IL_030d: Expected VT, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I8
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00e2: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_0379: Expected Obj, but got I4
		//IL_0124: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I4
		//IL_0176: Expected I, but got Obj
		//IL_0187: Expected VT, but got I4
		//IL_0334: Expected Obj, but got I4
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_01cb: Expected Obj, but got I
		//IL_01e5: Expected Obj, but got I
		//IL_0200: Expected VT, but got I4
		//IL_0200: Expected Obj, but got I
		//IL_0219: Expected Obj, but got I
		//IL_029c: Expected I, but got Obj
		//IL_02b4: Expected VT, but got I
		//IL_02c7: Expected I, but got Obj
		//IL_02e7: Expected VT, but got I
		Vector3 result;
		if ((object)item != null)
		{
			Transform transform = item.transform;
			if ((object)transform != null)
			{
				result = transform.position;
				Collider[] array = item.Colliders__BackingField;
				if (item.Colliders__BackingField != null)
				{
					if (array.Length < 1)
					{
						goto IL_02ec;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj = 0;
					object obj2 = array.Length & 0xFFFFFFFFL;
					object obj3 = item.Colliders__BackingField + 32;
					object obj5 = default;
					object obj4 = obj5;
					object obj7 = default;
					object obj6 = obj7;
					object obj9 = default;
					object obj8 = obj9;
					object obj10 = 2139095039;
					object obj11 = 0;
					bool flag = false;
					while (true)
					{
						bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
						object obj12 = !flag2;
						if (obj12 == null)
						{
							object obj13 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v10+E4]");
							bool flag3 = (nint)0 == 0;
							object obj14 = !flag3;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X24_v4+v85 @ X22_v5*8]");
							bool flag4 = (UnityEngine.Object)0 == null;
							bool flag5 = !flag4;
							object obj15 = !flag5;
							nint num = unchecked((nint)null);
							flag = false;
							result = (Vector3)flag4;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X24_v4+v85 @ X22_v5*8]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X24_v4+v85 @ X22_v5*8]");
								bool flag6 = ((Collider)0).enabled;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X24_v4+v85 @ X22_v5*8]");
								((Collider)0).enabled = true;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X24_v4+v85 @ X22_v5*8]");
								Vector3 vector = ((Collider)0).ClosestPoint((Vector3)0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X24_v4+v85 @ X22_v5*8]");
								((Collider)0).enabled = flag6;
								object obj16 = obj9 - obj9;
								object obj17 = obj7 - obj7;
								obj4 = obj5 - obj5;
								object obj18 = obj16 * obj16;
								object obj19 = obj17 * obj17;
								object obj20 = obj18 + obj19;
								obj6 = obj4 * obj4;
								obj8 = obj6 + obj20;
								bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
								num = unchecked((nint)null);
								flag = flag6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X24_v4+v85 @ X22_v5*8]");
								result = (Vector3)0;
								if (!flag7)
								{
									num = unchecked((nint)null);
									obj10 = obj8;
									flag = flag6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X24_v4+v85 @ X22_v5*8]");
									result = (Vector3)0;
								}
							}
							obj2 = array.Length;
							obj11++;
							if ((nint)obj11 < array.Length)
							{
								continue;
							}
							goto IL_02ec;
						}
						IndexOutOfRangeException ex = new IndexOutOfRangeException();
						break;
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (Vector3)ex2;
		IL_02ec:
		return result;
	}

	private unsafe void Take(int h, GillaItem item)
	{
		//IL_0ecd: Expected Obj, but got I
		//IL_0edd: Expected Obj, but got I
		//IL_0f3e: Expected VT, but got Obj
		//IL_0020: Expected Obj, but got I4
		//IL_0048: Expected VT, but got Obj
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I
		//IL_00dd: Expected VT, but got I4
		//IL_00e5: Expected I4, but got Obj
		//IL_0140: Expected Obj, but got VT
		//IL_010b: Expected VT, but got I4
		//IL_0279: Expected VT, but got I4
		//IL_02b7: Expected I, but got Obj
		//IL_0329: Expected Obj, but got I4
		//IL_0338: Expected Obj, but got I4
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected Obj, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected Obj, but got Unknown
		//IL_0432: Expected VT, but got I4
		//IL_0432: Expected VT, but got I4
		//IL_0499: Expected Obj, but got I4
		//IL_04a8: Expected Obj, but got I4
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected Obj, but got Unknown
		//IL_0512: Expected Obj, but got I4
		//IL_059d: Expected Obj, but got I4
		//IL_05ac: Expected Obj, but got I4
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected Obj, but got Unknown
		//IL_0616: Expected Obj, but got I4
		//IL_0720: Expected Obj, but got I4
		//IL_072f: Expected Obj, but got I4
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Expected Obj, but got Unknown
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Expected Obj, but got Unknown
		//IL_0ddc: Expected Obj, but got I4
		//IL_0e1a: Expected VT, but got I4
		//IL_094b: Expected Obj, but got I4
		//IL_095a: Expected Obj, but got I4
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected Obj, but got Unknown
		//IL_0e51: Expected Obj, but got I4
		//IL_09bc: Expected Obj, but got I4
		//IL_09db: Expected F8, but got I
		//IL_09eb: Expected F8, but got I
		//IL_09fb: Expected F8, but got I
		//IL_0a11: Expected VT, but got I
		//IL_0a11: Expected VT, but got I4
		//IL_102c: Expected F4, but got I
		//IL_102c: Expected F4, but got I
		//IL_0add: Expected Obj, but got I4
		//IL_0aec: Expected Obj, but got I4
		//IL_0b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b11: Expected Obj, but got Unknown
		//IL_0a73: Expected I, but got Obj
		//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3e: Expected Obj, but got Unknown
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected Obj, but got Unknown
		//IL_0b89: Expected I4, but got Obj
		//IL_0bb2: Expected Obj, but got I4
		//IL_0bc1: Expected Obj, but got I4
		//IL_0be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be6: Expected Obj, but got Unknown
		//IL_0bf6: Expected I4, but got Obj
		//IL_0c0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c13: Expected Obj, but got Unknown
		//IL_0c23: Expected Obj, but got I
		//IL_0c33: Expected Obj, but got I
		//IL_0c3b: Expected VT, but got Obj
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c53: Expected Obj, but got Unknown
		//IL_0c96: Expected Obj, but got I
		//IL_0c9e: Expected VT, but got Obj
		//IL_0c81: Expected Obj, but got I4
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf0: Expected Obj, but got Unknown
		//IL_0d41: Expected Obj, but got I4
		//IL_0d50: Expected Obj, but got I4
		//IL_0d70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d75: Expected Obj, but got Unknown
		//IL_0d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
		object obj2 = 0;
		GillaItem gillaItem = item;
		int num = h;
		int num2 = 0;
		double num4 = default;
		double num6 = default;
		double num8 = default;
		double num10 = default;
		Quaternion rotation = default;
		object obj30 = default;
		IntPtr intPtr = default;
		object obj51 = default;
		object obj52 = default;
		object obj53 = default;
		object obj55 = default;
		IndexOutOfRangeException ex = default;
		XRNode node;
		while (true)
		{
			GillaItem[] array = holding;
			bool flag = holding == null;
			double num3 = num4;
			double num5 = num6;
			double num7 = num8;
			double num9 = num10;
			Vector3 vector = (Vector3)gillaItem;
			double num21;
			if (!flag)
			{
				bool flag2 = num2 < array.Length;
				object obj3 = !flag2;
				num3 = num4;
				num5 = num6;
				num7 = num8;
				num9 = num10;
				vector = (Vector3)gillaItem;
				if (obj3 != null)
				{
					goto IL_0e99;
				}
				object obj4 = obj;
				object obj5 = holding + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v8+20]");
				bool flag4 = (UnityEngine.Object)0 == item;
				bool flag5 = !flag4;
				vector = (Vector3)0;
				num = (int)item;
				if (!flag5)
				{
					LetGo(num2, thrown: false);
					vector = (Vector3)0;
					num = num2;
				}
				num2++;
				bool flag6 = num2 != 3;
				gillaItem = (GillaItem)vector;
				if (flag6)
				{
					continue;
				}
				Vector3 vector2 = Point(h);
				bool flag7 = (object)item == null;
				num3 = num4;
				num5 = num6;
				num7 = num8;
				num9 = num10;
				num = h;
				if (!flag7)
				{
					Transform transform = item.transform;
					bool flag8 = (object)transform == null;
					num3 = num4;
					num5 = num6;
					num7 = num8;
					num9 = num10;
					num = 0;
					if (!flag8)
					{
						Vector3 position = transform.position;
						double num11;
						double num12;
						double num13;
						if (h == 2)
						{
							num11 = num10;
							num12 = num8;
							num13 = num6;
						}
						else
						{
							double num14 = num10 + num10;
							double num15 = num8 + num8;
							double num16 = num6 + num6;
							Vector3 vector3 = NearestOn(item, (Vector3)0);
							num11 = num14 - num10;
							num12 = num15 - num8;
							num13 = num16 - num6;
						}
						GillaItem[] array2 = holding;
						bool flag9 = holding == null;
						num3 = num4;
						num5 = num6;
						num7 = num8;
						num9 = num10;
						num = 0;
						if (!flag9)
						{
							nint num17 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X8_v9 (Il2CppClass<GillaItem[]>)+40]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag10 = ex == null;
							num3 = num4;
							num5 = num6;
							num7 = num8;
							num9 = num10;
							if (flag10)
							{
								goto IL_0ea7;
							}
							bool flag11 = array2.Length < h;
							object obj7 = !flag11;
							object obj8 = array2.Length - h;
							bool flag12 = obj8 == null;
							object obj9 = ~obj7;
							object obj10 = obj9 | flag12;
							num3 = num4;
							num5 = num6;
							num7 = num8;
							num9 = num10;
							if (obj10 != null)
							{
								goto IL_0e99;
							}
							object obj11 = holding + h;
							object obj12 = obj11 + 32;
							obj12 = item;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							item.Take(h);
							Quaternion quaternion = Turn(h);
							Vector3[] array3 = heldAt;
							Quaternion quaternion2 = Quaternion.Internal_Inverse(ref rotation);
							double num18 = num11 - num10;
							double num19 = num12 - num8;
							double num20 = num13 - num6;
							Vector3 vector4 = (Quaternion)0 * (Vector3)0;
							bool flag13 = heldAt == null;
							num3 = num4;
							num5 = num6;
							num7 = num8;
							num9 = num10;
							num = 0;
							if (!flag13)
							{
								bool flag14 = array3.Length < h;
								object obj13 = !flag14;
								object obj14 = array3.Length - h;
								bool flag15 = obj14 == null;
								object obj15 = ~obj13;
								object obj16 = obj15 | flag15;
								num3 = num4;
								num5 = num6;
								num7 = num8;
								num9 = num10;
								num = 0;
								if (obj16 != null)
								{
									goto IL_0e99;
								}
								object obj17 = h * 12;
								object obj18 = (object)heldAt + obj17;
								Vector3[] array4 = settling;
								bool flag16 = settling == null;
								num3 = num4;
								num5 = num6;
								num7 = num8;
								num9 = num10;
								num = 0;
								if (!flag16)
								{
									bool flag17 = array4.Length < h;
									object obj19 = !flag17;
									object obj20 = array4.Length - h;
									bool flag18 = obj20 == null;
									object obj21 = ~obj19;
									object obj22 = obj21 | flag18;
									num3 = num4;
									num5 = num6;
									num7 = num8;
									num9 = num10;
									num = 0;
									if (obj22 != null)
									{
										goto IL_0e99;
									}
									object obj23 = h * 12;
									object obj24 = (object)settling + obj23;
									num7 = num8 - num12;
									num21 = num10 - num11;
									num5 = num6 - num13;
									Quaternion[] array5 = heldTurn;
									Quaternion quaternion3 = Quaternion.Internal_Inverse(ref rotation);
									Transform transform2 = item.transform;
									bool flag19 = (object)transform2 == null;
									num3 = num4;
									num9 = num21;
									num = 0;
									if (!flag19)
									{
										Quaternion rotation2 = transform2.rotation;
										bool flag20 = heldTurn == null;
										num3 = num4;
										num9 = num21;
										num = 0;
										if (!flag20)
										{
											bool flag21 = array5.Length < h;
											object obj25 = !flag21;
											object obj26 = array5.Length - h;
											bool flag22 = obj26 == null;
											object obj27 = ~obj25;
											object obj28 = obj27 | flag22;
											num3 = num4;
											num9 = num21;
											num = 0;
											if (obj28 != null)
											{
												goto IL_0e99;
											}
											object obj29 = heldTurn + h;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction TRN2 not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
											double num22 = num21 * (double)obj30;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
											double num23 = num4 * num21;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
											num3 = num21 * num4;
											double num24 = num22 + num23;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
											double num25 = num22 - num23;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
											num18 = num24 + num3;
											num5 = num25 - num3;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
											double num26 = num3 * num21;
											num9 = num18 - num26;
											bool flag23 = h > 1;
											num20 = num21;
											num19 = num4;
											if (flag23)
											{
												goto IL_0f9e;
											}
											HeldShape[] array6 = shapes;
											Quaternion quaternion4 = Quaternion.Internal_Inverse(ref rotation);
											Vector3[] array7 = heldAt;
											bool flag24 = heldAt == null;
											num20 = num21;
											num19 = num4;
											num7 = num21;
											num = 0;
											if (!flag24)
											{
												bool flag25 = array7.Length < h;
												object obj31 = !flag25;
												object obj32 = array7.Length - h;
												bool flag26 = obj32 == null;
												object obj33 = ~obj31;
												object obj34 = obj33 | flag26;
												num20 = num21;
												num19 = num4;
												num7 = num21;
												num = 0;
												if (obj34 != null)
												{
													goto IL_0e99;
												}
												object obj35 = h * 12;
												object obj36 = (object)heldAt + obj35;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v25+20]");
												num18 = 0.0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v25+24]");
												num19 = 0.0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v25+28]");
												num20 = 0.0;
												HeldShape heldShape = ShapeOf(item, (Quaternion)0, vector, (Vector3)(nint)intPtr);
												bool flag27 = shapes == null;
												num7 = num21;
												num = 0;
												if (!flag27)
												{
													bool flag28 = heldShape == null;
													int num27 = 0;
													if (!flag28)
													{
														nint num28 = (nint)array6;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v36 (Il2CppClass<GorillaLocomotion.HeldShape[]>)+40]");
														num27 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
														bool flag29 = ex == null;
														num7 = num21;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v36 (Il2CppClass<GorillaLocomotion.HeldShape[]>)+40]");
														num = 0;
														if (flag29)
														{
															goto IL_0ea7;
														}
													}
													bool flag30 = array6.Length < h;
													object obj37 = !flag30;
													object obj38 = array6.Length - h;
													bool flag31 = obj38 == null;
													object obj39 = ~obj37;
													object obj40 = obj39 | flag31;
													num7 = num21;
													num = num27;
													if (obj40 != null)
													{
														goto IL_0e99;
													}
													object obj41 = shapes + h;
													object obj42 = obj41 + 32;
													obj42 = heldShape;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													HeldShape[] array8 = shapes;
													bool flag32 = shapes == null;
													num7 = num21;
													num = (int)heldShape;
													if (!flag32)
													{
														bool flag33 = array8.Length < h;
														object obj43 = !flag33;
														object obj44 = array8.Length - h;
														bool flag34 = obj44 == null;
														object obj45 = ~obj43;
														object obj46 = obj45 | flag34;
														num7 = num21;
														num = (int)heldShape;
														if (obj46 != null)
														{
															goto IL_0e99;
														}
														object obj47 = shapes + h;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1138]");
														object obj48 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ X8_v29+20]");
														object obj49 = 0;
														vector = (Vector3)obj48;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
														object obj50 = obj51 & 1;
														if (obj50 != null)
														{
															num = (int)(&obj52);
															obj53 = 1;
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1140]");
															object obj54 = 0;
															vector = (Vector3)obj54;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
															num = (int)(&obj55);
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ X8_v29+20]");
														bool flag35 = (nint)0 == 0;
														num7 = num21;
														if (!flag35)
														{
															object obj56 = obj53 & 1;
															bool[] array9 = knocking;
															bool flag36 = knocking == null;
															num7 = num21;
															if (!flag36)
															{
																bool flag37 = array9.Length < h;
																object obj57 = !flag37;
																object obj58 = array9.Length - h;
																bool flag38 = obj58 == null;
																object obj59 = ~obj57;
																object obj60 = obj59 | flag38;
																num7 = num21;
																if (obj60 != null)
																{
																	goto IL_0e99;
																}
																object obj61 = knocking + h;
																_ = 1;
																goto IL_0f9e;
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
			goto IL_0e8b;
			IL_0e99:
			ex = new IndexOutOfRangeException();
			goto IL_0ea7;
			IL_0f9e:
			Fingers(h, 1f);
			Transform transform3 = item.transform;
			bool flag39 = (object)transform3 == null;
			num7 = num21;
			num9 = 1.0;
			num = 0;
			if (!flag39)
			{
				Vector3 position2 = transform3.position;
				object obj62 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X0_v43+E4]");
				bool flag40 = (nint)0 == 0;
				object obj63 = !flag40;
				if (obj63 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Sfx.Play(pickUps, (Vector3)0, 1f, (float)num21, (float)num5);
				if (h <= 1)
				{
					bool flag41 = h == 0;
					object obj64 = !flag41;
					object obj65 = ~obj64;
					node = ((obj65 != null) ? ((XRNode)4) : ((XRNode)5));
					break;
				}
				return;
			}
			goto IL_0e8b;
			IL_0ea7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			throw new ArgumentNullException();
			IL_0e8b:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0e99;
		}
		UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
		nint num29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		UnityEngine.XR.InputDevice inputDevice = default;
		bool flag42 = inputDevice.SendHapticImpulse(0u, num29, 0f);
	}

	private unsafe void LetGo(int h, bool thrown)
	{
		//IL_0020: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_0098: Expected Obj, but got I4
		//IL_02b8: Expected Obj, but got I4
		//IL_02fd: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I4
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_08e3: Expected Obj, but got I
		//IL_08fb: Expected Obj, but got I
		//IL_0903: Expected VT, but got Obj
		//IL_091a: Expected VT, but got Obj
		//IL_0922: Expected VT, but got Obj
		//IL_092b: Expected Obj, but got I4
		//IL_0361: Expected Obj, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0173: Expected Obj, but got I4
		//IL_01a7: Expected Obj, but got I4
		//IL_03ad: Expected F4, but got I
		//IL_03bd: Expected F4, but got I
		//IL_032a: Expected Obj, but got Ref
		//IL_0676: Expected Obj, but got I
		//IL_068e: Expected Obj, but got I
		//IL_06ad: Expected VT, but got Ref
		//IL_03f7: Expected F4, but got I
		//IL_0407: Expected F4, but got I
		//IL_06d9: Expected VT, but got I
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected Obj, but got Unknown
		//IL_070b: Expected Obj, but got I4
		//IL_071b: Expected F4, but got I
		//IL_072b: Expected F4, but got I
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_07a5: Expected Obj, but got I
		//IL_07cf: Expected Obj, but got I4
		//IL_08bb: Expected Obj, but got I4
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_0808: Expected F4, but got VT
		//IL_0808: Expected VT, but got I4
		//IL_094f: Expected Obj, but got VT
		//IL_09bb: Invalid comparison between F4 and I
		//IL_09e4: Expected VT, but got I4
		//IL_081d: Expected Obj, but got I
		//IL_0847: Expected Obj, but got I4
		//IL_04bd: Expected Obj, but got I
		//IL_04e7: Expected Obj, but got I4
		//IL_0524: Expected VT, but got Ref
		//IL_0547: Expected F4, but got I
		//IL_0557: Expected F4, but got I
		//IL_056f: Expected F4, but got I
		//IL_057f: Expected F4, but got I
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected Obj, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected Obj, but got Unknown
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected VT, but got Unknown
		//IL_061f: Expected VT, but got I4
		//IL_062f: Expected F4, but got I
		//IL_063f: Expected F4, but got I
		GillaItem[] array = holding;
		if (holding == null)
		{
			goto IL_0874;
		}
		bool flag = array.Length < h;
		object obj = !flag;
		object obj2 = array.Length - h;
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag2;
		object obj7;
		Vector3 vector;
		float pitchMax;
		float pitchMin;
		ref RaycastHit reference;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj5 = 0;
			object obj6 = holding + h;
			obj7 = obj6 + 32;
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag3 = h > 1;
			bool flag4 = thrown;
			if (!flag3)
			{
				HeldShape[] array2 = shapes;
				if (shapes == null)
				{
					goto IL_0874;
				}
				bool flag5 = array2.Length < h;
				object obj8 = !flag5;
				object obj9 = array2.Length - h;
				bool flag6 = obj9 == null;
				object obj10 = ~obj8;
				object obj11 = obj10 | flag6;
				if (obj11 != null)
				{
					goto IL_0882;
				}
				object obj12 = shapes + h;
				object obj13 = obj12 + 32;
				obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj14 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X0_v65+E4]");
				bool flag7 = (nint)0 == 0;
				object obj15 = !flag7;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag8 = gt != null;
				bool flag9 = !flag8;
				flag4 = false;
				if (!flag9)
				{
					object obj16;
					if (h != 0)
					{
						if ((object)gt == null)
						{
							goto IL_0874;
						}
						obj16 = gt + 320;
					}
					else
					{
						if ((object)gt == null)
						{
							goto IL_0874;
						}
						obj16 = gt + 312;
					}
					obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					flag4 = false;
				}
			}
			Fingers(h, 0f);
			object obj17 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v11+E4]");
			bool flag10 = (nint)0 == 0;
			object obj18 = !flag10;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag11 = (UnityEngine.Object)obj7 == null;
			bool flag12 = !flag11;
			object obj19 = !flag12;
			if (obj19 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj20 = 0;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v13+A0]");
			object obj22 = 0;
			vector = (Vector3)obj22;
			bool flag13 = !thrown;
			Vector3 spin = (Vector3)obj22;
			Vector3 velocity = (Vector3)obj22;
			object obj23 = 0;
			int num = 0;
			if (!flag13)
			{
				Throw(h, out velocity, out spin);
				obj23 = (object)(&velocity);
				num = h;
			}
			object obj24 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v18+E4]");
			bool flag14 = (nint)0 == 0;
			object obj25 = !flag14;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag15 = gt != null;
			bool flag16 = h > 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v14+8]");
			pitchMax = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v14+4]");
			pitchMin = 0f;
			int num2 = (int)(&spin);
			reference = ref *(RaycastHit*)null;
			if (!flag16)
			{
				bool flag17 = !flag15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v14+8]");
				pitchMax = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v14+4]");
				pitchMin = 0f;
				num2 = (int)(&spin);
				reference = ref *(RaycastHit*)null;
				if (!flag17)
				{
					Vector3 vector2 = Point(h);
					if (obj7 != null)
					{
						Transform transform = ((Component)obj7).transform;
						if ((object)transform != null)
						{
							Vector3 position = transform.position;
							Player player = gt;
							if ((object)gt != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
								object obj26 = 0;
								object obj27 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X0_v49+E4]");
								bool flag18 = (nint)0 == 0;
								object obj28 = !flag18;
								if (obj28 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Vector3 vector3 = default;
								QueryTriggerInteraction queryTriggerInteraction = default;
								bool flag19 = Physics.Linecast((Vector3)(&vector3), (Vector3)player.locomotionEnabledLayers, out *(RaycastHit*)1, 0, queryTriggerInteraction);
								bool flag20 = !flag19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v14+8]");
								float num3 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v14+4]");
								float num4 = 0f;
								Vector3 vector4 = vector;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v14+8]");
								pitchMax = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v14+4]");
								pitchMin = 0f;
								num2 = 0;
								reference = ref *(RaycastHit*)1;
								if (!flag20)
								{
									Transform transform2 = ((Component)obj7).transform;
									if ((object)transform2 == null)
									{
										goto IL_0874;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
									object obj30 = default;
									object obj29 = obj30 * vector;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
									object obj32 = default;
									object obj31 = obj32 * 0;
									vector = vector3 + obj29;
									object obj33 = default;
									pitchMax = (float)obj33 + (float)obj31;
									transform2.position = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v14+8]");
									num3 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v14+4]");
									num4 = 0f;
									vector4 = vector3;
									float num5 = default;
									pitchMin = num5;
									num2 = 0;
									reference = ref *(RaycastHit*)1;
								}
								goto IL_0666;
							}
						}
					}
					goto IL_0874;
				}
			}
			goto IL_0666;
		}
		goto IL_0882;
		IL_0882:
		throw new IndexOutOfRangeException();
		IL_0874:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0882;
		IL_0666:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51C0]");
		object obj34 = 0;
		object obj35 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v19+A0]");
		object obj36 = 0;
		object obj37 = obj36;
		bool flag21 = obj36 == null;
		Vector3 spin2 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		if (!flag21)
		{
			Vector3 vector5 = Point(h);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X22_v8+28]");
			spin2 = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v249 @ X22_v8+18] (should have been resolved before IL gen)");
			object obj39 = default;
			object obj38 = obj39 & 1;
			bool flag22 = obj38 == null;
			object obj40 = !flag22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v14+8]");
			float num3 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v14+4]");
			float num4 = 0f;
			Vector3 vector4 = vector;
			if (obj40 != null)
			{
				return;
			}
		}
		if (obj7 != null)
		{
			Transform transform3 = ((Component)obj7).transform;
			if ((object)transform3 != null)
			{
				Vector3 position2 = transform3.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
				object obj41 = 0;
				object obj42 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X0_v27+E4]");
				bool flag23 = (nint)0 == 0;
				object obj43 = !flag23;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Sfx.Play(putDowns, (Vector3)0, (float)vector, pitchMin, pitchMax);
				object obj44 = vector * vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v14+4]");
				float num6 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v14+4]");
				float num7 = num6 * 0f;
				float num8 = (float)obj44 + num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v14+8]");
				float num9 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v14+8]");
				float num10 = num9 * 0f;
				float num11 = num10 + num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE10]");
				if (num11 > 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj45 = 0;
					object obj46 = obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X0_v33+E4]");
					bool flag24 = (nint)0 == 0;
					object obj47 = !flag24;
					if (obj47 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				}
				((GillaItem)obj7).Release((Vector3)0, spin2);
				return;
			}
		}
		goto IL_0874;
	}

	private unsafe void Throw(int h, out Vector3 velocity, out Vector3 spin)
	{
		//IL_0825: Expected Obj, but got I
		//IL_083d: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0164: Expected Obj, but got I4
		//IL_0193: Expected Obj, but got I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01c4: Expected Obj, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_0269: Expected Obj, but got I
		//IL_02c0: Expected Obj, but got I
		//IL_02d9: Expected Obj, but got I4
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_033c: Expected Obj, but got I4
		//IL_036b: Expected Obj, but got I4
		//IL_038e: Expected Obj, but got I
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected Obj, but got Unknown
		//IL_04ff: Invalid comparison between F4 and I4
		//IL_050e: Invalid comparison between F4 and I4
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected Obj, but got Unknown
		//IL_052f: Expected Obj, but got F4
		//IL_0564: Expected Obj, but got I4
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected Obj, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected Obj, but got Unknown
		//IL_071c: Expected Obj, but got I4
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected Obj, but got Unknown
		//IL_0744: Expected Obj, but got I4
		//IL_0759: Expected F4, but got VT
		//IL_05e1: Expected Ref, but got F4
		//IL_060c: Expected Obj, but got I
		//IL_0636: Expected Obj, but got I4
		//IL_07f8: Expected Obj, but got I
		//IL_0800: Expected F4, but got Obj
		//IL_0810: Expected F4, but got I
		//IL_08f3: Expected Ref, but got F4
		//IL_077f: Expected Obj, but got I
		//IL_07bd: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6+8]");
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6+4]");
		_ = 0;
		ref Vector3 reference2 = ref *(Vector3*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6+8]");
		_ = 0;
		if (frames < 6)
		{
			return;
		}
		float[] array = trailTime;
		bool flag = head < array.Length;
		object obj4 = !flag;
		if (obj4 == null)
		{
			object obj5 = head + 1;
			object obj6 = obj5 * 1717986919;
			object obj7 = obj6 >> 63;
			object obj8 = obj6 >> 33;
			object obj9 = obj8 + obj7;
			object obj10 = obj9 + obj9;
			object obj11 = obj5 - obj10;
			bool flag2 = (nint)obj11 < array.Length;
			object obj12 = !flag2;
			if (obj12 == null)
			{
				Vector3[,] array2 = trailAt;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X13_v5 (UnityEngine.Vector3[2])+10]");
				object obj13 = 0;
				bool flag3 = (nint)obj13 < h;
				object obj14 = !flag3;
				object obj15 = obj13 - h;
				bool flag4 = obj15 == null;
				object obj16 = ~obj14;
				object obj17 = obj16 | flag4;
				if (obj17 == null)
				{
					int num = head;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X9_v5+10]");
					bool flag5 = (nint)num < (nint)0;
					object obj18 = !flag5;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X9_v5+10]");
						bool flag6 = (nint)obj11 < 0;
						object obj19 = !flag6;
						if (obj19 == null)
						{
							object obj20 = array2 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X9_v5+10]");
							object obj21 = (nint)0 * (nint)h;
							object obj22 = obj21 + head;
							object obj23 = obj21 + obj11;
							object obj24 = obj22 * 12;
							object obj25 = obj20 + obj24;
							object obj26 = obj23 * 12;
							object obj27 = obj20 + obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							object obj28 = obj25 - obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6+8]");
							object obj29 = obj28 / 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X10_v6+8]");
							nint num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X12_v7+8]");
							object obj30 = num2 - 0;
							object obj32 = default;
							object obj31 = obj30 / obj32;
							object obj34 = default;
							object obj33 = obj29 * obj34;
							reference2 = ref *(Vector3*)obj33;
							float num3 = throwBoost * (float)obj31;
							Quaternion[,] array3 = trailTurn;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X10_v7 (UnityEngine.Quaternion[2])+10]");
							object obj35 = 0;
							bool flag7 = (nint)obj35 < h;
							object obj36 = !flag7;
							object obj37 = obj35 - h;
							bool flag8 = obj37 == null;
							object obj38 = ~obj36;
							object obj39 = obj38 | flag8;
							if (obj39 == null)
							{
								int num4 = head;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X13_v8+10]");
								bool flag9 = (nint)num4 < (nint)0;
								object obj40 = !flag9;
								if (obj40 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X13_v8+10]");
									bool flag10 = (nint)obj11 < 0;
									object obj41 = !flag10;
									if (obj41 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X13_v8+10]");
										object obj42 = (nint)0 * (nint)h;
										object obj43 = array3 + 32;
										object obj44 = obj42 + head;
										object obj45 = obj42 + obj11;
										object obj46 = obj43 + obj44;
										Quaternion rotation = default;
										Quaternion quaternion = Quaternion.Internal_Inverse(ref rotation);
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
										float num5 = throwBoost;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X10_v8+v534 @ X8_v14*16]");
										float num6 = num5 * 0f;
										object obj48 = default;
										object obj47 = obj46 * obj48;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
										float num7 = num6 + (float)obj47;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
										object obj50 = default;
										object obj49 = obj46 * obj50;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
										float num8 = num7 + (float)obj49;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
										Quaternion q = default;
										Quaternion.Internal_ToAxisAngleRad(ref q, out Vector3 axis, out float angle);
										float num9 = angle;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
										float num10 = num9 * 0f;
										float num11 = num10 + 3.2833536E+09f;
										float num12 = num10 - 1.1274813E+09f;
										bool flag11 = num12 < 0f;
										bool flag12 = num12 == 0f;
										object obj51 = num10 ^ 0x43340000;
										object obj52 = num10 ^ num12;
										object obj53 = obj51 & obj52;
										bool flag13 = (nint)obj53 < 0;
										bool flag14 = flag11 == flag13;
										object obj54 = !flag12;
										object obj55 = flag14 & obj54;
										object obj56 = ~obj55;
										if (obj56 == null)
										{
											num10 = num11;
										}
										object obj57 = axis & 0x7FFFFFFF;
										bool flag15 = (nint)obj57 < 2139095040;
										object obj58 = !flag15;
										object obj59 = obj57 - 2139095040;
										bool flag16 = obj59 == null;
										object obj60 = !flag16;
										object obj61 = obj58 & obj60;
										float num13 = (float)axis;
										if (obj61 == null)
										{
											float num14 = num10;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
											float num15 = num14 * 0f;
											float num16 = num15 / (float)obj32;
											num13 = (float)axis * num16;
											float num17 = default;
											object obj62 = default;
											num10 = num17 * (float)obj62;
											reference = ref *(Vector3*)num13;
											num11 = num17;
										}
										if (h == 2)
										{
											Camera main = Camera.main;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
											object obj63 = 0;
											object obj64 = obj63;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v23+E4]");
											bool flag17 = (nint)0 == 0;
											object obj65 = !flag17;
											if (obj65 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											float num22;
											float num23;
											if (main != null)
											{
												Camera main2 = Camera.main;
												Transform transform = main2.transform;
												Vector3 forward = transform.forward;
												float num18 = num11 * 5f;
												float num19 = num13 * 0f;
												object obj66 = obj;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X8_v32+A0]");
												object obj67 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v33+18]");
												float num20 = 0f * num13;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v33+20]");
												nint num21 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
												object obj68 = num21 * 0;
												num22 = num19 + num20;
												num23 = num18 + (float)obj68;
											}
											else
											{
												object obj69 = obj;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v27+A0]");
												object obj70 = 0;
												num22 = (float)obj70;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X8_v28+8]");
												num23 = 0f;
											}
											float num24 = (float)velocity + num22;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [velocity @ X2 (UnityEngine.Vector3&)+8]");
											float num25 = 0f + num23;
											reference2 = ref *(Vector3*)num24;
										}
										return;
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

	private void Fingers(int h, float k)
	{
		//IL_0029: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I4
		//IL_01a4: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I8
		//IL_00ad: Expected Obj, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00d4: Expected Obj, but got I4
		//IL_0379: Expected Obj, but got I4
		//IL_03d8: Expected Obj, but got I4
		//IL_03f6: Expected Obj, but got I
		//IL_0406: Expected Obj, but got I
		//IL_0430: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I
		//IL_026b: Expected Obj, but got I4
		//IL_0310: Expected Obj, but got I4
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0338: Expected I, but got Obj
		//IL_03b1: Expected Obj, but got I4
		//IL_044e: Expected Obj, but got I
		//IL_02b2: Expected Obj, but got I4
		if (h == 2)
		{
			return;
		}
		HandPoser[] array = posers;
		bool flag = h == 0;
		object obj = !flag;
		object obj2 = ~obj;
		object obj3 = ((obj2 != null) ? ((object)4) : ((object)(4 + 1)));
		bool flag2 = array.Length < 1;
		UnityEngine.Object obj4 = (UnityEngine.Object)h;
		if (!flag2)
		{
			object obj5 = array.Length & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj6 = 0;
			object obj7 = array + 32;
			IntPtr intPtr = default;
			nint num = intPtr;
			int num2 = h;
			object obj8 = 0;
			bool flag5;
			do
			{
				bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
				object obj9 = !flag3;
				if (obj9 == null)
				{
					object obj10 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X25_v6+v224 @ X23_v7*8]");
					UnityEngine.Object obj11 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v36+E4]");
					bool flag4 = (nint)0 == 0;
					object obj12 = !flag4;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X25_v6+v224 @ X23_v7*8]");
					if ((UnityEngine.Object)0 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X20_v9 (UnityEngine.Object)+20]");
						if (0 != (nint)obj3)
						{
						}
					}
					obj5 = array.Length;
					obj8++;
					flag5 = (nint)obj8 < array.Length;
					obj4 = null;
					num = unchecked((nint)null);
					num2 = 0;
					continue;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
			while (flag5);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v6+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj16 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v10+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v10+A0]");
		object obj19 = 0;
		object obj20 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v14+E4]");
		bool flag8 = (nint)0 == 0;
		object obj21 = !flag8;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj19 != null)
		{
			object obj22 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v14+E4]");
			bool flag9 = (nint)0 == 0;
			object obj23 = !flag9;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj24 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v18+E4]");
			bool flag10 = (nint)0 == 0;
			object obj25 = !flag10;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj24 = obj13;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v18+A0]");
			object obj26 = 0;
			object obj27 = h - 1;
			bool right = obj27 == null;
			((MonsterPlayer)obj26).CloseFingers(right, k);
		}
	}

	private unsafe void MouseHands(bool free)
	{
		//IL_0cdc: Expected Obj, but got I
		//IL_0cff: Expected Obj, but got I4
		//IL_0d07: Expected Obj, but got I4
		//IL_00c1: Expected VT, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0131: Expected VT, but got I4
		//IL_0d25: Expected Obj, but got I
		//IL_0d3d: Expected Obj, but got I
		//IL_0d54: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I4
		//IL_0085: Expected I, but got Obj
		//IL_0d72: Expected Obj, but got I
		//IL_0d8a: Expected Obj, but got I
		//IL_0d9e: Expected I, but got Obj
		//IL_01fc: Expected Obj, but got I4
		//IL_0dc9: Expected Obj, but got I
		//IL_0c6e: Expected Obj, but got I4
		//IL_0c95: Expected Obj, but got I4
		//IL_0e12: Expected VT, but got I4
		//IL_0e17: Expected I, but got Obj
		//IL_0239: Expected VT, but got I4
		//IL_023e: Expected I, but got Obj
		//IL_0cc5: Expected Obj, but got I4
		//IL_0321: Expected Obj, but got I4
		//IL_0331: Expected Obj, but got I4
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_035f: Expected VT, but got I4
		//IL_0364: Expected I, but got Obj
		//IL_0275: Expected Obj, but got I4
		//IL_0285: Expected Obj, but got I4
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_02b3: Expected VT, but got I4
		//IL_02b8: Expected I, but got Obj
		//IL_03a1: Expected Obj, but got I4
		//IL_03e3: Expected Obj, but got I4
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected Obj, but got Unknown
		//IL_099d: Expected VT, but got I4
		//IL_09a2: Expected I, but got Obj
		//IL_042b: Expected VT, but got I4
		//IL_0430: Expected I, but got Obj
		//IL_09cc: Expected Obj, but got I4
		//IL_09dc: Expected Obj, but got I4
		//IL_09fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a01: Expected Obj, but got Unknown
		//IL_0a0a: Expected VT, but got I4
		//IL_0a0f: Expected I, but got Obj
		//IL_0463: Expected VT, but got I4
		//IL_0468: Expected I, but got Obj
		//IL_0a47: Expected Obj, but got I4
		//IL_048c: Expected Obj, but got I
		//IL_0ab1: Expected VT, but got I4
		//IL_0ab6: Expected I, but got Obj
		//IL_04db: Expected VT, but got I4
		//IL_04e0: Expected I, but got Obj
		//IL_0ae9: Expected VT, but got I4
		//IL_0aee: Expected I, but got Obj
		//IL_0503: Expected Obj, but got I
		//IL_051c: Expected Obj, but got I
		//IL_0529: Expected I4, but got Obj
		//IL_0532: Expected VT, but got I4
		//IL_0537: Expected I, but got Obj
		//IL_053f: Expected I4, but got Obj
		//IL_0b12: Expected Obj, but got I
		//IL_0b23: Expected Obj, but got I4
		//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b31: Expected Obj, but got Unknown
		//IL_0b4b: Expected Obj, but got I4
		//IL_055b: Expected VT, but got I4
		//IL_059e: Expected Obj, but got I4
		//IL_0e3a: Expected Obj, but got I
		//IL_0e5a: Expected Obj, but got I4
		//IL_0e5f: Expected I, but got Obj
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected Obj, but got I
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected VT, but got Unknown
		//IL_0600: Expected I, but got Obj
		//IL_0e9e: Expected VT, but got Ref
		//IL_0ea7: Expected Obj, but got I4
		//IL_0625: Expected VT, but got Ref
		//IL_062e: Expected Obj, but got I4
		//IL_0655: Expected Obj, but got I4
		//IL_067c: Expected Obj, but got I4
		//IL_06a1: Expected I4, but got I8
		//IL_06e5: Expected Obj, but got I4
		//IL_0746: Expected VT, but got Ref
		//IL_074f: Expected Obj, but got I4
		//IL_0790: Expected Obj, but got I8
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected Obj, but got Unknown
		//IL_07ac: Expected Obj, but got I4
		//IL_0f58: Expected Obj, but got I4
		//IL_0f60: Expected VT, but got Ref
		//IL_0f69: Expected Obj, but got I4
		//IL_07db: Expected Obj, but got I4
		//IL_080a: Expected Obj, but got I
		//IL_0822: Expected I, but got Obj
		//IL_0ebf: Expected Obj, but got I4
		//IL_0ec8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecd: Expected Obj, but got Unknown
		//IL_0854: Expected VT, but got Ref
		//IL_085d: Expected Obj, but got I4
		//IL_0862: Expected I, but got Obj
		//IL_0886: Expected Obj, but got I
		//IL_089e: Expected I, but got Obj
		//IL_08ce: Expected VT, but got Ref
		//IL_08ce: Expected Obj, but got I
		//IL_08ec: Expected Obj, but got I4
		//IL_0ef6: Expected Obj, but got I4
		//IL_094f: Expected Obj, but got I4
		//IL_096f: Expected Obj, but got Ref
		//IL_090b: Expected I4, but got Obj
		//IL_0919: Expected Obj, but got I4
		//IL_0929: Expected F8, but got VT
		//IL_0941: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		bool isDeviceActive = XRSettings.isDeviceActive;
		bool flag = !isDeviceActive;
		object obj2 = !flag;
		UnityEngine.Object obj3 = (UnityEngine.Object)free;
		object obj15;
		bool flag9;
		RaycastHit raycastHit;
		nint num;
		if (obj2 == null)
		{
			object obj4 = 109891584;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v19+A0]");
			object obj7 = 0;
			bool flag2 = obj7 == null;
			obj3 = (UnityEngine.Object)free;
			if (!flag2)
			{
				Camera main = Camera.main;
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v22+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag4 = main != null;
				bool flag5 = !flag4;
				num = unchecked((nint)null);
				obj3 = null;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
					object obj10 = 0;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v27+A0]");
					object obj12 = 0;
					bool flag6 = obj12 == null;
					num = unchecked((nint)null);
					obj3 = null;
					if (flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X22_v13+A38]");
						bool flag7 = (nint)0 == 0;
						object obj13 = !flag7;
						if (obj13 == null)
						{
							_ = 1;
						}
						object obj14 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v32+A0]");
						obj15 = 0;
						object obj16 = obj15;
						if (free)
						{
							GillaItem[] array = holding;
							bool flag8 = holding == null;
							raycastHit = (RaycastHit)0;
							num = unchecked((nint)null);
							obj3 = null;
							flag9 = free;
							if (flag8)
							{
								goto IL_0b6f;
							}
							bool flag10 = array.Length < 2;
							object obj17 = !flag10;
							object obj18 = array.Length - 2;
							bool flag11 = obj18 == null;
							object obj19 = ~obj17;
							object obj20 = obj19 | flag11;
							raycastHit = (RaycastHit)0;
							num = unchecked((nint)null);
							obj3 = null;
							flag9 = free;
							if (obj20 != null)
							{
								goto IL_0b7d;
							}
							bool flag12 = Allowed(array[2]);
							flag9 = flag12;
						}
						else
						{
							flag9 = false;
						}
						GillaItem[] array2 = holding;
						bool flag13 = holding == null;
						raycastHit = (RaycastHit)0;
						num = unchecked((nint)null);
						obj3 = null;
						if (!flag13)
						{
							bool flag14 = array2.Length < 2;
							object obj21 = !flag14;
							object obj22 = array2.Length - 2;
							bool flag15 = obj22 == null;
							object obj23 = ~obj21;
							object obj24 = obj23 | flag15;
							raycastHit = (RaycastHit)0;
							num = unchecked((nint)null);
							obj3 = null;
							if (obj24 != null)
							{
								goto IL_0b7d;
							}
							object obj25 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X0_v54+E4]");
							bool flag16 = (nint)0 == 0;
							object obj26 = !flag16;
							if (obj26 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag17 = array2[2] == null;
							object obj27 = flag9 & flag17;
							object obj28 = obj27 & 1;
							bool flag18 = obj28 == null;
							obj3 = null;
							if (flag18)
							{
								goto IL_0979;
							}
							bool flag19 = obj15 == null;
							raycastHit = (RaycastHit)0;
							num = unchecked((nint)null);
							obj3 = null;
							if (!flag19)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X22_v14+1C0]");
								bool flag20 = (nint)0 == 0;
								raycastHit = (RaycastHit)0;
								num = unchecked((nint)null);
								obj3 = null;
								if (!flag20)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X22_v14+1C0]");
									bool wasPressedThisFrame = ((ButtonControl)0).wasPressedThisFrame;
									bool flag21 = !wasPressedThisFrame;
									obj3 = null;
									if (flag21)
									{
										goto IL_0979;
									}
									Camera main2 = Camera.main;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X22_v14+188]");
									bool flag22 = (nint)0 == 0;
									raycastHit = (RaycastHit)0;
									num = unchecked((nint)null);
									obj3 = null;
									if (!flag22)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CF8]");
										object obj29 = 0;
										obj3 = (UnityEngine.Object)obj29;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X22_v14+188]");
										Vector2 vector = ((InputControl<Vector2>)0).ReadValue();
										bool flag23 = (byte)(int)(~main2) != 0;
										raycastHit = (RaycastHit)0;
										num = unchecked((nint)null);
										flag9 = (byte)(int)main2 != 0;
										if (!flag23)
										{
											Ray ray = main2.ScreenPointToRay((Vector3)0);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
											flag9 = false;
											bool value = ((bool*)(flag9 ? 1 : 0))->m_value;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X0_v76 (System.Boolean)+E4]");
											bool flag24 = (nint)0 == 0;
											object obj30 = !flag24;
											if (obj30 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												value = ((bool*)(flag9 ? 1 : 0))->m_value;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X0_v76 (System.Boolean)+A0]");
											object obj31 = 0;
											bool flag25 = obj31 == null;
											RaycastHit raycastHit2 = default;
											raycastHit = raycastHit2;
											object obj32 = 0;
											num = unchecked((nint)null);
											obj3 = null;
											if (!flag25)
											{
												Enumerator<, > enumerator = ((List<System.__Canon>)obj31).GetEnumerator();
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5268]");
												object obj33 = 0;
												double num2 = 4.0;
												Enumerator<, > val = default;
												raycastHit = (RaycastHit)val;
												num = unchecked((nint)null);
												flag9 = false;
												Enumerator<, > val2 = default;
												GillaItem gillaItem = default;
												RaycastHit raycastHit3 = default;
												RaycastHit raycastHit4 = default;
												while (true)
												{
													IL_0e72:
													obj3 = (UnityEngine.Object)obj33;
													bool flag26 = val2.MoveNext();
													bool flag27 = !flag26;
													raycastHit2 = (RaycastHit)(&val2);
													obj32 = 0;
													if (flag27)
													{
														break;
													}
													bool flag28 = (object)gillaItem == null;
													raycastHit2 = (RaycastHit)(&val2);
													obj32 = 0;
													if (flag28)
													{
														goto IL_0b8b;
													}
													bool flag29 = (byte)(~(gillaItem.Gone__BackingField ? 1u : 0u)) != 0;
													object obj34 = !flag29;
													if (obj34 != null)
													{
														continue;
													}
													bool flag30 = (byte)(~(gillaItem.Swallowed__BackingField ? 1u : 0u)) != 0;
													object obj35 = !flag30;
													if (obj35 != null || (int)(gillaItem.Hand__BackingField & 0x80000000L) == 0)
													{
														continue;
													}
													bool heldByOther = gillaItem.HeldByOther;
													bool flag31 = !heldByOther;
													object obj36 = !flag31;
													if (obj36 != null || !Allowed(gillaItem))
													{
														continue;
													}
													Collider[] array3 = gillaItem.Colliders__BackingField;
													bool flag32 = gillaItem.Colliders__BackingField == null;
													raycastHit2 = (RaycastHit)(&val2);
													obj32 = 0;
													if (!flag32)
													{
														if (array3.Length < 1)
														{
															continue;
														}
														object obj37 = array3.Length & 0xFFFFFFFFL;
														object obj38 = gillaItem.Colliders__BackingField + 32;
														object obj39 = 0;
														while (true)
														{
															bool flag33 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj39) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj37);
															object obj40 = !flag33;
															raycastHit2 = (RaycastHit)(&val2);
															obj32 = 0;
															if (obj40 != null)
															{
																break;
															}
															object obj41 = obj;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X0_v87+E4]");
															bool flag34 = (nint)0 == 0;
															object obj42 = !flag34;
															if (obj42 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X27_v10+v398 @ X26_v11*8]");
															bool flag35 = (UnityEngine.Object)0 != null;
															bool flag36 = !flag35;
															num = unchecked((nint)null);
															obj3 = null;
															if (!flag36)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X27_v10+v398 @ X26_v11*8]");
																bool flag37 = (nint)0 == 0;
																raycastHit2 = (RaycastHit)(&val2);
																obj32 = 0;
																num = unchecked((nint)null);
																obj3 = null;
																if (flag37)
																{
																	goto IL_0bb5;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X27_v10+v398 @ X26_v11*8]");
																bool flag38 = ((Collider)0).enabled;
																bool flag39 = !flag38;
																num = unchecked((nint)null);
																obj3 = null;
																if (!flag39)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X27_v10+v398 @ X26_v11*8]");
																	bool flag40 = ((Collider)0).Raycast((Ray)(&raycastHit3), out var hitInfo, (float)num2);
																	bool flag41 = !flag40;
																	object obj43 = !flag41;
																	object obj44 = ~obj43;
																	if (obj44 == null)
																	{
																		flag9 = (byte)(int)gillaItem != 0;
																	}
																	object obj45 = !flag41;
																	object obj46 = ~obj45;
																	if (obj46 == null)
																	{
																		object obj47 = 0;
																		raycastHit3 = raycastHit2;
																		num2 = (double)raycastHit4;
																		raycastHit = raycastHit4;
																		num = (nint)(&hitInfo);
																		obj3 = (UnityEngine.Object)(&raycastHit3);
																	}
																	else
																	{
																		object obj47 = 0;
																		raycastHit3 = raycastHit2;
																		raycastHit = raycastHit4;
																		num = (nint)(&hitInfo);
																		obj3 = (UnityEngine.Object)(&raycastHit3);
																	}
																}
															}
															obj37 = array3.Length;
															obj39++;
															if ((nint)obj39 >= array3.Length)
															{
																goto IL_0e72;
															}
														}
														goto IL_0b99;
													}
													goto IL_0ba7;
												}
												goto IL_0c3a;
											}
										}
									}
								}
							}
						}
						goto IL_0b6f;
					}
				}
			}
		}
		GillaItem[] array4 = holding;
		bool flag42 = holding == null;
		raycastHit = (RaycastHit)0;
		flag9 = free;
		if (flag42)
		{
			goto IL_0b6f;
		}
		bool flag43 = array4.Length < 2;
		object obj48 = !flag43;
		object obj49 = array4.Length - 2;
		bool flag44 = obj49 == null;
		object obj50 = ~obj48;
		object obj51 = obj50 | flag44;
		raycastHit = (RaycastHit)0;
		flag9 = free;
		if (obj51 != null)
		{
			goto IL_0b7d;
		}
		object obj52 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v39+E4]");
		bool flag45 = (nint)0 == 0;
		object obj53 = !flag45;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool thrown;
		int h;
		if (array4[2] != null)
		{
			thrown = false;
			h = 2;
			goto IL_0f0d;
		}
		return;
		IL_0f0d:
		LetGo(h, thrown);
		return;
		IL_0bb5:
		NullReferenceException ex = new NullReferenceException();
		if ((nint)obj3 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		}
		else
		{
			if ((nint)obj3 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D3D4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		}
		goto IL_0c3a;
		IL_0b99:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_0ba7;
		IL_0b6f:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0b7d;
		IL_0ba7:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0bb5;
		IL_0b7d:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		goto IL_0b8b;
		IL_0c3a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D3D4");
		object obj54 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v9+E4]");
		bool flag46 = (nint)0 == 0;
		object obj55 = !flag46;
		if (obj55 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)flag9 != null)
		{
			Take(2, (GillaItem)flag9);
		}
		return;
		IL_0b8b:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_0b99;
		IL_0979:
		GillaItem[] array5 = holding;
		bool flag47 = holding == null;
		raycastHit = (RaycastHit)0;
		num = unchecked((nint)null);
		if (!flag47)
		{
			bool flag48 = array5.Length < 2;
			object obj56 = !flag48;
			object obj57 = array5.Length - 2;
			bool flag49 = obj57 == null;
			object obj58 = ~obj56;
			object obj59 = obj58 | flag49;
			raycastHit = (RaycastHit)0;
			num = unchecked((nint)null);
			if (obj59 != null)
			{
				goto IL_0b7d;
			}
			object obj60 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X0_v59+E4]");
			bool flag50 = (nint)0 == 0;
			object obj61 = !flag50;
			if (obj61 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(array5[2] != null))
			{
				return;
			}
			bool flag51 = obj15 == null;
			raycastHit = (RaycastHit)0;
			num = unchecked((nint)null);
			obj3 = null;
			if (!flag51)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X22_v14+1C0]");
				bool flag52 = (nint)0 == 0;
				raycastHit = (RaycastHit)0;
				num = unchecked((nint)null);
				obj3 = null;
				if (!flag52)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X22_v14+1C0]");
					bool isPressed = ((ButtonControl)0).isPressed;
					object obj62 = isPressed & flag9;
					object obj63 = obj62 & 1;
					bool flag53 = obj63 == null;
					object obj64 = !flag53;
					if (obj64 == null)
					{
						thrown = flag9;
						h = 2;
						goto IL_0f0d;
					}
					return;
				}
			}
		}
		goto IL_0b6f;
	}

	private static bool Grip(XRNode node, bool holding)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I
		//IL_0136: Expected VT, but got I
		//IL_0083: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I4
		//IL_016f: Invalid comparison between F4 and I4
		//IL_017e: Invalid comparison between F4 and I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_019e: Expected Obj, but got F4
		//IL_01d3: Expected Obj, but got I4
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected I4, but got Unknown
		//IL_00b5: Expected Obj, but got I
		UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
		UnityEngine.XR.InputDevice inputDevice = default;
		bool isValid = inputDevice.isValid;
		bool flag = !isValid;
		bool result = false;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v9+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v6+80]");
			if (inputDevice.TryGetFeatureValue((InputFeatureUsage<float>)0, out var value))
			{
				bool flag3 = !holding;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				object obj5 = 0;
				object obj6 = !flag3;
				object obj7 = ~obj6;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
					obj5 = 0;
				}
				float num = value - (float)obj5;
				bool flag4 = num < 0f;
				bool flag5 = num == 0f;
				object obj8 = value ^ obj5;
				object obj9 = value ^ num;
				object obj10 = obj8 & obj9;
				bool flag6 = (nint)obj10 < 0;
				bool flag7 = flag4 == flag6;
				object obj11 = !flag5;
				bool flag8 = (byte)((flag7 & obj11) ? 1 : 0) != 0;
				result = flag8;
			}
			else
			{
				result = false;
			}
		}
		return result;
	}

	public GillaHands()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_02d3: Expected F4, but got I
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01c9: Expected Obj, but got I4
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_0289: Expected Obj, but got I
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1180]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F28]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1188]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1190]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1198]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4470]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B500]");
		reach = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj10 = this + 56;
		object obj11 = default;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj12 = this + 64;
		object obj13 = default;
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj14 = this + 72;
		object obj15 = default;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj16 = this + 80;
		object obj17 = default;
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj18 = this + 88;
		object obj19 = default;
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj20 = this + 96;
		object obj21 = default;
		obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj22 = this + 104;
		object obj23 = default;
		obj22 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj24 = this + 112;
		object obj25 = default;
		obj24 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj26 = 17293312 + 4064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F00");
		object obj27 = this + 120;
		object obj28 = default;
		obj27 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F00");
		object obj29 = this + 128;
		object obj30 = default;
		obj29 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj31 = this + 136;
		object obj32 = default;
		obj31 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj33 = this + 160;
		object obj34 = default;
		obj33 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11A0]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj36 = this + 168;
		object obj37 = default;
		obj36 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
