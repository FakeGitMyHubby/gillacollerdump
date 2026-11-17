using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion.Sockets;
using UnityEngine.UIElements;

namespace Fusion;

[Serializable]
[StructLayout((LayoutKind)2, Size = 4)]
public struct PlayerRef : Action<UnityEngine.UIElements.Panel>, _0021_00210
{
	internal class DebuggerProxy<T>
	{
		internal class DebuggerProxy<V> : Dictionary<T, V>
		{
			internal class DebuggerProxy
			{
				[Serializable]
				public class ScriptableObjectData
				{
					public string UnityAssetPath;

					public string UnityAssetGuid;

					public long UnityFileId;

					public string Id;

					public string TypeName;

					public string Name;

					public string Data;

					public object UserData;
				}

				public Lazy<T[]> _items;

				public T[] Items
				{
					get
					{
						//IL_0035: Expected Obj, but got I
						//IL_0045: Expected Obj, but got I
						if (_items != null)
						{
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v1 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy+DebuggerProxy+DebuggerProxy>)+A8]");
							object obj = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X8_v2+48]");
							object obj2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v11 @ X1_v1+10] (should have been resolved before IL gen)");
							T[] result = default;
							return result;
						}
						return (T[])(object)new NullReferenceException();
					}
				}

				public unsafe DebuggerProxy(NetworkArray<T> array)
				{
					//IL_0016: Expected Obj, but got I
					//IL_0036: Expected Obj, but got I
					//IL_0046: Expected Obj, but got I
					//IL_0063: Unknown result type (might be due to invalid IL or missing references)
					//IL_0068: Expected Obj, but got Unknown
					//IL_0075: Expected Obj, but got I
					//IL_00a0: Expected Obj, but got I
					//IL_00c0: Expected Obj, but got I
					//IL_00d0: Expected Obj, but got I
					//IL_00f0: Expected Obj, but got I
					//IL_0115: Expected Obj, but got I
					//IL_0125: Expected Obj, but got I
					//IL_0135: Unknown result type (might be due to invalid IL or missing references)
					//IL_013a: Expected Obj, but got Unknown
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X8_v1 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy+DebuggerProxy+DebuggerProxy>)+A8]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v4 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy+DebuggerProxy+DebuggerProxy>)+A8]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v5+8]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ X1_v1] (should have been resolved before IL gen)");
					object obj5 = default;
					object obj4 = obj5 + 32;
					obj4 = (object)array._array;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					base._002Ector();
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v8 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy+DebuggerProxy+DebuggerProxy>)+A8]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v10 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy+DebuggerProxy+DebuggerProxy>)+A8]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v11+28]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ X3_v1] (should have been resolved before IL gen)");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v12 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy+DebuggerProxy+DebuggerProxy>)+A8]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v14 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy+DebuggerProxy+DebuggerProxy>)+A8]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v15+38]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ X2_v2] (should have been resolved before IL gen)");
					object obj12 = this + 16;
					object obj13 = default;
					obj12 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
			}

			public Lazy<KeyValuePair<T, V>[]> _items;

			public KeyValuePair<T, V>[] Items
			{
				get
				{
					//IL_003b: Expected Obj, but got I
					//IL_004b: Expected Obj, but got I
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.PlayerRef+DebuggerProxy<K>+DebuggerProxy<K, V>)+50]");
					if ((nint)0 != 0)
					{
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v1 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy+DebuggerProxy>)+A8]");
						object obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X8_v2+58]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v11 @ X1_v1+10] (should have been resolved before IL gen)");
						KeyValuePair<T, V>[] result = default;
						return result;
					}
					return (KeyValuePair<T, V>[])(object)new NullReferenceException();
				}
			}

			public unsafe DebuggerProxy(NetworkDictionary<T, V> dict)
			{
				//IL_0016: Expected Obj, but got I
				//IL_0036: Expected Obj, but got I
				//IL_0046: Expected Obj, but got I
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Expected Obj, but got Unknown
				//IL_00a6: Expected Obj, but got I
				//IL_00b6: Expected Obj, but got I
				//IL_00d6: Expected Obj, but got I
				//IL_00fb: Expected Obj, but got I
				//IL_010b: Expected Obj, but got I
				//IL_012b: Expected Obj, but got I
				//IL_014b: Expected Obj, but got I
				//IL_015b: Expected Obj, but got I
				//IL_016b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0170: Expected Obj, but got Unknown
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X8_v1 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy+DebuggerProxy>)+A8]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v4 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy+DebuggerProxy>)+A8]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v5+8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ X1_v1] (should have been resolved before IL gen)");
				object obj5 = default;
				object obj4 = obj5 + 56;
				_ = dict._keyOffset;
				_ = dict._entriesOffset;
				_ = dict._data;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v7 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy+DebuggerProxy>)+A8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v8+18]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ X1_v3] (should have been resolved before IL gen)");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v10 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy+DebuggerProxy>)+A8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v12 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy+DebuggerProxy>)+A8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v13+38]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v63 @ X3_v1] (should have been resolved before IL gen)");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v14 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy+DebuggerProxy>)+A8]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v16 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy+DebuggerProxy>)+A8]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v17+48]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ X2_v2] (should have been resolved before IL gen)");
				object obj14 = this + 80;
				object obj15 = default;
				obj14 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
		}

		public Lazy<T[]> _items;

		public T[] Items
		{
			get
			{
				//IL_0035: Expected Obj, but got I
				//IL_0045: Expected Obj, but got I
				if (_items != null)
				{
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v1 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy>)+A8]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X8_v2+48]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v11 @ X1_v1+10] (should have been resolved before IL gen)");
					T[] result = default;
					return result;
				}
				return (T[])(object)new NullReferenceException();
			}
		}

		public unsafe DebuggerProxy(NetworkLinkedList<T> list)
		{
			//IL_0016: Expected Obj, but got I
			//IL_0036: Expected Obj, but got I
			//IL_0046: Expected Obj, but got I
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected Obj, but got Unknown
			//IL_0075: Expected Obj, but got I
			//IL_00a0: Expected Obj, but got I
			//IL_00c0: Expected Obj, but got I
			//IL_00d0: Expected Obj, but got I
			//IL_00f0: Expected Obj, but got I
			//IL_0115: Expected Obj, but got I
			//IL_0125: Expected Obj, but got I
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Expected Obj, but got Unknown
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X8_v1 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy>)+A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v4 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy>)+A8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v5+8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ X1_v1] (should have been resolved before IL gen)");
			object obj5 = default;
			object obj4 = obj5 + 32;
			obj4 = (object)list._data;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v8 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy>)+A8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v10 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy>)+A8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v11+28]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ X3_v1] (should have been resolved before IL gen)");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v12 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy>)+A8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v14 (Il2CppClass<Fusion.PlayerRef+DebuggerProxy>)+A8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v15+38]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ X2_v2] (should have been resolved before IL gen)");
			object obj12 = this + 16;
			object obj13 = default;
			obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private static readonly IEqualityComparer<PlayerRef> Comparer__BackingField;

	private const int MASTER_CLIENT_RAW = default(int);

	private const uint SERIALIZATION_OFFSET = default(uint);

	internal const int INVALID_RAW = default(int);

	[FieldOffset(0)]
	internal int Raw;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_RAW = default(int);

	internal const int BYTE_COUNT_OF_RAW = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public static IEqualityComparer<PlayerRef> Comparer
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			return (IEqualityComparer<PlayerRef>)0;
		}
	}

	public static PlayerRef Invalid
	{
		get
		{
			//IL_000a: Expected VT, but got I8
			return (PlayerRef)4294967286L;
		}
	}

	public static PlayerRef None
	{
		get
		{
			//IL_0006: Expected VT, but got I4
			return (PlayerRef)0;
		}
	}

	public static PlayerRef InternalMasterClientIdentifier
	{
		get
		{
			//IL_000a: Expected VT, but got I8
			return (PlayerRef)4294967295L;
		}
	}

	public static PlayerRef MasterClient
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0058: Expected Obj, but got I4
			//IL_002e: Expected VT, but got I8
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return (PlayerRef)4294967295L;
		}
	}

	public bool IsRealPlayer
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_006a: Expected Obj, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected I4, but got Unknown
			bool flag = Raw < 0;
			bool flag2 = Raw == 0;
			int num = Raw ^ Raw;
			int num2 = Raw & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			return (byte)((flag4 & obj) ? 1 : 0) != 0;
		}
	}

	public bool IsNone
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			return Raw == 0;
		}
	}

	public bool IsInternalMasterClientIdentifier
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0010: Expected Obj, but got I4
			object obj = Raw + 1;
			return obj == null;
		}
	}

	public bool IsMasterClient
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0072: Expected Obj, but got I4
			//IL_0034: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = Raw + 1;
			return obj4 == null;
		}
	}

	public int RawEncoded => Raw;

	public int AsIndex => Raw - 1;

	public int PlayerId => Raw - 1;

	public bool IsInvalid
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_008c: Expected Obj, but got I4
			//IL_0034: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = Raw + 1;
			bool flag2 = (nint)obj4 < 0;
			bool flag3 = !flag2;
			return !flag3;
		}
	}

	public bool IsValid
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0048: Expected Obj, but got I4
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected I4, but got Unknown
			object obj = Raw + 2;
			bool flag = (nint)obj < 0;
			bool flag2 = obj == null;
			bool flag3 = !flag;
			object obj2 = !flag2;
			return (byte)((flag3 & obj2) ? 1 : 0) != 0;
		}
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj2 = 0;
			object obj3 = obj2;
			if (obj == obj2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int raw = Raw;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				object obj5 = (nint)raw - (nint)0;
				return obj5 == null;
			}
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)256)]
	public override int GetHashCode()
	{
		return Raw;
	}

	public override string ToString()
	{
		//IL_00eb: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I
		object obj = Raw + 1;
		object result;
		if (obj != null)
		{
			bool flag = Raw == 0;
			object obj2 = !flag;
			if (obj2 != null)
			{
				object format;
				if (Raw >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E00]");
					format = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6DF0]");
					format = 0;
				}
				object arg = default;
				return string.Format((string)format, arg);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6DE8]");
			result = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6DF8]");
			result = 0;
		}
		return (string)result;
	}

	public static PlayerRef FromEncoded(int encoded)
	{
		//IL_0005: Expected VT, but got I4
		return (PlayerRef)encoded;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static PlayerRef FromRaw(int raw)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I4
		//IL_0029: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return (PlayerRef)raw;
	}

	public static PlayerRef FromIndex(int index)
	{
		//IL_000e: Expected VT, but got I4
		return (PlayerRef)(index + 1);
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator ==(PlayerRef a, PlayerRef b)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = a - b;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator !=(PlayerRef a, PlayerRef b)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = a - b;
		bool flag = obj == null;
		return !flag;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static void Write(NetBitBuffer* buffer, PlayerRef playerRef)
	{
		//IL_0010: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I4
		//IL_002d: Invalid comparison between VT and I4
		//IL_003c: Invalid comparison between VT and I4
		//IL_004f: Expected Obj, but got VT
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected I8, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected I4, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = playerRef < (object)0;
		bool flag3 = playerRef == (PlayerRef)(object)0;
		object obj4 = playerRef ^ playerRef;
		object obj5 = playerRef & obj4;
		bool flag4 = (nint)obj5 < 0;
		bool flag5 = flag2 == flag4;
		object obj6 = !flag3;
		ulong value = (ulong)((flag5 & obj6) ? 1L : 0L);
		buffer->Write(value, 1);
		int num = playerRef - 1;
		if (num >= 1)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v5+E4]");
			bool flag6 = (nint)0 == 0;
			object obj8 = !flag6;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			buffer->WriteInt32VarLength(num);
		}
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static void Write<T>(T* buffer, PlayerRef playerRef) where T : struct, INetBitWriteStream
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_013c: Expected Obj, but got I
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0169: Expected Obj, but got Ref
		//IL_0176: Expected Obj, but got Ref
		//IL_0186: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I4
		//IL_01fc: Invalid comparison between VT and I4
		//IL_020b: Invalid comparison between VT and I4
		//IL_021e: Expected Obj, but got VT
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_0248: Expected Obj, but got Ref
		//IL_0261: Expected Obj, but got I4
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected I4, but got Unknown
		//IL_0288: Expected Obj, but got I
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I4
		//IL_00b5: Expected VT, but got Ref
		//IL_00be: Expected Ref, but got VT
		//IL_00d6: Expected Obj, but got Ref
		//IL_00f5: Expected Obj, but got I
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)16;
		object obj4 = obj3 + 15;
		object obj5 = obj4 & 0x1FFFFFFF0L;
		object obj7 = default;
		object obj6 = (ref *(byte*)(&obj7)) - (ref *(byte*)obj5);
		object obj8 = (ref *(byte*)(&obj7)) - (ref *(byte*)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		nint num3 = 0;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num3 = 0;
			num = 0;
		}
		bool flag2 = playerRef < (object)0;
		bool flag3 = playerRef == (PlayerRef)(object)0;
		object obj12 = playerRef ^ playerRef;
		object obj13 = playerRef & obj12;
		bool flag4 = (nint)obj13 < 0;
		object obj14 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
		bool flag5 = flag2 == flag4;
		object obj15 = !flag3;
		int num4 = ((flag5 & obj15) ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65B94");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-20]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v98 @ X0_v4 (should have been resolved before IL gen)");
		object obj18 = default;
		object obj17 = obj18 & 1;
		bool flag6 = obj17 == null;
		object obj19 = obj6;
		int num5 = num4;
		if (!flag6)
		{
			object obj20 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v10+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef playerRef2 = (PlayerRef)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
			int asIndex = ((PlayerRef*)playerRef2)->AsIndex;
			nint num6 = 0;
			obj14 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65B94");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-20]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v165 @ X0_v15 (should have been resolved before IL gen)");
			obj19 = obj8;
			num5 = asIndex;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
		if (num7 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		}
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe static PlayerRef Read(NetBitBuffer* buffer)
	{
		//IL_00bc: Expected VT, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I4
		//IL_0087: Expected VT, but got I4
		//IL_0090: Invalid comparison between VT and I4
		ulong num = buffer->Read(1);
		PlayerRef playerRef;
		if (num == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E08]");
			object error = 0;
			int num2 = buffer->ReadInt32VarLength();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			playerRef = (PlayerRef)(num2 + 1);
			bool flag2 = playerRef == (PlayerRef)(object)0;
			bool condition = !flag2;
			Assert.Check(condition, (string)error);
		}
		else
		{
			playerRef = (PlayerRef)0;
		}
		return playerRef;
	}

	public bool Equals(PlayerRef other)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		object obj = Raw - other;
		return obj == null;
	}

	internal unsafe static bool TryRead(ReadBuffer buffer, out PlayerRef result)
	{
		//IL_0134: Expected I4, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_008b: Expected Obj, but got I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		if (buffer != null)
		{
			uint num = buffer.UIntVar();
			ref PlayerRef reference;
			if (num != 0)
			{
				object obj = num - 2;
				object obj2 = obj + 2;
				bool flag = (nint)obj2 < 0;
				bool flag2 = obj2 == null;
				reference = ref *(PlayerRef*)obj;
				bool flag3 = !flag;
				object obj3 = !flag2;
				object obj4 = flag3 & obj3;
				if (obj4 != null)
				{
					return true;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v6+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			reference = ref *(PlayerRef*)4294967286L;
			return false;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	internal static void Write(Fusion.Sockets.WriteBuffer buffer, PlayerRef value)
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00e6: Expected Obj, but got I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected I4, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		object obj = value + 2;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		bool flag3 = !flag;
		object obj2 = !flag2;
		object obj3 = flag3 & obj2;
		uint value2;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E10]");
			object error = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v6+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Assert.Check(condition: true, (string)error);
			value2 = 0u;
		}
		else
		{
			value2 = (uint)(value + 2);
		}
		buffer.UIntVar(value2);
	}

	static PlayerRef()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj3 = default;
		obj3._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+A0]");
		object obj5 = 0;
		obj5 = obj3;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
