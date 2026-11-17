using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using UnityEngine;

public class GillaFlicker : MonoBehaviour
{
	public Light lamp;

	public Renderer tube;

	public int tubeSlot = 1;

	public Color glow;

	public float steadiness;

	public int seed;

	private System.Random rng;

	private MaterialPropertyBlock block;

	private float level;

	private float baseIntensity;

	private float nextChange;

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F90]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		System.Random random = default;
		random._002Ector(seed);
		object obj4 = this + 80;
		obj4 = random;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		MaterialPropertyBlock materialPropertyBlock = default;
		materialPropertyBlock._002Ector();
		object obj5 = this + 88;
		obj5 = materialPropertyBlock;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X21_v5-38]");
		bool flag2 = (UnityEngine.Object)0 != null;
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
		//IL_01ac: Expected Obj, but got I
		//IL_01d6: Expected Obj, but got I4
		//IL_0285: Expected Obj, but got I4
		//IL_001c: Expected I, but got Obj
		//IL_003b: Expected Obj, but got I
		//IL_0171: Expected F4, but got I
		//IL_0181: Expected F4, but got I
		//IL_0197: Expected F4, but got I4
		//IL_0305: Expected Obj, but got I
		//IL_0319: Expected VT, but got I4
		//IL_00f9: Expected I, but got Obj
		//IL_0118: Expected Obj, but got I
		//IL_0128: Expected F4, but got I
		//IL_014f: Expected F4, but got I
		float time = Time.time;
		float num = nextChange;
		if (!(time < nextChange))
		{
			System.Random random = rng;
			nint num2 = (nint)random;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v10 (Il2CppClass<System.Random>)+1C0]");
			nint num3 = 0;
			StreamingContext context = default;
			((System.Empty)(object)random).GetObjectData((SerializationInfo)0, context);
			float max;
			if (time < steadiness)
			{
				time = 1f;
				max = 3.5f;
				num = 0.5f;
			}
			else
			{
				double num4 = 1.0 - (double)steadiness;
				double num5 = num4 * 0.75;
				double num6 = (double)steadiness + num5;
				if ((double)time < num6)
				{
					System.Random random2 = rng;
					nint num7 = (nint)random2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v13 (Il2CppClass<System.Random>)+1C0]");
					num3 = 0;
					((System.Empty)(object)random2).GetObjectData((SerializationInfo)0, context);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
					max = 0f;
					float num8 = time;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
					time = num8 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
					num = 0f;
					double num9 = 0.75;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
					num = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
					max = 0f;
					double num9 = 0.75;
					time = 0f;
				}
			}
			Hold(time, num, max);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = lamp != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		if (!flag3)
		{
			num = baseIntensity;
			time = level * baseIntensity;
			lamp.intensity = time;
			obj4 = null;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (tube != null)
		{
			tube.GetPropertyBlock(block, tubeSlot);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
			object obj7 = 0;
			block.SetColor((string)obj7, (Color)0);
			tube.SetPropertyBlock(block, tubeSlot);
		}
	}

	private void Hold(float to, float min, float max)
	{
		//IL_0029: Expected Obj, but got I
		level = to;
		float time = Time.time;
		StreamingContext context = default;
		((System.Empty)(object)rng).GetObjectData((SerializationInfo)0, context);
		float num = max - min;
		float num2 = time + min;
		float num3 = num * time;
		float num4 = num2 + num3;
		nextChange = num4;
	}

	public GillaFlicker()
	{
		//IL_001d: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E1D0]");
		glow = (Color)0;
		steadiness = 0.8f;
		level = 1f;
		base._002Ector();
	}
}
