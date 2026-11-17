using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Fusion;

public struct NetworkPrefabAcquireContext
{
	public readonly NetworkPrefabId PrefabId;

	public readonly NetworkObjectMeta Meta;

	public readonly bool IsSynchronous;

	public readonly bool DontDestroyOnLoad;

	public bool HasHeader
	{
		get
		{
			bool flag = Meta == null;
			return !flag;
		}
	}

	public unsafe Span<int> Data
	{
		get
		{
			//IL_00c0: Expected VT, but got I4
			//IL_017b: Expected I4, but got I8
			//IL_0195: Expected Obj, but got I4
			//IL_00da: Expected Obj, but got I
			//IL_0129: Expected Obj, but got I
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected Obj, but got Unknown
			//IL_0151: Expected Obj, but got I4
			//IL_004d: Expected Obj, but got I4
			//IL_0060: Expected Obj, but got I4
			//IL_007f: Expected Obj, but got I
			//IL_0092: Expected Obj, but got I4
			//IL_0109: Expected VT, but got I
			NetworkObjectMeta meta = Meta;
			if (Meta == null)
			{
				return (Span<int>)0;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X21_v3+20]");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag4 = obj10 == null;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			return (Span<int>)(meta._ptr + 20);
		}
	}

	public unsafe NetworkPrefabAcquireContext([In] ref NetworkObjectAcquireContext context)
	{
		//IL_0043: Expected Obj, but got Ref
		//IL_0053: Expected Obj, but got I
		NetworkPrefabId? prefabId = context.PrefabId;
		NetworkPrefabId? networkPrefabId = default;
		NetworkPrefabId value = networkPrefabId.Value;
		PrefabId = value;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X1 (Fusion.NetworkObjectAcquireContext&)+8]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X1 (Fusion.NetworkObjectAcquireContext&)+10]");
		_ = 0;
	}
}
