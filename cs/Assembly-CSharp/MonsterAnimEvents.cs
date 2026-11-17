using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.XR;

public class MonsterAnimEvents : MonoBehaviour
{
	public MonsterBrain brain;

	public AudioClip[] footsteps;

	public float footstepVolume;

	public float footstepPitch;

	public float stepPitchLow;

	public float stepPitchHigh;

	public float footstepRange = 45f;

	public AudioClip[] grabSounds;

	public AudioClip[] jumpscareSounds;

	public float jumpscareVolume = 1f;

	public bool screamOnCue;

	public AudioClip[] biteSounds;

	public AudioClip[] stabSounds;

	public AudioClip[] landSounds;

	public AudioClip[] clawSounds;

	public AudioClip[] bangSounds;

	public AudioClip[] tearSounds;

	[NonSerialized]
	public bool stepsByHand;

	private float lastStep;

	private float lastStepPitch;

	private static AnimationCurve farFall;

	private static AnimationCurve farWet;

	private static AudioListener ears;

	internal const int Walls = default(int);

	public const float ScreamVolume = default(float);

	private bool KillingYou
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_01f2: Expected Obj, but got I4
			//IL_0061: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			//IL_00a3: Expected Obj, but got I4
			//IL_0103: Expected Obj, but got I
			//IL_01c8: Expected I4, but got Obj
			//IL_0177: Expected Obj, but got I4
			//IL_01ab: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (brain != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
				object obj4 = 0;
				object obj5 = obj;
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+A0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)obj7 != null)
				{
					object obj9 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v7+A0]");
					object obj10 = 0;
					object obj11 = obj10;
					if (obj10 == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v9+A9]");
					if ((nint)0 != 0)
					{
						object obj12 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v13+E4]");
						bool flag3 = (nint)0 == 0;
						object obj13 = !flag3;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v9+C0]");
						return (UnityEngine.Object)0 == brain;
					}
				}
			}
			return false;
		}
	}

	public void Footstep(AnimationEvent e)
	{
		//IL_027d: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I4
		//IL_0198: Expected VT, but got I4
		//IL_0051: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I4
		//IL_00ba: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I4
		//IL_00e3: Invalid comparison between I4 and F8
		//IL_00ee: Expected I, but got Obj
		//IL_0228: Expected VT, but got I4
		//IL_0261: Expected VT, but got I4
		bool flag = (byte)(~(stepsByHand ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		if (e != null)
		{
			AnimatorClipInfo animatorClipInfo = e.animatorClipInfo;
			AnimatorClipInfo animatorClipInfo2 = default;
			AnimationClip clip = animatorClipInfo2.clip;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = clip != null;
			bool flag4 = !flag3;
			nint num = unchecked((nint)null);
			if (!flag4)
			{
				AnimatorClipInfo animatorClipInfo3 = e.animatorClipInfo;
				bool flag5 = 0.0 < 0.5;
				num = unchecked((nint)null);
				if (flag5)
				{
					return;
				}
			}
		}
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v9+E4]");
		bool flag6 = (nint)0 == 0;
		object obj7 = !flag6;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = brain != null;
		bool flag8 = !flag7;
		Vector3 at = (Vector3)0;
		if (!flag8)
		{
			MonsterBrain monsterBrain = brain;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v15+E4]");
			bool flag9 = (nint)0 == 0;
			object obj9 = !flag9;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag10 = monsterBrain.Hurt__BackingField != null;
			bool flag11 = !flag10;
			at = (Vector3)0;
			if (!flag11)
			{
				MonsterBrain monsterBrain2 = brain;
				float num2 = monsterBrain2.Hurt__BackingField.StepLoud();
				at = (Vector3)0;
			}
		}
		Step(at, 0.5f);
	}

	public void Stomp(Vector3 at, float hard)
	{
		//IL_0032: Invalid comparison between Obj and F8
		object obj = default;
		if ((nint)obj < 0 || System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1.0))
		{
		}
		Step(at, hard);
	}

	private void Step(Vector3 at, float volume)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0de4: Expected Obj, but got I
		//IL_0e06: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_027d: Expected Obj, but got I
		//IL_029f: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I
		//IL_02ce: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I
		//IL_0427: Invalid comparison between F4 and I
		//IL_0307: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I
		//IL_04a5: Expected Obj, but got I4
		//IL_033d: Expected Obj, but got I
		//IL_0227: Expected VT, but got I4
		//IL_024a: Expected Obj, but got I4
		//IL_037b: Expected Obj, but got I
		//IL_03a5: Expected Obj, but got I4
		//IL_069a: Expected Obj, but got I4
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got Unknown
		//IL_03d1: Expected VT, but got I4
		//IL_03d1: Expected VT, but got I4
		//IL_03ef: Expected Obj, but got I4
		//IL_06df: Expected Obj, but got I4
		//IL_0544: Expected Obj, but got I4
		//IL_055e: Invalid comparison between F4 and I4
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected Obj, but got Unknown
		//IL_0742: Expected VT, but got I4
		//IL_075a: Expected Obj, but got I
		//IL_0774: Expected Obj, but got I4
		//IL_077d: Expected Obj, but got I4
		//IL_0e9e: Expected Obj, but got I4
		//IL_079b: Expected Obj, but got I
		//IL_0c6c: Expected Obj, but got I
		//IL_0c96: Expected Obj, but got I
		//IL_0cb0: Expected Obj, but got I
		//IL_0ab8: Expected Obj, but got I
		//IL_080e: Expected F4, but got I
		//IL_0b2b: Expected F4, but got I
		//IL_0846: Expected F4, but got I
		//IL_0846: Expected F4, but got I
		//IL_0862: Expected Obj, but got I4
		//IL_0872: Expected Obj, but got I4
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected Obj, but got Unknown
		//IL_0b60: Expected F4, but got I
		//IL_0b7c: Expected Obj, but got I4
		//IL_0b8c: Expected Obj, but got I4
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Expected Obj, but got Unknown
		//IL_0eb7: Expected VT, but got I4
		//IL_08d8: Expected F4, but got I
		//IL_08d8: Expected F4, but got I
		//IL_0bd5: Expected Obj, but got I
		//IL_0910: Expected F4, but got I
		//IL_0910: Expected F4, but got I
		//IL_092c: Expected Obj, but got I4
		//IL_093c: Expected Obj, but got I4
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected Obj, but got Unknown
		//IL_0c1b: Expected Obj, but got I
		//IL_09b4: Expected Obj, but got I4
		//IL_09c4: Expected Obj, but got I4
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Expected Obj, but got Unknown
		//IL_0d3e: Expected Obj, but got I
		//IL_0a0d: Expected Obj, but got I
		//IL_0a4d: Expected Obj, but got I
		//IL_0a7f: Expected Obj, but got I
		//IL_0a88: Expected VT, but got I4
		//IL_0a91: Expected VT, but got I4
		//IL_0a9a: Expected VT, but got I4
		//IL_0aa3: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v4+10]");
		bool flag2 = (UnityEngine.Object)0 == null;
		bool flag3 = !flag2;
		UnityEngine.Object obj7 = null;
		if (!flag3)
		{
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v101+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD36C");
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v84+A0]");
			object obj12 = (nint)0 + (nint)16;
			UnityEngine.Object obj13 = default;
			obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj7 = obj13;
		}
		object obj14 = obj;
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v6+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7+10]");
		bool flag6 = (UnityEngine.Object)0 != null;
		bool flag7 = !flag6;
		UnityEngine.Object obj18 = null;
		if (flag7)
		{
			goto IL_025d;
		}
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v80+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v81+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v81+10]");
			Transform transform = ((Component)0).transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				bool flag8 = ShopRooms.Holds((Vector3)0);
				bool flag9 = !flag8;
				object obj21 = !flag9;
				obj18 = null;
				if (obj21 == null)
				{
					goto IL_025d;
				}
				return;
			}
		}
		goto IL_0daf;
		IL_0588:
		float num;
		float num2;
		float maxInclusive = num - num2;
		float num3 = stepPitchLow;
		goto IL_0e66;
		IL_0dbd:
		throw new IndexOutOfRangeException();
		IL_025d:
		object obj22 = obj;
		object obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v12+A0]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v17+E4]");
		bool flag10 = (nint)0 == 0;
		object obj25 = !flag10;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v13+10]");
		if (!((UnityEngine.Object)0 != null))
		{
			goto IL_03fd;
		}
		object obj26 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v75+A0]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v76+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v76+10]");
			Transform transform2 = ((Component)0).transform;
			if ((object)transform2 != null)
			{
				Vector3 position2 = transform2.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8E8]");
				object obj28 = 0;
				object obj29 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X0_v88+E4]");
				bool flag11 = (nint)0 == 0;
				object obj30 = !flag11;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag12 = MonsterDread.ShutOut((Vector3)0, (Vector3)0);
				bool flag13 = !flag12;
				object obj31 = !flag13;
				if (obj31 == null)
				{
					goto IL_03fd;
				}
				return;
			}
		}
		goto IL_0daf;
		IL_03fd:
		float time = Time.time;
		float num4 = time - lastStep;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
		if (num4 < 0f)
		{
			return;
		}
		float time2 = Time.time;
		float num5 = stepPitchHigh;
		lastStep = time2;
		float num6 = stepPitchHigh - stepPitchLow;
		float num7 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		num2 = num7 * 0f;
		float num8 = UnityEngine.Random.Range(stepPitchLow, stepPitchHigh);
		object obj32 = 6;
		while (true)
		{
			num = lastStepPitch;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			if (!(num5 < num2))
			{
				break;
			}
			num5 = stepPitchHigh;
			num8 = UnityEngine.Random.Range(stepPitchLow, stepPitchHigh);
			obj32--;
			if ((nint)obj32 == 1)
			{
				num = lastStepPitch;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
				break;
			}
		}
		if (!(num5 < num2))
		{
			goto IL_0634;
		}
		num3 = num2 + num;
		maxInclusive = stepPitchHigh;
		bool flag14 = num3 < stepPitchHigh;
		object obj33 = !flag14;
		float num9 = num3 - stepPitchHigh;
		bool flag15 = num9 == 0f;
		object obj34 = ~obj33;
		object obj35 = obj34 | flag15;
		if (obj35 == null)
		{
			goto IL_0588;
		}
		float num10 = num - num2;
		num6 = stepPitchLow;
		if (!(num10 < stepPitchLow))
		{
			float value = UnityEngine.Random.value;
			num = lastStepPitch;
			if (!((double)value < 0.5))
			{
				goto IL_0588;
			}
			maxInclusive = stepPitchHigh;
			num3 = num2 + lastStepPitch;
		}
		goto IL_0e66;
		IL_0e66:
		num8 = UnityEngine.Random.Range(num3, maxInclusive);
		goto IL_0634;
		IL_0e7c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X8_v20+8]");
		bool flag16 = (nint)0 == 0;
		object obj36 = !flag16;
		Keyframe keyframe2;
		Keyframe keyframe3;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CA8]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Keyframe keyframe = new Keyframe(0f, 1f);
			Keyframe[] array = default;
			if (array == null)
			{
				goto IL_0daf;
			}
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
			keyframe2 = new Keyframe(0.25f, 0f);
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
			keyframe3 = new Keyframe(1f, 0f);
			bool flag17 = array.Length < 2;
			object obj38 = !flag17;
			object obj39 = array.Length - 2;
			bool flag18 = obj39 == null;
			object obj40 = ~obj38;
			object obj41 = obj40 | flag18;
			if (obj41 != null)
			{
				goto IL_0dbd;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C98]");
			object obj42 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			AnimationCurve animationCurve = default;
			animationCurve._002Ector(array);
			object obj43 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X8_v49+A0]");
			object obj44 = (nint)0 + (nint)8;
			obj44 = animationCurve;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		AudioSource audioSource;
		audioSource.rolloffMode = (AudioRolloffMode)2;
		audioSource.maxDistance = footstepRange;
		object obj45 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X8_v23+A0]");
		object curve = 0;
		audioSource.SetCustomCurve((AudioSourceCurveType)0, (AnimationCurve)curve);
		object obj46 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ X8_v25+A0]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v26+8]");
		audioSource.SetCustomCurve((AudioSourceCurveType)2, (AnimationCurve)0);
		audioSource.priority = 64;
		Transform transform3 = audioSource.transform;
		if ((object)transform3 != null)
		{
			Vector3 position3 = transform3.position;
			if (!Muffled((Vector3)0))
			{
				return;
			}
			GameObject gameObject = audioSource.gameObject;
			if ((object)gameObject != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B10]");
				object obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				AudioLowPassFilter audioLowPassFilter = default;
				if ((object)audioLowPassFilter != null)
				{
					audioLowPassFilter.cutoffFrequency = 500f;
					float volume2 = audioSource.volume;
					float num11 = volume2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
					float volume3 = num11 * 0f;
					audioSource.volume = volume3;
					return;
				}
			}
		}
		goto IL_0daf;
		IL_0daf:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0dbd;
		IL_0634:
		lastStepPitch = num8;
		float pitch = num8 * footstepPitch;
		float volume4 = default;
		audioSource = Play(footsteps, volume4, pitch, 1f);
		object obj49 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v17+E4]");
		bool flag19 = (nint)0 == 0;
		object obj50 = !flag19;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag20 = audioSource == null;
		bool flag21 = !flag20;
		object obj51 = !flag21;
		if (obj51 != null)
		{
			return;
		}
		if ((object)audioSource != null)
		{
			Transform transform4 = audioSource.transform;
			if ((object)transform4 != null)
			{
				transform4.position = (Vector3)0;
				object obj52 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X8_v18+A0]");
				object obj53 = 0;
				bool flag22 = obj53 == null;
				object obj54 = !flag22;
				object obj55 = 0;
				if (obj54 != null)
				{
					goto IL_0e7c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CA8]");
				object obj56 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Keyframe keyframe = new Keyframe(0f, 1f);
				Keyframe[] array2 = default;
				if (array2 != null)
				{
					_ = 0;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8D4]");
					keyframe2 = new Keyframe(0f, 1f);
					_ = 0;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEBC]");
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
					keyframe3 = new Keyframe(num12, 0f);
					bool flag23 = array2.Length < 2;
					object obj57 = !flag23;
					object obj58 = array2.Length - 2;
					bool flag24 = obj58 == null;
					object obj59 = ~obj57;
					object obj60 = obj59 | flag24;
					if (obj60 == null)
					{
						_ = 0;
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
						nint num13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
						Keyframe keyframe4 = new Keyframe(num13, 0f);
						_ = 0;
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A83C]");
						nint num14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
						Keyframe keyframe5 = new Keyframe(num14, 0f);
						bool flag25 = array2.Length < 4;
						object obj61 = !flag25;
						object obj62 = array2.Length - 4;
						bool flag26 = obj62 == null;
						object obj63 = ~obj61;
						object obj64 = obj63 | flag26;
						if (obj64 == null)
						{
							_ = 0;
							_ = 0;
							_ = 0;
							Keyframe keyframe6 = new Keyframe(1f, 0f);
							bool flag27 = array2.Length < 5;
							object obj65 = !flag27;
							object obj66 = array2.Length - 5;
							bool flag28 = obj66 == null;
							object obj67 = ~obj65;
							object obj68 = obj67 | flag28;
							if (obj68 == null)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C98]");
								object obj69 = 0;
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								AnimationCurve animationCurve2 = default;
								animationCurve2._002Ector(array2);
								object obj70 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1061 @ X8_v70+A0]");
								object obj71 = 0;
								obj71 = animationCurve2;
								object obj72 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj73 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X8_v73+A0]");
								obj53 = 0;
								keyframe3 = (Keyframe)0;
								keyframe2 = (Keyframe)0;
								keyframe = (Keyframe)0;
								obj55 = 0;
								goto IL_0e7c;
							}
						}
					}
					goto IL_0dbd;
				}
			}
		}
		goto IL_0daf;
	}

	private unsafe bool Muffled(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0559: Expected Obj, but got I
		//IL_057b: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_0518: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected I4, but got Unknown
		//IL_01bf: Expected Obj, but got I
		//IL_0539: Expected I4, but got Obj
		//IL_01f5: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I4
		//IL_02e2: Expected Obj, but got I
		//IL_030c: Expected Obj, but got I4
		//IL_0349: Expected VT, but got I8
		//IL_0349: Expected VT, but got Ref
		//IL_0372: Expected Obj, but got I8
		//IL_0439: Expected Obj, but got I4
		//IL_0476: Expected VT, but got I8
		//IL_0476: Expected VT, but got Ref
		//IL_0526: Expected Obj, but got I4
		//IL_050a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+10]");
		bool flag2 = (UnityEngine.Object)0 == null;
		bool flag3 = !flag2;
		UnityEngine.Object obj7 = null;
		if (!flag3)
		{
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v47+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD36C");
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v21+A0]");
			object obj12 = (nint)0 + (nint)16;
			UnityEngine.Object obj13 = default;
			obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj7 = obj13;
		}
		object obj14 = obj;
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v6+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v7+10]");
		bool flag6 = (UnityEngine.Object)0 == null;
		bool flag7 = !flag6;
		object obj18 = !flag7;
		if (obj18 != null)
		{
			goto IL_050f;
		}
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v11+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v12+10]");
		Transform transform2;
		object obj23;
		RaycastHit raycastHit = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		object obj26;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v12+10]");
			Transform transform = ((Component)0).transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				object obj21 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v19+E4]");
				bool flag8 = (nint)0 == 0;
				object obj22 = !flag8;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag9 = brain != null;
				bool flag10 = !flag9;
				MonsterAnimEvents monsterAnimEvents = this;
				if (!flag10)
				{
					monsterAnimEvents = (MonsterAnimEvents)(object)brain;
					if ((object)brain == null)
					{
						goto IL_052b;
					}
				}
				transform2 = monsterAnimEvents.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
				obj23 = 0;
				object obj24 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v15+E4]");
				bool flag11 = (nint)0 == 0;
				object obj25 = !flag11;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag12 = Physics.Linecast((Vector3)(&raycastHit), (Vector3)4294961403L, out *(RaycastHit*)1, 0, queryTriggerInteraction);
				bool flag13 = !flag12;
				ref RaycastHit reference = ref *(RaycastHit*)1;
				Transform transform3 = (Transform)4294961403L;
				if (flag13)
				{
					goto IL_040f;
				}
				Collider collider = raycastHit.collider;
				if ((object)collider != null)
				{
					Transform transform4 = collider.transform;
					if ((object)transform4 != null)
					{
						bool flag14 = transform4.IsChildOf(transform2);
						bool flag15 = !flag14;
						reference = ref *(RaycastHit*)null;
						transform3 = transform2;
						if (!flag15)
						{
							goto IL_040f;
						}
						obj26 = 1;
						goto IL_0589;
					}
				}
			}
		}
		goto IL_052b;
		IL_052b:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_050f:
		obj26 = 0;
		goto IL_0589;
		IL_040f:
		object obj27 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v29+E4]");
		bool flag16 = (nint)0 == 0;
		object obj28 = !flag16;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Physics.Linecast((Vector3)(&raycastHit), (Vector3)4294961403L, out *(RaycastHit*)1, 0, queryTriggerInteraction))
		{
			goto IL_050f;
		}
		Collider collider2 = raycastHit.collider;
		if ((object)collider2 != null)
		{
			Transform transform5 = collider2.transform;
			if ((object)transform5 != null)
			{
				bool flag17 = transform5.IsChildOf(transform2);
				obj26 = (flag17 ? 1 : 0) ^ 1;
				goto IL_0589;
			}
		}
		goto IL_052b;
		IL_0589:
		return (byte)(obj26 & 1) != 0;
	}

	public void KillGrab()
	{
		//IL_001d: Expected F4, but got I
		//IL_001d: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B004]");
		float pitch = UnityEngine.Random.Range(num, 0f);
		AudioSource audioSource = Play(grabSounds, 1f, pitch, 6f);
		if (~(screamOnCue ? 1u : 0u) != 0)
		{
			KillScream();
		}
	}

	public void KillScream()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I
		//IL_02a0: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I4
		//IL_016c: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+A0]");
		object obj5 = 0;
		UnityEngine.Object obj6 = (UnityEngine.Object)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = brain == null;
		bool flag3 = !flag2;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			return;
		}
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = (UnityEngine.Object)obj5 == null;
		bool flag6 = !flag5;
		object obj11 = !flag6;
		if (obj11 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X20_v2 (UnityEngine.Object)+A9]");
		if ((nint)0 == 0)
		{
			return;
		}
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		object obj13 = !flag7;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X20_v2 (UnityEngine.Object)+C0]");
		bool flag8 = (UnityEngine.Object)0 != brain;
		bool flag9 = !flag8;
		object obj14 = !flag9;
		if (obj14 == null)
		{
			float volume = jumpscareVolume * 0.5f;
			AudioSource audioSource = Play(jumpscareSounds, volume, 1f, 10f);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v10+E4]");
			bool flag10 = (nint)0 == 0;
			object obj16 = !flag10;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (audioSource != null)
			{
				audioSource.spatialBlend = 0f;
			}
		}
	}

	public void KillBite()
	{
		//IL_0010: Expected Obj, but got I
		//IL_007b: Expected F4, but got I
		//IL_007b: Expected F4, but got I
		//IL_00cf: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B004]");
		float pitch = UnityEngine.Random.Range(num, 0f);
		AudioSource audioSource = Play(biteSounds, 1f, pitch, 6f);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (brain != null)
		{
			brain.OnBite();
		}
	}

	public void KillBlink()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0220: Expected F4, but got I
		//IL_0220: Expected F4, but got I
		//IL_0282: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I4
		//IL_0193: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB8C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE3C]");
		float num2 = UnityEngine.Random.Range(num, 0f);
		float pitch = footstepPitch * num2;
		AudioSource audioSource = Play(footsteps, footstepVolume, pitch, 8f);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(brain != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj4 = 0;
		object obj5 = obj;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!((UnityEngine.Object)obj7 != null))
		{
			return;
		}
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v8+A0]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v10+A9]");
		if ((nint)0 != 0)
		{
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v16+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v10+C0]");
			if ((UnityEngine.Object)0 == brain)
			{
				object obj14 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v12+A0]");
				object obj15 = 0;
				object obj16 = obj15;
				float time = Time.time;
				float num3 = time;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD58]");
				float num4 = num3 + 0f;
			}
		}
	}

	public void KillGrind()
	{
		//IL_001a: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		float num = UnityEngine.Random.Range(0.5f, 0f);
		float num2 = footstepVolume;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
		float volume = num2 * 0f;
		float pitch = footstepPitch * num;
		AudioSource audioSource = Play(footsteps, volume, pitch, 6f);
	}

	public void KillTwist()
	{
		//IL_0010: Expected Obj, but got I
		//IL_020e: Expected F4, but got I
		//IL_020e: Expected F4, but got I
		//IL_0262: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I4
		//IL_0193: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_01ec: Expected Obj, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD5C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7FC]");
		float pitch = UnityEngine.Random.Range(num, 0f);
		AudioSource audioSource = Play(grabSounds, 1f, pitch, 6f);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(brain != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj4 = 0;
		object obj5 = obj;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v6+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!((UnityEngine.Object)obj7 != null))
		{
			return;
		}
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v8+A0]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v10+A9]");
		if ((nint)0 != 0)
		{
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v16+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v10+C0]");
			if ((UnityEngine.Object)0 == brain)
			{
				object obj14 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v12+A0]");
				object obj15 = 0;
				object obj16 = obj15 + 276;
				obj16 = 4915310915697377280L;
			}
		}
	}

	public void KillNip()
	{
		//IL_001d: Expected F4, but got I
		//IL_001d: Expected F4, but got I
		//IL_0046: Expected F4, but got I
		//IL_006f: Expected F4, but got I
		//IL_008f: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B004]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
		float pitch = UnityEngine.Random.Range(num, 0f);
		AudioClip[] clips = biteSounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		AudioSource audioSource = Play(clips, 0f, pitch, 6f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		Buzz((XRNode)4, 0.75f, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		Buzz((XRNode)5, 0.75f, 0f);
	}

	public void KillStab()
	{
		//IL_001d: Expected F4, but got I
		//IL_001d: Expected F4, but got I
		//IL_006c: Expected F4, but got I
		//IL_008c: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		float pitch = UnityEngine.Random.Range(num, 0f);
		AudioSource audioSource = Play(stabSounds, 1f, pitch, 6f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		Buzz((XRNode)4, 0f, 0.25f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		Buzz((XRNode)5, 0f, 0.25f);
	}

	public void KillTear()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00b3: Expected F4, but got I
		//IL_00b3: Expected F4, but got I
		//IL_00fd: Expected F4, but got I
		//IL_003f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB8]");
		float pitch = UnityEngine.Random.Range(num, 0f);
		AudioSource audioSource = Play(tearSounds, 1f, pitch, 6f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		Buzz((XRNode)5, 1f, 0f);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (brain != null)
		{
			brain.OnTear();
		}
	}

	public void KillThrow()
	{
		//IL_0023: Expected F4, but got I
		//IL_0023: Expected F4, but got I
		//IL_0046: Expected F4, but got I
		//IL_0046: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		Buzz((XRNode)4, num, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		Buzz((XRNode)5, num2, 0f);
	}

	public void KillLand()
	{
		//IL_001d: Expected F4, but got I
		//IL_001d: Expected F4, but got I
		//IL_006f: Expected F4, but got I
		//IL_006f: Expected F4, but got I
		//IL_0092: Expected F4, but got I
		//IL_0092: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB8]");
		float pitch = UnityEngine.Random.Range(num, 0f);
		AudioSource audioSource = Play(landSounds, 1f, pitch, 6f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		Buzz((XRNode)4, num2, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		Buzz((XRNode)5, num3, 0f);
	}

	public void PryScrape()
	{
		//IL_001d: Expected F4, but got I
		//IL_001d: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B004]");
		float pitch = UnityEngine.Random.Range(num, 0f);
		AudioSource audioSource = Play(clawSounds, 1f, pitch, 6f);
	}

	public void PryBang()
	{
		//IL_001d: Expected F4, but got I
		//IL_001d: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE68]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF4C]");
		float pitch = UnityEngine.Random.Range(num, 0f);
		AudioSource audioSource = Play(bangSounds, 1f, pitch, 15f);
	}

	private AudioSource Play(AudioClip[] clips, float volume, float pitch, float range)
	{
		//IL_0062: Expected VT, but got I4
		//IL_00bc: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I4
		//IL_01a7: Expected Obj, but got I
		//IL_01bb: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I
		//IL_028b: Expected VT, but got I4
		//IL_029b: Expected Obj, but got I
		//IL_02dc: Expected Obj, but got I
		//IL_0380: Expected Obj, but got I
		//IL_03a1: Invalid comparison between F4 and I
		//IL_0493: Expected Obj, but got I4
		//IL_03c8: Expected F4, but got I
		AudioSource result;
		if (clips != null && clips.Length != 0)
		{
			Transform transform = base.transform;
			if ((object)transform == null)
			{
				goto IL_0433;
			}
			Vector3 position = transform.position;
			bool flag = GillaBackroomsSwitch.OnYourSide((Vector3)0);
			bool flag2 = !flag;
			result = null;
			if (!flag2)
			{
				int num = UnityEngine.Random.Range(0, clips.Length);
				bool flag3 = num < clips.Length;
				object obj = !flag3;
				if (obj != null)
				{
					goto IL_0441;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj2 = 0;
				object obj3 = clips + num;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v15+E4]");
				bool flag4 = (nint)0 == 0;
				object obj5 = !flag4;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v9+20]");
				bool flag5 = (UnityEngine.Object)0 == null;
				bool flag6 = !flag5;
				object obj6 = !flag6;
				result = null;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v9+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v9+20]");
						string text = ((UnityEngine.Object)0).name;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8F0]");
						object obj7 = 0;
						string text2 = (string)obj7 + text;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						GameObject gameObject = default;
						gameObject._002Ector(text2);
						if ((object)gameObject != null)
						{
							Transform transform2 = gameObject.transform;
							Transform transform3 = base.transform;
							if ((object)transform3 != null)
							{
								Vector3 position2 = transform3.position;
								if ((object)transform2 != null)
								{
									transform2.position = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4350]");
									object obj9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
									AudioSource audioSource = default;
									if ((object)audioSource != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v9+20]");
										audioSource.clip = (AudioClip)0;
										audioSource.volume = volume;
										audioSource.pitch = pitch;
										audioSource.spatialBlend = 1f;
										audioSource.minDistance = range;
										float maxDistance = range * 3f;
										audioSource.maxDistance = maxDistance;
										audioSource.rolloffMode = (AudioRolloffMode)1;
										audioSource.dopplerLevel = 0f;
										audioSource.Play();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v9+20]");
										float length = ((AudioClip)0).length;
										object obj10 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
										float num2;
										if (pitch < 0f)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
											num2 = 0f;
										}
										else
										{
											num2 = pitch;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v42+E4]");
										bool flag7 = (nint)0 == 0;
										object obj11 = !flag7;
										if (obj11 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										float num3 = length / num2;
										float num4 = num3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
										float t = num4 + 0f;
										UnityEngine.Object.Destroy(gameObject, t);
										result = audioSource;
										goto IL_046c;
									}
								}
							}
						}
					}
					goto IL_0433;
				}
			}
		}
		else
		{
			result = null;
		}
		goto IL_046c;
		IL_046c:
		return result;
		IL_0433:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0441;
		IL_0441:
		return (AudioSource)(object)new IndexOutOfRangeException();
	}

	private void Buzz(XRNode node, float amp, float seconds)
	{
		//IL_006c: Invalid comparison between F4 and I4
		//IL_007b: Expected F4, but got I4
		if (!KillingYou)
		{
			return;
		}
		InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
		InputDevice inputDevice = default;
		if (!inputDevice.isValid)
		{
			return;
		}
		bool flag = amp < 0f;
		float amplitude = 0f;
		if (!flag)
		{
			bool flag2 = !((double)amp > 1.0);
			amplitude = amp;
			if (!flag2)
			{
				amplitude = 1f;
			}
		}
		bool flag3 = inputDevice.SendHapticImpulse(0u, amplitude, seconds);
	}

	public MonsterAnimEvents()
	{
		//IL_0028: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F4B0]");
		footstepVolume = 0f;
		base._002Ector();
	}
}
