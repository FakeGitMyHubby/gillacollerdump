using Cpp2ILInjected;
using UnityEngine;

public class AmbientLoop : MonoBehaviour
{
	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4308]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		AudioSource audioSource = default;
		AudioClip clip = audioSource.clip;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(clip == null))
		{
			audioSource.loop = true;
			AudioClip clip2 = audioSource.clip;
			float length = clip2.length;
			float time = Random.Range(0f, length);
			audioSource.time = time;
			audioSource.Play();
		}
	}
}
