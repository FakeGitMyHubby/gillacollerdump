using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class GillaVoxelSplash : MonoBehaviour
{
	public Mesh ball;

	public Mesh drop;

	public Material material;

	public int most = 90;

	private const float Gravity = default(float);

	private static readonly int DotsId;

	private static readonly int BrightId;

	private static GillaVoxelSplash instance;

	private ParticleSystem balls;

	private ParticleSystem drops;

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AB0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA310]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA308]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+A0]");
		object obj6 = (nint)0 + (nint)8;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		ParticleSystem particleSystem = Make((string)obj3, ball);
		object obj7 = this + 64;
		obj7 = particleSystem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		ParticleSystem particleSystem2 = Make((string)obj4, drop);
		object obj8 = this + 72;
		obj8 = particleSystem2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AB0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X9_v1+8]");
		if ((UnityEngine.Object)0 == this)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v8+A0]");
			object obj10 = (nint)0 + (nint)8;
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private unsafe ParticleSystem Make(string name, Mesh mesh)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0371: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I
		//IL_0187: Expected Obj, but got I
		//IL_022b: Expected VT, but got Ref
		//IL_029d: Expected Obj, but got I
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
		bool flag2 = mesh == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		ParticleSystem result = null;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = material == null;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			result = null;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				GameObject gameObject = default;
				gameObject._002Ector(name);
				if ((object)gameObject != null)
				{
					Transform transform = gameObject.transform;
					Transform parent = base.transform;
					if ((object)transform != null)
					{
						transform.SetParent(parent, worldPositionStays: false);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CD0]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
						ParticleSystem particleSystem = default;
						if ((object)particleSystem != null)
						{
							particleSystem.Stop(withChildren: true, (ParticleSystemStopBehavior)0);
							ParticleSystem.MainModule main = particleSystem.main;
							ParticleSystem.MainModule mainModule = default;
							mainModule.loop = false;
							mainModule.playOnAwake = false;
							mainModule.simulationSpace = (ParticleSystemSimulationSpace)1;
							ParticleSystem.MinMaxCurve minMaxCurve = 1f;
							object obj10 = default;
							mainModule.gravityModifier = (ParticleSystem.MinMaxCurve)(&obj10);
							mainModule.maxParticles = most;
							mainModule.startRotation3D = false;
							ParticleSystem.EmissionModule emission = particleSystem.emission;
							ParticleSystem.EmissionModule emissionModule = default;
							emissionModule.enabled = false;
							ParticleSystem.ShapeModule shape = particleSystem.shape;
							ParticleSystem.ShapeModule shapeModule = default;
							shapeModule.enabled = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CD8]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
							ParticleSystemRenderer particleSystemRenderer = default;
							if ((object)particleSystemRenderer != null)
							{
								particleSystemRenderer.renderMode = (ParticleSystemRenderMode)4;
								particleSystemRenderer.mesh = mesh;
								particleSystemRenderer.sharedMaterial = material;
								particleSystemRenderer.shadowCastingMode = (ShadowCastingMode)0;
								particleSystemRenderer.receiveShadows = false;
								particleSystemRenderer.alignment = (ParticleSystemRenderSpace)1;
								result = particleSystem;
								goto IL_0334;
							}
						}
					}
				}
				return (ParticleSystem)(object)new NullReferenceException();
			}
		}
		goto IL_0334;
		IL_0334:
		return result;
	}

	public static void Emit(Vector3 at, float strength)
	{
		//IL_0010: Expected Obj, but got I
		//IL_06e2: Expected Obj, but got I
		//IL_0704: Expected Obj, but got I4
		//IL_0994: Expected Obj, but got I
		//IL_09b6: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_0061: Expected F8, but got I
		//IL_0071: Invalid comparison between F8 and I
		//IL_0082: Expected Obj, but got I4
		//IL_00a2: Invalid comparison between F8 and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00e6: Expected Obj, but got I4
		//IL_00fd: Invalid comparison between F8 and I4
		//IL_010c: Expected F8, but got I4
		//IL_0722: Expected Obj, but got I
		//IL_074c: Expected Obj, but got I4
		//IL_018f: Expected VT, but got I4
		//IL_0784: Expected Obj, but got I4
		//IL_02e3: Expected Obj, but got I4
		//IL_07bc: Expected Obj, but got I4
		//IL_0269: Expected Obj, but got I4
		//IL_029e: Expected Obj, but got I
		//IL_02ab: Expected I4, but got Obj
		//IL_02c0: Expected Obj, but got I4
		//IL_03c6: Expected Obj, but got I4
		//IL_07f4: Expected Obj, but got I4
		//IL_0351: Expected Obj, but got I4
		//IL_09d4: Expected Obj, but got I
		//IL_09e4: Expected Obj, but got I
		//IL_0386: Expected Obj, but got I
		//IL_03a8: Expected Obj, but got I4
		//IL_03b8: Expected Obj, but got I
		//IL_03f0: Invalid comparison between F8 and I4
		//IL_03ff: Expected F8, but got I4
		//IL_09f9: Expected Obj, but got I
		//IL_0a23: Expected Obj, but got I4
		//IL_046d: Invalid comparison between F8 and I4
		//IL_08a6: Expected VT, but got F8
		//IL_08a6: Expected Obj, but got I
		//IL_08be: Expected Obj, but got I
		//IL_08ce: Expected Obj, but got I
		//IL_0561: Invalid comparison between F8 and I4
		//IL_0570: Expected F8, but got I4
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Expected Obj, but got Unknown
		//IL_0866: Expected Obj, but got I4
		//IL_0a5b: Expected Obj, but got I4
		//IL_05de: Invalid comparison between F8 and I4
		//IL_0977: Expected VT, but got F8
		//IL_0977: Expected Obj, but got I
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Expected Obj, but got Unknown
		//IL_0937: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AB0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v1+8]");
		bool flag3 = (UnityEngine.Object)0 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		double num = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		double num2 = default;
		bool flag4 = num2 < 0.0;
		object obj8 = !flag4;
		double num3 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		double num4 = num3 - 0.0;
		bool flag5 = num4 == 0.0;
		object obj9 = ~obj8;
		object obj10 = obj9 | flag5;
		if (obj10 != null)
		{
			return;
		}
		bool flag6 = !flag3;
		object obj11 = !flag6;
		if (obj11 != null)
		{
			return;
		}
		bool flag7 = num2 < 0.0;
		double num5 = 0.0;
		if (!flag7)
		{
			bool flag8 = !(num2 > 1.0);
			num5 = num2;
			num = 1.0;
			if (!flag8)
			{
				num5 = 1.0;
				num = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
		object obj12 = 0;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v8+E4]");
		bool flag9 = (nint)0 == 0;
		object obj14 = !flag9;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaSplashPool gillaSplashPool = GillaSplashPool.Near((Vector3)0, strength);
		Material material;
		if ((object)gillaSplashPool != null && (object)gillaSplashPool.surface != null)
		{
			Material sharedMaterial = gillaSplashPool.surface.sharedMaterial;
			UnityEngine.Object obj15 = null;
			material = sharedMaterial;
		}
		else
		{
			UnityEngine.Object obj15 = null;
			material = null;
		}
		object obj16 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v13+E4]");
		bool flag10 = (nint)0 == 0;
		object obj17 = !flag10;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (material != null)
		{
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v53+E4]");
			bool flag11 = (nint)0 == 0;
			object obj19 = !flag11;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v40+A0]");
			object obj21 = 0;
			Color color = material.GetColor((int)obj21);
			double num6 = strength;
			object obj22 = 0;
			UnityEngine.Object obj23 = (UnityEngine.Object)obj21;
		}
		else
		{
			double num6 = 1.0;
			object obj22 = 0;
			UnityEngine.Object obj23 = null;
		}
		object obj24 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v18+E4]");
		bool flag12 = (nint)0 == 0;
		object obj25 = !flag12;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (material != null)
		{
			object obj26 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v45+E4]");
			bool flag13 = (nint)0 == 0;
			object obj27 = !flag13;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj28 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v36+A0]");
			object obj29 = 0;
			Material material2 = material;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v37+4]");
			Color color2 = material2.GetColor(0);
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v37+4]");
			UnityEngine.Object obj31 = (UnityEngine.Object)0;
		}
		else
		{
			object obj30 = 0;
			UnityEngine.Object obj31 = null;
		}
		object obj32 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v24+E4]");
		bool flag14 = (nint)0 == 0;
		object obj33 = !flag14;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj32 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v24+A0]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v15+8]");
		object obj35 = 0;
		bool flag15 = num5 < 0.0;
		double num7 = 0.0;
		if (!flag15)
		{
			bool flag16 = !(num5 > 1.0);
			num7 = num5;
			if (!flag16)
			{
				num7 = 1.0;
			}
		}
		double num8 = num7 * 14.0;
		double num9 = num8 + 2.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj36 = 0;
		object obj37 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X0_v26+E4]");
		bool flag17 = (nint)0 == 0;
		object obj38 = !flag17;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num10;
		double num11;
		double num12 = default;
		if (num9 < 0.0)
		{
			if (num9 == -0.5)
			{
				num10 = -1.0;
				num11 = num12;
				goto IL_082f;
			}
			num11 = num9 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (num9 == 0.5)
			{
				num10 = 1.0;
				num11 = num12;
				goto IL_082f;
			}
			num11 = num9 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_0879;
		IL_0879:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v16+40]");
		GillaVoxelSplash gillaVoxelSplash = default;
		int count = default;
		float small = default;
		float big = default;
		Color colour = default;
		gillaVoxelSplash.Burst((ParticleSystem)0, (Vector3)num11, strength, count, small, big, colour);
		object obj39 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X8_v23+A0]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v24+8]");
		object obj41 = 0;
		bool flag18 = num5 < 0.0;
		double num13 = 0.0;
		if (!flag18)
		{
			bool flag19 = !(num5 > 1.0);
			num13 = num5;
			if (!flag19)
			{
				num13 = 1.0;
			}
		}
		double num14 = num13 * 30.0;
		double num15 = num14 + 4.0;
		object obj42 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X0_v31+E4]");
		bool flag20 = (nint)0 == 0;
		object obj43 = !flag20;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num16;
		double num17;
		if (num15 < 0.0)
		{
			if (num15 == -0.5)
			{
				num16 = -1.0;
				num17 = num12;
				goto IL_0900;
			}
			num17 = num15 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (num15 == 0.5)
			{
				num16 = 1.0;
				num17 = num12;
				goto IL_0900;
			}
			num17 = num15 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_094a;
		IL_082f:
		double num18 = num11 + num10;
		object obj44 = num11 & 1;
		bool flag21 = obj44 == null;
		object obj45 = !flag21;
		if (obj45 != null)
		{
			num11 = num18;
		}
		goto IL_0879;
		IL_0900:
		double num19 = num17 + num16;
		object obj46 = num17 & 1;
		bool flag22 = obj46 == null;
		object obj47 = !flag22;
		if (obj47 != null)
		{
			num17 = num19;
		}
		goto IL_094a;
		IL_094a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v25+48]");
		GillaVoxelSplash gillaVoxelSplash2 = default;
		gillaVoxelSplash2.Burst((ParticleSystem)0, (Vector3)num17, strength, count, small, big, colour);
	}

	private unsafe void Burst(ParticleSystem ps, Vector3 at, float strength, int count, float small, float big, Color colour)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03d9: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0063: Invalid comparison between F8 and I4
		//IL_00b5: Invalid comparison between F8 and I4
		//IL_00c4: Invalid comparison between F8 and I4
		//IL_00dc: Expected Obj, but got F8
		//IL_00e9: Expected Obj, but got F8
		//IL_011e: Expected Obj, but got I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_008a: Expected F8, but got I
		//IL_0093: Expected F8, but got I4
		//IL_03f0: Invalid comparison between VT and I4
		//IL_0193: Invalid comparison between F8 and I4
		//IL_01a2: Invalid comparison between F8 and I4
		//IL_01ba: Expected Obj, but got F8
		//IL_01c7: Expected Obj, but got F8
		//IL_0213: Expected Obj, but got I4
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_048f: Expected F8, but got I
		//IL_04e5: Invalid comparison between F8 and I4
		//IL_0266: Expected F8, but got I
		//IL_052c: Expected F4, but got I
		//IL_0286: Expected VT, but got I4
		//IL_0294: Expected VT, but got I4
		//IL_0324: Expected VT, but got I4
		//IL_0361: Expected VT, but got Ref
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected VT, but got Unknown
		//IL_037d: Invalid comparison between VT and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+E4]");
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
		double num = default;
		double num2;
		double num3;
		if (num < 0.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
			num2 = 0.0;
			num3 = 0.0;
		}
		else
		{
			double num4 = num - 1.0;
			bool flag4 = num4 < 0.0;
			bool flag5 = num4 == 0.0;
			object obj5 = num ^ 1.0;
			object obj6 = num ^ num4;
			object obj7 = obj5 & obj6;
			bool flag6 = (nint)obj7 < 0;
			bool flag7 = flag4 == flag6;
			object obj8 = !flag5;
			object obj9 = flag7 & obj8;
			object obj10 = ~obj9;
			double num5 = ((obj10 != null) ? num : 1.0);
			double num6 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAF4]");
			double num7 = num6 * 0.0;
			double num8 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
			double num9 = num8 + 0.0;
			bool flag8 = num > 1.0;
			num2 = num9;
			num3 = 1.0;
			if (!flag8)
			{
				num2 = num9;
				num3 = num;
			}
		}
		if (at >= (object)1)
		{
			double num10 = num - 1.0;
			bool flag9 = num10 < 0.0;
			bool flag10 = num10 == 0.0;
			object obj11 = num ^ 1.0;
			object obj12 = num ^ num10;
			object obj13 = obj11 & obj12;
			bool flag11 = (nint)obj13 < 0;
			double num11 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA18]");
			double num12 = num11 * 0.0;
			bool flag12 = flag9 == flag11;
			object obj14 = !flag10;
			object obj15 = flag12 & obj14;
			object obj16 = ~obj15;
			double num13 = ((obj16 != null) ? num : 1.0);
			double num14 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
			double num15 = num14 + 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			double num16 = 0.0;
			double num17 = num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF94]");
			double num18 = num17 * 0.0;
			double num19 = num15 * 0.0;
			double num20 = num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			double num21 = num20 + 0.0;
			float num22 = small + (float)num19;
			double num23;
			if (num < 0.0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
				num23 = 0.0;
			}
			else
			{
				num23 = num21;
			}
			Vector3 vector = at;
			ParticleSystem.EmitParams emitParams = default;
			float minInclusive = default;
			float maxInclusive = default;
			Color32 startColor = default;
			object obj17 = default;
			bool flag13;
			float num30 = default;
			double num31 = default;
			do
			{
				Vector2 insideUnitCircle = UnityEngine.Random.insideUnitCircle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
				float num24 = UnityEngine.Random.Range(0f, 1f);
				float num25 = (float)num2 * num24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
				emitParams.position = (Vector3)0;
				emitParams.velocity = (Vector3)0;
				float num26 = UnityEngine.Random.Range(minInclusive, maxInclusive);
				float startSize = num26 * (float)num23;
				emitParams.startSize = startSize;
				float num27 = num25 + num25;
				float num28 = num27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A92C]");
				float startLifetime = num28 / 0f;
				emitParams.startLifetime = startLifetime;
				float num29 = UnityEngine.Random.Range(0f, 360f);
				emitParams.rotation3D = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B470");
				emitParams.startColor = startColor;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				ps.Emit((ParticleSystem.EmitParams)(&obj17), 1);
				vector--;
				flag13 = vector != (Vector3)(object)1;
				num22 = num30;
				num16 = num31;
			}
			while (flag13);
		}
	}

	static GillaVoxelSplash()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA318]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AB0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA320]");
		object obj3 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+A0]");
		object obj5 = 0;
		obj5 = num;
		int num2 = Shader.PropertyToID((string)obj3);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v5+A0]");
		object obj7 = 0;
	}
}
