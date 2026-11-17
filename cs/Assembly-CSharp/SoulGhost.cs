using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class SoulGhost : MonoBehaviour
{
	private const float Out = default(float);

	private const float Hang = default(float);

	private const float Back = default(float);

	private static readonly int Alpha;

	private Vector3 from;

	private Vector3 to;

	private float t;

	private readonly List<Mesh> meshes;

	private readonly List<Renderer> parts;

	private MaterialPropertyBlock block;

	private SoulScythe scythe;

	private bool snapped;

	public static void Spawn(List<SkinnedMeshRenderer> body, Vector3 toward, SoulScythe scythe)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1527: Expected Obj, but got I
		//IL_156b: Unknown result type (might be due to invalid IL or missing references)
		//IL_156f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_0095: Expected Obj, but got VT
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got VT
		//IL_00ff: Expected Obj, but got I
		//IL_0107: Expected I4, but got Obj
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f5: Expected Obj, but got I
		//IL_1a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1c: Expected F4, but got I4
		//IL_1a26: Expected F4, but got I4
		//IL_1a2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected F4, but got I4
		//IL_0220: Expected F4, but got I4
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected F4, but got Unknown
		//IL_15a6: Invalid comparison between F8 and I4
		//IL_15b5: Invalid comparison between F8 and I4
		//IL_15c8: Expected Obj, but got F8
		//IL_15d5: Expected Obj, but got F8
		//IL_160a: Expected Obj, but got I4
		//IL_1612: Unknown result type (might be due to invalid IL or missing references)
		//IL_1617: Expected Obj, but got Unknown
		//IL_1729: Invalid comparison between F8 and I4
		//IL_1738: Invalid comparison between F8 and I4
		//IL_174b: Expected Obj, but got F8
		//IL_1758: Expected Obj, but got F8
		//IL_178d: Expected Obj, but got I4
		//IL_1795: Unknown result type (might be due to invalid IL or missing references)
		//IL_179a: Expected Obj, but got Unknown
		//IL_181f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1833: Unknown result type (might be due to invalid IL or missing references)
		//IL_183b: Expected F4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		string text = (string)obj;
		GameObject gameObject = default;
		gameObject._002Ector((string)obj);
		bool flag = (object)gameObject == null;
		double num2 = default;
		double num = num2;
		Renderer renderer2 = default;
		Renderer renderer = renderer2;
		Enumerator<, > val = (Enumerator<, >)0;
		Enumerator<, > val3 = default;
		Enumerator<, > val2 = val3;
		bool flag2 = false;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB40]");
			object obj3 = 0;
			text = (string)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			object obj4 = default;
			bool flag3 = obj4 == null;
			num = num2;
			renderer = renderer2;
			val = (Enumerator<, >)0;
			val2 = val3;
			flag2 = false;
			if (!flag3)
			{
				object obj5 = obj4 + 88;
				obj5 = toward;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag4 = (object)body == null;
				num = num2;
				renderer = renderer2;
				val = (Enumerator<, >)0;
				val2 = val3;
				flag2 = false;
				text = (string)toward;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB48]");
					object obj6 = 0;
					flag2 = (byte)(int)obj6 != 0;
					System.__Canon _Canon = ((List<System.__Canon>)(object)body).get_Item(0);
					bool flag5 = _Canon == null;
					num = num2;
					renderer = renderer2;
					val = (Enumerator<, >)0;
					val2 = val3;
					text = null;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D90]");
						Renderer renderer3 = (Renderer)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D78]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B58]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4188]");
						object obj9 = 0;
						Bounds bounds = ((Renderer)(object)_Canon).bounds;
						Enumerator<, > enumerator = ((List<System.__Canon>)(object)body).GetEnumerator();
						num = num2;
						float num4 = default;
						float num3 = num4;
						double num6 = default;
						double num5 = num6;
						double num8 = default;
						double num7 = num8;
						float num10 = default;
						float num9 = num10;
						Enumerator<, > val4 = default;
						val2 = val4;
						object obj10 = default;
						object obj11 = default;
						object obj12 = default;
						object obj13 = default;
						object obj20 = default;
						float num11;
						Enumerator<, > val5;
						Enumerator<, > val6;
						while (true)
						{
							text = (string)obj7;
							if (!val.MoveNext())
							{
								break;
							}
							bool flag6 = (object)renderer2 == null;
							renderer = null;
							val = val4;
							num10 = 0f;
							num11 = 63f;
							val5 = (Enumerator<, >)(ref val);
							val6 = (Enumerator<, >)(ref val);
							float num12 = (float)val3;
							if (!flag6)
							{
								Bounds bounds2 = renderer2.bounds;
								float num13 = num9 - (float)num5;
								double num14 = num5 + (double)num9;
								float num15 = (float)obj10 - (float)obj11;
								double num16 = (double)obj10 + (double)obj11;
								double num17 = (double)obj12 + (double)obj13;
								float num18 = num3 - (float)num7;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								if (!(num13 < num15))
								{
									num13 = num15;
								}
								double num19 = num14 - (double)num15;
								bool flag7 = num19 < 0.0;
								bool flag8 = num19 == 0.0;
								object obj14 = num14 ^ (double)num15;
								object obj15 = num14 ^ num19;
								object obj16 = obj14 & obj15;
								bool flag9 = (nint)obj16 < 0;
								bool flag10 = flag7 == flag9;
								object obj17 = !flag8;
								object obj18 = flag10 & obj17;
								object obj19 = ~obj18;
								double num20 = ((obj19 != null) ? ((double)num15) : num14);
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
								double num21 = num20 - (double)num13;
								float num22 = (float)obj20 - num18;
								double num23 = num21 * 0.5;
								float num24 = num22 * 63f;
								double num25 = (double)num13 + num23;
								float num26 = num18 + num24;
								double num27 = num25 - num23;
								double num28 = num23 + num25;
								float num29 = num26 - num24;
								float num30 = num24 + num26;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								if (!(num27 < num16))
								{
									num27 = num16;
								}
								double num31 = num28 - num16;
								bool flag11 = num31 < 0.0;
								bool flag12 = num31 == 0.0;
								object obj21 = num28 ^ num16;
								object obj22 = num28 ^ num31;
								object obj23 = obj21 & obj22;
								bool flag13 = (nint)obj23 < 0;
								bool flag14 = flag11 == flag13;
								object obj24 = !flag12;
								object obj25 = flag14 & obj24;
								object obj26 = ~obj25;
								if (obj26 == null)
								{
									num16 = num28;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
								double num32 = num16 - num27;
								double num33 = (double)num24 - num25;
								num5 = num32 * 0.5;
								num7 = num33 * 63.0;
								double num34 = num27 + num5;
								val2 = (Enumerator<, >)(num25 + num7);
								num = num25;
								double num35 = num29;
								num3 = (float)val2;
								num9 = (float)num34;
								continue;
							}
							goto IL_137d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D70]");
						object obj27 = 0;
						text = (string)obj27;
						val.Dispose();
						renderer = null;
						val = val4;
						num10 = 0f;
						num11 = 63f;
						val5 = (Enumerator<, >)(ref val);
						val6 = (Enumerator<, >)(ref val);
						renderer3 = null;
						goto IL_1434;
					}
				}
			}
		}
		goto IL_1417;
		IL_1434:
		throw new OutOfMemoryException();
		IL_137d:
		NullReferenceException ex = new NullReferenceException();
		NullReferenceException ex2 = new NullReferenceException();
		NullReferenceException ex3 = new NullReferenceException();
		NullReferenceException ex4 = new NullReferenceException();
		NullReferenceException ex5 = new NullReferenceException();
		NullReferenceException ex6 = new NullReferenceException();
		NullReferenceException ex7 = new NullReferenceException();
		NullReferenceException ex8 = new NullReferenceException();
		NullReferenceException ex9 = new NullReferenceException();
		NullReferenceException ex10 = new NullReferenceException();
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_1417;
		IL_1417:
		NullReferenceException ex12 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_1434;
	}

	private unsafe void Update()
	{
		//IL_0b9b: Invalid comparison between F4 and I
		//IL_0bc2: Expected Obj, but got I
		//IL_0bdd: Expected Obj, but got I
		//IL_005c: Invalid comparison between F4 and I4
		//IL_0096: Expected F8, but got I4
		//IL_0469: Invalid comparison between F4 and I
		//IL_0478: Expected F4, but got I4
		//IL_016b: Invalid comparison between F4 and I4
		//IL_017a: Expected F8, but got I4
		//IL_0c77: Expected Obj, but got I
		//IL_01fe: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected F4, but got I4
		//IL_025b: Expected Obj, but got I4
		//IL_0519: Expected Obj, but got VT
		//IL_0536: Expected Obj, but got I
		//IL_0546: Expected Obj, but got I
		//IL_057a: Expected Obj, but got I
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected Obj, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected Obj, but got Unknown
		//IL_05f8: Expected VT, but got I4
		//IL_04ec: Expected F4, but got I
		//IL_02a0: Expected Obj, but got I4
		//IL_02ba: Expected Obj, but got I4
		//IL_0617: Expected Obj, but got I
		//IL_0cdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Expected Obj, but got I4
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got I4
		//IL_064b: Expected Obj, but got I
		//IL_065b: Expected F8, but got I
		//IL_067f: Expected F8, but got I
		//IL_068f: Expected Obj, but got I
		//IL_06e2: Expected VT, but got I4
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Expected Obj, but got Unknown
		//IL_070f: Expected Obj, but got I4
		//IL_033b: Expected Obj, but got I4
		//IL_0355: Expected Obj, but got I4
		//IL_0d2d: Expected Obj, but got I
		//IL_0d4f: Expected Obj, but got I4
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected Obj, but got I
		//IL_0373: Expected Obj, but got I
		//IL_039d: Expected Obj, but got I4
		//IL_03ca: Expected F8, but got I
		//IL_03da: Expected F8, but got I
		//IL_03ea: Expected F8, but got I
		//IL_041b: Expected F4, but got I
		//IL_041b: Expected F4, but got I
		//IL_041b: Expected F4, but got VT
		//IL_041b: Expected VT, but got I4
		//IL_0426: Expected Obj, but got I4
		//IL_043b: Expected F4, but got I
		//IL_07c7: Expected Obj, but got I
		//IL_07d8: Expected I4, but got Obj
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Expected Obj, but got I4
		//IL_0833: Expected Obj, but got I
		//IL_0843: Expected Obj, but got I
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_085b: Expected Obj, but got I4
		//IL_091c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Expected Obj, but got I4
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected Obj, but got I4
		//IL_094c: Expected Obj, but got I4
		//IL_0db2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbb: Expected Ref, but got Unknown
		//IL_0dd5: Expected Obj, but got I4
		//IL_088a: Expected Obj, but got I4
		//IL_08cd: Expected Obj, but got I4
		//IL_096b: Expected Obj, but got I4
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected Obj, but got Unknown
		//IL_0a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6b: Expected Obj, but got I4
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7d: Expected Obj, but got I4
		//IL_09d8: Invalid comparison between F4 and I
		//IL_090e: Expected Obj, but got I4
		//IL_0af9: Expected Obj, but got I4
		//IL_0b02: Expected Obj, but got I4
		//IL_09b8: Expected Obj, but got I4
		//IL_0b61: Expected Obj, but got I4
		//IL_0a20: Expected Obj, but got I4
		float deltaTime = Time.deltaTime;
		float num = (t += deltaTime);
		float num2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		double num10;
		double num11;
		float num6;
		if (num2 < 0f)
		{
			float num3 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			float num4 = num3 / 0f;
			double num5 = 1.0 - (double)num4;
			num6 = num4 * 3f;
			double num7 = num5 * num5;
			bool flag = num6 < 0f;
			double num8 = num5 * num7;
			double num9 = 1.0 - num8;
			num10 = num9;
			num11 = 0.0;
			double num12 = 3.0;
			if (!flag)
			{
				if ((double)num6 > 1.0)
				{
					num10 = num9;
					num11 = 1.0;
					num12 = 3.0;
				}
				else
				{
					num10 = num9;
					num11 = num6;
					num12 = 3.0;
				}
			}
		}
		else
		{
			bool flag2 = (double)num < 0.75;
			num10 = 1.0;
			num11 = 1.0;
			if (!flag2)
			{
				float num13 = num + -0.75f;
				float num14 = num13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9F4]");
				float num15 = num14 / 0f;
				bool flag3 = num15 < 0f;
				double num16 = 0.0;
				if (!flag3)
				{
					bool flag4 = !((double)num15 > 1.0);
					num16 = num15;
					if (!flag4)
					{
						num16 = 1.0;
					}
				}
				num6 = (float)num16 * (float)num16;
				double num17 = num16 * (double)num6;
				num11 = 1.0 - (double)num6;
				double num18 = 1.0 - num17;
				num10 = num18;
				double num9 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		bool flag5 = (double)num < 0.75;
		IntPtr intPtr = default;
		UnityEngine.Object obj2 = (UnityEngine.Object)(nint)intPtr;
		float num19 = 0.75f;
		AudioClip[] array = null;
		SoulScythe soulScythe3 = default;
		Enumerator<, > val;
		double num20;
		SoulScythe soulScythe;
		SoulScythe soulScythe2;
		UnityEngine.Object obj7;
		if (!flag5)
		{
			bool flag6 = (byte)(~(snapped ? 1u : 0u)) != 0;
			object obj3 = !flag6;
			obj2 = (UnityEngine.Object)(nint)intPtr;
			num19 = 0.75f;
			array = null;
			if (obj3 == null)
			{
				object obj4 = obj;
				snapped = true;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v69+E4]");
				bool flag7 = (nint)0 == 0;
				object obj5 = !flag7;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag8 = scythe != null;
				bool flag9 = !flag8;
				object obj6 = 0;
				obj2 = null;
				num19 = 0.75f;
				array = (AudioClip[])flag8;
				if (!flag9)
				{
					soulScythe = scythe;
					bool flag10 = (object)scythe == null;
					soulScythe2 = soulScythe3;
					val = (Enumerator<, >)0;
					obj6 = 0;
					obj7 = null;
					num20 = 0.75;
					if (flag10)
					{
						goto IL_0a8f;
					}
					bool flag11 = soulScythe.snaps == null;
					obj6 = 0;
					obj2 = null;
					num19 = 0.75f;
					array = (AudioClip[])flag8;
					if (!flag11)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
						object obj8 = 0;
						object obj9 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v73+E4]");
						bool flag12 = (nint)0 == 0;
						object obj10 = !flag12;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
						double num9 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB8]");
						double num7 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
						double num12 = 0.0;
						AudioClip[] snaps = soulScythe.snaps;
						Vector3 vector = to;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SoulGhost)+30]");
						nint num21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SoulGhost)+34]");
						Sfx.Play(snaps, (Vector3)0, (float)vector, num21, 0f);
						obj6 = 0;
						obj2 = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SoulGhost)+30]");
						num19 = 0f;
						array = soulScythe.snaps;
					}
				}
			}
		}
		num = t;
		float num22 = t;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		bool flag13 = num22 < 0f;
		float num23 = 0f;
		if (!flag13)
		{
			bool flag14 = !((double)t < 0.75);
			num19 = 0.75f;
			num23 = 0f;
			if (!flag14)
			{
				num *= 1.1146363E+09f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				num19 = 0f;
				float num24 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				num23 = num24 * 0f;
			}
		}
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDA35]");
		soulScythe = (SoulScythe)0;
		bool flag15 = (object)transform == null;
		soulScythe2 = soulScythe3;
		val = (Enumerator<, >)0;
		obj7 = null;
		num20 = num19;
		num6 = num23;
		if (!flag15)
		{
			object obj11 = to - from;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SoulGhost)+34]");
			nint num25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SoulGhost)+28]");
			object obj12 = num25 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj13 = 0;
			object obj14 = obj13;
			object obj16 = default;
			object obj15 = obj11 * obj16;
			double num26 = num10 * (double)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v19+A0]");
			object obj17 = 0;
			object obj18 = from + obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SoulGhost)+28]");
			double num27 = 0.0 + num26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v20+3C]");
			object obj20 = default;
			object obj19 = 0 * obj20;
			double num28 = num23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v20+44]");
			double num9 = num28 * 0.0;
			num = (float)obj18 + (float)obj19;
			double num29 = num27 + num9;
			transform.position = (Vector3)0;
			Transform transform2 = base.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD9A8]");
			soulScythe = (SoulScythe)0;
			bool flag16 = (object)transform2 == null;
			soulScythe2 = soulScythe3;
			val = (Enumerator<, >)0;
			object obj21 = 109891584;
			obj7 = null;
			double num7 = num23;
			double num30 = default;
			num20 = num30;
			num6 = (float)num29;
			if (!flag16)
			{
				object obj22 = obj13;
				double num31 = num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
				double num32 = num31 * 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v24+A0]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v25+C]");
				num7 = 0.0;
				double num33 = num32 + 1.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v25+10]");
				num9 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB08]");
				obj21 = 0;
				float num34 = (float)num33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v25+14]");
				num6 = num34 * 0f;
				double num35 = num33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v25+10]");
				num20 = num35 * 0.0;
				float num36 = (float)num33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v25+C]");
				num = num36 * 0f;
				transform2.localScale = (Vector3)0;
				object obj24 = this + 80;
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)obj24;
				bool flag17 = obj24 == null;
				object obj25 = !flag17;
				obj7 = null;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					MaterialPropertyBlock materialPropertyBlock2 = default;
					materialPropertyBlock2._002Ector();
					obj24 = materialPropertyBlock2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					materialPropertyBlock = (MaterialPropertyBlock)obj24;
					obj7 = (UnityEngine.Object)(object)materialPropertyBlock2;
				}
				object obj27 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v42+E4]");
				soulScythe = (SoulScythe)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v42+E4]");
				bool flag18 = (nint)0 == 0;
				object obj28 = !flag18;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag19 = materialPropertyBlock == null;
				soulScythe2 = soulScythe3;
				val = (Enumerator<, >)0;
				if (!flag19)
				{
					object obj29 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v28+A0]");
					soulScythe = (SoulScythe)0;
					materialPropertyBlock.SetFloat((int)soulScythe, (float)num11);
					bool flag20 = (object)parts == null;
					soulScythe2 = soulScythe3;
					val = (Enumerator<, >)0;
					object obj6 = 0;
					obj7 = soulScythe;
					num = (float)num11;
					if (!flag20)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A00]");
						object obj30 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49F8]");
						obj21 = 0;
						Enumerator<, > enumerator = ((List<System.__Canon>)(object)parts).GetEnumerator();
						obj6 = 0;
						float num37 = default;
						object obj42 = default;
						object obj33;
						Enumerator<, > val2;
						while (true)
						{
							if (val.MoveNext())
							{
								object obj31 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X0_v50+E4]");
								bool flag21 = (nint)0 == 0;
								object obj32 = !flag21;
								if (obj32 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag22 = soulScythe3 != null;
								bool flag23 = !flag22;
								obj6 = 0;
								if (!flag23)
								{
									if ((object)soulScythe3 == null)
									{
										break;
									}
									((Renderer)(object)soulScythe3).SetPropertyBlock((MaterialPropertyBlock)obj24);
									obj6 = 0;
								}
								continue;
							}
							soulScythe2 = null;
							val = (Enumerator<, >)num37;
							obj33 = 0;
							val2 = (Enumerator<, >)(ref val);
							object obj34 = 12;
							num = num37;
							object obj35 = 0;
							while (true)
							{
								obj7 = (UnityEngine.Object)obj21;
								((Enumerator<, >*)val2)->Dispose();
								bool flag24 = obj35 == null;
								object obj36 = !flag24;
								if (obj36 == null)
								{
									bool flag25 = (object)soulScythe2 == null;
									object obj37 = !flag25;
									OutOfMemoryException ex = (OutOfMemoryException)val2;
									if (obj37 == null)
									{
										if ((nint)obj34 != 12)
										{
											bool flag26 = obj34 == null;
											object obj38 = !flag26;
											if (obj38 != null)
											{
												return;
											}
										}
										float num38 = t;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B004]");
										if (!(num38 < 0f))
										{
											GameObject obj39 = gameObject;
											object obj40 = obj;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X8_v9+E4]");
											bool flag27 = (nint)0 == 0;
											object obj41 = !flag27;
											if (obj41 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											UnityEngine.Object.Destroy(obj39);
										}
										return;
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
									soulScythe2 = (SoulScythe)1;
									soulScythe = (SoulScythe)1;
									obj35 = obj33;
								}
								else
								{
									if ((nint)obj7 != 1)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
									obj35 = obj42;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									obj33 = obj42;
								}
								obj34 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D088");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						NullReferenceException ex2 = new NullReferenceException();
						soulScythe2 = null;
						val = (Enumerator<, >)num37;
						obj33 = 0;
						val2 = (Enumerator<, >)(ref val);
						obj6 = 0;
						obj7 = null;
						num = num37;
					}
				}
			}
		}
		goto IL_0a8f;
		IL_0a8f:
		throw new NullReferenceException();
	}

	private unsafe void OnDestroy()
	{
		//IL_0017: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got I4
		//IL_013a: Expected Obj, but got I4
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got I4
		//IL_0298: Expected I, but got Obj
		//IL_02bb: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I4
		//IL_016a: Expected Obj, but got I4
		//IL_0172: Expected Obj, but got Ref
		//IL_00f7: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I4
		//IL_0209: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7080]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7078]");
		object obj3 = 0;
		Enumerator<, > enumerator = ((List<System.__Canon>)(object)meshes).GetEnumerator();
		object obj5 = default;
		object obj4 = obj5;
		Enumerator<, > val = default;
		while (val.MoveNext())
		{
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v26+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = (UnityEngine.Object)null != (UnityEngine.Object)null;
			bool flag3 = !flag2;
			obj4 = 0;
			if (!flag3)
			{
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v30+E4]");
				bool flag4 = (nint)0 == 0;
				object obj9 = !flag4;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy(null);
				obj4 = 0;
			}
		}
		object obj10 = 0;
		object obj11 = 0;
		Enumerator<, > val2 = (Enumerator<, >)(ref val);
		object obj12 = 0;
		object obj15 = default;
		object obj16 = default;
		IntPtr intPtr = default;
		object obj17 = default;
		while (true)
		{
			nint num = (nint)obj3;
			val.Dispose();
			bool flag5 = obj12 == null;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				bool flag6 = obj10 == null;
				object obj14 = !flag6;
				OutOfMemoryException ex = (OutOfMemoryException)(&val);
				if (obj14 == null)
				{
					break;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				obj4 = obj5;
				obj10 = obj15;
				obj11 = obj16;
				num = intPtr;
				obj3 = 109895680;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			switch ((long)num)
			{
			case 2L:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj10 = 1;
				obj12 = obj11;
				break;
			case 1L:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj12 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj11 = obj17;
				break;
			default:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DC5C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
		}
	}

	public SoulGhost()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7410]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj3 = this + 64;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list2 = default;
		list2._002Ector();
		object obj4 = this + 72;
		obj4 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static SoulGhost()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB58]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB08]");
		object obj2 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = num;
	}
}
