using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion.LagCompensation;

internal class Mapper
{
	private readonly Dictionary<HitboxRoot, int> _rootToNodeIndex;

	internal int Count
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0028: Expected I4, but got Obj
			if ((object)_rootToNodeIndex != null)
			{
				return ((Dictionary<System.__Canon, int>)(object)_rootToNodeIndex).Count;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	[MethodImpl((MethodImplOptions)256)]
	internal bool TryGetLeafIndex(HitboxRoot root, out int index)
	{
		//IL_0030: Expected I4, but got Obj
		if ((object)_rootToNodeIndex != null)
		{
			return ((Dictionary<System.__Canon, int>)(object)_rootToNodeIndex).TryGetValue((System.__Canon)(object)root, out index);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal int GetLeafIndex(HitboxRoot root)
	{
		//IL_0081: Expected I4, but got Obj
		//IL_0016: Expected Obj, but got I
		if ((object)_rootToNodeIndex != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAE98]");
			object error = 0;
			bool condition = ((Dictionary<System.__Canon, int>)(object)_rootToNodeIndex).ContainsKey((System.__Canon)(object)root);
			Assert.Check(condition, (string)error);
			if ((object)_rootToNodeIndex != null)
			{
				return ((Dictionary<System.__Canon, int>)(object)_rootToNodeIndex).get_Item((System.__Canon)(object)root);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal void RegisterMapping(HitboxRoot root, int leafIndex)
	{
		((Dictionary<System.__Canon, int>)(object)_rootToNodeIndex).set_Item((System.__Canon)(object)root, leafIndex);
	}

	[MethodImpl((MethodImplOptions)256)]
	internal void DeRegister(HitboxRoot root)
	{
		bool flag = ((Dictionary<System.__Canon, int>)(object)_rootToNodeIndex).Remove((System.__Canon)(object)root);
	}

	public Mapper()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAEA0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, int> dictionary = default;
		dictionary._002Ector();
		object obj2 = this + 16;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
