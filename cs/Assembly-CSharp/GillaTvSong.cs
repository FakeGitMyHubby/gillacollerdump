using System;
using Cpp2ILInjected;
using UnityEngine;

public class GillaTvSong : MonoBehaviour
{
	public AudioSource source;

	public Bounds[] room;

	public float volume;

	public float fade;

	private const float Ease = default(float);

	private const float OutOfStep = default(float);

	private float level;

	private float nextCheck;

	public float Level => level;

	public float Length
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0128: Expected Obj, but got I4
			//IL_00fe: Expected F4, but got I4
			//IL_008a: Expected Obj, but got I4
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
			if (source != null)
			{
				AudioClip clip = source.clip;
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (clip != null)
				{
					AudioClip clip2 = source.clip;
					return clip2.length;
				}
			}
			return 0f;
		}
	}

	public float SongTime
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0267: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got I4
			//IL_0057: Expected F4, but got I4
			//IL_009e: Expected Obj, but got I4
			//IL_00e3: Expected Obj, but got I4
			//IL_00ec: Expected F4, but got I4
			//IL_01e4: Expected Obj, but got I
			//IL_020e: Expected Obj, but got I4
			//IL_01ae: Expected F4, but got I4
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
			bool flag2 = source == null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			float result = 0f;
			if (obj4 == null)
			{
				AudioClip clip = source.clip;
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v6+E4]");
				bool flag4 = (nint)0 == 0;
				object obj6 = !flag4;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = clip == null;
				bool flag6 = !flag5;
				object obj7 = !flag6;
				result = 0f;
				if (obj7 == null)
				{
					if (source.isPlaying)
					{
						AudioClip clip2 = source.clip;
						int frequency = clip2.frequency;
						if (frequency >= 1)
						{
							int timeSamples = source.timeSamples;
							AudioClip clip3 = source.clip;
							int frequency2 = clip3.frequency;
							int num = timeSamples / frequency2;
							result = num;
							goto IL_0275;
						}
					}
					AudioClip clip4 = source.clip;
					float length = clip4.length;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA198]");
					object obj8 = 0;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v19+E4]");
					bool flag7 = (nint)0 == 0;
					object obj10 = !flag7;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return GillaBoombox.InStep(length);
				}
			}
			goto IL_0275;
			IL_0275:
			return result;
		}
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		level = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (source != null)
		{
			source.volume = 0f;
		}
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I4
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
		if (source != null)
		{
			source.Pause();
		}
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_05e5: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_00e7: Expected Obj, but got I4
		//IL_00f6: Expected VT, but got I4
		//IL_0139: Invalid comparison between F4 and I4
		//IL_014c: Expected Obj, but got F4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_018a: Expected Obj, but got I4
		//IL_0627: Expected Obj, but got I4
		//IL_063f: Invalid comparison between F4 and I4
		//IL_0650: Expected Obj, but got I4
		//IL_0684: Invalid comparison between F4 and I
		//IL_0695: Expected Obj, but got I4
		//IL_06b5: Invalid comparison between F4 and I4
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected Obj, but got Unknown
		//IL_04c9: Expected F4, but got I4
		//IL_04ff: Expected Obj, but got I
		//IL_0529: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I
		//IL_02b6: Expected Obj, but got I4
		//IL_036f: Invalid comparison between F4 and I4
		//IL_037e: Expected F4, but got I4
		//IL_0731: Invalid comparison between F4 and I
		//IL_0395: Invalid comparison between F4 and I4
		//IL_03a4: Expected F4, but got I4
		//IL_0432: Expected Obj, but got I4
		//IL_0403: Expected F4, but got I8
		//IL_03bb: Invalid comparison between F4 and I4
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
		Vector3 vector = ((GillaTvSong)flag5).Ears();
		float num = Inside((Vector3)0);
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		float num2 = unscaledDeltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		float num3 = num2 / 0f;
		float num4 = num - level;
		bool flag6 = num4 < 0f;
		object obj7 = num4 ^ num4;
		object obj8 = num4 & obj7;
		bool flag7 = (nint)obj8 < 0;
		float num5 = 0f - num3;
		bool flag8 = flag6 == flag7;
		object obj9 = !flag8;
		object obj10 = ~obj9;
		float num6 = ((obj10 != null) ? num3 : num5);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num7 = level + num6;
		bool flag9 = num5 < num3;
		object obj11 = !flag9;
		float num8 = num5 - num3;
		bool flag10 = num8 == 0f;
		object obj12 = !flag10;
		object obj13 = obj11 & obj12;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			num = num7;
		}
		float num9 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		bool flag11 = num9 < 0f;
		object obj15 = !flag11;
		float num10 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		float num11 = num10 - 0f;
		bool flag12 = num11 == 0f;
		level = num;
		object obj16 = ~obj15;
		object obj17 = obj16 | flag12;
		float length;
		object obj18;
		float num21;
		if (obj17 == null)
		{
			if (source.isPlaying)
			{
				float unscaledTime = Time.unscaledTime;
				if (!(unscaledTime < nextCheck))
				{
					float unscaledTime2 = Time.unscaledTime;
					float num12 = unscaledTime2 + 5f;
					nextCheck = num12;
					AudioClip clip2 = source.clip;
					length = clip2.length;
					float time = source.time;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA198]");
					obj18 = 0;
					object obj19 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v40+E4]");
					bool flag13 = (nint)0 == 0;
					object obj20 = !flag13;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num13 = GillaBoombox.InStep(length);
					float num14 = time / length;
					float num15 = num13 / length;
					float num16 = num14 * 1.13587E+09f;
					float num17 = num15 * 1.13587E+09f;
					float num18 = num17 - num16;
					float num19 = num18 / 1.13587E+09f;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					float num20 = num19 * 1.13587E+09f;
					num21 = num18 - num20;
					bool flag14 = num21 < 0f;
					float num22 = 0f;
					if (!flag14)
					{
						bool flag15 = num21 > 1.13587E+09f;
						float num23 = 1.13587E+09f;
						if (!flag15)
						{
							bool flag16 = !(num21 > 1.1274813E+09f);
							num23 = num21;
							num22 = num21;
							if (flag16)
							{
								goto IL_06f8;
							}
						}
						num22 = num23 + 3.2833536E+09f;
						num21 = 3.2833536E+09f;
					}
					goto IL_06f8;
				}
			}
			else
			{
				AudioClip clip3 = source.clip;
				float length2 = clip3.length;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA198]");
				object obj21 = 0;
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v28+E4]");
				bool flag17 = (nint)0 == 0;
				object obj23 = !flag17;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float time2 = GillaBoombox.InStep(length2);
				source.time = time2;
				source.Play();
				float unscaledTime3 = Time.unscaledTime;
				float num24 = unscaledTime3 + 2f;
				nextCheck = num24;
			}
			goto IL_06e9;
		}
		if (source.isPlaying)
		{
			source.Pause();
		}
		AudioSource audioSource = source;
		float num25 = 0f;
		goto IL_0748;
		IL_06f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		float num26 = num21 / 1.13587E+09f;
		float num27 = length * num26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		if (num27 > 0f)
		{
			object obj24 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X0_v43+E4]");
			bool flag18 = (nint)0 == 0;
			object obj25 = !flag18;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float time3 = GillaBoombox.InStep(length);
			source.time = time3;
		}
		goto IL_06e9;
		IL_0748:
		audioSource.volume = num25;
		return;
		IL_06e9:
		audioSource = source;
		num25 = level * volume;
		goto IL_0748;
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
		//IL_0035: Expected VT, but got I4
		//IL_007c: Expected F4, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got I8
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00d1: Expected F4, but got I4
		//IL_00f3: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I4
		//IL_03a7: Expected Obj, but got I4
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Obj, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected Obj, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected Obj, but got Unknown
		//IL_01f1: Expected Obj, but got I
		//IL_020e: Expected Obj, but got I
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0409: Invalid comparison between F4 and I4
		//IL_02c5: Invalid comparison between F4 and I4
		//IL_0438: Invalid comparison between F8 and I4
		//IL_0447: Invalid comparison between F8 and I4
		//IL_045a: Expected Obj, but got F8
		//IL_0467: Expected Obj, but got F8
		//IL_049c: Expected Obj, but got I4
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_0303: Invalid comparison between F4 and I4
		//IL_0312: Expected F8, but got I4
		Transform transform = base.transform;
		float result;
		if ((object)transform != null)
		{
			Vector3 vector = transform.InverseTransformPoint((Vector3)0);
			Bounds[] array = room;
			if (room != null)
			{
				bool flag = array.Length < 1;
				result = 0f;
				if (flag)
				{
					goto IL_0370;
				}
				object obj = ~array.Length;
				object obj2 = array.Length & obj;
				object obj3 = array.Length & 0xFFFFFFFFL;
				object obj4 = room + 52;
				float num = 0f;
				object obj8 = default;
				float num7 = default;
				object obj21 = default;
				while (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v5-10]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v5-4]");
					object obj5 = num2 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v5-10]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v5-4]");
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v5-14]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v5-8]");
						object obj17 = num4 - 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v5-14]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v5-8]");
						object obj18 = num5 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v5-C]");
						object obj19 = 0 - obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v5-C]");
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
					bool flag14 = (nint)obj2 != 1;
					result = num;
					if (flag14)
					{
						continue;
					}
					goto IL_0370;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
		}
		throw new NullReferenceException();
		IL_0370:
		return result;
	}

	public GillaTvSong()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_004f: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5048]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 40;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C1C0]");
		volume = 0f;
		base._002Ector();
	}
}
