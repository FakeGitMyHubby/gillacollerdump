using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;

namespace Photon.Client;

public class Pool<T> where T : class
{
	private readonly Func<T> createFunction;

	private readonly Queue<T> pool;

	private readonly Action<T> resetFunction;

	public unsafe int Count
	{
		get
		{
			//IL_0032: Expected Obj, but got Ref
			//IL_003b: Expected Obj, but got I4
			//IL_0063: Expected Obj, but got Ref
			//IL_006c: Expected Obj, but got I4
			//IL_01e3: Expected Obj, but got Ref
			//IL_00af: Expected Obj, but got I4
			//IL_007e: Expected Obj, but got Ref
			//IL_0090: Expected Obj, but got I4
			//IL_015f: Expected Obj, but got I4
			//IL_00d7: Expected Obj, but got I4
			bool lockTaken = default;
			Monitor.Enter(pool, ref lockTaken);
			Queue<T> queue = pool;
			bool flag = pool == null;
			object obj = (object)(&lockTaken);
			object obj2 = 0;
			NullReferenceException ex = null;
			if (flag)
			{
				goto IL_0100;
			}
			int result = queue._size;
			obj = (object)(&lockTaken);
			obj2 = 0;
			ex = null;
			goto IL_01db;
			IL_0100:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_010e;
			IL_01db:
			object obj3 = (object)(&lockTaken);
			if (obj3 != null)
			{
				object obj5 = default;
				object obj4 = (object)(&obj5);
				Monitor.Exit(obj4);
				obj = 0;
			}
			bool flag2 = ex == null;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				bool flag3 = obj2 == null;
				object obj7 = !flag3;
				ex2 = ex;
				if (obj7 == null)
				{
					return result;
				}
				goto IL_010e;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			goto IL_0100;
			IL_010e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)obj == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj2 = 1;
			}
			else
			{
				if ((nint)obj != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					int result2 = default;
					return result2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj8 = default;
				ex = (NullReferenceException)obj8;
			}
			result = 0;
			goto IL_01db;
		}
	}

	public Pool(Func<T> createFunction, Action<T> resetFunction, int poolCapacity)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got I
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_00ad: Expected Obj, but got I
		object obj = this + 16;
		obj = createFunction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = this + 32;
		obj2 = resetFunction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v1 (Il2CppClass<Photon.Client.Pool`1>)+A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Queue<System.__Canon> queue = default;
		queue._002Ector();
		object obj4 = this + 24;
		obj4 = queue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Photon.Client.Pool`1>)+A8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4098F94");
	}

	public Pool(Func<T> createFunction, int poolCapacity)
	{
		//IL_0016: Expected Obj, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Photon.Client.Pool`1>)+A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4098DE4");
	}

	private void CreatePoolItems(int numItems)
	{
		//IL_004f: Expected Obj, but got I
		if (numItems >= 1)
		{
			int num = numItems;
			System.__Canon item = default;
			do
			{
				Func<T> func = createFunction;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ X8_v3 (System.Func`1<T>)+18] (should have been resolved before IL gen)");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X9_v5 (Il2CppClass<Photon.Client.Pool`1>)+A8]");
				object obj = 0;
				((Queue<System.__Canon>)(object)pool).Enqueue(item);
				num--;
			}
			while (num != 1);
		}
	}

	public unsafe void Release(T item)
	{
		//IL_0197: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got Ref
		//IL_02a3: Expected Obj, but got Ref
		//IL_02b1: Expected Obj, but got I4
		//IL_02ba: Expected Obj, but got I4
		//IL_02c2: Expected Obj, but got Ref
		//IL_01c3: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_0092: Expected Obj, but got Ref
		//IL_009a: Expected Obj, but got Ref
		//IL_00a8: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I4
		//IL_0111: Expected I, but got Obj
		//IL_0227: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I4
		bool lockTaken = default;
		object obj = default;
		object obj2 = default;
		object obj3 = default;
		NullReferenceException ex = default;
		object obj4 = default;
		System.__Canon _Canon;
		object obj5;
		if (item != null)
		{
			Action<T> action = resetFunction;
			if (resetFunction != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ X8_v12 (System.Action`1<T>)+18] (should have been resolved before IL gen)");
			}
			Monitor.Enter(pool, ref lockTaken);
			bool flag = pool == null;
			obj = (object)(&obj2);
			obj3 = (object)(&lockTaken);
			ex = null;
			obj4 = 0;
			obj5 = 0;
			_Canon = (System.__Canon)(&lockTaken);
			lockTaken = false;
			obj2 = pool;
			if (!flag)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v14 (Il2CppClass<Photon.Client.Pool`1>)+A8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v15+50]");
				obj5 = 0;
				((Queue<System.__Canon>)(object)pool).Enqueue((System.__Canon)(object)item);
				obj = (object)(&obj2);
				obj3 = (object)(&lockTaken);
				ex = null;
				obj4 = 0;
				_Canon = (System.__Canon)(object)item;
				lockTaken = false;
				goto IL_00bf;
			}
			goto IL_01c8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = default;
		string paramName = default;
		ex2._002Ector(paramName);
		ArgumentNullException ex3 = new ArgumentNullException();
		obj5 = 0;
		IntPtr intPtr = default;
		nint num2 = intPtr;
		lockTaken = false;
		obj2 = null;
		goto IL_01b2;
		IL_00bf:
		if (obj3 != null)
		{
			Monitor.Exit(obj);
			_Canon = null;
		}
		bool flag2 = ex == null;
		object obj7 = !flag2;
		num2 = (nint)_Canon;
		if (obj7 != null)
		{
			goto IL_01b2;
		}
		bool flag3 = obj4 == null;
		object obj8 = !flag3;
		NullReferenceException ex4 = ex;
		if (obj8 == null)
		{
			return;
		}
		goto IL_01d6;
		IL_01b2:
		OutOfMemoryException ex5 = new OutOfMemoryException();
		_Canon = (System.__Canon)num2;
		goto IL_01c8;
		IL_01c8:
		ex4 = new NullReferenceException();
		goto IL_01d6;
		IL_01d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)_Canon == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj4 = 1;
		}
		else
		{
			if ((nint)_Canon != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj9 = default;
			ex = (NullReferenceException)obj9;
		}
		goto IL_00bf;
	}

	public unsafe T Acquire()
	{
		//IL_0032: Expected Obj, but got Ref
		//IL_003b: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got Ref
		//IL_00fc: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I4
		//IL_02eb: Expected Obj, but got Ref
		//IL_018c: Expected Obj, but got I4
		//IL_0280: Expected Obj, but got I4
		//IL_015b: Expected Obj, but got Ref
		//IL_016d: Expected Obj, but got I4
		//IL_02cf: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		bool lockTaken = default;
		Monitor.Enter(pool, ref lockTaken);
		Queue<System.__Canon> queue = (Queue<System.__Canon>)(object)pool;
		bool flag = pool == null;
		object obj = (object)(&lockTaken);
		object obj2 = 0;
		NullReferenceException ex = null;
		if (flag)
		{
			goto IL_0213;
		}
		object obj4;
		System.__Canon result;
		System.__Canon _Canon2;
		if (queue._size != 0)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v17 (Il2CppClass<Photon.Client.Pool`1>)+A8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v18+60]");
			obj = 0;
			System.__Canon _Canon = ((Queue<System.__Canon>)(object)pool).Dequeue();
			obj4 = 4;
			obj2 = 0;
			ex = null;
			result = null;
			_Canon2 = _Canon;
		}
		else
		{
			Func<T> func = createFunction;
			bool flag2 = createFunction == null;
			obj = (object)(&lockTaken);
			obj2 = 0;
			ex = null;
			if (flag2)
			{
				goto IL_0230;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v16 (System.Func`1<T>)+28]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v95 @ X8_v16 (System.Func`1<T>)+18] (should have been resolved before IL gen)");
			obj4 = 3;
			obj2 = 0;
			ex = null;
			System.__Canon _Canon3 = default;
			result = _Canon3;
			_Canon2 = null;
		}
		goto IL_02e3;
		IL_02e3:
		object obj5 = (object)(&lockTaken);
		if (obj5 != null)
		{
			object obj7 = default;
			object obj6 = (object)(&obj7);
			Monitor.Exit(obj6);
			obj = 0;
		}
		bool flag3 = ex == null;
		object obj8 = !flag3;
		NullReferenceException ex2;
		if (obj8 == null)
		{
			bool flag4 = obj2 == null;
			object obj9 = !flag4;
			ex2 = ex;
			if (obj9 == null)
			{
				object obj10 = obj4 | 4;
				if ((nint)obj10 == 4)
				{
					result = _Canon2;
				}
				return (T)(object)result;
			}
			goto IL_0221;
		}
		OutOfMemoryException ex3 = new OutOfMemoryException();
		goto IL_0213;
		IL_0221:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0230;
		IL_0213:
		ex2 = new NullReferenceException();
		goto IL_0221;
		IL_0230:
		NullReferenceException ex4 = new NullReferenceException();
		if ((nint)obj == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj2 = 1;
		}
		else
		{
			if ((nint)obj != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				T result2 = default;
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj11 = default;
			ex = (NullReferenceException)obj11;
		}
		obj4 = 0;
		result = null;
		_Canon2 = null;
		goto IL_02e3;
	}
}
