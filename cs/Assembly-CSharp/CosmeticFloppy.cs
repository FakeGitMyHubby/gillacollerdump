using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class CosmeticFloppy : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<CosmeticCatalog.Entry, string> _003C_003E9__30_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47B8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj2 = default;
			obj2._002Ector();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
			object obj4 = 0;
			obj4 = obj2;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		internal string _003CBuy_003Eb__30_0(CosmeticCatalog.Entry x)
		{
			if (x != null)
			{
				return x.name;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public CosmeticMotion.Limb[] limbs;

	private const int Steps = default(int);

	private const float LongestFrame = default(float);

	private const float Teleported = default(float);

	private bool started;

	private void Awake()
	{
		//IL_000f: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I4
		//IL_01f5: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I
		//IL_0101: Expected I, but got Obj
		//IL_01b0: Expected Obj, but got I4
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_0145: Expected Obj, but got I
		//IL_0162: Expected I, but got Obj
		CosmeticMotion.Limb[] array = limbs;
		if (limbs == null)
		{
			goto IL_0168;
		}
		object obj = array.Length;
		if (array.Length < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj4 = !flag;
			if (obj4 != null)
			{
				break;
			}
			object obj5 = (object)limbs + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v8+20]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v8+20]");
			if ((nint)0 != 0)
			{
				object obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X23_v6+10]");
				bool flag3 = (UnityEngine.Object)0 != null;
				bool flag4 = !flag3;
				nint num = unchecked((nint)null);
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X23_v6+10]");
					if ((nint)0 == 0)
					{
						goto IL_0168;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X23_v6+10]");
					Quaternion localRotation = ((Transform)0).localRotation;
					num = unchecked((nint)null);
				}
				obj = array.Length;
				obj3++;
				if ((nint)obj3 >= array.Length)
				{
					return;
				}
				continue;
			}
			goto IL_0168;
		}
		goto IL_0176;
		IL_0168:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0176;
		IL_0176:
		throw new IndexOutOfRangeException();
	}

	private void OnEnable()
	{
		started = false;
	}

	private void LateUpdate()
	{
		float deltaTime = Time.deltaTime;
		Step(deltaTime);
	}

	public void Step(float dt)
	{
		//IL_0b48: Invalid comparison between F4 and I4
		//IL_0b59: Expected Obj, but got I4
		//IL_0b62: Invalid comparison between F4 and I4
		//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7e: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I4
		//IL_00d6: Expected F8, but got I
		//IL_1007: Expected Obj, but got I4
		//IL_0118: Expected Obj, but got I
		//IL_0167: Expected Obj, but got I4
		//IL_0196: Expected Obj, but got I
		//IL_01b4: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I4
		//IL_01c2: Expected I, but got Obj
		//IL_0aee: Expected Obj, but got I4
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected Obj, but got Unknown
		//IL_01fa: Expected Obj, but got I4
		//IL_0229: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I4
		//IL_0250: Expected Obj, but got I4
		//IL_0255: Expected I, but got Obj
		//IL_029e: Expected VT, but got I4
		//IL_029e: Expected Obj, but got I
		//IL_02d4: Expected Obj, but got I
		//IL_030e: Expected Obj, but got I
		//IL_0322: Expected F4, but got I
		//IL_0332: Expected F4, but got I
		//IL_0bb6: Expected Obj, but got I4
		//IL_10a5: Expected F4, but got I
		//IL_10ae: Expected Obj, but got I4
		//IL_10b3: Expected I, but got Obj
		//IL_10c3: Expected F8, but got I
		//IL_0bdc: Expected Obj, but got I
		//IL_0be4: Expected F8, but got Obj
		//IL_0bf4: Expected F8, but got I
		//IL_0c1e: Expected F4, but got I
		//IL_0c27: Expected Obj, but got I4
		//IL_0c2c: Expected I, but got Obj
		//IL_0485: Expected F4, but got I
		//IL_0c65: Expected Obj, but got I
		//IL_0c75: Expected Obj, but got I
		//IL_0c85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8a: Expected Obj, but got Unknown
		//IL_0ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cae: Expected Obj, but got Unknown
		//IL_0cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc3: Expected Obj, but got Unknown
		//IL_0cd3: Expected F8, but got I
		//IL_0ce3: Expected F4, but got I
		//IL_0cf3: Expected F8, but got I
		//IL_0d12: Expected F4, but got I
		//IL_0d1b: Expected Obj, but got I4
		//IL_121e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1223: Expected Obj, but got Unknown
		//IL_123d: Expected Obj, but got I4
		//IL_1246: Expected Obj, but got I4
		//IL_050b: Invalid comparison between F4 and I
		//IL_0d77: Expected Obj, but got I4
		//IL_05c4: Invalid comparison between F8 and I
		//IL_0612: Expected Obj, but got I
		//IL_0623: Expected F8, but got I
		//IL_0e1c: Expected Obj, but got I4
		//IL_069e: Invalid comparison between F8 and I
		//IL_06ad: Expected F8, but got I4
		//IL_07fe: Expected F8, but got I
		//IL_0fa3: Expected Obj, but got I
		//IL_0fd2: Expected Obj, but got I
		//IL_0fda: Invalid comparison between F8 and Obj
		//IL_07e9: Expected VT, but got F8
		//IL_0f12: Expected Obj, but got I4
		//IL_128e: Expected VT, but got F8
		//IL_08cf: Expected Obj, but got I
		//IL_0905: Expected Obj, but got VT
		//IL_0ab0: Expected VT, but got I4
		//IL_0ab0: Expected Obj, but got I
		//IL_0aca: Expected Obj, but got I4
		//IL_0acf: Expected I, but got Obj
		bool flag = dt < 0f;
		object obj = !flag;
		bool flag2 = dt == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		if (obj3 != null)
		{
			return;
		}
		CosmeticMotion.Limb[] array = limbs;
		if (limbs == null)
		{
			goto IL_0b2a;
		}
		object obj4 = array.Length;
		if (array.Length < 1)
		{
			goto IL_0b1a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC80]");
		double num = 0.0 * 0.5;
		float num3 = default;
		float num2 = num3;
		float num5 = default;
		float num4 = num5;
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		double num6 = 0.0;
		double num7 = num;
		double num8 = 0.5;
		float num9 = dt;
		object obj27 = default;
		double num37 = default;
		double num38 = default;
		object obj29 = default;
		object obj30 = default;
		object obj31 = default;
		object obj32 = default;
		float num68 = default;
		Vector3 current = default;
		Vector3 target = default;
		object obj41 = default;
		while (true)
		{
			bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
			object obj9 = !flag3;
			if (obj9 != null)
			{
				break;
			}
			object obj10 = (object)limbs + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v10+20]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v10+20]");
			if ((nint)0 != 0)
			{
				object obj12 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X0_v9+E4]");
				bool flag4 = (nint)0 == 0;
				object obj13 = !flag4;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+10]");
				bool flag5 = (UnityEngine.Object)0 == null;
				bool flag6 = !flag5;
				object obj14 = !flag6;
				object obj15 = 0;
				nint num10 = unchecked((nint)null);
				if (obj14 == null)
				{
					object obj16 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X0_v14+E4]");
					bool flag7 = (nint)0 == 0;
					object obj17 = !flag7;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+18]");
					bool flag8 = (UnityEngine.Object)0 == null;
					bool flag9 = !flag8;
					object obj18 = !flag9;
					obj15 = 0;
					num10 = unchecked((nint)null);
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+10]");
							((Transform)0).localRotation = (Quaternion)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+10]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+10]");
								Vector3 position = ((Transform)0).position;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+18]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+18]");
									Vector3 position2 = ((Transform)0).position;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+30]");
									num2 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+34]");
									num4 = 0f;
									object obj19 = obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X0_v24+E4]");
									bool flag10 = (nint)0 == 0;
									object obj20 = !flag10;
									if (obj20 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+38]");
									float num11 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+38]");
									float num12 = num11 - 0f;
									num8 = (double)num12 * (double)num12;
									double num13 = num2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+30]");
									num6 = num13 - 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+54]");
									nint num14 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
									bool flag11 = num14 < 0;
									float num15 = num2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+30]");
									float num16 = 0f;
									obj15 = 0;
									num10 = unchecked((nint)null);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
									num7 = 0.0;
									if (!flag11)
									{
										if (~(started ? 1u : 0u) == 0)
										{
											float num17 = num2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+58]");
											float num18 = num17 - 0f;
											float num19 = num4;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+5C]");
											float num20 = num19 - 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+38]");
											float num21 = 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+60]");
											float num22 = num21 - 0f;
											float num23 = num18 * num18;
											float num24 = num20 * num20;
											float num25 = num23 + num24;
											float num26 = num22 * num22;
											float num27 = num25 + num26;
											bool flag12 = !((double)num27 > 2.25);
											double num28 = num22;
											if (flag12)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+38]");
												_ = 0;
												num15 = num2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+30]");
												num16 = 0f;
												float num29 = num18 / num9;
												object obj21 = obj7;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+54]");
												nint num30 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+28]");
												object obj22 = num30 * 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X8_v24+A0]");
												object obj23 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+20]");
												object obj24 = obj22 * 0;
												float num31 = num20 / num9;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X8_v25+2C]");
												object obj25 = 0 * obj24;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X8_v25+24]");
												object obj26 = 0 * obj27;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+54]");
												double num32 = 0.0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+40]");
												float num33 = 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+48]");
												double num34 = 0.0;
												float num35 = num22 / num9;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+4C]");
												float num36 = 0f;
												object obj28 = 1;
												num36 = num3;
												num33 = num5;
												num34 = num37;
												num32 = num38;
												obj28 = obj29;
												object obj34;
												do
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+38]");
													float num39 = 0f - (float)num34;
													float num40 = num15 - num33;
													float num41 = num36 - num29;
													float num42 = (float)num32 - num35;
													float num43 = num39;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+20]");
													float num44 = num43 * 0f;
													float num45 = num40 * (float)obj30;
													float num46 = num42;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+24]");
													float num47 = num46 * 0f;
													float num48 = num41 * (float)obj31;
													float num49 = num44 - num47;
													float num50 = num45 - num48;
													float num51 = (float)obj25 + num49;
													float num52 = (float)obj26 + num50;
													double num53 = num * (double)num51;
													float num54 = num52 * (float)obj32;
													num32 += num53;
													num36 += num54;
													float num55 = num36 * (float)obj32;
													double num56 = num * num32;
													num33 += num55;
													num34 += num56;
													object obj33 = obj28 & 1;
													bool flag13 = obj33 == null;
													obj34 = !flag13;
													obj28 = 0;
												}
												while (obj34 != null);
												float num57 = num33 - num16;
												double num58 = num34;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+38]");
												double num59 = num58 - 0.0;
												float num60 = num57 * num57;
												double num61 = num59 * num59;
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
												float num62 = num60 + (float)num61;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFFC]");
												double num63 = ((!(num62 < 0f)) ? num59 : ((double)num12));
												object obj35 = obj6;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X0_v32+E4]");
												bool flag14 = (nint)0 == 0;
												object obj36 = !flag14;
												if (obj36 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
												double num64 = num63 * num63;
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
												double num65 = num59 * num59;
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
												num28 = num64 + num65;
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
												double num66;
												if (num65 > 0.0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
													num66 = num63 / num65;
												}
												else
												{
													object obj37 = obj7;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X8_v55+A0]");
													object obj38 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1017 @ X8_v56+8]");
													num66 = 0.0;
												}
												float num67 = num68;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+54]");
												float num69 = num67 / 0f;
												float num70 = num12;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+54]");
												float num71 = num70 / 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+2C]");
												float num72 = 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
												float num73 = num72 * 0f;
												Vector3 vector = Vector3.Internal_RotateTowards(ref current, ref target, num73, 0f);
												object obj39 = obj6;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X0_v37+E4]");
												bool flag15 = (nint)0 == 0;
												object obj40 = !flag15;
												if (obj40 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												float num74 = num73 * num73;
												float num75 = 0f * 0f;
												float num76 = num74 + num75;
												double num77 = num66 * num66;
												double num78 = num77 + (double)num76;
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
												double num79 = num77;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F4]");
												bool flag16 = num79 < 0.0;
												double num80 = 0.0;
												if (!flag16)
												{
													float num81 = num73 * (float)num59;
													float num82 = 0f * (float)obj41;
													float num83 = num81 + num82;
													double num84 = num63 * num66;
													double num85 = num84 + (double)num83;
													double num86 = num85 / num77;
													bool flag17 = num86 < -1.0;
													num28 = -1.0;
													if (!flag17)
													{
														bool flag18 = !(num86 > 1.0);
														num28 = num86;
														num77 = 1.0;
														if (!flag18)
														{
															num28 = 1.0;
															num77 = 1.0;
														}
													}
													object obj42 = obj6;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1179 @ X0_v51+E4]");
													bool flag19 = (nint)0 == 0;
													object obj43 = !flag19;
													if (obj43 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D000");
													double num87 = num28;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
													num80 = num87 * 0.0;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+54]");
												float num88 = 0f * 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+54]");
												float num89 = 0f * num73;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+54]");
												double num90 = 0.0 * num66;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+34]");
												float num91 = 0f + num88;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+30]");
												float num92 = 0f + num89;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+38]");
												double num93 = 0.0 + num90;
												Vector3 vector2;
												if (num80 > 0.5)
												{
													float num94 = num29;
													float num95 = num31;
													vector2 = (Vector3)num6;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+4C]");
													num28 = 0.0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+4C]");
													double num96 = 0.0 - (double)num29;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+54]");
													num91 = 0f - num35;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
													object obj44 = 0;
													object obj45 = obj44;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+50]");
													num92 = 0f - num31;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ X8_v49+A0]");
													object obj46 = 0;
													if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num78) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj46))
													{
														float num97 = num73 * (float)num96;
														float num98 = 0f * num92;
														double num99 = num66 * (double)num91;
														float num100 = num97 + num98;
														double num101 = num99 + (double)num100;
														double num102 = num101 / num78;
														float num103 = num73 * (float)num102;
														float num104 = 0f * (float)num102;
														double num105 = num66 * num102;
														num96 -= (double)num103;
														num92 -= num104;
														num91 -= (float)num105;
													}
													float num94 = num29 + (float)num96;
													float num95 = num31 + num92;
													num35 += num91;
													vector2 = (Vector3)num6;
												}
												Quaternion quaternion = Quaternion.Internal_FromToRotation(ref current, ref target);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+10]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+10]");
													Quaternion rotation = ((Transform)0).rotation;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+10]");
													if ((nint)0 != 0)
													{
														object obj47 = vector2 * vector2;
														float num106 = num68 * num68;
														float num107 = (float)vector2 * num91;
														float num108 = num91 * (float)vector2;
														float num109 = (float)vector2 * num92;
														float num110 = num92 * (float)vector2;
														float num111 = (float)vector2 * num68;
														float num112 = num68 * (float)vector2;
														float num113 = (float)obj47 - num106;
														float num114 = num92 * num92;
														float num115 = num68 * num91;
														float num116 = num107 + num108;
														float num117 = num68 * num92;
														float num118 = num91 * num92;
														float num119 = num109 + num110;
														float num120 = num91 * num68;
														float num121 = num92 * num68;
														float num122 = num111 + num112;
														float num123 = num92 * num91;
														float num124 = num91 * num91;
														float num125 = num113 - num114;
														num2 = num117 + num116;
														float num126 = num120 + num119;
														float num127 = num123 + num122;
														num4 = num125 - num124;
														float num128 = num2 - num121;
														num8 = (double)num126 - (double)num115;
														num7 = (double)num127 - (double)num118;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+10]");
														((Transform)0).rotation = (Quaternion)0;
														current = vector2;
														num18 = num92;
														obj15 = 0;
														num10 = unchecked((nint)null);
														num6 = num128;
														num9 = dt;
														goto IL_0ae4;
													}
												}
												goto IL_0b2a;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+38]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+38]");
										_ = 0;
										object obj48 = obj7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v19+A0]");
										object obj49 = 0;
										num7 = (double)obj49;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X8_v20+8]");
										num8 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X8_v20+8]");
										_ = 0;
										num15 = num2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X22_v7+30]");
										num16 = 0f;
										obj15 = 0;
										num10 = unchecked((nint)null);
									}
									goto IL_0ae4;
								}
							}
						}
						goto IL_0b2a;
					}
				}
				goto IL_0ae4;
			}
			goto IL_0b2a;
			IL_0ae4:
			obj4 = array.Length;
			obj8++;
			if ((nint)obj8 < array.Length)
			{
				continue;
			}
			goto IL_0b1a;
		}
		goto IL_0b38;
		IL_0b38:
		throw new IndexOutOfRangeException();
		IL_0b1a:
		started = true;
		return;
		IL_0b2a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0b38;
	}

	public CosmeticFloppy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 32;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
