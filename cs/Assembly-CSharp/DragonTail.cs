using System;
using Cpp2ILInjected;
using UnityEngine;

public class DragonTail : MonoBehaviour
{
	public Transform[] segments;

	public float swish;

	public float swishRate;

	public float fastBoost;

	public float drag;

	public float maxDrag;

	private Quaternion[] rest;

	private Vector3 lastPos;

	private Vector3 vel;

	private float phase;

	private bool started;

	private void Awake()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I4
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_00a0: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_0241: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_0180: Expected Obj, but got I
		//IL_01a4: Expected Obj, but got I4
		Transform[] array = segments;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F28]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 64;
		UnityEngine.Object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X20_v6-20]");
		Transform[] array2 = (Transform[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		object obj5 = 4;
		object obj6 = 0;
		UnityEngine.Object obj7 = obj3;
		while (true)
		{
			object obj8 = obj5 - 4;
			if ((nint)obj8 >= array2.Length)
			{
				return;
			}
			bool flag = (nint)obj8 < array2.Length;
			object obj9 = !flag;
			if (obj9 != null)
			{
				break;
			}
			object obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v7 (UnityEngine.Transform[])+v101 @ X23_v5*8]");
			bool flag3 = (UnityEngine.Object)0 != null;
			bool flag4 = !flag3;
			obj7 = null;
			if (!flag4)
			{
				Transform[] array3 = segments;
				bool flag5 = (nint)obj8 < array3.Length;
				object obj12 = !flag5;
				if (obj12 != null)
				{
					break;
				}
				Quaternion[] array4 = rest;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v11 (UnityEngine.Transform[])+v101 @ X23_v5*8]");
				Quaternion localRotation = ((Transform)0).localRotation;
				bool flag6 = (nint)obj8 < array4.Length;
				object obj13 = !flag6;
				if (obj13 != null)
				{
					break;
				}
				object obj14 = (object)array4 + obj6;
				obj7 = null;
			}
			array2 = segments;
			obj5++;
			obj6 += 16;
			bool flag7 = segments == null;
			object obj15 = !flag7;
			if (obj15 == null)
			{
				throw new NullReferenceException();
			}
		}
		throw new IndexOutOfRangeException();
	}

	private void OnEnable()
	{
		started = false;
	}

	private void LateUpdate()
	{
		//IL_0936: Invalid comparison between F4 and I4
		//IL_0947: Expected Obj, but got I4
		//IL_0950: Invalid comparison between F4 and I4
		//IL_0967: Unknown result type (might be due to invalid IL or missing references)
		//IL_096c: Expected Obj, but got Unknown
		//IL_0123: Expected VT, but got F4
		//IL_09a6: Expected Obj, but got I
		//IL_09be: Expected Obj, but got I
		//IL_09c6: Expected VT, but got Obj
		//IL_09d6: Expected Obj, but got I
		//IL_09eb: Expected VT, but got Obj
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_0c5e: Invalid comparison between F8 and I4
		//IL_0c6d: Invalid comparison between F8 and I4
		//IL_0c85: Expected Obj, but got F8
		//IL_0c92: Expected Obj, but got F8
		//IL_0cc7: Expected Obj, but got I4
		//IL_0ccf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd4: Expected Obj, but got Unknown
		//IL_015c: Expected Obj, but got I
		//IL_0a15: Invalid comparison between F8 and I4
		//IL_0a81: Expected VT, but got F4
		//IL_0a90: Expected VT, but got F4
		//IL_0cfb: Expected Obj, but got I
		//IL_0d25: Expected Obj, but got I4
		//IL_0191: Expected F8, but got I4
		//IL_0203: Invalid comparison between F4 and I4
		//IL_0212: Expected F8, but got I4
		//IL_026c: Expected VT, but got I4
		//IL_0364: Expected Obj, but got I8
		//IL_03aa: Expected Obj, but got I
		//IL_03ca: Expected Obj, but got I4
		//IL_03d3: Expected Obj, but got I4
		//IL_03f9: Expected VT, but got I4
		//IL_0419: Expected Obj, but got I4
		//IL_0460: Expected Obj, but got I4
		//IL_048f: Expected Obj, but got I
		//IL_04ad: Expected Obj, but got I4
		//IL_04b6: Expected VT, but got I4
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Expected Obj, but got Unknown
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected Obj, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected Obj, but got Unknown
		//IL_0538: Expected Obj, but got I4
		//IL_058a: Expected Obj, but got I4
		//IL_08bc: Expected VT, but got I4
		//IL_08bc: Expected Obj, but got I
		//IL_08c5: Expected VT, but got F8
		//IL_08ce: Expected VT, but got I4
		float deltaTime = Time.deltaTime;
		bool flag = deltaTime < 0f;
		object obj = !flag;
		bool flag2 = deltaTime == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		if (obj3 != null)
		{
			return;
		}
		Transform[] array = segments;
		float num;
		object obj4;
		float num3;
		Vector3 vector;
		object obj7;
		if (segments != null)
		{
			if (array.Length == 0)
			{
				return;
			}
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				object obj5 = default;
				object obj8;
				if (~(started ? 1u : 0u) == 0)
				{
					num = deltaTime - (float)lastPos;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (DragonTail)+50]");
					obj4 = obj5 - 0;
					float num2 = num * num;
					object obj6 = obj4 * obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
					num3 = num2 + (float)obj6;
					if (!((double)num3 > 25.0))
					{
						vector = vel;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (DragonTail)+5C]");
						obj7 = 0;
						object obj9 = default;
						obj8 = obj9;
						goto IL_0be2;
					}
				}
				lastPos = (Vector3)deltaTime;
				obj8 = obj5;
				num3 = deltaTime;
				num = deltaTime - deltaTime;
				obj4 = obj5 - obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj10 = 0;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v30+A0]");
				object obj12 = 0;
				vector = (Vector3)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v31+8]");
				obj7 = 0;
				started = true;
				vel = (Vector3)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v31+8]");
				_ = 0;
				goto IL_0be2;
			}
		}
		goto IL_090f;
		IL_0be2:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		float num4 = (float)obj4 / deltaTime;
		float num5 = deltaTime * -6f;
		float num6 = num / num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		double num7 = 1.0 - (double)num5;
		double num8 = num7 - 1.0;
		bool flag3 = num8 < 0.0;
		bool flag4 = num8 == 0.0;
		object obj13 = num7 ^ 1.0;
		object obj14 = num7 ^ num8;
		object obj15 = obj13 & obj14;
		bool flag5 = (nint)obj15 < 0;
		bool flag6 = flag3 == flag5;
		object obj16 = !flag6;
		object obj17 = obj16 | flag4;
		object obj18 = ~obj17;
		double num9 = ((obj18 != null) ? 1.0 : num7);
		float num10 = num6 - (float)vector;
		if (num7 < 0.0)
		{
			num9 = 0.0;
		}
		float num11 = num4 - (float)obj7;
		object obj19 = default;
		float num12 = num10 * (float)obj19;
		float num13 = num11 * (float)num9;
		float num14 = (float)vector + num12;
		float num15 = (float)obj7 + num13;
		lastPos = (Vector3)deltaTime;
		vel = (Vector3)num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj20 = 0;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X0_v14+E4]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num16 = num14 * num14;
		float num17 = num15 * num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		float num18 = num16 + num17;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num19 = num18 * 0.25f;
		bool flag8 = num19 < 0f;
		double num20 = 0.0;
		if (!flag8)
		{
			bool flag9 = !((double)num19 > 1.0);
			num20 = num19;
			if (!flag9)
			{
				num20 = 1.0;
			}
		}
		float num21 = deltaTime * swishRate;
		double num22 = num20 * (double)fastBoost;
		float num23 = num21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
		float num24 = num23 * 0f;
		double num25 = num22 + 1.0;
		float num26 = num24 + num24;
		float num27 = num26 * (float)num25;
		float num28 = phase + num27;
		phase = num28;
		Transform transform2 = base.transform;
		if ((object)transform2 != null)
		{
			Vector3 vector2 = transform2.InverseTransformDirection((Vector3)0);
			double num29 = maxDrag;
			float num30 = (float)vel * drag;
			double num31 = 0f - num30;
			double num32 = 0f - maxDrag;
			bool flag10 = num31 < num32;
			double num33 = num32;
			if (!flag10)
			{
				bool flag11 = !(num31 > (double)maxDrag);
				num33 = num31;
				if (!flag11)
				{
					num33 = maxDrag;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (DragonTail)+58]");
			float num34 = 0f * drag;
			double num35 = (double)num34 * 0.5;
			if (!(num35 < num32))
			{
				bool flag12 = !(num35 > num29);
				num32 = num35;
				if (!flag12)
				{
					num32 = num29;
				}
			}
			Transform[] array2 = segments;
			if (segments != null)
			{
				if (array2.Length < 1)
				{
					return;
				}
				object obj23 = array2.Length & 0xFFFFFFFFL;
				double num36 = num33 / (double)array2.Length;
				double num37 = num32 / (double)array2.Length;
				double num38 = num20 + 1.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj24 = 0;
				double num39 = num37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
				double num40 = num39 * 0.0;
				object obj25 = 0;
				object obj26 = 0;
				double num41 = num38;
				double num42 = 0.5;
				float num43 = (float)num31;
				Vector3 vector3 = (Vector3)0;
				Vector3 euler = default;
				while (true)
				{
					Transform[] array3 = segments;
					if (segments == null)
					{
						break;
					}
					bool flag13 = (nint)obj25 < array3.Length;
					object obj27 = !flag13;
					if (obj27 == null)
					{
						object obj28 = obj24;
						object obj29 = (object)segments + obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v20+E4]");
						bool flag14 = (nint)0 == 0;
						object obj30 = !flag14;
						if (obj30 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X8_v20+20]");
						bool flag15 = (UnityEngine.Object)0 == null;
						bool flag16 = !flag15;
						object obj31 = !flag16;
						vector3 = (Vector3)0;
						if (obj31 != null)
						{
							goto IL_08d3;
						}
						object obj32 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEC0]");
						object obj33 = obj32 * 0;
						float num44 = phase + (float)obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
						Transform[] array4 = segments;
						if (segments == null)
						{
							break;
						}
						bool flag17 = (nint)obj25 < array4.Length;
						object obj34 = !flag17;
						if (obj34 == null)
						{
							Quaternion[] array5 = rest;
							if (rest == null)
							{
								break;
							}
							bool flag18 = (nint)obj25 < array5.Length;
							object obj35 = !flag18;
							if (obj35 == null)
							{
								object obj36 = (object)segments + obj25;
								float num45 = swish * num44;
								double num46 = (double)obj25 + 1.0;
								object obj37 = (object)rest + obj26;
								double num47 = num38 * (double)num45;
								double num48 = num46 / (double)array2.Length;
								double num49 = num48 * num47;
								double num50 = num49 / (double)array2.Length;
								double num51 = num50 + num50;
								double num52 = num36 + num51;
								double num53 = num52;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
								double num54 = num53 * 0.0;
								Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X8_v23+20]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+2C]");
								double num55 = 0.0 * num29;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+20]");
								double num56 = 0.0 * num54;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+2C]");
								double num57 = 0.0 * num38;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+28]");
								float num58 = 0f * (float)num29;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+2C]");
								double num59 = 0.0 * num36;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+24]");
								double num60 = 0.0 * num29;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+2C]");
								double num61 = 0.0 * num54;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+20]");
								double num62 = 0.0 * num29;
								double num63 = num55 - num56;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+24]");
								double num64 = 0.0 * num36;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+20]");
								double num65 = 0.0 * num38;
								double num66 = num57 + (double)num58;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+20]");
								double num67 = 0.0 * num36;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+28]");
								float num68 = 0f * (float)num36;
								double num69 = num59 + num60;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+28]");
								float num70 = 0f * (float)num54;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+24]");
								double num71 = 0.0 * num54;
								double num72 = num61 + num62;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+24]");
								double num73 = 0.0 * num38;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v24+28]");
								float num74 = 0f * (float)num38;
								double num75 = num63 - num64;
								num42 = num67 + num66;
								num43 = num70 + (float)num69;
								double num76 = num73 + num72;
								num29 = num75 - (double)num74;
								num33 = num42 - num71;
								num41 = (double)num43 - num65;
								num37 = num76 - (double)num68;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X8_v23+20]");
								((Transform)0).localRotation = (Quaternion)0;
								euler = (Vector3)num40;
								vector3 = (Vector3)0;
								goto IL_08d3;
							}
						}
					}
					goto IL_091d;
					IL_08d3:
					obj25++;
					obj26 += 16;
					if (obj23 == obj25)
					{
						return;
					}
				}
			}
		}
		goto IL_090f;
		IL_090f:
		NullReferenceException ex = new NullReferenceException();
		goto IL_091d;
		IL_091d:
		throw new IndexOutOfRangeException();
	}

	public DragonTail()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_005a: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 32;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		maxDrag = 35f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E720]");
		swish = 0f;
		base._002Ector();
	}
}
