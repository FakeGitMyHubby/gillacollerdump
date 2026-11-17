using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class VoicePitch : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public float now;

		internal bool _003CRoom_003Eb__0(float e)
		{
			//IL_001a: Invalid comparison between F4 and I4
			//IL_002f: Expected Obj, but got F4
			//IL_003e: Expected Obj, but got F4
			float num = now - e;
			bool flag = num < 0f;
			object obj = now ^ e;
			object obj2 = now ^ num;
			object obj3 = obj & obj2;
			bool flag2 = (nint)obj3 < 0;
			return flag == flag2;
		}

		internal bool _003CRoom_003Eb__1((AudioClip[], Vector3, float) l)
		{
			//IL_0039: Invalid comparison between F4 and I4
			//IL_0048: Invalid comparison between F4 and I4
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_0070: Expected Obj, but got F4
			//IL_00a5: Expected Obj, but got I4
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Expected I4, but got Unknown
			float num = now;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (System.ValueTuple`3<UnityEngine.AudioClip[], UnityEngine.Vector3, System.Single>)+14]");
			float num2 = num - 0f;
			float num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
			float num4 = num3 - 0f;
			bool flag = num4 < 0f;
			bool flag2 = num4 == 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
			object obj = num2 ^ 0;
			object obj2 = num2 ^ num4;
			object obj3 = obj & obj2;
			bool flag3 = (nint)obj3 < 0;
			bool flag4 = flag == flag3;
			object obj4 = !flag2;
			return (byte)((flag4 & obj4) ? 1 : 0) != 0;
		}
	}

	private const int MaxChannels = default(int);

	private const float FadeMs = default(float);

	private const float NoShift = default(float);

	public float pitch;

	public float windowMs;

	public float glideMs = 80f;

	private UnitySourceGeneratedAssemblyMonoScriptTypes_v1.Line line;

	private bool resetPending;

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0033: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC80]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC88]");
		object obj2 = 0;
		Build();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		resetPending = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		AudioSettings.AudioConfigurationChangeHandler audioConfigurationChangeHandler = default;
		audioConfigurationChangeHandler._002Ector(this, (IntPtr)obj2);
		AudioSettings.OnAudioConfigurationChanged += audioConfigurationChangeHandler;
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003e: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC80]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC88]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		AudioSettings.AudioConfigurationChangeHandler audioConfigurationChangeHandler = default;
		audioConfigurationChangeHandler._002Ector(this, (IntPtr)obj2);
		AudioSettings.OnAudioConfigurationChanged -= audioConfigurationChangeHandler;
	}

	private void AudioConfigChanged(bool deviceWasChanged)
	{
		Build();
	}

	private void OnValidate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I4
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			if (line != null)
			{
				Build();
			}
		}
	}

	private void Build()
	{
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_0256: Expected Obj, but got I4
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_00a6: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_00e7: Invalid comparison between F4 and I4
		//IL_02be: Expected Obj, but got F4
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0107: Expected F4, but got I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0059: Invalid comparison between I and F4
		//IL_0082: Invalid comparison between I and F4
		int outputSampleRate = AudioSettings.outputSampleRate;
		bool flag = outputSampleRate < 0;
		bool flag2 = outputSampleRate == 0;
		int num = outputSampleRate ^ outputSampleRate;
		int num2 = outputSampleRate & num;
		bool flag3 = num2 < 0;
		object obj = this + 48;
		object obj2 = obj;
		bool flag4 = flag == flag3;
		object obj3 = !flag2;
		object obj4 = flag4 & obj3;
		object obj5 = ~obj4;
		int num3 = ((obj5 != null) ? 48000 : outputSampleRate);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X21_v1+10]");
			if ((nint)0 == num3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X21_v1+14]");
				if (0f == windowMs)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X21_v1+18]");
					if (0f == glideMs)
					{
						return;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC90]");
		object obj6 = 0;
		float num4 = windowMs;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		float num5 = num4 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj7 = 0;
		float num6 = num5 * (float)num3;
		float num7 = ((!(num6 < 1.1156849E+09f)) ? num6 : 1.1156849E+09f);
		float num8 = num7 + 3f;
		object obj8 = num8 | num8;
		object obj9 = obj8 | obj8;
		object obj10 = obj9 | obj9;
		object obj11 = obj10 | obj10;
		object obj12 = obj11 | obj11;
		object obj13 = obj12 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_ = 1065353216;
		object obj14 = default;
		obj14._002Ector();
		object obj15 = obj13 << 3;
		_ = windowMs;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj16 = obj14 + 32;
		object obj17 = default;
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		double num9 = 1.0 / (double)num7;
		float num10 = glideMs;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		float num11 = num10 * 0f;
		float num12 = num11 * (float)num3;
		double num13 = ((!((double)num12 < 1.0)) ? ((double)num12) : 1.0);
		double num14 = -3.0 / num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		double num15 = 1.0 - num14;
		double num16 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC14]");
		double num17 = num16 * 0.0;
		if (num17 < 1.0)
		{
			num17 = 1.0;
		}
		double num18 = 1.0 / num17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		line = (UnitySourceGeneratedAssemblyMonoScriptTypes_v1.Line)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void OnAudioFilterRead(float[] data, int channels)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got I4
		//IL_0b62: Invalid comparison between F8 and I4
		//IL_0b71: Invalid comparison between F8 and I4
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8c: Expected Obj, but got Unknown
		//IL_0b99: Expected Obj, but got F8
		//IL_0bce: Expected Obj, but got I4
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Expected Obj, but got Unknown
		//IL_0bfb: Invalid comparison between F8 and I4
		//IL_0c0c: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_0c3d: Expected Obj, but got I4
		//IL_0c91: Expected Obj, but got I4
		//IL_017c: Expected F4, but got I
		//IL_0196: Expected Obj, but got I4
		//IL_0ce8: Invalid comparison between F4 and I4
		//IL_0cf9: Expected Obj, but got I4
		//IL_0d07: Invalid comparison between F4 and I4
		//IL_0d2e: Expected Obj, but got I8
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d44: Expected Obj, but got Unknown
		//IL_01ec: Expected Obj, but got I4
		//IL_0d64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d69: Expected Obj, but got Unknown
		//IL_08b2: Expected Obj, but got I4
		//IL_08bb: Expected Obj, but got I4
		//IL_0a29: Expected Obj, but got I4
		//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a61: Expected I4, but got Unknown
		//IL_0a96: Expected Obj, but got I4
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa3: Expected Obj, but got Unknown
		//IL_025e: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got I4
		//IL_0f90: Expected Obj, but got I4
		//IL_0f60: Invalid comparison between F8 and I
		//IL_08db: Expected Obj, but got I4
		//IL_0d91: Expected Obj, but got I4
		//IL_02c0: Invalid comparison between F8 and I4
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Expected Obj, but got Unknown
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0923: Expected Obj, but got Unknown
		//IL_092c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0931: Expected Obj, but got Unknown
		//IL_0dff: Expected Obj, but got I4
		//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0c: Expected Obj, but got Unknown
		//IL_0309: Expected Obj, but got I4
		//IL_0974: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected Obj, but got Unknown
		//IL_0987: Expected Obj, but got I4
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Expected I4, but got Unknown
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a6: Expected Obj, but got Unknown
		//IL_0e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e31: Expected Obj, but got Unknown
		//IL_037b: Invalid comparison between F8 and I
		//IL_0327: Expected Obj, but got I4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected I4, but got Unknown
		//IL_039f: Invalid comparison between F8 and I
		//IL_03d8: Invalid comparison between F8 and I4
		//IL_0feb: Expected Obj, but got I
		//IL_1008: Invalid comparison between F8 and I4
		//IL_1020: Expected Obj, but got F8
		//IL_102d: Expected Obj, but got F8
		//IL_106a: Expected Obj, but got I4
		//IL_046f: Invalid comparison between F8 and I4
		//IL_0480: Expected Obj, but got I4
		//IL_03f8: Expected F8, but got I4
		//IL_0ecb: Expected Obj, but got I4
		//IL_1131: Unknown result type (might be due to invalid IL or missing references)
		//IL_1136: Expected I4, but got Unknown
		//IL_1153: Unknown result type (might be due to invalid IL or missing references)
		//IL_1158: Expected I4, but got Unknown
		//IL_1165: Unknown result type (might be due to invalid IL or missing references)
		//IL_116a: Expected I4, but got Unknown
		//IL_1177: Unknown result type (might be due to invalid IL or missing references)
		//IL_117c: Expected I4, but got Unknown
		//IL_1189: Unknown result type (might be due to invalid IL or missing references)
		//IL_118e: Expected Obj, but got Unknown
		//IL_11d9: Expected Obj, but got I4
		//IL_0ef2: Expected Obj, but got I4
		//IL_0502: Expected Obj, but got I4
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected Obj, but got Unknown
		//IL_052f: Expected Obj, but got I4
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected Obj, but got Unknown
		//IL_057f: Expected Obj, but got I4
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected Obj, but got Unknown
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected Obj, but got Unknown
		//IL_05c8: Expected Obj, but got I4
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected I4, but got Unknown
		//IL_05fe: Expected Obj, but got I4
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected I, but got Unknown
		//IL_0634: Expected Obj, but got I4
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected Obj, but got Unknown
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Expected Obj, but got Unknown
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Expected Obj, but got Unknown
		//IL_06e1: Expected Obj, but got I
		//IL_078f: Expected Obj, but got F8
		//IL_07bd: Expected Obj, but got I4
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected I4, but got Unknown
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected Obj, but got Unknown
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ea: Expected Obj, but got Unknown
		UnitySourceGeneratedAssemblyMonoScriptTypes_v1.Line line = this.line;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		if (channels < 1 || this.line == null)
		{
			return;
		}
		object obj = pitch & 0x7FFFFFFF;
		bool flag = (nint)obj < 2139095040;
		object obj2 = !flag;
		object obj3 = obj - 2139095040;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		object obj6 = ~obj5;
		double num = ((obj6 != null) ? ((double)pitch) : 1.0);
		bool flag3 = num < 0.5;
		double num2 = 0.5;
		if (!flag3)
		{
			bool flag4 = !(num > 2.0);
			num2 = num;
			if (!flag4)
			{
				num2 = 2.0;
			}
		}
		double num3 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE84]");
		double num4 = num3 - 0.0;
		bool flag5 = num4 < 0.0;
		bool flag6 = num4 == 0.0;
		double num5 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE84]");
		object obj7 = num5 ^ 0;
		object obj8 = num2 ^ num4;
		object obj9 = obj7 & obj8;
		bool flag7 = (nint)obj9 < 0;
		bool flag8 = flag5 == flag7;
		object obj10 = !flag6;
		object obj11 = flag8 & obj10;
		double num6 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF60]");
		double num7 = num6 - 0.0;
		bool flag9 = num7 < 0.0;
		object obj12 = !flag9;
		object obj13 = ~obj12;
		object obj14 = ((obj13 != null) ? ((object)1) : obj11);
		bool flag10 = obj14 == null;
		object obj15 = !flag10;
		object obj16 = ~obj15;
		double num8 = ((obj16 != null) ? 1.0 : num2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
		int size;
		if (~(resetPending ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
			resetPending = false;
			size = line.size;
			line.warmup = line.size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B3F8]");
			line.glide = 0f;
			bool flag11 = data == null;
			object obj17 = !flag11;
			if (obj17 == null)
			{
				goto IL_0adb;
			}
		}
		else
		{
			size = line.size;
		}
		bool flag12 = channels < 8;
		object obj18 = !flag12;
		object obj19 = ~obj18;
		object obj20 = ~obj19;
		int num9 = ((obj20 != null) ? 8 : channels);
		double num10 = line.mix;
		float[] buf = line.buf;
		int num11 = data.Length / channels;
		bool flag13 = line.mix < 0f;
		object obj21 = !flag13;
		bool flag14 = line.mix == 0f;
		int num12 = line.write;
		object obj22 = data.Length & 0xFFFFFFFFL;
		object obj23 = ~obj21;
		object obj24 = obj23 | flag14;
		object obj25 = ~obj24;
		object obj26 = ((obj25 != null) ? ((object)1) : obj14);
		object obj27 = obj26 & 1;
		double num13;
		double num14;
		int num15;
		if (obj27 != null)
		{
			num13 = line.phase;
			num14 = line.glide;
			num15 = line.warmup;
			if (num11 < 1)
			{
				goto IL_083e;
			}
			int num16 = num12;
			int num17 = channels;
			float[] array = data;
			double num18 = num10;
			object obj28 = 0;
			double num19 = 1.0;
			int num20 = line.warmup;
			double num21 = line.glide;
			double num22 = line.phase;
			object obj29 = 0;
			while (true)
			{
				double num23 = num8 - num21;
				double num24 = (double)line.glideK * num23;
				double num25 = num21 + num24;
				double num26 = num8 - num25;
				double num27 = num25 - num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				bool flag15;
				if (num26 < 0.0)
				{
					double num28 = num27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					double num29 = num28 - 0.0;
					flag15 = num29 < 0.0;
				}
				else
				{
					flag15 = false;
				}
				object obj30 = !flag15;
				num14 = ((obj30 != null) ? num25 : num8);
				bool flag16 = num20 < 0;
				bool flag17 = num20 == 0;
				int num30 = num20 ^ num20;
				int num31 = num20 & num30;
				bool flag18 = num31 < 0;
				bool flag19 = flag16 == flag18;
				object obj31 = !flag19;
				object obj32 = obj31 | flag17;
				object obj33 = ~obj32;
				object obj34 = ((obj33 != null) ? ((object)1) : obj14);
				object obj35 = obj34 & 1;
				if (obj35 != null)
				{
					bool flag20 = flag16 == flag18;
					object obj36 = !flag17;
					object obj37 = flag20 & obj36;
					num15 = num20 - obj37;
					if (num20 > 0)
					{
						goto IL_03bb;
					}
					num20 = num15;
				}
				else
				{
					double num32 = num14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE84]");
					if (!(num32 > 0.0))
					{
						double num33 = num14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF60]");
						bool flag21 = num33 < 0.0;
						num15 = num20;
						if (!flag21)
						{
							goto IL_03bb;
						}
					}
				}
				num10 = (double)line.fadeStep + num18;
				bool flag22 = !(num10 > 1.0);
				num15 = num20;
				if (!flag22)
				{
					num10 = 1.0;
					num15 = num20;
				}
				goto IL_0e4e;
				IL_03bb:
				num10 = num18 - (double)line.fadeStep;
				if (num10 < 0.0)
				{
					num10 = 0.0;
				}
				goto IL_0e4e;
				IL_07af:
				object obj38 = num16 + 1;
				num12 = obj38 & line.mask;
				obj29++;
				obj28 += channels;
				bool flag23 = (nint)obj29 != num11;
				num16 = num12;
				num18 = num10;
				num19 = 1.0;
				num20 = num15;
				num21 = num14;
				num22 = num13;
				if (flag23)
				{
					continue;
				}
				goto IL_083e;
				IL_0e4e:
				double num34 = 1.0 - num14;
				double num35 = line.invWindow * num34;
				double num36 = num22 + num35;
				if (num36 < num19)
				{
					double num37 = num36 + num19;
					bool flag24 = num36 < 0.0;
					object obj39 = !flag24;
					object obj40 = ~obj39;
					num13 = ((obj40 != null) ? num37 : num36);
				}
				else
				{
					num13 = num36 + -1.0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj41 = 0;
				double num38 = num13 - 0.5;
				bool flag25 = num38 < 0.0;
				object obj42 = num13 ^ 0.5;
				object obj43 = num13 ^ num38;
				object obj44 = obj42 & obj43;
				bool flag26 = (nint)obj44 < 0;
				object obj45 = obj41;
				bool flag27 = flag25 == flag26;
				object obj46 = !flag27;
				object obj47 = ~obj46;
				double num39 = ((obj47 != null) ? (-0.5) : 0.5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ X0_v12+E4]");
				bool flag28 = (nint)0 == 0;
				object obj48 = !flag28;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj22 = data.Length;
				}
				double num40 = num13 + num39;
				object obj49 = obj28 << 32;
				double num41 = num13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C798]");
				double num42 = num41 * 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D160");
				double num43 = num13 * (double)line.window;
				double num44 = num40 * (double)line.window;
				double num45 = num42 * num42;
				double num46 = (double)num16 - num43;
				double num47 = (double)num16 - num44;
				double num48 = num46 - 1.0;
				int num49 = num46 & line.mask;
				double num50 = num47 - 1.0;
				int num51 = num48 & line.mask;
				int num52 = num47 & line.mask;
				int num53 = num50 & line.mask;
				object obj50 = obj22 & 0xFFFFFFFFL;
				double num54 = num43 - num43;
				double num55 = 1.0 - num45;
				double num56 = num44 - num44;
				object obj51 = obj28;
				int num57 = num9;
				object obj52 = 0;
				while (true)
				{
					bool flag29 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj51) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj50);
					object obj53 = !flag29;
					if (obj53 != null)
					{
						break;
					}
					object obj54 = num16 + obj52;
					bool flag30 = (nint)obj54 < buf.Length;
					object obj55 = !flag30;
					if (obj55 != null)
					{
						break;
					}
					object obj56 = (object)data + obj49;
					object obj57 = (object)buf + obj54;
					object obj58 = num49 + obj52;
					bool flag31 = (nint)obj58 < buf.Length;
					object obj59 = !flag31;
					object obj60 = obj56 + 32;
					if (obj59 != null)
					{
						break;
					}
					object obj61 = num51 + obj52;
					bool flag32 = (nint)obj61 < buf.Length;
					object obj62 = !flag32;
					if (obj62 != null)
					{
						break;
					}
					num17 = num52 + obj52;
					bool flag33 = num17 < buf.Length;
					object obj63 = !flag33;
					if (obj63 != null)
					{
						break;
					}
					nint num58 = (nint)(num53 + obj52);
					bool flag34 = num58 < buf.Length;
					object obj64 = !flag34;
					if (obj64 != null)
					{
						break;
					}
					object obj65 = (object)buf + obj58;
					object obj66 = (object)buf + obj61;
					array = (float[])(buf + 32);
					num57--;
					obj52 += size;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X1_v4 (System.Single[])+v806 @ X3_v4 (Il2CppMethodInfo)*4]");
					float num59 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X1_v4 (System.Single[])+v807 @ X2_v4 (System.Int32)*4]");
					float num60 = num59 - 0f;
					obj49 += 4294967296L;
					obj51++;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X0_v17+20]");
					nint num61 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X17_v11+20]");
					object obj67 = num61 - 0;
					double num62 = num56 * (double)num60;
					double num63 = num54 * (double)obj67;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X1_v4 (System.Single[])+v807 @ X2_v4 (System.Int32)*4]");
					float num64 = 0f + (float)num62;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X17_v11+20]");
					double num65 = 0.0 + num63;
					double num66 = num55 * (double)num64;
					double num67 = num45 * num65;
					double num68 = num67 + num66;
					double num69 = num68 - (double)obj60;
					double num70 = num10 * num69;
					double num71 = (double)obj60 + num70;
					obj60 = num71;
					if (num57 != 1)
					{
						continue;
					}
					goto IL_07af;
				}
				break;
			}
		}
		else
		{
			if (num11 < 1)
			{
				goto IL_09cd;
			}
			int num72 = num12;
			object obj68 = 0;
			object obj69 = 0;
			while (true)
			{
				object obj70 = obj68 << 32;
				int num73 = num9;
				object obj71 = obj68;
				int num74 = num72;
				while (true)
				{
					bool flag35 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj71) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22);
					object obj72 = !flag35;
					if (obj72 != null)
					{
						break;
					}
					bool flag36 = num74 < buf.Length;
					object obj73 = !flag36;
					if (obj73 != null)
					{
						break;
					}
					object obj74 = (object)data + obj70;
					object obj75 = buf + num74;
					num73--;
					obj70 += 4294967296L;
					obj71++;
					num74 += size;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X16_v7+20]");
					_ = 0;
					if (num73 != 1)
					{
						continue;
					}
					goto IL_096b;
				}
				break;
				IL_096b:
				obj69++;
				object obj76 = num72 + 1;
				num12 = obj76 & line.mask;
				obj68 += channels;
				bool flag37 = (nint)obj69 != num11;
				num72 = num12;
				if (flag37)
				{
					continue;
				}
				goto IL_09cd;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0adb;
		IL_083e:
		line.phase = num13;
		line.glide = (float)num14;
		line.mix = (float)num10;
		line.write = num12;
		line.warmup = num15;
		return;
		IL_0adb:
		throw new NullReferenceException();
		IL_09cd:
		line.write = num12;
		line.glide = 1f;
		if (line.warmup >= 1)
		{
			int num75 = line.warmup - num11;
			object obj77 = num75 - num11;
			bool flag38 = (nint)obj77 < 0;
			bool flag39 = obj77 == null;
			int num76 = num75 ^ num11;
			int num77 = num75 ^ obj77;
			int num78 = num76 & num77;
			bool flag40 = num78 < 0;
			bool flag41 = flag38 == flag40;
			object obj78 = !flag39;
			object obj79 = flag41 & obj78;
			object obj80 = ~obj79;
			if (obj80 != null)
			{
				num75 = 0;
			}
			line.warmup = num75;
		}
	}

	public VoicePitch()
	{
		//IL_001d: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C0A8]");
		pitch = 0f;
		base._002Ector();
	}
}
