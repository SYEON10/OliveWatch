// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class OliveWatch : ModuleRules
{
	public OliveWatch(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

	        PublicIncludePaths.AddRange(new string[]
        	{
            		"OliveWatch",
        	});

		PublicDependencyModuleNames.AddRange(new string[]
        	{
            		"Core",
            		"CoreUObject",
            		"Engine",
           		"InputCore",
            		"EnhancedInput",
            		"GameplayTags",
            		"GameplayTasks",
            		"GameplayAbilities",
           		"NavigationSystem",
           		"AIModule",
            		"Niagara",
            		"UMG"
        	});
	}
}
