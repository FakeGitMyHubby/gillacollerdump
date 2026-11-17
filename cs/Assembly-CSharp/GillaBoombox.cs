using System;
using Cpp2ILInjected;
using UnityEngine;

public class GillaBoombox : MonoBehaviour
{
	public AudioSource source;

	public PressKey muteKey;

	public PixelLabel keyFace;

	public PixelLabel screen;

	public Renderer lamp;

	public Bounds[] shop;

	public float volume;

	public float fade;

	public const string MutedKey = null;

	private const float Ease = default(float);

	private const float OutOfStep = default(float);

	public static readonly Color32 Amber;

	public static readonly Color32 Red;

	public static readonly Color32 Dark;

	private static readonly int BaseColorId;

	private bool muted;

	private float level;

	private float nextCheck;

	private MaterialPropertyBlock block;

	public bool Muted => muted;

	public float Level => level;

	public float InShop
	{
		get
		{
			//IL_0014: Expected VT, but got I
			Vector3 vector = Ears();
			IntPtr intPtr = default;
			return Inside((Vector3)(nint)intPtr);
		}
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_00a7: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF680]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		int num = PlayerPrefs.GetInt((string)key, 0);
		object obj2 = obj;
		object obj3 = num - 1;
		bool flag = obj3 == null;
		muted = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = muteKey != null;
		bool flag4 = !flag3;
		object obj5 = 0;
		Action<PressKey> action = null;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF688]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Action<System.__Canon> action2 = default;
			action2._002Ector((object)this, (IntPtr)obj7);
			muteKey.Pressed += (Action<PressKey>)action2;
			obj5 = 0;
			action = (Action<PressKey>)action2;
		}
		object obj8 = obj;
		level = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (source != null)
		{
			source.volume = 0f;
		}
		Show();
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_0097: Expected I, but got Obj
		//IL_00b4: Expected Obj, but got I4
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
		bool flag2 = muteKey != null;
		bool flag3 = !flag2;
		object obj4 = 0;
		Action<PressKey> action = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF688]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Action<System.__Canon> action2 = default;
			action2._002Ector((object)this, (IntPtr)obj6);
			muteKey.Pressed -= (Action<PressKey>)action2;
			obj4 = 0;
			action = (Action<PressKey>)action2;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (source != null)
		{
			source.Pause();
		}
	}

	private void OnKey(PressKey _)
	{
		bool flag = !muted;
		SetMuted(flag);
	}

	public void SetMuted(bool on)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF680]");
		object key = 0;
		muted = on;
		PlayerPrefs.SetInt((string)key, on ? 1 : 0);
		PlayerPrefs.Save();
		Show();
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_058a: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I4
		//IL_00fd: Expected F4, but got I4
		//IL_05d2: Invalid comparison between F4 and I4
		//IL_05e5: Expected Obj, but got F4
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected Obj, but got Unknown
		//IL_0623: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I4
		//IL_0123: Expected VT, but got I4
		//IL_066e: Expected Obj, but got I4
		//IL_0686: Invalid comparison between F4 and I4
		//IL_0697: Expected Obj, but got I4
		//IL_06cb: Invalid comparison between F4 and I
		//IL_06dc: Expected Obj, but got I4
		//IL_06fc: Invalid comparison between F4 and I4
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected Obj, but got Unknown
		//IL_046e: Expected F4, but got I4
		//IL_04a4: Expected Obj, but got I
		//IL_04ce: Expected Obj, but got I4
		//IL_0231: Expected Obj, but got I
		//IL_025b: Expected Obj, but got I4
		//IL_0314: Invalid comparison between F4 and I4
		//IL_0323: Expected F4, but got I4
		//IL_0778: Invalid comparison between F4 and I
		//IL_033a: Invalid comparison between F4 and I4
		//IL_0349: Expected F4, but got I4
		//IL_03d7: Expected Obj, but got I4
		//IL_03a8: Expected F4, but got I8
		//IL_0360: Invalid comparison between F4 and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = source == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		AudioClip clip = source.clip;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = clip == null;
		if (flag5)
		{
			return;
		}
		bool flag6 = (byte)(~(muted ? 1u : 0u)) != 0;
		object obj7 = !flag6;
		float num = 0f;
		if (obj7 == null)
		{
			Vector3 vector = ((GillaBoombox)flag5).Ears();
			float num2 = Inside((Vector3)0);
			num = num2;
		}
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		float num3 = unscaledDeltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		float num4 = num3 / 0f;
		float num5 = num - level;
		bool flag7 = num5 < 0f;
		object obj8 = num5 ^ num5;
		object obj9 = num5 & obj8;
		bool flag8 = (nint)obj9 < 0;
		float num6 = 0f - num4;
		bool flag9 = flag7 == flag8;
		object obj10 = !flag9;
		object obj11 = ~obj10;
		float num7 = ((obj11 != null) ? num4 : num6);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num8 = level + num7;
		bool flag10 = num6 < num4;
		object obj12 = !flag10;
		float num9 = num6 - num4;
		bool flag11 = num9 == 0f;
		object obj13 = !flag11;
		object obj14 = obj12 & obj13;
		object obj15 = ~obj14;
		float num10 = ((obj15 != null) ? num : num8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		bool flag12 = num10 < 0f;
		object obj16 = !flag12;
		float num11 = num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		float num12 = num11 - 0f;
		bool flag13 = num12 == 0f;
		level = num10;
		object obj17 = ~obj16;
		object obj18 = obj17 | flag13;
		float length;
		object obj19;
		float num22;
		if (obj18 == null)
		{
			if (source.isPlaying)
			{
				float unscaledTime = Time.unscaledTime;
				if (!(unscaledTime < nextCheck))
				{
					float unscaledTime2 = Time.unscaledTime;
					float num13 = unscaledTime2 + 5f;
					nextCheck = num13;
					AudioClip clip2 = source.clip;
					length = clip2.length;
					float time = source.time;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA198]");
					obj19 = 0;
					object obj20 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v39+E4]");
					bool flag14 = (nint)0 == 0;
					object obj21 = !flag14;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num14 = InStep(length);
					float num15 = time / length;
					float num16 = num14 / length;
					float num17 = num15 * 1.13587E+09f;
					float num18 = num16 * 1.13587E+09f;
					float num19 = num18 - num17;
					float num20 = num19 / 1.13587E+09f;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					float num21 = num20 * 1.13587E+09f;
					num22 = num19 - num21;
					bool flag15 = num22 < 0f;
					float num23 = 0f;
					if (!flag15)
					{
						bool flag16 = num22 > 1.13587E+09f;
						float num24 = 1.13587E+09f;
						if (!flag16)
						{
							bool flag17 = !(num22 > 1.1274813E+09f);
							num24 = num22;
							num23 = num22;
							if (flag17)
							{
								goto IL_073f;
							}
						}
						num23 = num24 + 3.2833536E+09f;
						num22 = 3.2833536E+09f;
					}
					goto IL_073f;
				}
			}
			else
			{
				AudioClip clip3 = source.clip;
				float length2 = clip3.length;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA198]");
				object obj22 = 0;
				object obj23 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v28+E4]");
				bool flag18 = (nint)0 == 0;
				object obj24 = !flag18;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float time2 = InStep(length2);
				source.time = time2;
				source.Play();
				float unscaledTime3 = Time.unscaledTime;
				float num25 = unscaledTime3 + 2f;
				nextCheck = num25;
			}
			goto IL_0730;
		}
		if (source.isPlaying)
		{
			source.Pause();
		}
		AudioSource audioSource = source;
		float num26 = 0f;
		goto IL_078f;
		IL_0730:
		audioSource = source;
		num26 = level * volume;
		goto IL_078f;
		IL_078f:
		audioSource.volume = num26;
		return;
		IL_073f:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		float num27 = num22 / 1.13587E+09f;
		float num28 = length * num27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		if (num28 > 0f)
		{
			object obj25 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v41+E4]");
			bool flag19 = (nint)0 == 0;
			object obj26 = !flag19;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float time3 = InStep(length);
			source.time = time3;
		}
		goto IL_0730;
	}

	public static float InStep(float length)
	{
		//IL_00ac: Invalid comparison between F4 and I4
		//IL_00bd: Expected Obj, but got I4
		//IL_00c6: Invalid comparison between F4 and I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00eb: Expected F4, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_009e: Expected F4, but got I8
		bool flag = length < 0f;
		object obj = !flag;
		bool flag2 = length == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		float result = 0f;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6178]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime = default;
			long ticks = dateTime.Ticks;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C790]");
			long num = ticks / 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D140");
			result = num;
		}
		return result;
	}

	private Vector3 Ears()
	{
		//IL_0010: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0159: Expected VT, but got Obj
		//IL_0095: Expected Obj, but got I4
		//IL_0146: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		AudioListener listening = GillaEars.Listening;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = listening != null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		Camera camera = (Camera)(object)listening;
		if (obj4 == null)
		{
			Camera main = Camera.main;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v6+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = main != null;
			bool flag6 = !flag5;
			camera = main;
			if (flag6)
			{
				return (Vector3)flag5;
			}
		}
		if ((object)camera != null)
		{
			Transform transform = camera.transform;
			if ((object)transform != null)
			{
				return transform.position;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	public float Inside(Vector3 p)
	{
		//IL_0029: Expected F4, but got I4
		//IL_0042: Expected Obj, but got I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I8
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_007c: Expected F4, but got I4
		//IL_009e: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I4
		//IL_0352: Expected Obj, but got I4
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected Obj, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected Obj, but got Unknown
		//IL_019c: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_03b4: Invalid comparison between F4 and I4
		//IL_0270: Invalid comparison between F4 and I4
		//IL_03e3: Invalid comparison between F8 and I4
		//IL_03f2: Invalid comparison between F8 and I4
		//IL_0405: Expected Obj, but got F8
		//IL_0412: Expected Obj, but got F8
		//IL_0447: Expected Obj, but got I4
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected Obj, but got Unknown
		//IL_02ae: Invalid comparison between F4 and I4
		//IL_02bd: Expected F8, but got I4
		Bounds[] array = shop;
		bool flag = array.Length < 1;
		float result = 0f;
		if (!flag)
		{
			object obj = ~array.Length;
			object obj2 = array.Length & obj;
			object obj3 = array.Length & 0xFFFFFFFFL;
			object obj4 = array + 52;
			float num = 0f;
			object obj8 = default;
			float num7 = default;
			object obj21 = default;
			bool flag14;
			do
			{
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X10_v5-10]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X10_v5-4]");
					object obj5 = num2 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X10_v5-10]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X10_v5-4]");
					object obj6 = num3 + 0;
					object obj7 = obj8 - obj5;
					bool flag2 = (nint)obj7 < 0;
					object obj9 = !flag2;
					object obj10 = ~obj9;
					bool flag3;
					bool flag4;
					bool flag5;
					if (obj10 == null)
					{
						object obj11 = obj8 - obj6;
						flag3 = (nint)obj11 < 0;
						flag4 = obj11 == null;
						object obj12 = obj8 ^ obj6;
						object obj13 = obj8 ^ obj11;
						object obj14 = obj12 & obj13;
						flag5 = (nint)obj14 < 0;
					}
					else
					{
						flag5 = false;
						flag4 = false;
						flag3 = false;
					}
					bool flag6 = flag3 == flag5;
					object obj15 = !flag4;
					object obj16 = flag6 & obj15;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X10_v5-14]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X10_v5-8]");
						object obj17 = num4 - 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X10_v5-14]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X10_v5-8]");
						object obj18 = num5 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X10_v5-C]");
						object obj19 = 0 - obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X10_v5-C]");
						object obj20 = 0 + obj4;
						float num6 = num7 - (float)obj17;
						float num8 = (float)obj18 - num7;
						float num9 = (float)obj21 - (float)obj19;
						float num10 = (float)obj20 - (float)obj21;
						if (num6 < num8)
						{
							num8 = num6;
						}
						if (num9 < num10)
						{
							num10 = num9;
						}
						if (num8 < num10)
						{
							num10 = num8;
						}
						if (num10 > 0f)
						{
							bool flag7 = !(fade > 0f);
							double num11 = 1.0;
							if (!flag7)
							{
								float num12 = num10 / fade;
								bool flag8 = num12 < 0f;
								num11 = 0.0;
								if (!flag8)
								{
									bool flag9 = !((double)num12 > 1.0);
									num11 = num12;
									if (!flag9)
									{
										num11 = 1.0;
									}
								}
							}
							double num13 = (double)num - num11;
							bool flag10 = num13 < 0.0;
							bool flag11 = num13 == 0.0;
							object obj22 = (double)num ^ num11;
							object obj23 = (double)num ^ num13;
							object obj24 = obj22 & obj23;
							bool flag12 = (nint)obj24 < 0;
							bool flag13 = flag10 == flag12;
							object obj25 = !flag11;
							object obj26 = flag13 & obj25;
							object obj27 = ~obj26;
							if (obj27 != null)
							{
								num = (float)num11;
							}
						}
					}
					obj3--;
					obj4 += 24;
					flag14 = (nint)obj2 != 1;
					result = num;
					continue;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
			while (flag14);
		}
		return result;
	}

	private void Show()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0543: Expected Obj, but got I4
		//IL_0255: Expected Obj, but got I4
		//IL_03c2: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got I
		//IL_02d9: Expected Obj, but got I
		//IL_00da: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I4
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected Obj, but got Unknown
		//IL_0431: Expected Obj, but got I4
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Expected Obj, but got Unknown
		//IL_0640: Expected Obj, but got I
		//IL_02c4: Expected Obj, but got I
		//IL_05a6: Expected Obj, but got I
		//IL_05b6: Expected VT, but got I
		//IL_00aa: Expected Obj, but got I4
		//IL_00b7: Expected VT, but got I8
		//IL_049d: Expected Obj, but got I
		//IL_04c7: Expected Obj, but got I4
		//IL_034c: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I
		//IL_044f: Expected Obj, but got I
		//IL_06b9: Expected Obj, but got I
		//IL_0300: Expected Obj, but got I4
		//IL_01df: Expected Obj, but got I4
		//IL_06ce: Expected Obj, but got I
		//IL_06e8: Expected VT, but got I4
		//IL_037e: Expected VT, but got Obj
		//IL_0681: Expected Obj, but got I
		//IL_069b: Expected Obj, but got I4
		//IL_0609: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I4
		//IL_0211: Expected VT, but got Obj
		//IL_05d1: Expected Obj, but got I
		//IL_05eb: Expected Obj, but got I4
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
		bool flag2 = keyFace != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		if (!flag3)
		{
			object obj5;
			if (!muted)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA9E8]");
				obj5 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF698]");
				obj5 = 0;
			}
			object obj6 = keyFace + 32;
			obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			PixelLabel pixelLabel = keyFace;
			Color32 colour;
			if (~(muted ? 1u : 0u) == 0)
			{
				bool flag4 = (object)pixelLabel == null;
				object obj7 = !flag4;
				colour = (Color32)4293323775L;
				if (obj7 == null)
				{
					goto IL_0512;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA198]");
				object obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v57+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v57+A0]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v38+8]");
				colour = (Color32)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA198]");
			object obj12 = 0;
			pixelLabel.colour = colour;
			PixelLabel pixelLabel2 = keyFace;
			object obj13 = obj12;
			object obj15;
			if (~(muted ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v50+E4]");
				bool flag6 = (nint)0 == 0;
				object obj14 = !flag6;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj13 = obj12;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v50+A0]");
				obj15 = (nint)0 + (nint)4;
				bool flag7 = (object)pixelLabel2 == null;
				object obj16 = !flag7;
				if (obj16 == null)
				{
					goto IL_0512;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v50+E4]");
				bool flag8 = (nint)0 == 0;
				object obj17 = !flag8;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj13 = obj12;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v50+A0]");
				obj15 = 0;
			}
			pixelLabel2.background = (Color32)obj15;
			keyFace.Redraw();
			obj4 = null;
		}
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v9+E4]");
		bool flag9 = (nint)0 == 0;
		object obj19 = !flag9;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag10 = screen != null;
		bool flag11 = !flag10;
		UnityEngine.Object obj20 = null;
		if (!flag11)
		{
			object obj21;
			if (!muted)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF690]");
				obj21 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF698]");
				obj21 = 0;
			}
			object obj22 = screen + 32;
			obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA198]");
			object obj23 = 0;
			PixelLabel pixelLabel3 = screen;
			object obj24 = obj23;
			object obj26;
			if (~(muted ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v36+E4]");
				bool flag12 = (nint)0 == 0;
				object obj25 = !flag12;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj24 = obj23;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v36+A0]");
				obj26 = (nint)0 + (nint)4;
				bool flag13 = (object)pixelLabel3 == null;
				object obj27 = !flag13;
				if (obj27 == null)
				{
					goto IL_0512;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v36+E4]");
				bool flag14 = (nint)0 == 0;
				object obj28 = !flag14;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj24 = obj23;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v36+A0]");
				obj26 = 0;
			}
			pixelLabel3.colour = (Color32)obj26;
			screen.Redraw();
			obj20 = null;
		}
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v14+E4]");
		bool flag15 = (nint)0 == 0;
		object obj30 = !flag15;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (lamp != null)
		{
			object obj31 = this + 104;
			bool flag16 = obj31 == null;
			object obj32 = !flag16;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				MaterialPropertyBlock materialPropertyBlock = default;
				materialPropertyBlock._002Ector();
				obj31 = materialPropertyBlock;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			lamp.GetPropertyBlock((MaterialPropertyBlock)obj31);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA198]");
			object obj34 = 0;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v20+E4]");
			bool flag17 = (nint)0 == 0;
			object obj36 = !flag17;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj37 = obj34;
			if (!muted)
			{
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X9_v5+A0]");
			object obj38 = 0;
			object obj39 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X9_v6+C]");
			((MaterialPropertyBlock)obj39).SetColor(0, (Color)0);
			lamp.SetPropertyBlock((MaterialPropertyBlock)obj31);
		}
		return;
		IL_0512:
		throw new NullReferenceException();
	}

	public GillaBoombox()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_004f: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5048]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 72;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B8C0]");
		volume = 0f;
		base._002Ector();
	}

	static GillaBoombox()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I8
		//IL_0062: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
		object obj2 = 0;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = 4280855295L;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+A0]");
		object obj6 = 0;
		_ = 4280166635L;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v7+A0]");
		object obj8 = 0;
		_ = 4278847496L;
		int num = Shader.PropertyToID((string)obj2);
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v9+A0]");
		object obj10 = 0;
	}
}
