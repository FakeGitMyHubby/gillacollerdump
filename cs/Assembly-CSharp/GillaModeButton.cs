using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using GorillaLocomotion;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.XR;

public class GillaModeButton : MonoBehaviour
{
	public string room;

	public Transform arrive;

	public Transform cap;

	public Renderer lamp;

	public float reach;

	public float travel;

	public Color readyColour;

	public Color busyColour;

	public AudioClip[] clickSounds;

	private const float Again = default(float);

	private static readonly int BaseColorId;

	private BoxCollider box;

	private Renderer shows;

	private MaterialPropertyBlock block;

	private Vector3 capRest;

	private bool touching;

	private int shown;

	private float nextPush;

	private float depth;

	private bool Busy
	{
		get
		{
			//IL_0023: Invalid comparison between F4 and I4
			float time = Time.time;
			float num = time - nextPush;
			return num < 0f;
		}
	}

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
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01ec: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I4
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_0241: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj3 = this + 112;
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
		Renderer renderer;
		if ((UnityEngine.Object)0 != null)
		{
			renderer = lamp;
			object obj7 = 0;
		}
		else
		{
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v23+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = cap != null;
			bool flag4 = !flag3;
			object obj7 = 0;
			renderer = null;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4410]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
				obj7 = 0;
				Renderer renderer2 = default;
				renderer = renderer2;
			}
		}
		object obj11 = this + 120;
		obj11 = renderer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v7-48]");
		if ((UnityEngine.Object)0 != null)
		{
			Vector3 localPosition = cap.localPosition;
			Vector3 vector = default;
			capRest = vector;
		}
	}

	private unsafe void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0709: Expected Obj, but got I4
		//IL_072f: Expected Obj, but got I
		//IL_0751: Expected Obj, but got I4
		//IL_09f9: Expected Obj, but got I
		//IL_0a1b: Expected Obj, but got I4
		//IL_0167: Expected VT, but got I4
		//IL_0174: Expected I4, but got I8
		//IL_07a3: Expected Obj, but got I4
		//IL_009a: Expected I4, but got I8
		//IL_00b4: Expected Obj, but got I4
		//IL_00bd: Expected VT, but got I4
		//IL_01a1: Invalid comparison between F4 and I4
		//IL_01e0: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_00f2: Expected VT, but got I4
		//IL_0227: Expected Obj, but got I4
		//IL_07ca: Expected Obj, but got I
		//IL_07e2: Expected Obj, but got I
		//IL_0129: Expected VT, but got F4
		//IL_0818: Expected Obj, but got I
		//IL_0830: Expected Obj, but got I
		//IL_05bd: Expected F4, but got I4
		//IL_0151: Expected VT, but got F4
		//IL_08cc: Invalid comparison between F4 and I4
		//IL_08df: Expected Obj, but got F4
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Expected Obj, but got Unknown
		//IL_091d: Expected Obj, but got I4
		//IL_0273: Expected Obj, but got I
		//IL_0966: Expected Obj, but got I4
		//IL_097e: Invalid comparison between F4 and I4
		//IL_098f: Expected Obj, but got I4
		//IL_02d0: Expected Obj, but got I4
		//IL_066b: Expected Obj, but got I4
		//IL_0876: Expected Obj, but got I
		//IL_0341: Expected Obj, but got I
		//IL_09dc: Expected VT, but got I4
		//IL_0358: Expected VT, but got I4
		//IL_0388: Expected Obj, but got I
		//IL_03b2: Expected Obj, but got I4
		//IL_06d5: Expected VT, but got I4
		//IL_03fc: Expected VT, but got Ref
		//IL_0418: Expected Obj, but got I4
		//IL_042a: Expected Obj, but got I4
		//IL_046f: Expected Obj, but got I4
		//IL_04b7: Expected Obj, but got I4
		//IL_04c9: Expected Obj, but got I4
		//IL_0502: Expected Obj, but got I4
		//IL_0514: Expected Obj, but got I4
		//IL_053a: Expected I4, but got I8
		//IL_0543: Expected Obj, but got I4
		//IL_0555: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num3;
		if ((UnityEngine.Object)obj8 != null)
		{
			int num = TouchingHand((Player)obj8);
			int num2 = (int)(num & 0x80000000L);
			bool flag4 = num2 == 0;
			object obj10 = !flag4;
			RaycastHit raycastHit = (RaycastHit)0;
			num3 = num;
			if (obj10 == null)
			{
				bool flag5 = (byte)(~(touching ? 1u : 0u)) != 0;
				object obj11 = !flag5;
				raycastHit = (RaycastHit)0;
				num3 = num;
				if (obj11 == null)
				{
					float time = Time.time;
					bool flag6 = time < nextPush;
					raycastHit = (RaycastHit)time;
					num3 = num;
					if (!flag6)
					{
						Push(num);
						raycastHit = (RaycastHit)time;
						num3 = num;
					}
				}
			}
		}
		else
		{
			RaycastHit raycastHit = (RaycastHit)0;
			num3 = -1;
		}
		int num4 = ~num3;
		int num5 = num4 >> 31;
		touching = (byte)num5 != 0;
		bool isDeviceActive = XRSettings.isDeviceActive;
		bool flag7 = !isDeviceActive;
		object obj12 = !flag7;
		int num6 = 0;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
			object obj13 = 0;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v25+A0]");
			object obj15 = 0;
			bool flag8 = obj15 == null;
			num6 = 0;
			if (flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
				object obj16 = 0;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v30+A0]");
				object obj18 = 0;
				object obj19 = obj18;
				bool flag9 = obj18 == null;
				num6 = 0;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v32+1C0]");
					bool wasPressedThisFrame = ((ButtonControl)0).wasPressedThisFrame;
					bool flag10 = !wasPressedThisFrame;
					num6 = 0;
					if (!flag10)
					{
						Camera main = Camera.main;
						object obj20 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v33+E4]");
						bool flag11 = (nint)0 == 0;
						object obj21 = !flag11;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag12 = main != null;
						bool flag13 = !flag12;
						num6 = 0;
						if (!flag13)
						{
							Camera main2 = Camera.main;
							object obj22 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v36+A0]");
							object obj23 = 0;
							object obj24 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v38+188]");
							Vector2 vector = ((InputControl<Vector2>)0).ReadValue();
							Ray ray = main2.ScreenPointToRay((Vector3)0);
							GameObject gameObject = base.gameObject;
							int layer = gameObject.layer;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
							object obj25 = 0;
							object obj26 = obj25;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v44+E4]");
							bool flag14 = (nint)0 == 0;
							object obj27 = !flag14;
							if (obj27 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							num6 = 1 << layer;
							object obj28 = default;
							bool flag15 = Physics.Raycast((Ray)(&obj28), out var hitInfo, 5f, num6, (QueryTriggerInteraction)2);
							bool flag16 = !flag15;
							object obj29 = 0;
							QueryTriggerInteraction queryTriggerInteraction = (QueryTriggerInteraction)2;
							object obj30 = 0;
							if (!flag16)
							{
								Collider collider = hitInfo.collider;
								object obj31 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v46+E4]");
								bool flag17 = (nint)0 == 0;
								object obj32 = !flag17;
								if (obj32 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag18 = collider == box;
								bool flag19 = !flag18;
								obj29 = 0;
								queryTriggerInteraction = (QueryTriggerInteraction)2;
								obj30 = 0;
								num6 = 0;
								if (!flag19)
								{
									float time2 = Time.time;
									bool flag20 = time2 < nextPush;
									obj29 = 0;
									queryTriggerInteraction = (QueryTriggerInteraction)2;
									obj30 = 0;
									num6 = 0;
									if (!flag20)
									{
										Push(-1);
										obj29 = 0;
										queryTriggerInteraction = (QueryTriggerInteraction)2;
										obj30 = 0;
										num6 = 0;
									}
								}
							}
						}
					}
				}
			}
		}
		float time3 = Time.time;
		float num7 = time3 - nextPush;
		bool busy = num7 < 0f;
		Show(busy);
		object obj33 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v18+E4]");
		bool flag21 = (nint)0 == 0;
		object obj34 = !flag21;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag22 = cap == null;
		bool flag23 = !flag22;
		object obj35 = !flag23;
		if (obj35 != null)
		{
			return;
		}
		float num8;
		float num12;
		float num13;
		if (~(touching ? 1u : 0u) == 0)
		{
			num8 = depth;
		}
		else
		{
			float time4 = Time.time;
			num8 = depth;
			double num9 = (double)nextPush + -1.5;
			double num10 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			double num11 = num10 + 0.0;
			bool flag24 = !((double)time4 < num11);
			num12 = 0f;
			num13 = depth;
			if (flag24)
			{
				goto IL_0883;
			}
		}
		num12 = travel;
		num13 = num8;
		goto IL_0883;
		IL_0883:
		float deltaTime = Time.deltaTime;
		float num14 = deltaTime * travel;
		float num15 = num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num16 = num15 / 0f;
		float num17 = num12 - num13;
		bool flag25 = num17 < 0f;
		object obj36 = num17 ^ num17;
		object obj37 = num17 & obj36;
		bool flag26 = (nint)obj37 < 0;
		float num18 = 0f - num16;
		bool flag27 = flag25 == flag26;
		object obj38 = !flag27;
		object obj39 = ~obj38;
		float num19 = ((obj39 != null) ? num16 : num18);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num20 = num13 + num19;
		bool flag28 = num18 < num16;
		object obj40 = !flag28;
		float num21 = num18 - num16;
		bool flag29 = num21 == 0f;
		object obj41 = !flag29;
		object obj42 = obj40 & obj41;
		object obj43 = ~obj42;
		float num22 = ((obj43 != null) ? num12 : num20);
		depth = num22;
		Transform transform = base.transform;
		Vector3 forward = transform.forward;
		Transform parent = cap.parent;
		object obj44 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v18+E4]");
		bool flag30 = (nint)0 == 0;
		object obj45 = !flag30;
		if (obj45 == null)
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

	public unsafe static bool Arrival(NetworkBootstrap.Lobby kind, out Transform at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03c7: Expected Obj, but got I
		//IL_0404: Expected Obj, but got I4
		//IL_03b7: Expected I4, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00eb: Expected Obj, but got I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected I4, but got Unknown
		//IL_0135: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I
		//IL_01bc: Expected Obj, but got I4
		//IL_01eb: Expected Obj, but got I
		//IL_029e: Expected Obj, but got I
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		//IL_0327: Expected Obj, but got I4
		//IL_034e: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got I4
		//IL_0269: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2658]");
		object obj2 = 0;
		ref Transform reference = ref *(Transform*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD840");
		object obj6 = default;
		if (obj6 == null)
		{
			goto IL_039b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
		bool flag2 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
		bool flag3 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
		object obj8 = num ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
		object obj9 = 0 & obj8;
		bool flag4 = (nint)obj9 < 0;
		bool flag5 = flag2 == flag4;
		object obj10 = !flag3;
		object obj11 = flag5 & obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
		bool flag6 = (nint)0 < (nint)1;
		object obj12 = obj11;
		if (flag6)
		{
			goto IL_0388;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj13 = 0;
		object obj14 = 0;
		obj12 = obj11;
		UnityEngine.Object obj15 = null;
		object obj29;
		while (true)
		{
			bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
			object obj16 = !flag7;
			if (obj16 != null)
			{
				break;
			}
			object obj17 = obj6 + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v9+20]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v9+20]");
			if ((nint)0 != 0)
			{
				object obj19 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v15+E4]");
				bool flag8 = (nint)0 == 0;
				object obj20 = !flag8;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X27_v6+28]");
				bool flag9 = (UnityEngine.Object)0 != null;
				bool flag10 = !flag9;
				obj15 = null;
				if (!flag10)
				{
					object obj21 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v20+E4]");
					bool flag11 = (nint)0 == 0;
					object obj22 = !flag11;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X27_v6+20]");
					NetworkBootstrap.Lobby lobby = NetworkBootstrap.KindOf((string)0);
					bool flag12 = lobby == kind;
					obj15 = null;
					if (flag12)
					{
						goto IL_0369;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
				obj7 = 0;
				obj14++;
				object obj23 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
				object obj24 = obj23 - 0;
				bool flag13 = (nint)obj24 < 0;
				object obj25 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
				object obj26 = obj25 ^ 0;
				object obj27 = obj14 ^ obj24;
				object obj28 = obj26 & obj27;
				bool flag14 = (nint)obj28 < 0;
				bool flag15 = flag13 == flag14;
				obj29 = !flag15;
				object obj30 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+18]");
				bool flag16 = (nint)obj30 < 0;
				obj12 = obj29;
				obj5 = 0;
				if (flag16)
				{
					continue;
				}
				goto IL_035c;
			}
			goto IL_039b;
		}
		goto IL_03a9;
		IL_039b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_03a9;
		IL_0388:
		return (byte)(obj12 & 1) != 0;
		IL_03a9:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
		IL_035c:
		obj12 = obj29;
		goto IL_0388;
		IL_0369:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X27_v6+28]");
		reference = ref *(Transform*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		goto IL_0388;
	}

	public void Click()
	{
		//IL_003a: Expected I4, but got I8
		float time = Time.time;
		if (!(time < nextPush))
		{
			Push(-1);
		}
	}

	private void Show(bool busy)
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
		if (shown == (busy ? 1 : 0))
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
		if (shows == null)
		{
			return;
		}
		object obj4 = this + 128;
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
		shows.GetPropertyBlock((MaterialPropertyBlock)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0CB0]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v12+E4]");
		object obj9;
		if ((nint)0 != 0)
		{
			bool flag3 = !busy;
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
			bool flag4 = !busy;
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
		shows.SetPropertyBlock((MaterialPropertyBlock)obj4);
		return;
		IL_01b9:
		obj8 = obj9;
		goto IL_01c6;
	}

	private int TouchingHand(Player gt)
	{
		//IL_060f: Expected I4, but got Obj
		//IL_0043: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got F8
		//IL_00e7: Expected F8, but got I
		//IL_00f0: Expected Obj, but got I4
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected Obj, but got Unknown
		//IL_011d: Expected Obj, but got I4
		//IL_0187: Expected Obj, but got I4
		//IL_01cc: Expected Obj, but got I4
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_027d: Expected Obj, but got I4
		//IL_0282: Expected I, but got Obj
		//IL_028b: Expected Obj, but got I4
		//IL_0209: Expected Obj, but got I4
		//IL_05fc: Expected I4, but got I8
		//IL_0306: Expected VT, but got I4
		//IL_032d: Expected Obj, but got I4
		//IL_0346: Invalid comparison between F8 and I4
		//IL_035b: Expected Obj, but got I4
		//IL_0368: Expected I4, but got Obj
		//IL_039e: Expected Obj, but got I4
		//IL_03b7: Invalid comparison between F8 and I4
		//IL_03cc: Expected Obj, but got I4
		//IL_03d9: Expected I4, but got Obj
		//IL_0412: Expected Obj, but got I4
		//IL_042b: Invalid comparison between F8 and I4
		//IL_04c4: Invalid comparison between Obj and F8
		//IL_04d5: Expected Obj, but got I4
		//IL_04ee: Invalid comparison between F8 and I4
		//IL_0503: Expected Obj, but got I4
		//IL_0510: Expected I4, but got Obj
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected Obj, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_0545: Expected Obj, but got I4
		//IL_054a: Expected I, but got Obj
		//IL_0553: Expected Obj, but got I4
		//IL_0577: Invalid comparison between Obj and F8
		//IL_0588: Expected Obj, but got I4
		//IL_05a0: Invalid comparison between F8 and I4
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected Obj, but got Unknown
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
				object obj6 = default;
				double num2 = (double)obj6 * 0.5;
				double num4 = default;
				double num3 = num4 * 0.5;
				double num5 = (double)obj6 * 0.5;
				object obj7 = 0.0 - num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
				double num6 = 0.0;
				object obj8 = 1;
				UnityEngine.Object obj9 = null;
				int hand = 0;
				while (true)
				{
					object obj10 = obj8 & 1;
					object obj12;
					if (obj10 != null)
					{
						bool flag = (object)gt == null;
						object obj11 = !flag;
						obj12 = obj4;
						if (obj11 == null)
						{
							break;
						}
					}
					else
					{
						bool flag2 = (object)gt == null;
						obj12 = obj3;
						if (flag2)
						{
							break;
						}
					}
					object obj13 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v9+E4]");
					bool flag3 = (nint)0 == 0;
					object obj14 = !flag3;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = (UnityEngine.Object)obj12 == null;
					bool flag5 = !flag4;
					object obj15 = !flag5;
					obj9 = null;
					nint num10;
					if (obj15 == null)
					{
						object obj16 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v16+E4]");
						bool flag6 = (nint)0 == 0;
						object obj17 = !flag6;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag7 = GillaOneArm.Resting(hand);
						bool flag8 = !flag7;
						obj9 = null;
						if (flag8)
						{
							Transform transform = base.transform;
							if (obj12 == null)
							{
								break;
							}
							Vector3 position = ((Transform)obj12).position;
							if ((object)transform == null)
							{
								break;
							}
							Vector3 vector = transform.InverseTransformPoint((Vector3)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
							bool flag9 = num6 < num;
							object obj18 = !flag9;
							double num7 = num6 - num;
							bool flag10 = num7 == 0.0;
							object obj19 = !flag10;
							bool flag11 = (byte)(obj18 & obj19) != 0;
							obj9 = null;
							if (!flag11)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
								bool flag12 = num6 < num3;
								obj18 = !flag12;
								num7 = num6 - num3;
								flag10 = num7 == 0.0;
								object obj20 = !flag10;
								flag11 = (byte)(obj18 & obj20) != 0;
								obj9 = null;
								if (!flag11)
								{
									object obj21 = obj6 - obj6;
									bool flag13 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
									obj18 = !flag13;
									num7 = (double)obj21 - (double)obj7;
									flag10 = num7 == 0.0;
									flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
									obj9 = null;
									if (!flag11)
									{
										Transform transform2 = base.transform;
										if ((object)transform2 == null)
										{
											break;
										}
										Vector3 lossyScale = transform2.lossyScale;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
										float num8 = reach;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
										float num9 = num8 / 0f;
										num6 = num2 + (double)num9;
										bool flag14 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num6);
										obj18 = !flag14;
										num7 = (double)obj21 - num6;
										flag10 = num7 == 0.0;
										object obj22 = !flag10;
										flag11 = (byte)(obj18 & obj22) != 0;
										object obj23 = flag11 & obj8;
										object obj24 = obj23 & 1;
										bool flag15 = obj24 == null;
										object obj25 = !flag15;
										num10 = unchecked((nint)null);
										obj8 = 0;
										obj9 = null;
										hand = 1;
										if (obj25 == null)
										{
											bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num6);
											object obj26 = !flag16;
											double num11 = (double)obj21 - num6;
											bool flag17 = num11 == 0.0;
											object obj27 = ~obj26;
											object obj28 = obj27 | flag17;
											object obj29 = ~obj28;
											if (obj29 == null)
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
					object obj30 = obj8 & 1;
					bool flag18 = obj30 == null;
					object obj31 = !flag18;
					num10 = unchecked((nint)null);
					obj8 = 0;
					hand = 1;
					if (obj31 == null)
					{
						return -1;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private void Push(int hand)
	{
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		//IL_0079: Expected F8, but got I
		//IL_0089: Expected F4, but got I
		//IL_0099: Expected F4, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00ca: Expected VT, but got I4
		//IL_00dc: Expected I4, but got I8
		//IL_00f6: Expected Obj, but got I4
		//IL_019f: Expected Obj, but got I4
		//IL_01e4: Expected VT, but got I4
		//IL_013c: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I4
		//IL_0699: Expected F4, but got I
		//IL_06bc: Expected F4, but got I
		//IL_0705: Expected Obj, but got I4
		//IL_0224: Expected VT, but got I4
		//IL_0224: Expected VT, but got I4
		//IL_0249: Expected VT, but got I4
		//IL_07f3: Expected Obj, but got I
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected Obj, but got Unknown
		//IL_080e: Expected Obj, but got I
		//IL_0845: Expected Obj, but got I4
		//IL_02e0: Expected Obj, but got I
		//IL_02f2: Expected Obj, but got I
		//IL_04ad: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got I
		//IL_04c2: Expected Obj, but got I
		//IL_04d2: Expected Obj, but got I
		//IL_051d: Expected Obj, but got I
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got Unknown
		//IL_055a: Expected Obj, but got I4
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected Obj, but got Unknown
		//IL_03d6: Expected Obj, but got I
		//IL_059b: Expected Obj, but got I
		//IL_03fe: Expected Obj, but got I4
		//IL_0371: Expected Obj, but got I4
		//IL_072c: Expected Obj, but got I
		//IL_0735: Expected Obj, but got I4
		//IL_03a0: Expected Obj, but got I
		//IL_05bd: Expected Obj, but got I
		//IL_0429: Expected Obj, but got I
		//IL_044b: Expected Obj, but got I
		//IL_0469: Expected Obj, but got I4
		//IL_0620: Expected Obj, but got I
		//IL_05f2: Expected Obj, but got I
		//IL_0774: Expected Obj, but got I
		//IL_07b7: Expected Obj, but got I4
		float time = Time.time;
		float num = (nextPush = time + 1.5f);
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
		object obj = 0;
		Vector3 position = transform.position;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		double num2 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB8]");
		float num3 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B004]");
		float num4 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		float num5 = default;
		Sfx.Play(clickSounds, (Vector3)0, num, 1.5f, num5);
		int num6 = (int)(hand & 0x80000000L);
		bool flag2 = num6 == 0;
		object obj5 = !flag2;
		double num7 = num;
		uint num8 = 0u;
		float num9 = 1.5f;
		if (obj5 == null)
		{
			bool flag3 = hand == 0;
			object obj6 = !flag3;
			object obj7 = ~obj6;
			XRNode node = ((obj7 != null) ? ((XRNode)4) : ((XRNode)5));
			UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
			num9 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
			UnityEngine.XR.InputDevice inputDevice = default;
			bool flag4 = inputDevice.SendHapticImpulse(0u, 0.5f, 0f);
			num7 = 0.5;
			num8 = 0u;
		}
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = arrive != null;
		bool flag7 = !flag6;
		Vector3 vector = (Vector3)0;
		if (!flag7)
		{
			Vector3 position2 = arrive.position;
			Vector3 forward = arrive.forward;
			bool flag8 = GillaTeleport.To((Vector3)0, (Vector3)0);
			num4 = num5;
			num3 = num9;
			num2 = num7;
			vector = (Vector3)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v17+E4]");
		bool flag9 = (nint)0 == 0;
		object obj12 = !flag9;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v21+E4]");
		bool flag10 = (nint)0 == 0;
		object obj14 = !flag10;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v21+A0]");
		object obj15 = 0;
		object obj16 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v12+8]");
		UnityEngine.Object obj17 = (UnityEngine.Object)0;
		NetworkBootstrap.Lobby lobby = NetworkBootstrap.KindOf((string)obj16);
		object obj18 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v13+E4]");
		bool flag11 = (nint)0 == 0;
		object obj19 = !flag11;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v12+8]");
		if ((UnityEngine.Object)0 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v12+8]");
			NetworkBootstrap.Lobby going = ((NetworkBootstrap)0).Going;
			if (going == lobby)
			{
				object obj21 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v50+E4]");
				bool flag12 = (nint)0 == 0;
				object obj22 = !flag12;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X20_v6 (UnityEngine.Object)+B0]");
				if (!((UnityEngine.Object)0 == null))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X20_v6 (UnityEngine.Object)+B0]");
					bool isRunning = ((NetworkRunner)0).IsRunning;
					bool flag13 = !isRunning;
					object obj23 = !flag13;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X20_v6 (UnityEngine.Object)+A4]");
						if ((nint)0 == 0)
						{
							goto IL_03c1;
						}
					}
					goto IL_049c;
				}
			}
			goto IL_03c1;
		}
		goto IL_049c;
		IL_03c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v12+8]");
		string text = ((NetworkBootstrap)0).TakeWaiting(lobby);
		bool flag14 = text._stringLength == 0;
		object obj24 = !flag14;
		string text2 = text;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v12+8]");
			string text3 = ((NetworkBootstrap)0).CarriedTo(lobby);
			text2 = text3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v12+8]");
		((NetworkBootstrap)0).JoinLobby(lobby, text2);
		object obj25 = 0;
		goto IL_073a;
		IL_073a:
		object obj26 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2640]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2638]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X9_v4+10]");
		bool flag15 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X9_v4+10]");
		bool flag16 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X9_v4+10]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X9_v4+10]");
		object obj29 = num10 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X9_v4+10]");
		object obj30 = 0 & obj29;
		bool flag17 = (nint)obj30 < 0;
		bool flag18 = flag15 == flag17;
		object obj31 = !flag16;
		object obj32 = flag18 & obj31;
		object obj33 = ~obj32;
		object obj34;
		if (obj33 == null)
		{
			obj34 = obj16;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF60]");
			obj34 = 0;
		}
		string text4;
		if (obj25 != null)
		{
			text4 = (string)obj20;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2648]");
			object obj35 = 0;
			string text6;
			if (text2._stringLength > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2188]");
				object obj36 = 0;
				string text5 = (string)obj36 + text2;
				text6 = text5;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2650]");
				object obj37 = 0;
				text6 = (string)obj37;
			}
			string text7 = (string)obj35 + text6;
			text4 = text7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj38 = 0;
		string message = (string)obj27 + (string)obj34 + (string)obj28 + text4;
		object obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v16+E4]");
		bool flag19 = (nint)0 == 0;
		object obj40 = !flag19;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		return;
		IL_049c:
		text2 = (string)obj20;
		obj25 = 1;
		goto IL_073a;
	}

	public GillaModeButton()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0044: Expected F4, but got I
		//IL_006d: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5EF8]");
		object obj = 0;
		object obj2 = this + 32;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F760]");
		reach = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107EFF0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
		_ = 0;
		shown = -1;
		base._002Ector();
	}

	static GillaModeButton()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0CB0]");
		object obj2 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = num;
	}
}
