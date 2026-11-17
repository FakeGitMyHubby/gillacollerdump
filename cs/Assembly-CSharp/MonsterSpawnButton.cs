using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class MonsterSpawnButton : MonoBehaviour
{
	public GameObject prefab;

	public Transform[] hands;

	public Transform head;

	public float radius;

	public float minDistance;

	public float maxDistance = 6f;

	private static readonly List<GameObject> Spawned;

	private const int Mask = default(int);

	private float cooldown;

	private Vector3 baseScale;

	private void Start()
	{
		Transform transform = base.transform;
		Vector3 localScale = transform.localScale;
		Vector3 vector = default;
		baseScale = vector;
	}

	private void Update()
	{
		//IL_0078: Invalid comparison between F8 and I4
		//IL_0087: Expected F8, but got I4
		//IL_015c: Expected VT, but got I4
		//IL_0171: Invalid comparison between F4 and I4
		//IL_01e1: Expected Obj, but got I8
		//IL_01f1: Expected Obj, but got I
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_020a: Expected Obj, but got I4
		//IL_0213: Expected VT, but got I4
		//IL_04c4: Expected Obj, but got I4
		//IL_0242: Expected Obj, but got I4
		//IL_0271: Expected Obj, but got I
		//IL_028f: Expected Obj, but got I4
		//IL_02a8: Expected VT, but got I4
		//IL_03f8: Expected Obj, but got I4
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_02ec: Expected Obj, but got I
		//IL_03d8: Expected VT, but got I4
		float deltaTime = Time.deltaTime;
		float num = (cooldown -= deltaTime);
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		if ((object)transform2 != null)
		{
			Vector3 localScale = transform2.localScale;
			float deltaTime2 = Time.deltaTime;
			float num2 = deltaTime2 * -10f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
			double num3 = 1.0 - (double)num2;
			bool flag = num3 < 0.0;
			double num4 = 0.0;
			if (!flag)
			{
				bool flag2 = !(num3 > 1.0);
				num4 = num3;
				if (!flag2)
				{
					num4 = 1.0;
				}
			}
			if ((object)transform != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterSpawnButton)+50]");
				double num6 = default;
				double num5 = 0.0 - num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterSpawnButton)+4C]");
				double num8 = default;
				double num7 = 0.0 - num8;
				float num9 = (float)baseScale - num;
				double num10 = num5 * num4;
				double num11 = num7 * num4;
				double num12 = num6 + num10;
				double num13 = num8 + num11;
				transform.localScale = (Vector3)0;
				float num14 = cooldown;
				if (cooldown > 0f)
				{
					return;
				}
				Transform[] array = hands;
				if (hands == null || array.Length < 1)
				{
					return;
				}
				object obj = array.Length & 0xFFFFFFFFL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj2 = 0;
				object obj3 = hands + 32;
				object obj4 = 0;
				Vector3 vector = (Vector3)0;
				while (true)
				{
					bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
					object obj5 = !flag3;
					if (obj5 != null)
					{
						break;
					}
					object obj6 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v17+E4]");
					bool flag4 = (nint)0 == 0;
					object obj7 = !flag4;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X24_v5+v73 @ X22_v6*8]");
					bool flag5 = (UnityEngine.Object)0 == null;
					bool flag6 = !flag5;
					object obj8 = !flag6;
					double num15 = num12;
					double num16 = num13;
					vector = (Vector3)0;
					if (obj8 != null)
					{
						goto IL_03ee;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X24_v5+v73 @ X22_v6*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X24_v5+v73 @ X22_v6*8]");
						Vector3 position = ((Transform)0).position;
						Transform transform3 = base.transform;
						if ((object)transform3 != null)
						{
							Vector3 position2 = transform3.position;
							float num17 = num14 - num14;
							double num18 = num13 - num13;
							double num19 = num12 - num12;
							float num20 = num17 * num17;
							double num21 = num18 * num18;
							float num22 = num20 + (float)num21;
							double num23 = num19 * num19;
							num15 = radius;
							double num24 = num23 + (double)num22;
							num16 = (double)radius * (double)radius;
							bool flag7 = !(num24 > num16);
							vector = (Vector3)0;
							num14 = (float)num24;
							if (!flag7)
							{
								goto IL_03ee;
							}
							Press();
							return;
						}
					}
					goto IL_043c;
					IL_03ee:
					obj = array.Length;
					obj4++;
					bool flag8 = (nint)obj4 < array.Length;
					num12 = num15;
					num13 = num16;
					if (!flag8)
					{
						return;
					}
				}
				goto IL_044a;
			}
		}
		goto IL_043c;
		IL_043c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_044a;
		IL_044a:
		throw new IndexOutOfRangeException();
	}

	public void Click()
	{
		//IL_000b: Invalid comparison between F4 and I4
		//IL_001c: Expected Obj, but got I4
		//IL_0027: Invalid comparison between F4 and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		bool flag = cooldown < 0f;
		object obj = !flag;
		bool flag2 = cooldown == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		if (obj3 != null)
		{
			Press();
		}
	}

	private void Press()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I
		//IL_004b: Expected Obj, but got I
		//IL_0059: Expected VT, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I4
		cooldown = 1f;
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj2 = default;
		object obj = baseScale * obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterSpawnButton)+50]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		object obj4 = num * 0;
		transform.localScale = (Vector3)0;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (prefab == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDAF0]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Clear();
		}
		else
		{
			Spawn();
		}
	}

	private unsafe void Spawn()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0942: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I4
		//IL_00e3: Expected F4, but got I4
		//IL_097a: Expected Obj, but got I4
		//IL_017e: Expected F4, but got I
		//IL_01d0: Invalid comparison between F4 and I4
		//IL_01df: Invalid comparison between F4 and I4
		//IL_01f2: Expected Obj, but got F8
		//IL_01ff: Expected Obj, but got F4
		//IL_0234: Expected Obj, but got I4
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_09a2: Expected Obj, but got I
		//IL_09b2: Expected Obj, but got I
		//IL_09bb: Expected F4, but got I4
		//IL_09c4: Expected Obj, but got I4
		//IL_09fb: Expected Obj, but got I
		//IL_0a0b: Expected F8, but got I
		//IL_0a1a: Expected VT, but got I4
		//IL_0a1a: Expected VT, but got I4
		//IL_0a5d: Expected Obj, but got I4
		//IL_02f8: Expected VT, but got I4
		//IL_02f8: Expected VT, but got I8
		//IL_0ac7: Expected Obj, but got I
		//IL_0ad8: Expected F4, but got I
		//IL_0afa: Expected Obj, but got I4
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected Obj, but got Unknown
		//IL_037b: Expected VT, but got I4
		//IL_03c6: Expected VT, but got I8
		//IL_03c6: Expected VT, but got Ref
		//IL_03ff: Expected F4, but got I
		//IL_040f: Expected F4, but got I
		//IL_045c: Invalid comparison between I4 and F8
		//IL_0488: Expected F4, but got I
		//IL_0498: Expected F4, but got I
		//IL_04c6: Expected F4, but got I4
		//IL_06c1: Expected Obj, but got I
		//IL_06e7: Expected Obj, but got I
		//IL_0711: Expected Obj, but got I4
		//IL_0b28: Expected Obj, but got I
		//IL_0b4b: Expected Obj, but got I4
		//IL_0cff: Expected Obj, but got I
		//IL_0d51: Expected VT, but got I4
		//IL_0d51: Expected VT, but got I8
		//IL_0d6f: Expected Obj, but got I4
		//IL_0b79: Expected Obj, but got I
		//IL_0b8a: Expected F4, but got I
		//IL_0bac: Expected Obj, but got I4
		//IL_060a: Expected VT, but got I4
		//IL_060a: Expected VT, but got I8
		//IL_0628: Expected Obj, but got I4
		//IL_0bf0: Expected Obj, but got I
		//IL_0c3d: Expected Obj, but got I
		//IL_0c4d: Invalid comparison between F4 and I
		//IL_0750: Expected VT, but got I4
		//IL_079b: Expected Obj, but got I4
		//IL_0c74: Expected Obj, but got I
		//IL_069d: Expected VT, but got I4
		//IL_07e9: Expected Obj, but got I
		//IL_0c93: Expected Obj, but got I
		//IL_0cbd: Expected Obj, but got I4
		//IL_0dcc: Expected Obj, but got I
		//IL_089f: Expected Obj, but got I4
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected Obj, but got Unknown
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ed: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = head == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB7D8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj8 = default;
		bool flag5 = obj8 != null;
		bool flag6 = !flag5;
		float num = 0f;
		double num2 = 2.0;
		UnityEngine.Object obj9 = null;
		if (!flag6)
		{
			num = ((CharacterController)obj8).height;
			num2 = num;
			obj9 = null;
		}
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X0_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj11 = !flag7;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num3;
		if (obj8 != null)
		{
			num3 = ((CharacterController)obj8).radius;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			num3 = 0f;
		}
		Vector3 position = head.position;
		double num4 = num2 - (double)num3;
		float num5 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num6 = num5 + 0f;
		float num7 = num6 - (float)num4;
		bool flag8 = num7 < 0f;
		bool flag9 = num7 == 0f;
		object obj12 = (double)num6 ^ num4;
		object obj13 = num6 ^ num7;
		object obj14 = obj12 & obj13;
		bool flag10 = (nint)obj14 < 0;
		bool flag11 = flag8 == flag10;
		object obj15 = !flag9;
		object obj16 = flag11 & obj15;
		object obj17 = ~obj16;
		double num8 = ((obj17 != null) ? num4 : ((double)num6));
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj19 = 0;
		float num9 = 0f;
		object obj20 = 60;
		float num10 = num3;
		float num12 = default;
		float num11 = num12;
		int num13 = 0;
		Vector3 euler = default;
		double num24 = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		QueryTriggerInteraction queryTriggerInteraction2 = default;
		float num36 = default;
		object obj34 = default;
		float num52;
		object obj43;
		while (true)
		{
			float num14 = UnityEngine.Random.Range(0f, 360f);
			float num15 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			float num16 = num15 * 0f;
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
			object obj21 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v16+A0]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v17+50]");
			double num17 = 0.0;
			Vector3 vector = (Quaternion)0 * (Vector3)0;
			float num18 = UnityEngine.Random.Range(minDistance, maxDistance);
			object obj23 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X0_v30+E4]");
			bool flag12 = (nint)0 == 0;
			object obj24 = !flag12;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num19 = num16 * num18;
			float num20 = 1.13587E+09f * num18;
			float num21 = num10 * num18;
			float num22 = num3 + num19;
			float num23 = (float)num24 + num20;
			float num25 = num11 + num21;
			bool flag13 = Physics.Linecast((Vector3)4294965499L, (Vector3)1, 0, queryTriggerInteraction);
			bool flag14 = !flag13;
			float num26 = num25;
			float num27 = num23;
			float num28 = num22;
			double num29 = num24;
			num10 = num11;
			float num30 = num3;
			num13 = 0;
			if (flag14)
			{
				object obj25 = obj18;
				object obj26 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v20+A0]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v21+24]");
				float num31 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X0_v35+E4]");
				bool flag15 = (nint)0 == 0;
				object obj28 = !flag15;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag16 = Physics.Raycast((Vector3)(&num9), (Vector3)4294965499L, out *(RaycastHit*)1, num22, 0, queryTriggerInteraction2);
				bool flag17 = !flag16;
				queryTriggerInteraction = (QueryTriggerInteraction)0;
				num17 = 4.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v21+2C]");
				num26 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v21+28]");
				num27 = 0f;
				num28 = num31;
				num29 = num23;
				num10 = num25;
				num11 = num12;
				num30 = num22;
				num13 = 1;
				if (!flag17)
				{
					bool flag18 = 0.0 < 0.75;
					queryTriggerInteraction = (QueryTriggerInteraction)0;
					num17 = 4.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v21+2C]");
					num26 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v21+28]");
					num27 = 0f;
					num28 = num31;
					num29 = 0.75;
					num10 = num25;
					num11 = num12;
					num30 = 0f;
					num13 = 1;
					if (!flag18)
					{
						float num32 = num9;
						object obj29 = obj18;
						object obj30 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X8_v23+A0]");
						object obj31 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X0_v40+E4]");
						bool flag19 = (nint)0 == 0;
						object obj32 = !flag19;
						if (obj32 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							num32 = num9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X8_v24+18]");
						double num33 = 0.0 * num8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X8_v24+20]");
						nint num34 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
						object obj33 = num34 * 0;
						num28 = num32 + (float)num33;
						double num35 = num36;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
						num29 = num35 + 0.0;
						num26 = (float)obj34 + (float)obj33;
						bool flag20 = Physics.Linecast((Vector3)4294965499L, (Vector3)1, 0, (QueryTriggerInteraction)0);
						bool flag21 = !flag20;
						object obj35 = !flag21;
						queryTriggerInteraction = (QueryTriggerInteraction)0;
						num17 = 4.0;
						num27 = num36;
						num10 = num12;
						num11 = num12;
						num30 = num3;
						num13 = 0;
						if (obj35 == null)
						{
							object obj36 = obj18;
							object obj37 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X8_v26+A0]");
							object obj38 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v27+20]");
							num31 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X0_v45+E4]");
							bool flag22 = (nint)0 == 0;
							object obj39 = !flag22;
							if (obj39 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							float num37 = num6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v27+18]");
							float num38 = num37 * 0f;
							float num39 = num6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v27+1C]");
							float num40 = num39 * 0f;
							float num41 = num6 * num31;
							double num42 = num8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v27+18]");
							double num43 = num42 * 0.0;
							double num44 = num8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v27+1C]");
							double num45 = num44 * 0.0;
							double num46 = num8 * (double)num31;
							num30 = num9 + num38;
							num29 = (double)num36 + (double)num40;
							num10 = (float)obj34 + num41;
							num28 = num9 + (float)num43;
							num27 = num36 + (float)num45;
							num26 = (float)obj34 + (float)num46;
							bool flag23 = Physics.CheckCapsule((Vector3)4294965499L, (Vector3)1, num30, 0, (QueryTriggerInteraction)0);
							bool flag24 = !flag23;
							object obj40 = !flag24;
							queryTriggerInteraction = (QueryTriggerInteraction)0;
							num17 = num3;
							num11 = num12;
							num13 = 0;
							if (obj40 == null)
							{
								float num47 = num12 - (float)obj34;
								float num48 = num3 - num9;
								float num49 = num48 * num48;
								float num50 = num47 * num47;
								object obj41 = obj18;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v30+A0]");
								object obj42 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								float num51 = num49 + num50;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X8_v31+18]");
								num52 = 0f * num10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X8_v31+20]");
								nint num53 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
								obj43 = num53 * 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
								if (num51 > 0f)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE5FD8");
									Vector3 vector2 = (Vector3)0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DA97E8");
									Vector3 vector2 = (Vector3)1;
								}
								break;
							}
						}
					}
				}
			}
			obj20--;
			bool flag25 = (nint)obj20 != 1;
			euler = (Vector3)0;
			if (!flag25)
			{
				string text = prefab.name;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB00]");
				object obj44 = 0;
				string message = (string)obj44 + text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj45 = 0;
				object obj46 = obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v54+E4]");
				bool flag26 = (nint)0 == 0;
				object obj47 = !flag26;
				if (obj47 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogWarning(message);
				return;
			}
		}
		object obj48 = obj;
		float num54 = num9 + num52;
		object obj49 = obj34 + obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v51+E4]");
		bool flag27 = (nint)0 == 0;
		object obj50 = !flag27;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5370]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDC9C");
		string text2 = prefab.name;
		UnityEngine.Object obj52 = default;
		obj52.name = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDAF8]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
		UnityEngine.Object obj54 = default;
		if (obj54 != null)
		{
			_ = 1;
			_ = 1086324736;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDAF0]");
		object obj55 = 0;
		object obj56 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X0_v62+E4]");
		bool flag28 = (nint)0 == 0;
		object obj57 = !flag28;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj56 = obj55;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X0_v62+A0]");
		object obj58 = 0;
		List<System.__Canon> list = (List<System.__Canon>)obj58;
		System.__Canon[] items = list._items;
		int version = list._version + 1;
		list._version = version;
		bool flag29 = list._size < items.Length;
		object obj59 = !flag29;
		if (obj59 == null)
		{
			object obj60 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj61 = obj60 + 32;
			obj61 = obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			list.AddWithResize((System.__Canon)(object)obj52);
		}
	}

	private unsafe static void Clear()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I4
		//IL_0479: Expected Obj, but got I
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got I4
		//IL_0430: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got Ref
		//IL_011a: Expected Obj, but got I
		//IL_013c: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I4
		//IL_016b: Expected Obj, but got I4
		//IL_03e0: Expected Obj, but got I
		//IL_0301: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I4
		//IL_0242: Expected Obj, but got I
		//IL_0291: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDAF0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+A0]");
		UnityEngine.Object obj4 = (UnityEngine.Object)0;
		bool flag2 = (object)obj4 == null;
		Enumerator<, > val = (Enumerator<, >)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4928]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4920]");
			object obj7 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)obj4).GetEnumerator();
			UnityEngine.Object obj8 = default;
			obj4 = obj8;
			while (val.MoveNext())
			{
				object obj9 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v35+E4]");
				obj4 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v35+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag4 = obj8 != null;
				bool flag5 = !flag4;
				object obj11 = 0;
				if (!flag5)
				{
					object obj12 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v39+E4]");
					obj4 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v39+E4]");
					bool flag6 = (nint)0 == 0;
					object obj13 = !flag6;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(obj8);
					obj11 = 0;
				}
			}
			UnityEngine.Object obj14 = null;
			Enumerator<, > val2 = default;
			val = val2;
			object obj15 = 0;
			Enumerator<, > val3 = (Enumerator<, >)(ref val);
			object obj16 = 0;
			object obj19 = default;
			while (true)
			{
				val.Dispose();
				bool flag7 = obj16 == null;
				object obj17 = !flag7;
				obj8 = obj14;
				if (obj17 == null)
				{
					bool flag8 = (object)obj14 == null;
					object obj18 = !flag8;
					obj8 = obj14;
					OutOfMemoryException ex = (OutOfMemoryException)(&val);
					obj4 = obj14;
					if (obj18 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)obj7 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj14 = (UnityEngine.Object)1;
					obj4 = (UnityEngine.Object)1;
					obj16 = obj15;
					continue;
				}
				if ((nint)obj7 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj16 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj14 = obj8;
					obj15 = obj19;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D0C4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v8+E4]");
			bool flag9 = (nint)0 == 0;
			object obj21 = !flag9;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj20 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v8+A0]");
			object obj22 = 0;
			obj4 = (UnityEngine.Object)obj22;
			bool flag10 = obj22 == null;
			obj8 = obj14;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v10 (UnityEngine.Object)+1C]");
				object obj23 = (nint)0 + (nint)1;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v10 (UnityEngine.Object)+18]");
				if ((nint)0 >= (nint)1)
				{
					IntPtr cachedPtr = obj4.m_CachedPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v10 (UnityEngine.Object)+18]");
					Array.Clear((Array)(nint)cachedPtr, 0, 0);
				}
				return;
			}
		}
		throw new NullReferenceException();
	}

	public MonsterSpawnButton()
	{
		//IL_001d: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B960]");
		radius = 0f;
		base._002Ector();
	}

	static MonsterSpawnButton()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDAF0]");
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
