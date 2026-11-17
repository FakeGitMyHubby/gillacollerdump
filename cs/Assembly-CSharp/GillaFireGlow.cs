using Cpp2ILInjected;
using UnityEngine;

public class GillaFireGlow : MonoBehaviour
{
	public Light lamp;

	public Renderer embers;

	public Color glow;

	public float seed = 1f;

	private MaterialPropertyBlock block;

	private float baseIntensity;

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_004f: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		MaterialPropertyBlock materialPropertyBlock = default;
		materialPropertyBlock._002Ector();
		object obj3 = this + 72;
		obj3 = materialPropertyBlock;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X21_v4-28]");
		bool flag2 = (Object)0 != null;
		bool flag3 = !flag2;
		float num = 1f;
		if (!flag3)
		{
			num = lamp.intensity;
		}
		baseIntensity = num;
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I
		//IL_01ca: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		float time = Time.time;
		float num = time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
		float y = num * 0f;
		float num2 = Mathf.PerlinNoise(seed, y);
		float num3 = seed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A830]");
		float x = num3 + 0f;
		float y2 = time * 6.5f;
		float num4 = Mathf.PerlinNoise(x, y2);
		object obj2 = obj;
		float num5 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		float num6 = num5 * 0f;
		float num7 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		float num8 = num7 * 0f;
		float num9 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB8C]");
		float num10 = num9 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num11 = num10 + num8;
		bool flag2 = lamp != null;
		bool flag3 = !flag2;
		Object obj4 = null;
		float num12 = num11;
		if (!flag3)
		{
			num12 = num11 * baseIntensity;
			lamp.intensity = num12;
			obj4 = null;
			num6 = num11;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (embers != null)
		{
			embers.GetPropertyBlock(block);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
			object obj7 = 0;
			block.SetColor((string)obj7, (Color)0);
			embers.SetPropertyBlock(block);
		}
	}

	public GillaFireGlow()
	{
		//IL_001d: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107CB80]");
		glow = (Color)0;
		base._002Ector();
	}
}
