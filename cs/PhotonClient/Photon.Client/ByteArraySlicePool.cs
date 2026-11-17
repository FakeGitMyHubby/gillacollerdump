using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;

namespace Photon.Client;

public class ByteArraySlicePool
{
	private int minStackIndex;

	internal readonly Stack<ByteArraySlice>[] poolTiers;

	private int allocationCounter;

	public int MinStackIndex
	{
		get
		{
			return minStackIndex;
		}
		set
		{
			//IL_001a: Expected Obj, but got I4
			bool flag = value < 31;
			object obj = !flag;
			object obj2 = ~obj;
			object obj3 = ~obj2;
			int num = ((obj3 != null) ? 31 : value);
			if (value < 1)
			{
				num = 1;
			}
			minStackIndex = num;
		}
	}

	public int AllocationCounter => allocationCounter;

	public unsafe ByteArraySlicePool()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got Ref
		//IL_01d7: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got Ref
		//IL_01ff: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6515FB8]");
		object obj = 0;
		minStackIndex = 7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 24;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
		bool lockTaken = default;
		Monitor.Enter(obj2, ref lockTaken);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6515FC8]");
		object obj4 = 0;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6515FC0]");
		Stack<System.__Canon> stack = (Stack<System.__Canon>)0;
		Stack<System.__Canon> stack2 = default;
		stack2._002Ector();
		bool flag = obj2 == null;
		object obj6 = 0;
		OutOfMemoryException ex = null;
		IndexOutOfRangeException ex2 = default;
		Stack<System.__Canon> stack3;
		if (!flag)
		{
			if (stack2 != null)
			{
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v23+40]");
				stack = (Stack<System.__Canon>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag2 = ex2 == null;
				obj6 = 0;
				ex = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v23+40]");
				stack3 = (Stack<System.__Canon>)0;
				if (flag2)
				{
					goto IL_0257;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X19_v2+18]");
			bool flag3 = (nint)0 == 0;
			obj6 = 0;
			ex = null;
			if (flag3)
			{
				goto IL_0241;
			}
			object obj8 = obj2 + 32;
			obj8 = stack2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj6 = 0;
			ex = null;
			stack = stack2;
			if ((object)(&lockTaken) != null)
			{
				object obj9 = default;
				Monitor.Exit((object)(&obj9));
				stack = null;
			}
			if ((object)(ex != null) == null)
			{
				object obj10 = obj6 != null;
				OutOfMemoryException ex3 = ex;
				if (obj10 == null)
				{
					return;
				}
			}
			else
			{
				OutOfMemoryException ex3 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		}
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0241;
		IL_0257:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex5 = new ArgumentNullException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0241:
		ex2 = new IndexOutOfRangeException();
		stack3 = stack;
		goto IL_0257;
	}

	public unsafe ByteArraySlice Acquire(byte[] buffer, int offset = default(int), int count = default(int))
	{
		//IL_003b: Expected Obj, but got Ref
		//IL_0044: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got Ref
		//IL_0092: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got Ref
		//IL_0103: Expected Obj, but got Ref
		//IL_0114: Expected Obj, but got Ref
		//IL_011d: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I4
		//IL_0173: Expected Obj, but got Ref
		//IL_017b: Expected Obj, but got Ref
		//IL_018c: Expected Obj, but got Ref
		//IL_0195: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got Ref
		//IL_0210: Expected Obj, but got Ref
		//IL_0222: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got I4
		//IL_047c: Expected Obj, but got I4
		//IL_0292: Expected Obj, but got I4
		//IL_02b1: Expected Obj, but got I4
		//IL_05ad: Expected Obj, but got Ref
		//IL_04ee: Expected Obj, but got I4
		//IL_02eb: Expected Obj, but got I4
		//IL_053d: Expected Obj, but got I4
		//IL_02be: Expected Obj, but got Ref
		//IL_0313: Expected Obj, but got I4
		//IL_0360: Expected Obj, but got I4
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected Obj, but got Unknown
		bool lockTaken = default;
		Monitor.Enter(poolTiers, ref lockTaken);
		Stack<ByteArraySlice>[] array = poolTiers;
		bool flag = poolTiers == null;
		int num = 0;
		Stack<ByteArraySlice> stack = (Stack<ByteArraySlice>)(&lockTaken);
		object obj = 0;
		NullReferenceException ex = null;
		bool lockTaken2 = false;
		object obj2 = null;
		if (flag)
		{
			goto IL_03c8;
		}
		bool flag2 = array.Length == 0;
		num = 0;
		stack = (Stack<ByteArraySlice>)(&lockTaken);
		obj = 0;
		ex = null;
		lockTaken2 = false;
		obj2 = null;
		if (flag2)
		{
			goto IL_03e5;
		}
		Monitor.Enter(array[0], ref lockTaken2);
		Stack<ByteArraySlice>[] array2 = poolTiers;
		bool flag3 = poolTiers == null;
		object obj3 = 0;
		IndexOutOfRangeException ex2 = null;
		object obj4 = (object)(&obj2);
		object obj5 = (object)(&lockTaken2);
		num = 0;
		stack = (Stack<ByteArraySlice>)(&lockTaken2);
		obj = 0;
		ex = null;
		lockTaken2 = false;
		obj2 = array[0];
		if (flag3)
		{
			goto IL_03f3;
		}
		bool flag4 = array2.Length == 0;
		obj3 = 0;
		ex2 = null;
		obj4 = (object)(&obj2);
		obj5 = (object)(&lockTaken2);
		num = 0;
		stack = (Stack<ByteArraySlice>)(&lockTaken2);
		obj = 0;
		ex = null;
		lockTaken2 = false;
		obj2 = array[0];
		if (flag4)
		{
			goto IL_040f;
		}
		stack = array2[0];
		ByteArraySlice byteArraySlice = PopOrCreate(array2[0], 0);
		obj3 = 0;
		ex2 = null;
		obj4 = (object)(&obj2);
		obj5 = (object)(&lockTaken2);
		num = 0;
		obj = 0;
		ex = null;
		lockTaken2 = false;
		ByteArraySlice byteArraySlice2 = byteArraySlice;
		goto IL_0560;
		IL_03d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_03e5;
		IL_0401:
		OutOfMemoryException ex3 = new OutOfMemoryException();
		goto IL_040f;
		IL_03c8:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_03d6;
		IL_041d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_042c;
		IL_0560:
		if (obj5 != null)
		{
			Monitor.Exit(obj4);
			stack = null;
		}
		bool flag5 = ex2 == null;
		object obj6 = !flag5;
		if (obj6 != null)
		{
			goto IL_0401;
		}
		bool flag6 = obj3 == null;
		object obj7 = !flag6;
		IndexOutOfRangeException ex5 = ex2;
		if (obj7 != null)
		{
			goto IL_041d;
		}
		object obj8 = 3;
		goto IL_05a5;
		IL_040f:
		ex5 = new IndexOutOfRangeException();
		goto IL_041d;
		IL_03f3:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_0401;
		IL_054c:
		return byteArraySlice2;
		IL_042c:
		NullReferenceException ex7 = new NullReferenceException();
		if ((nint)stack == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj3 = 1;
		}
		else
		{
			if ((nint)stack != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				if ((nint)stack == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj = 1;
				}
				else
				{
					if ((nint)stack != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						ByteArraySlice result = default;
						return result;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					object obj9 = default;
					ex = (NullReferenceException)obj9;
				}
				obj8 = 0;
				byteArraySlice2 = null;
				goto IL_05a5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj10 = default;
			ex2 = (IndexOutOfRangeException)obj10;
		}
		byteArraySlice2 = null;
		goto IL_0560;
		IL_05a5:
		object obj11 = (object)(&lockTaken);
		if (obj11 != null)
		{
			object obj13 = default;
			object obj12 = (object)(&obj13);
			Monitor.Exit(obj12);
			stack = null;
		}
		bool flag7 = ex == null;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			bool flag8 = obj == null;
			object obj15 = !flag8;
			ex4 = ex;
			if (obj15 != null)
			{
				goto IL_03d6;
			}
			if ((nint)obj8 != 3)
			{
				bool flag9 = obj8 == null;
				object obj16 = !flag9;
				if (obj16 != null)
				{
					goto IL_054c;
				}
			}
			if (byteArraySlice2 == null)
			{
				goto IL_042c;
			}
			object obj17 = byteArraySlice2 + 16;
			obj17 = buffer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			goto IL_054c;
		}
		OutOfMemoryException ex8 = new OutOfMemoryException();
		goto IL_03c8;
		IL_03e5:
		IndexOutOfRangeException ex9 = new IndexOutOfRangeException();
		goto IL_03f3;
	}

	public unsafe ByteArraySlice Acquire(int minByteCount)
	{
		//IL_09a5: Expected I4, but got I8
		//IL_09bf: Expected Obj, but got I4
		//IL_0701: Expected Obj, but got I
		//IL_0734: Expected I, but got Obj
		//IL_0744: Expected Obj, but got I
		//IL_0768: Expected Obj, but got I4
		//IL_09ff: Expected Obj, but got Ref
		//IL_0a07: Expected Obj, but got Ref
		//IL_0a28: Expected Obj, but got I4
		//IL_0a47: Expected Obj, but got Ref
		//IL_0a4f: Expected Obj, but got Ref
		//IL_003c: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got Ref
		//IL_00f9: Expected Obj, but got Ref
		//IL_011a: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got Ref
		//IL_0083: Expected Obj, but got I4
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_0166: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I4
		//IL_0a6a: Expected I4, but got Obj
		//IL_0a8f: Expected Obj, but got Ref
		//IL_01a6: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I
		//IL_0405: Expected Obj, but got Ref
		//IL_040d: Expected Obj, but got Ref
		//IL_042e: Expected Obj, but got I4
		//IL_043f: Expected Obj, but got I4
		//IL_044c: Expected Obj, but got Ref
		//IL_0454: Expected Obj, but got Ref
		//IL_0475: Expected Obj, but got Ref
		//IL_01f9: Expected Obj, but got Ref
		//IL_0201: Expected Obj, but got Ref
		//IL_0222: Expected Obj, but got I4
		//IL_03ea: Expected Obj, but got Ref
		//IL_0326: Expected Obj, but got I4
		//IL_032e: Expected Obj, but got Ref
		//IL_0336: Expected Obj, but got Ref
		//IL_0357: Expected Obj, but got I4
		//IL_0274: Expected I, but got Obj
		//IL_0284: Expected Obj, but got I
		//IL_02a5: Expected Obj, but got Ref
		//IL_02ad: Expected Obj, but got Ref
		//IL_02ce: Expected Obj, but got I4
		//IL_02f5: Expected Obj, but got I
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		int num = (int)(minByteCount & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		bool lockTaken = default;
		object obj6 = default;
		bool lockTaken2;
		Stack<System.__Canon> stack;
		Stack<ByteArraySlice> stack2;
		IndexOutOfRangeException ex2 = default;
		Stack<ByteArraySlice> stack5;
		if (obj == null)
		{
			int num2 = minStackIndex;
			if (minByteCount != 0)
			{
				object obj2 = minStackIndex - 31;
				bool flag2 = obj2 == null;
				object obj3 = !flag2;
				if (minStackIndex <= 31)
				{
					object obj4 = minByteCount - 1;
					while (obj4 >> num2 != 0)
					{
						num2++;
						if (num2 == 32)
						{
							num2 = 32;
							break;
						}
					}
				}
			}
			Monitor.Enter(poolTiers, ref lockTaken);
			Stack<ByteArraySlice>[] array = poolTiers;
			bool flag3 = poolTiers == null;
			object obj5 = (object)(&obj6);
			object obj7 = (object)(&lockTaken);
			lockTaken = false;
			obj6 = poolTiers;
			NullReferenceException ex = null;
			object obj8 = 0;
			int num3 = 0;
			lockTaken2 = false;
			stack = null;
			stack2 = (Stack<ByteArraySlice>)(&lockTaken);
			object obj9 = (object)(&obj6);
			if (!flag3)
			{
				obj9 = array.Length;
				bool flag4 = num2 < array.Length;
				object obj10 = !flag4;
				obj5 = (object)(&obj6);
				obj7 = (object)(&lockTaken);
				lockTaken = false;
				obj6 = poolTiers;
				ex = null;
				obj8 = 0;
				num3 = 0;
				lockTaken2 = false;
				stack = null;
				stack2 = (Stack<ByteArraySlice>)(&lockTaken);
				if (obj10 != null)
				{
					goto IL_080c;
				}
				object obj11 = poolTiers + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v27+20]");
				Stack<System.__Canon> stack3 = (Stack<System.__Canon>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v27+20]");
				bool flag5 = (nint)0 == 0;
				object obj12 = !flag5;
				int num4;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6515FC8]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6515FC0]");
					object obj14 = 0;
					stack2 = (Stack<ByteArraySlice>)obj14;
					Stack<System.__Canon> stack4 = default;
					stack4._002Ector();
					Stack<ByteArraySlice>[] array2 = poolTiers;
					bool flag6 = poolTiers == null;
					obj5 = (object)(&obj6);
					obj7 = (object)(&lockTaken);
					lockTaken = false;
					obj6 = poolTiers;
					ex = null;
					obj8 = 0;
					num3 = 0;
					lockTaken2 = false;
					stack = null;
					num4 = num2;
					if (flag6)
					{
						goto IL_0837;
					}
					if (stack4 != null)
					{
						nint num5 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v41 (Il2CppClass<System.Collections.Generic.Stack`1<Photon.Client.ByteArraySlice>[]>)+40]");
						stack2 = (Stack<ByteArraySlice>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag7 = ex2 == null;
						obj5 = (object)(&obj6);
						obj7 = (object)(&lockTaken);
						lockTaken = false;
						obj6 = poolTiers;
						ex = null;
						obj8 = 0;
						num3 = 0;
						lockTaken2 = false;
						stack = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v41 (Il2CppClass<System.Collections.Generic.Stack`1<Photon.Client.ByteArraySlice>[]>)+40]");
						stack5 = (Stack<ByteArraySlice>)0;
						num4 = num2;
						if (flag7)
						{
							goto IL_085b;
						}
					}
					bool flag8 = num2 < array2.Length;
					object obj15 = !flag8;
					obj5 = (object)(&obj6);
					obj7 = (object)(&lockTaken);
					lockTaken = false;
					obj6 = poolTiers;
					ex = null;
					obj8 = 0;
					num3 = 0;
					lockTaken2 = false;
					stack = null;
					num4 = num2;
					if (obj15 != null)
					{
						goto IL_0845;
					}
					object obj16 = array2 + num2;
					object obj17 = obj16 + 32;
					obj17 = stack4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					stack3 = stack4;
				}
				Monitor.Enter(stack3, ref lockTaken2);
				ByteArraySlice byteArraySlice = PopOrCreate((Stack<ByteArraySlice>)(object)stack3, num2);
				object obj18 = (object)(&lockTaken2);
				bool flag9 = obj18 == null;
				stack2 = (Stack<ByteArraySlice>)(object)stack3;
				if (!flag9)
				{
					object obj19 = (object)(&stack);
					Monitor.Exit(obj19);
					stack2 = null;
				}
				obj5 = (object)(&obj6);
				obj7 = (object)(&lockTaken);
				lockTaken = false;
				obj6 = poolTiers;
				ex = null;
				obj8 = 0;
				num3 = num2;
				object obj20 = 0;
				OutOfMemoryException ex3 = null;
				object obj21 = (object)(&stack);
				object obj22 = (object)(&lockTaken2);
				lockTaken2 = false;
				stack = stack3;
				num4 = num2;
				obj9 = (object)(&stack);
				goto IL_081a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1648");
			RuntimeTypeHandle handle = default;
			Type typeFromHandle = Type.GetTypeFromHandle(handle);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
			nint num6 = (nint)typeFromHandle;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v17 (Il2CppClass<System.Type>)+1B8]");
			object obj9 = 0;
			bool flag10 = ((System.RuntimeType)typeFromHandle).IsArrayImpl();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string text = default;
			string message = (string)flag10 + text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Exception ex4 = default;
			ex4._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex5 = new ArgumentNullException();
			lockTaken = false;
			obj6 = null;
			int num3 = 0;
			lockTaken2 = false;
			stack = null;
			Stack<ByteArraySlice> stack6 = default;
			stack2 = stack6;
			OutOfMemoryException ex6 = new OutOfMemoryException();
		}
		NullReferenceException ex7 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_080c;
		IL_085b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex8 = new ArgumentNullException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		ByteArraySlice result = default;
		return result;
		IL_0845:
		ex2 = new IndexOutOfRangeException();
		stack5 = stack2;
		goto IL_085b;
		IL_0837:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_0845;
		IL_080c:
		IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
		goto IL_081a;
		IL_081a:
		OutOfMemoryException ex11 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0837;
	}

	private unsafe ByteArraySlice PopOrCreate(Stack<ByteArraySlice> stack, int stackIndex)
	{
		//IL_0292: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got Ref
		//IL_0081: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got Ref
		//IL_0097: Expected Obj, but got I4
		//IL_02b0: Expected Obj, but got Ref
		//IL_003a: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got Ref
		//IL_00b6: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0159: Expected Obj, but got I
		bool lockTaken = default;
		Monitor.Enter(stack, ref lockTaken);
		bool flag = stack == null;
		NullReferenceException ex = null;
		object obj = 0;
		object obj2 = (object)(&lockTaken);
		if (flag)
		{
			goto IL_01ab;
		}
		System.__Canon _Canon2;
		object obj4;
		if (stack._size > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6515FD0]");
			object obj3 = 0;
			obj2 = obj3;
			System.__Canon _Canon = ((Stack<System.__Canon>)(object)stack).Pop();
			ex = null;
			obj = 0;
			_Canon2 = _Canon;
			obj4 = 3;
		}
		else
		{
			ex = null;
			obj = 0;
			obj2 = (object)(&lockTaken);
			_Canon2 = null;
			obj4 = 4;
		}
		goto IL_02a8;
		IL_02a8:
		object obj5 = (object)(&lockTaken);
		if (obj5 != null)
		{
			object obj7 = default;
			object obj6 = (object)(&obj7);
			Monitor.Exit(obj6);
			obj2 = 0;
		}
		bool flag2 = ex == null;
		object obj8 = !flag2;
		NullReferenceException ex2;
		if (obj8 == null)
		{
			bool flag3 = obj == null;
			object obj9 = !flag3;
			ex2 = ex;
			if (obj9 == null)
			{
				object obj10 = obj4 | 4;
				bool flag4 = (nint)obj10 != 4;
				ByteArraySlice result = (ByteArraySlice)(object)_Canon2;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F28]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					ByteArraySlice byteArraySlice = default;
					byteArraySlice._002Ector(this, stackIndex);
					int num = allocationCounter + 1;
					allocationCounter = num;
					result = byteArraySlice;
				}
				return result;
			}
			goto IL_01b9;
		}
		OutOfMemoryException ex3 = new OutOfMemoryException();
		goto IL_01ab;
		IL_01ab:
		ex2 = new NullReferenceException();
		goto IL_01b9;
		IL_01b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)obj2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj = 1;
		}
		else
		{
			if ((nint)obj2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				ByteArraySlice result2 = default;
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj12 = default;
			ex = (NullReferenceException)obj12;
		}
		_Canon2 = null;
		obj4 = 0;
		goto IL_02a8;
	}

	internal unsafe bool Release(ByteArraySlice slice, int stackIndex)
	{
		//IL_0897: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got Ref
		//IL_0106: Expected Obj, but got Ref
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_0098: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0184: Expected Obj, but got I4
		//IL_018d: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got Ref
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01cc: Expected Obj, but got I
		//IL_01f7: Expected Obj, but got I
		//IL_0200: Expected Obj, but got I4
		//IL_020d: Expected Obj, but got Ref
		//IL_0215: Expected Obj, but got Ref
		//IL_0226: Expected Obj, but got Ref
		//IL_0237: Expected Obj, but got I4
		//IL_0240: Expected Obj, but got I4
		//IL_024d: Expected Obj, but got Ref
		//IL_0255: Expected Obj, but got Ref
		//IL_026d: Expected Obj, but got I4
		//IL_0288: Expected Obj, but got I4
		//IL_0297: Expected Obj, but got I4
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_02cc: Expected Obj, but got I
		//IL_02d5: Expected Obj, but got I4
		//IL_02e2: Expected Obj, but got Ref
		//IL_02ea: Expected Obj, but got Ref
		//IL_02fb: Expected Obj, but got Ref
		//IL_030c: Expected Obj, but got I4
		//IL_0315: Expected Obj, but got I4
		//IL_0322: Expected Obj, but got Ref
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_0366: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I4
		//IL_037c: Expected Obj, but got Ref
		//IL_0384: Expected Obj, but got Ref
		//IL_0395: Expected Obj, but got Ref
		//IL_03a6: Expected Obj, but got I4
		//IL_03af: Expected Obj, but got I4
		//IL_03bc: Expected Obj, but got Ref
		//IL_03da: Expected Obj, but got I
		//IL_03f7: Expected Obj, but got I
		//IL_0407: Expected Obj, but got I
		//IL_0410: Expected Obj, but got I4
		//IL_041d: Expected Obj, but got Ref
		//IL_0425: Expected Obj, but got Ref
		//IL_0436: Expected Obj, but got Ref
		//IL_0447: Expected Obj, but got I4
		//IL_0730: Expected Obj, but got I4
		//IL_04a3: Expected Obj, but got I4
		//IL_04cb: Expected Obj, but got I4
		//IL_07cd: Expected Obj, but got I4
		//IL_0539: Expected Obj, but got Ref
		//IL_058b: Expected Obj, but got I4
		//IL_055e: Expected Obj, but got Ref
		//IL_05b3: Expected Obj, but got I4
		bool flag = slice == null;
		object obj = !flag;
		object obj2 = ~obj;
		bool flag2;
		bool flag3;
		if (obj2 == null)
		{
			flag2 = stackIndex < 0;
			int num = stackIndex ^ stackIndex;
			int num2 = stackIndex & num;
			flag3 = num2 < 0;
		}
		else
		{
			flag3 = false;
			flag2 = true;
		}
		bool flag4 = flag2 == flag3;
		if (!flag4)
		{
			goto IL_0619;
		}
		bool flag5 = stackIndex == 0;
		object obj3 = !flag5;
		if (obj3 == null)
		{
			object obj4 = slice + 16;
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		bool lockTaken = default;
		Monitor.Enter(poolTiers, ref lockTaken);
		Stack<ByteArraySlice>[] array = poolTiers;
		bool flag6 = poolTiers == null;
		object obj5 = null;
		bool lockTaken2 = false;
		object obj6 = 0;
		object obj7 = 0;
		NullReferenceException ex = null;
		object obj9 = default;
		object obj8 = (object)(&obj9);
		System.__Canon _Canon = (System.__Canon)(&lockTaken);
		if (flag6)
		{
			goto IL_067c;
		}
		obj8 = array.Length;
		bool flag7 = array.Length < stackIndex;
		object obj10 = !flag7;
		object obj11 = array.Length - stackIndex;
		bool flag8 = obj11 == null;
		object obj12 = ~obj10;
		object obj13 = obj12 | flag8;
		obj5 = null;
		lockTaken2 = false;
		obj6 = 0;
		obj7 = 0;
		ex = null;
		_Canon = (System.__Canon)(&lockTaken);
		if (obj13 != null)
		{
			goto IL_0699;
		}
		object obj14 = poolTiers + stackIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v30+20]");
		Monitor.Enter(0, ref lockTaken2);
		Stack<ByteArraySlice>[] array2 = poolTiers;
		bool flag9 = poolTiers == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v30+20]");
		obj5 = 0;
		object obj15 = 0;
		IndexOutOfRangeException ex2 = null;
		object obj16 = (object)(&obj5);
		object obj17 = (object)(&lockTaken2);
		lockTaken2 = false;
		object obj18 = (object)(&obj5);
		int num3 = stackIndex;
		obj6 = 0;
		obj7 = 0;
		ex = null;
		obj8 = (object)(&lockTaken2);
		_Canon = (System.__Canon)(&lockTaken2);
		if (flag9)
		{
			goto IL_06a7;
		}
		obj8 = array2.Length;
		bool flag10 = array2.Length < stackIndex;
		object obj19 = !flag10;
		object obj20 = array2.Length - stackIndex;
		bool flag11 = obj20 == null;
		object obj21 = ~obj19;
		object obj22 = obj21 | flag11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v30+20]");
		obj5 = 0;
		obj15 = 0;
		ex2 = null;
		obj16 = (object)(&obj5);
		obj17 = (object)(&lockTaken2);
		lockTaken2 = false;
		obj18 = (object)(&obj5);
		num3 = stackIndex;
		obj6 = 0;
		obj7 = 0;
		ex = null;
		_Canon = (System.__Canon)(&lockTaken2);
		if (obj22 != null)
		{
			goto IL_06c3;
		}
		object obj23 = poolTiers + stackIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v32+20]");
		bool flag12 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v30+20]");
		obj5 = 0;
		obj15 = 0;
		ex2 = null;
		obj16 = (object)(&obj5);
		obj17 = (object)(&lockTaken2);
		lockTaken2 = false;
		obj18 = (object)(&obj5);
		num3 = stackIndex;
		obj6 = 0;
		obj7 = 0;
		ex = null;
		_Canon = (System.__Canon)(&lockTaken2);
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6515FB0]");
			object obj24 = 0;
			obj6 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v32+20]");
			((Stack<System.__Canon>)0).Push((System.__Canon)(object)slice);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v30+20]");
			obj5 = 0;
			obj15 = 0;
			ex2 = null;
			obj16 = (object)(&obj5);
			obj17 = (object)(&lockTaken2);
			lockTaken2 = false;
			obj18 = (object)(&obj5);
			num3 = stackIndex;
			obj7 = 0;
			ex = null;
			_Canon = (System.__Canon)(object)slice;
			goto IL_0459;
		}
		goto IL_06e0;
		IL_06e0:
		NullReferenceException ex3 = new NullReferenceException();
		object obj25;
		IndexOutOfRangeException ex4;
		object obj26;
		object obj27;
		int num4;
		object obj28;
		object obj29;
		NullReferenceException ex5;
		object obj30;
		System.__Canon _Canon2;
		if ((nint)_Canon == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj15 = 1;
		}
		else
		{
			if ((nint)_Canon != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				if ((nint)_Canon == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj25 = obj15;
					ex4 = ex2;
					obj26 = obj16;
					obj27 = obj18;
					num4 = num3;
					obj28 = obj6;
					obj29 = 1;
					ex5 = ex;
					obj30 = obj8;
					_Canon2 = _Canon;
				}
				else
				{
					if ((nint)_Canon != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						bool result = default;
						return result;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj25 = obj15;
					ex4 = ex2;
					obj26 = obj16;
					obj27 = obj18;
					num4 = num3;
					obj28 = obj6;
					obj29 = obj7;
					object obj31 = default;
					ex5 = (NullReferenceException)obj31;
					obj30 = obj8;
					_Canon2 = _Canon;
				}
				goto IL_0531;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj32 = default;
			ex2 = (IndexOutOfRangeException)obj32;
		}
		goto IL_0459;
		IL_06c3:
		IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
		goto IL_06d1;
		IL_0459:
		if (obj17 != null)
		{
			Monitor.Exit(obj16);
			_Canon = null;
		}
		bool flag13 = ex2 == null;
		object obj33 = !flag13;
		if (obj33 != null)
		{
			goto IL_06b5;
		}
		bool flag14 = obj15 == null;
		object obj34 = !flag14;
		obj25 = obj15;
		ex4 = ex2;
		obj26 = obj16;
		obj27 = obj18;
		num4 = num3;
		obj28 = obj6;
		obj29 = obj7;
		ex5 = ex;
		obj30 = obj8;
		_Canon2 = _Canon;
		ex6 = ex2;
		if (obj34 == null)
		{
			goto IL_0531;
		}
		goto IL_06d1;
		IL_06a7:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_06b5;
		IL_06b5:
		OutOfMemoryException ex8 = new OutOfMemoryException();
		goto IL_06c3;
		IL_0531:
		object obj35 = (object)(&lockTaken);
		if (obj35 != null)
		{
			object obj36 = (object)(&obj9);
			Monitor.Exit(obj36);
			_Canon2 = null;
		}
		bool flag15 = ex5 == null;
		object obj37 = !flag15;
		NullReferenceException ex9;
		if (obj37 == null)
		{
			bool flag16 = obj29 == null;
			object obj38 = !flag16;
			obj15 = obj25;
			ex2 = ex4;
			obj16 = obj26;
			obj18 = obj27;
			num3 = num4;
			obj6 = obj28;
			obj7 = obj29;
			ex = ex5;
			obj8 = obj30;
			_Canon = _Canon2;
			ex9 = ex5;
			if (obj38 == null)
			{
				goto IL_0619;
			}
			goto IL_068a;
		}
		OutOfMemoryException ex10 = new OutOfMemoryException();
		obj15 = obj25;
		ex2 = ex4;
		obj16 = obj26;
		obj18 = obj27;
		num3 = num4;
		obj6 = obj28;
		obj7 = obj29;
		ex = ex5;
		obj8 = obj30;
		_Canon = _Canon2;
		goto IL_067c;
		IL_06d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_06e0;
		IL_0619:
		return flag4;
		IL_067c:
		ex9 = new NullReferenceException();
		goto IL_068a;
		IL_0699:
		IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
		goto IL_06a7;
		IL_068a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0699;
	}

	public unsafe void ClearPools(int lower = default(int), int upper = default(int))
	{
		//IL_0435: Expected Obj, but got I
		//IL_043e: Expected Obj, but got I4
		//IL_04b1: Expected Obj, but got I4
		//IL_0488: Expected Obj, but got I4
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected I4, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected I4, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_00e2: Expected Obj, but got I4
		//IL_04f8: Expected Obj, but got Ref
		//IL_014a: Expected Obj, but got I
		//IL_0265: Expected Obj, but got Ref
		//IL_018e: Expected Obj, but got I4
		//IL_01d8: Expected I4, but got Obj
		//IL_01e9: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got Ref
		//IL_0216: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6515FF8]");
		object obj = 0;
		object obj2 = 0;
		bool lockTaken = false;
		object obj3 = null;
		int num = upper;
		int num2 = lower;
		object obj4 = null;
		bool lockTaken2 = false;
		while (true)
		{
			object obj5 = 1 << (int)obj2;
			bool flag;
			bool flag2;
			bool flag3;
			if ((nint)obj5 >= lower)
			{
				object obj6 = obj5 - upper;
				flag = (nint)obj6 < 0;
				flag2 = obj6 == null;
				int num3 = obj5 ^ upper;
				object obj7 = obj5 ^ obj6;
				int num4 = num3 & obj7;
				flag3 = num4 < 0;
			}
			else
			{
				flag3 = false;
				flag2 = false;
				flag = false;
			}
			bool flag4 = flag == flag3;
			object obj8 = !flag2;
			object obj9 = flag4 & obj8;
			if (obj9 == null)
			{
				Monitor.Enter(poolTiers, ref lockTaken2);
				Stack<ByteArraySlice>[] array = poolTiers;
				if (poolTiers != null)
				{
					bool flag5 = (nint)obj2 < array.Length;
					object obj10 = !flag5;
					if (obj10 == null)
					{
						object obj11 = (object)poolTiers + obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v9+20]");
						bool flag6 = (nint)0 == 0;
						num = 0;
						num2 = (int)(&lockTaken2);
						if (!flag6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v9+20]");
							Monitor.Enter(0, ref lockTaken);
							Stack<ByteArraySlice>[] array2 = poolTiers;
							if (poolTiers != null)
							{
								bool flag7 = (nint)obj2 < array2.Length;
								object obj12 = !flag7;
								if (obj12 == null)
								{
									object obj13 = (object)poolTiers + obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v18+20]");
									if ((nint)0 != 0)
									{
										num2 = (int)obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v18+20]");
										((Stack<System.__Canon>)0).Clear();
										object obj14 = (object)(&lockTaken);
										if (obj14 != null)
										{
											object obj15 = (object)(&obj3);
											Monitor.Exit(obj15);
											num2 = 0;
										}
										OutOfMemoryException ex = new OutOfMemoryException();
										num = 0;
									}
									else
									{
										NullReferenceException ex2 = new NullReferenceException();
										num = 0;
										num2 = (int)(&lockTaken);
										OutOfMemoryException ex = (OutOfMemoryException)(object)ex2;
									}
								}
								else
								{
									IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
									num = 0;
									num2 = (int)(&lockTaken);
									OutOfMemoryException ex = (OutOfMemoryException)(object)ex3;
								}
							}
							else
							{
								NullReferenceException ex4 = new NullReferenceException();
								num = 0;
								num2 = (int)(&lockTaken);
								OutOfMemoryException ex = (OutOfMemoryException)(object)ex4;
							}
						}
						else
						{
							object obj16 = (object)(&lockTaken2);
							if (obj16 != null)
							{
								object obj17 = (object)(&obj4);
								Monitor.Exit(obj17);
								num2 = 0;
							}
							OutOfMemoryException ex = new OutOfMemoryException();
						}
					}
					else
					{
						IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
						num = 0;
						num2 = (int)(&lockTaken2);
						OutOfMemoryException ex = (OutOfMemoryException)(object)ex5;
					}
				}
				else
				{
					NullReferenceException ex6 = new NullReferenceException();
					num = 0;
					num2 = (int)(&lockTaken2);
					OutOfMemoryException ex = (OutOfMemoryException)(object)ex6;
				}
				break;
			}
			obj2++;
			if ((nint)obj2 == 32)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}
}
