using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace Photon.Client.StructWrapping;

public abstract class StructWrapper : IEnumerable<KeyValue<_00210, _00211>>
{
	public readonly WrappedType wrappedType;

	public readonly Type ttype;

	public StructWrapper(Type ttype, WrappedType wrappedType)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		object obj = this + 24;
		obj = ttype;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public abstract object Box();

	public abstract void DisconnectFromPool();

	public abstract void Dispose();

	public abstract string ToString(bool writeType);

	public static implicit operator StructWrapper(bool value)
	{
		return StructWrapperUtility.Wrap(value);
	}

	public static implicit operator StructWrapper(byte value)
	{
		return StructWrapperUtility.Wrap(value);
	}

	public static implicit operator StructWrapper(float value)
	{
		return StructWrapperUtility.Wrap(value);
	}

	public static implicit operator StructWrapper(double value)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65171D0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @377FD74");
		StructWrapper result = default;
		return result;
	}

	public static implicit operator StructWrapper(short value)
	{
		return StructWrapperUtility.Wrap(value);
	}

	public static implicit operator StructWrapper(int value)
	{
		return StructWrapperUtility.Wrap(value);
	}

	public static implicit operator StructWrapper(long value)
	{
		return StructWrapperUtility.Wrap(value);
	}

	public static implicit operator bool(StructWrapper wrapper)
	{
		//IL_00d6: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		if (wrapper != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65171F8]");
			object obj = 0;
			nint num = (nint)wrapper;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v4-8]");
				if (0 == (nint)obj2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65171F0]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4443480");
					bool result = default;
					return result;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static implicit operator byte(StructWrapper wrapper)
	{
		//IL_00ca: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		if (wrapper != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516CA8]");
			object obj = 0;
			nint num = (nint)wrapper;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v4-8]");
				if (0 == (nint)obj2)
				{
					return ((StructWrapper<byte>)wrapper).Unwrap();
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex;
	}

	public static implicit operator float(StructWrapper wrapper)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517210]");
		object obj = 0;
		nint num = (nint)wrapper;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v4-8]");
			if (0 == (nint)obj2)
			{
				return ((StructWrapper<float>)wrapper).Unwrap();
			}
		}
		throw new NullReferenceException();
	}

	public static implicit operator double(StructWrapper wrapper)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517220]");
		object obj = 0;
		nint num = (nint)wrapper;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v4-8]");
			if (0 == (nint)obj2)
			{
				return ((StructWrapper<double>)wrapper).Unwrap();
			}
		}
		throw new NullReferenceException();
	}

	public static implicit operator short(StructWrapper wrapper)
	{
		//IL_00ca: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		if (wrapper != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517230]");
			object obj = 0;
			nint num = (nint)wrapper;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v4-8]");
				if (0 == (nint)obj2)
				{
					return ((StructWrapper<short>)wrapper).Unwrap();
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (short)(int)ex;
	}

	public static implicit operator int(StructWrapper wrapper)
	{
		//IL_00ca: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		if (wrapper != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517240]");
			object obj = 0;
			nint num = (nint)wrapper;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v4-8]");
				if (0 == (nint)obj2)
				{
					return ((StructWrapper<int>)wrapper).Unwrap();
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static implicit operator long(StructWrapper wrapper)
	{
		//IL_00ca: Expected I8, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		if (wrapper != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517250]");
			object obj = 0;
			nint num = (nint)wrapper;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v4-8]");
				if (0 == (nint)obj2)
				{
					return ((StructWrapper<long>)wrapper).Unwrap();
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (long)ex;
	}

	public static implicit operator StructWrapper(Vector2 value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517258]");
		object obj = 0;
		return StructWrapperUtility.Wrap((Vector2)obj);
	}

	public static implicit operator StructWrapper(Vector3 value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517260]");
		object obj = 0;
		return StructWrapperUtility.Wrap((Vector3)obj);
	}

	public static implicit operator StructWrapper(Quaternion value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517268]");
		object obj = 0;
		return StructWrapperUtility.Wrap((Quaternion)obj);
	}

	public static implicit operator Vector2(StructWrapper wrapper)
	{
		//IL_00ca: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		if (wrapper != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517278]");
			object obj = 0;
			nint num = (nint)wrapper;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v4-8]");
				if (0 == (nint)obj2)
				{
					return ((StructWrapper<Vector2>)wrapper).Unwrap();
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector2)ex;
	}

	public static implicit operator Vector3(StructWrapper wrapper)
	{
		//IL_00ca: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		if (wrapper != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517288]");
			object obj = 0;
			nint num = (nint)wrapper;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v4-8]");
				if (0 == (nint)obj2)
				{
					return ((StructWrapper<Vector3>)wrapper).Unwrap();
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}

	public static implicit operator Quaternion(StructWrapper wrapper)
	{
		//IL_00ca: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		if (wrapper != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517298]");
			object obj = 0;
			nint num = (nint)wrapper;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v4-8]");
				if (0 == (nint)obj2)
				{
					return ((StructWrapper<Quaternion>)wrapper).Unwrap();
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (Quaternion)ex;
	}
}
public class StructWrapper<T> : StructWrapper
{
	private StructWrapperPool<T> ReturnPool__BackingField;

	internal Pooling pooling;

	internal T value;

	internal static StructWrapperPool<T> staticPool;

	public StructWrapperPool<T> ReturnPool
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.StructWrapping.StructWrapper`1<T>)+20]");
			return (StructWrapperPool<T>)0;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public StructWrapper(Pooling releasing)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I4
		//IL_0086: Expected VT, but got I
		//IL_00a0: Expected Obj, but got I
		//IL_00b1: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v2+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X9_v1 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1>)+A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v3+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X9_v2+10]");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5+10]");
		base._002Ector(typeFromHandle, StructWrapperPool.GetWrappedType(Type.GetTypeFromHandle((RuntimeTypeHandle)0)));
	}

	public StructWrapper(Pooling releasing, Type tType, WrappedType wType)
		: base(tType, wType)
	{
	}

	public StructWrapper<T> Poke(byte value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.StructWrapping.StructWrapper`1<T>)+28]");
		if ((nint)0 != 4)
		{
			return this;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		InvalidOperationException ex = default;
		string message = default;
		ex._002Ector(message);
		return (StructWrapper<T>)(object)new ArgumentNullException();
	}

	public StructWrapper<T> Poke(bool value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.StructWrapping.StructWrapper`1<T>)+28]");
		if ((nint)0 != 4)
		{
			return this;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		InvalidOperationException ex = default;
		string message = default;
		ex._002Ector(message);
		return (StructWrapper<T>)(object)new ArgumentNullException();
	}

	public StructWrapper<T> Poke(T value)
	{
		return this;
	}

	public T Unwrap()
	{
		//IL_0091: Expected VT, but got I4
		//IL_00a4: Expected VT, but got Obj
		//IL_0060: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.StructWrapping.StructWrapper`1<T>)+28]");
		if ((nint)0 != 4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.StructWrapping.StructWrapper`1<T>)+20]");
			if ((nint)0 == 0)
			{
				NullReferenceException ex = new NullReferenceException();
				return (T)ex;
			}
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v3 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1>)+A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4441820");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.StructWrapping.StructWrapper`1<T>)+2C]");
		bool flag = (nint)0 == 0;
		return (T)(!flag);
	}

	public T Peek()
	{
		//IL_000d: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.StructWrapping.StructWrapper`1<T>)+2C]");
		return (T)0;
	}

	public override object Box()
	{
		//IL_0060: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.StructWrapping.StructWrapper`1<T>)+20]");
		if ((nint)0 != 0)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1>)+A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4441820");
		}
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1>)+A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object result = default;
		return result;
	}

	public override void Dispose()
	{
		//IL_0016: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.StructWrapping.StructWrapper`1<T>)+28]");
		object obj = (nint)0 & (nint)8;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.StructWrapping.StructWrapper`1<T>)+20]");
			if ((nint)0 != 0)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X9_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1>)+A8]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4441820");
			}
		}
	}

	public override void DisconnectFromPool()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.StructWrapping.StructWrapper`1<T>)+28]");
		if ((nint)0 != 4)
		{
			object obj = this + 32;
			obj = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public override string ToString()
	{
		//IL_0016: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I4
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1>)+A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4443480");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X9_v2+30]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = default;
		return flag2.ToString();
	}

	public override string ToString(bool writeTypeInfo)
	{
		//IL_00f6: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I4
		bool flag2 = default;
		if (writeTypeInfo)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FA090]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FA098]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v10 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1>)+A8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4443480");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v7+30]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string arg = flag2.ToString();
			object arg2 = default;
			return string.Format((string)format, arg2, arg);
		}
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1>)+A8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4443480");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X9_v3+30]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return flag2.ToString();
	}

	public static implicit operator StructWrapper<T>(T value)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I
		//IL_01c4: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0146: Expected Obj, but got I4
		//IL_0179: Expected Obj, but got I
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3+48]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = (nint)0 + (nint)309;
		object obj8 = obj7 & 1;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		nint num2 = 0;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v5 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1>)+A8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v7+48]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v8+A0]");
		object obj12 = 0;
		if (obj12 != null)
		{
			object obj13 = (nint)0 + (nint)309;
			object obj14 = obj13 & 1;
			bool flag4 = obj14 == null;
			object obj15 = !flag4;
			nint num3 = 0;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v8 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1>)+A8]");
			object obj16 = 0;
			object obj17 = value & 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @44417D8");
			StructWrapper<T> result = default;
			return result;
		}
		return (StructWrapper<T>)(object)new NullReferenceException();
	}

	static StructWrapper()
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got I4
		//IL_0179: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I
		//IL_01b7: Expected Obj, but got I
		//IL_01d1: Expected Obj, but got I4
		//IL_01ef: Expected Obj, but got I
		//IL_01ff: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X0_v2 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj5 = (nint)0 + (nint)309;
		object obj6 = obj5 & 1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		nint num2 = 0;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num2 = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4441618");
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			nint num3 = 0;
		}
		else
		{
			nint num3 = 0;
			nint num4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v7 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1>)+A8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X9_v5+48]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X9_v6+A0]");
		object obj14 = 0;
		object obj15 = default;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v9 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1>)+135]");
		object obj16 = (nint)0 & (nint)1;
		bool flag4 = obj16 == null;
		object obj17 = !flag4;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			nint num3 = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v9 (Il2CppClass<Photon.Client.StructWrapping.StructWrapper`1>)+A8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v10+48]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
