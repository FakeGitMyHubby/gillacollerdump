using System;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class MonsterCatalog : ScriptableObject
{
	private struct Target
	{
		public Transform head;

		public PlayerRef player;

		public bool local;

		public float voice;

		public GillaDummy dummy;
	}

	public MonsterDirector.Entry[] monsters;

	private static MonsterCatalog loaded;

	public static MonsterCatalog Get()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_011f: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCBB0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA6B8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA6B0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v10+A0]");
			object obj10 = 0;
			object obj11 = default;
			obj10 = obj11;
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+A0]");
		return (MonsterCatalog)0;
	}

	public static MonsterDirector.Entry Of(int monster)
	{
		//IL_0010: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		//IL_0116: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		MonsterCatalog monsterCatalog = Get();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = monsterCatalog != null;
		int num = default;
		object obj4 = num - 1;
		bool flag3 = num < 1;
		MonsterDirector.Entry result = null;
		if (!flag3)
		{
			bool flag4 = !flag2;
			result = null;
			if (!flag4)
			{
				if ((object)monsterCatalog != null)
				{
					MonsterDirector.Entry[] array = monsterCatalog.monsters;
					if (monsterCatalog.monsters != null)
					{
						if (array.Length < num)
						{
							result = null;
						}
						else
						{
							bool flag5 = (nint)obj4 < array.Length;
							object obj5 = !flag5;
							if (obj5 != null)
							{
								goto IL_0159;
							}
							object obj6 = (object)monsterCatalog.monsters + obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v9+20]");
							result = (MonsterDirector.Entry)0;
						}
						goto IL_01a8;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				goto IL_0159;
			}
		}
		goto IL_01a8;
		IL_0159:
		return (MonsterDirector.Entry)(object)new IndexOutOfRangeException();
		IL_01a8:
		return result;
	}

	public MonsterCatalog()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCBB8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 24;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
