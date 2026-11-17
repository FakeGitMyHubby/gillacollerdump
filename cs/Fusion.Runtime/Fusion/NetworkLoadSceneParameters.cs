using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab.ClientModels;
using UnityEngine.SceneManagement;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 2)]
public struct NetworkLoadSceneParameters : Action<UpdateUserDataResult>
{
	[FieldOffset(0)]
	public readonly NetworkSceneLoadId LoadId;

	[FieldOffset(1)]
	private readonly NetworkLoadSceneParametersFlags _flags;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_LOAD_ID = default(int);

	internal const int BYTE_COUNT_OF_LOAD_ID = default(int);

	internal const int BYTE_OF__FLAGS = default(int);

	internal const int BYTE_COUNT_OF__FLAGS = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public LoadSceneMode LoadSceneMode
	{
		get
		{
			//IL_000b: Expected Obj, but got I4
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected I4, but got Unknown
			object obj = ~(int)_flags;
			return (LoadSceneMode)(1 & obj);
		}
	}

	public LocalPhysicsMode LocalPhysicsMode
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected I4, but got Unknown
			object obj = (int)_flags >> 1;
			return (LocalPhysicsMode)(obj & 3);
		}
	}

	public LoadSceneParameters LoadSceneParameters
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected I4, but got Unknown
			//IL_0029: Expected Obj, but got I4
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected I4, but got Unknown
			object obj = (int)_flags >> 1;
			LocalPhysicsMode physicsMode = (LocalPhysicsMode)(obj & 3);
			object obj2 = ~(int)_flags;
			LoadSceneMode mode = (LoadSceneMode)(1 & obj2);
			return new LoadSceneParameters(mode, physicsMode);
		}
	}

	public bool IsActiveOnLoad
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected I4, but got Unknown
			object obj = (int)_flags >> 3;
			return (byte)(obj & 1) != 0;
		}
	}

	public bool IsSingleLoad => (byte)(_flags & (NetworkLoadSceneParametersFlags)1) != 0;

	public bool IsLocalPhysics2D
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected I4, but got Unknown
			object obj = (int)_flags >> 1;
			return (byte)(obj & 1) != 0;
		}
	}

	public bool IsLocalPhysics3D
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected I4, but got Unknown
			object obj = (int)_flags >> 2;
			return (byte)(obj & 1) != 0;
		}
	}

	internal NetworkLoadSceneParametersFlags Flags => _flags;

	internal NetworkLoadSceneParameters(NetworkSceneLoadId loadId, NetworkLoadSceneParametersFlags flags)
	{
		LoadId = loadId;
		_flags = flags;
	}

	public bool Equals(NetworkLoadSceneParameters other)
	{
		//IL_000e: Expected Obj, but got VT
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_004c: Expected Obj, but got VT
		object obj = other >> 8;
		object obj2 = obj & 0xFFFFFF;
		if ((int)_flags == (nint)obj2)
		{
			object obj3 = LoadId - other;
			return obj3 == null;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7EE0]");
			object obj2 = 0;
			if (obj == obj2)
			{
				NetworkLoadSceneParametersFlags flags = _flags;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				if ((nint)(int)flags == 0)
				{
					NetworkSceneLoadId loadId = LoadId;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
					object obj3 = loadId - 0;
					return obj3 == null;
				}
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		//IL_001a: Expected Obj, but got I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got Unknown
		int hashCode = ((byte)this).GetHashCode();
		object obj = (int)_flags * 397;
		return obj ^ hashCode;
	}

	public static bool operator ==(NetworkLoadSceneParameters left, NetworkLoadSceneParameters right)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = left & 0xFFFF;
		object obj2 = obj - right;
		return obj2 == null;
	}

	public static bool operator !=(NetworkLoadSceneParameters left, NetworkLoadSceneParameters right)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = left & 0xFFFF;
		object obj2 = obj - right;
		bool flag = obj2 == null;
		return !flag;
	}

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F38]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F48]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		object arg2 = default;
		return string.Format((string)format, arg, arg2);
	}
}
