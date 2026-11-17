using Cpp2ILInjected;
using UnityEngine;

public class ShopScroll : MonoBehaviour
{
	public float speed = 0.18f;

	public float sideways;

	private static readonly int BaseMapST;

	private Renderer r;

	private MaterialPropertyBlock block;

	private Vector4 st;

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I4
		//IL_0202: Expected Obj, but got I4
		//IL_0249: Expected Obj, but got I
		//IL_0253: Expected VT, but got F8
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_00b4: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got I
		//IL_0120: Expected I4, but got Obj
		//IL_0149: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I4
		//IL_02a7: Expected Obj, but got I
		//IL_02b4: Expected I4, but got Obj
		//IL_02ce: Expected Obj, but got I4
		//IL_02e7: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4410]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj2 = this + 40;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		Material sharedMaterial = ((Renderer)obj2).sharedMaterial;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num;
		if (sharedMaterial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9E8]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v9+A0]");
			object obj11 = 0;
			bool flag3 = sharedMaterial.HasProperty((int)obj11);
			bool flag4 = !flag3;
			num = 1.0;
			object obj12 = 0;
			double num2 = 1.0;
			object obj13 = 0;
			object obj14 = 0;
			Object obj15 = (Object)obj11;
			if (!flag4)
			{
				object obj16 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v23+E4]");
				bool flag5 = (nint)0 == 0;
				object obj17 = !flag5;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj16 = obj7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v23+A0]");
				object obj18 = 0;
				Vector4 vector = sharedMaterial.GetVector((int)obj18);
				num = 1.0;
				obj12 = 0;
				double num3 = default;
				num2 = num3;
				object obj19 = default;
				obj13 = obj19;
				obj14 = 0;
				obj15 = (Object)obj18;
			}
		}
		else
		{
			num = 1.0;
			object obj12 = 0;
			double num2 = 1.0;
			object obj13 = 0;
			object obj14 = 0;
			Object obj15 = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
		object obj20 = 0;
		st = (Vector4)num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		MaterialPropertyBlock materialPropertyBlock = default;
		materialPropertyBlock._002Ector();
		object obj21 = this + 48;
		obj21 = materialPropertyBlock;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void Update()
	{
		//IL_0199: Invalid comparison between F4 and I4
		//IL_01a8: Expected F8, but got I4
		//IL_020e: Invalid comparison between F4 and I4
		//IL_0225: Expected F8, but got I4
		//IL_00ab: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I
		//IL_012f: Expected VT, but got I4
		//IL_012f: Expected I4, but got Obj
		float deltaTime = Time.deltaTime;
		float num = speed * deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ShopScroll)+44]");
		float num2 = 0f - num;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		object obj = default;
		float num3 = num2 - (float)obj;
		bool flag = num3 < 0f;
		double num4 = 0.0;
		if (!flag)
		{
			bool flag2 = !((double)num3 > 1.0);
			num4 = num3;
			if (!flag2)
			{
				num4 = 1.0;
			}
		}
		float deltaTime2 = Time.deltaTime;
		float num5 = sideways * deltaTime2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ShopScroll)+40]");
		float num6 = 0f + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num7 = num6 - num3;
		bool flag3 = num7 < 0f;
		double num8 = num3;
		double num9 = 0.0;
		if (!flag3)
		{
			bool flag4 = !((double)num7 > 1.0);
			num8 = 1.0;
			num9 = num7;
			if (!flag4)
			{
				num8 = 1.0;
				num9 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9E8]");
		object obj2 = 0;
		r.GetPropertyBlock(block);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj4 = !flag5;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v5+A0]");
		object obj6 = 0;
		block.SetVector((int)obj6, (Vector4)0);
		r.SetPropertyBlock(block);
	}

	static ShopScroll()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4300]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF9E8]");
		object obj2 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = num;
	}
}
