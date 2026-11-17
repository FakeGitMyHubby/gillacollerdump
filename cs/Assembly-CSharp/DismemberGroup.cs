using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.XR;

public class DismemberGroup : MonoBehaviour
{
	public Dismemberment[] copies;

	public float flingSpeed;

	public float tearHaptic;

	public float tearHapticSeconds;

	public bool IsTorn(ApePart part)
	{
		//IL_01d4: Expected I4, but got Obj
		//IL_0053: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I4
		//IL_0170: Expected I4, but got Obj
		Dismemberment[] array = copies;
		bool result;
		if (copies != null && array.Length != 0)
		{
			if (array.Length == 0)
			{
				goto IL_01b8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (array[0] != null)
			{
				Dismemberment[] array2 = copies;
				if (copies != null)
				{
					if (array2.Length == 0)
					{
						goto IL_01b8;
					}
					if ((object)array2[0] != null)
					{
						Dismemberment.Part part2 = array2[0].Find(part);
						bool flag2 = part2 == null;
						result = (byte)(int)part2 != 0;
						if (!flag2)
						{
							bool flag3 = !part2.torn;
							bool flag4 = !flag3;
							result = flag4;
						}
						goto IL_01fd;
					}
				}
				goto IL_01c6;
			}
		}
		result = false;
		goto IL_01fd;
		IL_01c6:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_01b8:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_01c6;
		IL_01fd:
		return result;
	}

	public void Tear(ApePart part)
	{
		//IL_0053: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I4
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_03db: Expected F4, but got I
		//IL_0475: Expected VT, but got I4
		//IL_0497: Expected Obj, but got I8
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected Obj, but got Unknown
		//IL_04ae: Expected Obj, but got I4
		//IL_04cf: Expected VT, but got I4
		//IL_065b: Expected Obj, but got I
		//IL_068f: Expected Obj, but got I4
		//IL_0800: Expected Obj, but got I4
		//IL_0838: Expected Obj, but got I4
		//IL_04fe: Expected Obj, but got I4
		//IL_052d: Expected Obj, but got I
		//IL_05a0: Expected Obj, but got I4
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected Obj, but got Unknown
		//IL_05df: Expected VT, but got I4
		//IL_05e8: Expected VT, but got I4
		//IL_0571: Expected VT, but got I4
		//IL_0571: Expected Obj, but got I
		Dismemberment[] array = copies;
		if (copies == null || array.Length == 0)
		{
			return;
		}
		object obj;
		if (array.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = array[0] == null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 != null)
			{
				return;
			}
			Dismemberment[] array2 = copies;
			if (array2.Length != 0)
			{
				Dismemberment.Part part2 = array2[0].Find(part);
				if (part2 != null)
				{
					bool flag4 = (byte)(~(part2.torn ? 1u : 0u)) != 0;
					object obj5 = !flag4;
					if (obj5 != null)
					{
						return;
					}
				}
				Transform transform = base.transform;
				Vector3 up = transform.up;
				object obj6 = default;
				double num = (double)obj6 * 1.5;
				object obj7 = default;
				double num2 = (double)obj7 * 1.5;
				object obj8 = default;
				double num3 = (double)obj8 * 1.5;
				Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				object obj9 = obj6 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				object obj10 = obj7 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				object obj11 = obj8 * 0;
				double num4 = num + (double)obj9;
				double num5 = num2 + (double)obj10;
				double num6 = num3 + (double)obj11;
				double num11;
				double num12;
				double num13;
				float num10;
				float num9;
				float num8;
				if (part == (ApePart)1)
				{
					Transform transform2 = base.transform;
					Vector3 right = transform2.right;
					float num7 = flingSpeed;
					num8 = (float)obj9 * flingSpeed;
					num9 = (float)obj10 * flingSpeed;
					num10 = (float)obj11 * flingSpeed;
					num11 = num4 - (double)num8;
					num12 = num5 - (double)num9;
					num13 = num6 - (double)num10;
					ApePart apePart = (ApePart)0;
				}
				else
				{
					Transform transform3 = base.transform;
					if (part == (ApePart)2)
					{
						Vector3 right2 = transform3.right;
						float num7 = flingSpeed;
						num8 = (float)obj9 * flingSpeed;
						num9 = (float)obj10 * flingSpeed;
						num10 = (float)obj11 * flingSpeed;
						ApePart apePart = (ApePart)0;
					}
					else
					{
						Vector3 up2 = transform3.up;
						Transform transform4 = base.transform;
						float num14 = (float)obj11 * flingSpeed;
						float num15 = (float)obj10 * flingSpeed;
						float num16 = (float)obj9 * flingSpeed;
						Vector3 forward = transform4.forward;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
						float num7 = 0f;
						float num17 = (float)obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
						float num18 = num17 * 0f;
						float num19 = (float)obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
						float num20 = num19 * 0f;
						float num21 = (float)obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
						float num22 = num21 * 0f;
						num8 = num16 + num18;
						num9 = num15 + num20;
						num10 = num14 + num22;
						ApePart apePart = (ApePart)0;
					}
					num11 = num4 + (double)num8;
					num12 = num5 + (double)num9;
					num13 = num6 + (double)num10;
				}
				Dismemberment[] array3 = copies;
				bool flag5 = array3.Length < 1;
				Vector3 vector = (Vector3)0;
				if (flag5)
				{
					goto IL_05f6;
				}
				object obj12 = array3.Length & 0xFFFFFFFFL;
				object obj13 = array3 + 32;
				object obj14 = 0;
				float num23 = num10;
				float num24 = num9;
				float num25 = num8;
				Vector3 vector2 = (Vector3)0;
				while (true)
				{
					bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
					object obj15 = !flag6;
					if (obj15 != null)
					{
						break;
					}
					object obj16 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v38+E4]");
					bool flag7 = (nint)0 == 0;
					object obj17 = !flag7;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X25_v6+v244 @ X24_v7*8]");
					bool flag8 = (UnityEngine.Object)0 != null;
					bool flag9 = !flag8;
					ApePart apePart = (ApePart)0;
					if (!flag9)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X25_v6+v244 @ X24_v7*8]");
						((Dismemberment)0).Tear(part, (Vector3)0);
						num23 = (float)num13;
						num24 = (float)num12;
						num25 = (float)num11;
						apePart = part;
					}
					obj12 = array3.Length;
					obj14++;
					bool flag10 = (nint)obj14 < array3.Length;
					num10 = num23;
					num9 = num24;
					num8 = num25;
					vector = (Vector3)0;
					vector2 = (Vector3)0;
					if (flag10)
					{
						continue;
					}
					goto IL_05f6;
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_064b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CE0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v15+E4]");
		bool flag11 = (nint)0 == 0;
		object obj20 = !flag11;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj21 = default;
		bool flag12 = obj21 != null;
		if (part == (ApePart)1 && flag12)
		{
			_ = 1;
		}
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X0_v27+E4]");
		bool flag13 = (nint)0 == 0;
		object obj23 = !flag13;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = obj21 != null;
		if (part == (ApePart)2 && flag14)
		{
			_ = 1;
		}
		return;
		IL_05f6:
		if (part != (ApePart)2)
		{
			Buzz((XRNode)4);
			if (part == (ApePart)1)
			{
				goto IL_064b;
			}
		}
		Buzz((XRNode)5);
		goto IL_064b;
	}

	public unsafe void Saw(ApePart part, GillaRip.Along along)
	{
		//IL_0053: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I4
		//IL_013c: Expected VT, but got I4
		//IL_02f5: Expected F4, but got I
		//IL_0161: Expected VT, but got I4
		//IL_04a7: Expected F4, but got I
		//IL_04b7: Expected Obj, but got I
		//IL_04cb: Expected Obj, but got I8
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected Obj, but got Unknown
		//IL_055c: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I
		//IL_01d8: Expected Obj, but got I4
		//IL_071b: Expected Obj, but got I4
		//IL_0735: Expected Obj, but got I4
		//IL_08ba: Expected Obj, but got I4
		//IL_0228: Expected VT, but got I4
		//IL_08e2: Expected Obj, but got I
		//IL_0916: Expected Obj, but got I4
		//IL_0593: Expected Obj, but got I4
		//IL_05c2: Expected Obj, but got I
		//IL_05de: Expected VT, but got I4
		//IL_094e: Expected Obj, but got I4
		//IL_06a4: Expected Obj, but got I4
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected Obj, but got Unknown
		//IL_0620: Expected Obj, but got I4
		//IL_065b: Expected VT, but got I4
		//IL_065b: Expected VT, but got Ref
		//IL_065b: Expected Obj, but got I
		//IL_066d: Expected I, but got Obj
		//IL_068d: Expected VT, but got Ref
		Dismemberment[] array = copies;
		if (copies == null || array.Length == 0)
		{
			return;
		}
		object obj;
		if (array.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = array[0] == null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 != null)
			{
				return;
			}
			Dismemberment[] array2 = copies;
			if (array2.Length != 0)
			{
				Dismemberment.Part part2 = array2[0].Find(part);
				bool flag4 = part2 == null;
				GillaRip.Along along2 = (GillaRip.Along)0;
				if (!flag4)
				{
					bool flag5 = (byte)(~(part2.torn ? 1u : 0u)) != 0;
					along2 = (GillaRip.Along)0;
					if (!flag5)
					{
						Dismemberment[] array3 = copies;
						if (array3.Length == 0)
						{
							goto IL_0854;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D48]");
						object obj5 = 0;
						object obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v55+E4]");
						bool flag6 = (nint)0 == 0;
						object obj7 = !flag6;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag7 = GillaSaw.Resawable(array3[0], part);
						bool flag8 = !flag7;
						along2 = (GillaRip.Along)0;
						if (flag8)
						{
							return;
						}
					}
				}
				Transform transform = base.transform;
				float num19;
				float num20;
				float num21;
				float num16;
				float num6 = default;
				float num4 = default;
				float num2 = default;
				if (part != 0)
				{
					Vector3 up = transform.up;
					Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
					Transform transform2 = base.transform;
					float num;
					float num3;
					float num5;
					if (part == (ApePart)1)
					{
						Vector3 right = transform2.right;
						num = 0f - num2;
						num3 = 0f - num4;
						num5 = 0f - num6;
						ApePart apePart = (ApePart)0;
					}
					else
					{
						Vector3 right2 = transform2.right;
						num5 = num6;
						num3 = num4;
						num = num2;
						ApePart apePart = (ApePart)0;
					}
					float num7 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					float num8 = num7 * 0f;
					float num9 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					float num10 = num9 * 0f;
					float num11 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
					float num12 = num11 * 0f;
					float num13 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
					float num14 = num13 * 0f;
					float num15 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					num16 = num15 * 0f;
					float num17 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
					float num18 = num17 * 0f;
					num2 = num * flingSpeed;
					num4 = num3 * flingSpeed;
					num6 = num5 * flingSpeed;
					num19 = num12 + num8;
					num20 = num14 + num10;
					num21 = num18 + num16;
				}
				else
				{
					Vector3 up2 = transform.up;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
					num16 = 0f;
					float num22 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
					num19 = num22 * 0f;
					float num23 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
					num20 = num23 * 0f;
					float num24 = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
					num21 = num24 * 0f;
					Vector3 insideUnitSphere2 = UnityEngine.Random.insideUnitSphere;
					ApePart apePart = (ApePart)0;
				}
				Dismemberment[] array4 = copies;
				if (array4.Length < 1)
				{
					goto IL_06f0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				num16 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D48]");
				object obj8 = 0;
				object obj9 = array4.Length & 0xFFFFFFFFL;
				object obj10 = array4 + 32;
				float num25 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				float num26 = num25 * 0f;
				float num27 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				float num28 = num27 * 0f;
				float num29 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				float num30 = num29 * 0f;
				float num31 = num21 + num26;
				float num32 = num20 + num28;
				float num33 = num19 + num30;
				IntPtr intPtr = default;
				nint num34 = intPtr;
				object obj11 = 0;
				GillaRip.Along along3 = along2;
				Vector3 n = default;
				while (true)
				{
					bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
					object obj12 = !flag9;
					if (obj12 != null)
					{
						break;
					}
					object obj13 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v34+E4]");
					bool flag10 = (nint)0 == 0;
					object obj14 = !flag10;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X27_v6+v348 @ X25_v7*8]");
					bool flag11 = (UnityEngine.Object)0 != null;
					bool flag12 = !flag11;
					along2 = (GillaRip.Along)0;
					ApePart apePart = (ApePart)0;
					if (!flag12)
					{
						object obj15 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X0_v39+E4]");
						bool flag13 = (nint)0 == 0;
						object obj16 = !flag13;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X27_v6+v348 @ X25_v7*8]");
						GillaSaw.CutPart((Dismemberment)0, part, (GillaRip.Along)(&n), (Vector3)0);
						n = along.n;
						num34 = unchecked((nint)null);
						num26 = num31;
						num28 = num32;
						num30 = num33;
						along2 = (GillaRip.Along)(&n);
						apePart = part;
					}
					obj9 = array4.Length;
					obj11++;
					bool flag14 = (nint)obj11 < array4.Length;
					num6 = num26;
					num4 = num28;
					num2 = num30;
					along3 = along2;
					if (flag14)
					{
						continue;
					}
					goto IL_06f0;
				}
			}
		}
		goto IL_0854;
		IL_0854:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_06f0:
		if (part != 0)
		{
			object obj17 = part - 1;
			bool flag15 = obj17 == null;
			object obj18 = !flag15;
			object obj19 = ~obj18;
			XRNode node = ((obj19 != null) ? ((XRNode)4) : ((XRNode)5));
			Buzz(node);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CE0]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v15+E4]");
			bool flag16 = (nint)0 == 0;
			object obj22 = !flag16;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj23 = default;
			bool flag17 = obj23 != null;
			if (part == (ApePart)1 && flag17)
			{
				_ = 1;
			}
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v26+E4]");
			bool flag18 = (nint)0 == 0;
			object obj25 = !flag18;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag19 = obj23 != null;
			if (part == (ApePart)2 && flag19)
			{
				_ = 1;
			}
		}
		else
		{
			Buzz((XRNode)4);
			Buzz((XRNode)5);
		}
	}

	public unsafe bool SawReady(ApePart part, GillaRip.Along along)
	{
		//IL_01bd: Expected Obj, but got I4
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected I4, but got Unknown
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I8
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0081: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
		//IL_025b: Expected Obj, but got I4
		//IL_01d0: Expected I4, but got Obj
		//IL_00b9: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I
		//IL_0104: Expected VT, but got I4
		//IL_0203: Expected Obj, but got I4
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_0146: Expected Obj, but got I4
		//IL_017c: Expected VT, but got Ref
		//IL_017c: Expected Obj, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_01a2: Expected VT, but got Ref
		Dismemberment[] array = copies;
		object obj5;
		if (copies != null && array.Length >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
			object obj2 = 0;
			object obj3 = array.Length & 0xFFFFFFFFL;
			object obj4 = copies + 32;
			GillaRip.Along along2 = along;
			ApePart apePart = part;
			obj5 = 1;
			object obj6 = 0;
			Vector3 n = default;
			do
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
				object obj7 = !flag;
				if (obj7 == null)
				{
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v6+E4]");
					bool flag2 = (nint)0 == 0;
					object obj9 = !flag2;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X27_v3+v183 @ X23_v4*8]");
					bool flag3 = (UnityEngine.Object)0 != null;
					bool flag4 = !flag3;
					along2 = (GillaRip.Along)0;
					apePart = (ApePart)0;
					if (!flag4)
					{
						object obj10 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v11+E4]");
						bool flag5 = (nint)0 == 0;
						object obj11 = !flag5;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X27_v3+v183 @ X23_v4*8]");
						bool flag6 = GillaWounds.SawPartReady((Dismemberment)0, part, (GillaRip.Along)(&n));
						obj5 = flag6 & obj5;
						n = along.n;
						along2 = (GillaRip.Along)(&n);
						apePart = part;
					}
					obj3 = array.Length;
					obj6++;
					continue;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				return (byte)(int)ex != 0;
			}
			while ((nint)obj6 < array.Length);
		}
		else
		{
			obj5 = 1;
		}
		return (byte)(obj5 & 1) != 0;
	}

	private void Buzz(XRNode node)
	{
		InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
		InputDevice inputDevice = default;
		if (inputDevice.isValid)
		{
			bool flag = inputDevice.SendHapticImpulse(0u, tearHaptic, tearHapticSeconds);
		}
	}

	public void ResetAll()
	{
		//IL_0015: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I
		//IL_017f: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got I8
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0067: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_012d: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I
		Dismemberment[] array = copies;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		if (array.Length >= 1)
		{
			object obj2 = array.Length & 0xFFFFFFFFL;
			object obj3 = array + 32;
			object obj5 = default;
			object obj4 = obj5;
			object obj6 = 0;
			bool flag3;
			do
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
				object obj7 = !flag;
				if (obj7 == null)
				{
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v14+E4]");
					bool flag2 = (nint)0 == 0;
					object obj9 = !flag2;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X24_v4+v76 @ X23_v5*8]");
					if ((UnityEngine.Object)0 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X24_v4+v76 @ X23_v5*8]");
						((Dismemberment)0).ResetAll();
					}
					obj2 = array.Length;
					obj6++;
					flag3 = (nint)obj6 < array.Length;
					obj4 = 0;
					continue;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
			while (flag3);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CE0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj13 = default;
		if (obj13 != null)
		{
			_ = 0;
		}
	}

	public DismemberGroup()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C320]");
		flingSpeed = 0f;
		tearHapticSeconds = 0.35f;
		base._002Ector();
	}
}
