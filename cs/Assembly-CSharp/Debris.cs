using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class Debris : MonoBehaviour
{
	private ParticleSystem chips;

	private ParticleSystem dust;

	private static Material material;

	private static Mesh cube;

	private const int Solid = default(int);

	private static readonly Color ChipLight;

	private static readonly Color ChipDark;

	private static readonly Color DustLight;

	private static readonly Color DustDark;

	public static Debris On(Component owner)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I
		if ((object)owner != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C80]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj5 = default;
			if (obj5 != null)
			{
				return (Debris)obj5;
			}
			GameObject gameObject = owner.gameObject;
			if ((object)gameObject != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C88]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				Debris result = default;
				return result;
			}
		}
		return (Debris)(object)new NullReferenceException();
	}

	public unsafe void Chips(Vector3 at, Vector3 outward, int count, float force = default(float), float spread = default(float))
	{
		//IL_0286: Invalid comparison between VT and I4
		//IL_003c: Expected Obj, but got I
		//IL_0044: Expected VT, but got Obj
		//IL_0066: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I
		//IL_0432: Expected VT, but got I4
		//IL_044f: Expected F4, but got I
		//IL_044f: Expected F4, but got I
		//IL_00e2: Expected F4, but got I
		//IL_00e2: Expected F4, but got I
		//IL_02d0: Expected Obj, but got I
		//IL_02fc: Expected F4, but got I
		//IL_02fc: Expected F4, but got I
		//IL_0343: Expected VT, but got I4
		//IL_0360: Expected F4, but got I
		//IL_0360: Expected F4, but got I
		//IL_014c: Expected VT, but got I4
		//IL_0198: Expected VT, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_0379: Expected Obj, but got I
		//IL_038b: Invalid comparison between F4 and I4
		//IL_03bc: Expected Obj, but got I
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_0412: Expected F4, but got I
		//IL_0412: Expected F4, but got I
		//IL_0236: Expected VT, but got Ref
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected VT, but got Unknown
		//IL_0252: Invalid comparison between VT and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		if (at < (object)1 || !Ensure())
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C90]");
		object obj = 0;
		Vector3 outward2 = (Vector3)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v8 (UnityEngine.Vector3)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 vector = Side(outward2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj3 = 0;
		int num = 144;
		Vector3 vector2 = at;
		ParticleSystem.EmitParams emitParams = default;
		object obj5 = default;
		object obj7 = default;
		object obj13 = default;
		Color32 startColor = default;
		float startLifetime = default;
		object obj15 = default;
		bool flag3;
		do
		{
			Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
			emitParams.position = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE6C]");
			float num3 = UnityEngine.Random.Range(num2, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA8C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			float num5 = UnityEngine.Random.Range(num4, 0f);
			object obj4 = obj3;
			float num6 = (float)obj5 * num3;
			float num7 = (float)obj5 * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v14+A0]");
			object obj6 = 0;
			float num8 = num6 + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE28]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			float num10 = UnityEngine.Random.Range(num9, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v15+20]");
			float num11 = 0f * num10;
			float num12 = num8 + num11;
			float num13 = num12 * (float)obj7;
			emitParams.velocity = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF80]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC8]");
			float num15 = (emitParams.startSize = UnityEngine.Random.Range(num14, 0f));
			Vector3 insideUnitSphere2 = UnityEngine.Random.insideUnitSphere;
			float num17 = num15 * 1.1274813E+09f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC8]");
			float num18 = 0f * 1.1274813E+09f;
			float num19 = num13 * 1.1274813E+09f;
			emitParams.rotation3D = (Vector3)0;
			Vector3 insideUnitSphere3 = UnityEngine.Random.insideUnitSphere;
			float num20 = num17 * 1.1442586E+09f;
			float num21 = num18 * 1.1442586E+09f;
			float num22 = num19 * 1.1442586E+09f;
			emitParams.angularVelocity3D = (Vector3)0;
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v30+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v30+A0]");
			object obj10 = 0;
			float value = UnityEngine.Random.value;
			if (value < 0f || !((double)value > 1.0))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v17+10]");
				nint num23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v17+20]");
				object obj11 = num23 - 0;
				object obj12 = obj11 * obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v17+20]");
				object obj14 = 0 + obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B470");
				emitParams.startColor = startColor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
				nint num24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
				startLifetime = UnityEngine.Random.Range(num24, 0f);
			}
			emitParams.startLifetime = startLifetime;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			chips.Emit((ParticleSystem.EmitParams)(&obj15), 1);
			vector2--;
			flag3 = vector2 != (Vector3)(object)1;
			num = 1;
		}
		while (flag3);
	}

	public unsafe void Puff(Vector3 at, Vector3 outward, Vector3 side, float width, int count, float force = default(float))
	{
		//IL_0253: Invalid comparison between VT and I4
		//IL_0046: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_0410: Expected VT, but got I4
		//IL_0089: Expected F4, but got I
		//IL_0089: Expected F4, but got I
		//IL_00aa: Expected F4, but got I
		//IL_00aa: Expected F4, but got I
		//IL_028e: Expected Obj, but got I
		//IL_02c2: Expected F4, but got I
		//IL_0309: Expected VT, but got I4
		//IL_0326: Expected F4, but got I
		//IL_0326: Expected F4, but got I
		//IL_0119: Expected VT, but got I4
		//IL_0165: Expected VT, but got I4
		//IL_018f: Expected Obj, but got I4
		//IL_033f: Expected Obj, but got I
		//IL_0351: Invalid comparison between F4 and I4
		//IL_0382: Expected Obj, but got I
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		//IL_03d5: Expected F4, but got I
		//IL_0203: Expected VT, but got Ref
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected VT, but got Unknown
		//IL_021f: Invalid comparison between VT and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		if (at < (object)1 || !Ensure())
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C90]");
		object obj2 = 0;
		int num = 144;
		Vector3 vector = at;
		ParticleSystem.EmitParams emitParams = default;
		object obj4 = default;
		object obj6 = default;
		object obj7 = default;
		object obj13 = default;
		Color32 startColor = default;
		float startLifetime = default;
		object obj15 = default;
		bool flag2;
		do
		{
			float num2 = UnityEngine.Random.Range(-0.5f, 0.5f);
			Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
			emitParams.position = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
			float num4 = UnityEngine.Random.Range(num3, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			float num6 = UnityEngine.Random.Range(num5, 0f);
			object obj3 = obj;
			float num7 = (float)obj4 * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v12+A0]");
			object obj5 = 0;
			float num8 = (float)obj6 * num6;
			float num9 = num7 + num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			float num10 = UnityEngine.Random.Range(0f, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v13+20]");
			float num11 = 0f * num10;
			float num12 = num9 + num11;
			float num13 = num12 * (float)obj7;
			emitParams.velocity = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA90]");
			float num15 = (emitParams.startSize = UnityEngine.Random.Range(num14, 0f));
			Vector3 insideUnitSphere2 = UnityEngine.Random.insideUnitSphere;
			float num17 = num15 * 1.1274813E+09f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA90]");
			float num18 = 0f * 1.1274813E+09f;
			float num19 = num13 * 1.1274813E+09f;
			emitParams.rotation3D = (Vector3)0;
			Vector3 insideUnitSphere3 = UnityEngine.Random.insideUnitSphere;
			float num20 = num17 * 1.1230249E+09f;
			float num21 = num18 * 1.1230249E+09f;
			float num22 = num19 * 1.1230249E+09f;
			emitParams.angularVelocity3D = (Vector3)0;
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X0_v28+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X0_v28+A0]");
			object obj10 = 0;
			float value = UnityEngine.Random.value;
			if (value < 0f || !((double)value > 1.0))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v15+30]");
				nint num23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v15+40]");
				object obj11 = num23 - 0;
				object obj12 = obj11 * obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v15+40]");
				object obj14 = 0 + obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B470");
				emitParams.startColor = startColor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
				startLifetime = UnityEngine.Random.Range(0.5f, 0f);
			}
			emitParams.startLifetime = startLifetime;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			dust.Emit((ParticleSystem.EmitParams)(&obj15), 1);
			vector--;
			flag2 = vector != (Vector3)(object)1;
			num = 1;
		}
		while (flag2);
	}

	private static Vector3 Side(Vector3 outward)
	{
		//IL_006c: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_01b0: Expected Obj, but got I
		//IL_01b8: Expected VT, but got Obj
		//IL_01da: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+18]");
		object obj5 = default;
		object obj4 = obj5 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+1C]");
		object obj6 = obj5 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+20]");
		object obj8 = default;
		object obj7 = obj8 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+20]");
		object obj10 = default;
		object obj9 = obj10 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+1C]");
		object obj11 = obj10 * 0;
		object obj12 = obj6 - obj7;
		object obj13 = obj9 - obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+18]");
		object obj14 = obj8 * 0;
		object obj15 = obj14 - obj11;
		object obj16 = obj12 * obj12;
		object obj17 = obj13 * obj13;
		object obj18 = obj16 + obj17;
		object obj19 = obj15 * obj15;
		object obj20 = obj19 + obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		Vector3 result = default;
		if ((nint)obj20 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj21 = 0;
			result = (Vector3)obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v2 (UnityEngine.Vector3)+E4]");
			bool flag = (nint)0 == 0;
			object obj22 = !flag;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+18]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if (num <= 0)
			{
			}
		}
		return result;
	}

	private unsafe bool Ensure()
	{
		//IL_0010: Expected Obj, but got I
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected Obj, but got Unknown
		//IL_08da: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I4
		//IL_0900: Expected Obj, but got I
		//IL_0922: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I4
		//IL_097f: Expected Obj, but got I
		//IL_09a1: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I4
		//IL_0940: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I4
		//IL_09c7: Expected Obj, but got I
		//IL_09e9: Expected Obj, but got I4
		//IL_027b: Expected Obj, but got I
		//IL_0441: Expected Obj, but got I
		//IL_08a5: Expected I4, but got Obj
		//IL_02d7: Expected Obj, but got I
		//IL_04ab: Expected Obj, but got Ref
		//IL_04f3: Expected Obj, but got I8
		//IL_0335: Expected Obj, but got I4
		//IL_0a0d: Expected Obj, but got I
		//IL_0a2f: Expected Obj, but got I
		//IL_0a59: Expected Obj, but got I4
		//IL_055c: Expected Obj, but got I4
		//IL_056c: Expected Obj, but got I4
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected Obj, but got Unknown
		//IL_0406: Expected Obj, but got I4
		//IL_05b5: Expected Obj, but got I
		//IL_03b9: Expected Obj, but got I4
		//IL_05f4: Expected Obj, but got I
		//IL_0618: Expected F4, but got I
		//IL_06d7: Expected Obj, but got I8
		//IL_0739: Expected Obj, but got I4
		//IL_0749: Expected Obj, but got I4
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected Obj, but got Unknown
		//IL_07ba: Expected Obj, but got I
		//IL_07de: Expected F4, but got I
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected Obj, but got Unknown
		//IL_085c: Expected VT, but got Ref
		//IL_0876: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj3 != null)
		{
			return true;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C90]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v9+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj9 == null;
		bool flag5 = !flag4;
		UnityEngine.Object obj11 = null;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CC8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CB0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
			object obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v47+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v47+A0]");
			object obj16 = 0;
			UnityEngine.Object obj17 = default;
			obj16 = obj17;
			object obj18 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj11 = obj17;
		}
		object obj19 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj19 = obj5;
		}
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v15+A0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v9+E4]");
		bool flag8 = (nint)0 == 0;
		object obj23 = !flag8;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj22 == null)
		{
			return false;
		}
		object obj24 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v20+E4]");
		bool flag9 = (nint)0 == 0;
		object obj25 = !flag9;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj24 = obj5;
		}
		object obj26 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v20+A0]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v11+E4]");
		bool flag10 = (nint)0 == 0;
		object obj28 = !flag10;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X9_v5+8]");
		if (!((UnityEngine.Object)0 == null))
		{
			goto IL_0431;
		}
		GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)3);
		if ((object)gameObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CA0]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
			MeshFilter meshFilter = default;
			if ((object)meshFilter != null)
			{
				Mesh sharedMesh = meshFilter.sharedMesh;
				object obj30 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v38+E4]");
				bool flag11 = (nint)0 == 0;
				object obj31 = !flag11;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj30 = obj5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v38+A0]");
				object obj32 = (nint)0 + (nint)8;
				obj32 = sharedMesh;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
				object obj33 = 0;
				object obj34 = obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X0_v66+E4]");
				bool flag12 = (nint)0 == 0;
				object obj35 = !flag12;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool isPlaying = Application.isPlaying;
				object obj36 = obj;
				if (isPlaying)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X0_v70+E4]");
					bool flag13 = (nint)0 == 0;
					object obj37 = !flag13;
					if (obj37 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(gameObject);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X0_v70+E4]");
					bool flag14 = (nint)0 == 0;
					object obj38 = !flag14;
					if (obj38 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.DestroyImmediate(gameObject);
				}
				goto IL_0431;
			}
		}
		goto IL_0897;
		IL_0897:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0431:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CA8]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Keyframe keyframe = new Keyframe(0f, 1f);
		Keyframe[] array = default;
		if (array != null)
		{
			if (array.Length != 0)
			{
				Keyframe keyframe2 = default;
				object obj40 = (object)(&keyframe2);
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X24_v7+60]");
				_ = 0;
				_ = 0;
				Keyframe keyframe3 = new Keyframe(0.75f, 1f);
				object obj41 = array.Length & 0xFFFFFFFEL;
				if (obj41 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X24_v7+40]");
					_ = 0;
					_ = 0;
					_ = 0;
					Keyframe keyframe4 = new Keyframe(1f, 0f);
					bool flag15 = array.Length < 2;
					object obj42 = !flag15;
					object obj43 = array.Length - 2;
					bool flag16 = obj43 == null;
					object obj44 = ~obj42;
					object obj45 = obj44 | flag16;
					if (obj45 == null)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C98]");
						object obj46 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X24_v7+20]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						AnimationCurve animationCurve = default;
						animationCurve._002Ector(array);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CC0]");
						object obj47 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
						ParticleSystem particleSystem = Make((string)obj47, 0f, 400, collide: true, animationCurve);
						chips = particleSystem;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						keyframe2 = new Keyframe(0f, 0.5f);
						Keyframe[] array2 = default;
						if (array2 == null)
						{
							goto IL_0897;
						}
						if (array2.Length != 0)
						{
							_ = 0;
							_ = 0;
							Keyframe keyframe5 = new Keyframe(0.25f, 1f);
							object obj48 = array2.Length & 0xFFFFFFFEL;
							if (obj48 != null)
							{
								_ = 0;
								_ = 0;
								_ = 0;
								Keyframe keyframe6 = new Keyframe(1f, 0f);
								bool flag17 = array2.Length < 2;
								object obj49 = !flag17;
								object obj50 = array2.Length - 2;
								bool flag18 = obj50 == null;
								object obj51 = ~obj49;
								object obj52 = obj51 | flag18;
								if (obj52 == null)
								{
									_ = 0;
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									AnimationCurve animationCurve2 = default;
									animationCurve2._002Ector(array2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CB8]");
									object obj53 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB64]");
									ParticleSystem particleSystem2 = Make((string)obj53, 0f, 300, collide: false, animationCurve2);
									object obj54 = this + 40;
									obj54 = particleSystem2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									if (obj54 != null)
									{
										ParticleSystem.LimitVelocityOverLifetimeModule limitVelocityOverLifetime = ((ParticleSystem)obj54).limitVelocityOverLifetime;
										ParticleSystem.LimitVelocityOverLifetimeModule limitVelocityOverLifetimeModule = default;
										limitVelocityOverLifetimeModule.enabled = true;
										ParticleSystem.MinMaxCurve minMaxCurve = 0f;
										object obj55 = default;
										limitVelocityOverLifetimeModule.limit = (ParticleSystem.MinMaxCurve)(&obj55);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
										limitVelocityOverLifetimeModule.dampen = 0f;
										return true;
									}
									goto IL_0897;
								}
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		}
		goto IL_0897;
	}

	private unsafe ParticleSystem Make(string name, float gravity, int max, bool collide, AnimationCurve size)
	{
		//IL_0010: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		//IL_010d: Expected VT, but got Ref
		//IL_013f: Expected VT, but got Ref
		//IL_01d4: Expected VT, but got Ref
		//IL_01f1: Expected F8, but got I4
		//IL_01fa: Expected F8, but got I4
		//IL_034a: Expected Obj, but got I
		//IL_0382: Expected Obj, but got I4
		//IL_043b: Expected Obj, but got I
		//IL_0450: Expected Obj, but got I
		//IL_0476: Expected Obj, but got I
		//IL_0257: Expected I4, but got I8
		//IL_028c: Expected F4, but got I
		//IL_02a2: Expected VT, but got Ref
		//IL_02c6: Expected VT, but got Ref
		//IL_02e6: Expected VT, but got Ref
		//IL_0301: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector(name);
		if ((object)gameObject != null)
		{
			Transform transform = gameObject.transform;
			Transform parent = base.transform;
			if ((object)transform != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CD0]");
				object obj2 = 0;
				transform.SetParent(parent, worldPositionStays: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				ParticleSystem particleSystem = default;
				if ((object)particleSystem != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CD8]");
					object obj3 = 0;
					particleSystem.Stop(withChildren: true, (ParticleSystemStopBehavior)0);
					ParticleSystem.MainModule main = particleSystem.main;
					ParticleSystem.MainModule mainModule = default;
					mainModule.playOnAwake = false;
					mainModule.simulationSpace = (ParticleSystemSimulationSpace)1;
					ParticleSystem.MinMaxCurve minMaxCurve = 0f;
					object obj4 = default;
					mainModule.startSpeed = (ParticleSystem.MinMaxCurve)(&obj4);
					mainModule.startRotation3D = true;
					ParticleSystem.MinMaxCurve minMaxCurve2 = gravity;
					object obj5 = default;
					mainModule.gravityModifier = (ParticleSystem.MinMaxCurve)(&obj5);
					mainModule.maxParticles = max;
					ParticleSystem.EmissionModule emission = particleSystem.emission;
					ParticleSystem.EmissionModule emissionModule = default;
					emissionModule.enabled = false;
					ParticleSystem.ShapeModule shape = particleSystem.shape;
					ParticleSystem.ShapeModule shapeModule = default;
					shapeModule.enabled = false;
					ParticleSystem.SizeOverLifetimeModule sizeOverLifetime = particleSystem.sizeOverLifetime;
					ParticleSystem.SizeOverLifetimeModule sizeOverLifetimeModule = default;
					sizeOverLifetimeModule.enabled = true;
					ParticleSystem.MinMaxCurve minMaxCurve3 = new ParticleSystem.MinMaxCurve(1f, size);
					object obj6 = default;
					sizeOverLifetimeModule.size = (ParticleSystem.MinMaxCurve)(&obj6);
					bool flag = !collide;
					double num = 0.0;
					double num2 = 0.0;
					if (!flag)
					{
						ParticleSystem.CollisionModule collision = particleSystem.collision;
						ParticleSystem.CollisionModule collisionModule = default;
						collisionModule.enabled = true;
						collisionModule.type = (ParticleSystemCollisionType)1;
						collisionModule.quality = (ParticleSystemCollisionQuality)2;
						LayerMask collidesWith = -5893;
						collisionModule.collidesWith = collidesWith;
						collisionModule.enableDynamicColliders = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
						ParticleSystem.MinMaxCurve minMaxCurve4 = 0f;
						object obj7 = default;
						collisionModule.bounce = (ParticleSystem.MinMaxCurve)(&obj7);
						ParticleSystem.MinMaxCurve minMaxCurve5 = 0.5f;
						object obj8 = default;
						collisionModule.dampen = (ParticleSystem.MinMaxCurve)(&obj8);
						ParticleSystem.MinMaxCurve minMaxCurve6 = 0f;
						object obj9 = default;
						collisionModule.lifetimeLoss = (ParticleSystem.MinMaxCurve)(&obj9);
						collisionModule.radiusScale = 0.5f;
						num = 0.0;
						num2 = 0.5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
					ParticleSystemRenderer particleSystemRenderer = default;
					if ((object)particleSystemRenderer != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C90]");
						object obj10 = 0;
						particleSystemRenderer.renderMode = (ParticleSystemRenderMode)4;
						object obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v40+E4]");
						bool flag2 = (nint)0 == 0;
						object obj12 = !flag2;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj11 = obj10;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v40+A0]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v8+8]");
						particleSystemRenderer.mesh = (Mesh)0;
						particleSystemRenderer.alignment = (ParticleSystemRenderSpace)1;
						object obj14 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v9+A0]");
						object sharedMaterial = 0;
						particleSystemRenderer.sharedMaterial = (Material)sharedMaterial;
						particleSystemRenderer.shadowCastingMode = (ShadowCastingMode)0;
						particleSystemRenderer.receiveShadows = false;
						particleSystemRenderer.lightProbeUsage = (LightProbeUsage)1;
						particleSystem.Play();
						return particleSystem;
					}
				}
			}
		}
		return (ParticleSystem)(object)new NullReferenceException();
	}

	static Debris()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C90]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107CD10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D420]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107DBA0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107FA50]");
		_ = 0;
	}
}
