using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion.LagCompensation;

internal static class LagCompensationUtils
{
	internal enum Rot
	{
		// error: enumerator has no value
		NONE,
		// error: enumerator has no value
		L_RL,
		// error: enumerator has no value
		L_RR,
		// error: enumerator has no value
		R_LL,
		// error: enumerator has no value
		R_LR,
		// error: enumerator has no value
		LL_RR,
		// error: enumerator has no value
		LL_RL
	}

	internal struct CustomPlanesBox
	{
		public CustomPlane P0;

		public CustomPlane P1;

		public CustomPlane P2;

		public CustomPlane P3;

		public CustomPlane P4;

		public CustomPlane P5;
	}

	internal struct CustomPlane
	{
		public Vector3 Normal;

		public Vector3 PointOnPlane;

		public CustomPlane(Vector3 normal, Vector3 pointOnPlane)
		{
			Vector3 normal2 = default;
			Normal = normal2;
			Vector3 pointOnPlane2 = default;
			PointOnPlane = pointOnPlane2;
		}
	}

	internal struct CustomEdgesBox
	{
		public Vector3 P0;

		public Vector3 P1;

		public Vector3 P2;

		public Vector3 P3;

		public Vector3 P4;

		public Vector3 P5;

		public Vector3 P6;

		public Vector3 P7;

		public unsafe CustomLine E00
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_000e: Expected VT, but got I4
				//IL_0009: Expected native int or pointer, but got VT
				//IL_001e: Expected native int or pointer, but got VT
				//IL_0032: Expected VT, but got Ref
				CustomLine customLine = default;
				((CustomLine*)(nint)customLine)->Start = (Vector3)0;
				_ = 0;
				((CustomLine*)(nint)customLine)->Start = P0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+10]");
				_ = 0;
				return (CustomLine)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}
		}

		public unsafe CustomLine E01
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_000e: Expected VT, but got I4
				//IL_0009: Expected native int or pointer, but got VT
				//IL_001e: Expected native int or pointer, but got VT
				//IL_0032: Expected VT, but got Ref
				CustomLine customLine = default;
				((CustomLine*)(nint)customLine)->Start = (Vector3)0;
				_ = 0;
				((CustomLine*)(nint)customLine)->Start = P1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+1C]");
				_ = 0;
				return (CustomLine)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}
		}

		public unsafe CustomLine E02
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_000e: Expected VT, but got I4
				//IL_0009: Expected native int or pointer, but got VT
				//IL_001e: Expected native int or pointer, but got VT
				//IL_0032: Expected VT, but got Ref
				CustomLine customLine = default;
				((CustomLine*)(nint)customLine)->Start = (Vector3)0;
				_ = 0;
				((CustomLine*)(nint)customLine)->Start = P2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+28]");
				_ = 0;
				return (CustomLine)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}
		}

		public unsafe CustomLine E03
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_000e: Expected VT, but got I4
				//IL_0009: Expected native int or pointer, but got VT
				//IL_0039: Expected native int or pointer, but got VT
				//IL_0040: Expected VT, but got Ref
				CustomLine customLine = default;
				((CustomLine*)(nint)customLine)->Start = (Vector3)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				_ = P0;
				((CustomLine*)(nint)customLine)->Start = P3;
				return (CustomLine)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}
		}

		public unsafe CustomLine E04
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_000e: Expected VT, but got I4
				//IL_0009: Expected native int or pointer, but got VT
				//IL_001e: Expected native int or pointer, but got VT
				//IL_0032: Expected VT, but got Ref
				CustomLine customLine = default;
				((CustomLine*)(nint)customLine)->Start = (Vector3)0;
				_ = 0;
				((CustomLine*)(nint)customLine)->Start = P4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+40]");
				_ = 0;
				return (CustomLine)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}
		}

		public unsafe CustomLine E05
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_000e: Expected VT, but got I4
				//IL_0009: Expected native int or pointer, but got VT
				//IL_001e: Expected native int or pointer, but got VT
				//IL_0032: Expected VT, but got Ref
				CustomLine customLine = default;
				((CustomLine*)(nint)customLine)->Start = (Vector3)0;
				_ = 0;
				((CustomLine*)(nint)customLine)->Start = P5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+4C]");
				_ = 0;
				return (CustomLine)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}
		}

		public unsafe CustomLine E06
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_000e: Expected VT, but got I4
				//IL_0009: Expected native int or pointer, but got VT
				//IL_001e: Expected native int or pointer, but got VT
				//IL_0032: Expected VT, but got Ref
				CustomLine customLine = default;
				((CustomLine*)(nint)customLine)->Start = (Vector3)0;
				_ = 0;
				((CustomLine*)(nint)customLine)->Start = P6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+58]");
				_ = 0;
				return (CustomLine)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}
		}

		public unsafe CustomLine E07
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_000e: Expected VT, but got I4
				//IL_0009: Expected native int or pointer, but got VT
				//IL_003f: Expected native int or pointer, but got VT
				//IL_0046: Expected VT, but got Ref
				CustomLine customLine = default;
				((CustomLine*)(nint)customLine)->Start = (Vector3)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+34]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				((CustomLine*)(nint)customLine)->Start = P7;
				return (CustomLine)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}
		}

		public unsafe CustomLine E08
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_000e: Expected VT, but got I4
				//IL_0009: Expected native int or pointer, but got VT
				//IL_0039: Expected native int or pointer, but got VT
				//IL_0040: Expected VT, but got Ref
				CustomLine customLine = default;
				((CustomLine*)(nint)customLine)->Start = (Vector3)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				_ = P0;
				((CustomLine*)(nint)customLine)->Start = P4;
				return (CustomLine)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}
		}

		public unsafe CustomLine E09
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_000e: Expected VT, but got I4
				//IL_0009: Expected native int or pointer, but got VT
				//IL_003f: Expected native int or pointer, but got VT
				//IL_0046: Expected VT, but got Ref
				CustomLine customLine = default;
				((CustomLine*)(nint)customLine)->Start = (Vector3)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				((CustomLine*)(nint)customLine)->Start = P5;
				return (CustomLine)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}
		}

		public unsafe CustomLine E10
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_000e: Expected VT, but got I4
				//IL_0009: Expected native int or pointer, but got VT
				//IL_003f: Expected native int or pointer, but got VT
				//IL_0046: Expected VT, but got Ref
				CustomLine customLine = default;
				((CustomLine*)(nint)customLine)->Start = (Vector3)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+1C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				((CustomLine*)(nint)customLine)->Start = P6;
				return (CustomLine)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}
		}

		public unsafe CustomLine E11
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_000e: Expected VT, but got I4
				//IL_0009: Expected native int or pointer, but got VT
				//IL_003f: Expected native int or pointer, but got VT
				//IL_0046: Expected VT, but got Ref
				CustomLine customLine = default;
				((CustomLine*)(nint)customLine)->Start = (Vector3)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				((CustomLine*)(nint)customLine)->Start = P7;
				return (CustomLine)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}
		}
	}

	internal struct CustomLine
	{
		public Vector3 Start;

		public Vector3 End;

		public CustomLine(Vector3 start, Vector3 end)
		{
			Vector3 start2 = default;
			Start = start2;
			Vector3 end2 = default;
			End = end2;
		}
	}

	private struct RotationMatrix
	{
		public float M00;

		public float M01;

		public float M02;

		public float M10;

		public float M11;

		public float M12;

		public float M20;

		public float M21;

		public float M22;
	}

	internal struct BoxNarrowData
	{
		public Vector3 Position;

		public Vector3 Extents;

		public Vector3 RotatedRight;

		public Vector3 RotatedUp;

		public Vector3 RotatedForward;

		public CustomPlanesBox BoxPlanesRotated;

		public CustomEdgesBox BoxEdgesRotated;

		public unsafe BoxNarrowData(Vector3 pos, Quaternion rot, Vector3 extents)
		{
			//IL_028d: Expected VT, but got I4
			//IL_029c: Expected Obj, but got Ref
			//IL_02a4: Expected Obj, but got VT
			//IL_02c1: Expected VT, but got I4
			//IL_02d0: Expected Obj, but got Ref
			//IL_02d8: Expected Obj, but got VT
			//IL_02f5: Expected VT, but got I4
			//IL_031b: Expected VT, but got I4
			//IL_0341: Expected VT, but got I4
			//IL_004a: Expected VT, but got I4
			//IL_006b: Expected VT, but got I4
			//IL_0091: Expected VT, but got I4
			//IL_00b2: Expected VT, but got I4
			//IL_00d8: Expected VT, but got I4
			//IL_00f9: Expected VT, but got I4
			//IL_0125: Expected Obj, but got VT
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Expected Obj, but got Unknown
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Expected Obj, but got Unknown
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected Obj, but got Unknown
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Expected Obj, but got Unknown
			//IL_01a9: Expected VT, but got Obj
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected Obj, but got Unknown
			Vector3 position = default;
			Position = position;
			Vector3 vector = default;
			Extents = vector;
			Vector3 vector2 = (Quaternion)0 * pos;
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 24));
			Vector3 vector3 = default;
			obj = vector3;
			Vector3 vector4 = (Quaternion)0 * pos;
			object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 36));
			obj2 = vector3;
			Vector3 vector5 = (Quaternion)0 * pos;
			RotatedForward = vector3;
			Vector3 vector6 = (Quaternion)0 * pos;
			BoxEdgesRotated = (CustomEdgesBox)vector3;
			Vector3 vector7 = (Quaternion)0 * pos;
			Vector3 vector8 = (Quaternion)0 * pos;
			Vector3 vector9 = (Quaternion)0 * pos;
			Vector3 vector10 = (Quaternion)0 * pos;
			Vector3 vector11 = (Quaternion)0 * pos;
			Vector3 vector12 = (Quaternion)0 * pos;
			Vector3 vector13 = (Quaternion)0 * pos;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			object obj3 = vector * RotatedRight;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			object obj5 = default;
			object obj4 = obj5 * RotatedForward;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.LagCompensationUtils+BoxNarrowData)+1C]");
			object obj7 = default;
			object obj6 = 0 * obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			object obj9 = default;
			object obj8 = obj9 * RotatedUp;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.LagCompensationUtils+BoxNarrowData)+28]");
			object obj11 = default;
			object obj10 = 0 * obj11;
			BoxPlanesRotated = (CustomPlanesBox)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.LagCompensationUtils+BoxNarrowData)+34]");
			object obj13 = default;
			object obj12 = 0 * obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X20_v4+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X21_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.LagCompensationUtils+BoxNarrowData)+38]");
			_ = 0;
			_ = RotatedForward;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.LagCompensationUtils+BoxNarrowData)+1C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.LagCompensationUtils+BoxNarrowData)+34]");
			_ = 0;
		}

		[MethodImpl((MethodImplOptions)256)]
		public Vector3 LocalToWorldPoint(Vector3 point)
		{
			return LocalToWorldVector(point);
		}

		[MethodImpl((MethodImplOptions)256)]
		public Vector3 WorldToLocalPoint(Vector3 point)
		{
			return WorldToLocalVector(point);
		}

		public unsafe Vector3 LocalToWorldVector(Vector3 vec)
		{
			//IL_0002: Expected VT, but got Ref
			return (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}

		public unsafe Vector3 WorldToLocalVector(Vector3 vec)
		{
			//IL_0002: Expected VT, but got Ref
			return (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}
	}

	private const float ALLOWED_DOT_DIFF = default(float);

	private const float EXTENTS_EXPANSION_MULTIPLIER = default(float);

	private const float MIN_CROSS_THRESHOLD = default(float);

	internal unsafe static bool NarrowBoxBox(ref BoxNarrowData aNarrow, ref BoxNarrowData bNarrow, bool detailedManifold, out Vector3 hitPoint, out Vector3 normal)
	{
		//IL_0036: Expected Obj, but got Ref
		//IL_0044: Expected Obj, but got Ref
		//IL_0061: Expected Obj, but got I
		//IL_006f: Expected Obj, but got Ref
		//IL_008c: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got Ref
		//IL_00d1: Expected Obj, but got I
		//IL_00df: Expected Obj, but got Ref
		//IL_00fc: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_0200: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0264: Expected Obj, but got I
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_029c: Expected Obj, but got Ref
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_0340: Expected Obj, but got I4
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_0399: Expected Obj, but got I
		//IL_03d0: Expected Obj, but got I
		//IL_03ed: Expected Obj, but got I
		//IL_0424: Expected Obj, but got I
		//IL_044e: Expected Obj, but got I
		//IL_0478: Expected Obj, but got I
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected Obj, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected Obj, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected Obj, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected Obj, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected Obj, but got Unknown
		//IL_05be: Expected Obj, but got I4
		//IL_204e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2053: Expected Obj, but got Unknown
		//IL_207a: Unknown result type (might be due to invalid IL or missing references)
		//IL_207f: Expected Obj, but got Unknown
		//IL_20a6: Expected Obj, but got I4
		//IL_20c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_20cb: Expected Obj, but got Unknown
		//IL_0585: Expected Obj, but got I4
		//IL_05ed: Expected Obj, but got I
		//IL_0617: Expected Obj, but got I
		//IL_0641: Expected Obj, but got I
		//IL_065e: Expected Obj, but got I
		//IL_067b: Expected Obj, but got I
		//IL_06b2: Expected Obj, but got I
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected Obj, but got Unknown
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected Obj, but got Unknown
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected Obj, but got Unknown
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Expected Obj, but got Unknown
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Expected Obj, but got Unknown
		//IL_0782: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Expected Obj, but got Unknown
		//IL_2110: Unknown result type (might be due to invalid IL or missing references)
		//IL_2115: Expected Obj, but got Unknown
		//IL_213c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2141: Expected Obj, but got Unknown
		//IL_2168: Expected Obj, but got I4
		//IL_2188: Unknown result type (might be due to invalid IL or missing references)
		//IL_218d: Expected Obj, but got Unknown
		//IL_21ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b0: Expected Obj, but got Unknown
		//IL_21cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d2: Expected Obj, but got Unknown
		//IL_21fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2201: Expected Obj, but got Unknown
		//IL_2273: Expected Obj, but got I4
		//IL_2293: Unknown result type (might be due to invalid IL or missing references)
		//IL_2298: Expected Obj, but got Unknown
		//IL_22b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_22bb: Expected Obj, but got Unknown
		//IL_22cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d0: Expected Obj, but got Unknown
		//IL_2307: Unknown result type (might be due to invalid IL or missing references)
		//IL_230c: Expected Obj, but got Unknown
		//IL_237e: Expected Obj, but got I4
		//IL_239e: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a3: Expected Obj, but got Unknown
		//IL_23c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c6: Expected Obj, but got Unknown
		//IL_23e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e8: Expected Obj, but got Unknown
		//IL_2412: Unknown result type (might be due to invalid IL or missing references)
		//IL_2417: Expected Obj, but got Unknown
		//IL_245b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2460: Expected Obj, but got Unknown
		//IL_2491: Expected Obj, but got I4
		//IL_24b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_24b6: Expected Obj, but got Unknown
		//IL_24ed: Expected Obj, but got I
		//IL_0997: Unknown result type (might be due to invalid IL or missing references)
		//IL_099c: Expected Obj, but got Unknown
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Expected Obj, but got Unknown
		//IL_09ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Expected Obj, but got Unknown
		//IL_0a45: Expected Obj, but got I4
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6a: Expected Obj, but got Unknown
		//IL_0c1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1f: Expected Obj, but got Unknown
		//IL_0c3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c41: Expected Obj, but got Unknown
		//IL_0cb3: Expected Obj, but got I4
		//IL_0cd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd8: Expected Obj, but got Unknown
		//IL_0e66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6b: Expected Obj, but got Unknown
		//IL_0f04: Expected Obj, but got I4
		//IL_0f24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f29: Expected Obj, but got Unknown
		//IL_10a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a9: Expected Obj, but got Unknown
		//IL_10c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cb: Expected Obj, but got Unknown
		//IL_10db: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e0: Expected Obj, but got Unknown
		//IL_1152: Expected Obj, but got I4
		//IL_1172: Unknown result type (might be due to invalid IL or missing references)
		//IL_1177: Expected Obj, but got Unknown
		//IL_0bf8: Expected Obj, but got I
		//IL_12f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f7: Expected Obj, but got Unknown
		//IL_1314: Unknown result type (might be due to invalid IL or missing references)
		//IL_1319: Expected Obj, but got Unknown
		//IL_1329: Unknown result type (might be due to invalid IL or missing references)
		//IL_132e: Expected Obj, but got Unknown
		//IL_13a0: Expected Obj, but got I4
		//IL_13c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c5: Expected Obj, but got Unknown
		//IL_1533: Expected Obj, but got I
		//IL_0ab6: Expected Obj, but got I
		//IL_1555: Unknown result type (might be due to invalid IL or missing references)
		//IL_155a: Expected Obj, but got Unknown
		//IL_1584: Unknown result type (might be due to invalid IL or missing references)
		//IL_1589: Expected Obj, but got Unknown
		//IL_15fb: Expected Obj, but got I4
		//IL_161b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1620: Expected Obj, but got Unknown
		//IL_0d24: Expected Obj, but got I
		//IL_17cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d0: Expected Obj, but got Unknown
		//IL_17ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f2: Expected Obj, but got Unknown
		//IL_1871: Expected Obj, but got I4
		//IL_1891: Unknown result type (might be due to invalid IL or missing references)
		//IL_1896: Expected Obj, but got Unknown
		//IL_0ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aed: Expected Obj, but got Unknown
		//IL_0afd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b02: Expected Obj, but got Unknown
		//IL_0b1f: Expected Obj, but got I
		//IL_0b3c: Expected Obj, but got I
		//IL_0bb0: Expected Obj, but got I
		//IL_2645: Expected Obj, but got I
		//IL_0d56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Expected Obj, but got Unknown
		//IL_0d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d70: Expected Obj, but got Unknown
		//IL_0d8d: Expected Obj, but got I
		//IL_0daa: Expected Obj, but got I
		//IL_0e1e: Expected Obj, but got I
		//IL_2661: Expected Obj, but got Ref
		//IL_2678: Expected VT, but got Ref
		//IL_268a: Expected Obj, but got Ref
		//IL_1a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a26: Expected Obj, but got Unknown
		//IL_1a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3b: Expected Obj, but got Unknown
		//IL_1a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a50: Expected Obj, but got Unknown
		//IL_1ac2: Expected Obj, but got I4
		//IL_1ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae7: Expected Obj, but got Unknown
		//IL_17ae: Expected Obj, but got I
		//IL_0f97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9c: Expected Obj, but got Unknown
		//IL_0fac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb1: Expected Obj, but got Unknown
		//IL_0fce: Expected Obj, but got I
		//IL_0feb: Expected Obj, but got I
		//IL_0be3: Expected Obj, but got I
		//IL_1ecb: Expected VT, but got Ref
		//IL_1c6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c72: Expected Obj, but got Unknown
		//IL_1c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca1: Expected Obj, but got Unknown
		//IL_1d13: Expected Obj, but got I4
		//IL_1d33: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d38: Expected Obj, but got Unknown
		//IL_11e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ea: Expected Obj, but got Unknown
		//IL_11fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ff: Expected Obj, but got Unknown
		//IL_121c: Expected Obj, but got I
		//IL_1239: Expected Obj, but got I
		//IL_0e51: Expected Obj, but got I
		//IL_1433: Unknown result type (might be due to invalid IL or missing references)
		//IL_1438: Expected Obj, but got Unknown
		//IL_1448: Unknown result type (might be due to invalid IL or missing references)
		//IL_144d: Expected Obj, but got Unknown
		//IL_146a: Expected Obj, but got I
		//IL_1487: Expected Obj, but got I
		//IL_1d65: Expected Obj, but got I
		//IL_168e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1693: Expected Obj, but got Unknown
		//IL_16a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a8: Expected Obj, but got Unknown
		//IL_16c5: Expected Obj, but got I
		//IL_16e2: Expected Obj, but got I
		//IL_1756: Expected Obj, but got I
		//IL_1904: Unknown result type (might be due to invalid IL or missing references)
		//IL_1909: Expected Obj, but got Unknown
		//IL_1919: Unknown result type (might be due to invalid IL or missing references)
		//IL_191e: Expected Obj, but got Unknown
		//IL_193b: Expected Obj, but got I
		//IL_1958: Expected Obj, but got I
		//IL_1d94: Expected Obj, but got I
		//IL_1791: Expected Obj, but got I
		//IL_1f69: Expected Obj, but got VT
		//IL_1f79: Expected Obj, but got I
		//IL_1f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8e: Expected Obj, but got Unknown
		//IL_1b65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6a: Expected Obj, but got Unknown
		//IL_1b87: Expected Obj, but got I
		//IL_1ba4: Expected Obj, but got I
		//IL_1bc1: Expected Obj, but got I
		//IL_26b0: Expected Ref, but got VT
		//IL_1db2: Expected Obj, but got I
		//IL_1dc2: Expected Obj, but got I
		//IL_1de6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1deb: Expected Obj, but got Unknown
		//IL_1dfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e00: Expected Obj, but got Unknown
		//IL_1e1d: Expected Obj, but got I
		//IL_1e3a: Expected Obj, but got I
		//IL_1fd3: Unsupported input type for neg.
		//IL_1fd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd8: Expected Obj, but got Unknown
		//IL_1fe5: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		ref Vector3 reference = ref *(Vector3*)null;
		_ = 0;
		_ = 0;
		ref Vector3 reference2 = ref *(Vector3*)null;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref aNarrow, 24));
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref bNarrow, 24));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+1C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+1C]");
		object obj3 = num * 0;
		object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref bNarrow, 36));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+1C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+28]");
		object obj5 = num2 * 0;
		object obj6 = obj * obj2;
		object obj7 = obj * obj4;
		object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref bNarrow, 48));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+20]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+20]");
		object obj9 = num3 * 0;
		object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref aNarrow, 36));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+1C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+34]");
		object obj11 = num4 * 0;
		object obj12 = obj6 + obj3;
		object obj13 = obj * obj8;
		object obj14 = obj7 + obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+20]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+2C]");
		object obj15 = num5 * 0;
		object obj16 = obj13 + obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+20]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+38]");
		object obj17 = num6 * 0;
		object obj18 = obj9 + obj12;
		object obj19 = obj15 + obj14;
		object obj20 = obj17 + obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Vector3 vector = (Vector3)(bNarrow - aNarrow);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		object obj21 = obj14 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		object obj22 = obj15 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+10]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+C]");
		object obj24 = 0;
		object obj25 = obj * vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+1C]");
		object obj27 = default;
		object obj26 = 0 * obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		object obj29 = default;
		object obj28 = obj29 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+8]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+8]");
		object obj30 = num7 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+C]");
		object obj31 = 0 * obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+10]");
		object obj32 = 0 * obj22;
		object obj33 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref aNarrow, 48));
		object obj34 = obj25 + obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+20]");
		object obj35 = 0 * obj30;
		object obj36 = obj31 + obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+14]");
		object obj37 = 0 * obj28;
		object obj38 = obj35 + obj34;
		object obj39 = obj36 + obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+C]");
		object obj40 = 0 + obj39;
		object obj41 = obj40 - obj32;
		bool flag = (nint)obj41 < 0;
		object obj42 = !flag;
		bool flag2 = obj41 == null;
		object obj43 = ~obj42;
		object obj44 = obj43 | flag2;
		bool flag3 = false;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+1C]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+28]");
			object obj45 = num8 * 0;
			object obj46 = obj8 * obj10;
			object obj47 = obj2 * obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+28]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+28]");
			object obj48 = num9 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+34]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+28]");
			object obj49 = num10 * 0;
			object obj50 = obj4 * obj10;
			object obj51 = obj47 + obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+20]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+2C]");
			object obj52 = num11 * 0;
			object obj53 = obj46 + obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+38]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+2C]");
			object obj54 = num12 * 0;
			object obj55 = obj50 + obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+2C]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+2C]");
			object obj56 = num13 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+2C]");
			object obj57 = 0 * obj30;
			object obj58 = obj52 + obj51;
			object obj59 = obj54 + obj53;
			object obj60 = obj56 + obj55;
			object obj61 = obj10 * vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+28]");
			object obj62 = 0 * obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			object obj63 = obj61 + obj62;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			object obj64 = obj58 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			object obj65 = vector + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			object obj66 = obj62 + 0;
			object obj67 = obj57 + obj63;
			object obj68;
			if ((nint)obj41 < 2139095039)
			{
				bool flag4 = !detailedManifold;
				obj68 = 2139095039;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X11_v2+8]");
					_ = 0;
					reference2 = ref *(Vector3*)obj;
					obj68 = obj41;
				}
			}
			else
			{
				obj68 = 2139095039;
			}
			object obj69 = obj24 * obj64;
			object obj70 = obj23 * obj65;
			object obj71 = obj69 + obj70;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+14]");
			object obj72 = 0 * obj66;
			object obj73 = obj72 + obj71;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
			object obj74 = 0 + obj73;
			object obj75 = obj74 - obj72;
			bool flag5 = (nint)obj75 < 0;
			object obj76 = !flag5;
			bool flag6 = obj75 == null;
			object obj77 = ~obj76;
			object obj78 = obj77 | flag6;
			if (obj78 == null)
			{
				object obj79 = obj2 * obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+1C]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+34]");
				object obj80 = num14 * 0;
				object obj81 = obj4 * obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+28]");
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+34]");
				object obj82 = num15 * 0;
				object obj83 = obj8 * obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+34]");
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+34]");
				object obj84 = num16 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+2C]");
				nint num17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+38]");
				object obj85 = num17 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+20]");
				nint num18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+38]");
				object obj86 = num18 * 0;
				object obj87 = obj79 + obj80;
				object obj88 = obj81 + obj82;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+38]");
				nint num19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+38]");
				object obj89 = num19 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+38]");
				object obj90 = 0 * obj30;
				object obj91 = obj83 + obj84;
				object obj92 = obj86 + obj87;
				object obj93 = obj85 + obj88;
				object obj94 = obj89 + obj91;
				object obj95 = obj33 * vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+34]");
				object obj97 = default;
				object obj96 = 0 * obj97;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				object obj98 = obj95 + obj96;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				object obj99 = obj89 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				object obj100 = obj91 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				object obj101 = obj96 + 0;
				object obj102 = obj90 + obj98;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj75) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68) && detailedManifold)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X13_v2+8]");
					_ = 0;
					reference2 = ref *(Vector3*)obj10;
					obj68 = obj75;
				}
				object obj103 = obj24 * obj99;
				object obj104 = obj23 * obj100;
				object obj105 = obj103 + obj104;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+14]");
				object obj106 = 0 * obj101;
				object obj107 = obj106 + obj105;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+14]");
				object obj108 = 0 + obj107;
				object obj109 = obj108 - obj106;
				bool flag7 = (nint)obj109 < 0;
				object obj110 = !flag7;
				bool flag8 = obj109 == null;
				object obj111 = ~obj110;
				object obj112 = obj111 | flag8;
				if (obj112 == null)
				{
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj109) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68) && detailedManifold)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X12_v3+8]");
						_ = 0;
						reference2 = ref *(Vector3*)obj33;
						obj68 = obj109;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
					object obj113 = 0 * obj64;
					object obj114 = obj18 * obj38;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+C]");
					object obj115 = 0 * obj21;
					object obj116 = obj58 * obj67;
					object obj117 = obj115 + obj113;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+14]");
					object obj118 = 0 * obj99;
					object obj119 = obj114 + obj116;
					object obj120 = obj92 * obj102;
					object obj121 = obj117 + obj118;
					object obj122 = obj120 + obj119;
					object obj123 = obj24 + obj121;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					object obj124 = obj123 - obj122;
					bool flag9 = (nint)obj124 < 0;
					object obj125 = !flag9;
					bool flag10 = obj124 == null;
					object obj126 = ~obj125;
					object obj127 = obj126 | flag10;
					if (obj127 == null)
					{
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj124) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68) && detailedManifold)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X10_v2+8]");
							_ = 0;
							reference2 = ref *(Vector3*)obj2;
							obj68 = obj124;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
						object obj128 = 0 * obj65;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+C]");
						object obj129 = 0 * obj22;
						object obj130 = obj19 * obj38;
						object obj131 = obj60 * obj67;
						object obj132 = obj129 + obj128;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+14]");
						object obj133 = 0 * obj100;
						object obj134 = obj130 + obj131;
						object obj135 = obj93 * obj102;
						object obj136 = obj132 + obj133;
						object obj137 = obj135 + obj134;
						object obj138 = obj23 + obj136;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
						object obj139 = obj138 - obj137;
						bool flag11 = (nint)obj139 < 0;
						object obj140 = !flag11;
						bool flag12 = obj139 == null;
						object obj141 = ~obj140;
						object obj142 = obj141 | flag12;
						if (obj142 == null)
						{
							object obj143;
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj139) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68))
							{
								bool flag13 = !detailedManifold;
								obj143 = obj66;
								if (!flag13)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v2+8]");
									_ = 0;
									reference2 = ref *(Vector3*)obj4;
									obj143 = obj66;
									obj68 = obj139;
								}
							}
							else
							{
								obj143 = obj66;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
							object obj144 = 0 * obj143;
							object obj145 = obj20 * obj38;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+C]");
							object obj146 = 0 * obj28;
							object obj147 = obj59 * obj67;
							object obj148 = obj146 + obj144;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+14]");
							object obj149 = 0 * obj101;
							object obj150 = obj145 + obj147;
							object obj151 = obj94 * obj102;
							object obj152 = obj148 + obj149;
							object obj153 = obj151 + obj150;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+14]");
							object obj154 = 0 + obj152;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							object obj155 = obj154 - obj153;
							bool flag14 = (nint)obj155 < 0;
							object obj156 = !flag14;
							bool flag15 = obj155 == null;
							object obj157 = ~obj156;
							object obj158 = obj157 | flag15;
							if (obj158 == null)
							{
								if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj155) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68) && detailedManifold)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v2+8]");
									_ = 0;
									reference2 = ref *(Vector3*)obj8;
									obj68 = obj155;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACA8]");
								bool flag16 = (nint)obj21 >= 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
								object obj159 = 0;
								if (!flag16)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
									object obj160 = 0 * obj99;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+14]");
									object obj161 = 0 * obj64;
									object obj162 = obj23 * obj28;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+14]");
									object obj163 = 0 * obj22;
									object obj164 = obj161 + obj160;
									obj153 = obj163 + obj162;
									object obj165 = obj58 * obj102;
									object obj166 = obj92 * obj67;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
									object obj167 = obj153 + obj164;
									object obj168 = obj167 - obj165;
									bool flag17 = (nint)obj168 < 0;
									object obj169 = !flag17;
									bool flag18 = obj168 == null;
									object obj170 = ~obj169;
									object obj171 = obj170 | flag18;
									if (obj171 != null)
									{
										goto IL_1fef;
									}
									if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj168) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68))
									{
										bool flag19 = !detailedManifold;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
										obj159 = 0;
										if (!flag19)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+1C]");
											object obj172 = 0 * obj165;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+1C]");
											object obj173 = obj166 * 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+18]");
											nint num20 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+1C]");
											object obj174 = num20 * 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+18]");
											nint num21 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+1C]");
											object obj175 = num21 * 0;
											object obj176 = obj172 - obj173;
											object obj177 = obj174 - obj175;
											object obj178 = obj176 * obj176;
											obj153 = obj177 * obj177;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
											object obj179 = obj153 + obj178;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
											bool flag20 = (nint)obj179 <= 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
											obj159 = 0;
											if (!flag20)
											{
												reference2 = ref *(Vector3*)obj176;
												obj68 = obj168;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
												obj159 = 0;
											}
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
										obj159 = 0;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACA8]");
								if ((nint)obj22 < 0)
								{
									object obj180 = obj159 * obj100;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+14]");
									object obj181 = 0 * obj65;
									object obj182 = obj24 * obj28;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+14]");
									object obj183 = 0 * obj21;
									object obj184 = obj181 + obj180;
									obj153 = obj183 + obj182;
									object obj185 = obj60 * obj102;
									object obj186 = obj93 * obj67;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
									object obj187 = obj153 + obj184;
									object obj188 = obj187 - obj185;
									bool flag21 = (nint)obj188 < 0;
									object obj189 = !flag21;
									bool flag22 = obj188 == null;
									object obj190 = ~obj189;
									object obj191 = obj190 | flag22;
									if (obj191 != null)
									{
										goto IL_1fef;
									}
									if (detailedManifold)
									{
										bool flag23 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj188) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
										obj159 = 0;
										if (!flag23)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+1C]");
											object obj192 = 0 * obj66;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+28]");
											object obj193 = obj186 * 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+18]");
											nint num22 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+28]");
											object obj194 = num22 * 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+24]");
											nint num23 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+1C]");
											object obj195 = num23 * 0;
											object obj196 = obj192 - obj193;
											object obj197 = obj194 - obj195;
											object obj198 = obj196 * obj196;
											obj153 = obj197 * obj197;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
											object obj199 = obj153 + obj198;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
											bool flag24 = (nint)obj199 <= 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
											obj159 = 0;
											if (!flag24)
											{
												reference2 = ref *(Vector3*)obj196;
												obj68 = obj188;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
												obj159 = 0;
											}
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
										obj159 = 0;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACA8]");
								bool flag25 = (nint)obj28 >= 0;
								object obj200 = obj28;
								object obj201 = obj66;
								if (!flag25)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+14]");
									object obj202 = 0 * obj66;
									object obj203 = obj159 * obj101;
									object obj204 = obj24 * obj22;
									object obj205 = obj23 * obj21;
									object obj206 = obj202 + obj203;
									obj153 = obj205 + obj204;
									object obj207 = obj94 * obj67;
									object obj208 = obj59 * obj102;
									obj200 = obj153 + obj206;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
									object obj209 = obj200 - obj208;
									bool flag26 = (nint)obj209 < 0;
									object obj210 = !flag26;
									bool flag27 = obj209 == null;
									object obj211 = ~obj210;
									object obj212 = obj211 | flag27;
									if (obj212 != null)
									{
										goto IL_1fef;
									}
									if (detailedManifold && System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj209) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68))
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+1C]");
										object obj213 = 0 * obj208;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+34]");
										object obj214 = obj207 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+18]");
										nint num24 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+34]");
										object obj215 = num24 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+30]");
										nint num25 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+1C]");
										object obj216 = num25 * 0;
										object obj217 = obj213 - obj214;
										object obj218 = obj215 - obj216;
										object obj219 = obj217 * obj217;
										obj153 = obj218 * obj218;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
										obj200 = obj153 + obj219;
										object obj220 = obj200;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
										bool flag28 = (nint)obj220 <= 0;
										obj201 = obj66;
										if (!flag28)
										{
											reference2 = ref *(Vector3*)obj217;
											obj68 = obj209;
											obj201 = obj66;
										}
									}
									else
									{
										obj201 = obj66;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACA8]");
								if ((nint)obj64 < 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+C]");
									object obj221 = 0 * obj99;
									object obj222 = obj23 * obj201;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+14]");
									object obj223 = 0 * obj65;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+14]");
									object obj224 = 0 * obj21;
									object obj225 = obj224 + obj221;
									obj153 = obj222 + obj223;
									object obj226 = obj92 * obj38;
									object obj227 = obj18 * obj102;
									obj200 = obj153 + obj225;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
									object obj228 = obj200 - obj226;
									bool flag29 = (nint)obj228 < 0;
									object obj229 = !flag29;
									bool flag30 = obj228 == null;
									object obj230 = ~obj229;
									object obj231 = obj230 | flag30;
									if (obj231 != null)
									{
										goto IL_1fef;
									}
									if (detailedManifold && System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj228) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68))
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+28]");
										object obj232 = 0 * obj226;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+1C]");
										object obj233 = obj227 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+24]");
										nint num26 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+1C]");
										object obj234 = num26 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+18]");
										nint num27 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+28]");
										object obj235 = num27 * 0;
										object obj236 = obj232 - obj233;
										object obj237 = obj234 - obj235;
										object obj238 = obj236 * obj236;
										obj153 = obj237 * obj237;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
										obj200 = obj153 + obj238;
										object obj239 = obj200;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
										bool flag31 = (nint)obj239 <= 0;
										obj201 = obj66;
										if (!flag31)
										{
											reference2 = ref *(Vector3*)obj236;
											obj68 = obj228;
											obj201 = obj66;
										}
									}
									else
									{
										obj201 = obj66;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACA8]");
								if ((nint)obj65 < 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+C]");
									object obj240 = 0 * obj100;
									object obj241 = obj24 * obj201;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+14]");
									object obj242 = 0 * obj64;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+14]");
									object obj243 = 0 * obj22;
									object obj244 = obj243 + obj240;
									obj153 = obj241 + obj242;
									object obj245 = obj93 * obj38;
									object obj246 = obj19 * obj102;
									obj200 = obj153 + obj244;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
									object obj247 = obj200 - obj245;
									bool flag32 = (nint)obj247 < 0;
									object obj248 = !flag32;
									bool flag33 = obj247 == null;
									object obj249 = ~obj248;
									object obj250 = obj249 | flag33;
									if (obj250 != null)
									{
										goto IL_1fef;
									}
									if (detailedManifold && System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj247) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68))
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+28]");
										object obj251 = 0 * obj245;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+28]");
										object obj252 = obj246 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+24]");
										nint num28 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+28]");
										object obj253 = num28 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+24]");
										nint num29 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+28]");
										object obj254 = num29 * 0;
										object obj255 = obj251 - obj252;
										object obj256 = obj253 - obj254;
										object obj257 = obj255 * obj255;
										obj153 = obj256 * obj256;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
										obj200 = obj153 + obj257;
										object obj258 = obj200;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
										bool flag34 = (nint)obj258 <= 0;
										obj201 = obj66;
										if (!flag34)
										{
											reference2 = ref *(Vector3*)obj255;
											obj68 = obj247;
											obj201 = obj66;
										}
									}
									else
									{
										obj201 = obj66;
									}
								}
								object obj259 = obj201;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACA8]");
								if ((nint)obj259 < 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+C]");
									object obj260 = 0 * obj101;
									object obj261 = obj24 * obj65;
									object obj262 = obj23 * obj64;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+14]");
									object obj263 = 0 * obj28;
									object obj264 = obj263 + obj260;
									obj153 = obj261 + obj262;
									object obj265 = obj94 * obj38;
									object obj266 = obj20 * obj102;
									obj200 = obj153 + obj264;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
									object obj267 = obj200 - obj265;
									bool flag35 = (nint)obj267 < 0;
									object obj268 = !flag35;
									bool flag36 = obj267 == null;
									object obj269 = ~obj268;
									object obj270 = obj269 | flag36;
									if (obj270 != null)
									{
										goto IL_1fef;
									}
									if (detailedManifold && System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj267) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68))
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+28]");
										object obj271 = 0 * obj265;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+34]");
										object obj272 = obj266 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+24]");
										nint num30 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+34]");
										object obj273 = num30 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+30]");
										nint num31 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+28]");
										object obj274 = num31 * 0;
										object obj275 = obj271 - obj272;
										object obj276 = obj273 - obj274;
										object obj277 = obj275 * obj275;
										obj153 = obj276 * obj276;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
										obj200 = obj153 + obj277;
										object obj278 = obj200;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
										bool flag37 = (nint)obj278 <= 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
										obj159 = 0;
										obj201 = obj66;
										if (!flag37)
										{
											reference2 = ref *(Vector3*)obj275;
											obj68 = obj267;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
											obj159 = 0;
											obj201 = obj66;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
										obj159 = 0;
										obj201 = obj66;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACA8]");
								object obj298;
								if ((nint)obj99 < 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+C]");
									object obj279 = 0 * obj64;
									object obj280 = obj23 * obj101;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+14]");
									object obj281 = 0 * obj100;
									object obj282 = obj159 * obj21;
									object obj283 = obj282 + obj279;
									obj153 = obj280 + obj281;
									object obj284 = obj18 * obj67;
									object obj285 = obj58 * obj38;
									obj200 = obj283 + obj153;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
									object obj286 = obj200 - obj284;
									bool flag38 = (nint)obj286 < 0;
									object obj287 = !flag38;
									bool flag39 = obj286 == null;
									object obj288 = ~obj287;
									object obj289 = obj288 | flag39;
									if (obj289 != null)
									{
										goto IL_1fef;
									}
									if (detailedManifold && System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj286) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68))
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+34]");
										object obj290 = 0 * obj284;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+1C]");
										object obj291 = obj285 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+30]");
										nint num32 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+1C]");
										object obj292 = num32 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+18]");
										nint num33 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+34]");
										object obj293 = num33 * 0;
										object obj294 = obj290 - obj291;
										object obj295 = obj292 - obj293;
										object obj296 = obj294 * obj294;
										obj153 = obj295 * obj295;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
										obj200 = obj153 + obj296;
										object obj297 = obj200;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
										bool flag40 = (nint)obj297 <= 0;
										obj298 = obj28;
										obj201 = obj66;
										if (!flag40)
										{
											reference2 = ref *(Vector3*)obj294;
											obj68 = obj286;
											obj298 = obj28;
											obj201 = obj66;
										}
									}
									else
									{
										obj298 = obj28;
										obj201 = obj66;
									}
								}
								else
								{
									obj298 = obj28;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACA8]");
								if ((nint)obj100 < 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+C]");
									object obj299 = 0 * obj65;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+14]");
									object obj300 = 0 * obj99;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
									object obj301 = 0 * obj22;
									object obj302 = obj24 * obj101;
									object obj303 = obj301 + obj299;
									obj153 = obj302 + obj300;
									object obj304 = obj19 * obj67;
									obj200 = obj303 + obj153;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
									object obj305 = obj200 - obj304;
									bool flag41 = (nint)obj305 < 0;
									object obj306 = !flag41;
									bool flag42 = obj305 == null;
									object obj307 = ~obj306;
									object obj308 = obj307 | flag42;
									if (obj308 != null)
									{
										goto IL_1fef;
									}
									bool flag43 = !detailedManifold;
									obj201 = obj66;
									if (!flag43)
									{
										bool flag44 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj305) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68);
										obj201 = obj66;
										if (!flag44)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+34]");
											object obj309 = 0 * obj66;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+14]");
											nint num34 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+28]");
											object obj310 = num34 * 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+30]");
											nint num35 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+28]");
											object obj311 = num35 * 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+24]");
											nint num36 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+34]");
											object obj312 = num36 * 0;
											object obj313 = obj309 - obj310;
											object obj314 = obj311 - obj312;
											object obj315 = obj313 * obj313;
											obj153 = obj314 * obj314;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
											obj200 = obj153 + obj315;
											object obj316 = obj200;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
											bool flag45 = (nint)obj316 <= 0;
											obj201 = obj66;
											if (!flag45)
											{
												reference2 = ref *(Vector3*)obj313;
												obj68 = obj305;
												obj201 = obj66;
											}
										}
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACA8]");
								bool flag46 = (nint)obj101 >= 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+C]");
								object obj317 = 0;
								if (!flag46)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+C]");
									object obj318 = 0 * obj201;
									object obj319 = obj24 * obj100;
									object obj320 = obj23 * obj99;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+10]");
									object obj321 = 0 * obj298;
									obj23 = obj319 + obj320;
									object obj322 = obj321 + obj318;
									obj24 = obj20 * obj67;
									obj153 = obj59 * obj38;
									object obj323 = obj322 + obj23;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
									obj200 = obj323 - obj24;
									bool flag47 = (nint)obj200 < 0;
									object obj324 = !flag47;
									bool flag48 = obj200 == null;
									object obj325 = ~obj324;
									object obj326 = obj325 | flag48;
									if (obj326 != null)
									{
										goto IL_1fef;
									}
									bool flag49 = !detailedManifold;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+C]");
									obj317 = 0;
									if (!flag49)
									{
										bool flag50 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj200) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+C]");
										obj317 = 0;
										if (!flag50)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+30]");
											obj298 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+30]");
											obj317 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+34]");
											object obj327 = 0 * obj200;
											object obj328 = obj153;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+34]");
											object obj329 = obj328 * 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+30]");
											nint num37 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+34]");
											object obj330 = num37 * 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bNarrow @ X1 (BoxNarrowData&)+30]");
											nint num38 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aNarrow @ X0 (BoxNarrowData&)+34]");
											object obj331 = num38 * 0;
											obj200 = obj327 - obj329;
											obj23 = obj330 - obj331;
											object obj332 = obj200 * obj200;
											obj153 = obj23 * obj23;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
											obj24 = obj153 + obj332;
											object obj333 = obj24;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
											if ((nint)obj333 > 0)
											{
												reference2 = ref *(Vector3*)obj200;
											}
										}
									}
								}
								object obj334 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref bNarrow, 60));
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
								object obj335 = default;
								Vector3 translation = default;
								CustomPlanesBox planesBox = GetPlanesBox((CustomPlanesBox)(&obj335), ref translation);
								object obj336 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref bNarrow, 204));
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
								object obj337 = default;
								CustomEdgesBox edgesBox = GetEdgesBox((CustomEdgesBox)(&obj337), ref translation);
								CustomPlanesBox planesB = default;
								CustomEdgesBox edgesB = default;
								flag3 = GetHitPoint(ref System.Runtime.CompilerServices.Unsafe.As<BoxNarrowData, CustomPlanesBox>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref aNarrow, 60)), ref planesB, ref System.Runtime.CompilerServices.Unsafe.As<BoxNarrowData, CustomEdgesBox>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref aNarrow, 204)), ref edgesB, ref aNarrow, ref bNarrow, ref translation, detailedManifold, out hitPoint);
								if (flag3 && detailedManifold)
								{
									object obj338 = vector * normal;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [normal @ X4 (UnityEngine.Vector3&)+8]");
									object obj339 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [normal @ X4 (UnityEngine.Vector3&)+8]");
									object obj340 = obj30 * 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
									object obj341 = obj340 + obj338;
									if ((nint)obj341 < 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
										obj339 = 0 - obj339;
										reference2 = ref *(Vector3*)normal;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
									reference2 = ref *(Vector3*)normal;
									flag3 = true;
								}
								goto IL_2012;
							}
						}
					}
				}
			}
			goto IL_1fef;
		}
		goto IL_2012;
		IL_1fef:
		flag3 = false;
		goto IL_2012;
		IL_2012:
		return flag3;
	}

	private unsafe static CustomEdgesBox GetEdgesBox(CustomEdgesBox edges, ref Vector3 translation)
	{
		//IL_0034: Expected Obj, but got I
		//IL_003c: Expected native int or pointer, but got VT
		//IL_007a: Expected Obj, but got I
		//IL_0082: Expected native int or pointer, but got VT
		//IL_00c0: Expected Obj, but got I
		//IL_00c8: Expected native int or pointer, but got VT
		//IL_0106: Expected Obj, but got I
		//IL_010e: Expected native int or pointer, but got VT
		//IL_014c: Expected Obj, but got I
		//IL_0154: Expected native int or pointer, but got VT
		//IL_0192: Expected Obj, but got I
		//IL_019a: Expected native int or pointer, but got VT
		//IL_01d8: Expected Obj, but got I
		//IL_01e0: Expected native int or pointer, but got VT
		//IL_021e: Expected Obj, but got I
		//IL_0226: Expected native int or pointer, but got VT
		Vector3 p = edges.P0 + translation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [edges @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [translation @ X1 (UnityEngine.Vector3&)+8]");
		object obj = num + 0;
		((CustomEdgesBox*)(nint)edges)->P0 = p;
		Vector3 p2 = edges.P1 + translation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [edges @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+14]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [translation @ X1 (UnityEngine.Vector3&)+8]");
		object obj2 = num2 + 0;
		((CustomEdgesBox*)(nint)edges)->P1 = p2;
		Vector3 p3 = edges.P2 + translation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [edges @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+20]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [translation @ X1 (UnityEngine.Vector3&)+8]");
		object obj3 = num3 + 0;
		((CustomEdgesBox*)(nint)edges)->P2 = p3;
		Vector3 p4 = edges.P3 + translation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [edges @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+2C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [translation @ X1 (UnityEngine.Vector3&)+8]");
		object obj4 = num4 + 0;
		((CustomEdgesBox*)(nint)edges)->P3 = p4;
		Vector3 p5 = edges.P4 + translation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [edges @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+38]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [translation @ X1 (UnityEngine.Vector3&)+8]");
		object obj5 = num5 + 0;
		((CustomEdgesBox*)(nint)edges)->P4 = p5;
		Vector3 p6 = edges.P5 + translation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [edges @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+44]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [translation @ X1 (UnityEngine.Vector3&)+8]");
		object obj6 = num6 + 0;
		((CustomEdgesBox*)(nint)edges)->P5 = p6;
		Vector3 p7 = edges.P6 + translation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [edges @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+50]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [translation @ X1 (UnityEngine.Vector3&)+8]");
		object obj7 = num7 + 0;
		((CustomEdgesBox*)(nint)edges)->P6 = p7;
		Vector3 p8 = edges.P7 + translation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [edges @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomEdgesBox)+5C]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [translation @ X1 (UnityEngine.Vector3&)+8]");
		object obj8 = num8 + 0;
		((CustomEdgesBox*)(nint)edges)->P7 = p8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		CustomEdgesBox result = default;
		return result;
	}

	private static CustomPlanesBox GetPlanesBox(CustomPlanesBox planes, ref Vector3 translation)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0037: Expected Obj, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_013b: Expected Obj, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_017c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [planes @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomPlanesBox)+C]");
		object obj = 0 + translation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [planes @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomPlanesBox)+14]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [translation @ X1 (UnityEngine.Vector3&)+8]");
		object obj2 = num + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [planes @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomPlanesBox)+3C]");
		object obj3 = 0 + translation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [planes @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomPlanesBox)+44]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [translation @ X1 (UnityEngine.Vector3&)+8]");
		object obj4 = num2 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [planes @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomPlanesBox)+6C]");
		object obj5 = 0 + translation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [planes @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomPlanesBox)+74]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [translation @ X1 (UnityEngine.Vector3&)+8]");
		object obj6 = num3 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [planes @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomPlanesBox)+24]");
		object obj7 = 0 + translation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [planes @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomPlanesBox)+2C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [translation @ X1 (UnityEngine.Vector3&)+8]");
		object obj8 = num4 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [planes @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomPlanesBox)+54]");
		object obj9 = 0 + translation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [planes @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomPlanesBox)+5C]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [translation @ X1 (UnityEngine.Vector3&)+8]");
		object obj10 = num5 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [planes @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomPlanesBox)+84]");
		object obj11 = 0 + translation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [planes @ X0 (Fusion.LagCompensation.LagCompensationUtils+CustomPlanesBox)+8C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [translation @ X1 (UnityEngine.Vector3&)+8]");
		object obj12 = num6 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		CustomPlanesBox result = default;
		return result;
	}

	private unsafe static bool GetHitPoint(ref CustomPlanesBox planesA, ref CustomPlanesBox planesB, ref CustomEdgesBox edgesA, ref CustomEdgesBox edgesB, ref BoxNarrowData boxNarrowA, ref BoxNarrowData boxNarrowB, ref Vector3 boxAToBoxBOffset, bool computeDetailedInfo, out Vector3 contactPoint)
	{
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_0153: Expected Obj, but got VT
		//IL_0170: Expected Obj, but got I
		//IL_01ce: Expected Ref, but got VT
		ref Vector3 reference = ref *(Vector3*)null;
		_ = 0;
		Vector3 offset = default;
		int cpCount = default;
		GetContactPointPlaneEdge(ref planesA, ref edgesB, ref boxNarrowA, ref offset, ref System.Runtime.CompilerServices.Unsafe.As<BoxNarrowData, Vector3>(ref boxNarrowA), computeDetailedInfo, ref cpCount, ref contactPoint);
		int num = 0;
		if (num >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj2 = default;
			object obj = contactPoint / obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ stack_0 (UnityEngine.Vector3&)+8]");
			int num2 = (int)((nint)0 / (nint)num);
			reference = ref *(Vector3*)obj;
		}
		else if (BoxInAABB(ref edgesB, ref boxNarrowA, ref offset))
		{
			object obj3 = boxAToBoxBOffset + boxNarrowA;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAToBoxBOffset @ X6 (UnityEngine.Vector3&)+8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxNarrowA @ X4 (BoxNarrowData&)+8]");
			object obj4 = num3 + 0;
			reference = ref *(Vector3*)obj3;
		}
		else
		{
			if (!BoxInAABB(ref edgesA, ref boxNarrowB, ref boxAToBoxBOffset))
			{
				return false;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxNarrowA @ X4 (BoxNarrowData&)+8]");
			_ = 0;
			reference = ref *(Vector3*)boxNarrowA;
		}
		return true;
	}

	private unsafe static void GetContactPointPlaneEdge(ref CustomPlanesBox planes, ref CustomEdgesBox edges, ref BoxNarrowData boxNarrow, ref Vector3 offset, ref Vector3 boxAPosition, bool detailedManifold, ref int cpCount, ref Vector3 contactPoint)
	{
		//IL_0064: Expected VT, but got Ref
		//IL_0182: Expected VT, but got Ref
		//IL_02ad: Expected VT, but got Ref
		//IL_009c: Expected Obj, but got VT
		//IL_00b9: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I4
		//IL_03ca: Expected VT, but got Ref
		//IL_01b5: Expected Obj, but got VT
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I
		//IL_0204: Expected Obj, but got I4
		//IL_04f5: Expected VT, but got Ref
		//IL_02e0: Expected Obj, but got VT
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_030f: Expected Obj, but got I
		//IL_032f: Expected Obj, but got I4
		//IL_0620: Expected VT, but got Ref
		//IL_03fd: Expected Obj, but got VT
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected Obj, but got Unknown
		//IL_042c: Expected Obj, but got I
		//IL_044c: Expected Obj, but got I4
		//IL_074b: Expected VT, but got Ref
		//IL_0528: Expected Obj, but got VT
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected Obj, but got Unknown
		//IL_0557: Expected Obj, but got I
		//IL_0577: Expected Obj, but got I4
		//IL_0876: Expected VT, but got Ref
		//IL_0653: Expected Obj, but got VT
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected Obj, but got Unknown
		//IL_0682: Expected Obj, but got I
		//IL_06a2: Expected Obj, but got I4
		//IL_0993: Expected VT, but got Ref
		//IL_077e: Expected Obj, but got VT
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Expected Obj, but got Unknown
		//IL_07ad: Expected Obj, but got I
		//IL_07cd: Expected Obj, but got I4
		//IL_0abe: Expected VT, but got Ref
		//IL_08a9: Expected Obj, but got VT
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Expected Obj, but got Unknown
		//IL_08d8: Expected Obj, but got I
		//IL_08f8: Expected Obj, but got I4
		//IL_0be9: Expected VT, but got Ref
		//IL_09c6: Expected Obj, but got VT
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Expected Obj, but got Unknown
		//IL_09f5: Expected Obj, but got I
		//IL_0a15: Expected Obj, but got I4
		//IL_0d14: Expected VT, but got Ref
		//IL_0af1: Expected Obj, but got VT
		//IL_0afe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b03: Expected Obj, but got Unknown
		//IL_0b20: Expected Obj, but got I
		//IL_0b40: Expected Obj, but got I4
		//IL_0e3f: Expected VT, but got Ref
		//IL_0c1c: Expected Obj, but got VT
		//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2e: Expected Obj, but got Unknown
		//IL_0c4b: Expected Obj, but got I
		//IL_0c6b: Expected Obj, but got I4
		//IL_0f78: Expected VT, but got Ref
		//IL_0d47: Expected Obj, but got VT
		//IL_0d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d59: Expected Obj, but got Unknown
		//IL_0d76: Expected Obj, but got I
		//IL_0d96: Expected Obj, but got I4
		//IL_10b1: Expected VT, but got Ref
		//IL_0e72: Expected Obj, but got VT
		//IL_0e7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e84: Expected Obj, but got Unknown
		//IL_0ea1: Expected Obj, but got I
		//IL_0ec1: Expected Obj, but got I4
		//IL_11dc: Expected VT, but got Ref
		//IL_0fab: Expected Obj, but got VT
		//IL_0fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbd: Expected Obj, but got Unknown
		//IL_0fda: Expected Obj, but got I
		//IL_0ffa: Expected Obj, but got I4
		//IL_1315: Expected VT, but got Ref
		//IL_10e4: Expected Obj, but got VT
		//IL_10f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f6: Expected Obj, but got Unknown
		//IL_1113: Expected Obj, but got I
		//IL_1133: Expected Obj, but got I4
		//IL_144e: Expected VT, but got Ref
		//IL_120f: Expected Obj, but got VT
		//IL_121c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1221: Expected Obj, but got Unknown
		//IL_123e: Expected Obj, but got I
		//IL_125e: Expected Obj, but got I4
		//IL_1587: Expected VT, but got Ref
		//IL_1348: Expected Obj, but got VT
		//IL_1355: Unknown result type (might be due to invalid IL or missing references)
		//IL_135a: Expected Obj, but got Unknown
		//IL_1377: Expected Obj, but got I
		//IL_1397: Expected Obj, but got I4
		//IL_16c0: Expected VT, but got Ref
		//IL_1481: Expected Obj, but got VT
		//IL_148e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1493: Expected Obj, but got Unknown
		//IL_14b0: Expected Obj, but got I
		//IL_14d0: Expected Obj, but got I4
		//IL_17eb: Expected VT, but got Ref
		//IL_15ba: Expected Obj, but got VT
		//IL_15c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cc: Expected Obj, but got Unknown
		//IL_15e9: Expected Obj, but got I
		//IL_1609: Expected Obj, but got I4
		//IL_1924: Expected VT, but got Ref
		//IL_16f3: Expected Obj, but got VT
		//IL_1700: Unknown result type (might be due to invalid IL or missing references)
		//IL_1705: Expected Obj, but got Unknown
		//IL_1722: Expected Obj, but got I
		//IL_1742: Expected Obj, but got I4
		//IL_1a5d: Expected VT, but got Ref
		//IL_181e: Expected Obj, but got VT
		//IL_182b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1830: Expected Obj, but got Unknown
		//IL_184d: Expected Obj, but got I
		//IL_186d: Expected Obj, but got I4
		//IL_1b96: Expected VT, but got Ref
		//IL_1957: Expected Obj, but got VT
		//IL_1964: Unknown result type (might be due to invalid IL or missing references)
		//IL_1969: Expected Obj, but got Unknown
		//IL_1986: Expected Obj, but got I
		//IL_19a6: Expected Obj, but got I4
		//IL_1cc1: Expected VT, but got Ref
		//IL_1a90: Expected Obj, but got VT
		//IL_1a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa2: Expected Obj, but got Unknown
		//IL_1abf: Expected Obj, but got I
		//IL_1adf: Expected Obj, but got I4
		//IL_1dfa: Expected VT, but got Ref
		//IL_1bc9: Expected Obj, but got VT
		//IL_1bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bdb: Expected Obj, but got Unknown
		//IL_1bf8: Expected Obj, but got I
		//IL_1c18: Expected Obj, but got I4
		//IL_1f33: Expected VT, but got Ref
		//IL_1cf4: Expected Obj, but got VT
		//IL_1d01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d06: Expected Obj, but got Unknown
		//IL_1d23: Expected Obj, but got I
		//IL_1d43: Expected Obj, but got I4
		//IL_205e: Expected VT, but got Ref
		//IL_1e2d: Expected Obj, but got VT
		//IL_1e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3f: Expected Obj, but got Unknown
		//IL_1e5c: Expected Obj, but got I
		//IL_1e7c: Expected Obj, but got I4
		//IL_2197: Expected VT, but got Ref
		//IL_1f66: Expected Obj, but got VT
		//IL_1f73: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f78: Expected Obj, but got Unknown
		//IL_1f95: Expected Obj, but got I
		//IL_1fb5: Expected Obj, but got I4
		//IL_22d0: Expected VT, but got Ref
		//IL_2091: Expected Obj, but got VT
		//IL_209e: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a3: Expected Obj, but got Unknown
		//IL_20c0: Expected Obj, but got I
		//IL_20e0: Expected Obj, but got I4
		//IL_2409: Expected VT, but got Ref
		//IL_21ca: Expected Obj, but got VT
		//IL_21d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_21dc: Expected Obj, but got Unknown
		//IL_21f9: Expected Obj, but got I
		//IL_2219: Expected Obj, but got I4
		//IL_2542: Expected VT, but got Ref
		//IL_2303: Expected Obj, but got VT
		//IL_2310: Unknown result type (might be due to invalid IL or missing references)
		//IL_2315: Expected Obj, but got Unknown
		//IL_2332: Expected Obj, but got I
		//IL_2352: Expected Obj, but got I4
		//IL_266d: Expected VT, but got Ref
		//IL_243c: Expected Obj, but got VT
		//IL_2449: Unknown result type (might be due to invalid IL or missing references)
		//IL_244e: Expected Obj, but got Unknown
		//IL_246b: Expected Obj, but got I
		//IL_248b: Expected Obj, but got I4
		//IL_27a6: Expected VT, but got Ref
		//IL_2575: Expected Obj, but got VT
		//IL_2582: Unknown result type (might be due to invalid IL or missing references)
		//IL_2587: Expected Obj, but got Unknown
		//IL_25a4: Expected Obj, but got I
		//IL_25c4: Expected Obj, but got I4
		//IL_28df: Expected VT, but got Ref
		//IL_26a0: Expected Obj, but got VT
		//IL_26ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b2: Expected Obj, but got Unknown
		//IL_26cf: Expected Obj, but got I
		//IL_26ef: Expected Obj, but got I4
		//IL_2a18: Expected VT, but got Ref
		//IL_27d9: Expected Obj, but got VT
		//IL_27e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_27eb: Expected Obj, but got Unknown
		//IL_2808: Expected Obj, but got I
		//IL_2828: Expected Obj, but got I4
		//IL_2b43: Expected VT, but got Ref
		//IL_2912: Expected Obj, but got VT
		//IL_291f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2924: Expected Obj, but got Unknown
		//IL_2941: Expected Obj, but got I
		//IL_2961: Expected Obj, but got I4
		//IL_2c7c: Expected VT, but got Ref
		//IL_2a4b: Expected Obj, but got VT
		//IL_2a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a5d: Expected Obj, but got Unknown
		//IL_2a7a: Expected Obj, but got I
		//IL_2a9a: Expected Obj, but got I4
		//IL_2db5: Expected VT, but got Ref
		//IL_2b76: Expected Obj, but got VT
		//IL_2b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b88: Expected Obj, but got Unknown
		//IL_2ba5: Expected Obj, but got I
		//IL_2bc5: Expected Obj, but got I4
		//IL_2ee0: Expected VT, but got Ref
		//IL_2caf: Expected Obj, but got VT
		//IL_2cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cc1: Expected Obj, but got Unknown
		//IL_2cde: Expected Obj, but got I
		//IL_2cfe: Expected Obj, but got I4
		//IL_3019: Expected VT, but got Ref
		//IL_2de8: Expected Obj, but got VT
		//IL_2df5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dfa: Expected Obj, but got Unknown
		//IL_2e17: Expected Obj, but got I
		//IL_2e37: Expected Obj, but got I4
		//IL_3152: Expected VT, but got Ref
		//IL_2f13: Expected Obj, but got VT
		//IL_2f20: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f25: Expected Obj, but got Unknown
		//IL_2f42: Expected Obj, but got I
		//IL_2f62: Expected Obj, but got I4
		//IL_328b: Expected VT, but got Ref
		//IL_304c: Expected Obj, but got VT
		//IL_3059: Unknown result type (might be due to invalid IL or missing references)
		//IL_305e: Expected Obj, but got Unknown
		//IL_307b: Expected Obj, but got I
		//IL_309b: Expected Obj, but got I4
		//IL_33c4: Expected VT, but got Ref
		//IL_3185: Expected Obj, but got VT
		//IL_3192: Unknown result type (might be due to invalid IL or missing references)
		//IL_3197: Expected Obj, but got Unknown
		//IL_31b4: Expected Obj, but got I
		//IL_31d4: Expected Obj, but got I4
		//IL_34ef: Expected VT, but got Ref
		//IL_32be: Expected Obj, but got VT
		//IL_32cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_32d0: Expected Obj, but got Unknown
		//IL_32ed: Expected Obj, but got I
		//IL_330d: Expected Obj, but got I4
		//IL_3628: Expected VT, but got Ref
		//IL_33f7: Expected Obj, but got VT
		//IL_3404: Unknown result type (might be due to invalid IL or missing references)
		//IL_3409: Expected Obj, but got Unknown
		//IL_3426: Expected Obj, but got I
		//IL_3446: Expected Obj, but got I4
		//IL_3761: Expected VT, but got Ref
		//IL_3522: Expected Obj, but got VT
		//IL_352f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3534: Expected Obj, but got Unknown
		//IL_3551: Expected Obj, but got I
		//IL_3571: Expected Obj, but got I4
		//IL_389a: Expected VT, but got Ref
		//IL_365b: Expected Obj, but got VT
		//IL_3668: Unknown result type (might be due to invalid IL or missing references)
		//IL_366d: Expected Obj, but got Unknown
		//IL_368a: Expected Obj, but got I
		//IL_36aa: Expected Obj, but got I4
		//IL_39c5: Expected VT, but got Ref
		//IL_3794: Expected Obj, but got VT
		//IL_37a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_37a6: Expected Obj, but got Unknown
		//IL_37c3: Expected Obj, but got I
		//IL_37e3: Expected Obj, but got I4
		//IL_3afe: Expected VT, but got Ref
		//IL_38cd: Expected Obj, but got VT
		//IL_38da: Unknown result type (might be due to invalid IL or missing references)
		//IL_38df: Expected Obj, but got Unknown
		//IL_38fc: Expected Obj, but got I
		//IL_391c: Expected Obj, but got I4
		//IL_3c37: Expected VT, but got Ref
		//IL_39f8: Expected Obj, but got VT
		//IL_3a05: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a0a: Expected Obj, but got Unknown
		//IL_3a27: Expected Obj, but got I
		//IL_3a47: Expected Obj, but got I4
		//IL_3d62: Expected VT, but got Ref
		//IL_3b31: Expected Obj, but got VT
		//IL_3b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b43: Expected Obj, but got Unknown
		//IL_3b60: Expected Obj, but got I
		//IL_3b80: Expected Obj, but got I4
		//IL_3e9b: Expected VT, but got Ref
		//IL_3c6a: Expected Obj, but got VT
		//IL_3c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c7c: Expected Obj, but got Unknown
		//IL_3c99: Expected Obj, but got I
		//IL_3cb9: Expected Obj, but got I4
		//IL_3fd4: Expected VT, but got Ref
		//IL_3d95: Expected Obj, but got VT
		//IL_3da2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3da7: Expected Obj, but got Unknown
		//IL_3dc4: Expected Obj, but got I
		//IL_3de4: Expected Obj, but got I4
		//IL_410d: Expected VT, but got Ref
		//IL_3ece: Expected Obj, but got VT
		//IL_3edb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ee0: Expected Obj, but got Unknown
		//IL_3efd: Expected Obj, but got I
		//IL_3f1d: Expected Obj, but got I4
		//IL_4246: Expected VT, but got Ref
		//IL_4007: Expected Obj, but got VT
		//IL_4014: Unknown result type (might be due to invalid IL or missing references)
		//IL_4019: Expected Obj, but got Unknown
		//IL_4036: Expected Obj, but got I
		//IL_4056: Expected Obj, but got I4
		//IL_4371: Expected VT, but got Ref
		//IL_4140: Expected Obj, but got VT
		//IL_414d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4152: Expected Obj, but got Unknown
		//IL_416f: Expected Obj, but got I
		//IL_418f: Expected Obj, but got I4
		//IL_44aa: Expected VT, but got Ref
		//IL_4279: Expected Obj, but got VT
		//IL_4286: Unknown result type (might be due to invalid IL or missing references)
		//IL_428b: Expected Obj, but got Unknown
		//IL_42a8: Expected Obj, but got I
		//IL_42c8: Expected Obj, but got I4
		//IL_45e3: Expected VT, but got Ref
		//IL_43a4: Expected Obj, but got VT
		//IL_43b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_43b6: Expected Obj, but got Unknown
		//IL_43d3: Expected Obj, but got I
		//IL_43f3: Expected Obj, but got I4
		//IL_471c: Expected VT, but got Ref
		//IL_44dd: Expected Obj, but got VT
		//IL_44ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_44ef: Expected Obj, but got Unknown
		//IL_450c: Expected Obj, but got I
		//IL_452c: Expected Obj, but got I4
		//IL_4847: Expected VT, but got Ref
		//IL_4616: Expected Obj, but got VT
		//IL_4623: Unknown result type (might be due to invalid IL or missing references)
		//IL_4628: Expected Obj, but got Unknown
		//IL_4645: Expected Obj, but got I
		//IL_4665: Expected Obj, but got I4
		//IL_4980: Expected VT, but got Ref
		//IL_474f: Expected Obj, but got VT
		//IL_475c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4761: Expected Obj, but got Unknown
		//IL_477e: Expected Obj, but got I
		//IL_479e: Expected Obj, but got I4
		//IL_4ab9: Expected VT, but got Ref
		//IL_487a: Expected Obj, but got VT
		//IL_4887: Unknown result type (might be due to invalid IL or missing references)
		//IL_488c: Expected Obj, but got Unknown
		//IL_48a9: Expected Obj, but got I
		//IL_48c9: Expected Obj, but got I4
		//IL_4be4: Expected VT, but got Ref
		//IL_49b3: Expected Obj, but got VT
		//IL_49c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_49c5: Expected Obj, but got Unknown
		//IL_49e2: Expected Obj, but got I
		//IL_4a02: Expected Obj, but got I4
		//IL_4d1d: Expected VT, but got Ref
		//IL_4aec: Expected Obj, but got VT
		//IL_4af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4afe: Expected Obj, but got Unknown
		//IL_4b1b: Expected Obj, but got I
		//IL_4b3b: Expected Obj, but got I4
		//IL_4e56: Expected VT, but got Ref
		//IL_4c17: Expected Obj, but got VT
		//IL_4c24: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c29: Expected Obj, but got Unknown
		//IL_4c46: Expected Obj, but got I
		//IL_4c66: Expected Obj, but got I4
		//IL_4f8f: Expected VT, but got Ref
		//IL_4d50: Expected Obj, but got VT
		//IL_4d5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d62: Expected Obj, but got Unknown
		//IL_4d7f: Expected Obj, but got I
		//IL_4d9f: Expected Obj, but got I4
		//IL_50c8: Expected VT, but got Ref
		//IL_4e89: Expected Obj, but got VT
		//IL_4e96: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e9b: Expected Obj, but got Unknown
		//IL_4eb8: Expected Obj, but got I
		//IL_4ed8: Expected Obj, but got I4
		//IL_51f3: Expected VT, but got Ref
		//IL_4fc2: Expected Obj, but got VT
		//IL_4fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fd4: Expected Obj, but got Unknown
		//IL_4ff1: Expected Obj, but got I
		//IL_5011: Expected Obj, but got I4
		//IL_532c: Expected VT, but got Ref
		//IL_50fb: Expected Obj, but got VT
		//IL_5108: Unknown result type (might be due to invalid IL or missing references)
		//IL_510d: Expected Obj, but got Unknown
		//IL_512a: Expected Obj, but got I
		//IL_514a: Expected Obj, but got I4
		//IL_5465: Expected VT, but got Ref
		//IL_5226: Expected Obj, but got VT
		//IL_5233: Unknown result type (might be due to invalid IL or missing references)
		//IL_5238: Expected Obj, but got Unknown
		//IL_5255: Expected Obj, but got I
		//IL_5275: Expected Obj, but got I4
		//IL_559e: Expected VT, but got Ref
		//IL_535f: Expected Obj, but got VT
		//IL_536c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5371: Expected Obj, but got Unknown
		//IL_538e: Expected Obj, but got I
		//IL_53ae: Expected Obj, but got I4
		//IL_5498: Expected Obj, but got VT
		//IL_54a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_54aa: Expected Obj, but got Unknown
		//IL_54c7: Expected Obj, but got I
		//IL_54e7: Expected Obj, but got I4
		//IL_55d1: Expected Obj, but got VT
		//IL_55de: Unknown result type (might be due to invalid IL or missing references)
		//IL_55e3: Expected Obj, but got Unknown
		//IL_5600: Expected Obj, but got I
		//IL_5620: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Vector3 intersection = default;
		BoxNarrowData boxNarrow2 = default;
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref planes), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj = contactPoint + boxAPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj2 = num + 0;
			ref Vector3 reference = ref *(Vector3*)obj;
			object obj3 = cpCount + 1;
			ref int reference2 = ref *(int*)obj3;
			if (!detailedManifold || (nint)obj3 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref planes), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj4 = intersection + boxAPosition;
			object obj5 = contactPoint + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj6 = num2 + 0;
			ref Vector3 reference = ref *(Vector3*)obj5;
			object obj7 = cpCount + 1;
			ref int reference2 = ref *(int*)obj7;
			if (!detailedManifold || (nint)obj7 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref planes), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj8 = intersection + boxAPosition;
			object obj9 = contactPoint + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj10 = num3 + 0;
			ref Vector3 reference = ref *(Vector3*)obj9;
			object obj11 = cpCount + 1;
			ref int reference2 = ref *(int*)obj11;
			if (!detailedManifold || (nint)obj11 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref planes), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj12 = intersection + boxAPosition;
			object obj13 = contactPoint + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj14 = num4 + 0;
			ref Vector3 reference = ref *(Vector3*)obj13;
			object obj15 = cpCount + 1;
			ref int reference2 = ref *(int*)obj15;
			if (!detailedManifold || (nint)obj15 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref planes), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj16 = intersection + boxAPosition;
			object obj17 = contactPoint + obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj18 = num5 + 0;
			ref Vector3 reference = ref *(Vector3*)obj17;
			object obj19 = cpCount + 1;
			ref int reference2 = ref *(int*)obj19;
			if (!detailedManifold || (nint)obj19 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref planes), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj20 = intersection + boxAPosition;
			object obj21 = contactPoint + obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj22 = num6 + 0;
			ref Vector3 reference = ref *(Vector3*)obj21;
			object obj23 = cpCount + 1;
			ref int reference2 = ref *(int*)obj23;
			if (!detailedManifold || (nint)obj23 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref planes), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj24 = intersection + boxAPosition;
			object obj25 = contactPoint + obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj26 = num7 + 0;
			ref Vector3 reference = ref *(Vector3*)obj25;
			object obj27 = cpCount + 1;
			ref int reference2 = ref *(int*)obj27;
			if (!detailedManifold || (nint)obj27 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref planes), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj28 = intersection + boxAPosition;
			object obj29 = contactPoint + obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj30 = num8 + 0;
			ref Vector3 reference = ref *(Vector3*)obj29;
			object obj31 = cpCount + 1;
			ref int reference2 = ref *(int*)obj31;
			if (!detailedManifold || (nint)obj31 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref planes), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj32 = intersection + boxAPosition;
			object obj33 = contactPoint + obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj34 = num9 + 0;
			ref Vector3 reference = ref *(Vector3*)obj33;
			object obj35 = cpCount + 1;
			ref int reference2 = ref *(int*)obj35;
			if (!detailedManifold || (nint)obj35 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref planes), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj36 = intersection + boxAPosition;
			object obj37 = contactPoint + obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj38 = num10 + 0;
			ref Vector3 reference = ref *(Vector3*)obj37;
			object obj39 = cpCount + 1;
			ref int reference2 = ref *(int*)obj39;
			if (!detailedManifold || (nint)obj39 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref planes), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj40 = intersection + boxAPosition;
			object obj41 = contactPoint + obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj42 = num11 + 0;
			ref Vector3 reference = ref *(Vector3*)obj41;
			object obj43 = cpCount + 1;
			ref int reference2 = ref *(int*)obj43;
			if (!detailedManifold || (nint)obj43 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref planes), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj44 = intersection + boxAPosition;
			object obj45 = contactPoint + obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj46 = num12 + 0;
			ref Vector3 reference = ref *(Vector3*)obj45;
			object obj47 = cpCount + 1;
			ref int reference2 = ref *(int*)obj47;
			if (!detailedManifold || (nint)obj47 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj48 = intersection + boxAPosition;
			object obj49 = contactPoint + obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj50 = num13 + 0;
			ref Vector3 reference = ref *(Vector3*)obj49;
			object obj51 = cpCount + 1;
			ref int reference2 = ref *(int*)obj51;
			if (!detailedManifold || (nint)obj51 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj52 = intersection + boxAPosition;
			object obj53 = contactPoint + obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj54 = num14 + 0;
			ref Vector3 reference = ref *(Vector3*)obj53;
			object obj55 = cpCount + 1;
			ref int reference2 = ref *(int*)obj55;
			if (!detailedManifold || (nint)obj55 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj56 = intersection + boxAPosition;
			object obj57 = contactPoint + obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj58 = num15 + 0;
			ref Vector3 reference = ref *(Vector3*)obj57;
			object obj59 = cpCount + 1;
			ref int reference2 = ref *(int*)obj59;
			if (!detailedManifold || (nint)obj59 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj60 = intersection + boxAPosition;
			object obj61 = contactPoint + obj60;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj62 = num16 + 0;
			ref Vector3 reference = ref *(Vector3*)obj61;
			object obj63 = cpCount + 1;
			ref int reference2 = ref *(int*)obj63;
			if (!detailedManifold || (nint)obj63 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj64 = intersection + boxAPosition;
			object obj65 = contactPoint + obj64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj66 = num17 + 0;
			ref Vector3 reference = ref *(Vector3*)obj65;
			object obj67 = cpCount + 1;
			ref int reference2 = ref *(int*)obj67;
			if (!detailedManifold || (nint)obj67 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj68 = intersection + boxAPosition;
			object obj69 = contactPoint + obj68;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj70 = num18 + 0;
			ref Vector3 reference = ref *(Vector3*)obj69;
			object obj71 = cpCount + 1;
			ref int reference2 = ref *(int*)obj71;
			if (!detailedManifold || (nint)obj71 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj72 = intersection + boxAPosition;
			object obj73 = contactPoint + obj72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj74 = num19 + 0;
			ref Vector3 reference = ref *(Vector3*)obj73;
			object obj75 = cpCount + 1;
			ref int reference2 = ref *(int*)obj75;
			if (!detailedManifold || (nint)obj75 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj76 = intersection + boxAPosition;
			object obj77 = contactPoint + obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj78 = num20 + 0;
			ref Vector3 reference = ref *(Vector3*)obj77;
			object obj79 = cpCount + 1;
			ref int reference2 = ref *(int*)obj79;
			if (!detailedManifold || (nint)obj79 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj80 = intersection + boxAPosition;
			object obj81 = contactPoint + obj80;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj82 = num21 + 0;
			ref Vector3 reference = ref *(Vector3*)obj81;
			object obj83 = cpCount + 1;
			ref int reference2 = ref *(int*)obj83;
			if (!detailedManifold || (nint)obj83 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj84 = intersection + boxAPosition;
			object obj85 = contactPoint + obj84;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj86 = num22 + 0;
			ref Vector3 reference = ref *(Vector3*)obj85;
			object obj87 = cpCount + 1;
			ref int reference2 = ref *(int*)obj87;
			if (!detailedManifold || (nint)obj87 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj88 = intersection + boxAPosition;
			object obj89 = contactPoint + obj88;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj90 = num23 + 0;
			ref Vector3 reference = ref *(Vector3*)obj89;
			object obj91 = cpCount + 1;
			ref int reference2 = ref *(int*)obj91;
			if (!detailedManifold || (nint)obj91 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj92 = intersection + boxAPosition;
			object obj93 = contactPoint + obj92;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj94 = num24 + 0;
			ref Vector3 reference = ref *(Vector3*)obj93;
			object obj95 = cpCount + 1;
			ref int reference2 = ref *(int*)obj95;
			if (!detailedManifold || (nint)obj95 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj96 = intersection + boxAPosition;
			object obj97 = contactPoint + obj96;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj98 = num25 + 0;
			ref Vector3 reference = ref *(Vector3*)obj97;
			object obj99 = cpCount + 1;
			ref int reference2 = ref *(int*)obj99;
			if (!detailedManifold || (nint)obj99 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj100 = intersection + boxAPosition;
			object obj101 = contactPoint + obj100;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj102 = num26 + 0;
			ref Vector3 reference = ref *(Vector3*)obj101;
			object obj103 = cpCount + 1;
			ref int reference2 = ref *(int*)obj103;
			if (!detailedManifold || (nint)obj103 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj104 = intersection + boxAPosition;
			object obj105 = contactPoint + obj104;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj106 = num27 + 0;
			ref Vector3 reference = ref *(Vector3*)obj105;
			object obj107 = cpCount + 1;
			ref int reference2 = ref *(int*)obj107;
			if (!detailedManifold || (nint)obj107 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj108 = intersection + boxAPosition;
			object obj109 = contactPoint + obj108;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj110 = num28 + 0;
			ref Vector3 reference = ref *(Vector3*)obj109;
			object obj111 = cpCount + 1;
			ref int reference2 = ref *(int*)obj111;
			if (!detailedManifold || (nint)obj111 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj112 = intersection + boxAPosition;
			object obj113 = contactPoint + obj112;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj114 = num29 + 0;
			ref Vector3 reference = ref *(Vector3*)obj113;
			object obj115 = cpCount + 1;
			ref int reference2 = ref *(int*)obj115;
			if (!detailedManifold || (nint)obj115 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj116 = intersection + boxAPosition;
			object obj117 = contactPoint + obj116;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj118 = num30 + 0;
			ref Vector3 reference = ref *(Vector3*)obj117;
			object obj119 = cpCount + 1;
			ref int reference2 = ref *(int*)obj119;
			if (!detailedManifold || (nint)obj119 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj120 = intersection + boxAPosition;
			object obj121 = contactPoint + obj120;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj122 = num31 + 0;
			ref Vector3 reference = ref *(Vector3*)obj121;
			object obj123 = cpCount + 1;
			ref int reference2 = ref *(int*)obj123;
			if (!detailedManifold || (nint)obj123 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj124 = intersection + boxAPosition;
			object obj125 = contactPoint + obj124;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj126 = num32 + 0;
			ref Vector3 reference = ref *(Vector3*)obj125;
			object obj127 = cpCount + 1;
			ref int reference2 = ref *(int*)obj127;
			if (!detailedManifold || (nint)obj127 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj128 = intersection + boxAPosition;
			object obj129 = contactPoint + obj128;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj130 = num33 + 0;
			ref Vector3 reference = ref *(Vector3*)obj129;
			object obj131 = cpCount + 1;
			ref int reference2 = ref *(int*)obj131;
			if (!detailedManifold || (nint)obj131 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj132 = intersection + boxAPosition;
			object obj133 = contactPoint + obj132;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj134 = num34 + 0;
			ref Vector3 reference = ref *(Vector3*)obj133;
			object obj135 = cpCount + 1;
			ref int reference2 = ref *(int*)obj135;
			if (!detailedManifold || (nint)obj135 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj136 = intersection + boxAPosition;
			object obj137 = contactPoint + obj136;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj138 = num35 + 0;
			ref Vector3 reference = ref *(Vector3*)obj137;
			object obj139 = cpCount + 1;
			ref int reference2 = ref *(int*)obj139;
			if (!detailedManifold || (nint)obj139 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj140 = intersection + boxAPosition;
			object obj141 = contactPoint + obj140;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj142 = num36 + 0;
			ref Vector3 reference = ref *(Vector3*)obj141;
			object obj143 = cpCount + 1;
			ref int reference2 = ref *(int*)obj143;
			if (!detailedManifold || (nint)obj143 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj144 = intersection + boxAPosition;
			object obj145 = contactPoint + obj144;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj146 = num37 + 0;
			ref Vector3 reference = ref *(Vector3*)obj145;
			object obj147 = cpCount + 1;
			ref int reference2 = ref *(int*)obj147;
			if (!detailedManifold || (nint)obj147 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj148 = intersection + boxAPosition;
			object obj149 = contactPoint + obj148;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj150 = num38 + 0;
			ref Vector3 reference = ref *(Vector3*)obj149;
			object obj151 = cpCount + 1;
			ref int reference2 = ref *(int*)obj151;
			if (!detailedManifold || (nint)obj151 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj152 = intersection + boxAPosition;
			object obj153 = contactPoint + obj152;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj154 = num39 + 0;
			ref Vector3 reference = ref *(Vector3*)obj153;
			object obj155 = cpCount + 1;
			ref int reference2 = ref *(int*)obj155;
			if (!detailedManifold || (nint)obj155 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj156 = intersection + boxAPosition;
			object obj157 = contactPoint + obj156;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj158 = num40 + 0;
			ref Vector3 reference = ref *(Vector3*)obj157;
			object obj159 = cpCount + 1;
			ref int reference2 = ref *(int*)obj159;
			if (!detailedManifold || (nint)obj159 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj160 = intersection + boxAPosition;
			object obj161 = contactPoint + obj160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj162 = num41 + 0;
			ref Vector3 reference = ref *(Vector3*)obj161;
			object obj163 = cpCount + 1;
			ref int reference2 = ref *(int*)obj163;
			if (!detailedManifold || (nint)obj163 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj164 = intersection + boxAPosition;
			object obj165 = contactPoint + obj164;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj166 = num42 + 0;
			ref Vector3 reference = ref *(Vector3*)obj165;
			object obj167 = cpCount + 1;
			ref int reference2 = ref *(int*)obj167;
			if (!detailedManifold || (nint)obj167 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj168 = intersection + boxAPosition;
			object obj169 = contactPoint + obj168;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj170 = num43 + 0;
			ref Vector3 reference = ref *(Vector3*)obj169;
			object obj171 = cpCount + 1;
			ref int reference2 = ref *(int*)obj171;
			if (!detailedManifold || (nint)obj171 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj172 = intersection + boxAPosition;
			object obj173 = contactPoint + obj172;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj174 = num44 + 0;
			ref Vector3 reference = ref *(Vector3*)obj173;
			object obj175 = cpCount + 1;
			ref int reference2 = ref *(int*)obj175;
			if (!detailedManifold || (nint)obj175 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj176 = intersection + boxAPosition;
			object obj177 = contactPoint + obj176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj178 = num45 + 0;
			ref Vector3 reference = ref *(Vector3*)obj177;
			object obj179 = cpCount + 1;
			ref int reference2 = ref *(int*)obj179;
			if (!detailedManifold || (nint)obj179 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj180 = intersection + boxAPosition;
			object obj181 = contactPoint + obj180;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj182 = num46 + 0;
			ref Vector3 reference = ref *(Vector3*)obj181;
			object obj183 = cpCount + 1;
			ref int reference2 = ref *(int*)obj183;
			if (!detailedManifold || (nint)obj183 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj184 = intersection + boxAPosition;
			object obj185 = contactPoint + obj184;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj186 = num47 + 0;
			ref Vector3 reference = ref *(Vector3*)obj185;
			object obj187 = cpCount + 1;
			ref int reference2 = ref *(int*)obj187;
			if (!detailedManifold || (nint)obj187 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj188 = intersection + boxAPosition;
			object obj189 = contactPoint + obj188;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj190 = num48 + 0;
			ref Vector3 reference = ref *(Vector3*)obj189;
			object obj191 = cpCount + 1;
			ref int reference2 = ref *(int*)obj191;
			if (!detailedManifold || (nint)obj191 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 96)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj192 = intersection + boxAPosition;
			object obj193 = contactPoint + obj192;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj194 = num49 + 0;
			ref Vector3 reference = ref *(Vector3*)obj193;
			object obj195 = cpCount + 1;
			ref int reference2 = ref *(int*)obj195;
			if (!detailedManifold || (nint)obj195 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 96)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj196 = intersection + boxAPosition;
			object obj197 = contactPoint + obj196;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj198 = num50 + 0;
			ref Vector3 reference = ref *(Vector3*)obj197;
			object obj199 = cpCount + 1;
			ref int reference2 = ref *(int*)obj199;
			if (!detailedManifold || (nint)obj199 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 96)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj200 = intersection + boxAPosition;
			object obj201 = contactPoint + obj200;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj202 = num51 + 0;
			ref Vector3 reference = ref *(Vector3*)obj201;
			object obj203 = cpCount + 1;
			ref int reference2 = ref *(int*)obj203;
			if (!detailedManifold || (nint)obj203 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 96)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj204 = intersection + boxAPosition;
			object obj205 = contactPoint + obj204;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj206 = num52 + 0;
			ref Vector3 reference = ref *(Vector3*)obj205;
			object obj207 = cpCount + 1;
			ref int reference2 = ref *(int*)obj207;
			if (!detailedManifold || (nint)obj207 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 96)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj208 = intersection + boxAPosition;
			object obj209 = contactPoint + obj208;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj210 = num53 + 0;
			ref Vector3 reference = ref *(Vector3*)obj209;
			object obj211 = cpCount + 1;
			ref int reference2 = ref *(int*)obj211;
			if (!detailedManifold || (nint)obj211 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 96)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj212 = intersection + boxAPosition;
			object obj213 = contactPoint + obj212;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj214 = num54 + 0;
			ref Vector3 reference = ref *(Vector3*)obj213;
			object obj215 = cpCount + 1;
			ref int reference2 = ref *(int*)obj215;
			if (!detailedManifold || (nint)obj215 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 96)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj216 = intersection + boxAPosition;
			object obj217 = contactPoint + obj216;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj218 = num55 + 0;
			ref Vector3 reference = ref *(Vector3*)obj217;
			object obj219 = cpCount + 1;
			ref int reference2 = ref *(int*)obj219;
			if (!detailedManifold || (nint)obj219 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 96)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj220 = intersection + boxAPosition;
			object obj221 = contactPoint + obj220;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj222 = num56 + 0;
			ref Vector3 reference = ref *(Vector3*)obj221;
			object obj223 = cpCount + 1;
			ref int reference2 = ref *(int*)obj223;
			if (!detailedManifold || (nint)obj223 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 96)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj224 = intersection + boxAPosition;
			object obj225 = contactPoint + obj224;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj226 = num57 + 0;
			ref Vector3 reference = ref *(Vector3*)obj225;
			object obj227 = cpCount + 1;
			ref int reference2 = ref *(int*)obj227;
			if (!detailedManifold || (nint)obj227 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 96)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj228 = intersection + boxAPosition;
			object obj229 = contactPoint + obj228;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num58 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj230 = num58 + 0;
			ref Vector3 reference = ref *(Vector3*)obj229;
			object obj231 = cpCount + 1;
			ref int reference2 = ref *(int*)obj231;
			if (!detailedManifold || (nint)obj231 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 96)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj232 = intersection + boxAPosition;
			object obj233 = contactPoint + obj232;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj234 = num59 + 0;
			ref Vector3 reference = ref *(Vector3*)obj233;
			object obj235 = cpCount + 1;
			ref int reference2 = ref *(int*)obj235;
			if (!detailedManifold || (nint)obj235 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 96)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj236 = intersection + boxAPosition;
			object obj237 = contactPoint + obj236;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num60 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj238 = num60 + 0;
			ref Vector3 reference = ref *(Vector3*)obj237;
			object obj239 = cpCount + 1;
			ref int reference2 = ref *(int*)obj239;
			if (!detailedManifold || (nint)obj239 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 120)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj240 = intersection + boxAPosition;
			object obj241 = contactPoint + obj240;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num61 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj242 = num61 + 0;
			ref Vector3 reference = ref *(Vector3*)obj241;
			object obj243 = cpCount + 1;
			ref int reference2 = ref *(int*)obj243;
			if (!detailedManifold || (nint)obj243 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 120)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj244 = intersection + boxAPosition;
			object obj245 = contactPoint + obj244;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num62 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj246 = num62 + 0;
			ref Vector3 reference = ref *(Vector3*)obj245;
			object obj247 = cpCount + 1;
			ref int reference2 = ref *(int*)obj247;
			if (!detailedManifold || (nint)obj247 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 120)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj248 = intersection + boxAPosition;
			object obj249 = contactPoint + obj248;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num63 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj250 = num63 + 0;
			ref Vector3 reference = ref *(Vector3*)obj249;
			object obj251 = cpCount + 1;
			ref int reference2 = ref *(int*)obj251;
			if (!detailedManifold || (nint)obj251 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 120)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj252 = intersection + boxAPosition;
			object obj253 = contactPoint + obj252;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num64 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj254 = num64 + 0;
			ref Vector3 reference = ref *(Vector3*)obj253;
			object obj255 = cpCount + 1;
			ref int reference2 = ref *(int*)obj255;
			if (!detailedManifold || (nint)obj255 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 120)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj256 = intersection + boxAPosition;
			object obj257 = contactPoint + obj256;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj258 = num65 + 0;
			ref Vector3 reference = ref *(Vector3*)obj257;
			object obj259 = cpCount + 1;
			ref int reference2 = ref *(int*)obj259;
			if (!detailedManifold || (nint)obj259 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 120)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj260 = intersection + boxAPosition;
			object obj261 = contactPoint + obj260;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj262 = num66 + 0;
			ref Vector3 reference = ref *(Vector3*)obj261;
			object obj263 = cpCount + 1;
			ref int reference2 = ref *(int*)obj263;
			if (!detailedManifold || (nint)obj263 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 120)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj264 = intersection + boxAPosition;
			object obj265 = contactPoint + obj264;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num67 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj266 = num67 + 0;
			ref Vector3 reference = ref *(Vector3*)obj265;
			object obj267 = cpCount + 1;
			ref int reference2 = ref *(int*)obj267;
			if (!detailedManifold || (nint)obj267 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 120)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj268 = intersection + boxAPosition;
			object obj269 = contactPoint + obj268;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num68 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj270 = num68 + 0;
			ref Vector3 reference = ref *(Vector3*)obj269;
			object obj271 = cpCount + 1;
			ref int reference2 = ref *(int*)obj271;
			if (!detailedManifold || (nint)obj271 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 120)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 48)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref edges), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj272 = intersection + boxAPosition;
			object obj273 = contactPoint + obj272;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num69 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj274 = num69 + 0;
			ref Vector3 reference = ref *(Vector3*)obj273;
			object obj275 = cpCount + 1;
			ref int reference2 = ref *(int*)obj275;
			if (!detailedManifold || (nint)obj275 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 120)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 60)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 12)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj276 = intersection + boxAPosition;
			object obj277 = contactPoint + obj276;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num70 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj278 = num70 + 0;
			ref Vector3 reference = ref *(Vector3*)obj277;
			object obj279 = cpCount + 1;
			ref int reference2 = ref *(int*)obj279;
			if (!detailedManifold || (nint)obj279 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 120)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 72)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 24)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj280 = intersection + boxAPosition;
			object obj281 = contactPoint + obj280;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num71 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj282 = num71 + 0;
			ref Vector3 reference = ref *(Vector3*)obj281;
			object obj283 = cpCount + 1;
			ref int reference2 = ref *(int*)obj283;
			if (!detailedManifold || (nint)obj283 > 3)
			{
				return;
			}
		}
		if (ClipToPlane(ref System.Runtime.CompilerServices.Unsafe.As<CustomPlanesBox, CustomPlane>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref planes, 120)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 84)), ref System.Runtime.CompilerServices.Unsafe.As<CustomEdgesBox, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref edges, 36)), ref intersection) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref intersection))
		{
			object obj284 = intersection + boxAPosition;
			object obj285 = contactPoint + obj284;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [contactPoint @ X7 (UnityEngine.Vector3&)+8]");
			nint num72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxAPosition @ X4 (UnityEngine.Vector3&)+8]");
			object obj286 = num72 + 0;
			ref Vector3 reference = ref *(Vector3*)obj285;
			object obj287 = cpCount + 1;
			ref int reference2 = ref *(int*)obj287;
		}
	}

	private unsafe static bool ClipToPlane(ref CustomPlane plane, ref Vector3 lineStart, ref Vector3 lineEnd, ref Vector3 intersection)
	{
		//IL_0017: Expected Obj, but got VT
		//IL_0034: Expected Obj, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_01b4: Expected Obj, but got I4
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0169: Invalid comparison between Obj and F8
		//IL_017a: Expected Obj, but got I4
		//IL_0197: Invalid comparison between F8 and I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		object obj = lineEnd - lineStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [lineEnd @ X2 (UnityEngine.Vector3&)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [lineStart @ X1 (UnityEngine.Vector3&)+8]");
		object obj2 = num - 0;
		object obj3 = obj * plane;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [plane @ X0 (CustomPlane&)+8]");
		object obj4 = obj2 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		object obj5 = obj4 + obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACA4]");
		if ((nint)obj5 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			if ((nint)obj5 < 0)
			{
				goto IL_01b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [plane @ X0 (CustomPlane&)+C]");
		object obj6 = 0 - lineStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [plane @ X0 (CustomPlane&)+14]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [lineStart @ X1 (UnityEngine.Vector3&)+8]");
		object obj7 = num2 - 0;
		object obj8 = plane * obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [plane @ X0 (CustomPlane&)+8]");
		object obj9 = 0 * obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		object obj10 = obj9 + obj8;
		object obj11 = obj10 / obj5;
		object obj12;
		bool flag2;
		if ((nint)obj11 >= 0)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1.0);
			obj12 = !flag;
			double num3 = (double)obj11 - 1.0;
			flag2 = num3 == 0.0;
		}
		else
		{
			flag2 = false;
			obj12 = 1;
		}
		object obj13 = ~obj12;
		object obj14 = obj13 | flag2;
		if (obj14 != null)
		{
			object obj16 = default;
			object obj15 = obj * obj16;
			object obj17 = obj2 * obj11;
			object obj18 = lineStart + obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [lineStart @ X1 (UnityEngine.Vector3&)+8]");
			object obj19 = 0 + obj17;
			ref Vector3 reference = ref *(Vector3*)obj18;
			return true;
		}
		goto IL_01b9;
		IL_01b9:
		return false;
	}

	private unsafe static bool BoxInAABB(ref CustomEdgesBox boxEdges, ref BoxNarrowData boxNarrow, ref Vector3 offset)
	{
		//IL_0020: Expected VT, but got Ref
		//IL_0056: Expected VT, but got Ref
		//IL_008c: Expected VT, but got Ref
		//IL_00c2: Expected VT, but got Ref
		//IL_00f8: Expected VT, but got Ref
		//IL_012e: Expected VT, but got Ref
		//IL_0164: Expected VT, but got Ref
		//IL_019a: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		BoxNarrowData boxNarrow2 = default;
		IntPtr intPtr = default;
		if (PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref *(Vector3*)intPtr) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref *(Vector3*)intPtr) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref *(Vector3*)intPtr) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref *(Vector3*)intPtr) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref *(Vector3*)intPtr) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref *(Vector3*)intPtr) && PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref *(Vector3*)intPtr))
		{
			return PointInAABB((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxNarrow), ref boxNarrow2, ref offset, ref *(Vector3*)intPtr);
		}
		return false;
	}

	private unsafe static bool PointInAABB(Vector3 point, ref BoxNarrowData boxNarrow, ref Vector3 max, ref Vector3 offset)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_004a: Expected VT, but got I4
		//IL_004a: Expected Ref, but got VT
		//IL_0057: Unsupported input type for neg.
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_02f5: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I4
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_0230: Expected Obj, but got I4
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_0321: Expected Obj, but got I4
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_033b: Expected I4, but got Obj
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - max;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [max @ X2 (UnityEngine.Vector3&)+4]");
		object obj4 = default;
		object obj3 = obj4 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [max @ X2 (UnityEngine.Vector3&)+8]");
		object obj6 = default;
		object obj5 = obj6 - 0;
		Vector3 vector = ((BoxNarrowData*)point)->WorldToLocalVector((Vector3)0);
		object obj7 = 0 - boxNarrow;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
		{
			object obj8 = obj - boxNarrow;
			bool flag = (nint)obj8 < 0;
			bool flag2 = obj8 == null;
			object obj9 = obj ^ boxNarrow;
			object obj10 = obj ^ obj8;
			object obj11 = obj9 & obj10;
			bool flag3 = (nint)obj11 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxNarrow @ X1 (BoxNarrowData&)+4]");
			object obj12 = -0;
			bool flag4 = flag == flag3;
			object obj13 = !flag4;
			object obj14 = obj13 | flag2;
			object obj15 = ~obj14;
			bool flag5;
			if (obj15 == null)
			{
				object obj16 = obj3 - obj12;
				flag5 = (nint)obj16 < 0;
			}
			else
			{
				flag5 = true;
			}
			object obj17 = !flag5;
			if (obj17 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxNarrow @ X1 (BoxNarrowData&)+8]");
				object obj18 = -0;
				object obj19 = obj5 - obj18;
				bool flag6 = (nint)obj19 < 0;
				object obj20 = !flag6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxNarrow @ X1 (BoxNarrowData&)+8]");
				object obj21 = obj5 - 0;
				bool flag7 = (nint)obj21 < 0;
				bool flag8 = obj21 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxNarrow @ X1 (BoxNarrowData&)+8]");
				object obj22 = obj5 ^ 0;
				object obj23 = obj5 ^ obj21;
				object obj24 = obj22 & obj23;
				bool flag9 = (nint)obj24 < 0;
				bool flag10 = flag7 == flag9;
				object obj25 = !flag10;
				object obj26 = obj25 | flag8;
				object obj27 = ~obj26;
				bool flag11;
				bool flag12;
				bool flag13;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxNarrow @ X1 (BoxNarrowData&)+4]");
					object obj28 = obj3 - 0;
					flag11 = (nint)obj28 < 0;
					flag12 = obj28 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxNarrow @ X1 (BoxNarrowData&)+4]");
					object obj29 = obj3 ^ 0;
					object obj30 = obj3 ^ obj28;
					object obj31 = obj29 & obj30;
					flag13 = (nint)obj31 < 0;
				}
				else
				{
					flag13 = false;
					flag12 = false;
					flag11 = false;
				}
				bool flag14 = flag11 == flag13;
				object obj32 = !flag14;
				object obj33 = obj32 | flag12;
				return (byte)(obj33 & obj20) != 0;
			}
		}
		return false;
	}

	public static bool LocalAABBSphereIntersection(Vector3 aabbExtents, Vector3 sphereCenter, float sphereRadius)
	{
		//IL_0004: Unsupported input type for neg.
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected VT, but got Unknown
		//IL_0016: Expected Obj, but got VT
		//IL_0030: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got VT
		//IL_010b: Expected Obj, but got VT
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_014d: Expected Obj, but got I4
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_01b6: Expected Obj, but got VT
		//IL_005d: Unsupported input type for neg.
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_009a: Unsupported input type for neg.
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		Vector3 vector2 = default;
		Vector3 vector = 0 - vector2;
		Vector3 vector3 = default;
		object obj = vector3 - vector;
		bool flag = (nint)obj < 0;
		object obj2 = !flag;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			vector = vector3;
		}
		object obj4 = vector3 - vector2;
		bool flag2 = (nint)obj4 < 0;
		bool flag3 = obj4 == null;
		object obj5 = vector3 ^ vector2;
		object obj6 = vector3 ^ obj4;
		object obj7 = obj5 & obj6;
		bool flag4 = (nint)obj7 < 0;
		bool flag5 = flag2 == flag4;
		object obj8 = !flag3;
		object obj9 = flag5 & obj8;
		object obj10 = ~obj9;
		if (obj10 == null)
		{
		}
		object obj11 = default;
		object obj12 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
		{
			object obj13 = 0 - obj12;
			bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13);
			obj12 = obj11;
			if (!flag6)
			{
				obj12 = obj13;
			}
		}
		object obj14 = default;
		object obj15 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15))
		{
			object obj16 = 0 - obj15;
			bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16);
			obj15 = obj14;
			if (!flag7)
			{
				obj15 = obj16;
			}
		}
		object obj17 = vector3 - vector;
		object obj18 = obj11 - obj12;
		object obj19 = obj14 - obj15;
		object obj20 = obj17 * obj17;
		object obj21 = obj18 * obj18;
		object obj22 = obj20 + obj21;
		object obj23 = obj19 * obj19;
		object obj24 = obj22 + obj23;
		object obj26 = default;
		object obj25 = obj26 * obj26;
		object obj27 = obj24 - obj25;
		return (nint)obj27 < 0;
	}

	public unsafe static bool LocalAABBSphereContact(Vector3 aabbExtents, Vector3 sphereCenter, float sphereRadius, out SnapshotHistoryDraw.ContactData contact)
	{
		//IL_002b: Invalid comparison between F4 and I4
		//IL_003a: Invalid comparison between F4 and I4
		//IL_004d: Expected Obj, but got F4
		//IL_005a: Expected Obj, but got F4
		//IL_008f: Expected Obj, but got I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_000e: Expected Obj, but got I4
		//IL_0756: Expected Obj, but got I4
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected Obj, but got Unknown
		//IL_00e4: Expected Obj, but got I4
		//IL_010f: Invalid comparison between F4 and I4
		//IL_011e: Invalid comparison between F4 and I4
		//IL_0131: Expected Obj, but got F4
		//IL_013e: Expected Obj, but got F4
		//IL_0173: Expected Obj, but got I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_00d6: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I4
		//IL_07b8: Expected Obj, but got I4
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected Obj, but got Unknown
		//IL_01bf: Expected Obj, but got I4
		//IL_0408: Expected native int or pointer, but got VT
		//IL_0415: Expected native int or pointer, but got VT
		//IL_044f: Expected native int or pointer, but got VT
		//IL_04a5: Invalid comparison between F4 and Obj
		//IL_054c: Expected native int or pointer, but got VT
		//IL_055a: Expected native int or pointer, but got VT
		//IL_01dc: Invalid comparison between F4 and I4
		//IL_01eb: Invalid comparison between F4 and I4
		//IL_01fe: Expected Obj, but got F4
		//IL_020b: Expected Obj, but got F4
		//IL_0240: Expected Obj, but got I4
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_04cc: Expected Obj, but got I
		//IL_04f6: Expected Obj, but got I4
		//IL_07f5: Expected Obj, but got I4
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected Obj, but got Unknown
		//IL_051e: Expected F4, but got I
		//IL_052e: Expected F4, but got I
		//IL_053e: Expected F4, but got I
		//IL_0287: Expected Obj, but got I4
		//IL_0294: Expected native int or pointer, but got VT
		//IL_02a1: Expected native int or pointer, but got VT
		//IL_02b6: Expected Obj, but got I
		//IL_02be: Expected native int or pointer, but got VT
		//IL_02f9: Expected Obj, but got I4
		//IL_064e: Invalid comparison between F4 and I4
		//IL_065d: Invalid comparison between F4 and I4
		//IL_0670: Expected Obj, but got F4
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected Obj, but got Unknown
		//IL_06a5: Expected Obj, but got I4
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected Obj, but got Unknown
		//IL_05a1: Invalid comparison between F4 and I4
		//IL_05b0: Invalid comparison between F4 and I4
		//IL_05c3: Expected Obj, but got F4
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected Obj, but got Unknown
		//IL_05fd: Expected Obj, but got I4
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_033e: Invalid comparison between F4 and I4
		//IL_034d: Invalid comparison between F4 and I4
		//IL_0360: Expected Obj, but got F4
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_039a: Expected Obj, but got I4
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Obj, but got Unknown
		float num = 0f - sphereRadius;
		float num2 = default;
		object obj;
		if (num2 < num)
		{
			obj = 0;
		}
		else
		{
			float num3 = num2 - sphereRadius;
			bool flag = num3 < 0f;
			bool flag2 = num3 == 0f;
			object obj2 = num2 ^ sphereRadius;
			object obj3 = num2 ^ num3;
			object obj4 = obj2 & obj3;
			bool flag3 = (nint)obj4 < 0;
			bool flag4 = flag == flag3;
			object obj5 = !flag4;
			object obj6 = obj5 | flag2;
			object obj7 = ~obj6;
			num = ((obj7 != null) ? sphereRadius : num2);
			bool flag5 = flag == flag3;
			object obj8 = !flag5;
			object obj9 = obj8 | flag2;
			object obj10 = ~obj9;
			obj = ((obj10 != null) ? ((object)0) : ((object)1));
		}
		float num5 = default;
		float num4 = 0f - num5;
		float num6 = default;
		if (num6 < num4)
		{
			obj = 0;
		}
		else
		{
			float num7 = num6 - num5;
			bool flag6 = num7 < 0f;
			bool flag7 = num7 == 0f;
			object obj11 = num6 ^ num5;
			object obj12 = num6 ^ num7;
			object obj13 = obj11 & obj12;
			bool flag8 = (nint)obj13 < 0;
			bool flag9 = flag6 == flag8;
			object obj14 = !flag9;
			object obj15 = obj14 | flag7;
			object obj16 = ~obj15;
			num4 = ((obj16 != null) ? num5 : num6);
			bool flag10 = flag6 == flag8;
			object obj17 = !flag10;
			object obj18 = obj17 | flag7;
			object obj19 = ~obj18;
			if (obj19 != null)
			{
				obj = 0;
			}
		}
		float num9 = default;
		float num8 = 0f - num9;
		float num10 = default;
		float num13;
		float num14;
		if (!(num10 < num8))
		{
			float num11 = num10 - num9;
			bool flag11 = num11 < 0f;
			bool flag12 = num11 == 0f;
			object obj20 = num10 ^ num9;
			object obj21 = num10 ^ num11;
			object obj22 = obj20 & obj21;
			bool flag13 = (nint)obj22 < 0;
			bool flag14 = flag11 == flag13;
			object obj23 = !flag14;
			object obj24 = obj23 | flag12;
			object obj25 = ~obj24;
			num8 = ((obj25 != null) ? num9 : num10);
			bool flag15 = flag11 == flag13;
			object obj26 = !flag12;
			object obj27 = flag15 & obj26;
			object obj28 = ~obj27;
			if (obj28 == null)
			{
				obj = 0;
			}
			if ((nint)obj == 1)
			{
				((Vector3*)(nint)aabbExtents)->x = num2;
				((Vector3*)(nint)aabbExtents)->y = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj29 = 0;
				((Vector3*)(nint)aabbExtents)->z = num10;
				_ = 0;
				object obj30 = obj29;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v9+E4]");
				bool flag16 = (nint)0 == 0;
				object obj31 = !flag16;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				float num12 = sphereRadius - sphereRadius;
				num13 = num5 - num5;
				num14 = num9 - num8;
				if (num13 < num12)
				{
					if (!(num13 < num14))
					{
						goto IL_0645;
					}
					bool flag17 = num4 < 0f;
					bool flag18 = num4 == 0f;
					object obj32 = num4 ^ num4;
					object obj33 = num4 & obj32;
					bool flag19 = (nint)obj33 < 0;
					bool flag20 = flag17 == flag19;
					object obj34 = !flag18;
					object obj35 = flag20 & obj34;
					object obj36 = ~obj35;
					if (obj36 == null)
					{
						double num15 = 1.0;
					}
					else
					{
						double num15 = -1.0;
					}
				}
				else
				{
					if (!(num12 < num14))
					{
						goto IL_0645;
					}
					bool flag21 = num < 0f;
					bool flag22 = num == 0f;
					object obj37 = num ^ num;
					object obj38 = num & obj37;
					bool flag23 = (nint)obj38 < 0;
					bool flag24 = flag21 == flag23;
					object obj39 = !flag22;
					object obj40 = flag24 & obj39;
					object obj41 = ~obj40;
					if (obj41 == null)
					{
						double num16 = 1.0;
					}
					else
					{
						double num16 = -1.0;
					}
					num13 = num12;
				}
				goto IL_095d;
			}
		}
		float num17 = num2 - num;
		float num18 = num6 - num4;
		((Vector3*)(nint)aabbExtents)->x = num;
		((Vector3*)(nint)aabbExtents)->y = num4;
		float num19 = num10 - num8;
		float num20 = num17 * num17;
		float num21 = num18 * num18;
		((Vector3*)(nint)aabbExtents)->z = num8;
		float num22 = num20 + num21;
		float num23 = num19 * num19;
		float num24 = num22 + num23;
		object obj43 = default;
		object obj42 = obj43 * obj43;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num24) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj42))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj44 = 0;
			object obj45 = obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v6+E4]");
			bool flag25 = (nint)0 == 0;
			object obj46 = !flag25;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aabbExtents @ X0 (UnityEngine.Vector3)+C]");
				num17 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aabbExtents @ X0 (UnityEngine.Vector3)+10]");
				num18 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aabbExtents @ X0 (UnityEngine.Vector3)+14]");
				num19 = 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			double num25 = 1.0 / (double)num8;
			double num26 = (double)num24 * num25;
			double num27 = (double)num17 * num25;
			double num28 = (double)num18 * num25;
			double num29 = (double)num19 * num25;
			double num30 = (double)obj43 - num26;
			goto IL_0976;
		}
		((Vector3*)(nint)aabbExtents)->x = 0f;
		((Vector3*)(nint)aabbExtents)->z = 0f;
		_ = 0;
		_ = 0;
		return false;
		IL_095d:
		float num31 = num13 + (float)obj43;
		goto IL_0976;
		IL_0645:
		bool flag26 = num10 < 0f;
		bool flag27 = num10 == 0f;
		object obj47 = num10 ^ num10;
		object obj48 = num10 & obj47;
		bool flag28 = (nint)obj48 < 0;
		bool flag29 = flag26 == flag28;
		object obj49 = !flag27;
		object obj50 = flag29 & obj49;
		object obj51 = ~obj50;
		if (obj51 == null)
		{
			double num32 = 1.0;
		}
		else
		{
			double num32 = -1.0;
		}
		num13 = num14;
		goto IL_095d;
		IL_0976:
		return true;
	}

	internal unsafe static bool LocalSphereCapsuleIntersection(Vector3 capsuleTopCenter, Vector3 capsuleBottomCenter, float capsuleRadius, Vector3 sphereCenter, float sphereRadius, out SnapshotHistoryDraw.ContactData contactData)
	{
		//IL_03ca: Expected Obj, but got I
		//IL_040e: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I
		//IL_0446: Expected Obj, but got I4
		//IL_0173: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I4
		//IL_02f7: Expected native int or pointer, but got VT
		//IL_0305: Expected native int or pointer, but got VT
		//IL_0376: Expected Obj, but got I4
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected I4, but got Unknown
		//IL_021b: Expected native int or pointer, but got VT
		//IL_0228: Expected native int or pointer, but got VT
		//IL_0235: Expected native int or pointer, but got VT
		//IL_034f: Expected Obj, but got I4
		Vector3 vector = ClosestPtPointSegment(capsuleTopCenter, capsuleBottomCenter, sphereCenter);
		object obj2 = default;
		object obj = obj2 - obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj3 = 0;
		object obj5 = default;
		object obj4 = obj5 - obj5;
		object obj6 = obj3;
		object obj8 = default;
		object obj7 = obj8 - obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = obj * obj;
		object obj11 = obj4 * obj4;
		object obj12 = obj10 + obj11;
		object obj13 = obj7 * obj7;
		object obj14 = obj13 + obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		object obj16;
		object obj17;
		object obj18;
		if ((nint)obj14 > 0)
		{
			obj15 = obj / obj14;
			obj16 = obj4 / obj14;
			obj17 = obj7 / obj14;
			obj18 = obj15;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj19 = 0;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v19+A0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v20+4]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v20+8]");
			obj17 = 0;
			obj18 = obj21;
		}
		object obj22 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj23 = !flag2;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj25 = default;
		object obj26 = default;
		object obj24 = obj25 + obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
		object obj27 = !flag3;
		object obj28 = obj7 - obj24;
		bool flag4 = obj28 == null;
		object obj29 = !flag4;
		object obj30 = obj27 & obj29;
		if (obj30 == null)
		{
			object obj31 = obj16 * obj25;
			object obj32 = obj18 * obj25;
			object obj33 = obj17 * obj25;
			float num = (float)obj5 + (float)obj31;
			float num2 = (float)obj2 + (float)obj32;
			float num3 = (float)obj8 + (float)obj33;
			((Vector3*)(nint)capsuleTopCenter)->x = num2;
			((Vector3*)(nint)capsuleTopCenter)->y = num;
			((Vector3*)(nint)capsuleTopCenter)->z = num3;
			object obj34 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v12+E4]");
			bool flag5 = (nint)0 == 0;
			object obj35 = !flag5;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num4 = num2 - (float)obj2;
			float num5 = num - (float)obj5;
			float num6 = num3 - (float)obj8;
			float num7 = num4 * num4;
			float num8 = num5 * num5;
			float num9 = num7 + num8;
			float num10 = num6 * num6;
			float num11 = num10 + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float num12 = (float)obj26 - num11;
		}
		else
		{
			((Vector3*)(nint)capsuleTopCenter)->x = 0f;
			((Vector3*)(nint)capsuleTopCenter)->z = 0f;
			_ = 0;
			_ = 0;
		}
		bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
		object obj36 = !flag6;
		object obj37 = obj7 - obj24;
		bool flag7 = obj37 == null;
		object obj38 = ~obj36;
		return (byte)((obj38 | flag7) ? 1 : 0) != 0;
	}

	internal unsafe static bool LocalRayCapsuleIntersection(Vector3 capsuleTopCenter, Vector3 capsuleBottomCenter, float capsuleRadius, Vector3 rayLocalOrigin, Vector3 rayLocalDir, float maxDistance, out Vector3 point, out Vector3 normal, out float distance)
	{
		//IL_0026: Invalid comparison between F4 and I4
		//IL_0035: Invalid comparison between F4 and I4
		//IL_0048: Expected Obj, but got F4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_007d: Expected Obj, but got I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected I4, but got Unknown
		//IL_0092: Invalid comparison between F4 and Obj
		//IL_00a3: Expected Obj, but got I4
		//IL_00bb: Invalid comparison between F4 and I4
		//IL_00cc: Expected Obj, but got I4
		//IL_022d: Expected native int or pointer, but got VT
		//IL_023b: Expected native int or pointer, but got VT
		//IL_0249: Expected F4, but got I4
		//IL_0304: Expected native int or pointer, but got VT
		//IL_016d: Expected native int or pointer, but got VT
		//IL_017a: Expected native int or pointer, but got VT
		//IL_0187: Expected native int or pointer, but got VT
		//IL_033c: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I4
		//IL_01cf: Invalid comparison between F4 and I
		//IL_025e: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I
		//IL_027e: Expected F4, but got Obj
		//IL_028e: Expected F4, but got I
		//IL_029e: Expected F4, but got I
		//IL_02d0: Expected native int or pointer, but got VT
		//IL_02dd: Expected native int or pointer, but got VT
		//IL_02ea: Expected native int or pointer, but got VT
		float num2 = default;
		float num = RayCapsuleIntersect(capsuleTopCenter, capsuleBottomCenter, rayLocalOrigin, rayLocalDir, num2);
		bool flag = num < 0f;
		bool flag2 = num == 0f;
		object obj = num ^ num;
		object obj2 = num & obj;
		bool flag3 = (nint)obj2 < 0;
		bool flag4 = flag == flag3;
		object obj3 = !flag2;
		bool flag5 = (byte)((flag4 & obj3) ? 1 : 0) != 0;
		object obj4 = default;
		bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
		object obj5 = !flag6;
		float num3 = num - (float)obj4;
		bool flag7 = num3 == 0f;
		object obj6 = !flag7;
		object obj7 = obj5 & obj6;
		object obj8 = ~obj7;
		bool flag8 = obj8 != null && flag5;
		float x2;
		if (flag8)
		{
			object obj9 = default;
			float num4 = (float)obj9 * num;
			object obj10 = default;
			float num5 = (float)obj10 * num;
			object obj11 = default;
			float num6 = (float)obj11 * num;
			float num7 = num2 + num4;
			object obj12 = default;
			float num8 = (float)obj12 + num5;
			object obj13 = default;
			float num9 = (float)obj13 + num6;
			((Vector3*)(nint)capsuleTopCenter)->x = num7;
			((Vector3*)(nint)capsuleTopCenter)->y = num8;
			((Vector3*)(nint)capsuleTopCenter)->z = num9;
			Vector3 vector = ClosestPtPointSegment(capsuleTopCenter, capsuleBottomCenter, rayLocalOrigin);
			float num10 = num7 - num7;
			float num11 = num8 - num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj14 = 0;
			float num12 = num9 - num9;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v6+E4]");
			bool flag9 = (nint)0 == 0;
			object obj16 = !flag9;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			float x;
			float y;
			float z;
			if (num9 > 0f)
			{
				x = num10 / num9;
				y = num11 / num9;
				z = num12 / num9;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj17 = 0;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+A0]");
				object obj19 = 0;
				x = (float)obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v15+4]");
				y = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v15+8]");
				z = 0f;
			}
			((Vector3*)(nint)capsuleBottomCenter)->x = x;
			((Vector3*)(nint)capsuleBottomCenter)->y = y;
			((Vector3*)(nint)capsuleBottomCenter)->z = z;
			x2 = num;
		}
		else
		{
			_ = 0;
			_ = 0;
			((Vector3*)(nint)capsuleBottomCenter)->z = 0f;
			((Vector3*)(nint)capsuleBottomCenter)->x = 0f;
			x2 = 0f;
		}
		((Vector3*)(nint)rayLocalOrigin)->x = x2;
		return flag8;
	}

	internal unsafe static bool LocalAABBCapsuleIntersection(Vector3 localCapsuleCenter, Vector3 localCapsulePointA, Vector3 localCapsulePointB, float capsuleRadius, Vector3 aabbExtents, out SnapshotHistoryDraw.ContactData contactData)
	{
		//IL_007c: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I4
		//IL_0092: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I4
		//IL_0e6d: Expected Obj, but got I
		//IL_023b: Invalid comparison between F4 and I4
		//IL_024a: Invalid comparison between F4 and I4
		//IL_025d: Expected Obj, but got F4
		//IL_026a: Expected Obj, but got F4
		//IL_029f: Expected Obj, but got I4
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_0eb4: Expected Obj, but got I4
		//IL_0ee8: Expected VT, but got Obj
		//IL_0f0a: Expected Obj, but got I4
		//IL_0f1a: Expected I4, but got F4
		//IL_0a41: Invalid comparison between F4 and I
		//IL_0b53: Invalid comparison between F4 and Obj
		//IL_0b64: Expected Obj, but got I4
		//IL_0b7c: Invalid comparison between F4 and I4
		//IL_0b93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Expected Obj, but got Unknown
		//IL_0371: Expected Obj, but got I
		//IL_0389: Expected Obj, but got I
		//IL_0399: Expected F4, but got I
		//IL_03ff: Expected I4, but got F4
		//IL_0a6b: Expected Obj, but got F4
		//IL_0a73: Expected native int or pointer, but got VT
		//IL_0a80: Expected native int or pointer, but got VT
		//IL_0a8d: Expected native int or pointer, but got VT
		//IL_04be: Invalid comparison between F4 and Obj
		//IL_04cf: Expected Obj, but got I4
		//IL_04e7: Invalid comparison between F4 and I4
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected Obj, but got Unknown
		//IL_0f52: Expected Obj, but got I4
		//IL_0c6e: Invalid comparison between F4 and I
		//IL_0554: Expected VT, but got I4
		//IL_0554: Expected VT, but got I4
		//IL_0554: Expected VT, but got I4
		//IL_0554: Expected VT, but got I4
		//IL_0754: Expected Obj, but got I
		//IL_076c: Expected Obj, but got I
		//IL_0774: Expected F4, but got Obj
		//IL_0784: Expected F4, but got I
		//IL_0f99: Expected Obj, but got I4
		//IL_058b: Expected VT, but got I4
		//IL_058b: Expected VT, but got I4
		//IL_058b: Expected VT, but got I4
		//IL_058b: Expected VT, but got I4
		//IL_05a8: Expected Obj, but got I4
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected Obj, but got Unknown
		//IL_0c98: Expected Obj, but got F4
		//IL_0ca0: Expected native int or pointer, but got VT
		//IL_0cad: Expected native int or pointer, but got VT
		//IL_0cba: Expected native int or pointer, but got VT
		//IL_0d2e: Invalid comparison between F4 and I
		//IL_0871: Expected Obj, but got I
		//IL_0889: Expected Obj, but got I
		//IL_0891: Expected F4, but got Obj
		//IL_08a1: Expected F4, but got I
		//IL_0bbf: Expected Obj, but got I4
		//IL_0bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf1: Expected Obj, but got Unknown
		//IL_0d58: Expected Obj, but got F4
		//IL_0d60: Expected native int or pointer, but got VT
		//IL_0d6d: Expected native int or pointer, but got VT
		//IL_0d7a: Expected native int or pointer, but got VT
		//IL_07ac: Expected Obj, but got I4
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected Obj, but got Unknown
		//IL_0624: Expected Obj, but got I4
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected Obj, but got Unknown
		//IL_066d: Expected native int or pointer, but got VT
		//IL_067b: Expected native int or pointer, but got VT
		//IL_0ddf: Expected Obj, but got I4
		//IL_08be: Expected Obj, but got I
		//IL_08d6: Expected Obj, but got I
		//IL_08ee: Expected Obj, but got I
		//IL_0e3d: Expected native int or pointer, but got VT
		//IL_0e4a: Expected native int or pointer, but got VT
		//IL_0857: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Expected Obj, but got Unknown
		float num2 = default;
		float num = 0f - num2;
		float num3 = default;
		object obj;
		if (num3 < num)
		{
			num3 = num;
			obj = 0;
		}
		else if (num3 > num2)
		{
			num3 = num2;
			obj = 0;
		}
		else
		{
			obj = 1;
		}
		float num5 = default;
		float num4 = 0f - num5;
		float num6 = default;
		if (num6 < num4)
		{
			num6 = num4;
			obj = 0;
		}
		else if (num6 > num5)
		{
			num6 = num5;
			obj = 0;
		}
		float num8 = default;
		float num7 = 0f - num8;
		float num9 = default;
		float num10;
		if (num9 < num7)
		{
			obj = 0;
			num10 = num7;
		}
		else
		{
			bool flag = !(num9 > num8);
			num10 = num9;
			if (!flag)
			{
				obj = 0;
				num10 = num8;
			}
		}
		float num11 = default;
		bool flag2 = num11 < num;
		float num12 = num;
		if (!flag2)
		{
			bool flag3 = !(num11 > num2);
			num12 = num11;
			if (!flag3)
			{
				num12 = num2;
			}
		}
		float num13 = default;
		bool flag4 = num13 < num4;
		float num14 = num4;
		if (!flag4)
		{
			bool flag5 = !(num13 > num5);
			num14 = num13;
			if (!flag5)
			{
				num14 = num5;
			}
		}
		float num15 = default;
		bool flag6 = num15 < num7;
		float num16 = num7;
		if (!flag6)
		{
			bool flag7 = !(num15 > num8);
			num16 = num15;
			if (!flag7)
			{
				num16 = num8;
			}
		}
		float num17 = default;
		if (!(num17 < num))
		{
			bool flag8 = !(num17 > num2);
			num = num17;
			if (!flag8)
			{
				num = num2;
			}
		}
		float num18 = default;
		if (!(num18 < num4))
		{
			bool flag9 = !(num18 > num5);
			num4 = num18;
			if (!flag9)
			{
				num4 = num5;
			}
		}
		float num19 = default;
		if (!(num19 < num7))
		{
			float num20 = num19 - num8;
			bool flag10 = num20 < 0f;
			bool flag11 = num20 == 0f;
			object obj2 = num19 ^ num8;
			object obj3 = num19 ^ num20;
			object obj4 = obj2 & obj3;
			bool flag12 = (nint)obj4 < 0;
			bool flag13 = flag10 == flag12;
			object obj5 = !flag13;
			object obj6 = obj5 | flag11;
			object obj7 = ~obj6;
			num7 = ((obj7 != null) ? num8 : num19);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj8 = 0;
		if (obj == null)
		{
			float num21 = num13;
			float num22 = num15;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v5+E4]");
			float num23;
			float num24;
			float num25;
			float num26;
			float num27;
			if ((nint)0 != 0)
			{
				num23 = num11;
				num24 = num4;
				num25 = num16;
				num26 = num14;
				num27 = num12;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num23 = num11;
				num24 = num4;
				num25 = num16;
				num26 = num14;
				num27 = num12;
				num21 = num13;
				num22 = num15;
			}
			float num28 = num23 - num27;
			float num29 = num21 - num26;
			float num30 = num22 - num25;
			float num31 = num28 * num28;
			float num32 = num29 * num29;
			float num33 = num31 + num32;
			float num34 = num30 * num30;
			float num35 = num33 + num34;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Vector3 pointA = (Vector3)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v9 (UnityEngine.Vector3)+E4]");
			bool flag14 = (nint)0 == 0;
			object obj10 = !flag14;
			object obj12 = default;
			object obj11 = obj12;
			bool flag15 = (byte)(int)num23 != 0;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj12;
				flag15 = (byte)(int)num11 != 0;
				num24 = num4;
				num25 = num16;
				num26 = num14;
				num27 = num12;
				num21 = num13;
				num22 = num15;
			}
			bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num35) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
			object obj13 = !flag16;
			float num36 = num35 - (float)obj11;
			bool flag17 = num36 == 0f;
			object obj14 = ~obj13;
			object obj15 = obj14 | flag17;
			if (obj15 == null)
			{
				float num37 = num18 - num24;
				float num38 = num19 - num7;
				float num39 = num17 - num;
				float num40 = num37 * num37;
				float num41 = num38 * num38;
				float num42 = num39 * num39;
				float num43 = num42 + num40;
				float num44 = num43 + num41;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				bool flag18 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num44) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
				object obj16 = !flag18;
				float num45 = num44 - (float)obj11;
				bool flag19 = num45 == 0f;
				object obj17 = ~obj16;
				object obj18 = obj17 | flag19;
				if (obj18 == null)
				{
					Vector3 aABBSupportPoint = GetAABBSupportPoint(pointA, localCapsulePointA, localCapsulePointB);
					IntPtr intPtr = default;
					bool clampA = default;
					bool clampB = default;
					(Vector3, Vector3, float) tuple = ClosestDistanceBetweenLines((Vector3)1, (Vector3)0, (Vector3)0, (Vector3)0, clampAll: false, (byte)(nint)intPtr != 0, clampA, clampB, flag15);
					(Vector3, Vector3, float) tuple2 = ClosestDistanceBetweenLines((Vector3)1, (Vector3)0, (Vector3)0, (Vector3)0, clampAll: false, (byte)(nint)intPtr != 0, clampA, clampB, flag15);
					object obj19 = default;
					bool flag20 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
					object obj20 = !flag20;
					object obj21 = obj19 - obj19;
					bool flag21 = obj21 == null;
					object obj22 = ~obj20;
					object obj23 = obj22 | flag21;
					object obj24 = ~obj23;
					object obj26 = default;
					object obj25 = ((obj24 != null) ? obj26 : obj26);
					bool flag22 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
					object obj27 = !flag22;
					object obj28 = obj19 - obj11;
					bool flag23 = obj28 == null;
					object obj29 = ~obj27;
					object obj30 = obj29 | flag23;
					if (obj30 == null)
					{
						bool flag24 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
						object obj31 = !flag24;
						object obj32 = obj19 - obj11;
						bool flag25 = obj32 == null;
						object obj33 = ~obj31;
						object obj34 = obj33 | flag25;
						if (obj34 == null)
						{
							((Vector3*)(nint)localCapsuleCenter)->x = 0f;
							((Vector3*)(nint)localCapsuleCenter)->z = 0f;
							_ = 0;
							_ = 0;
							return false;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					bool flag26 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
					object obj35 = !flag26;
					object obj36 = obj19 - obj19;
					bool flag27 = obj36 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					object obj37 = ~obj35;
					object obj38 = obj37 | flag27;
					object obj39 = ~obj38;
					object obj41 = default;
					object obj40 = ((obj39 != null) ? obj41 : obj41);
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					object obj42 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
					object obj43 = obj8;
					object obj45 = default;
					object obj46 = default;
					object obj44 = obj45 - obj46;
					object obj47 = obj40 - obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1078 @ X0_v40+E4]");
					bool flag28 = (nint)0 == 0;
					object obj48 = !flag28;
					if (obj48 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj42 = obj11;
					}
					object obj49 = obj47 * obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					object obj50;
					object obj51;
					if ((nint)obj49 > 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						obj50 = obj47 / obj49;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						obj51 = obj44 / 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
						object obj52 = 0;
						object obj53 = obj52;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1097 @ X8_v51+A0]");
						object obj54 = 0;
						obj51 = obj54;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1098 @ X8_v52+8]");
						obj50 = 0;
					}
					object obj56 = default;
					object obj55 = obj51 * obj56;
					object obj57 = obj50 * obj42;
					_ = 0;
					float x = (float)obj46 + (float)obj55;
					float z = (float)obj25 + (float)obj57;
					((Vector3*)(nint)localCapsuleCenter)->x = x;
					((Vector3*)(nint)localCapsuleCenter)->z = z;
					return true;
				}
				object obj58 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ X0_v24+E4]");
				bool flag29 = (nint)0 == 0;
				object obj59 = !flag29;
				if (obj59 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num24 = num4;
				}
				float num46 = num24 * num24;
				float num47 = num * num;
				float num48 = num47 + num46;
				float num49 = num7 * num7;
				float num50 = num48 + num49;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				float num51;
				float x2;
				if (num50 > 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					num51 = num7 / num50;
					float num52 = num / num;
					x2 = num;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj60 = 0;
					object obj61 = obj60;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X8_v35+A0]");
					object obj62 = 0;
					float num52 = (float)obj62;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ X8_v36+8]");
					num51 = 0f;
					x2 = num;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				object obj63 = 0f - num51;
				((Vector3*)(nint)localCapsuleCenter)->x = x2;
				((Vector3*)(nint)localCapsuleCenter)->y = num24;
				((Vector3*)(nint)localCapsuleCenter)->z = num7;
			}
			else
			{
				object obj64 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X0_v13+E4]");
				bool flag30 = (nint)0 == 0;
				object obj65 = !flag30;
				if (obj65 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num25 = num16;
					num26 = num14;
					num27 = num12;
				}
				float num53 = num27 * num27;
				float num54 = num26 * num26;
				float num55 = num53 + num54;
				float num56 = num25 * num25;
				float num57 = num55 + num56;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				float num58;
				if (num57 > 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					num58 = num25 / num57;
					float num52 = num27 / (float)(flag15 ? 1 : 0);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj66 = 0;
					object obj67 = obj66;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X8_v22+A0]");
					object obj68 = 0;
					float num52 = (float)obj68;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v23+8]");
					num58 = 0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				object obj63 = 0f - num58;
				((Vector3*)(nint)localCapsuleCenter)->x = num27;
				((Vector3*)(nint)localCapsuleCenter)->y = num26;
				((Vector3*)(nint)localCapsuleCenter)->z = num25;
			}
		}
		else
		{
			float y = num6;
			float x3 = num3;
			object obj69 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v61+E4]");
			bool flag31 = (nint)0 == 0;
			object obj70 = !flag31;
			if (obj70 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				y = num6;
				x3 = num3;
			}
			float num59 = num10 * num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			float num60;
			if (num59 > 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				num60 = num10 / num59;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj71 = 0;
				object obj72 = obj71;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v68+A0]");
				object obj73 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v69+8]");
				num60 = 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			object obj74 = 0f - num60;
			((Vector3*)(nint)localCapsuleCenter)->x = x3;
			((Vector3*)(nint)localCapsuleCenter)->y = y;
			((Vector3*)(nint)localCapsuleCenter)->z = num10;
		}
		_ = 0;
		return true;
	}

	private static Vector3 GetAABBSupportPoint(Vector3 pointA, Vector3 pointB, Vector3 extents)
	{
		//IL_0024: Expected Obj, but got I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_01df: Invalid comparison between F8 and I4
		//IL_01f0: Expected Obj, but got I4
		//IL_0209: Invalid comparison between F8 and I4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_024b: Invalid comparison between F8 and I4
		//IL_025c: Expected Obj, but got I4
		//IL_0275: Invalid comparison between F8 and I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_011d: Expected Obj, but got I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0190: Expected Obj, but got I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		object obj = default;
		bool flag = (nint)obj < 1;
		object obj2 = !flag;
		object obj3 = obj - 1;
		bool flag2 = obj3 == null;
		object obj4 = ~obj2;
		object obj5 = obj4 | flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			object obj6 = default;
			bool flag3 = (nint)obj6 < 1;
			object obj7 = !flag3;
			object obj8 = obj6 - 1;
			bool flag4 = obj8 == null;
			object obj9 = ~obj7;
			object obj10 = obj9 | flag4;
			object obj11 = ~obj10;
			if (obj11 != null)
			{
			}
		}
		double num = default;
		object obj16 = default;
		object obj17 = default;
		object obj18 = default;
		object obj27 = default;
		object obj31;
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			bool flag5 = num < 1.0;
			object obj12 = !flag5;
			double num2 = num - 1.0;
			bool flag6 = num2 == 0.0;
			object obj13 = ~obj12;
			object obj14 = obj13 | flag6;
			if (obj14 == null)
			{
				object obj15 = obj16 - obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
				num = (double)obj15 * 0.5;
				bool flag7 = (nint)obj18 < 1;
				object obj19 = !flag7;
				object obj20 = obj18 - 1;
				bool flag8 = obj20 == null;
				object obj21 = ~obj19;
				object obj22 = obj21 | flag8;
				object obj23 = ~obj22;
				if (obj23 != null)
				{
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			bool flag9 = num < 1.0;
			object obj24 = !flag9;
			double num3 = num - 1.0;
			bool flag10 = num3 == 0.0;
			object obj25 = ~obj24;
			object obj26 = obj25 | flag10;
			if (obj26 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			bool flag11 = (nint)obj27 < 1;
			object obj28 = !flag11;
			object obj29 = obj27 - 1;
			bool flag12 = obj29 == null;
			object obj30 = ~obj28;
			obj31 = obj30 | flag12;
		}
		while (obj31 == null);
		return pointA;
	}

	internal unsafe static bool ClampPointToAABB(Vector3 point, Vector3 aabbExtents, out Vector3 clampedPoint)
	{
		//IL_0021: Invalid comparison between F4 and I4
		//IL_0030: Invalid comparison between F4 and I4
		//IL_0043: Expected Obj, but got F4
		//IL_0050: Expected Obj, but got F4
		//IL_0085: Expected Obj, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_0240: Expected Obj, but got I4
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_0161: Invalid comparison between F4 and I4
		//IL_0170: Invalid comparison between F4 and I4
		//IL_0183: Expected Obj, but got F4
		//IL_0190: Expected Obj, but got F4
		//IL_01c5: Expected Obj, but got I4
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_032b: Expected Obj, but got I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_02ee: Expected native int or pointer, but got VT
		//IL_02fb: Expected native int or pointer, but got VT
		//IL_0308: Expected native int or pointer, but got VT
		float num2 = default;
		float num = 0f - num2;
		float num4 = default;
		float num3 = num4 - num2;
		bool flag = num3 < 0f;
		bool flag2 = num3 == 0f;
		object obj = num4 ^ num2;
		object obj2 = num4 ^ num3;
		object obj3 = obj & obj2;
		bool flag3 = (nint)obj3 < 0;
		bool flag4 = flag == flag3;
		object obj4 = !flag4;
		object obj5 = obj4 | flag2;
		object obj6 = ~obj5;
		float num5 = ((obj6 != null) ? num2 : num4);
		float num7 = default;
		float num6 = 0f - num7;
		bool flag5 = flag == flag3;
		object obj7 = !flag5;
		object obj8 = obj7 | flag2;
		object obj9 = ~obj8;
		bool flag6 = obj9 == null;
		float x = ((!(num4 < num)) ? num5 : num);
		if (num4 < num)
		{
			flag6 = false;
		}
		float num8 = default;
		if (!(num8 < num6))
		{
			bool flag7 = !(num8 > num7);
			num6 = num8;
			if (flag7)
			{
				goto IL_02be;
			}
			num6 = num7;
		}
		flag6 = false;
		goto IL_02be;
		IL_02be:
		float num10 = default;
		float num9 = 0f - num10;
		float num11 = default;
		bool result;
		if (num11 < num9)
		{
			result = false;
		}
		else
		{
			float num12 = num11 - num10;
			bool flag8 = num12 < 0f;
			bool flag9 = num12 == 0f;
			object obj10 = num11 ^ num10;
			object obj11 = num11 ^ num12;
			object obj12 = obj10 & obj11;
			bool flag10 = (nint)obj12 < 0;
			bool flag11 = flag8 == flag10;
			object obj13 = !flag11;
			object obj14 = obj13 | flag9;
			object obj15 = ~obj14;
			num9 = ((obj15 != null) ? num10 : num11);
			bool flag12 = flag8 == flag10;
			object obj16 = !flag12;
			object obj17 = obj16 | flag9;
			object obj18 = ~obj17;
			result = obj18 == null && flag6;
		}
		((Vector3*)(nint)point)->x = x;
		((Vector3*)(nint)point)->y = num6;
		((Vector3*)(nint)point)->z = num9;
		return result;
	}

	public unsafe static (Vector3, Vector3, float) ClosestDistanceBetweenLines(Vector3 a0, Vector3 a1, Vector3 b0, Vector3 b1, bool clampAll = default(bool), bool clampA0 = default(bool), bool clampA1 = default(bool), bool clampB0 = default(bool), bool clampB1 = default(bool))
	{
		//IL_0cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc6: Expected Obj, but got Unknown
		//IL_140f: Expected Obj, but got I4
		//IL_0d13: Expected Obj, but got I
		//IL_000e: Expected VT, but got I4
		//IL_0017: Expected VT, but got I4
		//IL_0020: Expected VT, but got I4
		//IL_1433: Expected Obj, but got I4
		//IL_144f: Expected Obj, but got I
		//IL_1471: Expected Obj, but got I4
		//IL_1499: Expected Obj, but got I
		//IL_14c5: Expected Obj, but got I
		//IL_14fb: Expected Obj, but got I
		//IL_151b: Invalid comparison between F4 and I4
		//IL_152a: Invalid comparison between F4 and I4
		//IL_1540: Unknown result type (might be due to invalid IL or missing references)
		//IL_1545: Expected Obj, but got Unknown
		//IL_1552: Expected Obj, but got F4
		//IL_1587: Expected Obj, but got I4
		//IL_158f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1594: Expected Obj, but got Unknown
		//IL_0086: Expected F4, but got I
		//IL_02c4: Expected Obj, but got VT
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_048f: Expected I, but got F4
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected I4, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected I, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_15fd: Expected Obj, but got I4
		//IL_0564: Invalid comparison between F4 and I4
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected Obj, but got Unknown
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected Obj, but got Unknown
		//IL_135a: Expected VT, but got Obj
		//IL_136d: Expected Obj, but got I4
		//IL_137d: Expected VT, but got Ref
		//IL_070c: Invalid comparison between F4 and I4
		//IL_071b: Invalid comparison between F4 and I4
		//IL_072e: Expected Obj, but got F4
		//IL_073b: Expected Obj, but got F4
		//IL_0770: Expected Obj, but got I4
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Expected Obj, but got Unknown
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Expected Obj, but got Unknown
		//IL_102d: Expected Obj, but got I
		//IL_1054: Expected Obj, but got I
		//IL_016b: Invalid comparison between F4 and I4
		//IL_017c: Expected Obj, but got I4
		//IL_0185: Invalid comparison between F4 and I4
		//IL_01f0: Expected Obj, but got I4
		//IL_1069: Expected native int or pointer, but got VT
		//IL_0f89: Invalid comparison between F4 and I4
		//IL_0f97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9c: Expected Obj, but got Unknown
		//IL_0fa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faa: Expected Obj, but got Unknown
		//IL_165c: Expected Obj, but got I4
		//IL_081c: Invalid comparison between F4 and I4
		//IL_082b: Invalid comparison between F4 and I4
		//IL_083e: Expected Obj, but got F4
		//IL_084b: Expected Obj, but got F4
		//IL_0880: Expected Obj, but got I4
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_088d: Expected Obj, but got Unknown
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected Obj, but got Unknown
		//IL_06d5: Expected VT, but got Obj
		//IL_06e7: Expected F4, but got Obj
		//IL_06ef: Expected VT, but got Ref
		//IL_0214: Invalid comparison between F4 and I4
		//IL_1089: Invalid comparison between F4 and I4
		//IL_10a7: Invalid comparison between F4 and I4
		//IL_10b6: Invalid comparison between F4 and I4
		//IL_10c9: Expected Obj, but got F4
		//IL_10d6: Expected Obj, but got F4
		//IL_110b: Expected Obj, but got I4
		//IL_1113: Unknown result type (might be due to invalid IL or missing references)
		//IL_1118: Expected Obj, but got Unknown
		//IL_1120: Unknown result type (might be due to invalid IL or missing references)
		//IL_1125: Expected Obj, but got Unknown
		//IL_112e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1133: Expected Obj, but got Unknown
		//IL_114d: Expected Obj, but got I4
		//IL_0604: Expected Obj, but got I4
		//IL_061c: Invalid comparison between F4 and I4
		//IL_062d: Expected Obj, but got I4
		//IL_0982: Invalid comparison between F4 and I4
		//IL_09a0: Invalid comparison between F4 and I4
		//IL_09af: Invalid comparison between F4 and I4
		//IL_09c2: Expected Obj, but got F4
		//IL_09cf: Expected Obj, but got F4
		//IL_0a04: Expected Obj, but got I4
		//IL_0a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a11: Expected Obj, but got Unknown
		//IL_0a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Expected Obj, but got Unknown
		//IL_0a38: Expected Obj, but got I4
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_123e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1243: Expected Obj, but got Unknown
		//IL_125d: Expected Obj, but got I4
		//IL_08df: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Expected Obj, but got Unknown
		//IL_1281: Expected I, but got F4
		//IL_12c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c8: Expected I, but got Unknown
		//IL_1164: Invalid comparison between F4 and I4
		//IL_1182: Invalid comparison between F4 and I4
		//IL_1191: Invalid comparison between F4 and I4
		//IL_11a4: Expected Obj, but got F4
		//IL_11b1: Expected Obj, but got F4
		//IL_11e6: Expected Obj, but got I4
		//IL_11ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f3: Expected Obj, but got Unknown
		//IL_11fe: Expected Obj, but got I4
		//IL_1214: Unknown result type (might be due to invalid IL or missing references)
		//IL_1219: Expected Obj, but got Unknown
		//IL_0a65: Expected F4, but got I4
		//IL_0b1d: Invalid comparison between F4 and I4
		//IL_0b3b: Invalid comparison between F4 and I4
		//IL_0b4a: Invalid comparison between F4 and I4
		//IL_0b5d: Expected Obj, but got F4
		//IL_0b6a: Expected Obj, but got F4
		//IL_0b9f: Expected Obj, but got I4
		//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Expected Obj, but got Unknown
		//IL_0bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb9: Expected Obj, but got Unknown
		//IL_0bd3: Expected Obj, but got I4
		//IL_0c36: Expected Obj, but got I4
		//IL_12d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12da: Expected Obj, but got Unknown
		//IL_12f4: Expected Obj, but got I4
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Expected Obj, but got Unknown
		//IL_0c80: Expected Obj, but got I4
		//IL_13bb: Expected Obj, but got I4
		//IL_1327: Expected I, but got F4
		//IL_13f8: Expected Obj, but got I4
		//IL_1672: Expected VT, but got Obj
		//IL_1684: Expected VT, but got Ref
		//IL_0f68: Expected Obj, but got I4
		//IL_0c00: Expected F4, but got I4
		//IL_1691: Expected VT, but got Obj
		//IL_16a4: Expected Obj, but got I4
		//IL_16b4: Expected VT, but got Ref
		//IL_0ff1: Expected Obj, but got I4
		//IL_15b3: Expected VT, but got Obj
		//IL_15c6: Expected Obj, but got I4
		//IL_15ce: Expected VT, but got Ref
		//IL_1613: Expected VT, but got Obj
		//IL_162d: Expected VT, but got Ref
		object obj = a0 & 1;
		bool flag = obj == null;
		Vector3 vector = a1;
		Vector3 vector2 = b0;
		Vector3 vector3 = b1;
		bool flag2 = clampAll;
		if (!flag)
		{
			vector = (Vector3)1;
			vector2 = (Vector3)1;
			vector3 = (Vector3)1;
			flag2 = true;
		}
		object obj2 = 109891584;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj3 = 0;
		float num2 = default;
		float num3 = default;
		float num = num2 - num3;
		float num5 = default;
		float num6 = default;
		float num4 = num5 - num6;
		float num8 = default;
		float num9 = default;
		float num7 = num8 - num9;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v3+E4]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num10 = num * num;
		float num11 = num4 * num4;
		float num12 = num10 + num11;
		float num13 = num7 * num7;
		nint num14 = default;
		IntPtr intPtr = num14;
		float num16 = default;
		float num15 = num16;
		bool flag3 = clampB1;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj5 = obj3;
		bool flag4 = default;
		object obj6 = (flag4 ? 1 : 0) - (clampB1 ? 1 : 0);
		float num18 = default;
		float num17 = num18 - num16;
		nint num19 = default;
		object obj7 = num19 - num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			intPtr = num14;
			num15 = num16;
			flag3 = clampB1;
		}
		float num21 = default;
		float num20 = num / num21;
		float num22 = num4 / num21;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num23 = num7 / num21;
		float num25 = default;
		float num24 = num17 / num25;
		float num26 = (float)obj7 / num25;
		float num27 = num23 * num24;
		float num28 = (float)obj6 / num25;
		float num29 = num22 * num26;
		float num30 = num20 * num26;
		float num31 = num29 - num27;
		float num32 = num20 * num24;
		float num33 = num23 * num28;
		float num34 = num22 * num28;
		float num35 = num33 - num30;
		float num36 = num32 - num34;
		float num37 = num31 * num31;
		float num38 = num35 * num35;
		float num39 = num37 + num38;
		float num40 = num36 * num36;
		float num41 = num40 + num39;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v12+A0]");
		object obj11 = 0;
		float num42 = num15 - num6;
		float num43 = num40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
		float num44 = num43 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAEB0]");
		object obj12 = 0;
		float num45 = num44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v13+4]");
		float num46 = num45 - 0f;
		bool flag6 = num46 < 0f;
		bool flag7 = num46 == 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v13+4]");
		object obj13 = num44 ^ 0;
		object obj14 = num44 ^ num46;
		object obj15 = obj13 & obj14;
		bool flag8 = (nint)obj15 < 0;
		bool flag9 = flag6 == flag8;
		object obj16 = !flag7;
		object obj17 = flag9 & obj16;
		object obj18 = ~obj17;
		float num47;
		if (obj18 == null)
		{
			num47 = num44;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v13+4]");
			num47 = 0f;
		}
		float num48 = (float)(flag3 ? 1 : 0) - num3;
		float num49 = (float)(nint)intPtr - num9;
		Vector3 item;
		(Vector3, Vector3, float) tuple;
		object obj32 = default;
		if (num30 < num47)
		{
			float num50 = num48 * num20;
			float num51 = num42 * num22;
			float num52 = num49 * num23;
			object obj19 = vector & 1;
			object obj20 = vector2 & 1;
			object obj21 = vector3 & 1;
			float num53 = num50 + num51;
			object obj22 = obj21 | flag2;
			object obj23 = obj20 | obj19;
			object obj24 = obj22 | obj23;
			float num54 = num52 + num53;
			if (obj24 != null)
			{
				float num55 = num18 - num6;
				float num56 = (float)num19 - num9;
				bool flag10 = num54 < 0f;
				object obj25 = !flag10;
				bool flag11 = num54 == 0f;
				float num57 = (float)(flag4 ? 1 : 0) - num3;
				float num58 = num55 * num22;
				float num59 = num57 * num20;
				float num60 = num59 + num58;
				float num61 = num56 * num23;
				float num62 = num61 + num60;
				object obj26 = !flag11;
				object obj27 = obj25 & obj26;
				if (obj27 == null && !(num62 < 0f))
				{
					object obj28 = obj19 & flag2;
					if (obj28 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
						if (!(num61 < num62))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD9A1]");
							bool flag12 = (nint)0 == 0;
							object obj29 = !flag12;
							if (obj29 == null)
							{
								_ = 1;
							}
							object obj30 = obj3;
							float num63 = num9 - (float)num19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X0_v49+E4]");
							bool flag13 = (nint)0 == 0;
							object obj31 = !flag13;
							if (obj31 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							item = (Vector3)obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							tuple = ((Vector3, Vector3, float))(&obj32);
						}
						else
						{
							object obj33 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X0_v57+E4]");
							bool flag14 = (nint)0 == 0;
							object obj34 = !flag14;
							if (obj34 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							item = (Vector3)obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							obj32 = 0;
							tuple = ((Vector3, Vector3, float))(&obj32);
						}
						goto IL_1059;
					}
				}
				else if (!(num54 < num21))
				{
					bool flag15 = num62 < num21;
					object obj35 = !flag15;
					float num64 = num62 - num21;
					bool flag16 = num64 == 0f;
					object obj36 = !flag16;
					object obj37 = obj35 & obj36;
					if (obj37 == null)
					{
						object obj38 = obj20 & obj21;
						if (obj38 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							if (!(num61 < num62))
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD9A1]");
								bool flag17 = (nint)0 == 0;
								object obj39 = !flag17;
								float num65 = num8;
								if (obj39 == null)
								{
									_ = 1;
									num65 = num8;
								}
								object obj40 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ X0_v33+E4]");
								bool flag18 = (nint)0 == 0;
								object obj41 = !flag18;
								if (obj41 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								item = (Vector3)obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								obj32 = 0;
								num3 = num2;
								tuple = ((Vector3, Vector3, float))(&obj32);
							}
							else
							{
								object obj42 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1101 @ X0_v41+E4]");
								bool flag19 = (nint)0 == 0;
								object obj43 = !flag19;
								if (obj43 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								item = (Vector3)obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								num3 = num2;
								tuple = ((Vector3, Vector3, float))(&obj32);
							}
							goto IL_1059;
						}
					}
				}
			}
			float num66 = num20 * num54;
			float num67 = num22 * num54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj44 = 0;
			float num68 = num23 * num54;
			object obj45 = obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v47+A0]");
			object obj46 = 0;
			object obj47 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X0_v20+E4]");
			bool flag20 = (nint)0 == 0;
			object obj48 = !flag20;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			item = (Vector3)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			num3 = (float)obj46;
			tuple = ((Vector3, Vector3, float))(&obj32);
			goto IL_1059;
		}
		float num69 = num49 * num28;
		float num70 = num48 * num26;
		object obj49 = vector2 | vector;
		float num71 = num42 * num26;
		float num72 = num49 * num24;
		object obj50 = flag2 | vector3;
		float num73 = num48 * num24;
		float num74 = num42 * num28;
		object obj51 = obj50 | obj49;
		float num75 = num69 - num70;
		float num76 = num71 - num72;
		float num77 = num73 - num74;
		float num78 = num49 * num22;
		float num79 = num49 * num20;
		float num80 = num48 * num23;
		float num81 = num48 * num22;
		float num82 = num75 * num35;
		float num83 = num42 * num23;
		float num84 = num42 * num20;
		float num85 = num76 * num31;
		float num86 = num77 * num36;
		float num87 = num79 - num80;
		float num88 = num83 - num78;
		float num89 = num81 - num84;
		float num90 = num85 + num82;
		float num91 = num87 * num35;
		float num92 = num88 * num31;
		float num93 = num89 * num36;
		float num94 = num86 + num90;
		float num95 = num92 + num91;
		float num96 = num94 / num41;
		float num97 = num93 + num95;
		float num98 = num97 / num41;
		nint num99 = (nint)(num20 * num96);
		float num100 = num22 * num96;
		float num101 = num23 * num96;
		float num102 = num3 + (float)num99;
		float num103 = num6 + num100;
		float num104 = num9 + num101;
		float num105 = num28 * num98;
		float num106 = num24 * num98;
		float num107 = num26 * num98;
		bool flag21 = (byte)(int)(flag3 + num105) != 0;
		float num108 = num15 + num106;
		nint num109 = (nint)((nint)intPtr + num107);
		object obj52 = obj51 & 1;
		if (obj52 != null)
		{
			bool flag22 = num96 < 0f;
			object obj53 = vector & flag22;
			object obj54 = obj53 & 1;
			if (obj54 != null)
			{
				num107 = num18;
				num102 = num3;
				num99 = num19;
				num103 = num6;
				num104 = num9;
			}
			else
			{
				float num110 = num96 - num21;
				bool flag23 = num110 < 0f;
				bool flag24 = num110 == 0f;
				object obj55 = num96 ^ num21;
				object obj56 = num96 ^ num110;
				object obj57 = obj55 & obj56;
				bool flag25 = (nint)obj57 < 0;
				bool flag26 = flag23 == flag25;
				object obj58 = !flag24;
				object obj59 = flag26 & obj58;
				object obj60 = vector2 & obj59;
				bool flag27 = (nint)obj60 != 1;
				num107 = num18;
				num99 = num19;
				if (!flag27)
				{
					num107 = num18;
					num102 = num2;
					num99 = num19;
					num103 = num5;
					num104 = num8;
				}
			}
			bool flag28 = num98 < 0f;
			object obj61 = vector3 & flag28;
			object obj62 = obj61 & 1;
			if (obj62 != null)
			{
				flag21 = flag3;
				num108 = num15;
				num109 = intPtr;
			}
			else
			{
				float num111 = num98 - num25;
				bool flag29 = num111 < 0f;
				bool flag30 = num111 == 0f;
				object obj63 = num98 ^ num25;
				object obj64 = num98 ^ num111;
				object obj65 = obj63 & obj64;
				bool flag31 = (nint)obj65 < 0;
				bool flag32 = flag29 == flag31;
				object obj66 = !flag30;
				object obj67 = flag32 & obj66;
				object obj68 = flag2 & obj67;
				if ((nint)obj68 == 1)
				{
					flag21 = flag4;
					num108 = num107;
					num109 = num99;
				}
			}
			bool flag33 = num96 < 0f;
			float num112 = num96 - num21;
			bool flag34 = num112 < 0f;
			bool flag35 = num112 == 0f;
			object obj69 = num96 ^ num21;
			object obj70 = num96 ^ num112;
			object obj71 = obj69 & obj70;
			bool flag36 = (nint)obj71 < 0;
			bool flag37 = flag34 == flag36;
			object obj72 = !flag35;
			object obj73 = flag37 & obj72;
			object obj74 = vector2 & obj73;
			object obj75 = obj74 & 1;
			bool flag38 = obj75 == null;
			object obj76 = !flag38;
			if (obj76 == null)
			{
				object obj77 = flag33 & vector;
				if (obj77 == null)
				{
					goto IL_115b;
				}
			}
			float num113 = num102 - (float)(flag3 ? 1 : 0);
			float num114 = num103 - num15;
			float num115 = num104 - (float)(nint)intPtr;
			float num116 = num28 * num113;
			float num117 = num24 * num114;
			float num118 = num26 * num115;
			float num119 = num117 + num116;
			float num120 = num118 + num119;
			bool flag39 = num120 < 0f;
			float num121 = num120 - num25;
			bool flag40 = num121 < 0f;
			bool flag41 = num121 == 0f;
			object obj78 = num120 ^ num25;
			object obj79 = num120 ^ num121;
			object obj80 = obj78 & obj79;
			bool flag42 = (nint)obj80 < 0;
			bool flag43 = flag40 == flag42;
			object obj81 = !flag41;
			object obj82 = flag43 & obj81;
			object obj83 = flag2 & obj82;
			bool flag44 = obj83 == null;
			object obj84 = !flag44;
			object obj85 = ~obj84;
			if (obj85 == null)
			{
				num120 = num25;
			}
			object obj86 = vector3 & flag39;
			bool flag45 = obj86 == null;
			object obj87 = !flag45;
			object obj88 = ~obj87;
			if (obj88 == null)
			{
				num120 = 0f;
			}
			num99 = (nint)(num28 * num120);
			num107 = num24 * num120;
			num96 = num26 * num120;
			flag21 = (byte)((flag3 ? 1 : 0) + num99) != 0;
			num108 = num15 + num107;
			num109 = (nint)((nint)intPtr + num96);
			goto IL_115b;
		}
		goto IL_15d3;
		IL_115b:
		bool flag46 = num98 < 0f;
		float num122 = num98 - num25;
		bool flag47 = num122 < 0f;
		bool flag48 = num122 == 0f;
		object obj89 = num98 ^ num25;
		object obj90 = num98 ^ num122;
		object obj91 = obj89 & obj90;
		bool flag49 = (nint)obj91 < 0;
		bool flag50 = flag47 == flag49;
		object obj92 = !flag50;
		object obj93 = obj92 | flag48;
		object obj94 = !flag2;
		object obj95 = obj93 | obj94;
		object obj96 = obj95 & 1;
		if (obj96 != null)
		{
			object obj97 = flag46 & vector3;
			bool flag51 = obj97 == null;
			num106 = num3;
			if (flag51)
			{
				goto IL_15d3;
			}
		}
		float num123 = (float)(flag21 ? 1 : 0) - num3;
		float num124 = num108 - num6;
		float num125 = (float)num109 - num9;
		float num126 = num20 * num123;
		float num127 = num22 * num124;
		float num128 = num23 * num125;
		float num129 = num127 + num126;
		float num130 = num128 + num129;
		bool flag52 = num130 < 0f;
		float num131 = num130 - num21;
		bool flag53 = num131 < 0f;
		bool flag54 = num131 == 0f;
		object obj98 = num130 ^ num21;
		object obj99 = num130 ^ num131;
		object obj100 = obj98 & obj99;
		bool flag55 = (nint)obj100 < 0;
		bool flag56 = flag53 == flag55;
		object obj101 = !flag54;
		object obj102 = flag56 & obj101;
		object obj103 = vector2 & obj102;
		bool flag57 = obj103 == null;
		object obj104 = !flag57;
		object obj105 = ~obj104;
		if (obj105 == null)
		{
			num130 = num21;
		}
		object obj106 = vector & flag52;
		bool flag58 = obj106 == null;
		object obj107 = !flag58;
		object obj108 = ~obj107;
		if (obj108 == null)
		{
			num130 = 0f;
		}
		num96 = num20 * num130;
		num99 = (nint)(num22 * num130);
		num98 = num23 * num130;
		num102 = num3 + num96;
		num106 = num3;
		goto IL_15d3;
		IL_15d3:
		object obj109 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X0_v11+E4]");
		bool flag59 = (nint)0 == 0;
		object obj110 = !flag59;
		if (obj110 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		item = (Vector3)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		obj32 = 0;
		num3 = num102;
		tuple = ((Vector3, Vector3, float))(&obj32);
		goto IL_1059;
		IL_1059:
		*((Vector3, Vector3, float)*)(nint)tuple = (item, b0, num3);
		object obj111 = obj32;
		return tuple;
	}

	internal static float RayCapsuleIntersect(Vector3 rayOrigin, Vector3 rayDir, Vector3 capsulePointA, Vector3 capsulePointB, float capsuleRadius)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0281: Unsupported input type for neg.
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_02d0: Invalid comparison between F8 and I4
		//IL_02df: Invalid comparison between F8 and I4
		//IL_02f2: Expected Obj, but got F8
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		//IL_0327: Expected Obj, but got I4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_0363: Invalid comparison between F8 and I4
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_039f: Invalid comparison between F8 and I4
		//IL_03b0: Expected Obj, but got I4
		//IL_03b9: Invalid comparison between F8 and I4
		//IL_03d7: Expected Obj, but got I4
		//IL_0476: Expected Obj, but got I4
		//IL_04a5: Expected Obj, but got I4
		//IL_043f: Unsupported input type for neg.
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 - obj6;
		object obj7 = capsuleRadius - obj3;
		object obj9 = default;
		object obj8 = obj9 - obj6;
		object obj11 = default;
		object obj12 = default;
		object obj10 = obj11 - obj12;
		object obj14 = default;
		object obj13 = obj14 - obj12;
		object obj15 = obj * obj;
		object obj16 = obj4 * obj4;
		object obj17 = obj7 * obj7;
		object obj18 = obj8 * obj8;
		object obj19 = obj7 * obj;
		object obj20 = obj8 * obj4;
		object obj22 = default;
		object obj21 = obj22 * obj;
		object obj24 = default;
		object obj23 = obj24 * obj4;
		object obj25 = obj22 * obj7;
		object obj26 = obj24 * obj8;
		object obj27 = obj15 + obj16;
		object obj28 = obj10 * obj10;
		object obj29 = obj17 + obj18;
		object obj30 = obj13 * obj13;
		object obj31 = obj19 + obj20;
		object obj32 = obj13 * obj10;
		object obj33 = obj21 + obj23;
		object obj34 = obj25 + obj26;
		object obj36 = default;
		object obj35 = obj36 * obj10;
		object obj37 = obj28 + obj27;
		object obj38 = obj36 * obj13;
		object obj39 = obj30 + obj29;
		object obj40 = obj32 + obj31;
		object obj41 = obj35 + obj33;
		object obj43 = default;
		object obj42 = obj43 * obj43;
		object obj44 = obj38 + obj34;
		object obj45 = obj39 * obj37;
		object obj46 = obj40 * obj40;
		object obj47 = obj41 * obj41;
		object obj48 = obj40 * obj41;
		object obj49 = obj44 * obj37;
		object obj50 = obj45 - obj46;
		object obj51 = obj42 * obj37;
		object obj52 = obj49 - obj48;
		object obj53 = obj37 - obj47;
		object obj54 = obj50 - obj51;
		object obj55 = obj52 * obj52;
		object obj56 = obj53 * obj54;
		object obj57 = obj55 - obj56;
		bool flag = (nint)obj57 < 0;
		double num = -1.0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			object obj58 = 0 - obj52;
			double num2 = (double)obj58 - -1.0;
			num = num2 / (double)obj53;
			double num3 = (double)obj41 * num;
			double num4 = (double)obj40 + num3;
			bool flag2 = num4 < 0.0;
			bool flag3 = num4 == 0.0;
			object obj59 = num4 ^ num4;
			object obj60 = num4 & obj59;
			bool flag4 = (nint)obj60 < 0;
			bool flag5 = flag2 == flag4;
			object obj61 = !flag3;
			object obj62 = flag5 & obj61;
			object obj63 = ~obj62;
			bool flag6;
			if (obj63 == null)
			{
				double num5 = num4 - (double)obj37;
				flag6 = num5 < 0.0;
			}
			else
			{
				flag6 = false;
			}
			if (!flag6)
			{
				object obj64 = capsuleRadius - obj2;
				object obj65 = obj9 - obj5;
				bool flag7 = num4 < 0.0;
				object obj66 = !flag7;
				bool flag8 = num4 == 0.0;
				object obj67 = obj14 - obj11;
				object obj68 = !flag8;
				object obj69 = obj66 & obj68;
				object obj70 = ~obj69;
				if (obj70 != null)
				{
					obj65 = obj8;
				}
				object obj71 = !flag8;
				object obj72 = obj66 & obj71;
				object obj73 = ~obj72;
				if (obj73 != null)
				{
					obj64 = obj7;
				}
				object obj74 = !flag8;
				object obj75 = obj66 & obj74;
				object obj76 = ~obj75;
				if (obj76 != null)
				{
					obj67 = obj13;
				}
				object obj77 = obj22 * obj64;
				object obj78 = obj24 * obj65;
				object obj79 = obj64 * obj64;
				object obj80 = obj65 * obj65;
				object obj81 = obj77 + obj78;
				object obj82 = obj36 * obj67;
				object obj83 = obj67 * obj67;
				object obj84 = obj79 + obj80;
				object obj85 = obj82 + obj81;
				object obj86 = obj83 + obj84;
				object obj87 = obj85 * obj85;
				object obj88 = obj42 - obj86;
				object obj89 = obj87 + obj88;
				bool flag9 = (nint)obj89 <= 0;
				num = -1.0;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					object obj90 = 0 - obj85;
					num = (double)obj90 - (double)obj89;
				}
			}
		}
		return (float)num;
	}

	internal static Vector3 ClosestPtPointSegment(Vector3 point, Vector3 a, Vector3 b)
	{
		//IL_0107: Invalid comparison between Obj and F8
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 - obj6;
		object obj8 = default;
		object obj9 = default;
		object obj7 = obj8 - obj9;
		object obj11 = default;
		object obj10 = obj11 - obj3;
		object obj13 = default;
		object obj12 = obj13 - obj6;
		object obj14 = obj * obj10;
		object obj15 = obj4 * obj12;
		object obj17 = default;
		object obj16 = obj17 - obj9;
		object obj18 = obj10 * obj10;
		object obj19 = obj12 * obj12;
		object obj20 = obj14 + obj15;
		object obj21 = obj7 * obj16;
		object obj22 = obj16 * obj16;
		object obj23 = obj18 + obj19;
		object obj24 = obj21 + obj20;
		object obj25 = obj22 + obj23;
		object obj26 = obj24 / obj25;
		if ((nint)obj26 < 0 || System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1.0))
		{
		}
		return point;
	}

	internal unsafe static bool SphereSphere(Vector3 centerA, float radiusA, Vector3 centerB, float radiusB, out Vector3 intersection, out Vector3 normal)
	{
		//IL_0027: Expected native int or pointer, but got VT
		//IL_0035: Expected native int or pointer, but got VT
		//IL_007c: Expected native int or pointer, but got VT
		//IL_0089: Expected native int or pointer, but got VT
		//IL_00a3: Expected native int or pointer, but got VT
		//IL_00dd: Invalid comparison between F4 and Obj
		//IL_01ee: Invalid comparison between F4 and I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_020e: Expected Obj, but got F4
		//IL_0284: Expected Obj, but got I
		//IL_029c: Expected Obj, but got I
		//IL_02b1: Expected F4, but got I
		//IL_02ac: Expected native int or pointer, but got VT
		//IL_02c6: Expected F4, but got I
		//IL_02c1: Expected native int or pointer, but got VT
		//IL_0171: Expected native int or pointer, but got VT
		//IL_017e: Expected native int or pointer, but got VT
		//IL_01b8: Expected native int or pointer, but got VT
		//IL_0250: Expected native int or pointer, but got VT
		//IL_025d: Expected native int or pointer, but got VT
		//IL_026a: Expected native int or pointer, but got VT
		float num2 = default;
		float num = radiusA - num2;
		float num4 = default;
		float num3 = radiusB - num4;
		((Vector3*)(nint)centerA)->z = 0f;
		((Vector3*)(nint)centerA)->x = 0f;
		object obj = default;
		float num6 = default;
		float num5 = (float)obj - num6;
		object obj3 = default;
		object obj4 = default;
		object obj2 = obj3 + obj4;
		float num7 = num * num;
		float num8 = num3 * num3;
		((Vector3*)(nint)centerB)->x = num;
		((Vector3*)(nint)centerB)->y = num3;
		object obj5 = obj2 * obj2;
		((Vector3*)(nint)centerB)->z = num5;
		float num9 = num7 + num8;
		float num10 = num5 * num5;
		float num11 = num10 + num9;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float x;
			float y;
			float z;
			if ((nint)obj2 > 1)
			{
				float num12 = num / (float)obj2;
				float num13 = num3 / (float)obj2;
				float num14 = num5 / (float)obj2;
				float num15 = num12 * (float)obj4;
				float num16 = num13 * (float)obj4;
				((Vector3*)(nint)centerB)->x = num12;
				((Vector3*)(nint)centerB)->y = num13;
				x = num2 + num15;
				y = num4 + num16;
				float num17 = num14 * (float)obj4;
				((Vector3*)(nint)centerB)->z = num14;
				z = num6 + num17;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v8+A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v9+3C]");
				((Vector3*)(nint)centerB)->x = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v9+44]");
				((Vector3*)(nint)centerB)->z = 0f;
				z = num6;
				x = num2;
				y = num4;
			}
			((Vector3*)(nint)centerA)->x = x;
			((Vector3*)(nint)centerA)->y = y;
			((Vector3*)(nint)centerA)->z = z;
		}
		float num18 = num11 - (float)obj5;
		bool flag = num18 < 0f;
		object obj9 = num11 ^ obj5;
		object obj10 = num11 ^ num18;
		object obj11 = obj9 & obj10;
		bool flag2 = (nint)obj11 < 0;
		bool flag3 = flag == flag2;
		return !flag3;
	}

	internal unsafe static bool RayAABB(ref Vector3 minB, ref Vector3 maxB, ref Vector3 origin, ref Vector3 dir, float sqrMaxdistance, out Vector3 point, out Vector3 normal, out float distance)
	{
		//IL_0034: Expected F8, but got VT
		//IL_0055: Expected Obj, but got I4
		//IL_06ca: Expected F8, but got I
		//IL_0106: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_0070: Expected F8, but got VT
		//IL_0706: Expected F8, but got I
		//IL_00ce: Expected F8, but got I
		//IL_00b0: Expected F8, but got I4
		//IL_00b9: Expected Obj, but got I4
		//IL_0151: Expected F8, but got I
		//IL_0179: Invalid comparison between F8 and I4
		//IL_0188: Invalid comparison between F8 and I4
		//IL_01ab: Expected Obj, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01f5: Expected Obj, but got I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I4
		//IL_012e: Expected F8, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_074e: Expected Obj, but got I4
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected Obj, but got Unknown
		//IL_013c: Expected Obj, but got I4
		//IL_0222: Expected F8, but got I4
		//IL_0278: Invalid comparison between VT and I4
		//IL_0289: Expected Obj, but got I4
		//IL_078b: Expected Obj, but got I4
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected Obj, but got Unknown
		//IL_0230: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got I4
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected Obj, but got Unknown
		//IL_07ed: Expected Obj, but got I4
		//IL_025c: Expected Ref, but got VT
		//IL_0a6e: Expected Obj, but got I4
		//IL_02f6: Expected Obj, but got I4
		//IL_0811: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Expected Obj, but got Unknown
		//IL_0830: Expected Obj, but got I4
		//IL_0aa7: Expected Obj, but got I4
		//IL_0344: Expected Obj, but got I4
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Expected Obj, but got Unknown
		//IL_0873: Expected Obj, but got I4
		//IL_0ad6: Invalid comparison between F8 and I4
		//IL_08a6: Invalid comparison between F8 and I4
		//IL_08b7: Expected Obj, but got I4
		//IL_08d9: Expected Obj, but got I4
		//IL_08f9: Invalid comparison between F8 and I4
		//IL_04a3: Expected Ref, but got F8
		//IL_0950: Invalid comparison between F8 and I
		//IL_0414: Expected Ref, but got F8
		//IL_0421: Invalid comparison between F8 and VT
		//IL_04b8: Invalid comparison between F8 and I
		//IL_0442: Invalid comparison between F8 and VT
		//IL_0a0a: Expected Obj, but got I4
		//IL_0a22: Invalid comparison between F8 and I4
		//IL_0a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Expected Obj, but got Unknown
		//IL_052b: Invalid comparison between F8 and I
		//IL_05ff: Invalid comparison between VT and F8
		//IL_054f: Invalid comparison between F8 and I
		//IL_069a: Expected Ref, but got F4
		//IL_06ac: Expected Ref, but got F8
		//IL_0635: Invalid comparison between I and F8
		//IL_05cc: Invalid comparison between I and F8
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)null;
		_ = 0;
		ref Vector3 reference2 = ref *(Vector3*)null;
		ref float reference3 = ref *(float*)null;
		double num = (double)minB;
		bool flag = origin < minB;
		object obj = 0;
		if (!flag)
		{
			num = (double)maxB;
			if (origin > maxB)
			{
				obj = 0;
			}
			else
			{
				num = 0.0;
				obj = 1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [minB @ X0 (UnityEngine.Vector3&)+4]");
		double num2 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ X2 (UnityEngine.Vector3&)+4]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [minB @ X0 (UnityEngine.Vector3&)+4]");
		object obj2;
		object obj3;
		if (num3 >= 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [maxB @ X1 (UnityEngine.Vector3&)+4]");
			num2 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ X2 (UnityEngine.Vector3&)+4]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [maxB @ X1 (UnityEngine.Vector3&)+4]");
			if (num4 <= 0)
			{
				obj2 = obj;
				obj3 = 1;
				num2 = 0.0;
				goto IL_06f6;
			}
		}
		obj2 = 0;
		obj3 = 0;
		goto IL_06f6;
		IL_0575:
		return false;
		IL_06f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [minB @ X0 (UnityEngine.Vector3&)+8]");
		double num5 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ X2 (UnityEngine.Vector3&)+8]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [minB @ X0 (UnityEngine.Vector3&)+8]");
		object obj4;
		if (num6 < 0)
		{
			obj4 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [maxB @ X1 (UnityEngine.Vector3&)+8]");
			num5 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ X2 (UnityEngine.Vector3&)+8]");
			double num7 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [maxB @ X1 (UnityEngine.Vector3&)+8]");
			double num8 = num7 - 0.0;
			bool flag2 = num8 < 0.0;
			bool flag3 = num8 == 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ X2 (UnityEngine.Vector3&)+8]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [maxB @ X1 (UnityEngine.Vector3&)+8]");
			object obj5 = num9 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ X2 (UnityEngine.Vector3&)+8]");
			object obj6 = 0 ^ num8;
			object obj7 = obj5 & obj6;
			bool flag4 = (nint)obj7 < 0;
			bool flag5 = flag2 == flag4;
			object obj8 = !flag5;
			object obj9 = obj8 | flag3;
			object obj10 = ~obj9;
			if (obj10 == null)
			{
				num5 = 0.0;
			}
			bool flag6 = flag2 == flag4;
			object obj11 = !flag3;
			object obj12 = flag6 & obj11;
			object obj13 = ~obj12;
			object obj14 = ((obj13 != null) ? obj2 : ((object)0));
			bool flag7 = flag2 == flag4;
			object obj15 = !flag7;
			object obj16 = obj15 | flag3;
			bool flag8 = (nint)obj14 != 1;
			obj4 = obj16;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ X2 (UnityEngine.Vector3&)+8]");
				_ = 0;
				reference = ref *(Vector3*)origin;
				return false;
			}
		}
		bool flag9 = dir == (Vector3)(object)0;
		object obj17 = !flag9;
		object obj18 = ~obj17;
		if (obj18 != null)
		{
			obj = 1;
		}
		object obj19 = obj & 1;
		bool flag10 = obj19 == null;
		object obj20 = !flag10;
		double num10 = -1.0;
		if (obj20 == null)
		{
			double num11 = num - (double)origin;
			num10 = num11 / (double)dir;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dir @ X3 (UnityEngine.Vector3&)+4]");
		bool flag11 = (nint)0 == 0;
		object obj21 = !flag11;
		object obj22 = ~obj21;
		object obj23 = ((obj22 != null) ? ((object)1) : obj3);
		object obj24 = obj23 & 1;
		bool flag12 = obj24 == null;
		object obj25 = !flag12;
		double num12 = -1.0;
		if (obj25 == null)
		{
			double num13 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ X2 (UnityEngine.Vector3&)+4]");
			double num14 = num13 - 0.0;
			double num15 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dir @ X3 (UnityEngine.Vector3&)+4]");
			num12 = num15 / 0.0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dir @ X3 (UnityEngine.Vector3&)+8]");
		bool flag13 = (nint)0 == 0;
		object obj26 = !flag13;
		object obj27 = ~obj26;
		object obj28 = ((obj27 != null) ? ((object)1) : obj4);
		object obj29 = obj28 & 1;
		bool flag14 = obj29 == null;
		object obj30 = !flag14;
		double num16 = -1.0;
		if (obj30 == null)
		{
			double num17 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ X2 (UnityEngine.Vector3&)+8]");
			double num18 = num17 - 0.0;
			double num19 = num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dir @ X3 (UnityEngine.Vector3&)+8]");
			num16 = num19 / 0.0;
		}
		double num20 = num10 - num12;
		bool flag15 = num20 < 0.0;
		double num21 = ((!(num10 < num12)) ? num10 : num12);
		double num22 = num21 - num16;
		bool flag16 = num22 < 0.0;
		object obj31 = !flag16;
		object obj32 = ~obj31;
		double num23 = ((obj32 != null) ? num16 : num21);
		object obj33 = !flag16;
		object obj34 = ~obj33;
		bool flag17 = ((obj34 != null) ? true : flag15);
		if (!(num23 < 0.0))
		{
			if (flag17)
			{
				double num24 = (double)dir * num23;
				num = (double)origin + num24;
				reference = ref *(Vector3*)num;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) < System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref minB) || System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) > System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref maxB))
				{
					goto IL_0575;
				}
				if (num10 < num12 && !(num21 < num16))
				{
					goto IL_04cc;
				}
			}
			else
			{
				reference = ref *(Vector3*)num;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dir @ X3 (UnityEngine.Vector3&)+4]");
			double num25 = 0.0 * num23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ X2 (UnityEngine.Vector3&)+4]");
			num2 = 0.0 + num25;
			double num26 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [minB @ X0 (UnityEngine.Vector3&)+4]");
			if (!(num26 < 0.0))
			{
				double num27 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [maxB @ X1 (UnityEngine.Vector3&)+4]");
				if (!(num27 > 0.0))
				{
					goto IL_04cc;
				}
			}
		}
		goto IL_0575;
		IL_04cc:
		if (!(num21 < num16))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dir @ X3 (UnityEngine.Vector3&)+8]");
			double num28 = 0.0 * num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ X2 (UnityEngine.Vector3&)+8]");
			num5 = 0.0 + num28;
			double num29 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [minB @ X0 (UnityEngine.Vector3&)+8]");
			if (!(num29 < 0.0))
			{
				double num30 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [maxB @ X1 (UnityEngine.Vector3&)+8]");
				if (!(num30 > 0.0))
				{
					goto IL_0964;
				}
			}
			goto IL_0575;
		}
		goto IL_0964;
		IL_0964:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ X2 (UnityEngine.Vector3&)+8]");
		double num31 = 0.0 - num5;
		double num32 = (double)origin - num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ X2 (UnityEngine.Vector3&)+4]");
		double num33 = 0.0 - num2;
		double num34 = num32 * num32;
		double num35 = num33 * num33;
		double num36 = num34 + num35;
		double num37 = num31 * num31;
		double num38 = num36 + num37;
		bool flag18 = num38 < (double)sqrMaxdistance;
		object obj35 = !flag18;
		double num39 = num38 - (double)sqrMaxdistance;
		bool flag19 = num39 == 0.0;
		object obj36 = ~obj35;
		object obj37 = obj36 | flag19;
		if (obj37 != null)
		{
			switch (flag17)
			{
			case true:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ X2 (UnityEngine.Vector3&)+4]");
				if (0.0 > num2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F2D1BC");
				}
				break;
			case false:
				if (origin > (object)num)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @315E6D8");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @315E71C");
				}
				break;
			default:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [origin @ X2 (UnityEngine.Vector3&)+8]");
				if (0.0 > num5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE5E70");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @315E760");
				}
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			reference2 = ref *(Vector3*)sqrMaxdistance;
			reference3 = ref *(float*)num5;
			return true;
		}
		goto IL_0575;
	}

	internal unsafe static bool RaySphereIntersection(Vector3 p1, Vector3 dir, float length, Vector3 center, float radius, out Vector3 hitPoint, out Vector3 normal, out float distance)
	{
		//IL_0089: Invalid comparison between F4 and Obj
		//IL_0223: Expected native int or pointer, but got VT
		//IL_0231: Expected native int or pointer, but got VT
		//IL_0426: Expected native int or pointer, but got VT
		//IL_0434: Expected native int or pointer, but got VT
		//IL_0442: Expected native int or pointer, but got VT
		//IL_00d2: Expected Obj, but got F4
		//IL_0115: Invalid comparison between F4 and I4
		//IL_0203: Invalid comparison between F4 and Obj
		//IL_02ce: Expected native int or pointer, but got VT
		//IL_02db: Expected native int or pointer, but got VT
		//IL_02e8: Expected native int or pointer, but got VT
		//IL_02f5: Expected native int or pointer, but got VT
		//IL_0302: Invalid comparison between F4 and Obj
		//IL_04b1: Expected Obj, but got I
		//IL_04db: Expected Obj, but got I4
		//IL_038c: Invalid comparison between F4 and I
		//IL_03e8: Expected Obj, but got I
		//IL_0400: Expected Obj, but got I
		//IL_0408: Expected F4, but got Obj
		//IL_0418: Expected F4, but got I
		//IL_0459: Expected native int or pointer, but got VT
		//IL_0466: Expected native int or pointer, but got VT
		object obj = default;
		float num = length - (float)obj;
		object obj2 = default;
		float num2 = radius - (float)obj2;
		object obj4 = default;
		object obj5 = default;
		object obj3 = obj4 - obj5;
		float num3 = num * num;
		float num4 = num2 * num2;
		object obj6 = obj3 * obj3;
		float num5 = num3 + num4;
		object obj8 = default;
		object obj7 = obj8 * obj8;
		float num6 = (float)obj6 + num5;
		object obj9 = default;
		bool result;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num6) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) && (nint)obj9 >= 1)
		{
			object obj10 = default;
			float num7 = (float)obj10 * num2;
			object obj11 = 0f - num7;
			object obj12 = default;
			float num8 = (float)obj12 * num;
			object obj14 = default;
			object obj13 = obj14 * obj3;
			float num9 = (float)obj11 - num8;
			float num10 = num9 - (float)obj13;
			if (!(num10 < 0f))
			{
				float num11 = (float)obj12 * num10;
				float num12 = (float)obj10 * num10;
				float num13 = (float)obj14 * num10;
				float num14 = length + num11;
				float num15 = radius + num12;
				float num16 = (float)obj4 + num13;
				float num17 = (float)obj - num14;
				float num18 = (float)obj2 - num15;
				float num19 = (float)obj5 - num16;
				float num20 = num17 * num17;
				float num21 = num18 * num18;
				float num22 = num20 + num21;
				float num23 = num19 * num19;
				float num24 = num23 + num22;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num24) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
				{
					float num25 = (float)obj7 - num24;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					float num26 = (float)obj12 * num25;
					float num27 = (float)obj10 * num25;
					float num28 = (float)obj14 * num25;
					float num29 = num10 - num25;
					float x = num14 - num26;
					float y = num15 - num27;
					float z = num16 - num28;
					((Vector3*)(nint)p1)->x = x;
					((Vector3*)(nint)p1)->y = y;
					((Vector3*)(nint)p1)->z = z;
					((Vector3*)(nint)center)->x = num29;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num29) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
					{
						result = false;
						goto IL_041d;
					}
					float num30 = p1.x - (float)obj;
					float num31 = p1.z - (float)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj15 = 0;
					object obj16 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v5+E4]");
					bool flag = (nint)0 == 0;
					object obj17 = !flag;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num32 = num30 * num30;
					float num33 = num31 * num31;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
					float num34 = num32 + num33;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					float z2;
					float x2;
					if (num34 > 0f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						z2 = num31 / num34;
						float num35 = num30;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						x2 = num35 / 0f;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
						object obj18 = 0;
						object obj19 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v18+A0]");
						object obj20 = 0;
						x2 = (float)obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v19+8]");
						z2 = 0f;
					}
					((Vector3*)(nint)dir)->x = x2;
					((Vector3*)(nint)dir)->z = z2;
					result = true;
					goto IL_04e9;
				}
			}
		}
		((Vector3*)(nint)p1)->z = 0f;
		((Vector3*)(nint)p1)->x = 0f;
		result = false;
		goto IL_041d;
		IL_04e9:
		return result;
		IL_041d:
		((Vector3*)(nint)dir)->z = 0f;
		((Vector3*)(nint)dir)->x = 0f;
		((Vector3*)(nint)center)->x = 0f;
		goto IL_04e9;
	}
}
