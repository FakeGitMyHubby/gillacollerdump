using System;

namespace Fusion;

public class PluginCodeExportSettingsAttribute : Attribute
{
	private readonly PluginExportOptions Options__BackingField;

	public PluginExportOptions Options => Options__BackingField;

	public bool ShouldExport => (byte)(Options__BackingField & (PluginExportOptions)1) != 0;

	public PluginCodeExportSettingsAttribute(PluginExportOptions options)
	{
		Options__BackingField = options;
	}
}
