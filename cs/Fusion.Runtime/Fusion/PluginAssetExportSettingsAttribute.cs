using System;

namespace Fusion;

public class PluginAssetExportSettingsAttribute(PluginExportOptions options) : Attribute
{
	private PluginExportOptions _003Coptions_003EP = options;

	public PluginExportOptions Options => _003Coptions_003EP;
}
