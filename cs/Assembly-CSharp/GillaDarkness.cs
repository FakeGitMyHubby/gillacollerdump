using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class GillaDarkness : MonoBehaviour
{
	private static float Amount__BackingField;

	public float Level;

	public bool Lamp;

	public Shader shader;

	public AudioClip sound;

	private const float FlickerSeconds = default(float);

	private const float LightComesOnAt = default(float);

	private const float BackSeconds = default(float);

	private const float Dim = default(float);

	private static readonly int DarkId;

	private static readonly int BeamId;

	private Renderer shell;

	private Material mat;

	private bool on;

	private bool wasLit;

	private bool lampDone;

	private float since;

	private float beam;

	private float target;

	private float from;

	public static float Amount
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0079: Expected F4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50A8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			return (float)obj4;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_007c: Expected Obj, but got F4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50A8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = 0;
			obj4 = value;
		}
	}

	private void OnDisable()
	{
		//IL_011a: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I4
		Level = 0f;
		Lamp = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50A8]");
		object obj = 0;
		target = 0f;
		from = 0f;
		if (~(on ? 1u : 0u) == 0)
		{
			bool flag = (byte)(~(wasLit ? 1u : 0u)) != 0;
			object obj2 = !flag;
			if (obj2 == null)
			{
				GillaHeadlamp.Set(on: false);
			}
		}
		object obj3 = obj;
		on = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v7+A0]");
		object obj9 = 0;
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (shell != null)
		{
			shell.enabled = false;
		}
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = shell != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		if (!flag3)
		{
			GameObject obj5 = shell.gameObject;
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(obj5);
			obj4 = null;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (mat != null)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(mat);
		}
	}

	private void Update()
	{
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected Obj, but got Unknown
		//IL_06d0: Expected Obj, but got I
		//IL_06fa: Invalid comparison between F4 and I4
		//IL_0709: Invalid comparison between F4 and I4
		//IL_071c: Expected Obj, but got F4
		//IL_0729: Expected Obj, but got F4
		//IL_0755: Expected Obj, but got I
		//IL_076e: Expected Obj, but got I4
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Expected Obj, but got Unknown
		//IL_07c9: Invalid comparison between F4 and I4
		//IL_07d8: Invalid comparison between F4 and I4
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected Obj, but got Unknown
		//IL_0800: Expected Obj, but got F4
		//IL_0835: Expected Obj, but got I4
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected Obj, but got Unknown
		//IL_0034: Expected F4, but got I
		//IL_0c42: Expected Obj, but got I
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected Obj, but got Unknown
		//IL_08cf: Expected Obj, but got F4
		//IL_0920: Unknown result type (might be due to invalid IL or missing references)
		//IL_0925: Expected Obj, but got Unknown
		//IL_02e7: Expected Obj, but got I
		//IL_0311: Expected Obj, but got I4
		//IL_04ca: Expected F4, but got Obj
		//IL_04da: Expected F8, but got I
		//IL_038a: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I4
		//IL_05d3: Expected F4, but got I
		//IL_042b: Expected Obj, but got I
		//IL_0455: Expected Obj, but got I4
		//IL_0679: Expected I, but got Obj
		//IL_089f: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_00e0: Expected I, but got Obj
		//IL_0a58: Expected Obj, but got I
		//IL_0a60: Expected F4, but got Obj
		//IL_0a8a: Expected Obj, but got I4
		//IL_0533: Expected F4, but got I
		//IL_03a8: Invalid comparison between F4 and I
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_0416: Expected Obj, but got F4
		//IL_090b: Expected Obj, but got I
		//IL_0915: Expected I4, but got Obj
		//IL_0c72: Expected Obj, but got I
		//IL_0c93: Expected F4, but got Obj
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected Obj, but got Unknown
		//IL_059d: Expected F4, but got I
		//IL_0976: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I4
		//IL_0ca0: Expected F4, but got Obj
		//IL_0cb0: Expected Obj, but got I
		//IL_0cdf: Invalid comparison between F4 and I4
		//IL_0cf2: Expected Obj, but got F4
		//IL_0cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cff: Expected Obj, but got Unknown
		//IL_0d30: Expected Obj, but got I4
		//IL_03d6: Expected I, but got Obj
		//IL_0164: Expected Obj, but got I4
		//IL_0169: Expected I, but got Obj
		//IL_0a3a: Expected Obj, but got I4
		//IL_0d57: Expected Obj, but got I
		//IL_0d5f: Expected Obj, but got F4
		//IL_09b6: Expected Obj, but got I4
		//IL_09ce: Invalid comparison between F4 and I4
		//IL_09df: Expected Obj, but got I4
		//IL_0187: Expected Obj, but got I
		//IL_0abd: Expected Obj, but got I
		//IL_0616: Expected Obj, but got I
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_0b28: Invalid comparison between F8 and I4
		//IL_0b3b: Expected Obj, but got F8
		//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Expected Obj, but got Unknown
		//IL_0b70: Expected Obj, but got I4
		//IL_062c: Expected F8, but got I4
		//IL_0bbb: Expected Obj, but got I4
		//IL_0bd3: Invalid comparison between F4 and I4
		//IL_0be4: Expected Obj, but got I4
		//IL_0242: Expected Obj, but got I
		//IL_026c: Expected Obj, but got I4
		//IL_0299: Expected F4, but got I
		//IL_02b7: Expected VT, but got I4
		//IL_02cd: Expected Obj, but got I4
		//IL_02d2: Expected I, but got Obj
		float deltaTime = Time.deltaTime;
		object obj = this + 84;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		object obj3 = obj2;
		float num2 = default;
		float num = deltaTime - num2;
		bool flag = num < 0f;
		bool flag2 = num == 0f;
		object obj4 = deltaTime ^ num2;
		object obj5 = deltaTime ^ num;
		object obj6 = obj4 & obj5;
		bool flag3 = (nint)obj6 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+A0]");
		object obj7 = 0;
		bool flag4 = flag == flag3;
		object obj8 = !flag2;
		object obj9 = flag4 & obj8;
		object obj10 = ~obj9;
		float num3 = ((obj10 != null) ? num2 : deltaTime);
		float num4 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		float num5 = num4 * 0f;
		float num6 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v8+4]");
		float num7 = num6 - 0f;
		bool flag5 = num7 < 0f;
		bool flag6 = num7 == 0f;
		float num8 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v8+4]");
		object obj11 = num8 ^ 0;
		object obj12 = num5 ^ num7;
		object obj13 = obj11 & obj12;
		bool flag7 = (nint)obj13 < 0;
		bool flag8 = flag5 == flag7;
		object obj14 = !flag6;
		object obj15 = flag8 & obj14;
		object obj16 = ~obj15;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v8+4]");
			num5 = 0f;
		}
		float num9 = default;
		if (!(num9 < num5))
		{
			if (Level > target)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj17 = 0;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v61+E4]");
				bool flag9 = (nint)0 == 0;
				object obj19 = !flag9;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag10 = sound != null;
				bool flag11 = !flag10;
				object obj20 = 0;
				nint num10 = unchecked((nint)null);
				if (!flag11)
				{
					Camera main = Camera.main;
					object obj21 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v63+E4]");
					bool flag12 = (nint)0 == 0;
					object obj22 = !flag12;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag13 = main != null;
					bool flag14 = !flag13;
					obj20 = 0;
					num10 = unchecked((nint)null);
					if (!flag14)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						AudioClip[] array = default;
						if (array != null)
						{
							object obj24 = array + 32;
							obj24 = sound;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Camera main2 = Camera.main;
							if ((object)main2 != null)
							{
								Transform transform = main2.transform;
								if ((object)transform != null)
								{
									Vector3 position = transform.position;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
									object obj25 = 0;
									object obj26 = obj25;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X0_v83+E4]");
									bool flag15 = (nint)0 == 0;
									object obj27 = !flag15;
									if (obj27 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
									float num11 = 0f;
									Sfx.Play(array, (Vector3)0, Level, target, num9);
									double num12 = 1.0;
									obj20 = 0;
									num10 = unchecked((nint)null);
									goto IL_02d7;
								}
							}
						}
						NullReferenceException ex = new NullReferenceException();
						throw new IndexOutOfRangeException();
					}
				}
			}
			goto IL_02d7;
		}
		goto IL_0c28;
		IL_02d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50A8]");
		object obj28 = 0;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v50+E4]");
		bool flag16 = (nint)0 == 0;
		object obj30 = !flag16;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj31 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v54+E4]");
		bool flag17 = (nint)0 == 0;
		object obj32 = !flag17;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj28;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v54+A0]");
		object obj33 = 0;
		since = 0f;
		target = Level;
		from = (float)obj33;
		goto IL_0c28;
		IL_0a18:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v7+E4]");
		bool flag18 = (nint)0 == 0;
		object obj34 = !flag18;
		object obj36;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50A8]");
			object obj35 = 0;
			obj36 = obj35;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v7+A0]");
		object obj37 = 0;
		float num13;
		obj37 = num13;
		object obj39;
		object obj38 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v17+A0]");
		object obj40 = 0;
		float num14 = deltaTime * 12f;
		float num15 = deltaTime * 12f;
		float num16 = 0f - num15;
		double num17 = ((obj40 != null) ? 1.0 : 0.0);
		double num18 = num17 - (double)beam;
		bool flag19 = num18 < 0.0;
		object obj41 = num18 ^ num18;
		object obj42 = num18 & obj41;
		bool flag20 = (nint)obj42 < 0;
		bool flag21 = flag19 == flag20;
		object obj43 = !flag21;
		object obj44 = ~obj43;
		float num19 = ((obj44 != null) ? num14 : num16);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num20 = beam + num19;
		bool flag22 = num16 < num14;
		object obj45 = !flag22;
		float num21 = num16 - num14;
		bool flag23 = num21 == 0f;
		object obj46 = !flag23;
		object obj47 = obj45 & obj46;
		object obj48 = ~obj47;
		if (obj48 == null)
		{
			num17 = num20;
		}
		beam = (float)num17;
		Show();
		return;
		IL_0c28:
		bool flag24 = Lamp;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61C8]");
		obj39 = 0;
		object obj49;
		if (Lamp != on)
		{
			on = Lamp;
			if (~(Lamp ? 1u : 0u) != 0)
			{
				if (~(wasLit ? 1u : 0u) == 0)
				{
					obj49 = this + 76;
					float num22 = deltaTime + (float)obj49;
					obj49 = num22;
					goto IL_091a;
				}
				GillaHeadlamp.Set(on: false);
				nint num10 = unchecked((nint)null);
			}
			else
			{
				object obj50 = obj39;
				lampDone = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v51+A0]");
				object obj51 = 0;
				wasLit = (byte)(int)obj51 != 0;
			}
			flag24 = on;
		}
		obj49 = this + 76;
		float num23 = deltaTime + (float)obj49;
		obj49 = num23;
		if (flag24)
		{
			bool flag25 = (byte)(~(lampDone ? 1u : 0u)) != 0;
			object obj52 = !flag25;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC38]");
				if (!(num23 < 0f))
				{
					lampDone = true;
					GillaHeadlamp.Set(on: true);
					nint num10 = unchecked((nint)null);
				}
			}
		}
		goto IL_091a;
		IL_0a48:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50A8]");
		object obj53 = 0;
		object obj54;
		num13 = (float)obj54;
		object obj55 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v16+E4]");
		bool flag26 = (nint)0 == 0;
		object obj56 = !flag26;
		if (obj56 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		obj36 = obj53;
		goto IL_0a18;
		IL_091a:
		obj54 = this + 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X24_v5-4]");
		float num24;
		double num31;
		float num26;
		if (0 < (nint)obj54)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50A8]");
			object obj57 = 0;
			object obj58 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v27+E4]");
			bool flag27 = (nint)0 == 0;
			object obj59 = !flag27;
			if (obj59 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			obj36 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v7+E4]");
			bool flag28 = (nint)0 == 0;
			object obj60 = !flag28;
			if (obj60 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj36 = obj57;
			}
			num24 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v7+A0]");
			object obj61 = 0;
			float num25 = deltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			num26 = num25 / 0f;
			float num27 = (float)obj - (float)obj61;
			bool flag29 = num27 < 0f;
			object obj62 = num27 ^ num27;
			object obj63 = num27 & obj62;
			bool flag30 = (nint)obj63 < 0;
			float num28 = 0f - num26;
			bool flag31 = flag29 == flag30;
			object obj64 = !flag31;
			object obj65 = ~obj64;
			float num11 = ((obj65 != null) ? num26 : num28);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			float num29 = (float)obj61 + num11;
			bool flag32 = num28 < num26;
			object obj66 = !flag32;
			float num30 = num28 - num26;
			bool flag33 = num30 == 0f;
			object obj67 = !flag33;
			object obj68 = obj66 & obj67;
			object obj69 = ~obj68;
			num13 = ((obj69 != null) ? num24 : num29);
			double num12 = num28;
			num31 = num29;
			goto IL_0a18;
		}
		float num32 = (float)obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		double num33 = 0.0;
		object obj70 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		if ((nint)obj70 < 0)
		{
			float time = Time.time;
			float x = time * 17f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE8]");
			num32 = Mathf.PerlinNoise(x, 0f);
			object obj71 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE78]");
			object obj72 = obj71 / 0;
			double num34 = (double)obj72 * 0.5;
			double num35 = num34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD5C]");
			num33 = num35 + 0.0;
			bool flag34 = !((double)num32 > num33);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD5C]");
			num24 = 0f;
			num31 = num33;
			num26 = num32;
			if (flag34)
			{
				goto IL_0a48;
			}
		}
		obj54 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD5C]");
		num24 = 0f;
		num31 = num33;
		num26 = num32;
		goto IL_0a48;
	}

	private void Show()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I4
		//IL_02d6: Expected Obj, but got I
		//IL_02f8: Expected Obj, but got I4
		//IL_0361: Expected Obj, but got I
		//IL_038a: Expected Obj, but got I4
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_022a: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I4
		//IL_0316: Expected Obj, but got I
		//IL_03f4: Expected Obj, but got I4
		//IL_032b: Expected Obj, but got I
		//IL_0343: Expected F8, but got I4
		//IL_01ea: Expected Obj, but got I
		//IL_0156: Invalid comparison between Obj and F8
		//IL_0167: Expected F8, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v6+A0]");
		object obj7 = 0;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		bool flag3 = (nint)obj7 < 0;
		object obj9 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		object obj10 = obj7 - 0;
		bool flag4 = obj10 == null;
		object obj11 = ~obj9;
		object obj12 = obj11 | flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v7+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (shell == null && !Build())
			{
				return;
			}
			shell.enabled = true;
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v24+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v24+A0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v24+E4]");
			bool flag7 = (nint)0 == 0;
			object obj17 = !flag7;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v24+A0]");
			object obj18 = 0;
			bool flag8 = (nint)obj18 < 0;
			double num = 0.0;
			if (!flag8)
			{
				bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1.0);
				num = (double)obj18;
				if (!flag9)
				{
					num = 1.0;
				}
			}
			double num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9E4]");
			double num3 = num2 * 0.0;
			float value = (float)num3 + 1f;
			Material material = mat;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v11+4]");
			material.SetFloat(0, value);
			object obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v16+A0]");
			object obj20 = 0;
			Material material2 = mat;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v17+8]");
			material2.SetFloat(0, beam);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v7+E4]");
			bool flag10 = (nint)0 == 0;
			object obj21 = !flag10;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (shell != null)
			{
				shell.enabled = false;
			}
		}
	}

	private bool Build()
	{
		//IL_0010: Expected Obj, but got I
		//IL_042b: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_03f8: Expected I4, but got Obj
		//IL_0117: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I4
		//IL_0225: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0279: Expected Obj, but got I
		//IL_0287: Expected VT, but got I4
		//IL_02e5: Expected Obj, but got I
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_0330: Expected Obj, but got I
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = main == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(shader == null))
			{
				GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)0);
				if ((object)gameObject != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8330]");
					object obj7 = 0;
					gameObject.name = (string)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7560]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
					object obj9 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v12+E4]");
					bool flag5 = (nint)0 == 0;
					object obj10 = !flag5;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object obj11 = default;
					UnityEngine.Object.Destroy(obj11);
					Transform transform = gameObject.transform;
					if ((object)main != null)
					{
						Transform parent = main.transform;
						if ((object)transform != null)
						{
							transform.SetParent(parent, worldPositionStays: false);
							Transform transform2 = gameObject.transform;
							if ((object)transform2 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
								object obj12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								object obj13 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v17+A0]");
								object obj14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v18+C]");
								object obj16 = default;
								object obj15 = 0 * obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v18+14]");
								nint num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
								object obj17 = num * 0;
								transform2.localScale = (Vector3)0;
								GameObject gameObject2 = main.gameObject;
								if ((object)gameObject2 != null)
								{
									int layer = gameObject2.layer;
									gameObject.layer = layer;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56C8]");
									object obj18 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									Material material = default;
									material._002Ector(shader);
									object obj19 = this + 64;
									obj19 = material;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B18]");
									object obj20 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
									object obj21 = this + 56;
									object obj22 = default;
									obj21 = obj22;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									if (obj21 != null)
									{
										((Renderer)obj21).sharedMaterial = (Material)obj19;
										if (obj21 != null)
										{
											((Renderer)obj21).shadowCastingMode = (ShadowCastingMode)0;
											if (obj21 != null)
											{
												((Renderer)obj21).receiveShadows = false;
												return true;
											}
										}
									}
								}
							}
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}
		return false;
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+A0]");
		object obj6 = 0;
		obj6 = 0;
	}

	static GillaDarkness()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0490]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0498]");
		object obj3 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+A0]");
		object obj5 = 0;
		int num2 = Shader.PropertyToID((string)obj3);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v5+A0]");
		object obj7 = 0;
	}
}
