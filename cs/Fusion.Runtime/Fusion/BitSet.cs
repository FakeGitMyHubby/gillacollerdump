using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

internal struct BitSet
{
	private readonly Span<ulong> _words;

	public int Length
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet)+8]");
			return (int)((nint)0 << 6);
		}
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe BitSet(Span<ulong> words)
	{
		//IL_0070: Expected Obj, but got I8
		//IL_007e: Expected I8, but got Obj
		//IL_008b: Expected Ref, but got VT
		_words = words;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEFB8]");
		Span<ulong> span;
		if ((nint)0 != 0)
		{
			span = words;
		}
		else
		{
			span = _words;
			_ = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet)+8]");
		object obj = 0 & 0xFFFFFFFFL;
		ulong byteLength = (ulong)(obj << 3);
		System.SpanHelpers.ClearWithoutReferences(ref *(byte*)span, byteLength);
	}

	[MethodImpl((MethodImplOptions)256)]
	public static int WordsRequired(int bitCount)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_001c: Expected I4, but got Obj
		object obj = bitCount + 63;
		return obj >> 6;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void Clear()
	{
		//IL_001b: Expected I8, but got I
		//IL_002a: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet)+8]");
		ulong byteLength = (ulong)((nint)0 << 3);
		System.SpanHelpers.ClearWithoutReferences(ref *(byte*)_words, byteLength);
	}

	[MethodImpl((MethodImplOptions)256)]
	public void Set(int bit)
	{
		//IL_002f: Expected Obj, but got I4
		int num = bit >> 6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet)+8]");
		bool flag = (nint)num < (nint)0;
		object obj = !flag;
		if (obj == null)
		{
			Span<ulong> words = _words;
			int num2 = 1 << bit;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X9_v2 (System.Span`1<System.UInt64>)+v0 @ X8_v1 (System.Int32)*8]");
			int num3 = (int)((nint)0 | (nint)num2);
			return;
		}
		throw new IndexOutOfRangeException();
	}

	[MethodImpl((MethodImplOptions)256)]
	public bool IsSet(int bit)
	{
		//IL_002f: Expected Obj, but got I4
		//IL_007d: Expected I4, but got Obj
		int num = bit >> 6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet)+8]");
		bool flag = (nint)num < (nint)0;
		object obj = !flag;
		if (obj == null)
		{
			Span<ulong> words = _words;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X9_v2 (System.Span`1<System.UInt64>)+v0 @ X8_v1 (System.Int32)*8]");
			int num2 = (int)((nint)0 >> bit);
			return (byte)(num2 & 1) != 0;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
	}
}
