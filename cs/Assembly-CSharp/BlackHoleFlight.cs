using System;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class BlackHoleFlight : MonoBehaviour
{
	private const float Flies = default(float);

	private const float Waits = default(float);

	private int Owner__BackingField = -1;

	private Vector3 velocity;

	private float t;

	private bool mine;

	private bool stopped;

	private Transform model;

	private Transform ring;

	private int mask;

	public int Owner
	{
		get
		{
			return Owner__BackingField;
		}
		private set
		{
			Owner__BackingField = value;
		}
	}

	public void Begin(PocketBlackHole look, GameObject display, Vector3 v, NetworkApe by)
	{
		//IL_0010: Expected Obj, but got I
		//IL_06ea: Expected Obj, but got I4
		//IL_002e: Expected Obj, but got VT
		//IL_0046: Expected Obj, but got VT
		//IL_008e: Expected I4, but got I8
		//IL_0708: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00fc: Expected Obj, but got I8
		//IL_0129: Expected Obj, but got I
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got I4
		//IL_0181: Expected Obj, but got I
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_01c4: Expected Obj, but got I
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_01fe: Expected Obj, but got I8
		//IL_022b: Expected Obj, but got I
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_026d: Expected Obj, but got I4
		//IL_0283: Expected Obj, but got I
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_02c6: Expected Obj, but got I
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_0308: Expected Obj, but got I4
		//IL_031e: Expected Obj, but got I
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_0361: Expected Obj, but got I
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected Obj, but got Unknown
		//IL_03d0: Expected Obj, but got I4
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected Obj, but got Unknown
		//IL_0472: Expected Obj, but got I4
		//IL_04ba: Expected Obj, but got I4
		//IL_074b: Expected Obj, but got I4
		//IL_0575: Expected Obj, but got I4
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected Obj, but got Unknown
		//IL_07a0: Expected Obj, but got I4
		//IL_0620: Expected Obj, but got I4
		//IL_0526: Expected Obj, but got I4
		//IL_05dc: Expected Obj, but got I4
		//IL_07cd: Expected Obj, but got I
		//IL_07e5: Expected Obj, but got I
		//IL_07f3: Expected VT, but got I4
		//IL_081d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Vector3 vector = default;
		velocity = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)v == null;
		mine = flag2;
		int num;
		if ((UnityEngine.Object)v != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v @ X3 (UnityEngine.Vector3)+6CC]");
			num = 0;
		}
		else
		{
			num = -1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj4 = 0;
		Owner__BackingField = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array = default;
		if (array.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5A8]");
			object obj5 = 0;
			object obj6 = array + 32;
			obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X23_v4-8]");
			object obj7 = 0 & 0xFFFFFFFEL;
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F18]");
				object obj8 = 0;
				object obj9 = array + 40;
				obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X23_v6-10]");
				bool flag3 = (nint)0 < (nint)2;
				object obj10 = !flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X23_v6-10]");
				object obj11 = -2;
				bool flag4 = obj11 == null;
				object obj12 = ~obj10;
				object obj13 = obj12 | flag4;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F20]");
					object obj14 = 0;
					object obj15 = array + 48;
					obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X23_v8-18]");
					object obj16 = 0 & 0xFFFFFFFCL;
					if (obj16 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5C0]");
						object obj17 = 0;
						object obj18 = array + 56;
						obj18 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X23_v10-20]");
						bool flag5 = (nint)0 < (nint)4;
						object obj19 = !flag5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X23_v10-20]");
						object obj20 = -4;
						bool flag6 = obj20 == null;
						object obj21 = ~obj19;
						object obj22 = obj21 | flag6;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5B0]");
							object obj23 = 0;
							object obj24 = array + 64;
							obj24 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X23_v12-28]");
							bool flag7 = (nint)0 < (nint)5;
							object obj25 = !flag7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X23_v12-28]");
							object obj26 = -5;
							bool flag8 = obj26 == null;
							object obj27 = ~obj25;
							object obj28 = obj27 | flag8;
							if (obj28 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5B8]");
								object obj29 = 0;
								object obj30 = array + 72;
								obj30 = obj29;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								int num2 = LayerMask.GetMask(array);
								object obj31 = obj;
								int num3 = ~num2;
								mask = num3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v27+E4]");
								bool flag9 = (nint)0 == 0;
								object obj32 = !flag9;
								if (obj32 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if (!(display == null))
								{
									Transform transform = display.transform;
									object obj33 = this + 56;
									obj33 = transform;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj34 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X0_v35+E4]");
									bool flag10 = (nint)0 == 0;
									object obj35 = !flag10;
									if (obj35 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag11 = look.orb != null;
									bool flag12 = !flag11;
									object obj36 = 0;
									string text = null;
									UnityEngine.Object obj37 = null;
									if (!flag12)
									{
										Transform transform2 = display.transform;
										Transform root = look.transform;
										string text2 = Path(root, look.orb);
										Transform transform3 = transform2.Find(text2);
										obj36 = 0;
										text = text2;
										obj37 = transform3;
									}
									object obj38 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v40+E4]");
									bool flag13 = (nint)0 == 0;
									object obj39 = !flag13;
									if (obj39 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag14 = look.ring != null;
									bool flag15 = !flag14;
									object obj40 = 0;
									Transform transform4 = null;
									if (!flag15)
									{
										Transform transform5 = display.transform;
										Transform root2 = look.transform;
										string n = Path(root2, look.ring);
										Transform transform6 = transform5.Find(n);
										obj40 = 0;
										transform4 = transform6;
									}
									object obj41 = this + 64;
									obj41 = transform4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj42 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X0_v48+E4]");
									bool flag16 = (nint)0 == 0;
									object obj43 = !flag16;
									if (obj43 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag17 = obj37 != null;
									bool flag18 = !flag17;
									object obj44 = !flag18;
									Transform transform7 = (Transform)obj37;
									if (obj44 == null)
									{
										Transform transform8 = display.transform;
										transform7 = transform8;
									}
									Transform parent = base.transform;
									transform7.SetParent(parent, worldPositionStays: false);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
									object obj45 = 0;
									object obj46 = obj45;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v34+A0]");
									object obj47 = 0;
									transform7.localPosition = (Vector3)0;
									object obj48 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v58+E4]");
									bool flag19 = (nint)0 == 0;
									object obj49 = !flag19;
									if (obj49 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									UnityEngine.Object.Destroy(display);
									obj33 = transform7;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								}
								return;
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private static string Path(Transform root, Transform t)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I4
		if ((object)t != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B18]");
			object obj2 = 0;
			string text = t.name;
			Transform transform = t;
			while (true)
			{
				Transform parent = transform.parent;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (parent != null)
				{
					Transform parent2 = transform.parent;
					object obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v7+E4]");
					bool flag2 = (nint)0 == 0;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (parent2 != root)
					{
						Transform parent3 = transform.parent;
						if ((object)parent3 == null)
						{
							break;
						}
						string text2 = parent3.name;
						string text3 = text2 + (string)obj2 + text;
						text = text3;
						transform = parent3;
						continue;
					}
				}
				return text;
			}
		}
		return (string)(object)new NullReferenceException();
	}

	private unsafe void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_044b: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I4
		//IL_00ac: Expected F4, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_02ad: Expected VT, but got F4
		//IL_0473: Expected Obj, but got I
		//IL_04ac: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got I4
		//IL_0310: Invalid comparison between F4 and I
		//IL_04e4: Expected Obj, but got I4
		//IL_035c: Expected VT, but got I4
		//IL_035c: Expected VT, but got Ref
		//IL_03c5: Expected VT, but got I4
		//IL_03dc: Invalid comparison between F4 and I
		//IL_03a4: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		float deltaTime = Time.deltaTime;
		object obj2 = obj;
		float num = (t = deltaTime + t);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+E4]");
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
		float num2 = default;
		if (!flag3)
		{
			num2 = deltaTime * 1.1404575E+09f;
			ring.Rotate(0f, num2, 0f, (Space)1);
			obj4 = 0;
			space = (Space)1;
			num = 0f;
		}
		if (~(stopped ? 1u : 0u) == 0)
		{
			bool flag4 = (byte)(~(mine ? 1u : 0u)) != 0;
			object obj5 = !flag4;
			if (obj5 == null && (double)t > 3.0)
			{
				GameObject obj6 = gameObject;
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v36+E4]");
				bool flag5 = (nint)0 == 0;
				object obj8 = !flag5;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy(obj6);
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj11 = !flag6;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 gravity = Physics.gravity;
		float num3 = deltaTime * 0.25f;
		float num4 = num3 * num;
		float num5 = num3 * num2;
		float num6 = num3 * 0f;
		float num7 = (float)velocity + num4;
		float num8 = deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE78]");
		float num9 = num8 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BlackHoleFlight)+28]");
		float num10 = 0f + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BlackHoleFlight)+2C]");
		float num11 = 0f + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		float num12 = num9 * num7;
		float num13 = num9 * num10;
		float num14 = num9 * num11;
		velocity = (Vector3)num12;
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj12 = 0;
		float num15 = deltaTime * num14;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v21+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num16 = num15 * num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		if (num14 > 0f)
		{
		}
		object obj15 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X0_v24+E4]");
		bool flag8 = (nint)0 == 0;
		object obj16 = !flag8;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj17 = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		bool flag9 = Physics.Raycast((Vector3)(&obj17), (Vector3)mask, out *(RaycastHit*)1, num9, 0, queryTriggerInteraction);
		Transform transform2 = base.transform;
		if (flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			transform2.position = (Vector3)0;
		}
		else
		{
			Vector3 position2 = transform2.position;
			transform2.position = (Vector3)0;
			float num17 = t;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC38]");
			if (num17 < 0f)
			{
				return;
			}
		}
		Stop();
	}

	private unsafe void Stop()
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_02d9: Expected Obj, but got I
		//IL_02fb: Expected Obj, but got I4
		//IL_0359: Expected Obj, but got I
		//IL_0383: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_0232: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_0291: Expected VT, but got I4
		//IL_0114: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I
		//IL_0333: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01d1: Expected Obj, but got I4
		//IL_020d: Expected VT, but got I4
		//IL_020d: Expected VT, but got Ref
		t = 0f;
		stopped = true;
		if (~(mine ? 1u : 0u) != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v7+A0]");
		object obj8 = 0;
		UnityEngine.Object obj9 = (UnityEngine.Object)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj8 != null;
		bool flag5 = !flag4;
		object obj11 = 0;
		if (!flag5)
		{
			object obj12 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v21+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X20_v6 (UnityEngine.Object)+40]");
			bool flag7 = (UnityEngine.Object)0 != null;
			bool flag8 = !flag7;
			obj11 = 0;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X20_v6 (UnityEngine.Object)+40]");
				object obj14 = 0;
				object obj15 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v26+E4]");
				bool flag9 = (nint)0 == 0;
				object obj16 = !flag9;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X21_v8+30]");
				bool flag10 = (UnityEngine.Object)0;
				bool flag11 = !flag10;
				obj11 = 0;
				if (!flag11)
				{
					ArgumentNullException ex = new ArgumentNullException();
					object obj17 = ex & 1;
					bool flag12 = obj17 == null;
					obj11 = 0;
					if (!flag12)
					{
						Transform transform = base.transform;
						Vector3 position = transform.position;
						object obj18 = default;
						((NetworkApe)obj8).RPC_BlackHoleOpen((Vector3)(&obj18), (RpcInfo)0);
						return;
					}
				}
			}
		}
		Transform transform2 = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDA90]");
		object obj19 = 0;
		Vector3 position2 = transform2.position;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v17+E4]");
		bool flag13 = (nint)0 == 0;
		object obj21 = !flag13;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PocketBlackHole.Open(null, (Vector3)0);
	}

	public BlackHoleFlight()
	{
		//IL_000f: Expected I4, but got I8
	}
}
