using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;

namespace Fusion;

internal class NetworkInterestedObjectList
{
	private HashSet<NetworkObjectConnectionData> _active;

	public Enumerator Active
	{
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			if (_active != null)
			{
				Enumerator enumerator = ((HashSet<System.__Canon>)(object)_active).GetEnumerator();
				object obj2 = default;
				object obj = obj2;
				return enumerator;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Enumerator)ex;
		}
	}

	public void SetIdle(NetworkObjectConnectionData item)
	{
		if (((HashSet<System.__Canon>)(object)_active).Contains((System.__Canon)(object)item))
		{
			bool flag = ((HashSet<System.__Canon>)(object)_active).Remove((System.__Canon)(object)item);
		}
	}

	public void SetActive(NetworkObjectConnectionData item, NetworkObjectMeta meta)
	{
		bool flag = ((HashSet<System.__Canon>)(object)_active).Add((System.__Canon)(object)item);
	}

	public void Remove(NetworkObjectConnectionData item)
	{
		bool flag = ((HashSet<System.__Canon>)(object)_active).Remove((System.__Canon)(object)item);
	}

	public bool IsActive(NetworkObjectConnectionData data)
	{
		//IL_002c: Expected I4, but got Obj
		if (_active != null)
		{
			return ((HashSet<System.__Canon>)(object)_active).Contains((System.__Canon)(object)data);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public NetworkInterestedObjectList()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D70E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<System.__Canon> hashSet = default;
		hashSet._002Ector();
		object obj2 = this + 16;
		obj2 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
