using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class GillaEggMess : MonoBehaviour
{
	public float stays;

	public float shrinks;

	private float t;

	private Vector3 size;

	private void Start()
	{
		Transform transform = base.transform;
		Vector3 localScale = transform.localScale;
		Vector3 vector = default;
		size = vector;
	}

	public void Fling(Vector3 way, float speed)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0368: Expected VT, but got Obj
		//IL_0025: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I4
		//IL_009b: Expected F4, but got I
		//IL_03f3: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I4
		//IL_01a1: Invalid comparison between F4 and I
		//IL_0202: Expected Obj, but got I
		//IL_020a: Expected F4, but got Obj
		//IL_021a: Expected F4, but got I
		//IL_022a: Expected F4, but got I
		//IL_03b1: Expected F4, but got I
		//IL_03b1: Expected F4, but got I
		//IL_029f: Expected VT, but got I4
		//IL_029f: Expected Obj, but got I
		//IL_02ff: Expected VT, but got I4
		//IL_02ff: Expected Obj, but got I
		//IL_030f: Expected Obj, but got I
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_033c: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C74D8]");
		object obj = 0;
		Vector3 vector = (Vector3)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
		object obj2 = default;
		if (obj2 == null)
		{
			goto IL_034b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj5 = 0;
		float num2 = default;
		float num = num2;
		float num4 = default;
		float num3 = num4;
		float num6 = default;
		float num5 = num6;
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		float num7 = 0f;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
			object obj7 = !flag;
			if (obj7 != null)
			{
				break;
			}
			object obj8 = obj2 + obj6;
			Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
			object obj9 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num8 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			float num9 = num8 * 0f;
			float num10 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			float num11 = num10 * 0f;
			float num12 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			float num13 = num12 * 0f;
			float num14 = speed + num9;
			float num15 = num4 + num11;
			float num16 = num2 + num13;
			float num17 = num14 * num14;
			float num18 = num15 * num15;
			float num19 = num17 + num18;
			float num20 = num16 * num16;
			float num21 = num20 + num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			float num22;
			float num23;
			float num24;
			if (num21 > 0f)
			{
				num22 = num14 / num21;
				num23 = num15 / num21;
				num24 = num16 / num21;
			}
			else
			{
				object obj11 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v14+A0]");
				object obj12 = 0;
				num22 = (float)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v15+4]");
				num23 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v15+8]");
				num24 = 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
			nint num25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
			float num26 = UnityEngine.Random.Range(num25, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v8+20]");
			if ((nint)0 != 0)
			{
				float num27 = num24 * num6;
				num5 = num23 * num6;
				float num28 = num22 * num6;
				float num29 = num27 * num26;
				float num30 = num5 * num26;
				float num31 = num28 * num26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v8+20]");
				((Rigidbody)0).linearVelocity = (Vector3)0;
				Vector3 insideUnitSphere2 = UnityEngine.Random.insideUnitSphere;
				num7 = num31 * 18f;
				num3 = num30 * 18f;
				num = num29 * 18f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v8+20]");
				((Rigidbody)0).angularVelocity = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
				obj3 = 0;
				obj6++;
				object obj13 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+18]");
				bool flag3 = (nint)obj13 < 0;
				vector = (Vector3)0;
				if (!flag3)
				{
					return;
				}
				continue;
			}
			goto IL_034b;
		}
		goto IL_0359;
		IL_0359:
		throw new IndexOutOfRangeException();
		IL_034b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0359;
	}

	private void Update()
	{
		//IL_004f: Invalid comparison between F8 and I4
		//IL_0060: Expected Obj, but got I4
		//IL_0069: Invalid comparison between F8 and I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I4
		//IL_00b0: Expected VT, but got I4
		float deltaTime = Time.deltaTime;
		float num = (t += deltaTime);
		if (num < stays)
		{
			return;
		}
		float num2 = num - stays;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		float num3 = num2 / shrinks;
		double num4 = 1.0 - (double)num3;
		bool flag = num4 < 0.0;
		object obj = !flag;
		bool flag2 = num4 == 0.0;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		if (obj3 == null)
		{
			Transform transform = base.transform;
			transform.localScale = (Vector3)0;
			return;
		}
		GameObject obj4 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.Destroy(obj4);
	}

	public GillaEggMess()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BFC0]");
		stays = 0f;
		base._002Ector();
	}
}
