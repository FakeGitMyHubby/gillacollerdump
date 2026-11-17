using System.Runtime.CompilerServices;
using UnityEngine;

namespace Fusion;

public static class ReadWriteUtils
{
	public const float ACCURACY = default(float);

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static void WriteFloat(int* data, float f)
	{
		//IL_0008: Expected I, but got F4
		int* ptr = (int*)(nint)f;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static float ReadFloat(int* data)
	{
		//IL_0005: Expected F4, but got I
		return (nint)data;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static void WriteVector2(int* data, Vector2 value)
	{
		//IL_0008: Expected I, but got Obj
		object obj = default;
		int* ptr = (int*)(nint)obj;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static Vector2 ReadVector2(int* data)
	{
		//IL_0005: Expected VT, but got I
		return (Vector2)data;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static void WriteVector3(int* data, Vector3 value)
	{
		//IL_0008: Expected I, but got Obj
		object obj = default;
		int* ptr = (int*)(nint)obj;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static Vector3 ReadVector3(int* data)
	{
		//IL_0005: Expected VT, but got I
		return (Vector3)data;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static void WriteVector4(int* data, Vector4 value)
	{
		//IL_0008: Expected I, but got Obj
		object obj = default;
		int* ptr = (int*)(nint)obj;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static Vector4 ReadVector4(int* data)
	{
		//IL_0005: Expected VT, but got I
		return (Vector4)data;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static void WriteQuaternion(int* data, Quaternion value)
	{
		//IL_0008: Expected I, but got Obj
		object obj = default;
		int* ptr = (int*)(nint)obj;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static Quaternion ReadQuaternion(int* data)
	{
		//IL_0005: Expected VT, but got I
		return (Quaternion)data;
	}
}
