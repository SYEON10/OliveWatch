// Copyright Epic Games, Inc. All Rights Reserved.

#include "OliveWatchGameMode.h"
#include "OliveWatchCharacter.h"
#include "UObject/ConstructorHelpers.h"

AOliveWatchGameMode::AOliveWatchGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPerson/Blueprints/BP_FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

}
