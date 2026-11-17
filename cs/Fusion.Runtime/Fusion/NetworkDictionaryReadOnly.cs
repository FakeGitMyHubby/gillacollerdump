using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

public struct NetworkDictionaryReadOnly<K, V>
{
	private const int INVALID_ENTRY = default(int);

	private const int FREE_OFFSET = default(int);

	private const int FREE_COUNT_OFFSET = default(int);

	private const int USED_COUNT_OFFSET = default(int);

	private unsafe readonly int* _data;

	private readonly int _capacity;

	private readonly int _nxtOffset;

	private readonly int _keyOffset;

	private readonly int _valOffset;

	private readonly int _entryStride;

	private readonly int _bucketsOffset;

	private readonly int _entriesOffset;

	private readonly IElementReaderWriter<K> _keyReaderWriter;

	private readonly IElementReaderWriter<V> _valReaderWriter;

	private readonly EqualityComparer<K> _equalityComparer;

	private unsafe int _free
	{
		get
		{
			//IL_0005: Expected Obj, but got Ref
			//IL_000a: Expected I4, but got Obj
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			return (int)obj;
		}
	}

	private unsafe int _freeCount
	{
		get
		{
			//IL_0005: Expected Obj, but got Ref
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1+4]");
			return 0;
		}
	}

	private unsafe int _usedCount
	{
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
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0068: Expected Obj, but got I
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected Obj, but got Unknown
			//IL_0098: Expected Obj, but got I4
			//IL_00b1: Expected Obj, but got Ref
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected Obj, but got Unknown
			//IL_00d9: Expected Obj, but got I4
			//IL_00f8: Expected Obj, but got I
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Expected I4, but got Unknown
			//IL_002b: Expected Obj, but got I
			//IL_004d: Expected Obj, but got Ref
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F99F0]");
			object error = 0;
			Assert.Check(System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (string)error);
			object obj = (nint)0 + (nint)309;
			object obj2 = obj;
			object obj3 = obj & 1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			nint num = 0;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj5 = (nint)0 + (nint)309;
				obj2 = obj5;
				num = 0;
			}
			object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			object obj7 = obj2 & 1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X9_v2+4]");
			object obj9 = ~(nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X9_v2+8]");
			return 0 + obj9;
		}
	}

	public int Capacity
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionaryReadOnly`2<K, V>)+8]");
			return (int)(-1);
		}
	}

	internal unsafe NetworkDictionaryReadOnly(int* data, int capacity, IElementReaderWriter<K> keyReaderWriter, IElementReaderWriter<V> valReaderWriter)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0382: Expected Obj, but got I
		//IL_0392: Expected Obj, but got I
		//IL_03b4: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00f5: Expected Obj, but got I4
		//IL_03ca: Expected I, but got Obj
		//IL_03da: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I
		//IL_01cb: Expected Obj, but got I
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_01f3: Expected Obj, but got I4
		//IL_0226: Expected Obj, but got I
		//IL_0236: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0274: Expected Obj, but got I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_043a: Expected I, but got Obj
		//IL_044a: Expected Obj, but got I
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_04a7: Expected I4, but got Obj
		//IL_04b1: Expected I4, but got Obj
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected Obj, but got Unknown
		//IL_04c7: Expected VT, but got I
		//IL_04d4: Expected I4, but got Obj
		//IL_0534: Expected Obj, but got I
		//IL_054e: Expected Obj, but got I4
		//IL_02af: Expected Obj, but got I
		//IL_0355: Expected Obj, but got I
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected Obj, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D42A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F99F8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5298]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = Primes.IsPrime(capacity);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F78D0");
		object obj6 = (nint)0 + (nint)309;
		object obj7 = obj6 & 1;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		nint num = 0;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v10 (Il2CppClass<Fusion.NetworkDictionaryReadOnly`2>)+A8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v7+20]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v7+20]");
		object obj11 = (nint)0 + (nint)309;
		object obj12 = obj11 & 1;
		bool flag4 = obj12 == null;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj14 = default;
			obj10 = obj14;
		}
		nint num2 = (nint)keyReaderWriter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v10 (Il2CppClass<Fusion.IElementReaderWriter`1<K>>)+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v10 (Il2CppClass<Fusion.IElementReaderWriter`1<K>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0171;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v10 (Il2CppClass<Fusion.IElementReaderWriter`1<K>>)+98]");
		object obj16 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X10_v12-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj15--;
			obj16 += 16;
			if ((nint)obj15 != 1)
			{
				continue;
			}
			goto IL_0171;
		}
		object obj17 = obj16 + 2;
		object obj18 = num2 + obj17;
		object obj19 = obj18 + 312;
		int num3 = capacity;
		goto IL_0423;
		IL_02f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num3 = 2;
		goto IL_0493;
		IL_0493:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v339 @ X0_v18] (should have been resolved before IL gen)");
		_entryStride = (int)keyReaderWriter;
		_entriesOffset = (int)valReaderWriter;
		object obj21 = default;
		object obj20 = obj21 + 1;
		NetworkDictionaryReadOnly<K, V> networkDictionaryReadOnly = (NetworkDictionaryReadOnly<K, V>)data;
		object obj22 = default;
		int capacity2 = (int)(obj22 + obj20);
		nint num4 = 0;
		_capacity = capacity2;
		int keyOffset = capacity + 3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BE88]");
		_ = 0;
		_nxtOffset = 3;
		_keyOffset = keyOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v21 (Il2CppClass<Fusion.NetworkDictionaryReadOnly`2>)+135]");
		object obj23 = (nint)0 & (nint)1;
		bool flag5 = obj23 == null;
		object obj24 = !flag5;
		nint num5 = 0;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v22 (Il2CppClass<Fusion.NetworkDictionaryReadOnly`2>)+A8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35D8424");
		IElementReaderWriter<K> keyReaderWriter2 = default;
		_keyReaderWriter = keyReaderWriter2;
		return;
		IL_0423:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v256 @ X0_v12] (should have been resolved before IL gen)");
		object obj26 = (nint)0 + (nint)309;
		object obj27 = obj26 & 1;
		bool flag6 = obj27 == null;
		object obj28 = !flag6;
		nint num6 = 0;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v16 (Il2CppClass<Fusion.NetworkDictionaryReadOnly`2>)+A8]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v15+30]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v15+30]");
		object obj31 = (nint)0 + (nint)309;
		object obj32 = obj31 & 1;
		bool flag7 = obj32 == null;
		object obj33 = !flag7;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj34 = default;
			obj30 = obj34;
		}
		nint num7 = (nint)valReaderWriter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v18 (Il2CppClass<Fusion.IElementReaderWriter`1<V>>)+12E]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v18 (Il2CppClass<Fusion.IElementReaderWriter`1<V>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02f0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v18 (Il2CppClass<Fusion.IElementReaderWriter`1<V>>)+98]");
		object obj36 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X10_v7-8]");
			if (0 == (nint)obj30)
			{
				break;
			}
			obj35--;
			obj36 += 16;
			if ((nint)obj35 != 1)
			{
				continue;
			}
			goto IL_02f0;
		}
		object obj37 = obj36 + 2;
		object obj38 = num7 + obj37;
		object obj39 = obj38 + 312;
		goto IL_0493;
		IL_0171:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num3 = 2;
		goto IL_0423;
	}

	public V Get(K key)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00e8: Expected VT, but got Obj
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2 (Il2CppClass<Fusion.NetworkDictionaryReadOnly`2>)+A8]");
		object obj4 = 0;
		object obj5 = key & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F99C90");
		object obj7 = default;
		object obj6 = obj7 & 1;
		V result = default;
		if (obj6 != null)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		KeyNotFoundException ex = default;
		ex._002Ector();
		ArgumentNullException ex2 = new ArgumentNullException();
		return (V)ex2;
	}

	public unsafe bool TryGet(K key, out V value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0137: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00a1: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F99F0]");
		object error = 0;
		Assert.Check(System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (string)error);
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v4 (Il2CppClass<Fusion.NetworkDictionaryReadOnly`2>)+A8]");
		object obj4 = 0;
		object obj5 = key & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F99D6C");
		object obj6 = default;
		object obj11;
		if (obj6 != null)
		{
			object obj7 = (nint)0 + (nint)309;
			object obj8 = obj7 & 1;
			bool flag2 = obj8 == null;
			object obj9 = !flag2;
			nint num2 = 0;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v10 (Il2CppClass<Fusion.NetworkDictionaryReadOnly`2>)+A8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB27AC");
			object obj12 = default;
			obj11 = obj12;
		}
		else
		{
			obj11 = 0;
		}
		bool flag3 = obj6 == null;
		ref V reference = ref *(V*)obj11;
		return !flag3;
	}

	private unsafe int Find(K key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_035c: Expected Obj, but got I
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_0399: Expected Obj, but got I4
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected I4, but got Unknown
		//IL_03c0: Expected Obj, but got Ref
		//IL_03e2: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00fb: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I
		//IL_0309: Expected I4, but got Obj
		//IL_01bb: Expected I, but got Obj
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_01ff: Expected Obj, but got I4
		//IL_0221: Expected Obj, but got I
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0249: Expected Obj, but got I4
		//IL_026b: Expected Obj, but got Ref
		//IL_027a: Expected Obj, but got I4
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_02d0: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A00]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj2 = 0;
		string text = (string)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionaryReadOnly`2<K, V>)+8]");
		bool flag = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionaryReadOnly`2<K, V>)+8]");
		bool flag2 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionaryReadOnly`2<K, V>)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionaryReadOnly`2<K, V>)+8]");
		object obj3 = num ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionaryReadOnly`2<K, V>)+8]");
		object obj4 = 0 & obj3;
		bool flag3 = (nint)obj4 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		bool condition = (byte)((flag4 & obj5) ? 1 : 0) != 0;
		Assert.Check(condition, (string)obj);
		object obj6 = obj2;
		object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag6 = obj10 == null;
		object obj11 = !flag6;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionaryReadOnly`2<K, V>)+8]");
		object obj12 = key / 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionaryReadOnly`2<K, V>)+8]");
		object obj13 = obj12 * 0;
		object obj14 = key - obj13;
		object obj15 = obj14 + _nxtOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v3+v87 @ X8_v9*4]");
		int num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v3+v87 @ X8_v9*4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v3+v87 @ X8_v9*4]");
		int result = 0;
		if (!flag7)
		{
			object obj22 = default;
			object obj31;
			string text2 = default;
			do
			{
				IElementReaderWriter<K> keyReaderWriter = _keyReaderWriter;
				object obj17 = (nint)0 + (nint)309;
				object obj18 = obj17 & 1;
				bool flag8 = obj18 == null;
				object obj19 = !flag8;
				nint num3 = 0;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v11 (Il2CppClass<Fusion.NetworkDictionaryReadOnly`2>)+A8]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB2884");
				if (_keyReaderWriter != null)
				{
					nint num4 = (nint)keyReaderWriter;
					obj16 = key & 0xFFFFFFFFL;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v128 @ X8_v15 (Il2CppClass<Fusion.IElementReaderWriter`1<K>>)+1B8] (should have been resolved before IL gen)");
					object obj21 = obj22 & 1;
					bool flag9 = obj21 == null;
					object obj23 = !flag9;
					result = num2;
					if (obj23 != null)
					{
						break;
					}
					object obj24 = (nint)0 + (nint)309;
					object obj25 = obj24 & 1;
					bool flag10 = obj25 == null;
					object obj26 = !flag10;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					}
					object obj27 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
					object obj28 = _capacity * num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionaryReadOnly`2<K, V>)+C]");
					object obj29 = 0 + obj28;
					object obj30 = _keyOffset + obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X10_v3+v106 @ X8_v20*4]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X10_v3+v106 @ X8_v20*4]");
					bool flag11 = (nint)0 == 0;
					obj31 = !flag11;
					text = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X10_v3+v106 @ X8_v20*4]");
					result = 0;
					continue;
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			while (obj31 != null);
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)256)]
	private uint GetBucketFromHashCode(int hash)
	{
		//IL_002a: Expected Obj, but got I
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionaryReadOnly`2<K, V>)+8]");
		int num = (int)((nint)hash / (nint)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionaryReadOnly`2<K, V>)+8]");
		object obj = (nint)num * (nint)0;
		return (uint)(hash - obj);
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe K GetKey(int entry)
	{
		//IL_0197: Expected VT, but got Obj
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_005d: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00de: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I
		//IL_020c: Expected Obj, but got I4
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0234: Expected Obj, but got Ref
		//IL_0119: Expected Obj, but got I
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		int entryStride = _entryStride;
		if (_entryStride != 0)
		{
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (Il2CppClass<Fusion.NetworkDictionaryReadOnly`2>)+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v2+20]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v2+20]");
			object obj6 = (nint)0 + (nint)309;
			object obj7 = obj6 & 1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj9 = default;
				obj5 = obj9;
			}
			int value = ((int*)entryStride)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5 (System.Int32)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5 (System.Int32)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_015a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5 (System.Int32)+98]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v5-8]");
				if (0 == (nint)obj5)
				{
					break;
				}
				obj10--;
				obj11 += 16;
				if ((nint)obj10 != 1)
				{
					continue;
				}
				goto IL_015a;
			}
			object obj12 = value + obj11;
			object obj13 = obj12 + 312;
			goto IL_01fd;
		}
		NullReferenceException ex = new NullReferenceException();
		return (K)ex;
		IL_01fd:
		object obj14 = _capacity * entry;
		object obj15 = _data + obj14;
		object obj16 = _keyOffset + obj15;
		object obj17 = (ref System.Runtime.CompilerServices.Unsafe.As<NetworkDictionaryReadOnly<K, V>, byte>(ref this)) + (ref *(byte*)obj16);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v182 @ X0_v5] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_015a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_01fd;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe V GetVal(int entry)
	{
		//IL_0197: Expected VT, but got Obj
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_005d: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00de: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I
		//IL_020c: Expected Obj, but got I4
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_023a: Expected Obj, but got Ref
		//IL_0119: Expected Obj, but got I
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		int entriesOffset = _entriesOffset;
		if (_entriesOffset != 0)
		{
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (Il2CppClass<Fusion.NetworkDictionaryReadOnly`2>)+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v2+30]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v2+30]");
			object obj6 = (nint)0 + (nint)309;
			object obj7 = obj6 & 1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj9 = default;
				obj5 = obj9;
			}
			int value = ((int*)entriesOffset)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5 (System.Int32)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5 (System.Int32)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_015a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5 (System.Int32)+98]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v5-8]");
				if (0 == (nint)obj5)
				{
					break;
				}
				obj10--;
				obj11 += 16;
				if ((nint)obj10 != 1)
				{
					continue;
				}
				goto IL_015a;
			}
			object obj12 = value + obj11;
			object obj13 = obj12 + 312;
			goto IL_01fd;
		}
		NullReferenceException ex = new NullReferenceException();
		return (V)ex;
		IL_01fd:
		object obj14 = _capacity * entry;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionaryReadOnly`2<K, V>)+14]");
		object obj15 = 0 + obj14;
		object obj16 = _keyOffset + obj15;
		object obj17 = (ref System.Runtime.CompilerServices.Unsafe.As<NetworkDictionaryReadOnly<K, V>, byte>(ref this)) + (ref *(byte*)obj16);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v182 @ X0_v5] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_015a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_01fd;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe int GetNxt(int entry)
	{
		//IL_0005: Expected Obj, but got Ref
		//IL_0014: Expected Obj, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		object obj2 = _capacity * entry;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionaryReadOnly`2<K, V>)+C]");
		object obj3 = 0 + obj2;
		object obj4 = _keyOffset + obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X10_v1+v8 @ X8_v3*4]");
		return 0;
	}
}
