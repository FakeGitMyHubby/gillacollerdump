using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion.LagCompensation;

public class ColliderDrawInfo
{
	internal int Index;

	internal IHitboxColliderContainer Container;

	public HitboxTypes Type
	{
		get
		{
			//IL_00f4: Expected I4, but got Obj
			//IL_000d: Expected I, but got Obj
			//IL_001d: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0150: Expected I4, but got Obj
			//IL_0068: Expected Obj, but got I
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected Obj, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected Obj, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			IHitboxColliderContainer container = Container;
			if (Container != null)
			{
				nint num = (nint)container;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6480]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00a9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+98]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X10_v7-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj2--;
					obj3 += 16;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00a9;
				}
				object obj4 = obj3 + 2;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				goto IL_0141;
			}
			NullReferenceException ex = new NullReferenceException();
			return (HitboxTypes)ex;
			IL_0141:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v151 @ X0_v3] (should have been resolved before IL gen)");
			object obj7 = default;
			return (HitboxTypes)obj7;
			IL_00a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0141;
		}
	}

	public Vector3 BoxExtents
	{
		get
		{
			//IL_00f4: Expected VT, but got Obj
			//IL_000d: Expected I, but got Obj
			//IL_001d: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0068: Expected Obj, but got I
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected Obj, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected Obj, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			IHitboxColliderContainer container = Container;
			if (Container != null)
			{
				nint num = (nint)container;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6480]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00a9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+98]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X10_v7-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj2--;
					obj3 += 16;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00a9;
				}
				object obj4 = obj3 + 2;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				goto IL_0141;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
			IL_0141:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ X0_v3] (should have been resolved before IL gen)");
			Vector3 result = default;
			return result;
			IL_00a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0141;
		}
	}

	public Vector3 Offset
	{
		get
		{
			//IL_00f4: Expected VT, but got Obj
			//IL_000d: Expected I, but got Obj
			//IL_001d: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0068: Expected Obj, but got I
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected Obj, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected Obj, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			IHitboxColliderContainer container = Container;
			if (Container != null)
			{
				nint num = (nint)container;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6480]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00a9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+98]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X10_v7-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj2--;
					obj3 += 16;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00a9;
				}
				object obj4 = obj3 + 2;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				goto IL_0141;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
			IL_0141:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ X0_v3] (should have been resolved before IL gen)");
			Vector3 result = default;
			return result;
			IL_00a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0141;
		}
	}

	public float Radius
	{
		get
		{
			//IL_000d: Expected I, but got Obj
			//IL_001d: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0130: Expected F4, but got I
			//IL_0068: Expected Obj, but got I
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected Obj, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected Obj, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			IHitboxColliderContainer container = Container;
			nint num = (nint)container;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6480]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00a9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+98]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X10_v7-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj2--;
				obj3 += 16;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00a9;
			}
			object obj4 = obj3 + 2;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0119;
			IL_00a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0119;
			IL_0119:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ X0_v3] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v5+60]");
			return 0f;
		}
	}

	public float CapsuleExtents
	{
		get
		{
			//IL_000d: Expected I, but got Obj
			//IL_001d: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0130: Expected F4, but got I
			//IL_0068: Expected Obj, but got I
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected Obj, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected Obj, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			IHitboxColliderContainer container = Container;
			nint num = (nint)container;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6480]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00a9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+98]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X10_v7-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj2--;
				obj3 += 16;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00a9;
			}
			object obj4 = obj3 + 2;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0119;
			IL_00a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0119;
			IL_0119:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ X0_v3] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v5+64]");
			return 0f;
		}
	}

	public unsafe Vector3 CapsuleTopCenter
	{
		get
		{
			//IL_00f4: Expected VT, but got Obj
			//IL_000d: Expected I, but got Obj
			//IL_001d: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0154: Expected Ref, but got VT
			//IL_0068: Expected Obj, but got I
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected Obj, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected Obj, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			IHitboxColliderContainer container = Container;
			if (Container != null)
			{
				nint num = (nint)container;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6480]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00a9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+98]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X10_v7-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj2--;
					obj3 += 16;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00a9;
				}
				object obj4 = obj3 + 2;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				goto IL_0141;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
			IL_0141:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v151 @ X0_v3] (should have been resolved before IL gen)");
			HitboxCollider hitboxCollider = default;
			return ((HitboxCollider*)hitboxCollider)->CapsuleLocalTopCenter;
			IL_00a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0141;
		}
	}

	public unsafe Vector3 CapsuleBottomCenter
	{
		get
		{
			//IL_00f4: Expected VT, but got Obj
			//IL_000d: Expected I, but got Obj
			//IL_001d: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0154: Expected Ref, but got VT
			//IL_0068: Expected Obj, but got I
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected Obj, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected Obj, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			IHitboxColliderContainer container = Container;
			if (Container != null)
			{
				nint num = (nint)container;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6480]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00a9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+98]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X10_v7-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj2--;
					obj3 += 16;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00a9;
				}
				object obj4 = obj3 + 2;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				goto IL_0141;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
			IL_0141:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v151 @ X0_v3] (should have been resolved before IL gen)");
			HitboxCollider hitboxCollider = default;
			return ((HitboxCollider*)hitboxCollider)->CapsuleLocalBottomCenter;
			IL_00a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0141;
		}
	}

	public unsafe Matrix4x4 LocalToWorldMatrix
	{
		get
		{
			//IL_00f4: Expected VT, but got Obj
			//IL_000d: Expected I, but got Obj
			//IL_001d: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0154: Expected Ref, but got VT
			//IL_0160: Expected native int or pointer, but got VT
			//IL_016d: Expected native int or pointer, but got VT
			//IL_017a: Expected native int or pointer, but got VT
			//IL_0187: Expected native int or pointer, but got VT
			//IL_0068: Expected Obj, but got I
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected Obj, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected Obj, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			IHitboxColliderContainer container = Container;
			if (Container != null)
			{
				nint num = (nint)container;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6480]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v2 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v2 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00a9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v2 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+98]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v7-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj2--;
					obj3 += 16;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00a9;
				}
				object obj4 = obj3 + 2;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				goto IL_0141;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Matrix4x4)ex;
			IL_0141:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v166 @ X0_v3] (should have been resolved before IL gen)");
			HitboxCollider hitboxCollider = default;
			Matrix4x4 localToWorld = ((HitboxCollider*)hitboxCollider)->LocalToWorld;
			Matrix4x4 matrix4x = default;
			float m = default;
			((Matrix4x4*)(nint)matrix4x)->m00 = m;
			float m2 = default;
			((Matrix4x4*)(nint)matrix4x)->m01 = m2;
			float m3 = default;
			((Matrix4x4*)(nint)matrix4x)->m02 = m3;
			float m4 = default;
			((Matrix4x4*)(nint)matrix4x)->m03 = m4;
			return localToWorld;
			IL_00a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0141;
		}
	}

	internal ColliderDrawInfo FromHitboxCollider(int colliderIndex)
	{
		Index = colliderIndex;
		return this;
	}

	internal void SetContainer(IHitboxColliderContainer container)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 24;
		obj = container;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
