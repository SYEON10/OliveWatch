// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class OliveWatch : ModuleRules
{
	public OliveWatch(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
