using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion.LagCompensation;

internal struct HitboxCollider
{
	internal HitboxTypes Type;

	private Matrix4x4 _cachedMatrix;

	private bool _matrixCalculated;

	internal Vector3 Offset;

	internal Vector3 BoxExtents;

	internal float Radius;

	internal float CapsuleExtents;

	internal bool Active;

	internal Hitbox Hitbox;

	internal int layerMask;

	internal int DebugTick;

	internal bool Used;

	internal int Next;

	internal LagCompensationUtils.BoxNarrowData BoxNarrowData;

	private bool IsBoxNarrowDataInitialized__BackingField;

	internal Vector3 Position;

	internal Quaternion Rotation;

	internal unsafe Matrix4x4 LocalToWorld
	{
		get
		{
			//IL_0016: Expected Obj, but got I4
			//IL_001b: Expected VT, but got Ref
			//IL_003d: Expected F4, but got VT
			//IL_0038: Expected native int or pointer, but got VT
			//IL_0052: Expected F4, but got I
			//IL_004d: Expected native int or pointer, but got VT
			//IL_0067: Expected F4, but got I
			//IL_0062: Expected native int or pointer, but got VT
			//IL_007c: Expected F4, but got I
			//IL_0077: Expected native int or pointer, but got VT
			//IL_00a1: Expected VT, but got I
			//IL_00b4: Expected VT, but got Ref
			bool flag = (byte)(~(_matrixCalculated ? 1u : 0u)) != 0;
			object obj = !flag;
			Matrix4x4 result = (Matrix4x4)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			if (obj == null)
			{
				ref Matrix4x4 reference = ref System.Runtime.CompilerServices.Unsafe.As<HitboxCollider, Matrix4x4>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
				IntPtr intPtr = default;
				Quaternion r = default;
				Vector3 s = default;
				CustomTRS(ref reference, (Vector3)(nint)intPtr, r, s);
				_matrixCalculated = true;
				result = (Matrix4x4)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
			}
			Matrix4x4 matrix4x = default;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)_cachedMatrix;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.HitboxCollider)+14]");
			((Matrix4x4*)(nint)matrix4x)->m01 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.HitboxCollider)+24]");
			((Matrix4x4*)(nint)matrix4x)->m02 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.HitboxCollider)+34]");
			((Matrix4x4*)(nint)matrix4x)->m03 = 0f;
			return result;
		}
	}

	internal bool IsBoxNarrowDataInitialized
	{
		get
		{
			return IsBoxNarrowDataInitialized__BackingField;
		}
		set
		{
			IsBoxNarrowDataInitialized__BackingField = value;
		}
	}

	internal unsafe Vector3 CapsuleLocalTopCenter
	{
		get
		{
			//IL_003a: Invalid comparison between F8 and I4
			//IL_0049: Invalid comparison between F8 and I4
			//IL_005e: Expected Obj, but got F8
			//IL_006b: Expected Obj, but got F8
			//IL_00a0: Expected Obj, but got I4
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected Obj, but got Unknown
			//IL_00c6: Expected VT, but got Ref
			double num = (double)CapsuleExtents * 0.5;
			double num2 = num - (double)Radius;
			bool flag = num2 < 0.0;
			bool flag2 = num2 == 0.0;
			object obj = num ^ (double)Radius;
			object obj2 = num ^ num2;
			object obj3 = obj & obj2;
			bool flag3 = (nint)obj3 < 0;
			bool flag4 = flag == flag3;
			object obj4 = !flag2;
			object obj5 = flag4 & obj4;
			object obj6 = ~obj5;
			if (obj6 == null)
			{
			}
			return (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}
	}

	internal unsafe Vector3 CapsuleLocalBottomCenter
	{
		get
		{
			//IL_003a: Invalid comparison between F8 and I4
			//IL_0049: Invalid comparison between F8 and I4
			//IL_005e: Expected Obj, but got F8
			//IL_006b: Expected Obj, but got F8
			//IL_00a0: Expected Obj, but got I4
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected Obj, but got Unknown
			//IL_00c6: Expected VT, but got Ref
			double num = (double)CapsuleExtents * 0.5;
			double num2 = num - (double)Radius;
			bool flag = num2 < 0.0;
			bool flag2 = num2 == 0.0;
			object obj = num ^ (double)Radius;
			object obj2 = num ^ num2;
			object obj3 = obj & obj2;
			bool flag3 = (nint)obj3 < 0;
			bool flag4 = flag == flag3;
			object obj4 = !flag2;
			object obj5 = flag4 & obj4;
			object obj6 = ~obj5;
			if (obj6 == null)
			{
			}
			return (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}
	}

	internal unsafe static void Lerp(ref HitboxCollider from, ref HitboxCollider to, float alpha, ref HitboxCollider result)
	{
		//IL_0018: Expected Obj, but got Ref
		//IL_0030: Invalid comparison between F4 and I4
		//IL_003f: Expected F8, but got I4
		//IL_01ba: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I
		//IL_01e0: Invalid comparison between F4 and I4
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0241: Expected F8, but got I4
		//IL_026c: Expected Obj, but got I
		//IL_0275: Invalid comparison between F4 and I4
		//IL_02af: Expected F8, but got I4
		//IL_02da: Expected Obj, but got I
		//IL_02f7: Expected Obj, but got I
		//IL_0300: Invalid comparison between F4 and I4
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_0361: Expected F8, but got I4
		//IL_038c: Expected Obj, but got I
		//IL_0395: Invalid comparison between F4 and I4
		//IL_03cf: Expected F8, but got I4
		//IL_03fa: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I
		//IL_0425: Expected Obj, but got Ref
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_04b8: Invalid comparison between F4 and I4
		//IL_04c7: Invalid comparison between F4 and I4
		//IL_04df: Expected Obj, but got F8
		//IL_04ec: Expected Obj, but got F4
		//IL_052c: Expected Obj, but got I4
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref result, 112));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag = alpha < 0f;
		double num = 0.0;
		if (!flag)
		{
			bool flag2 = !((double)alpha > 1.0);
			num = alpha;
			if (!flag2)
			{
				num = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [to @ X1 (Fusion.LagCompensation.HitboxCollider&)+48]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X0 (Fusion.LagCompensation.HitboxCollider&)+48]");
		object obj2 = num2 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [to @ X1 (Fusion.LagCompensation.HitboxCollider&)+50]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X0 (Fusion.LagCompensation.HitboxCollider&)+50]");
		object obj3 = num3 - 0;
		bool flag3 = alpha < 0f;
		object obj5 = default;
		object obj4 = obj2 * obj5;
		double num4 = (double)obj3 * num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X0 (Fusion.LagCompensation.HitboxCollider&)+48]");
		object obj6 = 0 + obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X0 (Fusion.LagCompensation.HitboxCollider&)+50]");
		double num5 = 0.0 + num4;
		double num6 = 0.0;
		if (!flag3)
		{
			bool flag4 = !((double)alpha > 1.0);
			num6 = alpha;
			if (!flag4)
			{
				num6 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [to @ X1 (Fusion.LagCompensation.HitboxCollider&)+60]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X0 (Fusion.LagCompensation.HitboxCollider&)+60]");
		object obj7 = num7 - 0;
		bool flag5 = alpha < 0f;
		double num8 = (double)obj7 * num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X0 (Fusion.LagCompensation.HitboxCollider&)+60]");
		double num9 = 0.0 + num8;
		double num10 = 0.0;
		if (!flag5)
		{
			bool flag6 = !((double)alpha > 1.0);
			num10 = alpha;
			if (!flag6)
			{
				num10 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [to @ X1 (Fusion.LagCompensation.HitboxCollider&)+54]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X0 (Fusion.LagCompensation.HitboxCollider&)+54]");
		object obj8 = num11 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [to @ X1 (Fusion.LagCompensation.HitboxCollider&)+5C]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X0 (Fusion.LagCompensation.HitboxCollider&)+5C]");
		object obj9 = num12 - 0;
		bool flag7 = alpha < 0f;
		object obj10 = obj8 * obj5;
		double num13 = (double)obj9 * num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X0 (Fusion.LagCompensation.HitboxCollider&)+54]");
		object obj11 = 0 + obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X0 (Fusion.LagCompensation.HitboxCollider&)+5C]");
		double num14 = 0.0 + num13;
		double num15 = 0.0;
		if (!flag7)
		{
			bool flag8 = !((double)alpha > 1.0);
			num15 = alpha;
			if (!flag8)
			{
				num15 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [to @ X1 (Fusion.LagCompensation.HitboxCollider&)+64]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X0 (Fusion.LagCompensation.HitboxCollider&)+64]");
		object obj12 = num16 - 0;
		bool flag9 = alpha < 0f;
		double num17 = (double)obj12 * num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X0 (Fusion.LagCompensation.HitboxCollider&)+64]");
		double num18 = 0.0 + num17;
		double num19 = 0.0;
		if (!flag9)
		{
			bool flag10 = !((double)alpha > 1.0);
			num19 = alpha;
			if (!flag10)
			{
				num19 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [to @ X1 (Fusion.LagCompensation.HitboxCollider&)+1B8]");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X0 (Fusion.LagCompensation.HitboxCollider&)+1B8]");
		object obj13 = num20 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [to @ X1 (Fusion.LagCompensation.HitboxCollider&)+1C0]");
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X0 (Fusion.LagCompensation.HitboxCollider&)+1C0]");
		object obj14 = num21 - 0;
		object obj15 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref to, 452));
		object obj17 = default;
		object obj16 = obj13 * obj17;
		double num22 = (double)obj14 * num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X0 (Fusion.LagCompensation.HitboxCollider&)+1B8]");
		object obj18 = 0 + obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X0 (Fusion.LagCompensation.HitboxCollider&)+1C0]");
		double num23 = 0.0 + num22;
		Quaternion a = default;
		Quaternion b = default;
		Quaternion quaternion = Quaternion.Internal_Lerp(ref a, ref b, alpha);
		float num24 = alpha - 0.5f;
		bool flag11 = num24 < 0f;
		bool flag12 = num24 == 0f;
		object obj19 = (double)alpha ^ 0.5;
		object obj20 = alpha ^ num24;
		object obj21 = obj19 & obj20;
		bool flag13 = (nint)obj21 < 0;
		_ = 0;
		bool flag14 = flag11 == flag13;
		object obj22 = !flag12;
		object obj23 = flag14 & obj22;
		object obj24 = ~obj23;
		if (obj24 == null)
		{
			ref HitboxCollider reference = ref to;
		}
		else
		{
			ref HitboxCollider reference = ref from;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v2 (Fusion.LagCompensation.HitboxCollider&)+78]");
		_ = 0;
	}

	internal unsafe void InitNarrowData()
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0011: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got VT
		//IL_0097: Expected Obj, but got I
		//IL_00d4: Expected VT, but got I4
		//IL_00d4: Expected VT, but got I4
		//IL_00e4: Expected Obj, but got Ref
		Matrix4x4 matrix4x = default;
		object obj = (object)(&matrix4x);
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (Type == (HitboxTypes)1)
		{
			bool flag = (byte)(~(IsBoxNarrowDataInitialized__BackingField ? 1u : 0u)) != 0;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = Position + Offset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.HitboxCollider)+1C0]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.HitboxCollider)+50]");
				object obj4 = num + 0;
				Matrix4x4 localToWorld = LocalToWorld;
				Quaternion rotation = matrix4x.GetRotation();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
				Vector3 extents = default;
				LagCompensationUtils.BoxNarrowData boxNarrowData = new LagCompensationUtils.BoxNarrowData((Vector3)0, (Quaternion)300, extents);
				object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 136));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				IsBoxNarrowDataInitialized__BackingField = true;
			}
		}
	}

	internal void ResetCachedMatrix()
	{
		_matrixCalculated = false;
	}

	private unsafe static void CustomTRS(ref Matrix4x4 res, Vector3 t, Quaternion r, Vector3 s)
	{
		//IL_024f: Expected Ref, but got F8
		object obj2 = default;
		object obj = obj2 * obj2;
		object obj4 = default;
		object obj3 = obj4 * obj4;
		object obj6 = default;
		object obj5 = obj6 * obj4;
		object obj8 = default;
		object obj7 = obj2 * obj8;
		object obj9 = obj2 * obj4;
		object obj10 = obj6 * obj8;
		object obj11 = obj6 * obj6;
		object obj12 = obj6 * obj2;
		object obj13 = obj + obj3;
		object obj14 = obj4 * obj8;
		_ = 0;
		object obj15 = obj5 - obj7;
		object obj16 = obj5 + obj7;
		object obj17 = obj9 + obj10;
		object obj18 = obj9 - obj10;
		_ = 0;
		object obj19 = obj11 + obj3;
		object obj20 = obj11 + obj;
		_ = 0;
		object obj21 = obj13 + obj13;
		object obj23 = default;
		object obj22 = obj23 * obj15;
		object obj24 = obj12 + obj14;
		object obj25 = obj12 - obj14;
		_ = 1065353216;
		object obj27 = default;
		object obj26 = obj27 * obj16;
		object obj28 = obj19 + obj19;
		object obj29 = obj27 * obj18;
		object obj30 = obj20 + obj20;
		object obj32 = default;
		object obj31 = obj32 * obj17;
		double num = 1.0 - (double)obj21;
		object obj33 = obj22 + obj22;
		object obj34 = obj23 * obj24;
		object obj35 = obj32 * obj25;
		object obj36 = obj26 + obj26;
		double num2 = 1.0 - (double)obj28;
		object obj37 = obj29 + obj29;
		double num3 = 1.0 - (double)obj30;
		object obj38 = obj31 + obj31;
		double num4 = (double)obj23 * num;
		object obj39 = obj34 + obj34;
		object obj40 = obj35 + obj35;
		double num5 = (double)obj32 * num2;
		double num6 = (double)obj27 * num3;
		ref Matrix4x4 reference = ref *(Matrix4x4*)num4;
	}
}
