using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Fusion;

[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
public struct NetworkSceneLoadId(byte value) : _0021_00210
{
	[FieldOffset(0)]
	public readonly byte Value = value;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_VALUE = default(int);

	internal const int BYTE_COUNT_OF_VALUE = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public bool Equals(NetworkSceneLoadId other)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		object obj = Value - other;
		return obj == null;
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9F38]");
			object obj2 = 0;
			if (obj == obj2)
			{
				byte value = Value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				object obj3 = (nint)(int)value - (nint)0;
				return obj3 == null;
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ((byte)this).GetHashCode();
	}

	public static bool operator ==(NetworkSceneLoadId left, NetworkSceneLoadId right)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = left & 0xFF;
		object obj2 = obj - right;
		return obj2 == null;
	}

	public static bool operator !=(NetworkSceneLoadId left, NetworkSceneLoadId right)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = left & 0xFF;
		object obj2 = obj - right;
		bool flag = obj2 == null;
		return !flag;
	}

	public static implicit operator NetworkSceneLoadId(byte value)
	{
		//IL_0005: Expected VT, but got I4
		return (NetworkSceneLoadId)value;
	}

	public override string ToString()
	{
		return ((byte)this).ToString();
	}
}
