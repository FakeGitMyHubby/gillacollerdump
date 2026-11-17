using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;
using UnityEngine;

public static class ModMenuAccess
{
	public const string Item = null;

	public const string SizeItem = null;

	public const string OpItem = null;

	public const string PunchItem = null;

	public const string ModeratorItem = null;

	public static readonly string[] OwnerNames;

	private static string MetaUserName__BackingField;

	private static bool Granted__BackingField;

	private static bool HasSize__BackingField;

	private static bool HasOp__BackingField;

	private static bool HasPunch__BackingField;

	private static bool HasModerator__BackingField;

	private static string hand;

	private const string OwnerEquipKey = null;

	private const string EquipKey = null;

	public static string MetaUserName
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
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
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+8]");
			return (string)0;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = (nint)0 + (nint)8;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static bool Granted
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
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
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+10]");
			return false;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = 0;
		}
	}

	public static bool HasSize
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
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
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+11]");
			return false;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = 0;
		}
	}

	public static bool HasOp
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
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
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+12]");
			return false;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = 0;
		}
	}

	public static bool HasPunch
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
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
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+13]");
			return false;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = 0;
		}
	}

	public static bool HasModerator
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
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
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+14]");
			return false;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = 0;
		}
	}

	public static bool IsModerator
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00bd: Expected Obj, but got I4
			//IL_00f5: Expected Obj, but got I4
			//IL_0113: Expected Obj, but got I
			//IL_0068: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v7+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7+14]");
			if ((nint)0 != 0)
			{
				return true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return IsOwner;
		}
	}

	public static bool IsOwner
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0150: Expected Obj, but got I4
			//IL_0188: Expected Obj, but got I4
			//IL_01de: Expected Obj, but got I
			//IL_0200: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_007a: Expected Obj, but got I4
			//IL_00ed: Expected Obj, but got I4
			//IL_01c0: Expected Obj, but got I4
			//IL_021e: Expected Obj, but got I
			//IL_022f: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v7+10]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
				object obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v9+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!Application.isEditor)
				{
					object obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v13+E4]");
					bool flag5 = (nint)0 == 0;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj13 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v17+E4]");
					bool flag6 = (nint)0 == 0;
					object obj14 = !flag6;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj13 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v17+A0]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v17+8]");
					return IsOwnerName((string)0);
				}
			}
			return true;
		}
	}

	public static bool IsRealOwner
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00ed: Expected Obj, but got I4
			//IL_0060: Expected Obj, but got I
			//IL_008a: Expected Obj, but got I4
			//IL_0125: Expected Obj, but got I4
			//IL_0143: Expected Obj, but got I
			//IL_0154: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Application.isEditor)
			{
				return true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v10+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v8+8]");
			return IsOwnerName((string)0);
		}
	}

	public static ModMenu.Kind? Menu
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00f3: Expected Obj, but got I4
			//IL_0091: Expected Obj, but got I4
			//IL_0062: Expected VT, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (OwnerHere)
			{
				Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)0;
				return (ModMenu.Kind?)(object)0;
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string item = BoughtOn();
			return KindOf(item);
		}
	}

	private static bool OwnerHere
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_005c: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return IsOwner;
		}
	}

	private static bool SizeHere
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_006a: Expected Obj, but got I4
			//IL_00a2: Expected Obj, but got I4
			//IL_00c0: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7+11]");
			return false;
		}
	}

	private static bool OpHere
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_006a: Expected Obj, but got I4
			//IL_00a2: Expected Obj, but got I4
			//IL_00c0: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7+12]");
			return false;
		}
	}

	private static bool PunchHere
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_006a: Expected Obj, but got I4
			//IL_00a2: Expected Obj, but got I4
			//IL_00c0: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7+13]");
			return false;
		}
	}

	private static bool ModeratorHere
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_006a: Expected Obj, but got I4
			//IL_00a2: Expected Obj, but got I4
			//IL_00c0: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7+14]");
			return false;
		}
	}

	public static bool HasOwnerMenu
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_005c: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return OwnerHere;
		}
	}

	public static bool OwnerHasOp
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00e3: Expected Obj, but got I4
			//IL_0062: Expected Obj, but got I
			//IL_0084: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (OwnerHere)
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6E0]");
				object item = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return OwnerEquipped((string)item);
			}
			return false;
		}
	}

	public static bool OwnerHasSize
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00e3: Expected Obj, but got I4
			//IL_0062: Expected Obj, but got I
			//IL_0084: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (OwnerHere)
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6E8]");
				object item = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return OwnerEquipped((string)item);
			}
			return false;
		}
	}

	public static bool OwnerHasPunch
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00e3: Expected Obj, but got I4
			//IL_0062: Expected Obj, but got I
			//IL_0084: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (OwnerHere)
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6F0]");
				object item = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return OwnerEquipped((string)item);
			}
			return false;
		}
	}

	public static bool MenuWorksHere
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0105: Expected Obj, but got I4
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected Obj, but got Unknown
			//IL_00d6: Expected Obj, but got I4
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Expected I4, but got Unknown
			//IL_006e: Expected I4, but got VT
			//IL_0090: Expected Obj, but got I4
			//IL_00c8: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ModMenu.Kind? menu = Menu;
			object obj4 = (_003F?)menu & 0xFF;
			object obj7;
			if (obj4 != null)
			{
				object obj5 = obj;
				ModMenu.Kind kind = (ModMenu.Kind)((_003F?)menu >> 32);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag3 = OffHere(kind);
				obj7 = (flag3 ? 1 : 0) ^ 1;
			}
			else
			{
				obj7 = 0;
			}
			return (byte)(obj7 & 1) != 0;
		}
	}

	public static ModMenu.Kind? KindOf(string item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0033: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_00f4: Expected VT, but got I4
		//IL_0116: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6E8]");
		object obj = 0;
		Unity.IL2CPP.Metadata.__Il2CppInt32Enum value;
		Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum;
		if (item == (string)obj)
		{
			value = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6E0]");
			object obj2 = 0;
			if (item == (string)obj2)
			{
				value = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6F0]");
				object obj3 = 0;
				if (item == (string)obj3)
				{
					value = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)4;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6F8]");
					object obj4 = 0;
					bool flag = item == (string)obj4;
					bool flag2 = !flag;
					_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum?)(object)0;
					if (flag2)
					{
						goto IL_0110;
					}
					value = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)5;
				}
			}
		}
		_Il2CppInt32Enum = value;
		goto IL_0110;
		IL_0110:
		return (ModMenu.Kind?)(object)0;
	}

	public static string ItemOf(string sku)
	{
		//IL_0010: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC700]");
		object obj = 0;
		object result;
		if (sku == (string)obj)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6E8]");
			result = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC708]");
			object obj2 = 0;
			if (!(sku == (string)obj2))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC710]");
				object obj3 = 0;
				bool flag = sku == (string)obj3;
				bool flag2 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6F0]");
				object result2 = 0;
				object obj4 = !flag2;
				object obj5 = ~obj4;
				if (obj5 == null)
				{
					return (string)result2;
				}
				return null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6E0]");
			result = 0;
		}
		return (string)result;
	}

	private static string BoughtOn()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0574: Expected Obj, but got I4
		//IL_06d7: Expected Obj, but got I
		//IL_06e7: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I4
		//IL_0639: Expected Obj, but got I
		//IL_0642: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01e7: Expected Obj, but got I8
		//IL_05c4: Expected Obj, but got I
		//IL_05d5: Expected Obj, but got I
		//IL_0214: Expected Obj, but got I
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_0256: Expected Obj, but got I4
		//IL_026c: Expected Obj, but got I
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_00fc: Expected Obj, but got I4
		//IL_060e: Expected Obj, but got I
		//IL_061e: Expected Obj, but got I
		//IL_02af: Expected Obj, but got I
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02e9: Expected Obj, but got I8
		//IL_0316: Expected Obj, but got I
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected Obj, but got Unknown
		//IL_0375: Expected Obj, but got I8
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_038c: Expected Obj, but got I4
		//IL_068c: Expected Obj, but got I4
		//IL_03a9: Expected Obj, but got I
		//IL_03cb: Expected Obj, but got I4
		//IL_049e: Expected Obj, but got I
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected Obj, but got Unknown
		//IL_043c: Expected Obj, but got I4
		//IL_0480: Expected Obj, but got I4
		//IL_0504: Expected Obj, but got I4
		//IL_06b0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v55+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v55+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+18]");
		string item = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+18]");
		string text;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v55+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v39+A0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v40+18]");
				item = (string)0;
			}
			bool flag3 = Here(item);
			obj2 = obj;
			if (flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v55+E4]");
				bool flag4 = (nint)0 == 0;
				object obj8 = !flag4;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v55+A0]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v35+18]");
				bool flag5 = Equipped((string)0);
				obj2 = obj;
				if (flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v55+E4]");
					bool flag6 = (nint)0 == 0;
					object obj10 = !flag6;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj2 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v55+A0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v38+18]");
					text = (string)0;
					goto IL_0529;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v55+E4]");
		bool flag7 = (nint)0 == 0;
		object obj13 = !flag7;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v55+A0]");
		object obj14 = (nint)0 + (nint)24;
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v12+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6E0]");
				object obj16 = 0;
				object obj17 = obj15 + 32;
				obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X20_v6-8]");
				object obj18 = 0 & 0xFFFFFFFEL;
				if (obj18 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6E8]");
					object obj19 = 0;
					object obj20 = obj15 + 40;
					obj20 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X20_v8-10]");
					bool flag8 = (nint)0 < (nint)2;
					object obj21 = !flag8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X20_v8-10]");
					object obj22 = -2;
					bool flag9 = obj22 == null;
					object obj23 = ~obj21;
					object obj24 = obj23 | flag9;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6F0]");
						object obj25 = 0;
						object obj26 = obj15 + 48;
						obj26 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X20_v10-18]");
						object obj27 = 0 & 0xFFFFFFFCL;
						if (obj27 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6F8]");
							object obj28 = 0;
							object obj29 = obj15 + 56;
							obj29 = obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X20_v12-20]");
							if ((nint)0 < (nint)1)
							{
								goto IL_04d0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X20_v12-20]");
							object obj30 = 0 & 0xFFFFFFFFL;
							object obj31 = obj15 + 32;
							object obj32 = 0;
							while (true)
							{
								bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30);
								object obj33 = !flag10;
								if (obj33 != null)
								{
									break;
								}
								object obj34 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X23_v6+v169 @ X22_v7*8]");
								text = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v27+E4]");
								bool flag11 = (nint)0 == 0;
								object obj35 = !flag11;
								if (obj35 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if (Here(text))
								{
									object obj36 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v32+E4]");
									bool flag12 = (nint)0 == 0;
									object obj37 = !flag12;
									if (obj37 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag13 = Equipped(text);
									bool flag14 = !flag13;
									object obj38 = !flag14;
									if (obj38 != null)
									{
										goto IL_04da;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v12+18]");
								obj30 = 0;
								obj32++;
								object obj39 = obj32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v12+18]");
								if ((nint)obj39 < 0)
								{
									continue;
								}
								goto IL_04d0;
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		return (string)(object)new NullReferenceException();
		IL_0529:
		return text;
		IL_04d0:
		text = null;
		goto IL_0529;
		IL_04da:
		object obj40 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v37+E4]");
		bool flag15 = (nint)0 == 0;
		object obj41 = !flag15;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj40 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v37+A0]");
		object obj42 = (nint)0 + (nint)24;
		obj42 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		goto IL_0529;
	}

	public static bool SideBoard(ModMenu.Kind kind)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_01a7: Expected Obj, but got I4
		//IL_0218: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = ItemFor(kind);
		if (text != null)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool ownerHere = OwnerHere;
			object obj6 = obj;
			if (ownerHere)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v11+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return OwnerEquipped(text);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Here(text))
			{
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v15+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (Equipped(text))
				{
					object obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v20+E4]");
					bool flag6 = (nint)0 == 0;
					object obj12 = !flag6;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text2 = BoughtOn();
					return text2 != text;
				}
			}
		}
		return false;
	}

	public static string ItemFor(ModMenu.Kind kind)
	{
		//IL_00d8: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		string result;
		object obj;
		if (kind <= (ModMenu.Kind)3)
		{
			if (kind != (ModMenu.Kind)1)
			{
				bool flag = kind != (ModMenu.Kind)2;
				result = null;
				if (flag)
				{
					goto IL_00fa;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6E0]");
				obj = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6E8]");
				obj = 0;
			}
		}
		else if (kind != (ModMenu.Kind)4)
		{
			bool flag2 = kind != (ModMenu.Kind)5;
			result = null;
			if (flag2)
			{
				goto IL_00fa;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6F8]");
			obj = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6F0]");
			obj = 0;
		}
		result = (string)obj;
		goto IL_00fa;
		IL_00fa:
		return result;
	}

	private static bool Here(string item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0239: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_01a0: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got I4
		//IL_01f8: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
		object obj2 = 0;
		if (item == (string)obj)
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v24+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return SizeHere;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6E0]");
		object obj5 = 0;
		if (item == (string)obj5)
		{
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v20+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return OpHere;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6F0]");
		object obj8 = 0;
		if (item == (string)obj8)
		{
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v16+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return PunchHere;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6F8]");
		object obj11 = 0;
		if (item == (string)obj11)
		{
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return ModeratorHere;
		}
		return false;
	}

	public static bool OwnerEquipped(string item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC720]");
		object obj = 0;
		string key = (string)obj + item;
		int num = PlayerPrefs.GetInt(key, 0);
		object obj2 = num - 1;
		return obj2 == null;
	}

	public static void SetOwnerEquipped(string item, bool on)
	{
		//IL_01e6: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I
		//IL_0216: Expected Obj, but got I
		//IL_0226: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I
		//IL_019b: Expected Obj, but got I4
		bool flag = string.IsNullOrEmpty(item);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = OwnerEquipped(item);
		if (flag4 != on)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC720]");
			object obj5 = 0;
			string key = (string)obj5 + item;
			bool flag5 = !on;
			object obj6 = !flag5;
			object obj7 = ~obj6;
			object obj8;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC738]");
				obj8 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC730]");
				obj8 = 0;
			}
			PlayerPrefs.SetInt(key, on ? 1 : 0);
			PlayerPrefs.Save();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB5F8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC728]");
			object obj10 = 0;
			string message = (string)obj9 + item + (string)obj8 + (string)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj11 = 0;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v16+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA900]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v16+E4]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ModMenu.AttachIfOwner();
		}
	}

	public static bool OwnerHas(ModMenu.Kind kind)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (OwnerHere)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return SideBoard(kind);
		}
		return false;
	}

	public static bool Worn(string item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool ownerHere = OwnerHere;
		object obj4 = obj;
		if (ownerHere)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return OwnerEquipped(item);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Here(item))
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return Equipped(item);
		}
		return false;
	}

	public static void SetWorn(string item, bool on)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool ownerHere = OwnerHere;
		object obj4 = obj;
		if (ownerHere)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SetOwnerEquipped(item, on);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SetEquipped(item, on);
		}
	}

	public static bool Equipped(string item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected I4, but got Unknown
		//IL_0033: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC718]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6F8]");
		object obj2 = 0;
		string key = (string)obj + item;
		bool flag = item == (string)obj2;
		object obj3 = !flag;
		int defaultValue = 1 & obj3;
		int num = PlayerPrefs.GetInt(key, defaultValue);
		object obj4 = num - 1;
		return obj4 == null;
	}

	public static void SetEquipped(string item, bool on)
	{
		//IL_01f9: Expected Obj, but got I
		//IL_0220: Expected Obj, but got I4
		//IL_0228: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I4
		//IL_01c6: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_0129: Expected Obj, but got I
		//IL_0261: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I4
		//IL_0197: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA900]");
		object obj = 0;
		bool flag = string.IsNullOrEmpty(item);
		bool flag2 = !flag;
		object obj2 = !flag2;
		IntPtr intPtr = default;
		string text = (string)(nint)intPtr;
		object obj3 = 0;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = Equipped(item);
			object obj7 = flag4 ^ on;
			object obj8 = obj7 & 1;
			bool flag5 = obj8 == null;
			text = (string)(nint)intPtr;
			obj3 = 0;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC718]");
				object obj9 = 0;
				string key = (string)obj9 + item;
				bool flag6 = !on;
				object obj10 = !flag6;
				object obj11 = ~obj10;
				object obj12;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC748]");
					obj12 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC740]");
					obj12 = 0;
				}
				PlayerPrefs.SetInt(key, on ? 1 : 0);
				PlayerPrefs.Save();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB5F8]");
				object obj13 = 0;
				text = (string)obj12;
				string message = (string)obj13 + item + (string)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj14 = 0;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v17+E4]");
				bool flag7 = (nint)0 == 0;
				object obj16 = !flag7;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.Log(message);
				obj3 = 0;
			}
		}
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v5+E4]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ModMenu.AttachIfOwner();
	}

	public static bool OffHere(ModMenu.Kind kind)
	{
		//IL_003b: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I4
		//IL_0239: Expected Obj, but got I
		//IL_0249: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I4
		//IL_021b: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I
		//IL_018e: Expected I4, but got Obj
		bool flag = kind == 0;
		bool result = false;
		if (!flag)
		{
			bool flag2 = kind == (ModMenu.Kind)5;
			result = false;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v4+E4]");
				bool flag3 = (nint)0 == 0;
				object obj3 = !flag3;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v8+E4]");
				bool flag4 = (nint)0 == 0;
				object obj5 = !flag4;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj4 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v8+A0]");
				object obj7 = 0;
				object obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v10+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v2+8]");
				if ((UnityEngine.Object)0 != null)
				{
					object obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v13+E4]");
					bool flag6 = (nint)0 == 0;
					object obj11 = !flag6;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v17+E4]");
					bool flag7 = (nint)0 == 0;
					object obj13 = !flag7;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj12 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v17+A0]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v15+8]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v15+8]");
					if ((nint)0 == 0)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v16+90]");
					bool flag8 = (nint)0 == 0;
					bool flag9 = !flag8;
					result = flag9;
				}
				else
				{
					result = false;
				}
			}
		}
		return result;
	}

	public static bool Owns(string item)
	{
		//IL_0023: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I4
		//IL_00c8: Expected Obj, but got I4
		if (string.IsNullOrEmpty(item))
		{
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (OwnerHere)
		{
			return true;
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return Here(item);
	}

	public static void Adopt(string[] owned)
	{
		//IL_0010: Expected Obj, but got I
		//IL_06f9: Expected Obj, but got I
		//IL_0709: Expected Obj, but got I
		//IL_0721: Expected Obj, but got I
		//IL_0731: Expected Obj, but got I
		//IL_0741: Expected Obj, but got I
		//IL_0763: Expected Obj, but got I4
		//IL_079b: Expected Obj, but got I4
		//IL_0cd9: Expected Obj, but got I
		//IL_0ce9: Expected Obj, but got I
		//IL_0d0b: Expected Obj, but got I4
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d18: Expected Obj, but got Unknown
		//IL_0d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d26: Expected Obj, but got Unknown
		//IL_07cb: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_08b8: Expected Obj, but got I4
		//IL_0d99: Expected Obj, but got I
		//IL_0da9: Expected Obj, but got I
		//IL_0dcb: Expected Obj, but got I4
		//IL_0dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd8: Expected Obj, but got Unknown
		//IL_0de1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de6: Expected Obj, but got Unknown
		//IL_0e00: Expected Obj, but got I4
		//IL_07f1: Expected Obj, but got I
		//IL_0801: Expected Obj, but got I
		//IL_0823: Expected Obj, but got I4
		//IL_02b4: Expected Obj, but got I4
		//IL_0d53: Expected Obj, but got I
		//IL_0d72: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I
		//IL_0998: Expected Obj, but got I4
		//IL_0856: Expected Obj, but got I
		//IL_0880: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I
		//IL_0f72: Expected Obj, but got I
		//IL_08f0: Expected Obj, but got I4
		//IL_09c8: Expected Obj, but got I4
		//IL_0e1e: Expected Obj, but got I
		//IL_0e40: Expected Obj, but got I4
		//IL_0e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4d: Expected Obj, but got Unknown
		//IL_0e56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5b: Expected Obj, but got Unknown
		//IL_0e75: Expected Obj, but got I4
		//IL_0f8c: Expected Obj, but got I
		//IL_09f8: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I4
		//IL_0fa6: Expected Obj, but got I
		//IL_0a16: Expected Obj, but got I
		//IL_0a38: Expected Obj, but got I4
		//IL_0928: Expected Obj, but got I4
		//IL_0fc0: Expected Obj, but got I
		//IL_0e93: Expected Obj, but got I
		//IL_0eb5: Expected Obj, but got I4
		//IL_0ebd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec2: Expected Obj, but got Unknown
		//IL_0ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed0: Expected Obj, but got Unknown
		//IL_0eea: Expected Obj, but got I4
		//IL_0259: Expected Obj, but got I4
		//IL_0361: Expected Obj, but got I
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected Obj, but got Unknown
		//IL_039b: Expected Obj, but got I8
		//IL_0960: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got I
		//IL_03e2: Expected Obj, but got I4
		//IL_0f08: Expected Obj, but got I
		//IL_0f2a: Expected Obj, but got I4
		//IL_0f32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f37: Expected Obj, but got Unknown
		//IL_0f40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f45: Expected Obj, but got Unknown
		//IL_040e: Expected Obj, but got I
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected Obj, but got Unknown
		//IL_06c5: Expected Obj, but got I4
		//IL_0a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a54: Expected Obj, but got Unknown
		//IL_0a88: Expected Obj, but got I4
		//IL_0a9e: Expected Obj, but got I
		//IL_0abe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac3: Expected Obj, but got Unknown
		//IL_067a: Expected Obj, but got I4
		//IL_0432: Expected Obj, but got I
		//IL_043d: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got I
		//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adf: Expected Obj, but got Unknown
		//IL_0b0b: Expected Obj, but got I8
		//IL_048d: Expected Obj, but got I
		//IL_0498: Expected Obj, but got I4
		//IL_04c4: Expected Obj, but got I
		//IL_0b31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b36: Expected Obj, but got Unknown
		//IL_0b6a: Expected Obj, but got I4
		//IL_0b80: Expected Obj, but got I
		//IL_0ba0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba5: Expected Obj, but got Unknown
		//IL_04e8: Expected Obj, but got I
		//IL_04f3: Expected Obj, but got I4
		//IL_051f: Expected Obj, but got I
		//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc1: Expected Obj, but got Unknown
		//IL_0bf5: Expected Obj, but got I4
		//IL_0c0b: Expected Obj, but got I
		//IL_0c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Expected Obj, but got Unknown
		//IL_0531: Expected Obj, but got I4
		//IL_053e: Expected Obj, but got I4
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected Obj, but got Unknown
		//IL_0573: Expected Obj, but got I4
		//IL_05af: Expected Obj, but got I
		//IL_0c47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4c: Expected Obj, but got Unknown
		//IL_0c80: Expected Obj, but got I4
		//IL_0c96: Expected Obj, but got I
		//IL_0cb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbb: Expected Obj, but got Unknown
		//IL_059a: Expected Obj, but got I
		//IL_05c4: Expected Obj, but got I
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected Obj, but got Unknown
		//IL_0620: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CAB60]");
		object item = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6E8]");
		object item2 = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6E0]");
		object item3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6F0]");
		object item4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC6F8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = Has(owned, (string)item);
		bool flag3 = Has(owned, (string)item2);
		bool flag4 = Has(owned, (string)item3);
		bool flag5 = Has(owned, (string)item4);
		string text = (string)obj3;
		bool flag6 = Has(owned, (string)obj3);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v17+E4]");
		bool flag7 = (nint)0 == 0;
		object obj6 = !flag7;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v17+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v7+14]");
		bool flag8 = (nint)0 == 0;
		object obj9 = !flag8;
		object obj10 = flag6 ^ obj9;
		object obj11 = obj10 & 1;
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v17+E4]");
			bool flag9 = (nint)0 == 0;
			object obj12 = !flag9;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC778]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC788]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v126+E4]");
			bool flag10 = (nint)0 == 0;
			object obj16 = !flag10;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v126+A0]");
			object obj17 = 0;
			bool flag11 = !flag6;
			object obj18 = !flag11;
			object obj19 = ~obj18;
			object obj20;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				obj20 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC790]");
				obj20 = 0;
			}
			string message = (string)obj14 + (string)obj20 + (string)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			obj8 = 0;
			object obj21 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v114+E4]");
			bool flag12 = (nint)0 == 0;
			object obj22 = !flag12;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message);
			obj5 = obj;
			text = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v17+E4]");
		bool flag13 = (nint)0 == 0;
		object obj23 = !flag13;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v27+E4]");
		bool flag14 = (nint)0 == 0;
		object obj25 = !flag14;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj24 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v27+A0]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA900]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v15+10]");
		bool flag15 = (nint)0 == 0;
		object obj28 = !flag15;
		object obj29 = flag2 ^ obj28;
		object obj30 = obj29 & 1;
		bool flag16 = obj30 == null;
		object obj31 = !flag16;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v27+E4]");
			bool flag17 = (nint)0 == 0;
			object obj32 = !flag17;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v27+E4]");
			bool flag18 = (nint)0 == 0;
			object obj33 = !flag18;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj24 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v27+A0]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v83+11]");
			bool flag19 = (nint)0 == 0;
			object obj35 = !flag19;
			object obj36 = flag3 ^ obj35;
			object obj37 = obj36 & 1;
			bool flag20 = obj37 == null;
			object obj38 = !flag20;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v27+E4]");
				bool flag21 = (nint)0 == 0;
				object obj39 = !flag21;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				obj24 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v27+E4]");
				bool flag22 = (nint)0 == 0;
				object obj40 = !flag22;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj24 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v27+A0]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v91+12]");
				bool flag23 = (nint)0 == 0;
				object obj42 = !flag23;
				object obj43 = flag4 ^ obj42;
				object obj44 = obj43 & 1;
				bool flag24 = obj44 == null;
				object obj45 = !flag24;
				if (obj45 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v27+E4]");
					bool flag25 = (nint)0 == 0;
					object obj46 = !flag25;
					if (obj46 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					obj24 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v27+E4]");
					bool flag26 = (nint)0 == 0;
					object obj47 = !flag26;
					if (obj47 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj24 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v27+A0]");
					object obj48 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v99+13]");
					bool flag27 = (nint)0 == 0;
					object obj49 = !flag27;
					object obj50 = flag5 ^ obj49;
					object obj51 = obj50 & 1;
					if (obj51 == null)
					{
						object obj52 = obj10 & 1;
						bool flag28 = obj52 == null;
						object obj53 = !flag28;
						if (obj53 == null)
						{
							return;
						}
						goto IL_0650;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v27+E4]");
		bool flag29 = (nint)0 == 0;
		object obj54 = !flag29;
		if (obj54 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj55 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v37+E4]");
		bool flag30 = (nint)0 == 0;
		object obj56 = !flag30;
		if (obj56 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj55 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v37+A0]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v37+E4]");
		bool flag31 = (nint)0 == 0;
		object obj58 = !flag31;
		if (obj58 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj55 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v37+A0]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v37+E4]");
		bool flag32 = (nint)0 == 0;
		object obj60 = !flag32;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj55 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v37+A0]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v37+E4]");
		bool flag33 = (nint)0 == 0;
		object obj63 = !flag33;
		if (obj63 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj55 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v37+A0]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array = default;
		if (array.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC780]");
			object obj65 = 0;
			object obj66 = array + 32;
			obj66 = obj65;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X24_v17-8]");
			object obj67 = 0 & 0xFFFFFFFEL;
			if (obj67 != null)
			{
				bool flag34 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC768]");
				object obj68 = 0;
				object obj69 = !flag34;
				object obj70 = ~obj69;
				if (obj70 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					obj68 = 0;
				}
				object obj71 = array + 40;
				obj71 = obj68;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X24_v19-10]");
				bool flag35 = (nint)0 < (nint)2;
				object obj72 = !flag35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X24_v19-10]");
				object obj73 = -2;
				bool flag36 = obj73 == null;
				object obj74 = ~obj72;
				object obj75 = obj74 | flag36;
				if (obj75 == null)
				{
					bool flag37 = !flag3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC758]");
					object obj76 = 0;
					object obj77 = !flag37;
					object obj78 = ~obj77;
					if (obj78 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
						obj76 = 0;
					}
					object obj79 = array + 48;
					obj79 = obj76;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X24_v21-18]");
					object obj80 = 0 & 0xFFFFFFFCL;
					if (obj80 != null)
					{
						bool flag38 = !flag4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC770]");
						object obj81 = 0;
						object obj82 = !flag38;
						object obj83 = ~obj82;
						if (obj83 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
							obj81 = 0;
						}
						object obj84 = array + 56;
						obj84 = obj81;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X24_v23-20]");
						bool flag39 = (nint)0 < (nint)4;
						object obj85 = !flag39;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X24_v23-20]");
						object obj86 = -4;
						bool flag40 = obj86 == null;
						object obj87 = ~obj85;
						object obj88 = obj87 | flag40;
						if (obj88 == null)
						{
							bool flag41 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC760]");
							object obj89 = 0;
							object obj90 = !flag41;
							object obj91 = ~obj90;
							if (obj91 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
								obj89 = 0;
							}
							object obj92 = array + 64;
							obj92 = obj89;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X24_v25-28]");
							bool flag42 = (nint)0 < (nint)5;
							object obj93 = !flag42;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X24_v25-28]");
							object obj94 = -5;
							bool flag43 = obj94 == null;
							object obj95 = ~obj93;
							object obj96 = obj95 | flag43;
							if (obj96 == null)
							{
								object obj97 = flag2 | flag3;
								object obj98 = flag4 | flag5;
								object obj99 = obj97 | obj98;
								object obj100 = obj99 & 1;
								bool flag44 = obj100 == null;
								object obj101 = !flag44;
								object obj102 = ~obj101;
								object obj103;
								if (obj102 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
									obj103 = 0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC750]");
									obj103 = 0;
								}
								object obj104 = array + 72;
								obj104 = obj103;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X20_v10-30]");
								bool flag45 = (nint)0 < (nint)6;
								object obj105 = !flag45;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X20_v10-30]");
								object obj106 = -6;
								bool flag46 = obj106 == null;
								object obj107 = ~obj105;
								object obj108 = obj107 | flag46;
								if (obj108 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9338]");
									object obj109 = 0;
									object obj110 = array + 80;
									obj110 = obj109;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									string message2 = string.Concat(array);
									object obj111 = obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v64+E4]");
									bool flag47 = (nint)0 == 0;
									object obj112 = !flag47;
									if (obj112 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Debug.Log(message2);
									text = null;
									goto IL_0650;
								}
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_0650:
		object obj113 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X0_v23+E4]");
		bool flag48 = (nint)0 == 0;
		object obj114 = !flag48;
		if (obj114 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ModMenu.AttachIfOwner();
	}

	private static bool Has(string[] owned, string item)
	{
		if (owned != null)
		{
			int num = Array.IndexOf((System.__Canon[])(object)owned, (System.__Canon)(object)item);
			int num2 = ~num;
			return (byte)(num2 >> 31) != 0;
		}
		return false;
	}

	private static bool IsOwnerName(string name)
	{
		//IL_0256: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0274: Expected Obj, but got I
		//IL_022f: Expected I4, but got Obj
		//IL_00a3: Expected Obj, but got I8
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I4
		//IL_02b2: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I4
		//IL_01c5: Expected Obj, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_0132: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I4
		bool flag = string.IsNullOrEmpty(name);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v8+A0]");
			object obj5 = 0;
			object obj6 = obj5;
			if (obj5 == null)
			{
				goto IL_0213;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v4+18]");
			if ((nint)0 >= (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v4+18]");
				object obj7 = 0 & 0xFFFFFFFFL;
				object obj8 = obj5 + 32;
				object obj9 = 0;
				while (true)
				{
					bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
					object obj10 = !flag4;
					if (obj10 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X23_v6+v124 @ X22_v7*8]");
					bool flag5 = string.IsNullOrEmpty((string)0);
					bool flag6 = !flag5;
					object obj11 = !flag6;
					if (obj11 != null)
					{
						goto IL_01b5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X23_v6+v124 @ X22_v7*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X23_v6+v124 @ X22_v7*8]");
						string a = ((string)0).Trim();
						if (name != null)
						{
							string b = name.Trim();
							bool flag7 = string.Equals(a, b, (StringComparison)5);
							bool flag8 = !flag7;
							object obj12 = !flag8;
							object obj13 = 0;
							StringComparison stringComparison = (StringComparison)5;
							if (obj12 == null)
							{
								goto IL_01b5;
							}
							return true;
						}
					}
					goto IL_0213;
					IL_01b5:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v4+18]");
					obj7 = 0;
					obj9++;
					object obj14 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v4+18]");
					if ((nint)obj14 < 0)
					{
						continue;
					}
					goto IL_01f7;
				}
				goto IL_0221;
			}
		}
		goto IL_01f7;
		IL_01f7:
		return false;
		IL_0221:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
		IL_0213:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0221;
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I4
		//IL_01dc: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I4
		//IL_01f7: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I4
		//IL_0212: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I4
		//IL_022d: Expected Obj, but got I
		//IL_01be: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I
		//IL_0257: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v14+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v14+A0]");
		object obj6 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v14+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v14+A0]");
		object obj8 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v14+A0]");
		object obj10 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v14+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v14+A0]");
		object obj12 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v14+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v14+A0]");
		object obj14 = (nint)0 + (nint)24;
		obj14 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private static void Report()
	{
		//IL_0010: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC798]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj5 = 0;
		string playerId = NetworkBootstrap.PlayerId;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isOwner = IsOwner;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		string message = string.Format((string)format, playerId, arg);
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
	}

	static ModMenuAccess()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = default;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC7A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj4 = 0;
			object obj5 = obj2 + 32;
			obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v7+A0]");
			object obj7 = 0;
			obj7 = obj2;
			object obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}
}
