using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.XR;

public class GillaBlast : MonoBehaviour
{
	public float killRadius;

	public float hurtRadius;

	public float throwRadius;

	public Vector2 throwSpeed;

	public float thingSpeed;

	public float monsterDamage;

	public float monsterRadius;

	public float monsterShove;

	public float feltRadius;

	public MeshRenderer voxels;

	public float voxelSeconds;

	public Light flash;

	public AnimationCurve flashCurve;

	public float flashDelay;

	public float flashSeconds;

	public float flashRange;

	public AudioSource boom;

	public AudioClip[] booms;

	public float lasts;

	public const int Solid = default(int);

	private const int Thrown = default(int);

	private float t;

	private float flashMax;

	private MaterialPropertyBlock block;

	private static readonly int AgeId;

	private static readonly int TurnId;

	private static readonly ProfilerMarker BlastMark;

	private const int ShownAtOnce = default(int);

	private const float ShownOver = default(float);

	private static int shownLately;

	private static float shownFrom;

	private const int HeadCrushWounds = default(int);

	private const int TrapWounds = default(int);

	public unsafe static void Go(GillaBlast prefab, Vector3 at, Vector3 seen)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05a6: Expected Obj, but got I4
		//IL_0705: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I4
		//IL_05c4: Expected Obj, but got I
		//IL_05eb: Invalid comparison between F4 and I
		//IL_0046: Expected VT, but got I4
		//IL_074c: Expected Obj, but got I4
		//IL_076a: Expected Obj, but got I
		//IL_0780: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I4
		//IL_0612: Expected Obj, but got I
		//IL_063a: Expected Obj, but got I
		//IL_064a: Expected Obj, but got I
		//IL_066a: Expected Obj, but got I
		//IL_0672: Expected F4, but got Obj
		//IL_0682: Expected F4, but got I
		//IL_0692: Expected F4, but got I
		//IL_06a2: Expected F4, but got I
		//IL_06c4: Expected Obj, but got I4
		//IL_012c: Expected Obj, but got I4
		//IL_0191: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I4
		//IL_0201: Expected Obj, but got I4
		//IL_026c: Expected Obj, but got I4
		//IL_032c: Expected Obj, but got I
		//IL_0356: Expected Obj, but got I4
		//IL_037d: Expected VT, but got I4
		//IL_0386: Expected Obj, but got I4
		//IL_02c4: Expected VT, but got Obj
		//IL_0398: Expected Obj, but got Ref
		//IL_03e6: Expected Obj, but got I4
		//IL_04f8: Expected Obj, but got I4
		//IL_0500: Expected VT, but got Obj
		//IL_03be: Expected I, but got Obj
		//IL_03c7: Expected VT, but got I4
		//IL_0576: Expected VT, but got Obj
		//IL_046d: Expected Obj, but got VT
		//IL_040e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+8]");
		Vector3 vector = default;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+8]");
			ProfilerUnsafeUtility.BeginSample((IntPtr)0);
			vector = (Vector3)0;
		}
		float time = Time.time;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v9+A0]");
		object obj7 = 0;
		float num = time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7+14]");
		float num2 = num - 0f;
		float num3 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		if (num3 > 0f)
		{
			num2 = Time.time;
			obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v9+A0]");
			object obj9 = 0;
			_ = 0;
			float num4 = num2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v9+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v11+10]");
		object obj12 = (nint)0 + (nint)1;
		float num6 = default;
		float num10 = default;
		string text;
		float num11;
		float num12 = default;
		float num13;
		float num15;
		float num16;
		float num17;
		object obj21;
		OutOfMemoryException ex;
		GillaBlast gillaBlast;
		if ((nint)obj12 > 5)
		{
			bool flag5 = (object)prefab == null;
			object obj13 = !flag5;
			float num5 = num6;
			float num7 = time;
			float num8 = num6;
			gillaBlast = prefab;
			float num9 = num10;
			if (obj13 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj15 = 0;
			object obj16 = obj14;
			object obj17 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v28+A0]");
			object obj18 = 0;
			float num4 = (float)obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v29+4]");
			float num8 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v29+8]");
			float num7 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v29+C]");
			float num9 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v43+E4]");
			bool flag6 = (nint)0 == 0;
			object obj19 = !flag6;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBC0]");
			object obj20 = 0;
			text = (string)obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDC9C");
			bool flag7 = (object)prefab == null;
			num11 = num12;
			num13 = num10;
			float num14 = num9;
			num15 = num7;
			num16 = num8;
			float num5 = num4;
			num17 = num6;
			obj21 = 0;
			ex = null;
			gillaBlast = (GillaBlast)109891584;
			if (flag7)
			{
				goto IL_0472;
			}
			string text2 = prefab.name;
			GillaBlast gillaBlast2 = default;
			bool flag8 = (object)gillaBlast2 == null;
			num11 = num12;
			num13 = num10;
			num14 = num9;
			num15 = num7;
			num16 = num8;
			num5 = num4;
			num17 = num6;
			obj21 = 0;
			ex = null;
			text = text2;
			gillaBlast = gillaBlast2;
			if (flag8)
			{
				goto IL_0480;
			}
			gillaBlast2.name = text2;
			num14 = num9;
			num12 = num7;
			num10 = num8;
			num5 = num4;
			vector = (Vector3)text2;
			gillaBlast = gillaBlast2;
		}
		gillaBlast.HitYou(vector);
		gillaBlast.HitDummies(vector);
		gillaBlast.HitMonsters(vector);
		gillaBlast.HitThings(vector);
		gillaBlast.Rumble(vector);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4F8]");
		object obj22 = 0;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X0_v37+E4]");
		bool flag9 = (nint)0 == 0;
		object obj24 = !flag9;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaDynamite.ChainFrom((Vector3)0);
		obj21 = 0;
		ex = null;
		goto IL_0390;
		IL_0472:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0480;
		IL_0480:
		NullReferenceException ex3 = new NullReferenceException();
		float num18 = default;
		float num19 = default;
		float num20 = default;
		if ((nint)text == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num18 = num11;
			num19 = num13;
			num12 = num15;
			num10 = num16;
			num20 = num17;
			obj21 = 1;
			vector = (Vector3)text;
		}
		else
		{
			if ((nint)text != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num18 = num11;
			num19 = num13;
			num12 = num15;
			num10 = num16;
			num20 = num17;
			object obj25 = default;
			ex = (OutOfMemoryException)obj25;
			vector = (Vector3)text;
		}
		goto IL_0390;
		IL_0390:
		object obj27 = default;
		object obj26 = (object)(&obj27);
		if (obj26 != null)
		{
			ProfilerUnsafeUtility.EndSample((IntPtr)obj26);
			vector = (Vector3)0;
		}
		bool flag10 = ex == null;
		object obj28 = !flag10;
		if (obj28 == null)
		{
			bool flag11 = obj21 == null;
			object obj29 = !flag11;
			OutOfMemoryException ex4 = ex;
			if (obj29 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex4 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		num11 = num18;
		num13 = num19;
		num15 = num12;
		num16 = num10;
		num17 = num20;
		text = (string)vector;
		goto IL_0472;
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0481: Expected Obj, but got I4
		//IL_004c: Expected F4, but got I4
		//IL_00cb: Expected Obj, but got I4
		//IL_0110: Expected VT, but got I4
		//IL_02a0: Expected Obj, but got I4
		//IL_0137: Expected Obj, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_018a: Expected Obj, but got I
		//IL_01b4: Expected Obj, but got I4
		//IL_0236: Expected Obj, but got I
		//IL_0260: Expected VT, but got I4
		//IL_0271: Expected VT, but got I4
		//IL_0364: Expected Obj, but got I4
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_03b7: Expected Obj, but got I
		//IL_03d4: Expected F4, but got I
		//IL_03d4: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = flash != null;
		bool flag3 = !flag2;
		float num = 0f;
		UnityEngine.Object obj4 = null;
		if (!flag3)
		{
			if ((object)flash == null)
			{
				goto IL_0442;
			}
			num = flash.intensity;
			obj4 = null;
		}
		object obj5 = obj;
		flashMax = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = voxels != null;
		bool flag6 = !flag5;
		Vector4 vector = (Vector4)0;
		int num2 = 0;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			object obj8 = this + 152;
			obj8 = materialPropertyBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			float value = UnityEngine.Random.value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v34+E4]");
			bool flag7 = (nint)0 == 0;
			object obj11 = !flag7;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (obj8 == null)
			{
				goto IL_0442;
			}
			float num3 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
			float num4 = num3 * 0f;
			float num5 = num4 + num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
			object obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v17+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v18+4]");
			num2 = 0;
			object obj14 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v18+4]");
			((MaterialPropertyBlock)obj14).SetVector(0, (Vector4)0);
			float num6 = default;
			num = num6;
			vector = (Vector4)0;
		}
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v16+E4]");
		bool flag8 = (nint)0 == 0;
		object obj16 = !flag8;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (boom != null)
		{
			AudioClip[] array = booms;
			if (booms != null && array.Length != 0)
			{
				int num7 = UnityEngine.Random.Range(0, array.Length);
				bool flag9 = num7 < array.Length;
				object obj17 = !flag9;
				if (obj17 == null)
				{
					if ((object)boom != null)
					{
						object obj18 = booms + num7;
						AudioSource audioSource = boom;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v11+20]");
						audioSource.clip = (AudioClip)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD44]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B004]");
						float pitch = UnityEngine.Random.Range(num8, 0f);
						if ((object)boom != null)
						{
							boom.pitch = pitch;
							if ((object)boom != null)
							{
								boom.Play();
								goto IL_043b;
							}
						}
					}
					goto IL_0442;
				}
				goto IL_0450;
			}
		}
		goto IL_043b;
		IL_043b:
		Update();
		return;
		IL_0442:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0450;
		IL_0450:
		throw new IndexOutOfRangeException();
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_057c: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I4
		//IL_01e8: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_0507: Expected Obj, but got I4
		//IL_0223: Invalid comparison between F4 and I4
		//IL_0234: Expected Obj, but got I4
		//IL_00a8: Invalid comparison between F4 and I4
		//IL_00cd: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I
		//IL_014b: Expected I4, but got Obj
		//IL_05a3: Expected Obj, but got I4
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected Obj, but got Unknown
		//IL_05b9: Expected F4, but got I4
		//IL_0268: Invalid comparison between F8 and I4
		//IL_0277: Invalid comparison between F8 and I4
		//IL_028f: Expected Obj, but got F8
		//IL_029c: Expected Obj, but got F8
		//IL_0174: Expected Obj, but got I4
		//IL_033f: Invalid comparison between F4 and I4
		//IL_034e: Invalid comparison between F4 and I4
		//IL_0366: Expected Obj, but got F8
		//IL_0373: Expected Obj, but got F4
		//IL_03a8: Expected Obj, but got I4
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_05d0: Invalid comparison between F4 and I4
		//IL_0419: Invalid comparison between F4 and I4
		//IL_0428: Invalid comparison between F4 and I4
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected Obj, but got Unknown
		//IL_0450: Expected Obj, but got F4
		//IL_0485: Expected Obj, but got I4
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected I4, but got Unknown
		//IL_04aa: Expected Obj, but got I4
		//IL_03f4: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		float deltaTime = Time.deltaTime;
		object obj2 = obj;
		float num = t + deltaTime;
		t = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = voxels != null;
		bool flag3 = !flag2;
		object obj4 = 0;
		MaterialPropertyBlock materialPropertyBlock = null;
		if (!flag3)
		{
			bool flag4 = block == null;
			obj4 = 0;
			materialPropertyBlock = null;
			if (!flag4)
			{
				float num2 = t - voxelSeconds;
				bool flag5 = num2 < 0f;
				voxels.enabled = flag5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v28+E4]");
				bool flag6 = (nint)0 == 0;
				object obj7 = !flag6;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj8 = obj5;
				num = t;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v12+A0]");
				object obj9 = 0;
				block.SetFloat((int)obj9, t);
				materialPropertyBlock = block;
				voxels.SetPropertyBlock(block);
				obj4 = 0;
			}
		}
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v10+E4]");
		bool flag7 = (nint)0 == 0;
		object obj11 = !flag7;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = flash != null;
		bool flag9 = !flag8;
		object obj12 = 0;
		if (!flag9)
		{
			float num3 = t - flashDelay;
			float num4 = num3 / flashSeconds;
			bool flag10 = num4 < 0f;
			object obj13 = !flag10;
			object obj14 = ~obj13;
			bool flag11;
			bool flag12;
			bool flag13;
			if (obj14 == null)
			{
				double num5 = (double)num4 - 1.0;
				flag11 = num5 < 0.0;
				flag12 = num5 == 0.0;
				object obj15 = (double)num4 ^ 1.0;
				object obj16 = (double)num4 ^ num5;
				object obj17 = obj15 & obj16;
				flag13 = (nint)obj17 < 0;
			}
			else
			{
				flag13 = false;
				flag12 = false;
				flag11 = false;
			}
			bool flag14 = flag11 == flag13;
			object obj18 = !flag12;
			object obj19 = flag14 & obj18;
			float num6 = 0f;
			if (obj19 == null)
			{
				float num7 = flashCurve.Evaluate(num4);
				num6 = num7;
			}
			float intensity = num6 * flashMax;
			flash.intensity = intensity;
			float num8 = num4 - 1f;
			bool flag15 = num8 < 0f;
			bool flag16 = num8 == 0f;
			object obj20 = (double)num4 ^ 1.0;
			object obj21 = num4 ^ num8;
			object obj22 = obj20 & obj21;
			bool flag17 = (nint)obj22 < 0;
			bool flag18 = flag15 == flag17;
			object obj23 = !flag16;
			object obj24 = flag18 & obj23;
			object obj25 = ~obj24;
			float num9 = ((obj25 != null) ? num4 : 1f);
			if (num4 < 0f)
			{
				num9 = 0f;
			}
			float range = num9 * flashRange;
			flash.range = range;
			float num10 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
			float num11 = num10 - 0f;
			bool flag19 = num11 < 0f;
			bool flag20 = num11 == 0f;
			float num12 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
			object obj26 = num12 ^ 0;
			object obj27 = num6 ^ num11;
			object obj28 = obj26 & obj27;
			bool flag21 = (nint)obj28 < 0;
			bool flag22 = flag19 == flag21;
			object obj29 = !flag20;
			bool flag23 = (byte)((flag22 & obj29) ? 1 : 0) != 0;
			flash.enabled = flag23;
			obj12 = 0;
		}
		if (!(t < lasts))
		{
			GameObject obj30 = gameObject;
			object obj31 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v8+E4]");
			bool flag24 = (nint)0 == 0;
			object obj32 = !flag24;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(obj30);
		}
	}

	private void HitYou(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_04cb: Expected Obj, but got I
		//IL_04f5: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I
		//IL_0513: Expected Obj, but got I
		//IL_0523: Expected Obj, but got I
		//IL_0543: Expected Obj, but got I
		//IL_0565: Expected Obj, but got I4
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected Obj, but got Unknown
		//IL_05ad: Expected Obj, but got I
		//IL_05cf: Expected Obj, but got I4
		//IL_08b8: Expected Obj, but got I
		//IL_08c1: Expected Obj, but got I4
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e3: Expected Obj, but got Unknown
		//IL_0607: Expected Obj, but got I
		//IL_0631: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I
		//IL_0181: Expected Obj, but got I4
		//IL_0663: Expected VT, but got I4
		//IL_0663: Expected VT, but got I8
		//IL_0677: Invalid comparison between F8 and I
		//IL_06cd: Expected Obj, but got I
		//IL_06dd: Expected Obj, but got I
		//IL_06ed: Expected F8, but got I
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_06a6: Expected Obj, but got I
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_095b: Expected Obj, but got Unknown
		//IL_0978: Expected Obj, but got I
		//IL_099a: Expected Obj, but got I4
		//IL_0749: Expected Obj, but got I4
		//IL_023f: Invalid comparison between F8 and I
		//IL_0292: Expected Obj, but got I
		//IL_076a: Invalid comparison between F8 and I4
		//IL_0779: Expected F8, but got I4
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected Obj, but got Unknown
		//IL_07bd: Expected F8, but got I
		//IL_07df: Expected Obj, but got I4
		//IL_0836: Expected Obj, but got I4
		//IL_02ed: Expected F8, but got I
		//IL_0321: Expected VT, but got I4
		//IL_0895: Expected VT, but got I4
		//IL_089e: Expected VT, but got I4
		//IL_037b: Expected VT, but got I4
		//IL_0384: Expected VT, but got I4
		//IL_0854: Expected Obj, but got I
		//IL_087e: Expected Obj, but got I4
		//IL_03c4: Expected I4, but got VT
		//IL_049d: Expected VT, but got I4
		//IL_04a6: Expected VT, but got I4
		//IL_0469: Expected VT, but got I4
		//IL_0472: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v3+A0]");
		object obj5 = 0;
		UnityEngine.Object obj6 = (UnityEngine.Object)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 == null;
		bool flag3 = !flag2;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			return;
		}
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X19_v2 (UnityEngine.Object)+20]");
		bool flag5 = (UnityEngine.Object)0 == null;
		bool flag6 = !flag5;
		object obj11 = !flag6;
		if (obj11 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X19_v2 (UnityEngine.Object)+20]");
		Vector3 position = ((Transform)0).position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj13 = 0;
		object obj14 = obj12;
		object obj15 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v10+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v16+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj18 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v11+24]");
		object obj20 = default;
		object obj19 = 0 * obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v11+2C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X19_v2 (UnityEngine.Object)+58]");
		object obj21 = num * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v20+E4]");
		bool flag8 = (nint)0 == 0;
		object obj22 = !flag8;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v20+A0]");
		object obj23 = 0;
		object obj24 = 109891584;
		object obj25 = obj19 * obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v15+C]");
		object obj26 = obj21 * 0;
		object obj28 = default;
		object obj27 = obj28 + obj26;
		object obj30 = default;
		object obj29 = obj30 + obj25;
		object obj31 = obj29 - obj30;
		object obj32 = obj27 - obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj33 = 0;
		object obj34 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v22+E4]");
		bool flag9 = (nint)0 == 0;
		object obj35 = !flag9;
		object obj36 = obj29;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj36 = obj29;
		}
		double num2 = (double)obj32 * (double)obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		if (num2 > (double)throwRadius)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj37 = 0;
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v24+E4]");
		bool flag10 = (nint)0 == 0;
		object obj39 = !flag10;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj36 = obj29;
		}
		QueryTriggerInteraction queryTriggerInteraction = default;
		bool flag11 = Physics.Linecast((Vector3)4294961403L, (Vector3)1, 0, queryTriggerInteraction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		double num3;
		object obj40;
		if (num2 > 0.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			num3 = (double)obj32 / num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			obj40 = obj31 / 0;
		}
		else
		{
			object obj41 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v45+A0]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v46+18]");
			obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v46+20]");
			num3 = 0.0;
		}
		object obj43 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v24+A0]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v25+18]");
		object obj46 = default;
		object obj45 = 0 * obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v25+20]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
		object obj47 = num4 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X24_v3+9A1]");
		bool flag12 = (nint)0 == 0;
		object obj48 = !flag12;
		if (obj48 == null)
		{
			_ = 1;
		}
		object obj49 = obj33;
		float num5 = (float)num2 / throwRadius;
		object obj50 = obj40 + obj45;
		double num6 = num3 + (double)obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v32+E4]");
		bool flag13 = (nint)0 == 0;
		object obj51 = !flag13;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num7 = num6 * num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		double num8 = 1.0 - (double)num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		object obj52;
		if (num7 > 0.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			obj52 = obj50 / 0;
		}
		else
		{
			object obj53 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v39+A0]");
			object obj54 = 0;
			obj52 = obj54;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D110");
		bool flag14 = num8 < 0.0;
		double num9 = 0.0;
		if (!flag14)
		{
			bool flag15 = !(num8 > 1.0);
			num9 = num8;
			if (!flag15)
			{
				num9 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBlast)+30]");
		object obj55 = 0 - throwSpeed;
		bool flag16 = !flag11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		double num10 = 0.0;
		object obj56 = obj13;
		double num11 = (double)obj55 * num9;
		object obj57 = !flag16;
		object obj58 = ~obj57;
		if (obj58 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			double num12 = 0.0;
		}
		else
		{
			double num12 = 1.0;
		}
		double num13 = (double)throwSpeed + num11;
		object obj59 = obj52 * obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X0_v34+E4]");
		bool flag17 = (nint)0 == 0;
		object obj60 = !flag17;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj61 = default;
		float num14 = (float)obj59 * (float)obj61;
		if (MonsterPlayer.IsMonster)
		{
			((KillCam)obj5).Shoved((Vector3)0);
			return;
		}
		if (flag11)
		{
			goto IL_088c;
		}
		num14 = killRadius;
		Vector3 vector;
		Vector3 vector2;
		if (num2 < (double)killRadius)
		{
			num10 = num2;
			vector = (Vector3)1;
			vector2 = (Vector3)6;
		}
		else
		{
			double num12 = hurtRadius;
			bool flag18 = !(num2 < (double)hurtRadius);
			num10 = num2;
			if (flag18)
			{
				goto IL_088c;
			}
			double num15 = (double)hurtRadius + (double)killRadius;
			double num16 = num15 * 0.5;
			if (num2 < num16)
			{
				num10 = num2;
				num12 = 0.5;
				num14 = (float)num16;
				vector = (Vector3)0;
				vector2 = (Vector3)2;
			}
			else
			{
				num10 = num2;
				num12 = 0.5;
				num14 = (float)num16;
				vector = (Vector3)0;
				vector2 = (Vector3)1;
			}
		}
		goto IL_0844;
		IL_0844:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
		object obj62 = 0;
		object obj63 = obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X0_v38+E4]");
		bool flag19 = (nint)0 == 0;
		object obj64 = !flag19;
		if (obj64 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Wound(vector2, vector, 0, (byte)queryTriggerInteraction != 0);
		((KillCam)obj5).Blasted(vector2, (int)vector, false);
		return;
		IL_088c:
		vector = (Vector3)0;
		vector2 = (Vector3)0;
		goto IL_0844;
	}

	public static void CrushYou(Vector3 from, Vector3 velocity)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I
		//IL_01e7: Expected Obj, but got I
		//IL_0207: Expected Obj, but got I
		//IL_0229: Expected Obj, but got I4
		//IL_025c: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I
		//IL_029b: Expected Obj, but got I4
		//IL_02b9: Expected Obj, but got I
		//IL_02c9: Expected Obj, but got I
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_031d: Expected Obj, but got I4
		//IL_0151: Expected VT, but got I4
		//IL_0151: Expected VT, but got I4
		//IL_0169: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+A0]");
		object obj5 = 0;
		UnityEngine.Object obj6 = (UnityEngine.Object)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 == null;
		bool flag3 = !flag2;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			return;
		}
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v2 (UnityEngine.Object)+20]");
		if (!((UnityEngine.Object)0 == null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v2 (UnityEngine.Object)+20]");
			Vector3 position = ((Transform)0).position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj12 = 0;
			object obj13 = obj11;
			object obj14 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v12+A0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v16+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v13+28]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v2 (UnityEngine.Object)+58]");
			object obj18 = num * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v13+2C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v2 (UnityEngine.Object)+58]");
			object obj19 = num2 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v20+E4]");
			bool flag6 = (nint)0 == 0;
			object obj20 = !flag6;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v20+A0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v17+C]");
			object obj23 = obj18 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v17+C]");
			object obj24 = obj19 * 0;
			object obj25 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v21+E4]");
			bool flag7 = (nint)0 == 0;
			object obj26 = !flag7;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool dies = default;
			Wound((Vector3)6, (Vector3)1, 0, dies);
			((KillCam)obj5).Blasted((Vector3)6, 1, false);
		}
	}

	public static void CrushDummy(GillaDummy d, Vector3 from, Vector3 velocity)
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I
		//IL_00db: Expected I, but got Obj
		//IL_010a: Expected Obj, but got I4
		//IL_0146: Expected VT, but got Obj
		//IL_0146: Expected VT, but got I4
		//IL_0170: Expected Obj, but got I4
		//IL_01bb: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBA0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBA8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj7 = 0;
		GillaWounds wounds = GillaWounds.On(d.tearing);
		Vector3 middle = d.Middle;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3> action = default;
		action._002Ector((object)d, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float size = default;
		Action<GoreSection, Vector3> put = default;
		PlaceWounds(wounds, (Vector3)6, (Vector3)action, 0, size, put);
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v14+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		byte b = NetworkApe.TornBit((ApePart)1);
		byte b2 = NetworkApe.TornBit((ApePart)2);
		Vector3 velocity2 = (Vector3)(b2 | b);
		d.Blasted(velocity2, 1, apart: false);
	}

	public static void HeadCrushYou(Vector3 head, Vector3 from)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_05ac: Expected Obj, but got I
		//IL_05d6: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I4
		//IL_060e: Expected Obj, but got I4
		//IL_06e8: Expected Obj, but got I
		//IL_06f8: Expected Obj, but got I
		//IL_071a: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I4
		//IL_0646: Expected Obj, but got I4
		//IL_0460: Expected Obj, but got I
		//IL_048a: Expected Obj, but got I4
		//IL_0177: Expected Obj, but got I4
		//IL_04c4: Expected Obj, but got I
		//IL_04ee: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I
		//IL_01c2: Expected Obj, but got I4
		//IL_0576: Expected VT, but got I
		//IL_06a5: Expected Obj, but got I4
		//IL_01ea: Expected Obj, but got I
		//IL_0738: Expected Obj, but got I
		//IL_0752: Expected Obj, but got I
		//IL_0760: Expected I, but got Obj
		//IL_0770: Expected Obj, but got I
		//IL_079a: Expected Obj, but got I4
		//IL_054d: Expected VT, but got Obj
		//IL_054d: Expected VT, but got I4
		//IL_021f: Expected Obj, but got I
		//IL_023f: Expected Obj, but got I4
		//IL_0272: Expected Obj, but got I4
		//IL_029f: Expected Obj, but got I8
		//IL_02b5: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I4
		//IL_02c7: Expected Obj, but got I4
		//IL_066d: Expected Obj, but got I4
		//IL_02e9: Expected Obj, but got I
		//IL_030b: Expected Obj, but got I4
		//IL_03be: Expected Obj, but got I
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_03eb: Expected Obj, but got I4
		//IL_03f9: Expected Obj, but got I4
		//IL_0392: Expected Obj, but got I4
		//IL_039b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v3+A0]");
		object obj5 = 0;
		UnityEngine.Object obj6 = (UnityEngine.Object)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj5 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj8;
		}
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v10+A0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X9_v2+8]");
		UnityEngine.Object obj15 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X9_v2+8]");
		bool flag5 = (UnityEngine.Object)0 != null;
		bool flag6 = !flag5;
		object obj17 = 0;
		UnityEngine.Object obj18 = null;
		UnityEngine.Object obj19 = null;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X9_v2+8]");
			if ((nint)0 != 0)
			{
				object obj20 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v52+E4]");
				bool flag7 = (nint)0 == 0;
				object obj21 = !flag7;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X21_v2 (UnityEngine.Object)+68]");
				bool flag8 = (UnityEngine.Object)0 != null;
				bool flag9 = !flag8;
				obj17 = 0;
				obj18 = null;
				obj19 = null;
				if (flag9)
				{
					goto IL_061c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X21_v2 (UnityEngine.Object)+68]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X21_v2 (UnityEngine.Object)+68]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v37+20]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v37+20]");
					bool flag10 = (nint)0 == 0;
					obj17 = 0;
					obj18 = null;
					if (!flag10)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X21_v11+18]");
						bool flag11 = (nint)0 < (nint)1;
						obj17 = 0;
						obj18 = null;
						if (!flag11)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X21_v11+18]");
							object obj24 = 0 & 0xFFFFFFFFL;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v37+20]");
							object obj25 = (nint)0 + (nint)32;
							object obj26 = 0;
							object obj27 = 0;
							UnityEngine.Object obj28 = null;
							while (true)
							{
								bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
								object obj29 = !flag12;
								if (obj29 != null)
								{
									break;
								}
								object obj30 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X24_v6+v291 @ X23_v7*8]");
								obj19 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v58+E4]");
								bool flag13 = (nint)0 == 0;
								object obj31 = !flag13;
								if (obj31 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if (obj19 != null)
								{
									if ((object)obj19 == null)
									{
										goto IL_0577;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X20_v6 (UnityEngine.Object)+28]");
									bool flag14 = (nint)0 == 0;
									object obj32 = !flag14;
									obj17 = 0;
									obj18 = null;
									if (obj32 != null)
									{
										goto IL_061c;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X21_v11+18]");
								obj24 = 0;
								obj26++;
								object obj33 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X21_v11+18]");
								bool flag15 = (nint)obj33 < 0;
								obj17 = 0;
								obj18 = null;
								obj27 = 0;
								obj28 = null;
								if (flag15)
								{
									continue;
								}
								goto IL_040c;
							}
							goto IL_0585;
						}
					}
					goto IL_040c;
				}
			}
			goto IL_0577;
		}
		goto IL_061c;
		IL_061c:
		object obj34 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v15+E4]");
		bool flag16 = (nint)0 == 0;
		object obj35 = !flag16;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
			object obj36 = 0;
			object obj37 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v25+E4]");
			bool flag17 = (nint)0 == 0;
			object obj38 = !flag17;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaWounds wounds = GillaWounds.On((Dismemberment)obj19);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj39 = 0;
			object obj40 = obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v23+E4]");
			bool flag18 = (nint)0 == 0;
			object obj41 = !flag18;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj42 = obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v31+E4]");
			bool flag19 = (nint)0 == 0;
			object obj43 = !flag19;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBA0]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBF0]");
			object obj45 = 0;
			Action<Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3> action = default;
			action._002Ector((object)null, (IntPtr)obj45);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
			object obj46 = 0;
			object obj47 = obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X0_v35+E4]");
			bool flag20 = (nint)0 == 0;
			object obj48 = !flag20;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float size = default;
			Action<GoreSection, Vector3> put = default;
			PlaceWounds(wounds, (Vector3)4, (Vector3)action, 0, size, put);
		}
		if (obj5 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X19_v2 (UnityEngine.Object)+80]");
			((KillCam)obj5).Blasted((Vector3)0, 0, false);
			return;
		}
		goto IL_0577;
		IL_0585:
		throw new IndexOutOfRangeException();
		IL_040c:
		obj19 = null;
		goto IL_061c;
		IL_0577:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0585;
	}

	public static void HeadCrushDummy(GillaDummy d, Vector3 head, Vector3 from)
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I4
		//IL_00be: Expected I, but got Obj
		//IL_00e8: Expected Obj, but got I4
		//IL_0124: Expected VT, but got Obj
		//IL_0124: Expected VT, but got I4
		//IL_0141: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBA0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBA8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaWounds wounds = GillaWounds.On(d.tearing);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3> action = default;
		action._002Ector((object)d, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float size = default;
		Action<GoreSection, Vector3> put = default;
		PlaceWounds(wounds, (Vector3)4, (Vector3)action, 0, size, put);
		d.Blasted((Vector3)0, 0, apart: false);
	}

	public static void TrapYou(Vector3 from)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0176: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I
		//IL_01be: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I4
		//IL_0243: Expected Obj, but got I
		//IL_0260: Expected Obj, but got I
		//IL_0282: Expected Obj, but got I4
		//IL_02c0: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got I
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_0324: Expected Obj, but got I4
		//IL_0151: Expected VT, but got I4
		//IL_0151: Expected VT, but got I4
		//IL_02af: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v3+A0]");
		object obj5 = 0;
		UnityEngine.Object obj6 = (UnityEngine.Object)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 == null;
		bool flag3 = !flag2;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			return;
		}
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X19_v2 (UnityEngine.Object)+20]");
		if (!((UnityEngine.Object)0 == null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X19_v2 (UnityEngine.Object)+20]");
			Vector3 position = ((Transform)0).position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj12 = 0;
			object obj13 = obj11;
			object obj14 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v10+A0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v16+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v11+28]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X19_v2 (UnityEngine.Object)+58]");
			object obj18 = num * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v11+2C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X19_v2 (UnityEngine.Object)+58]");
			object obj19 = num2 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v20+E4]");
			bool flag6 = (nint)0 == 0;
			object obj20 = !flag6;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v20+A0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v15+C]");
			object obj23 = obj18 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v15+C]");
			object obj24 = obj19 * 0;
			object obj25 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v21+E4]");
			bool flag7 = (nint)0 == 0;
			object obj26 = !flag7;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool dies = default;
			Wound((Vector3)3, (Vector3)0, 0, dies);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X19_v2 (UnityEngine.Object)+80]");
			((KillCam)obj5).Blasted((Vector3)0, 0, false);
		}
	}

	public static void TrapDummy(GillaDummy d, Vector3 from)
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I4
		//IL_00cb: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I4
		//IL_0136: Expected VT, but got Obj
		//IL_0136: Expected VT, but got I4
		//IL_0153: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBA0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBA8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaWounds wounds = GillaWounds.On(d.tearing);
		Vector3 middle = d.Middle;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3> action = default;
		action._002Ector((object)d, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float size = default;
		Action<GoreSection, Vector3> put = default;
		PlaceWounds(wounds, (Vector3)3, (Vector3)action, 0, size, put);
		d.Blasted((Vector3)0, 0, apart: false);
	}

	private static void Wound(Vector3 middle, Vector3 at, int many, bool dies)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04f4: Expected Obj, but got I4
		//IL_051a: Expected Obj, but got I
		//IL_053c: Expected Obj, but got I4
		//IL_0631: Expected Obj, but got I
		//IL_0641: Expected Obj, but got I
		//IL_0663: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_0574: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got I
		//IL_00e0: Invalid comparison between VT and I4
		//IL_0104: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I4
		//IL_05ac: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I8
		//IL_018c: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I4
		//IL_0307: Expected Obj, but got I4
		//IL_05d3: Expected Obj, but got I4
		//IL_0325: Expected Obj, but got I
		//IL_034f: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I4
		//IL_0389: Expected Obj, but got I
		//IL_03b3: Expected Obj, but got I4
		//IL_0278: Expected Obj, but got I
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_02a5: Expected Obj, but got I4
		//IL_02b3: Expected Obj, but got I4
		//IL_060b: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I4
		//IL_0255: Expected Obj, but got I4
		//IL_0681: Expected Obj, but got I
		//IL_0691: Expected Obj, but got I
		//IL_06ab: Expected Obj, but got I
		//IL_06b9: Expected I, but got Obj
		//IL_06c9: Expected Obj, but got I
		//IL_06f3: Expected Obj, but got I4
		//IL_0419: Expected Obj, but got I
		//IL_0419: Expected VT, but got Obj
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_0454: Expected Obj, but got I
		//IL_047e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X9_v1+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X9_v1+8]");
		bool flag4 = (UnityEngine.Object)0 != null;
		bool flag5 = !flag4;
		UnityEngine.Object obj11 = null;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X22_v3 (UnityEngine.Object)+68]");
			obj11 = (UnityEngine.Object)0;
		}
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v10+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj11 == null || middle < (object)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X21_v4 (UnityEngine.Object)+20]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X21_v4 (UnityEngine.Object)+20]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X22_v4+18]");
		bool flag7 = (nint)0 < (nint)1;
		object obj15 = 0;
		UnityEngine.Object obj16 = null;
		if (flag7)
		{
			goto IL_02c6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X22_v4+18]");
		object obj17 = 0 & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X21_v4 (UnityEngine.Object)+20]");
		object obj18 = (nint)0 + (nint)32;
		object obj19 = 0;
		object obj20 = 0;
		UnityEngine.Object obj21 = null;
		UnityEngine.Object obj24;
		while (true)
		{
			bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17);
			object obj22 = !flag8;
			if (obj22 == null)
			{
				object obj23 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X25_v4+v167 @ X24_v5*8]");
				obj24 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v50+E4]");
				bool flag9 = (nint)0 == 0;
				object obj25 = !flag9;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (obj24 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X21_v5 (UnityEngine.Object)+28]");
					bool flag10 = (nint)0 == 0;
					object obj26 = !flag10;
					obj15 = 0;
					obj16 = null;
					if (obj26 != null)
					{
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X22_v4+18]");
				obj17 = 0;
				obj19++;
				object obj27 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X22_v4+18]");
				bool flag11 = (nint)obj27 < 0;
				obj15 = 0;
				obj16 = null;
				obj20 = 0;
				obj21 = null;
				if (flag11)
				{
					continue;
				}
				goto IL_02c6;
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			throw new NullReferenceException();
		}
		goto IL_0582;
		IL_02c6:
		obj24 = null;
		goto IL_0582;
		IL_0582:
		object obj28 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X0_v15+E4]");
		bool flag12 = (nint)0 == 0;
		object obj29 = !flag12;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag13 = obj24 == null;
		bool flag14 = !flag13;
		object obj30 = !flag14;
		if (obj30 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj31 = 0;
		object obj32 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v19+E4]");
		bool flag15 = (nint)0 == 0;
		object obj33 = !flag15;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaWounds wounds = GillaWounds.On((Dismemberment)obj24);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj34 = 0;
		object obj35 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v15+E4]");
		bool flag16 = (nint)0 == 0;
		object obj36 = !flag16;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj37 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v26+E4]");
		bool flag17 = (nint)0 == 0;
		object obj38 = !flag17;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj37 = obj34;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v26+A0]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBA0]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBF0]");
		object obj41 = 0;
		Action<Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3> action = default;
		action._002Ector((object)null, (IntPtr)obj41);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
		object obj42 = 0;
		object obj43 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X0_v29+E4]");
		bool flag18 = (nint)0 == 0;
		object obj44 = !flag18;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float size = default;
		IntPtr intPtr = default;
		PlaceWounds(wounds, middle, (Vector3)action, 0, size, (Action<GoreSection, Vector3>)(nint)intPtr);
		object obj45 = at & 1;
		if (obj45 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj46 = 0;
			object obj47 = obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X0_v32+E4]");
			bool flag19 = (nint)0 == 0;
			object obj48 = !flag19;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			NetworkApe.TearYou((ApePart)1);
			NetworkApe.TearYou((ApePart)2);
		}
	}

	private unsafe static void PlaceWounds(GillaWounds wounds, Vector3 middle, Vector3 at, int many, float size, Action<GoreSection, Vector3> put)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04ff: Expected Obj, but got I4
		//IL_0583: Expected Obj, but got I
		//IL_05bc: Expected Obj, but got I4
		//IL_00b3: Invalid comparison between F4 and I
		//IL_0117: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I
		//IL_013f: Expected F4, but got I
		//IL_0147: Expected F4, but got Obj
		//IL_0157: Expected F4, but got I
		//IL_051b: Invalid comparison between VT and I4
		//IL_016a: Expected Obj, but got VT
		//IL_01c2: Expected Obj, but got I
		//IL_01ea: Expected F4, but got I
		//IL_01f3: Expected Obj, but got I4
		//IL_01fc: Expected VT, but got I4
		//IL_05f4: Expected Obj, but got I4
		//IL_02aa: Invalid comparison between F4 and I
		//IL_030e: Expected Obj, but got I
		//IL_0316: Expected F4, but got Obj
		//IL_0326: Expected F4, but got I
		//IL_061a: Expected Obj, but got I
		//IL_0637: Expected F4, but got I
		//IL_0637: Expected F4, but got I
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		//IL_042b: Expected VT, but got Ref
		//IL_042b: Expected VT, but got Ref
		//IL_044e: Expected VT, but got Ref
		//IL_0456: Expected Obj, but got Ref
		//IL_0541: Invalid comparison between Obj and VT
		//IL_0474: Expected VT, but got I
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected Obj, but got Unknown
		//IL_04a5: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (wounds == null)
		{
			return;
		}
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 - obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj7 = 0;
		object obj8 = obj7;
		float num2 = default;
		float num = num2 - size;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num3 = num * num;
		object obj10 = obj4 * obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		float num4 = (float)obj10 + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		float num5;
		float num7;
		float num8;
		if (num4 > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			num5 = (float)obj4 / num4;
			float num6 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			num7 = num6 / 0f;
			num8 = num7;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj11 = 0;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v33+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v34+8]");
			num5 = 0f;
			num8 = (float)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			num7 = 0f;
		}
		if (middle < (object)1)
		{
			return;
		}
		object obj14 = middle << 2;
		if ((nint)obj14 < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		float num10 = default;
		float num9 = num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
		float num11 = num9 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj15 = 0;
		float num12 = num10;
		float num13 = num11;
		float num14 = num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		float num15 = 0f;
		object obj16 = 0;
		Vector3 vector = (Vector3)0;
		UnityEngine.Object obj17 = null;
		object obj25 = default;
		object obj27 = default;
		UnityEngine.Object obj28 = default;
		float num39 = default;
		float num40 = default;
		float num41 = default;
		do
		{
			Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
			object obj18 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v15+E4]");
			bool flag3 = (nint)0 == 0;
			object obj19 = !flag3;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num16 = num13 * num7;
			float num17 = num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			float num18 = num17 * 0f;
			float num19 = num8 + num16;
			float num20 = num5 + num18;
			float num21 = num19 * num19;
			float num22 = num20 * num20;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			float num23 = num22 + num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			float num24;
			float num26;
			if (num23 > 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				num24 = num20 / num23;
				float num25 = num19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				num26 = num25 / 0f;
			}
			else
			{
				object obj20 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v28+A0]");
				object obj21 = 0;
				num26 = (float)obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v29+8]");
				num24 = 0f;
			}
			object obj22 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v24+A0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADCC]");
			nint num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			float num28 = UnityEngine.Random.Range(num27, 0f);
			float num29 = num24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADDC]");
			float num30 = num29 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v25+18]");
			object obj24 = 0 * obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v25+20]");
			float num31 = 0f * num28;
			float num32 = num26 * num11;
			float num33 = num30 * num10;
			object obj26 = obj24 * obj27;
			float num34 = num32 * (float)obj27;
			float num35 = num31 * num10;
			float num36 = (float)obj6 + num33;
			float num37 = size + num34;
			num15 = num36 + num35;
			num13 = num37 + (float)obj26;
			num12 = (float)obj6 - num15;
			float num38 = size - num13;
			bool flag4 = wounds.Hit((Vector3)(&obj28), num13, (Vector3)(&num39), out *(GoreSection*)null, out *(Vector3*)put);
			bool flag5 = !flag4;
			num14 = num40;
			vector = (Vector3)(&num39);
			obj17 = (UnityEngine.Object)(&obj28);
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X2 (UnityEngine.Vector3)+28]");
				vector = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [at @ X2 (UnityEngine.Vector3)+18] (should have been resolved before IL gen)");
				obj16++;
				num13 = num39;
				num14 = num41;
				num15 = 0f;
				obj17 = obj28;
			}
		}
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref middle) && 1 < (nint)obj14);
	}

	private void HitDummies(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_09a5: Expected Obj, but got I4
		//IL_0c62: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0044: Expected VT, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I8
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e9: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I4
		//IL_0102: Expected F8, but got I
		//IL_0c80: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I4
		//IL_01a4: Expected I, but got Obj
		//IL_01b5: Expected VT, but got I4
		//IL_09bd: Expected Obj, but got I4
		//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Expected Obj, but got Unknown
		//IL_01d4: Expected Obj, but got I
		//IL_01fc: Expected I, but got Obj
		//IL_020d: Expected VT, but got I4
		//IL_022c: Expected Obj, but got I
		//IL_0254: Expected I, but got Obj
		//IL_0265: Expected VT, but got I4
		//IL_029d: Expected Obj, but got I4
		//IL_02cc: Expected Obj, but got I
		//IL_02ea: Expected Obj, but got I4
		//IL_02ff: Expected I, but got Obj
		//IL_0310: Expected VT, but got I4
		//IL_032f: Expected Obj, but got I
		//IL_0a23: Expected Obj, but got I4
		//IL_03a4: Invalid comparison between Obj and F4
		//IL_03ba: Expected VT, but got F4
		//IL_03d0: Expected I, but got Obj
		//IL_03d9: Expected VT, but got I4
		//IL_0411: Expected Obj, but got I4
		//IL_044b: Expected VT, but got I4
		//IL_044b: Expected VT, but got I8
		//IL_0469: Expected Obj, but got I4
		//IL_0491: Expected VT, but got F4
		//IL_04af: Expected I, but got Obj
		//IL_04c0: Expected VT, but got I4
		//IL_05b6: Expected Obj, but got I
		//IL_0a67: Expected Obj, but got I
		//IL_0a77: Expected F4, but got I
		//IL_0a87: Expected F8, but got I
		//IL_0a97: Expected F8, but got I
		//IL_0aa7: Expected F4, but got I
		//IL_0ab7: Expected F8, but got I
		//IL_0532: Expected Obj, but got I
		//IL_0554: Expected Obj, but got I4
		//IL_0a4a: Expected Obj, but got I
		//IL_057b: Expected Obj, but got I4
		//IL_058b: Expected Obj, but got I
		//IL_0ae6: Expected Obj, but got I4
		//IL_0cb0: Expected Obj, but got I
		//IL_0ccd: Expected Obj, but got I
		//IL_0cea: Expected Obj, but got I
		//IL_0d7c: Invalid comparison between F4 and I
		//IL_062c: Expected Obj, but got I
		//IL_0634: Expected F4, but got Obj
		//IL_0644: Expected F8, but got I
		//IL_0654: Expected F8, but got I
		//IL_05d5: Expected Obj, but got I
		//IL_0afe: Invalid comparison between Obj and F4
		//IL_0681: Invalid comparison between Obj and F4
		//IL_070a: Expected VT, but got I4
		//IL_0662: Expected VT, but got I4
		//IL_0b3f: Expected Obj, but got I4
		//IL_06c7: Invalid comparison between Obj and F8
		//IL_0764: Expected Obj, but got I
		//IL_0778: Expected Obj, but got I
		//IL_0737: Expected VT, but got I4
		//IL_0797: Expected Obj, but got I
		//IL_07b0: Expected I, but got Obj
		//IL_07b0: Expected Obj, but got I
		//IL_07c0: Expected Obj, but got I
		//IL_07ea: Expected Obj, but got I4
		//IL_06f4: Expected VT, but got I4
		//IL_0825: Expected VT, but got Obj
		//IL_0835: Expected Obj, but got I
		//IL_085f: Expected Obj, but got I4
		//IL_08dc: Expected F8, but got I
		//IL_08ef: Invalid comparison between F8 and I4
		//IL_08fe: Expected F8, but got I4
		//IL_0b76: Invalid comparison between F4 and I4
		//IL_0b93: Invalid comparison between Obj and F4
		//IL_0960: Expected VT, but got I4
		//IL_0c13: Expected Obj, but got I
		//IL_0c23: Expected Obj, but got I
		//IL_0952: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB720]");
		object obj5 = 0;
		Vector3 vector = (Vector3)obj5;
		System.__Canon[] array = ((List<System.__Canon>)obj4).ToArray();
		if (array.Length < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj9 = 0;
		object obj10 = array.Length & 0xFFFFFFFFL;
		object obj11 = array + 32;
		double num2 = default;
		double num = num2;
		object obj12 = 0;
		object obj13 = 17276928;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		double num3 = 0.0;
		double num4 = default;
		double num10 = default;
		object obj24 = default;
		Action<Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3> action = default;
		Action<GoreSection, Vector3> put = default;
		while (true)
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
			object obj14 = !flag2;
			if (obj14 != null)
			{
				break;
			}
			object obj15 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X29_v4+v160 @ X27_v5*8]");
			UnityEngine.Object obj16 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X29_v4+v160 @ X27_v5*8]");
			bool flag4 = (UnityEngine.Object)0 == null;
			bool flag5 = !flag4;
			object obj18 = !flag5;
			num4 = num4;
			double num5 = num;
			nint num6 = unchecked((nint)null);
			double num7 = num3;
			vector = (Vector3)0;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X29_v4+v160 @ X27_v5*8]");
				bool alive = ((GillaDummy)0).Alive;
				bool flag6 = !alive;
				num4 = num4;
				num5 = num;
				num6 = unchecked((nint)null);
				num7 = num3;
				vector = (Vector3)0;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X29_v4+v160 @ X27_v5*8]");
					bool mine = ((GillaDummy)0).Mine;
					bool flag7 = !mine;
					num4 = num4;
					num5 = num;
					num6 = unchecked((nint)null);
					num7 = num3;
					vector = (Vector3)0;
					if (!flag7)
					{
						object obj19 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X0_v20+E4]");
						bool flag8 = (nint)0 == 0;
						object obj20 = !flag8;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X23_v5 (UnityEngine.Object)+80]");
						bool flag9 = (UnityEngine.Object)0 == null;
						bool flag10 = !flag9;
						object obj21 = !flag10;
						num4 = num4;
						num5 = num;
						num6 = unchecked((nint)null);
						num7 = num3;
						vector = (Vector3)0;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X29_v4+v160 @ X27_v5*8]");
							Vector3 middle = ((GillaDummy)0).Middle;
							object obj22 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X0_v27+E4]");
							bool flag11 = (nint)0 == 0;
							object obj23 = !flag11;
							if (obj23 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							double num8 = num4 - num4;
							float num9 = (float)num3 - (float)num10;
							double num11 = num - num2;
							num5 = num8 * num8;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							num7 = throwRadius;
							bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)throwRadius);
							num4 = num4;
							Vector2 vector2 = (Vector2)num9;
							float num12 = (float)num8;
							double num13 = num3;
							num6 = unchecked((nint)null);
							vector = (Vector3)0;
							if (!flag12)
							{
								object obj25 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X0_v29+E4]");
								bool flag13 = (nint)0 == 0;
								object obj26 = !flag13;
								if (obj26 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag14 = Physics.Linecast((Vector3)4294961403L, (Vector3)1, 0, (QueryTriggerInteraction)0);
								bool flag15 = !flag14;
								object obj27 = !flag15;
								double num14 = num4;
								double num15 = num;
								double num16 = num3;
								num4 = num4;
								vector2 = (Vector2)num9;
								num12 = (float)num8;
								num5 = num2;
								num13 = num3;
								num6 = unchecked((nint)null);
								num7 = num10;
								vector = (Vector3)1;
								if (obj27 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
									double num19;
									float num20;
									double num21;
									if ((nint)obj24 > 0)
									{
										float num17 = num9 / (float)obj24;
										double num18 = num11 / (double)obj24;
										num19 = num8 / (double)obj24;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
										obj13 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD9A0]");
										bool flag16 = (nint)0 == 0;
										object obj28 = !flag16;
										num20 = num17;
										num21 = num18;
										if (obj28 == null)
										{
											object obj29 = 109891584;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
											obj13 = 0;
											_ = 1;
											num20 = num17;
											num21 = num18;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
										obj13 = 0;
										object obj30 = obj13;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v48+A0]");
										object obj31 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v49+18]");
										float num17 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v49+1C]");
										double num18 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v49+20]");
										num19 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v49+18]");
										num20 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v49+1C]");
										num21 = 0.0;
									}
									object obj32 = obj13;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v21+A0]");
									object obj33 = 0;
									object obj34 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X0_v36+E4]");
									bool flag17 = (nint)0 == 0;
									object obj35 = !flag17;
									if (obj35 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
										obj13 = 0;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v22+18]");
									nint num22 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
									object obj36 = num22 * 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v22+1C]");
									nint num23 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
									object obj37 = num23 * 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v22+20]");
									nint num24 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
									object obj38 = num24 * 0;
									float num25 = num20 + (float)obj36;
									double num26 = num21 + (double)obj37;
									double num27 = num19 + (double)obj38;
									float num28 = num25 * num25;
									double num29 = num26 * num26;
									float num30 = num28 + (float)num29;
									double num31 = num27 * num27;
									float num32 = num30 + (float)num31;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
									double num34;
									double num35;
									if (num32 > 0f)
									{
										num12 = num25 / num32;
										double num33 = num26 / (double)num32;
										num34 = num27 / (double)num32;
										num35 = num33;
									}
									else
									{
										object obj39 = obj13;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v41+A0]");
										object obj40 = 0;
										num12 = (float)obj40;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X8_v42+8]");
										num34 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X8_v42+4]");
										num35 = 0.0;
									}
									Vector3 middle2;
									object obj41;
									if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)killRadius))
									{
										middle2 = (Vector3)6;
										obj41 = obj7;
										double num36 = num34;
									}
									else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)hurtRadius))
									{
										float num37 = killRadius + hurtRadius;
										double num36 = (double)num37 * 0.5;
										if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num36))
										{
											num26 = 0.5;
											middle2 = (Vector3)2;
											obj41 = obj7;
										}
										else
										{
											num26 = 0.5;
											middle2 = (Vector3)1;
											obj41 = obj7;
										}
									}
									else
									{
										middle2 = (Vector3)0;
										obj41 = obj7;
										double num36 = hurtRadius;
									}
									object obj42 = obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X0_v38+E4]");
									bool flag18 = (nint)0 == 0;
									object obj43 = !flag18;
									if (obj43 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X23_v5 (UnityEngine.Object)+80]");
									GillaWounds wounds = GillaWounds.On((Dismemberment)0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBA0]");
									object obj44 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBA8]");
									object obj45 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X29_v4+v160 @ X27_v5*8]");
									action._002Ector((object)0, (IntPtr)obj45);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
									object obj46 = 0;
									object obj47 = obj46;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X0_v44+E4]");
									bool flag19 = (nint)0 == 0;
									object obj48 = !flag19;
									if (obj48 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									PlaceWounds(wounds, middle2, (Vector3)action, 0, (float)num3, put);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
									object obj49 = 0;
									object obj50 = obj49;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X0_v47+E4]");
									bool flag20 = (nint)0 == 0;
									object obj51 = !flag20;
									if (obj51 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									float num38 = (float)obj24 / throwRadius;
									num13 = 1.0 - (double)num38;
									byte b = NetworkApe.TornBit((ApePart)1);
									byte b2 = NetworkApe.TornBit((ApePart)2);
									vector2 = throwSpeed;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaBlast)+30]");
									num11 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D110");
									bool flag21 = num13 < 0.0;
									double num39 = 0.0;
									if (!flag21)
									{
										bool flag22 = !(num13 > 1.0);
										num39 = num13;
										if (!flag22)
										{
											num39 = 1.0;
										}
									}
									double num40 = num11 - (double)vector2;
									float num41 = (float)obj24 - killRadius;
									bool flag23 = num41 < 0f;
									int num42 = b2 | b;
									vector = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)killRadius)) ? ((Vector3)0) : ((Vector3)num42));
									double num43 = num40 * num39;
									double num44 = (double)vector2 + num43;
									num7 = (double)num12 * num44;
									num5 = num35 * num44;
									num4 = num34 * num44;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X29_v4+v160 @ X27_v5*8]");
									((GillaDummy)0).Blasted(vector, flag23 ? ((byte)1) : ((byte)0), apart: false);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
									obj9 = 0;
									num14 = num4;
									num15 = num2;
									num16 = num34;
									num6 = (flag23 ? 1 : 0);
									obj7 = obj41;
								}
							}
						}
					}
				}
			}
			obj10 = array.Length;
			obj12++;
			bool flag24 = (nint)obj12 < array.Length;
			num = num5;
			num3 = num7;
			if (!flag24)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private unsafe void HitMonsters(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0e89: Expected Obj, but got I4
		//IL_0eaf: Expected Obj, but got I
		//IL_0ed1: Expected Obj, but got I4
		//IL_1247: Expected Obj, but got I
		//IL_1257: Expected Obj, but got I
		//IL_1279: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_007d: Expected VT, but got I4
		//IL_0eef: Expected Obj, but got I
		//IL_0f19: Expected Obj, but got I4
		//IL_1297: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I
		//IL_0311: Expected VT, but got Obj
		//IL_00ee: Expected Obj, but got I
		//IL_010a: Expected VT, but got I4
		//IL_0132: Expected Obj, but got I
		//IL_0352: Expected Obj, but got I
		//IL_0366: Expected Obj, but got I8
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected Obj, but got Unknown
		//IL_0394: Expected F4, but got I
		//IL_039d: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I
		//IL_1221: Expected Obj, but got I4
		//IL_02d3: Expected VT, but got I4
		//IL_03bb: Expected Obj, but got I
		//IL_03dd: Expected Obj, but got I4
		//IL_040c: Expected Obj, but got I
		//IL_042a: Expected Obj, but got I4
		//IL_044b: Expected VT, but got I4
		//IL_0454: Expected VT, but got I4
		//IL_0e05: Expected Obj, but got I4
		//IL_0e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e13: Expected Obj, but got Unknown
		//IL_0484: Expected Obj, but got I4
		//IL_04a5: Expected VT, but got I4
		//IL_04ae: Expected VT, but got I4
		//IL_01e0: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I
		//IL_022b: Expected VT, but got I4
		//IL_04cd: Expected Obj, but got I
		//IL_0f51: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I
		//IL_0568: Invalid comparison between F4 and I4
		//IL_0594: Expected VT, but got I4
		//IL_059d: Expected VT, but got I4
		//IL_0268: Expected Obj, but got I
		//IL_0670: Expected Obj, but got I
		//IL_069a: Expected Obj, but got I4
		//IL_02a2: Expected Obj, but got I
		//IL_06d7: Expected VT, but got I8
		//IL_06d7: Expected VT, but got Ref
		//IL_06fc: Expected VT, but got I4
		//IL_0709: Expected Obj, but got I8
		//IL_05e5: Invalid comparison between F4 and I4
		//IL_05f6: Expected Obj, but got I4
		//IL_05ff: Invalid comparison between F4 and I4
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected Obj, but got Unknown
		//IL_0649: Expected VT, but got I4
		//IL_0652: Expected VT, but got I4
		//IL_02b7: Expected Obj, but got I
		//IL_02c0: Expected VT, but got I4
		//IL_0f6f: Invalid comparison between F4 and I
		//IL_0aba: Expected Obj, but got I
		//IL_0735: Expected Obj, but got I
		//IL_0aea: Expected Obj, but got I4
		//IL_0afa: Expected F4, but got I
		//IL_0b1a: Expected F4, but got I
		//IL_0b2f: Expected F4, but got I
		//IL_0b4f: Expected F4, but got I
		//IL_0b58: Expected VT, but got I4
		//IL_07d9: Expected VT, but got Obj
		//IL_0760: Expected VT, but got I4
		//IL_0811: Expected Obj, but got I4
		//IL_0b88: Expected Obj, but got I4
		//IL_0884: Expected VT, but got I4
		//IL_0a1e: Expected Obj, but got I4
		//IL_0a68: Expected VT, but got I4
		//IL_089b: Invalid comparison between F4 and I4
		//IL_08aa: Expected F8, but got I4
		//IL_0aa4: Expected VT, but got I4
		//IL_0f96: Expected Obj, but got I
		//IL_0fc0: Expected Obj, but got I4
		//IL_12ac: Expected Obj, but got I
		//IL_12c5: Expected Obj, but got I
		//IL_12d5: Expected F4, but got I
		//IL_09ce: Expected VT, but got I4
		//IL_09ce: Expected VT, but got Obj
		//IL_09f7: Expected VT, but got I4
		//IL_1021: Expected Obj, but got I
		//IL_1067: Expected Obj, but got I
		//IL_107e: Expected F4, but got Obj
		//IL_1086: Invalid comparison between F4 and Obj
		//IL_1309: Expected Obj, but got I4
		//IL_0d1b: Invalid comparison between F4 and I
		//IL_0d74: Expected Obj, but got I
		//IL_0d8c: Expected Obj, but got I
		//IL_0d94: Expected F4, but got Obj
		//IL_0da4: Expected F4, but got I
		//IL_0db4: Expected F4, but got I
		//IL_10f4: Expected Obj, but got I4
		//IL_0ddb: Expected F8, but got I
		//IL_1172: Expected Obj, but got I4
		//IL_0df6: Expected F4, but got I4
		//IL_11c9: Expected VT, but got I4
		//IL_11c9: Expected Obj, but got I
		//IL_11e1: Expected F4, but got I
		//IL_1203: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X9_v1+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X9_v1+8]");
		bool flag4 = (UnityEngine.Object)0 != null;
		bool flag5 = !flag4;
		Vector3 vector = (Vector3)0;
		UnityEngine.Object obj11 = null;
		UnityEngine.Object obj12 = null;
		if (!flag5)
		{
			object obj13 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v84+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X21_v3 (UnityEngine.Object)+68]");
			bool flag7 = (UnityEngine.Object)0 != null;
			bool flag8 = !flag7;
			vector = (Vector3)0;
			obj11 = null;
			obj12 = null;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X21_v3 (UnityEngine.Object)+68]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v62+20]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v62+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v63+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v63+18]");
						if ((nint)0 == 0)
						{
							goto IL_0e4a;
						}
						object obj17 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v88+E4]");
						bool flag9 = (nint)0 == 0;
						object obj18 = !flag9;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v63+20]");
						bool flag10 = (UnityEngine.Object)0 != null;
						bool flag11 = !flag10;
						vector = (Vector3)0;
						obj11 = null;
						obj12 = null;
						if (!flag11)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X21_v3 (UnityEngine.Object)+68]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v64+20]");
							object obj20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v65+18]");
							if ((nint)0 == 0)
							{
								goto IL_0e4a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v65+20]");
							object obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v66+30]");
							obj12 = (UnityEngine.Object)0;
							vector = (Vector3)0;
							obj11 = null;
						}
						goto IL_0edf;
					}
				}
				vector = (Vector3)0;
				obj11 = null;
				obj12 = null;
			}
		}
		goto IL_0edf;
		IL_0edf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		object obj22 = 0;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v12+E4]");
		bool flag12 = (nint)0 == 0;
		object obj24 = !flag12;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj23 = obj22;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v12+A0]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBC8]");
		object obj26 = 0;
		Vector3 vector2 = (Vector3)obj26;
		System.__Canon[] array = ((List<System.__Canon>)obj25).ToArray();
		if (array.Length < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj27 = 0;
		object obj28 = array.Length & 0xFFFFFFFFL;
		object obj29 = array + 32;
		float num2 = default;
		float num = num2;
		float num4 = default;
		float num3 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		float num5 = 0f;
		object obj30 = 0;
		float num10 = default;
		float num14 = default;
		RaycastHit raycastHit = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		while (true)
		{
			bool flag13 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28);
			object obj31 = !flag13;
			if (obj31 != null)
			{
				break;
			}
			object obj32 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X24_v3+v285 @ X28_v4*8]");
			UnityEngine.Object obj33 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v17+E4]");
			bool flag14 = (nint)0 == 0;
			object obj34 = !flag14;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X24_v3+v285 @ X28_v4*8]");
			bool flag15 = (UnityEngine.Object)0 == null;
			bool flag16 = !flag15;
			object obj35 = !flag16;
			float num6 = num;
			float num7 = num3;
			float num8 = num5;
			vector = (Vector3)0;
			vector2 = (Vector3)0;
			float num18;
			bool flag26;
			float num20;
			float num21;
			float num22;
			float num23;
			float num25;
			float num26;
			float num27;
			int num24;
			float num12;
			float num11;
			float num9;
			double num16;
			float num17;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X25_v4 (UnityEngine.Object)+100]");
				bool flag17 = (nint)0 == 0;
				object obj36 = !flag17;
				num6 = num;
				num7 = num3;
				num8 = num5;
				vector = (Vector3)0;
				vector2 = (Vector3)0;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X24_v3+v285 @ X28_v4*8]");
					Vector3 middle = ((MonsterBrain)0).Middle;
					object obj37 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X0_v25+E4]");
					bool flag18 = (nint)0 == 0;
					object obj38 = !flag18;
					if (obj38 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					num9 = num5 - num10;
					num11 = num3 - num4;
					num12 = num - num2;
					num6 = num12 * num12;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					float num13 = num14 + num14;
					float num15 = num13 / monsterRadius;
					num8 = 2f - num15;
					bool flag19 = num8 < 0f;
					num7 = 2f;
					num16 = num3;
					num17 = num5;
					vector = (Vector3)0;
					vector2 = (Vector3)0;
					if (!flag19)
					{
						bool flag20 = (double)num8 > 1.0;
						num18 = 1f;
						if (!flag20)
						{
							bool flag21 = num8 < 0f;
							object obj39 = !flag21;
							bool flag22 = num8 == 0f;
							object obj40 = ~obj39;
							object obj41 = obj40 | flag22;
							num18 = num8;
							num7 = 2f;
							num16 = num3;
							num17 = num5;
							vector = (Vector3)0;
							vector2 = (Vector3)0;
							if (obj41 != null)
							{
								goto IL_0dfb;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
						object obj42 = 0;
						object obj43 = obj42;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X0_v27+E4]");
						bool flag23 = (nint)0 == 0;
						object obj44 = !flag23;
						if (obj44 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag24 = Physics.Linecast((Vector3)(&raycastHit), (Vector3)4294961403L, out *(RaycastHit*)1, 0, queryTriggerInteraction);
						bool flag25 = !flag24;
						flag26 = true;
						vector = (Vector3)1;
						Transform transform = (Transform)4294961403L;
						if (!flag25)
						{
							Transform transform2 = raycastHit.transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X24_v3+v285 @ X28_v4*8]");
							Transform transform3 = ((Component)0).transform;
							bool flag27 = transform2.IsChildOf(transform3);
							flag26 = flag27;
							vector = (Vector3)0;
							transform = transform3;
						}
						float num19 = num14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
						if (num19 > 0f)
						{
							num20 = num9 / num14;
							num21 = num11 / num14;
							num22 = num12 / num14;
							bool flag28 = !flag26;
							num23 = num20;
							num14 = num20;
							num11 = num21;
							num9 = num22;
							num8 = num20;
							vector2 = (Vector3)transform;
							if (!flag28)
							{
								goto IL_07e7;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X24_v3+v285 @ X28_v4*8]");
							Transform transform4 = ((Component)0).transform;
							Vector3 forward = transform4.forward;
							bool flag29 = !flag26;
							object obj45 = !flag29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
							num23 = 0f;
							num21 = num4;
							num22 = num2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
							num20 = 0f;
							transform = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
							num14 = 0f;
							num11 = num4;
							num9 = num2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
							num8 = 0f;
							vector2 = (Vector3)0;
							if (obj45 != null)
							{
								goto IL_07e7;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X25_v4 (UnityEngine.Object)+121]");
						bool flag30 = (nint)0 == 0;
						object obj46 = !flag30;
						num24 = 0;
						num25 = num;
						num26 = num3;
						num27 = num5;
						num6 = num2;
						num7 = num4;
						num16 = num3;
						num17 = num5;
						if (obj46 == null)
						{
							num25 = num;
							num26 = num3;
							num27 = num5;
							num6 = num2;
							num16 = 0.25;
							goto IL_129c;
						}
					}
				}
			}
			goto IL_0dfb;
			IL_129c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj47 = 0;
			object obj48 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v888 @ X8_v32+A0]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v33+20]");
			num12 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v33+18]");
			float num28 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v33+18]");
			float num29 = num28 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v33+1C]");
			float num30 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v33+1C]");
			float num31 = num30 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
			object obj50 = 0;
			object obj51 = obj50;
			float num32 = num29 + num31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v33+20]");
			float num33 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v33+20]");
			float num34 = num33 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X8_v37+A0]");
			object obj52 = 0;
			float num35 = num34 + num32;
			float num36 = (float)obj52;
			bool flag31 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num35) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj52);
			num17 = num14;
			if (!flag31)
			{
				float num37 = num14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v33+18]");
				float num38 = num37 * 0f;
				float num39 = num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v33+1C]");
				float num40 = num39 * 0f;
				float num41 = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v33+20]");
				num27 = num41 * 0f;
				float num42 = num38 + num40;
				float num43 = num27 + num42;
				float num44 = num43 / num35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v33+18]");
				num36 = 0f * num44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v33+1C]");
				num6 = 0f * num44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v33+20]");
				num35 = 0f * num44;
				num17 = num14 - num36;
				num11 -= num6;
				num9 -= num35;
			}
			object obj53 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ X0_v37+E4]");
			bool flag32 = (nint)0 == 0;
			object obj54 = !flag32;
			if (obj54 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float num45 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			float num46;
			float num47;
			float num48;
			if (num45 > 0f)
			{
				num46 = num17 / num6;
				num47 = num11 / num6;
				num48 = num9 / num6;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj55 = 0;
				object obj56 = obj55;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X8_v47+A0]");
				object obj57 = 0;
				num46 = (float)obj57;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X8_v48+4]");
				num47 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X8_v48+8]");
				num48 = 0f;
			}
			bool flag33 = !flag26;
			float num49 = num46 * monsterShove;
			float num50 = num47 * monsterShove;
			float num51 = num48 * monsterShove;
			object obj58 = !flag33;
			object obj59 = ~obj58;
			double num52;
			if (obj59 == null)
			{
				num52 = 1.0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				num52 = 0.0;
			}
			float num53 = num18 * monsterDamage;
			float num54 = num18 * num49;
			float num55 = num18 * num50;
			float num56 = num18 * num51;
			num8 = num53 * (float)num16;
			num7 = num54 * (float)num52;
			object obj60 = !flag33;
			object obj61 = ~obj60;
			if (obj61 == null)
			{
				float num57 = num18;
			}
			else
			{
				float num57 = 0f;
			}
			num6 = num55 * (float)num52;
			num27 = num56 * (float)num52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X24_v3+v285 @ X28_v4*8]");
			((MonsterBrain)0).Blasted(num8, (Vector3)0, vector, num7);
			double num58 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v33+18]");
			num14 = 0f;
			num24 = 0;
			num25 = num4;
			num26 = num10;
			vector2 = (Vector3)0;
			goto IL_0dfb;
			IL_0dfb:
			obj28 = array.Length;
			obj30++;
			bool flag34 = (nint)obj30 < array.Length;
			num = num6;
			num3 = num7;
			num5 = num8;
			if (!flag34)
			{
				return;
			}
			continue;
			IL_07e7:
			object obj62 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v57+E4]");
			bool flag35 = (nint)0 == 0;
			object obj63 = !flag35;
			if (obj63 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag36 = obj12 != null;
			bool flag37 = !flag36;
			num25 = num;
			num26 = num3;
			num27 = num5;
			num6 = num2;
			double num59 = num12;
			num7 = num4;
			vector2 = (Vector3)0;
			if (!flag37)
			{
				bool flag38 = num18 < 0f;
				num59 = 0.0;
				double num60 = num20;
				if (!flag38)
				{
					bool flag39 = !((double)num18 > 1.0);
					num59 = num18;
					num60 = 1.0;
					if (!flag39)
					{
						num59 = 1.0;
						num60 = 1.0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
				object obj64 = 0;
				object obj65 = obj64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X0_v62+E4]");
				bool flag40 = (nint)0 == 0;
				object obj66 = !flag40;
				if (obj66 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num61 = num23 * 0.25f;
				float num62 = num21 * 0.25f;
				double num63 = (double)num22 * 0.25;
				double num64 = num59 * 0.5;
				num20 = num5 - num61;
				num7 = num3 - num62;
				double num65 = (double)num - num63;
				double num66 = num64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				num58 = num66 + 0.0;
				Blood.Burst((Vector3)obj12, (Vector3)0, null, num20);
				num25 = num22;
				num26 = num21;
				num27 = num23;
				num6 = (float)num65;
				vector2 = (Vector3)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X25_v4 (UnityEngine.Object)+121]");
			bool flag41 = (nint)0 == 0;
			object obj67 = !flag41;
			num14 = num23;
			num24 = 0;
			num12 = (float)num59;
			num11 = num21;
			num9 = num22;
			num16 = num3;
			num17 = num5;
			num8 = num20;
			vector = (Vector3)0;
			if (obj67 != null)
			{
				goto IL_0dfb;
			}
			num14 = num23;
			num11 = num21;
			num9 = num22;
			num16 = 1.0;
			vector = (Vector3)0;
			goto IL_129c;
		}
		goto IL_0e4a;
		IL_0e4a:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private unsafe void HitThings(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_09ca: Expected Obj, but got I
		//IL_09ec: Expected Obj, but got I4
		//IL_0a0a: Expected Obj, but got I
		//IL_0a3e: Expected Obj, but got I4
		//IL_0101: Expected VT, but got I8
		//IL_009c: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I4
		//IL_019c: Expected F8, but got I
		//IL_01c3: Expected Obj, but got I4
		//IL_0cd7: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I
		//IL_0239: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got I4
		//IL_094d: Expected Obj, but got I4
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_095b: Expected Obj, but got Unknown
		//IL_02e1: Expected Obj, but got I4
		//IL_032a: Expected Obj, but got I4
		//IL_0372: Expected Obj, but got I4
		//IL_03b6: Expected I4, but got Obj
		//IL_03f4: Expected I4, but got Obj
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		//IL_0544: Expected F4, but got Obj
		//IL_0a5c: Expected Obj, but got I
		//IL_0a86: Expected Obj, but got I4
		//IL_0d44: Expected Obj, but got F4
		//IL_059f: Expected Obj, but got I4
		//IL_05dc: Expected VT, but got I8
		//IL_05dc: Expected VT, but got Ref
		//IL_05ff: Expected Obj, but got F4
		//IL_0625: Expected Obj, but got I8
		//IL_079a: Invalid comparison between F4 and I
		//IL_0806: Expected Obj, but got I
		//IL_067a: Expected Obj, but got I4
		//IL_04ac: Expected I4, but got I8
		//IL_0af1: Expected Obj, but got I
		//IL_0b01: Expected F4, but got I
		//IL_0b11: Expected F4, but got I
		//IL_07da: Expected Obj, but got I
		//IL_06c2: Expected Obj, but got I4
		//IL_0ab4: Expected Obj, but got I
		//IL_0ac4: Expected F4, but got I
		//IL_0ad4: Expected F4, but got I
		//IL_04ea: Expected Obj, but got I4
		//IL_0d99: Expected Obj, but got I4
		//IL_0b26: Expected Obj, but got I
		//IL_0b50: Expected Obj, but got I4
		//IL_0519: Expected Obj, but got I4
		//IL_08ba: Invalid comparison between F4 and I
		//IL_090e: Expected Obj, but got I
		//IL_0926: Expected Obj, but got I
		//IL_092e: Expected F4, but got Obj
		//IL_093e: Expected F4, but got I
		//IL_0bd5: Expected VT, but got I4
		//IL_0c5a: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBD0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBD8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<System.__Canon> hashSet = default;
		hashSet._002Ector();
		object obj5 = obj3;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v3+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj7 != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj9 = null;
		if (!flag3)
		{
			object obj10 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v54+A0]");
			object obj11 = 0;
			object obj12 = obj11;
			if (obj11 == null)
			{
				goto IL_0982;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v56+30]");
			obj9 = (UnityEngine.Object)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj13 = 0;
		float num = throwRadius;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num2 = default;
		Collider[] array = Physics.OverlapSphere((Vector3)4294965503L, num2, 1, (QueryTriggerInteraction)0);
		if (array == null)
		{
			goto IL_0982;
		}
		object obj16 = array.Length;
		if (array.Length < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBE8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBE0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		GillaItem gillaItem = null;
		object obj19 = 0;
		float num3 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		double num4 = 0.0;
		float num5 = num;
		double num7 = default;
		double num6 = num7;
		QueryTriggerInteraction queryTriggerInteraction = (QueryTriggerInteraction)0;
		GillaBlast gillaBlast = this;
		object obj20 = 109891584;
		object obj31 = default;
		GillaBlast gillaBlast2 = default;
		RaycastHit raycastHit = default;
		QueryTriggerInteraction queryTriggerInteraction2 = default;
		float num19 = default;
		object obj59 = default;
		object obj60 = default;
		object obj61 = default;
		while (true)
		{
			bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16);
			object obj21 = !flag5;
			if (obj21 != null)
			{
				break;
			}
			object obj22 = (object)array + obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v10+20]");
			Rigidbody attachedRigidbody;
			double num8;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v10+20]");
				attachedRigidbody = ((Collider)0).attachedRigidbody;
				object obj23 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v11+E4]");
				bool flag6 = (nint)0 == 0;
				object obj24 = !flag6;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag7 = attachedRigidbody == null;
				bool flag8 = !flag7;
				object obj25 = !flag8;
				num8 = num6;
				queryTriggerInteraction = (QueryTriggerInteraction)0;
				if (obj25 == null)
				{
					if ((object)attachedRigidbody == null)
					{
						goto IL_0982;
					}
					bool isKinematic = attachedRigidbody.isKinematic;
					bool flag9 = !isKinematic;
					object obj26 = !flag9;
					num8 = num6;
					queryTriggerInteraction = (QueryTriggerInteraction)0;
					if (obj26 == null)
					{
						object obj27 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X0_v22+E4]");
						bool flag10 = (nint)0 == 0;
						object obj28 = !flag10;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag11 = attachedRigidbody == obj9;
						bool flag12 = !flag11;
						object obj29 = !flag12;
						num8 = num6;
						queryTriggerInteraction = (QueryTriggerInteraction)0;
						if (obj29 == null)
						{
							if (hashSet == null)
							{
								goto IL_0982;
							}
							queryTriggerInteraction = (QueryTriggerInteraction)obj17;
							bool flag13 = hashSet.Add((System.__Canon)(object)attachedRigidbody);
							bool flag14 = !flag13;
							num8 = num6;
							if (!flag14)
							{
								queryTriggerInteraction = (QueryTriggerInteraction)obj18;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
								object obj30 = obj31 & 1;
								if (obj30 == null)
								{
									goto IL_052f;
								}
								if ((object)gillaItem == null)
								{
									goto IL_0982;
								}
								bool mine = gillaItem.Mine;
								bool flag15 = !mine;
								num8 = num6;
								if (!flag15)
								{
									if ((object)gillaItem == null)
									{
										goto IL_0982;
									}
									int num9 = (int)(gillaItem.Hand__BackingField & 0x80000000L);
									bool flag16 = num9 == 0;
									num8 = num6;
									if (!flag16)
									{
										bool flag17 = (byte)(~(gillaItem.Swallowed__BackingField ? 1u : 0u)) != 0;
										object obj32 = !flag17;
										num8 = num6;
										if (obj32 == null)
										{
											bool flag18 = (byte)(~(gillaItem.Gone__BackingField ? 1u : 0u)) != 0;
											object obj33 = !flag18;
											num8 = num6;
											if (obj33 == null)
											{
												goto IL_052f;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_0943;
			}
			goto IL_0982;
			IL_052f:
			Vector3 worldCenterOfMass = attachedRigidbody.worldCenterOfMass;
			float num10 = (float)gillaBlast2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj34 = 0;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X0_v34+E4]");
			bool flag19 = (nint)0 == 0;
			object obj36 = !flag19;
			num5 = (float)num4;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num10 = num3;
				num5 = (float)num4;
			}
			float num11 = (float)num6 - (float)num7;
			float num12 = num5 - num2;
			float num13 = num11 * num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			bool flag20 = num13 > gillaBlast.throwRadius;
			gillaBlast2 = (GillaBlast)num10;
			num = (float)num6;
			num3 = num13;
			num4 = gillaBlast.throwRadius;
			num8 = num6;
			if (!flag20)
			{
				Vector3 worldCenterOfMass2 = attachedRigidbody.worldCenterOfMass;
				object obj37 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X0_v38+E4]");
				bool flag21 = (nint)0 == 0;
				object obj38 = !flag21;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag22 = Physics.Linecast((Vector3)(&raycastHit), (Vector3)4294961403L, out *(RaycastHit*)1, 0, queryTriggerInteraction2);
				bool flag23 = !flag22;
				object obj39 = obj13;
				GillaBlast gillaBlast3 = (GillaBlast)num10;
				object obj40 = obj18;
				object obj41 = obj17;
				QueryTriggerInteraction queryTriggerInteraction3 = (QueryTriggerInteraction)1;
				UnityEngine.Object obj42 = (UnityEngine.Object)4294961403L;
				GillaBlast gillaBlast4 = gillaBlast;
				object obj43 = obj20;
				float num17;
				float num18;
				int num14;
				float num15;
				double num16;
				if (!flag23)
				{
					Rigidbody rigidbody = raycastHit.rigidbody;
					object obj44 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v48+E4]");
					bool flag24 = (nint)0 == 0;
					object obj45 = !flag24;
					if (obj45 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag25 = rigidbody != attachedRigidbody;
					bool flag26 = !flag25;
					object obj46 = !flag26;
					obj39 = obj13;
					gillaBlast3 = gillaBlast;
					obj40 = obj18;
					obj41 = obj17;
					queryTriggerInteraction3 = (QueryTriggerInteraction)0;
					obj42 = attachedRigidbody;
					gillaBlast4 = gillaBlast;
					obj43 = obj20;
					num14 = 0;
					num15 = (float)num6;
					num16 = num13;
					num17 = (float)num6;
					num18 = num13;
					gillaBlast2 = gillaBlast;
					num = gillaBlast.throwRadius;
					num3 = num19;
					num4 = num2;
					num5 = gillaBlast.throwRadius;
					num8 = num7;
					queryTriggerInteraction = (QueryTriggerInteraction)0;
					if (obj46 != null)
					{
						goto IL_0943;
					}
				}
				num = gillaBlast4.throwRadius;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				object obj47;
				if (num13 > 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					num17 = num11 / num13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					obj47 = 0;
					float num20 = num12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
					num18 = num20 / 0f;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					obj47 = 0;
					object obj48 = obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v42+A0]");
					object obj49 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v43+18]");
					num18 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v43+20]");
					num17 = 0f;
				}
				object obj50 = obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v24+A0]");
				object obj51 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v25+20]");
				num12 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v25+18]");
				num11 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X23_v7+9A1]");
				bool flag27 = (nint)0 == 0;
				object obj52 = !flag27;
				if (obj52 == null)
				{
					_ = 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj53 = 0;
				object obj54 = obj53;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X0_v46+E4]");
				bool flag28 = (nint)0 == 0;
				object obj55 = !flag28;
				if (obj55 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num21 = num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				float num22 = num21 * 0f;
				float num23 = num11 * num19;
				float num24 = num17 + num22;
				float num25 = num18 + num23;
				float num26 = num24 * num24;
				float num27 = num25 * num25;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				float num28 = num27 + num26;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				float num29;
				float num30;
				if (num28 > 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					num29 = num24 / num28;
					num30 = num25 / num26;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj56 = 0;
					object obj57 = obj56;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v35+A0]");
					object obj58 = 0;
					num30 = (float)obj58;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X8_v36+8]");
					num29 = 0f;
				}
				float num31 = num13 / num;
				float num32 = num30 * (float)obj59;
				float num33 = num29 * gillaBlast4.thingSpeed;
				double num34 = 1.0 - (double)num31;
				float num35 = num32 * (float)obj60;
				double num36 = num34 * (double)num33;
				attachedRigidbody.AddForce((Vector3)2, (ForceMode)0);
				Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
				float num37 = num35 * 12f;
				double num38 = (double)obj61 * 12.0;
				double num39 = num36 * 12.0;
				num4 = num34 * (double)num37;
				num3 = (float)num34 * (float)num38;
				num8 = num34 * num39;
				attachedRigidbody.AddTorque((Vector3)2, (ForceMode)0);
				obj13 = obj39;
				num14 = 0;
				num15 = (float)num6;
				num16 = 1.0;
				gillaBlast2 = gillaBlast3;
				obj18 = obj40;
				obj17 = obj41;
				num5 = (float)num34;
				queryTriggerInteraction = (QueryTriggerInteraction)0;
				gillaBlast = gillaBlast4;
				obj20 = obj43;
			}
			goto IL_0943;
			IL_0943:
			obj16 = array.Length;
			obj19++;
			bool flag29 = (nint)obj19 < array.Length;
			num6 = num8;
			if (!flag29)
			{
				return;
			}
		}
		goto IL_0990;
		IL_0982:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0990;
		IL_0990:
		throw new IndexOutOfRangeException();
	}

	private void Rumble(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0486: Expected Obj, but got I
		//IL_04b0: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I
		//IL_04ce: Expected Obj, but got I
		//IL_04f8: Expected Obj, but got I4
		//IL_01b8: Invalid comparison between F8 and I4
		//IL_01c9: Expected Obj, but got I4
		//IL_01d2: Invalid comparison between F8 and I4
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_020c: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I8
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_02db: Invalid comparison between F8 and I4
		//IL_02ea: Invalid comparison between F8 and I4
		//IL_0302: Expected Obj, but got F8
		//IL_030f: Expected Obj, but got F8
		//IL_0344: Expected Obj, but got I4
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_0565: Invalid comparison between F8 and I4
		//IL_0585: Invalid comparison between F8 and I4
		//IL_03cd: Expected Obj, but got I4
		//IL_05b5: Expected Obj, but got I4
		//IL_03af: Expected Obj, but got I4
		//IL_03bf: Expected F8, but got I
		//IL_041e: Expected Obj, but got I
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3+A0]");
		object obj5 = 0;
		UnityEngine.Object obj6 = (UnityEngine.Object)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 == null;
		bool flag3 = !flag2;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			return;
		}
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X20_v3 (UnityEngine.Object)+20]");
		bool flag5 = (UnityEngine.Object)0 == null;
		bool flag6 = !flag5;
		object obj11 = !flag6;
		if (obj11 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X20_v3 (UnityEngine.Object)+20]");
		Vector3 position = ((Transform)0).position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj12 = 0;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v16+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj16 = default;
		object obj15 = obj16 - obj16;
		object obj18 = default;
		object obj17 = obj18 - obj18;
		object obj20 = default;
		object obj19 = obj20 - obj20;
		object obj21 = obj15 * obj15;
		object obj22 = obj17 * obj17;
		object obj23 = obj19 * obj19;
		object obj24 = obj21 + obj22;
		object obj25 = obj23 + obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num = (float)obj25 / feltRadius;
		double num2 = 1.0 - (double)num;
		bool flag8 = num2 < 0.0;
		object obj26 = !flag8;
		bool flag9 = num2 == 0.0;
		object obj27 = ~obj26;
		object obj28 = obj27 | flag9;
		if (obj28 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB98]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v19+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v19+18]");
			bool flag10 = (nint)0 == 1;
			_ = 4;
			if (!flag10)
			{
				_ = 5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v19+18]");
				if ((nint)0 < (nint)1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v19+18]");
				object obj30 = 0 & 0xFFFFFFFFL;
				object obj32 = default;
				object obj31 = obj32 + 32;
				double num3 = num2 - 1.0;
				bool flag11 = num3 < 0.0;
				bool flag12 = num3 == 0.0;
				object obj33 = num2 ^ 1.0;
				object obj34 = num2 ^ num3;
				object obj35 = obj33 & obj34;
				bool flag13 = (nint)obj35 < 0;
				bool flag14 = flag11 == flag13;
				object obj36 = !flag12;
				object obj37 = flag14 & obj36;
				object obj38 = ~obj37;
				double num4 = ((obj38 != null) ? num2 : 1.0);
				double num5 = num4 * 0.75;
				double num6 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
				double num7 = num6 * 0.0;
				double num8 = num5 + 0.25;
				double num9 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
				double num10 = num9 + 0.0;
				double num11 = ((!(num2 < 0.0)) ? num8 : 0.25);
				object obj39;
				double num12;
				if (num2 < 0.0)
				{
					obj39 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
					num12 = 0.0;
				}
				else
				{
					obj39 = 0;
					num12 = num10;
				}
				InputDevice inputDevice = default;
				while (true)
				{
					bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj39) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30);
					object obj40 = !flag15;
					if (obj40 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X21_v8+v354 @ X20_v10*4]");
					InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode((XRNode)0);
					bool flag16 = inputDevice.SendHapticImpulse(0u, (float)num11, (float)num12);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v19+18]");
					obj30 = 0;
					obj39++;
					object obj41 = obj39;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v19+18]");
					if ((nint)obj41 >= 0)
					{
						return;
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public GillaBlast()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01d6: Expected F4, but got I
		//IL_01fe: Expected VT, but got I
		//IL_0210: Expected F4, but got I
		//IL_0067: Expected F4, but got I
		//IL_0067: Expected F4, but got I
		//IL_007b: Expected Obj, but got I8
		//IL_00dd: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0136: Expected Obj, but got I
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0198: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CA8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B8B0]");
		killRadius = 0f;
		throwRadius = 7f;
		feltRadius = 16f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C090]");
		throwSpeed = (Vector2)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C920]");
		thingSpeed = 0f;
		voxelSeconds = 2.8f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Keyframe keyframe = new Keyframe(0f, 1f);
		Keyframe[] array = default;
		if (array.Length != 0)
		{
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD68]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA18]");
			Keyframe keyframe2 = new Keyframe(num, 0f);
			if ((object)(array.Length & 0xFFFFFFFEL) != null)
			{
				_ = 0;
				_ = 0;
				_ = 0;
				Keyframe keyframe3 = new Keyframe(1f, 0f);
				if ((object)(~(object)(array.Length >= 2) | ((object)(array.Length - 2) == null)) == null)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C98]");
					object obj2 = 0;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					AnimationCurve animationCurve = default;
					animationCurve._002Ector(array);
					object obj3 = this + 96;
					obj3 = animationCurve;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					flashRange = 18.75f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B5A8]");
					flashDelay = 0f;
					lasts = 4.5f;
					base._002Ector();
					return;
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	static GillaBlast()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBF8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC00]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBC08]");
		object obj4 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+A0]");
		object obj6 = 0;
		obj6 = num;
		int num2 = Shader.PropertyToID((string)obj3);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5+A0]");
		object obj8 = 0;
		IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker((string)obj4, 1, (MarkerFlags)0, 0);
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+A0]");
		object obj10 = 0;
		_ = 3240099840L;
	}
}
