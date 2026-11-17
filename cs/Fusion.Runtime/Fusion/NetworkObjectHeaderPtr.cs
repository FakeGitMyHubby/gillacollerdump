using System;
using Cpp2ILInjected;

namespace Fusion;

public unsafe struct NetworkObjectHeaderPtr(NetworkObjectHeader* ptr)
{
	public unsafe NetworkObjectHeader* Ptr = ptr;

	public unsafe NetworkObjectTypeId Type
	{
		get
		{
			//IL_0044: Expected VT, but got Obj
			//IL_0036: Expected VT, but got I
			NetworkObjectHeader* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Fusion.NetworkObjectHeader*)+8]");
				return (NetworkObjectTypeId)0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (NetworkObjectTypeId)ex;
		}
	}

	public unsafe NetworkId Id
	{
		get
		{
			//IL_003c: Expected VT, but got Obj
			//IL_002e: Expected VT, but got I
			NetworkObjectHeader* ptr = Ptr;
			if (Ptr == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (NetworkId)ex;
			}
			return (NetworkId)ptr;
		}
	}

	public unsafe NetworkObjectHeaderFlags Flags
	{
		get
		{
			//IL_0044: Expected I4, but got Obj
			NetworkObjectHeader* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Fusion.NetworkObjectHeader*)+18]");
				return (NetworkObjectHeaderFlags)0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (NetworkObjectHeaderFlags)ex;
		}
	}

	public unsafe NetworkId NestingRoot
	{
		get
		{
			//IL_0044: Expected VT, but got Obj
			//IL_0036: Expected VT, but got I
			NetworkObjectHeader* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Fusion.NetworkObjectHeader*)+10]");
				return (NetworkId)0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (NetworkId)ex;
		}
	}

	public unsafe Span<int> Data
	{
		get
		{
			//IL_0057: Expected VT, but got Obj
			//IL_0044: Expected VT, but got I
			NetworkObjectHeader* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X19_v2 (Fusion.NetworkObjectHeader*)+4]");
				if ((nint)0 <= (nint)19)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				return (Span<int>)((byte*)Ptr + 80);
			}
			NullReferenceException ex = new NullReferenceException();
			return (Span<int>)ex;
		}
	}
}
