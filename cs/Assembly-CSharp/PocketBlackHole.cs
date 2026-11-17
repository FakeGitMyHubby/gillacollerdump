using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class PocketBlackHole : MonoBehaviour, _0021_00211
{
	public Transform orb;

	public Transform ring;

	public GameObject field;

	public float throwSpeed = 1.3f;

	public AudioClip[] throws;

	public AudioClip[] opens;

	public AudioClip[] bursts;

	public AudioClip hum;

	private bool live;

	private Vector3 orbRest;

	private float phase;

	private static PocketBlackHole prefab;

	private static readonly List<BlackHoleFlight> flying;

	public void Live()
	{
		live = true;
	}

	public void Taken(int h)
	{
	}

	public unsafe bool LetGo(Vector3 velocity)
	{
		//IL_04a7: Expected Obj, but got I
		//IL_04d1: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_047e: Expected I4, but got Obj
		//IL_012e: Expected Obj, but got I4
		//IL_01cc: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I4
		//IL_022b: Expected VT, but got I4
		//IL_022b: Expected VT, but got I4
		//IL_023b: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I4
		//IL_050e: Expected Obj, but got I4
		//IL_056c: Expected Obj, but got I
		//IL_0596: Expected Obj, but got I4
		//IL_031f: Expected Obj, but got I4
		//IL_034e: Expected Obj, but got I
		//IL_037f: Expected Obj, but got I
		//IL_0546: Expected Obj, but got I4
		//IL_03c9: Expected Obj, but got I
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected Obj, but got Unknown
		//IL_045d: Expected VT, but got Obj
		//IL_045d: Expected VT, but got I4
		//IL_045d: Expected VT, but got Ref
		float num;
		object obj11;
		Transform transform;
		if (~(live ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v6+E4]");
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
			num = (float)obj9 + (float)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			if (!(num < throwSpeed))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				obj11 = 0;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj13 = !flag2;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (orb != null)
				{
					transform = orb;
					bool flag3 = (object)orb == null;
					object obj14 = !flag3;
					if (obj14 != null)
					{
						goto IL_0176;
					}
				}
				else
				{
					transform = base.transform;
					if ((object)transform != null)
					{
						goto IL_0176;
					}
				}
				goto IL_0470;
			}
		}
		return false;
		IL_0470:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0176:
		Vector3 position = transform.position;
		Transform transform2 = base.transform;
		if ((object)transform2 != null)
		{
			Vector3 lossyScale = transform2.lossyScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDA90]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v19+E4]");
			bool flag4 = (nint)0 == 0;
			object obj17 = !flag4;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			NetworkApe networkApe = default;
			Launch(this, (Vector3)0, (Vector3)0, networkApe, num);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj18 = 0;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v22+E4]");
			bool flag5 = (nint)0 == 0;
			object obj20 = !flag5;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj21 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v26+E4]");
			bool flag6 = (nint)0 == 0;
			object obj22 = !flag6;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj18;
			}
			object obj23 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v26+A0]");
			object obj24 = 0;
			UnityEngine.Object obj25 = (UnityEngine.Object)obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v20+E4]");
			bool flag7 = (nint)0 == 0;
			object obj26 = !flag7;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj24 != null)
			{
				if (obj24 == null)
				{
					goto IL_0470;
				}
				object obj27 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v32+E4]");
				bool flag8 = (nint)0 == 0;
				object obj28 = !flag8;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X19_v7 (UnityEngine.Object)+40]");
				if ((UnityEngine.Object)0 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X19_v7 (UnityEngine.Object)+40]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X19_v7 (UnityEngine.Object)+40]");
					if ((nint)0 == 0)
					{
						goto IL_0470;
					}
					object obj30 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v37+E4]");
					bool flag9 = (nint)0 == 0;
					object obj31 = !flag9;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X20_v11+30]");
					if ((bool)(UnityEngine.Object)0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X20_v11+30]");
						if ((nint)0 == 0)
						{
							goto IL_0470;
						}
						ArgumentNullException ex2 = new ArgumentNullException();
						object obj32 = ex2 & 1;
						if (obj32 != null)
						{
							object obj33 = default;
							((NetworkApe)obj24).RPC_BlackHoleThrow((Vector3)(&obj33), (Vector3)0, num, (RpcInfo)networkApe);
						}
					}
				}
			}
			return true;
		}
		goto IL_0470;
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I4
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
		if (orb != null)
		{
			Vector3 localPosition = orb.localPosition;
			Vector3 vector = default;
			orbRest = vector;
		}
		float value = UnityEngine.Random.value;
		float num = value * 10f;
		phase = num;
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I4
		//IL_00ac: Expected F4, but got I4
		//IL_015d: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		float deltaTime = Time.deltaTime;
		object obj2 = obj;
		float num = deltaTime + phase;
		phase = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = ring != null;
		bool flag3 = !flag2;
		object obj4 = 0;
		Space space = (Space)0;
		if (!flag3)
		{
			float yAngle = deltaTime * 1.1325932E+09f;
			ring.Rotate(0f, yAngle, 0f, (Space)1);
			obj4 = 0;
			space = (Space)1;
			num = 0f;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (orb != null)
		{
			float num2 = phase;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB6C]");
			float num3 = num2 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			orb.localPosition = (Vector3)0;
		}
	}

	private static PocketBlackHole Prefab()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I
		//IL_02cd: Expected Obj, but got I4
		//IL_0371: Expected Obj, but got I
		//IL_0393: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I4
		//IL_02eb: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I4
		//IL_0179: Expected Obj, but got I4
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01e3: Expected Obj, but got I4
		//IL_025b: Expected Obj, but got I4
		//IL_0332: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDA90]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj6 != null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v34+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v34+A0]");
			return (PocketBlackHole)0;
		}
		int count = CosmeticCatalog.Count;
		if (count >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE7A8]");
			object obj10 = 0;
			PocketBlackHole pocketBlackHole = null;
			object obj11 = 0;
			int num = 1;
			object obj15 = default;
			while (true)
			{
				CosmeticCatalog.Entry entry = CosmeticCatalog.Of(num);
				if (entry != null)
				{
					object obj12 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v17+E4]");
					bool flag4 = (nint)0 == 0;
					object obj13 = !flag4;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag5 = entry.prefab != null;
					bool flag6 = !flag5;
					obj11 = 0;
					if (!flag6)
					{
						if ((object)entry.prefab == null)
						{
							goto IL_0285;
						}
						obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
						object obj14 = obj15 & 1;
						bool flag7 = obj14 == null;
						object obj16 = !flag7;
						if (obj16 != null)
						{
							object obj17 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v27+E4]");
							bool flag8 = (nint)0 == 0;
							object obj18 = !flag8;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj17 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v27+A0]");
							object obj19 = 0;
							obj19 = pocketBlackHole;
							object obj20 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							return pocketBlackHole;
						}
					}
					num++;
					int count2 = CosmeticCatalog.Count;
					if (num > count2)
					{
						break;
					}
					continue;
				}
				goto IL_0285;
				IL_0285:
				return (PocketBlackHole)(object)new NullReferenceException();
			}
		}
		return null;
	}

	public static void ShowThrow(NetworkApe by, Vector3 from, Vector3 velocity, float size)
	{
		//IL_0010: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I
		//IL_013c: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I
		//IL_0100: Expected VT, but got I4
		//IL_0100: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDA90]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PocketBlackHole pocketBlackHole = Prefab();
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (pocketBlackHole != null)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IntPtr intPtr = default;
			Launch(pocketBlackHole, (Vector3)by, (Vector3)0, (NetworkApe)(nint)intPtr, size);
		}
	}

	public static void Open(NetworkApe by, Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_07ae: Expected Obj, but got I4
		//IL_006e: Expected I4, but got I8
		//IL_07cc: Expected Obj, but got I
		//IL_07f6: Expected Obj, but got I4
		//IL_09c3: Expected Obj, but got I
		//IL_09d3: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I4
		//IL_0826: Expected Obj, but got I4
		//IL_03a2: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I4
		//IL_03e7: Expected Obj, but got I4
		//IL_03f0: Expected Obj, but got I4
		//IL_089d: Expected Obj, but got I4
		//IL_04b2: Expected Obj, but got I4
		//IL_0844: Expected Obj, but got I
		//IL_04f7: Expected Obj, but got I4
		//IL_042d: Expected Obj, but got I4
		//IL_013a: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I4
		//IL_0475: Expected Obj, but got I4
		//IL_0515: Expected Obj, but got I
		//IL_053f: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got I4
		//IL_08f3: Expected Obj, but got I
		//IL_0913: Expected Obj, but got I
		//IL_0935: Expected Obj, but got I4
		//IL_01da: Expected Obj, but got I4
		//IL_08d5: Expected Obj, but got I4
		//IL_05df: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I4
		//IL_0859: Expected Obj, but got I
		//IL_09f0: Expected Obj, but got I
		//IL_0a12: Expected Obj, but got I4
		//IL_05fe: Expected Obj, but got I
		//IL_061b: Expected Obj, but got I
		//IL_086e: Expected Obj, but got I
		//IL_021c: Expected Obj, but got I
		//IL_0224: Expected Obj, but got I4
		//IL_02ca: Expected Obj, but got I
		//IL_096d: Expected Obj, but got I4
		//IL_0306: Expected Obj, but got I4
		//IL_0672: Expected Obj, but got I
		//IL_06ea: Expected Obj, but got I
		//IL_0714: Expected Obj, but got I4
		//IL_09a5: Expected Obj, but got I4
		//IL_0a38: Expected Obj, but got I
		//IL_0a5a: Expected Obj, but got I4
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
		int num = (int)((!((UnityEngine.Object)by != (UnityEngine.Object)null)) ? 4294967295L : by.owner);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDA90]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v9+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v5+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v6+18]");
		int num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v6+18]");
		bool flag3 = (nint)0 < (nint)1;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE7D0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE7C0]");
			object obj12 = 0;
			obj9 = 0;
			obj10 = null;
			do
			{
				object obj13 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v87+E4]");
				bool flag4 = (nint)0 == 0;
				object obj14 = !flag4;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj13 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v87+A0]");
				object obj15 = 0;
				num2--;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v46+8]");
				System.__Canon _Canon = ((List<System.__Canon>)0).get_Item(num2);
				object obj16 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v47+E4]");
				bool flag5 = (nint)0 == 0;
				object obj17 = !flag5;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)(object)_Canon == null)
				{
					object obj18 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X0_v107+E4]");
					bool flag6 = (nint)0 == 0;
					object obj19 = !flag6;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj18 = obj4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X0_v107+A0]");
					object obj20 = 0;
					obj9 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v54+8]");
					((List<System.__Canon>)0).RemoveAt(num2);
					obj10 = (UnityEngine.Object)num2;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v89 (System.__Canon)+20]");
				bool flag7 = (nint)0 != num;
				obj9 = 0;
				obj10 = null;
				if (!flag7)
				{
					object obj21 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v96+E4]");
					bool flag8 = (nint)0 == 0;
					object obj22 = !flag8;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj21 = obj4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v96+A0]");
					object obj23 = 0;
					obj9 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v51+8]");
					((List<System.__Canon>)0).RemoveAt(num2);
					GameObject obj24 = ((Component)(object)_Canon).gameObject;
					object obj25 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v52+E4]");
					bool flag9 = (nint)0 == 0;
					object obj26 = !flag9;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(obj24);
					obj10 = null;
				}
			}
			while (num2 > 0);
			obj5 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v9+E4]");
		bool flag10 = (nint)0 == 0;
		object obj27 = !flag10;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PocketBlackHole pocketBlackHole = Prefab();
		object obj28 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v9+E4]");
		bool flag11 = (nint)0 == 0;
		object obj29 = !flag11;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag12 = pocketBlackHole == null;
		bool flag13 = !flag12;
		object obj30 = !flag13;
		object obj31 = 0;
		UnityEngine.Object obj32 = null;
		if (obj30 == null)
		{
			object obj33 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v38+E4]");
			bool flag14 = (nint)0 == 0;
			object obj34 = !flag14;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag15 = pocketBlackHole.field == null;
			bool flag16 = !flag15;
			obj31 = 0;
			obj32 = null;
			if (flag16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
				object obj35 = 0;
				object obj36 = obj;
				object obj37 = obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v24+A0]");
				object obj38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X0_v43+E4]");
				bool flag17 = (nint)0 == 0;
				object obj39 = !flag17;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5370]");
				object obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDC9C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE7D8]");
				object obj41 = 0;
				UnityEngine.Object obj42 = default;
				obj42.name = (string)obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE7B8]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
				UnityEngine.Object obj44 = default;
				bool flag18 = obj44 == null;
				bool flag19 = !flag18;
				UnityEngine.Object obj45 = obj44;
				UnityEngine.Object obj46 = null;
				if (!flag19)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE7B0]");
					object obj47 = 0;
					obj46 = (UnityEngine.Object)obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
					UnityEngine.Object obj48 = default;
					obj45 = obj48;
				}
				object obj49 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X0_v51+E4]");
				bool flag20 = (nint)0 == 0;
				object obj50 = !flag20;
				if (obj50 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool yours;
				if ((UnityEngine.Object)by == (UnityEngine.Object)null)
				{
					yours = true;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
					object obj51 = 0;
					object obj52 = obj51;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v57+E4]");
					bool flag21 = (nint)0 == 0;
					object obj53 = !flag21;
					if (obj53 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj54 = obj51;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v61+E4]");
					bool flag22 = (nint)0 == 0;
					object obj55 = !flag22;
					if (obj55 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj54 = obj51;
					}
					object obj56 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v61+A0]");
					object obj57 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v39+E4]");
					bool flag23 = (nint)0 == 0;
					object obj58 = !flag23;
					if (obj58 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					yours = by == (UnityEngine.Object)obj57;
				}
				((BlackHoleField)obj45).Begin(pocketBlackHole, yours);
				return;
			}
		}
		object obj59 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X0_v15+E4]");
		bool flag24 = (nint)0 == 0;
		object obj60 = !flag24;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag25 = (UnityEngine.Object)by == (UnityEngine.Object)null;
		bool flag26 = !flag25;
		object obj61 = !flag26;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj62 = 0;
			object obj63 = obj62;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X0_v21+E4]");
			bool flag27 = (nint)0 == 0;
			object obj64 = !flag27;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj65 = obj62;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v25+E4]");
			bool flag28 = (nint)0 == 0;
			object obj66 = !flag28;
			if (obj66 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj65 = obj62;
			}
			object obj67 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v25+A0]");
			object obj68 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v17+E4]");
			bool flag29 = (nint)0 == 0;
			object obj69 = !flag29;
			if (obj69 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(by == (UnityEngine.Object)obj68))
			{
				return;
			}
		}
		GillaToys.Back();
	}

	private static void Launch(PocketBlackHole look, Vector3 from, Vector3 velocity, NetworkApe by, float size)
	{
		//IL_0010: Expected Obj, but got I
		//IL_039f: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0084: Expected VT, but got I4
		//IL_00c3: Expected VT, but got I4
		//IL_0105: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I
		//IL_013b: Expected VT, but got I4
		//IL_0163: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I4
		//IL_03fd: Expected Obj, but got I
		//IL_040d: Expected Obj, but got I
		//IL_01c2: Expected Obj, but got I
		//IL_021c: Expected Obj, but got I4
		//IL_02a1: Expected Obj, but got I
		//IL_02b1: Expected Obj, but got I
		//IL_02c1: Expected Obj, but got I
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_030d: Expected Obj, but got I
		//IL_0337: Expected Obj, but got I4
		//IL_0373: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDA90]");
		object obj = 0;
		PocketBlackHole look2 = (PocketBlackHole)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (PocketBlackHole)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE7A0]");
		object obj4 = 0;
		CosmeticCatalog.Entry entry = Entry(look2);
		GameObject gameObject2;
		if (entry != null)
		{
			GameObject gameObject = CosmeticCatalog.Display(entry);
			Vector3 vector = (Vector3)0;
			gameObject2 = gameObject;
		}
		else
		{
			Vector3 vector = from;
			gameObject2 = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject3 = default;
		gameObject3._002Ector((string)obj4);
		Transform transform = gameObject3.transform;
		transform.position = (Vector3)0;
		Transform transform2 = gameObject3.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		object obj5 = default;
		if ((nint)obj5 < 0 || (nint)obj5 > 1120403456)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v11+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE790]");
		object obj9 = 0;
		transform2.localScale = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		BlackHoleFlight blackHoleFlight = default;
		IntPtr intPtr = default;
		blackHoleFlight.Begin(look, gameObject2, from, (NetworkApe)(nint)intPtr);
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v19+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v19+A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v14+8]");
		List<System.__Canon> list = (List<System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE798]");
		object obj13 = 0;
		System.__Canon[] items = list._items;
		object obj14 = obj13;
		int version = list._version + 1;
		list._version = version;
		bool flag3 = list._size < items.Length;
		object obj15 = !flag3;
		if (obj15 == null)
		{
			object obj16 = items + list._size;
			int size2 = list._size + 1;
			list._size = size2;
			object obj17 = obj16 + 32;
			obj17 = blackHoleFlight;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			GameObject gameObject4 = gameObject2;
			System.__Canon _Canon = (System.__Canon)(object)blackHoleFlight;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X9_v4+20]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v21+A8]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v22+70]");
			GameObject gameObject4 = (GameObject)0;
			list.AddWithResize((System.__Canon)(object)blackHoleFlight);
			System.__Canon _Canon = (System.__Canon)(object)blackHoleFlight;
		}
		if (look.throws != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj20 = 0;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v22+E4]");
			bool flag4 = (nint)0 == 0;
			object obj22 = !flag4;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float pitchMin = default;
			float pitchMax = default;
			Sfx.Play(look.throws, (Vector3)0, size, pitchMin, pitchMax);
		}
	}

	private static CosmeticCatalog.Entry Entry(PocketBlackHole look)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_010f: Expected Obj, but got I4
		int count = CosmeticCatalog.Count;
		if (count < 1)
		{
			goto IL_015b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE7A8]");
		object obj2 = 0;
		int num = 1;
		object obj7 = default;
		CosmeticCatalog.Entry result;
		while (true)
		{
			CosmeticCatalog.Entry entry = CosmeticCatalog.Of(num);
			if (entry != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = entry.prefab != null;
				bool flag3 = !flag2;
				object obj5 = 0;
				if (!flag3)
				{
					if ((object)entry.prefab == null)
					{
						goto IL_0165;
					}
					obj5 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
					object obj6 = obj7 & 1;
					bool flag4 = obj6 == null;
					object obj8 = !flag4;
					result = entry;
					if (obj8 != null)
					{
						break;
					}
				}
				num++;
				int count2 = CosmeticCatalog.Count;
				if (num <= count2)
				{
					continue;
				}
				goto IL_015b;
			}
			goto IL_0165;
			IL_0165:
			return (CosmeticCatalog.Entry)(object)new NullReferenceException();
		}
		goto IL_0199;
		IL_0199:
		return result;
		IL_015b:
		result = null;
		goto IL_0199;
	}

	static PocketBlackHole()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE808]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDA90]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+A0]");
		object obj4 = (nint)0 + (nint)8;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
