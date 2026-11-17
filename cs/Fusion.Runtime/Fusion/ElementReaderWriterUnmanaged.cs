using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab.GroupsModels;

namespace Fusion;

[StructLayout((LayoutKind)0, Size = 1)]
public struct ElementReaderWriterUnmanaged<T, TWordCount> : Action<ListGroupInvitationsResponse> where T : struct where TWordCount : struct, IMetaConstant
{
	private static IElementReaderWriter<T> Instance;

	[MethodImpl((MethodImplOptions)256)]
	public static IElementReaderWriter<T> GetInstance()
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00eb: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_015c: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I
		//IL_0214: Expected Obj, but got I4
		//IL_0232: Expected Obj, but got I
		//IL_0242: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X0_v2 (Il2CppClass<Fusion.ElementReaderWriterUnmanaged`2>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X8_v3+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v4+A0]");
		object obj6 = 0;
		IElementReaderWriter<T> result = (IElementReaderWriter<T>)obj6;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			object obj8 = (nint)0 + (nint)309;
			object obj9 = obj8 & 1;
			bool flag3 = obj9 == null;
			object obj10 = !flag3;
			nint num2 = 0;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6 (Il2CppClass<Fusion.ElementReaderWriterUnmanaged`2>)+A8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object obj12 = (nint)0 + (nint)309;
			object obj13 = obj12 & 1;
			bool flag4 = obj13 == null;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				nint num3 = 0;
			}
			else
			{
				nint num3 = 0;
				nint num4 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v9 (Il2CppClass<Fusion.ElementReaderWriterUnmanaged`2>)+A8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X9_v4+10]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X9_v5+A0]");
			object obj17 = 0;
			IElementReaderWriter<T> elementReaderWriter = default;
			obj17 = elementReaderWriter;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v12 (Il2CppClass<Fusion.ElementReaderWriterUnmanaged`2>)+135]");
			object obj18 = (nint)0 & (nint)1;
			bool flag5 = obj18 == null;
			object obj19 = !flag5;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr = default;
				nint num3 = intPtr;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v12 (Il2CppClass<Fusion.ElementReaderWriterUnmanaged`2>)+A8]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v13+10]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			result = elementReaderWriter;
		}
		return result;
	}

	public unsafe T Read(byte* data, int index)
	{
		//IL_001b: Expected VT, but got I
		int num = index << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (System.Byte*)+v0 @ X8_v1 (System.Int32)]");
		return (T)0;
	}

	public unsafe void Write(byte* data, int index, T element)
	{
		int num = index << 2;
	}

	public int GetElementWordCount()
	{
		return 1;
	}

	public unsafe ref T ReadRef(byte* data, int index)
	{
		int num = index << 2;
		return ref *(T*)(data + num);
	}

	public int GetElementHashCode(T element)
	{
		byte b = default;
		return b.GetHashCode();
	}

	public T Read(ReadOnlySpan<byte> data)
	{
		//IL_0014: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36A197C");
		object obj = default;
		return (T)obj;
	}

	public void Write(Span<byte> data, T element)
	{
		//IL_0017: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36A1980");
		IntPtr intPtr = default;
		object obj = (nint)intPtr;
	}

	public ref T ReadRef(Span<byte> data)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36A1980");
		ref T result = default;
		return ref result;
	}
}
