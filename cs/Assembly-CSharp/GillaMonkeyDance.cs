using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class GillaMonkeyDance : MonoBehaviour
{
	public GillaTvSong song;

	public float bpm;

	public float firstBeat;

	public float nod;

	public float tip;

	public float chest = 2.5f;

	private Transform spine;

	private Transform neck;

	private Transform head;

	private Transform[] posed;

	private Quaternion[] rest;

	private Vector3 leftLocal;

	private Vector3 aheadLocal;

	private bool ready;

	public float Beat
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_014c: Expected Obj, but got I4
			//IL_0088: Invalid comparison between F4 and I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num;
			if (song != null)
			{
				if ((object)song != null)
				{
					float length = song.Length;
					if (!(length > 0f))
					{
						goto IL_00d2;
					}
					if ((object)song != null)
					{
						num = song.SongTime;
						goto IL_00e0;
					}
				}
				throw new NullReferenceException();
			}
			goto IL_00d2;
			IL_00e0:
			float num2 = num - firstBeat;
			float num3 = num2 * bpm;
			return num3 / 1.1146363E+09f;
			IL_00d2:
			num = Time.time;
			goto IL_00e0;
		}
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_17de: Expected Obj, but got I
		//IL_1808: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I4
		//IL_1aa8: Expected Obj, but got I4
		//IL_1826: Expected Obj, but got I
		//IL_1836: Expected Obj, but got I
		//IL_1846: Expected Obj, but got I
		//IL_188f: Expected Obj, but got I4
		//IL_067c: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I
		//IL_06f0: Expected Obj, but got I4
		//IL_173b: Expected Obj, but got I
		//IL_1744: Unknown result type (might be due to invalid IL or missing references)
		//IL_1749: Expected Obj, but got Unknown
		//IL_0764: Expected Obj, but got I4
		//IL_0490: Expected Obj, but got I
		//IL_04b9: Expected Obj, but got I4
		//IL_04c1: Expected I4, but got Obj
		//IL_0398: Expected Obj, but got I4
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected Obj, but got Unknown
		//IL_04ec: Expected Obj, but got I
		//IL_04f5: Expected Obj, but got I4
		//IL_0454: Expected Obj, but got I4
		//IL_07d6: Expected Obj, but got I4
		//IL_03bf: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I4
		//IL_03f0: Expected I4, but got Obj
		//IL_17ab: Expected Obj, but got I4
		//IL_17b3: Expected I4, but got Obj
		//IL_02d2: Expected Obj, but got I4
		//IL_047b: Expected Obj, but got I
		//IL_0410: Expected Obj, but got I
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected Obj, but got Unknown
		//IL_0424: Expected Obj, but got I4
		//IL_0314: Expected Obj, but got I4
		//IL_0571: Expected Obj, but got I
		//IL_059c: Expected Obj, but got I4
		//IL_0838: Expected Obj, but got I
		//IL_1795: Expected Obj, but got I4
		//IL_179d: Expected I4, but got Obj
		//IL_05e2: Expected Obj, but got I4
		//IL_05ea: Expected I4, but got Obj
		//IL_033b: Expected Obj, but got I
		//IL_05bc: Expected Obj, but got I4
		//IL_05c4: Expected I4, but got Obj
		//IL_05d4: Expected Obj, but got I
		//IL_050a: Expected Obj, but got I
		//IL_0535: Expected Obj, but got I4
		//IL_17c1: Expected Obj, but got I4
		//IL_17c9: Expected I4, but got Obj
		//IL_01e9: Expected Obj, but got I4
		//IL_08ff: Expected Obj, but got I4
		//IL_055c: Expected Obj, but got I
		//IL_08c1: Expected Obj, but got I4
		//IL_0210: Expected Obj, but got I
		//IL_0239: Expected Obj, but got I4
		//IL_0241: Expected I4, but got Obj
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0923: Expected Obj, but got Unknown
		//IL_0952: Expected I4, but got Obj
		//IL_09d2: Expected Obj, but got I8
		//IL_09ea: Expected Obj, but got I4
		//IL_0261: Expected Obj, but got I
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_0275: Expected Obj, but got I4
		//IL_099a: Expected Obj, but got I4
		//IL_0a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Expected Obj, but got Unknown
		//IL_0a3d: Expected I4, but got Obj
		//IL_0ac5: Expected Obj, but got I4
		//IL_0adb: Expected Obj, but got I
		//IL_0afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b00: Expected Obj, but got Unknown
		//IL_0b09: Expected Obj, but got I4
		//IL_0a85: Expected Obj, but got I4
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Expected Obj, but got Unknown
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected Obj, but got Unknown
		//IL_0b98: Expected Obj, but got I
		//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bad: Expected Obj, but got Unknown
		//IL_0bb5: Expected Obj, but got I4
		//IL_0bd4: Expected Obj, but got I
		//IL_0c0a: Expected Obj, but got I4
		//IL_0c13: Expected Obj, but got I4
		//IL_0c39: Expected Obj, but got I4
		//IL_0c42: Expected Obj, but got I4
		//IL_0c9b: Expected Obj, but got I
		//IL_1ae4: Expected Obj, but got I
		//IL_1b1d: Expected Obj, but got I4
		//IL_0e80: Expected F8, but got I
		//IL_0e9a: Invalid comparison between F8 and I
		//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cca: Expected Obj, but got Unknown
		//IL_0cd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd8: Expected Obj, but got Unknown
		//IL_0cf9: Expected Obj, but got I4
		//IL_0d02: Expected Obj, but got I4
		//IL_0ef3: Expected Obj, but got I
		//IL_0f0b: Expected Obj, but got I
		//IL_0f13: Expected F8, but got Obj
		//IL_0f23: Expected F8, but got I
		//IL_0f33: Expected F8, but got I
		//IL_0d2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d34: Expected Obj, but got Unknown
		//IL_0d6a: Expected Obj, but got I4
		//IL_192b: Expected Obj, but got I
		//IL_197f: Expected Obj, but got I
		//IL_1996: Expected F8, but got Obj
		//IL_199e: Invalid comparison between F8 and Obj
		//IL_1b5a: Expected Obj, but got I4
		//IL_1102: Expected Obj, but got I
		//IL_111a: Expected Obj, but got I
		//IL_1122: Expected F8, but got Obj
		//IL_1132: Expected F8, but got I
		//IL_1142: Expected F8, but got I
		//IL_19e9: Expected Obj, but got I4
		//IL_117c: Expected Obj, but got I4
		//IL_11b4: Expected Obj, but got I4
		//IL_13be: Expected Obj, but got I4
		//IL_11f7: Expected Obj, but got I4
		//IL_1b80: Expected Obj, but got I
		//IL_1b88: Expected F8, but got Obj
		//IL_1b90: Invalid comparison between F8 and Obj
		//IL_1bd3: Expected Obj, but got I4
		//IL_1602: Expected Obj, but got I
		//IL_161a: Expected Obj, but got I
		//IL_1622: Expected F8, but got Obj
		//IL_1632: Expected F8, but got I
		//IL_1642: Expected F8, but got I
		//IL_134b: Expected Obj, but got I4
		//IL_1354: Expected Obj, but got I4
		//IL_1655: Expected VT, but got I4
		//IL_1663: Expected VT, but got F8
		//IL_16bf: Expected VT, but got I4
		//IL_16cd: Expected VT, but got F8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
		object obj3 = default;
		if (obj3 == null)
		{
			goto IL_0d81;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3+18]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3+18]");
		UnityEngine.Object obj7;
		UnityEngine.Object obj8;
		UnityEngine.Object obj10;
		UnityEngine.Object obj11;
		int num;
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7728]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7740]");
			object obj6 = 0;
			num = 1;
			obj7 = null;
			obj8 = null;
			object obj9 = 0;
			obj10 = null;
			obj11 = null;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
				object obj12 = !flag;
				if (obj12 != null)
				{
					break;
				}
				object obj13 = obj3 + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v88+20]");
				if ((nint)0 == 0)
				{
					goto IL_0d81;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v88+20]");
				string text = ((UnityEngine.Object)0).name;
				bool flag2 = text == null;
				num = 0;
				if (!flag2)
				{
					if (text._stringLength != 4)
					{
						if (text._stringLength != 10)
						{
							bool flag3 = text._stringLength != 5;
							num = 0;
							if (!flag3)
							{
								char c = text.get_Chars(4);
								int num2 = c & 0xFFFF;
								switch (num2)
								{
								case 82:
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4910]");
									object obj17 = 0;
									bool flag6 = text == (string)obj17;
									bool flag7 = !flag6;
									object obj18 = !flag7;
									object obj16 = ~obj18;
									if (obj16 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v88+20]");
										obj11 = (UnityEngine.Object)0;
									}
									obj2 = 0;
									num = (int)obj17;
									goto IL_172b;
								}
								case 76:
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48D8]");
									object obj14 = 0;
									bool flag4 = text == (string)obj14;
									bool flag5 = !flag4;
									object obj15 = !flag5;
									object obj16 = ~obj15;
									if (obj16 == null)
									{
										obj2 = 0;
										num = (int)obj14;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v88+20]");
										obj10 = (UnityEngine.Object)0;
									}
									else
									{
										obj2 = 0;
										num = (int)obj14;
									}
									goto IL_172b;
								}
								}
								bool flag8 = num2 != 101;
								obj2 = 0;
								num = 4;
								if (!flag8)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F8]");
									object obj19 = 0;
									bool flag9 = text == (string)obj19;
									bool flag10 = !flag9;
									obj2 = 0;
									num = (int)obj19;
									if (!flag10)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v88+20]");
										spine = (Transform)0;
										object obj20 = this + 64;
										obj2 = 0;
										goto IL_176d;
									}
								}
							}
						}
						else
						{
							char c2 = text.get_Chars(9);
							int num3 = c2 & 0xFFFF;
							if (num3 != 76)
							{
								bool flag11 = num3 != 82;
								obj2 = 0;
								num = 9;
								if (!flag11)
								{
									bool flag12 = text == (string)obj6;
									bool flag13 = !flag12;
									object obj21 = !flag13;
									object obj16 = ~obj21;
									if (obj16 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v88+20]");
										obj8 = (UnityEngine.Object)0;
									}
									obj2 = 0;
									num = (int)obj6;
								}
							}
							else
							{
								bool flag14 = text == (string)obj5;
								bool flag15 = !flag14;
								object obj22 = !flag15;
								object obj16 = ~obj22;
								if (obj16 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v88+20]");
									obj7 = (UnityEngine.Object)0;
								}
								obj2 = 0;
								num = (int)obj5;
							}
						}
					}
					else
					{
						char c3 = text.get_Chars(0);
						int num4 = c3 & 0xFFFF;
						if (num4 != 104)
						{
							bool flag16 = num4 != 110;
							obj2 = 0;
							num = 0;
							if (!flag16)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7720]");
								object obj23 = 0;
								bool flag17 = text == (string)obj23;
								bool flag18 = !flag17;
								obj2 = 0;
								num = (int)obj23;
								if (!flag18)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v88+20]");
									neck = (Transform)0;
									object obj20 = this + 72;
									obj2 = 0;
									goto IL_176d;
								}
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F0]");
							object obj24 = 0;
							bool flag19 = text == (string)obj24;
							bool flag20 = !flag19;
							obj2 = 0;
							num = (int)obj24;
							if (!flag20)
							{
								object obj20 = this + 80;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v88+20]");
								head = (Transform)0;
								obj2 = 0;
								goto IL_176d;
							}
						}
					}
				}
				goto IL_172b;
				IL_172b:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3+18]");
				obj4 = 0;
				obj9++;
				object obj25 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3+18]");
				if ((nint)obj25 < 0)
				{
					continue;
				}
				goto IL_17ce;
				IL_176d:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v88+20]");
				num = 0;
				goto IL_172b;
			}
			goto IL_16d8;
		}
		num = 1;
		obj7 = null;
		obj8 = null;
		obj10 = null;
		obj11 = null;
		goto IL_17ce;
		IL_1816:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CF0]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2CE8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj28 = 0;
		string text2 = name;
		string message = (string)obj26 + text2 + (string)obj27;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X8_v5+E4]");
		bool flag21 = (nint)0 == 0;
		object obj30 = !flag21;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		return;
		IL_16e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_17ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj31 = 0;
		object obj32 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v17+E4]");
		bool flag22 = (nint)0 == 0;
		object obj33 = !flag22;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IndexOutOfRangeException ex = default;
		if (spine != null)
		{
			object obj34 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v21+E4]");
			bool flag23 = (nint)0 == 0;
			object obj35 = !flag23;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (neck != null)
			{
				object obj36 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X0_v25+E4]");
				bool flag24 = (nint)0 == 0;
				object obj37 = !flag24;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (head != null)
				{
					object obj38 = obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1009 @ X0_v29+E4]");
					bool flag25 = (nint)0 == 0;
					object obj39 = !flag25;
					if (obj39 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (obj7 != null)
					{
						object obj40 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ X0_v33+E4]");
						bool flag26 = (nint)0 == 0;
						object obj41 = !flag26;
						if (obj41 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (ready = obj8 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
							object obj42 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							object obj43 = default;
							if (obj43 == null)
							{
								goto IL_0d81;
							}
							bool flag27 = (object)spine == null;
							int num5 = 3;
							if (!flag27)
							{
								object obj44 = obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v84+40]");
								num5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag28 = ex == null;
								obj2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v84+40]");
								num = 0;
								if (flag28)
								{
									goto IL_16e6;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v38+18]");
							bool flag29 = (nint)0 == 0;
							obj2 = 0;
							num = num5;
							if (!flag29)
							{
								object obj45 = obj43 + 32;
								obj45 = spine;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								bool flag30 = (object)neck == null;
								int num6 = (int)spine;
								if (!flag30)
								{
									object obj46 = obj43;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v83+40]");
									num6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag31 = ex == null;
									obj2 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v83+40]");
									num = 0;
									if (flag31)
									{
										goto IL_16e6;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v38+18]");
								object obj47 = 0 & 0xFFFFFFFEL;
								bool flag32 = obj47 == null;
								obj2 = 0;
								num = num6;
								if (!flag32)
								{
									object obj48 = obj43 + 40;
									obj48 = neck;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									bool flag33 = (object)head == null;
									int num7 = (int)neck;
									if (!flag33)
									{
										object obj49 = obj43;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v82+40]");
										num7 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag34 = ex == null;
										obj2 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v82+40]");
										num = 0;
										if (flag34)
										{
											goto IL_16e6;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v38+18]");
									bool flag35 = (nint)0 < (nint)2;
									object obj50 = !flag35;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v38+18]");
									object obj51 = -2;
									bool flag36 = obj51 == null;
									object obj52 = ~obj50;
									object obj53 = obj52 | flag36;
									obj2 = 0;
									num = num7;
									if (obj53 == null)
									{
										object obj54 = obj43 + 48;
										obj54 = head;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj55 = this + 88;
										obj55 = obj43;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj56 = obj55;
										if (obj55 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F28]");
											object obj57 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
											object obj58 = this + 96;
											int num8 = default;
											obj58 = num8;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X25_v8-8]");
											object obj59 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X25_v8-8]");
											if ((nint)0 != 0)
											{
												num = num8;
												object obj60 = 0;
												object obj61 = 0;
												double num14 = default;
												double num12 = default;
												double num10 = default;
												while (true)
												{
													object obj62 = obj60;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v26+18]");
													object obj71;
													double num20;
													double num21;
													double num22;
													object obj77;
													double num30;
													double num43;
													double num44;
													double num45;
													double num53;
													double num54;
													double num55;
													if ((nint)obj62 < 0)
													{
														object obj63 = obj60;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v26+18]");
														bool flag37 = (nint)obj63 < 0;
														object obj64 = !flag37;
														obj2 = 0;
														if (obj64 != null)
														{
															break;
														}
														object obj65 = obj59 + obj60;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v78+20]");
														if ((nint)0 != 0)
														{
															object obj66 = obj58;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v78+20]");
															Quaternion localRotation = ((Transform)0).localRotation;
															if (obj58 != null)
															{
																obj60++;
																object obj67 = obj60 - 1;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X29_v8+18]");
																bool flag38 = (nint)obj67 < 0;
																object obj68 = !flag38;
																obj2 = 0;
																num = 0;
																if (obj68 != null)
																{
																	break;
																}
																object obj69 = obj58 + obj61;
																obj61 += 16;
																obj59 = obj55;
																bool flag39 = obj55 == null;
																object obj70 = !flag39;
																num = 0;
																if (obj70 != null)
																{
																	continue;
																}
															}
														}
													}
													else if ((object)neck != null)
													{
														Vector3 position = neck.position;
														if ((object)spine != null)
														{
															Vector3 position2 = spine.position;
															double num9 = num10 - num10;
															double num11 = num12 - num12;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
															obj71 = 0;
															double num13 = num14 - num14;
															object obj72 = obj71;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X0_v64+E4]");
															bool flag40 = (nint)0 == 0;
															object obj73 = !flag40;
															if (obj73 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															double num15 = num9 * num9;
															double num16 = num11 * num11;
															double num17 = num15 + num16;
															double num18 = num13 * num13;
															double num19 = num18 + num17;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
															num12 = 0.0;
															Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
															if (num19 > 0.0)
															{
																num20 = num9 / num19;
																num21 = num11 / num19;
																num22 = num13 / num19;
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
																object obj74 = 0;
																object obj75 = obj74;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1135 @ X8_v74+A0]");
																object obj76 = 0;
																num20 = (double)obj76;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1136 @ X8_v75+4]");
																num21 = 0.0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1136 @ X8_v75+8]");
																num22 = 0.0;
															}
															bool flag41 = (object)obj7 == null;
															num10 = num22;
															if (!flag41)
															{
																Vector3 position3 = ((Transform)obj7).position;
																bool flag42 = (object)obj8 == null;
																num10 = num22;
																if (!flag42)
																{
																	Vector3 position4 = ((Transform)obj8).position;
																	double num23 = num20 * num20;
																	double num24 = num21 * num21;
																	double num25 = num22 - num22;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
																	obj77 = 0;
																	double num26 = num12 - num12;
																	double num27 = num14 - num14;
																	double num28 = num23 + num24;
																	double num29 = num22 * num22;
																	object obj78 = obj77;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ X8_v36+A0]");
																	object obj79 = 0;
																	num30 = num29 + num28;
																	double num31 = (double)obj79;
																	bool flag43 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num30) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj79);
																	num14 = num22;
																	if (!flag43)
																	{
																		double num32 = num20 * num25;
																		double num33 = num21 * num26;
																		double num34 = num22 * num27;
																		double num35 = num32 + num33;
																		double num36 = num34 + num35;
																		double num37 = num36 / num30;
																		num29 = num20 * num37;
																		num14 = num21 * num37;
																		num31 = num22 * num37;
																		num25 -= num29;
																		num26 -= num14;
																		num27 -= num31;
																		double num38 = num22;
																	}
																	object obj80 = obj71;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1213 @ X0_v73+E4]");
																	bool flag44 = (nint)0 == 0;
																	object obj81 = !flag44;
																	if (obj81 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	}
																	double num39 = num25 * num25;
																	double num40 = num26 * num26;
																	double num41 = num39 + num40;
																	double num42 = num27 * num27;
																	num10 = num41 + num42;
																	Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
																	if (num10 > num12)
																	{
																		num43 = num25 / num10;
																		num44 = num26 / num10;
																		num45 = num27 / num10;
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
																		object obj82 = 0;
																		object obj83 = obj82;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ X8_v67+A0]");
																		object obj84 = 0;
																		num43 = (double)obj84;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X8_v68+4]");
																		num44 = 0.0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X8_v68+8]");
																		num45 = 0.0;
																	}
																	object obj85 = obj31;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1237 @ X0_v75+E4]");
																	bool flag45 = (nint)0 == 0;
																	object obj86 = !flag45;
																	if (obj86 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	}
																	bool flag46 = obj10 != null;
																	bool flag47 = !flag46;
																	object obj87 = 0;
																	double num46;
																	if (!flag47)
																	{
																		object obj88 = obj31;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1249 @ X0_v105+E4]");
																		bool flag48 = (nint)0 == 0;
																		object obj89 = !flag48;
																		if (obj89 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		}
																		bool flag49 = obj11 != null;
																		bool flag50 = !flag49;
																		obj87 = 0;
																		if (!flag50)
																		{
																			bool flag51 = (object)obj10 == null;
																			num46 = num21;
																			if (!flag51)
																			{
																				Vector3 position5 = ((Transform)obj10).position;
																				bool flag52 = (object)obj11 == null;
																				num46 = num21;
																				if (!flag52)
																				{
																					Vector3 position6 = ((Transform)obj11).position;
																					bool flag53 = (object)head == null;
																					num46 = num21;
																					if (!flag53)
																					{
																						double num47 = num14 + num14;
																						double num48 = num12 + num12;
																						double num49 = num10 + num10;
																						double num50 = num47 * 0.5;
																						double num51 = num48 * 0.5;
																						double num52 = num49 * 0.5;
																						Vector3 position7 = head.position;
																						num53 = num52 - num49;
																						num54 = num51 - num48;
																						num55 = num50 - num47;
																						num46 = 0.5;
																						obj87 = 0;
																						object obj90 = 0;
																						goto IL_1b68;
																					}
																				}
																			}
																			goto IL_0d81;
																		}
																	}
																	Transform transform = base.transform;
																	bool flag54 = (object)transform == null;
																	num46 = num21;
																	if (!flag54)
																	{
																		Vector3 forward = transform.forward;
																		num46 = num21;
																		num54 = num12;
																		num55 = num14;
																		num53 = num10;
																		object obj90 = 0;
																		goto IL_1b68;
																	}
																}
															}
														}
													}
													goto IL_0d81;
													IL_1b68:
													object obj91 = obj77;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1296 @ X8_v48+A0]");
													object obj92 = 0;
													double num56 = (double)obj92;
													if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num30) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj92))
													{
														double num57 = num20 * num53;
														double num58 = num21 * num54;
														double num59 = num22 * num55;
														double num60 = num57 + num58;
														double num61 = num59 + num60;
														double num62 = num61 / num30;
														double num63 = num20 * num62;
														double num46 = num21 * num62;
														double num64 = num22 * num62;
														num53 -= num63;
														num54 -= num46;
														num55 -= num64;
														double num38 = num21;
													}
													double num65 = num43 * num43;
													double num66 = num44 * num44;
													double num67 = num65 + num66;
													num14 = num45 * num45;
													double num68 = num14 + num67;
													if (!(num68 < num56))
													{
														double num69 = num43 * num53;
														double num70 = num44 * num54;
														double num46 = num45 * num55;
														double num71 = num69 + num70;
														double num72 = num46 + num71;
														double num73 = num72 / num68;
														num68 = num43 * num73;
														num14 = num44 * num73;
														num56 = num45 * num73;
														num53 -= num68;
														num54 -= num14;
														num55 -= num56;
													}
													object obj93 = obj71;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1382 @ X0_v83+E4]");
													bool flag55 = (nint)0 == 0;
													object obj94 = !flag55;
													if (obj94 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													double num74 = num53 * num53;
													double num75 = num54 * num54;
													double num76 = num74 + num75;
													double num77 = num55 * num55;
													num10 = num76 + num77;
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
													double num78;
													if (num10 > num12)
													{
														num78 = num53 / num10;
														double num79 = num54 / num10;
														double num80 = num55 / num10;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
														object obj95 = 0;
														object obj96 = obj95;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1400 @ X8_v58+A0]");
														object obj97 = 0;
														num78 = (double)obj97;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1401 @ X8_v59+4]");
														double num79 = 0.0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1401 @ X8_v59+8]");
														double num80 = 0.0;
													}
													Transform transform2 = base.transform;
													if ((object)transform2 != null)
													{
														Vector3 vector = transform2.InverseTransformDirection((Vector3)0);
														leftLocal = (Vector3)num43;
														Transform transform3 = base.transform;
														bool flag56 = (object)transform3 == null;
														num14 = num45;
														num12 = num44;
														num10 = num43;
														if (!flag56)
														{
															Vector3 vector2 = transform3.InverseTransformDirection((Vector3)0);
															aheadLocal = (Vector3)num78;
															return;
														}
													}
													goto IL_0d81;
												}
												goto IL_16d8;
											}
										}
										goto IL_0d81;
									}
								}
							}
							goto IL_16d8;
						}
						goto IL_1816;
					}
				}
			}
		}
		ready = false;
		goto IL_1816;
		IL_0d81:
		throw new NullReferenceException();
		IL_16d8:
		ex = new IndexOutOfRangeException();
		goto IL_16e6;
	}

	public static float Bump(float beat)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		object obj = default;
		float num = beat - (float)obj;
		float num2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F8]");
		float num3 = num2 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D100");
		float num4 = num3 * 0.5f;
		float num5 = num4 + 0.5f;
		return num5 * num5;
	}

	private void LateUpdate()
	{
		//IL_0aa8: Expected Obj, but got I4
		//IL_0ac3: Expected Obj, but got I4
		//IL_0125: Expected Obj, but got I4
		//IL_03b7: Expected F4, but got I
		//IL_03c1: Expected F4, but got VT
		//IL_03cf: Expected VT, but got I4
		//IL_040e: Unsupported input type for neg.
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected VT, but got Unknown
		//IL_0425: Expected F4, but got I
		//IL_0433: Expected VT, but got I4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01e3: Expected Obj, but got I4
		//IL_0491: Expected F4, but got I
		//IL_04e0: Expected F4, but got I
		//IL_04f0: Expected F4, but got I
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_027c: Expected Obj, but got I4
		//IL_028c: Expected F4, but got I
		//IL_029c: Expected F4, but got I
		//IL_02ac: Expected F4, but got I
		//IL_02c5: Expected VT, but got I4
		//IL_02eb: Expected Obj, but got I4
		//IL_030b: Expected F4, but got I
		//IL_031b: Expected F4, but got I
		//IL_0357: Expected F4, but got I
		//IL_06e8: Expected VT, but got I4
		//IL_075f: Expected F4, but got I
		//IL_0966: Expected VT, but got I4
		//IL_0a91: Expected VT, but got I4
		if (~(ready ? 1u : 0u) != 0)
		{
			return;
		}
		float beat = Beat;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num = beat - beat;
		float num2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F8]");
		float num3 = num2 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D100");
		Transform[] array = posed;
		bool flag = posed == null;
		float num4 = beat;
		float num12 = default;
		float num7;
		if (!flag)
		{
			float num5 = num3 * 0.5f;
			float num6 = num5 + 0.5f;
			num7 = num6 * num6;
			float num9 = default;
			float num8 = num9;
			float num11 = default;
			float num10 = num11;
			object obj2 = default;
			object obj = obj2;
			object obj4 = default;
			object obj3 = obj4;
			Transform transform2 = default;
			Transform transform = transform2;
			Transform transform3 = null;
			Transform[] array2 = posed;
			Vector3 axis = default;
			while (true)
			{
				Quaternion[] array3 = (Quaternion[])array2.Length;
				bool flag2 = (nint)transform3 < array2.Length;
				object obj5 = !flag2;
				bool flag3 = (nint)transform3 >= array2.Length;
				num9 = num8;
				num11 = num10;
				obj2 = obj;
				obj4 = obj3;
				transform2 = transform;
				array = array2;
				num4 = beat;
				num3 = num6;
				if (!flag3)
				{
					bool flag4 = (nint)transform3 < array2.Length;
					obj5 = !flag4;
					if (obj5 == null)
					{
						array3 = rest;
						bool flag5 = rest == null;
						num9 = num8;
						num11 = num10;
						obj2 = obj;
						obj4 = obj3;
						transform2 = transform;
						num12 = num7;
						array = array2;
						num4 = beat;
						num3 = num6;
						if (flag5)
						{
							break;
						}
						transform2 = (Transform)(transform3 + 1);
						obj4 = transform2 - 1;
						bool flag6 = (nint)obj4 < array3.Length;
						obj5 = !flag6;
						if (obj5 == null)
						{
							array = (Transform[])(object)((object)array2 + (object)transform3);
							bool flag7 = (object)array[0] == null;
							num9 = num8;
							num11 = num10;
							obj2 = obj;
							num12 = num7;
							num4 = beat;
							num3 = num6;
							if (flag7)
							{
								break;
							}
							object obj6 = rest + 0;
							obj2 = 0 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X9_v7+28]");
							num11 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X9_v7+2C]");
							num9 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X9_v7+20]");
							num3 = 0f;
							array[0].localRotation = (Quaternion)0;
							array = posed;
							bool flag8 = posed == null;
							object obj7 = !flag8;
							num12 = num7;
							num4 = beat;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X9_v7+2C]");
							num8 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X9_v7+28]");
							num10 = 0f;
							obj = obj2;
							obj3 = obj4;
							transform = transform2;
							transform3 = transform2;
							array2 = posed;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X9_v7+20]");
							num6 = 0f;
							if (obj7 == null)
							{
								break;
							}
							continue;
						}
					}
					throw new IndexOutOfRangeException();
				}
				Transform transform4 = base.transform;
				bool flag9 = (object)transform4 == null;
				num12 = num7;
				if (flag9)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+70]");
				num11 = 0f;
				num3 = (float)leftLocal;
				Vector3 vector = transform4.TransformDirection((Vector3)0);
				Transform transform5 = base.transform;
				bool flag10 = (object)transform5 == null;
				num12 = num7;
				if (flag10)
				{
					break;
				}
				Vector3 vector2 = 0 - leftLocal;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+70]");
				float num13 = -0;
				Vector3 vector3 = transform5.TransformDirection((Vector3)0);
				transform2 = spine;
				num3 = num7 * chest;
				Quaternion quaternion = Quaternion.Internal_AngleAxis(num3, ref axis);
				bool flag11 = (object)spine == null;
				axis = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+7C]");
				num11 = 0f;
				num12 = num7;
				if (flag11)
				{
					break;
				}
				Quaternion rotation = spine.rotation;
				bool flag12 = (object)spine == null;
				axis = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+7C]");
				num11 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+7C]");
				num12 = 0f;
				if (flag12)
				{
					break;
				}
				float num14 = num9 * num9;
				float num15 = num3 * num3;
				float num16 = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+7C]");
				float num17 = num16 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+7C]");
				float num18 = 0f * num9;
				float num19 = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+78]");
				float num20 = num19 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+78]");
				double num21 = 0.0 * (double)num9;
				float num22 = num9 * num3;
				float num23 = num3 * num9;
				float num24 = num14 - num15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+78]");
				double num25 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+78]");
				double num26 = num25 * 0.0;
				float num27 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+7C]");
				float num28 = num27 * 0f;
				float num29 = num17 + num18;
				float num30 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+78]");
				float num31 = num30 * 0f;
				float num32 = num20 + (float)num21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+7C]");
				float num33 = 0f * num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+78]");
				float num34 = 0f * num3;
				float num35 = num22 + num23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+78]");
				float num36 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+7C]");
				float num37 = num36 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+7C]");
				float num38 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+7C]");
				float num39 = num38 * 0f;
				float num40 = num24 - (float)num26;
				float num41 = num31 + num29;
				float num42 = num37 + num35;
				float num43 = num40 - num39;
				float num44 = num41 - num34;
				spine.rotation = (Quaternion)0;
				float num45 = nod;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				float num46 = num45 * 0f;
				float num47 = num7 * num46;
				Quaternion quaternion2 = Quaternion.Internal_AngleAxis(num47, ref axis);
				bool flag13 = (object)neck == null;
				axis = vector2;
				num9 = num43;
				num11 = num44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaMonkeyDance)+7C]");
				num12 = 0f;
				num3 = num47;
				if (flag13)
				{
					break;
				}
				Quaternion rotation2 = neck.rotation;
				bool flag14 = (object)neck == null;
				axis = vector2;
				num9 = num43;
				num11 = num44;
				num12 = num44;
				num3 = num47;
				if (flag14)
				{
					break;
				}
				float num48 = num43 * num43;
				float num49 = num47 * num47;
				float num50 = num43 * num44;
				float num51 = num44 * num43;
				float num52 = num43 * num13;
				float num53 = num13 * num43;
				float num54 = num43 * num47;
				float num55 = num47 * num43;
				float num56 = num48 - num49;
				double num57 = (double)num13 * (double)num13;
				num28 = num47 * num44;
				float num58 = num50 + num51;
				num31 = num47 * num13;
				num32 = num52 + num53;
				num33 = num44 * num47;
				float num59 = num13 * num47;
				float num60 = num54 + num55;
				num37 = num13 * num44;
				float num61 = num44 * num44;
				float num62 = num56 - (float)num57;
				float num63 = num31 + num58;
				float num64 = num33 + num32;
				num42 = num37 + num60;
				num9 = num62 - num61;
				num11 = num63 - num59;
				float num65 = num64 - num28;
				neck.rotation = (Quaternion)0;
				float num66 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
				float num67 = num66 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				float num68 = num67 * tip;
				Quaternion quaternion3 = Quaternion.Internal_AngleAxis(num68, ref axis);
				float num69 = nod;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				float num70 = num69 * 0f;
				num3 = num7 * num70;
				Quaternion quaternion4 = Quaternion.Internal_AngleAxis(num3, ref axis);
				bool flag15 = (object)head == null;
				axis = vector2;
				transform2 = head;
				num12 = num44;
				num4 = num68;
				if (flag15)
				{
					break;
				}
				Quaternion rotation3 = head.rotation;
				bool flag16 = (object)head == null;
				axis = vector2;
				transform2 = head;
				num12 = num3;
				num4 = num68;
				if (flag16)
				{
					break;
				}
				head.rotation = (Quaternion)0;
				return;
			}
		}
		num7 = num12;
		throw new NullReferenceException();
	}

	public GillaMonkeyDance()
	{
		//IL_001d: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107DD80]");
		bpm = 0f;
		base._002Ector();
	}
}
