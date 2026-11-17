using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering.Universal;
using UnityEngine.XR;

public class GillaFreecam : MonoBehaviour
{
	public struct Print
	{
		public Rect paper;

		public Rect art;
	}

	private struct Pressable
	{
		public Component thing;

		public float radius;

		public Action press;

		public string label;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<RaycastHit> _003C_003E9__37_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0998]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj2 = default;
			obj2._002Ector();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
			object obj4 = 0;
			obj4 = obj2;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		internal int _003CPick_003Eb__37_0(RaycastHit a, RaycastHit b)
		{
			float num = default;
			return num.CompareTo(b.m_Distance);
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public GillaGlass glass;

		public Rigidbody body;
	}

	private sealed class _003C_003Ec__DisplayClass36_1
	{
		public Vector3 at;

		public Vector3 push;

		public _003C_003Ec__DisplayClass36_0 CS_0024_003C_003E8__locals1;

		internal void _003CResolve_003Eb__0()
		{
			//IL_0025: Expected VT, but got I
			_003C_003Ec__DisplayClass36_0 obj = CS_0024_003C_003E8__locals1;
			IntPtr intPtr = default;
			Vector3 vector = default;
			obj.glass.Click((Vector3)(nint)intPtr, vector);
		}
	}

	private static bool On__BackingField;

	public static bool GIsTaken;

	private const int PlayerRig = default(int);

	private const int FirstPerson = default(int);

	private const int Sees = default(int);

	private const float LookSpeed = default(float);

	private const float Shove = default(float);

	private Camera cam;

	private Camera player;

	private AudioListener ear;

	private AudioListener playerEar;

	private float yaw;

	private float pitch;

	private float speed;

	private float hintUntil;

	private float nextLook;

	private float nextNet;

	private float pressablesAt;

	private string under;

	private string net;

	private readonly List<Pressable> pressables;

	private GUIStyle style;

	public static bool On
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0032: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
			object obj3 = 0;
			return (byte)(int)obj3 != 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+A0]");
			object obj3 = 0;
			obj3 = value;
		}
	}

	public Camera View => cam;

	private void Start()
	{
		float unscaledTime = Time.unscaledTime;
		float num = unscaledTime + 8f;
		hintUntil = num;
	}

	private void OnDestroy()
	{
		//IL_001d: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v5+A0]");
		object obj3 = 0;
		if (obj3 != null)
		{
			Leave();
		}
	}

	private unsafe void Update()
	{
		//IL_0ce8: Expected Obj, but got I
		//IL_0d00: Expected Obj, but got I
		//IL_001f: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I
		//IL_0aec: Expected Obj, but got I
		//IL_0ab7: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I4
		//IL_02de: Expected VT, but got I4
		//IL_01aa: Expected Obj, but got I
		//IL_0d35: Expected Obj, but got I
		//IL_0d4d: Expected Obj, but got I
		//IL_0d55: Expected F8, but got Obj
		//IL_0d65: Expected F8, but got I
		//IL_0d75: Expected F8, but got I
		//IL_0317: Expected Obj, but got I
		//IL_0326: Invalid comparison between F4 and I4
		//IL_0337: Invalid comparison between F4 and I4
		//IL_034e: Expected Obj, but got F4
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got Unknown
		//IL_01dd: Expected Obj, but got I
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_023a: Invalid comparison between F4 and I8
		//IL_0257: Expected F4, but got I8
		//IL_0473: Expected Obj, but got I4
		//IL_039d: Expected Obj, but got I4
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Obj, but got Unknown
		//IL_026e: Invalid comparison between F4 and I4
		//IL_0ba6: Expected Obj, but got I4
		//IL_03e3: Expected F8, but got I
		//IL_0296: Expected F4, but got I4
		//IL_04f1: Expected Obj, but got I4
		//IL_03f1: Invalid comparison between F8 and I4
		//IL_0c0a: Expected Obj, but got I4
		//IL_0419: Expected F8, but got I4
		//IL_0549: Expected Obj, but got I4
		//IL_05e0: Expected Obj, but got I4
		//IL_0677: Expected Obj, but got I4
		//IL_0710: Expected VT, but got I4
		//IL_0710: Expected VT, but got I4
		//IL_0736: Expected Obj, but got I
		//IL_0dfa: Expected VT, but got I4
		//IL_07de: Expected Obj, but got I
		//IL_0808: Expected Obj, but got I4
		//IL_086e: Expected Obj, but got I
		//IL_0887: Expected VT, but got I4
		//IL_08a1: Expected Obj, but got I
		//IL_0916: Expected F8, but got I4
		//IL_0a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a82: Expected Obj, but got Unknown
		//IL_08d3: Expected Obj, but got I
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Expected Ref, but got Unknown
		//IL_096c: Expected VT, but got Ref
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected Ref, but got Unknown
		//IL_09a4: Expected VT, but got Ref
		//IL_09c0: Expected F8, but got I4
		//IL_097e: Expected F8, but got I4
		//IL_09e1: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D08]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v7+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDA38]");
		if ((nint)0 != 0)
		{
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 == null)
			{
				return;
			}
		}
		else
		{
			_ = 1;
			if (obj3 == null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v13+A0]");
		object obj7 = 0;
		object obj8 = obj7;
		KeyControl pKey = ((Keyboard)obj3).pKey;
		bool wasPressedThisFrame = pKey.wasPressedThisFrame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
		object obj9 = 0;
		if (wasPressedThisFrame)
		{
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X8_v69+A0]");
			object obj11 = 0;
			if (obj11 != null)
			{
				Leave();
			}
			else
			{
				Enter();
			}
		}
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v19+A0]");
		object obj13 = 0;
		if (obj13 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (cam == null)
		{
			Leave();
			return;
		}
		float num2 = default;
		if (obj7 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X22_v3+1D0]");
			if (((ButtonControl)0).isPressed)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X22_v3+190]");
				Vector2 vector = ((InputControl<Vector2>)0).ReadValue();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
				object obj18 = default;
				object obj17 = obj18 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
				object obj20 = default;
				object obj19 = obj20 * 0;
				float num = pitch - (float)obj17;
				num2 = yaw + (float)obj19;
				bool flag3 = num < 3.2664453E+09f;
				yaw = num2;
				float num3 = 3.2664453E+09f;
				if (!flag3)
				{
					bool flag4 = !(num > 1.1189617E+09f);
					num3 = num;
					if (!flag4)
					{
						num3 = 1.1189617E+09f;
					}
				}
				pitch = num3;
			}
		}
		Transform transform = cam.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Vector3 euler = default;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
		transform.rotation = (Quaternion)0;
		bool flag5 = obj7 == null;
		double num4 = yaw;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X22_v3+1B8]");
			Vector2 vector2 = ((InputControl<Vector2>)0).ReadValue();
			bool flag6 = yaw < 0f;
			bool flag7 = yaw == 0f;
			object obj21 = yaw ^ yaw;
			object obj22 = yaw & obj21;
			bool flag8 = (nint)obj22 < 0;
			num4 = yaw;
			if (!flag7)
			{
				bool flag9 = flag6 == flag8;
				object obj23 = !flag7;
				object obj24 = flag9 & obj23;
				object obj25 = ~obj24;
				double num5;
				if (obj25 == null)
				{
					num5 = 1.25;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
					num5 = 0.0;
				}
				num4 = num5 * (double)speed;
				bool flag10 = num4 < 0.25;
				double num6 = 0.25;
				if (!flag10)
				{
					bool flag11 = !(num4 > 1114636288.0);
					num6 = num4;
					if (!flag11)
					{
						num6 = 1114636288.0;
					}
				}
				speed = (float)num6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj26 = 0;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v31+A0]");
		object obj28 = 0;
		double num7 = (double)obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v32+4]");
		double num8 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v32+8]");
		double num9 = 0.0;
		KeyControl wKey = ((Keyboard)obj3).wKey;
		bool isPressed = wKey.isPressed;
		KeyControl sKey = ((Keyboard)obj3).sKey;
		bool flag12 = !isPressed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v32+8]");
		double num10 = 0.0 + 1.0;
		object obj29 = !flag12;
		object obj30 = ~obj29;
		if (obj30 == null)
		{
			num9 = num10;
		}
		bool isPressed2 = sKey.isPressed;
		bool flag13 = !isPressed2;
		double num11 = num9 + -1.0;
		object obj31 = !flag13;
		object obj32 = ~obj31;
		if (obj32 == null)
		{
			num9 = num11;
		}
		KeyControl dKey = ((Keyboard)obj3).dKey;
		bool isPressed3 = dKey.isPressed;
		KeyControl aKey = ((Keyboard)obj3).aKey;
		bool flag14 = !isPressed3;
		double num12 = num7 + 1.0;
		object obj33 = !flag14;
		object obj34 = ~obj33;
		if (obj34 == null)
		{
			num7 = num12;
		}
		bool isPressed4 = aKey.isPressed;
		bool flag15 = !isPressed4;
		double num13 = num7 + -1.0;
		object obj35 = !flag15;
		object obj36 = ~obj35;
		if (obj36 == null)
		{
			num7 = num13;
		}
		KeyControl eKey = ((Keyboard)obj3).eKey;
		bool isPressed5 = eKey.isPressed;
		bool flag16 = !isPressed5;
		object obj37 = !flag16;
		if (obj37 == null)
		{
			KeyControl spaceKey = ((Keyboard)obj3).spaceKey;
			if (!spaceKey.isPressed)
			{
				goto IL_0c33;
			}
		}
		num8++;
		num13 = 1.0;
		goto IL_0c33;
		IL_0c33:
		KeyControl qKey = ((Keyboard)obj3).qKey;
		bool isPressed6 = qKey.isPressed;
		bool flag17 = !isPressed6;
		object obj38 = !flag17;
		if (obj38 == null)
		{
			KeyControl leftCtrlKey = ((Keyboard)obj3).leftCtrlKey;
			if (!leftCtrlKey.isPressed)
			{
				goto IL_0c45;
			}
		}
		num8 += -1.0;
		num13 = -1.0;
		goto IL_0c45;
		IL_0cc6:
		KeyControl tKey = ((Keyboard)obj3).tKey;
		if (tKey.wasPressedThisFrame)
		{
			BringPlayer();
		}
		float unscaledTime = Time.unscaledTime;
		if (!(unscaledTime < nextNet))
		{
			float unscaledTime2 = Time.unscaledTime;
			float num14 = unscaledTime2 + 0.5f;
			nextNet = num14;
			string text = Network();
			object obj39 = this + 104;
			obj39 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		return;
		IL_0c45:
		KeyControl leftShiftKey = ((Keyboard)obj3).leftShiftKey;
		bool isPressed7 = leftShiftKey.isPressed;
		bool flag18 = !isPressed7;
		object obj40 = !flag18;
		double num15;
		if (obj40 == null)
		{
			KeyControl rightShiftKey = ((Keyboard)obj3).rightShiftKey;
			bool isPressed8 = rightShiftKey.isPressed;
			bool flag19 = !isPressed8;
			num15 = 1.0;
			if (flag19)
			{
				goto IL_06e0;
			}
		}
		num15 = 4.0;
		goto IL_06e0;
		IL_06e0:
		Transform transform2 = cam.transform;
		Quaternion rotation = transform2.rotation;
		Vector3 vector3 = (Quaternion)0 * (Vector3)0;
		object obj41 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X8_v35+A0]");
		object obj42 = 0;
		Transform transform3 = cam.transform;
		double num16 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v36+18]");
		double num17 = num16 * 0.0;
		double num18 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v36+1C]");
		double num19 = num18 * 0.0;
		double num20 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v36+20]");
		double num21 = num20 * 0.0;
		double num22 = num13 + num17;
		double num23 = num4 + num19;
		double num24 = (double)num2 + num21;
		Vector3 position = transform3.position;
		double num25 = num22 * num22;
		double num26 = num23 * num23;
		double num27 = num25 + num26;
		double num28 = num24 * num24;
		double num29 = num28 + num27;
		if (num29 > 1.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj43 = 0;
			object obj44 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X0_v89+E4]");
			bool flag20 = (nint)0 == 0;
			object obj45 = !flag20;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			num23 /= 1.0;
			num24 /= 1.0;
		}
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		double num30 = num15 * (double)speed;
		double num31 = num30 * (double)unscaledDeltaTime;
		double num32 = num23 * num31;
		double num33 = num24 * num31;
		double num34 = num19 + num32;
		double num35 = num21 + num33;
		transform3.position = (Vector3)0;
		bool flag21 = obj7 == null;
		ref string reference = ref *(string*)null;
		if (!flag21)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X22_v3+188]");
			Vector2 vector4 = ((InputControl<Vector2>)0).ReadValue();
			Ray ray = cam.ScreenPointToRay((Vector3)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X22_v3+1C0]");
			if (((ButtonControl)0).wasPressedThisFrame)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X22_v3+1D0]");
				if (!((ButtonControl)0).isPressed)
				{
					object obj46 = default;
					Action action = Resolve((Ray)(&obj46), out *(string*)(this + 96));
					bool flag22 = action == null;
					num35 = 0.0;
					if (!flag22)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v878.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						num35 = 0.0;
					}
					goto IL_0cc6;
				}
			}
			float unscaledTime3 = Time.unscaledTime;
			bool flag23 = unscaledTime3 < nextLook;
			num35 = 0.0;
			reference = ref *(string*)null;
			if (!flag23)
			{
				float unscaledTime4 = Time.unscaledTime;
				ref string reference2 = ref *(string*)(this + 96);
				float num36 = unscaledTime4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				float num37 = num36 + 0f;
				nextLook = num37;
				object obj47 = default;
				Action action2 = Resolve((Ray)(&obj47), out reference2);
				num35 = 0.0;
				reference = ref reference2;
			}
		}
		goto IL_0cc6;
	}

	public void Switch()
	{
		//IL_0023: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v5+A0]");
		object obj3 = 0;
		if (obj3 != null)
		{
			Leave();
		}
		else
		{
			Enter();
		}
	}

	public void LookFrom(Vector3 from, Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I
		//IL_01d3: Expected Obj, but got I
		//IL_0239: Expected VT, but got I4
		//IL_008f: Invalid comparison between F4 and I4
		//IL_009e: Invalid comparison between F4 and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00bf: Expected Obj, but got F4
		//IL_00f4: Expected Obj, but got I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_016d: Expected VT, but got I4
		//IL_016d: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = cam == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v9+A0]");
			object obj7 = 0;
			Vector3 forward = default;
			Vector3 upwards = default;
			Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
			Quaternion rotation = default;
			Vector3 vector = Quaternion.Internal_ToEulerRad(ref rotation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v10+18]");
			float num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
			float num2 = num * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v10+20]");
			float num3 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
			float num4 = num3 * 0f;
			Vector3 vector2 = Quaternion.Internal_MakePositive((Vector3)0);
			float num5 = num2 + 3.2833536E+09f;
			float num6 = num2 - 1.1274813E+09f;
			bool flag4 = num6 < 0f;
			bool flag5 = num6 == 0f;
			object obj8 = num2 ^ 0x43340000;
			object obj9 = num2 ^ num6;
			object obj10 = obj8 & obj9;
			bool flag6 = (nint)obj10 < 0;
			bool flag7 = flag4 == flag6;
			object obj11 = !flag5;
			object obj12 = flag7 & obj11;
			object obj13 = ~obj12;
			if (obj13 == null)
			{
				num2 = num5;
			}
			yaw = num4;
			pitch = num2;
			Transform transform = cam.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(ref forward);
			transform.SetPositionAndRotation((Vector3)0, (Quaternion)0);
		}
	}

	public unsafe string ClickAt(Vector2 at)
	{
		//IL_014c: Expected Obj, but got I
		//IL_0164: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00cd: Expected VT, but got I4
		//IL_00df: Expected VT, but got Ref
		//IL_00ff: Expected Obj, but got Ref
		//IL_011f: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v7+A0]");
		object obj3 = 0;
		object result;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(cam == null))
			{
				if ((object)cam != null)
				{
					Ray ray = cam.ScreenPointToRay((Vector3)0);
					object obj7 = default;
					Action action = Resolve((Ray)(&obj7), out var label);
					bool flag2 = action == null;
					result = (object)(&label);
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v107.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						result = (object)(&label);
					}
					goto IL_0137;
				}
				return (string)(object)new NullReferenceException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0978]");
		result = 0;
		goto IL_0137;
		IL_0137:
		return (string)result;
	}

	private void Enter()
	{
		//IL_0010: Expected Obj, but got I
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected Obj, but got Unknown
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected Obj, but got Unknown
		//IL_0778: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_02d8: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I
		//IL_0796: Expected Obj, but got I
		//IL_07ae: Expected Obj, but got I
		//IL_0112: Expected F4, but got I
		//IL_0345: Expected VT, but got I4
		//IL_036f: Expected Obj, but got I4
		//IL_08bd: Expected Obj, but got I
		//IL_08d5: Expected Obj, but got I
		//IL_08dd: Expected F4, but got Obj
		//IL_08ed: Expected F4, but got I
		//IL_015e: Expected VT, but got I4
		//IL_0824: Invalid comparison between F4 and I4
		//IL_0833: Invalid comparison between F4 and I4
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Expected Obj, but got Unknown
		//IL_0854: Expected Obj, but got F4
		//IL_0889: Expected Obj, but got I4
		//IL_0891: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Expected Obj, but got Unknown
		//IL_0175: Expected I4, but got I8
		//IL_092d: Expected Obj, but got I4
		//IL_0417: Expected F4, but got I4
		//IL_01aa: Expected Obj, but got I
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_01e8: Expected F8, but got I4
		//IL_01f1: Expected F4, but got I4
		//IL_01fa: Expected F4, but got I4
		//IL_0203: Expected Obj, but got I4
		//IL_04a9: Expected Obj, but got I4
		//IL_04ec: Expected Obj, but got I4
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected Obj, but got Unknown
		//IL_052c: Expected Obj, but got I4
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected I4, but got Unknown
		//IL_054f: Expected Obj, but got I
		//IL_050a: Expected Obj, but got I
		//IL_05b8: Expected Obj, but got I4
		//IL_05fb: Expected Obj, but got I4
		//IL_067e: Expected Obj, but got I4
		//IL_0589: Expected Obj, but got I
		//IL_0976: Expected Obj, but got I
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_098e: Expected Obj, but got Unknown
		//IL_0631: Expected Obj, but got I
		//IL_064f: Expected Obj, but got I4
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Expected Obj, but got Unknown
		//IL_06f6: Expected Obj, but got I
		//IL_09be: Expected Obj, but got I
		//IL_09d6: Expected Obj, but got I
		//IL_09df: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = this + 40;
		obj2 = main;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = obj;
		object obj4 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj4 == null;
		bool flag3 = !flag2;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		float num2 = default;
		float num3 = default;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0898]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			GameObject gameObject = default;
			gameObject._002Ector((string)obj9);
			Transform transform = gameObject.transform;
			Transform parent = base.transform;
			transform.SetParent(parent, worldPositionStays: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8558]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			object obj11 = default;
			obj4 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj12 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
			((Camera)obj12).nearClipPlane = 0f;
			((Camera)obj4).farClipPlane = 300f;
			((Camera)obj4).fieldOfView = 80f;
			((Camera)obj4).clearFlags = (CameraClearFlags)2;
			((Camera)obj4).backgroundColor = (Color)0;
			((Camera)obj4).cullingMask = -769;
			((Camera)obj4).stereoTargetEye = (StereoTargetEyeMask)0;
			UniversalAdditionalCameraData universalAdditionalCameraData = CameraExtensions.GetUniversalAdditionalCameraData((Camera)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0890]");
			object obj13 = 0;
			universalAdditionalCameraData.m_RenderPostProcessing = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			object obj14 = this + 48;
			UnityEngine.Object obj15 = default;
			obj14 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			double num = 0.0;
			num2 = 0f;
			num3 = 0f;
			obj6 = 0;
			obj7 = obj15;
		}
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj17 = !flag4;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = (UnityEngine.Object)obj2 != null;
		bool flag6 = !flag5;
		UnityEngine.Object obj18 = null;
		if (!flag6)
		{
			Transform transform2 = ((Component)obj2).transform;
			obj18 = transform2;
		}
		Transform transform3 = ((Component)obj4).transform;
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v7+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj18 != null)
		{
			Vector3 position = ((Transform)obj18).position;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj21 = 0;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v47+A0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v48+18]");
			num3 = 0f * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v48+20]");
			double num = 0.0 * 1.5;
			float num4 = default;
			num2 = num4;
		}
		transform3.position = (Vector3)0;
		object obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v25+E4]");
		bool flag8 = (nint)0 == 0;
		object obj25 = !flag8;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj18 != null)
		{
			Vector3 eulerAngles = ((Transform)obj18).eulerAngles;
			UnityEngine.Object obj26 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj27 = 0;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v40+A0]");
			object obj29 = 0;
			num3 = (float)obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v41+4]");
			num2 = 0f;
			UnityEngine.Object obj26 = null;
		}
		object obj30 = obj;
		float num5 = num3 + 3.2833536E+09f;
		float num6 = num3 - 1.1274813E+09f;
		bool flag9 = num6 < 0f;
		bool flag10 = num6 == 0f;
		object obj31 = num3 ^ 0x43340000;
		object obj32 = num3 ^ num6;
		object obj33 = obj31 & obj32;
		bool flag11 = (nint)obj33 < 0;
		bool flag12 = flag9 == flag11;
		object obj34 = !flag10;
		object obj35 = flag12 & obj34;
		object obj36 = ~obj35;
		if (obj36 == null)
		{
			num3 = num5;
		}
		yaw = num2;
		pitch = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v30+E4]");
		bool flag13 = (nint)0 == 0;
		object obj37 = !flag13;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = player != null;
		bool flag15 = !flag14;
		float num7 = 0f;
		if (!flag15)
		{
			num7 = ((Camera)obj2).depth;
		}
		float depth = num7 + 10f;
		cam.depth = depth;
		GameObject gameObject2 = ((Component)obj4).gameObject;
		gameObject2.SetActive(value: true);
		object obj38 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X0_v38+E4]");
		bool flag16 = (nint)0 == 0;
		object obj39 = !flag16;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17 = (UnityEngine.Object)obj2 != null;
		bool flag18 = !flag17;
		object obj40 = 0;
		if (!flag18)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0888]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			object obj42 = default;
			obj40 = obj42;
		}
		object obj43 = this + 56;
		obj43 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool isDeviceActive = XRSettings.isDeviceActive;
		object obj44 = !isDeviceActive;
		bool flag19 = (byte)(1 & obj44) != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X22_v11-8]");
		((UnityEngine.Behaviour)0).enabled = flag19;
		Component component;
		object obj45;
		if (isDeviceActive)
		{
			component = (Component)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0878]");
			obj45 = 0;
		}
		else
		{
			object obj46 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v59+E4]");
			bool flag20 = (nint)0 == 0;
			object obj47 = !flag20;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag21 = (UnityEngine.Object)obj2 != null;
			bool flag22 = !flag21;
			object obj48 = 0;
			string text = null;
			if (!flag22)
			{
				((UnityEngine.Behaviour)obj2).enabled = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0878]");
				text = (((Component)obj2).tag = (string)0);
				obj48 = 0;
			}
			object obj49 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v64+E4]");
			bool flag23 = (nint)0 == 0;
			object obj50 = !flag23;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj43 != null)
			{
				((UnityEngine.Behaviour)obj43).enabled = false;
			}
			component = (Component)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0880]");
			obj45 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj51 = 0;
		component.tag = (string)obj45;
		object obj52 = this + 96;
		obj52 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		string text3 = Network();
		object obj53 = this + 104;
		obj53 = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
		object obj54 = 0;
		object obj55 = obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v22+A0]");
		object obj56 = 0;
		obj56 = 1;
	}

	private void Leave()
	{
		//IL_0217: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_0255: Expected Obj, but got I4
		//IL_0277: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I4
		//IL_0173: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v7+A0]");
		object obj5 = 0;
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = cam != null;
		bool flag3 = !flag2;
		object obj7 = 0;
		bool flag4 = false;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0878]");
			object obj8 = 0;
			cam.tag = (string)obj8;
			GameObject gameObject = cam.gameObject;
			gameObject.SetActive(value: false);
			obj7 = 0;
			flag4 = false;
		}
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v10+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = player != null;
		bool flag7 = !flag6;
		object obj11 = 0;
		bool flag8 = false;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0880]");
			object obj12 = 0;
			player.tag = (string)obj12;
			player.enabled = true;
			obj11 = 0;
			flag8 = true;
		}
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v15+E4]");
		bool flag9 = (nint)0 == 0;
		object obj14 = !flag9;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (playerEar != null)
		{
			playerEar.enabled = true;
		}
	}

	private unsafe Action Resolve(Ray ray, out string label)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1333: Expected VT, but got Ref
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_135d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1361: Unknown result type (might be due to invalid IL or missing references)
		//IL_136c: Unknown result type (might be due to invalid IL or missing references)
		//IL_137d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1389: Expected Obj, but got Ref
		//IL_139a: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_142b: Unknown result type (might be due to invalid IL or missing references)
		//IL_142f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got I4
		//IL_0581: Expected Obj, but got I4
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected Obj, but got I4
		//IL_05ac: Expected Obj, but got I4
		//IL_14f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got I4
		//IL_1452: Expected Obj, but got I
		//IL_145a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1463: Expected Ref, but got Unknown
		//IL_147d: Expected Obj, but got I4
		//IL_147d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1481: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0154: Expected Obj, but got I4
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Invalid comparison between Unknown and I4
		//IL_05cb: Expected Obj, but got I4
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected Obj, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Invalid comparison between Unknown and I4
		//IL_0660: Expected Obj, but got I4
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_129e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected Obj, but got I4
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected Obj, but got Unknown
		//IL_11d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1209: Expected Obj, but got I4
		//IL_120e: Unknown result type (might be due to invalid IL or missing references)
		//IL_121a: Unknown result type (might be due to invalid IL or missing references)
		//IL_121e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1233: Expected Obj, but got I4
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Invalid comparison between Unknown and I4
		//IL_12f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1309: Expected Obj, but got I4
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_036c: Expected Obj, but got I4
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_0cb7: Expected Obj, but got I
		//IL_06b8: Expected Obj, but got I
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected Obj, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Invalid comparison between Obj and Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected Obj, but got I
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fc: Expected Obj, but got I4
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected I4, but got Unknown
		//IL_07e1: Expected Obj, but got I4
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected Obj, but got Unknown
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Invalid comparison between Unknown and Obj
		//IL_04a1: Expected Obj, but got I4
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got Unknown
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected Obj, but got Unknown
		//IL_0c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4d: Expected Obj, but got Unknown
		//IL_0c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c66: Expected Obj, but got I4
		//IL_0c6f: Expected Obj, but got I4
		//IL_0c74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c99: Expected Obj, but got I4
		//IL_0ca2: Expected Obj, but got I4
		//IL_080d: Expected Obj, but got I4
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1415: Expected Obj, but got I4
		//IL_1415: Unknown result type (might be due to invalid IL or missing references)
		//IL_1419: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got Unknown
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Expected Obj, but got I
		//IL_090f: Expected Obj, but got I4
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0936: Expected Obj, but got I4
		//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce4: Expected I4, but got Unknown
		//IL_0cf1: Expected I4, but got Obj
		//IL_0eae: Expected Obj, but got I
		//IL_0d2a: Expected Obj, but got I4
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecf: Expected I4, but got Obj
		//IL_0edc: Expected I4, but got Obj
		//IL_0edc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d56: Expected Obj, but got I4
		//IL_0dfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected Obj, but got I4
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f05: Expected Obj, but got Unknown
		//IL_0f27: Expected Obj, but got I
		//IL_0d90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f58: Expected Obj, but got I
		//IL_0f66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6b: Expected Obj, but got Unknown
		//IL_0fab: Expected Obj, but got I
		//IL_0fb3: Expected I4, but got Obj
		//IL_0e33: Expected Obj, but got I
		//IL_09de: Expected Obj, but got I
		//IL_09ee: Expected Obj, but got I
		//IL_0a13: Expected Obj, but got I
		//IL_14b9: Expected I, but got Obj
		//IL_14b9: Expected Obj, but got I4
		//IL_0e52: Expected Obj, but got I
		//IL_0e6c: Expected I, but got Obj
		//IL_0e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db9: Expected Obj, but got I4
		//IL_0a32: Expected Obj, but got I
		//IL_0a5f: Expected Obj, but got I
		//IL_0a82: Expected Obj, but got I4
		//IL_0fc8: Expected Obj, but got I
		//IL_0fe9: Expected I4, but got Obj
		//IL_0ff6: Expected I4, but got Obj
		//IL_0ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e99: Expected Obj, but got I
		//IL_1524: Expected I, but got Obj
		//IL_0ae6: Expected I, but got Obj
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Expected VT, but got Obj
		//IL_101a: Unknown result type (might be due to invalid IL or missing references)
		//IL_101f: Expected Obj, but got Unknown
		//IL_1055: Expected I4, but got Obj
		//IL_1055: Unknown result type (might be due to invalid IL or missing references)
		//IL_1059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected Obj, but got I
		//IL_1097: Expected I4, but got Obj
		//IL_1097: Unknown result type (might be due to invalid IL or missing references)
		//IL_109b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b74: Expected I, but got Obj
		//IL_0b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba6: Expected VT, but got Obj
		//IL_10c6: Expected Obj, but got I
		//IL_10da: Expected Obj, but got I
		//IL_111c: Expected Obj, but got I
		//IL_112a: Unknown result type (might be due to invalid IL or missing references)
		//IL_112f: Expected Obj, but got Unknown
		//IL_0bc5: Expected Obj, but got I
		//IL_0be8: Expected Obj, but got I
		//IL_0bf3: Expected Obj, but got I4
		//IL_1174: Expected Obj, but got I
		//IL_117c: Expected I4, but got Obj
		//IL_0c1a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D08A0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		object obj3 = default;
		bool flag = Pick((Ray)(&obj3), out var hit);
		bool flag2 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		Enumerator<, > val2 = default;
		Enumerator<, > val = (Enumerator<, >)(val2 + 0);
		object obj4 = !flag2;
		object obj5 = ~obj4;
		if (obj5 != null)
		{
			val = (Enumerator<, >)1133903872;
		}
		List<Pressable> list = Pressables();
		bool flag3 = list == null;
		ref string reference = ref label;
		Enumerator<, > val4 = default;
		Enumerator<, > val3 = val4;
		Enumerator<, > val5 = (Enumerator<, >)0;
		bool flag4 = flag;
		Enumerator<, > val6 = (Enumerator<, >)1133903872;
		UnityEngine.Object obj6 = (UnityEngine.Object)(&hit);
		Ray ray2 = ray;
		UnityEngine.Object obj7 = (UnityEngine.Object)109895680;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D08C0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj9 = 0;
			Enumerator<, > enumerator = list.GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj10 = 0;
			reference = ref label;
			UnityEngine.Object obj11 = null;
			string text = null;
			Enumerator<, > val8 = default;
			Enumerator<, > val7 = val8;
			val6 = val4;
			Enumerator<, > val9 = (Enumerator<, >)2139095039;
			Enumerator<, > val10 = (Enumerator<, >)0;
			Enumerator<, > val13 = default;
			string text4 = default;
			object obj40 = default;
			Action result = default;
			object obj50 = default;
			Action action = default;
			bool value = default;
			object obj60 = default;
			bool flag33 = default;
			object arg2 = default;
			object obj77 = default;
			object obj84 = default;
			while (true)
			{
				Enumerator<, > val11 = val9;
				UnityEngine.Object obj16;
				string text3;
				Enumerator<, > val15;
				object obj19;
				while (true)
				{
					ref string reference2;
					object obj17;
					Enumerator<, > val12;
					UnityEngine.Object obj15;
					string text2;
					object obj18;
					Enumerator<, > val14;
					if (val5.MoveNext())
					{
						object obj12 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X0_v129+E4]");
						bool flag5 = (nint)0 == 0;
						object obj13 = !flag5;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag6 = (UnityEngine.Object)val4 == null;
						bool flag7 = !flag6;
						object obj14 = !flag7;
						reference = ref *(string*)null;
						if (obj14 != null)
						{
							continue;
						}
						if (flag)
						{
							Collider collider = hit.collider;
							bool flag8 = (object)collider == null;
							reference = ref *(string*)null;
							obj6 = null;
							if (flag8)
							{
								goto IL_11c0;
							}
							Transform transform = collider.transform;
							bool flag9 = (int)val4 == 0;
							reference = ref *(string*)null;
							obj6 = null;
							if (flag9)
							{
								goto IL_11ce;
							}
							Transform transform2 = ((Component)val4).transform;
							bool flag10 = (object)transform == null;
							reference2 = ref *(string*)null;
							obj6 = transform2;
							if (flag10)
							{
								goto IL_11aa;
							}
							bool flag11 = transform.IsChildOf(transform2);
							bool flag12 = !flag11;
							reference = ref *(string*)null;
							if (!flag12)
							{
								val12 = val10;
								obj15 = obj11;
								text2 = text;
								reference = ref *(string*)null;
								val3 = (Enumerator<, >)0;
								obj16 = (UnityEngine.Object)val4;
								val5 = val13;
								text3 = text4;
								obj17 = 0;
								obj18 = 0;
								val14 = (Enumerator<, >)(ref val5);
								flag4 = flag;
								val15 = val8;
								ray2 = ray;
								obj19 = 7;
								obj7 = (UnityEngine.Object)1;
								goto IL_1442;
							}
						}
						else
						{
							bool flag13 = (int)val4 == 0;
							reference = ref *(string*)null;
							reference2 = ref *(string*)null;
							obj6 = null;
							if (flag13)
							{
								goto IL_119c;
							}
						}
						Transform transform3 = ((Component)val4).transform;
						if ((object)transform3 != null)
						{
							Vector3 position = transform3.position;
							object obj20 = val11 - ray.m_Origin;
							Enumerator<, > val16 = val6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ray @ X1 (UnityEngine.Ray)+4]");
							object obj21 = val16 - 0;
							Enumerator<, > val17 = val7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ray @ X1 (UnityEngine.Ray)+8]");
							object obj22 = val17 - 0;
							object obj23 = obj20 * ray.m_Direction;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ray @ X1 (UnityEngine.Ray)+10]");
							object obj24 = obj21 * 0;
							val11 = (Enumerator<, >)(obj23 + obj24);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ray @ X1 (UnityEngine.Ray)+14]");
							val6 = (Enumerator<, >)(obj22 * 0);
							object obj25 = val6 + val11;
							bool flag14 = (nint)obj25 < 0;
							object obj26 = !flag14;
							bool flag15 = obj25 == null;
							object obj27 = ~obj26;
							object obj28 = obj27 | flag15;
							if (obj28 != null)
							{
								continue;
							}
							bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) > System.Runtime.CompilerServices.Unsafe.As<Enumerator<, >, UIntPtr>(ref val);
							val11 = val;
							if (!flag16)
							{
								object obj29 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X0_v147+E4]");
								bool flag17 = (nint)0 == 0;
								object obj30 = !flag17;
								if (obj30 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj31 = ray.m_Direction * obj25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ray @ X1 (UnityEngine.Ray)+10]");
								object obj32 = 0 * obj25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ray @ X1 (UnityEngine.Ray)+14]");
								object obj33 = 0 * obj25;
								object obj34 = obj20 - obj31;
								object obj35 = obj21 - obj32;
								val7 = (Enumerator<, >)(obj22 - obj33);
								object obj36 = obj34 * obj34;
								object obj37 = obj35 * obj35;
								object obj38 = obj36 + obj37;
								object obj39 = val7 * val7;
								val11 = (Enumerator<, >)(obj39 + obj38);
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								bool flag18 = System.Runtime.CompilerServices.Unsafe.As<Enumerator<, >, UIntPtr>(ref val11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40);
								object obj41 = !flag18;
								object obj42 = val11 - obj40;
								bool flag19 = obj42 == null;
								object obj43 = ~obj41;
								object obj44 = obj43 | flag19;
								obj5 = ~obj44;
								bool flag20;
								if (obj5 == null)
								{
									object obj45 = val11 - val9;
									flag20 = (nint)obj45 < 0;
								}
								else
								{
									flag20 = false;
								}
								object obj46 = !flag20;
								val6 = val9;
								if (obj46 == null)
								{
									break;
								}
							}
							continue;
						}
						NullReferenceException ex = new NullReferenceException();
						reference2 = ref reference;
						obj6 = null;
						goto IL_119c;
					}
					val12 = val10;
					obj15 = obj11;
					text2 = text;
					val3 = (Enumerator<, >)0;
					val5 = val13;
					obj17 = 0;
					obj18 = 0;
					val14 = (Enumerator<, >)(ref val5);
					flag4 = flag;
					ray2 = ray;
					obj19 = 7;
					obj7 = (UnityEngine.Object)1;
					goto IL_14e9;
					IL_11c0:
					NullReferenceException ex2 = new NullReferenceException();
					goto IL_11ce;
					IL_11aa:
					NullReferenceException ex3 = new NullReferenceException();
					reference = ref reference2;
					goto IL_11c0;
					IL_1442:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D08B8]");
					object obj47 = 0;
					obj6 = (UnityEngine.Object)obj47;
					((Enumerator<, >*)val14)->Dispose();
					bool flag21 = obj17 == null;
					object obj48 = !flag21;
					val = val11;
					if (obj48 == null)
					{
						bool flag22 = (int)val3 == 0;
						object obj49 = !flag22;
						val = val11;
						OutOfMemoryException ex4 = (OutOfMemoryException)val14;
						if (obj49 == null)
						{
							goto IL_05e9;
						}
					}
					else
					{
						OutOfMemoryException ex4 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj6 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						val3 = (Enumerator<, >)1;
						obj17 = obj18;
					}
					else
					{
						if ((nint)obj6 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0C20");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return result;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj17 = obj50;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj18 = obj50;
					}
					val11 = val;
					obj19 = 0;
					goto IL_14e9;
					IL_14e9:
					obj16 = obj15;
					text3 = text2;
					val15 = val12;
					goto IL_1442;
					IL_119c:
					NullReferenceException ex5 = new NullReferenceException();
					goto IL_11aa;
					IL_11ce:
					NullReferenceException ex6 = new NullReferenceException();
					val12 = val10;
					obj15 = obj11;
					text2 = text;
					val3 = (Enumerator<, >)0;
					val5 = val13;
					obj18 = 0;
					val14 = (Enumerator<, >)(ref val5);
					flag4 = flag;
					val = val11;
					ray2 = ray;
					obj7 = (UnityEngine.Object)1;
					goto end_IL_142b;
				}
				obj11 = (UnityEngine.Object)val4;
				text = text4;
				val6 = val9;
				val9 = val11;
				val10 = val8;
				continue;
				IL_153e:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Action result2 = null;
				goto IL_1438;
				IL_14a8:
				bool flag23;
				object obj51;
				action._002Ector(flag23, (IntPtr)obj51);
				result2 = action;
				goto IL_1438;
				IL_05e9:
				if ((nint)obj19 != 7)
				{
					bool flag24 = obj19 == null;
					object obj52 = !flag24;
					result2 = (Action)val15;
					if (obj52 != null)
					{
						goto IL_1438;
					}
				}
				object obj53 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X0_v13+E4]");
				bool flag25 = (nint)0 == 0;
				object obj54 = !flag25;
				if (obj54 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				ref string reference3;
				if (obj16 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0928]");
					object obj55 = 0;
					string text5 = text3 + (string)obj55;
					reference3 = ref *(string*)text5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					result2 = (Action)val15;
					goto IL_1438;
				}
				string text7;
				object obj71;
				nint num2;
				object obj85;
				string text11;
				if (flag4)
				{
					Collider collider2 = hit.collider;
					bool flag26 = (object)collider2 == null;
					reference = ref *(string*)null;
					val = val11;
					obj6 = null;
					if (flag26)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D08A8]");
					object obj56 = 0;
					obj6 = (UnityEngine.Object)obj56;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
					bool flag27 = obj2 == null;
					reference = ref *(string*)null;
					val = val11;
					if (flag27)
					{
						break;
					}
					flag4 = (byte)(obj2 + 16) != 0;
					((bool*)(flag4 ? 1 : 0))->m_value = value;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj57 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1114 @ X0_v26+E4]");
					bool flag28 = (nint)0 == 0;
					object obj58 = !flag28;
					if (obj58 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((UnityEngine.Object)((bool*)(flag4 ? 1 : 0))->m_value != null)
					{
						bool value2 = ((bool*)(flag4 ? 1 : 0))->m_value;
						bool flag29 = (byte)(~(((bool*)(flag4 ? 1 : 0))->m_value ? 1u : 0u)) != 0;
						reference = ref *(string*)null;
						val = val11;
						obj6 = null;
						if (flag29)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v56 (System.Boolean)+5C]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D08E0]");
							object obj59 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							obj60._002Ector();
							bool flag30 = (byte)(int)(~obj60) != 0;
							reference = ref *(string*)null;
							flag4 = (byte)(int)obj60 != 0;
							val = val11;
							obj6 = null;
							if (flag30)
							{
								break;
							}
							object obj61 = obj60 + 40;
							obj61 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D08F8]");
							object obj62 = 0;
							reference3 = ref *(string*)obj62;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
							object obj63 = 0;
							object obj64 = ray2.m_Direction * 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X20_v11 (UnityEngine.Ray)+14]");
							double num = 0.0 * 4.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D08D8]");
							obj51 = 0;
							flag23 = (byte)(int)obj60 != 0;
							goto IL_14a8;
						}
					}
					Collider collider3 = hit.collider;
					bool flag31 = (object)collider3 == null;
					reference = ref *(string*)null;
					val = val11;
					obj6 = null;
					if (flag31)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D08B0]");
					object obj65 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
					object obj66 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v24+E4]");
					bool flag32 = (nint)0 == 0;
					object obj67 = !flag32;
					if (obj67 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((UnityEngine.Object)flag33 != null)
					{
						bool flag34 = !flag33;
						reference = ref *(string*)null;
						flag4 = flag33;
						val = val11;
						obj6 = null;
						if (flag34)
						{
							break;
						}
						string text6 = ((UnityEngine.Object)flag33).name;
						bool flag35 = text6 == null;
						reference = ref *(string*)null;
						flag4 = flag33;
						val = val11;
						obj6 = null;
						if (flag35)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB568]");
						object oldValue = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
						object newValue = 0;
						string arg = text6.Replace((string)oldValue, (string)newValue);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCAC0]");
						object obj68 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0918]");
						object format = 0;
						text7 = string.Format((string)format, arg, arg2);
						object obj69 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1132 @ X0_v33 (System.Boolean)+48]");
						obj7 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v47+E4]");
						bool flag36 = (nint)0 == 0;
						object obj70 = !flag36;
						if (obj70 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (obj7 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1132 @ X0_v33 (System.Boolean)+48]");
							bool flag37 = (nint)0 == 0;
							num2 = unchecked((nint)null);
							reference = ref *(string*)null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1132 @ X0_v33 (System.Boolean)+F8]");
							Enumerator<, > val14 = (Enumerator<, >)0;
							flag4 = flag33;
							val = val11;
							obj6 = null;
							ray2 = (Ray)text7;
							if (flag37)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1132 @ X0_v33 (System.Boolean)+48]");
							if (((MonsterNet)0).Live)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1132 @ X0_v33 (System.Boolean)+48]");
								bool flag38 = (nint)0 == 0;
								num2 = unchecked((nint)null);
								reference = ref *(string*)null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1132 @ X0_v33 (System.Boolean)+F8]");
								val14 = (Enumerator<, >)0;
								flag4 = flag33;
								val = val11;
								obj6 = null;
								ray2 = (Ray)text7;
								if (flag38)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1132 @ X0_v33 (System.Boolean)+48]");
								bool isAuthority = ((MonsterNet)0).IsAuthority;
								bool flag39 = !isAuthority;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0908]");
								obj71 = 0;
								object obj72 = !flag39;
								object obj73 = ~obj72;
								if (obj73 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0938]");
									obj71 = 0;
								}
								goto IL_1506;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0930]");
						obj71 = 0;
						goto IL_1506;
					}
					Rigidbody rigidbody = hit.rigidbody;
					flag4 = (byte)(obj2 + 24) != 0;
					((bool*)(flag4 ? 1 : 0))->m_value = (byte)(int)rigidbody != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj74 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1173 @ X0_v41+E4]");
					bool flag40 = (nint)0 == 0;
					object obj75 = !flag40;
					if (obj75 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((UnityEngine.Object)((bool*)(flag4 ? 1 : 0))->m_value != null)
					{
						bool flag41 = !((bool*)(flag4 ? 1 : 0))->m_value;
						reference = ref *(string*)null;
						val = val11;
						obj6 = null;
						if (flag41)
						{
							break;
						}
						if (!((Rigidbody)((bool*)(flag4 ? 1 : 0))->m_value).isKinematic)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D08F0]");
							object obj76 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							obj77._002Ector();
							bool flag42 = (byte)(int)(~obj77) != 0;
							reference = ref *(string*)null;
							flag4 = (byte)(int)obj77 != 0;
							val = val11;
							obj6 = null;
							if (flag42)
							{
								break;
							}
							object obj78 = obj77 + 40;
							obj78 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj79 = obj78;
							bool flag43 = obj78 == null;
							reference = ref *(string*)null;
							flag4 = (byte)(int)obj77 != 0;
							val = val11;
							obj6 = (UnityEngine.Object)obj2;
							if (flag43)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v33+18]");
							bool flag44 = (nint)0 == 0;
							reference = ref *(string*)null;
							flag4 = (byte)(int)obj77 != 0;
							val = val11;
							obj6 = (UnityEngine.Object)obj2;
							if (flag44)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v33+18]");
							string text8 = ((UnityEngine.Object)0).name;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0910]");
							object obj80 = 0;
							string text9 = text8 + (string)obj80;
							reference3 = ref *(string*)text9;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
							object obj81 = 0;
							object obj82 = ray2.m_Direction * 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X20_v11 (UnityEngine.Ray)+14]");
							double num3 = 0.0 * 3.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D08E8]");
							obj51 = 0;
							flag23 = (byte)(int)obj77 != 0;
							goto IL_14a8;
						}
					}
					Collider collider4 = hit.collider;
					bool flag45 = (object)collider4 == null;
					reference = ref *(string*)null;
					val = val11;
					obj6 = null;
					if (flag45)
					{
						break;
					}
					string arg3 = collider4.name;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj83 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0920]");
					object format2 = 0;
					string text10 = string.Format((string)format2, arg3, obj84);
					num2 = unchecked((nint)null);
					obj85 = obj84;
					val11 = val2;
					text11 = text10;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0900]");
					object obj86 = 0;
					text11 = (string)obj86;
					obj85 = null;
				}
				reference3 = ref *(string*)text11;
				ref string reference4 = ref label;
				goto IL_153e;
				IL_1506:
				string text12 = text7 + (string)obj71;
				reference3 = ref *(string*)text12;
				num2 = unchecked((nint)null);
				obj85 = null;
				text11 = text12;
				reference4 = ref label;
				goto IL_153e;
				IL_1438:
				return result2;
				continue;
				end_IL_142b:
				break;
			}
		}
		throw new NullReferenceException();
	}

	private unsafe static bool Pick(Ray ray, out RaycastHit hit)
	{
		//IL_0010: Expected Obj, but got I
		//IL_052f: Expected Obj, but got I
		//IL_0551: Expected Obj, but got I4
		//IL_0040: Expected I4, but got I8
		//IL_0040: Expected VT, but got Ref
		//IL_006e: Expected Obj, but got I4
		//IL_056f: Expected Obj, but got I
		//IL_057f: Expected Obj, but got I
		//IL_058f: Expected Obj, but got I
		//IL_05b1: Expected Obj, but got I4
		//IL_05ba: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I4
		//IL_0517: Expected I4, but got Obj
		//IL_014c: Expected Obj, but got I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_05d8: Expected Obj, but got I
		//IL_05f2: Expected Obj, but got I
		//IL_0603: Expected I, but got Obj
		//IL_0621: Expected Obj, but got I
		//IL_063c: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected I4, but got Unknown
		//IL_01c7: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I
		//IL_01e7: Expected Obj, but got I
		//IL_01fb: Expected Obj, but got I8
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0212: Expected VT, but got I4
		//IL_021b: Expected Obj, but got I4
		//IL_0662: Expected Obj, but got I4
		//IL_0276: Expected VT, but got Obj
		//IL_04e1: Expected Ref, but got VT
		//IL_02e2: Expected Obj, but got I4
		//IL_0327: Expected Obj, but got I4
		//IL_0393: Expected Obj, but got I4
		//IL_03d8: Expected Obj, but got I4
		//IL_03f0: Expected Obj, but got I4
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Obj, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected Obj, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		//IL_047b: Expected Obj, but got I4
		//IL_049c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0998]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = default;
		RaycastHit[] array = Physics.RaycastAll((Ray)(&obj5), 300f, -769, (QueryTriggerInteraction)2);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v7+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v14+8]");
		Comparison<RaycastHit> comparison = (Comparison<RaycastHit>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC4F8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v14+8]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj11 = 0;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v27+A0]");
				obj8 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC500]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0990]");
			object obj15 = 0;
			Comparison<RaycastHit> comparison2 = default;
			comparison2._002Ector(obj8, (IntPtr)obj15);
			object obj16 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v26+A0]");
			object obj17 = (nint)0 + (nint)8;
			obj17 = comparison2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj11 = 0;
			comparison = comparison2;
		}
		object obj18 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34C553C");
		if (array == null)
		{
			goto IL_04fb;
		}
		bool flag5 = array.Length < 0;
		bool flag6 = array.Length == 0;
		object obj19 = array.Length ^ array.Length;
		object obj20 = array.Length & obj19;
		bool flag7 = (nint)obj20 < 0;
		bool flag8 = flag5 == flag7;
		object obj21 = !flag6;
		object obj22 = flag8 & obj21;
		bool flag9 = array.Length < 1;
		object obj23 = obj22;
		if (flag9)
		{
			goto IL_04b2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0980]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0988]");
		object obj26 = 0;
		object obj27 = array.Length & 0xFFFFFFFFL;
		object obj28 = array + 32;
		RaycastHit raycastHit = (RaycastHit)0;
		object obj29 = 0;
		object obj30 = obj22;
		UnityEngine.Object obj34 = default;
		UnityEngine.Object obj38 = default;
		while (true)
		{
			bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27);
			object obj31 = !flag10;
			if (obj31 != null)
			{
				break;
			}
			Collider collider = raycastHit.collider;
			if ((object)collider != null)
			{
				bool isTrigger = collider.isTrigger;
				bool flag11 = !isTrigger;
				raycastHit = (RaycastHit)obj28;
				if (!flag11)
				{
					Collider collider2 = raycastHit.collider;
					if ((object)collider2 == null)
					{
						goto IL_04fb;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
					object obj32 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v17+E4]");
					bool flag12 = (nint)0 == 0;
					object obj33 = !flag12;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag13 = obj34 != null;
					bool flag14 = !flag13;
					object obj35 = !flag14;
					if (obj35 == null)
					{
						Collider collider3 = raycastHit.collider;
						if ((object)collider3 == null)
						{
							goto IL_04fb;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
						object obj36 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v18+E4]");
						bool flag15 = (nint)0 == 0;
						object obj37 = !flag15;
						if (obj37 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag16 = obj38 != null;
						bool flag17 = !flag16;
						object obj39 = !flag17;
						if (obj39 == null)
						{
							obj27 = array.Length;
							obj29++;
							obj28 += 48;
							object obj40 = obj29 - array.Length;
							bool flag18 = (nint)obj40 < 0;
							object obj41 = obj29 ^ array.Length;
							object obj42 = obj29 ^ obj40;
							object obj43 = obj41 & obj42;
							bool flag19 = (nint)obj43 < 0;
							bool flag20 = flag18 == flag19;
							object obj44 = !flag20;
							bool flag21 = (nint)obj29 < array.Length;
							obj23 = obj44;
							obj18 = 0;
							obj30 = obj44;
							if (flag21)
							{
								continue;
							}
							goto IL_04b2;
						}
					}
				}
				goto IL_04cc;
			}
			goto IL_04fb;
		}
		goto IL_0509;
		IL_0670:
		return (byte)(obj23 & 1) != 0;
		IL_04b2:
		_ = 0;
		_ = 0;
		ref RaycastHit reference = ref *(RaycastHit*)null;
		goto IL_0670;
		IL_04fb:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0509;
		IL_04cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X27_v7+20]");
		_ = 0;
		reference = ref *(RaycastHit*)raycastHit;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X27_v7+10]");
		_ = 0;
		obj23 = obj30;
		goto IL_0670;
		IL_0509:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private unsafe List<Pressable> Pressables()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I
		//IL_0159: Expected VT, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I
		//IL_019e: Expected Obj, but got Ref
		//IL_01be: Expected F4, but got I4
		//IL_062e: Expected Obj, but got I4
		//IL_065b: Expected Obj, but got I
		//IL_0663: Expected VT, but got Obj
		//IL_01e9: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I
		//IL_020a: Expected F4, but got I4
		//IL_0213: Expected Obj, but got I4
		//IL_1b47: Expected Obj, but got I4
		//IL_069a: Expected Obj, but got I
		//IL_0a01: Expected Obj, but got I
		//IL_0a2b: Expected Obj, but got I4
		//IL_025a: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I
		//IL_0a58: Expected Obj, but got I
		//IL_0a60: Expected VT, but got Obj
		//IL_06cf: Expected Obj, but got I
		//IL_06df: Expected Obj, but got I
		//IL_06ef: Expected Obj, but got I
		//IL_0700: Expected Obj, but got I4
		//IL_0293: Expected Obj, but got I
		//IL_02ac: Expected I, but got Obj
		//IL_02ac: Expected Obj, but got I
		//IL_02ba: Expected Obj, but got Ref
		//IL_1b6e: Expected Obj, but got I4
		//IL_0a97: Expected Obj, but got I
		//IL_0e67: Expected Obj, but got I
		//IL_0e91: Expected Obj, but got I4
		//IL_0742: Expected Obj, but got I
		//IL_075c: Expected Obj, but got I
		//IL_0318: Expected Obj, but got I4
		//IL_0ebe: Expected Obj, but got I
		//IL_0ec6: Expected VT, but got Obj
		//IL_0acc: Expected Obj, but got I
		//IL_0adc: Expected Obj, but got I
		//IL_0aec: Expected Obj, but got I
		//IL_0afa: Expected Obj, but got Ref
		//IL_0b0b: Expected Obj, but got I4
		//IL_0784: Expected I, but got Obj
		//IL_0784: Expected Obj, but got I
		//IL_0792: Expected Obj, but got Ref
		//IL_0347: Expected Obj, but got I
		//IL_1bbc: Expected Obj, but got I4
		//IL_0412: Expected Obj, but got I
		//IL_0423: Expected Obj, but got I4
		//IL_0efd: Expected Obj, but got I
		//IL_1339: Expected Obj, but got I4
		//IL_0b4d: Expected Obj, but got I
		//IL_07db: Expected Obj, but got I
		//IL_1366: Expected Obj, but got I
		//IL_136e: Expected VT, but got Obj
		//IL_0f32: Expected Obj, but got I
		//IL_0f42: Expected Obj, but got I
		//IL_0f50: Expected Obj, but got Ref
		//IL_0f5a: Expected Obj, but got I4
		//IL_0438: Expected Obj, but got I
		//IL_044e: Expected Obj, but got I
		//IL_03a6: Expected Obj, but got I
		//IL_03ba: Expected Obj, but got I
		//IL_03ca: Expected Obj, but got I
		//IL_1c0a: Expected Obj, but got I4
		//IL_0b8e: Expected I, but got Obj
		//IL_0ba7: Expected I, but got Obj
		//IL_0ba7: Expected Obj, but got I
		//IL_03ed: Expected Obj, but got I4
		//IL_13a5: Expected Obj, but got I
		//IL_0bba: Expected Obj, but got Ref
		//IL_081b: Expected Obj, but got I
		//IL_0831: Expected Obj, but got I
		//IL_04a9: Expected Obj, but got I4
		//IL_1711: Expected Obj, but got I
		//IL_173b: Expected Obj, but got I4
		//IL_0f9c: Expected Obj, but got I
		//IL_0c5d: Expected Obj, but got I
		//IL_0548: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I
		//IL_0575: Expected VT, but got Ref
		//IL_058d: Expected VT, but got Ref
		//IL_059d: Expected F8, but got Obj
		//IL_1768: Expected Obj, but got I
		//IL_13da: Expected Obj, but got I
		//IL_13ea: Expected Obj, but got I
		//IL_13fa: Expected Obj, but got I
		//IL_1403: Expected Obj, but got I4
		//IL_0c19: Expected Obj, but got I
		//IL_088c: Expected Obj, but got I4
		//IL_05b2: Expected Obj, but got I
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected Obj, but got Unknown
		//IL_04d4: Expected Obj, but got I
		//IL_04ea: Expected Obj, but got I
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected Obj, but got Unknown
		//IL_051a: Expected VT, but got I4
		//IL_0533: Expected F8, but got Obj
		//IL_1c31: Expected Obj, but got I4
		//IL_0fdb: Expected Obj, but got I
		//IL_0ffe: Expected I, but got Obj
		//IL_0ffe: Expected Obj, but got I
		//IL_092b: Expected Obj, but got I
		//IL_093b: Expected Obj, but got I
		//IL_0958: Expected VT, but got Ref
		//IL_0970: Expected VT, but got Ref
		//IL_0980: Expected F8, but got Obj
		//IL_179f: Expected Obj, but got I
		//IL_1011: Expected Obj, but got Ref
		//IL_1045: Expected Obj, but got I4
		//IL_0c82: Expected Obj, but got I
		//IL_0c98: Expected Obj, but got I
		//IL_0995: Expected Obj, but got I
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Expected Obj, but got Unknown
		//IL_09ca: Expected Obj, but got I4
		//IL_09d3: Expected Obj, but got I4
		//IL_08b7: Expected Obj, but got I
		//IL_08cd: Expected Obj, but got I
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected Obj, but got Unknown
		//IL_08fd: Expected VT, but got I4
		//IL_0916: Expected F8, but got Obj
		//IL_1445: Expected Obj, but got I
		//IL_1074: Expected Obj, but got I
		//IL_17d4: Expected Obj, but got I
		//IL_17e4: Expected Obj, but got I
		//IL_17f4: Expected Obj, but got I
		//IL_17fd: Expected Obj, but got I4
		//IL_1123: Expected Obj, but got I
		//IL_0cf3: Expected Obj, but got I4
		//IL_1c58: Expected Obj, but got I4
		//IL_1484: Expected Obj, but got I
		//IL_149e: Expected Obj, but got I
		//IL_14b7: Expected I, but got Obj
		//IL_14b7: Expected Obj, but got I
		//IL_0d91: Expected Obj, but got I
		//IL_0da1: Expected Obj, but got I
		//IL_0dbe: Expected VT, but got Ref
		//IL_0dd6: Expected VT, but got Ref
		//IL_0de6: Expected F8, but got Obj
		//IL_14ca: Expected Obj, but got Ref
		//IL_14dd: Expected Obj, but got Ref
		//IL_0dfb: Expected Obj, but got I
		//IL_0e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e09: Expected Obj, but got Unknown
		//IL_0e30: Expected Obj, but got I4
		//IL_0e39: Expected Obj, but got I4
		//IL_0d1e: Expected Obj, but got I
		//IL_0d34: Expected Obj, but got I
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d42: Expected Obj, but got Unknown
		//IL_0d64: Expected VT, but got I4
		//IL_0d7c: Expected F8, but got Obj
		//IL_1827: Expected Obj, but got I
		//IL_1841: Expected Obj, but got I
		//IL_1151: Expected Obj, but got I
		//IL_1167: Expected Obj, but got I
		//IL_10cb: Expected Obj, but got I
		//IL_10df: Expected Obj, but got I
		//IL_1860: Expected Obj, but got I
		//IL_1879: Expected I, but got Obj
		//IL_1879: Expected Obj, but got I
		//IL_1887: Expected Obj, but got Ref
		//IL_11c2: Expected Obj, but got I4
		//IL_1533: Expected Obj, but got I
		//IL_1549: Expected Obj, but got I
		//IL_1258: Expected Obj, but got I
		//IL_1268: Expected Obj, but got I
		//IL_1285: Expected VT, but got Ref
		//IL_1296: Expected VT, but got Ref
		//IL_12a6: Expected F8, but got Obj
		//IL_18d4: Expected Obj, but got I
		//IL_12bb: Expected Obj, but got I
		//IL_12c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c9: Expected Obj, but got Unknown
		//IL_12e8: Expected Obj, but got I4
		//IL_12f1: Expected Obj, but got I4
		//IL_11ed: Expected Obj, but got I
		//IL_1203: Expected Obj, but got I
		//IL_120c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1211: Expected Obj, but got Unknown
		//IL_1233: Expected VT, but got I4
		//IL_1243: Expected F8, but got Obj
		//IL_15a4: Expected Obj, but got I4
		//IL_1643: Expected Obj, but got I
		//IL_1653: Expected Obj, but got I
		//IL_1670: Expected VT, but got Ref
		//IL_1680: Expected VT, but got Ref
		//IL_1690: Expected F8, but got Obj
		//IL_1914: Expected Obj, but got I
		//IL_192a: Expected Obj, but got I
		//IL_16a5: Expected Obj, but got I
		//IL_16ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b3: Expected Obj, but got Unknown
		//IL_16d2: Expected Obj, but got I4
		//IL_16e3: Expected Obj, but got I4
		//IL_15cf: Expected Obj, but got I
		//IL_15e5: Expected Obj, but got I
		//IL_15ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f3: Expected Obj, but got Unknown
		//IL_1615: Expected VT, but got I4
		//IL_162e: Expected F8, but got Obj
		//IL_1985: Expected Obj, but got I4
		//IL_1a12: Expected Obj, but got I
		//IL_1a22: Expected Obj, but got I
		//IL_1a3f: Expected VT, but got Ref
		//IL_1a47: Expected F8, but got Obj
		//IL_1a5c: Expected Obj, but got I
		//IL_1a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6a: Expected Obj, but got Unknown
		//IL_1a89: Expected Obj, but got I4
		//IL_19b0: Expected Obj, but got I
		//IL_19c6: Expected Obj, but got I
		//IL_19cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d4: Expected Obj, but got Unknown
		//IL_19f5: Expected I4, but got Obj
		//IL_19fd: Expected F8, but got Obj
		float unscaledTime = Time.unscaledTime;
		float num = unscaledTime - pressablesAt;
		object obj;
		if ((double)num < 1.0)
		{
			obj = this + 112;
			goto IL_1a97;
		}
		float unscaledTime2 = Time.unscaledTime;
		obj = this + 112;
		object obj2 = obj;
		object obj5;
		object obj11;
		float num5 = default;
		float num11 = default;
		int num2;
		double num6;
		object obj4 = default;
		Action action2 = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v4+18]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v4+1C]");
			object obj3 = (nint)0 + (nint)1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v4+18]");
			bool flag = (nint)0 < (nint)1;
			IntPtr intPtr = default;
			int num3 = (int)(nint)intPtr;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v4+10]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v4+18]");
				Array.Clear((Array)num4, 0, 0);
				obj4 = 0;
				num3 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D04D0]");
			object obj8 = 0;
			Pressable pressable = (Pressable)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
			object obj9 = default;
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X0_v14+18]");
				object obj10 = 0;
				obj11 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num5, 6));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X0_v14+18]");
				bool flag3 = (nint)0 < (nint)1;
				num5 = 0f;
				num6 = 1.0;
				if (flag3)
				{
					goto IL_0604;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0A10]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D09C0]");
				object obj13 = 0;
				Action action = action2;
				num5 = 0f;
				object obj14 = 0;
				object obj15 = obj4;
				int num7 = num2;
				double num8 = 1.0;
				Action action3 = default;
				while (true)
				{
					bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
					object obj16 = !flag4;
					if (obj16 != null)
					{
						break;
					}
					object obj17 = obj9 + obj14;
					List<Pressable> list = (List<Pressable>)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ X8_v114+20]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D09B0]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ X8_v114+20]");
					action3._002Ector(0, (IntPtr)obj20);
					object obj21 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num5, 4));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ X8_v114+20]");
					if ((nint)0 != 0)
					{
						object obj22 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1117 @ X0_v142+E4]");
						bool flag5 = (nint)0 == 0;
						object obj23 = !flag5;
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X23_v22 (System.Object)+20]");
						string text;
						string text4;
						if ((UnityEngine.Object)0 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X23_v22 (System.Object)+20]");
							if ((nint)0 == 0)
							{
								goto IL_1a9c;
							}
							text = (string)obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X23_v22 (System.Object)+20]");
							string text2 = ((UnityEngine.Object)0).name;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7260]");
							object obj24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
							object obj25 = 0;
							string text3 = (string)obj24 + text2 + (string)obj25;
							obj4 = 0;
							text4 = text3;
						}
						else
						{
							text = (string)obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
							object obj26 = 0;
							text4 = (string)obj26;
							obj4 = 0;
						}
						string text5 = text + text4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						if (obj != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X22_v21 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
							object obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X22_v21 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+1C]");
							object obj28 = (nint)0 + (nint)1;
							object obj29 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X22_v21 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X22_v21 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
								nint num9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X8_v122+18]");
								bool flag6 = num9 < 0;
								object obj30 = !flag6;
								if (obj30 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X22_v21 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
									nint num10 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X22_v21 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
									object obj31 = num10 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X22_v21 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
									object obj32 = (nint)0 + (nint)1;
									object obj33 = obj31 + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									pressable = (Pressable)0;
									num2 = 0;
									unscaledTime2 = num5;
									num6 = (double)action3;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X9_v43+20]");
									object obj34 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1360 @ X8_v125+A8]");
									object obj35 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1365 @ X8_v126+70]");
									num2 = 0;
									((List<Pressable>)obj).AddWithResize((Pressable)(&num11));
									action = action3;
									num11 = num5;
									pressable = (Pressable)(&num11);
									unscaledTime2 = num5;
									num6 = (double)action3;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X0_v14+18]");
								obj10 = 0;
								obj14++;
								object obj36 = obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X0_v14+18]");
								bool flag7 = (nint)obj36 < 0;
								action2 = action;
								obj15 = obj4;
								num7 = num2;
								num8 = num6;
								if (flag7)
								{
									continue;
								}
								goto IL_0604;
							}
						}
					}
					goto IL_1a9c;
				}
				goto IL_1aaa;
			}
		}
		goto IL_1a9c;
		IL_1701:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj37 = 0;
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ X0_v36+E4]");
		bool flag8 = (nint)0 == 0;
		object obj39 = !flag8;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D09E0]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj41 = default;
		if (obj41 == null)
		{
			goto IL_1a9c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v39+18]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v39+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_1a97;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0A08]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0A28]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D09C0]");
		object obj45 = 0;
		object obj46 = 0;
		Action action4 = default;
		while (true)
		{
			bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj46) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj42);
			object obj47 = !flag9;
			if (obj47 != null)
			{
				break;
			}
			object obj48 = obj41 + obj46;
			List<Pressable> list2 = (List<Pressable>)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1547 @ X8_v41+20]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D09B8]");
			object obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1547 @ X8_v41+20]");
			action4._002Ector(0, (IntPtr)obj51);
			object obj52 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num5, 4));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1547 @ X8_v41+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X23_v11 (System.Object)+20]");
				string text6 = (string)obj43 + (string)0 + (string)obj44;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if (obj != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X22_v11 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
					object obj53 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X22_v11 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+1C]");
					object obj54 = (nint)0 + (nint)1;
					object obj55 = obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X22_v11 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X22_v11 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
						nint num12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X8_v47+18]");
						bool flag10 = num12 < 0;
						object obj56 = !flag10;
						if (obj56 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X22_v11 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
							nint num13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X22_v11 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
							object obj57 = num13 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X22_v11 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
							object obj58 = (nint)0 + (nint)1;
							object obj59 = obj57 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							num2 = (int)obj44;
							num6 = (double)action4;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X9_v14+20]");
							object obj60 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1662 @ X8_v50+A8]");
							object obj61 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1667 @ X8_v51+70]");
							num2 = 0;
							((List<Pressable>)obj).AddWithResize((Pressable)(&num11));
							num6 = (double)action4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v39+18]");
						obj42 = 0;
						obj46++;
						object obj62 = obj46;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v39+18]");
						bool flag11 = (nint)obj62 < 0;
						obj4 = 0;
						if (flag11)
						{
							continue;
						}
						goto IL_1a97;
					}
				}
			}
			goto IL_1a9c;
		}
		goto IL_1aaa;
		IL_0604:
		object obj63 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X0_v16+E4]");
		bool flag12 = (nint)0 == 0;
		object obj64 = !flag12;
		if (obj64 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8A68]");
		object obj65 = 0;
		Pressable pressable2 = (Pressable)obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj66 = default;
		if (obj66 == null)
		{
			goto IL_1a9c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X0_v19+18]");
		object obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X0_v19+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_09f1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D09F8]");
		object obj68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0A38]");
		object obj69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D09C0]");
		object obj70 = 0;
		Action action5 = action2;
		object obj71 = 0;
		object obj72 = obj4;
		int num14 = num2;
		double num15 = num6;
		Action action6 = default;
		while (true)
		{
			bool flag13 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj71) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj67);
			object obj73 = !flag13;
			if (obj73 != null)
			{
				break;
			}
			object obj74 = obj66 + obj71;
			List<Pressable> list3 = (List<Pressable>)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ X8_v103+20]");
			object obj75 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj76 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ X8_v103+20]");
			action6._002Ector(0, (IntPtr)obj68);
			object obj77 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num5, 4));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ X8_v103+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X23_v20 (System.Object)+20]");
				string text7 = (string)obj69 + (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if (obj != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X22_v19 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
					object obj78 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X22_v19 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+1C]");
					object obj79 = (nint)0 + (nint)1;
					object obj80 = obj70;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X22_v19 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X22_v19 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
						nint num16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v107+18]");
						bool flag14 = num16 < 0;
						object obj81 = !flag14;
						if (obj81 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X22_v19 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
							nint num17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X22_v19 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
							object obj82 = num17 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X22_v19 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
							object obj83 = (nint)0 + (nint)1;
							object obj84 = obj82 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							pressable2 = (Pressable)0;
							num2 = 0;
							unscaledTime2 = num5;
							num6 = (double)action6;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X9_v37+20]");
							object obj85 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ X8_v110+A8]");
							object obj86 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1381 @ X8_v111+70]");
							num2 = 0;
							((List<Pressable>)obj).AddWithResize((Pressable)(&num11));
							action5 = action6;
							num11 = num5;
							pressable2 = (Pressable)(&num11);
							unscaledTime2 = num5;
							num6 = (double)action6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X0_v19+18]");
						obj67 = 0;
						obj71++;
						object obj87 = obj71;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X0_v19+18]");
						bool flag15 = (nint)obj87 < 0;
						action2 = action5;
						obj4 = 0;
						obj72 = 0;
						num14 = num2;
						num15 = num6;
						if (flag15)
						{
							continue;
						}
						goto IL_09f1;
					}
				}
			}
			goto IL_1a9c;
		}
		goto IL_1aaa;
		IL_1a97:
		return (List<Pressable>)obj;
		IL_130f:
		object obj89;
		object obj88 = obj89;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1282 @ X0_v31+E4]");
		bool flag16 = (nint)0 == 0;
		object obj90 = !flag16;
		if (obj90 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D09F0]");
		object obj91 = 0;
		Pressable pressable3 = (Pressable)obj91;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj92 = default;
		if (obj92 == null)
		{
			goto IL_1a9c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X0_v34+18]");
		object obj93 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X0_v34+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_1701;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D09A0]");
		object obj94 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0A20]");
		object obj95 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D09C0]");
		object obj96 = 0;
		object obj97 = 0;
		object obj98 = obj4;
		int num18 = num2;
		double num19 = num6;
		Action action7 = default;
		object obj105 = default;
		while (true)
		{
			bool flag17 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj97) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj93);
			object obj99 = !flag17;
			if (obj99 != null)
			{
				break;
			}
			object obj100 = obj92 + obj97;
			List<Pressable> list4 = (List<Pressable>)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X8_v54+20]");
			object obj101 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X8_v54+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
				object obj102 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0A00]");
				object obj103 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X8_v54+20]");
				action7._002Ector(0, (IntPtr)obj103);
				object obj104 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num5, 4));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				string text8 = ((Enum)(&obj105)).ToString();
				string text9 = (string)obj95 + text8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if (obj != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X22_v13 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
					object obj106 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X22_v13 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+1C]");
					object obj107 = (nint)0 + (nint)1;
					object obj108 = obj96;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X22_v13 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X22_v13 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
						nint num20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X8_v62+18]");
						bool flag18 = num20 < 0;
						object obj109 = !flag18;
						if (obj109 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X22_v13 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
							nint num21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X22_v13 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
							object obj110 = num21 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X22_v13 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
							object obj111 = (nint)0 + (nint)1;
							object obj112 = obj110 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							pressable3 = (Pressable)0;
							num2 = 0;
							unscaledTime2 = num5;
							num6 = (double)action7;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X9_v20+20]");
							object obj113 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1633 @ X8_v65+A8]");
							object obj114 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1638 @ X8_v66+70]");
							num2 = 0;
							((List<Pressable>)obj).AddWithResize((Pressable)(&num11));
							num11 = num5;
							pressable3 = (Pressable)(&num11);
							unscaledTime2 = num5;
							num6 = (double)action7;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X0_v34+18]");
						obj93 = 0;
						obj97++;
						object obj115 = obj97;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X0_v34+18]");
						bool flag19 = (nint)obj115 < 0;
						obj4 = 0;
						obj105 = obj94;
						obj98 = 0;
						num18 = num2;
						num19 = num6;
						if (flag19)
						{
							continue;
						}
						goto IL_1701;
					}
				}
			}
			goto IL_1a9c;
		}
		goto IL_1aaa;
		IL_0e57:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		obj89 = 0;
		object obj116 = obj89;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1176 @ X0_v26+E4]");
		bool flag20 = (nint)0 == 0;
		object obj117 = !flag20;
		if (obj117 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D09E8]");
		object obj118 = 0;
		Pressable pressable4 = (Pressable)obj118;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj119 = default;
		if (obj119 == null)
		{
			goto IL_1a9c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v29+18]");
		object obj120 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v29+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_130f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D09D0]");
		object obj121 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D09C0]");
		object obj122 = 0;
		object obj123 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num5, 6));
		object obj124 = 0;
		object obj125 = obj4;
		int num22 = num2;
		double num23 = num6;
		Action action8 = default;
		while (true)
		{
			bool flag21 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj124) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj120);
			object obj126 = !flag21;
			if (obj126 != null)
			{
				break;
			}
			object obj127 = obj119 + obj124;
			List<Pressable> list5 = (List<Pressable>)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v69+20]");
			object obj128 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v69+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
				object obj129 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v69+20]");
				action8._002Ector(0, (IntPtr)obj121);
				object obj130 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num5, 4));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj131 = obj89;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1478 @ X0_v81+E4]");
				bool flag22 = (nint)0 == 0;
				object obj132 = !flag22;
				if (obj132 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X23_v15 (System.Object)+20]");
				if ((UnityEngine.Object)0 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X23_v15 (System.Object)+20]");
					if ((nint)0 == 0)
					{
						goto IL_1a9c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X23_v15 (System.Object)+20]");
					string text10 = ((UnityEngine.Object)0).name;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0A30]");
					object obj133 = 0;
					string text11 = (string)obj133 + text10;
					string text12 = text11;
					num2 = 0;
					object obj134 = obj11;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0A48]");
					object obj135 = 0;
					string text12 = (string)obj135;
					num2 = 0;
					object obj134 = obj123;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if (obj != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X22_v15 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
					object obj136 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X22_v15 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+1C]");
					object obj137 = (nint)0 + (nint)1;
					object obj138 = obj122;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X22_v15 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X22_v15 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
						nint num24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X8_v75+18]");
						bool flag23 = num24 < 0;
						object obj139 = !flag23;
						if (obj139 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X22_v15 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
							nint num25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X22_v15 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
							object obj140 = num25 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X22_v15 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
							object obj141 = (nint)0 + (nint)1;
							object obj142 = obj140 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							pressable4 = (Pressable)0;
							unscaledTime2 = num5;
							num6 = (double)action8;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X9_v26+20]");
							object obj143 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1600 @ X8_v78+A8]");
							object obj144 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1605 @ X8_v79+70]");
							num2 = 0;
							((List<Pressable>)obj).AddWithResize((Pressable)(&num11));
							num11 = num5;
							pressable4 = (Pressable)(&num11);
							unscaledTime2 = num5;
							num6 = (double)action8;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v29+18]");
						obj120 = 0;
						obj124++;
						object obj145 = obj124;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v29+18]");
						bool flag24 = (nint)obj145 < 0;
						obj4 = 0;
						obj125 = 0;
						num22 = num2;
						num23 = num6;
						if (flag24)
						{
							continue;
						}
						goto IL_130f;
					}
				}
			}
			goto IL_1a9c;
		}
		goto IL_1aaa;
		IL_1aaa:
		return (List<Pressable>)(object)new IndexOutOfRangeException();
		IL_09f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj146 = 0;
		object obj147 = obj146;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1083 @ X0_v21+E4]");
		bool flag25 = (nint)0 == 0;
		object obj148 = !flag25;
		if (obj148 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D09D8]");
		object obj149 = 0;
		Pressable pressable5 = (Pressable)obj149;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj150 = default;
		if (obj150 == null)
		{
			goto IL_1a9c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v24+18]");
		object obj151 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v24+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_0e57;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj152 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D09A8]");
		object obj153 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D09C0]");
		object obj154 = 0;
		object obj155 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num5, 6));
		Action action9 = action2;
		object obj156 = 0;
		object obj157 = obj4;
		int num26 = num2;
		double num27 = num6;
		Action action10 = default;
		while (true)
		{
			bool flag26 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj156) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj151);
			object obj158 = !flag26;
			if (obj158 != null)
			{
				break;
			}
			object obj159 = obj150 + obj156;
			List<Pressable> list6 = (List<Pressable>)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v87+20]");
			object obj160 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v87+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				nint num28 = (nint)obj153;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v87+20]");
				action10._002Ector(0, (IntPtr)obj153);
				object obj161 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num5, 4));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v87+20]");
				int num29 = (int)((nint)0 + (nint)32);
				if (((int*)num29)->m_value != 0)
				{
					string text13 = ((int*)num29)->ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0A18]");
					object obj162 = 0;
					string text14 = (string)obj162 + text13;
					string text15 = text14;
					num28 = 0;
					object obj163 = obj155;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0A40]");
					object obj164 = 0;
					string text15 = (string)obj164;
					object obj163 = obj11;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if (obj != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X22_v17 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
					object obj165 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X22_v17 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+1C]");
					object obj166 = (nint)0 + (nint)1;
					object obj167 = obj154;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X22_v17 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X22_v17 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
						nint num30 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v843 @ X8_v91+18]");
						bool flag27 = num30 < 0;
						object obj168 = !flag27;
						if (obj168 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X22_v17 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+10]");
							nint num31 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X22_v17 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
							object obj169 = num31 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X22_v17 (System.Collections.Generic.List`1<GillaFreecam+Pressable>)+18]");
							object obj170 = (nint)0 + (nint)1;
							object obj171 = obj169 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							pressable5 = (Pressable)0;
							num2 = (int)num28;
							unscaledTime2 = num5;
							num6 = (double)action10;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X9_v32+20]");
							object obj172 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1512 @ X8_v94+A8]");
							object obj173 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1517 @ X8_v95+70]");
							num2 = 0;
							((List<Pressable>)obj).AddWithResize((Pressable)(&num11));
							action9 = action10;
							num11 = num5;
							pressable5 = (Pressable)(&num11);
							unscaledTime2 = num5;
							num6 = (double)action10;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v24+18]");
						obj151 = 0;
						obj156++;
						object obj174 = obj156;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v24+18]");
						bool flag28 = (nint)obj174 < 0;
						action2 = action9;
						obj4 = 0;
						obj157 = 0;
						num26 = num2;
						num27 = num6;
						if (flag28)
						{
							continue;
						}
						goto IL_0e57;
					}
				}
			}
			goto IL_1a9c;
		}
		goto IL_1aaa;
		IL_1a9c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1aaa;
	}

	public void BringPlayer()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I4
		//IL_0080: Expected VT, but got I4
		//IL_00b9: Expected VT, but got I4
		//IL_00b9: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (cam != null)
		{
			Transform transform = cam.transform;
			Vector3 position = transform.position;
			float down = default;
			Vector3 vector = GillaTeleport.FloorUnder((Vector3)0, down);
			Transform transform2 = cam.transform;
			Vector3 forward = transform2.forward;
			bool flag2 = GillaTeleport.To((Vector3)0, (Vector3)0);
		}
	}

	private static string Network()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0654: Expected Obj, but got I
		//IL_0676: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I
		//IL_0243: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I4
		//IL_06df: Expected Obj, but got I
		//IL_06ef: Expected Obj, but got I
		//IL_06ff: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_0833: Expected Obj, but got I4
		//IL_02c6: Expected Obj, but got I
		//IL_0768: Expected Obj, but got I4
		//IL_0281: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I
		//IL_07a0: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I4
		//IL_0859: Expected Obj, but got I
		//IL_0869: Expected Obj, but got I
		//IL_088b: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I
		//IL_0327: Expected Obj, but got I
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_07d8: Expected Obj, but got I4
		//IL_0694: Expected Obj, but got I
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected Obj, but got Unknown
		//IL_06c1: Expected Obj, but got I4
		//IL_03a8: Expected Obj, but got I
		//IL_0452: Expected Obj, but got I4
		//IL_0235: Expected Obj, but got I4
		//IL_01a0: Expected Obj, but got I
		//IL_0497: Expected Obj, but got I4
		//IL_0382: Expected Obj, but got I
		//IL_0616: Expected Obj, but got I
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_020a: Expected Obj, but got I
		//IL_0423: Expected Obj, but got I
		//IL_0521: Expected Obj, but got I
		//IL_0560: Expected Obj, but got I
		//IL_0585: Expected Obj, but got I
		//IL_0585: Expected Obj, but got I
		//IL_05ab: Expected Obj, but got I
		//IL_05ca: Expected Obj, but got I
		//IL_05d5: Expected Obj, but got I4
		//IL_0601: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB788]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj5 = (UnityEngine.Object)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj6 = default;
		if (obj6 == null)
		{
			goto IL_0620;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v5+18]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v5+18]");
		object obj8;
		object obj9;
		object obj17;
		if ((nint)0 >= (nint)1)
		{
			obj8 = 0;
			obj9 = 0;
			object obj10 = 0;
			while (true)
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
				object obj11 = !flag2;
				if (obj11 != null)
				{
					break;
				}
				object obj12 = obj6 + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v39+20]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v39+20]");
				if ((nint)0 != 0)
				{
					object obj14 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v66+E4]");
					bool flag3 = (nint)0 == 0;
					object obj15 = !flag3;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X26_v8+48]");
					bool flag4 = (UnityEngine.Object)0 != null;
					bool flag5 = !flag4;
					obj5 = null;
					if (flag5)
					{
						goto IL_0219;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X26_v8+48]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X26_v8+48]");
						bool live = ((MonsterNet)0).Live;
						bool flag6 = !live;
						obj5 = null;
						if (flag6)
						{
							goto IL_0219;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X26_v8+48]");
						if ((nint)0 != 0)
						{
							obj8++;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X26_v8+48]");
							bool isAuthority = ((MonsterNet)0).IsAuthority;
							obj5 = null;
							goto IL_0684;
						}
					}
				}
				goto IL_0620;
				IL_0684:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v5+18]");
				obj7 = 0;
				obj10++;
				object obj16 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v5+18]");
				bool flag7 = (nint)obj16 < 0;
				obj17 = 0;
				if (flag7)
				{
					continue;
				}
				goto IL_022c;
				IL_0219:
				obj9++;
				goto IL_0684;
			}
			goto IL_062e;
		}
		obj8 = 0;
		obj9 = 0;
		goto IL_06cf;
		IL_022c:
		obj17 = 0;
		goto IL_06cf;
		IL_07e6:
		object obj18;
		string text;
		return (string)obj18 + text;
		IL_0606:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0968]");
		obj18 = 0;
		goto IL_07e6;
		IL_0620:
		NullReferenceException ex = new NullReferenceException();
		goto IL_062e;
		IL_06cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0958]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		object arg2 = default;
		string text2 = string.Format((string)format, arg, arg2);
		string text4;
		if ((nint)obj9 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0948]");
			object format2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg3 = default;
			string text3 = string.Format((string)format2, arg3);
			object obj21 = obj9;
			text4 = text3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj22 = 0;
			text4 = (string)obj22;
			object obj21 = obj8;
		}
		text = text2 + text4;
		object obj23 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v10+E4]");
		bool flag8 = (nint)0 == 0;
		object obj24 = !flag8;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj25 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v23+E4]");
		bool flag9 = (nint)0 == 0;
		object obj26 = !flag9;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj20;
		}
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v23+A0]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v4+8]");
		UnityEngine.Object obj29 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v14+E4]");
		bool flag10 = (nint)0 == 0;
		object obj30 = !flag10;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v4+8]");
		bool flag11 = (UnityEngine.Object)0 != null;
		bool flag12 = !flag11;
		UnityEngine.Object obj31 = null;
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v4+8]");
			if ((nint)0 == 0)
			{
				goto IL_0620;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X21_v5 (UnityEngine.Object)+B0]");
			obj31 = (UnityEngine.Object)0;
		}
		object obj32 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X0_v27+E4]");
		bool flag13 = (nint)0 == 0;
		object obj33 = !flag13;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v4+8]");
		if ((UnityEngine.Object)0 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v4+8]");
			if ((nint)0 == 0)
			{
				goto IL_0620;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X21_v5 (UnityEngine.Object)+A4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0940]");
				obj18 = 0;
				goto IL_07e6;
			}
		}
		object obj34 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v35+E4]");
		bool flag14 = (nint)0 == 0;
		object obj35 = !flag14;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag15 = obj31 == null;
		bool flag16 = !flag15;
		object obj36 = !flag16;
		if (obj36 != null)
		{
			goto IL_0606;
		}
		if ((object)obj31 != null)
		{
			if (!((NetworkRunner)obj31).IsRunning)
			{
				goto IL_0606;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v4+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X20_v7 (UnityEngine.Object)+2F8]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X20_v7 (UnityEngine.Object)+2F8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0950]");
					object format3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X21_v5 (UnityEngine.Object)+78]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v22+10]");
					object arg4 = default;
					string text5 = string.Format((string)format3, num, 0, arg4);
					bool isSharedModeMasterClient = ((NetworkRunner)obj31).IsSharedModeMasterClient;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0960]");
					object obj38 = 0;
					bool flag17 = !isSharedModeMasterClient;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60D8]");
					object obj39 = 0;
					object obj40 = !flag17;
					object obj41 = ~obj40;
					if (obj41 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0970]");
						obj38 = 0;
					}
					return text5 + (string)obj38 + (string)obj39 + text;
				}
			}
		}
		goto IL_0620;
		IL_062e:
		return (string)(object)new IndexOutOfRangeException();
	}

	private void OnGUI()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CCCC");
	}

	public GillaFreecam()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0A90]");
		object obj2 = 0;
		speed = 4f;
		pressablesAt = -10f;
		object obj3 = this + 96;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = this + 104;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Pressable> list = default;
		list._002Ector();
		object obj5 = this + 112;
		obj5 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
