using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.Rendering;

public class GillaOreFX
{
	private readonly GillaOreVeins veins;

	private ParticleSystem chips;

	private ParticleSystem flares;

	private ParticleSystem sparks;

	private bool made;

	public GillaOreFX(GillaOreVeins veins)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		object obj = this + 16;
		obj = veins;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public unsafe void Hit(GillaOre ore, GillaOre.Kind kind, Vector3 at, Vector3 normal)
	{
		//IL_0010: Expected Obj, but got I
		//IL_043a: Expected Obj, but got I4
		//IL_04a0: Expected Obj, but got I
		//IL_04d0: Expected F4, but got I4
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0090: Expected F4, but got I4
		//IL_00ac: Expected Obj, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00d7: Expected F4, but got I
		//IL_00e7: Expected F4, but got I
		//IL_00f7: Expected F4, but got I
		//IL_010d: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_0458: Expected Obj, but got I
		//IL_0482: Expected Obj, but got I4
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_01bc: Expected F4, but got I
		//IL_01cc: Expected F4, but got I
		//IL_01e6: Expected VT, but got I4
		//IL_021e: Expected Obj, but got I4
		//IL_02d9: Expected F4, but got I
		//IL_02d9: Expected I4, but got VT
		//IL_02d9: Expected VT, but got I4
		//IL_02d9: Expected VT, but got Ref
		//IL_02e1: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5130]");
		object obj = 0;
		NullReferenceException ex = (NullReferenceException)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v6 (System.NullReferenceException)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ex = (NullReferenceException)obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v6 (System.NullReferenceException)+A0]");
		object obj3 = 0;
		object obj4 = obj3;
		bool flag2 = obj3 == null;
		float num2 = default;
		float num = num2;
		float num4 = default;
		float num3 = num4;
		float num5 = 0f;
		if (flag2)
		{
			goto IL_034b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v6+18]");
		GillaOre.Kind kind2 = default;
		bool flag3 = (nint)0 < (nint)(int)kind2;
		object obj5 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v6+18]");
		object obj6 = -(int)kind2;
		bool flag4 = obj6 == null;
		object obj7 = ~obj5;
		object obj8 = obj7 | flag4;
		num5 = 0f;
		if (obj8 != null)
		{
			goto IL_03a0;
		}
		object obj9 = kind2 & (GillaOre.Kind)0xFF;
		object obj10 = obj9 * 72;
		object obj11 = obj3 + obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v12+30]");
		num3 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v12+40]");
		num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v12+55]");
		num5 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v12+54]");
		object obj12 = (nint)0 & (nint)1;
		bool flag5 = obj12 == null;
		object obj13 = !flag5;
		object clips;
		if (obj13 == null)
		{
			if ((object)veins == null)
			{
				goto IL_034b;
			}
			clips = veins + 96;
		}
		else
		{
			if ((object)veins == null)
			{
				goto IL_034b;
			}
			clips = veins + 112;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v9+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		float num6 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
		float num7 = 0f;
		float num8 = default;
		Sfx.Play((AudioClip[])clips, (Vector3)0, num8, num4, num2);
		bool flag7 = Make();
		bool flag8 = !flag7;
		GillaOre gillaOre = null;
		float num9 = 1f;
		IndexOutOfRangeException ex2 = (IndexOutOfRangeException)flag7;
		if (!flag8)
		{
			float num11 = default;
			float num10 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
			float num12 = num10 * 0f;
			float num14 = default;
			float num13 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
			float num15 = num13 * 0f;
			float num17 = default;
			float num16 = num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
			float num18 = num16 * 0f;
			num8 += num12;
			num4 += num15;
			num2 += num18;
			float size = num8;
			float size2 = num4;
			float life = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
			object obj17 = default;
			Chips((Vector3)(&obj17), (Vector3)6, (GillaOreVeins.Look)at, (int)normal, size, size2, life, num11, num14, num17, 0f);
			gillaOre = (GillaOre)(&obj17);
			num7 = num17;
			num6 = num14;
			num9 = num11;
			ex2 = (IndexOutOfRangeException)(object)this;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		bool flag9 = num19 != 0;
		num = num2;
		num3 = num4;
		num5 = num8;
		if (!flag9)
		{
			return;
		}
		goto IL_0405;
		IL_03a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		bool flag10 = num20 != 0;
		num = num2;
		num3 = num4;
		ex2 = (IndexOutOfRangeException)(object)ex;
		if (!flag10)
		{
			ex2 = new IndexOutOfRangeException();
			num = num2;
			num3 = num4;
		}
		goto IL_0405;
		IL_034b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		bool flag11 = num21 != 0;
		ex2 = (IndexOutOfRangeException)(object)ex;
		if (!flag11)
		{
			ex = new NullReferenceException();
			num2 = num;
			num4 = num3;
			goto IL_03a0;
		}
		goto IL_0405;
		IL_0405:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
	}

	public unsafe void Break(GillaOre ore, GillaOre.Kind kind, Vector3 at, Vector3 normal)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0018: Expected Obj, but got I
		//IL_0c4a: Expected I4, but got Obj
		//IL_0c6c: Expected Obj, but got I4
		//IL_0c8a: Expected Obj, but got I
		//IL_0b66: Expected Obj, but got I4
		//IL_002f: Expected I4, but got Obj
		//IL_0055: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got Ref
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I
		//IL_0104: Expected F4, but got I
		//IL_0141: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I4
		//IL_021a: Expected F4, but got I
		//IL_01b0: Expected F4, but got I
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0cf5: Expected Obj, but got I
		//IL_0d1f: Expected Obj, but got I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_025c: Expected F4, but got I
		//IL_026c: Expected F4, but got I
		//IL_0286: Expected VT, but got I4
		//IL_02c7: Expected Obj, but got I4
		//IL_02e5: Expected Obj, but got I
		//IL_030f: Expected Obj, but got I4
		//IL_0d69: Expected F4, but got I
		//IL_0d79: Expected F4, but got I
		//IL_0db4: Expected F4, but got I
		//IL_0db4: Expected I4, but got VT
		//IL_0db4: Expected VT, but got I4
		//IL_0db4: Expected VT, but got Ref
		//IL_0df9: Expected Obj, but got I4
		//IL_0e56: Expected VT, but got I4
		//IL_0e0c: Expected VT, but got I4
		//IL_0e29: Expected F4, but got I
		//IL_0e29: Expected F4, but got I
		//IL_0524: Expected F4, but got I
		//IL_0524: Expected F4, but got I
		//IL_0406: Expected I4, but got Obj
		//IL_0578: Expected Obj, but got VT
		//IL_0475: Expected I4, but got Obj
		//IL_05dc: Expected VT, but got Ref
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected Obj, but got Unknown
		//IL_060a: Expected VT, but got I4
		//IL_0631: Expected Obj, but got I
		//IL_0736: Expected VT, but got I4
		//IL_0757: Expected F4, but got I
		//IL_0760: Expected Obj, but got I4
		//IL_1010: Invalid comparison between F4 and I
		//IL_077b: Expected F4, but got I4
		//IL_0e6b: Invalid comparison between F4 and I
		//IL_0796: Expected F4, but got I4
		//IL_0e92: Invalid comparison between F4 and I
		//IL_07b1: Expected F4, but got I4
		//IL_0eb7: Expected VT, but got I4
		//IL_1051: Expected Obj, but got I4
		//IL_0857: Invalid comparison between F4 and I
		//IL_0eea: Expected VT, but got I4
		//IL_0f07: Expected F4, but got I
		//IL_0f07: Expected F4, but got I
		//IL_089d: Expected F4, but got I
		//IL_089d: Expected F4, but got I
		//IL_0f51: Expected Obj, but got VT
		//IL_0f69: Expected F4, but got I
		//IL_095c: Expected VT, but got Ref
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_096f: Expected Obj, but got Unknown
		//IL_098a: Expected VT, but got I4
		//IL_09a3: Expected F4, but got I
		//IL_09dd: Expected VT, but got I4
		//IL_09ee: Expected Obj, but got Ref
		//IL_0a06: Expected F4, but got I
		//IL_0a10: Expected I4, but got Obj
		//IL_0a48: Expected Obj, but got I4
		//IL_0a75: Expected F4, but got I
		//IL_0a85: Expected F4, but got I
		//IL_0aa4: Expected VT, but got I4
		//IL_0ab5: Expected VT, but got I4
		//IL_0ad3: Expected F8, but got I
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5130]");
		object obj3 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		bool flag = (byte)(int)obj3 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v10 (System.Boolean)+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			flag = (byte)(int)obj3 != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v10 (System.Boolean)+A0]");
		object obj5 = 0;
		object obj6 = obj5;
		bool flag3 = obj5 == null;
		int num = 144;
		UnityEngine.Object obj7 = null;
		float num3 = default;
		float num2 = num3;
		float num5 = default;
		float num4 = num5;
		double num7 = default;
		double num6 = num7;
		float num9 = default;
		float num8 = num9;
		float num11 = default;
		float num10 = num11;
		NullReferenceException ex;
		object obj14 = default;
		object obj19;
		float num13;
		float num14;
		float num15;
		float num12 = default;
		IndexOutOfRangeException ex2;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v6+18]");
			bool flag4 = (nint)0 < (nint)(int)kind;
			object obj8 = !flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v6+18]");
			object obj9 = -(int)kind;
			bool flag5 = obj9 == null;
			object obj10 = ~obj8;
			object obj11 = obj10 | flag5;
			num = 144;
			obj7 = null;
			ex = (NullReferenceException)flag;
			if (obj11 != null)
			{
				goto IL_0b92;
			}
			object obj12 = kind & (GillaOre.Kind)0xFF;
			object obj13 = (object)(&obj14);
			object obj15 = obj12 * 72;
			object obj16 = obj5 + obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X9_v8+55]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X9_v8+44]");
			num10 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X9_v8+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X9_v8+64]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X9_v8+44]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X9_v8+54]");
			object obj17 = (nint)0 & (nint)1;
			bool flag6 = obj17 == null;
			object obj18 = !flag6;
			object clips;
			if (obj18 == null)
			{
				bool flag7 = (object)veins == null;
				num = 144;
				obj7 = null;
				num2 = num3;
				num4 = num5;
				num6 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X9_v8+28]");
				num8 = 0f;
				if (flag7)
				{
					goto IL_0b3d;
				}
				clips = veins + 104;
			}
			else
			{
				bool flag8 = (object)veins == null;
				num = 144;
				obj7 = null;
				num2 = num3;
				num4 = num5;
				num6 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X9_v8+28]");
				num8 = 0f;
				if (flag8)
				{
					goto IL_0b3d;
				}
				clips = veins + 120;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			obj19 = 0;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X0_v12+E4]");
			bool flag9 = (nint)0 == 0;
			object obj21 = !flag9;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			num4 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
			num2 = 0f;
			Sfx.Play((AudioClip[])clips, (Vector3)0, num11, num9, num12);
			bool flag10 = Make();
			bool flag11 = !flag10;
			num = 144;
			obj7 = null;
			num6 = 1.0;
			ex2 = (IndexOutOfRangeException)flag10;
			if (flag11)
			{
				goto IL_0afd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj22 = 0;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v18+E4]");
			bool flag12 = (nint)0 == 0;
			object obj24 = !flag12;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			flag = ore != null;
			bool flag13 = !flag;
			num13 = num11;
			num14 = num9;
			num15 = num12;
			if (flag13)
			{
				goto IL_0d2d;
			}
			bool flag14 = (object)ore == null;
			num = 0;
			obj7 = null;
			num6 = 1.0;
			num8 = num9;
			num10 = num11;
			if (!flag14)
			{
				Transform transform = ore.transform;
				bool flag15 = (object)transform == null;
				num = 0;
				obj7 = null;
				num6 = 1.0;
				num8 = num9;
				num10 = num11;
				flag = (byte)(int)transform != 0;
				if (!flag15)
				{
					Vector3 position = transform.position;
					Transform transform2 = ore.transform;
					bool flag16 = (object)transform2 == null;
					num = 0;
					obj7 = null;
					num6 = 1.0;
					num8 = num9;
					num10 = num11;
					flag = (byte)(int)transform2 != 0;
					if (!flag16)
					{
						Vector3 up = transform2.up;
						float num16 = num11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEBC]");
						float num17 = num16 * 0f;
						float num18 = num9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEBC]");
						float num19 = num18 * 0f;
						float num20 = num12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEBC]");
						float num21 = num20 * 0f;
						num13 = num11 + num17;
						num14 = num9 + num19;
						num15 = num12 + num21;
						goto IL_0d2d;
					}
				}
			}
		}
		goto IL_0b3d;
		IL_0d2d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X25_v5+D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X9_v8+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X25_v5+E4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
		float num22 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A95C]");
		float num23 = 0f;
		Vector3 vector = default;
		Vector3 look = vector;
		float size = num13;
		float size2 = num14;
		float life = num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
		Chips((Vector3)(&obj14), (Vector3)64, (GillaOreVeins.Look)look, (int)normal, size, size2, life, (float)num7, num5, num3, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X9_v8+28]");
		float num24 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X9_v8+28]");
		float num25 = num24 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		int num26 = 144;
		object obj25 = 4;
		ParticleSystem.EmitParams emitParams = default;
		Color32 color = default;
		double num29 = default;
		float num30 = default;
		float num31 = default;
		object obj26 = default;
		while (true)
		{
			Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
			emitParams.position = (Vector3)0;
			emitParams.velocity = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEBC]");
			nint num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB8]");
			float startLifetime = UnityEngine.Random.Range(num27, 0f);
			emitParams.startLifetime = startLifetime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			float startSize = UnityEngine.Random.Range(num28, 0f);
			emitParams.startSize = startSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B470");
			emitParams.startColor = color;
			bool flag17 = (object)flares == null;
			num = 0;
			obj7 = (UnityEngine.Object)color;
			num2 = num3;
			num4 = num25;
			num6 = num29;
			num12 = num30;
			num8 = num31;
			num10 = num25;
			flag = (byte)(&emitParams) != 0;
			if (flag17)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			flares.Emit((ParticleSystem.EmitParams)(&obj26), 1);
			obj25--;
			bool flag18 = (nint)obj25 != 1;
			vector = (Vector3)0;
			num26 = 1;
			if (flag18)
			{
				continue;
			}
			goto IL_0621;
		}
		goto IL_0b3d;
		IL_0621:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj27 = 0;
		double num32 = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		double num33 = num32 * 0.0;
		float num34 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		float num35 = num34 * 0f;
		float num36 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		float num37 = num36 * 0f;
		float num38 = (float)num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		num12 = num38 * 0f;
		float num39 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num40 = num39 * 0f;
		float num41 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num42 = num41 * 0f;
		double num43 = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		double num44 = num43 * 0.0;
		float num45 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		num23 = num45 * 0f;
		float num46 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		float num47 = num46 * 0f;
		float num48 = num12 + num13;
		float num49 = num40 + num14;
		float num50 = num42 + num15;
		vector = (Vector3)0;
		int num51 = 1;
		num8 = num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD0]");
		num10 = 0f;
		object obj28 = 24;
		Color32 color2 = default;
		object obj31 = default;
		while (true)
		{
			Vector3 insideUnitSphere2 = UnityEngine.Random.insideUnitSphere;
			float num52 = (float)num33 + num10;
			float num53 = num35 + num8;
			float num54 = num37 + num12;
			float num55 = (float)num7 * num52;
			float num56 = num5 * num53;
			float num57 = num55 + num56;
			float num58 = num3 * num54;
			float num59 = num58 + num57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			float num60 = ((!(num59 < 0f)) ? 128f : num23);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			float num61 = ((!(num59 < 0f)) ? 128f : num47);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			float num62 = ((!(num59 < 0f)) ? 128f : ((float)num44));
			emitParams.position = (Vector3)0;
			object obj29 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1065 @ X0_v48+E4]");
			bool flag19 = (nint)0 == 0;
			object obj30 = !flag19;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num63 = num53 + num60;
			float num64 = num52 + num62;
			float num65 = num54 + num61;
			float num66 = num64 * num64;
			float num67 = num63 * num63;
			float num68 = num67 + num66;
			float num69 = num65 * num65;
			float num70 = num69 + num68;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if (num70 > 0f)
			{
			}
			float num71 = UnityEngine.Random.Range(3f, 7.5f);
			emitParams.velocity = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			nint num72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
			float startLifetime2 = UnityEngine.Random.Range(num72, 0f);
			emitParams.startLifetime = startLifetime2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE2C]");
			nint num73 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD0]");
			float startSize2 = UnityEngine.Random.Range(num73, 0f);
			emitParams.startSize = startSize2;
			float value = UnityEngine.Random.value;
			bool flag20 = !((double)value < 0.5);
			num6 = num29;
			num12 = num30;
			num8 = num31;
			num10 = num25;
			if (!flag20)
			{
				num6 = 1.0;
				num12 = 1f;
				num8 = 1f;
				num10 = 1f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B470");
			emitParams.startColor = color2;
			bool flag21 = (object)sparks == null;
			num22 = num5;
			num = 0;
			obj7 = (UnityEngine.Object)color2;
			num2 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			num4 = 0f;
			flag = (byte)(&emitParams) != 0;
			if (flag21)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			sparks.Emit((ParticleSystem.EmitParams)(&obj31), 1);
			obj28--;
			bool flag22 = (nint)obj28 != 1;
			vector = (Vector3)0;
			num51 = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			num40 = 0f;
			if (flag22)
			{
				continue;
			}
			goto IL_09b1;
		}
		goto IL_0b3d;
		IL_0c27:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		return;
		IL_0afd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ SYSREG+28]");
		nint num74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ SYSREG+28]");
		bool flag23 = num74 != 0;
		num8 = num9;
		num10 = num11;
		if (!flag23)
		{
			return;
		}
		goto IL_0c27;
		IL_0b3d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ SYSREG+28]");
		nint num75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ SYSREG+28]");
		bool flag24 = num75 != 0;
		ex2 = (IndexOutOfRangeException)flag;
		if (!flag24)
		{
			ex = new NullReferenceException();
			num9 = num8;
			num11 = num10;
			goto IL_0b92;
		}
		goto IL_0c27;
		IL_0b92:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ SYSREG+28]");
		nint num76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ SYSREG+28]");
		bool flag25 = num76 != 0;
		num2 = num2;
		num4 = num4;
		num6 = num6;
		num8 = num9;
		num10 = num11;
		ex2 = (IndexOutOfRangeException)(object)ex;
		if (!flag25)
		{
			ex2 = new IndexOutOfRangeException();
			num2 = num2;
			num4 = num4;
			num6 = num6;
			num8 = num9;
			num10 = num11;
		}
		goto IL_0c27;
		IL_09b1:
		GillaOreVeins gillaOreVeins = veins;
		bool flag26 = (object)veins == null;
		num22 = num5;
		vector = (Vector3)0;
		num = 1;
		obj7 = (UnityEngine.Object)(&obj31);
		num2 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		num4 = 0f;
		flag = (byte)(int)sparks != 0;
		if (!flag26)
		{
			object obj32 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1141 @ X0_v63+E4]");
			bool flag27 = (nint)0 == 0;
			object obj33 = !flag27;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB8]");
			num4 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B004]");
			num2 = 0f;
			Sfx.Play(gillaOreVeins.dropSounds, (Vector3)0, num13, num14, num15);
			num22 = num5;
			vector = (Vector3)0;
			num = 1;
			obj7 = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			num6 = 0.0;
			num12 = num15;
			num9 = num14;
			num11 = num13;
			ex2 = (IndexOutOfRangeException)(object)gillaOreVeins.dropSounds;
			goto IL_0afd;
		}
		goto IL_0b3d;
	}

	private unsafe void Chips(Vector3 at, Vector3 normal, GillaOreVeins.Look look, int many, float size0, float size1, float life0, float life1, float speed0, float speed1, float spread)
	{
		//IL_0013: Invalid comparison between VT and I4
		//IL_02ef: Expected VT, but got I4
		//IL_0231: Expected VT, but got I4
		//IL_00ec: Expected VT, but got I4
		//IL_0108: Expected VT, but got I4
		//IL_0126: Invalid comparison between F4 and I
		//IL_0154: Expected Obj, but got I4
		//IL_0257: Invalid comparison between F4 and I
		//IL_0146: Expected Obj, but got I4
		//IL_0170: Expected Obj, but got I4
		//IL_027e: Invalid comparison between F4 and I
		//IL_0162: Expected Obj, but got I4
		//IL_018c: Expected Obj, but got I4
		//IL_02a5: Invalid comparison between F4 and I
		//IL_017e: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I4
		//IL_01cb: Expected VT, but got Ref
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected VT, but got Unknown
		//IL_01e7: Invalid comparison between VT and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		if (normal < (object)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		int num = 144;
		Vector3 vector = normal;
		ParticleSystem.EmitParams emitParams = default;
		float minInclusive = default;
		float maxInclusive = default;
		float minInclusive2 = default;
		float maxInclusive2 = default;
		float maxInclusive3 = default;
		Color32 startColor = default;
		object obj5 = default;
		bool flag;
		do
		{
			Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
			emitParams.position = (Vector3)0;
			float num2 = UnityEngine.Random.Range(minInclusive, maxInclusive);
			Vector3 insideUnitSphere2 = UnityEngine.Random.insideUnitSphere;
			float num3 = UnityEngine.Random.Range(minInclusive, maxInclusive);
			float num4 = UnityEngine.Random.Range(0.5f, 2f);
			emitParams.velocity = (Vector3)0;
			float startLifetime = UnityEngine.Random.Range(minInclusive2, maxInclusive2);
			emitParams.startLifetime = startLifetime;
			float startSize = UnityEngine.Random.Range(spread, maxInclusive3);
			emitParams.startSize = startSize;
			float num5 = UnityEngine.Random.Range(0f, 360f);
			float num6 = UnityEngine.Random.Range(0f, 360f);
			float num7 = UnityEngine.Random.Range(0f, 360f);
			emitParams.rotation3D = (Vector3)0;
			Vector3 insideUnitSphere3 = UnityEngine.Random.insideUnitSphere;
			emitParams.angularVelocity3D = (Vector3)0;
			float value = UnityEngine.Random.value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			if (value < 0f)
			{
				object obj = 20;
			}
			else
			{
				object obj = 36;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			if (value < 0f)
			{
				object obj2 = 8;
			}
			else
			{
				object obj2 = 24;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			if (value < 0f)
			{
				object obj3 = 16;
			}
			else
			{
				object obj3 = 32;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			if (value < 0f)
			{
				object obj4 = 12;
			}
			else
			{
				object obj4 = 28;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B470");
			emitParams.startColor = startColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			chips.Emit((ParticleSystem.EmitParams)(&obj5), 1);
			vector--;
			flag = vector != (Vector3)(object)1;
			num = 1;
		}
		while (flag);
	}

	private unsafe bool Make()
	{
		//IL_14a8: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I4
		//IL_1498: Expected I4, but got Obj
		//IL_00bf: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I4
		//IL_06cd: Expected Obj, but got I
		//IL_06f7: Expected Obj, but got I4
		//IL_0724: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I
		//IL_028a: Expected Obj, but got I
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		//IL_02f0: Expected Obj, but got Ref
		//IL_0321: Expected VT, but got Ref
		//IL_03be: Expected VT, but got Ref
		//IL_0467: Expected I4, but got I8
		//IL_049c: Expected VT, but got Ref
		//IL_04b2: Expected F4, but got I
		//IL_04c3: Expected VT, but got Ref
		//IL_0507: Expected Obj, but got I
		//IL_05a8: Expected Obj, but got I
		//IL_05ef: Expected Obj, but got I
		//IL_0606: Expected Obj, but got I
		//IL_0659: Expected Obj, but got I4
		//IL_075b: Expected Obj, but got I
		//IL_0772: Expected Obj, but got I
		//IL_067d: Expected Obj, but got I
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected Obj, but got Unknown
		//IL_06b3: Expected Obj, but got I
		//IL_07c5: Expected Obj, but got I4
		//IL_0849: Expected Obj, but got I
		//IL_0860: Expected Obj, but got I
		//IL_07e9: Expected Obj, but got I
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected Obj, but got Unknown
		//IL_081f: Expected Obj, but got I
		//IL_08b3: Expected Obj, but got I4
		//IL_0937: Expected Obj, but got I
		//IL_094e: Expected Obj, but got I
		//IL_08d7: Expected Obj, but got I
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Expected Obj, but got Unknown
		//IL_090d: Expected Obj, but got I
		//IL_09a1: Expected Obj, but got I4
		//IL_0a25: Expected Obj, but got I
		//IL_0a3c: Expected Obj, but got I
		//IL_09c5: Expected Obj, but got I
		//IL_09d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09da: Expected Obj, but got Unknown
		//IL_09fb: Expected Obj, but got I
		//IL_0a8f: Expected Obj, but got I4
		//IL_0ab3: Expected Obj, but got I
		//IL_0ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac8: Expected Obj, but got Unknown
		//IL_0b4d: Expected Obj, but got I4
		//IL_0baa: Expected Obj, but got I
		//IL_0bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd4: Expected Obj, but got Unknown
		//IL_0c50: Expected F4, but got I
		//IL_0c7c: Expected VT, but got Ref
		//IL_0cc9: Expected Obj, but got I
		//IL_0cf1: Expected Obj, but got I
		//IL_0d12: Expected VT, but got I4
		//IL_0d7d: Expected VT, but got I4
		//IL_0d91: Expected Obj, but got I8
		//IL_0dbe: Expected Obj, but got I
		//IL_0e5d: Expected Obj, but got I8
		//IL_0ecd: Expected VT, but got Ref
		//IL_0f2f: Expected Obj, but got I
		//IL_0f59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5e: Expected Obj, but got Unknown
		//IL_0fab: Expected F4, but got I
		//IL_0fc1: Expected VT, but got Ref
		//IL_1019: Expected VT, but got Ref
		//IL_102f: Expected F4, but got I
		//IL_1040: Expected VT, but got Ref
		//IL_1092: Expected Obj, but got I
		//IL_10cb: Expected VT, but got I4
		//IL_112e: Expected VT, but got I4
		//IL_1142: Expected Obj, but got I8
		//IL_1202: Expected Obj, but got I8
		//IL_1258: Expected Obj, but got I4
		//IL_1268: Expected Obj, but got I4
		//IL_1288: Unknown result type (might be due to invalid IL or missing references)
		//IL_128d: Expected Obj, but got Unknown
		//IL_12ee: Expected VT, but got Ref
		//IL_135a: Expected I4, but got I8
		//IL_1381: Expected F4, but got I
		//IL_1392: Expected VT, but got Ref
		//IL_13b6: Expected VT, but got Ref
		//IL_13cc: Expected F4, but got I
		//IL_13dd: Expected VT, but got Ref
		//IL_1449: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		if (~(made ? 1u : 0u) == 0)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v169+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return chips != null;
		}
		GillaOreVeins gillaOreVeins = veins;
		made = true;
		if ((object)veins != null)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = gillaOreVeins.chipMaterial == null;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			if (obj6 != null)
			{
				goto IL_06bd;
			}
			GillaOreVeins gillaOreVeins2 = veins;
			if ((object)veins != null)
			{
				Mesh[] chipMeshes = gillaOreVeins2.chipMeshes;
				if (gillaOreVeins2.chipMeshes == null || chipMeshes.Length == 0)
				{
					goto IL_06bd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54E0]");
				object name = 0;
				GameObject gameObject = default;
				gameObject._002Ector((string)name);
				if ((object)gameObject != null)
				{
					Transform transform = gameObject.transform;
					if ((object)veins != null)
					{
						Transform transform2 = veins.transform;
						if ((object)transform != null)
						{
							transform.SetParent(transform2, worldPositionStays: false);
							GillaOreVeins gillaOreVeins3 = veins;
							if ((object)veins != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54C0]");
								object name2 = 0;
								ParticleSystem particleSystem = Particles(transform, (string)name2, gillaOreVeins3.chipMaterial, 600);
								object obj8 = this + 24;
								obj8 = particleSystem;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								if (obj8 != null)
								{
									GradientColorKey gradientColorKey = default;
									object obj9 = (object)(&gradientColorKey);
									ParticleSystem.MainModule main = ((ParticleSystem)obj8).main;
									ParticleSystem.MinMaxCurve minMaxCurve = 1f;
									ParticleSystem.MainModule mainModule = default;
									object obj10 = default;
									mainModule.gravityModifier = (ParticleSystem.MinMaxCurve)(&obj10);
									mainModule.startRotation3D = true;
									if (obj8 != null)
									{
										ParticleSystem.SizeOverLifetimeModule sizeOverLifetime = ((ParticleSystem)obj8).sizeOverLifetime;
										ParticleSystem.SizeOverLifetimeModule sizeOverLifetimeModule = default;
										sizeOverLifetimeModule.enabled = true;
										AnimationCurve curve = AnimationCurve.Linear(0f, 1f, 1f, 0f);
										ParticleSystem.MinMaxCurve minMaxCurve2 = new ParticleSystem.MinMaxCurve(1f, curve);
										object obj11 = default;
										sizeOverLifetimeModule.size = (ParticleSystem.MinMaxCurve)(&obj11);
										if (obj8 != null)
										{
											RotationOverLifetimeModule rotationOverLifetime = ((ParticleSystem)obj8).rotationOverLifetime;
											RotationOverLifetimeModule rotationOverLifetimeModule = default;
											rotationOverLifetimeModule.enabled = false;
											if (obj8 != null)
											{
												ParticleSystem.CollisionModule collision = ((ParticleSystem)obj8).collision;
												ParticleSystem.CollisionModule collisionModule = default;
												collisionModule.enabled = true;
												collisionModule.type = (ParticleSystemCollisionType)1;
												collisionModule.quality = (ParticleSystemCollisionQuality)1;
												LayerMask collidesWith = -5893;
												collisionModule.collidesWith = collidesWith;
												ParticleSystem.MinMaxCurve minMaxCurve3 = 0.25f;
												object obj12 = default;
												collisionModule.bounce = (ParticleSystem.MinMaxCurve)(&obj12);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
												ParticleSystem.MinMaxCurve minMaxCurve4 = 0f;
												object obj13 = default;
												collisionModule.dampen = (ParticleSystem.MinMaxCurve)(&obj13);
												collisionModule.radiusScale = 0.5f;
												if (obj8 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F08]");
													object obj14 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
													ParticleSystemRenderer particleSystemRenderer = default;
													if ((object)particleSystemRenderer != null)
													{
														particleSystemRenderer.renderMode = (ParticleSystemRenderMode)4;
														GillaOreVeins gillaOreVeins4 = veins;
														if ((object)veins != null)
														{
															particleSystemRenderer.SetMeshes(gillaOreVeins4.chipMeshes);
															particleSystemRenderer.meshDistribution = (ParticleSystemMeshDistribution)0;
															particleSystemRenderer.alignment = (ParticleSystemRenderSpace)1;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54B8]");
															object obj15 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
															List<Unity.IL2CPP.Metadata.__Il2CppInt32Enum> list = default;
															list._002Ector();
															if (list != null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+10]");
																object obj16 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+1C]");
																object obj17 = (nint)0 + (nint)1;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+10]");
																if ((nint)0 != 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+18]");
																	nint num = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1245 @ X8_v36+18]");
																	bool flag5 = num < 0;
																	object obj18 = !flag5;
																	if (obj18 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+18]");
																		object obj19 = (nint)0 + (nint)1;
																		object obj20 = obj16;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+18]");
																		object obj21 = obj20 + 0;
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+1C]");
																		object obj22 = (nint)0 + (nint)1;
																	}
																	else
																	{
																		list.AddWithResize((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+10]");
																		obj16 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+1C]");
																		object obj23 = (nint)0 + (nint)1;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+10]");
																		if ((nint)0 == 0)
																		{
																			goto IL_147c;
																		}
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+18]");
																	nint num2 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1245 @ X8_v36+18]");
																	bool flag6 = num2 < 0;
																	object obj24 = !flag6;
																	if (obj24 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+18]");
																		object obj25 = (nint)0 + (nint)1;
																		object obj26 = obj16;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+18]");
																		object obj27 = obj26 + 0;
																		_ = 1;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+1C]");
																		object obj28 = (nint)0 + (nint)1;
																	}
																	else
																	{
																		list.AddWithResize((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)1);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+10]");
																		obj16 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+1C]");
																		object obj29 = (nint)0 + (nint)1;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+10]");
																		if ((nint)0 == 0)
																		{
																			goto IL_147c;
																		}
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+18]");
																	nint num3 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1245 @ X8_v36+18]");
																	bool flag7 = num3 < 0;
																	object obj30 = !flag7;
																	if (obj30 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+18]");
																		object obj31 = (nint)0 + (nint)1;
																		object obj32 = obj16;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+18]");
																		object obj33 = obj32 + 0;
																		_ = 3;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+1C]");
																		object obj34 = (nint)0 + (nint)1;
																	}
																	else
																	{
																		list.AddWithResize((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)3);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+10]");
																		obj16 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+1C]");
																		object obj35 = (nint)0 + (nint)1;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+10]");
																		if ((nint)0 == 0)
																		{
																			goto IL_147c;
																		}
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+18]");
																	nint num4 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1245 @ X8_v36+18]");
																	bool flag8 = num4 < 0;
																	object obj36 = !flag8;
																	if (obj36 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+18]");
																		object obj37 = (nint)0 + (nint)1;
																		object obj38 = obj16;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+18]");
																		object obj39 = obj38 + 0;
																		_ = 4;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+1C]");
																		object obj40 = (nint)0 + (nint)1;
																	}
																	else
																	{
																		list.AddWithResize((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)4);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+10]");
																		obj16 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+1C]");
																		object obj41 = (nint)0 + (nint)1;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+10]");
																		if ((nint)0 == 0)
																		{
																			goto IL_147c;
																		}
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+18]");
																	nint num5 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1245 @ X8_v36+18]");
																	bool flag9 = num5 < 0;
																	object obj42 = !flag9;
																	if (obj42 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+18]");
																		object obj43 = (nint)0 + (nint)1;
																		object obj44 = obj16;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v64 (System.Collections.Generic.List`1<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)+18]");
																		object obj45 = obj44 + 0;
																		_ = 21;
																	}
																	else
																	{
																		list.AddWithResize((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)21);
																	}
																	particleSystemRenderer.SetActiveVertexStreams((List<ParticleSystemVertexStream>)(object)list);
																	GillaOreVeins gillaOreVeins5 = veins;
																	if ((object)veins != null)
																	{
																		object obj46 = obj;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1260 @ X0_v71+E4]");
																		bool flag10 = (nint)0 == 0;
																		object obj47 = !flag10;
																		if (obj47 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		}
																		if (!(gillaOreVeins5.sparkMaterial != null))
																		{
																			return true;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54D0]");
																		object name3 = 0;
																		ParticleSystem particleSystem2 = Particles(transform, (string)name3, gillaOreVeins5.sparkMaterial, 32);
																		object obj48 = this + 32;
																		obj48 = particleSystem2;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		if (obj48 != null)
																		{
																			ParticleSystem.SizeOverLifetimeModule sizeOverLifetime2 = ((ParticleSystem)obj48).sizeOverLifetime;
																			ParticleSystem.SizeOverLifetimeModule sizeOverLifetimeModule2 = default;
																			sizeOverLifetimeModule2.enabled = true;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8D8]");
																			AnimationCurve curve2 = AnimationCurve.Linear(0f, 0f, 1f, 1f);
																			ParticleSystem.MinMaxCurve minMaxCurve5 = new ParticleSystem.MinMaxCurve(1f, curve2);
																			object obj49 = default;
																			sizeOverLifetimeModule2.size = (ParticleSystem.MinMaxCurve)(&obj49);
																			if (obj48 != null)
																			{
																				ParticleSystem.ColorOverLifetimeModule colorOverLifetime = ((ParticleSystem)obj48).colorOverLifetime;
																				ParticleSystem.ColorOverLifetimeModule colorOverLifetimeModule = default;
																				colorOverLifetimeModule.enabled = true;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54A0]");
																				object obj50 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																				Gradient gradient = default;
																				gradient._002Ector();
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5498]");
																				object obj51 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																				GradientColorKey gradientColorKey2 = new GradientColorKey((Color)0, 1f);
																				GradientColorKey[] array = default;
																				if (array != null)
																				{
																					if (array.Length != 0)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X27_v5+150]");
																						_ = 0;
																						_ = 0;
																						GradientColorKey gradientColorKey3 = new GradientColorKey((Color)0, 1f);
																						object obj52 = array.Length & 0xFFFFFFFEL;
																						if (obj52 != null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5490]");
																							object obj53 = 0;
																							_ = 0;
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																							GradientAlphaKey gradientAlphaKey = new GradientAlphaKey(1f, 0f);
																							GradientAlphaKey[] array2 = default;
																							if (array2 == null)
																							{
																								goto IL_147c;
																							}
																							if (array2.Length != 0)
																							{
																								_ = 0;
																								GradientAlphaKey gradientAlphaKey2 = new GradientAlphaKey(0f, 1f);
																								object obj54 = array2.Length & 0xFFFFFFFEL;
																								if (obj54 != null)
																								{
																									_ = 0;
																									if ((object)gradient != null)
																									{
																										gradient.SetKeys(array, array2);
																										ParticleSystem.MinMaxGradient minMaxGradient = gradient;
																										object obj55 = default;
																										colorOverLifetimeModule.color = (ParticleSystem.MinMaxGradient)(&obj55);
																										if (obj48 != null)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
																											ParticleSystemRenderer particleSystemRenderer2 = default;
																											if ((object)particleSystemRenderer2 != null)
																											{
																												particleSystemRenderer2.renderMode = (ParticleSystemRenderMode)0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54D8]");
																												object name4 = 0;
																												ParticleSystem particleSystem3 = Particles(transform, (string)name4, gillaOreVeins5.sparkMaterial, 128);
																												object obj56 = this + 40;
																												obj56 = particleSystem3;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												if (obj56 != null)
																												{
																													ParticleSystem.MainModule main2 = ((ParticleSystem)obj56).main;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
																													ParticleSystem.MinMaxCurve minMaxCurve6 = 0f;
																													ParticleSystem.MainModule mainModule2 = default;
																													object obj57 = default;
																													mainModule2.gravityModifier = (ParticleSystem.MinMaxCurve)(&obj57);
																													if (obj56 != null)
																													{
																														ParticleSystem.LimitVelocityOverLifetimeModule limitVelocityOverLifetime = ((ParticleSystem)obj56).limitVelocityOverLifetime;
																														ParticleSystem.LimitVelocityOverLifetimeModule limitVelocityOverLifetimeModule = default;
																														limitVelocityOverLifetimeModule.enabled = true;
																														ParticleSystem.MinMaxCurve minMaxCurve7 = 100f;
																														object obj58 = default;
																														limitVelocityOverLifetimeModule.limit = (ParticleSystem.MinMaxCurve)(&obj58);
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
																														ParticleSystem.MinMaxCurve minMaxCurve8 = 0f;
																														object obj59 = default;
																														limitVelocityOverLifetimeModule.drag = (ParticleSystem.MinMaxCurve)(&obj59);
																														if (obj56 != null)
																														{
																															ParticleSystem.ColorOverLifetimeModule colorOverLifetime2 = ((ParticleSystem)obj56).colorOverLifetime;
																															ParticleSystem.ColorOverLifetimeModule colorOverLifetimeModule2 = default;
																															colorOverLifetimeModule2.enabled = true;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54A0]");
																															object obj60 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																															Gradient gradient2 = default;
																															gradient2._002Ector();
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																															gradientColorKey = new GradientColorKey((Color)0, 1f);
																															GradientColorKey[] array3 = default;
																															if (array3 != null)
																															{
																																if (array3.Length != 0)
																																{
																																	_ = 0;
																																	GradientColorKey gradientColorKey4 = new GradientColorKey((Color)0, 1f);
																																	object obj61 = array3.Length & 0xFFFFFFFEL;
																																	if (obj61 != null)
																																	{
																																		_ = 0;
																																		_ = 0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																																		GradientAlphaKey gradientAlphaKey3 = new GradientAlphaKey(1f, 0f);
																																		GradientAlphaKey[] array4 = default;
																																		if (array4 == null)
																																		{
																																			goto IL_147c;
																																		}
																																		if (array4.Length != 0)
																																		{
																																			_ = 0;
																																			GradientAlphaKey gradientAlphaKey4 = new GradientAlphaKey(1f, 0.5f);
																																			object obj62 = array4.Length & 0xFFFFFFFEL;
																																			if (obj62 != null)
																																			{
																																				_ = 0;
																																				GradientAlphaKey gradientAlphaKey5 = new GradientAlphaKey(0f, 1f);
																																				bool flag11 = array4.Length < 2;
																																				object obj63 = !flag11;
																																				object obj64 = array4.Length - 2;
																																				bool flag12 = obj64 == null;
																																				object obj65 = ~obj63;
																																				object obj66 = obj65 | flag12;
																																				if (obj66 == null)
																																				{
																																					_ = 0;
																																					if ((object)gradient2 != null)
																																					{
																																						gradient2.SetKeys(array3, array4);
																																						ParticleSystem.MinMaxGradient minMaxGradient2 = gradient2;
																																						object obj67 = default;
																																						colorOverLifetimeModule2.color = (ParticleSystem.MinMaxGradient)(&obj67);
																																						if (obj56 != null)
																																						{
																																							ParticleSystem.CollisionModule collision2 = ((ParticleSystem)obj56).collision;
																																							ParticleSystem.CollisionModule collisionModule2 = default;
																																							collisionModule2.enabled = true;
																																							collisionModule2.type = (ParticleSystemCollisionType)1;
																																							collisionModule2.quality = (ParticleSystemCollisionQuality)2;
																																							LayerMask collidesWith2 = -5893;
																																							collisionModule2.collidesWith = collidesWith2;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
																																							ParticleSystem.MinMaxCurve minMaxCurve9 = 0f;
																																							object obj68 = default;
																																							collisionModule2.bounce = (ParticleSystem.MinMaxCurve)(&obj68);
																																							ParticleSystem.MinMaxCurve minMaxCurve10 = 0.5f;
																																							object obj69 = default;
																																							collisionModule2.dampen = (ParticleSystem.MinMaxCurve)(&obj69);
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
																																							ParticleSystem.MinMaxCurve minMaxCurve11 = 0f;
																																							object obj70 = default;
																																							collisionModule2.lifetimeLoss = (ParticleSystem.MinMaxCurve)(&obj70);
																																							if (obj56 != null)
																																							{
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
																																								ParticleSystemRenderer particleSystemRenderer3 = default;
																																								if ((object)particleSystemRenderer3 != null)
																																								{
																																									particleSystemRenderer3.renderMode = (ParticleSystemRenderMode)1;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8D0]");
																																									particleSystemRenderer3.velocityScale = 0f;
																																									particleSystemRenderer3.lengthScale = 1.5f;
																																									return true;
																																								}
																																							}
																																						}
																																					}
																																					goto IL_147c;
																																				}
																																			}
																																		}
																																	}
																																}
																																goto IL_148a;
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																									goto IL_147c;
																								}
																							}
																						}
																					}
																					goto IL_148a;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_147c;
		IL_147c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_148a;
		IL_06bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj71 = 0;
		object obj72 = obj71;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ X0_v12+E4]");
		bool flag13 = (nint)0 == 0;
		object obj73 = !flag13;
		if (obj73 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54C8]");
		object message = 0;
		Debug.LogWarning(message);
		return false;
		IL_148a:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private unsafe static ParticleSystem Particles(Transform root, string name, Material material, int most)
	{
		//IL_0010: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_010c: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector(name);
		if ((object)gameObject != null)
		{
			Transform transform = gameObject.transform;
			if ((object)transform != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CD0]");
				object obj2 = 0;
				transform.SetParent(root, worldPositionStays: false);
				gameObject.layer = 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				ParticleSystem particleSystem = default;
				if ((object)particleSystem != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F08]");
					object obj3 = 0;
					particleSystem.Stop(withChildren: true, (ParticleSystemStopBehavior)0);
					ParticleSystem.MainModule main = particleSystem.main;
					ParticleSystem.MainModule mainModule = default;
					mainModule.playOnAwake = false;
					mainModule.simulationSpace = (ParticleSystemSimulationSpace)1;
					ParticleSystem.MinMaxCurve minMaxCurve = 0f;
					object obj4 = default;
					mainModule.startSpeed = (ParticleSystem.MinMaxCurve)(&obj4);
					mainModule.maxParticles = most;
					ParticleSystem.EmissionModule emission = particleSystem.emission;
					ParticleSystem.EmissionModule emissionModule = default;
					emissionModule.enabled = false;
					ParticleSystem.ShapeModule shape = particleSystem.shape;
					ParticleSystem.ShapeModule shapeModule = default;
					shapeModule.enabled = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
					Renderer renderer = default;
					if ((object)renderer != null)
					{
						renderer.sharedMaterial = material;
						renderer.shadowCastingMode = (ShadowCastingMode)0;
						renderer.receiveShadows = false;
						return particleSystem;
					}
				}
			}
		}
		return (ParticleSystem)(object)new NullReferenceException();
	}
}
