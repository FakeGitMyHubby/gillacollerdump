using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Photon.Client;

public class ByteArraySlice : IEnumerable<KeyValuePair<_00210, _00211>>
{
	public byte[] Buffer;

	public int Offset;

	public int Count;

	private readonly ByteArraySlicePool returnPool;

	private readonly int stackIndex;

	internal ByteArraySlice(ByteArraySlicePool returnPool, int stackIndex)
	{
		//IL_0096: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0015: Expected Obj, but got I
		object obj2;
		if (stackIndex != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
			object obj = 0;
			int num = 1 << stackIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj3 = default;
			obj2 = obj3;
		}
		else
		{
			object obj4 = this != null;
			obj2 = 0;
			if (obj4 == null)
			{
				throw new NullReferenceException();
			}
		}
		object obj5 = this + 16;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = this + 32;
		obj6 = returnPool;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public ByteArraySlice(byte[] buffer, int offset = default(int), int count = default(int))
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		object obj = this + 16;
		obj = buffer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = this + 32;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 4294967295L;
	}

	public ByteArraySlice()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_001a: Expected Obj, but got I4
		object obj = this + 32;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 4294967295L;
	}

	public void Dispose()
	{
		bool flag = Release();
	}

	public bool Release()
	{
		//IL_0014: Expected I4, but got I8
		//IL_002e: Expected Obj, but got I4
		//IL_0095: Expected I4, but got Obj
		int num = (int)(stackIndex & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			Offset = 0;
			if (returnPool != null)
			{
				return returnPool.Release(this, stackIndex);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return false;
	}

	public void Reset()
	{
		Offset = 0;
	}
}
