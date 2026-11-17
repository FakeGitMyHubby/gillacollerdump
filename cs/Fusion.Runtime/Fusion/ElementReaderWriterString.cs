using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Fusion;

[StructLayout((LayoutKind)0, Size = 1)]
public struct ElementReaderWriterString<TCapacity> : _0021_00210 where TCapacity : struct, IMetaConstant
{
	private static IElementReaderWriter<string> Instance;

	[MethodImpl((MethodImplOptions)256)]
	public static IElementReaderWriter<string> GetInstance()
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X0_v2 (Il2CppClass<Fusion.ElementReaderWriterString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X8_v3+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v4+A0]");
		object obj6 = 0;
		IElementReaderWriter<string> result = (IElementReaderWriter<string>)obj6;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6 (Il2CppClass<Fusion.ElementReaderWriterString`1>)+A8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v9 (Il2CppClass<Fusion.ElementReaderWriterString`1>)+A8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X9_v4+8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X9_v5+A0]");
			object obj17 = 0;
			IElementReaderWriter<string> elementReaderWriter = default;
			obj17 = elementReaderWriter;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v12 (Il2CppClass<Fusion.ElementReaderWriterString`1>)+135]");
			object obj18 = (nint)0 & (nint)1;
			bool flag5 = obj18 == null;
			object obj19 = !flag5;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr = default;
				nint num3 = intPtr;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v12 (Il2CppClass<Fusion.ElementReaderWriterString`1>)+A8]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v13+8]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			result = elementReaderWriter;
		}
		return result;
	}

	public unsafe string Read(byte* data, int index)
	{
		//IL_000c: Expected Obj, but got I
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_016f: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected I, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj;
		object obj3 = obj & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		nint num;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj5 = (nint)0 + (nint)309;
			obj2 = obj5;
			num = 0;
		}
		else
		{
			nint num2 = 0;
			num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v1 (Il2CppClass<Fusion.ElementReaderWriterString`1>)+A8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X10_v1+18]");
		object obj7 = 0;
		object obj8 = obj2 & 1;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj10 = (nint)0 + (nint)309;
			obj2 = obj10;
			num = 0;
		}
		else
		{
			IntPtr intPtr = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2 (Il2CppClass<Fusion.ElementReaderWriterString`1>)+A8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X10_v3+10]");
		object obj12 = 0;
		object obj13 = obj2 & 1;
		bool flag3 = obj13 == null;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			num = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4 (Il2CppClass<Fusion.ElementReaderWriterString`1>)+A8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v64 @ X10_v4] (should have been resolved before IL gen)");
		object obj17 = default;
		object obj16 = obj17 * index;
		int* ptr = (int*)(nint)(data + obj16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X10_v2+FC]");
		int num3 = ReadWriteUtilsForWeaver.ReadStringUtf32NoHash(ptr, 0, out var result);
		return result;
	}

	public unsafe void Write(byte* data, int index, string element)
	{
		//IL_000c: Expected Obj, but got I
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_016f: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected I, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj;
		object obj3 = obj & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		nint num;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj5 = (nint)0 + (nint)309;
			obj2 = obj5;
			num = 0;
		}
		else
		{
			nint num2 = 0;
			num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v1 (Il2CppClass<Fusion.ElementReaderWriterString`1>)+A8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X10_v1+18]");
		object obj7 = 0;
		object obj8 = obj2 & 1;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj10 = (nint)0 + (nint)309;
			obj2 = obj10;
			num = 0;
		}
		else
		{
			IntPtr intPtr = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v2 (Il2CppClass<Fusion.ElementReaderWriterString`1>)+A8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X10_v3+10]");
		object obj12 = 0;
		object obj13 = obj2 & 1;
		bool flag3 = obj13 == null;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			num = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4 (Il2CppClass<Fusion.ElementReaderWriterString`1>)+A8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ X10_v4] (should have been resolved before IL gen)");
		object obj17 = default;
		object obj16 = obj17 * index;
		int* ptr = (int*)(nint)(data + obj16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X10_v2+FC]");
		int num3 = ReadWriteUtilsForWeaver.WriteStringUtf32NoHash(ptr, 0, element);
	}

	public int GetElementWordCount()
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X0_v2 (Il2CppClass<Fusion.ElementReaderWriterString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X8_v3+18]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X8_v4+FC]");
		return (int)((nint)0 + (nint)1);
	}

	public unsafe ref string ReadRef(byte* data, int index)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		NotSupportedException ex = default;
		string message = default;
		ex._002Ector(message);
		ArgumentNullException ex2 = new ArgumentNullException();
		return ref *(string*)ex2;
	}

	public int GetElementHashCode(string element)
	{
		//IL_0100: Expected Obj, but got I
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0128: Expected Obj, but got I4
		//IL_00f4: Expected I4, but got Obj
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		if (element != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3 (Il2CppClass<Fusion.ElementReaderWriterString`1>)+A8]");
			object obj5 = 0;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X9_v1+18]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int stringLength = element._stringLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v7+FC]");
			int len = Math.Min(stringLength, 0);
			return HashCodeUtilities.GetHashDeterministicInternal(element, len, 352654597);
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public unsafe string Read(ReadOnlySpan<byte> data)
	{
		//IL_0078: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00b7: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I
		//IL_0034: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X3+20]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X3+20]");
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+A8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
		object obj6 = 0;
		ReadOnlySpan<byte> readOnlySpan = default;
		ref byte reference = ref readOnlySpan.GetPinnableReference();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v6+FC]");
		int num = ReadWriteUtilsForWeaver.ReadStringUtf32NoHash((int*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), 0, out var result);
		return result;
	}

	public unsafe void Write(Span<byte> data, string element)
	{
		//IL_0074: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00b3: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I
		//IL_0034: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X4+20]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X4+20]");
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+A8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5+18]");
		object obj6 = 0;
		Span<byte> span = default;
		ref byte reference = ref span.GetPinnableReference();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6+FC]");
		IntPtr intPtr = default;
		int num = ReadWriteUtilsForWeaver.WriteStringUtf32NoHash((int*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), 0, (string)(nint)intPtr);
	}

	public unsafe ref string ReadRef(Span<byte> data)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		NotSupportedException ex = default;
		string message = default;
		ex._002Ector(message);
		ArgumentNullException ex2 = new ArgumentNullException();
		return ref *(string*)ex2;
	}
}
