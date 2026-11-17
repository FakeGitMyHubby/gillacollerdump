using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion.LagCompensation;

public struct AABB
{
	public readonly Vector3 Center;

	public readonly Vector3 Extents;

	public readonly Vector3 Min;

	public readonly Vector3 Max;

	public AABB(Bounds bounds)
	{
		//IL_006c: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I
		Center = bounds.m_Center;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+8]");
		_ = 0;
		Extents = bounds.m_Extents;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+14]");
		_ = 0;
		Vector3 min = bounds.m_Center - bounds.m_Extents;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+14]");
		object obj = num - 0;
		Min = min;
		Vector3 max = bounds.m_Center + bounds.m_Extents;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+14]");
		object obj2 = num2 + 0;
		Max = max;
	}

	public AABB(Vector3 center, Vector3 extents)
	{
		Vector3 vector = default;
		Vector3 vector2 = default;
		Vector3 min = vector - vector2;
		Center = vector;
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		Extents = vector2;
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 - obj6;
		Vector3 max = vector + vector2;
		object obj7 = obj2 + obj3;
		object obj8 = obj5 + obj6;
		Min = min;
		Max = max;
	}

	public AABB(Vector3 center, Vector3 pointA, Vector3 pointB)
	{
		//IL_001c: Expected Obj, but got VT
		//IL_0047: Expected Obj, but got VT
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0105: Expected Obj, but got I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_01c2: Expected Obj, but got I4
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_027f: Expected Obj, but got I4
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		Vector3 vector = default;
		Center = vector;
		Vector3 vector2 = default;
		Vector3 vector3 = default;
		object obj = vector2 - vector3;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		object obj2 = vector2 ^ vector3;
		object obj3 = vector2 ^ obj;
		object obj4 = obj2 & obj3;
		bool flag3 = (nint)obj4 < 0;
		Vector3 min = ((vector2 >= vector3) ? vector3 : vector2);
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		object obj6 = flag4 & obj5;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
		}
		object obj9 = default;
		object obj10 = default;
		object obj8 = obj9 - obj10;
		bool flag5 = (nint)obj8 < 0;
		bool flag6 = obj8 == null;
		object obj11 = obj9 ^ obj10;
		object obj12 = obj9 ^ obj8;
		object obj13 = obj11 & obj12;
		bool flag7 = (nint)obj13 < 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
		{
			object obj14 = obj9;
		}
		else
		{
			object obj14 = obj10;
		}
		bool flag8 = flag5 == flag7;
		object obj15 = !flag6;
		object obj16 = flag8 & obj15;
		object obj17 = ~obj16;
		if (obj17 == null)
		{
		}
		object obj19 = default;
		object obj20 = default;
		object obj18 = obj19 - obj20;
		bool flag9 = (nint)obj18 < 0;
		bool flag10 = obj18 == null;
		object obj21 = obj19 ^ obj20;
		object obj22 = obj19 ^ obj18;
		object obj23 = obj21 & obj22;
		bool flag11 = (nint)obj23 < 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20))
		{
			object obj24 = obj19;
		}
		else
		{
			object obj24 = obj20;
		}
		bool flag12 = flag9 == flag11;
		object obj25 = !flag10;
		object obj26 = flag12 & obj25;
		object obj27 = ~obj26;
		if (obj27 == null)
		{
		}
		Min = min;
		Max = vector3;
		Vector3 extents = vector3 - vector;
		object obj29 = default;
		object obj28 = obj20 - obj29;
		object obj31 = default;
		object obj30 = obj10 - obj31;
		Extents = extents;
	}
}
