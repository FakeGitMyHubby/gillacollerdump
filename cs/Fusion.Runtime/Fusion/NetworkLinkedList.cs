using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace Fusion;

public struct NetworkLinkedList<T> : _0021_00210, Action<UnityEngine.Object>, _0021_00210
{
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public NetworkLinkedList<T> list;

		internal T[] _003C_002Ector_003Eb__0()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected Obj, but got Unknown
			//IL_0021: Expected Obj, but got I
			//IL_0070: Expected Obj, but got I
			//IL_004e: Expected Obj, but got I
			nint num = 0;
			object obj = this + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Fusion.NetworkLinkedList`1+<>c__DisplayClass0_0>)+A8]");
			object obj2 = 0;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v2+10]");
				object obj3 = 0;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v8 @ X2_v1 (should have been resolved before IL gen)");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v2+28]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v23 @ X1_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public struct Enumerator : Action<object>, _0021_00210, Action<object>
	{
		private bool _first;

		private int _head;

		private NetworkLinkedList<T> _list;

		public unsafe T Current
		{
			get
			{
				//IL_0008: Expected Obj, but got Ref
				//IL_0021: Expected Obj, but got I
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_002f: Expected Obj, but got Unknown
				//IL_0049: Expected Obj, but got I4
				//IL_01c8: Expected Obj, but got I
				//IL_01d8: Expected Obj, but got I
				//IL_01ee: Expected Obj, but got I
				//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0200: Expected Obj, but got Unknown
				//IL_00a6: Expected Obj, but got I
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Expected Obj, but got Unknown
				//IL_00d6: Expected Obj, but got I4
				//IL_0242: Expected Obj, but got I
				//IL_0252: Expected Obj, but got I
				//IL_025b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0260: Expected Obj, but got Unknown
				//IL_027a: Expected Obj, but got I4
				//IL_00fa: Expected Obj, but got I
				//IL_0298: Expected Obj, but got I
				//IL_02a3: Expected Obj, but got Ref
				//IL_02b1: Expected Obj, but got Ref
				//IL_02ce: Expected Obj, but got I
				//IL_02dc: Expected Obj, but got Ref
				//IL_032b: Expected Obj, but got VT
				object obj2 = default;
				object obj = (object)(&obj2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
				_ = 0;
				object obj3 = (nint)0 + (nint)309;
				object obj4 = obj3 & 1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				nint num = 0;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr = default;
					num = intPtr;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3 (Il2CppClass<Fusion.NetworkLinkedList`1+Enumerator>)+A8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+30]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+FC]");
				object obj8 = (nint)0 + (nint)15;
				object obj9 = obj8 & 0x1FFFFFFF0L;
				object obj10 = default;
				nint num2 = (ref *(byte*)(&obj10)) - (ref *(byte*)obj9);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedList`1<T>+Enumerator<T>)+4]");
				ArgumentNullException ex;
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedList`1<T>+Enumerator<T>)+4]");
					if ((nint)0 <= (nint)_head)
					{
						object obj11 = (nint)0 + (nint)309;
						object obj12 = obj11;
						object obj13 = obj11 & 1;
						bool flag2 = obj13 == null;
						object obj14 = !flag2;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
							object obj15 = (nint)0 + (nint)309;
							obj12 = obj15;
							nint num3 = 0;
						}
						else
						{
							nint num4 = 0;
							nint num3 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v10 (Il2CppClass<Fusion.NetworkLinkedList`1+Enumerator>)+A8]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X10_v2+28]");
						object obj17 = 0;
						object obj18 = obj12 & 1;
						bool flag3 = obj18 == null;
						object obj19 = !flag3;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
							IntPtr intPtr2 = default;
							nint num3 = intPtr2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v13 (Il2CppClass<Fusion.NetworkLinkedList`1+Enumerator>)+A8]");
						object obj20 = 0;
						object obj21 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
						object obj22 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedList`1<T>+Enumerator<T>)+4]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v14+28]");
						object obj23 = 0;
						object obj24 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v187 @ X1_v4+10] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
						bool flag4 = num5 != 0;
						IntPtr intPtr3 = num2;
						T val = default;
						ex = (ArgumentNullException)val;
						if (!flag4)
						{
							return val;
						}
						goto IL_01a9;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
				bool flag5 = num6 != 0;
				InvalidOperationException ex2 = default;
				ex = (ArgumentNullException)(object)ex2;
				if (!flag5)
				{
					ex2._002Ector();
					ex = new ArgumentNullException();
					IntPtr intPtr4 = default;
					IntPtr intPtr3 = intPtr4;
				}
				goto IL_01a9;
				IL_01a9:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
				T result = default;
				return result;
			}
		}

		private unsafe object System_002ECollections_002EIEnumerator_002ECurrent
		{
			get
			{
				//IL_0008: Expected Obj, but got Ref
				//IL_0021: Expected Obj, but got I
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Expected Obj, but got Unknown
				//IL_0051: Expected Obj, but got I4
				//IL_0162: Expected Obj, but got I
				//IL_0172: Expected Obj, but got I
				//IL_0188: Expected Obj, but got I
				//IL_0195: Unknown result type (might be due to invalid IL or missing references)
				//IL_019a: Expected Obj, but got Unknown
				//IL_01a7: Expected Obj, but got Ref
				//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b5: Expected Obj, but got Unknown
				//IL_01cf: Expected Obj, but got I4
				//IL_0075: Expected Obj, but got I
				//IL_01ed: Expected Obj, but got I
				//IL_01fd: Expected Obj, but got I
				//IL_0206: Unknown result type (might be due to invalid IL or missing references)
				//IL_020b: Expected Obj, but got Unknown
				//IL_0225: Expected Obj, but got I4
				//IL_00af: Expected Obj, but got I
				//IL_0243: Expected Obj, but got I
				//IL_0251: Expected Obj, but got Ref
				//IL_0261: Expected Obj, but got I
				//IL_027c: Expected Obj, but got I
				//IL_0285: Unknown result type (might be due to invalid IL or missing references)
				//IL_028a: Expected Obj, but got Unknown
				//IL_02a4: Expected Obj, but got I4
				//IL_0105: Expected Obj, but got I
				object obj2 = default;
				object obj = (object)(&obj2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
				_ = 0;
				object obj3 = (nint)0 + (nint)309;
				object obj4 = obj3;
				object obj5 = obj3 & 1;
				bool flag = obj5 == null;
				object obj6 = !flag;
				nint num;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj7 = (nint)0 + (nint)309;
					obj4 = obj7;
					num = 0;
				}
				else
				{
					nint num2 = 0;
					num = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1+Enumerator>)+A8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X10_v1+30]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X10_v2+FC]");
				object obj10 = (nint)0 + (nint)15;
				object obj11 = obj10 & 0x1FFFFFFF0L;
				object obj13 = default;
				object obj12 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
				object obj14 = obj4 & 1;
				bool flag2 = obj14 == null;
				object obj15 = !flag2;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj16 = (nint)0 + (nint)309;
					obj4 = obj16;
					num = 0;
				}
				else
				{
					IntPtr intPtr = num;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedList`1+Enumerator>)+A8]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X10_v6+38]");
				object obj18 = 0;
				object obj19 = obj4 & 1;
				bool flag3 = obj19 == null;
				object obj20 = !flag3;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr2 = default;
					num = intPtr2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v5 (Il2CppClass<Fusion.NetworkLinkedList`1+Enumerator>)+A8]");
				object obj21 = 0;
				object obj22 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6+38]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v89 @ X1_v1+10] (should have been resolved before IL gen)");
				object obj24 = (nint)0 + (nint)309;
				object obj25 = obj24 & 1;
				bool flag4 = obj25 == null;
				object obj26 = !flag4;
				nint num3 = 0;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v7 (Il2CppClass<Fusion.NetworkLinkedList`1+Enumerator>)+A8]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X29_v1-8]");
				object result = default;
				if (num4 == 0)
				{
					return result;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
				object result2 = default;
				return result2;
			}
		}

		internal unsafe Enumerator(NetworkLinkedList<T> list)
		{
			//IL_0010: Expected Obj, but got Ref
			//IL_001d: Expected Obj, but got I
			//IL_0036: Expected VT, but got I4
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 24));
			obj = (object)list._data;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			_ = 0;
			Enumerator enumerator = (Enumerator)1;
		}

		public unsafe bool MoveNext()
		{
			//IL_0023: Expected VT, but got I4
			//IL_002e: Expected Obj, but got Ref
			//IL_003a: Expected Obj, but got I
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected Obj, but got Unknown
			//IL_006a: Expected Obj, but got I4
			//IL_00d2: Expected Obj, but got I
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected Obj, but got Unknown
			//IL_0102: Expected Obj, but got I4
			//IL_023f: Expected Obj, but got I
			//IL_024f: Expected Obj, but got I
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_025d: Expected Obj, but got Unknown
			//IL_0277: Expected Obj, but got I4
			//IL_008e: Expected Obj, but got I
			//IL_0295: Expected Obj, but got I
			//IL_02a5: Expected Obj, but got I
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b3: Expected Obj, but got Unknown
			//IL_02cd: Expected Obj, but got I4
			//IL_0126: Expected Obj, but got I
			//IL_0312: Expected Obj, but got I
			//IL_0331: Expected Obj, but got I
			//IL_033c: Expected Obj, but got Ref
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Expected Obj, but got Unknown
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Expected I4, but got Unknown
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Expected I4, but got Unknown
			//IL_0207: Expected Obj, but got I4
			//IL_020f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0214: Expected I4, but got Unknown
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) != null)
			{
				Enumerator enumerator = (Enumerator)0;
				object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
				object obj2 = (nint)0 + (nint)309;
				object obj3 = obj2;
				object obj4 = obj2 & 1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj6 = (nint)0 + (nint)309;
					obj3 = obj6;
					nint num = 0;
				}
				else
				{
					nint num2 = 0;
					nint num = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v15 (Il2CppClass<Fusion.NetworkLinkedList`1+Enumerator>)+A8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v6+10]");
				object obj8 = 0;
				object obj9 = obj3 & 1;
				bool flag2 = obj9 == null;
				object obj10 = !flag2;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr = default;
					nint num = intPtr;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v14 (Il2CppClass<Fusion.NetworkLinkedList`1+Enumerator>)+A8]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ X10_v7] (should have been resolved before IL gen)");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedList`1<T>+Enumerator<T>)+4]");
				if ((nint)0 == 0)
				{
					goto IL_0221;
				}
				object obj12 = (nint)0 + (nint)309;
				object obj13 = obj12;
				object obj14 = obj12 & 1;
				bool flag3 = obj14 == null;
				object obj15 = !flag3;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj16 = (nint)0 + (nint)309;
					obj13 = obj16;
					nint num3 = 0;
				}
				else
				{
					nint num4 = 0;
					nint num3 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v6 (Il2CppClass<Fusion.NetworkLinkedList`1+Enumerator>)+A8]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X10_v4+20]");
				object obj18 = 0;
				object obj19 = obj13 & 1;
				bool flag4 = obj19 == null;
				object obj20 = !flag4;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr2 = default;
					nint num3 = intPtr2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v8 (Il2CppClass<Fusion.NetworkLinkedList`1+Enumerator>)+A8]");
				object obj21 = 0;
				object obj22 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ X10_v5] (should have been resolved before IL gen)");
			}
			object obj23 = default;
			if ((nint)obj23 >= 1)
			{
				object obj24 = obj23 - _head;
				bool flag5 = (nint)obj24 < 0;
				bool flag6 = obj24 == null;
				int num5 = obj23 ^ _head;
				object obj25 = obj23 ^ obj24;
				int num6 = num5 & obj25;
				bool flag7 = num6 < 0;
				bool flag8 = flag5 == flag7;
				object obj26 = !flag8;
				return (byte)((obj26 | flag6) ? 1 : 0) != 0;
			}
			goto IL_0221;
			IL_0221:
			return false;
		}

		public void Reset()
		{
			_ = 0;
		}

		public void Dispose()
		{
			_ = 0;
			_first = false;
			_ = 0;
			_ = 4294967295L;
		}
	}

	public const int ELEMENT_WORDS = default(int);

	public const int META_WORDS = default(int);

	private unsafe int* _data;

	private int _stride;

	private int _capacity;

	private IElementReaderWriter<T> _rw;

	private const int COUNT = default(int);

	private const int HEAD = default(int);

	private const int TAIL = default(int);

	private const int PREV = default(int);

	private const int NEXT = default(int);

	private const int INVALID = default(int);

	private const int OFFSET = default(int);

	private unsafe int Head
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0005: Expected Obj, but got Ref
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1+4]");
			return 0;
		}
		[MethodImpl((MethodImplOptions)256)]
		set
		{
			//IL_0005: Expected Obj, but got Ref
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}
	}

	private unsafe int Tail
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0005: Expected Obj, but got Ref
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1+8]");
			return 0;
		}
		[MethodImpl((MethodImplOptions)256)]
		set
		{
			//IL_0005: Expected Obj, but got Ref
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}
	}

	public unsafe int Count
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0005: Expected Obj, but got Ref
			//IL_000a: Expected I4, but got Obj
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			return (int)obj;
		}
		[MethodImpl((MethodImplOptions)256)]
		private set
		{
			//IL_0005: Expected Obj, but got Ref
			//IL_000d: Expected Obj, but got I4
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			obj = value;
		}
	}

	public int Capacity
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedList`1<T>)+C]");
			return 0;
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	[MethodImpl((MethodImplOptions)256)]
	public unsafe T get_Item(int index)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0025: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_01fe: Expected Obj, but got Ref
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_0226: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_027c: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I
		//IL_030a: Expected Obj, but got I
		//IL_0320: Expected Obj, but got I
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_0350: Expected Obj, but got I4
		//IL_0179: Expected Obj, but got I
		//IL_029a: Expected Obj, but got I
		//IL_02aa: Expected Obj, but got I
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02d2: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I
		//IL_036e: Expected Obj, but got I
		//IL_037c: Expected Obj, but got Ref
		//IL_0391: Expected Obj, but got I
		//IL_039f: Expected Obj, but got Ref
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
		object obj4 = (nint)0 + (nint)309;
		object obj5 = obj4;
		object obj6 = obj4 & 1;
		bool flag = obj6 == null;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
			object obj8 = (nint)0 + (nint)309;
			obj5 = obj8;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
			object obj9 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+A8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X10_v1+20]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X10_v2+FC]");
		object obj12 = (nint)0 + (nint)15;
		object obj13 = obj12 & 0x1FFFFFFF0L;
		object obj15 = default;
		object obj14 = (ref *(byte*)(&obj15)) - (ref *(byte*)obj13);
		object obj16 = obj5 & 1;
		bool flag2 = obj16 == null;
		object obj17 = !flag2;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
			object obj18 = (nint)0 + (nint)309;
			obj5 = obj18;
		}
		else
		{
			object obj19 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v2+A8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X10_v4+8]");
		object obj21 = 0;
		object obj22 = obj5 & 1;
		bool flag3 = obj22 == null;
		object obj23 = !flag3;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj24 = default;
			obj3 = obj24;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5+A8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ X10_v5] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
		object obj27 = (nint)0 + (nint)309;
		object obj28 = obj27;
		object obj29 = obj27 & 1;
		bool flag4 = obj29 == null;
		object obj30 = !flag4;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
			obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
			object obj31 = (nint)0 + (nint)309;
			obj28 = obj31;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
			object obj32 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v6+A8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v6+18]");
		object obj34 = 0;
		object obj35 = obj28 & 1;
		bool flag5 = obj35 == null;
		object obj36 = !flag5;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj37 = default;
			obj26 = obj37;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v9+A8]");
		object obj38 = 0;
		object obj39 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v10+18]");
		object obj40 = 0;
		object obj41 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ X1_v2+10] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
		T result = default;
		if (num == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		T result2 = default;
		return result2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void set_Item(int index, T value)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0026: Expected Obj, but got I
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0056: Expected Obj, but got I4
		//IL_01eb: Expected Obj, but got I
		//IL_01fb: Expected Obj, but got I
		//IL_0211: Expected Obj, but got I
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_0230: Expected Obj, but got Ref
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0258: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I
		//IL_0286: Expected Obj, but got I
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_02ae: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I
		//IL_04d2: Expected Obj, but got I
		//IL_04e8: Expected Obj, but got I
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected Obj, but got Unknown
		//IL_0518: Expected Obj, but got I4
		//IL_02cc: Expected Obj, but got I
		//IL_02dc: Expected Obj, but got I
		//IL_0310: Expected Obj, but got I
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		//IL_0342: Expected VT, but got Ref
		//IL_035b: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_03a4: Expected Obj, but got I4
		//IL_03c2: Expected Obj, but got I
		//IL_03d2: Expected Obj, but got I
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_03fa: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I
		//IL_0418: Expected Obj, but got I
		//IL_0428: Expected Obj, but got I
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_0450: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I
		//IL_0536: Expected Obj, but got I
		//IL_0546: Expected Obj, but got I
		//IL_0560: Expected Obj, but got I8
		//IL_057a: Expected Obj, but got I4
		//IL_046c: Expected Obj, but got Ref
		//IL_047a: Expected Obj, but got Ref
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		_ = 0;
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3;
		object obj5 = obj3 & 1;
		bool flag = obj5 == null;
		object obj6 = !flag;
		nint num;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj7 = (nint)0 + (nint)309;
			obj4 = obj7;
			num = 0;
		}
		else
		{
			nint num2 = 0;
			num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X10_v1+20]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X10_v2+FC]");
		object obj10 = (nint)0 + (nint)15;
		object obj11 = obj10 & 0x1FFFFFFF0L;
		object obj13 = default;
		object obj12 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
		object obj14 = obj4 & 1;
		bool flag2 = obj14 == null;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj16 = (nint)0 + (nint)309;
			obj4 = obj16;
			num = 0;
		}
		else
		{
			IntPtr intPtr = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X10_v4+8]");
		object obj18 = 0;
		object obj19 = obj4 & 1;
		bool flag3 = obj19 == null;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			num = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v5 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v84 @ X10_v5] (should have been resolved before IL gen)");
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22;
		object obj24 = obj22 & 1;
		bool flag4 = obj24 == null;
		object obj25 = !flag4;
		nint num3;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj26 = (nint)0 + (nint)309;
			obj23 = obj26;
			num3 = 0;
		}
		else
		{
			num3 = 0;
			nint num4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v6 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v9+20]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v10+28]");
		bool flag5 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v10+28]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v10+28]");
		object obj29 = num5 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v10+28]");
		object obj30 = 0 & obj29;
		bool flag6 = (nint)obj30 < 0;
		T val = (T)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
		bool flag7 = flag5 == flag6;
		object obj31 = !flag7;
		object obj32 = ~obj31;
		if (obj32 == null)
		{
			T val2 = value;
		}
		else
		{
			T val2 = val;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		object obj33 = obj23 & 1;
		bool flag8 = obj33 == null;
		object obj34 = !flag8;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj35 = (nint)0 + (nint)309;
			obj23 = obj35;
			num3 = 0;
		}
		else
		{
			IntPtr intPtr3 = num3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v9 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v14+28]");
		object obj37 = 0;
		object obj38 = obj23 & 1;
		bool flag9 = obj38 == null;
		object obj39 = !flag9;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj40 = (nint)0 + (nint)309;
			obj23 = obj40;
			num3 = 0;
		}
		else
		{
			IntPtr intPtr4 = num3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v10 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v17+28]");
		object obj42 = 0;
		object obj43 = obj23 & 1;
		bool flag10 = obj43 == null;
		object obj44 = !flag10;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr5 = default;
			num3 = intPtr5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X25_v6 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v18+20]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v19+28]");
		object obj47 = 0 & 0x80000000L;
		bool flag11 = obj47 == null;
		object obj48 = !flag11;
		if (obj48 == null)
		{
			obj12 = obj12;
		}
		object obj49 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
		object obj50 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v168 @ X21_v2+10] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
		if (num6 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		}
	}

	public unsafe void Clear()
	{
		//IL_000c: Expected Obj, but got I
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_018e: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected I4, but got Unknown
		//IL_0137: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_01b4: Expected I8, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj;
		object obj3 = obj & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj5 = (nint)0 + (nint)309;
			obj2 = obj5;
			nint num = 0;
		}
		else
		{
			nint num2 = 0;
			nint num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X10_v1+30]");
		object obj7 = 0;
		object obj8 = obj2 & 1;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			nint num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ X10_v2] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedList`1<T>)+8]");
		object obj12 = default;
		object obj11 = 0 * obj12;
		object obj13 = obj11 << 2;
		int num3 = obj13 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8E]");
		if ((nint)0 != 0)
		{
			if (num3 == 0)
			{
				return;
			}
		}
		else
		{
			_ = 1;
			bool flag3 = num3 == 0;
			object obj14 = !flag3;
			if (obj14 == null)
			{
				return;
			}
		}
		int num4 = num3 >> 30;
		bool flag4 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) == null;
		object obj15 = !flag4;
		object obj16 = ~obj15;
		bool condition = obj16 == null && num4 == 0;
		Assert.Always(condition, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), num3);
		UnsafeUtility.MemClear(System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), num3);
	}

	public unsafe bool Contains(T value)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0026: Expected Obj, but got I
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0056: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I
		//IL_01da: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_020f: Expected Obj, but got Ref
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_0237: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_0255: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02cb: Expected VT, but got Ref
		//IL_02e4: Expected Obj, but got I4
		//IL_0313: Expected Obj, but got I
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_0343: Expected Obj, but got I4
		//IL_0361: Expected Obj, but got I
		//IL_0371: Expected Obj, but got I
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected Obj, but got Unknown
		//IL_0399: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I
		//IL_04e4: Expected Obj, but got I
		//IL_04fa: Expected Obj, but got I
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected Obj, but got Unknown
		//IL_052a: Expected Obj, but got I4
		//IL_03b7: Expected Obj, but got I
		//IL_03c7: Expected Obj, but got I
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected Obj, but got Unknown
		//IL_03ef: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I
		//IL_040d: Expected Obj, but got I
		//IL_041d: Expected Obj, but got I
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_0445: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I
		//IL_0548: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I
		//IL_0572: Expected Obj, but got I8
		//IL_058c: Expected Obj, but got I4
		//IL_0461: Expected Obj, but got Ref
		//IL_046f: Expected Obj, but got Ref
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3;
		object obj5 = obj3 & 1;
		bool flag = obj5 == null;
		object obj6 = !flag;
		nint num;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj7 = (nint)0 + (nint)309;
			obj4 = obj7;
			num = 0;
		}
		else
		{
			nint num2 = 0;
			num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X9_v1+20]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X9_v2+FC]");
		object obj10 = (nint)0 + (nint)15;
		object obj11 = obj10 & 0x1FFFFFFF0L;
		object obj13 = default;
		object obj12 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
		object obj14 = obj4 & 1;
		bool flag2 = obj14 == null;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			num = 0;
		}
		else
		{
			IntPtr intPtr = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5+20]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+28]");
		bool flag3 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+28]");
		object obj18 = num3 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+28]");
		object obj19 = 0 & obj18;
		bool flag4 = (nint)obj19 < 0;
		T val = (T)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
		bool flag5 = flag3 == flag4;
		object obj20 = !flag5;
		object obj21 = ~obj20;
		if (obj21 == null)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		object obj22 = num + 309;
		object obj23 = obj22;
		object obj24 = obj22 & 1;
		bool flag6 = obj24 == null;
		object obj25 = !flag6;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj26 = (nint)0 + (nint)309;
			obj23 = obj26;
			num = 0;
		}
		else
		{
			IntPtr intPtr2 = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v5 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X9_v4+38]");
		object obj28 = 0;
		object obj29 = obj23 & 1;
		bool flag7 = obj29 == null;
		object obj30 = !flag7;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr3 = default;
			num = intPtr3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X22_v5 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ X9_v5] (should have been resolved before IL gen)");
		object obj32 = (nint)0 + (nint)309;
		object obj33 = obj32;
		object obj34 = obj32 & 1;
		bool flag8 = obj34 == null;
		object obj35 = !flag8;
		nint num4;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj36 = (nint)0 + (nint)309;
			obj33 = obj36;
			num4 = 0;
		}
		else
		{
			nint num5 = 0;
			num4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v9 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X10_v3+50]");
		object obj38 = 0;
		object obj39 = obj33 & 1;
		bool flag9 = obj39 == null;
		object obj40 = !flag9;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj41 = (nint)0 + (nint)309;
			obj33 = obj41;
			num4 = 0;
		}
		else
		{
			IntPtr intPtr4 = num4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v10 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X10_v5+50]");
		object obj43 = 0;
		object obj44 = obj33 & 1;
		bool flag10 = obj44 == null;
		object obj45 = !flag10;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr5 = default;
			num4 = intPtr5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v16 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v17+20]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v18+28]");
		object obj48 = 0 & 0x80000000L;
		bool flag11 = obj48 == null;
		object obj49 = !flag11;
		if (obj49 == null)
		{
			obj12 = obj12;
		}
		object obj50 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
		object obj51 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ X21_v2+10] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-C]");
		bool flag12 = (nint)0 == 0;
		bool result = !flag12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
		if (num6 == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result2 = default;
		return result2;
	}

	public unsafe bool Contains(T value, IEqualityComparer<T> comparer)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0030: Expected Obj, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got I4
		//IL_0616: Expected Obj, but got I
		//IL_0626: Expected Obj, but got I
		//IL_063c: Expected Obj, but got I
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected Obj, but got Unknown
		//IL_065b: Expected Obj, but got Ref
		//IL_0668: Expected Obj, but got Ref
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_0690: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		//IL_06ae: Expected Obj, but got I
		//IL_06be: Expected Obj, but got I
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected Obj, but got Unknown
		//IL_06e6: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I
		//IL_09eb: Expected Obj, but got I
		//IL_09fb: Expected Obj, but got I
		//IL_09ac: Expected Obj, but got I
		//IL_095e: Expected Obj, but got I
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected Obj, but got Unknown
		//IL_098e: Expected Obj, but got I4
		//IL_0704: Expected Obj, but got I
		//IL_0714: Expected Obj, but got I
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected Obj, but got Unknown
		//IL_073c: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I
		//IL_0a32: Expected Obj, but got I
		//IL_0a40: Expected Obj, but got Ref
		//IL_0a5e: Expected Obj, but got I
		//IL_0a83: Expected Obj, but got I
		//IL_0a8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a91: Expected Obj, but got Unknown
		//IL_0aab: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I
		//IL_0188: Expected Obj, but got Ref
		//IL_0198: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_0209: Expected Obj, but got I4
		//IL_0230: Expected Obj, but got I
		//IL_058a: Expected Obj, but got I
		//IL_05c3: Expected Obj, but got I
		//IL_024e: Expected Obj, but got I
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0276: Expected Obj, but got I4
		//IL_05f2: Expected Obj, but got I
		//IL_02a9: Expected Obj, but got I
		//IL_02b9: Expected Obj, but got I
		//IL_02cf: Expected Obj, but got I
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_02f7: Expected Obj, but got I4
		//IL_077d: Expected Obj, but got I
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected Obj, but got Unknown
		//IL_07a5: Expected Obj, but got I4
		//IL_033b: Expected Obj, but got I
		//IL_034b: Expected Obj, but got I
		//IL_0365: Expected Obj, but got I8
		//IL_037f: Expected Obj, but got I4
		//IL_07c5: Expected Obj, but got I
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected Obj, but got Unknown
		//IL_07ed: Expected Obj, but got I4
		//IL_03c1: Expected Obj, but got I
		//IL_03d1: Expected Obj, but got I
		//IL_03eb: Expected Obj, but got I8
		//IL_0405: Expected Obj, but got I4
		//IL_0809: Expected I, but got Obj
		//IL_0819: Expected Obj, but got I
		//IL_0888: Expected Obj, but got Ref
		//IL_0898: Expected Obj, but got I
		//IL_08e6: Expected Obj, but got I4
		//IL_043e: Expected Obj, but got I
		//IL_04ba: Expected Obj, but got I
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected Obj, but got Unknown
		//IL_04ea: Expected Obj, but got I4
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected Obj, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected Obj, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_090c: Expected Obj, but got I
		//IL_091c: Expected Obj, but got I
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Expected Obj, but got Unknown
		//IL_0944: Expected Obj, but got I4
		//IL_050e: Expected Obj, but got I
		//IL_0acf: Expected Obj, but got I
		//IL_0b03: Expected Obj, but got I4
		//IL_0b14: Expected Obj, but got I4
		//IL_0562: Expected Obj, but got I4
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		_ = 0;
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3;
		object obj5 = obj3 & 1;
		bool flag = obj5 == null;
		object obj6 = !flag;
		nint num;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj7 = (nint)0 + (nint)309;
			obj4 = obj7;
			num = 0;
		}
		else
		{
			nint num2 = 0;
			num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X10_v1+20]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X10_v2+FC]");
		object obj10 = (nint)0 + (nint)15;
		object obj11 = obj10 & 0x1FFFFFFF0L;
		object obj13 = default;
		object obj12 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
		object obj14 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
		object obj15 = obj4 & 1;
		bool flag2 = obj15 == null;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj17 = (nint)0 + (nint)309;
			obj4 = obj17;
			num = 0;
		}
		else
		{
			IntPtr intPtr = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v5+60]");
		object obj19 = 0;
		object obj20 = obj4 & 1;
		bool flag3 = obj20 == null;
		object obj21 = !flag3;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			num = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v6 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7+60]");
		NullReferenceException ex = (NullReferenceException)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v89 @ X10_v6] (should have been resolved before IL gen)");
		bool result;
		NullReferenceException ex2 = default;
		if (ex2 != null)
		{
			IEqualityComparer<T> equalityComparer2 = default;
			IEqualityComparer<T> equalityComparer = equalityComparer2;
			NullReferenceException ex3 = ex2;
			IntPtr intPtr3 = default;
			object obj52 = default;
			IntPtr intPtr4 = default;
			object obj73;
			while (true)
			{
				object obj23 = (nint)0 + (nint)309;
				object obj24 = obj23;
				object obj25 = obj23 & 1;
				bool flag4 = obj25 == null;
				object obj26 = !flag4;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj27 = (nint)0 + (nint)309;
					obj24 = obj27;
					nint num3 = 0;
				}
				else
				{
					nint num4 = 0;
					nint num3 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v11 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X10_v10+18]");
				object obj29 = 0;
				object obj30 = obj24 & 1;
				bool flag5 = obj30 == null;
				object obj31 = !flag5;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					nint num3 = intPtr3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v15 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj32 = 0;
				object obj33 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 28));
				nint num5 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v16+18]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v336 @ X1_v5+10] (should have been resolved before IL gen)");
				object obj35 = (nint)0 + (nint)309;
				object obj36 = obj35 & 1;
				bool flag6 = obj36 == null;
				object obj37 = !flag6;
				nint num6 = 0;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v16 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj38 = 0;
				NullReferenceException ex4 = (NullReferenceException)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v20+20]");
				object obj39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v21+28]");
				bool flag7 = (nint)0 < (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v21+28]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v21+28]");
				object obj40 = num7 ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v21+28]");
				object obj41 = 0 & obj40;
				bool flag8 = (nint)obj41 < 0;
				bool flag9 = flag7 == flag8;
				object obj42 = !flag9;
				object obj43 = ~obj42;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-30]");
					ex = (NullReferenceException)0;
				}
				else
				{
					ex = ex4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				if (equalityComparer2 == null)
				{
					break;
				}
				object obj44 = (nint)0 + (nint)309;
				object obj45 = obj44 & 1;
				bool flag10 = obj45 == null;
				object obj46 = !flag10;
				nint num8 = 0;
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v21 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj47 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v28+58]");
				object obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v28+58]");
				object obj49 = (nint)0 + (nint)309;
				object obj50 = obj49 & 1;
				bool flag11 = obj50 == null;
				object obj51 = !flag11;
				if (obj51 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					obj48 = obj52;
				}
				object obj53 = (nint)0 + (nint)309;
				object obj54 = obj53 & 1;
				bool flag12 = obj54 == null;
				object obj55 = !flag12;
				nint num9 = 0;
				if (obj55 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v24 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj56 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v33+20]");
				object obj57 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v34+28]");
				object obj58 = 0 & 0x80000000L;
				bool flag13 = obj58 == null;
				object obj59 = !flag13;
				object obj60 = obj12;
				if (obj59 == null)
				{
					obj60 = obj12;
				}
				object obj61 = (nint)0 + (nint)309;
				object obj62 = obj61 & 1;
				bool flag14 = obj62 == null;
				object obj63 = !flag14;
				nint num10 = 0;
				if (obj63 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v26 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj64 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v38+20]");
				object obj65 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v39+28]");
				object obj66 = 0 & 0x80000000L;
				bool flag15 = obj66 == null;
				object obj67 = !flag15;
				object obj68 = obj14;
				if (obj67 == null)
				{
					obj68 = obj14;
				}
				nint num11 = (nint)equalityComparer2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v41 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<T>>)+12E]");
				object obj69 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v41 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<T>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_047f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v41 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<T>>)+98]");
				object obj70 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X10_v18-8]");
					if (0 == (nint)obj48)
					{
						break;
					}
					obj69--;
					obj70 += 16;
					if ((nint)obj69 != 1)
					{
						continue;
					}
					goto IL_047f;
				}
				object obj71 = num11 + obj70;
				object obj72 = obj71 + 312;
				goto IL_0862;
				IL_047f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				goto IL_0862;
				IL_0862:
				num5 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
				obj73 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 28));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v27+8]");
				ex = (NullReferenceException)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v251._className (System.String) (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-1C]");
				bool flag16 = (nint)0 == 0;
				bool flag17 = !flag16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-1C]");
				bool flag18 = (nint)0 == 0;
				object obj74 = !flag18;
				result = flag17;
				if (obj74 == null)
				{
					object obj75 = (nint)0 + (nint)309;
					object obj76 = obj75;
					object obj77 = obj75 & 1;
					bool flag19 = obj77 == null;
					object obj78 = !flag19;
					if (obj78 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						object obj79 = (nint)0 + (nint)309;
						obj76 = obj79;
						nint num12 = 0;
					}
					else
					{
						nint num13 = 0;
						nint num12 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v30 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
					object obj80 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X10_v13+70]");
					object obj81 = 0;
					object obj82 = obj76 & 1;
					bool flag20 = obj82 == null;
					object obj83 = !flag20;
					if (obj83 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						nint num12 = intPtr4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v47 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
					object obj84 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v48+70]");
					num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v113 @ X10_v14] (should have been resolved before IL gen)");
					bool flag21 = ex2 == null;
					object obj85 = !flag21;
					ex = ex3;
					equalityComparer = (IEqualityComparer<T>)1;
					ex3 = ex2;
					if (obj85 != null)
					{
						continue;
					}
					result = flag17;
					ex = ex2;
					equalityComparer2 = (IEqualityComparer<T>)1;
				}
				goto IL_099c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
			object obj86 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v24+28]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
			bool flag22 = num14 != 0;
			obj73 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X10_v2+FC]");
			equalityComparer2 = (IEqualityComparer<T>)0;
			if (!flag22)
			{
				ex2 = new NullReferenceException();
				obj73 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X10_v2+FC]");
				equalityComparer2 = (IEqualityComparer<T>)0;
			}
			goto IL_05f7;
		}
		result = false;
		goto IL_099c;
		IL_05f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result2 = default;
		return result2;
		IL_099c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
		object obj87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v9+28]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		if (num15 == 0)
		{
			return result;
		}
		goto IL_05f7;
	}

	public unsafe T Set(int index, T value)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_002f: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I
		//IL_0362: Expected Obj, but got I
		//IL_0372: Expected Obj, but got I
		//IL_0388: Expected Obj, but got I
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected Obj, but got Unknown
		//IL_03a7: Expected Obj, but got Ref
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_03cf: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I
		//IL_00b8: Expected Obj, but got I
		//IL_03ed: Expected Obj, but got I
		//IL_03fd: Expected Obj, but got I
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_0425: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I
		//IL_06c9: Expected Obj, but got I
		//IL_06e3: Expected Obj, but got I
		//IL_06f9: Expected Obj, but got I
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected Obj, but got Unknown
		//IL_0729: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I
		//IL_0443: Expected Obj, but got I
		//IL_0453: Expected Obj, but got I
		//IL_0487: Expected Obj, but got I
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_04b9: Expected VT, but got Ref
		//IL_04d2: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected Obj, but got Unknown
		//IL_051b: Expected Obj, but got I4
		//IL_0539: Expected Obj, but got I
		//IL_0549: Expected Obj, but got I
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected Obj, but got Unknown
		//IL_0571: Expected Obj, but got I4
		//IL_01c1: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I
		//IL_058f: Expected Obj, but got I
		//IL_059f: Expected Obj, but got I
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected Obj, but got Unknown
		//IL_05c7: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I
		//IL_0221: Expected Obj, but got I
		//IL_0747: Expected Obj, but got I
		//IL_0757: Expected Obj, but got I
		//IL_0771: Expected Obj, but got I8
		//IL_078b: Expected Obj, but got I4
		//IL_05e3: Expected Obj, but got Ref
		//IL_05f1: Expected Obj, but got Ref
		//IL_061a: Expected Obj, but got I
		//IL_0630: Expected Obj, but got I
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected Obj, but got Unknown
		//IL_0658: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got I
		//IL_028e: Expected Obj, but got I
		//IL_02c2: Expected Obj, but got I
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected Obj, but got Unknown
		//IL_02f4: Expected VT, but got Ref
		//IL_030d: Expected Obj, but got I4
		//IL_068a: Expected Obj, but got I
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
		object obj4 = (nint)0 + (nint)309;
		object obj5 = obj4;
		object obj6 = obj4 & 1;
		bool flag = obj6 == null;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
			object obj8 = (nint)0 + (nint)309;
			obj5 = obj8;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
			object obj9 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+A8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X10_v1+20]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X10_v2+FC]");
		object obj12 = (nint)0 + (nint)15;
		object obj13 = obj12 & 0x1FFFFFFF0L;
		object obj15 = default;
		object obj14 = (ref *(byte*)(&obj15)) - (ref *(byte*)obj13);
		object obj16 = obj5 & 1;
		bool flag2 = obj16 == null;
		object obj17 = !flag2;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
			object obj18 = (nint)0 + (nint)309;
			obj5 = obj18;
		}
		else
		{
			object obj19 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v2+A8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X10_v4+8]");
		object obj21 = 0;
		object obj22 = obj5 & 1;
		bool flag3 = obj22 == null;
		object obj23 = !flag3;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj24 = default;
			obj3 = obj24;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v6+A8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ X10_v5] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
		object obj27 = (nint)0 + (nint)309;
		object obj28 = obj27;
		object obj29 = obj27 & 1;
		bool flag4 = obj29 == null;
		object obj30 = !flag4;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
			obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
			object obj31 = (nint)0 + (nint)309;
			obj28 = obj31;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
			object obj32 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v6+A8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v10+20]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v11+28]");
		bool flag5 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v11+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v11+28]");
		object obj35 = num ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v11+28]");
		object obj36 = 0 & obj35;
		bool flag6 = (nint)obj36 < 0;
		T val = (T)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
		bool flag7 = flag5 == flag6;
		object obj37 = !flag7;
		object obj38 = ~obj37;
		if (obj38 == null)
		{
			T val2 = value;
		}
		else
		{
			T val2 = val;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		object obj39 = obj28 & 1;
		bool flag8 = obj39 == null;
		object obj40 = !flag8;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
			obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
			object obj41 = (nint)0 + (nint)309;
			obj28 = obj41;
		}
		else
		{
			object obj42 = obj26;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v9+A8]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v15+28]");
		object obj44 = 0;
		object obj45 = obj28 & 1;
		bool flag9 = obj45 == null;
		object obj46 = !flag9;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
			obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
			object obj47 = (nint)0 + (nint)309;
			obj28 = obj47;
		}
		else
		{
			object obj48 = obj26;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v10+A8]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v18+28]");
		object obj50 = 0;
		object obj51 = obj28 & 1;
		bool flag10 = obj51 == null;
		object obj52 = !flag10;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj53 = default;
			obj26 = obj53;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X26_v5+A8]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v19+20]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v20+28]");
		object obj56 = 0 & 0x80000000L;
		bool flag11 = obj56 == null;
		object obj57 = !flag11;
		object obj58 = obj14;
		if (obj57 == null)
		{
			obj58 = obj14;
		}
		object obj59 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
		object obj60 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ X28_v1+10] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X4+20]");
		object obj62 = (nint)0 + (nint)309;
		object obj63 = obj62 & 1;
		bool flag12 = obj63 == null;
		object obj64 = !flag12;
		if (obj64 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v15+A8]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v25+20]");
		object obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v26+28]");
		bool flag13 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v26+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v26+28]");
		object obj67 = num2 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v26+28]");
		object obj68 = 0 & obj67;
		bool flag14 = (nint)obj68 < 0;
		T val3 = (T)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
		bool flag15 = flag13 == flag14;
		object obj69 = !flag15;
		object obj70 = ~obj69;
		if (obj70 == null)
		{
			T val4 = value;
		}
		else
		{
			T val4 = val3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-30]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v29+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		T result = default;
		if (num3 == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		T result2 = default;
		return result2;
	}

	public unsafe T Get(int index)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0025: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_01fe: Expected Obj, but got Ref
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_0226: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_027c: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I
		//IL_030a: Expected Obj, but got I
		//IL_0320: Expected Obj, but got I
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_0350: Expected Obj, but got I4
		//IL_0179: Expected Obj, but got I
		//IL_029a: Expected Obj, but got I
		//IL_02aa: Expected Obj, but got I
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02d2: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I
		//IL_036e: Expected Obj, but got I
		//IL_037c: Expected Obj, but got Ref
		//IL_0391: Expected Obj, but got I
		//IL_039f: Expected Obj, but got Ref
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
		object obj4 = (nint)0 + (nint)309;
		object obj5 = obj4;
		object obj6 = obj4 & 1;
		bool flag = obj6 == null;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
			object obj8 = (nint)0 + (nint)309;
			obj5 = obj8;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
			object obj9 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+A8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X10_v1+20]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X10_v2+FC]");
		object obj12 = (nint)0 + (nint)15;
		object obj13 = obj12 & 0x1FFFFFFF0L;
		object obj15 = default;
		object obj14 = (ref *(byte*)(&obj15)) - (ref *(byte*)obj13);
		object obj16 = obj5 & 1;
		bool flag2 = obj16 == null;
		object obj17 = !flag2;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
			object obj18 = (nint)0 + (nint)309;
			obj5 = obj18;
		}
		else
		{
			object obj19 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v2+A8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X10_v4+8]");
		object obj21 = 0;
		object obj22 = obj5 & 1;
		bool flag3 = obj22 == null;
		object obj23 = !flag3;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj24 = default;
			obj3 = obj24;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5+A8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ X10_v5] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
		object obj27 = (nint)0 + (nint)309;
		object obj28 = obj27;
		object obj29 = obj27 & 1;
		bool flag4 = obj29 == null;
		object obj30 = !flag4;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
			obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
			object obj31 = (nint)0 + (nint)309;
			obj28 = obj31;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X3+20]");
			object obj32 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v6+A8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v6+18]");
		object obj34 = 0;
		object obj35 = obj28 & 1;
		bool flag5 = obj35 == null;
		object obj36 = !flag5;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj37 = default;
			obj26 = obj37;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v9+A8]");
		object obj38 = 0;
		object obj39 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v10+18]");
		object obj40 = 0;
		object obj41 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ X1_v2+10] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
		T result = default;
		if (num == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		T result2 = default;
		return result2;
	}

	public unsafe int IndexOf(T value)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0026: Expected Obj, but got I
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0056: Expected Obj, but got I4
		//IL_01d2: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I
		//IL_01f8: Expected Obj, but got I
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0217: Expected Obj, but got Ref
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_023f: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_025d: Expected Obj, but got I
		//IL_026d: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_02d3: Expected VT, but got Ref
		//IL_02ec: Expected Obj, but got I4
		//IL_031b: Expected Obj, but got I
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_034b: Expected Obj, but got I4
		//IL_0369: Expected Obj, but got I
		//IL_0379: Expected Obj, but got I
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_03a1: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I
		//IL_04ca: Expected Obj, but got I
		//IL_04e0: Expected Obj, but got I
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected Obj, but got Unknown
		//IL_0510: Expected Obj, but got I4
		//IL_03bf: Expected Obj, but got I
		//IL_03cf: Expected Obj, but got I
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got Unknown
		//IL_03f7: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I
		//IL_0415: Expected Obj, but got I
		//IL_0425: Expected Obj, but got I
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_044d: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I
		//IL_052e: Expected Obj, but got I
		//IL_053e: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I8
		//IL_0572: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got Ref
		//IL_0477: Expected Obj, but got Ref
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3;
		object obj5 = obj3 & 1;
		bool flag = obj5 == null;
		object obj6 = !flag;
		nint num;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj7 = (nint)0 + (nint)309;
			obj4 = obj7;
			num = 0;
		}
		else
		{
			nint num2 = 0;
			num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X9_v1+20]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X9_v2+FC]");
		object obj10 = (nint)0 + (nint)15;
		object obj11 = obj10 & 0x1FFFFFFF0L;
		object obj13 = default;
		object obj12 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
		object obj14 = obj4 & 1;
		bool flag2 = obj14 == null;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			num = 0;
		}
		else
		{
			IntPtr intPtr = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5+20]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+28]");
		bool flag3 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+28]");
		object obj18 = num3 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+28]");
		object obj19 = 0 & obj18;
		bool flag4 = (nint)obj19 < 0;
		T val = (T)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
		bool flag5 = flag3 == flag4;
		object obj20 = !flag5;
		object obj21 = ~obj20;
		if (obj21 == null)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		object obj22 = num + 309;
		object obj23 = obj22;
		object obj24 = obj22 & 1;
		bool flag6 = obj24 == null;
		object obj25 = !flag6;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj26 = (nint)0 + (nint)309;
			obj23 = obj26;
			num = 0;
		}
		else
		{
			IntPtr intPtr2 = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v5 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X9_v4+38]");
		object obj28 = 0;
		object obj29 = obj23 & 1;
		bool flag7 = obj29 == null;
		object obj30 = !flag7;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr3 = default;
			num = intPtr3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X22_v5 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ X9_v5] (should have been resolved before IL gen)");
		object obj32 = (nint)0 + (nint)309;
		object obj33 = obj32;
		object obj34 = obj32 & 1;
		bool flag8 = obj34 == null;
		object obj35 = !flag8;
		nint num4;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj36 = (nint)0 + (nint)309;
			obj33 = obj36;
			num4 = 0;
		}
		else
		{
			nint num5 = 0;
			num4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v9 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X10_v3+78]");
		object obj38 = 0;
		object obj39 = obj33 & 1;
		bool flag9 = obj39 == null;
		object obj40 = !flag9;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj41 = (nint)0 + (nint)309;
			obj33 = obj41;
			num4 = 0;
		}
		else
		{
			IntPtr intPtr4 = num4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v10 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X10_v5+78]");
		object obj43 = 0;
		object obj44 = obj33 & 1;
		bool flag10 = obj44 == null;
		object obj45 = !flag10;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr5 = default;
			num4 = intPtr5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v16 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v17+20]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v18+28]");
		object obj48 = 0 & 0x80000000L;
		bool flag11 = obj48 == null;
		object obj49 = !flag11;
		if (obj49 == null)
		{
			obj12 = obj12;
		}
		object obj50 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
		object obj51 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ X21_v2+10] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
		if (num6 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-C]");
			return 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		int result = default;
		return result;
	}

	public unsafe int IndexOf(T value, IEqualityComparer<T> equalityComparer)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0030: Expected Obj, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got I4
		//IL_0615: Expected Obj, but got I
		//IL_0625: Expected Obj, but got I
		//IL_0648: Expected Obj, but got I
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected Obj, but got Unknown
		//IL_0667: Expected Obj, but got Ref
		//IL_0674: Expected Obj, but got Ref
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected Obj, but got Unknown
		//IL_069c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		//IL_06ba: Expected Obj, but got I
		//IL_06ca: Expected Obj, but got I
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected Obj, but got Unknown
		//IL_06f2: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I
		//IL_0996: Expected Obj, but got I
		//IL_09a6: Expected Obj, but got I
		//IL_058f: Expected I4, but got I8
		//IL_0a82: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_0948: Expected Obj, but got I
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected Obj, but got Unknown
		//IL_0978: Expected Obj, but got I4
		//IL_0710: Expected Obj, but got I
		//IL_0720: Expected Obj, but got I
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected Obj, but got Unknown
		//IL_0748: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I
		//IL_09e5: Expected Obj, but got I
		//IL_09f3: Expected Obj, but got Ref
		//IL_0a11: Expected Obj, but got I
		//IL_0a36: Expected Obj, but got I
		//IL_0a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a44: Expected Obj, but got Unknown
		//IL_0a5e: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got Ref
		//IL_01c1: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0229: Expected Obj, but got I
		//IL_0242: Expected Obj, but got I4
		//IL_0269: Expected Obj, but got I
		//IL_05a9: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02af: Expected Obj, but got I4
		//IL_02e2: Expected Obj, but got I
		//IL_02f2: Expected Obj, but got I
		//IL_0308: Expected Obj, but got I
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected Obj, but got Unknown
		//IL_0330: Expected Obj, but got I4
		//IL_0789: Expected Obj, but got I
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_0797: Expected Obj, but got Unknown
		//IL_07b1: Expected Obj, but got I4
		//IL_0374: Expected Obj, but got I
		//IL_0384: Expected Obj, but got I
		//IL_039e: Expected Obj, but got I8
		//IL_03b8: Expected Obj, but got I4
		//IL_07d1: Expected Obj, but got I
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Expected Obj, but got Unknown
		//IL_07f9: Expected Obj, but got I4
		//IL_03fa: Expected Obj, but got I
		//IL_040a: Expected Obj, but got I
		//IL_0424: Expected Obj, but got I8
		//IL_043e: Expected Obj, but got I4
		//IL_0815: Expected I, but got Obj
		//IL_0825: Expected Obj, but got I
		//IL_0894: Expected Obj, but got Ref
		//IL_08a4: Expected Obj, but got I
		//IL_08d0: Expected Obj, but got I4
		//IL_0477: Expected Obj, but got I
		//IL_04f3: Expected Obj, but got I
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected Obj, but got Unknown
		//IL_0523: Expected Obj, but got I4
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected Obj, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Obj, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Obj, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected Obj, but got Unknown
		//IL_08f6: Expected Obj, but got I
		//IL_0906: Expected Obj, but got I
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected Obj, but got Unknown
		//IL_092e: Expected Obj, but got I4
		//IL_0547: Expected Obj, but got I
		//IL_0ac1: Expected Obj, but got I
		//IL_0b03: Expected Obj, but got I4
		//IL_0b14: Expected Obj, but got I4
		//IL_0b3d: Expected Obj, but got I4
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		_ = 0;
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3;
		object obj5 = obj3 & 1;
		bool flag = obj5 == null;
		object obj6 = !flag;
		nint num;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj7 = (nint)0 + (nint)309;
			obj4 = obj7;
			num = 0;
		}
		else
		{
			nint num2 = 0;
			num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X10_v1+20]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X10_v2+FC]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X10_v2+FC]");
		object obj10 = (nint)0 + (nint)15;
		object obj11 = obj10 & 0x1FFFFFFF0L;
		object obj13 = default;
		object obj12 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
		object obj14 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
		object obj15 = obj4 & 1;
		bool flag2 = obj15 == null;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj17 = (nint)0 + (nint)309;
			obj4 = obj17;
			num = 0;
		}
		else
		{
			IntPtr intPtr = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v5+60]");
		object obj19 = 0;
		object obj20 = obj4 & 1;
		bool flag3 = obj20 == null;
		object obj21 = !flag3;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			num = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v6 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7+60]");
		NullReferenceException ex = (NullReferenceException)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v89 @ X10_v6] (should have been resolved before IL gen)");
		NullReferenceException ex2 = default;
		bool flag4 = ex2 == null;
		IEqualityComparer<T> equalityComparer2 = equalityComparer;
		if (flag4)
		{
			goto IL_0582;
		}
		object obj24 = default;
		object obj23 = obj24;
		nint num4 = default;
		nint num3 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7+60]");
		NullReferenceException ex3 = (NullReferenceException)0;
		IEqualityComparer<T> equalityComparer3 = equalityComparer;
		int num5 = 0;
		NullReferenceException ex4 = ex2;
		IntPtr intPtr3 = default;
		object obj54 = default;
		IntPtr intPtr4 = default;
		while (true)
		{
			object obj25 = (nint)0 + (nint)309;
			object obj26 = obj25;
			object obj27 = obj25 & 1;
			bool flag5 = obj27 == null;
			object obj28 = !flag5;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj29 = (nint)0 + (nint)309;
				obj26 = obj29;
				nint num6 = 0;
			}
			else
			{
				nint num7 = 0;
				nint num6 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v12 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X10_v11+18]");
			object obj31 = 0;
			object obj32 = obj26 & 1;
			bool flag6 = obj32 == null;
			object obj33 = !flag6;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				nint num6 = intPtr3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v16 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj34 = 0;
			object obj35 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 28));
			num4 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v17+18]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v366 @ X1_v6+10] (should have been resolved before IL gen)");
			object obj37 = (nint)0 + (nint)309;
			object obj38 = obj37 & 1;
			bool flag7 = obj38 == null;
			object obj39 = !flag7;
			nint num8 = 0;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v17 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj40 = 0;
			NullReferenceException ex5 = (NullReferenceException)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v21+20]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v22+28]");
			bool flag8 = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v22+28]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v22+28]");
			object obj42 = num9 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v22+28]");
			object obj43 = 0 & obj42;
			bool flag9 = (nint)obj43 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
			equalityComparer2 = (IEqualityComparer<T>)0;
			bool flag10 = flag8 == flag9;
			object obj44 = !flag10;
			object obj45 = ~obj44;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-30]");
				ex = (NullReferenceException)0;
			}
			else
			{
				ex = ex5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			if (equalityComparer == null)
			{
				break;
			}
			object obj46 = (nint)0 + (nint)309;
			object obj47 = obj46 & 1;
			bool flag11 = obj47 == null;
			object obj48 = !flag11;
			nint num10 = 0;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v22 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v29+58]");
			object obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v29+58]");
			object obj51 = (nint)0 + (nint)309;
			object obj52 = obj51 & 1;
			bool flag12 = obj52 == null;
			object obj53 = !flag12;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				obj50 = obj54;
			}
			object obj55 = (nint)0 + (nint)309;
			object obj56 = obj55 & 1;
			bool flag13 = obj56 == null;
			object obj57 = !flag13;
			nint num11 = 0;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v25 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj58 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v34+20]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v35+28]");
			object obj60 = 0 & 0x80000000L;
			bool flag14 = obj60 == null;
			object obj61 = !flag14;
			object obj62 = obj12;
			if (obj61 == null)
			{
				obj62 = obj12;
			}
			object obj63 = (nint)0 + (nint)309;
			object obj64 = obj63 & 1;
			bool flag15 = obj64 == null;
			object obj65 = !flag15;
			nint num12 = 0;
			if (obj65 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X0_v27 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v39+20]");
			object obj67 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v40+28]");
			object obj68 = 0 & 0x80000000L;
			bool flag16 = obj68 == null;
			object obj69 = !flag16;
			object obj70 = obj14;
			if (obj69 == null)
			{
				obj70 = obj14;
			}
			nint num13 = (nint)equalityComparer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v42 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<T>>)+12E]");
			object obj71 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v42 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_04b8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v42 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<T>>)+98]");
			object obj72 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X10_v19-8]");
				if (0 == (nint)obj50)
				{
					break;
				}
				obj71--;
				obj72 += 16;
				if ((nint)obj71 != 1)
				{
					continue;
				}
				goto IL_04b8;
			}
			object obj73 = num13 + obj72;
			object obj74 = obj73 + 312;
			goto IL_086e;
			IL_04b8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_086e;
			IL_086e:
			num4 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
			obj24 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 28));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v28+8]");
			ex = (NullReferenceException)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v280._className (System.String) (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-1C]");
			bool flag17 = (nint)0 == 0;
			object obj75 = !flag17;
			equalityComparer2 = equalityComparer;
			if (obj75 == null)
			{
				object obj76 = (nint)0 + (nint)309;
				object obj77 = obj76;
				object obj78 = obj76 & 1;
				bool flag18 = obj78 == null;
				object obj79 = !flag18;
				if (obj79 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj80 = (nint)0 + (nint)309;
					obj77 = obj80;
					nint num14 = 0;
				}
				else
				{
					nint num15 = 0;
					nint num14 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X0_v31 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj81 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X10_v14+70]");
				object obj82 = 0;
				object obj83 = obj77 & 1;
				bool flag19 = obj83 == null;
				object obj84 = !flag19;
				if (obj84 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					nint num14 = intPtr4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v48 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj85 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v49+70]");
				num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v113 @ X10_v15] (should have been resolved before IL gen)");
				num5++;
				bool flag20 = ex2 == null;
				object obj86 = !flag20;
				ex = ex4;
				equalityComparer2 = (IEqualityComparer<T>)1;
				obj23 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v49+70]");
				num3 = 0;
				ex3 = ex4;
				equalityComparer3 = (IEqualityComparer<T>)1;
				ex4 = ex2;
				if (obj86 != null)
				{
					continue;
				}
				goto IL_0582;
			}
			goto IL_0a72;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-40]");
		object obj87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v25+28]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		bool flag21 = num16 != 0;
		obj24 = obj12;
		if (!flag21)
		{
			ex2 = new NullReferenceException();
			obj24 = obj12;
		}
		goto IL_05f6;
		IL_0a72:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-40]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v9+28]");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		if (num17 == 0)
		{
			return num5;
		}
		goto IL_05f6;
		IL_0582:
		num5 = -1;
		goto IL_0a72;
		IL_05f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		int result = default;
		return result;
	}

	public unsafe bool Remove(T value)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0026: Expected Obj, but got I
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0056: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I
		//IL_01da: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_020f: Expected Obj, but got Ref
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_0237: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_0255: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02cb: Expected VT, but got Ref
		//IL_02e4: Expected Obj, but got I4
		//IL_0313: Expected Obj, but got I
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_0343: Expected Obj, but got I4
		//IL_0361: Expected Obj, but got I
		//IL_0371: Expected Obj, but got I
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected Obj, but got Unknown
		//IL_0399: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I
		//IL_04e4: Expected Obj, but got I
		//IL_04fa: Expected Obj, but got I
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected Obj, but got Unknown
		//IL_052a: Expected Obj, but got I4
		//IL_03b7: Expected Obj, but got I
		//IL_03c7: Expected Obj, but got I
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected Obj, but got Unknown
		//IL_03ef: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I
		//IL_040d: Expected Obj, but got I
		//IL_041d: Expected Obj, but got I
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_0445: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I
		//IL_0548: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I
		//IL_0572: Expected Obj, but got I8
		//IL_058c: Expected Obj, but got I4
		//IL_0461: Expected Obj, but got Ref
		//IL_046f: Expected Obj, but got Ref
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3;
		object obj5 = obj3 & 1;
		bool flag = obj5 == null;
		object obj6 = !flag;
		nint num;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj7 = (nint)0 + (nint)309;
			obj4 = obj7;
			num = 0;
		}
		else
		{
			nint num2 = 0;
			num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X9_v1+20]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X9_v2+FC]");
		object obj10 = (nint)0 + (nint)15;
		object obj11 = obj10 & 0x1FFFFFFF0L;
		object obj13 = default;
		object obj12 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
		object obj14 = obj4 & 1;
		bool flag2 = obj14 == null;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			num = 0;
		}
		else
		{
			IntPtr intPtr = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5+20]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+28]");
		bool flag3 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+28]");
		object obj18 = num3 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+28]");
		object obj19 = 0 & obj18;
		bool flag4 = (nint)obj19 < 0;
		T val = (T)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
		bool flag5 = flag3 == flag4;
		object obj20 = !flag5;
		object obj21 = ~obj20;
		if (obj21 == null)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		object obj22 = num + 309;
		object obj23 = obj22;
		object obj24 = obj22 & 1;
		bool flag6 = obj24 == null;
		object obj25 = !flag6;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj26 = (nint)0 + (nint)309;
			obj23 = obj26;
			num = 0;
		}
		else
		{
			IntPtr intPtr2 = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v5 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X9_v4+38]");
		object obj28 = 0;
		object obj29 = obj23 & 1;
		bool flag7 = obj29 == null;
		object obj30 = !flag7;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr3 = default;
			num = intPtr3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X22_v5 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ X9_v5] (should have been resolved before IL gen)");
		object obj32 = (nint)0 + (nint)309;
		object obj33 = obj32;
		object obj34 = obj32 & 1;
		bool flag8 = obj34 == null;
		object obj35 = !flag8;
		nint num4;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj36 = (nint)0 + (nint)309;
			obj33 = obj36;
			num4 = 0;
		}
		else
		{
			nint num5 = 0;
			num4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v9 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X10_v3+80]");
		object obj38 = 0;
		object obj39 = obj33 & 1;
		bool flag9 = obj39 == null;
		object obj40 = !flag9;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj41 = (nint)0 + (nint)309;
			obj33 = obj41;
			num4 = 0;
		}
		else
		{
			IntPtr intPtr4 = num4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v10 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X10_v5+80]");
		object obj43 = 0;
		object obj44 = obj33 & 1;
		bool flag10 = obj44 == null;
		object obj45 = !flag10;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr5 = default;
			num4 = intPtr5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v16 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v17+20]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v18+28]");
		object obj48 = 0 & 0x80000000L;
		bool flag11 = obj48 == null;
		object obj49 = !flag11;
		if (obj49 == null)
		{
			obj12 = obj12;
		}
		object obj50 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
		object obj51 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ X21_v2+10] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-C]");
		bool flag12 = (nint)0 == 0;
		bool result = !flag12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
		if (num6 == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result2 = default;
		return result2;
	}

	public unsafe bool Remove(T value, IEqualityComparer<T> equalityComparer)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0030: Expected Obj, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got I4
		//IL_0692: Expected Obj, but got I
		//IL_06a2: Expected Obj, but got I
		//IL_06b8: Expected Obj, but got I
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected Obj, but got Unknown
		//IL_06d7: Expected Obj, but got Ref
		//IL_06e4: Expected Obj, but got Ref
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Expected Obj, but got Unknown
		//IL_070c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		//IL_072a: Expected Obj, but got I
		//IL_073a: Expected Obj, but got I
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected Obj, but got Unknown
		//IL_0762: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I
		//IL_0aaf: Expected Obj, but got I
		//IL_0565: Expected Obj, but got I
		//IL_0a2b: Expected Obj, but got I4
		//IL_09c4: Expected Obj, but got I
		//IL_09d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09da: Expected Obj, but got Unknown
		//IL_09f4: Expected Obj, but got I4
		//IL_0780: Expected Obj, but got I
		//IL_0790: Expected Obj, but got I
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected Obj, but got Unknown
		//IL_07b8: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I
		//IL_0afa: Expected Obj, but got I
		//IL_0b08: Expected Obj, but got Ref
		//IL_0b26: Expected Obj, but got I
		//IL_0b4b: Expected Obj, but got I
		//IL_0b54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b59: Expected Obj, but got Unknown
		//IL_0b73: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_0229: Expected Obj, but got I4
		//IL_0606: Expected Obj, but got I
		//IL_063f: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_0296: Expected Obj, but got I4
		//IL_066e: Expected Obj, but got I
		//IL_02c9: Expected Obj, but got I
		//IL_02d9: Expected Obj, but got I
		//IL_02ef: Expected Obj, but got I
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_0317: Expected Obj, but got I4
		//IL_07f9: Expected Obj, but got I
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Expected Obj, but got Unknown
		//IL_0821: Expected Obj, but got I4
		//IL_035b: Expected Obj, but got I
		//IL_036b: Expected Obj, but got I
		//IL_0385: Expected Obj, but got I8
		//IL_039f: Expected Obj, but got I4
		//IL_0841: Expected Obj, but got I
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		//IL_084f: Expected Obj, but got Unknown
		//IL_0869: Expected Obj, but got I4
		//IL_03e1: Expected Obj, but got I
		//IL_03f1: Expected Obj, but got I
		//IL_040b: Expected Obj, but got I8
		//IL_0425: Expected Obj, but got I4
		//IL_0885: Expected I, but got Obj
		//IL_0895: Expected Obj, but got I
		//IL_0904: Expected Obj, but got Ref
		//IL_0914: Expected Obj, but got I
		//IL_092a: Expected Obj, but got I
		//IL_0954: Expected Obj, but got I4
		//IL_045e: Expected Obj, but got I
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_0592: Expected Obj, but got I4
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected Obj, but got Unknown
		//IL_04f6: Expected Obj, but got I4
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected Obj, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected Obj, but got Unknown
		//IL_0a49: Expected Obj, but got I
		//IL_0a59: Expected Obj, but got I
		//IL_0a69: Expected Obj, but got I
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Expected Obj, but got Unknown
		//IL_0a91: Expected Obj, but got I4
		//IL_05b6: Expected Obj, but got I
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected Obj, but got Unknown
		//IL_0c27: Expected Obj, but got I
		//IL_0c37: Expected Obj, but got I
		//IL_0972: Expected Obj, but got I
		//IL_0982: Expected Obj, but got I
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0990: Expected Obj, but got Unknown
		//IL_09aa: Expected Obj, but got I4
		//IL_051a: Expected Obj, but got I
		//IL_0b97: Expected Obj, but got I
		//IL_0bc7: Expected Obj, but got I4
		//IL_0bd8: Expected Obj, but got I4
		//IL_0c01: Expected Obj, but got I4
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		_ = 0;
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3;
		object obj5 = obj3 & 1;
		bool flag = obj5 == null;
		object obj6 = !flag;
		nint num;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj7 = (nint)0 + (nint)309;
			obj4 = obj7;
			num = 0;
		}
		else
		{
			nint num2 = 0;
			num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X10_v1+20]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X10_v2+FC]");
		object obj10 = (nint)0 + (nint)15;
		object obj11 = obj10 & 0x1FFFFFFF0L;
		object obj13 = default;
		object obj12 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
		object obj14 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
		object obj15 = obj4 & 1;
		bool flag2 = obj15 == null;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj17 = (nint)0 + (nint)309;
			obj4 = obj17;
			num = 0;
		}
		else
		{
			IntPtr intPtr = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v5+60]");
		object obj19 = 0;
		object obj20 = obj4 & 1;
		bool flag3 = obj20 == null;
		object obj21 = !flag3;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			num = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v6 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7+60]");
		bool flag4 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v89 @ X10_v6] (should have been resolved before IL gen)");
		bool flag6 = default;
		bool flag5 = !flag6;
		IEqualityComparer<T> equalityComparer2 = equalityComparer;
		if (flag5)
		{
			goto IL_0555;
		}
		object obj24 = default;
		object obj23 = obj24;
		nint num4 = default;
		nint num3 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7+60]");
		bool flag7 = false;
		IEqualityComparer<T> equalityComparer3 = equalityComparer;
		bool flag8 = flag6;
		IntPtr intPtr3 = default;
		object obj54 = default;
		object obj76;
		object obj77;
		IntPtr intPtr4 = default;
		while (true)
		{
			object obj25 = (nint)0 + (nint)309;
			object obj26 = obj25;
			object obj27 = obj25 & 1;
			bool flag9 = obj27 == null;
			object obj28 = !flag9;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj29 = (nint)0 + (nint)309;
				obj26 = obj29;
				nint num5 = 0;
			}
			else
			{
				nint num6 = 0;
				nint num5 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v11 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X10_v11+18]");
			object obj31 = 0;
			object obj32 = obj26 & 1;
			bool flag10 = obj32 == null;
			object obj33 = !flag10;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				nint num5 = intPtr3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v15 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj34 = 0;
			object obj35 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 28));
			num4 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v16+18]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v364 @ X1_v6+10] (should have been resolved before IL gen)");
			object obj37 = (nint)0 + (nint)309;
			object obj38 = obj37 & 1;
			bool flag11 = obj38 == null;
			object obj39 = !flag11;
			nint num7 = 0;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v16 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj40 = 0;
			bool flag12 = (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40)) != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v20+20]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v21+28]");
			bool flag13 = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v21+28]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v21+28]");
			object obj42 = num8 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v21+28]");
			object obj43 = 0 & obj42;
			bool flag14 = (nint)obj43 < 0;
			bool flag15 = flag13 == flag14;
			object obj44 = !flag15;
			object obj45 = ~obj44;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-30]");
				flag4 = false;
			}
			else
			{
				flag4 = flag12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			if (equalityComparer == null)
			{
				break;
			}
			object obj46 = (nint)0 + (nint)309;
			object obj47 = obj46 & 1;
			bool flag16 = obj47 == null;
			object obj48 = !flag16;
			nint num9 = 0;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v21 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v28+58]");
			object obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v28+58]");
			object obj51 = (nint)0 + (nint)309;
			object obj52 = obj51 & 1;
			bool flag17 = obj52 == null;
			object obj53 = !flag17;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				obj50 = obj54;
			}
			object obj55 = (nint)0 + (nint)309;
			object obj56 = obj55 & 1;
			bool flag18 = obj56 == null;
			object obj57 = !flag18;
			nint num10 = 0;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v24 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj58 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v33+20]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v34+28]");
			object obj60 = 0 & 0x80000000L;
			bool flag19 = obj60 == null;
			object obj61 = !flag19;
			object obj62 = obj12;
			if (obj61 == null)
			{
				obj62 = obj12;
			}
			object obj63 = (nint)0 + (nint)309;
			object obj64 = obj63 & 1;
			bool flag20 = obj64 == null;
			object obj65 = !flag20;
			nint num11 = 0;
			if (obj65 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X0_v26 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v38+20]");
			object obj67 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v39+28]");
			object obj68 = 0 & 0x80000000L;
			bool flag21 = obj68 == null;
			object obj69 = !flag21;
			object obj70 = obj14;
			if (obj69 == null)
			{
				obj70 = obj14;
			}
			nint num12 = (nint)equalityComparer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v41 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<T>>)+12E]");
			object obj71 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v41 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_049f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v41 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<T>>)+98]");
			object obj72 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X10_v22-8]");
				if (0 == (nint)obj50)
				{
					break;
				}
				obj71--;
				obj72 += 16;
				if ((nint)obj71 != 1)
				{
					continue;
				}
				goto IL_049f;
			}
			object obj73 = num12 + obj72;
			object obj74 = obj73 + 312;
			goto IL_08de;
			IL_049f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_08de;
			IL_08de:
			num4 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
			obj24 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 28));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v27+8]");
			object obj75 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v511 @ X1_v9+10] (should have been resolved before IL gen)");
			obj76 = (nint)0 + (nint)309;
			obj77 = obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-1C]");
			bool flag22 = (nint)0 == 0;
			object obj78 = !flag22;
			if (obj78 == null)
			{
				object obj79 = obj77 & 1;
				bool flag23 = obj79 == null;
				object obj80 = !flag23;
				if (obj80 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj81 = (nint)0 + (nint)309;
					obj77 = obj81;
					nint num13 = 0;
				}
				else
				{
					nint num14 = 0;
					nint num13 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v40 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj82 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X10_v17+70]");
				object obj83 = 0;
				object obj84 = obj77 & 1;
				bool flag24 = obj84 == null;
				object obj85 = !flag24;
				if (obj85 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					nint num13 = intPtr4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v51 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj86 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v52+70]");
				num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ X10_v18] (should have been resolved before IL gen)");
				bool flag25 = !flag6;
				object obj87 = !flag25;
				flag4 = flag8;
				equalityComparer2 = (IEqualityComparer<T>)1;
				obj23 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v52+70]");
				num3 = 0;
				flag7 = flag8;
				equalityComparer3 = (IEqualityComparer<T>)1;
				flag8 = flag6;
				if (obj87 != null)
				{
					continue;
				}
				goto IL_0555;
			}
			goto IL_056a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v24+28]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		bool flag26 = num15 != 0;
		obj24 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X10_v2+FC]");
		equalityComparer2 = (IEqualityComparer<T>)0;
		NullReferenceException ex;
		if (!flag26)
		{
			ex = new NullReferenceException();
			obj24 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X10_v2+FC]");
			equalityComparer2 = (IEqualityComparer<T>)0;
		}
		goto IL_0673;
		IL_0673:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result = default;
		return result;
		IL_0a02:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X21_v2+28]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		bool flag27 = num16 != 0;
		ex = (NullReferenceException)flag6;
		if (!flag27)
		{
			return flag6;
		}
		goto IL_0673;
		IL_0555:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
		object obj89 = 0;
		goto IL_0a02;
		IL_056a:
		object obj90 = obj76 & 1;
		bool flag28 = obj90 == null;
		object obj91 = !flag28;
		if (obj91 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj92 = (nint)0 + (nint)309;
			obj77 = obj92;
			nint num17 = 0;
		}
		else
		{
			nint num18 = 0;
			nint num17 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v30 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj93 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
		obj89 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X10_v15+88]");
		object obj94 = 0;
		object obj95 = obj77 & 1;
		bool flag29 = obj95 == null;
		object obj96 = !flag29;
		if (obj96 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr5 = default;
			nint num17 = intPtr5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v46 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj97 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v47+88]");
		equalityComparer2 = (IEqualityComparer<T>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v199 @ X10_v16] (should have been resolved before IL gen)");
		flag4 = flag8;
		flag6 = true;
		goto IL_0a02;
	}

	public unsafe void Add(T value)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_072c: Expected Obj, but got I
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected Obj, but got Unknown
		//IL_075c: Expected Obj, but got I4
		//IL_077a: Expected Obj, but got I
		//IL_078a: Expected Obj, but got I
		//IL_07a0: Expected Obj, but got I
		//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Expected Obj, but got Unknown
		//IL_07bf: Expected Obj, but got Ref
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cd: Expected Obj, but got Unknown
		//IL_07e7: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I
		//IL_0805: Expected Obj, but got I
		//IL_0815: Expected Obj, but got I
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Expected Obj, but got Unknown
		//IL_083d: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_0fb0: Expected Obj, but got I
		//IL_0fc6: Expected Obj, but got I
		//IL_0fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdc: Expected Obj, but got Unknown
		//IL_0ff6: Expected Obj, but got I4
		//IL_085b: Expected Obj, but got I
		//IL_086b: Expected Obj, but got I
		//IL_087b: Expected Obj, but got I
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected Obj, but got Unknown
		//IL_08a3: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I
		//IL_1014: Expected Obj, but got I
		//IL_1098: Expected Obj, but got I4
		//IL_10a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a5: Expected I4, but got Unknown
		//IL_10be: Expected Obj, but got I
		//IL_10cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d4: Expected Obj, but got Unknown
		//IL_10ee: Expected Obj, but got I4
		//IL_08c1: Expected Obj, but got I
		//IL_08d1: Expected Obj, but got I
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Expected Obj, but got Unknown
		//IL_08f9: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I
		//IL_110c: Expected Obj, but got I
		//IL_1122: Expected Obj, but got I
		//IL_1133: Unknown result type (might be due to invalid IL or missing references)
		//IL_1138: Expected Obj, but got Unknown
		//IL_1152: Expected Obj, but got I4
		//IL_0917: Expected Obj, but got I
		//IL_0927: Expected Obj, but got I
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Expected Obj, but got Unknown
		//IL_094f: Expected Obj, but got I4
		//IL_015e: Expected Obj, but got I
		//IL_1170: Expected Obj, but got I
		//IL_06d3: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01d5: Expected Obj, but got I4
		//IL_0708: Expected Obj, but got I4
		//IL_096d: Expected Obj, but got I
		//IL_097d: Expected Obj, but got I
		//IL_098d: Expected Obj, but got I
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_099b: Expected Obj, but got Unknown
		//IL_09b5: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I
		//IL_11b6: Expected Obj, but got I
		//IL_11f3: Expected Obj, but got I
		//IL_1204: Unknown result type (might be due to invalid IL or missing references)
		//IL_1209: Expected Obj, but got Unknown
		//IL_1223: Expected Obj, but got I4
		//IL_09d3: Expected Obj, but got I
		//IL_09e3: Expected Obj, but got I
		//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Expected Obj, but got Unknown
		//IL_0a0b: Expected Obj, but got I4
		//IL_024a: Expected Obj, but got I
		//IL_1241: Expected Obj, but got I
		//IL_1257: Expected Obj, but got I
		//IL_1268: Unknown result type (might be due to invalid IL or missing references)
		//IL_126d: Expected Obj, but got Unknown
		//IL_1287: Expected Obj, but got I4
		//IL_0a29: Expected Obj, but got I
		//IL_0a39: Expected Obj, but got I
		//IL_0a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a47: Expected Obj, but got Unknown
		//IL_0a61: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got I
		//IL_12a5: Expected Obj, but got I
		//IL_12ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b3: Expected Obj, but got Unknown
		//IL_12c9: Expected Obj, but got I
		//IL_12d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d7: Expected Obj, but got Unknown
		//IL_12f1: Expected Obj, but got I4
		//IL_0a7f: Expected Obj, but got I
		//IL_0a8f: Expected Obj, but got I
		//IL_0ac3: Expected Obj, but got I
		//IL_0ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Expected Obj, but got Unknown
		//IL_0af5: Expected VT, but got Ref
		//IL_0b0e: Expected Obj, but got I4
		//IL_0b3d: Expected Obj, but got I
		//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b53: Expected Obj, but got Unknown
		//IL_0b6d: Expected Obj, but got I4
		//IL_0b8b: Expected Obj, but got I
		//IL_0b9b: Expected Obj, but got I
		//IL_0ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba9: Expected Obj, but got Unknown
		//IL_0bc3: Expected Obj, but got I4
		//IL_0317: Expected Obj, but got I
		//IL_0be1: Expected Obj, but got I
		//IL_0bf1: Expected Obj, but got I
		//IL_0bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bff: Expected Obj, but got Unknown
		//IL_0c19: Expected Obj, but got I4
		//IL_034d: Expected Obj, but got I
		//IL_130f: Expected Obj, but got I
		//IL_131f: Expected Obj, but got I
		//IL_1339: Expected Obj, but got I8
		//IL_1353: Expected Obj, but got I4
		//IL_0c35: Expected Obj, but got Ref
		//IL_0c43: Expected Obj, but got Ref
		//IL_0c68: Expected Obj, but got I
		//IL_0c79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7e: Expected Obj, but got Unknown
		//IL_0c98: Expected Obj, but got I4
		//IL_0cb6: Expected Obj, but got I
		//IL_0cc6: Expected Obj, but got I
		//IL_0ccf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd4: Expected Obj, but got Unknown
		//IL_0cee: Expected Obj, but got I4
		//IL_03a7: Expected Obj, but got I
		//IL_1371: Expected Obj, but got I
		//IL_1387: Expected Obj, but got I
		//IL_1398: Unknown result type (might be due to invalid IL or missing references)
		//IL_139d: Expected Obj, but got Unknown
		//IL_13b7: Expected Obj, but got I4
		//IL_0d0c: Expected Obj, but got I
		//IL_0d1c: Expected Obj, but got I
		//IL_0d25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2a: Expected Obj, but got Unknown
		//IL_0d44: Expected Obj, but got I4
		//IL_03f8: Expected Obj, but got I
		//IL_13d5: Expected Obj, but got I
		//IL_13eb: Expected Obj, but got I
		//IL_13fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1401: Expected Obj, but got Unknown
		//IL_141b: Expected Obj, but got I4
		//IL_0d62: Expected Obj, but got I
		//IL_0d72: Expected Obj, but got I
		//IL_0d7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d80: Expected Obj, but got Unknown
		//IL_0d9a: Expected Obj, but got I4
		//IL_0449: Expected Obj, but got I
		//IL_1439: Expected Obj, but got I
		//IL_1449: Expected Obj, but got I
		//IL_145f: Expected Obj, but got I
		//IL_1470: Unknown result type (might be due to invalid IL or missing references)
		//IL_1475: Expected Obj, but got Unknown
		//IL_148f: Expected Obj, but got I4
		//IL_0db8: Expected Obj, but got I
		//IL_0dc8: Expected Obj, but got I
		//IL_0dd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd6: Expected Obj, but got Unknown
		//IL_0df0: Expected Obj, but got I4
		//IL_049a: Expected Obj, but got I
		//IL_14ad: Expected Obj, but got I
		//IL_14c3: Expected Obj, but got I
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected Obj, but got Unknown
		//IL_055c: Expected Obj, but got I4
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected Obj, but got Unknown
		//IL_04fd: Expected Obj, but got I4
		//IL_0e64: Expected Obj, but got I
		//IL_0e74: Expected Obj, but got I
		//IL_0e7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e82: Expected Obj, but got Unknown
		//IL_0e9c: Expected Obj, but got I4
		//IL_0580: Expected Obj, but got I
		//IL_155c: Expected Obj, but got I
		//IL_156c: Expected Obj, but got I
		//IL_157b: Expected I, but got Obj
		//IL_0e0e: Expected Obj, but got I
		//IL_0e1e: Expected Obj, but got I
		//IL_0e27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2c: Expected Obj, but got Unknown
		//IL_0e46: Expected Obj, but got I4
		//IL_0521: Expected Obj, but got I
		//IL_0f0c: Expected Obj, but got I
		//IL_0f1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f22: Expected Obj, but got Unknown
		//IL_0f3c: Expected Obj, but got I4
		//IL_14f8: Expected Obj, but got I
		//IL_150e: Expected Obj, but got I
		//IL_151f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1524: Expected Obj, but got Unknown
		//IL_153e: Expected Obj, but got I4
		//IL_0f5a: Expected Obj, but got I
		//IL_0f6a: Expected Obj, but got I
		//IL_0f73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f78: Expected Obj, but got Unknown
		//IL_0f92: Expected Obj, but got I4
		//IL_064a: Expected Obj, but got I
		//IL_0eba: Expected Obj, but got I
		//IL_0eca: Expected Obj, but got I
		//IL_0ed3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed8: Expected Obj, but got Unknown
		//IL_0ef2: Expected Obj, but got I4
		//IL_05d1: Expected Obj, but got I
		//IL_15e0: Expected Obj, but got I
		//IL_15f0: Expected Obj, but got I
		//IL_1598: Expected Obj, but got I
		//IL_15a8: Expected Obj, but got I
		//IL_15c3: Expected Obj, but got I4
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		_ = 0;
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3;
		object obj5 = obj3 & 1;
		bool flag = obj5 == null;
		object obj6 = !flag;
		nint num;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj7 = (nint)0 + (nint)309;
			obj4 = obj7;
			num = 0;
		}
		else
		{
			nint num2 = 0;
			num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X10_v1+20]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X10_v2+FC]");
		object obj10 = (nint)0 + (nint)15;
		object obj11 = obj10 & 0x1FFFFFFF0L;
		object obj13 = default;
		object obj12 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
		object obj14 = obj4 & 1;
		bool flag2 = obj14 == null;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj16 = (nint)0 + (nint)309;
			obj4 = obj16;
			num = 0;
		}
		else
		{
			IntPtr intPtr = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v3 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v4+90]");
		object obj18 = 0;
		object obj19 = obj4 & 1;
		bool flag3 = obj19 == null;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			num = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v97 @ X10_v5] (should have been resolved before IL gen)");
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22;
		object obj24 = obj22 & 1;
		bool flag4 = obj24 == null;
		object obj25 = !flag4;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj26 = (nint)0 + (nint)309;
			obj23 = obj26;
			nint num3 = 0;
		}
		else
		{
			nint num4 = 0;
			nint num3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v7 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X10_v6+30]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A30]");
		object error = 0;
		object obj29 = obj23 & 1;
		bool flag5 = obj29 == null;
		object obj30 = !flag5;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr3 = default;
			nint num3 = intPtr3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v11 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ X10_v7] (should have been resolved before IL gen)");
		object obj33 = default;
		object obj34 = default;
		object obj32 = obj33 - obj34;
		bool flag6 = (nint)obj32 < 0;
		bool flag7 = obj32 == null;
		object obj35 = obj33 ^ obj34;
		object obj36 = obj33 ^ obj32;
		object obj37 = obj35 & obj36;
		bool flag8 = (nint)obj37 < 0;
		bool flag9 = flag6 == flag8;
		object obj38 = !flag9;
		bool condition = (byte)((obj38 | flag7) ? 1 : 0) != 0;
		Assert.Check(condition, (string)error);
		object obj39 = (nint)0 + (nint)309;
		object obj40 = obj39;
		object obj41 = obj39 & 1;
		bool flag10 = obj41 == null;
		object obj42 = !flag10;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj43 = (nint)0 + (nint)309;
			obj40 = obj43;
			nint num5 = 0;
		}
		else
		{
			nint num6 = 0;
			nint num5 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v12 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X10_v8+90]");
		object obj45 = 0;
		object obj46 = obj40 & 1;
		bool flag11 = obj46 == null;
		object obj47 = !flag11;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr4 = default;
			nint num5 = intPtr4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v15 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v175 @ X10_v9] (should have been resolved before IL gen)");
		object obj49 = (nint)0 + (nint)309;
		object obj50 = obj49;
		object obj51 = obj49 & 1;
		bool flag12 = obj51 == null;
		object obj52 = !flag12;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj53 = (nint)0 + (nint)309;
			obj50 = obj53;
			nint num7 = 0;
		}
		else
		{
			nint num8 = 0;
			nint num7 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v16 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X10_v10+30]");
		object obj55 = 0;
		object obj56 = obj50 & 1;
		bool flag13 = obj56 == null;
		object obj57 = !flag13;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr5 = default;
			nint num7 = intPtr5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v19 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v20+30]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v206 @ X10_v11] (should have been resolved before IL gen)");
		object obj59 = default;
		object obj60 = default;
		if (obj59 != obj60)
		{
			object obj61 = (nint)0 + (nint)309;
			object obj62 = obj61;
			object obj63 = obj61 & 1;
			bool flag14 = obj63 == null;
			object obj64 = !flag14;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj65 = (nint)0 + (nint)309;
				obj62 = obj65;
				nint num10 = 0;
			}
			else
			{
				nint num11 = 0;
				nint num10 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v32 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X10_v13+98]");
			object obj67 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A38]");
			object error2 = 0;
			object obj68 = obj62 & 1;
			bool flag15 = obj68 == null;
			object obj69 = !flag15;
			if (obj69 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr6 = default;
				nint num10 = intPtr6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v25 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj70 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v250 @ X10_v14] (should have been resolved before IL gen)");
			IntPtr intPtr7 = default;
			bool flag16 = intPtr7 == (IntPtr)0;
			bool condition2 = !flag16;
			Assert.Check(condition2, (string)error2);
			object obj71 = (nint)0 + (nint)309;
			object obj72 = obj71;
			object obj73 = obj71 & 1;
			bool flag17 = obj73 == null;
			object obj74 = !flag17;
			if (obj74 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj75 = (nint)0 + (nint)309;
				obj72 = obj75;
				nint num12 = 0;
			}
			else
			{
				nint num13 = 0;
				nint num12 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v37 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj76 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X10_v15+90]");
			object obj77 = 0;
			object obj78 = obj72 & 1;
			bool flag18 = obj78 == null;
			object obj79 = !flag18;
			if (obj79 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr8 = default;
				nint num12 = intPtr8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v29 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj80 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v371 @ X10_v16] (should have been resolved before IL gen)");
			object obj81 = (nint)0 + (nint)309;
			object obj82 = obj81;
			object obj83 = obj81 & 1;
			bool flag19 = obj83 == null;
			object obj84 = !flag19;
			if (obj84 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj85 = (nint)0 + (nint)309;
				obj82 = obj85;
				nint num14 = 0;
			}
			else
			{
				nint num15 = 0;
				nint num14 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v41 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj86 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X10_v17+A0]");
			object obj87 = 0;
			object obj88 = obj82 & 1;
			bool flag20 = obj88 == null;
			object obj89 = !flag20;
			if (obj89 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr9 = default;
				nint num14 = intPtr9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v33 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj90 = 0;
			object obj92 = default;
			object obj91 = obj92 + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v444 @ X10_v18] (should have been resolved before IL gen)");
			object obj93 = (nint)0 + (nint)309;
			object obj94 = obj93 & 1;
			bool flag21 = obj94 == null;
			object obj95 = !flag21;
			nint num16;
			if (obj95 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				num16 = 0;
			}
			else
			{
				num16 = 0;
				nint num17 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v45 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj96 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v37+20]");
			object obj97 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v38+28]");
			bool flag22 = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v38+28]");
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v38+28]");
			object obj98 = num18 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v38+28]");
			object obj99 = 0 & obj98;
			bool flag23 = (nint)obj99 < 0;
			T val = (T)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
			bool flag24 = flag22 == flag23;
			object obj100 = !flag24;
			object obj101 = ~obj100;
			if (obj101 == null)
			{
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			object obj102 = num16 + 309;
			object obj103 = obj102;
			object obj104 = obj102 & 1;
			bool flag25 = obj104 == null;
			object obj105 = !flag25;
			if (obj105 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj106 = (nint)0 + (nint)309;
				obj103 = obj106;
				num16 = 0;
			}
			else
			{
				IntPtr intPtr10 = num16;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v48 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj107 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X9_v25+28]");
			object obj108 = 0;
			object obj109 = obj103 & 1;
			bool flag26 = obj109 == null;
			object obj110 = !flag26;
			if (obj110 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj111 = (nint)0 + (nint)309;
				obj103 = obj111;
				num16 = 0;
			}
			else
			{
				IntPtr intPtr11 = num16;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v49 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj112 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X9_v27+28]");
			object obj113 = 0;
			object obj114 = obj103 & 1;
			bool flag27 = obj114 == null;
			object obj115 = !flag27;
			if (obj115 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr12 = default;
				num16 = intPtr12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X25_v13 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj116 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v45+20]");
			object obj117 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v46+28]");
			object obj118 = 0 & 0x80000000L;
			bool flag28 = obj118 == null;
			object obj119 = !flag28;
			if (obj119 == null)
			{
				obj12 = obj12;
			}
			object obj120 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
			object obj121 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v334 @ X24_v3+10] (should have been resolved before IL gen)");
			object obj122 = (nint)0 + (nint)309;
			object obj123 = obj122;
			object obj124 = obj122 & 1;
			bool flag29 = obj124 == null;
			object obj125 = !flag29;
			if (obj125 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj126 = (nint)0 + (nint)309;
				obj123 = obj126;
				nint num19 = 0;
			}
			else
			{
				nint num20 = 0;
				nint num19 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X0_v53 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj127 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X10_v19+A8]");
			object obj128 = 0;
			object obj129 = obj123 & 1;
			bool flag30 = obj129 == null;
			object obj130 = !flag30;
			if (obj130 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr13 = default;
				nint num19 = intPtr13;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v51 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj131 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v560 @ X10_v20] (should have been resolved before IL gen)");
			object obj132 = (nint)0 + (nint)309;
			object obj133 = obj132;
			object obj134 = obj132 & 1;
			bool flag31 = obj134 == null;
			object obj135 = !flag31;
			if (obj135 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj136 = (nint)0 + (nint)309;
				obj133 = obj136;
				nint num21 = 0;
			}
			else
			{
				nint num22 = 0;
				nint num21 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v57 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj137 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X10_v21+B0]");
			object obj138 = 0;
			object obj139 = obj133 & 1;
			bool flag32 = obj139 == null;
			object obj140 = !flag32;
			if (obj140 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr14 = default;
				nint num21 = intPtr14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v55 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj141 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v591 @ X10_v22] (should have been resolved before IL gen)");
			object obj142 = (nint)0 + (nint)309;
			object obj143 = obj142;
			object obj144 = obj142 & 1;
			bool flag33 = obj144 == null;
			object obj145 = !flag33;
			if (obj145 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj146 = (nint)0 + (nint)309;
				obj143 = obj146;
				nint num23 = 0;
			}
			else
			{
				nint num24 = 0;
				nint num23 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X0_v61 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj147 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X10_v23+B0]");
			object obj148 = 0;
			object obj149 = obj143 & 1;
			bool flag34 = obj149 == null;
			object obj150 = !flag34;
			if (obj150 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr15 = default;
				nint num23 = intPtr15;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v59 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj151 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X8_v60+B0]");
			object obj152 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v624 @ X10_v24] (should have been resolved before IL gen)");
			object obj153 = (nint)0 + (nint)309;
			object obj154 = obj153;
			object obj155 = obj153 & 1;
			bool flag35 = obj155 == null;
			object obj156 = !flag35;
			if (obj156 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj157 = (nint)0 + (nint)309;
				obj154 = obj157;
				nint num25 = 0;
			}
			else
			{
				nint num26 = 0;
				nint num25 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X0_v65 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj158 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X10_v25+A8]");
			object obj159 = 0;
			object obj160 = obj154 & 1;
			bool flag36 = obj160 == null;
			object obj161 = !flag36;
			if (obj161 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr16 = default;
				nint num25 = intPtr16;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v63 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj162 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v657 @ X10_v26] (should have been resolved before IL gen)");
			object obj163 = (nint)0 + (nint)309;
			object obj164 = obj163;
			object obj165 = default;
			if (obj165 != null)
			{
				object obj166 = obj164 & 1;
				bool flag37 = obj166 == null;
				object obj167 = !flag37;
				if (obj167 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj168 = (nint)0 + (nint)309;
					obj164 = obj168;
					nint num27 = 0;
				}
				else
				{
					nint num28 = 0;
					nint num27 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X0_v88 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj169 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X10_v32+A8]");
				object obj170 = 0;
				object obj171 = obj164 & 1;
				bool flag38 = obj171 == null;
				object obj172 = !flag38;
				if (obj172 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr17 = default;
					nint num27 = intPtr17;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X8_v80 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj173 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v694 @ X10_v33] (should have been resolved before IL gen)");
				object obj174 = (nint)0 + (nint)309;
				object obj175 = obj174;
				object obj176 = obj174 & 1;
				bool flag39 = obj176 == null;
				object obj177 = !flag39;
				if (obj177 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj178 = (nint)0 + (nint)309;
					obj175 = obj178;
					nint num29 = 0;
				}
				else
				{
					nint num30 = 0;
					nint num29 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X0_v92 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj179 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X10_v34+B0]");
				object obj180 = 0;
				object obj181 = obj175 & 1;
				bool flag40 = obj181 == null;
				object obj182 = !flag40;
				if (obj182 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr18 = default;
					nint num29 = intPtr18;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X8_v84 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj183 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X8_v85+B0]");
				obj152 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v743 @ X10_v35] (should have been resolved before IL gen)");
				nint num31 = intPtr7;
				object obj184 = 1;
				IntPtr intPtr20 = default;
				IntPtr intPtr19 = intPtr20;
			}
			else
			{
				object obj185 = obj163 & 1;
				bool flag41 = obj185 == null;
				object obj186 = !flag41;
				if (obj186 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj187 = (nint)0 + (nint)309;
					obj164 = obj187;
					nint num32 = 0;
				}
				else
				{
					nint num33 = 0;
					nint num32 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X0_v79 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj188 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X10_v30+C0]");
				object obj189 = 0;
				object obj190 = obj164 & 1;
				bool flag42 = obj190 == null;
				object obj191 = !flag42;
				if (obj191 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr21 = default;
					nint num32 = intPtr21;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X8_v75 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj192 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v76+C0]");
				object obj184 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v706 @ X10_v31] (should have been resolved before IL gen)");
				nint num31 = unchecked((nint)null);
				IntPtr intPtr19 = intPtr7;
			}
			object obj193 = (nint)0 + (nint)309;
			object obj194 = obj193;
			object obj195 = obj193 & 1;
			bool flag43 = obj195 == null;
			object obj196 = !flag43;
			if (obj196 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj197 = (nint)0 + (nint)309;
				obj194 = obj197;
				nint num34 = 0;
			}
			else
			{
				nint num35 = 0;
				nint num34 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v70 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj198 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X10_v28+B8]");
			object obj199 = 0;
			object obj200 = obj194 & 1;
			bool flag44 = obj200 == null;
			object obj201 = !flag44;
			if (obj201 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr22 = default;
				nint num34 = intPtr22;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X8_v69 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj202 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v70+B8]");
			object obj203 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v312 @ X10_v29] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
			bool flag45 = num36 != 0;
			num9 = intPtr7;
			if (!flag45)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
			bool flag46 = num37 != 0;
			object obj203 = 0;
			string text = default;
			ArgumentNullException ex = (ArgumentNullException)(object)text;
			if (!flag46)
			{
				InvalidOperationException ex2 = default;
				ex2._002Ector(text);
				ex = new ArgumentNullException();
				obj203 = 0;
				IntPtr intPtr23 = default;
				num9 = intPtr23;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
	}

	private int FindFreeEntry()
	{
		//IL_01e4: Expected Obj, but got I
		//IL_0333: Expected Obj, but got I
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_0363: Expected Obj, but got I4
		//IL_0230: Expected Obj, but got I
		//IL_0240: Expected Obj, but got I
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0268: Expected Obj, but got I4
		//IL_0029: Expected Obj, but got I
		//IL_0381: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_00a0: Expected Obj, but got I4
		//IL_0286: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02be: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I
		//IL_03c7: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_013b: Expected Obj, but got I4
		//IL_02dc: Expected Obj, but got I
		//IL_02ec: Expected Obj, but got I
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_0314: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I
		//IL_040d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedList`1<T>)+C]");
		if ((nint)0 < (nint)1)
		{
			goto IL_01d4;
		}
		nint num = 1;
		IntPtr intPtr = default;
		object obj11 = default;
		IntPtr intPtr2 = default;
		object obj22 = default;
		IntPtr intPtr3 = default;
		object obj33 = default;
		int result;
		while (true)
		{
			object obj = (nint)0 + (nint)309;
			object obj2 = obj;
			object obj3 = obj & 1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj5 = (nint)0 + (nint)309;
				obj2 = obj5;
				nint num2 = 0;
			}
			else
			{
				nint num3 = 0;
				nint num2 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v7 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X10_v4+60]");
			object obj7 = 0;
			object obj8 = obj2 & 1;
			bool flag2 = obj8 == null;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				nint num2 = intPtr;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v11 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v12+60]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v174 @ X10_v5] (should have been resolved before IL gen)");
			if (num != (nint)obj11)
			{
				object obj12 = (nint)0 + (nint)309;
				object obj13 = obj12;
				object obj14 = obj12 & 1;
				bool flag3 = obj14 == null;
				object obj15 = !flag3;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj16 = (nint)0 + (nint)309;
					obj13 = obj16;
					nint num5 = 0;
				}
				else
				{
					nint num6 = 0;
					nint num5 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v12 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X10_v7+A8]");
				object obj18 = 0;
				object obj19 = obj13 & 1;
				bool flag4 = obj19 == null;
				object obj20 = !flag4;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					nint num5 = intPtr2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v17 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v18+A8]");
				num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v204 @ X10_v8] (should have been resolved before IL gen)");
				if (num != (nint)obj22)
				{
					object obj23 = (nint)0 + (nint)309;
					object obj24 = obj23;
					object obj25 = obj23 & 1;
					bool flag5 = obj25 == null;
					object obj26 = !flag5;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						object obj27 = (nint)0 + (nint)309;
						obj24 = obj27;
						nint num7 = 0;
					}
					else
					{
						nint num8 = 0;
						nint num7 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v16 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X10_v9+70]");
					object obj29 = 0;
					object obj30 = obj24 & 1;
					bool flag6 = obj30 == null;
					object obj31 = !flag6;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						nint num7 = intPtr3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v21 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
					object obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v132 @ X10_v10] (should have been resolved before IL gen)");
					bool flag7 = obj33 == null;
					num4 = num;
					result = (int)num;
					if (flag7)
					{
						break;
					}
				}
			}
			nint num9 = num + 1;
			nint intPtr4 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedList`1<T>)+C]");
			bool flag8 = intPtr4 < 0;
			num = num9;
			if (flag8)
			{
				continue;
			}
			goto IL_01d4;
		}
		goto IL_0322;
		IL_01d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A48]");
		object error = 0;
		Assert.AlwaysFail((string)error);
		result = 0;
		goto IL_0322;
		IL_0322:
		return result;
	}

	private void RemoveEntry(int entryIndex)
	{
		//IL_05a7: Expected Obj, but got I
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected Obj, but got Unknown
		//IL_05d7: Expected Obj, but got I4
		//IL_05f5: Expected Obj, but got I
		//IL_0605: Expected Obj, but got I
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected Obj, but got Unknown
		//IL_062d: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I
		//IL_0b6a: Expected Obj, but got I
		//IL_0b80: Expected Obj, but got I
		//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b96: Expected Obj, but got Unknown
		//IL_0bb0: Expected Obj, but got I4
		//IL_064b: Expected Obj, but got I
		//IL_065b: Expected Obj, but got I
		//IL_066b: Expected Obj, but got I
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected Obj, but got Unknown
		//IL_0693: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_0bce: Expected Obj, but got I
		//IL_0c52: Expected Obj, but got I4
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Expected I4, but got Unknown
		//IL_0c78: Expected Obj, but got I
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8e: Expected Obj, but got Unknown
		//IL_0ca8: Expected Obj, but got I4
		//IL_06b1: Expected Obj, but got I
		//IL_06c1: Expected Obj, but got I
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected Obj, but got Unknown
		//IL_06e9: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I
		//IL_0cc6: Expected Obj, but got I
		//IL_0cdc: Expected Obj, but got I
		//IL_0ced: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf2: Expected Obj, but got Unknown
		//IL_0d0c: Expected Obj, but got I4
		//IL_0707: Expected Obj, but got I
		//IL_0717: Expected Obj, but got I
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected Obj, but got Unknown
		//IL_073f: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I
		//IL_0d2a: Expected Obj, but got I
		//IL_0d5c: Expected Obj, but got I4
		//IL_0d7e: Expected Obj, but got I
		//IL_0d8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d94: Expected Obj, but got Unknown
		//IL_0dae: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_0185: Expected Obj, but got I4
		//IL_01f0: Expected Obj, but got I
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_0220: Expected Obj, but got I4
		//IL_0826: Expected Obj, but got I
		//IL_0836: Expected Obj, but got I
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0844: Expected Obj, but got Unknown
		//IL_085e: Expected Obj, but got I4
		//IL_0295: Expected Obj, but got I
		//IL_077a: Expected Obj, but got I
		//IL_078a: Expected Obj, but got I
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected Obj, but got Unknown
		//IL_07b2: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got I
		//IL_0e5c: Expected Obj, but got I
		//IL_07d0: Expected Obj, but got I
		//IL_07e0: Expected Obj, but got I
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected Obj, but got Unknown
		//IL_0808: Expected Obj, but got I4
		//IL_0244: Expected Obj, but got I
		//IL_0dcc: Expected Obj, but got I
		//IL_0ddc: Expected Obj, but got I
		//IL_0def: Expected Obj, but got I4
		//IL_0878: Expected Obj, but got I
		//IL_0889: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Expected Obj, but got Unknown
		//IL_08a8: Expected Obj, but got I4
		//IL_0e14: Expected Obj, but got I
		//IL_0e24: Expected Obj, but got I
		//IL_0e37: Expected Obj, but got I4
		//IL_02dc: Expected Obj, but got I
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_030c: Expected Obj, but got I4
		//IL_091c: Expected Obj, but got I
		//IL_092c: Expected Obj, but got I
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected Obj, but got Unknown
		//IL_0954: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got I
		//IL_0edc: Expected Obj, but got I
		//IL_08c6: Expected Obj, but got I
		//IL_08d6: Expected Obj, but got I
		//IL_08df: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Expected Obj, but got Unknown
		//IL_08fe: Expected Obj, but got I4
		//IL_0330: Expected Obj, but got I
		//IL_096e: Expected Obj, but got I
		//IL_097f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0984: Expected Obj, but got Unknown
		//IL_099e: Expected Obj, but got I4
		//IL_0ea5: Expected Obj, but got I
		//IL_0eb5: Expected Obj, but got I
		//IL_03c8: Expected Obj, but got I
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_03f8: Expected Obj, but got I4
		//IL_0a12: Expected Obj, but got I
		//IL_0a22: Expected Obj, but got I
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Expected Obj, but got Unknown
		//IL_0a4a: Expected Obj, but got I4
		//IL_046d: Expected Obj, but got I
		//IL_0f5c: Expected Obj, but got I
		//IL_0f72: Expected Obj, but got I
		//IL_0f83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f88: Expected Obj, but got Unknown
		//IL_0fa2: Expected Obj, but got I4
		//IL_09bc: Expected Obj, but got I
		//IL_09cc: Expected Obj, but got I
		//IL_09d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09da: Expected Obj, but got Unknown
		//IL_09f4: Expected Obj, but got I4
		//IL_041c: Expected Obj, but got I
		//IL_0f25: Expected Obj, but got I
		//IL_0f35: Expected Obj, but got I
		//IL_0a68: Expected Obj, but got I
		//IL_0a78: Expected Obj, but got I
		//IL_0a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Expected Obj, but got Unknown
		//IL_0aa0: Expected Obj, but got I4
		//IL_04be: Expected Obj, but got I
		//IL_0fc0: Expected Obj, but got I
		//IL_0fd6: Expected Obj, but got I
		//IL_0fe7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fec: Expected Obj, but got Unknown
		//IL_1006: Expected Obj, but got I4
		//IL_0abe: Expected Obj, but got I
		//IL_0ace: Expected Obj, but got I
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adc: Expected Obj, but got Unknown
		//IL_0af6: Expected Obj, but got I4
		//IL_050f: Expected Obj, but got I
		//IL_1024: Expected Obj, but got I
		//IL_103a: Expected Obj, but got I
		//IL_104b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1050: Expected Obj, but got Unknown
		//IL_106a: Expected Obj, but got I4
		//IL_0b14: Expected Obj, but got I
		//IL_0b24: Expected Obj, but got I
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Expected Obj, but got Unknown
		//IL_0b4c: Expected Obj, but got I4
		//IL_0560: Expected Obj, but got I
		//IL_1088: Expected Obj, but got I
		//IL_1091: Unknown result type (might be due to invalid IL or missing references)
		//IL_1096: Expected Obj, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj;
		object obj3 = obj & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj5 = (nint)0 + (nint)309;
			obj2 = obj5;
			nint num = 0;
		}
		else
		{
			nint num2 = 0;
			nint num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X10_v1+90]");
		object obj7 = 0;
		object obj8 = obj2 & 1;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			nint num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v5 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ X10_v2] (should have been resolved before IL gen)");
		object obj11 = (nint)0 + (nint)309;
		object obj12 = obj11;
		object obj13 = obj11 & 1;
		bool flag3 = obj13 == null;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj15 = (nint)0 + (nint)309;
			obj12 = obj15;
			nint num3 = 0;
		}
		else
		{
			nint num4 = 0;
			nint num3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v6 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X10_v3+30]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A30]");
		object error = 0;
		object obj18 = obj12 & 1;
		bool flag4 = obj18 == null;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			nint num3 = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v9 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v92 @ X10_v4] (should have been resolved before IL gen)");
		object obj22 = default;
		object obj23 = default;
		object obj21 = obj22 - obj23;
		bool flag5 = (nint)obj21 < 0;
		bool flag6 = obj21 == null;
		object obj24 = obj22 ^ obj23;
		object obj25 = obj22 ^ obj21;
		object obj26 = obj24 & obj25;
		bool flag7 = (nint)obj26 < 0;
		bool flag8 = flag5 == flag7;
		object obj27 = !flag8;
		bool condition = (byte)((obj27 | flag6) ? 1 : 0) != 0;
		Assert.Check(condition, (string)error);
		object obj28 = (nint)0 + (nint)309;
		object obj29 = obj28;
		object obj30 = obj28 & 1;
		bool flag9 = obj30 == null;
		object obj31 = !flag9;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj32 = (nint)0 + (nint)309;
			obj29 = obj32;
			nint num5 = 0;
		}
		else
		{
			nint num6 = 0;
			nint num5 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v11 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X10_v5+70]");
		object obj34 = 0;
		object obj35 = obj29 & 1;
		bool flag10 = obj35 == null;
		object obj36 = !flag10;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr3 = default;
			nint num5 = intPtr3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v13 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v138 @ X10_v6] (should have been resolved before IL gen)");
		object obj38 = (nint)0 + (nint)309;
		object obj39 = obj38;
		object obj40 = obj38 & 1;
		bool flag11 = obj40 == null;
		object obj41 = !flag11;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj42 = (nint)0 + (nint)309;
			obj39 = obj42;
			nint num7 = 0;
		}
		else
		{
			nint num8 = 0;
			nint num7 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v15 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X10_v7+70]");
		object obj44 = 0;
		object obj45 = obj39 & 1;
		bool flag12 = obj45 == null;
		object obj46 = !flag12;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr4 = default;
			nint num7 = intPtr4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v17 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v18+70]");
		int num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v171 @ X10_v8] (should have been resolved before IL gen)");
		int num10 = default;
		bool flag13 = num10 == 0;
		object obj48 = 1;
		int num11 = entryIndex;
		int num14 = default;
		if (!flag13)
		{
			object obj49 = (nint)0 + (nint)309;
			object obj50 = obj49;
			object obj51 = obj49 & 1;
			bool flag14 = obj51 == null;
			object obj52 = !flag14;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj53 = (nint)0 + (nint)309;
				obj50 = obj53;
				nint num12 = 0;
			}
			else
			{
				nint num13 = 0;
				nint num12 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v103 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X10_v31+B0]");
			object obj55 = 0;
			object obj56 = obj50 & 1;
			bool flag15 = obj56 == null;
			object obj57 = !flag15;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr5 = default;
				nint num12 = intPtr5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v79 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj58 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v80+B0]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v204 @ X10_v32] (should have been resolved before IL gen)");
			obj48 = 1;
			num11 = num10;
			num9 = num14;
		}
		if (num14 != 0)
		{
			object obj60 = (nint)0 + (nint)309;
			object obj61 = obj60;
			object obj62 = obj60 & 1;
			bool flag16 = obj62 == null;
			object obj63 = !flag16;
			if (obj63 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj64 = (nint)0 + (nint)309;
				obj61 = obj64;
				nint num15 = 0;
			}
			else
			{
				nint num16 = 0;
				nint num15 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v94 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X10_v29+B0]");
			object obj66 = 0;
			object obj67 = obj61 & 1;
			bool flag17 = obj67 == null;
			object obj68 = !flag17;
			if (obj68 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr6 = default;
				nint num15 = intPtr6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v73 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj69 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v74+B0]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v234 @ X10_v30] (should have been resolved before IL gen)");
			obj48 = 0;
			num11 = num14;
			num9 = num10;
		}
		object obj70 = (nint)0 + (nint)309;
		object obj71 = obj70;
		object obj72 = obj70 & 1;
		bool flag18 = obj72 == null;
		object obj73 = !flag18;
		if (obj73 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj74 = (nint)0 + (nint)309;
			obj71 = obj74;
			nint num17 = 0;
		}
		else
		{
			nint num18 = 0;
			nint num17 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v21 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X10_v11+A8]");
		object obj76 = 0;
		object obj77 = obj71 & 1;
		bool flag19 = obj77 == null;
		object obj78 = !flag19;
		if (obj78 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr7 = default;
			nint num17 = intPtr7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v23 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v24+A8]");
		int num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v286 @ X10_v12] (should have been resolved before IL gen)");
		object obj80 = default;
		if ((nint)obj80 == entryIndex)
		{
			object obj81 = (nint)0 + (nint)309;
			object obj82 = obj81;
			object obj83 = obj81 & 1;
			bool flag20 = obj83 == null;
			object obj84 = !flag20;
			if (obj84 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj85 = (nint)0 + (nint)309;
				obj82 = obj85;
				nint num20 = 0;
			}
			else
			{
				nint num21 = 0;
				nint num20 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v80 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj86 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X10_v27+B8]");
			object obj87 = 0;
			object obj88 = obj82 & 1;
			bool flag21 = obj88 == null;
			object obj89 = !flag21;
			if (obj89 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr8 = default;
				nint num20 = intPtr8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v65 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj90 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v66+B8]");
			obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v329 @ X10_v28] (should have been resolved before IL gen)");
			num19 = num10;
		}
		object obj91 = (nint)0 + (nint)309;
		object obj92 = obj91;
		object obj93 = obj91 & 1;
		bool flag22 = obj93 == null;
		object obj94 = !flag22;
		if (obj94 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj95 = (nint)0 + (nint)309;
			obj92 = obj95;
			nint num22 = 0;
		}
		else
		{
			nint num23 = 0;
			nint num22 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v26 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X10_v14+60]");
		object obj97 = 0;
		object obj98 = obj92 & 1;
		bool flag23 = obj98 == null;
		object obj99 = !flag23;
		if (obj99 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr9 = default;
			nint num22 = intPtr9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v28 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj100 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v29+60]");
		int num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v365 @ X10_v15] (should have been resolved before IL gen)");
		object obj101 = default;
		if ((nint)obj101 == entryIndex)
		{
			object obj102 = (nint)0 + (nint)309;
			object obj103 = obj102;
			object obj104 = obj102 & 1;
			bool flag24 = obj104 == null;
			object obj105 = !flag24;
			if (obj105 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj106 = (nint)0 + (nint)309;
				obj103 = obj106;
				nint num25 = 0;
			}
			else
			{
				nint num26 = 0;
				nint num25 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X0_v66 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj107 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X10_v25+C0]");
			object obj108 = 0;
			object obj109 = obj103 & 1;
			bool flag25 = obj109 == null;
			object obj110 = !flag25;
			if (obj110 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr10 = default;
				nint num25 = intPtr10;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v57 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj111 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v58+C0]");
			obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v408 @ X10_v26] (should have been resolved before IL gen)");
			num24 = num14;
		}
		object obj112 = (nint)0 + (nint)309;
		object obj113 = obj112;
		object obj114 = obj112 & 1;
		bool flag26 = obj114 == null;
		object obj115 = !flag26;
		if (obj115 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj116 = (nint)0 + (nint)309;
			obj113 = obj116;
			nint num27 = 0;
		}
		else
		{
			nint num28 = 0;
			nint num27 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v31 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj117 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X10_v17+B0]");
		object obj118 = 0;
		object obj119 = obj113 & 1;
		bool flag27 = obj119 == null;
		object obj120 = !flag27;
		if (obj120 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr11 = default;
			nint num27 = intPtr11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v33 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj121 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v444 @ X10_v18] (should have been resolved before IL gen)");
		object obj122 = (nint)0 + (nint)309;
		object obj123 = obj122;
		object obj124 = obj122 & 1;
		bool flag28 = obj124 == null;
		object obj125 = !flag28;
		if (obj125 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj126 = (nint)0 + (nint)309;
			obj123 = obj126;
			nint num29 = 0;
		}
		else
		{
			nint num30 = 0;
			nint num29 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X0_v35 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj127 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X10_v19+B0]");
		object obj128 = 0;
		object obj129 = obj123 & 1;
		bool flag29 = obj129 == null;
		object obj130 = !flag29;
		if (obj130 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr12 = default;
			nint num29 = intPtr12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v37 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj131 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v483 @ X10_v20] (should have been resolved before IL gen)");
		object obj132 = (nint)0 + (nint)309;
		object obj133 = obj132;
		object obj134 = obj132 & 1;
		bool flag30 = obj134 == null;
		object obj135 = !flag30;
		if (obj135 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj136 = (nint)0 + (nint)309;
			obj133 = obj136;
			nint num31 = 0;
		}
		else
		{
			nint num32 = 0;
			nint num31 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v39 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj137 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X10_v21+90]");
		object obj138 = 0;
		object obj139 = obj133 & 1;
		bool flag31 = obj139 == null;
		object obj140 = !flag31;
		if (obj140 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr13 = default;
			nint num31 = intPtr13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v41 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj141 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v516 @ X10_v22] (should have been resolved before IL gen)");
		object obj142 = (nint)0 + (nint)309;
		object obj143 = obj142;
		object obj144 = obj142 & 1;
		bool flag32 = obj144 == null;
		object obj145 = !flag32;
		if (obj145 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj146 = (nint)0 + (nint)309;
			obj143 = obj146;
			nint num33 = 0;
		}
		else
		{
			nint num34 = 0;
			nint num33 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v43 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj147 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X10_v23+A0]");
		object obj148 = 0;
		object obj149 = obj143 & 1;
		bool flag33 = obj149 == null;
		object obj150 = !flag33;
		if (obj150 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr14 = default;
			nint num33 = intPtr14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v45 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj151 = 0;
		object obj153 = default;
		object obj152 = obj153 - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v547 @ X10_v24] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private int GetEntryIndexByListIndex(int listIndex)
	{
		//IL_000c: Expected Obj, but got I
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		//IL_01c1: Expected Obj, but got I
		//IL_01d1: Expected Obj, but got I
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_01f9: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I
		//IL_0298: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_01b1: Expected I4, but got Obj
		//IL_00d2: Expected Obj, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I4
		//IL_0217: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_024f: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I
		//IL_0303: Expected Obj, but got I4
		//IL_0313: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj;
		object obj3 = obj & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj5 = (nint)0 + (nint)309;
			obj2 = obj5;
			nint num = 0;
		}
		else
		{
			nint num2 = 0;
			nint num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X10_v1+60]");
		object obj7 = 0;
		object obj8 = obj2 & 1;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			nint num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+60]");
		IndexOutOfRangeException ex = (IndexOutOfRangeException)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ X10_v2] (should have been resolved before IL gen)");
		IndexOutOfRangeException ex2 = default;
		IndexOutOfRangeException ex3;
		if (ex2 != null)
		{
			object obj11 = listIndex + 1;
			object obj13 = default;
			object obj12 = obj13;
			IntPtr intPtr2 = default;
			nint num3 = intPtr2;
			ex3 = ex2;
			IntPtr intPtr3 = default;
			IndexOutOfRangeException ex4 = default;
			object obj24;
			do
			{
				obj11--;
				if ((nint)obj11 != 1)
				{
					object obj14 = (nint)0 + (nint)309;
					object obj15 = obj14;
					object obj16 = obj14 & 1;
					bool flag3 = obj16 == null;
					object obj17 = !flag3;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						object obj18 = (nint)0 + (nint)309;
						obj15 = obj18;
						nint num4 = 0;
					}
					else
					{
						nint num5 = 0;
						nint num4 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v17 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X10_v6+70]");
					object obj20 = 0;
					object obj21 = obj15 & 1;
					bool flag4 = obj21 == null;
					object obj22 = !flag4;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						nint num4 = intPtr3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v10 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v92 @ X10_v7] (should have been resolved before IL gen)");
					bool flag5 = ex4 == null;
					obj24 = !flag5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v11+70]");
					obj12 = 0;
					num3 = 1;
					ex = ex3;
					ex3 = ex4;
					continue;
				}
				return (int)ex3;
			}
			while (obj24 != null);
		}
		int num6 = default;
		string message = num6.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		IndexOutOfRangeException ex5 = default;
		ex5._002Ector(message);
		ex3 = ex5;
		throw new ArgumentNullException();
	}

	[MethodImpl((MethodImplOptions)256)]
	private int EntryOffset(int index)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected I4, but got Unknown
		object obj = index - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedList`1<T>)+8]");
		object obj2 = 0 * obj;
		return 3 + obj2;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe int EntryInt(int entryIndex, int field)
	{
		//IL_0005: Expected Obj, but got Ref
		//IL_0011: Expected Obj, but got I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0041: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2;
		object obj4 = obj2 & 1;
		bool flag = obj4 == null;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj6 = (nint)0 + (nint)309;
			obj3 = obj6;
			nint num = 0;
		}
		else
		{
			nint num2 = 0;
			nint num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X10_v1+C8]");
		object obj8 = 0;
		object obj9 = obj3 & 1;
		bool flag2 = obj9 == null;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			nint num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ X10_v2] (should have been resolved before IL gen)");
		object obj13 = default;
		object obj12 = obj13 + field;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X23_v1+v65 @ X8_v5*4]");
		return 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe void SetEntryInt(int entryIndex, int field, int value)
	{
		//IL_0005: Expected Obj, but got Ref
		//IL_0011: Expected Obj, but got I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0041: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2;
		object obj4 = obj2 & 1;
		bool flag = obj4 == null;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj6 = (nint)0 + (nint)309;
			obj3 = obj6;
			nint num = 0;
		}
		else
		{
			nint num2 = 0;
			nint num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X10_v1+C8]");
		object obj8 = 0;
		object obj9 = obj3 & 1;
		bool flag2 = obj9 == null;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			nint num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v3 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ X10_v2] (should have been resolved before IL gen)");
		object obj13 = default;
		object obj12 = obj13 + field;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe T ReadElement(int entryIndex)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0025: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I
		//IL_0301: Expected Obj, but got I
		//IL_0311: Expected Obj, but got I
		//IL_0327: Expected Obj, but got I
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_036e: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_038c: Expected Obj, but got I
		//IL_039c: Expected Obj, but got I
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Obj, but got Unknown
		//IL_03c4: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I
		//IL_04f7: Expected Obj, but got I
		//IL_0507: Expected Obj, but got I
		//IL_013c: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_017a: Expected Obj, but got I4
		//IL_01a7: Expected Obj, but got I
		//IL_01b7: Expected Obj, but got I
		//IL_01cd: Expected Obj, but got I
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01f5: Expected Obj, but got I4
		//IL_03f0: Expected Obj, but got I
		//IL_0447: Expected Obj, but got Ref
		//IL_0455: Expected Obj, but got Ref
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got Unknown
		//IL_047d: Expected Obj, but got I
		//IL_0487: Expected Obj, but got Ref
		//IL_04d1: Expected Obj, but got I
		//IL_04d9: Expected Obj, but got VT
		//IL_0230: Expected Obj, but got I
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected Obj, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X3_v1+20]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X3_v1+20]");
		object obj4 = (nint)0 + (nint)309;
		object obj5 = obj4;
		object obj6 = obj4 & 1;
		bool flag = obj6 == null;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X3_v1+20]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X3_v1+20]");
			object obj8 = (nint)0 + (nint)309;
			obj5 = obj8;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X3_v1+20]");
			object obj9 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+A8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X10_v1+20]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X10_v2+FC]");
		object obj12 = (nint)0 + (nint)15;
		object obj13 = obj12 & 0x1FFFFFFF0L;
		object obj14 = default;
		int num = (ref *(byte*)(&obj14)) - (ref *(byte*)obj13);
		object obj15 = obj5 & 1;
		bool flag2 = obj15 == null;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X3_v1+20]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X3_v1+20]");
			object obj17 = (nint)0 + (nint)309;
			obj5 = obj17;
		}
		else
		{
			object obj18 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v2+A8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X10_v4+C8]");
		object obj20 = 0;
		object obj21 = obj5 & 1;
		bool flag3 = obj21 == null;
		object obj22 = !flag3;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj23 = default;
			obj3 = obj23;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5+A8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+C8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ X10_v5] (should have been resolved before IL gen)");
		int* ptr = _data;
		if (_data != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X3_v1+20]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X3_v1+20]");
			object obj27 = (nint)0 + (nint)309;
			object obj28 = obj27 & 1;
			bool flag4 = obj28 == null;
			object obj29 = !flag4;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v10+A8]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v11+D0]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v11+D0]");
			object obj32 = (nint)0 + (nint)309;
			object obj33 = obj32 & 1;
			bool flag5 = obj33 == null;
			object obj34 = !flag5;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj35 = default;
				obj31 = obj35;
			}
			IntPtr intPtr = (nint)ptr;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v14 (Il2CppClass<System.Int32*>)+12E]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v14 (Il2CppClass<System.Int32*>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0271;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v14 (Il2CppClass<System.Int32*>)+98]");
			object obj37 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X10_v11-8]");
				if (0 == (nint)obj31)
				{
					break;
				}
				obj36--;
				obj37 += 16;
				if ((nint)obj36 != 1)
				{
					continue;
				}
				goto IL_0271;
			}
			object obj38 = (nint)intPtr + obj37;
			object obj39 = obj38 + 312;
			goto IL_0439;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
		NullReferenceException ex = default;
		if (num2 == 0)
		{
			ex = new NullReferenceException();
		}
		goto IL_02e2;
		IL_0271:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0439;
		IL_02e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		T result = default;
		return result;
		IL_0439:
		object obj40 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
		object obj41 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
		object obj42 = ex + 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v12+8]");
		object obj43 = 0;
		object obj44 = (ref System.Runtime.CompilerServices.Unsafe.As<NetworkLinkedList<T>, byte>(ref this)) + (ref *(byte*)obj42);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v296 @ X1_v5+10] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
		bool flag6 = num3 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X10_v2+FC]");
		obj25 = 0;
		T val = default;
		ex = (NullReferenceException)val;
		if (!flag6)
		{
			return val;
		}
		goto IL_02e2;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe void WriteElement(int entryIndex, T value)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0026: Expected Obj, but got I
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0056: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I
		//IL_03a7: Expected Obj, but got I
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected Obj, but got Unknown
		//IL_03c6: Expected Obj, but got Ref
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_03ee: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_040c: Expected Obj, but got I
		//IL_041c: Expected Obj, but got I
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected Obj, but got Unknown
		//IL_0444: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I
		//IL_0686: Expected Obj, but got I
		//IL_06a6: Expected Obj, but got I
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected Obj, but got Unknown
		//IL_06ce: Expected Obj, but got I4
		//IL_0462: Expected Obj, but got I
		//IL_0472: Expected Obj, but got I
		//IL_04a6: Expected Obj, but got I
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected Obj, but got Unknown
		//IL_04d8: Expected VT, but got Ref
		//IL_04f1: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0150: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01d1: Expected Obj, but got I4
		//IL_053d: Expected Obj, but got I
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected Obj, but got Unknown
		//IL_0565: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got I
		//IL_0225: Expected Obj, but got I
		//IL_023f: Expected Obj, but got I8
		//IL_0259: Expected Obj, but got I4
		//IL_0597: Expected Obj, but got I
		//IL_05ee: Expected Obj, but got Ref
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected Obj, but got Unknown
		//IL_0624: Expected VT, but got I
		//IL_062e: Expected Obj, but got Ref
		//IL_028a: Expected Obj, but got I
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected Obj, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		_ = 0;
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3;
		object obj5 = obj3 & 1;
		bool flag = obj5 == null;
		object obj6 = !flag;
		nint num;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj7 = (nint)0 + (nint)309;
			obj4 = obj7;
			num = 0;
		}
		else
		{
			nint num2 = 0;
			num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X10_v1+20]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X10_v2+FC]");
		object obj10 = (nint)0 + (nint)15;
		object obj11 = obj10 & 0x1FFFFFFF0L;
		object obj13 = default;
		object obj12 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
		object obj14 = obj4 & 1;
		bool flag2 = obj14 == null;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj16 = (nint)0 + (nint)309;
			obj4 = obj16;
			num = 0;
		}
		else
		{
			IntPtr intPtr = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X10_v4+C8]");
		object obj18 = 0;
		object obj19 = obj4 & 1;
		bool flag3 = obj19 == null;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			num = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ X10_v5] (should have been resolved before IL gen)");
		int* ptr = _data;
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22 & 1;
		bool flag4 = obj23 == null;
		object obj24 = !flag4;
		nint num3 = 0;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr3 = default;
			num3 = intPtr3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v8 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+20]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v10+28]");
		bool flag5 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v10+28]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v10+28]");
		object obj27 = num4 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v10+28]");
		object obj28 = 0 & obj27;
		bool flag6 = (nint)obj28 < 0;
		T val = (T)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 48));
		bool flag7 = flag5 == flag6;
		object obj29 = !flag7;
		object obj30 = ~obj29;
		T val2;
		if (obj30 == null)
		{
			val2 = value;
		}
		else
		{
			val2 = val;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		if (_data != null)
		{
			object obj31 = (nint)0 + (nint)309;
			object obj32 = obj31 & 1;
			bool flag8 = obj32 == null;
			object obj33 = !flag8;
			nint num5 = 0;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v13 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v17+D0]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v17+D0]");
			object obj36 = (nint)0 + (nint)309;
			object obj37 = obj36 & 1;
			bool flag9 = obj37 == null;
			object obj38 = !flag9;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj39 = default;
				obj35 = obj39;
			}
			object obj40 = (nint)0 + (nint)309;
			object obj41 = obj40 & 1;
			bool flag10 = obj41 == null;
			object obj42 = !flag10;
			nint num6 = 0;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v16 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v22+20]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v23+28]");
			object obj45 = 0 & 0x80000000L;
			bool flag11 = obj45 == null;
			object obj46 = !flag11;
			if (obj46 == null)
			{
				obj12 = obj12;
			}
			IntPtr intPtr4 = (nint)ptr;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v25 (Il2CppClass<System.Int32*>)+12E]");
			object obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v25 (Il2CppClass<System.Int32*>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02cb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v25 (Il2CppClass<System.Int32*>)+98]");
			object obj48 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X10_v11-8]");
				if (0 == (nint)obj35)
				{
					break;
				}
				obj47--;
				obj48 += 16;
				if ((nint)obj47 != 1)
				{
					continue;
				}
				goto IL_02cb;
			}
			object obj49 = obj48 + 1;
			object obj50 = (nint)intPtr4 + obj49;
			object obj51 = obj50 + 312;
			goto IL_05e0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
		bool flag12 = num7 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X10_v2+FC]");
		int* ptr2 = null;
		if (!flag12)
		{
			NullReferenceException ex = new NullReferenceException();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X10_v2+FC]");
			ptr2 = null;
		}
		goto IL_0366;
		IL_02cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_05e0;
		IL_05e0:
		object obj52 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
		nint num8 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
		object obj54 = default;
		object obj53 = obj54 + 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v17+8]");
		val2 = (T)0;
		object obj55 = (ref System.Runtime.CompilerServices.Unsafe.As<NetworkLinkedList<T>, byte>(ref this)) + (ref *(byte*)obj53);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v192 @ X1_v3 (T)+10] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ SYSREG+28]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-8]");
		bool flag13 = num9 != 0;
		ptr2 = _data;
		if (!flag13)
		{
			return;
		}
		goto IL_0366;
		IL_0366:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
	}

	public unsafe T[] ToArray()
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0026: Expected Obj, but got I
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0056: Expected Obj, but got I4
		//IL_0510: Expected Obj, but got I
		//IL_0520: Expected Obj, but got I
		//IL_0536: Expected Obj, but got I
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected Obj, but got Unknown
		//IL_0555: Expected Obj, but got Ref
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected Obj, but got Unknown
		//IL_057d: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_059b: Expected Obj, but got I
		//IL_05ab: Expected Obj, but got I
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected Obj, but got Unknown
		//IL_05d3: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I
		//IL_07a1: Expected Obj, but got I
		//IL_07b7: Expected Obj, but got I
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected Obj, but got Unknown
		//IL_07df: Expected Obj, but got I4
		//IL_05f1: Expected Obj, but got I
		//IL_0607: Expected Obj, but got I
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected Obj, but got Unknown
		//IL_0637: Expected Obj, but got I4
		//IL_0655: Expected Obj, but got I
		//IL_0665: Expected Obj, but got I
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected Obj, but got Unknown
		//IL_068d: Expected Obj, but got I4
		//IL_0118: Expected Obj, but got I
		//IL_0803: Expected Obj, but got I
		//IL_0813: Expected Obj, but got I
		//IL_0403: Expected Obj, but got I
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_016f: Expected Obj, but got Ref
		//IL_0197: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I4
		//IL_0753: Expected Obj, but got I
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Expected Obj, but got Unknown
		//IL_0783: Expected Obj, but got I4
		//IL_06ab: Expected Obj, but got I
		//IL_06bb: Expected Obj, but got I
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected Obj, but got Unknown
		//IL_06e3: Expected Obj, but got I4
		//IL_01c3: Expected Obj, but got I
		//IL_084a: Expected Obj, but got I
		//IL_0858: Expected Obj, but got Ref
		//IL_086d: Expected Obj, but got I
		//IL_0895: Expected VT, but got Ref
		//IL_04a4: Expected Obj, but got I
		//IL_0219: Expected Obj, but got I4
		//IL_021e: Expected VT, but got Ref
		//IL_0447: Expected Obj, but got I
		//IL_0234: Expected I, but got Obj
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_026c: Expected Obj, but got I
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_0294: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected Obj, but got Unknown
		//IL_02ee: Expected Obj, but got I4
		//IL_02fe: Expected VT, but got I
		//IL_031c: Expected I, but got Obj
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_034e: Expected Obj, but got I
		//IL_0364: Expected Obj, but got I
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_0394: Expected Obj, but got I4
		//IL_0701: Expected Obj, but got I
		//IL_0711: Expected Obj, but got I
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Expected Obj, but got Unknown
		//IL_0739: Expected Obj, but got I4
		//IL_03b8: Expected Obj, but got I
		//IL_08b3: Expected Obj, but got I
		//IL_08c3: Expected Obj, but got I
		//IL_08e7: Expected Obj, but got I4
		//IL_08f8: Expected VT, but got I4
		//IL_0918: Expected Obj, but got I
		//IL_0921: Expected VT, but got I4
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		_ = 0;
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3;
		object obj5 = obj3 & 1;
		bool flag = obj5 == null;
		object obj6 = !flag;
		nint num;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj7 = (nint)0 + (nint)309;
			obj4 = obj7;
			num = 0;
		}
		else
		{
			nint num2 = 0;
			num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X10_v2+20]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X10_v3+FC]");
		object obj10 = (nint)0 + (nint)15;
		object obj11 = obj10 & 0x1FFFFFFF0L;
		object obj12 = default;
		NullReferenceException ex = (NullReferenceException)((ref *(byte*)(&obj12)) - (ref *(byte*)obj11));
		object obj13 = obj4 & 1;
		bool flag2 = obj13 == null;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj15 = (nint)0 + (nint)309;
			obj4 = obj15;
			num = 0;
		}
		else
		{
			IntPtr intPtr = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X10_v5+90]");
		object obj17 = 0;
		object obj18 = obj4 & 1;
		bool flag3 = obj18 == null;
		object obj19 = !flag3;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			num = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v5 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v84 @ X10_v6] (should have been resolved before IL gen)");
		object obj21 = (nint)0 + (nint)309;
		object obj22 = obj21 & 1;
		bool flag4 = obj22 == null;
		object obj23 = !flag4;
		nint num3 = 0;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr3 = default;
			num3 = intPtr3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v8 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj25 = (nint)0 + (nint)309;
		object obj26 = obj25;
		object obj27 = obj25 & 1;
		bool flag5 = obj27 == null;
		object obj28 = !flag5;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj29 = (nint)0 + (nint)309;
			obj26 = obj29;
			nint num4 = 0;
		}
		else
		{
			nint num5 = 0;
			nint num4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v9 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X10_v7+60]");
		object obj31 = 0;
		object obj32 = obj26 & 1;
		bool flag6 = obj32 == null;
		object obj33 = !flag6;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr4 = default;
			nint num4 = intPtr4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v12 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v13+60]");
		NullReferenceException ex2 = (NullReferenceException)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ X10_v8] (should have been resolved before IL gen)");
		T[] array = default;
		NullReferenceException ex3 = default;
		if (ex3 != null)
		{
			object obj35 = array + 32;
			object obj36 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
			NullReferenceException ex5 = default;
			NullReferenceException ex4 = ex5;
			object obj38 = default;
			object obj37 = obj38;
			NetworkLinkedList<T> networkLinkedList2 = default;
			NetworkLinkedList<T> networkLinkedList = networkLinkedList2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v13+60]");
			NullReferenceException ex6 = (NullReferenceException)0;
			object obj39 = 0;
			NullReferenceException ex7 = ex3;
			IntPtr intPtr5 = default;
			IntPtr intPtr6 = default;
			while (true)
			{
				object obj40 = (nint)0 + (nint)309;
				object obj41 = obj40;
				object obj42 = obj40 & 1;
				bool flag7 = obj42 == null;
				object obj43 = !flag7;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj44 = (nint)0 + (nint)309;
					obj41 = obj44;
					nint num6 = 0;
				}
				else
				{
					nint num7 = 0;
					nint num6 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v18 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj45 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X10_v12+18]");
				object obj46 = 0;
				object obj47 = obj41 & 1;
				bool flag8 = obj47 == null;
				object obj48 = !flag8;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					nint num6 = intPtr5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v21 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
				object obj49 = 0;
				obj38 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v22+18]");
				ex2 = (NullReferenceException)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v267._className (System.String) (should have been resolved before IL gen)");
				bool flag9 = array == null;
				networkLinkedList2 = (NetworkLinkedList<T>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
				if (!flag9)
				{
					bool flag10 = (nint)obj39 < array.Length;
					object obj50 = !flag10;
					networkLinkedList2 = (NetworkLinkedList<T>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
					if (obj50 == null)
					{
						nint num8 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v31 (Il2CppClass<T[]>)+104]");
						object obj51 = 0 * obj39;
						object obj52 = obj35 + obj51;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
						object obj53 = (nint)0 + (nint)309;
						object obj54 = obj53 & 1;
						bool flag11 = obj54 == null;
						object obj55 = !flag11;
						ex3 = (NullReferenceException)0;
						if (obj55 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						}
						object obj56 = obj39 + 1;
						object obj57 = obj56 - 1;
						bool flag12 = (nint)obj57 < array.Length;
						object obj58 = !flag12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X10_v3+FC]");
						networkLinkedList2 = (NetworkLinkedList<T>)0;
						ex2 = ex;
						if (obj58 == null)
						{
							nint num9 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v36 (Il2CppClass<T[]>)+104]");
							object obj59 = 0 * obj39;
							object obj60 = obj35 + obj59;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v13 (System.NullReferenceException)+A8]");
							object obj61 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E0C");
							object obj62 = (nint)0 + (nint)309;
							object obj63 = obj62;
							object obj64 = obj62 & 1;
							bool flag13 = obj64 == null;
							object obj65 = !flag13;
							if (obj65 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
								object obj66 = (nint)0 + (nint)309;
								obj63 = obj66;
								nint num10 = 0;
							}
							else
							{
								nint num11 = 0;
								nint num10 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X0_v32 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
							object obj67 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X10_v14+70]");
							object obj68 = 0;
							object obj69 = obj63 & 1;
							bool flag14 = obj69 == null;
							object obj70 = !flag14;
							if (obj70 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
								nint num10 = intPtr6;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v41 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
							object obj71 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v42+70]");
							obj38 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v199 @ X10_v15] (should have been resolved before IL gen)");
							bool flag15 = ex3 == null;
							object obj72 = !flag15;
							ex5 = ex;
							networkLinkedList2 = (NetworkLinkedList<T>)1;
							ex2 = ex7;
							ex4 = ex;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v42+70]");
							obj37 = 0;
							networkLinkedList = (NetworkLinkedList<T>)1;
							ex6 = ex7;
							obj39 = obj56;
							ex7 = ex3;
							if (obj72 == null)
							{
								break;
							}
							continue;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-28]");
					object obj73 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v29+28]");
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
					bool flag16 = num12 != 0;
					ex5 = ex;
					if (flag16)
					{
						goto IL_04f1;
					}
					IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
					ex3 = (NullReferenceException)(object)ex8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-28]");
				object obj74 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v25+28]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
				bool flag17 = num13 != 0;
				ex5 = ex;
				if (!flag17)
				{
					ex3 = new NullReferenceException();
					ex5 = ex;
				}
				goto IL_04f1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-28]");
		object obj75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v16+28]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		if (num14 == 0)
		{
			return array;
		}
		goto IL_04f1;
		IL_04f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		T[] result = default;
		return result;
	}

	public unsafe Enumerator GetEnumerator()
	{
		//IL_001c: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I
		//IL_0086: Expected VT, but got Ref
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1>)+135]");
		object obj = (nint)0 & (nint)1;
		bool flag = obj == null;
		object obj2 = !flag;
		nint num2 = 0;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B37DA4");
		object obj5 = default;
		object obj4 = obj5;
		_ = 0;
		return (Enumerator)(&obj5);
	}

	public unsafe NetworkLinkedList(byte* data, int capacity, IElementReaderWriter<T> rw)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01a3: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got Ref
		//IL_01e4: Expected VT, but got I
		//IL_0021: Expected Obj, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00ca: Expected Obj, but got I4
		//IL_01f6: Expected I, but got Obj
		//IL_0206: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I4
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_0105: Expected Obj, but got I
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_0190: Expected Obj, but got I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A20]");
		object error = 0;
		object obj = (nint)data & (nint)3;
		bool condition = obj == null;
		Assert.Check(condition, (string)error);
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		obj2 = rw;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		NetworkLinkedList<T> networkLinkedList = (NetworkLinkedList<T>)data;
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3 & 1;
		bool flag = obj4 == null;
		object obj5 = !flag;
		nint num = 0;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v8 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5+D0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5+D0]");
		object obj8 = (nint)0 + (nint)309;
		object obj9 = obj8 & 1;
		bool flag2 = obj9 == null;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj11 = default;
			obj7 = obj11;
		}
		nint num2 = (nint)rw;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v8 (Il2CppClass<Fusion.IElementReaderWriter`1<T>>)+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v8 (Il2CppClass<Fusion.IElementReaderWriter`1<T>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0146;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v8 (Il2CppClass<Fusion.IElementReaderWriter`1<T>>)+98]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X10_v5-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj12--;
			obj13 += 16;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_0146;
		}
		object obj14 = obj13 + 2;
		object obj15 = num2 + obj14;
		object obj16 = obj15 + 312;
		object obj17 = 0;
		goto IL_024f;
		IL_0146:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj17 = 2;
		goto IL_024f;
		IL_024f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v199 @ X0_v10] (should have been resolved before IL gen)");
		object obj19 = default;
		object obj18 = obj19 + 2;
	}

	public unsafe NetworkLinkedList<T> Remap(void* list)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00e3: Expected Obj, but got I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected I4, but got Unknown
		//IL_010c: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_0051: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F99F0]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A00]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A50]");
		object error3 = 0;
		Assert.Check(System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedList`1<T>)+C]");
		bool flag = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedList`1<T>)+C]");
		bool flag2 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedList`1<T>)+C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedList`1<T>)+C]");
		object obj = num ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedList`1<T>)+C]");
		object obj2 = 0 & obj;
		bool flag3 = (nint)obj2 < 0;
		bool flag4 = flag == flag3;
		object obj3 = !flag2;
		bool condition = (byte)((flag4 & obj3) ? 1 : 0) != 0;
		Assert.Check(condition, (string)error2);
		Assert.Check((object)_data, (string)error3);
		object obj4 = (object)list;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedList`1<T>)+8]");
		_ = 0;
		return (NetworkLinkedList<T>)_data;
	}

	private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
	{
		//IL_001c: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1>)+135]");
		object obj = (nint)0 & (nint)1;
		bool flag = obj == null;
		object obj2 = !flag;
		nint num2 = 0;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B37DA4");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v4 (Il2CppClass<Fusion.NetworkLinkedList`1>)+135]");
		object obj4 = (nint)0 & (nint)1;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		nint num4 = 0;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		IEnumerator<T> result = default;
		return result;
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		//IL_001c: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I4
		//IL_02db: Expected Obj, but got I
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		//IL_0319: Expected Obj, but got I4
		//IL_042c: Expected Obj, but got I
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_0454: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got I4
		//IL_0337: Expected Obj, but got I
		//IL_038c: Expected Obj, but got I
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_03bc: Expected Obj, but got I4
		//IL_0191: Expected Obj, but got I
		//IL_03da: Expected Obj, but got I
		//IL_03ea: Expected Obj, but got I
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected Obj, but got Unknown
		//IL_0412: Expected Obj, but got I4
		//IL_0217: Expected Obj, but got I
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_0478: Expected Obj, but got I
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected Obj, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_04b6: Expected Obj, but got I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1>)+135]");
		object obj = (nint)0 & (nint)1;
		bool flag = obj == null;
		object obj2 = !flag;
		nint num2 = 0;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object obj4 = (nint)0 + (nint)309;
		object obj5 = obj4 & 1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		nint num3 = 0;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num3 = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj7 + 309;
		object obj10 = obj9 & 1;
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj12 = default;
			obj8 = obj12;
		}
		object obj13 = (nint)0 + (nint)309;
		object obj14 = obj13 & 1;
		bool flag4 = obj14 == null;
		object obj15 = !flag4;
		nint num4 = 0;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v8 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v11+118]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v11+118]");
		object obj18 = (nint)0 + (nint)309;
		object obj19 = obj18 & 1;
		bool flag5 = obj19 == null;
		object obj20 = !flag5;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj21 = default;
			obj17 = obj21;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X21_v2+12E]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X21_v2+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01d2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X21_v2+98]");
		object obj23 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X9_v16-8]");
			if (0 == (nint)obj17)
			{
				break;
			}
			obj22--;
			obj23 += 16;
			if ((nint)obj22 != 1)
			{
				continue;
			}
			goto IL_01d2;
		}
		object obj24 = obj8 + obj23;
		object obj25 = obj24 + 312;
		goto IL_0380;
		IL_0380:
		object obj26 = (nint)0 + (nint)309;
		object obj27 = obj26;
		object obj28 = obj26 & 1;
		bool flag6 = obj28 == null;
		object obj29 = !flag6;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj30 = (nint)0 + (nint)309;
			obj27 = obj30;
			nint num5 = 0;
		}
		else
		{
			nint num6 = 0;
			nint num5 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v11 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X10_v2+120]");
		object obj32 = 0;
		object obj33 = obj27 & 1;
		bool flag7 = obj33 == null;
		object obj34 = !flag7;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			nint num5 = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v18 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj35 = 0;
		object obj36 = obj35;
		object obj37 = obj35 + 309;
		object obj38 = obj37 & 1;
		bool flag8 = obj38 == null;
		object obj39 = !flag8;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj40 = default;
			obj36 = obj40;
		}
		object obj42 = default;
		object obj41 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v23+40]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X1_v5+40]");
		if (num7 == 0)
		{
			object obj43 = obj42 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v181 @ X10_v3] (should have been resolved before IL gen)");
			IEnumerator result = default;
			return result;
		}
		return (IEnumerator)new InvalidCastException();
		IL_01d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E914");
		goto IL_0380;
	}

	private unsafe void Fusion_002EINetworkLinkedList_002EAdd(object item)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0021: Expected Obj, but got I
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		//IL_0177: Expected Obj, but got I
		//IL_0187: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got Ref
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I
		//IL_034e: Expected Obj, but got I
		//IL_035e: Expected Obj, but got I
		//IL_0374: Expected Obj, but got I
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_039c: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got I
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_0238: Expected Obj, but got I4
		//IL_0256: Expected Obj, but got I
		//IL_0266: Expected Obj, but got I
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_028e: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I
		//IL_02ac: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02e4: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I
		//IL_03ba: Expected Obj, but got I
		//IL_03ca: Expected Obj, but got I
		//IL_03e4: Expected Obj, but got I8
		//IL_03fe: Expected Obj, but got I4
		//IL_0300: Expected Obj, but got Ref
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
		_ = 0;
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3;
		object obj5 = obj3 & 1;
		bool flag = obj5 == null;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj7 = (nint)0 + (nint)309;
			obj4 = obj7;
			nint num = 0;
		}
		else
		{
			nint num2 = 0;
			nint num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X10_v1+20]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X10_v2+FC]");
		object obj10 = (nint)0 + (nint)15;
		object obj11 = obj10 & 0x1FFFFFFF0L;
		object obj13 = default;
		object obj12 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
		object obj14 = obj4 & 1;
		bool flag2 = obj14 == null;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			nint num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5+20]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5+20]");
		object obj18 = (nint)0 + (nint)309;
		object obj19 = obj18 & 1;
		bool flag3 = obj19 == null;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj21 = default;
			obj17 = obj21;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F98");
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22;
		object obj24 = obj22 & 1;
		bool flag4 = obj24 == null;
		object obj25 = !flag4;
		nint num3;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj26 = (nint)0 + (nint)309;
			obj23 = obj26;
			num3 = 0;
		}
		else
		{
			nint num4 = 0;
			num3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v6 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v6+128]");
		object obj28 = 0;
		object obj29 = obj23 & 1;
		bool flag5 = obj29 == null;
		object obj30 = !flag5;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj31 = (nint)0 + (nint)309;
			obj23 = obj31;
			num3 = 0;
		}
		else
		{
			IntPtr intPtr2 = num3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v7 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X10_v8+128]");
		object obj33 = 0;
		object obj34 = obj23 & 1;
		bool flag6 = obj34 == null;
		object obj35 = !flag6;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr3 = default;
			num3 = intPtr3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v11 (Il2CppClass<Fusion.NetworkLinkedList`1>)+A8]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v12+20]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v13+28]");
		object obj38 = 0 & 0x80000000L;
		bool flag7 = obj38 == null;
		object obj39 = !flag7;
		object obj41 = default;
		object obj40 = obj41;
		if (obj39 == null)
		{
			obj40 = obj41;
		}
		object obj42 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ X20_v2+10] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X29_v1-8]");
		if (num5 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		}
	}
}
