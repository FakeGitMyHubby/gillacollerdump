using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

public class PhysicsBody2D : AbstractPhysicsBody
{
	private readonly Rigidbody2D _rb;

	public Rigidbody2D Rigidbody2D => _rb;

	public override Vector3 LinearVelocity
	{
		get
		{
			//IL_0041: Expected VT, but got Obj
			if ((object)_rb != null)
			{
				return _rb.velocity;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
		set
		{
			//IL_0010: Expected VT, but got I4
			_rb.velocity = (Vector2)0;
		}
	}

	public override Vector3 AngularVelocity
	{
		get
		{
			//IL_0029: Expected VT, but got Obj
			//IL_001b: Expected VT, but got Obj
			if ((object)_rb != null)
			{
				float angularVelocity = _rb.angularVelocity;
				return (Vector3)_rb;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
		set
		{
			float angularVelocity = default;
			_rb.angularVelocity = angularVelocity;
		}
	}

	public override Vector3 Position
	{
		get
		{
			//IL_0041: Expected VT, but got Obj
			if ((object)_rb != null)
			{
				return _rb.position;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
		set
		{
			//IL_0010: Expected VT, but got I4
			_rb.position = (Vector2)0;
		}
	}

	public override Quaternion Rotation
	{
		get
		{
			//IL_0043: Expected VT, but got Obj
			if ((object)_rb != null)
			{
				float rotation = _rb.rotation;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Vector3 euler = default;
				return Quaternion.Internal_FromEulerRad(ref euler);
			}
			NullReferenceException ex = new NullReferenceException();
			return (Quaternion)ex;
		}
		set
		{
			//IL_002e: Expected VT, but got I4
			Quaternion rotation = default;
			Vector3 vector = Quaternion.Internal_ToEulerRad(ref rotation);
			object obj = default;
			float num = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
			float rotation2 = num * 0f;
			Vector3 vector2 = Quaternion.Internal_MakePositive((Vector3)0);
			_rb.rotation = rotation2;
		}
	}

	public override Vector3 Gravity
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_005c: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6838]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return Physics2D.gravity;
		}
	}

	public override float Drag
	{
		get
		{
			return _rb.drag;
		}
		set
		{
			_rb.drag = value;
		}
	}

	public override float AngularDrag
	{
		get
		{
			return _rb.angularDrag;
		}
		set
		{
			_rb.angularDrag = value;
		}
	}

	public override float Mass
	{
		get
		{
			return _rb.mass;
		}
		set
		{
			_rb.mass = value;
		}
	}

	public override int EncodedConstraints
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			if ((object)_rb != null)
			{
				return (int)_rb.constraints;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
		set
		{
			_rb.constraints = (RigidbodyConstraints2D)value;
		}
	}

	public override bool Kinematic
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			if ((object)_rb != null)
			{
				return _rb.isKinematic;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		set
		{
			_rb.isKinematic = value;
		}
	}

	public override Vector3 InertiaTensor
	{
		get
		{
			//IL_0029: Expected VT, but got Obj
			//IL_001b: Expected VT, but got Obj
			if ((object)_rb != null)
			{
				float inertia = _rb.inertia;
				return (Vector3)_rb;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
		set
		{
			float inertia = default;
			_rb.inertia = inertia;
		}
	}

	public override NetworkTransformHelpers.BodyInterpolation Interpolation
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			if ((object)_rb != null)
			{
				return (NetworkTransformHelpers.BodyInterpolation)_rb.interpolation;
			}
			NullReferenceException ex = new NullReferenceException();
			return (NetworkTransformHelpers.BodyInterpolation)ex;
		}
		set
		{
			_rb.interpolation = (RigidbodyInterpolation2D)value;
		}
	}

	public override Transform Transform
	{
		get
		{
			if ((object)_rb != null)
			{
				return _rb.transform;
			}
			return (Transform)(object)new NullReferenceException();
		}
	}

	public override Component Component => _rb;

	public override bool Valid
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0062: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return _rb;
		}
	}

	public float Inertia2D
	{
		get
		{
			return _rb.inertia;
		}
		set
		{
			_rb.inertia = value;
		}
	}

	public override bool Sleeping
	{
		get
		{
			//IL_0041: Expected I4, but got Obj
			if ((object)_rb != null)
			{
				return _rb.IsSleeping();
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		set
		{
			if (value)
			{
				_rb.Sleep();
			}
			else
			{
				_rb.WakeUp();
			}
		}
	}

	public override NetworkRigidbodyFlags Flags
	{
		get
		{
			//IL_00c0: Expected I4, but got Obj
			//IL_0080: Expected Obj, but got I4
			if ((object)_rb != null)
			{
				bool isKinematic = _rb.isKinematic;
				if ((object)_rb != null)
				{
					bool flag = _rb.IsSleeping();
					bool flag2 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
					object obj = !flag2;
					object obj2 = ~obj;
					if (obj2 == null)
					{
						return (NetworkRigidbodyFlags)2;
					}
					return isKinematic ? ((NetworkRigidbodyFlags)1) : ((NetworkRigidbodyFlags)0);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (NetworkRigidbodyFlags)(int)ex;
		}
	}

	public PhysicsBody2D(Rigidbody2D rb)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I4
		//IL_00ce: Expected VT, but got Obj
		//IL_00e2: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I4
		//IL_0143: Expected Obj, but got I
		//IL_014c: Expected VT, but got Obj
		//IL_0172: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6808]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6810]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6818]");
		object error3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6820]");
		object obj = 0;
		((object)this)._002Ector();
		object obj2 = this + 24;
		obj2 = rb;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Assert.Check(condition: true, (string)error);
		Assert.Check(condition: true, (string)error2);
		Assert.Check(condition: true, (string)error3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X20_v4+E8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v8+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X20_v4+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v4+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Array values = Enum.GetValues(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6828]");
		Array values2 = Enum.GetValues(Type.GetTypeFromHandle((RuntimeTypeHandle)(object)0));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6830]");
		object error4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v14 (System.Array)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v19 (System.Array)+18]");
		Assert.Check((object)(num - 0) == null, (string)error4);
	}

	public override void AddForce(Vector3 force)
	{
		//IL_0010: Expected VT, but got I4
		_rb.AddForce((Vector2)0);
	}

	public override void AddTorque(Vector3 torque)
	{
		float torque2 = default;
		_rb.AddTorque(torque2);
	}
}
