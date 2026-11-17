using System;
using Cpp2ILInjected;
using GorillaLocomotion;
using UnityEngine;
using UnityEngine.XR;

public class HandFeedback : MonoBehaviour
{
	public AudioClip footstep;

	public float volume;

	public float pitchMin;

	public float pitchMax;

	public float hardHitSpeed;

	public float minInterval;

	public float minAirTime;

	public float minSpeed;

	public float hapticMin;

	public float hapticMax;

	public float hapticSeconds;

	private Player gt;

	private AudioSource[] sources;

	private int next;

	private bool wasL;

	private bool wasR;

	private Vector3 lastL;

	private Vector3 lastR;

	private float coolL;

	private float coolR;

	private float offL;

	private float offR;

	private float speedL;

	private float speedR;

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0081: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		//IL_04e2: Expected Obj, but got I4
		//IL_03f8: Expected Obj, but got I
		//IL_0410: Expected VT, but got F8
		//IL_0479: Expected VT, but got F8
		//IL_01d4: Expected Obj, but got I4
		//IL_022d: Expected F4, but got I
		//IL_027f: Expected Obj, but got I4
		//IL_02c0: Expected Obj, but got I4
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected Obj, but got Unknown
		//IL_0332: Expected Obj, but got I4
		//IL_0348: Expected Obj, but got I4
		//IL_0370: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CE0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4348]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj3 = this + 80;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj5 = this + 88;
		string text = default;
		obj5 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj5;
		bool flag = obj5 == null;
		int num = 0;
		if (flag)
		{
			goto IL_038f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA7C0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4350]");
		object obj9 = 0;
		double num3 = default;
		double num2 = num3;
		object obj11 = default;
		object obj10 = obj11;
		int num4 = 0;
		num = 0;
		GameObject gameObject = default;
		AudioSource audioSource = default;
		while (true)
		{
			int num5 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v8+18]");
			bool flag2 = (nint)num5 < (nint)0;
			object obj12 = !flag2;
			int num6 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v8+18]");
			bool flag3 = (nint)num6 >= (nint)0;
			num3 = num2;
			int num7 = num4;
			if (flag3)
			{
				break;
			}
			string text2 = num.ToString();
			string text3 = (string)obj7 + text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			gameObject._002Ector(text3);
			bool flag4 = (object)gameObject == null;
			num3 = num2;
			bool flag5 = false;
			num7 = num4;
			if (!flag4)
			{
				Transform transform = gameObject.transform;
				Transform parent = base.transform;
				bool flag6 = (object)transform == null;
				num3 = num2;
				flag5 = false;
				num7 = num4;
				if (!flag6)
				{
					transform.SetParent(parent, worldPositionStays: false);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
					bool flag7 = (object)audioSource == null;
					num3 = num2;
					obj11 = 0;
					flag5 = false;
					num7 = num4;
					if (!flag7)
					{
						audioSource.playOnAwake = false;
						audioSource.spatialBlend = 1f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
						audioSource.minDistance = 0f;
						audioSource.maxDistance = 15f;
						audioSource.rolloffMode = (AudioRolloffMode)1;
						object obj13 = obj5;
						bool flag8 = obj5 == null;
						num3 = 15.0;
						obj11 = 0;
						flag5 = false;
						num7 = num4;
						if (!flag8)
						{
							int num8 = num;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v12+18]");
							bool flag9 = (nint)num8 < (nint)0;
							obj12 = !flag9;
							if (obj12 != null)
							{
								throw new IndexOutOfRangeException();
							}
							object obj14 = obj5 + num;
							object obj15 = obj14 + 32;
							obj15 = audioSource;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							obj6 = obj5;
							num7 = num + 1;
							bool flag10 = obj5 == null;
							object obj16 = !flag10;
							num3 = 15.0;
							obj11 = 0;
							flag5 = false;
							num = num7;
							num2 = 15.0;
							obj10 = 0;
							num4 = num7;
							num = num7;
							if (obj16 != null)
							{
								continue;
							}
						}
					}
				}
			}
			goto IL_038f;
		}
		goto IL_039d;
		IL_038f:
		NullReferenceException ex = new NullReferenceException();
		goto IL_039d;
		IL_039d:
		object obj17 = obj3;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v5+30]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v5+30]");
				Vector3 position = ((Transform)0).position;
				Player player = gt;
				lastL = (Vector3)num3;
				if ((object)gt != null && (object)player.rightHandFollower != null)
				{
					Vector3 position2 = player.rightHandFollower.position;
					lastR = (Vector3)num3;
					return;
				}
			}
		}
		goto IL_038f;
	}

	private unsafe void LateUpdate()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Ref, but got Unknown
		//IL_002e: Expected Obj, but got I
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Ref, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Ref, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Ref, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Ref, but got Unknown
		//IL_00be: Expected Obj, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Ref, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Ref, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Ref, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Ref, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Ref, but got Unknown
		float deltaTime = Time.deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		ref float reference = ref *(float*)(this + 128);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X5_v2 (System.Single&)-30]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj3 = default;
		object obj2 = reference - obj3;
		reference = ref *(float*)obj2;
		ref bool was = ref *(bool*)(this + 100);
		ref Vector3 last = ref *(Vector3*)(this + 104);
		ref float off = ref *(float*)(this + 136);
		ref float lastSpeed = ref *(float*)(this + 144);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X8_v2+30]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X8_v2+F8]");
		Step((Transform)num, touching: false, ref was, ref last, ref reference, ref off, ref lastSpeed, (XRNode)4, deltaTime);
		Player player = gt;
		Step(player.rightHandFollower, player.wasRightHandTouching, ref *(bool*)(this + 101), ref *(Vector3*)(this + 116), ref *(float*)(this + 132), ref *(float*)(this + 140), ref *(float*)(this + 148), (XRNode)5, deltaTime);
	}

	private unsafe void Step(Transform hand, bool touching, ref bool was, ref Vector3 last, ref float cool, ref float off, ref float lastSpeed, XRNode node, float dt)
	{
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected Obj, but got Unknown
		//IL_047f: Expected Obj, but got I
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected Obj, but got Unknown
		//IL_04be: Expected Obj, but got I4
		//IL_0073: Expected Ref, but got F4
		//IL_00c2: Invalid comparison between F4 and I4
		//IL_00d1: Invalid comparison between F4 and I4
		//IL_00e9: Expected Obj, but got F4
		//IL_00f6: Expected Obj, but got F4
		//IL_011a: Expected Ref, but got F4
		//IL_0133: Expected Obj, but got I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_04f1: Expected Ref, but got F4
		//IL_0183: Expected Obj, but got I4
		//IL_018c: Expected F4, but got I4
		//IL_01a8: Invalid comparison between F4 and I4
		//IL_01b9: Expected Obj, but got I4
		//IL_01c7: Invalid comparison between F4 and I4
		//IL_01d8: Expected Obj, but got I4
		//IL_01ee: Expected F4, but got I4
		//IL_021a: Expected F4, but got I4
		//IL_0241: Expected F4, but got I4
		//IL_0269: Invalid comparison between F4 and I4
		//IL_0280: Expected F8, but got I4
		//IL_02f6: Expected Obj, but got I
		//IL_0320: Expected Obj, but got I4
		//IL_0361: Invalid comparison between F8 and I4
		//IL_051b: Expected Obj, but got I4
		//IL_051b: Expected VT, but got Obj
		//IL_041f: Expected Ref, but got F4
		//IL_0428: Expected F4, but got I4
		//IL_03ba: Invalid comparison between F8 and I4
		//IL_03c9: Expected F8, but got I4
		Vector3 position = hand.position;
		float num = dt - (float)last;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [last @ X4 (UnityEngine.Vector3&)+4]");
		object obj2 = default;
		object obj = obj2 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [last @ X4 (UnityEngine.Vector3&)+8]");
		object obj5 = default;
		object obj4 = obj5 - 0;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num2 = num * num;
		object obj8 = obj * obj;
		object obj9 = obj4 * obj4;
		float num3 = num2 + (float)obj8;
		float num4 = lastSpeed;
		ref Vector3 reference = ref *(Vector3*)dt;
		float num5 = num3 + (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num6 = num5 / dt;
		float num7 = num6 - lastSpeed;
		bool flag2 = num7 < 0f;
		bool flag3 = num7 == 0f;
		object obj10 = num6 ^ lastSpeed;
		object obj11 = num6 ^ num7;
		object obj12 = obj10 & obj11;
		bool flag4 = (nint)obj12 < 0;
		ref float reference2 = ref *(float*)num6;
		bool flag5 = flag2 == flag4;
		object obj13 = !flag3;
		object obj14 = flag5 & obj13;
		object obj15 = ~obj14;
		if (obj15 == null)
		{
			num4 = num6;
		}
		float num8;
		if (touching)
		{
			bool flag6 = !was;
			object obj16 = !flag6;
			num8 = 0f;
			if (obj16 == null)
			{
				bool flag7 = cool < 0f;
				object obj17 = !flag7;
				bool flag8 = cool == 0f;
				object obj18 = !flag8;
				object obj19 = obj17 & obj18;
				num8 = 0f;
				if (obj19 == null)
				{
					bool flag9 = off < minAirTime;
					num8 = 0f;
					if (!flag9)
					{
						bool flag10 = num4 < minSpeed;
						num8 = 0f;
						if (!flag10)
						{
							float num9 = num4 / hardHitSpeed;
							bool flag11 = num9 < 0f;
							double num10 = num4;
							double num11 = 0.0;
							if (!flag11)
							{
								bool flag12 = !((double)num9 > 1.0);
								num10 = 1.0;
								num11 = num9;
								if (!flag12)
								{
									num10 = 1.0;
									num11 = 1.0;
								}
							}
							Player player = gt;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4368]");
							object obj20 = 0;
							object obj21 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v10+E4]");
							bool flag13 = (nint)0 == 0;
							object obj22 = !flag13;
							if (obj22 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Collider collider = Surfaces.Under((Vector3)player.locomotionEnabledLayers, dt, 0);
							bool isValid = default;
							InputDevice inputDevice = default;
							if (num11 < 0.0 || !(num11 > 1.0))
							{
								Play((Vector3)collider, (Collider)touching, dt);
								InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
								isValid = inputDevice.isValid;
							}
							if (isValid)
							{
								bool flag14 = num11 < 0.0;
								double num12 = 0.0;
								if (!flag14)
								{
									bool flag15 = !(num11 > 1.0);
									num12 = num11;
									if (!flag15)
									{
										num12 = 1.0;
									}
								}
								float num13 = hapticMax - hapticMin;
								double num14 = (double)num13 * num12;
								float amplitude = hapticMin + (float)num14;
								bool flag16 = inputDevice.SendHapticImpulse(0u, amplitude, hapticSeconds);
							}
							ref float reference3 = ref *(float*)minInterval;
							num8 = 0f;
						}
					}
				}
			}
		}
		else
		{
			num8 = off + dt;
		}
		ref float reference4 = ref *(float*)num8;
		ref bool reference5 = ref *(touching ? ((bool*)1) : ((bool*)null));
	}

	private void Play(Vector3 at, Collider surface, float loud)
	{
		//IL_0022: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_007c: Expected I4, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_00fb: Expected VT, but got I4
		//IL_0125: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got VT
		//IL_0178: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I
		//IL_0284: Expected Obj, but got I
		AudioSource[] array = sources;
		if (sources != null)
		{
			bool flag = next < array.Length;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_0293;
			}
			object obj2 = next + 1;
			object obj3 = sources + next;
			object obj4 = obj2 / array.Length;
			object obj5 = obj4 * array.Length;
			int num = obj2 - obj5;
			next = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v6+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v6+20]");
				Transform transform = ((Component)0).transform;
				if ((object)transform != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4368]");
					object obj6 = 0;
					transform.position = (Vector3)0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v8+E4]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj9 = default;
					float loud2 = volume * (float)obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v6+20]");
					bool flag3 = Surfaces.Play((AudioSource)0, (Collider)at, loud2, pitchMin, pitchMax);
					bool flag4 = !flag3;
					object obj10 = !flag4;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj11 = 0;
						object obj12 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v13+E4]");
						bool flag5 = (nint)0 == 0;
						object obj13 = !flag5;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (!(footstep == null))
						{
							float pitch = UnityEngine.Random.Range(pitchMin, pitchMax);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v6+20]");
							((AudioSource)0).pitch = pitch;
							float volumeScale = volume * (float)obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v6+20]");
							((AudioSource)0).PlayOneShot(footstep, volumeScale);
						}
					}
					return;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0293;
		IL_0293:
		throw new IndexOutOfRangeException();
	}

	public HandFeedback()
	{
		//IL_0012: Expected F4, but got I
		//IL_0024: Expected F4, but got I
		//IL_0036: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107DE80]");
		volume = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E1B0]");
		minInterval = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C770]");
		hapticMax = 0f;
		base._002Ector();
	}
}
