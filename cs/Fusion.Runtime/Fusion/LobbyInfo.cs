using Cpp2ILInjected;

namespace Fusion;

public class LobbyInfo
{
	private bool IsValid__BackingField;

	private string Name__BackingField;

	private string Region__BackingField;

	public bool IsValid
	{
		get
		{
			return IsValid__BackingField;
		}
		internal set
		{
			IsValid__BackingField = value;
		}
	}

	public string Name
	{
		get
		{
			return Name__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public string Region
	{
		get
		{
			return Region__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	internal void Reset()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_001f: Expected Obj, but got I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got I4
		IsValid__BackingField = false;
		object obj = this + 24;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = this + 32;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
