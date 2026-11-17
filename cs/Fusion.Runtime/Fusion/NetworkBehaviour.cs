using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Unity.Collections.LowLevel.Unsafe;
using Unity.IL2CPP.Metadata;
using UnityEngine.InputSystem;
using UnityEngine.XR;

namespace Fusion;

public abstract class NetworkBehaviour : SimulationBehaviour, _0021_00210, Action<InputActionAsset>, _0021_00210, Action<UnityEngine.XR.InputDevice>, _0021_00210
{
	private sealed class _003C_003Ec__DisplayClass9_0<T> where T : NetworkBehaviour
	{
		public NetworkBehaviourUtils.ChangeDetector.OnChangedPrevCallback<T> callback;

		internal void _003CGetWrapperPrev_003Eb__0(NetworkBehaviour behaviour, NetworkBehaviourBuffer prev)
		{
			//IL_001f: Expected Obj, but got I
			//IL_002f: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I
			//IL_0055: Expected Obj, but got I
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_007d: Expected Obj, but got I4
			//IL_00e8: Expected Obj, but got I4
			//IL_011a: Expected Obj, but got I
			//IL_012a: Expected Obj, but got I
			//IL_013a: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I4
			NetworkBehaviourUtils.ChangeDetector.OnChangedPrevCallback<T> onChangedPrevCallback = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X4+20]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v1+A8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v2+10]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v2+10]");
			object obj4 = (nint)0 + (nint)309;
			object obj5 = obj4 & 1;
			bool flag = obj5 == null;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj7 = default;
				obj3 = obj7;
			}
			if ((object)behaviour != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				object obj8 = default;
				bool flag2 = obj8 == null;
				object obj9 = !flag2;
				if (obj9 == null)
				{
					throw new InvalidCastException();
				}
			}
			else
			{
				object obj10 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X23_v1 (Fusion.NetworkBehaviourUtils+ChangeDetector+OnChangedPrevCallback`1<T>)+40]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X23_v1 (Fusion.NetworkBehaviourUtils+ChangeDetector+OnChangedPrevCallback`1<T>)+28]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X23_v1 (Fusion.NetworkBehaviourUtils+ChangeDetector+OnChangedPrevCallback`1<T>)+18]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v61 @ X5_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public struct ArrayReader<T>
	{
		internal int Offset;

		internal int Capacity;

		internal IElementReaderWriter<T> ReaderWriter;

		public unsafe NetworkArrayReadOnly<T> Read(NetworkBehaviourBuffer first)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0026: Expected Obj, but got I
			//IL_0040: Expected Obj, but got I4
			//IL_008d: Expected Obj, but got I
			//IL_0095: Expected Obj, but got VT
			//IL_00a0: Expected VT, but got Ref
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X3+20]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+135]");
			object obj2 = (nint)0 & (nint)1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			byte* array = (byte*)((ref *(byte*)first) + (ref System.Runtime.CompilerServices.Unsafe.As<ArrayReader<T>, byte>(ref this)));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkBehaviour+ArrayReader`1<T>)+4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkBehaviour+ArrayReader`1<T>)+8]");
			NetworkArrayReadOnly<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType> networkArrayReadOnly = new NetworkArrayReadOnly<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>(array, (int)num, (IElementReaderWriter<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>)0);
			object obj4 = networkArrayReadOnly;
			_ = 0;
			return (NetworkArrayReadOnly<T>)(&networkArrayReadOnly);
		}
	}

	public struct LinkListReader<T>
	{
		internal int Offset;

		internal int Capacity;

		internal IElementReaderWriter<T> ReaderWriter;

		public unsafe NetworkLinkedListReadOnly<T> Read(NetworkBehaviourBuffer first)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0026: Expected Obj, but got I
			//IL_0040: Expected Obj, but got I4
			//IL_006d: Expected Obj, but got I
			//IL_0077: Expected Obj, but got Ref
			//IL_0094: Expected VT, but got Ref
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X3+20]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+135]");
			object obj2 = (nint)0 & (nint)1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+A8]");
			object obj4 = 0;
			object obj5 = (ref *(byte*)first) + (ref System.Runtime.CompilerServices.Unsafe.As<LinkListReader<T>, byte>(ref this));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA2144");
			object obj7 = default;
			object obj6 = obj7;
			_ = 0;
			return (NetworkLinkedListReadOnly<T>)(&obj7);
		}
	}

	public struct DictionaryReader<K, V>
	{
		internal int Offset;

		internal int Capacity;

		internal IElementReaderWriter<K> KeyReaderWriter;

		internal IElementReaderWriter<V> ValueReaderWriter;

		public unsafe NetworkDictionaryReadOnly<K, V> Read(NetworkBehaviourBuffer first)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0026: Expected Obj, but got I
			//IL_0040: Expected Obj, but got I4
			//IL_0093: Expected Obj, but got I4
			//IL_0093: Expected Obj, but got I
			//IL_00a7: Expected Obj, but got VT
			//IL_00b2: Expected VT, but got Ref
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X3+20]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+135]");
			object obj2 = (nint)0 & (nint)1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			int* data = (int*)((ref *(byte*)first) + (ref System.Runtime.CompilerServices.Unsafe.As<DictionaryReader<K, V>, byte>(ref this)));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkBehaviour+DictionaryReader`2<K, V>)+4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkBehaviour+DictionaryReader`2<K, V>)+8]");
			NetworkDictionaryReadOnly<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType, Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType> networkDictionaryReadOnly = new NetworkDictionaryReadOnly<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType, Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>(data, (int)num, (IElementReaderWriter<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>)0, (IElementReaderWriter<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>)Offset);
			_ = 0;
			_ = 0;
			object obj4 = networkDictionaryReadOnly;
			_ = 0;
			return (NetworkDictionaryReadOnly<K, V>)(&networkDictionaryReadOnly);
		}
	}

	public struct BehaviourReader<T> where T : NetworkBehaviour
	{
		internal NetworkRunner Runner;

		internal PropertyReader<NetworkBehaviourId> Reader;

		public unsafe T Read(NetworkBehaviourBuffer first)
		{
			//IL_0145: Expected VT, but got Ref
			//IL_0152: Expected Ref, but got VT
			//IL_0013: Expected Obj, but got Ref
			//IL_0049: Expected Obj, but got I
			//IL_005f: Expected Obj, but got I
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected Obj, but got Unknown
			//IL_0087: Expected Obj, but got I4
			//IL_00b4: Expected Obj, but got I
			//IL_00c4: Expected Obj, but got I
			//IL_00da: Expected Obj, but got I
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected Obj, but got Unknown
			//IL_0102: Expected Obj, but got I4
			PropertyReader<NetworkBehaviourId> propertyReader = (PropertyReader<NetworkBehaviourId>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			NetworkBehaviourId behaviourId = ((PropertyReader<NetworkBehaviourId>*)propertyReader)->Read(first);
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) != null)
			{
				bool flag = ((NetworkRunner)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)).TryFindBehaviour(behaviourId, out var _);
				bool flag2 = !flag;
				T result = null;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X3+20]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X3+20]");
					object obj2 = (nint)0 + (nint)309;
					object obj3 = obj2 & 1;
					bool flag3 = obj3 == null;
					object obj4 = !flag3;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v10+A8]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v7+8]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v7+8]");
					object obj7 = (nint)0 + (nint)309;
					object obj8 = obj7 & 1;
					bool flag4 = obj8 == null;
					object obj9 = !flag4;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						object obj10 = default;
						obj6 = obj10;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				}
				return result;
			}
			return (T)(object)new NullReferenceException();
		}

		public (T, T) Read(NetworkBehaviourBuffer first, NetworkBehaviourBuffer second)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0026: Expected Obj, but got I
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected Obj, but got Unknown
			//IL_004e: Expected Obj, but got I4
			//IL_00c0: Expected Obj, but got I
			//IL_00da: Expected Obj, but got I
			//IL_00f0: Expected Obj, but got I
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Expected Obj, but got Unknown
			//IL_0118: Expected Obj, but got I4
			//IL_0136: Expected Obj, but got I
			//IL_0150: Expected Obj, but got I
			//IL_0166: Expected Obj, but got I
			//IL_0180: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X5+20]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X5+20]");
			object obj2 = (nint)0 + (nint)309;
			object obj3 = obj2 & 1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj5 = default;
				obj = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v2+A8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F6E024");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X5+20]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X5+20]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5+A8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F6E024");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X5+20]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v8+135]");
			object obj14 = (nint)0 & (nint)1;
			bool flag3 = obj14 == null;
			object obj15 = !flag3;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			System.__Canon item = default;
			System.__Canon item2 = default;
			return ((T)(object)item, (T)(object)item2);
		}
	}

	public struct PropertyReader<T> where T : struct
	{
		internal int Offset;

		public PropertyReader(int offset)
		{
			//IL_0008: Expected VT, but got I4
			PropertyReader<T> propertyReader = (PropertyReader<T>)offset;
		}

		public T Read(NetworkBehaviourBuffer first)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0026: Expected Obj, but got I
			//IL_0040: Expected Obj, but got I4
			//IL_006d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X3+20]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X0_v2+135]");
			object obj2 = (nint)0 & (nint)1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X0_v2+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D4930");
			T result = default;
			return result;
		}

		public (T, T) Read(NetworkBehaviourBuffer first, NetworkBehaviourBuffer second)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0026: Expected Obj, but got I
			//IL_0040: Expected Obj, but got I4
			//IL_006d: Expected Obj, but got I
			//IL_0087: Expected Obj, but got I
			//IL_009d: Expected Obj, but got I
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected Obj, but got Unknown
			//IL_00c5: Expected Obj, but got I4
			//IL_0120: Expected Obj, but got I
			//IL_0141: Expected Obj, but got I
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected Obj, but got Unknown
			//IL_0169: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X5+20]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v2+135]");
			object obj2 = (nint)0 & (nint)1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v2+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D4930");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X5+20]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X5+20]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+A8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D4930");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X5+20]");
			object obj11 = (nint)0 + (nint)309;
			object obj12 = obj11 & 1;
			bool flag3 = obj12 == null;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Angle item = default;
			Angle item2 = default;
			return ((T)item, (T)item2);
		}
	}

	[NonSerialized]
	public unsafe int* Ptr;

	internal int WordOffset;

	internal int WordCount;

	internal int ObjectIndex;

	internal bool DefaultReplicated = true;

	private NetworkBehaviourUtils.ChangeDetector _onRenderCallbacksDetector;

	internal unsafe int* InternalPtr => Ptr;

	internal unsafe Span<int> RawWords
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_002a: Expected I4, but got I8
			//IL_0016: Expected VT, but got I
			if ((int)(WordCount & 0x80000000L) != 0)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return (Span<int>)Ptr;
		}
	}

	public unsafe bool StateBufferIsValid
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			bool flag = Ptr == null;
			return !flag;
		}
	}

	public unsafe NetworkBehaviourBuffer StateBuffer
	{
		get
		{
			//IL_0060: Expected VT, but got Obj
			//IL_0052: Expected VT, but got I
			NetworkRunner runner = base._runner;
			if ((object)base._runner != null && (object)runner._simulation != null)
			{
				return (NetworkBehaviourBuffer)Ptr;
			}
			NullReferenceException ex = new NullReferenceException();
			return (NetworkBehaviourBuffer)ex;
		}
	}

	public (int, int) WordInfo
	{
		get
		{
			//IL_0021: Expected VT, but got I4
			(int, int) tuple = (WordOffset, WordCount);
			return ((int, int))0;
		}
	}

	public Tick ChangedTick
	{
		get
		{
			//IL_00a9: Expected VT, but got Obj
			//IL_0054: Expected Obj, but got I4
			//IL_0073: Expected Obj, but got I
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected VT, but got Unknown
			if ((object)base._object != null)
			{
				ReadOnlySpan<int> behaviourChangedTickArray = base._object.BehaviourChangedTickArray;
				int objectIndex = ObjectIndex;
				bool flag = ObjectIndex < 0;
				object obj = !flag;
				if (obj == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X0_v5 (System.ReadOnlySpan`1<System.Int32>)+v26 @ X8_v2 (System.Int32)*4]");
					object obj2 = ~(nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X0_v5 (System.ReadOnlySpan`1<System.Int32>)+v26 @ X8_v2 (System.Int32)*4]");
					return (Tick)(0 & obj2);
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (Tick)ex2;
		}
	}

	public unsafe NetworkBehaviourId Id
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0079: Expected I, but got Obj
			//IL_00d7: Expected VT, but got I
			//IL_0048: Expected Obj, but got I8
			NetworkObject networkObject = base._object;
			nint num;
			if ((object)base._object != null)
			{
				int* ptr = networkObject.Ptr;
				if (networkObject.Ptr != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v6 (System.Int32*)+4]");
					object obj = 0 & -9223372036854775808L;
					if (obj != null)
					{
						System.ThrowHelper.ThrowArgumentOutOfRangeException();
					}
				}
				Span<int> span = default;
				if (!span.IsEmpty)
				{
					int* ptr2 = networkObject.Ptr;
					num = (nint)ptr2;
					goto IL_00c8;
				}
			}
			num = unchecked((nint)null);
			goto IL_00c8;
			IL_00c8:
			return (NetworkBehaviourId)(num | ObjectIndex);
		}
	}

	public bool HasInputAuthority
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_003c: Expected Obj, but got I4
			//IL_0056: Expected Obj, but got I4
			NetworkObject networkObject = base._object;
			if ((object)base._object != null)
			{
				object obj = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					return base._object.HasInputAuthority;
				}
			}
			return false;
		}
	}

	public bool HasStateAuthority
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_003c: Expected Obj, but got I4
			//IL_0056: Expected Obj, but got I4
			NetworkObject networkObject = base._object;
			if ((object)base._object != null)
			{
				object obj = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
					bool result = default;
					return result;
				}
			}
			return false;
		}
	}

	public bool IsProxy
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_003c: Expected Obj, but got I4
			//IL_0056: Expected Obj, but got I4
			NetworkObject networkObject = base._object;
			if ((object)base._object != null)
			{
				object obj = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					return base._object.IsProxy;
				}
			}
			return false;
		}
	}

	public virtual int? DynamicWordCount
	{
		get
		{
			//IL_0006: Expected VT, but got I4
			return (int?)(object)0;
		}
	}

	internal bool IsEditorWritable
	{
		get
		{
			//IL_003c: Expected Obj, but got I4
			//IL_0056: Expected Obj, but got I4
			//IL_014f: Expected Obj, but got I
			//IL_0179: Expected Obj, but got I4
			//IL_013f: Expected I4, but got Obj
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected Obj, but got Unknown
			NetworkObject networkObject = base._object;
			if ((object)base._object != null)
			{
				object obj = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj3 = 0;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v4+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((bool)networkObject._runner)
					{
						if ((object)networkObject._runner != null)
						{
							ArgumentNullException ex = new ArgumentNullException();
							object obj6 = ex & 1;
							if (obj6 == null)
							{
								goto IL_012b;
							}
							if ((object)base._object != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
								bool result = default;
								return result;
							}
						}
						NullReferenceException ex2 = new NullReferenceException();
						return (byte)(int)ex2 != 0;
					}
				}
			}
			goto IL_012b;
			IL_012b:
			return true;
		}
	}

	internal unsafe void Init(int* ptr, int wordOffset, int wordCount)
	{
		int* ptr2 = (int*)((byte*)ptr + wordOffset);
		WordOffset = wordOffset;
		WordCount = wordCount;
		Ptr = ptr2;
	}

	internal unsafe int* InternalSwap(int* ptr)
	{
		Ptr = ptr;
		return Ptr;
	}

	internal unsafe int InternalCompare(int* ptr)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I4
		//IL_015a: Expected I8, but got I4
		object obj = 109895680;
		int num = WordCount << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8D]");
		if ((nint)0 != 0)
		{
			if (num != 0)
			{
				goto IL_005b;
			}
		}
		else
		{
			_ = 1;
			bool flag = num == 0;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_005b;
			}
		}
		return 0;
		IL_005b:
		int num2 = num >> 30;
		bool flag2 = ptr == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40E0]");
		object obj3 = 0;
		object obj4 = !flag2;
		object obj5 = ~obj4;
		bool flag3 = obj5 == null && num2 == 0;
		if (Ptr == null)
		{
			bool flag4 = false;
		}
		else
		{
			bool flag4 = flag3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F6408");
		return UnsafeUtility.MemCmp(Ptr, ptr, num);
	}

	public int GetLocalAuthorityMask()
	{
		//IL_014d: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected I4, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected I4, but got Unknown
		//IL_007c: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetworkObject networkObject;
		object obj7;
		if ((bool)base._runner)
		{
			networkObject = base._object;
			if ((object)base._object != null)
			{
				object obj4 = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
				bool flag2 = obj4 == null;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
					networkObject = base._object;
					bool flag3 = (object)base._object == null;
					object obj6 = !flag3;
					object obj8 = default;
					obj7 = obj8;
					if (obj6 == null)
					{
						obj7 = obj8;
						goto IL_01c0;
					}
				}
				else
				{
					obj7 = 0;
				}
				object obj9 = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
				bool flag4 = obj9 == null;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					bool hasInputAuthority = networkObject.HasInputAuthority;
					networkObject = (NetworkObject)hasInputAuthority;
				}
				else
				{
					networkObject = null;
				}
			}
			else
			{
				obj7 = 0;
			}
			goto IL_01c0;
		}
		return 0;
		IL_01c0:
		bool state = (byte)(obj7 & 1) != 0;
		bool input = (byte)(networkObject & 1) != 0;
		return AuthorityMasks.Create(state, input);
	}

	public void ReplicateTo(PlayerRef player, bool replicate)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected VT, but got Unknown
		PlayerRef player2 = (PlayerRef)(player & 0xFFFFFFFFL);
		base._runner.SetBehaviourReplicateTo(this, player2, replicate);
	}

	public void ReplicateToAll(bool replicate)
	{
		base._runner.SetBehaviourReplicateToAll(this, replicate);
	}

	public unsafe void CopyStateFrom(NetworkBehaviour source)
	{
		//IL_0295: Expected Obj, but got I
		//IL_02af: Expected Obj, but got I
		//IL_02de: Expected Obj, but got I
		//IL_0315: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I4
		//IL_0337: Expected I4, but got I8
		//IL_036b: Expected I4, but got I8
		//IL_013f: Expected Obj, but got I
		//IL_014d: Expected VT, but got I
		//IL_0161: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I4
		//IL_01ec: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I
		//IL_01bb: Expected Obj, but got I4
		//IL_0250: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59F0]");
		object error = 0;
		NetworkObject networkObject = base._object;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		bool condition;
		if ((object)base._object != null)
		{
			object obj2 = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
			bool flag = obj2 == null;
			condition = flag;
		}
		else
		{
			condition = false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59E8]");
		object error2 = 0;
		Assert.Check(condition, (string)error);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool condition2 = source;
		Assert.Check(condition2, (string)error2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v7+E8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type type = default;
		Type type2 = default;
		if (!(type == type2))
		{
			return;
		}
		if ((int)(WordCount & 0x80000000L) != 0)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		if ((int)(source.WordCount & 0x80000000L) != 0)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59E0]");
		object obj8 = 0;
		ReadOnlySpan<int> span = (Span<int>)source.Ptr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59D8]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X23_v3+38]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X23_v3+38]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			}
		}
		object obj13 = WordCount - source.WordCount;
		bool condition3 = obj13 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D28]");
		object obj14 = 0;
		Assert.Check(condition3, source.WordCount, WordCount);
		if (source.WordCount != 0)
		{
			ref int reference = ref MemoryMarshal.GetReference((Span<int>)Ptr);
			ref int reference2 = ref MemoryMarshal.GetReference(span);
			int num = source.WordCount << 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		}
	}

	public override void FixedUpdateNetwork()
	{
	}

	public unsafe void ResetState()
	{
		//IL_00ef: Expected Obj, but got I
		//IL_0018: Expected Obj, but got I4
		//IL_00ab: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I4
		//IL_016f: Expected I8, but got I4
		while (true)
		{
			NetworkObject networkObject = base._object;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59F0]");
			object error = 0;
			bool condition;
			if ((object)base._object != null)
			{
				object obj = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
				bool flag = obj == null;
				condition = flag;
			}
			else
			{
				condition = false;
			}
			Assert.Check(condition, (string)error);
			int num = WordCount << 2;
			if (num != 0)
			{
				int num2 = num >> 30;
				bool flag2 = Ptr == null;
				object obj2 = !flag2;
				object obj3 = ~obj2;
				bool condition2 = obj3 == null && num2 == 0;
				Assert.Always(condition2, (nint)Ptr, num);
				UnsafeUtility.MemClear(Ptr, num);
			}
			nint num3 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v8 (Il2CppClass<Fusion.NetworkBehaviour>)+2B0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v8 (Il2CppClass<Fusion.NetworkBehaviour>)+2A8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v135 @ X3_v2 (should have been resolved before IL gen)");
		}
	}

	public virtual void CopyBackingFieldsToState(bool firstTime)
	{
	}

	public virtual void CopyStateToBackingFields()
	{
	}

	internal override void PreRender()
	{
		if (_onRenderCallbacksDetector != null)
		{
			NetworkBehaviourUtils.ChangeDetector.Enumerable enumerable = _onRenderCallbacksDetector.DetectChangesInternal(this, out NetworkBehaviourBuffer _, out NetworkBehaviourBuffer _, true);
		}
	}

	internal void PreSpawned()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5860]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type type = default;
		if (NetworkBehaviourUtils.ChangeDetector.HasChangeCallbacks(type))
		{
			NetworkBehaviourUtils.ChangeDetector changeDetector = GetChangeDetector((NetworkBehaviourUtils.ChangeDetector.Source)3, copyInitial: true);
			object obj4 = this + 96;
			obj4 = changeDetector;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj4;
			_ = 1;
		}
	}

	public virtual void Spawned()
	{
	}

	public virtual void Despawned(NetworkRunner runner, bool hasState)
	{
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe ref T ReinterpretState<T>(int offset = default(int)) where T : struct
	{
		//IL_0029: Expected Obj, but got I
		//IL_0188: Expected I4, but got I8
		//IL_0095: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6460]");
		object error = 0;
		bool flag = Ptr == null;
		bool condition = !flag;
		Assert.Check(condition, (string)error);
		if ((int)(WordCount & 0x80000000L) != 0)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		bool flag2 = WordCount < offset;
		object obj = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6468]");
		object obj2 = 0;
		object obj3 = obj2;
		if (obj == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X23_v1+20]");
		object obj4 = (nint)0 + (nint)309;
		object obj5 = obj4 & 1;
		bool flag3 = obj5 == null;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		if (WordCount != offset)
		{
			return ref *(T*)((byte*)Ptr + offset);
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return ref *(T*)ex;
	}

	public BehaviourReader<T> GetBehaviourReader<T>(string property) where T : NetworkBehaviour
	{
		//IL_005a: Expected VT, but got Obj
		if ((object)this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D0DD8");
			BehaviourReader<T> result = default;
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (BehaviourReader<T>)ex;
	}

	public static BehaviourReader<T> GetBehaviourReader<T>(NetworkRunner runner, Type behaviourType, string property) where T : NetworkBehaviour
	{
		//IL_0026: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		PropertyReader<NetworkBehaviourId> propertyReader = GetPropertyReader<NetworkBehaviourId>(behaviourType, property);
		return (BehaviourReader<T>)runner;
	}

	public static BehaviourReader<TProperty> GetBehaviourReader<TBehaviour, TProperty>(NetworkRunner runner, string property) where TBehaviour : NetworkBehaviour where TProperty : NetworkBehaviour
	{
		//IL_0033: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I4
		//IL_0089: Expected VT, but got I
		//IL_00a9: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		PropertyReader<NetworkBehaviourId> propertyReader = GetPropertyReader<NetworkBehaviourId>(typeFromHandle, property);
		return (BehaviourReader<TProperty>)runner;
	}

	public PropertyReader<T> GetPropertyReader<T>(string property) where T : struct
	{
		//IL_0061: Expected VT, but got Obj
		if ((object)this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
			Type behaviourType = default;
			return GetPropertyReader<T>(behaviourType, property);
		}
		NullReferenceException ex = new NullReferenceException();
		return (PropertyReader<T>)ex;
	}

	public static PropertyReader<TProperty> GetPropertyReader<TBehaviour, TProperty>(string property) where TBehaviour : NetworkBehaviour where TProperty : struct
	{
		//IL_0056: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I4
		//IL_002a: Expected VT, but got I
		//IL_003c: Expected Obj, but got I
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X9_v2+E8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			nint num = 0;
			object obj4 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v51 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	public unsafe static PropertyReader<T> GetPropertyReader<T>(Type behaviourType, string property) where T : struct
	{
		//IL_05c9: Expected Obj, but got I
		//IL_05f3: Expected Obj, but got I4
		//IL_0679: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_006e: Expected I, but got Obj
		//IL_007e: Expected Obj, but got Ref
		//IL_009c: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I4
		//IL_0104: Expected VT, but got Obj
		//IL_0120: Expected Obj, but got I4
		//IL_0128: Expected I, but got Obj
		//IL_0135: Expected Obj, but got Ref
		//IL_05b9: Expected VT, but got Obj
		//IL_014b: Expected I, but got Obj
		//IL_0178: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01dd: Expected Obj, but got I
		//IL_01ff: Expected Obj, but got I4
		//IL_0225: Expected VT, but got Obj
		//IL_0241: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got Ref
		//IL_01c3: Expected Obj, but got I
		//IL_061b: Expected Obj, but got I4
		//IL_0264: Expected I, but got Obj
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_0308: Expected VT, but got Obj
		//IL_0639: Expected Obj, but got I
		//IL_065b: Expected Obj, but got I4
		//IL_0334: Expected VT, but got I
		//IL_02c6: Expected Obj, but got I
		//IL_02d6: Expected Obj, but got I
		//IL_02e6: Expected Obj, but got I
		//IL_04cb: Expected I4, but got VT
		//IL_04d1: Expected VT, but got I4
		//IL_0383: Expected Obj, but got I4
		//IL_0388: Expected I, but got Obj
		//IL_0398: Expected Obj, but got Ref
		//IL_03cd: Expected Obj, but got I4
		//IL_0417: Expected I, but got Obj
		//IL_0434: Expected Obj, but got I
		//IL_0456: Expected Obj, but got I4
		//IL_047a: Expected VT, but got I
		//IL_048b: Expected Obj, but got I4
		//IL_03fc: Expected I, but got Obj
		//IL_04a8: Expected I, but got Obj
		//IL_054f: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CC8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+A0]");
		object obj4 = 0;
		bool flag2 = obj4 == null;
		string text = property;
		NetworkPropertyMeta propertyMeta;
		Type type3;
		if (!flag2)
		{
			bool flag3 = ((NetworkTypesMeta)obj4).TryGetPropertyMeta(behaviourType, property, out propertyMeta);
			bool flag4 = !flag3;
			object obj5 = 0;
			nint num = (nint)property;
			text = (string)(object)behaviourType;
			object obj6 = (object)(&propertyMeta);
			if (flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string format = default;
				string paramName = string.Format(format, property, behaviourType);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentOutOfRangeException ex = default;
				string message = default;
				ex._002Ector(paramName, message);
				goto IL_05ab;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X24_v5+E8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8068]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v25+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj9);
			bool flag6 = (object)typeFromHandle == null;
			obj5 = 0;
			num = (nint)property;
			text = null;
			obj6 = (object)(&propertyMeta);
			if (!flag6)
			{
				nint num2 = (nint)typeFromHandle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v12 (Il2CppClass<System.Type>)+2A0]");
				num = 0;
				Type elementType = ((System.RuntimeType)typeFromHandle).GetElementType();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X24_v5+E8]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v69+E4]");
				object obj12 = 0;
				object obj13 = elementType & 1;
				object obj14;
				Type type2;
				if (obj13 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8060]");
					obj14 = 0;
					Type type = null;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5848]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v69+E4]");
					bool flag7 = (nint)0 == 0;
					object obj16 = !flag7;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj15);
					bool flag8 = (object)typeFromHandle2 == null;
					obj5 = 0;
					text = null;
					obj6 = (object)(&propertyMeta);
					if (flag8)
					{
						goto IL_04d1;
					}
					nint num3 = (nint)typeFromHandle2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v25 (Il2CppClass<System.Type>)+2A0]");
					num = 0;
					Type elementType2 = ((System.RuntimeType)typeFromHandle2).GetElementType();
					object obj17 = elementType2 & 1;
					bool flag9 = obj17 == null;
					type2 = null;
					type3 = null;
					if (flag9)
					{
						goto IL_0629;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X24_v5+E8]");
					obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8058]");
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v69+E4]");
					obj12 = 0;
					Type type = null;
				}
				bool flag10 = obj12 == null;
				object obj18 = !flag10;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj14);
				type2 = null;
				type3 = typeFromHandle3;
				goto IL_0629;
			}
		}
		goto IL_04d1;
		IL_05ab:
		ArgumentNullException ex2 = new ArgumentNullException();
		return (PropertyReader<T>)ex2;
		IL_0629:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X24_v5+E8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v32+E4]");
		bool flag11 = (nint)0 == 0;
		object obj20 = !flag11;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle4 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		if (type3 != typeFromHandle4)
		{
			bool flag12 = (object)type3 == null;
			object obj5 = 0;
			nint num = unchecked((nint)null);
			text = (string)(object)typeFromHandle4;
			object obj6 = (object)(&propertyMeta);
			if (flag12)
			{
				goto IL_04d1;
			}
			bool isByRef = type3.IsByRef;
			bool flag13 = !isByRef;
			object obj21 = !flag13;
			nint num4;
			Type type4;
			if (obj21 == null)
			{
				bool isPointer = type3.IsPointer;
				bool flag14 = !isPointer;
				num4 = unchecked((nint)null);
				type4 = null;
				if (flag14)
				{
					goto IL_053e;
				}
			}
			nint num5 = (nint)type3;
			bool isEnum = ((System.RuntimeType)type3).IsEnum;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X24_v5+E8]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v21+E4]");
			bool flag15 = (nint)0 == 0;
			object obj23 = !flag15;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			bool flag16 = (Type)isEnum == typeFromHandle5;
			bool flag17 = !flag16;
			num4 = unchecked((nint)null);
			type4 = typeFromHandle5;
			if (flag17)
			{
				goto IL_053e;
			}
		}
		PropertyReader<T> propertyReader = new PropertyReader<T>((int)propertyMeta);
		return (PropertyReader<T>)0;
		IL_04d1:
		throw new NullReferenceException();
		IL_053e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1648");
		Type typeFromHandle6 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string format2 = default;
		string message2 = string.Format(format2, property, behaviourType, typeFromHandle6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		InvalidOperationException ex3 = default;
		ex3._002Ector(message2);
		goto IL_05ab;
	}

	public ArrayReader<T> GetArrayReader<T>(string property)
	{
		//IL_00ab: Expected VT, but got Obj
		//IL_004a: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		if ((object)this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
			nint num = 0;
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num2 = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr = default;
				num2 = intPtr;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v42 @ X8_v3 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
		NullReferenceException ex = new NullReferenceException();
		return (ArrayReader<T>)ex;
	}

	public unsafe static ArrayReader<T> GetArrayReader<T>(Type behaviourType, string property, IElementReaderWriter<T> readerWriter = null)
	{
		//IL_02a1: Expected Obj, but got I
		//IL_02cb: Expected Obj, but got I4
		//IL_0306: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I4
		//IL_00d1: Expected VT, but got I
		//IL_0102: Expected Obj, but got I4
		//IL_0291: Expected VT, but got Obj
		//IL_0227: Expected VT, but got I
		//IL_012a: Expected Obj, but got I4
		//IL_02e7: Expected Obj, but got Ref
		//IL_0150: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CC8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+A0]");
		object obj4 = 0;
		string text = default;
		if (((NetworkTypesMeta)obj4).TryGetPropertyMeta(behaviourType, text, out NetworkPropertyMeta _))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X25_v3+E8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v24+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			bool flag3 = null != typeFromHandle;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				IElementReaderWriter<T> elementReaderWriter = default;
				bool flag5 = elementReaderWriter == null;
				object obj9 = !flag5;
				IElementReaderWriter<T> elementReaderWriter2 = elementReaderWriter;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E30]");
					object obj10 = 0;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v46+E4]");
					bool flag6 = (nint)0 == 0;
					object obj12 = !flag6;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ X1_v15 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
					IElementReaderWriter<T> elementReaderWriter3 = default;
					elementReaderWriter2 = elementReaderWriter3;
				}
				ArrayReader<T> result = default;
				object obj13 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref result, 8));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1648");
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format = default;
			string message = string.Format(format, text, behaviourType, typeFromHandle2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			InvalidOperationException ex = default;
			ex._002Ector(message);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format2 = default;
			string paramName = string.Format(format2, text, behaviourType);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentOutOfRangeException ex2 = default;
			string message2 = default;
			ex2._002Ector(paramName, message2);
		}
		ArgumentNullException ex3 = new ArgumentNullException();
		return (ArrayReader<T>)ex3;
	}

	public LinkListReader<T> GetLinkListReader<T>(string property)
	{
		//IL_00ab: Expected VT, but got Obj
		//IL_004a: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		if ((object)this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
			nint num = 0;
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num2 = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr = default;
				num2 = intPtr;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v42 @ X8_v3 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
		NullReferenceException ex = new NullReferenceException();
		return (LinkListReader<T>)ex;
	}

	public unsafe static LinkListReader<T> GetLinkListReader<T>(Type behaviourType, string property, IElementReaderWriter<T> readerWriter = null)
	{
		//IL_02a1: Expected Obj, but got I
		//IL_02cb: Expected Obj, but got I4
		//IL_0306: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I4
		//IL_00d1: Expected VT, but got I
		//IL_0102: Expected Obj, but got I4
		//IL_0291: Expected VT, but got Obj
		//IL_0227: Expected VT, but got I
		//IL_012a: Expected Obj, but got I4
		//IL_02e7: Expected Obj, but got Ref
		//IL_0150: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CC8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+A0]");
		object obj4 = 0;
		string text = default;
		if (((NetworkTypesMeta)obj4).TryGetPropertyMeta(behaviourType, text, out NetworkPropertyMeta _))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X25_v3+E8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v24+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			bool flag3 = null != typeFromHandle;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				IElementReaderWriter<T> elementReaderWriter = default;
				bool flag5 = elementReaderWriter == null;
				object obj9 = !flag5;
				IElementReaderWriter<T> elementReaderWriter2 = elementReaderWriter;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E30]");
					object obj10 = 0;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v46+E4]");
					bool flag6 = (nint)0 == 0;
					object obj12 = !flag6;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ X1_v15 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
					IElementReaderWriter<T> elementReaderWriter3 = default;
					elementReaderWriter2 = elementReaderWriter3;
				}
				LinkListReader<T> result = default;
				object obj13 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref result, 8));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1648");
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format = default;
			string message = string.Format(format, text, behaviourType, typeFromHandle2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			InvalidOperationException ex = default;
			ex._002Ector(message);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format2 = default;
			string paramName = string.Format(format2, text, behaviourType);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentOutOfRangeException ex2 = default;
			string message2 = default;
			ex2._002Ector(paramName, message2);
		}
		ArgumentNullException ex3 = new ArgumentNullException();
		return (LinkListReader<T>)ex3;
	}

	public DictionaryReader<K, V> GetDictionaryReader<K, V>(string property)
	{
		//IL_00c2: Expected VT, but got Obj
		//IL_004a: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_0100: Expected Obj, but got I4
		if ((object)this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
			nint num = 0;
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num2 = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr = default;
				num2 = intPtr;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			object obj4 = (nint)0 + (nint)309;
			object obj5 = obj4 & 1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			nint num3 = 0;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr2 = default;
				num3 = intPtr2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ X8_v2 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
			object obj8 = default;
			object obj7 = obj8;
			_ = 0;
			DictionaryReader<K, V> result = default;
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (DictionaryReader<K, V>)ex;
	}

	public unsafe static DictionaryReader<K, V> GetDictionaryReader<K, V>(Type behaviourType, string property, IElementReaderWriter<K> keyReaderWriter = null, IElementReaderWriter<V> valueReaderWriter = null)
	{
		//IL_0315: Expected Obj, but got I
		//IL_033f: Expected Obj, but got I4
		//IL_03cf: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I4
		//IL_00d1: Expected VT, but got I
		//IL_0102: Expected Obj, but got I4
		//IL_0305: Expected VT, but got Obj
		//IL_029b: Expected VT, but got I
		//IL_012a: Expected Obj, but got I4
		//IL_035b: Expected Obj, but got Ref
		//IL_037f: Expected Obj, but got I4
		//IL_03a3: Expected Obj, but got Ref
		//IL_0150: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I4
		//IL_01c4: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CC8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v4+A0]");
		object obj4 = 0;
		string text = default;
		if (((NetworkTypesMeta)obj4).TryGetPropertyMeta(behaviourType, text, out NetworkPropertyMeta _))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X27_v3+E8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v24+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			bool flag3 = null != typeFromHandle;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				IElementReaderWriter<K> elementReaderWriter = default;
				bool flag5 = elementReaderWriter == null;
				object obj9 = !flag5;
				IElementReaderWriter<K> elementReaderWriter2 = elementReaderWriter;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E30]");
					object obj10 = 0;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v53+E4]");
					bool flag6 = (nint)0 == 0;
					object obj12 = !flag6;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ X1_v17 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
					IElementReaderWriter<K> elementReaderWriter3 = default;
					elementReaderWriter2 = elementReaderWriter3;
				}
				object obj14 = default;
				object obj13 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj14, 8));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				IElementReaderWriter<V> elementReaderWriter4 = default;
				bool flag7 = elementReaderWriter4 == null;
				object obj15 = !flag7;
				IElementReaderWriter<V> elementReaderWriter5 = elementReaderWriter4;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E30]");
					object obj16 = 0;
					object obj17 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v48+E4]");
					bool flag8 = (nint)0 == 0;
					object obj18 = !flag8;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v226 @ X1_v16 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
					IElementReaderWriter<V> elementReaderWriter6 = default;
					elementReaderWriter5 = elementReaderWriter6;
				}
				object obj19 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj14, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj20 = obj14;
				DictionaryReader<K, V> result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1648");
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format = default;
			string message = string.Format(format, text, behaviourType, typeFromHandle2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			InvalidOperationException ex = default;
			ex._002Ector(message);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format2 = default;
			string paramName = string.Format(format2, text, behaviourType);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentOutOfRangeException ex2 = default;
			string message2 = default;
			ex2._002Ector(paramName, message2);
		}
		ArgumentNullException ex3 = new ArgumentNullException();
		return (DictionaryReader<K, V>)ex3;
	}

	public NetworkBehaviourUtils.ChangeDetector GetChangeDetector(NetworkBehaviourUtils.ChangeDetector.Source source, bool copyInitial = default(bool))
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5860]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			((NetworkBehaviourUtils.ChangeDetector)obj2).Init(this, source, copyInitial);
			return (NetworkBehaviourUtils.ChangeDetector)obj2;
		}
		return (NetworkBehaviourUtils.ChangeDetector)(object)new NullReferenceException();
	}

	public bool TryGetSnapshotsBuffers(out NetworkBehaviourBuffer from, out NetworkBehaviourBuffer to, out float alpha)
	{
		//IL_0020: Invalid comparison between VT and I4
		//IL_0067: Invalid comparison between VT and I4
		//IL_00c6: Expected Obj, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected I4, but got Unknown
		RenderTimeline.GetRenderBuffers(this, out from, out to, out alpha);
		if (from != (NetworkBehaviourBuffer)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [from @ X1 (Fusion.NetworkBehaviourBuffer&)+8]");
			if ((nint)0 >= (nint)1 && to != (NetworkBehaviourBuffer)(object)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [to @ X2 (Fusion.NetworkBehaviourBuffer&)+8]");
				bool flag = (nint)0 < (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [to @ X2 (Fusion.NetworkBehaviourBuffer&)+8]");
				bool flag2 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [to @ X2 (Fusion.NetworkBehaviourBuffer&)+8]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [to @ X2 (Fusion.NetworkBehaviourBuffer&)+8]");
				object obj = num ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [to @ X2 (Fusion.NetworkBehaviourBuffer&)+8]");
				object obj2 = 0 & obj;
				bool flag3 = (nint)obj2 < 0;
				bool flag4 = flag == flag3;
				object obj3 = !flag2;
				return (byte)((flag4 & obj3) ? 1 : 0) != 0;
			}
		}
		return false;
	}

	protected virtual bool ReplicateTo(PlayerRef player)
	{
		return true;
	}

	public unsafe T? GetInput<T>() where T : struct, INetworkInput
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0025: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I4
		//IL_046d: Expected Obj, but got I
		//IL_0483: Expected Obj, but got I
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_04a2: Expected Obj, but got Ref
		//IL_04af: Expected VT, but got Ref
		//IL_04d5: Expected Obj, but got I
		//IL_04de: Expected VT, but got I4
		//IL_0432: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I4
		//IL_03e6: Expected Obj, but got I
		//IL_03f6: Expected Obj, but got VT
		//IL_04fc: Expected Obj, but got I
		//IL_0526: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got I
		//IL_0155: Expected VT, but got I4
		//IL_01b0: Expected Obj, but got I
		//IL_01b9: Expected VT, but got I4
		//IL_01c6: Expected I4, but got Obj
		//IL_0205: Expected Obj, but got I
		//IL_020e: Expected VT, but got I4
		//IL_021b: Expected I4, but got Obj
		//IL_0246: Expected VT, but got I
		//IL_0260: Expected VT, but got I
		//IL_032f: Expected Obj, but got I
		//IL_033d: Expected Obj, but got Ref
		//IL_0353: Expected Obj, but got Ref
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X2+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X2+38]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X2+38]");
			obj3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+FC]");
		object obj6 = (nint)0 + (nint)15;
		object obj7 = obj6 & 0x1FFFFFFF0L;
		object obj9 = default;
		object obj8 = (ref *(byte*)(&obj9)) - (ref *(byte*)obj7);
		PlayerRef playerRef = (PlayerRef)((ref *(byte*)(&obj9)) - (ref *(byte*)obj7));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		bool flag2 = (object)this == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+FC]");
		NetworkRunner networkRunner = (NetworkRunner)0;
		PlayerRef playerRef2 = (PlayerRef)0;
		bool flag5 = default;
		if (!flag2)
		{
			NetworkObject networkObject = base._object;
			if ((object)base._object != null)
			{
				object obj10 = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
				bool flag3 = obj10 == null;
				object obj11 = !flag3;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj12 = 0;
					object obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v19+E4]");
					bool flag4 = (nint)0 == 0;
					object obj14 = !flag4;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					flag5 = networkObject._runner;
					if (flag5)
					{
						NetworkRunner runner = networkObject._runner;
						bool flag6 = (object)networkObject._runner == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+FC]");
						networkRunner = (NetworkRunner)0;
						playerRef2 = (PlayerRef)0;
						if (!flag6)
						{
							if ((object)runner._simulation == null)
							{
								goto IL_0383;
							}
							NetworkObject networkObject2 = base._object;
							bool flag7 = (object)base._object == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+FC]");
							networkRunner = (NetworkRunner)0;
							playerRef2 = (PlayerRef)0;
							flag5 = (byte)(int)runner._simulation != 0;
							if (!flag7)
							{
								NetworkObjectMeta meta = networkObject2.Meta;
								bool flag8 = networkObject2.Meta == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+FC]");
								networkRunner = (NetworkRunner)0;
								playerRef2 = (PlayerRef)0;
								flag5 = (byte)(int)runner._simulation != 0;
								if (!flag8)
								{
									int* ptr = meta._ptr;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v22 (System.Int32*)+1C]");
									playerRef2 = (PlayerRef)0;
									Simulation simulation = runner._simulation;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v22 (System.Int32*)+1C]");
									flag5 = simulation.PlayerValid((PlayerRef)0);
									if (!flag5)
									{
										goto IL_0383;
									}
									NetworkObject networkObject3 = base._object;
									bool flag9 = (object)base._object == null;
									networkRunner = null;
									if (!flag9)
									{
										NetworkObjectMeta meta2 = networkObject3.Meta;
										bool flag10 = networkObject3.Meta == null;
										networkRunner = null;
										if (!flag10)
										{
											networkRunner = networkObject3._runner;
											if ((object)networkObject3._runner != null)
											{
												int* ptr2 = meta2._ptr;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X2+38]");
												object obj15 = 0;
												object obj16 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
												object obj17 = obj15;
												object obj18 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v24 (System.Int32*)+1C]");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v266 @ X1_v12+10] (should have been resolved before IL gen)");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
												goto IL_039c;
											}
										}
									}
								}
							}
						}
						goto IL_0409;
					}
				}
			}
			goto IL_0383;
		}
		goto IL_0409;
		IL_044e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		T? result = default;
		return result;
		IL_0383:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		goto IL_039c;
		IL_0409:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		bool flag11 = num != 0;
		NullReferenceException ex = (NullReferenceException)flag5;
		if (!flag11)
		{
			ex = new NullReferenceException();
		}
		goto IL_044e;
		IL_039c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		bool flag12 = num2 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+FC]");
		networkRunner = (NetworkRunner)0;
		playerRef2 = playerRef;
		T? val = default;
		ex = (NullReferenceException)val;
		if (!flag12)
		{
			return val;
		}
		goto IL_044e;
	}

	public unsafe bool GetInput<T>(out T input) where T : struct, INetworkInput
	{
		//IL_0267: Expected I4, but got Obj
		//IL_0056: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I
		//IL_02bb: Expected Obj, but got I4
		//IL_0191: Expected VT, but got I
		if ((object)this != null)
		{
			nint num = 0;
			NetworkObject networkObject = base._object;
			if ((object)base._object != null)
			{
				object obj = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj3 = 0;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v9+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((bool)networkObject._runner)
					{
						NetworkRunner runner = networkObject._runner;
						if ((object)networkObject._runner != null)
						{
							if ((object)runner._simulation == null)
							{
								goto IL_0249;
							}
							NetworkObject networkObject2 = base._object;
							if ((object)base._object != null)
							{
								NetworkObjectMeta meta = networkObject2.Meta;
								if (networkObject2.Meta != null)
								{
									int* ptr = meta._ptr;
									Simulation simulation = runner._simulation;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v15 (System.Int32*)+1C]");
									if (!simulation.PlayerValid((PlayerRef)0))
									{
										goto IL_0249;
									}
									NetworkObject networkObject3 = base._object;
									if ((object)base._object != null)
									{
										NetworkObjectMeta meta2 = networkObject3.Meta;
										if (networkObject3.Meta != null && (object)networkObject3._runner != null)
										{
											int* ptr2 = meta2._ptr;
											nint num2 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v117 @ X3_v1 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
											goto IL_0249;
										}
									}
								}
							}
						}
						goto IL_0259;
					}
				}
			}
			goto IL_0249;
		}
		goto IL_0259;
		IL_0259:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0249:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		return false;
	}

	public unsafe static int NetworkSerialize(NetworkRunner runner, NetworkBehaviour obj, byte* data)
	{
		//IL_003f: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (int)ex2;
	}

	public unsafe static int NetworkDeserialize(NetworkRunner runner, byte* data, ref NetworkBehaviour result)
	{
		//IL_003f: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (int)ex2;
	}

	public static NetworkBehaviourId NetworkWrap(NetworkRunner runner, NetworkBehaviour obj)
	{
		return NetworkWrap(obj);
	}

	public unsafe static NetworkBehaviourId NetworkWrap(NetworkBehaviour obj)
	{
		//IL_012e: Expected I, but got Obj
		//IL_0194: Expected VT, but got I
		//IL_0030: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_011b: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I8
		//IL_0138: Expected I, but got Obj
		nint num;
		int num2;
		if ((object)obj != null)
		{
			object obj2 = obj.Flags & (SimulationBehaviourRuntimeFlags)8;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				NetworkObject networkObject = ((SimulationBehaviour)obj)._object;
				if ((object)((SimulationBehaviour)obj)._object != null)
				{
					object obj4 = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
					bool flag2 = obj4 == null;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						int* ptr = networkObject.Ptr;
						if (networkObject.Ptr != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X21_v6 (System.Int32*)+4]");
							object obj6 = 0 & -9223372036854775808L;
							if (obj6 != null)
							{
								System.ThrowHelper.ThrowArgumentOutOfRangeException();
							}
						}
						Span<int> span = default;
						if (span.IsEmpty)
						{
							num = unchecked((nint)null);
						}
						else
						{
							int* ptr2 = networkObject.Ptr;
							num = (nint)ptr2;
						}
						num2 = obj.ObjectIndex << 32;
						goto IL_0187;
					}
				}
			}
			num2 = 0;
			num = unchecked((nint)null);
		}
		else
		{
			num2 = 0;
			num = unchecked((nint)null);
		}
		goto IL_0187;
		IL_0187:
		return (NetworkBehaviourId)(num2 | num);
	}

	public static NetworkBehaviour NetworkUnwrap(NetworkRunner runner, NetworkBehaviourId wrapper)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0217: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected VT, but got Unknown
		//IL_003f: Invalid comparison between VT and I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got VT
		//IL_0151: Expected Obj, but got I4
		//IL_01a2: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetworkId networkId = (NetworkId)(wrapper & 0xFFFFFFFFL);
		if (networkId == (NetworkId)(object)0)
		{
			goto IL_01c7;
		}
		if ((object)runner != null)
		{
			if (!runner.TryFindObject(networkId, out var networkObject))
			{
				runner.InvokeFailedToResolveNetworkObject(networkId);
				goto IL_01c7;
			}
			object obj4 = wrapper & -9223372036854775808L;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				goto IL_01b9;
			}
			if ((object)networkObject != null)
			{
				NetworkBehaviour[] networkedBehaviours = networkObject.NetworkedBehaviours;
				if (networkObject.NetworkedBehaviours != null)
				{
					object obj6 = wrapper >> 32;
					bool flag3 = (nint)obj6 < networkedBehaviours.Length;
					object obj7 = !flag3;
					if ((nint)obj6 >= networkedBehaviours.Length)
					{
						goto IL_01b9;
					}
					if (obj7 == null)
					{
						object obj8 = (object)networkObject.NetworkedBehaviours + obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v11+20]");
						return (NetworkBehaviour)0;
					}
					goto IL_01df;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_01df;
		IL_01df:
		return (NetworkBehaviour)(object)new IndexOutOfRangeException();
		IL_01c7:
		return null;
		IL_01b9:
		NetworkBehaviourUtils.NotifyNetworkUnwrapFailed(wrapper);
		goto IL_01c7;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static implicit operator NetworkBehaviourId(NetworkBehaviour behaviour)
	{
		//IL_0086: Expected VT, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I4
		//IL_0078: Expected VT, but got I4
		if ((object)behaviour == null)
		{
			NullReferenceException ex = new NullReferenceException();
			return (NetworkBehaviourId)ex;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((bool)((SimulationBehaviour)behaviour)._runner)
		{
			return NetworkWrap(behaviour);
		}
		return (NetworkBehaviourId)0;
	}

	protected internal static void InvokeWeavedCode()
	{
	}

	public unsafe static ref T MakeRef<T>() where T : struct
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		NotImplementedException ex = default;
		string message = default;
		ex._002Ector(message);
		ArgumentNullException ex2 = new ArgumentNullException();
		return ref *(T*)ex2;
	}

	public unsafe static ref T MakeRef<T>(T defaultValue) where T : struct
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		NotImplementedException ex = default;
		string message = default;
		ex._002Ector(message);
		ArgumentNullException ex2 = new ArgumentNullException();
		return ref *(T*)ex2;
	}

	public unsafe static T* MakePtr<T>() where T : struct
	{
		//IL_0043: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		NotImplementedException ex = default;
		string message = default;
		ex._002Ector(message);
		ArgumentNullException ex2 = new ArgumentNullException();
		return (T*)(nint)ex2;
	}

	public unsafe static T* MakePtr<T>(T defaultValue) where T : struct
	{
		//IL_0043: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		NotImplementedException ex = default;
		string message = default;
		ex._002Ector(message);
		ArgumentNullException ex2 = new ArgumentNullException();
		return (T*)(nint)ex2;
	}

	public static NetworkBehaviourUtils.ArrayInitializer<T> MakeInitializer<T>(T[] array)
	{
		//IL_0043: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		NotImplementedException ex = default;
		string message = default;
		ex._002Ector(message);
		ArgumentNullException ex2 = new ArgumentNullException();
		return (NetworkBehaviourUtils.ArrayInitializer<T>)ex2;
	}

	public static NetworkMecanimAnimator.DictionaryInitializer<K, V> MakeInitializer<K, V>(Dictionary<K, V> dictionary)
	{
		//IL_0043: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		NotImplementedException ex = default;
		string message = default;
		ex._002Ector(message);
		ArgumentNullException ex2 = new ArgumentNullException();
		return (NetworkMecanimAnimator.DictionaryInitializer<K, V>)ex2;
	}

	internal void MakeOwned(NetworkRunner runner, NetworkObject obj, int index)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		object obj2 = this + 56;
		obj2 = runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = this + 64;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal new void MakeUnowned()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I4
		object obj = this + 56;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = this + 64;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 0;
	}

	private int Fusion_002EIElementReaderWriter_003CFusion_002ENetworkBehaviour_003E_002EGetElementHashCode(NetworkBehaviour element)
	{
		NetworkBehaviourId networkBehaviourId = NetworkWrap(element);
		NetworkBehaviourId networkBehaviourId2 = default;
		return networkBehaviourId2.GetHashCode();
	}

	private int Fusion_002EIElementReaderWriter_003CFusion_002ENetworkBehaviour_003E_002EGetElementWordCount()
	{
		return 2;
	}

	private unsafe NetworkBehaviour Fusion_002EIElementReaderWriter_003CFusion_002ENetworkBehaviour_003E_002ERead(byte* data, int index)
	{
		//IL_0025: Expected VT, but got I
		int num = index << 3;
		NetworkRunner runner = base._runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (System.Byte*)+v0 @ X8_v1 (System.Int32)]");
		return NetworkUnwrap(runner, (NetworkBehaviourId)0);
	}

	private unsafe ref NetworkBehaviour Fusion_002EIElementReaderWriter_003CFusion_002ENetworkBehaviour_003E_002EReadRef(byte* data, int index)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		NotSupportedException ex = default;
		string message = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return ref *(NetworkBehaviour*)ex2;
	}

	private unsafe void Fusion_002EIElementReaderWriter_003CFusion_002ENetworkBehaviour_003E_002EWrite(byte* data, int index, NetworkBehaviour element)
	{
		NetworkBehaviourId networkBehaviourId = NetworkWrap(element);
		int num = index << 3;
	}

	private int Fusion_002EIElementReaderWriter_003CFusion_002ENetworkObject_003E_002EGetElementWordCount()
	{
		return 1;
	}

	private int Fusion_002EIElementReaderWriter_003CFusion_002ENetworkObject_003E_002EGetElementHashCode(NetworkObject element)
	{
		//IL_0010: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj = 0;
		NetworkId networkId = NetworkObject.NetworkWrap(element);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetworkId networkId2 = default;
		return networkId2.GetHashCode();
	}

	private unsafe NetworkObject Fusion_002EIElementReaderWriter_003CFusion_002ENetworkObject_003E_002ERead(byte* data, int index)
	{
		//IL_0029: Expected VT, but got I
		int num = index << 2;
		NetworkRunner runner = base._runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (System.Byte*)+v3 @ X8_v1 (System.Int32)]");
		NetworkObject result = default;
		NetworkObject.NetworkUnwrap(runner, (NetworkId)0, ref result);
		return result;
	}

	private unsafe ref NetworkObject Fusion_002EIElementReaderWriter_003CFusion_002ENetworkObject_003E_002EReadRef(byte* data, int index)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		NotSupportedException ex = default;
		string message = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return ref *(NetworkObject*)ex2;
	}

	private unsafe void Fusion_002EIElementReaderWriter_003CFusion_002ENetworkObject_003E_002EWrite(byte* data, int index, NetworkObject element)
	{
		NetworkId networkId = NetworkObject.NetworkWrap(element);
		int num = index << 2;
	}

	protected NetworkBehaviour()
	{
		Flags = (SimulationBehaviourRuntimeFlags)16;
		((Behaviour)this)._002Ector();
	}
}
