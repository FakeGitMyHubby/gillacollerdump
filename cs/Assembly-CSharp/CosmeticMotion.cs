using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class CosmeticMotion : MonoBehaviour
{
	[Serializable]
	public class Limb
	{
		public Transform bone;

		public Transform tip;

		public float stiffness;

		public float damping;

		public float sag;

		public float maxAngle;

		[NonSerialized]
		public Quaternion rest;

		[NonSerialized]
		public Vector3 at;

		[NonSerialized]
		public Vector3 vel;

		[NonSerialized]
		public Vector3 lastTip;

		public Limb()
		{
			//IL_0012: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107CB40]");
			stiffness = 0f;
			base._002Ector();
		}
	}

	public float spinPerMetre;

	public float maxSpin;

	public float idleSpin;

	public float spinDown;

	public float swayStiffness;

	public float swayDamping;

	public float swayPerAccel;

	public float maxSway;

	private readonly List<CosmeticWearer.Part> spins;

	private readonly List<CosmeticWearer.Part> sways;

	private Vector3 lastPos;

	private float spinAngle;

	private float spinSpeed;

	private bool started;

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0070: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I
		//IL_05e4: Expected Obj, but got I4
		//IL_0862: Expected Obj, but got I4
		//IL_0639: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I
		//IL_0181: Expected Obj, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_056b: Expected Obj, but got I
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected Obj, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_020f: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I
		//IL_029b: Expected Obj, but got I4
		//IL_02e5: Expected Obj, but got I
		//IL_02ee: Expected Obj, but got I4
		//IL_06a5: Expected Obj, but got I
		//IL_06ba: Expected Obj, but got I
		//IL_06cf: Expected Obj, but got I
		//IL_072c: Expected Obj, but got I
		//IL_0744: Expected Obj, but got I
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected Obj, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected Obj, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected Obj, but got Unknown
		//IL_07b9: Expected VT, but got I4
		//IL_07b9: Expected VT, but got I4
		//IL_07d7: Expected Obj, but got I4
		//IL_0336: Expected Obj, but got I
		//IL_0360: Expected Obj, but got I4
		//IL_0705: Expected Obj, but got I
		//IL_070e: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I
		//IL_0446: Expected I4, but got Obj
		//IL_0495: Expected Obj, but got I4
		//IL_03e2: Expected Obj, but got I4
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
		object obj2 = default;
		if (obj2 == null)
		{
			goto IL_0658;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3+18]");
		object obj3 = 0;
		object obj4 = this + 64;
		object obj5 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_059d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4810]");
		object value = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4818]");
		object value2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4808]");
		object obj6 = 0;
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		object obj8 = 0;
		int num = 17276928;
		object obj13 = default;
		object obj14 = default;
		object obj15 = default;
		UnityEngine.Object obj21 = default;
		object obj28 = default;
		object obj29 = default;
		object obj30 = default;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
			object obj9 = !flag;
			if (obj9 != null)
			{
				break;
			}
			object obj10 = obj2 + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v13+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v13+20]");
				string text = ((UnityEngine.Object)0).name;
				if (text != null)
				{
					bool flag2 = text.StartsWith((string)value);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v13+20]");
					string text2 = ((UnityEngine.Object)0).name;
					if (text2 != null)
					{
						bool flag3 = text2.StartsWith((string)value2);
						object obj11 = flag2 | flag3;
						object obj12 = obj11 & 1;
						bool flag4 = obj12 == null;
						obj13 = obj13;
						obj14 = obj14;
						if (flag4)
						{
							goto IL_055b;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						obj15._002Ector();
						if (obj15 != null)
						{
							object obj16 = obj15 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v13+20]");
							obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v13+20]");
							Quaternion localRotation = ((Transform)0).localRotation;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47F0]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
							object obj18 = 0;
							object obj19 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v21+E4]");
							bool flag5 = (nint)0 == 0;
							object obj20 = !flag5;
							if (obj20 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag6 = obj21 != null;
							bool flag7 = !flag6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
							object obj22 = 0;
							object obj23 = 0;
							if (!flag7)
							{
								if ((object)obj21 == null)
								{
									goto IL_0658;
								}
								Mesh sharedMesh = ((MeshFilter)obj21).sharedMesh;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
								object obj24 = 0;
								object obj25 = obj24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v41+E4]");
								bool flag8 = (nint)0 == 0;
								object obj26 = !flag8;
								UnityEngine.Object obj27 = sharedMesh;
								if (obj26 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj27 = sharedMesh;
								}
								bool flag9 = obj27 != null;
								bool flag10 = !flag9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
								obj22 = 0;
								obj23 = 0;
								if (!flag10)
								{
									Mesh sharedMesh2 = ((MeshFilter)obj21).sharedMesh;
									if ((object)sharedMesh2 == null)
									{
										goto IL_0658;
									}
									Bounds bounds = sharedMesh2.bounds;
									obj22 = obj28 + obj29;
									obj30 = obj29;
									obj23 = 0;
									obj8 = obj28;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v13+20]");
							Vector3 localPosition = ((Transform)0).localPosition;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v13+20]");
							Quaternion localRotation2 = ((Transform)0).localRotation;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v13+20]");
							Vector3 localScale = ((Transform)0).localScale;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
							object obj31 = 0;
							object obj32 = obj31;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v28+A0]");
							object obj33 = 0;
							object obj34 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v29+20]");
							object obj35 = obj34 * 0;
							object obj36 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v29+18]");
							object obj37 = obj36 * 0;
							object obj38 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v29+1C]");
							object obj39 = obj38 * 0;
							object obj40 = obj13 * obj35;
							object obj41 = obj8 * obj37;
							object obj42 = obj30 * obj39;
							Vector3 vector = (Quaternion)0 * (Vector3)0;
							bool flag11 = !flag2;
							object obj43 = !flag11;
							object obj44 = ~obj43;
							object obj45 = ((obj44 != null) ? obj5 : obj4);
							object obj46 = obj30 + obj30;
							object obj47 = obj8 + obj8;
							obj13 += obj13;
							List<System.__Canon> list = (List<System.__Canon>)obj45;
							if (obj45 != null)
							{
								System.__Canon[] items = list._items;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47F8]");
								object obj48 = 0;
								int version = list._version + 1;
								num = (int)obj48;
								list._version = version;
								if (list._items != null)
								{
									bool flag12 = list._size < items.Length;
									object obj49 = !flag12;
									if (obj49 == null)
									{
										object obj50 = list._items + list._size;
										num = list._size + 1;
										list._size = num;
										object obj51 = obj50 + 32;
										obj51 = obj15;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj52 = obj8;
										obj14 = obj13;
										obj30 = obj46;
										obj8 = obj47;
									}
									else
									{
										((List<System.__Canon>)obj45).AddWithResize((System.__Canon)obj15);
										object obj52 = obj8;
										obj14 = obj13;
										obj30 = obj46;
										obj8 = obj47;
									}
									goto IL_055b;
								}
							}
						}
					}
				}
			}
			goto IL_0658;
			IL_055b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3+18]");
			obj3 = 0;
			obj7++;
			object obj53 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3+18]");
			if ((nint)obj53 < 0)
			{
				continue;
			}
			goto IL_059d;
		}
		goto IL_0666;
		IL_059d:
		object obj54 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v7+18]");
			bool flag13 = (nint)0 == 0;
			object obj55 = !flag13;
			if (obj55 != null)
			{
				return;
			}
			object obj56 = obj5;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v10+18]");
				bool flag14 = (nint)0 == 0;
				object obj57 = !flag14;
				if (obj57 == null)
				{
					enabled = false;
				}
				return;
			}
		}
		goto IL_0658;
		IL_0658:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0666;
		IL_0666:
		throw new IndexOutOfRangeException();
	}

	private void OnEnable()
	{
		started = false;
	}

	private void LateUpdate()
	{
		//IL_1287: Invalid comparison between F4 and I4
		//IL_1298: Expected Obj, but got I4
		//IL_12a1: Invalid comparison between F4 and I4
		//IL_12b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bd: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected VT, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_016b: Expected VT, but got F4
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected VT, but got I4
		//IL_01b2: Expected Obj, but got I4
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected F4, but got Unknown
		//IL_1c19: Expected VT, but got Obj
		//IL_1358: Expected Obj, but got I
		//IL_1382: Expected Obj, but got I4
		//IL_1b4c: Expected Obj, but got I
		//IL_1b54: Expected VT, but got Obj
		//IL_1b66: Expected Obj, but got I4
		//IL_1b74: Expected Obj, but got I4
		//IL_1b75: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b86: Expected Obj, but got I4
		//IL_1b8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba0: Expected Obj, but got I4
		//IL_13b4: Invalid comparison between F8 and I4
		//IL_13c5: Expected Obj, but got I4
		//IL_1112: Expected Obj, but got I4
		//IL_1113: Unknown result type (might be due to invalid IL or missing references)
		//IL_1117: Unknown result type (might be due to invalid IL or missing references)
		//IL_1124: Expected Obj, but got I4
		//IL_1129: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c5b: Expected Obj, but got F8
		//IL_1c82: Invalid comparison between F8 and I4
		//IL_1c91: Expected F8, but got I4
		//IL_0234: Expected VT, but got F4
		//IL_1489: Invalid comparison between F4 and I4
		//IL_1498: Expected F4, but got I4
		//IL_12e3: Expected Obj, but got I
		//IL_12eb: Expected F4, but got Obj
		//IL_12fb: Expected F4, but got I
		//IL_1326: Expected VT, but got Obj
		//IL_1343: Expected F4, but got I
		//IL_14b0: Expected VT, but got F4
		//IL_14e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1510: Expected VT, but got I4
		//IL_03ba: Invalid comparison between F4 and I4
		//IL_03f7: Expected Obj, but got I
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected Obj, but got I
		//IL_0426: Expected Obj, but got I
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected F4, but got Unknown
		//IL_15b6: Expected VT, but got Obj
		//IL_03e2: Expected F4, but got I4
		//IL_1b06: Expected Obj, but got I
		//IL_1b0e: Expected VT, but got Obj
		//IL_1b26: Expected Obj, but got I4
		//IL_1b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got I4
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected F4, but got VT
		//IL_04ae: Expected F4, but got I
		//IL_04be: Expected F4, but got I
		//IL_1526: Expected I, but got Obj
		//IL_1536: Expected Obj, but got I
		//IL_1546: Expected F4, but got I
		//IL_157c: Expected Obj, but got I4
		//IL_157d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1581: Unknown result type (might be due to invalid IL or missing references)
		//IL_1589: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a0: Expected VT, but got I4
		//IL_0721: Expected VT, but got I4
		//IL_0731: Expected VT, but got I
		//IL_0749: Expected F4, but got I
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
		Transform transform = base.transform;
		bool flag3 = (object)transform == null;
		CosmeticWearer.Part part2 = default;
		CosmeticWearer.Part part = part2;
		Enumerator<, > val = (Enumerator<, >)0;
		double num2 = default;
		double num = num2;
		float num4 = default;
		float num3 = num4;
		float num5 = deltaTime;
		Vector3 vector = (Vector3)0;
		object obj4 = 109891584;
		Enumerator<, > val4 = default;
		object obj10;
		Transform transform2;
		Enumerator<, > val3;
		float num31;
		if (!flag3)
		{
			Vector3 position = transform.position;
			bool flag4 = (byte)(~(started ? 1u : 0u)) != 0;
			num = num2;
			num3 = num4;
			num5 = deltaTime;
			if (!flag4)
			{
				double num6 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CosmeticMotion)+58]");
				num = num6 - 0.0;
				float num7 = deltaTime - (float)lastPos;
				float num8 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CosmeticMotion)+54]");
				float num9 = num8 - 0f;
				float num10 = num7 * num7;
				float num11 = num9 * num9;
				float num12 = num10 + num11;
				num3 = (float)num * (float)num;
				float num13 = num12 + num3;
				bool flag5 = !((double)num13 > 1.0);
				num5 = 1f;
				if (flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					obj4 = 0;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1043 @ X0_v59+E4]");
					bool flag6 = (nint)0 == 0;
					object obj6 = !flag6;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					double num14 = idleSpin;
					double num15 = 1.0 / (double)deltaTime;
					double num16 = num15 * (double)spinPerMetre;
					bool flag7 = num16 < (double)idleSpin;
					double num17 = spinPerMetre;
					if (!flag7)
					{
						num17 = maxSpin;
						bool flag8 = !(num16 > (double)maxSpin);
						num14 = num16;
						if (!flag8)
						{
							num14 = maxSpin;
						}
					}
					float num18 = spinSpeed;
					double num19 = num14 - (double)spinSpeed;
					bool flag9 = num19 == 0.0;
					object obj7 = !flag9;
					bool flag10 = num14 > (double)spinSpeed;
					double num20 = 8.0;
					if (!flag10)
					{
						num20 = spinDown;
					}
					double num21 = num20 * (double)deltaTime;
					object obj8 = 0.0 - num21;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
					double num22 = 1.0 - (double)obj8;
					bool flag11 = num22 < 0.0;
					double num23 = 0.0;
					if (!flag11)
					{
						bool flag12 = !(num22 > 1.0);
						num23 = num22;
						if (!flag12)
						{
							num23 = 1.0;
						}
					}
					double num24 = num14 - (double)num18;
					double num25 = num24 * num23;
					num = (double)num18 + num25;
					float num26 = deltaTime * (float)num;
					spinSpeed = (float)num;
					float num27 = spinAngle + num26;
					float num28 = num27 / 1.13587E+09f;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					float num29 = num28 * 1.13587E+09f;
					num3 = num27 - num29;
					bool flag13 = num3 < 0f;
					num5 = 0f;
					if (!flag13)
					{
						bool flag14 = !(num3 > 1.13587E+09f);
						num5 = num3;
						if (!flag14)
						{
							num5 = 1.13587E+09f;
						}
					}
					lastPos = (Vector3)deltaTime;
					spinAngle = num5;
					bool flag15 = spins == null;
					part = part2;
					val = (Enumerator<, >)0;
					num13 = (float)num14;
					float num30 = (float)num2;
					num31 = num4;
					float num32 = deltaTime;
					vector = (Vector3)0;
					if (!flag15)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4838]");
						transform2 = (Transform)0;
						Enumerator<, > enumerator = ((List<System.__Canon>)(object)spins).GetEnumerator();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4828]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
						CosmeticWearer.Part part3 = (CosmeticWearer.Part)0;
						num13 = (float)num14;
						Enumerator<, > val2 = default;
						num5 = (float)val2;
						num30 = (float)num2;
						num31 = num4;
						num32 = deltaTime;
						Vector3 axis = default;
						while (true)
						{
							vector = (Vector3)obj9;
							if (val.MoveNext())
							{
								bool flag16 = part2 == null;
								part = null;
								obj10 = 0;
								val = val2;
								val3 = (Enumerator<, >)(ref val);
								if (flag16)
								{
									break;
								}
								num32 = (float)part2.rest;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-E8 (CosmeticWearer+Part)+20]");
								num13 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-E8 (CosmeticWearer+Part)+24]");
								num18 = 0f;
								num31 = spinAngle;
								nint num33 = (nint)part3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1753 @ X8_v70 (Il2CppClass<CosmeticWearer+Part>)+A0]");
								object obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1420 @ X8_v71+20]");
								num3 = 0f;
								Quaternion quaternion = Quaternion.Internal_AngleAxis(spinAngle, ref axis);
								bool flag17 = (object)part2.t == null;
								part = null;
								obj10 = 0;
								val = val2;
								val3 = (Enumerator<, >)(ref val);
								num5 = spinAngle;
								vector = (Vector3)0;
								if (!flag17)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-E8 (CosmeticWearer+Part)+24]");
									float num34 = 0f * num29;
									float num35 = (float)part2.rest * spinAngle;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-E8 (CosmeticWearer+Part)+24]");
									double num36 = 0.0 * num;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-E8 (CosmeticWearer+Part)+20]");
									float num37 = 0f * num29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-E8 (CosmeticWearer+Part)+24]");
									float num38 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1420 @ X8_v71+20]");
									float num39 = num38 * 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-E8 (CosmeticWearer+Part)+1C]");
									float num40 = 0f * num29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-E8 (CosmeticWearer+Part)+24]");
									float num41 = 0f * spinAngle;
									float num42 = (float)part2.rest * num29;
									float num43 = num34 - num35;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-E8 (CosmeticWearer+Part)+1C]");
									float num44 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1420 @ X8_v71+20]");
									float num45 = num44 * 0f;
									float num46 = (float)part2.rest * (float)num;
									double num47 = num36 + (double)num37;
									float num48 = (float)part2.rest;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1420 @ X8_v71+20]");
									float num49 = num48 * 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-E8 (CosmeticWearer+Part)+20]");
									float num50 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1420 @ X8_v71+20]");
									float num51 = num50 * 0f;
									float num52 = num39 + num40;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-E8 (CosmeticWearer+Part)+20]");
									float num53 = 0f * spinAngle;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-E8 (CosmeticWearer+Part)+1C]");
									float num54 = 0f * spinAngle;
									float num55 = num41 + num42;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-E8 (CosmeticWearer+Part)+1C]");
									double num56 = 0.0 * num;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-E8 (CosmeticWearer+Part)+20]");
									float num57 = 0f * (float)num;
									float num58 = num43 - num45;
									num28 = num49 + (float)num47;
									float num59 = num53 + num52;
									double num60 = num56 + (double)num55;
									num29 = num58 - num57;
									num = (double)num28 - (double)num54;
									float num61 = num59 - num46;
									num5 = (float)num60 - num51;
									part2.t.localRotation = (Quaternion)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1420 @ X8_v71+18]");
									axis = (Vector3)0;
									num3 = num61;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ stack_-E8 (CosmeticWearer+Part)+1C]");
									num30 = 0f;
									continue;
								}
								goto IL_1148;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4820]");
							object obj12 = 0;
							vector = (Vector3)obj12;
							val.Dispose();
							part = null;
							obj10 = 0;
							val = val2;
							val3 = (Enumerator<, >)(ref val);
							double num62 = num31;
							throw new OutOfMemoryException();
						}
						goto IL_113a;
					}
					goto IL_118e;
				}
			}
			lastPos = (Vector3)deltaTime;
			bool flag18 = sways == null;
			part = part2;
			val = (Enumerator<, >)0;
			num31 = num4;
			vector = (Vector3)0;
			obj4 = 109891584;
			if (!flag18)
			{
				Enumerator<, > enumerator2 = ((List<System.__Canon>)(object)sways).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4828]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				obj4 = 0;
				num5 = (float)val4;
				while (true)
				{
					vector = (Vector3)obj13;
					if (!val.MoveNext())
					{
						break;
					}
					Vector3 vector2 = Tip(part2);
					if (part2 != null)
					{
						part2.lastTip = (Vector3)num5;
						object obj14 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1224 @ X8_v31+A0]");
						object obj15 = 0;
						num5 = (float)obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ X8_v32+4]");
						num3 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
						part2.vel = (Vector3)obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ X8_v32+4]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ X8_v32+4]");
						float num29 = 0f;
						continue;
					}
					goto IL_10fb;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4820]");
				object obj16 = 0;
				vector = (Vector3)obj16;
				val.Dispose();
				CosmeticWearer.Part part3 = (CosmeticWearer.Part)7;
				part = null;
				obj10 = 0;
				val = val4;
				transform2 = (Transform)109891584;
				val3 = (Enumerator<, >)(ref val);
				num31 = num4;
				obj4 = 0;
				goto IL_11ab;
			}
		}
		goto IL_118e;
		IL_113a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1148;
		IL_1148:
		NullReferenceException ex2 = new NullReferenceException();
		NullReferenceException ex3 = new NullReferenceException();
		NullReferenceException ex4 = new NullReferenceException();
		NullReferenceException ex5 = new NullReferenceException();
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_118e;
		IL_10fb:
		NullReferenceException ex7 = new NullReferenceException();
		part = null;
		obj10 = 0;
		val = val4;
		transform2 = (Transform)109891584;
		val3 = (Enumerator<, >)(ref val);
		num31 = num4;
		goto IL_113a;
		IL_118e:
		NullReferenceException ex8 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_11ab;
		IL_11ab:
		throw new OutOfMemoryException();
	}

	private static Vector3 Tip(CosmeticWearer.Part p)
	{
		//IL_0093: Expected VT, but got Obj
		//IL_007c: Expected VT, but got I4
		if (p != null && (object)p.t != null)
		{
			Transform parent = p.t.parent;
			if ((object)parent != null)
			{
				return parent.TransformPoint((Vector3)0);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	public CosmeticMotion()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0074: Expected F4, but got I
		//IL_0086: Expected F4, but got I
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4840]");
		object obj = 0;
		maxSway = 30f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C318]");
		spinPerMetre = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E350]");
		spinDown = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj2 = this + 64;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list2 = default;
		list2._002Ector();
		object obj3 = this + 72;
		obj3 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
