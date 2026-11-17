using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using GorillaLocomotion;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.XR;

public class GillaDoorButton : MonoBehaviour
{
	public GillaDoor door;

	public Transform cap;

	public float reach;

	public float travel;

	public Color readyColour;

	public Color busyColour;

	public AudioClip[] clickSounds;

	private const float Again = default(float);

	private static readonly int BaseColorId;

	private BoxCollider box;

	private Renderer capRenderer;

	private MaterialPropertyBlock block;

	private Vector3 capRest;

	private bool touching;

	private int shown;

	private float nextPush;

	private float depth;

	public bool ShowsBusy
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			object obj = shown - 1;
			return obj == null;
		}
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_011e: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj3 = this + 96;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X20_v3-38]");
		if (!((UnityEngine.Object)0 == null))
		{
			Vector3 localPosition = cap.localPosition;
			Vector3 vector = default;
			capRest = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4410]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			object obj8 = this + 104;
			object obj9 = default;
			obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private unsafe void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_082f: Expected Obj, but got I4
		//IL_084d: Expected Obj, but got I
		//IL_0877: Expected Obj, but got I4
		//IL_08af: Expected Obj, but got I4
		//IL_0b57: Expected Obj, but got I
		//IL_0b79: Expected Obj, but got I4
		//IL_0232: Expected VT, but got I4
		//IL_023f: Expected I4, but got I8
		//IL_0901: Expected Obj, but got I4
		//IL_0100: Expected I4, but got I8
		//IL_011a: Expected Obj, but got I4
		//IL_0123: Expected VT, but got I4
		//IL_0278: Expected Obj, but got I4
		//IL_02bf: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_0192: Expected Obj, but got I4
		//IL_019b: Expected VT, but got I4
		//IL_0928: Expected Obj, but got I
		//IL_0940: Expected Obj, but got I
		//IL_01e4: Expected VT, but got F4
		//IL_06e3: Expected F4, but got I4
		//IL_0976: Expected Obj, but got I
		//IL_098e: Expected Obj, but got I
		//IL_0a2a: Invalid comparison between F4 and I4
		//IL_0a3d: Expected Obj, but got F4
		//IL_0a45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4a: Expected Obj, but got Unknown
		//IL_0a7b: Expected Obj, but got I4
		//IL_0214: Expected VT, but got F4
		//IL_0224: Expected Obj, but got I4
		//IL_0315: Expected Obj, but got I
		//IL_0ac4: Expected Obj, but got I4
		//IL_0adc: Invalid comparison between F4 and I4
		//IL_0aed: Expected Obj, but got I4
		//IL_0377: Expected Obj, but got I4
		//IL_0791: Expected Obj, but got I4
		//IL_09d4: Expected Obj, but got I
		//IL_0b3a: Expected VT, but got I4
		//IL_03ed: Expected Obj, but got I
		//IL_0404: Expected VT, but got I4
		//IL_07fb: Expected VT, but got I4
		//IL_0434: Expected Obj, but got I
		//IL_045e: Expected Obj, but got I4
		//IL_04a8: Expected VT, but got Ref
		//IL_04c4: Expected Obj, but got I4
		//IL_04d6: Expected Obj, but got I4
		//IL_04e3: Expected VT, but got F8
		//IL_04eb: Expected Obj, but got Ref
		//IL_0530: Expected Obj, but got I4
		//IL_056b: Expected Obj, but got I4
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected Obj, but got Unknown
		//IL_05a0: Expected Obj, but got I4
		//IL_05a9: Expected Obj, but got I4
		//IL_05bb: Expected Obj, but got I4
		//IL_05c8: Expected VT, but got F8
		//IL_0615: Expected Obj, but got I4
		//IL_0627: Expected Obj, but got I4
		//IL_062f: Expected VT, but got F4
		//IL_065f: Expected I4, but got I8
		//IL_0668: Expected Obj, but got I4
		//IL_067a: Expected Obj, but got I4
		//IL_0682: Expected VT, but got F4
		//IL_0698: Expected Obj, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2;
		if (door != null)
		{
			bool busy = door.Busy;
			flag2 = busy;
		}
		else
		{
			flag2 = false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj4;
		}
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v11+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num3;
		if ((UnityEngine.Object)obj10 != null)
		{
			int num = TouchingHand((Player)obj10);
			int num2 = (int)(num & 0x80000000L);
			bool flag6 = num2 == 0;
			object obj12 = !flag6;
			RaycastHit raycastHit = (RaycastHit)0;
			num3 = num;
			UnityEngine.Object obj13 = (UnityEngine.Object)obj10;
			if (obj12 == null)
			{
				bool flag7 = !touching;
				object obj14 = !flag7;
				object obj15 = obj14 | flag2;
				object obj16 = obj15 & 1;
				bool flag8 = obj16 == null;
				object obj17 = !flag8;
				raycastHit = (RaycastHit)0;
				num3 = num;
				obj13 = (UnityEngine.Object)obj10;
				if (obj17 == null)
				{
					float time = Time.time;
					float num4 = nextPush;
					bool flag9 = time < nextPush;
					raycastHit = (RaycastHit)time;
					num3 = num;
					obj13 = (UnityEngine.Object)obj10;
					if (!flag9)
					{
						Push(num);
						raycastHit = (RaycastHit)time;
						num3 = num;
						obj13 = (UnityEngine.Object)num;
					}
				}
			}
		}
		else
		{
			RaycastHit raycastHit = (RaycastHit)0;
			num3 = -1;
			UnityEngine.Object obj13 = null;
		}
		int num5 = ~num3;
		int num6 = num5 >> 31;
		touching = (byte)num6 != 0;
		bool isDeviceActive = XRSettings.isDeviceActive;
		bool flag10 = !isDeviceActive;
		object obj18 = !flag10;
		int num7 = 0;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
			object obj19 = 0;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v25+A0]");
			object obj21 = 0;
			bool flag11 = obj21 == null;
			num7 = 0;
			if (flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
				object obj22 = 0;
				object obj23 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v30+A0]");
				object obj24 = 0;
				object obj25 = obj24;
				bool flag12 = obj24 == null;
				num7 = 0;
				if (!flag12)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v32+1C0]");
					bool wasPressedThisFrame = ((ButtonControl)0).wasPressedThisFrame;
					bool flag13 = !wasPressedThisFrame;
					num7 = 0;
					UnityEngine.Object obj13 = null;
					if (!flag13)
					{
						Camera main = Camera.main;
						object obj26 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v33+E4]");
						bool flag14 = (nint)0 == 0;
						object obj27 = !flag14;
						if (obj27 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag15 = main != null;
						bool flag16 = !flag15;
						num7 = 0;
						obj13 = null;
						if (!flag16)
						{
							Camera main2 = Camera.main;
							object obj28 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v36+A0]");
							object obj29 = 0;
							object obj30 = obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v38+188]");
							Vector2 vector = ((InputControl<Vector2>)0).ReadValue();
							Ray ray = main2.ScreenPointToRay((Vector3)0);
							GameObject gameObject = base.gameObject;
							int layer = gameObject.layer;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
							object obj31 = 0;
							object obj32 = obj31;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v44+E4]");
							bool flag17 = (nint)0 == 0;
							object obj33 = !flag17;
							if (obj33 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							num7 = 1 << layer;
							object obj34 = default;
							bool flag18 = Physics.Raycast((Ray)(&obj34), out var hitInfo, 5f, num7, (QueryTriggerInteraction)2);
							bool flag19 = !flag18;
							object obj35 = 0;
							QueryTriggerInteraction queryTriggerInteraction = (QueryTriggerInteraction)2;
							object obj36 = 0;
							RaycastHit raycastHit = (RaycastHit)5.0;
							obj13 = (UnityEngine.Object)(&hitInfo);
							if (!flag19)
							{
								Collider collider = hitInfo.collider;
								object obj37 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v46+E4]");
								bool flag20 = (nint)0 == 0;
								object obj38 = !flag20;
								if (obj38 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag21 = collider == box;
								object obj39 = !flag21;
								object obj40 = flag2 | obj39;
								object obj41 = obj40 & 1;
								bool flag22 = obj41 == null;
								object obj42 = !flag22;
								obj35 = 0;
								queryTriggerInteraction = (QueryTriggerInteraction)2;
								obj36 = 0;
								raycastHit = (RaycastHit)5.0;
								num7 = 0;
								obj13 = box;
								if (obj42 == null)
								{
									float time2 = Time.time;
									float num4 = nextPush;
									bool flag23 = time2 < nextPush;
									obj35 = 0;
									queryTriggerInteraction = (QueryTriggerInteraction)2;
									obj36 = 0;
									raycastHit = (RaycastHit)time2;
									num7 = 0;
									obj13 = box;
									if (!flag23)
									{
										Push(-1);
										obj35 = 0;
										queryTriggerInteraction = (QueryTriggerInteraction)2;
										obj36 = 0;
										raycastHit = (RaycastHit)time2;
										num7 = 0;
										obj13 = (UnityEngine.Object)4294967295L;
									}
								}
							}
						}
					}
				}
			}
		}
		object obj43 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v19+E4]");
		bool flag24 = (nint)0 == 0;
		object obj44 = !flag24;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag25 = cap == null;
		bool flag26 = !flag25;
		object obj45 = !flag26;
		if (obj45 != null)
		{
			return;
		}
		Show(flag2);
		float num8;
		float num11;
		float num12;
		if (~(touching ? 1u : 0u) == 0)
		{
			num8 = depth;
		}
		else
		{
			float time3 = Time.time;
			num8 = depth;
			float num9 = nextPush;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB24]");
			float num10 = num9 + 0f;
			bool flag27 = !(time3 < num10);
			num11 = 0f;
			num12 = depth;
			if (flag27)
			{
				goto IL_09e1;
			}
		}
		num11 = travel;
		num12 = num8;
		goto IL_09e1;
		IL_09e1:
		float deltaTime = Time.deltaTime;
		float num13 = deltaTime * travel;
		float num14 = num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num15 = num14 / 0f;
		float num16 = num11 - num12;
		bool flag28 = num16 < 0f;
		object obj46 = num16 ^ num16;
		object obj47 = num16 & obj46;
		bool flag29 = (nint)obj47 < 0;
		float num17 = 0f - num15;
		bool flag30 = flag28 == flag29;
		object obj48 = !flag30;
		object obj49 = ~obj48;
		float num18 = ((obj49 != null) ? num15 : num17);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num19 = num12 + num18;
		bool flag31 = num17 < num15;
		object obj50 = !flag31;
		float num20 = num17 - num15;
		bool flag32 = num20 == 0f;
		object obj51 = !flag32;
		object obj52 = obj50 & obj51;
		object obj53 = ~obj52;
		float num21 = ((obj53 != null) ? num11 : num19);
		depth = num21;
		Transform transform = base.transform;
		Vector3 forward = transform.forward;
		Transform parent = cap.parent;
		object obj54 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v18+E4]");
		bool flag33 = (nint)0 == 0;
		object obj55 = !flag33;
		if (obj55 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (parent != null)
		{
			Transform parent2 = cap.parent;
			Vector3 vector2 = parent2.InverseTransformVector((Vector3)0);
		}
		cap.localPosition = (Vector3)0;
	}

	private void Show(bool moving)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00b4: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I
		//IL_01a3: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I
		//IL_01d6: Expected Obj, but got I
		//IL_01e8: Expected VT, but got I4
		//IL_01e8: Expected I4, but got Obj
		if (shown == (moving ? 1 : 0))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (capRenderer == null)
		{
			return;
		}
		object obj4 = this + 112;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			obj4 = materialPropertyBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		capRenderer.GetPropertyBlock((MaterialPropertyBlock)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D05A8]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v12+E4]");
		object obj9;
		if ((nint)0 != 0)
		{
			bool flag3 = !moving;
			obj9 = obj8;
			if (flag3)
			{
				goto IL_01b9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj7;
			bool flag4 = !moving;
			object obj10 = !flag4;
			obj9 = obj7;
			if (obj10 == null)
			{
				goto IL_01b9;
			}
		}
		goto IL_01c6;
		IL_01c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v12+A0]");
		object obj11 = 0;
		((MaterialPropertyBlock)obj4).SetColor((int)obj11, (Color)0);
		capRenderer.SetPropertyBlock((MaterialPropertyBlock)obj4);
		return;
		IL_01b9:
		obj8 = obj9;
		goto IL_01c6;
	}

	private int TouchingHand(Player gt)
	{
		//IL_05c6: Expected I4, but got Obj
		//IL_0043: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got F8
		//IL_00e0: Expected Obj, but got I4
		//IL_00e9: Expected VT, but got I4
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got I4
		//IL_01c9: Expected VT, but got I4
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_0279: Expected Obj, but got I4
		//IL_027e: Expected I, but got Obj
		//IL_0287: Expected Obj, but got I4
		//IL_0201: Expected Obj, but got I4
		//IL_0243: Expected VT, but got I4
		//IL_05b3: Expected I4, but got I8
		//IL_0302: Expected VT, but got I4
		//IL_0318: Invalid comparison between Obj and F8
		//IL_0329: Expected Obj, but got I4
		//IL_0342: Invalid comparison between F8 and I4
		//IL_0357: Expected Obj, but got I4
		//IL_0364: Expected I4, but got Obj
		//IL_036d: Expected VT, but got I4
		//IL_038d: Invalid comparison between Obj and F8
		//IL_039e: Expected Obj, but got I4
		//IL_03b7: Invalid comparison between F8 and I4
		//IL_03cc: Expected Obj, but got I4
		//IL_03d9: Expected I4, but got Obj
		//IL_03e2: Expected VT, but got I4
		//IL_0416: Expected Obj, but got I4
		//IL_042f: Invalid comparison between F8 and I4
		//IL_0450: Expected VT, but got I4
		//IL_0477: Invalid comparison between Obj and F8
		//IL_0488: Expected Obj, but got I4
		//IL_04a1: Invalid comparison between F8 and I4
		//IL_04b6: Expected Obj, but got I4
		//IL_04c3: Expected I4, but got Obj
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected Obj, but got Unknown
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected Obj, but got Unknown
		//IL_04f8: Expected Obj, but got I4
		//IL_04fd: Expected I, but got Obj
		//IL_0506: Expected Obj, but got I4
		//IL_050f: Expected VT, but got I4
		//IL_052e: Invalid comparison between Obj and F8
		//IL_053f: Expected Obj, but got I4
		//IL_0557: Invalid comparison between F8 and I4
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected Obj, but got Unknown
		if ((object)box != null)
		{
			Vector3 center = box.center;
			if ((object)box != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE890]");
				object obj2 = 0;
				Vector3 size = box.size;
				object obj3 = gt + 56;
				object obj4 = gt + 48;
				object obj5 = default;
				double num = (double)obj5 * 0.5;
				double num3 = default;
				double num2 = num3 * 0.5;
				object obj6 = default;
				double num4 = (double)obj6 * 0.5;
				double num5 = (double)obj6 * 0.5;
				object obj7 = 0.0 - num5;
				object obj8 = 1;
				Vector3 vector = (Vector3)0;
				int hand = 0;
				while (true)
				{
					object obj9 = obj8 & 1;
					object obj11;
					if (obj9 != null)
					{
						bool flag = (object)gt == null;
						object obj10 = !flag;
						obj11 = obj4;
						if (obj10 == null)
						{
							break;
						}
					}
					else
					{
						bool flag2 = (object)gt == null;
						obj11 = obj3;
						if (flag2)
						{
							break;
						}
					}
					object obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v9+E4]");
					bool flag3 = (nint)0 == 0;
					object obj13 = !flag3;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = (UnityEngine.Object)obj11 == null;
					bool flag5 = !flag4;
					object obj14 = !flag5;
					vector = (Vector3)0;
					nint num7;
					if (obj14 == null)
					{
						object obj15 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v16+E4]");
						bool flag6 = (nint)0 == 0;
						object obj16 = !flag6;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag7 = GillaOneArm.Resting(hand);
						bool flag8 = !flag7;
						vector = (Vector3)0;
						if (flag8)
						{
							Transform transform = base.transform;
							if (obj11 == null)
							{
								break;
							}
							Vector3 position = ((Transform)obj11).position;
							if ((object)transform == null)
							{
								break;
							}
							Vector3 vector2 = transform.InverseTransformPoint((Vector3)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
							bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num);
							object obj17 = !flag9;
							double num6 = (double)obj5 - num;
							bool flag10 = num6 == 0.0;
							object obj18 = !flag10;
							bool flag11 = (byte)(obj17 & obj18) != 0;
							vector = (Vector3)0;
							if (!flag11)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
								bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num2);
								obj17 = !flag12;
								num6 = (double)obj5 - num2;
								flag10 = num6 == 0.0;
								object obj19 = !flag10;
								flag11 = (byte)(obj17 & obj19) != 0;
								vector = (Vector3)0;
								if (!flag11)
								{
									obj5 = obj6 - obj6;
									bool flag13 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
									obj17 = !flag13;
									num6 = (double)obj5 - (double)obj7;
									flag10 = num6 == 0.0;
									flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
									vector = (Vector3)0;
									if (!flag11)
									{
										num3 = num4 + (double)reach;
										bool flag14 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3);
										obj17 = !flag14;
										num6 = (double)obj5 - num3;
										flag10 = num6 == 0.0;
										object obj20 = !flag10;
										flag11 = (byte)(obj17 & obj20) != 0;
										object obj21 = flag11 & obj8;
										object obj22 = obj21 & 1;
										bool flag15 = obj22 == null;
										object obj23 = !flag15;
										num7 = unchecked((nint)null);
										obj8 = 0;
										vector = (Vector3)0;
										hand = 1;
										if (obj23 == null)
										{
											bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3);
											object obj24 = !flag16;
											double num8 = (double)obj5 - num3;
											bool flag17 = num8 == 0.0;
											object obj25 = ~obj24;
											object obj26 = obj25 | flag17;
											object obj27 = ~obj26;
											if (obj27 == null)
											{
												return 1;
											}
											return -1;
										}
										continue;
									}
								}
							}
						}
					}
					object obj28 = obj8 & 1;
					bool flag18 = obj28 == null;
					object obj29 = !flag18;
					num7 = unchecked((nint)null);
					obj8 = 0;
					hand = 1;
					if (obj29 == null)
					{
						return -1;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public void Click()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_00cd: Expected I4, but got I8
		//IL_0085: Expected Obj, but got I4
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
		bool flag2 = door == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			bool busy = door.Busy;
			bool flag4 = !busy;
			object obj5 = !flag4;
			if (obj5 != null)
			{
				return;
			}
		}
		float time = Time.time;
		if (!(time < nextPush))
		{
			Push(-1);
		}
	}

	private void Push(int hand)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0240: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I4
		//IL_015e: Expected F4, but got I
		//IL_015e: Expected VT, but got I4
		//IL_0170: Expected I4, but got I8
		//IL_018a: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I4
		//IL_027e: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		float time = Time.time;
		object obj2 = obj;
		float num = time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		float volume = (nextPush = num + 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (door != null)
		{
			door.Press();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaQuests.Report((GillaQuests.Stat)4, 1);
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
		object obj7 = 0;
		Vector3 position = transform.position;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v16+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AudioClip[] clips = clickSounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		float pitchMax = default;
		Sfx.Play(clips, (Vector3)0, volume, 0f, pitchMax);
		int num2 = (int)(hand & 0x80000000L);
		bool flag4 = num2 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			bool flag5 = hand == 0;
			object obj11 = !flag5;
			object obj12 = ~obj11;
			XRNode node = ((obj12 != null) ? ((XRNode)4) : ((XRNode)5));
			UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
			UnityEngine.XR.InputDevice inputDevice = default;
			bool flag6 = inputDevice.SendHapticImpulse(0u, 0.5f, 0f);
		}
	}

	public GillaDoorButton()
	{
		//IL_0012: Expected F4, but got I
		//IL_003b: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107CD80]");
		reach = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107EFD0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B8A0]");
		_ = 0;
		shown = -1;
		base._002Ector();
	}

	static GillaDoorButton()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D05A8]");
		object obj2 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = num;
	}
}
