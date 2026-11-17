using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

internal static class BehaviourUtils
{
	internal class HitboxComparerZ : _0021_00210
	{
		public unsafe int Compare(HitboxRoot a, HitboxRoot b)
		{
			//IL_00e1: Expected I4, but got Obj
			//IL_00c5: Expected Ref, but got F4
			if ((object)a != null)
			{
				Transform transform = a.transform;
				if ((object)transform != null)
				{
					Vector3 position = transform.position;
					if ((object)b != null)
					{
						Transform transform2 = b.transform;
						if ((object)transform2 != null)
						{
							Vector3 position2 = transform2.position;
							object obj = default;
							float num = (float)(ref obj) + 8f;
							float value = default;
							return ((float*)num)->CompareTo(value);
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public struct DeferredJoin
	{
		public IEnumerable _enumerable;

		public override string ToString()
		{
			//IL_0011: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F48]");
			object separator = 0;
			IEnumerable<System.__Canon> values = Enumerable.Cast<System.__Canon>(_enumerable);
			return string.Join((string)separator, values);
		}
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool IsNull(Behaviour obj)
	{
		return (object)obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool IsNotNull(Behaviour obj)
	{
		bool flag = (object)obj == null;
		return !flag;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool IsAlive(NetworkRunner obj)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return obj;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool IsNotAlive(NetworkRunner obj)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = obj;
		object obj5 = !flag2;
		return (byte)(1 & obj5) != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool IsAlive(SimulationBehaviour obj)
	{
		//IL_0017: Expected I4, but got Obj
		//IL_0038: Expected Obj, but got I4
		bool flag = (object)obj == null;
		bool result = (byte)(int)obj != 0;
		if (!flag)
		{
			object obj2 = obj.Flags & (SimulationBehaviourRuntimeFlags)8;
			bool flag2 = obj2 == null;
			result = flag2;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool IsNotAlive(SimulationBehaviour obj)
	{
		//IL_0030: Expected Obj, but got I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected I4, but got Unknown
		if ((object)obj != null)
		{
			object obj2 = (int)obj.Flags >> 3;
			return (byte)(obj2 & 1) != 0;
		}
		return true;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool IsAlive(NetworkObject obj)
	{
		//IL_0017: Expected I4, but got Obj
		//IL_0038: Expected Obj, but got I4
		bool flag = (object)obj == null;
		bool result = (byte)(int)obj != 0;
		if (!flag)
		{
			object obj2 = obj.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
			bool flag2 = obj2 == null;
			result = flag2;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool IsNotAlive(NetworkObject obj)
	{
		//IL_0030: Expected Obj, but got I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected I4, but got Unknown
		if ((object)obj != null)
		{
			object obj2 = (int)obj.RuntimeFlags >> 1;
			return (byte)(obj2 & 1) != 0;
		}
		return true;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool IsSame(Behaviour a, Behaviour b)
	{
		object obj = (object)a - (object)b;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool IsSameNotNull(Behaviour a, Behaviour b)
	{
		//IL_001a: Expected Obj, but got I4
		bool flag = (object)a == null;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			object obj3 = (object)a - (object)b;
			return obj3 == null;
		}
		return false;
	}

	public static BitSet64.NameDeferred GetName(Behaviour obj)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		BitSet64.NameDeferred result = default;
		return result;
	}

	public static DeferredJoin Join(IEnumerable objects)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		DeferredJoin result = default;
		return result;
	}
}
