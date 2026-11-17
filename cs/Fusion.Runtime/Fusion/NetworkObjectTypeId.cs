using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion.Sockets;
using PlayFab.ClientModels;
using PlayFab.EconomyModels;

namespace Fusion;

[Serializable]
[StructLayout((LayoutKind)2, Size = 8)]
public struct NetworkObjectTypeId : _0021_00210, Action<SetFriendTagsResult>
{
	public sealed class EqualityComparer : Action<SearchItemsResponse>
	{
		public bool Equals(NetworkObjectNestingKey x, NetworkObjectNestingKey y)
		{
			//IL_000d: Expected Obj, but got VT
			object obj = x - y;
			return obj == null;
		}

		public int GetHashCode(NetworkObjectNestingKey obj)
		{
			//IL_0005: Expected I4, but got VT
			return (int)obj;
		}
	}

	public const int ALIGNMENT = default(int);

	private const int KIND_MASK = default(int);

	private const int KIND_BITS = default(int);

	private const int SCENE_OBJECT_INDEX_SHIFT = default(int);

	private const int SCENE_OBJECT_INDEX_BITS = default(int);

	private const int SCENE_OBJECT_INDEX_MASK = default(int);

	private const int SCENE_OBJECT_LOAD_ID_SHIFT = default(int);

	private const int SCENE_OBJECT_LOAD_ID_BITS = default(int);

	public const int MAX_SCENE_OBJECT_INDEX = default(int);

	private const ushort STRUCT_TYPE_PLAYERDATA = default(ushort);

	private static readonly NetworkPrefabId.EqualityComparer Comparer__BackingField;

	[FieldOffset(0)]
	private uint _value0;

	[FieldOffset(4)]
	private uint _value1;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF__VALUE0 = default(int);

	internal const int BYTE_COUNT_OF__VALUE0 = default(int);

	internal const int BYTE_OF__VALUE1 = default(int);

	internal const int BYTE_COUNT_OF__VALUE1 = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public static NetworkPrefabId.EqualityComparer Comparer
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
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
			return (NetworkPrefabId.EqualityComparer)0;
		}
	}

	public static NetworkObjectTypeId PlayerData
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0058: Expected Obj, but got I4
			//IL_002e: Expected VT, but got I8
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return (NetworkObjectTypeId)8589934593L;
		}
	}

	public NetworkTypeIdKind Kind
	{
		get
		{
			//IL_002b: Expected Obj, but got I4
			//IL_008d: Expected Obj, but got I4
			//IL_009d: Expected Obj, but got I4
			//IL_00b7: Expected Obj, but got I4
			//IL_00d2: Expected I4, but got Obj
			int num = (int)(_value0 | _value1);
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				return (NetworkTypeIdKind)5;
			}
			NetworkTypeIdKind networkTypeIdKind = (NetworkTypeIdKind)(_value1 & 3);
			if (networkTypeIdKind != 0)
			{
				return networkTypeIdKind;
			}
			bool flag2 = (int)_value1 < 3;
			object obj2 = !flag2;
			object obj3 = _value1 - 3;
			bool flag3 = obj3 == null;
			object obj4 = !flag3;
			object obj5 = obj2 & obj4;
			return (NetworkTypeIdKind)(obj5 << 2);
		}
	}

	public NetworkSceneObjectId AsSceneObjectId
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0197: Expected Obj, but got I4
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected VT, but got Unknown
			//IL_016d: Expected VT, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (IsSceneObject)
			{
				SceneRef sceneRef = SceneRef.FromRaw(_value0);
				int num = (int)_value1 >> 2;
				int num2 = num & 0x3FFFFF;
				byte b = (byte)((int)_value1 >> 24);
				NetworkSceneLoadId networkSceneLoadId = b;
				return (NetworkSceneObjectId)(sceneRef | num2);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1648");
			NetworkTypeIdKind kind = Kind;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format = default;
			object arg = default;
			object arg2 = default;
			string message = string.Format(format, arg, arg2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			InvalidOperationException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (NetworkSceneObjectId)ex2;
		}
	}

	public NetworkPrefabId AsPrefabId
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_013d: Expected Obj, but got I4
			//IL_0052: Expected VT, but got I4
			//IL_0113: Expected VT, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!IsPrefab)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1648");
				NetworkTypeIdKind kind = Kind;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string format = default;
				object arg = default;
				object arg2 = default;
				string message = string.Format(format, arg, arg2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				InvalidOperationException ex = default;
				ex._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentNullException ex2 = new ArgumentNullException();
				return (NetworkPrefabId)ex2;
			}
			return (NetworkPrefabId)_value0;
		}
	}

	public (NetworkPrefabId, int) AsNestedPrefabId
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_017c: Expected Obj, but got I4
			//IL_008b: Expected VT, but got I4
			//IL_0091: Expected VT, but got I4
			//IL_0152: Expected VT, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (IsPrefabNestedObject)
			{
				int num = (int)_value1 >> 2;
				int num2 = num & 0x3FFFFF;
				int item = num2 - 1;
				(NetworkPrefabId, int) tuple = ((NetworkPrefabId)_value0, item);
				return ((NetworkPrefabId, int))0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1648");
			NetworkTypeIdKind kind = Kind;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format = default;
			object arg = default;
			object arg2 = default;
			string message = string.Format(format, arg, arg2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			InvalidOperationException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return ((NetworkPrefabId, int))ex2;
		}
	}

	public uint AsCustom
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_013d: Expected Obj, but got I4
			//IL_0113: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (IsCustom)
			{
				return _value0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1648");
			NetworkTypeIdKind kind = Kind;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format = default;
			object arg = default;
			object arg2 = default;
			string message = string.Format(format, arg, arg2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			InvalidOperationException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (uint)(int)ex2;
		}
	}

	public ushort AsInternalStructId
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_013d: Expected Obj, but got I4
			//IL_0113: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (IsStruct)
			{
				return (ushort)_value0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1648");
			NetworkTypeIdKind kind = Kind;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format = default;
			object arg = default;
			object arg2 = default;
			string message = string.Format(format, arg, arg2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			InvalidOperationException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (ushort)(int)ex2;
		}
	}

	public bool IsNone
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0073: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = (int)(_value0 | _value1);
			return num == 0;
		}
	}

	public bool IsValid
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = (int)(_value0 | _value1);
			bool flag2 = num == 0;
			return !flag2;
		}
	}

	public bool IsSceneObject
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0133: Expected Obj, but got I4
			//IL_004f: Expected Obj, but got I4
			//IL_0095: Expected Obj, but got I4
			//IL_014f: Expected Obj, but got I4
			//IL_00bf: Expected Obj, but got I4
			//IL_00cf: Expected Obj, but got I4
			//IL_00e9: Expected Obj, but got I4
			//IL_0104: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = (int)(_value0 | _value1);
			bool flag2 = num == 0;
			object obj4 = !flag2;
			int num2;
			if (obj4 == null)
			{
				num2 = 5;
			}
			else
			{
				num2 = (int)(_value1 & 3);
				bool flag3 = num2 == 0;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					bool flag4 = (int)_value1 < 3;
					object obj6 = !flag4;
					object obj7 = _value1 - 3;
					bool flag5 = obj7 == null;
					object obj8 = !flag5;
					object obj9 = obj6 & obj8;
					num2 = obj9 << 2;
				}
			}
			object obj10 = num2 - 3;
			return obj10 == null;
		}
	}

	public bool IsPrefab
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00e8: Expected Obj, but got I4
			//IL_005f: Expected Obj, but got I4
			//IL_0101: Expected Obj, but got I4
			//IL_00b9: Expected Obj, but got I4
			//IL_0121: Expected I4, but got Obj
			//IL_00ab: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = (int)(_value0 | _value1);
			int num2 = (int)(_value1 & 3);
			bool flag2 = num2 == 0;
			object obj4 = !flag2;
			bool flag3 = obj4 != null || num == 0;
			object obj5 = !flag3;
			object obj6 = ~obj5;
			object obj7;
			if (obj6 == null)
			{
				bool flag4 = (int)_value1 < 4;
				obj7 = !flag4;
			}
			else
			{
				obj7 = 1;
			}
			return (byte)(int)(~obj7) != 0;
		}
	}

	public bool IsPrefabNestedObject
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0110: Expected Obj, but got I4
			//IL_005f: Expected Obj, but got I4
			//IL_0129: Expected Obj, but got I4
			//IL_00d8: Expected Obj, but got I4
			//IL_014b: Expected Obj, but got I4
			//IL_0158: Expected I4, but got Obj
			//IL_00ab: Expected Obj, but got I4
			//IL_00bb: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = (int)(_value0 | _value1);
			int num2 = (int)(_value1 & 3);
			bool flag2 = num2 == 0;
			object obj4 = !flag2;
			bool flag3 = obj4 != null || num == 0;
			object obj5 = !flag3;
			object obj6 = ~obj5;
			object obj7;
			bool flag5;
			if (obj6 == null)
			{
				bool flag4 = (int)_value1 < 3;
				obj7 = !flag4;
				object obj8 = _value1 - 3;
				flag5 = obj8 == null;
			}
			else
			{
				obj7 = 0;
				flag5 = false;
			}
			object obj9 = !flag5;
			return (byte)(obj7 & obj9) != 0;
		}
	}

	public bool IsStruct
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0133: Expected Obj, but got I4
			//IL_004f: Expected Obj, but got I4
			//IL_0095: Expected Obj, but got I4
			//IL_014f: Expected Obj, but got I4
			//IL_00bf: Expected Obj, but got I4
			//IL_00cf: Expected Obj, but got I4
			//IL_00e9: Expected Obj, but got I4
			//IL_0104: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = (int)(_value0 | _value1);
			bool flag2 = num == 0;
			object obj4 = !flag2;
			int num2;
			if (obj4 == null)
			{
				num2 = 5;
			}
			else
			{
				num2 = (int)(_value1 & 3);
				bool flag3 = num2 == 0;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					bool flag4 = (int)_value1 < 3;
					object obj6 = !flag4;
					object obj7 = _value1 - 3;
					bool flag5 = obj7 == null;
					object obj8 = !flag5;
					object obj9 = obj6 & obj8;
					num2 = obj9 << 2;
				}
			}
			object obj10 = num2 - 2;
			return obj10 == null;
		}
	}

	public bool IsCustom
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0133: Expected Obj, but got I4
			//IL_004f: Expected Obj, but got I4
			//IL_0095: Expected Obj, but got I4
			//IL_014f: Expected Obj, but got I4
			//IL_00bf: Expected Obj, but got I4
			//IL_00cf: Expected Obj, but got I4
			//IL_00e9: Expected Obj, but got I4
			//IL_0104: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = (int)(_value0 | _value1);
			bool flag2 = num == 0;
			object obj4 = !flag2;
			int num2;
			if (obj4 == null)
			{
				num2 = 5;
			}
			else
			{
				num2 = (int)(_value1 & 3);
				bool flag3 = num2 == 0;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					bool flag4 = (int)_value1 < 3;
					object obj6 = !flag4;
					object obj7 = _value1 - 3;
					bool flag5 = obj7 == null;
					object obj8 = !flag5;
					object obj9 = obj6 & obj8;
					num2 = obj9 << 2;
				}
			}
			object obj10 = num2 - 1;
			return obj10 == null;
		}
	}

	public static NetworkObjectTypeId FromSceneRefAndObjectIndex(SceneRef sceneRef, int objIndex, NetworkSceneLoadId loadId = default(NetworkSceneLoadId))
	{
		//IL_0010: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
		return FromSceneObjectId((NetworkSceneObjectId)sceneRef);
	}

	public static NetworkObjectTypeId FromSceneObjectId(NetworkSceneObjectId sceneObjectId)
	{
		//IL_00b6: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I4
		//IL_00ec: Expected Obj, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected VT, but got Unknown
		//IL_0116: Expected VT, but got Obj
		SceneRef sceneRef = default;
		ArgumentException ex;
		if (sceneRef.IsValid)
		{
			object obj = default;
			bool flag = (nint)obj < 4194304;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = obj << 2;
				IntPtr intPtr = default;
				object obj4 = obj3 | (nint)intPtr;
				object obj5 = obj4 | 3;
				return (NetworkObjectTypeId)(sceneRef | obj5);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D87E8]");
			object obj6 = 0;
			ArgumentException ex2 = default;
			ex = ex2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D87E0]");
			object obj6 = 0;
			ArgumentException ex3 = default;
			ex = ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string message = default;
		string paramName = default;
		ex._002Ector(message, paramName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex4 = new ArgumentNullException();
		return (NetworkObjectTypeId)ex4;
	}

	public static NetworkObjectTypeId FromPrefabId(NetworkPrefabId prefabId)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected VT, but got Unknown
		//IL_001b: Invalid comparison between VT and I4
		//IL_0094: Expected VT, but got Obj
		NetworkObjectTypeId networkObjectTypeId = (NetworkObjectTypeId)(prefabId & 0xFFFFFFFFL);
		if (networkObjectTypeId != (NetworkObjectTypeId)(object)0)
		{
			return networkObjectTypeId;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentException ex = default;
		string message = default;
		string paramName = default;
		ex._002Ector(message, paramName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (NetworkObjectTypeId)ex2;
	}

	public static NetworkObjectTypeId FromPrefabNestedObject(NetworkPrefabId prefabId, int index)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected VT, but got Unknown
		//IL_001b: Invalid comparison between VT and I4
		//IL_0099: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I4
		//IL_0104: Expected VT, but got Obj
		//IL_00e1: Expected Obj, but got I
		NetworkObjectTypeId networkObjectTypeId = (NetworkObjectTypeId)(prefabId & 0xFFFFFFFFL);
		ArgumentException ex;
		string message;
		if (networkObjectTypeId != (NetworkObjectTypeId)(object)0)
		{
			bool flag = index < 4194304;
			object obj = !flag;
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
				return networkObjectTypeId;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC998]");
			object obj2 = 0;
			ArgumentException ex2 = default;
			ex = ex2;
			string text = default;
			message = text;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8810]");
			object obj2 = 0;
			ArgumentException ex3 = default;
			ex = ex3;
			string text2 = default;
			message = text2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string paramName = default;
		ex._002Ector(message, paramName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex4 = new ArgumentNullException();
		return (NetworkObjectTypeId)ex4;
	}

	public static NetworkObjectTypeId FromCustom(uint raw)
	{
		//IL_0012: Expected VT, but got I8
		return (NetworkObjectTypeId)((int)raw | 0x100000000L);
	}

	public static NetworkObjectTypeId FromStruct(ushort structId)
	{
		//IL_0014: Expected VT, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
		return (NetworkObjectTypeId)8589934592L;
	}

	public bool Equals(NetworkObjectTypeId other)
	{
		//IL_000a: Invalid comparison between I4 and VT
		//IL_002f: Expected Obj, but got VT
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		if ((object)_value0 == (object)other)
		{
			object obj = other >> 32;
			object obj2 = _value1 - obj;
			return obj2 == null;
		}
		return false;
	}

	public override int GetHashCode()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected I4, but got Unknown
		object obj = _value0 * 397;
		return (int)(obj ^ _value1);
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
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
				uint value = _value0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				if ((nint)(int)value == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
					object obj5 = (nint)0 >> 32;
					object obj6 = _value1 - obj5;
					return obj6 == null;
				}
			}
		}
		return false;
	}

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0460: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I
		//IL_034d: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I4
		//IL_0243: Expected Obj, but got I4
		//IL_02c8: Expected Obj, but got I4
		//IL_027a: Expected Obj, but got I
		//IL_02ff: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I4
		//IL_0299: Expected Obj, but got I
		//IL_031e: Expected Obj, but got I
		//IL_03ad: Expected Obj, but got I4
		//IL_03e4: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I4
		//IL_01d5: Expected Obj, but got I
		//IL_041c: Expected Obj, but got I
		//IL_01f4: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object result;
		if (IsValid)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = (int)(_value0 | _value1);
			bool flag3 = num == 0;
			object obj6 = !flag3;
			if (obj6 != null)
			{
				int num2 = (int)(_value1 & 3);
				object format2;
				if (num2 <= 1)
				{
					bool flag4 = num2 == 0;
					object obj7 = !flag4;
					if (obj7 == null)
					{
						object obj8 = obj;
						bool flag5 = (int)_value1 < 4;
						object obj9 = !flag5;
						if (obj9 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v35+E4]");
							bool flag6 = (nint)0 == 0;
							object obj10 = !flag6;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							(NetworkPrefabId, int) asNestedPrefabId = AsNestedPrefabId;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							(NetworkPrefabId, int) asNestedPrefabId2 = AsNestedPrefabId;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8478]");
							object format = 0;
							object arg = default;
							object arg2 = default;
							return string.Format((string)format, arg, arg2);
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v35+E4]");
						bool flag7 = (nint)0 == 0;
						object obj12 = !flag7;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						NetworkPrefabId asPrefabId = AsPrefabId;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8488]");
						format2 = 0;
					}
					else
					{
						object obj14 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v28+E4]");
						bool flag8 = (nint)0 == 0;
						object obj15 = !flag8;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						uint asCustom = AsCustom;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8480]");
						format2 = 0;
					}
				}
				else
				{
					if (num2 != 2)
					{
						object obj17 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v14+E4]");
						bool flag9 = (nint)0 == 0;
						object obj18 = !flag9;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						NetworkSceneObjectId asSceneObjectId = AsSceneObjectId;
						NetworkSceneObjectId networkSceneObjectId = default;
						return networkSceneObjectId.ToString();
					}
					object obj19 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v21+E4]");
					bool flag10 = (nint)0 == 0;
					object obj20 = !flag10;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					ushort asInternalStructId = AsInternalStructId;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8470]");
					format2 = 0;
				}
				object arg3 = default;
				return string.Format((string)format2, arg3);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8468]");
			result = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8490]");
			result = 0;
		}
		return (string)result;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator ==(NetworkObjectTypeId a, NetworkObjectTypeId b)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = a - b;
		return obj == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator !=(NetworkObjectTypeId a, NetworkObjectTypeId b)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = a - b;
		bool flag = obj == null;
		return !flag;
	}

	public static implicit operator NetworkObjectTypeId(NetworkPrefabId prefabId)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetworkPrefabId prefabId2 = (NetworkPrefabId)(prefabId & 0xFFFFFFFFL);
		return FromPrefabId(prefabId2);
	}

	internal unsafe static void WriteInternal(NetworkObjectTypeId typeId, NetBitBuffer* buffer, int blockSize)
	{
		//IL_000e: Expected I4, but got VT
		//IL_001f: Expected I4, but got VT
		uint value = (uint)(typeId >> 32);
		buffer->WriteUInt32VarLength((uint)(int)typeId, blockSize);
		buffer->WriteUInt32VarLength(value, blockSize);
	}

	internal unsafe static NetworkObjectTypeId ReadInternal(NetBitBuffer* buffer, int blockSize)
	{
		//IL_0034: Expected VT, but got I4
		uint num = buffer->ReadUInt32VarLength(blockSize);
		uint num2 = buffer->ReadUInt32VarLength(blockSize);
		return (NetworkObjectTypeId)(num | num2);
	}

	static NetworkObjectTypeId()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8848]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
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
