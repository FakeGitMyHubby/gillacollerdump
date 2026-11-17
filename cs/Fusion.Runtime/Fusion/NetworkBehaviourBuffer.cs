using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

public struct NetworkBehaviourBuffer
{
	internal unsafe int* _ptr;

	internal int _length;

	internal Tick _tick;

	public Tick Tick => _tick;

	public int Length => _length;

	public unsafe bool Valid
	{
		get
		{
			//IL_0089: Expected Obj, but got I4
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Expected I4, but got Unknown
			if (_ptr != null)
			{
				bool flag = _length < 0;
				bool flag2 = _length == 0;
				int num = _length ^ _length;
				int num2 = _length & num;
				bool flag3 = num2 < 0;
				bool flag4 = flag == flag3;
				object obj = !flag2;
				return (byte)((flag4 & obj) ? 1 : 0) != 0;
			}
			return false;
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public unsafe int get_Item(int index)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I4
		//IL_0059: Expected Obj, but got I4
		//IL_0066: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B58]");
		object error = 0;
		bool flag = _length < index;
		object obj = !flag;
		object obj2 = _length - index;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		bool condition = (byte)(obj & obj3) != 0;
		Assert.Check(condition, (string)error);
		int* ptr = _ptr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4 (System.Int32*)+index @ X1 (System.Int32)*4]");
		return 0;
	}

	public unsafe T ReinterpretState<T>(int offset = default(int)) where T : struct
	{
		//IL_0010: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_0093: Expected I4, but got Obj
		//IL_00bb: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected I4, but got Unknown
		//IL_014a: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B70]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8080]");
		object error2 = 0;
		bool valid = Valid;
		Assert.Check(valid, (string)error);
		bool flag = _length < offset;
		object obj = !flag;
		object obj2 = _length - offset;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		bool condition = (byte)(obj & obj3) != 0;
		Assert.Check(condition, offset, _length);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4038]");
		object error3 = 0;
		Assert.Always(condition: true, (string)error3);
		object obj4 = offset + 1;
		bool flag3 = (nint)obj4 < _length;
		object obj5 = !flag3;
		object obj6 = obj4 - _length;
		bool flag4 = obj6 == null;
		object obj7 = ~obj5;
		bool condition2 = (byte)((obj7 | flag4) ? 1 : 0) != 0;
		Assert.Check(condition2, (string)error2);
		int* ptr = _ptr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v8 (System.Int32*)+offset @ X1 (System.Int32)*4]");
		return (T)0;
	}

	internal unsafe NetworkBehaviourBuffer(Tick tick, int* ptr, int length)
	{
		_ptr = ptr;
		_length = length;
		_tick = tick;
	}

	public T Read<T>(NetworkBehaviour.BehaviourReader<T> reader) where T : NetworkBehaviour
	{
		//IL_0022: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X3+38]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X3+38]");
			bool flag2 = (nint)0 == 0;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			}
		}
		bool valid = Valid;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B70]");
		object error = 0;
		Assert.Check(valid, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F6E024");
		T result = default;
		return result;
	}

	public unsafe T Read<T>(NetworkBehaviour.PropertyReader<T> reader) where T : struct
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_005b: Invalid comparison between I4 and VT
		//IL_006c: Expected Obj, but got I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0095: Expected Obj, but got I4
		//IL_00a2: Expected I4, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00fb: Expected Obj, but got I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected I4, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0173: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B70]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B68]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8078]");
		object error3 = 0;
		bool valid = Valid;
		Assert.Check(valid, (string)error);
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)_length) < System.Runtime.CompilerServices.Unsafe.As<NetworkBehaviour.PropertyReader<T>, UIntPtr>(ref reader);
		object obj = !flag;
		object obj2 = _length - reader;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		bool condition = (byte)(obj & obj3) != 0;
		Assert.Check(condition, (string)error2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4038]");
		object error4 = 0;
		Assert.Always(condition: true, (string)error4);
		object obj4 = reader + 1;
		bool flag3 = (nint)obj4 < _length;
		object obj5 = !flag3;
		object obj6 = obj4 - _length;
		bool flag4 = obj6 == null;
		object obj7 = ~obj5;
		bool condition2 = (byte)((obj7 | flag4) ? 1 : 0) != 0;
		Assert.Check(condition2, (string)error3);
		int* ptr = _ptr;
		object obj8 = reader & 0xFFFFFFFFL;
		object obj9 = obj8 << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X9_v2+v105 @ X8_v9 (System.Int32*)]");
		return (T)0;
	}

	public unsafe float Read(NetworkBehaviour.PropertyReader<float> reader)
	{
		//IL_00de: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I
		//IL_0134: Invalid comparison between I4 and VT
		//IL_0145: Expected Obj, but got I4
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got I4
		//IL_017b: Expected I4, but got Obj
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01b1: Expected Obj, but got I4
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected I4, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected I4, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00ce: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B70]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B68]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B60]");
		object error3 = 0;
		bool condition;
		if (_ptr != null)
		{
			bool flag = _length < 0;
			bool flag2 = _length == 0;
			int num = _length ^ _length;
			int num2 = _length & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			bool flag5 = (byte)((flag4 & obj) ? 1 : 0) != 0;
			condition = flag5;
		}
		else
		{
			condition = false;
		}
		Assert.Check(condition, (string)error);
		bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)_length) < System.Runtime.CompilerServices.Unsafe.As<NetworkBehaviour.PropertyReader<float>, UIntPtr>(ref reader);
		object obj2 = !flag6;
		object obj3 = _length - reader;
		bool flag7 = obj3 == null;
		object obj4 = !flag7;
		bool condition2 = (byte)(obj2 & obj4) != 0;
		Assert.Check(condition2, (string)error2);
		object obj5 = reader + 1;
		bool flag8 = (nint)obj5 < _length;
		object obj6 = !flag8;
		object obj7 = obj5 - _length;
		bool flag9 = obj7 == null;
		object obj8 = ~obj6;
		bool condition3 = (byte)((obj8 | flag9) ? 1 : 0) != 0;
		Assert.Check(condition3, (string)error3);
		int* ptr = _ptr;
		object obj9 = reader & 0xFFFFFFFFL;
		object obj10 = obj9 << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X9_v4+v123 @ X8_v7 (System.Int32*)]");
		return 0f;
	}

	public unsafe Vector2 Read(NetworkBehaviour.PropertyReader<Vector2> reader)
	{
		//IL_00ac: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_0102: Invalid comparison between I4 and VT
		//IL_0113: Expected Obj, but got I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_013c: Expected Obj, but got I4
		//IL_0149: Expected I4, but got Obj
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_017f: Expected Obj, but got I4
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected VT, but got Unknown
		//IL_01c0: Expected I4, but got VT
		//IL_006f: Expected Obj, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B70]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B68]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B78]");
		object error3 = 0;
		bool condition;
		if (_ptr != null)
		{
			bool flag = _length < 0;
			bool flag2 = _length == 0;
			int num = _length ^ _length;
			int num2 = _length & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			bool flag5 = (byte)((flag4 & obj) ? 1 : 0) != 0;
			condition = flag5;
		}
		else
		{
			condition = false;
		}
		Assert.Check(condition, (string)error);
		bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)_length) < System.Runtime.CompilerServices.Unsafe.As<NetworkBehaviour.PropertyReader<Vector2>, UIntPtr>(ref reader);
		object obj2 = !flag6;
		object obj3 = _length - reader;
		bool flag7 = obj3 == null;
		object obj4 = !flag7;
		bool condition2 = (byte)(obj2 & obj4) != 0;
		Assert.Check(condition2, (string)error2);
		object obj5 = reader + 2;
		bool flag8 = (nint)obj5 < _length;
		object obj6 = !flag8;
		object obj7 = obj5 - _length;
		bool flag9 = obj7 == null;
		object obj8 = ~obj6;
		Vector2 vector = (Vector2)(obj8 | flag9);
		Assert.Check((byte)(int)vector != 0, (string)error3);
		return vector;
	}

	public unsafe Vector3 Read(NetworkBehaviour.PropertyReader<Vector3> reader)
	{
		//IL_00ac: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_0102: Invalid comparison between I4 and VT
		//IL_0113: Expected Obj, but got I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_013c: Expected Obj, but got I4
		//IL_0149: Expected I4, but got Obj
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_017f: Expected Obj, but got I4
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected VT, but got Unknown
		//IL_01c0: Expected I4, but got VT
		//IL_006f: Expected Obj, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B70]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B68]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B80]");
		object error3 = 0;
		bool condition;
		if (_ptr != null)
		{
			bool flag = _length < 0;
			bool flag2 = _length == 0;
			int num = _length ^ _length;
			int num2 = _length & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			bool flag5 = (byte)((flag4 & obj) ? 1 : 0) != 0;
			condition = flag5;
		}
		else
		{
			condition = false;
		}
		Assert.Check(condition, (string)error);
		bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)_length) < System.Runtime.CompilerServices.Unsafe.As<NetworkBehaviour.PropertyReader<Vector3>, UIntPtr>(ref reader);
		object obj2 = !flag6;
		object obj3 = _length - reader;
		bool flag7 = obj3 == null;
		object obj4 = !flag7;
		bool condition2 = (byte)(obj2 & obj4) != 0;
		Assert.Check(condition2, (string)error2);
		object obj5 = reader + 3;
		bool flag8 = (nint)obj5 < _length;
		object obj6 = !flag8;
		object obj7 = obj5 - _length;
		bool flag9 = obj7 == null;
		object obj8 = ~obj6;
		Vector3 vector = (Vector3)(obj8 | flag9);
		Assert.Check((byte)(int)vector != 0, (string)error3);
		return vector;
	}

	public unsafe Vector4 Read(NetworkBehaviour.PropertyReader<Vector4> reader)
	{
		//IL_00ac: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_0102: Invalid comparison between I4 and VT
		//IL_0113: Expected Obj, but got I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_013c: Expected Obj, but got I4
		//IL_0149: Expected I4, but got Obj
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_017f: Expected Obj, but got I4
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected VT, but got Unknown
		//IL_01c0: Expected I4, but got VT
		//IL_006f: Expected Obj, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B70]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B68]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B88]");
		object error3 = 0;
		bool condition;
		if (_ptr != null)
		{
			bool flag = _length < 0;
			bool flag2 = _length == 0;
			int num = _length ^ _length;
			int num2 = _length & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			bool flag5 = (byte)((flag4 & obj) ? 1 : 0) != 0;
			condition = flag5;
		}
		else
		{
			condition = false;
		}
		Assert.Check(condition, (string)error);
		bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)_length) < System.Runtime.CompilerServices.Unsafe.As<NetworkBehaviour.PropertyReader<Vector4>, UIntPtr>(ref reader);
		object obj2 = !flag6;
		object obj3 = _length - reader;
		bool flag7 = obj3 == null;
		object obj4 = !flag7;
		bool condition2 = (byte)(obj2 & obj4) != 0;
		Assert.Check(condition2, (string)error2);
		object obj5 = reader + 4;
		bool flag8 = (nint)obj5 < _length;
		object obj6 = !flag8;
		object obj7 = obj5 - _length;
		bool flag9 = obj7 == null;
		object obj8 = ~obj6;
		Vector4 vector = (Vector4)(obj8 | flag9);
		Assert.Check((byte)(int)vector != 0, (string)error3);
		return vector;
	}

	public unsafe Quaternion Read(NetworkBehaviour.PropertyReader<Quaternion> reader)
	{
		//IL_00ac: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_0102: Invalid comparison between I4 and VT
		//IL_0113: Expected Obj, but got I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_013c: Expected Obj, but got I4
		//IL_0149: Expected I4, but got Obj
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_017f: Expected Obj, but got I4
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected VT, but got Unknown
		//IL_01c0: Expected I4, but got VT
		//IL_006f: Expected Obj, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B70]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B68]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B88]");
		object error3 = 0;
		bool condition;
		if (_ptr != null)
		{
			bool flag = _length < 0;
			bool flag2 = _length == 0;
			int num = _length ^ _length;
			int num2 = _length & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			bool flag5 = (byte)((flag4 & obj) ? 1 : 0) != 0;
			condition = flag5;
		}
		else
		{
			condition = false;
		}
		Assert.Check(condition, (string)error);
		bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)_length) < System.Runtime.CompilerServices.Unsafe.As<NetworkBehaviour.PropertyReader<Quaternion>, UIntPtr>(ref reader);
		object obj2 = !flag6;
		object obj3 = _length - reader;
		bool flag7 = obj3 == null;
		object obj4 = !flag7;
		bool condition2 = (byte)(obj2 & obj4) != 0;
		Assert.Check(condition2, (string)error2);
		object obj5 = reader + 4;
		bool flag8 = (nint)obj5 < _length;
		object obj6 = !flag8;
		object obj7 = obj5 - _length;
		bool flag9 = obj7 == null;
		object obj8 = ~obj6;
		Quaternion quaternion = (Quaternion)(obj8 | flag9);
		Assert.Check((byte)(int)quaternion != 0, (string)error3);
		return quaternion;
	}

	public static implicit operator bool(NetworkBehaviourBuffer buffer)
	{
		//IL_0009: Invalid comparison between VT and I4
		//IL_001a: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected I4, but got Unknown
		//IL_005c: Expected Obj, but got I
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		bool flag = buffer == (NetworkBehaviourBuffer)(object)0;
		object obj = !flag;
		object obj2 = ~obj;
		bool flag2;
		bool flag3;
		bool flag4;
		if (obj2 == null)
		{
			nint num = default;
			flag2 = num < 0;
			flag3 = num == 0;
			object obj3 = num ^ num;
			object obj4 = num & obj3;
			flag4 = (nint)obj4 < 0;
		}
		else
		{
			flag4 = false;
			flag3 = true;
			flag2 = false;
		}
		bool flag5 = flag2 == flag4;
		object obj5 = !flag3;
		return (byte)((flag5 & obj5) ? 1 : 0) != 0;
	}
}
