using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

internal class NetworkObjectInactivityGuard : Behaviour
{
	[NonSerialized]
	public NetworkObject Object;

	private void OnEnable()
	{
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I
		object obj = this + 32;
		object obj2 = obj;
		if (obj == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+30]");
		UnityEngine.Object obj5 = (UnityEngine.Object)0;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+30]");
		bool flag2 = (UnityEngine.Object)0;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v5+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v6+38]");
		object obj10 = 0;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v6+38]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v7+10]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8538]");
				object obj12 = 0;
				object obj13 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v139 @ X9_v6+188] (should have been resolved before IL gen)");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X20_v3 (UnityEngine.Object)+148]");
			((Stack<System.__Canon>)0).Push((System.__Canon)(object)this);
			Transform transform = base.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+30]");
			Transform parent = ((Component)0).transform;
			transform.SetParent(parent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v6+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v7+10]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8540]");
			object obj15 = 0;
			object obj16 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ X9_v4+188] (should have been resolved before IL gen)");
		}
		GameObject obj17 = gameObject;
		object obj18 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj19 = !flag3;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.Destroy(obj17);
	}

	private void OnDestroy()
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		NetworkObject networkObject = Object;
		if ((object)Object == null)
		{
			return;
		}
		object obj = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)1;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v7+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v8+38]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v8+38]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v9+10]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8548]");
				object obj8 = 0;
				object obj9 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ X9_v3+188] (should have been resolved before IL gen)");
				networkObject = Object;
			}
			networkObject.OnDestroyNeverActive();
		}
	}
}
