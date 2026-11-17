using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

internal class OffsetSet
{
	private int[] _003CsortedOffsets_003EP;

	public bool IsEmpty
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_004d: Expected I4, but got Obj
			int[] array = _003CsortedOffsets_003EP;
			if (_003CsortedOffsets_003EP != null)
			{
				return array.Length == 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public ReadOnlySpan<int> Values => _003CsortedOffsets_003EP;

	public int[] AsArray => _003CsortedOffsets_003EP;

	public OffsetSet(int[] sortedOffsets)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 16;
		obj = sortedOffsets;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	public unsafe bool TryFind(int offset, ref int index)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I4
		//IL_0105: Expected I4, but got Obj
		//IL_0051: Expected Obj, but got I
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00c3: Expected Obj, but got I4
		int[] array = _003CsortedOffsets_003EP;
		object obj = index;
		while (true)
		{
			bool flag = (nint)obj < array.Length;
			object obj2 = !flag;
			if ((nint)obj < array.Length)
			{
				if (obj2 != null)
				{
					break;
				}
				object obj3 = (object)array + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v6+20]");
				object obj4 = -offset;
				bool result = obj4 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v6+20]");
				if ((nint)0 < (nint)offset)
				{
					obj++;
					ref int reference = ref *(int*)obj;
					array = _003CsortedOffsets_003EP;
					bool flag2 = _003CsortedOffsets_003EP == null;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						throw new NullReferenceException();
					}
					continue;
				}
				return result;
			}
			return false;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
	}
}
