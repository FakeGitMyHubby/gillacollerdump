using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.XR;

public class GillaHeadlamp : MonoBehaviour
{
	public float range;

	public float angle;

	public float intensity;

	public Color colour;

	public AudioClip clickOn;

	public AudioClip clickOff;

	private static bool Lit__BackingField;

	private static GillaHeadlamp instance;

	private Light lamp;

	private Transform head;

	private bool was;

	public static bool Lit
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0032: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61C8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61C8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+A0]");
			object obj3 = 0;
			obj3 = value;
		}
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_02b7: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I4
		//IL_020c: Expected Obj, but got I
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0248: Expected VT, but got Obj
		//IL_017a: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I4
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_02e8: Expected Obj, but got I4
		//IL_02fe: Expected Obj, but got I
		//IL_01b4: Expected Obj, but got I
		//IL_01d6: Expected Obj, but got I4
		//IL_01df: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CE0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		Camera main = Camera.main;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Component component;
		if (main != null)
		{
			Camera main2 = Camera.main;
			bool flag2 = (object)main2 == null;
			object obj5 = !flag2;
			object obj6 = 0;
			component = main2;
			if (obj5 == null)
			{
				goto IL_0273;
			}
		}
		else
		{
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v27+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj9 = default;
			bool flag4 = obj9 != null;
			bool flag5 = !flag4;
			object obj6 = 0;
			if (!flag5)
			{
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v33+E4]");
				bool flag6 = (nint)0 == 0;
				object obj11 = !flag6;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3 (UnityEngine.Object)+20]");
				bool flag7 = (UnityEngine.Object)0 != null;
				bool flag8 = !flag7;
				obj6 = 0;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3 (UnityEngine.Object)+20]");
					component = (Component)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3 (UnityEngine.Object)+20]");
					bool flag9 = (nint)0 == 0;
					object obj12 = !flag9;
					obj6 = 0;
					if (obj12 == null)
					{
						goto IL_0273;
					}
					goto IL_02c5;
				}
			}
			component = this;
		}
		goto IL_02c5;
		IL_02c5:
		Transform transform = component.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61C8]");
		object obj13 = 0;
		object obj14 = this + 88;
		obj14 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Light light = MakeLamp((Transform)obj14, range, angle, intensity, (Color)transform);
		object obj15 = this + 80;
		obj15 = light;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj16 = obj13;
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v7+A0]");
		object obj18 = (nint)0 + (nint)8;
		obj18 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return;
		IL_0273:
		throw new NullReferenceException();
	}

	private void OnDestroy()
	{
		//IL_008a: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I4
		//IL_00ea: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5+A0]");
		object obj5 = 0;
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v6+8]");
		if ((UnityEngine.Object)0 == this)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7+A0]");
			object obj8 = (nint)0 + (nint)8;
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static void Set(bool on)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I
		//IL_0181: Expected Obj, but got I
		//IL_019b: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+8]");
		if (!((UnityEngine.Object)0 != null))
		{
			return;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v8+A0]");
		object obj8 = 0;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		if ((nint)obj9 != (on ? 1 : 0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!MonsterPlayer.IsMonster)
			{
				object obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v15+A0]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v16+8]");
				((GillaHeadlamp)0).Switch();
			}
		}
	}

	public static Light MakeLamp(Transform head, float range, float angle, float intensity, Color colour)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		//IL_00ae: Expected VT, but got I4
		//IL_014b: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector((string)obj2);
		if ((object)gameObject != null)
		{
			Transform transform = gameObject.transform;
			if ((object)transform != null)
			{
				transform.SetParent(head, worldPositionStays: false);
				Transform transform2 = gameObject.transform;
				if ((object)transform2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA3A8]");
					object obj3 = 0;
					transform2.localPosition = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
					Light light = default;
					if ((object)light != null)
					{
						light.type = (LightType)0;
						light.range = range;
						light.spotAngle = angle;
						float num = angle;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
						float innerSpotAngle = num * 0f;
						light.innerSpotAngle = innerSpotAngle;
						light.intensity = intensity;
						light.color = (Color)0;
						light.shadows = (LightShadows)0;
						light.renderMode = (LightRenderMode)1;
						light.enabled = false;
						return light;
					}
				}
			}
		}
		return (Light)(object)new NullReferenceException();
	}

	private void Update()
	{
		//IL_01c3: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I
		//IL_001b: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0231: Expected Obj, but got I
		//IL_0249: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		bool flag = Pressed();
		if (flag)
		{
			bool flag2 = (byte)(~(was ? 1u : 0u)) != 0;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v30+E4]");
				bool flag3 = (nint)0 == 0;
				object obj4 = !flag3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool isMonster = MonsterPlayer.IsMonster;
				bool flag4 = !isMonster;
				object obj5 = !flag4;
				if (obj5 == null)
				{
					Switch();
				}
			}
		}
		object obj6 = obj;
		was = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj8 = 0;
		if (MonsterPlayer.IsMonster)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61C8]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v22+A0]");
			object obj11 = 0;
			obj11 = 0;
		}
		object obj12 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v9+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (lamp != null)
		{
			bool flag7 = lamp.enabled;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61C8]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v13+A0]");
			object obj16 = 0;
			bool flag8 = obj16 == null;
			object obj17 = !flag8;
			if ((flag7 ? 1 : 0) != (nint)obj17)
			{
				bool flag9 = obj16 == null;
				bool flag10 = !flag9;
				lamp.enabled = flag10;
			}
		}
	}

	private void Switch()
	{
		//IL_0229: Expected Obj, but got I
		//IL_0241: Expected Obj, but got I
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I
		//IL_001c: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I
		//IL_019a: Expected F4, but got I
		//IL_019a: Expected F4, but got I
		//IL_0073: Expected Obj, but got I
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I4
		//IL_0161: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61C8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5+A0]");
		object obj3 = 0;
		object obj4 = obj3 ^ 1;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		object obj6 = obj5;
		if (obj4 == null)
		{
			object obj7 = 72;
		}
		else
		{
			object obj7 = 64;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHeadlamp)+v113 @ X8_v11]");
		if ((UnityEngine.Object)0 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			AudioClip[] array = default;
			if (array != null)
			{
				object obj10 = array + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaHeadlamp)+v113 @ X8_v11]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if ((object)head != null)
				{
					Vector3 position = head.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
					object obj11 = 0;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v25+E4]");
					bool flag2 = (nint)0 == 0;
					object obj13 = !flag2;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float volume = default;
					float pitchMin = default;
					float pitchMax = default;
					Sfx.Play(array, (Vector3)0, volume, pitchMin, pitchMax);
					goto IL_0166;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			throw new IndexOutOfRangeException();
		}
		goto IL_0166;
		IL_0166:
		UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode((XRNode)5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
		UnityEngine.XR.InputDevice inputDevice = default;
		bool flag3 = inputDevice.SendHapticImpulse(0u, num, 0f);
	}

	private static bool Pressed()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01c4: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I
		//IL_01fb: Expected VT, but got I
		//IL_019a: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool result;
		if (GillaDynamite.InHand(1))
		{
			result = false;
		}
		else
		{
			UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode((XRNode)5);
			UnityEngine.XR.InputDevice inputDevice = default;
			if (inputDevice.isValid)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB0]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v25+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj5 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v25+A0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v15+18]");
				if (inputDevice.TryGetFeatureValue((InputFeatureUsage<bool>)0, out var value))
				{
					bool flag3 = !value;
					bool flag4 = !flag3;
					result = flag4;
					goto IL_0187;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D08]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v10+A0]");
			object obj10 = 0;
			bool isDeviceActive = XRSettings.isDeviceActive;
			bool flag5 = !isDeviceActive;
			object obj11 = !flag5;
			result = false;
			if (obj11 == null)
			{
				bool flag6 = obj10 == null;
				result = false;
				if (!flag6)
				{
					KeyControl lKey = ((Keyboard)obj10).lKey;
					if (lKey == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					result = lKey.isPressed;
				}
			}
		}
		goto IL_0187;
		IL_0187:
		return result;
	}

	private static void Forget()
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61C8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v5+A0]");
		object obj3 = 0;
		obj3 = 0;
	}

	public GillaHeadlamp()
	{
		//IL_0018: Expected F4, but got I
		_ = 1065353216;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107DED0]");
		range = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B1F0]");
		_ = 0;
		base._002Ector();
	}
}
