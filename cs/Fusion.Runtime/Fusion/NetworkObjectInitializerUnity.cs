using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

public class NetworkObjectInitializerUnity : _0021_00210
{
	public void InitializeNetworkState(NetworkObject networkObject)
	{
		//IL_0056: Expected Obj, but got I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0091: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		if ((object)networkObject != null)
		{
			NetworkBehaviour[] networkedBehaviours = networkObject.NetworkedBehaviours;
			if (networkObject.NetworkedBehaviours != null)
			{
				object obj = networkedBehaviours.Length;
				if (networkedBehaviours.Length < 1)
				{
					return;
				}
				object obj2 = networkObject.NetworkedBehaviours + 32;
				object obj3 = 0;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
					object obj4 = !flag;
					if (obj4 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X21_v5+v26 @ X20_v6*8]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X21_v5+v26 @ X20_v6*8]");
					if ((nint)0 != 0)
					{
						object obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X8_v6+2A8] (should have been resolved before IL gen)");
						obj = networkedBehaviours.Length;
						obj3++;
						if ((nint)obj3 >= networkedBehaviours.Length)
						{
							return;
						}
						continue;
					}
					goto IL_0114;
				}
				goto IL_0122;
			}
		}
		goto IL_0114;
		IL_0122:
		throw new IndexOutOfRangeException();
		IL_0114:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0122;
	}
}
