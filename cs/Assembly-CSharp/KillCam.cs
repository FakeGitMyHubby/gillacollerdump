using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using GorillaLocomotion;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR;

public class KillCam : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass32_0
	{
		public Vector3 sum;

		public int n;
	}

	public static KillCam Local;

	public Transform head;

	public Player locomotion;

	public Rigidbody body;

	public DismemberGroup dismember;

	public float follow;

	public float holdAfterBite;

	public float fadeSeconds;

	public float blackSeconds;

	public float maxSeconds;

	public float faceTurnSeconds;

	public float heldEyesOver;

	private Vector3 heldEyes;

	public float thrownSpeed;

	public float slamSpeed;

	public float thrownSeconds;

	public float handsBackOver;

	public float launchGrace;

	public float heldEase;

	public int punchesToKill;

	public float downSeconds;

	public float shoveDownSeconds;

	public float downTip;

	public float downFall;

	public float downRise;

	public const float ThrowLimit = default(float);

	public const float NotHeldAfterBack = default(float);

	private int Hits__BackingField;

	private Vector3 DeathVelocity__BackingField;

	private bool BlownApart__BackingField;

	private bool Busy__BackingField;

	private bool Knocked__BackingField;

	[NonSerialized]
	public Transform respawnAt;

	private Transform onceAt;

	private static Action m_Died;

	private static Action m_Dying;

	private MonsterBrain Killer__BackingField;

	private bool FellInPit__BackingField;

	private Transform HeldBy__BackingField;

	private Transform heldFace;

	private bool heldBegun;

	private bool heldFaced;

	private bool dying;

	private Vector3 spawnPos;

	private Quaternion spawnRot;

	private float t;

	private float biteAt;

	private float fadeBack;

	private float backAt;

	private float blinkTill;

	private float twistLeft;

	private float twistRate;

	private Renderer fade;

	private Material fadeMat;

	private RigidbodyInterpolation interp;

	private bool restoreInterp;

	private float flying;

	private Vector3 flew;

	private float downLeft;

	private float tipped;

	private float eyesWere;

	private Vector3 downGoing;

	private Vector3 tipAxis;

	private const float EyesLying = default(float);

	private const float DownFriction = default(float);

	private const int Solid = default(int);

	private bool doorCut;

	private Vector3 doorCutNormal;

	private float doorCutOff;

	private byte doorCutBy;

	private const float GoreWait = default(float);

	private readonly List<Renderer> hiddenBody;

	public int Hits
	{
		get
		{
			return Hits__BackingField;
		}
		private set
		{
			Hits__BackingField = value;
		}
	}

	public Vector3 DeathVelocity
	{
		get
		{
			//IL_0002: Expected VT, but got Obj
			return (Vector3)this;
		}
		private set
		{
			Vector3 vector = default;
			DeathVelocity__BackingField = vector;
		}
	}

	public bool BlownApart
	{
		get
		{
			return BlownApart__BackingField;
		}
		private set
		{
			BlownApart__BackingField = value;
		}
	}

	public bool Busy
	{
		get
		{
			return Busy__BackingField;
		}
		private set
		{
			Busy__BackingField = value;
		}
	}

	public bool Knocked
	{
		get
		{
			return Knocked__BackingField;
		}
		private set
		{
			Knocked__BackingField = value;
		}
	}

	public MonsterBrain Killer
	{
		get
		{
			return Killer__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 192;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public bool FellInPit
	{
		get
		{
			return FellInPit__BackingField;
		}
		private set
		{
			FellInPit__BackingField = value;
		}
	}

	public Transform HeldBy
	{
		get
		{
			return HeldBy__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 208;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public bool IsDying => dying;

	public static event Action Died
	{
		add
		{
			//IL_0010: Expected Obj, but got I
			//IL_00a3: Expected Obj, but got I
			//IL_00b3: Expected Obj, but got I
			//IL_00c3: Expected Obj, but got I
			//IL_0052: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v4+8]");
			Delegate obj5 = (Delegate)0;
			Delegate obj9 = default;
			while (true)
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 != null && obj6 != obj4)
				{
					break;
				}
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X9_v3+A0]");
				object obj8 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag = (object)obj9 != obj5;
				obj5 = obj9;
				if (!flag)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_0010: Expected Obj, but got I
			//IL_00a3: Expected Obj, but got I
			//IL_00b3: Expected Obj, but got I
			//IL_00c3: Expected Obj, but got I
			//IL_0052: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v4+8]");
			Delegate obj5 = (Delegate)0;
			Delegate obj9 = default;
			while (true)
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 != null && obj6 != obj4)
				{
					break;
				}
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X9_v3+A0]");
				object obj8 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag = (object)obj9 != obj5;
				obj5 = obj9;
				if (!flag)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
	}

	public static event Action Dying
	{
		add
		{
			//IL_0010: Expected Obj, but got I
			//IL_00a3: Expected Obj, but got I
			//IL_00b3: Expected Obj, but got I
			//IL_00c3: Expected Obj, but got I
			//IL_0052: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v4+10]");
			Delegate obj5 = (Delegate)0;
			Delegate obj9 = default;
			while (true)
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 != null && obj6 != obj4)
				{
					break;
				}
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X9_v3+A0]");
				object obj8 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag = (object)obj9 != obj5;
				obj5 = obj9;
				if (!flag)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_0010: Expected Obj, but got I
			//IL_00a3: Expected Obj, but got I
			//IL_00b3: Expected Obj, but got I
			//IL_00c3: Expected Obj, but got I
			//IL_0052: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v4+10]");
			Delegate obj5 = (Delegate)0;
			Delegate obj9 = default;
			while (true)
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 != null && obj6 != obj4)
				{
					break;
				}
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X9_v3+A0]");
				object obj8 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag = (object)obj9 != obj5;
				obj5 = obj9;
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
		//IL_0010: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+A0]");
		object obj3 = 0;
		obj3 = this;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Vector3 vector = default;
		spawnPos = vector;
		Transform transform2 = base.transform;
		Quaternion rotation = transform2.rotation;
		spawnRot = (Quaternion)vector;
		BuildFade();
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
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
		bool flag2 = (UnityEngine.Object)obj5 == this;
		bool flag3 = !flag2;
		UnityEngine.Object obj7 = this;
		if (!flag3)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v9+A0]");
			object obj9 = 0;
			obj9 = 0;
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj7 = null;
		}
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (fadeMat != null)
		{
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v11+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(fadeMat);
		}
	}

	public bool Begin(MonsterBrain killer, Transform backTo = null)
	{
		//IL_011f: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00f6: Expected F4, but got I
		bool flag = (byte)(~(Busy__BackingField ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(head == null))
			{
				Freeze();
				object obj5 = this + 192;
				obj5 = killer;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj6 = this + 184;
				obj6 = backTo;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
				Buzz(0f, 0.25f);
				return true;
			}
		}
		return false;
	}

	public bool BeginHeld(Transform hand, Transform face, Vector3? eyesFromHand = null)
	{
		//IL_0034: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_0248: Expected Obj, but got I4
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_034b: Expected VT, but got F4
		//IL_036f: Expected F4, but got I
		//IL_02b6: Expected F4, but got I
		//IL_02c4: Expected F4, but got VT
		//IL_02d4: Expected F8, but got I
		if (~(Busy__BackingField ? 1u : 0u) != 0 || ~(Knocked__BackingField ? 1u : 0u) == 0)
		{
			bool flag = (byte)(~(dying ? 1u : 0u)) != 0;
			object obj = !flag;
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v5+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag3 = head == null;
				bool flag4 = !flag3;
				object obj5 = !flag4;
				if (obj5 == null)
				{
					object obj6 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v9+E4]");
					bool flag5 = (nint)0 == 0;
					object obj7 = !flag5;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = hand == null;
					bool flag7 = !flag6;
					object obj8 = !flag7;
					if (obj8 == null)
					{
						float time = Time.time;
						float num = time - backAt;
						if (!((double)num < 3.0))
						{
							if (~(Knocked__BackingField ? 1u : 0u) == 0)
							{
								Knocked__BackingField = false;
								t = 0f;
							}
							else
							{
								Freeze();
							}
							object obj9 = this + 208;
							obj9 = hand;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj10 = this + 216;
							obj10 = face;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj11 = obj2;
							_ = 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v20+E4]");
							bool flag8 = (nint)0 == 0;
							object obj12 = !flag8;
							if (obj12 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag9 = face != null;
							object obj13 = (_003F?)eyesFromHand & 0xFF;
							bool flag10 = obj13 == null;
							heldFaced = flag9;
							float num5;
							if (!flag10)
							{
								nint num3 = default;
								float num2 = num3 >> 32;
								float num4 = (_003F?)eyesFromHand >> 32;
								num5 = num4;
								double num6 = num3;
								float num7 = num2;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
								num5 = num * heldEyesOver;
								double num6 = 3.0 * (double)heldEyesOver;
								object obj14 = default;
								float num7 = (float)obj14 * heldEyesOver;
							}
							heldEyes = (Vector3)num5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
							Buzz(0f, 0.25f);
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	public void EndHeld(Vector3 velocity)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I4
		//IL_007d: Expected VT, but got I4
		//IL_007d: Expected VT, but got I4
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
		Transform transform;
		if (head != null)
		{
			transform = head;
		}
		else
		{
			transform = base.transform;
			bool flag2 = (object)transform == null;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				throw new NullReferenceException();
			}
		}
		Vector3 position = transform.position;
		EndHeld((Vector3)0, (Vector3)0);
	}

	public void EndHeld(Vector3 eyesAt, Vector3 velocity)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_013a: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I4
		//IL_022c: Expected VT, but got I4
		//IL_022c: Expected VT, but got I4
		//IL_01ed: Expected Obj, but got I4
		//IL_02c9: Expected VT, but got I
		//IL_02c9: Expected VT, but got I4
		//IL_02c9: Expected VT, but got I4
		//IL_0421: Expected Obj, but got I
		//IL_044b: Expected Obj, but got I4
		//IL_02ef: Expected Obj, but got VT
		//IL_0337: Invalid comparison between Obj and F4
		//IL_0395: Expected Obj, but got I4
		if (~(Busy__BackingField ? 1u : 0u) != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = HeldBy__BackingField == null;
		bool flag3 = !flag2;
		object obj4 = 0;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v44+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = heldFace == null;
			bool flag6 = !flag5;
			object obj8 = !flag6;
			obj4 = 0;
			obj5 = null;
			if (obj8 != null)
			{
				return;
			}
		}
		bool flag7 = (byte)(~(dying ? 1u : 0u)) != 0;
		object obj9 = !flag7;
		if (obj9 != null)
		{
			return;
		}
		Tip(0f);
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v9+E4]");
		bool flag8 = (nint)0 == 0;
		object obj11 = !flag8;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform transform;
		if (heldFace != null)
		{
			transform = heldFace;
			bool flag9 = (object)heldFace == null;
			object obj12 = !flag9;
			if (obj12 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			transform = head;
		}
		Vector3 position = transform.position;
		Vector3 vector = Unblocked((Vector3)0, (Vector3)0);
		Transform transform2 = base.transform;
		Vector3 position2 = transform2.position;
		Vector3 position3 = head.position;
		Transform transform3 = base.transform;
		object obj14 = default;
		object obj13 = obj14 + obj14;
		object obj16 = default;
		object obj15 = obj16 + obj16;
		object obj17 = obj13 - obj14;
		object obj18 = obj15 - obj16;
		Quaternion rotation = transform3.rotation;
		IntPtr intPtr = default;
		Release((Vector3)0, (Quaternion)0, (Vector3)(nint)intPtr);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj19 = 0;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v29+E4]");
		bool flag10 = (nint)0 == 0;
		object obj21 = !flag10;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 vector2 = default;
		object obj22 = vector2 * vector2;
		object obj24 = default;
		object obj23 = obj24 * obj24;
		object obj25 = obj22 + obj23;
		object obj27 = default;
		object obj26 = obj27 * obj27;
		object obj28 = obj26 + obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)thrownSpeed))
		{
			object obj29 = obj;
			flew = vector2;
			flying = thrownSeconds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v31+E4]");
			bool flag11 = (nint)0 == 0;
			object obj30 = !flag11;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (locomotion != null)
			{
				locomotion.enabled = false;
			}
		}
	}

	private unsafe void FixedUpdate()
	{
		//IL_06c2: Invalid comparison between F4 and I4
		//IL_06d3: Expected Obj, but got I4
		//IL_06de: Invalid comparison between F4 and I4
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected Obj, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I4
		//IL_071d: Expected Obj, but got I
		//IL_0735: Expected Obj, but got I
		//IL_073d: Expected F4, but got Obj
		//IL_074d: Expected F4, but got I
		//IL_075d: Expected F4, but got I
		//IL_0765: Expected F4, but got Obj
		//IL_0a28: Expected Obj, but got I
		//IL_0a52: Expected Obj, but got I4
		//IL_078e: Expected Obj, but got I
		//IL_07e5: Expected Obj, but got I4
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected Obj, but got Unknown
		//IL_0832: Expected Obj, but got I4
		//IL_0ae3: Invalid comparison between F4 and I4
		//IL_0af2: Invalid comparison between F4 and I4
		//IL_0b05: Expected Obj, but got F8
		//IL_0b12: Expected Obj, but got F4
		//IL_0b3e: Expected F4, but got I
		//IL_0b57: Expected Obj, but got I4
		//IL_0b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b64: Expected Obj, but got Unknown
		//IL_0187: Expected F4, but got I
		//IL_0852: Invalid comparison between VT and F4
		//IL_01b6: Expected Obj, but got I4
		//IL_0983: Expected Obj, but got I
		//IL_09a5: Expected Obj, but got I
		//IL_09db: Expected Obj, but got I
		//IL_0a03: Expected VT, but got F4
		//IL_03e8: Expected VT, but got F4
		//IL_03f1: Invalid comparison between F4 and I4
		//IL_0496: Invalid comparison between F4 and I4
		//IL_054b: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got I4
		//IL_0283: Expected Obj, but got I4
		//IL_0293: Expected F4, but got I
		//IL_04c4: Invalid comparison between VT and F8
		//IL_08da: Expected VT, but got I8
		//IL_08da: Expected VT, but got Ref
		//IL_0921: Expected Obj, but got I8
		//IL_02bb: Expected F4, but got I
		//IL_05a5: Expected Obj, but got I
		//IL_05cf: Expected Obj, but got I4
		//IL_02d9: Expected Obj, but got F4
		//IL_032d: Invalid comparison between F4 and I4
		//IL_033c: Invalid comparison between F4 and I4
		//IL_034f: Expected Obj, but got F4
		//IL_035c: Expected Obj, but got F4
		//IL_0391: Expected Obj, but got I4
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_060f: Expected Obj, but got I4
		//IL_096e: Expected Obj, but got I8
		float num = flying;
		bool flag = flying < 0f;
		object obj = !flag;
		bool flag2 = flying == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		if (obj3 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		float fixedDeltaTime = Time.fixedDeltaTime;
		object obj5 = obj4;
		float num2 = (flying -= fixedDeltaTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num3;
		float num4;
		float num5 = default;
		if (body != null)
		{
			Vector3 linearVelocity = body.linearVelocity;
			num3 = num2;
			num4 = num5;
			UnityEngine.Object obj7 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v41+A0]");
			object obj10 = 0;
			num2 = (float)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v42+4]");
			num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v42+8]");
			num4 = 0f;
			num3 = (float)obj10;
			UnityEngine.Object obj7 = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		float num6 = num;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num6 = num;
		}
		float num7 = num6 * num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj14 = 0;
		float num8 = num4 * num4;
		float num9 = num3 * num3;
		object obj15 = obj14;
		float num10 = num9 + num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num11 = num8 + num10;
		Vector3 gravity = Physics.gravity;
		float num12 = fixedDeltaTime * num7;
		float num13 = fixedDeltaTime * num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KillCam)+144]");
		float num14 = 0f + num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj17 = obj11;
		object obj18 = this + 316;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v17+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		float num15 = num;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num15 = num;
		}
		object obj20 = obj18 * obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KillCam)+144]");
		float num16 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KillCam)+144]");
		float num17 = num16 * 0f;
		float num18 = (float)obj20 + num17;
		double num19 = (double)num18 * 0.25;
		float num20 = num11 - (float)num19;
		bool flag7 = num20 < 0f;
		bool flag8 = num20 == 0f;
		object obj21 = (double)num11 ^ num19;
		object obj22 = num11 ^ num20;
		object obj23 = obj21 & obj22;
		bool flag9 = (nint)obj23 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		float num21 = 0f;
		bool flag10 = flag7 == flag9;
		object obj24 = !flag8;
		object obj25 = flag10 & obj24;
		object obj26 = ~obj25;
		float num22;
		if (obj26 == null)
		{
			num22 = num4;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KillCam)+144]");
			num22 = 0f;
		}
		bool flag11 = flew <= (object)num21;
		double num23 = 0.25;
		ref RaycastHit reference = ref *(RaycastHit*)null;
		if (!flag11)
		{
			object obj27 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v41+E4]");
			bool flag12 = (nint)0 == 0;
			object obj28 = !flag12;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag13 = head != null;
			bool flag14 = !flag13;
			num23 = 0.25;
			reference = ref *(RaycastHit*)null;
			UnityEngine.Object obj7 = null;
			if (!flag14)
			{
				Vector3 position = head.position;
				float num24 = num4 / (float)flew;
				object obj29 = obj14;
				float num25 = num3 / (float)flew;
				float num26 = num / (float)flew;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X0_v48+E4]");
				bool flag15 = (nint)0 == 0;
				object obj30 = !flag15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KillCam)+144]");
				float radius = 0f;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KillCam)+144]");
					radius = 0f;
				}
				float num27 = fixedDeltaTime * (float)flew;
				float num28 = num27 + num27;
				float num29 = num28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				float num30 = num29 + 0f;
				object obj31 = default;
				QueryTriggerInteraction queryTriggerInteraction = default;
				bool flag16 = Physics.SphereCast((Vector3)(&obj31), radius, (Vector3)4294961403L, out *(RaycastHit*)1, num21, 0, queryTriggerInteraction);
				bool flag17 = !flag16;
				int num31 = 0;
				float num32 = num24;
				num23 = 0.25;
				reference = ref *(RaycastHit*)1;
				obj7 = (UnityEngine.Object)4294961403L;
				if (!flag17)
				{
					float num33 = 0f * num;
					object obj32 = 0f - num33;
					object obj33 = default;
					float num34 = num3 * (float)obj33;
					float num35 = (float)obj32 - num34;
					double num37 = default;
					double num36 = (double)num4 * num37;
					float num38 = num35 - (float)num36;
					float num39 = num14 - num38;
					bool flag18 = num39 < 0f;
					bool flag19 = num39 == 0f;
					object obj34 = num14 ^ num38;
					object obj35 = num14 ^ num39;
					object obj36 = obj34 & obj35;
					bool flag20 = (nint)obj36 < 0;
					bool flag21 = flag18 == flag20;
					object obj37 = !flag19;
					object obj38 = flag21 & obj37;
					object obj39 = ~obj38;
					if (obj39 != null)
					{
						num14 = num38;
					}
					num31 = 0;
					num32 = num24;
					num15 = num;
					num23 = num37;
					num21 = (float)num36;
					reference = ref *(RaycastHit*)1;
					obj7 = (UnityEngine.Object)4294961403L;
					goto IL_0b7b;
				}
			}
			num15 = num;
		}
		goto IL_0b7b;
		IL_0516:
		object obj40 = obj4;
		flying = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X0_v26+E4]");
		bool flag22 = (nint)0 == 0;
		object obj41 = !flag22;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (locomotion != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj42 = 0;
			object obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v30+E4]");
			bool flag23 = (nint)0 == 0;
			object obj44 = !flag23;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isMonster = MonsterPlayer.IsMonster;
			bool flag24 = !isMonster;
			object obj45 = !flag24;
			if (obj45 == null)
			{
				locomotion.InitializeValues();
				locomotion.enabled = true;
			}
		}
		return;
		IL_0b7b:
		if (num14 < slamSpeed)
		{
			flew = (Vector3)num3;
			float reach;
			double num42;
			if (num15 < 0f)
			{
				float num40 = fixedDeltaTime * num15;
				num21 = handsBackOver;
				float num41 = num40 + num40;
				reach = handsBackOver - num41;
				bool flag25 = HandNearFloor(reach);
				bool flag26 = !flag25;
				object obj46 = !flag26;
				num42 = handsBackOver;
				if (obj46 != null)
				{
					goto IL_0516;
				}
			}
			reach = flying;
			bool flag27 = !(flying > 0f);
			num42 = num21;
			if (!flag27)
			{
				if (flew > (object)1.5)
				{
					return;
				}
				num23 = thrownSeconds;
				num42 = (double)thrownSeconds + -0.25;
				if ((double)flying > num42)
				{
					return;
				}
			}
			goto IL_0516;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		flying = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		float num43 = num22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		float num44 = num43 * 0f;
		float num45 = slamSpeed * num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj48 = obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v22+A0]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v23+18]");
		float num46 = 0f * slamSpeed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v23+20]");
		nint num47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		object obj50 = num47 * 0;
		float num48 = num46 - num45;
		float num49 = (float)obj50 - num44;
		DeathVelocity__BackingField = (Vector3)num48;
		Die(tearHead: false);
	}

	private bool HandNearFloor(float reach)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0317: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_02ed: Expected I4, but got Obj
		//IL_00ad: Expected Obj, but got I8
		//IL_00e4: Expected Obj, but got I8
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_013c: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I
		//IL_0155: Expected Obj, but got I4
		//IL_0360: Expected Obj, but got I4
		//IL_033d: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I
		//IL_0207: Expected Obj, but got I
		//IL_0250: Expected VT, but got I4
		//IL_0250: Expected VT, but got I8
		//IL_026e: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
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
		bool flag2 = locomotion == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			goto IL_02c3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj6 = default;
		if (obj6 == null)
		{
			goto IL_02d1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v11+18]");
		object obj7 = 0 & 0xFFFFFFFEL;
		bool flag6;
		if (obj7 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v11+18]");
			object obj8 = 0 & 0xFFFFFFFFL;
			_ = 1;
			if ((nint)obj8 < 1)
			{
				goto IL_02c3;
			}
			object obj9 = obj6 + 32;
			float num = reach;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
			float num2 = num + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
			object obj11 = 0;
			object obj12 = 0;
			float num3 = num2;
			object obj21 = default;
			object obj22 = default;
			QueryTriggerInteraction queryTriggerInteraction = default;
			while (true)
			{
				bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
				object obj13 = !flag4;
				if (obj13 != null)
				{
					break;
				}
				if ((object)locomotion == null)
				{
					goto IL_02d1;
				}
				Player player = locomotion;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X25_v5+v173 @ X23_v6]");
				Vector3 vector = player.HandNow(right: false);
				object obj14 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v14+A0]");
				object obj15 = 0;
				object obj16 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v21+E4]");
				bool flag5 = (nint)0 == 0;
				object obj17 = !flag5;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v16+18]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
				object obj18 = num4 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v16+1C]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
				object obj19 = num5 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v16+20]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
				object obj20 = num6 * 0;
				num3 += (float)obj18;
				obj21 += obj19;
				obj22 += obj20;
				flag6 = Physics.Raycast((Vector3)4294961403L, (Vector3)1, num3, 0, queryTriggerInteraction);
				bool flag7 = !flag6;
				object obj23 = !flag7;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v11+18]");
					obj8 = 0;
					obj12++;
					object obj24 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v11+18]");
					if ((nint)obj24 < 0)
					{
						continue;
					}
				}
				goto IL_0342;
			}
		}
		goto IL_02df;
		IL_02c3:
		flag6 = false;
		goto IL_0342;
		IL_0342:
		return flag6;
		IL_02d1:
		NullReferenceException ex = new NullReferenceException();
		goto IL_02df;
		IL_02df:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	public void Slammed(Vector3 going)
	{
		if (~(dying ? 1u : 0u) != 0)
		{
			Vector3 vector = default;
			DeathVelocity__BackingField = vector;
			Die(tearHead: false);
		}
	}

	public bool KnockDown(Vector3 going, float downFor = default(float))
	{
		//IL_0010: Expected Obj, but got I
		//IL_0438: Expected VT, but got F4
		//IL_045f: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got I4
		//IL_0421: Expected I4, but got Obj
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_027b: Expected Obj, but got F4
		//IL_02bc: Expected VT, but got I4
		//IL_02bc: Expected Obj, but got VT
		//IL_0476: Invalid comparison between F4 and I4
		//IL_033f: Expected Obj, but got I
		//IL_034f: Invalid comparison between F4 and I
		//IL_0371: Expected VT, but got I4
		//IL_051c: Expected VT, but got Obj
		//IL_0544: Expected VT, but got F4
		//IL_03ef: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		float num = default;
		DeathVelocity__BackingField = (Vector3)num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = head == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null && ~(dying ? 1u : 0u) != 0 && (~(Busy__BackingField ? 1u : 0u) != 0 || ~(Knocked__BackingField ? 1u : 0u) == 0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isMonster = MonsterPlayer.IsMonster;
			bool flag5 = !isMonster;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
				object obj9 = 0;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v13+E4]");
				bool flag6 = (nint)0 == 0;
				object obj11 = !flag6;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool outOfHunt = GillaMapVote.OutOfHunt;
				bool flag7 = !outOfHunt;
				object obj12 = !flag7;
				if (obj12 == null)
				{
					float time = Time.time;
					float num2 = time - backAt;
					if (!((double)num2 < 3.0))
					{
						object obj14 = default;
						if (~(Knocked__BackingField ? 1u : 0u) == 0)
						{
							object obj13 = this + 340;
							double num3 = (double)obj14 * 0.5;
							float num4 = num * 63f;
							double num5 = num3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KillCam)+15C]");
							double num6 = num5 + 0.0;
							float num7 = num4 + (float)obj13;
							obj13 = num7;
						}
						else
						{
							if ((object)head == null)
							{
								goto IL_0413;
							}
							Vector3 position = head.position;
							float num8 = ((KillCam)position).EyesOverFloor((Vector3)0);
							eyesWere = num8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2ECCDCC");
							float num9 = num * num;
							object obj16 = default;
							object obj15 = obj16 * obj16;
							float num10 = num9 + (float)obj15;
							object obj17 = obj14 * obj14;
							float num11 = (float)obj17 + num10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
							object obj18 = 0;
							float num12 = num11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
							bool flag8 = !(num12 < 0f);
							float num13 = num;
							object obj19 = obj14;
							Vector3 vector = (Vector3)0;
							if (!flag8)
							{
								if ((object)head == null)
								{
									goto IL_0413;
								}
								Vector3 forward = head.forward;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2ECCDCC");
								num13 = num;
								obj19 = obj14;
								obj18 = obj16;
								num11 = num;
								vector = (Vector3)0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
							object obj20 = obj16 * obj14;
							object obj21 = obj14 * obj16;
							float num14 = (float)obj14 * num;
							float num15 = num * (float)obj14;
							tipped = 0f;
							float num16 = num * (float)obj16;
							float num17 = (float)obj16 * num;
							Vector3 vector2 = (Vector3)(obj20 - obj21);
							float num18 = num14 - num15;
							float num19 = num16 - num17;
							downGoing = (Vector3)num;
							tipAxis = vector2;
							Freeze();
							Knocked__BackingField = true;
						}
						float num20 = default;
						bool flag9 = !(num20 < 0f);
						float num21 = num20;
						if (!flag9)
						{
							num21 = downSeconds;
						}
						downLeft = num21;
						return true;
					}
				}
			}
		}
		return false;
		IL_0413:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private unsafe float EyesOverFloor(Vector3 eyes)
	{
		//IL_00f6: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I4
		//IL_0038: Expected VT, but got I8
		//IL_0038: Expected VT, but got Ref
		//IL_00e1: Expected F4, but got I
		//IL_0069: Expected F4, but got I
		//IL_0079: Invalid comparison between F4 and I
		//IL_009d: Invalid comparison between F4 and I
		//IL_00cc: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = default;
		float maxDistance = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		float result;
		if (Physics.Raycast((Vector3)(&obj4), (Vector3)4294961403L, out *(RaycastHit*)1, maxDistance, 0, queryTriggerInteraction))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			result = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			float num = default;
			if (!(num < 0f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
				bool flag2 = !(num > 0f);
				result = num;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
					result = 0f;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			result = 0f;
		}
		return result;
	}

	private unsafe void Lying(float dt)
	{
		//IL_083f: Expected Obj, but got I
		//IL_0857: Expected Obj, but got I
		//IL_085f: Expected F4, but got Obj
		//IL_086f: Expected F4, but got I
		//IL_0d0c: Expected Obj, but got I
		//IL_0d1c: Expected Obj, but got I
		//IL_0d2c: Expected Obj, but got I
		//IL_0d71: Invalid comparison between F4 and I4
		//IL_089e: Expected Obj, but got I4
		//IL_0207: Expected VT, but got F4
		//IL_0036: Invalid comparison between F4 and I4
		//IL_0903: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I4
		//IL_024e: Invalid comparison between F4 and I
		//IL_0260: Expected VT, but got I4
		//IL_007f: Expected Obj, but got I4
		//IL_0097: Invalid comparison between F4 and I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_091a: Invalid comparison between F4 and I4
		//IL_092b: Expected Obj, but got I4
		//IL_0934: Invalid comparison between F4 and I4
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Expected Obj, but got Unknown
		//IL_02c5: Expected Obj, but got I4
		//IL_0e34: Expected Obj, but got I
		//IL_0e6f: Expected Obj, but got I
		//IL_0437: Invalid comparison between F8 and I4
		//IL_0446: Expected F8, but got I4
		//IL_030a: Expected VT, but got I8
		//IL_030a: Expected VT, but got Ref
		//IL_035c: Expected VT, but got I8
		//IL_0a54: Expected Obj, but got I4
		//IL_04c2: Expected VT, but got I8
		//IL_04c2: Expected VT, but got Ref
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_0385: Expected Obj, but got I
		//IL_0992: Expected Obj, but got I
		//IL_09b4: Expected Obj, but got I
		//IL_0ad6: Invalid comparison between F4 and I4
		//IL_0ae7: Expected Obj, but got I4
		//IL_0af0: Invalid comparison between F4 and I4
		//IL_0b0b: Expected Obj, but got I4
		//IL_04fb: Invalid comparison between F4 and I4
		//IL_050c: Expected Obj, but got I4
		//IL_0515: Invalid comparison between F4 and I4
		//IL_0526: Expected Obj, but got I4
		//IL_0dfc: Expected VT, but got I8
		//IL_063c: Invalid comparison between F4 and I4
		//IL_064b: Invalid comparison between F4 and I4
		//IL_065e: Expected Obj, but got F8
		//IL_066b: Expected Obj, but got F4
		//IL_06a0: Expected Obj, but got I4
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected Obj, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Obj, but got Unknown
		//IL_0b65: Invalid comparison between F4 and I4
		//IL_0b78: Expected Obj, but got F4
		//IL_0b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b85: Expected Obj, but got Unknown
		//IL_0bb7: Expected Obj, but got I4
		//IL_06ff: Expected F4, but got I4
		//IL_058d: Invalid comparison between F4 and I4
		//IL_05a0: Expected Obj, but got F4
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected Obj, but got Unknown
		//IL_05ee: Expected Obj, but got I4
		//IL_0a7b: Expected Obj, but got I4
		//IL_0a93: Invalid comparison between F4 and I4
		//IL_0aa4: Expected Obj, but got I4
		//IL_0be7: Expected Obj, but got I4
		//IL_0bff: Invalid comparison between F8 and I4
		//IL_0c1f: Expected Obj, but got I4
		//IL_0c56: Expected VT, but got I8
		//IL_0c5f: Invalid comparison between F4 and I4
		//IL_0c70: Expected Obj, but got I4
		//IL_0c79: Invalid comparison between F4 and I4
		//IL_0c8a: Expected Obj, but got I4
		//IL_07a7: Invalid comparison between F4 and I4
		//IL_0cba: Expected VT, but got I4
		//IL_0cba: Expected VT, but got I4
		//IL_0cba: Expected VT, but got I4
		SetFade(0f);
		float num = (downLeft -= dt);
		Vector3 position = head.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v6+A0]");
		object obj3 = 0;
		float num2 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v7+8]");
		float num3 = 0f;
		float num4 = (float)obj3 - (float)downGoing;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v7+8]");
		float num5 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KillCam)+15C]");
		float num6 = num5 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v7+4]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v7+4]");
		object obj4 = num7 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj6 = 0;
		float num8 = num4 * num4;
		float num9 = num8 + (float)obj4;
		float num10 = num6 * num6;
		float num11 = num9 + num10;
		bool flag = num11 == 0f;
		float num12 = dt;
		if (!flag)
		{
			num12 = dt * 6f;
			bool flag2 = num12 < 0f;
			float num13 = 6f;
			if (!flag2)
			{
				num13 = num12 * num12;
				bool flag3 = num11 < num13;
				object obj7 = !flag3;
				float num14 = num11 - num13;
				bool flag4 = num14 == 0f;
				object obj8 = ~obj7;
				object obj9 = obj8 | flag4;
				num9 = num13;
				if (obj9 != null)
				{
					goto IL_0874;
				}
			}
			object obj10 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v57+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float num15 = num4 / num13;
			float num16 = num6 / num13;
			num10 = num12 * num15;
			num2 = (float)downGoing + num10;
			num9 = num12 * num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KillCam)+15C]");
			num3 = 0f + num9;
		}
		goto IL_0874;
		IL_0874:
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v10+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 gravity = Physics.gravity;
		float num17 = num9 * dt;
		float num18 = num10 * dt;
		object obj14 = default;
		float num19 = (float)obj14 * dt;
		float num20 = num2 + num17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KillCam)+158]");
		float num21 = 0f + num18;
		float num22 = num3 + num19;
		downGoing = (Vector3)num20;
		float num23 = num20 * dt;
		object obj15 = obj6;
		float num24 = num21 * dt;
		float num25 = num22 * dt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num26 = num25 * num25;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num27 = num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		bool flag8 = !(num27 > 0f);
		Vector3 vector = (Vector3)0;
		float num31 = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		if (!flag8)
		{
			float num28 = num23 / num12;
			object obj17 = obj5;
			float num29 = num24 / num12;
			float num30 = num25 / num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v43+E4]");
			bool flag9 = (nint)0 == 0;
			object obj18 = !flag9;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj19 = default;
			bool flag10 = Physics.SphereCast((Vector3)(&obj19), num, (Vector3)4294961403L, out *(RaycastHit*)1, num31, 0, queryTriggerInteraction);
			bool flag11 = !flag10;
			int num32 = 0;
			ref RaycastHit reference = ref *(RaycastHit*)1;
			float num33 = num12;
			float num34 = num30;
			float num35 = num29;
			float num36 = num28;
			vector = (Vector3)4294961403L;
			if (!flag11)
			{
				object obj20 = this + 340;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KillCam)+15C]");
				object obj21 = 0;
				object obj22 = obj20;
				object obj24 = default;
				object obj23 = obj24 * obj24;
				object obj26 = default;
				object obj25 = obj26 * obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
				object obj27 = 0;
				object obj28 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v45+A0]");
				object obj29 = 0;
				object obj30 = obj25 + obj23;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29))
				{
					object obj31 = obj20 * obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KillCam)+15C]");
					object obj32 = 0 * obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
					object obj33 = obj32 + obj31;
					object obj34 = obj33 / obj30;
					object obj36 = default;
					object obj35 = obj24 * obj36;
					object obj37 = obj26 * obj34;
					obj22 -= obj35;
					obj21 -= obj37;
				}
				object obj38 = default;
				num23 = num28 * (float)obj38;
				num24 = num29 * (float)obj38;
				obj20 = obj22;
				num32 = 0;
				reference = ref *(RaycastHit*)1;
				num33 = num12;
				num34 = num30;
				num35 = num29;
				num36 = num28;
				vector = (Vector3)4294961403L;
			}
		}
		bool flag12 = num < 0f;
		object obj39 = !flag12;
		bool flag13 = num == 0f;
		object obj40 = ~obj39;
		object obj41 = obj40 | flag13;
		double num37 = eyesWere;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			double num38 = (double)tipped / (double)downTip;
			bool flag14 = num38 < 0.0;
			double num39 = 0.0;
			if (!flag14)
			{
				bool flag15 = num38 > 1.0;
				num39 = 1.0;
				if (!flag15)
				{
					num39 = num38;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			float num40 = 0f - eyesWere;
			double num41 = (double)num40 * num39;
			num37 = (double)eyesWere + num41;
		}
		object obj42 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v19+A0]");
		object obj43 = 0;
		float num42 = num31 + num24;
		float num43 = num + num23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v20+18]");
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		object obj44 = num44 * 0;
		object obj45 = obj5;
		float maxDistance = num43 + (float)obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v20+E4]");
		bool flag16 = (nint)0 == 0;
		object obj46 = !flag16;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj47 = default;
		float num53;
		float num54;
		if (Physics.Raycast((Vector3)(&obj47), (Vector3)4294961403L, out *(RaycastHit*)1, maxDistance, 0, queryTriggerInteraction))
		{
			object obj48 = default;
			double num45 = num37 + (double)obj48;
			bool flag17 = num < 0f;
			object obj49 = !flag17;
			bool flag18 = num == 0f;
			object obj50 = !flag18;
			object obj51 = obj49 & obj50;
			if (obj51 == null)
			{
				float num46 = eyesWere;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB24]");
				float num47 = num46 + 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				float num48 = num47 / downRise;
				float num49 = (float)num45 - num42;
				bool flag19 = num49 < 0f;
				object obj52 = num49 ^ num49;
				object obj53 = num49 & obj52;
				bool flag20 = (nint)obj53 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
				float num50 = num48 * dt;
				bool flag21 = flag19 == flag20;
				object obj54 = !flag21;
				object obj55 = ~obj54;
				if (obj55 == null)
				{
				}
				bool flag22 = num49 < num50;
				object obj56 = !flag22;
				float num51 = num49 - num50;
				bool flag23 = num51 == 0f;
				object obj57 = !flag23;
				object obj58 = obj56 & obj57;
				object obj59 = ~obj58;
				if (obj59 != null)
				{
				}
			}
			else
			{
				float num52 = num42 - (float)num45;
				bool flag24 = num52 < 0f;
				bool flag25 = num52 == 0f;
				object obj60 = (double)num42 ^ num45;
				object obj61 = num42 ^ num52;
				object obj62 = obj60 & obj61;
				bool flag26 = (nint)obj62 < 0;
				bool flag27 = flag24 == flag26;
				object obj63 = !flag25;
				object obj64 = flag27 & obj63;
				object obj65 = ~obj64;
				if (obj65 != null)
				{
				}
			}
			_ = 0;
			num53 = dt;
			num54 = num;
		}
		else
		{
			num53 = dt;
			num54 = num;
		}
		bool flag28 = num54 < 0f;
		object obj66 = !flag28;
		bool flag29 = num54 == 0f;
		float num55 = downTip;
		object obj67 = !flag29;
		object obj68 = obj66 & obj67;
		float num56;
		double num58;
		if (obj68 == null)
		{
			num56 = tipped;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			double num57 = downTip;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			num58 = num57 / 0.0;
			num55 = 0f;
		}
		else
		{
			num56 = tipped;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			double num59 = (double)downTip * 3.0;
			double num60 = (double)tipped / 1.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			double num61 = num59 * num60;
			num58 = num61 / (double)downFall;
		}
		float num62 = num55 - num56;
		double num63 = num58 * (double)num53;
		double num64 = num58 * (double)num53;
		double num65 = 0.0 - num64;
		bool flag30 = num62 < 0f;
		object obj69 = num62 ^ num62;
		object obj70 = num62 & obj69;
		bool flag31 = (nint)obj70 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag32 = flag30 == flag31;
		object obj71 = !flag32;
		object obj72 = ~obj71;
		if (obj72 != null)
		{
			num65 = num63;
		}
		bool flag33 = (double)num62 < num63;
		object obj73 = !flag33;
		double num66 = (double)num62 - num63;
		bool flag34 = num66 == 0.0;
		double num67 = (double)num56 + num65;
		object obj74 = !flag34;
		object obj75 = obj73 & obj74;
		object obj76 = ~obj75;
		if (obj76 == null)
		{
			num55 = (float)num67;
		}
		Tip(num55, (Vector3)4294961403L);
		bool flag35 = num54 < 0f;
		object obj77 = !flag35;
		bool flag36 = num54 == 0f;
		object obj78 = !flag36;
		object obj79 = obj77 & obj78;
		if (obj79 == null && !(tipped > 0f))
		{
			Knocked__BackingField = false;
			Transform transform = base.transform;
			Vector3 position2 = transform.position;
			Transform transform2 = base.transform;
			Quaternion rotation = transform2.rotation;
			Release((Vector3)0, (Quaternion)1, (Vector3)0);
		}
	}

	private void Tip(float to)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I4
		//IL_007c: Expected VT, but got I4
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
		Transform transform;
		if (head != null)
		{
			transform = head;
		}
		else
		{
			transform = base.transform;
			bool flag2 = (object)transform == null;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				throw new NullReferenceException();
			}
		}
		Vector3 position = transform.position;
		Tip(to, (Vector3)0);
	}

	private void Tip(float to, Vector3 eyes)
	{
		//IL_0323: Invalid comparison between F4 and I4
		//IL_0334: Expected Obj, but got I4
		//IL_033d: Invalid comparison between F4 and I4
		//IL_034e: Expected Obj, but got I4
		//IL_0314: Expected VT, but got I4
		//IL_0072: Expected VT, but got I
		//IL_0072: Expected VT, but got I4
		//IL_0379: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_042d: Invalid comparison between F4 and I
		//IL_045c: Expected Obj, but got I
		//IL_0566: Expected Obj, but got I
		//IL_05df: Expected Obj, but got I
		//IL_048f: Expected Obj, but got I
		//IL_04c8: Expected Obj, but got I4
		//IL_015d: Invalid comparison between F4 and I
		//IL_04fd: Expected Obj, but got I
		//IL_0610: Expected Obj, but got I
		//IL_0635: Expected Obj, but got I
		//IL_0652: Expected Obj, but got I
		//IL_069a: Expected Obj, but got I
		//IL_06d8: Expected Obj, but got I4
		//IL_01b4: Invalid comparison between F4 and I
		//IL_02e0: Expected VT, but got I
		//IL_02e0: Expected VT, but got I4
		//IL_01fc: Expected Obj, but got I
		//IL_052c: Expected Obj, but got I4
		float num = tipped;
		IntPtr intPtr = default;
		if (tipped != to)
		{
			Transform transform = base.transform;
			Vector3 position = head.position;
			float num2 = to - tipped;
			transform.RotateAround((Vector3)0, (Vector3)(nint)intPtr, to);
			tipped = to;
			num = to;
		}
		bool flag = num < 0f;
		object obj = !flag;
		bool flag2 = num == 0f;
		object obj2 = !flag2;
		object obj3 = obj & obj2;
		if (obj3 == null)
		{
			Transform transform2 = base.transform;
			Vector3 up = transform2.up;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v5+A0]");
			object obj6 = 0;
			float num3 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v6+20]");
			float num4 = num3 - 0f;
			float num5 = to;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v6+18]");
			float num6 = num5 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v6+1C]");
			object obj8 = default;
			object obj7 = obj8 - 0;
			float num7 = num6 * num6;
			object obj9 = obj7 * obj7;
			float num8 = num7 + (float)obj9;
			float num9 = num4 * num4;
			float num10 = num8 + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			if (num10 > 0f)
			{
				Transform transform3 = base.transform;
				Vector3 position2 = head.position;
				Transform transform4 = base.transform;
				Vector3 up2 = transform4.up;
				object obj10 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v11+A0]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v12+20]");
				object obj12 = num11 * 0;
				float num12 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v12+1C]");
				float num13 = num12 * 0f;
				float num14 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v12+18]");
				float num15 = num14 * 0f;
				float num16 = num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v12+20]");
				float num17 = num16 * 0f;
				float num18 = num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v12+1C]");
				float num19 = num18 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
				nint num20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v12+18]");
				object obj13 = num20 * 0;
				float num21 = (float)obj12 - num13;
				float num22 = num15 - num17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj14 = 0;
				float num23 = num19 - (float)obj13;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X0_v23+E4]");
				bool flag3 = (nint)0 == 0;
				object obj16 = !flag3;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num24 = num21 * num21;
				float num25 = num22 * num22;
				float num26 = num24 + num25;
				float num27 = num23 * num23;
				float num28 = num27 + num26;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				if (num28 > 0f)
				{
				}
				Transform transform5 = base.transform;
				Vector3 up3 = transform5.up;
				object obj17 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v21+A0]");
				object obj18 = 0;
				float num29 = num28 * num28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				nint num30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				object obj19 = num30 * 0;
				object obj20 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v22+18]");
				nint num31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v22+18]");
				object obj21 = num31 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v22+1C]");
				nint num32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v22+1C]");
				object obj22 = num32 * 0;
				float num33 = num29 + (float)obj19;
				float num34 = num4 * num4;
				object obj23 = obj21 + obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v22+20]");
				nint num35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v22+20]");
				object obj24 = num35 * 0;
				float num36 = num34 + num33;
				object obj25 = obj24 + obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X0_v30+E4]");
				bool flag4 = (nint)0 == 0;
				object obj26 = !flag4;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F4]");
				if (!(num36 < 0f))
				{
					float num37 = num28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v22+18]");
					float num38 = num37 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					nint num39 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v22+1C]");
					object obj27 = num39 * 0;
					float num40 = num38 + (float)obj27;
					float num41 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v22+20]");
					float num42 = num41 * 0f;
					float num43 = num42 + num40;
					float num44 = num43 / num36;
					bool flag5 = (double)num44 < -1.0;
					double num45 = -1.0;
					if (!flag5)
					{
						bool flag6 = !((double)num44 > 1.0);
						num45 = num44;
						if (!flag6)
						{
							num45 = 1.0;
						}
					}
					object obj28 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v35+E4]");
					bool flag7 = (nint)0 == 0;
					object obj29 = !flag7;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D000");
				}
				transform3.RotateAround((Vector3)0, (Vector3)(nint)intPtr, num10);
			}
		}
		Transform transform6 = base.transform;
		Vector3 position3 = transform6.position;
		Vector3 position4 = head.position;
		transform6.position = (Vector3)0;
	}

	public void Punched()
	{
		//IL_0016: Expected Obj, but got I4
		bool flag = (byte)(~(dying ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj == null)
		{
			int num = Hits__BackingField + 1;
			Hits__BackingField = num;
			Buzz(1f, 0.25f);
			if (Hits__BackingField >= punchesToKill)
			{
				Die(tearHead: false);
			}
		}
	}

	public void Finished()
	{
		//IL_0035: Expected Obj, but got I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected I4, but got Unknown
		//IL_00a8: Expected Obj, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		if (~(dying ? 1u : 0u) != 0)
		{
			int num = Hits__BackingField;
			object obj = Hits__BackingField - punchesToKill;
			bool flag = (nint)obj < 0;
			bool flag2 = obj == null;
			int num2 = Hits__BackingField ^ punchesToKill;
			int num3 = Hits__BackingField ^ obj;
			int num4 = num2 & num3;
			bool flag3 = num4 < 0;
			bool flag4 = flag == flag3;
			object obj2 = !flag2;
			object obj3 = flag4 & obj2;
			object obj4 = ~obj3;
			if (obj4 != null)
			{
				num = punchesToKill;
			}
			Hits__BackingField = num;
			Die(tearHead: false);
		}
	}

	public void Blasted(Vector3 velocity, int hits, bool blownApart)
	{
		//IL_0020: Expected F4, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected I4, but got Unknown
		//IL_0061: Expected Obj, but got I4
		//IL_0252: Expected VT, but got F4
		//IL_00a6: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I4
		//IL_016c: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I4
		//IL_0282: Expected VT, but got I4
		//IL_0239: Expected VT, but got I4
		if (~(dying ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
		Buzz(1f, 0f);
		int num = (Hits__BackingField = (int)(Hits__BackingField + velocity));
		int num2 = hits & 1;
		bool flag = num2 == 0;
		object obj = !flag;
		float num3 = default;
		if (obj == null && num < punchesToKill)
		{
			bool flag2 = (byte)(~(Busy__BackingField ? 1u : 0u)) != 0;
			object obj2 = !flag2;
			if (obj2 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = body == null;
			bool flag5 = !flag4;
			object obj6 = !flag5;
			if (obj6 != null)
			{
				return;
			}
			bool isKinematic = body.isKinematic;
			bool flag6 = !isKinematic;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				object obj8 = obj3;
				flying = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v11+E4]");
				bool flag7 = (nint)0 == 0;
				object obj9 = !flag7;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (locomotion != null && locomotion.enabled)
				{
					locomotion.Launch((Vector3)0, num3);
				}
				else
				{
					body.linearVelocity = (Vector3)0;
				}
			}
		}
		else
		{
			int num4 = hits & 1;
			DeathVelocity__BackingField = (Vector3)num3;
			BlownApart__BackingField = (byte)num4 != 0;
			Die(tearHead: false);
		}
	}

	public void CutByDoor(Vector3 normal, float off, byte door)
	{
		//IL_0024: Expected VT, but got F4
		//IL_004d: Expected I4, but got VT
		//IL_0079: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I
		//IL_00a6: Expected VT, but got Obj
		if (~(dying ? 1u : 0u) != 0)
		{
			doorCutNormal = (Vector3)off;
			doorCut = true;
			float num = default;
			doorCutOff = num;
			doorCutBy = (byte)(int)normal;
			Buzz(1f, 0.5f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v5+A0]");
			object obj3 = 0;
			BlownApart__BackingField = false;
			DeathVelocity__BackingField = (Vector3)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6+8]");
			_ = 0;
			Die(tearHead: false);
		}
	}

	public unsafe bool TakeDoorCut(out Vector3 normal, out float off, out byte door)
	{
		//IL_0017: Expected Ref, but got VT
		//IL_0021: Expected Ref, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KillCam)+178]");
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)doorCutNormal;
		ref float reference2 = ref *(float*)doorCutOff;
		ref byte reference3 = ref *(byte*)doorCutBy;
		doorCut = false;
		return doorCut;
	}

	public void Shoved(Vector3 velocity)
	{
		//IL_00fc: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00e0: Expected VT, but got I4
		bool flag = (byte)(~(Busy__BackingField ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = body == null;
			bool flag4 = !flag3;
			object obj5 = !flag4;
			if (obj5 == null && !body.isKinematic)
			{
				Vector3 linearVelocity = body.linearVelocity;
				body.linearVelocity = (Vector3)0;
			}
		}
	}

	public void Die(bool tearHead = default(bool))
	{
		//IL_02b5: Expected Obj, but got I4
		//IL_0027: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I
		//IL_02d4: Expected Obj, but got I
		//IL_02fe: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I4
		//IL_00f8: Expected I, but got Obj
		//IL_0336: Expected Obj, but got I4
		//IL_038c: Expected Obj, but got I
		//IL_039c: Expected Obj, but got I
		//IL_03c6: Expected Obj, but got I4
		//IL_012b: Expected I, but got Obj
		//IL_025b: Expected Obj, but got I4
		//IL_036e: Expected Obj, but got I4
		//IL_03e4: Expected Obj, but got I
		bool flag = (byte)(~(Busy__BackingField ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj == null)
		{
			Freeze();
		}
		bool flag2 = (byte)(~(dying ? 1u : 0u)) != 0;
		object obj2 = !flag2;
		if (obj2 != null)
		{
			return;
		}
		Knocked__BackingField = false;
		dying = true;
		biteAt = t;
		bool flag3 = !tearHead;
		ApePart apePart = (tearHead ? ((ApePart)1) : ((ApePart)0));
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v38+E4]");
			bool flag4 = (nint)0 == 0;
			object obj5 = !flag4;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = dismember != null;
			bool flag6 = !flag5;
			nint num = unchecked((nint)null);
			apePart = (ApePart)0;
			if (!flag6)
			{
				dismember.Tear((ApePart)0);
				num = unchecked((nint)null);
				apePart = (ApePart)0;
			}
		}
		Buzz(1f, 0.5f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v11+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v12+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v12+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v13+28]");
			apePart = (ApePart)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v146 @ X8_v13+18] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v8+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v12+E4]");
		bool flag8 = (nint)0 == 0;
		object obj14 = !flag8;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v12+A0]");
		object obj16 = 0;
		object obj17 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v20+E4]");
		bool flag9 = (nint)0 == 0;
		object obj18 = !flag9;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj16 != null)
		{
			object obj19 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v16+E4]");
			bool flag10 = (nint)0 == 0;
			object obj20 = !flag10;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj21 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v20+E4]");
			bool flag11 = (nint)0 == 0;
			object obj22 = !flag11;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj10;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v20+A0]");
			object obj23 = 0;
			((NetworkApe)obj23).LeaveBody();
		}
	}

	public void DieInPit()
	{
		FellInPit__BackingField = true;
		Die(tearHead: false);
	}

	private void Freeze()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0203: Expected Obj, but got I4
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_0221: Expected Obj, but got I4
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_023f: Expected Obj, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0029: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I4
		//IL_01c2: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		flying = 0f;
		Busy__BackingField = true;
		object obj2 = this + 192;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = this + 216;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = this + 208;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = this + 184;
		obj5 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B338]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X21_v2-90]");
		bool flag2 = (UnityEngine.Object)0 != null;
		bool flag3 = !flag2;
		object obj8 = 0;
		bool flag4 = false;
		if (!flag3)
		{
			locomotion.enabled = false;
			obj8 = 0;
			flag4 = false;
		}
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v20+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (body != null)
		{
			RigidbodyInterpolation interpolation = body.interpolation;
			interp = interpolation;
			body.interpolation = (RigidbodyInterpolation)0;
			body.linearVelocity = (Vector3)0;
			body.isKinematic = true;
		}
	}

	public void Blink(float seconds)
	{
		float time = Time.time;
		float num = time + seconds;
		blinkTill = num;
	}

	public void Twist(float degrees, float seconds)
	{
		twistLeft = degrees;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		float num = degrees / seconds;
		twistRate = num;
	}

	public void TearArm(ApePart part)
	{
		//IL_001b: Expected Obj, but got I4
		//IL_0034: Invalid comparison between F4 and I4
		//IL_005b: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I4
		//IL_00f9: Expected F4, but got I
		if (~(Busy__BackingField ? 1u : 0u) != 0)
		{
			return;
		}
		bool flag = (byte)(~(dying ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj == null && biteAt < 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(dismember == null))
			{
				dismember.Tear(part);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				Buzz(1f, 0f);
			}
		}
	}

	public void Bite()
	{
		//IL_0010: Invalid comparison between F4 and I4
		//IL_0037: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I
		//IL_0167: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I
		if (~(Busy__BackingField ? 1u : 0u) == 0 && biteAt < 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			biteAt = t;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (dismember != null)
			{
				dismember.Tear((ApePart)0);
			}
			Buzz(1f, 0.5f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v10+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v11+10]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v11+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v12+40]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v12+28]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v12+18]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v98 @ X2_v4 (should have been resolved before IL gen)");
			}
		}
	}

	public bool Fell()
	{
		//IL_0016: Expected Obj, but got I4
		//IL_0070: Expected VT, but got I
		bool flag = (byte)(~(Busy__BackingField ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj == null)
		{
			IntPtr intPtr = default;
			Quaternion rot = default;
			Vector3 velocity = default;
			Release((Vector3)(nint)intPtr, rot, velocity);
			restoreInterp = restoreInterp;
			Transform back = Back();
			Home(back);
			fadeBack = 1f;
			SetFade(1f);
		}
		return !Busy__BackingField;
	}

	public void FadeIn()
	{
		if (~(Busy__BackingField ? 1u : 0u) != 0)
		{
			fadeBack = 1f;
			SetFade(1f);
		}
	}

	private void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_1619: Expected Obj, but got I
		//IL_163b: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I
		//IL_00d4: Expected VT, but got I4
		//IL_00d9: Expected I4, but got Obj
		//IL_1654: Invalid comparison between F4 and I4
		//IL_0099: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got I4
		//IL_0156: Expected VT, but got I4
		//IL_029e: Invalid comparison between F4 and I4
		//IL_01f9: Invalid comparison between F4 and I4
		//IL_019c: Expected VT, but got I4
		//IL_03dc: Expected Obj, but got I4
		//IL_0666: Expected Obj, but got I4
		//IL_02cb: Expected Obj, but got I4
		//IL_0219: Expected F4, but got I4
		//IL_0414: Expected Obj, but got I4
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected Obj, but got Unknown
		//IL_0459: Expected VT, but got I4
		//IL_0311: Invalid comparison between F4 and I4
		//IL_0324: Expected Obj, but got F4
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_038a: Expected Obj, but got I4
		//IL_173b: Expected Obj, but got I4
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Expected Obj, but got Unknown
		//IL_0722: Expected VT, but got I4
		//IL_072b: Expected VT, but got I4
		//IL_0484: Expected VT, but got I4
		//IL_169d: Expected Obj, but got I4
		//IL_16b5: Invalid comparison between F4 and I4
		//IL_16d5: Expected Obj, but got I4
		//IL_125b: Invalid comparison between F4 and I4
		//IL_126c: Expected Obj, but got VT
		//IL_03c1: Expected F4, but got I4
		//IL_18d1: Invalid comparison between F4 and I4
		//IL_074d: Expected VT, but got I4
		//IL_04c5: Expected Obj, but got I4
		//IL_170c: Expected F8, but got I4
		//IL_13d5: Expected Obj, but got I4
		//IL_12a4: Expected Obj, but got I4
		//IL_0865: Expected Obj, but got I4
		//IL_050c: Expected Obj, but got I4
		//IL_0515: Expected VT, but got I4
		//IL_141c: Expected Obj, but got I4
		//IL_1425: Expected F4, but got I4
		//IL_142e: Expected F4, but got I4
		//IL_078a: Expected Obj, but got I4
		//IL_191b: Expected F4, but got I4
		//IL_13a6: Expected F4, but got I4
		//IL_1357: Expected VT, but got I4
		//IL_09b7: Expected Obj, but got I4
		//IL_07d1: Expected Obj, but got I4
		//IL_07da: Expected VT, but got I4
		//IL_0800: Expected VT, but got I4
		//IL_0809: Expected VT, but got I4
		//IL_0537: Expected VT, but got I4
		//IL_14a4: Invalid comparison between F4 and I4
		//IL_1466: Invalid comparison between F4 and I4
		//IL_08e8: Expected Obj, but got I4
		//IL_0637: Expected VT, but got I4
		//IL_0578: Expected Obj, but got I4
		//IL_1574: Expected Obj, but got I4
		//IL_1932: Invalid comparison between F4 and I4
		//IL_1944: Expected F4, but got I4
		//IL_133a: Expected VT, but got I4
		//IL_0a77: Expected F4, but got I
		//IL_0add: Expected Obj, but got I4
		//IL_0a14: Expected Obj, but got I4
		//IL_05bd: Expected VT, but got I4
		//IL_05c6: Expected VT, but got I4
		//IL_14ef: Invalid comparison between F4 and I4
		//IL_14fe: Expected F4, but got I4
		//IL_0b46: Expected Obj, but got I4
		//IL_094f: Expected Obj, but got I
		//IL_0971: Expected Obj, but got I4
		//IL_097a: Expected Obj, but got I4
		//IL_0bda: Expected Obj, but got I4
		//IL_0cd9: Expected F8, but got VT
		//IL_0ce2: Expected VT, but got I4
		//IL_0ec4: Expected Obj, but got I4
		//IL_0d4b: Expected F4, but got I
		//IL_0d5b: Invalid comparison between F4 and I
		//IL_0d6c: Expected F8, but got VT
		//IL_0d75: Expected VT, but got I4
		//IL_0ff7: Invalid comparison between F4 and I4
		//IL_0dc0: Expected F4, but got I
		//IL_0dd0: Invalid comparison between F4 and I
		//IL_0de1: Expected F8, but got VT
		//IL_0dea: Expected VT, but got I4
		//IL_0c72: Expected VT, but got I4
		//IL_0c7a: Expected F8, but got VT
		//IL_0ca3: Expected VT, but got I4
		//IL_11d1: Invalid comparison between F4 and I4
		//IL_11e0: Expected F8, but got I4
		//IL_0f68: Expected VT, but got I4
		//IL_0f68: Expected VT, but got I4
		//IL_17bf: Invalid comparison between F8 and I4
		//IL_17ce: Invalid comparison between F8 and I4
		//IL_17e1: Expected Obj, but got F8
		//IL_17ee: Expected Obj, but got F8
		//IL_1823: Expected Obj, but got I4
		//IL_182b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1830: Expected Obj, but got Unknown
		//IL_0e64: Expected VT, but got I4
		//IL_0e64: Expected VT, but got I4
		//IL_0e84: Expected F4, but got I
		//IL_0e95: Expected VT, but got I4
		//IL_18b1: Expected VT, but got I4
		//IL_18ba: Expected VT, but got I4
		//IL_18c3: Expected VT, but got I4
		//IL_109d: Expected VT, but got I4
		//IL_109d: Expected VT, but got I4
		//IL_10c8: Expected VT, but got F8
		//IL_10eb: Expected VT, but got I4
		//IL_10f4: Expected VT, but got I4
		//IL_1793: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj7 = 0;
		if ((UnityEngine.Object)obj5 == this)
		{
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v175+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaWounds.Pump();
		}
		bool flag3 = (byte)(~(restoreInterp ? 1u : 0u)) != 0;
		Quaternion quaternion = (Quaternion)0;
		RigidbodyInterpolation rigidbodyInterpolation = (RigidbodyInterpolation)this;
		if (!flag3)
		{
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v168+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = body != null;
			bool flag6 = !flag5;
			quaternion = (Quaternion)0;
			rigidbodyInterpolation = (RigidbodyInterpolation)0;
			if (!flag6)
			{
				rigidbodyInterpolation = interp;
				body.interpolation = interp;
				restoreInterp = false;
				quaternion = (Quaternion)0;
			}
		}
		if (fadeBack > 0f)
		{
			bool flag7 = (byte)(~(Busy__BackingField ? 1u : 0u)) != 0;
			object obj12 = !flag7;
			if (obj12 == null)
			{
				float deltaTime = Time.deltaTime;
				float num = deltaTime / fadeSeconds;
				float num2 = fadeBack - num;
				if (num2 < 0f)
				{
					num2 = 0f;
				}
				fadeBack = num2;
				SetFade(num2);
			}
		}
		if (~(Busy__BackingField ? 1u : 0u) != 0)
		{
			return;
		}
		float deltaTime2 = Time.deltaTime;
		float num3 = t;
		float num4 = deltaTime2 + t;
		t = num4;
		if (~(Knocked__BackingField ? 1u : 0u) == 0)
		{
			Lying(deltaTime2);
			return;
		}
		float num5 = tipped;
		float num8 = default;
		float num7 = default;
		double num11 = default;
		if (tipped > 0f)
		{
			bool flag8 = (byte)(~(dying ? 1u : 0u)) != 0;
			object obj13 = !flag8;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				float num6 = downTip / downRise;
				num7 = 0f - tipped;
				bool flag9 = num7 < 0f;
				object obj14 = num7 ^ num7;
				object obj15 = num7 & obj14;
				bool flag10 = (nint)obj15 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
				num8 = deltaTime2 * num6;
				float num9 = deltaTime2 * num6;
				num3 = 0f - num9;
				bool flag11 = flag9 == flag10;
				object obj16 = !flag11;
				object obj17 = ~obj16;
				if (obj17 != null)
				{
					num3 = num8;
				}
				bool flag12 = num7 < num8;
				object obj18 = !flag12;
				float num10 = num7 - num8;
				bool flag13 = num10 == 0f;
				num5 += num3;
				object obj19 = !flag13;
				object obj20 = obj18 & obj19;
				object obj21 = ~obj20;
				if (obj21 != null)
				{
					num5 = 0f;
				}
				Tip(num5);
				num11 = 0.0;
			}
		}
		bool flag14 = (byte)(~(dying ? 1u : 0u)) != 0;
		object obj22 = !flag14;
		Quaternion rot;
		if (obj22 == null)
		{
			object obj23 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X0_v137+E4]");
			bool flag15 = (nint)0 == 0;
			object obj24 = !flag15;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag16 = Killer__BackingField == null;
			bool flag17 = !flag16;
			quaternion = (Quaternion)0;
			rigidbodyInterpolation = (RigidbodyInterpolation)0;
			if (!flag17)
			{
				bool flag18 = (byte)(~(heldBegun ? 1u : 0u)) != 0;
				quaternion = (Quaternion)0;
				rigidbodyInterpolation = (RigidbodyInterpolation)0;
				if (!flag18)
				{
					object obj25 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X0_v141+E4]");
					bool flag19 = (nint)0 == 0;
					object obj26 = !flag19;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag20 = HeldBy__BackingField == null;
					bool flag21 = !flag20;
					object obj27 = !flag21;
					rot = (Quaternion)0;
					if (obj27 != null)
					{
						goto IL_05dd;
					}
					bool flag22 = (byte)(~(heldFaced ? 1u : 0u)) != 0;
					quaternion = (Quaternion)0;
					rigidbodyInterpolation = (RigidbodyInterpolation)0;
					if (!flag22)
					{
						object obj28 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X0_v155+E4]");
						bool flag23 = (nint)0 == 0;
						object obj29 = !flag23;
						if (obj29 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag24 = heldFace == null;
						bool flag25 = !flag24;
						rot = (Quaternion)0;
						quaternion = (Quaternion)0;
						rigidbodyInterpolation = (RigidbodyInterpolation)0;
						if (!flag25)
						{
							goto IL_05dd;
						}
					}
				}
			}
		}
		object obj30 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X0_v13+E4]");
		bool flag26 = (nint)0 == 0;
		object obj31 = !flag26;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj32 = ((!(Killer__BackingField != null)) ? ((object)(this + 208)) : ((object)(Killer__BackingField + 40)));
		object obj33 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X0_v17+E4]");
		bool flag27 = (nint)0 == 0;
		object obj34 = !flag27;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag28 = (UnityEngine.Object)obj32 != null;
		bool flag29 = !flag28;
		double num12 = num8;
		double num13 = num7;
		double num14 = num3;
		Vector3 vector = (Vector3)0;
		Vector3 vector2 = (Vector3)0;
		float num16;
		Transform transform;
		float num22;
		float num26;
		float num27;
		double num28;
		if (!flag29)
		{
			bool flag30 = (byte)(~(dying ? 1u : 0u)) != 0;
			Vector3 vector3 = (Vector3)0;
			UnityEngine.Object obj35 = null;
			if (!flag30)
			{
				object obj36 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X0_v130+E4]");
				bool flag31 = (nint)0 == 0;
				object obj37 = !flag31;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				flag28 = Killer__BackingField == null;
				bool flag32 = !flag28;
				object obj38 = !flag32;
				vector3 = (Vector3)0;
				obj35 = null;
				num12 = num8;
				num13 = num7;
				num14 = num3;
				vector = (Vector3)0;
				vector2 = (Vector3)0;
				if (obj38 != null)
				{
					goto IL_1246;
				}
			}
			float num15 = follow * deltaTime2;
			num16 = 0f - num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
			object obj39 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X0_v44+E4]");
			bool flag33 = (nint)0 == 0;
			object obj40 = !flag33;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num17;
			double num18;
			float num19;
			float num20;
			float num21;
			if (Killer__BackingField != null)
			{
				MonsterBrain monsterBrain = Killer__BackingField;
				object obj41 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1094 @ X0_v118+E4]");
				bool flag34 = (nint)0 == 0;
				object obj42 = !flag34;
				if (obj42 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag35 = monsterBrain.face != null;
				Component component = Killer__BackingField;
				object obj44;
				if (flag35)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v122 (UnityEngine.Component)+30]");
					transform = (Transform)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v122 (UnityEngine.Component)+30]");
					bool flag36 = (nint)0 == 0;
					object obj43 = !flag36;
					obj44 = 0;
					if (obj43 == null)
					{
						throw new NullReferenceException();
					}
					goto IL_0a19;
				}
				Transform transform2 = Killer__BackingField.transform;
				Vector3 position = transform2.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
				num17 = num11;
				num18 = num11;
				num19 = num3;
				num20 = num16;
				num21 = num3;
				num22 = num16;
				obj44 = 0;
			}
			else
			{
				object obj45 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1059 @ X0_v108+E4]");
				bool flag37 = (nint)0 == 0;
				object obj46 = !flag37;
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj44;
				if (heldFace != null)
				{
					transform = heldFace;
					obj44 = 0;
					goto IL_0a19;
				}
				Vector3 position2 = ((Transform)obj32).position;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				num7 = 0f;
				float num23 = num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				num22 = num23 * 0f;
				float num24 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				num21 = num24 * 0f;
				double num25 = num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				num17 = num25 * 0.0;
				num18 = num11;
				num19 = num3;
				num20 = num16;
				obj44 = 0;
			}
			num26 = num20 + num22;
			num27 = num19 + num21;
			num28 = num18 + num17;
			num11 = num17;
			num3 = num21;
			goto IL_0b8d;
		}
		goto IL_1246;
		IL_1246:
		float num29 = biteAt;
		bool flag38 = !(biteAt < 0f);
		UnityEngine.Object obj47 = (UnityEngine.Object)vector2;
		if (!flag38)
		{
			object obj48 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X0_v37+E4]");
			bool flag39 = (nint)0 == 0;
			object obj49 = !flag39;
			if (obj49 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Killer__BackingField != null)
			{
				num29 = t;
				num5 = maxSeconds;
				if (t > maxSeconds)
				{
					biteAt = t;
					vector = (Vector3)0;
					obj47 = null;
					goto IL_18c8;
				}
			}
			num29 = biteAt;
			vector = (Vector3)0;
			obj47 = null;
		}
		goto IL_18c8;
		IL_05dd:
		Transform transform3 = base.transform;
		Vector3 position3 = transform3.position;
		Transform transform4 = base.transform;
		Quaternion rotation = transform4.rotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
		Vector3 velocity = default;
		Release((Vector3)0, rot, velocity);
		return;
		IL_0b8d:
		Vector3 position4 = head.position;
		Vector3 forward = head.forward;
		object obj50 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1240 @ X0_v53+E4]");
		bool flag40 = (nint)0 == 0;
		object obj51 = !flag40;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num30 = 1.0 - (double)num16;
		float num32;
		float num33;
		double num31;
		Vector3 vector5;
		Vector3 vector4 = default;
		if (Killer__BackingField != null)
		{
			MonsterBrain monsterBrain2 = Killer__BackingField;
			if (~(monsterBrain2.killLooksUp ? 1u : 0u) == 0)
			{
				LookUpAt((Vector3)0, num26);
				num31 = (double)vector4;
				num7 = (float)num30;
				num11 = num28;
				num32 = num27;
				num33 = num26;
				vector5 = (Vector3)0;
				goto IL_0e9a;
			}
		}
		num33 = t;
		num32 = faceTurnSeconds;
		bool flag41 = !(t < faceTurnSeconds);
		num31 = (double)vector4;
		vector5 = (Vector3)0;
		if (!flag41)
		{
			float num34 = num26 - num22;
			double num35 = num28 - num11;
			float num36 = num34 * num34;
			double num37 = num35 * num35;
			num33 = num36 + (float)num37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
			num32 = 0f;
			float num38 = num33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
			bool flag42 = !(num38 > 0f);
			num31 = (double)vector4;
			vector5 = (Vector3)0;
			if (!flag42)
			{
				float num39 = num22 * num22;
				double num40 = num11 * num11;
				num33 = num39 + (float)num40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				num32 = 0f;
				float num41 = num33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				bool flag43 = !(num41 > 0f);
				num31 = (double)vector4;
				vector5 = (Vector3)0;
				if (!flag43)
				{
					Transform transform5 = base.transform;
					Vector3 position5 = head.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72DCC");
					double num42 = num30 * (double)num22;
					transform5.RotateAround((Vector3)0, (Vector3)0, num33);
					float num43 = (float)num42;
					num31 = num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					num8 = 0f;
					num7 = num33;
					vector5 = (Vector3)0;
				}
			}
		}
		goto IL_0e9a;
		IL_0e9a:
		object obj52 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1302 @ X0_v58+E4]");
		bool flag44 = (nint)0 == 0;
		object obj53 = !flag44;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag45 = Killer__BackingField != null;
		bool flag46 = !flag45;
		double num44 = num32;
		if (!flag46)
		{
			Transform transform6 = base.transform;
			Vector3 position6 = transform6.position;
			Vector3 position7 = head.position;
			Vector3 position8 = ((Transform)obj32).position;
			Vector3 vector6 = Unblocked((Vector3)0, (Vector3)0);
			Vector3 position9 = head.position;
			float num45 = num32 - num32;
			double num46 = num11 - num11;
			float time = Time.time;
			double num47 = ((!(time < blinkTill)) ? num30 : 1.0);
			double num48 = (double)num45 * num47;
			double num49 = num46 * num47;
			num44 = (double)num32 + num48;
			num11 += num49;
			transform6.position = (Vector3)0;
		}
		if (twistLeft > 0f)
		{
			float num50 = deltaTime2 * twistRate;
			float num51 = ((!(twistLeft < num50)) ? num50 : twistLeft);
			Transform transform7 = base.transform;
			Vector3 position10 = head.position;
			Vector3 forward2 = head.forward;
			transform7.RotateAround((Vector3)0, (Vector3)0, twistLeft);
			num5 = twistLeft - num51;
			twistLeft = num5;
			float num43 = num51;
			vector4 = (Vector3)num11;
			num12 = num50;
			num13 = twistLeft;
			num14 = num50;
			vector = (Vector3)0;
			vector2 = (Vector3)0;
		}
		else
		{
			Transform transform8 = base.transform;
			Vector3 position11 = transform8.position;
			Vector3 position12 = ((Transform)obj32).position;
			vector4 = heldEyes;
			double num52 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KillCam)+64]");
			double num53 = num52 + 0.0;
			double num54 = num44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KillCam)+60]");
			double num55 = num54 + 0.0;
			float num56 = twistLeft + (float)heldEyes;
			Vector3 position13 = head.position;
			float num57 = num56 - twistLeft;
			double num58 = num55 - num44;
			double num59 = num53 - num11;
			float num60 = t / heldEase;
			bool flag47 = num60 < 0f;
			num12 = 0.0;
			if (!flag47)
			{
				bool flag48 = !((double)num60 > 1.0);
				num12 = num60;
				if (!flag48)
				{
					num12 = 1.0;
				}
			}
			double num61 = num30 - num12;
			bool flag49 = num61 < 0.0;
			bool flag50 = num61 == 0.0;
			object obj54 = num30 ^ num12;
			object obj55 = num30 ^ num61;
			object obj56 = obj54 & obj55;
			bool flag51 = (nint)obj56 < 0;
			bool flag52 = flag49 == flag51;
			object obj57 = !flag50;
			object obj58 = flag52 & obj57;
			object obj59 = ~obj58;
			num13 = ((obj59 != null) ? num12 : num30);
			double num62 = (double)num57 * num13;
			double num63 = num58 * num13;
			double num64 = num59 * num13;
			num5 = twistLeft + (float)num62;
			num14 = num44 + num63;
			num11 += num64;
			transform8.position = (Vector3)0;
			vector = (Vector3)0;
			vector2 = (Vector3)0;
		}
		goto IL_1246;
		IL_0a19:
		Vector3 position14 = transform.position;
		num27 = num3;
		num28 = num11;
		num26 = num16;
		num22 = num16;
		goto IL_0b8d;
		IL_18c8:
		if (num29 < 0f)
		{
			float time2 = Time.time;
			float num65 = ((!(time2 < blinkTill)) ? 0f : 1f);
			SetFade(num65);
			return;
		}
		object obj60 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X0_v23+E4]");
		bool flag53 = (nint)0 == 0;
		object obj61 = !flag53;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag54 = Killer__BackingField == null;
		bool flag55 = !flag54;
		object obj62 = !flag55;
		float num66 = 0f;
		float num67 = 0f;
		if (obj62 == null)
		{
			MonsterBrain monsterBrain3 = Killer__BackingField;
			num67 = monsterBrain3.killHoldAfterBite;
			if (monsterBrain3.killHoldAfterBite < 0f)
			{
				num67 = holdAfterBite;
			}
			bool flag56 = !(num67 > 0f);
			num66 = 0f;
			if (!flag56)
			{
				num66 = fadeSeconds;
			}
		}
		float num68 = t - num29;
		bool flag57 = num68 < num67;
		float num69 = 0f;
		if (!flag57)
		{
			bool flag58 = !(num66 > 0f);
			num69 = 1f;
			if (!flag58)
			{
				float num70 = num68 - num67;
				float num71 = num70 / num66;
				bool flag59 = num71 < 0f;
				num69 = 0f;
				if (!flag59)
				{
					bool flag60 = !((double)num71 > 1.0);
					num69 = num71;
					if (!flag60)
					{
						num69 = 1f;
					}
				}
			}
		}
		SetFade(num69);
		float num72 = num67 + num66;
		float num73 = num72 + blackSeconds;
		if (num68 < num73)
		{
			return;
		}
		object obj63 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1176 @ X0_v28+E4]");
		bool flag61 = (nint)0 == 0;
		object obj64 = !flag61;
		if (obj64 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (GillaWounds.Pending)
		{
			double num74 = (double)num73 + 2.5;
			if ((double)num68 < num74)
			{
				return;
			}
		}
		Respawn();
	}

	private unsafe void LookUpAt(Vector3 face, float k)
	{
		//IL_001a: Invalid comparison between F4 and I4
		//IL_006c: Expected F4, but got I
		//IL_00c5: Invalid comparison between F4 and I
		//IL_00f8: Invalid comparison between F4 and I
		//IL_0112: Expected Obj, but got I4
		//IL_0633: Expected Obj, but got I
		//IL_065d: Expected Obj, but got I4
		//IL_01b5: Invalid comparison between F4 and I4
		//IL_01c4: Expected F8, but got I4
		//IL_015c: Expected Obj, but got I4
		//IL_04aa: Invalid comparison between F8 and I4
		//IL_04b9: Invalid comparison between F8 and I4
		//IL_04cc: Expected Obj, but got F8
		//IL_04d9: Expected Obj, but got F8
		//IL_050e: Expected Obj, but got I4
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected Obj, but got Unknown
		//IL_067b: Expected Obj, but got I
		//IL_0693: Expected Obj, but got I
		//IL_06c2: Expected Obj, but got I4
		//IL_0249: Invalid comparison between F4 and I
		//IL_02b6: Expected Obj, but got I
		//IL_02be: Expected F4, but got Obj
		//IL_02ce: Expected F4, but got I
		//IL_02d7: Expected F4, but got I4
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected Obj, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected VT, but got Unknown
		//IL_06fa: Expected Obj, but got I4
		//IL_02fb: Invalid comparison between F4 and I
		//IL_05e9: Expected VT, but got I4
		//IL_05e9: Expected VT, but got I4
		//IL_0391: Invalid comparison between F4 and I4
		//IL_03a0: Invalid comparison between F4 and I4
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Obj, but got Unknown
		//IL_03c1: Expected Obj, but got F4
		//IL_03f6: Expected Obj, but got I4
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_060c: Invalid comparison between F4 and I
		//IL_0460: Expected VT, but got Ref
		//IL_0460: Expected VT, but got I4
		Vector3 position = head.position;
		if (!(biteAt < 0f))
		{
			return;
		}
		float num = k - k;
		object obj2 = default;
		object obj = obj2 - obj2;
		object obj3 = default;
		float num2 = (float)obj3 - (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADA4]");
		float num3 = 0f;
		float num4 = num * num;
		object obj4 = obj * obj;
		float num5 = num4 + (float)obj4;
		float num6 = num2 * num2;
		float num7 = num6 + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADA4]");
		if (num7 < 0f)
		{
			return;
		}
		float num8 = num4 + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		bool flag = !(num8 < 0f);
		float num9 = num;
		object obj5 = 0;
		if (!flag)
		{
			Vector3 forward = head.forward;
			Vector3 forward2 = head.forward;
			num9 = num8;
			num2 = num7;
			obj5 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num10 = num2 * num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFF0");
		float num11 = t;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		float num12 = num11 / 0f;
		bool flag3 = num12 < 0f;
		double num13 = 0.0;
		if (!flag3)
		{
			bool flag4 = !((double)num12 > 1.0);
			num13 = num12;
			if (!flag4)
			{
				num13 = 1.0;
			}
		}
		double num14 = (double)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
		double num15 = num14 * 0.0;
		double num16 = num13 * 1110704128.0;
		double num17 = num15 - num16;
		bool flag5 = num17 < 0.0;
		bool flag6 = num17 == 0.0;
		object obj9 = num15 ^ num16;
		object obj10 = num15 ^ num17;
		object obj11 = obj9 & obj10;
		bool flag7 = (nint)obj11 < 0;
		bool flag8 = flag5 == flag7;
		object obj12 = !flag6;
		object obj13 = flag8 & obj12;
		object obj14 = ~obj13;
		double num18 = ((obj14 != null) ? num16 : num15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj15 = 0;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v13+A0]");
		object obj17 = 0;
		object obj18 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v14+E4]");
		bool flag9 = (nint)0 == 0;
		object obj19 = !flag9;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		float num19;
		float num20;
		float num21;
		if (num10 > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			num19 = 0f / num10;
			num20 = num2 / num10;
			num21 = num9;
			num3 = num10;
		}
		else
		{
			object obj20 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v35+A0]");
			object obj21 = 0;
			num19 = (float)obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v36+8]");
			num20 = 0f;
			num21 = 1.1107041E+09f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v14+20]");
		object obj23 = default;
		object obj22 = 0 * obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
		object obj24 = default;
		float num22 = num20 * (float)obj24;
		float num23 = num3 * num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v14+18]");
		float num24 = 0f * num21;
		Vector3 vector = (Vector3)(num22 - obj22);
		float num25 = num23 - num24;
		float angle = (float)(0.0 - num18);
		Vector3 axis = default;
		Quaternion quaternion = Quaternion.Internal_AngleAxis(angle, ref axis);
		object obj25 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X0_v20+E4]");
		bool flag10 = (nint)0 == 0;
		object obj26 = !flag10;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		if (num10 > 0f)
		{
		}
		Vector3 vector2 = (Quaternion)0 * (Vector3)0;
		Vector3 forward3 = head.forward;
		Vector3 toDirection = default;
		Quaternion quaternion2 = Quaternion.Internal_FromToRotation(ref axis, ref toDirection);
		Quaternion q = default;
		Quaternion.Internal_ToAxisAngleRad(ref q, out Vector3 _, out float angle2);
		float num26 = angle2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
		float num27 = num26 * 0f;
		float num28 = num27 + 3.2833536E+09f;
		float num29 = num27 - 1.1274813E+09f;
		bool flag11 = num29 < 0f;
		bool flag12 = num29 == 0f;
		object obj27 = num27 ^ 0x43340000;
		object obj28 = num27 ^ num29;
		object obj29 = obj27 & obj28;
		bool flag13 = (nint)obj29 < 0;
		bool flag14 = flag11 == flag13;
		object obj30 = !flag12;
		object obj31 = flag14 & obj30;
		object obj32 = ~obj31;
		if (obj32 == null)
		{
			num27 = num28;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		if (num28 > 0f)
		{
			Transform transform = base.transform;
			Vector3 position2 = head.position;
			transform.RotateAround((Vector3)0, (Vector3)(&angle2), num27);
		}
	}

	private Vector3 Unblocked(Vector3 from, Vector3 target)
	{
		//IL_061e: Expected Obj, but got I
		//IL_0626: Expected VT, but got Obj
		//IL_0655: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_0104: Expected VT, but got I4
		//IL_0104: Expected VT, but got I8
		//IL_0118: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I4
		//IL_0506: Expected Obj, but got I
		//IL_0516: Expected Obj, but got I
		//IL_0538: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I4
		//IL_04ec: Expected VT, but got Obj
		//IL_020e: Expected VT, but got Obj
		//IL_0556: Expected Obj, but got I
		//IL_0570: Expected Obj, but got I
		//IL_0581: Expected I, but got Obj
		//IL_059f: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I
		//IL_0230: Expected Obj, but got I8
		//IL_0240: Expected Obj, but got I
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0257: Expected VT, but got I4
		//IL_0260: Expected Obj, but got I4
		//IL_05d7: Expected Obj, but got I4
		//IL_02f3: Expected Obj, but got I4
		//IL_02fb: Expected VT, but got I4
		//IL_044f: Expected Obj, but got I4
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected Obj, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected Obj, but got Unknown
		//IL_0483: Expected VT, but got Obj
		//IL_0333: Expected Obj, but got I4
		//IL_0377: Expected VT, but got I4
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected Obj, but got Unknown
		//IL_042f: Expected VT, but got I4
		//IL_0437: Expected VT, but got I4
		object obj = default;
		float num2 = default;
		float num = (float)obj - num2;
		object obj3 = default;
		object obj4 = default;
		object obj2 = obj3 - obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj5 = 0;
		Vector3 result = (Vector3)obj5;
		object obj7 = default;
		object obj8 = default;
		object obj6 = obj7 - obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v5 (UnityEngine.Vector3)+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = obj6 * obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		if ((nint)obj4 >= 0)
		{
			float num3 = num / (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
			object obj11 = 0;
			object obj12 = obj11;
			object obj13 = obj2 / obj4;
			object obj14 = obj6 / obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj15 = !flag2;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			object obj16 = obj4 + 0;
			IntPtr intPtr = default;
			RaycastHit[] array = Physics.RaycastAll((Vector3)4294965499L, (Vector3)1, num2, 0, (QueryTriggerInteraction)(nint)intPtr);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC510]");
			object obj17 = 0;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v15+E4]");
			bool flag3 = (nint)0 == 0;
			object obj19 = !flag3;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj18 = obj17;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v15+A0]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X9_v5+8]");
			Comparison<RaycastHit> comparison = (Comparison<RaycastHit>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X9_v5+8]");
			bool flag4 = (nint)0 == 0;
			object obj21 = !flag4;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v15+E4]");
				bool flag5 = (nint)0 == 0;
				object obj22 = !flag5;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj23 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v37+A0]");
					obj20 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC500]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC508]");
				object obj25 = 0;
				Comparison<RaycastHit> comparison2 = default;
				comparison2._002Ector(obj20, (IntPtr)obj25);
				object obj26 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v36+A0]");
				object obj27 = (nint)0 + (nint)8;
				obj27 = comparison2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				comparison = comparison2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC4F8]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34C553C");
			if (array == null)
			{
				goto IL_04d0;
			}
			bool flag6 = array.Length < 1;
			result = (Vector3)array;
			if (!flag6)
			{
				object obj29 = array.Length & 0xFFFFFFFFL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj30 = 0;
				object obj31 = array + 32;
				RaycastHit raycastHit = (RaycastHit)0;
				object obj32 = 0;
				object obj38 = default;
				while (true)
				{
					bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29);
					object obj33 = !flag7;
					if (obj33 != null)
					{
						break;
					}
					Collider collider = raycastHit.collider;
					Vector3 vector;
					if ((object)collider != null)
					{
						Transform transform = collider.transform;
						Transform parent = base.transform;
						if ((object)transform != null)
						{
							bool flag8 = transform.IsChildOf(parent);
							bool flag9 = !flag8;
							object obj34 = !flag9;
							result = (Vector3)flag8;
							if (obj34 != null)
							{
								goto IL_0445;
							}
							object obj35 = obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v27+E4]");
							bool flag10 = (nint)0 == 0;
							object obj36 = !flag10;
							if (obj36 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag11 = Killer__BackingField != null;
							bool flag12 = !flag11;
							vector = (Vector3)flag11;
							if (flag12)
							{
								goto IL_0496;
							}
							Collider collider2 = raycastHit.collider;
							if ((object)collider2 != null)
							{
								Transform transform2 = collider2.transform;
								if ((object)Killer__BackingField != null)
								{
									Transform parent2 = Killer__BackingField.transform;
									if ((object)transform2 != null)
									{
										bool flag13 = transform2.IsChildOf(parent2);
										bool flag14 = !flag13;
										result = (Vector3)flag13;
										vector = (Vector3)flag13;
										if (!flag14)
										{
											goto IL_0445;
										}
										goto IL_0496;
									}
								}
							}
						}
					}
					goto IL_04d0;
					IL_0445:
					obj29 = array.Length;
					obj32++;
					obj31 += 48;
					bool flag15 = (nint)obj32 < array.Length;
					raycastHit = (RaycastHit)obj31;
					if (flag15)
					{
						continue;
					}
					goto IL_04f1;
					IL_0496:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADCC]");
					object obj37 = obj38 + 0;
					if ((nint)obj37 < 0)
					{
					}
					result = vector;
					goto IL_04f1;
				}
				goto IL_04de;
			}
		}
		goto IL_04f1;
		IL_04d0:
		NullReferenceException ex = new NullReferenceException();
		goto IL_04de;
		IL_04f1:
		return result;
		IL_04de:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (Vector3)ex2;
	}

	public unsafe void Heal()
	{
		//IL_0010: Expected Obj, but got I
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got I4
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got I4
		//IL_0788: Expected Obj, but got I4
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected Ref, but got Unknown
		//IL_07ab: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I4
		//IL_00ef: Expected Obj, but got I4
		//IL_01a4: Expected Obj, but got I4
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_05d9: Expected Obj, but got I4
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected Obj, but got I4
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got I4
		//IL_067b: Expected Obj, but got I4
		//IL_0684: Expected Obj, but got I4
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected I4, but got Unknown
		//IL_02a7: Expected Obj, but got I4
		//IL_076d: Expected Obj, but got I4
		//IL_0315: Expected Obj, but got I4
		//IL_03d1: Expected Obj, but got I
		//IL_03f3: Expected Obj, but got I4
		//IL_049e: Expected Obj, but got I4
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected Obj, but got I4
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected Obj, but got I
		//IL_04e6: Expected Obj, but got I4
		//IL_054a: Expected Obj, but got I4
		//IL_05a3: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE11C]");
		List<Renderer> list = (List<Renderer>)0;
		bool flag = (object)hiddenBody == null;
		UnityEngine.Object obj = default;
		List<Renderer> list2 = (List<Renderer>)obj;
		Enumerator<, > val = (Enumerator<, >)0;
		IntPtr intPtr = default;
		UnityEngine.Object obj2 = (UnityEngine.Object)(nint)intPtr;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A00]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49F8]");
			bool flag2 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
			object obj5 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)hiddenBody).GetEnumerator();
			UnityEngine.Object obj6 = obj;
			Enumerator<, > val2 = default;
			object obj14 = default;
			while (true)
			{
				object obj10;
				Enumerator<, > val4;
				Enumerator<, > val5;
				Enumerator<, > val3;
				object obj9;
				if (val.MoveNext())
				{
					object obj7 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v54+E4]");
					list = (List<Renderer>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v54+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = obj != null;
					bool flag5 = !flag4;
					obj9 = 0;
					obj6 = list;
					if (!flag5)
					{
						if ((object)obj == null)
						{
							NullReferenceException ex = new NullReferenceException();
							obj9 = 0;
							list2 = null;
							val = val2;
							obj10 = 0;
							val3 = (Enumerator<, >)(ref val);
							val4 = val2;
							val5 = (Enumerator<, >)(ref val);
							obj2 = null;
							break;
						}
						((Renderer)obj).enabled = true;
						obj9 = 0;
						obj6 = list;
					}
					continue;
				}
				list2 = null;
				val = val2;
				obj10 = 0;
				val3 = (Enumerator<, >)(ref val);
				val4 = val2;
				val5 = (Enumerator<, >)(ref val);
				list = (List<Renderer>)obj6;
				object obj11 = 0;
				while (true)
				{
					obj2 = (UnityEngine.Object)((bool*)(flag2 ? 1 : 0))->m_value;
					((Enumerator<, >*)val5)->Dispose();
					bool flag6 = obj11 == null;
					object obj12 = !flag6;
					if (obj12 == null)
					{
						bool flag7 = (object)list2 == null;
						object obj13 = !flag7;
						OutOfMemoryException ex2 = (OutOfMemoryException)val5;
						list = list2;
						if (obj13 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex2 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj2 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						list2 = (List<Renderer>)1;
						list = (List<Renderer>)1;
						obj11 = obj10;
						continue;
					}
					if ((nint)obj2 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj11 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj10 = obj14;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D088");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				list = hiddenBody;
				if ((object)hiddenBody == null)
				{
					break;
				}
				val3 = (Enumerator<, >)(list._version + 1);
				list._size = 0;
				list._version = (int)val3;
				bool flag8 = list._size < 1;
				int value = (((bool*)(flag2 ? 1 : 0))->m_value ? 1 : 0);
				if (!flag8)
				{
					Array.Clear(list._items, 0, list._size);
					value = 0;
				}
				object obj15 = obj4;
				Hits__BackingField = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v6+E4]");
				bool flag9 = (nint)0 == 0;
				object obj16 = !flag9;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (locomotion != null)
				{
					Player player = locomotion;
					bool flag10 = (object)locomotion == null;
					obj9 = 0;
					obj2 = null;
					list = (List<Renderer>)(object)locomotion;
					if (flag10)
					{
						break;
					}
					if (~(player.leftHandDisabled ? 1u : 0u) == 0)
					{
						val3 = (Enumerator<, >)player.leftHandDisabled;
						flag2 = false;
					}
					else
					{
						bool flag11 = !player.rightHandDisabled;
						val3 = (Enumerator<, >)player.leftHandDisabled;
						flag2 = flag11;
					}
				}
				else
				{
					flag2 = true;
				}
				object obj17 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v10+E4]");
				bool flag12 = (nint)0 == 0;
				object obj18 = !flag12;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaWounds.FinishAll();
				object obj19 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v13+E4]");
				list = (List<Renderer>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v13+E4]");
				bool flag13 = (nint)0 == 0;
				object obj20 = !flag13;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag14 = dismember != null;
				bool flag15 = !flag14;
				UnityEngine.Object obj21 = null;
				if (!flag15)
				{
					bool flag16 = (object)dismember == null;
					obj9 = 0;
					obj2 = null;
					if (flag16)
					{
						break;
					}
					dismember.ResetAll();
					obj21 = null;
				}
				bool flag17 = !flag2;
				object obj22 = !flag17;
				if (obj22 != null)
				{
					return;
				}
				object obj23 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v19+E4]");
				list = (List<Renderer>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v19+E4]");
				bool flag18 = (nint)0 == 0;
				object obj24 = !flag18;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(locomotion != null))
				{
					return;
				}
				bool flag19 = (object)locomotion == null;
				obj9 = 0;
				obj2 = null;
				if (flag19)
				{
					break;
				}
				if (locomotion.enabled)
				{
					bool flag20 = (object)locomotion == null;
					obj9 = 0;
					obj2 = null;
					if (flag20)
					{
						break;
					}
					locomotion.InitializeValues();
				}
				return;
			}
		}
		throw new NullReferenceException();
	}

	public void HideBody()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0552: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I8
		//IL_0110: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I4
		//IL_05a0: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I
		//IL_01bc: Expected Obj, but got I4
		//IL_01c5: Expected Obj, but got I4
		//IL_04e6: Expected Obj, but got I4
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got I
		//IL_025c: Expected Obj, but got I4
		//IL_0274: Expected Obj, but got I4
		//IL_027d: Expected Obj, but got I4
		//IL_0579: Expected Obj, but got I4
		//IL_02c5: Expected Obj, but got I
		//IL_049a: Expected Obj, but got I
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_0301: Expected Obj, but got I
		//IL_033f: Expected I4, but got Obj
		//IL_03a3: Expected Obj, but got I4
		//IL_043e: Expected Obj, but got I
		//IL_044e: Expected Obj, but got I
		//IL_045e: Expected Obj, but got I
		//IL_0475: Expected Obj, but got I
		//IL_0485: Expected Obj, but got I
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_0406: Expected Obj, but got I
		//IL_0419: Expected Obj, but got I4
		//IL_0429: Expected Obj, but got I
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
		bool flag2 = dismember == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		DismemberGroup dismemberGroup = dismember;
		if ((object)dismember == null)
		{
			goto IL_0513;
		}
		Dismemberment[] copies = dismemberGroup.copies;
		if (dismemberGroup.copies == null || copies.Length < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75C0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4188]");
		object obj6 = 0;
		object obj7 = copies.Length & 0xFFFFFFFFL;
		object obj8 = 0;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		object obj16 = default;
		while (true)
		{
			bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
			object obj11 = !flag4;
			if (obj11 != null)
			{
				break;
			}
			object obj12 = obj;
			object obj13 = (object)dismemberGroup.copies + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v12+E4]");
			int num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v12+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v11+20]");
			bool flag6 = (UnityEngine.Object)0 == null;
			bool flag7 = !flag6;
			object obj15 = !flag7;
			obj9 = 0;
			obj10 = null;
			if (obj15 != null)
			{
				goto IL_04dc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v11+20]");
			if ((nint)0 != 0)
			{
				obj10 = (UnityEngine.Object)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
				if (obj16 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v18+18]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v18+18]");
					bool flag8 = (nint)0 < (nint)1;
					obj9 = 0;
					if (!flag8)
					{
						object obj18 = 0;
						object obj19 = 0;
						while (true)
						{
							bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17);
							object obj20 = !flag9;
							if (obj20 != null)
							{
								break;
							}
							object obj21 = obj16 + obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v16+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v16+20]");
								bool flag10 = ((Renderer)0).enabled;
								bool flag11 = !flag10;
								obj10 = null;
								if (flag11)
								{
									goto IL_048a;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v16+20]");
								((Renderer)0).enabled = false;
								List<System.__Canon> list = (List<System.__Canon>)(object)hiddenBody;
								if ((object)hiddenBody != null)
								{
									System.__Canon[] items = list._items;
									num = (int)obj6;
									int version = list._version + 1;
									list._version = version;
									if (list._items != null)
									{
										bool flag12 = list._size < items.Length;
										object obj22 = !flag12;
										if (obj22 == null)
										{
											object obj23 = list._items + list._size;
											num = list._size + 1;
											list._size = num;
											object obj24 = obj23 + 32;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v16+20]");
											obj24 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											obj19 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v16+20]");
											obj10 = (UnityEngine.Object)0;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X9_v8 (System.Int32)+20]");
											object obj25 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v20+A8]");
											object obj26 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v21+70]");
											obj19 = 0;
											List<Renderer> list2 = hiddenBody;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v16+20]");
											((List<System.__Canon>)(object)list2).AddWithResize((System.__Canon)0);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v16+20]");
											obj10 = (UnityEngine.Object)0;
										}
										goto IL_048a;
									}
								}
							}
							goto IL_0513;
							IL_048a:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v18+18]");
							obj17 = 0;
							object obj27 = obj18 + 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v18+18]");
							bool flag13 = (nint)obj27 < 0;
							obj9 = obj19;
							obj18 = obj27;
							if (flag13)
							{
								continue;
							}
							goto IL_04dc;
						}
						break;
					}
					goto IL_04dc;
				}
			}
			goto IL_0513;
			IL_04dc:
			obj7 = copies.Length;
			obj8++;
			if ((nint)obj8 >= copies.Length)
			{
				return;
			}
		}
		goto IL_0521;
		IL_0521:
		throw new IndexOutOfRangeException();
		IL_0513:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0521;
	}

	private void Respawn()
	{
		//IL_00df: Expected Obj, but got I
		//IL_011a: Expected VT, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_014f: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		float time = Time.time;
		doorCut = false;
		backAt = time;
		Heal();
		IntPtr intPtr = default;
		Quaternion rot = default;
		Vector3 velocity = default;
		Release((Vector3)(nint)intPtr, rot, velocity);
		object obj2 = obj;
		object obj3 = this + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj5 = 0;
		Transform back;
		if ((UnityEngine.Object)obj3 != null)
		{
			back = (Transform)obj3;
		}
		else
		{
			Transform transform = Back();
			back = transform;
		}
		onceAt = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Home(back);
		SetFade(0f);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v10+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v11+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v11+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v125 @ X8_v12+18] (should have been resolved before IL gen)");
		}
		FellInPit__BackingField = false;
	}

	public void SendHome()
	{
		Transform back = Back();
		Home(back);
	}

	private Transform Back()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01ba: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			if (obj3 != null)
			{
				GameObject gameObject = ((Component)obj3).gameObject;
				if ((object)gameObject != null)
				{
					bool activeInHierarchy = gameObject.activeInHierarchy;
					bool flag4 = !activeInHierarchy;
					object obj6 = !flag4;
					obj5 = null;
					if (obj6 == null)
					{
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						obj5 = null;
					}
					goto IL_00f2;
				}
			}
			return (Transform)(object)new NullReferenceException();
		}
		goto IL_00f2;
		IL_00f2:
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj3 != null)
		{
			return (Transform)obj3;
		}
		return ModeLobby();
	}

	public static Transform ModeLobby()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_074d: Expected Obj, but got I4
		//IL_0773: Expected Obj, but got I
		//IL_0795: Expected Obj, but got I4
		//IL_09e5: Expected Obj, but got I
		//IL_0a07: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I
		//IL_07cd: Expected Obj, but got I4
		//IL_0a25: Expected Obj, but got I
		//IL_0a35: Expected Obj, but got I
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got I
		//IL_01fe: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I4
		//IL_0839: Expected Obj, but got I4
		//IL_0855: Expected Obj, but got I4
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_0291: Expected Obj, but got I
		//IL_02bb: Expected Obj, but got I4
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected Obj, but got Unknown
		//IL_021e: Expected Obj, but got I4
		//IL_0227: Expected Obj, but got I4
		//IL_04f2: Expected Obj, but got I
		//IL_051c: Expected Obj, but got I4
		//IL_0895: Expected Obj, but got I4
		//IL_0a72: Expected Obj, but got I
		//IL_0a94: Expected Obj, but got I4
		//IL_094f: Expected Obj, but got I4
		//IL_0329: Expected Obj, but got I4
		//IL_0b1c: Expected Obj, but got I
		//IL_0b3e: Expected Obj, but got I4
		//IL_036e: Expected Obj, but got I4
		//IL_05be: Expected Obj, but got I4
		//IL_08cd: Expected Obj, but got I4
		//IL_0ab2: Expected Obj, but got I
		//IL_0987: Expected Obj, but got I4
		//IL_0b5c: Expected Obj, but got I
		//IL_03d1: Expected Obj, but got I4
		//IL_0400: Expected Obj, but got I
		//IL_041c: Expected Obj, but got I4
		//IL_0621: Expected Obj, but got I4
		//IL_0650: Expected Obj, but got I
		//IL_0461: Expected Obj, but got I4
		//IL_06a0: Expected Obj, but got I4
		//IL_0905: Expected Obj, but got I4
		//IL_0ae7: Expected Obj, but got I
		//IL_09bf: Expected Obj, but got I4
		//IL_0b91: Expected Obj, but got I
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj2 = 0;
		string currentName = GillaPlaces.CurrentName;
		object obj3 = obj2;
		string text = (string)((currentName != null) ? currentName : obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v8+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v2+8]");
		object obj17;
		if ((UnityEngine.Object)0 != null)
		{
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v112+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v116+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v116+A0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v67+8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v67+8]");
			if ((nint)0 == 0)
			{
				goto IL_06ec;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v68+90]");
			obj17 = 0;
		}
		else
		{
			obj17 = 0;
		}
		object obj21;
		object obj23;
		object obj22;
		string text2;
		if (text != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC518]");
			object value = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8310]");
			object obj18 = 0;
			bool flag6;
			if (text.StartsWith((string)value))
			{
				flag6 = true;
			}
			else if (text._stringLength != 0)
			{
				flag6 = false;
			}
			else
			{
				object obj19 = obj17 - 1;
				bool flag7 = obj19 == null;
				flag6 = flag7;
			}
			text2 = (string)obj18;
			if (text.StartsWith((string)obj18))
			{
				bool flag8 = !flag6;
				object obj20 = !flag8;
				obj21 = 0;
				if (obj20 != null)
				{
					goto IL_0281;
				}
				obj22 = 0;
				obj23 = 0;
			}
			else
			{
				bool flag9;
				if (text._stringLength == 0)
				{
					object obj24 = obj17 - 2;
					flag9 = obj24 == null;
				}
				else
				{
					flag9 = false;
				}
				object obj25 = !flag9;
				bool flag10 = !flag6;
				obj21 = obj25;
				obj22 = 0;
				obj23 = obj25;
				if (!flag10)
				{
					goto IL_0281;
				}
			}
			goto IL_04ad;
		}
		goto IL_06ec;
		IL_06ec:
		return (Transform)(object)new NullReferenceException();
		IL_0913:
		object obj26;
		Transform result = (Transform)obj26;
		goto IL_0920;
		IL_0920:
		return result;
		IL_0281:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
		object obj27 = 0;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v67+E4]");
		bool flag11 = (nint)0 == 0;
		object obj29 = !flag11;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj30 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v71+E4]");
		bool flag12 = (nint)0 == 0;
		object obj31 = !flag12;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj27;
		}
		object obj32 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v71+A0]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v43+E4]");
		bool flag13 = (nint)0 == 0;
		object obj34 = !flag13;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = (UnityEngine.Object)obj33 != null;
		bool flag15 = !flag14;
		obj22 = 0;
		text2 = null;
		obj23 = obj21;
		if (flag15)
		{
			goto IL_04ad;
		}
		object obj35 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v75+E4]");
		bool flag16 = (nint)0 == 0;
		object obj36 = !flag16;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj37 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v79+E4]");
		bool flag17 = (nint)0 == 0;
		object obj38 = !flag17;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj37 = obj27;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v79+A0]");
		object obj39 = 0;
		object obj40 = obj39;
		if (obj39 != null)
		{
			object obj41 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v80+E4]");
			bool flag18 = (nint)0 == 0;
			object obj42 = !flag18;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v49+48]");
			bool flag19 = (UnityEngine.Object)0 != null;
			bool flag20 = !flag19;
			obj22 = 0;
			text2 = null;
			obj23 = obj21;
			if (flag20)
			{
				goto IL_04ad;
			}
			object obj43 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X0_v84+E4]");
			bool flag21 = (nint)0 == 0;
			object obj44 = !flag21;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj45 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v88+E4]");
			bool flag22 = (nint)0 == 0;
			object obj46 = !flag22;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj45 = obj27;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v88+A0]");
			object obj47 = 0;
			if (obj47 != null)
			{
				obj26 = obj47 + 72;
				goto IL_0913;
			}
		}
		goto IL_06ec;
		IL_04ad:
		object obj48 = obj23 & 1;
		if (obj48 != null)
		{
			result = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8158]");
			object obj49 = 0;
			object obj50 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v21+E4]");
			bool flag23 = (nint)0 == 0;
			object obj51 = !flag23;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj52 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X0_v25+E4]");
			bool flag24 = (nint)0 == 0;
			object obj53 = !flag24;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj52 = obj49;
			}
			object obj54 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X0_v25+A0]");
			object obj55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v19+E4]");
			bool flag25 = (nint)0 == 0;
			object obj56 = !flag25;
			if (obj56 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag26 = (UnityEngine.Object)obj55 != null;
			bool flag27 = !flag26;
			result = null;
			if (!flag27)
			{
				object obj57 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X0_v30+E4]");
				bool flag28 = (nint)0 == 0;
				object obj58 = !flag28;
				if (obj58 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj59 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v34+E4]");
				bool flag29 = (nint)0 == 0;
				object obj60 = !flag29;
				if (obj60 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj59 = obj49;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v34+A0]");
				object obj61 = 0;
				object obj62 = obj61;
				if (obj61 != null)
				{
					object obj63 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X0_v35+E4]");
					bool flag30 = (nint)0 == 0;
					object obj64 = !flag30;
					if (obj64 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v26+50]");
					bool flag31 = (UnityEngine.Object)0 != null;
					bool flag32 = !flag31;
					result = null;
					if (flag32)
					{
						goto IL_0920;
					}
					object obj65 = obj49;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v40+E4]");
					bool flag33 = (nint)0 == 0;
					object obj66 = !flag33;
					if (obj66 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj67 = obj49;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v44+E4]");
					bool flag34 = (nint)0 == 0;
					object obj68 = !flag34;
					if (obj68 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj67 = obj49;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v44+A0]");
					object obj69 = 0;
					if (obj69 != null)
					{
						obj26 = obj69 + 80;
						goto IL_0913;
					}
				}
				goto IL_06ec;
			}
		}
		goto IL_0920;
	}

	private void Home(Transform back)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_00db: Expected VT, but got I4
		//IL_00db: Expected VT, but got I4
		//IL_00e8: Expected VT, but got I4
		//IL_008f: Expected VT, but got I4
		//IL_0077: Expected VT, but got I4
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
		Vector3 facing;
		if (back != null)
		{
			Vector3 position = back.position;
			Vector3 forward = back.forward;
			facing = (Vector3)0;
		}
		else
		{
			Vector3 vector = (Quaternion)0 * (Vector3)0;
			facing = (Vector3)0;
		}
		bool flag2 = GillaTeleport.To((Vector3)0, facing);
	}

	private void Release(Vector3 pos, Quaternion rot, Vector3 velocity)
	{
		//IL_0395: Expected Obj, but got I
		//IL_03ad: Expected Obj, but got I
		//IL_03c2: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0027: Expected VT, but got I4
		//IL_0051: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_009f: Expected VT, but got I4
		//IL_034d: Expected Obj, but got I
		//IL_0377: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I4
		//IL_00d2: Expected VT, but got I4
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_02c5: Expected Obj, but got I4
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_02e3: Expected Obj, but got I4
		//IL_00e7: Expected VT, but got I4
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_0306: Expected Obj, but got I4
		//IL_01ec: Expected Obj, but got I
		//IL_0216: Expected Obj, but got I4
		//IL_00fc: Expected VT, but got I4
		//IL_0256: Expected Obj, but got I4
		//IL_025f: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I
		//IL_0129: Expected VT, but got I4
		//IL_013d: Expected Obj, but got I4
		//IL_0146: Expected VT, but got I4
		//IL_0296: Expected Obj, but got I4
		flying = 0f;
		Knocked__BackingField = false;
		tipped = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5+A0]");
		object obj3 = 0;
		BlownApart__BackingField = false;
		DeathVelocity__BackingField = (Vector3)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v6+8]");
		_ = 0;
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		transform.SetPositionAndRotation((Vector3)0, rot);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = body != null;
		bool flag3 = !flag2;
		object obj7 = 0;
		Vector3 vector = (Vector3)0;
		if (!flag3)
		{
			body.isKinematic = false;
			body.position = (Vector3)0;
			body.rotation = (Quaternion)0;
			body.linearVelocity = (Vector3)0;
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v20+A0]");
			object obj9 = 0;
			body.angularVelocity = (Vector3)0;
			restoreInterp = true;
			obj7 = 0;
			vector = (Vector3)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Physics.SyncTransforms();
		object obj13 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v15+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = locomotion != null;
		bool flag7 = !flag6;
		object obj15 = 0;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v28+E4]");
			bool flag8 = (nint)0 == 0;
			object obj18 = !flag8;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isMonster = MonsterPlayer.IsMonster;
			bool flag9 = !isMonster;
			object obj19 = !flag9;
			obj15 = 0;
			if (obj19 == null)
			{
				locomotion.InitializeValues();
				locomotion.enabled = true;
				obj15 = 0;
			}
		}
		Busy__BackingField = false;
		dying = false;
		object obj20 = this + 192;
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj21 = this + 216;
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj22 = this + 208;
		obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 0;
	}

	private void BuildFade()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0444: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_0192: Expected Obj, but got I
		//IL_01a0: Expected VT, but got I4
		//IL_01e8: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_0255: Expected Obj, but got I
		//IL_0282: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I
		//IL_02d4: Expected Obj, but got I
		//IL_0301: Expected Obj, but got I
		//IL_032a: Expected Obj, but got I
		//IL_0353: Expected Obj, but got I
		//IL_037c: Expected Obj, but got I
		//IL_03b0: Expected Obj, but got I
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
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
		if (!(head == null))
		{
			GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC4E8]");
			object obj4 = 0;
			gameObject.name = (string)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7560]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj8 = default;
			UnityEngine.Object.Destroy(obj8);
			Transform transform = gameObject.transform;
			transform.SetParent(head, worldPositionStays: false);
			Transform transform2 = gameObject.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v14+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v15+C]");
			object obj13 = default;
			object obj12 = 0 * obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v15+14]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			object obj14 = num * 0;
			transform2.localScale = (Vector3)0;
			GameObject gameObject2 = head.gameObject;
			int layer = gameObject2.layer;
			gameObject.layer = layer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B40]");
			object obj15 = 0;
			Shader shader = Shader.Find((string)obj15);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56C8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Material material = default;
			material._002Ector(shader);
			object obj17 = this + 296;
			fadeMat = material;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B48]");
			object obj18 = 0;
			fadeMat.SetFloat((string)obj18, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC4F0]");
			object obj19 = 0;
			fadeMat.SetFloat((string)obj19, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B28]");
			object obj20 = 0;
			fadeMat.SetFloat((string)obj20, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B38]");
			object obj21 = 0;
			fadeMat.SetFloat((string)obj21, 8f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B30]");
			object obj22 = 0;
			fadeMat.SetInt((string)obj22, 5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B50]");
			object obj23 = 0;
			fadeMat.SetInt((string)obj23, 10);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B60]");
			object obj24 = 0;
			fadeMat.SetInt((string)obj24, 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B58]");
			object keyword = 0;
			fadeMat.EnableKeyword((string)keyword);
			fadeMat.renderQueue = 5000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B18]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
			Renderer renderer = default;
			fade = renderer;
			object obj26 = this + 288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			fade.sharedMaterial = fadeMat;
			fade.shadowCastingMode = (ShadowCastingMode)0;
			SetFade(0f);
		}
	}

	private void SetFade(float a)
	{
		//IL_0010: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I4
		//IL_0072: Invalid comparison between F4 and I4
		//IL_0081: Invalid comparison between F4 and I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00a9: Expected Obj, but got F4
		//IL_00de: Expected Obj, but got I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected I4, but got Unknown
		//IL_010f: Expected Obj, but got I
		//IL_0123: Expected VT, but got I4
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
		if (!(fade == null))
		{
			float num = a;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
			float num2 = num - 0f;
			bool flag2 = num2 < 0f;
			bool flag3 = num2 == 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
			object obj4 = a ^ 0;
			object obj5 = a ^ num2;
			object obj6 = obj4 & obj5;
			bool flag4 = (nint)obj6 < 0;
			bool flag5 = flag2 == flag4;
			object obj7 = !flag3;
			bool flag6 = (byte)((flag5 & obj7) ? 1 : 0) != 0;
			fade.enabled = flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
			object obj8 = 0;
			fadeMat.SetColor((string)obj8, (Color)0);
		}
	}

	private static void Buzz(float amp, float seconds)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I8
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00c1: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_012d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB98]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+18]");
			bool flag = (nint)0 == 1;
			_ = 4;
			if (!flag)
			{
				_ = 5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+18]");
				if ((nint)0 < (nint)1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+18]");
				object obj2 = 0 & 0xFFFFFFFFL;
				object obj4 = default;
				object obj3 = obj4 + 32;
				object obj5 = 0;
				InputDevice inputDevice = default;
				while (true)
				{
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
					object obj6 = !flag2;
					if (obj6 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X21_v5+v137 @ X20_v7*4]");
					InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode((XRNode)0);
					if (inputDevice.isValid)
					{
						bool flag3 = inputDevice.SendHapticImpulse(0u, amp, seconds);
						object obj7 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+18]");
					obj2 = 0;
					obj5++;
					object obj8 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+18]");
					if ((nint)obj8 >= 0)
					{
						return;
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public KillCam()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002f: Expected F4, but got I
		//IL_0041: Expected F4, but got I
		//IL_0053: Expected F4, but got I
		//IL_0070: Expected F4, but got I
		//IL_008d: Expected F4, but got I
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41A0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C930]");
		follow = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C1C8]");
		maxSeconds = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107DD60]");
		thrownSpeed = 0f;
		heldEyesOver = 0.36f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BDB8]");
		launchGrace = 0f;
		punchesToKill = 3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F160]");
		downSeconds = 0f;
		downRise = 0.45f;
		biteAt = -1f;
		backAt = -100f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj2 = this + 392;
		hiddenBody = (List<Renderer>)(object)list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
