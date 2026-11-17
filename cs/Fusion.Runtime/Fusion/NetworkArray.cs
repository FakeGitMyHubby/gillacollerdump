using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Photon.Client;
using PlayFab.ClientModels;
using UnityEngine.UIElements;

namespace Fusion;

public struct NetworkArray<T> : _0021_00210, Action<global::Photon.Client.NCommand>, _0021_00210
{
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public NetworkArray<T> array;

		internal T[] _003C_002Ector_003Eb__0()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected Obj, but got Unknown
			//IL_0021: Expected Obj, but got I
			//IL_0070: Expected Obj, but got I
			//IL_004e: Expected Obj, but got I
			nint num = 0;
			object obj = this + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Fusion.NetworkArray`1+<>c__DisplayClass0_0>)+A8]");
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

	public struct Enumerator : Action<MeshGenerationContext>, _0021_00210, Action<ModifyUserVirtualCurrencyResult>
	{
		private int _index;

		private NetworkArray<T> _array;

		public unsafe T Current
		{
			get
			{
				//IL_000c: Expected Obj, but got I
				//IL_0015: Unknown result type (might be due to invalid IL or missing references)
				//IL_001a: Expected Obj, but got Unknown
				//IL_0034: Expected Obj, but got I4
				//IL_0069: Expected Obj, but got I4
				//IL_0083: Expected Obj, but got I
				//IL_008c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Expected Obj, but got Unknown
				//IL_00ab: Expected Obj, but got I4
				//IL_012d: Expected VT, but got Obj
				//IL_00de: Expected Obj, but got I
				//IL_00e9: Expected Obj, but got Ref
				object obj = (nint)0 + (nint)309;
				object obj2 = obj & 1;
				bool flag = obj2 == null;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				bool flag2 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) < (nint)_index;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					object obj5 = (nint)0 + (nint)309;
					object obj6 = obj5 & 1;
					bool flag3 = obj6 == null;
					object obj7 = !flag3;
					nint num = 0;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v10 (Il2CppClass<Fusion.NetworkArray`1+Enumerator>)+A8]");
					object obj8 = 0;
					object obj9 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90AE4");
					T result = default;
					return result;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				IndexOutOfRangeException ex = default;
				ex._002Ector();
				ArgumentNullException ex2 = new ArgumentNullException();
				return (T)ex2;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkArray`1+Enumerator>)+A8]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4ACF590");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Fusion.NetworkArray`1+Enumerator>)+A8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object result = default;
				return result;
			}
		}

		public unsafe Enumerator(NetworkArray<T> array)
		{
			//IL_000d: Expected VT, but got I8
			//IL_0018: Expected Obj, but got Ref
			//IL_0025: Expected Obj, but got I
			Enumerator enumerator = (Enumerator)4294967295L;
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 24));
			obj = (object)array._array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		public unsafe bool MoveNext()
		{
			//IL_000b: Expected Obj, but got Ref
			//IL_0017: Expected Obj, but got I
			//IL_001f: Expected VT, but got Obj
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected Obj, but got Unknown
			//IL_0047: Expected Obj, but got I4
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected Obj, but got Unknown
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected I4, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected I4, but got Unknown
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 1));
			object obj2 = (nint)0 + (nint)309;
			Enumerator enumerator = (Enumerator)obj;
			object obj3 = obj2 & 1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			object obj5 = obj - _index;
			bool flag2 = (nint)obj5 < 0;
			int num = obj ^ _index;
			object obj6 = obj ^ obj5;
			int num2 = num & obj6;
			bool flag3 = num2 < 0;
			bool flag4 = flag2 == flag3;
			return !flag4;
		}

		public void Reset()
		{
			//IL_000d: Expected VT, but got I8
			Enumerator enumerator = (Enumerator)4294967295L;
		}

		public void Dispose()
		{
			//IL_0024: Expected VT, but got I8
			_ = 0;
			_index = 0;
			_ = 0;
			Enumerator enumerator = (Enumerator)4294967295L;
		}
	}

	private static StringBuilder _stringBuilderCached;

	private unsafe byte* _array;

	private int _length;

	private IElementReaderWriter<T> _readerWriter;

	public int Length
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
			return 0;
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public unsafe T get_Item(int index)
	{
		//IL_0021: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_01cc: Expected VT, but got Obj
		//IL_009e: Expected Obj, but got I
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I4
		//IL_01dc: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_022a: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
		bool flag = (nint)0 < (nint)index;
		object obj = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
		object obj2 = -index;
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag2;
		if (obj4 == null)
		{
			byte* array = _array;
			if (_array != null)
			{
				object obj5 = (nint)0 + (nint)309;
				object obj6 = obj5 & 1;
				bool flag3 = obj6 == null;
				object obj7 = !flag3;
				nint num = 0;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr = default;
					num = intPtr;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v3 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+8]");
				object obj10 = (nint)0 + (nint)309;
				object obj11 = obj10 & 1;
				bool flag4 = obj11 == null;
				object obj12 = !flag4;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj13 = default;
					obj9 = obj13;
				}
				while (true)
				{
					IntPtr intPtr2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7 (Il2CppClass<System.Byte*>)+12E]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7 (Il2CppClass<System.Byte*>)+12E]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7 (Il2CppClass<System.Byte*>)+98]");
						object obj15 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X10_v5-8]");
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
							goto IL_015f;
						}
						object obj16 = (nint)intPtr2 + obj15;
						object obj17 = obj16 + 312;
						goto IL_025c;
					}
					goto IL_015f;
					IL_025c:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v186 @ X0_v11] (should have been resolved before IL gen)");
					continue;
					IL_015f:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					goto IL_025c;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			IndexOutOfRangeException ex = default;
			ex._002Ector();
			ArgumentNullException ex2 = new ArgumentNullException();
		}
		NullReferenceException ex3 = new NullReferenceException();
		return (T)ex3;
	}

	public unsafe void set_Item(int index, T value)
	{
		//IL_0021: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_007d: Expected Obj, but got Ref
		//IL_0089: Expected Obj, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00b1: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I
		//IL_01f4: Expected Obj, but got I
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_021c: Expected Obj, but got I4
		//IL_0288: Expected Obj, but got I
		//IL_0266: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
		bool flag = (nint)0 < (nint)index;
		object obj = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
		object obj2 = -index;
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag2;
		if (obj4 == null)
		{
			byte* array = _array;
			object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			object obj6 = (nint)0 + (nint)309;
			object obj7 = obj6 & 1;
			bool flag3 = obj7 == null;
			object obj8 = !flag3;
			nint num = 0;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr = default;
				num = intPtr;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v3 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4+8]");
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
			object obj19 = default;
			while (true)
			{
				IntPtr intPtr2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v7 (Il2CppClass<System.Byte*>)+12E]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v7 (Il2CppClass<System.Byte*>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v7 (Il2CppClass<System.Byte*>)+98]");
					object obj16 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X10_v5-8]");
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
						goto IL_014a;
					}
					object obj17 = obj16 + 1;
					object obj18 = (nint)intPtr2 + obj17;
					obj19 = obj18 + 312;
					goto IL_024e;
				}
				goto IL_014a;
				IL_024e:
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v11+8]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v92 @ X5_v1 (should have been resolved before IL gen)");
				continue;
				IL_014a:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				goto IL_024e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		IndexOutOfRangeException ex = default;
		ex._002Ector();
		ArgumentNullException ex2 = new ArgumentNullException();
		throw new NullReferenceException();
	}

	// C# has no syntax for parameterized property 'Fusion.INetworkArray.Item'.
	private object Fusion_002EINetworkArray_002Eget_Item(int index)
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v2 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90AE4");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object result = default;
		return result;
	}

	private void Fusion_002EINetworkArray_002Eset_Item(int index, object value)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0184: Expected Obj, but got I4
		//IL_007e: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00e1: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v2 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+18]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+18]");
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
		nint num2 = (nint)value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v7 (Il2CppClass<System.Object>)+40]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X1_v2+40]");
		if (num3 == 0)
		{
			object obj10 = (nint)0 + (nint)309;
			object obj11 = obj10 & 1;
			bool flag3 = obj11 == null;
			object obj12 = !flag3;
			nint num4 = 0;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v8 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90BD8");
			return;
		}
		throw new InvalidCastException();
	}

	public T Get(int index)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90AE4");
		T result = default;
		return result;
	}

	public T Set(int index, T value)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v2 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90BD8");
		return value;
	}

	internal unsafe ref T GetRef(int index)
	{
		//IL_0021: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_009e: Expected Obj, but got I
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I4
		//IL_01ea: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_0238: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
		bool flag = (nint)0 < (nint)index;
		object obj = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
		object obj2 = -index;
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag2;
		if (obj4 == null)
		{
			byte* array = _array;
			if (_array != null)
			{
				object obj5 = (nint)0 + (nint)309;
				object obj6 = obj5 & 1;
				bool flag3 = obj6 == null;
				object obj7 = !flag3;
				nint num = 0;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr = default;
					num = intPtr;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v3 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+8]");
				object obj10 = (nint)0 + (nint)309;
				object obj11 = obj10 & 1;
				bool flag4 = obj11 == null;
				object obj12 = !flag4;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj13 = default;
					obj9 = obj13;
				}
				while (true)
				{
					IntPtr intPtr2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7 (Il2CppClass<System.Byte*>)+12E]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7 (Il2CppClass<System.Byte*>)+12E]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7 (Il2CppClass<System.Byte*>)+98]");
						object obj15 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X10_v5-8]");
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
							goto IL_015f;
						}
						object obj16 = obj15 + 3;
						object obj17 = (nint)intPtr2 + obj16;
						object obj18 = obj17 + 312;
						goto IL_026a;
					}
					goto IL_015f;
					IL_026a:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v187 @ X0_v11] (should have been resolved before IL gen)");
					continue;
					IL_015f:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					goto IL_026a;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			IndexOutOfRangeException ex = default;
			ex._002Ector();
			ArgumentNullException ex2 = new ArgumentNullException();
		}
		NullReferenceException ex3 = new NullReferenceException();
		return ref *(T*)ex3;
	}

	public T[] ToArray()
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00ad: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01c5: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
		T[] array = default;
		if ((nint)0 >= (nint)1)
		{
			object obj5 = array + 32;
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
			object obj7 = 0;
			while (true)
			{
				object obj8 = (nint)0 + (nint)309;
				object obj9 = obj8 & 1;
				bool flag2 = obj9 == null;
				object obj10 = !flag2;
				nint num2 = 0;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v9 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90AE4");
				if (array != null)
				{
					bool flag3 = (nint)obj6 < array.Length;
					object obj12 = !flag3;
					if (obj12 == null)
					{
						obj6++;
						object obj13 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
						bool flag4 = (nint)obj13 < 0;
						obj7 = obj6;
						if (!flag4)
						{
							break;
						}
						continue;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
				}
				return (T[])(object)new IndexOutOfRangeException();
			}
		}
		return array;
	}

	public void CopyTo(List<T> list)
	{
		//IL_0219: Expected Obj, but got I
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_0241: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00a9: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I4
		//IL_01a0: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		List<T> list2 = list;
		List<T> list3 = null;
		byte b = default;
		List<T> list4;
		do
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v4 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v6+28]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90AE4");
			object obj5 = (nint)0 + (nint)309;
			object obj6 = obj5 & 1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			nint num3 = 0;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v10 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
			object obj8 = 0;
			T[] items = list._items;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X9_v4+68]");
			object obj9 = 0;
			int version = list._version + 1;
			list._version = version;
			bool flag3 = list._size < items.Length;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				int size = list._size + 1;
				object obj11 = items + list._size;
				list._size = size;
				list2 = list3;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X9_v5+20]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v13+A8]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v14+70]");
				num2 = 0;
				((List<byte>)(object)list).AddWithResize(b);
				list2 = (List<T>)b;
			}
			list3 = (List<T>)(list3 + 1);
			list4 = list3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
		}
		while ((nint)list4 < 0);
	}

	public void CopyTo(NetworkArray<T> array)
	{
		//IL_000c: Expected Obj, but got I
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0228: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I
		//IL_00e5: Expected VT, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02c9: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I
		//IL_011f: Expected Obj, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0147: Expected Obj, but got I4
		//IL_0246: Expected Obj, but got I
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected VT, but got Unknown
		//IL_026e: Invalid comparison between I and VT
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
		object obj6 = obj2 & 1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [array @ X1 (Fusion.NetworkArray`1<T>)+8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [array @ X1 (Fusion.NetworkArray`1<T>)+8]");
			if (num2 > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string format = default;
				object arg = default;
				object arg2 = default;
				string message = string.Format(format, arg, arg2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentException ex = default;
				string paramName = default;
				ex._002Ector(message, paramName);
				throw new ArgumentNullException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [array @ X1 (Fusion.NetworkArray`1<T>)+8]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		NetworkArray<T> networkArray = array;
		NetworkArray<T> networkArray2 = (NetworkArray<T>)0;
		IntPtr intPtr = default;
		bool flag5;
		do
		{
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj11 = !flag3;
			nint num3 = 0;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v6 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90AE4");
			object obj13 = (nint)0 + (nint)309;
			object obj14 = obj13 & 1;
			bool flag4 = obj14 == null;
			object obj15 = !flag4;
			nint num4 = 0;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				num4 = intPtr;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v10 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90BD8");
			NetworkArray<T> networkArray3 = (NetworkArray<T>)(networkArray2 + 1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [array @ X1 (Fusion.NetworkArray`1<T>)+8]");
			flag5 = (object)0 != (object)networkArray3;
			networkArray = networkArray2;
			networkArray2 = networkArray3;
		}
		while (flag5);
	}

	public void CopyTo(T[] array, bool throwIfOverflow = default(bool))
	{
		//IL_0050: Expected Obj, but got I8
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0158: Expected Obj, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_0180: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		T[] array2 = default;
		if (array2 != null)
		{
			if (array2.Length < 1)
			{
				return;
			}
			object obj = array2.Length & 0xFFFFFFFFL;
			object obj2 = array2 + 32;
			T[] array3 = array2;
			T[] array4 = null;
			while (true)
			{
				object obj3 = (nint)0 + (nint)309;
				object obj4 = obj3 & 1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				nint num = 0;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v15 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90AE4");
				bool flag2 = (nint)array4 < array2.Length;
				object obj7 = !flag2;
				if (obj7 != null)
				{
					break;
				}
				T[] array5 = (T[])(array4 + 1);
				bool flag3 = obj != array5;
				array3 = array4;
				array4 = array5;
				if (!flag3)
				{
					return;
				}
			}
			throw new IndexOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex = default;
		string paramName = default;
		ex._002Ector(paramName);
		throw new ArgumentNullException();
	}

	public override string ToString()
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X8_v2 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F91958");
		string result = default;
		return result;
	}

	public unsafe Enumerator GetEnumerator()
	{
		//IL_001c: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I
		//IL_0086: Expected VT, but got Ref
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X0_v1 (Il2CppClass<Fusion.NetworkArray`1>)+135]");
		object obj = (nint)0 & (nint)1;
		bool flag = obj == null;
		object obj2 = !flag;
		nint num2 = 0;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4ACF698");
		object obj5 = default;
		object obj4 = obj5;
		_ = 0;
		return (Enumerator)(&obj5);
	}

	public void Clear()
	{
		//IL_002a: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00c7: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		nint num = unchecked((nint)null);
		bool flag2;
		do
		{
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num2 = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v4 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90BD8");
			nint num3 = num + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
			flag2 = num3 < 0;
			num = num3;
		}
		while (flag2);
	}

	public void CopyFrom(T[] source, int sourceOffset, int sourceCount)
	{
		//IL_01fc: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_0287: Expected Obj, but got I
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_0338: Expected Obj, but got I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0167: Expected I4, but got I8
		T[] array = default;
		if (array != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
			int num = default;
			if ((nint)0 >= (nint)num)
			{
				int num2 = default;
				object obj = num + num2;
				if ((nint)obj <= array.Length)
				{
					if (num < 1)
					{
						return;
					}
					int num3 = num2 << 32;
					int num4 = num;
					int num5 = num2;
					T[] array2 = array;
					T[] array3 = null;
					while (true)
					{
						object obj2 = num2 + array3;
						bool flag = (nint)obj2 < array.Length;
						object obj3 = !flag;
						if (obj3 != null)
						{
							break;
						}
						object obj4 = array + num3;
						object obj5 = (nint)0 + (nint)309;
						object obj6 = obj5 & 1;
						bool flag2 = obj6 == null;
						object obj7 = !flag2;
						nint num6 = 0;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v53 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v10+38]");
						num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90BD8");
						T[] array4 = (T[])(array3 + 1);
						num3 = (int)(num3 + 4294967296L);
						bool flag3 = num != (nint)array4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v9+20]");
						num5 = 0;
						array2 = array3;
						array3 = array4;
						if (!flag3)
						{
							return;
						}
					}
					throw new IndexOutOfRangeException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string format = default;
				object arg = default;
				object arg2 = default;
				object arg3 = default;
				string paramName = string.Format(format, arg, arg2, arg3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentOutOfRangeException ex = default;
				string message = default;
				ex._002Ector(paramName, message);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string format2 = default;
				object arg4 = default;
				object arg5 = default;
				string message2 = string.Format(format2, arg4, arg5);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentException ex2 = default;
				string paramName2 = default;
				ex2._002Ector(message2, paramName2);
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex3 = default;
			string paramName3 = default;
			ex3._002Ector(paramName3);
		}
		throw new ArgumentNullException();
	}

	public void CopyFrom(List<T> source, int sourceOffset, int sourceCount)
	{
		//IL_01e6: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I4
		//IL_0271: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_039d: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected I4, but got Unknown
		//IL_0148: Expected Obj, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_0170: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected Obj, but got Unknown
		if (source != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
			if ((nint)0 >= (nint)sourceCount)
			{
				object obj = (nint)0 + (nint)309;
				object obj2 = obj & 1;
				bool flag = obj2 == null;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				object obj4 = sourceCount + sourceOffset;
				if (source._size >= (nint)obj4)
				{
					if (sourceCount < 1)
					{
						return;
					}
					int num = sourceCount;
					int num2 = sourceOffset;
					List<T> list = source;
					List<T> list2 = null;
					IntPtr intPtr = default;
					bool flag4;
					do
					{
						object obj5 = (nint)0 + (nint)309;
						object obj6 = obj5 & 1;
						bool flag2 = obj6 == null;
						object obj7 = !flag2;
						nint num3 = 0;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v53 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
						object obj8 = 0;
						int index = sourceOffset + list2;
						byte b = ((List<byte>)(object)source).get_Item(index);
						object obj9 = (nint)0 + (nint)309;
						object obj10 = obj9 & 1;
						bool flag3 = obj10 == null;
						object obj11 = !flag3;
						nint num4 = 0;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
							num4 = intPtr;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v13 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v14+38]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90BD8");
						List<T> list3 = (List<T>)(list2 + 1);
						flag4 = sourceCount != (nint)list3;
						num2 = b;
						list = list2;
						list2 = list3;
					}
					while (flag4);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string format = default;
				object arg = default;
				object arg2 = default;
				object arg3 = default;
				string paramName = string.Format(format, arg, arg2, arg3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentOutOfRangeException ex = default;
				string message = default;
				ex._002Ector(paramName, message);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string format2 = default;
				object arg4 = default;
				object arg5 = default;
				string message2 = string.Format(format2, arg4, arg5);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentException ex2 = default;
				string paramName2 = default;
				ex2._002Ector(message2, paramName2);
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex3 = default;
			string paramName3 = default;
			ex3._002Ector(paramName3);
		}
		throw new ArgumentNullException();
	}

	private unsafe string ToListString()
	{
		//IL_0015: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0053: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I
		//IL_0198: Expected Obj, but got I
		//IL_01bc: Expected Obj, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		//IL_0405: Expected Obj, but got I
		//IL_0415: Expected Obj, but got I
		//IL_0425: Expected Obj, but got I
		//IL_0443: Expected Obj, but got I
		//IL_045d: Expected Obj, but got I4
		//IL_04c3: Expected Obj, but got I
		//IL_04d3: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_0263: Expected Obj, but got I4
		//IL_0296: Expected Obj, but got I
		//IL_02a6: Expected Obj, but got I
		//IL_02b6: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I
		//IL_02cf: Expected Obj, but got I4
		//IL_02d8: Expected Obj, but got I4
		//IL_0477: Expected Obj, but got I
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected Obj, but got Unknown
		//IL_049f: Expected Obj, but got I4
		//IL_02fc: Expected Obj, but got I
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03a8: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9928]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v6 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v9+30]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v10+A0]");
			object obj6 = 0;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v39 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v37+30]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v38+A0]");
				object obj12 = 0;
				if (obj12 == null)
				{
					goto IL_03bd;
				}
				StringBuilder stringBuilder = ((StringBuilder)obj12).Clear();
				string text = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				StringBuilder stringBuilder2 = default;
				stringBuilder2._002Ector();
				object obj14 = (nint)0 + (nint)309;
				object obj15 = obj14 & 1;
				bool flag3 = obj15 == null;
				object obj16 = !flag3;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					nint num3 = 0;
				}
				else
				{
					nint num4 = 0;
					nint num3 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v29 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X9_v7+30]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X9_v8+A0]");
				object obj19 = 0;
				obj19 = stringBuilder2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v30 (Il2CppClass<Fusion.NetworkArray`1>)+135]");
				object obj20 = (nint)0 & (nint)1;
				bool flag4 = obj20 == null;
				object obj21 = !flag4;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr = default;
					nint num3 = intPtr;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v30 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v31+30]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				string text = (string)(object)stringBuilder2;
			}
			object obj24 = (nint)0 + (nint)309;
			object obj25 = obj24 & 1;
			bool flag5 = obj25 == null;
			object obj26 = !flag5;
			nint num5 = 0;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v11 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v17+30]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v18+A0]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0A68]");
			object obj30 = 0;
			object obj31 = 1;
			object obj32 = 0;
			byte b = default;
			string result = default;
			while (true)
			{
				object obj33 = (nint)0 + (nint)309;
				object obj34 = obj33 & 1;
				bool flag6 = obj34 == null;
				object obj35 = !flag6;
				nint num6 = 0;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v14 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
				object obj36 = 0;
				object obj37 = obj31 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90E20");
				string value = b.ToString();
				if (obj29 == null)
				{
					break;
				}
				StringBuilder stringBuilder3 = ((StringBuilder)obj29).Append(value);
				object obj38 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
				if (obj38 != null)
				{
					string text = (string)obj30;
					StringBuilder stringBuilder4 = ((StringBuilder)obj29).Append((string)obj30);
					obj31++;
					obj32 = 0;
					continue;
				}
				((SymmetricAlgorithm)obj29).BlockSize = 0;
				return result;
			}
			goto IL_03bd;
		}
		return null;
		IL_03bd:
		return (string)(object)new NullReferenceException();
	}

	public unsafe NetworkArray(byte* array, int length, IElementReaderWriter<T> readerWriter)
	{
		//IL_0008: Expected VT, but got I
		//IL_0018: Expected Obj, but got Ref
		NetworkArray<T> networkArray = (NetworkArray<T>)array;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		obj = readerWriter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I4
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F913E0");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v4 (Il2CppClass<Fusion.NetworkArray`1>)+135]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		nint num3 = 0;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		IEnumerator<T> result = default;
		return result;
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I4
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F913E0");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v4 (Il2CppClass<Fusion.NetworkArray`1>)+135]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		nint num3 = 0;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5 (Il2CppClass<Fusion.NetworkArray`1>)+A8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		IEnumerator result = default;
		return result;
	}

	public unsafe NetworkArrayReadOnly<T> ToReadOnly()
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_003a: Expected VT, but got I
		//IL_005c: Expected Obj, but got Ref
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		NetworkArrayReadOnly<T> result = (NetworkArrayReadOnly<T>)0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArray`1<T>)+8]");
		_ = 0;
		_ = 0;
		_ = _array;
		return result;
	}

	public unsafe static implicit operator NetworkArrayReadOnly<T>(NetworkArray<T> value)
	{
		//IL_000c: Expected Obj, but got I
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got I4
		//IL_00e2: Expected VT, but got I
		//IL_0090: Expected Obj, but got VT
		//IL_0066: Expected Obj, but got I
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
		object obj6 = obj2 & 1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		NetworkArrayReadOnly<T> result = (NetworkArrayReadOnly<T>)num;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj8 = value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ X0 (Fusion.NetworkArray`1<T>)+8]");
		_ = 0;
		_ = 0;
		_ = value._array;
		return result;
	}
}
