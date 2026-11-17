using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

public struct NetworkObjectReleaseContext
{
	public readonly NetworkObject Object;

	public readonly NetworkObjectTypeId TypeId;

	public readonly bool IsBeingDestroyed;

	public unsafe bool IsNestedObject
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_006b: Expected Obj, but got I4
			//IL_002f: Expected VT, but got Ref
			//IL_0038: Expected Ref, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			NetworkObjectTypeId networkObjectTypeId = (NetworkObjectTypeId)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			return ((NetworkObjectTypeId*)networkObjectTypeId)->IsPrefabNestedObject;
		}
	}

	public NetworkObjectReleaseContext(NetworkObject obj, NetworkObjectTypeId typeId, bool isBeingDestroyed)
	{
		Object = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		IsBeingDestroyed = isBeingDestroyed;
		TypeId = typeId;
	}

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D87B8]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		object arg2 = default;
		return string.Format((string)format, Object, arg, arg2);
	}
}
