using System;
using Cpp2ILInjected;

namespace Fusion;

public sealed class NetworkedAttribute : Attribute
{
	private string Default__BackingField;

	private bool PluginAuthority__BackingField;

	private bool AllowPrediction__BackingField = true;

	public string Default
	{
		get
		{
			return Default__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public bool PluginAuthority
	{
		get
		{
			return PluginAuthority__BackingField;
		}
		set
		{
			PluginAuthority__BackingField = value;
		}
	}

	public bool AllowPrediction
	{
		get
		{
			return AllowPrediction__BackingField;
		}
		set
		{
			AllowPrediction__BackingField = value;
		}
	}
}
