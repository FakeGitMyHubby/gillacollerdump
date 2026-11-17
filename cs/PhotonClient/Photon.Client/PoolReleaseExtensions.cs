using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Photon.Client;

internal static class PoolReleaseExtensions
{
	internal static void ReleaseAndClear<T>(List<T> list, Pool<T> pool) where T : class
	{
		int size = list._size;
		if (list._size >= 1)
		{
			int num = 0;
			do
			{
				System.__Canon item = ((List<System.__Canon>)(object)list).get_Item(num);
				pool.Release((T)(object)item);
				size = list._size;
				num++;
			}
			while (num < list._size);
		}
		int version = list._version + 1;
		list._size = 0;
		list._version = version;
		if (size >= 1)
		{
			Array.Clear(list._items, 0, size);
		}
	}

	internal static void ReleaseAndClear<T>(Queue<T> queue, Pool<T> pool) where T : class
	{
		if (queue._size >= 1)
		{
			do
			{
				System.__Canon item = ((Queue<System.__Canon>)(object)queue).Dequeue();
				pool.Release((T)(object)item);
			}
			while (queue._size > 0);
		}
	}

	internal static void ReleaseAndClear<T>(ConcurrentQueue<T> queue, Pool<T> pool) where T : class
	{
		System.__Canon result;
		while (((ConcurrentQueue<System.__Canon>)(object)queue).TryDequeue(out result))
		{
			pool.Release((T)(object)result);
		}
	}

	internal unsafe static void ReleaseValuesAndClear<K, V>(NonAllocDictionary<K, V> dict, Pool<V> pool) where V : class
	{
		//IL_002d: Expected VT, but got I4
		//IL_0037: Expected VT, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got Ref
		//IL_00ca: Expected VT, but got Ref
		//IL_00d6: Expected Obj, but got I4
		//IL_0258: Expected Obj, but got I
		//IL_0268: Expected Obj, but got I
		//IL_0271: Expected Ref, but got VT
		//IL_028b: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got Ref
		//IL_0140: Expected VT, but got Ref
		//IL_00f5: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got VT
		//IL_01ba: Expected Obj, but got I4
		bool flag = dict == null;
		NonAllocDictionary<int, System.__Canon>.ValueIterator valueIterator = (NonAllocDictionary<int, System.__Canon>.ValueIterator)0;
		NonAllocDictionary<int, System.__Canon>.ValueIterator valueIterator2 = (NonAllocDictionary<int, System.__Canon>.ValueIterator)0;
		IntPtr intPtr2 = default;
		IntPtr intPtr = intPtr2;
		if (!flag)
		{
			NonAllocDictionary<int, System.__Canon>.ValueIterator values = ((NonAllocDictionary<int, System.__Canon>)(object)dict).Values;
			NonAllocDictionary<int, System.__Canon>.ValueIterator enumerator = valueIterator.GetEnumerator();
			System.__Canon current;
			object obj9 = default;
			object obj;
			object obj2;
			object obj3;
			NonAllocDictionary<int, System.__Canon>.ValueIterator valueIterator3;
			Pool<V> pool2 = default;
			while (true)
			{
				if (valueIterator2.MoveNext())
				{
					current = valueIterator2.Current;
					if (pool2 == null)
					{
						break;
					}
					pool2.Release((V)(object)current);
					continue;
				}
				obj = 0;
				obj2 = 0;
				obj3 = (object)(&intPtr);
				valueIterator3 = (NonAllocDictionary<int, System.__Canon>.ValueIterator)(&valueIterator2);
				object obj4 = 0;
				while (true)
				{
					object obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v4+38]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v5+50]");
					pool2 = (Pool<V>)0;
					((NonAllocDictionary<int, System.__Canon>.ValueIterator*)valueIterator3)->Dispose();
					bool flag2 = obj4 == null;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						bool flag3 = obj == null;
						object obj8 = !flag3;
						OutOfMemoryException ex = (OutOfMemoryException)valueIterator3;
						if (obj8 == null)
						{
							((NonAllocDictionary<int, System.__Canon>)(object)dict).Clear();
							return;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)pool2 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj = 1;
						obj4 = obj2;
						continue;
					}
					if ((nint)pool2 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj4 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj2 = obj9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28B9974");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			NullReferenceException ex2 = new NullReferenceException();
			obj = 0;
			obj2 = 0;
			obj3 = (object)(&intPtr);
			valueIterator3 = (NonAllocDictionary<int, System.__Canon>.ValueIterator)(&valueIterator2);
			pool2 = (Pool<V>)(object)current;
		}
		throw new NullReferenceException();
	}
}
