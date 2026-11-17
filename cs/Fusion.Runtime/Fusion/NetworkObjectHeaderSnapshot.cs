using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

internal class NetworkObjectHeaderSnapshot
{
	internal NetworkObjectHeaderSnapshot Prev;

	internal NetworkObjectHeaderSnapshot Next;

	public Tick Tick;

	public int WordCount;

	private unsafe int* _ptr;

	public unsafe NetworkObjectHeaderPtr HeaderPtr
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0045: Expected VT, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84B8]");
			object error = 0;
			bool flag = _ptr == null;
			bool condition = !flag;
			Assert.Always(condition, (string)error);
			return (NetworkObjectHeaderPtr)_ptr;
		}
	}

	public unsafe ref NetworkObjectHeader Header
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84B8]");
			object error = 0;
			bool flag = _ptr == null;
			bool condition = !flag;
			Assert.Always(condition, (string)error);
			return ref *(NetworkObjectHeader*)_ptr;
		}
	}

	public unsafe Span<int> Raw
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0061: Expected VT, but got I
			//IL_0019: Expected I4, but got I8
			Span<int> result = (Span<int>)_ptr;
			if (_ptr != null)
			{
				if ((int)(WordCount & 0x80000000L) != 0)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
			}
			else
			{
				Span<int> empty = Span<int>.Empty;
				result = empty;
			}
			return result;
		}
	}

	public unsafe void PoolInit(Simulation simulation, int wordCount)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84E8]");
		object error = 0;
		bool condition = _ptr == null;
		Assert.Check(condition, (string)error);
		WordCount = wordCount;
		int* ptr = simulation.NativeAllocObjectSnapshot(wordCount);
		_ptr = ptr;
	}

	public unsafe void PoolReset(Simulation simulation)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Ref, but got Unknown
		//IL_0029: Expected VT, but got I4
		simulation.NativeFreeObjectSnapshot(ref *(int**)(this + 40), WordCount);
		Tick = (Tick)0;
	}

	public unsafe void AllocRaw(Allocator allocator, int wordCount)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84E8]");
		object error = 0;
		bool condition = _ptr == null;
		Assert.Check(condition, (string)error);
		int size = wordCount << 2;
		WordCount = wordCount;
		void* ptr = Allocator.AllocAndClear(allocator, size);
		_ptr = (int*)ptr;
	}

	public unsafe void FreeRaw(Allocator allocator)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Ref, but got Unknown
		//IL_001c: Expected VT, but got I4
		ref int* ptr = ref *(int**)(this + 40);
		Tick = (Tick)0;
		bool flag = Allocator.Free(allocator, ref ptr);
	}

	public unsafe NetworkObjectHeaderSnapshot Clone(Simulation simulation)
	{
		//IL_015c: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I4
		//IL_01e1: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I4
		NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot;
		int num;
		if ((object)simulation != null)
		{
			networkObjectHeaderSnapshot = simulation.AcquireNetworkObjectHeaderSnapshot(WordCount);
			if (networkObjectHeaderSnapshot != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84C8]");
				object error = 0;
				object obj = WordCount - networkObjectHeaderSnapshot.WordCount;
				bool condition = obj == null;
				Assert.Check(condition, (string)error);
				num = networkObjectHeaderSnapshot.WordCount << 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8B]");
				if ((nint)0 != 0)
				{
					if (num != 0)
					{
						goto IL_006f;
					}
				}
				else
				{
					_ = 1;
					bool flag = num == 0;
					object obj2 = !flag;
					if (obj2 != null)
					{
						goto IL_006f;
					}
				}
				bool flag2 = true;
				goto IL_01d1;
			}
		}
		return (NetworkObjectHeaderSnapshot)(object)new NullReferenceException();
		IL_01d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		return networkObjectHeaderSnapshot;
		IL_006f:
		if (networkObjectHeaderSnapshot._ptr != null)
		{
			int num2 = num >> 30;
			bool flag3 = _ptr == null;
			object obj4 = !flag3;
			object obj5 = ~obj4;
			bool flag4 = obj5 == null && num2 == 0;
			bool flag2 = flag4;
		}
		else
		{
			bool flag2 = false;
		}
		goto IL_01d1;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void CopyTo(int[] destination)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0254: Expected Obj, but got I
		//IL_025e: Expected VT, but got I
		//IL_026e: Expected Obj, but got I
		//IL_0236: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I8
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0166: Expected Obj, but got I
		//IL_0177: Expected I4, but got Obj
		//IL_011d: Expected Obj, but got I4
		//IL_019d: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+38]");
		if ((nint)0 != 0)
		{
			if (destination != null)
			{
				goto IL_0032;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			bool flag = destination == null;
			object obj3 = !flag;
			if (obj3 != null)
			{
				goto IL_0032;
			}
		}
		int[] array = destination;
		int num = 0;
		goto IL_0244;
		IL_0244:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59E0]");
		object obj4 = 0;
		Span<int> span = (Span<int>)_ptr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59D8]");
		object obj5 = 0;
		int[] array2;
		if (_ptr != null)
		{
			array2 = (int[])WordCount;
			object obj6 = WordCount & 0x80000000L;
			if (obj6 != null)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
		}
		else
		{
			Span<int> empty = Span<int>.Empty;
			array2 = destination;
			span = empty;
		}
		ReadOnlySpan<int> span2 = span;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X23_v3+38]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X23_v3+38]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			}
		}
		object obj10 = array2 - num;
		bool condition = obj10 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D28]");
		object obj11 = 0;
		Assert.Check(condition, (int)array2, num);
		if (array2 != null)
		{
			ref int reference = ref MemoryMarshal.GetReference((Span<int>)array);
			ref int reference2 = ref MemoryMarshal.GetReference(span2);
			object obj12 = (object)array2 << 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		}
		return;
		IL_0032:
		num = destination.Length;
		array = (int[])(destination + 32);
		goto IL_0244;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void CopyFrom(NetworkObjectMeta source)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0029: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84C8]");
		object error = 0;
		object obj = WordCount - source.WordCount;
		bool condition = obj == null;
		Assert.Check(condition, (string)error);
		int num = WordCount << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8B]");
		if ((nint)0 != 0)
		{
			if (num != 0)
			{
				goto IL_0097;
			}
		}
		else
		{
			_ = 1;
			bool flag = num == 0;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_0097;
			}
		}
		bool flag2 = true;
		goto IL_0173;
		IL_0173:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		return;
		IL_0097:
		if (_ptr != null)
		{
			int num2 = num >> 30;
			bool flag3 = source._ptr == null;
			object obj4 = !flag3;
			object obj5 = ~obj4;
			bool flag4 = obj5 == null && num2 == 0;
			flag2 = flag4;
		}
		else
		{
			flag2 = false;
		}
		goto IL_0173;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void CopyTo(NetworkObjectMeta destination)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0029: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7190]");
		object error = 0;
		object obj = WordCount - destination.WordCount;
		bool condition = obj == null;
		Assert.Check(condition, (string)error);
		int num = WordCount << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8B]");
		if ((nint)0 != 0)
		{
			if (num != 0)
			{
				goto IL_0097;
			}
		}
		else
		{
			_ = 1;
			bool flag = num == 0;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_0097;
			}
		}
		bool flag2 = true;
		goto IL_0173;
		IL_0173:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		return;
		IL_0097:
		if (destination._ptr != null)
		{
			int num2 = num >> 30;
			bool flag3 = _ptr == null;
			object obj4 = !flag3;
			object obj5 = ~obj4;
			bool flag4 = obj5 == null && num2 == 0;
			flag2 = flag4;
		}
		else
		{
			flag2 = false;
		}
		goto IL_0173;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void CopyFrom(NetworkObjectHeaderSnapshot source)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0029: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84C8]");
		object error = 0;
		object obj = source.WordCount - WordCount;
		bool condition = obj == null;
		Assert.Check(condition, (string)error);
		int num = WordCount << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8B]");
		if ((nint)0 != 0)
		{
			if (num != 0)
			{
				goto IL_0097;
			}
		}
		else
		{
			_ = 1;
			bool flag = num == 0;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_0097;
			}
		}
		bool flag2 = true;
		goto IL_0173;
		IL_0173:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		return;
		IL_0097:
		if (_ptr != null)
		{
			int num2 = num >> 30;
			bool flag3 = source._ptr == null;
			object obj4 = !flag3;
			object obj5 = ~obj4;
			bool flag4 = obj5 == null && num2 == 0;
			flag2 = flag4;
		}
		else
		{
			flag2 = false;
		}
		goto IL_0173;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void CopyTo(NetworkObjectHeaderSnapshot destination)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0029: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7190]");
		object error = 0;
		object obj = destination.WordCount - WordCount;
		bool condition = obj == null;
		Assert.Check(condition, (string)error);
		int num = WordCount << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8B]");
		if ((nint)0 != 0)
		{
			if (num != 0)
			{
				goto IL_0097;
			}
		}
		else
		{
			_ = 1;
			bool flag = num == 0;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_0097;
			}
		}
		bool flag2 = true;
		goto IL_0173;
		IL_0173:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		return;
		IL_0097:
		if (destination._ptr != null)
		{
			int num2 = num >> 30;
			bool flag3 = _ptr == null;
			object obj4 = !flag3;
			object obj5 = ~obj4;
			bool flag4 = obj5 == null && num2 == 0;
			flag2 = flag4;
		}
		else
		{
			flag2 = false;
		}
		goto IL_0173;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal unsafe int* GetBehaviourPtr(NetworkBehaviour behaviour)
	{
		//IL_0010: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I
		//IL_0140: Expected I, but got Obj
		//IL_0153: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool condition;
		if ((UnityEngine.Object)behaviour != (UnityEngine.Object)null)
		{
			if ((object)behaviour == null)
			{
				goto IL_0145;
			}
			object obj4 = behaviour.WordOffset - WordCount;
			bool flag2 = (nint)obj4 < 0;
			int num = behaviour.WordOffset ^ WordCount;
			int num2 = behaviour.WordOffset ^ obj4;
			int num3 = num & num2;
			bool flag3 = num3 < 0;
			bool flag4 = flag2 == flag3;
			bool flag5 = !flag4;
			condition = flag5;
		}
		else
		{
			condition = false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84E0]");
		object error = 0;
		Assert.Always(condition, (string)error);
		if (_ptr != null)
		{
			if ((object)behaviour != null)
			{
				return (int*)((byte*)_ptr + behaviour.WordOffset);
			}
			goto IL_0145;
		}
		return (int*)unchecked((nint)null);
		IL_0145:
		NullReferenceException ex = new NullReferenceException();
		return (int*)(nint)ex;
	}

	internal unsafe ulong BuildCRC()
	{
		//IL_00e4: Expected Obj, but got I
		//IL_00ee: Expected VT, but got I
		//IL_00fe: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I4
		//IL_0023: Expected Obj, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59E0]");
		object obj = 0;
		Span<int> span = (Span<int>)_ptr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D39F0]");
		object obj2 = 0;
		if (_ptr != null)
		{
			nint num = WordCount;
			object obj3 = WordCount & 0x80000000L;
			if (obj3 != null)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
		}
		else
		{
			Span<int> empty = Span<int>.Empty;
			IntPtr intPtr = default;
			nint num = intPtr;
			span = empty;
		}
		ReadOnlySpan<int> data = span;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return CRC64.Compute(data);
	}
}
