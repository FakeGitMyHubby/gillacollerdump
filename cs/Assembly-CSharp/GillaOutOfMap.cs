using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using GorillaLocomotion;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GillaOutOfMap : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public Vector3 pop;

		internal void _003CDrop_003Eb__0(NetworkRunner r, NetworkObject o)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected Obj, but got Unknown
			//IL_0058: Expected VT, but got I4
			//IL_0074: Expected VT, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F70]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
			object obj3 = default;
			object obj2 = obj3 & 1;
			if (obj2 != null)
			{
				Rigidbody rigidbody = default;
				rigidbody.linearVelocity = (Vector3)0;
				Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
				rigidbody.angularVelocity = (Vector3)0;
			}
		}
	}

	public struct Reading
	{
		public int backs;

		public int fronts;

		public int open;

		public bool solid;

		public bool Out
		{
			get
			{
				//IL_0058: Expected Obj, but got I4
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0096: Expected I4, but got Unknown
				//IL_00cb: Expected Obj, but got I4
				//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Expected I4, but got Unknown
				if (~(solid ? 1u : 0u) == 0)
				{
					return true;
				}
				if (backs < 3)
				{
					return false;
				}
				object obj = backs - fronts;
				bool flag = (nint)obj < 0;
				bool flag2 = obj == null;
				int num = backs ^ fronts;
				int num2 = backs ^ obj;
				int num3 = num & num2;
				bool flag3 = num3 < 0;
				bool flag4 = flag == flag3;
				object obj2 = !flag2;
				return (byte)((flag4 & obj2) ? 1 : 0) != 0;
			}
		}

		public override string ToString()
		{
			//IL_00b5: Expected Obj, but got I
			//IL_0088: Expected Obj, but got I
			//IL_0015: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj = 0;
			string format;
			object arg;
			object arg2;
			if (~(solid ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57C8]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				format = (string)obj2;
				object obj3 = default;
				arg = obj3;
				object obj4 = default;
				arg2 = obj4;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57C0]");
				object obj5 = 0;
				format = (string)obj5;
				object obj6 = default;
				arg = obj6;
				object obj7 = default;
				arg2 = obj7;
			}
			object arg3 = default;
			return string.Format(format, arg2, arg, arg3);
		}
	}

	public const float LookEvery = default(float);

	public const float OutFor = default(float);

	public const float Reach = default(float);

	private const float KeepEvery = default(float);

	private const int Kept = default(int);

	private const float BeforeOut = default(float);

	private const float FloorWithin = default(float);

	public const int NotSolid = default(int);

	private static readonly Vector3[] Ways;

	private static readonly Collider[] touching;

	private static int PutBacks__BackingField;

	private static Reading Last__BackingField;

	public static bool CheckInTests;

	private Player gt;

	private Transform head;

	private float nextLook;

	private float nextKeep;

	private float outSince;

	private readonly GillaOutfits.Spot[] kept;

	private int keptNext;

	private int keptCount;

	public static int PutBacks
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5768]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+10]");
			return 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5768]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = 0;
		}
	}

	public static Reading Last
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected VT, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5768]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+14]");
			return (Reading)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5768]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+A0]");
			object obj4 = 0;
		}
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5768]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v8+A0]");
		object obj6 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v8+A0]");
		object obj8 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v8+A0]");
		object obj9 = 0;
		_ = 0;
	}

	private static void Boot()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		//IL_00ed: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I4
		//IL_006a: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4380]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5770]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4390]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5768]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction = default;
		unityAction._002Ector((object)null, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction2 = default;
		unityAction2._002Ector((object)null, (IntPtr)obj2);
		SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction2;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Attach();
	}

	private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5768]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Attach();
	}

	private static void Attach()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I4
		//IL_0352: Expected Obj, but got I
		//IL_0374: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_032c: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I4
		//IL_02f4: Expected Obj, but got I4
		//IL_0392: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I4
		//IL_023f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj15;
		if ((UnityEngine.Object)obj8 != null)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v35+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v39+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v39+A0]");
			object obj14 = 0;
			obj15 = (UnityEngine.Object)obj14;
		}
		else
		{
			object obj16 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F50]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v30+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD36C");
			UnityEngine.Object obj19 = default;
			obj15 = obj19;
		}
		object obj20 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v11+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = obj15 == null;
		bool flag9 = !flag8;
		object obj22 = !flag9;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5778]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			object obj24 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v14+E4]");
			bool flag10 = (nint)0 == 0;
			object obj25 = !flag10;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj26 = default;
			if (!(obj26 != null))
			{
				GameObject gameObject = ((Component)obj15).gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5780]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			}
		}
	}

	private unsafe static Vector3[] MakeWays()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I
		//IL_0184: Expected VT, but got I
		//IL_00f3: Expected Obj, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_011e: Expected Obj, but got I
		//IL_0b76: Expected Obj, but got I
		//IL_0b86: Expected Obj, but got I
		//IL_0b9c: Expected Obj, but got I
		//IL_01b7: Expected Obj, but got I4
		//IL_0247: Expected Obj, but got I
		//IL_0257: Expected Obj, but got I
		//IL_026c: Expected VT, but got I
		//IL_01db: Expected Obj, but got I
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_0206: Expected Obj, but got I
		//IL_0be6: Expected Obj, but got I
		//IL_0bf6: Expected Obj, but got I
		//IL_0c0c: Expected Obj, but got I
		//IL_029f: Expected Obj, but got I4
		//IL_032f: Expected Obj, but got I
		//IL_033f: Expected Obj, but got I
		//IL_0354: Expected VT, but got I
		//IL_02c3: Expected Obj, but got I
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_02ee: Expected Obj, but got I
		//IL_0c56: Expected Obj, but got I
		//IL_0c66: Expected Obj, but got I
		//IL_0c7c: Expected Obj, but got I
		//IL_0387: Expected Obj, but got I4
		//IL_0417: Expected Obj, but got I
		//IL_0427: Expected Obj, but got I
		//IL_043c: Expected VT, but got I
		//IL_03ab: Expected Obj, but got I
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_03d6: Expected Obj, but got I
		//IL_0cc6: Expected Obj, but got I
		//IL_0cd6: Expected Obj, but got I
		//IL_0cec: Expected Obj, but got I
		//IL_046f: Expected Obj, but got I4
		//IL_04ff: Expected Obj, but got I
		//IL_050f: Expected Obj, but got I
		//IL_0524: Expected VT, but got I
		//IL_0493: Expected Obj, but got I
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_04be: Expected Obj, but got I
		//IL_0d36: Expected Obj, but got I
		//IL_0d46: Expected Obj, but got I
		//IL_0d56: Expected Obj, but got I
		//IL_0d66: Expected Obj, but got I
		//IL_0d7c: Expected Obj, but got I
		//IL_0557: Expected Obj, but got I4
		//IL_05e7: Expected Obj, but got I
		//IL_05f7: Expected Obj, but got I
		//IL_060c: Expected VT, but got I
		//IL_0621: Expected Obj, but got I
		//IL_062a: Expected Obj, but got I4
		//IL_057b: Expected Obj, but got I
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected Obj, but got Unknown
		//IL_05a6: Expected Obj, but got I
		//IL_0f09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0e: Expected Obj, but got Unknown
		//IL_0f17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1c: Expected Obj, but got Unknown
		//IL_0f2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f31: Expected Obj, but got Unknown
		//IL_0f4b: Expected Obj, but got I
		//IL_0f69: Expected Obj, but got I
		//IL_0658: Expected Obj, but got I4
		//IL_06d9: Expected Obj, but got I
		//IL_06e9: Expected Obj, but got I
		//IL_06f9: Expected VT, but got I
		//IL_070e: Expected VT, but got I
		//IL_071f: Expected Obj, but got I4
		//IL_067c: Expected Obj, but got I
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected Obj, but got Unknown
		//IL_06a7: Expected Obj, but got I
		//IL_06c4: Expected VT, but got Ref
		//IL_0dbe: Expected Obj, but got I
		//IL_0ded: Expected Obj, but got I4
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected Obj, but got Unknown
		//IL_0777: Expected Obj, but got I
		//IL_0808: Expected Obj, but got I
		//IL_0820: Expected Obj, but got I
		//IL_0e0b: Expected Obj, but got I
		//IL_0e29: Expected Obj, but got I
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected Obj, but got Unknown
		//IL_084e: Expected Obj, but got I4
		//IL_08c1: Expected Obj, but got I
		//IL_08d1: Expected Obj, but got I
		//IL_08e1: Expected VT, but got I
		//IL_08f6: Expected VT, but got I
		//IL_0872: Expected Obj, but got I
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected Obj, but got Unknown
		//IL_089d: Expected Obj, but got I
		//IL_0e6b: Expected Obj, but got I
		//IL_0e9a: Expected Obj, but got I4
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Expected Obj, but got Unknown
		//IL_0956: Expected Obj, but got I
		//IL_09e7: Expected Obj, but got I
		//IL_09ff: Expected Obj, but got I
		//IL_0eb8: Expected Obj, but got I
		//IL_0ed6: Expected Obj, but got I
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ca: Expected Obj, but got Unknown
		//IL_0a2d: Expected Obj, but got I4
		//IL_0aa0: Expected Obj, but got I
		//IL_0ab0: Expected Obj, but got I
		//IL_0ac5: Expected VT, but got I
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae0: Expected Obj, but got Unknown
		//IL_0a51: Expected Obj, but got I
		//IL_0a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Expected Obj, but got Unknown
		//IL_0a7c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector3> list = default;
		list._002Ector();
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v6+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
			object obj6 = 0;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
			object obj8 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v7+18]");
				bool flag = num < 0;
				object obj9 = !flag;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj10 = (nint)0 * (nint)12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj11 = 0 + obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					object obj12 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X9_v2+3C]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X9_v2+40]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X9_v2+44]");
					_ = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v3+20]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v91+A8]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v92+70]");
					list.AddWithResize((Vector3)0);
				}
				object obj15 = obj2;
				object obj16 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v11+A0]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
				object obj19 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v12+18]");
					bool flag2 = num2 < 0;
					object obj20 = !flag2;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						object obj21 = (nint)0 * (nint)12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
						object obj22 = 0 + obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						object obj23 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X9_v5+30]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X9_v5+34]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X9_v5+38]");
						_ = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X10_v5+20]");
						object obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v87+A8]");
						object obj25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v88+70]");
						list.AddWithResize((Vector3)0);
					}
					object obj26 = obj2;
					object obj27 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v16+A0]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
					object obj30 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v17+18]");
						bool flag3 = num3 < 0;
						object obj31 = !flag3;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj32 = (nint)0 * (nint)12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj33 = 0 + obj32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							object obj34 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X9_v9+48]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X9_v9+4C]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X9_v9+50]");
							_ = 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X10_v7+20]");
							object obj35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v83+A8]");
							object obj36 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v84+70]");
							list.AddWithResize((Vector3)0);
						}
						object obj37 = obj2;
						object obj38 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v21+A0]");
						object obj39 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
						object obj40 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
						object obj41 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v22+18]");
							bool flag4 = num4 < 0;
							object obj42 = !flag4;
							if (obj42 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								object obj43 = (nint)0 * (nint)12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
								object obj44 = 0 + obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								object obj45 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X9_v13+54]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X9_v13+58]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X9_v13+5C]");
								_ = 0;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X10_v9+20]");
								object obj46 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v79+A8]");
								object obj47 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v80+70]");
								list.AddWithResize((Vector3)0);
							}
							object obj48 = obj2;
							object obj49 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v26+A0]");
							object obj50 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj51 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
							object obj52 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								nint num5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v27+18]");
								bool flag5 = num5 < 0;
								object obj53 = !flag5;
								if (obj53 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									object obj54 = (nint)0 * (nint)12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
									object obj55 = 0 + obj54;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									object obj56 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X9_v17+18]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X9_v17+1C]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X9_v17+20]");
									_ = 0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X10_v11+20]");
									object obj57 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v75+A8]");
									object obj58 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v76+70]");
									list.AddWithResize((Vector3)0);
								}
								object obj59 = obj2;
								object obj60 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v31+A0]");
								object obj61 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
								object obj62 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X9_v21+28]");
								object obj63 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X9_v21+2C]");
								object obj64 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
								object obj65 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									nint num6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v32+18]");
									bool flag6 = num6 < 0;
									object obj66 = !flag6;
									if (obj66 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										object obj67 = (nint)0 * (nint)12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
										object obj68 = 0 + obj67;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										object obj69 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X9_v21+24]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X9_v21+28]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X9_v21+2C]");
										_ = 0;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X10_v13+20]");
										object obj70 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v71+A8]");
										object obj71 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v72+70]");
										list.AddWithResize((Vector3)0);
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
									object obj72 = 0;
									object obj73 = 0;
									object obj84 = default;
									object obj109 = default;
									while (true)
									{
										object obj74 = obj73 * 1119092736;
										object obj75 = obj74 + 1110704128;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
										object obj76 = obj75 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
										object obj77 = 0;
										object obj78 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
										object obj79 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
										if ((nint)0 == 0)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										nint num7 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v38+18]");
										bool flag7 = num7 < 0;
										object obj80 = !flag7;
										if (obj80 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
											object obj81 = (nint)0 * (nint)12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
											object obj82 = 0 + obj81;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
											object obj83 = (nint)0 + (nint)1;
											_ = 0;
											Vector3 vector = (Vector3)(&obj84);
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X9_v27+20]");
											object obj85 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v68+A8]");
											object obj86 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v69+70]");
											Vector3 vector = (Vector3)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v69+70]");
											list.AddWithResize((Vector3)0);
											obj64 = obj84;
											obj63 = 0;
										}
										object obj87 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X8_v41+A0]");
										object obj88 = 0;
										object obj89 = obj72;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X0_v25+E4]");
										bool flag8 = (nint)0 == 0;
										object obj90 = !flag8;
										if (obj90 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										object obj91 = obj84;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X8_v42+2C]");
										object obj92 = obj91 + 0;
										object obj93 = obj92 * obj92;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X8_v42+24]");
										nint num8 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X8_v42+24]");
										object obj94 = num8 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
										object obj95 = obj94 + obj93;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
										if ((nint)obj95 > 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
											object obj96 = obj92 / obj95;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X8_v42+24]");
											object obj97 = 0 / obj93;
										}
										else
										{
											object obj98 = obj2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v66+A0]");
											object obj99 = 0;
											object obj97 = obj99;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v67+8]");
											object obj96 = 0;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
										object obj100 = 0;
										object obj101 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
										object obj102 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
										if ((nint)0 == 0)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										nint num9 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v46+18]");
										bool flag9 = num9 < 0;
										object obj103 = !flag9;
										if (obj103 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
											object obj104 = (nint)0 * (nint)12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
											object obj105 = 0 + obj104;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
											object obj106 = (nint)0 + (nint)1;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X9_v30+20]");
											object obj107 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v63+A8]");
											object obj108 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v64+70]");
											Vector3 vector = (Vector3)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v64+70]");
											list.AddWithResize((Vector3)0);
											obj92 = obj109;
										}
										object obj110 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X8_v49+A0]");
										object obj111 = 0;
										object obj112 = obj72;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X0_v31+E4]");
										bool flag10 = (nint)0 == 0;
										object obj113 = !flag10;
										if (obj113 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										object obj114 = obj84;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X8_v50+20]");
										obj63 = obj114 + 0;
										object obj115 = obj63 * obj63;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X8_v50+18]");
										nint num10 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X8_v50+18]");
										object obj116 = num10 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
										object obj117 = obj116 + obj115;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
										if ((nint)obj117 > 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
											obj64 = obj63 / obj117;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X8_v50+18]");
											object obj118 = 0 / obj115;
										}
										else
										{
											object obj119 = obj2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v61+A0]");
											object obj120 = 0;
											object obj118 = obj120;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v62+8]");
											obj64 = 0;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
										object obj121 = 0;
										object obj122 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
										object obj123 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
										if ((nint)0 == 0)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										nint num11 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v54+18]");
										bool flag11 = num11 < 0;
										object obj124 = !flag11;
										if (obj124 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
											object obj125 = (nint)0 * (nint)12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
											object obj126 = 0 + obj125;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
											object obj127 = (nint)0 + (nint)1;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X9_v33+20]");
											object obj128 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v58+A8]");
											object obj129 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v59+70]");
											list.AddWithResize((Vector3)0);
											obj63 = obj109;
										}
										obj73++;
										if ((nint)obj73 == 4)
										{
											return list.ToArray();
										}
									}
								}
							}
						}
					}
				}
			}
		}
		return (Vector3[])(object)new NullReferenceException();
	}

	public static int Mask(Player player)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I4
		//IL_00a4: Expected I4, but got Obj
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected I4, but got Unknown
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
		if (player != null)
		{
			if ((object)player != null)
			{
				return (int)(player.locomotionEnabledLayers & 0xFFFFE0FBL);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
		return 0;
	}

	public unsafe static Reading Read(Vector3 eyes, int mask)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a53: Expected Obj, but got I
		//IL_0a75: Expected Obj, but got I4
		//IL_0cdd: Expected Obj, but got I
		//IL_0d00: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I
		//IL_006e: Expected Obj, but got VT
		//IL_006e: Expected VT, but got I
		//IL_03ba: Expected Obj, but got VT
		//IL_03c3: Expected Obj, but got I4
		//IL_0b57: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I
		//IL_00b8: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got VT
		//IL_00d2: Expected Obj, but got I4
		//IL_040a: Expected Obj, but got I4
		//IL_0b1f: Expected Obj, but got I4
		//IL_0b75: Expected Obj, but got I
		//IL_0b95: Expected Obj, but got I4
		//IL_0b9d: Expected Obj, but got I4
		//IL_0baa: Expected Obj, but got Ref
		//IL_0a93: Expected Obj, but got I
		//IL_0aa3: Expected Obj, but got I
		//IL_093a: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_07f8: Expected Obj, but got I4
		//IL_0801: Expected Obj, but got I4
		//IL_0c22: Expected Obj, but got I4
		//IL_0c2a: Expected Obj, but got I4
		//IL_0c37: Expected Obj, but got Ref
		//IL_0c40: Expected Obj, but got I4
		//IL_046e: Expected Obj, but got I8
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_0485: Expected Obj, but got I4
		//IL_048e: Expected Obj, but got I4
		//IL_0497: Expected Obj, but got I4
		//IL_04c1: Expected Obj, but got I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0142: Expected Obj, but got I
		//IL_0cb7: Expected Obj, but got I4
		//IL_0d27: Expected Obj, but got I4
		//IL_0d30: Expected Obj, but got I4
		//IL_0d38: Expected Obj, but got I4
		//IL_0d45: Expected Obj, but got Ref
		//IL_0d4f: Expected Obj, but got I4
		//IL_085b: Expected Obj, but got I4
		//IL_0177: Expected I, but got Obj
		//IL_01a0: Expected Obj, but got I4
		//IL_09d0: Expected Obj, but got I4
		//IL_04f0: Expected Obj, but got I4
		//IL_0243: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I4
		//IL_0a1f: Expected Obj, but got I4
		//IL_0a28: Expected Obj, but got I4
		//IL_0a31: Expected Obj, but got I4
		//IL_08a0: Expected Obj, but got I4
		//IL_0536: Expected VT, but got Ref
		//IL_01d4: Expected Obj, but got I
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Expected Obj, but got Unknown
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Expected Obj, but got Unknown
		//IL_071c: Expected Obj, but got I4
		//IL_0734: Expected Obj, but got I
		//IL_074e: Expected Obj, but got VT
		//IL_075e: Expected Obj, but got I
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad6: Expected Obj, but got Unknown
		//IL_02cf: Expected Obj, but got I
		//IL_020c: Expected Obj, but got I
		//IL_0915: Expected VT, but got Obj
		//IL_0bd1: Expected Obj, but got I
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdf: Expected Obj, but got Unknown
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Expected Obj, but got Unknown
		//IL_0586: Expected Obj, but got I4
		//IL_08f2: Expected Obj, but got I4
		//IL_08fa: Expected VT, but got Obj
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected Obj, but got Unknown
		//IL_05e1: Expected VT, but got Ref
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_077d: Expected Obj, but got I4
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected Obj, but got Unknown
		//IL_06b7: Expected Obj, but got I
		//IL_06d1: Expected Obj, but got VT
		//IL_06e1: Expected Obj, but got I
		//IL_0636: Invalid comparison between Obj and F4
		//IL_0647: Expected Obj, but got I4
		//IL_065f: Invalid comparison between F4 and I4
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected Obj, but got Unknown
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected Obj, but got Unknown
		//IL_07b8: Expected Obj, but got I
		//IL_07d2: Expected Obj, but got VT
		//IL_07e2: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5768]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X9_v1+8]");
		float num2 = default;
		int num = Physics.OverlapSphereNonAlloc((Vector3)0, num2, (Collider[])eyes, 1, (QueryTriggerInteraction)0);
		Collider[] array;
		object obj12;
		object obj28;
		object obj29 = default;
		object obj30 = default;
		object obj31;
		object obj32 = default;
		float num7;
		QueryTriggerInteraction queryTriggerInteraction;
		object obj9;
		if (num >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4370]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj10 = 0;
			object obj11 = 0;
			int num3 = 1;
			array = (Collider[])eyes;
			obj12 = 0;
			object obj27;
			do
			{
				object obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v62+E4]");
				bool flag3 = (nint)0 == 0;
				object obj14 = !flag3;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj13 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v62+A0]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v35+8]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v35+8]");
				if ((nint)0 != 0)
				{
					object obj17 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v36+18]");
					bool flag4 = (nint)obj17 < 0;
					object obj18 = !flag4;
					if (obj18 != null)
					{
						goto IL_0928;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v35+8]");
					object obj19 = 0 + obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v39+20]");
					Collider collider = (Collider)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v39+20]");
					if ((nint)0 != 0)
					{
						object obj20 = obj9;
						nint num4 = (nint)collider;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X9_v19 (Il2CppClass<UnityEngine.Collider>)+130]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v40+130]");
						bool flag5 = num5 < 0;
						object obj21 = !flag5;
						object obj22 = ~obj21;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X9_v19 (Il2CppClass<UnityEngine.Collider>)+B0]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v40+130]");
							object obj23 = num6 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X9_v24-8]");
							if (0 == (nint)obj20)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v39+20]");
								bool convex = ((MeshCollider)0).convex;
								bool flag6 = !convex;
								array = null;
								if (flag6)
								{
									goto IL_0ac8;
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v39+20]");
						Rigidbody attachedRigidbody = ((Collider)0).attachedRigidbody;
						object obj24 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v42+E4]");
						bool flag7 = (nint)0 == 0;
						object obj25 = !flag7;
						if (obj25 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag8 = attachedRigidbody != null;
						bool flag9 = !flag8;
						Collider[] array2 = null;
						if (!flag9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v39+20]");
							Rigidbody attachedRigidbody2 = ((Collider)0).attachedRigidbody;
							bool flag10 = (object)attachedRigidbody2 == null;
							num3 = 0;
							array = null;
							if (flag10)
							{
								goto IL_091a;
							}
							bool isKinematic = attachedRigidbody2.isKinematic;
							bool flag11 = !isKinematic;
							array2 = null;
							num3 = 0;
							array = null;
							if (flag11)
							{
								goto IL_0ac8;
							}
						}
						object obj26 = obj12 & -1095216660481L;
						obj12 = obj26 | 0x100000000L;
						num3 = 0;
						array = array2;
						goto IL_0ac8;
					}
				}
				goto IL_091a;
				IL_0ac8:
				obj11++;
				if ((nint)obj11 >= num)
				{
					break;
				}
				obj27 = obj12 & 0x100000000L;
				continue;
				IL_0928:
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				obj28 = 0;
				queryTriggerInteraction = (QueryTriggerInteraction)0;
				obj29 = obj30;
				obj31 = obj32;
				num7 = num2;
				goto IL_0960;
				IL_091a:
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_0928;
			}
			while (obj27 == null);
		}
		else
		{
			int num3 = 1;
			array = (Collider[])eyes;
			obj12 = 0;
		}
		object obj33 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v16+E4]");
		bool flag12 = (nint)0 == 0;
		object obj34 = !flag12;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool queriesHitBackfaces = Physics.queriesHitBackfaces;
		object obj35 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v21+E4]");
		bool flag13 = (nint)0 == 0;
		object obj36 = !flag13;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj35 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v21+A0]");
		object obj37 = 0;
		object obj38 = obj37;
		bool flag14 = obj37 == null;
		object obj39 = 0;
		obj28 = queriesHitBackfaces;
		NullReferenceException ex3 = null;
		object obj40 = (object)(&obj28);
		queryTriggerInteraction = (QueryTriggerInteraction)0;
		if (flag14)
		{
			goto IL_098c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X23_v5+18]");
		object obj42;
		object obj44;
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X23_v5+18]");
			object obj41 = 0 & 0xFFFFFFFFL;
			object obj11 = obj37 + 40;
			obj42 = 0;
			object obj43 = 17276928;
			obj44 = 0;
			queryTriggerInteraction = (QueryTriggerInteraction)0;
			obj29 = obj30;
			obj31 = obj32;
			num7 = num2;
			obj = 0;
			object obj48 = default;
			QueryTriggerInteraction queryTriggerInteraction2 = default;
			object obj52 = default;
			object obj53 = default;
			object obj54 = default;
			while (true)
			{
				bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj41);
				object obj45 = !flag15;
				obj39 = 0;
				obj28 = queriesHitBackfaces;
				ex3 = null;
				obj40 = (object)(&obj28);
				obj9 = 1109393408;
				if (obj45 != null)
				{
					break;
				}
				object obj46 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X0_v24+E4]");
				bool flag16 = (nint)0 == 0;
				object obj47 = !flag16;
				if (obj47 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Physics.queriesHitBackfaces = true;
				if (Physics.Raycast((Vector3)(&obj48), eyes, out *(RaycastHit*)1, num2, 0, queryTriggerInteraction2))
				{
					object obj49 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v30+E4]");
					bool flag17 = (nint)0 == 0;
					object obj50 = !flag17;
					if (obj50 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Physics.queriesHitBackfaces = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
					object obj51 = obj52 + 0;
					bool flag18 = Physics.Raycast((Vector3)(&obj53), eyes, out *(RaycastHit*)1, num2, 0, queryTriggerInteraction2);
					bool flag19 = !flag18;
					obj31 = obj32;
					num7 = num2;
					object obj58;
					object obj59;
					int num3;
					if (!flag19)
					{
						float num8 = (float)obj52;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
						num7 = num8 + 0f;
						bool flag20 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj54) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num7);
						object obj55 = !flag20;
						float num9 = (float)obj54 - num7;
						bool flag21 = num9 == 0f;
						object obj56 = ~obj55;
						object obj57 = obj56 | flag21;
						obj31 = obj54;
						if (obj57 != null)
						{
							obj44++;
							obj58 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X26_v1-4]");
							obj59 = 0;
							queryTriggerInteraction = (QueryTriggerInteraction)0;
							num3 = 1;
							array = (Collider[])eyes;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X26_v1-8]");
							obj8 = 0;
							obj31 = obj54;
							goto IL_0bc1;
						}
					}
					obj42++;
					obj58 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X26_v1-4]");
					obj59 = 0;
					queryTriggerInteraction = (QueryTriggerInteraction)0;
					num3 = 1;
					array = (Collider[])eyes;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X26_v1-8]");
					obj8 = 0;
				}
				else
				{
					object obj60 = obj12 + 1;
					obj43 = obj12 & -4294967296L;
					obj12 = obj60 | obj43;
					object obj51 = 1109393408;
					object obj58 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X26_v1-4]");
					object obj59 = 0;
					queryTriggerInteraction = (QueryTriggerInteraction)0;
					int num3 = 1;
					array = (Collider[])eyes;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X26_v1-8]");
					obj8 = 0;
					obj31 = obj32;
					num7 = num2;
				}
				goto IL_0bc1;
				IL_0bc1:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X23_v5+18]");
				obj41 = 0;
				obj++;
				obj11 += 12;
				object obj61 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X23_v5+18]");
				bool flag22 = (nint)obj61 < 0;
				obj29 = obj30;
				if (flag22)
				{
					continue;
				}
				goto IL_0773;
			}
			goto IL_0960;
		}
		obj42 = 0;
		obj44 = 0;
		queryTriggerInteraction = (QueryTriggerInteraction)0;
		goto IL_0c19;
		IL_0960:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		goto IL_096e;
		IL_096e:
		OutOfMemoryException ex5 = new OutOfMemoryException();
		obj32 = obj31;
		num2 = num7;
		goto IL_098c;
		IL_0c8d:
		object obj62 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X0_v8+E4]");
		bool flag23 = (nint)0 == 0;
		object obj63 = !flag23;
		if (obj63 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag24 = obj40 == null;
		bool queriesHitBackfaces2 = !flag24;
		Physics.queriesHitBackfaces = queriesHitBackfaces2;
		bool flag25 = ex3 == null;
		object obj64 = !flag25;
		array = null;
		obj29 = obj29;
		obj31 = obj32;
		num7 = num2;
		if (obj64 != null)
		{
			goto IL_096e;
		}
		bool flag26 = obj39 == null;
		object obj65 = !flag26;
		array = null;
		NullReferenceException ex6 = ex3;
		if (obj65 != null)
		{
			goto IL_099a;
		}
		object obj66;
		Reading result;
		if ((nint)obj66 != 15)
		{
			bool flag27 = obj66 == null;
			object obj67 = !flag27;
			result = (Reading)ex3;
			if (obj67 != null)
			{
				goto IL_0c45;
			}
		}
		result = (Reading)(obj42 | obj44);
		goto IL_0c45;
		IL_099a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)array == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj39 = 1;
		}
		else
		{
			if ((nint)array != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D694");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				Reading result2 = default;
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj68 = default;
			ex3 = (NullReferenceException)obj68;
		}
		obj42 = 0;
		obj44 = 0;
		obj66 = 0;
		goto IL_0c8d;
		IL_0c19:
		obj39 = 0;
		obj28 = queriesHitBackfaces;
		ex3 = null;
		obj40 = (object)(&obj28);
		obj66 = 15;
		goto IL_0c8d;
		IL_0773:
		obj9 = 1109393408;
		obj32 = obj31;
		num2 = num7;
		goto IL_0c19;
		IL_0c45:
		return result;
		IL_098c:
		ex6 = new NullReferenceException();
		goto IL_099a;
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_018b: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CE0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj3 = this + 32;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 != null;
		bool flag3 = !flag2;
		object obj7 = 0;
		Transform transform = null;
		if (!flag3)
		{
			object obj8 = obj3;
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v5+20]");
			bool flag5 = (UnityEngine.Object)0 != null;
			bool flag6 = !flag5;
			obj7 = 0;
			transform = null;
			if (!flag6)
			{
				object obj11 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v7+20]");
				Transform transform2 = ((Component)0).transform;
				obj7 = 0;
				transform = transform2;
			}
		}
		object obj12 = this + 40;
		obj12 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private bool Watching()
	{
		//IL_0010: Expected Obj, but got I
		//IL_03b9: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_00f6: Expected I4, but got I8
		//IL_0110: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I4
		//IL_038f: Expected I4, but got Obj
		//IL_020a: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got I
		//IL_03ef: Expected Obj, but got I
		//IL_0262: Invalid comparison between VT and I4
		//IL_0286: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I4
		//IL_041c: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = gt == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = head == null;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				int current = GillaPlaces.Current;
				int num = (int)(current & 0x80000000L);
				bool flag7 = num == 0;
				object obj8 = !flag7;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
					object obj9 = 0;
					object obj10 = obj;
					object obj11 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v9+A0]");
					object obj12 = 0;
					UnityEngine.Object obj13 = (UnityEngine.Object)obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v15+E4]");
					bool flag8 = (nint)0 == 0;
					object obj14 = !flag8;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag9 = (UnityEngine.Object)obj12 == null;
					bool flag10 = !flag9;
					object obj15 = !flag10;
					if (obj15 == null)
					{
						if (obj12 == null)
						{
							goto IL_0381;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X20_v7 (UnityEngine.Object)+A9]");
						bool flag11 = (nint)0 == 0;
						object obj16 = !flag11;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
							object obj17 = 0;
							object obj18 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v17+A0]");
							object obj19 = 0;
							if (obj19 == null)
							{
								Player player = gt;
								if ((object)gt != null)
								{
									if (player.locomotionEnabledLayers == (LayerMask)(object)0)
									{
										goto IL_021d;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5768]");
									object obj20 = 0;
									object obj21 = obj20;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v23+E4]");
									bool flag12 = (nint)0 == 0;
									object obj22 = !flag12;
									if (obj22 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj21 = obj20;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v23+A0]");
									object obj23 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v23+24]");
									if ((nint)0 != 0)
									{
										return true;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
									object obj24 = 0;
									object obj25 = obj24;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v24+E4]");
									bool flag13 = (nint)0 == 0;
									object obj26 = !flag13;
									if (obj26 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									string roomTag = NetworkBootstrap.RoomTag;
									if (roomTag != null)
									{
										return roomTag._stringLength == 0;
									}
								}
								goto IL_0381;
							}
						}
					}
				}
			}
		}
		goto IL_021d;
		IL_021d:
		return false;
		IL_0381:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void Update()
	{
		//IL_006b: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I4
		//IL_00e3: Expected VT, but got I4
		//IL_0247: Expected Obj, but got I4
		//IL_02b7: Expected Obj, but got I
		//IL_015d: Invalid comparison between F4 and I4
		//IL_019f: Expected VT, but got I4
		float time = Time.time;
		if (time < nextLook)
		{
			return;
		}
		float time2 = Time.time;
		float num = time2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		float num2 = num + 0f;
		nextLook = num2;
		if (Watching())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5768]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num3 = Mask(gt);
			Vector3 position = head.position;
			Reading eyes = Read((Vector3)num3, 0);
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v19+A0]");
			object obj6 = 0;
			_ = 0;
			if (outSince < 0f)
			{
				float time3 = Time.time;
				outSince = time3;
			}
			float time4 = Time.time;
			float num4 = time4 - outSince;
			float num5 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
			float num6 = num5 + 0f;
			if ((double)num6 < 1.0)
			{
				return;
			}
			PutBack((Vector3)eyes, (Reading)0, num3);
		}
		outSince = -1f;
	}

	private unsafe void Keep(Vector3 eyes, int mask)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03bf: Expected Obj, but got I4
		//IL_03dd: Expected Obj, but got I
		//IL_03f5: Expected Obj, but got I
		//IL_0414: Expected VT, but got Ref
		//IL_0457: Expected Obj, but got I
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected Obj, but got Unknown
		//IL_0482: Expected Obj, but got I
		//IL_04d8: Expected Obj, but got I
		//IL_0773: Expected Obj, but got I
		//IL_0790: Expected Obj, but got I
		//IL_07a0: Expected Obj, but got I
		//IL_07d2: Expected Obj, but got I
		//IL_07e2: Expected Obj, but got I
		//IL_0815: Expected Obj, but got I
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected Obj, but got Unknown
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected Obj, but got Unknown
		//IL_05bb: Expected Obj, but got I4
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected Obj, but got Unknown
		//IL_0170: Expected Obj, but got Ref
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_05f8: Expected Obj, but got I4
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected Obj, but got Unknown
		//IL_0163: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got Ref
		//IL_0635: Expected Obj, but got I4
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected Obj, but got Unknown
		//IL_017e: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got Ref
		//IL_0199: Expected Obj, but got I4
		//IL_06eb: Expected Obj, but got I
		//IL_06fb: Expected Obj, but got I
		//IL_070b: Expected Obj, but got I
		//IL_071b: Expected Obj, but got I
		//IL_083b: Expected Obj, but got I
		//IL_0865: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got I4
		//IL_0220: Expected Obj, but got I
		//IL_0238: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_02c9: Expected Obj, but got I4
		//IL_02d9: Expected Obj, but got I4
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected I4, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_06be: Expected Obj, but got Ref
		//IL_06c6: Expected Obj, but got Ref
		//IL_06ce: Expected Obj, but got Ref
		//IL_032c: Unsupported input type for neg.
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj = 0;
		float time = Time.time;
		object obj2 = obj;
		float num = time + 0.25f;
		nextKeep = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool queriesHitBackfaces = Physics.queriesHitBackfaces;
		Physics.queriesHitBackfaces = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v5+A0]");
		object obj6 = 0;
		object obj7 = default;
		float maxDistance = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		bool flag2 = Physics.Raycast((Vector3)(&obj7), eyes, out *(RaycastHit*)1, maxDistance, 0, queryTriggerInteraction);
		Physics.queriesHitBackfaces = queriesHitBackfaces;
		if (!flag2)
		{
			return;
		}
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v10+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v11+18]");
		object obj11 = default;
		object obj10 = obj11 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v11+1C]");
		object obj12 = (nint)0 * (nint)0;
		object obj13 = obj10 + obj12;
		object obj15 = default;
		object obj14 = obj15 + obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		if ((nint)obj14 < 0)
		{
			return;
		}
		if ((object)head != null)
		{
			Vector3 forward = head.forward;
			object obj16 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v17+A0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v18+18]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v18+18]");
			object obj18 = num2 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v18+1C]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v18+1C]");
			object obj19 = num3 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
			object obj20 = 0;
			object obj21 = obj20;
			object obj22 = obj18 + obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v18+20]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v18+20]");
			object obj23 = num4 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v22+A0]");
			object obj24 = 0;
			object obj25 = obj23 + obj22;
			bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
			object obj27 = default;
			object obj26 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			object obj28 = 0;
			object obj29 = obj14;
			object obj37 = default;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v18+18]");
				object obj30 = obj14 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v18+1C]");
				object obj31 = num5 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v18+20]");
				object obj32 = obj27 * 0;
				object obj33 = obj30 + obj31;
				object obj34 = obj32 + obj33;
				object obj35 = obj34 / obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v18+18]");
				object obj36 = 0 * obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v18+1C]");
				obj37 = 0 * obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v18+20]");
				object obj38 = 0 * obj35;
				obj29 = obj14 - obj36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				obj28 = 0 - obj37;
				obj26 = obj27 - obj38;
			}
			GillaOutfits.Spot[] array = kept;
			float time2 = Time.time;
			object obj39 = obj29 * obj29;
			object obj40 = obj28 * obj28;
			object obj41 = obj39 + obj40;
			object obj42 = obj26 * obj26;
			object obj43 = obj41 + obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			object obj44 = obj43 - 0;
			bool flag4 = (nint)obj44 < 0;
			bool flag5 = obj44 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			object obj45 = obj43 ^ 0;
			object obj46 = obj43 ^ obj44;
			object obj47 = obj45 & obj46;
			bool flag6 = (nint)obj47 < 0;
			bool flag7 = flag4 == flag6;
			object obj48 = !flag5;
			object obj49 = flag7 & obj48;
			object obj50 = ~obj49;
			object obj52 = default;
			object obj51;
			if (obj50 == null)
			{
				obj51 = 28;
			}
			else
			{
				obj51 = (object)(&obj52);
			}
			bool flag8 = flag4 == flag6;
			object obj53 = !flag5;
			object obj54 = flag8 & obj53;
			object obj55 = ~obj54;
			object obj57 = default;
			object obj56;
			if (obj55 == null)
			{
				obj56 = 24;
			}
			else
			{
				obj56 = (object)(&obj57);
			}
			bool flag9 = flag4 == flag6;
			object obj58 = !flag5;
			object obj59 = flag9 & obj58;
			object obj60 = ~obj59;
			object obj62 = default;
			object obj61;
			if (obj60 == null)
			{
				obj61 = 20;
			}
			else
			{
				obj61 = (object)(&obj62);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			object obj63;
			object obj64 = default;
			object obj69;
			object obj70;
			object obj71;
			if ((nint)obj43 > 0)
			{
				obj63 = obj64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj65 = 0;
				object obj66 = obj65;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X0_v30+E4]");
				bool flag10 = (nint)0 == 0;
				object obj67 = !flag10;
				if (obj67 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj63 = obj64;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				object obj68 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				if ((nint)obj68 > 0)
				{
					obj69 = obj29 / obj37;
					obj70 = obj28 / obj37;
					obj71 = obj26 / obj37;
				}
				else
				{
					object obj72 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v49+A0]");
					object obj73 = 0;
					obj69 = obj73;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v50+4]");
					obj70 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v50+8]");
					obj71 = 0;
				}
				obj61 = (object)(&obj62);
				obj56 = (object)(&obj57);
				obj51 = (object)(&obj52);
			}
			else
			{
				obj63 = obj64;
				object obj74 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v37+A0]");
				object obj75 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v38+48]");
				obj69 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v38+4C]");
				obj70 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v38+50]");
				obj71 = 0;
			}
			obj61 = obj69;
			obj56 = obj70;
			obj51 = obj71;
			if (kept != null)
			{
				bool flag11 = keptNext < array.Length;
				object obj76 = !flag11;
				if (obj76 == null)
				{
					object obj78 = default;
					object obj77 = obj78 - obj63;
					object obj79 = kept + keptNext;
					object obj80 = keptNext + 1;
					object obj81 = keptCount + 1;
					object obj82 = 0 - obj80;
					int num6 = obj80 & 0x1F;
					object obj83 = obj82 & 0x1F;
					if (0 >= (nint)obj80)
					{
						num6 = 0 - obj83;
					}
					int num7 = (((nint)obj81 < 32) ? (keptCount + 1) : 32);
					keptNext = num6;
					keptCount = num7;
					return;
				}
				goto IL_0367;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0367;
		IL_0367:
		throw new IndexOutOfRangeException();
	}

	private unsafe void PutBack(Vector3 eyes, Reading why, int mask)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0c6c: Expected Obj, but got I4
		//IL_0c82: Expected VT, but got Obj
		//IL_0ca4: Expected Obj, but got I4
		//IL_0df0: Expected Obj, but got I
		//IL_0e06: Expected Obj, but got I
		//IL_0cd4: Expected Obj, but got I4
		//IL_003b: Expected VT, but got Obj
		//IL_0e1b: Expected Obj, but got I
		//IL_0e30: Expected Obj, but got I
		//IL_0e40: Expected Obj, but got I
		//IL_0367: Expected Obj, but got I
		//IL_0377: Expected Obj, but got I
		//IL_0052: Expected VT, but got Obj
		//IL_03a0: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I4
		//IL_03d8: Expected Obj, but got I
		//IL_0402: Expected Obj, but got I4
		//IL_044b: Expected Obj, but got I
		//IL_0463: Expected VT, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00e8: Unsupported input type for neg.
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_0cfd: Expected Obj, but got I4
		//IL_012a: Invalid comparison between I and F4
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_0d2b: Expected Obj, but got I
		//IL_0d4d: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I
		//IL_01fb: Expected I4, but got VT
		//IL_01fb: Expected VT, but got I4
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_022b: Expected Obj, but got I4
		//IL_023b: Expected F4, but got I
		//IL_026f: Expected Obj, but got VT
		//IL_0278: Invalid comparison between VT and I4
		//IL_0d74: Expected Obj, but got I4
		//IL_0d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d81: Expected Obj, but got Unknown
		//IL_0d91: Expected F4, but got I
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Obj, but got Unknown
		//IL_04b7: Expected Obj, but got I
		//IL_04e7: Expected VT, but got Ref
		//IL_04f7: Expected F4, but got I
		//IL_0534: Expected VT, but got Ref
		//IL_05e2: Expected F4, but got I
		//IL_054a: Expected I, but got Obj
		//IL_055a: Expected VT, but got I
		//IL_0583: Expected VT, but got I
		//IL_0593: Expected F4, but got I
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected Obj, but got Unknown
		//IL_064e: Expected VT, but got Ref
		//IL_06e7: Expected Obj, but got I8
		//IL_070e: Expected F4, but got I
		//IL_0664: Expected I, but got Obj
		//IL_0674: Expected VT, but got I
		//IL_069d: Expected VT, but got I
		//IL_06ad: Expected F4, but got I
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected Obj, but got Unknown
		//IL_0764: Expected Obj, but got I
		//IL_078a: Expected VT, but got Ref
		//IL_082b: Expected Obj, but got I4
		//IL_083b: Expected Obj, but got I4
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Expected Obj, but got Unknown
		//IL_0878: Expected F4, but got I
		//IL_07a0: Expected I, but got Obj
		//IL_07b0: Expected VT, but got I
		//IL_07d9: Expected VT, but got I
		//IL_07e9: Expected F4, but got I
		//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Expected Obj, but got Unknown
		//IL_08fd: Expected VT, but got Ref
		//IL_098e: Expected Obj, but got I8
		//IL_09b5: Expected F4, but got I
		//IL_0913: Expected I, but got Obj
		//IL_0923: Expected VT, but got I
		//IL_094c: Expected VT, but got I
		//IL_095c: Expected F4, but got I
		//IL_09dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e1: Expected Obj, but got Unknown
		//IL_0a19: Expected VT, but got Ref
		//IL_0ac2: Expected Obj, but got I4
		//IL_0ad2: Expected Obj, but got I4
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af7: Expected Obj, but got Unknown
		//IL_0b0f: Expected F4, but got I
		//IL_0b2f: Expected F4, but got I
		//IL_0a2f: Expected I, but got Obj
		//IL_0a3f: Expected VT, but got I
		//IL_0a68: Expected VT, but got I
		//IL_0a78: Expected F4, but got I
		//IL_0a98: Expected F4, but got I
		//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4b: Expected Obj, but got Unknown
		//IL_0b6d: Expected Obj, but got I
		//IL_0b93: Expected Obj, but got I
		//IL_0bbd: Expected Obj, but got I4
		//IL_0bf3: Expected VT, but got I4
		//IL_0bf3: Expected VT, but got I4
		//IL_0c0a: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5768]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Reading reading = (Reading)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v33 (GillaOutOfMap+Reading)+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			reading = (Reading)obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v33 (GillaOutOfMap+Reading)+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v7+10]");
		object obj6 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v33 (GillaOutOfMap+Reading)+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			reading = (Reading)obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v33 (GillaOutOfMap+Reading)+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5788]");
		object obj10 = 0;
		bool flag4 = keptCount < 1;
		float num2 = default;
		float num = num2;
		if (flag4)
		{
			goto IL_0357;
		}
		float num4 = default;
		float num3 = num4;
		float num5 = num2;
		float num7 = default;
		float num6 = num7;
		object obj11 = 1;
		object obj12 = 31;
		float num14;
		int num15 = default;
		Vector3 vector = default;
		float num16;
		while (true)
		{
			GillaOutfits.Spot[] array = kept;
			if (kept == null)
			{
				break;
			}
			object obj13 = obj12 + keptNext;
			object obj14 = 0 - obj13;
			object obj15 = obj13 & 0x1F;
			object obj16 = obj14 & 0x1F;
			if (0 >= (nint)obj13)
			{
				obj15 = 0 - obj16;
			}
			bool flag5 = (nint)obj15 < array.Length;
			object obj17 = !flag5;
			if (obj17 == null)
			{
				object obj18 = (object)kept + obj15;
				float num8 = outSince;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA8C]");
				num6 = num8 + 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+20]");
				if (!(0f > num6))
				{
					object obj19 = obj9;
					object obj20 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X8_v32+A0]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X0_v35+E4]");
					bool flag6 = (nint)0 == 0;
					object obj22 = !flag6;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+30]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v33+18]");
					object obj23 = num9 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+30]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v33+1C]");
					object obj24 = num10 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+30]");
					nint num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v33+20]");
					object obj25 = num11 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+24]");
					float num12 = 0f + (float)obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+28]");
					float num13 = 0f + (float)obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+2C]");
					num14 = 0f + (float)obj25;
					reading = Read((Vector3)num15, (int)vector);
					object obj26 = vector & 0xFF00000000L;
					bool flag7 = obj26 == null;
					object obj27 = !flag7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+24]");
					num3 = 0f;
					num5 = num14;
					num16 = num13;
					num6 = num12;
					if (obj27 == null)
					{
						object obj28 = reading >> 32;
						bool flag8;
						bool flag9;
						bool flag10;
						if (reading >= (object)3)
						{
							object obj29 = reading - obj28;
							flag8 = (nint)obj29 < 0;
							flag9 = obj29 == null;
							object obj30 = reading ^ obj28;
							object obj31 = reading ^ obj29;
							object obj32 = obj30 & obj31;
							flag10 = (nint)obj32 < 0;
						}
						else
						{
							flag10 = false;
							flag9 = true;
							flag8 = false;
						}
						bool flag11 = flag8 == flag10;
						object obj33 = !flag11;
						object obj34 = obj33 | flag9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+24]");
						num3 = 0f;
						num5 = num14;
						num16 = num13;
						num6 = num12;
						if (obj34 != null)
						{
							goto IL_04a7;
						}
					}
				}
				obj11++;
				obj12--;
				bool flag12 = (nint)obj11 <= keptCount;
				num = num5;
				if (flag12)
				{
					continue;
				}
				goto IL_0357;
			}
			goto IL_0c1e;
		}
		goto IL_0c10;
		IL_04a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object[] array2 = default;
		bool flag13 = array2 == null;
		object obj36 = default;
		vector = (Vector3)(&obj36);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+24]");
		num3 = 0f;
		num5 = num14;
		num16 = num7;
		num6 = num2;
		if (flag13)
		{
			goto IL_0c10;
		}
		object obj37 = default;
		bool flag14 = obj37 == null;
		Vector3 vector2 = (Vector3)(&obj36);
		IndexOutOfRangeException ex = default;
		if (!flag14)
		{
			nint num17 = (nint)array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v57 (Il2CppClass<System.Object[]>)+40]");
			vector2 = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag15 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v57 (Il2CppClass<System.Object[]>)+40]");
			vector = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+24]");
			num3 = 0f;
			num5 = num14;
			num16 = num7;
			num6 = num2;
			if (flag15)
			{
				goto IL_0c2c;
			}
		}
		bool flag16 = array2.Length == 0;
		vector = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+24]");
		num3 = 0f;
		num5 = num14;
		num16 = num7;
		num6 = num2;
		if (!flag16)
		{
			object obj38 = array2 + 32;
			obj38 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object obj39 = default;
			bool flag17 = obj39 == null;
			object obj40 = default;
			Vector3 vector3 = (Vector3)(&obj40);
			if (!flag17)
			{
				nint num18 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X8_v56 (Il2CppClass<System.Object[]>)+40]");
				vector3 = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag18 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X8_v56 (Il2CppClass<System.Object[]>)+40]");
				vector = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+24]");
				num3 = 0f;
				num5 = num14;
				num16 = num7;
				num6 = num2;
				if (flag18)
				{
					goto IL_0c2c;
				}
			}
			object obj41 = array2.Length & 0xFFFFFFFEL;
			bool flag19 = obj41 == null;
			vector = vector3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+24]");
			num3 = 0f;
			num5 = num14;
			num16 = num7;
			num6 = num2;
			if (!flag19)
			{
				object obj42 = array2 + 40;
				obj42 = obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object obj44 = default;
				bool flag20 = obj44 == null;
				object obj45 = default;
				Vector3 vector4 = (Vector3)(&obj45);
				if (!flag20)
				{
					nint num19 = (nint)array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v55 (Il2CppClass<System.Object[]>)+40]");
					vector4 = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag21 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v55 (Il2CppClass<System.Object[]>)+40]");
					vector = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+24]");
					num3 = 0f;
					num5 = num14;
					num16 = num7;
					num6 = num2;
					if (flag21)
					{
						goto IL_0c2c;
					}
				}
				bool flag22 = array2.Length < 2;
				object obj46 = !flag22;
				object obj47 = array2.Length - 2;
				bool flag23 = obj47 == null;
				object obj48 = ~obj46;
				object obj49 = obj48 | flag23;
				vector = vector4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+24]");
				num3 = 0f;
				num5 = num14;
				num16 = num7;
				num6 = num2;
				if (obj49 == null)
				{
					object obj50 = array2 + 48;
					obj50 = obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					float num20 = outSince;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+20]");
					num6 = num20 - 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj51 = default;
					bool flag24 = obj51 == null;
					object obj52 = default;
					Vector3 vector5 = (Vector3)(&obj52);
					if (!flag24)
					{
						nint num21 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v54 (Il2CppClass<System.Object[]>)+40]");
						vector5 = (Vector3)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag25 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v54 (Il2CppClass<System.Object[]>)+40]");
						vector = (Vector3)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+24]");
						num3 = 0f;
						num5 = num14;
						num16 = num7;
						if (flag25)
						{
							goto IL_0c2c;
						}
					}
					object obj53 = array2.Length & 0xFFFFFFFCL;
					bool flag26 = obj53 == null;
					vector = vector5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+24]");
					num3 = 0f;
					num5 = num14;
					num16 = num7;
					if (!flag26)
					{
						object obj54 = array2 + 56;
						obj54 = obj51;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj55 = default;
						bool flag27 = obj55 == null;
						object obj56 = default;
						Vector3 vector6 = (Vector3)(&obj56);
						if (!flag27)
						{
							nint num22 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v53 (Il2CppClass<System.Object[]>)+40]");
							vector6 = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag28 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v53 (Il2CppClass<System.Object[]>)+40]");
							vector = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+24]");
							num3 = 0f;
							num5 = num14;
							num16 = num7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+24]");
							num6 = 0f;
							if (flag28)
							{
								goto IL_0c2c;
							}
						}
						bool flag29 = array2.Length < 4;
						object obj57 = !flag29;
						object obj58 = array2.Length - 4;
						bool flag30 = obj58 == null;
						object obj59 = ~obj57;
						object obj60 = obj59 | flag30;
						vector = vector6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+24]");
						num3 = 0f;
						num5 = num14;
						num16 = num7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+24]");
						num6 = 0f;
						if (obj60 == null)
						{
							object obj61 = array2 + 64;
							obj61 = obj55;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5790]");
							object format = 0;
							string message = string.Format((string)format, array2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
							object obj62 = 0;
							object obj63 = obj62;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X8_v52+E4]");
							bool flag31 = (nint)0 == 0;
							object obj64 = !flag31;
							if (obj64 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Debug.LogWarning(message);
							Put((Vector3)0, (Vector3)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v29+20]");
							DropAfter(0f);
							goto IL_04a0;
						}
					}
				}
			}
		}
		goto IL_0c1e;
		IL_0c10:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0c1e;
		IL_0357:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5798]");
		object format2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		object arg2 = default;
		object arg3 = default;
		string message2 = string.Format((string)format2, arg, arg2, arg3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj67 = 0;
		object obj68 = obj67;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v23+E4]");
		bool flag32 = (nint)0 == 0;
		object obj69 = !flag32;
		if (obj69 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message2);
		object obj70 = obj65;
		keptCount = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v24+A0]");
		object obj71 = 0;
		bool flag33 = obj71 == null;
		vector = (Vector3)0;
		num3 = num3;
		num5 = num;
		num16 = num7;
		num6 = num2;
		if (!flag33)
		{
			((KillCam)obj71).SendHome();
			goto IL_04a0;
		}
		goto IL_0c10;
		IL_04a0:
		Show();
		return;
		IL_0c1e:
		ex = new IndexOutOfRangeException();
		goto IL_0c2c;
		IL_0c2c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
	}

	private void DropAfter(float after)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0058: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected I4, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_0066: Unsupported input type for neg.
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected I4, but got Unknown
		//IL_0138: Expected Obj, but got I4
		//IL_0082: Expected I4, but got I8
		//IL_00a0: Invalid comparison between I and F4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected I4, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		if (keptCount < 1)
		{
			return;
		}
		GillaOutfits.Spot[] array = kept;
		int num = keptNext;
		object obj = kept + 32;
		object obj2 = keptCount + 1;
		while (true)
		{
			object obj3 = num + 31;
			object obj4 = 0 - obj3;
			num = obj3 & 0x1F;
			object obj5 = obj4 & 0x1F;
			if (0 >= (nint)obj3)
			{
				num = 0 - obj5;
			}
			bool flag = num < array.Length;
			object obj6 = !flag;
			if (obj6 != null)
			{
				break;
			}
			int num2 = (int)(num & 0xFFFFFFFFL);
			int num3 = num2 << 5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X9_v4+v26 @ X12_v6 (System.Int32)]");
			if (0f > after)
			{
				int num4 = obj2 - 2;
				obj2--;
				keptNext = num;
				keptCount = num4;
				if ((nint)obj2 < 2)
				{
					return;
				}
				continue;
			}
			return;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void Show()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I
		//IL_0033: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I4
		//IL_00b3: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj3 = 0;
		((KillCam)obj3).FadeIn();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A8]");
		object title = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57B0]");
		object line = 0;
		Vector3 position = head.position;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int hand = GillaToast.NearerHand((Vector3)0);
		GillaToast.Show(hand, (string)title, (string)line, error: true);
	}

	private unsafe void Put(Vector3 eyes, Vector3 facing)
	{
		//IL_03e6: Expected VT, but got I4
		//IL_03f0: Expected VT, but got I4
		//IL_0405: Expected Obj, but got I
		//IL_041d: Expected Obj, but got I
		//IL_04d0: Expected Obj, but got I
		//IL_04ed: Expected Obj, but got I
		//IL_04fd: Expected Obj, but got I
		//IL_052f: Expected Obj, but got I
		//IL_053f: Expected Obj, but got I
		//IL_047d: Expected F4, but got I
		//IL_048d: Invalid comparison between F4 and I
		//IL_0157: Invalid comparison between F4 and I
		//IL_01d0: Expected Obj, but got I
		//IL_0247: Expected VT, but got I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_027b: Expected VT, but got Ref
		//IL_037f: Expected Obj, but got I
		//IL_03a9: Expected Obj, but got I4
		//IL_02b8: Expected VT, but got I4
		//IL_02e4: Expected Obj, but got I4
		//IL_02ed: Expected VT, but got I4
		//IL_030e: Expected VT, but got I4
		//IL_032b: Expected Obj, but got I
		//IL_033b: Expected F4, but got I
		//IL_034b: Expected F4, but got I
		//IL_0353: Expected F4, but got Obj
		//IL_0361: Expected VT, but got I4
		//IL_036a: Expected VT, but got I4
		GillaPlaces.Prepare((Vector3)0);
		GillaBackroomsSwitch.Prepare((Vector3)0);
		Vector3 forward = head.forward;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v6+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v7+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v7+18]");
		object obj4 = num * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v7+1C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v7+1C]");
		object obj5 = num2 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj6 = 0;
		object obj7 = obj6;
		object obj8 = obj4 + obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v7+20]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v7+20]");
		object obj9 = num3 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v11+A0]");
		object obj10 = 0;
		object obj11 = obj9 + obj8;
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
		float num5 = default;
		float num4 = num5;
		float num7 = default;
		float num6 = num7;
		float num9 = default;
		float num8 = num9;
		float num10 = num5;
		if (!flag)
		{
			float num11 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v7+18]");
			float num12 = num11 * 0f;
			float num13 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v7+1C]");
			float num14 = num13 * 0f;
			float num15 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v7+20]");
			float num16 = num15 * 0f;
			float num17 = num12 + num14;
			float num18 = num16 + num17;
			float num19 = num18 / (float)obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v7+18]");
			float num20 = 0f * num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v7+1C]");
			num10 = 0f * num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v7+20]");
			float num21 = 0f * num19;
			num8 = num9 - num20;
			num6 = num7 - num10;
			num4 = num5 - num21;
		}
		float num22 = num8 * num8;
		float num23 = num6 * num6;
		float num24 = num22 + num23;
		float num25 = num4 * num4;
		float num26 = num24 + num25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		float num27 = 0f;
		float num28 = num26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		if (num28 > 0f)
		{
			object obj13 = default;
			object obj12 = obj13 * obj13;
			object obj15 = default;
			object obj14 = obj15 * obj15;
			object obj16 = obj12 + obj14;
			object obj17 = default;
			num10 = (float)obj17 * (float)obj17;
			num26 = num10 + (float)obj16;
			float num29 = num26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			if (num29 > 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72DCC");
				gt.Turn(num8);
				num10 = num4;
				num26 = num6;
				num27 = num8;
			}
		}
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F70]");
		object obj18 = 0;
		Vector3 position2 = head.position;
		float num30 = num9 - num27;
		float num31 = num7 - num26;
		float num32 = num5 - num10;
		float num33 = num27 + num30;
		float num34 = num26 + num31;
		float num35 = num10 + num32;
		transform.position = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
		object obj20 = default;
		object obj19 = obj20 & 1;
		bool flag2 = obj19 == null;
		Rigidbody rigidbody = default;
		Vector3 vector = (Vector3)(&rigidbody);
		if (!flag2)
		{
			Transform transform2 = base.transform;
			Vector3 position3 = transform2.position;
			rigidbody.position = (Vector3)0;
			bool isKinematic = rigidbody.isKinematic;
			bool flag3 = !isKinematic;
			object obj21 = !flag3;
			vector = (Vector3)0;
			if (obj21 == null)
			{
				rigidbody.linearVelocity = (Vector3)0;
				object obj22 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v25+A0]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v26+4]");
				num34 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v26+8]");
				num35 = 0f;
				num33 = (float)obj23;
				rigidbody.angularVelocity = (Vector3)0;
				vector = (Vector3)0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj24 = 0;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v20+E4]");
		bool flag4 = (nint)0 == 0;
		object obj26 = !flag4;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Physics.SyncTransforms();
		gt.InitializeValues();
	}

	public GillaOutOfMap()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57B8]");
		object obj = 0;
		outSince = -1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 64;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaOutOfMap()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5768]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4470]");
		object obj2 = 0;
		Vector3[] array = MakeWays();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = array;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6+A0]");
		object obj7 = (nint)0 + (nint)8;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
