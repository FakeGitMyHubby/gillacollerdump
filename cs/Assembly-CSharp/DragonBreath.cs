using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class DragonBreath : MonoBehaviour
{
	public ParticleSystem flames;

	public ParticleSystem embers;

	public ParticleSystem smoke;

	public Light glow;

	public AudioSource roar;

	public float from;

	public float flameRate;

	public float emberRate;

	public float smokeRate;

	public float glowIntensity;

	public float roarVolume;

	public float talkFire;

	private ApeFace face;

	private float fire;

	private bool mirror;

	private bool firstPerson;

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_06d4: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I4
		//IL_018d: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I4
		//IL_01e6: Expected Obj, but got I4
		//IL_022f: Expected Obj, but got I4
		//IL_03bc: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I4
		//IL_02fb: Expected Obj, but got I4
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected Obj, but got Unknown
		//IL_0340: Expected Obj, but got I4
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_044e: Expected Obj, but got I4
		//IL_0464: Expected Obj, but got I
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected Obj, but got Unknown
		//IL_02c3: Expected Obj, but got I4
		//IL_04a1: Expected I4, but got Obj
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected Obj, but got Unknown
		//IL_038f: Expected Obj, but got I4
		//IL_0502: Expected Obj, but got I8
		//IL_0512: Expected Obj, but got I
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected Obj, but got Unknown
		//IL_0529: Expected Obj, but got I4
		//IL_0533: Expected I4, but got Obj
		//IL_072e: Expected Obj, but got I4
		//IL_0562: Expected Obj, but got I4
		//IL_0591: Expected Obj, but got I
		//IL_05ad: Expected Obj, but got I4
		//IL_0645: Expected Obj, but got I
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected Obj, but got Unknown
		//IL_0627: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F00]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj5 = default;
		object obj6;
		if (obj5 != null)
		{
			if ((object)obj5 == null)
			{
				goto IL_068b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (UnityEngine.Object)+168]");
			obj6 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4888]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
			object obj8 = default;
			obj6 = obj8;
		}
		if ((object)this != null)
		{
			object obj9 = this + 104;
			obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			GameObject gameObject = base.gameObject;
			if ((object)gameObject != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F20]");
				object layerName = 0;
				int layer = gameObject.layer;
				int num = LayerMask.NameToLayer((string)layerName);
				object obj10 = layer - num;
				bool flag2 = obj10 == null;
				mirror = flag2;
				GameObject gameObject2 = base.gameObject;
				if ((object)gameObject2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F18]");
					object layerName2 = 0;
					int layer2 = gameObject2.layer;
					int num2 = LayerMask.NameToLayer((string)layerName2);
					object obj11 = layer2 - num2;
					bool flag3 = (firstPerson = obj11 == null);
					bool flag4 = (byte)(~(mirror ? 1u : 0u)) != 0;
					object obj12 = 0;
					bool flag5 = false;
					bool flag6 = flag3;
					if (!flag4)
					{
						object obj13 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v41+E4]");
						bool flag7 = (nint)0 == 0;
						object obj14 = !flag7;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag8 = glow != null;
						bool flag9 = !flag8;
						object obj15 = 0;
						bool flag10 = false;
						if (!flag9)
						{
							if ((object)glow == null)
							{
								goto IL_068b;
							}
							glow.enabled = false;
							obj15 = 0;
							flag10 = false;
						}
						object obj16 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v46+E4]");
						bool flag11 = (nint)0 == 0;
						object obj17 = !flag11;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag12 = roar != null;
						bool flag13 = !flag12;
						obj12 = 0;
						flag5 = false;
						if (!flag13)
						{
							if ((object)roar == null)
							{
								goto IL_068b;
							}
							roar.enabled = false;
							obj12 = 0;
							flag5 = false;
						}
						flag6 = firstPerson;
					}
					if (!flag6)
					{
						goto IL_067f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F10]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj19 = default;
					if (obj19 != null)
					{
						object obj20 = obj19 + 32;
						obj20 = flames;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj21 = obj19 + 40;
						obj21 = embers;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X21_v8-10]");
						bool flag14 = (nint)0 < (nint)2;
						object obj22 = !flag14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X21_v8-10]");
						object obj23 = -2;
						bool flag15 = obj23 == null;
						object obj24 = ~obj22;
						object obj25 = obj24 | flag15;
						if (obj25 == null)
						{
							flag5 = (byte)(int)smoke != 0;
							object obj26 = obj19 + 48;
							obj26 = smoke;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X21_v10-18]");
							if ((nint)0 < (nint)1)
							{
								goto IL_067f;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X21_v10-18]");
							object obj27 = 0 & 0xFFFFFFFFL;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F08]");
							object obj28 = 0;
							object obj29 = obj19 + 32;
							object obj30 = 0;
							bool flag16 = (byte)(int)smoke != 0;
							Renderer renderer = default;
							while (true)
							{
								bool flag17 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27);
								object obj31 = !flag17;
								if (obj31 != null)
								{
									break;
								}
								object obj32 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v33+E4]");
								bool flag18 = (nint)0 == 0;
								object obj33 = !flag18;
								if (obj33 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X25_v3+v91 @ X23_v4*8]");
								bool flag19 = (UnityEngine.Object)0 != null;
								bool flag20 = !flag19;
								obj12 = 0;
								flag5 = false;
								if (flag20)
								{
									goto IL_0635;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X25_v3+v91 @ X23_v4*8]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
									if ((object)renderer != null)
									{
										renderer.enabled = false;
										obj12 = 0;
										flag5 = false;
										goto IL_0635;
									}
								}
								goto IL_068b;
								IL_0635:
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v25+18]");
								obj27 = 0;
								obj30++;
								object obj34 = obj30;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v25+18]");
								bool flag21 = (nint)obj34 < 0;
								flag16 = flag5;
								if (flag21)
								{
									continue;
								}
								goto IL_067f;
							}
						}
						goto IL_0699;
					}
				}
			}
		}
		goto IL_068b;
		IL_0699:
		throw new IndexOutOfRangeException();
		IL_067f:
		Set(0f);
		return;
		IL_068b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0699;
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I4
		//IL_0221: Invalid comparison between F4 and I
		//IL_0230: Expected F8, but got I4
		//IL_0275: Invalid comparison between F4 and I4
		//IL_0284: Expected F8, but got I4
		//IL_02bb: Invalid comparison between F8 and I4
		//IL_02ca: Invalid comparison between F8 and I4
		//IL_02dd: Expected Obj, but got F8
		//IL_02ea: Expected Obj, but got F8
		//IL_031f: Expected Obj, but got I4
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_00df: Invalid comparison between F4 and I4
		//IL_00ee: Expected F8, but got I4
		//IL_035d: Invalid comparison between F8 and I4
		//IL_036c: Invalid comparison between F8 and I4
		//IL_0381: Expected Obj, but got F8
		//IL_038e: Expected Obj, but got F8
		//IL_03c3: Expected Obj, but got I4
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_0431: Invalid comparison between F8 and I4
		//IL_0444: Expected Obj, but got F8
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected Obj, but got Unknown
		//IL_0483: Expected Obj, but got I4
		//IL_04b3: Expected Obj, but got I4
		//IL_04cb: Invalid comparison between F8 and I4
		//IL_04ed: Expected Obj, but got I4
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
		float talk = default;
		float num;
		if (face != null)
		{
			float scream = face.Scream;
			talk = face.Talk;
			num = scream;
		}
		else
		{
			float num2 = Yours(out var _);
			num = num2;
		}
		float num3 = from;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
		bool flag2 = num3 == 0f;
		double num4 = 0.0;
		if (!flag2)
		{
			float num5 = num - from;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
			float num6 = 0f - from;
			float num7 = num5 / num6;
			bool flag3 = num7 < 0f;
			num4 = 0.0;
			if (!flag3)
			{
				bool flag4 = (double)num7 > 1.0;
				num4 = 1.0;
				if (!flag4)
				{
					num4 = num7;
				}
			}
		}
		float num8 = talk;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
		float num9 = num8 * 0f;
		float num10 = num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB24]");
		float num11 = num10 + 0f;
		bool flag5 = num11 < 0f;
		double num12 = 0.0;
		if (!flag5)
		{
			bool flag6 = !((double)num11 > 1.0);
			num12 = num11;
			if (!flag6)
			{
				num12 = 1.0;
			}
		}
		double num13 = (double)talkFire * num12;
		double num14 = num4 - num13;
		bool flag7 = num14 < 0.0;
		bool flag8 = num14 == 0.0;
		object obj4 = num4 ^ num13;
		object obj5 = num4 ^ num14;
		object obj6 = obj4 & obj5;
		bool flag9 = (nint)obj6 < 0;
		bool flag10 = flag7 == flag9;
		object obj7 = !flag8;
		object obj8 = flag10 & obj7;
		object obj9 = ~obj8;
		double num15 = ((obj9 != null) ? num13 : num4);
		double num16 = num15 - (double)fire;
		bool flag11 = num16 < 0.0;
		bool flag12 = num16 == 0.0;
		object obj10 = num15 ^ (double)fire;
		object obj11 = num15 ^ num16;
		object obj12 = obj10 & obj11;
		bool flag13 = (nint)obj12 < 0;
		bool flag14 = flag11 == flag13;
		object obj13 = !flag12;
		object obj14 = flag14 & obj13;
		object obj15 = ~obj14;
		double num17 = ((obj15 != null) ? 3.0 : 6.0);
		float deltaTime = Time.deltaTime;
		double num18 = num15 - (double)fire;
		float num19 = deltaTime * (float)num17;
		float num20 = deltaTime * (float)num17;
		float num21 = 0f - num20;
		bool flag15 = num18 < 0.0;
		object obj16 = num18 ^ num18;
		object obj17 = num18 & obj16;
		bool flag16 = (nint)obj17 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag17 = flag15 == flag16;
		object obj18 = !flag17;
		object obj19 = ~obj18;
		if (obj19 != null)
		{
			num21 = num19;
		}
		bool flag18 = num18 < (double)num19;
		object obj20 = !flag18;
		double num22 = num18 - (double)num19;
		bool flag19 = num22 == 0.0;
		float k = fire + num21;
		object obj21 = !flag19;
		object obj22 = obj20 & obj21;
		object obj23 = ~obj22;
		if (obj23 != null)
		{
			k = (float)num15;
		}
		fire = k;
		Set(k);
	}

	private unsafe static float Yours(out float talk)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02d7: Expected Obj, but got I4
		//IL_02fd: Expected Obj, but got I
		//IL_031f: Expected Obj, but got I4
		//IL_0387: Expected Obj, but got I
		//IL_0397: Expected Obj, but got I
		//IL_03b9: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_0088: Expected F8, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I4
		//IL_013b: Expected F8, but got I4
		//IL_0159: Expected Obj, but got I
		//IL_01a6: Invalid comparison between F4 and I4
		//IL_01b5: Expected F4, but got I4
		//IL_033a: Expected Ref, but got F4
		//IL_034a: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_023e: Invalid comparison between F8 and I4
		//IL_024d: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		ref float reference = ref *(float*)null;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X9_v1+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X9_v1+8]");
		bool flag4 = (UnityEngine.Object)0 == null;
		bool flag5 = !flag4;
		object obj11 = !flag5;
		double num = 0.0;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X9_v1+8]");
			if ((nint)0 != 0)
			{
				object obj12 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v13+E4]");
				bool flag6 = (nint)0 == 0;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v3 (UnityEngine.Object)+50]");
				bool flag7 = (UnityEngine.Object)0 == null;
				bool flag8 = !flag7;
				object obj14 = !flag8;
				num = 0.0;
				if (obj14 != null)
				{
					goto IL_032d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v3 (UnityEngine.Object)+50]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v3 (UnityEngine.Object)+50]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v11+3C]");
					float num2 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
					float num3 = num2 / 0f;
					bool flag9 = num3 < 0f;
					float num4 = 0f;
					if (!flag9)
					{
						bool flag10 = !((double)num3 > 1.0);
						num4 = num3;
						if (!flag10)
						{
							num4 = 1f;
						}
					}
					reference = ref *(float*)num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v3 (UnityEngine.Object)+50]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v3 (UnityEngine.Object)+50]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v12+3C]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC84]");
						object obj17 = num5 + 0;
						double num6 = (double)obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
						double num7 = num6 / 0.0;
						bool flag11 = num7 < 0.0;
						num = 0.0;
						if (!flag11)
						{
							bool flag12 = !(num7 > 1.0);
							num = num7;
							if (!flag12)
							{
								num = 1.0;
							}
						}
						goto IL_032d;
					}
				}
			}
			throw new NullReferenceException();
		}
		goto IL_032d;
		IL_032d:
		return (float)num;
	}

	private void Set(float k)
	{
		//IL_0010: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I4
		//IL_00e9: Invalid comparison between F4 and I4
		//IL_00f8: Invalid comparison between F4 and I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0120: Expected Obj, but got F4
		//IL_0155: Expected Obj, but got I4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected I4, but got Unknown
		//IL_01a8: Expected F4, but got I
		//IL_02c9: Invalid comparison between F4 and I
		//IL_0217: Expected Obj, but got I4
		//IL_0399: Invalid comparison between F4 and I
		//IL_0309: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		float rate = flameRate * k;
		Rate(flames, rate);
		float rate2 = emberRate * k;
		Rate(embers, rate2);
		float rate3 = smokeRate * k;
		Rate(smoke, rate3);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = glow != null;
		bool flag3 = !flag2;
		object obj4 = 0;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			bool flag4 = (byte)(~(mirror ? 1u : 0u)) != 0;
			object obj6 = !flag4;
			obj4 = 0;
			obj5 = null;
			if (obj6 == null)
			{
				float num = k;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				float num2 = num - 0f;
				bool flag5 = num2 < 0f;
				bool flag6 = num2 == 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				object obj7 = k ^ 0;
				object obj8 = k ^ num2;
				object obj9 = obj7 & obj8;
				bool flag7 = (nint)obj9 < 0;
				bool flag8 = flag5 == flag7;
				object obj10 = !flag6;
				bool flag9 = (byte)((flag8 & obj10) ? 1 : 0) != 0;
				glow.enabled = flag9;
				float time = Time.time;
				float x = time * 14f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				float num3 = Mathf.PerlinNoise(x, 0f);
				float num4 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				float num5 = num4 * 0f;
				float num6 = glowIntensity * k;
				float num7 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
				float num8 = num7 + 0f;
				rate3 = num6 * num8;
				glow.intensity = rate3;
				obj4 = 0;
				obj5 = null;
			}
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v12+E4]");
		bool flag10 = (nint)0 == 0;
		object obj12 = !flag10;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(roar != null))
		{
			return;
		}
		bool flag11 = (byte)(~(mirror ? 1u : 0u)) != 0;
		object obj13 = !flag11;
		if (obj13 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		if (k > 0f)
		{
			bool isPlaying = roar.isPlaying;
			bool flag12 = !isPlaying;
			object obj14 = !flag12;
			if (obj14 == null)
			{
				roar.Play();
			}
		}
		float volume = roarVolume * k;
		roar.volume = volume;
		float num9 = k;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		float num10 = num9 * 0f;
		float num11 = num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		float pitch = num11 + 0f;
		roar.pitch = pitch;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		if (!(k > 0f) && roar.isPlaying)
		{
			roar.Stop();
		}
	}

	private unsafe static void Rate(ParticleSystem ps, float rate)
	{
		//IL_0010: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0086: Expected VT, but got Ref
		//IL_0096: Invalid comparison between F4 and I
		//IL_00d4: Expected Obj, but got I4
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
		bool flag2 = ps == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		ParticleSystem.EmissionModule emission = ps.emission;
		ParticleSystem.MinMaxCurve minMaxCurve = rate;
		ParticleSystem.EmissionModule emissionModule = default;
		object obj5 = default;
		emissionModule.rateOverTime = (ParticleSystem.MinMaxCurve)(&obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		if (rate > 0f)
		{
			bool isPlaying = ps.isPlaying;
			bool flag4 = !isPlaying;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				ps.Play();
			}
		}
	}

	public DragonBreath()
	{
		//IL_0012: Expected F4, but got I
		//IL_0024: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D340]");
		from = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCA0]");
		glowIntensity = 0f;
		talkFire = 0.18f;
		base._002Ector();
	}
}
