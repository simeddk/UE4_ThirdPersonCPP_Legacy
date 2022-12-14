// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class U05_MultiPlay : ModuleRules
{
	public U05_MultiPlay(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] 
		{ 
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"HeadMountedDisplay",
			"UMG",
			"OnlineSubSystem",
			"OnlineSubsystemSteam"
		});
	}
}
