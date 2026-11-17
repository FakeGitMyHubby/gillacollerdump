using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class MonsterDisplay : MonoBehaviour
{
	[Serializable]
	public class Spawn
	{
		public GameObject prefab;

		public Vector3 position;

		public float yaw;
	}

	public MonsterDirector.Entry entry;

	public bool showOff;

	private Transform up;

	private Transform lo;

	private Transform end;

	private Transform i1;

	private Transform p1;

	private bool hinge;

	private Vector3 alongUp;

	private Vector3 hingeUp;

	private Vector3 alongLo;

	private Quaternion restRel;

	public unsafe static MonsterDisplay Make(MonsterDirector.Entry e, bool showOff)
	{
		//IL_0aca: Expected Obj, but got I
		//IL_0b11: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got I4
		//IL_0078: Expected I, but got Obj
		//IL_01a4: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I
		//IL_010e: Expected I, but got Obj
		//IL_0116: Expected I4, but got Obj
		//IL_0264: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I
		//IL_02d7: Expected Obj, but got I
		//IL_0311: Expected Obj, but got I
		//IL_0377: Expected Obj, but got I8
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_038e: Expected Obj, but got I4
		//IL_0397: Expected Obj, but got I4
		//IL_046c: Expected Obj, but got I
		//IL_04a0: Expected Obj, but got I4
		//IL_0b38: Expected Obj, but got I4
		//IL_04e3: Expected Obj, but got I4
		//IL_055b: Expected Obj, but got I
		//IL_03c6: Expected Obj, but got I4
		//IL_03f4: Expected Obj, but got I
		//IL_0404: Expected Obj, but got I
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected Obj, but got Unknown
		//IL_0431: Expected Obj, but got I4
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected Obj, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_0525: Expected Obj, but got I4
		//IL_0546: Expected Obj, but got I4
		//IL_05cf: Expected Obj, but got I
		//IL_0b7d: Expected Obj, but got I4
		//IL_0628: Expected Obj, but got I4
		//IL_065c: Expected Obj, but got I4
		//IL_06ea: Expected Obj, but got I
		//IL_071e: Expected Obj, but got I4
		//IL_0761: Expected Obj, but got I4
		//IL_07f5: Expected Obj, but got I
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected Obj, but got Unknown
		//IL_083b: Expected Obj, but got I
		//IL_0855: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Expected Obj, but got Unknown
		//IL_0881: Expected Obj, but got I
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Expected Obj, but got Unknown
		//IL_08c7: Expected Obj, but got I
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Expected Obj, but got Unknown
		//IL_090d: Expected Obj, but got I
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Expected Obj, but got Unknown
		//IL_07e0: Expected Obj, but got I4
		//IL_0968: Invalid comparison between VT and I4
		//IL_0985: Expected Obj, but got VT
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected Ref, but got Unknown
		//IL_09b9: Expected Obj, but got I
		//IL_09e3: Expected Obj, but got I4
		//IL_0a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Expected Ref, but got Unknown
		//IL_0a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1c: Expected Ref, but got Unknown
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Expected Ref, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		UnityEngine.Object obj4;
		if (e != null)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v117+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = e.prefab != null;
			bool flag3 = !flag2;
			obj4 = null;
			nint num = unchecked((nint)null);
			bool flag4 = false;
			if (!flag3)
			{
				if ((object)e.prefab != null)
				{
					Transform transform = e.prefab.transform;
					if ((object)transform != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C48]");
						object obj5 = 0;
						Transform transform2 = transform.Find((string)obj5);
						obj4 = transform2;
						num = unchecked((nint)null);
						flag4 = (byte)(int)obj5 != 0;
						goto IL_0ae7;
					}
				}
				goto IL_0aac;
			}
		}
		else
		{
			obj4 = null;
			bool flag4 = showOff;
		}
		goto IL_0ae7;
		IL_043f:
		UnityEngine.Object obj6 = default;
		GameObject gameObject = default;
		MonsterDisplay result;
		if ((object)obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC908]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v22+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj10 = default;
			bool flag6 = obj10 != null;
			bool flag7 = !flag6;
			object obj11 = 0;
			if (!flag7)
			{
				if ((object)obj10 == null)
				{
					goto IL_0aac;
				}
				object obj12 = obj10 + 32;
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				((Behaviour)obj10).enabled = false;
				obj11 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE18]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			MonsterDisplay monsterDisplay = default;
			if ((object)monsterDisplay != null)
			{
				object obj14 = monsterDisplay + 32;
				obj14 = e;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if ((object)obj6 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE20]");
					object obj15 = 0;
					UnityEngine.Object obj16 = (UnityEngine.Object)obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
					bool flag9;
					UnityEngine.Object obj19 = default;
					if (showOff)
					{
						object obj17 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v95+E4]");
						bool flag8 = (nint)0 == 0;
						object obj18 = !flag8;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						flag9 = obj19 != null;
						obj11 = 0;
						obj16 = null;
					}
					else
					{
						flag9 = false;
					}
					object obj20 = obj;
					monsterDisplay.showOff = flag9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v28+E4]");
					bool flag10 = (nint)0 == 0;
					object obj21 = !flag10;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (obj19 != null)
					{
						if ((object)obj19 == null)
						{
							goto IL_0aac;
						}
						_ = monsterDisplay.showOff;
					}
					if ((object)obj6 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC900]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
						object obj23 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v32+E4]");
						bool flag11 = (nint)0 == 0;
						object obj24 = !flag11;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						UnityEngine.Object obj25 = default;
						bool flag12 = obj25 != null;
						bool flag13 = !flag12;
						object obj26 = 0;
						if (!flag13)
						{
							if ((object)obj25 == null)
							{
								goto IL_0aac;
							}
							((Animator)obj25).fireEvents = false;
							((Animator)obj25).cullingMode = (AnimatorCullingMode)0;
							((Animator)obj25).Rebind();
							((Animator)obj25).Update(0f);
							((Animator)obj25).Update(0f);
							obj26 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7740]");
						object n = 0;
						MonsterGore._003C_003Ec__DisplayClass12_0 obj27 = default;
						Transform transform3 = _003CMake_003Eg__B_007C12_0((string)n, ref obj27);
						object obj28 = monsterDisplay + 48;
						obj28 = transform3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7738]");
						object n2 = 0;
						MonsterGore._003C_003Ec__DisplayClass12_0 obj29 = default;
						Transform transform4 = _003CMake_003Eg__B_007C12_0((string)n2, ref obj29);
						object obj30 = monsterDisplay + 56;
						obj30 = transform4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E0]");
						object n3 = 0;
						MonsterGore._003C_003Ec__DisplayClass12_0 obj31 = default;
						Transform transform5 = _003CMake_003Eg__B_007C12_0((string)n3, ref obj31);
						object obj32 = monsterDisplay + 64;
						obj32 = transform5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC940]");
						object n4 = 0;
						MonsterGore._003C_003Ec__DisplayClass12_0 obj33 = default;
						Transform transform6 = _003CMake_003Eg__B_007C12_0((string)n4, ref obj33);
						object obj34 = monsterDisplay + 72;
						obj34 = transform6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC948]");
						object n5 = 0;
						MonsterGore._003C_003Ec__DisplayClass12_0 obj35 = default;
						Transform transform7 = _003CMake_003Eg__B_007C12_0((string)n5, ref obj35);
						object obj36 = monsterDisplay + 80;
						obj36 = transform7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag15;
						if (~(e.hingeArms ? 1u : 0u) == 0)
						{
							if (obj35 == (MonsterGore._003C_003Ec__DisplayClass12_0)(object)0)
							{
								goto IL_0aac;
							}
							Transform model = ((GameObject)obj35).transform;
							Transform body = gameObject.transform;
							ref Quaternion reference = ref *(Quaternion*)(monsterDisplay + 128);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
							object obj37 = 0;
							object obj38 = obj37;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v80+E4]");
							bool flag14 = (nint)0 == 0;
							object obj39 = !flag14;
							if (obj39 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							flag15 = MonsterAvatar.HingeRestOf(model, body, monsterDisplay.up, monsterDisplay.lo, monsterDisplay.end, out *(Vector3*)(monsterDisplay + 92), out *(Vector3*)(monsterDisplay + 104), out *(Vector3*)(monsterDisplay + 116), out reference, out var _, out var _);
						}
						else
						{
							flag15 = false;
						}
						monsterDisplay.hinge = flag15;
						bool flag16 = (byte)(~(monsterDisplay.showOff ? 1u : 0u)) != 0;
						result = monsterDisplay;
						if (!flag16)
						{
							monsterDisplay.HoldUp();
							result = monsterDisplay;
						}
						goto IL_0a99;
					}
				}
			}
		}
		goto IL_0aac;
		IL_0aac:
		return (MonsterDisplay)(object)new NullReferenceException();
		IL_0ae7:
		object obj40 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v3+E4]");
		bool flag17 = (nint)0 == 0;
		object obj41 = !flag17;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag18 = obj4 == null;
		bool flag19 = !flag18;
		object obj42 = !flag19;
		result = null;
		if (obj42 != null)
		{
			goto IL_0a99;
		}
		if (e != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE28]");
			object obj43 = 0;
			string text = (string)obj43 + e.name;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			gameObject._002Ector(text);
			if ((object)obj4 != null)
			{
				GameObject gameObject2 = ((Component)obj4).gameObject;
				if ((object)gameObject != null)
				{
					Transform transform8 = gameObject.transform;
					object obj45 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v11+E4]");
					bool flag20 = (nint)0 == 0;
					object obj46 = !flag20;
					if (obj46 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC920]");
					object obj47 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDBD8");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					if ((object)obj6 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C48]");
						object obj48 = 0;
						obj6.name = (string)obj48;
						if ((object)obj6 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC910]");
							object obj49 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
							object obj50 = default;
							if (obj50 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v24+18]");
								if ((nint)0 < (nint)1)
								{
									goto IL_043f;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v24+18]");
								object obj51 = 0 & 0xFFFFFFFFL;
								object obj52 = obj50 + 32;
								object obj53 = 0;
								object obj54 = 1;
								while (true)
								{
									bool flag21 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj53) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj51);
									object obj55 = !flag21;
									if (obj55 != null)
									{
										break;
									}
									object obj56 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v108+E4]");
									bool flag22 = (nint)0 == 0;
									object obj57 = !flag22;
									if (obj57 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X26_v4+v125 @ X25_v7*8]");
									UnityEngine.Object.Destroy((UnityEngine.Object)0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v24+18]");
									obj51 = 0;
									obj53++;
									object obj58 = obj53;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v24+18]");
									bool flag23 = (nint)obj58 < 0;
									obj54 = 0;
									if (flag23)
									{
										continue;
									}
									goto IL_043f;
								}
								IndexOutOfRangeException ex = new IndexOutOfRangeException();
							}
						}
					}
				}
			}
		}
		goto IL_0aac;
		IL_0a99:
		return result;
	}

	public unsafe static Bounds Posed(GameObject go)
	{
		//IL_08e8: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_04ff: Expected F8, but got I4
		//IL_0508: Expected F8, but got I4
		//IL_0512: Expected F8, but got I4
		//IL_052b: Expected F8, but got I4
		//IL_055c: Expected F8, but got I4
		//IL_0565: Expected F8, but got I4
		//IL_056e: Expected F8, but got I4
		//IL_0577: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		//IL_00a2: Expected F8, but got I4
		//IL_00ab: Expected F8, but got I4
		//IL_00b5: Expected F8, but got I4
		//IL_00be: Expected F8, but got I4
		//IL_00c7: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I4
		//IL_00d9: Expected F8, but got I4
		//IL_00e2: Expected F8, but got I4
		//IL_00eb: Expected F8, but got I4
		//IL_00f4: Expected F8, but got I4
		//IL_00fd: Expected F8, but got I4
		//IL_010e: Expected Obj, but got I4
		//IL_0fd2: Expected Obj, but got I
		//IL_0ffc: Expected Obj, but got I4
		//IL_0bc4: Expected Obj, but got I4
		//IL_0f66: Expected native int or pointer, but got VT
		//IL_0f75: Expected VT, but got Ref
		//IL_0156: Expected Obj, but got I
		//IL_0434: Expected Obj, but got I
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		//IL_01af: Expected Obj, but got I8
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_0263: Expected Obj, but got I4
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected Obj, but got Unknown
		//IL_0f8e: Expected Obj, but got I4
		//IL_0594: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I4
		//IL_05e3: Expected Obj, but got I4
		//IL_02c1: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I4
		//IL_090f: Expected Obj, but got I4
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Expected Obj, but got Unknown
		//IL_09c6: Expected Obj, but got I4
		//IL_09cf: Expected Obj, but got I4
		//IL_060b: Expected Obj, but got I8
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected Obj, but got Unknown
		//IL_066a: Expected Obj, but got I4
		//IL_0673: Expected Obj, but got I4
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0eaa: Expected Obj, but got I4
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected Obj, but got Unknown
		//IL_041b: Expected Obj, but got I
		//IL_0b3c: Expected Obj, but got I
		//IL_0b4c: Expected F8, but got I
		//IL_0353: Expected Obj, but got I
		//IL_0fad: Expected Obj, but got I4
		//IL_07d7: Expected Obj, but got I
		//IL_0a05: Invalid comparison between F8 and I4
		//IL_0a14: Invalid comparison between F8 and I4
		//IL_0a27: Expected Obj, but got F8
		//IL_0a34: Expected Obj, but got F8
		//IL_0a7d: Expected Obj, but got I4
		//IL_0a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8a: Expected Obj, but got Unknown
		//IL_07fd: Expected Obj, but got I
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Expected Obj, but got Unknown
		//IL_085a: Expected Obj, but got I4
		//IL_06d9: Expected Obj, but got I
		//IL_0bef: Invalid comparison between F8 and I4
		//IL_0bfe: Invalid comparison between F8 and I4
		//IL_0c11: Expected Obj, but got F8
		//IL_0c1e: Expected Obj, but got F8
		//IL_0c53: Expected Obj, but got I4
		//IL_0c5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c60: Expected Obj, but got Unknown
		//IL_0d72: Invalid comparison between F8 and I4
		//IL_0d81: Invalid comparison between F8 and I4
		//IL_0d94: Expected Obj, but got F8
		//IL_0da1: Expected Obj, but got F8
		//IL_0dea: Expected Obj, but got I4
		//IL_0df2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df7: Expected Obj, but got Unknown
		double num3;
		object obj7;
		double num6;
		double num11 = default;
		double num15 = default;
		double num17 = default;
		double num19 = default;
		double num21 = default;
		double num23 = default;
		double num;
		double num2;
		Bounds bounds2 = default;
		double num41;
		double num42;
		Bounds bounds3;
		Bounds bounds;
		GameObject gameObject2;
		object obj2;
		double num34;
		double num35;
		double num36;
		double num37;
		double num38;
		double num39;
		double num40;
		if ((object)go != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C58]");
			object obj = 0;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
			object obj3 = default;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v5+18]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v5+18]");
				UnityEngine.Object obj12;
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj6 = 0;
					num = 0.0;
					num2 = 0.0;
					num3 = 0.0;
					double num4 = 0.0;
					obj7 = 0;
					object obj8 = 0;
					double num5 = 0.0;
					num6 = 0.0;
					double num7 = 0.0;
					double num8 = 0.0;
					double num9 = 0.0;
					GameObject gameObject = go;
					object obj9 = 109895680;
					object obj15 = default;
					object obj17 = default;
					while (true)
					{
						bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
						object obj10 = !flag;
						if (obj10 != null)
						{
							break;
						}
						object obj11 = obj3 + obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v27+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v27+20]");
							Transform[] bones = ((SkinnedMeshRenderer)0).bones;
							if (bones != null)
							{
								bool flag2 = bones.Length < 1;
								obj12 = null;
								if (!flag2)
								{
									object obj13 = bones.Length & 0xFFFFFFFFL;
									gameObject = (GameObject)(bones + 32);
									double num10 = num11;
									object obj14 = obj15;
									double num12 = num;
									double num13 = num2;
									double num14 = num15;
									object obj16 = obj17;
									double num16 = num17;
									double num18 = num19;
									double num20 = num21;
									double num22 = num23;
									double num24 = num3;
									double num25 = num4;
									object obj18 = obj7;
									double num26 = num5;
									double num27 = num6;
									double num28 = num7;
									double num29 = num8;
									double num30 = num9;
									object obj19 = obj2;
									UnityEngine.Object obj20 = null;
									object obj21 = 0;
									while (true)
									{
										bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13);
										object obj22 = !flag3;
										if (obj22 != null)
										{
											break;
										}
										object obj23 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v31+E4]");
										bool flag4 = (nint)0 == 0;
										object obj24 = !flag4;
										if (obj24 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X20_v9 (UnityEngine.GameObject)+v397 @ X19_v15*8]");
										bool flag5 = (UnityEngine.Object)0 == null;
										bool flag6 = !flag5;
										object obj25 = !flag6;
										obj12 = null;
										if (obj25 == null)
										{
											object obj26 = obj18 & 1;
											if (obj26 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X20_v9 (UnityEngine.GameObject)+v397 @ X19_v15*8]");
												if ((nint)0 == 0)
												{
													goto IL_08da;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X20_v9 (UnityEngine.GameObject)+v397 @ X19_v15*8]");
												Vector3 position = ((Transform)0).position;
												num22 = num29 - num28;
												num18 = num29 + num28;
												num16 = num25 - num26;
												num20 = num25 + num26;
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
												if (!(num22 < num30))
												{
													num22 = num30;
												}
												double num31 = num18 - num30;
												bool flag7 = num31 < 0.0;
												bool flag8 = num31 == 0.0;
												object obj27 = num18 ^ num30;
												object obj28 = num18 ^ num31;
												object obj29 = obj27 & obj28;
												bool flag9 = (nint)obj29 < 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
												bool flag10 = flag7 == flag9;
												obj14 = !flag8;
												object obj30 = flag10 & obj14;
												obj16 = ~obj30;
												if (obj16 == null)
												{
													num30 = num18;
												}
												num14 -= num16;
												double num32 = num30 - num22;
												num26 = num14 * 63.0;
												num27 = num32 * 0.5;
												double num33 = num16 + num26;
												num29 = num22 + num27;
												num10 = num27;
												num12 = num26;
												num25 = num33;
												obj12 = null;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X20_v9 (UnityEngine.GameObject)+v397 @ X19_v15*8]");
												if ((nint)0 == 0)
												{
													goto IL_08da;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X20_v9 (UnityEngine.GameObject)+v397 @ X19_v15*8]");
												Vector3 position2 = ((Transform)0).position;
												object obj31 = obj6;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1062 @ X8_v38+A0]");
												object obj32 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ X8_v39+4]");
												num22 = 0.0;
												num27 = (double)obj32 * 0.5;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ X8_v39+4]");
												num26 = 0.0 * 63.0;
												num10 = num27;
												num12 = num26;
												num13 = num18;
												num25 = num14;
												num29 = num30;
												obj12 = null;
											}
											num24 = num26;
											obj18 = 1;
											num28 = num27;
											num30 = num26;
										}
										obj13 = bones.Length;
										obj9 = obj21 + 1;
										bool flag11 = (nint)obj9 < bones.Length;
										num11 = num10;
										obj15 = obj14;
										num = num12;
										num2 = num13;
										num15 = num14;
										obj17 = obj16;
										num17 = num16;
										num19 = num18;
										num21 = num20;
										num23 = num22;
										num3 = num24;
										num4 = num25;
										obj7 = obj18;
										num5 = num26;
										num6 = num27;
										num7 = num28;
										num8 = num29;
										num9 = num30;
										obj2 = 0;
										obj19 = 0;
										obj20 = obj12;
										obj21 = obj9;
										if (flag11)
										{
											continue;
										}
										goto IL_0424;
									}
									break;
								}
								goto IL_0424;
							}
						}
						goto IL_08da;
						IL_0424:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v5+18]");
						obj4 = 0;
						obj8++;
						object obj33 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v5+18]");
						if ((nint)obj33 < 0)
						{
							continue;
						}
						goto IL_0466;
					}
					goto IL_08cc;
				}
				num = 0.0;
				num2 = 0.0;
				num34 = 0.0;
				bounds = bounds2;
				gameObject2 = go;
				num35 = 0.0;
				num36 = num15;
				num37 = num17;
				num38 = num19;
				num39 = num21;
				num40 = num23;
				num6 = 0.0;
				num41 = 0.0;
				num42 = 0.0;
				obj12 = (UnityEngine.Object)1;
				bounds3 = bounds2;
				goto IL_0fc2;
			}
		}
		goto IL_08da;
		IL_0466:
		object obj34 = obj7 & 1;
		bool flag12 = obj34 == null;
		num34 = num3;
		bounds = bounds2;
		gameObject2 = go;
		if (!flag12)
		{
			num35 = num;
			num36 = num15;
			num37 = num17;
			num38 = num19;
			num39 = num21;
			num40 = num23;
			double num43 = default;
			num41 = num43;
			num42 = num3;
			bounds3 = bounds2;
			goto IL_0fc2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49E8]");
		object obj35 = 0;
		obj2 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
		object obj36 = default;
		double num44 = default;
		if (obj36 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v19+18]");
			bool flag13 = (nint)0 < (nint)1;
			UnityEngine.Object obj12 = (UnityEngine.Object)1;
			if (flag13)
			{
				goto IL_0868;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v19+18]");
			object obj37 = 0 & 0xFFFFFFFFL;
			object obj38 = obj36 + 32;
			double num45 = default;
			num44 = num45;
			double num46 = num11;
			double num48 = default;
			double num47 = num48;
			double num50 = default;
			double num49 = num50;
			double num51 = num15;
			double num52 = num17;
			double num53 = num19;
			double num54 = num21;
			double num55 = num23;
			object obj39 = 0;
			object obj40 = 0;
			object obj43 = default;
			object obj44 = default;
			object obj45 = default;
			object obj46 = default;
			while (true)
			{
				bool flag14 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj37);
				object obj41 = !flag14;
				if (obj41 != null)
				{
					break;
				}
				object obj42 = obj39 & 1;
				if (obj42 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X21_v7+v399 @ X19_v10*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X21_v7+v399 @ X19_v10*8]");
						Bounds bounds4 = ((Renderer)0).bounds;
						double num56 = (double)obj43 - (double)obj44;
						double num57 = (double)obj43 + (double)obj44;
						double num58 = num2 - num44;
						double num59 = num2 + num44;
						num52 = (double)obj45 + (double)obj46;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
						if (!(num58 < num56))
						{
							num58 = num56;
						}
						double num60 = num59 - num56;
						bool flag15 = num60 < 0.0;
						bool flag16 = num60 == 0.0;
						object obj47 = num59 ^ num56;
						object obj48 = num59 ^ num60;
						object obj49 = obj47 & obj48;
						bool flag17 = (nint)obj49 < 0;
						bool flag18 = flag15 == flag17;
						object obj50 = !flag16;
						object obj51 = flag18 & obj50;
						object obj52 = ~obj51;
						if (obj52 != null)
						{
							num59 = num56;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
						double num61 = num59 - num58;
						double num62 = num46 - num44;
						double num63 = num61 * 0.5;
						num49 = num62 * 63.0;
						num47 = num58 + num63;
						double num64 = num44 + num49;
						double num65 = num47 - num63;
						double num66 = num63 + num47;
						num54 = num64 - num49;
						double num67 = num49 + num64;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
						if (!(num65 < num57))
						{
							num65 = num57;
						}
						double num68 = num66 - num57;
						bool flag19 = num68 < 0.0;
						bool flag20 = num68 == 0.0;
						object obj53 = num66 ^ num57;
						object obj54 = num66 ^ num68;
						object obj55 = obj53 & obj54;
						bool flag21 = (nint)obj55 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
						bool flag22 = flag19 == flag21;
						object obj15 = !flag20;
						object obj56 = flag22 & obj15;
						object obj17 = ~obj56;
						if (obj17 == null)
						{
							num57 = num66;
						}
						double num69 = num67 - num54;
						double num70 = num57 - num65;
						num53 = num69 * 63.0;
						num34 = num70 * 0.5;
						num55 = num54 + num53;
						num51 = num65 + num34;
						num44 = num34;
						num11 = num53;
						num2 = num51;
						obj12 = null;
						goto IL_07ed;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X21_v7+v399 @ X19_v10*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X21_v7+v399 @ X19_v10*8]");
						Bounds bounds5 = ((Renderer)0).bounds;
						num11 = num46;
						obj12 = null;
						goto IL_07ed;
					}
				}
				goto IL_08da;
				IL_07ed:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v19+18]");
				obj37 = 0;
				obj40++;
				object obj57 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v19+18]");
				bool flag23 = (nint)obj57 < 0;
				num15 = num51;
				num17 = num52;
				num19 = num53;
				num21 = num54;
				num23 = num55;
				num46 = num11;
				obj39 = 1;
				if (flag23)
				{
					continue;
				}
				goto IL_0868;
			}
			goto IL_08cc;
		}
		goto IL_08da;
		IL_0fc2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj58 = 0;
		object obj59 = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v8+E4]");
		bool flag24 = (nint)0 == 0;
		object obj60 = !flag24;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num71 = num42 + num42;
		double num72 = num6 + num6;
		double num73 = num41 + num41;
		double num74 = num72 * num72;
		double num75 = num71 * num71;
		double num76 = num74 + num75;
		double num77 = num73 * num73;
		double num78 = num76 + num77;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num79 = (float)num78;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
		float amount = num79 * 0f;
		Bounds center = default;
		center.Expand(amount);
		((Bounds*)(nint)bounds3)->m_Center = (Vector3)center;
		return (Bounds)(&center);
		IL_08da:
		NullReferenceException ex = new NullReferenceException();
		return (Bounds)ex;
		IL_0868:
		num35 = num;
		num36 = num15;
		num37 = num17;
		num38 = num19;
		num39 = num21;
		num40 = num23;
		num6 = num11;
		num41 = num44;
		num42 = num;
		bounds3 = bounds;
		goto IL_0fc2;
		IL_08cc:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_08da;
	}

	private void LateUpdate()
	{
		if (~(showOff ? 1u : 0u) == 0)
		{
			HoldUp();
		}
	}

	private void HoldUp()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0b94: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got VT
		//IL_0bb2: Expected Obj, but got I
		//IL_0bdc: Expected Obj, but got I4
		//IL_0225: Expected Obj, but got VT
		//IL_0c14: Expected Obj, but got I4
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_0349: Expected VT, but got Obj
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_0c32: Expected Obj, but got I
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4f: Expected Obj, but got Unknown
		//IL_0c5f: Expected Obj, but got I
		//IL_0c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c74: Expected Obj, but got Unknown
		//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c89: Expected Obj, but got Unknown
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9e: Expected Obj, but got Unknown
		//IL_04f3: Expected Obj, but got I
		//IL_051d: Expected Obj, but got I4
		//IL_0562: Expected VT, but got I4
		//IL_056b: Expected VT, but got I4
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected Obj, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_042e: Expected Obj, but got I
		//IL_043e: Expected Obj, but got I
		//IL_0de7: Expected Obj, but got I4
		//IL_0cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cff: Expected Obj, but got Unknown
		//IL_0d1c: Expected Obj, but got I
		//IL_06c6: Expected Obj, but got I4
		//IL_0d67: Expected Obj, but got I4
		//IL_06fe: Expected Obj, but got I4
		//IL_04bd: Invalid comparison between F8 and I
		//IL_0745: Expected Obj, but got I4
		//IL_0d85: Expected Obj, but got I
		//IL_0daf: Expected Obj, but got I4
		//IL_062f: Expected Obj, but got VT
		//IL_062f: Expected VT, but got I
		//IL_062f: Expected VT, but got I4
		//IL_062f: Expected VT, but got I4
		//IL_062f: Expected VT, but got I4
		//IL_0638: Expected VT, but got I4
		//IL_0793: Expected Obj, but got VT
		//IL_07b0: Expected Obj, but got I
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Expected Obj, but got Unknown
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Expected Obj, but got Unknown
		//IL_086e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected Obj, but got Unknown
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0880: Expected VT, but got Unknown
		//IL_08a8: Unsupported input type for neg.
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Expected Obj, but got Unknown
		//IL_08b1: Unsupported input type for neg.
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected VT, but got Unknown
		//IL_08ba: Unsupported input type for neg.
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected Obj, but got Unknown
		//IL_097d: Expected VT, but got I4
		//IL_09eb: Invalid comparison between F8 and I
		//IL_0a0c: Expected Obj, but got VT
		//IL_0a7b: Expected Obj, but got VT
		//IL_0a98: Expected Obj, but got I
		//IL_0ac2: Expected Obj, but got I
		//IL_0b64: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = up == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = lo == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X0_v11+E4]");
		bool flag7 = (nint)0 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = end == null;
		bool flag9 = !flag8;
		object obj10 = !flag9;
		if (obj10 != null)
		{
			return;
		}
		Transform transform = base.transform;
		Vector3 forward = transform.forward;
		Transform transform2 = base.transform;
		Vector3 right = transform2.right;
		Vector3 position = lo.position;
		Vector3 position2 = up.position;
		Vector3 vector = default;
		object obj11 = vector - vector;
		object obj13 = default;
		object obj12 = obj13 - obj13;
		object obj15 = default;
		object obj14 = obj15 - obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj16 = 0;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v28+E4]");
		bool flag10 = (nint)0 == 0;
		object obj18 = !flag10;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 position3 = end.position;
		Vector3 position4 = lo.position;
		object obj19 = vector - vector;
		object obj20 = obj13 - obj13;
		object obj21 = obj15 - obj15;
		object obj22 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X0_v35+E4]");
		bool flag11 = (nint)0 == 0;
		object obj23 = !flag11;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj24 = obj11 * obj11;
		object obj25 = obj12 * obj12;
		object obj26 = obj14 * obj14;
		object obj27 = obj24 + obj25;
		object obj28 = obj19 * obj19;
		object obj29 = obj27 + obj26;
		object obj30 = obj20 * obj20;
		object obj31 = obj28 + obj30;
		object obj32 = obj21 * obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj33 = obj31 + obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj34 = obj29 + obj33;
		Vector3 position5 = up.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		object obj35 = obj34 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		object obj36 = obj34 * 0;
		object obj37 = vector * obj35;
		Vector3 vector2 = (Vector3)(obj13 * obj35);
		object obj38 = obj15 * obj35;
		object obj39 = obj37 + obj29;
		object obj40 = vector2 + obj33;
		object obj41 = obj38 + obj32;
		object obj42 = vector * obj36;
		object obj43 = obj13 * obj36;
		object obj44 = obj15 * obj36;
		object obj45 = obj42 + obj39;
		object obj46 = obj43 + obj40;
		object obj47 = obj44 + obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj48 = 0;
		object obj49 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		object obj50 = obj34 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v19+A0]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v33+18]");
		object obj52 = obj50 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v33+1C]");
		object obj53 = obj50 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v33+20]");
		object obj54 = obj50 * 0;
		float num = (float)obj45 + (float)obj52;
		object obj55 = obj46 + obj53;
		object obj56 = obj47 + obj54;
		object obj72;
		object obj75;
		if (~(hinge ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj57 = vector * 63;
			double num2 = (double)obj15 * 0.5;
			object obj58 = vector * obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA8C]");
			object obj59 = obj15 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterDisplay)+60]");
			object obj60 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterDisplay)+64]");
			object obj61 = 0;
			object obj62 = obj57 + obj58;
			double num3 = num2 + (double)obj59;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v33+24]");
			object obj63 = 0 * obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v33+2C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			object obj64 = num4 * 0;
			object obj65 = obj62 + obj63;
			double num5 = num3 + (double)obj64;
			object obj66 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X0_v87+E4]");
			bool flag12 = (nint)0 == 0;
			object obj67 = !flag12;
			if (obj67 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj68 = obj65 * obj65;
			double num6 = num5 * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			double num7 = (double)obj68 + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if (num7 > 0.0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
			object obj69 = 0;
			object obj70 = obj69;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X0_v89+E4]");
			bool flag13 = (nint)0 == 0;
			object obj71 = !flag13;
			if (obj71 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Transform transform3 = up;
			Transform transform4 = lo;
			Transform transform5 = end;
			Vector3 pole = hingeUp;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterDisplay)+70]");
			nint num8 = 0;
			Vector3 handRest = alongLo;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterDisplay)+7C]");
			Vector3 vector3 = default;
			Quaternion quaternion = default;
			MonsterAvatar.HingeReach(transform3, transform4, transform5, (Vector3)0, (Vector3)0, (Vector3)0, vector3, quaternion, pole, num, (Quaternion)num8, (Quaternion)handRest, handTurns: false, (MonsterAvatar.Swing)restRel);
			Vector3 vector4 = (Vector3)0;
			Vector3 vector5 = alongUp;
			vector2 = hingeUp;
			obj72 = obj56;
			object obj73 = obj55;
			float num9 = num;
			object obj74 = obj65;
			obj75 = obj15;
			Transform transform6 = end;
			Transform transform7 = lo;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC918]");
			object obj76 = 0;
			object obj77 = obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X0_v80+E4]");
			bool flag14 = (nint)0 == 0;
			object obj78 = !flag14;
			if (obj78 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 side = default;
			Vector3 back = default;
			MonsterAvatar.Reach(up, lo, end, (Vector3)0, side, back, num);
			Vector3 vector4 = (Vector3)0;
			object obj60 = obj13;
			Vector3 vector5 = vector;
			object obj61 = obj15;
			obj72 = obj56;
			object obj73 = obj55;
			float num9 = num;
			object obj74 = obj19;
			obj75 = obj15;
			Transform transform6 = end;
			Transform transform7 = lo;
		}
		object obj79 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X0_v41+E4]");
		bool flag15 = (nint)0 == 0;
		object obj80 = !flag15;
		if (obj80 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag16 = i1 == null;
		bool flag17 = !flag16;
		object obj81 = !flag17;
		if (obj81 != null)
		{
			return;
		}
		object obj82 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X0_v45+E4]");
		bool flag18 = (nint)0 == 0;
		object obj83 = !flag18;
		if (obj83 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag19 = p1 == null;
		bool flag20 = !flag19;
		object obj84 = !flag20;
		if (obj84 != null)
		{
			return;
		}
		MonsterDirector.Entry entry = this.entry;
		if (this.entry == null)
		{
			return;
		}
		object obj85 = entry.palmR * entry.palmR;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v24 (MonsterDirector+Entry)+58]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v24 (MonsterDirector+Entry)+58]");
		object obj86 = num10 * 0;
		object obj87 = obj85 + obj86;
		object obj89 = default;
		object obj88 = obj87 + obj89;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		if ((nint)obj88 < 0)
		{
			return;
		}
		Vector3 position6 = i1.position;
		Vector3 position7 = p1.position;
		Vector3 position8 = end.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
		object obj90 = obj88 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
		object obj91 = obj89 * 0;
		object obj92 = obj72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
		object obj93 = obj92 * 0;
		Vector3 vector6 = vector + obj90;
		object obj94 = obj13 + obj91;
		object obj95 = obj75 + obj93;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
		object obj96 = 0 - obj15;
		Vector3 vector7 = 0 - vector;
		object obj97 = 0 - obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2ECCDCC");
		MonsterDirector.Entry entry2 = this.entry;
		object obj98 = obj72 + obj72;
		object obj99 = obj89 + obj89;
		object obj100 = obj88 + obj88;
		double num11 = (double)obj98 * 0.5;
		double num12 = (double)obj99 * 0.5;
		double num13 = (double)obj100 * 0.5;
		double num14 = num13 - (double)obj88;
		double num15 = num12 - (double)obj89;
		double num16 = num11 - (double)obj72;
		Vector3 vector8 = end.TransformDirection((Vector3)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2ECCDCC");
		double num17 = num14 * num14;
		double num18 = num15 * num15;
		double num19 = num17 + num18;
		double num20 = num16 * num16;
		double num21 = num20 + num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
		if (num21 < 0.0)
		{
			return;
		}
		object obj101 = vector7 * vector7;
		object obj102 = obj97 * obj97;
		object obj103 = obj101 + obj102;
		object obj104 = obj96 * obj96;
		object obj105 = obj104 + obj103;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		if ((nint)obj105 >= 0)
		{
			object obj106 = entry2.palmR * entry2.palmR;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X8_v27 (MonsterDirector+Entry)+58]");
			nint num22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X8_v27 (MonsterDirector+Entry)+58]");
			object obj107 = num22 * 0;
			object obj108 = obj106 + obj107;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X8_v27 (MonsterDirector+Entry)+5C]");
			nint num23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X8_v27 (MonsterDirector+Entry)+5C]");
			object obj109 = num23 * 0;
			object obj110 = obj109 + obj108;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			if ((nint)obj110 >= 0)
			{
				Vector3 forward2 = default;
				Vector3 upwards = default;
				Quaternion quaternion2 = Quaternion.Internal_LookRotation(ref forward2, ref upwards);
				Quaternion quaternion3 = Quaternion.Internal_LookRotation(ref forward2, ref upwards);
				Quaternion rotation = default;
				Quaternion quaternion4 = Quaternion.Internal_Inverse(ref rotation);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
				Quaternion rotation2 = end.rotation;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
				end.rotation = (Quaternion)0;
			}
		}
	}

	public MonsterDisplay()
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0037: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v5+A0]");
		restRel = (Quaternion)(object)0;
		base._002Ector();
	}

	internal static Transform _003CMake_003Eg__B_007C12_0(string n, ref MonsterGore._003C_003Ec__DisplayClass12_0 P_1)
	{
		//IL_018b: Invalid comparison between VT and I4
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0088: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		Transform result;
		if (P_1 != (MonsterGore._003C_003Ec__DisplayClass12_0)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B28]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
			object obj2 = default;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v7+18]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v7+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_0157;
				}
				object obj4 = obj2 + 32;
				object obj5 = 0;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
					object obj6 = !flag;
					if (obj6 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X23_v6+v51 @ X22_v7*8]");
					if ((nint)0 == 0)
					{
						goto IL_0161;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X23_v6+v51 @ X22_v7*8]");
					string text = ((UnityEngine.Object)0).name;
					bool flag2 = text == n;
					bool flag3 = !flag2;
					object obj7 = !flag3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X23_v6+v51 @ X22_v7*8]");
					result = (Transform)0;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v7+18]");
						obj3 = 0;
						obj5++;
						object obj8 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v7+18]");
						if ((nint)obj8 < 0)
						{
							continue;
						}
						goto IL_0157;
					}
					goto IL_019f;
				}
				goto IL_016f;
			}
		}
		goto IL_0161;
		IL_019f:
		return result;
		IL_0161:
		NullReferenceException ex = new NullReferenceException();
		goto IL_016f;
		IL_016f:
		return (Transform)(object)new IndexOutOfRangeException();
		IL_0157:
		result = null;
		goto IL_019f;
	}
}
