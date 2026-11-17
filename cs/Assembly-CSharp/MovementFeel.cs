using Cpp2ILInjected;
using UnityEngine;

public class MovementFeel : MonoBehaviour
{
	public float gravity;

	public float launchMultiplier;

	public float maxLaunchSpeed;

	public float wallPushOut;

	private void Awake()
	{
		Apply();
	}

	private void OnValidate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Application.isPlaying)
		{
			Apply();
		}
	}

	private void Apply()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0130: Expected Obj, but got F4
		//IL_0140: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I4
		//IL_002e: Expected VT, but got I4
		//IL_005c: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = 0f - gravity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CE0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Physics.gravity = (Vector3)0;
		Physics.simulationMode = (SimulationMode)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B78]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		_ = launchMultiplier;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Object obj10 = default;
		if (obj10 != null)
		{
			((Rigidbody)obj10).interpolation = (RigidbodyInterpolation)0;
			((Rigidbody)obj10).maxDepenetrationVelocity = wallPushOut;
		}
	}

	public MovementFeel()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D130]");
		gravity = 0f;
		base._002Ector();
	}
}
