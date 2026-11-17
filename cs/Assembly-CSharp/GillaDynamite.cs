using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.XR;

public class GillaDynamite : NetworkBehaviour
{
	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public GillaDummy _003C_003E4__this;

		public byte torn;

		public Vector3 velocity;

		public int id;

		public byte seed;

		internal void _003CBlown_003Eb__0()
		{
			//IL_0010: Expected Obj, but got I
			//IL_04a0: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got I4
			//IL_00d1: Expected Obj, but got I4
			//IL_011b: Expected Obj, but got I4
			//IL_0139: Expected Obj, but got I
			//IL_01a6: Expected Obj, but got I
			//IL_01c0: Expected Obj, but got I8
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Expected Obj, but got Unknown
			//IL_01d7: Expected Obj, but got I4
			//IL_01e0: Expected VT, but got I4
			//IL_04c7: Expected Obj, but got I4
			//IL_0218: Expected Obj, but got I4
			//IL_042e: Expected Obj, but got I
			//IL_0437: Unknown result type (might be due to invalid IL or missing references)
			//IL_043c: Expected Obj, but got Unknown
			//IL_0302: Expected Obj, but got I4
			//IL_030b: Expected VT, but got I4
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			//IL_038d: Expected Obj, but got Unknown
			//IL_0400: Expected VT, but got I4
			//IL_0409: Expected VT, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = (UnityEngine.Object)_003C_003E4__this == (UnityEngine.Object)null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 != null)
			{
				return;
			}
			GillaDummy gillaDummy = _003C_003E4__this;
			if ((object)_003C_003E4__this != null)
			{
				if (gillaDummy.mode == (GillaDummy.Mode)3)
				{
					return;
				}
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v11+E4]");
				bool flag4 = (nint)0 == 0;
				object obj6 = !flag4;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = gillaDummy.tearing == null;
				bool flag6 = !flag5;
				object obj7 = !flag6;
				if (obj7 != null)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D06E8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj9 = default;
				if (obj9 != null)
				{
					_ = 1;
					_ = 2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v16+18]");
					if ((nint)0 < (nint)1)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v16+18]");
					object obj11 = 0 & 0xFFFFFFFFL;
					object obj12 = obj9 + 32;
					object obj13 = 0;
					Vector3 vector = (Vector3)0;
					ApePart apePart = (ApePart)3;
					double num4 = default;
					object obj20 = default;
					while (true)
					{
						bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
						object obj14 = !flag7;
						if (obj14 != null)
						{
							break;
						}
						object obj15 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v18+E4]");
						bool flag8 = (nint)0 == 0;
						object obj16 = !flag8;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X25_v5+v209 @ X23_v6*4]");
						byte b = NetworkApe.TornBit((ApePart)0);
						int num = b & torn;
						bool flag9 = num == 0;
						apePart = (ApePart)0;
						if (flag9)
						{
							goto IL_041e;
						}
						GillaDummy gillaDummy2 = _003C_003E4__this;
						if ((object)_003C_003E4__this != null && (object)gillaDummy2.tearing != null)
						{
							Dismemberment tearing = gillaDummy2.tearing;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X25_v5+v209 @ X23_v6*4]");
							bool flag10 = tearing.IsTorn((ApePart)0);
							bool flag11 = !flag10;
							object obj17 = !flag11;
							vector = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X25_v5+v209 @ X23_v6*4]");
							apePart = (ApePart)0;
							if (obj17 != null)
							{
								goto IL_041e;
							}
							GillaDummy gillaDummy3 = _003C_003E4__this;
							if ((object)_003C_003E4__this != null)
							{
								Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
								if ((object)gillaDummy3.tearing != null)
								{
									object obj18 = velocity * 63;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDynamite+<>c__DisplayClass87_0)+24]");
									double num2 = 0.0 * 0.5;
									double num3 = num4 + num4;
									object obj19 = obj20 + obj20;
									num4 = num2 + num3;
									obj20 = obj18 + obj19;
									Dismemberment tearing2 = gillaDummy3.tearing;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X25_v5+v209 @ X23_v6*4]");
									tearing2.Tear((ApePart)0, (Vector3)0);
									vector = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X25_v5+v209 @ X23_v6*4]");
									apePart = (ApePart)0;
									goto IL_041e;
								}
							}
						}
						goto IL_0461;
						IL_041e:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v16+18]");
						obj11 = 0;
						obj13++;
						object obj21 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v16+18]");
						if ((nint)obj21 >= 0)
						{
							return;
						}
					}
					goto IL_046f;
				}
			}
			goto IL_0461;
			IL_0461:
			NullReferenceException ex = new NullReferenceException();
			goto IL_046f;
			IL_046f:
			throw new IndexOutOfRangeException();
		}

		internal void _003CBlown_003Eb__1()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0092: Expected Obj, but got I4
			//IL_0066: Expected VT, but got I4
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
			if ((UnityEngine.Object)_003C_003E4__this != (UnityEngine.Object)null)
			{
				_003C_003E4__this.Die((Vector3)0, false);
			}
		}

		internal void _003CBlown_003Eb__2()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaCorpse.RipSoon(id, seed);
		}
	}

	public GillaItem item;

	public float fuseSeconds;

	public Transform fuse;

	public Transform spark;

	public ParticleSystem[] burning;

	public MeshRenderer[] buds;

	public AudioSource hiss;

	public AudioClip lightSound;

	public GillaBlast blast;

	public float chainRadius;

	private NetworkBool _Lit;

	private float _Burn;

	private NetworkBool _Blown;

	public static readonly List<GillaDynamite> All;

	private const float BudEvery = default(float);

	private static readonly int BudAge;

	private static readonly int BudTurn;

	private MaterialPropertyBlock budBlock;

	private float[] budWas;

	private bool litHere;

	private bool blownHere;

	private bool wentOff;

	private bool shownLit;

	private bool shownBlown;

	private float burnHere;

	private float lightWaits;

	private float buzzAt;

	private float chainAt;

	private readonly GillaNetGuard.Holder holder;

	private float litSince;

	private float blastNearAt;

	private const int MostEach = default(int);

	private const float OffBy = default(float);

	private const float BurntShare = default(float);

	private const float ChainSlack = default(float);

	private const float ChainFor = default(float);

	private readonly bool[] was;

	private Vector3 fuseAt;

	private Vector3 tipAt;

	private Vector3 rootAt;

	private float hissVolume;

	public static readonly Bounds NoBlast;

	private unsafe NetworkBool Lit
	{
		get
		{
			//IL_002e: Expected VT, but got I
			//IL_0080: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				InvalidOperationException ex = default;
				string message = default;
				ex._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentNullException ex2 = new ArgumentNullException();
				return (NetworkBool)ex2;
			}
			return (NetworkBool)ptr;
		}
		set
		{
			//IL_0027: Expected I, but got VT
			if (Ptr != null)
			{
				int* ptr = (int*)(nint)value;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	private unsafe float Burn
	{
		get
		{
			//IL_0036: Expected F4, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+4]");
				return 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
		set
		{
			if (Ptr != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	private unsafe NetworkBool Blown
	{
		get
		{
			//IL_0036: Expected VT, but got I
			//IL_0088: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+8]");
				return (NetworkBool)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (NetworkBool)ex2;
		}
		set
		{
			if (Ptr != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	private bool Live
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_012b: Expected Obj, but got I4
			//IL_0101: Expected I4, but got Obj
			//IL_0163: Expected Obj, but got I4
			//IL_00ed: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)((SimulationBehaviour)this)._object != (UnityEngine.Object)null)
			{
				NetworkObject networkObject = ((SimulationBehaviour)this)._object;
				if ((object)((SimulationBehaviour)this)._object != null)
				{
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v11+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!networkObject._runner)
					{
						goto IL_00ed;
					}
					if ((object)networkObject._runner != null)
					{
						ArgumentNullException ex = new ArgumentNullException();
						return (byte)(int)ex != 0;
					}
				}
				NullReferenceException ex2 = new NullReferenceException();
				return (byte)(int)ex2 != 0;
			}
			goto IL_00ed;
			IL_00ed:
			return false;
		}
	}

	private Vector3 Where
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00f6: Expected Obj, but got I4
			//IL_00b0: Expected Obj, but got I4
			//IL_00cc: Expected VT, but got Obj
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
			Transform transform;
			if (spark != null)
			{
				transform = spark;
				if ((object)spark != null)
				{
					goto IL_007a;
				}
			}
			else
			{
				transform = base.transform;
				bool flag2 = (object)transform == null;
				object obj4 = !flag2;
				if (obj4 != null)
				{
					goto IL_007a;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
			IL_007a:
			return transform.position;
		}
	}

	public bool IsLit
	{
		get
		{
			//IL_005d: Expected Obj, but got I4
			bool result;
			if (Live)
			{
				NetworkBool lit = Lit;
				bool flag = lit;
				bool flag2 = !flag;
				object obj = !flag2;
				if (obj != null)
				{
					goto IL_009c;
				}
				result = false;
			}
			else
			{
				result = litHere;
				if (~(litHere ? 1u : 0u) == 0)
				{
					goto IL_009c;
				}
			}
			goto IL_00b9;
			IL_00b9:
			return result;
			IL_009c:
			bool isBlown = IsBlown;
			result = (byte)((isBlown ? 1u : 0u) ^ 1u) != 0;
			goto IL_00b9;
		}
	}

	public float Burnt
	{
		get
		{
			if (Live)
			{
				return Burn;
			}
			return burnHere;
		}
	}

	public bool IsBlown
	{
		get
		{
			if (~(wentOff ? 1u : 0u) == 0)
			{
				return true;
			}
			if (Live)
			{
				NetworkBool blown = Blown;
				return blown;
			}
			bool flag = !blownHere;
			return !flag;
		}
	}

	public unsafe static bool InSpawn(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_007a: Expected VT, but got I
		//IL_0087: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4F8]");
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
		Bounds bounds = (Bounds)((nint)0 + (nint)16);
		Vector3 point = default;
		return ((Bounds*)bounds)->Internal_Contains(ref point);
	}

	private void SayNotHere(string line)
	{
		//IL_0010: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected I4, but got I8
		//IL_009c: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I
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
		bool flag2 = item == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		GillaItem gillaItem = item;
		int num = (int)(gillaItem.Hand__BackingField & 0x80000000L);
		bool flag4 = num == 0;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			bool flag5 = gillaItem.Hand__BackingField < 2;
			object obj6 = !flag5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
			object obj7 = 0;
			object obj8 = ~obj6;
			object obj9 = ~obj8;
			int hand = ((obj9 != null) ? 2 : gillaItem.Hand__BackingField);
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v7+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0738]");
			object title = 0;
			GillaToast.Show(hand, (string)title, line, error: true);
		}
	}

	public static bool InHand(int hand)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected I4, but got Unknown
		//IL_010a: Expected I4, but got Obj
		//IL_007c: Expected Obj, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00e9: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		GillaItem gillaItem = GillaHands.Holding(hand);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7;
		if (gillaItem != null)
		{
			if ((object)gillaItem != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A08]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
				object obj6 = default;
				object obj5 = obj6 & 1;
				if (obj5 == null)
				{
					goto IL_00ee;
				}
				GillaDynamite gillaDynamite = default;
				if ((object)gillaDynamite != null)
				{
					bool isBlown = gillaDynamite.IsBlown;
					obj7 = (isBlown ? 1 : 0) ^ 1;
					goto IL_014f;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_00ee;
		IL_014f:
		return (byte)(obj7 & 1) != 0;
		IL_00ee:
		obj7 = 0;
		goto IL_014f;
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_0258: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I
		//IL_0290: Expected Obj, but got I4
		//IL_02c8: Expected Obj, but got I4
		//IL_01ee: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 == null;
		bool flag3 = !flag2;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51E0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			UnityEngine.Object obj7 = default;
			item = (GillaItem)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj5 = obj7;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = fuse != null;
		bool flag6 = !flag5;
		UnityEngine.Object obj10 = null;
		Vector3 vector = default;
		if (!flag6)
		{
			Vector3 localPosition = fuse.localPosition;
			rootAt = vector;
			fuseAt = vector;
			obj10 = null;
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = spark != null;
		bool flag9 = !flag8;
		UnityEngine.Object obj13 = null;
		if (!flag9)
		{
			Vector3 localPosition2 = spark.localPosition;
			tipAt = vector;
			obj13 = null;
		}
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v17+E4]");
		bool flag10 = (nint)0 == 0;
		object obj15 = !flag10;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = hiss != null;
		bool flag12 = !flag11;
		float num = 0f;
		if (!flag12)
		{
			num = hiss.volume;
		}
		hissVolume = num;
		Show();
	}

	private void OnEnable()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0031: Expected I4, but got I8
		//IL_005d: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4F8]");
		object obj = 0;
		object obj2 = obj;
		Fusion.SimulationBehaviourRuntimeFlags flags = (Fusion.SimulationBehaviourRuntimeFlags)((long)((SimulationBehaviour)this).Flags & 0xFFFFFFEFL);
		((SimulationBehaviour)this).Flags = flags;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+A0]");
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
		//IL_0015: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4F8]");
		object obj = 0;
		object obj2 = obj;
		Fusion.SimulationBehaviourRuntimeFlags flags = ((SimulationBehaviour)this).Flags | (Fusion.SimulationBehaviourRuntimeFlags)0x10;
		((SimulationBehaviour)this).Flags = flags;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v5+A0]");
		object obj4 = 0;
		bool flag2 = ((List<System.__Canon>)obj4).Remove((System.__Canon)(object)this);
	}

	public unsafe override void Spawned()
	{
		//IL_0095: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I
		//IL_01d2: Expected Obj, but got I4
		//IL_03ab: Expected Obj, but got I
		//IL_03bb: Expected Obj, but got I
		//IL_03cb: Expected Obj, but got I
		//IL_03ed: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I4
		//IL_0219: Expected Obj, but got I4
		//IL_040b: Expected Obj, but got I
		//IL_0425: Expected Obj, but got I
		//IL_042d: Expected I, but got Obj
		//IL_043e: Expected I, but got Obj
		//IL_045c: Expected Obj, but got I
		//IL_047e: Expected I, but got Obj
		//IL_02f6: Expected Obj, but got I4
		//IL_0249: Expected Obj, but got I
		//IL_0323: Expected Obj, but got I
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj4 = default;
				object obj3 = obj4 & 1;
				bool flag2 = obj3 == null;
				object obj5 = !flag2;
				nint num = unchecked((nint)null);
				if (obj5 != null)
				{
					return;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4F8]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj6;
		}
		NetworkObject networkObject2 = ((SimulationBehaviour)this)._object;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+A0]");
		object obj9 = 0;
		int* ptr = networkObject2.Ptr;
		if (networkObject2.Ptr != null)
		{
			NetworkRunner runner = networkObject2._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v9 (System.Int32*)+20]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BD10");
			nint num2 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v32+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef none = PlayerRef.None;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0768]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v12+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v18+8]");
		Func<System.__Canon, bool> func = (Func<System.__Canon, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v18+8]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v12+E4]");
			bool flag7 = (nint)0 == 0;
			object obj19 = !flag7;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj20 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v22+A0]");
				obj16 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0750]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0760]");
			object obj22 = 0;
			nint num2 = (nint)obj22;
			Func<System.__Canon, bool> func2 = default;
			func2._002Ector(obj16, (IntPtr)obj22);
			object obj23 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v21+A0]");
			object obj24 = (nint)0 + (nint)8;
			obj24 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			func = func2;
			nint num = (nint)func2;
		}
		object obj25 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0758]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v14+E4]");
		bool flag8 = (nint)0 == 0;
		object obj27 = !flag8;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3627130");
		object obj28 = default;
		if ((nint)obj28 >= 12)
		{
			object obj29 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v18+E4]");
			bool flag9 = (nint)0 == 0;
			object obj30 = !flag9;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0770]");
			object what = 0;
			GillaNetGuard.Ignore(this, (string)what, 12);
		}
	}

	public unsafe static void ChainFrom(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0873: Expected Obj, but got I4
		//IL_0a12: Expected Obj, but got I
		//IL_0a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got I
		//IL_00aa: Expected F4, but got I
		//IL_00b3: Expected Obj, but got I4
		//IL_0679: Expected Obj, but got I4
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected Obj, but got I4
		//IL_0996: Expected I, but got Obj
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Expected Ref, but got Unknown
		//IL_09b9: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I4
		//IL_06b6: Expected Obj, but got I4
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected Obj, but got Unknown
		//IL_06f3: Expected I, but got Obj
		//IL_0728: Expected Obj, but got I4
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected I, but got Obj
		//IL_07c4: Expected Obj, but got I4
		//IL_07d5: Expected Obj, but got I4
		//IL_08c3: Expected Obj, but got I
		//IL_08e5: Expected Obj, but got I4
		//IL_0206: Invalid comparison between Obj and F8
		//IL_0217: Expected Obj, but got I4
		//IL_022f: Invalid comparison between F8 and I4
		//IL_0240: Expected Obj, but got I4
		//IL_091a: Expected Obj, but got I4
		//IL_02a9: Expected F4, but got I
		//IL_02dc: Expected Obj, but got I4
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected Obj, but got Unknown
		//IL_043d: Expected Obj, but got I4
		//IL_0302: Expected Obj, but got I
		//IL_0332: Expected F4, but got I
		//IL_0952: Expected Obj, but got I4
		//IL_095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_095f: Expected Obj, but got Unknown
		//IL_0978: Expected F4, but got I
		//IL_0474: Invalid comparison between F4 and I4
		//IL_0483: Invalid comparison between F4 and I4
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected Obj, but got Unknown
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected Obj, but got Unknown
		//IL_0350: Expected Obj, but got I
		//IL_0366: Expected Obj, but got I
		//IL_0380: Expected Obj, but got I4
		//IL_0399: Expected F4, but got I
		//IL_0504: Expected Obj, but got I
		//IL_0526: Expected Obj, but got I4
		//IL_055f: Expected VT, but got I4
		//IL_055f: Expected VT, but got I8
		//IL_057d: Expected Obj, but got I4
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected Obj, but got Unknown
		//IL_03d7: Expected Obj, but got I4
		//IL_03e7: Expected Obj, but got I
		//IL_0400: Expected F4, but got I
		//IL_05ea: Expected F4, but got I
		//IL_05ea: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4F8]");
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
		UnityEngine.Object obj4 = (UnityEngine.Object)0;
		bool flag2 = (object)obj4 == null;
		UnityEngine.Object obj6 = default;
		UnityEngine.Object obj5 = obj6;
		Enumerator<, > val = (Enumerator<, >)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0780]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0778]");
			object obj10 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)obj4).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj11 = 0;
			object obj13 = default;
			object obj12 = obj13;
			float num2 = default;
			float num = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
			float num3 = 0f;
			obj4 = (UnityEngine.Object)17276928;
			object obj19 = default;
			object obj30 = default;
			QueryTriggerInteraction queryTriggerInteraction = default;
			Enumerator<, > val2 = default;
			object obj47 = default;
			int num4;
			object obj43;
			float num13 = default;
			Enumerator<, > val3;
			while (true)
			{
				if (val.MoveNext())
				{
					object obj14 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X0_v29+E4]");
					obj4 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X0_v29+E4]");
					bool flag3 = (nint)0 == 0;
					object obj15 = !flag3;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = obj6 == null;
					bool flag5 = !flag4;
					object obj16 = !flag5;
					num4 = 0;
					if (obj16 != null)
					{
						continue;
					}
					nint num5;
					if ((object)obj6 != null)
					{
						Transform transform = ((Component)obj6).transform;
						bool flag6 = (object)transform == null;
						num5 = unchecked((nint)null);
						if (flag6)
						{
							break;
						}
						Vector3 position = transform.position;
						object obj17 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v40+E4]");
						obj4 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v40+E4]");
						bool flag7 = (nint)0 == 0;
						object obj18 = !flag7;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						obj12 -= obj13;
						num = (float)obj12 * (float)obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ stack_-B8 (UnityEngine.Object)+B0]");
						double num6 = 0.0 + 2.0;
						bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num6);
						object obj20 = !flag8;
						double num7 = (double)obj19 - num6;
						bool flag9 = num7 == 0.0;
						object obj21 = !flag9;
						object obj22 = obj20 & obj21;
						float num8 = (float)num6;
						if (obj22 == null)
						{
							num8 = Time.time;
						}
						bool isBlown = ((GillaDynamite)obj6).IsBlown;
						bool flag10 = !isBlown;
						object obj23 = !flag10;
						num4 = 0;
						num3 = num8;
						if (obj23 != null)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ stack_-B8 (UnityEngine.Object)+E4]");
						bool flag11 = (nint)0 >= (nint)0;
						num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ stack_-B8 (UnityEngine.Object)+E4]");
						num3 = 0f;
						if (flag11)
						{
							continue;
						}
						bool live = ((GillaDynamite)obj6).Live;
						bool flag12 = !live;
						object obj24 = 0;
						UnityEngine.Object obj25 = obj4;
						if (!flag12)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ stack_-B8 (UnityEngine.Object)+40]");
							object obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ stack_-B8 (UnityEngine.Object)+40]");
							bool flag13 = (nint)0 == 0;
							num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ stack_-B8 (UnityEngine.Object)+E4]");
							num3 = 0f;
							if (flag13)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v55+58]");
							obj4 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v55+58]");
							object obj27 = (nint)0 & (nint)2;
							bool flag14 = obj27 == null;
							object obj28 = !flag14;
							num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ stack_-B8 (UnityEngine.Object)+E4]");
							num3 = 0f;
							if (obj28 != null)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
							object obj29 = obj30 & 1;
							bool flag15 = obj29 == null;
							obj24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v55+58]");
							obj25 = (UnityEngine.Object)0;
							num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ stack_-B8 (UnityEngine.Object)+E4]");
							num3 = 0f;
							if (flag15)
							{
								continue;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
						object obj31 = obj19 - 0;
						bool flag16 = (nint)obj31 < 0;
						object obj32 = !flag16;
						object obj33 = ~obj32;
						bool flag17;
						bool flag18;
						bool flag19;
						if (obj33 == null)
						{
							float num9 = (float)obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ stack_-B8 (UnityEngine.Object)+B0]");
							float num10 = num9 - 0f;
							flag17 = num10 < 0f;
							flag18 = num10 == 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ stack_-B8 (UnityEngine.Object)+B0]");
							object obj34 = obj19 ^ 0;
							object obj35 = obj19 ^ num10;
							object obj36 = obj34 & obj35;
							flag19 = (nint)obj36 < 0;
						}
						else
						{
							flag19 = false;
							flag18 = false;
							flag17 = false;
						}
						bool flag20 = flag17 == flag19;
						object obj37 = !flag18;
						object obj38 = flag20 & obj37;
						num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ stack_-B8 (UnityEngine.Object)+B0]");
						num3 = 0f;
						obj4 = obj25;
						if (obj38 == null)
						{
							object obj39 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X0_v48+E4]");
							obj4 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X0_v48+E4]");
							bool flag21 = (nint)0 == 0;
							object obj40 = !flag21;
							if (obj40 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag22 = Physics.Linecast((Vector3)4294961403L, (Vector3)1, 0, queryTriggerInteraction);
							bool flag23 = !flag22;
							object obj41 = !flag23;
							object obj42 = obj12;
							float num11 = num;
							float num12 = num3;
							obj12 = obj13;
							num = num2;
							num4 = 0;
							num3 = num13;
							if (obj41 == null)
							{
								float time = Time.time;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
								nint num14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
								float num15 = UnityEngine.Random.Range(num14, 0f);
								float num16 = (float)obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
								float num17 = num16 * 0f;
								float num18 = num17 + time;
								float num19 = num18 + num15;
								obj42 = obj13;
								num11 = num2;
								num12 = num13;
								obj12 = obj13;
								num = num18;
								num4 = 0;
								num3 = num19;
							}
						}
						continue;
					}
					NullReferenceException ex = new NullReferenceException();
					num5 = unchecked((nint)null);
					break;
				}
				obj5 = null;
				obj43 = 0;
				val = val2;
				val3 = (Enumerator<, >)(ref val);
				object obj44 = 0;
				while (true)
				{
					nint num5 = (nint)obj10;
					((Enumerator<, >*)val3)->Dispose();
					bool flag24 = obj44 == null;
					object obj45 = !flag24;
					obj13 = obj12;
					num2 = num;
					num13 = num3;
					if (obj45 == null)
					{
						bool flag25 = (object)obj5 == null;
						object obj46 = !flag25;
						obj13 = obj12;
						num2 = num;
						num13 = num3;
						OutOfMemoryException ex2 = (OutOfMemoryException)val3;
						if (obj46 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex2 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch ((long)num5)
					{
					case 2L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj12 = obj13;
						num = num2;
						obj5 = (UnityEngine.Object)1;
						num3 = num13;
						obj4 = (UnityEngine.Object)1;
						obj44 = obj43;
						break;
					case 1L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj44 = obj47;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj12 = obj13;
						num = num2;
						obj43 = obj47;
						num3 = num13;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0BA8");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
				}
				return;
			}
			NullReferenceException ex3 = new NullReferenceException();
			obj13 = obj12;
			num2 = num;
			num4 = 0;
			obj5 = null;
			obj43 = 0;
			val = val2;
			num13 = num3;
			val3 = (Enumerator<, >)(ref val);
		}
		throw new NullReferenceException();
	}

	private void Update()
	{
		//IL_0e35: Expected Obj, but got I
		//IL_0e58: Invalid comparison between F4 and I4
		//IL_0106: Invalid comparison between F4 and I4
		//IL_00aa: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got I4
		//IL_02f5: Expected Obj, but got I
		//IL_031f: Expected Obj, but got I4
		//IL_037f: Expected Obj, but got I
		//IL_038f: Expected Obj, but got I
		//IL_06c3: Invalid comparison between F4 and I4
		//IL_0298: Expected Obj, but got I4
		//IL_0eef: Expected Obj, but got I4
		//IL_094c: Expected Obj, but got I4
		//IL_0954: Expected VT, but got Obj
		//IL_0ebd: Expected Obj, but got I4
		//IL_02bc: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got I4
		//IL_0975: Expected VT, but got Obj
		//IL_0c03: Expected Obj, but got I4
		//IL_083a: Expected Obj, but got I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_0999: Expected Obj, but got I4
		//IL_09a1: Expected VT, but got Obj
		//IL_073a: Expected Obj, but got I4
		//IL_0754: Expected Obj, but got I4
		//IL_0650: Expected Obj, but got I4
		//IL_086a: Expected VT, but got Obj
		//IL_088c: Expected Obj, but got I4
		//IL_0449: Expected Obj, but got I4
		//IL_09f7: Invalid comparison between F4 and I4
		//IL_0a06: Invalid comparison between F4 and I4
		//IL_0a1e: Expected Obj, but got F8
		//IL_0a2b: Expected Obj, but got F4
		//IL_0a60: Expected Obj, but got I4
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6d: Expected Obj, but got Unknown
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Expected Obj, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected Obj, but got Unknown
		//IL_0f3f: Expected VT, but got Obj
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected Obj, but got Unknown
		//IL_0488: Expected Obj, but got I4
		//IL_0c96: Expected Obj, but got I4
		//IL_0ca9: Expected Obj, but got I4
		//IL_0cc3: Expected Obj, but got I4
		//IL_08f3: Expected Obj, but got I
		//IL_0dfa: Expected Obj, but got VT
		//IL_0acb: Expected Obj, but got I4
		//IL_04c0: Expected Obj, but got I4
		//IL_0505: Expected Obj, but got I4
		//IL_0b3b: Expected Obj, but got I4
		//IL_0b8d: Expected VT, but got I4
		//IL_0ba3: Expected Obj, but got I4
		//IL_0bac: Expected VT, but got I4
		//IL_0d79: Expected Obj, but got I4
		//IL_0560: Expected Obj, but got I4
		//IL_0fad: Expected F4, but got I
		//IL_0597: Expected Obj, but got I4
		//IL_05a0: Expected Obj, but got I4
		//IL_05d7: Expected Obj, but got I4
		//IL_05e0: Expected Obj, but got I4
		//IL_0602: Expected Obj, but got I4
		bool live = Live;
		bool flag = !live;
		IntPtr intPtr = default;
		NetworkObject networkObject = (NetworkObject)(nint)intPtr;
		object obj = default;
		if (!flag)
		{
			if (holder == null)
			{
				goto IL_0dff;
			}
			networkObject = ((SimulationBehaviour)this)._object;
			holder.Watch(((SimulationBehaviour)this)._object);
			obj = 0;
		}
		NetworkObject networkObject2;
		if (Live)
		{
			NetworkBool lit = Lit;
			bool flag2 = lit;
			bool flag3 = !flag2;
			object obj2 = !flag3;
			networkObject = null;
			networkObject2 = null;
			if (obj2 == null)
			{
				goto IL_00c2;
			}
		}
		else
		{
			bool flag4 = (byte)(~(litHere ? 1u : 0u)) != 0;
			networkObject2 = networkObject;
			if (flag4)
			{
				goto IL_00c2;
			}
		}
		if (litSince < 0f)
		{
			float time = Time.time;
			litSince = time;
		}
		goto IL_0e43;
		IL_0b75:
		Transform transform;
		Vector3 position = transform.position;
		GoOff((Vector3)0);
		double num = 1.0;
		obj = 0;
		Vector3 vector = (Vector3)0;
		goto IL_0bb1;
		IL_0e6c:
		if (IsLit)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X0_v85+E4]");
			bool flag5 = (nint)0 == 0;
			object obj5 = !flag5;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaRip.MakeOneMore();
		}
		bool[] array = was;
		object obj6;
		object obj7;
		if (was != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4F8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj7 = 0;
			if (array.Length < 1)
			{
				goto IL_06ae;
			}
			object obj8 = obj;
			NetworkObject networkObject3 = networkObject2;
			int num2 = 0;
			while (true)
			{
				object obj9 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v69+E4]");
				bool flag6 = (nint)0 == 0;
				object obj10 = !flag6;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (Button(num2))
				{
					bool[] array2 = was;
					if (was == null)
					{
						break;
					}
					bool flag7 = num2 < array2.Length;
					object obj11 = !flag7;
					if (obj11 != null)
					{
						goto IL_0e0d;
					}
					object obj12 = was + num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v41+20]");
					bool flag8 = (nint)0 == 0;
					object obj13 = !flag8;
					if (obj13 == null)
					{
						object obj14 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X0_v74+E4]");
						bool flag9 = (nint)0 == 0;
						object obj15 = !flag9;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag10 = item != null;
						bool flag11 = !flag10;
						obj8 = 0;
						networkObject3 = null;
						if (!flag11)
						{
							GillaItem gillaItem = item;
							if ((object)item == null)
							{
								break;
							}
							bool flag12 = num2 != gillaItem.Hand__BackingField;
							obj8 = 0;
							networkObject3 = null;
							if (!flag12)
							{
								bool isLit = IsLit;
								bool flag13 = !isLit;
								object obj16 = !flag13;
								obj8 = 0;
								networkObject3 = null;
								if (obj16 == null)
								{
									bool isBlown = IsBlown;
									bool flag14 = !isBlown;
									object obj17 = !flag14;
									obj8 = 0;
									networkObject3 = null;
									if (obj17 == null)
									{
										Light();
										obj8 = 0;
										networkObject3 = null;
									}
								}
							}
						}
					}
				}
				bool[] array3 = was;
				if (was == null)
				{
					break;
				}
				bool flag15 = num2 < array3.Length;
				object obj18 = !flag15;
				if (obj18 == null)
				{
					object obj19 = was + num2;
					num2++;
					bool flag16 = num2 < array3.Length;
					obj = obj8;
					networkObject2 = networkObject3;
					if (flag16)
					{
						continue;
					}
					goto IL_06ae;
				}
				goto IL_0e0d;
			}
		}
		goto IL_0dff;
		IL_06ae:
		float num3 = lightWaits;
		float num4 = default;
		if (!(lightWaits < 0f))
		{
			if (Live)
			{
				NetworkObject networkObject4 = ((SimulationBehaviour)this)._object;
				if ((object)((SimulationBehaviour)this)._object != null)
				{
					object obj20 = networkObject4.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
					bool flag17 = obj20 == null;
					object obj21 = !flag17;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
						object obj23 = default;
						object obj22 = obj23 & 1;
						bool flag18 = obj22 == null;
						networkObject2 = null;
						if (!flag18)
						{
							lightWaits = -1f;
							Light();
							networkObject2 = null;
							goto IL_0ecb;
						}
					}
				}
			}
			num3 = Time.time;
			num4 = lightWaits;
			if (num3 > lightWaits)
			{
				lightWaits = -1f;
			}
		}
		goto IL_0ecb;
		IL_0dff:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0e0d;
		IL_0ecb:
		bool live2 = Live;
		bool flag19 = !live2;
		object obj24 = !flag19;
		num = num4;
		string text = (string)(object)networkObject2;
		if (obj24 == null)
		{
			bool flag20 = (byte)(~(litHere ? 1u : 0u)) != 0;
			num = num4;
			text = (string)(object)networkObject2;
			if (!flag20)
			{
				bool flag21 = (byte)(~(blownHere ? 1u : 0u)) != 0;
				object obj25 = !flag21;
				num = num4;
				text = (string)(object)networkObject2;
				if (obj25 == null)
				{
					Vector3 vector2 = Where;
					Vector3 at = (Vector3)obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X0_v57 (UnityEngine.Vector3)+E4]");
					bool flag22 = (nint)0 == 0;
					object obj26 = !flag22;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag23 = InSpawn(at);
					bool flag24 = !flag23;
					num = num4;
					text = (string)(object)networkObject2;
					if (!flag24)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0798]");
						object obj27 = 0;
						litHere = false;
						burnHere = 0f;
						text = (string)obj27;
						SayNotHere((string)obj27);
						num = num4;
					}
				}
			}
		}
		bool live3 = Live;
		bool flag25 = !live3;
		object obj28 = !flag25;
		vector = (Vector3)text;
		if (obj28 == null)
		{
			bool flag26 = (byte)(~(litHere ? 1u : 0u)) != 0;
			vector = (Vector3)text;
			if (!flag26)
			{
				bool flag27 = (byte)(~(blownHere ? 1u : 0u)) != 0;
				object obj29 = !flag27;
				vector = (Vector3)text;
				if (obj29 == null)
				{
					float deltaTime = Time.deltaTime;
					float num5 = deltaTime / fuseSeconds;
					num3 = burnHere + num5;
					float num6 = num3 - 1f;
					bool flag28 = num6 < 0f;
					bool flag29 = num6 == 0f;
					object obj30 = (double)num3 ^ 1.0;
					object obj31 = num3 ^ num6;
					object obj32 = obj30 & obj31;
					bool flag30 = (nint)obj32 < 0;
					bool flag31 = flag28 == flag30;
					object obj33 = !flag29;
					object obj34 = flag31 & obj33;
					object obj35 = ~obj34;
					if (obj35 == null)
					{
						num3 = 1f;
					}
					burnHere = num3;
					bool flag32 = (double)num3 < 1.0;
					num = 1.0;
					vector = (Vector3)text;
					if (!flag32)
					{
						object obj36 = obj7;
						blownHere = true;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X0_v43+E4]");
						bool flag33 = (nint)0 == 0;
						object obj37 = !flag33;
						if (obj37 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (spark != null)
						{
							transform = spark;
							bool flag34 = (object)spark == null;
							object obj38 = !flag34;
							if (obj38 != null)
							{
								goto IL_0b75;
							}
						}
						else
						{
							transform = base.transform;
							if ((object)transform != null)
							{
								goto IL_0b75;
							}
						}
						goto IL_0dff;
					}
				}
			}
		}
		goto IL_0bb1;
		IL_0e0d:
		throw new IndexOutOfRangeException();
		IL_0bb1:
		if (IsLit)
		{
			object obj39 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X0_v28+E4]");
			bool flag35 = (nint)0 == 0;
			object obj40 = !flag35;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (item != null)
			{
				GillaItem gillaItem2 = item;
				if ((object)item == null)
				{
					goto IL_0dff;
				}
				bool flag36 = gillaItem2.Hand__BackingField < 1;
				object obj41 = !flag36;
				object obj42 = gillaItem2.Hand__BackingField - 1;
				bool flag37 = obj42 == null;
				object obj43 = !flag37;
				object obj44 = obj41 & obj43;
				if (obj44 == null)
				{
					float time2 = Time.time;
					if (!(time2 < buzzAt))
					{
						float time3 = Time.time;
						GillaItem gillaItem3 = item;
						float num7 = time3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD80]");
						float num8 = num7 + 0f;
						buzzAt = num8;
						if ((object)item == null)
						{
							goto IL_0dff;
						}
						bool flag38 = gillaItem3.Hand__BackingField == 0;
						object obj45 = !flag38;
						object obj46 = ~obj45;
						XRNode node = ((obj46 != null) ? ((XRNode)4) : ((XRNode)5));
						UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
						float burnt = Burnt;
						float num9 = burnt * 0.25f;
						float num10 = num9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
						float amplitude = num10 + 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
						UnityEngine.XR.InputDevice inputDevice = default;
						bool flag39 = inputDevice.SendHapticImpulse(0u, amplitude, 0f);
					}
				}
			}
		}
		Show();
		return;
		IL_00c2:
		litSince = -1f;
		networkObject2 = networkObject;
		goto IL_0e43;
		IL_0e43:
		float num11 = chainAt;
		if (!(chainAt < 0f))
		{
			num11 = Time.time;
			num4 = chainAt;
			if (!(num11 < chainAt))
			{
				chainAt = -1f;
				if (Live)
				{
					NetworkObject networkObject5 = ((SimulationBehaviour)this)._object;
					if ((object)((SimulationBehaviour)this)._object != null)
					{
						object obj47 = networkObject5.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
						bool flag40 = obj47 == null;
						object obj48 = !flag40;
						if (obj48 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
							object obj50 = default;
							object obj49 = obj50 & 1;
							bool flag41 = obj49 == null;
							networkObject2 = null;
							if (!flag41)
							{
								NetworkBool blown = Blown;
								bool flag42 = blown;
								bool flag43 = !flag42;
								networkObject2 = null;
								if (flag43)
								{
									NetworkBool networkBool = (Lit = true);
									Burn = 1f;
									num11 = 1f;
									networkObject2 = (NetworkObject)networkBool;
									goto IL_0e6c;
								}
							}
						}
					}
				}
				bool live4 = Live;
				bool flag44 = !live4;
				object obj51 = !flag44;
				if (obj51 == null)
				{
					bool flag45 = (byte)(~(blownHere ? 1u : 0u)) != 0;
					object obj52 = !flag45;
					if (obj52 == null)
					{
						litHere = true;
						burnHere = 1f;
					}
				}
			}
		}
		goto IL_0e6c;
	}

	private void Light()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02f9: Expected VT, but got Obj
		//IL_031b: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I
		//IL_0339: Expected Obj, but got I
		//IL_0363: Expected Obj, but got I4
		//IL_0190: Expected I, but got VT
		//IL_00d7: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_012b: Expected I, but got Obj
		//IL_0246: Expected Obj, but got I4
		//IL_0259: Expected Obj, but got I4
		//IL_0273: Expected Obj, but got I4
		//IL_02ad: Expected Obj, but got I4
		//IL_03a4: Expected F4, but got I
		//IL_03a4: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4F8]");
		object obj = 0;
		Vector3 vector = Where;
		Vector3 at = (Vector3)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v5 (UnityEngine.Vector3)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (InSpawn(at))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D07A0]");
			object line = 0;
			lightWaits = -1f;
			SayNotHere((string)line);
			return;
		}
		if (Live)
		{
			NetworkObject networkObject = ((SimulationBehaviour)this)._object;
			if ((object)((SimulationBehaviour)this)._object != null)
			{
				object obj3 = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
				bool flag2 = obj3 == null;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
					object obj6 = default;
					object obj5 = obj6 & 1;
					bool flag3 = obj5 == null;
					nint num = unchecked((nint)null);
					if (!flag3)
					{
						goto IL_0139;
					}
				}
			}
			float time = Time.time;
			float num2 = time + 1.5f;
			lightWaits = num2;
			return;
		}
		goto IL_0139;
		IL_0139:
		if (Live)
		{
			NetworkBool networkBool = (Lit = true);
			Burn = 0f;
			nint num = (nint)networkBool;
		}
		else
		{
			burnHere = 0f;
			litHere = true;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (item != null)
		{
			GillaItem gillaItem = item;
			bool flag5 = gillaItem.Hand__BackingField < 1;
			object obj10 = !flag5;
			object obj11 = gillaItem.Hand__BackingField - 1;
			bool flag6 = obj11 == null;
			object obj12 = !flag6;
			object obj13 = obj10 & obj12;
			if (obj13 == null)
			{
				bool flag7 = gillaItem.Hand__BackingField == 0;
				object obj14 = !flag7;
				object obj15 = ~obj14;
				XRNode node = ((obj15 != null) ? ((XRNode)4) : ((XRNode)5));
				UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
				UnityEngine.XR.InputDevice inputDevice = default;
				bool flag8 = inputDevice.SendHapticImpulse(0u, num3, 0f);
			}
		}
	}

	public unsafe override void FixedUpdateNetwork()
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I
		//IL_010a: Expected VT, but got Obj
		//IL_012c: Expected Obj, but got I4
		//IL_0216: Invalid comparison between F4 and I4
		//IL_0225: Invalid comparison between F4 and I4
		//IL_023d: Expected Obj, but got F8
		//IL_024a: Expected Obj, but got F4
		//IL_027f: Expected Obj, but got I4
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_01ab: Expected Obj, but got I
		//IL_02e2: Expected Obj, but got I
		//IL_030c: Expected Obj, but got I4
		//IL_03af: Expected Obj, but got I4
		//IL_0381: Expected VT, but got I4
		//IL_0381: Expected VT, but got Ref
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object == null)
		{
			return;
		}
		object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
		object obj4 = default;
		object obj3 = obj4 & 1;
		if (obj3 == null)
		{
			return;
		}
		NetworkBool lit = Lit;
		if (!lit)
		{
			return;
		}
		NetworkBool blown = Blown;
		if ((bool)blown)
		{
			return;
		}
		Vector3 vector = Where;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4F8]");
		object obj5 = 0;
		Vector3 at = (Vector3)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v16 (UnityEngine.Vector3)+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (InSpawn(at))
		{
			NetworkBool lit2 = false;
			Lit = lit2;
			Burn = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0798]");
			object line = 0;
			SayNotHere((string)line);
			return;
		}
		float burn = Burn;
		float deltaTime = ((SimulationBehaviour)this)._runner.DeltaTime;
		float num = deltaTime / fuseSeconds;
		float num2 = burn + num;
		float num3 = num2 - 1f;
		bool flag3 = num3 < 0f;
		bool flag4 = num3 == 0f;
		object obj7 = (double)num2 ^ 1.0;
		object obj8 = num2 ^ num3;
		object obj9 = obj7 & obj8;
		bool flag5 = (nint)obj9 < 0;
		bool flag6 = flag3 == flag5;
		object obj10 = !flag4;
		object obj11 = flag6 & obj10;
		object obj12 = ~obj11;
		if (obj12 == null)
		{
			num2 = 1f;
		}
		Burn = num2;
		float burn2 = Burn;
		if ((double)burn2 < 1.0)
		{
			return;
		}
		NetworkBool blown2 = true;
		Blown = blown2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v27+E4]");
		bool flag7 = (nint)0 == 0;
		object obj15 = !flag7;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform transform;
		if (spark != null)
		{
			transform = spark;
		}
		else
		{
			transform = base.transform;
			bool flag8 = (object)transform == null;
			object obj16 = !flag8;
			if (obj16 == null)
			{
				throw new NullReferenceException();
			}
		}
		Vector3 position = transform.position;
		object obj17 = default;
		RPC_GoOff((Vector3)(&obj17), (RpcInfo)0);
	}

	public unsafe void RPC_GoOff(Vector3 at, RpcInfo info = default(RpcInfo))
	{
		//IL_00ab: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I4
		//IL_003d: Expected VT, but got I4
		//IL_05b8: Expected Obj, but got I4
		//IL_05c1: Expected VT, but got I4
		//IL_0058: Expected VT, but got F4
		//IL_006b: Expected VT, but got F4
		//IL_0179: Expected Obj, but got VT
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_01a1: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I4
		//IL_02d0: Expected Obj, but got I
		//IL_02e2: Expected VT, but got I8
		//IL_02fd: Expected Obj, but got I4
		//IL_0320: Expected Obj, but got VT
		//IL_033a: Expected Obj, but got I4
		//IL_0342: Expected I4, but got VT
		//IL_034b: Expected VT, but got I4
		//IL_060c: Expected Obj, but got I4
		//IL_03af: Expected Obj, but got I4
		//IL_03b8: Expected Obj, but got I4
		//IL_03c0: Expected VT, but got Ref
		//IL_03c8: Expected I, but got VT
		//IL_03d0: Expected Obj, but got Ref
		//IL_03d9: Expected Obj, but got I4
		//IL_03e1: Expected Obj, but got Ref
		//IL_03ea: Expected Obj, but got I4
		//IL_03f2: Expected I4, but got VT
		//IL_01f0: Expected Obj, but got I4
		//IL_01f5: Expected VT, but got Obj
		//IL_01fe: Expected VT, but got I4
		//IL_066b: Expected Ref, but got VT
		//IL_0685: Expected Obj, but got I4
		//IL_07b1: Expected Obj, but got I4
		//IL_0369: Expected Obj, but got I
		//IL_0371: Expected I4, but got Obj
		//IL_0383: Expected I4, but got Obj
		//IL_0383: Expected VT, but got I4
		//IL_021d: Invalid comparison between VT and I4
		//IL_06d1: Expected Obj, but got I4
		//IL_069c: Expected Obj, but got I4
		//IL_06a4: Expected Obj, but got VT
		//IL_06ad: Expected Obj, but got I4
		//IL_044c: Expected Obj, but got I
		//IL_0476: Expected Obj, but got I4
		//IL_023a: Invalid comparison between VT and I4
		//IL_024c: Expected Obj, but got I4
		//IL_0251: Expected VT, but got Obj
		//IL_025a: Expected VT, but got I4
		//IL_071f: Expected Obj, but got I
		//IL_072f: Expected Obj, but got I
		//IL_042e: Expected Obj, but got I4
		//IL_0580: Expected native int or pointer, but got VT
		//IL_058f: Expected I, but got Obj
		//IL_0598: Expected VT, but got I4
		//IL_04ab: Expected Obj, but got I
		//IL_04b4: Expected VT, but got Obj
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected I4, but got Unknown
		//IL_04ef: Expected Obj, but got I4
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected I4, but got Unknown
		//IL_053e: Expected VT, but got I4
		//IL_053e: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		RpcInfo rpcInfo = default;
		PlayerRef playerRef = (PlayerRef)rpcInfo;
		RpcChannel rpcChannel = (RpcChannel)0;
		object obj;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder2 = default;
		Fusion.RpcDataWriter writer;
		object obj4 = default;
		PlayerRef playerRef2;
		RpcInvokeInfo rpcInvokeInfo2;
		int num;
		Fusion.RpcBuilder rpcBuilder3;
		NullReferenceException ex;
		object obj11;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			object obj2 = obj;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj3 = !flag3;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				Fusion.RpcBuilder rpcBuilder = networkRunner.CreateRpcBuilder(1421761683u, bytePayloadSize, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder2.Prepare(out writer);
				obj4 = rpcInvokeInfo >> 32;
				object obj5 = obj4 - 522;
				bool flag4 = (nint)obj5 < 2;
				object obj6 = !flag4;
				object obj7 = ~obj6;
				object obj8;
				PlayerRef playerRef3;
				if (obj7 == null && (nint)obj4 != 518)
				{
					bool flag5 = (nint)obj4 != 524;
					obj8 = 0;
					playerRef2 = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					playerRef3 = invalid;
					if (flag5)
					{
						goto IL_0312;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag6 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						obj8 = 0;
						playerRef2 = (PlayerRef)this;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						playerRef3 = invalid;
						if (flag6)
						{
							goto IL_0312;
						}
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v60+E4]");
				bool flag7 = (nint)0 == 0;
				object obj10 = !flag7;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D07B0]");
				object rpc = 0;
				playerRef2 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef2);
				obj8 = 0;
				rpcInvokeInfo2 = rpcInvokeInfo;
				playerRef3 = none;
				goto IL_0312;
			}
			ex = new NullReferenceException();
			obj11 = 0;
			rpcBuilder3 = (Fusion.RpcBuilder)0;
			num = bytePayloadSize;
			goto IL_05ce;
		}
		goto IL_0005;
		IL_0797:
		object obj12 = default;
		bool flag8 = obj12 == null;
		object obj13 = !flag8;
		object obj14;
		nint num3;
		if (obj13 == null)
		{
			if ((nint)obj14 != 7)
			{
				bool flag9 = obj14 == null;
				object obj15 = !flag9;
				if (obj15 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v12+E4]");
			bool flag10 = (nint)0 == 0;
			object obj18 = !flag10;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj16;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v12+A0]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v7+18]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D07A8]");
				object obj21 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj21);
				object obj22 = obj;
				int num2 = num | obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X8_v12+E4]");
				bool flag11 = (nint)0 == 0;
				object obj23 = !flag11;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(networkRunner & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num2, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v83 @ X26_v3+18] (should have been resolved before IL gen)");
				object obj24 = default;
				obj12 = obj24;
			}
			if (num != 0)
			{
				return;
			}
			RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			float x = default;
			((Vector3*)(nint)at)->x = x;
			num3 = unchecked((nint)null);
			playerRef = (PlayerRef)0;
			rpcChannel = (RpcChannel)0;
			goto IL_0005;
		}
		goto IL_05ce;
		IL_0774:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0312:
		object obj25 = rpcInvokeInfo >> 32;
		bool flag12 = obj25 == null;
		object obj26 = !flag12;
		int num4 = (int)rpcInvokeInfo2;
		rpcBuilder3 = (Fusion.RpcBuilder)0;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj27 = 0;
			num4 = (int)obj27;
			writer.Write((Vector3)12, (int)obj27);
			int num5 = rpcBuilder2.Send();
			Fusion.RpcBuilder rpcBuilder4 = default;
			rpcBuilder3 = rpcBuilder4;
		}
		rpcBuilder2.Dispose();
		obj12 = 0;
		object obj28 = 0;
		Fusion.RpcBuilder rpcBuilder5 = (Fusion.RpcBuilder)(&rpcBuilder2);
		num3 = (nint)playerRef2;
		networkRunner = (NetworkRunner)(&writer);
		obj11 = 0;
		ex = (NullReferenceException)(&rpcBuilder2);
		obj14 = 7;
		num = (int)rpcInvokeInfo;
		goto IL_0797;
		IL_05ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj29;
		OutOfMemoryException ex2;
		if ((nint)obj11 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj29 = obj28;
			obj12 = 1;
		}
		else
		{
			bool flag13 = (nint)obj11 != 1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag13)
			{
				goto IL_0774;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj30 = default;
			obj29 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj28 = obj30;
		}
		((Fusion.RpcBuilder*)rpcBuilder5)->Dispose();
		bool flag14 = obj29 == null;
		object obj31 = !flag14;
		if (obj31 == null)
		{
			obj11 = 0;
			ex = (NullReferenceException)rpcBuilder5;
			obj14 = 0;
			goto IL_0797;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		obj11 = 0;
		goto IL_0774;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (UnityEngine.Vector3)+18]");
		object obj32 = (nint)0 & (nint)1;
		bool flag15 = obj32 == null;
		object obj33 = !flag15;
		Vector3 at2 = (Vector3)rpcChannel;
		if (obj33 == null)
		{
			at2 = (Vector3)at.y;
			if (!WentOffThere((Vector3)at.y, playerRef))
			{
				return;
			}
		}
		GoOff(at2);
	}

	private bool WentOffThere(Vector3 at, PlayerRef from)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03f7: Expected Obj, but got I4
		//IL_002e: Expected VT, but got I4
		//IL_03cd: Expected I4, but got Obj
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected VT, but got Unknown
		//IL_015f: Expected Obj, but got I
		//IL_0167: Expected VT, but got Obj
		//IL_0189: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I4
		//IL_01ed: Expected VT, but got Obj
		//IL_020f: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I4
		//IL_026c: Invalid comparison between F4 and I4
		//IL_02dc: Invalid comparison between F4 and I4
		//IL_02ef: Expected Obj, but got F4
		//IL_02fc: Expected Obj, but got F4
		//IL_043c: Invalid comparison between F4 and I4
		//IL_044d: Expected Obj, but got I4
		//IL_0378: Expected Obj, but got I4
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (NetworkApe.Sane((Vector3)0))
		{
			if (holder == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			PlayerRef playerRef = (PlayerRef)(at & 0xFFFFFFFFL);
			if (holder.Is(((SimulationBehaviour)this)._object, playerRef))
			{
				Vector3 vector = Where;
				object obj5 = default;
				object obj4 = obj5 - obj5;
				object obj7 = default;
				object obj6 = obj7 - obj7;
				float num2 = default;
				float num = num2 - num2;
				object obj8 = obj4 * obj4;
				object obj9 = obj6 * obj6;
				object obj10 = obj8 + obj9;
				float num3 = num * num;
				float num4 = num3 + (float)obj10;
				if (!((double)num4 > 9.0))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4F8]");
					object obj11 = 0;
					Vector3 at2 = (Vector3)obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v14 (UnityEngine.Vector3)+E4]");
					bool flag2 = (nint)0 == 0;
					object obj12 = !flag2;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag3 = InSpawn(at2);
					bool flag4 = !flag3;
					object obj13 = !flag4;
					if (obj13 == null)
					{
						Vector3 vector2 = Where;
						Vector3 at3 = (Vector3)obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v19 (UnityEngine.Vector3)+E4]");
						bool flag5 = (nint)0 == 0;
						object obj14 = !flag5;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag6 = InSpawn(at3);
						bool flag7 = !flag6;
						object obj15 = !flag7;
						if (obj15 == null)
						{
							bool flag8;
							if (litSince < 0f)
							{
								flag8 = false;
							}
							else
							{
								float time = Time.time;
								float num5 = time - litSince;
								float num6 = fuseSeconds;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
								float num7 = num6 * 0f;
								float num8 = num5 - num7;
								bool flag9 = num8 < 0f;
								object obj16 = num5 ^ num7;
								object obj17 = num5 ^ num8;
								object obj18 = obj16 & obj17;
								bool flag10 = (nint)obj18 < 0;
								bool flag11 = flag9 == flag10;
								flag8 = flag11;
							}
							float time2 = Time.time;
							float num9 = time2 - blastNearAt;
							float num10 = num9 - 2f;
							bool flag12 = num10 < 0f;
							object obj19 = !flag12;
							object obj20 = ~obj19;
							if (obj20 != null || flag8)
							{
								object obj21 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v23+E4]");
								bool flag13 = (nint)0 == 0;
								object obj22 = !flag13;
								if (obj22 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								PlayerRef playerRef2 = (PlayerRef)(at & 0xFFFFFFFFL);
								return NetworkApe.InBudget(playerRef2);
							}
						}
					}
				}
			}
		}
		return false;
	}

	private void GoOff(Vector3 at)
	{
		//IL_05c2: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I4
		//IL_015e: Expected VT, but got I4
		//IL_02ba: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I
		//IL_01f9: Invalid comparison between Obj and F8
		//IL_05dd: Invalid comparison between Obj and F8
		//IL_03f5: Expected I4, but got I8
		//IL_040f: Expected Obj, but got I4
		//IL_0601: Invalid comparison between Obj and F8
		//IL_036d: Expected Obj, but got I4
		//IL_0387: Expected Obj, but got I4
		//IL_063a: Expected Obj, but got I4
		//IL_047f: Expected Obj, but got I8
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected Obj, but got Unknown
		//IL_0496: Expected Obj, but got I4
		//IL_049f: Expected Obj, but got I4
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_0282: Expected VT, but got I4
		//IL_0282: Expected VT, but got I4
		//IL_028b: Expected VT, but got I4
		//IL_0661: Expected Obj, but got I4
		//IL_04ce: Expected Obj, but got I4
		//IL_04fd: Expected Obj, but got I
		//IL_0519: Expected Obj, but got I4
		//IL_055f: Expected Obj, but got I4
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected Obj, but got Unknown
		//IL_0542: Expected Obj, but got I
		//IL_054b: Expected Obj, but got I4
		bool flag = (byte)(~(wentOff ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		wentOff = true;
		Show();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform transform;
		if (spark != null)
		{
			transform = spark;
			bool flag3 = (object)spark == null;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				goto IL_05a5;
			}
		}
		else
		{
			transform = base.transform;
		}
		Vector3 position = transform.position;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = blast != null;
		bool flag6 = !flag5;
		Vector3 vector = (Vector3)0;
		if (!flag6)
		{
			object obj9 = default;
			object obj8 = obj9 - obj9;
			object obj11 = default;
			object obj10 = obj11 - obj11;
			object obj13 = default;
			object obj12 = obj13 - obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
			object obj14 = 0;
			object obj15 = obj14;
			object obj16 = obj8 * obj8;
			object obj17 = obj10 * obj10;
			object obj18 = obj16 + obj17;
			object obj19 = obj12 * obj12;
			object obj20 = obj19 + obj18;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)4.0))
			{
				object obj21 = obj13;
			}
			else
			{
				object obj21 = obj13;
			}
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)4.0))
			{
				object obj22 = obj11;
			}
			else
			{
				object obj22 = obj11;
			}
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)4.0))
			{
				object obj23 = obj9;
			}
			else
			{
				object obj23 = obj9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v41+E4]");
			bool flag7 = (nint)0 == 0;
			object obj24 = !flag7;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaBlast.Go(blast, (Vector3)0, (Vector3)0);
			vector = (Vector3)0;
		}
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v17+E4]");
		bool flag8 = (nint)0 == 0;
		object obj26 = !flag8;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (item == null)
		{
			return;
		}
		bool live = Live;
		bool flag9 = !live;
		UnityEngine.Object obj27 = null;
		if (!flag9)
		{
			NetworkObject networkObject = ((SimulationBehaviour)this)._object;
			if ((object)((SimulationBehaviour)this)._object == null)
			{
				return;
			}
			object obj28 = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag10 = obj28 == null;
			object obj29 = !flag10;
			if (obj29 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
			object obj31 = default;
			object obj30 = obj31 & 1;
			bool flag11 = obj30 == null;
			obj27 = null;
			if (flag11)
			{
				return;
			}
		}
		GillaItem gillaItem = item;
		int num = (int)(gillaItem.Hand__BackingField & 0x80000000L);
		bool flag12 = num == 0;
		object obj32 = !flag12;
		if (obj32 == null)
		{
			GillaHands.Drop(gillaItem);
			gillaItem = item;
			obj27 = null;
		}
		Collider[] array = gillaItem.Colliders__BackingField;
		if (array.Length < 1)
		{
			goto IL_058b;
		}
		object obj33 = array.Length & 0xFFFFFFFFL;
		object obj34 = array + 32;
		object obj35 = 0;
		object obj36 = 0;
		while (true)
		{
			bool flag13 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj35) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33);
			object obj37 = !flag13;
			if (obj37 != null)
			{
				break;
			}
			object obj38 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v30+E4]");
			bool flag14 = (nint)0 == 0;
			object obj39 = !flag14;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X24_v5+v261 @ X23_v6*8]");
			bool flag15 = (UnityEngine.Object)0 != null;
			bool flag16 = !flag15;
			obj36 = 0;
			obj27 = null;
			if (!flag16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X24_v5+v261 @ X23_v6*8]");
				((Collider)0).enabled = false;
				obj36 = 0;
				obj27 = null;
			}
			obj33 = array.Length;
			obj35++;
			if ((nint)obj35 < array.Length)
			{
				continue;
			}
			goto IL_058b;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_05a5;
		IL_05a5:
		throw new NullReferenceException();
		IL_058b:
		item.Recycle();
	}

	private void Show()
	{
		//IL_0c3c: Expected Obj, but got I
		//IL_0c64: Expected VT, but got I
		//IL_0c78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Expected Obj, but got Unknown
		//IL_0c8d: Expected Obj, but got I
		//IL_0c95: Expected F4, but got Obj
		//IL_0cba: Expected Obj, but got I
		//IL_0cf7: Expected Obj, but got I4
		//IL_0e30: Expected VT, but got I4
		//IL_0139: Expected Obj, but got I4
		//IL_0141: Expected VT, but got I
		//IL_0076: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I4
		//IL_03e6: Expected Obj, but got I4
		//IL_042b: Expected VT, but got I4
		//IL_03a6: Expected VT, but got I4
		//IL_03b7: Expected VT, but got I4
		//IL_0179: Expected Obj, but got I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00ca: Expected I, but got Obj
		//IL_01be: Expected Obj, but got I4
		//IL_01c7: Expected VT, but got I4
		//IL_04ae: Expected Obj, but got I4
		//IL_046f: Expected VT, but got I4
		//IL_0480: Expected VT, but got I4
		//IL_06cd: Expected Obj, but got I4
		//IL_01ff: Expected Obj, but got I4
		//IL_00f9: Expected I, but got Obj
		//IL_04d0: Expected Obj, but got I8
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected Obj, but got Unknown
		//IL_04e7: Expected VT, but got I4
		//IL_04f0: Expected Obj, but got I4
		//IL_04f9: Expected Obj, but got I4
		//IL_0244: Expected Obj, but got I4
		//IL_024d: Expected VT, but got I4
		//IL_0d68: Expected Obj, but got I4
		//IL_0d26: Expected Obj, but got I4
		//IL_026b: Expected Obj, but got I
		//IL_0528: Expected Obj, but got I4
		//IL_0557: Expected Obj, but got I
		//IL_0575: Expected Obj, but got I4
		//IL_057e: Expected Obj, but got I4
		//IL_0587: Expected VT, but got I4
		//IL_067f: Expected Obj, but got I4
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Expected Obj, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected Obj, but got Unknown
		//IL_08db: Invalid comparison between F4 and I4
		//IL_08ea: Expected F8, but got I4
		//IL_078b: Expected Obj, but got I4
		//IL_05a6: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I
		//IL_0309: Expected Obj, but got I4
		//IL_095d: Expected Obj, but got I
		//IL_05d8: Expected Obj, but got I4
		//IL_05e0: Expected VT, but got I4
		//IL_0340: Expected VT, but got I4
		//IL_0349: Expected Obj, but got I4
		//IL_0352: Expected VT, but got I4
		//IL_07db: Expected Obj, but got I4
		//IL_0b2c: Expected Obj, but got I
		//IL_081e: Expected F4, but got I4
		//IL_05ff: Expected Obj, but got I
		//IL_061d: Expected Obj, but got I4
		//IL_062e: Expected Obj, but got I4
		//IL_0637: Expected VT, but got I4
		//IL_0b4b: Expected Obj, but got I
		//IL_0a10: Expected Obj, but got I8
		//IL_0a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Expected Obj, but got Unknown
		//IL_0a27: Expected Obj, but got I4
		//IL_0db5: Expected Obj, but got I4
		//IL_0656: Expected Obj, but got I
		//IL_0667: Expected Obj, but got I4
		//IL_0670: Expected VT, but got I4
		//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7e: Expected Obj, but got Unknown
		//IL_0b87: Expected Obj, but got I4
		//IL_0ddc: Expected Obj, but got I4
		//IL_0a56: Expected Obj, but got I4
		//IL_0a85: Expected Obj, but got I
		//IL_0ba2: Expected Obj, but got I
		//IL_0bb2: Expected Obj, but got I
		//IL_0bbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc0: Expected Obj, but got Unknown
		//IL_0af0: Expected Obj, but got I4
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afe: Expected Obj, but got Unknown
		//IL_0acf: Expected Obj, but got I
		//IL_0ae1: Expected Obj, but got I4
		bool isLit = IsLit;
		bool flag;
		nint num = default;
		if (~(wentOff ? 1u : 0u) == 0)
		{
			flag = true;
		}
		else if (Live)
		{
			NetworkObject networkObject = ((SimulationBehaviour)this)._object;
			if ((object)((SimulationBehaviour)this)._object != null)
			{
				object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
				bool flag2 = obj == null;
				object obj2 = !flag2;
				if (obj2 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
					object obj4 = default;
					object obj3 = obj4 & 1;
					bool flag3 = obj3 == null;
					num = unchecked((nint)null);
					if (!flag3)
					{
						NetworkBool blown = Blown;
						bool flag4 = blown;
						num = unchecked((nint)null);
						flag = flag4;
						goto IL_0c1d;
					}
				}
			}
			flag = false;
		}
		else
		{
			flag = blownHere;
		}
		goto IL_0c1d;
		IL_0c1d:
		bool flag5 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		bool flag6 = !flag5;
		float burnt = Burnt;
		bool flag7 = !isLit;
		Vector3 vector = (Vector3)num;
		if (!flag7)
		{
			bool flag8 = (byte)(~(shownLit ? 1u : 0u)) != 0;
			object obj6 = !flag8;
			vector = (Vector3)num;
			if (obj6 == null)
			{
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v80+E4]");
				bool flag9 = (nint)0 == 0;
				object obj8 = !flag9;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag10 = lightSound != null;
				bool flag11 = !flag10;
				object obj9 = 0;
				vector = (Vector3)0;
				if (!flag11)
				{
					object obj10 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v84+E4]");
					bool flag12 = (nint)0 == 0;
					object obj11 = !flag12;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag13 = spark != null;
					bool flag14 = !flag13;
					obj9 = 0;
					vector = (Vector3)0;
					if (!flag14)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						AudioClip[] array = default;
						if (array.Length == 0)
						{
							goto IL_0be5;
						}
						object obj13 = array + 32;
						obj13 = lightSound;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Vector3 position = spark.position;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
						object obj14 = 0;
						object obj15 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X0_v95+E4]");
						bool flag15 = (nint)0 == 0;
						object obj16 = !flag15;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float pitchMin = default;
						float pitchMax = default;
						Sfx.Play(array, (Vector3)0, burnt, pitchMin, pitchMax);
						obj9 = 0;
						vector = (Vector3)0;
					}
				}
			}
		}
		object obj17 = this + 268;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDynamite)+120]");
		object obj18 = 0;
		float num2 = (float)obj17;
		object obj19 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDynamite)+114]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDynamite)+120]");
		object obj20 = num3 - 0;
		shownLit = isLit;
		float num4 = (float)obj17 - (float)rootAt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v7+E4]");
		bool flag16 = (nint)0 == 0;
		object obj21 = !flag16;
		float num5 = burnt;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num5 = burnt;
		}
		object obj22 = default;
		float num6 = num4 * (float)obj22;
		float num7 = num5 * (float)obj20;
		bool flag17 = fuse != null;
		bool flag18 = !flag17;
		Vector3 vector2 = (Vector3)0;
		object obj23 = default;
		if (!flag18)
		{
			num5 = (float)fuseAt - num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDynamite)+108]");
			num2 = 0f - num7;
			fuse.localPosition = (Vector3)0;
			obj18 = obj23;
			vector2 = (Vector3)0;
		}
		object obj24 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v12+E4]");
		bool flag19 = (nint)0 == 0;
		object obj25 = !flag19;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag20 = spark != null;
		bool flag21 = !flag20;
		Vector3 vector3 = (Vector3)0;
		if (!flag21)
		{
			num5 = (float)obj17 - num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDynamite)+114]");
			num2 = 0f - num7;
			spark.localPosition = (Vector3)0;
			obj18 = obj23;
			vector3 = (Vector3)0;
		}
		ParticleSystem[] array2 = burning;
		bool flag22 = array2.Length < 1;
		object obj26 = 0;
		if (flag22)
		{
			goto IL_06b3;
		}
		object obj27 = array2.Length & 0xFFFFFFFFL;
		object obj28 = array2 + 32;
		ParticleSystem.EmissionModule emissionModule = (ParticleSystem.EmissionModule)0;
		object obj29 = 0;
		object obj30 = 0;
		while (true)
		{
			bool flag23 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27);
			object obj31 = !flag23;
			if (obj31 != null)
			{
				break;
			}
			object obj32 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X0_v60+E4]");
			bool flag24 = (nint)0 == 0;
			object obj33 = !flag24;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X27_v3+v246 @ X26_v4*8]");
			bool flag25 = (UnityEngine.Object)0 == null;
			bool flag26 = !flag25;
			object obj34 = !flag26;
			obj26 = 0;
			vector3 = (Vector3)0;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X27_v3+v246 @ X26_v4*8]");
				ParticleSystem.EmissionModule emission = ((ParticleSystem)0).emission;
				emissionModule.enabled = isLit;
				bool flag27 = !isLit;
				emissionModule = emission;
				obj26 = 0;
				vector3 = (Vector3)isLit;
				if (!flag27)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X27_v3+v246 @ X26_v4*8]");
					bool isPlaying = ((ParticleSystem)0).isPlaying;
					bool flag28 = !isPlaying;
					object obj35 = !flag28;
					emissionModule = emission;
					obj26 = 0;
					vector3 = (Vector3)0;
					if (obj35 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X27_v3+v246 @ X26_v4*8]");
						((ParticleSystem)0).Play();
						emissionModule = emission;
						obj26 = 0;
						vector3 = (Vector3)0;
					}
				}
			}
			obj27 = array2.Length;
			obj29++;
			bool flag29 = (nint)obj29 < array2.Length;
			obj30 = obj26;
			if (flag29)
			{
				continue;
			}
			goto IL_06b3;
		}
		goto IL_0be5;
		IL_0be5:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_0b1c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75C0]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X0_v27+18]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X0_v27+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		object obj39 = default;
		object obj38 = obj39 + 32;
		object obj40 = 0;
		while (true)
		{
			bool flag30 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj37);
			object obj41 = !flag30;
			if (obj41 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X21_v10+v487 @ X20_v8*8]");
			((Renderer)0).enabled = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X0_v27+18]");
			obj37 = 0;
			obj40++;
			object obj42 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X0_v27+18]");
			if ((nint)obj42 >= 0)
			{
				return;
			}
		}
		goto IL_0be5;
		IL_06b3:
		bool flag31 = !flag;
		object obj43 = !flag31;
		object obj44 = ~obj43;
		bool flag32 = obj44 != null && isLit;
		ShowBuds(flag32);
		object obj45 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X0_v19+E4]");
		bool flag33 = (nint)0 == 0;
		object obj46 = !flag33;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag34 = hiss != null;
		bool flag35 = !flag34;
		ParticleSystemStopBehavior particleSystemStopBehavior = (ParticleSystemStopBehavior)0;
		UnityEngine.Object obj47 = null;
		if (!flag35)
		{
			if (isLit)
			{
				bool isPlaying2 = hiss.isPlaying;
				bool flag36 = !isPlaying2;
				object obj48 = !flag36;
				particleSystemStopBehavior = (ParticleSystemStopBehavior)0;
				if (obj48 == null)
				{
					AudioClip clip = hiss.clip;
					object obj49 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v28+E4]");
					bool flag37 = (nint)0 == 0;
					object obj50 = !flag37;
					if (obj50 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag38 = clip != null;
					bool flag39 = !flag38;
					float maxInclusive = 0f;
					if (!flag39)
					{
						AudioClip clip2 = hiss.clip;
						float length = clip2.length;
						maxInclusive = length;
					}
					float time = UnityEngine.Random.Range(0f, maxInclusive);
					hiss.time = time;
					hiss.Play();
					particleSystemStopBehavior = (ParticleSystemStopBehavior)0;
				}
			}
			else
			{
				bool isPlaying3 = hiss.isPlaying;
				bool flag40 = !isPlaying3;
				particleSystemStopBehavior = (ParticleSystemStopBehavior)0;
				if (!flag40)
				{
					hiss.Stop();
					particleSystemStopBehavior = (ParticleSystemStopBehavior)0;
				}
			}
			hiss.volume = hissVolume;
			bool flag41 = burnt < 0f;
			double num8 = 0.0;
			if (!flag41)
			{
				bool flag42 = !((double)burnt > 1.0);
				num8 = burnt;
				if (!flag42)
				{
					num8 = 1.0;
				}
			}
			double num9 = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			double num10 = num9 * 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB8]");
			obj18 = 0;
			float num11 = (float)num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB8]");
			num5 = num11 + 0f;
			hiss.pitch = num5;
			obj47 = null;
		}
		if (shownBlown == flag6)
		{
			return;
		}
		shownBlown = flag6;
		if (!flag)
		{
			return;
		}
		ParticleSystem[] array3 = burning;
		if (array3.Length < 1)
		{
			goto IL_0b1c;
		}
		object obj51 = array3.Length & 0xFFFFFFFFL;
		object obj52 = array3 + 32;
		object obj53 = 0;
		while (true)
		{
			bool flag43 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj53) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj51);
			object obj54 = !flag43;
			if (obj54 != null)
			{
				break;
			}
			object obj55 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X0_v31+E4]");
			bool flag44 = (nint)0 == 0;
			object obj56 = !flag44;
			if (obj56 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X24_v5+v421 @ X23_v6*8]");
			bool flag45 = (UnityEngine.Object)0 != null;
			bool flag46 = !flag45;
			particleSystemStopBehavior = (ParticleSystemStopBehavior)0;
			obj47 = null;
			if (!flag46)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X24_v5+v421 @ X23_v6*8]");
				((ParticleSystem)0).Stop(withChildren: true, (ParticleSystemStopBehavior)0);
				particleSystemStopBehavior = (ParticleSystemStopBehavior)0;
				obj47 = (UnityEngine.Object)1;
			}
			obj51 = array3.Length;
			obj53++;
			if ((nint)obj53 < array3.Length)
			{
				continue;
			}
			goto IL_0b1c;
		}
		goto IL_0be5;
	}

	private void ShowBuds(bool on)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected Obj, but got Unknown
		//IL_065c: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I4
		//IL_008e: Expected I4, but got Obj
		//IL_0136: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I4
		//IL_01cd: Expected I, but got Obj
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected Obj, but got Unknown
		//IL_05ed: Expected Obj, but got I4
		//IL_01f5: Expected Obj, but got I
		//IL_020c: Expected I, but got Obj
		//IL_022f: Expected Obj, but got I
		//IL_0234: Expected I, but got Obj
		//IL_0280: Expected F4, but got I4
		//IL_0307: Invalid comparison between F4 and I4
		//IL_0316: Expected F4, but got I4
		//IL_0389: Expected Obj, but got I4
		//IL_0334: Invalid comparison between F4 and I
		//IL_03b4: Expected F4, but got I
		//IL_03c4: Invalid comparison between F4 and I
		//IL_0363: Expected F4, but got I
		//IL_0476: Expected Obj, but got I4
		//IL_03ec: Expected Obj, but got I
		//IL_04a7: Expected Obj, but got I
		//IL_068f: Expected Obj, but got I
		//IL_04e7: Expected Obj, but got I4
		//IL_0448: Expected VT, but got I4
		//IL_051c: Expected Obj, but got I
		//IL_0573: Expected Obj, but got I
		//IL_058d: Expected VT, but got I4
		//IL_05a7: Expected Obj, but got I
		//IL_05ac: Expected I, but got Obj
		//IL_05b4: Expected I4, but got Obj
		MeshRenderer[] array = buds;
		if (buds == null)
		{
			return;
		}
		object obj = this + 192;
		bool flag = obj == null;
		object obj2 = !flag;
		bool flag2 = on;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			budBlock = materialPropertyBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			array = buds;
			flag2 = (byte)(int)materialPropertyBlock != 0;
		}
		object obj4 = this + 200;
		bool flag3 = obj4 == null;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			bool flag4 = default;
			budWas = (float[])flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			array = buds;
			flag2 = flag4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4F8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj9 = 0;
		object obj10 = 0;
		while (true)
		{
			if ((nint)obj10 >= array.Length)
			{
				return;
			}
			bool flag5 = (nint)obj10 < array.Length;
			object obj11 = !flag5;
			if (obj11 != null)
			{
				break;
			}
			object obj12 = obj7;
			object obj13 = (object)array + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v8+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v9+20]");
			bool flag7 = (UnityEngine.Object)0 == null;
			bool flag8 = !flag7;
			object obj15 = !flag8;
			nint num = unchecked((nint)null);
			flag2 = false;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v9+20]");
				bool flag9 = ((Renderer)0).enabled;
				bool flag10 = flag9 == on;
				num = unchecked((nint)null);
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v9+20]");
					((Renderer)0).enabled = on;
					num = unchecked((nint)null);
				}
				bool flag11 = !on;
				flag2 = on;
				if (!flag11)
				{
					float time = Time.time;
					MeshRenderer[] array2 = buds;
					float num2 = array2.Length;
					float num3 = (float)obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
					float num4 = num3 * 0f;
					float num5 = num4 / (float)array2.Length;
					float num6 = time + num5;
					float num7 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
					float num8 = num7 / 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					float num9 = num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
					float num10 = num9 * 0f;
					float num11 = num6 - num10;
					bool flag12 = num11 < 0f;
					float num12 = 0f;
					if (!flag12)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
						bool flag13 = !(num11 > 0f);
						num12 = num11;
						if (!flag13)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
							num12 = 0f;
						}
					}
					object obj16 = obj4;
					object obj17 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v15+18]");
					bool flag14 = (nint)obj17 < 0;
					object obj18 = !flag14;
					if (obj18 != null)
					{
						break;
					}
					object obj19 = obj16 + obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X9_v13+20]");
					float num13 = 0f;
					float num14 = num12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X9_v13+20]");
					if (num14 < 0f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v9+20]");
						Transform transform = ((Component)0).transform;
						object obj20 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v24+A0]");
						object obj21 = 0;
						float num15 = UnityEngine.Random.Range(0f, 360f);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v25+20]");
						num2 = 0f * num15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v25+1C]");
						num10 = 0f * num15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v25+18]");
						num13 = 0f * num15;
						transform.localEulerAngles = (Vector3)0;
						obj16 = obj4;
					}
					object obj22 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v15+18]");
					bool flag15 = (nint)obj22 < 0;
					object obj23 = !flag15;
					if (obj23 != null)
					{
						break;
					}
					object obj24 = obj16 + obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v9+20]");
					Transform transform2 = ((Component)0).transform;
					Vector3 localEulerAngles = transform2.localEulerAngles;
					object obj25 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X0_v21+E4]");
					bool flag16 = (nint)0 == 0;
					object obj26 = !flag16;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj27 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v18+A0]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v19+8]");
					((MaterialPropertyBlock)obj).SetFloat(0, num12);
					float num16 = num10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
					float num17 = num16 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
					object obj29 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X8_v20+A0]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v21+C]");
					((MaterialPropertyBlock)obj).SetVector(0, (Vector4)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v9+20]");
					((Renderer)0).SetPropertyBlock((MaterialPropertyBlock)obj);
					num = unchecked((nint)null);
					flag2 = (byte)(int)obj != 0;
				}
			}
			array = buds;
			obj10++;
			bool flag17 = buds == null;
			object obj31 = !flag17;
			if (obj31 == null)
			{
				throw new NullReferenceException();
			}
		}
		throw new IndexOutOfRangeException();
	}

	public void LightForTest()
	{
		Light();
	}

	private static bool Button(int hand)
	{
		//IL_00f6: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got I
		//IL_0253: Expected VT, but got I
		//IL_0271: Expected Obj, but got I4
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected I4, but got Unknown
		//IL_018e: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_01be: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I4
		//IL_0161: Expected I4, but got Obj
		bool result;
		XRNode node;
		if (hand != 0)
		{
			if (hand == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D08]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
				object obj2 = 0;
				object obj3 = obj;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v12+A0]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v18+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = !flag;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool isEditor = Application.isEditor;
				bool flag2 = !isEditor;
				result = false;
				if (!flag2)
				{
					bool flag3 = obj5 == null;
					result = false;
					if (!flag3)
					{
						KeyControl bKey = ((Keyboard)obj5).bKey;
						if (bKey != null)
						{
							return bKey.isPressed;
						}
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
				}
				goto IL_01ee;
			}
			node = (XRNode)5;
		}
		else
		{
			node = (XRNode)4;
		}
		UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
		UnityEngine.XR.InputDevice inputDevice = default;
		if (inputDevice.isValid)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB0]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v8+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v4+18]");
			bool flag5 = inputDevice.TryGetFeatureValue((InputFeatureUsage<bool>)0, out var value);
			bool flag6 = !value;
			object obj11 = !flag6;
			result = (byte)((flag5 & obj11) ? 1 : 0) != 0;
		}
		else
		{
			result = false;
		}
		goto IL_01ee;
		IL_01ee:
		return result;
	}

	public GillaDynamite()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00cf: Expected F4, but got I
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D07B8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E18]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj4 = 0;
		fuseSeconds = 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj5 = this + 136;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj7 = this + 144;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		lightWaits = -1f;
		chainRadius = 3.6f;
		chainAt = -1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GillaNetGuard.Holder holder = default;
		holder._002Ector();
		object obj9 = this + 232;
		obj9 = holder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B4B8]");
		litSince = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj10 = this + 248;
		object obj11 = default;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaDynamite()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D07C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4F8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBF8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC00]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+A0]");
		object obj6 = 0;
		obj6 = list;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int num = Shader.PropertyToID((string)obj3);
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+A0]");
		object obj9 = 0;
		int num2 = Shader.PropertyToID((string)obj4);
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v8+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E500]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B068]");
		_ = 0;
	}

	public override void CopyBackingFieldsToState(bool P_0)
	{
		Lit = _Lit;
		Burn = _Burn;
		Blown = _Blown;
	}

	public override void CopyStateToBackingFields()
	{
		NetworkBool lit = Lit;
		_Lit = lit;
		float burn = Burn;
		_Burn = burn;
		NetworkBool blown = Blown;
		_Blown = blown;
	}

	protected unsafe static void RPC_GoOff_0040Invoker1421761683([In] ref RpcInvokeContext context)
	{
		//IL_0011: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I4
		//IL_01d3: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I
		//IL_0213: Expected VT, but got I4
		//IL_023a: Expected Obj, but got I
		//IL_0243: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_00dd: Expected I, but got Obj
		//IL_0106: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I
		//IL_007e: Expected VT, but got Obj
		//IL_00ad: Expected VT, but got I
		//IL_013a: Expected Obj, but got I
		//IL_0172: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out Vector3 _, 12);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v8+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v7+18]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v7+18]");
		bool flag2 = (nint)0 == 0;
		RpcInfo info = (RpcInfo)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D07A8]");
			object obj7 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj7);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X21_v3+28]");
			info = (RpcInfo)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v97 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v9+A0]");
		object obj9 = 0;
		obj9 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaDynamite gillaDynamite = (GillaDynamite)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4F8]");
		object obj10 = 0;
		object obj11 = obj10;
		nint num = (nint)gillaDynamite;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v14 (Il2CppClass<GillaDynamite>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X1_v6+130]");
		bool flag3 = num2 < 0;
		object obj12 = !flag3;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v14 (Il2CppClass<GillaDynamite>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X1_v6+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v17-8]");
			if (0 == (nint)obj11)
			{
				object obj15 = default;
				gillaDynamite.RPC_GoOff((Vector3)(&obj15), info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}
}
