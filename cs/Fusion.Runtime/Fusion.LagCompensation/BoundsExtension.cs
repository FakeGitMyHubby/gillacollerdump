using System.Runtime.CompilerServices;
using UnityEngine;

namespace Fusion.LagCompensation;

internal static class BoundsExtension
{
	[MethodImpl((MethodImplOptions)256)]
	internal unsafe static bool ContainBounds(Bounds bounds, Bounds target)
	{
		//IL_000e: Expected Ref, but got VT
		//IL_003c: Expected Ref, but got VT
		Vector3 point = default;
		if (((Bounds*)bounds)->Internal_Contains(ref point))
		{
			return ((Bounds*)bounds)->Internal_Contains(ref point);
		}
		return false;
	}
}
