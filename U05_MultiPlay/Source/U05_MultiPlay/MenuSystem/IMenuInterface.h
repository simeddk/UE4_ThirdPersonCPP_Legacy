#pragma once

#include "CoreMinimal.h"
#include "UObject/Interface.h"
#include "IMenuInterface.generated.h"

UINTERFACE(MinimalAPI)
class UIMenuInterface : public UInterface
{
	GENERATED_BODY()
};

class U05_MULTIPLAY_API IIMenuInterface
{
	GENERATED_BODY()

public:
	virtual void Host() = 0;
};
