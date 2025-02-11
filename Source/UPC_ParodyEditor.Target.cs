// CC BY-NC-SA

using UnrealBuildTool;
using System.Collections.Generic;

public class UPC_ParodyEditorTarget : TargetRules
{
	public UPC_ParodyEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "UPC_Parody" } );
	}
}
