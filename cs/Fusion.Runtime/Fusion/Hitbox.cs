using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion.LagCompensation;
using UnityEngine;

namespace Fusion;

public class Hitbox : Behaviour
{
	public HitboxTypes Type;

	public float SphereRadius;

	public float CapsuleRadius;

	public Vector3 BoxExtents;

	public float CapsuleExtents;

	public Vector3 Offset;

	public HitboxRoot Root;

	internal int _hitboxIndex;

	private int ColliderIndex__BackingField;

	public Color GizmosColor;

	private int _cachedLayerMask;

	private Transform _cachedTransform;

	internal float AbsSphereRadius
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			return SphereRadius;
		}
	}

	internal float AbsCapsuleRadius
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			return CapsuleRadius;
		}
	}

	internal Vector3 CapsuleTopCenter
	{
		get
		{
			//IL_0044: Invalid comparison between F8 and I4
			//IL_0053: Invalid comparison between F8 and I4
			//IL_0068: Expected Obj, but got F8
			//IL_0075: Expected Obj, but got F8
			//IL_00aa: Expected Obj, but got I4
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected Obj, but got Unknown
			//IL_00d0: Expected VT, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			double num = (double)CapsuleExtents * 0.5;
			double num2 = num - (double)CapsuleRadius;
			bool flag = num2 < 0.0;
			bool flag2 = num2 == 0.0;
			object obj = num ^ (double)CapsuleRadius;
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
			return (Vector3)this;
		}
	}

	internal Vector3 CapsuleBottomCenter
	{
		get
		{
			//IL_0044: Invalid comparison between F8 and I4
			//IL_0053: Invalid comparison between F8 and I4
			//IL_0068: Expected Obj, but got F8
			//IL_0075: Expected Obj, but got F8
			//IL_00aa: Expected Obj, but got I4
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected Obj, but got Unknown
			//IL_00d0: Expected VT, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			double num = (double)CapsuleExtents * 0.5;
			double num2 = num - (double)CapsuleRadius;
			bool flag = num2 < 0.0;
			bool flag2 = num2 == 0.0;
			object obj = num ^ (double)CapsuleRadius;
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
			return (Vector3)this;
		}
	}

	internal Vector3 AbsBoxExtents
	{
		get
		{
			//IL_0020: Expected VT, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			return (Vector3)this;
		}
	}

	public int HitboxIndex
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			return _hitboxIndex;
		}
	}

	internal uint HitboxMask
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0031: Expected Obj, but got I4
			//IL_003a: Expected I4, but got Obj
			//IL_0057: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6930]");
			object error = 0;
			bool flag = _hitboxIndex < 31;
			object obj = !flag;
			bool condition = (byte)(int)(~obj) != 0;
			Assert.Check(condition, (string)error);
			object obj2 = _hitboxIndex + 1;
			return (uint)(1 << (int)obj2);
		}
	}

	public bool HitboxActive
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_003c: Expected Obj, but got I4
			//IL_0056: Expected Obj, but got I4
			HitboxRoot root = Root;
			if ((object)Root != null)
			{
				object obj = root.Flags & (SimulationBehaviourRuntimeFlags)8;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					return Root.IsHitboxActive(this);
				}
			}
			return false;
		}
		[MethodImpl((MethodImplOptions)256)]
		set
		{
			//IL_003c: Expected Obj, but got I4
			//IL_0056: Expected Obj, but got I4
			HitboxRoot root = Root;
			if ((object)Root != null)
			{
				object obj = root.Flags & (SimulationBehaviourRuntimeFlags)8;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					Root.SetHitboxActive(this, value);
				}
			}
		}
	}

	public int ColliderIndex
	{
		get
		{
			return ColliderIndex__BackingField;
		}
		internal set
		{
			ColliderIndex__BackingField = value;
		}
	}

	public Vector3 Position
	{
		get
		{
			//IL_0098: Expected VT, but got Obj
			//IL_007c: Expected VT, but got I4
			//IL_007c: Expected VT, but got I4
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				Transform transform2 = base.transform;
				if ((object)transform2 != null)
				{
					Quaternion rotation = transform2.rotation;
					return (Quaternion)0 * (Vector3)0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
	}

	private void Awake()
	{
		CacheInfo();
	}

	internal void CacheInfo()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		int layer = gameObject.layer;
		int cachedLayerMask = 1 << layer;
		_cachedLayerMask = cachedLayerMask;
		Transform transform = base.transform;
		object obj = this + 112;
		obj = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal unsafe void SetColliderData(ref HitboxCollider c, int tick)
	{
		//IL_0117: Expected Obj, but got I
		//IL_0018: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got Ref
		//IL_00f3: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		HitboxRoot root = Root;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6968]");
		object error = 0;
		bool condition;
		if ((object)Root != null)
		{
			object obj = root.Flags & (SimulationBehaviourRuntimeFlags)8;
			bool flag = obj == null;
			condition = flag;
		}
		else
		{
			condition = false;
		}
		Assert.Check(condition, (string)error);
		ref HitboxCollider reference = ref *(HitboxCollider*)(int)Type;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Hitbox)+44]");
		_ = 0;
		_ = Offset;
		_cachedTransform.GetPositionAndRotation(out System.Runtime.CompilerServices.Unsafe.As<HitboxCollider, Vector3>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref c, 440)), out System.Runtime.CompilerServices.Unsafe.As<HitboxCollider, Quaternion>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref c, 452)));
		c.ResetCachedMatrix();
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref c, 112));
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		_ = BoxExtents;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Hitbox)+34]");
		_ = 0;
		if (Type == (HitboxTypes)2)
		{
			object obj3 = 36;
		}
		else
		{
			object obj3 = 40;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Hitbox)+v177 @ X8_v10]");
		_ = 0;
		_ = CapsuleExtents;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = _cachedLayerMask;
		throw new ArgumentNullException();
	}

	public void SetLayer(int layer)
	{
		GameObject gameObject = base.gameObject;
		gameObject.layer = layer;
		int cachedLayerMask = 1 << layer;
		_cachedLayerMask = cachedLayerMask;
	}

	public unsafe void OnDrawGizmos()
	{
		//IL_003c: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_00fe: Expected Obj, but got I4
		HitboxRoot root = Root;
		if ((object)Root != null)
		{
			object obj = root.Flags & (SimulationBehaviourRuntimeFlags)8;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null && root.Ptr != null)
			{
				ArgumentNullException ex = new ArgumentNullException();
				object obj3 = ex & 1;
				bool flag2 = obj3 == null;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					throw new ArgumentNullException();
				}
			}
		}
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Transform transform2 = base.transform;
		Quaternion rotation = transform2.rotation;
		Vector3 pos = default;
		Quaternion q = default;
		Vector3 s = default;
		Matrix4x4 matrix4x = Matrix4x4.Internal_TRS(ref pos, ref q, ref s);
		TypeCode typeCode = ((Enum)(object)this).GetTypeCode();
	}

	protected unsafe virtual void DrawGizmos(Color color, ref Matrix4x4 localToWorldMatrix)
	{
		//IL_0009: Expected VT, but got Ref
		//IL_0013: Expected VT, but got I4
		//IL_00f5: Expected VT, but got I4
		//IL_00f5: Expected VT, but got I4
		//IL_0104: Expected VT, but got I4
		//IL_00ba: Expected F4, but got VT
		//IL_00ba: Expected VT, but got I4
		//IL_0112: Expected VT, but got Ref
		//IL_009b: Expected VT, but got I4
		//IL_009b: Expected VT, but got I4
		object obj = default;
		Gizmos.matrix = (Matrix4x4)(&obj);
		Gizmos.color = (Color)0;
		if (Type != (HitboxTypes)3)
		{
			if (Type != (HitboxTypes)2)
			{
				if (Type == (HitboxTypes)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					Gizmos.DrawWireCube((Vector3)0, (Vector3)0);
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Gizmos.DrawWireSphere((Vector3)0, (float)Offset);
			}
		}
		else
		{
			Vector3 capsuleTopCenter = CapsuleTopCenter;
			Vector3 capsuleBottomCenter = CapsuleBottomCenter;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			float capsuleRadius = default;
			LagCompensationDraw.GizmosDrawWireCapsule((Vector3)0, (Vector3)0, capsuleRadius);
		}
		Gizmos.color = (Color)0;
		object obj2 = default;
		Gizmos.matrix = (Matrix4x4)(&obj2);
	}

	public Hitbox()
	{
		//IL_0012: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107CDA0]");
		GizmosColor = (Color)0;
		((MonoBehaviour)this)._002Ector();
	}
}
