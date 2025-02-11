// CC BY-NC-SA

using UnrealBuildTool;
using System.Collections.Generic;

public class UPC_ParodyTarget : TargetRules
{
	public UPC_ParodyTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "UPC_Parody" } );
	}
}
