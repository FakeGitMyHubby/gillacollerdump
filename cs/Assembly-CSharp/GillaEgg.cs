using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class GillaEgg : NetworkBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<GillaDynamite, bool> _003C_003E9__67_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0768]");
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

		internal bool _003CSpawned_003Eb__67_0(GillaDynamite d)
		{
			//IL_0056: Expected I4, but got Obj
			//IL_0035: Expected Obj, but got I4
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected I4, but got Unknown
			if ((object)d != null)
			{
				bool isBlown = d.IsBlown;
				object obj = !isBlown;
				return (byte)(1 & obj) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public GillaItem item;

	public float breakSpeed;

	public float hitsAt;

	public GillaEggMess shards;

	public GillaEggMess puddle;

	public GillaEggMess splat;

	public AudioClip[] crackSounds;

	public AudioClip[] splatSounds;

	public float stain;

	private const float BodyDown = default(float);

	private const float BodyRound = default(float);

	private const float MonsterRound = default(float);

	private const float NotYouFor = default(float);

	private NetworkBool _Broken;

	private bool broke;

	private Vector3 lastAt;

	private float letGoAt;

	private int wasHand;

	private readonly GillaNetGuard.Holder holder;

	private const float BrokeSlack = default(float);

	private const float BrokeBudget = default(float);

	private unsafe NetworkBool Broken
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

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51E0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			GillaItem gillaItem = default;
			item = gillaItem;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Vector3 vector = default;
		lastAt = vector;
	}

	public override void Spawned()
	{
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Vector3 vector = default;
		lastAt = vector;
		NetworkBool broken = Broken;
		if ((bool)broken)
		{
			Hide();
		}
	}

	private void Update()
	{
		//IL_0357: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I4
		//IL_0059: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I4
		//IL_00fe: Expected I4, but got I8
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_01f2: Expected VT, but got F4
		//IL_012f: Expected I4, but got I8
		//IL_0149: Expected Obj, but got I4
		//IL_0272: Expected Obj, but got I4
		//IL_0289: Invalid comparison between F4 and I4
		//IL_029a: Expected Obj, but got I4
		//IL_02a3: Invalid comparison between F4 and I4
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_030d: Invalid comparison between F4 and I4
		//IL_0331: Expected VT, but got I4
		//IL_0331: Expected VT, but got I4
		bool live = Live;
		bool flag = !live;
		IntPtr intPtr = default;
		NetworkObject networkObject = (NetworkObject)(nint)intPtr;
		if (!flag)
		{
			networkObject = ((SimulationBehaviour)this)._object;
			holder.Watch(((SimulationBehaviour)this)._object);
		}
		bool flag2 = (byte)(~(broke ? 1u : 0u)) != 0;
		object obj = !flag2;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = item == null;
		bool flag5 = !flag4;
		object obj5 = !flag5;
		if (obj5 != null)
		{
			return;
		}
		GillaItem gillaItem = item;
		if ((int)(gillaItem.Hand__BackingField & 0x80000000L) != 0)
		{
			int num = (int)(wasHand & 0x80000000L);
			bool flag6 = num == 0;
			object obj6 = !flag6;
			if (obj6 == null)
			{
				float time = Time.time;
				gillaItem = item;
				letGoAt = time;
			}
		}
		wasHand = gillaItem.Hand__BackingField;
		float deltaTime = Time.deltaTime;
		Transform transform = base.transform;
		Vector3 position = transform.position;
		float num2 = deltaTime - (float)lastAt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaEgg)+B0]");
		object obj8 = default;
		object obj7 = obj8 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaEgg)+B4]");
		object obj10 = default;
		object obj9 = obj10 - 0;
		lastAt = (Vector3)deltaTime;
		if (!item.Mine)
		{
			return;
		}
		GillaItem gillaItem2 = item;
		if (~(gillaItem2.Gone__BackingField ? 1u : 0u) == 0)
		{
			return;
		}
		bool flag7 = (byte)(~(gillaItem2.Swallowed__BackingField ? 1u : 0u)) != 0;
		object obj11 = !flag7;
		if (obj11 != null)
		{
			return;
		}
		bool flag8 = deltaTime < 0f;
		object obj12 = !flag8;
		bool flag9 = deltaTime == 0f;
		object obj13 = ~obj12;
		object obj14 = obj13 | flag9;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
			float num3 = num2 / deltaTime;
			if (!(num3 < hitsAt) && !(num3 > 1.1093934E+09f))
			{
				LooksForSomeone((Vector3)0, (Vector3)0);
			}
		}
	}

	private void OnCollisionEnter(Collision hit)
	{
		//IL_01c1: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00e6: Expected I4, but got I8
		//IL_0100: Expected Obj, but got I4
		//IL_015f: Invalid comparison between Obj and F4
		//IL_01a1: Expected VT, but got I4
		//IL_01a1: Expected VT, but got I8
		bool flag = (byte)(~(broke ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = item == null;
		bool flag4 = !flag3;
		object obj5 = !flag4;
		if (obj5 != null || !item.Mine)
		{
			return;
		}
		GillaItem gillaItem = item;
		int num = (int)(gillaItem.Hand__BackingField & 0x80000000L);
		bool flag5 = num == 0;
		object obj6 = !flag5;
		if (obj6 != null && hit.contactCount != 0)
		{
			Vector3 relativeVelocity = hit.relativeVelocity;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
			object obj7 = default;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)breakSpeed))
			{
				ContactPoint contact = hit.GetContact(0);
				int player = default;
				GillaDummy dummy = default;
				Break((Vector3)4294967295L, (Vector3)0, player, dummy);
			}
		}
	}

	public void Smash()
	{
		//IL_0057: Expected VT, but got I4
		//IL_0057: Expected VT, but got I8
		if (~(broke ? 1u : 0u) != 0)
		{
			Transform transform = base.transform;
			Vector3 position = transform.position;
			int player = default;
			GillaDummy dummy = default;
			Break((Vector3)4294967295L, (Vector3)0, player, dummy);
		}
	}

	private unsafe void LooksForSomeone(Vector3 a, Vector3 b)
	{
		//IL_0010: Expected Obj, but got I
		//IL_144d: Expected Obj, but got I4
		//IL_1a14: Expected Obj, but got I
		//IL_1a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7a: Expected F8, but got Unknown
		//IL_1a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa5: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected F8, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_1307: Unknown result type (might be due to invalid IL or missing references)
		//IL_130f: Expected F4, but got Unknown
		//IL_07c4: Expected Obj, but got I4
		//IL_07cd: Expected Obj, but got I4
		//IL_185b: Expected Obj, but got I
		//IL_1863: Expected VT, but got Obj
		//IL_1886: Expected Obj, but got I4
		//IL_188b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1895: Unknown result type (might be due to invalid IL or missing references)
		//IL_189e: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ba: Expected Obj, but got I4
		//IL_18bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_0118: Expected VT, but got I4
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Expected Obj, but got I4
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected Obj, but got Ref
		//IL_122d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1237: Unknown result type (might be due to invalid IL or missing references)
		//IL_125c: Expected VT, but got I4
		//IL_126a: Expected Obj, but got I4
		//IL_1270: Unknown result type (might be due to invalid IL or missing references)
		//IL_128c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1296: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_01cb: Expected VT, but got I4
		//IL_12d6: Expected VT, but got Obj
		//IL_0203: Expected Obj, but got I4
		//IL_14af: Expected Obj, but got I4
		//IL_1acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1adb: Expected Obj, but got Unknown
		//IL_1afd: Expected Obj, but got I4
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected VT, but got I4
		//IL_0536: Expected Obj, but got I4
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected VT, but got I4
		//IL_0339: Expected Obj, but got I4
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected Obj, but got I
		//IL_05a4: Expected VT, but got I4
		//IL_05a4: Expected VT, but got I4
		//IL_05a4: Expected VT, but got Ref
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected F8, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected F8, but got Unknown
		//IL_061f: Expected VT, but got I4
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected I4, but got I8
		//IL_039a: Expected VT, but got I4
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected F8, but got Unknown
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected F8, but got Unknown
		//IL_06ad: Expected VT, but got I4
		//IL_06bb: Expected Obj, but got I4
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Expected VT, but got I4
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Invalid comparison between Unknown and F8
		//IL_03e8: Expected Obj, but got I4
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Invalid comparison between Unknown and F8
		//IL_0418: Invalid comparison between F8 and I4
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected Obj, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Obj, but got Unknown
		//IL_04ac: Expected VT, but got I4
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1345: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected Obj, but got I
		//IL_1365: Invalid comparison between VT and I4
		//IL_13bc: Invalid comparison between VT and I4
		//IL_1b1b: Expected Obj, but got I
		//IL_1b45: Expected Obj, but got I4
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Invalid comparison between F4 and I
		//IL_139e: Expected Obj, but got I4
		//IL_13a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1140: Expected Obj, but got I
		//IL_1158: Expected Obj, but got I
		//IL_1160: Expected F8, but got Obj
		//IL_1170: Expected F4, but got I
		//IL_1180: Expected F8, but got I
		//IL_1400: Unknown result type (might be due to invalid IL or missing references)
		//IL_199c: Expected Obj, but got I
		//IL_19a4: Expected VT, but got Obj
		//IL_19a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ad: Expected Ref, but got Unknown
		//IL_19c7: Expected Obj, but got I4
		//IL_19d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19df: Expected F4, but got Unknown
		//IL_19df: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e7: Expected F4, but got Unknown
		//IL_14e1: Expected VT, but got I4
		//IL_14e1: Expected VT, but got I
		//IL_14f5: Expected F8, but got I4
		//IL_14f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fd: Expected F8, but got Unknown
		//IL_150e: Expected VT, but got I4
		//IL_150f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1513: Unknown result type (might be due to invalid IL or missing references)
		//IL_1520: Expected Obj, but got I4
		//IL_1529: Expected Obj, but got I4
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_1101: Expected Obj, but got I4
		//IL_1111: Unknown result type (might be due to invalid IL or missing references)
		//IL_1119: Expected Obj, but got Unknown
		//IL_1119: Unknown result type (might be due to invalid IL or missing references)
		//IL_1121: Expected F4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v4+8]");
		bool flag2 = (nint)0 == 0;
		Enumerator<, > val = (Enumerator<, >)0;
		Enumerator<, > val2 = (Enumerator<, >)0;
		Enumerator<, > val3 = (Enumerator<, >)0;
		Enumerator<, > val4 = (Enumerator<, >)0;
		Enumerator<, > val5 = (Enumerator<, >)0;
		float num2 = default;
		float num = num2;
		float num4 = default;
		float num3 = num4;
		double num6 = default;
		double num5 = num6;
		Enumerator<, > val6 = default;
		double num7 = (double)val6;
		float num9 = default;
		float num8 = num9;
		UnityEngine.Object obj6 = default;
		UnityEngine.Object obj5 = obj6;
		Enumerator<, > val7 = (Enumerator<, >)0;
		float num10 = default;
		Enumerator<, > val8 = (Enumerator<, >)num10;
		UnityEngine.Object obj7 = (UnityEngine.Object)109895680;
		float num11 = num2;
		if (flag2)
		{
			goto IL_12ea;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C58]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v4+8]");
		Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
		val5 = (Enumerator<, >)0;
		num7 = (double)val6;
		num8 = num9;
		Enumerator<, > val9 = (Enumerator<, >)(ref val7);
		Enumerator<, > val10 = default;
		val8 = val10;
		bool flag15 = default;
		object obj25 = default;
		object obj27 = default;
		object obj29 = default;
		bool flag17 = default;
		bool flag19 = default;
		double num13 = default;
		object obj31 = default;
		IntPtr intPtr = default;
		object obj32;
		Enumerator<, > val12;
		Vector3 vector2;
		double num16;
		Vector3 vector;
		while (val7.MoveNext())
		{
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X0_v123+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = obj6 == null;
			bool flag5 = !flag4;
			object obj13 = !flag5;
			vector = (Vector3)0;
			if (obj13 != null)
			{
				continue;
			}
			UnityEngine.Object obj33;
			if ((object)obj6 != null)
			{
				object obj14 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ stack_-138 (UnityEngine.Object)+68]");
				UnityEngine.Object obj15 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ X0_v128+E4]");
				bool flag6 = (nint)0 == 0;
				object obj16 = !flag6;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag7 = obj15 == null;
				bool flag8 = !flag7;
				object obj17 = !flag8;
				vector = (Vector3)0;
				if (obj17 != null)
				{
					continue;
				}
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1276 @ X0_v132+E4]");
				bool flag9 = (nint)0 == 0;
				object obj19 = !flag9;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj20 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1568 @ X0_v136+E4]");
				bool flag10 = (nint)0 == 0;
				object obj21 = !flag10;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj20 = obj;
				}
				object obj22 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1568 @ X0_v136+A0]");
				val9 = (Enumerator<, >)0;
				obj15 = (UnityEngine.Object)val9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1570 @ X8_v90+E4]");
				bool flag11 = (nint)0 == 0;
				object obj23 = !flag11;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag12 = obj6 == obj15;
				bool flag13 = !flag12;
				bool flag14 = flag15;
				object obj24 = obj25;
				object obj26 = obj27;
				object obj28 = obj29;
				bool flag16 = flag17;
				bool flag18 = flag19;
				double num12 = num13;
				object obj30 = obj31;
				float num14 = num8;
				Enumerator<, > val11 = val8;
				if (!flag13)
				{
					GillaItem gillaItem = item;
					bool flag20 = (object)item == null;
					val = (Enumerator<, >)0;
					val2 = (Enumerator<, >)0;
					val3 = (Enumerator<, >)0;
					val4 = (Enumerator<, >)0;
					num = num2;
					num3 = num4;
					num5 = num6;
					vector = (Vector3)0;
					obj5 = null;
					obj32 = 0;
					val12 = (Enumerator<, >)(ref val7);
					obj33 = obj15;
					obj7 = obj6;
					num11 = num2;
					if (flag20)
					{
						goto IL_12c5;
					}
					int num15 = (int)(gillaItem.Hand__BackingField & 0x80000000L);
					bool flag21 = num15 == 0;
					vector = (Vector3)0;
					if (flag21)
					{
						continue;
					}
					float time = Time.time;
					num14 = letGoAt;
					val11 = (Enumerator<, >)(time - letGoAt);
					bool flag22 = (double)val11 < 0.5;
					obj30 = !flag22;
					num12 = (double)val11 - 0.5;
					flag18 = (double)val11 < 0.5;
					flag16 = num12 == 0.0;
					obj28 = val11 ^ 0.5;
					obj26 = val11 ^ num12;
					obj24 = obj28 & obj26;
					flag14 = (nint)obj24 < 0;
					flag15 = flag14;
					obj25 = obj24;
					obj27 = obj26;
					obj29 = obj28;
					flag17 = flag16;
					flag19 = flag18;
					num13 = num12;
					obj31 = obj30;
					num8 = letGoAt;
					vector = (Vector3)0;
					val8 = val11;
					if (flag18)
					{
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ stack_-138 (UnityEngine.Object)+68]");
				bool flag23 = (nint)0 == 0;
				val = (Enumerator<, >)0;
				val2 = (Enumerator<, >)0;
				val3 = (Enumerator<, >)0;
				val4 = (Enumerator<, >)0;
				num = num2;
				num3 = num4;
				num5 = num6;
				num8 = num14;
				vector = (Vector3)0;
				obj5 = null;
				obj32 = 0;
				val8 = val11;
				val12 = (Enumerator<, >)(ref val7);
				obj33 = obj15;
				obj7 = obj6;
				num11 = num2;
				if (!flag23)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ stack_-138 (UnityEngine.Object)+68]");
					Vector3 position = ((Transform)0).position;
					bool flag24 = Near((Vector3)(&val5), (Vector3)0, (Vector3)0, num10, num9, out *(Vector3*)intPtr);
					bool flag25 = !flag24;
					num7 = (double)val6;
					num16 = (double)val6;
					flag15 = flag14;
					obj25 = obj24;
					obj27 = obj26;
					obj29 = obj28;
					flag17 = flag16;
					flag19 = flag18;
					num13 = num12;
					obj31 = obj30;
					num8 = num9;
					vector = (Vector3)0;
					val8 = (Enumerator<, >)num10;
					if (flag25)
					{
						continue;
					}
					goto IL_0635;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
				val3 = (Enumerator<, >)0;
				val4 = (Enumerator<, >)0;
				num = num2;
				num3 = num4;
				num5 = num6;
				vector = (Vector3)0;
				obj5 = null;
				obj32 = 0;
				val12 = (Enumerator<, >)(ref val7);
				obj33 = null;
				NullReferenceException ex2 = new NullReferenceException();
				val = (Enumerator<, >)0;
				val2 = (Enumerator<, >)0;
				num11 = num2;
				NullReferenceException ex3 = new NullReferenceException();
			}
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_12c5;
			IL_12c5:
			NullReferenceException ex5 = new NullReferenceException();
			vector2 = (Vector3)obj33;
			NullReferenceException ex6 = new NullReferenceException();
			goto IL_12ea;
		}
		num = num2;
		num3 = num4;
		num5 = num6;
		object obj34 = 0;
		obj7 = (UnityEngine.Object)6;
		goto IL_184b;
		IL_184b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
		object obj35 = 0;
		vector2 = (Vector3)obj35;
		val7.Dispose();
		bool flag26 = obj34 == null;
		object obj36 = !flag26;
		val = (Enumerator<, >)0;
		val2 = (Enumerator<, >)0;
		val3 = (Enumerator<, >)0;
		val4 = (Enumerator<, >)0;
		obj5 = null;
		obj32 = 0;
		val7 = val10;
		val12 = (Enumerator<, >)(ref val7);
		num11 = num2;
		NullReferenceException ex7;
		if (obj36 == null)
		{
			val = (Enumerator<, >)0;
			val2 = (Enumerator<, >)0;
			val3 = (Enumerator<, >)0;
			val4 = (Enumerator<, >)0;
			obj5 = null;
			obj32 = 0;
			val7 = val10;
			val12 = (Enumerator<, >)(ref val7);
			ex7 = (NullReferenceException)(&val7);
			num11 = num2;
			goto IL_12f8;
		}
		goto IL_1307;
		IL_12f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_1307;
		IL_1307:
		num10 = (float)val8;
		throw new OutOfMemoryException();
		IL_0635:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ stack_-138 (UnityEngine.Object)+68]");
		bool flag27 = (nint)0 == 0;
		val = (Enumerator<, >)0;
		val2 = (Enumerator<, >)0;
		val3 = (Enumerator<, >)0;
		val4 = (Enumerator<, >)0;
		num = num2;
		num3 = num4;
		num5 = num6;
		double num17 = (double)val6;
		num16 = (double)val6;
		num8 = num9;
		vector = (Vector3)0;
		obj5 = null;
		obj32 = 0;
		val7 = val10;
		val12 = (Enumerator<, >)(ref val7);
		vector2 = (Vector3)0;
		obj7 = obj6;
		num11 = num2;
		if (!flag27)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ stack_-138 (UnityEngine.Object)+68]");
			Vector3 position2 = ((Transform)0).position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj37 = 0;
			object obj38 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1700 @ X0_v149+E4]");
			bool flag28 = (nint)0 == 0;
			object obj39 = !flag28;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num19 = default;
			float num18 = num19 - (float)val5;
			double num20 = 0.0 - (double)val6;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			double num21;
			if (num2 > 0f)
			{
				num5 = (double)val5 / (double)num2;
				num3 = num18 / num2;
				num21 = num20 / (double)num2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj40 = 0;
				object obj41 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1740 @ X8_v103+A0]");
				object obj42 = 0;
				num5 = (double)obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1741 @ X8_v104+4]");
				num3 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1741 @ X8_v104+8]");
				num21 = 0.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD6CC]");
			GillaDummy dummy = default;
			Break((Vector3)0, (Vector3)0, (int)(nint)intPtr, dummy);
			num = (float)num21;
			num7 = 0.0;
			num16 = (double)val5;
			num8 = num19;
			vector = (Vector3)0;
			val8 = val5;
			obj34 = 0;
			obj7 = (UnityEngine.Object)5;
			goto IL_184b;
		}
		double num22;
		Enumerator<, > val13;
		object obj44 = default;
		while (true)
		{
			NullReferenceException ex8 = new NullReferenceException();
			num22 = num;
			val13 = (Enumerator<, >)num11;
			NullReferenceException ex9 = new NullReferenceException();
			object obj43;
			if (vector2 == (Vector3)(object)2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj5 = (UnityEngine.Object)1;
				val8 = (Enumerator<, >)num10;
				obj43 = obj32;
			}
			else
			{
				if (vector2 != (Vector3)(object)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D7E4");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj43 = obj44;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj32 = obj44;
				val8 = (Enumerator<, >)num10;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C48]");
			object obj45 = 0;
			vector2 = (Vector3)obj45;
			((Enumerator<, >*)val12)->Dispose();
			bool flag29 = obj43 == null;
			object obj46 = !flag29;
			num = (float)num22;
			num7 = num17;
			num10 = (float)val8;
			num11 = (float)val13;
			if (obj46 != null)
			{
				OutOfMemoryException ex10 = new OutOfMemoryException();
				num17 = num7;
				continue;
			}
			break;
		}
		bool flag30 = (object)obj5 == null;
		object obj47 = !flag30;
		num = (float)num22;
		num7 = num17;
		ex7 = (NullReferenceException)val12;
		num11 = (float)val13;
		if (obj47 == null)
		{
			return;
		}
		goto IL_12f8;
		IL_12ea:
		ex7 = new NullReferenceException();
		goto IL_12f8;
	}

	private unsafe static bool Near(Vector3 a, Vector3 b, Vector3 top, float down, float round, out Vector3 at)
	{
		//IL_0052: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_028e: Invalid comparison between F8 and I4
		//IL_029d: Expected F8, but got I4
		//IL_025d: Invalid comparison between F8 and Obj
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected I4, but got Unknown
		//IL_02c1: Expected native int or pointer, but got VT
		//IL_02ce: Expected native int or pointer, but got VT
		//IL_02db: Expected native int or pointer, but got VT
		//IL_00ec: Expected Obj, but got I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0133: Expected native int or pointer, but got VT
		//IL_0140: Expected native int or pointer, but got VT
		//IL_014d: Expected native int or pointer, but got VT
		double num2 = default;
		double num = num2 - (double)down;
		double num4 = default;
		double num3 = num4 - (double)round;
		double num6 = default;
		object obj = default;
		double num5 = num6 - (double)obj;
		double num8 = default;
		object obj2 = default;
		double num7 = num8 - (double)obj2;
		object obj4 = default;
		object obj3 = obj4 * obj4;
		object obj5 = 1;
		object obj6 = 1;
		double num12;
		double num17;
		double num18;
		object obj7 = default;
		object obj8 = default;
		while (true)
		{
			double num9 = (double)obj5 / 3.0;
			bool flag = num9 < 0.0;
			double num10 = 0.0;
			if (!flag)
			{
				bool flag2 = !(num9 > 1.0);
				num10 = num9;
				if (!flag2)
				{
					num10 = 1.0;
				}
			}
			double num11 = num3 * num10;
			num12 = (double)round + num11;
			bool flag3 = num12 < num7;
			double num13 = num7;
			if (!flag3)
			{
				bool flag4 = !(num12 > num8);
				num13 = num12;
				if (!flag4)
				{
					num13 = num8;
				}
			}
			double num14 = num * num10;
			double num15 = num5 * num10;
			double num16 = num12 - num13;
			num17 = (double)down + num14;
			num18 = (double)obj + num15;
			double num19 = num16 * num16;
			double num20 = num17 - (double)obj7;
			double num21 = num18 - (double)obj8;
			double num22 = num20 * num20;
			double num23 = num22 + num19;
			double num24 = num21 * num21;
			double num25 = num24 + num23;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num25) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				break;
			}
			bool flag5 = (nint)obj5 < 3;
			object obj9 = !flag5;
			obj5++;
			object obj10 = ~obj9;
			bool flag6 = (nint)obj5 != 4;
			obj6 = obj10;
			if (!flag6)
			{
				((Vector3*)(nint)a)->x = (float)num17;
				((Vector3*)(nint)a)->y = (float)num12;
				((Vector3*)(nint)a)->z = (float)num18;
				obj6 = obj10;
				break;
			}
		}
		bool result = (byte)(obj6 & 1) != 0;
		((Vector3*)(nint)a)->x = (float)num17;
		((Vector3*)(nint)a)->y = (float)num12;
		((Vector3*)(nint)a)->z = (float)num18;
		return result;
	}

	private unsafe void Break(Vector3 at, Vector3 normal, int player, GillaDummy dummy)
	{
		//IL_01f3: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got VT
		//IL_00a9: Expected VT, but got I4
		//IL_021b: Expected VT, but got I
		//IL_021b: Expected VT, but got Obj
		//IL_00e1: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I
		//IL_012c: Expected VT, but got I4
		//IL_014a: Expected Obj, but got I
		//IL_0260: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I
		//IL_01d7: Expected VT, but got Obj
		//IL_016e: Expected Obj, but got I8
		//IL_01ba: Expected VT, but got I4
		bool flag = (byte)(~(broke ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		if (Live)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = (UnityEngine.Object)normal != null;
			bool flag4 = !flag3;
			Vector3 normal2 = (Vector3)0;
			if (!flag4)
			{
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v14+E4]");
				bool flag5 = (nint)0 == 0;
				object obj6 = !flag5;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [normal @ X2 (UnityEngine.Vector3)+40]");
				bool flag6 = (UnityEngine.Object)0 != null;
				bool flag7 = !flag6;
				normal2 = (Vector3)0;
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [normal @ X2 (UnityEngine.Vector3)+40]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X21_v7+20]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X21_v7+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X22_v12+4]");
						object obj9 = 0 & -9223372036854775808L;
						if (obj9 != null)
						{
							System.ThrowHelper.ThrowArgumentOutOfRangeException();
						}
					}
					Span<int> span = default;
					if (span.IsEmpty)
					{
						normal2 = (Vector3)0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X21_v7+20]");
						object obj10 = 0;
						normal2 = (Vector3)obj10;
					}
				}
			}
			object obj11 = default;
			IntPtr intPtr = default;
			RPC_Broke(at, normal2, (int)(&obj11), (NetworkId)dummy, (RpcInfo)(nint)intPtr);
		}
		else
		{
			Broke(at, normal, player, dummy);
		}
	}

	public unsafe void RPC_Broke(Vector3 at, Vector3 normal, int player, NetworkId dummy, RpcInfo info = default(RpcInfo))
	{
		//IL_1509: Expected VT, but got I4
		//IL_1511: Expected Obj, but got VT
		//IL_030d: Expected Obj, but got I
		//IL_0357: Expected I4, but got Obj
		//IL_0379: Expected Obj, but got I4
		//IL_03c9: Expected VT, but got I4
		//IL_03d1: Expected Obj, but got VT
		//IL_0410: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I4
		//IL_0438: Expected Obj, but got I4
		//IL_0445: Expected I4, but got Obj
		//IL_0462: Expected I4, but got I8
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected VT, but got Unknown
		//IL_00ce: Invalid comparison between VT and I4
		//IL_0494: Expected Obj, but got VT
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		//IL_04bc: Expected Obj, but got I4
		//IL_09b7: Expected VT, but got I4
		//IL_05b5: Expected Obj, but got I4
		//IL_1580: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I4
		//IL_05eb: Expected Obj, but got I
		//IL_05fd: Expected VT, but got I8
		//IL_0618: Expected VT, but got I4
		//IL_171b: Expected VT, but got I
		//IL_0176: Expected VT, but got I4
		//IL_0184: Expected VT, but got I4
		//IL_063b: Expected Obj, but got VT
		//IL_0655: Expected Obj, but got I4
		//IL_066e: Expected VT, but got I4
		//IL_0676: Expected I4, but got VT
		//IL_13dc: Expected F8, but got I4
		//IL_0756: Expected F8, but got I4
		//IL_075f: Expected Obj, but got I4
		//IL_0767: Expected VT, but got Ref
		//IL_076f: Expected I4, but got VT
		//IL_0777: Expected Obj, but got VT
		//IL_0787: Expected VT, but got I4
		//IL_079c: Expected Obj, but got Ref
		//IL_07c5: Expected Obj, but got VT
		//IL_050b: Expected VT, but got I4
		//IL_0510: Expected VT, but got Obj
		//IL_0521: Expected VT, but got I4
		//IL_1444: Expected Ref, but got VT
		//IL_01ac: Expected VT, but got I4
		//IL_01ba: Expected VT, but got I4
		//IL_174c: Invalid comparison between F8 and I4
		//IL_0694: Expected Obj, but got I
		//IL_06a6: Expected I4, but got Obj
		//IL_06a6: Expected VT, but got I4
		//IL_06b8: Expected I4, but got Obj
		//IL_06b8: Expected VT, but got I4
		//IL_0a00: Expected VT, but got I
		//IL_06d0: Expected I4, but got VT
		//IL_06e0: Expected Obj, but got I
		//IL_06e8: Expected VT, but got Obj
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected VT, but got Unknown
		//IL_0538: Invalid comparison between VT and I4
		//IL_1489: Expected Obj, but got VT
		//IL_0212: Expected Obj, but got I4
		//IL_0a31: Expected VT, but got I
		//IL_0a60: Expected Obj, but got I4
		//IL_0255: Expected VT, but got I4
		//IL_0262: Expected VT, but got Obj
		//IL_026b: Expected VT, but got I4
		//IL_081f: Expected Obj, but got I
		//IL_0849: Expected Obj, but got I4
		//IL_0555: Invalid comparison between VT and I4
		//IL_0567: Expected VT, but got I4
		//IL_056c: Expected VT, but got Obj
		//IL_057d: Expected VT, but got I4
		//IL_0a87: Expected VT, but got I4
		//IL_159e: Expected Obj, but got I
		//IL_0801: Expected Obj, but got I4
		//IL_0291: Expected VT, but got I4
		//IL_029e: Expected VT, but got Obj
		//IL_02a7: Expected VT, but got I4
		//IL_17b5: Expected Obj, but got I4
		//IL_0ae7: Expected Obj, but got I4
		//IL_087e: Expected Obj, but got I
		//IL_0887: Expected VT, but got Obj
		//IL_08a0: Expected VT, but got Obj
		//IL_08c2: Expected Obj, but got I4
		//IL_0b0e: Expected VT, but got I4
		//IL_02cd: Expected Obj, but got I
		//IL_02e8: Expected VT, but got I4
		//IL_02f0: Expected VT, but got Obj
		//IL_0974: Expected I4, but got VT
		//IL_099b: Expected VT, but got I4
		//IL_08fa: Expected I4, but got I8
		//IL_0911: Expected VT, but got I4
		//IL_0b79: Expected VT, but got I
		//IL_0ba9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bae: Expected Obj, but got Unknown
		//IL_0c1d: Invalid comparison between F8 and I4
		//IL_0c41: Expected Obj, but got I
		//IL_0c6b: Expected Obj, but got I4
		//IL_0cb0: Expected VT, but got I
		//IL_0ceb: Expected Obj, but got I8
		//IL_0d05: Expected Obj, but got I4
		//IL_0d1f: Expected VT, but got F8
		//IL_0d31: Expected VT, but got I4
		//IL_1622: Expected Obj, but got I4
		//IL_11ab: Expected Obj, but got VT
		//IL_0d77: Expected Obj, but got I4
		//IL_1640: Expected Obj, but got I
		//IL_1650: Expected Obj, but got I
		//IL_16c1: Expected VT, but got F8
		//IL_16d7: Expected VT, but got I4
		//IL_16e7: Expected VT, but got Obj
		//IL_11d5: Invalid comparison between VT and I4
		//IL_11e4: Expected VT, but got I4
		//IL_0db1: Expected Obj, but got I
		//IL_0dc6: Expected Obj, but got I
		//IL_0dda: Expected VT, but got I
		//IL_0e09: Expected Obj, but got I4
		//IL_124e: Expected Obj, but got I4
		//IL_0e4e: Expected Obj, but got I4
		//IL_0e70: Expected VT, but got F8
		//IL_0e79: Expected VT, but got I4
		//IL_1275: Expected Obj, but got I4
		//IL_1293: Expected Obj, but got I4
		//IL_138a: Expected VT, but got I4
		//IL_0eb9: Expected VT, but got F8
		//IL_0ecb: Expected VT, but got I4
		//IL_0ee0: Expected I4, but got Obj
		//IL_0ee8: Expected I4, but got F4
		//IL_12c1: Expected VT, but got I4
		//IL_0f1b: Expected VT, but got I
		//IL_0f4d: Expected Obj, but got I4
		//IL_12ed: Expected Obj, but got I
		//IL_12f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fe: Expected Obj, but got Unknown
		//IL_136a: Invalid comparison between F8 and I4
		//IL_0f74: Expected Obj, but got VT
		//IL_0f92: Expected Obj, but got I4
		//IL_0fb4: Expected VT, but got F8
		//IL_0fbd: Expected VT, but got I4
		//IL_1005: Expected VT, but got F8
		//IL_1017: Expected VT, but got I4
		//IL_102c: Expected I4, but got Obj
		//IL_1053: Expected Obj, but got I
		//IL_10ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d3: Expected VT, but got Unknown
		//IL_10dc: Invalid comparison between VT and I4
		//IL_10ee: Expected F8, but got I4
		//IL_10f7: Expected VT, but got I4
		//IL_1111: Expected F8, but got I4
		//IL_112b: Expected VT, but got I4
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		object obj2 = default;
		object obj = obj2;
		double num2 = default;
		double num = num2;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		GillaDummy dummy2 = (GillaDummy)dummy;
		RpcChannel rpcChannel = (RpcChannel)0;
		Vector3 vector = at;
		Vector3 vector3 = default;
		Vector3 vector2 = vector3;
		int num4 = default;
		int num3 = num4;
		object obj3 = default;
		int bytePayloadSize4;
		MethodBase methodBase = default;
		int num7 = default;
		UnityEngine.Object obj5;
		object obj6;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		PlayerRef playerRef;
		PlayerRef playerRef2;
		RpcInvokeInfo rpcInvokeInfo2;
		int num6;
		int num5;
		bool flag4;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj3 = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			int bytePayloadSize3 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			bytePayloadSize4 = Fusion.RpcDataWriter.GetBytePayloadSize(4);
			num5 = (int)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X8_v16 (System.Int32)+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			flag4 = (object)((SimulationBehaviour)this)._runner == null;
			obj = obj2;
			num = num2;
			rpcBuilder = (Fusion.RpcBuilder)0;
			dummy2 = (GillaDummy)dummy;
			num6 = bytePayloadSize4;
			methodBase = (MethodBase)(object)((SimulationBehaviour)this)._runner;
			num7 = bytePayloadSize2;
			obj5 = null;
			vector = at;
			vector2 = vector3;
			num3 = num4;
			obj6 = bytePayloadSize;
			if (!flag4)
			{
				object obj7 = bytePayloadSize2 + bytePayloadSize;
				object obj8 = bytePayloadSize3 + bytePayloadSize4;
				int payloadByteCount = (int)(obj7 + obj8);
				Fusion.RpcBuilder rpcBuilder2 = ((SimulationBehaviour)this)._runner.CreateRpcBuilder(4118133620u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				methodBase = (MethodBase)(rpcInvokeInfo >> 32);
				object obj9 = methodBase - 522;
				bool flag5 = (nint)obj9 < 2;
				object obj10 = !flag5;
				object obj11 = ~obj10;
				RpcInfo rpcInfo;
				if (obj11 == null && (nint)methodBase != 518)
				{
					bool flag6 = (nint)methodBase != 524;
					rpcInfo = (RpcInfo)0;
					playerRef = (PlayerRef)this;
					playerRef2 = invalid;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag6)
					{
						goto IL_062d;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag7 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						rpcInfo = (RpcInfo)0;
						playerRef = (PlayerRef)this;
						playerRef2 = invalid;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag7)
						{
							goto IL_062d;
						}
					}
				}
				object obj12 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X0_v71+E4]");
				bool flag8 = (nint)0 == 0;
				object obj13 = !flag8;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0800]");
				object rpc = 0;
				playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
				rpcInfo = (RpcInfo)0;
				playerRef2 = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_062d;
			}
			goto IL_1390;
		}
		goto IL_0005;
		IL_139e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		OutOfMemoryException ex2 = default;
		OutOfMemoryException ex = ex2;
		double num8 = default;
		object obj15 = default;
		object obj16 = default;
		Fusion.RpcBuilder rpcBuilder4 = default;
		OutOfMemoryException ex4 = default;
		while (true)
		{
			object obj14;
			if ((nint)obj5 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				num8 = 1.0;
				obj14 = obj15;
				num5 = 1;
			}
			else
			{
				if ((nint)obj5 != 1)
				{
					goto IL_1720;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj14 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj15 = obj16;
			}
			((Fusion.RpcBuilder*)rpcBuilder4)->Dispose();
			if (obj14 == null)
			{
				break;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			ex = ex3;
			obj5 = null;
			goto IL_1720;
			IL_1720:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			methodBase = null;
			ex = ex4;
			num7 = 0;
			obj6 = null;
		}
		int num9 = num4;
		Vector3 vector4 = vector3;
		obj5 = null;
		NullReferenceException ex5 = (NullReferenceException)rpcBuilder4;
		num5 = 0;
		goto IL_1743;
		IL_15d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		num3 = 0;
		int value = ((int*)num3)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1084 @ X0_v105 (System.Int32)+E4]");
		num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1084 @ X0_v105 (System.Int32)+E4]");
		bool flag9 = (nint)0 == 0;
		object obj17 = !flag9;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj18 = default;
		object obj22 = default;
		if ((UnityEngine.Object)vector2 != null)
		{
			flag4 = vector2 == (Vector3)(object)0;
			vector3 = (Vector3)0;
			obj5 = null;
			obj6 = obj18;
			if (flag4)
			{
				goto IL_1390;
			}
			int value2 = ((int*)num3)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X21_v2 (UnityEngine.Vector3)+68]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ X0_v109 (System.Int32)+E4]");
			num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ X0_v109 (System.Int32)+E4]");
			bool flag10 = (nint)0 == 0;
			object obj19 = !flag10;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag11 = (UnityEngine.Object)num3 == null;
			bool flag12 = !flag11;
			object obj20 = !flag12;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X21_v2 (UnityEngine.Vector3)+68]");
				flag4 = (nint)0 == 0;
				vector3 = (Vector3)0;
				obj5 = null;
				obj6 = obj18;
				if (flag4)
				{
					goto IL_1390;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X21_v2 (UnityEngine.Vector3)+68]");
				Vector3 position = ((Transform)0).position;
				object obj21 = rpcBuilder - obj22;
				double num10 = num - num2;
				object obj23 = obj - obj2;
				object obj24 = obj21 * obj21;
				double num11 = num10 * num10;
				double num12 = (double)obj24 + num11;
				object obj25 = obj23 * obj23;
				double num13 = (double)obj25 + num12;
				if (!(num13 > 1108344832.0))
				{
					goto IL_16fd;
				}
			}
			vector2 = (Vector3)0;
		}
		goto IL_16fd;
		IL_062d:
		object obj26 = rpcInvokeInfo >> 32;
		bool flag13 = obj26 == null;
		object obj27 = !flag13;
		obj = obj2;
		num = num2;
		rpcBuilder = (Fusion.RpcBuilder)0;
		int num14 = (int)rpcInvokeInfo2;
		object obj30 = default;
		double num16 = default;
		Fusion.RpcBuilder rpcBuilder5 = default;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj28 = 0;
			writer.Write((Vector3)12, (int)obj28);
			writer.Write((Vector3)12, (int)obj28);
			writer.Write((int)at, 4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D58]");
			object obj29 = 0;
			playerRef = (PlayerRef)obj29;
			NetworkId value3 = (NetworkId)(vector3 & 0xFFFFFFFFL);
			writer.Write(value3, 4);
			int num15 = rpcBuilder3.Send();
			obj = obj30;
			num = num16;
			rpcBuilder = rpcBuilder5;
			num14 = 4;
		}
		rpcBuilder3.Dispose();
		num8 = 0.0;
		obj15 = 0;
		rpcBuilder4 = (Fusion.RpcBuilder)(&rpcBuilder3);
		num9 = (int)playerRef;
		dummy2 = (GillaDummy)playerRef2;
		num6 = bytePayloadSize4;
		vector4 = (Vector3)num14;
		num7 = (int)(&writer);
		obj5 = null;
		ex5 = (NullReferenceException)(&rpcBuilder3);
		vector = at;
		vector2 = vector3;
		num3 = num4;
		num5 = 13;
		obj6 = rpcInvokeInfo;
		goto IL_1743;
		IL_1390:
		ex5 = new NullReferenceException();
		goto IL_139e;
		IL_16fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v81 (System.Object)+10]");
		Broke((Vector3)0, vector2, num4, dummy2);
		return;
		IL_1743:
		bool flag14 = num8 == 0.0;
		flag4 = !flag14;
		num4 = num9;
		vector3 = vector4;
		if (!flag4)
		{
			if (num5 != 13)
			{
				bool flag15 = num5 == 0;
				object obj31 = !flag15;
				if (obj31 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj32 = 0;
			object obj33 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X0_v6+E4]");
			bool flag16 = (nint)0 == 0;
			object obj34 = !flag16;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj33 = obj32;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X0_v6+A0]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X8_v5+18]");
			num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X8_v5+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D07E8]");
				object obj36 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj36);
				object obj37 = obj3;
				RpcInvokeInfo invokeInfo = (RpcInvokeInfo)(obj6 | (object)methodBase);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1009 @ X8_v10+E4]");
				bool flag17 = (nint)0 == 0;
				object obj38 = !flag17;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(num7 & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, invokeInfo, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v423 @ X27_v1 (System.Int32)+18] (should have been resolved before IL gen)");
				object obj39 = default;
				obj = obj39;
				double num17 = default;
				num8 = num17;
				RpcInfo rpcInfo = (RpcInfo)invalid2;
				dummy2 = null;
				methodBase = methodFromHandle;
			}
			bool flag18 = obj6 == null;
			object obj40 = !flag18;
			if (obj40 == null)
			{
				RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
				((int*)num3)->m_value = (int)rpcBuilder4;
				num = num8;
				rpcBuilder = rpcBuilder4;
				num4 = 0;
				vector3 = (Vector3)0;
				rpcChannel = (RpcChannel)0;
				goto IL_0005;
			}
			return;
		}
		goto IL_139e;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D07F8]");
		num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		obj18._002Ector();
		flag4 = obj18 == null;
		obj5 = null;
		obj6 = obj18;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
			object obj41 = 0;
			object obj42 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v82+E4]");
			bool flag19 = (nint)0 == 0;
			object obj43 = !flag19;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			vector = (Vector3)(vector2 & 0xFFFFFFFFL);
			if (vector != (Vector3)(object)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				num7 = 0;
				int value4 = ((int*)num7)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v142 (System.Int32)+E4]");
				num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v142 (System.Int32)+E4]");
				bool flag20 = (nint)0 == 0;
				object obj44 = !flag20;
				if (obj44 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag21 = (UnityEngine.Object)((SimulationBehaviour)this)._runner != (UnityEngine.Object)null;
				bool flag22 = !flag21;
				vector3 = (Vector3)0;
				obj5 = null;
				vector2 = (Vector3)0;
				if (!flag22)
				{
					flag4 = (object)((SimulationBehaviour)this)._runner == null;
					vector3 = (Vector3)0;
					obj5 = null;
					vector2 = (Vector3)0;
					obj6 = obj18;
					if (flag4)
					{
						goto IL_1390;
					}
					NetworkObject networkObject = ((SimulationBehaviour)this)._runner.FindObject((NetworkId)vector);
					num5 = ((int*)num7)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X8_v16 (System.Int32)+E4]");
					bool flag23 = (nint)0 == 0;
					object obj45 = !flag23;
					if (obj45 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag24 = (UnityEngine.Object)networkObject != (UnityEngine.Object)null;
					bool flag25 = !flag24;
					vector3 = (Vector3)0;
					obj5 = null;
					vector = (Vector3)networkObject;
					vector2 = (Vector3)0;
					if (!flag25)
					{
						flag4 = (object)networkObject == null;
						vector3 = (Vector3)0;
						obj5 = null;
						vector = (Vector3)networkObject;
						vector2 = (Vector3)0;
						obj6 = obj18;
						if (flag4)
						{
							goto IL_1390;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BE8]");
						object obj46 = 0;
						obj5 = (UnityEngine.Object)obj46;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
						vector3 = (Vector3)0;
						vector = (Vector3)networkObject;
						Vector3 vector5 = default;
						vector2 = vector5;
					}
				}
			}
			else
			{
				obj5 = null;
				vector2 = (Vector3)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X20_v2 (System.Int32)+18]");
			num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X20_v2 (System.Int32)+18]");
			int num18 = (int)((nint)0 & (nint)1);
			bool flag26 = num18 == 0;
			object obj47 = !flag26;
			if (obj47 != null)
			{
				goto IL_16fd;
			}
			flag4 = this.holder == null;
			obj6 = obj18;
			if (!flag4)
			{
				GillaNetGuard.Holder holder = this.holder;
				NetworkObject o = ((SimulationBehaviour)this)._object;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X20_v2 (System.Int32)+4]");
				if (!holder.Is(o, (PlayerRef)0))
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
				vector = (Vector3)0;
				float x = vector.x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X0_v89 (System.Single)+E4]");
				bool flag27 = (nint)0 == 0;
				object obj48 = !flag27;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!NetworkApe.Sane((Vector3)0))
				{
					return;
				}
				float x2 = vector.x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X0_v93 (System.Single)+E4]");
				num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X0_v93 (System.Single)+E4]");
				bool flag28 = (nint)0 == 0;
				object obj49 = !flag28;
				if (obj49 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!NetworkApe.Sane((Vector3)0))
				{
					return;
				}
				Transform transform = base.transform;
				flag4 = (object)transform == null;
				obj = obj30;
				num = num16;
				rpcBuilder = rpcBuilder5;
				num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X20_v2 (System.Int32)+4]");
				vector3 = (Vector3)0;
				obj5 = null;
				obj6 = obj18;
				if (!flag4)
				{
					Vector3 position2 = transform.position;
					object obj50 = obj22 - rpcBuilder5;
					double num19 = num2 - num16;
					obj = obj2 - obj30;
					object obj51 = obj50 * obj50;
					double num20 = num19 * num19;
					double num21 = (double)obj51 + num20;
					object obj52 = obj * obj;
					double num22 = (double)obj52 + num21;
					if (num22 > 1108344832.0)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
					object obj53 = 0;
					object obj54 = obj53;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ X0_v100+E4]");
					bool flag29 = (nint)0 == 0;
					object obj55 = !flag29;
					if (obj55 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X20_v2 (System.Int32)+4]");
					if (!GillaNetGuard.Spend((PlayerRef)0, (GillaNetGuard.Kind)4, 4f, 8f))
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v81 (System.Object)+10]");
					object obj56 = 0 & 0x80000000L;
					bool flag30 = obj56 == null;
					object obj57 = !flag30;
					num = 8.0;
					rpcBuilder = (Fusion.RpcBuilder)4.0;
					num4 = 0;
					Vector3 vector6 = (Vector3)0;
					GillaNetGuard.Kind kind = (GillaNetGuard.Kind)4;
					if (obj57 == null)
					{
						float x3 = vector.x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ X0_v119 (System.Single)+E4]");
						bool flag31 = (nint)0 == 0;
						object obj58 = !flag31;
						if (obj58 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							x3 = vector.x;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ X0_v119 (System.Single)+A0]");
						object obj59 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C10]");
						object obj60 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1091 @ X8_v57+8]");
						num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D07F0]");
						num5 = 0;
						Predicate<System.__Canon> predicate = default;
						predicate._002Ector(obj18, (IntPtr)((int*)num5)->m_value);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1091 @ X8_v57+8]");
						flag4 = (nint)0 == 0;
						num = 8.0;
						rpcBuilder = (Fusion.RpcBuilder)4.0;
						num4 = 0;
						vector3 = (Vector3)((int*)num5)->m_value;
						obj5 = (UnityEngine.Object)obj18;
						vector = (Vector3)predicate;
						obj6 = obj18;
						if (flag4)
						{
							goto IL_1390;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C00]");
						object obj61 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1091 @ X8_v57+8]");
						System.__Canon _Canon = ((List<System.__Canon>)0).Find(predicate);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						Vector3 vector7 = (Vector3)0;
						float x4 = vector7.x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v62 (System.Single)+E4]");
						bool flag32 = (nint)0 == 0;
						object obj62 = !flag32;
						if (obj62 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag33 = (UnityEngine.Object)(object)_Canon == null;
						bool flag34 = !flag33;
						object obj63 = !flag34;
						object obj64 = obj;
						double num23 = 8.0;
						Fusion.RpcBuilder rpcBuilder6 = (Fusion.RpcBuilder)4.0;
						Vector3 vector8 = (Vector3)0;
						GillaNetGuard.Kind kind2 = (GillaNetGuard.Kind)0;
						if (obj63 == null)
						{
							flag4 = _Canon == null;
							num = 8.0;
							rpcBuilder = (Fusion.RpcBuilder)4.0;
							num4 = 0;
							vector3 = (Vector3)0;
							obj5 = null;
							vector = vector7;
							num3 = (int)_Canon;
							num5 = (int)x4;
							obj6 = obj18;
							if (flag4)
							{
								goto IL_1390;
							}
							float x5 = vector7.x;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X0_v123 (System.__Canon)+68]");
							vector7 = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ X0_v128 (System.Single)+E4]");
							num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ X0_v128 (System.Single)+E4]");
							bool flag35 = (nint)0 == 0;
							object obj65 = !flag35;
							if (obj65 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag36 = (UnityEngine.Object)vector7 == null;
							bool flag37 = !flag36;
							object obj66 = !flag37;
							obj64 = obj;
							num23 = 8.0;
							rpcBuilder6 = (Fusion.RpcBuilder)4.0;
							vector8 = (Vector3)0;
							kind2 = (GillaNetGuard.Kind)0;
							if (obj66 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X0_v123 (System.__Canon)+68]");
								flag4 = (nint)0 == 0;
								num = 8.0;
								rpcBuilder = (Fusion.RpcBuilder)4.0;
								num4 = 0;
								vector3 = (Vector3)0;
								obj5 = null;
								vector = vector7;
								num3 = (int)_Canon;
								obj6 = obj18;
								if (flag4)
								{
									goto IL_1390;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X0_v123 (System.__Canon)+68]");
								Vector3 position3 = ((Transform)0).position;
								double num24 = 4.0 - (double)obj22;
								double num25 = 8.0 - num2;
								obj64 = obj - obj2;
								double num26 = num24 * num24;
								double num27 = num25 * num25;
								double num28 = num26 + num27;
								object obj67 = obj64 * obj64;
								rpcBuilder6 = (Fusion.RpcBuilder)(obj67 + num28);
								bool flag38 = rpcBuilder6 <= (object)1108344832;
								num23 = 1108344832.0;
								vector8 = (Vector3)0;
								kind2 = (GillaNetGuard.Kind)0;
								obj = obj64;
								num = 1108344832.0;
								rpcBuilder = rpcBuilder6;
								num4 = 0;
								vector6 = (Vector3)0;
								kind = (GillaNetGuard.Kind)0;
								vector = vector7;
								if (flag38)
								{
									goto IL_15d3;
								}
							}
						}
						_ = 4294967295L;
						obj = obj64;
						num = num23;
						rpcBuilder = rpcBuilder6;
						num4 = 0;
						vector6 = vector8;
						kind = kind2;
						vector = vector7;
					}
					goto IL_15d3;
				}
			}
		}
		goto IL_1390;
	}

	private void Broke(Vector3 at, Vector3 normal, int player, GillaDummy dummy)
	{
		//IL_0a50: Expected Obj, but got I4
		//IL_0bb1: Expected Obj, but got I
		//IL_0bdb: Expected Obj, but got I4
		//IL_0101: Invalid comparison between F4 and I
		//IL_0113: Expected F4, but got I4
		//IL_011c: Expected F4, but got I4
		//IL_0125: Expected F4, but got I4
		//IL_012e: Expected F4, but got I4
		//IL_0a73: Expected Obj, but got I
		//IL_0a8b: Expected Obj, but got I
		//IL_0a9b: Expected Obj, but got I
		//IL_0aab: Expected Obj, but got I
		//IL_0abb: Expected Obj, but got I
		//IL_0ad0: Expected Obj, but got I
		//IL_0afa: Expected Obj, but got I4
		//IL_01a9: Expected VT, but got I4
		//IL_01c5: Expected VT, but got I4
		//IL_01da: Expected Obj, but got I
		//IL_0204: Expected Obj, but got I4
		//IL_0230: Expected VT, but got I4
		//IL_0230: Expected VT, but got I4
		//IL_0240: Expected Obj, but got I
		//IL_026a: Expected Obj, but got I4
		//IL_02af: Expected VT, but got I4
		//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1a: Expected Obj, but got Unknown
		//IL_0b34: Expected Obj, but got I4
		//IL_0511: Expected Obj, but got I4
		//IL_0385: Expected Obj, but got I4
		//IL_0538: Expected Obj, but got VT
		//IL_0447: Expected Obj, but got I
		//IL_0471: Expected Obj, but got I4
		//IL_03b2: Expected Obj, but got I
		//IL_03ba: Expected VT, but got Obj
		//IL_0b6c: Expected Obj, but got I4
		//IL_04a5: Expected VT, but got I4
		//IL_04a5: Expected I4, but got VT
		//IL_04b7: Expected Obj, but got I4
		//IL_03d9: Expected F4, but got I
		//IL_03ea: Expected VT, but got Obj
		//IL_0570: Expected Obj, but got VT
		//IL_058c: Expected VT, but got I4
		//IL_06b3: Expected VT, but got I4
		//IL_06e8: Expected Obj, but got I4
		//IL_05c4: Expected Obj, but got I4
		//IL_05f3: Expected Obj, but got I
		//IL_060f: Expected VT, but got I4
		//IL_081e: Expected VT, but got Obj
		//IL_062d: Expected Obj, but got I
		//IL_0657: Expected Obj, but got I4
		//IL_0693: Expected VT, but got I4
		//IL_0693: Expected Obj, but got I
		//IL_069c: Expected VT, but got I4
		//IL_0877: Expected I4, but got I8
		//IL_0891: Expected Obj, but got I4
		//IL_079b: Expected Obj, but got I4
		//IL_07b5: Expected Obj, but got I4
		//IL_08bb: Expected VT, but got I4
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected Obj, but got Unknown
		//IL_0905: Expected Obj, but got I8
		//IL_090e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Expected Obj, but got Unknown
		//IL_091c: Expected Obj, but got I4
		//IL_0925: Expected Obj, but got I4
		//IL_0b93: Expected Obj, but got I4
		//IL_0954: Expected Obj, but got I4
		//IL_0983: Expected Obj, but got I
		//IL_099f: Expected Obj, but got I4
		//IL_09a8: Expected VT, but got I4
		//IL_09ed: Expected Obj, but got I4
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fb: Expected Obj, but got Unknown
		//IL_09cc: Expected Obj, but got I
		//IL_09d5: Expected Obj, but got I4
		//IL_09de: Expected VT, but got I4
		bool flag = (byte)(~(broke ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		object obj3 = default;
		object obj2 = obj3 * obj3;
		object obj5 = default;
		object obj4 = obj5 * obj5;
		object obj6 = obj2 + obj4;
		object obj8 = default;
		object obj7 = obj8 * obj8;
		object obj9 = obj7 + obj6;
		broke = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		bool flag2 = (nint)obj9 >= 0;
		object obj10 = obj3;
		object obj11 = obj5;
		object obj12 = obj8;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj13 = 0;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v56+A0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v57+18]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v57+1C]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v57+20]");
			obj12 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj16 = 0;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj18 = !flag3;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj19 = obj10 * obj10;
		object obj20 = obj11 * obj11;
		object obj21 = obj20 + obj19;
		object obj22 = obj12 * obj12;
		float num = (float)obj22 + (float)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		bool flag4 = !(num2 > 0f);
		float num3 = 0f;
		float num4 = 0f;
		float num5 = 0f;
		float num6 = 0f;
		if (!flag4)
		{
			num5 = (float)obj10 / num;
			num6 = (float)obj11 / num;
			num = (float)obj12 / num;
			num3 = num6;
			num4 = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
		object obj23 = 0;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj25 = !flag5;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num7 = default;
		float num8 = default;
		float num9 = default;
		Sfx.Play(crackSounds, (Vector3)0, num7, num8, num9);
		Sfx.Play(splatSounds, (Vector3)0, num7, num8, num9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
		object obj26 = 0;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj28 = !flag6;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Blood.Yolk((Vector3)0, (Vector3)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj29 = 0;
		object obj30 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v14+E4]");
		bool flag7 = (nint)0 == 0;
		object obj31 = !flag7;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = shards != null;
		bool flag9 = !flag8;
		Vector3 vector = (Vector3)0;
		float num10 = num4;
		float num11 = num5;
		float num12 = num3;
		float num13 = num9;
		float num14 = num8;
		float num15 = num7;
		float num16 = num8;
		float num17 = num9;
		float num18 = num3;
		float num19 = num4;
		if (!flag9)
		{
			float num20 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
			float num21 = num20 * 0f;
			float num22 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
			float num23 = num22 * 0f;
			float num24 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
			float num25 = num24 * 0f;
			Quaternion rotation = UnityEngine.Random.rotation;
			object obj32 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X0_v80+E4]");
			bool flag10 = (nint)0 == 0;
			object obj33 = !flag10;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0808]");
			object obj34 = 0;
			vector = (Vector3)obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDC9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA50]");
			num11 = 0f;
			GillaEggMess gillaEggMess = default;
			gillaEggMess.Fling((Vector3)obj34, num5);
			num10 = num23;
			num12 = num21;
			num13 = num4;
			num14 = num3;
			num15 = num5;
			num16 = num8;
			num17 = num9;
			num18 = num3;
			num19 = num4;
		}
		object obj35 = at & 0x80000000L;
		bool flag11 = obj35 == null;
		object obj36 = !flag11;
		bool flag13;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
			object obj37 = 0;
			object obj38 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v72+E4]");
			bool flag12 = (nint)0 == 0;
			object obj39 = !flag12;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaSplatter.Stain((int)at, (Vector3)1, num7, (GillaStains.Stuff)0);
			GillaStains.Stuff stuff = (GillaStains.Stuff)0;
			UnityEngine.Object obj40 = (UnityEngine.Object)1;
			num11 = stain;
			num13 = num17;
			num14 = num16;
			num15 = num7;
			flag13 = true;
		}
		else
		{
			object obj41 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X0_v67+E4]");
			bool flag14 = (nint)0 == 0;
			object obj42 = !flag14;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag15 = (UnityEngine.Object)normal != null;
			GillaStains.Stuff stuff = (GillaStains.Stuff)0;
			UnityEngine.Object obj40 = null;
			flag13 = flag15;
		}
		object obj43 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X0_v20+E4]");
		bool flag16 = (nint)0 == 0;
		object obj44 = !flag16;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17 = (UnityEngine.Object)normal != null;
		bool flag18 = !flag17;
		Vector3 normal2 = (Vector3)0;
		if (!flag18)
		{
			object obj45 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X0_v57+E4]");
			bool flag19 = (nint)0 == 0;
			object obj46 = !flag19;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [normal @ X2 (UnityEngine.Vector3)+80]");
			bool flag20 = (UnityEngine.Object)0 != null;
			bool flag21 = !flag20;
			normal2 = (Vector3)0;
			if (!flag21)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
				object obj47 = 0;
				object obj48 = obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X0_v61+E4]");
				bool flag22 = (nint)0 == 0;
				object obj49 = !flag22;
				if (obj49 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [normal @ X2 (UnityEngine.Vector3)+80]");
				GillaSplatter.Stain((Dismemberment)0, (Vector3)1, num7, (GillaStains.Stuff)0);
				normal2 = (Vector3)0;
			}
		}
		Lay((Vector3)flag13, normal2, (byte)player != 0);
		Hide();
		object obj50 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X0_v27+E4]");
		bool flag23 = (nint)0 == 0;
		object obj51 = !flag23;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (item == null)
		{
			return;
		}
		bool live = Live;
		bool flag24 = !live;
		UnityEngine.Object obj52 = null;
		if (!flag24)
		{
			NetworkObject networkObject = ((SimulationBehaviour)this)._object;
			if ((object)((SimulationBehaviour)this)._object == null)
			{
				return;
			}
			object obj53 = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag25 = obj53 == null;
			object obj54 = !flag25;
			if (obj54 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
			object obj56 = default;
			object obj55 = obj56 & 1;
			bool flag26 = obj55 == null;
			obj52 = null;
			if (flag26)
			{
				return;
			}
		}
		bool live2 = Live;
		bool flag27 = !live2;
		NetworkBool networkBool = (NetworkBool)obj52;
		if (!flag27)
		{
			NetworkBool networkBool2 = (Broken = true);
			networkBool = networkBool2;
		}
		GillaItem gillaItem = item;
		int num26 = (int)(gillaItem.Hand__BackingField & 0x80000000L);
		bool flag28 = num26 == 0;
		object obj57 = !flag28;
		if (obj57 == null)
		{
			GillaHands.Drop(gillaItem);
			gillaItem = item;
			networkBool = (NetworkBool)0;
		}
		Collider[] array = gillaItem.Colliders__BackingField;
		if (array.Length >= 1)
		{
			object obj58 = array.Length & 0xFFFFFFFFL;
			object obj59 = array + 32;
			object obj60 = 0;
			object obj61 = 0;
			do
			{
				bool flag29 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj61) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj58);
				object obj62 = !flag29;
				if (obj62 == null)
				{
					object obj63 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X0_v43+E4]");
					bool flag30 = (nint)0 == 0;
					object obj64 = !flag30;
					if (obj64 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X24_v4+v584 @ X22_v13*8]");
					bool flag31 = (UnityEngine.Object)0 != null;
					bool flag32 = !flag31;
					obj60 = 0;
					networkBool = (NetworkBool)0;
					if (!flag32)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X24_v4+v584 @ X22_v13*8]");
						((Collider)0).enabled = false;
						obj60 = 0;
						networkBool = (NetworkBool)0;
					}
					obj58 = array.Length;
					obj61++;
					continue;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
			while ((nint)obj61 < array.Length);
		}
		item.Recycle();
	}

	private unsafe void Lay(Vector3 at, Vector3 normal, bool onSomeone)
	{
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_03ba: Expected Obj, but got I4
		//IL_03c3: Expected F4, but got I4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01b9: Expected Ref, but got VT
		//IL_05f0: Expected Obj, but got I
		//IL_061a: Expected Obj, but got I4
		//IL_0015: Expected F4, but got I
		//IL_029d: Expected Obj, but got I4
		//IL_0638: Expected Obj, but got I
		//IL_0648: Expected Obj, but got I
		//IL_0668: Expected Obj, but got I
		//IL_068a: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I4
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_020f: Expected VT, but got I8
		//IL_020f: Expected VT, but got Ref
		//IL_00ba: Expected Obj, but got I4
		//IL_06a8: Expected Obj, but got I
		//IL_06c0: Expected Obj, but got I
		//IL_06ee: Expected Obj, but got I
		//IL_072a: Expected Obj, but got I
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected Obj, but got Unknown
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Expected Obj, but got Unknown
		//IL_0789: Expected Obj, but got I
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected Obj, but got Unknown
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Expected Obj, but got Unknown
		//IL_08c6: Expected Obj, but got I4
		//IL_024f: Expected VT, but got I8
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_030d: Expected Obj, but got I
		//IL_03e1: Expected Obj, but got I
		//IL_03f9: Expected Obj, but got I
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected Obj, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected Obj, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got Unknown
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected Obj, but got Unknown
		//IL_0482: Expected Obj, but got VT
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected Obj, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got Unknown
		//IL_05bf: Expected Obj, but got I4
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_012a: Expected Obj, but got I
		//IL_0388: Expected F4, but got I
		//IL_0388: Expected F4, but got I
		//IL_0175: Expected F4, but got I
		//IL_0175: Expected F4, but got I
		//IL_05db: Expected VT, but got I4
		object obj = at & 1;
		bool flag = obj == null;
		object obj2 = !flag;
		float num = 0f;
		object obj9 = default;
		Vector3 axis = default;
		Vector3 toDirection = default;
		object obj18 = default;
		Transform transform2;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			object obj3 = default;
			if ((nint)obj3 <= 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v40+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag3 = splat == null;
				bool flag4 = !flag3;
				object obj7 = !flag4;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A884]");
					object obj8 = obj9 * 0;
					float num2 = UnityEngine.Random.Range(-35f, 35f);
					Quaternion quaternion = Quaternion.Internal_AngleAxis(num2, ref axis);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj10 = 0;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v39+A0]");
					object obj12 = 0;
					Quaternion quaternion2 = Quaternion.Internal_FromToRotation(ref axis, ref toDirection);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v40+18]");
					Vector3 vector = default;
					object obj13 = vector * 0;
					float num3 = num2 * (float)vector;
					object obj14 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v40+20]");
					object obj15 = vector * 0;
					float num4 = 1.1080827E+09f * (float)vector;
					object obj16 = vector * obj8;
					object obj17 = obj18 * vector;
					object obj19 = vector * vector;
					float num5 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v40+18]");
					float num6 = num5 * 0f;
					float num7 = (float)obj13 + num3;
					float num8 = 1.1080827E+09f * (float)obj8;
					float num9 = (float)obj15 + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v40+18]");
					object obj20 = obj18 * 0;
					float num10 = 1.1080827E+09f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v40+18]");
					float num11 = num10 * 0f;
					object obj21 = obj16 + obj17;
					float num12 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v40+20]");
					float num13 = num12 * 0f;
					object obj22 = obj18 * obj8;
					float num14 = (float)obj19 - num6;
					float num15 = 1.1080827E+09f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v40+20]");
					float num16 = num15 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v40+20]");
					object obj23 = obj18 * 0;
					float num17 = num8 + num7;
					float num18 = (float)obj20 + num9;
					float num19 = num13 + (float)obj21;
					float num20 = num14 - num16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v50+E4]");
					bool flag5 = (nint)0 == 0;
					object obj24 = !flag5;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0808]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDC9C");
					Component component = default;
					Transform transform = component.transform;
					Vector3 localScale = transform.localScale;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
					nint num21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
					float num22 = UnityEngine.Random.Range(num21, 0f);
					transform2 = transform;
					goto IL_05cd;
				}
				return;
			}
		}
		object obj26 = at & 1;
		bool flag6 = obj26 == null;
		int num23 = (onSomeone ? 1 : 0);
		ref RaycastHit reference = ref *(RaycastHit*)normal;
		Vector3 vector2 = at;
		object obj27 = obj9;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
			object obj29 = 0;
			object obj30 = obj28;
			object obj31 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v28+A0]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v32+E4]");
			bool flag7 = (nint)0 == 0;
			object obj33 = !flag7;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj34 = default;
			float num24 = default;
			IntPtr intPtr = default;
			if (!Physics.Raycast((Vector3)(&obj34), (Vector3)4294961403L, out *(RaycastHit*)1, num24, 0, (QueryTriggerInteraction)(nint)intPtr))
			{
				return;
			}
			num23 = 0;
			reference = ref *(RaycastHit*)1;
			vector2 = (Vector3)4294961403L;
			num = num24;
			object obj35 = default;
			obj27 = obj35;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj36 = 0;
		object obj37 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v8+E4]");
		bool flag8 = (nint)0 == 0;
		object obj38 = !flag8;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = puddle == null;
		bool flag10 = !flag9;
		object obj39 = !flag10;
		if (obj39 == null)
		{
			object obj40 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A884]");
			object obj41 = obj40 * 0;
			float num25 = UnityEngine.Random.Range(0f, 360f);
			Quaternion quaternion3 = Quaternion.Internal_AngleAxis(num25, ref axis);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj42 = 0;
			object obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X8_v15+A0]");
			object obj44 = 0;
			Quaternion quaternion4 = Quaternion.Internal_FromToRotation(ref axis, ref toDirection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v29+24]");
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v16+18]");
			object obj45 = num26 * 0;
			float num27 = num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v29+24]");
			float num28 = num27 * 0f;
			object obj46 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v29+24]");
			nint num29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v16+20]");
			object obj47 = num29 * 0;
			float num30 = 1.13587E+09f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v29+24]");
			float num31 = num30 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v29+24]");
			object obj48 = 0 * obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v29+24]");
			object obj49 = obj18 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v29+24]");
			nint num32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v29+24]");
			object obj50 = num32 * 0;
			float num33 = num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v16+18]");
			float num34 = num33 * 0f;
			float num35 = (float)obj45 + num28;
			float num36 = 1.13587E+09f * (float)obj41;
			float num37 = (float)obj47 + num31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v16+18]");
			object obj51 = obj18 * 0;
			float num38 = 1.13587E+09f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v16+18]");
			float num39 = num38 * 0f;
			object obj52 = obj48 + obj49;
			float num40 = num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v16+20]");
			float num41 = num40 * 0f;
			object obj53 = obj18 * obj41;
			float num42 = (float)obj50 - num34;
			float num43 = 1.13587E+09f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v16+20]");
			float num44 = num43 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v16+20]");
			object obj54 = obj18 * 0;
			float num45 = num36 + num35;
			float num46 = (float)obj51 + num37;
			float num47 = num41 + (float)obj52;
			float num48 = num42 - num44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v18+E4]");
			bool flag11 = (nint)0 == 0;
			object obj55 = !flag11;
			if (obj55 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0808]");
			object obj56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDC9C");
			Component component2 = default;
			Transform transform3 = component2.transform;
			Vector3 localScale2 = transform3.localScale;
			object obj57 = at & 1;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
				nint num49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEC4]");
				float num50 = UnityEngine.Random.Range(num49, 0f);
			}
			transform2 = transform3;
			goto IL_05cd;
		}
		return;
		IL_05cd:
		transform2.localScale = (Vector3)0;
	}

	private void Hide()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0061: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
		object obj2 = default;
		if (obj2 == null)
		{
			goto IL_00e4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+18]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+18]");
		if ((nint)0 < (nint)1)
		{
			return;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X21_v7+v96 @ X20_v7*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X21_v7+v96 @ X20_v7*8]");
				((Renderer)0).enabled = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+18]");
				obj3 = 0;
				obj5++;
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+18]");
				if ((nint)obj7 >= 0)
				{
					return;
				}
				continue;
			}
			goto IL_00e4;
		}
		goto IL_00f2;
		IL_00e4:
		NullReferenceException ex = new NullReferenceException();
		goto IL_00f2;
		IL_00f2:
		throw new IndexOutOfRangeException();
	}

	public GillaEgg()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0039: Expected F4, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5E18]");
		object obj = 0;
		stain = 0.15f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B1E8]");
		breakSpeed = 0f;
		letGoAt = 0f / 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GillaNetGuard.Holder holder = default;
		holder._002Ector();
		object obj2 = this + 192;
		obj2 = holder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	public override void CopyBackingFieldsToState(bool P_0)
	{
		Broken = _Broken;
	}

	public override void CopyStateToBackingFields()
	{
		NetworkBool broken = Broken;
		_Broken = broken;
	}

	protected unsafe static void RPC_Broke_0040Invoker4118133620([In] ref RpcInvokeContext context)
	{
		//IL_0013: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I
		//IL_021b: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I
		//IL_0268: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I4
		//IL_0281: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I
		//IL_010e: Expected I, but got Obj
		//IL_0137: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I
		//IL_00c0: Expected VT, but got Obj
		//IL_016b: Expected Obj, but got I
		//IL_01af: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out Vector3 _, 12);
		rpcDataReader.Read(out Vector3 _, 12);
		rpcDataReader.Read(out int value3, 4);
		rpcDataReader.Read(out NetworkId value4, 4);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v11+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v7+18]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D07E8]");
			object obj7 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj7);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v9+A0]");
		object obj9 = 0;
		obj9 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaEgg gillaEgg = (GillaEgg)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0810]");
		object obj10 = 0;
		object obj11 = obj10;
		nint num = (nint)gillaEgg;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v14 (Il2CppClass<GillaEgg>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X1_v9+130]");
		bool flag2 = num2 < 0;
		object obj12 = !flag2;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v14 (Il2CppClass<GillaEgg>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X1_v9+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v17-8]");
			if (0 == (nint)obj11)
			{
				object obj15 = default;
				NetworkId dummy = default;
				RpcInfo info = default;
				gillaEgg.RPC_Broke((Vector3)value3, (Vector3)value4, (int)(&obj15), dummy, info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}
}
