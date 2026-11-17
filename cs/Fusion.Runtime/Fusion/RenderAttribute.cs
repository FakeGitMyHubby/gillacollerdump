using System;
using Cpp2ILInjected;

namespace Fusion;

public sealed class RenderAttribute : Attribute
{
	private RenderTimeframe Timeframe__BackingField;

	private RenderSource Source__BackingField;

	private string Method__BackingField;

	public RenderTimeframe Timeframe
	{
		get
		{
			return Timeframe__BackingField;
		}
		set
		{
			Timeframe__BackingField = value;
		}
	}

	public RenderSource Source
	{
		get
		{
			return Source__BackingField;
		}
		set
		{
			Source__BackingField = value;
		}
	}

	public string Method
	{
		get
		{
			return Method__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public RenderAttribute()
	{
	}

	public RenderAttribute(RenderTimeframe timeframe, RenderSource source)
	{
		Timeframe__BackingField = timeframe;
		Source__BackingField = source;
	}
}
