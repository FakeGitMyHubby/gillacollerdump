using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.ProBuilder;

namespace Fusion;

public struct NetworkDictionary<K, V> : Action<ProBuilderMesh>, _0021_00210, Action<object>
{
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public NetworkDictionary<K, V> dict;

		internal KeyValuePair<K, V>[] _003C_002Ector_003Eb__0()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected Obj, but got Unknown
			//IL_0021: Expected Obj, but got I
			//IL_0070: Expected Obj, but got I
			//IL_004e: Expected Obj, but got I
			nint num = 0;
			object obj = this + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Fusion.NetworkDictionary`2+<>c__DisplayClass0_0>)+A8]");
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

	public struct Enumerator : _0021_00210, Action<PressKey>, _0021_00210
	{
		private int _bucket;

		private int _entry;

		private NetworkDictionary<K, V> _dict;

		public KeyValuePair<K, V> Current
		{
			get
			{
				//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b3: Expected Obj, but got Unknown
				//IL_01e8: Expected VT, but got Obj
				//IL_006b: Expected Obj, but got I
				//IL_0085: Expected Obj, but got I4
				//IL_00b8: Expected Obj, but got I
				//IL_00df: Expected Obj, but got I
				//IL_00f9: Expected Obj, but got I4
				//IL_012c: Expected Obj, but got I
				//IL_0142: Expected Obj, but got I
				//IL_014b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0150: Expected Obj, but got Unknown
				//IL_016a: Expected Obj, but got I4
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>+Enumerator<K, V>)+4]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>+Enumerator<K, V>)+4]");
					if ((nint)0 < (nint)_bucket)
					{
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v7 (Il2CppClass<Fusion.NetworkDictionary`2+Enumerator>)+135]");
						object obj = (nint)0 & (nint)1;
						bool flag = obj == null;
						object obj2 = !flag;
						nint num2 = 0;
						if (obj2 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v8 (Il2CppClass<Fusion.NetworkDictionary`2+Enumerator>)+A8]");
						object obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB2B54");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v11 (Il2CppClass<Fusion.NetworkDictionary`2+Enumerator>)+135]");
						object obj4 = (nint)0 & (nint)1;
						bool flag2 = obj4 == null;
						object obj5 = !flag2;
						nint num4 = 0;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v12 (Il2CppClass<Fusion.NetworkDictionary`2+Enumerator>)+A8]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB2A60");
						object obj7 = (nint)0 + (nint)309;
						object obj8 = obj7 & 1;
						bool flag3 = obj8 == null;
						object obj9 = !flag3;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						}
						PlayerRef key = default;
						byte value = default;
						return (KeyValuePair<K, V>)new KeyValuePair<PlayerRef, byte>(key, value);
					}
				}
				object obj10 = typeof(IInputAuthorityLost) + 3248;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				InvalidOperationException ex = default;
				ex._002Ector();
				ArgumentNullException ex2 = new ArgumentNullException();
				return (KeyValuePair<K, V>)ex2;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			get
			{
				//IL_000c: Expected Obj, but got I
				//IL_0015: Unknown result type (might be due to invalid IL or missing references)
				//IL_001a: Expected Obj, but got Unknown
				//IL_0034: Expected Obj, but got I4
				//IL_0086: Expected Obj, but got I
				//IL_009c: Expected Obj, but got I
				//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00aa: Expected Obj, but got Unknown
				//IL_00c4: Expected Obj, but got I4
				//IL_00e8: Expected Obj, but got I
				object obj = (nint)0 + (nint)309;
				object obj2 = obj & 1;
				bool flag = obj2 == null;
				object obj3 = !flag;
				nint num = 0;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr = default;
					num = intPtr;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkDictionary`2+Enumerator>)+A8]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77F00");
				object obj5 = (nint)0 + (nint)309;
				object obj6 = obj5 & 1;
				bool flag2 = obj6 == null;
				object obj7 = !flag2;
				nint num2 = 0;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr2 = default;
					num2 = intPtr2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Fusion.NetworkDictionary`2+Enumerator>)+A8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object result = default;
				return result;
			}
		}

		internal unsafe Enumerator(NetworkDictionary<K, V> dict)
		{
			//IL_002e: Expected Obj, but got Ref
			//IL_0045: Expected VT, but got I8
			_ = dict._entriesOffset;
			_ = dict._keyOffset;
			_ = dict._data;
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 48));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Enumerator enumerator = (Enumerator)4294967295L;
		}

		public unsafe bool MoveNext()
		{
			//IL_0010: Expected Obj, but got I
			//IL_017b: Expected Obj, but got Ref
			//IL_0021: Expected Obj, but got I
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected Obj, but got Unknown
			//IL_0049: Expected Obj, but got I4
			//IL_01a4: Expected VT, but got Obj
			//IL_01b0: Expected Obj, but got I
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected Obj, but got Unknown
			//IL_01d8: Expected Obj, but got I4
			//IL_007c: Expected Obj, but got I
			//IL_008c: Expected Obj, but got I
			//IL_009c: Expected Obj, but got I
			//IL_00b2: Expected Obj, but got I
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Expected Obj, but got Unknown
			//IL_00da: Expected Obj, but got I4
			//IL_0205: Expected Obj, but got I
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Expected Obj, but got Unknown
			//IL_0247: Expected Obj, but got I4
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Expected Obj, but got Unknown
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Expected Obj, but got Unknown
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected Obj, but got Unknown
			//IL_015d: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>+Enumerator<K, V>)+4]");
			object obj = 0;
			while (true)
			{
				if (obj != null)
				{
					object obj2 = (nint)0 + (nint)309;
					object obj3 = obj2 & 1;
					bool flag = obj3 == null;
					object obj4 = !flag;
					nint num = 0;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v10 (Il2CppClass<Fusion.NetworkDictionary`2+Enumerator>)+A8]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>+Enumerator<K, V>)+8]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v12+20]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v13+20]");
					object obj8 = (nint)0 + (nint)309;
					object obj9 = obj8 & 1;
					bool flag2 = obj9 == null;
					object obj10 = !flag2;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>+Enumerator<K, V>)+20]");
					object obj11 = 0 * obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>+Enumerator<K, V>)+28]");
					object obj12 = 0 + obj11;
					object obj13 = obj12 + _entry;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X22_v6+v109 @ X8_v18*4]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X22_v6+v109 @ X8_v18*4]");
					bool flag3 = (nint)0 == 0;
					obj = 0;
					if (flag3)
					{
						continue;
					}
				}
				else
				{
					object obj14 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 1));
					if ((nint)obj14 >= _bucket)
					{
						break;
					}
					Enumerator enumerator = (Enumerator)obj14;
					object obj15 = (nint)0 + (nint)309;
					object obj16 = obj15 & 1;
					bool flag4 = obj16 == null;
					object obj17 = !flag4;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>+Enumerator<K, V>)+8]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>+Enumerator<K, V>)+24]");
					object obj19 = 0 + obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v5+v112 @ X8_v8*4]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X9_v5+v112 @ X8_v8*4]");
					bool flag5 = (nint)0 == 0;
					obj = 0;
					if (flag5)
					{
						continue;
					}
				}
				return true;
			}
			return false;
		}

		public void Reset()
		{
			//IL_000d: Expected VT, but got I8
			Enumerator enumerator = (Enumerator)4294967295L;
		}

		public void Dispose()
		{
			//IL_0021: Expected VT, but got I4
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Enumerator enumerator = (Enumerator)(-1);
		}
	}

	public const int META_WORD_COUNT = default(int);

	private const int FREE_OFFSET = default(int);

	private const int FREE_COUNT_OFFSET = default(int);

	private const int USED_COUNT_OFFSET = default(int);

	private const int INVALID_ENTRY = default(int);

	private unsafe int* _data;

	private int _capacity;

	private int _nxtOffset;

	private int _keyOffset;

	private int _valOffset;

	private int _entryStride;

	private int _bucketsOffset;

	private int _entriesOffset;

	private IElementReaderWriter<K> _keyReaderWriter;

	private IElementReaderWriter<V> _valReaderWriter;

	private EqualityComparer<K> _equalityComparer;

	private unsafe int _free
	{
		get
		{
			//IL_0005: Expected Obj, but got Ref
			//IL_000a: Expected I4, but got Obj
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			return (int)obj;
		}
		set
		{
			//IL_0005: Expected Obj, but got Ref
			//IL_000d: Expected Obj, but got I4
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			obj = value;
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
		set
		{
			//IL_0005: Expected Obj, but got Ref
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
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
		set
		{
			//IL_0005: Expected Obj, but got Ref
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
			return (int)(-1);
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public V get_Item(K key)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj4 = 0;
		object obj5 = key & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B87C");
		V result = default;
		return result;
	}

	public void set_Item(K key, V value)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v2 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj4 = 0;
		object obj5 = key & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B904");
	}

	private unsafe void Init(int capacity, IElementReaderWriter<K> keyReaderWriter, IElementReaderWriter<V> valReaderWriter)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0479: Expected Obj, but got I
		//IL_0489: Expected Obj, but got I
		//IL_04ab: Expected Obj, but got I4
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
		//IL_04c1: Expected I, but got Obj
		//IL_04d1: Expected Obj, but got I
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
		//IL_0531: Expected I, but got Obj
		//IL_0541: Expected Obj, but got I
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_059f: Expected Obj, but got Ref
		//IL_05bc: Expected Obj, but got Ref
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected Obj, but got Unknown
		//IL_0606: Expected Obj, but got I4
		//IL_062a: Expected Obj, but got I
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected Obj, but got Unknown
		//IL_0652: Expected Obj, but got I4
		//IL_02af: Expected Obj, but got I
		//IL_0355: Expected Obj, but got I
		//IL_036a: Expected Obj, but got Ref
		//IL_038d: Expected Obj, but got I
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got Unknown
		//IL_03b5: Expected Obj, but got I4
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected Obj, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_03dd: Expected Obj, but got Ref
		//IL_03f7: Expected Obj, but got I4
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_0411: Expected Obj, but got I
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected Obj, but got Unknown
		//IL_0439: Expected Obj, but got I4
		//IL_0670: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D42A8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F99F8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5298]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v10 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v7+40]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v7+40]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v10 (Il2CppClass<Fusion.IElementReaderWriter`1<K>>)+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v10 (Il2CppClass<Fusion.IElementReaderWriter`1<K>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0171;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v10 (Il2CppClass<Fusion.IElementReaderWriter`1<K>>)+98]");
		object obj16 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X10_v12-8]");
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
		goto IL_051a;
		IL_058a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v334 @ X0_v18] (should have been resolved before IL gen)");
		object obj20 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
		obj20 = keyReaderWriter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj21 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 48));
		obj21 = valReaderWriter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj23 = default;
		object obj22 = obj23 + 1;
		object obj25 = default;
		object obj24 = obj25 + obj22;
		object obj26 = capacity + 3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BE88]");
		_ = 0;
		_ = 3;
		object obj27 = (nint)0 + (nint)309;
		object obj28 = obj27 & 1;
		bool flag5 = obj28 == null;
		object obj29 = !flag5;
		nint num4 = 0;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v27 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35D8424");
		object obj31 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 56));
		object obj32 = default;
		obj31 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj33 = (nint)0 + (nint)309;
		object obj34 = obj33 & 1;
		bool flag6 = obj34 == null;
		object obj35 = !flag6;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj36 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		bool flag7 = obj36 == null;
		object obj37 = !flag7;
		if (obj37 == null)
		{
			object obj38 = (nint)0 + (nint)309;
			object obj39 = obj38 & 1;
			bool flag8 = obj39 == null;
			object obj40 = !flag8;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				obj36 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			}
			obj36 = 1;
		}
		return;
		IL_02f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num3 = 2;
		goto IL_058a;
		IL_051a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v251 @ X0_v12] (should have been resolved before IL gen)");
		object obj41 = (nint)0 + (nint)309;
		object obj42 = obj41 & 1;
		bool flag9 = obj42 == null;
		object obj43 = !flag9;
		nint num5 = 0;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v16 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v15+50]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v15+50]");
		object obj46 = (nint)0 + (nint)309;
		object obj47 = obj46 & 1;
		bool flag10 = obj47 == null;
		object obj48 = !flag10;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj49 = default;
			obj45 = obj49;
		}
		nint num6 = (nint)valReaderWriter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v18 (Il2CppClass<Fusion.IElementReaderWriter`1<V>>)+12E]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v18 (Il2CppClass<Fusion.IElementReaderWriter`1<V>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02f0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v18 (Il2CppClass<Fusion.IElementReaderWriter`1<V>>)+98]");
		object obj51 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X10_v7-8]");
			if (0 == (nint)obj45)
			{
				break;
			}
			obj50--;
			obj51 += 16;
			if ((nint)obj50 != 1)
			{
				continue;
			}
			goto IL_02f0;
		}
		object obj52 = obj51 + 2;
		object obj53 = num6 + obj52;
		object obj54 = obj53 + 312;
		goto IL_058a;
		IL_0171:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num3 = 2;
		goto IL_051a;
	}

	public unsafe void Clear()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01ed: Expected Obj, but got I
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_0215: Expected Obj, but got I4
		//IL_0029: Expected Obj, but got Ref
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0063: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got Ref
		//IL_008e: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got Ref
		//IL_00ed: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I4
		//IL_024c: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F99F0]");
		object error = 0;
		Assert.Check(System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (string)error);
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		_ = 1;
		object obj5 = (nint)0 + (nint)309;
		object obj6 = obj5 & 1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		obj8 = 0;
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj12 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		object obj13 = 109895680;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
		int num = (int)((nint)0 << 2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8E]");
		if ((nint)0 != 0)
		{
			if (num == 0)
			{
				return;
			}
		}
		else
		{
			_ = 1;
			bool flag4 = num == 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				return;
			}
		}
		int num2 = num >> 30;
		nint num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, _nxtOffset));
		bool flag5 = num2 != 0 || num3 == 0;
		bool condition = !flag5;
		Assert.Always(condition, num3, num);
		UnsafeUtility.MemClear((void*)num3, num);
	}

	public bool ContainsKey(K key)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj4 = 0;
		object obj5 = key & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9C3F0");
		object obj6 = default;
		bool flag2 = obj6 == null;
		return !flag2;
	}

	public unsafe bool ContainsValue(V value, IEqualityComparer<V> equalityComparer = null)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I4
		//IL_00a3: Expected VT, but got I4
		//IL_00ab: Expected Obj, but got Ref
		//IL_04cb: Expected Obj, but got I
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected Obj, but got Unknown
		//IL_04f3: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00f5: Expected Obj, but got I4
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		//IL_045c: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I
		//IL_013b: Expected VT, but got I4
		//IL_0143: Expected Obj, but got Ref
		//IL_048f: Expected Obj, but got I
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01d8: Expected Obj, but got I4
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected I4, but got Unknown
		//IL_020b: Expected Obj, but got I
		//IL_0221: Expected Obj, but got I
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0249: Expected Obj, but got I4
		//IL_04bf: Expected I4, but got Obj
		//IL_028f: Expected Obj, but got I
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02b7: Expected Obj, but got I4
		//IL_02ea: Expected Obj, but got I
		//IL_02fa: Expected Obj, but got I
		//IL_0310: Expected Obj, but got I
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0338: Expected Obj, but got I4
		//IL_050f: Expected I, but got Obj
		//IL_051f: Expected Obj, but got I
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected Obj, but got Unknown
		//IL_0373: Expected Obj, but got I
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected Obj, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected Obj, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9CD80");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		bool flag2 = equalityComparer == null;
		object obj5 = !flag2;
		V val = (V)72;
		object obj7 = default;
		object obj6 = (object)(&obj7);
		IEqualityComparer<V> equalityComparer2 = equalityComparer;
		if (obj5 == null)
		{
			object obj8 = (nint)0 + (nint)309;
			object obj9 = obj8 & 1;
			bool flag3 = obj9 == null;
			object obj10 = !flag3;
			nint num2 = 0;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v41 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35FF9AC");
			val = (V)72;
			obj6 = (object)(&obj7);
			IEqualityComparer<V> equalityComparer3 = default;
			equalityComparer2 = equalityComparer3;
		}
		object obj18 = default;
		object obj33 = default;
		bool flag10 = default;
		object obj43 = default;
		object obj45 = default;
		while (true)
		{
			object obj12 = (nint)0 + (nint)309;
			object obj13 = obj12 & 1;
			bool flag4 = obj13 == null;
			object obj14 = !flag4;
			nint num3 = 0;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v9 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77E18");
			object obj16 = (nint)0 + (nint)309;
			object obj17 = obj18 & 1;
			if (obj17 != null)
			{
				object obj19 = obj16 & 1;
				bool flag5 = obj19 == null;
				object obj20 = !flag5;
				nint num4 = 0;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v18 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77F00");
				object obj22 = (nint)0 + (nint)309;
				object obj23 = obj22 & 1;
				bool flag6 = obj23 == null;
				object obj24 = !flag6;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				if (equalityComparer2 == null)
				{
					break;
				}
				object obj25 = (nint)0 + (nint)309;
				object obj26 = obj25 & 1;
				bool flag7 = obj26 == null;
				object obj27 = !flag7;
				nint num5 = 0;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v24 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v17+A8]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v17+A8]");
				object obj30 = (nint)0 + (nint)309;
				object obj31 = obj30 & 1;
				bool flag8 = obj31 == null;
				object obj32 = !flag8;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					obj29 = obj33;
				}
				nint num6 = (nint)equalityComparer2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<V>>)+12E]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<V>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_03f0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEqualityComparer`1<V>>)+98]");
				object obj35 = (nint)0 + (nint)8;
				bool flag9 = flag10;
				object obj37;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X10_v7-8]");
					object obj36 = 0 - obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X10_v7-8]");
					if (0 == (nint)obj29)
					{
						break;
					}
					obj34--;
					obj36 = obj34 - 1;
					bool flag11 = obj36 == null;
					obj37 = obj35 + 16;
					flag10 = (nint)obj34 != 1;
					flag9 = flag10;
					obj35 = obj37;
					if (flag10)
					{
						continue;
					}
					goto IL_03f0;
				}
				object obj38 = num6 + obj35;
				object obj39 = obj38 + 312;
				flag10 = flag9;
				obj37 = obj35;
				goto IL_0584;
			}
			object obj40 = obj16 & 1;
			bool flag12 = obj40 == null;
			object obj41 = !flag12;
			nint num7 = 0;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v15 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B78028");
			goto IL_049e;
			IL_049e:
			return (byte)(obj18 & 1) != 0;
			IL_0584:
			obj6 = obj43 >> 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v296 @ X0_v26] (should have been resolved before IL gen)");
			object obj44 = obj45 & 1;
			bool flag13 = obj44 == null;
			val = value;
			if (flag13)
			{
				continue;
			}
			goto IL_049e;
			IL_03f0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0584;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj4 = 0;
		object obj5 = key & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
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

	public V Set(K key, V value)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00f1: Expected Obj, but got I4
		//IL_0124: Expected Obj, but got I
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0087: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v2 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj4 = 0;
		object obj5 = key & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9C3F0");
		object obj6 = (nint)0 + (nint)309;
		object obj7 = default;
		if (obj7 != null)
		{
			object obj8 = obj6 & 1;
			bool flag2 = obj8 == null;
			object obj9 = !flag2;
			nint num2 = 0;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v11 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB2960");
		}
		else
		{
			object obj11 = obj6 & 1;
			bool flag3 = obj11 == null;
			object obj12 = !flag3;
			nint num3 = 0;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
			object obj13 = 0;
			object obj14 = key & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BFDC");
		}
		return value;
	}

	public unsafe bool Add(K key, V value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_006a: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00ac: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v4 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj4 = 0;
		object obj5 = key & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9C3F0");
		object obj6 = default;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			object obj8 = (nint)0 + (nint)309;
			object obj9 = obj8 & 1;
			bool flag3 = obj9 == null;
			object obj10 = !flag3;
			nint num2 = 0;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v10 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
			object obj11 = 0;
			object obj12 = key & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BFDC");
		}
		return obj6 == null;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v4 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj4 = 0;
		object obj5 = key & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9C3F0");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v10 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB2A60");
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

	public bool Remove(K key)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected I4, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X0_v2 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj4 = 0;
		object obj5 = key & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BBB8");
		object obj6 = default;
		return (byte)(obj6 & 1) != 0;
	}

	public unsafe bool Remove(K key, out V value)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a5f: Expected Obj, but got I
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6d: Expected Obj, but got Unknown
		//IL_0a87: Expected Obj, but got I4
		//IL_0a49: Expected I4, but got Obj
		//IL_005d: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0136: Expected Obj, but got I4
		//IL_0ab8: Expected Obj, but got I
		//IL_0b11: Expected Obj, but got I
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b23: Expected Obj, but got Unknown
		//IL_0b39: Expected Obj, but got I
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4f: Expected Obj, but got Unknown
		//IL_0b69: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I
		//IL_0cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccd: Expected Obj, but got Unknown
		//IL_0cdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce2: Expected Obj, but got Unknown
		//IL_0cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfd: Expected Obj, but got Unknown
		//IL_0d17: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got Ref
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_024b: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_0279: Expected Obj, but got I4
		//IL_0b93: Expected Obj, but got I
		//IL_0b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba1: Expected Obj, but got Unknown
		//IL_0bbb: Expected Obj, but got I4
		//IL_029d: Expected Obj, but got I
		//IL_02ce: Expected I, but got Obj
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_0312: Expected Obj, but got I4
		//IL_049d: Expected Obj, but got I
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected Obj, but got Unknown
		//IL_06fa: Expected Obj, but got I4
		//IL_032c: Expected Obj, but got I
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0354: Expected Obj, but got I4
		//IL_072d: Expected Obj, but got I
		//IL_0732: Expected Obj, but got Ref
		//IL_0742: Expected Obj, but got I
		//IL_0758: Expected Obj, but got I
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected Obj, but got Unknown
		//IL_0780: Expected Obj, but got I4
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected Obj, but got Unknown
		//IL_04e2: Expected Obj, but got I4
		//IL_0387: Expected Obj, but got I
		//IL_038c: Expected Obj, but got Ref
		//IL_039c: Expected Obj, but got I
		//IL_03b2: Expected Obj, but got I
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_03da: Expected Obj, but got I4
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Expected Obj, but got Unknown
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected Obj, but got Unknown
		//IL_07c7: Expected Obj, but got I
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected Obj, but got Unknown
		//IL_07ec: Expected Obj, but got I
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Expected Obj, but got Unknown
		//IL_0814: Expected Obj, but got I4
		//IL_0515: Expected Obj, but got I
		//IL_051a: Expected Obj, but got Ref
		//IL_052a: Expected Obj, but got I
		//IL_0540: Expected Obj, but got I
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected Obj, but got Unknown
		//IL_0568: Expected Obj, but got I4
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected Obj, but got Unknown
		//IL_044c: Expected Obj, but got I4
		//IL_046c: Expected Obj, but got I
		//IL_0836: Expected Obj, but got Ref
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected Obj, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected Obj, but got Unknown
		//IL_05af: Expected Obj, but got I
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected Obj, but got Unknown
		//IL_05d4: Expected Obj, but got I
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected Obj, but got Unknown
		//IL_05fc: Expected Obj, but got I4
		//IL_0bdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be1: Expected Obj, but got Unknown
		//IL_0bf2: Expected Obj, but got I
		//IL_0bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c00: Expected Obj, but got Unknown
		//IL_0c1a: Expected Obj, but got I4
		//IL_062f: Expected Obj, but got I
		//IL_0634: Expected Obj, but got Ref
		//IL_0644: Expected Obj, but got I
		//IL_065a: Expected Obj, but got I
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected Obj, but got Unknown
		//IL_0682: Expected Obj, but got I4
		//IL_0864: Expected Obj, but got I
		//IL_0882: Expected Obj, but got I
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Expected Obj, but got Unknown
		//IL_08b2: Expected Obj, but got I4
		//IL_06af: Expected Obj, but got I
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected Obj, but got Unknown
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected I4, but got Unknown
		//IL_0c33: Expected Obj, but got Ref
		//IL_0c3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c41: Expected Obj, but got Unknown
		//IL_0c5b: Expected Obj, but got I4
		//IL_0d35: Expected Obj, but got I
		//IL_0d45: Expected Obj, but got I
		//IL_0d5b: Expected Obj, but got I
		//IL_0d64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d69: Expected Obj, but got Unknown
		//IL_0d83: Expected Obj, but got I4
		//IL_08dc: Expected Obj, but got I
		//IL_091c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0921: Expected Obj, but got Unknown
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected Obj, but got Unknown
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Expected Obj, but got Unknown
		//IL_0956: Expected Obj, but got I
		//IL_095f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0964: Expected Obj, but got Unknown
		//IL_097e: Expected Obj, but got I4
		//IL_08fe: Expected Obj, but got Ref
		//IL_09a0: Expected Obj, but got Ref
		//IL_09b4: Expected Obj, but got I
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ca: Expected Obj, but got Unknown
		//IL_09e4: Expected Obj, but got I4
		//IL_0c74: Expected Obj, but got Ref
		//IL_0c7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c82: Expected Obj, but got Unknown
		//IL_0c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c90: Expected Obj, but got Unknown
		//IL_0caa: Expected Obj, but got I4
		//IL_0a0e: Expected Obj, but got I
		//IL_0a36: Expected Obj, but got Ref
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
		int entryStride = _entryStride;
		if (_entryStride == 0)
		{
			goto IL_0a3b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v6+138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v7+20]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v7+20]");
		object obj7 = (nint)0 + (nint)309;
		object obj8 = obj7 & 1;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v8+A8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v10+40]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v10+40]");
		object obj12 = (nint)0 + (nint)309;
		object obj13 = obj12 & 1;
		bool flag3 = obj13 == null;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj15 = default;
			obj11 = obj15;
		}
		int value2 = ((int*)entryStride)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v13 (System.Int32)+12E]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v13 (System.Int32)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01b2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v13 (System.Int32)+98]");
		object obj17 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X10_v12-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj16--;
			obj17 += 16;
			if ((nint)obj16 != 1)
			{
				continue;
			}
			goto IL_01b2;
		}
		object obj18 = obj17 + 4;
		object obj19 = value2 + obj18;
		object obj20 = obj19 + 312;
		goto IL_0b01;
		IL_0a3b:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_01b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0b01;
		IL_047a:
		ref V reference = ref *(V*)null;
		return false;
		IL_0b01:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v10+8]");
		object obj21 = 0;
		object obj22 = key & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v249 @ X0_v10] (should have been resolved before IL gen)");
		object obj23 = (nint)0 + (nint)309;
		object obj24 = obj23;
		object obj25 = obj23 & 1;
		bool flag4 = obj25 == null;
		object obj26 = !flag4;
		nint num2 = 0;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj27 = (nint)0 + (nint)309;
			obj24 = obj27;
			num2 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
		object obj29 = default;
		object obj28 = obj29 / 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
		object obj30 = obj28 * 0;
		object obj31 = obj29 - obj30;
		object obj32 = obj24 & 1;
		bool flag5 = obj32 == null;
		object obj33 = !flag5;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj34 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		object obj35 = _nxtOffset + obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X9_v7+v280 @ X8_v19*4]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X9_v7+v280 @ X8_v19*4]");
		if ((nint)0 == 0)
		{
			goto IL_047a;
		}
		object obj37 = 0;
		object obj43 = default;
		object obj58 = default;
		object obj101 = default;
		while (true)
		{
			IElementReaderWriter<K> keyReaderWriter = _keyReaderWriter;
			object obj38 = (nint)0 + (nint)309;
			object obj39 = obj38 & 1;
			bool flag6 = obj39 == null;
			object obj40 = !flag6;
			nint num3 = 0;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v20 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB2B54");
			if (_keyReaderWriter == null)
			{
				break;
			}
			nint num4 = (nint)keyReaderWriter;
			obj21 = key & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v339 @ X8_v25 (Il2CppClass<Fusion.IElementReaderWriter`1<K>>)+1B8] (should have been resolved before IL gen)");
			object obj42 = obj43 & 1;
			bool flag7 = obj42 == null;
			object obj44 = !flag7;
			if (obj44 == null)
			{
				object obj45 = (nint)0 + (nint)309;
				object obj46 = obj45 & 1;
				bool flag8 = obj46 == null;
				object obj47 = !flag8;
				nint num5 = 0;
				if (obj47 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X0_v71 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
				object obj48 = 0;
				object obj49 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v78+160]");
				object obj50 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v79+20]");
				object obj51 = (nint)0 + (nint)309;
				object obj52 = obj51 & 1;
				bool flag9 = obj52 == null;
				object obj53 = !flag9;
				if (obj53 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				object obj54 = _capacity * obj36;
				object obj55 = _keyOffset + obj54;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+C]");
				object obj56 = obj55 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X24_v11+v377 @ X8_v84*4]");
				bool flag10 = (nint)0 == 0;
				object obj57 = !flag10;
				obj37 = obj36;
				obj22 = obj58;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X24_v11+v377 @ X8_v84*4]");
				obj36 = 0;
				if (obj57 != null)
				{
					continue;
				}
				goto IL_047a;
			}
			object obj59 = (nint)0 + (nint)309;
			int num8;
			if (obj37 != null)
			{
				object obj60 = obj59 & 1;
				bool flag11 = obj60 == null;
				object obj61 = !flag11;
				nint num6 = 0;
				if (obj61 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v59 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
				object obj62 = 0;
				object obj63 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v63+160]");
				object obj64 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v64+20]");
				object obj65 = (nint)0 + (nint)309;
				object obj66 = obj65 & 1;
				bool flag12 = obj66 == null;
				object obj67 = !flag12;
				if (obj67 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				object obj68 = _capacity * obj36;
				object obj69 = _keyOffset + obj68;
				object obj70 = (nint)0 + (nint)309;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+C]");
				object obj71 = obj69 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X23_v10+v410 @ X8_v69*4]");
				object obj72 = 0;
				object obj73 = obj70 & 1;
				bool flag13 = obj73 == null;
				object obj74 = !flag13;
				nint num7 = 0;
				if (obj74 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X0_v63 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
				object obj75 = 0;
				object obj76 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v70+170]");
				object obj77 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v71+20]");
				object obj78 = (nint)0 + (nint)309;
				object obj79 = obj78 & 1;
				bool flag14 = obj79 == null;
				object obj80 = !flag14;
				if (obj80 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+C]");
				obj31 = 0;
				object obj81 = _capacity * obj37;
				num8 = _keyOffset + obj81;
			}
			else
			{
				object obj82 = obj59 & 1;
				bool flag15 = obj82 == null;
				object obj83 = !flag15;
				nint num9 = 0;
				if (obj83 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v51 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
				object obj84 = 0;
				object obj85 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v55+160]");
				object obj86 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v56+20]");
				object obj87 = (nint)0 + (nint)309;
				object obj88 = obj87 & 1;
				bool flag16 = obj88 == null;
				object obj89 = !flag16;
				if (obj89 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				object obj90 = _capacity * obj36;
				object obj91 = _keyOffset + obj90;
				object obj92 = (nint)0 + (nint)309;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+C]");
				object obj93 = obj91 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X23_v8+v425 @ X8_v61*4]");
				object obj72 = 0;
				object obj94 = obj92 & 1;
				bool flag17 = obj94 == null;
				object obj95 = !flag17;
				if (obj95 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				object obj76 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
				num8 = _nxtOffset;
			}
			object obj96 = num8 + obj31;
			object obj97 = (nint)0 + (nint)309;
			object obj98 = obj97 & 1;
			bool flag18 = obj98 == null;
			object obj99 = !flag18;
			nint num10 = 0;
			if (obj99 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v28 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
			object obj100 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB2A60");
			reference = ref *(V*)obj101;
			object obj102 = (nint)0 + (nint)309;
			object obj103 = obj102;
			object obj104 = obj102 & 1;
			bool flag19 = obj104 == null;
			object obj105 = !flag19;
			nint num11 = 0;
			if (obj105 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj106 = (nint)0 + (nint)309;
				obj103 = obj106;
				num11 = 0;
			}
			object obj107 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			object obj108 = obj103 & 1;
			bool flag20 = obj108 == null;
			object obj109 = !flag20;
			if (obj109 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				obj107 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v33 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
			object obj110 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v36+170]");
			object obj111 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v37+20]");
			object obj112 = (nint)0 + (nint)309;
			object obj113 = obj112 & 1;
			bool flag21 = obj113 == null;
			object obj114 = !flag21;
			if (obj114 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			object obj115 = _capacity * obj36;
			object obj116 = _keyOffset + obj115;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+C]");
			object obj117 = obj116 + 0;
			object obj118 = (nint)0 + (nint)309;
			object obj119 = obj118 & 1;
			bool flag22 = obj119 == null;
			object obj120 = !flag22;
			if (obj120 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			object obj121 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			obj121 = obj36;
			object obj122 = (nint)0 + (nint)309;
			object obj123 = obj122;
			object obj124 = obj122 & 1;
			bool flag23 = obj124 == null;
			object obj125 = !flag23;
			nint num12 = 0;
			if (obj125 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj126 = (nint)0 + (nint)309;
				obj123 = obj126;
				num12 = 0;
			}
			object obj127 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
			object obj128 = obj127 + 1;
			object obj129 = obj123 & 1;
			bool flag24 = obj129 == null;
			object obj130 = !flag24;
			if (obj130 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				obj127 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
			}
			obj127 = obj128;
			return true;
		}
		goto IL_0a3b;
	}

	private unsafe int Insert(K key, V val)
	{
		//IL_07fe: Expected Obj, but got I
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Expected Obj, but got Unknown
		//IL_0826: Expected Obj, but got I4
		//IL_0019: Expected Obj, but got Ref
		//IL_0025: Expected Obj, but got I
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_0245: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_0296: Expected Obj, but got I
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02be: Expected Obj, but got I4
		//IL_0262: Expected Obj, but got Ref
		//IL_0887: Expected Obj, but got I
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Expected Obj, but got Unknown
		//IL_08c4: Expected Obj, but got I4
		//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d1: Expected I4, but got Unknown
		//IL_08ea: Expected Obj, but got I
		//IL_08fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Expected Obj, but got Unknown
		//IL_091a: Expected Obj, but got I4
		//IL_02e0: Expected Obj, but got Ref
		//IL_02f0: Expected Obj, but got I
		//IL_030d: Expected Obj, but got I
		//IL_0339: Expected Obj, but got I
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Obj, but got Unknown
		//IL_03a4: Expected Obj, but got I
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_03d4: Expected Obj, but got I4
		//IL_0277: Expected Obj, but got I
		//IL_0285: Expected VT, but got Obj
		//IL_0933: Expected Obj, but got Ref
		//IL_093b: Expected I4, but got Obj
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected Obj, but got Unknown
		//IL_0963: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got Ref
		//IL_0a5b: Expected Obj, but got Ref
		//IL_0a63: Expected I4, but got Obj
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Expected Obj, but got Unknown
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7f: Expected Obj, but got Unknown
		//IL_0a99: Expected Obj, but got I4
		//IL_0aa2: Expected Obj, but got I4
		//IL_0c65: Expected Obj, but got I
		//IL_0c75: Expected Obj, but got I
		//IL_0c8b: Expected Obj, but got I
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c99: Expected Obj, but got Unknown
		//IL_0cb3: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I
		//IL_09dd: Expected Obj, but got I
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09eb: Expected Obj, but got Unknown
		//IL_0a05: Expected Obj, but got I4
		//IL_03fe: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0112: Expected Obj, but got I
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_014f: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got Ref
		//IL_0426: Expected Obj, but got Ref
		//IL_042f: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got Ref
		//IL_0181: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01bd: Expected Obj, but got I4
		//IL_07f2: Expected I4, but got Obj
		//IL_097c: Expected Obj, but got Ref
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Expected Obj, but got Unknown
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected Obj, but got Unknown
		//IL_09b2: Expected Obj, but got I4
		//IL_09bb: Expected Obj, but got I4
		//IL_047c: Expected Obj, but got I
		//IL_048c: Expected Obj, but got I
		//IL_049c: Expected Obj, but got I
		//IL_04b2: Expected Obj, but got I
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Obj, but got Unknown
		//IL_04da: Expected Obj, but got I4
		//IL_01e7: Expected Obj, but got I
		//IL_0507: Expected Obj, but got I
		//IL_0517: Expected Obj, but got I
		//IL_052d: Expected Obj, but got I
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected Obj, but got Unknown
		//IL_0555: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got Ref
		//IL_0218: Expected Obj, but got I4
		//IL_0acd: Expected Obj, but got I
		//IL_0b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b28: Expected Obj, but got Unknown
		//IL_0b3e: Expected Obj, but got I
		//IL_0b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b54: Expected Obj, but got Unknown
		//IL_0b6e: Expected Obj, but got I4
		//IL_0590: Expected Obj, but got I
		//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Expected Obj, but got Unknown
		//IL_0ce9: Expected Obj, but got I4
		//IL_0b92: Expected Obj, but got I
		//IL_0b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba4: Expected Obj, but got Unknown
		//IL_0bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb9: Expected Obj, but got Unknown
		//IL_0bcf: Expected Obj, but got I
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdd: Expected Obj, but got Unknown
		//IL_0bf7: Expected Obj, but got I4
		//IL_0624: Expected Obj, but got I
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected Obj, but got Unknown
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected Obj, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected Obj, but got Unknown
		//IL_066d: Expected Obj, but got I
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected Obj, but got Unknown
		//IL_06a5: Expected Obj, but got I
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Expected Obj, but got Unknown
		//IL_06d5: Expected Obj, but got I4
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected Obj, but got Unknown
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected Obj, but got Unknown
		//IL_0c10: Expected Obj, but got Ref
		//IL_0c1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1f: Expected Obj, but got Unknown
		//IL_0c28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2d: Expected Obj, but got Unknown
		//IL_0c47: Expected Obj, but got I4
		//IL_0d07: Expected Obj, but got I
		//IL_0d17: Expected Obj, but got I
		//IL_0d2d: Expected Obj, but got I
		//IL_0d36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3b: Expected Obj, but got Unknown
		//IL_0d55: Expected Obj, but got I4
		//IL_06ff: Expected Obj, but got I
		//IL_0744: Expected Obj, but got I4
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected Obj, but got Unknown
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected Obj, but got Unknown
		//IL_0781: Expected Obj, but got I
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Expected Obj, but got Unknown
		//IL_07a9: Expected Obj, but got I4
		//IL_0721: Expected Obj, but got Ref
		//IL_07cb: Expected Obj, but got Ref
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected Obj, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		object obj5 = (nint)0 + (nint)309;
		int num3;
		object obj38;
		object obj37;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A08]");
			object obj6 = 0;
			object obj7 = obj5 & 1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}
			string text = (string)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v46+4]");
			bool flag3 = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v46+4]");
			bool flag4 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v46+4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v46+4]");
			object obj9 = num ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v46+4]");
			object obj10 = 0 & obj9;
			bool flag5 = (nint)obj10 < 0;
			bool flag6 = flag3 == flag5;
			object obj11 = !flag4;
			bool condition = (byte)((flag6 & obj11) ? 1 : 0) != 0;
			Assert.Check(condition, (string)obj6);
			object obj12 = (nint)0 + (nint)309;
			object obj13 = obj12;
			object obj14 = obj12 & 1;
			bool flag7 = obj14 == null;
			object obj15 = !flag7;
			nint num2 = 0;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj16 = (nint)0 + (nint)309;
				obj13 = obj16;
				num2 = 0;
			}
			object obj17 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			num3 = (int)obj17;
			object obj18 = obj13 & 1;
			bool flag8 = obj18 == null;
			object obj19 = !flag8;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				obj17 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v66 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v67+160]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v68+20]");
			object obj22 = (nint)0 + (nint)309;
			object obj23 = obj22 & 1;
			bool flag9 = obj23 == null;
			object obj24 = !flag9;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			object obj25 = _capacity * num3;
			object obj26 = _keyOffset + obj25;
			object obj27 = (nint)0 + (nint)309;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+C]");
			object obj28 = obj26 + 0;
			object obj29 = obj27 & 1;
			bool flag10 = obj29 == null;
			object obj30 = !flag10;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			object obj31 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X24_v11+v191 @ X8_v73*4]");
			obj31 = 0;
			object obj32 = (nint)0 + (nint)309;
			object obj33 = obj32;
			object obj34 = obj32 & 1;
			bool flag11 = obj34 == null;
			object obj35 = !flag11;
			nint num4 = 0;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj36 = (nint)0 + (nint)309;
				obj33 = obj36;
				num4 = 0;
			}
			obj37 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
			obj38 = obj37 - 1;
			object obj39 = obj33 & 1;
			bool flag12 = obj39 == null;
			object obj40 = !flag12;
			object obj41 = 0;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				obj37 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
				obj41 = 0;
			}
		}
		else
		{
			object obj42 = obj5 & 1;
			bool flag13 = obj42 == null;
			object obj43 = !flag13;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v46+8]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
			bool flag14 = num5 != 0;
			K val2 = key;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A10]");
				object error = 0;
				Assert.AlwaysFail((string)error);
				val2 = (K)null;
			}
			object obj44 = (nint)0 + (nint)309;
			object obj45 = obj44 & 1;
			bool flag15 = obj45 == null;
			object obj46 = !flag15;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			object obj47 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A18]");
			object obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v51+8]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
			object obj49 = num6 - 0;
			bool flag16 = (nint)obj49 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v51+8]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
			object obj50 = num7 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v51+8]");
			object obj51 = 0 ^ obj49;
			object obj52 = obj50 & obj51;
			bool flag17 = (nint)obj52 < 0;
			string text = (string)obj48;
			bool flag18 = flag16 == flag17;
			bool condition2 = !flag18;
			Assert.Check(condition2, (string)obj48);
			object obj53 = (nint)0 + (nint)309;
			object obj54 = obj53;
			object obj55 = obj53 & 1;
			bool flag19 = obj55 == null;
			object obj56 = !flag19;
			nint num8 = 0;
			if (obj56 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj57 = (nint)0 + (nint)309;
				obj54 = obj57;
				num8 = 0;
			}
			obj37 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			num3 = (int)obj37;
			obj38 = obj37 + 1;
			object obj58 = obj54 & 1;
			bool flag20 = obj58 == null;
			object obj59 = !flag20;
			object obj41 = 0;
			if (obj59 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				obj37 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
				obj41 = 0;
			}
		}
		obj37 = obj38;
		object obj60 = (nint)0 + (nint)309;
		object obj61 = obj60 & 1;
		bool flag21 = obj61 == null;
		object obj62 = !flag21;
		nint num9 = 0;
		if (obj62 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		int entryStride = _entryStride;
		if (_entryStride != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v7 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
			object obj63 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v9+138]");
			object obj64 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v10+20]");
			object obj65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v10+20]");
			object obj66 = (nint)0 + (nint)309;
			object obj67 = obj66 & 1;
			bool flag22 = obj67 == null;
			object obj68 = !flag22;
			if (obj68 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v10+A8]");
			object obj69 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v13+40]");
			object obj70 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v13+40]");
			object obj71 = (nint)0 + (nint)309;
			object obj72 = obj71 & 1;
			bool flag23 = obj72 == null;
			object obj73 = !flag23;
			if (obj73 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj74 = default;
				obj70 = obj74;
			}
			int value = ((int*)entryStride)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v16 (System.Int32)+12E]");
			object obj75 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v16 (System.Int32)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_05d1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v16 (System.Int32)+98]");
			object obj76 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X10_v7-8]");
				if (0 == (nint)obj70)
				{
					break;
				}
				obj75--;
				obj76 += 16;
				if ((nint)obj75 != 1)
				{
					continue;
				}
				goto IL_05d1;
			}
			object obj77 = obj76 + 4;
			object obj78 = value + obj77;
			object obj79 = obj78 + 312;
			goto IL_0b16;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_05d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0b16;
		IL_0b16:
		object obj80 = key & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v406 @ X0_v12] (should have been resolved before IL gen)");
		object obj81 = (nint)0 + (nint)309;
		object obj82 = obj81;
		object obj83 = obj81 & 1;
		bool flag24 = obj83 == null;
		object obj84 = !flag24;
		nint num10 = 0;
		if (obj84 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj85 = (nint)0 + (nint)309;
			obj82 = obj85;
			num10 = 0;
		}
		object obj86 = obj82 & 1;
		bool flag25 = obj86 == null;
		object obj87 = !flag25;
		if (obj87 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num10 = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v21 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj88 = 0;
		object obj89 = key & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
		object obj91 = default;
		object obj90 = obj91 / 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB2C48");
		object obj92 = (nint)0 + (nint)309;
		object obj93 = obj92 & 1;
		bool flag26 = obj93 == null;
		object obj94 = !flag26;
		nint num11 = 0;
		if (obj94 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X0_v20 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj95 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
		object obj96 = obj90 * 0;
		object obj97 = obj91 - obj96;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB2960");
		object obj98 = (nint)0 + (nint)309;
		object obj99 = obj98;
		object obj100 = obj98 & 1;
		bool flag27 = obj100 == null;
		object obj101 = !flag27;
		nint num12 = 0;
		if (obj101 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj102 = (nint)0 + (nint)309;
			obj99 = obj102;
			num12 = 0;
		}
		object obj103 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		object obj104 = _nxtOffset + obj97;
		object obj105 = obj99 & 1;
		bool flag28 = obj105 == null;
		object obj106 = !flag28;
		if (obj106 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			obj103 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v25 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj107 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v29+170]");
		object obj108 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v30+20]");
		object obj109 = (nint)0 + (nint)309;
		object obj110 = obj109 & 1;
		bool flag29 = obj110 == null;
		object obj111 = !flag29;
		if (obj111 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj112 = _capacity * num3;
		object obj113 = _keyOffset + obj112;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+C]");
		object obj114 = obj113 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X24_v5+v470 @ X9_v10*4]");
		_ = 0;
		object obj115 = (nint)0 + (nint)309;
		object obj116 = obj115 & 1;
		bool flag30 = obj116 == null;
		object obj117 = !flag30;
		if (obj117 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj118 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		object obj119 = _nxtOffset + obj97;
		return num3;
	}

	private unsafe int Find(K key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_053c: Expected Obj, but got I
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected Obj, but got Unknown
		//IL_0579: Expected Obj, but got I4
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected I4, but got Unknown
		//IL_059f: Expected Obj, but got I
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected Obj, but got Unknown
		//IL_05c7: Expected Obj, but got I4
		//IL_04f1: Expected I4, but got Obj
		//IL_005d: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0136: Expected Obj, but got I4
		//IL_05f8: Expected Obj, but got I
		//IL_0651: Expected Obj, but got I
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected Obj, but got Unknown
		//IL_0679: Expected Obj, but got I
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected Obj, but got Unknown
		//IL_06a9: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected Obj, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected Obj, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected Obj, but got Unknown
		//IL_071c: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got Ref
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_0205: Expected Obj, but got I
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_0296: Expected Obj, but got I
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02be: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I
		//IL_0322: Expected I, but got Obj
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_0366: Expected Obj, but got I4
		//IL_0388: Expected Obj, but got I
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_03b0: Expected Obj, but got I4
		//IL_03e3: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got Ref
		//IL_03f8: Expected Obj, but got I
		//IL_040e: Expected Obj, but got I
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_0436: Expected Obj, but got I4
		//IL_0462: Expected Obj, but got I4
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_04b8: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A00]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
		bool flag = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
		bool flag2 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
		object obj = num ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
		object obj2 = 0 & obj;
		bool flag3 = (nint)obj2 < 0;
		bool flag4 = flag == flag3;
		object obj3 = !flag2;
		bool condition = (byte)((flag4 & obj3) ? 1 : 0) != 0;
		Assert.Check(condition, (string)error);
		object obj4 = (nint)0 + (nint)309;
		object obj5 = obj4 & 1;
		bool flag5 = obj5 == null;
		object obj6 = !flag5;
		nint num2 = 0;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		int entryStride = _entryStride;
		if (_entryStride == 0)
		{
			goto IL_04e3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7+138]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v8+20]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v8+20]");
		object obj10 = (nint)0 + (nint)309;
		object obj11 = obj10 & 1;
		bool flag6 = obj11 == null;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v8+A8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v11+40]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v11+40]");
		object obj15 = (nint)0 + (nint)309;
		object obj16 = obj15 & 1;
		bool flag7 = obj16 == null;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj18 = default;
			obj14 = obj18;
		}
		int value = ((int*)entryStride)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v14 (System.Int32)+12E]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v14 (System.Int32)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01b2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v14 (System.Int32)+98]");
		object obj20 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X10_v7-8]");
			if (0 == (nint)obj14)
			{
				break;
			}
			obj19--;
			obj20 += 16;
			if ((nint)obj19 != 1)
			{
				continue;
			}
			goto IL_01b2;
		}
		object obj21 = obj20 + 4;
		object obj22 = value + obj21;
		object obj23 = obj22 + 312;
		goto IL_0641;
		IL_04e3:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_01b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_0641;
		IL_04de:
		int result;
		return result;
		IL_0641:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v10+8]");
		object obj24 = 0;
		object obj25 = key & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v235 @ X0_v10] (should have been resolved before IL gen)");
		object obj26 = (nint)0 + (nint)309;
		object obj27 = obj26;
		object obj28 = obj26 & 1;
		bool flag8 = obj28 == null;
		object obj29 = !flag8;
		nint num3 = 0;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj30 = (nint)0 + (nint)309;
			obj27 = obj30;
			num3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
		object obj32 = default;
		object obj31 = obj32 / 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
		object obj33 = obj31 * 0;
		object obj34 = obj32 - obj33;
		object obj35 = obj27 & 1;
		bool flag9 = obj35 == null;
		object obj36 = !flag9;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj37 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		object obj38 = _nxtOffset + obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X9_v7+v267 @ X8_v20*4]");
		int num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X9_v7+v267 @ X8_v20*4]");
		bool flag10 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X9_v7+v267 @ X8_v20*4]");
		result = 0;
		if (flag10)
		{
			goto IL_04de;
		}
		object obj44 = default;
		object obj59 = default;
		while (true)
		{
			IElementReaderWriter<K> keyReaderWriter = _keyReaderWriter;
			object obj39 = (nint)0 + (nint)309;
			object obj40 = obj39 & 1;
			bool flag11 = obj40 == null;
			object obj41 = !flag11;
			nint num5 = 0;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v19 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB2B54");
			if (_keyReaderWriter == null)
			{
				break;
			}
			nint num6 = (nint)keyReaderWriter;
			obj24 = key & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v295 @ X8_v26 (Il2CppClass<Fusion.IElementReaderWriter`1<K>>)+1B8] (should have been resolved before IL gen)");
			object obj43 = obj44 & 1;
			bool flag12 = obj43 == null;
			object obj45 = !flag12;
			result = num4;
			if (obj45 == null)
			{
				object obj46 = (nint)0 + (nint)309;
				object obj47 = obj46 & 1;
				bool flag13 = obj47 == null;
				object obj48 = !flag13;
				nint num7 = 0;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v25 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
				object obj49 = 0;
				object obj50 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v29+160]");
				object obj51 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v30+20]");
				object obj52 = (nint)0 + (nint)309;
				object obj53 = obj52 & 1;
				bool flag14 = obj53 == null;
				object obj54 = !flag14;
				if (obj54 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				object obj55 = _capacity * num4;
				object obj56 = _keyOffset + obj55;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+C]");
				object obj57 = obj56 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X23_v7+v281 @ X8_v35*4]");
				num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X23_v7+v281 @ X8_v35*4]");
				bool flag15 = (nint)0 == 0;
				object obj58 = !flag15;
				obj25 = obj59;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X23_v7+v281 @ X8_v35*4]");
				result = 0;
				if (obj58 != null)
				{
					continue;
				}
			}
			goto IL_04de;
		}
		goto IL_04e3;
	}

	[MethodImpl((MethodImplOptions)256)]
	private uint GetBucketFromHashCode(int hash)
	{
		//IL_002a: Expected Obj, but got I
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
		int num = (int)((nint)hash / (nint)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
		object obj = (nint)num * (nint)0;
		return (uint)(hash - obj);
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe int GetBucket(uint bucket)
	{
		//IL_0005: Expected Obj, but got Ref
		//IL_0014: Expected Obj, but got I4
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		object obj2 = _nxtOffset + (int)bucket;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+v3 @ X8_v2*4]");
		return 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe void SetBucket(uint bucket, int value)
	{
		//IL_0005: Expected Obj, but got Ref
		//IL_0014: Expected Obj, but got I4
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		object obj2 = _nxtOffset + (int)bucket;
	}

	[MethodImpl((MethodImplOptions)256)]
	private int EntryOffset(int entry)
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected I4, but got Unknown
		object obj = _capacity * entry;
		return _keyOffset + obj;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe void ClrEntry(int entry)
	{
		//IL_00eb: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0123: Expected I8, but got I4
		int num = _capacity << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8E]");
		if ((nint)0 != 0)
		{
			if (num == 0)
			{
				return;
			}
		}
		else
		{
			_ = 1;
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				return;
			}
		}
		object obj2 = _capacity * entry;
		int num2 = num >> 30;
		object obj3 = _keyOffset + obj2;
		nint num3 = (ref System.Runtime.CompilerServices.Unsafe.As<NetworkDictionary<K, V>, byte>(ref this)) + (ref *(byte*)obj3);
		bool flag2 = num2 != 0 || num3 == 0;
		bool condition = !flag2;
		Assert.Always(condition, num3, num);
		UnsafeUtility.MemClear((void*)num3, num);
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe K GetKey(int entry)
	{
		//IL_0016: Expected Obj, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		//IL_01e8: Expected VT, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00ae: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_012f: Expected Obj, but got I4
		//IL_0205: Expected Obj, but got I
		//IL_025d: Expected Obj, but got I4
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_0285: Expected Obj, but got Ref
		//IL_016a: Expected Obj, but got I
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		int entryStride = _entryStride;
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		if (_entryStride != 0)
		{
			object obj4 = (nint)0 + (nint)309;
			object obj5 = obj4 & 1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			nint num = 0;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+40]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+40]");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj12 = default;
				obj8 = obj12;
			}
			int value = ((int*)entryStride)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v8 (System.Int32)+12E]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v8 (System.Int32)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01ab;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v8 (System.Int32)+98]");
			object obj14 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X10_v5-8]");
				if (0 == (nint)obj8)
				{
					break;
				}
				obj13--;
				obj14 += 16;
				if ((nint)obj13 != 1)
				{
					continue;
				}
				goto IL_01ab;
			}
			object obj15 = value + obj14;
			object obj16 = obj15 + 312;
			goto IL_024e;
		}
		NullReferenceException ex = new NullReferenceException();
		return (K)ex;
		IL_01ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_024e;
		IL_024e:
		object obj17 = _capacity * entry;
		object obj18 = _keyOffset + obj17;
		object obj19 = _data + obj18;
		object obj20 = (ref System.Runtime.CompilerServices.Unsafe.As<NetworkDictionary<K, V>, byte>(ref this)) + (ref *(byte*)obj19);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v191 @ X0_v7] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe void SetKey(int entry, K key)
	{
		//IL_0016: Expected Obj, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0110: Expected Obj, but got I4
		//IL_01e6: Expected Obj, but got I
		//IL_023e: Expected Obj, but got I4
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_0265: Expected Obj, but got I
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_0290: Expected Obj, but got Ref
		//IL_014b: Expected Obj, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		int entryStride = _entryStride;
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj4 = (nint)0 + (nint)309;
		object obj5 = obj4 & 1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		nint num = 0;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+40]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+40]");
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj12 = default;
			obj8 = obj12;
		}
		int value = ((int*)entryStride)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v8 (System.Int32)+12E]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v8 (System.Int32)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_018c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v8 (System.Int32)+98]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v5-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj13--;
			obj14 += 16;
			if ((nint)obj13 != 1)
			{
				continue;
			}
			goto IL_018c;
		}
		object obj15 = obj14 + 1;
		object obj16 = value + obj15;
		object obj17 = obj16 + 312;
		goto IL_022f;
		IL_022f:
		object obj18 = _capacity * entry;
		object obj19 = _keyOffset + obj18;
		object obj20 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v7+8]");
		object obj21 = 0;
		object obj22 = key & 0xFFFFFFFFL;
		object obj23 = _data + obj19;
		object obj24 = (ref System.Runtime.CompilerServices.Unsafe.As<NetworkDictionary<K, V>, byte>(ref this)) + (ref *(byte*)obj23);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v81 @ X5_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_018c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_022f;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe V GetVal(int entry)
	{
		//IL_0016: Expected Obj, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		//IL_01f8: Expected VT, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00be: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_013f: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_0299: Expected Obj, but got Ref
		//IL_017a: Expected Obj, but got I
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		int entriesOffset = _entriesOffset;
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj4;
		if (_entriesOffset != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+14]");
			obj4 = 0;
			object obj5 = (nint)0 + (nint)309;
			object obj6 = obj5 & 1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			nint num = 0;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5+50]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5+50]");
			object obj10 = (nint)0 + (nint)309;
			object obj11 = obj10 & 1;
			bool flag3 = obj11 == null;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj13 = default;
				obj9 = obj13;
			}
			int value = ((int*)entriesOffset)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v8 (System.Int32)+12E]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v8 (System.Int32)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01bb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v8 (System.Int32)+98]");
			object obj15 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X10_v5-8]");
				if (0 == (nint)obj9)
				{
					break;
				}
				obj14--;
				obj15 += 16;
				if ((nint)obj14 != 1)
				{
					continue;
				}
				goto IL_01bb;
			}
			object obj16 = value + obj15;
			object obj17 = obj16 + 312;
			goto IL_025e;
		}
		NullReferenceException ex = new NullReferenceException();
		return (V)ex;
		IL_01bb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_025e;
		IL_025e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X21_v2+18]");
		object obj18 = (nint)0 * (nint)entry;
		object obj19 = _keyOffset + obj18;
		object obj20 = obj4 + obj19;
		object obj21 = (ref System.Runtime.CompilerServices.Unsafe.As<NetworkDictionary<K, V>, byte>(ref this)) + (ref *(byte*)obj20);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v192 @ X0_v7] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe void SetVal(int entry, V val)
	{
		//IL_0016: Expected Obj, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_009f: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0120: Expected Obj, but got I4
		//IL_01f6: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_027b: Expected Obj, but got I
		//IL_0292: Expected Obj, but got Ref
		//IL_015b: Expected Obj, but got I
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		int entriesOffset = _entriesOffset;
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+14]");
		object obj4 = 0;
		object obj5 = (nint)0 + (nint)309;
		object obj6 = obj5 & 1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		nint num = 0;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v5+50]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v5+50]");
		object obj10 = (nint)0 + (nint)309;
		object obj11 = obj10 & 1;
		bool flag3 = obj11 == null;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj13 = default;
			obj9 = obj13;
		}
		int value = ((int*)entriesOffset)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v8 (System.Int32)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v8 (System.Int32)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_019c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v8 (System.Int32)+98]");
		object obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X10_v5-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			obj14--;
			obj15 += 16;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_019c;
		}
		object obj16 = obj15 + 1;
		object obj17 = value + obj16;
		object obj18 = obj17 + 312;
		goto IL_023f;
		IL_023f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X22_v2+18]");
		object obj19 = (nint)0 * (nint)entry;
		object obj20 = _keyOffset + obj19;
		object obj21 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v7+8]");
		object obj22 = 0;
		object obj23 = obj4 + obj20;
		object obj24 = (ref System.Runtime.CompilerServices.Unsafe.As<NetworkDictionary<K, V>, byte>(ref this)) + (ref *(byte*)obj23);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v82 @ X5_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_019c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_023f;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe int GetNxt(int entry)
	{
		//IL_0005: Expected Obj, but got Ref
		//IL_0011: Expected Obj, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0039: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj5 = _capacity * entry;
		object obj6 = _keyOffset + obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+C]");
		object obj7 = obj6 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X21_v1+v42 @ X8_v5*4]");
		return 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe void SetNxt(int entry, int next)
	{
		//IL_0005: Expected Obj, but got Ref
		//IL_0011: Expected Obj, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0039: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj5 = _capacity * entry;
		object obj6 = _keyOffset + obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkDictionary`2<K, V>)+C]");
		object obj7 = obj6 + 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe int GetKeyHashCode(K key)
	{
		//IL_01a5: Expected I4, but got Obj
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
		//IL_01c2: Expected Obj, but got I
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X0_v3 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v3+40]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v3+40]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v6 (System.Int32)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v6 (System.Int32)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_015a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v6 (System.Int32)+98]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X10_v5-8]");
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
			object obj12 = obj11 + 4;
			object obj13 = value + obj12;
			object obj14 = obj13 + 312;
			goto IL_020b;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_020b:
		object obj15 = key & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v159 @ X0_v5] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_015a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_020b;
	}

	public unsafe KeyValuePair<K, V>[] ToArray()
	{
		//IL_001c: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I4
		//IL_025a: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_0298: Expected Obj, but got I4
		//IL_02bc: Expected Obj, but got I
		//IL_02d8: Expected Obj, but got Ref
		//IL_02e1: Expected Obj, but got I4
		//IL_02f2: Expected Obj, but got I
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_031a: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0149: Expected Obj, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0171: Expected Obj, but got I4
		//IL_01a4: Expected Obj, but got I
		//IL_01b4: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I4
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X0_v1 (Il2CppClass<Fusion.NetworkDictionary`2>)+135]");
		object obj = (nint)0 & (nint)1;
		bool flag = obj == null;
		object obj2 = !flag;
		nint num2 = 0;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v2 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B144");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = (nint)0 + (nint)309;
		object obj9 = obj8 & 1;
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		nint num4 = 0;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			num4 = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v7 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9CD80");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		object obj13 = default;
		object obj12 = (object)(&obj13);
		object obj14 = 0;
		object obj20 = default;
		KeyValuePair<K, V>[] array = default;
		while (true)
		{
			object obj15 = (nint)0 + (nint)309;
			object obj16 = obj15 & 1;
			bool flag4 = obj16 == null;
			object obj17 = !flag4;
			nint num5 = 0;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v15 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77E18");
			object obj19 = obj20 & 1;
			if (obj19 != null)
			{
				object obj21 = (nint)0 + (nint)309;
				object obj22 = obj21 & 1;
				bool flag5 = obj22 == null;
				object obj23 = !flag5;
				nint num6 = 0;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v20 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v16+C8]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77F00");
				if (array != null)
				{
					bool flag6 = (nint)obj14 < array.Length;
					object obj25 = !flag6;
					if (obj25 != null)
					{
						break;
					}
					object obj26 = (object)array + obj14;
					obj14++;
					continue;
				}
				NullReferenceException ex = new NullReferenceException();
				break;
			}
			return array;
		}
		return (KeyValuePair<K, V>[])(object)new IndexOutOfRangeException();
	}

	public Enumerator GetEnumerator()
	{
		//IL_001c: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X0_v1 (Il2CppClass<Fusion.NetworkDictionary`2>)+135]");
		object obj = (nint)0 & (nint)1;
		bool flag = obj == null;
		object obj2 = !flag;
		nint num2 = 0;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77DDC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Enumerator result = default;
		return result;
	}

	public unsafe NetworkDictionary(int* data, int capacity, IElementReaderWriter<K> keyReaderWriter, IElementReaderWriter<V> valReaderWriter)
	{
		//IL_000b: Expected Obj, but got Ref
		//IL_0014: Expected Obj, but got I4
		//IL_001b: Expected I, but got Obj
		//IL_004c: Expected Obj, but got Ref
		//IL_0055: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got Ref
		//IL_0078: Expected Obj, but got I4
		//IL_008a: Expected VT, but got I
		//IL_0096: Expected Obj, but got I
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00be: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
		obj = 0;
		_data = (int*)unchecked((nint)null);
		_capacity = 0;
		_ = 0;
		_keyOffset = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 48));
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 56));
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		NetworkDictionary<K, V> networkDictionary = (NetworkDictionary<K, V>)data;
		object obj4 = (nint)0 + (nint)309;
		object obj5 = obj4 & 1;
		bool flag = obj5 == null;
		object obj6 = !flag;
		nint num = 0;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v10 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B284");
	}

	private IEnumerator<KeyValuePair<K, V>> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CK_002CV_003E_003E_002EGetEnumerator()
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00e5: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9CD80");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		object obj5 = (nint)0 + (nint)309;
		object obj6 = obj5 & 1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		nint num2 = 0;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v7 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		IEnumerator<KeyValuePair<K, V>> result = default;
		return result;
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00e5: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9CD80");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		object obj5 = (nint)0 + (nint)309;
		object obj6 = obj5 & 1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		nint num2 = 0;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v7 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		IEnumerator result = default;
		return result;
	}

	private void Fusion_002EINetworkDictionary_002EAdd(object item)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0284: Expected Obj, but got I
		//IL_0294: Expected Obj, but got I
		//IL_02aa: Expected Obj, but got I
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02d2: Expected Obj, but got I4
		//IL_007e: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_01d1: Expected Obj, but got I
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_0201: Expected Obj, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_014b: Expected Obj, but got I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0180: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I8
		//IL_0231: Expected Obj, but got I
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v2 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+D8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+D8]");
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
		nint num2 = (nint)item;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v7 (Il2CppClass<System.Object>)+40]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X1_v2+40]");
		object obj11;
		nint num4;
		nint num6;
		if (num3 == 0)
		{
			object obj10 = (nint)0 + (nint)309;
			obj11 = obj10;
			object obj12 = obj10 & 1;
			if (obj12 != null)
			{
				object obj13 = obj11 & 1;
				bool flag3 = obj13 == null;
				num4 = 0;
				nint num5 = 0;
				if (!flag3)
				{
					goto IL_0123;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj14 = (nint)0 + (nint)309;
				obj11 = obj14;
				object obj15 = obj14 & 1;
				bool flag4 = obj15 == null;
				object obj16 = !flag4;
				num4 = 0;
				nint num5 = 0;
				if (obj16 != null)
				{
					goto IL_0123;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj17 = (nint)0 + (nint)309;
			object obj18 = obj17 & 1;
			bool flag5 = obj18 == null;
			num4 = 0;
			if (flag5)
			{
				goto IL_0161;
			}
			num6 = 0;
			goto IL_0170;
		}
		throw new InvalidCastException();
		IL_0170:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v13 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (System.Object)+10]");
		object obj20 = (nint)0 >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (System.Object)+10]");
		object obj21 = 0 & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B9BC");
		return;
		IL_0123:
		object obj22 = obj11 & 1;
		bool flag6 = obj22 == null;
		object obj23 = !flag6;
		num6 = num4;
		if (obj23 == null)
		{
			goto IL_0161;
		}
		goto IL_0170;
		IL_0161:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		goto IL_0170;
	}

	public unsafe NetworkDictionaryReadOnly<K, V> ToReadOnly()
	{
		//IL_001c: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I
		//IL_0092: Expected VT, but got Ref
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X0_v1 (Il2CppClass<Fusion.NetworkDictionary`2>)+135]");
		object obj = (nint)0 & (nint)1;
		bool flag = obj == null;
		object obj2 = !flag;
		nint num2 = 0;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F999CC");
		_ = 0;
		_ = 0;
		object obj5 = default;
		object obj4 = obj5;
		_ = 0;
		return (NetworkDictionaryReadOnly<K, V>)(&obj5);
	}

	public unsafe static implicit operator NetworkDictionaryReadOnly<K, V>(NetworkDictionary<K, V> value)
	{
		//IL_000c: Expected Obj, but got I
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I4
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_00e6: Expected VT, but got Ref
		//IL_006f: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj;
		object obj3 = obj & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		object obj5 = 0;
		nint num = 0;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj6 = (nint)0 + (nint)309;
			obj2 = obj6;
			obj5 = 0;
			num = 0;
		}
		object obj7 = obj2 & 1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (Il2CppClass<Fusion.NetworkDictionary`2>)+A8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ X0 (Fusion.NetworkDictionary`2<K, V>)+8]");
		object obj10 = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F999CC");
		object obj12 = default;
		object obj11 = obj12;
		return (NetworkDictionaryReadOnly<K, V>)(&obj12);
	}
}
