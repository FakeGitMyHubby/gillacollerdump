using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering.Universal;
using UnityEngine.XR;

public class MirrorSurface : MonoBehaviour
{
	public int textureSize;

	public int quest3TextureSize;

	public int quest2TextureSize;

	public int quest3FrameSkip;

	public int quest2FrameSkip;

	public int msaa;

	public int quest2Msaa;

	public float maxDistance;

	public LayerMask reflectionMask;

	public float farClip;

	public float clipOffset;

	public bool playersOnly;

	private static readonly int TexL;

	private static readonly int TexR;

	private static readonly int LookupL;

	private static readonly int LookupR;

	private static readonly List<XRDisplaySubsystem> displays;

	private static readonly List<Renderer> unseen;

	private static readonly List<Renderer> found;

	private static int solid;

	private Camera mirrorCam;

	private readonly RenderTexture[] targets;

	private readonly Matrix4x4[] views;

	private readonly Matrix4x4[] projections;

	private readonly Matrix4x4[] lookups;

	private readonly Plane[] planes;

	private MaterialPropertyBlock block;

	private Renderer glass;

	private int size;

	private int skip;

	private int frame;

	private int samples;

	private bool hooked;

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I4
		//IL_0046: Expected I, but got Obj
		//IL_0070: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5208]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC568]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj4 = 0;
		Init();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NameTag.MakeYours();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction unityAction = default;
		unityAction._002Ector(this, (IntPtr)obj3);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.onBeforeRender += unityAction;
		hooked = true;
	}

	private void OnEnable()
	{
		//IL_014c: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I
		//IL_00c1: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I4
		bool flag = (byte)(~(hooked ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (mirrorCam != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5208]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC568]");
			object obj6 = 0;
			UnityAction unityAction = default;
			unityAction._002Ector(this, (IntPtr)obj6);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Application.onBeforeRender += unityAction;
			hooked = true;
		}
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0071: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5208]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC568]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction unityAction = default;
		unityAction._002Ector(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.onBeforeRender -= unityAction;
		hooked = false;
	}

	private void Init()
	{
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected Obj, but got Unknown
		//IL_0730: Expected Obj, but got I
		//IL_074a: Expected Obj, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I
		//IL_025c: Expected Obj, but got I4
		//IL_0264: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I4
		//IL_0275: Expected Obj, but got I4
		//IL_01d7: Expected Obj, but got I4
		//IL_01e0: Expected Obj, but got I4
		//IL_01e9: Expected Obj, but got I4
		//IL_01f2: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I4
		//IL_0325: Expected Obj, but got I4
		//IL_02ba: Expected Obj, but got I4
		//IL_0883: Expected Obj, but got I
		//IL_0899: Expected Obj, but got I
		//IL_08be: Expected Obj, but got I
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Expected Obj, but got Unknown
		//IL_0908: Expected Obj, but got I4
		//IL_0317: Expected Obj, but got I4
		//IL_02ac: Expected Obj, but got I4
		//IL_0338: Expected Obj, but got I4
		//IL_02d6: Expected Obj, but got I4
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Expected Obj, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Expected Obj, but got Unknown
		//IL_099b: Expected Obj, but got I4
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Expected Obj, but got Unknown
		//IL_07bf: Expected Obj, but got I
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected I4, but got Unknown
		//IL_084f: Expected Obj, but got I4
		//IL_0857: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Expected Obj, but got Unknown
		//IL_02c8: Expected Obj, but got I4
		//IL_034b: Expected Obj, but got I4
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected Obj, but got Unknown
		//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f5: Expected Obj, but got Unknown
		//IL_0a03: Expected I4, but got Obj
		//IL_0a2d: Expected Obj, but got I
		//IL_0aa2: Expected Obj, but got I4
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected I4, but got Unknown
		//IL_0ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Expected Obj, but got Unknown
		//IL_0afa: Expected Obj, but got I
		//IL_0380: Expected Obj, but got I
		//IL_03b7: Expected Obj, but got I4
		//IL_0414: Expected Obj, but got I4
		//IL_0478: Expected Obj, but got I
		//IL_04c0: Expected I4, but got VT
		//IL_04dc: Expected F4, but got I
		//IL_0511: Expected Obj, but got I4
		//IL_055a: Expected VT, but got I4
		//IL_0582: Expected Obj, but got I4
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected I4, but got Unknown
		//IL_05f4: Expected Obj, but got I4
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected I4, but got Unknown
		//IL_065f: Expected Obj, but got I4
		object obj = this + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		bool flag = obj == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			obj = materialPropertyBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		object obj5 = obj2;
		object obj6 = this + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = (UnityEngine.Object)obj6 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isMobilePlatform = Application.isMobilePlatform;
		string deviceName = SystemInfo.deviceName;
		string deviceModel = SystemInfo.deviceModel;
		string text = deviceName + (string)obj11 + deviceModel;
		string text2 = text.ToLowerInvariant();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC570]");
		object value = 0;
		object obj15;
		object obj16;
		object obj17;
		if (text2.Contains((string)value))
		{
			bool flag6 = !isMobilePlatform;
			object obj13 = !flag6;
			object obj14 = 0;
			obj15 = 1;
			obj16 = 0;
			obj17 = 1;
			if (obj13 == null)
			{
				goto IL_0209;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC580]");
			object value2 = 0;
			bool flag7 = text2.Contains((string)value2);
			bool flag8 = !isMobilePlatform;
			object obj14 = 0;
			obj15 = flag7;
			obj16 = 0;
			obj17 = flag7;
			if (flag8)
			{
				goto IL_0209;
			}
		}
		if (obj17 == null)
		{
			object obj18 = 44;
		}
		else
		{
			object obj18 = 48;
		}
		if (obj17 == null)
		{
			object obj19 = 36;
		}
		else
		{
			object obj19 = 40;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MirrorSurface)+v449 @ X9_v6]");
		int num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MirrorSurface)+v449 @ X9_v6]");
		object obj20 = -1;
		bool flag9 = (nint)obj20 < 0;
		bool flag10 = obj20 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MirrorSurface)+v449 @ X9_v6]");
		int num2 = (int)((nint)0 ^ (nint)1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MirrorSurface)+v449 @ X9_v6]");
		int num3 = 0 ^ obj20;
		int num4 = num2 & num3;
		bool flag11 = num4 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MirrorSurface)+v471 @ X10_v10]");
		size = 0;
		bool flag12 = flag9 == flag11;
		object obj21 = !flag10;
		object obj22 = flag12 & obj21;
		object obj23 = ~obj22;
		if (obj23 == null)
		{
			object obj14 = obj16;
			obj15 = obj17;
		}
		else
		{
			num = 1;
			object obj14 = obj16;
			obj15 = obj17;
		}
		goto IL_0759;
		IL_0209:
		size = textureSize;
		num = 1;
		goto IL_0759;
		IL_0759:
		if (obj15 == null)
		{
			object obj24 = 52;
		}
		else
		{
			object obj24 = 56;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MirrorSurface)+v451 @ X8_v13]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MirrorSurface)+v451 @ X8_v13]");
		object obj26 = -8;
		bool flag13 = (nint)obj26 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MirrorSurface)+v451 @ X8_v13]");
		object obj27 = (nint)0 ^ (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MirrorSurface)+v451 @ X8_v13]");
		object obj28 = 0 ^ obj26;
		object obj29 = obj27 & obj28;
		bool flag14 = (nint)obj29 < 0;
		bool flag15 = flag13 == flag14;
		object obj30 = !flag15;
		object obj31 = ~obj30;
		if (obj31 != null)
		{
			obj25 = 8;
		}
		object obj32 = obj25 - 1;
		bool flag16 = (nint)obj32 < 0;
		bool flag17 = obj32 == null;
		object obj33 = obj25 ^ 1;
		object obj34 = obj25 ^ obj32;
		object obj35 = obj33 & obj34;
		bool flag18 = (nint)obj35 < 0;
		bool flag19 = flag16 == flag18;
		object obj36 = !flag17;
		object obj37 = flag19 & obj36;
		object obj38 = ~obj37;
		if (obj38 != null)
		{
			obj25 = 1;
		}
		object obj39 = obj25 - 1;
		object obj40 = obj39 | obj39;
		object obj41 = obj40 | obj40;
		object obj42 = obj41 + 1;
		int num5 = obj42 >> 1;
		object obj43 = obj25 - obj42;
		object obj44 = obj42 - obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4410]");
		object obj45 = 0;
		object obj46 = obj43 - obj44;
		bool flag20 = (nint)obj46 < 0;
		object obj47 = obj43 ^ obj44;
		object obj48 = obj43 ^ obj46;
		object obj49 = obj47 & obj48;
		bool flag21 = (nint)obj49 < 0;
		skip = num;
		bool flag22 = flag20 == flag21;
		object obj50 = !flag22;
		object obj51 = ~obj50;
		int num6 = ((obj51 != null) ? (obj41 + 1) : num5);
		samples = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj52 = this + 136;
		object obj53 = default;
		obj52 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC578]");
		object obj55 = 0;
		GameObject gameObject = default;
		gameObject._002Ector((string)obj55);
		object obj56 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v30+E4]");
		bool flag23 = (nint)0 == 0;
		object obj57 = !flag23;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Application.isPlaying)
		{
			bool flag24 = (object)gameObject == null;
			object obj58 = !flag24;
			if (obj58 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			gameObject.hideFlags = (HideFlags)61;
		}
		Transform transform = gameObject.transform;
		Transform parent = base.transform;
		transform.SetParent(parent, worldPositionStays: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8558]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		object obj60 = default;
		obj6 = obj60;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		((Behaviour)obj6).enabled = false;
		((Camera)obj6).cullingMask = (int)reflectionMask;
		Camera camera = mirrorCam;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		camera.nearClipPlane = 0f;
		((Camera)obj6).farClipPlane = farClip;
		bool flag25 = !playersOnly;
		object obj61 = !flag25;
		object obj62 = ~obj61;
		CameraClearFlags clearFlags = ((obj62 != null) ? ((CameraClearFlags)1) : ((CameraClearFlags)2));
		mirrorCam.clearFlags = clearFlags;
		mirrorCam.backgroundColor = (Color)0;
		((Camera)obj6).useOcclusionCulling = false;
		object obj63 = samples - 1;
		bool flag26 = (nint)obj63 < 0;
		bool flag27 = obj63 == null;
		int num7 = samples ^ 1;
		int num8 = samples ^ obj63;
		int num9 = num7 & num8;
		bool flag28 = num9 < 0;
		bool flag29 = flag26 == flag28;
		object obj64 = !flag27;
		bool allowMSAA = (byte)((flag29 & obj64) ? 1 : 0) != 0;
		((Camera)obj6).allowMSAA = allowMSAA;
		mirrorCam.allowHDR = false;
		UniversalAdditionalCameraData universalAdditionalCameraData = CameraExtensions.GetUniversalAdditionalCameraData((Camera)obj6);
		object obj65 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v30+E4]");
		bool flag30 = (nint)0 == 0;
		object obj66 = !flag30;
		if (obj66 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (universalAdditionalCameraData != null)
		{
			universalAdditionalCameraData.m_RenderShadows = false;
			universalAdditionalCameraData.m_RenderPostProcessing = false;
			universalAdditionalCameraData.m_RequiresDepthTextureOption = (CameraOverrideOption)0;
			universalAdditionalCameraData.m_RequiresOpaqueTextureOption = (CameraOverrideOption)0;
			universalAdditionalCameraData.m_Antialiasing = (AntialiasingMode)0;
			universalAdditionalCameraData.m_AllowXRRendering = false;
			universalAdditionalCameraData.m_StopNaN = false;
		}
	}

	private unsafe void BeforeRender()
	{
		//IL_0010: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got I4
		//IL_01c7: Invalid comparison between Obj and F4
		//IL_033b: Expected Obj, but got I
		//IL_0365: Expected Obj, but got I4
		//IL_0268: Expected VT, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected VT, but got Unknown
		//IL_02c4: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = this == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null || !isActiveAndEnabled)
		{
			return;
		}
		Camera main = Camera.main;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v5+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = main == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Transform transform2 = main.transform;
		Vector3 position2 = transform2.position;
		object obj9 = default;
		object obj8 = obj9 - obj9;
		object obj11 = default;
		object obj10 = obj11 - obj11;
		object obj13 = default;
		object obj12 = obj13 - obj13;
		object obj14 = obj8 * obj8;
		object obj15 = obj10 * obj10;
		object obj16 = obj14 + obj15;
		object obj17 = obj12 * obj12;
		object obj18 = obj17 + obj16;
		float num = maxDistance * maxDistance;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num))
		{
			return;
		}
		GeometryUtility.CalculateFrustumPlanes(main, planes);
		Plane[] array = planes;
		Bounds bounds = glass.bounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC588]");
		object obj19 = 0;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v26+38]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
		}
		ref Bounds bounds2;
		Span<Plane> span;
		if (planes != null)
		{
			bounds2 = ref *(Bounds*)array.Length;
			span = (Span<Plane>)(planes + 32);
		}
		else
		{
			bounds2 = ref *(Bounds*)null;
			span = (Span<Plane>)0;
		}
		ReadOnlySpan<Plane> readOnlySpan = span;
		if (!GeometryUtility.Internal_TestPlanesAABB(readOnlySpan, ref bounds2))
		{
			return;
		}
		if (skip >= 2)
		{
			int num2 = frame + 1;
			int num3 = num2 / skip;
			frame = num2;
			object obj22 = num3 * skip;
			if (num2 != (nint)obj22)
			{
				return;
			}
		}
		RenderFor(main);
	}

	public unsafe void RenderFor(Camera viewer)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I4
		//IL_0043: Expected VT, but got I4
		//IL_009f: Expected Obj, but got I4
		//IL_00ad: Expected VT, but got I4
		//IL_00fb: Expected Obj, but got I4
		//IL_0109: Expected VT, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_0165: Expected VT, but got I4
		//IL_0197: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got VT
		//IL_01b9: Expected VT, but got Obj
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_0211: Unsupported input type for neg.
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected VT, but got Unknown
		//IL_022e: Invalid comparison between F8 and I4
		//IL_2301: Invalid comparison between F8 and I4
		//IL_2321: Invalid comparison between F8 and I4
		//IL_0290: Expected VT, but got I4
		//IL_235a: Expected Obj, but got I4
		//IL_0282: Expected VT, but got I4
		//IL_02b2: Expected VT, but got I4
		//IL_031f: Expected Obj, but got I
		//IL_034e: Expected F8, but got VT
		//IL_0357: Expected VT, but got I4
		//IL_036c: Expected Obj, but got Ref
		//IL_237e: Expected Obj, but got Ref
		//IL_2387: Expected Obj, but got I4
		//IL_2395: Expected F8, but got VT
		//IL_23a6: Expected Obj, but got I4
		//IL_02f2: Expected VT, but got I4
		//IL_249f: Expected Obj, but got I4
		//IL_24b7: Expected VT, but got F8
		//IL_038b: Expected Obj, but got Ref
		//IL_0393: Expected Obj, but got Ref
		//IL_03d4: Expected Obj, but got I4
		//IL_03ec: Expected F8, but got VT
		//IL_03f5: Expected VT, but got I4
		//IL_23ed: Expected F8, but got VT
		//IL_16c6: Expected Obj, but got I4
		//IL_16de: Expected VT, but got F8
		//IL_20ac: Expected VT, but got F8
		//IL_040d: Expected Obj, but got I4
		//IL_0428: Expected Obj, but got I4
		//IL_176a: Expected VT, but got F8
		//IL_04a1: Expected VT, but got I
		//IL_04b1: Expected VT, but got F8
		//IL_04b9: Expected VT, but got F8
		//IL_228f: Expected I4, but got Obj
		//IL_22a1: Expected I4, but got Obj
		//IL_2247: Expected Obj, but got I4
		//IL_2250: Expected Obj, but got I4
		//IL_1730: Expected Obj, but got I4
		//IL_22be: Expected F8, but got VT
		//IL_22cf: Expected Obj, but got I4
		//IL_04e6: Expected Obj, but got I4
		//IL_0501: Expected Obj, but got I4
		//IL_051e: Expected VT, but got F8
		//IL_17b5: Expected I, but got Obj
		//IL_17cd: Expected VT, but got F8
		//IL_206c: Expected VT, but got I
		//IL_05b6: Expected Obj, but got I8
		//IL_05cb: Expected VT, but got I
		//IL_05e3: Expected VT, but got F8
		//IL_181f: Expected Obj, but got I4
		//IL_1846: Expected VT, but got I4
		//IL_185f: Expected I, but got Obj
		//IL_1877: Expected VT, but got F8
		//IL_062c: Expected Obj, but got I4
		//IL_2029: Expected Obj, but got I8
		//IL_2046: Expected VT, but got F8
		//IL_18ce: Expected Obj, but got I
		//IL_18fd: Expected Obj, but got I4
		//IL_216c: Expected I, but got Obj
		//IL_2174: Expected Obj, but got I4
		//IL_0685: Expected Obj, but got I8
		//IL_069a: Expected VT, but got I
		//IL_06b2: Expected VT, but got F8
		//IL_2436: Expected I, but got Obj
		//IL_244e: Expected VT, but got F8
		//IL_21a3: Expected Obj, but got Ref
		//IL_21ac: Expected Obj, but got I4
		//IL_06fb: Expected Obj, but got F8
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected Obj, but got Unknown
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected Obj, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected Obj, but got Unknown
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_073e: Expected Obj, but got Unknown
		//IL_07bf: Expected VT, but got F8
		//IL_07cc: Expected VT, but got F8
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected VT, but got Unknown
		//IL_1958: Expected I, but got Obj
		//IL_1970: Expected VT, but got F8
		//IL_0841: Expected Obj, but got I8
		//IL_1992: Expected I, but got Obj
		//IL_19aa: Expected VT, but got F8
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Expected Obj, but got Unknown
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected Obj, but got Unknown
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Expected Obj, but got Unknown
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected VT, but got Unknown
		//IL_09cb: Expected VT, but got I4
		//IL_09cb: Expected VT, but got I4
		//IL_09ff: Expected Obj, but got I8
		//IL_19c8: Expected Obj, but got I
		//IL_19de: Expected Obj, but got I4
		//IL_19de: Expected I4, but got Obj
		//IL_1a08: Expected Obj, but got I4
		//IL_1a35: Expected VT, but got F8
		//IL_0aac: Expected Obj, but got I8
		//IL_1a59: Expected Obj, but got I4
		//IL_1a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a92: Expected I4, but got Unknown
		//IL_1ac8: Expected Obj, but got I4
		//IL_1ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad5: Expected Obj, but got Unknown
		//IL_1af3: Expected Obj, but got I4
		//IL_1afc: Expected Obj, but got I4
		//IL_1b29: Expected VT, but got F8
		//IL_0b4f: Expected Obj, but got I4
		//IL_0b76: Expected VT, but got I4
		//IL_0baa: Expected Obj, but got I8
		//IL_1b5c: Expected Obj, but got I4
		//IL_1b89: Expected VT, but got F8
		//IL_0c28: Expected VT, but got Ref
		//IL_0c40: Expected Obj, but got I
		//IL_0c63: Expected Obj, but got I4
		//IL_1bc9: Expected Obj, but got I
		//IL_1bef: Expected Obj, but got I
		//IL_1c19: Expected Obj, but got I4
		//IL_1c49: Expected VT, but got F8
		//IL_1c59: Expected Obj, but got I
		//IL_0c92: Expected VT, but got I4
		//IL_0c92: Expected VT, but got Ref
		//IL_0c92: Expected VT, but got Ref
		//IL_0ca3: Expected VT, but got Ref
		//IL_0ca3: Expected VT, but got Ref
		//IL_0ce0: Expected VT, but got F8
		//IL_0cf8: Expected Obj, but got I8
		//IL_0d15: Expected VT, but got F8
		//IL_0d5d: Expected Obj, but got Ref
		//IL_1c85: Expected Obj, but got I4
		//IL_1cb5: Expected VT, but got F8
		//IL_1cc5: Expected Obj, but got I
		//IL_0d7d: Expected VT, but got Ref
		//IL_1cf0: Expected Obj, but got I4
		//IL_1d20: Expected VT, but got F8
		//IL_1d30: Expected Obj, but got I
		//IL_0de0: Expected VT, but got F8
		//IL_0df8: Expected Obj, but got I8
		//IL_0e15: Expected VT, but got F8
		//IL_0e5d: Expected Obj, but got Ref
		//IL_1d53: Expected F8, but got I4
		//IL_1d60: Expected VT, but got I4
		//IL_1d70: Expected Obj, but got I
		//IL_1d8e: Expected VT, but got Ref
		//IL_1dbc: Expected F8, but got I4
		//IL_1dc5: Expected Obj, but got I4
		//IL_1def: Expected VT, but got Obj
		//IL_1dff: Expected Obj, but got I
		//IL_0e7d: Expected VT, but got Ref
		//IL_0ee6: Expected VT, but got F8
		//IL_0efe: Expected Obj, but got I8
		//IL_0f23: Expected VT, but got F8
		//IL_1e2b: Expected Obj, but got I4
		//IL_1e38: Expected F8, but got I4
		//IL_1e41: Expected Obj, but got I4
		//IL_1e6b: Expected VT, but got Obj
		//IL_1e7b: Expected Obj, but got I
		//IL_0f8f: Expected Obj, but got I4
		//IL_0fd7: Expected VT, but got F8
		//IL_0fef: Expected Obj, but got I8
		//IL_0ff4: Expected I, but got Obj
		//IL_1014: Expected VT, but got F8
		//IL_1054: Expected Obj, but got Ref
		//IL_1eaa: Expected F8, but got I4
		//IL_1eb3: Expected Obj, but got I4
		//IL_1edd: Expected VT, but got Obj
		//IL_1eed: Expected Obj, but got I
		//IL_10be: Expected VT, but got F8
		//IL_10d6: Expected Obj, but got I8
		//IL_10fb: Expected VT, but got F8
		//IL_1f25: Expected Obj, but got I
		//IL_1f35: Expected VT, but got I
		//IL_1f45: Expected VT, but got I
		//IL_1f63: Expected VT, but got Ref
		//IL_1f87: Expected F8, but got I
		//IL_1f94: Expected F8, but got I4
		//IL_1f9d: Expected Obj, but got I4
		//IL_1fb5: Expected VT, but got I
		//IL_1fc5: Expected F8, but got I
		//IL_1fd5: Expected Obj, but got I
		//IL_1163: Unknown result type (might be due to invalid IL or missing references)
		//IL_1168: Expected Obj, but got Unknown
		//IL_1182: Expected Obj, but got I
		//IL_11de: Expected VT, but got F8
		//IL_11f6: Expected Obj, but got I8
		//IL_121b: Expected VT, but got F8
		//IL_130f: Expected VT, but got F8
		//IL_1327: Expected Obj, but got I8
		//IL_134c: Expected VT, but got F8
		//IL_1394: Expected Obj, but got Ref
		//IL_13ac: Expected Obj, but got I4
		//IL_13c7: Expected Obj, but got I4
		//IL_141f: Expected VT, but got F8
		//IL_1437: Expected Obj, but got I8
		//IL_145c: Expected VT, but got F8
		//IL_14d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d8: Expected Obj, but got Unknown
		//IL_14e0: Expected Obj, but got VT
		//IL_14ed: Expected I, but got VT
		//IL_14fa: Expected I4, but got VT
		//IL_1507: Expected I4, but got F8
		//IL_1570: Expected F8, but got VT
		//IL_1578: Expected F8, but got VT
		//IL_15a0: Expected VT, but got F8
		//IL_15b8: Expected Obj, but got I8
		//IL_15d8: Expected VT, but got F8
		//IL_15e0: Expected F8, but got VT
		//IL_15e8: Expected F8, but got VT
		//IL_162e: Expected VT, but got F8
		//IL_163e: Expected Obj, but got I8
		//IL_1643: Expected I, but got Obj
		//IL_165e: Expected VT, but got F8
		//IL_1666: Expected F8, but got VT
		//IL_166e: Expected F8, but got VT
		//IL_169e: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE136]");
		MirrorSurface mirrorSurface = (MirrorSurface)0;
		Init();
		int num = Eyes(viewer);
		Transform transform = base.transform;
		bool flag = (object)transform == null;
		object obj = 0;
		Vector3 vector = (Vector3)0;
		MaterialPropertyBlock materialPropertyBlock = null;
		MirrorSurface mirrorSurface2 = this;
		Camera camera = viewer;
		if (!flag)
		{
			Vector3 position = transform.position;
			Transform transform2 = base.transform;
			bool flag2 = (object)transform2 == null;
			obj = 0;
			vector = (Vector3)0;
			materialPropertyBlock = null;
			mirrorSurface2 = this;
			camera = viewer;
			if (!flag2)
			{
				Vector3 forward = transform2.forward;
				bool flag3 = (object)viewer == null;
				obj = 0;
				vector = (Vector3)0;
				materialPropertyBlock = null;
				mirrorSurface2 = this;
				camera = viewer;
				if (!flag3)
				{
					Transform transform3 = viewer.transform;
					bool flag4 = (object)transform3 == null;
					obj = 0;
					vector = (Vector3)0;
					materialPropertyBlock = null;
					mirrorSurface2 = this;
					camera = viewer;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC598]");
						object obj2 = 0;
						Vector3 position2 = transform3.position;
						Vector3 vector2 = default;
						object obj3 = vector2 - vector2;
						Vector3 n = (Vector3)obj2;
						double num3 = default;
						double num2 = num3 - num3;
						double num4 = 0.0 - num3;
						double num5 = 0.0 * 0.0;
						object obj4 = vector2 * obj3;
						double num6 = num5 + (double)obj4;
						double num7 = num3 * num2;
						Vector3 vector3 = 0 - vector2;
						double num8 = num7 + num6;
						double num9 = ((!(num8 < 0.0)) ? num3 : num4);
						Vector3 vector4 = ((!(num8 < 0.0)) ? vector2 : vector3);
						Vector3 vector5 = ((!(num8 < 0.0)) ? ((Vector3)0) : ((Vector3)0));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1898 @ X0_v56 (UnityEngine.Vector3)+E4]");
						bool flag5 = (nint)0 == 0;
						object obj5 = !flag5;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Matrix4x4 matrix4x = Reflection(n, (Vector3)0);
						bool flag6 = (byte)(~(playersOnly ? 1u : 0u)) != 0;
						double num10 = num9;
						Vector3 vector6 = vector4;
						Vector3 vector7 = default;
						vector = vector7;
						if (!flag6)
						{
							HideUnseen((Vector3)0);
							num10 = num9;
							vector6 = vector4;
							vector = vector5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8560]");
						object obj6 = 0;
						bool flag7 = num < 1;
						Vector3 vector9 = default;
						Vector3 vector8 = vector9;
						double num11 = num3;
						double num12 = (double)vector2;
						Vector3 vector10 = (Vector3)0;
						int num13 = num;
						materialPropertyBlock = null;
						mirrorSurface = (MirrorSurface)(&mirrorSurface2);
						int num14 = 0;
						int num53 = default;
						MirrorSurface mirrorSurface5;
						int num54;
						MirrorSurface mirrorSurface6;
						if (!flag7)
						{
							object obj7 = (object)(&obj);
							object obj9 = default;
							object obj8 = (object)(&obj9);
							double num16 = default;
							double num15 = num16;
							Vector3 vector12 = default;
							Vector3 vector11 = vector12;
							Vector3 vector14 = default;
							Vector3 vector13 = vector14;
							double num18 = default;
							double num17 = num18;
							double num20 = default;
							double num19 = num20;
							double num22 = default;
							double num21 = num22;
							object obj10 = 32;
							vector8 = vector9;
							num11 = num3;
							num12 = (double)vector2;
							vector10 = (Vector3)0;
							int num23 = 0;
							double num27 = default;
							double num28 = default;
							object obj19 = default;
							double num30 = default;
							object obj21 = default;
							object obj23 = default;
							object obj25 = default;
							object obj26 = default;
							double num35 = default;
							object obj29 = default;
							Vector3 upwards = default;
							object obj30 = default;
							object obj32 = default;
							object obj33 = default;
							object obj35 = default;
							object obj37 = default;
							object obj40 = default;
							Vector3 vector20 = default;
							Vector3 vector21 = default;
							Vector3 vector23 = default;
							Vector3 vector24 = default;
							Vector3 vector25 = default;
							Vector3 vector28 = default;
							double num51 = default;
							Vector3 vector29 = default;
							Vector3 vector30 = default;
							Vector3 vector31 = default;
							Vector3 vector32;
							Vector3 forward2 = default;
							Vector3 vector16;
							nint num52;
							MirrorSurface mirrorSurface4;
							while (true)
							{
								mirrorSurface2.Target(num23, viewer);
								Matrix4x4[] array = mirrorSurface2.views;
								bool flag8 = mirrorSurface2.views == null;
								Camera camera2 = viewer;
								double num24 = (double)vector6;
								int num25 = num23;
								MirrorSurface mirrorSurface3 = (MirrorSurface)(object)mirrorSurface2.views;
								if (flag8)
								{
									goto IL_209b;
								}
								mirrorSurface4 = (MirrorSurface)array.Length;
								bool flag9 = num23 < array.Length;
								object obj11 = !flag9;
								camera2 = viewer;
								num25 = num23;
								if (obj11 == null)
								{
									object obj12 = (object)mirrorSurface2.views + obj10;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DF8E5C");
									Matrix4x4[] array2 = mirrorSurface2.projections;
									bool flag10 = mirrorSurface2.projections == null;
									camera2 = null;
									Vector3 vector15 = forward2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2377 @ X8_v47+30]");
									vector10 = (Vector3)0;
									num10 = num19;
									vector6 = (Vector3)num21;
									vector = (Vector3)num17;
									num25 = (int)(&vector15);
									mirrorSurface3 = (MirrorSurface)(object)mirrorSurface2.projections;
									if (!flag10)
									{
										mirrorSurface4 = (MirrorSurface)array2.Length;
										bool flag11 = num23 < array2.Length;
										object obj13 = !flag11;
										camera2 = null;
										num10 = num19;
										num24 = num21;
										vector = (Vector3)num17;
										num25 = (int)(&vector15);
										mirrorSurface3 = (MirrorSurface)(object)mirrorSurface2.projections;
										if (obj13 == null)
										{
											object obj14 = (object)mirrorSurface2.projections + obj10;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X25_v8+20]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X25_v8+10]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DF8E5C");
											mirrorSurface4 = (MirrorSurface)(object)mirrorSurface2.views;
											bool flag12 = mirrorSurface2.views == null;
											object obj15 = obj14;
											obj9 = 3212836864L;
											camera2 = null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2377 @ X8_v47+30]");
											vector10 = (Vector3)0;
											num10 = num19;
											num24 = num21;
											vector = (Vector3)num17;
											num25 = (int)(&obj15);
											mirrorSurface3 = mirrorSurface2;
											if (flag12)
											{
												goto IL_207f;
											}
											mirrorSurface3 = (MirrorSurface)(object)((MonoBehaviour)mirrorSurface4).m_CancellationTokenSource;
											bool flag13 = num23 < (nint)((MonoBehaviour)mirrorSurface4).m_CancellationTokenSource;
											object obj16 = !flag13;
											if (obj16 == null)
											{
												Matrix4x4 matrix4x2 = Matrix4x4.Internal_Inverse(ref *(Matrix4x4*)((object)mirrorSurface2.views + obj10));
												bool flag14 = (object)mirrorSurface2.mirrorCam == null;
												obj15 = obj14;
												obj9 = 3212836864L;
												camera2 = null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2377 @ X8_v47+30]");
												vector10 = (Vector3)0;
												num10 = num19;
												num24 = num21;
												vector = (Vector3)num17;
												num25 = 0;
												mirrorSurface3 = mirrorSurface2;
												if (flag14)
												{
													goto IL_208d;
												}
												Transform transform4 = mirrorSurface2.mirrorCam.transform;
												double num26 = num27 * num28;
												object obj17 = 0.0 - num26;
												object obj18 = num22 * obj19;
												double num29 = num30 * num19;
												object obj20 = forward2 * obj21;
												object obj22 = forward2 * obj23;
												object obj24 = num22 * obj25;
												double num31 = num30 * num21;
												double num32 = num28 * (double)obj26;
												double num33 = (double)obj17 - num29;
												double num34 = num35 * num35;
												object obj27 = obj20 + obj18;
												num12 = num20 * (double)obj19;
												object obj28 = obj24 - obj22;
												num11 = num20 * (double)obj29;
												vector8 = (Vector3)(num31 + num32);
												vector16 = (Vector3)(num35 * num28);
												num24 = num33 - num34;
												double num36 = (double)obj27 + num12;
												Vector3 vector17 = (Vector3)(obj28 - num11);
												Vector3 vector18 = vector8 + vector16;
												Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward2, ref upwards);
												bool flag15 = (object)transform4 == null;
												obj15 = obj14;
												obj9 = 3212836864L;
												camera2 = null;
												forward2 = vector17;
												vector10 = vector18;
												num10 = num36;
												vector = vector17;
												num25 = (int)(&upwards);
												mirrorSurface3 = mirrorSurface2;
												if (flag15)
												{
													goto IL_2071;
												}
												double num37 = (double)obj30 * num17;
												object obj31 = obj32 * obj33;
												object obj34 = num22 * obj35;
												double num38 = num37 + (double)obj31;
												object obj36 = obj37 * vector9;
												double num39 = num38 + (double)obj36;
												object obj38 = vector17 * obj19;
												double num40 = (double)vector7 + num39;
												object obj39 = obj38 + obj34;
												double num41 = num30 * num17;
												double num42 = num28 * (double)obj33;
												double num43 = 1.0 / num40;
												double num44 = num20 * (double)obj29;
												double num45 = (double)obj39 + num44;
												double num46 = num41 + num42;
												double num47 = num35 * (double)vector9;
												double num48 = num18 + num45;
												double num49 = num46 + num47;
												double num50 = (double)vector9 + num49;
												Vector3 vector19 = (Vector3)(num48 * obj40);
												num10 = num50 * num43;
												transform4.SetPositionAndRotation((Vector3)0, (Quaternion)0);
												bool flag16 = (object)mirrorSurface2.mirrorCam == null;
												vector16 = vector18;
												obj15 = obj14;
												obj9 = 3212836864L;
												camera2 = null;
												object obj41 = obj12;
												vector15 = vector17;
												vector8 = vector18;
												num11 = num36;
												num12 = num24;
												forward2 = vector17;
												vector10 = vector17;
												vector6 = vector20;
												vector = vector19;
												num25 = 0;
												array = (Matrix4x4[])(object)mirrorSurface2;
												if (flag16)
												{
													goto IL_20c7;
												}
												Transform transform5 = mirrorSurface2.mirrorCam.transform;
												bool flag17 = (object)transform5 == null;
												vector16 = vector18;
												obj15 = obj14;
												obj9 = 3212836864L;
												camera2 = null;
												obj41 = obj12;
												vector15 = vector17;
												vector8 = vector18;
												num11 = num36;
												num12 = num24;
												forward2 = vector17;
												vector10 = vector17;
												vector6 = vector20;
												vector = vector19;
												num25 = 0;
												mirrorSurface = mirrorSurface2;
												if (flag17)
												{
													goto IL_213f;
												}
												Vector3 position3 = transform5.position;
												object obj42 = obj6;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4175 @ X0_v113+E4]");
												bool flag18 = (nint)0 == 0;
												object obj43 = !flag18;
												if (obj43 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												NameTag.FaceMirror((Vector3)0);
												bool flag19 = (object)mirrorSurface2.mirrorCam == null;
												vector16 = vector18;
												obj15 = obj14;
												obj9 = 3212836864L;
												camera2 = null;
												obj41 = obj12;
												vector15 = forward2;
												vector8 = vector18;
												num11 = num36;
												num12 = num24;
												forward2 = vector17;
												vector10 = vector17;
												vector6 = vector20;
												vector = vector19;
												num25 = 0;
												array = (Matrix4x4[])(object)mirrorSurface2;
												if (flag19)
												{
													goto IL_211b;
												}
												mirrorSurface2.mirrorCam.worldToCameraMatrix = (Matrix4x4)(&vector21);
												object obj44 = obj2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4188 @ X0_v117+E4]");
												mirrorSurface4 = (MirrorSurface)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4188 @ X0_v117+E4]");
												bool flag20 = (nint)0 == 0;
												object obj45 = !flag20;
												if (obj45 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Vector4 vector22 = CameraSpacePlane((Matrix4x4)(&vector23), (Vector3)(&vector21), (Vector3)0);
												Matrix4x4 matrix4x3 = Oblique((Matrix4x4)(&vector24), (Vector4)(&vector21));
												bool flag21 = (object)mirrorSurface2.mirrorCam == null;
												vector24 = forward2;
												vector23 = forward2;
												vector21 = forward2;
												vector16 = (Vector3)num17;
												obj15 = obj14;
												obj9 = 3212836864L;
												camera2 = null;
												obj41 = obj12;
												vector15 = forward2;
												vector8 = (Vector3)num17;
												num11 = num21;
												num12 = num19;
												forward2 = upwards;
												vector10 = vector5;
												num10 = num15;
												vector6 = vector13;
												vector = vector11;
												num25 = (int)(&vector21);
												array = (Matrix4x4[])(&upwards);
												if (flag21)
												{
													goto IL_20f1;
												}
												mirrorSurface2.mirrorCam.projectionMatrix = (Matrix4x4)(&vector25);
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DF8E5C");
												bool flag22 = (object)mirrorSurface2.mirrorCam == null;
												Vector3 vector26 = upwards;
												Vector3 vector27 = upwards;
												vector25 = upwards;
												vector24 = upwards;
												vector23 = upwards;
												vector21 = upwards;
												upwards = vector28;
												vector16 = (Vector3)num17;
												obj15 = obj14;
												obj9 = 3212836864L;
												camera2 = null;
												obj41 = obj12;
												vector15 = vector28;
												vector8 = (Vector3)num17;
												num11 = num21;
												num12 = num19;
												forward2 = vector28;
												vector10 = vector5;
												num10 = num51;
												vector6 = vector29;
												vector = vector30;
												num25 = (int)(&vector26);
												array = (Matrix4x4[])(&vector28);
												if (flag22)
												{
													goto IL_20e3;
												}
												mirrorSurface2.mirrorCam.cullingMatrix = (Matrix4x4)(&vector31);
												mirrorSurface = (MirrorSurface)(object)mirrorSurface2.targets;
												bool flag23 = mirrorSurface2.targets == null;
												vector31 = vector28;
												vector26 = vector28;
												vector27 = vector28;
												vector25 = vector28;
												vector24 = vector28;
												vector23 = vector28;
												vector21 = vector28;
												upwards = vector28;
												vector16 = (Vector3)num17;
												obj15 = obj14;
												obj9 = 3212836864L;
												camera2 = null;
												obj41 = obj12;
												vector15 = vector28;
												mirrorSurface4 = mirrorSurface2;
												vector8 = (Vector3)num17;
												num11 = num21;
												num12 = num19;
												forward2 = vector28;
												vector10 = vector5;
												num10 = num51;
												vector6 = vector29;
												vector = vector30;
												num25 = (int)(&vector31);
												if (flag23)
												{
													goto IL_214d;
												}
												bool flag24 = num23 < (nint)((MonoBehaviour)mirrorSurface).m_CancellationTokenSource;
												object obj46 = !flag24;
												vector31 = vector28;
												vector26 = vector28;
												vector27 = vector28;
												vector25 = vector28;
												vector24 = vector28;
												vector23 = vector28;
												vector21 = vector28;
												upwards = vector28;
												vector16 = (Vector3)num17;
												obj15 = obj14;
												obj9 = 3212836864L;
												num52 = unchecked((nint)null);
												obj41 = obj12;
												vector15 = vector28;
												mirrorSurface4 = mirrorSurface2;
												vector8 = (Vector3)num17;
												num11 = num21;
												num12 = num19;
												forward2 = vector28;
												vector10 = vector5;
												num10 = num51;
												vector6 = vector29;
												vector = vector30;
												materialPropertyBlock = (MaterialPropertyBlock)(&vector31);
												if (obj46 == null)
												{
													bool flag25 = (object)mirrorSurface2.mirrorCam == null;
													vector31 = vector28;
													vector26 = vector28;
													vector27 = vector28;
													vector25 = vector28;
													vector24 = vector28;
													vector23 = vector28;
													vector21 = vector28;
													upwards = vector28;
													vector16 = (Vector3)num17;
													obj15 = obj14;
													obj9 = 3212836864L;
													camera2 = null;
													obj41 = obj12;
													vector15 = vector28;
													mirrorSurface4 = mirrorSurface2;
													vector8 = (Vector3)num17;
													num11 = num21;
													num12 = num19;
													forward2 = vector28;
													vector10 = vector5;
													num10 = num51;
													vector6 = vector29;
													vector = vector30;
													num25 = (int)(&vector31);
													array = (Matrix4x4[])(object)mirrorSurface2.targets;
													if (flag25)
													{
														goto IL_210d;
													}
													object obj47 = mirrorSurface2.targets + num23;
													Camera camera3 = mirrorSurface2.mirrorCam;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4236 @ X8_v69+20]");
													camera3.targetTexture = (RenderTexture)0;
													bool flag26 = (object)mirrorSurface2.mirrorCam == null;
													vector31 = vector28;
													vector26 = vector28;
													vector27 = vector28;
													vector25 = vector28;
													vector24 = vector28;
													vector23 = vector28;
													vector21 = vector28;
													upwards = vector28;
													vector16 = (Vector3)num17;
													obj15 = obj14;
													obj9 = 3212836864L;
													camera2 = null;
													obj41 = obj12;
													vector15 = vector28;
													mirrorSurface4 = mirrorSurface2;
													vector8 = (Vector3)num17;
													num11 = num21;
													num12 = num19;
													forward2 = vector28;
													vector10 = vector5;
													num10 = num51;
													vector6 = vector29;
													vector = vector30;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4236 @ X8_v69+20]");
													num25 = 0;
													mirrorSurface = mirrorSurface2;
													if (flag26)
													{
														goto IL_2131;
													}
													mirrorSurface2.mirrorCam.Render();
													Matrix4x4[] array3 = mirrorSurface2.lookups;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DF8E5C");
													bool flag27 = mirrorSurface2.lookups == null;
													vector32 = vector28;
													Vector3 vector33 = vector28;
													vector31 = vector28;
													vector26 = vector28;
													vector27 = vector28;
													vector25 = vector28;
													vector24 = vector28;
													vector23 = vector28;
													vector21 = vector28;
													upwards = vector28;
													vector16 = (Vector3)num17;
													obj15 = obj14;
													obj9 = 3212836864L;
													camera2 = null;
													obj41 = obj12;
													vector15 = vector28;
													mirrorSurface4 = mirrorSurface2;
													vector8 = (Vector3)num17;
													num11 = num21;
													num12 = num19;
													forward2 = vector28;
													vector10 = vector5;
													num10 = num51;
													vector6 = vector29;
													vector = vector30;
													num25 = (int)(&vector32);
													array = (Matrix4x4[])(&vector28);
													if (flag27)
													{
														goto IL_20ff;
													}
													mirrorSurface = (MirrorSurface)array3.Length;
													bool flag28 = num23 < array3.Length;
													object obj48 = !flag28;
													vector32 = vector28;
													vector33 = vector28;
													vector31 = vector28;
													vector26 = vector28;
													vector27 = vector28;
													vector25 = vector28;
													vector24 = vector28;
													vector23 = vector28;
													vector21 = vector28;
													upwards = vector28;
													vector16 = (Vector3)num17;
													obj15 = obj14;
													obj9 = 3212836864L;
													camera2 = null;
													obj41 = obj12;
													vector15 = vector28;
													mirrorSurface4 = mirrorSurface2;
													vector8 = (Vector3)num17;
													num11 = num21;
													num12 = num19;
													forward2 = vector28;
													vector10 = vector5;
													num10 = num51;
													vector6 = vector29;
													vector = vector30;
													num25 = (int)(&vector32);
													if (obj48 == null)
													{
														mirrorSurface = (MirrorSurface)(object)((object)mirrorSurface2.lookups + obj10);
														num23++;
														obj10 += 64;
														mirrorSurface = (MirrorSurface)vector28;
														((UnityEngine.Object)mirrorSurface).m_CachedPtr = (IntPtr)vector29;
														mirrorSurface.textureSize = (int)vector30;
														mirrorSurface.quest2FrameSkip = (int)num51;
														bool flag29 = num != num23;
														vector32 = vector28;
														vector33 = vector28;
														vector31 = vector28;
														num15 = num51;
														vector11 = vector30;
														vector13 = vector29;
														vector26 = vector28;
														vector27 = vector28;
														vector25 = vector28;
														num17 = num51;
														num19 = (double)vector30;
														num21 = (double)vector29;
														vector24 = vector28;
														vector23 = vector28;
														vector21 = vector28;
														upwards = vector28;
														vector16 = (Vector3)num51;
														obj15 = obj14;
														obj9 = 3212836864L;
														obj41 = obj12;
														vector15 = vector28;
														mirrorSurface4 = mirrorSurface2;
														vector8 = (Vector3)num51;
														num11 = (double)vector29;
														num12 = (double)vector30;
														forward2 = vector28;
														vector10 = vector5;
														num10 = num51;
														vector6 = vector29;
														vector = vector30;
														if (!flag29)
														{
															break;
														}
														continue;
													}
													goto IL_215b;
												}
												goto IL_2179;
											}
											IndexOutOfRangeException ex = new IndexOutOfRangeException();
											obj15 = obj14;
											obj9 = 3212836864L;
											camera2 = null;
											num10 = num19;
											num24 = num21;
											vector = (Vector3)num17;
											num25 = (int)(&obj15);
										}
										IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2377 @ X8_v47+30]");
										vector10 = (Vector3)0;
										goto IL_2071;
									}
									goto IL_20b1;
								}
								goto IL_20d5;
								IL_211b:
								NullReferenceException ex3 = new NullReferenceException();
								mirrorSurface = (MirrorSurface)(object)array;
								goto IL_2131;
								IL_2131:
								NullReferenceException ex4 = new NullReferenceException();
								goto IL_213f;
								IL_213f:
								NullReferenceException ex5 = new NullReferenceException();
								goto IL_214d;
								IL_215b:
								IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
								num52 = (nint)camera2;
								materialPropertyBlock = (MaterialPropertyBlock)num25;
								goto IL_2179;
								IL_2179:
								IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
								num53 = num;
								mirrorSurface5 = null;
								num54 = 0;
								mirrorSurface6 = (MirrorSurface)(&mirrorSurface2);
								obj = 0;
								num3 = num10;
								vector2 = vector6;
								camera = viewer;
								goto IL_21cf;
								IL_214d:
								NullReferenceException ex8 = new NullReferenceException();
								goto IL_215b;
								IL_2071:
								NullReferenceException ex9 = new NullReferenceException();
								goto IL_207f;
								IL_207f:
								NullReferenceException ex10 = new NullReferenceException();
								goto IL_208d;
								IL_208d:
								NullReferenceException ex11 = new NullReferenceException();
								goto IL_209b;
								IL_209b:
								NullReferenceException ex12 = new NullReferenceException();
								vector6 = (Vector3)num24;
								goto IL_20b1;
								IL_20c7:
								NullReferenceException ex13 = new NullReferenceException();
								goto IL_20d5;
								IL_20b1:
								NullReferenceException ex14 = new NullReferenceException();
								array = (Matrix4x4[])(object)mirrorSurface3;
								goto IL_20c7;
								IL_20d5:
								IndexOutOfRangeException ex15 = new IndexOutOfRangeException();
								goto IL_20e3;
								IL_20f1:
								NullReferenceException ex16 = new NullReferenceException();
								goto IL_20ff;
								IL_20e3:
								NullReferenceException ex17 = new NullReferenceException();
								goto IL_20f1;
								IL_20ff:
								NullReferenceException ex18 = new NullReferenceException();
								goto IL_210d;
								IL_210d:
								NullReferenceException ex19 = new NullReferenceException();
								goto IL_211b;
							}
							vector32 = vector28;
							vector16 = (Vector3)num51;
							obj9 = 3212836864L;
							num52 = unchecked((nint)null);
							mirrorSurface4 = mirrorSurface2;
							num53 = num;
							vector8 = (Vector3)num51;
							num11 = (double)vector29;
							num12 = (double)vector30;
							vector10 = vector5;
							num10 = num51;
							vector6 = vector29;
							vector = vector30;
							num13 = num;
							materialPropertyBlock = (MaterialPropertyBlock)(&vector32);
							num14 = 0;
						}
						mirrorSurface5 = null;
						num54 = 0;
						mirrorSurface6 = (MirrorSurface)(&mirrorSurface2);
						obj = 0;
						double num55 = (double)vector;
						camera = viewer;
						object obj49 = 6;
						object obj52 = default;
						while (true)
						{
							ShowUnseen();
							bool flag30 = num14 == 0;
							object obj50 = !flag30;
							num3 = num10;
							vector2 = vector6;
							vector = (Vector3)num55;
							if (obj50 == null)
							{
								bool flag31 = (object)mirrorSurface5 == null;
								object obj51 = !flag31;
								num3 = num10;
								vector2 = vector6;
								vector = (Vector3)num55;
								OutOfMemoryException ex20 = (OutOfMemoryException)(object)this;
								mirrorSurface = mirrorSurface5;
								if (obj51 == null)
								{
									break;
								}
							}
							else
							{
								OutOfMemoryException ex20 = new OutOfMemoryException();
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
							if ((nint)materialPropertyBlock == 2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								mirrorSurface5 = (MirrorSurface)1;
								mirrorSurface = (MirrorSurface)1;
								num14 = num54;
							}
							else
							{
								if ((nint)materialPropertyBlock != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FB5C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
									return;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								num14 = (int)obj52;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								num54 = (int)obj52;
							}
							num10 = num3;
							vector6 = vector2;
							num55 = (double)vector;
							num13 = num53;
							obj49 = 0;
						}
						if ((nint)obj49 != 6)
						{
							bool flag32 = obj49 == null;
							object obj53 = !flag32;
							if (obj53 != null)
							{
								return;
							}
						}
						bool flag33 = (object)mirrorSurface2.mirrorCam == null;
						num3 = num10;
						vector2 = vector6;
						vector = (Vector3)num55;
						mirrorSurface = mirrorSurface2;
						if (!flag33)
						{
							mirrorSurface2.mirrorCam.targetTexture = null;
							Transform transform6 = camera.transform;
							bool flag34 = (object)transform6 == null;
							nint num52 = unchecked((nint)null);
							num3 = num10;
							vector2 = vector6;
							vector = (Vector3)num55;
							materialPropertyBlock = null;
							mirrorSurface = mirrorSurface2;
							if (!flag34)
							{
								Vector3 position4 = transform6.position;
								object obj54 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2224 @ X0_v13+E4]");
								bool flag35 = (nint)0 == 0;
								object obj55 = !flag35;
								if (obj55 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								NameTag.FaceViewer((Vector3)0);
								bool flag36 = (object)mirrorSurface2.glass == null;
								num52 = unchecked((nint)null);
								num3 = num10;
								vector2 = vector6;
								vector = (Vector3)num55;
								materialPropertyBlock = null;
								mirrorSurface = mirrorSurface2;
								if (!flag36)
								{
									materialPropertyBlock = mirrorSurface2.block;
									mirrorSurface2.glass.GetPropertyBlock(mirrorSurface2.block);
									object obj56 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v18+E4]");
									MirrorSurface mirrorSurface4 = (MirrorSurface)0;
									camera = (Camera)(object)mirrorSurface2.block;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v18+E4]");
									bool flag37 = (nint)0 == 0;
									object obj57 = !flag37;
									MirrorSurface mirrorSurface7 = mirrorSurface2;
									if (obj57 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj56 = obj2;
										mirrorSurface7 = mirrorSurface2;
									}
									mirrorSurface = (MirrorSurface)(object)mirrorSurface7.targets;
									bool flag38 = mirrorSurface7.targets == null;
									num52 = unchecked((nint)null);
									num3 = num10;
									vector2 = vector6;
									vector = (Vector3)num55;
									if (!flag38)
									{
										mirrorSurface4 = (MirrorSurface)(object)((MonoBehaviour)mirrorSurface).m_CancellationTokenSource;
										bool flag39 = ((MonoBehaviour)mirrorSurface).m_CancellationTokenSource == null;
										num52 = unchecked((nint)null);
										num3 = num10;
										vector2 = vector6;
										vector = (Vector3)num55;
										if (flag39)
										{
											goto IL_21dd;
										}
										bool flag40 = (object)camera == null;
										num52 = unchecked((nint)null);
										num3 = num10;
										vector2 = vector6;
										vector = (Vector3)num55;
										if (!flag40)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X0_v18+A0]");
											object obj58 = 0;
											((MaterialPropertyBlock)(object)camera).SetTexture((int)obj58, (Texture)mirrorSurface.textureSize);
											mirrorSurface = (MirrorSurface)(object)mirrorSurface2.targets;
											bool flag41 = mirrorSurface2.targets == null;
											object obj59 = 0;
											num52 = mirrorSurface.textureSize;
											mirrorSurface4 = mirrorSurface2;
											num3 = num10;
											vector2 = vector6;
											vector = (Vector3)num55;
											materialPropertyBlock = (MaterialPropertyBlock)obj58;
											if (!flag41)
											{
												object obj60 = num13 - 1;
												bool flag42 = (nint)obj60 < 0;
												bool flag43 = obj60 == null;
												int num56 = num13 ^ 1;
												int num57 = num13 ^ obj60;
												int num58 = num56 & num57;
												bool flag44 = num58 < 0;
												bool flag45 = flag42 == flag44;
												object obj61 = !flag43;
												object obj62 = flag45 & obj61;
												CancellationTokenSource cancellationTokenSource = ((MonoBehaviour)mirrorSurface).m_CancellationTokenSource;
												bool flag46 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj62) < System.Runtime.CompilerServices.Unsafe.As<CancellationTokenSource, UIntPtr>(ref cancellationTokenSource);
												object obj63 = !flag46;
												obj59 = 0;
												num52 = mirrorSurface.textureSize;
												mirrorSurface4 = mirrorSurface2;
												num3 = num10;
												vector2 = vector6;
												vector = (Vector3)num55;
												materialPropertyBlock = (MaterialPropertyBlock)obj58;
												if (obj63 != null)
												{
													goto IL_21dd;
												}
												bool flag47 = mirrorSurface2.block == null;
												obj59 = 0;
												num52 = mirrorSurface.textureSize;
												mirrorSurface4 = mirrorSurface2;
												num3 = num10;
												vector2 = vector6;
												vector = (Vector3)num55;
												materialPropertyBlock = (MaterialPropertyBlock)obj58;
												if (!flag47)
												{
													object obj64 = obj2;
													object obj65 = (object)mirrorSurface2.targets + obj62;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4133 @ X9_v7+A0]");
													object obj66 = 0;
													MaterialPropertyBlock materialPropertyBlock2 = mirrorSurface2.block;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4135 @ X9_v8+4]");
													nint num59 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4134 @ X8_v13+20]");
													materialPropertyBlock2.SetTexture((int)num59, (Texture)0);
													mirrorSurface = (MirrorSurface)(object)mirrorSurface2.lookups;
													bool flag48 = mirrorSurface2.lookups == null;
													obj59 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4134 @ X8_v13+20]");
													num52 = 0;
													mirrorSurface4 = mirrorSurface2;
													num3 = num10;
													vector2 = vector6;
													vector = (Vector3)num55;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4135 @ X9_v8+4]");
													materialPropertyBlock = (MaterialPropertyBlock)0;
													if (!flag48)
													{
														bool flag49 = ((MonoBehaviour)mirrorSurface).m_CancellationTokenSource == null;
														obj59 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4134 @ X8_v13+20]");
														num52 = 0;
														mirrorSurface4 = mirrorSurface2;
														num3 = num10;
														vector2 = vector6;
														vector = (Vector3)num55;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4135 @ X9_v8+4]");
														materialPropertyBlock = (MaterialPropertyBlock)0;
														if (flag49)
														{
															goto IL_21dd;
														}
														bool flag50 = mirrorSurface2.block == null;
														obj59 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4134 @ X8_v13+20]");
														num52 = 0;
														mirrorSurface4 = mirrorSurface2;
														num3 = num10;
														vector2 = vector6;
														vector = (Vector3)num55;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4135 @ X9_v8+4]");
														materialPropertyBlock = (MaterialPropertyBlock)0;
														if (!flag50)
														{
															object obj67 = obj2;
															num3 = mirrorSurface.textureSize;
															vector10 = (Vector3)mirrorSurface.quest2FrameSkip;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4171 @ X9_v10+A0]");
															object obj68 = 0;
															MaterialPropertyBlock materialPropertyBlock3 = mirrorSurface2.block;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4172 @ X9_v11+8]");
															double num60 = default;
															materialPropertyBlock3.SetMatrix(0, (Matrix4x4)(&num60));
															mirrorSurface = (MirrorSurface)(object)mirrorSurface2.lookups;
															bool flag51 = mirrorSurface2.lookups == null;
															num60 = mirrorSurface.textureSize;
															obj59 = 0;
															num52 = (nint)(&num60);
															mirrorSurface4 = mirrorSurface2;
															vector2 = (Vector3)mirrorSurface.reflectionMask;
															vector = (Vector3)mirrorSurface.mirrorCam;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4172 @ X9_v11+8]");
															materialPropertyBlock = (MaterialPropertyBlock)0;
															if (!flag51)
															{
																CancellationTokenSource cancellationTokenSource2 = ((MonoBehaviour)mirrorSurface).m_CancellationTokenSource;
																bool flag52 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj62) < System.Runtime.CompilerServices.Unsafe.As<CancellationTokenSource, UIntPtr>(ref cancellationTokenSource2);
																object obj69 = !flag52;
																num60 = mirrorSurface.textureSize;
																obj59 = 0;
																num52 = (nint)(&num60);
																mirrorSurface4 = mirrorSurface2;
																vector2 = (Vector3)mirrorSurface.reflectionMask;
																vector = (Vector3)mirrorSurface.mirrorCam;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4172 @ X9_v11+8]");
																materialPropertyBlock = (MaterialPropertyBlock)0;
																if (obj69 != null)
																{
																	goto IL_21dd;
																}
																bool flag53 = mirrorSurface2.block == null;
																num60 = mirrorSurface.textureSize;
																obj59 = 0;
																num52 = (nint)(&num60);
																mirrorSurface4 = mirrorSurface2;
																vector2 = (Vector3)mirrorSurface.reflectionMask;
																vector = (Vector3)mirrorSurface.mirrorCam;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4172 @ X9_v11+8]");
																materialPropertyBlock = (MaterialPropertyBlock)0;
																if (!flag53)
																{
																	object obj70 = obj2;
																	object obj71 = (object)mirrorSurface2.lookups + obj62;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4182 @ X9_v13+A0]");
																	mirrorSurface4 = (MirrorSurface)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4183 @ X8_v16+40]");
																	vector2 = (Vector3)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4183 @ X8_v16+50]");
																	vector = (Vector3)0;
																	MaterialPropertyBlock materialPropertyBlock4 = mirrorSurface2.block;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X9_v21 (MirrorSurface)+C]");
																	double num61 = default;
																	materialPropertyBlock4.SetMatrix(0, (Matrix4x4)(&num61));
																	bool flag54 = (object)mirrorSurface2.glass == null;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4183 @ X8_v16+20]");
																	num61 = 0.0;
																	num60 = mirrorSurface.textureSize;
																	obj59 = 0;
																	num52 = (nint)(&num61);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4183 @ X8_v16+30]");
																	vector10 = (Vector3)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4183 @ X8_v16+20]");
																	num3 = 0.0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X9_v21 (MirrorSurface)+C]");
																	materialPropertyBlock = (MaterialPropertyBlock)0;
																	mirrorSurface = mirrorSurface2;
																	if (!flag54)
																	{
																		mirrorSurface2.glass.SetPropertyBlock(mirrorSurface2.block);
																		return;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_21cf;
		IL_21dd:
		throw new IndexOutOfRangeException();
		IL_21cf:
		NullReferenceException ex21 = new NullReferenceException();
		goto IL_21dd;
	}

	private unsafe void HideUnseen(Vector3 normal)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0e23: Expected Obj, but got I4
		//IL_11f3: Expected Obj, but got I
		//IL_1209: Expected Obj, but got I
		//IL_1223: Expected Obj, but got I4
		//IL_0e41: Expected Obj, but got I
		//IL_0e6b: Expected Obj, but got I4
		//IL_1241: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_005e: Expected VT, but got I4
		//IL_0444: Expected Obj, but got I
		//IL_0454: Expected Obj, but got I
		//IL_0464: Expected Obj, but got I
		//IL_0474: Expected Obj, but got I
		//IL_0485: Expected Obj, but got I
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected Obj, but got I
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected VT, but got I
		//IL_008e: Expected VT, but got I4
		//IL_0cfb: Expected Obj, but got VT
		//IL_0ecf: Expected Obj, but got I4
		//IL_0ed3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got I
		//IL_00b4: Expected VT, but got Obj
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I8
		//IL_0105: Expected VT, but got I
		//IL_11aa: Expected Obj, but got I
		//IL_11b2: Expected VT, but got Obj
		//IL_11b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bb: Expected Ref, but got Unknown
		//IL_11d5: Expected Obj, but got I4
		//IL_04e8: Expected Obj, but got I4
		//IL_0c8d: Expected I, but got VT
		//IL_126f: Invalid comparison between VT and I4
		//IL_052d: Expected Obj, but got I4
		//IL_0532: Expected I, but got Obj
		//IL_0cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got I
		//IL_012b: Expected VT, but got Obj
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_016d: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01b0: Expected VT, but got I
		//IL_0d79: Invalid comparison between VT and I4
		//IL_0d59: Expected Obj, but got I4
		//IL_0d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d61: Expected Obj, but got Unknown
		//IL_0d25: Expected Obj, but got I4
		//IL_0d25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got I
		//IL_01d6: Expected VT, but got Obj
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_0210: Expected Obj, but got I8
		//IL_0227: Expected VT, but got I
		//IL_0db9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected Obj, but got I4
		//IL_0589: Expected I, but got Obj
		//IL_0245: Expected Obj, but got I
		//IL_024d: Expected VT, but got Obj
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_028f: Expected Obj, but got I4
		//IL_02a5: Expected Obj, but got I
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02d2: Expected VT, but got I
		//IL_05c1: Expected Obj, but got I4
		//IL_02f0: Expected Obj, but got I
		//IL_02f8: Expected VT, but got Obj
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_033a: Expected Obj, but got I4
		//IL_0350: Expected Obj, but got I
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_037d: Expected VT, but got I
		//IL_039b: Expected Obj, but got I
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected Obj, but got Unknown
		//IL_0bf5: Expected VT, but got I4
		//IL_062b: Expected VT, but got I4
		//IL_03f7: Expected Obj, but got I4
		//IL_0c1c: Expected VT, but got I4
		//IL_0c2a: Expected Obj, but got I4
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected VT, but got I4
		//IL_0e89: Expected Obj, but got I
		//IL_0ea0: Expected VT, but got I4
		//IL_06ad: Expected VT, but got I4
		//IL_06cb: Expected Obj, but got I4
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected I, but got Obj
		//IL_0654: Expected VT, but got I4
		//IL_0efd: Expected Obj, but got I
		//IL_0f1a: Expected Obj, but got I
		//IL_0f37: Expected Obj, but got I
		//IL_0f54: Expected Obj, but got I
		//IL_0f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8a: Expected VT, but got I4
		//IL_0fa8: Expected Obj, but got I4
		//IL_0fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc5: Expected I, but got Obj
		//IL_0725: Expected Obj, but got I4
		//IL_0fe3: Expected Obj, but got I
		//IL_0ff3: Expected VT, but got I
		//IL_1003: Expected Obj, but got I
		//IL_100b: Expected I, but got Obj
		//IL_102d: Expected Obj, but got I
		//IL_1054: Unknown result type (might be due to invalid IL or missing references)
		//IL_1058: Unknown result type (might be due to invalid IL or missing references)
		//IL_106a: Expected Obj, but got I4
		//IL_106e: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected Obj, but got I
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1088: Expected VT, but got Obj
		//IL_1107: Expected Obj, but got I
		//IL_110f: Expected VT, but got Obj
		//IL_111c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1130: Unknown result type (might be due to invalid IL or missing references)
		//IL_1134: Unknown result type (might be due to invalid IL or missing references)
		//IL_1140: Expected VT, but got I
		//IL_114e: Expected Obj, but got I4
		//IL_114e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1152: Unknown result type (might be due to invalid IL or missing references)
		//IL_115a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Expected Obj, but got I4
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Expected Obj, but got I4
		//IL_0b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b81: Expected Obj, but got I4
		//IL_0b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Expected VT, but got I4
		//IL_07fd: Expected I4, but got VT
		//IL_0860: Expected Obj, but got I4
		//IL_10c2: Expected Obj, but got I
		//IL_10d2: Expected Obj, but got I
		//IL_0afd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1e: Expected I, but got Obj
		//IL_0b2c: Expected Obj, but got I4
		//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Expected VT, but got I4
		//IL_089a: Expected I4, but got Obj
		//IL_08fc: Expected Obj, but got I4
		//IL_097b: Expected Obj, but got I
		//IL_098b: Expected Obj, but got I
		//IL_09b0: Expected Obj, but got I
		//IL_091c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0921: Expected Obj, but got Unknown
		//IL_094a: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Expected Obj, but got Unknown
		//IL_0966: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC598]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4+28]");
		object obj5 = (nint)0 + (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		Vector3 vector = default;
		Vector3 vector2;
		nint num = default;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			string[] array = default;
			bool flag3 = array == null;
			vector = (Vector3)6;
			if (!flag3)
			{
				bool flag4 = array.Length == 0;
				vector2 = (Vector3)num;
				vector = (Vector3)6;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5A8]");
					object obj8 = 0;
					vector = (Vector3)obj8;
					object obj9 = array + 32;
					obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X21_v21-8]");
					object obj10 = 0 & 0xFFFFFFFEL;
					bool flag5 = obj10 == null;
					vector2 = (Vector3)num;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F18]");
						object obj11 = 0;
						vector = (Vector3)obj11;
						object obj12 = array + 40;
						obj12 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X21_v23-10]");
						bool flag6 = (nint)0 < (nint)2;
						object obj13 = !flag6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X21_v23-10]");
						object obj14 = -2;
						bool flag7 = obj14 == null;
						object obj15 = ~obj13;
						object obj16 = obj15 | flag7;
						vector2 = (Vector3)num;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F20]");
							object obj17 = 0;
							vector = (Vector3)obj17;
							object obj18 = array + 48;
							obj18 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X21_v25-18]");
							object obj19 = 0 & 0xFFFFFFFCL;
							bool flag8 = obj19 == null;
							vector2 = (Vector3)num;
							if (!flag8)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5C0]");
								object obj20 = 0;
								vector = (Vector3)obj20;
								object obj21 = array + 56;
								obj21 = obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X21_v27-20]");
								bool flag9 = (nint)0 < (nint)4;
								object obj22 = !flag9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X21_v27-20]");
								object obj23 = -4;
								bool flag10 = obj23 == null;
								object obj24 = ~obj22;
								object obj25 = obj24 | flag10;
								vector2 = (Vector3)num;
								if (obj25 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5B0]");
									object obj26 = 0;
									vector = (Vector3)obj26;
									object obj27 = array + 64;
									obj27 = obj26;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X21_v29-28]");
									bool flag11 = (nint)0 < (nint)5;
									object obj28 = !flag11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X21_v29-28]");
									object obj29 = -5;
									bool flag12 = obj29 == null;
									object obj30 = ~obj28;
									object obj31 = obj30 | flag12;
									vector2 = (Vector3)num;
									if (obj31 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5B8]");
										object obj32 = 0;
										object obj33 = array + 72;
										obj33 = obj32;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										int mask = LayerMask.GetMask(array);
										object obj34 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1080 @ X8_v81+E4]");
										bool flag13 = (nint)0 == 0;
										object obj35 = !flag13;
										if (obj35 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj34 = obj;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1080 @ X8_v81+A0]");
										object obj36 = 0;
										int num2 = ~mask;
										vector = (Vector3)0;
										goto IL_0e31;
									}
								}
							}
						}
					}
				}
				goto IL_0c3f;
			}
			goto IL_0cc0;
		}
		goto IL_0e31;
		IL_1177:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0c6d:
		OutOfMemoryException ex = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		num = (nint)vector2;
		goto IL_0c92;
		IL_0c92:
		NullReferenceException ex2 = new NullReferenceException();
		object obj38;
		object obj37 = obj38;
		object obj40;
		object obj39 = obj40;
		NullReferenceException ex4;
		NullReferenceException ex3 = ex4;
		Enumerator<, > val2;
		Enumerator<, > val = val2;
		goto IL_0cc0;
		IL_0aa4:
		NullReferenceException ex5 = new NullReferenceException();
		Enumerator<, > val4 = default;
		Enumerator<, > val3 = (Enumerator<, >)(ref val4);
		object obj41 = obj37;
		object obj42 = obj39;
		Enumerator<, > val5 = val;
		ex3 = null;
		object obj43 = 0;
		Enumerator<, > val6 = default;
		val = val6;
		Enumerator<, > val8 = default;
		Enumerator<, > val7 = (Enumerator<, >)(ref val8);
		goto IL_0ce3;
		IL_06fb:
		object obj44 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ X0_v53+E4]");
		bool flag14 = (nint)0 == 0;
		object obj45 = !flag14;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj44 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ X0_v53+A0]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ X8_v30+20]");
		vector = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5A0]");
		object obj47 = 0;
		num = (nint)obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F9CC");
		object obj48 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1125 @ X8_v33+A0]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v34+20]");
		bool flag15 = (nint)0 == 0;
		obj41 = obj37;
		obj42 = obj39;
		val5 = val;
		ex4 = null;
		obj43 = 0;
		val7 = (Enumerator<, >)(ref val8);
		object obj50;
		object obj55;
		int num4;
		if (!flag15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v34+20]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			Renderer renderer = default;
			while (true)
			{
				vector = (Vector3)obj50;
				if (!val4.MoveNext())
				{
					break;
				}
				if ((object)renderer == null)
				{
					goto IL_0aa4;
				}
				bool forceRenderingOff = renderer.forceRenderingOff;
				bool flag16 = !forceRenderingOff;
				object obj51 = !flag16;
				if (obj51 != null)
				{
					continue;
				}
				GameObject gameObject = renderer.gameObject;
				if ((object)gameObject != null)
				{
					int layer = gameObject.layer;
					int num3 = reflectionMask >> layer;
					if ((num3 & 1) == 0)
					{
						continue;
					}
					renderer.forceRenderingOff = true;
					object obj52 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X0_v71+E4]");
					bool flag17 = (nint)0 == 0;
					object obj53 = !flag17;
					if (obj53 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj52 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X0_v71+A0]");
					object obj54 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1187 @ X8_v45+18]");
					List<System.__Canon> list = (List<System.__Canon>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1187 @ X8_v45+18]");
					if ((nint)0 != 0)
					{
						System.__Canon[] items = list._items;
						num4 = (int)obj55;
						int version = list._version + 1;
						list._version = version;
						if (list._items != null)
						{
							bool flag18 = list._size < items.Length;
							object obj56 = !flag18;
							if (obj56 == null)
							{
								object obj57 = list._items + list._size;
								num4 = list._size + 1;
								list._size = num4;
								object obj58 = obj57 + 32;
								obj58 = renderer;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								num = unchecked((nint)null);
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X9_v7 (System.Int32)+20]");
								object obj59 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1195 @ X8_v48+A8]");
								object obj60 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1163 @ X8_v49+70]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1187 @ X8_v45+18]");
								((List<System.__Canon>)0).AddWithResize((System.__Canon)(object)renderer);
							}
							continue;
						}
					}
					goto IL_0af0;
				}
				goto IL_0b4a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49F8]");
			object obj61 = 0;
			vector = (Vector3)obj61;
			val4.Dispose();
			val3 = (Enumerator<, >)(ref val4);
			obj41 = obj37;
			obj42 = obj39;
			val5 = val;
			vector2 = (Vector3)num;
			ex4 = null;
			obj43 = 0;
			val2 = val6;
			val7 = (Enumerator<, >)(ref val8);
			goto IL_0c6d;
		}
		goto IL_0c92;
		IL_0ce3:
		NullReferenceException ex6 = ex3;
		NullReferenceException ex7 = ex5;
		UnityEngine.Object obj62 = (UnityEngine.Object)vector;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D088");
		if (vector3 == (Vector3)(object)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			ex6 = (NullReferenceException)1;
			val2 = val;
			goto IL_0d32;
		}
		bool flag19 = vector3 != (Vector3)(object)1;
		Vector3 vector4 = vector3;
		if (flag19)
		{
			goto IL_1177;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
		object obj64 = default;
		object obj63 = obj64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		val2 = val;
		goto IL_119a;
		IL_0af0:
		ex5 = new NullReferenceException();
		val3 = (Enumerator<, >)(ref val4);
		obj41 = obj37;
		obj42 = obj39;
		val5 = val;
		num = unchecked((nint)null);
		ex3 = null;
		obj43 = 0;
		val = val6;
		val7 = (Enumerator<, >)(ref val8);
		vector = (Vector3)1;
		goto IL_0ce3;
		IL_119a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
		object obj65 = 0;
		vector4 = (Vector3)obj65;
		((Enumerator<, >*)val7)->Dispose();
		bool flag20 = obj63 == null;
		object obj66 = !flag20;
		if (obj66 == null)
		{
			bool flag21 = ex6 == null;
			object obj67 = !flag21;
			OutOfMemoryException ex8 = (OutOfMemoryException)val7;
			if (obj67 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex8 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		val = val2;
		NullReferenceException ex9 = default;
		ex7 = ex9;
		goto IL_1177;
		IL_0cc0:
		ex5 = new NullReferenceException();
		obj38 = obj37;
		obj40 = obj39;
		goto IL_0ce3;
		IL_0d32:
		obj63 = obj43;
		goto IL_119a;
		IL_0b4a:
		ex5 = new NullReferenceException();
		val3 = (Enumerator<, >)(ref val4);
		obj41 = obj37;
		obj42 = obj39;
		val5 = val;
		ex3 = null;
		obj43 = 0;
		val = val6;
		val7 = (Enumerator<, >)(ref val8);
		vector = (Vector3)0;
		goto IL_0ce3;
		IL_0c3f:
		IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
		obj38 = obj37;
		obj40 = obj39;
		ex4 = ex3;
		val2 = val;
		goto IL_0c6d;
		IL_0e31:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj68 = 0;
		object obj69 = obj68;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v27+E4]");
		bool flag22 = (nint)0 == 0;
		object obj70 = !flag22;
		if (obj70 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj69 = obj68;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v27+A0]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v16+8]");
		if ((nint)0 == 0)
		{
			goto IL_0cc0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A00]");
		obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4188]");
		obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v16+8]");
		Enumerator<, > enumerator2 = ((List<System.__Canon>)0).GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj74 = 0;
		obj38 = obj37;
		obj40 = obj39;
		Enumerator<, > val9 = default;
		val2 = val9;
		num4 = (int)(&val8);
		while (true)
		{
			bool flag23 = val8.MoveNext();
			bool flag24 = !flag23;
			ex6 = null;
			obj43 = 0;
			val7 = (Enumerator<, >)(ref val8);
			if (flag24)
			{
				break;
			}
			object obj75 = obj73;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X0_v33+E4]");
			bool flag25 = (nint)0 == 0;
			object obj76 = !flag25;
			if (obj76 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag26 = (UnityEngine.Object)(object)ex3 == null;
			bool flag27 = !flag26;
			object obj77 = !flag27;
			num = unchecked((nint)null);
			if (obj77 != null)
			{
				continue;
			}
			Vector3 at;
			if (ex3 != null)
			{
				bool isLocal = ((NetworkApe)(object)ex3).IsLocal;
				bool flag28 = !isLocal;
				object obj78 = !flag28;
				num = unchecked((nint)null);
				if (obj78 != null)
				{
					continue;
				}
				object obj79 = obj73;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ X0_v40+E4]");
				bool flag29 = (nint)0 == 0;
				object obj80 = !flag29;
				if (obj80 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)(object)((Exception)ex3)._source != null)
				{
					bool flag30 = ((Exception)ex3)._source == null;
					vector = (Vector3)0;
					if (!flag30)
					{
						Vector3 position = ((Transform)(object)((Exception)ex3)._source).position;
						at = (Vector3)0;
						goto IL_069e;
					}
				}
				else
				{
					Transform transform = ((Component)(object)ex3).transform;
					if ((object)transform != null)
					{
						Vector3 position2 = transform.position;
						at = (Vector3)0;
						goto IL_069e;
					}
					NullReferenceException ex11 = new NullReferenceException();
					vector = (Vector3)0;
				}
				NullReferenceException ex12 = new NullReferenceException();
				obj37 = obj38;
				obj39 = obj40;
				vector2 = (Vector3)0;
				ex3 = null;
				obj43 = 0;
				val = val2;
				val7 = (Enumerator<, >)(ref val8);
				goto IL_0c3f;
			}
			throw new NullReferenceException();
			IL_069e:
			bool flag31 = Sees(at, (Vector3)0);
			bool flag32 = !flag31;
			object obj81 = !flag32;
			obj41 = obj37;
			obj42 = obj39;
			val5 = val;
			num = unchecked((nint)null);
			if (obj81 != null)
			{
				continue;
			}
			object obj82 = obj74;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ X8_v27+A0]");
			object obj83 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v28+20]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			object obj84 = num5 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v28+18]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			object obj85 = num6 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v28+1C]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			object obj86 = num7 * 0;
			obj38 -= obj84;
			val2 = (Enumerator<, >)(val2 - obj85);
			obj40 -= obj86;
			bool flag33 = Sees(at, (Vector3)0);
			bool flag34 = !flag33;
			object obj87 = !flag34;
			obj41 = obj37;
			obj42 = obj39;
			val5 = val;
			num = unchecked((nint)null);
			if (obj87 != null)
			{
				continue;
			}
			goto IL_06fb;
		}
		goto IL_0d32;
	}

	private unsafe void ShowUnseen()
	{
		//IL_0010: Expected Obj, but got I
		//IL_03a6: Expected Obj, but got I4
		//IL_048f: Expected Obj, but got I
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got I4
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got I4
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Ref, but got Unknown
		//IL_044e: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got I4
		//IL_027c: Expected Obj, but got I4
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got I4
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got I
		//IL_03fe: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I4
		//IL_0317: Expected Obj, but got I4
		//IL_0320: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC598]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+A0]");
		UnityEngine.Object obj4 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v10 (UnityEngine.Object)+18]");
		bool flag2 = (nint)0 == 0;
		UnityEngine.Object obj6 = default;
		UnityEngine.Object obj5 = obj6;
		Enumerator<, > val = (Enumerator<, >)0;
		IntPtr intPtr = default;
		UnityEngine.Object obj7 = (UnityEngine.Object)(nint)intPtr;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A00]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49F8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v10 (UnityEngine.Object)+18]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			obj4 = obj6;
			Enumerator<, > val2 = default;
			object obj18 = default;
			while (true)
			{
				object obj14;
				Enumerator<, > val3;
				Enumerator<, > val4;
				if (val.MoveNext())
				{
					object obj11 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v35+E4]");
					obj4 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v35+E4]");
					bool flag3 = (nint)0 == 0;
					object obj12 = !flag3;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = obj6 != null;
					bool flag5 = !flag4;
					object obj13 = 0;
					if (!flag5)
					{
						if ((object)obj6 == null)
						{
							NullReferenceException ex = new NullReferenceException();
							obj13 = 0;
							obj5 = null;
							val = val2;
							obj14 = 0;
							val3 = val2;
							val4 = (Enumerator<, >)(ref val);
							obj7 = null;
							break;
						}
						((Renderer)obj6).forceRenderingOff = false;
						obj13 = 0;
					}
					continue;
				}
				obj5 = null;
				val = val2;
				obj14 = 0;
				val3 = val2;
				val4 = (Enumerator<, >)(ref val);
				object obj15 = 0;
				while (true)
				{
					obj7 = (UnityEngine.Object)obj10;
					((Enumerator<, >*)val4)->Dispose();
					bool flag6 = obj15 == null;
					object obj16 = !flag6;
					if (obj16 == null)
					{
						bool flag7 = (object)obj5 == null;
						object obj17 = !flag7;
						OutOfMemoryException ex2 = (OutOfMemoryException)val4;
						obj4 = obj5;
						if (obj17 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex2 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj7 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj5 = (UnityEngine.Object)1;
						obj4 = (UnityEngine.Object)1;
						obj15 = obj14;
						continue;
					}
					if ((nint)obj7 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj15 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj14 = obj18;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D088");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				object obj19 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v8+E4]");
				bool flag8 = (nint)0 == 0;
				object obj20 = !flag8;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj19 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v8+A0]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v8+18]");
				obj4 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v8+18]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v10 (UnityEngine.Object)+1C]");
				object obj22 = (nint)0 + (nint)1;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v10 (UnityEngine.Object)+18]");
				if ((nint)0 >= (nint)1)
				{
					IntPtr cachedPtr = obj4.m_CachedPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v10 (UnityEngine.Object)+18]");
					Array.Clear((Array)(nint)cachedPtr, 0, 0);
				}
				return;
			}
		}
		throw new NullReferenceException();
	}

	private bool Sees(Vector3 at, Vector3 normal)
	{
		//IL_040c: Expected I4, but got Obj
		//IL_0094: Expected Obj, but got I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_03f9: Expected Obj, but got I4
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected I4, but got Unknown
		//IL_018e: Invalid comparison between Obj and F4
		//IL_020e: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I4
		//IL_04cb: Expected Obj, but got I
		//IL_04e3: Expected Obj, but got I
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_027d: Expected Obj, but got I4
		//IL_02b0: Expected Obj, but got I
		//IL_02ec: Expected VT, but got I4
		//IL_031a: Expected Obj, but got I4
		//IL_044d: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got I
		//IL_0518: Expected Obj, but got I
		//IL_053a: Expected Obj, but got I4
		//IL_0494: Expected Obj, but got I4
		//IL_049d: Expected Obj, but got I4
		//IL_036d: Expected VT, but got I4
		//IL_036d: Expected VT, but got I
		//IL_03eb: Expected Obj, but got I4
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		Transform transform = base.transform;
		bool flag8;
		if ((object)transform != null)
		{
			Vector3 position = transform.position;
			object obj2 = default;
			object obj = obj2 - obj2;
			object obj4 = default;
			object obj3 = obj4 - obj4;
			object obj6 = default;
			object obj5 = obj6 - obj6;
			object obj8 = default;
			object obj7 = obj8 * obj;
			object obj10 = default;
			object obj9 = obj10 * obj3;
			object obj11 = obj7 + obj9;
			object obj13 = default;
			object obj12 = obj13 * obj5;
			object obj14 = obj12 + obj11;
			bool flag = (nint)obj14 < 0;
			object obj15 = !flag;
			bool flag2 = obj14 == null;
			object obj16 = ~obj15;
			object obj17 = obj16 | flag2;
			if (obj17 != null)
			{
				goto IL_03f0;
			}
			if ((object)glass != null)
			{
				Bounds bounds = glass.bounds;
				Bounds bounds2 = default;
				Vector3 point = default;
				Vector3 vector = bounds2.Internal_ClosestPoint(ref point);
				object obj19 = default;
				object obj18 = obj19 - obj2;
				object obj20 = obj12 - obj4;
				object obj21 = obj5 - obj6;
				object obj22 = obj18 * obj18;
				object obj23 = obj20 * obj20;
				object obj24 = obj22 + obj23;
				object obj25 = obj21 * obj21;
				object obj26 = obj25 + obj24;
				float num = farClip * farClip;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num))
				{
					goto IL_03f0;
				}
				if ((object)glass != null)
				{
					Bounds localBounds = glass.localBounds;
					if ((object)glass != null)
					{
						Transform transform2 = glass.transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
						object obj27 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC598]");
						object obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
						object obj29 = 0;
						object obj30 = 0;
						int num2 = 0;
						object obj31 = obj4;
						object obj32 = obj6;
						object obj40 = default;
						object obj46 = default;
						object obj48 = default;
						IntPtr intPtr = default;
						while (true)
						{
							object obj39;
							object obj42;
							if (obj30 != null)
							{
								object obj33 = obj30 & 1;
								bool flag3 = obj33 == null;
								object obj34 = !flag3;
								object obj35;
								if (obj34 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC84]");
									obj35 = 0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
									obj35 = 0;
								}
								bool flag4 = (nint)obj30 < 3;
								object obj36 = !flag4;
								object obj37 = ~obj36;
								object obj38 = ~obj37;
								if (obj38 == null)
								{
								}
								obj39 = obj40 * obj35;
								bool flag5 = (object)transform2 == null;
								object obj41 = !flag5;
								obj42 = 0;
								obj32 = obj40;
								if (obj41 == null)
								{
									break;
								}
							}
							else
							{
								object obj43 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v18+A0]");
								object obj44 = 0;
								obj39 = obj44;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v19+4]");
								obj42 = 0;
								if ((object)transform2 == null)
								{
									break;
								}
							}
							object obj45 = obj46 + obj42;
							object obj47 = obj48 + obj39;
							Vector3 vector2 = transform2.TransformPoint((Vector3)0);
							object obj49 = obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v23+E4]");
							bool flag6 = (nint)0 == 0;
							object obj50 = !flag6;
							if (obj50 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj49 = obj28;
							}
							object obj51 = obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v23+A0]");
							object obj52 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v15+E4]");
							bool flag7 = (nint)0 == 0;
							object obj53 = !flag7;
							if (obj53 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X9_v5+28]");
							flag8 = Physics.Linecast((Vector3)0, (Vector3)1, 0, (QueryTriggerInteraction)(nint)intPtr);
							if (flag8)
							{
								object obj54 = obj30 + 1;
								bool flag9 = (nint)obj30 != 4;
								obj30 = obj54;
								num2 = 0;
								obj31 = obj4;
								obj32 = obj2;
								if (flag9)
								{
									continue;
								}
							}
							goto IL_03dd;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_03dd:
		object obj55 = (flag8 ? 1 : 0) ^ 1;
		goto IL_0565;
		IL_0565:
		return (byte)(obj55 & 1) != 0;
		IL_03f0:
		obj55 = 0;
		goto IL_0565;
	}

	private unsafe int Eyes(Camera viewer)
	{
		//IL_003f: Expected Obj, but got I
		//IL_0047: Expected I, but got Obj
		//IL_0069: Expected Obj, but got I4
		//IL_1089: Expected Obj, but got I
		//IL_1095: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c3: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I
		//IL_00bd: Expected I4, but got Obj
		//IL_00cf: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0091: Expected I, but got Obj
		//IL_0720: Expected Obj, but got Ref
		//IL_0730: Expected Obj, but got I
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Ref
		//IL_0123: Expected Obj, but got Ref
		//IL_0135: Expected Obj, but got I
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got I4
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e1: Expected Obj, but got I
		//IL_10e9: Expected I4, but got Obj
		//IL_110d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1111: Unknown result type (might be due to invalid IL or missing references)
		//IL_115d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected Obj, but got I4
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected Obj, but got I4
		//IL_0573: Expected Obj, but got I4
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Expected I4, but got Unknown
		//IL_123b: Expected Obj, but got I
		//IL_1243: Expected I4, but got Obj
		//IL_1243: Unknown result type (might be due to invalid IL or missing references)
		//IL_124c: Expected Ref, but got Unknown
		//IL_1266: Expected Obj, but got I4
		//IL_126e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1272: Unknown result type (might be due to invalid IL or missing references)
		//IL_12be: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed5: Expected Obj, but got I4
		//IL_0ed9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected Obj, but got I4
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected Obj, but got I4
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected I4, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1001: Unknown result type (might be due to invalid IL or missing references)
		//IL_101e: Expected Obj, but got I4
		//IL_0910: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0202: Expected Obj, but got I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected Obj, but got Ref
		//IL_09a8: Expected Obj, but got I
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got Unknown
		//IL_0a8b: Expected Obj, but got I8
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b69: Expected Obj, but got I4
		//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e71: Expected I4, but got Obj
		//IL_0c02: Expected Obj, but got I4
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c56: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02ce: Expected Obj, but got I4
		//IL_02de: Expected I4, but got Obj
		//IL_0e96: Expected Obj, but got I4
		//IL_0eb6: Expected Obj, but got Ref
		//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d25: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected VT, but got I
		//IL_030c: Expected Obj, but got I
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got I
		//IL_0e5b: Expected Obj, but got Ref
		//IL_0d63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d68: Expected Obj, but got Unknown
		//IL_0d7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Obj, but got I4
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got Unknown
		//IL_040a: Expected Obj, but got I
		//IL_0434: Expected Obj, but got I
		//IL_044a: Expected Obj, but got I4
		//IL_0452: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		bool flag = (object)viewer == null;
		int num = 232;
		Camera.StereoscopicEye stereoscopicEye = (Camera.StereoscopicEye)0;
		MirrorSurface mirrorSurface = this;
		Enumerator<, > val3 = default;
		int result2;
		object obj32;
		Enumerator<, > val7 = default;
		int num10 = default;
		if (!flag)
		{
			Enumerator<, > val2 = default;
			IntegratedSubsystem integratedSubsystem3 = default;
			object obj41 = default;
			LayerMask layerMask3 = default;
			LayerMask layerMask4 = default;
			Camera camera4 = default;
			if (viewer.stereoEnabled)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC598]");
				Matrix4x4[] array = (Matrix4x4[])0;
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v47 (Il2CppClass<UnityEngine.Matrix4x4[]>)+E4]");
				bool flag2 = (nint)0 == 0;
				object obj = !flag2;
				nint num3 = num2;
				if (obj == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num3 = (nint)array;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A90]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v48 (Il2CppClass<UnityEngine.Matrix4x4[]>)+A0]");
				Enumerator<, > val = (Enumerator<, >)0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v31+E4]");
				bool flag3 = (nint)0 == 0;
				object obj4 = !flag3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5AB8]");
				object obj5 = 0;
				stereoscopicEye = (Camera.StereoscopicEye)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @37885AC");
				nint num4 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v34 (Il2CppClass<UnityEngine.Matrix4x4[]>)+A0]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v35+10]");
				bool flag4 = (nint)0 == 0;
				num = 232;
				mirrorSurface = this;
				if (!flag4)
				{
					XRDisplaySubsystem.XRRenderParameter renderParameter = default;
					object obj7 = (object)(&renderParameter);
					object obj8 = (object)(&val2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v35+10]");
					Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
					val = (Enumerator<, >)(ref val3);
					object obj9 = 0;
					Camera camera = (Camera)val2;
					num = 232;
					IntegratedSubsystem integratedSubsystem;
					Enumerator<, > val4;
					LayerMask layerMask;
					object obj11;
					object obj13;
					object obj15;
					object obj17;
					object obj19;
					object obj21;
					object obj23;
					int num5;
					Enumerator<, > val6;
					object obj25;
					Camera camera2;
					int num7;
					IntegratedSubsystem integratedSubsystem2 = default;
					Enumerator<, > val5 = default;
					LayerMask layerMask2 = default;
					object obj12 = default;
					object obj14 = default;
					object obj16 = default;
					object obj18 = default;
					object obj20 = default;
					object obj22 = default;
					object obj24 = default;
					int num6 = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5AA0]");
						object obj10 = 0;
						stereoscopicEye = (Camera.StereoscopicEye)obj10;
						bool flag5 = val3.MoveNext();
						bool flag6 = !flag5;
						integratedSubsystem = integratedSubsystem2;
						val4 = val5;
						layerMask = layerMask2;
						obj11 = obj12;
						obj13 = obj14;
						obj15 = obj16;
						obj17 = obj18;
						obj19 = obj20;
						obj21 = obj22;
						obj23 = obj24;
						num5 = num6;
						val6 = val;
						obj25 = obj9;
						camera2 = camera;
						num7 = num;
						if (flag6)
						{
							break;
						}
						if (integratedSubsystem3 != null)
						{
							if (!integratedSubsystem3.running)
							{
								continue;
							}
							num5 = 0;
							while (true)
							{
								int renderPassCount = ((XRDisplaySubsystem)integratedSubsystem3).GetRenderPassCount();
								if (num5 >= renderPassCount || (nint)obj9 >= 2)
								{
									break;
								}
								((XRDisplaySubsystem)integratedSubsystem3).GetRenderPass(num5, out XRDisplaySubsystem.XRRenderPass renderPass);
								obj16 = 0x20 | obj9;
								obj24 = 0;
								val = (Enumerator<, >)32;
								int num8 = 0;
								num = (int)(&renderPass);
								while (true)
								{
									int renderParameterCount = renderPass.GetRenderParameterCount();
									if (num8 >= renderParameterCount)
									{
										break;
									}
									object obj26 = obj9 + num8;
									if ((nint)obj26 >= 2)
									{
										break;
									}
									renderPass.GetRenderParameter(viewer, num8, out renderParameter);
									Matrix4x4[] array2 = views;
									bool flag7 = views == null;
									num = num8;
									Camera camera3 = viewer;
									if (!flag7)
									{
										val = (Enumerator<, >)array2.Length;
										obj12 = obj9 + num8;
										bool flag8 = (nint)obj12 < array2.Length;
										object obj27 = !flag8;
										num = num8;
										stereoscopicEye = (Camera.StereoscopicEye)viewer;
										if (obj27 != null)
										{
											goto IL_0e84;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X25_v8+20]");
										layerMask2 = (LayerMask)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X25_v8+30]");
										camera = (Camera)0;
										object obj28 = (object)views + obj16;
										val5 = (Enumerator<, >)obj7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X25_v8+10]");
										integratedSubsystem2 = (IntegratedSubsystem)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X25_v8+20]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X25_v8+30]");
										_ = 0;
										obj28 = obj7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X25_v8+10]");
										_ = 0;
										array = projections;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
										if (projections != null)
										{
											bool flag9 = (nint)obj12 < array.Length;
											object obj29 = !flag9;
											num = 232;
											stereoscopicEye = (Camera.StereoscopicEye)(int)(&renderParameter);
											if (obj29 == null)
											{
												object obj30 = (object)projections + obj16;
												num8++;
												obj16 += 64;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X26_v8+40]");
												obj30 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X26_v8+50]");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X26_v8+60]");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X26_v8+70]");
												camera = (Camera)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X26_v8+70]");
												_ = 0;
												obj14 = 0;
												obj24 = (object)(&renderParameter);
												num = 232;
												continue;
											}
											goto IL_0e76;
										}
										NullReferenceException ex = new NullReferenceException();
										num = 232;
										camera3 = (Camera)(&renderParameter);
									}
									NullReferenceException ex2 = new NullReferenceException();
									stereoscopicEye = (Camera.StereoscopicEye)camera3;
									goto IL_0e76;
									IL_0e84:
									IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
									obj14 = 0;
									obj18 = obj9;
									obj20 = obj9;
									obj22 = obj9;
									obj24 = (object)(&renderParameter);
									num6 = num5;
									goto IL_0ec3;
									IL_0e76:
									IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
									goto IL_0e84;
								}
								object obj31 = obj9 + num8;
								int num9 = num5 + 1;
								obj18 = obj9;
								obj20 = obj9;
								obj22 = obj9;
								num5 = num9;
								obj9 = obj31;
							}
							bool flag10 = (nint)obj9 <= 0;
							integratedSubsystem = integratedSubsystem2;
							val4 = val5;
							layerMask = layerMask2;
							obj11 = obj12;
							obj13 = obj14;
							obj15 = obj16;
							obj17 = obj18;
							obj19 = obj20;
							obj21 = obj22;
							obj23 = obj24;
							val6 = val;
							obj25 = obj9;
							camera2 = camera;
							num7 = num;
							num6 = num5;
							if (!flag10)
							{
								break;
							}
							continue;
						}
						goto IL_0ec3;
					}
					obj32 = 0;
					val7 = (Enumerator<, >)(ref val3);
					num10 = 0;
					object obj33 = 11;
					mirrorSurface = this;
					object obj34 = 0;
					object obj38 = default;
					int result = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A98]");
						object obj35 = 0;
						stereoscopicEye = (Camera.StereoscopicEye)obj35;
						((Enumerator<, >*)val7)->Dispose();
						bool flag11 = obj34 == null;
						object obj36 = !flag11;
						integratedSubsystem2 = integratedSubsystem;
						val5 = val4;
						layerMask2 = layerMask;
						obj12 = obj11;
						obj14 = obj13;
						obj16 = obj15;
						obj18 = obj17;
						obj20 = obj19;
						obj22 = obj21;
						obj24 = obj23;
						num6 = num5;
						val = val6;
						camera = camera2;
						num = num7;
						if (obj36 == null)
						{
							bool flag12 = num10 == 0;
							object obj37 = !flag12;
							integratedSubsystem2 = integratedSubsystem;
							val5 = val4;
							layerMask2 = layerMask;
							obj12 = obj11;
							obj14 = obj13;
							obj16 = obj15;
							obj18 = obj17;
							obj20 = obj19;
							obj22 = obj21;
							obj24 = obj23;
							num6 = num5;
							val = val6;
							camera = camera2;
							num = num7;
							OutOfMemoryException ex5 = (OutOfMemoryException)val7;
							if (obj37 == null)
							{
								break;
							}
						}
						else
						{
							OutOfMemoryException ex5 = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						switch (stereoscopicEye)
						{
						case (Camera.StereoscopicEye)2:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							num10 = 1;
							obj34 = obj32;
							break;
						case (Camera.StereoscopicEye)1:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj34 = obj38;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj32 = obj38;
							break;
						default:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D76C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return result;
						}
						integratedSubsystem = integratedSubsystem2;
						val4 = val5;
						layerMask = layerMask2;
						obj11 = obj12;
						obj13 = obj14;
						obj15 = obj16;
						obj17 = obj18;
						obj19 = obj20;
						obj21 = obj22;
						obj23 = obj24;
						num5 = num6;
						val6 = val;
						obj25 = obj22;
						camera2 = camera;
						obj33 = 0;
						num7 = num;
					}
					if ((nint)obj33 != 11)
					{
						bool flag13 = obj33 == null;
						object obj39 = !flag13;
						result2 = (int)val7;
						if (obj39 != null)
						{
							goto IL_11e3;
						}
					}
					if ((nint)obj25 == 2)
					{
						result2 = 2;
						goto IL_11e3;
					}
					Matrix4x4[] array3 = mirrorSurface.views;
					Matrix4x4 stereoViewMatrix = viewer.GetStereoViewMatrix((Camera.StereoscopicEye)0);
					bool flag14 = mirrorSurface.views == null;
					integratedSubsystem2 = integratedSubsystem;
					val5 = val4;
					layerMask2 = layerMask;
					obj12 = obj11;
					obj14 = obj13;
					obj16 = obj15;
					obj18 = obj17;
					obj20 = obj19;
					obj22 = obj21;
					obj24 = obj23;
					num6 = num5;
					val = val6;
					camera = camera2;
					num = 0;
					stereoscopicEye = (Camera.StereoscopicEye)0;
					if (!flag14)
					{
						bool flag15 = array3.Length == 0;
						integratedSubsystem2 = integratedSubsystem;
						val5 = val4;
						layerMask2 = layerMask;
						obj12 = obj11;
						obj14 = obj13;
						obj16 = obj15;
						obj18 = obj17;
						obj20 = obj19;
						obj22 = obj21;
						obj24 = obj23;
						num6 = num5;
						val = val6;
						camera = camera2;
						num = 0;
						stereoscopicEye = (Camera.StereoscopicEye)0;
						if (!flag15)
						{
							object obj40 = (object)(&obj41);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v924 @ X8_v9+FF]");
							camera = (Camera)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v924 @ X8_v9+FF]");
							_ = 0;
							Matrix4x4[] array4 = mirrorSurface.views;
							Matrix4x4 stereoViewMatrix2 = viewer.GetStereoViewMatrix((Camera.StereoscopicEye)1);
							bool flag16 = mirrorSurface.views == null;
							integratedSubsystem2 = integratedSubsystem3;
							val5 = val2;
							layerMask2 = layerMask3;
							obj12 = obj11;
							obj14 = obj13;
							obj16 = obj15;
							obj18 = obj17;
							obj20 = obj19;
							obj22 = obj21;
							obj24 = obj23;
							num6 = num5;
							val = val6;
							num = 0;
							stereoscopicEye = (Camera.StereoscopicEye)1;
							if (flag16)
							{
								goto IL_0ef2;
							}
							object obj42 = array4.Length & 0xFFFFFFFEL;
							bool flag17 = obj42 == null;
							integratedSubsystem2 = integratedSubsystem3;
							val5 = val2;
							layerMask2 = layerMask3;
							obj12 = obj11;
							obj14 = obj13;
							obj16 = obj15;
							obj18 = obj17;
							obj20 = obj19;
							obj22 = obj21;
							obj24 = obj23;
							num6 = num5;
							val = val6;
							num = 0;
							stereoscopicEye = (Camera.StereoscopicEye)1;
							if (!flag17)
							{
								Matrix4x4[] array5 = mirrorSurface.projections;
								Matrix4x4 stereoProjectionMatrix = viewer.GetStereoProjectionMatrix((Camera.StereoscopicEye)0);
								bool flag18 = mirrorSurface.projections == null;
								integratedSubsystem2 = (IntegratedSubsystem)num10;
								val5 = val7;
								layerMask2 = layerMask4;
								obj12 = obj11;
								obj14 = obj13;
								obj16 = obj15;
								obj18 = obj17;
								obj20 = obj19;
								obj22 = obj21;
								obj24 = obj23;
								num6 = num5;
								val = val6;
								camera = camera4;
								num = 0;
								stereoscopicEye = (Camera.StereoscopicEye)0;
								if (flag18)
								{
									goto IL_0ef2;
								}
								bool flag19 = array5.Length == 0;
								integratedSubsystem2 = (IntegratedSubsystem)num10;
								val5 = val7;
								layerMask2 = layerMask4;
								obj12 = obj11;
								obj14 = obj13;
								obj16 = obj15;
								obj18 = obj17;
								obj20 = obj19;
								obj22 = obj21;
								obj24 = obj23;
								num6 = num5;
								val = val6;
								camera = camera4;
								num = 0;
								stereoscopicEye = (Camera.StereoscopicEye)0;
								if (!flag19)
								{
									mirrorSurface = (MirrorSurface)(object)mirrorSurface.projections;
									Matrix4x4 stereoProjectionMatrix2 = viewer.GetStereoProjectionMatrix((Camera.StereoscopicEye)1);
									bool flag20 = mirrorSurface.projections == null;
									IntegratedSubsystem integratedSubsystem4 = default;
									integratedSubsystem2 = integratedSubsystem4;
									Enumerator<, > val8 = default;
									val5 = val8;
									LayerMask layerMask5 = default;
									layerMask2 = layerMask5;
									obj12 = obj11;
									obj14 = obj13;
									obj16 = obj15;
									obj18 = obj17;
									obj20 = obj19;
									obj22 = obj21;
									obj24 = obj23;
									num6 = num5;
									val = val6;
									Camera camera5 = default;
									camera = camera5;
									num = 0;
									stereoscopicEye = (Camera.StereoscopicEye)1;
									if (flag20)
									{
										goto IL_0ef2;
									}
									object obj43 = ((MonoBehaviour)mirrorSurface).m_CancellationTokenSource & 0xFFFFFFFEL;
									bool flag21 = obj43 == null;
									integratedSubsystem2 = integratedSubsystem4;
									val5 = val8;
									layerMask2 = layerMask5;
									obj12 = obj11;
									obj14 = obj13;
									obj16 = obj15;
									obj18 = obj17;
									obj20 = obj19;
									obj22 = obj21;
									obj24 = obj23;
									num6 = num5;
									val = val6;
									camera = camera5;
									num = 0;
									stereoscopicEye = (Camera.StereoscopicEye)1;
									if (!flag21)
									{
										MaterialPropertyBlock materialPropertyBlock = default;
										mirrorSurface.block = materialPropertyBlock;
										int num11 = default;
										mirrorSurface.size = num11;
										Matrix4x4[] array6 = default;
										mirrorSurface.views = array6;
										Matrix4x4[] array7 = default;
										mirrorSurface.lookups = array7;
										result2 = 2;
										goto IL_11e3;
									}
								}
							}
						}
						goto IL_0f00;
					}
				}
			}
			else
			{
				Matrix4x4[] array8 = views;
				Matrix4x4 worldToCameraMatrix = viewer.worldToCameraMatrix;
				bool flag22 = views == null;
				num = 232;
				stereoscopicEye = (Camera.StereoscopicEye)0;
				mirrorSurface = this;
				if (!flag22)
				{
					bool flag23 = array8.Length == 0;
					num = 232;
					stereoscopicEye = (Camera.StereoscopicEye)0;
					mirrorSurface = this;
					if (!flag23)
					{
						object obj44 = (object)(&obj41);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v25+FF]");
						Camera camera = (Camera)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v25+FF]");
						_ = 0;
						mirrorSurface = (MirrorSurface)(object)projections;
						Matrix4x4 projectionMatrix = viewer.projectionMatrix;
						bool flag24 = projections == null;
						IntegratedSubsystem integratedSubsystem2 = integratedSubsystem3;
						Enumerator<, > val5 = val2;
						LayerMask layerMask2 = layerMask3;
						num = 232;
						stereoscopicEye = (Camera.StereoscopicEye)0;
						if (flag24)
						{
							goto IL_0ef2;
						}
						bool flag25 = ((MonoBehaviour)mirrorSurface).m_CancellationTokenSource == null;
						integratedSubsystem2 = integratedSubsystem3;
						val5 = val2;
						layerMask2 = layerMask3;
						num = 232;
						stereoscopicEye = (Camera.StereoscopicEye)0;
						if (!flag25)
						{
							mirrorSurface.reflectionMask = layerMask4;
							mirrorSurface.mirrorCam = camera4;
							mirrorSurface.textureSize = (int)val7;
							mirrorSurface.quest2FrameSkip = num10;
							result2 = 1;
							goto IL_11e3;
						}
					}
					goto IL_0f00;
				}
			}
		}
		goto IL_0ef2;
		IL_11e3:
		return result2;
		IL_0f00:
		throw new IndexOutOfRangeException();
		IL_0ec3:
		NullReferenceException ex6 = new NullReferenceException();
		obj32 = 0;
		val7 = (Enumerator<, >)(ref val3);
		num10 = 0;
		mirrorSurface = this;
		goto IL_0ef2;
		IL_0ef2:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_0f00;
	}

	private void Target(int e, Camera viewer)
	{
		//IL_0af7: Expected Obj, but got I4
		//IL_0022: Expected F4, but got I
		//IL_0032: Expected Obj, but got I
		//IL_0042: Invalid comparison between F4 and I
		//IL_0116: Expected F4, but got I
		//IL_016f: Expected F8, but got I4
		//IL_0bac: Expected Obj, but got I4
		//IL_0b2f: Expected Obj, but got I4
		//IL_01a7: Invalid comparison between F4 and I4
		//IL_0091: Invalid comparison between F4 and I4
		//IL_0cd3: Invalid comparison between F4 and I4
		//IL_0ce2: Invalid comparison between F4 and I4
		//IL_0cf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf6: Expected Obj, but got Unknown
		//IL_0d03: Expected Obj, but got F4
		//IL_0d38: Expected Obj, but got I4
		//IL_0d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Expected Obj, but got Unknown
		//IL_0c13: Expected F4, but got I4
		//IL_0c2c: Invalid comparison between F8 and I4
		//IL_0c3b: Invalid comparison between F8 and I4
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4f: Expected Obj, but got Unknown
		//IL_0c5c: Expected Obj, but got F8
		//IL_0c91: Expected Obj, but got I4
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9e: Expected Obj, but got Unknown
		//IL_03ad: Expected F4, but got I4
		//IL_0bd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd7: Expected Obj, but got Unknown
		//IL_0bf1: Expected Obj, but got I4
		//IL_0312: Expected F8, but got I4
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5a: Expected Obj, but got Unknown
		//IL_0b74: Expected Obj, but got I4
		//IL_03cd: Expected Obj, but got I4
		//IL_03dc: Expected Obj, but got I4
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_0424: Expected Obj, but got I
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_044b: Expected Obj, but got I
		//IL_046d: Expected Obj, but got I4
		//IL_049c: Expected Obj, but got I
		//IL_059e: Expected Obj, but got I4
		//IL_05cd: Expected Obj, but got I
		//IL_06b5: Expected Obj, but got I
		//IL_06c5: Expected Obj, but got I
		//IL_06f4: Expected I4, but got F4
		//IL_06f4: Expected I4, but got F8
		//IL_04f9: Expected I, but got Obj
		//IL_0509: Expected Obj, but got I
		//IL_051b: Invalid comparison between Obj and F8
		//IL_073e: Expected Obj, but got I
		//IL_0d85: Expected Obj, but got I4
		//IL_0729: Expected Obj, but got I
		//IL_0633: Expected Obj, but got I
		//IL_0643: Expected Obj, but got I
		//IL_066d: Expected Obj, but got I4
		//IL_053a: Expected I, but got Obj
		//IL_054a: Expected Obj, but got I
		//IL_055c: Invalid comparison between Obj and F4
		//IL_069b: Expected Obj, but got I
		//IL_0774: Expected Obj, but got I4
		//IL_07a0: Expected Obj, but got I4
		//IL_082d: Expected Obj, but got I4
		//IL_084d: Expected Obj, but got I4
		//IL_0863: Expected I, but got Obj
		//IL_0873: Expected Obj, but got I
		//IL_0895: Expected Obj, but got I4
		//IL_08d5: Expected Obj, but got I4
		//IL_08e4: Expected Obj, but got I4
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected Obj, but got Unknown
		//IL_0912: Expected Obj, but got I4
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected Obj, but got Unknown
		//IL_094f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Expected Obj, but got Unknown
		//IL_098a: Expected Obj, but got I4
		//IL_09d2: Expected Obj, but got I4
		//IL_09e1: Expected Obj, but got I4
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a06: Expected Obj, but got Unknown
		//IL_0a0f: Expected Obj, but got I4
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4b: Expected Obj, but got Unknown
		//IL_0a6b: Expected Obj, but got I4
		//IL_0aa9: Expected Obj, but got I
		Camera camera = default;
		bool flag = (object)camera == null;
		UnityEngine.Object obj = (UnityEngine.Object)e;
		if (flag)
		{
			goto IL_0aae;
		}
		float aspect = camera.aspect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		if (aspect < 0f)
		{
			goto IL_0059;
		}
		bool flag2 = (double)aspect > 4.0;
		float num2 = 4f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		float num3 = 0f;
		if (!flag2)
		{
			bool flag3 = (double)aspect < 1.0;
			float num4 = aspect;
			num = aspect;
			num2 = aspect;
			num3 = aspect;
			if (flag3)
			{
				goto IL_0059;
			}
		}
		double num5 = size;
		float num6 = (float)size / num2;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v52+E4]");
		bool flag4 = (nint)0 == 0;
		object obj4 = !flag4;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num7;
		float num8;
		float num9 = default;
		double num10;
		if (num6 < 0f)
		{
			if ((double)num6 == -0.5)
			{
				num7 = -1.0;
				num8 = num9;
				goto IL_0bba;
			}
			num8 = num6 + -0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num10 = -0.5;
		}
		else
		{
			if ((double)num6 == 0.5)
			{
				num7 = 1.0;
				num8 = num9;
				goto IL_0bba;
			}
			num8 = num6 + 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num10 = 0.5;
		}
		goto IL_0cba;
		IL_0b3d:
		double num12;
		double num11;
		num10 = num11 + num12;
		object obj5 = num11 & 1;
		bool flag5 = obj5 == null;
		object obj6 = !flag5;
		if (obj6 != null)
		{
			num11 = num10;
		}
		goto IL_0c09;
		IL_0c09:
		float num13 = size;
		double num14 = num11 - 64.0;
		bool flag6 = num14 < 0.0;
		bool flag7 = num14 == 0.0;
		object obj7 = num11 ^ 0x40;
		object obj8 = num11 ^ num14;
		object obj9 = obj7 & obj8;
		bool flag8 = (nint)obj9 < 0;
		bool flag9 = flag6 == flag8;
		object obj10 = !flag7;
		object obj11 = flag9 & obj10;
		object obj12 = ~obj11;
		num5 = ((obj12 != null) ? 64.0 : num11);
		goto IL_0de0;
		IL_0bba:
		num10 = (double)num8 + num7;
		object obj13 = num8 & 1;
		bool flag10 = obj13 == null;
		object obj14 = !flag10;
		if (obj14 != null)
		{
			num8 = (float)num10;
		}
		goto IL_0cba;
		IL_0059:
		float num15 = num * (float)size;
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v61+E4]");
		bool flag11 = (nint)0 == 0;
		object obj16 = !flag11;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num16 = default;
		if (num15 < 0f)
		{
			if ((double)num15 == -0.5)
			{
				num12 = -1.0;
				num11 = num16;
				goto IL_0b3d;
			}
			num11 = (double)num15 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num10 = -0.5;
		}
		else
		{
			if ((double)num15 == 0.5)
			{
				num12 = 1.0;
				num11 = num16;
				goto IL_0b3d;
			}
			num11 = (double)num15 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num10 = 0.5;
		}
		goto IL_0c09;
		IL_0cba:
		float num17 = num8 - 64f;
		bool flag12 = num17 < 0f;
		bool flag13 = num17 == 0f;
		object obj17 = num8 ^ 0x40;
		object obj18 = num8 ^ num17;
		object obj19 = obj17 & obj18;
		bool flag14 = (nint)obj19 < 0;
		bool flag15 = flag12 == flag14;
		object obj20 = !flag13;
		object obj21 = flag15 & obj20;
		object obj22 = ~obj21;
		if (obj22 == null)
		{
			float num4 = num2;
			num11 = num8;
			num13 = num8;
		}
		else
		{
			float num4 = num2;
			num11 = num8;
			num13 = 64f;
		}
		goto IL_0de0;
		IL_0de0:
		RenderTexture[] array = targets;
		bool flag16 = targets == null;
		obj = null;
		IndexOutOfRangeException ex = default;
		if (!flag16)
		{
			bool flag17 = array.Length < e;
			object obj23 = !flag17;
			object obj24 = array.Length - e;
			bool flag18 = obj24 == null;
			object obj25 = ~obj23;
			object obj26 = obj25 | flag18;
			obj = null;
			if (obj26 != null)
			{
				goto IL_0abc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj27 = 0;
			object obj28 = targets + e;
			object obj29 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v9+20]");
			UnityEngine.Object obj30 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X0_v11+E4]");
			bool flag19 = (nint)0 == 0;
			object obj31 = !flag19;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v9+20]");
			bool flag20 = (UnityEngine.Object)0 != null;
			bool flag21 = !flag20;
			UnityEngine.Object obj32 = null;
			if (!flag21)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v9+20]");
				bool flag22 = (nint)0 == 0;
				camera = null;
				obj = null;
				if (flag22)
				{
					goto IL_0aae;
				}
				nint num18 = (nint)obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X8_v29 (Il2CppClass<UnityEngine.Object>)+190]");
				obj32 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v721 @ X8_v29 (Il2CppClass<UnityEngine.Object>)+188] (should have been resolved before IL gen)");
				object obj33 = default;
				if (obj33 == (object)num5)
				{
					nint num19 = (nint)obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v30 (Il2CppClass<UnityEngine.Object>)+1B0]");
					obj32 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v508 @ X8_v30 (Il2CppClass<UnityEngine.Object>)+1A8] (should have been resolved before IL gen)");
					object obj34 = default;
					if (obj34 == (object)num13)
					{
						return;
					}
				}
			}
			object obj35 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X0_v16+E4]");
			bool flag23 = (nint)0 == 0;
			object obj36 = !flag23;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v9+20]");
			bool flag24 = (UnityEngine.Object)0 != null;
			bool flag25 = !flag24;
			UnityEngine.Object obj37 = null;
			if (!flag25)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v9+20]");
				bool flag26 = (nint)0 == 0;
				camera = null;
				obj = null;
				if (flag26)
				{
					goto IL_0aae;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v9+20]");
				((RenderTexture)0).Release();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC598]");
				object obj38 = 0;
				object obj39 = obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X0_v41+E4]");
				bool flag27 = (nint)0 == 0;
				object obj40 = !flag27;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v9+20]");
				Kill((UnityEngine.Object)0);
				obj37 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8568]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5D8]");
			object obj42 = 0;
			RenderTexture[] array2 = targets;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			RenderTexture renderTexture = default;
			renderTexture._002Ector((int)num5, (int)num13, 24, (RenderTextureFormat)7);
			object obj43;
			if (e == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5D0]");
				obj43 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5C8]");
				obj43 = 0;
			}
			string text = (string)obj42 + (string)obj43;
			bool flag28 = (object)renderTexture == null;
			object obj44 = 0;
			RenderTextureFormat renderTextureFormat = (RenderTextureFormat)7;
			nint num20 = 24;
			camera = null;
			obj = (UnityEngine.Object)obj43;
			if (!flag28)
			{
				renderTexture.name = text;
				renderTexture.antiAliasing = samples;
				object obj45 = samples - 1;
				bool useMipMap = obj45 == null;
				renderTexture.useMipMap = useMipMap;
				object obj46 = samples - 1;
				bool autoGenerateMips = obj46 == null;
				renderTexture.autoGenerateMips = autoGenerateMips;
				FilterMode filterMode = ((samples != 1) ? ((FilterMode)1) : ((FilterMode)2));
				renderTexture.filterMode = filterMode;
				renderTexture.anisoLevel = 2;
				renderTexture.wrapMode = (TextureWrapMode)1;
				renderTexture.hideFlags = (HideFlags)52;
				bool flag29 = targets == null;
				obj44 = 0;
				renderTextureFormat = (RenderTextureFormat)7;
				num20 = 24;
				camera = null;
				obj = (UnityEngine.Object)52;
				if (!flag29)
				{
					nint num21 = (nint)array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v20 (Il2CppClass<UnityEngine.RenderTexture[]>)+40]");
					obj = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag30 = ex == null;
					obj44 = 0;
					renderTextureFormat = (RenderTextureFormat)7;
					num20 = 24;
					camera = null;
					if (flag30)
					{
						goto IL_0aca;
					}
					bool flag31 = array2.Length < e;
					object obj47 = !flag31;
					object obj48 = array2.Length - e;
					bool flag32 = obj48 == null;
					object obj49 = ~obj47;
					object obj50 = obj49 | flag32;
					obj44 = 0;
					renderTextureFormat = (RenderTextureFormat)7;
					num20 = 24;
					camera = null;
					if (obj50 != null)
					{
						goto IL_0abc;
					}
					object obj51 = targets + e;
					object obj52 = obj51 + 32;
					obj52 = renderTexture;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					RenderTexture[] array3 = targets;
					bool flag33 = targets == null;
					obj44 = 0;
					renderTextureFormat = (RenderTextureFormat)7;
					num20 = 24;
					camera = null;
					obj = renderTexture;
					if (!flag33)
					{
						bool flag34 = array3.Length < e;
						object obj53 = !flag34;
						object obj54 = array3.Length - e;
						bool flag35 = obj54 == null;
						object obj55 = ~obj53;
						object obj56 = obj55 | flag35;
						obj44 = 0;
						renderTextureFormat = (RenderTextureFormat)7;
						num20 = 24;
						camera = null;
						obj = renderTexture;
						if (obj56 != null)
						{
							goto IL_0abc;
						}
						object obj57 = targets + e;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v23+20]");
						bool flag36 = (nint)0 == 0;
						obj44 = 0;
						renderTextureFormat = (RenderTextureFormat)7;
						num20 = 24;
						camera = null;
						obj = renderTexture;
						if (!flag36)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v23+20]");
							bool flag37 = ((RenderTexture)0).Create();
							return;
						}
					}
				}
			}
		}
		goto IL_0aae;
		IL_0abc:
		ex = new IndexOutOfRangeException();
		goto IL_0aca;
		IL_0aca:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_0aae:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0abc;
	}

	private unsafe static Matrix4x4 Reflection(Vector3 n, Vector3 point)
	{
		//IL_0049: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_015f: Expected native int or pointer, but got VT
		//IL_0179: Expected F4, but got I
		//IL_0174: Expected native int or pointer, but got VT
		//IL_018e: Expected native int or pointer, but got VT
		//IL_01a8: Expected F4, but got I
		//IL_01a3: Expected native int or pointer, but got VT
		//IL_01d3: Expected native int or pointer, but got VT
		//IL_01e0: Expected native int or pointer, but got VT
		//IL_01ed: Expected native int or pointer, but got VT
		//IL_01fa: Expected native int or pointer, but got VT
		//IL_022a: Expected native int or pointer, but got VT
		//IL_0237: Expected native int or pointer, but got VT
		//IL_0262: Expected native int or pointer, but got VT
		//IL_027c: Expected F4, but got I
		//IL_0277: Expected native int or pointer, but got VT
		//IL_0284: Expected native int or pointer, but got VT
		//IL_0291: Expected native int or pointer, but got VT
		//IL_029e: Expected native int or pointer, but got VT
		//IL_02b8: Expected F4, but got I
		//IL_02b3: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 * obj3;
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 * obj6;
		object obj7 = obj2 + obj2;
		object obj9 = default;
		object obj10 = default;
		object obj8 = obj9 * obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8758]");
		object obj11 = 0;
		object obj12 = obj5 + obj5;
		double num = (double)obj9 * -2.0;
		double num2 = (double)obj2 * -2.0;
		object obj13 = obj9 + obj9;
		object obj14 = obj11;
		object obj15 = obj + obj4;
		double num3 = (double)obj5 * -2.0;
		object obj16 = obj2 * obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+A0]");
		object obj17 = 0;
		object obj18 = obj5 * obj12;
		double num4 = (double)obj2 * num;
		double num5 = (double)obj5 * num;
		object obj19 = obj8 + obj15;
		double num6 = (double)obj9 * num3;
		double num7 = 1.0 - (double)obj16;
		double num8 = (double)obj2 * num3;
		double num9 = (double)obj9 * num2;
		object obj20 = obj9 * obj13;
		Matrix4x4 matrix4x = default;
		((Matrix4x4*)(nint)matrix4x)->m20 = (float)num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v5+4C]");
		((Matrix4x4*)(nint)matrix4x)->m30 = 0f;
		object obj21 = obj19 + obj19;
		((Matrix4x4*)(nint)matrix4x)->m21 = (float)num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v5+5C]");
		((Matrix4x4*)(nint)matrix4x)->m31 = 0f;
		double num10 = (double)obj5 * num2;
		double num11 = 1.0 - (double)obj18;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)num7;
		((Matrix4x4*)(nint)matrix4x)->m10 = (float)num8;
		((Matrix4x4*)(nint)matrix4x)->m02 = (float)num9;
		((Matrix4x4*)(nint)matrix4x)->m12 = (float)num6;
		double num12 = 1.0 - (double)obj20;
		float m = (float)obj2 * (float)obj21;
		((Matrix4x4*)(nint)matrix4x)->m01 = (float)num10;
		((Matrix4x4*)(nint)matrix4x)->m11 = (float)num11;
		float m2 = (float)obj5 * (float)obj21;
		float m3 = (float)obj9 * (float)obj21;
		((Matrix4x4*)(nint)matrix4x)->m22 = (float)num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v5+6C]");
		((Matrix4x4*)(nint)matrix4x)->m32 = 0f;
		((Matrix4x4*)(nint)matrix4x)->m03 = m;
		((Matrix4x4*)(nint)matrix4x)->m13 = m2;
		((Matrix4x4*)(nint)matrix4x)->m23 = m3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v5+7C]");
		((Matrix4x4*)(nint)matrix4x)->m33 = 0f;
		return (Matrix4x4)n;
	}

	private static Vector4 CameraSpacePlane(Matrix4x4 view, Vector3 point, Vector3 normal)
	{
		//IL_00eb: Expected Obj, but got I
		//IL_00f3: Expected VT, but got Obj
		//IL_0115: Expected Obj, but got I4
		//IL_006f: Invalid comparison between F4 and I
		object obj = default;
		float num = (float)obj * view.m20;
		object obj2 = default;
		float num2 = (float)obj2 * view.m21;
		object obj3 = default;
		float num3 = (float)obj3 * view.m22;
		float num4 = num + num2;
		float num5 = num4 + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj4 = 0;
		Vector4 result = (Vector4)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v4 (UnityEngine.Vector4)+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num6 = num5 * num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		if (num6 > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		return result;
	}

	private unsafe static Matrix4x4 Oblique(Matrix4x4 proj, Vector4 clipPlane)
	{
		//IL_0009: Expected Ref, but got VT
		//IL_0069: Expected Ref, but got VT
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00a9: Expected Obj, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0130: Expected Obj, but got I4
		//IL_0384: Expected native int or pointer, but got VT
		//IL_0391: Expected native int or pointer, but got VT
		//IL_039e: Expected native int or pointer, but got VT
		//IL_03ab: Expected native int or pointer, but got VT
		//IL_03bd: Expected native int or pointer, but got VT
		//IL_03cf: Expected native int or pointer, but got VT
		//IL_03e1: Expected native int or pointer, but got VT
		//IL_03f3: Expected native int or pointer, but got VT
		Matrix4x4 matrix4x = Matrix4x4.Internal_Inverse(ref *(Matrix4x4*)proj);
		Matrix4x4 m = default;
		Matrix4x4 matrix4x2 = Matrix4x4.Internal_Transpose(ref m);
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 * obj3;
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 * obj6;
		object obj7 = obj + obj4;
		object obj9 = default;
		object obj10 = default;
		object obj8 = obj9 * obj10;
		object obj11 = obj7 + obj8;
		Matrix4x4 result = Matrix4x4.Internal_Inverse(ref *(Matrix4x4*)proj);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		object obj12 = obj11 & 1;
		bool flag = obj12 == null;
		object obj13 = !flag;
		object obj14 = ~obj13;
		double num = ((obj14 != null) ? 1.0 : (-1.0));
		object obj16 = default;
		object obj15 = obj16 & 1;
		bool flag2 = obj15 == null;
		object obj17 = !flag2;
		object obj18 = ~obj17;
		double num2 = ((obj18 != null) ? 1.0 : (-1.0));
		double num3 = num * (double)obj2;
		object obj19 = default;
		double num4 = num * (double)obj19;
		double num5 = num2 * (double)obj5;
		object obj20 = default;
		double num6 = num2 * (double)obj20;
		object obj21 = default;
		double num7 = num * (double)obj21;
		object obj22 = default;
		double num8 = num2 * (double)obj22;
		object obj23 = default;
		double num9 = num * (double)obj23;
		object obj24 = default;
		double num10 = num2 * (double)obj24;
		double num11 = num3 + num5;
		double num12 = num4 + num6;
		double num13 = num7 + num8;
		double num14 = num9 + num10;
		double num15 = num11 + (double)obj9;
		object obj25 = default;
		double num16 = num12 + (double)obj25;
		object obj26 = default;
		double num17 = num13 + (double)obj26;
		object obj27 = default;
		double num18 = num14 + (double)obj27;
		object obj28 = default;
		double num19 = num15 + (double)obj28;
		object obj29 = default;
		double num20 = num16 + (double)obj29;
		object obj30 = default;
		double num21 = num17 + (double)obj30;
		object obj31 = default;
		double num22 = (double)obj31 * num19;
		object obj32 = default;
		double num23 = (double)obj32 * num20;
		object obj33 = default;
		double num24 = num18 + (double)obj33;
		object obj34 = default;
		double num25 = (double)obj34 * num21;
		double num26 = num22 + num23;
		object obj35 = default;
		double num27 = (double)obj35 * num24;
		double num28 = num25 + num26;
		double num29 = num27 + num28;
		double num30 = 2.0 / num29;
		double num31 = (double)obj31 * num30;
		double num32 = (double)obj32 * num30;
		double num33 = (double)obj34 * num30;
		double num34 = (double)obj35 * num30;
		double num35 = num31 - (double)proj.m30;
		double num36 = num32 - (double)proj.m31;
		double num37 = num33 - (double)proj.m32;
		double num38 = num34 - (double)proj.m33;
		((Matrix4x4*)(nint)proj)->m20 = (float)num35;
		((Matrix4x4*)(nint)proj)->m21 = (float)num36;
		((Matrix4x4*)(nint)proj)->m23 = (float)num38;
		((Matrix4x4*)(nint)proj)->m22 = (float)num37;
		Matrix4x4 matrix4x3 = default;
		((Matrix4x4*)(nint)matrix4x3)->m00 = proj.m00;
		((Matrix4x4*)(nint)matrix4x3)->m01 = proj.m01;
		((Matrix4x4*)(nint)matrix4x3)->m02 = proj.m02;
		((Matrix4x4*)(nint)matrix4x3)->m03 = proj.m03;
		return result;
	}

	public void Release()
	{
		//IL_0586: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I4
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected Obj, but got Unknown
		//IL_05be: Expected Obj, but got I4
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected Obj, but got Unknown
		//IL_03bb: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I4
		//IL_04d7: Expected Obj, but got I4
		//IL_0420: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I
		//IL_053b: Expected Obj, but got I4
		//IL_046a: Expected Obj, but got I4
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_0353: Expected Obj, but got I4
		//IL_035c: Expected Obj, but got I4
		//IL_0365: Expected Obj, but got I4
		//IL_0499: Expected Obj, but got I4
		//IL_0118: Expected Obj, but got I4
		//IL_014f: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got I4
		//IL_01b0: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I4
		//IL_024a: Expected Obj, but got I4
		//IL_0278: Expected Obj, but got I
		//IL_029c: Expected Obj, but got I4
		//IL_02d3: Expected Obj, but got I4
		RenderTexture[] array = targets;
		bool flag = targets == null;
		IntPtr intPtr = default;
		UnityEngine.Object obj = (UnityEngine.Object)(nint)intPtr;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC598]");
			object obj3 = 0;
			object obj5 = default;
			object obj4 = obj5;
			object obj6 = 32;
			object obj7 = 4;
			object obj24;
			do
			{
				object obj8 = obj7 - 4;
				bool flag2 = (nint)obj8 < array.Length;
				object obj9 = !flag2;
				bool flag3 = (nint)obj8 >= array.Length;
				obj5 = obj4;
				obj = obj;
				object obj10 = obj6;
				if (!flag3)
				{
					bool flag4 = (nint)obj8 < array.Length;
					obj9 = !flag4;
					if (obj9 == null)
					{
						object obj11 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v28+E4]");
						bool flag5 = (nint)0 == 0;
						object obj12 = !flag5;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v10 (UnityEngine.RenderTexture[])+v142 @ X21_v9*8]");
						bool flag6 = (UnityEngine.Object)0 != null;
						bool flag7 = !flag6;
						obj = null;
						if (flag7)
						{
							goto IL_0311;
						}
						RenderTexture[] array2 = targets;
						bool flag8 = targets == null;
						obj5 = 0;
						obj = null;
						obj10 = obj6;
						if (flag8)
						{
							break;
						}
						bool flag9 = (nint)obj8 < array2.Length;
						obj9 = !flag9;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v14 (UnityEngine.RenderTexture[])+v142 @ X21_v9*8]");
							bool flag10 = (nint)0 == 0;
							obj5 = 0;
							obj = null;
							obj10 = obj6;
							if (flag10)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v14 (UnityEngine.RenderTexture[])+v142 @ X21_v9*8]");
							((RenderTexture)0).Release();
							RenderTexture[] array3 = targets;
							bool flag11 = targets == null;
							obj5 = 0;
							obj = null;
							obj10 = obj6;
							if (flag11)
							{
								break;
							}
							bool flag12 = (nint)obj8 < array3.Length;
							obj9 = !flag12;
							if (obj9 == null)
							{
								object obj13 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v34+E4]");
								bool flag13 = (nint)0 == 0;
								object obj14 = !flag13;
								if (obj14 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v15 (UnityEngine.RenderTexture[])+v142 @ X21_v9*8]");
								Kill((UnityEngine.Object)0);
								RenderTexture[] array4 = targets;
								bool flag14 = targets == null;
								obj5 = 0;
								obj = null;
								obj10 = obj6;
								if (flag14)
								{
									break;
								}
								bool flag15 = (nint)obj8 < array4.Length;
								obj9 = !flag15;
								if (obj9 == null)
								{
									object obj15 = (object)targets + obj6;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									obj = null;
									goto IL_0311;
								}
							}
						}
					}
					throw new IndexOutOfRangeException();
				}
				object obj16 = obj2;
				object obj17 = this + 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v3+E4]");
				bool flag16 = (nint)0 == 0;
				object obj18 = !flag16;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag17 = (UnityEngine.Object)obj17 != null;
				bool flag18 = !flag17;
				UnityEngine.Object obj19 = null;
				if (!flag18)
				{
					bool flag19 = obj17 == null;
					obj5 = 0;
					obj = null;
					if (flag19)
					{
						break;
					}
					GameObject o = ((Component)obj17).gameObject;
					object obj20 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v8+E4]");
					bool flag20 = (nint)0 == 0;
					object obj21 = !flag20;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Kill(o);
					obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj19 = null;
				}
				object obj22 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v8+E4]");
				bool flag21 = (nint)0 == 0;
				object obj23 = !flag21;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (glass != null)
				{
					bool flag22 = (object)glass == null;
					obj5 = 0;
					obj = null;
					if (flag22)
					{
						break;
					}
					glass.SetPropertyBlock(null);
				}
				return;
				IL_0311:
				array = targets;
				obj7++;
				obj10 = obj6 + 8;
				bool flag23 = targets == null;
				obj24 = !flag23;
				obj5 = 0;
				obj4 = 0;
				obj6 = obj10;
			}
			while (obj24 != null);
		}
		throw new NullReferenceException();
	}

	private static void Kill(UnityEngine.Object o)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isPlaying = Application.isPlaying;
		object obj5 = obj3;
		if (isPlaying)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(o);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.DestroyImmediate(o);
		}
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0071: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5208]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC568]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction unityAction = default;
		unityAction._002Ector(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.onBeforeRender -= unityAction;
		Release();
	}

	public MirrorSurface()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0135: Expected I4, but got I8
		//IL_0143: Expected I4, but got I8
		//IL_0163: Expected F4, but got I
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7350]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107DBB0]");
		textureSize = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BFA0]");
		quest2FrameSkip = 0;
		quest2Msaa = 2;
		LayerMask layerMask = -1;
		reflectionMask = layerMask;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B948]");
		farClip = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj4 = this + 88;
		object obj5 = default;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj6 = this + 96;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = this + 104;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj10 = this + 112;
		object obj11 = default;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj12 = this + 120;
		object obj13 = default;
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		skip = 1;
		samples = 1;
		base._002Ector();
	}

	static MirrorSurface()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I
		//IL_01e8: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5F0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC598]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5F8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC600]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC608]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A80]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41A0]");
		object obj7 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v3+A0]");
		object obj9 = 0;
		obj9 = num;
		int num2 = Shader.PropertyToID((string)obj3);
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+A0]");
		object obj11 = 0;
		int num3 = Shader.PropertyToID((string)obj4);
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v7+A0]");
		object obj13 = 0;
		int num4 = Shader.PropertyToID((string)obj5);
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v9+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v11+A0]");
		object obj17 = (nint)0 + (nint)16;
		obj17 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list2 = default;
		list2._002Ector();
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v12+A0]");
		object obj19 = (nint)0 + (nint)24;
		obj19 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list3 = default;
		list3._002Ector();
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v13+A0]");
		object obj21 = (nint)0 + (nint)32;
		obj21 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v14+A0]");
		object obj23 = 0;
		_ = 4294967295L;
	}
}
