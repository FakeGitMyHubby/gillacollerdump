using System;
using Cpp2ILInjected;
using Liv.Lck;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.Universal;

public class GillaLivLens : MonoBehaviour, _0021_00210
{
	public const string Id = null;

	private Camera Cam__BackingField;

	private UniversalAdditionalCameraData Data__BackingField;

	public Camera Cam
	{
		get
		{
			return Cam__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public UniversalAdditionalCameraData Data
	{
		get
		{
			return Data__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public string CameraId
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1DC0]");
			return (string)0;
		}
	}

	public static GillaLivLens Make()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0137: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1DC0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector((string)obj2);
		if ((object)gameObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8558]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			Behaviour behaviour = default;
			if ((object)behaviour != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2128]");
				object obj4 = 0;
				behaviour.enabled = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				ILckCamera lckCamera = default;
				if (lckCamera != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D08]");
					object obj5 = 0;
					object obj6 = lckCamera + 32;
					obj6 = behaviour;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					UniversalAdditionalCameraData universalAdditionalCameraData = Configure((Camera)behaviour, post: false);
					object obj7 = lckCamera + 40;
					obj7 = universalAdditionalCameraData;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj8 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v17+E4]");
					bool flag = (nint)0 == 0;
					object obj9 = !flag;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					LckMediator.RegisterCamera(lckCamera);
					return (GillaLivLens)lckCamera;
				}
			}
		}
		return (GillaLivLens)(object)new NullReferenceException();
	}

	public static UniversalAdditionalCameraData Configure(Camera cam, bool post)
	{
		if ((object)cam != null)
		{
			cam.stereoTargetEye = (StereoTargetEyeMask)0;
			cam.allowMSAA = false;
			UniversalAdditionalCameraData universalAdditionalCameraData = CameraExtensions.GetUniversalAdditionalCameraData(cam);
			if ((object)universalAdditionalCameraData != null)
			{
				universalAdditionalCameraData.m_AllowXRRendering = false;
				universalAdditionalCameraData.m_RenderPostProcessing = post;
				universalAdditionalCameraData.m_RequiresDepthTextureOption = (CameraOverrideOption)0;
				universalAdditionalCameraData.m_RequiresOpaqueTextureOption = (CameraOverrideOption)0;
				return universalAdditionalCameraData;
			}
		}
		return (UniversalAdditionalCameraData)(object)new NullReferenceException();
	}

	public unsafe static RenderTexture TargetLike(int width, int height)
	{
		//IL_0010: Expected Obj, but got I
		//IL_002c: Expected VT, but got Ref
		//IL_005e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8568]");
		object obj = 0;
		RenderTextureDescriptor renderTextureDescriptor = new RenderTextureDescriptor(width, height, (GraphicsFormat)8, (GraphicsFormat)92);
		renderTextureDescriptor.useMipMap = false;
		renderTextureDescriptor.sRGB = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		RenderTexture renderTexture = default;
		object obj2 = default;
		renderTexture._002Ector((RenderTextureDescriptor)(&obj2));
		if ((object)renderTexture != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2130]");
			object obj3 = 0;
			renderTexture.antiAliasing = 1;
			renderTexture.filterMode = (FilterMode)0;
			renderTexture.name = (string)obj3;
			bool flag = renderTexture.Create();
			return renderTexture;
		}
		return (RenderTexture)(object)new NullReferenceException();
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D08]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1DC0]");
		object id = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ILckCamera cameraById = LckMediator.GetCameraById((string)id);
		if (cameraById == this)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			LckMediator.UnregisterCamera((ILckCamera)this);
		}
	}

	public void ActivateCamera(RenderTexture renderTexture)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I4
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
		if (!(Cam__BackingField == null))
		{
			Cam__BackingField.targetTexture = renderTexture;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = renderTexture != null;
			Cam__BackingField.enabled = flag3;
		}
	}

	public void DeactivateCamera()
	{
		//IL_0010: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I4
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
		if (!(Cam__BackingField == null))
		{
			Cam__BackingField.enabled = false;
			Cam__BackingField.targetTexture = null;
		}
	}

	public Camera GetCameraComponent()
	{
		return Cam__BackingField;
	}
}
