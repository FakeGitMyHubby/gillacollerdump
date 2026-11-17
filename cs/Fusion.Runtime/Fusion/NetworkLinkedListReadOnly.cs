using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

public struct NetworkLinkedListReadOnly<T>
{
	private const int COUNT = default(int);

	private const int HEAD = default(int);

	private const int TAIL = default(int);

	private const int PREV = default(int);

	private const int NEXT = default(int);

	private const int INVALID = default(int);

	private const int OFFSET = default(int);

	public const int ELEMENT_WORDS = default(int);

	public const int META_WORDS = default(int);

	private unsafe int* _data;

	private int _stride;

	private int _capacity;

	private IElementReaderWriter<T> _rw;

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
	}

	public int Capacity
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedListReadOnly`1<T>)+C]");
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
		//IL_038c: Expected Obj, but got I
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X10_v1+30]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X10_v4+18]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v6+28]");
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
		object obj39 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v10+28]");
		object obj40 = 0;
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

	internal unsafe NetworkLinkedListReadOnly(byte* data, int capacity, IElementReaderWriter<T> rw)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I
		//IL_01b9: Expected I, but got Obj
		//IL_01c1: Expected VT, but got I
		//IL_0021: Expected Obj, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I4
		//IL_01d3: Expected I, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I4
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_00f5: Expected Obj, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_0180: Expected Obj, but got I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A20]");
		object error = 0;
		object obj = (nint)data & (nint)3;
		bool condition = obj == null;
		Assert.Check(condition, (string)error);
		_data = (int*)(nint)rw;
		NetworkLinkedListReadOnly<T> networkLinkedListReadOnly = (NetworkLinkedListReadOnly<T>)data;
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		nint num = 0;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = obj5 + 309;
		object obj8 = obj7 & 1;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj10 = default;
			obj6 = obj10;
		}
		nint num2 = (nint)rw;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v8 (Il2CppClass<Fusion.IElementReaderWriter`1<T>>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v8 (Il2CppClass<Fusion.IElementReaderWriter`1<T>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0136;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v8 (Il2CppClass<Fusion.IElementReaderWriter`1<T>>)+98]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X10_v5-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj11--;
			obj12 += 16;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_0136;
		}
		object obj13 = obj12 + 2;
		object obj14 = num2 + obj13;
		object obj15 = obj14 + 312;
		object obj16 = 0;
		goto IL_022c;
		IL_0136:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj16 = 2;
		goto IL_022c;
		IL_022c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v195 @ X0_v7] (should have been resolved before IL gen)");
		object obj18 = default;
		object obj17 = obj18 + 2;
	}

	private unsafe int* GetEntryByListIndex(int listIndex)
	{
		//IL_000c: Expected Obj, but got I
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I
		//IL_01da: Expected Obj, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_0202: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I
		//IL_02c0: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I4
		//IL_01b0: Expected I, but got Obj
		//IL_0272: Expected Obj, but got I
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_02a2: Expected Obj, but got I4
		//IL_0220: Expected Obj, but got I
		//IL_0230: Expected Obj, but got I
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0258: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I
		//IL_0307: Expected Obj, but got I
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_0131: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X10_v1+38]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+38]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ X10_v2] (should have been resolved before IL gen)");
		object obj12 = default;
		if (obj12 != null)
		{
			object obj13 = listIndex + 1;
			IntPtr intPtr2 = default;
			nint num3 = intPtr2;
			object obj14 = obj12;
			IntPtr intPtr3 = default;
			object obj25;
			int* result = default;
			do
			{
				object obj15 = (nint)0 + (nint)309;
				object obj16 = obj15;
				object obj17 = obj15 & 1;
				bool flag3 = obj17 == null;
				object obj18 = !flag3;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj19 = (nint)0 + (nint)309;
					obj16 = obj19;
					nint num4 = 0;
				}
				else
				{
					nint num5 = 0;
					nint num4 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v16 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X10_v6+40]");
				object obj21 = 0;
				object obj22 = obj16 & 1;
				bool flag4 = obj22 == null;
				object obj23 = !flag4;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					nint num4 = intPtr3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v10 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ X10_v7] (should have been resolved before IL gen)");
				obj13--;
				if ((nint)obj13 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v5 (System.Int32*)+4]");
					bool flag5 = (nint)0 == 0;
					obj25 = !flag5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v11+40]");
					num3 = 0;
					obj11 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v5 (System.Int32*)+4]");
					obj14 = 0;
					continue;
				}
				return result;
			}
			while (obj25 != null);
		}
		int num6 = default;
		string message = num6.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		IndexOutOfRangeException ex = default;
		ex._002Ector(message);
		ArgumentNullException ex2 = new ArgumentNullException();
		return (int*)(nint)ex2;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X9_v1+30]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5+30]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v5 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X9_v4+48]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X22_v5 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v9 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X10_v3+60]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v10 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X10_v5+60]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v16 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v17+30]");
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
		//IL_0688: Expected Obj, but got I
		//IL_0698: Expected Obj, but got I
		//IL_06ae: Expected Obj, but got I
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Expected Obj, but got Unknown
		//IL_06cd: Expected Obj, but got Ref
		//IL_06da: Expected Obj, but got Ref
		//IL_06e7: Expected Obj, but got Ref
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected Obj, but got Unknown
		//IL_070f: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		//IL_072d: Expected Obj, but got I
		//IL_073d: Expected Obj, but got I
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected Obj, but got Unknown
		//IL_0765: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I
		//IL_0a2b: Expected Obj, but got I
		//IL_0a3b: Expected Obj, but got I
		//IL_05b0: Expected Obj, but got I
		//IL_05d9: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I
		//IL_012c: Expected VT, but got Ref
		//IL_09dd: Expected Obj, but got I
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f3: Expected Obj, but got Unknown
		//IL_0a0d: Expected Obj, but got I4
		//IL_0783: Expected Obj, but got I
		//IL_0793: Expected Obj, but got I
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Expected Obj, but got Unknown
		//IL_07bb: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I
		//IL_0a6e: Expected Obj, but got I
		//IL_0a84: Expected Obj, but got I
		//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected Obj, but got Unknown
		//IL_0ab4: Expected Obj, but got I4
		//IL_07d9: Expected Obj, but got I
		//IL_07e9: Expected Obj, but got I
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected Obj, but got Unknown
		//IL_0811: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I
		//IL_0ad2: Expected Obj, but got I
		//IL_0af0: Expected Obj, but got I
		//IL_0b1a: Expected Obj, but got I
		//IL_0b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b28: Expected Obj, but got Unknown
		//IL_0b42: Expected Obj, but got I4
		//IL_01f2: Expected Obj, but got I
		//IL_0200: Expected Obj, but got Ref
		//IL_0210: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0281: Expected Obj, but got I4
		//IL_02a8: Expected Obj, but got I
		//IL_05fc: Expected Obj, but got I
		//IL_0635: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02ee: Expected Obj, but got I4
		//IL_0664: Expected Obj, but got I
		//IL_0321: Expected Obj, but got I
		//IL_0331: Expected Obj, but got I
		//IL_0347: Expected Obj, but got I
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_036f: Expected Obj, but got I4
		//IL_0852: Expected Obj, but got I
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Expected Obj, but got Unknown
		//IL_087a: Expected Obj, but got I4
		//IL_03b3: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I
		//IL_03dd: Expected Obj, but got I8
		//IL_03f7: Expected Obj, but got I4
		//IL_089a: Expected Obj, but got I
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Expected Obj, but got Unknown
		//IL_08c2: Expected Obj, but got I4
		//IL_0439: Expected Obj, but got I
		//IL_0449: Expected Obj, but got I
		//IL_0463: Expected Obj, but got I8
		//IL_047d: Expected Obj, but got I4
		//IL_08de: Expected I, but got Obj
		//IL_08ee: Expected Obj, but got I
		//IL_095d: Expected Obj, but got Ref
		//IL_096d: Expected Obj, but got I
		//IL_09bb: Expected Obj, but got I4
		//IL_04b6: Expected Obj, but got I
		//IL_0546: Expected VT, but got I
		//IL_0562: Expected Obj, but got I4
		//IL_058a: Expected Obj, but got I
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected Obj, but got Unknown
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected Obj, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got Unknown
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X10_v1+30]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X10_v2+FC]");
		object obj10 = (nint)0 + (nint)15;
		object obj11 = obj10 & 0x1FFFFFFF0L;
		object obj13 = default;
		object obj12 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
		object obj14 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
		object obj15 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
		object obj16 = obj4 & 1;
		bool flag2 = obj16 == null;
		object obj17 = !flag2;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj18 = (nint)0 + (nint)309;
			obj4 = obj18;
			num = 0;
		}
		else
		{
			IntPtr intPtr = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X10_v6+38]");
		object obj20 = 0;
		object obj21 = obj4 & 1;
		bool flag3 = obj21 == null;
		object obj22 = !flag3;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			num = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v6 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v7+38]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v93 @ X10_v7] (should have been resolved before IL gen)");
		bool flag4 = default;
		if (!flag4)
		{
			goto IL_05a0;
		}
		object obj26 = default;
		object obj25 = obj26;
		nint num3 = default;
		IntPtr intPtr3 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v7+38]");
		object obj27 = 0;
		IEqualityComparer<T> equalityComparer2 = default;
		IEqualityComparer<T> equalityComparer = equalityComparer2;
		bool flag5 = flag4;
		NetworkLinkedListReadOnly<T> networkLinkedListReadOnly = (NetworkLinkedListReadOnly<T>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		IntPtr intPtr4 = default;
		IntPtr intPtr5 = default;
		object obj67 = default;
		while (true)
		{
			object obj28 = (nint)0 + (nint)309;
			object obj29 = obj28;
			object obj30 = obj28 & 1;
			bool flag6 = obj30 == null;
			object obj31 = !flag6;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj32 = (nint)0 + (nint)309;
				obj29 = obj32;
				nint num4 = 0;
			}
			else
			{
				nint num5 = 0;
				nint num4 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v10 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X10_v11+40]");
			object obj34 = 0;
			object obj35 = obj29 & 1;
			bool flag7 = obj35 == null;
			object obj36 = !flag7;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				nint num4 = intPtr4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v15 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v321 @ X10_v12] (should have been resolved before IL gen)");
			object obj38 = (nint)0 + (nint)309;
			object obj39 = obj38;
			object obj40 = obj38 & 1;
			bool flag8 = obj40 == null;
			object obj41 = !flag8;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj42 = (nint)0 + (nint)309;
				obj39 = obj42;
				nint num6 = 0;
			}
			else
			{
				nint num7 = 0;
				nint num6 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v14 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X10_v13+28]");
			object obj44 = 0;
			object obj45 = obj39 & 1;
			bool flag9 = obj45 == null;
			object obj46 = !flag9;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				nint num6 = intPtr5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v19 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
			object obj47 = 0;
			num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v20+28]");
			object obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v362 @ X1_v6+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			object obj49 = (nint)0 + (nint)309;
			object obj50 = obj49 & 1;
			bool flag10 = obj50 == null;
			object obj51 = !flag10;
			nint num8 = 0;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v21 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
			object obj52 = 0;
			object obj53 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v24+30]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v25+28]");
			bool flag11 = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v25+28]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v25+28]");
			object obj55 = num9 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v25+28]");
			object obj56 = 0 & obj55;
			bool flag12 = (nint)obj56 < 0;
			bool flag13 = flag11 == flag12;
			object obj57 = !flag13;
			object obj58 = ~obj57;
			if (obj58 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-30]");
				obj24 = 0;
			}
			else
			{
				obj24 = obj53;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			if (equalityComparer2 == null)
			{
				break;
			}
			object obj59 = (nint)0 + (nint)309;
			object obj60 = obj59 & 1;
			bool flag14 = obj60 == null;
			object obj61 = !flag14;
			nint num10 = 0;
			if (obj61 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v26 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
			object obj62 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v32+68]");
			object obj63 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v32+68]");
			object obj64 = (nint)0 + (nint)309;
			object obj65 = obj64 & 1;
			bool flag15 = obj65 == null;
			object obj66 = !flag15;
			if (obj66 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				obj63 = obj67;
			}
			object obj68 = (nint)0 + (nint)309;
			object obj69 = obj68 & 1;
			bool flag16 = obj69 == null;
			object obj70 = !flag16;
			nint num11 = 0;
			if (obj70 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v29 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
			object obj71 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v37+30]");
			object obj72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v38+28]");
			object obj73 = 0 & 0x80000000L;
			bool flag17 = obj73 == null;
			object obj74 = !flag17;
			object obj75 = obj14;
			if (obj74 == null)
			{
				obj75 = obj14;
			}
			object obj76 = (nint)0 + (nint)309;
			object obj77 = obj76 & 1;
			bool flag18 = obj77 == null;
			object obj78 = !flag18;
			nint num12 = 0;
			if (obj78 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X0_v31 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
			object obj79 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v42+30]");
			object obj80 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v43+28]");
			object obj81 = 0 & 0x80000000L;
			bool flag19 = obj81 == null;
			object obj82 = !flag19;
			object obj83 = obj15;
			if (obj82 == null)
			{
				obj83 = obj15;
			}
			nint num13 = (nint)equalityComparer2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v45 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<T>>)+12E]");
			object obj84 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v45 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_04f7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v45 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<T>>)+98]");
			object obj85 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X10_v19-8]");
				if (0 == (nint)obj63)
				{
					break;
				}
				obj84--;
				obj85 += 16;
				if ((nint)obj84 != 1)
				{
					continue;
				}
				goto IL_04f7;
			}
			object obj86 = num13 + obj85;
			object obj87 = obj86 + 312;
			goto IL_0937;
			IL_0937:
			num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
			obj26 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v32+8]");
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v244 @ X1_v2+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C]");
			bool flag20 = (nint)0 == 0;
			bool flag21 = !flag20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C]");
			bool flag22 = (nint)0 == 0;
			object obj88 = !flag22;
			flag4 = flag21;
			if (obj88 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v13+4]");
				flag5 = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
				networkLinkedListReadOnly = (NetworkLinkedListReadOnly<T>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v13+4]");
				bool flag23 = (byte)(~(nuint)0u) != 0;
				object obj89 = !flag23;
				flag4 = flag21;
				obj25 = obj26;
				intPtr3 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v32+8]");
				obj27 = 0;
				equalityComparer = equalityComparer2;
				if (obj89 != null)
				{
					continue;
				}
			}
			goto IL_05a0;
			IL_04f7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0937;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-40]");
		object obj90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v28+28]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		bool flag24 = num14 != 0;
		obj26 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X10_v2+FC]");
		equalityComparer2 = (IEqualityComparer<T>)0;
		NullReferenceException ex;
		if (!flag24)
		{
			ex = new NullReferenceException();
			obj26 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X10_v2+FC]");
			equalityComparer2 = (IEqualityComparer<T>)0;
		}
		goto IL_0669;
		IL_0669:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result = default;
		return result;
		IL_05a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-40]");
		object obj91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v10+28]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		bool flag25 = num15 != 0;
		ex = (NullReferenceException)flag4;
		if (!flag25)
		{
			return flag4;
		}
		goto IL_0669;
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
		//IL_038c: Expected Obj, but got I
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X10_v1+30]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X10_v4+18]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v6+28]");
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
		object obj39 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v10+28]");
		object obj40 = 0;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X9_v1+30]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5+30]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v5 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X9_v4+48]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X22_v5 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v9 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v10 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v16 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v17+30]");
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
		//IL_0040: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got Ref
		//IL_00df: Expected Obj, but got Ref
		//IL_08c9: Expected Obj, but got I
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Expected Obj, but got Unknown
		//IL_08f9: Expected Obj, but got I4
		//IL_0643: Expected Obj, but got I
		//IL_0653: Expected Obj, but got I
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected Obj, but got Unknown
		//IL_067b: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I
		//IL_0917: Expected Obj, but got I
		//IL_0927: Expected VT, but got I
		//IL_059d: Expected I4, but got I8
		//IL_0a4e: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_017a: Expected Obj, but got I4
		//IL_0699: Expected Obj, but got I
		//IL_06a9: Expected Obj, but got I
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Expected Obj, but got Unknown
		//IL_06d1: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I
		//IL_0960: Expected Obj, but got I
		//IL_0976: Expected Obj, but got I
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Expected Obj, but got Unknown
		//IL_09a6: Expected Obj, but got I4
		//IL_06ef: Expected Obj, but got I
		//IL_06ff: Expected Obj, but got I
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected Obj, but got Unknown
		//IL_0727: Expected Obj, but got I4
		//IL_01ef: Expected Obj, but got I
		//IL_09c4: Expected Obj, but got I
		//IL_09e2: Expected Obj, but got I
		//IL_0a02: Expected Obj, but got I
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a10: Expected Obj, but got Unknown
		//IL_0a2a: Expected Obj, but got I4
		//IL_0249: Expected Obj, but got I
		//IL_0257: Expected VT, but got Ref
		//IL_0267: Expected Obj, but got I
		//IL_029b: Expected Obj, but got I
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_02d8: Expected Obj, but got I4
		//IL_02ff: Expected VT, but got I
		//IL_05b7: Expected Obj, but got I
		//IL_05f0: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_0345: Expected Obj, but got I4
		//IL_061f: Expected Obj, but got I
		//IL_0378: Expected Obj, but got I
		//IL_0388: Expected Obj, but got I
		//IL_039e: Expected Obj, but got I
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected Obj, but got Unknown
		//IL_03c6: Expected Obj, but got I4
		//IL_0768: Expected Obj, but got I
		//IL_0771: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Expected Obj, but got Unknown
		//IL_0790: Expected Obj, but got I4
		//IL_040a: Expected Obj, but got I
		//IL_041a: Expected Obj, but got I
		//IL_0434: Expected Obj, but got I8
		//IL_044e: Expected Obj, but got I4
		//IL_07b0: Expected Obj, but got I
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected Obj, but got Unknown
		//IL_07d8: Expected Obj, but got I4
		//IL_0490: Expected Obj, but got I
		//IL_04a0: Expected Obj, but got I
		//IL_04ba: Expected Obj, but got I8
		//IL_04d4: Expected Obj, but got I4
		//IL_07f4: Expected I, but got Obj
		//IL_0804: Expected Obj, but got I
		//IL_0873: Expected Obj, but got Ref
		//IL_0883: Expected VT, but got I
		//IL_08af: Expected Obj, but got I4
		//IL_050d: Expected Obj, but got I
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected Obj, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected Obj, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v1 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+135]");
		object obj3 = (nint)0 & (nint)1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		nint num2 = 0;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+30]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+FC]");
		object obj7 = (nint)0 + (nint)15;
		object obj8 = obj7 & 0x1FFFFFFF0L;
		object obj10 = default;
		object obj9 = (ref *(byte*)(&obj10)) - (ref *(byte*)obj8);
		object obj11 = (ref *(byte*)(&obj10)) - (ref *(byte*)obj8);
		int num3 = 0;
		IntPtr intPtr = default;
		IntPtr intPtr2 = default;
		IntPtr intPtr3 = default;
		object obj60 = default;
		NullReferenceException ex = default;
		IEqualityComparer<T> equalityComparer2 = default;
		while (true)
		{
			object obj12 = (nint)0 + (nint)309;
			object obj13 = obj12;
			object obj14 = obj12 & 1;
			bool flag2 = obj14 == null;
			object obj15 = !flag2;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj16 = (nint)0 + (nint)309;
				obj13 = obj16;
				nint num4 = 0;
			}
			else
			{
				nint num5 = 0;
				nint num4 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v4 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X10_v2+80]");
			object obj18 = 0;
			object obj19 = obj13 & 1;
			bool flag3 = obj19 == null;
			object obj20 = !flag3;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				nint num4 = intPtr;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v10 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11+80]");
			T val = (T)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v145 @ X10_v3] (should have been resolved before IL gen)");
			nint num10;
			object obj82;
			if (num3 < (nint)ex)
			{
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
					nint num6 = 0;
				}
				else
				{
					nint num7 = 0;
					nint num6 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v12 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X10_v6+18]");
				object obj28 = 0;
				object obj29 = obj23 & 1;
				bool flag5 = obj29 == null;
				object obj30 = !flag5;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					nint num6 = intPtr2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v18 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v223 @ X10_v7] (should have been resolved before IL gen)");
				object obj32 = (nint)0 + (nint)309;
				object obj33 = obj32;
				object obj34 = obj32 & 1;
				bool flag6 = obj34 == null;
				object obj35 = !flag6;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj36 = (nint)0 + (nint)309;
					obj33 = obj36;
					nint num8 = 0;
				}
				else
				{
					nint num9 = 0;
					nint num8 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v16 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X10_v8+28]");
				object obj38 = 0;
				object obj39 = obj33 & 1;
				bool flag7 = obj39 == null;
				object obj40 = !flag7;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					nint num8 = intPtr3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v22 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
				object obj41 = 0;
				num10 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v23+28]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v364 @ X1_v6+10] (should have been resolved before IL gen)");
				object obj43 = (nint)0 + (nint)309;
				object obj44 = obj43 & 1;
				bool flag8 = obj44 == null;
				object obj45 = !flag8;
				nint num11 = 0;
				if (obj45 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v21 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
				object obj46 = 0;
				T val2 = (T)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v27+30]");
				object obj47 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v28+28]");
				bool flag9 = (nint)0 < (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v28+28]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v28+28]");
				object obj48 = num12 ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v28+28]");
				object obj49 = 0 & obj48;
				bool flag10 = (nint)obj49 < 0;
				bool flag11 = flag9 == flag10;
				object obj50 = !flag11;
				object obj51 = ~obj50;
				if (obj51 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-30]");
					val = (T)0;
				}
				else
				{
					val = val2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				if (equalityComparer2 != null)
				{
					object obj52 = (nint)0 + (nint)309;
					object obj53 = obj52 & 1;
					bool flag12 = obj53 == null;
					object obj54 = !flag12;
					nint num13 = 0;
					if (obj54 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v26 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
					object obj55 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v35+68]");
					object obj56 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v35+68]");
					object obj57 = (nint)0 + (nint)309;
					object obj58 = obj57 & 1;
					bool flag13 = obj58 == null;
					object obj59 = !flag13;
					if (obj59 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						obj56 = obj60;
					}
					object obj61 = (nint)0 + (nint)309;
					object obj62 = obj61 & 1;
					bool flag14 = obj62 == null;
					object obj63 = !flag14;
					nint num14 = 0;
					if (obj63 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v29 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
					object obj64 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v40+30]");
					object obj65 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v41+28]");
					object obj66 = 0 & 0x80000000L;
					bool flag15 = obj66 == null;
					object obj67 = !flag15;
					object obj68 = obj9;
					if (obj67 == null)
					{
						obj68 = obj9;
					}
					object obj69 = (nint)0 + (nint)309;
					object obj70 = obj69 & 1;
					bool flag16 = obj70 == null;
					object obj71 = !flag16;
					nint num15 = 0;
					if (obj71 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X0_v31 (Il2CppClass<Fusion.NetworkLinkedListReadOnly`1>)+A8]");
					object obj72 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v45+30]");
					object obj73 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v46+28]");
					object obj74 = 0 & 0x80000000L;
					bool flag17 = obj74 == null;
					object obj75 = !flag17;
					object obj76 = obj11;
					if (obj75 == null)
					{
						obj76 = obj11;
					}
					nint num16 = (nint)equalityComparer2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v48 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<T>>)+12E]");
					object obj77 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v48 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<T>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_054e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v48 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<T>>)+98]");
					object obj78 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X10_v14-8]");
						if (0 == (nint)obj56)
						{
							break;
						}
						obj77--;
						obj78 += 16;
						if ((nint)obj77 != 1)
						{
							continue;
						}
						goto IL_054e;
					}
					object obj79 = num16 + obj78;
					object obj80 = obj79 + 312;
					goto IL_084d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
				object obj81 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v31+28]");
				nint num17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
				bool flag18 = num17 != 0;
				obj82 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+FC]");
				equalityComparer2 = (IEqualityComparer<T>)0;
				if (!flag18)
				{
					ex = new NullReferenceException();
					obj82 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+FC]");
					equalityComparer2 = (IEqualityComparer<T>)0;
				}
				break;
			}
			num3 = -1;
			goto IL_0a3e;
			IL_054e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_084d;
			IL_084d:
			num10 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
			obj82 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v32+8]");
			val = (T)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v85 @ X1_v1 (T)+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C]");
			bool flag19 = (nint)0 == 0;
			object obj83 = !flag19;
			if (obj83 == null)
			{
				num3++;
				continue;
			}
			goto IL_0a3e;
			IL_0a3e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
			object obj84 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v13+28]");
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
			if (num18 != 0)
			{
				break;
			}
			return num3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		int result = default;
		return result;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe int* Entry(int index)
	{
		//IL_00a6: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got Ref
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected I, but got Unknown
		//IL_001a: Expected Obj, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected I4, but got Unknown
		object obj = index - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A28]");
		object error = 0;
		bool condition;
		if (index >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedListReadOnly`1<T>)+C]");
			object obj2 = -index;
			bool flag = (nint)obj2 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedListReadOnly`1<T>)+C]");
			int num = (int)((nint)0 ^ (nint)index);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedListReadOnly`1<T>)+C]");
			object obj3 = 0 ^ obj2;
			int num2 = num & obj3;
			bool flag2 = num2 < 0;
			bool flag3 = flag == flag2;
			condition = flag3;
		}
		else
		{
			condition = false;
		}
		Assert.Check(condition, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkLinkedListReadOnly`1<T>)+8]");
		object obj4 = 0 * obj;
		object obj5 = (ref System.Runtime.CompilerServices.Unsafe.As<NetworkLinkedListReadOnly<T>, byte>(ref this)) + (ref *(byte*)obj4);
		return (int*)(nint)(obj5 + 12);
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe T Read(int* entry)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0025: Expected VT, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0063: Expected Obj, but got I4
		//IL_0068: Expected VT, but got Ref
		//IL_025a: Expected Obj, but got I
		//IL_026a: Expected Obj, but got I
		//IL_0280: Expected Obj, but got I
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_021f: Expected Obj, but got VT
		//IL_009d: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00db: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0146: Expected Obj, but got I4
		//IL_02e6: Expected Obj, but got I
		//IL_033d: Expected Obj, but got Ref
		//IL_034b: Expected Obj, but got Ref
		//IL_0363: Expected Obj, but got I
		//IL_0373: Expected Obj, but got I
		//IL_03b5: Expected Obj, but got VT
		//IL_0181: Expected Obj, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X3_v1+20]");
		NetworkLinkedListReadOnly<T> networkLinkedListReadOnly = (NetworkLinkedListReadOnly<T>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X3_v1+20]");
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3 & 1;
		bool flag = obj4 == null;
		object obj5 = !flag;
		NetworkLinkedListReadOnly<T> networkLinkedListReadOnly2 = (NetworkLinkedListReadOnly<T>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			networkLinkedListReadOnly = networkLinkedListReadOnly2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3 (Fusion.NetworkLinkedListReadOnly`1<T>)+A8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+30]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5+FC]");
		object obj8 = (nint)0 + (nint)15;
		object obj9 = obj8 & 0x1FFFFFFF0L;
		object obj10 = default;
		int* ptr = (int*)((ref *(byte*)(&obj10)) - (ref *(byte*)obj9));
		int* data = _data;
		if (_data != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X3_v1+20]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X3_v1+20]");
			object obj12 = (nint)0 + (nint)309;
			object obj13 = obj12 & 1;
			bool flag2 = obj13 == null;
			object obj14 = !flag2;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v6+A8]");
			object obj15 = 0;
			object obj16 = obj15;
			object obj17 = obj15 + 309;
			object obj18 = obj17 & 1;
			bool flag3 = obj18 == null;
			object obj19 = !flag3;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj20 = default;
				obj16 = obj20;
			}
			IntPtr intPtr = (nint)data;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v14 (Il2CppClass<System.Int32*>)+12E]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v14 (Il2CppClass<System.Int32*>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01c2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v14 (Il2CppClass<System.Int32*>)+98]");
			object obj22 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v6-8]");
				if (0 == (nint)obj16)
				{
					break;
				}
				obj21--;
				obj22 += 16;
				if ((nint)obj21 != 1)
				{
					continue;
				}
				goto IL_01c2;
			}
			object obj23 = (nint)intPtr + obj22;
			object obj24 = obj23 + 312;
			goto IL_032f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
		bool flag4 = num != 0;
		NullReferenceException ex = (NullReferenceException)networkLinkedListReadOnly2;
		if (!flag4)
		{
			ex = new NullReferenceException();
		}
		goto IL_023b;
		IL_01c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_032f;
		IL_023b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		T result = default;
		return result;
		IL_032f:
		object obj25 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
		object obj26 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
		int* ptr2 = default;
		object obj27 = (object)(ptr2 + 2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v8+8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v258 @ X1_v4+10] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
		bool flag5 = num2 != 0;
		T val = default;
		ex = (NullReferenceException)val;
		if (!flag5)
		{
			return val;
		}
		goto IL_023b;
	}
}
