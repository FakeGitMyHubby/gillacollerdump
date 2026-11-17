using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using Unity.IL2CPP.Metadata;
using UnityEngine;

public class GillaDummy : NetworkBehaviour
{
	private sealed class _003CUnignore_003Ed__223 : _00210, _0021_00210, _00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float after;

		public Collider box;

		public Collider[] frame;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CUnignore_003Ed__223(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0355: Expected Obj, but got I
			//IL_0364: Expected I4, but got I8
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			//IL_038d: Expected Obj, but got Unknown
			//IL_0037: Expected Obj, but got I
			//IL_0046: Expected I4, but got I8
			//IL_0070: Expected Obj, but got I4
			//IL_00b7: Expected Obj, but got I4
			//IL_03cb: Expected I4, but got Obj
			//IL_0121: Expected Obj, but got I8
			//IL_0131: Expected Obj, but got I
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected Obj, but got Unknown
			//IL_014a: Expected Obj, but got I4
			//IL_0419: Expected Obj, but got I4
			//IL_0187: Expected Obj, but got I4
			//IL_01b6: Expected Obj, but got I
			//IL_0314: Expected Obj, but got I4
			//IL_031d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0322: Expected Obj, but got Unknown
			//IL_020f: Expected Obj, but got I4
			//IL_0243: Expected Obj, but got I
			//IL_02b5: Expected Obj, but got I4
			//IL_02ec: Expected Obj, but got I
			//IL_0305: Expected Obj, but got I
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj = 0;
					_003C_003E1__state = -1;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v9+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag2 = box == null;
					bool flag3 = !flag2;
					object obj4 = !flag3;
					if (obj4 == null)
					{
						Collider[] array = frame;
						if (frame != null)
						{
							if (array.Length < 1)
							{
								goto IL_03ea;
							}
							object obj5 = array.Length & 0xFFFFFFFFL;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
							object obj6 = 0;
							object obj7 = frame + 32;
							object obj8 = 0;
							bool flag4 = false;
							UnityEngine.Object obj9 = null;
							while (true)
							{
								bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
								object obj10 = !flag5;
								if (obj10 != null)
								{
									break;
								}
								object obj11 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v17+E4]");
								bool flag6 = (nint)0 == 0;
								object obj12 = !flag6;
								if (obj12 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X27_v4+v239 @ X25_v5*8]");
								bool flag7 = (UnityEngine.Object)0 != null;
								bool flag8 = !flag7;
								flag4 = false;
								obj9 = null;
								if (!flag8)
								{
									object obj13 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v22+E4]");
									bool flag9 = (nint)0 == 0;
									object obj14 = !flag9;
									if (obj14 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X27_v4+v239 @ X25_v5*8]");
									bool flag10 = (UnityEngine.Object)0 != box;
									bool flag11 = !flag10;
									Collider collider = box;
									flag4 = false;
									obj9 = box;
									if (!flag11)
									{
										object obj15 = obj6;
										collider = box;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v26+E4]");
										bool flag12 = (nint)0 == 0;
										object obj16 = !flag12;
										if (obj16 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Collider collider2 = collider;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X27_v4+v239 @ X25_v5*8]");
										Physics.IgnoreCollision(collider2, (Collider)0, ignore: false);
										flag4 = false;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X27_v4+v239 @ X25_v5*8]");
										obj9 = (UnityEngine.Object)0;
									}
								}
								obj5 = array.Length;
								obj8++;
								if ((nint)obj8 < array.Length)
								{
									continue;
								}
								goto IL_03ea;
							}
							IndexOutOfRangeException ex = new IndexOutOfRangeException();
						}
						NullReferenceException ex2 = new NullReferenceException();
						return (byte)(int)ex2 != 0;
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5AC0]");
				object obj17 = 0;
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				WaitForSeconds waitForSeconds = default;
				waitForSeconds._002Ector(after);
				object obj18 = this + 24;
				obj18 = waitForSeconds;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_003C_003E1__state = 1;
			}
			goto IL_03ea;
			IL_03ea:
			return _003C_003E1__state == 0;
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

	private enum Mode
	{
		// error: enumerator has no value
		Standing,
		// error: enumerator has no value
		Held,
		// error: enumerator has no value
		Eaten,
		// error: enumerator has no value
		Gone
	}

	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public ApePart part;

		public GillaRip.Along along;

		public GillaDummy _003C_003E4__this;

		internal unsafe void _003CSawnThrough_003Eb__1()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0364: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got I4
			//IL_00b7: Expected Obj, but got I4
			//IL_0101: Expected Obj, but got I4
			//IL_0158: Expected VT, but got I4
			//IL_024e: Expected Obj, but got I4
			//IL_0296: Expected Obj, but got Ref
			//IL_0185: Expected Obj, but got I
			//IL_01af: Expected Obj, but got I4
			//IL_037c: Expected Obj, but got VT
			//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b7: Expected Obj, but got Unknown
			//IL_03d4: Expected Obj, but got I
			//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e9: Expected Obj, but got Unknown
			//IL_0402: Expected Obj, but got I
			//IL_0412: Unknown result type (might be due to invalid IL or missing references)
			//IL_0417: Expected Obj, but got Unknown
			//IL_0434: Expected Obj, but got I
			//IL_0444: Unknown result type (might be due to invalid IL or missing references)
			//IL_0449: Expected Obj, but got Unknown
			//IL_049a: Expected Obj, but got I4
			//IL_0289: Expected Obj, but got Ref
			//IL_01fc: Expected VT, but got I4
			//IL_020f: Expected Obj, but got I4
			//IL_0218: Expected VT, but got I4
			//IL_02c7: Expected VT, but got I4
			//IL_02c7: Expected VT, but got Ref
			//IL_02d7: Expected VT, but got Ref
			//IL_0302: Expected Obj, but got I4
			//IL_0334: Expected VT, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
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
			if (gillaDummy.mode == (Mode)3)
			{
				return;
			}
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v9+E4]");
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
			GillaDummy gillaDummy2 = _003C_003E4__this;
			ApePart apePart = part;
			bool flag7 = gillaDummy2.tearing.IsTorn(part);
			bool flag8 = !flag7;
			GillaRip.Along along = (GillaRip.Along)0;
			object obj11;
			GillaRip.Along along2;
			ApePart apePart2;
			if (!flag8)
			{
				GillaDummy gillaDummy3 = _003C_003E4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D48]");
				object obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v28+E4]");
				bool flag9 = (nint)0 == 0;
				object obj10 = !flag9;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag10 = GillaSaw.Resawable(gillaDummy3.tearing, part);
				bool flag11 = !flag10;
				along = (GillaRip.Along)0;
				apePart = part;
				obj11 = 0;
				along2 = (GillaRip.Along)0;
				apePart2 = part;
				if (flag11)
				{
					goto IL_02e6;
				}
			}
			GillaDummy gillaDummy4 = _003C_003E4__this;
			object obj12 = 17281024 + 480;
			bool flag12 = part == 0;
			object obj13;
			if (part == 0)
			{
				object obj14 = default;
				obj13 = (object)(&obj14);
			}
			else
			{
				object obj15 = default;
				obj13 = (object)(&obj15);
			}
			obj13 = this.along;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy+<>c__DisplayClass77_0)+24]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy+<>c__DisplayClass77_0)+34]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
			GillaRip.Along along3 = this.along;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X10_v5+v323 @ Z_v5 (System.Boolean)*4]");
			object obj16 = along3 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy+<>c__DisplayClass77_0)+24]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X10_v5+v323 @ Z_v5 (System.Boolean)*4]");
			object obj17 = num * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X10_v5+v323 @ Z_v5 (System.Boolean)*4]");
			object obj19 = default;
			object obj18 = obj19 * 0;
			Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D48]");
			object obj20 = 0;
			object obj21 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			object obj22 = obj21 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X22_v5+10]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			object obj23 = num2 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			object obj24 = obj19 * 0;
			object obj25 = obj20;
			object obj26 = obj16 + obj22;
			object obj27 = obj17 + obj23;
			object obj28 = obj18 + obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v24+E4]");
			bool flag13 = (nint)0 == 0;
			object obj29 = !flag13;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj30 = default;
			GillaSaw.CutPart(gillaDummy4.tearing, part, (GillaRip.Along)(&obj30), (Vector3)0);
			obj11 = obj26;
			along2 = (GillaRip.Along)(&obj30);
			apePart2 = part;
			goto IL_02e6;
			IL_02e6:
			bool flag14 = part == 0;
			object obj31 = !flag14;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
				_003C_003E4__this.Die((Vector3)0, quiet: false);
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_1
	{
		public Dismemberment copy;

		public _003C_003Ec__DisplayClass77_0 CS_0024_003C_003E8__locals1;

		internal unsafe bool _003CSawnThrough_003Eb__0()
		{
			//IL_0010: Expected Obj, but got I
			//IL_013d: Expected Obj, but got I4
			//IL_0113: Expected I4, but got Obj
			//IL_0098: Expected Obj, but got I
			//IL_00c2: Expected Obj, but got I4
			//IL_00f7: Expected VT, but got Ref
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
			if (copy == null)
			{
				return true;
			}
			_003C_003Ec__DisplayClass77_0 obj4 = CS_0024_003C_003E8__locals1;
			if (CS_0024_003C_003E8__locals1 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj8 = default;
				return GillaWounds.SawPartReady(copy, obj4.part, (GillaRip.Along)(&obj8));
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public Transform head;

	public Transform leftHand;

	public Transform rightHand;

	public Dismemberment tearing;

	public ApeColor colour;

	public float eyeHeight = 1.2f;

	private int _Rgb;

	public static readonly List<GillaDummy> All;

	private const int FirstBody = default(int);

	private const float EyesOverHand = default(float);

	private const float ThrownDies = default(float);

	private const float GoneAfter = default(float);

	private static int offline;

	private static readonly Color[] Furs;

	private Mode mode;

	private PlayerRef holder;

	private Vector3 heldEyes;

	private bool holderRight;

	private MonsterBrain eater;

	private float eatenAt;

	private float biteAt = -1f;

	private float goneAt;

	private int hits;

	private int offlineBody;

	private Vector3 standAt;

	private Quaternion standFacing;

	private float phase;

	private bool paintPending;

	private bool blown;

	private const int Solid = default(int);

	private unsafe int Rgb
	{
		get
		{
			//IL_0080: Expected I4, but got Obj
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
				return (int)ex2;
			}
			return (int)ptr;
		}
		set
		{
			if (Ptr != null)
			{
				int* ptr = (int*)value;
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

	public bool Mine
	{
		get
		{
			//IL_0031: Expected I4, but got Obj
			//IL_003c: Expected I4, but got Obj
			//IL_0060: Expected Obj, but got I
			//IL_007a: Expected Obj, but got I4
			bool result;
			if (Live)
			{
				result = (byte)(int)((SimulationBehaviour)this)._object != 0;
				if ((int)(~((SimulationBehaviour)this)._object) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v2 (System.Boolean)+58]");
					object obj = (nint)0 & (nint)2;
					bool flag = obj == null;
					object obj2 = !flag;
					if (obj2 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
						bool result2 = default;
						return result2;
					}
					result = false;
				}
			}
			else
			{
				result = true;
			}
			return result;
		}
	}

	public bool Standing => mode == 0;

	public bool Alive
	{
		get
		{
			if (mode == (Mode)3)
			{
				return false;
			}
			return !blown;
		}
	}

	public int Hits => hits;

	public unsafe int BodyId
	{
		get
		{
			//IL_0113: Expected I4, but got Obj
			//IL_0140: Expected Obj, but got I4
			//IL_006f: Expected Obj, but got I8
			//IL_00c9: Expected Obj, but got I8
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Expected Obj, but got Unknown
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected Obj, but got Unknown
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Expected I4, but got Unknown
			int result;
			if (Live)
			{
				NetworkObject networkObject = ((SimulationBehaviour)this)._object;
				if ((object)((SimulationBehaviour)this)._object == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (int)ex;
				}
				int* ptr = networkObject.Ptr;
				if (networkObject.Ptr != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X20_v5 (System.Int32*)+4]");
					object obj = 0 & -9223372036854775808L;
					if (obj != null)
					{
						System.ThrowHelper.ThrowArgumentOutOfRangeException();
					}
				}
				Span<int> span = default;
				bool isEmpty = span.IsEmpty;
				bool flag = !isEmpty;
				object obj2 = !flag;
				result = 50000;
				if (obj2 == null)
				{
					int* ptr2 = networkObject.Ptr;
					object obj3 = (nint)ptr2 * 3518437209L;
					object obj4 = obj3 >> 47;
					object obj5 = obj4 * 40000;
					object obj6 = ptr2 - obj5;
					result = obj6 + 50000;
				}
			}
			else
			{
				result = offlineBody;
			}
			return result;
		}
	}

	public Vector3 Middle
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00f5: Expected Obj, but got I4
			//IL_00cb: Expected VT, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (head != null)
			{
				if ((object)head != null)
				{
					return head.position;
				}
			}
			else
			{
				Transform transform = base.transform;
				if ((object)transform != null)
				{
					return transform.position;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
	}

	public bool IsTorn(ApePart part)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I4
		//IL_009c: Expected I4, but got Obj
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
		if (tearing != null)
		{
			if ((object)tearing != null)
			{
				return tearing.IsTorn(part);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return false;
	}

	public bool HeldBy(PlayerRef who, bool right)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I4
		if (mode == (Mode)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (holder == who)
			{
				object obj4 = (holderRight ? 1 : 0) - (right ? 1 : 0);
				return obj4 == null;
			}
		}
		return false;
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01ba: Expected Obj, but got I4
		//IL_01d8: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_0250: Expected Obj, but got I
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected I4, but got Unknown
		//IL_006c: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+8]");
		object obj5 = (nint)0 * (nint)1954687339;
		object obj6 = obj5 >> 63;
		object obj7 = obj5 >> 44;
		object obj8 = obj7 + obj6;
		object obj9 = obj8 * 9000;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+8]");
		object obj10 = 0 - obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+8]");
		object obj11 = (nint)0 + (nint)1;
		object obj12 = obj10 + 86016;
		int num = obj12 + 3984;
		offlineBody = num;
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Vector3 vector = default;
		standAt = vector;
		Transform transform2 = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj13 = 0;
		Quaternion rotation = transform2.rotation;
		standFacing = (Quaternion)vector;
		float num2 = UnityEngine.Random.Range(0f, 10f);
		object obj14 = obj13;
		phase = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (tearing != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v17+E4]");
			bool flag3 = (nint)0 == 0;
			object obj18 = !flag3;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaRip.Prepare(tearing);
		}
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
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

	private void Start()
	{
		//IL_0016: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I4
		//IL_00c0: Expected VT, but got I
		if (Live)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v5+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v4+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v4+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X20_v4+18]");
			int num = UnityEngine.Random.Range(0, 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X20_v4+18]");
			bool flag2 = (nint)num < (nint)0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X20_v4+18]");
				Paint((Color)0);
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	public override void Spawned()
	{
		//IL_009c: Expected VT, but got I4
		//IL_00bd: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I4
		//IL_00e0: Expected VT, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_011e: Expected VT, but got I4
		//IL_0150: Expected Obj, but got I4
		//IL_0159: Expected VT, but got I4
		//IL_0177: Expected Obj, but got I
		//IL_01a1: Expected Obj, but got I4
		//IL_0603: Expected Obj, but got I
		//IL_0613: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I4
		//IL_0224: Expected Obj, but got I
		//IL_0648: Expected Obj, but got I
		//IL_0672: Expected Obj, but got I4
		//IL_0263: Invalid comparison between F8 and I4
		//IL_080d: Expected Obj, but got I4
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Expected Obj, but got Unknown
		//IL_06b7: Expected Obj, but got I4
		//IL_036a: Invalid comparison between F8 and I4
		//IL_0747: Expected Obj, but got I
		//IL_0845: Expected Obj, but got I4
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected Obj, but got Unknown
		//IL_071e: Expected Obj, but got I4
		//IL_04d3: Invalid comparison between Obj and F8
		//IL_0495: Invalid comparison between Obj and F8
		//IL_07a4: Expected Obj, but got F8
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected Obj, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected Obj, but got Unknown
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected I4, but got Unknown
		//IL_07de: Expected VT, but got I4
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Expected Obj, but got Unknown
		//IL_0783: Expected Obj, but got I4
		Transform transform = base.transform;
		Color c;
		double num2;
		object obj13;
		double num3;
		double num4 = default;
		double num5;
		double num6;
		if ((object)transform != null)
		{
			Vector3 position = transform.position;
			Vector3 vector = default;
			standAt = vector;
			Transform transform2 = base.transform;
			if ((object)transform2 != null)
			{
				Quaternion rotation = transform2.rotation;
				NetworkObject networkObject = ((SimulationBehaviour)this)._object;
				standFacing = (Quaternion)vector;
				bool flag = (object)((SimulationBehaviour)this)._object == null;
				c = (Color)0;
				if (!flag)
				{
					object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
					bool flag2 = obj == null;
					object obj2 = !flag2;
					c = (Color)0;
					if (obj2 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
						object obj4 = default;
						object obj3 = obj4 & 1;
						bool flag3 = obj3 == null;
						c = (Color)0;
						if (!flag3)
						{
							int rgb = Rgb;
							bool flag4 = rgb == 0;
							object obj5 = !flag4;
							c = (Color)0;
							if (obj5 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
								object obj6 = 0;
								object obj7 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v27+E4]");
								bool flag5 = (nint)0 == 0;
								object obj8 = !flag5;
								if (obj8 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj7 = obj6;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v27+A0]");
								object obj9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v14+10]");
								object obj10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v14+10]");
								if ((nint)0 == 0)
								{
									goto IL_05b7;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X20_v9+18]");
								int num = UnityEngine.Random.Range(0, 0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X20_v9+18]");
								bool flag6 = (nint)num < (nint)0;
								object obj11 = !flag6;
								if (obj11 != null)
								{
									goto IL_05c5;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v14+10]");
								object obj12 = (nint)0 + (nint)num;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v16+20]");
								num2 = 0.0 * 1132396544.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
								obj13 = 0;
								object obj14 = obj13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v31+E4]");
								bool flag7 = (nint)0 == 0;
								object obj15 = !flag7;
								if (obj15 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
								if (num2 < 0.0)
								{
									if (num2 == -0.5)
									{
										num3 = num4;
										num5 = -1.0;
										goto IL_0680;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
									num6 = -0.5;
								}
								else
								{
									if (num2 == 0.5)
									{
										num3 = num4;
										num5 = 1.0;
										goto IL_0680;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
									num6 = 0.5;
								}
								goto IL_06ca;
							}
						}
					}
				}
				goto IL_055c;
			}
		}
		goto IL_05b7;
		IL_0731:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v16+28]");
		object obj16 = (nint)0 * (nint)1132396544;
		object obj17 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v41+E4]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num7;
		double num8;
		if ((nint)obj16 < 0)
		{
			if (obj16 == (object)(-0.5))
			{
				num7 = num4;
				num8 = -1.0;
				goto IL_074c;
			}
			num7 = (double)obj16 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (obj16 == (object)0.5)
			{
				num7 = num4;
				num8 = 1.0;
				goto IL_074c;
			}
			num7 = (double)obj16 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_0796;
		IL_05c5:
		throw new IndexOutOfRangeException();
		IL_0796:
		object obj19 = num2 << 16;
		double num9;
		object obj20 = obj19 | num9;
		object obj21 = obj20 | num7;
		int num10 = (Rgb = obj21 | 0x1000000);
		c = (Color)num10;
		goto IL_055c;
		IL_0680:
		num6 = num3 + num5;
		object obj22 = num3 & 1;
		bool flag9 = obj22 == null;
		object obj23 = !flag9;
		num2 = ((obj23 != null) ? num6 : num3);
		goto IL_06ca;
		IL_06ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v16+24]");
		num9 = 0.0 * 1132396544.0;
		object obj24 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v36+E4]");
		bool flag10 = (nint)0 == 0;
		object obj25 = !flag10;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num12;
		double num13;
		double num14;
		if (num9 < 0.0)
		{
			if (num9 == -0.5)
			{
				num12 = num4;
				num13 = -1.0;
				goto IL_06e7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num14 = -0.5;
		}
		else
		{
			if (num9 == 0.5)
			{
				num12 = num4;
				num13 = 1.0;
				goto IL_06e7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num14 = 0.5;
		}
		goto IL_0731;
		IL_055c:
		if (Rgb != 0)
		{
			int rgb2 = Rgb;
			int rgb3 = Rgb;
			int rgb4 = Rgb;
			Paint(c);
		}
		return;
		IL_074c:
		double num15 = num7 + num8;
		object obj26 = num7 & 1;
		bool flag11 = obj26 == null;
		object obj27 = !flag11;
		if (obj27 != null)
		{
			num7 = num15;
		}
		goto IL_0796;
		IL_06e7:
		num14 = num12 + num13;
		object obj28 = num12 & 1;
		bool flag12 = obj28 == null;
		object obj29 = !flag12;
		num9 = ((obj29 != null) ? num14 : num12);
		goto IL_0731;
		IL_05b7:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05c5;
	}

	private void Paint(Color c)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
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
		bool flag2 = colour == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			ApeColor apeColor = colour;
			Color furColor = default;
			apeColor.furColor = furColor;
			paintPending = true;
		}
	}

	public unsafe void Grab(PlayerRef by, bool right, Vector3 eyesFromHand)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected VT, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected VT, but got Unknown
		//IL_005c: Expected VT, but got I
		//IL_005c: Expected VT, but got Ref
		if (Live)
		{
			NetworkBool right2 = right;
			PlayerRef playerRef = (PlayerRef)(by & 0xFFFFFFFFL);
			object obj = default;
			IntPtr intPtr = default;
			RPC_Grab(playerRef, right2, (Vector3)(&obj), (RpcInfo)(nint)intPtr);
		}
		else
		{
			PlayerRef playerRef2 = (PlayerRef)(by & 0xFFFFFFFFL);
			Grabbed(playerRef2, right, eyesFromHand);
		}
	}

	public unsafe void Release(Vector3 at, Vector3 velocity)
	{
		//IL_0039: Expected VT, but got I
		//IL_0039: Expected VT, but got Ref
		if (Live)
		{
			object obj = default;
			IntPtr intPtr = default;
			RPC_Release((Vector3)(&obj), velocity, (RpcInfo)(nint)intPtr);
		}
		else
		{
			Released(at, velocity);
		}
	}

	public unsafe void Punch(GoreSection section, Vector3 point)
	{
		//IL_004d: Expected VT, but got I4
		//IL_0039: Expected VT, but got I
		//IL_0039: Expected VT, but got Ref
		IntPtr intPtr = default;
		if (Live)
		{
			object obj = default;
			RPC_Punch((byte)section, (Vector3)(&obj), (RpcInfo)(nint)intPtr);
		}
		else
		{
			Punched(section, (Vector3)1, (byte)(nint)intPtr != 0);
		}
	}

	public unsafe void Wound(GoreSection section, Vector3 point)
	{
		//IL_004d: Expected VT, but got I4
		//IL_0039: Expected VT, but got I
		//IL_0039: Expected VT, but got Ref
		IntPtr intPtr = default;
		if (Live)
		{
			object obj = default;
			RPC_Wound((byte)section, (Vector3)(&obj), (RpcInfo)(nint)intPtr);
		}
		else
		{
			Punched(section, (Vector3)0, (byte)(nint)intPtr != 0);
		}
	}

	public unsafe void Stab(GoreSection section, Vector3 point, float radius, byte does)
	{
		//IL_0041: Expected VT, but got I
		if (Live)
		{
			object obj = default;
			IntPtr intPtr = default;
			RPC_Stab((byte)section, point, radius, (byte)(&obj), (RpcInfo)(nint)intPtr);
		}
		else
		{
			Stabbed(section, point, radius, does);
		}
	}

	public unsafe void Tear(ApePart part)
	{
		//IL_0035: Expected VT, but got Ref
		if (Live)
		{
			object obj = default;
			RPC_Tear((byte)part, (RpcInfo)(&obj));
		}
		else
		{
			Torn(part);
		}
	}

	public unsafe void Rip(PlayerRef by, byte seed, bool plusInRight, Quaternion rotRight, Quaternion rotLeft)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected VT, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected VT, but got Unknown
		//IL_0064: Expected VT, but got I
		//IL_0064: Expected VT, but got Ref
		if (Live)
		{
			NetworkBool plusInRight2 = plusInRight;
			PlayerRef playerRef = (PlayerRef)(by & 0xFFFFFFFFL);
			object obj = default;
			IntPtr intPtr = default;
			RPC_Rip(playerRef, seed, plusInRight2, (Quaternion)(&obj), rotLeft, (RpcInfo)(nint)intPtr);
		}
		else
		{
			PlayerRef playerRef2 = (PlayerRef)(by & 0xFFFFFFFFL);
			Ripped(playerRef2, seed, plusInRight, rotRight, rotLeft);
		}
	}

	public unsafe void Blasted(Vector3 velocity, byte torn, bool apart = default(bool))
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I4
		//IL_008e: Expected VT, but got I4
		//IL_008e: Expected I4, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = GillaRip.PickSeed();
		if (Live)
		{
			bool flag2 = (byte)(torn & 1) != 0;
			NetworkBool networkBool = flag2;
			object obj4 = default;
			RpcInfo info = default;
			RPC_Blasted(velocity, (byte)(int)networkBool, (NetworkBool)num, (byte)(&obj4), info);
		}
		else
		{
			byte torn2 = (byte)(torn & 1);
			IntPtr intPtr = default;
			Blown(velocity, torn2, (byte)num != 0, (byte)(nint)intPtr);
		}
	}

	public unsafe void SawBite(GoreSection section, int slot, GillaRip.Along along, Vector3 middle, Vector3 way, Vector3 half)
	{
		//IL_007a: Expected VT, but got I4
		//IL_007a: Expected VT, but got Ref
		//IL_0052: Expected VT, but got I
		//IL_0052: Expected F4, but got VT
		//IL_0052: Expected VT, but got Ref
		IntPtr intPtr = default;
		if (Live)
		{
			object obj = default;
			RPC_SawBite((byte)section, (byte)slot, (Vector3)(&obj), (float)along.n, middle, way, half, (RpcInfo)(nint)intPtr);
		}
		else
		{
			object obj2 = default;
			SawBitten(section, slot, (GillaRip.Along)(&obj2), (Vector3)0, way, half, (byte)(nint)intPtr != 0);
		}
	}

	public unsafe void SawThrough(GoreSection section, GillaRip.Along along)
	{
		//IL_0055: Expected VT, but got Ref
		//IL_0042: Expected VT, but got I
		//IL_0042: Expected F4, but got VT
		//IL_0042: Expected VT, but got Ref
		if (Live)
		{
			object obj = default;
			IntPtr intPtr = default;
			RPC_SawThrough((byte)section, (Vector3)(&obj), (float)along.n, (RpcInfo)(nint)intPtr);
		}
		else
		{
			object obj2 = default;
			SawnThrough(section, (GillaRip.Along)(&obj2));
		}
	}

	public unsafe void Eaten(MonsterBrain brain)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0083: Expected I, but got Obj
		//IL_00b7: Expected I, but got Obj
		//IL_0162: Expected VT, but got I
		//IL_0108: Expected Obj, but got I8
		//IL_01cc: Expected VT, but got Ref
		//IL_0148: Expected VT, but got I4
		if (Live)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = (UnityEngine.Object)brain.net != (UnityEngine.Object)null;
			bool flag3 = !flag2;
			nint num = unchecked((nint)null);
			if (!flag3)
			{
				bool live = brain.net.Live;
				bool flag4 = !live;
				num = unchecked((nint)null);
				if (!flag4)
				{
					MonsterNet net = brain.net;
					NetworkObject networkObject = ((SimulationBehaviour)net)._object;
					int* ptr = networkObject.Ptr;
					if (networkObject.Ptr != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X21_v8 (System.Int32*)+4]");
						object obj4 = 0 & -9223372036854775808L;
						if (obj4 != null)
						{
							System.ThrowHelper.ThrowArgumentOutOfRangeException();
						}
					}
					Span<int> span = default;
					NetworkId monster;
					if (span.IsEmpty)
					{
						monster = (NetworkId)0;
					}
					else
					{
						int* ptr2 = networkObject.Ptr;
						monster = (NetworkId)ptr2;
					}
					object obj5 = default;
					RPC_Eaten(monster, (RpcInfo)(&obj5));
					return;
				}
			}
		}
		EatenBy(brain);
	}

	public unsafe void RPC_Grab(PlayerRef by, NetworkBool right, Vector3 eyesFromHand, RpcInfo info = default(RpcInfo))
	{
		//IL_091a: Expected VT, but got I4
		//IL_0197: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0066: Expected VT, but got I4
		//IL_07a0: Expected Obj, but got I4
		//IL_07b9: Expected VT, but got I4
		//IL_0242: Expected Obj, but got I4
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected I4, but got Unknown
		//IL_00b1: Expected Obj, but got I4
		//IL_029a: Expected I4, but got VT
		//IL_02a8: Expected Obj, but got I4
		//IL_02c2: Expected Obj, but got I4
		//IL_00dc: Expected VT, but got F4
		//IL_03b3: Expected Obj, but got I4
		//IL_03e9: Expected Obj, but got I
		//IL_03fb: Expected VT, but got I8
		//IL_0412: Expected I, but got Obj
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected VT, but got Unknown
		//IL_0435: Expected Obj, but got VT
		//IL_044f: Expected Obj, but got I4
		//IL_0457: Expected I4, but got VT
		//IL_0460: Expected VT, but got I4
		//IL_0935: Expected Obj, but got VT
		//IL_0976: Invalid comparison between Obj and F8
		//IL_07fc: Expected Obj, but got I4
		//IL_052a: Expected Obj, but got I4
		//IL_0533: Expected Obj, but got I4
		//IL_053b: Expected VT, but got Ref
		//IL_054b: Expected VT, but got I4
		//IL_0564: Expected Obj, but got I4
		//IL_057c: Expected Obj, but got Ref
		//IL_0585: Expected Obj, but got I4
		//IL_058d: Expected I4, but got VT
		//IL_030d: Expected I, but got Obj
		//IL_0312: Expected VT, but got Obj
		//IL_031b: Expected VT, but got I4
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4f: Expected VT, but got Unknown
		//IL_0863: Expected Ref, but got VT
		//IL_087d: Expected Obj, but got I4
		//IL_0a2f: Expected Obj, but got I4
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected VT, but got Unknown
		//IL_04a3: Expected Obj, but got I
		//IL_04ab: Expected VT, but got Obj
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected VT, but got Unknown
		//IL_0131: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I4
		//IL_04e4: Expected Obj, but got I
		//IL_04ec: Expected I4, but got Obj
		//IL_04fe: Expected I4, but got Obj
		//IL_04fe: Expected VT, but got I4
		//IL_033a: Invalid comparison between VT and I4
		//IL_08c9: Expected Obj, but got I4
		//IL_0894: Expected Obj, but got I4
		//IL_089c: Expected Obj, but got VT
		//IL_08a5: Expected Obj, but got I4
		//IL_05e7: Expected Obj, but got I
		//IL_0611: Expected Obj, but got I4
		//IL_0357: Invalid comparison between VT and I4
		//IL_0365: Expected I, but got Obj
		//IL_036a: Expected VT, but got Obj
		//IL_0373: Expected VT, but got I4
		//IL_099d: Expected Obj, but got I
		//IL_09ad: Expected Obj, but got I
		//IL_05c9: Expected Obj, but got I4
		//IL_0739: Expected F4, but got VT
		//IL_0734: Expected native int or pointer, but got VT
		//IL_0747: Expected VT, but got I4
		//IL_0750: Expected VT, but got I4
		//IL_0646: Expected Obj, but got I
		//IL_064f: Expected VT, but got Obj
		//IL_068a: Expected Obj, but got I4
		//IL_06c2: Expected I4, but got I8
		//IL_06d9: Expected VT, but got I4
		//IL_06d9: Expected VT, but got I4
		//IL_06fc: Expected I, but got VT
		//IL_0705: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		Vector3 eyesFromHand2 = eyesFromHand;
		NetworkBool networkBool = right;
		RpcChannel rpcChannel = (RpcChannel)0;
		object obj2 = default;
		object obj = obj2;
		object obj4 = default;
		object obj3 = obj4;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		object obj5;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		int num;
		PlayerRef playerRef;
		RpcInvokeInfo rpcInvokeInfo2;
		PlayerRef playerRef2;
		int num3;
		int num4;
		Fusion.RpcBuilder rpcBuilder4;
		Vector3 vector;
		NetworkBool networkBool2;
		object obj15;
		NullReferenceException ex;
		object obj14;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj5 = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			int bytePayloadSize3 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)((SimulationBehaviour)this)._runner != null)
			{
				object obj8 = bytePayloadSize2 + bytePayloadSize;
				int payloadByteCount = obj8 + bytePayloadSize3;
				Fusion.RpcBuilder rpcBuilder2 = ((SimulationBehaviour)this)._runner.CreateRpcBuilder(847740543u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				num = rpcInvokeInfo >> 32;
				object obj9 = num - 522;
				bool flag4 = (nint)obj9 < 2;
				object obj10 = !flag4;
				object obj11 = ~obj10;
				nint num2;
				if (obj11 == null && num != 518)
				{
					bool flag5 = num != 524;
					num2 = unchecked((nint)null);
					playerRef = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					playerRef2 = invalid;
					if (flag5)
					{
						goto IL_0427;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag6 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						num2 = unchecked((nint)null);
						playerRef = (PlayerRef)this;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						playerRef2 = invalid;
						if (flag6)
						{
							goto IL_0427;
						}
					}
				}
				object obj12 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X0_v66+E4]");
				bool flag7 = (nint)0 == 0;
				object obj13 = !flag7;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D05E0]");
				object rpc = 0;
				playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
				num2 = unchecked((nint)null);
				rpcInvokeInfo2 = rpcInvokeInfo;
				playerRef2 = none;
				goto IL_0427;
			}
			ex = new NullReferenceException();
			vector = eyesFromHand;
			networkBool2 = right;
			num = bytePayloadSize3;
			num3 = bytePayloadSize2;
			obj14 = 0;
			obj = obj2;
			obj15 = obj4;
			rpcBuilder4 = (Fusion.RpcBuilder)0;
			num4 = bytePayloadSize;
			goto IL_07c6;
		}
		goto IL_0005;
		IL_0a15:
		object obj16 = default;
		bool flag8 = obj16 == null;
		object obj17 = !flag8;
		object obj18;
		Fusion.RpcBuilder rpcBuilder5 = default;
		RpcInfo rpcInfo;
		if (obj17 == null)
		{
			if ((nint)obj18 != 7)
			{
				bool flag9 = obj18 == null;
				object obj19 = !flag9;
				if (obj19 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj20 = 0;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X0_v16+E4]");
			bool flag10 = (nint)0 == 0;
			object obj22 = !flag10;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X0_v16+A0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v7+18]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D05D8]");
				object obj25 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj25);
				object obj26 = obj5;
				int num5 = num4 | num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X8_v12+E4]");
				bool flag11 = (nint)0 == 0;
				object obj27 = !flag11;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(num3 & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num5, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ X28_v3+18] (should have been resolved before IL gen)");
				object obj28 = default;
				obj16 = obj28;
				nint num2 = (nint)invalid2;
				rpcInfo = (RpcInfo)0;
				object obj29 = default;
				obj = obj29;
			}
			if (num4 != 0)
			{
				return;
			}
			RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			((Vector3*)(nint)eyesFromHand)->x = (float)rpcBuilder5;
			eyesFromHand2 = (Vector3)0;
			networkBool = (NetworkBool)0;
			rpcChannel = (RpcChannel)0;
			obj3 = obj16;
			rpcBuilder = rpcBuilder5;
			goto IL_0005;
		}
		goto IL_07c6;
		IL_09f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0427:
		object obj30 = rpcInvokeInfo >> 32;
		bool flag12 = obj30 == null;
		object obj31 = !flag12;
		int num6 = (int)rpcInvokeInfo2;
		rpcBuilder4 = (Fusion.RpcBuilder)0;
		Fusion.RpcBuilder rpcBuilder6 = default;
		if (obj31 == null)
		{
			PlayerRef value = (PlayerRef)(by & 0xFFFFFFFFL);
			writer.Write(value, 4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E00]");
			object obj32 = 0;
			playerRef = (PlayerRef)obj32;
			NetworkBool value2 = (NetworkBool)(right & 0xFFFFFFFFL);
			writer.Write(value2, 4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj33 = 0;
			num6 = (int)obj33;
			writer.Write((Vector3)12, (int)obj33);
			int num7 = rpcBuilder3.Send();
			rpcBuilder4 = rpcBuilder6;
		}
		rpcBuilder3.Dispose();
		obj16 = 0;
		object obj34 = 0;
		rpcBuilder5 = (Fusion.RpcBuilder)(&rpcBuilder3);
		vector = (Vector3)playerRef;
		networkBool2 = (NetworkBool)num6;
		rpcInfo = (RpcInfo)playerRef2;
		num3 = (int)(&writer);
		obj14 = 0;
		obj = obj2;
		obj15 = obj4;
		ex = (NullReferenceException)(&rpcBuilder3);
		obj18 = 7;
		num4 = (int)rpcInvokeInfo;
		goto IL_0a15;
		IL_07c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj35;
		OutOfMemoryException ex2;
		if ((nint)obj14 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj16 = 1;
			obj35 = obj34;
		}
		else
		{
			bool flag13 = (nint)obj14 != 1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag13)
			{
				goto IL_09f2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj36 = default;
			obj35 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj34 = obj36;
		}
		((Fusion.RpcBuilder*)rpcBuilder5)->Dispose();
		bool flag14 = obj35 == null;
		object obj37 = !flag14;
		if (obj37 == null)
		{
			obj14 = 0;
			ex = (NullReferenceException)rpcBuilder5;
			obj18 = 0;
			goto IL_0a15;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		obj14 = 0;
		goto IL_09f2;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj38 = 0;
		object obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v75+E4]");
		bool flag15 = (nint)0 == 0;
		object obj40 = !flag15;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkApe.Sane((Vector3)0))
		{
			return;
		}
		object obj41 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v79+E4]");
		bool flag16 = (nint)0 == 0;
		object obj42 = !flag16;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkApe.InBudget((PlayerRef)eyesFromHand.y))
		{
			return;
		}
		NetworkBool networkBool3 = (NetworkBool)(right & 0xFFFFFFFFL);
		bool right2 = networkBool3;
		object obj43 = rpcBuilder6 * rpcBuilder6;
		object obj44 = obj4 * obj4;
		object obj45 = obj43 + obj44;
		object obj46 = obj2 * obj2;
		object obj47 = obj46 + obj45;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj47) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)6.25))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj48 = 0;
			object obj49 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v88+E4]");
			bool flag17 = (nint)0 == 0;
			object obj50 = !flag17;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		}
		PlayerRef playerRef3 = (PlayerRef)(by & 0xFFFFFFFFL);
		Grabbed(playerRef3, right2, eyesFromHand2);
	}

	public unsafe void RPC_Release(Vector3 at, Vector3 velocity, RpcInfo info = default(RpcInfo))
	{
		//IL_08f5: Expected VT, but got I4
		//IL_01ea: Expected Obj, but got I
		//IL_023f: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0066: Expected VT, but got I4
		//IL_078b: Expected Obj, but got I4
		//IL_07a4: Expected VT, but got I4
		//IL_02aa: Expected I4, but got I8
		//IL_00b1: Expected Obj, but got I4
		//IL_02dc: Expected Obj, but got VT
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_0304: Expected Obj, but got I4
		//IL_00d8: Expected VT, but got I4
		//IL_03fd: Expected Obj, but got I4
		//IL_0433: Expected Obj, but got I
		//IL_0445: Expected VT, but got I8
		//IL_0460: Expected VT, but got I4
		//IL_0123: Expected Obj, but got I4
		//IL_0483: Expected Obj, but got VT
		//IL_049d: Expected Obj, but got I4
		//IL_04a5: Expected I4, but got VT
		//IL_04be: Expected VT, but got I4
		//IL_014e: Expected VT, but got F4
		//IL_07e7: Expected Obj, but got I4
		//IL_0549: Expected Obj, but got I4
		//IL_0552: Expected Obj, but got I4
		//IL_055a: Expected VT, but got Ref
		//IL_056a: Expected VT, but got I4
		//IL_0572: Expected I, but got VT
		//IL_057a: Expected Obj, but got Ref
		//IL_0583: Expected Obj, but got I4
		//IL_058b: Expected Obj, but got Ref
		//IL_0594: Expected Obj, but got I4
		//IL_059c: Expected I4, but got VT
		//IL_0353: Expected VT, but got I4
		//IL_0358: Expected VT, but got Obj
		//IL_0361: Expected VT, but got I4
		//IL_084e: Expected Ref, but got VT
		//IL_0868: Expected Obj, but got I4
		//IL_0a06: Expected Obj, but got I4
		//IL_04dc: Expected Obj, but got I
		//IL_04ee: Expected I4, but got Obj
		//IL_04ee: Expected VT, but got I4
		//IL_04f6: Expected I4, but got Obj
		//IL_0508: Expected I4, but got Obj
		//IL_0508: Expected VT, but got I4
		//IL_0380: Invalid comparison between VT and I4
		//IL_0910: Expected Obj, but got VT
		//IL_08b4: Expected Obj, but got I4
		//IL_087f: Expected Obj, but got I4
		//IL_0887: Expected Obj, but got VT
		//IL_0890: Expected Obj, but got I4
		//IL_0a23: Expected VT, but got I4
		//IL_05f6: Expected Obj, but got I
		//IL_0620: Expected Obj, but got I4
		//IL_039d: Invalid comparison between VT and I4
		//IL_03af: Expected VT, but got I4
		//IL_03b4: Expected VT, but got Obj
		//IL_03bd: Expected VT, but got I4
		//IL_0184: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got I4
		//IL_0974: Expected Obj, but got I
		//IL_0984: Expected Obj, but got I
		//IL_05d8: Expected Obj, but got I4
		//IL_0744: Expected F4, but got VT
		//IL_073f: Expected native int or pointer, but got VT
		//IL_0752: Expected VT, but got I4
		//IL_075b: Expected VT, but got I4
		//IL_0655: Expected Obj, but got I
		//IL_065e: Expected VT, but got Obj
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Expected I4, but got Unknown
		//IL_0699: Expected Obj, but got I4
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Expected I4, but got Unknown
		//IL_06e8: Expected VT, but got I4
		//IL_06e8: Expected VT, but got I4
		//IL_0710: Expected I, but got Obj
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		RpcChannel rpcChannel = (RpcChannel)0;
		object obj2 = default;
		object obj = obj2;
		object obj4 = default;
		object obj3 = obj4;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		object obj5;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		object obj8 = default;
		PlayerRef playerRef2;
		RpcInvokeInfo rpcInvokeInfo2;
		PlayerRef playerRef3;
		int num;
		object obj15;
		Fusion.RpcBuilder rpcBuilder4;
		NullReferenceException ex;
		object obj14;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj5 = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			object obj6 = obj5;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				int payloadByteCount = bytePayloadSize2 + bytePayloadSize;
				Fusion.RpcBuilder rpcBuilder2 = networkRunner.CreateRpcBuilder(4260040627u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				obj8 = rpcInvokeInfo >> 32;
				object obj9 = obj8 - 522;
				bool flag4 = (nint)obj9 < 2;
				object obj10 = !flag4;
				object obj11 = ~obj10;
				PlayerRef playerRef;
				if (obj11 == null && (nint)obj8 != 518)
				{
					bool flag5 = (nint)obj8 != 524;
					playerRef = (PlayerRef)0;
					playerRef2 = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					playerRef3 = invalid;
					if (flag5)
					{
						goto IL_0475;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag6 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						playerRef = (PlayerRef)0;
						playerRef2 = (PlayerRef)this;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						playerRef3 = invalid;
						if (flag6)
						{
							goto IL_0475;
						}
					}
				}
				object obj12 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v63+E4]");
				bool flag7 = (nint)0 == 0;
				object obj13 = !flag7;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D05F0]");
				object rpc = 0;
				playerRef2 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef2);
				playerRef = (PlayerRef)0;
				rpcInvokeInfo2 = rpcInvokeInfo;
				playerRef3 = none;
				goto IL_0475;
			}
			ex = new NullReferenceException();
			obj14 = 0;
			obj = obj2;
			obj15 = obj4;
			rpcBuilder4 = (Fusion.RpcBuilder)0;
			num = bytePayloadSize;
			goto IL_07b1;
		}
		goto IL_0005;
		IL_09ec:
		object obj16 = default;
		bool flag8 = obj16 == null;
		object obj17 = !flag8;
		object obj18;
		Fusion.RpcBuilder rpcBuilder5 = default;
		RpcInfo rpcInfo2;
		Vector3 velocity2 = default;
		nint num3;
		if (obj17 == null)
		{
			if ((nint)obj18 != 7)
			{
				bool flag9 = obj18 == null;
				object obj19 = !flag9;
				if (obj19 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj20 = 0;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X0_v14+E4]");
			bool flag10 = (nint)0 == 0;
			object obj22 = !flag10;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X0_v14+A0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X8_v7+18]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D05E8]");
				object obj25 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj25);
				object obj26 = obj5;
				int num2 = num | obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v12+E4]");
				bool flag11 = (nint)0 == 0;
				object obj27 = !flag11;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(networkRunner & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num2, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ X26_v3+18] (should have been resolved before IL gen)");
				object obj28 = default;
				obj16 = obj28;
				PlayerRef playerRef = invalid2;
				num3 = unchecked((nint)null);
				object obj29 = default;
				obj = obj29;
			}
			if (num != 0)
			{
				return;
			}
			RpcInfo rpcInfo = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			((Vector3*)(nint)at)->x = (float)rpcBuilder5;
			rpcInfo2 = (RpcInfo)0;
			velocity2 = (Vector3)0;
			rpcChannel = (RpcChannel)0;
			obj3 = obj16;
			rpcBuilder = rpcBuilder5;
			goto IL_0005;
		}
		goto IL_07b1;
		IL_09c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0475:
		object obj30 = rpcInvokeInfo >> 32;
		bool flag12 = obj30 == null;
		object obj31 = !flag12;
		int num4 = (int)rpcInvokeInfo2;
		obj = obj2;
		obj15 = obj4;
		rpcBuilder4 = (Fusion.RpcBuilder)0;
		object obj33 = default;
		object obj34 = default;
		Fusion.RpcBuilder rpcBuilder6 = default;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj32 = 0;
			writer.Write((Vector3)12, (int)obj32);
			num4 = (int)obj32;
			writer.Write((Vector3)12, (int)obj32);
			int num5 = rpcBuilder3.Send();
			obj = obj33;
			obj15 = obj34;
			rpcBuilder4 = rpcBuilder6;
		}
		rpcBuilder3.Dispose();
		obj16 = 0;
		object obj35 = 0;
		rpcBuilder5 = (Fusion.RpcBuilder)(&rpcBuilder3);
		rpcInfo2 = (RpcInfo)playerRef2;
		velocity2 = (Vector3)num4;
		num3 = (nint)playerRef3;
		networkRunner = (NetworkRunner)(&writer);
		obj14 = 0;
		ex = (NullReferenceException)(&rpcBuilder3);
		obj18 = 7;
		num = (int)rpcInvokeInfo;
		goto IL_09ec;
		IL_07b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj36;
		OutOfMemoryException ex2;
		if ((nint)obj14 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj16 = 1;
			obj36 = obj35;
		}
		else
		{
			bool flag13 = (nint)obj14 != 1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag13)
			{
				goto IL_09c9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj37 = default;
			obj36 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj35 = obj37;
		}
		((Fusion.RpcBuilder*)rpcBuilder5)->Dispose();
		bool flag14 = obj36 == null;
		object obj38 = !flag14;
		if (obj38 == null)
		{
			obj14 = 0;
			ex = (NullReferenceException)rpcBuilder5;
			obj18 = 0;
			goto IL_09ec;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		obj14 = 0;
		goto IL_09c9;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj39 = 0;
		object obj40 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v72+E4]");
		bool flag15 = (nint)0 == 0;
		object obj41 = !flag15;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkApe.Sane((Vector3)0))
		{
			return;
		}
		object obj42 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v76+E4]");
		bool flag16 = (nint)0 == 0;
		object obj43 = !flag16;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkApe.Sane((Vector3)0))
		{
			return;
		}
		object obj44 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v80+E4]");
		bool flag17 = (nint)0 == 0;
		object obj45 = !flag17;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkApe.InBudget((PlayerRef)at.y))
		{
			return;
		}
		object obj46 = rpcBuilder6 * rpcBuilder6;
		object obj47 = obj34 * obj34;
		object obj48 = obj46 + obj47;
		object obj49 = obj33 * obj33;
		object obj50 = obj49 + obj48;
		if ((nint)obj50 > 1132462080)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj51 = 0;
			object obj52 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X0_v87+E4]");
			bool flag18 = (nint)0 == 0;
			object obj53 = !flag18;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		}
		Released((Vector3)0, velocity2);
	}

	public unsafe void RPC_Punch(byte section, Vector3 point, RpcInfo info = default(RpcInfo))
	{
		//IL_081a: Expected I4, but got VT
		//IL_0844: Expected VT, but got I4
		//IL_0129: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_006a: Expected VT, but got I4
		//IL_06ca: Expected Obj, but got I4
		//IL_06e3: Expected VT, but got I4
		//IL_01e9: Expected I4, but got I8
		//IL_00b5: Expected Obj, but got I4
		//IL_021b: Expected Obj, but got VT
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0243: Expected Obj, but got I4
		//IL_00e0: Expected VT, but got F4
		//IL_033c: Expected Obj, but got I4
		//IL_0372: Expected Obj, but got I
		//IL_0384: Expected VT, but got I8
		//IL_039f: Expected VT, but got I4
		//IL_0114: Expected VT, but got I4
		//IL_03c2: Expected Obj, but got VT
		//IL_03dc: Expected Obj, but got I4
		//IL_03e4: Expected I4, but got VT
		//IL_03ed: Expected VT, but got I4
		//IL_0726: Expected Obj, but got I4
		//IL_0478: Expected Obj, but got I4
		//IL_0481: Expected Obj, but got I4
		//IL_0489: Expected VT, but got Ref
		//IL_0491: Expected I, but got VT
		//IL_0499: Expected Obj, but got Ref
		//IL_04a1: Expected VT, but got I4
		//IL_04aa: Expected Obj, but got I4
		//IL_04c2: Expected Obj, but got Ref
		//IL_04cb: Expected Obj, but got I4
		//IL_04d3: Expected I4, but got VT
		//IL_0292: Expected VT, but got I4
		//IL_0297: Expected VT, but got Obj
		//IL_02a8: Expected VT, but got I4
		//IL_078d: Expected Ref, but got VT
		//IL_07a7: Expected Obj, but got I4
		//IL_08f4: Expected Obj, but got I4
		//IL_040b: Expected Obj, but got I
		//IL_0413: Expected VT, but got Obj
		//IL_042d: Expected Obj, but got I
		//IL_0435: Expected I4, but got Obj
		//IL_0447: Expected I4, but got Obj
		//IL_0447: Expected VT, but got I4
		//IL_02bf: Invalid comparison between VT and I4
		//IL_07f3: Expected Obj, but got I4
		//IL_07be: Expected Obj, but got I4
		//IL_07c6: Expected Obj, but got VT
		//IL_07cf: Expected Obj, but got I4
		//IL_052d: Expected Obj, but got I
		//IL_0557: Expected Obj, but got I4
		//IL_02dc: Invalid comparison between VT and I4
		//IL_02ee: Expected VT, but got I4
		//IL_02f3: Expected VT, but got Obj
		//IL_0304: Expected VT, but got I4
		//IL_0862: Expected Obj, but got I
		//IL_0872: Expected Obj, but got I
		//IL_050f: Expected Obj, but got I4
		//IL_067b: Expected F4, but got VT
		//IL_0676: Expected native int or pointer, but got VT
		//IL_0692: Expected VT, but got I4
		//IL_058c: Expected Obj, but got I
		//IL_0595: Expected VT, but got Obj
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected I4, but got Unknown
		//IL_05d0: Expected Obj, but got I4
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected I4, but got Unknown
		//IL_061f: Expected VT, but got I4
		//IL_061f: Expected VT, but got I4
		//IL_0647: Expected I, but got Obj
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		RpcInfo rpcInfo = default;
		bool counts = (byte)(int)rpcInfo != 0;
		Vector3 vector = point;
		RpcChannel rpcChannel = (RpcChannel)0;
		object obj2 = default;
		object obj = obj2;
		object obj4 = default;
		object obj3 = obj4;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		object obj5;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		object obj8 = default;
		PlayerRef playerRef3;
		RpcInvokeInfo rpcInvokeInfo2;
		int num;
		Fusion.RpcBuilder rpcBuilder4;
		Vector3 vector2;
		object obj15;
		NullReferenceException ex;
		object obj14;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj5 = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			object obj6 = obj5;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				int payloadByteCount = bytePayloadSize2 + bytePayloadSize;
				Fusion.RpcBuilder rpcBuilder2 = networkRunner.CreateRpcBuilder(3835533800u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				obj8 = rpcInvokeInfo >> 32;
				object obj9 = obj8 - 522;
				bool flag4 = (nint)obj9 < 2;
				object obj10 = !flag4;
				object obj11 = ~obj10;
				PlayerRef playerRef2;
				PlayerRef playerRef;
				if (obj11 == null && (nint)obj8 != 518)
				{
					bool flag5 = (nint)obj8 != 524;
					playerRef = (PlayerRef)0;
					playerRef2 = (PlayerRef)this;
					playerRef3 = invalid;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag5)
					{
						goto IL_03b4;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag6 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						playerRef = (PlayerRef)0;
						playerRef2 = (PlayerRef)this;
						playerRef3 = invalid;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag6)
						{
							goto IL_03b4;
						}
					}
				}
				object obj12 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X0_v63+E4]");
				bool flag7 = (nint)0 == 0;
				object obj13 = !flag7;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0600]");
				object rpc = 0;
				playerRef2 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef2);
				playerRef = (PlayerRef)0;
				playerRef3 = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_03b4;
			}
			ex = new NullReferenceException();
			vector2 = point;
			obj14 = 0;
			obj = obj2;
			obj15 = obj4;
			rpcBuilder4 = (Fusion.RpcBuilder)0;
			num = bytePayloadSize;
			goto IL_06f0;
		}
		goto IL_0005;
		IL_08da:
		object obj16 = default;
		bool flag8 = obj16 == null;
		object obj17 = !flag8;
		object obj18;
		Fusion.RpcBuilder rpcBuilder5 = default;
		nint num3;
		if (obj17 == null)
		{
			if ((nint)obj18 != 7)
			{
				bool flag9 = obj18 == null;
				object obj19 = !flag9;
				if (obj19 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj20 = 0;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v14+E4]");
			bool flag10 = (nint)0 == 0;
			object obj22 = !flag10;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v14+A0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v7+18]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D05F8]");
				object obj25 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj25);
				object obj26 = obj5;
				int num2 = num | obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v12+E4]");
				bool flag11 = (nint)0 == 0;
				object obj27 = !flag11;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(networkRunner & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num2, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ X27_v3+18] (should have been resolved before IL gen)");
				object obj28 = default;
				obj16 = obj28;
				PlayerRef playerRef = invalid2;
				num3 = unchecked((nint)null);
				object obj29 = default;
				obj = obj29;
			}
			if (num != 0)
			{
				return;
			}
			RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			((Vector3*)(nint)point)->x = (float)rpcBuilder5;
			counts = false;
			vector = (Vector3)0;
			rpcChannel = (RpcChannel)0;
			obj3 = obj16;
			rpcBuilder = rpcBuilder5;
			goto IL_0005;
		}
		goto IL_06f0;
		IL_08b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_03b4:
		object obj30 = rpcInvokeInfo >> 32;
		bool flag12 = obj30 == null;
		object obj31 = !flag12;
		int num4 = (int)rpcInvokeInfo2;
		rpcBuilder4 = (Fusion.RpcBuilder)0;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj32 = 0;
			PlayerRef playerRef2 = (PlayerRef)obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj33 = 0;
			num4 = (int)obj33;
			writer.Write((Vector3)12, (int)obj33);
			int num5 = rpcBuilder3.Send();
			Fusion.RpcBuilder rpcBuilder6 = default;
			rpcBuilder4 = rpcBuilder6;
		}
		rpcBuilder3.Dispose();
		obj16 = 0;
		object obj34 = 0;
		rpcBuilder5 = (Fusion.RpcBuilder)(&rpcBuilder3);
		num3 = (nint)playerRef3;
		networkRunner = (NetworkRunner)(&writer);
		vector2 = (Vector3)num4;
		obj14 = 0;
		obj = obj2;
		obj15 = obj4;
		ex = (NullReferenceException)(&rpcBuilder3);
		obj18 = 7;
		num = (int)rpcInvokeInfo;
		goto IL_08da;
		IL_06f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj35;
		OutOfMemoryException ex2;
		if ((nint)obj14 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj16 = 1;
			obj35 = obj34;
		}
		else
		{
			bool flag13 = (nint)obj14 != 1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag13)
			{
				goto IL_08b7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj36 = default;
			obj35 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj34 = obj36;
		}
		((Fusion.RpcBuilder*)rpcBuilder5)->Dispose();
		bool flag14 = obj35 == null;
		object obj37 = !flag14;
		if (obj37 == null)
		{
			obj14 = 0;
			ex = (NullReferenceException)rpcBuilder5;
			obj18 = 0;
			goto IL_08da;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		obj14 = 0;
		goto IL_08b7;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj38 = 0;
		object obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v72+E4]");
		bool flag15 = (nint)0 == 0;
		object obj40 = !flag15;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (NetworkApe.SaneWound(section, (Vector3)0))
		{
			object obj41 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v76+E4]");
			bool flag16 = (nint)0 == 0;
			object obj42 = !flag16;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (NetworkApe.InBudget((PlayerRef)point.y))
			{
				Punched((GoreSection)section, (Vector3)1, counts);
			}
		}
	}

	public unsafe void RPC_Wound(byte section, Vector3 point, RpcInfo info = default(RpcInfo))
	{
		//IL_081a: Expected I4, but got VT
		//IL_0844: Expected VT, but got I4
		//IL_0129: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_006a: Expected VT, but got I4
		//IL_06ca: Expected Obj, but got I4
		//IL_06e3: Expected VT, but got I4
		//IL_01e9: Expected I4, but got I8
		//IL_00b5: Expected Obj, but got I4
		//IL_021b: Expected Obj, but got VT
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0243: Expected Obj, but got I4
		//IL_00e0: Expected VT, but got F4
		//IL_033c: Expected Obj, but got I4
		//IL_0372: Expected Obj, but got I
		//IL_0384: Expected VT, but got I8
		//IL_039f: Expected VT, but got I4
		//IL_0114: Expected VT, but got I4
		//IL_03c2: Expected Obj, but got VT
		//IL_03dc: Expected Obj, but got I4
		//IL_03e4: Expected I4, but got VT
		//IL_03ed: Expected VT, but got I4
		//IL_0726: Expected Obj, but got I4
		//IL_0478: Expected Obj, but got I4
		//IL_0481: Expected Obj, but got I4
		//IL_0489: Expected VT, but got Ref
		//IL_0491: Expected I, but got VT
		//IL_0499: Expected Obj, but got Ref
		//IL_04a1: Expected VT, but got I4
		//IL_04aa: Expected Obj, but got I4
		//IL_04c2: Expected Obj, but got Ref
		//IL_04cb: Expected Obj, but got I4
		//IL_04d3: Expected I4, but got VT
		//IL_0292: Expected VT, but got I4
		//IL_0297: Expected VT, but got Obj
		//IL_02a8: Expected VT, but got I4
		//IL_078d: Expected Ref, but got VT
		//IL_07a7: Expected Obj, but got I4
		//IL_08f4: Expected Obj, but got I4
		//IL_040b: Expected Obj, but got I
		//IL_0413: Expected VT, but got Obj
		//IL_042d: Expected Obj, but got I
		//IL_0435: Expected I4, but got Obj
		//IL_0447: Expected I4, but got Obj
		//IL_0447: Expected VT, but got I4
		//IL_02bf: Invalid comparison between VT and I4
		//IL_07f3: Expected Obj, but got I4
		//IL_07be: Expected Obj, but got I4
		//IL_07c6: Expected Obj, but got VT
		//IL_07cf: Expected Obj, but got I4
		//IL_052d: Expected Obj, but got I
		//IL_0557: Expected Obj, but got I4
		//IL_02dc: Invalid comparison between VT and I4
		//IL_02ee: Expected VT, but got I4
		//IL_02f3: Expected VT, but got Obj
		//IL_0304: Expected VT, but got I4
		//IL_0862: Expected Obj, but got I
		//IL_0872: Expected Obj, but got I
		//IL_050f: Expected Obj, but got I4
		//IL_067b: Expected F4, but got VT
		//IL_0676: Expected native int or pointer, but got VT
		//IL_0692: Expected VT, but got I4
		//IL_058c: Expected Obj, but got I
		//IL_0595: Expected VT, but got Obj
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected I4, but got Unknown
		//IL_05d0: Expected Obj, but got I4
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected I4, but got Unknown
		//IL_061f: Expected VT, but got I4
		//IL_061f: Expected VT, but got I4
		//IL_0647: Expected I, but got Obj
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		RpcInfo rpcInfo = default;
		bool counts = (byte)(int)rpcInfo != 0;
		Vector3 vector = point;
		RpcChannel rpcChannel = (RpcChannel)0;
		object obj2 = default;
		object obj = obj2;
		object obj4 = default;
		object obj3 = obj4;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		object obj5;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		object obj8 = default;
		PlayerRef playerRef3;
		RpcInvokeInfo rpcInvokeInfo2;
		int num;
		Fusion.RpcBuilder rpcBuilder4;
		Vector3 vector2;
		object obj15;
		NullReferenceException ex;
		object obj14;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj5 = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			object obj6 = obj5;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				int payloadByteCount = bytePayloadSize2 + bytePayloadSize;
				Fusion.RpcBuilder rpcBuilder2 = networkRunner.CreateRpcBuilder(2797674477u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				obj8 = rpcInvokeInfo >> 32;
				object obj9 = obj8 - 522;
				bool flag4 = (nint)obj9 < 2;
				object obj10 = !flag4;
				object obj11 = ~obj10;
				PlayerRef playerRef2;
				PlayerRef playerRef;
				if (obj11 == null && (nint)obj8 != 518)
				{
					bool flag5 = (nint)obj8 != 524;
					playerRef = (PlayerRef)0;
					playerRef2 = (PlayerRef)this;
					playerRef3 = invalid;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag5)
					{
						goto IL_03b4;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag6 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						playerRef = (PlayerRef)0;
						playerRef2 = (PlayerRef)this;
						playerRef3 = invalid;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag6)
						{
							goto IL_03b4;
						}
					}
				}
				object obj12 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X0_v63+E4]");
				bool flag7 = (nint)0 == 0;
				object obj13 = !flag7;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0610]");
				object rpc = 0;
				playerRef2 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef2);
				playerRef = (PlayerRef)0;
				playerRef3 = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_03b4;
			}
			ex = new NullReferenceException();
			vector2 = point;
			obj14 = 0;
			obj = obj2;
			obj15 = obj4;
			rpcBuilder4 = (Fusion.RpcBuilder)0;
			num = bytePayloadSize;
			goto IL_06f0;
		}
		goto IL_0005;
		IL_08da:
		object obj16 = default;
		bool flag8 = obj16 == null;
		object obj17 = !flag8;
		object obj18;
		Fusion.RpcBuilder rpcBuilder5 = default;
		nint num3;
		if (obj17 == null)
		{
			if ((nint)obj18 != 7)
			{
				bool flag9 = obj18 == null;
				object obj19 = !flag9;
				if (obj19 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj20 = 0;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v14+E4]");
			bool flag10 = (nint)0 == 0;
			object obj22 = !flag10;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v14+A0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v7+18]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0608]");
				object obj25 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj25);
				object obj26 = obj5;
				int num2 = num | obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v12+E4]");
				bool flag11 = (nint)0 == 0;
				object obj27 = !flag11;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(networkRunner & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num2, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ X27_v3+18] (should have been resolved before IL gen)");
				object obj28 = default;
				obj16 = obj28;
				PlayerRef playerRef = invalid2;
				num3 = unchecked((nint)null);
				object obj29 = default;
				obj = obj29;
			}
			if (num != 0)
			{
				return;
			}
			RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			((Vector3*)(nint)point)->x = (float)rpcBuilder5;
			counts = false;
			vector = (Vector3)0;
			rpcChannel = (RpcChannel)0;
			obj3 = obj16;
			rpcBuilder = rpcBuilder5;
			goto IL_0005;
		}
		goto IL_06f0;
		IL_08b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_03b4:
		object obj30 = rpcInvokeInfo >> 32;
		bool flag12 = obj30 == null;
		object obj31 = !flag12;
		int num4 = (int)rpcInvokeInfo2;
		rpcBuilder4 = (Fusion.RpcBuilder)0;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj32 = 0;
			PlayerRef playerRef2 = (PlayerRef)obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj33 = 0;
			num4 = (int)obj33;
			writer.Write((Vector3)12, (int)obj33);
			int num5 = rpcBuilder3.Send();
			Fusion.RpcBuilder rpcBuilder6 = default;
			rpcBuilder4 = rpcBuilder6;
		}
		rpcBuilder3.Dispose();
		obj16 = 0;
		object obj34 = 0;
		rpcBuilder5 = (Fusion.RpcBuilder)(&rpcBuilder3);
		num3 = (nint)playerRef3;
		networkRunner = (NetworkRunner)(&writer);
		vector2 = (Vector3)num4;
		obj14 = 0;
		obj = obj2;
		obj15 = obj4;
		ex = (NullReferenceException)(&rpcBuilder3);
		obj18 = 7;
		num = (int)rpcInvokeInfo;
		goto IL_08da;
		IL_06f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj35;
		OutOfMemoryException ex2;
		if ((nint)obj14 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj16 = 1;
			obj35 = obj34;
		}
		else
		{
			bool flag13 = (nint)obj14 != 1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag13)
			{
				goto IL_08b7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj36 = default;
			obj35 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj34 = obj36;
		}
		((Fusion.RpcBuilder*)rpcBuilder5)->Dispose();
		bool flag14 = obj35 == null;
		object obj37 = !flag14;
		if (obj37 == null)
		{
			obj14 = 0;
			ex = (NullReferenceException)rpcBuilder5;
			obj18 = 0;
			goto IL_08da;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		obj14 = 0;
		goto IL_08b7;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj38 = 0;
		object obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v72+E4]");
		bool flag15 = (nint)0 == 0;
		object obj40 = !flag15;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (NetworkApe.SaneWound(section, (Vector3)0))
		{
			object obj41 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v76+E4]");
			bool flag16 = (nint)0 == 0;
			object obj42 = !flag16;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (NetworkApe.InBudget((PlayerRef)point.y))
			{
				Punched((GoreSection)section, (Vector3)0, counts);
			}
		}
	}

	public unsafe void RPC_Stab(byte section, Vector3 point, float radius, byte does, RpcInfo info = default(RpcInfo))
	{
		//IL_09a1: Expected VT, but got I4
		//IL_01f0: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I4
		//IL_006a: Expected VT, but got I4
		//IL_07fb: Expected Obj, but got I4
		//IL_0814: Expected VT, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00b3: Expected Obj, but got I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00db: Expected Obj, but got I4
		//IL_02b6: Expected Obj, but got I4
		//IL_02c3: Expected Obj, but got I4
		//IL_02d0: Expected I4, but got Obj
		//IL_0319: Expected Obj, but got VT
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_0341: Expected Obj, but got I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_0432: Expected Obj, but got I4
		//IL_0468: Expected Obj, but got I
		//IL_047a: Expected VT, but got I8
		//IL_0491: Expected I, but got Obj
		//IL_014b: Expected Obj, but got I4
		//IL_04b4: Expected Obj, but got VT
		//IL_04ce: Expected Obj, but got I4
		//IL_04d7: Expected F4, but got I4
		//IL_0179: Expected VT, but got I
		//IL_085f: Expected Obj, but got I4
		//IL_0870: Expected Obj, but got I4
		//IL_0585: Expected Obj, but got I4
		//IL_058e: Expected Obj, but got I4
		//IL_0596: Expected VT, but got Ref
		//IL_059e: Expected I4, but got VT
		//IL_05bf: Expected Obj, but got I4
		//IL_05d7: Expected VT, but got F4
		//IL_05df: Expected Obj, but got Ref
		//IL_05e8: Expected Obj, but got I4
		//IL_05f0: Expected I4, but got VT
		//IL_038c: Expected I, but got Obj
		//IL_0391: Expected VT, but got Obj
		//IL_039a: Expected VT, but got I4
		//IL_08c7: Expected Ref, but got VT
		//IL_04f5: Expected Obj, but got I
		//IL_050f: Expected Obj, but got I
		//IL_0521: Expected I4, but got Obj
		//IL_0521: Expected VT, but got I4
		//IL_01aa: Invalid comparison between F4 and I
		//IL_0541: Expected VT, but got Obj
		//IL_03b9: Invalid comparison between VT and I4
		//IL_092d: Expected Obj, but got I4
		//IL_08f8: Expected Obj, but got I4
		//IL_0900: Expected Obj, but got VT
		//IL_0909: Expected Obj, but got I4
		//IL_0566: Expected VT, but got I4
		//IL_01ce: Invalid comparison between F4 and I
		//IL_064a: Expected Obj, but got I
		//IL_0674: Expected Obj, but got I4
		//IL_03d6: Invalid comparison between VT and I4
		//IL_03e4: Expected I, but got Obj
		//IL_03e9: Expected VT, but got Obj
		//IL_03f2: Expected VT, but got I4
		//IL_09da: Expected Obj, but got I
		//IL_09ea: Expected Obj, but got I
		//IL_062c: Expected Obj, but got I4
		//IL_079c: Expected I4, but got VT
		//IL_07b3: Expected VT, but got I4
		//IL_06a9: Expected Obj, but got I
		//IL_06b2: Expected VT, but got Obj
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Expected I4, but got Unknown
		//IL_06ed: Expected Obj, but got I4
		//IL_0725: Expected I4, but got I8
		//IL_073c: Expected VT, but got I4
		//IL_073c: Expected VT, but got I4
		//IL_075f: Expected I, but got VT
		//IL_0768: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		byte does2 = does;
		Vector3 vector = point;
		RpcChannel rpcChannel = (RpcChannel)0;
		object obj2 = default;
		object obj = obj2;
		object obj4 = default;
		object obj3 = obj4;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		if (!flag2)
		{
			goto IL_0005;
		}
		goto IL_01e0;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v79+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkApe.SaneWound(section, (Vector3)0))
		{
			return;
		}
		object obj8 = point & 0xFF;
		bool flag4 = (nint)obj8 < 2;
		object obj9 = !flag4;
		object obj10 = obj8 - 2;
		bool flag5 = obj10 == null;
		object obj11 = !flag5;
		object obj12 = obj9 & obj11;
		if (obj12 != null)
		{
			return;
		}
		float num = default;
		object obj13 = num & 0x7F800000;
		if ((nint)obj13 == 2139095040)
		{
			return;
		}
		object obj14 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v83+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [does @ X3 (System.Byte)+4]");
		if (!NetworkApe.InBudget((PlayerRef)0))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B00C]");
		if (!(num < 0f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			if (num > 0f)
			{
				goto IL_01e0;
			}
		}
		Stabbed((GoreSection)section, point, radius, does2);
		return;
		IL_04a6:
		RpcInvokeInfo rpcInvokeInfo;
		object obj16 = rpcInvokeInfo >> 32;
		bool flag7 = obj16 == null;
		object obj17 = !flag7;
		float num2 = 0f;
		Fusion.RpcDataWriter writer;
		PlayerRef playerRef;
		Fusion.RpcBuilder rpcBuilder2 = default;
		RpcInvokeInfo rpcInvokeInfo2;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj19 = 0;
			writer.Write((Vector3)12, (int)obj19);
			writer.Write(num, 4);
			playerRef = (PlayerRef)obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			int num3 = rpcBuilder2.Send();
			rpcInvokeInfo2 = (RpcInvokeInfo)1;
			num2 = num;
		}
		rpcBuilder2.Dispose();
		object obj20 = 0;
		object obj21 = 0;
		Fusion.RpcBuilder rpcBuilder3 = (Fusion.RpcBuilder)(&rpcBuilder2);
		byte b = (byte)(int)playerRef;
		Vector3 vector2 = (Vector3)rpcInvokeInfo2;
		PlayerRef playerRef2;
		RpcInfo rpcInfo = (RpcInfo)playerRef2;
		int num4 = (int)(&writer);
		object obj22 = 0;
		obj = obj2;
		object obj23 = obj4;
		Fusion.RpcBuilder rpcBuilder4 = (Fusion.RpcBuilder)num2;
		NullReferenceException ex = (NullReferenceException)(&rpcBuilder2);
		object obj24 = 7;
		int num5 = (int)rpcInvokeInfo;
		goto IL_0a32;
		IL_0821:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		OutOfMemoryException ex3 = default;
		OutOfMemoryException ex2 = ex3;
		object obj26 = default;
		NetworkRunner networkRunner;
		OutOfMemoryException ex5 = default;
		while (true)
		{
			object obj25;
			if ((nint)obj22 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj20 = 1;
				obj25 = obj21;
				obj24 = 1;
			}
			else
			{
				if ((nint)obj22 != 1)
				{
					goto IL_0a0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj25 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj21 = obj26;
			}
			((Fusion.RpcBuilder*)rpcBuilder3)->Dispose();
			if (obj25 == null)
			{
				break;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			ex2 = ex4;
			obj22 = 0;
			goto IL_0a0f;
			IL_0a0f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			networkRunner = null;
			ex2 = ex5;
			num4 = 0;
			num5 = 0;
		}
		obj22 = 0;
		ex = (NullReferenceException)rpcBuilder3;
		obj24 = 0;
		goto IL_0a32;
		IL_01e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj27 = 0;
		int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(1);
		int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
		int bytePayloadSize3 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
		int bytePayloadSize4 = Fusion.RpcDataWriter.GetBytePayloadSize(1);
		obj24 = obj27;
		networkRunner = ((SimulationBehaviour)this)._runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X8_v18+E4]");
		bool flag8 = (nint)0 == 0;
		object obj28 = !flag8;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef invalid = PlayerRef.Invalid;
		if ((object)networkRunner != null)
		{
			object obj29 = bytePayloadSize2 + bytePayloadSize;
			object obj30 = bytePayloadSize3 + bytePayloadSize4;
			int payloadByteCount = (int)(obj29 + obj30);
			Fusion.RpcBuilder rpcBuilder5 = networkRunner.CreateRpcBuilder(1715877582u, payloadByteCount, (NetworkBehaviour)this, invalid);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			rpcInvokeInfo = rpcBuilder2.Prepare(out writer);
			networkRunner = (NetworkRunner)(rpcInvokeInfo >> 32);
			object obj31 = networkRunner - 522;
			bool flag9 = (nint)obj31 < 2;
			object obj32 = !flag9;
			object obj33 = ~obj32;
			nint num6;
			if (obj33 == null && (nint)networkRunner != 518)
			{
				bool flag10 = (nint)networkRunner != 524;
				num6 = unchecked((nint)null);
				playerRef = (PlayerRef)this;
				rpcInvokeInfo2 = (RpcInvokeInfo)0;
				playerRef2 = invalid;
				if (flag10)
				{
					goto IL_04a6;
				}
				if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
				{
					bool flag11 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
					num6 = unchecked((nint)null);
					playerRef = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					playerRef2 = invalid;
					if (flag11)
					{
						goto IL_04a6;
					}
				}
			}
			object obj34 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v70+E4]");
			bool flag12 = (nint)0 == 0;
			object obj35 = !flag12;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef none = PlayerRef.None;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0620]");
			object rpc = 0;
			playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
			NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
			num6 = unchecked((nint)null);
			rpcInvokeInfo2 = rpcInvokeInfo;
			playerRef2 = none;
			goto IL_04a6;
		}
		ex = new NullReferenceException();
		b = does;
		vector2 = point;
		num4 = bytePayloadSize2;
		obj22 = 0;
		obj = obj2;
		obj23 = obj4;
		rpcBuilder4 = (Fusion.RpcBuilder)0;
		num5 = bytePayloadSize;
		goto IL_0821;
		IL_0a32:
		if (obj20 == null)
		{
			if ((nint)obj24 != 7)
			{
				bool flag13 = obj24 == null;
				object obj36 = !flag13;
				if (obj36 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj37 = 0;
			object obj38 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X0_v18+E4]");
			bool flag14 = (nint)0 == 0;
			object obj39 = !flag14;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj38 = obj37;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X0_v18+A0]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v7+18]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0618]");
				object obj42 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj42);
				object obj43 = obj27;
				int num7 = num5 | networkRunner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X8_v12+E4]");
				bool flag15 = (nint)0 == 0;
				object obj44 = !flag15;
				if (obj44 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(num4 & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num7, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v123 @ X27_v4+18] (should have been resolved before IL gen)");
				object obj45 = default;
				obj20 = obj45;
				nint num6 = (nint)invalid2;
				rpcInfo = (RpcInfo)0;
				object obj46 = default;
				obj = obj46;
			}
			if (num5 != 0)
			{
				return;
			}
			RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			((byte*)(int)does)->m_value = (byte)(int)rpcBuilder3;
			does2 = 0;
			vector = (Vector3)0;
			rpcChannel = (RpcChannel)0;
			obj3 = obj20;
			rpcBuilder = rpcBuilder3;
			goto IL_0005;
		}
		goto IL_0821;
	}

	public unsafe void RPC_Tear(byte part, RpcInfo info = default(RpcInfo))
	{
		//IL_0773: Expected VT, but got I4
		//IL_0115: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I4
		//IL_002d: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		//IL_063b: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got VT
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_020b: Expected Obj, but got I4
		//IL_0304: Expected Obj, but got I4
		//IL_033a: Expected Obj, but got I
		//IL_034c: Expected VT, but got I8
		//IL_0367: Expected VT, but got I4
		//IL_038a: Expected Obj, but got VT
		//IL_03a4: Expected Obj, but got I4
		//IL_040a: Expected Obj, but got I4
		//IL_0412: Expected VT, but got Ref
		//IL_041a: Expected I, but got VT
		//IL_042a: Expected Obj, but got Ref
		//IL_0433: Expected Obj, but got I4
		//IL_043b: Expected Obj, but got Ref
		//IL_0444: Expected Obj, but got I4
		//IL_044c: Expected I4, but got VT
		//IL_025a: Expected VT, but got I4
		//IL_025f: Expected VT, but got Obj
		//IL_0268: Expected VT, but got I4
		//IL_06e5: Expected Ref, but got VT
		//IL_06ff: Expected Obj, but got I4
		//IL_0834: Expected Obj, but got I4
		//IL_03c2: Expected Obj, but got I
		//IL_03ca: Expected VT, but got Obj
		//IL_03ea: Expected VT, but got I4
		//IL_0287: Invalid comparison between VT and I4
		//IL_074b: Expected Obj, but got I4
		//IL_0716: Expected Obj, but got I4
		//IL_071e: Expected Obj, but got VT
		//IL_0727: Expected Obj, but got I4
		//IL_04a6: Expected Obj, but got I
		//IL_04d0: Expected Obj, but got I4
		//IL_02a4: Invalid comparison between VT and I4
		//IL_02b6: Expected VT, but got I4
		//IL_02bb: Expected VT, but got Obj
		//IL_02c4: Expected VT, but got I4
		//IL_07a2: Expected Obj, but got I
		//IL_07b2: Expected Obj, but got I
		//IL_0488: Expected Obj, but got I4
		//IL_05eb: Expected native int or pointer, but got VT
		//IL_05f8: Expected native int or pointer, but got VT
		//IL_060a: Expected I, but got Obj
		//IL_0613: Expected VT, but got I4
		//IL_0505: Expected Obj, but got I
		//IL_050e: Expected VT, but got Obj
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected I4, but got Unknown
		//IL_0549: Expected Obj, but got I4
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected I4, but got Unknown
		//IL_0598: Expected VT, but got I4
		//IL_0598: Expected VT, but got I4
		//IL_05c4: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		RpcInfo rpcInfo = info;
		RpcChannel rpcChannel = (RpcChannel)0;
		object obj;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		object obj4 = default;
		PlayerRef playerRef2;
		RpcInvokeInfo rpcInvokeInfo2;
		int num;
		RpcInfo rpcInfo2;
		NullReferenceException ex;
		object obj10;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			object obj2 = obj;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj3 = !flag3;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				Fusion.RpcBuilder rpcBuilder2 = networkRunner.CreateRpcBuilder(485164785u, bytePayloadSize, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				obj4 = rpcInvokeInfo >> 32;
				object obj5 = obj4 - 522;
				bool flag4 = (nint)obj5 < 2;
				object obj6 = !flag4;
				object obj7 = ~obj6;
				PlayerRef playerRef;
				PlayerRef playerRef3;
				if (obj7 == null && (nint)obj4 != 518)
				{
					bool flag5 = (nint)obj4 != 524;
					playerRef = (PlayerRef)0;
					playerRef2 = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					playerRef3 = invalid;
					if (flag5)
					{
						goto IL_037c;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag6 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						playerRef = (PlayerRef)0;
						playerRef2 = (PlayerRef)this;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						playerRef3 = invalid;
						if (flag6)
						{
							goto IL_037c;
						}
					}
				}
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v60+E4]");
				bool flag7 = (nint)0 == 0;
				object obj9 = !flag7;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0630]");
				object rpc = 0;
				playerRef2 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef2);
				playerRef = (PlayerRef)0;
				rpcInvokeInfo2 = rpcInvokeInfo;
				playerRef3 = none;
				goto IL_037c;
			}
			ex = new NullReferenceException();
			rpcInfo2 = info;
			obj10 = 0;
			num = bytePayloadSize;
			goto IL_0648;
		}
		goto IL_0005;
		IL_081a:
		nint num2 = default;
		bool flag8 = num2 == 0;
		object obj11 = !flag8;
		object obj12;
		Fusion.RpcBuilder rpcBuilder4 = default;
		nint num4;
		if (obj11 == null)
		{
			if ((nint)obj12 != 7)
			{
				bool flag9 = obj12 == null;
				object obj13 = !flag9;
				if (obj13 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v12+E4]");
			bool flag10 = (nint)0 == 0;
			object obj16 = !flag10;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v12+A0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v7+18]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0628]");
				object obj19 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj19);
				object obj20 = obj;
				int num3 = num | obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v12+E4]");
				bool flag11 = (nint)0 == 0;
				object obj21 = !flag11;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(networkRunner & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num3, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ X27_v3+18] (should have been resolved before IL gen)");
				IntPtr intPtr = default;
				num2 = intPtr;
				PlayerRef playerRef = invalid2;
				PlayerRef playerRef3 = (PlayerRef)0;
			}
			if (num != 0)
			{
				return;
			}
			RpcInfo rpcInfo3 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			System.Runtime.CompilerServices.Unsafe.Write(&((RpcInfo*)(nint)info)->Tick, (Tick)rpcBuilder4);
			((RpcInfo*)(nint)info)->_validationResult = num2;
			rpcBuilder = rpcBuilder4;
			num4 = unchecked((nint)null);
			rpcInfo = (RpcInfo)0;
			rpcChannel = (RpcChannel)0;
			goto IL_0005;
		}
		goto IL_0648;
		IL_07f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_037c:
		object obj22 = rpcInvokeInfo >> 32;
		bool flag12 = obj22 == null;
		object obj23 = !flag12;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj24 = 0;
			playerRef2 = (PlayerRef)obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			int num5 = rpcBuilder3.Send();
			rpcInvokeInfo2 = (RpcInvokeInfo)1;
		}
		rpcBuilder3.Dispose();
		num2 = 0;
		object obj25 = 0;
		rpcBuilder4 = (Fusion.RpcBuilder)(&rpcBuilder3);
		num4 = (nint)playerRef2;
		rpcInfo2 = (RpcInfo)rpcInvokeInfo2;
		networkRunner = (NetworkRunner)(&writer);
		obj10 = 0;
		ex = (NullReferenceException)(&rpcBuilder3);
		obj12 = 7;
		num = (int)rpcInvokeInfo;
		goto IL_081a;
		IL_0648:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj26;
		OutOfMemoryException ex2;
		if ((nint)obj10 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj26 = obj25;
			num2 = 1;
		}
		else
		{
			bool flag13 = (nint)obj10 != 1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag13)
			{
				goto IL_07f7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj27 = default;
			obj26 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj25 = obj27;
		}
		((Fusion.RpcBuilder*)rpcBuilder4)->Dispose();
		bool flag14 = obj26 == null;
		object obj28 = !flag14;
		if (obj28 == null)
		{
			obj10 = 0;
			ex = (NullReferenceException)rpcBuilder4;
			obj12 = 0;
			goto IL_081a;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		obj10 = 0;
		goto IL_07f7;
		IL_0005:
		int num6 = part & 0xFF;
		bool flag15 = num6 < 2;
		object obj29 = !flag15;
		object obj30 = num6 - 2;
		bool flag16 = obj30 == null;
		object obj31 = !flag16;
		object obj32 = obj29 & obj31;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj33 = 0;
			object obj34 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v69+E4]");
			bool flag17 = (nint)0 == 0;
			object obj35 = !flag17;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (NetworkApe.InBudget(info.Source))
			{
				Torn((ApePart)num6);
			}
		}
	}

	public unsafe void RPC_Rip(PlayerRef by, byte seed, NetworkBool plusInRight, Quaternion rotRight, Quaternion rotLeft, RpcInfo info = default(RpcInfo))
	{
		//IL_0a5d: Expected VT, but got I4
		//IL_01d4: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0258: Expected Obj, but got I4
		//IL_0066: Expected VT, but got I4
		//IL_088f: Expected Obj, but got I4
		//IL_08b0: Expected VT, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_02a8: Expected Obj, but got I4
		//IL_02b5: Expected Obj, but got I4
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected I4, but got Unknown
		//IL_02ea: Expected I4, but got I8
		//IL_00d8: Expected VT, but got I4
		//IL_031c: Expected Obj, but got VT
		//IL_032c: Expected Obj, but got I
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0354: Expected Obj, but got I4
		//IL_044d: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I4
		//IL_0483: Expected Obj, but got I
		//IL_0495: Expected VT, but got I8
		//IL_04b0: Expected VT, but got I4
		//IL_014e: Expected VT, but got F4
		//IL_04d3: Expected Obj, but got VT
		//IL_04ed: Expected Obj, but got I4
		//IL_04f5: Expected I4, but got VT
		//IL_0516: Expected VT, but got I4
		//IL_08fb: Expected Obj, but got I4
		//IL_090c: Expected Obj, but got I4
		//IL_0629: Expected Obj, but got I4
		//IL_0632: Expected Obj, but got I4
		//IL_063a: Expected VT, but got Ref
		//IL_0663: Expected Obj, but got I4
		//IL_066b: Expected Obj, but got Ref
		//IL_0674: Expected Obj, but got I4
		//IL_067c: Expected I4, but got VT
		//IL_03a3: Expected VT, but got I4
		//IL_03b4: Expected VT, but got I4
		//IL_03b9: Expected VT, but got Obj
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected VT, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected VT, but got Unknown
		//IL_0963: Expected Ref, but got VT
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected VT, but got Unknown
		//IL_0559: Expected Obj, but got I
		//IL_0578: Expected Obj, but got I
		//IL_0580: Expected VT, but got Obj
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected VT, but got Unknown
		//IL_05b4: Expected Obj, but got I
		//IL_05c6: Expected I4, but got Obj
		//IL_05c6: Expected VT, but got I4
		//IL_03d0: Invalid comparison between VT and I4
		//IL_09d9: Expected Obj, but got I4
		//IL_099b: Expected Obj, but got I
		//IL_09a4: Expected Obj, but got I4
		//IL_09ac: Expected Obj, but got VT
		//IL_09b5: Expected Obj, but got I4
		//IL_05d3: Expected I4, but got Obj
		//IL_05e5: Expected I4, but got Obj
		//IL_05e5: Expected VT, but got I4
		//IL_06d6: Expected Obj, but got I
		//IL_0700: Expected Obj, but got I4
		//IL_03ed: Invalid comparison between VT and I4
		//IL_03ff: Expected VT, but got I4
		//IL_0410: Expected VT, but got I4
		//IL_0415: Expected VT, but got Obj
		//IL_0a7b: Expected Obj, but got I
		//IL_0a8b: Expected Obj, but got I
		//IL_06b8: Expected Obj, but got I4
		//IL_0828: Expected F4, but got VT
		//IL_0823: Expected native int or pointer, but got VT
		//IL_083f: Expected VT, but got I4
		//IL_0735: Expected Obj, but got I
		//IL_073e: Expected VT, but got Obj
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected I4, but got Unknown
		//IL_0779: Expected Obj, but got I4
		//IL_07b1: Expected I4, but got I8
		//IL_07c8: Expected VT, but got I4
		//IL_07c8: Expected VT, but got I4
		//IL_07f4: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		Quaternion rotRight2 = rotRight;
		byte b = seed;
		NetworkBool networkBool = plusInRight;
		RpcChannel rpcChannel = (RpcChannel)0;
		object obj2 = default;
		object obj = obj2;
		object obj4 = default;
		object obj3 = obj4;
		object obj6 = default;
		object obj5 = obj6;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		object obj13;
		Quaternion rotLeft2 = default;
		PlayerRef playerRef;
		RpcInvokeInfo rpcInvokeInfo2;
		PlayerRef playerRef2;
		int num;
		object obj19;
		int num2;
		object obj20;
		Fusion.RpcBuilder rpcBuilder4;
		byte b2;
		NetworkBool networkBool2;
		object obj8;
		NullReferenceException ex;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj7 = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			int bytePayloadSize3 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			int bytePayloadSize4 = Fusion.RpcDataWriter.GetBytePayloadSize(16);
			int bytePayloadSize5 = Fusion.RpcDataWriter.GetBytePayloadSize(16);
			obj8 = obj7;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v18+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				object obj10 = bytePayloadSize2 + bytePayloadSize;
				object obj11 = bytePayloadSize3 + bytePayloadSize4;
				object obj12 = obj10 + obj11;
				int payloadByteCount = obj12 + bytePayloadSize5;
				Fusion.RpcBuilder rpcBuilder2 = networkRunner.CreateRpcBuilder(3089612098u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				networkRunner = (NetworkRunner)(rpcInvokeInfo >> 32);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				obj13 = 0;
				object obj14 = networkRunner - 522;
				bool flag4 = (nint)obj14 < 2;
				object obj15 = !flag4;
				object obj16 = ~obj15;
				if (obj16 == null && (nint)networkRunner != 518)
				{
					bool flag5 = (nint)networkRunner != 524;
					rotLeft2 = (Quaternion)0;
					playerRef = invalid;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					playerRef2 = (PlayerRef)this;
					if (flag5)
					{
						goto IL_04c5;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag6 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						rotLeft2 = (Quaternion)0;
						playerRef = invalid;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						playerRef2 = (PlayerRef)this;
						if (flag6)
						{
							goto IL_04c5;
						}
					}
				}
				object obj17 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v73+E4]");
				bool flag7 = (nint)0 == 0;
				object obj18 = !flag7;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0640]");
				object rpc = 0;
				playerRef2 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef2);
				rotLeft2 = (Quaternion)0;
				playerRef = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_04c5;
			}
			ex = new NullReferenceException();
			rotRight2 = rotRight;
			num = bytePayloadSize2;
			b2 = seed;
			networkBool2 = plusInRight;
			obj19 = 0;
			obj = obj2;
			obj3 = obj4;
			obj20 = obj6;
			rpcBuilder4 = (Fusion.RpcBuilder)0;
			num2 = bytePayloadSize;
			goto IL_08bd;
		}
		goto IL_0005;
		IL_04c5:
		object obj21 = rpcInvokeInfo >> 32;
		bool flag8 = obj21 == null;
		object obj22 = !flag8;
		int num3 = (int)rpcInvokeInfo2;
		obj = obj2;
		obj3 = obj4;
		obj20 = obj6;
		rpcBuilder4 = (Fusion.RpcBuilder)0;
		if (obj22 == null)
		{
			PlayerRef value = (PlayerRef)(by & 0xFFFFFFFFL);
			writer.Write(value, 4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E00]");
			object obj24 = 0;
			playerRef2 = (PlayerRef)obj24;
			NetworkBool value2 = (NetworkBool)(plusInRight & 0xFFFFFFFFL);
			writer.Write(value2, 4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD898]");
			object obj25 = 0;
			writer.Write((Quaternion)16, (int)obj25);
			num3 = (int)obj25;
			writer.Write((Quaternion)16, (int)obj25);
			int num4 = rpcBuilder3.Send();
			object obj26 = default;
			obj = obj26;
			object obj27 = default;
			obj3 = obj27;
			object obj28 = default;
			obj20 = obj28;
			Fusion.RpcBuilder rpcBuilder5 = default;
			rpcBuilder4 = rpcBuilder5;
		}
		rpcBuilder3.Dispose();
		object obj29 = 0;
		object obj30 = 0;
		Fusion.RpcBuilder rpcBuilder6 = (Fusion.RpcBuilder)(&rpcBuilder3);
		rotRight2 = (Quaternion)playerRef;
		num = (int)(&writer);
		b2 = (byte)num3;
		networkBool2 = (NetworkBool)playerRef2;
		obj19 = 0;
		ex = (NullReferenceException)(&rpcBuilder3);
		obj8 = 7;
		num2 = (int)rpcInvokeInfo;
		goto IL_0ad3;
		IL_08bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		OutOfMemoryException ex3 = default;
		OutOfMemoryException ex2 = ex3;
		object obj32 = default;
		OutOfMemoryException ex5 = default;
		while (true)
		{
			object obj31;
			if ((nint)obj19 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj29 = 1;
				obj31 = obj30;
				obj8 = 1;
			}
			else
			{
				if ((nint)obj19 != 1)
				{
					goto IL_0ab0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj31 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj30 = obj32;
			}
			((Fusion.RpcBuilder*)rpcBuilder6)->Dispose();
			if (obj31 == null)
			{
				break;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			ex2 = ex4;
			obj19 = 0;
			goto IL_0ab0;
			IL_0ab0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			ex2 = ex5;
			num = 0;
			networkRunner = null;
			num2 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		obj13 = 0;
		obj19 = 0;
		ex = (NullReferenceException)rpcBuilder6;
		obj8 = 0;
		goto IL_0ad3;
		IL_0ad3:
		if (obj29 == null)
		{
			if ((nint)obj8 != 7)
			{
				bool flag9 = obj8 == null;
				object obj33 = !flag9;
				if (obj33 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj34 = 0;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X0_v20+E4]");
			bool flag10 = (nint)0 == 0;
			object obj36 = !flag10;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj35 = obj34;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X0_v20+A0]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X8_v7+18]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0638]");
				object obj39 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj39);
				object obj40 = obj13;
				int num5 = num2 | networkRunner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v12+E4]");
				bool flag11 = (nint)0 == 0;
				object obj41 = !flag11;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(num & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num5, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ X28_v4+18] (should have been resolved before IL gen)");
				object obj42 = default;
				obj29 = obj42;
				rotLeft2 = (Quaternion)invalid2;
				rotRight2 = (Quaternion)0;
				object obj43 = default;
				obj3 = obj43;
			}
			if (num2 != 0)
			{
				return;
			}
			RpcInfo rpcInfo = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			((Quaternion*)(nint)rotRight)->x = (float)rpcBuilder6;
			b = 0;
			networkBool = (NetworkBool)0;
			rpcChannel = (RpcChannel)0;
			obj5 = obj29;
			rpcBuilder = rpcBuilder6;
			goto IL_0005;
		}
		goto IL_08bd;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj44 = 0;
		object obj45 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v82+E4]");
		bool flag12 = (nint)0 == 0;
		object obj46 = !flag12;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkApe.Sane((Quaternion)0))
		{
			return;
		}
		object obj47 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v86+E4]");
		bool flag13 = (nint)0 == 0;
		object obj48 = !flag13;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (NetworkApe.Sane((Quaternion)0))
		{
			object obj49 = obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v90+E4]");
			bool flag14 = (nint)0 == 0;
			object obj50 = !flag14;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (NetworkApe.InBudget((PlayerRef)rotRight.y))
			{
				NetworkBool networkBool3 = (NetworkBool)(plusInRight & 0xFFFFFFFFL);
				bool plusInRight2 = networkBool3;
				PlayerRef playerRef3 = (PlayerRef)(by & 0xFFFFFFFFL);
				Ripped(playerRef3, seed, plusInRight2, rotRight2, rotLeft2);
			}
		}
	}

	public unsafe void RPC_Blasted(Vector3 velocity, byte torn, NetworkBool apart, byte seed, RpcInfo info = default(RpcInfo))
	{
		//IL_094e: Expected VT, but got I4
		//IL_017b: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got I4
		//IL_0066: Expected VT, but got I4
		//IL_07a0: Expected Obj, but got I4
		//IL_07b9: Expected VT, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I4
		//IL_025b: Expected I4, but got Obj
		//IL_0276: Expected I4, but got I8
		//IL_00df: Expected VT, but got I
		//IL_02a8: Expected Obj, but got VT
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_02d0: Expected Obj, but got I4
		//IL_03c9: Expected Obj, but got I4
		//IL_03ff: Expected Obj, but got I
		//IL_0411: Expected VT, but got I8
		//IL_042c: Expected VT, but got I4
		//IL_0969: Expected Obj, but got VT
		//IL_044f: Expected Obj, but got VT
		//IL_0469: Expected Obj, but got I4
		//IL_0472: Expected VT, but got I4
		//IL_0a7f: Expected VT, but got I8
		//IL_0aa2: Expected I4, but got VT
		//IL_0804: Expected Obj, but got I4
		//IL_0815: Expected Obj, but got I4
		//IL_0532: Expected Obj, but got I4
		//IL_053b: Expected Obj, but got I4
		//IL_0543: Expected VT, but got Ref
		//IL_054b: Expected I4, but got VT
		//IL_0563: Expected I4, but got VT
		//IL_056c: Expected Obj, but got I4
		//IL_0584: Expected Obj, but got Ref
		//IL_058d: Expected Obj, but got I4
		//IL_0595: Expected I4, but got VT
		//IL_031f: Expected VT, but got I4
		//IL_032c: Expected VT, but got Obj
		//IL_0335: Expected VT, but got I4
		//IL_0115: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I4
		//IL_086c: Expected Ref, but got VT
		//IL_0490: Expected Obj, but got I
		//IL_04a2: Expected I4, but got Obj
		//IL_04a2: Expected VT, but got I4
		//IL_04b2: Expected Obj, but got I
		//IL_04d4: Expected VT, but got I8
		//IL_04ee: Expected VT, but got Obj
		//IL_034c: Invalid comparison between VT and I4
		//IL_08d2: Expected Obj, but got I4
		//IL_089d: Expected Obj, but got I4
		//IL_08a5: Expected Obj, but got VT
		//IL_08ae: Expected Obj, but got I4
		//IL_0513: Expected VT, but got I4
		//IL_05ef: Expected Obj, but got I
		//IL_0619: Expected Obj, but got I4
		//IL_0369: Invalid comparison between VT and I4
		//IL_037b: Expected VT, but got I4
		//IL_0388: Expected VT, but got Obj
		//IL_0391: Expected VT, but got I4
		//IL_09cd: Expected Obj, but got I
		//IL_09dd: Expected Obj, but got I
		//IL_05d1: Expected Obj, but got I4
		//IL_0747: Expected VT, but got I4
		//IL_064e: Expected Obj, but got I
		//IL_0657: Expected VT, but got Obj
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Expected I4, but got Unknown
		//IL_0692: Expected Obj, but got I4
		//IL_06ca: Expected I4, but got I8
		//IL_06e1: Expected VT, but got I4
		//IL_06e1: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		byte seed2 = seed;
		NetworkBool networkBool = apart;
		byte b = torn;
		RpcChannel rpcChannel = (RpcChannel)0;
		object obj2 = default;
		object obj = obj2;
		object obj4 = default;
		object obj3 = obj4;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		object obj5;
		NetworkRunner networkRunner;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		PlayerRef playerRef;
		PlayerRef playerRef2;
		RpcInvokeInfo rpcInvokeInfo2;
		int num;
		object obj15;
		int num2;
		Fusion.RpcBuilder rpcBuilder4;
		NetworkBool networkBool2;
		byte b2;
		object obj16;
		object obj6;
		NullReferenceException ex;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj5 = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			int bytePayloadSize3 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			int bytePayloadSize4 = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			obj6 = obj5;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v18+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)networkRunner != null)
			{
				object obj8 = bytePayloadSize2 + bytePayloadSize;
				object obj9 = bytePayloadSize3 + bytePayloadSize4;
				int payloadByteCount = (int)(obj8 + obj9);
				Fusion.RpcBuilder rpcBuilder2 = networkRunner.CreateRpcBuilder(2153976918u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				networkRunner = (NetworkRunner)(rpcInvokeInfo >> 32);
				object obj10 = networkRunner - 522;
				bool flag4 = (nint)obj10 < 2;
				object obj11 = !flag4;
				object obj12 = ~obj11;
				RpcInfo rpcInfo;
				if (obj12 == null && (nint)networkRunner != 518)
				{
					bool flag5 = (nint)networkRunner != 524;
					rpcInfo = (RpcInfo)0;
					playerRef = invalid;
					playerRef2 = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag5)
					{
						goto IL_0441;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag6 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						rpcInfo = (RpcInfo)0;
						playerRef = invalid;
						playerRef2 = (PlayerRef)this;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag6)
						{
							goto IL_0441;
						}
					}
				}
				object obj13 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v70+E4]");
				bool flag7 = (nint)0 == 0;
				object obj14 = !flag7;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0650]");
				object rpc = 0;
				playerRef2 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef2);
				rpcInfo = (RpcInfo)0;
				playerRef = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_0441;
			}
			ex = new NullReferenceException();
			seed2 = seed;
			num = bytePayloadSize2;
			networkBool2 = apart;
			b2 = torn;
			obj15 = 0;
			obj = obj2;
			obj16 = obj4;
			rpcBuilder4 = (Fusion.RpcBuilder)0;
			num2 = bytePayloadSize;
			goto IL_07c6;
		}
		goto IL_0005;
		IL_0441:
		object obj17 = rpcInvokeInfo >> 32;
		bool flag8 = obj17 == null;
		object obj18 = !flag8;
		rpcBuilder4 = (Fusion.RpcBuilder)0;
		Fusion.RpcBuilder rpcBuilder5 = default;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj19 = 0;
			writer.Write((Vector3)12, (int)obj19);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			NetworkBool value = (NetworkBool)((int)torn & 0xFFFFFFFFL);
			writer.Write(value, 4);
			playerRef2 = (PlayerRef)obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			int num3 = rpcBuilder3.Send();
			rpcInvokeInfo2 = (RpcInvokeInfo)1;
			rpcBuilder4 = rpcBuilder5;
		}
		rpcBuilder3.Dispose();
		object obj21 = 0;
		object obj22 = 0;
		Fusion.RpcBuilder rpcBuilder6 = (Fusion.RpcBuilder)(&rpcBuilder3);
		seed2 = (byte)(int)playerRef;
		num = (int)(&writer);
		networkBool2 = (NetworkBool)playerRef2;
		b2 = (byte)(int)rpcInvokeInfo2;
		obj15 = 0;
		obj = obj2;
		obj16 = obj4;
		ex = (NullReferenceException)(&rpcBuilder3);
		obj6 = 7;
		num2 = (int)rpcInvokeInfo;
		goto IL_0a25;
		IL_07c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		OutOfMemoryException ex3 = default;
		OutOfMemoryException ex2 = ex3;
		object obj24 = default;
		OutOfMemoryException ex5 = default;
		while (true)
		{
			object obj23;
			if ((nint)obj15 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj21 = 1;
				obj23 = obj22;
				obj6 = 1;
			}
			else
			{
				if ((nint)obj15 != 1)
				{
					goto IL_0a02;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj23 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj22 = obj24;
			}
			((Fusion.RpcBuilder*)rpcBuilder6)->Dispose();
			if (obj23 == null)
			{
				break;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			ex2 = ex4;
			obj15 = 0;
			goto IL_0a02;
			IL_0a02:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			networkRunner = null;
			ex2 = ex5;
			num = 0;
			num2 = 0;
		}
		obj15 = 0;
		ex = (NullReferenceException)rpcBuilder6;
		obj6 = 0;
		goto IL_0a25;
		IL_0a25:
		if (obj21 == null)
		{
			if ((nint)obj6 != 7)
			{
				bool flag9 = obj6 == null;
				object obj25 = !flag9;
				if (obj25 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj26 = 0;
			object obj27 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v18+E4]");
			bool flag10 = (nint)0 == 0;
			object obj28 = !flag10;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj27 = obj26;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v18+A0]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v7+18]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0648]");
				object obj31 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj31);
				object obj32 = obj5;
				int num4 = num2 | networkRunner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v12+E4]");
				bool flag11 = (nint)0 == 0;
				object obj33 = !flag11;
				if (obj33 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(num & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num4, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v149 @ X28_v4+18] (should have been resolved before IL gen)");
				object obj34 = default;
				obj21 = obj34;
				RpcInfo rpcInfo = (RpcInfo)invalid2;
				seed2 = 0;
				object obj35 = default;
				obj = obj35;
			}
			if (num2 != 0)
			{
				return;
			}
			RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			networkBool = (NetworkBool)0;
			b = 0;
			rpcChannel = (RpcChannel)0;
			obj3 = obj21;
			rpcBuilder = rpcBuilder6;
			goto IL_0005;
		}
		goto IL_07c6;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj36 = 0;
		object obj37 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v79+E4]");
		bool flag12 = (nint)0 == 0;
		object obj38 = !flag12;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkApe.Sane((Vector3)0))
		{
			return;
		}
		object obj39 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v83+E4]");
		bool flag13 = (nint)0 == 0;
		object obj40 = !flag13;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [seed @ X4 (System.Byte)+4]");
		if (!NetworkApe.InBudget((PlayerRef)0))
		{
			return;
		}
		object obj41 = rpcBuilder5 * rpcBuilder5;
		object obj42 = obj4 * obj4;
		object obj43 = obj41 + obj42;
		object obj44 = obj2 * obj2;
		object obj45 = obj44 + obj43;
		if ((nint)obj45 > 1147207680)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj46 = 0;
			object obj47 = obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v92+E4]");
			bool flag14 = (nint)0 == 0;
			object obj48 = !flag14;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		}
		NetworkBool networkBool3 = (NetworkBool)((int)torn & 0xFFFFFFFFL);
		bool torn2 = networkBool3;
		Blown(velocity, torn2 ? ((byte)1) : ((byte)0), (byte)(int)apart != 0, seed2);
	}

	public unsafe void RPC_Eaten(NetworkId monster, RpcInfo info = default(RpcInfo))
	{
		//IL_094e: Expected VT, but got I4
		//IL_02a4: Expected Obj, but got I
		//IL_02ba: Expected I, but got Obj
		//IL_02e6: Expected Obj, but got I4
		//IL_0324: Expected VT, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0398: Expected Obj, but got VT
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Obj, but got Unknown
		//IL_03c0: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I4
		//IL_0497: Expected I, but got Obj
		//IL_04b9: Expected Obj, but got I4
		//IL_010f: Expected VT, but got I4
		//IL_0118: Expected VT, but got I4
		//IL_0121: Expected VT, but got I4
		//IL_04ef: Expected Obj, but got I
		//IL_0501: Expected VT, but got I8
		//IL_051c: Expected VT, but got I4
		//IL_09a4: Expected Obj, but got I4
		//IL_053f: Expected Obj, but got VT
		//IL_0559: Expected Obj, but got I4
		//IL_0561: Expected I4, but got VT
		//IL_01b9: Expected Obj, but got VT
		//IL_01da: Expected VT, but got I4
		//IL_0149: Expected VT, but got I4
		//IL_0157: Expected VT, but got I4
		//IL_05d8: Expected VT, but got I4
		//IL_05ea: Expected Obj, but got I4
		//IL_05f2: Expected VT, but got Ref
		//IL_05fa: Expected I, but got VT
		//IL_0602: Expected Obj, but got Ref
		//IL_060a: Expected VT, but got I4
		//IL_0617: Expected Obj, but got Ref
		//IL_0620: Expected Obj, but got I4
		//IL_0638: Expected I4, but got VT
		//IL_040f: Expected VT, but got I4
		//IL_0414: Expected VT, but got Obj
		//IL_0425: Expected VT, but got I4
		//IL_09e1: Expected Obj, but got I4
		//IL_08c0: Expected Ref, but got VT
		//IL_08da: Expected Obj, but got I4
		//IL_0a91: Expected Obj, but got I4
		//IL_057f: Expected Obj, but got I
		//IL_0587: Expected VT, but got Obj
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected VT, but got Unknown
		//IL_0264: Expected Obj, but got VT
		//IL_01f1: Invalid comparison between VT and I4
		//IL_0200: Expected VT, but got I4
		//IL_020e: Expected VT, but got I4
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected VT, but got Unknown
		//IL_0193: Expected VT, but got I4
		//IL_019b: Expected VT, but got Obj
		//IL_043c: Invalid comparison between VT and I4
		//IL_08fd: Expected Obj, but got VT
		//IL_0906: Expected Obj, but got I4
		//IL_028f: Expected Obj, but got VT
		//IL_022c: Expected Obj, but got I
		//IL_0692: Expected Obj, but got I
		//IL_06bc: Expected Obj, but got I4
		//IL_0459: Invalid comparison between VT and I4
		//IL_046b: Expected VT, but got I4
		//IL_0470: Expected VT, but got Obj
		//IL_0481: Expected VT, but got I4
		//IL_09ff: Expected Obj, but got I
		//IL_0a0f: Expected Obj, but got I
		//IL_0674: Expected Obj, but got I4
		//IL_07df: Expected native int or pointer, but got VT
		//IL_07ec: Expected native int or pointer, but got VT
		//IL_07fe: Expected I, but got Obj
		//IL_0807: Expected VT, but got I4
		//IL_06f1: Expected Obj, but got I
		//IL_06fa: Expected VT, but got Obj
		//IL_0706: Expected I, but got Obj
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected I4, but got Unknown
		//IL_0735: Expected Obj, but got I4
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Expected I4, but got Unknown
		//IL_0784: Expected VT, but got I4
		//IL_0784: Expected VT, but got I4
		//IL_07b0: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		RpcChannel rpcChannel = (RpcChannel)0;
		NetworkId networkId = monster;
		RpcInfo rpcInfo2 = default;
		RpcInfo rpcInfo = rpcInfo2;
		MethodBase methodBase = default;
		NetworkRunner networkRunner = default;
		int num2;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		object obj3 = default;
		PlayerRef playerRef2;
		RpcInvokeInfo rpcInvokeInfo2;
		UnityEngine.Object obj2;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			methodBase = (MethodBase)0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			nint num = (nint)methodBase;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v20 (Il2CppClass<System.Reflection.MethodBase>)+E4]");
			bool flag3 = (nint)0 == 0;
			object obj = !flag3;
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			bool flag4 = (object)networkRunner == null;
			rpcBuilder = (Fusion.RpcBuilder)0;
			obj2 = null;
			networkId = monster;
			rpcInfo = rpcInfo2;
			num2 = bytePayloadSize;
			if (!flag4)
			{
				Fusion.RpcBuilder rpcBuilder2 = networkRunner.CreateRpcBuilder(524838844u, bytePayloadSize, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				obj3 = rpcInvokeInfo >> 32;
				object obj4 = obj3 - 522;
				bool flag5 = (nint)obj4 < 2;
				object obj5 = !flag5;
				object obj6 = ~obj5;
				PlayerRef playerRef;
				PlayerRef playerRef3;
				if (obj6 == null && (nint)obj3 != 518)
				{
					bool flag6 = (nint)obj3 != 524;
					playerRef = (PlayerRef)0;
					playerRef2 = (PlayerRef)this;
					playerRef3 = invalid;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag6)
					{
						goto IL_0531;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag7 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						playerRef = (PlayerRef)0;
						playerRef2 = (PlayerRef)this;
						playerRef3 = invalid;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag7)
						{
							goto IL_0531;
						}
					}
				}
				nint num3 = (nint)methodBase;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v61 (Il2CppClass<System.Reflection.MethodBase>)+E4]");
				bool flag8 = (nint)0 == 0;
				object obj7 = !flag8;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D06C0]");
				object rpc = 0;
				playerRef2 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef2);
				playerRef = (PlayerRef)0;
				playerRef3 = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_0531;
			}
			goto IL_0815;
		}
		goto IL_0005;
		IL_0823:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj8;
		object obj9 = default;
		nint num4 = default;
		OutOfMemoryException ex;
		if ((nint)obj2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj8 = obj9;
			num4 = 1;
		}
		else
		{
			bool flag9 = (nint)obj2 != 1;
			OutOfMemoryException ex2 = default;
			ex = ex2;
			if (flag9)
			{
				goto IL_0a54;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj10 = default;
			obj8 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj9 = obj10;
		}
		Fusion.RpcBuilder rpcBuilder4 = default;
		((Fusion.RpcBuilder*)rpcBuilder4)->Dispose();
		bool flag10 = obj8 == null;
		object obj11 = !flag10;
		RpcInfo rpcInfo3;
		object obj12;
		NullReferenceException ex3;
		if (obj11 == null)
		{
			rpcInfo3 = rpcInfo2;
			obj2 = null;
			ex3 = (NullReferenceException)rpcBuilder4;
			obj12 = 0;
			goto IL_0a77;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex = ex4;
		obj2 = null;
		goto IL_0a54;
		IL_0815:
		ex3 = new NullReferenceException();
		goto IL_0823;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v70+E4]");
		bool flag11 = (nint)0 == 0;
		object obj15 = !flag11;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkApe.InBudget(rpcInfo.Source))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		num2 = 0;
		int value = ((int*)num2)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v74 (System.Int32)+E4]");
		bool flag12 = (nint)0 == 0;
		object obj16 = !flag12;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag13 = (UnityEngine.Object)((SimulationBehaviour)this)._runner != (UnityEngine.Object)null;
		bool flag14 = !flag13;
		RpcInfo rpcInfo4 = (RpcInfo)0;
		NetworkId networkId2 = (NetworkId)0;
		rpcInfo = (RpcInfo)0;
		if (!flag14)
		{
			bool flag15 = (object)((SimulationBehaviour)this)._runner == null;
			rpcInfo2 = (RpcInfo)0;
			obj2 = null;
			rpcInfo = (RpcInfo)0;
			if (flag15)
			{
				goto IL_0815;
			}
			networkId2 = (NetworkId)(networkId & 0xFFFFFFFFL);
			NetworkObject networkObject = ((SimulationBehaviour)this)._runner.FindObject(networkId2);
			rpcInfo4 = (RpcInfo)0;
			rpcInfo = (RpcInfo)networkObject;
		}
		int value2 = ((int*)num2)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v79 (System.Int32)+E4]");
		bool flag16 = (nint)0 == 0;
		object obj17 = !flag16;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17 = (UnityEngine.Object)rpcInfo != null;
		bool flag18 = !flag17;
		UnityEngine.Object obj18 = null;
		NetworkId networkId3 = (NetworkId)0;
		if (!flag18)
		{
			bool flag19 = rpcInfo == (RpcInfo)(object)0;
			rpcInfo2 = (RpcInfo)0;
			obj2 = null;
			networkId = (NetworkId)0;
			if (flag19)
			{
				goto IL_0815;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF0]");
			object obj19 = 0;
			obj18 = (UnityEngine.Object)obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			NetworkId networkId4 = default;
			networkId3 = networkId4;
		}
		int value3 = ((int*)num2)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v84 (System.Int32)+E4]");
		bool flag20 = (nint)0 == 0;
		object obj20 = !flag20;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)networkId3 != null)
		{
			EatenBy((MonsterBrain)networkId3);
		}
		return;
		IL_0a77:
		bool flag21 = num4 == 0;
		object obj21 = !flag21;
		rpcInfo2 = rpcInfo3;
		nint num7;
		if (obj21 == null)
		{
			if ((nint)obj12 != 12)
			{
				bool flag22 = obj12 == null;
				object obj22 = !flag22;
				if (obj22 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj23 = 0;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v6+E4]");
			bool flag23 = (nint)0 == 0;
			object obj25 = !flag23;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj24 = obj23;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v6+A0]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X8_v5+18]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X8_v5+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D06B8]");
				object obj28 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj28);
				nint num5 = (nint)methodBase;
				int num6 = num2 | obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X8_v10 (Il2CppClass<System.Reflection.MethodBase>)+E4]");
				bool flag24 = (nint)0 == 0;
				object obj29 = !flag24;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(networkRunner & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num6, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v214 @ X27_v1+18] (should have been resolved before IL gen)");
				IntPtr intPtr = default;
				num4 = intPtr;
				PlayerRef playerRef = invalid2;
				PlayerRef playerRef3 = (PlayerRef)0;
				methodBase = methodFromHandle;
			}
			if (num2 != 0)
			{
				return;
			}
			RpcInfo rpcInfo5 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			System.Runtime.CompilerServices.Unsafe.Write(&((RpcInfo*)(nint)rpcInfo)->Tick, (Tick)rpcBuilder4);
			((RpcInfo*)(nint)rpcInfo)->_validationResult = num4;
			rpcBuilder = rpcBuilder4;
			num7 = unchecked((nint)null);
			rpcInfo2 = (RpcInfo)0;
			rpcChannel = (RpcChannel)0;
			goto IL_0005;
		}
		goto IL_0823;
		IL_0531:
		object obj30 = rpcInvokeInfo >> 32;
		bool flag25 = obj30 == null;
		object obj31 = !flag25;
		int num8 = (int)rpcInvokeInfo2;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D58]");
			object obj32 = 0;
			playerRef2 = (PlayerRef)obj32;
			NetworkId value4 = (NetworkId)(monster & 0xFFFFFFFFL);
			writer.Write(value4, 4);
			int num9 = rpcBuilder3.Send();
			num8 = 4;
		}
		rpcBuilder3.Dispose();
		rpcBuilder = (Fusion.RpcBuilder)0;
		num4 = 0;
		obj9 = 0;
		rpcBuilder4 = (Fusion.RpcBuilder)(&rpcBuilder3);
		num7 = (nint)playerRef2;
		networkRunner = (NetworkRunner)(&writer);
		rpcInfo3 = (RpcInfo)num8;
		obj2 = null;
		ex3 = (NullReferenceException)(&rpcBuilder3);
		obj12 = 12;
		networkId = monster;
		rpcInfo = rpcInfo2;
		num2 = (int)rpcInvokeInfo;
		goto IL_0a77;
		IL_0a54:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	public unsafe void RPC_SawBite(byte section, byte slot, Vector3 normal, float off, Vector3 middle, Vector3 way, Vector3 half, RpcInfo info = default(RpcInfo))
	{
		//IL_0f27: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I4
		//IL_006f: Expected VT, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I4
		//IL_05e8: Expected Obj, but got I4
		//IL_068f: Expected Obj, but got I4
		//IL_069c: Expected Obj, but got I4
		//IL_06a9: Expected Obj, but got I4
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected Obj, but got Unknown
		//IL_06d0: Expected I4, but got Obj
		//IL_06ed: Expected I4, but got I8
		//IL_0123: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I4
		//IL_071f: Expected I4, but got VT
		//IL_072f: Expected Obj, but got I
		//IL_073d: Expected Obj, but got I4
		//IL_0757: Expected Obj, but got I4
		//IL_0850: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got I4
		//IL_0886: Expected Obj, but got I
		//IL_0898: Expected VT, but got I8
		//IL_08b3: Expected VT, but got I4
		//IL_01bc: Expected VT, but got I4
		//IL_08d6: Expected Obj, but got VT
		//IL_08f0: Expected Obj, but got I4
		//IL_08f8: Expected I4, but got VT
		//IL_0df4: Expected Obj, but got I4
		//IL_0e05: Expected Obj, but got I4
		//IL_0a08: Expected Obj, but got I4
		//IL_0a11: Expected Obj, but got I4
		//IL_0a19: Expected VT, but got Ref
		//IL_0a5e: Expected I4, but got VT
		//IL_0a66: Expected Obj, but got Ref
		//IL_0a7f: Expected Obj, but got I4
		//IL_07a6: Expected VT, but got I4
		//IL_07ab: Expected VT, but got Obj
		//IL_07bc: Expected VT, but got I4
		//IL_0e5c: Expected Ref, but got VT
		//IL_092e: Expected Obj, but got I
		//IL_0940: Expected VT, but got Obj
		//IL_095f: Expected Obj, but got I
		//IL_0971: Expected I4, but got Obj
		//IL_0971: Expected VT, but got I4
		//IL_07d3: Invalid comparison between VT and I4
		//IL_024e: Expected Obj, but got F4
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0e94: Expected Obj, but got I
		//IL_0eb1: Expected Obj, but got VT
		//IL_0ec2: Expected Obj, but got I4
		//IL_099b: Expected I4, but got Obj
		//IL_099b: Expected VT, but got I4
		//IL_09ad: Expected I4, but got Obj
		//IL_09ad: Expected VT, but got I4
		//IL_0ad9: Expected Obj, but got I
		//IL_0b03: Expected Obj, but got I4
		//IL_09ba: Expected I4, but got Obj
		//IL_09cc: Expected I4, but got Obj
		//IL_09cc: Expected VT, but got I4
		//IL_07f0: Invalid comparison between VT and I4
		//IL_0802: Expected VT, but got I4
		//IL_0807: Expected VT, but got Obj
		//IL_0818: Expected VT, but got I4
		//IL_02a8: Expected Obj, but got I4
		//IL_0fbd: Expected Obj, but got I
		//IL_0fec: Expected Obj, but got I4
		//IL_0abb: Expected Obj, but got I4
		//IL_02cf: Expected VT, but got I4
		//IL_0c33: Expected F4, but got VT
		//IL_0c2e: Expected native int or pointer, but got VT
		//IL_0c41: Expected VT, but got I4
		//IL_0c49: Expected I4, but got Obj
		//IL_0c6b: Expected I, but got VT
		//IL_0b38: Expected Obj, but got I
		//IL_0b41: Expected VT, but got Obj
		//IL_0b7c: Expected Obj, but got I4
		//IL_02fd: Expected Obj, but got I
		//IL_033e: Invalid comparison between Obj and F8
		//IL_0bb4: Expected I4, but got I8
		//IL_0bcb: Expected VT, but got I4
		//IL_0bcb: Expected VT, but got I4
		//IL_0bf7: Expected VT, but got I4
		//IL_0381: Expected Obj, but got I4
		//IL_03a8: Expected VT, but got I4
		//IL_03f8: Expected Obj, but got I4
		//IL_0423: Expected VT, but got F4
		//IL_0473: Expected Obj, but got I4
		//IL_049e: Expected VT, but got F4
		//IL_04ae: Expected Obj, but got I
		//IL_04b8: Expected I4, but got Obj
		//IL_04d0: Expected Obj, but got I
		//IL_04f2: Expected Obj, but got I4
		//IL_0519: Expected Obj, but got I4
		//IL_0548: Expected VT, but got I4
		//IL_0cf6: Expected Obj, but got I4
		//IL_0d30: Invalid comparison between F4 and I4
		//IL_0d41: Expected VT, but got I4
		//IL_1008: Expected VT, but got I4
		//IL_102e: Invalid comparison between F4 and I4
		//IL_103d: Invalid comparison between F4 and I4
		//IL_104b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1050: Expected Obj, but got Unknown
		//IL_1058: Unknown result type (might be due to invalid IL or missing references)
		//IL_105d: Expected Obj, but got Unknown
		//IL_1092: Expected Obj, but got I4
		//IL_109a: Unknown result type (might be due to invalid IL or missing references)
		//IL_109f: Expected Obj, but got Unknown
		//IL_1130: Expected Obj, but got I4
		//IL_1138: Unknown result type (might be due to invalid IL or missing references)
		//IL_113d: Expected Obj, but got Unknown
		//IL_11ce: Expected Obj, but got I4
		//IL_11d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected Obj, but got Unknown
		//IL_1233: Expected I4, but got VT
		//IL_1233: Expected VT, but got I4
		//IL_1233: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj = 0;
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		RpcChannel rpcChannel = (RpcChannel)0;
		object obj3 = default;
		object obj2 = obj3;
		object obj5 = default;
		object obj4 = obj5;
		nint num2 = default;
		nint num = num2;
		byte b2 = default;
		byte b = b2;
		Vector3 vector2 = default;
		Vector3 vector = vector2;
		int bytePayloadSize4;
		int bytePayloadSize5;
		int num4 = default;
		int num5 = default;
		Vector3 vector3 = default;
		UnityEngine.Object obj8;
		int num6;
		int num7;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder2 = default;
		Fusion.RpcDataWriter writer;
		Vector3 way2 = default;
		PlayerRef playerRef;
		PlayerRef playerRef2;
		RpcInvokeInfo rpcInvokeInfo2;
		int num3;
		object obj6;
		bool flag4;
		object obj9;
		IntPtr intPtr;
		if (flag2)
		{
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			int bytePayloadSize3 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			bytePayloadSize4 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			bytePayloadSize5 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			int bytePayloadSize6 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			int bytePayloadSize7 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v16+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			flag4 = (object)((SimulationBehaviour)this)._runner == null;
			num3 = bytePayloadSize5;
			num4 = bytePayloadSize4;
			num5 = bytePayloadSize2;
			vector3 = vector2;
			obj8 = null;
			obj2 = obj3;
			obj9 = obj5;
			intPtr = num2;
			num6 = bytePayloadSize;
			b = b2;
			num7 = bytePayloadSize7;
			if (!flag4)
			{
				object obj10 = bytePayloadSize2 + bytePayloadSize;
				object obj11 = bytePayloadSize3 + bytePayloadSize4;
				object obj12 = bytePayloadSize5 + bytePayloadSize6;
				object obj13 = obj10 + obj11;
				object obj14 = obj12 + bytePayloadSize7;
				int payloadByteCount = (int)(obj13 + obj14);
				Fusion.RpcBuilder rpcBuilder = ((SimulationBehaviour)this)._runner.CreateRpcBuilder(4161124152u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder2.Prepare(out writer);
				num7 = rpcInvokeInfo >> 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				obj = 0;
				object obj15 = num7 - 522;
				bool flag5 = (nint)obj15 < 2;
				object obj16 = !flag5;
				object obj17 = ~obj16;
				if (obj17 == null && num7 != 518)
				{
					bool flag6 = num7 != 524;
					way2 = (Vector3)0;
					playerRef = (PlayerRef)this;
					playerRef2 = invalid;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag6)
					{
						goto IL_08c8;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag7 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						way2 = (Vector3)0;
						playerRef = (PlayerRef)this;
						playerRef2 = invalid;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag7)
						{
							goto IL_08c8;
						}
					}
				}
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X0_v80+E4]");
				bool flag8 = (nint)0 == 0;
				object obj19 = !flag8;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0680]");
				object rpc = 0;
				playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
				way2 = (Vector3)0;
				playerRef2 = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_08c8;
			}
			goto IL_0da0;
		}
		goto IL_0005;
		IL_08c8:
		object obj20 = rpcInvokeInfo >> 32;
		bool flag9 = obj20 == null;
		object obj21 = !flag9;
		int num8 = (int)rpcInvokeInfo2;
		obj2 = obj3;
		obj9 = obj5;
		intPtr = num2;
		float num9 = default;
		object obj24 = default;
		IntPtr intPtr2 = default;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			playerRef = (PlayerRef)obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj23 = 0;
			writer.Write((Vector3)12, (int)obj23);
			writer.Write(num9, 4);
			writer.Write((Vector3)12, (int)obj23);
			writer.Write((Vector3)12, (int)obj23);
			num8 = (int)obj23;
			writer.Write((Vector3)12, (int)obj23);
			int num10 = rpcBuilder2.Send();
			obj2 = obj3;
			obj9 = obj24;
			intPtr = intPtr2;
		}
		rpcBuilder2.Dispose();
		object obj25 = 0;
		object obj26 = 0;
		Fusion.RpcBuilder rpcBuilder3 = (Fusion.RpcBuilder)(&rpcBuilder2);
		Vector3 vector4 = (Vector3)playerRef;
		Vector3 vector5 = (Vector3)playerRef2;
		num3 = bytePayloadSize5;
		num4 = bytePayloadSize4;
		num5 = (int)(&writer);
		vector3 = vector2;
		byte b3 = (byte)num8;
		obj8 = null;
		num6 = (int)rpcInvokeInfo;
		NullReferenceException ex = (NullReferenceException)(&rpcBuilder2);
		b = b2;
		vector = vector2;
		obj6 = 10;
		goto IL_125b;
		IL_0dae:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		rpcBuilder3 = rpcBuilder3;
		OutOfMemoryException ex3 = default;
		OutOfMemoryException ex2 = ex3;
		object obj28 = default;
		Fusion.RpcBuilder rpcBuilder4 = default;
		OutOfMemoryException ex5 = default;
		while (true)
		{
			object obj27;
			if ((nint)obj8 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj25 = 1;
				obj27 = obj26;
				obj6 = 1;
			}
			else
			{
				if ((nint)obj8 != 1)
				{
					goto IL_1238;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj27 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj26 = obj28;
			}
			((Fusion.RpcBuilder*)rpcBuilder3)->Dispose();
			if (obj27 == null)
			{
				break;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			ex2 = ex4;
			obj8 = null;
			goto IL_1238;
			IL_1238:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			rpcBuilder3 = rpcBuilder4;
			ex2 = ex5;
			num5 = 0;
			num6 = 0;
			num7 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		obj = 0;
		vector4 = vector2;
		b3 = b2;
		obj8 = null;
		ex = (NullReferenceException)rpcBuilder3;
		vector = vector3;
		obj6 = 0;
		goto IL_125b;
		IL_125b:
		bool flag10 = obj25 == null;
		flag4 = !flag10;
		vector2 = vector4;
		b2 = b3;
		if (!flag4)
		{
			if ((nint)obj6 != 10)
			{
				bool flag11 = obj6 == null;
				object obj29 = !flag11;
				if (obj29 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj30 = 0;
			object obj31 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X0_v6+E4]");
			bool flag12 = (nint)0 == 0;
			object obj32 = !flag12;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj31 = obj30;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X0_v6+A0]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ X8_v5+18]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ X8_v5+18]");
			bool flag13 = (nint)0 == 0;
			MethodBase methodBase = (MethodBase)num4;
			if (!flag13)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0678]");
				object obj34 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj34);
				object obj35 = obj;
				int num11 = num6 | num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v10+E4]");
				bool flag14 = (nint)0 == 0;
				object obj36 = !flag14;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(num5 & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num11, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v602 @ X27_v3 (System.Int32)+18] (should have been resolved before IL gen)");
				object obj37 = default;
				obj25 = obj37;
				way2 = (Vector3)invalid2;
				vector5 = (Vector3)0;
				methodBase = methodFromHandle;
				object obj38 = default;
				obj2 = obj38;
			}
			if (num6 != 0)
			{
				return;
			}
			RpcInfo rpcInfo = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			((Vector3*)(nint)vector)->x = (float)rpcBuilder3;
			vector2 = (Vector3)0;
			num4 = (int)methodBase;
			b2 = 0;
			rpcChannel = (RpcChannel)0;
			obj4 = obj25;
			num = (nint)rpcBuilder3;
			goto IL_0005;
		}
		goto IL_0dae;
		IL_0da0:
		ex = new NullReferenceException();
		goto IL_0dae;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		num6 = 0;
		int value = ((int*)num6)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v89 (System.Int32)+E4]");
		bool flag15 = (nint)0 == 0;
		object obj39 = !flag15;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag16 = NetworkApe.SaneWound(section, (Vector3)0);
		int num12 = section & 0xFF;
		bool flag17 = num12 < 3;
		object obj40 = !flag17;
		object obj41 = num12 - 3;
		bool flag18 = obj41 == null;
		object obj42 = !flag18;
		object obj43 = obj40 & obj42;
		if (obj43 != null || !flag16)
		{
			return;
		}
		int num13 = b & 0xFF;
		bool flag19 = num13 < 1;
		object obj44 = !flag19;
		object obj45 = num13 - 1;
		bool flag20 = obj45 == null;
		object obj46 = !flag20;
		object obj47 = obj44 & obj46;
		if (obj47 != null)
		{
			return;
		}
		int value2 = ((int*)num6)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X0_v93 (System.Int32)+E4]");
		bool flag21 = (nint)0 == 0;
		object obj48 = !flag21;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkApe.Sane((Vector3)0))
		{
			return;
		}
		float num14 = off * off;
		object obj50 = default;
		object obj49 = obj50 * obj50;
		float num15 = num14 + (float)obj49;
		object obj52 = default;
		object obj51 = obj52 * obj52;
		float num16 = (float)obj51 + num15;
		if ((double)num16 < 0.5)
		{
			return;
		}
		object obj53 = ~num9;
		object obj54 = 0x7F800000 & obj53;
		if (obj54 == null)
		{
			return;
		}
		int value3 = ((int*)num6)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X0_v97 (System.Int32)+E4]");
		bool flag22 = (nint)0 == 0;
		object obj55 = !flag22;
		if (obj55 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkApe.Sane((Vector3)0))
		{
			return;
		}
		object obj56 = num2 * num2;
		object obj58 = default;
		object obj57 = obj58 * obj58;
		object obj59 = obj56 + obj57;
		object obj60 = obj5 * obj5;
		object obj61 = obj60 + obj59;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj61) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.5))
		{
			return;
		}
		int value4 = ((int*)num6)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v101 (System.Int32)+E4]");
		bool flag23 = (nint)0 == 0;
		object obj62 = !flag23;
		if (obj62 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkApe.Sane((Vector3)0))
		{
			return;
		}
		int value5 = ((int*)num6)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X0_v105 (System.Int32)+E4]");
		bool flag24 = (nint)0 == 0;
		object obj63 = !flag24;
		if (obj63 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkApe.InBudget((PlayerRef)vector.y))
		{
			return;
		}
		int value6 = ((int*)num6)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X0_v109 (System.Int32)+E4]");
		bool flag25 = (nint)0 == 0;
		object obj64 = !flag25;
		if (obj64 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetworkApe.SawBogs((PlayerRef)vector.y);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj65 = 0;
		num7 = (int)((SimulationBehaviour)this)._runner;
		object obj66 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X0_v112+E4]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X0_v112+E4]");
		bool flag26 = (nint)0 == 0;
		object obj67 = !flag26;
		if (obj67 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 middle2;
		if ((UnityEngine.Object)num7 == null)
		{
			UnityEngine.Object obj68 = null;
			middle2 = (Vector3)1;
		}
		else
		{
			flag4 = (object)((SimulationBehaviour)this)._runner == null;
			b2 = 0;
			obj8 = null;
			obj2 = obj3;
			obj9 = obj24;
			intPtr = intPtr2;
			b = (byte)num13;
			if (flag4)
			{
				goto IL_0da0;
			}
			PlayerRef localPlayer = ((SimulationBehaviour)this)._runner.LocalPlayer;
			object obj69 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X8_v51+E4]");
			bool flag27 = (nint)0 == 0;
			object obj70 = !flag27;
			if (obj70 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num17 = vector.y - (float)localPlayer;
			bool flag28 = num17 == 0f;
			Vector3 vector6 = (Vector3)(!flag28);
			UnityEngine.Object obj68 = null;
			middle2 = vector6;
		}
		bool flag29 = (double)num9 < -3.0;
		double num18 = -3.0;
		if (!flag29)
		{
			bool flag30 = !((double)num9 > 3.0);
			num18 = num9;
			if (!flag30)
			{
				num18 = 3.0;
			}
		}
		GillaRip.Along along = GillaRip.Along.Across((Vector3)0, off);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
		float num19 = (float)(nint)intPtr2 - off;
		bool flag31 = num19 < 0f;
		bool flag32 = num19 == 0f;
		object obj71 = (nint)intPtr2 ^ off;
		object obj72 = (nint)intPtr2 ^ num19;
		object obj73 = obj71 & obj72;
		bool flag33 = (nint)obj73 < 0;
		bool flag34 = flag31 == flag33;
		object obj74 = !flag32;
		object obj75 = flag34 & obj74;
		object obj76 = ~obj75;
		if (obj76 == null)
		{
		}
		object obj77 = obj24 - obj50;
		bool flag35 = (nint)obj77 < 0;
		bool flag36 = obj77 == null;
		object obj78 = obj24 ^ obj50;
		object obj79 = obj24 ^ obj77;
		object obj80 = obj78 & obj79;
		bool flag37 = (nint)obj80 < 0;
		bool flag38 = flag35 == flag37;
		object obj81 = !flag36;
		object obj82 = flag38 & obj81;
		object obj83 = ~obj82;
		if (obj83 == null)
		{
		}
		object obj84 = obj3 - obj52;
		bool flag39 = (nint)obj84 < 0;
		bool flag40 = obj84 == null;
		object obj85 = obj3 ^ obj52;
		object obj86 = obj3 ^ obj84;
		object obj87 = obj85 & obj86;
		bool flag41 = (nint)obj87 < 0;
		bool flag42 = flag39 == flag41;
		object obj88 = !flag40;
		object obj89 = flag42 & obj88;
		object obj90 = ~obj89;
		if (obj90 == null)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		object obj91 = default;
		SawBitten((GoreSection)section, num13, (GillaRip.Along)(&obj91), middle2, way2, (Vector3)0, (byte)(int)info != 0);
	}

	public unsafe void RPC_SawThrough(byte section, Vector3 normal, float off, RpcInfo info = default(RpcInfo))
	{
		//IL_08fd: Expected Obj, but got I4
		//IL_0916: Expected VT, but got I4
		//IL_091e: Expected I4, but got VT
		//IL_095d: Expected Obj, but got I4
		//IL_096b: Expected Obj, but got I4
		//IL_0985: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_05d4: Expected Obj, but got I
		//IL_05fe: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I4
		//IL_0625: Expected VT, but got I4
		//IL_07bb: Expected VT, but got I4
		//IL_07dc: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected I4, but got Unknown
		//IL_00fa: Expected I4, but got I8
		//IL_012c: Expected I4, but got VT
		//IL_013a: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I4
		//IL_06b7: Expected Obj, but got F4
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected Obj, but got Unknown
		//IL_024d: Expected Obj, but got I4
		//IL_0283: Expected Obj, but got I
		//IL_0295: Expected VT, but got I8
		//IL_02b0: Expected VT, but got I4
		//IL_070c: Expected Obj, but got I4
		//IL_02d3: Expected Obj, but got VT
		//IL_02ed: Expected Obj, but got I4
		//IL_02f6: Expected F4, but got I4
		//IL_0737: Expected VT, but got F4
		//IL_081f: Expected Obj, but got I4
		//IL_03b2: Expected VT, but got F4
		//IL_03bb: Expected Obj, but got I4
		//IL_03c4: Expected Obj, but got I4
		//IL_03cc: Expected VT, but got Ref
		//IL_03e4: Expected I, but got VT
		//IL_03f5: Expected Obj, but got I4
		//IL_03fd: Expected Obj, but got Ref
		//IL_0405: Expected I4, but got VT
		//IL_01a3: Expected VT, but got I4
		//IL_01a8: Expected VT, but got Obj
		//IL_01b1: Expected VT, but got I4
		//IL_0886: Expected Ref, but got VT
		//IL_089e: Expected Obj, but got I4
		//IL_08a6: Expected Obj, but got VT
		//IL_0424: Expected Obj, but got I4
		//IL_0314: Expected Obj, but got I
		//IL_031c: Expected VT, but got Obj
		//IL_0336: Expected Obj, but got I
		//IL_0348: Expected I4, but got Obj
		//IL_0348: Expected VT, but got I4
		//IL_035d: Expected Obj, but got I
		//IL_0365: Expected VT, but got Obj
		//IL_01d0: Invalid comparison between VT and I4
		//IL_09f3: Expected VT, but got I4
		//IL_0a05: Expected VT, but got Ref
		//IL_0442: Expected Obj, but got I
		//IL_046c: Expected Obj, but got I4
		//IL_08d3: Expected Obj, but got I4
		//IL_09b0: Expected Obj, but got I
		//IL_09c0: Expected Obj, but got I
		//IL_01ed: Invalid comparison between VT and I4
		//IL_01ff: Expected VT, but got I4
		//IL_0204: Expected VT, but got Obj
		//IL_020d: Expected VT, but got I4
		//IL_0a67: Expected Obj, but got I4
		//IL_04a1: Expected Obj, but got I
		//IL_04aa: Expected VT, but got Obj
		//IL_04e5: Expected Obj, but got I4
		//IL_058f: Expected F4, but got VT
		//IL_058a: Expected native int or pointer, but got VT
		//IL_05ad: Expected VT, but got I4
		//IL_051d: Expected I4, but got I8
		//IL_0534: Expected VT, but got I4
		//IL_0534: Expected VT, but got I4
		//IL_0564: Expected I, but got Obj
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		object obj = !flag2;
		object obj3 = default;
		object obj2 = obj3;
		object obj5 = default;
		object obj4 = obj5;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		RpcHostMode rpcHostMode = (RpcHostMode)normal;
		RpcChannel rpcChannel = (RpcChannel)0;
		object obj6;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		int num;
		PlayerRef playerRef2;
		RpcInvokeInfo rpcInvokeInfo2;
		PlayerRef playerRef3;
		int num2;
		int num3;
		object obj15;
		Fusion.RpcBuilder rpcBuilder4;
		Vector3 vector;
		NullReferenceException ex;
		object obj16;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj6 = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			int bytePayloadSize3 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v11+E4]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			if ((object)((SimulationBehaviour)this)._runner != null)
			{
				obj8 = bytePayloadSize2 + bytePayloadSize;
				int payloadByteCount = obj8 + bytePayloadSize3;
				Fusion.RpcBuilder rpcBuilder2 = ((SimulationBehaviour)this)._runner.CreateRpcBuilder(3153123177u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				num = rpcInvokeInfo >> 32;
				object obj10 = num - 522;
				bool flag4 = (nint)obj10 < 2;
				object obj11 = !flag4;
				object obj12 = ~obj11;
				PlayerRef playerRef;
				if (obj12 == null && num != 518)
				{
					bool flag5 = num != 524;
					playerRef = (PlayerRef)0;
					playerRef2 = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					playerRef3 = invalid;
					if (flag5)
					{
						goto IL_02c5;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag6 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						playerRef = (PlayerRef)0;
						playerRef2 = (PlayerRef)this;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						playerRef3 = invalid;
						if (flag6)
						{
							goto IL_02c5;
						}
					}
				}
				object obj13 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X0_v80+E4]");
				bool flag7 = (nint)0 == 0;
				object obj14 = !flag7;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0690]");
				object rpc = 0;
				playerRef2 = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef2);
				playerRef = (PlayerRef)0;
				rpcInvokeInfo2 = rpcInvokeInfo;
				playerRef3 = none;
				goto IL_02c5;
			}
			ex = new NullReferenceException();
			obj2 = obj3;
			obj15 = obj5;
			rpcBuilder4 = (Fusion.RpcBuilder)0;
			vector = normal;
			num = bytePayloadSize3;
			num2 = bytePayloadSize2;
			obj16 = 0;
			num3 = bytePayloadSize;
			goto IL_07e9;
		}
		goto IL_0935;
		IL_040a:
		object obj17 = default;
		bool flag8 = obj17 == null;
		object obj18 = !flag8;
		if (obj18 != null)
		{
			goto IL_07e9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj19 = 0;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X0_v49+E4]");
		bool flag9 = (nint)0 == 0;
		object obj21 = !flag9;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj19;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X0_v49+A0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v19+18]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v19+18]");
		nint num5;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0688]");
			object obj24 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj24);
			object obj25 = obj6;
			int num4 = num3 | num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v24+E4]");
			bool flag10 = (nint)0 == 0;
			object obj26 = !flag10;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid2 = PlayerRef.Invalid;
			RpcHostMode hostMode = (RpcHostMode)(num2 & 0xFFFFFFFFL);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num4, hostMode, (PlayerRef)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v95 @ X27_v4+18] (should have been resolved before IL gen)");
			object obj27 = default;
			obj2 = obj27;
			object obj28 = default;
			obj17 = obj28;
			PlayerRef playerRef = invalid2;
			num5 = unchecked((nint)null);
		}
		bool flag11 = num3 == 0;
		object obj29 = !flag11;
		Fusion.RpcBuilder rpcBuilder5 = default;
		RpcInfo rpcInfo2;
		if (obj29 == null)
		{
			RpcInfo rpcInfo = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			((Vector3*)(nint)normal)->x = (float)rpcBuilder5;
			obj4 = obj17;
			rpcBuilder = rpcBuilder5;
			rpcInfo2 = (RpcInfo)0;
			rpcHostMode = (RpcHostMode)0;
			rpcChannel = (RpcChannel)0;
			goto IL_0935;
		}
		return;
		IL_0a2a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_02c5:
		object obj30 = rpcInvokeInfo >> 32;
		bool flag12 = obj30 == null;
		object obj31 = !flag12;
		float num6 = 0f;
		float num7 = default;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj32 = 0;
			playerRef2 = (PlayerRef)obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj33 = 0;
			writer.Write((Vector3)12, (int)obj33);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BD0]");
			object obj34 = 0;
			rpcInvokeInfo2 = (RpcInvokeInfo)obj34;
			writer.Write(num7, 4);
			int num8 = rpcBuilder3.Send();
			num6 = num7;
		}
		rpcBuilder3.Dispose();
		obj2 = obj3;
		obj15 = obj5;
		rpcBuilder4 = (Fusion.RpcBuilder)num6;
		obj17 = 0;
		object obj35 = 0;
		rpcBuilder5 = (Fusion.RpcBuilder)(&rpcBuilder3);
		rpcInfo2 = (RpcInfo)playerRef2;
		vector = (Vector3)rpcInvokeInfo2;
		num5 = (nint)playerRef3;
		num2 = (int)(&writer);
		obj16 = 0;
		ex = (NullReferenceException)(&rpcBuilder3);
		num3 = (int)rpcInvokeInfo;
		goto IL_040a;
		IL_07e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj36;
		OutOfMemoryException ex2;
		if ((nint)obj16 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj17 = 1;
			obj36 = obj35;
		}
		else
		{
			bool flag13 = (nint)obj16 != 1;
			OutOfMemoryException ex3 = default;
			ex2 = ex3;
			if (flag13)
			{
				goto IL_0a2a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj37 = default;
			obj36 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj35 = obj37;
		}
		((Fusion.RpcBuilder*)rpcBuilder5)->Dispose();
		bool flag14 = obj36 == null;
		obj16 = 0;
		ex = (NullReferenceException)rpcBuilder5;
		if (flag14)
		{
			goto IL_040a;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		ex2 = ex4;
		obj16 = 0;
		goto IL_0a2a;
		IL_0935:
		int num9 = section & 0xFF;
		bool flag15 = num9 < 3;
		object obj38 = !flag15;
		object obj39 = num9 - 3;
		bool flag16 = obj39 == null;
		object obj40 = !flag16;
		object obj41 = obj38 & obj40;
		if (obj41 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj42 = 0;
		object obj43 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v5+E4]");
		bool flag17 = (nint)0 == 0;
		object obj44 = !flag17;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkApe.Sane((Vector3)0))
		{
			return;
		}
		float num10 = off * off;
		object obj45 = obj5 * obj5;
		float num11 = num10 + (float)obj45;
		object obj46 = obj3 * obj3;
		float num12 = (float)obj46 + num11;
		if ((double)num12 < 0.5)
		{
			return;
		}
		object obj47 = ~num7;
		object obj48 = 0x7F800000 & obj47;
		if (obj48 != null)
		{
			object obj49 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v9+E4]");
			bool flag18 = (nint)0 == 0;
			object obj50 = !flag18;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (NetworkApe.InBudget((PlayerRef)normal.y) && ((double)num7 < -3.0 || !((double)num7 > 3.0)))
			{
				GillaRip.Along along = GillaRip.Along.Across((Vector3)0, off);
				object obj51 = default;
				SawnThrough((GoreSection)section, (GillaRip.Along)(&obj51));
			}
		}
	}

	private unsafe void SawBitten(GoreSection section, int slot, GillaRip.Along along, Vector3 middle, Vector3 way, Vector3 half, bool bleed)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected VT, but got Unknown
		//IL_0143: Expected VT, but got I4
		//IL_0143: Expected VT, but got Ref
		if (mode == (Mode)3)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = tearing == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D48]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 middle2 = (Vector3)(middle & 1);
			object obj8 = default;
			GillaSaw.Bite(tearing, section, slot, (GillaRip.Along)(&obj8), middle2, (Vector3)0, half, bleed);
		}
	}

	private unsafe void SawnThrough(GoreSection section, GillaRip.Along along)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0085: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Ref, but got Unknown
		//IL_0314: Expected F4, but got VT
		//IL_0314: Expected VT, but got I4
		//IL_019d: Expected Obj, but got I
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_022d: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_025d: Expected I, but got Obj
		//IL_026d: Expected Obj, but got I
		//IL_028c: Expected Obj, but got I
		//IL_02a2: Expected I, but got Obj
		//IL_02cc: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0698]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003C_003Ec__DisplayClass77_0 obj2 = default;
		obj2._002Ector();
		object obj3 = obj2 + 64;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [along @ X2 (GillaRip+Along)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [along @ X2 (GillaRip+Along)+10]");
		_ = 0;
		_ = along.n;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		if (mode == (Mode)3)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (tearing == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D48]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v14+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (GillaSaw.PartOf(section, out *(ApePart*)(obj2 + 16)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D06B0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			_003C_003Ec__DisplayClass77_1 obj11 = default;
			obj11._002Ector();
			object obj12 = obj11 + 24;
			obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Dismemberment dismemberment = tearing;
			int bodyId = BodyId;
			dismemberment.pieceOwner = bodyId;
			object obj13 = obj11 + 16;
			obj13 = tearing;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F28]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D06A8]");
			object obj15 = 0;
			Func<bool> func = default;
			func._002Ector((object)obj11, (IntPtr)obj15);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D06A0]");
			object obj17 = 0;
			Action action = default;
			action._002Ector(obj11.CS_0024_003C_003E8__locals1, (IntPtr)obj17);
			object obj18 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v33+E4]");
			bool flag3 = (nint)0 == 0;
			object obj19 = !flag3;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaSaw.WhenCut(func, action);
		}
		else
		{
			IntPtr intPtr = default;
			DoorCutHere(9, (Vector3)255, (float)obj2.along, (byte)(nint)intPtr);
		}
	}

	public unsafe void RPC_DoorCut(byte seed, Vector3 normal, float off, byte door, RpcInfo info = default(RpcInfo))
	{
		//IL_0a67: Expected VT, but got I4
		//IL_02b6: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_032c: Expected Obj, but got I4
		//IL_0066: Expected VT, but got I4
		//IL_08c1: Expected Obj, but got I4
		//IL_08da: Expected VT, but got I4
		//IL_00d7: Expected Obj, but got F4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0105: Invalid comparison between F4 and I4
		//IL_0114: Invalid comparison between F4 and I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_013c: Expected Obj, but got F4
		//IL_0171: Expected Obj, but got I4
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_037c: Expected Obj, but got I4
		//IL_0389: Expected Obj, but got I4
		//IL_0396: Expected I4, but got Obj
		//IL_03df: Expected Obj, but got VT
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected Obj, but got Unknown
		//IL_0407: Expected Obj, but got I4
		//IL_0a80: Expected Obj, but got I4
		//IL_01b2: Invalid comparison between F4 and I4
		//IL_04f8: Expected Obj, but got I4
		//IL_052e: Expected Obj, but got I
		//IL_0540: Expected VT, but got I8
		//IL_0557: Expected I, but got Obj
		//IL_057a: Expected Obj, but got VT
		//IL_0594: Expected Obj, but got I4
		//IL_059d: Expected F4, but got I4
		//IL_0925: Expected Obj, but got I4
		//IL_0936: Expected Obj, but got I4
		//IL_064b: Expected Obj, but got I4
		//IL_0654: Expected Obj, but got I4
		//IL_065c: Expected VT, but got Ref
		//IL_0664: Expected I4, but got VT
		//IL_0685: Expected Obj, but got I4
		//IL_069d: Expected VT, but got F4
		//IL_06a5: Expected Obj, but got Ref
		//IL_06ae: Expected Obj, but got I4
		//IL_06b6: Expected I4, but got VT
		//IL_0452: Expected I, but got Obj
		//IL_0457: Expected VT, but got Obj
		//IL_0460: Expected VT, but got I4
		//IL_0217: Expected Obj, but got I4
		//IL_098d: Expected Ref, but got VT
		//IL_05bb: Expected Obj, but got I
		//IL_05d5: Expected Obj, but got I
		//IL_05e7: Expected I4, but got Obj
		//IL_05e7: Expected VT, but got I4
		//IL_0245: Expected VT, but got I
		//IL_0607: Expected VT, but got Obj
		//IL_047f: Invalid comparison between VT and I4
		//IL_09f3: Expected Obj, but got I4
		//IL_09be: Expected Obj, but got I4
		//IL_09c6: Expected Obj, but got VT
		//IL_09cf: Expected Obj, but got I4
		//IL_062c: Expected VT, but got I4
		//IL_0710: Expected Obj, but got I
		//IL_073a: Expected Obj, but got I4
		//IL_049c: Invalid comparison between VT and I4
		//IL_04aa: Expected I, but got Obj
		//IL_04af: Expected VT, but got Obj
		//IL_04b8: Expected VT, but got I4
		//IL_0ac7: Expected Obj, but got I
		//IL_0ad7: Expected Obj, but got I
		//IL_06f2: Expected Obj, but got I4
		//IL_0862: Expected I4, but got VT
		//IL_0879: Expected VT, but got I4
		//IL_076f: Expected Obj, but got I
		//IL_0778: Expected VT, but got Obj
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected I4, but got Unknown
		//IL_07b3: Expected Obj, but got I4
		//IL_07eb: Expected I4, but got I8
		//IL_0802: Expected VT, but got I4
		//IL_0802: Expected VT, but got I4
		//IL_0825: Expected I, but got VT
		//IL_082e: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		byte door2 = door;
		Vector3 vector = normal;
		RpcChannel rpcChannel = (RpcChannel)0;
		object obj2 = default;
		object obj = obj2;
		object obj4 = default;
		object obj3 = obj4;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		if (!flag2)
		{
			goto IL_0005;
		}
		goto IL_02a6;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v79+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num4 = default;
		if (NetworkApe.Sane((Vector3)0))
		{
			float num = off * off;
			object obj8 = obj4 * obj4;
			float num2 = num + (float)obj8;
			object obj9 = obj2 * obj2;
			float num3 = (float)obj9 + num2;
			object obj10 = ~num4;
			object obj11 = 0x7F800000 & obj10;
			float num5 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			float num6 = num5 - 0f;
			bool flag4 = num6 < 0f;
			bool flag5 = num6 == 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			object obj12 = num3 ^ 0;
			object obj13 = num3 ^ num6;
			object obj14 = obj12 & obj13;
			bool flag6 = (nint)obj14 < 0;
			bool flag7 = flag4 == flag6;
			object obj15 = !flag5;
			object obj16 = flag7 & obj15;
			object obj17 = ~obj16;
			bool flag8;
			if (obj17 == null)
			{
				float num7 = num3 - 4f;
				flag8 = num7 < 0f;
			}
			else
			{
				flag8 = false;
			}
			object obj18 = !flag8;
			if (obj18 == null && obj11 != null)
			{
				object obj19 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v83+E4]");
				bool flag9 = (nint)0 == 0;
				object obj20 = !flag9;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [door @ X3 (System.Byte)+4]");
				if (NetworkApe.InBudget((PlayerRef)0))
				{
					if ((double)num4 < -3.0 || !((double)num4 > 3.0))
					{
						DoorCutHere(seed, normal, off, door2);
						return;
					}
					goto IL_02a6;
				}
				return;
			}
			return;
		}
		return;
		IL_0b1f:
		object obj21 = default;
		object obj31;
		int num9;
		NetworkRunner networkRunner;
		int num10;
		Fusion.RpcBuilder rpcBuilder2 = default;
		object obj22;
		RpcInfo rpcInfo;
		if (obj21 == null)
		{
			if ((nint)obj22 != 7)
			{
				bool flag10 = obj22 == null;
				object obj23 = !flag10;
				if (obj23 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj24 = 0;
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X0_v18+E4]");
			bool flag11 = (nint)0 == 0;
			object obj26 = !flag11;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj25 = obj24;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X0_v18+A0]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v7+18]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v7+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D06C8]");
				object obj29 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj29);
				object obj30 = obj31;
				int num8 = num9 | networkRunner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v12+E4]");
				bool flag12 = (nint)0 == 0;
				object obj32 = !flag12;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(num10 & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, (RpcInvokeInfo)num8, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v123 @ X27_v4+18] (should have been resolved before IL gen)");
				object obj33 = default;
				obj21 = obj33;
				nint num11 = (nint)invalid;
				rpcInfo = (RpcInfo)0;
				object obj34 = default;
				obj = obj34;
			}
			if (num9 != 0)
			{
				return;
			}
			RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			((byte*)(int)door)->m_value = (byte)(int)rpcBuilder2;
			door2 = 0;
			vector = (Vector3)0;
			rpcChannel = (RpcChannel)0;
			obj3 = obj21;
			rpcBuilder = rpcBuilder2;
			goto IL_0005;
		}
		goto IL_08e7;
		IL_02a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		obj31 = 0;
		int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(1);
		int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
		int bytePayloadSize3 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
		int bytePayloadSize4 = Fusion.RpcDataWriter.GetBytePayloadSize(1);
		obj22 = obj31;
		networkRunner = ((SimulationBehaviour)this)._runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v18+E4]");
		bool flag13 = (nint)0 == 0;
		object obj35 = !flag13;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef invalid2 = PlayerRef.Invalid;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder4 = default;
		Fusion.RpcDataWriter writer;
		PlayerRef playerRef;
		RpcInvokeInfo rpcInvokeInfo2;
		PlayerRef playerRef2;
		if ((object)networkRunner != null)
		{
			object obj36 = bytePayloadSize2 + bytePayloadSize;
			object obj37 = bytePayloadSize3 + bytePayloadSize4;
			int payloadByteCount = (int)(obj36 + obj37);
			Fusion.RpcBuilder rpcBuilder3 = networkRunner.CreateRpcBuilder(726025702u, payloadByteCount, (NetworkBehaviour)this, invalid2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			rpcInvokeInfo = rpcBuilder4.Prepare(out writer);
			networkRunner = (NetworkRunner)(rpcInvokeInfo >> 32);
			object obj38 = networkRunner - 522;
			bool flag14 = (nint)obj38 < 2;
			object obj39 = !flag14;
			object obj40 = ~obj39;
			nint num11;
			if (obj40 == null && (nint)networkRunner != 518)
			{
				bool flag15 = (nint)networkRunner != 524;
				num11 = unchecked((nint)null);
				playerRef = (PlayerRef)this;
				rpcInvokeInfo2 = (RpcInvokeInfo)0;
				playerRef2 = invalid2;
				if (flag15)
				{
					goto IL_056c;
				}
				if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
				{
					bool flag16 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
					num11 = unchecked((nint)null);
					playerRef = (PlayerRef)this;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					playerRef2 = invalid2;
					if (flag16)
					{
						goto IL_056c;
					}
				}
			}
			object obj41 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v70+E4]");
			bool flag17 = (nint)0 == 0;
			object obj42 = !flag17;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef none = PlayerRef.None;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D06D0]");
			object rpc = 0;
			playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
			NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
			num11 = unchecked((nint)null);
			rpcInvokeInfo2 = rpcInvokeInfo;
			playerRef2 = none;
			goto IL_056c;
		}
		NullReferenceException ex = new NullReferenceException();
		byte b = door;
		Vector3 vector2 = normal;
		num10 = bytePayloadSize2;
		object obj43 = 0;
		obj = obj2;
		object obj44 = obj4;
		Fusion.RpcBuilder rpcBuilder5 = (Fusion.RpcBuilder)0;
		num9 = bytePayloadSize;
		goto IL_08e7;
		IL_08e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		OutOfMemoryException ex3 = default;
		OutOfMemoryException ex2 = ex3;
		object obj46 = default;
		object obj47 = default;
		OutOfMemoryException ex5 = default;
		while (true)
		{
			object obj45;
			if ((nint)obj43 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj21 = 1;
				obj45 = obj46;
				obj22 = 1;
			}
			else
			{
				if ((nint)obj43 != 1)
				{
					goto IL_0afc;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj45 = obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj46 = obj47;
			}
			((Fusion.RpcBuilder*)rpcBuilder2)->Dispose();
			if (obj45 == null)
			{
				break;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			ex2 = ex4;
			obj43 = 0;
			goto IL_0afc;
			IL_0afc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			networkRunner = null;
			ex2 = ex5;
			num10 = 0;
			num9 = 0;
		}
		obj43 = 0;
		ex = (NullReferenceException)rpcBuilder2;
		obj22 = 0;
		goto IL_0b1f;
		IL_056c:
		object obj48 = rpcInvokeInfo >> 32;
		bool flag18 = obj48 == null;
		object obj49 = !flag18;
		float num12 = 0f;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj51 = 0;
			writer.Write((Vector3)12, (int)obj51);
			writer.Write(num4, 4);
			playerRef = (PlayerRef)obj50;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			int num13 = rpcBuilder4.Send();
			rpcInvokeInfo2 = (RpcInvokeInfo)1;
			num12 = num4;
		}
		rpcBuilder4.Dispose();
		obj21 = 0;
		obj46 = 0;
		rpcBuilder2 = (Fusion.RpcBuilder)(&rpcBuilder4);
		b = (byte)(int)playerRef;
		vector2 = (Vector3)rpcInvokeInfo2;
		rpcInfo = (RpcInfo)playerRef2;
		num10 = (int)(&writer);
		obj43 = 0;
		obj = obj2;
		obj44 = obj4;
		rpcBuilder5 = (Fusion.RpcBuilder)num12;
		ex = (NullReferenceException)(&rpcBuilder4);
		obj22 = 7;
		num9 = (int)rpcInvokeInfo;
		goto IL_0b1f;
	}

	public unsafe void CutByDoor(Vector3 normal, float off, byte door)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int seed = GillaRip.PickSeed();
		if (Live)
		{
			object obj4 = default;
			RpcInfo info = default;
			RPC_DoorCut((byte)seed, normal, off, (byte)(&obj4), info);
		}
		else
		{
			IntPtr intPtr = default;
			DoorCutHere((byte)seed, normal, off, (byte)(nint)intPtr);
		}
	}

	private unsafe void DoorCutHere(byte seed, Vector3 normal, float off, byte door)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I4
		//IL_027c: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I4
		//IL_0336: Expected Obj, but got I
		//IL_034e: Expected Obj, but got I
		//IL_035e: Expected VT, but got I4
		//IL_0368: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I4
		//IL_0318: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I
		//IL_02a3: Expected Obj, but got I4
		//IL_02bd: Expected Obj, but got I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_015b: Expected VT, but got I4
		//IL_0189: Expected Obj, but got I4
		//IL_01c9: Expected I4, but got VT
		//IL_01c9: Expected VT, but got Ref
		//IL_0247: Expected Obj, but got I4
		if (mode == (Mode)3)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = tearing == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		int bodyId = BodyId;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v9+A0]");
		object obj8 = 0;
		obj8 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v15+A0]");
		object obj11 = 0;
		Die((Vector3)1, quiet: false);
		object obj12 = 1;
		object obj13 = 0;
		object obj18 = default;
		while (true)
		{
			OutOfMemoryException ex = (OutOfMemoryException)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v16 (System.OutOfMemoryException)+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				ex = (OutOfMemoryException)obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v16 (System.OutOfMemoryException)+A0]");
			object obj15 = 0;
			obj15 = 0;
			bool flag6 = obj13 == null;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				object obj17 = obj12 & 1;
				if (obj17 != null)
				{
					break;
				}
			}
			else
			{
				ex = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			obj13 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj12 = 1;
		}
		GillaRip.Along along = GillaRip.Along.Across((Vector3)0, off);
		object obj19 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v33+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int seed2 = seed & 0xFF;
		object obj21 = default;
		GillaCorpse.DoorCut(bodyId, seed2, (GillaRip.Along)(&obj21), (byte)(int)normal);
	}

	private void Grabbed(PlayerRef by, bool right, Vector3 eyesFromHand)
	{
		//IL_00a8: Expected Obj, but got VT
		//IL_0054: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected VT, but got Unknown
		if (mode != 0)
		{
			return;
		}
		mode = (Mode)1;
		holder = by;
		holderRight = right;
		Vector3 vector = default;
		object obj = vector * vector;
		object obj3 = default;
		object obj2 = obj3 * obj3;
		object obj4 = obj + obj2;
		double num2 = default;
		double num = num2 * num2;
		double num3 = num + (double)obj4;
		bool flag = !(num3 > 6.25);
		double num4 = num2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj8 = vector / obj3;
			double num5 = num2 / 6.25;
			vector = (Vector3)(obj8 * 0);
			num4 = num5 * 2.5;
		}
		heldEyes = vector;
	}

	private void Released(Vector3 at, Vector3 velocity)
	{
		//IL_02b3: Expected Obj, but got I
		//IL_02dd: Expected Obj, but got I4
		//IL_0071: Invalid comparison between Obj and F8
		//IL_0211: Expected I4, but got VT
		//IL_0211: Expected VT, but got I4
		//IL_0098: Expected Obj, but got I
		//IL_00ab: Expected VT, but got Obj
		//IL_00cd: Expected Obj, but got I4
		//IL_02fb: Expected Obj, but got I
		//IL_0313: Expected Obj, but got I
		//IL_0435: Expected Obj, but got I
		//IL_0452: Expected Obj, but got I
		//IL_0462: Expected Obj, but got I
		//IL_0494: Expected Obj, but got I
		//IL_04a4: Expected Obj, but got I
		//IL_0325: Expected Obj, but got VT
		//IL_022c: Expected Obj, but got I
		//IL_023c: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected VT, but got Unknown
		//IL_0398: Expected Obj, but got I
		//IL_03a8: Expected VT, but got I
		//IL_03b8: Expected Obj, but got I
		//IL_03d2: Expected VT, but got I4
		//IL_027b: Expected VT, but got I4
		if (mode != (Mode)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = default;
		object obj4 = obj5 * obj5;
		object obj7 = default;
		object obj6 = obj7 * obj7;
		object obj8 = obj4 + obj6;
		object obj10 = default;
		object obj9 = obj10 * obj10;
		object obj11 = obj9 + obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)4.0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
			object obj12 = 0;
			mode = (Mode)0;
			Vector3 vector = (Vector3)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v8 (UnityEngine.Vector3)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj13 = !flag2;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 vector2 = FloorUnder(vector);
			Vector3 vector3 = default;
			standAt = vector3;
			Vector3 forward = head.forward;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v16+A0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v17+18]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v17+18]");
			object obj17 = num * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v17+1C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v17+1C]");
			object obj18 = num2 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
			object obj19 = 0;
			object obj20 = obj19;
			object obj21 = obj17 + obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v17+20]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v17+20]");
			object obj22 = num3 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v21+A0]");
			object obj23 = 0;
			object obj24 = obj22 + obj21;
			bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23);
			object obj26 = default;
			object obj25 = obj26;
			object obj28 = default;
			object obj27 = obj28;
			Vector3 vector4 = vector3;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v17+18]");
				object obj29 = vector3 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v17+1C]");
				object obj30 = obj28 * 0;
				object obj31 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v17+20]");
				obj5 = obj31 * 0;
				object obj32 = obj29 + obj30;
				object obj33 = obj5 + obj32;
				object obj34 = obj33 / obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v17+18]");
				object obj35 = 0 * obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v17+1C]");
				object obj36 = 0 * obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v17+20]");
				object obj37 = 0 * obj34;
				vector4 = vector3 - obj35;
				obj27 = obj28 - obj36;
				obj25 = obj26 - obj37;
				obj26 = obj36;
			}
			object obj38 = vector4 * vector4;
			object obj39 = obj27 * obj27;
			object obj40 = obj38 + obj39;
			object obj41 = obj25 * obj25;
			object obj42 = obj40 + obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			Quaternion quaternion;
			Quaternion rotation;
			if ((nint)obj42 <= 0)
			{
				quaternion = standFacing;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+DC]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+E0]");
				obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+E4]");
				obj5 = 0;
				rotation = (Quaternion)velocity;
			}
			else
			{
				object obj44 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v27+A0]");
				object obj45 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v28+18]");
				quaternion = (Quaternion)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v28+20]");
				object obj43 = 0;
				Vector3 forward2 = default;
				Vector3 upwards = default;
				Quaternion quaternion2 = Quaternion.Internal_LookRotation(ref forward2, ref upwards);
				rotation = (Quaternion)0;
			}
			standFacing = quaternion;
			if (Mine)
			{
				Transform transform = base.transform;
				transform.SetPositionAndRotation((Vector3)0, rotation);
			}
		}
		else
		{
			Die((Vector3)0, (byte)(int)velocity != 0);
		}
	}

	private void Punched(GoreSection section, Vector3 point, bool counts)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I4
		//IL_0124: Expected Obj, but got I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_02ca: Expected VT, but got I4
		//IL_01ae: Expected VT, but got I4
		//IL_01c0: Expected VT, but got I4
		//IL_01d5: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I4
		//IL_02d4: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I
		//IL_02ae: Expected Obj, but got I
		//IL_0329: Expected VT, but got I4
		if (mode == (Mode)3)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = tearing == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaWounds gillaWounds = GillaWounds.On(tearing);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (gillaWounds == null)
		{
			return;
		}
		object obj10 = point & 1;
		if (obj10 != null)
		{
			float radius = default;
			gillaWounds.Add(section, (Vector3)0, radius);
			gillaWounds.Burst(section, (Vector3)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
			object obj11 = 0;
			object obj12 = obj;
			object obj13 = obj11;
			int num = ++hits;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v11+A0]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v19+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj19;
			if ((UnityEngine.Object)obj14 != null)
			{
				object obj16 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v22+A0]");
				object obj17 = 0;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v24+80]");
				obj19 = 0;
			}
			else
			{
				obj19 = 3;
			}
			if (num >= (nint)obj19)
			{
				Die((Vector3)0, quiet: false);
			}
		}
		else
		{
			gillaWounds.AddSoon(section, (Vector3)1, burst: false);
		}
	}

	private void Stabbed(GoreSection section, Vector3 point, float radius, byte does)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I4
		//IL_0124: Expected Obj, but got I4
		//IL_0167: Expected VT, but got I4
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_0194: Expected VT, but got I4
		//IL_019d: Expected VT, but got I4
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_0214: Expected I4, but got VT
		//IL_0360: Expected VT, but got I4
		//IL_0232: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I4
		//IL_02ff: Expected Obj, but got I4
		//IL_02d4: Expected Obj, but got I
		//IL_02f1: Expected Obj, but got I
		if (mode == (Mode)3)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = tearing == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaWounds gillaWounds = GillaWounds.On(tearing);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = gillaWounds != null;
		bool flag7 = !flag6;
		Vector3 vector = (Vector3)0;
		GoreSection goreSection = (GoreSection)0;
		if (!flag7)
		{
			float radius2 = default;
			gillaWounds.Add(section, (Vector3)0, radius2);
			vector = (Vector3)0;
			goreSection = section;
		}
		object obj10 = point & 0xFF;
		if (obj10 == null)
		{
			return;
		}
		object obj11 = point & 0xFF;
		bool flag8 = (nint)obj11 == 2;
		int num = ++hits;
		bool quiet = (byte)(int)vector != 0;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
			object obj12 = 0;
			object obj13 = obj;
			object obj14 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v20+A0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v23+E4]");
			bool flag9 = (nint)0 == 0;
			object obj16 = !flag9;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj20;
			if ((UnityEngine.Object)obj15 != null)
			{
				object obj17 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v24+A0]");
				object obj18 = 0;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v26+80]");
				obj20 = 0;
			}
			else
			{
				obj20 = 3;
			}
			bool flag10 = num >= (nint)obj20;
			quiet = false;
			if (!flag10)
			{
				return;
			}
		}
		Die((Vector3)0, quiet);
	}

	private void Torn(ApePart part)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I4
		//IL_00e8: Expected VT, but got I4
		//IL_0148: Expected VT, but got I4
		if (mode == (Mode)3)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = tearing == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		bool flag4 = tearing.IsTorn(part);
		bool flag5 = !flag4;
		object obj5 = !flag5;
		if (obj5 == null)
		{
			Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
			tearing.Tear(part, (Vector3)0);
			if (part == 0)
			{
				Die((Vector3)0, quiet: false);
			}
		}
	}

	private void Ripped(PlayerRef by, byte seed, bool plusInRight, Quaternion rotRight, Quaternion rotLeft)
	{
		//IL_0016: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00cb: Expected VT, but got I4
		//IL_00ff: Expected Obj, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected VT, but got Unknown
		//IL_006d: Expected VT, but got I4
		//IL_006d: Expected VT, but got I4
		if (mode != (Mode)3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v8+A0]");
			object obj4 = 0;
			Die((Vector3)1, seed != 0);
			int bodyId = BodyId;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef playerRef = (PlayerRef)(by & 0xFFFFFFFFL);
			int seed2 = seed & 0xFF;
			IntPtr intPtr = default;
			bool flag2 = GillaCorpse.RipIt(playerRef, bodyId, seed2, plusInRight, (Quaternion)1, (Quaternion)0, (byte)(nint)intPtr != 0);
		}
	}

	private void Blown(Vector3 velocity, byte torn, bool apart, byte seed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0080: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I
		//IL_017f: Expected I, but got Obj
		//IL_018f: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I
		//IL_020f: Expected I, but got Obj
		//IL_0262: Expected Obj, but got I
		//IL_0273: Expected I, but got Obj
		//IL_02a2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0658]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GillaDynamite._003C_003Ec__DisplayClass87_0 obj2 = default;
		obj2._002Ector();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		if (mode == (Mode)3)
		{
			return;
		}
		bool flag = (byte)(~(blown ? 1u : 0u)) != 0;
		object obj4 = !flag;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = tearing == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		blown = true;
		int bodyId = BodyId;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj9 = 0;
		obj2.id = bodyId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0660]");
		object obj10 = 0;
		Action action = default;
		action._002Ector(obj2, (IntPtr)obj10);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v16+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaWounds.Later(action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0668]");
		object obj14 = 0;
		Action action2 = default;
		action2._002Ector(obj2, (IntPtr)obj14);
		GillaWounds.Later(action2);
		if ((torn & 1) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0670]");
			object obj15 = 0;
			Action action3 = default;
			action3._002Ector(obj2, (IntPtr)obj15);
			object obj16 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v24+E4]");
			bool flag6 = (nint)0 == 0;
			object obj17 = !flag6;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaWounds.Later(action3);
		}
	}

	private void EatenBy(MonsterBrain brain)
	{
		//IL_00f3: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		bool flag = mode == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = brain == null;
			bool flag4 = !flag3;
			object obj5 = !flag4;
			if (obj5 == null)
			{
				object obj6 = this + 176;
				obj6 = brain;
				_ = 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				float time = Time.time;
				_ = 3212836864L;
			}
		}
	}

	public static void BittenBy(MonsterBrain brain, bool arm)
	{
		//IL_0010: Expected Obj, but got I
		//IL_051d: Expected Obj, but got I4
		//IL_05d2: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I8
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00c0: Expected Obj, but got I4
		//IL_0544: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I4
		//IL_0151: Expected I, but got Obj
		//IL_0232: Expected Obj, but got I4
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0183: Expected I, but got Obj
		//IL_01ae: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I4
		//IL_0212: Expected I, but got Obj
		//IL_0397: Expected F4, but got I
		//IL_03b6: Expected I, but got Obj
		//IL_0298: Expected Obj, but got I
		//IL_02ba: Expected Obj, but got I4
		//IL_03ed: Expected Obj, but got I
		//IL_0414: Expected Obj, but got I4
		//IL_02f9: Expected I, but got Obj
		//IL_0453: Expected I, but got Obj
		//IL_0322: Expected Obj, but got I
		//IL_0340: Expected Obj, but got I4
		//IL_0345: Expected I, but got Obj
		//IL_034e: Expected Obj, but got I4
		//IL_047c: Expected Obj, but got I
		//IL_049a: Expected Obj, but got I4
		//IL_049f: Expected I, but got Obj
		//IL_0382: Expected Obj, but got I
		//IL_04d8: Expected Obj, but got I
		//IL_0562: Expected Obj, but got I
		//IL_059e: Expected Obj, but got I
		//IL_05b0: Expected VT, but got I4
		//IL_05b5: Expected I, but got Obj
		//IL_05bd: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB720]");
		object obj5 = 0;
		UnityEngine.Object obj6 = (UnityEngine.Object)obj5;
		System.__Canon[] array = ((List<System.__Canon>)obj4).ToArray();
		if (array.Length < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj8 = 0;
		object obj9 = array.Length & 0xFFFFFFFFL;
		object obj10 = array + 32;
		object obj11 = 0;
		while (true)
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
			object obj12 = !flag2;
			if (obj12 != null)
			{
				break;
			}
			object obj13 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X27_v4+v105 @ X25_v5*8]");
			UnityEngine.Object obj14 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj15 = !flag3;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X27_v4+v105 @ X25_v5*8]");
			bool flag4 = (UnityEngine.Object)0 == null;
			bool flag5 = !flag4;
			object obj16 = !flag5;
			nint num = unchecked((nint)null);
			obj6 = null;
			ApePart apePart;
			Dismemberment dismemberment;
			float num2;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X23_v5 (UnityEngine.Object)+98]");
				bool flag6 = (nint)0 != 2;
				num = unchecked((nint)null);
				obj6 = null;
				if (!flag6)
				{
					object obj17 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X23_v5 (UnityEngine.Object)+B0]");
					UnityEngine.Object obj18 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X0_v16+E4]");
					bool flag7 = (nint)0 == 0;
					object obj19 = !flag7;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag8 = obj18 != brain;
					bool flag9 = !flag8;
					num = unchecked((nint)null);
					obj6 = brain;
					if (flag9)
					{
						if (arm)
						{
							object obj20 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X23_v5 (UnityEngine.Object)+80]");
							obj18 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v33+E4]");
							bool flag10 = (nint)0 == 0;
							object obj21 = !flag10;
							if (obj21 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag11 = obj18 != null;
							bool flag12 = !flag11;
							num = unchecked((nint)null);
							obj6 = null;
							if (!flag12)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X23_v5 (UnityEngine.Object)+80]");
								bool flag13 = ((Dismemberment)0).IsTorn((ApePart)2);
								bool flag14 = !flag13;
								object obj22 = !flag14;
								num = unchecked((nint)null);
								obj6 = (UnityEngine.Object)2;
								if (obj22 == null)
								{
									object obj23 = obj8;
									apePart = (ApePart)2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X23_v5 (UnityEngine.Object)+80]");
									dismemberment = (Dismemberment)0;
									goto IL_0552;
								}
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X23_v5 (UnityEngine.Object)+BC]");
							num2 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X23_v5 (UnityEngine.Object)+BC]");
							bool flag15 = (nint)0 >= (nint)0;
							num = unchecked((nint)null);
							obj6 = brain;
							if (!flag15)
							{
								num2 = Time.time;
								object obj24 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X23_v5 (UnityEngine.Object)+80]");
								obj18 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v22+E4]");
								bool flag16 = (nint)0 == 0;
								object obj25 = !flag16;
								if (obj25 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag17 = obj18 != null;
								bool flag18 = !flag17;
								num = unchecked((nint)null);
								obj6 = null;
								if (!flag18)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X23_v5 (UnityEngine.Object)+80]");
									bool flag19 = ((Dismemberment)0).IsTorn((ApePart)0);
									bool flag20 = !flag19;
									object obj26 = !flag20;
									num = unchecked((nint)null);
									obj6 = null;
									if (obj26 == null)
									{
										object obj23 = obj8;
										apePart = (ApePart)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X23_v5 (UnityEngine.Object)+80]");
										dismemberment = (Dismemberment)0;
										goto IL_0552;
									}
								}
							}
						}
					}
				}
			}
			goto IL_0228;
			IL_0228:
			obj9 = array.Length;
			obj11++;
			if ((nint)obj11 >= array.Length)
			{
				return;
			}
			continue;
			IL_0552:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v17+A0]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v18+18]");
			float num3 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v18+18]");
			num2 = num3 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v18+20]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v18+20]");
			object obj28 = num4 + 0;
			dismemberment.Tear(apePart, (Vector3)0);
			num = unchecked((nint)null);
			obj6 = (UnityEngine.Object)apePart;
			goto IL_0228;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void Die(Vector3 velocity, bool quiet = default(bool))
	{
		//IL_0016: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_00a2: Expected VT, but got I
		//IL_00ab: Expected Obj, but got I4
		//IL_0449: Expected Obj, but got I
		//IL_0473: Expected Obj, but got I4
		//IL_04da: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected VT, but got Unknown
		//IL_01c7: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I4
		//IL_041b: Expected Obj, but got I4
		//IL_0434: Expected F4, but got I
		//IL_02b3: Expected Obj, but got I4
		//IL_02f8: Expected Obj, but got I4
		//IL_03a1: Expected Obj, but got I4
		//IL_03d6: Expected Obj, but got I
		//IL_03eb: Expected F4, but got I
		if (mode == (Mode)3)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		mode = (Mode)3;
		float time = Time.time;
		object obj2 = obj;
		goneAt = time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = tearing != null;
		bool flag3 = !flag2;
		IntPtr intPtr = default;
		Vector3 vector = (Vector3)(nint)intPtr;
		object obj4 = 0;
		bool flag4 = false;
		if (!flag3)
		{
			int bodyId = BodyId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			byte torn = NetworkApe.TornMask(tearing);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v15+E4]");
			bool flag6 = (nint)0 == 0;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			vector = (Vector3)(velocity & 1);
			GillaCorpse gillaCorpse = GillaCorpse.Make(tearing, bodyId, torn, vector, quiet: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
			object obj11 = 0;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v18+E4]");
			bool flag7 = (nint)0 == 0;
			object obj13 = !flag7;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaModeRound current = GillaModeRound.Current;
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v19+E4]");
			bool flag8 = (nint)0 == 0;
			object obj15 = !flag8;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (gillaCorpse != null)
			{
				object obj16 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v33+E4]");
				bool flag9 = (nint)0 == 0;
				object obj17 = !flag9;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag10 = (UnityEngine.Object)current == (UnityEngine.Object)null;
				bool flag11 = !flag10;
				object obj18 = !flag11;
				UnityEngine.Object obj19 = null;
				if (obj18 == null)
				{
					bool live = current.Live;
					bool flag12 = !live;
					obj19 = null;
					if (!flag12)
					{
						byte b = current.Phase;
						int num = b & 0xFF;
						bool flag13 = num == 1;
						obj19 = null;
						if (flag13)
						{
							goto IL_03f0;
						}
					}
				}
				object obj20 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v38+E4]");
				bool flag14 = (nint)0 == 0;
				object obj21 = !flag14;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj22 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v24+A0]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v25+10]");
				gillaCorpse.GoIn(0f);
			}
			goto IL_03f0;
		}
		goto IL_0439;
		IL_03f0:
		GameObject gameObject = tearing.gameObject;
		gameObject.SetActive(value: false);
		obj4 = 0;
		flag4 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v25+10]");
		time = 0f;
		goto IL_0439;
		IL_0439:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj24 = 0;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v11+E4]");
		bool flag15 = (nint)0 == 0;
		object obj26 = !flag15;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj24;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v11+A0]");
		object obj27 = 0;
		bool flag16 = ((List<System.__Canon>)obj27).Remove((System.__Canon)(object)this);
	}

	private void LateUpdate()
	{
		//IL_045b: Expected Obj, but got I
		//IL_046e: Expected VT, but got I
		//IL_01b6: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_01fd: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_007d: Expected VT, but got I4
		//IL_0235: Expected Obj, but got I4
		//IL_027c: Expected Obj, but got I4
		//IL_00b5: Expected VT, but got I4
		//IL_00be: Expected Obj, but got I4
		//IL_00c7: Expected VT, but got I4
		//IL_02b4: Expected Obj, but got I4
		//IL_0413: Expected Obj, but got I4
		//IL_02fb: Expected Obj, but got I4
		//IL_038f: Expected Obj, but got I4
		//IL_03b8: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		bool flag = (byte)(~(paintPending ? 1u : 0u)) != 0;
		IntPtr intPtr = default;
		Color color = (Color)(nint)intPtr;
		if (!flag)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v44+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = colour != null;
			bool flag4 = !flag3;
			object obj4 = 0;
			color = (Color)0;
			if (!flag4)
			{
				ApeColor apeColor = colour;
				paintPending = false;
				colour.SetColor((Color)0);
				obj4 = 0;
				color = (Color)0;
			}
		}
		if (this.mode == (Mode)3)
		{
			if (!Mine)
			{
				return;
			}
			float time = Time.time;
			float num = time - goneAt;
			if (!((double)num > 1.5))
			{
				return;
			}
			if (Live)
			{
				((SimulationBehaviour)this)._runner.Despawn(((SimulationBehaviour)this)._object);
				return;
			}
			GameObject obj5 = gameObject;
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v16+E4]");
			bool flag5 = (nint)0 == 0;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(obj5);
			return;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v6+E4]");
		bool flag6 = (nint)0 == 0;
		object obj9 = !flag6;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = head == null;
		bool flag8 = !flag7;
		object obj10 = !flag8;
		if (obj10 != null)
		{
			return;
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v10+E4]");
		bool flag9 = (nint)0 == 0;
		object obj12 = !flag9;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag10 = leftHand == null;
		bool flag11 = !flag10;
		object obj13 = !flag11;
		if (obj13 != null)
		{
			return;
		}
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v14+E4]");
		bool flag12 = (nint)0 == 0;
		object obj15 = !flag12;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag13 = rightHand == null;
		bool flag14 = !flag13;
		object obj16 = !flag14;
		if (obj16 != null)
		{
			return;
		}
		Mode mode = this.mode;
		if (this.mode == (Mode)1)
		{
			if (!Hold())
			{
				this.mode = (Mode)0;
				goto IL_049d;
			}
			mode = this.mode;
		}
		if (mode == (Mode)2)
		{
			bool flag15 = InJaws();
			bool flag16 = !flag15;
			object obj17 = !flag16;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
				Die((Vector3)0, quiet: false);
			}
		}
		if (this.mode != 0)
		{
			return;
		}
		goto IL_049d;
		IL_049d:
		Stand();
	}

	private void Stand()
	{
		//IL_0346: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_02b7: Expected VT, but got I4
		//IL_02ec: Expected VT, but got I4
		//IL_02ec: Expected VT, but got I4
		//IL_0309: Expected VT, but got I4
		//IL_0318: Expected VT, but got I4
		//IL_0318: Expected VT, but got I4
		//IL_0335: Expected VT, but got I4
		float time = Time.time;
		float num = time + phase;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		float num2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
		float num3 = num2 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C0B0]");
		object obj5 = default;
		object obj4 = 0 * obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		object obj6 = obj4 * (object)typeof(_0021_00210);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj7 = obj6 * (object)typeof(_0021_00210);
		Vector3 euler = default;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+E4]");
		object obj9 = default;
		object obj8 = 0 * obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+E0]");
		object obj11 = default;
		object obj10 = 0 * obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+E4]");
		object obj12 = 0 * typeof(_0021_00210);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+DC]");
		object obj13 = 0 * obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+E4]");
		object obj14 = 0 * obj11;
		object obj15 = standFacing * obj7;
		float num4 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC40]");
		float num5 = num4 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+E4]");
		object obj16 = 0 * obj7;
		object obj17 = obj8 + obj10;
		object obj18 = standFacing * typeof(_0021_00210);
		object obj19 = standFacing * obj11;
		object obj20 = obj12 + obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+E0]");
		object obj21 = 0 * obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+DC]");
		object obj22 = 0 * obj7;
		object obj23 = obj14 - obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+DC]");
		object obj24 = 0 * typeof(_0021_00210);
		float num6 = num5 + eyeHeight;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+E0]");
		object obj25 = 0 * typeof(_0021_00210);
		object obj26 = obj18 + obj17;
		object obj27 = obj16 + obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+DC]");
		object obj28 = 0 * obj9;
		object obj29 = obj21 + obj20;
		object obj30 = obj23 - obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+E0]");
		object obj31 = 0 * obj9;
		object obj32 = standFacing * obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X20_v2+20]");
		float num7 = 0f * num6;
		object obj33 = obj28 + obj27;
		object obj34 = obj30 - obj31;
		object obj35 = obj26 - obj22;
		object obj36 = obj33 - obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+D4]");
		float num8 = 0f + num7;
		object obj37 = obj29 - obj32;
		Quaternion rotation = default;
		head.SetPositionAndRotation((Vector3)0, rotation);
		float num9 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		float num10 = num9 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		Vector3 vector = (Quaternion)0 * (Vector3)0;
		leftHand.SetPositionAndRotation((Vector3)0, rotation);
		Vector3 vector2 = (Quaternion)0 * (Vector3)0;
		rightHand.SetPositionAndRotation((Vector3)0, rotation);
	}

	private unsafe bool Hold()
	{
		//IL_0010: Expected Obj, but got I
		//IL_06cc: Expected Obj, but got I4
		//IL_06f2: Expected Obj, but got I
		//IL_0714: Expected Obj, but got I4
		//IL_08e8: Expected Obj, but got I
		//IL_090a: Expected Obj, but got I4
		//IL_02d9: Expected Obj, but got I
		//IL_0303: Expected Obj, but got I4
		//IL_0359: Expected Obj, but got I4
		//IL_039c: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I4
		//IL_0799: Expected Obj, but got I4
		//IL_046e: Expected Obj, but got I4
		//IL_074c: Expected Obj, but got I4
		//IL_06a2: Expected I4, but got Obj
		//IL_0681: Expected Obj, but got I4
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected I4, but got Unknown
		//IL_0928: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I4
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_0400: Expected Obj, but got I4
		//IL_040a: Expected Obj, but got I4
		//IL_01e1: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I4
		//IL_04d0: Expected Obj, but got I4
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected Obj, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected Obj, but got Unknown
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected Obj, but got Unknown
		//IL_0420: Expected Obj, but got I4
		//IL_0283: Expected Obj, but got I
		//IL_084c: Expected Obj, but got I
		//IL_0864: Expected Obj, but got I
		//IL_086c: Expected VT, but got Obj
		//IL_087c: Expected Obj, but got I
		//IL_088c: Expected Obj, but got I
		//IL_07e1: Expected Obj, but got VT
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02b7: Expected Obj, but got I4
		//IL_0669: Expected VT, but got I4
		//IL_0671: Expected VT, but got Obj
		//IL_07b7: Expected Obj, but got I
		//IL_07cf: Expected Obj, but got I
		//IL_08b0: Expected VT, but got I4
		//IL_08b8: Expected VT, but got Ref
		//IL_0962: Expected Obj, but got I
		//IL_097f: Expected Obj, but got I
		//IL_098f: Expected Obj, but got I
		//IL_09ce: Expected Obj, but got I
		//IL_09de: Expected Obj, but got I
		//IL_09f8: Expected VT, but got Obj
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected Obj, but got Unknown
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected Obj, but got Unknown
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected Obj, but got Unknown
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected Obj, but got Unknown
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected Obj, but got Unknown
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected Obj, but got Unknown
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj8 != null;
		bool flag5 = !flag4;
		UnityEngine.Object obj10 = null;
		if (flag5)
		{
			goto IL_02c9;
		}
		bool live = Live;
		bool flag6 = !live;
		UnityEngine.Object obj11 = null;
		if (!flag6)
		{
			if ((object)((SimulationBehaviour)this)._runner == null)
			{
				goto IL_0694;
			}
			PlayerRef localPlayer = ((SimulationBehaviour)this)._runner.LocalPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj12 = 0;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v65+E4]");
			bool flag7 = (nint)0 == 0;
			object obj14 = !flag7;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag8 = holder != localPlayer;
			obj11 = null;
			obj10 = null;
			if (flag8)
			{
				goto IL_02c9;
			}
		}
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v67+E4]");
		bool flag9 = (nint)0 == 0;
		object obj16 = !flag9;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v71+E4]");
		bool flag10 = (nint)0 == 0;
		object obj18 = !flag10;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v71+A0]");
		object obj19 = 0;
		UnityEngine.Object obj27;
		UnityEngine.Object obj28;
		object obj31;
		Transform transform2;
		object obj25;
		UnityEngine.Object obj26;
		if (obj19 != null)
		{
			Transform transform = ((MonsterPlayer)obj19).HoldPoint(holderRight);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
			object obj20 = 0;
			object obj21 = obj5;
			object obj22 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X9_v11+A0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v57+E4]");
			bool flag11 = (nint)0 == 0;
			object obj24 = !flag11;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!((UnityEngine.Object)obj23 != null))
			{
				obj25 = 0;
				obj26 = null;
				obj27 = transform;
				obj28 = null;
				goto IL_076f;
			}
			object obj29 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v58+A0]");
			object obj30 = 0;
			if (obj30 != null)
			{
				obj31 = obj30 + 32;
				obj25 = 0;
				obj26 = null;
				transform2 = transform;
				goto IL_075a;
			}
		}
		goto IL_0694;
		IL_02c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj32 = 0;
		object obj33 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v52+E4]");
		bool flag12 = (nint)0 == 0;
		object obj34 = !flag12;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetworkApe networkApe = NetworkApe.Find(holder);
		object obj35 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v49+E4]");
		bool flag13 = (nint)0 == 0;
		object obj36 = !flag13;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = (UnityEngine.Object)networkApe != (UnityEngine.Object)null;
		bool flag15 = !flag14;
		obj25 = 0;
		obj26 = null;
		obj27 = null;
		obj28 = null;
		if (!flag15)
		{
			if ((object)networkApe == null)
			{
				goto IL_0694;
			}
			Transform transform3 = networkApe.HandOf(holderRight);
			obj31 = networkApe + 104;
			obj25 = 0;
			obj26 = (UnityEngine.Object)holderRight;
			transform2 = transform3;
			goto IL_075a;
		}
		goto IL_076f;
		IL_0694:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_076f:
		object obj37 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v11+E4]");
		bool flag16 = (nint)0 == 0;
		object obj38 = !flag16;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17 = obj27 == null;
		bool flag18 = !flag17;
		object obj39 = !flag18;
		if (obj39 == null)
		{
			if ((object)obj27 == null)
			{
				goto IL_0694;
			}
			Vector3 position = ((Transform)obj27).position;
			object obj40 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v19+E4]");
			bool flag19 = (nint)0 == 0;
			object obj41 = !flag19;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj43 = default;
			object obj42 = obj43 + heldEyes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+A4]");
			object obj45 = default;
			object obj44 = obj45 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDummy)+A8]");
			object obj47 = default;
			object obj46 = obj47 + 0;
			object obj54;
			Vector3 vector;
			object obj60;
			UnityEngine.Object obj61;
			if (obj28 != null)
			{
				if ((object)obj28 == null)
				{
					goto IL_0694;
				}
				Vector3 position2 = ((Transform)obj28).position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj48 = 0;
				object obj49 = obj48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X8_v34+A0]");
				object obj50 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v35+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v35+18]");
				object obj51 = num * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v35+1C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v35+1C]");
				object obj52 = num2 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
				object obj53 = 0;
				obj54 = obj45 - obj44;
				object obj55 = obj53;
				object obj56 = obj51 + obj52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v35+20]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v35+20]");
				object obj57 = num3 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X8_v39+A0]");
				object obj58 = 0;
				object obj59 = obj57 + obj56;
				vector = (Vector3)(obj43 - obj42);
				obj60 = obj47 - obj46;
				bool flag20 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj59) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj58);
				obj61 = null;
				if (!flag20)
				{
					Vector3 vector2 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v35+18]");
					object obj62 = vector2 * 0;
					object obj63 = obj54;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v35+1C]");
					object obj64 = obj63 * 0;
					object obj65 = obj60;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v35+20]");
					object obj66 = obj65 * 0;
					object obj67 = obj62 + obj64;
					object obj68 = obj66 + obj67;
					object obj69 = obj68 / obj59;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v35+18]");
					object obj70 = 0 * obj69;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v35+1C]");
					object obj71 = 0 * obj69;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v35+20]");
					object obj72 = 0 * obj69;
					vector -= obj70;
					obj54 -= obj71;
					obj60 -= obj72;
					obj61 = null;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj73 = 0;
				object obj74 = obj73;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v27+A0]");
				object obj75 = 0;
				vector = (Vector3)obj75;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v28+4]");
				obj54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v28+8]");
				obj60 = 0;
				obj61 = null;
			}
			object obj76 = vector * vector;
			object obj77 = obj54 * obj54;
			object obj78 = obj76 + obj77;
			object obj79 = obj60 * obj60;
			object obj80 = obj78 + obj79;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			Quaternion facing;
			Vector3 eyes;
			if ((nint)obj80 <= 0)
			{
				facing = (Quaternion)0;
				eyes = (Vector3)obj61;
			}
			else
			{
				Vector3 forward = default;
				Vector3 upwards = default;
				Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
				facing = (Quaternion)0;
				eyes = (Vector3)(&upwards);
			}
			Hang(eyes, facing);
		}
		object obj81 = !flag17;
		return (byte)(1 & obj81) != 0;
		IL_075a:
		obj28 = (UnityEngine.Object)obj31;
		obj27 = transform2;
		goto IL_076f;
	}

	private unsafe bool InJaws()
	{
		//IL_0010: Expected Obj, but got I
		//IL_047b: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0451: Expected I4, but got Obj
		//IL_00af: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got I4
		//IL_0112: Invalid comparison between F4 and I4
		//IL_0150: Invalid comparison between F4 and I
		//IL_0259: Expected Obj, but got I4
		//IL_02df: Expected Obj, but got I
		//IL_0301: Expected Obj, but got I4
		//IL_0410: Invalid comparison between F4 and I
		//IL_0435: Expected VT, but got I4
		//IL_043e: Expected VT, but got I4
		//IL_04a3: Expected VT, but got I4
		//IL_04ab: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = eater == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		float num2;
		Transform transform;
		if (obj4 == null)
		{
			MonsterBrain monsterBrain = eater;
			if ((object)eater != null)
			{
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v11+E4]");
				bool flag4 = (nint)0 == 0;
				object obj6 = !flag4;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = monsterBrain.grabSocket == null;
				bool flag6 = !flag5;
				object obj7 = !flag6;
				if (obj7 != null)
				{
					goto IL_0314;
				}
				if (!(biteAt < 0f))
				{
					float time = Time.time;
					float num = time - biteAt;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					if (num > 0f)
					{
						goto IL_0314;
					}
				}
				float time2 = Time.time;
				MonsterBrain monsterBrain2 = eater;
				if ((object)eater != null)
				{
					num2 = time2 - eatenAt;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
					if ((double)num2 > 1.0)
					{
						goto IL_0314;
					}
					if ((object)monsterBrain2.grabSocket != null)
					{
						Vector3 position = monsterBrain2.grabSocket.position;
						MonsterBrain monsterBrain3 = eater;
						if ((object)eater != null)
						{
							object obj8 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v19+E4]");
							bool flag7 = (nint)0 == 0;
							object obj9 = !flag7;
							if (obj9 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag8 = monsterBrain3.face != null;
							Component component = eater;
							if (flag8)
							{
								if ((object)eater != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v23 (UnityEngine.Component)+30]");
									transform = (Transform)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v23 (UnityEngine.Component)+30]");
									bool flag9 = (nint)0 == 0;
									object obj10 = !flag9;
									if (obj10 != null)
									{
										goto IL_036d;
									}
								}
							}
							else if ((object)eater != null)
							{
								transform = eater.transform;
								if ((object)transform != null)
								{
									goto IL_036d;
								}
							}
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_0314;
		IL_036d:
		Vector3 position2 = transform.position;
		double num3 = 1.0 - 1.0;
		float num4 = num2 - num2;
		float num5 = eatenAt - eatenAt;
		float num6 = num4 * num4;
		double num7 = num3 * num3;
		float num8 = num6 + (float)num7;
		float num9 = num5 * num5;
		float num10 = num9 + num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		Quaternion facing;
		Vector3 eyes;
		if (!(num10 > 0f))
		{
			facing = (Quaternion)0;
			eyes = (Vector3)0;
		}
		else
		{
			Vector3 forward = default;
			Vector3 upwards = default;
			Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
			facing = (Quaternion)0;
			eyes = (Vector3)(&upwards);
		}
		Hang(eyes, facing);
		return true;
		IL_0314:
		return false;
	}

	private void Hang(Vector3 eyes, Quaternion facing)
	{
		//IL_0014: Expected VT, but got I4
		//IL_0023: Expected VT, but got I4
		//IL_0023: Expected VT, but got I4
		//IL_0040: Expected VT, but got I4
		//IL_004f: Expected VT, but got I4
		//IL_004f: Expected VT, but got I4
		//IL_006c: Expected VT, but got I4
		head.SetPositionAndRotation((Vector3)0, facing);
		Vector3 vector = (Quaternion)0 * (Vector3)0;
		leftHand.SetPositionAndRotation((Vector3)0, facing);
		Vector3 vector2 = (Quaternion)0 * (Vector3)0;
		rightHand.SetPositionAndRotation((Vector3)0, facing);
	}

	private unsafe static Vector3 FloorUnder(Vector3 from)
	{
		//IL_00e3: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I
		//IL_0128: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I4
		//IL_0038: Expected VT, but got I8
		//IL_0038: Expected VT, but got Ref
		//IL_006e: Expected VT, but got I4
		//IL_0061: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v5+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v6+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		object obj5 = num * 0;
		object obj6 = obj4;
		object obj7 = default;
		float maxDistance = (float)obj7 + (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj9 = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		bool flag2 = Physics.Raycast((Vector3)(&obj9), (Vector3)4294961403L, out *(RaycastHit*)1, maxDistance, 0, queryTriggerInteraction);
		Vector3 result;
		if (flag2)
		{
			result = (Vector3)flag2;
		}
		else
		{
			result = (Vector3)flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		}
		return result;
	}

	public unsafe static GillaDummy Nearest(Vector3 at, float reach, out float away)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0bee: Expected native int or pointer, but got VT
		//IL_0c1d: Expected Obj, but got I4
		//IL_0df8: Expected Obj, but got I
		//IL_0e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e22: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got I
		//IL_008f: Expected F4, but got I
		//IL_0949: Expected Obj, but got I4
		//IL_0949: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Expected Obj, but got I4
		//IL_0d74: Expected Obj, but got I
		//IL_0d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d85: Expected Ref, but got Unknown
		//IL_0d9f: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I4
		//IL_0108: Expected I, but got Obj
		//IL_098c: Expected Obj, but got I4
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ac: Expected Obj, but got Unknown
		//IL_012a: Expected I, but got Obj
		//IL_015f: Expected Obj, but got I4
		//IL_0164: Expected I, but got Obj
		//IL_0b66: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got I4
		//IL_01f6: Expected I, but got Obj
		//IL_0abf: Expected Obj, but got I4
		//IL_0abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected I, but got Obj
		//IL_0244: Expected Obj, but got I
		//IL_0e5a: Expected Obj, but got I4
		//IL_029b: Invalid comparison between F4 and I4
		//IL_02aa: Invalid comparison between F4 and I4
		//IL_02bd: Expected Obj, but got F4
		//IL_02ca: Expected Obj, but got F4
		//IL_02ff: Expected Obj, but got I4
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		//IL_0389: Expected Obj, but got I
		//IL_03fe: Invalid comparison between F4 and I4
		//IL_0c7c: Expected F4, but got I4
		//IL_0c89: Expected I, but got Obj
		//IL_0c92: Expected Obj, but got I4
		//IL_041e: Expected F4, but got I4
		//IL_0440: Expected Obj, but got I
		//IL_0460: Expected Obj, but got I4
		//IL_04f3: Expected F4, but got I4
		//IL_0500: Expected I, but got Obj
		//IL_0476: Expected I, but got Obj
		//IL_0486: Expected Obj, but got I
		//IL_04a8: Expected F4, but got I4
		//IL_04b5: Expected I, but got Obj
		//IL_04c5: Expected Obj, but got I
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected Obj, but got Unknown
		//IL_0546: Expected Obj, but got I
		//IL_0602: Expected Obj, but got I8
		//IL_0622: Expected F4, but got I4
		//IL_062f: Expected I, but got Obj
		//IL_057b: Expected I, but got Obj
		//IL_058b: Expected Obj, but got I
		//IL_05b4: Expected Obj, but got I
		//IL_05bd: Expected F4, but got I4
		//IL_05ca: Expected I, but got Obj
		//IL_05da: Expected Obj, but got I
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected Obj, but got Unknown
		//IL_067d: Expected F4, but got I4
		//IL_0682: Expected I, but got Obj
		//IL_06aa: Expected Obj, but got I8
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected Obj, but got Unknown
		//IL_06d1: Expected F4, but got I4
		//IL_06ee: Expected I, but got Obj
		//IL_06ff: Expected Obj, but got I4
		//IL_0911: Expected native int or pointer, but got VT
		//IL_0e81: Expected Obj, but got I4
		//IL_071c: Expected Obj, but got I
		//IL_073e: Expected Obj, but got I4
		//IL_0cb0: Expected Obj, but got I
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Expected Obj, but got Unknown
		//IL_0d01: Expected I, but got Obj
		//IL_0d0e: Expected I, but got Obj
		//IL_07af: Expected I, but got Obj
		//IL_0d56: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj = 0;
		float x = default;
		((Vector3*)(nint)at)->x = x;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+A0]");
		object obj4 = 0;
		bool flag2 = obj4 == null;
		UnityEngine.Object obj6 = default;
		UnityEngine.Object obj5 = obj6;
		Enumerator<, > val = (Enumerator<, >)0;
		object obj7 = 109895680;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C58]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj9 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)obj4).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			obj7 = 0;
			float num2 = default;
			float num = num2;
			float num4 = default;
			float num3 = num4;
			UnityEngine.Object obj10 = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			float num5 = 0f;
			float num13;
			float num20;
			UnityEngine.Object obj29 = default;
			Enumerator<, > val2 = default;
			object obj51 = default;
			GillaDummy result2 = default;
			ArgumentNullException ex2 = default;
			NullReferenceException ex = default;
			object obj46;
			GillaDummy result;
			float num11 = default;
			Enumerator<, > val3;
			ref float reference;
			while (true)
			{
				UnityEngine.Object obj34;
				if (val.MoveNext())
				{
					object obj11 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v30+E4]");
					bool flag3 = (nint)0 == 0;
					object obj12 = !flag3;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = obj6 == null;
					bool flag5 = !flag4;
					object obj13 = !flag5;
					nint num6 = unchecked((nint)null);
					if (obj13 != null)
					{
						continue;
					}
					bool flag6 = (object)obj6 == null;
					num6 = unchecked((nint)null);
					UnityEngine.Object obj14 = null;
					if (flag6)
					{
						goto IL_09fb;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ stack_-C8 (UnityEngine.Object)+98]");
					bool flag7 = (nint)0 == 0;
					object obj15 = !flag7;
					num6 = unchecked((nint)null);
					if (obj15 != null)
					{
						continue;
					}
					object obj16 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ stack_-C8 (UnityEngine.Object)+68]");
					UnityEngine.Object obj17 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v50+E4]");
					bool flag8 = (nint)0 == 0;
					object obj18 = !flag8;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag9 = obj17 == null;
					bool flag10 = !flag9;
					object obj19 = !flag10;
					num6 = unchecked((nint)null);
					if (obj19 != null)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ stack_-C8 (UnityEngine.Object)+68]");
					bool flag11 = (nint)0 == 0;
					num6 = unchecked((nint)null);
					obj14 = null;
					if (!flag11)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ stack_-C8 (UnityEngine.Object)+68]");
						Vector3 position = ((Transform)0).position;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ stack_-C8 (UnityEngine.Object)+D0]");
						float num7 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
						float num8 = num7 + 0f;
						if (!(num2 < num8))
						{
							float num9 = num2 - num;
							bool flag12 = num9 < 0f;
							bool flag13 = num9 == 0f;
							object obj20 = num2 ^ num;
							object obj21 = num2 ^ num9;
							object obj22 = obj20 & obj21;
							bool flag14 = (nint)obj22 < 0;
							bool flag15 = flag12 == flag14;
							object obj23 = !flag15;
							object obj24 = obj23 | flag13;
							object obj25 = ~obj24;
							num8 = ((obj25 != null) ? num : num2);
						}
						object obj26 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X0_v57+E4]");
						bool flag16 = (nint)0 == 0;
						object obj27 = !flag16;
						if (obj27 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num10 = num11 - num5;
						float num12 = num2 - num8;
						num13 = num4 - num3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
						object obj28 = 0;
						float num14 = num10 * num10;
						float num15 = num12 * num12;
						float num16 = num14 + num15;
						float num17 = num13 * num13;
						float num18 = num17 + num16;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						float num19 = num18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A960]");
						num20 = num19 + 0f;
						bool flag17 = !(num20 < 0f);
						float num21 = (flag17 ? num20 : 0f);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						bool flag18 = (object)obj29 == null;
						num = 0f;
						obj17 = obj29;
						num6 = unchecked((nint)null);
						obj14 = (UnityEngine.Object)2;
						if (!flag18)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ stack_-C8 (UnityEngine.Object)+70]");
							UnityEngine.Object obj30 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ stack_-C8 (UnityEngine.Object)+70]");
							bool flag19 = (nint)0 == 0;
							UnityEngine.Object obj31 = (UnityEngine.Object)2;
							if (!flag19)
							{
								nint num22 = (nint)obj29;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v49 (Il2CppClass<UnityEngine.Object>)+40]");
								obj31 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag20 = ex == null;
								num = 0f;
								obj17 = obj29;
								num6 = unchecked((nint)null);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v49 (Il2CppClass<UnityEngine.Object>)+40]");
								obj14 = (UnityEngine.Object)0;
								if (flag20)
								{
									goto IL_0a71;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X0_v60 (UnityEngine.Object)+18]");
							bool flag21 = (nint)0 == 0;
							num = 0f;
							obj17 = obj29;
							num6 = unchecked((nint)null);
							obj14 = obj31;
							if (!flag21)
							{
								object obj32 = obj29 + 32;
								obj32 = obj30;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ stack_-C8 (UnityEngine.Object)+78]");
								UnityEngine.Object obj33 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ stack_-C8 (UnityEngine.Object)+78]");
								bool flag22 = (nint)0 == 0;
								obj14 = obj30;
								if (!flag22)
								{
									nint num23 = (nint)obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ X8_v48 (Il2CppClass<UnityEngine.Object>)+40]");
									obj14 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag23 = ex2 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ stack_-C8 (UnityEngine.Object)+78]");
									obj30 = (UnityEngine.Object)0;
									num = 0f;
									obj17 = obj29;
									num6 = unchecked((nint)null);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ X8_v48 (Il2CppClass<UnityEngine.Object>)+40]");
									obj34 = (UnityEngine.Object)0;
									if (flag23)
									{
										break;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X0_v60 (UnityEngine.Object)+18]");
								object obj35 = 0 & 0xFFFFFFFEL;
								bool flag24 = obj35 == null;
								obj30 = obj33;
								num = 0f;
								obj17 = obj29;
								num6 = unchecked((nint)null);
								if (!flag24)
								{
									object obj36 = obj29 + 40;
									obj36 = obj33;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X0_v60 (UnityEngine.Object)+18]");
									bool flag25 = (nint)0 < (nint)1;
									num = 0f;
									num6 = unchecked((nint)null);
									if (!flag25)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X0_v60 (UnityEngine.Object)+18]");
										object obj37 = 0 & 0xFFFFFFFFL;
										object obj38 = obj29 + 32;
										obj30 = obj33;
										float num24 = num21;
										float num25 = 0f;
										bool flag26 = flag17;
										float num26 = num8;
										float num27 = num13;
										nint num28 = unchecked((nint)null);
										obj14 = obj33;
										object obj39 = 0;
										while (true)
										{
											bool flag27 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj39) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj37);
											object obj40 = !flag27;
											if (obj40 == null)
											{
												object obj41 = obj9;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X28_v14+v524 @ X19_v18*8]");
												obj30 = (UnityEngine.Object)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X0_v74+E4]");
												bool flag28 = (nint)0 == 0;
												object obj42 = !flag28;
												if (obj42 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												bool flag29 = obj30 != null;
												bool flag30 = !flag29;
												num = num25;
												float num29 = num20;
												obj14 = null;
												if (!flag30)
												{
													bool flag31 = (object)obj30 == null;
													num28 = unchecked((nint)null);
													obj14 = null;
													if (flag31)
													{
														goto IL_09cd;
													}
													Vector3 position2 = ((Transform)obj30).position;
													object obj43 = obj7;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X0_v82+E4]");
													bool flag32 = (nint)0 == 0;
													object obj44 = !flag32;
													if (obj44 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													float num30 = num20 - num11;
													float num31 = num25 - num2;
													float num32 = num27 - num4;
													float num33 = num30 * num30;
													float num34 = num31 * num31;
													float num35 = num33 + num34;
													num = num32 * num32;
													num29 = num + num35;
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
													flag26 = !(num24 < num29);
													if (!flag26)
													{
														num26 = num27;
														num27 = num32;
														obj14 = null;
													}
													else
													{
														num24 = num29;
														num26 = num27;
														num27 = num32;
														obj14 = null;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X0_v60 (UnityEngine.Object)+18]");
												obj37 = 0;
												obj = obj39 + 1;
												object obj45 = obj;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X0_v60 (UnityEngine.Object)+18]");
												bool flag33 = (nint)obj45 < 0;
												obj33 = obj30;
												num21 = num24;
												flag17 = flag26;
												num8 = num26;
												num13 = num27;
												num6 = unchecked((nint)null);
												num25 = num;
												num28 = unchecked((nint)null);
												num20 = num29;
												obj39 = obj;
												if (!flag33)
												{
													break;
												}
												continue;
											}
											IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
											goto IL_09cd;
											IL_09cd:
											NullReferenceException ex4 = new NullReferenceException();
											num = num25;
											num3 = num27;
											num6 = num28;
											num5 = num20;
											goto IL_09fb;
										}
									}
									num5 = at.x;
									bool flag34 = !(num21 < at.x);
									obj30 = obj33;
									num3 = num13;
									obj17 = obj29;
									if (!flag34)
									{
										((Vector3*)(nint)at)->x = num21;
										obj30 = obj33;
										num3 = num13;
										obj17 = obj29;
										obj10 = obj6;
									}
									continue;
								}
								goto IL_0a19;
							}
							goto IL_0a27;
						}
						goto IL_0a35;
					}
					goto IL_0a53;
				}
				obj5 = null;
				obj46 = 0;
				val = val2;
				result = (GillaDummy)obj10;
				val3 = (Enumerator<, >)(ref val);
				object obj47 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C40]");
					object obj48 = 0;
					reference = ref *(float*)obj48;
					((Enumerator<, >*)val3)->Dispose();
					bool flag35 = obj47 == null;
					object obj49 = !flag35;
					num2 = num;
					num4 = num3;
					num11 = num5;
					if (obj49 == null)
					{
						bool flag36 = (object)obj5 == null;
						object obj50 = !flag36;
						num2 = num;
						num4 = num3;
						num11 = num5;
						OutOfMemoryException ex5 = (OutOfMemoryException)val3;
						if (obj50 == null)
						{
							return result;
						}
					}
					else
					{
						OutOfMemoryException ex5 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) == (void*)2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						num = num2;
						num3 = num4;
						obj5 = (UnityEngine.Object)1;
						num5 = num11;
						obj47 = obj46;
						continue;
					}
					if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != (void*)1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj47 = obj51;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					num = num2;
					num3 = num4;
					obj46 = obj51;
					num5 = num11;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D7A8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result2;
				IL_0a27:
				IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
				goto IL_0a35;
				IL_09fb:
				NullReferenceException ex7 = new NullReferenceException();
				num13 = num3;
				num20 = num5;
				goto IL_0a19;
				IL_0a71:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
				ex2 = new ArgumentNullException();
				obj34 = null;
				break;
				IL_0a19:
				IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
				goto IL_0a27;
				IL_0a53:
				ex = new NullReferenceException();
				num13 = num3;
				num20 = num5;
				goto IL_0a71;
				IL_0a35:
				NullReferenceException ex9 = new NullReferenceException();
				num3 = num13;
				num5 = num20;
				goto IL_0a53;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			ArgumentNullException ex10 = new ArgumentNullException();
			num2 = num;
			num4 = num13;
			obj5 = null;
			obj46 = 0;
			val = val2;
			result = (GillaDummy)obj10;
			num11 = num20;
			val3 = (Enumerator<, >)(ref val);
			reference = ref *(float*)null;
		}
		throw new NullReferenceException();
	}

	public unsafe bool PartNear(Vector3 hand, float reach, out ApePart part, out float away)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_047a: Expected native int or pointer, but got VT
		//IL_0487: Expected Ref, but got F4
		//IL_0471: Expected I4, but got Obj
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I8
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_011b: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_0450: Expected Obj, but got I4
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected I4, but got Unknown
		//IL_01b7: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I8
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_0208: Expected Obj, but got I4
		//IL_0211: Expected Obj, but got I4
		//IL_021a: Expected F4, but got I4
		//IL_0593: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I4
		//IL_0293: Expected Obj, but got I4
		//IL_04d2: Expected Obj, but got I
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected Obj, but got Unknown
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected Obj, but got Unknown
		//IL_02ee: Expected Obj, but got I4
		//IL_0316: Expected Obj, but got I
		//IL_0559: Expected Obj, but got I4
		//IL_03df: Expected Obj, but got I4
		//IL_03f6: Invalid comparison between F4 and I4
		//IL_041a: Expected Ref, but got F4
		//IL_042f: Expected F4, but got I
		//IL_042a: Expected native int or pointer, but got VT
		//IL_0438: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD140]");
		object obj2 = 0;
		((Vector3*)(nint)hand)->x = 0f;
		float num = default;
		ref ApePart reference = ref *(ApePart*)num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		(Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon) tuple = ((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0, (System.__Canon)(object)head);
		object obj3 = default;
		object obj12;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+18]");
			if ((nint)0 != 0)
			{
				object obj4 = obj3 + 40;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				(Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon) tuple2 = ((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)1, (System.__Canon)(object)leftHand);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+18]");
				object obj5 = 0 & 0xFFFFFFFEL;
				if (obj5 != null)
				{
					object obj6 = obj3 + 56;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					System.__Canon _Canon = (System.__Canon)(object)rightHand;
					(Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon) tuple3 = ((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)2, (System.__Canon)(object)rightHand);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+18]");
					bool flag = (nint)0 < (nint)2;
					object obj7 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+18]");
					object obj8 = -2;
					bool flag2 = obj8 == null;
					object obj9 = ~obj7;
					object obj10 = obj9 | flag2;
					if (obj10 == null)
					{
						object obj11 = obj3 + 72;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+18]");
						if ((nint)0 < (nint)1)
						{
							obj12 = 0;
							goto IL_0567;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+18]");
						object obj15 = 0 & 0xFFFFFFFFL;
						object obj16 = obj3 + 40;
						object obj18 = default;
						object obj17 = obj18;
						object obj20 = default;
						object obj19 = obj20;
						obj12 = 0;
						object obj21 = 0;
						float num2 = 0f;
						UnityEngine.Object obj22 = null;
						while (true)
						{
							bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15);
							object obj23 = !flag3;
							if (obj23 != null)
							{
								break;
							}
							object obj24 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v20+E4]");
							bool flag4 = (nint)0 == 0;
							object obj25 = !flag4;
							if (obj25 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag5 = (UnityEngine.Object)obj16 == null;
							bool flag6 = !flag5;
							object obj26 = !flag6;
							object obj27 = obj17;
							object obj28 = obj19;
							float num3 = num2;
							obj22 = null;
							if (obj26 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X29_v6-8]");
								bool flag7 = IsTorn((ApePart)0);
								bool flag8 = !flag7;
								object obj29 = !flag8;
								obj27 = obj17;
								obj28 = obj19;
								num3 = num2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X29_v6-8]");
								obj22 = (UnityEngine.Object)0;
								if (obj29 == null)
								{
									if (obj16 == null)
									{
										goto IL_0463;
									}
									Vector3 position = ((Transform)obj16).position;
									object obj30 = obj14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v30+E4]");
									bool flag9 = (nint)0 == 0;
									object obj31 = !flag9;
									if (obj31 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									float num4 = num2 - reach;
									object obj32 = obj19 - obj20;
									obj27 = obj17 - obj18;
									float num5 = num4 * num4;
									object obj33 = obj32 * obj32;
									float num6 = num5 + (float)obj33;
									object obj34 = obj27 * obj27;
									num3 = (float)obj34 + num6;
									obj28 = part;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
									bool flag10 = !(num3 < (float)part);
									obj22 = null;
									if (!flag10)
									{
										reference = ref *(ApePart*)num3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X29_v6-8]");
										((Vector3*)(nint)hand)->x = 0f;
										obj12 = 1;
										obj22 = null;
									}
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+18]");
							obj15 = 0;
							obj21++;
							obj16 += 16;
							object obj35 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+18]");
							bool flag11 = (nint)obj35 < 0;
							obj17 = obj27;
							obj19 = obj28;
							num2 = num3;
							_Canon = null;
							if (flag11)
							{
								continue;
							}
							goto IL_0567;
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		goto IL_0463;
		IL_0463:
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
		IL_0567:
		return (byte)(obj12 & 1) != 0;
	}

	public GillaDummy()
	{
		//IL_002b: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_004d: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v7+A0]");
		standFacing = (Quaternion)(object)0;
		base._002Ector();
	}

	static GillaDummy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0318: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0168: Expected Obj, but got I4
		//IL_017e: Expected Obj, but got I
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_0212: Expected Obj, but got I4
		//IL_0228: Expected Obj, but got I
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_02c5: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D06D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C85B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3+A0]");
		object obj5 = 0;
		obj5 = list;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+18]");
			bool flag = (nint)0 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F960]");
			_ = 0;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+18]");
				bool flag2 = (nint)0 < (nint)2;
				object obj7 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+18]");
				object obj8 = -2;
				bool flag3 = obj8 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F2C0]");
				_ = 0;
				object obj9 = ~obj7;
				object obj10 = obj9 | flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+18]");
					bool flag4 = (nint)0 == 3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F750]");
					_ = 0;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+18]");
						bool flag5 = (nint)0 < (nint)4;
						object obj11 = !flag5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+18]");
						object obj12 = -4;
						bool flag6 = obj12 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E4F0]");
						_ = 0;
						object obj13 = ~obj11;
						object obj14 = obj13 | flag6;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+18]");
							bool flag7 = (nint)0 == 5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E750]");
							_ = 0;
							if (!flag7)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+18]");
								bool flag8 = (nint)0 < (nint)6;
								object obj15 = !flag8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+18]");
								object obj16 = -6;
								bool flag9 = obj16 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107CD90]");
								_ = 0;
								object obj17 = ~obj15;
								object obj18 = obj17 | flag9;
								if (obj18 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+18]");
									bool flag10 = (nint)0 == 7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107FA80]");
									_ = 0;
									if (!flag10)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F970]");
										_ = 0;
										object obj19 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v9+A0]");
										object obj20 = (nint)0 + (nint)16;
										object obj21 = default;
										obj20 = obj21;
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
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public override void CopyBackingFieldsToState(bool P_0)
	{
		Rgb = _Rgb;
	}

	public override void CopyStateToBackingFields()
	{
		int rgb = Rgb;
		_Rgb = rgb;
	}

	protected unsafe static void RPC_Grab_0040Invoker847740543([In] ref RpcInvokeContext context)
	{
		//IL_0013: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I4
		//IL_01f5: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I
		//IL_025b: Expected Obj, but got I4
		//IL_026b: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_0125: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		//IL_00ae: Expected VT, but got Obj
		//IL_0159: Expected Obj, but got I
		//IL_0199: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out PlayerRef value, 4);
		rpcDataReader.Read(out NetworkBool value2, 4);
		rpcDataReader.Read(out Vector3 _, 12);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v10+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v7+18]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D05D8]");
			object obj7 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj7);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v122 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v9+A0]");
		object obj9 = 0;
		obj9 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaDummy gillaDummy = (GillaDummy)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj10 = 0;
		object obj11 = obj10;
		nint num = (nint)gillaDummy;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v14 (Il2CppClass<GillaDummy>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X1_v8+130]");
		bool flag2 = num2 < 0;
		object obj12 = !flag2;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v14 (Il2CppClass<GillaDummy>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X1_v8+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v17-8]");
			if (0 == (nint)obj11)
			{
				object obj15 = default;
				RpcInfo info = default;
				gillaDummy.RPC_Grab(value, value2, (Vector3)(&obj15), info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Release_0040Invoker4260040627([In] ref RpcInvokeContext context)
	{
		//IL_0011: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I
		//IL_0211: Expected Obj, but got I
		//IL_0231: Expected VT, but got I4
		//IL_023a: Expected VT, but got I4
		//IL_0260: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I4
		//IL_0279: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_0125: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I
		//IL_0095: Expected VT, but got Obj
		//IL_00c4: Expected VT, but got I
		//IL_00d7: Expected VT, but got I4
		//IL_0159: Expected Obj, but got I
		//IL_0195: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out Vector3 _, 12);
		rpcDataReader.Read(out Vector3 _, 12);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v9+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v7+18]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v7+18]");
		bool flag2 = (nint)0 == 0;
		Vector3 velocity = (Vector3)0;
		RpcInfo info = (RpcInfo)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D05E8]");
			object obj7 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj7);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X21_v3+28]");
			velocity = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ X21_v3+18] (should have been resolved before IL gen)");
			info = (RpcInfo)0;
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v9+A0]");
		object obj9 = 0;
		obj9 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaDummy gillaDummy = (GillaDummy)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj10 = 0;
		object obj11 = obj10;
		nint num = (nint)gillaDummy;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v14 (Il2CppClass<GillaDummy>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X1_v7+130]");
		bool flag3 = num2 < 0;
		object obj12 = !flag3;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v14 (Il2CppClass<GillaDummy>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X1_v7+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v17-8]");
			if (0 == (nint)obj11)
			{
				object obj15 = default;
				gillaDummy.RPC_Release((Vector3)(&obj15), velocity, info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Punch_0040Invoker3835533800([In] ref RpcInvokeContext context)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I4
		//IL_01e9: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I
		//IL_0229: Expected VT, but got I4
		//IL_024f: Expected Obj, but got I
		//IL_0258: Expected Obj, but got I4
		//IL_0268: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_0125: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I
		//IL_00a5: Expected VT, but got Obj
		//IL_00d7: Expected VT, but got I4
		//IL_0159: Expected Obj, but got I
		//IL_0195: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj2 = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out Vector3 _, 12);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v9+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v7+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v7+18]");
		bool flag2 = (nint)0 == 0;
		RpcInfo info = (RpcInfo)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D05F8]");
			object obj8 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj8);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ X21_v3+18] (should have been resolved before IL gen)");
			info = (RpcInfo)0;
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v9+A0]");
		object obj10 = 0;
		obj10 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaDummy gillaDummy = (GillaDummy)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaDummy;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14 (Il2CppClass<GillaDummy>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X1_v7+130]");
		bool flag3 = num2 < 0;
		object obj13 = !flag3;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14 (Il2CppClass<GillaDummy>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X1_v7+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				byte section = default;
				object obj16 = default;
				gillaDummy.RPC_Punch(section, (Vector3)(&obj16), info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Wound_0040Invoker2797674477([In] ref RpcInvokeContext context)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I4
		//IL_01e9: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I
		//IL_0229: Expected VT, but got I4
		//IL_024f: Expected Obj, but got I
		//IL_0258: Expected Obj, but got I4
		//IL_0268: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_0125: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I
		//IL_00a5: Expected VT, but got Obj
		//IL_00d7: Expected VT, but got I4
		//IL_0159: Expected Obj, but got I
		//IL_0195: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj2 = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out Vector3 _, 12);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v9+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v7+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v7+18]");
		bool flag2 = (nint)0 == 0;
		RpcInfo info = (RpcInfo)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0608]");
			object obj8 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj8);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ X21_v3+18] (should have been resolved before IL gen)");
			info = (RpcInfo)0;
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v9+A0]");
		object obj10 = 0;
		obj10 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaDummy gillaDummy = (GillaDummy)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaDummy;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14 (Il2CppClass<GillaDummy>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X1_v7+130]");
		bool flag3 = num2 < 0;
		object obj13 = !flag3;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14 (Il2CppClass<GillaDummy>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X1_v7+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				byte section = default;
				object obj16 = default;
				gillaDummy.RPC_Wound(section, (Vector3)(&obj16), info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Stab_0040Invoker1715877582([In] ref RpcInvokeContext context)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0022: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I4
		//IL_0280: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		//IL_0115: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I
		//IL_00c7: Expected VT, but got Obj
		//IL_0172: Expected Obj, but got I
		//IL_01b6: Expected F4, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj2 = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out Vector3 value, 12);
		rpcDataReader.Read(out float _, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v11+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v7+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0618]");
			object obj8 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj8);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v9+A0]");
		object obj10 = 0;
		obj10 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaDummy gillaDummy = (GillaDummy)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaDummy;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v14 (Il2CppClass<GillaDummy>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X1_v9+130]");
		bool flag2 = num2 < 0;
		object obj13 = !flag2;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v14 (Il2CppClass<GillaDummy>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X1_v9+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				byte section = default;
				Vector3 point = default;
				object obj16 = default;
				RpcInfo info = default;
				gillaDummy.RPC_Stab(section, point, (float)value, (byte)(&obj16), info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Tear_0040Invoker485164785([In] ref RpcInvokeContext context)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I
		//IL_01da: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_00dc: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		//IL_008d: Expected VT, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_0171: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj2 = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0628]");
			object obj8 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj8);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v96 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v9+A0]");
		object obj10 = 0;
		obj10 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaDummy gillaDummy = (GillaDummy)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaDummy;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v14 (Il2CppClass<GillaDummy>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X1_v6+130]");
		bool flag2 = num2 < 0;
		object obj13 = !flag2;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v14 (Il2CppClass<GillaDummy>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X1_v6+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				byte part = default;
				object obj16 = default;
				gillaDummy.RPC_Tear(part, (RpcInfo)(&obj16));
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Rip_0040Invoker3089612098([In] ref RpcInvokeContext context)
	{
		//IL_0011: Expected Obj, but got I
		//IL_0023: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I
		//IL_023e: Expected Obj, but got I
		//IL_024e: Expected Obj, but got I
		//IL_028b: Expected Obj, but got I
		//IL_0294: Expected Obj, but got I4
		//IL_02a4: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I
		//IL_0135: Expected I, but got Obj
		//IL_015e: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I
		//IL_00e7: Expected VT, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_01da: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj2 = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out PlayerRef value, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		rpcDataReader.Read(out NetworkBool value2, 4);
		rpcDataReader.Read(out Quaternion _, 16);
		rpcDataReader.Read(out Quaternion _, 16);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v12+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v7+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0638]");
			object obj8 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj8);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v143 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v9+A0]");
		object obj10 = 0;
		obj10 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaDummy gillaDummy = (GillaDummy)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaDummy;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v14 (Il2CppClass<GillaDummy>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X1_v10+130]");
		bool flag2 = num2 < 0;
		object obj13 = !flag2;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v14 (Il2CppClass<GillaDummy>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X1_v10+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				byte seed = default;
				object obj16 = default;
				Quaternion rotLeft = default;
				RpcInfo info = default;
				gillaDummy.RPC_Rip(value, seed, value2, (Quaternion)(&obj16), rotLeft, info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Blasted_0040Invoker2153976918([In] ref RpcInvokeContext context)
	{
		//IL_0011: Expected Obj, but got I
		//IL_0022: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I4
		//IL_0280: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		//IL_0115: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I
		//IL_00c7: Expected VT, but got Obj
		//IL_0172: Expected Obj, but got I
		//IL_01b6: Expected I4, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj2 = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out Vector3 _, 12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		rpcDataReader.Read(out NetworkBool value2, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v11+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v7+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0648]");
			object obj8 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj8);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v9+A0]");
		object obj10 = 0;
		obj10 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaDummy gillaDummy = (GillaDummy)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaDummy;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v14 (Il2CppClass<GillaDummy>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X1_v9+130]");
		bool flag2 = num2 < 0;
		object obj13 = !flag2;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v14 (Il2CppClass<GillaDummy>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X1_v9+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				Vector3 velocity = default;
				NetworkBool apart = default;
				object obj16 = default;
				RpcInfo info = default;
				gillaDummy.RPC_Blasted(velocity, (byte)(int)value2, apart, (byte)(&obj16), info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_Eaten_0040Invoker524838844([In] ref RpcInvokeContext context)
	{
		//IL_0011: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I4
		//IL_01c3: Expected Obj, but got I
		//IL_01d3: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I
		//IL_0221: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_00cd: Expected I, but got Obj
		//IL_00f6: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I
		//IL_007e: Expected VT, but got Obj
		//IL_012a: Expected Obj, but got I
		//IL_0162: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out NetworkId value, 4);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+18]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D06B8]");
			object obj7 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj7);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v96 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v9+A0]");
		object obj9 = 0;
		obj9 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaDummy gillaDummy = (GillaDummy)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj10 = 0;
		object obj11 = obj10;
		nint num = (nint)gillaDummy;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v14 (Il2CppClass<GillaDummy>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X1_v6+130]");
		bool flag2 = num2 < 0;
		object obj12 = !flag2;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v14 (Il2CppClass<GillaDummy>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X1_v6+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v17-8]");
			if (0 == (nint)obj11)
			{
				object obj15 = default;
				gillaDummy.RPC_Eaten(value, (RpcInfo)(&obj15));
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_SawBite_0040Invoker4161124152([In] ref RpcInvokeContext context)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0022: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I4
		//IL_0256: Expected Obj, but got I
		//IL_0266: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I4
		//IL_02cc: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I
		//IL_015d: Expected I, but got Obj
		//IL_0186: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I
		//IL_010f: Expected VT, but got Obj
		//IL_01ba: Expected Obj, but got I
		//IL_020a: Expected F4, but got VT
		//IL_020a: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj2 = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out Vector3 value, 12);
		rpcDataReader.Read(out float _, 4);
		rpcDataReader.Read(out Vector3 _, 12);
		rpcDataReader.Read(out Vector3 _, 12);
		rpcDataReader.Read(out Vector3 _, 12);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v14+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0678]");
			object obj8 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj8);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v149 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v9+A0]");
		object obj10 = 0;
		obj10 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaDummy gillaDummy = (GillaDummy)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaDummy;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v14 (Il2CppClass<GillaDummy>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X1_v12+130]");
		bool flag2 = num2 < 0;
		object obj13 = !flag2;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v14 (Il2CppClass<GillaDummy>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X1_v12+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				byte section = default;
				byte slot = default;
				object obj16 = default;
				Vector3 middle = default;
				Vector3 way = default;
				Vector3 half = default;
				RpcInfo info = default;
				gillaDummy.RPC_SawBite(section, slot, (Vector3)(&obj16), (float)value, middle, way, half, info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_SawThrough_0040Invoker3153123177([In] ref RpcInvokeContext context)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0022: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_0205: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I
		//IL_0225: Expected Obj, but got I
		//IL_0245: Expected VT, but got I4
		//IL_026b: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I4
		//IL_0284: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_0114: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I
		//IL_00bd: Expected VT, but got Obj
		//IL_00ef: Expected VT, but got I4
		//IL_0171: Expected Obj, but got I
		//IL_01b1: Expected F4, but got VT
		//IL_01b1: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj2 = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out Vector3 value, 12);
		rpcDataReader.Read(out float _, 4);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v10+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v7+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v7+18]");
		bool flag2 = (nint)0 == 0;
		RpcInfo info = (RpcInfo)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0688]");
			object obj8 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj8);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v123 @ X21_v3+18] (should have been resolved before IL gen)");
			info = (RpcInfo)0;
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v9+A0]");
		object obj10 = 0;
		obj10 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaDummy gillaDummy = (GillaDummy)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaDummy;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v14 (Il2CppClass<GillaDummy>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X1_v8+130]");
		bool flag3 = num2 < 0;
		object obj13 = !flag3;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v14 (Il2CppClass<GillaDummy>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X1_v8+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				byte section = default;
				object obj16 = default;
				gillaDummy.RPC_SawThrough(section, (Vector3)(&obj16), (float)value, info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	protected unsafe static void RPC_DoorCut_0040Invoker726025702([In] ref RpcInvokeContext context)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0022: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_0256: Expected Obj, but got I
		//IL_0266: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I4
		//IL_032a: Expected Obj, but got I
		//IL_0333: Expected Obj, but got I4
		//IL_0343: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I
		//IL_00c7: Expected VT, but got Obj
		//IL_0136: Expected Obj, but got I
		//IL_013e: Expected I4, but got Obj
		//IL_0146: Expected I, but got Obj
		//IL_016f: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I
		//IL_01ef: Expected F4, but got VT
		//IL_01ef: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj2 = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out Vector3 value, 12);
		rpcDataReader.Read(out float _, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v11+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v7+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v7+18]");
		bool flag2 = (nint)0 == 0;
		object obj9 = default;
		object obj8 = obj9;
		RpcChannel rpcChannel = (RpcChannel)0;
		RpcHostMode rpcHostMode = (RpcHostMode)0;
		object obj10 = 0;
		object obj12 = default;
		object obj11 = obj12;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D06C8]");
			object obj13 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj13);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X21_v3+28]");
			rpcChannel = (RpcChannel)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ X21_v3+18] (should have been resolved before IL gen)");
			object obj14 = default;
			obj8 = obj14;
			rpcHostMode = (RpcHostMode)(int)(&obj12);
			obj10 = 0;
			object obj15 = default;
			obj11 = obj15;
		}
		object obj16 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v9+A0]");
		object obj17 = 0;
		obj17 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaDummy gillaDummy = (GillaDummy)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
			object obj18 = 0;
			rpcHostMode = (RpcHostMode)obj18;
			nint num = (nint)gillaDummy;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v19 (Il2CppClass<GillaDummy>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X1_v8 (Fusion.RpcHostMode)+130]");
			bool flag3 = num2 < 0;
			object obj19 = !flag3;
			object obj20 = ~obj19;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v19 (Il2CppClass<GillaDummy>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X1_v8 (Fusion.RpcHostMode)+130]");
				object obj21 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v22-8]");
				if ((nint)0 == (nint)rpcHostMode)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
					byte seed = default;
					Vector3 normal = default;
					object obj22 = default;
					RpcInfo info = default;
					((GillaDummy)0).RPC_DoorCut(seed, normal, (float)value, (byte)(&obj22), info);
					return;
				}
			}
			InvalidCastException ex = new InvalidCastException();
		}
		throw new NullReferenceException();
	}
}
