using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

public struct NetworkObjectAcquireContext
{
	public readonly NetworkObjectTypeId TypeId;

	public readonly NetworkObjectMeta Meta;

	public readonly bool IsSynchronous;

	public readonly bool DontDestroyOnLoad;

	public readonly NetworkObject AttachableInstance;

	public bool HasHeader
	{
		get
		{
			bool flag = Meta == null;
			return !flag;
		}
	}

	public unsafe ref NetworkObjectHeader Header
	{
		get
		{
			NetworkObjectMeta meta = Meta;
			if (Meta == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return ref *(NetworkObjectHeader*)ex;
			}
			return ref *(NetworkObjectHeader*)meta._ptr;
		}
	}

	public unsafe ReadOnlySpan<int> Data
	{
		get
		{
			//IL_00f8: Expected VT, but got Obj
			//IL_0189: Expected I4, but got I8
			//IL_01a3: Expected Obj, but got I4
			//IL_00a8: Expected Obj, but got I
			//IL_013c: Expected Obj, but got I
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected Obj, but got Unknown
			//IL_0164: Expected Obj, but got I4
			//IL_0029: Expected Obj, but got I4
			//IL_003c: Expected Obj, but got I4
			//IL_005b: Expected Obj, but got I
			//IL_006e: Expected Obj, but got I4
			//IL_00d8: Expected VT, but got I
			NetworkObjectMeta meta = Meta;
			if (Meta == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (ReadOnlySpan<int>)ex;
			}
			int num = (int)(meta.WordCount & -9223372036854775808L);
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				bool flag2 = meta.WordCount < 19;
				object obj2 = !flag2;
				object obj3 = meta.WordCount - 19;
				bool flag3 = obj3 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E50]");
				object obj4 = 0;
				object obj5 = obj4;
				object obj6 = !flag3;
				object obj7 = obj2 & obj6;
				if (obj7 == null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
			}
			else
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E50]");
				object obj8 = 0;
				object obj5 = obj8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X21_v1+20]");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag4 = obj10 == null;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Span<int> span = (Span<int>)(meta._ptr + 20);
			return span;
		}
	}

	public NetworkPrefabId? PrefabId
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00f5: Expected Obj, but got I4
			//IL_00c6: Expected VT, but got I4
			//IL_0076: Expected Obj, but got I4
			//IL_00b8: Expected VT, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (((NetworkObjectTypeId)this).IsPrefab)
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				NetworkPrefabId asPrefabId = ((NetworkObjectTypeId)this).AsPrefabId;
				NetworkPrefabId? networkPrefabId = asPrefabId;
				return (NetworkPrefabId?)(object)0;
			}
			return (NetworkPrefabId?)(object)0;
		}
	}

	public unsafe NetworkObjectAcquireContext(NetworkObjectTypeId typeId, NetworkObjectMeta meta = null, bool isSynchronous = default(bool), bool dontDestroyOnLoad = default(bool), NetworkObject attachableInstance = null)
	{
		//IL_0015: Expected Obj, but got Ref
		//IL_0032: Expected Obj, but got Ref
		TypeId = typeId;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		obj = meta;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 24));
		obj2 = attachableInstance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
