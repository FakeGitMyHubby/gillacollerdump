using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

public struct NetworkBehaviourBufferInterpolator
{
	public readonly NetworkBehaviour Behaviour;

	public readonly NetworkBehaviourBuffer From;

	public readonly NetworkBehaviourBuffer To;

	public readonly float Alpha;

	public readonly bool Valid;

	public NetworkBehaviourBufferInterpolator(NetworkBehaviour nb)
	{
		Behaviour = nb;
		bool valid = nb.TryGetSnapshotsBuffers(out System.Runtime.CompilerServices.Unsafe.As<NetworkBehaviourBufferInterpolator, NetworkBehaviourBuffer>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8)), out System.Runtime.CompilerServices.Unsafe.As<NetworkBehaviourBufferInterpolator, NetworkBehaviourBuffer>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 24)), out System.Runtime.CompilerServices.Unsafe.As<NetworkBehaviourBufferInterpolator, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40)));
		Valid = valid;
	}

	public float Angle(string property)
	{
		//IL_0015: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5BA0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D1808");
		NetworkBehaviour.PropertyReader<Angle> property2 = default;
		return Angle(property2);
	}

	public float Angle(NetworkBehaviour.PropertyReader<Angle> property)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00a1: Expected VT, but got Obj
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected VT, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B70]");
		object error = 0;
		Assert.Check(Valid, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @40D2A80");
		object obj = default;
		Angle angle = (Angle)(obj >> 32);
		Angle angle2 = (Angle)(obj & 0xFFFFFFFFL);
		float num = (float)angle2;
		float num2 = (float)angle;
		Angle angle3 = (Angle)(obj & 0xFFFFFFFFL);
		float num3 = (float)angle3;
		float num4 = num2 - num3;
		float num5 = num4 * Alpha;
		return num + num5;
	}

	public float Float(string property)
	{
		NetworkBehaviour.PropertyReader<float> propertyReader = Behaviour.GetPropertyReader<float>(property);
		return Float(propertyReader);
	}

	public float Float(NetworkBehaviour.PropertyReader<float> property)
	{
		//IL_0010: Expected Obj, but got I
		//IL_003f: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B70]");
		object error = 0;
		Assert.Check(Valid, (string)error);
		NetworkBehaviourBuffer first = From;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkBehaviourBufferInterpolator)+10]");
		NetworkBehaviour.PropertyReader<float> propertyReader = default;
		(float, float) tuple = propertyReader.Read(first, (NetworkBehaviourBuffer)0);
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		float num = Alpha * (float)obj;
		return (float)obj3 + num;
	}

	public int Int(string property)
	{
		return Select<int>(property);
	}

	public int Int(NetworkBehaviour.PropertyReader<int> property)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected VT, but got Unknown
		NetworkBehaviour.PropertyReader<int> property2 = (NetworkBehaviour.PropertyReader<int>)(property & 0xFFFFFFFFL);
		return Select(property2);
	}

	public bool Bool(NetworkBehaviour.PropertyReader<bool> property)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5BD0]");
		object obj = 0;
		object obj2 = property & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D5AC4");
		bool result = default;
		return result;
	}

	public bool Bool(string property)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5BD8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D5B54");
		bool result = default;
		return result;
	}

	public NetworkBool NetworkBool(NetworkBehaviour.PropertyReader<NetworkBool> property)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected VT, but got Unknown
		NetworkBehaviour.PropertyReader<NetworkBool> property2 = (NetworkBehaviour.PropertyReader<NetworkBool>)(property & 0xFFFFFFFFL);
		return Select(property2);
	}

	public NetworkBool NetworkBool(string property)
	{
		return Select<NetworkBool>(property);
	}

	public T Select<T>(string property) where T : struct
	{
		//IL_006c: Expected VT, but got Obj
		if ((object)Behaviour != null)
		{
			NetworkBehaviour.PropertyReader<bool> propertyReader = Behaviour.GetPropertyReader<bool>(property);
			return Select((NetworkBehaviour.PropertyReader<T>)propertyReader);
		}
		NullReferenceException ex = new NullReferenceException();
		return (T)ex;
	}

	public T Select<T>(NetworkBehaviour.PropertyReader<T> property) where T : struct
	{
		//IL_0029: Expected Obj, but got I
		//IL_0053: Expected VT, but got I
		//IL_007b: Invalid comparison between F8 and I4
		//IL_008c: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I4
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00e6: Expected VT, but got I4
		//IL_00ac: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B70]");
		object error = 0;
		Assert.Check(Valid, (string)error);
		NetworkBehaviourBuffer first = From;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkBehaviourBufferInterpolator)+10]");
		NetworkBehaviour.PropertyReader<bool> propertyReader = default;
		(bool, bool) tuple = propertyReader.Read(first, (NetworkBehaviourBuffer)0);
		double num = (double)Alpha - 0.5;
		bool flag = num < 0.0;
		object obj = !flag;
		object obj2 = ~obj;
		object obj3 = ((obj2 != null) ? ((object)1) : ((object)256));
		object obj4 = obj3 & tuple;
		bool flag2 = obj4 == null;
		return (T)(!flag2);
	}

	public Vector3 Vector3(string property)
	{
		//IL_003f: Expected VT, but got Obj
		if ((object)Behaviour != null)
		{
			NetworkBehaviour.PropertyReader<Vector3> propertyReader = Behaviour.GetPropertyReader<Vector3>(property);
			return Vector3(propertyReader);
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	public Vector3 Vector3(NetworkBehaviour.PropertyReader<Vector3> property)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f4: Expected VT, but got I
		//IL_0103: Invalid comparison between F4 and I4
		//IL_0034: Invalid comparison between F8 and I4
		//IL_0043: Invalid comparison between F8 and I4
		//IL_005d: Expected Obj, but got F8
		//IL_006c: Expected Obj, but got F8
		//IL_00a1: Expected Obj, but got I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B70]");
		object error = 0;
		Assert.Check(Valid, (string)error);
		NetworkBehaviourBuffer first = From;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkBehaviourBufferInterpolator)+10]");
		NetworkBehaviour.PropertyReader<Vector3> propertyReader = default;
		Vector3 result = (Vector3)propertyReader.Read(first, (NetworkBehaviourBuffer)0);
		if (!(Alpha < 0f))
		{
			double num = (double)Alpha - 1.0;
			bool flag = num < 0.0;
			bool flag2 = num == 0.0;
			object obj = (double)Alpha ^ 1.0;
			object obj2 = (double)Alpha ^ num;
			object obj3 = obj & obj2;
			bool flag3 = (nint)obj3 < 0;
			bool flag4 = flag == flag3;
			object obj4 = !flag4;
			object obj5 = obj4 | flag2;
			object obj6 = ~obj5;
			if (obj6 != null)
			{
			}
		}
		return result;
	}

	public Vector2 Vector2(string property)
	{
		//IL_003f: Expected VT, but got Obj
		if ((object)Behaviour != null)
		{
			NetworkBehaviour.PropertyReader<Vector2> propertyReader = Behaviour.GetPropertyReader<Vector2>(property);
			return Vector2(propertyReader);
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector2)ex;
	}

	public Vector2 Vector2(NetworkBehaviour.PropertyReader<Vector2> property)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0049: Expected VT, but got I
		//IL_006c: Invalid comparison between F8 and I4
		//IL_007b: Invalid comparison between F8 and I4
		//IL_0095: Expected Obj, but got F8
		//IL_00a4: Expected Obj, but got F8
		//IL_00d9: Expected Obj, but got I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_0108: Invalid comparison between F4 and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B70]");
		object error = 0;
		Assert.Check(Valid, (string)error);
		NetworkBehaviourBuffer first = From;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkBehaviourBufferInterpolator)+10]");
		NetworkBehaviour.PropertyReader<Vector2> propertyReader = default;
		Vector2 result = (Vector2)propertyReader.Read(first, (NetworkBehaviourBuffer)0);
		double num = (double)Alpha - 1.0;
		bool flag = num < 0.0;
		bool flag2 = num == 0.0;
		object obj = (double)Alpha ^ 1.0;
		object obj2 = (double)Alpha ^ num;
		object obj3 = obj & obj2;
		bool flag3 = (nint)obj3 < 0;
		bool flag4 = flag == flag3;
		object obj4 = !flag4;
		object obj5 = obj4 | flag2;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
		}
		if (Alpha < 0f)
		{
		}
		return result;
	}

	public Vector4 Vector4(string property)
	{
		//IL_003f: Expected VT, but got Obj
		if ((object)Behaviour != null)
		{
			NetworkBehaviour.PropertyReader<Vector4> propertyReader = Behaviour.GetPropertyReader<Vector4>(property);
			return Vector4(propertyReader);
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector4)ex;
	}

	public Vector4 Vector4(NetworkBehaviour.PropertyReader<Vector4> property)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f4: Expected VT, but got I
		//IL_0103: Invalid comparison between F4 and I4
		//IL_0034: Invalid comparison between F8 and I4
		//IL_0043: Invalid comparison between F8 and I4
		//IL_005d: Expected Obj, but got F8
		//IL_006c: Expected Obj, but got F8
		//IL_00a1: Expected Obj, but got I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B70]");
		object error = 0;
		Assert.Check(Valid, (string)error);
		NetworkBehaviourBuffer first = From;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkBehaviourBufferInterpolator)+10]");
		NetworkBehaviour.PropertyReader<Vector4> propertyReader = default;
		Vector4 result = (Vector4)propertyReader.Read(first, (NetworkBehaviourBuffer)0);
		if (!(Alpha < 0f))
		{
			double num = (double)Alpha - 1.0;
			bool flag = num < 0.0;
			bool flag2 = num == 0.0;
			object obj = (double)Alpha ^ 1.0;
			object obj2 = (double)Alpha ^ num;
			object obj3 = obj & obj2;
			bool flag3 = (nint)obj3 < 0;
			bool flag4 = flag == flag3;
			object obj4 = !flag4;
			object obj5 = obj4 | flag2;
			object obj6 = ~obj5;
			if (obj6 != null)
			{
			}
		}
		return result;
	}

	public Quaternion Quaternion(string property)
	{
		//IL_003f: Expected VT, but got Obj
		if ((object)Behaviour != null)
		{
			NetworkBehaviour.PropertyReader<Quaternion> propertyReader = Behaviour.GetPropertyReader<Quaternion>(property);
			return Quaternion(propertyReader);
		}
		NullReferenceException ex = new NullReferenceException();
		return (Quaternion)ex;
	}

	public Quaternion Quaternion(NetworkBehaviour.PropertyReader<Quaternion> property)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0044: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B70]");
		object error = 0;
		Assert.Check(Valid, (string)error);
		NetworkBehaviourBuffer first = From;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkBehaviourBufferInterpolator)+10]");
		NetworkBehaviour.PropertyReader<Quaternion> propertyReader = default;
		(Quaternion, Quaternion) tuple = propertyReader.Read(first, (NetworkBehaviourBuffer)0);
		Quaternion a = default;
		Quaternion b = default;
		return UnityEngine.Quaternion.Internal_Slerp(ref a, ref b, Alpha);
	}

	public static implicit operator bool(NetworkBehaviourBufferInterpolator i)
	{
		return i.Valid;
	}
}
