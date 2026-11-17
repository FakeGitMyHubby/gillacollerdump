using Cpp2ILInjected;
using UnityEngine;

public class GillaHover : MonoBehaviour
{
	public float height;

	public float period;

	public float spin;

	public float sway;

	public float swaySpeed = 2f;

	public Vector3 drift;

	private Vector3 rest;

	private Quaternion restTurn;

	private float turned;

	private void Awake()
	{
		Transform transform = base.transform;
		Vector3 localPosition = transform.localPosition;
		Vector3 vector = default;
		rest = vector;
		Transform transform2 = base.transform;
		Quaternion localRotation = transform2.localRotation;
		restTurn = (Quaternion)vector;
	}

	private void Update()
	{
		//IL_01d1: Expected Obj, but got I
		//IL_005e: Expected VT, but got I4
		//IL_0078: Invalid comparison between F4 and I4
		//IL_024a: Invalid comparison between F4 and I4
		//IL_0259: Expected F4, but got I4
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected Obj, but got Unknown
		//IL_009a: Invalid comparison between F4 and I4
		//IL_00ce: Invalid comparison between F4 and I4
		//IL_00f6: Expected F4, but got I4
		//IL_027f: Expected Obj, but got I
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_02ab: Expected Obj, but got I
		//IL_01bb: Expected VT, but got I4
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		float time = Time.time;
		float num = time + time;
		float num2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
		float num3 = num2 * 0f;
		float num4 = num3 / period;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		transform.localPosition = (Vector3)0;
		float num5 = spin;
		if (spin == 0f && sway == 0f)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v18+A0]");
			object obj3 = 0;
			object obj4 = drift - obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHover)+3C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v19+8]");
			object obj5 = num6 - 0;
			object obj6 = obj4 * obj4;
			object obj7 = obj5 * obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			object obj8 = obj7 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
			if ((nint)obj8 < 0)
			{
				return;
			}
			num5 = spin;
		}
		float deltaTime = Time.deltaTime;
		float num7 = num5 * deltaTime;
		float num8 = turned + num7;
		float num9 = num8 / 1.13587E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num10 = num9 * 1.13587E+09f;
		float num11 = num8 - num10;
		bool flag = num11 < 0f;
		float num12 = 0f;
		if (!flag)
		{
			bool flag2 = !(num11 > 1.13587E+09f);
			num12 = num11;
			if (!flag2)
			{
				num12 = 1.13587E+09f;
			}
		}
		turned = num12;
		float time2 = Time.time;
		float num13 = time2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9DC]");
		float num14 = num13 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		float num15 = (float)drift * num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B5C0]");
		object obj10 = default;
		object obj9 = 0 * obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCE0]");
		object obj11 = obj9 + 0;
		float num16 = num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
		float num17 = num16 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Vector3 euler = default;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
		Transform transform2 = base.transform;
		float num18 = time2 * swaySpeed;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(ref euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
		transform2.localRotation = (Quaternion)0;
	}

	public GillaHover()
	{
		//IL_001d: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B100]");
		height = 0f;
		base._002Ector();
	}
}
