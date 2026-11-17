using System;
using Cpp2ILInjected;

namespace Fusion;

public sealed class NetworkObjectSpawnException : Exception
{
	private readonly NetworkObjectTypeId? TypeId__BackingField;

	private readonly NetworkSpawnStatus Status__BackingField;

	public NetworkObjectTypeId? TypeId => TypeId__BackingField;

	public NetworkSpawnStatus Status => Status__BackingField;

	public override string Message
	{
		get
		{
			//IL_0032: Expected Obj, but got I
			//IL_0042: Expected Obj, but got I
			//IL_0015: Expected Obj, but got I
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected Obj, but got Unknown
			//IL_0089: Expected Obj, but got I
			//IL_0099: Expected Obj, but got I
			string text;
			if (Status__BackingField == (NetworkSpawnStatus)2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9B98]");
				object obj = 0;
				text = (string)obj;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7930]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9B90]");
				object format = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object arg = default;
				string text2 = string.Format((string)format, arg);
				NetworkSpawnStatus networkSpawnStatus = Status__BackingField;
				text = text2;
			}
			object obj3 = (_003F?)TypeId__BackingField & 0xFF;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9B80]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9B88]");
				object format2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object arg2 = default;
				string text3 = string.Format((string)format2, arg2);
				string text4 = text + text3;
				text = text4;
			}
			return text;
		}
	}

	public NetworkObjectSpawnException(NetworkSpawnStatus status, NetworkObjectTypeId? id = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5388]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		base._002Ector();
		TypeId__BackingField = id;
		Status__BackingField = status;
	}
}
