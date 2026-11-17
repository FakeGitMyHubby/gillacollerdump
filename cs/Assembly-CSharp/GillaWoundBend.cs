using Cpp2ILInjected;
using UnityEngine;

public class GillaWoundBend : MonoBehaviour
{
	private static readonly int OtherBone;

	public Transform other;

	public Matrix4x4 bind;

	private Renderer shown;

	private MaterialPropertyBlock block;

	private void LateUpdate()
	{
		Bend();
	}

	public unsafe void Bend()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_02a0: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_012f: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I4
		//IL_02d8: Expected Obj, but got I4
		//IL_02fe: Expected Obj, but got I
		//IL_0320: Expected Obj, but got I4
		//IL_016c: Expected Obj, but got I
		//IL_0253: Expected VT, but got Ref
		//IL_0253: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (Object)obj3 == null;
		bool flag3 = !flag2;
		Object obj5 = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4410]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			Object obj7 = default;
			shown = (Renderer)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj5 = obj7;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = (Object)obj3 == null;
		bool flag6 = !flag5;
		object obj10 = !flag6;
		if (obj10 == null)
		{
			object obj11 = this + 112;
			MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA750]");
			object obj12 = 0;
			bool flag7 = obj11 == null;
			object obj13 = !flag7;
			Object obj14 = null;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				MaterialPropertyBlock materialPropertyBlock2 = default;
				materialPropertyBlock2._002Ector();
				obj11 = materialPropertyBlock2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				materialPropertyBlock = (MaterialPropertyBlock)obj11;
				obj14 = (Object)(object)materialPropertyBlock2;
			}
			object obj16 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v14+E4]");
			bool flag8 = (nint)0 == 0;
			object obj17 = !flag8;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj12;
			}
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v14+A0]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v9+E4]");
			bool flag9 = (nint)0 == 0;
			object obj20 = !flag9;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (other != null)
			{
				Matrix4x4 localToWorldMatrix = other.localToWorldMatrix;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DF8E5C");
			}
			else
			{
				Transform transform = base.transform;
				Matrix4x4 localToWorldMatrix2 = transform.localToWorldMatrix;
			}
			object obj21 = default;
			materialPropertyBlock.SetMatrix((int)obj19, (Matrix4x4)(&obj21));
			((Renderer)obj3).SetPropertyBlock((MaterialPropertyBlock)obj11);
		}
	}

	static GillaWoundBend()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA758]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA750]");
		object obj2 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = num;
	}
}
