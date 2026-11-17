using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine;

public class BlackHoleField : MonoBehaviour
{
	private const float Grow = default(float);

	private const float Pull = default(float);

	private const float Shut = default(float);

	private const float Radius = default(float);

	private float t;

	private bool mine;

	private bool burst;

	private PocketBlackHole look;

	private Transform horizon;

	private Transform disc;

	private ParticleSystem swirl;

	private Light glow;

	private AudioSource hum;

	private float glowMax;

	private readonly List<Rigidbody> caught;

	private readonly HashSet<Rigidbody> gravityOff;

	public void Begin(PocketBlackHole p, bool yours)
	{
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected Obj, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0067: Expected Obj, but got I
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01ee: Expected Obj, but got I4
		//IL_015c: Expected Obj, but got I
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_0262: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I
		//IL_0288: Expected VT, but got I4
		//IL_02aa: Expected VT, but got I4
		//IL_0392: Expected Obj, but got I4
		//IL_02d7: Expected Obj, but got I
		//IL_030e: Expected Obj, but got I4
		//IL_035a: Expected F4, but got I
		//IL_035a: Expected F4, but got I
		//IL_035a: Expected F4, but got Obj
		//IL_035a: Expected VT, but got I4
		//IL_0363: Expected VT, but got I4
		//IL_03fe: Expected Obj, but got I
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected Obj, but got Unknown
		object obj = this + 40;
		obj = p;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		mine = yours;
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE7F0]");
		object n = 0;
		Transform transform2 = transform.Find((string)n);
		object obj2 = this + 48;
		obj2 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Transform transform3 = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE7F8]");
		object n2 = 0;
		Transform transform4 = transform3.Find((string)n2);
		object obj3 = this + 56;
		obj3 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Transform transform5 = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE800]");
		object n3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		Transform transform6 = transform5.Find((string)n3);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (transform6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE7E8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			object obj8 = this + 64;
			object obj9 = default;
			obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE7E0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F01C");
		object obj11 = this + 72;
		object obj12 = default;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj13 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v30+E4]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj11 != null)
		{
			float intensity = ((Light)obj11).intensity;
			glowMax = intensity;
		}
		Transform transform7 = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj15 = 0;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v19+A0]");
		object obj17 = 0;
		transform7.localScale = (Vector3)0;
		bool flag3 = p.opens == null;
		Vector3 vector = (Vector3)0;
		if (!flag3)
		{
			Transform transform8 = base.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj18 = 0;
			Vector3 position = transform8.position;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X0_v62+E4]");
			bool flag4 = (nint)0 == 0;
			object obj20 = !flag4;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AudioClip[] opens = p.opens;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v20+4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v20+8]");
			Sfx.Play(opens, (Vector3)0, (float)obj17, num, 0f);
			vector = (Vector3)0;
		}
		object obj21 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v40+E4]");
		bool flag5 = (nint)0 == 0;
		object obj22 = !flag5;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (p.hum != null)
		{
			GameObject gameObject = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4350]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			object obj24 = this + 80;
			object obj25 = default;
			obj24 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			((AudioSource)obj24).clip = p.hum;
			((AudioSource)obj24).loop = true;
			((AudioSource)obj24).spatialBlend = 1f;
			((AudioSource)obj24).minDistance = 1.5f;
			((AudioSource)obj24).maxDistance = 25f;
			((AudioSource)obj24).rolloffMode = (AudioRolloffMode)1;
			((AudioSource)obj24).dopplerLevel = 0f;
			((AudioSource)obj24).volume = 0f;
			((AudioSource)obj24).Play();
		}
	}

	private void Update()
	{
		//IL_08c4: Invalid comparison between F4 and I
		//IL_0095: Invalid comparison between F4 and I
		//IL_0131: Invalid comparison between F4 and I4
		//IL_0140: Expected F8, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_08e4: Invalid comparison between F4 and I4
		//IL_0195: Expected F4, but got I4
		//IL_01b7: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_0232: Expected VT, but got I4
		//IL_025c: Expected Obj, but got I4
		//IL_02a1: Expected Obj, but got I4
		//IL_0339: Expected Obj, but got I4
		//IL_02ef: Expected Obj, but got I4
		//IL_02f8: Expected F4, but got I4
		//IL_030a: Expected F4, but got I4
		//IL_047a: Expected Obj, but got I4
		//IL_03b4: Invalid comparison between F4 and I4
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected Obj, but got Unknown
		//IL_03e0: Expected Obj, but got F4
		//IL_0415: Expected Obj, but got I4
		//IL_06fd: Expected Obj, but got I4
		//IL_0742: Expected Obj, but got I4
		//IL_04eb: Invalid comparison between F4 and I4
		//IL_04fa: Expected F8, but got I4
		//IL_07c4: Expected Obj, but got I4
		//IL_096c: Invalid comparison between F4 and I
		//IL_0993: Invalid comparison between F4 and I
		//IL_0782: Invalid comparison between F4 and I4
		//IL_079e: Expected Obj, but got I4
		//IL_05a8: Invalid comparison between F8 and I4
		//IL_07e4: Invalid comparison between F4 and I
		//IL_05df: Expected F4, but got I4
		//IL_0556: Expected F8, but got I
		//IL_0624: Invalid comparison between F4 and I4
		//IL_0633: Expected F8, but got I4
		//IL_05c8: Expected F4, but got I4
		//IL_05d1: Expected F8, but got I4
		//IL_0864: Expected Obj, but got I4
		//IL_06a3: Expected F4, but got I
		float deltaTime = Time.deltaTime;
		float num = (t = deltaTime + t);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
		float num4;
		if (num < 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4868]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v57+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
			float num3 = num2 / 0f;
			num4 = CosmeticToy.Elastic(num3);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA50]");
			if (num < 0f)
			{
				float num5 = num * 9f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				float num6 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
				float num7 = num6 * 0f;
				num4 = num7 + 1f;
			}
			else
			{
				float num8 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8A8]");
				float num9 = num8 + 0f;
				float num10 = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
				float num11 = num10 / 0f;
				bool flag2 = num11 < 0f;
				double num12 = 0.0;
				if (!flag2)
				{
					bool flag3 = !((double)num11 > 1.0);
					num12 = num11;
					if (!flag3)
					{
						num12 = 1.0;
					}
				}
				num4 = 1f - (float)num12;
			}
		}
		float num13 = ((!(num4 < 0f)) ? num4 : 0f);
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v10+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj7 = 0;
		float num14 = num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v11+14]");
		float num15 = num14 * 0f;
		float num16 = num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v11+10]");
		float num17 = num16 * 0f;
		float num18 = num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v11+C]");
		float num19 = num18 * 0f;
		transform.localScale = (Vector3)0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = disc != null;
		bool flag6 = !flag5;
		object obj10 = 0;
		Space space = (Space)0;
		if (!flag6)
		{
			num17 = deltaTime * 1.137836E+09f;
			disc.Rotate(0f, num17, 0f, (Space)1);
			obj10 = 0;
			num15 = 0f;
			space = (Space)1;
			num19 = 0f;
		}
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = glow != null;
		bool flag9 = !flag8;
		UnityEngine.Object obj13 = null;
		if (!flag9)
		{
			num15 = glowMax;
			float num20 = t;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA50]");
			float num21 = num20 - 0f;
			bool flag10 = num21 < 0f;
			float num22 = t;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA50]");
			object obj14 = num22 ^ 0;
			object obj15 = t ^ num21;
			object obj16 = obj14 & obj15;
			bool flag11 = (nint)obj16 < 0;
			bool flag12 = flag10 == flag11;
			object obj17 = !flag12;
			object obj18 = ~obj17;
			double num23 = ((obj18 != null) ? 2.0 : 1.0);
			num17 = num13 * num15;
			num19 = num17 * (float)num23;
			glow.intensity = num19;
			obj13 = null;
		}
		object obj19 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X0_v20+E4]");
		bool flag13 = (nint)0 == 0;
		object obj20 = !flag13;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = hum != null;
		bool flag15 = !flag14;
		UnityEngine.Object obj21 = null;
		if (!flag15)
		{
			float num24 = t;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
			num15 = num24 / 0f;
			bool flag16 = num15 < 0f;
			double num25 = 0.0;
			if (!flag16)
			{
				bool flag17 = !((double)num15 > 1.0);
				num25 = num15;
				if (!flag17)
				{
					num25 = 1.0;
				}
			}
			float num26 = t;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA50]");
			double num27;
			if (num26 < 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				num27 = 0.0;
			}
			else
			{
				float num28 = t;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8A8]");
				float num29 = num28 + 0f;
				double num30 = (double)num29 * -3.0;
				double num31 = num30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				num27 = num31 + 0.0;
				if (num27 < 0.0)
				{
					num15 = 0f;
					num27 = 0.0;
				}
				else
				{
					num15 = 0f;
				}
			}
			float volume = (float)num25 * (float)num27;
			hum.volume = volume;
			float num32 = t;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA50]");
			float num33 = num32 / 0f;
			bool flag18 = num33 < 0f;
			double num34 = 0.0;
			if (!flag18)
			{
				bool flag19 = !((double)num33 > 1.0);
				num34 = num33;
				if (!flag19)
				{
					num34 = 1.0;
				}
			}
			double num35 = num34 * 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			num17 = 0f;
			float num36 = (float)num35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			num19 = num36 + 0f;
			hum.pitch = num19;
			obj21 = null;
		}
		object obj22 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v25+E4]");
		bool flag20 = (nint)0 == 0;
		object obj23 = !flag20;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag21 = swirl != null;
		bool flag22 = !flag21;
		object obj24 = 0;
		if (!flag22)
		{
			ParticleSystem.EmissionModule emission = swirl.emission;
			float num37 = t;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA50]");
			float num38 = num37 - 0f;
			bool flag23 = num38 < 0f;
			ParticleSystem.EmissionModule emissionModule = default;
			emissionModule.enabled = flag23;
			obj24 = 0;
		}
		float num39 = t;
		bool flag24 = (byte)(~(burst ? 1u : 0u)) != 0;
		object obj25 = !flag24;
		if (obj25 == null)
		{
			float num40 = t;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA50]");
			if (!(num40 < 0f))
			{
				Burst();
				num39 = t;
			}
		}
		float num41 = num39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A938]");
		if (!(num41 < 0f))
		{
			if (~(mine ? 1u : 0u) == 0)
			{
				GillaToys.Back();
			}
			GameObject obj26 = gameObject;
			object obj27 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v22+E4]");
			bool flag25 = (nint)0 == 0;
			object obj28 = !flag25;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(obj26);
		}
	}

	private unsafe void FixedUpdate()
	{
		//IL_1b12: Expected F8, but got I
		//IL_1b24: Invalid comparison between F4 and I
		//IL_001b: Expected Obj, but got I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected F4, but got I
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected I4, but got Unknown
		//IL_017e: Expected Obj, but got I
		//IL_01a8: Expected Obj, but got I4
		//IL_1b48: Expected Obj, but got I
		//IL_1b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got I
		//IL_01fb: Expected Obj, but got I
		//IL_020b: Expected Obj, but got I
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected F4, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected Obj, but got I4
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected Obj, but got I4
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Expected Obj, but got I4
		//IL_1e8b: Expected Obj, but got I
		//IL_1e93: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e9c: Expected Ref, but got Unknown
		//IL_1eb6: Expected Obj, but got I4
		//IL_025a: Expected Obj, but got I4
		//IL_029f: Expected Obj, but got I4
		//IL_0852: Expected Obj, but got I4
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected Obj, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got I4
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e7: Expected Obj, but got I4
		//IL_0914: Expected Obj, but got I
		//IL_08af: Expected Obj, but got I4
		//IL_0379: Expected Obj, but got I8
		//IL_097b: Expected Obj, but got I
		//IL_03c1: Expected Obj, but got I4
		//IL_09b0: Expected Obj, but got I
		//IL_09c0: Expected Obj, but got I
		//IL_09d1: Expected Obj, but got I4
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Unknown result type (might be due to invalid IL or missing references)
		//IL_109a: Expected Obj, but got I
		//IL_10a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bde: Expected Obj, but got I4
		//IL_1c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got I4
		//IL_10df: Expected Obj, but got I
		//IL_1110: Invalid comparison between F8 and I4
		//IL_111f: Invalid comparison between F8 and I4
		//IL_1137: Expected Obj, but got F8
		//IL_1144: Expected Obj, but got F8
		//IL_1170: Expected Obj, but got I
		//IL_1180: Expected Obj, but got I
		//IL_1199: Expected Obj, but got I4
		//IL_11a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a6: Expected Obj, but got Unknown
		//IL_0a3b: Expected Obj, but got I
		//IL_0a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected Obj, but got I4
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c5e: Invalid comparison between F8 and I4
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afd: Expected Obj, but got I4
		//IL_1c7e: Expected F8, but got I4
		//IL_1c9e: Expected F4, but got I
		//IL_1ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e5: Expected F8, but got I4
		//IL_0b42: Expected Obj, but got I4
		//IL_0fb4: Expected Obj, but got I
		//IL_0fbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc2: Expected Obj, but got Unknown
		//IL_1019: Unknown result type (might be due to invalid IL or missing references)
		//IL_101d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected Obj, but got I4
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df1: Expected Obj, but got I
		//IL_1e05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e16: Expected Obj, but got I4
		//IL_1e1f: Expected Obj, but got I4
		//IL_1e28: Expected Obj, but got I4
		//IL_1e3e: Expected Obj, but got I4
		//IL_1e42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1221: Expected Obj, but got I4
		//IL_1a8b: Expected Obj, but got I4
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected Obj, but got I4
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Expected Obj, but got I
		//IL_1266: Expected Obj, but got I4
		//IL_1af2: Expected Obj, but got I4
		//IL_06ca: Expected Obj, but got I4
		//IL_06ea: Expected Obj, but got I4
		//IL_1297: Unknown result type (might be due to invalid IL or missing references)
		//IL_129b: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b0: Expected Obj, but got I4
		//IL_12b9: Expected Obj, but got I4
		//IL_12c2: Expected Obj, but got I4
		//IL_12d8: Expected Obj, but got I4
		//IL_12dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Expected Obj, but got VT
		//IL_079a: Expected Obj, but got I
		//IL_07c1: Expected Obj, but got I
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected Obj, but got Unknown
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected Obj, but got Unknown
		//IL_074d: Expected Obj, but got I
		//IL_076b: Unknown result type (might be due to invalid IL or missing references)
		//IL_132b: Expected Obj, but got I4
		//IL_0cd1: Expected I4, but got Obj
		//IL_0ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce9: Expected Obj, but got Unknown
		//IL_0d00: Expected Obj, but got Ref
		//IL_0e08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d66: Expected Obj, but got Ref
		//IL_0e9e: Expected Obj, but got I4
		//IL_0ebe: Expected Obj, but got I4
		//IL_1d00: Expected Obj, but got I4
		//IL_13a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bb: Expected Obj, but got I4
		//IL_13c4: Expected Obj, but got I4
		//IL_13cd: Expected Obj, but got I4
		//IL_13e3: Expected Obj, but got I4
		//IL_13e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f55: Expected Obj, but got VT
		//IL_0f65: Expected Obj, but got I
		//IL_0ede: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee3: Expected Obj, but got Unknown
		//IL_0f0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f11: Expected Obj, but got Unknown
		//IL_0f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d36: Expected Obj, but got I
		//IL_141f: Expected Obj, but got I
		//IL_1427: Expected I4, but got Obj
		//IL_1d65: Expected Obj, but got I4
		//IL_154e: Expected Obj, but got I
		//IL_158e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1593: Expected Obj, but got Unknown
		//IL_15f3: Invalid comparison between F4 and I
		//IL_1657: Expected Obj, but got I
		//IL_165f: Expected F4, but got Obj
		//IL_166f: Expected F4, but got I
		//IL_1d83: Invalid comparison between F8 and I
		//IL_1ee2: Invalid comparison between F8 and I4
		//IL_1ef1: Expected F8, but got I4
		//IL_16a5: Invalid comparison between F8 and I4
		//IL_16b4: Expected F8, but got I4
		//IL_1f17: Expected Obj, but got I
		//IL_1fb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb9: Expected Obj, but got Unknown
		//IL_2090: Expected VT, but got I4
		//IL_17b5: Invalid comparison between F8 and I4
		//IL_17c6: Expected Obj, but got I4
		//IL_16df: Invalid comparison between F8 and I4
		//IL_16f0: Expected Obj, but got I4
		//IL_1854: Expected F4, but got I
		//IL_1915: Expected VT, but got I4
		float num = t;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		double num2 = 0.0;
		float num3 = t;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		if (num3 < 0f)
		{
			return;
		}
		bool flag = (byte)(~(burst ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Transform transform = base.transform;
		bool flag2 = (object)transform == null;
		Enumerator<, > val = (Enumerator<, >)0;
		GillaCorpse gillaCorpse = null;
		Enumerator<, > val2 = (Enumerator<, >)0;
		UnityEngine.Object obj2 = null;
		BlackHoleField blackHoleField = this;
		double num8 = default;
		object obj8;
		object obj9;
		UnityEngine.Object obj12 = default;
		double num7;
		float num4;
		double num19;
		UnityEngine.Object obj24;
		object obj25;
		object obj26;
		Enumerator<, > val3;
		int num20 = default;
		object obj19 = default;
		float num18 = default;
		double num9;
		double num10;
		float num11;
		float num17 = default;
		UnityEngine.Object obj14;
		Enumerator<, > val5;
		int num6;
		float num5;
		object obj15;
		if (!flag2)
		{
			Vector3 position = transform.position;
			List<Rigidbody> list = caught;
			bool flag3 = (object)caught == null;
			val = (Enumerator<, >)0;
			gillaCorpse = null;
			val2 = (Enumerator<, >)0;
			num4 = t;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			num5 = 0f;
			obj2 = null;
			blackHoleField = this;
			if (!flag3)
			{
				num6 = list._size;
				val3 = (Enumerator<, >)(list._version + 1);
				list._size = 0;
				list._version = (int)val3;
				bool flag4 = list._size < 1;
				obj2 = null;
				if (!flag4)
				{
					Array.Clear(list._items, 0, list._size);
					obj2 = null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
				object obj3 = 0;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X0_v125+E4]");
				bool flag5 = (nint)0 == 0;
				object obj5 = !flag5;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj4 = obj3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X0_v125+A0]");
				object obj6 = 0;
				bool flag6 = obj6 == null;
				val = (Enumerator<, >)0;
				gillaCorpse = null;
				val2 = (Enumerator<, >)0;
				num7 = num8;
				num4 = num;
				num5 = (float)num2;
				blackHoleField = this;
				if (!flag6)
				{
					Enumerator<, > enumerator = ((List<System.__Canon>)obj6).GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5268]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE858]");
					obj9 = 0;
					num9 = num2;
					num10 = num8;
					Enumerator<, > val4 = default;
					num11 = (float)val4;
					val3 = (Enumerator<, >)(ref val2);
					while (val2.MoveNext())
					{
						object obj10 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1473 @ X0_v131+E4]");
						bool flag7 = (nint)0 == 0;
						object obj11 = !flag7;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag8 = obj12 == null;
						bool flag9 = !flag8;
						object obj13 = !flag9;
						num6 = 0;
						if (obj13 != null)
						{
							continue;
						}
						bool flag10 = (object)obj12 == null;
						val = (Enumerator<, >)0;
						gillaCorpse = null;
						obj14 = null;
						obj15 = 0;
						val2 = val4;
						val5 = (Enumerator<, >)(ref val2);
						num6 = 0;
						num7 = num8;
						num4 = num;
						num5 = (float)num2;
						obj2 = null;
						blackHoleField = this;
						if (flag10)
						{
							goto IL_19c5;
						}
						bool flag11 = ((GillaItem)obj12).Mine;
						bool flag12 = !flag11;
						num6 = 0;
						if (flag12)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ stack_-E8_v15 (UnityEngine.Object)+3C]");
						object obj16 = 0 & 0x80000000L;
						bool flag13 = obj16 == null;
						num6 = 0;
						if (flag13)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ stack_-E8_v15 (UnityEngine.Object)+40]");
						bool flag14 = (nint)0 == 0;
						object obj17 = !flag14;
						num6 = 0;
						if (obj17 != null)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ stack_-E8_v15 (UnityEngine.Object)+41]");
						bool flag15 = (nint)0 == 0;
						object obj18 = !flag15;
						num6 = 0;
						if (obj18 != null)
						{
							continue;
						}
						Transform transform2 = ((Component)obj12).transform;
						bool flag16 = (object)transform2 == null;
						val = (Enumerator<, >)0;
						gillaCorpse = null;
						obj14 = null;
						obj15 = 0;
						val2 = val4;
						val5 = (Enumerator<, >)(ref val2);
						num6 = 0;
						num7 = num8;
						num4 = num;
						num5 = (float)num2;
						obj2 = null;
						blackHoleField = this;
						if (flag16)
						{
							goto IL_1a25;
						}
						Vector3 position2 = transform2.position;
						num10 -= num8;
						float num12 = num11 - num;
						double num13 = num9 - num2;
						float num14 = num12 * num12;
						double num15 = num13 * num13;
						float num16 = num14 + (float)num15;
						num9 = num10 * num10;
						num11 = (float)num9 + num16;
						bool flag17 = !((double)num11 < 25.0);
						num17 = num;
						num18 = (float)num2;
						num6 = 0;
						if (flag17)
						{
							continue;
						}
						List<System.__Canon> list2 = (List<System.__Canon>)(object)caught;
						bool flag18 = (object)caught == null;
						val = (Enumerator<, >)0;
						gillaCorpse = null;
						num17 = num;
						num18 = (float)num2;
						obj14 = null;
						obj15 = 0;
						val2 = val4;
						val5 = (Enumerator<, >)(ref val2);
						num6 = 0;
						num7 = num8;
						num4 = num;
						num19 = num2;
						obj2 = null;
						blackHoleField = this;
						if (!flag18)
						{
							System.__Canon[] items = list2._items;
							val3 = (Enumerator<, >)obj9;
							num20 = ++list2._version;
							bool flag19 = list2._items == null;
							val = (Enumerator<, >)0;
							gillaCorpse = null;
							num17 = num;
							num18 = (float)num2;
							obj14 = null;
							obj15 = 0;
							val2 = val4;
							val5 = (Enumerator<, >)(ref val2);
							num6 = 0;
							num7 = num8;
							num4 = num;
							num19 = num2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ stack_-E8_v15 (UnityEngine.Object)+78]");
							obj2 = (UnityEngine.Object)0;
							blackHoleField = this;
							if (!flag19)
							{
								num20 = list2._size;
								obj19 = items.Length;
								bool flag20 = list2._size < items.Length;
								object obj20 = !flag20;
								if (obj20 == null)
								{
									object obj21 = list2._items + list2._size;
									int num21 = ++list2._size;
									object obj22 = obj21 + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ stack_-E8_v15 (UnityEngine.Object)+78]");
									obj22 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									num17 = num;
									num18 = (float)num2;
									val3 = (Enumerator<, >)num21;
									num6 = 0;
								}
								else
								{
									System.__Canon _Canon = (System.__Canon)val3._current;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1693 @ X8_v80 (System.__Canon)+A8]");
									object obj23 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1307 @ X8_v81+70]");
									num6 = 0;
									List<Rigidbody> list3 = caught;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ stack_-E8_v15 (UnityEngine.Object)+78]");
									((List<System.__Canon>)(object)list3).AddWithResize((System.__Canon)0);
									num17 = num;
									num18 = (float)num2;
								}
								continue;
							}
						}
						goto IL_1a3b;
					}
					val = (Enumerator<, >)0;
					gillaCorpse = null;
					obj24 = null;
					obj15 = 0;
					val2 = val4;
					obj25 = 6;
					val5 = (Enumerator<, >)(ref val2);
					num7 = num8;
					num4 = num;
					num19 = num2;
					blackHoleField = this;
					obj26 = 0;
					goto IL_1e7b;
				}
			}
		}
		goto IL_1997;
		IL_1e7b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5260]");
		object obj27 = 0;
		obj2 = (UnityEngine.Object)obj27;
		((Enumerator<, >*)val5)->Dispose();
		bool flag21 = obj26 == null;
		object obj28 = !flag21;
		obj14 = obj24;
		num5 = (float)num19;
		UnityEngine.Object obj39 = default;
		object obj44;
		object obj37;
		object obj36;
		NullReferenceException ex;
		if (obj28 == null)
		{
			bool flag22 = (object)obj24 == null;
			object obj29 = !flag22;
			obj14 = obj24;
			num5 = (float)num19;
			ex = (NullReferenceException)val5;
			if (obj29 == null)
			{
				if ((nint)obj25 != 6)
				{
					bool flag23 = obj25 == null;
					object obj30 = !flag23;
					if (obj30 != null)
					{
						return;
					}
				}
				object obj31 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1550 @ X0_v7+E4]");
				bool flag24 = (nint)0 == 0;
				object obj32 = !flag24;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE870]");
				object obj33 = 0;
				obj2 = (UnityEngine.Object)obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD798");
				object obj34 = default;
				bool flag25 = obj34 == null;
				num2 = num9;
				num8 = num10;
				obj12 = obj24;
				num = num11;
				num5 = (float)num19;
				if (flag25)
				{
					goto IL_1997;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v10+18]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v10+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_103f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B78]");
				obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74F0]");
				obj37 = 0;
				UnityEngine.Object obj38 = obj39;
				object obj40 = 0;
				object obj41 = obj19;
				int num22 = num20;
				num2 = num9;
				num8 = num10;
				float num23 = num17;
				float num24 = num18;
				Enumerator<, > val6 = val3;
				int num25 = num6;
				UnityEngine.Object obj42 = (UnityEngine.Object)obj33;
				UnityEngine.Object obj48 = default;
				object obj51 = default;
				while (true)
				{
					bool flag26 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj35);
					object obj43 = !flag26;
					obj39 = obj38;
					obj44 = obj40;
					obj19 = obj41;
					num20 = num22;
					num9 = num2;
					num10 = num8;
					num17 = num23;
					num18 = num24;
					obj14 = obj24;
					val3 = val6;
					num6 = num25;
					num5 = (float)num19;
					obj2 = obj42;
					if (obj43 != null)
					{
						break;
					}
					object obj45 = obj34 + obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v46+20]");
					obj39 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v46+20]");
					bool flag27 = (nint)0 == 0;
					obj44 = obj40;
					obj19 = obj41;
					num20 = num22;
					num17 = num23;
					num18 = num24;
					obj12 = obj24;
					num = num11;
					val3 = val6;
					num6 = num25;
					num5 = (float)num19;
					obj2 = obj42;
					if (!flag27)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
						object obj46 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v47+E4]");
						val3 = (Enumerator<, >)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v47+E4]");
						bool flag28 = (nint)0 == 0;
						object obj47 = !flag28;
						if (obj47 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag29 = obj48 == null;
						bool flag30 = !flag29;
						object obj49 = !flag30;
						num6 = 0;
						obj2 = null;
						if (obj49 != null)
						{
							goto IL_0fa4;
						}
						bool flag31 = (object)obj48 == null;
						obj44 = obj40;
						obj19 = obj41;
						num20 = num22;
						num17 = num23;
						num18 = num24;
						obj12 = obj24;
						num = num11;
						num6 = 0;
						num5 = (float)num19;
						obj2 = null;
						if (!flag31)
						{
							Vector3 position3 = ((Rigidbody)obj48).position;
							num8 -= num7;
							float num26 = num11 - num4;
							double num27 = num2 - num19;
							float num28 = num26 * num26;
							double num29 = num27 * num27;
							float num30 = num28 + (float)num29;
							num2 = num8 * num8;
							num11 = (float)num2 + num30;
							bool flag32 = !((double)num11 < 25.0);
							num23 = num4;
							num24 = (float)num19;
							num6 = 0;
							obj2 = null;
							if (flag32)
							{
								goto IL_0fa4;
							}
							bool isKinematic = ((Rigidbody)obj48).isKinematic;
							bool flag33 = !isKinematic;
							num6 = 0;
							obj2 = null;
							if (!flag33)
							{
								num6 = (int)obj37;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
								object obj50 = obj51 & 1;
								bool flag34 = obj50 == null;
								obj2 = (UnityEngine.Object)(&gillaCorpse);
								if (!flag34)
								{
									bool flag35 = (object)gillaCorpse == null;
									obj44 = obj40;
									obj19 = obj41;
									num20 = num22;
									num17 = num4;
									num18 = (float)num19;
									obj12 = obj24;
									num = num11;
									num5 = (float)num19;
									obj2 = (UnityEngine.Object)(&gillaCorpse);
									if (flag35)
									{
										goto IL_1997;
									}
									gillaCorpse.Loosen();
									obj2 = null;
								}
							}
							List<System.__Canon> list4 = (List<System.__Canon>)(object)blackHoleField.caught;
							bool flag36 = (object)blackHoleField.caught == null;
							obj44 = obj40;
							obj19 = obj41;
							num20 = num22;
							num17 = num4;
							num18 = (float)num19;
							obj12 = obj24;
							num = num11;
							num5 = (float)num19;
							if (!flag36)
							{
								System.__Canon[] items2 = list4._items;
								val3 = (Enumerator<, >)obj9;
								num20 = list4._version + 1;
								list4._version = num20;
								bool flag37 = list4._items == null;
								obj44 = obj40;
								obj19 = obj41;
								num17 = num4;
								num18 = (float)num19;
								obj12 = obj24;
								num = num11;
								num5 = (float)num19;
								if (!flag37)
								{
									num22 = list4._size;
									obj41 = items2.Length;
									bool flag38 = list4._size < items2.Length;
									object obj52 = !flag38;
									if (obj52 == null)
									{
										object obj53 = list4._items + list4._size;
										int num31 = ++list4._size;
										object obj54 = obj53 + 32;
										obj54 = obj48;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										num23 = num4;
										num24 = (float)num19;
										val3 = (Enumerator<, >)num31;
										obj2 = obj48;
									}
									else
									{
										System.__Canon _Canon2 = (System.__Canon)val3._current;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1819 @ X8_v51 (System.__Canon)+A8]");
										object obj55 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1721 @ X8_v52+70]");
										num6 = 0;
										((List<System.__Canon>)(object)blackHoleField.caught).AddWithResize((System.__Canon)(object)obj48);
										num23 = num4;
										num24 = (float)num19;
										obj2 = obj48;
									}
									goto IL_0fa4;
								}
							}
						}
					}
					goto IL_1997;
					IL_0fa4:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v10+18]");
					obj35 = 0;
					obj44 = obj40 + 1;
					object obj56 = obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v10+18]");
					bool flag39 = (nint)obj56 < 0;
					obj19 = obj41;
					num20 = num22;
					num9 = num2;
					num10 = num8;
					num17 = num23;
					num18 = num24;
					obj38 = obj39;
					obj40 = obj44;
					val6 = val3;
					num25 = num6;
					obj42 = obj2;
					if (flag39)
					{
						continue;
					}
					goto IL_103f;
				}
				goto IL_19d3;
			}
			goto IL_19fd;
		}
		goto IL_1a0c;
		IL_19d3:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_19e1;
		IL_19c5:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_19d3;
		IL_1997:
		NullReferenceException ex4 = new NullReferenceException();
		num9 = num2;
		num10 = num8;
		obj14 = obj12;
		num11 = num;
		goto IL_19c5;
		IL_19fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_1a0c;
		IL_103f:
		num = Time.fixedDeltaTime;
		bool flag40 = (object)blackHoleField.caught == null;
		num2 = num9;
		num8 = num10;
		obj12 = obj24;
		num5 = (float)num19;
		if (flag40)
		{
			goto IL_1997;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE868]");
		object obj57 = 0;
		Enumerator<, > enumerator2 = ((List<System.__Canon>)(object)blackHoleField.caught).GetEnumerator();
		float num32 = num * -5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE848]");
		obj9 = 0;
		double num33 = 1.0 - (double)num32;
		double num34 = num33 - 1.0;
		bool flag41 = num34 < 0.0;
		bool flag42 = num34 == 0.0;
		object obj58 = num33 ^ 1.0;
		object obj59 = num33 ^ num34;
		object obj60 = obj58 & obj59;
		bool flag43 = (nint)obj60 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj62 = 0;
		bool flag44 = flag41 == flag43;
		object obj63 = !flag42;
		object obj64 = flag44 & obj63;
		object obj65 = ~obj64;
		num10 = ((obj65 != null) ? num33 : 1.0);
		double num35 = ((!(num33 < 0.0)) ? num10 : 0.0);
		num9 = 0.0;
		double num36 = num19;
		num18 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		num11 = 0f;
		val3 = (Enumerator<, >)17276928;
		Enumerator<, > val7 = default;
		object obj79 = default;
		object obj84 = default;
		object obj85 = default;
		object obj87 = default;
		while (val.MoveNext())
		{
			object obj66 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1797 @ X0_v20+E4]");
			bool flag45 = (nint)0 == 0;
			object obj67 = !flag45;
			if (obj67 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag46 = obj24 == null;
			bool flag47 = !flag46;
			object obj68 = !flag47;
			obj39 = obj24;
			num6 = 0;
			if (obj68 != null)
			{
				continue;
			}
			bool flag48 = (object)obj24 == null;
			val = val7;
			obj39 = obj24;
			obj44 = 1;
			obj37 = 109891584;
			obj36 = 17276928;
			num17 = (float)num36;
			obj14 = null;
			obj15 = 0;
			val5 = (Enumerator<, >)(ref val);
			num6 = 0;
			num5 = (float)num19;
			obj2 = null;
			if (!flag48)
			{
				bool isKinematic2 = ((Rigidbody)obj24).isKinematic;
				bool flag49 = !isKinematic2;
				object obj69 = !flag49;
				obj39 = obj24;
				num6 = 0;
				if (obj69 != null)
				{
					continue;
				}
				bool useGravity = ((Rigidbody)obj24).useGravity;
				bool flag50 = !useGravity;
				num6 = 0;
				if (!flag50)
				{
					((Rigidbody)obj24).useGravity = false;
					bool flag51 = blackHoleField.gravityOff == null;
					val = val7;
					obj39 = obj24;
					obj44 = 1;
					obj37 = 109891584;
					obj36 = 17276928;
					num17 = (float)num36;
					obj14 = null;
					obj15 = 0;
					val5 = (Enumerator<, >)(ref val);
					num6 = 0;
					num5 = (float)num19;
					obj2 = null;
					if (flag51)
					{
						goto IL_19ef;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBE8]");
					object obj70 = 0;
					num6 = (int)obj70;
					bool flag52 = ((HashSet<System.__Canon>)(object)blackHoleField.gravityOff).Add((System.__Canon)(object)obj24);
				}
				Vector3 position4 = ((Rigidbody)obj24).position;
				object obj71 = obj61;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1850 @ X0_v32+E4]");
				bool flag53 = (nint)0 == 0;
				object obj72 = !flag53;
				if (obj72 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj73 = obj62;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD99E]");
				val3 = (Enumerator<, >)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1862 @ X8_v31+A0]");
				object obj74 = 0;
				object obj75 = obj61;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1878 @ X0_v37+E4]");
				bool flag54 = (nint)0 == 0;
				object obj76 = !flag54;
				if (obj76 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double num37 = num7 - num10;
				double num38 = num37 * num37;
				float num39 = num4 - num11;
				float num40 = num39 * num39;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				double num41 = num38 + (double)num40;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				double num42 = num37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
				double num43 = num42 / 0.0;
				float num44 = num39 / (float)num36;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				float num45 = num44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1863 @ X8_v32+1C]");
				float num46 = num45 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
				nint num47 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1863 @ X8_v32+1C]");
				object obj77 = num47 * 0;
				float num48 = num44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1863 @ X8_v32+1C]");
				float num49 = num48 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				float num50 = (float)obj77 - num46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1863 @ X8_v32+18]");
				object obj78 = 0 * obj79;
				float num51 = (float)obj78 - num49;
				float num52 = num50 * num50;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				float num53 = num51 * num51;
				float num54 = num53 + num52;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				float num55;
				float num57;
				if (num54 > 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					num55 = num51 / num54;
					float num56 = num50;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					num57 = num56 / 0f;
				}
				else
				{
					object obj80 = obj62;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1926 @ X8_v41+A0]");
					object obj81 = 0;
					num57 = (float)obj81;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1927 @ X8_v42+8]");
					num55 = 0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				double num59;
				double num63;
				double num64;
				double num65;
				if (num41 > 0.0)
				{
					double num58 = num41 / -5.0;
					num59 = num58 + 1.0;
					bool flag55 = num59 < 0.0;
					double num60 = 0.0;
					if (!flag55)
					{
						double num61 = num59 - 1.0;
						bool flag56 = num61 == 0.0;
						obj63 = !flag56;
						bool flag57 = num59 > 1.0;
						num60 = 1.0;
						if (!flag57)
						{
							num60 = num59;
						}
					}
					double num62 = num60 * 6.0;
					num63 = num62 + 3.0;
					num64 = num63;
					num65 = 3.0;
				}
				else
				{
					num63 = num41 / -5.0;
					double num66 = num41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC44]");
					double num67 = num66 + 0.0;
					double num68 = num67 * 6.0;
					num59 = num63 + 1.0;
					num64 = num68;
					num65 = 6.0;
				}
				bool flag58 = num59 < 0.0;
				double num69 = 0.0;
				if (!flag58)
				{
					double num70 = num59 - 1.0;
					bool flag59 = num70 == 0.0;
					obj63 = !flag59;
					bool flag60 = num59 > 1.0;
					num69 = 1.0;
					if (!flag60)
					{
						num69 = num59;
					}
				}
				object obj82 = obj62;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2043 @ X8_v38+A0]");
				object obj83 = 0;
				Vector3 position5 = ((Rigidbody)obj24).position;
				Vector3 linearVelocity = ((Rigidbody)obj24).linearVelocity;
				double num71 = num69 * 4.0;
				float num72 = num44 * (float)obj84;
				double num73 = num71 + 2.0;
				double num74 = num19 - num63;
				double num75 = num43 * num64;
				float num76 = num57 * (float)obj85;
				float num77 = num55 * (float)num73;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1786 @ X8_v39+18]");
				object obj86 = 0 * obj87;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1786 @ X8_v39+20]");
				double num78 = 0.0 * num74;
				float num79 = num72 + num76;
				double num80 = num75 + (double)num77;
				object obj88 = obj86 + obj86;
				double num81 = num78 + num78;
				float num82 = num79 + (float)obj88;
				double num83 = num80 + num81;
				float num84 = num82 - (float)num59;
				double num85 = num83 - num65;
				float num86 = num84 * (float)obj87;
				double num87 = num85 * num35;
				double num88 = num59 + (double)num86;
				double num89 = num65 + num87;
				((Rigidbody)obj24).linearVelocity = (Vector3)0;
				Vector3 angularVelocity = ((Rigidbody)obj24).angularVelocity;
				Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
				double num90 = num88 * 8.0;
				double num91 = (double)obj85 * 8.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				num18 = 0f;
				double num92 = num89 * 8.0;
				double num93 = num90 - num88;
				double num94 = num91 - (double)obj85;
				double num95 = num92 - num89;
				double num96 = num93;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				double num97 = num96 * 0.0;
				double num98 = num94;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				double num99 = num98 * 0.0;
				double num100 = num95;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				double num101 = num100 * 0.0;
				num11 = (float)num88 + (float)num97;
				num9 = (double)obj85 + num99;
				num10 = num89 + num101;
				((Rigidbody)obj24).angularVelocity = (Vector3)0;
				((Rigidbody)obj24).WakeUp();
				obj39 = obj24;
				num36 = num35;
				continue;
			}
			goto IL_19e1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE840]");
		object obj89 = 0;
		obj2 = (UnityEngine.Object)obj89;
		val.Dispose();
		val = val7;
		obj44 = 1;
		obj37 = 109891584;
		obj36 = 17276928;
		num17 = (float)num36;
		obj14 = null;
		obj15 = 0;
		val5 = (Enumerator<, >)(ref val);
		num5 = (float)num19;
		blackHoleField = null;
		OutOfMemoryException ex5 = new OutOfMemoryException();
		goto IL_1a25;
		IL_1a25:
		NullReferenceException ex6 = new NullReferenceException();
		num19 = num5;
		goto IL_1a3b;
		IL_1a3b:
		NullReferenceException ex7 = new NullReferenceException();
		if ((nint)obj2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj14 = (UnityEngine.Object)1;
			obj26 = obj15;
		}
		else
		{
			if ((nint)obj2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D3D4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj90 = default;
			obj26 = obj90;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj15 = obj90;
		}
		obj24 = obj14;
		obj25 = 0;
		goto IL_1e7b;
		IL_1a0c:
		throw new OutOfMemoryException();
		IL_19e1:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_19ef;
		IL_19ef:
		ex = new NullReferenceException();
		goto IL_19fd;
	}

	private unsafe void Burst()
	{
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_0115: Expected F4, but got I
		//IL_051a: Expected Obj, but got I4
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected Obj, but got I4
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Expected Ref, but got Unknown
		//IL_0995: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_017e: Expected Obj, but got I4
		//IL_019c: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I4
		//IL_056d: Expected Obj, but got I4
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected Obj, but got Unknown
		//IL_0731: Expected Obj, but got I4
		//IL_0743: Expected Obj, but got I4
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got I4
		//IL_01e7: Expected Obj, but got I4
		//IL_05c2: Expected Obj, but got I
		//IL_05f7: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I4
		//IL_022a: Expected Obj, but got I4
		//IL_064b: Expected I4, but got Obj
		//IL_0656: Expected I4, but got Obj
		//IL_065f: Expected Obj, but got I4
		//IL_09f0: Expected Obj, but got I4
		//IL_02b1: Invalid comparison between F4 and I
		//IL_030d: Expected Obj, but got I
		//IL_0315: Expected F4, but got Obj
		//IL_0325: Expected F4, but got I
		//IL_06b7: Expected Obj, but got I
		//IL_06e1: Expected Obj, but got I4
		//IL_0965: Expected VT, but got I4
		//IL_0965: Expected Obj, but got I
		//IL_0a16: Expected Obj, but got I
		//IL_0a58: Expected Obj, but got I4
		//IL_0422: Invalid comparison between F4 and I
		//IL_048b: Expected F4, but got I4
		//IL_049b: Expected F4, but got I
		//IL_0935: Expected VT, but got I4
		//IL_0935: Expected Obj, but got I4
		//IL_04ea: Expected VT, but got I4
		//IL_04ea: Expected Obj, but got I4
		//IL_04f3: Expected Obj, but got I4
		burst = true;
		Transform transform = base.transform;
		bool flag = (object)transform == null;
		float num2 = default;
		float num = num2;
		bool flag3 = default;
		bool flag2 = flag3;
		float num4 = default;
		float num3 = num4;
		Enumerator val = (Enumerator)0;
		float num6 = default;
		float num5 = num6;
		UnityEngine.Object obj = null;
		bool flag4 = true;
		if (!flag)
		{
			Vector3 position = transform.position;
			bool flag5 = gravityOff == null;
			num = num2;
			flag2 = flag3;
			num3 = num4;
			val = (Enumerator)0;
			num5 = num6;
			float num7 = num2;
			float num8 = num4;
			float num9 = num6;
			obj = null;
			flag4 = true;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE820]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE818]");
				object obj4 = 0;
				Enumerator enumerator = ((HashSet<System.__Canon>)(object)gravityOff).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj6 = 0;
				num = num2;
				num3 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				num5 = 0f;
				flag4 = false;
				object obj21 = default;
				object obj22 = default;
				Enumerator val2 = default;
				object obj27 = default;
				while (true)
				{
					object obj23;
					Enumerator val3;
					object obj10;
					if (val.MoveNext())
					{
						object obj7 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v41+E4]");
						flag4 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v41+E4]");
						bool flag6 = (byte)(~(nuint)0u) != 0;
						object obj8 = !flag6;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag7 = (UnityEngine.Object)flag3 == null;
						bool flag8 = !flag7;
						object obj9 = !flag8;
						obj10 = 0;
						if (obj9 != null)
						{
							continue;
						}
						if (flag3)
						{
							((Rigidbody)flag3).useGravity = true;
							bool isKinematic = ((Rigidbody)flag3).isKinematic;
							bool flag9 = !isKinematic;
							object obj11 = !flag9;
							obj10 = 0;
							if (obj11 == null)
							{
								Vector3 position2 = ((Rigidbody)flag3).position;
								object obj12 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X0_v53+E4]");
								bool flag10 = (nint)0 == 0;
								object obj13 = !flag10;
								if (obj13 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								float num10 = num5 - num6;
								float num11 = num - num2;
								float num12 = num10 * num10;
								float num13 = num11 * num11;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
								float num14 = num13 + num12;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
								float num15;
								float num16;
								if (num14 > 0f)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
									num15 = num11 / num14;
									num16 = num10 / num13;
								}
								else
								{
									object obj14 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X8_v41+A0]");
									object obj15 = 0;
									num16 = (float)obj15;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v42+8]");
									num15 = 0f;
								}
								object obj16 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v33+A0]");
								object obj17 = 0;
								Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
								object obj18 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X0_v60+E4]");
								flag4 = false;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X0_v60+E4]");
								bool flag11 = (byte)(~(nuint)0u) != 0;
								object obj19 = !flag11;
								if (obj19 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v34+18]");
								float num17 = 0f * num4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v34+20]");
								float num18 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
								float num19 = num18 * 0f;
								float num20 = num16 + num17;
								float num21 = num10 * num6;
								float num22 = num14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
								float num23 = num22 * 0f;
								float num24 = num15 + num19;
								float num25 = num20 + num21;
								float num26 = num24 + num23;
								float num27 = num25 * num25;
								float num28 = num26 * num26;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
								float num29 = num28 + num27;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
								float num30;
								float num31;
								if (num29 > 0f)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
									num30 = num26 / num29;
									num31 = num25 / num28;
								}
								else
								{
									object obj20 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X8_v39+A0]");
									flag4 = false;
									num31 = (((bool*)(flag4 ? 1 : 0))->m_value ? 1 : 0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v15 (System.Boolean)+8]");
									num30 = 0f;
								}
								float num32 = UnityEngine.Random.Range(5f, 8.5f);
								float num33 = num31 * (float)obj21;
								float num34 = num30 * num32;
								((Rigidbody)flag3).linearVelocity = (Vector3)0;
								Vector3 insideUnitSphere2 = UnityEngine.Random.insideUnitSphere;
								double num35 = (double)num33 * 12.0;
								double num36 = (double)obj22 * 12.0;
								num = num34 * 12f;
								((Rigidbody)flag3).angularVelocity = (Vector3)0;
								obj10 = 0;
								num3 = (float)num36;
								num5 = (float)num35;
							}
							continue;
						}
						NullReferenceException ex = new NullReferenceException();
						obj10 = 0;
						flag2 = false;
						obj23 = 0;
						val = val2;
						val3 = (Enumerator)(ref val);
						num7 = num2;
						num8 = num4;
						num9 = num6;
						obj = null;
						break;
					}
					flag2 = false;
					obj23 = 0;
					val = val2;
					val3 = (Enumerator)(ref val);
					num7 = num2;
					num8 = num4;
					num9 = num6;
					object obj24 = 0;
					while (true)
					{
						obj = (UnityEngine.Object)obj4;
						((Enumerator*)val3)->Dispose();
						bool flag12 = obj24 == null;
						object obj25 = !flag12;
						if (obj25 == null)
						{
							bool flag13 = !flag2;
							object obj26 = !flag13;
							OutOfMemoryException ex2 = (OutOfMemoryException)val3;
							flag4 = flag2;
							if (obj26 == null)
							{
								break;
							}
						}
						else
						{
							OutOfMemoryException ex2 = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if ((nint)obj == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							flag2 = true;
							flag4 = true;
							obj24 = obj23;
							continue;
						}
						if ((nint)obj == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj24 = obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj23 = obj27;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A00F4");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					bool flag14 = gravityOff == null;
					flag4 = flag2;
					if (flag14)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE830]");
					object obj28 = 0;
					((HashSet<System.__Canon>)(object)gravityOff).Clear();
					object obj29 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X0_v7+E4]");
					bool flag15 = (nint)0 == 0;
					object obj30 = !flag15;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!(look != null))
					{
						return;
					}
					flag4 = (byte)(int)look != 0;
					bool flag16 = (byte)(int)(~look) != 0;
					obj10 = 0;
					num3 = num8;
					num5 = num9;
					obj = null;
					if (flag16)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v15 (System.Boolean)+50]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
						object obj31 = 0;
						object obj32 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X0_v12+E4]");
						bool flag17 = (nint)0 == 0;
						object obj33 = !flag17;
						float pitchMin = num8;
						float volume = num9;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							pitchMin = num8;
							volume = num9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v15 (System.Boolean)+50]");
						Sfx.Play((AudioClip[])0, (Vector3)0, volume, pitchMin, num7);
					}
					return;
				}
			}
		}
		throw new NullReferenceException();
	}

	private unsafe void OnDestroy()
	{
		//IL_0251: Expected Obj, but got I
		//IL_025a: Expected Obj, but got I4
		//IL_0017: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Ref, but got Unknown
		//IL_02bd: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_0124: Expected Obj, but got I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_014d: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got I4
		bool flag = gravityOff == null;
		IntPtr intPtr = default;
		UnityEngine.Object obj = (UnityEngine.Object)(nint)intPtr;
		object obj2 = 109895680;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE820]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE818]");
			obj2 = 0;
			Enumerator enumerator = ((HashSet<System.__Canon>)(object)gravityOff).GetEnumerator();
			Enumerator val = default;
			bool flag4;
			object obj13 = default;
			object obj7;
			object obj8;
			object obj9;
			Enumerator val2;
			do
			{
				if (val.MoveNext())
				{
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v27+E4]");
					bool flag2 = (nint)0 == 0;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag3 = (UnityEngine.Object)null != (UnityEngine.Object)null;
					flag4 = !flag3;
					obj7 = 0;
					continue;
				}
				obj8 = 0;
				obj9 = 0;
				val2 = (Enumerator)(ref val);
				object obj10 = 0;
				while (true)
				{
					obj = (UnityEngine.Object)obj2;
					((Enumerator*)val2)->Dispose();
					bool flag5 = obj10 == null;
					object obj11 = !flag5;
					if (obj11 == null)
					{
						bool flag6 = obj8 == null;
						object obj12 = !flag6;
						OutOfMemoryException ex = (OutOfMemoryException)val2;
						if (obj12 == null)
						{
							return;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj8 = 1;
						obj10 = obj9;
						continue;
					}
					if ((nint)obj != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj10 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj9 = obj13;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A00F4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			while (flag4);
			NullReferenceException ex2 = new NullReferenceException();
			obj7 = 0;
			obj8 = 0;
			obj9 = 0;
			val2 = (Enumerator)(ref val);
			obj = null;
		}
		throw new NullReferenceException();
	}

	public BlackHoleField()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE878]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBBD0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj3 = this + 96;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<System.__Canon> hashSet = default;
		hashSet._002Ector();
		object obj4 = this + 104;
		obj4 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
