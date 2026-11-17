using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

internal struct NetworkObjectHeaderSnapshotList
{
	public const int SIZE = default(int);

	public const int ALIGNMENT = default(int);

	private int _count;

	private NetworkObjectHeaderSnapshot _tail;

	private NetworkObjectHeaderSnapshot _head;

	public int Count => _count;

	public NetworkObjectHeaderSnapshot Oldest => _tail;

	public NetworkObjectHeaderSnapshot Latest => _head;

	public unsafe void AddFirst(NetworkObjectHeaderSnapshot item)
	{
		//IL_0113: Expected Obj, but got Ref
		//IL_0123: Expected Obj, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_0093: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002d: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got Ref
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62E0]");
		object error = 0;
		object obj2 = obj;
		while (obj2 != item)
		{
			obj2 += 24;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				break;
			}
		}
		bool condition = obj2 == null;
		Assert.Check(condition, (string)error);
		object obj4 = item + 24;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = item + 16;
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		if (obj != null)
		{
			object obj6 = obj + 16;
			obj6 = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			_head = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		}
		obj = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int count = _count + 1;
		_count = count;
	}

	public unsafe void AddLast(NetworkObjectHeaderSnapshot item)
	{
		//IL_0100: Expected Obj, but got Ref
		//IL_0110: Expected Obj, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got Ref
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002d: Expected Obj, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62E0]");
		object error = 0;
		object obj2 = obj;
		while (obj2 != item)
		{
			obj2 += 24;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				break;
			}
		}
		bool condition = obj2 == null;
		Assert.Check(condition, (string)error);
		object obj4 = item + 24;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		object obj6 = item + 16;
		obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj5 + 24;
		object obj8;
		if (obj5 == null)
		{
			obj8 = obj;
		}
		else
		{
			obj8 = obj7;
		}
		obj8 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		obj5 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int count = _count + 1;
		_count = count;
	}

	public unsafe void AddBefore(NetworkObjectHeaderSnapshot before, NetworkObjectHeaderSnapshot item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02a3: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I
		//IL_02be: Expected Obj, but got Ref
		//IL_02ce: Expected Obj, but got I
		//IL_0338: Expected Obj, but got I4
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected I4, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01df: Expected Obj, but got I4
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_025d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7298]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8508]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62E0]");
		object error3 = 0;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62C8]");
		object error4 = 0;
		bool flag = _count < 0;
		bool flag2 = _count == 0;
		int num = _count ^ _count;
		int num2 = _count & num;
		bool flag3 = num2 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		bool condition = (byte)((flag4 & obj2) ? 1 : 0) != 0;
		Assert.Check(condition, (string)error);
		object obj3 = obj;
		while (obj3 != before)
		{
			obj3 += 24;
			bool flag5 = obj3 == null;
			object obj4 = !flag5;
			if (obj4 == null)
			{
				break;
			}
		}
		bool flag6 = obj3 == null;
		bool condition2 = !flag6;
		Assert.Check(condition2, (string)error2);
		object obj5 = obj;
		while (obj5 != item)
		{
			obj5 += 24;
			bool flag7 = obj5 == null;
			object obj6 = !flag7;
			if (obj6 == null)
			{
				break;
			}
		}
		bool condition3 = obj5 == null;
		Assert.Check(condition3, (string)error3);
		if (obj != before)
		{
			object obj7 = item + 24;
			obj7 = before;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj8 = before + 16;
			object obj9 = item + 16;
			obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj10 = obj8 + 24;
			obj10 = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj8 = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int count = _count + 1;
			_count = count;
		}
		else
		{
			AddFirst(item);
		}
		object obj11 = obj;
		while (obj11 != before)
		{
			obj11 += 24;
			bool flag8 = obj11 == null;
			object obj12 = !flag8;
			if (obj12 == null)
			{
				break;
			}
		}
		bool flag9 = obj11 == null;
		bool condition4 = !flag9;
		Assert.Check(condition4, (string)error2);
		while (obj != item)
		{
			obj += 24;
			bool flag10 = obj == null;
			object obj13 = !flag10;
			if (obj13 == null)
			{
				break;
			}
		}
		bool flag11 = obj == null;
		bool condition5 = !flag11;
		Assert.Check(condition5, (string)error4);
	}

	public unsafe void AddAfter(NetworkObjectHeaderSnapshot after, NetworkObjectHeaderSnapshot item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02af: Expected Obj, but got I
		//IL_02bf: Expected Obj, but got I
		//IL_02ca: Expected Obj, but got Ref
		//IL_02da: Expected Obj, but got I
		//IL_0344: Expected Obj, but got I4
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected I4, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01eb: Expected Obj, but got I4
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_0269: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7298]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62B8]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62E0]");
		object error3 = 0;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62C8]");
		object error4 = 0;
		bool flag = _count < 0;
		bool flag2 = _count == 0;
		int num = _count ^ _count;
		int num2 = _count & num;
		bool flag3 = num2 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		bool condition = (byte)((flag4 & obj2) ? 1 : 0) != 0;
		Assert.Check(condition, (string)error);
		object obj3 = obj;
		while (obj3 != after)
		{
			obj3 += 24;
			bool flag5 = obj3 == null;
			object obj4 = !flag5;
			if (obj4 == null)
			{
				break;
			}
		}
		bool flag6 = obj3 == null;
		bool condition2 = !flag6;
		Assert.Check(condition2, (string)error2);
		object obj5 = obj;
		while (obj5 != item)
		{
			obj5 += 24;
			bool flag7 = obj5 == null;
			object obj6 = !flag7;
			if (obj6 == null)
			{
				break;
			}
		}
		bool condition3 = obj5 == null;
		Assert.Check(condition3, (string)error3);
		if (_tail != after)
		{
			object obj7 = item + 24;
			obj7 = after.Next;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj8 = item + 16;
			obj8 = after;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj9 = after.Next + 16;
			obj9 = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj10 = after + 24;
			after.Next = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int count = _count + 1;
			_count = count;
		}
		else
		{
			AddLast(item);
		}
		object obj11 = obj;
		while (obj11 != after)
		{
			obj11 += 24;
			bool flag8 = obj11 == null;
			object obj12 = !flag8;
			if (obj12 == null)
			{
				break;
			}
		}
		bool flag9 = obj11 == null;
		bool condition4 = !flag9;
		Assert.Check(condition4, (string)error2);
		while (obj != item)
		{
			obj += 24;
			bool flag10 = obj == null;
			object obj13 = !flag10;
			if (obj13 == null)
			{
				break;
			}
		}
		bool flag11 = obj == null;
		bool condition5 = !flag11;
		Assert.Check(condition5, (string)error4);
	}

	public unsafe NetworkObjectHeaderSnapshot RemoveOldest()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected I4, but got Unknown
		//IL_0162: Expected Obj, but got Ref
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7298]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8510]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8518]");
		object error3 = 0;
		bool flag = _count < 0;
		bool flag2 = _count == 0;
		int num = _count ^ _count;
		int num2 = _count & num;
		bool flag3 = num2 < 0;
		bool flag4 = flag == flag3;
		object obj = !flag2;
		bool condition = (byte)((flag4 & obj) ? 1 : 0) != 0;
		Assert.Check(condition, (string)error);
		bool flag5 = _tail == null;
		bool condition2 = !flag5;
		Assert.Check(condition2, (string)error2);
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		while (obj2 != _tail)
		{
			obj2 += 24;
			bool flag6 = obj2 == null;
			object obj3 = !flag6;
			if (obj3 == null)
			{
				break;
			}
		}
		bool flag7 = obj2 == null;
		bool condition3 = !flag7;
		Assert.Check(condition3, (string)error3);
		Remove(_tail);
		return _tail;
	}

	public unsafe NetworkObjectHeaderSnapshot RemoveLatest()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected I4, but got Unknown
		//IL_0139: Expected Obj, but got Ref
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7298]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8520]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8528]");
		object error3 = 0;
		bool flag = _count < 0;
		bool flag2 = _count == 0;
		int num = _count ^ _count;
		int num2 = _count & num;
		bool flag3 = num2 < 0;
		bool flag4 = flag == flag3;
		object obj = !flag2;
		bool condition = (byte)((flag4 & obj) ? 1 : 0) != 0;
		Assert.Check(condition, (string)error);
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		bool flag5 = obj2 == null;
		bool condition2 = !flag5;
		Assert.Check(condition2, (string)error2);
		while (obj2 != obj2)
		{
			obj2 += 24;
			bool flag6 = obj2 == null;
			object obj3 = !flag6;
			if (obj3 == null)
			{
				break;
			}
		}
		bool flag7 = obj2 == null;
		bool condition3 = !flag7;
		Assert.Check(condition3, (string)error3);
		Remove(_head);
		return _head;
	}

	public unsafe void Remove(NetworkObjectHeaderSnapshot item)
	{
		//IL_01d4: Expected Obj, but got Ref
		//IL_01e4: Expected Obj, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002d: Expected Obj, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_0117: Expected Obj, but got Ref
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_018c: Expected Obj, but got I4
		//IL_019f: Expected Obj, but got I4
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62C8]");
		object error = 0;
		object obj2 = obj;
		while (obj2 != item)
		{
			obj2 += 24;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				break;
			}
		}
		bool flag2 = obj2 == null;
		bool condition = !flag2;
		Assert.Check(condition, (string)error);
		object obj4 = item + 16;
		if (obj4 != null)
		{
			object obj5 = obj4 + 24;
			obj5 = item.Next;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		object obj6 = item + 24;
		if (obj6 != null)
		{
			object obj7 = obj6 + 16;
			obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		if (obj8 == item)
		{
			obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		if (obj == item)
		{
			obj = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int count = _count - 1;
		_count = count;
	}

	private unsafe bool IsInList(NetworkObjectHeaderSnapshot item)
	{
		//IL_000b: Expected Obj, but got Ref
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		while (obj != item)
		{
			obj += 24;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				break;
			}
		}
		bool flag2 = obj == null;
		return !flag2;
	}
}
