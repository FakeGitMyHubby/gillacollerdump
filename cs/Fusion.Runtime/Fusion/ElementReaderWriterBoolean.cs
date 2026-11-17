using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab.GroupsModels;

namespace Fusion;

[StructLayout((LayoutKind)0, Size = 1)]
public struct ElementReaderWriterBoolean : Action<ListGroupBlocksResponse>
{
	private static IElementReaderWriter<bool> Instance;

	[MethodImpl((MethodImplOptions)256)]
	public static IElementReaderWriter<bool> GetInstance()
	{
		//IL_0010: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I4
		//IL_0037: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6C48]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+A0]");
		object obj3 = 0;
		IElementReaderWriter<bool> result = (IElementReaderWriter<bool>)obj3;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5+A0]");
			object obj6 = 0;
			IElementReaderWriter<bool> elementReaderWriter = default;
			obj6 = elementReaderWriter;
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			result = elementReaderWriter;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe bool Read(byte* data, int index)
	{
		int num = index << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (System.Byte*)+v0 @ X8_v1 (System.Int32)]");
		bool flag = (nint)0 == 0;
		return !flag;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe ref bool ReadRef(byte* data, int index)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		NotSupportedException ex = default;
		string message = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return ref *(bool*)ex2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void Write(byte* data, int index, bool val)
	{
		int num = index << 2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public int GetElementWordCount()
	{
		return 1;
	}

	[MethodImpl((MethodImplOptions)256)]
	public int GetElementHashCode(bool val)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v2+30]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X0_v1+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = default;
		return flag2.GetHashCode();
	}

	public bool Read(ReadOnlySpan<byte> data)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36A197C");
		object obj = default;
		bool flag = obj == null;
		return !flag;
	}

	public void Write(Span<byte> data, bool val)
	{
		//IL_001d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36A1980");
		nint num = default;
		object obj = num & 1;
		object obj2 = obj;
	}

	public unsafe ref bool ReadRef(Span<byte> data)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		NotSupportedException ex = default;
		string message = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return ref *(bool*)ex2;
	}
}
