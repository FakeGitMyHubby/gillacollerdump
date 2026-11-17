using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class BecomeMonsterButton : MonoBehaviour
{
	public int monster;

	public Transform[] hands;

	public float radius = 0.13f;

	private float cooldown;

	private Vector3 baseScale;

	private void Start()
	{
		Transform transform = base.transform;
		Vector3 localScale = transform.localScale;
		Vector3 vector = default;
		baseScale = vector;
	}

	private void Update()
	{
		//IL_0078: Invalid comparison between F8 and I4
		//IL_0087: Expected F8, but got I4
		//IL_015c: Expected VT, but got I4
		//IL_0171: Invalid comparison between F4 and I4
		//IL_01b4: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I4
		//IL_05a2: Expected Obj, but got I4
		//IL_05e7: Expected Obj, but got I
		//IL_05f7: Expected Obj, but got I
		//IL_0621: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I4
		//IL_02b8: Expected Obj, but got I8
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_02d1: Expected Obj, but got I4
		//IL_02da: Expected Obj, but got I4
		//IL_05c9: Expected Obj, but got I4
		//IL_030e: Expected Obj, but got I4
		//IL_033d: Expected Obj, but got I
		//IL_035b: Expected Obj, but got I4
		//IL_04bc: Expected Obj, but got I4
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got Unknown
		//IL_04e3: Expected Obj, but got I4
		//IL_03b4: Expected Obj, but got I
		float deltaTime = Time.deltaTime;
		float num = (cooldown -= deltaTime);
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		if ((object)transform2 != null)
		{
			Vector3 localScale = transform2.localScale;
			float deltaTime2 = Time.deltaTime;
			float num2 = deltaTime2 * -10f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
			double num3 = 1.0 - (double)num2;
			bool flag = num3 < 0.0;
			double num4 = 0.0;
			if (!flag)
			{
				bool flag2 = !(num3 > 1.0);
				num4 = num3;
				if (!flag2)
				{
					num4 = 1.0;
				}
			}
			if ((object)transform != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BecomeMonsterButton)+40]");
				double num6 = default;
				double num5 = 0.0 - num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BecomeMonsterButton)+3C]");
				double num8 = default;
				double num7 = 0.0 - num8;
				float num9 = (float)baseScale - num;
				double num10 = num5 * num4;
				double num11 = num7 * num4;
				double num12 = num6 + num10;
				double num13 = num8 + num11;
				transform.localScale = (Vector3)0;
				float num14 = cooldown;
				if (cooldown > 0f || hands == null)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v16+E4]");
				bool flag3 = (nint)0 == 0;
				object obj3 = !flag3;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v20+E4]");
				bool flag4 = (nint)0 == 0;
				object obj5 = !flag4;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj4 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v20+A0]");
				object obj7 = 0;
				object obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v11+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag6 = (UnityEngine.Object)obj7 == null;
				bool flag7 = !flag6;
				object obj10 = !flag7;
				if (obj10 != null)
				{
					return;
				}
				Transform[] array = hands;
				if (hands != null)
				{
					if (array.Length < 1)
					{
						return;
					}
					object obj11 = array.Length & 0xFFFFFFFFL;
					object obj12 = hands + 32;
					object obj13 = 0;
					object obj14 = 0;
					UnityEngine.Object obj15 = null;
					while (true)
					{
						bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
						object obj16 = !flag8;
						if (obj16 != null)
						{
							break;
						}
						object obj17 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X0_v25+E4]");
						bool flag9 = (nint)0 == 0;
						object obj18 = !flag9;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X24_v5+v80 @ X23_v6*8]");
						bool flag10 = (UnityEngine.Object)0 == null;
						bool flag11 = !flag10;
						object obj19 = !flag11;
						double num15 = num12;
						double num16 = num13;
						obj15 = null;
						if (obj19 != null)
						{
							goto IL_04b2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X24_v5+v80 @ X23_v6*8]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X24_v5+v80 @ X23_v6*8]");
							Vector3 position = ((Transform)0).position;
							Transform transform3 = base.transform;
							if ((object)transform3 != null)
							{
								Vector3 position2 = transform3.position;
								float num17 = num14 - num14;
								double num18 = num13 - num13;
								double num19 = num12 - num12;
								float num20 = num17 * num17;
								double num21 = num18 * num18;
								float num22 = num20 + (float)num21;
								double num23 = num19 * num19;
								num15 = radius;
								double num24 = num23 + (double)num22;
								num16 = (double)radius * (double)radius;
								bool flag12 = !(num24 > num16);
								obj15 = null;
								num14 = (float)num24;
								if (!flag12)
								{
									goto IL_04b2;
								}
								Press();
								return;
							}
						}
						goto IL_0509;
						IL_04b2:
						obj11 = array.Length;
						obj13++;
						bool flag13 = (nint)obj13 < array.Length;
						obj14 = 0;
						num12 = num15;
						num13 = num16;
						if (!flag13)
						{
							return;
						}
					}
					goto IL_0517;
				}
			}
		}
		goto IL_0509;
		IL_0517:
		throw new IndexOutOfRangeException();
		IL_0509:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0517;
	}

	public void Click()
	{
		//IL_00c5: Invalid comparison between F4 and I4
		//IL_00d6: Expected Obj, but got I4
		//IL_00e1: Invalid comparison between F4 and I4
		//IL_00f2: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0125: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I4
		bool flag = cooldown < 0f;
		object obj = !flag;
		bool flag2 = cooldown == 0f;
		object obj2 = !flag2;
		object obj3 = obj & obj2;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj4;
			}
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v7+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v8+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj11 != null)
			{
				Press();
			}
		}
	}

	private void Press()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I
		//IL_004b: Expected Obj, but got I
		//IL_0059: Expected VT, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got I
		cooldown = 1f;
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj2 = default;
		object obj = baseScale * obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BecomeMonsterButton)+40]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		object obj4 = num * 0;
		transform.localScale = (Vector3)0;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v10+A0]");
		object obj9 = 0;
		((MonsterPlayer)obj9).Become(monster);
	}
}
